using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using SistemaAcademico1.Models.Aluno;
using System.Configuration;

namespace SistemaAcademico1.Models.Aluno
{
    public class AlunoDAO
    {
        private String conexao;

        public AlunoDAO () {
            conexao = ConfigurationManager.ConnectionStrings["StringConexao"].ConnectionString;
        }
    }
}