namespace Dsw2026Ej8.test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            var helper = new ProductHelper();
            long code = 101;
            string desc = "Monitor";
            decimal price = 1500.50m;

            // Act
            string resultado = helper.ObtenerEtiquetaProducto(code, desc, price);

            // Assert
            // Verificamos que contenga el código entre corchetes y la descripción
            Assert.IsTrue(resultado.Contains("[101] Monitor"));
            // Verificamos que el precio tenga formato moneda (ej. $ 1.500,50)
            Assert.IsTrue(resultado.Contains(price.ToString("C")));
        }

        [TestMethod]
        public void TestProblema2() 
        {
            var p2 = new Problema2();
            // Act: cantidad -5
            string resultado = p2.CrearResumenVenta(1, "Prod A", -5, 100);

            // Assert: El formato es Code-Description-Total
            Assert.AreEqual("1-Prod A-0", resultado);
        }
    }
}
