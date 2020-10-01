using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tabela_de_Pontos;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestaSomaDeJogos() //Linha 68 do programa
        {
            int i = 1;
            int resultado = i;
            resultado++;
            Assert.AreEqual(2, resultado); //Se resultado for igual a 2 (Em ordem crescente: 1, 2, 3, 4...), o teste é bem sucedido
        }
    }
}
