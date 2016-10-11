using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using SistemaAcademico1.Models.Turmas;
using System.Configuration;
namespace SistemaAcademico1.Models.Turma
{
    public class TurmasDAO
    {
        private String conexao;

        public TurmasDAO () {
            conexao = ConfigurationManager.ConnectionStrings["StringConexao"].ConnectionString;
        }
    }
}