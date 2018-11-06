using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ViewBaseExample.Views.Base
{
    public partial class BaseView : ContentPage
    {
        public static readonly BindableProperty ViewContentProperty = BindableProperty.Create(nameof(ViewContent), typeof(View), typeof(BaseView));

        public View ViewContent
        {
            get { return (View)GetValue(ViewContentProperty); }
            set { SetValue(ViewContentProperty, value); }
        }

        public BaseView()
        {
            InitializeComponent();
        }
    }
}
