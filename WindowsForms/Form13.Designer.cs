
namespace WindowsForms
{
    partial class Form13
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.teknik = new System.Windows.Forms.TabPage();
            this.detay = new System.Windows.Forms.TabPage();
            this.yorum = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.teknik.SuspendLayout();
            this.detay.SuspendLayout();
            this.yorum.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.teknik);
            this.tabControl1.Controls.Add(this.detay);
            this.tabControl1.Controls.Add(this.yorum);
            this.tabControl1.Location = new System.Drawing.Point(223, 131);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(395, 190);
            this.tabControl1.TabIndex = 0;
            // 
            // teknik
            // 
            this.teknik.Controls.Add(this.label2);
            this.teknik.Location = new System.Drawing.Point(4, 25);
            this.teknik.Name = "teknik";
            this.teknik.Padding = new System.Windows.Forms.Padding(3);
            this.teknik.Size = new System.Drawing.Size(387, 161);
            this.teknik.TabIndex = 0;
            this.teknik.Text = "Teknik Özellikler";
            this.teknik.UseVisualStyleBackColor = true;
            // 
            // detay
            // 
            this.detay.Controls.Add(this.label1);
            this.detay.Location = new System.Drawing.Point(4, 25);
            this.detay.Name = "detay";
            this.detay.Padding = new System.Windows.Forms.Padding(3);
            this.detay.Size = new System.Drawing.Size(387, 161);
            this.detay.TabIndex = 1;
            this.detay.Text = "Ürün Detay";
            this.detay.UseVisualStyleBackColor = true;
            // 
            // yorum
            // 
            this.yorum.Controls.Add(this.button1);
            this.yorum.Controls.Add(this.richTextBox1);
            this.yorum.Location = new System.Drawing.Point(4, 25);
            this.yorum.Name = "yorum";
            this.yorum.Padding = new System.Windows.Forms.Padding(3);
            this.yorum.Size = new System.Drawing.Size(387, 161);
            this.yorum.TabIndex = 2;
            this.yorum.Text = "Ürüne Yorum Yap";
            this.yorum.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(6, 6);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(375, 96);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 46);
            this.button1.TabIndex = 1;
            this.button1.Text = "Yorumu Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "label2";
            // 
            // Form13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form13";
            this.Text = "Tab sistemi";
            this.tabControl1.ResumeLayout(false);
            this.teknik.ResumeLayout(false);
            this.teknik.PerformLayout();
            this.detay.ResumeLayout(false);
            this.detay.PerformLayout();
            this.yorum.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage teknik;
        private System.Windows.Forms.TabPage detay;
        private System.Windows.Forms.TabPage yorum;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}