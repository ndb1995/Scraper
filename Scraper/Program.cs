using System;
using CsvHelper;
using HtmlAgilityPack;
using System.IO;
using System.Collections.Generic;
using System.Globalization;

namespace Scraper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Scraper scrape = new Scraper();
            scrape.Scrape();
            
        }

    }
}
