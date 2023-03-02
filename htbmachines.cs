using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using RestSharp.Extensions;
using RestSharp.Serializers;
using System.Text.Json;
using Newtonsoft.Json;

namespace WpfApp3
{
    public class FeedbackForChart
    {
        public int counterCake { get; set; }
        public int counterVeryEasy { get; set; }
        public int counterEasy { get; set; }
        public int counterTooEasy { get; set; }
        public int counterMedium { get; set; }
        public int counterBitHard { get; set; }
        public int counterHard { get; set; }
        public int counterTooHard { get; set; }
        public int counterExHard { get; set; }
        public int counterBrainFuck { get; set; }
    }

   
    public class Maker
    {
        public int id { get; set; }
        public string name { get; set; }
        public string avatar { get; set; }
        public bool isRespected { get; set; }
    }

    public class Maker2
    {
        public int id { get; set; }
        public string name { get; set; }
        public string avatar { get; set; }
        public bool isRespected { get; set; }
    }



    class htbmachines
    {
        public htbmachines()
        {
            var client = new RestClient("https://www.hackthebox.com/api/v4/machine/list");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            /// Root machines = JsonConvert.DeserializeObject<Root>(response.Content);

        }
        public static void htbmachineico(string id, string avatar)
        {
            var uri = "https://www.hackthebox.com/";
            var client = new RestClient(uri);
            var request = new RestRequest(avatar, Method.GET);
            //request.AddHeader("Content-Type", "application/octet-stream");
            client.DownloadData(request).SaveAs("C:\\Users\\Antonio La Cokos\\source\\repos\\WpfApp3\\WpfApp3\\images\\avatars\\"+id+".png");
        }
        /*
        public class FeedbackForChart
        {
            public int counterCake { get; set; }
            public int counterVeryEasy { get; set; }
            public int counterEasy { get; set; }
            public int counterTooEasy { get; set; }
            public int counterMedium { get; set; }
            public int counterBitHard { get; set; }
            public int counterHard { get; set; }
            public int counterTooHard { get; set; }
            public int counterExHard { get; set; }
            public int counterBrainFuck { get; set; }
        }

        public class Info
        {
            public int id { get; set; }
            public string name { get; set; }
            public string os { get; set; }
            public int points { get; set; }
            public int static_points { get; set; }
            public DateTime release { get; set; }
            public int user_owns_count { get; set; }
            public int root_owns_count { get; set; }
            public bool? authUserInUserOwns { get; set; }
            public bool? authUserInRootOwns { get; set; }
            public bool isTodo { get; set; }
            public bool authUserHasReviewed { get; set; }
            public string stars { get; set; }
            public int difficulty { get; set; }
            public FeedbackForChart feedbackForChart { get; set; }
            public string avatar { get; set; }
            public string difficultyText { get; set; }
            public PlayInfo playInfo { get; set; }
            public bool free { get; set; }
            public Maker maker { get; set; }
            public Maker2 maker2 { get; set; }
            public int recommended { get; set; }
        }

        public class Maker
        {
            public int id { get; set; }
            public string name { get; set; }
            public string avatar { get; set; }
            public bool isRespected { get; set; }
        }

        public class Maker2
        {
            public int id { get; set; }
            public string name { get; set; }
            public string avatar { get; set; }
            public bool isRespected { get; set; }
        }

        public class PlayInfo
        {
            public bool isSpawned { get; set; }
            public object isSpawning { get; set; }
            public bool? isActive { get; set; }
            public object active_player_count { get; set; }
            public object expires_at { get; set; }
        }

        public class Root
        {
            public List<Info> info { get; set; }
        }
        */

    }
}
