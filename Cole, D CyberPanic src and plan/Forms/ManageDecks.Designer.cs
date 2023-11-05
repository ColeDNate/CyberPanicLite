namespace CyberPanicLite.Forms
{
    partial class ManageDecks
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
            this.DeckList = new System.Windows.Forms.ListView();
            this.deckIDColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.deckNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.leadCardColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.deckHPColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ErrorMessageLabel = new System.Windows.Forms.Label();
            this.ClearIDButton = new System.Windows.Forms.Button();
            this.ClearAllButton = new System.Windows.Forms.Button();
            this.DeckIDLabel = new System.Windows.Forms.Label();
            this.deckIDTitle = new System.Windows.Forms.Label();
            this.EditDeckButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddDeckButton = new System.Windows.Forms.Button();
            this.CardList1 = new System.Windows.Forms.ListView();
            this.cardName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.action1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.action2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CardList2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CardList3 = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CardList4 = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CardList5 = new System.Windows.Forms.ListView();
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.card1 = new System.Windows.Forms.Label();
            this.card2 = new System.Windows.Forms.Label();
            this.card3 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.card5 = new System.Windows.Forms.Label();
            this.DeckNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DeckHPNumeric = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.DeckHPNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // DeckList
            // 
            this.DeckList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.deckIDColumn,
            this.deckNameColumn,
            this.leadCardColumn,
            this.deckHPColumn});
            this.DeckList.FullRowSelect = true;
            this.DeckList.HideSelection = false;
            this.DeckList.Location = new System.Drawing.Point(14, 16);
            this.DeckList.Name = "DeckList";
            this.DeckList.Size = new System.Drawing.Size(292, 205);
            this.DeckList.TabIndex = 0;
            this.DeckList.UseCompatibleStateImageBehavior = false;
            this.DeckList.View = System.Windows.Forms.View.Details;
            this.DeckList.SelectedIndexChanged += new System.EventHandler(this.DeckList_SelectedIndexChanged);
            // 
            // deckIDColumn
            // 
            this.deckIDColumn.Text = "Deck ID";
            this.deckIDColumn.Width = 52;
            // 
            // deckNameColumn
            // 
            this.deckNameColumn.Text = "Deck Name";
            this.deckNameColumn.Width = 88;
            // 
            // leadCardColumn
            // 
            this.leadCardColumn.Text = "Lead Card";
            this.leadCardColumn.Width = 72;
            // 
            // deckHPColumn
            // 
            this.deckHPColumn.Text = "Deck HP";
            this.deckHPColumn.Width = 57;
            // 
            // ErrorMessageLabel
            // 
            this.ErrorMessageLabel.AutoSize = true;
            this.ErrorMessageLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorMessageLabel.Location = new System.Drawing.Point(231, 420);
            this.ErrorMessageLabel.Name = "ErrorMessageLabel";
            this.ErrorMessageLabel.Size = new System.Drawing.Size(75, 13);
            this.ErrorMessageLabel.TabIndex = 30;
            this.ErrorMessageLabel.Text = "Error Message";
            this.ErrorMessageLabel.Visible = false;
            // 
            // ClearIDButton
            // 
            this.ClearIDButton.Location = new System.Drawing.Point(14, 273);
            this.ClearIDButton.Name = "ClearIDButton";
            this.ClearIDButton.Size = new System.Drawing.Size(55, 23);
            this.ClearIDButton.TabIndex = 38;
            this.ClearIDButton.Text = "Clear ID";
            this.ClearIDButton.UseVisualStyleBackColor = true;
            this.ClearIDButton.Click += new System.EventHandler(this.ClearIDButton_Click);
            // 
            // ClearAllButton
            // 
            this.ClearAllButton.Location = new System.Drawing.Point(14, 302);
            this.ClearAllButton.Name = "ClearAllButton";
            this.ClearAllButton.Size = new System.Drawing.Size(55, 23);
            this.ClearAllButton.TabIndex = 37;
            this.ClearAllButton.Text = "Clear All";
            this.ClearAllButton.UseVisualStyleBackColor = true;
            this.ClearAllButton.Click += new System.EventHandler(this.ClearAllButton_Click);
            // 
            // DeckIDLabel
            // 
            this.DeckIDLabel.AutoSize = true;
            this.DeckIDLabel.Location = new System.Drawing.Point(14, 257);
            this.DeckIDLabel.Name = "DeckIDLabel";
            this.DeckIDLabel.Size = new System.Drawing.Size(51, 13);
            this.DeckIDLabel.TabIndex = 36;
            this.DeckIDLabel.Text = "Add New";
            // 
            // deckIDTitle
            // 
            this.deckIDTitle.AutoSize = true;
            this.deckIDTitle.Location = new System.Drawing.Point(14, 238);
            this.deckIDTitle.Name = "deckIDTitle";
            this.deckIDTitle.Size = new System.Drawing.Size(47, 13);
            this.deckIDTitle.TabIndex = 35;
            this.deckIDTitle.Text = "Deck ID";
            // 
            // EditDeckButton
            // 
            this.EditDeckButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.EditDeckButton.Location = new System.Drawing.Point(129, 415);
            this.EditDeckButton.Name = "EditDeckButton";
            this.EditDeckButton.Size = new System.Drawing.Size(75, 23);
            this.EditDeckButton.TabIndex = 32;
            this.EditDeckButton.Text = "Edit Deck";
            this.EditDeckButton.UseVisualStyleBackColor = false;
            this.EditDeckButton.Click += new System.EventHandler(this.EditDeckButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.DeleteButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.DeleteButton.FlatAppearance.BorderSize = 2;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DeleteButton.Location = new System.Drawing.Point(706, 415);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 34;
            this.DeleteButton.Text = "DELETE";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AddDeckButton
            // 
            this.AddDeckButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.AddDeckButton.Location = new System.Drawing.Point(30, 415);
            this.AddDeckButton.Name = "AddDeckButton";
            this.AddDeckButton.Size = new System.Drawing.Size(75, 23);
            this.AddDeckButton.TabIndex = 31;
            this.AddDeckButton.Text = "Add Deck";
            this.AddDeckButton.UseVisualStyleBackColor = false;
            this.AddDeckButton.Click += new System.EventHandler(this.AddDeckButton_Click);
            // 
            // CardList1
            // 
            this.CardList1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cardName,
            this.action1,
            this.action2});
            this.CardList1.FullRowSelect = true;
            this.CardList1.HideSelection = false;
            this.CardList1.Location = new System.Drawing.Point(331, 66);
            this.CardList1.Name = "CardList1";
            this.CardList1.Size = new System.Drawing.Size(208, 155);
            this.CardList1.TabIndex = 39;
            this.CardList1.UseCompatibleStateImageBehavior = false;
            this.CardList1.View = System.Windows.Forms.View.Details;
            // 
            // cardName
            // 
            this.cardName.Text = "Card Name";
            this.cardName.Width = 73;
            // 
            // action1
            // 
            this.action1.Text = "Action 1";
            this.action1.Width = 65;
            // 
            // action2
            // 
            this.action2.Text = "Action 2";
            this.action2.Width = 59;
            // 
            // CardList2
            // 
            this.CardList2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.CardList2.FullRowSelect = true;
            this.CardList2.HideSelection = false;
            this.CardList2.Location = new System.Drawing.Point(573, 66);
            this.CardList2.Name = "CardList2";
            this.CardList2.Size = new System.Drawing.Size(208, 155);
            this.CardList2.TabIndex = 40;
            this.CardList2.UseCompatibleStateImageBehavior = false;
            this.CardList2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Card Name";
            this.columnHeader1.Width = 73;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Action 1";
            this.columnHeader2.Width = 65;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Action 2";
            this.columnHeader3.Width = 59;
            // 
            // CardList3
            // 
            this.CardList3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.CardList3.FullRowSelect = true;
            this.CardList3.HideSelection = false;
            this.CardList3.Location = new System.Drawing.Point(98, 254);
            this.CardList3.Name = "CardList3";
            this.CardList3.Size = new System.Drawing.Size(208, 155);
            this.CardList3.TabIndex = 41;
            this.CardList3.UseCompatibleStateImageBehavior = false;
            this.CardList3.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Card Name";
            this.columnHeader4.Width = 73;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Action 1";
            this.columnHeader5.Width = 65;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Action 2";
            this.columnHeader6.Width = 59;
            // 
            // CardList4
            // 
            this.CardList4.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.CardList4.FullRowSelect = true;
            this.CardList4.HideSelection = false;
            this.CardList4.Location = new System.Drawing.Point(334, 254);
            this.CardList4.Name = "CardList4";
            this.CardList4.Size = new System.Drawing.Size(208, 155);
            this.CardList4.TabIndex = 42;
            this.CardList4.UseCompatibleStateImageBehavior = false;
            this.CardList4.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Card Name";
            this.columnHeader7.Width = 73;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Action 1";
            this.columnHeader8.Width = 65;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Action 2";
            this.columnHeader9.Width = 59;
            // 
            // CardList5
            // 
            this.CardList5.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.CardList5.FullRowSelect = true;
            this.CardList5.HideSelection = false;
            this.CardList5.Location = new System.Drawing.Point(573, 254);
            this.CardList5.Name = "CardList5";
            this.CardList5.Size = new System.Drawing.Size(208, 155);
            this.CardList5.TabIndex = 43;
            this.CardList5.UseCompatibleStateImageBehavior = false;
            this.CardList5.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Card Name";
            this.columnHeader10.Width = 73;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Action 1";
            this.columnHeader11.Width = 65;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Action 2";
            this.columnHeader12.Width = 59;
            // 
            // card1
            // 
            this.card1.AutoSize = true;
            this.card1.Location = new System.Drawing.Point(331, 47);
            this.card1.Name = "card1";
            this.card1.Size = new System.Drawing.Size(38, 13);
            this.card1.TabIndex = 44;
            this.card1.Text = "Card 1";
            // 
            // card2
            // 
            this.card2.AutoSize = true;
            this.card2.Location = new System.Drawing.Point(570, 50);
            this.card2.Name = "card2";
            this.card2.Size = new System.Drawing.Size(38, 13);
            this.card2.TabIndex = 45;
            this.card2.Text = "Card 2";
            // 
            // card3
            // 
            this.card3.AutoSize = true;
            this.card3.Location = new System.Drawing.Point(95, 238);
            this.card3.Name = "card3";
            this.card3.Size = new System.Drawing.Size(38, 13);
            this.card3.TabIndex = 46;
            this.card3.Text = "Card 3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(331, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "Card 4";
            // 
            // card5
            // 
            this.card5.AutoSize = true;
            this.card5.Location = new System.Drawing.Point(570, 238);
            this.card5.Name = "card5";
            this.card5.Size = new System.Drawing.Size(38, 13);
            this.card5.TabIndex = 48;
            this.card5.Text = "Card 5";
            // 
            // DeckNameTextBox
            // 
            this.DeckNameTextBox.Location = new System.Drawing.Point(401, 16);
            this.DeckNameTextBox.Name = "DeckNameTextBox";
            this.DeckNameTextBox.Size = new System.Drawing.Size(138, 20);
            this.DeckNameTextBox.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(328, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 50;
            this.label1.Text = "Deck Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(570, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 52;
            this.label2.Text = "Deck HP:";
            // 
            // DeckHPNumeric
            // 
            this.DeckHPNumeric.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.DeckHPNumeric.Location = new System.Drawing.Point(630, 17);
            this.DeckHPNumeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.DeckHPNumeric.Name = "DeckHPNumeric";
            this.DeckHPNumeric.Size = new System.Drawing.Size(53, 20);
            this.DeckHPNumeric.TabIndex = 53;
            this.DeckHPNumeric.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // ManageDecks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DeckHPNumeric);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeckNameTextBox);
            this.Controls.Add(this.card5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.card3);
            this.Controls.Add(this.card2);
            this.Controls.Add(this.card1);
            this.Controls.Add(this.CardList5);
            this.Controls.Add(this.CardList4);
            this.Controls.Add(this.CardList3);
            this.Controls.Add(this.CardList2);
            this.Controls.Add(this.CardList1);
            this.Controls.Add(this.ErrorMessageLabel);
            this.Controls.Add(this.ClearIDButton);
            this.Controls.Add(this.ClearAllButton);
            this.Controls.Add(this.DeckIDLabel);
            this.Controls.Add(this.deckIDTitle);
            this.Controls.Add(this.EditDeckButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddDeckButton);
            this.Controls.Add(this.DeckList);
            this.Name = "ManageDecks";
            this.Text = "ManageDecks";
            ((System.ComponentModel.ISupportInitialize)(this.DeckHPNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView DeckList;
        private System.Windows.Forms.Label ErrorMessageLabel;
        private System.Windows.Forms.Button ClearIDButton;
        private System.Windows.Forms.Button ClearAllButton;
        private System.Windows.Forms.Label DeckIDLabel;
        private System.Windows.Forms.Label deckIDTitle;
        private System.Windows.Forms.Button EditDeckButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button AddDeckButton;
        private System.Windows.Forms.ColumnHeader deckIDColumn;
        private System.Windows.Forms.ColumnHeader deckNameColumn;
        private System.Windows.Forms.ColumnHeader leadCardColumn;
        private System.Windows.Forms.ListView CardList1;
        private System.Windows.Forms.ColumnHeader cardName;
        private System.Windows.Forms.ColumnHeader action1;
        private System.Windows.Forms.ColumnHeader action2;
        private System.Windows.Forms.ColumnHeader deckHPColumn;
        private System.Windows.Forms.ListView CardList2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView CardList3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ListView CardList4;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ListView CardList5;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.Label card1;
        private System.Windows.Forms.Label card2;
        private System.Windows.Forms.Label card3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label card5;
        private System.Windows.Forms.TextBox DeckNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown DeckHPNumeric;
    }
}