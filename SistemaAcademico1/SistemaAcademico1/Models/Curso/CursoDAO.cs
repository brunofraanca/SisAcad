using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using SistemaAcademico1.Models.Curso;
using System.Configuration;

namespace SistemaAcademico1.Models.Curso
{
    public class CursoDAO
    {
         private String conexao;

        public CursoDAO () {
            conexao = ConfigurationManager.ConnectionStrings["StringConexao"].ConnectionString;
        }
    }
}