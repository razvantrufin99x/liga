using System;
using System.Collections.Generic;
using System.Text;

namespace liga.liga1
{
	public class subrecordClasament
	{
		public char tad;

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
		public subrecordClasament(char ptad) { tad = ptad; }

		public void sqlm(ref List<meci> meciurile, int pcodunicechipa)
		{
			this.m = 0;
			if (this.tad == 'A' || this.tad == 'a')
			{
				for (int i = 0; i < meciurile.Count; i++)
				{
					if (meciurile[i].eg.codunicechipa == pcodunicechipa)
					{
						m += 1;
					}
				}
			}
			if (this.tad == 'D' || this.tad == 'd')
			{
				for (int i = 0; i < meciurile.Count; i++)
				{
					if (meciurile[i].eo.codunicechipa == pcodunicechipa)
					{
						m += 1;
					}
				}
			}
		}
		public void sqlv(ref List<meci> meciurile, int pcodunicechipa)
		{
			this.v =0 ;
			if (this.tad == 'A' || this.tad == 'a')
			{
				for (int i = 0; i < meciurile.Count; i++)
				{
					if (meciurile[i].eg.codunicechipa == pcodunicechipa)
					{
						if(gm > gp) v += 1;
					}
				}
			}
			if (this.tad == 'D' || this.tad == 'd')
			{
				for (int i = 0; i < meciurile.Count; i++)
				{
					if (meciurile[i].eo.codunicechipa == pcodunicechipa)
					{
						if (gm < gp) v += 1;
					}
				}
			}
		}
		public void sqle(ref List<meci> meciurile, int pcodunicechipa)
		{
			this.e =0;
			if (this.tad == 'A' || this.tad == 'a')
			{
				for (int i = 0; i < meciurile.Count; i++)
				{
					if (meciurile[i].eg.codunicechipa == pcodunicechipa)
					{
						if (gm == gp) e += 1;
					}
				}
			}
			if (this.tad == 'D' || this.tad == 'd')
			{
				for (int i = 0; i < meciurile.Count; i++)
				{
					if (meciurile[i].eo.codunicechipa == pcodunicechipa)
					{
						if (gm == gp) e += 1;
					}
				}
			}
		}
		public void sqli(ref List<meci> meciurile, int pcodunicechipa) 
		{
			this.i =0;
			if (this.tad == 'A' || this.tad == 'a')
			{
				for (int i = 0; i < meciurile.Count; i++)
				{
					if (meciurile[i].eg.codunicechipa == pcodunicechipa)
					{
						if (gm < gp) e += 1;
					}
				}
			}
			if (this.tad == 'D' || this.tad == 'd')
			{
				for (int i = 0; i < meciurile.Count; i++)
				{
					if (meciurile[i].eo.codunicechipa == pcodunicechipa)
					{
						if (gm > gp) e += 1;
					}
				}
			}
		}
		public void sqlgm(ref List<meci> meciurile, int pcodunicechipa)
		{
			this.gm =0;
			if (this.tad == 'A' || this.tad == 'a')
			{
				for (int i = 0; i < meciurile.Count; i++)
				{
					if (meciurile[i].eg.codunicechipa == pcodunicechipa)
					{
						gm += meciurile[i].gg;
					}
				}
			}
			if (this.tad == 'D' || this.tad == 'd')
			{
				for (int i = 0; i < meciurile.Count; i++)
				{
					if (meciurile[i].eo.codunicechipa == pcodunicechipa)
					{
						gm += meciurile[i].go;
					}
				}
			}
		}
		public void sqlgp(ref List<meci> meciurile, int pcodunicechipa) 
		{
			this.gp =0;
			if (this.tad == 'A' || this.tad == 'a')
			{
				for (int i = 0; i < meciurile.Count; i++)
				{
					if (meciurile[i].eg.codunicechipa == pcodunicechipa)
					{
						gp += meciurile[i].go;
					}
				}
			}
			if (this.tad == 'D' || this.tad == 'd')
			{
				for (int i = 0; i < meciurile.Count; i++)
				{
					if (meciurile[i].eo.codunicechipa == pcodunicechipa)
					{
						gp += meciurile[i].gg;
					}
				}
			}
		}

		public void calcgol() { gol=gp-gp ; }
		public void calcadv() {
			if (tad == 'A' || tad == 'a') { this.adv = i * 3 + e * 2; }
			else if (tad == 'D' || tad == 'd') { this.adv = v * 3 + e * 1; }
			else if (tad == 'T' || tad == 't') { this.adv = 0; }
			else { this.adv = 0; }
		}

		public void calcClasamentTotal(ref subrecordClasament A, ref subrecordClasament D)
		{
			if (this.tad == 'T' || this.tad == 't')
			{
				m = A.m + D.m;
				v = A.v + D.v;
				e = A.e + D.e;
				i = A.i + D.i;
				gm = A.gm + D.gm;
				gp = A.gp + D.gp;
				gol = A.gol + D.gol;
				adv = A.adv + D.adv;
				pct = A.pct + D.pct;
			}
			else
			{ 
				//error nu este un clasament totalizator 
			}
		}

		public bool odd(int x) { if (x % 2 == 0) return true; else return false; }
		public int half(int x)
		{
			if (odd(x) == true)
			{
				return x / 2;
			}
			else
			{
				return ((x + 1) / 2);
			}
		}
		public int calculeazaPunctajulInjumatatitCuAdaugare()
		{
			return this.half(this.pct);
		}

		public void addpenalizari(int p) { this.pen = p; }
		public void calcpct() {  pct = this.v * 3 + this.e; }

	}
}
