using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace cinchiglemaS2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ejercicio : ContentPage
    {
        public ejercicio()
        {
            InitializeComponent();
        }

        private void pciudades_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pciudades.SelectedIndex == -1)

            {
                DisplayAlert("alerta", "valor nulo", "cancelar");

            }
            else
            {
                DisplayAlert("alerta", "valor nulo", pciudades.Items[pciudades.SelectedIndex], "cancelar");
            }
        }
        private void btnmostrar_clicked(object sender, EventArgs e)
        {
            double nota1 = Convert.ToDouble(txnota1.Text);
            double nota2 = Convert.ToDouble(txexamen1.Text );
            
             
            //prueba de gib
            //cambio de prueba
            //fewfwefsdf

        }
    }  
          
        }

