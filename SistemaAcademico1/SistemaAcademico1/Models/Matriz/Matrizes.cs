using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaAcademico1.Models.Matrizes
{
    public class Matrizes
    {
        private Int32 COD_CURSO;
        private Int32 COD_DISC;
        private int periodo;

        public Matrizes() { }
        public Matrizes(Int32 COD_CUR, Int32 COD_DIS)
        {
            this.COD_CURSO = COD_CUR;
            this.COD_DISC = COD_DIS;
        }

        public Int32 COD_CURSO1
        {
            get { return COD_CURSO; }
            set { COD_CURSO = value; }
        }


        public Int32 COD_DISC1
        {
            get { return COD_DISC; }
            set { COD_DISC = value; }
        }

        public int PERIODO1
        {
            get { return periodo; }
            set { periodo = value; }
        }
    }
}