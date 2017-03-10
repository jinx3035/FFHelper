using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using FFHelper.Models;

namespace FFHelper.Api
{
    public class SportRadar
    {


        //Basketball or baseball PlayerProfile?
        public async Task<HttpResponseMessage> ConsumeExternalAPI()
        {
            string url = "http://api.sportradar.us/nba-t3/players/82e44ba0-efd4-41de-b998-056d2865cebf/profile.json?api_key=4ya9vcbdprnybvkd3hdhcqjt";

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {

                }
                return response;
            }
            //}
        }
    }
}











//var data = await response.Content.ReadAsStringAsync();
//var table = Newtonsoft.Json.JsonConvert.DeserializeObject<DataTable>(data);

//GridView gView = new GridView();
//gView.DataSource = table;
//gView.DataBind();
//using (StringWriter writer = new StringWriter())
//{
//    using (HtmlTextWriter htw = new HtmlTextWriter(writer))
//    {
//        gView.RenderControl(htw);
//        ViewBag.ReturnedData = writer.ToString();
//    }
//}