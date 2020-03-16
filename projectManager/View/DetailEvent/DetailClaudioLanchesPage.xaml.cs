using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace projectManager.View.DetailEvent
{
    public partial class DetailClaudioLanchesPage : ContentPage
    {
        public DetailClaudioLanchesPage()
        {
            InitializeComponent();
        }

        void goPageCheckList(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new View.CheckList.CheckListClaudioLanches());
        }

       
        void goPageGaleriaDocumentos(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new View.GaleriaDocumentos.GaleriaDocumentosClaudioLanches());
        
        }

        void goPageFinanceiro(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new View.Financeiro.FinanceiroClaudioLanches());
        }

        void goGaleriaImagens(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new View.GaleriaImagens.GaleriaImagensPage());
        }

        void goRegistroConsumo(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new View.RegistroConsumo.RegistroConsumoPage());
        }

        void goRegistroFornecedor(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new View.RegistroFornecedor.RegistroFornecedorPage());
        }
    }
}
