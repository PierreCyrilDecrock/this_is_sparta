using System;
using System.Collections.Generic;

namespace Gladiator
{
	public class Team
	{

		const int NB_GLADIATOR = 3;

		private string _Name;
		public string Name {
			get {return _Name;}
			set {_Name = value;}
		}

		private string _Description;
		public string Description {
			get {return _Description;}
			set {_Description = value;}
		}

		private int _MatchsPlayed;
		public int MatchsPlayed {
			get {return _MatchsPlayed;}
			set {_MatchsPlayed = value;}
		}

		private int _MatchsWon;
		public int MatchsWon {
			get {return _MatchsWon;}
			set {_MatchsWon = value;}
		}

		private int _MatchsLost;
		public int MatchsLost {
			get {return MatchsPlayed-MatchsWon;}
			set {_MatchsLost = value;}
		}

		private double _WinRate;
		public double WinRate {
			get {
				if (MatchsPlayed != 0) {
					return  MatchsWon * 100 / MatchsPlayed;
				} 
				else {
					return MatchsPlayed;
				}

			}
			set {_WinRate = value;}
		}

		private List<Gladiator> _Gladiators = new List<Gladiator> ();
		public List<Gladiator> Gladiators {
			get {return _Gladiators;}
			set {_Gladiators = value;}
		}

		public Team (string name, string description)
		{
			this.Name = name;
			this.Description = description;
		}

		//Ajouter un gladiateur dans une team
		public void AddGladiator(Gladiator gladiator){
			//Vérification si la taille limite d'une team n'a pas été atteinte
			if (this.Gladiators.Count < NB_GLADIATOR) {
				this.Gladiators.Add (gladiator);
				Console.WriteLine ("Votre gladiateur a bien été ajouté à cette team.");
			}	
			else
				Console.WriteLine ("Vous ne pouvez pas avoir plus de " + NB_GLADIATOR + " gladiateurs dans une team.");
		}
		//retirer un gladiateur d'une team
		public void RemoveGladiator(Gladiator gladiator){
			if (this.Gladiators.Count > 0) {
				this.Gladiators.Remove (gladiator);
				Console.WriteLine ("Votre gladiateur a bien été retiré de cette team.");
			}	
			else
				Console.WriteLine ("Votre team ne contient aucun gladiateur.");
		}

	}
}

