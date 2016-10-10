using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DameDePique
{

    class Jeu
    {
        static Random random = new Random();

        // La classe Mere de bg notre Projet
        // Ces methodes seront called by le forme

        // Trois autres Joueur(s) ordinateur et vous 
        public List<Joueur> ListeDesJoueurs {
            get; set;
        }

        public List<Carte> ListeCartesEnJeu {
            get; set;
        }

        // Ordinateur
        public Joueur PlayerA {
            get; set;
        }

        // Ordinateur
        public Joueur PlayerN
        {
            get; set;
        }

        // Ordinateur
        public Joueur PlayerH
        {
            get; set;
        }

        // Vous
        public Joueur Player {
            get; set;
        }

        // Les Cartes 
        public Paquet Deck {
            get; set;
        }

        // La Coleur/Suit en jeu
        public Couleur Suit {
            get; set;
        }

        // L'usager choisit d'abord son nom et son image et apres le jeu commence
        public Jeu(Joueur player) {

            this.Player = player;
            this.PlayerA = new Joueur("Ahmad", "player-A.png");
            this.PlayerN = new Joueur("Nassim", "player-N.png");
            this.PlayerH = new Joueur("Halim", "player-H.png");

            // AJOUT dans la liste de joueurs 
            ListeDesJoueurs = new List<Joueur>();
            ListeDesJoueurs.Add(Player);
            ListeDesJoueurs.Add(PlayerA);
            ListeDesJoueurs.Add(PlayerN);
            ListeDesJoueurs.Add(PlayerH);

            // Initialize le Deck
            this.Deck = new Paquet(); // Creation des Carte(s) 

            // Initialize la liste pour mettre les Cartes en jeu
            this.ListeCartesEnJeu = new List<Carte>();
        }

        // Distribue les cartes aux Joueurs
        public void distribuer() {
            foreach (Joueur joueur in ListeDesJoueurs) {
                joueur.Paquet = Deck.Distribuer();
            }
        }

        // Celui qui commence 
        public void Starting() {
            // Celui qui a Deux de Trefle commence la partie
            Carte carte = new Carte(Couleur.Trefle, Valeur.Deux);
            foreach (Joueur player in ListeDesJoueurs) {
                if (player.Paquet.Contains(carte)) {

                }
            }
        }

        // Methode Ordinateur
        // A tour de role Thread.sleep pour les Ordinateurs
        public void putCarteInTable(Joueur joueur) {
            // Carte random correspondant a la Coleur/Suit de la table 
            Carte carte = null;
            // Jusqu'a qu'il trouve une Carte random qui correspont a la Coleur/Suit joue

            List<Carte> paquetDuJoueur = joueur.Paquet;
            List<Carte> cartesValide = new List<Carte>(); // Les Cartes qui peuvent etre joue

            // Met les cartes qui peuvent etre joue dans une Liste
            foreach(Carte card in paquetDuJoueur){
                if (card.Color == Suit) {
                    cartesValide.Add(carte);
                }
            }

            // Si elle n'est pas vide Alors le Joueur(Ordi) a une carte de la coleur en question qui peut etre joue
            if (cartesValide.Count != 0) {
                carte = cartesValide[random.Next(cartesValide.Count)];
                //joueur.CouleurExclus.Add(Suit);
            }
            else {
                // Il peut jouer un autre Coleur/Suit
                // boucle
            }

            // Ajout Success
            ListeCartesEnJeu.Add(carte);

        }

        public void verification() {
            // Utilise la liste ListeCartesEnJeu
        }


    }
}
