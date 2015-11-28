using System;
using System.Collections.Generic;
using System.Linq;

namespace Gladiator
{
	public class Match
	{

		private Team _FirstTeam;
		public Team FirstTeam {
			get {return _FirstTeam;}
			set {_FirstTeam = value;}
		}

		private Team _SecondTeam;
		public Team SecondTeam {
			get {return _SecondTeam;}
			set {_SecondTeam = value;}
		}

		public Match (Team firstTeam, Team secondTeam)
		{
			FirstTeam = firstTeam;
			SecondTeam = secondTeam;
		}

		//Méthode de lancement du match, elle retourne l'équipe vainqueur
		public Team Start(){
			Team winnerTeam = null;
			Team loserTeam = null;
			int nbCombat = 0;
			List<Gladiator> firstTeam = this.FirstTeam.Gladiators.OrderBy(j => j.Initiative).ToList();
			List<Gladiator> secondTeam = this.SecondTeam.Gladiators.OrderBy(j => j.Initiative).ToList();
			Gladiator winnerGladiator;

			while (firstTeam.Count != 0 && secondTeam.Count != 0) {
				nbCombat++;
				//Lancement des combats entre les gladiateurs de chacune des teams
				Fight fight = new Fight (firstTeam.First(), secondTeam.First());
				Console.WriteLine ("==> Combat n°"+nbCombat);
				winnerGladiator = fight.Start ();
				//Le gladiateur vainqueur de son combat reste dans l'arêne
				if (winnerGladiator == firstTeam.First ()) {
					secondTeam.Remove (secondTeam.First ());
					winnerTeam = FirstTeam;
					loserTeam = SecondTeam;
				}
				else {
					firstTeam.Remove (firstTeam.First ());
					winnerTeam = SecondTeam;
					loserTeam = FirstTeam;
				}
				Console.WriteLine (FirstTeam.Name +" : " + (3-secondTeam.Count));
				Console.WriteLine (SecondTeam.Name +" :" + (3-firstTeam.Count)+"\r\n");
			}
			Console.WriteLine ("Le gagnant de cette manche est : " +winnerTeam.Name+"\r\n");
			winnerTeam.MatchsPlayed++;
			loserTeam.MatchsPlayed++;
			winnerTeam.MatchsWon++;
			return winnerTeam;
		}
	}
}

