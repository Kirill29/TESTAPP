using System.Collections.Generic;
using System.Xml.Linq;
using iProspect.TestApp.Models;

namespace iProspect.TestApp.Abstractions
{
    public interface IFileProvider
    {
        IEnumerable< Product > Load( string sourcePath );

        void Save( XDocument outputDocument, string outputPath );
    }
}