namespace BilKollen
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.welcomeDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.welcomeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.welcomeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.welcomeDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.welcomeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.welcomeBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(235, 4);
            this.textBox1.MaxLength = 6;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(465, 98);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(9, 122);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(691, 228);
            this.listBox1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(431, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Elias Tano - Uppgifter hämtade från www.biluppgifter.se";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // button2
            // 
            this.button2.Image = global::BilKollen.Properties.Resources.icons8_save_as_48;
            this.button2.Location = new System.Drawing.Point(706, 122);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(68, 52);
            this.button2.TabIndex = 7;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.Image = global::BilKollen.Properties.Resources.Capture1;
            this.label1.Location = new System.Drawing.Point(186, -11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 128);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BilKollen.Properties.Resources.fe9c16f7_ca46_4128_8162_4829ca1c89a3;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-16, -58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 160);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Image = global::BilKollen.Properties.Resources.Actions_arrow_right_icon;
            this.button1.Location = new System.Drawing.Point(706, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 98);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Text File |*.txt";
            this.saveFileDialog1.Title = "Spara till fil";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // welcomeDataBindingSource
            // 
            this.welcomeDataBindingSource.DataSource = typeof(BilKollen.WelcomeData);
            // 
            // welcomeBindingSource
            // 
            this.welcomeBindingSource.DataSource = typeof(BilKollen.Welcome);
            // 
            // welcomeBindingSource1
            // 
            this.welcomeBindingSource1.DataSource = typeof(BilKollen.Welcome);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 110);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "BilKollen v1.1";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.welcomeDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.welcomeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.welcomeBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.BindingSource welcomeDataBindingSource;
        private System.Windows.Forms.BindingSource welcomeBindingSource;
        private System.Windows.Forms.BindingSource welcomeBindingSource1;
        private System.Windows.Forms.Label label2;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

