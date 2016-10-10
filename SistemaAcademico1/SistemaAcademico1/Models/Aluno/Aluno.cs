using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaAcademico1.Models.Aluno
{

    public class Aluno
    {
        private UInt32 Mat_alu;
        private String Nom_alu;
        private UInt32 Tot_cred;
        private DateTime Dat_nasc;
        private Double Mgp;
        private UInt32 Cod_curso;

        public Aluno(UInt32 Mat_alu)
        {
            this.Mat_alu = Mat_alu;
        }

        public UInt32 Mat_alu1
        {
            get { return Mat_alu; }
            set { Mat_alu = value; }
        }

        public String Nom_alu1
        {
            get { return Nom_alu; }
            set { Nom_alu = value; }
        }

        public UInt32 Tot_cred1
        {
            get { return Tot_cred; }
            set { Tot_cred = value; }
        }

        public DateTime Dat_nasc1
        {
            get { return Dat_nasc; }
            set { Dat_nasc = value; }
        }

        public Double Mgp1
        {
            get { return Mgp; }
            set { Mgp = value; }
        }

        public UInt32 Cod_curso1
        {
            get { return Cod_curso; }
            set { Cod_curso = value; }
        }
    }
}