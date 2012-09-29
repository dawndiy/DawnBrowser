using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace DawnBrowser
{
    public partial class MainForm : Form
    {

        


        private int TITLE_COUNT = 10;               //标签上标题最大字符数
        private int CLOSE_SIZE = 15;                //标签上关闭按钮大小
        private string tempUrl;                     //浏览器中临时选中的URL
        private string searchEngine = "google";     //默认搜索引擎
        uint remainder=0;                           //计时的总秒数
        uint minute;                                //计时的分钟数
        uint second;                                //计时的秒数
        uint hour;                                  //计时的小时数

        public MainForm()
        {
            InitializeComponent();
        }


        #region 初始化
        //////////////////////////////////////////////
        //                                          //
        //                 初始化                   //
        //                                          //
        //////////////////////////////////////////////
        /// <summary>
        /// 窗体载入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            initMainFrom();
        }
        /// <summary>
        /// 浏览器初始化
        /// </summary>
        private void initMainFrom()
        {
            string timepath = @"time.dat";
            if (!File.Exists(timepath))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(timepath))
                {
                    sw.WriteLine("0");
                }
            }
            else
            {
                StreamReader sr = File.OpenText(timepath);
                String s = "0";
                s = sr.ReadLine();
                remainder = uint.Parse(s);

            }


            /*初始化*/
            this.tabControl1.DrawMode = TabDrawMode.OwnerDrawFixed;
            this.tabControl1.Padding = new System.Drawing.Point(CLOSE_SIZE, 4);
            this.tabControl1.DrawItem+=new DrawItemEventHandler(this.tabControl1_DrawItem);
            this.tabControl1.MouseDown+=new MouseEventHandler(tabControl1_MouseDown);
            newTabPage();
            getCurrentBrowser().GoHome();
            timer1.Enabled = true;

        }


        #endregion

        #region 常用方法
        //////////////////////////////////////////////
        //                                          //
        //                功能方法                  //
        //                                          //
        //////////////////////////////////////////////
        /// <summary>
        /// 规范处理链接地址
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        private Uri getUrl(string address)
        {
            string tempaddress = address;
            if ((!address.StartsWith("http://")) && (!address.StartsWith("https://")) && (!address.StartsWith("ftp://")) && (!address.StartsWith("javascript")))
            {
                tempaddress = "http://" + address;
            }
            //txturl.text = tempaddress;
            Uri myurl;
            try
            {
                myurl = new Uri(tempaddress);
            }
            catch
            {
                myurl = new Uri("about:blank");
            }
            return myurl;
        }
        /// <summary>
        /// 获取当前浏览器
        /// </summary>
        /// <returns></returns>
        private WebBrowser getCurrentBrowser()
        {
            WebBrowser wb = (WebBrowser)tabControl1.SelectedTab.Controls[0];
            return wb;
        }
        /// <summary>
        /// 规范处理标签标题
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        private string newTitle(string address)
        {
            string temp;
            if (address.Length < TITLE_COUNT)
            {
                this.Text = address + " - DawnBrowser";
                return address;
            }
            else
            {
                temp = address.Substring(0, TITLE_COUNT);
            }
            string formTitle = address + " - DawnBrowser";
            this.Text = formTitle;
            return temp + "…";
        }
        /// <summary>
        /// 控制进度条变化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newWebBrowser_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            toolStripProgressBar1.Visible = true;
            toolStripProgressBar1.Maximum = (int)e.MaximumProgress;
            toolStripProgressBar1.Value = (int)e.CurrentProgress;
            toolStripProgressBar1.Visible = false;
            /*******************暂时处理办法*********************/
            //解决网页加载慢导致标题未显示出来
            if (e.MaximumProgress==e.CurrentProgress)
                ((TabPage)getCurrentBrowser().Parent).Text = newTitle(getCurrentBrowser().DocumentTitle);

            setButtonStatus();
        }
        /// <summary>
        /// 新建空白页
        /// </summary>
        private void newTabPage()
        {
            //空白页地址栏地址
            txtUrl.Text = "about:blank";
            //新建空白标签页
            TabPage newTabpage = new TabPage("新标签页");
            //主窗口标题更新
            this.Text = "新标签页 - DawnBrowser";
            //新建浏览器
            WebBrowser newWebBrowser = new WebBrowser();
            //为临时浏览器关联NewWindow等事件
            newWebBrowser.Navigated+=new WebBrowserNavigatedEventHandler(newWebBrowser_Navigated);
            newWebBrowser.NewWindow += new CancelEventHandler(newWebBrowser_NewWindow);
            newWebBrowser.ProgressChanged += new WebBrowserProgressChangedEventHandler(newWebBrowser_ProgressChanged);
            newWebBrowser.StatusTextChanged += new EventHandler(newWebBrowser_StatusTextChanged);
            //浏览器最大化填满标签页
            newWebBrowser.Dock = DockStyle.Fill;
            //将浏览器添加到新标签页里
            newTabpage.Controls.Add(newWebBrowser);
            //将新标签页添加到主窗体里
            tabControl1.Controls.Add(newTabpage);
            //跳转到新加的标签页,总标签页数+1
            tabControl1.SelectedIndex = tabControl1.TabPages.Count-1;
        }
        /// <summary>
        /// 新建空白页(重载)
        /// </summary>
        /// <param name="url"></param>
        private void newTabPage(string url)
        {
            newTabPage();
            newCurrentPageUrl(url);
        }

        private void setButtonStatus()
        {
            btnGoForward.Enabled = getCurrentBrowser().CanGoForward;
            btnGoBack.Enabled = getCurrentBrowser().CanGoBack;
        }

        #endregion

        #region 新建浏览器事件 
        //////////////////////////////////////////////
        //                                          //
        //           新建浏览器事件实现             //
        //                                          //
        //////////////////////////////////////////////
        /// <summary>
        /// 当前页面重新定向
        /// </summary>
        /// <param name="address"></param>
        private void newCurrentPageUrl(string address)
        {
            Uri url = getUrl(address);
            getCurrentBrowser().Navigate(url);
        }
        /// <summary>
        /// 浏览器定向完毕
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void newWebBrowser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            //地址栏显示规范地址
            txtUrl.Text = getCurrentBrowser().Url.ToString();
            //获得当前浏览器对象
            WebBrowser newWebBrowser = (WebBrowser)sender;
            //获得当前标签页对象
            TabPage newTabPage = (TabPage)newWebBrowser.Parent;
            //设置临时浏览器所在tab标题
            newTabPage.Text = newTitle(newWebBrowser.DocumentTitle);

        }
        /// <summary>
        /// 浏览器产生新窗口事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void newWebBrowser_NewWindow(object sender, CancelEventArgs e)
        {
            //获取触发newWebBrowser_NewWindow事件的浏览器
            WebBrowser newWebBrowser = (WebBrowser)sender;
            //获取触发newWebBrowser_NewWindow事件的浏览器所在TabPage
            TabPage newPage = (TabPage)newWebBrowser.Parent;
            //通过StatusText属性获得新的url
            string NewURL = ((WebBrowser)sender).StatusText;
            string NewURL1 = tempUrl;
            //新建标签页并打开新URL
            newTabPage(NewURL1);
            //使外部无法捕获此事件
            e.Cancel = true;
        }
        /// <summary>
        /// 浏览器状态变化事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void newWebBrowser_StatusTextChanged(object sender, EventArgs e)
        {

            WebBrowser newWebBrowser = (WebBrowser)sender;
            if (newWebBrowser != getCurrentBrowser())
            {
                return;
            }
            else
            {
                if (newWebBrowser.StatusText.Length != 0)
                {
                    tempUrl = newWebBrowser.StatusText;
                }
                toolStripStatusLabel1.Text = newWebBrowser.StatusText;
            }
        }
        
        #endregion

        #region tabControl1控件的常用事件
        /////////////////////////////////////////////
        //                                         //
        //       tabControl事件处理实现            //
        //                                         //
        /////////////////////////////////////////////
        /// <summary>
        /// 关闭选定标签方法
        /// </summary>
        private void tabPageClose()
        {
            //获取当前浏览器
            WebBrowser wb = getCurrentBrowser();
            //释放浏览器资源
            wb.Dispose();
            wb.Controls.Clear();
            //记录该标签索引
            int temp = tabControl1.SelectedIndex;
            //删除该标签页
            tabControl1.TabPages.Remove(tabControl1.SelectedTab);

            if (tabControl1.TabPages.Count < 1)
            {   //如果只剩一个标签时返回一个新的标签页
                newTabPage();
            }
            else
            {   //如果前面还有标签页
                if (temp==tabControl1.TabPages.Count)
                    //如果是最右边的标签页关闭着向前移
                    tabControl1.SelectedTab = tabControl1.TabPages[temp-1];
                else
                    tabControl1.SelectedTab = tabControl1.TabPages[temp];
            }
        }
        /// <summary>
        /// 标签页切换
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.TabCount != 0)
            {
                WebBrowser wb = (WebBrowser)tabControl1.SelectedTab.Controls[0];
                if (wb.Url == null)
                {
                    tabControl1.SelectedTab.Text = newTitle("新标签页");
                    txtUrl.Text = "about:blank";
                }
                else
                {
                    tabControl1.SelectedTab.Text = newTitle(wb.DocumentTitle);
                    txtUrl.Text = wb.Url.ToString();
                }
                setButtonStatus();
            }
        }

        /// <summary>
        /// 双击标签关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabControl1_DoubleClick(object sender, EventArgs e)
        {
            tabPageClose();
        }
        /// <summary>
        /// tabControl1控件标签重绘
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            try
            {
                Rectangle myTabRect = this.tabControl1.GetTabRect(e.Index);

                //添加TabPage属性
                e.Graphics.DrawString(this.tabControl1.TabPages[e.Index].Text, this.Font, SystemBrushes.ControlText, myTabRect.X + 2, myTabRect.Y + 2);

                //画一个矩形框
                using (Pen p = new Pen(Color.White))
                {
                    myTabRect.Offset(myTabRect.Width-(CLOSE_SIZE+3),2);
                    myTabRect.Width = CLOSE_SIZE-2;
                    myTabRect.Height = CLOSE_SIZE-2;
                    e.Graphics.DrawRectangle(p, myTabRect);
                }
                //填充矩形框
                Color recColor = e.State == DrawItemState.Selected ? Color.LightSteelBlue : Color.LightGray;
                using (Brush b = new SolidBrush(recColor))
                {
                    e.Graphics.FillRectangle(b, myTabRect);
                }
                //画关闭符号
                using (Pen objpen = new Pen(Color.LightYellow))
                {
                    
                    //画X
                    //"\"线
                    Point p1 = new Point(myTabRect.X + 4, myTabRect.Y + 4);
                    Point p2 = new Point(myTabRect.X + myTabRect.Width - 4, myTabRect.Y + myTabRect.Height - 4);
                    e.Graphics.DrawLine(objpen, p1, p2);
                    Point p11 = new Point(myTabRect.X + 4, myTabRect.Y + 4);
                    Point p22 = new Point(myTabRect.X + myTabRect.Width - 4, myTabRect.Y + myTabRect.Height - 4);
                    e.Graphics.DrawLine(objpen, p11, p22);
                    //"/"线
                    Point p3 = new Point(myTabRect.X + 4, myTabRect.Y + myTabRect.Height - 4);
                    Point p4 = new Point(myTabRect.X + myTabRect.Width - 4, myTabRect.Y + 4);
                    e.Graphics.DrawLine(objpen, p3, p4);

                   
                }
                e.Graphics.Dispose();
            }
            catch (System.Exception )
            {
                
            }
        }
        /// <summary>
        /// tab标签上的关闭按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabControl1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int x = e.X, y = e.Y;
                //计算关闭区域  
                Rectangle myTabRect = this.tabControl1.GetTabRect(this.tabControl1.SelectedIndex);

                myTabRect.Offset(myTabRect.Width - (CLOSE_SIZE + 3), 2);
                myTabRect.Width = CLOSE_SIZE;
                myTabRect.Height = CLOSE_SIZE;

                //如果鼠标在区域内就关闭选项卡  
                bool isClose = x > myTabRect.X && x < myTabRect.Right && y > myTabRect.Y && y < myTabRect.Bottom;
                if (isClose == true)
                {
                    tabPageClose();
                }
            }
        }


        #endregion

        #region 菜单栏
        ///////////////////////////////////////
        //                                   //
        //          菜单栏功能实现           //
        //                                   //
        ///////////////////////////////////////
        /// <summary>
        /// 退出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        /// <summary>
        /// 新建标签页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 新建标签页ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newTabPage();
        }
        /// <summary>
        /// 关闭标签页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 关闭标签页ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabPageClose();
        }
        /// <summary>
        /// 关于
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutForm().Visible = true;
        }
        /// <summary>
        /// 属性
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 属性ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            getCurrentBrowser().ShowPropertiesDialog();
        }
        /// <summary>
        /// 查看源文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 源文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HtmlElement elem;
            WebBrowser wb = getCurrentBrowser();
            if (wb.Document != null)
            {
                CodeForm cf = new CodeForm();
                HtmlElementCollection elems = wb.Document.GetElementsByTagName("HTML");
                if (elems.Count == 1)
                {
                    elem = elems[0];
                    cf.Code = elem.OuterHtml;
                    cf.Text = wb.Url.ToString() + " - 源文件";
                    cf.Show();
                }
            }

        }

        private void 关闭标签页ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tabPageClose();
        }
        private void 新建标签页ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            newTabPage();
        }

        private void 刷新ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            getCurrentBrowser().Refresh();
        }

        private void 停止ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            getCurrentBrowser().Stop();
        }

        private void 页面另存为ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            getCurrentBrowser().ShowSaveAsDialog();
        }

        private void 页面设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            getCurrentBrowser().ShowPageSetupDialog();
        }

        private void 打印ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            getCurrentBrowser().ShowPrintDialog();
        }

        private void 打印预览ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            getCurrentBrowser().ShowPrintPreviewDialog();
        }
        /// <summary>
        /// 调用Internet选项面板
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void internetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo = new System.Diagnostics.ProcessStartInfo("rundll32.exe", "shell32.dll,Control_RunDLL inetcpl.cpl");
            p.Start();
        }
        /// <summary>
        /// 显示系统信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 系统信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new WMIForm().Show();
        }

        /// <summary>
        /// 复位上网时间
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 清除上网时间ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否复位上网计数器?", "清除上网时间", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                File.Delete("time.dat");
                remainder = 0;
            }
        }

        /// <summary>
        /// 截图调用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 截图工具ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("cutimage.exe");
        }
        /// <summary>
        /// 发送邮件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 邮件工具ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new MailForm().Visible = true;
        }
        /// <summary>
        /// 计时工具
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 计时工具ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new TimeForm().Show();
        }
        /// <summary>
        /// 云输入法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 云输入法ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newCurrentPageUrl("javascript:(function(q){!!q?q.toggle():(function(d,j){j=d.createElement('script');j.src='//ime.qq.com/fcgi-bin/getjs';j.setAttribute('ime-cfg','lt=2');d.getElementsByTagName('head')[0].appendChild(j)})(document)})(window.QQWebIME)");

        }
        /// <summary>
        /// 豆瓣电台
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 豆瓣FMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newTabPage("http://douban.fm/radio");
        }
        #endregion

        #region 工具栏
        //////////////////////////////////////
        //                                  //
        //         工具栏功能实现           //
        //                                  //
        //////////////////////////////////////
        
        /// <summary>
        /// 转到按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGoTo_Click(object sender, EventArgs e)
        {
            newCurrentPageUrl(txtUrl.Text);

        }
        /// <summary>
        /// 地址栏输入地址后按下回车
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtUrl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                newCurrentPageUrl(txtUrl.Text);
        }
        /// <summary>
        /// 单击选中所有地址栏上的地址
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtUrl_Click(object sender, EventArgs e)
        {
            txtUrl.SelectAll();
        }
        /// <summary>
        /// 刷新按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            getCurrentBrowser().Refresh();
        }
        /// <summary>
        /// 停止
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStop_Click(object sender, EventArgs e)
        {
            getCurrentBrowser().Stop();
        }
        /// <summary>
        /// 新建标签页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNewTabPage_Click(object sender, EventArgs e)
        {
            newTabPage();
        }
        /// <summary>
        /// 后退按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGoBack_Click(object sender, EventArgs e)
        {
            getCurrentBrowser().GoBack();
            setButtonStatus();
        }
        /// <summary>
        /// 前进按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGoForward_Click(object sender, EventArgs e)
        {
            getCurrentBrowser().GoForward();
            setButtonStatus();
        }
        /// <summary>
        /// 标签页关闭按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCloseTabPage_Click(object sender, EventArgs e)
        {
            tabPageClose();
        }
        /// <summary>
        /// 返回主页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGoHome_Click(object sender, EventArgs e)
        {
            getCurrentBrowser().GoHome();
        }
        #endregion

        #region 搜索功能
        //////////////////////////////////////////////////
        //                                              //
        //                  搜索模块                    //
        //                                              //
        //////////////////////////////////////////////////

        /// <summary>
        /// 切换为谷歌搜索引擎
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 谷歌ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            谷歌ToolStripMenuItem.Select();
            btnSearchEngine.Image = global::DawnBrowser.Properties.Resources.google;
            searchEngine = "google";
        }
        /// <summary>
        /// 切换为百度搜索引擎
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 百度ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            百度ToolStripMenuItem.Select();
            btnSearchEngine.Image = global::DawnBrowser.Properties.Resources.baidu;
            searchEngine = "baidu";
        }
        /// <summary>
        /// 搜索关键字
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string url;
            switch (searchEngine)
            {
                case "google":
                    url = "http://www.google.com/search?q=" + txtSearch;
                    break;
                case "baidu":
                    url = "http://www.baidu.com/s?wd=" + txtSearch;
                    break;
                default:
                    url = "";
                    break;
            }
            newTabPage(url);
        }
        /// <summary>
        /// 搜索框中按下Enter键搜索
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSearch_Click(sender,e);
        }
        /// <summary>
        /// 单击选中所有搜索栏上的关键字
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.SelectAll();
        }
        #endregion

        private void timer1_Tick(object sender, EventArgs e)
        {
            remainder++;
            second=remainder%60;
            minute=remainder/60;
            hour=minute/60;



            timeLabel.Text = "上网时间:" + hour + "时" + minute + "分" + second + "秒" ;
        }


        /// <summary>
        /// 主窗口关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("确定退出浏览器？", "退出浏览器", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                saveTime();
                this.Dispose();
            }
            else e.Cancel = true;
        }




        /// <summary>
        /// 储存上网时间计数器
        /// </summary>
        private void saveTime()
        {
            StreamWriter sw = File.CreateText("time.dat");
            sw.WriteLine(remainder.ToString());
            sw.Close();
        }
       

       
     

       

        









        


        










    }
}
