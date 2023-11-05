using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_3_JFB
{
    public class Lavadora : Electrodomestico
    {
        public int Carga { get; set; }

        public Lavadora()
        {
        }
        public Lavadora(double precio, int peso)
        {
            PrecioBase = precio;
            Peso = peso;
        }
        public Lavadora(double precio, string color, char consumo, int peso, int carga)
        {
            PrecioBase = precio;
            ColorElectrodomestico = color;
            ConsumoEnergetico = consumo;
            Peso = peso;
            Carga = carga;
        }
        public override double PrecioFinal()
        {
            double precioLavadora = base.PrecioFinal();
            double precioDeMercado = PrecioBase + precioLavadora;

            if (Carga >= 30)
            {
                precioDeMercado += 50;
            }

            return precioDeMercado;
        }

    }
}