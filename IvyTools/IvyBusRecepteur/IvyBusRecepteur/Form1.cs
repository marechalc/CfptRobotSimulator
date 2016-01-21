/**
 * Author       : Gilles Bergerat
 * Description  : Receptor
 * Class        : T.IS-E2A
 * Date         : 10.12.2015
 * Version      : 1.0
 * */
using System;
using System.Windows.Forms;
using IvyBus;
namespace IvyTools
{
    public partial class Form1 : Form
    {
        private Ivy bus;
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Affiche les données reçues dans un listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addMessage(object sender, IvyMessageEventArgs e)
        {
            foreach (var message in e.GetArguments())
            {
                lbxDonnees.Items.Add(message + " ");
            }
        }

        /// <summary>
        /// Permet de changer d'abonnement à un messgae
        /// </summary>
        private void changementMesage()
        {
            bus.Stop();

            bus = new Ivy();

            try
            {
                bus.Start(tbxAdresse.Text);
            }
            catch (IvyException ie)
            {
                MessageBox.Show("Erreur " + ie.GetBaseException());
            }


        }
        private void btnConenxion_Click(object sender, System.EventArgs e)
        {
            bus = new Ivy("mon_appli", "mon_appli Ready");

            try
            {
                bus.Start(tbxAdresse.Text);
                MessageBox.Show("Vous êtes connecté");

                // On récupère tous les messages qui circulent sur le bus et on les stocke dans un listbox
                //bus.BindMsg("^(Y =.*|X = .*)", addMessage);
            }
            catch (IvyException ie)
            {
                MessageBox.Show("Erreur " + ie.GetBaseException());
            }
        }

        private void btnDeconnexion_Click(object sender, EventArgs e)
        {
            bus.Stop();
            MessageBox.Show("Vous êtes déconnecté");
        }

        private void cbxChoixRegle_SelectedIndexChanged(object sender, EventArgs e)
        {
            changementMesage();
            int choix = cbxChoixRegle.SelectedIndex;
            switch (choix)
            {
                case 0:
                    bus.BindMsg("^(PositionChanged.*)", addMessage);
                    break;
                case 1:
                    bus.BindMsg("^(OrientationChanged.*)", addMessage);
                    break;
                case 2:
                    bus.BindMsg("^(X = .*)", addMessage);
                    break;
                case 3:
                    bus.BindMsg("^(Y =.*)", addMessage);
                    break;
                case 4:
                    bus.BindMsg("^(Y =.*|X = .*)", addMessage);
                    break;
                default:
                    break;
            }
        }

    }
}
