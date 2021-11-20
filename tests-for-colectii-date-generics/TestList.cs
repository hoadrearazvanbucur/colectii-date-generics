using colectii_date_generics;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace tests_for_colectii_date_generics
{
    public class TestList
    {
        private readonly ITestOutputHelper outputHelper;
        public TestList(ITestOutputHelper output)
        {
            this.outputHelper = output;
        }

        [Fact]

        public void test1()
        {
            List lista = new List();
            lista.add(new Masina("bmw,1"));
            lista.add(new Masina("vw,2"));
            lista.add(new Masina("vw,3"));
            lista.add(new Masina("audi,4"));
            outputHelper.WriteLine(lista.afisare()+"\n\n");

            lista.remove(1);
            outputHelper.WriteLine(lista.afisare());

        }
    }
}
