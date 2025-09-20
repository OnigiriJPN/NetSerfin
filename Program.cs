using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (Environment.OSVersion.Version.Major < 6)
            {
                MessageBox.Show("このアプリは Windows XP以下 では動作しません。\nWindows 7 以降をご利用ください。\n推奨OS：Windows 11",
                        "NetSerfin",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                return; // ここで Main() を抜ける → アプリ起動しない
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
