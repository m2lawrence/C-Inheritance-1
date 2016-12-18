//Reusing Existing Code with Inheritance1.
using System;
using System.Text;

namespace MikesInheritance1
{
	class Person
	{
		private string firstName;
		private string middleName;
		private string lastName;
		private int age;
		
		//Add properties to access the data members.
		
		public Person()
		{
		}
		
		public Person(string fn, string ln)
		{
			firstName=fn;
			lastName=ln;
		}
		
		public Person(string fn, string mn, string ln)
		{
			firstName=fn;
			middleName=mn;
			lastName=ln;
		}
		
		public Person(string fn, string mn, string ln, int a)
		{
			firstName=fn;
			middleName=mn;
			lastName=ln;
			age=a;
		}
		
		public void displayAge()
		{
			Console.WriteLine("Age {0}", age);
		}
		
		public void displayFullName()
		{
			StringBuilder FullName = new StringBuilder();
			
			FullName.Append(firstName);
			FullName.Append(" ");
			if (middleName != "") 
			{
				FullName.Append(middleName[0]);
				FullName.Append(". ");
			}
			FullName.Append(lastName);
			
			Console.WriteLine(FullName);		
		}
	}
	
	//NameApp class, illustrates the use of the Person class.
	class NameApp
	{
		public static void Main()
		{
			Person me = new Person("Mike", "Jacques", "Lawrence");
			Person girl = new Person("Melissa", "Anne", "Jones", 21);
			
			me.displayFullName();
			me.displayAge();
			
			girl.displayFullName();
			girl.displayAge();
			
			Console.ReadKey(true);
		}
	}
}