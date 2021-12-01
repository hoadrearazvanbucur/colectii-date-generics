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

        public void testAfisare()
        {
            ControlMasina control = new ControlMasina();
            control.afisare();
        }

        [Fact]

        public void testAdaugareStergere()
        {
            ControlMasina control = new ControlMasina();
            control.adaugare(new Masina("test1,1"));
            Assert.True(control.Lista.contains(new Masina("test1,1")));
            control.stergere(control.Lista.indexOf(new Masina("test1, 1")));
            Assert.False(control.Lista.contains(new Masina("test1,1")));

        }

        [Fact]

        public void testModificare()
        {
            ControlMasina control = new ControlMasina();
            Masina m = new Masina("test1,1");
            control.adaugare(m);
            control.modificareMarca(m,"testMarca");
            Assert.True(control.Lista.get(control.Lista.indexOf(m)).Data.Marca.Equals("testMarca")==true);

            control.modificareKm(m, 123);
            Assert.True(control.Lista.get(control.Lista.indexOf(m)).Data.Km.Equals(123) == true);
            control.stergere(control.Lista.indexOf(m));

        }
    }
}
