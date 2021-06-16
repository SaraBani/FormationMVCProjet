using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;

namespace _02_DemoController.Tools
{
    public class MyJsonTool
    {
        public static string ToJson<T>(T obj)
        {
            string resultat = null;
            DataContractJsonSerializer serialize = new DataContractJsonSerializer(typeof(T));
            using(MemoryStream Stream = new MemoryStream())
            {
                serialize.WriteObject(Stream, obj);
                resultat = Encoding.UTF8.GetString(Stream.ToArray());
                    
            }
              return resultat;
        }
    }
}