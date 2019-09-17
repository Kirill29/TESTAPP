using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;
using iProspect.TestApp.Abstractions;
using iProspect.TestApp.Models;
using System.Linq;
namespace iProspect.TestApp.Implementations
{
    class Converter : IConverter
    {
        public XDocument Convert(IEnumerable<Product> source)
        {
            XDocument doc =
     new XDocument(
       new XElement("yml_catalog", new XAttribute("date", DateTime.Now.ToString("yyyy-M-d HH:mm")),
         new XElement("shop",
            new XElement("name","BestSeller"),
            new XElement("company", "The Best inc."),
            new XElement("url", "http://best.seller.ru"),
            new XElement("currencies",
               new XElement("currency", new XAttribute("id", "RUR"), new XAttribute("rate", "1")
            )),
             new XElement("categories",
               new XElement("category", new XAttribute("id", "1"), "Электроника")
            ),

            new XElement("offers",
               source.Select(x => new XElement("offer", new XAttribute("id", x.Guid), new XAttribute("available", x.Availability),
                new XElement("name", x.Title),
                new XElement("url", x.Url),
                new XElement("price", x.Price),
                new XElement("currencyId", "RUR"),
                new XElement("categoryId", "1"),
                new XElement("picture", x.Img),
                new XElement("description", x.Description)
          )) ) )   ) );
       return doc;
        }
    }
}
