using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using SistemaAcademico1.Models.Matricula;
using System.Configuration;

namespace SistemaAcademico1.Models.Matricula
{
    public class MatriculaDAO
    {
          private String conexao;

        public MatriculaDAO () {
            conexao = ConfigurationManager.ConnectionStrings["StringConexao"].ConnectionString;
        }
    }
}