using System;

namespace MyNameIsGladiator
{
	public class Equipement
	{
		public int coutPoints = 0;
		public virtual int CoutPoints {
			get {return coutPoints;}
			set { this.coutPoints = value; }
		}

		public int priorite = 10;
		public virtual int Priorite {
			get {return priorite;}
			set {priorite = value;}
		}

		public string nom = "";
		public virtual string Nom {
			get {return nom;}
			set { this.nom = value; }
		}
		public bool utilise = false;
		public virtual bool Utilise {
			get {return utilise;}
			set { this.utilise = value; }
		}
		public int precision=0;
		public virtual int Precision {
			get {
				return precision;
			}
			set {
				precision = value;
			}
		}
		public int blocage=0;
		public virtual int Blocage {
			get {
				return blocage;
			}
			set {
				blocage = value;
			}
		}

		public Equipement ()
		{
			
		}
	}
}

