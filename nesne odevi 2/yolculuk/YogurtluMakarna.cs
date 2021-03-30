using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yolculuk
{
	class YogurtluMakarna : Yemek
	{

		public override void Sudok()
		{
			Console.WriteLine("yogurtlu makarna ıcın su döküldü.");

		}
		public override void Kaynat()
		{
			Console.WriteLine("Yogurtlu makarna ıcın su kaynatıldı.");

		}
		public override void MalzemeEkle()
		{
			Console.WriteLine("Yogurtlu makarna icin malzeme eklendi.");

		}
		public override void YogurtEkle()
		{
			Console.WriteLine("Yogurtlu makarna ıcın yogurt eklendi.");

		}
	}
}
