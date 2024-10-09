using BddtournoiContext;
using DllTournoi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AppTournoi
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Participant> participants;
        List<Sport> sport;
        List<Tournoi> tournoi;
        bddtournoi bdd = new bddtournoi();
        public MainWindow()
        {
            InitializeComponent();
            this.LVParticipants.Visibility = Visibility.Hidden;       
            this.GBInfoParticipant.Visibility = Visibility.Hidden;
            this.LVTournois.Visibility = Visibility.Hidden;
            this.DGTournois.Visibility = Visibility.Hidden;
            this.DGSports.Visibility = Visibility.Hidden;
            this.LVSports.Visibility = Visibility.Hidden;
        }

        private void BConnexionBdd_Click(object sender, RoutedEventArgs e)
        {
            string IPv4 = Properties.Settings.Default.IPv4;
            string port = Properties.Settings.Default.Port;
            string utilisateur = Properties.Settings.Default.Login;
            string mdp = Properties.Settings.Default.Mdp;
            bddtournoi bddparam = new bddtournoi(IPv4, port, utilisateur, mdp);
            if (bddparam != null)
            {
                BTabParticipants.IsEnabled = true;
                TBSports.IsEnabled = true;
                TBTournois.IsEnabled = true;
                BSettings.IsEnabled = true;
            }
        }

        private void BGestionnaire_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                WindowGestionnaire wingest = new WindowGestionnaire();
                if (wingest.ShowDialog() == true)
                {
                    BGestionSports.IsEnabled = true;
                    BGestionTournois.IsEnabled = true;
                    BGestionParticipants.IsEnabled = true;
                    BSettings.IsEnabled = true;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void BGestionSports_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                WindowGestionSports gestSport = new WindowGestionSports();
                gestSport.ShowDialog();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void BGestionTournois_Click(object sender, RoutedEventArgs e)
        {
            WindowTournoi gestTournoi = new WindowTournoi();
            gestTournoi.ShowDialog();
        }

        private void BGestionParticipants_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BTabParticipants_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                this.GBInfoParticipant.Visibility = Visibility.Visible;
                this.LVParticipants.Visibility = Visibility.Visible;
                this.LVTournois.Visibility = Visibility.Hidden;
                this.DGTournois.Visibility = Visibility.Hidden;
                this.DGSports.Visibility = Visibility.Hidden;
                this.LVSports.Visibility = Visibility.Hidden;
                participants = bdd.getallParticipants();
                if (participants != null)
                    this.LVParticipants.ItemsSource = participants;
            }catch (Exception) { throw new Exception("Le tableau dess participants n'a pas pu être récupéré"); }
        }

        private void TBSports_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                this.LVSports.Visibility = Visibility.Visible;
                this.DGSports.Visibility = Visibility.Visible;
                this.DGTournois.Visibility = Visibility.Hidden;
                this.LVTournois.Visibility = Visibility.Hidden;
                this.GBInfoParticipant.Visibility = Visibility.Hidden;
                this.LVParticipants.Visibility = Visibility.Hidden;
                sport = bdd.getallSports();
                if (sport != null)
                    this.LVSports.ItemsSource = sport;
            }catch(Exception) { throw new Exception("Le tableau des sports n'a pas pu être ouvert"); }
        }

        private void TBTournois_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                this.DGTournois.Visibility = Visibility.Visible;
                this.LVTournois.Visibility = Visibility.Visible;
                this.GBInfoParticipant.Visibility = Visibility.Hidden;
                this.LVParticipants.Visibility = Visibility.Hidden;
                this.LVSports.Visibility = Visibility.Hidden;
                this.DGSports.Visibility = Visibility.Hidden;
                tournoi = bdd.getallTournois();
                if (tournoi != null)
                    this.LVTournois.ItemsSource = tournoi;
            }catch (Exception) { throw new Exception("La fenêtre n'a pas pu être ouverte"); }
        }
        private void BSettings_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                WindowSettings paramBDD = new WindowSettings();
                paramBDD.TIPv4.Text = Properties.Settings.Default.IPv4;
                paramBDD.TPort.Text = Properties.Settings.Default.Port;
                paramBDD.TLogin.Text = Properties.Settings.Default.Login;
                paramBDD.TMdp.Password = Properties.Settings.Default.Mdp;
                paramBDD.TNomServeur.Text = Properties.Settings.Default.NomServ;
                if (paramBDD.ShowDialog() == true)
                {
                    Properties.Settings.Default.IPv4 = paramBDD.TIPv4.Text;
                    Properties.Settings.Default.Port = paramBDD.TPort.Text;
                    Properties.Settings.Default.Login = paramBDD.TLogin.Text;
                    Properties.Settings.Default.Mdp = paramBDD.TMdp.Password;
                    Properties.Settings.Default.NomServ = paramBDD.TNomServeur.Text;
                    Properties.Settings.Default.Save();
                }
            }
            catch (Exception){ throw new Exception ("Erreur de suavegarde des paramètres"); }
        }
        private void LVParticipants_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                if (sender is ListView && LVParticipants.SelectedIndex != -1)
                {
                    Participant participantSelected = (Participant)(sender as ListView).SelectedItem;
                    this.TBNom.Text = participantSelected.Nom;
                    this.TBPrenom.Text = participantSelected.Prenom;
                    this.TBDateNaissance.Text = participantSelected.DateNaissance.ToString();
                    this.TBSport.Text = participantSelected.Sport.Intitule;
                    this.TBTournoi.Text = participantSelected.Tournoi.Intitule;
                    this.imgJoueur.Source = GestionImage.ConvertByteArrayToBitmapImage(participantSelected.Photo);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void LVTournois_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Tournoi tournoiSelected = (Tournoi)(sender as ListView).SelectedItem;
            participants = bdd.getParticipantsPourTournoi(tournoiSelected);
            this.DGTournois.ItemsSource = participants;
        }

        private void LVSports_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Sport sportSelected = (Sport)(sender as ListView).SelectedItem;
            participants = bdd.getParticipantsPourSport(sportSelected);
            this.DGSports.ItemsSource = participants;
        }
    }
}