using System;
using System.Collections.Generic;
using System.Text;

namespace liga.liga1
{
	public class subrecordClasament
	{
		public int m;
		public int v;
		public int e;
		public int i;
		public int gm;
		public int gp;
		public int gol;
		public int adv;
		public int pen;
		public int pct;
		public subrecordClasament() { }
		public int sqlm() { return 0; }
		public int sqlv() { return 0; }
		public int sqle() { return 0; }
		public int sqli() { return 0; }
		public int sqlgm() { return 0; }
		public int sqlgp() { return 0; }
		public int calcgol() { return 0; }
		public int calcadv() { return 0; }
		public void addpenalizari(int p) { this.pen = p; }
		public int calcpct() { return 0; }

	}
}
