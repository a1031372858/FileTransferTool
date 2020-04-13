using Prism.Mvvm;

namespace Base.Base
{
    public class ViewModelBase:BindableBase
    {
        public ViewModelBase()
        {
            RegisterProperties();
            RegisterCommands();
            RegisterPubEvents();
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

        /// <summary>
        /// モドルデータの初期化
        /// </summary>
        protected virtual void InitData()
        {

        }

        protected virtual void RegisterPubEvents()
        {
        }
    }
}