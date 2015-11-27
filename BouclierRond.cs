using System;

namespace MyNameIsGladiator
{
	public class BouclierRond: Equipement
	{
		public new string  nom= "Petit bouclier rond";

		public override string Nom {
			get {return nom;}
			set { this.nom = value; }
		}

		public new int coutPoints= 5 ;

		public override int CoutPoints {
			get {return coutPoints;}
			set { this.coutPoints = value; }
		}
		public new int blocage=20;
		public override int Blocage {
			get {
				return blocage;
			}
			set {
				blocage = value;
			}
		}

		public BouclierRond ()
		{
		}
	}
}

