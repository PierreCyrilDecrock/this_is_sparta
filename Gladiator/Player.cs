using System;
using System.Collections.Generic;

namespace Gladiator
{
	public class Player
	{
		const int NB_TEAMS = 5;

		private string _FirstName;
		public string FirstName {
			get {return _FirstName;}
			set {_FirstName = value;}
		}

		private string _LastName;
		public string LastName {
			get {return _LastName;}
			set {_LastName = value;}
		}

		private string _NickName;
		public string NickName {
			get {return _NickName;}
			set {_NickName = value;}
		}

		private DateTime _RegistrationDate;
		public DateTime RegistrationDate {
			get {return _RegistrationDate;}
			set {_RegistrationDate = value;}
		}

		private List<Team> _Teams = new List<Team>();
		public List<Team> Teams {
			get {return _Teams;}
			set {_Teams = value;}
		}

		public Player (string firstName, string lastName, string nickName)
		{
			this.FirstName = firstName;
			this.LastName = lastName;
			this.NickName = nickName;
			this._RegistrationDate = DateTime.Today;
		}

		public string AddTeam(Team team){
			if (this.Teams.Count < NB_TEAMS) {
				this.Teams.Add (team);
				return "Votre team a bien été ajoutée.";
			}	
			else
				return "Vous ne pouvez pas avoir plus de " + NB_TEAMS + " équipes.";
		}
	}
}

