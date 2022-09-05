
namespace Labb2_Azure_AnalyseImage
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.downloadBtn = new System.Windows.Forms.Button();
            this.localRadioBtn = new System.Windows.Forms.RadioButton();
            this.urlRadioBtn = new System.Windows.Forms.RadioButton();
            this.localPictureTextbox = new System.Windows.Forms.TextBox();
            this.browseBtn = new System.Windows.Forms.Button();
            this.analyseBtn = new System.Windows.Forms.Button();
            this.urlTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.beforeAnalyse = new System.Windows.Forms.PictureBox();
            this.afterAnalyse = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.beforeAnalyse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.afterAnalyse)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.downloadBtn);
            this.groupBox1.Controls.Add(this.localRadioBtn);
            this.groupBox1.Controls.Add(this.urlRadioBtn);
            this.groupBox1.Controls.Add(this.localPictureTextbox);
            this.groupBox1.Controls.Add(this.browseBtn);
            this.groupBox1.Controls.Add(this.analyseBtn);
            this.groupBox1.Controls.Add(this.urlTextbox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1065, 106);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // downloadBtn
            // 
            this.downloadBtn.Location = new System.Drawing.Point(214, 15);
            this.downloadBtn.Name = "downloadBtn";
            this.downloadBtn.Size = new System.Drawing.Size(75, 23);
            this.downloadBtn.TabIndex = 9;
            this.downloadBtn.Text = "Download";
            this.downloadBtn.UseVisualStyleBackColor = true;
            this.downloadBtn.Click += new System.EventHandler(this.downloadBtn_Click);
            // 
            // localRadioBtn
            // 
            this.localRadioBtn.AutoSize = true;
            this.localRadioBtn.Location = new System.Drawing.Point(80, 81);
            this.localRadioBtn.Name = "localRadioBtn";
            this.localRadioBtn.Size = new System.Drawing.Size(50, 19);
            this.localRadioBtn.TabIndex = 8;
            this.localRadioBtn.TabStop = true;
            this.localRadioBtn.Text = "local";
            this.localRadioBtn.UseVisualStyleBackColor = true;
            // 
            // urlRadioBtn
            // 
            this.urlRadioBtn.AutoSize = true;
            this.urlRadioBtn.Location = new System.Drawing.Point(15, 81);
            this.urlRadioBtn.Name = "urlRadioBtn";
            this.urlRadioBtn.Size = new System.Drawing.Size(46, 19);
            this.urlRadioBtn.TabIndex = 7;
            this.urlRadioBtn.TabStop = true;
            this.urlRadioBtn.Text = "URL";
            this.urlRadioBtn.UseVisualStyleBackColor = true;
            // 
            // localPictureTextbox
            // 
            this.localPictureTextbox.Location = new System.Drawing.Point(80, 54);
            this.localPictureTextbox.Name = "localPictureTextbox";
            this.localPictureTextbox.Size = new System.Drawing.Size(128, 23);
            this.localPictureTextbox.TabIndex = 6;
            // 
            // browseBtn
            // 
            this.browseBtn.Location = new System.Drawing.Point(214, 54);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.Size = new System.Drawing.Size(75, 23);
            this.browseBtn.TabIndex = 5;
            this.browseBtn.Text = "Browse";
            this.browseBtn.UseVisualStyleBackColor = true;
            this.browseBtn.Click += new System.EventHandler(this.browseBtn_Click);
            // 
            // analyseBtn
            // 
            this.analyseBtn.Location = new System.Drawing.Point(498, 77);
            this.analyseBtn.Name = "analyseBtn";
            this.analyseBtn.Size = new System.Drawing.Size(75, 23);
            this.analyseBtn.TabIndex = 4;
            this.analyseBtn.Text = "Analyse";
            this.analyseBtn.UseVisualStyleBackColor = true;
            this.analyseBtn.Click += new System.EventHandler(this.analyseBtn_Click);
            // 
            // urlTextbox
            // 
            this.urlTextbox.Location = new System.Drawing.Point(52, 16);
            this.urlTextbox.Name = "urlTextbox";
            this.urlTextbox.Size = new System.Drawing.Size(156, 23);
            this.urlTextbox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Local File:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "URL:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.beforeAnalyse);
            this.groupBox2.Location = new System.Drawing.Point(12, 124);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(532, 473);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Before Analysed";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.afterAnalyse);
            this.groupBox3.Location = new System.Drawing.Point(550, 124);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(527, 473);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Analysed Picture";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // beforeAnalyse
            // 
            this.beforeAnalyse.Location = new System.Drawing.Point(6, 22);
            this.beforeAnalyse.Name = "beforeAnalyse";
            this.beforeAnalyse.Size = new System.Drawing.Size(520, 445);
            this.beforeAnalyse.TabIndex = 0;
            this.beforeAnalyse.TabStop = false;
            // 
            // afterAnalyse
            // 
            this.afterAnalyse.Location = new System.Drawing.Point(6, 22);
            this.afterAnalyse.Name = "afterAnalyse";
            this.afterAnalyse.Size = new System.Drawing.Size(515, 445);
            this.afterAnalyse.TabIndex = 1;
            this.afterAnalyse.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 609);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.beforeAnalyse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.afterAnalyse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox urlTextbox;
        private System.Windows.Forms.TextBox localPictureTextbox;
        private System.Windows.Forms.Button browseBtn;
        private System.Windows.Forms.Button analyseBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RadioButton localRadioBtn;
        private System.Windows.Forms.RadioButton urlRadioBtn;
        private System.Windows.Forms.Button downloadBtn;
        private System.Windows.Forms.PictureBox beforeAnalyse;
        private System.Windows.Forms.PictureBox afterAnalyse;
    }
}

