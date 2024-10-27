using HtmlAgilityPack;
using System;
using System.Net.Http;

class Program
{
  static void Main(string[] args)
  {
    String url = "https://www.yr.no/nb/v%C3%A6rvarsel/daglig-tabell/1-92416/Norge/Vestland/Bergen/Bergen";
    var httpClient = new HttpClient();
    var html = httpClient.GetStringAsync(url).Result;
    var htmlDocument = new HtmlDocument();
    htmlDocument.LoadHtml(html);

  }

}