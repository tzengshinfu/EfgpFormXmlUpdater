using System;
using System.Windows.Forms;

namespace EfgpFormXmlUpdater {
    static class Program {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main(string[] args) {
            if (args.Length != 4) {
                Console.Write("命令列參數必須為[資料庫主機位址] [資料庫名稱] [連線帳號] [連線密碼]");

                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain(args));
        }
    }
}