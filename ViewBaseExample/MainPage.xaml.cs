using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewBaseExample.Views;
using Xamarin.Forms;

namespace ViewBaseExample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Handle_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new FirstView());
        }
    }
}
