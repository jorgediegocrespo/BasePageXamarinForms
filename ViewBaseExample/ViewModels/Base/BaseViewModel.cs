using System;
using Xamarin.Forms;

namespace ViewBaseExample.ViewModels.Base
{
    public class BaseViewModel : BindableObject
    {
        private bool _bussy;
        private string _bussyText;

        public bool Bussy
        {
            get { return _bussy; }
            set
            {
                _bussy = value;
                OnPropertyChanged();
            }
        }

        public string BussyText
        {
            get { return _bussyText; }
            set
            {
                _bussyText = value;
                OnPropertyChanged();
            }
        }

        public BaseViewModel()
        {
        }
    }
}
