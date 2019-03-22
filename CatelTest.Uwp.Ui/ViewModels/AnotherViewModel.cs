using Catel.Logging;
using Catel.MVVM;
using System;
using System.Threading.Tasks;

namespace CatelTest.Uwp.Ui.ViewModels
{
    public class AnotherViewModel : ViewModelBase
    {
        private static readonly ILog log = LogManager.GetCurrentClassLogger();

        public AnotherViewModel()
        {
            log.Info($"Constructor ({UniqueIdentifier.ToString()})");
        }

        protected override Task InitializeAsync()
        {
            log.Info($"Initialize async ({UniqueIdentifier.ToString()})");

            return base.InitializeAsync();
        }
    }
}
