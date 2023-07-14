using Class_Practic_7._14date.Command;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;

namespace Class_Practic_7._14date.ViewModels
{
    public class AddImagePageViewModel:INotifyPropertyChanged
    {
        private string? _path;
        private ObservableCollection<string?>? _paths = new();

        public ObservableCollection<string?>? paths
        {
            get { return _paths; }
            set { _paths = value;
                propertyChanged();
            }
        }



        public string? path
        {
            get { return _path; }
            set { _path = value;
                propertyChanged();
            }
        }
        public event PropertyChangedEventHandler? PropertyChanged;

        public RealCommand? SelectButtonCommand { get; set; }


        public AddImagePageViewModel()
        {
            SelectButtonCommand = new RealCommand(selectBtn);

        }

        public void selectBtn(object? parametr)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.png; *.jpg; *.jpeg; *.gif)|*.png; *.jpg; *.jpeg; *.gif";
           

            if (openFileDialog.ShowDialog() == true)
            {
                string imagePath = openFileDialog.FileName;
                path = imagePath;
                paths!.Add(path);
                JsonSerializerOptions options = new JsonSerializerOptions();
                options.WriteIndented = true;

                File.WriteAllText("AllPath.json", JsonSerializer.Serialize(paths, options));

            }
        }

        public void propertyChanged([CallerMemberName] string? name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

    }
}
