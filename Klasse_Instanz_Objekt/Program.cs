﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasse_Instanz_Objekt
{
	class Program
	{
		static void Main(string[] args)
		{
			//int zahl1;
			// Objekt(-Variable) erzeugen inc. Bezeichner
			// Objekt muss vor Verwendung erzeugt werden.
			
			// Standard Konstruktor wird durch parameterisierten Konstruktor unten überschrieben!
			//Person Man1 = new Person(1);
			Person Man1 = new Person();
			//zahl1 = 33;
			//Man1.altereintragen(zahl1);
			//Man1.Alter = zahl1;
			//zahl1 = Man1.Alter;
			//		Alternativ: zahl1 = Man1.alterlesen();
			// und	Console.Write(zahl1);
			Console.WriteLine(Man1.Alter);
		}
	}

	class Person
	{
		//string nachname;
		//string vorname;
		// prop...
		public string Vorname { get; set; }
		public string Nachname { get; set; }
		public int Alter { get; set; }

		int alter;
		//int jahre;
		
		//get und set
		//public int Alter { get => alter; set => alter = value; }
		//public string Nachname { get => nachname; set => nachname = value; }

		// alter eintragen


		public void altereintragen(int alter)
		{
			
			this.alter = alter;
		}
		// Alter ausgeben/auslesen...
		public int alterlesen()
		{
			return alter;
		}

		/*
		// selber schreiben eines Konstruktors:
		public Person(int alter)
		{
		// F: this.alter vs. this.Alter
		this.Alter = alter;
		}
		*/

		// Stichw. Polymorphie ... hier Überladung, durch Parameterdiff. möglich
		
		/*
		public Person()
		{
		// "Standard-Konstruktor"
		}
		*/

		/*
		public Person(string zahl)
		{
		
		}
		*/

		//public void altereintragen(int jahre)
		//{
		//	Console.WriteLine("Bitte Alter in Jahren eingben:");
		//	jahre = Convert.ToInt32(Console.ReadLine());
		//}
		
	}

}

