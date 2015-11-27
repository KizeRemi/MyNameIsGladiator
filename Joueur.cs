using System;

namespace MyNameIsGladiator
{
	public class Joueur
	{
		private string _Nom;
		public string Nom 
		{
			get { return this._Nom; }
			set { this._Nom = value; }
		}

		private string _Prenom;
		public string Prenom 
		{
			get { return this._Prenom; }
			set { this._Prenom = value; }
		}
		private string _Pseudo;
		public string Pseudo 
		{
			get { return this._Pseudo; }
			set { this._Pseudo = value; }
		}
		public Equipe[] equipes = new Equipe[4];
		public DateTime _DateInscription = DateTime.Now;

		public Joueur (string nom, string prenom, string pseudo)
		{
			this._Nom = nom;
			this._Prenom = prenom;
			this._Pseudo = pseudo;
		}

		public void CreerEquipe(Equipe createEquipe, int i)
		{
			equipes[i] = createEquipe;
		}
			
		public string AfficherJoueur()
		{
			return "Le joueur " + this._Nom + " '" + this._Pseudo + "' " + this._Prenom + " s'est inscrit le: " + this._DateInscription;
		}

		public string AfficherEquipe(int i)
		{
			return this.equipes[i].NomEquipe;
		}

	}
}

