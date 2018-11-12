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
    /// Interaction logic for DetailWindow.xaml
    /// </summary>
    public partial class DetailWindow : Window
    {
        Character _character = new Character();

        public DetailWindow(Character character)
        {
            InitializeComponent();
            _character = character;
            lbl_age.Content = "Age: " + _character.Age;
            lbl_title.Content = _character.FullName();
            lbl_gender.Content = "Gender: " + _character.Gender.ToString();
            lbl_description.Content = _character.Description;
            //img_charimage.Source = _character.ImageFileName;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
