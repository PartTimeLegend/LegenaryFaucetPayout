using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Net.Sockets;
using System.Web.Handlers;

namespace LogicLayer
{
    public class WebRequests
    {
        public string Payout()
        {
            var client = new HttpClient();
            var requestContent = new FormUrlEncodedContent(new [] {
            new KeyValuePair<string, string>("secret", "YourSecretKeyHere"),});
            var response = client.PostAsJsonAsync("http://legendaryfaucet.herokuapp.com", requestContent);
            return response.ToString();
            
        }
    }
}
