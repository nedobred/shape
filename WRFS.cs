using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using shapes;

namespace shapes

{

    internal class WRFS
    {
        static public bool AppendString(string _filename, string _str, bool append = true)
        {
            try
            {
                StreamWriter myStream = new StreamWriter(_filename, append);
                myStream.WriteLine(_str);
                myStream.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
