using Newtonsoft.Json;
using System.Diagnostics;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;


namespace ChefRisingStar.Models
{

    public class Rank
    {
        [JsonProperty("Ranking")]
        public string Ranking { get; set; }

        [JsonProperty("Recipe")]
        public string Recipe { get; set; }

        [JsonProperty("Rating")]
        public string Rating { get; set; }

        [JsonProperty("Link")]
        public string Link { get; set; }

        public ICommand OpenWebCommand { get; }
        public Rank()
        {
            OpenWebCommand = new Command(async () => await Browser.OpenAsync(Link));
        }
    }
}
