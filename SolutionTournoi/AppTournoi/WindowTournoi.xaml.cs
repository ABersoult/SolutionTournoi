using BddtournoiContext;
using DllTournoi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace AppTournoi
{
    /// <summary>
    /// Logique d'interaction pour WindowTournoi.xaml
    /// </summary>
    public partial class WindowTournoi : Window
    {
        bddtournoi bdd = new bddtournoi();
        List<Tournoi> tournoi = new List<Tournoi>();
        public WindowTournoi()
        {
            InitializeComponent();
            try
            {
                tournoi = bdd.getallTournois();
                if (tournoi != null)
                    this.LstwGestionTournoi.ItemsSource = tournoi;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                bdd.AjoutTournoi(this.txtIntituleTournoi.Text);
                MessageBox.Show("Tournoi ajouté avec succès");
                this.txtIntituleTournoi.Text = "";
                tournoi = bdd.getallTournois();
                if (tournoi != null)
                    this.LstwGestionTournoi.ItemsSource = tournoi;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
