
namespace Klasse_Person
{
	class Prog 
	{
		//static void Main(string[] args) 
		//{
		//	Person person = new Person();

		//	//person.name = "Batman";
		//	//person.vorname = "Bat";

		//	//Console.WriteLine($"Name : {person.name} Vorname : {person.vorname}");

		//	person.Eingabe();
		//	person.Ausgabe();
		//	person.GeburtsjahrAusgabe();

		//	Console.ReadKey();
		//}

		//----------------------------------------------------------------------------------------------------------------------------------

		static void Main(string[] args)
		{
			Person[] person_array = new Person[2];

			for(int i = 0; i < person_array.Length; i++)
			{
				Person person = new Person();
				//person.Eingabe();
				person_array[i] = person;

			}

			foreach(var p in person_array)
			{
				p.Ausgabe();
				Console.WriteLine("\n---------------------------\n");
				p.GeburtsjahrAusgabe();
				Console.WriteLine("\n---------------------------\n");
			}

			


			Console.ReadKey();
		}
	}

}