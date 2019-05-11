namespace Bakalaurs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonHome = new System.Windows.Forms.Button();
            this.buttonNewGame = new System.Windows.Forms.Button();
            this.buttonShowStatistics = new System.Windows.Forms.Button();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.panelScroll = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelNewGame = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.secondNumber = new System.Windows.Forms.TextBox();
            this.firstNumber = new System.Windows.Forms.TextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pSecondLastName = new System.Windows.Forms.TextBox();
            this.AddTeamSecondPlayer = new System.Windows.Forms.Button();
            this.pSecondFirstName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pOneLastName = new System.Windows.Forms.TextBox();
            this.AddTeamFirstPlayer = new System.Windows.Forms.Button();
            this.pOneFirstName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SaveSecondTeamName = new System.Windows.Forms.Button();
            this.SaveFirstTeamName = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.header = new System.Windows.Forms.Label();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.HomePanel = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelNewGame.SuspendLayout();
            this.panel2.SuspendLayout();
            this.HomePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(166, 41);
            this.panel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "BasketballStats";
            // 
            // buttonHome
            // 
            this.buttonHome.FlatAppearance.BorderSize = 0;
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHome.ForeColor = System.Drawing.Color.White;
            this.buttonHome.Image = ((System.Drawing.Image)(resources.GetObject("buttonHome.Image")));
            this.buttonHome.Location = new System.Drawing.Point(12, 47);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(151, 98);
            this.buttonHome.TabIndex = 1;
            this.buttonHome.Text = "Galvenā";
            this.buttonHome.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.GoToHome);
            // 
            // buttonNewGame
            // 
            this.buttonNewGame.FlatAppearance.BorderSize = 0;
            this.buttonNewGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNewGame.ForeColor = System.Drawing.Color.White;
            this.buttonNewGame.Image = ((System.Drawing.Image)(resources.GetObject("buttonNewGame.Image")));
            this.buttonNewGame.Location = new System.Drawing.Point(12, 151);
            this.buttonNewGame.Name = "buttonNewGame";
            this.buttonNewGame.Size = new System.Drawing.Size(151, 98);
            this.buttonNewGame.TabIndex = 2;
            this.buttonNewGame.Text = "Izveidot jaunu spēli";
            this.buttonNewGame.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonNewGame.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonNewGame.UseVisualStyleBackColor = true;
            this.buttonNewGame.Click += new System.EventHandler(this.buttonNewGame_Click);
            // 
            // buttonShowStatistics
            // 
            this.buttonShowStatistics.FlatAppearance.BorderSize = 0;
            this.buttonShowStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowStatistics.ForeColor = System.Drawing.Color.White;
            this.buttonShowStatistics.Image = ((System.Drawing.Image)(resources.GetObject("buttonShowStatistics.Image")));
            this.buttonShowStatistics.Location = new System.Drawing.Point(12, 255);
            this.buttonShowStatistics.Name = "buttonShowStatistics";
            this.buttonShowStatistics.Size = new System.Drawing.Size(151, 98);
            this.buttonShowStatistics.TabIndex = 3;
            this.buttonShowStatistics.Text = "Izvadīt spēles statistiku";
            this.buttonShowStatistics.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonShowStatistics.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonShowStatistics.UseVisualStyleBackColor = true;
            this.buttonShowStatistics.Click += new System.EventHandler(this.buttonShowStatistics_Click);
            // 
            // buttonPrint
            // 
            this.buttonPrint.FlatAppearance.BorderSize = 0;
            this.buttonPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrint.ForeColor = System.Drawing.Color.White;
            this.buttonPrint.Image = ((System.Drawing.Image)(resources.GetObject("buttonPrint.Image")));
            this.buttonPrint.Location = new System.Drawing.Point(12, 359);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(151, 98);
            this.buttonPrint.TabIndex = 4;
            this.buttonPrint.Text = "Printēt spēles statistiku";
            this.buttonPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // panelScroll
            // 
            this.panelScroll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panelScroll.Location = new System.Drawing.Point(3, 47);
            this.panelScroll.Name = "panelScroll";
            this.panelScroll.Size = new System.Drawing.Size(6, 98);
            this.panelScroll.TabIndex = 1;
            // 
            // buttonExit
            // 
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.ForeColor = System.Drawing.Color.White;
            this.buttonExit.Image = ((System.Drawing.Image)(resources.GetObject("buttonExit.Image")));
            this.buttonExit.Location = new System.Drawing.Point(921, 0);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(104, 41);
            this.buttonExit.TabIndex = 6;
            this.buttonExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelScroll);
            this.panel1.Controls.Add(this.buttonPrint);
            this.panel1.Controls.Add(this.buttonShowStatistics);
            this.panel1.Controls.Add(this.buttonNewGame);
            this.panel1.Controls.Add(this.buttonHome);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(166, 575);
            this.panel1.TabIndex = 0;
            // 
            // panelNewGame
            // 
            this.panelNewGame.Controls.Add(this.panel2);
            this.panelNewGame.Location = new System.Drawing.Point(172, 47);
            this.panelNewGame.Name = "panelNewGame";
            this.panelNewGame.Size = new System.Drawing.Size(0, 516);
            this.panelNewGame.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.secondNumber);
            this.panel2.Controls.Add(this.firstNumber);
            this.panel2.Controls.Add(this.richTextBox2);
            this.panel2.Controls.Add(this.richTextBox1);
            this.panel2.Controls.Add(this.pSecondLastName);
            this.panel2.Controls.Add(this.AddTeamSecondPlayer);
            this.panel2.Controls.Add(this.pSecondFirstName);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.pOneLastName);
            this.panel2.Controls.Add(this.AddTeamFirstPlayer);
            this.panel2.Controls.Add(this.pOneFirstName);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.SaveSecondTeamName);
            this.panel2.Controls.Add(this.SaveFirstTeamName);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(3, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(772, 468);
            this.panel2.TabIndex = 0;
            // 
            // secondNumber
            // 
            this.secondNumber.Location = new System.Drawing.Point(289, 380);
            this.secondNumber.Name = "secondNumber";
            this.secondNumber.Size = new System.Drawing.Size(51, 29);
            this.secondNumber.TabIndex = 29;
            this.secondNumber.Visible = false;
            // 
            // firstNumber
            // 
            this.firstNumber.Location = new System.Drawing.Point(289, 135);
            this.firstNumber.Name = "firstNumber";
            this.firstNumber.Size = new System.Drawing.Size(51, 29);
            this.firstNumber.TabIndex = 28;
            this.firstNumber.Visible = false;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(454, 241);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(263, 220);
            this.richTextBox2.TabIndex = 27;
            this.richTextBox2.Text = "";
            this.richTextBox2.Visible = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(454, 7);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(263, 220);
            this.richTextBox1.TabIndex = 26;
            this.richTextBox1.Text = "";
            this.richTextBox1.Visible = false;
            // 
            // pSecondLastName
            // 
            this.pSecondLastName.Location = new System.Drawing.Point(148, 380);
            this.pSecondLastName.Name = "pSecondLastName";
            this.pSecondLastName.Size = new System.Drawing.Size(135, 29);
            this.pSecondLastName.TabIndex = 25;
            this.pSecondLastName.Visible = false;
            // 
            // AddTeamSecondPlayer
            // 
            this.AddTeamSecondPlayer.BackColor = System.Drawing.Color.Transparent;
            this.AddTeamSecondPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddTeamSecondPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddTeamSecondPlayer.ForeColor = System.Drawing.Color.Green;
            this.AddTeamSecondPlayer.Location = new System.Drawing.Point(346, 380);
            this.AddTeamSecondPlayer.Name = "AddTeamSecondPlayer";
            this.AddTeamSecondPlayer.Size = new System.Drawing.Size(90, 30);
            this.AddTeamSecondPlayer.TabIndex = 24;
            this.AddTeamSecondPlayer.Text = "PIEVIENOT";
            this.AddTeamSecondPlayer.UseVisualStyleBackColor = false;
            this.AddTeamSecondPlayer.Visible = false;
            this.AddTeamSecondPlayer.Click += new System.EventHandler(this.AddTeamSecondPlayer_Click);
            // 
            // pSecondFirstName
            // 
            this.pSecondFirstName.Location = new System.Drawing.Point(7, 380);
            this.pSecondFirstName.Name = "pSecondFirstName";
            this.pSecondFirstName.Size = new System.Drawing.Size(135, 29);
            this.pSecondFirstName.TabIndex = 23;
            this.pSecondFirstName.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(105, 349);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 24);
            this.label7.TabIndex = 22;
            this.label7.Text = "Spēlētājs";
            this.label7.Visible = false;
            // 
            // pOneLastName
            // 
            this.pOneLastName.Location = new System.Drawing.Point(148, 135);
            this.pOneLastName.Name = "pOneLastName";
            this.pOneLastName.Size = new System.Drawing.Size(135, 29);
            this.pOneLastName.TabIndex = 21;
            this.pOneLastName.Visible = false;
            // 
            // AddTeamFirstPlayer
            // 
            this.AddTeamFirstPlayer.BackColor = System.Drawing.Color.Transparent;
            this.AddTeamFirstPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddTeamFirstPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddTeamFirstPlayer.ForeColor = System.Drawing.Color.Green;
            this.AddTeamFirstPlayer.Location = new System.Drawing.Point(346, 135);
            this.AddTeamFirstPlayer.Name = "AddTeamFirstPlayer";
            this.AddTeamFirstPlayer.Size = new System.Drawing.Size(90, 30);
            this.AddTeamFirstPlayer.TabIndex = 20;
            this.AddTeamFirstPlayer.Text = "PIEVIENOT";
            this.AddTeamFirstPlayer.UseVisualStyleBackColor = false;
            this.AddTeamFirstPlayer.Visible = false;
            this.AddTeamFirstPlayer.Click += new System.EventHandler(this.AddTeamFirstPlayer_Click);
            // 
            // pOneFirstName
            // 
            this.pOneFirstName.Location = new System.Drawing.Point(7, 135);
            this.pOneFirstName.Name = "pOneFirstName";
            this.pOneFirstName.Size = new System.Drawing.Size(135, 29);
            this.pOneFirstName.TabIndex = 19;
            this.pOneFirstName.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(105, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 24);
            this.label6.TabIndex = 18;
            this.label6.Text = "Spēlētājs";
            this.label6.Visible = false;
            // 
            // SaveSecondTeamName
            // 
            this.SaveSecondTeamName.BackColor = System.Drawing.Color.Transparent;
            this.SaveSecondTeamName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveSecondTeamName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveSecondTeamName.ForeColor = System.Drawing.Color.Green;
            this.SaveSecondTeamName.Location = new System.Drawing.Point(346, 290);
            this.SaveSecondTeamName.Name = "SaveSecondTeamName";
            this.SaveSecondTeamName.Size = new System.Drawing.Size(90, 30);
            this.SaveSecondTeamName.TabIndex = 17;
            this.SaveSecondTeamName.Text = "OK";
            this.SaveSecondTeamName.UseVisualStyleBackColor = false;
            this.SaveSecondTeamName.Click += new System.EventHandler(this.SaveSecondTeamName_Click);
            // 
            // SaveFirstTeamName
            // 
            this.SaveFirstTeamName.BackColor = System.Drawing.Color.Transparent;
            this.SaveFirstTeamName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveFirstTeamName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveFirstTeamName.ForeColor = System.Drawing.Color.Green;
            this.SaveFirstTeamName.Location = new System.Drawing.Point(346, 47);
            this.SaveFirstTeamName.Name = "SaveFirstTeamName";
            this.SaveFirstTeamName.Size = new System.Drawing.Size(90, 30);
            this.SaveFirstTeamName.TabIndex = 16;
            this.SaveFirstTeamName.Text = "OK";
            this.SaveFirstTeamName.UseVisualStyleBackColor = false;
            this.SaveFirstTeamName.Click += new System.EventHandler(this.SaveFirstTeamName_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel4.Location = new System.Drawing.Point(3, 233);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(810, 2);
            this.panel4.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(3, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 24);
            this.label5.TabIndex = 14;
            this.label5.Text = "Nosaukums";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(3, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "Nosaukums";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(138, 290);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(202, 29);
            this.textBox2.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(138, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(202, 29);
            this.textBox1.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(3, 246);
            this.label3.MaximumSize = new System.Drawing.Size(300, 31);
            this.label3.MinimumSize = new System.Drawing.Size(300, 31);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(300, 31);
            this.label3.TabIndex = 10;
            this.label3.Text = "Komanda #2";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.MaximumSize = new System.Drawing.Size(300, 31);
            this.label2.MinimumSize = new System.Drawing.Size(300, 31);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(300, 31);
            this.label2.TabIndex = 9;
            this.label2.Text = "Komanda #1";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.header.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.header.Location = new System.Drawing.Point(323, 7);
            this.header.MaximumSize = new System.Drawing.Size(500, 31);
            this.header.MinimumSize = new System.Drawing.Size(500, 31);
            this.header.Name = "header";
            this.header.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.header.Size = new System.Drawing.Size(500, 31);
            this.header.TabIndex = 8;
            this.header.Text = "Galvenā";
            this.header.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(182, 13);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(0, 24);
            this.ErrorLabel.TabIndex = 9;
            // 
            // HomePanel
            // 
            this.HomePanel.Controls.Add(this.label8);
            this.HomePanel.Location = new System.Drawing.Point(186, 48);
            this.HomePanel.Name = "HomePanel";
            this.HomePanel.Size = new System.Drawing.Size(801, 514);
            this.HomePanel.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(299, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(164, 46);
            this.label8.TabIndex = 0;
            this.label8.Text = "SVEIKS";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1000, 575);
            this.Controls.Add(this.HomePanel);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.header);
            this.Controls.Add(this.panelNewGame);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panelNewGame.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.HomePanel.ResumeLayout(false);
            this.HomePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Button buttonNewGame;
        private System.Windows.Forms.Button buttonShowStatistics;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Panel panelScroll;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelNewGame;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button SaveSecondTeamName;
        private System.Windows.Forms.Button SaveFirstTeamName;
        private System.Windows.Forms.TextBox pSecondLastName;
        private System.Windows.Forms.Button AddTeamSecondPlayer;
        private System.Windows.Forms.TextBox pSecondFirstName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox pOneLastName;
        private System.Windows.Forms.Button AddTeamFirstPlayer;
        private System.Windows.Forms.TextBox pOneFirstName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.TextBox secondNumber;
        private System.Windows.Forms.TextBox firstNumber;
        private System.Windows.Forms.Panel HomePanel;
        private System.Windows.Forms.Label label8;
    }
}

