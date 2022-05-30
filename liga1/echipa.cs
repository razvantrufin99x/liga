using System;
using System.Collections.Generic;
using System.Text;

namespace liga.liga1
{
	public class echipa
	{
		public string sigla;
		public int codunicechipa;
		public string denumire;
		public echipa() { }
		public List<meci> meciurileechipei = new List<meci> { };

		public echipa(string psigla, int pcodunicechipa, string pdenumire) 
		{ 
			sigla = psigla;
			codunicechipa = pcodunicechipa;
			denumire = pdenumire;
		}
	}
}
