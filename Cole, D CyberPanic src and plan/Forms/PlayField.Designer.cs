using CyberPanicLite.Classes;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Media;
using System.Xml.Serialization;

namespace CyberPanicLite {
    partial class PlayField {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;



        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayField));
            this.OpponentHpBar = new System.Windows.Forms.ProgressBar();
            this.PlayerHpBar = new System.Windows.Forms.ProgressBar();
            this.OpponentShield = new System.Windows.Forms.ProgressBar();
            this.PlayerShield = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.PlayerFieldCards = new System.Windows.Forms.GroupBox();
            this.GameOverBanner = new System.Windows.Forms.Panel();
            this.GameOverText = new System.Windows.Forms.Label();
            this.PlayCard2Box = new System.Windows.Forms.GroupBox();
            this.PlayCard2SwapButton = new System.Windows.Forms.Button();
            this.PlayCard2Action1Button = new System.Windows.Forms.Button();
            this.PlayCard2Action2Button = new System.Windows.Forms.Button();
            this.PlayCard1Box = new System.Windows.Forms.GroupBox();
            this.PlayCard1SwapButton = new System.Windows.Forms.Button();
            this.PlayCard1Action1Button = new System.Windows.Forms.Button();
            this.PlayCard1Action2Button = new System.Windows.Forms.Button();
            this.PlayerHandCards = new System.Windows.Forms.GroupBox();
            this.HandCard3Box = new System.Windows.Forms.GroupBox();
            this.Hand3Description2 = new System.Windows.Forms.TextBox();
            this.Hand3Action2 = new System.Windows.Forms.Label();
            this.Hand3Description1 = new System.Windows.Forms.TextBox();
            this.HandCard3SwapButton = new System.Windows.Forms.Button();
            this.Hand3Action1 = new System.Windows.Forms.Label();
            this.HandCard2Box = new System.Windows.Forms.GroupBox();
            this.Hand2Description2 = new System.Windows.Forms.TextBox();
            this.Hand2Action2 = new System.Windows.Forms.Label();
            this.Hand2Description1 = new System.Windows.Forms.TextBox();
            this.HandCard2SwapButton = new System.Windows.Forms.Button();
            this.Hand2Action1 = new System.Windows.Forms.Label();
            this.HandCard1Box = new System.Windows.Forms.GroupBox();
            this.Hand1Description2 = new System.Windows.Forms.TextBox();
            this.Hand1Description1 = new System.Windows.Forms.TextBox();
            this.Hand1Action2 = new System.Windows.Forms.Label();
            this.Hand1Action1 = new System.Windows.Forms.Label();
            this.HandCard1SwapButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.OpponentFieldCards = new System.Windows.Forms.GroupBox();
            this.OpponentPlayCard2 = new System.Windows.Forms.GroupBox();
            this.OpponentPlayCard1 = new System.Windows.Forms.GroupBox();
            this.OpponentCard1Action2 = new System.Windows.Forms.Label();
            this.OpponentCard1Action1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.OpponentCard2Action2 = new System.Windows.Forms.Label();
            this.OpponentCard2Action1 = new System.Windows.Forms.Label();
            this.PlayerFieldCards.SuspendLayout();
            this.GameOverBanner.SuspendLayout();
            this.PlayCard2Box.SuspendLayout();
            this.PlayCard1Box.SuspendLayout();
            this.PlayerHandCards.SuspendLayout();
            this.HandCard3Box.SuspendLayout();
            this.HandCard2Box.SuspendLayout();
            this.HandCard1Box.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.OpponentFieldCards.SuspendLayout();
            this.OpponentPlayCard2.SuspendLayout();
            this.OpponentPlayCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OpponentHpBar
            // 
            this.OpponentHpBar.BackColor = System.Drawing.SystemColors.Control;
            this.OpponentHpBar.ForeColor = System.Drawing.Color.LightGreen;
            this.OpponentHpBar.Location = new System.Drawing.Point(164, 317);
            this.OpponentHpBar.Name = "OpponentHpBar";
            this.OpponentHpBar.Size = new System.Drawing.Size(400, 17);
            this.OpponentHpBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.OpponentHpBar.TabIndex = 0;
            this.OpponentHpBar.Value = 75;
            // 
            // PlayerHpBar
            // 
            this.PlayerHpBar.BackColor = System.Drawing.SystemColors.Control;
            this.PlayerHpBar.ForeColor = System.Drawing.Color.LightGreen;
            this.PlayerHpBar.Location = new System.Drawing.Point(164, 343);
            this.PlayerHpBar.Name = "PlayerHpBar";
            this.PlayerHpBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PlayerHpBar.Size = new System.Drawing.Size(400, 17);
            this.PlayerHpBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.PlayerHpBar.TabIndex = 1;
            this.PlayerHpBar.Value = 75;
            // 
            // OpponentShield
            // 
            this.OpponentShield.BackColor = System.Drawing.SystemColors.Control;
            this.OpponentShield.ForeColor = System.Drawing.Color.SteelBlue;
            this.OpponentShield.Location = new System.Drawing.Point(578, 317);
            this.OpponentShield.Name = "OpponentShield";
            this.OpponentShield.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.OpponentShield.Size = new System.Drawing.Size(200, 17);
            this.OpponentShield.TabIndex = 2;
            this.OpponentShield.Value = 75;
            // 
            // PlayerShield
            // 
            this.PlayerShield.BackColor = System.Drawing.SystemColors.Control;
            this.PlayerShield.ForeColor = System.Drawing.Color.SteelBlue;
            this.PlayerShield.Location = new System.Drawing.Point(578, 343);
            this.PlayerShield.Name = "PlayerShield";
            this.PlayerShield.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PlayerShield.Size = new System.Drawing.Size(200, 17);
            this.PlayerShield.TabIndex = 3;
            this.PlayerShield.Value = 75;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGreen;
            this.label1.Location = new System.Drawing.Point(77, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Opponent HP";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PlayerFieldCards
            // 
            this.PlayerFieldCards.Controls.Add(this.GameOverBanner);
            this.PlayerFieldCards.Controls.Add(this.PlayCard2Box);
            this.PlayerFieldCards.Controls.Add(this.PlayCard1Box);
            this.PlayerFieldCards.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerFieldCards.ForeColor = System.Drawing.Color.LightGreen;
            this.PlayerFieldCards.Location = new System.Drawing.Point(61, 382);
            this.PlayerFieldCards.Name = "PlayerFieldCards";
            this.PlayerFieldCards.Size = new System.Drawing.Size(438, 288);
            this.PlayerFieldCards.TabIndex = 6;
            this.PlayerFieldCards.TabStop = false;
            this.PlayerFieldCards.Text = "Field Cards";
            // 
            // GameOverBanner
            // 
            this.GameOverBanner.BackColor = System.Drawing.Color.Silver;
            this.GameOverBanner.Controls.Add(this.GameOverText);
            this.GameOverBanner.ForeColor = System.Drawing.Color.Ivory;
            this.GameOverBanner.Location = new System.Drawing.Point(0, 157);
            this.GameOverBanner.Name = "GameOverBanner";
            this.GameOverBanner.Size = new System.Drawing.Size(438, 125);
            this.GameOverBanner.TabIndex = 12;
            this.GameOverBanner.Visible = false;
            // 
            // GameOverText
            // 
            this.GameOverText.AutoSize = true;
            this.GameOverText.Font = new System.Drawing.Font("Bahnschrift", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameOverText.ForeColor = System.Drawing.Color.ForestGreen;
            this.GameOverText.Location = new System.Drawing.Point(67, 38);
            this.GameOverText.Name = "GameOverText";
            this.GameOverText.Size = new System.Drawing.Size(284, 58);
            this.GameOverText.TabIndex = 0;
            this.GameOverText.Text = "GAME OVER";
            this.GameOverText.Visible = false;
            // 
            // PlayCard2Box
            // 
            this.PlayCard2Box.Controls.Add(this.PlayCard2SwapButton);
            this.PlayCard2Box.Controls.Add(this.PlayCard2Action1Button);
            this.PlayCard2Box.Controls.Add(this.PlayCard2Action2Button);
            this.PlayCard2Box.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayCard2Box.ForeColor = System.Drawing.Color.LightGreen;
            this.PlayCard2Box.Location = new System.Drawing.Point(204, 23);
            this.PlayCard2Box.Name = "PlayCard2Box";
            this.PlayCard2Box.Size = new System.Drawing.Size(188, 259);
            this.PlayCard2Box.TabIndex = 13;
            this.PlayCard2Box.TabStop = false;
            this.PlayCard2Box.Text = "PlayCard2";
            // 
            // PlayCard2SwapButton
            // 
            this.PlayCard2SwapButton.ForeColor = System.Drawing.Color.Black;
            this.PlayCard2SwapButton.Location = new System.Drawing.Point(47, 51);
            this.PlayCard2SwapButton.Name = "PlayCard2SwapButton";
            this.PlayCard2SwapButton.Size = new System.Drawing.Size(100, 23);
            this.PlayCard2SwapButton.TabIndex = 15;
            this.PlayCard2SwapButton.Text = "SWITCH ME!";
            this.PlayCard2SwapButton.UseVisualStyleBackColor = true;
            this.PlayCard2SwapButton.Click += new System.EventHandler(this.PlayCard2SwapButton_Click);
            // 
            // PlayCard2Action1Button
            // 
            this.PlayCard2Action1Button.ForeColor = System.Drawing.Color.Black;
            this.PlayCard2Action1Button.Location = new System.Drawing.Point(34, 143);
            this.PlayCard2Action1Button.Name = "PlayCard2Action1Button";
            this.PlayCard2Action1Button.Size = new System.Drawing.Size(129, 49);
            this.PlayCard2Action1Button.TabIndex = 15;
            this.PlayCard2Action1Button.Text = "PlayCard2 Action1Button";
            this.PlayCard2Action1Button.UseVisualStyleBackColor = true;
            this.PlayCard2Action1Button.Click += new System.EventHandler(this.PlayCard2Action1Button_Click);
            // 
            // PlayCard2Action2Button
            // 
            this.PlayCard2Action2Button.ForeColor = System.Drawing.Color.Black;
            this.PlayCard2Action2Button.Location = new System.Drawing.Point(34, 201);
            this.PlayCard2Action2Button.Name = "PlayCard2Action2Button";
            this.PlayCard2Action2Button.Size = new System.Drawing.Size(129, 49);
            this.PlayCard2Action2Button.TabIndex = 14;
            this.PlayCard2Action2Button.Text = "PlayCard2 Action2Button";
            this.PlayCard2Action2Button.UseVisualStyleBackColor = true;
            this.PlayCard2Action2Button.Click += new System.EventHandler(this.PlayCard2Action2Button_Click);
            // 
            // PlayCard1Box
            // 
            this.PlayCard1Box.Controls.Add(this.PlayCard1SwapButton);
            this.PlayCard1Box.Controls.Add(this.PlayCard1Action1Button);
            this.PlayCard1Box.Controls.Add(this.PlayCard1Action2Button);
            this.PlayCard1Box.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayCard1Box.ForeColor = System.Drawing.Color.LightGreen;
            this.PlayCard1Box.Location = new System.Drawing.Point(6, 23);
            this.PlayCard1Box.Name = "PlayCard1Box";
            this.PlayCard1Box.Size = new System.Drawing.Size(188, 259);
            this.PlayCard1Box.TabIndex = 12;
            this.PlayCard1Box.TabStop = false;
            this.PlayCard1Box.Text = "PlayCard1";
            // 
            // PlayCard1SwapButton
            // 
            this.PlayCard1SwapButton.ForeColor = System.Drawing.Color.Black;
            this.PlayCard1SwapButton.Location = new System.Drawing.Point(40, 51);
            this.PlayCard1SwapButton.Name = "PlayCard1SwapButton";
            this.PlayCard1SwapButton.Size = new System.Drawing.Size(100, 23);
            this.PlayCard1SwapButton.TabIndex = 14;
            this.PlayCard1SwapButton.Text = "SWITCH ME!";
            this.PlayCard1SwapButton.UseVisualStyleBackColor = true;
            this.PlayCard1SwapButton.Click += new System.EventHandler(this.PlayCard1SwapButton_Click);
            // 
            // PlayCard1Action1Button
            // 
            this.PlayCard1Action1Button.ForeColor = System.Drawing.Color.Black;
            this.PlayCard1Action1Button.Location = new System.Drawing.Point(30, 143);
            this.PlayCard1Action1Button.Name = "PlayCard1Action1Button";
            this.PlayCard1Action1Button.Size = new System.Drawing.Size(129, 49);
            this.PlayCard1Action1Button.TabIndex = 13;
            this.PlayCard1Action1Button.Text = "PlayCard1 Action1Button";
            this.PlayCard1Action1Button.UseVisualStyleBackColor = true;
            this.PlayCard1Action1Button.Click += new System.EventHandler(this.PlayCard1Action1Button_Click);
            // 
            // PlayCard1Action2Button
            // 
            this.PlayCard1Action2Button.ForeColor = System.Drawing.Color.Black;
            this.PlayCard1Action2Button.Location = new System.Drawing.Point(30, 201);
            this.PlayCard1Action2Button.Name = "PlayCard1Action2Button";
            this.PlayCard1Action2Button.Size = new System.Drawing.Size(129, 49);
            this.PlayCard1Action2Button.TabIndex = 12;
            this.PlayCard1Action2Button.Text = "PlayCard1 Action2Button";
            this.PlayCard1Action2Button.UseVisualStyleBackColor = true;
            this.PlayCard1Action2Button.Click += new System.EventHandler(this.PlayCard1Action2Button_Click);
            // 
            // PlayerHandCards
            // 
            this.PlayerHandCards.Controls.Add(this.HandCard3Box);
            this.PlayerHandCards.Controls.Add(this.HandCard2Box);
            this.PlayerHandCards.Controls.Add(this.HandCard1Box);
            this.PlayerHandCards.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerHandCards.ForeColor = System.Drawing.Color.LightGreen;
            this.PlayerHandCards.Location = new System.Drawing.Point(577, 382);
            this.PlayerHandCards.Name = "PlayerHandCards";
            this.PlayerHandCards.Size = new System.Drawing.Size(638, 288);
            this.PlayerHandCards.TabIndex = 7;
            this.PlayerHandCards.TabStop = false;
            this.PlayerHandCards.Text = "Hand Cards";
            // 
            // HandCard3Box
            // 
            this.HandCard3Box.Controls.Add(this.Hand3Description2);
            this.HandCard3Box.Controls.Add(this.Hand3Action2);
            this.HandCard3Box.Controls.Add(this.Hand3Description1);
            this.HandCard3Box.Controls.Add(this.HandCard3SwapButton);
            this.HandCard3Box.Controls.Add(this.Hand3Action1);
            this.HandCard3Box.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HandCard3Box.ForeColor = System.Drawing.Color.LightGreen;
            this.HandCard3Box.Location = new System.Drawing.Point(403, 22);
            this.HandCard3Box.Name = "HandCard3Box";
            this.HandCard3Box.Size = new System.Drawing.Size(188, 259);
            this.HandCard3Box.TabIndex = 17;
            this.HandCard3Box.TabStop = false;
            this.HandCard3Box.Text = "HandCard3";
            // 
            // Hand3Description2
            // 
            this.Hand3Description2.BackColor = System.Drawing.Color.Black;
            this.Hand3Description2.ForeColor = System.Drawing.Color.LightGreen;
            this.Hand3Description2.Location = new System.Drawing.Point(24, 155);
            this.Hand3Description2.MaxLength = 250;
            this.Hand3Description2.Multiline = true;
            this.Hand3Description2.Name = "Hand3Description2";
            this.Hand3Description2.ReadOnly = true;
            this.Hand3Description2.Size = new System.Drawing.Size(146, 63);
            this.Hand3Description2.TabIndex = 23;
            // 
            // Hand3Action2
            // 
            this.Hand3Action2.AutoSize = true;
            this.Hand3Action2.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hand3Action2.ForeColor = System.Drawing.Color.LightGreen;
            this.Hand3Action2.Location = new System.Drawing.Point(6, 135);
            this.Hand3Action2.Name = "Hand3Action2";
            this.Hand3Action2.Size = new System.Drawing.Size(80, 16);
            this.Hand3Action2.TabIndex = 21;
            this.Hand3Action2.Text = "Software HP";
            this.Hand3Action2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Hand3Description1
            // 
            this.Hand3Description1.BackColor = System.Drawing.Color.Black;
            this.Hand3Description1.ForeColor = System.Drawing.Color.LightGreen;
            this.Hand3Description1.Location = new System.Drawing.Point(24, 55);
            this.Hand3Description1.MaxLength = 250;
            this.Hand3Description1.Multiline = true;
            this.Hand3Description1.Name = "Hand3Description1";
            this.Hand3Description1.ReadOnly = true;
            this.Hand3Description1.Size = new System.Drawing.Size(146, 63);
            this.Hand3Description1.TabIndex = 22;
            // 
            // HandCard3SwapButton
            // 
            this.HandCard3SwapButton.ForeColor = System.Drawing.Color.Black;
            this.HandCard3SwapButton.Location = new System.Drawing.Point(58, 228);
            this.HandCard3SwapButton.Name = "HandCard3SwapButton";
            this.HandCard3SwapButton.Size = new System.Drawing.Size(75, 23);
            this.HandCard3SwapButton.TabIndex = 18;
            this.HandCard3SwapButton.Text = "SWAP";
            this.HandCard3SwapButton.UseVisualStyleBackColor = true;
            this.HandCard3SwapButton.Click += new System.EventHandler(this.HandCard3SwapButton_Click);
            // 
            // Hand3Action1
            // 
            this.Hand3Action1.AutoSize = true;
            this.Hand3Action1.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hand3Action1.ForeColor = System.Drawing.Color.LightGreen;
            this.Hand3Action1.Location = new System.Drawing.Point(6, 36);
            this.Hand3Action1.Name = "Hand3Action1";
            this.Hand3Action1.Size = new System.Drawing.Size(80, 16);
            this.Hand3Action1.TabIndex = 20;
            this.Hand3Action1.Text = "Software HP";
            this.Hand3Action1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // HandCard2Box
            // 
            this.HandCard2Box.Controls.Add(this.Hand2Description2);
            this.HandCard2Box.Controls.Add(this.Hand2Action2);
            this.HandCard2Box.Controls.Add(this.Hand2Description1);
            this.HandCard2Box.Controls.Add(this.HandCard2SwapButton);
            this.HandCard2Box.Controls.Add(this.Hand2Action1);
            this.HandCard2Box.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HandCard2Box.ForeColor = System.Drawing.Color.LightGreen;
            this.HandCard2Box.Location = new System.Drawing.Point(209, 22);
            this.HandCard2Box.Name = "HandCard2Box";
            this.HandCard2Box.Size = new System.Drawing.Size(188, 259);
            this.HandCard2Box.TabIndex = 15;
            this.HandCard2Box.TabStop = false;
            this.HandCard2Box.Text = "HandCard2";
            // 
            // Hand2Description2
            // 
            this.Hand2Description2.BackColor = System.Drawing.Color.Black;
            this.Hand2Description2.ForeColor = System.Drawing.Color.LightGreen;
            this.Hand2Description2.Location = new System.Drawing.Point(24, 155);
            this.Hand2Description2.MaxLength = 250;
            this.Hand2Description2.Multiline = true;
            this.Hand2Description2.Name = "Hand2Description2";
            this.Hand2Description2.ReadOnly = true;
            this.Hand2Description2.Size = new System.Drawing.Size(146, 63);
            this.Hand2Description2.TabIndex = 21;
            // 
            // Hand2Action2
            // 
            this.Hand2Action2.AutoSize = true;
            this.Hand2Action2.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hand2Action2.ForeColor = System.Drawing.Color.LightGreen;
            this.Hand2Action2.Location = new System.Drawing.Point(11, 135);
            this.Hand2Action2.Name = "Hand2Action2";
            this.Hand2Action2.Size = new System.Drawing.Size(80, 16);
            this.Hand2Action2.TabIndex = 19;
            this.Hand2Action2.Text = "Software HP";
            this.Hand2Action2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Hand2Description1
            // 
            this.Hand2Description1.BackColor = System.Drawing.Color.Black;
            this.Hand2Description1.ForeColor = System.Drawing.Color.LightGreen;
            this.Hand2Description1.Location = new System.Drawing.Point(24, 55);
            this.Hand2Description1.MaxLength = 250;
            this.Hand2Description1.Multiline = true;
            this.Hand2Description1.Name = "Hand2Description1";
            this.Hand2Description1.ReadOnly = true;
            this.Hand2Description1.Size = new System.Drawing.Size(146, 63);
            this.Hand2Description1.TabIndex = 20;
            // 
            // HandCard2SwapButton
            // 
            this.HandCard2SwapButton.ForeColor = System.Drawing.Color.Black;
            this.HandCard2SwapButton.Location = new System.Drawing.Point(57, 228);
            this.HandCard2SwapButton.Name = "HandCard2SwapButton";
            this.HandCard2SwapButton.Size = new System.Drawing.Size(75, 23);
            this.HandCard2SwapButton.TabIndex = 17;
            this.HandCard2SwapButton.Text = "SWAP";
            this.HandCard2SwapButton.UseVisualStyleBackColor = true;
            this.HandCard2SwapButton.Click += new System.EventHandler(this.HandCard2SwapButton_Click);
            // 
            // Hand2Action1
            // 
            this.Hand2Action1.AutoSize = true;
            this.Hand2Action1.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hand2Action1.ForeColor = System.Drawing.Color.LightGreen;
            this.Hand2Action1.Location = new System.Drawing.Point(11, 36);
            this.Hand2Action1.Name = "Hand2Action1";
            this.Hand2Action1.Size = new System.Drawing.Size(80, 16);
            this.Hand2Action1.TabIndex = 18;
            this.Hand2Action1.Text = "Software HP";
            this.Hand2Action1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // HandCard1Box
            // 
            this.HandCard1Box.Controls.Add(this.Hand1Description2);
            this.HandCard1Box.Controls.Add(this.Hand1Description1);
            this.HandCard1Box.Controls.Add(this.Hand1Action2);
            this.HandCard1Box.Controls.Add(this.Hand1Action1);
            this.HandCard1Box.Controls.Add(this.HandCard1SwapButton);
            this.HandCard1Box.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HandCard1Box.ForeColor = System.Drawing.Color.LightGreen;
            this.HandCard1Box.Location = new System.Drawing.Point(6, 23);
            this.HandCard1Box.Name = "HandCard1Box";
            this.HandCard1Box.Size = new System.Drawing.Size(188, 259);
            this.HandCard1Box.TabIndex = 14;
            this.HandCard1Box.TabStop = false;
            this.HandCard1Box.Text = "HandCard1";
            // 
            // Hand1Description2
            // 
            this.Hand1Description2.BackColor = System.Drawing.Color.Black;
            this.Hand1Description2.ForeColor = System.Drawing.Color.LightGreen;
            this.Hand1Description2.Location = new System.Drawing.Point(24, 154);
            this.Hand1Description2.MaxLength = 250;
            this.Hand1Description2.Multiline = true;
            this.Hand1Description2.Name = "Hand1Description2";
            this.Hand1Description2.ReadOnly = true;
            this.Hand1Description2.Size = new System.Drawing.Size(146, 63);
            this.Hand1Description2.TabIndex = 19;
            // 
            // Hand1Description1
            // 
            this.Hand1Description1.BackColor = System.Drawing.Color.Black;
            this.Hand1Description1.ForeColor = System.Drawing.Color.LightGreen;
            this.Hand1Description1.Location = new System.Drawing.Point(24, 54);
            this.Hand1Description1.MaxLength = 250;
            this.Hand1Description1.Multiline = true;
            this.Hand1Description1.Name = "Hand1Description1";
            this.Hand1Description1.ReadOnly = true;
            this.Hand1Description1.Size = new System.Drawing.Size(146, 63);
            this.Hand1Description1.TabIndex = 18;
            // 
            // Hand1Action2
            // 
            this.Hand1Action2.AutoSize = true;
            this.Hand1Action2.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hand1Action2.ForeColor = System.Drawing.Color.LightGreen;
            this.Hand1Action2.Location = new System.Drawing.Point(6, 134);
            this.Hand1Action2.Name = "Hand1Action2";
            this.Hand1Action2.Size = new System.Drawing.Size(80, 16);
            this.Hand1Action2.TabIndex = 17;
            this.Hand1Action2.Text = "Software HP";
            this.Hand1Action2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Hand1Action1
            // 
            this.Hand1Action1.AutoSize = true;
            this.Hand1Action1.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hand1Action1.ForeColor = System.Drawing.Color.LightGreen;
            this.Hand1Action1.Location = new System.Drawing.Point(6, 35);
            this.Hand1Action1.Name = "Hand1Action1";
            this.Hand1Action1.Size = new System.Drawing.Size(80, 16);
            this.Hand1Action1.TabIndex = 13;
            this.Hand1Action1.Text = "Software HP";
            this.Hand1Action1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // HandCard1SwapButton
            // 
            this.HandCard1SwapButton.ForeColor = System.Drawing.Color.Black;
            this.HandCard1SwapButton.Location = new System.Drawing.Point(65, 227);
            this.HandCard1SwapButton.Name = "HandCard1SwapButton";
            this.HandCard1SwapButton.Size = new System.Drawing.Size(75, 23);
            this.HandCard1SwapButton.TabIndex = 16;
            this.HandCard1SwapButton.Text = "SWAP";
            this.HandCard1SwapButton.UseVisualStyleBackColor = true;
            this.HandCard1SwapButton.Click += new System.EventHandler(this.HandCard1SwapButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.LightGreen;
            this.groupBox3.Location = new System.Drawing.Point(577, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(638, 288);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "OpponentDeck";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.ForestGreen;
            this.label5.Location = new System.Drawing.Point(23, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(362, 35);
            this.label5.TabIndex = 1;
            this.label5.Text = "Data Log: To be developed.";
            // 
            // OpponentFieldCards
            // 
            this.OpponentFieldCards.Controls.Add(this.OpponentPlayCard2);
            this.OpponentFieldCards.Controls.Add(this.OpponentPlayCard1);
            this.OpponentFieldCards.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpponentFieldCards.ForeColor = System.Drawing.Color.LightGreen;
            this.OpponentFieldCards.Location = new System.Drawing.Point(61, 12);
            this.OpponentFieldCards.Name = "OpponentFieldCards";
            this.OpponentFieldCards.Size = new System.Drawing.Size(438, 288);
            this.OpponentFieldCards.TabIndex = 8;
            this.OpponentFieldCards.TabStop = false;
            this.OpponentFieldCards.Text = "OpponentHand";
            // 
            // OpponentPlayCard2
            // 
            this.OpponentPlayCard2.Controls.Add(this.OpponentCard2Action2);
            this.OpponentPlayCard2.Controls.Add(this.OpponentCard2Action1);
            this.OpponentPlayCard2.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpponentPlayCard2.ForeColor = System.Drawing.Color.LightGreen;
            this.OpponentPlayCard2.Location = new System.Drawing.Point(204, 22);
            this.OpponentPlayCard2.Name = "OpponentPlayCard2";
            this.OpponentPlayCard2.Size = new System.Drawing.Size(188, 259);
            this.OpponentPlayCard2.TabIndex = 15;
            this.OpponentPlayCard2.TabStop = false;
            this.OpponentPlayCard2.Text = "PlayCard2";
            // 
            // OpponentPlayCard1
            // 
            this.OpponentPlayCard1.Controls.Add(this.OpponentCard1Action2);
            this.OpponentPlayCard1.Controls.Add(this.OpponentCard1Action1);
            this.OpponentPlayCard1.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpponentPlayCard1.ForeColor = System.Drawing.Color.LightGreen;
            this.OpponentPlayCard1.Location = new System.Drawing.Point(6, 22);
            this.OpponentPlayCard1.Name = "OpponentPlayCard1";
            this.OpponentPlayCard1.Size = new System.Drawing.Size(188, 259);
            this.OpponentPlayCard1.TabIndex = 14;
            this.OpponentPlayCard1.TabStop = false;
            this.OpponentPlayCard1.Text = "PlayCard1";
            // 
            // OpponentCard1Action2
            // 
            this.OpponentCard1Action2.AutoSize = true;
            this.OpponentCard1Action2.Location = new System.Drawing.Point(6, 203);
            this.OpponentCard1Action2.Name = "OpponentCard1Action2";
            this.OpponentCard1Action2.Size = new System.Drawing.Size(84, 16);
            this.OpponentCard1Action2.TabIndex = 1;
            this.OpponentCard1Action2.Text = "Card1 Action2";
            // 
            // OpponentCard1Action1
            // 
            this.OpponentCard1Action1.AutoSize = true;
            this.OpponentCard1Action1.Location = new System.Drawing.Point(6, 169);
            this.OpponentCard1Action1.Name = "OpponentCard1Action1";
            this.OpponentCard1Action1.Size = new System.Drawing.Size(81, 16);
            this.OpponentCard1Action1.TabIndex = 0;
            this.OpponentCard1Action1.Text = "Card1 Action1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightGreen;
            this.label2.Location = new System.Drawing.Point(78, 344);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Software HP";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightGreen;
            this.label3.Location = new System.Drawing.Point(784, 344);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "PlayerFirewall";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightGreen;
            this.label4.Location = new System.Drawing.Point(784, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "OpponentFirewall";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // OpponentCard2Action2
            // 
            this.OpponentCard2Action2.AutoSize = true;
            this.OpponentCard2Action2.Location = new System.Drawing.Point(6, 203);
            this.OpponentCard2Action2.Name = "OpponentCard2Action2";
            this.OpponentCard2Action2.Size = new System.Drawing.Size(84, 16);
            this.OpponentCard2Action2.TabIndex = 3;
            this.OpponentCard2Action2.Text = "Card1 Action2";
            // 
            // OpponentCard2Action1
            // 
            this.OpponentCard2Action1.AutoSize = true;
            this.OpponentCard2Action1.Location = new System.Drawing.Point(6, 169);
            this.OpponentCard2Action1.Name = "OpponentCard2Action1";
            this.OpponentCard2Action1.Size = new System.Drawing.Size(81, 16);
            this.OpponentCard2Action1.TabIndex = 2;
            this.OpponentCard2Action1.Text = "Card1 Action1";
            // 
            // PlayField
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1249, 681);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.OpponentFieldCards);
            this.Controls.Add(this.PlayerHandCards);
            this.Controls.Add(this.PlayerFieldCards);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PlayerShield);
            this.Controls.Add(this.OpponentShield);
            this.Controls.Add(this.PlayerHpBar);
            this.Controls.Add(this.OpponentHpBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PlayField";
            this.Text = "PlayField";
            this.Load += new System.EventHandler(this.PlayField_Load);
            this.PlayerFieldCards.ResumeLayout(false);
            this.GameOverBanner.ResumeLayout(false);
            this.GameOverBanner.PerformLayout();
            this.PlayCard2Box.ResumeLayout(false);
            this.PlayCard1Box.ResumeLayout(false);
            this.PlayerHandCards.ResumeLayout(false);
            this.HandCard3Box.ResumeLayout(false);
            this.HandCard3Box.PerformLayout();
            this.HandCard2Box.ResumeLayout(false);
            this.HandCard2Box.PerformLayout();
            this.HandCard1Box.ResumeLayout(false);
            this.HandCard1Box.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.OpponentFieldCards.ResumeLayout(false);
            this.OpponentPlayCard2.ResumeLayout(false);
            this.OpponentPlayCard2.PerformLayout();
            this.OpponentPlayCard1.ResumeLayout(false);
            this.OpponentPlayCard1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar OpponentHpBar;
        private System.Windows.Forms.ProgressBar PlayerHpBar;
        private System.Windows.Forms.ProgressBar OpponentShield;
        private System.Windows.Forms.ProgressBar PlayerShield;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox PlayerFieldCards;
        private System.Windows.Forms.GroupBox PlayerHandCards;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox OpponentFieldCards;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox PlayCard2Box;
        private System.Windows.Forms.GroupBox PlayCard1Box;
        private System.Windows.Forms.GroupBox HandCard3Box;
        private System.Windows.Forms.GroupBox HandCard2Box;
        private System.Windows.Forms.GroupBox HandCard1Box;
        private System.Windows.Forms.GroupBox OpponentPlayCard2;
        private System.Windows.Forms.GroupBox OpponentPlayCard1;
        private System.Windows.Forms.Button PlayCard2Action1Button;
        private System.Windows.Forms.Button PlayCard2Action2Button;
        private System.Windows.Forms.Button PlayCard1Action1Button;
        private System.Windows.Forms.Button PlayCard1Action2Button;
        private System.Windows.Forms.Button HandCard3SwapButton;
        private System.Windows.Forms.Button HandCard2SwapButton;
        private System.Windows.Forms.Button HandCard1SwapButton;
        private System.Windows.Forms.Button PlayCard1SwapButton;
        private System.Windows.Forms.Button PlayCard2SwapButton;
        private System.Windows.Forms.Panel GameOverBanner;
        private System.Windows.Forms.Label GameOverText;
        private System.Windows.Forms.Label Hand1Action1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Hand3Action2;
        private System.Windows.Forms.Label Hand3Action1;
        private System.Windows.Forms.Label Hand2Action2;
        private System.Windows.Forms.Label Hand2Action1;
        private System.Windows.Forms.TextBox Hand1Description1;
        private System.Windows.Forms.Label Hand1Action2;
        private System.Windows.Forms.TextBox Hand1Description2;
        private System.Windows.Forms.TextBox Hand3Description2;
        private System.Windows.Forms.TextBox Hand3Description1;
        private System.Windows.Forms.TextBox Hand2Description2;
        private System.Windows.Forms.TextBox Hand2Description1;
        private System.Windows.Forms.Label OpponentCard1Action2;
        private System.Windows.Forms.Label OpponentCard1Action1;
        private System.Windows.Forms.Label OpponentCard2Action2;
        private System.Windows.Forms.Label OpponentCard2Action1;
    }
}

