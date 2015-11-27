using System;

namespace MyNameIsGladiator
{
	public class BouclierRect: Equipement
	{
		public new string  nom= "Bouclier rectangulaire";

		public override string Nom {
			get {return nom;}
			set { this.nom = value; }
		}

		public new int coutPoints= 8 ;

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

		public BouclierRect ()
		{
		}
	}
}

