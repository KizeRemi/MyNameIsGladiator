using System;
using System.Collections.Generic;

namespace MyNameIsGladiator
{
	public class Gladiateur
	{
		private string _NomGladiateur;
		public string nomGladiateur 
		{
			get { return this._NomGladiateur; }
			set { this._NomGladiateur = value; }
		}
		private bool _etat = true;
		public bool Etat
		{
			get { return this._etat; }
			set { this._etat = value; }
		}
		public int _nbrGagne;
		public int _nbrPerdu;
		public int _tauxVictoire;
		public int _positionFile;
		public string positionFile
		{
			get { return this.positionFile; }
			set { this.positionFile = value; }
		}
		public int _equipementMax = 10;
		List<Equipement> equipement = new List<Equipement> ();

		public List<Equipement> getEquipement {
			get {
				return equipement;
				}
		}

		public Gladiateur (string nom, int positionFile)
		{
			this._NomGladiateur = nom;
			this._positionFile = positionFile;

		}
/* ON DETERMINE LE POIDS DU GLADIATEUR EN FONCTION DE SON EQUIPEMENT*/
		public int poidsGladiateur()
		{
			int poidsActuel = 0;
			foreach(Equipement equiper in this.getEquipement)
			{
				poidsActuel += equiper.CoutPoints;
			}
			return poidsActuel;
		}

		public void AjouterEquipement(Equipement equipement)
		{
			if ((poidsGladiateur() + equipement.CoutPoints) <= 10) 
			{
				this.equipement.Add(equipement);
			}
		}
		public string AfficherEquipement()
		{
			string ListeEquipement = "";

			foreach(Equipement equiper in this.getEquipement)
			{
				ListeEquipement+=" "+equiper.Nom;
			}
			return ListeEquipement;
		}
	}
}

