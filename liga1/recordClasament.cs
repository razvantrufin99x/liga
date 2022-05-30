using System;
using System.Collections.Generic;
using System.Text;

namespace liga.liga1
{
	public class recordClasament
	{
		public int codunicechipa;
		public int locul;
		public subrecordClasament totalSRC = new subrecordClasament('T');
		public subrecordClasament acasa = new subrecordClasament('A');
		public subrecordClasament deplasare = new subrecordClasament('D');
		public recordClasament() { }
		public recordClasament(int pcodunicechipa) {
			codunicechipa = pcodunicechipa;
			
		}
	}
}
