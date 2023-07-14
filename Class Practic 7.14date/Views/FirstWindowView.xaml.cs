using Class_Practic_7._14date.Command;
using Class_Practic_7._14date.ViewModels;
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
using Class_Practic_7._14date.Views;


namespace Class_Practic_7._14date.Views
{

    public partial class FirstWindowView : Window
    {
        public RealCommand? AddButtonCommand { get; set; }
        public RealCommand? GalleryButtonCommand { get; set; }
        public FirstWindowView()
        {
            InitializeComponent();
            DataContext = this;
            AddButtonCommand = new RealCommand(addBtn);
            GalleryButtonCommand = new RealCommand(galleryBtn);
        }

        public void addBtn(object? parametr)
        {
            MyFrame.Content = new Class_Practic_7._14date.Views.AddImage();

        }

        public void galleryBtn(object? parametr)
        {
            MyFrame.Content = new Class_Practic_7._14date.Views.GalleryPage();

        }
    }
}
