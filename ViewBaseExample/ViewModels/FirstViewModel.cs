using System;
using ViewBaseExample.ViewModels.Base;

namespace ViewBaseExample.ViewModels
{
    public class FirstViewModel : BaseViewModel
    {
        public FirstViewModel()
        {
            Load();
        }

        private async void Load()
        {
            Bussy = true;
            BussyText = "Loading...";

            await System.Threading.Tasks.Task.Delay(3000);

            Bussy = false;
            BussyText = string.Empty;
        }
    }
}
