using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Logic
{
    public class Buy
    {
        /*
         * Nivel de ocultacion cerrado
         * Abstracion de las caracteristicas mas importantes
         */
        private int typeHamburger;//Tipo de hamburguesa
        private int numHamburger;//Numero de hamburguesas
        private int paymentType;//Tipo de pago
        private int price;//Precio
        private double taxCard;//Impuesto de la tarjeta
        private double total;//Total
        private double totalCard;//Total tarjeta
        private string msj;//Mensaje

        /*
         * Encapsulación de los atributos
         * Propiedades get (devuelve un valor) y set (asigna un valor)
         */
        public int TypeHamburger { get => typeHamburger; set => typeHamburger = value; }
        public int NumHamburger { get => numHamburger; set => numHamburger = value; }
        public int PaymentType { get => paymentType; set => paymentType = value; }
        public int Price { get => price; set => price = value; }
        public double TaxCard { get => taxCard; set => taxCard = value; }
        public double Total { get => total; set => total = value; }
        public double TotalCard { get => totalCard; set => totalCard = value; }
        public string Msj { get => msj; set => msj = value; }

        /*
         * Metodo que retorna un numero decimal (double)
         * con el resultado de la compra
         */
        public double calculatePrice()
        {

            switch (typeHamburger)
            {
                case 1:
                    price = 20000;
                    break;
                case 2:
                    price = 25000;
                    break;
                case 3:
                    price = 28000;
                    break;
                default:
                    msj = "¡Seleccione un tipo de hamburguesa!";
                    break;
            }

            total = price * numHamburger;//Se calcula el total sin cargo

            switch (paymentType)
            {
                case 1:
                    taxCard = 0;//Impuesto para otro medio de pago
                    break;
                case 2:
                    taxCard = total * 0.07;//Se calcula el impuesto del 7%, pago con tarjeta
                    break;
                default:
                    msj = "¡Seleccione un tipo de pago!";
                    break;
            }

            totalCard = total + taxCard;//Se calcula el total con el cargo

            return totalCard;
        }
    }
}