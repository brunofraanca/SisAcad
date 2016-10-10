using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaAcademico1.Models.Turmas
{
    public class Turmas
    {
        
        private Int32 ANO;
        private int SEMESTRE;
        private Int32 COD_DISC;
        private Int32 VAGAS;
        private Int32 idt_prof;

        public Int32 ANO1
        {
            get { return ANO; }
            set { ANO = value; }
        }
        public int SEMESTRE1
        {
            get { return SEMESTRE; }
            set { SEMESTRE = value; }
        }
        public Int32 COD_DISC1
        {
            get { return COD_DISC; }
            set { COD_DISC = value; }
        }
        public Int32 VAGAS1 {
            get { return VAGAS; }
            set { VAGAS = value; }
        }
        public Int32 idt_prof1
        {
            get { return idt_prof; }
            set { idt_prof = value; }
        }
    }
}