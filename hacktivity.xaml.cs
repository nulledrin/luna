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
using RestSharp;
using Newtonsoft.Json;

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for hacktivity.xaml
    /// </summary>
    /// 

    public class SampleData
    {

        /////////////////////////////////////////////////////////////////////////////////////////////////////
        #region PUBLIC PROCEDURES
        /////////////////////////////////////////////////////////////////////////////////////////////////////

        public int Id { get; set; }
        public string SocialSecurity { get; set; }
        public string Phone { get; set; }

        public static List<SampleData> Values
        {
            get
            {
                List<SampleData> values = new List<SampleData>();
                values.Add(new SampleData() { Id = 1, SocialSecurity = "123-45-6789", Phone = "1-703-555-1212" });
                values.Add(new SampleData() { Id = 2, SocialSecurity = "234-56-7890", Phone = "(571) 555-1212" });
                values.Add(new SampleData() { Id = 3, SocialSecurity = "345-67-8901", Phone = "212-555-1212" });
                values.Add(new SampleData() { Id = 4, SocialSecurity = "456-78-9012", Phone = "555-1212" });
                values.Add(new SampleData() { Id = 5, SocialSecurity = "567-89-0123", Phone = "(202) 555-1212" });
                return values;
            }
        }

        #endregion // PUBLIC PROCEDURES
    }

    public partial class hacktivity : Page
    {
        public hacktivity()
        {
            InitializeComponent();
            this.Generateactivity();
        }


        public void Generateactivity()
        {
            activityout activModel;
            var rootModel = new activityout();
            var client = new RestClient("https://www.hackthebox.com/api/v4/profile/activity/174509");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("Authorization", "Bearer eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiJ9.eyJhdWQiOiI1IiwianRpIjoiYjE4YjAzZjA0Y2U3ZDYzYjBiZmRmNDVhZDA0MDI3OWZkYjc2N2UwYzVjOTEwYWY0MTYyNDI5NjNjYTE3ZmRmZGMyM2ZiZWViNTkxMDM1ZTMiLCJpYXQiOjE2NzY1Njc5OTkuODE2OTYzLCJuYmYiOjE2NzY1Njc5OTkuODE2OTY1LCJleHAiOjE2NzcxNzI3OTkuODA5Mjk2LCJzdWIiOiIxNzQ1MDkiLCJzY29wZXMiOlsiMmZhIl19.hn94otbeoD_l4P_v2Q2IQhoEFe-lmwY4uvKFo6wLftUxxvSvMFRJxSfeTt_TIFdT2iwe7QkKSNmuKBDOakRrXwE39FsWoEvwBIIm79Q7Ub7goj9Snb4t8xHb_iLsGXJvE9su43mKA5fn_R4SedX3Uw5uFrKND7awwhy6m-_R7JB1r8igFeMLExX991G885iO3izstMw7wqOgRsZiWn8C-9cgbikbYvX5IcBHNY71SFmGaLmg59Nxh8HB2b3jlCWtoI1EVWP4A0DlYJjLLqYm3Q5RyYOa_DhwwsB8atLqmAYQqF3nT4XCjEV7LPEGbhX8fVhM_LxI6vD6fiN1_6S-187HiYKrGj3tTCyiDrYFNeJ5Od8ot85NbVxe9okFjCTY_w4me72wzvsqJUNUH_a0ZSC8FzDNbigSam4kPk-H66uwM2T9II9qQE9viPZMse3K8xvvK9rM2hMNgET4ZTGDSRBS1_fBUl7CBqd_DbQzbvt-y_kSkRR6QnzF9Y8zg1tdnTzNKqSspMCIgsyZuGJycSqx4L5afXzhOASWKMIVm-Wc2QYEE8v-fTKEZJU6S13-UVFuuLdkVW1GcWH99Z5TmnSm_OxSARXYyssdhjCUqmO3VpaK6UwM_LNeRPPDxXS6c66GfvM_yJc9Yc3c7rBWBUUiqNZbzZVACh87itlb9jU");
            IRestResponse response = client.Execute(request);
            Hacktivity activities = JsonConvert.DeserializeObject<Hacktivity>(response.Content);
            for (int i = 0; i < activities.profile.activity.Count; i++)
            {
                activModel = new activityout() { Value = activities.profile.activity[i].name + " " + activities.profile.activity[i].object_type + " -- " + activities.profile.activity[i].type };
                rootModel.Children.Add(activModel);
            }
            this.DataContext = rootModel;
        }
    }

    

    public class Activity
    {
        public DateTime date { get; set; }
        public string date_diff { get; set; }
        public string object_type { get; set; }
        public string type { get; set; }
        public bool first_blood { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public int points { get; set; }
        public string machine_avatar { get; set; }
        public string flag_title { get; set; }
        public string challenge_category { get; set; }
    }

    public class listactivity
    {
        public List<Activity> activity { get; set; }
    }

    public class Hacktivity
    {
        public listactivity profile { get; set; }
    }

    public class activityout : TreeNodeModel
    {
        public string ava { get; set; }
        public string Value { get; set; }
    }
}
