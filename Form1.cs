using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Microsoft.Web.WebView2.WinForms;
using Microsoft.Web.WebView2.Core;
using System.Media;
using System.Security.Cryptography.X509Certificates;
using System.Net;

namespace Clock
{
    public partial class Form1 : Form
    {
        [DllImport("user32.DLL")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private X509Certificate2 cert;
        private DateTime expiry;
        private int daysRemaining;
        private bool isTrusted;
        private string securityStatus;

        public Form1()
        {
            InitializeComponent();
            InitWeb();
            CheckDependencies();
            FPS.Start();
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private async void InitWeb()
        {
            await Browser.EnsureCoreWebView2Async(null);
        }

        private void Browser_NavigationCompleted(object sender, CoreWebView2NavigationCompletedEventArgs e)
        {
            this.Text = "NetSerfin V1.90.1";
            URLBox.Text = Browser.Source.ToString();
            EnableDev.Enabled = true;
            AutoPasswordSaveEnable.Enabled = true;
            Zoom.Enabled = true;
            ShortCutKey.Enabled = true;
            ContextMenu.Enabled = true;
            AutoInput.Enabled = true;
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            radioButton3.Enabled = true;
            EnableJavaScript.Enabled = true;
            string url = Browser.Source.ToString();
            if (url.StartsWith("https://"))
            {
                Secua.Text = "🔒";
                Secua.BackColor = Color.LightGreen;
                Secua.ForeColor = Color.Black;
            }
            else
            {
                Secua.Text = "⚠️";
                Secua.BackColor = Color.OrangeRed;
                Secua.ForeColor = Color.White;
            }
            cert = GetServerCertificate(url);
            if (cert == null)
            {
                MessageBox.Show("証明書の取得に失敗しました。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // ここで変数を定義
            DateTime expiry = cert.NotAfter;
            bool isTrusted = cert.Verify();
            if (isTrusted && expiry >= DateTime.Now)
            {
                SecuaCerf.Text = "🔒";
                SecuaCerf.ForeColor = Color.Black;
                SecuaCerf.BackColor = Color.LightGreen;
            }
            else if (!isTrusted)
            {
                SecuaCerf.Text = "⚠️ 信頼されていない証明書";
                SecuaCerf.ForeColor = Color.White;
                SecuaCerf.BackColor = Color.Red;
            }
            else
            {
                SecuaCerf.Text = "⚠️ 期限切れの証明書";
                SecuaCerf.ForeColor = Color.Black;
                SecuaCerf.BackColor = Color.Orange;
            }
        }
        private X509Certificate2 GetServerCertificate(string url)
        {
            X509Certificate2 certResult = null;

            try
            {
                ServicePointManager.ServerCertificateValidationCallback = (sender, cert, chain, errors) =>
                {
                    if (cert != null)
                        certResult = new X509Certificate2(cert);
                    return true; // 証明書取得目的なので無条件で接続許可
                };

                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
                req.GetResponse().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("証明書の取得に失敗しました。\n" + ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return certResult;
        }
        private void Search_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "TLS/SSLは、セキュリティー証明書が、必要となります。\nもし、アクセスできない時、証明書の有効期限が切れてる・無効の可能性があります。証明書を、確認してからアクセスしてください。", "証明書", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) == System.Windows.Forms.DialogResult.OK)
            {
                if (URLBox.Text == "")
                {
                    MessageBox.Show(this, "URLがありません。少なくとも、1文字以上は、必要です。");
                    return;
                }

                NavigateToUrl(URLBox.Text.ToString());
            }
        }

        private void CheckDependencies()
        {
            // 1. WebView2Loader.dll が存在するかチェック
            string dllPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "WebView2Loader.dll");
            if (!File.Exists(dllPath))
            {
                MessageBox.Show(
                    "WebView2 Runtime（エバーグリーンエディションSDK） が見つかりません。\nダウンロードページを開きます。もし、誤作動だった場合WebView2SDK保存場所へ移動し、フォルダーがあるか確認をしてください。",
                    "エラー",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                System.Diagnostics.Process.Start("https://developer.microsoft.com/en-us/microsoft-edge/webview2/#download-section");
                Application.Exit();
            }

            // 2. Visual C++ 再頒布可能パッケージ（例: MSVCP140.dll が存在するか）チェック
            bool cppRedisPresent = true;
            try
            {
                // 実際に存在する DLL をロードできるか確認
                IntPtr handle = LoadLibrary("msvcp140.dll");
                if (handle == IntPtr.Zero)
                    cppRedisPresent = false;
            }
            catch
            {
                cppRedisPresent = false;
            }

            if (!cppRedisPresent)
            {
                if (
                MessageBox.Show(
                    "このアプリは、Visual C++ 再頒布可能パッケージ が必要です。お使いのWindowsPCは、 Visual C++ 再頒布可能パッケージ が含まれていないようです。\nダウンロードページを開きますか？",
                    "エラー",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Error
                ) == System.Windows.Forms.DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start("https://learn.microsoft.com/ja-jp/cpp/windows/latest-supported-vc-redist");
                    Application.Exit();
                }
            }
        }

        // Win32 API で DLL ロード確認
        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern IntPtr LoadLibrary(string lpFileName);

        private void Browser_NavigationStarting(object sender, CoreWebView2NavigationStartingEventArgs e)
        {
            this.Text = "NetSerfin 読み込み中...";
            EnableDev.Enabled = false;
            AutoPasswordSaveEnable.Enabled = false;
            Zoom.Enabled = false;
            ShortCutKey.Enabled = false;
            ContextMenu.Enabled = false;
            AutoInput.Enabled = false;
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            radioButton3.Enabled = false;
            EnableJavaScript.Enabled = false;
            if (e.Uri.StartsWith("http://"))
            {
                e.Cancel = true;
                MessageBox.Show("このページはSSL/TLS（https）httpプロトコルサイトを、ブロックされました。\nhttpプロトコルサイトは、昔使われましたが、今は入力されたパスワード・クレジットカード番号など個人情報が、悪用される危険性があるため、今となっては非推奨です。",
                    "セキュリティ警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void URLBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // ピッという音を消す
                NavigateToUrl(URLBox.Text.Trim());
            }
        }
        private void NavigateToUrl(string input)
        {
            string url = NormalizeUrl(input);

            if (!IsValidUrl(url))
            {
                MessageBox.Show("不正な URL です。\nhttps:// から始まる正しいドメイン名を入力してください。", "URL エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Browser.CoreWebView2.Navigate(url);
        }
        private bool IsValidUrl(string url)
        {
            if (!url.StartsWith("https://"))
                return false;

            try
            {
                Uri uri = new Uri(url);
                return uri.Scheme == Uri.UriSchemeHttps;
            }
            catch (Exception error)
            {
                throw new Exception(error.Message, error.InnerException);
            }
        }

        private string NormalizeUrl(string input)
        {
            // http:// → https:// に変換
            if (input.StartsWith("http://"))
                input = "https://" + input.Substring("http://".Length);

            // スキームがなければ追加（https://）
            if (!input.StartsWith("https://"))
                input = "https://" + input;

            return input;
        }

        private void BackForward_Click(object sender, EventArgs e)
        {
            Browser.CoreWebView2.GoBack();
        }

        private void Reload_Click(object sender, EventArgs e)
        {

            Browser.CoreWebView2.Reload();
        }

        private void Forward_Click(object sender, EventArgs e)
        {

            Browser.CoreWebView2.GoForward();
        }

        private void EnableJavaScript_CheckedChanged(object sender, EventArgs e)
        {
            


            if (EnableJavaScript.Checked == false)
            {
                if (MessageBox.Show(this, "JavaScriptを無効にしますか？この項目で、「チェックを外す」アクションは、非推奨です。\n※一部のサイトで、モダンUIなどが不安定になったり、<noscript>が、作動する可能性があります。また、この項目は保存されません。", "NetSerfin -- 非推奨な項目を設定しようとしています。", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) == System.Windows.Forms.DialogResult.OK)
                {
                    Browser.CoreWebView2.Settings.IsScriptEnabled = false;
                }
                else
                {
                    EnableJavaScript.Checked = true;
                }
            }
            else
            {
                Browser.CoreWebView2.Settings.IsScriptEnabled = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

            if (EnableDev.Checked == false)
            {
                Browser.CoreWebView2.Settings.AreDevToolsEnabled = false;
            }
            else
            {
                Browser.CoreWebView2.Settings.AreDevToolsEnabled = true;
            }
        }

        private void AutoPasswordSaveEnable_CheckedChanged(object sender, EventArgs e)
        {

            if (EnableJavaScript.Checked == false)
            {
                if (MessageBox.Show(this, "パスワード自動保存を無効にしますか？この項目で、「チェックを外す」アクションは、非推奨です。\n※もし、誤ってアカウントログアウトしてしまった時に、\nパスワードを忘れた場合、パスワードをリセット出来ますが、リセットしたくない場合、この項目が推奨です。", "NetSerfin -- 非推奨な項目を設定しようとしています。", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) == System.Windows.Forms.DialogResult.OK)
                {
                    Browser.CoreWebView2.Settings.IsPasswordAutosaveEnabled = false;
                }
                else
                {
                    EnableJavaScript.Checked = true;
                }
            }
            else
            {
                Browser.CoreWebView2.Settings.IsPasswordAutosaveEnabled = true;
            }
        }

        private void Zoom_CheckedChanged(object sender, EventArgs e)
        {

            if (Zoom.Checked == false)
            {
                Browser.CoreWebView2.Settings.IsZoomControlEnabled = false;
            }
            else
            {
                Browser.CoreWebView2.Settings.IsZoomControlEnabled = true;
            }
        }

        private void ShortCutKey_CheckedChanged(object sender, EventArgs e)
        {

            if (ShortCutKey.Checked == false)
            {
                Browser.CoreWebView2.Settings.AreBrowserAcceleratorKeysEnabled = false;
            }
            else
            {
                Browser.CoreWebView2.Settings.AreBrowserAcceleratorKeysEnabled = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton2.Checked == true)
            {
                EnableDev.Checked = false;
                EnableDev.Enabled = false;
                AutoPasswordSaveEnable.Checked = false;
                AutoPasswordSaveEnable.Enabled = false;
                Zoom.Checked = false;
                Zoom.Enabled = false;
                ShortCutKey.Checked = false;
                ShortCutKey.Enabled = false;
                ContextMenu.Checked = false;
                ContextMenu.Enabled = false;
                AutoInput.Checked = false;
                AutoInput.Enabled = false;
                Browser.CoreWebView2.Reload();
            }
            else
            {
                EnableDev.Checked = true;
                EnableDev.Enabled = true;
                AutoPasswordSaveEnable.Checked = true;
                AutoPasswordSaveEnable.Enabled = true;
                Zoom.Checked = true;
                Zoom.Enabled = true;
                ShortCutKey.Checked = true;
                ShortCutKey.Enabled = true;
                ContextMenu.Checked = true;
                ContextMenu.Enabled = true;
                AutoInput.Checked = true;
                AutoInput.Enabled = true;
                Browser.CoreWebView2.Reload();
            }
        }

        private void ContextMenu_CheckedChanged(object sender, EventArgs e)
        {

            if (ContextMenu.Checked == false)
            {
                Browser.CoreWebView2.Settings.AreDefaultContextMenusEnabled = false;
            }
            else
            {
                Browser.CoreWebView2.Settings.AreDefaultContextMenusEnabled = true;
            }
        }

        private void AutoInput_CheckedChanged(object sender, EventArgs e)
        {

            if (AutoInput.Checked == false)
            {
                Browser.CoreWebView2.Settings.IsGeneralAutofillEnabled = false;
            }
            else
            {
                Browser.CoreWebView2.Settings.IsGeneralAutofillEnabled = true;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton3.Checked == true)
            {
                AutoPasswordSaveEnable.Checked = false;
                AutoPasswordSaveEnable.Enabled = false;
                EnableJavaScript.Checked = false;
                EnableJavaScript.Enabled = false;
                Browser.CoreWebView2.Reload();
            }
            else
            {
                AutoPasswordSaveEnable.Checked = true;
                AutoPasswordSaveEnable.Enabled = true;
                EnableJavaScript.Checked = true;
                EnableJavaScript.Enabled = true;
                Browser.CoreWebView2.Reload();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
        int frameCount = 0;
        DateTime lastTime = DateTime.Now;

        private void Sound(object sender, EventArgs e)
        {

        }

        private void FPS_Tick(object sender, EventArgs e)
        {
            frameCount++;
            TimeSpan span = DateTime.Now - lastTime;
            if (span.TotalSeconds >= 1) {
                labelFPS.Text = "FPS: " + frameCount;
                frameCount = 0;
                lastTime = DateTime.Now;
            }
            string response = GetResponseFromWindow();
            if (response == null)
            {
                if (MessageBox.Show(
                    "応答がありません。待機もしくは、閉じますか？それとももう一度開きますか？\n「はい」閉じる\n「いいえ」再起動\n「キャンセル」待機\n※作業データが紛失する可能性があります。",
                    "NetSerfin",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Asterisk
                ) == DialogResult.Yes)
                {
                    Application.ExitThread();
                }
                else if (MessageBox.Show(
                    "応答がありません。待機もしくは、閉じますか？それとももう一度開きますか？\n「はい」閉じる\n「いいえ」再起動\n「キャンセル」待機\n※作業データが紛失する可能性があります。",
                    "NetSerfin",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Asterisk
                ) == DialogResult.No)
                {
                    Application.Restart();
                }
                else if (MessageBox.Show(
                    "応答がありません。待機もしくは、閉じますか？それとももう一度開きますか？\n「はい」閉じる\n「いいえ」再起動\n「キャンセル」待機\n※作業データが紛失する可能性があります。",
                    "NetSerfin",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Asterisk
                ) == DialogResult.Cancel)
                {
                    return;
                }

            }
            else
            {
                labelStatus.Text = response;
            }
        }
        private string GetResponseFromWindow()
        {
            // 例：Labelにテキストがあるかで応答を判定
            if (string.IsNullOrEmpty(labelStatus.Text) || labelStatus.Text == "応答待ち")
            {
                return null; // 応答なし
            }
            else
            {
                return labelStatus.Text; // 応答あり
            }
        }

        private void Secua_Click(object sender, EventArgs e)
        {
            string url = Browser.Source.ToString(); // WebViewのURL
            if (!url.StartsWith("https://"))
            {
                MessageBox.Show("HTTPSページでのみ証明書チェックできます。");
                return;
            }

            // ここで証明書取得
            cert = GetServerCertificate(url);
            if (cert == null) return;

            // フィールドに値を代入
            expiry = cert.NotAfter;
            daysRemaining = (expiry - DateTime.Now).Days;
            isTrusted = cert.Verify();
            securityStatus = isTrusted ? "証明書は信頼されています ✅" : "⚠️ 証明書は信頼されていません ❌";

            // ラベル反映
            if (isTrusted && expiry >= DateTime.Now)
            {
                Secua.Text = "🔒 安全な接続（HTTPS）";
                Secua.ForeColor = Color.White;
                Secua.BackColor = Color.Green;
            }
            else if (!isTrusted)
            {
                Secua.Text = "⚠️ 信頼されていない証明書";
                Secua.ForeColor = Color.White;
                Secua.BackColor = Color.Red;
            }
            else
            {
                Secua.Text = "⚠️ 期限切れの証明書";
                Secua.ForeColor = Color.Black;
                Secua.BackColor = Color.Orange;
            }

            // ポップアップ表示
            string message = string.Format(
                "🔐 証明書の詳細\n\nURL: {0}\n発行先: {1}\n発行者: {2}\n有効期限: {3}（残り {4} 日）\nセキュリティ: {5}",
                url, cert.Subject, cert.Issuer, expiry.ToShortDateString(), daysRemaining, securityStatus
            );

            CertInfoForm certForm = new CertInfoForm(message);
            certForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            About ab = new About();
            ab.ShowDialog();
        }

        private void SecuaCerf_Click(object sender, EventArgs e)
        {

        }
        
    }
}
