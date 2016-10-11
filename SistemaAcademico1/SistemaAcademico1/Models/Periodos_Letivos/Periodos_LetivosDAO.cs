using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using SistemaAcademico1.Models.Periodos_Letivos;
using System.Configuration;

namespace SistemaAcademico1.Models.Periodos_Letivos
{
    public class Periodos_LetivosDAO
    {
         private String conexao;

        public Periodos_LetivosDAO () {
            conexao = ConfigurationManager.ConnectionStrings["StringConexao"].ConnectionString;
        }
    }
}