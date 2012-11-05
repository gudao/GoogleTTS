using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json;
namespace siri
{
    public partial class Form1 : Form
    {
        BackgroundWorker worker = new BackgroundWorker();
        private StringBuilder sbResult = new StringBuilder();
        public Form1()
        {
            InitializeComponent();
            btStop.Enabled = false;
            worker.WorkerReportsProgress = true;
            worker.WorkerSupportsCancellation = true;
            worker.DoWork += new DoWorkEventHandler(DoFor);
            worker.ProgressChanged += new ProgressChangedEventHandler(ChangeFor);
            worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(CompletedFor);
        }

        private void DoFor(object sender, DoWorkEventArgs e)
        {
            
            bool isEnglish = rbEnglish.Checked;
            string rate = tbHz.Text.Trim();

            int postLength = 100 * 1024;
            byte[] postData = File.ReadAllBytes(e.Argument.ToString());
            int count = postData.Length / postLength;
            int yu = postData.Length % postLength;
            
            for (int i = 0; i < count; i++)
            {
                byte[] temp = new byte[postLength];
                Array.Copy(postData, i * postLength, temp, 0, postLength);
                ChangeResult rs = new ChangeResult();
                rs.Res=convertFlac(temp, rate, isEnglish);
                rs.Pro=i + "/" + count;
                worker.ReportProgress(0, rs);
                if (worker.CancellationPending)
                { break; }
            }
            if (yu > 0&&!worker.CancellationPending)
            {
                byte[] temp = new byte[yu];
                Array.Copy(postData, count * postLength, temp, 0, yu);
                ChangeResult rs = new ChangeResult();
                rs.Res = convertFlac(temp, rate, isEnglish);
                rs.Pro = "完成！";
                worker.ReportProgress(0, rs);
            }
            if (worker.CancellationPending)
            {
                worker.ReportProgress(0, new ChangeResult() {  Pro="终止！",Res=""});
            }
            
        }
        public void ChangeFor(object sender, ProgressChangedEventArgs e)
        {
           ChangeResult res=  e.UserState as ChangeResult;
           if (res.Res != "")
           {
               tbResult.Items.Add(res.Res);
               sbResult.Append(res.Res);
           }
           lbpro.Text = res.Pro;

        }
        public void CompletedFor(object sender, RunWorkerCompletedEventArgs e)
        {
            btSend.Text = "开始识别";
            btSend.Enabled = true;
            
        }


        private void btBowser_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tbFilePath.Text = ofd.FileName;
            }
        }

        private void btSend_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbFilePath.Text.Trim()) && !string.IsNullOrEmpty(tbHz.Text.Trim()))
            {
                if (!File.Exists(tbFilePath.Text.Trim()))
                    return;

                lbpro.Text = "0/0";
                btSend.Text = "识别中...";
                btSend.Enabled = false;
                btStop.Enabled = true;
                worker.RunWorkerAsync(tbFilePath.Text.Trim());
            }
        }

        private string convertFlac(byte[] postData,string rate,bool isEnglish)
        {
            try
            {
                string url = "http://www.google.com/speech-api/v1/recognize?xjerr=1&client=chromium&lang=en-US&maxresults=1";
                if (!isEnglish) url = "http://www.google.com/speech-api/v1/recognize?xjerr=1&client=chromium&lang=zh-CN&maxresults=1";
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
                req.ServicePoint.Expect100Continue = false;
                req.Method = "POST";
                req.KeepAlive = true;
                req.UserAgent = "adks";
                //req.Timeout = 400000;
                req.ContentType = "audio/x-flac; rate=" + rate;
                Stream reqStream = req.GetRequestStream();
                reqStream.Write(postData, 0, postData.Length);
                reqStream.Close();

                HttpWebResponse rsp = (HttpWebResponse)req.GetResponse();
                Encoding encoding = Encoding.GetEncoding(rsp.CharacterSet);
                reqStream = rsp.GetResponseStream();
                StreamReader reader = new StreamReader(reqStream, encoding);
                string jsonresult = reader.ReadToEnd();

                GoogleResponse objResult =
               JsonConvert.DeserializeObject<GoogleResponse>(jsonresult);
                if (objResult.status == 0 && objResult.hypotheses.Length > 0)
                {
                    return objResult.hypotheses[0].utterance;
                }
                else
                {
                    return "";
                }
            }
            catch (Exception ee)
            {
                return "服务器错误！请查看google是否能够正常访问！" + ee;
            }
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            worker.CancelAsync();
            btStop.Enabled = false;
        }

        private void btOutput_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                sfd.RestoreDirectory = true;
                sfd.Filter = "*.txt|*.txt|所有文件(*.*)|*.*";
                System.IO.File.WriteAllText(sfd.FileName, sbResult.ToString());
                sbResult.Clear();
                tbResult.Items.Clear();
            }
        }
    }

    public class ChangeResult
    {
        public string Res { get; set; }
        public string Pro { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public class GoogleHypothesa
    {
        [JsonProperty]
        public string utterance { get; set; }

        [JsonProperty]
        public double confidence { get; set; }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public class GoogleResponse
    {
        [JsonProperty]
        public int status { get; set; }
        [JsonProperty]
        public string id { get; set; }
        [JsonProperty]
        public GoogleHypothesa[] hypotheses { get; set; }
    }
}
