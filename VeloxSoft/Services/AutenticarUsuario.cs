using Npgsql;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using VeloxSoft.Config;
using VeloxSoft.Models;
using System.Security.Cryptography;
using Konscious.Security.Cryptography;


namespace VeloxSoft.Services
{
    public class AutenticarUsuario
    {
        private readonly DatabaseConfig _dbConfig;

        public AutenticarUsuario(DatabaseConfig dbConfig)
        {
            _dbConfig = dbConfig;
        }

        public Usuario Autenticar(string username, string password, out string errorMessage)
        {
            errorMessage = null;
            try
            {
                var conn = new NpgsqlConnection(_dbConfig.GetConnection(Roles.Lectura));
                conn.Open();

                using var cmd = new NpgsqlCommand(
                    "SELECT * FROM comp_usuario(@user)", conn);

                long userId = long.Parse(username);
                cmd.Parameters.AddWithValue("@user", userId);

                using var reader = cmd.ExecuteReader();

                if (!reader.Read())
                {
                    errorMessage = "Credenciales Invalidas";
                    return Error();
                }

                string result = reader.GetString(0);
                var parts = result.Split('|');

                if (parts[0] == "ERROR")
                {
                    errorMessage = parts[1];
                    return Error();
                }

                string hash = parts[1];

                MessageBox.Show(HashPassword(password), hash);

                if (!VerifyPassword(password, hash))
                {
                    errorMessage = "Credenciales Invalidas";
                    return Error();
                }


                return ObtenerDato(userId, out errorMessage);
            }
            catch(PostgresException e)
            {
                errorMessage = "Error inesperado porfavor intente nuevamente";
                return Error();    
            }
        }

        public Usuario ObtenerDato(long username, out string errorMessage)
        {
            errorMessage = null;
            var conn = new NpgsqlConnection(_dbConfig.GetConnection(Roles.Lectura));
            conn.Open();

            using var cmd = new NpgsqlCommand(
                "SELECT * FROM inc_usuario(@user)", conn);


            cmd.Parameters.AddWithValue("@user", username);


            using var reader = cmd.ExecuteReader();


            if (!reader.Read())
            {
                errorMessage = "Error inesperado porfavor intente nuevamente";
                return Error();
            }

            return new Usuario
            {
                Id = reader.GetInt64(0),
                Nombre = reader.GetString(1),
                Rol = reader.GetString(3)
            };
        }

        public Usuario Error()
        {
            return new Usuario
            {
                Id = 0,
                Nombre = "Error",
                Rol = "Error"
            };
        }

        public static bool VerifyPassword(string password, string storedHash)
        {

            byte[] decoded = Convert.FromBase64String(storedHash);
            byte[] salt = new byte[16];
            byte[] hash = new byte[32];

            Buffer.BlockCopy(decoded, 0, salt, 0, 16);
            Buffer.BlockCopy(decoded, 16, hash, 0, 32);

            var argon2 = new Argon2id(Encoding.UTF8.GetBytes(password))
            {
                Salt = salt,
                DegreeOfParallelism = 8,
                Iterations = 4,
                MemorySize = 1024 * 64
            };

            byte[] newHash = argon2.GetBytes(32);

            return CryptographicOperations.FixedTimeEquals(hash, newHash);
        }

        public static string HashPassword(string password)
        {
            // Generar salt aleatorio
            byte[] salt = RandomNumberGenerator.GetBytes(16);

            var argon2 = new Argon2id(Encoding.UTF8.GetBytes(password))
            {
                Salt = salt,
                DegreeOfParallelism = 8, // núcleos
                Iterations = 4,
                MemorySize = 1024 * 64 // 64 MB
            };

            byte[] hash = argon2.GetBytes(32);

            // Combinar salt + hash
            byte[] result = new byte[salt.Length + hash.Length];
            Buffer.BlockCopy(salt, 0, result, 0, salt.Length);
            Buffer.BlockCopy(hash, 0, result, salt.Length, hash.Length);

            return Convert.ToBase64String(result);
        }

    }
}
