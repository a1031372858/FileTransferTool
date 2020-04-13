using Reactive.Bindings;
using System;
using System.IO;
using System.Text;

namespace FileTransferTool.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        public ReactiveProperty<string> FileSourcePath { set; get; }

        public ReactiveProperty<string> SavePath { set; get; }

        public ReactiveCommand SourcePathSelectCommand { set; get; }

        public ReactiveCommand SavePathSelectCommand { set; get; }

        protected override void RegisterProperties()
        {
            base.RegisterProperties();
            FileSourcePath = new ReactiveProperty<string>();
            SavePath = new ReactiveProperty<string>();
        }

        protected override void RegisterCommands()
        {
            base.RegisterCommands();
            SourcePathSelectCommand = new ReactiveCommand();
            SavePathSelectCommand = new ReactiveCommand();

            SourcePathSelectCommand.Subscribe(SourcePathSelect);
            SavePathSelectCommand.Subscribe(SavePathSelect);
        }

        private void SavePathSelect()
        {
            var filePath = @"F:\MyVSFiles\fileTest.txt";
            var objectFilePath = @"F:\copyDir\";
            var sourceFile = new FileInfo(filePath);
            var objectFile = new FileInfo(objectFilePath+sourceFile.Name);
            if (sourceFile.Exists)
            {
                if (!objectFile.Exists)
                {
                    objectFile.Create();
                }

                using (var fs = sourceFile.OpenRead())
                {
                    using (var fw = objectFile.OpenWrite())
                    {
                        byte[] bs = new byte[1024];
                        var utf8 = Encoding.UTF8;
                        int i = 0;
                        while ((i = fs.Read(bs, 0, bs.Length)) > 0)
                        {
                            Console.WriteLine(utf8.GetString(bs, 0, i));
                            fw.Write(bs, 0, i);
                            fw.Flush();
                        }
                    }
                }
            }
        }

        private void SourcePathSelect()
        {

        }
    }
}