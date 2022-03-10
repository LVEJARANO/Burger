using Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentation
{
    public partial class Index : System.Web.UI.Page
    {
        Buy objBuy = new Buy();//Se instancia la clase Buy
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        /*
         * Evento Click, al presionar el boton Pagar
         */
        protected void BtnPagar_Click(object sender, EventArgs e)
        {
            objBuy.TypeHamburger = Convert.ToInt32(TBTipoHam.Text);//Se asigna (set) el valor desde la caja de texto
            objBuy.NumHamburger = Convert.ToInt32(TBCant.Text);//Se asigna (set) el valor desde la caja de texto
            objBuy.PaymentType = Convert.ToInt32(TBTipoPago.Text);//Se asigna (set) el valor desde la caja de texto
            LblMsj.Text = objBuy.calculatePrice().ToString();//Se invoca el método que hace el calculo. 
            LblCant.Text = objBuy.NumHamburger.ToString();//Se obtiene (get) el valor asignado en la caja de texto
            LblTotalSinImpu.Text = objBuy.Total.ToString();//Se obtiene (get) el valor asignado en la caja de texto
            LblImpuesto.Text = objBuy.TaxCard.ToString();//Se obtiene (get) el valor asignado en la caja de texto
        }
    }
}