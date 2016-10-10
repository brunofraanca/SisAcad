using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaAcademico1.Models.Matricula
{
    public class Matricula
    {
        private UInt32 ANO;
            private int SEMESTRE;
            private UInt32 Mat_alu;
            private UInt32 COD_DISC;
            private double NOTA_1;
            private double NOTA_2;
            private double NOTA_3;
            private Decimal FALTAS_1;
            private Decimal FALTAS_2;
            private Decimal FALTAS_3;


            public Matricula() { }

            //Get's e Set's
            public UInt32 ANO1
            {
                get { return ANO; }
                set { ANO = value; }
            }
            public int SEMESTRE1
            {
                get { return SEMESTRE; }
                set { SEMESTRE = value; }
            }
            public UInt32 COD_DISC1
            {
                get { return COD_DISC; }
                set { COD_DISC = value; }
            }
            public UInt32 Mat_alu1
            {
                get { return Mat_alu; }
                set { Mat_alu = value; }
            }

            public double NOTA_11
            {
                get { return NOTA_1; }
                set { NOTA_1 = value; }
            }


            public double NOTA_21
            {
                get { return NOTA_2; }
                set { NOTA_2 = value; }
            }

            public double NOTA_31
            {
                get { return NOTA_3; }
                set { NOTA_3 = value; }
            }


            public Decimal FALTAS_11
            {
                get { return FALTAS_1; }
                set { FALTAS_1 = value; }
            }


            public Decimal FALTAS_21
            {
                get { return FALTAS_2; }
                set { FALTAS_2 = value; }
            }

            public Decimal FALTAS_31
            {
                get { return FALTAS_3; }
                set { FALTAS_3 = value; }
            }
    }
}