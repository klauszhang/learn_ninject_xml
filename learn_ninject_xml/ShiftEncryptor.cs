using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learn_ninject_xml
{
  class ShiftEncryptor : IEncryptor
  {
    public string Encrypt(string str)
    {
      var charArray = str.Select(c => (char)(c + 1)).ToArray();
      return new string(charArray);
    }
  }
}
