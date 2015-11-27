using System;
using System.Linq;
using System.Collections.Generic;

namespace MyNameIsGladiator
{
	public class Tournoi 
	{
		
		public Joueur[] joueurs;

		public Tournoi (Joueur[] joueurs)
		{
			this.joueurs = joueurs;
		}

		public void  AfficherEquipeJoueur()
		{
			int i = 1;
			foreach (Joueur joueur in joueurs) 
			{
				Console.WriteLine ("Le joueur "+ i + ": "+ joueur.Nom + " possède l'équipe suivante: " + joueur.AfficherEquipe(0));
				i++;
			}
		}

/* ON DETERMINE LE GLADIATEUR QUI VA COMBATTRE ET QUI EST VIVANT*/
		public Gladiateur gladPrio(List<Gladiateur> gladiateur)
		{
			Gladiateur gladCourant= new Gladiateur("bidon",1);
			gladCourant.Etat = false;
			foreach (Gladiateur gladiater in gladiateur) 
			{
				if (gladiater.Etat) {
					gladCourant = gladiater;
				}
			}
			return gladCourant;
		}
/* ON RESET L'ETAT DES ARMES */
		public void flushEquipement(Gladiateur[] gladiateur){
			foreach (Gladiateur gladiater in gladiateur) 
			{
				foreach (Equipement equiper in gladiater.getEquipement) 
				{
					equiper.Utilise = false;
				}
			}
		}
/* ON DEBUTE UN TOURNOI ET ON RETOURNE LE JOUEUR GAGNANT*/
		public Joueur DebuterTournoi(Joueur J1, Joueur J2)
		{
			Console.WriteLine ("Match en cours; " +J1.Pseudo+" contre "+J2.Pseudo);
			System.Threading.Thread.Sleep (1500);
			while(J1.equipes[0].hasGladiateurOk() && J2.equipes[0].hasGladiateurOk()){
				flushEquipement(J1.equipes[0].gladiateurs);
				flushEquipement(J1.equipes[0].gladiateurs);
				Duel duelEnCours = new Duel(J1.equipes[0].gladiateurs[J1.equipes[0].DeterminerOrdreGlad()], J2.equipes[0].gladiateurs[J2.equipes[0].DeterminerOrdreGlad()]);
				duelEnCours.Bataille ();
			}
			if (J1.equipes [0].hasGladiateurOk ()) {
				return J1;
			} else {
				return J2;
			}
		}


	}
}

