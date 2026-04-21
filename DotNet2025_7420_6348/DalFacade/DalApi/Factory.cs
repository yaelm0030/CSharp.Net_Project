using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static DalApi.Config;
using DO;
using System.Reflection;
using System.Linq.Expressions;

namespace DalApi;

public static class Factory
{
    public static IDal Get {
        get {
            string dalType = s_dalName ?? throw new DalConfigExceptions($"DAL name is not extracted from the configuration");
            string dal = s_dalPackages[dalType] ?? throw new DalConfigExceptions($"Package for {dalType} is not found in packages list in dal-config.xml");
            try
            {
                Assembly.Load(dal ?? throw new DalConfigExceptions($"Package {dal} is null"));
            }
            catch (Exception ex)
            {
                throw new DalConfigExceptions($"Failed to load {dal}.dll package", ex);
            }
            Type type = Type.GetType($"Dal.{dal},{dal}") ?? throw new DalConfigExceptions($"Class Dal.{dal} was not found in {dal}.dll");
            return type.GetProperty("Instance", BindingFlags.Public | BindingFlags.Static)?.GetValue(null) as IDal ?? throw new DalConfigExceptions($"Class{dal} is not a singleton or wrong property name for Instance");
        } }
}
