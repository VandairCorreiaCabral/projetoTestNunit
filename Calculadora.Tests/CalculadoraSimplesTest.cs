namespace Calculadora.Tests
{
    [TestFixture]
    public class CalculadoraSimplesTest
    {
        [SetUp]
        public void Setup()
        {
        }
        /// <summary>
        /// o teste deve adicionar 2 numeros com sucesso e retornar o resultado correto
        /// </summary>
        [Test]
        public void Adicionar_DeveRetornarAdicaoDoisNumeros()
        {

            var sut = new CalculadoraSimples();
            var retorno = sut.Adicionar(3, 5);
            Assert.That(retorno, Is.EqualTo(8));

        }
        /// <summary>
        /// o teste deve multiplicar 2 numeros com sucesso e retornar o resultado correto.
        /// </summary>
        [Test]
        public void Multiplicar_DeveRetornarMultiplicacaoDoisNumeros()
        {

            var sut = new CalculadoraSimples();
            var retorno = sut.Multiplicar(3, 5);
            Assert.That(retorno, Is.EqualTo(15));

        }
        /// <summary>
        /// o teste deve subtrair 2 numeros com sucesso e retornar o resultado correto.
        /// </summary>
        [Test]
        public void Subitrair_DeveRetornarSubtracaoDoisNumeros()
        {

            var sut = new CalculadoraSimples();
            var retorno = sut.Subtrair(25, 5);
            Assert.That(retorno, Is.EqualTo(20));

        }
        /// <summary>
        /// o teste deve dividir 2 numeros com sucesso e retornar o resultado correto.
        /// </summary>
        [Test]
        public void Dividir_DeveRetornarDivisãoDoisNumeros()
        {

            var sut = new CalculadoraSimples();
            var retorno = sut.Dividir(15, 3);
            Assert.That(retorno, Is.EqualTo(5));


        }
        /// <summary>
        /// o teste deve dividir 2 numeros com sucesso e retornar o resultado correto.
        /// </summary>
        //[Test]
        //public void Dividir_DeveRetornarDivisãoPorzero()
        //{


        //    var sut = new CalculadoraSimples();
        //    var retorno = sut.Dividir(15, 0);
        //    Assert.That(retorno, Is.EqualTo("divisao por zero"));


        //}
    }
  
}