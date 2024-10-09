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
    /// Logique d'interaction pour WindowGestionnaire.xaml
    /// </summary>
    public partial class WindowGestionnaire : Window
    {
        public WindowGestionnaire()
        {
            InitializeComponent();
        }
        private void BTValider_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string log = TBlog.Text;
                string mdp = TBPassword.Password;
                if (log == "admin," && mdp == "Password1234@ciel")
                {
                    MessageBox.Show("Connexion établie");
                    DialogResult = true;
                }
                else
                {
                    MessageBox.Show("Mauvais login ou mauvais mot de passe");
                    TBlog.Clear();
                    TBPassword.Clear();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
