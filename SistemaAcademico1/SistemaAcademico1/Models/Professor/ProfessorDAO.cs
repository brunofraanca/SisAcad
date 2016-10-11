using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using SistemaAcademico1.Models.Professor;
using System.Configuration;
namespace SistemaAcademico1.Models.Professor
{
    public class ProfessorDAO
    {
        private String conexao;

        public ProfessorDAO () {
            conexao = ConfigurationManager.ConnectionStrings["StringConexao"].ConnectionString;
        }
    }
}