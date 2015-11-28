using System;

namespace Gladiator.Weapons
{
	public class Net : Equipment
	{
		public Net ()
		{
			this.Name = "Filet";
			this.Type = "att";
			this.Cost = 3;
			this.Attack = 30;
			this.Defense = 0;
			this.Initiative = 1;
			this.UniqueUse = true;
		}
	}
}

