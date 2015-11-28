using System;

namespace Gladiator.Weapons
{
	public class SmallRoundShield : Equipment
	{
		public SmallRoundShield ()
		{
			this.Name = "Petit bouclier rond";
			this.Type = "def";
			this.Cost = 5;
			this.Attack = 0;
			this.Defense = 20;
			this.Initiative = 10;
			this.UniqueUse = false;
		}
	}
}

