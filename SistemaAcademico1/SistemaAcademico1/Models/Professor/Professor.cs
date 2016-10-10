using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaAcademico1.Models.Professor
{
    public class Professores
    {
        private Int32 Mat_prof;
        private Int32 idt_prof;
        private String nom_prof;

        
        public Int32 Mat_prof1
        {
            get { return Mat_prof; }
            set { Mat_prof = value; }
        }

        public Int32 idt_prof1
        {
            get { return idt_prof; }
            set { idt_prof = value; }
        }

        public String nom_prof1
        {
            get { return nom_prof; }
            set { nom_prof = value; }
        }
    }
}