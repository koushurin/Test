using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Threading;
using System.Drawing;

namespace CameraTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var thread = new Thread(Process);
            thread.Start();
        }

        void Process()
        {
            while (true)
            {
                if (!GetData())
                    break;
            }
        }

        const string _ipAddress = "http://192.168.102.117/?action=snapshot";

        bool GetData()
        {
            WebClient webClient = new WebClient();
            var data = webClient.DownloadData(_ipAddress);
            using (var ms = new MemoryStream(data))
            {
                var bitmap = new Bitmap(ms);
                try
                {
                    picPhoto.Invoke(new EventHandler((obj, args) => picPhoto.Image = bitmap));
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
            return true;
        }

        #region Text Flow


        List<CommentInfo> _comment = new List<CommentInfo>();

        void DrawText(string text)
        {

        }

        #endregion

        private void Form1_Resize(object sender, EventArgs e)
        {
            pnLeft.Size = new Size(this.Size.Width - 656, pnLeft.Size.Height);
        }

        FontFamily _fmBlack = new System.Drawing.FontFamily("黑体");
        Font _fBlack = new System.Drawing.Font("黑体", 20);
        private void pnLeft_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            var pen = new Pen(Color.Blue);
            g.DrawString("TestString", _fBlack, pen.Brush, 0, 0);
        }
    }
}

class CommentInfo
{
    public int Left { get; set; }
    public int Up { get; set; }
    public string Text { get; set; }
    public Color Color { get; set; }
}