using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace liga.liga1
{
    public  class eveniment
    {
        public int coduniceveniment;
        public persoana pers;
        public string relatare;
        public string evenimentul;
        public int minutul;

        public eveniment() { }
        public eveniment(int pcoduniceveniment , persoana ppers, string prelatare, string pevenimentul, int pminutul ) 
        {
            coduniceveniment = pcoduniceveniment;
            pers = ppers;
            relatare = prelatare;
            evenimentul = pevenimentul;
            minutul = pminutul;
            
        }


    }
}
