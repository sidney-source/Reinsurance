using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows;

namespace Reinsurance
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        public bool MenuClosed { get; private set; }

        public MainWindow()
        {
            InitializeComponent();
            //mainFrame.Navigate(new Uri("Pages/loginpage.xaml", UriKind.RelativeOrAbsolute));
            

            //string connectionString = "SERVER=DESKTOP-S9FU8U1;DATABASE=ContractDb;UID=root;Password=;";

            //MySqlConnection connection = new MySqlConnection(connectionString);

            //MySqlCommand cmd = new MySqlCommand("select * from TblUsers", connection);
            //connection.Open();
            //DataTable dt = new DataTable();
            //dt.Load(cmd.ExecuteReader());
            //connection.Close();

            //Text1.Text = dt;
        }

        internal static Window GetWindow()
        {
            throw new NotImplementedException();
        }

        #region Dashboard Home Button
        private void Dashboard_btn_click(object sender, RoutedEventArgs e)
        {
            ViewWindow.Navigate(new Uri("Pages/Dashboard.xaml", UriKind.RelativeOrAbsolute));
            if (MenuDrawer.Width == new GridLength(38, GridUnitType.Star))
            {
                MenuDrawer.Width = new GridLength(7, GridUnitType.Star);
                TreatyDrawer.Height = new GridLength(50);
                FacDrawer.Height = new GridLength(50);
            }
            else
            {
                MenuDrawer.Width = new GridLength(38, GridUnitType.Star);
            }
        }
        #endregion

        #region Facultative Home Button
        private void Facultative_btn_click(object sender, RoutedEventArgs e)
        {
            if (MenuDrawer.Width == new GridLength(38, GridUnitType.Star))
            {
                MenuDrawer.Width = new GridLength(7, GridUnitType.Star);
                TreatyDrawer.Height = new GridLength(50);
                FacDrawer.Height = new GridLength(50);
            }
            else
            {
                MenuDrawer.Width = new GridLength(38, GridUnitType.Star);
            }

            
        }
        #endregion

        #region Treaty Home Button
        private void Treaty_btn_click(object sender, RoutedEventArgs e)
        {
            if (MenuDrawer.Width == new GridLength(38, GridUnitType.Star))
            {
                MenuDrawer.Width = new GridLength(7, GridUnitType.Star);
                TreatyDrawer.Height = new GridLength(50);
                FacDrawer.Height = new GridLength(50);
            }
            else
            {
                MenuDrawer.Width = new GridLength(38, GridUnitType.Star);
            }
        }
        #endregion

        #region Finance Home Button
        private void Finance_btn_click(object sender, RoutedEventArgs e)
        {
            if (MenuDrawer.Width == new GridLength(38, GridUnitType.Star))
            {
                MenuDrawer.Width = new GridLength(7, GridUnitType.Star);
                TreatyDrawer.Height = new GridLength(50);
                FacDrawer.Height = new GridLength(50);
            }
            else
            {
                MenuDrawer.Width = new GridLength(38, GridUnitType.Star);
            }
        }
        #endregion

        #region OpenDrawer Home Button
        private void Open_drawer(object sender, RoutedEventArgs e)
        {
            if (MenuDrawer.Width == new GridLength(38, GridUnitType.Star))
            {
                MenuDrawer.Width = new GridLength(7, GridUnitType.Star);
                TreatyDrawer.Height = new GridLength(50);
                FacDrawer.Height = new GridLength(50);
            }
            else
            {
                MenuDrawer.Width = new GridLength(38, GridUnitType.Star);
            }

        }
        #endregion

        private void TextBlock_PreviewMouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            
            FacDrawer.Height = FacDrawer.Height == new GridLength(50) ? new GridLength(130) : new GridLength(50);
        }

        private void TextBlock_PreviewMouseLeftButtonDown_1(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ViewWindow.Navigate(new Uri("Pages/Fac_Quote.xaml", UriKind.RelativeOrAbsolute));
            Tiwyr1.Text = "Facultative";
            Tiwyr2.Text = FacQt.Text;
        }

        private void TextBlock_PreviewMouseLeftButtonDown_3(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            TreatyDrawer.Height = TreatyDrawer.Height == new GridLength(50) ? new GridLength(130) : new GridLength(50);
        }

        private void TextBlock_PreviewMouseLeftButtonDown_2(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ViewWindow.Navigate(new Uri("Pages/Dashboard.xaml", UriKind.RelativeOrAbsolute));
        }
    }

}
