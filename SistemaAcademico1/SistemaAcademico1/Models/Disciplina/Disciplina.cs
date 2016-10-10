using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaAcademico1.Models.Disciplina
{
    public class Disciplinas
    {

        private Int32 COD_DISC;
        private String NOME_DISC;
        private Int32 HORAS_OBRIG;
        private Int32 LIMITE_FALTAS;
        private char TPO_DISC;
        

        public Disciplinas() { }

        public Disciplinas(Int32 COD_DISC)
        {
            this.COD_DISC = COD_DISC;
        }

        public Int32 COD_DISC1
        {
            get { return COD_DISC; }
            set { COD_DISC = value; }
        }

        public String NOME_DISC1
        {
            get { return NOME_DISC; }
            set { NOME_DISC = value; }
        }

        public Int32 CARGA_HORARIA_DISC1
        {
            get { return HORAS_OBRIG; }
            set { HORAS_OBRIG = value; }
        }

        public Int32 LIMITE_FALTAS1
        {
            get { return LIMITE_FALTAS; }
            set { LIMITE_FALTAS = value; }
        }

        public char TPO_DISC1 {
            get { return TPO_DISC; }
            set { TPO_DISC = value; }
        }

    }
}