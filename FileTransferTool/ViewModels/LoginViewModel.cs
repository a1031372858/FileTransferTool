using System.Security.RightsManagement;
using Reactive.Bindings;
using Reactive.Bindings.Extensions;

namespace FileTransferTool.ViewModels
{
    public class LoginViewModel:ViewModelBase
    {
        public ReactiveProperty<string> Account {set;get; }

        public ReactiveProperty<string> Password { set; get; }

        public ReactiveCommand RegisterCommand { set; get; }

        public ReactiveCommand LoginCommand { set; get; }

        

        protected override void RegisterProperties()
        {
            base.RegisterProperties();
            Account = new ReactiveProperty<string>();
            Password = new ReactiveProperty<string>();

        }

        protected override void RegisterCommands()
        {
            base.RegisterCommands();
            RegisterCommand = new ReactiveCommand();
            LoginCommand = new ReactiveCommand();

            RegisterCommand.Subscribe(Register);
            LoginCommand.Subscribe(Login);
        }

        protected override void InitData()
        {
            base.InitData();

        }

        private void Register()
        {
            if (string.IsNullOrEmpty(Account.Value) || string.IsNullOrEmpty(Password.Value))
            {
                return;
            }
            
        }
        private void Login()
        {
            if (string.IsNullOrEmpty(Account.Value) || string.IsNullOrEmpty(Password.Value))
            {
                return;
            }

            if (Account.Value.Equals("admin") && Password.Value.Equals("admin"))
            {
                var home = new HomeView();
                home.Show();
                home.DataContext = new HomeViewModel();
            }
        }
    }
}