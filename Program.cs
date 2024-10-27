using HtmlAgilityPack;
using System;
using System.Net.Http;

class Program
{
  static void Main(string[] args)
  {
    String url = ""
    var httpClient = new HttpClient();
    var html = httpClient.GetStringAsync(url).Result;
    var htmlDocument = new HtmlDocument();
    htmlDocument.LoadHtml(html);

  }

}