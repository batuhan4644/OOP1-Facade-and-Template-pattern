using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yolculuk
{
	public class YolculukFacade
	{

		Bilet bilet =new Bilet() ;
		Bavul bavul = new Bavul();
		Yemek yemek = new Yemek();
		Icecek ıcecek = new Icecek();
		Araba araba = new Araba();
		Otel otel = new Otel();


		public void tatileGit()
		{
			Console.WriteLine("----TATİLE GİDİLİYOR---- ");
			Console.WriteLine("");
			bilet.GidisBiletiAra();
			bilet.GidisBiletiBul();
			bilet.GidisBiletiAl();
			bavul.EsyaSec();
			bavul.EsyaHazırla();
			bavul.EsyaYerlestir();
			yemek.Hazırla();
			ıcecek.IcecekSatınAl();
			ıcecek.Icecekıc();
			araba.BagacAc();
			araba.BagajaYerlestir();
			araba.BagajKapat();
			araba.GidisBenzin();
			otel.OteleGit();
			otel.OteleYerles();
			Console.WriteLine("");
			Console.WriteLine("");
		}

		

		public void tatiliBitir()
		{
			Console.WriteLine("----TATİLDEN DONULUYOR---- ");
			Console.WriteLine("");
			bilet.DonusBiletiAra();
			bilet.DonusBiletiBul();
			bilet.DonusBiletiAl();
			bavul.EsyaYerlestir();
			otel.OtelParasıOde();
			otel.OteldenAyrıl();
			araba.BagacAc();
			araba.BagajaYerlestir();
			araba.BagajKapat();
			ıcecek.IcecekCopeAt();
			bavul.EsyaBosalt();
			Console.WriteLine("");
			Console.WriteLine("");


		}
		public void Yemekye()
		{
			Console.WriteLine("---- YEMEK YE ---- ");
			Console.WriteLine("");
			yemek.Hazırla();
			Console.WriteLine("");
			Console.WriteLine("");
		}
		public void Icecekicme()
		{
			Console.WriteLine("---- ICECEK IC ---- ");
			Console.WriteLine("");
			ıcecek.IcecekSec();
			ıcecek.IcecekSatınAl();
			ıcecek.Icecekıc();
			Console.WriteLine("");
			Console.WriteLine("");
		}
		public void IcecekBitir()
		{
			Console.WriteLine("---- ICECEK BITIR ---- ");
			ıcecek.IcecekCopeAt();
			Console.WriteLine("");
			Console.WriteLine("");

		}




	}
}
