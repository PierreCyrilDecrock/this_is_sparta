using System;
using System.Collections.Generic;
using System.Linq;

namespace Gladiator
{
	public class Tournament
	{
		private string _Name;
		public string Name {
			get {return _Name;}
			set {_Name = value;}
		}

		private List<Team> _Teams = new List<Team> ();
		public List<Team> Teams {
			get {return _Teams;}
			set {_Teams = value;}
		}


		public Tournament ()
		{
		}

		//Méthode d'ajout d'une team à un tournoi
		public void AddTeam(Team team){
			this.Teams.Add (team);
		}

		//Méthode de lancement d'un tournoi
		public void Start(){
			List<Team> TournamentBrackets = this.Teams;
			int nbBrackets = 0;

			//Vérification de la parité du nombre d'équipe pour que l'appairage se passe bien
			if (TournamentBrackets.Count % 2 == 1) {
				Console.WriteLine ("Le tournois doit avoir un nombre d'équipes pair.");
			} 
			else {
				Console.WriteLine ("Le tournois commence\r\n");
				//Le tournoi se finit seulement lorsqu'il y a un vainqueur 
				while (TournamentBrackets.Count != 1) {
					nbBrackets++;
					Console.WriteLine ("Manche n°"+nbBrackets +"\r\n");
					TournamentBrackets = this.MatchMaking (TournamentBrackets);
				}
				Console.WriteLine ("Le tournois est terminé, le vainqueur est la team : "+TournamentBrackets.First().Name +"\r\n");
			}


		}

		//Appairage des équipes en fonction du % de victoire.
		public List<Team> MatchMaking(List<Team> brackets){
			List<Team> newBracket = new List<Team>();

			brackets = brackets.OrderBy (j => j.WinRate).ToList();

			for (int i=0; i < brackets.Count; i += 2) {
				Match match = new Match (brackets[i], brackets[i+1]);
				newBracket.Add (match.Start ());
			}

			return newBracket;
		}
	}
}

