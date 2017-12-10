namespace CapstoneProject
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
            this.playerCard1 = new System.Windows.Forms.PictureBox();
            this.btnHit = new System.Windows.Forms.Button();
            this.btnHold = new System.Windows.Forms.Button();
            this.dealerCard1 = new System.Windows.Forms.PictureBox();
            this.dealerCard2 = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.playerCard2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.deckCount = new System.Windows.Forms.Label();
            this.dealerCardCtn = new System.Windows.Forms.Label();
            this.playerCardctn = new System.Windows.Forms.Label();
            this.playerCard3 = new System.Windows.Forms.PictureBox();
            this.playerCard4 = new System.Windows.Forms.PictureBox();
            this.playerCard5 = new System.Windows.Forms.PictureBox();
            this.result = new System.Windows.Forms.Label();
            this.playerCard6 = new System.Windows.Forms.PictureBox();
            this.btnNextGame = new System.Windows.Forms.Button();
            this.dealerCard3 = new System.Windows.Forms.PictureBox();
            this.dealerCard4 = new System.Windows.Forms.PictureBox();
            this.dealerCard5 = new System.Windows.Forms.PictureBox();
            this.newShoe = new System.Windows.Forms.Label();
            this.btnBet5 = new System.Windows.Forms.Button();
            this.btnBet10 = new System.Windows.Forms.Button();
            this.btnBet20 = new System.Windows.Forms.Button();
            this.btnBet50 = new System.Windows.Forms.Button();
            this.currentBet = new System.Windows.Forms.Label();
            this.errorBet = new System.Windows.Forms.Label();
            this.plyBalance = new System.Windows.Forms.Label();
            this.btnClearBet = new System.Windows.Forms.Button();
            this.dealerCard6 = new System.Windows.Forms.PictureBox();
            this.dealerCard7 = new System.Windows.Forms.PictureBox();
            this.playerCard7 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerCard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerCard4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerCard5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerCard6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerCard7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard7)).BeginInit();
            this.SuspendLayout();
            // 
            // playerCard1
            // 
            this.playerCard1.Location = new System.Drawing.Point(445, 457);
            this.playerCard1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.playerCard1.MaximumSize = new System.Drawing.Size(1100, 1100);
            this.playerCard1.Name = "playerCard1";
            this.playerCard1.Size = new System.Drawing.Size(63, 78);
            this.playerCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.playerCard1.TabIndex = 0;
            this.playerCard1.TabStop = false;
            this.playerCard1.Visible = false;
            this.playerCard1.Click += new System.EventHandler(this.btnHit_Click);
            // 
            // btnHit
            // 
            this.btnHit.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnHit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnHit.Location = new System.Drawing.Point(376, 574);
            this.btnHit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(85, 31);
            this.btnHit.TabIndex = 1;
            this.btnHit.Text = "HIT";
            this.btnHit.UseVisualStyleBackColor = false;
            this.btnHit.Visible = false;
            this.btnHit.Click += new System.EventHandler(this.btnHit_Click);
            // 
            // btnHold
            // 
            this.btnHold.Location = new System.Drawing.Point(573, 574);
            this.btnHold.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHold.Name = "btnHold";
            this.btnHold.Size = new System.Drawing.Size(85, 31);
            this.btnHold.TabIndex = 2;
            this.btnHold.Text = "Hold";
            this.btnHold.UseVisualStyleBackColor = true;
            this.btnHold.Visible = false;
            this.btnHold.Click += new System.EventHandler(this.btnHold_Click);
            // 
            // dealerCard1
            // 
            this.dealerCard1.Location = new System.Drawing.Point(313, 75);
            this.dealerCard1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dealerCard1.MaximumSize = new System.Drawing.Size(1100, 1100);
            this.dealerCard1.Name = "dealerCard1";
            this.dealerCard1.Size = new System.Drawing.Size(63, 78);
            this.dealerCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dealerCard1.TabIndex = 3;
            this.dealerCard1.TabStop = false;
            this.dealerCard1.Visible = false;
            this.dealerCard1.Click += new System.EventHandler(this.dealerCard1_Click);
            // 
            // dealerCard2
            // 
            this.dealerCard2.Location = new System.Drawing.Point(383, 75);
            this.dealerCard2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dealerCard2.MaximumSize = new System.Drawing.Size(1100, 1100);
            this.dealerCard2.Name = "dealerCard2";
            this.dealerCard2.Size = new System.Drawing.Size(63, 78);
            this.dealerCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dealerCard2.TabIndex = 4;
            this.dealerCard2.TabStop = false;
            this.dealerCard2.Visible = false;
            this.dealerCard2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(480, 539);
            this.btnStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(91, 30);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // playerCard2
            // 
            this.playerCard2.Location = new System.Drawing.Point(519, 457);
            this.playerCard2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.playerCard2.MaximumSize = new System.Drawing.Size(1100, 1100);
            this.playerCard2.Name = "playerCard2";
            this.playerCard2.Size = new System.Drawing.Size(63, 78);
            this.playerCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.playerCard2.TabIndex = 6;
            this.playerCard2.TabStop = false;
            this.playerCard2.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, 25);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(1100, 1100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1032, 583);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // deckCount
            // 
            this.deckCount.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deckCount.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deckCount.Location = new System.Drawing.Point(139, 102);
            this.deckCount.Name = "deckCount";
            this.deckCount.Size = new System.Drawing.Size(61, 38);
            this.deckCount.TabIndex = 8;
            this.deckCount.Text = "deckCtn";
            this.deckCount.Click += new System.EventHandler(this.label1_Click);
            // 
            // dealerCardCtn
            // 
            this.dealerCardCtn.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealerCardCtn.Location = new System.Drawing.Point(260, 75);
            this.dealerCardCtn.Name = "dealerCardCtn";
            this.dealerCardCtn.Size = new System.Drawing.Size(47, 39);
            this.dealerCardCtn.TabIndex = 9;
            this.dealerCardCtn.Text = "d_count";
            this.dealerCardCtn.Click += new System.EventHandler(this.dealerCardCtn_Click);
            // 
            // playerCardctn
            // 
            this.playerCardctn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerCardctn.Location = new System.Drawing.Point(800, 388);
            this.playerCardctn.Name = "playerCardctn";
            this.playerCardctn.Size = new System.Drawing.Size(52, 47);
            this.playerCardctn.TabIndex = 10;
            this.playerCardctn.Text = "p_count";
            this.playerCardctn.Click += new System.EventHandler(this.playerCardctn_Click);
            // 
            // playerCard3
            // 
            this.playerCard3.Location = new System.Drawing.Point(599, 457);
            this.playerCard3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.playerCard3.MaximumSize = new System.Drawing.Size(1100, 1100);
            this.playerCard3.Name = "playerCard3";
            this.playerCard3.Size = new System.Drawing.Size(63, 78);
            this.playerCard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.playerCard3.TabIndex = 11;
            this.playerCard3.TabStop = false;
            this.playerCard3.Visible = false;
            this.playerCard3.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // playerCard4
            // 
            this.playerCard4.Location = new System.Drawing.Point(676, 457);
            this.playerCard4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.playerCard4.MaximumSize = new System.Drawing.Size(1100, 1100);
            this.playerCard4.Name = "playerCard4";
            this.playerCard4.Size = new System.Drawing.Size(63, 78);
            this.playerCard4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerCard4.TabIndex = 12;
            this.playerCard4.TabStop = false;
            this.playerCard4.Visible = false;
            this.playerCard4.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // playerCard5
            // 
            this.playerCard5.Location = new System.Drawing.Point(753, 457);
            this.playerCard5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.playerCard5.MaximumSize = new System.Drawing.Size(1100, 1100);
            this.playerCard5.Name = "playerCard5";
            this.playerCard5.Size = new System.Drawing.Size(63, 78);
            this.playerCard5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerCard5.TabIndex = 13;
            this.playerCard5.TabStop = false;
            this.playerCard5.Visible = false;
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.Location = new System.Drawing.Point(425, 260);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(154, 20);
            this.result.TabIndex = 14;
            this.result.Text = "Please Make A Bet";
            this.result.Click += new System.EventHandler(this.result_Click);
            // 
            // playerCard6
            // 
            this.playerCard6.Location = new System.Drawing.Point(832, 457);
            this.playerCard6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.playerCard6.MaximumSize = new System.Drawing.Size(1100, 1100);
            this.playerCard6.Name = "playerCard6";
            this.playerCard6.Size = new System.Drawing.Size(63, 78);
            this.playerCard6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerCard6.TabIndex = 15;
            this.playerCard6.TabStop = false;
            this.playerCard6.Visible = false;
            // 
            // btnNextGame
            // 
            this.btnNextGame.Location = new System.Drawing.Point(445, 297);
            this.btnNextGame.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNextGame.Name = "btnNextGame";
            this.btnNextGame.Size = new System.Drawing.Size(141, 23);
            this.btnNextGame.TabIndex = 16;
            this.btnNextGame.Text = "Next Game";
            this.btnNextGame.UseVisualStyleBackColor = true;
            this.btnNextGame.Visible = false;
            this.btnNextGame.Click += new System.EventHandler(this.btnNextGame_Click);
            // 
            // dealerCard3
            // 
            this.dealerCard3.Location = new System.Drawing.Point(452, 75);
            this.dealerCard3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dealerCard3.MaximumSize = new System.Drawing.Size(1100, 1100);
            this.dealerCard3.Name = "dealerCard3";
            this.dealerCard3.Size = new System.Drawing.Size(63, 78);
            this.dealerCard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dealerCard3.TabIndex = 17;
            this.dealerCard3.TabStop = false;
            this.dealerCard3.Visible = false;
            // 
            // dealerCard4
            // 
            this.dealerCard4.Location = new System.Drawing.Point(521, 75);
            this.dealerCard4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dealerCard4.MaximumSize = new System.Drawing.Size(1100, 1100);
            this.dealerCard4.Name = "dealerCard4";
            this.dealerCard4.Size = new System.Drawing.Size(63, 78);
            this.dealerCard4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dealerCard4.TabIndex = 18;
            this.dealerCard4.TabStop = false;
            this.dealerCard4.Visible = false;
            // 
            // dealerCard5
            // 
            this.dealerCard5.Location = new System.Drawing.Point(589, 75);
            this.dealerCard5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dealerCard5.MaximumSize = new System.Drawing.Size(1100, 1100);
            this.dealerCard5.Name = "dealerCard5";
            this.dealerCard5.Size = new System.Drawing.Size(63, 78);
            this.dealerCard5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dealerCard5.TabIndex = 19;
            this.dealerCard5.TabStop = false;
            this.dealerCard5.Visible = false;
            this.dealerCard5.Click += new System.EventHandler(this.dealerCard5_Click);
            // 
            // newShoe
            // 
            this.newShoe.BackColor = System.Drawing.Color.DarkGreen;
            this.newShoe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newShoe.ForeColor = System.Drawing.Color.Red;
            this.newShoe.Location = new System.Drawing.Point(101, 155);
            this.newShoe.Name = "newShoe";
            this.newShoe.Size = new System.Drawing.Size(169, 37);
            this.newShoe.TabIndex = 20;
            this.newShoe.Text = "New Shoe Added";
            this.newShoe.Visible = false;
            this.newShoe.Click += new System.EventHandler(this.newShoe_Click);
            // 
            // btnBet5
            // 
            this.btnBet5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnBet5.Location = new System.Drawing.Point(57, 353);
            this.btnBet5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBet5.Name = "btnBet5";
            this.btnBet5.Size = new System.Drawing.Size(53, 34);
            this.btnBet5.TabIndex = 21;
            this.btnBet5.Text = "5";
            this.btnBet5.UseVisualStyleBackColor = false;
            this.btnBet5.Click += new System.EventHandler(this.btnBet5_Click);
            // 
            // btnBet10
            // 
            this.btnBet10.BackColor = System.Drawing.Color.Red;
            this.btnBet10.Location = new System.Drawing.Point(96, 400);
            this.btnBet10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBet10.Name = "btnBet10";
            this.btnBet10.Size = new System.Drawing.Size(53, 34);
            this.btnBet10.TabIndex = 22;
            this.btnBet10.Text = "10";
            this.btnBet10.UseVisualStyleBackColor = false;
            this.btnBet10.Click += new System.EventHandler(this.btnBet10_Click);
            // 
            // btnBet20
            // 
            this.btnBet20.BackColor = System.Drawing.Color.DarkBlue;
            this.btnBet20.Location = new System.Drawing.Point(145, 446);
            this.btnBet20.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBet20.Name = "btnBet20";
            this.btnBet20.Size = new System.Drawing.Size(53, 34);
            this.btnBet20.TabIndex = 23;
            this.btnBet20.Text = "20";
            this.btnBet20.UseVisualStyleBackColor = false;
            this.btnBet20.Click += new System.EventHandler(this.btnBet20_Click);
            // 
            // btnBet50
            // 
            this.btnBet50.BackColor = System.Drawing.Color.Fuchsia;
            this.btnBet50.Location = new System.Drawing.Point(197, 481);
            this.btnBet50.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBet50.Name = "btnBet50";
            this.btnBet50.Size = new System.Drawing.Size(53, 34);
            this.btnBet50.TabIndex = 24;
            this.btnBet50.Text = "50";
            this.btnBet50.UseVisualStyleBackColor = false;
            this.btnBet50.Click += new System.EventHandler(this.btnBet50_Click);
            // 
            // currentBet
            // 
            this.currentBet.AutoSize = true;
            this.currentBet.Location = new System.Drawing.Point(11, 447);
            this.currentBet.Name = "currentBet";
            this.currentBet.Size = new System.Drawing.Size(76, 17);
            this.currentBet.TabIndex = 25;
            this.currentBet.Text = "CurrentBet";
            this.currentBet.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // errorBet
            // 
            this.errorBet.AutoSize = true;
            this.errorBet.ForeColor = System.Drawing.Color.Red;
            this.errorBet.Location = new System.Drawing.Point(7, 487);
            this.errorBet.Name = "errorBet";
            this.errorBet.Size = new System.Drawing.Size(141, 17);
            this.errorBet.TabIndex = 26;
            this.errorBet.Text = "Bet Exceeds Balance";
            this.errorBet.Visible = false;
            // 
            // plyBalance
            // 
            this.plyBalance.AutoSize = true;
            this.plyBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plyBalance.Location = new System.Drawing.Point(703, 176);
            this.plyBalance.Name = "plyBalance";
            this.plyBalance.Size = new System.Drawing.Size(47, 32);
            this.plyBalance.TabIndex = 27;
            this.plyBalance.Text = "$$";
            // 
            // btnClearBet
            // 
            this.btnClearBet.BackColor = System.Drawing.Color.White;
            this.btnClearBet.Location = new System.Drawing.Point(32, 306);
            this.btnClearBet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClearBet.Name = "btnClearBet";
            this.btnClearBet.Size = new System.Drawing.Size(53, 34);
            this.btnClearBet.TabIndex = 28;
            this.btnClearBet.Text = "Clear";
            this.btnClearBet.UseVisualStyleBackColor = false;
            this.btnClearBet.Click += new System.EventHandler(this.btnClearBet_Click);
            // 
            // dealerCard6
            // 
            this.dealerCard6.Location = new System.Drawing.Point(657, 76);
            this.dealerCard6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dealerCard6.MaximumSize = new System.Drawing.Size(1100, 1100);
            this.dealerCard6.Name = "dealerCard6";
            this.dealerCard6.Size = new System.Drawing.Size(63, 78);
            this.dealerCard6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dealerCard6.TabIndex = 29;
            this.dealerCard6.TabStop = false;
            this.dealerCard6.Visible = false;
            // 
            // dealerCard7
            // 
            this.dealerCard7.Location = new System.Drawing.Point(726, 76);
            this.dealerCard7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dealerCard7.MaximumSize = new System.Drawing.Size(1100, 1100);
            this.dealerCard7.Name = "dealerCard7";
            this.dealerCard7.Size = new System.Drawing.Size(63, 78);
            this.dealerCard7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dealerCard7.TabIndex = 30;
            this.dealerCard7.TabStop = false;
            this.dealerCard7.Visible = false;
            // 
            // playerCard7
            // 
            this.playerCard7.Location = new System.Drawing.Point(908, 457);
            this.playerCard7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.playerCard7.MaximumSize = new System.Drawing.Size(1100, 1100);
            this.playerCard7.Name = "playerCard7";
            this.playerCard7.Size = new System.Drawing.Size(63, 78);
            this.playerCard7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerCard7.TabIndex = 31;
            this.playerCard7.TabStop = false;
            this.playerCard7.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1111, 724);
            this.Controls.Add(this.playerCard7);
            this.Controls.Add(this.dealerCard7);
            this.Controls.Add(this.dealerCard6);
            this.Controls.Add(this.btnClearBet);
            this.Controls.Add(this.plyBalance);
            this.Controls.Add(this.errorBet);
            this.Controls.Add(this.currentBet);
            this.Controls.Add(this.btnBet50);
            this.Controls.Add(this.btnBet20);
            this.Controls.Add(this.btnBet10);
            this.Controls.Add(this.btnBet5);
            this.Controls.Add(this.newShoe);
            this.Controls.Add(this.dealerCard5);
            this.Controls.Add(this.dealerCard4);
            this.Controls.Add(this.dealerCard3);
            this.Controls.Add(this.btnNextGame);
            this.Controls.Add(this.playerCard6);
            this.Controls.Add(this.result);
            this.Controls.Add(this.playerCard5);
            this.Controls.Add(this.playerCard4);
            this.Controls.Add(this.playerCard3);
            this.Controls.Add(this.playerCardctn);
            this.Controls.Add(this.dealerCardCtn);
            this.Controls.Add(this.deckCount);
            this.Controls.Add(this.playerCard2);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.dealerCard2);
            this.Controls.Add(this.dealerCard1);
            this.Controls.Add(this.btnHold);
            this.Controls.Add(this.btnHit);
            this.Controls.Add(this.playerCard1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "BlackJack";
            ((System.ComponentModel.ISupportInitialize)(this.playerCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerCard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerCard4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerCard5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerCard6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerCard7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox playerCard1;
        private System.Windows.Forms.Button btnHit;
        private System.Windows.Forms.Button btnHold;
        private System.Windows.Forms.PictureBox dealerCard1;
        private System.Windows.Forms.PictureBox dealerCard2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox playerCard2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label deckCount;
        private System.Windows.Forms.Label dealerCardCtn;
        private System.Windows.Forms.Label playerCardctn;
        private System.Windows.Forms.PictureBox playerCard3;
        private System.Windows.Forms.PictureBox playerCard4;
        private System.Windows.Forms.PictureBox playerCard5;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.PictureBox playerCard6;
        private System.Windows.Forms.Button btnNextGame;
        private System.Windows.Forms.PictureBox dealerCard3;
        private System.Windows.Forms.PictureBox dealerCard4;
        private System.Windows.Forms.PictureBox dealerCard5;
        private System.Windows.Forms.Label newShoe;
        private System.Windows.Forms.Button btnBet5;
        private System.Windows.Forms.Button btnBet10;
        private System.Windows.Forms.Button btnBet20;
        private System.Windows.Forms.Button btnBet50;
        private System.Windows.Forms.Label currentBet;
        private System.Windows.Forms.Label errorBet;
        private System.Windows.Forms.Label plyBalance;
        private System.Windows.Forms.Button btnClearBet;
        private System.Windows.Forms.PictureBox dealerCard6;
        private System.Windows.Forms.PictureBox dealerCard7;
        private System.Windows.Forms.PictureBox playerCard7;
    }
}

