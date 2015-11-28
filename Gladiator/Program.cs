using System;
using Gladiator.Weapons;

namespace Gladiator
{
	class MainClass
	{
		public static void Main (string[] args)
		{
		//////  PLAYERS  //////

			Player player1 = new Player ("Daniel", "SMITH", "Dany");
			Player player2 = new Player ("Ryan", "JOHNSON", "RJ");
			Player player3 = new Player ("James", "WILLIAMS", "Jimy");
			Player player4 = new Player ("Kyle", "BROWN", "Kyle");

		//////  WEAPONS  //////

			Equipment petitBouclierRond = new SmallRoundShield ();
			Equipment bouclierRectangulaire = new RectangularShield ();
			Equipment casque = new Helmet ();
			Equipment dague = new Dagger ();
			Equipment epee = new Sword ();
			Equipment trident = new Trident ();
			Equipment lance = new Lance ();
			Equipment filet = new Net ();

		//////  TEAMS  //////
			 
			Team teamRed = new Team ("teamRed", "La teamRed est la plus forte.");
			Team teamBlue = new Team ("teamBlue", "La teamBlue est la plus forte.");
			Team teamGreen = new Team ("teamGreen", "La teamGreen est la plus forte.");
			Team teamYellow = new Team ("teamYellow", "La teamYellow est la plus forte.");

			player1.AddTeam (teamRed);
			player2.AddTeam (teamBlue);
			player3.AddTeam (teamGreen);
			player4.AddTeam (teamYellow);

			/// TEAM RED
			Gladiator gladiatorR1 = new Gladiator ("gladiatorR1");
			gladiatorR1.Equip (casque);
			gladiatorR1.Equip (trident);
			gladiatorR1.Equip (trident);	
			gladiatorR1.Equip (casque);	
			Gladiator gladiatorR2 = new Gladiator ("gladiatorR2");
			gladiatorR2.Equip (filet);
			gladiatorR2.Equip (lance);
			Gladiator gladiatorR3 = new Gladiator ("gladiatorR3");
			gladiatorR3.Equip (epee);
			gladiatorR3.Equip (petitBouclierRond);

			gladiatorR1.SetInitiativeTo (1);
			gladiatorR2.SetInitiativeTo (2);
			gladiatorR3.SetInitiativeTo (3);

			teamRed.AddGladiator (gladiatorR1);
			teamRed.AddGladiator (gladiatorR3);
			teamRed.AddGladiator (gladiatorR2);


			/// TEAM BLUE
			Gladiator gladiatorB1 = new Gladiator ("gladiatorB1");
			gladiatorB1.Equip (dague);
			gladiatorB1.Equip (dague);
			gladiatorB1.Equip (petitBouclierRond);
			Gladiator gladiatorB2 = new Gladiator ("gladiatorB2");
			gladiatorB2.Equip (dague);
			gladiatorB2.Equip (bouclierRectangulaire);
			Gladiator gladiatorB3 = new Gladiator ("gladiatorB3");
			gladiatorB3.Equip (epee);
			gladiatorB3.Equip (casque);

			gladiatorB1.SetInitiativeTo (1);
			gladiatorB2.SetInitiativeTo (2);
			gladiatorB3.SetInitiativeTo (3);

			teamBlue.AddGladiator (gladiatorB1);
			teamBlue.AddGladiator (gladiatorB2);
			teamBlue.AddGladiator (gladiatorB3);

			/// TEAM GREEN
			Gladiator gladiatorG1 = new Gladiator ("gladiatorG1");
			gladiatorG1.Equip (epee);
			gladiatorG1.Equip (petitBouclierRond);
			Gladiator gladiatorG2 = new Gladiator ("gladiatorG2");
			gladiatorG2.Equip (dague);
			gladiatorG2.Equip (dague);
			gladiatorG2.Equip (petitBouclierRond);
			Gladiator gladiatorG3 = new Gladiator ("gladiatorG3");
			gladiatorG3.Equip (lance);	
			gladiatorG3.Equip (casque);

			gladiatorG1.SetInitiativeTo (1);
			gladiatorG2.SetInitiativeTo (2);
			gladiatorG3.SetInitiativeTo (3);

			teamGreen.AddGladiator (gladiatorG1);
			teamGreen.AddGladiator (gladiatorG2);
			teamGreen.AddGladiator (gladiatorG3);

			/// TEAM YELLOW
			Gladiator gladiatorY1 = new Gladiator ("gladiatorY1");
			gladiatorY1.Equip (dague);
			gladiatorY1.Equip (dague);
			gladiatorY1.Equip (petitBouclierRond);
			Gladiator gladiatorY2 = new Gladiator ("gladiatorY2");
			gladiatorY2.Equip (epee);
			gladiatorY2.Equip (petitBouclierRond);
			Gladiator gladiatorY3 = new Gladiator ("gladiatorY3");
			gladiatorY3.Equip (trident);	
			gladiatorY3.Equip (casque);

			gladiatorY1.SetInitiativeTo (1);
			gladiatorY2.SetInitiativeTo (2);
			gladiatorY3.SetInitiativeTo (3);

			teamYellow.AddGladiator (gladiatorY1);
			teamYellow.AddGladiator (gladiatorY2);
			teamYellow.AddGladiator (gladiatorY3);

		//////  TOURNAMENT  //////
			Tournament tournois = new Tournament();
			tournois.AddTeam (teamGreen);
			tournois.AddTeam (teamYellow);
			tournois.AddTeam (teamBlue);
			tournois.AddTeam (teamRed);

		//////  TEST  //////

			tournois.Start ();

			Console.WriteLine ("STATISTIQUES :\r\n");
			Console.WriteLine ("teamBlue winrate : "+ teamBlue.WinRate);
			Console.WriteLine ("teamGreen winrate : "+teamGreen.WinRate);
			Console.WriteLine ("teamRed winrate : "+teamRed.WinRate);
			Console.WriteLine ("teamYellow winrate : "+teamYellow.WinRate + "\r\n");
			Console.WriteLine ("gladiatorB1 winrate : "+gladiatorB1.WinRate);
			Console.WriteLine ("gladiatorB2 winrate : "+gladiatorB2.WinRate);
			Console.WriteLine ("gladiatorB3 winrate : "+gladiatorB3.WinRate);
			Console.WriteLine ("gladiatorR1 winrate : "+gladiatorR1.WinRate);
			Console.WriteLine ("gladiatorR2 winrate : "+gladiatorR2.WinRate);
			Console.WriteLine ("gladiatorR3 winrate : "+gladiatorR3.WinRate);
			Console.WriteLine ("gladiatorG1 winrate : "+gladiatorG1.WinRate);
			Console.WriteLine ("gladiatorG2 winrate : "+gladiatorG2.WinRate);
			Console.WriteLine ("gladiatorG3 winrate : "+gladiatorG3.WinRate);
			Console.WriteLine ("gladiatorY1 winrate : "+gladiatorY1.WinRate);
			Console.WriteLine ("gladiatorY2 winrate : "+gladiatorY2.WinRate);
			Console.WriteLine ("gladiatorY3 winrate : "+gladiatorY3.WinRate);
				
		}
	}
}
