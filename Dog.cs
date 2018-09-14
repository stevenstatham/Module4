using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
	enum Gender
	{
		Male,
		Female
	}
	class Dog
	{
		protected string name;
		protected string owner;
		protected int age;
		protected Gender gender;
		public Dog(string n, string o, int a, Gender g)
		{
			name = n;
			owner = o;
			age = a;
			gender = g;
		}
		public void Bark(int n)
		{
			for (int count = 0; count < n; count++)
			{
				Console.WriteLine("Woof!");
			}
			Console.ReadLine();
		}
		public void GetTag()
		{
			string i;
			string j;
			string k;
			if (gender == Gender.Male)
			{
				i = "His";
				j = "He";
			}
			else
			{
				i = "Her";
				j = "she";
			}
			if (age == 1)
			{
				k = "year";
			}
			else
			{
				k = "years";
			}
			Console.WriteLine("If lost, call {0}. {1} name is {2} and {3} is {4} {5} old.", owner, i, name, j, age, k);
			Console.ReadLine();
		}
	}
	class MakeDog
	{
		static void Main(string[] args)
		{
			Dog p = new Dog("Pluto", "Goofy", 8, Gender.Male);
			p.Bark(5);
			p.GetTag();

			Dog s = new Dog("Skip", "Sarah", 1, Gender.Male);
			s.Bark(8);
			s.GetTag();

			Dog n = new Dog("Navi", "Jake", 4, Gender.Female);
			n.Bark(1);
			n.GetTag();
		}
	}
}
