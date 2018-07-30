using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AdopteUneDev.DAL.Interfaces
{
    public static class IEntityExtension
    {
        public static string GetPKey<T>()
        {
            PropertyInfo PI = typeof(T).GetProperties().FirstOrDefault(p => p.CustomAttributes.Any(a => a.AttributeType.Name == "KeyAttribute"));

            return PI != null ? PI.Name : null;
        }
    }
}
