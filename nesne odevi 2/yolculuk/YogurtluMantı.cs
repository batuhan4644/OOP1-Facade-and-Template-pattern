using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yolculuk
{
	class YogurtluMantı : Yemek
	{
		public override void Sudok()
		{
			Console.WriteLine("yogurtlu mantı ıcın su döküldü.");

		}
		public override void Kaynat()
		{
			Console.WriteLine("Yogurtlu mantı ıcın su kaynatıldı.");

		}
		public override void MalzemeEkle()
		{
			Console.WriteLine("Yogurtlu mantı icin malzeme eklendi.");

		}
		public override void YogurtEkle()
		{
			Console.WriteLine("Yogurtlu mantı ıcın yogurt eklendi.");

		}
	}
}
