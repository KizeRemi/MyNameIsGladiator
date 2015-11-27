﻿using System;

namespace MyNameIsGladiator
{
	public class Dague: Equipement
	{
		public new string  nom= "Dague";

		public override string Nom {
			get {return nom;}
			set { this.nom = value; }
		}

		public new bool utilise = false;
		public override bool Utilise {
			get {return utilise;}
			set { this.utilise = value; }
		}

		public new int coutPoints= 2 ;
		public new int priorite= 5 ;
		public override int Priorite {
			get {return priorite;}
			set {priorite = value;}
		}
		public override int CoutPoints {
			get {return coutPoints;}
			set { this.coutPoints = value; }
		}

		public new int precision=60;
		public override int Precision {
			get {
				return precision;
			}
			set {
				precision = value;
			}
		}

		public Dague ()
		{
		}
	}
}

