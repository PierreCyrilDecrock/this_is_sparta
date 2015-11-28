using System;
using System.Collections.Generic;

namespace Gladiator
{
	public class Gladiator
	{
		
		const int MAX_STRENGTH = 10;

		private string _Name;
		public string Name {
			get {return _Name;}
			set {_Name = value;}
		}

		private List<Equipment> _Equipments = new List<Equipment> ();
		public List<Equipment> Equipments {
			get {
				return _Equipments;
			}
			set {
				_Equipments = value;
			}
		}

		private int _FightWin;
		public int FightWin {
			get {return _FightWin;}
			set {_FightWin = value;}
		}

		private int _FightLost;
		public int FightLost {
			get {return _FightLost;}
			set {_FightLost = value;}
		}

		private double _WinRate;
		public double WinRate {
			get {
				if (FightWin != 0) {
					return  FightWin*100/(FightLost+FightWin);
				} 
				else {
					return FightWin;
				}
			}
			set {_WinRate = value;}
		}

		private int _Initiative;
		public int Initiative {
			get {return _Initiative;}
			set {_Initiative = value;}
		}

		private int _Strength;
		public int Strength {
			get {return _Strength;}
			set {_Strength = value;}
		}

		private bool _State;
		public bool State {
			get {return _State;}
			set {_State = value;}
		}

		private bool _Trap;
		public bool Trap {
			get {return _Trap;}
			set {_Trap = value;}
		}

		public Gladiator ()
		{
			this.Name = "Esclave aléatoire";
			this.State = true;
			this.Trap = false;
		}

		public Gladiator (string name)
		{
			this.Name = name;
			this.State = true;
			this.Trap = false;
		}

		// Méthode pour équiper une arme que une glasiateur
		public void Equip(Equipment equipment){
			int nb_att = 0;
			//Vérification si le gladiateur a encore de la place dans son inventaire (10 points)
			if ((this.Strength + equipment.Cost) <= MAX_STRENGTH) {
				//Vérification de la présence d'au moins une arme
				if (this.Equipments.Count == 0) {
					if (equipment.Type == "att" || equipment.Type == "both") {
						nb_att++;
					}
				}

				for (int i = 0; i < this.Equipments.Count; i++) {
					if(this.Equipments[i].Type == "att" || this.Equipments[i].Type == "both"){
						nb_att++;
					}
				}

				switch (nb_att) {
				case 0:
					Console.WriteLine (this.Name + " doit au moins avoir une arme pour commencer.");
					break;
				case 2:
					if (equipment.Type == "att" || equipment.Type == "both") {
						Console.WriteLine ("Il ne peut pas avoir plus de deux armes.");
					} 
					else {
						this.Equipments.Add (equipment);
						this.Strength += equipment.Cost;
						Console.WriteLine ("Un(e) " + equipment.Name + " s'est ajouté(e) à l'équipement de " + this.Name);
					}
					break;
				default:
					this.Equipments.Add (equipment);
					this.Strength += equipment.Cost;
					Console.WriteLine ("Un(e) " + equipment.Name + " s'est ajouté(e) à l'équipement de " + this.Name);
					break;
				}

			} 
			else {
				Console.WriteLine (this.Name + " n'est pas assez fort pour porter un(e) " + equipment.Name + " en plus.");

			}
				

		}
		//Méthode qui permet d'indiquer l'ordre d'une gladiateur dans une team
		public void SetInitiativeTo(int initiative){
			this.Initiative = initiative;
		}
	}
}

