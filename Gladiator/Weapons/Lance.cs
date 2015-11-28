using System;

namespace Gladiator.Weapons
{
	public class Lance : Equipment
	{
		public Lance ()
		{
			this.Name = "Lance";
			this.Type = "att";
			this.Cost = 7;
			this.Attack = 50;
			this.Defense = 0;
			this.Initiative = 2;
			this.UniqueUse = false;
		}

	}
}

