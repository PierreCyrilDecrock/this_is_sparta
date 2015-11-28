using System;

namespace Gladiator.Weapons
{
	public class Sword : Equipment
	{
		public Sword ()
		{
			this.Name = "Epée";
			this.Type = "att";
			this.Cost = 5;
			this.Attack = 70;
			this.Defense = 0;
			this.Initiative = 4;
			this.UniqueUse = false;
		}
	}
}

