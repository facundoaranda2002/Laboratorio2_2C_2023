using Entidades.Modelo;
using Entidades.Excepciones;
using System.Text;

namespace PruebasUnitarias
{
    [TestClass]
    public class TestNumerosRomanos
    {
        [TestMethod]
        public void AlRecibirUnNumeroUno_EnDecimal_DeberiaObtenerUnNumeroRomano()
        {
            //given
            //arrange
            int numero = 1;
            string esperado = "I";

            //when
            //act
            string resultado = Conversor.ConvertirANumeroRomano(numero);

            //then
            //assert
            Assert.AreEqual(resultado, esperado);
        }

        [TestMethod]
        public void AlRecibirUnNumeroDos_EnDecimal_DeberiaObtenerUnNumeroRomano()
        {
            //given
            //arrange
            int numero = 2;
            string esperado = "II";

            //when
            //act
            string resultado = Conversor.ConvertirANumeroRomano(numero);

            //then
            //assert
            Assert.AreEqual(resultado, esperado);
        }

        [TestMethod]
        [DataRow(1)]
        [DataRow(2)]
        [DataRow(3)]
        public void AlRecibirUnNumeroEntero_EnDecimal_DeberiaObtenerSuEquivalenteRomano(int value)
        {
            //given
            //arrange
            StringBuilder sb = new StringBuilder();
            sb.Append('I', value);
            string esperado = sb.ToString();

            //when
            //act
            string resultado = Conversor.ConvertirANumeroRomano(value);

            //then
            //assert
            Assert.AreEqual(resultado, esperado);
        }

        [TestMethod]
        //[ExpectedException(typeof(Exception))]
        [ExpectedException(typeof(NumeroInvalidoException))]
        public void AlRecibirInvalido_DeberiaObtenerUnError()
        {
            //given
            //arrange
            
            //when
            //act
            string resultado = Conversor.ConvertirANumeroRomano(0);

            //then
            //assert
            //No voy a usar assert en este caso ya que ya lo esta haciendo de por si el decorado de excepcion
        }

        [TestMethod]
        [DataRow(10)]
        public void AlRecibirUnNumeroDiez_DeberiaObtenerSuEquivalenteRomano(int value)
        {
            //given
            //arrange
            string esperado = "X";

            //when
            //act
            string resultado = Conversor.ConvertirANumeroRomano(value);

            //then
            //assert
            Assert.AreEqual(resultado, esperado);
        }
    }
}