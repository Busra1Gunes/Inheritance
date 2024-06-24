using KalıtımDersi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalıtım
{
	public class Kaplumbaga:HayvanlarAlemi,IGorevler
	{ //Kalıtım alırken önce sınıf (sadece 1 sınıftan kalıtım alınabilir)yazılır sonra İnterface(LER)
		public int KabuğuOlma { get; set; }
		List<HayvanlarAlemi> hayvanlarAlemi;
        public Kaplumbaga(List<HayvanlarAlemi> _hayvanlarAlemi)
        {
			hayvanlarAlemi = _hayvanlarAlemi;
        }

        public void Yurume()
		{
			//KAplunbağalar yürüyen hayvanlardır
		}

		public List<HayvanlarAlemi> YasamBelirtisi()
		{
			return hayvanlarAlemi;
		}

		public string Yeme()
		{
			//Kamplumbağalar otobur hayvanlardır
			return "Otobur";
		}
	}
}
