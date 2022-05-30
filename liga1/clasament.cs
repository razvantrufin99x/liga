using System;
using System.Collections.Generic;
using System.Text;

namespace liga.liga1
{
	public class clasament
	{
		public List<recordClasament> echipe = new List<recordClasament>();
		public int codunicliga;
		public clasament() { }
		public clasament(int pcodunicliga) { 
			codunicliga = pcodunicliga;
		}
	}
}
