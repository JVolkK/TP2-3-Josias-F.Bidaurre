using TP2_3_JFB;

namespace UnitTest_TP2_3_JFB
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //arrange
            Lavadora lavadora1 = new Lavadora(3000, "Blanco", 'A', 15, 20); //Precio Total: $3110
            Lavadora lavadora2 = new Lavadora(3000, "Negro", 'B', 25, 30); //Precio Total: $3180
            Lavadora lavadora3 = new Lavadora(3000, "Rojo", 'C', 60, 10); //Precio Total: $3140
            Lavadora lavadora4 = new Lavadora(3000, "Azul", 'D', 65, 55); //Precio Total: $3180
            Lavadora lavadora5 = new Lavadora(3000, "Verde", 'E', 85, 20); //Precio Total: $3130
            Lavadora lavadora6 = new Lavadora(3000, "Morado", 'F', 80, 60); //Precio Total: $3160

            Television television1 = new Television(3000, "Blanco", 'A', 15, 20); //Precio Total: $3110
            Television television2 = new Television(3000, "Negro", 'B', 25, 40); //Precio Total: $4069
            Television television3 = new Television(3000, "Rojo", 'C', 60, 45); //Precio Total: $4082
            Television television4 = new Television(3000, "Azul", 'D', 65, 20); //Precio Total: $3130
            Television television5 = new Television(3000, "Verde", 'E', 85, 15); //Precio Total: $3130
            Television television6 = new Television(3000, "Rosado", 'F', 80, 65); //Precio Total: $4043
            Television television7 = new Television(3000, "Rosado", 'J', 80, 65); //Error en el color y en el Consumo Energetico

            //act
            double precioLavadora1 = lavadora1.PrecioFinal();
            double precioLavadora2 = lavadora2.PrecioFinal();
            double precioLavadora3 = lavadora3.PrecioFinal();
            double precioLavadora4 = lavadora4.PrecioFinal();
            double precioLavadora5 = lavadora5.PrecioFinal();
            double precioLavadora6 = lavadora6.PrecioFinal();

            double precioTelevisor1 = television1.PrecioFinal();
            double precioTelevisor2 = television2.PrecioFinal();
            double precioTelevisor3 = television3.PrecioFinal();
            double precioTelevisor4 = television4.PrecioFinal();
            double precioTelevisor5 = television5.PrecioFinal();
            double precioTelevisor6 = television6.PrecioFinal();

            //assert
            //Precio
            Assert.AreEqual(3110, precioLavadora1);
            Assert.AreEqual(3180, precioLavadora2);
            Assert.AreEqual(3140, precioLavadora3);
            Assert.AreEqual(3180, precioLavadora4);
            Assert.AreEqual(3130, precioLavadora5);
            Assert.AreEqual(3160, precioLavadora6);

            Assert.AreEqual(3110, precioTelevisor1);
            Assert.AreEqual(4069, precioTelevisor2);
            Assert.AreEqual(4082, precioTelevisor3);
            Assert.AreEqual(3130, precioTelevisor4);
            Assert.AreEqual(3130, precioTelevisor5);
            Assert.AreEqual(4043, precioTelevisor6);

            //Color
            Assert.IsTrue(lavadora1.ValidarColor());
            Assert.IsTrue(lavadora2.ValidarColor());
            Assert.IsTrue(lavadora3.ValidarColor());
            Assert.IsTrue(lavadora4.ValidarColor());
            Assert.IsTrue(lavadora5.ValidarColor());
            Assert.IsFalse(lavadora6.ValidarColor());

            Assert.IsTrue(television1.ValidarColor());
            Assert.IsTrue(television2.ValidarColor());
            Assert.IsTrue(television3.ValidarColor());
            Assert.IsTrue(television4.ValidarColor());
            Assert.IsTrue(television5.ValidarColor());
            Assert.IsFalse(television6.ValidarColor());
            Assert.IsFalse(television7.ValidarColor());

            //Consumo energetico 
            Assert.IsTrue(television1.ValidarConsumoEnergetico());
            Assert.IsTrue(television2.ValidarConsumoEnergetico());
            Assert.IsTrue(television3.ValidarConsumoEnergetico());
            Assert.IsTrue(television4.ValidarConsumoEnergetico());
            Assert.IsTrue(television5.ValidarConsumoEnergetico());
            Assert.IsTrue(television6.ValidarConsumoEnergetico());
            Assert.IsFalse(television7.ValidarConsumoEnergetico());
        }
    }
}