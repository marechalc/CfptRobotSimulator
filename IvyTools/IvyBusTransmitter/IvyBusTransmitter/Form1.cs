/**
 * Author       : Gilles Bergerat
 * Description  : Emetor
 * Class        : T.IS-E2A
 * Date         : 10.12.2015
 * Version      : 1.0
 * */
using System;
using System.Windows.Forms;
using IvyBus;
namespace IviBusEmeteur
{
    public partial class Form1 : Form
    {
        private Ivy bus;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            // Création du bus
            bus = new Ivy("mon_appli", "Emetteur Ready!");

            // On essaie de se connecter à l'adresse saisie par l'utilisateur
            try
            {
                bus.Start(tbxAdresse.Text);
                MessageBox.Show("Vous êtes connecté");
                timer1.Start();
            }
            catch (IvyException ie)
            {
                MessageBox.Show("Erreur " + ie.GetBaseException());
            }
        }

        private void btnEnvoyer_Click(object sender, EventArgs e)
        {
            // On envoie le message de l'utilisateur sur le bus
            bus.SendMsg(tbxMessage.Text);
            tbxMessage.Clear();
        }

        private void btnDeconnexion_Click(object sender, EventArgs e)
        {
            // On se déconnecte du bus
            timer1.Stop();
            MessageBox.Show("Vous êtes déconnecté!");
            bus.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Donnees donnee = new Donnees();
            bus.SendMsg(donnee.envoiDonneesX());
            bus.SendMsg(donnee.envoiDonneesY());
            bus.SendMsg(donnee.positionChanger());
            bus.SendMsg(donnee.orientationChanged());
        }
    }
}
