using System;

namespace Gladiator.Weapons
{
	public class Helmet : Equipment
	{
		public Helmet ()
		{
			this.Name = "Casque";
			this.Type = "def";
			this.Cost = 2;
			this.Attack = 0;
			this.Defense = 10;
			this.Initiative = 10;
			this.UniqueUse = false;
		}
	}
}

