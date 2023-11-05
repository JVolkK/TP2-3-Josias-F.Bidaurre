using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_3_JFB
{
    public class Television : Electrodomestico
    {
        public int Pulgadas;

        public Television(){}

        public Television(int pulgadas)
        {
            Pulgadas = pulgadas;
        }

        public Television(double precio, string color, char consumo, int peso, int pulgadas)
        {
            PrecioBase = precio;
            ColorElectrodomestico = color;
            ConsumoEnergetico = consumo;
            Peso = peso;
            Pulgadas = pulgadas;
        }
        public override double PrecioFinal()
        {
            double precioTelevisor = base.PrecioFinal();
            double precioMercado = PrecioBase + precioTelevisor;
            double precioDevolucion = 0;

            if(Pulgadas >= 40)
            {
                precioDevolucion = precioMercado + (precioMercado * 0.30);
            }
            else
            {
                precioDevolucion = precioMercado;
            }
            return precioDevolucion;
        }
    }
}
