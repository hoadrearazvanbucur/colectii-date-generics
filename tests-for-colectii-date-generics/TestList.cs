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
            lista.add(new Masina("ggggggg,0"));
            lista.add(new Masina("ffffff,1"));
            lista.add(new Masina("ccc,2"));
            lista.add(new Masina("a,3"));
            lista.add(new Masina("dddd,4"));
            lista.add(new Masina("bb,5"));
            lista.add(new Masina("eeeee,6"));
            outputHelper.WriteLine(lista.afisare()+"\n\n");

            lista.sortKm();
            outputHelper.WriteLine(lista.afisare() + "\n\n");
        }
    }
}
