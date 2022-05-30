using System;
using System.Collections.Generic;
using System.Text;

namespace liga.liga1
{
	public class meci
	{
		public echipa eg;
		public int gg;
		public int go;
		public int ggp;
		public int gop;
		public echipa eo;
		public int codunicmeci;
		public int etapa;
		public string partea;

		public int ggpr;
		public int gopr;
		public int ggpen;
		public int gopen;

		public DateTime data;

		public List<eveniment> evenimente = new List<eveniment>();
		public void addEveniment(eveniment ev) 
		{
			evenimente.Add(ev);
		}
		public meci() { }
		public meci(echipa peg, echipa peo, int pcodunicmeci, int petapa, string ppartea, DateTime pdata) 
		{
			eg = peg;
			eo= peo;
			codunicmeci = pcodunicmeci;
			etapa = petapa;
			partea = ppartea;
			data = pdata;
		}
	}
}
