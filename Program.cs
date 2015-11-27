using System;

namespace MyNameIsGladiator
{
	class MainClass
	{
		public static void Main (string[] args)
		{
/* ON INITIALISE LES ARMES */
			Dague Dague = new Dague();
			Epee Epee = new Epee();
			Epee Epee2 = new Epee();
			Lance Lance = new Lance();
			Lance Lance2 = new Lance();
			Trident Trident = new Trident();
			Filet Filet = new Filet();
			BouclierRond BouclierRond = new BouclierRond();
			BouclierRect BouclierRect = new BouclierRect();
			Casque Casque = new Casque();
/* CREATION DU JOUEUR 1 ET DE SON EQUIPE */
			Joueur Joueur1 = new Joueur("Mavillaz","Remi","Kize");
			Equipe Equipe1 = new Equipe("Good Game","Impossible a battre");
			Joueur1.CreerEquipe(Equipe1, 0);
			Gladiateur Glad1 = new Gladiateur ("Maximus", 1);
			Gladiateur Glad2 = new Gladiateur ("Petraites", 2);
			Gladiateur Glad3 = new Gladiateur ("Prudens", 3);
			Equipe1.CreerGladiateur (Glad1, 0);
			Glad1.AjouterEquipement (Epee);
			Glad1.AjouterEquipement (BouclierRond);
			Equipe1.CreerGladiateur (Glad2, 1);
			Glad2.AjouterEquipement (Dague);
			Glad2.AjouterEquipement (Trident);
			Glad2.AjouterEquipement (BouclierRond);
			Equipe1.CreerGladiateur (Glad3, 2);
			Glad3.AjouterEquipement (Dague);
			Glad3.AjouterEquipement (Lance);
/* CREATION DU JOUEUR 2 ET DE SON EQUIPE */
			Joueur Joueur2 = new Joueur("Jean","Guy","DarkNoob");
			Equipe Equipe2 = new Equipe("Fnatic","Champion de LoL");
			Joueur2.CreerEquipe(Equipe2, 0);
			Gladiateur Glad4 = new Gladiateur ("Carpophorus", 2);
			Gladiateur Glad5 = new Gladiateur ("Crixus", 3);
			Gladiateur Glad6 = new Gladiateur ("Commodus", 1);
			Equipe2.CreerGladiateur (Glad4, 0);
			Glad4.AjouterEquipement (Epee2);
			Glad4.AjouterEquipement (Filet);
			Equipe2.CreerGladiateur (Glad5, 1);
			Glad5.AjouterEquipement (Lance);
			Glad5.AjouterEquipement (Casque);
			Equipe2.CreerGladiateur (Glad6, 2);
			Glad6.AjouterEquipement (Dague);
			Glad6.AjouterEquipement (Casque);
			Glad6.AjouterEquipement (BouclierRond);
/* CREATION DU JOUEUR 3 ET DE SON EQUIPE */
			Joueur Joueur3 = new Joueur("Jeremy","Amzalak","Torlk");
			Equipe Equipe3 = new Equipe("Millenium","Champion d'Hearthstone");
			Joueur3.CreerEquipe(Equipe3, 0);
			Gladiateur Glad7 = new Gladiateur ("Spiculus", 1);
			Gladiateur Glad8 = new Gladiateur ("Marcus", 3);
			Gladiateur Glad9 = new Gladiateur ("Attilius", 2);
			Equipe3.CreerGladiateur (Glad7, 0);
			Glad7.AjouterEquipement (Epee2);
			Glad7.AjouterEquipement (Filet);
			Equipe3.CreerGladiateur (Glad8, 1);
			Glad8.AjouterEquipement (Lance);
			Glad8.AjouterEquipement (Casque);
			Equipe3.CreerGladiateur (Glad9, 2);
			Glad9.AjouterEquipement (Dague);
			Glad9.AjouterEquipement (Casque);
			Glad9.AjouterEquipement (BouclierRond);
/* CREATION DU JOUEUR 4 ET DE SON EQUIPE */
			Joueur Joueur4 = new Joueur("John","Shepard","Augure");
			Equipe Equipe4 = new Equipe("Spectre","Les moissonneurs arrivent !");
			Joueur4.CreerEquipe(Equipe4, 0);
			Gladiateur Glad10 = new Gladiateur ("Flamma", 1);
			Gladiateur Glad11 = new Gladiateur ("Verus", 2);
			Gladiateur Glad12 = new Gladiateur ("Spartacus", 3);
			Equipe4.CreerGladiateur (Glad10, 0);
			Glad10.AjouterEquipement (Epee);
			Glad10.AjouterEquipement (BouclierRond);
			Equipe4.CreerGladiateur (Glad11, 1);
			Glad11.AjouterEquipement (Dague);
			Glad11.AjouterEquipement (Trident);
			Glad11.AjouterEquipement (BouclierRond);
			Equipe4.CreerGladiateur (Glad12, 2);
			Glad12.AjouterEquipement (Dague);
			Glad12.AjouterEquipement (Lance2);
/* CREATION DU TOURNOI */
			//Joueur[] joueurs = new Joueur[2];
			Tournoi Tournoi = new Tournoi(new Joueur[]{Joueur1, Joueur2, Joueur3, Joueur4});
/* AFFICHAGE DU JOUEUR ET DE SES EQUIPES */
			Console.WriteLine ("________________________________");
			Console.WriteLine ("____ BIENVENUE DANS L'ARENE ____");
			Console.WriteLine ("________________________________");
			Console.WriteLine (" ");
			Console.WriteLine ("PRESENTION DU PREMIER JOUEUR");
			Console.WriteLine (Joueur1.AfficherJoueur());
			Console.WriteLine ("EQUIPE: " + Joueur1.AfficherEquipe (0));
			Console.WriteLine ("GLADIATEURS: " + Equipe1.AfficherGladiateur(0) + " - " + Equipe1.AfficherGladiateur(1) + " - " + Equipe1.AfficherGladiateur(2));
			Console.WriteLine ("__________________________");
			Console.WriteLine (Joueur2.AfficherJoueur());
			Console.WriteLine ("EQUIPE: " + Joueur2.AfficherEquipe (0));
			Console.WriteLine ("GLADIATEURS: " + Equipe2.AfficherGladiateur(0) + " - " + Equipe2.AfficherGladiateur(1) + " - " + Equipe2.AfficherGladiateur(2));
			Console.WriteLine ("__________________________");
			Console.WriteLine (Joueur3.AfficherJoueur());
			Console.WriteLine ("EQUIPE: " + Joueur3.AfficherEquipe (0));
			Console.WriteLine ("GLADIATEURS: " + Equipe3.AfficherGladiateur(0) + " - " + Equipe3.AfficherGladiateur(1) + " - " + Equipe3.AfficherGladiateur(2));
			Console.WriteLine ("__________________________");
			Console.WriteLine (Joueur4.AfficherJoueur());
			Console.WriteLine ("EQUIPE: " + Joueur4.AfficherEquipe (0));
			Console.WriteLine ("GLADIATEURS: " + Equipe4.AfficherGladiateur(0) + " - " + Equipe4.AfficherGladiateur(1) + " - " + Equipe4.AfficherGladiateur(2));
			Console.WriteLine ("__________________________");
			Console.WriteLine ("Les combats vont commencer");
/* DEROULEMENT DU TOURNOI */
			Joueur joueurGagnant = Tournoi.DebuterTournoi (Joueur1, Joueur2);
			Console.WriteLine ("-----------------------------------------------------");
			Console.WriteLine ("Le joueur "+ joueurGagnant.Pseudo+" a gagné le match!");
			Console.WriteLine ("-----------------------------------------------------");
			Joueur joueurGagnant2 = Tournoi.DebuterTournoi (Joueur3, Joueur4);
			Joueur joueurFinal = Tournoi.DebuterTournoi (joueurGagnant,joueurGagnant2);
			Console.WriteLine ("-----------------------------------------------------");
			Console.WriteLine ("Le joueur "+ joueurFinal.Pseudo+" a remporté le tournoi!");
			Console.WriteLine ("-----------------------------------------------------");
			Console.Read ();
		}
	}
}
