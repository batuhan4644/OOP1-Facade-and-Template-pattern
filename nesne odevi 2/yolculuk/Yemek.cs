using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yolculuk
{
	class Yemek
	{
		public virtual void Hazırla()
		{
			Console.WriteLine("Yemek hazırlandı.");
			this.Sudok();
			this.Kaynat();
			this.MalzemeEkle();
			this.YogurtEkle();


		}
		public virtual void Sudok()
		{
			Console.WriteLine("Su döküldü.");

		}
		public virtual void Kaynat()
		{
			Console.WriteLine("Su kaynatıldı.");

		}
		public virtual void MalzemeEkle()
		{
			Console.WriteLine("Malzemeler eklendi.");

		}
		public virtual void YogurtEkle()
		{
			Console.WriteLine("Yoğurt eklendi.");

		}

	}
}
