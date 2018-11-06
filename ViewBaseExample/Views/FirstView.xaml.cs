using System;
using System.Collections.Generic;
using ViewBaseExample.ViewModels;
using ViewBaseExample.Views.Base;
using Xamarin.Forms;

namespace ViewBaseExample.Views
{
    public partial class FirstView : BaseView
    {
        public FirstView()
        {
            InitializeComponent();
            BindingContext = new FirstViewModel();
        }
    }
}
