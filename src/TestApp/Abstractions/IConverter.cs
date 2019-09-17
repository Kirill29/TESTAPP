using System.Collections.Generic;
using System.Xml.Linq;
using iProspect.TestApp.Models;

namespace iProspect.TestApp.Abstractions
{
    public interface IConverter
    {
        XDocument Convert( IEnumerable< Product > source );
    }
}