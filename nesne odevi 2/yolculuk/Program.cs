using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yolculuk
{
	class Program
	{
		static void Main(string[] args)
		{

			YolculukFacade yolculuk = new YolculukFacade();
			yolculuk.tatileGit();

			YolculukFacade yolculuk2 = new YolculukFacade();
			yolculuk.tatiliBitir();

			YolculukFacade yolculuk3 = new YolculukFacade();
			yolculuk.Yemekye();

			YolculukFacade yolculuk4 = new YolculukFacade();
			yolculuk.Icecekicme();

			YolculukFacade yolculuk5 = new YolculukFacade();
			yolculuk.IcecekBitir();

			Console.WriteLine("----------------------------------");
			Console.WriteLine("----------------------------------");
			Console.WriteLine("----------------------------------");
			Console.WriteLine("----------------------------------");

			Console.WriteLine(" YOGURTLU MAKARNA ");


			            YogurtluMakarna yogurtlumakarna = new YogurtluMakarna();
			            yogurtlumakarna.Hazırla();
			Console.WriteLine("----------------------------------");
			Console.WriteLine("----------------------------------");
			Console.WriteLine("----------------------------------");
			Console.WriteLine("----------------------------------");


			Console.WriteLine(" YOGURTLU MANTI ");


			            YogurtluMantı yogurtlumantı = new YogurtluMantı();
			            yogurtlumantı.Hazırla();


			Console.WriteLine("----------------------------------");
			Console.WriteLine("----------------------------------");
			Console.WriteLine("----------------------------------");
			Console.WriteLine("----------------------------------");
			Console.WriteLine(" YOGURTLU ERİSTE ");


			            YogurtluEriste yogurtlueriste = new YogurtluEriste();
			            yogurtlumakarna.Hazırla();

			Console.ReadLine();

		}
	}
}
