using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yolculuk
{
	class YogurtluEriste : Yemek
	{
		public override void Sudok()
		{
			Console.WriteLine("yogurtlu eriste ıcın su döküldü.");

		}
		public override void Kaynat()
		{
			Console.WriteLine("Yogurtlu eriste ıcın su kaynatıldı.");

		}
		public override void MalzemeEkle()
		{
			Console.WriteLine("Yogurtlu eriste icin malzeme eklendi.");

		}
		public override void YogurtEkle()
		{
			Console.WriteLine("Yogurtlu eriste ıcın yogurt eklendi.");

		}
	}
}
