using Newtonsoft.Json;
using System.Windows;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace Examwpf2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            GetData();
        }

        private void DataGrid_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

        }
        List<Property> GetData()
        {
            List<Property> qwe = new List<Property>();
            WebClient client = new WebClient();
            string url = "https://earthquake.usgs.gov/fdsnws/event/1/query?format=geojson&limit=";
            url += eventsCount.Text;
            var jsonEvent = client.DownloadString($"{url}");
            var result = JsonConvert.DeserializeObject<Featur>(jsonEvent);
            foreach (var feature in result.Features)
            {
                qwe.Add(feature.Properties);
            }
            eventsGrid.ItemsSource = qwe;
            return qwe;
        }
    }   
}
