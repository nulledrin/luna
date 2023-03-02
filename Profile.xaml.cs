using ActiproSoftware.Windows;
using ActiproSoftware.Windows.Themes;
using ActiproSoftware.Windows.Themes.Generation;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System;
using System.Windows.Media.Imaging;
using System.Collections.Generic;
using RestSharp;
using Newtonsoft.Json;
using WpfApp3;

namespace WpfApp3


{

    public class showoflist
    {
        public List<showof> showofs { get; set; }
    }
    public class showof : TreeNodeModel
    {
        public string ava { get; set; }
        public string name { get; set; }
        public string value { get; set; }


    }

    public class Root
    {
        public Userpr profile { get; set; }
    }

    public class Userpr : TreeNodeModel
    {
        public string id { get; set; }
        public string name { get; set; }
        public string timezone { get; set; }
        public string isVip { get; set; }
        public string avatar { get; set; }
        public string points { get; set; }
        public string system_owns { get; set; }
        public string user_owns { get; set; }
        public string user_bloods { get; set; }
        public string system_bloods { get; set; }
        public string respects { get; set; }
        public string country_name { get; set; }
        public string country_code { get; set; }
        public Team team { get; set; }
        public object university_name { get; set; }
        public object description { get; set; }
        public string github { get; set; }
        public string linkedin { get; set; }
        public string twitter { get; set; }
        public string website { get; set; }
        public string rank { get; set; }
        public string rank_id { get; set; }
        public string current_rank_progress { get; set; }
        public string next_rank { get; set; }
        public string next_rank_points { get; set; }
        public string rank_ownership { get; set; }
        public string rank_requirement { get; set; }
        public string ranking { get; set; }
        public string Name2 { get; set; }
    }

    public class Team
    {
        public string name { get; set; }
        public int ranking { get; set; }
        public string avatar { get; set; }
    }

    public partial class Profile : Page
    {
        public string pfp { get; set; }


        public Profile()
        {

            ThemeManager.BeginUpdate();
            try
            {
                // Register the theme definitions for your application
                ThemeManager.RegisterThemeDefinition(new ThemeDefinition("Custom")
                {
                    Intent = ThemeIntent.Black,
                    ButtonPadding = new Thickness(2),
                    ButtonBackgroundGradientKind = GradientKind.None,
                    ButtonCornerRadius = 0,
                    CheckBoxCornerRadius = 0,
                    TabCornerRadius = 0,
                    ToolBarButtonCornerRadius = 0,
                });
                
                // Use the Actipro styles for native WPF controls that look great with Actipro's control products
                ThemeManager.AreNativeThemesEnabled = true;

                // Set the current app theme via a registered theme definition name
                ThemeManager.CurrentTheme = "Custom";
            }
            finally
            {
                ThemeManager.EndUpdate();
            }
            InitializeComponent();
            this.GenerateItems();
            
            
        }

        public void GenerateItems()
        {
            showof artistModel;
            var rootModel = new ArtistTreeNodeModel();
            var client = new RestClient("https://www.hackthebox.com/api/v4/profile/174509");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("Authorization", "Bearer eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiJ9.eyJhdWQiOiI1IiwianRpIjoiYjE4YjAzZjA0Y2U3ZDYzYjBiZmRmNDVhZDA0MDI3OWZkYjc2N2UwYzVjOTEwYWY0MTYyNDI5NjNjYTE3ZmRmZGMyM2ZiZWViNTkxMDM1ZTMiLCJpYXQiOjE2NzY1Njc5OTkuODE2OTYzLCJuYmYiOjE2NzY1Njc5OTkuODE2OTY1LCJleHAiOjE2NzcxNzI3OTkuODA5Mjk2LCJzdWIiOiIxNzQ1MDkiLCJzY29wZXMiOlsiMmZhIl19.hn94otbeoD_l4P_v2Q2IQhoEFe-lmwY4uvKFo6wLftUxxvSvMFRJxSfeTt_TIFdT2iwe7QkKSNmuKBDOakRrXwE39FsWoEvwBIIm79Q7Ub7goj9Snb4t8xHb_iLsGXJvE9su43mKA5fn_R4SedX3Uw5uFrKND7awwhy6m-_R7JB1r8igFeMLExX991G885iO3izstMw7wqOgRsZiWn8C-9cgbikbYvX5IcBHNY71SFmGaLmg59Nxh8HB2b3jlCWtoI1EVWP4A0DlYJjLLqYm3Q5RyYOa_DhwwsB8atLqmAYQqF3nT4XCjEV7LPEGbhX8fVhM_LxI6vD6fiN1_6S-187HiYKrGj3tTCyiDrYFNeJ5Od8ot85NbVxe9okFjCTY_w4me72wzvsqJUNUH_a0ZSC8FzDNbigSam4kPk-H66uwM2T9II9qQE9viPZMse3K8xvvK9rM2hMNgET4ZTGDSRBS1_fBUl7CBqd_DbQzbvt-y_kSkRR6QnzF9Y8zg1tdnTzNKqSspMCIgsyZuGJycSqx4L5afXzhOASWKMIVm-Wc2QYEE8v-fTKEZJU6S13-UVFuuLdkVW1GcWH99Z5TmnSm_OxSARXYyssdhjCUqmO3VpaK6UwM_LNeRPPDxXS6c66GfvM_yJc9Yc3c7rBWBUUiqNZbzZVACh87itlb9jU");
            IRestResponse response = client.Execute(request);
            Root user = JsonConvert.DeserializeObject<Root>(response.Content);
            string Name2 = user.profile.name+"#"+user.profile.id;
            textbox1.Text = Name2;

            pfp = "C:\\Users\\Antonio La Cokos\\source\\repos\\WpfApp3\\WpfApp3\\images\\avatars\\" + user.profile.name + ".png";
            Console.WriteLine(pfp);
            asd.Source = new BitmapImage(new Uri(pfp));
            

            artistModel = new showof() { ava= "C:\\Users\\Antonio La Cokos\\source\\repos\\WpfApp3\\WpfApp3\\images\\hackthebox.png", name = "HackTheBox", IsExpanded = true };
            rootModel.Children.Add(artistModel);
            artistModel.Children.Add(new showof() { ava = "images/root.png", name = "id", value = user.profile.id});
            artistModel.Children.Add(new showof() { ava = "images/user.png", name = "name", value = user.profile.name });
            artistModel.Children.Add(new showof() { ava = "images/otp.png", name = "Time Zone", value = user.profile.timezone });
            artistModel.Children.Add(new showof() { ava = "images/vipcross.png", name = "Vip", value = user.profile.isVip });
            artistModel.Children.Add(new showof() { ava = "images/points.png", name = "points", value = user.profile.points });
            artistModel.Children.Add(new showof() { ava = "images/rootflag.png", name = "System Owns", value = user.profile.system_owns });
            artistModel.Children.Add(new showof() { ava = "images/userflag.png", name = "User Owns", value = user.profile.user_owns });
            artistModel.Children.Add(new showof() { ava = "images/rootblood.png", name = "System Bloods", value = user.profile.system_bloods });
            artistModel.Children.Add(new showof() { ava = "images/userblood.png", name = "User Bloods", value = user.profile.user_bloods });
            artistModel.Children.Add(new showof() { ava = "images/respects.png", name = "Respects", value = user.profile.respects });
            artistModel.Children.Add(new showof() { ava = "images/eu.png", name = "Country", value = user.profile.country_name });
            artistModel.Children.Add(new showof() { ava = "images/teams.png", name = "Team", value = user.profile.team.name });
            artistModel.Children.Add(new showof() { ava = "images/prohacker.png", name = "rank", value = user.profile.rank });
            artistModel.Children.Add(new showof() { ava = "images/ranking.png", name = "Rank Progress", value = user.profile.current_rank_progress });
            artistModel.Children.Add(new showof() { ava = "images/elitehacker.png", name = "Next Rank", value = user.profile.next_rank });
            artistModel.Children.Add(new showof() { ava = "images/ranking.png", name = "Rank Ownership", value = user.profile.rank_ownership });
            artistModel.Children.Add(new showof() { ava = "images/ranking.png", name = "Rank Requirement", value = user.profile.rank_requirement });
            artistModel.Children.Add(new showof() { ava = "images/github.png", name = "Github", value = user.profile.github });
            artistModel.Children.Add(new showof() { ava = "images/linkedin.png", name = "Linkedin", value = user.profile.linkedin });
            artistModel.Children.Add(new showof() { ava = "images/twitter.png", name = "Twitter", value = user.profile.twitter });
            artistModel.Children.Add(new showof() { ava = "images/link.png", name = "Website", value = user.profile.website });
            this.DataContext = rootModel;
        }


        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
