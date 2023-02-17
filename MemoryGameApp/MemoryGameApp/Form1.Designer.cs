namespace MemoryGameApp
{
    partial class frmMemory
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
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.tblControls1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnStart = new System.Windows.Forms.Button();
            this.rdbTwoPlayer = new System.Windows.Forms.RadioButton();
            this.rdbPlayComputer = new System.Windows.Forms.RadioButton();
            this.tblScores = new System.Windows.Forms.TableLayoutPanel();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblGameStatus = new System.Windows.Forms.Label();
            this.lblScorePlayer1 = new System.Windows.Forms.Label();
            this.lblScorePlayer2 = new System.Windows.Forms.Label();
            this.tblCards = new System.Windows.Forms.TableLayoutPanel();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn10 = new System.Windows.Forms.Button();
            this.btn11 = new System.Windows.Forms.Button();
            this.btn12 = new System.Windows.Forms.Button();
            this.btn13 = new System.Windows.Forms.Button();
            this.btn14 = new System.Windows.Forms.Button();
            this.btn15 = new System.Windows.Forms.Button();
            this.btn16 = new System.Windows.Forms.Button();
            this.btn17 = new System.Windows.Forms.Button();
            this.btn18 = new System.Windows.Forms.Button();
            this.btn19 = new System.Windows.Forms.Button();
            this.btn20 = new System.Windows.Forms.Button();
            this.tblMain.SuspendLayout();
            this.tblControls1.SuspendLayout();
            this.tblScores.SuspendLayout();
            this.tblCards.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.BackColor = System.Drawing.Color.MediumOrchid;
            this.tblMain.ColumnCount = 1;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.Controls.Add(this.tblControls1, 0, 0);
            this.tblMain.Controls.Add(this.tblScores, 0, 1);
            this.tblMain.Controls.Add(this.tblCards, 0, 2);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 3;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.695652F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.695652F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.6087F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMain.Size = new System.Drawing.Size(776, 672);
            this.tblMain.TabIndex = 0;
            // 
            // tblControls1
            // 
            this.tblControls1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.tblControls1.ColumnCount = 3;
            this.tblControls1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblControls1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblControls1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tblControls1.Controls.Add(this.btnStart, 0, 0);
            this.tblControls1.Controls.Add(this.rdbTwoPlayer, 1, 0);
            this.tblControls1.Controls.Add(this.rdbPlayComputer, 2, 0);
            this.tblControls1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblControls1.Location = new System.Drawing.Point(3, 3);
            this.tblControls1.Name = "tblControls1";
            this.tblControls1.RowCount = 1;
            this.tblControls1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblControls1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblControls1.Size = new System.Drawing.Size(770, 52);
            this.tblControls1.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStart.Font = new System.Drawing.Font("Segoe UI Emoji", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStart.Location = new System.Drawing.Point(3, 3);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(225, 46);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            // 
            // rdbTwoPlayer
            // 
            this.rdbTwoPlayer.AutoSize = true;
            this.rdbTwoPlayer.Checked = true;
            this.rdbTwoPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdbTwoPlayer.Font = new System.Drawing.Font("Segoe UI Emoji", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdbTwoPlayer.Location = new System.Drawing.Point(234, 3);
            this.rdbTwoPlayer.Name = "rdbTwoPlayer";
            this.rdbTwoPlayer.Size = new System.Drawing.Size(225, 46);
            this.rdbTwoPlayer.TabIndex = 1;
            this.rdbTwoPlayer.TabStop = true;
            this.rdbTwoPlayer.Text = "2 Player";
            this.rdbTwoPlayer.UseVisualStyleBackColor = true;
            // 
            // rdbPlayComputer
            // 
            this.rdbPlayComputer.AutoSize = true;
            this.rdbPlayComputer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdbPlayComputer.Font = new System.Drawing.Font("Segoe UI Emoji", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdbPlayComputer.Location = new System.Drawing.Point(465, 3);
            this.rdbPlayComputer.Name = "rdbPlayComputer";
            this.rdbPlayComputer.Size = new System.Drawing.Size(302, 46);
            this.rdbPlayComputer.TabIndex = 2;
            this.rdbPlayComputer.Text = "Play Against Computer";
            this.rdbPlayComputer.UseVisualStyleBackColor = true;
            // 
            // tblScores
            // 
            this.tblScores.BackColor = System.Drawing.Color.Cyan;
            this.tblScores.ColumnCount = 4;
            this.tblScores.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblScores.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblScores.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblScores.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblScores.Controls.Add(this.lblMessage, 0, 0);
            this.tblScores.Controls.Add(this.lblGameStatus, 1, 0);
            this.tblScores.Controls.Add(this.lblScorePlayer1, 2, 0);
            this.tblScores.Controls.Add(this.lblScorePlayer2, 3, 0);
            this.tblScores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblScores.Location = new System.Drawing.Point(3, 61);
            this.tblScores.Name = "tblScores";
            this.tblScores.RowCount = 1;
            this.tblScores.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblScores.Size = new System.Drawing.Size(770, 52);
            this.tblScores.TabIndex = 2;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMessage.Location = new System.Drawing.Point(3, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(186, 52);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "Message:";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGameStatus
            // 
            this.lblGameStatus.AutoSize = true;
            this.lblGameStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGameStatus.Location = new System.Drawing.Point(195, 0);
            this.lblGameStatus.Name = "lblGameStatus";
            this.lblGameStatus.Size = new System.Drawing.Size(186, 52);
            this.lblGameStatus.TabIndex = 1;
            this.lblGameStatus.Text = "Game Status:";
            this.lblGameStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblScorePlayer1
            // 
            this.lblScorePlayer1.AutoSize = true;
            this.lblScorePlayer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblScorePlayer1.Location = new System.Drawing.Point(387, 0);
            this.lblScorePlayer1.Name = "lblScorePlayer1";
            this.lblScorePlayer1.Size = new System.Drawing.Size(186, 52);
            this.lblScorePlayer1.TabIndex = 2;
            this.lblScorePlayer1.Text = "Score Player 1:";
            this.lblScorePlayer1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblScorePlayer2
            // 
            this.lblScorePlayer2.AutoSize = true;
            this.lblScorePlayer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblScorePlayer2.Location = new System.Drawing.Point(579, 0);
            this.lblScorePlayer2.Name = "lblScorePlayer2";
            this.lblScorePlayer2.Size = new System.Drawing.Size(188, 52);
            this.lblScorePlayer2.TabIndex = 3;
            this.lblScorePlayer2.Text = "Score Player 2:";
            this.lblScorePlayer2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tblCards
            // 
            this.tblCards.ColumnCount = 5;
            this.tblCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblCards.Controls.Add(this.btn1, 0, 0);
            this.tblCards.Controls.Add(this.btn2, 1, 0);
            this.tblCards.Controls.Add(this.btn3, 2, 0);
            this.tblCards.Controls.Add(this.btn4, 3, 0);
            this.tblCards.Controls.Add(this.btn5, 4, 0);
            this.tblCards.Controls.Add(this.btn6, 0, 1);
            this.tblCards.Controls.Add(this.btn7, 1, 1);
            this.tblCards.Controls.Add(this.btn8, 2, 1);
            this.tblCards.Controls.Add(this.btn9, 3, 1);
            this.tblCards.Controls.Add(this.btn10, 4, 1);
            this.tblCards.Controls.Add(this.btn11, 0, 2);
            this.tblCards.Controls.Add(this.btn12, 1, 2);
            this.tblCards.Controls.Add(this.btn13, 2, 2);
            this.tblCards.Controls.Add(this.btn14, 3, 2);
            this.tblCards.Controls.Add(this.btn15, 4, 2);
            this.tblCards.Controls.Add(this.btn16, 0, 3);
            this.tblCards.Controls.Add(this.btn17, 1, 3);
            this.tblCards.Controls.Add(this.btn18, 2, 3);
            this.tblCards.Controls.Add(this.btn19, 3, 3);
            this.tblCards.Controls.Add(this.btn20, 4, 3);
            this.tblCards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblCards.Font = new System.Drawing.Font("Webdings", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tblCards.Location = new System.Drawing.Point(3, 119);
            this.tblCards.Name = "tblCards";
            this.tblCards.RowCount = 4;
            this.tblCards.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblCards.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblCards.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblCards.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblCards.Size = new System.Drawing.Size(770, 550);
            this.tblCards.TabIndex = 3;
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn1.Font = new System.Drawing.Font("Webdings", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn1.ForeColor = System.Drawing.Color.Black;
            this.btn1.Location = new System.Drawing.Point(3, 3);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(148, 131);
            this.btn1.TabIndex = 0;
            this.btn1.UseVisualStyleBackColor = false;
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn2.Font = new System.Drawing.Font("Webdings", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn2.ForeColor = System.Drawing.Color.Black;
            this.btn2.Location = new System.Drawing.Point(157, 3);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(148, 131);
            this.btn2.TabIndex = 1;
            this.btn2.UseVisualStyleBackColor = false;
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn3.Font = new System.Drawing.Font("Webdings", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn3.ForeColor = System.Drawing.Color.Black;
            this.btn3.Location = new System.Drawing.Point(311, 3);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(148, 131);
            this.btn3.TabIndex = 2;
            this.btn3.UseVisualStyleBackColor = false;
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn4.Font = new System.Drawing.Font("Webdings", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn4.ForeColor = System.Drawing.Color.Black;
            this.btn4.Location = new System.Drawing.Point(465, 3);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(148, 131);
            this.btn4.TabIndex = 3;
            this.btn4.UseVisualStyleBackColor = false;
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn5.Font = new System.Drawing.Font("Webdings", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn5.ForeColor = System.Drawing.Color.Black;
            this.btn5.Location = new System.Drawing.Point(619, 3);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(148, 131);
            this.btn5.TabIndex = 4;
            this.btn5.UseVisualStyleBackColor = false;
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn6.Font = new System.Drawing.Font("Webdings", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn6.ForeColor = System.Drawing.Color.Black;
            this.btn6.Location = new System.Drawing.Point(3, 140);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(148, 131);
            this.btn6.TabIndex = 5;
            this.btn6.UseVisualStyleBackColor = false;
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn7.Font = new System.Drawing.Font("Webdings", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn7.ForeColor = System.Drawing.Color.Black;
            this.btn7.Location = new System.Drawing.Point(157, 140);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(148, 131);
            this.btn7.TabIndex = 6;
            this.btn7.UseVisualStyleBackColor = false;
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn8.Font = new System.Drawing.Font("Webdings", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn8.ForeColor = System.Drawing.Color.Black;
            this.btn8.Location = new System.Drawing.Point(311, 140);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(148, 131);
            this.btn8.TabIndex = 7;
            this.btn8.UseVisualStyleBackColor = false;
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn9.Font = new System.Drawing.Font("Webdings", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn9.ForeColor = System.Drawing.Color.Black;
            this.btn9.Location = new System.Drawing.Point(465, 140);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(148, 131);
            this.btn9.TabIndex = 8;
            this.btn9.UseVisualStyleBackColor = false;
            // 
            // btn10
            // 
            this.btn10.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn10.Font = new System.Drawing.Font("Webdings", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn10.ForeColor = System.Drawing.Color.Black;
            this.btn10.Location = new System.Drawing.Point(619, 140);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(148, 131);
            this.btn10.TabIndex = 9;
            this.btn10.UseVisualStyleBackColor = false;
            // 
            // btn11
            // 
            this.btn11.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn11.Font = new System.Drawing.Font("Webdings", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn11.ForeColor = System.Drawing.Color.Black;
            this.btn11.Location = new System.Drawing.Point(3, 277);
            this.btn11.Name = "btn11";
            this.btn11.Size = new System.Drawing.Size(148, 131);
            this.btn11.TabIndex = 10;
            this.btn11.UseVisualStyleBackColor = false;
            // 
            // btn12
            // 
            this.btn12.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn12.Font = new System.Drawing.Font("Webdings", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn12.ForeColor = System.Drawing.Color.Black;
            this.btn12.Location = new System.Drawing.Point(157, 277);
            this.btn12.Name = "btn12";
            this.btn12.Size = new System.Drawing.Size(148, 131);
            this.btn12.TabIndex = 11;
            this.btn12.UseVisualStyleBackColor = false;
            // 
            // btn13
            // 
            this.btn13.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn13.Font = new System.Drawing.Font("Webdings", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn13.ForeColor = System.Drawing.Color.Black;
            this.btn13.Location = new System.Drawing.Point(311, 277);
            this.btn13.Name = "btn13";
            this.btn13.Size = new System.Drawing.Size(148, 131);
            this.btn13.TabIndex = 12;
            this.btn13.UseVisualStyleBackColor = false;
            // 
            // btn14
            // 
            this.btn14.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn14.Font = new System.Drawing.Font("Webdings", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn14.ForeColor = System.Drawing.Color.Black;
            this.btn14.Location = new System.Drawing.Point(465, 277);
            this.btn14.Name = "btn14";
            this.btn14.Size = new System.Drawing.Size(148, 131);
            this.btn14.TabIndex = 13;
            this.btn14.UseVisualStyleBackColor = false;
            // 
            // btn15
            // 
            this.btn15.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn15.Font = new System.Drawing.Font("Webdings", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn15.ForeColor = System.Drawing.Color.Black;
            this.btn15.Location = new System.Drawing.Point(619, 277);
            this.btn15.Name = "btn15";
            this.btn15.Size = new System.Drawing.Size(148, 131);
            this.btn15.TabIndex = 14;
            this.btn15.UseVisualStyleBackColor = false;
            // 
            // btn16
            // 
            this.btn16.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn16.Font = new System.Drawing.Font("Webdings", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn16.ForeColor = System.Drawing.Color.Black;
            this.btn16.Location = new System.Drawing.Point(3, 414);
            this.btn16.Name = "btn16";
            this.btn16.Size = new System.Drawing.Size(148, 133);
            this.btn16.TabIndex = 15;
            this.btn16.UseVisualStyleBackColor = false;
            // 
            // btn17
            // 
            this.btn17.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn17.Font = new System.Drawing.Font("Webdings", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn17.ForeColor = System.Drawing.Color.Black;
            this.btn17.Location = new System.Drawing.Point(157, 414);
            this.btn17.Name = "btn17";
            this.btn17.Size = new System.Drawing.Size(148, 133);
            this.btn17.TabIndex = 16;
            this.btn17.UseVisualStyleBackColor = false;
            // 
            // btn18
            // 
            this.btn18.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn18.Font = new System.Drawing.Font("Webdings", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn18.ForeColor = System.Drawing.Color.Black;
            this.btn18.Location = new System.Drawing.Point(311, 414);
            this.btn18.Name = "btn18";
            this.btn18.Size = new System.Drawing.Size(148, 133);
            this.btn18.TabIndex = 17;
            this.btn18.UseVisualStyleBackColor = false;
            // 
            // btn19
            // 
            this.btn19.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn19.Font = new System.Drawing.Font("Webdings", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn19.ForeColor = System.Drawing.Color.Black;
            this.btn19.Location = new System.Drawing.Point(465, 414);
            this.btn19.Name = "btn19";
            this.btn19.Size = new System.Drawing.Size(148, 133);
            this.btn19.TabIndex = 18;
            this.btn19.UseVisualStyleBackColor = false;
            // 
            // btn20
            // 
            this.btn20.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn20.Font = new System.Drawing.Font("Webdings", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn20.ForeColor = System.Drawing.Color.Black;
            this.btn20.Location = new System.Drawing.Point(619, 414);
            this.btn20.Name = "btn20";
            this.btn20.Size = new System.Drawing.Size(148, 133);
            this.btn20.TabIndex = 19;
            this.btn20.UseVisualStyleBackColor = false;
            // 
            // frmMemory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 672);
            this.Controls.Add(this.tblMain);
            this.Name = "frmMemory";
            this.Text = "Memory";
            this.tblMain.ResumeLayout(false);
            this.tblControls1.ResumeLayout(false);
            this.tblControls1.PerformLayout();
            this.tblScores.ResumeLayout(false);
            this.tblScores.PerformLayout();
            this.tblCards.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tblMain;
        private TableLayoutPanel tblControls1;
        private Button btnStart;
        private RadioButton rdbTwoPlayer;
        private RadioButton rdbPlayComputer;
        private TableLayoutPanel tblScores;
        private TableLayoutPanel tblCards;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btn10;
        private Button btn11;
        private Button btn12;
        private Button btn13;
        private Button btn14;
        private Button btn15;
        private Button btn16;
        private Button btn17;
        private Button btn18;
        private Button btn19;
        private Button btn20;
        private Label lblMessage;
        private Label lblGameStatus;
        private Label lblScorePlayer1;
        private Label lblScorePlayer2;
    }
}