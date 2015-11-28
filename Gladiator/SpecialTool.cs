using System;

namespace Gladiator
{
	public abstract class SpecialTool : Equipment
	{
		

		private string _Name;
		public string Name {
			get {return _Name;}
			set {_Name = value;}
		}

		private string _Type;
		public string Type {
			get {return _Type;}
			set {_Type = value;}
		}

		private int _Cost;
		public int Cost {
			get {return _Cost;}
			set {_Cost = value;}
		}

		private int _Attack;
		public int Attack {
			get {return _Attack;}
			set {_Attack = value;}
		}

		private int _Defense;
		public int Defense {
			get {return _Defense;}
			set {_Defense = value;}
		}

	
		private int _Initiative;
		public int Initiative {
			get {return _Initiative;}
			set {_Initiative = value;}
		}

		private bool _UniqueUse;
		public bool UniqueUse {
			get {return _UniqueUse;}
			set {_UniqueUse = value;}
		}

		public SpecialTool ()
		{
		}
	}
}

