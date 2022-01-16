using System;
using CsvHelper;
using HtmlAgilityPack;
using System.IO;
using System.Collections.Generic;
using System.Globalization;

namespace Scraper
{
    internal class Scraper
    {
        public void Scrape()
        {
            try
            {
                var html = @"https://crypto.com/price";

                HtmlWeb web = new HtmlWeb();

                var htmlDoc = web.Load(html);

                var Names = htmlDoc.DocumentNode.SelectNodes("//span[@class='chakra-text css-1mrk1dy']");
                var Prices = htmlDoc.DocumentNode.SelectNodes("//div[@class='css-b1ilzc']");
                var result = new List<parsedData>();
                for (int i = 0; i < Names.Count; i++)
                {
                    result.Add(new parsedData { Title = Names[i].InnerText + " " + Prices[i].InnerText });
                    Console.WriteLine(result[i].Title);
                }


            }
            catch (Exception e)
            {
                Console.WriteLine(":( Failed with exception" + e);
            }
        }

        public class parsedData
        {
            public string Title { get; set; }
        }
    }
}
