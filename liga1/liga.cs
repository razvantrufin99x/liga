using System;
using System.Collections.Generic;
using System.Text;

namespace liga.liga1
{
	public class liga
	{
		public string denumire;
		public int codunicliga;
		public List<echipa> echipe = new List<echipa>();
		public string tara;
		public int sezonul;
		public DateTime datastart;
		public DateTime datatfinal;
		public List<meci> meciuri = new List<meci>();
		public liga() { }
		public liga(string pdenumire, int pcodunicliga, string ptara, int psezonul) 
		{ 
			denumire = pdenumire;
			codunicliga = pcodunicliga;
			tara = ptara;
			sezonul = psezonul;
		}
	}
}
