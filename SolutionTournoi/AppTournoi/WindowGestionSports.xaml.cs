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
    /// Logique d'interaction pour WindowGestionSports.xaml
    /// </summary>
    public partial class WindowGestionSports : Window
    {
        bddtournoi bdd = new bddtournoi();
        List<Sport> sport = new List<Sport>();
        public WindowGestionSports()
        {
            InitializeComponent();
            try
            {
                sport = bdd.getallSports();
                if (sport != null)
                    this.LstwGestionSport.ItemsSource = sport;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                bdd.AjoutSport(this.txtIntituleSport.Text);
                MessageBox.Show("Sport ajouté avec succès");
                this.txtIntituleSport.Text = "";
                sport = bdd.getallSports();
                if (sport != null)
                    this.LstwGestionSport.ItemsSource = sport;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void LstwGestionSport_MouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            if(cm ==
        }
    }
}
