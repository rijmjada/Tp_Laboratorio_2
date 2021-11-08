using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades.Productos;
using Entidades;


namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        #region Clase Remera

        [TestMethod]
        public void VerificarOperadoresRemera_True()
        {
            #region Arrange

            Remera r1 = new Remera(ETipoMaterial.Algodon, ETalle.Large, 100, EOrigen.Argentina, "Nike");
            Remera r2 = new Remera(ETipoMaterial.Algodon, ETalle.Large, 50, EOrigen.China, "Nike");

            #endregion

            #region Act

            bool ret = r1 == r2;

            #endregion

            #region Assert

            Assert.IsTrue(ret);

            #endregion
        }

        [TestMethod]
        public void VerificarOperadoresRemera_False()
        {
            #region Arrange

            Remera r1 = new Remera(ETipoMaterial.Poliester, ETalle.Large, 100, EOrigen.Argentina, "Nike");
            Remera r2 = new Remera(ETipoMaterial.Algodon, ETalle.Large, 100, EOrigen.Argentina, "Nike");

            #endregion

            #region Act

            bool ret = r1 == r2;

            #endregion

            #region Arrange

            Assert.IsFalse(ret);

            #endregion
        }

        [TestMethod]
        public void VerificarPropiedadGananciaRemera()
        {
            #region Arrange

            Remera r1 = new Remera(ETipoMaterial.Poliester, ETalle.Large, 100, EOrigen.Argentina, "Adidas");
            double retornoEsperado = 25;
            double ganancia;

            #endregion

            #region Act

            ganancia = r1.RetornarGanancia();

            #endregion

            #region Arrange

            Assert.AreEqual(ganancia, retornoEsperado);

            #endregion

        }

        #endregion

        #region Clase Pantalon

        [TestMethod]
        public void VerificarOperadoresPantalon_True()
        {
            #region Arrange

            Pantalon p1 = new Pantalon(ETipoMaterial.Algodon, ETalle.Large, 100, EOrigen.Argentina, "Adidas");
            Pantalon p2 = new Pantalon(ETipoMaterial.Algodon, ETalle.Large, 50, EOrigen.China, "Adidas");

            #endregion

            #region Act

            bool ret = p1 == p2;

            #endregion

            #region Assert

            Assert.IsTrue(ret);

            #endregion
        }

        [TestMethod]
        public void VerificarOperadoresPantalon_False()
        {
            #region Arrange

            Pantalon p1 = new Pantalon(ETipoMaterial.Poliester, ETalle.Large, 100, EOrigen.Argentina, "Adidas");
            Pantalon p2 = new Pantalon(ETipoMaterial.Algodon, ETalle.Large, 100, EOrigen.Argentina, "Adidas");

            #endregion

            #region Act

            bool ret = p1 == p2;

            #endregion

            #region Arrange

            Assert.IsFalse(ret);

            #endregion
        }

        [TestMethod]
        public void VerificarPropiedadGananciaPantalon()
        {
            #region Arrange

            Pantalon p1 = new Pantalon(ETipoMaterial.Algodon, ETalle.Large, 100, EOrigen.Argentina, "Adidas");
            double retornoEsperado = 45;
            double ganancia;

            #endregion

            #region Act

            ganancia = p1.RetornarGanancia();

            #endregion

            #region Arrange

            Assert.AreEqual(ganancia, retornoEsperado);

            #endregion

        }

        #endregion

    }

   
}
