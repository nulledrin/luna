using System;
using System.Collections.Generic;
using RestSharp;
using Newtonsoft.Json;
using System;
using System.Windows.Media.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackTheBox
{
    
    /////////////////////////////////////////////////////////////////////////////////////////////////////
    #region PUBLIC PROCEDURES
    /////////////////////////////////////////////////////////////////////////////////////////////////////

    public static class Connection
    {
        public static string status { get; set; }
        public static string name { get; set; }
        public static string ip4 { get; set; }
        public static string ip6 { get; set; }
        public static string down { get; set; }
        public static string up { get; set; }
           
        public class Connection_stats1
        {
            public string name { get; set; }
            public string ip4 { get; set; }
            public string ip6 { get; set; }
            public string down { get; set; }
            public string up { get; set; }
        }

        public class Root1
        {
            public string status { get; set; }
            public Connection_stats1 connection { get; set; }
        }

        public static void Connect()
        {
            var client = new RestClient("https://www.hackthebox.com/api/v4/user/connection/status");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("Authorization", "Bearer eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiJ9.eyJhdWQiOiI1IiwianRpIjoiYjE4YjAzZjA0Y2U3ZDYzYjBiZmRmNDVhZDA0MDI3OWZkYjc2N2UwYzVjOTEwYWY0MTYyNDI5NjNjYTE3ZmRmZGMyM2ZiZWViNTkxMDM1ZTMiLCJpYXQiOjE2NzY1Njc5OTkuODE2OTYzLCJuYmYiOjE2NzY1Njc5OTkuODE2OTY1LCJleHAiOjE2NzcxNzI3OTkuODA5Mjk2LCJzdWIiOiIxNzQ1MDkiLCJzY29wZXMiOlsiMmZhIl19.hn94otbeoD_l4P_v2Q2IQhoEFe-lmwY4uvKFo6wLftUxxvSvMFRJxSfeTt_TIFdT2iwe7QkKSNmuKBDOakRrXwE39FsWoEvwBIIm79Q7Ub7goj9Snb4t8xHb_iLsGXJvE9su43mKA5fn_R4SedX3Uw5uFrKND7awwhy6m-_R7JB1r8igFeMLExX991G885iO3izstMw7wqOgRsZiWn8C-9cgbikbYvX5IcBHNY71SFmGaLmg59Nxh8HB2b3jlCWtoI1EVWP4A0DlYJjLLqYm3Q5RyYOa_DhwwsB8atLqmAYQqF3nT4XCjEV7LPEGbhX8fVhM_LxI6vD6fiN1_6S-187HiYKrGj3tTCyiDrYFNeJ5Od8ot85NbVxe9okFjCTY_w4me72wzvsqJUNUH_a0ZSC8FzDNbigSam4kPk-H66uwM2T9II9qQE9viPZMse3K8xvvK9rM2hMNgET4ZTGDSRBS1_fBUl7CBqd_DbQzbvt-y_kSkRR6QnzF9Y8zg1tdnTzNKqSspMCIgsyZuGJycSqx4L5afXzhOASWKMIVm-Wc2QYEE8v-fTKEZJU6S13-UVFuuLdkVW1GcWH99Z5TmnSm_OxSARXYyssdhjCUqmO3VpaK6UwM_LNeRPPDxXS6c66GfvM_yJc9Yc3c7rBWBUUiqNZbzZVACh87itlb9jU");
            IRestResponse response = client.Execute(request);
            if (response.Content == "{\"status\":\"0\",\"connection\":\"not connected\"}")
            {
                status = "0";
            }
            else if (response.Content == "{\"status\":\"0\",\"connection\":\"server down\"}")
            {
                status = "Down";
            }
            else if (response.Content == "{\"error\":\"Unauthenticated.\"}")
            {
                status = "unauth";
            }
            else
            {
                Root1 connectio = JsonConvert.DeserializeObject<Root1>(response.Content);
                Console.WriteLine(connectio.status);
                status = connectio.status;
                name = connectio.connection.name;
                ip4 = connectio.connection.ip4;
                ip6 = connectio.connection.ip6;
                down = connectio.connection.down;
                up = connectio.connection.up;
            }
        }

    }

    #endregion // PUBLIC PROCEDURES
}
