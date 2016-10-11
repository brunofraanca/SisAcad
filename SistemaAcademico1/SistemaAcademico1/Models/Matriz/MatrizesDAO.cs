using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using SistemaAcademico1.Models.Matriz;
using System.Configuration;

namespace SistemaAcademico1.Models.Matriz
{
    public class MatrizesDAO
    {
         private String conexao;

        public MatrizesDAO () {
            conexao = ConfigurationManager.ConnectionStrings["StringConexao"].ConnectionString;
        }
    }
}