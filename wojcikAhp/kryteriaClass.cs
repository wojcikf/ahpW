using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wojcikAhp
{
    class kryteriaClass
    {
        public int id = 0;
        public string nazwaKryterium;

        public kryteriaClass()
        {
            id = 0;
            nazwaKryterium = "Nazwa";
        }

        public kryteriaClass(int id, string nazwaKryterium)
        {
            id = this.id;
            nazwaKryterium = this.nazwaKryterium;
            id++;
        }
    }
}
