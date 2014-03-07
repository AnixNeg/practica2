using System;

namespace proyecto2
{
	class MainClass
	{

		public static void Main (string[] args)
		{
			double iva = 1.16;
			double precio1,precio2,precio3;

			Console.WriteLine ("Ingresa el primer valor");
			float primer=float.Parse (Console.ReadLine ());
			precio1 = primer * iva;
			Console.WriteLine ("El precio normal es:"+ primer);
			Console.WriteLine ("El Precio con iva es:"+ precio1);

			Console.WriteLine ("Ingresa el segundo valor");
			float segundo=float.Parse(Console.ReadLine ());
			precio2 = segundo * iva;
			Console.WriteLine ("El precio normal es:"+ segundo);
		    Console.WriteLine ("El Precio con iva es:" + precio2);


			Console.WriteLine ("Ingresa el tercer valor");
			float tercero=float.Parse(Console.ReadLine ());
			precio3 = tercero * iva;
			Console.WriteLine ("El precio normal es:"+ tercero);
			Console.WriteLine ("El Precio con iva es:" + precio3);

			Console.WriteLine ("Preciona cualquier tecla para salir");
	
		}
	}
}