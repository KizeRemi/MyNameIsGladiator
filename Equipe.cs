using System;

namespace MyNameIsGladiator
{
	public class Equipe 
	{
		private string _Nom;
		public string NomEquipe 
		{
			get { return this._Nom; }
			set { this._Nom = value; }
		}

		private string _Description;
		public string Description 
		{
			get { return this._Description; }
			set { this._Description = value; }
		}
			
		public Gladiateur[] _gladiateurs = new Gladiateur[3];
		public Gladiateur[] gladiateurs
		{
			get {return _gladiateurs;}
			set {_gladiateurs = value;}
		}

		public Equipe (string nom, string description)
		{
			this._Nom = nom;
			this._Description = description;
		}

		public void CreerGladiateur(Gladiateur createGladiateur, int i)
		{
			gladiateurs[i] = createGladiateur;
		}

		public string AfficherGladiateur(int i)
		{
			return this.gladiateurs[i]._positionFile + "/" + this.gladiateurs[i].nomGladiateur;
		}

		public string AfficherEquipe()
		{
			return "l'équipe s'appelle " + this._Nom + ". Description: " + this._Description;
		}
/* ON DETERMINE L'ORDRE DES GLADIATEURS */
		public int DeterminerOrdreGlad()
		{
			int ordre = -1;
			int i = 0;
			foreach (Gladiateur gladiateur in gladiateurs) 
			{
				if (gladiateur.Etat) {
					ordre = i;
					break;
				} else {
					i++;
				}
			}
			return ordre;
		}
/* RETOURNE VRAI SI AU MOINS UN GLADIATEUR EST VIVANT DANS L'EQUIPE */
		public bool hasGladiateurOk()
		{
			bool result = false;
			foreach (Gladiateur gladiater in gladiateurs) {
				if (gladiater.Etat) {
					result = true;
					break;
				}
			}
			return result;
		}

	}
}

