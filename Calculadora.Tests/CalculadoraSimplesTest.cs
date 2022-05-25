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

       


        [Test]
        public void AdicionarDecimal_Sucesso()
        {
            var sut = new CalculadoraSimples();
            var retorno = sut.AdicionarDecimais(1.1M, 2.2M);
            Assert.That(retorno,Is.EqualTo(3.3));
        }

        [Test]
        public void AdicionarDuble_Sucesso()
        {
            var sut = new CalculadoraSimples();
            var retorno = sut.AdicionarDouble(1.1, 2.2);
            Assert.That(retorno, Is.EqualTo(3.3));
        }
        [Test]
        public void AdicionarDuble_Com_Within_Sucesso()
        {
            var sut = new CalculadoraSimples();
            var retorno = sut.AdicionarDouble(1.1, 2.2);
            Assert.That(retorno, Is.EqualTo(3.3).Within(0.01)); //aceita tolerancia de ate 0.01 ou seja diferença de ate 0.01
        }

        [Test]
        public void AdicionarDuble_Com_WithinPercentual_Sucesso()
        {
            var sut = new CalculadoraSimples();
            var retorno = sut.AdicionarDouble(50, 50);
            Assert.That(retorno, Is.EqualTo(99.5).Within(1).Percent); //aceita tolerancia de ate 1% ou seja diferença de ate 1
        }

    }
  
}