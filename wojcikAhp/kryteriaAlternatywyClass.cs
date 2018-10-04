using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wojcikAhp
{
   public class kryteriaAlternatywyClass
    {
        public int iloscKryteriow;
        public int iloscAlternatyw;

        public kryteriaAlternatywyClass() {
            iloscAlternatyw = 0;
            iloscKryteriow = 0;
        }
        public kryteriaAlternatywyClass(int iloscKryteriow, int iloscAlternatyw)
        {
            iloscKryteriow = this.iloscKryteriow;
            iloscAlternatyw = this.iloscAlternatyw;
           
        }
    }
}
