using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalcoliCombinatori
{
    [TestClass]
    public class UnitTest1
    {
        
        [DataTestMethod]
        [DataRow(0)]
        [DataRow(1)]
        [DataRow(5)]
        [DataRow(10)]
        [DataRow(50)]
        public void TestMethod1(long num)
        {
            long fatto;

            fatto = EquazioniLibrary.CalcoliCombinatori.Fattoriale(num);

            Console.WriteLine($"{num}!={fatto}");
        }
    }
    
}
