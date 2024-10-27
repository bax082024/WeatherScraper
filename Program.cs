using HtmlAgilityPack;
using System;
using System.Net.Http;

class Program
{
  static void Main(string[] args)
  {
    // send request to yr
    String url = "https://www.yr.no/nb/v%C3%A6rvarsel/daglig-tabell/1-92416/Norge/Vestland/Bergen/Bergen";
    var httpClient = new HttpClient();
    var html = httpClient.GetStringAsync(url).Result;
    var htmlDocument = new HtmlDocument();
    htmlDocument.LoadHtml(html);


    // Get temperature
    var temperatureElement = htmlDocument.DocumentNode.SelectSingleNode("//span[@class='temperature temperature--warm-primary']");
    var temperature = temperatureElement.InnerText.Trim();
    Console.WriteLine("Temperature: " + temperature);

    // Get the Conditions
    var conditionElement = htmlDocument.DocumentNode.SelectSingleNode("//span[@class= 'Precipitation-module__main-sU6qN']");
    var conditions = conditionElement.InnerText.Trim();
    Console.WriteLine("Conditions: " + conditions);

    // Location

  }

}