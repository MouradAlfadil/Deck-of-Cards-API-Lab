using Newtonsoft.Json;
using System.Net;

namespace Deck_of_Cards_Lab.Models
{
    public class DeckDAL
    {
        public static DeckModel GetDeck() //adjusthere
        {
            //ADJUST HERE
            //Setup
            string url = "https://deckofcardsapi.com/api/deck/new/draw/?count=5";

            //Request
            HttpWebRequest request = WebRequest.CreateHttp(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            //Converting to JSON
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string JSON = reader.ReadToEnd();

            //ADJUST HERE
            //converting to C#
            DeckModel result = JsonConvert.DeserializeObject<DeckModel>(JSON);
            return result;

        }
    }
}
