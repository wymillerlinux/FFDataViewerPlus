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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;
using System.ComponentModel;

namespace FFDataViewerPlus
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Character> _characters;

        public MainWindow()
        {
            InitializeComponent();
            ReadFromXMLToDataGrid();
        }

        private void ReadFromXMLToDataGrid()
        {
            string dataFilePath = AppConfig.dataFilePath;

            XmlDataService dataService = new XmlDataService(dataFilePath);
            _characters = dataService.ReadAll();

            var bindingList = new BindingList<Character>(_characters);
            var source = new DataSet();
            source.ReadXml(dataFilePath);
            dataGridFF.ItemsSource = source.Tables[0].DefaultView;
        }

        private void btn_exit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                XmlDataService XmlDataService = new XmlDataService(AppConfig.dataFilePath);
                XmlDataService.WriteAll(_characters);
            }
            catch (Exception)
            {
                throw;
            }

            this.Close();
        }

        private void btn_viewdetail_Click(object sender, RoutedEventArgs e)
        {
            // Tried getting this to work

            //Character character = new Character();
            //character = (Character)dataGridFF.DataContext;

            //DetailWindow detail = new DetailWindow(character);
            //detail.ShowDialog();

            Character character = _characters[dataGridFF.SelectedIndex];
            DetailWindow detailWindow = new DetailWindow(character);
            detailWindow.Show();
        }

        private void btn_search_Click(object sender, RoutedEventArgs e)
        {
            string searchTerm = txtbox_box1.Text;
            var searchedList = _characters.Where(c => c.LastName.ToUpper().Contains(searchTerm.ToUpper())).ToList();

            if (searchedList == null)
            {
                MessageBox.Show("Nothing to search! Please try again.");
            }
            else
            {
                dataGridFF.ItemsSource = searchedList;
            }
        }

        private void btn_help_Click(object sender, RoutedEventArgs e)
        {
            HelpWindow help = new HelpWindow();
            help.ShowDialog();
        }

        private void btn_filter_Click(object sender, RoutedEventArgs e)
        {
            var filteredList = _characters.Where(c => c.Gender == Character.GenderType.Female).ToList();

            if (filteredList == null)
            {
                MessageBox.Show("Nothing to filter! Please try again.");
            }
            else
            {
                dataGridFF.ItemsSource = filteredList;
            }
        }
    }
}
