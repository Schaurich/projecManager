using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace projectManager.View
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent(); 
        }

       

        void btnDetailEventClaudio(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new View.DetailEvent.DetailClaudioLanchesPage());
        }
    }
}
