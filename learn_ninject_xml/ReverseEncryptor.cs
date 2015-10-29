using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learn_ninject_xml
{
  class ReverseEncryptor : IEncryptor
  {
    public string Encrypt(string str)
    {
      var charArray = str.Reverse().ToArray();
      return new string(charArray);
    }
  }
}
