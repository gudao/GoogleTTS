namespace siri
{
    partial class Form1
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
            this.btBowser = new System.Windows.Forms.Button();
            this.tbFilePath = new System.Windows.Forms.TextBox();
            this.btSend = new System.Windows.Forms.Button();
            this.rbEnglish = new System.Windows.Forms.RadioButton();
            this.rbChinese = new System.Windows.Forms.RadioButton();
            this.tbHz = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbResult = new System.Windows.Forms.ListBox();
            this.lbpro = new System.Windows.Forms.Label();
            this.btStop = new System.Windows.Forms.Button();
            this.btOutput = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btBowser
            // 
            this.btBowser.Location = new System.Drawing.Point(390, 14);
            this.btBowser.Name = "btBowser";
            this.btBowser.Size = new System.Drawing.Size(62, 23);
            this.btBowser.TabIndex = 1;
            this.btBowser.Text = "浏览";
            this.btBowser.UseVisualStyleBackColor = true;
            this.btBowser.Click += new System.EventHandler(this.btBowser_Click);
            // 
            // tbFilePath
            // 
            this.tbFilePath.Location = new System.Drawing.Point(101, 16);
            this.tbFilePath.Name = "tbFilePath";
            this.tbFilePath.Size = new System.Drawing.Size(283, 21);
            this.tbFilePath.TabIndex = 0;
            // 
            // btSend
            // 
            this.btSend.Location = new System.Drawing.Point(309, 85);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(75, 23);
            this.btSend.TabIndex = 5;
            this.btSend.Text = "开始识别";
            this.btSend.UseVisualStyleBackColor = true;
            this.btSend.Click += new System.EventHandler(this.btSend_Click);
            // 
            // rbEnglish
            // 
            this.rbEnglish.AutoSize = true;
            this.rbEnglish.Checked = true;
            this.rbEnglish.Location = new System.Drawing.Point(101, 58);
            this.rbEnglish.Name = "rbEnglish";
            this.rbEnglish.Size = new System.Drawing.Size(47, 16);
            this.rbEnglish.TabIndex = 2;
            this.rbEnglish.TabStop = true;
            this.rbEnglish.Text = "英文";
            this.rbEnglish.UseVisualStyleBackColor = true;
            // 
            // rbChinese
            // 
            this.rbChinese.AutoSize = true;
            this.rbChinese.Location = new System.Drawing.Point(154, 58);
            this.rbChinese.Name = "rbChinese";
            this.rbChinese.Size = new System.Drawing.Size(47, 16);
            this.rbChinese.TabIndex = 3;
            this.rbChinese.Text = "中文";
            this.rbChinese.UseVisualStyleBackColor = true;
            // 
            // tbHz
            // 
            this.tbHz.Location = new System.Drawing.Point(101, 93);
            this.tbHz.Name = "tbHz";
            this.tbHz.Size = new System.Drawing.Size(75, 21);
            this.tbHz.TabIndex = 4;
            this.tbHz.Text = "16000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "语  言：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "采样率：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "（默认16000HZ）";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "文  件：";
            // 
            // tbResult
            // 
            this.tbResult.FormattingEnabled = true;
            this.tbResult.ItemHeight = 12;
            this.tbResult.Location = new System.Drawing.Point(45, 136);
            this.tbResult.Name = "tbResult";
            this.tbResult.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.tbResult.Size = new System.Drawing.Size(407, 280);
            this.tbResult.TabIndex = 11;
            // 
            // lbpro
            // 
            this.lbpro.AutoSize = true;
            this.lbpro.Location = new System.Drawing.Point(45, 423);
            this.lbpro.Name = "lbpro";
            this.lbpro.Size = new System.Drawing.Size(23, 12);
            this.lbpro.TabIndex = 12;
            this.lbpro.Text = "0/0";
            // 
            // btStop
            // 
            this.btStop.Location = new System.Drawing.Point(390, 85);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(62, 23);
            this.btStop.TabIndex = 13;
            this.btStop.Text = "停止";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // btOutput
            // 
            this.btOutput.Location = new System.Drawing.Point(376, 423);
            this.btOutput.Name = "btOutput";
            this.btOutput.Size = new System.Drawing.Size(75, 23);
            this.btOutput.TabIndex = 14;
            this.btOutput.Text = "导出全文";
            this.btOutput.UseVisualStyleBackColor = true;
            this.btOutput.Click += new System.EventHandler(this.btOutput_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 479);
            this.Controls.Add(this.btOutput);
            this.Controls.Add(this.btStop);
            this.Controls.Add(this.lbpro);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbHz);
            this.Controls.Add(this.rbChinese);
            this.Controls.Add(this.rbEnglish);
            this.Controls.Add(this.btSend);
            this.Controls.Add(this.tbFilePath);
            this.Controls.Add(this.btBowser);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "声音识别";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btBowser;
        private System.Windows.Forms.TextBox tbFilePath;
        private System.Windows.Forms.Button btSend;
        private System.Windows.Forms.RadioButton rbEnglish;
        private System.Windows.Forms.RadioButton rbChinese;
        private System.Windows.Forms.TextBox tbHz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox tbResult;
        private System.Windows.Forms.Label lbpro;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.Button btOutput;
    }
}

