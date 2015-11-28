using System;

namespace Gladiator.Weapons
{
	public class Dagger : Equipment
	{
		public Dagger ()
		{
			this.Name = "Dague";
			this.Type = "att";
			this.Cost = 2;
			this.Attack = 60;
			this.Defense = 0;
			this.Initiative = 5;
			this.UniqueUse = false;
		}
	}
}

