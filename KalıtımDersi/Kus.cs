using KalıtımDersi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalıtım
{
	public class Kus:HayvanlarAlemi,IGorevler
	{
        public int Ucma { get; set; }
        public int Kanatlar { get; set; }

		public List<HayvanlarAlemi> YasamBelirtisi()
		{
			throw new NotImplementedException();
		}

		public string Yeme()
		{
			throw new NotImplementedException();
		}

		public void Yurume()
		{
			throw new NotImplementedException();
		}
	}
}
