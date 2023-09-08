using System.Net.Http.Headers;
using System.Text;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

//using HttpClient client = new();

/*
string authValue ="Basic "+ Convert.ToBase64String(Encoding.GetEncoding("ISO-8859-1").GetBytes("4feb4478-d03a-4b8f-857f-fa473a23c8ac" + ":" + "6Gq-1cIEuZC1tQHnkxPuU8kjpYSJmwQB3pkpZowhAX8"));
string contentTypeValue = "application/x-www-form-urlencoded";
string staticUrl = "https://apps.mypurecloud.com/platform/api/v2/downloads/ed3eafaa66474941";






//Console.WriteLine(authValue);

client.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", authValue);
client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(contentTypeValue));


await ProcessRepositoriesAsync(client,staticUrl);

static async Task ProcessRepositoriesAsync(HttpClient client, string staticUrl)
{


    var data = new[]
    {
        new KeyValuePair<string, string>("grant_type", "client_credentials"),
    };

    var request = await client.PostAsync("https://login.mypurecloud.com/oauth/token",new FormUrlEncodedContent(data));

    var result = await request.Content.ReadAsStringAsync();
    string[] subs = result.Split(':',',');

    
    using HttpClient staticUrlRequest = new();
    string authValueStaticLink = string.Format("{0} {1}",subs[3],subs[1]);
    Console.WriteLine(authValueStaticLink);
    staticUrlRequest.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", authValueStaticLink);


    byte[] fileBytes =  await staticUrlRequest.GetByteArrayAsync(staticUrl);

    //fileBytes.
    Console.WriteLine(fileBytes);

    File.WriteAllBytes("file.csv", fileBytes);
    

}*/


namespace HttpClientStatus;

class Program
{
    static async Task Main(string[] args)
    {
        using var client = new HttpClient();
        string authValue ="Basic "+ Convert.ToBase64String(Encoding.GetEncoding("ISO-8859-1").GetBytes("4feb4478-d03a-4b8f-857f-fa473a23c8ac" + ":" + "6Gq-1cIEuZC1tQHnkxPuU8kjpYSJmwQB3pkpZowhAX8"));
        string contentTypeValue = "application/x-www-form-urlencoded";
        client.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", authValue);
        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(contentTypeValue));

        var data = new[]
        {
            new KeyValuePair<string, string>("grant_type", "client_credentials"),
        };

        var request = await client.PostAsync("https://login.mypurecloud.com/oauth/token",new FormUrlEncodedContent(data));

        var result = await request.Content.ReadAsStringAsync();
        string[] subs = result.Split(':',',');

        Console.WriteLine(subs[2]);


        //var result = await client.GetAsync("http://webcode.me");
        //Console.WriteLine(result.StatusCode);
    }
}