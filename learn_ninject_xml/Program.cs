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
      // Load multiple xml files
      // kernel.Load("module1.xml","module2.xml","module3.xml");
      // kernel.Load("*.xml");
      // kernel.load(""Modules/*.xml");
      var encryptor = kernel.Get<IEncryptor>();
      Console.WriteLine(encryptor.Encrypt("Hello"));
      Console.ReadKey();
    }
  }
}
