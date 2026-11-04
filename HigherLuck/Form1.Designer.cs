namespace HigherLuck
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
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            numericUpDown1 = new NumericUpDown();
            groupBox2 = new GroupBox();
            picDice = new PictureBox();
            btnRoll = new Button();
            lblTurn = new Label();
            lblRound = new Label();
            label6 = new Label();
            groupBox3 = new GroupBox();
            rbAvatar4 = new RadioButton();
            rbAvatar3 = new RadioButton();
            rbAvatar2 = new RadioButton();
            rbAvatar1 = new RadioButton();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            btnSetupP1 = new Button();
            btnSetupP2 = new Button();
            btnReset = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picDice).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(368, 176);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, -3);
            label2.Name = "label2";
            label2.Size = new Size(256, 140);
            label2.TabIndex = 1;
            label2.Text = "Team name: Polymorphs\r\nTeam members: 5\r\nSelmane Djihene 78430\r\nAbdeldjalil takouche 78469\r\nKabdyy Aiym E2026874\r\nIkhsangaliyeva Amira 78147\r\nChekouche Yanis Saïd Kaddour 78484";
            label2.Click += label2_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Location = new Point(262, -3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(316, 173);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Initializations";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(162, 67);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(162, 103);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 105);
            label5.Name = "label5";
            label5.Size = new Size(144, 20);
            label5.TabIndex = 3;
            label5.Text = "Second player name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 70);
            label4.Name = "label4";
            label4.Size = new Size(122, 20);
            label4.TabIndex = 2;
            label4.Text = "First player name";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 27);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 1;
            label3.Text = "Rounds";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(86, 26);
            numericUpDown1.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(40, 27);
            numericUpDown1.TabIndex = 0;
            numericUpDown1.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(picDice);
            groupBox2.Controls.Add(btnRoll);
            groupBox2.Controls.Add(lblTurn);
            groupBox2.Controls.Add(lblRound);
            groupBox2.Location = new Point(262, 176);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(316, 254);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Action";
            // 
            // picDice
            // 
            picDice.BorderStyle = BorderStyle.FixedSingle;
            picDice.Image = (Image)resources.GetObject("picDice.Image");
            picDice.Location = new Point(15, 125);
            picDice.Name = "picDice";
            picDice.Size = new Size(119, 114);
            picDice.SizeMode = PictureBoxSizeMode.StretchImage;
            picDice.TabIndex = 4;
            picDice.TabStop = false;
            picDice.Click += picDice_Click;
            // 
            // btnRoll
            // 
            btnRoll.Enabled = false;
            btnRoll.Location = new Point(12, 90);
            btnRoll.Name = "btnRoll";
            btnRoll.Size = new Size(175, 29);
            btnRoll.TabIndex = 2;
            btnRoll.Text = "ROLL";
            btnRoll.UseVisualStyleBackColor = true;
            // 
            // lblTurn
            // 
            lblTurn.AutoSize = true;
            lblTurn.BackColor = Color.Black;
            lblTurn.Location = new Point(12, 53);
            lblTurn.Name = "lblTurn";
            lblTurn.Size = new Size(181, 20);
            lblTurn.TabIndex = 1;
            lblTurn.Text = "                                           ";
            // 
            // lblRound
            // 
            lblRound.AutoSize = true;
            lblRound.Location = new Point(6, 23);
            lblRound.Name = "lblRound";
            lblRound.Size = new Size(67, 20);
            lblRound.TabIndex = 0;
            lblRound.Text = "Round: 0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(586, 7);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 4;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(rbAvatar4);
            groupBox3.Controls.Add(rbAvatar3);
            groupBox3.Controls.Add(rbAvatar2);
            groupBox3.Controls.Add(rbAvatar1);
            groupBox3.Controls.Add(pictureBox4);
            groupBox3.Controls.Add(pictureBox3);
            groupBox3.Controls.Add(pictureBox2);
            groupBox3.Controls.Add(pictureBox1);
            groupBox3.Location = new Point(584, -3);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(180, 314);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Avatars";
            // 
            // rbAvatar4
            // 
            rbAvatar4.AutoSize = true;
            rbAvatar4.Location = new Point(33, 269);
            rbAvatar4.Name = "rbAvatar4";
            rbAvatar4.Size = new Size(17, 16);
            rbAvatar4.TabIndex = 7;
            rbAvatar4.TabStop = true;
            rbAvatar4.UseVisualStyleBackColor = true;
            // 
            // rbAvatar3
            // 
            rbAvatar3.AutoSize = true;
            rbAvatar3.Location = new Point(33, 192);
            rbAvatar3.Name = "rbAvatar3";
            rbAvatar3.Size = new Size(17, 16);
            rbAvatar3.TabIndex = 6;
            rbAvatar3.TabStop = true;
            rbAvatar3.UseVisualStyleBackColor = true;
            // 
            // rbAvatar2
            // 
            rbAvatar2.AutoSize = true;
            rbAvatar2.Location = new Point(33, 124);
            rbAvatar2.Name = "rbAvatar2";
            rbAvatar2.Size = new Size(17, 16);
            rbAvatar2.TabIndex = 5;
            rbAvatar2.TabStop = true;
            rbAvatar2.UseVisualStyleBackColor = true;
            // 
            // rbAvatar1
            // 
            rbAvatar1.AutoSize = true;
            rbAvatar1.Location = new Point(33, 55);
            rbAvatar1.Name = "rbAvatar1";
            rbAvatar1.Size = new Size(17, 16);
            rbAvatar1.TabIndex = 4;
            rbAvatar1.TabStop = true;
            rbAvatar1.UseVisualStyleBackColor = true;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(82, 242);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(78, 63);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(82, 172);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(78, 63);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(82, 103);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(78, 63);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(82, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(78, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnSetupP1
            // 
            btnSetupP1.Enabled = false;
            btnSetupP1.Location = new Point(584, 317);
            btnSetupP1.Name = "btnSetupP1";
            btnSetupP1.Size = new Size(180, 33);
            btnSetupP1.TabIndex = 6;
            btnSetupP1.Text = "Set Up First Player";
            btnSetupP1.UseVisualStyleBackColor = true;
            // 
            // btnSetupP2
            // 
            btnSetupP2.Enabled = false;
            btnSetupP2.Location = new Point(584, 356);
            btnSetupP2.Name = "btnSetupP2";
            btnSetupP2.Size = new Size(180, 33);
            btnSetupP2.TabIndex = 7;
            btnSetupP2.Text = "Set Up Second Player";
            btnSetupP2.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(584, 395);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(180, 33);
            btnReset.TabIndex = 8;
            btnReset.Text = "RESET ALL";
            btnReset.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1095, 487);
            Controls.Add(btnReset);
            Controls.Add(btnSetupP2);
            Controls.Add(btnSetupP1);
            Controls.Add(groupBox3);
            Controls.Add(label6);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Higher Luck";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picDice).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private NumericUpDown numericUpDown1;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox textBox2;
        private TextBox textBox1;
        private GroupBox groupBox2;
        private Label lblRound;
        private Button btnRoll;
        private Label lblTurn;
        private PictureBox picDice;
        private Label label6;
        private GroupBox groupBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private RadioButton rbAvatar4;
        private RadioButton rbAvatar3;
        private RadioButton rbAvatar2;
        private RadioButton rbAvatar1;
        private Button btnSetupP1;
        private Button btnSetupP2;
        private Button btnReset;
    }
}
