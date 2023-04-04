namespace bilgiyarısması
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            richTextBox1 = new RichTextBox();
            btna = new Button();
            btnd = new Button();
            btnb = new Button();
            btnc = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblsoruno = new Label();
            lbldoru = new Label();
            lblyanlıs = new Label();
            btnsonra = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            panel1 = new Panel();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(10, 74);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(496, 128);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // btna
            // 
            btna.Location = new Point(43, 209);
            btna.Name = "btna";
            btna.Size = new Size(195, 29);
            btna.TabIndex = 1;
            btna.Text = "A";
            btna.UseVisualStyleBackColor = true;
            btna.Click += btna_Click;
            // 
            // btnd
            // 
            btnd.Location = new Point(271, 253);
            btnd.Name = "btnd";
            btnd.Size = new Size(195, 29);
            btnd.TabIndex = 2;
            btnd.Text = "D";
            btnd.UseVisualStyleBackColor = true;
            btnd.Click += btnd_Click;
            // 
            // btnb
            // 
            btnb.Location = new Point(271, 209);
            btnb.Name = "btnb";
            btnb.Size = new Size(195, 29);
            btnb.TabIndex = 3;
            btnb.Text = "B";
            btnb.UseVisualStyleBackColor = true;
            btnb.Click += btnb_Click;
            // 
            // btnc
            // 
            btnc.Location = new Point(43, 253);
            btnc.Name = "btnc";
            btnc.Size = new Size(195, 29);
            btnc.TabIndex = 4;
            btnc.Text = "C";
            btnc.UseVisualStyleBackColor = true;
            btnc.Click += btnc_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(531, 77);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 5;
            label1.Text = "SORU NO:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(531, 105);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 6;
            label2.Text = "DOĞRU:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(531, 130);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 7;
            label3.Text = "YANLIŞ:";
            // 
            // lblsoruno
            // 
            lblsoruno.AutoSize = true;
            lblsoruno.Location = new Point(599, 77);
            lblsoruno.Name = "lblsoruno";
            lblsoruno.Size = new Size(14, 15);
            lblsoruno.TabIndex = 8;
            lblsoruno.Text = "0";
            // 
            // lbldoru
            // 
            lbldoru.AutoSize = true;
            lbldoru.Location = new Point(599, 105);
            lbldoru.Name = "lbldoru";
            lbldoru.Size = new Size(14, 15);
            lbldoru.TabIndex = 9;
            lbldoru.Text = "0";
            // 
            // lblyanlıs
            // 
            lblyanlıs.AutoSize = true;
            lblyanlıs.Location = new Point(599, 130);
            lblyanlıs.Name = "lblyanlıs";
            lblyanlıs.Size = new Size(14, 15);
            lblyanlıs.TabIndex = 10;
            lblyanlıs.Text = "0";
            // 
            // btnsonra
            // 
            btnsonra.Location = new Point(537, 164);
            btnsonra.Name = "btnsonra";
            btnsonra.Size = new Size(82, 24);
            btnsonra.TabIndex = 11;
            btnsonra.Text = "SONRAKİ";
            btnsonra.UseVisualStyleBackColor = true;
            btnsonra.Click += btnsonra_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(519, 201);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(62, 56);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(591, 201);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(62, 56);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(537, 276);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 14;
            label4.Text = "label4";
            label4.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(599, 276);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 15;
            label5.Text = "label5";
            label5.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(564, 230);
            label6.Name = "label6";
            label6.Size = new Size(0, 15);
            label6.TabIndex = 16;
            // 
            // panel1
            // 
            panel1.Controls.Add(label7);
            panel1.Location = new Point(28, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(467, 48);
            panel1.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Candara", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(128, 9);
            label7.Name = "label7";
            label7.Size = new Size(182, 29);
            label7.TabIndex = 0;
            label7.Text = "BİLGİ YARIŞMASI";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(658, 287);
            Controls.Add(panel1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnsonra);
            Controls.Add(lblyanlıs);
            Controls.Add(lbldoru);
            Controls.Add(lblsoruno);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnc);
            Controls.Add(btnb);
            Controls.Add(btnd);
            Controls.Add(btna);
            Controls.Add(richTextBox1);
            Font = new Font("Cambria", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button btna;
        private Button btnd;
        private Button btnb;
        private Button btnc;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblsoruno;
        private Label lbldoru;
        private Label lblyanlıs;
        private Button btnsonra;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Panel panel1;
        private Label label7;
    }
}