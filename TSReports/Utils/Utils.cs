using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace TSReports.Utils
{
    class Utils
    {
        static string tab = "t";
        static int tabseq = 0;

        public static T DeepCopy<T>(T other)
        {
            using (MemoryStream ms = new MemoryStream()) {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(ms, other);
                ms.Position = 0;
                return (T)formatter.Deserialize(ms);
            }
        }
        

        public static string TableAlias()
        {
            return tab + Utils.tabseq++.ToString();
        }
    }
}
