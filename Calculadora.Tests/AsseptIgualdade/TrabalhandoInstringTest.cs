using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Calculadora.Tests.AsseptIgualdade
{
    [TestFixture]
    public class TrabalhandoInstringTest
    {
        [SetUp]
        public void Setup()
        {
        }

        /// <summary>
        /// juntar 2 string,  finalidade comparar igualdade entre strings,se retornar  string for iguais  teste passou
        /// </summary>
        [Test]
        public void Juntar2StringSucesso()
        {
            var sut = new TrabalhandoStrings();
            var retorno = sut.JuntarString("joao", "doria");
            Assert.That(retorno, Is.EqualTo("joao doria"));
        }

        /// <summary>
        /// juntar 2 string, finalidade comparar igualdade entre strings  com mesmo case ,se retornar  string  iguais com mesmo case  teste passou
        /// </summary>
        [Test]
        public void Juntar2StringSucesso_CaseSensitive()
        {
            var sut = new TrabalhandoStrings();
            var retorno = sut.JuntarString("joao", "doria");
            Assert.That(retorno, Is.EqualTo("JOAO DORIA"));
        }

        /// <summary>
        /// juntar 2 string, finalidade comparar igualdade entre strings  com mesmo/nao case ,se retornar  string  iguais com mesmo/ case  teste passou
        /// </summary>
       
        [Test]
        public void Juntar2StringSucesso_ignoreCaseSensitive()
        {
            var sut = new TrabalhandoStrings();
            var retorno = sut.JuntarString("joao", "doria");
            Assert.That(retorno, Is.EqualTo("JOAO DORIA").IgnoreCase);
        }

        /// <summary>
        /// juntar 2 string, finalidade comparar diferenças entre strings  com mesmo/nao case ,se retornar  string  diferentes com mesmo/nao case  teste passou
        /// </summary>
        [Test]
        public void Juntar2StringSucesso_DiferenteResultadoSucesso_IgnoreCase()
        {
            var sut = new TrabalhandoStrings();
            var retorno = sut.JuntarString("joao", "doria");
            Assert.That(retorno, Is.Not.EqualTo("JOAO DORIA").IgnoreCase);
        }

    }
}
