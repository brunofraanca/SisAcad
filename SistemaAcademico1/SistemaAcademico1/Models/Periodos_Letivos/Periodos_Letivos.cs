using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaAcademico1.Models.Periodos_Letivos
{
    public class Periodos_Letivos
    {
        private int ANO;
        private int SEMESTRE;
        private string DAT_INI;
        private string DAT_FIM;

        public Periodos_Letivos() { }

        public int ANO1
        {
            get { return ANO; }
            set { ANO = value; }
        }
        public int SEMESTRE1
        {
            get { return SEMESTRE; }
            set { SEMESTRE = value; }
        }
        public String DAT_INI1
        {
            get { return DAT_INI; }
            set { DAT_INI = value; }
        }
        public String DAT_FIM1
        {
            get { return DAT_FIM; }
            set { DAT_FIM = value; }
        }
    }
}