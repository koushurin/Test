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
using System.IO.Ports;


namespace CameraTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SerialPort _serialPort;

        private void Form1_Load(object sender, EventArgs e)
        { 
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
            this.UpdateStyles();

            _bufferedContext = BufferedGraphicsManager.Current;
            _bufferedGraphics = _bufferedContext.Allocate(pnLeft.CreateGraphics(), pnLeft.DisplayRectangle);
            _cameraUiGraphics = _bufferedContext.Allocate(picPhoto.CreateGraphics(), picPhoto.DisplayRectangle);

            lblInfo.BackColor = _greenBgColor;
            lblInfo.Parent = picPhoto;

            lblLog.BackColor = _greenBgColor;
            lblLog.Parent = picPhoto;
            lblLog.Text = string.Empty;

            InitSerailPort();

            WindowState = FormWindowState.Maximized;
            
            var thread = new Thread(Process);
            thread.Start();
            var textThread = new Thread(TextProcess);
            textThread.Start();
        }

        void InitSerailPort()
        {
            _serialPort = new SerialPort("COM3");
            _serialPort.BaudRate = 9600;
            try
            {
                _serialPort.Open();
            }
            catch
            {
                _serialPort = null;
            }
        }

        private BufferedGraphicsContext _bufferedContext;
        private BufferedGraphics _bufferedGraphics;
        private BufferedGraphics _cameraUiGraphics;

        void Process()
        {
            while (true)
            {
                if (!GetData())
                    break;
            }
        }

        const string _ipAddress = "http://192.168.102.118/?action=snapshot";

        bool GetData()
        {
            try
            {
                WebClient webClient = new WebClient();
                var data = webClient.DownloadData(_ipAddress);
                using (var ms = new MemoryStream(data))
                {
                    var bitmap = new Bitmap(ms);
                    picPhoto.Invoke(new EventHandler((obj, args) => picPhoto.Image = bitmap));
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        #region Text Flow

        object _commentsSyncRoot = new object();
        CommentInfo[] _comments = new CommentInfo[100];
        List<CommentLogInfo> _commentLog = new List<CommentLogInfo>();
        StringBuilder _logBuilder = new StringBuilder();
        //int _logCount = 0;

        void SendComment(string text, CommentType type, bool sentBySelf)
        {
            var info = new CommentInfo
            {
                Left = pnLeft.Width,
                Text = text,
                Color = GetColor(type),
                SentBySelf = sentBySelf
            };
            lock (_commentsSyncRoot)
            {
                for (int i = 0; i < _comments.Length; i++)
                {
                    if (_comments[i] == null)
                    {
                        _comments[i] = info;
                        info.Up = i * (TextSize + 5);
                        break;
                    }
                }
                var logInfo = new CommentLogInfo
                    {
                        Text = text,
                        Time = DateTime.Now,
                        Type = type
                    };
                _commentLog.Add(logInfo);
                try
                {
                    //string logText = string.Format("{0} [{1}] 「{2}」\n", logInfo.Time, GetSymbol(logInfo.Type), logInfo.Text);
                    //_logBuilder.Insert(0, logText);
                    //_logBuilder.
                    _logBuilder.Clear();
                    for (int i = _commentLog.Count - 1; i >= Math.Max(0, _commentLog.Count - 20); i--)
                    {
                        _logBuilder.Append(_commentLog[i].Time.ToString()).Append(" ");
                        _logBuilder.Append("[").Append(_commentLog[i].Type.ToString()).Append("] ");
                        _logBuilder.Append("「").Append(_commentLog[i].Text.ToString()).Append("」\n");
                    }
                    string logText = _logBuilder.ToString();
                        //lblLog.Text += string.Format("{0} [{1}] 「{2}」\n", _commentLog[i].Time, GetSymbol(_commentLog[i].Type), _commentLog[i].Text);
                    lblLog.Invoke(new EventHandler((sender, args) =>
                        {
                            lblLog.Text = logText;
                        }));
                }
                catch { }
            }

        }

        string GetSymbol(CommentType type)
        {
            switch (type)
            {
                case CommentType.Good:
                    return "↑";
                case CommentType.Bad:
                    return "↓";
                default:
                    return "-";
            }
        }

        CommentLogInfo[] _othersComments = new CommentLogInfo[]
        {
            new CommentLogInfo{ Text = "これは推し進めて議論すべき", Type = CommentType.Good},
            new CommentLogInfo{ Text = "その発想は無かった！", Type = CommentType.Good},
            new CommentLogInfo{ Text = "必要な法案だと思う，問題は財源", Type = CommentType.Good},
            new CommentLogInfo{ Text = "景気回復につながりそう", Type = CommentType.Good},

            new CommentLogInfo{ Text = "具体的な達成方法がイメージできない", Type = CommentType.Bad},
            new CommentLogInfo{ Text = "財源はどうなっているのか，不透明です", Type = CommentType.Bad},
            new CommentLogInfo{ Text = "質問への解答になってない", Type = CommentType.Bad},
            new CommentLogInfo{ Text = "目的がはっきりしていない", Type = CommentType.Bad},

            new CommentLogInfo{ Text = "なるほど分からん", Type = CommentType.Neutral},
            new CommentLogInfo{ Text = "www", Type = CommentType.Neutral},
            new CommentLogInfo{ Text = "費用対効果はどうなっているのですか", Type = CommentType.Neutral},
            new CommentLogInfo{ Text = "ここに病院を建てましょう", Type = CommentType.Neutral},
            new CommentLogInfo{ Text = "ね，簡単でしょう？", Type = CommentType.Neutral},
            new CommentLogInfo{ Text = "利点と欠点のまとめが欲しいな", Type = CommentType.Neutral},
            new CommentLogInfo{ Text = "俺得", Type = CommentType.Neutral},
            new CommentLogInfo{ Text = "話が長い", Type = CommentType.Neutral},
            new CommentLogInfo{ Text = "野次うるさいなあ", Type = CommentType.Neutral},
            new CommentLogInfo{ Text = "高齢者だけでなく，子供に対しても優しい案を考えてほしい", Type = CommentType.Neutral},
            new CommentLogInfo{ Text = "それってもっと簡単にできないの？", Type = CommentType.Neutral},
            new CommentLogInfo{ Text = "今必要であっても，5年後，10年後にはどうなのか？将来の見通しを立てて考えるべき", Type = CommentType.Neutral},
        };
        
        Color GetColor(CommentType type)
        {
            switch (type)
            {
                case CommentType.Good:
                    return Color.Blue;
                case CommentType.Bad:
                    return Color.Red;
                default:
                    return Color.Black;
            }
        }

        const int FPS = 60;
        const int TextSpeed = 100;
        const int TextSize = 50;

        int _count = 0;

        void TextProcess()
        {
            Random rand = new Random();
            try
            {
                while (true)
                {
                    Thread.Sleep(1000 / FPS);
                    //pnLeft.Invoke(new EventHandler((obj, args) => pnLeft.Refresh()));
                    DrawToBuffer();
                    lock (_commentsSyncRoot)
                    {
                        for (int i = 0; i < _comments.Length; i++)
                        {
                            if (_comments[i] != null)
                            {
                                if (_comments[i].Left < GetTextWidth(_comments[i]))
                                    _comments[i] = null;
                                else
                                    _comments[i].Left -= TextSpeed * FPS / 1000;
                            }
                        }
                    }

                    if (++_count > 40)
                    {
                        _count = 0;
                        var info = _othersComments[rand.Next(0, _othersComments.Length)];
                        SendComment(info.Text, info.Type, false);
                    }
                }
            }
            catch { }
        }

        FontFamily _fmBlack = new System.Drawing.FontFamily("黑体");
        Font _fBlack = new System.Drawing.Font("黑体", TextSize);

        void DrawToBuffer()
        {
            var g = _bufferedGraphics.Graphics;
            g.Clear(pnLeft.BackColor);
            lock (_commentsSyncRoot)
            {
                foreach (var info in _comments)
                {
                    if (info != null)
                    {
                        var pen = new Pen(info.Color);
                        g.DrawString(info.Text, _fBlack, pen.Brush, info.Left, info.Up);
                        if (info.Length == 0)
                        {
                            var m = g.MeasureString(info.Text, _fBlack);
                            info.Length = (int)m.Width;
                            info.Height = (int)m.Height;
                        }
                        if (info.SentBySelf)
                            g.DrawRectangle(pen, new Rectangle(info.Left, info.Up, info.Length, info.Height));
                    }
                }
            }
            _bufferedGraphics.Render();
        }

        int GetTextWidth(CommentInfo info)
        {
            return -info.Length;
        }

        #endregion

        private void Form1_Resize(object sender, EventArgs e)
        {
            pnLeft.Size = new Size(this.Size.Width - 832, pnLeft.Size.Height);
            _bufferedGraphics = _bufferedContext.Allocate(pnLeft.CreateGraphics(), pnLeft.DisplayRectangle);
            lblLogo.Location = new Point(pnLogo.Width / 2 - lblLogo.Size.Width / 2,
                pnLogo.Height / 2 - lblLogo.Size.Height / 2);
        }

        private void pnLeft_Paint(object sender, PaintEventArgs e)
        {
            _bufferedGraphics.Render(e.Graphics);
        }

        //private void btnSubmit_Click(object sender, EventArgs e)
        //{
        //    CommentType type = CommentType.Neutral;
        //    if (rbGood.Checked)
        //        type = CommentType.Good;
        //    else if (rbBad.Checked)
        //        type = CommentType.Bad;
        //    SendComment(tbText.Text, type);
        //}

        //private void cbComment_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    tbText.Text = cbComment.Text;
        //}

        //private void cbPeople_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    switch (cbPeople.SelectedIndex)
        //    {
        //        case 0:
        //            tbInfo.Text = tbInfoA.Text;
        //            break;
        //        case 1:
        //            tbInfo.Text = tbInfoB.Text;
        //            break;
        //    }
        //}

        //private void btnBack_Click(object sender, EventArgs e)
        //{
        //    cbPeople.SelectedIndex = -1;
        //    tbInfo.Text = "";
        //}

        Color _greenBgColor = Color.FromArgb(160, Color.Green);

        

        private void picPhoto_Paint(object sender, PaintEventArgs e)
        {
            if (lblInfo.Visible)
            {
                var g = e.Graphics;
                var rect = new Rectangle(300, 100, 150, 200);
                var brush = new SolidBrush(_greenBgColor);
                g.DrawRectangle(new Pen(brush, 5), rect);
                g.DrawLine(new Pen(brush, 5), new Point(lblInfo.Location.X, lblInfo.Location.Y + lblInfo.Size.Height + 20),
                    new Point(lblInfo.Location.X + lblInfo.Size.Width, lblInfo.Location.Y + lblInfo.Size.Height + 20));
                g.DrawLine(new Pen(brush, 5), new Point(rect.Right, rect.Bottom),
                    new Point(lblInfo.Location.X, lblInfo.Location.Y + lblInfo.Size.Height + 20));
            }
        }

        private void btnInfoPanel_Click(object sender, EventArgs e)
        {
            lblInfo.Visible = !lblInfo.Visible;
            pnComment.Visible = false;
            lblLog.Visible = false;
        }

        private void btnCmtPanel_Click(object sender, EventArgs e)
        {
            lblInfo.Visible = false;
            pnComment.Visible = !pnComment.Visible;
            lblLog.Visible = false;
        }

        private void btnCmtLogPanel_Click(object sender, EventArgs e)
        {
            lblInfo.Visible = false;
            pnComment.Visible = false;
            lblLog.Visible = !lblLog.Visible;
        }

        CommentType _commentType = CommentType.Good;

        void ResetCommentButtons()
        {
            btnGood.FlatAppearance.BorderSize = 1;
            btnBad.FlatAppearance.BorderSize = 1;
            btnNeutral.FlatAppearance.BorderSize = 1;
        }

        private void btnNeutral_Click(object sender, EventArgs e)
        {
            SelectNeutral();
        }

        void SelectNeutral()
        {
            _commentType = CommentType.Neutral;
            ResetCommentButtons();
            btnNeutral.FlatAppearance.BorderSize = 3;
        }

        private void btnGood_Click(object sender, EventArgs e)
        {
            SelectGood();
        }

        void SelectGood()
        {
            _commentType = CommentType.Good;
            ResetCommentButtons();
            btnGood.FlatAppearance.BorderSize = 3;
        }

        private void btnBad_Click(object sender, EventArgs e)
        {
            SelectBad();
        }

        void SelectBad()
        {
            _commentType = CommentType.Bad;
            ResetCommentButtons();
            btnBad.FlatAppearance.BorderSize = 3;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string text = cbComment.Text;
            if (!string.IsNullOrEmpty(text))
            {
                SendComment(text, _commentType, true);
                if (!SendSerial())
                {
                    InitSerailPort();
                    SendSerial();
                }
            }
            //cbComment.SelectedIndex = -1;
            //cbComment.Text = "";
        }

        bool SendSerial()
        {
            try
            {
                if (_commentType == CommentType.Good)
                    _serialPort.Write("p");
                else if (_commentType == CommentType.Bad)
                    _serialPort.Write("n");
            }
            catch
            {
                return false;
            }
            return true;
        }

        private void cbComment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbComment.SelectedIndex == 0)
                SelectGood();
            else if (cbComment.SelectedIndex == 1)
                SelectBad();
        }

        private void cbComment_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSubmit.PerformClick();
        }
    }

    class CommentInfo
    {
        public int Left { get; set; }
        public int Up { get; set; }
        public string Text { get; set; }
        public Color Color { get; set; }
        public int Length { get; set; }
        public int Height { get; set; }
        public bool SentBySelf { get; set; }
    }

    public enum CommentType
    {
        Neutral,
        Good,
        Bad,
    }

    class CommentLogInfo
    {
        public string Text { get; set; }
        public DateTime Time { get; set; }
        public CommentType Type { get; set; }
    }
}
