using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Stealer
{
    public class Spy
    {
        public string StealFieldInfo(string name, params string[] fields)
        {
            Type classToInvestigate = Type.GetType(name);
            FieldInfo[] classFields = classToInvestigate.GetFields((BindingFlags)60);
            StringBuilder sb = new StringBuilder();

            Object classInstance = Activator.CreateInstance(classToInvestigate, new object[] { });
            sb.AppendLine($"Class under investigation: {name}");
            foreach (var field in classFields.Where(x => fields.Contains(x.Name)))
            {
                sb.AppendLine($"{field.Name} = {field.GetValue(classInstance)}");
            }
            return sb.ToString().Trim();
        }
    }
}
