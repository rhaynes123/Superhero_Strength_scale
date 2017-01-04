using System;

namespace Superhero_Strength_scale
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			SuperHero MeasuredHero = new SuperHero();
			//This cycle of statements lists out the strength level of a character
			Console.WriteLine("How much can you lift? in Pounds");
			MeasuredHero.weightlimit_p = int.Parse(Console.ReadLine());
			Console.WriteLine("How much can you lift? in tons");
			MeasuredHero.weightlimit_t = Convert.ToInt32(Console.ReadLine());
			if (MeasuredHero.weightlimit_p > 150 && MeasuredHero.weightlimit_p < 200)
				Console.WriteLine("Normal human: 2 ");
			if (MeasuredHero.weightlimit_p >= 200 && MeasuredHero.weightlimit_p <300)
				Console.WriteLine("Athletic: 3 ");
			if (MeasuredHero.weightlimit_p >300 && MeasuredHero.weightlimit_p <= 800)
				Console.WriteLine("Peak human: 3");
			if (MeasuredHero.weightlimit_t >=1 && MeasuredHero.weightlimit_t <= 100) 
				Console.WriteLine("Superhuman: 4");
			else 
				if (MeasuredHero.weightlimit_t > 100)
				Console.WriteLine("Possibly Incalculatable: 7 ");
			
			//This cycle of statements lists out the speed level of a character
			Console.WriteLine("How fast can you run?");
			MeasuredHero.speedlimit = Convert.ToInt32(Console.ReadLine());
			if (MeasuredHero.speedlimit < 28)
				Console.WriteLine("Poor: 1");
			if (MeasuredHero.speedlimit == 28)
				Console.WriteLine("Normal: 2");
			if (MeasuredHero.speedlimit> 40 && MeasuredHero.speedlimit < 768) 
				Console.WriteLine("Subsonic: 3");
			if (MeasuredHero.speedlimit >= 768 && MeasuredHero.speedlimit <= 1536)
				Console.WriteLine("Supersonic Speedster: 4");
			if (MeasuredHero.speedlimit > 1536 && MeasuredHero.speedlimit < 19000) 
				Console.WriteLine("Hypersonic Speedster: 5");
			if (MeasuredHero.speedlimit > 19000 && MeasuredHero.speedlimit < 671000000) 
				Console.WriteLine("Speed of light Speedster: 6");
			else 
				if (MeasuredHero.speedlimit >  671000000)
				Console.WriteLine("Warp Speedster or Teleporter: 7");
			
			//This cycle will be in regards to the damage a hero can take
			Console.WriteLine("How well do you handle taking damage?");
			Console.WriteLine("Poor, Normal, Above Human, Regenerative, Bulletproof, Above Superhuman, Nearly Indestructible?");
			MeasuredHero.damagelimit = Console.ReadLine();
			if (MeasuredHero.damagelimit == "Poor")
				Console.WriteLine("Poor: 1");
			if (MeasuredHero.damagelimit == "Normal")
				Console.WriteLine("Normal: 2");
			if (MeasuredHero.damagelimit == "Above Human")
				Console.WriteLine("Above Human: 3");
			if (MeasuredHero.damagelimit == "Regenerative")
				Console.WriteLine("Regenerative: 4 ");
			if (MeasuredHero.damagelimit == "Bulletproof")
				Console.WriteLine("Regenerative: 5");
			if (MeasuredHero.damagelimit == "Above Superhuman")
				Console.WriteLine("Above Superhuman: 6");
			else 
				if (MeasuredHero.damagelimit == "Nearly Indestructible")
				Console.WriteLine("Nearly Indestructible: 7");

			//This cycle is for intelligence
			Console.WriteLine("How smart is the hero");
			Console.WriteLine("Impaired, Normal, Educated, Gifted, Genius, Super Genius, Omniscient?");
			MeasuredHero.intellectlevel = Console.ReadLine();
			if (MeasuredHero.intellectlevel == "Impaired")
				Console.WriteLine("Impaired: 1");
			if (MeasuredHero.damagelimit == "Normal")
				Console.WriteLine("Normal: 2");
			if (MeasuredHero.damagelimit == "Educated")
				Console.WriteLine("Educated: 3");
			if (MeasuredHero.damagelimit == "Gifted")
				Console.WriteLine("Gifted: 4 ");
			if (MeasuredHero.damagelimit == "Genius")
				Console.WriteLine("Genius: 5");
			if (MeasuredHero.damagelimit == "Super Genius")
				Console.WriteLine("Super Genius: 6");
			else
				if (MeasuredHero.damagelimit == "Omniscient")
				Console.WriteLine("Omniscient: 7");

			//This cycle is for combative fighting skill
			Console.WriteLine("How well can you fight?");
			Console.WriteLine("Poor, Normal, Street Fighter, Experienced Fighter, Martial Arts Master, Martial Arts Grand Master, Omniscient Combatant?");
			MeasuredHero.martialskill = Console.ReadLine();
			if (MeasuredHero.martialskill == "Poor")
				Console.WriteLine("Poor: 1");
			if (MeasuredHero.martialskill == "Normal")
				Console.WriteLine("Normal: 2");
			if (MeasuredHero.martialskill == "Street Fighter")
				Console.WriteLine("Street Fighter with some training: 3");
			if (MeasuredHero.martialskill == "Experienced Fighter")
				Console.WriteLine("Experienced Fighter with years worth of combat skills : 4");
			if (MeasuredHero.martialskill == "Martial Arts Master")
				Console.WriteLine("Master 1 parituclar form of combat with decades worth of combat prowess : 5");
			if (MeasuredHero.martialskill == "Martial Arts Grand Master")
				Console.WriteLine("Master of several parituclar form of combat with centuries worth of combat prowess : 6");
			if (MeasuredHero.martialskill == "Omniscient Combatant")
				Console.WriteLine(" Master of all forms of combat accross the whole of eternity : 7");

			//This cycle is for combative fighting skill
			Console.WriteLine("Do you have the ability to manipluate or discharge some form of energy?");
			Console.WriteLine("No, On Contact, Somewhat, Moderately,Fairly Well, Expertly,Godlike? ");
			MeasuredHero.energrycontrol = Console.ReadLine();
			if (MeasuredHero.energrycontrol == "No")
				Console.WriteLine("None: 1");
			if (MeasuredHero.energrycontrol == "On Contact")
				Console.WriteLine("Tactical Energy Discharge: 2");
			if (MeasuredHero.energrycontrol == "Somewhat")
				Console.WriteLine("Short range and duration of a single energy type: 3");
			if (MeasuredHero.energrycontrol == "Moderately ")
				Console.WriteLine("Medium range and duration of s singgle energy type : 4");
			if (MeasuredHero.energrycontrol == "Fairly Well")
				Console.WriteLine("Long range and duration of a single energy type: 5");
			if (MeasuredHero.energrycontrol == "Expertly ")
				Console.WriteLine("Multiple forms of energy with long ranges and durations : 6");
			if (MeasuredHero.energrycontrol == "Godlike")
				Console.WriteLine(" Unlimited control over all forms of energy and matter : 7");
			
			Console.WriteLine("Press Enter to Exit");
			Console.ReadKey();//This is only needed on none Apple devices to keep the app running 
							  

		}
	}
}

