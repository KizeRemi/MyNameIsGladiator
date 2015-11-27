using System;

namespace MyNameIsGladiator
{
	public class Casque: Equipement
	{
		public new string  nom= "Casque";

		public override string Nom {
			get {return nom;}
			set { this.nom = value; }
		}

		public new int coutPoints= 2 ;

		public override int CoutPoints {
			get {return coutPoints;}
			set { this.coutPoints = value; }
		}

		public new int blocage=10;
		public override int Blocage {
			get {
				return blocage;
			}
			set {
				blocage = value;
			}
		}
		public Casque ()
		{
		}
	}
}

