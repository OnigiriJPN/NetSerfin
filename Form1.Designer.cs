namespace Clock
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Browser = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.SecuaCerf = new System.Windows.Forms.Label();
            this.Secua = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelFPS = new System.Windows.Forms.Label();
            this.AutoInput = new System.Windows.Forms.CheckBox();
            this.ContextMenu = new System.Windows.Forms.CheckBox();
            this.ShortCutKey = new System.Windows.Forms.CheckBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.Zoom = new System.Windows.Forms.CheckBox();
            this.AutoPasswordSaveEnable = new System.Windows.Forms.CheckBox();
            this.Reload = new System.Windows.Forms.Button();
            this.Forward = new System.Windows.Forms.Button();
            this.BackForward = new System.Windows.Forms.Button();
            this.EnableDev = new System.Windows.Forms.CheckBox();
            this.EnableJavaScript = new System.Windows.Forms.CheckBox();
            this.Search = new System.Windows.Forms.Button();
            this.URLBox = new System.Windows.Forms.ComboBox();
            this.FPS = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Browser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Browser
            // 
            this.Browser.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Browser.AllowExternalDrop = true;
            this.Browser.CreationProperties = null;
            this.Browser.DefaultBackgroundColor = System.Drawing.Color.White;
            this.Browser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Browser.Location = new System.Drawing.Point(0, 0);
            this.Browser.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Browser.Name = "Browser";
            this.Browser.Size = new System.Drawing.Size(1371, 638);
            this.Browser.Source = new System.Uri("https://google.co.jp", System.UriKind.Absolute);
            this.Browser.TabIndex = 1;
            this.Browser.ZoomFactor = 1D;
            this.Browser.NavigationStarting += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2NavigationStartingEventArgs>(this.Browser_NavigationStarting);
            this.Browser.NavigationCompleted += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs>(this.Browser_NavigationCompleted);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.Browser);
            this.splitContainer1.Size = new System.Drawing.Size(1371, 857);
            this.splitContainer1.SplitterDistance = 213;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.SecuaCerf);
            this.panel1.Controls.Add(this.Secua);
            this.panel1.Controls.Add(this.labelStatus);
            this.panel1.Controls.Add(this.labelFPS);
            this.panel1.Controls.Add(this.AutoInput);
            this.panel1.Controls.Add(this.ContextMenu);
            this.panel1.Controls.Add(this.ShortCutKey);
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Zoom);
            this.panel1.Controls.Add(this.AutoPasswordSaveEnable);
            this.panel1.Controls.Add(this.Reload);
            this.panel1.Controls.Add(this.Forward);
            this.panel1.Controls.Add(this.BackForward);
            this.panel1.Controls.Add(this.EnableDev);
            this.panel1.Controls.Add(this.EnableJavaScript);
            this.panel1.Controls.Add(this.Search);
            this.panel1.Controls.Add(this.URLBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1371, 213);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(665, 64);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 35);
            this.button1.TabIndex = 21;
            this.button1.Text = "アプリについて";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SecuaCerf
            // 
            this.SecuaCerf.AutoSize = true;
            this.SecuaCerf.BackColor = System.Drawing.Color.LightGreen;
            this.SecuaCerf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SecuaCerf.ForeColor = System.Drawing.Color.Black;
            this.SecuaCerf.Location = new System.Drawing.Point(88, 81);
            this.SecuaCerf.Name = "SecuaCerf";
            this.SecuaCerf.Size = new System.Drawing.Size(31, 23);
            this.SecuaCerf.TabIndex = 20;
            this.SecuaCerf.Text = "🔒";
            this.toolTip1.SetToolTip(this.SecuaCerf, "証明書が切れてるか切れてないかを表します。");
            this.SecuaCerf.Click += new System.EventHandler(this.SecuaCerf_Click);
            // 
            // Secua
            // 
            this.Secua.BackColor = System.Drawing.Color.LightGreen;
            this.Secua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Secua.ForeColor = System.Drawing.Color.Black;
            this.Secua.Location = new System.Drawing.Point(88, 112);
            this.Secua.Name = "Secua";
            this.Secua.Size = new System.Drawing.Size(31, 23);
            this.Secua.TabIndex = 19;
            this.Secua.Text = "🔒";
            this.toolTip1.SetToolTip(this.Secua, "クリックして、セキュリティ証明書の詳細を確認します。");
            this.Secua.Click += new System.EventHandler(this.Secua_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(619, 150);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(40, 23);
            this.labelStatus.TabIndex = 18;
            this.labelStatus.Text = "快適";
            // 
            // labelFPS
            // 
            this.labelFPS.AutoSize = true;
            this.labelFPS.Location = new System.Drawing.Point(461, 149);
            this.labelFPS.Name = "labelFPS";
            this.labelFPS.Size = new System.Drawing.Size(173, 23);
            this.labelFPS.TabIndex = 17;
            this.labelFPS.Text = "FPSを読み込んでます。";
            // 
            // AutoInput
            // 
            this.AutoInput.AutoSize = true;
            this.AutoInput.Checked = true;
            this.AutoInput.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AutoInput.Location = new System.Drawing.Point(1177, 14);
            this.AutoInput.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.AutoInput.Name = "AutoInput";
            this.AutoInput.Size = new System.Drawing.Size(92, 27);
            this.AutoInput.TabIndex = 16;
            this.AutoInput.Text = "自動入力";
            this.AutoInput.UseVisualStyleBackColor = true;
            this.AutoInput.CheckedChanged += new System.EventHandler(this.AutoInput_CheckedChanged);
            this.AutoInput.Click += new System.EventHandler(this.Sound);
            // 
            // ContextMenu
            // 
            this.ContextMenu.AutoSize = true;
            this.ContextMenu.Checked = true;
            this.ContextMenu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ContextMenu.Location = new System.Drawing.Point(998, 14);
            this.ContextMenu.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ContextMenu.Name = "ContextMenu";
            this.ContextMenu.Size = new System.Drawing.Size(182, 27);
            this.ContextMenu.TabIndex = 15;
            this.ContextMenu.Text = "コンテキストメニュー";
            this.ContextMenu.UseVisualStyleBackColor = true;
            this.ContextMenu.CheckedChanged += new System.EventHandler(this.ContextMenu_CheckedChanged);
            this.ContextMenu.Click += new System.EventHandler(this.Sound);
            // 
            // ShortCutKey
            // 
            this.ShortCutKey.AutoSize = true;
            this.ShortCutKey.Checked = true;
            this.ShortCutKey.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ShortCutKey.Location = new System.Drawing.Point(838, 14);
            this.ShortCutKey.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ShortCutKey.Name = "ShortCutKey";
            this.ShortCutKey.Size = new System.Drawing.Size(167, 27);
            this.ShortCutKey.TabIndex = 14;
            this.ShortCutKey.Text = "ショートカットキー";
            this.ShortCutKey.UseVisualStyleBackColor = true;
            this.ShortCutKey.CheckedChanged += new System.EventHandler(this.ShortCutKey_CheckedChanged);
            this.ShortCutKey.Click += new System.EventHandler(this.Sound);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(537, 52);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(106, 27);
            this.radioButton3.TabIndex = 13;
            this.radioButton3.Text = "非推奨設定";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            this.radioButton3.Click += new System.EventHandler(this.Sound);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(383, 52);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(150, 27);
            this.radioButton2.TabIndex = 12;
            this.radioButton2.Text = "子供向け(教育版)";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            this.radioButton2.Click += new System.EventHandler(this.Sound);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(181, 52);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(196, 27);
            this.radioButton1.TabIndex = 11;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "デフォルト（カスタム）";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            this.radioButton1.Click += new System.EventHandler(this.Sound);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "プリセット:";
            // 
            // Zoom
            // 
            this.Zoom.AutoSize = true;
            this.Zoom.Checked = true;
            this.Zoom.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Zoom.Location = new System.Drawing.Point(665, 14);
            this.Zoom.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Zoom.Name = "Zoom";
            this.Zoom.Size = new System.Drawing.Size(167, 27);
            this.Zoom.TabIndex = 8;
            this.Zoom.Text = "ウェブ画面をズーム";
            this.Zoom.UseVisualStyleBackColor = true;
            this.Zoom.CheckedChanged += new System.EventHandler(this.Zoom_CheckedChanged);
            this.Zoom.Click += new System.EventHandler(this.Sound);
            // 
            // AutoPasswordSaveEnable
            // 
            this.AutoPasswordSaveEnable.AutoSize = true;
            this.AutoPasswordSaveEnable.Checked = true;
            this.AutoPasswordSaveEnable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AutoPasswordSaveEnable.Location = new System.Drawing.Point(552, 14);
            this.AutoPasswordSaveEnable.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.AutoPasswordSaveEnable.Name = "AutoPasswordSaveEnable";
            this.AutoPasswordSaveEnable.Size = new System.Drawing.Size(107, 27);
            this.AutoPasswordSaveEnable.TabIndex = 7;
            this.AutoPasswordSaveEnable.Text = "パスワード";
            this.AutoPasswordSaveEnable.UseVisualStyleBackColor = true;
            this.AutoPasswordSaveEnable.CheckedChanged += new System.EventHandler(this.AutoPasswordSaveEnable_CheckedChanged);
            this.AutoPasswordSaveEnable.Click += new System.EventHandler(this.Sound);
            // 
            // Reload
            // 
            this.Reload.Location = new System.Drawing.Point(357, 150);
            this.Reload.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Reload.Name = "Reload";
            this.Reload.Size = new System.Drawing.Size(41, 35);
            this.Reload.TabIndex = 6;
            this.Reload.Text = "🔃";
            this.Reload.UseVisualStyleBackColor = true;
            this.Reload.Click += new System.EventHandler(this.Reload_Click);
            // 
            // Forward
            // 
            this.Forward.Location = new System.Drawing.Point(404, 150);
            this.Forward.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Forward.Name = "Forward";
            this.Forward.Size = new System.Drawing.Size(41, 35);
            this.Forward.TabIndex = 5;
            this.Forward.Text = "🔜";
            this.Forward.UseVisualStyleBackColor = true;
            this.Forward.Click += new System.EventHandler(this.Forward_Click);
            // 
            // BackForward
            // 
            this.BackForward.Location = new System.Drawing.Point(314, 150);
            this.BackForward.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BackForward.Name = "BackForward";
            this.BackForward.Size = new System.Drawing.Size(41, 35);
            this.BackForward.TabIndex = 4;
            this.BackForward.Text = "🔙";
            this.BackForward.UseVisualStyleBackColor = true;
            this.BackForward.Click += new System.EventHandler(this.BackForward_Click);
            // 
            // EnableDev
            // 
            this.EnableDev.AutoSize = true;
            this.EnableDev.Checked = true;
            this.EnableDev.CheckState = System.Windows.Forms.CheckState.Checked;
            this.EnableDev.Location = new System.Drawing.Point(404, 14);
            this.EnableDev.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.EnableDev.Name = "EnableDev";
            this.EnableDev.Size = new System.Drawing.Size(142, 27);
            this.EnableDev.TabIndex = 3;
            this.EnableDev.Text = "DevToolsの有効";
            this.EnableDev.UseVisualStyleBackColor = true;
            this.EnableDev.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            this.EnableDev.Click += new System.EventHandler(this.Sound);
            // 
            // EnableJavaScript
            // 
            this.EnableJavaScript.AutoSize = true;
            this.EnableJavaScript.Checked = true;
            this.EnableJavaScript.CheckState = System.Windows.Forms.CheckState.Checked;
            this.EnableJavaScript.Location = new System.Drawing.Point(125, 14);
            this.EnableJavaScript.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.EnableJavaScript.Name = "EnableJavaScript";
            this.EnableJavaScript.Size = new System.Drawing.Size(273, 27);
            this.EnableJavaScript.TabIndex = 2;
            this.EnableJavaScript.Text = "JavaScriptの有効（有効が、推奨）";
            this.toolTip1.SetToolTip(this.EnableJavaScript, "JavaScriptを有効化するかどうか※この設定は非推奨");
            this.EnableJavaScript.UseVisualStyleBackColor = true;
            this.EnableJavaScript.CheckedChanged += new System.EventHandler(this.EnableJavaScript_CheckedChanged);
            this.EnableJavaScript.Click += new System.EventHandler(this.Sound);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(1275, 109);
            this.Search.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(84, 35);
            this.Search.TabIndex = 1;
            this.Search.Text = "検索";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // URLBox
            // 
            this.URLBox.FormattingEnabled = true;
            this.URLBox.Items.AddRange(new object[] {
            "https://chatgpt.com/"});
            this.URLBox.Location = new System.Drawing.Point(125, 109);
            this.URLBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.URLBox.Name = "URLBox";
            this.URLBox.Size = new System.Drawing.Size(1144, 31);
            this.URLBox.TabIndex = 0;
            this.URLBox.Text = "https://google.co.jp";
            this.URLBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.URLBox_KeyDown);
            // 
            // FPS
            // 
            this.FPS.Tick += new System.EventHandler(this.FPS_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 857);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("メイリオ", 9F);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "Form1";
            this.Text = "NetSerfin";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.Browser)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 Browser;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.ComboBox URLBox;
        private System.Windows.Forms.CheckBox EnableDev;
        private System.Windows.Forms.CheckBox EnableJavaScript;
        private System.Windows.Forms.Button Reload;
        private System.Windows.Forms.Button Forward;
        private System.Windows.Forms.Button BackForward;
        private System.Windows.Forms.CheckBox AutoPasswordSaveEnable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox Zoom;
        private System.Windows.Forms.CheckBox AutoInput;
        private System.Windows.Forms.CheckBox ContextMenu;
        private System.Windows.Forms.CheckBox ShortCutKey;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Timer FPS;
        private System.Windows.Forms.Label labelFPS;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label Secua;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label SecuaCerf;
        private System.Windows.Forms.Button button1;
    }
}

