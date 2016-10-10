using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaAcademico1.Models.Curso
{
    public class Curso
    {
        private Int32 COD_CURSO;
        private String NOM_CURSO;
        private Int32 TOT_CRED;
        private Int16 IDT_PROF;

        public Int32 COD_CURSO1 {
            get { return COD_CURSO; }
            set { COD_CURSO = value; }
        }

        public String NOM_CURSO1
        {
            get { return NOM_CURSO; }
            set { NOM_CURSO = value; }
        }

        public Int32 TOT_CRED1
        {
            get { return TOT_CRED; }
            set { TOT_CRED = value; }
        }

        public Int16 IDT_PROF1
        {
            get { return IDT_PROF; }
            set { IDT_PROF = value; }
        }
    }
}