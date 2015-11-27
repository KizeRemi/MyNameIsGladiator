using System;

namespace MyNameIsGladiator
{
	public class Trident: Equipement
	{
		public new string  nom= "Trident";

		public override string Nom {
			get {return nom;}
			set { this.nom = value; }
		}
		public new bool utilise = false;
		public override bool Utilise {
			get {return utilise;}
			set { this.utilise = value; }
		}
		public new int coutPoints= 3 ;
		public new int priorite= 3 ;
		public override int Priorite {
			get {return priorite;}
			set {priorite = value;}
		}
		public override int CoutPoints {
			get {return coutPoints;}
			set { this.coutPoints = value; }
		}

		int precision=40;
		public override int Precision {
			get {
				return precision;
			}
			set {
				precision = value;
			}
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

		public Trident ()
		{
		}
	}
}

