using Class_Practic_7._14date.Command;
using Class_Practic_7._14date.ViewModels;
using Microsoft.Win32;
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

namespace Class_Practic_7._14date.Views
{
    /// <summary>
    /// Interaction logic for AddImage.xaml
    /// </summary>
    public partial class AddImage : Page
    {


        public AddImage()
        {
            InitializeComponent();
            DataContext = new AddImagePageViewModel();
        }


     
    }
}
