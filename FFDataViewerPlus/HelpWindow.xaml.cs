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

namespace FFDataViewerPlus
{
    /// <summary>
    /// Interaction logic for HelpWindow.xaml
    /// </summary>
    public partial class HelpWindow : Window
    {
        public HelpWindow()
        {
            InitializeComponent();
            lbl_actualhelp.Content = "Welcome to the Final Fantasy data viewer!\n\nDelete Selected button deletes any selected character(s) on the data viewer.\n\nView Detail button gives you details on any one character you have selected (work in progress)\n\nSorting is done by clicking on the header you wish from.\n\nThe Filter button filters gender by Female.\n\nSearch by Last Name searches throughout the data for any data you have \ntyped in the text box next to the button.\n\nHelp button is how you got here.\n\nExit button is to exit the program.\n\nThank you for using my program!";
        }

        private void btn_close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
