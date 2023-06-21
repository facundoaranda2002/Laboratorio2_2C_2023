using Entidades.Exceptions;
using Entidades.Models;
using Entidades.Files;

namespace Test
{
    [TestClass]
    public class TestAhorcado
    {
        [TestMethod]
        [ExpectedException(typeof(FileManagerException))]
        public void AlNoRecibirUnaExtensionAdecuada_DeberiaRecibirUnaExcepcion()
        {
            Ahorcado<Pais> ahorcado = new Ahorcado<Pais>();
            string extension = ".lalala";

            FileManager.Guardar<Ahorcado<Pais>>(ahorcado, extension);
        }

        [TestMethod]
        public void AlInstanciarUnNuevoJuego_DeberiaTenerLosAciertosEnCero()
        {
            int esperado = 0;
            Ahorcado<Pais> ahorcado = new Ahorcado<Pais>();

            int resultado = ahorcado.CantidadDeAciertos;

            Assert.AreEqual(resultado, esperado);

        }
    }
}