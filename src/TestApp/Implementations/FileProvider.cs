using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;
using iProspect.TestApp.Abstractions;
using iProspect.TestApp.Models;
using CsvHelper;
using System.IO;
using System.Collections;

namespace iProspect.TestApp.Implementations
{
    class FileProvider : IFileProvider
    {
        public IEnumerable<Product> Load(string sourcePath)
        {

                using (var reader = new StreamReader(sourcePath))
                {

                    List<Product> products = new List<Product>();
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(';');
                        Product prod = new Product()
                        {
                            Guid = values[0],
                            Url = values[1],
                            Title = values[2],
                            Price = values[3],
                            Description = values[4],
                            Img = values[5],
                            Availability = values[6]

                        };

                        products.Add(prod);
                    }
                    products.RemoveAt(0);
                    return products;
                }
        }


        public void Save(XDocument outputDocument, string outputPath)
        {
            string path_to_save=Path.Combine(outputPath, String.Concat("output_",DateTime.Now.ToString("HH_mm_d_M"),".xml"));
            outputDocument.Save(path_to_save);
        }
    }
}
