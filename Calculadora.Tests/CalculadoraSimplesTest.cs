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
    }
}