using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_3_JFB
{
    public enum Color
    {
        Blanco,
        Negro,
        Rojo,
        Azul,
        Verde
    }
    public abstract class Electrodomestico
    {
        public double PrecioBase { get; set; }
        public string ColorElectrodomestico { get; set; }
        public char ConsumoEnergetico { get; set; }
        public double Peso { get; set; }

        public bool ValidarConsumoEnergetico()
        {
            if(ConsumoEnergetico == 'A' || ConsumoEnergetico =='B' || ConsumoEnergetico == 'C' || ConsumoEnergetico == 'D' || ConsumoEnergetico == 'E' || ConsumoEnergetico == 'F')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ValidarColor() { return Enum.IsDefined(typeof(Color), ColorElectrodomestico); }

        public virtual double PrecioFinal()
        {
            int precioConsumo = 0;
            int precioPeso = 0;

            if (ConsumoEnergetico == 'A')
            {
                precioConsumo = 100;
            }
            else if (ConsumoEnergetico == 'B')
            {
                precioConsumo = 80;
            }
            else if (ConsumoEnergetico == 'C')
            {
                precioConsumo = 60;
            }
            else if (ConsumoEnergetico == 'D')
            {
                precioConsumo = 50;
            }
            else if (ConsumoEnergetico == 'E')
            {
                precioConsumo = 30;
            }
            else if (ConsumoEnergetico == 'F')
            {
                precioConsumo = 10;
            }

            if (Peso >= 0 && Peso <= 19)
            {
                precioPeso = 10;
            }
            else if (Peso >= 20 && Peso <= 49)
            {
                precioPeso = 50;
            }
            else if (Peso >= 50 && Peso <= 79)
            {
                precioPeso = 80;
            }
            else if (Peso >= 80)
            {
                precioPeso = 100;
            }

            return precioPeso + precioConsumo;
        }
    }
}
