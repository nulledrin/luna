using System;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Collections.Generic;
using RestSharp;
using Newtonsoft.Json;

namespace WpfApp3
{

    public partial class Dashboard2 : Page
    {
        public class Root
        {
            public List<info> info { get; set; }
        }
        public Dashboard2()
        {
            InitializeComponent();
            this.GenerateItems();
        }

        public void GenerateItems()
        {
            ArtistTreeNodeModel artistModel;
            var rootModel = new ArtistTreeNodeModel();
            var client = new RestClient("https://www.hackthebox.com/api/v4/machine/list");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("Authorization", "Bearer eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiJ9.eyJhdWQiOiI1IiwianRpIjoiYjE4YjAzZjA0Y2U3ZDYzYjBiZmRmNDVhZDA0MDI3OWZkYjc2N2UwYzVjOTEwYWY0MTYyNDI5NjNjYTE3ZmRmZGMyM2ZiZWViNTkxMDM1ZTMiLCJpYXQiOjE2NzY1Njc5OTkuODE2OTYzLCJuYmYiOjE2NzY1Njc5OTkuODE2OTY1LCJleHAiOjE2NzcxNzI3OTkuODA5Mjk2LCJzdWIiOiIxNzQ1MDkiLCJzY29wZXMiOlsiMmZhIl19.hn94otbeoD_l4P_v2Q2IQhoEFe-lmwY4uvKFo6wLftUxxvSvMFRJxSfeTt_TIFdT2iwe7QkKSNmuKBDOakRrXwE39FsWoEvwBIIm79Q7Ub7goj9Snb4t8xHb_iLsGXJvE9su43mKA5fn_R4SedX3Uw5uFrKND7awwhy6m-_R7JB1r8igFeMLExX991G885iO3izstMw7wqOgRsZiWn8C-9cgbikbYvX5IcBHNY71SFmGaLmg59Nxh8HB2b3jlCWtoI1EVWP4A0DlYJjLLqYm3Q5RyYOa_DhwwsB8atLqmAYQqF3nT4XCjEV7LPEGbhX8fVhM_LxI6vD6fiN1_6S-187HiYKrGj3tTCyiDrYFNeJ5Od8ot85NbVxe9okFjCTY_w4me72wzvsqJUNUH_a0ZSC8FzDNbigSam4kPk-H66uwM2T9II9qQE9viPZMse3K8xvvK9rM2hMNgET4ZTGDSRBS1_fBUl7CBqd_DbQzbvt-y_kSkRR6QnzF9Y8zg1tdnTzNKqSspMCIgsyZuGJycSqx4L5afXzhOASWKMIVm-Wc2QYEE8v-fTKEZJU6S13-UVFuuLdkVW1GcWH99Z5TmnSm_OxSARXYyssdhjCUqmO3VpaK6UwM_LNeRPPDxXS6c66GfvM_yJc9Yc3c7rBWBUUiqNZbzZVACh87itlb9jU");
            IRestResponse response = client.Execute(request);
            Root machines = JsonConvert.DeserializeObject<Root>(response.Content);
            artistModel = new ArtistTreeNodeModel() { ava="C:\\Users\\Antonio La Cokos\\source\\repos\\WpfApp3\\WpfApp3\\images\\avatars\\insane.png", Name = "Insane", IsExpanded = true };
            rootModel.Children.Add(artistModel);
            for (int i = 0; i < 20; i++)
            {
                /// htbmachines.htbmachineico(machines.info[i].id, machines.info[i].avatar);
                machines.info[i].ava = "C:\\Users\\Antonio La Cokos\\source\\repos\\WpfApp3\\WpfApp3\\images\\avatars\\" + machines.info[i].id + ".png";
                if (machines.info[i].authUserInRootOwns == "true") machines.info[i].isowned = "Root";
                else if (machines.info[i].authUserInUserOwns == "true") machines.info[i].isowned = "User";
                if (machines.info[i].difficultyText=="Insane") artistModel.Children.Add(machines.info[i]);
            }
            artistModel = new ArtistTreeNodeModel() { ava = "C:\\Users\\Antonio La Cokos\\source\\repos\\WpfApp3\\WpfApp3\\images\\avatars\\hard.png", Name = "Hard", IsExpanded = true };
            rootModel.Children.Add(artistModel);
            for (int i = 0; i < 20; i++)
            {
                if (machines.info[i].difficultyText == "Hard") artistModel.Children.Add(machines.info[i]);
            }
            artistModel = new ArtistTreeNodeModel() { ava = "C:\\Users\\Antonio La Cokos\\source\\repos\\WpfApp3\\WpfApp3\\images\\avatars\\medium.png", Name = "Medium", IsExpanded = true };
            rootModel.Children.Add(artistModel);
            for (int i = 0; i < 20; i++)
            {
                if (machines.info[i].difficultyText == "Medium") artistModel.Children.Add(machines.info[i]);
            }
            artistModel = new ArtistTreeNodeModel() { ava = "C:\\Users\\Antonio La Cokos\\source\\repos\\WpfApp3\\WpfApp3\\images\\avatars\\easy.png", Name = "Easy", IsExpanded = true };
            rootModel.Children.Add(artistModel);
            for (int i = 0; i < 20; i++)
            {
                if (machines.info[i].difficultyText == "Easy") artistModel.Children.Add(machines.info[i]);
            }
            this.DataContext = rootModel;
        }
    }

    public class ArtistTreeNodeModel : TreeNodeModel
    {
        /// <summary>
        /// Gets or sets the length.
        /// </summary>
        /// <value>
        /// The length.
        public string value;
        public string ava;
        /// </value>
        public ArtistTreeNodeModel()
        {
            var imageUri = new Uri("images/user.png", UriKind.Relative);
            this.ImageSource = new BitmapImage(imageUri);
        }


    }
        public class PlayInfo
    {
        public string isSpawned { get; set; }
        public object isSpawning { get; set; }
        public string isActive { get; set; }
        public object active_player_count { get; set; }
        public object expires_at { get; set; }
    }

    public class info : TreeNodeModel
    {


        public string os { get; set; }
        public int usersowns { get; set; }
        public int rootowns { get; set; }
        public double rating { get; set; }
        public string difficulty { get; set; }
        public string isowned { get; set; }
        public int id { get; set; }
        public string Name { get; set; }
        public int points { get; set; }
        public int static_points { get; set; }
        public DateTime release { get; set; }
        public int user_owns_count { get; set; }
        public int root_owns_count { get; set; }
        public string authUserInUserOwns { get; set; }
        public string authUserInRootOwns { get; set; }
        public bool isTodo { get; set; }
        public bool authUserHasReviewed { get; set; }
        public string stars { get; set; }
        public FeedbackForChart feedbackForChart { get; set; }
        public string avatar { get; set; }
        public string difficultyText { get; set; }
        public PlayInfo playInfo { get; set; }
        public bool free { get; set; }
        public Maker maker { get; set; }
        public Maker2 maker2 { get; set; }
        public int recommended { get; set; }
        public string ava { get; set; }

        public info()

        {

            var imageUri = new Uri("/images/otp.png", UriKind.Relative);
            this.ImageSource = new BitmapImage(imageUri);
        }

    }

}