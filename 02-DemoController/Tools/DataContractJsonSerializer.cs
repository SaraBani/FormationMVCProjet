using System;
using System.IO;

namespace _02_DemoController.Tools
{
    internal class DataContractJsonSerializer
    {
        private Type type;

        public DataContractJsonSerializer(Type type)
        {
            this.type = type;
        }

        internal void WriteObject<T>(MemoryStream stream, T obj)
        {
            throw new NotImplementedException();
        }
    }
}