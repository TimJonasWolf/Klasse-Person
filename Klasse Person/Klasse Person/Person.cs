using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasse_Person
{
	internal class Person
	{
		public string name { get; set; }

		public string vorname { get; set; }

		public string adresse { get; set; }
		public int alter { get; set; }
		public string email { get; set; }

		public Person() 
		{
			Eingabe(); 
		}

		//public Person(string N,string v, string A, int al, string EM) 
		//{
		//	name= N;
		//	vorname= v;
		//	adresse= A;
		//	alter= al;
		//	email= EM;
		//}	

		public void Eingabe() 
		{
			try 
			{
				Console.WriteLine("\nGeben sie ihren Namen ein : ");
				name = Console.ReadLine();
				Console.WriteLine("\nGeben sie ihren Vornamen ein : ");
				vorname = Console.ReadLine();
				Console.WriteLine("\nGeben sie ihre Adresse ein : ");
				adresse = Console.ReadLine();
				Console.WriteLine("\nGeben sie ihr Alter ein : ");
				alter = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("\nGeben sie ihre E-Mail ein : ");
				email = Console.ReadLine();
				Console.WriteLine("\n-----------------------------------------------\n");






			}
			catch(Exception ex) 
			{
				Console.WriteLine(ex.Message);
			}
		}
		public void Ausgabe() 
		{
			Console.WriteLine($"Name	: {name}\n" +
							  $"Vorname : {vorname}\n" +
							  $"Adresse : {adresse}\n" +
							  $"Alter	: {alter}\n" +
							  $"E-Mail	: {email}\n" );
		}

		public void GeburtsjahrAusgabe() 
		{ 
			Console.WriteLine($" Ihr Geburtsjahr ist : {2023-alter}");


		}
	}
}
