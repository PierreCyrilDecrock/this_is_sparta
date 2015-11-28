using System;
using System.Collections.Generic;
using System.Linq;

namespace Gladiator
{
	public class Fight
	{

		private Gladiator _FirstGladiator;
		public Gladiator FirstGladiator {
			get {return _FirstGladiator;}
			set {_FirstGladiator = value;}
		}

		private Gladiator _SecondGladiator;
		public Gladiator SecondGladiator {
			get {return _SecondGladiator;}
			set {_SecondGladiator = value;}
		}

		public Fight (Gladiator firstGladiator, Gladiator secondGladiator)
		{
			FirstGladiator = firstGladiator;
			SecondGladiator = secondGladiator;
		}

		//Méthode de lancement du combat entre les deux gladiateur, elle renvoie le gladiateur vainqueur 
		public Gladiator Start(){
			Gladiator winnerGladiator = null;
			Gladiator attacker = null;
			Gladiator defender = null;
//			Gladiator sameAttacker = null;
//			Gladiator sameDefender = null;
			List<Equipment> listWeapons = new List<Equipment>();
			List<Equipment> listArmor = new List<Equipment>();
//			List<Equipment> secondListWeapons = new List<Equipment>();
//			List<Equipment> secondListArmor = new List<Equipment>();
			List<Equipment> firstEquipmentList = new List<Equipment>();
			List<Equipment> secondEquipmentList = new List<Equipment>();
			Random rand = new Random ();

			firstEquipmentList = this.FirstGladiator.Equipments.OrderBy(j => j.Initiative).ToList();
			secondEquipmentList = this.SecondGladiator.Equipments.OrderBy(j => j.Initiative).ToList();

//			if (firstEquipmentList.First ().Initiative == secondEquipmentList.First ().Initiative) {
//				sameAttacker = this.FirstGladiator;
//				sameDefender = this.SecondGladiator;
//				Console.WriteLine ("Cas 1");
//			}


			//Choix du gladiateur qui attaquera en premier en fonction de l'initiative de leurs armes
			if (firstEquipmentList.First ().Initiative < secondEquipmentList.First ().Initiative) {
				attacker = this.FirstGladiator;
				defender = this.SecondGladiator;
			} 
			else{
				attacker = this.SecondGladiator;
				defender = this.FirstGladiator;
			}


			while (attacker.State == true && defender.State == true) {
				Console.WriteLine ("-------- Passe d'arme --------");

//				if (sameAttacker == null && sameDefender == null) {
					for (int i = 0; i < attacker.Equipments.Count; i++) {
						if (attacker.Equipments [i].Type == "att" || attacker.Equipments [i].Type == "both") {
							if (attacker.Equipments [i].Name == "Filet" && attacker.Equipments [i].UniqueUse == false) {
								continue;
							} 
							else {
								listWeapons.Add (attacker.Equipments [i]);
							}
						}
					}

					for (int i = 0; i < defender.Equipments.Count; i++) {
						if (defender.Equipments [i].Type == "def" || defender.Equipments [i].Type == "both") {
							listArmor.Add (defender.Equipments [i]);
						}
					}
//				} 
//				else {
//					for (int i = 0; i < sameAttacker.Equipments.Count; i++) {
//						if (sameAttacker.Equipments [i].Type == "att" || sameAttacker.Equipments [i].Type == "both") {
//							listWeapons.Add (sameAttacker.Equipments [i]);
//						}
//						if (sameAttacker.Equipments [i].Type == "def" || sameAttacker.Equipments [i].Type == "both") {
//							listArmor.Add (sameAttacker.Equipments [i]);
//						}
//					}
//
//					for (int i = 0; i < sameDefender.Equipments.Count; i++) {
//						if (sameDefender.Equipments [i].Type == "att" || sameDefender.Equipments [i].Type == "both") {
//							secondListWeapons.Add (sameDefender.Equipments [i]);
//						}
//						if (sameDefender.Equipments [i].Type == "def" || sameDefender.Equipments [i].Type == "both") {
//							secondListArmor.Add (sameDefender.Equipments [i]);
//						}
//					}
//				}


				Console.WriteLine ("L'attaquant a "+listWeapons.Count+" arme(s)");
				Console.WriteLine ("Le défenseur a "+listArmor.Count+" armure(s)");
//				Console.WriteLine ("Le défenseur a "+secondListWeapons.Count+" armes");
//				Console.WriteLine ("Le défenseur a "+secondListArmor.Count+" armure");

				//Attaque et défense successive des armes et des armures
				foreach (Equipment weapon in listWeapons) {
					if (attacker.Trap == true) {
						weapon.Attack = weapon.Attack / 2;
						Console.WriteLine (attacker.Name+" est piégé");

					}
					if (defender.State == true) {
						if (weapon.Attack < rand.Next (100)) {
							Console.WriteLine (attacker.Name+" réussi son attaque avec un(e) "+ weapon.Name);
							if (weapon.Name == "Filet" && weapon.UniqueUse == true) {
								defender.Trap = true;
								weapon.UniqueUse = false;
							}

							foreach (Equipment armor in listArmor) {
								if (weapon.Name == "Filet") {
									Console.WriteLine (defender.Name + " se prend un filet sur la tronche");
									break;
								} else if (armor.Defense < rand.Next (100)) {
									Console.WriteLine (defender.Name + " bloque le coup avec un(e)" + armor.Name);
									break;

								} else {
									Console.WriteLine (defender.Name + " est mort.\r\n");
									defender.State = false;
									winnerGladiator = attacker;
									defender.FightLost++;
									attacker.FightWin++;
									goto Outer;
								}
							}
							if (listArmor.Count == 0) {
								Console.WriteLine (defender.Name + " est mort.");
								defender.State = false;
								winnerGladiator = attacker;
								defender.FightLost++;
								attacker.FightWin++;
								goto Outer;
							}
						}
						else {
							Console.WriteLine (attacker.Name+" rate son attaque de "+weapon.Name);
						}
					}
					Outer:continue;
				}
				//Switch entre l'attaquant et le défenseur 
				listWeapons.Clear ();
				listArmor.Clear();
				Gladiator temp = attacker;
				attacker = defender;
				defender = temp;
			}

			//remise à neuf de nos braves gladiateurs pour les prochains combats
			this.FirstGladiator.State = true;
			this.SecondGladiator.State = true;
			this.FirstGladiator.Trap = false;
			this.SecondGladiator.Trap = false;
			for (int i = 0; i < this.FirstGladiator.Equipments.Count; i++) {
				if (this.FirstGladiator.Equipments [i].Name == "Filet") {
					this.FirstGladiator.Equipments [i].UniqueUse = true;
				}
			}
			for (int i = 0; i < this.SecondGladiator.Equipments.Count; i++) {
				if (this.SecondGladiator.Equipments [i].Name == "Filet") {
					this.SecondGladiator.Equipments [i].UniqueUse = true;
				}
			}
			return winnerGladiator;
		}
	}
}

