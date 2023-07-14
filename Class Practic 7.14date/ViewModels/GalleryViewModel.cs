using Class_Practic_7._14date.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;


namespace Class_Practic_7._14date.ViewModels
{
    public class GalleryViewModel 
    {
        public ObservableCollection<Image> Sekiller { get; set; } = new();
        public ObservableCollection<string> Sekiller1 { get; set; } = Read<ObservableCollection<string>>("AllPath.json");
        public static T Read<T>(string filePath)
        {
            try
            {
                string text = File.ReadAllText(filePath);
                return JsonSerializer.Deserialize<T>(text);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return default(T);
        }



        public GalleryViewModel()
        {



            foreach (var item in Sekiller1)
            {
                Sekiller.Add(new Image() { Source = new BitmapImage(new Uri(item)) });
            }
        }
    }
}
