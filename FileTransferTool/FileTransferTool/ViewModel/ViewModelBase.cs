using Prism.Mvvm;

namespace FileTransferTool.ViewModels
{
    public class ViewModelBase : BindableBase
    {
        protected ViewModelBase()
        {
            RegisterProperties();
            RegisterCommands();
            InitData();
        }
        protected virtual void RegisterProperties()
        {
        }

        /// <summary>
        /// コマンドの初期化
        /// </summary>
        protected virtual void RegisterCommands()
        {

        }
        protected virtual void InitData()
        {
        }
    }
}