namespace ProgrammerEyeResting
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.lbl_metin = new System.Windows.Forms.Label();
            this.rbaftif = new System.Windows.Forms.RadioButton();
            this.rbdeaktif = new System.Windows.Forms.RadioButton();
            this.txtdk = new System.Windows.Forms.TextBox();
            this.txtsn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_basla = new System.Windows.Forms.Button();
            this.btndurdur = new System.Windows.Forms.Button();
            this.btnsifirla = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // lbl_metin
            // 
            this.lbl_metin.AutoSize = true;
            this.lbl_metin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_metin.Location = new System.Drawing.Point(12, 9);
            this.lbl_metin.Name = "lbl_metin";
            this.lbl_metin.Size = new System.Drawing.Size(198, 25);
            this.lbl_metin.TabIndex = 0;
            this.lbl_metin.Text = "Göz egzersizi zamanı";
            // 
            // rbaftif
            // 
            this.rbaftif.AutoSize = true;
            this.rbaftif.Location = new System.Drawing.Point(1090, 63);
            this.rbaftif.Name = "rbaftif";
            this.rbaftif.Size = new System.Drawing.Size(56, 21);
            this.rbaftif.TabIndex = 4;
            this.rbaftif.Text = "Aktif";
            this.rbaftif.UseVisualStyleBackColor = true;
            this.rbaftif.CheckedChanged += new System.EventHandler(this.rbaftif_CheckedChanged);
            // 
            // rbdeaktif
            // 
            this.rbdeaktif.AutoSize = true;
            this.rbdeaktif.Checked = true;
            this.rbdeaktif.Location = new System.Drawing.Point(1170, 63);
            this.rbdeaktif.Name = "rbdeaktif";
            this.rbdeaktif.Size = new System.Drawing.Size(89, 21);
            this.rbdeaktif.TabIndex = 5;
            this.rbdeaktif.TabStop = true;
            this.rbdeaktif.Text = "Aftif Değil";
            this.rbdeaktif.UseVisualStyleBackColor = true;
            this.rbdeaktif.CheckedChanged += new System.EventHandler(this.rbdeaktif_CheckedChanged);
            // 
            // txtdk
            // 
            this.txtdk.Location = new System.Drawing.Point(1136, 111);
            this.txtdk.Name = "txtdk";
            this.txtdk.Size = new System.Drawing.Size(44, 22);
            this.txtdk.TabIndex = 6;
            this.txtdk.Text = "10";
            this.txtdk.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtsn
            // 
            this.txtsn.Location = new System.Drawing.Point(1204, 111);
            this.txtsn.Name = "txtsn";
            this.txtsn.Size = new System.Drawing.Size(44, 22);
            this.txtsn.TabIndex = 7;
            this.txtsn.Text = "00";
            this.txtsn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1070, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Periyot :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1186, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = ":";
            // 
            // btn_basla
            // 
            this.btn_basla.BackColor = System.Drawing.Color.Azure;
            this.btn_basla.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.btn_basla.Location = new System.Drawing.Point(1062, 162);
            this.btn_basla.Name = "btn_basla";
            this.btn_basla.Size = new System.Drawing.Size(92, 39);
            this.btn_basla.TabIndex = 10;
            this.btn_basla.Text = "BAŞLA";
            this.btn_basla.UseVisualStyleBackColor = false;
            this.btn_basla.Click += new System.EventHandler(this.btn_basla_Click);
            // 
            // btndurdur
            // 
            this.btndurdur.BackColor = System.Drawing.Color.Azure;
            this.btndurdur.Location = new System.Drawing.Point(1161, 162);
            this.btndurdur.Name = "btndurdur";
            this.btndurdur.Size = new System.Drawing.Size(98, 39);
            this.btndurdur.TabIndex = 11;
            this.btndurdur.Text = "DURDUR";
            this.btndurdur.UseVisualStyleBackColor = false;
            this.btndurdur.Click += new System.EventHandler(this.btndurdur_Click);
            // 
            // btnsifirla
            // 
            this.btnsifirla.BackColor = System.Drawing.Color.Azure;
            this.btnsifirla.Location = new System.Drawing.Point(1117, 216);
            this.btnsifirla.Name = "btnsifirla";
            this.btnsifirla.Size = new System.Drawing.Size(81, 39);
            this.btnsifirla.TabIndex = 12;
            this.btnsifirla.Text = "SIFIRLA";
            this.btnsifirla.UseVisualStyleBackColor = false;
            this.btnsifirla.Click += new System.EventHandler(this.btnsifirla_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 60;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl.Location = new System.Drawing.Point(12, 48);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(53, 20);
            this.lbl.TabIndex = 16;
            this.lbl.Text = "label3";
            // 
            // button2
            // 
            this.button2.Image = global::ProgrammerEyeResting.Properties.Resources._1493262703_arrow_left;
            this.button2.Location = new System.Drawing.Point(17, 235);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 71);
            this.button2.TabIndex = 15;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Image = global::ProgrammerEyeResting.Properties.Resources._1493262736_arrow_right;
            this.button1.Location = new System.Drawing.Point(933, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 71);
            this.button1.TabIndex = 14;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightCyan;
            this.button3.Location = new System.Drawing.Point(1062, 271);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(197, 35);
            this.button3.TabIndex = 17;
            this.button3.Text = "GİZLE";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1070, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Alarm :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1345, 318);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnsifirla);
            this.Controls.Add(this.btndurdur);
            this.Controls.Add(this.btn_basla);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtsn);
            this.Controls.Add(this.txtdk);
            this.Controls.Add(this.rbdeaktif);
            this.Controls.Add(this.rbaftif);
            this.Controls.Add(this.lbl_metin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "GözEgzersiz";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label lbl_metin;
        private System.Windows.Forms.RadioButton rbaftif;
        private System.Windows.Forms.RadioButton rbdeaktif;
        private System.Windows.Forms.TextBox txtdk;
        private System.Windows.Forms.TextBox txtsn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_basla;
        private System.Windows.Forms.Button btndurdur;
        private System.Windows.Forms.Button btnsifirla;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
    }
}

