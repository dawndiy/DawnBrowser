namespace DawnBrowser
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.新建标签页ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.关闭标签页ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建标签页ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关闭标签页ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.页面设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打印ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打印预览ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.页面另存为ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.属性ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.刷新ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.停止ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.源文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.工具TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.internetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.清除上网时间ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.附件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.截图工具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.邮件工具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.计时工具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.系统信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnGoBack = new System.Windows.Forms.ToolStripButton();
            this.btnGoForward = new System.Windows.Forms.ToolStripButton();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.btnStop = new System.Windows.Forms.ToolStripButton();
            this.btnGoHome = new System.Windows.Forms.ToolStripButton();
            this.btnNewTabPage = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.txtUrl = new System.Windows.Forms.ToolStripComboBox();
            this.btnGoTo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSearchEngine = new System.Windows.Forms.ToolStripSplitButton();
            this.谷歌ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.百度ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtSearch = new System.Windows.Forms.ToolStripTextBox();
            this.btnSearch = new System.Windows.Forms.ToolStripButton();
            this.btnCloseTabPage = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.timeLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.云输入法ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.豆瓣FMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.ContextMenuStrip = this.contextMenuStrip1;
            this.tabControl1.Location = new System.Drawing.Point(0, 53);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(844, 432);
            this.tabControl1.TabIndex = 3;
            this.tabControl1.DoubleClick += new System.EventHandler(this.tabControl1_DoubleClick);
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建标签页ToolStripMenuItem1,
            this.关闭标签页ToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(137, 48);
            // 
            // 新建标签页ToolStripMenuItem1
            // 
            this.新建标签页ToolStripMenuItem1.Name = "新建标签页ToolStripMenuItem1";
            this.新建标签页ToolStripMenuItem1.Size = new System.Drawing.Size(136, 22);
            this.新建标签页ToolStripMenuItem1.Text = "新建标签页";
            this.新建标签页ToolStripMenuItem1.Click += new System.EventHandler(this.新建标签页ToolStripMenuItem1_Click);
            // 
            // 关闭标签页ToolStripMenuItem1
            // 
            this.关闭标签页ToolStripMenuItem1.Name = "关闭标签页ToolStripMenuItem1";
            this.关闭标签页ToolStripMenuItem1.Size = new System.Drawing.Size(136, 22);
            this.关闭标签页ToolStripMenuItem1.Text = "关闭标签页";
            this.关闭标签页ToolStripMenuItem1.Click += new System.EventHandler(this.关闭标签页ToolStripMenuItem1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件FToolStripMenuItem,
            this.查看ToolStripMenuItem,
            this.工具TToolStripMenuItem,
            this.附件ToolStripMenuItem,
            this.帮助HToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(844, 25);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件FToolStripMenuItem
            // 
            this.文件FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建标签页ToolStripMenuItem,
            this.关闭标签页ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.页面设置ToolStripMenuItem,
            this.打印ToolStripMenuItem,
            this.打印预览ToolStripMenuItem,
            this.toolStripMenuItem4,
            this.页面另存为ToolStripMenuItem,
            this.属性ToolStripMenuItem,
            this.toolStripMenuItem2,
            this.退出ToolStripMenuItem});
            this.文件FToolStripMenuItem.Name = "文件FToolStripMenuItem";
            this.文件FToolStripMenuItem.Size = new System.Drawing.Size(58, 21);
            this.文件FToolStripMenuItem.Text = "文件(&F)";
            // 
            // 新建标签页ToolStripMenuItem
            // 
            this.新建标签页ToolStripMenuItem.Name = "新建标签页ToolStripMenuItem";
            this.新建标签页ToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.新建标签页ToolStripMenuItem.Text = "新建标签页";
            this.新建标签页ToolStripMenuItem.Click += new System.EventHandler(this.新建标签页ToolStripMenuItem_Click);
            // 
            // 关闭标签页ToolStripMenuItem
            // 
            this.关闭标签页ToolStripMenuItem.Name = "关闭标签页ToolStripMenuItem";
            this.关闭标签页ToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.关闭标签页ToolStripMenuItem.Text = "关闭标签页";
            this.关闭标签页ToolStripMenuItem.Click += new System.EventHandler(this.关闭标签页ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(142, 6);
            // 
            // 页面设置ToolStripMenuItem
            // 
            this.页面设置ToolStripMenuItem.Name = "页面设置ToolStripMenuItem";
            this.页面设置ToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.页面设置ToolStripMenuItem.Text = "页面设置";
            this.页面设置ToolStripMenuItem.Click += new System.EventHandler(this.页面设置ToolStripMenuItem_Click);
            // 
            // 打印ToolStripMenuItem
            // 
            this.打印ToolStripMenuItem.Name = "打印ToolStripMenuItem";
            this.打印ToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.打印ToolStripMenuItem.Text = "打印";
            this.打印ToolStripMenuItem.Click += new System.EventHandler(this.打印ToolStripMenuItem_Click);
            // 
            // 打印预览ToolStripMenuItem
            // 
            this.打印预览ToolStripMenuItem.Name = "打印预览ToolStripMenuItem";
            this.打印预览ToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.打印预览ToolStripMenuItem.Text = "打印预览";
            this.打印预览ToolStripMenuItem.Click += new System.EventHandler(this.打印预览ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(142, 6);
            // 
            // 页面另存为ToolStripMenuItem
            // 
            this.页面另存为ToolStripMenuItem.Name = "页面另存为ToolStripMenuItem";
            this.页面另存为ToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.页面另存为ToolStripMenuItem.Text = "页面另存为...";
            this.页面另存为ToolStripMenuItem.Click += new System.EventHandler(this.页面另存为ToolStripMenuItem_Click);
            // 
            // 属性ToolStripMenuItem
            // 
            this.属性ToolStripMenuItem.Name = "属性ToolStripMenuItem";
            this.属性ToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.属性ToolStripMenuItem.Text = "属性";
            this.属性ToolStripMenuItem.Click += new System.EventHandler(this.属性ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(142, 6);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 查看ToolStripMenuItem
            // 
            this.查看ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.刷新ToolStripMenuItem,
            this.停止ToolStripMenuItem,
            this.toolStripMenuItem3,
            this.源文件ToolStripMenuItem});
            this.查看ToolStripMenuItem.Name = "查看ToolStripMenuItem";
            this.查看ToolStripMenuItem.Size = new System.Drawing.Size(60, 21);
            this.查看ToolStripMenuItem.Text = "查看(&V)";
            // 
            // 刷新ToolStripMenuItem
            // 
            this.刷新ToolStripMenuItem.Name = "刷新ToolStripMenuItem";
            this.刷新ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.刷新ToolStripMenuItem.Text = "刷新";
            this.刷新ToolStripMenuItem.Click += new System.EventHandler(this.刷新ToolStripMenuItem_Click);
            // 
            // 停止ToolStripMenuItem
            // 
            this.停止ToolStripMenuItem.Name = "停止ToolStripMenuItem";
            this.停止ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.停止ToolStripMenuItem.Text = "停止";
            this.停止ToolStripMenuItem.Click += new System.EventHandler(this.停止ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(109, 6);
            // 
            // 源文件ToolStripMenuItem
            // 
            this.源文件ToolStripMenuItem.Name = "源文件ToolStripMenuItem";
            this.源文件ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.源文件ToolStripMenuItem.Text = "源文件";
            this.源文件ToolStripMenuItem.Click += new System.EventHandler(this.源文件ToolStripMenuItem_Click);
            // 
            // 工具TToolStripMenuItem
            // 
            this.工具TToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.internetToolStripMenuItem,
            this.清除上网时间ToolStripMenuItem});
            this.工具TToolStripMenuItem.Name = "工具TToolStripMenuItem";
            this.工具TToolStripMenuItem.Size = new System.Drawing.Size(59, 21);
            this.工具TToolStripMenuItem.Text = "工具(&T)";
            // 
            // internetToolStripMenuItem
            // 
            this.internetToolStripMenuItem.Name = "internetToolStripMenuItem";
            this.internetToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.internetToolStripMenuItem.Text = "Internet选项";
            this.internetToolStripMenuItem.Click += new System.EventHandler(this.internetToolStripMenuItem_Click);
            // 
            // 清除上网时间ToolStripMenuItem
            // 
            this.清除上网时间ToolStripMenuItem.Name = "清除上网时间ToolStripMenuItem";
            this.清除上网时间ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.清除上网时间ToolStripMenuItem.Text = "清除上网时间";
            this.清除上网时间ToolStripMenuItem.Click += new System.EventHandler(this.清除上网时间ToolStripMenuItem_Click);
            // 
            // 附件ToolStripMenuItem
            // 
            this.附件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.截图工具ToolStripMenuItem,
            this.邮件工具ToolStripMenuItem,
            this.计时工具ToolStripMenuItem,
            this.云输入法ToolStripMenuItem,
            this.豆瓣FMToolStripMenuItem});
            this.附件ToolStripMenuItem.Name = "附件ToolStripMenuItem";
            this.附件ToolStripMenuItem.Size = new System.Drawing.Size(60, 21);
            this.附件ToolStripMenuItem.Text = "应用(&A)";
            // 
            // 截图工具ToolStripMenuItem
            // 
            this.截图工具ToolStripMenuItem.Name = "截图工具ToolStripMenuItem";
            this.截图工具ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.截图工具ToolStripMenuItem.Text = "截图工具";
            this.截图工具ToolStripMenuItem.Click += new System.EventHandler(this.截图工具ToolStripMenuItem_Click);
            // 
            // 邮件工具ToolStripMenuItem
            // 
            this.邮件工具ToolStripMenuItem.Name = "邮件工具ToolStripMenuItem";
            this.邮件工具ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.邮件工具ToolStripMenuItem.Text = "邮件工具";
            this.邮件工具ToolStripMenuItem.Click += new System.EventHandler(this.邮件工具ToolStripMenuItem_Click);
            // 
            // 计时工具ToolStripMenuItem
            // 
            this.计时工具ToolStripMenuItem.Name = "计时工具ToolStripMenuItem";
            this.计时工具ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.计时工具ToolStripMenuItem.Text = "提醒工具";
            this.计时工具ToolStripMenuItem.Click += new System.EventHandler(this.计时工具ToolStripMenuItem_Click);
            // 
            // 帮助HToolStripMenuItem
            // 
            this.帮助HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统信息ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            this.帮助HToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
            this.帮助HToolStripMenuItem.Text = "帮助(&H)";
            // 
            // 系统信息ToolStripMenuItem
            // 
            this.系统信息ToolStripMenuItem.Name = "系统信息ToolStripMenuItem";
            this.系统信息ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.系统信息ToolStripMenuItem.Text = "系统信息";
            this.系统信息ToolStripMenuItem.Click += new System.EventHandler(this.系统信息ToolStripMenuItem_Click);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.关于ToolStripMenuItem.Text = "关于";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGoBack,
            this.btnGoForward,
            this.btnRefresh,
            this.btnStop,
            this.btnGoHome,
            this.btnNewTabPage,
            this.toolStripSeparator1,
            this.txtUrl,
            this.btnGoTo,
            this.toolStripSeparator2,
            this.btnSearchEngine,
            this.txtSearch,
            this.btnSearch,
            this.btnCloseTabPage});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(744, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnGoBack
            // 
            this.btnGoBack.Image = global::DawnBrowser.Properties.Resources.BTN_GOBACK;
            this.btnGoBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(52, 22);
            this.btnGoBack.Text = "后退";
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // btnGoForward
            // 
            this.btnGoForward.Image = global::DawnBrowser.Properties.Resources.BTN_GOFORWARD;
            this.btnGoForward.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGoForward.Name = "btnGoForward";
            this.btnGoForward.Size = new System.Drawing.Size(52, 22);
            this.btnGoForward.Text = "前进";
            this.btnGoForward.Click += new System.EventHandler(this.btnGoForward_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = global::DawnBrowser.Properties.Resources.BTN_REFRESH;
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(52, 22);
            this.btnRefresh.Text = "刷新";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnStop
            // 
            this.btnStop.Image = global::DawnBrowser.Properties.Resources.BTN_STOP;
            this.btnStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(52, 22);
            this.btnStop.Text = "停止";
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnGoHome
            // 
            this.btnGoHome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGoHome.Image = global::DawnBrowser.Properties.Resources.BTN_HOME;
            this.btnGoHome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGoHome.Name = "btnGoHome";
            this.btnGoHome.Size = new System.Drawing.Size(23, 22);
            this.btnGoHome.Text = "主页";
            this.btnGoHome.Click += new System.EventHandler(this.btnGoHome_Click);
            // 
            // btnNewTabPage
            // 
            this.btnNewTabPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNewTabPage.Image = global::DawnBrowser.Properties.Resources.BTN_NEWTAB;
            this.btnNewTabPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNewTabPage.Name = "btnNewTabPage";
            this.btnNewTabPage.Size = new System.Drawing.Size(23, 22);
            this.btnNewTabPage.Text = "新建";
            this.btnNewTabPage.ToolTipText = "新建标签页";
            this.btnNewTabPage.Click += new System.EventHandler(this.btnNewTabPage_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // txtUrl
            // 
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(350, 25);
            this.txtUrl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUrl_KeyDown);
            this.txtUrl.Click += new System.EventHandler(this.txtUrl_Click);
            // 
            // btnGoTo
            // 
            this.btnGoTo.Image = global::DawnBrowser.Properties.Resources.BTN_GO;
            this.btnGoTo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGoTo.Name = "btnGoTo";
            this.btnGoTo.Size = new System.Drawing.Size(52, 22);
            this.btnGoTo.Text = "转到";
            this.btnGoTo.Click += new System.EventHandler(this.btnGoTo_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnSearchEngine
            // 
            this.btnSearchEngine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSearchEngine.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.谷歌ToolStripMenuItem,
            this.百度ToolStripMenuItem});
            this.btnSearchEngine.Image = global::DawnBrowser.Properties.Resources.google;
            this.btnSearchEngine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSearchEngine.Name = "btnSearchEngine";
            this.btnSearchEngine.Size = new System.Drawing.Size(32, 22);
            this.btnSearchEngine.Text = "搜索引擎";
            // 
            // 谷歌ToolStripMenuItem
            // 
            this.谷歌ToolStripMenuItem.Image = global::DawnBrowser.Properties.Resources.google;
            this.谷歌ToolStripMenuItem.Name = "谷歌ToolStripMenuItem";
            this.谷歌ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.谷歌ToolStripMenuItem.Text = "谷歌";
            this.谷歌ToolStripMenuItem.Click += new System.EventHandler(this.谷歌ToolStripMenuItem_Click);
            // 
            // 百度ToolStripMenuItem
            // 
            this.百度ToolStripMenuItem.Image = global::DawnBrowser.Properties.Resources.baidu;
            this.百度ToolStripMenuItem.Name = "百度ToolStripMenuItem";
            this.百度ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.百度ToolStripMenuItem.Text = "百度";
            this.百度ToolStripMenuItem.Click += new System.EventHandler(this.百度ToolStripMenuItem_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(150, 23);
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            this.txtSearch.Click += new System.EventHandler(this.txtSearch_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::DawnBrowser.Properties.Resources.BTN_SEARCH;
            this.btnSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(52, 21);
            this.btnSearch.Text = "搜索";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnCloseTabPage
            // 
            this.btnCloseTabPage.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnCloseTabPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCloseTabPage.Image = global::DawnBrowser.Properties.Resources.BTN_CLOSETAB;
            this.btnCloseTabPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCloseTabPage.Name = "btnCloseTabPage";
            this.btnCloseTabPage.Size = new System.Drawing.Size(23, 20);
            this.btnCloseTabPage.Text = "关闭标签";
            this.btnCloseTabPage.Click += new System.EventHandler(this.btnCloseTabPage_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripProgressBar1,
            this.timeLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 484);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(844, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.AutoSize = false;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(500, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripStatusLabel1.ToolTipText = "状态";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(11, 17);
            this.toolStripStatusLabel2.Text = "|";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // timeLabel
            // 
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // 云输入法ToolStripMenuItem
            // 
            this.云输入法ToolStripMenuItem.Name = "云输入法ToolStripMenuItem";
            this.云输入法ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.云输入法ToolStripMenuItem.Text = "云输入法";
            this.云输入法ToolStripMenuItem.Click += new System.EventHandler(this.云输入法ToolStripMenuItem_Click);
            // 
            // 豆瓣FMToolStripMenuItem
            // 
            this.豆瓣FMToolStripMenuItem.Name = "豆瓣FMToolStripMenuItem";
            this.豆瓣FMToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.豆瓣FMToolStripMenuItem.Text = "豆瓣FM";
            this.豆瓣FMToolStripMenuItem.Click += new System.EventHandler(this.豆瓣FMToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 506);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "DawnBrower";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新建标签页ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem 帮助HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripButton btnGoBack;
        private System.Windows.Forms.ToolStripButton btnGoForward;
        private System.Windows.Forms.ToolStripButton btnStop;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnGoTo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSplitButton btnSearchEngine;
        private System.Windows.Forms.ToolStripTextBox txtSearch;
        private System.Windows.Forms.ToolStripButton btnSearch;
        private System.Windows.Forms.ToolStripButton btnNewTabPage;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripMenuItem 关闭标签页ToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox txtUrl;
        private System.Windows.Forms.ToolStripMenuItem 属性ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 查看ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 源文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 谷歌ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 百度ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 新建标签页ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 关闭标签页ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 刷新ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 停止ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem 工具TToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem internetToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton btnCloseTabPage;
        private System.Windows.Forms.ToolStripMenuItem 页面另存为ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 页面设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打印ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打印预览ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem 系统信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton btnGoHome;
        private System.Windows.Forms.ToolStripMenuItem 附件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 截图工具ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 邮件工具ToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel timeLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem 计时工具ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 清除上网时间ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 云输入法ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 豆瓣FMToolStripMenuItem;
    }
}

