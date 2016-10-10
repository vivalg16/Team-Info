using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DameDePique
{
    class Joueur
    {
        // Les Carte(s) qu'il aura/a en main 
        public List<Carte> Paquet {
            get; set;
        }

        public String Nom {
            get; set;
        }

        public String Image {
            get; set;
        }

        // Le Joueur n'a plus des cartes de cette Couleur
        public enum ColeurExclus { };

        public Joueur(String nom, String image) {
            this.Nom = nom;
            this.Image = image;
        }

        public override String ToString() {
            String deckEnString = "";
            foreach (Carte carte in Paquet) {
                deckEnString += carte.ToString() + "\n";
            }
            return deckEnString;
        }

    }
}
