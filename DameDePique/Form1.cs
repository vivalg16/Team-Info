using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DameDePique
{
    public partial class Form1 : Form
    {
        private Jeu jeu;

        public Form1()
        {
            InitializeComponent();
            // Ouvre form de style ou l'usager choisit son bonhomme et ecrit son nom
            Joueur player = new Joueur("Moi", "image.png");

            // Jeu
            this.jeu = new Jeu(player);
            jeu.distribuer();
            richTextBox1.AppendText(jeu.Player.ToString());
            richTextBox1.AppendText(jeu.PlayerA.ToString());
            richTextBox1.AppendText(jeu.PlayerN.ToString());
            richTextBox1.AppendText(jeu.PlayerH.ToString());
        }
    }
}
