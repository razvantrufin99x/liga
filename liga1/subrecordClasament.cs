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
		public void sqlm() { m=0 ; }
		public void sqlv() { v=0 ; }
		public void sqle() {  e=0; }
		public void sqli() {  i=0; }
		public void sqlgm() {  gm=0; }
		public void sqlgp() {  gp=0; }
		public void calcgol() { gol=gp-gp ; }
		public void calcadv() {   }
		public void addpenalizari(int p) { this.pen = p; }
		public void calcpct() {  pct = this.v * 3 + this.e; }

	}
}
