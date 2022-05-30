using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace liga.liga1
{
    public class persoana
    {
        public string nume;
        public string prenume;
        public DateTime datanasterii;
        public int codunicpersoana;

        public persoana() { }
        public persoana(int pcodunicpersoana, string pnume , string pprenume, DateTime pdatanasterii) 
        { 
            codunicpersoana = pcodunicpersoana;
            nume = pnume;
            prenume = pprenume;
            datanasterii = pdatanasterii;
        
        }
    }
}
