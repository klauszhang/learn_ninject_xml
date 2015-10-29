using Ninject;
using System;

namespace learn_ninject_xml
{
  class Program
  {
    static void Main(string[] args)
    {
      var kernel = new StandardKernel();
      kernel.Load("encryptorModule.xml");
      var encryptor = kernel.Get<IEncryptor>();
      Console.WriteLine(encryptor.Encrypt("Hello"));
      Console.ReadKey();
    }
  }
}
