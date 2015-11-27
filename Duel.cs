using System;
using System.Collections.Generic;

namespace MyNameIsGladiator
{
	public class Duel
	{
		Gladiateur G1;
		Gladiateur G2;
		public Duel (Gladiateur G1, Gladiateur G2)
		{
			this.G1 = G1;
			this.G2 = G2;
		}
/* ON DETERMINE L'ARME PRIORITAIRE */
		public Equipement armePrio(List<Equipement> equipement)
		{
			Equipement armeCourante= new Equipement();
			armeCourante.Priorite = 10;
			foreach (Equipement equiper in equipement) 
			{
				if (armeCourante.Priorite > equiper.Priorite && !equiper.Utilise) {
					armeCourante = equiper;
				}
			}
			return armeCourante;
		}

/* DEROULEMENT D'UN DUEL DE GLADIATEUR*/
		public void Bataille()
		{
			Console.WriteLine ("Le duel opposant " + G1.nomGladiateur + " contre " + G2.nomGladiateur + " va commencer !");
			while (G1.Etat == true && G2.Etat == true) 
			{
				Equipement armeCouranteG1 = armePrio(G1.getEquipement);
				Equipement armeCouranteG2 = armePrio(G2.getEquipement);
				Random rand = new Random();
/* SI TOUTES LES ARMES SONT UTILISES EN CAS DE RATE, ON RECOMMENCE LE DUEL */
				if(armeCouranteG1.Priorite == 10 && armeCouranteG2.Priorite == 10){
				Console.WriteLine ("Le combat se termine car ils n'ont plus d'arme. Le duel va se relancer");
					break;
				}
/* ON DETERMINE SI LE JOUEUR 1 ATTAQUE */
				if (armeCouranteG1.Priorite < armeCouranteG2.Priorite) {
					Console.WriteLine (G1.nomGladiateur + " utilise l'arme: " + armeCouranteG1.Nom);
					int score = rand.Next (0, 100);
					System.Threading.Thread.Sleep (1500);
					if (score < armeCouranteG1.Precision) {
						bool blocageReussi = false;
/* ON DETERMINE S'IL LE DEFENSEUR POSSEDE UN EQUIPEMENT DEFENSIF ET S'IL BLOQUE */
						foreach (Equipement equiper in G2.getEquipement) {
							if (equiper.Blocage > 0) {
								int scoreBloquer = rand.Next (0, 100);
								if (scoreBloquer < equiper.Blocage) {
									blocageReussi = true;
									Console.WriteLine ("Le coup a été bloqué avec le " + equiper.Nom);
									System.Threading.Thread.Sleep (1500);
									break;
								}
							} 
						}
						if (!blocageReussi) {
							G2.Etat = false;
							Console.WriteLine ("Le gladiateur: "+ G1.nomGladiateur + " touche et remporte la victoire !");	
							System.Threading.Thread.Sleep (1500);
						}
					} else {
						Console.WriteLine (G1.nomGladiateur + "a raté son coup !");
						System.Threading.Thread.Sleep (1500);
					}
					armeCouranteG1.Utilise = true;
/* ON DETERMINE SI LE JOUEUR 2 ATTAQUE */
				} else if (armeCouranteG1.Priorite > armeCouranteG2.Priorite) {
					Console.WriteLine (G2.nomGladiateur + " utilise l'arme: " + armeCouranteG2.Nom);
					int score = rand.Next (0, 100);
					System.Threading.Thread.Sleep (1500);
					if (score < armeCouranteG2.Precision) {
						bool blocageReussi = false;
						foreach (Equipement equiper in G2.getEquipement) {
							if (equiper.Blocage > 0) {
								int scoreBloquer = rand.Next (0, 100);
								if (scoreBloquer < equiper.Blocage) {
									blocageReussi = true;
									Console.WriteLine ("Le coup a été bloqué avec le " + equiper.Nom);
									System.Threading.Thread.Sleep (1500);
									break;
								}
							} 
						}
						if (!blocageReussi) {
							G2.Etat = false;
							Console.WriteLine ("Le gladiateur: "+ G2.nomGladiateur + " touche et remporte la victoire !");				
						}
					} else {
						Console.WriteLine (G2.nomGladiateur + "a raté son coup !");
						System.Threading.Thread.Sleep (1500);
					}
					armeCouranteG2.Utilise = true;
				} 
/* SI LES 2 JOUEURS ONT LA MËME ARME, UN JOUEUR ALEATOIRE EST CHOISIT */
				else {
					int score = rand.Next (1, 3);
					if (score == 1) {
						score = rand.Next (0, 100);
						Console.WriteLine (G1.nomGladiateur + " utilise l'arme: " + armeCouranteG1.Nom);
						System.Threading.Thread.Sleep (1500);
						if (score < armeCouranteG1.Precision) {
							G2.Etat = false;
							Console.WriteLine ("Le gladiateur: "+ G1.nomGladiateur + " touche et remporte la victoire !");
						} else {
							Console.WriteLine (G1.nomGladiateur + "a raté son coup !");
						}
						armeCouranteG1.Utilise = true;
					} else {
						score = rand.Next (0, 100);
						Console.WriteLine (G2.nomGladiateur + " utilise l'arme: " + armeCouranteG2.Nom);
						System.Threading.Thread.Sleep (1500);
						if (score < armeCouranteG2.Precision) {
							G1.Etat = false;
							Console.WriteLine ("Le gladiateur: "+ G2.nomGladiateur + " touche et remporte la victoire !");
						} else {
							Console.WriteLine (G2.nomGladiateur + "a raté son coup !");
						}
						armeCouranteG2.Utilise = true;
					}
						
				}
			}
				
		}
	}
}

