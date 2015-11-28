using System;

namespace Gladiator.Weapons
{
	public class Trident : Equipment
	{
		public Trident ()
		{
			this.Name = "Trident";
			this.Type = "both";
			this.Cost = 7;
			this.Attack = 40;
			this.Defense = 10;
			this.Initiative = 3;
			this.UniqueUse = false;
		}
	}
}

