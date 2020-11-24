using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Newtonsoft.Json;

namespace Cross_platform_App
{
    public class APIResponse
    {
        public string IP { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
        public string Loc { get; set; }
        public string Org { get; set; }
        public string Postal { get; set; }
        public string TimeZone { get; set; }
        public string Readme { get; set; }

    }

    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await GetPublicIP();



            var Result = JsonConvert.DeserializeObject<APIResponse>(responseBody);
            Debug.WriteLine($"{Result}");
#if false
            var data = json["IP"];

            foreach (var dataItem in data)
            {
                string myValue = dataItem.Value["myKey"];
            }
#endif
            lbIP.Text = Result.IP;
            lbCity.Text = Result.City;
            lbRegion.Text = Result.Region;
            lbCountry.Text = Result.Country;
            lbGeo.Text = Result.Loc;
            lbSP.Text = Result.Org;
            lbPCode.Text = Result.Postal;
            lbTimeZone.Text = Result.TimeZone;
            //lbReadme.Text = Result.Readme;
        }

        private async void Button_Clicked_FreeNanum(object sender, EventArgs e)
        {
            await DisplayAlert("(c)FreeNanum", "freeNanum.github.io/market", "Close");
        }

#if true //httpRequest

        // HttpClient is intended to be instantiated once per application, rather than per-use. See Remarks.
        static readonly HttpClient client = new HttpClient();
        static string responseBody;

        static async
        Task
        GetPublicIP()
        {
            // Call asynchronous network methods in a try/catch block to handle exceptions.
            try
            {
                HttpResponseMessage response = await client.GetAsync("https://ipinfo.io/json");
                response.EnsureSuccessStatusCode();
                responseBody = await response.Content.ReadAsStringAsync();
                // Above three lines can be replaced with new helper method below
                // string responseBody = await client.GetStringAsync(uri);
#if true
                Console.WriteLine(responseBody);
#endif
#if alertDebug
                //await DisplayAlert("response", responseBody.ToString(), "Confirm");
#endif
            }
            catch (HttpRequestException e)
            {
#if true
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
#endif
#if alertDebug
                //await DisplayAlert("Message ", "Exception Caught!", "Confirm");
#endif
            }
        }

#if alertDebug
        private static new async Task DisplayAlert(string x, string y, string z)
        {
            await DisplayAlert(x, y, z);
            throw new NotImplementedException();
        }
#endif

#endif//#if true

    }
}
