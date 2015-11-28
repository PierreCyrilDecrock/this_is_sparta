using System;

namespace Gladiator.Weapons
{
	public class RectangularShield : Equipment
	{
		public RectangularShield ()
		{
			this.Name = "Bouclier rectangulaire";
			this.Type = "def";
			this.Cost = 8;
			this.Attack = 0;
			this.Defense = 30;
			this.Initiative = 10;
			this.UniqueUse = false;
		}
	}
}

