using System;
using System.Collections.Generic;
using System.Text;

namespace VeloxSoft.Config
{
    public static class ObtenerRolEnum
    {
        public static Roles ObtenerRol(string rolNumber)
        {
            return rolNumber switch
            {
                "1" => Roles.Admin,
                "2" => Roles.Crud,
                _ => Roles.Lectura
            };
        }
    }
}
