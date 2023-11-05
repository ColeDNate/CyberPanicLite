namespace CyberPanicLite.Forms
{
    partial class GameMenu
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
            this.PlayButton = new System.Windows.Forms.Button();
            this.manageActionsButton = new System.Windows.Forms.Button();
            this.manageCardsButton = new System.Windows.Forms.Button();
            this.DeckList = new System.Windows.Forms.ListView();
            this.deckName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.firstCard = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.softwareHP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.manageDecksButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PlayButton
            // 
            this.PlayButton.Location = new System.Drawing.Point(145, 254);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(85, 23);
            this.PlayButton.TabIndex = 0;
            this.PlayButton.Text = "Play Game";
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // manageActionsButton
            // 
            this.manageActionsButton.Location = new System.Drawing.Point(523, 102);
            this.manageActionsButton.Name = "manageActionsButton";
            this.manageActionsButton.Size = new System.Drawing.Size(98, 23);
            this.manageActionsButton.TabIndex = 1;
            this.manageActionsButton.Text = "Manage Actions";
            this.manageActionsButton.UseVisualStyleBackColor = true;
            this.manageActionsButton.Click += new System.EventHandler(this.ActionButton_Click);
            // 
            // manageCardsButton
            // 
            this.manageCardsButton.Location = new System.Drawing.Point(523, 146);
            this.manageCardsButton.Name = "manageCardsButton";
            this.manageCardsButton.Size = new System.Drawing.Size(98, 23);
            this.manageCardsButton.TabIndex = 2;
            this.manageCardsButton.Text = "Manage Cards";
            this.manageCardsButton.UseVisualStyleBackColor = true;
            this.manageCardsButton.Click += new System.EventHandler(this.manageCardsButton_Click);
            // 
            // DeckList
            // 
            this.DeckList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.deckName,
            this.firstCard,
            this.softwareHP});
            this.DeckList.FullRowSelect = true;
            this.DeckList.HideSelection = false;
            this.DeckList.Location = new System.Drawing.Point(62, 54);
            this.DeckList.Name = "DeckList";
            this.DeckList.Size = new System.Drawing.Size(246, 176);
            this.DeckList.TabIndex = 3;
            this.DeckList.UseCompatibleStateImageBehavior = false;
            this.DeckList.View = System.Windows.Forms.View.Details;
            // 
            // deckName
            // 
            this.deckName.Text = "Deck Name";
            this.deckName.Width = 75;
            // 
            // firstCard
            // 
            this.firstCard.Text = "Forerunner";
            this.firstCard.Width = 79;
            // 
            // softwareHP
            // 
            this.softwareHP.Text = "Software HP";
            this.softwareHP.Width = 87;
            // 
            // manageDecksButton
            // 
            this.manageDecksButton.Location = new System.Drawing.Point(523, 190);
            this.manageDecksButton.Name = "manageDecksButton";
            this.manageDecksButton.Size = new System.Drawing.Size(98, 23);
            this.manageDecksButton.TabIndex = 4;
            this.manageDecksButton.Text = "Manage Decks";
            this.manageDecksButton.UseVisualStyleBackColor = true;
            this.manageDecksButton.Click += new System.EventHandler(this.manageDecksButton_Click);
            // 
            // GameMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.manageDecksButton);
            this.Controls.Add(this.DeckList);
            this.Controls.Add(this.manageCardsButton);
            this.Controls.Add(this.manageActionsButton);
            this.Controls.Add(this.PlayButton);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "GameMenu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Button manageActionsButton;
        private System.Windows.Forms.Button manageCardsButton;
        private System.Windows.Forms.ListView DeckList;
        private System.Windows.Forms.ColumnHeader deckName;
        private System.Windows.Forms.ColumnHeader firstCard;
        private System.Windows.Forms.ColumnHeader softwareHP;
        private System.Windows.Forms.Button manageDecksButton;
    }
}