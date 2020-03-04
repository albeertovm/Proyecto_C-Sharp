using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Dapper;

namespace Proyecto {
    public class SqliteAccesoDatos {

        public static List<string> datos() {
            var xd = Directory.GetCurrentDirectory() + "\\bdemperatriz.db";
            string cs = @"URI=file:" + xd;
            using (IDbConnection conexion = new SQLiteConnection(cs)) {
                var respuesta = conexion.Query<String>("SELECT nombre FROM Productos;", new DynamicParameters());
                return respuesta.ToList();
            }
        }
    }
}
