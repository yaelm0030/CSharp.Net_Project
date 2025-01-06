using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml.Linq;
using DO;

namespace DalApi;

static class Config
{
    internal static string s_dalName;
    internal static Dictionary<string, string> s_dalPackages;

    static Config()
    {
        XElement dalConfig = XElement.Load(@"..\xml\dal-config.xml") ?? throw new DalConfigExceptions("dal-config.xml file was not found");
        s_dalName = dalConfig.Element("dal")?.Value ?? throw new DalConfigExceptions("<dal> element is missing");
        var packages = dalConfig.Element("dal-packages")?.Elements() ?? throw new DalConfigExceptions("<dal-packages> element is missing");
        s_dalPackages=packages.ToDictionary(p=>""+p.Name, p=>p.Value);
    }
}
