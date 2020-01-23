using System.Threading.Tasks;
using Venz.UI.Xaml;
using VkMessenger.View;
using Windows.ApplicationModel.Activation;

namespace VkMessenger
{
    public sealed partial class App: Venz.UI.Xaml.Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Task StartAsync(Frame frame, ActivationKind activationKind, ApplicationExecutionState previousExecutionState, PrelaunchStage prelaunchStage)
        {
            frame.Navigation.Navigate(typeof(MessengerPage));
            return Task.CompletedTask;
        }
    }
}
