using System;
using System.Web.Mvc;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;


namespace FFHelper.Api
{
    public class SportRadarBaseBallPlayerProfile
    {
        public async Task<HttpResponseMessage> ConsumeExternalAPI()
        {
            string url = "http://api.sportradar.us/nfl-ot1/players/9634e162-5ff5-4372-b72b-ee1b0cb73a0d/profile.json?api_key=z7ugh9dxur8qghckm8yes5mu";

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