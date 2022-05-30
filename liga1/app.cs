using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace liga.liga1
{
    public  class app
    {

        public List<liga> Ligi = new List<liga>();

        public liga liga1romania = new liga("Liga 1 Casa Pariurilor", 1, "Romania", 2022);

        public void addLiga2Ligi(ref liga l)
        { 
            Ligi.Add(l);
        }

        public void addEchipeLiga1()
        {
            liga1romania.echipe.Add(new echipa("CFRCLUJ.jpeg", 1, "CFR CLUJ"));
            liga1romania.echipe.Add(new echipa("FCSB.jpeg", 2, "FCSB"));
            liga1romania.echipe.Add(new echipa("CSUCRAIOVA.jpeg", 3, "CSU CRAIOVA"));
            liga1romania.echipe.Add(new echipa("VOLUNTARI.jpeg", 4, "VOLUNTARI"));
            liga1romania.echipe.Add(new echipa("ARGES.jpeg", 5, "ARGES"));
            liga1romania.echipe.Add(new echipa("FARUL.jpeg", 6, "FARUL"));
            liga1romania.echipe.Add(new echipa("SEPSI.jpeg", 7, "SEPSI"));
            liga1romania.echipe.Add(new echipa("BOTOSANI.jpeg", 8, "BOTOSANI"));
            liga1romania.echipe.Add(new echipa("RAPID.jpeg", 9, "RAPID"));
            liga1romania.echipe.Add(new echipa("CHINDIA.jpeg", 10, "CHINDIA"));
            liga1romania.echipe.Add(new echipa("MIOVENI.jpeg", 11, "MIOVENI"));
            liga1romania.echipe.Add(new echipa("UTA.jpeg", 12, "UTA"));
            liga1romania.echipe.Add(new echipa("FCUCRAIOVA.jpeg", 13, "FCUCRAIOVA"));
            liga1romania.echipe.Add(new echipa("PETROLUL.jpeg", 14, "PETROLUL"));
            liga1romania.echipe.Add(new echipa("HERMANNSTADT.jpeg", 15, "HERMANNSTADT"));
            liga1romania.echipe.Add(new echipa("UCLUJ.jpeg", 16, "U CLUJ"));
         
        }

        public void addMeciuriLiga1()
        {
            //eg - eo - nrmeci - etapa - partea de sezon - data si ora
            //sample etapa 1 sezon regular exemplu not real
            liga1romania.meciuri.Add(new meci(liga1romania.echipe[1 - 1], liga1romania.echipe[2 - 1], 1, 1, "SEZON REGULAR", DateTime.Now));
            liga1romania.meciuri.Add(new meci(liga1romania.echipe[3 - 1], liga1romania.echipe[4 - 1], 2, 1, "SEZON REGULAR", DateTime.Now));
            liga1romania.meciuri.Add(new meci(liga1romania.echipe[5 - 1], liga1romania.echipe[6 - 1], 3, 1, "SEZON REGULAR", DateTime.Now));
            liga1romania.meciuri.Add(new meci(liga1romania.echipe[7 - 1], liga1romania.echipe[8 - 1], 4, 1, "SEZON REGULAR", DateTime.Now));
            liga1romania.meciuri.Add(new meci(liga1romania.echipe[9 - 1], liga1romania.echipe[10 - 1], 5, 1, "SEZON REGULAR", DateTime.Now));
            liga1romania.meciuri.Add(new meci(liga1romania.echipe[11 - 1], liga1romania.echipe[12 - 1], 6, 1, "SEZON REGULAR", DateTime.Now));
            liga1romania.meciuri.Add(new meci(liga1romania.echipe[13 - 1], liga1romania.echipe[14 - 1], 7, 1, "SEZON REGULAR", DateTime.Now));
            liga1romania.meciuri.Add(new meci(liga1romania.echipe[15 - 1], liga1romania.echipe[16 - 1], 8, 1, "SEZON REGULAR", DateTime.Now));

        }

        public int searchMeciAfterCoduUnicMeciInListaMeciuri( ref List<meci> meciurile , int pcodunicmeci)
        {
            for (int i = 0; i < meciurile.Count; i++)
            { 
                if(meciurile[i].codunicmeci == pcodunicmeci)
                { return i;}
            }
            return -1;
        }
        public void addInformatiiMeciFinal(int pcodunicmeci, int pgg, int pgo)
        { 
            liga1romania.meciuri[searchMeciAfterCoduUnicMeciInListaMeciuri(ref liga1romania.meciuri, pcodunicmeci)].gg = pgg;
            liga1romania.meciuri[searchMeciAfterCoduUnicMeciInListaMeciuri(ref liga1romania.meciuri, pcodunicmeci)].go = pgo;

        }
        public void addInformatiiPauza(int pcodunicmeci, int pggp, int pgop)
        {
            liga1romania.meciuri[searchMeciAfterCoduUnicMeciInListaMeciuri(ref liga1romania.meciuri, pcodunicmeci)].ggp = pggp;
            liga1romania.meciuri[searchMeciAfterCoduUnicMeciInListaMeciuri(ref liga1romania.meciuri, pcodunicmeci)].gop = pgop;
        }
        public void addInformatiiPrelungiriMeci(int pcodunicmeci , int pggpr, int pgopr)
        {
            liga1romania.meciuri[searchMeciAfterCoduUnicMeciInListaMeciuri(ref liga1romania.meciuri, pcodunicmeci)].ggpr = pggpr;
            liga1romania.meciuri[searchMeciAfterCoduUnicMeciInListaMeciuri(ref liga1romania.meciuri, pcodunicmeci)].gopr = pgopr;
        }
        public void addInformatiiPenaltiuriMeci(int pcodunicmeci, int pggpen, int pgopen)
        {
            liga1romania.meciuri[searchMeciAfterCoduUnicMeciInListaMeciuri(ref liga1romania.meciuri, pcodunicmeci)].ggpen = pggpen;
            liga1romania.meciuri[searchMeciAfterCoduUnicMeciInListaMeciuri(ref liga1romania.meciuri, pcodunicmeci)].gopen = pgopen;
        }

    }
}
