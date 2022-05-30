using System;
using System.Collections.Generic;
using System.Text;

namespace liga.liga1
{
	public class recordClasament
	{
		public int codunicechipa;
		public int locul;
		public int codunicliga;
		public subrecordClasament totalSRC = new subrecordClasament();
		public subrecordClasament acasa = new subrecordClasament();
		public subrecordClasament deplasare = new subrecordClasament();
		public recordClasament() { }
		public recordClasament(int pcodunicechipa, int pcodunicliga) {
			codunicechipa = pcodunicechipa;
			codunicliga = pcodunicliga;
		}
	}
}
