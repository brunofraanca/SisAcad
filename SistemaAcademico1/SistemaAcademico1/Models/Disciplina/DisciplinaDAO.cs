using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using SistemaAcademico1.Models.Disciplina;
using System.Configuration;

namespace SistemaAcademico1.Models.Disciplina
{
    public class DisciplinaDAO{ 
        
         private String conexao;

        public DisciplinaDAO () {
            conexao = ConfigurationManager.ConnectionStrings["StringConexao"].ConnectionString;
        }
    }
}