namespace CyberPanicLite.Forms
{
    partial class ManageCards
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
            this.CardList = new System.Windows.Forms.ListView();
            this.cardIDColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cardNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cardDescriptionColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cardTypeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.action1Column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.action2Column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.actionBox1 = new System.Windows.Forms.GroupBox();
            this.Action1NameLabel = new System.Windows.Forms.Label();
            this.Action1EffectLabel = new System.Windows.Forms.Label();
            this.Action1TargetLabel = new System.Windows.Forms.Label();
            this.Action1CooldownLabel = new System.Windows.Forms.Label();
            this.Action1ValueLabel = new System.Windows.Forms.Label();
            this.Action1DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.actionBox2 = new System.Windows.Forms.GroupBox();
            this.Action2NameLabel = new System.Windows.Forms.Label();
            this.Action2DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.Action2EffectLabel = new System.Windows.Forms.Label();
            this.Action2ValueLabel = new System.Windows.Forms.Label();
            this.Action2TargetLabel = new System.Windows.Forms.Label();
            this.Action2CooldownLabel = new System.Windows.Forms.Label();
            this.ClearIDButton = new System.Windows.Forms.Button();
            this.ClearAllButton = new System.Windows.Forms.Button();
            this.CardIDLabel = new System.Windows.Forms.Label();
            this.CardIDHeader = new System.Windows.Forms.Label();
            this.EditCardButton = new System.Windows.Forms.Button();
            this.AddCardButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ActionList1 = new System.Windows.Forms.ListView();
            this.actionName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.effectType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.value = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cooldown = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ActionList2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CardNameInput = new System.Windows.Forms.TextBox();
            this.CardDescriptionInput = new System.Windows.Forms.TextBox();
            this.CardTypeBox = new System.Windows.Forms.ComboBox();
            this.cardTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ErrorMessageLabel = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.effectTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.actionBox1.SuspendLayout();
            this.actionBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cardTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.effectTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CardList
            // 
            this.CardList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cardIDColumn,
            this.cardNameColumn,
            this.cardDescriptionColumn,
            this.cardTypeColumn,
            this.action1Column,
            this.action2Column});
            this.CardList.FullRowSelect = true;
            this.CardList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.CardList.HideSelection = false;
            this.CardList.Location = new System.Drawing.Point(12, 12);
            this.CardList.Name = "CardList";
            this.CardList.Size = new System.Drawing.Size(570, 283);
            this.CardList.TabIndex = 0;
            this.CardList.UseCompatibleStateImageBehavior = false;
            this.CardList.View = System.Windows.Forms.View.Details;
            this.CardList.SelectedIndexChanged += new System.EventHandler(this.CardList_SelectedIndexChanged);
            // 
            // cardIDColumn
            // 
            this.cardIDColumn.Text = "Card ID";
            this.cardIDColumn.Width = 51;
            // 
            // cardNameColumn
            // 
            this.cardNameColumn.Text = "Card Name";
            this.cardNameColumn.Width = 75;
            // 
            // cardDescriptionColumn
            // 
            this.cardDescriptionColumn.Text = "Card Description";
            this.cardDescriptionColumn.Width = 211;
            // 
            // cardTypeColumn
            // 
            this.cardTypeColumn.Text = "Card Type";
            this.cardTypeColumn.Width = 72;
            // 
            // action1Column
            // 
            this.action1Column.Text = "Action 1";
            this.action1Column.Width = 79;
            // 
            // action2Column
            // 
            this.action2Column.Text = "Action 2";
            this.action2Column.Width = 78;
            // 
            // actionBox1
            // 
            this.actionBox1.Controls.Add(this.Action1NameLabel);
            this.actionBox1.Controls.Add(this.Action1EffectLabel);
            this.actionBox1.Controls.Add(this.Action1TargetLabel);
            this.actionBox1.Controls.Add(this.Action1CooldownLabel);
            this.actionBox1.Controls.Add(this.Action1ValueLabel);
            this.actionBox1.Controls.Add(this.Action1DescriptionTextBox);
            this.actionBox1.Location = new System.Drawing.Point(588, 12);
            this.actionBox1.Name = "actionBox1";
            this.actionBox1.Size = new System.Drawing.Size(200, 139);
            this.actionBox1.TabIndex = 1;
            this.actionBox1.TabStop = false;
            this.actionBox1.Text = "Action 1";
            // 
            // Action1NameLabel
            // 
            this.Action1NameLabel.AutoSize = true;
            this.Action1NameLabel.Location = new System.Drawing.Point(9, 20);
            this.Action1NameLabel.Name = "Action1NameLabel";
            this.Action1NameLabel.Size = new System.Drawing.Size(68, 13);
            this.Action1NameLabel.TabIndex = 5;
            this.Action1NameLabel.Text = "Action Name";
            // 
            // Action1EffectLabel
            // 
            this.Action1EffectLabel.AutoSize = true;
            this.Action1EffectLabel.Location = new System.Drawing.Point(6, 97);
            this.Action1EffectLabel.Name = "Action1EffectLabel";
            this.Action1EffectLabel.Size = new System.Drawing.Size(72, 13);
            this.Action1EffectLabel.TabIndex = 4;
            this.Action1EffectLabel.Text = "Effect: Attack";
            // 
            // Action1TargetLabel
            // 
            this.Action1TargetLabel.AutoSize = true;
            this.Action1TargetLabel.Location = new System.Drawing.Point(99, 97);
            this.Action1TargetLabel.Name = "Action1TargetLabel";
            this.Action1TargetLabel.Size = new System.Drawing.Size(76, 13);
            this.Action1TargetLabel.TabIndex = 3;
            this.Action1TargetLabel.Text = "Target: Enemy";
            // 
            // Action1CooldownLabel
            // 
            this.Action1CooldownLabel.AutoSize = true;
            this.Action1CooldownLabel.Location = new System.Drawing.Point(99, 119);
            this.Action1CooldownLabel.Name = "Action1CooldownLabel";
            this.Action1CooldownLabel.Size = new System.Drawing.Size(66, 13);
            this.Action1CooldownLabel.TabIndex = 2;
            this.Action1CooldownLabel.Text = "Cooldown: 0";
            // 
            // Action1ValueLabel
            // 
            this.Action1ValueLabel.AutoSize = true;
            this.Action1ValueLabel.Location = new System.Drawing.Point(6, 119);
            this.Action1ValueLabel.Name = "Action1ValueLabel";
            this.Action1ValueLabel.Size = new System.Drawing.Size(55, 13);
            this.Action1ValueLabel.TabIndex = 1;
            this.Action1ValueLabel.Text = "Value:    0";
            // 
            // Action1DescriptionTextBox
            // 
            this.Action1DescriptionTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.Action1DescriptionTextBox.Location = new System.Drawing.Point(6, 36);
            this.Action1DescriptionTextBox.Multiline = true;
            this.Action1DescriptionTextBox.Name = "Action1DescriptionTextBox";
            this.Action1DescriptionTextBox.ReadOnly = true;
            this.Action1DescriptionTextBox.Size = new System.Drawing.Size(188, 58);
            this.Action1DescriptionTextBox.TabIndex = 0;
            this.Action1DescriptionTextBox.Text = "Action Description....";
            // 
            // actionBox2
            // 
            this.actionBox2.Controls.Add(this.Action2NameLabel);
            this.actionBox2.Controls.Add(this.Action2DescriptionTextBox);
            this.actionBox2.Controls.Add(this.Action2EffectLabel);
            this.actionBox2.Controls.Add(this.Action2ValueLabel);
            this.actionBox2.Controls.Add(this.Action2TargetLabel);
            this.actionBox2.Controls.Add(this.Action2CooldownLabel);
            this.actionBox2.Location = new System.Drawing.Point(588, 157);
            this.actionBox2.Name = "actionBox2";
            this.actionBox2.Size = new System.Drawing.Size(200, 139);
            this.actionBox2.TabIndex = 2;
            this.actionBox2.TabStop = false;
            this.actionBox2.Text = "Action 2";
            // 
            // Action2NameLabel
            // 
            this.Action2NameLabel.AutoSize = true;
            this.Action2NameLabel.Location = new System.Drawing.Point(9, 20);
            this.Action2NameLabel.Name = "Action2NameLabel";
            this.Action2NameLabel.Size = new System.Drawing.Size(68, 13);
            this.Action2NameLabel.TabIndex = 11;
            this.Action2NameLabel.Text = "Action Name";
            // 
            // Action2DescriptionTextBox
            // 
            this.Action2DescriptionTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.Action2DescriptionTextBox.Location = new System.Drawing.Point(6, 36);
            this.Action2DescriptionTextBox.Multiline = true;
            this.Action2DescriptionTextBox.Name = "Action2DescriptionTextBox";
            this.Action2DescriptionTextBox.ReadOnly = true;
            this.Action2DescriptionTextBox.Size = new System.Drawing.Size(188, 58);
            this.Action2DescriptionTextBox.TabIndex = 6;
            this.Action2DescriptionTextBox.Text = "Action Description....";
            // 
            // Action2EffectLabel
            // 
            this.Action2EffectLabel.AutoSize = true;
            this.Action2EffectLabel.Location = new System.Drawing.Point(6, 97);
            this.Action2EffectLabel.Name = "Action2EffectLabel";
            this.Action2EffectLabel.Size = new System.Drawing.Size(72, 13);
            this.Action2EffectLabel.TabIndex = 10;
            this.Action2EffectLabel.Text = "Effect: Attack";
            // 
            // Action2ValueLabel
            // 
            this.Action2ValueLabel.AutoSize = true;
            this.Action2ValueLabel.Location = new System.Drawing.Point(6, 119);
            this.Action2ValueLabel.Name = "Action2ValueLabel";
            this.Action2ValueLabel.Size = new System.Drawing.Size(55, 13);
            this.Action2ValueLabel.TabIndex = 7;
            this.Action2ValueLabel.Text = "Value:    0";
            // 
            // Action2TargetLabel
            // 
            this.Action2TargetLabel.AutoSize = true;
            this.Action2TargetLabel.Location = new System.Drawing.Point(99, 97);
            this.Action2TargetLabel.Name = "Action2TargetLabel";
            this.Action2TargetLabel.Size = new System.Drawing.Size(76, 13);
            this.Action2TargetLabel.TabIndex = 9;
            this.Action2TargetLabel.Text = "Target: Enemy";
            // 
            // Action2CooldownLabel
            // 
            this.Action2CooldownLabel.AutoSize = true;
            this.Action2CooldownLabel.Location = new System.Drawing.Point(99, 119);
            this.Action2CooldownLabel.Name = "Action2CooldownLabel";
            this.Action2CooldownLabel.Size = new System.Drawing.Size(66, 13);
            this.Action2CooldownLabel.TabIndex = 8;
            this.Action2CooldownLabel.Text = "Cooldown: 0";
            // 
            // ClearIDButton
            // 
            this.ClearIDButton.Location = new System.Drawing.Point(14, 344);
            this.ClearIDButton.Name = "ClearIDButton";
            this.ClearIDButton.Size = new System.Drawing.Size(55, 23);
            this.ClearIDButton.TabIndex = 29;
            this.ClearIDButton.Text = "Clear ID";
            this.ClearIDButton.UseVisualStyleBackColor = true;
            this.ClearIDButton.Click += new System.EventHandler(this.ClearIDButton_Click);
            // 
            // ClearAllButton
            // 
            this.ClearAllButton.Location = new System.Drawing.Point(14, 373);
            this.ClearAllButton.Name = "ClearAllButton";
            this.ClearAllButton.Size = new System.Drawing.Size(55, 23);
            this.ClearAllButton.TabIndex = 28;
            this.ClearAllButton.Text = "Clear All";
            this.ClearAllButton.UseVisualStyleBackColor = true;
            this.ClearAllButton.Click += new System.EventHandler(this.ClearAllButton_Click);
            // 
            // CardIDLabel
            // 
            this.CardIDLabel.AutoSize = true;
            this.CardIDLabel.Location = new System.Drawing.Point(17, 323);
            this.CardIDLabel.Name = "CardIDLabel";
            this.CardIDLabel.Size = new System.Drawing.Size(51, 13);
            this.CardIDLabel.TabIndex = 27;
            this.CardIDLabel.Text = "Add New";
            // 
            // CardIDHeader
            // 
            this.CardIDHeader.AutoSize = true;
            this.CardIDHeader.Location = new System.Drawing.Point(17, 302);
            this.CardIDHeader.Name = "CardIDHeader";
            this.CardIDHeader.Size = new System.Drawing.Size(43, 13);
            this.CardIDHeader.TabIndex = 26;
            this.CardIDHeader.Text = "Card ID";
            // 
            // EditCardButton
            // 
            this.EditCardButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.EditCardButton.Location = new System.Drawing.Point(113, 417);
            this.EditCardButton.Name = "EditCardButton";
            this.EditCardButton.Size = new System.Drawing.Size(75, 23);
            this.EditCardButton.TabIndex = 23;
            this.EditCardButton.Text = "Edit Card";
            this.EditCardButton.UseVisualStyleBackColor = false;
            this.EditCardButton.Click += new System.EventHandler(this.EditCardButton_Click);
            // 
            // AddCardButton
            // 
            this.AddCardButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.AddCardButton.Location = new System.Drawing.Point(14, 417);
            this.AddCardButton.Name = "AddCardButton";
            this.AddCardButton.Size = new System.Drawing.Size(75, 23);
            this.AddCardButton.TabIndex = 22;
            this.AddCardButton.Text = "Add Card";
            this.AddCardButton.UseVisualStyleBackColor = false;
            this.AddCardButton.Click += new System.EventHandler(this.AddCardButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ActionList1);
            this.groupBox3.Controls.Add(this.ActionList2);
            this.groupBox3.Controls.Add(this.CardNameInput);
            this.groupBox3.Controls.Add(this.CardDescriptionInput);
            this.groupBox3.Controls.Add(this.CardTypeBox);
            this.groupBox3.Location = new System.Drawing.Point(81, 302);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(707, 109);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add or Edit";
            // 
            // ActionList1
            // 
            this.ActionList1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.actionName,
            this.effectType,
            this.value,
            this.cooldown});
            this.ActionList1.FullRowSelect = true;
            this.ActionList1.HideSelection = false;
            this.ActionList1.Location = new System.Drawing.Point(284, 18);
            this.ActionList1.Name = "ActionList1";
            this.ActionList1.Size = new System.Drawing.Size(205, 85);
            this.ActionList1.TabIndex = 0;
            this.ActionList1.UseCompatibleStateImageBehavior = false;
            this.ActionList1.View = System.Windows.Forms.View.Details;
            // 
            // actionName
            // 
            this.actionName.Text = "Name";
            this.actionName.Width = 55;
            // 
            // effectType
            // 
            this.effectType.Text = "Effect";
            this.effectType.Width = 55;
            // 
            // value
            // 
            this.value.Text = "Value";
            this.value.Width = 39;
            // 
            // cooldown
            // 
            this.cooldown.Text = "CD";
            this.cooldown.Width = 34;
            // 
            // ActionList2
            // 
            this.ActionList2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.ActionList2.FullRowSelect = true;
            this.ActionList2.HideSelection = false;
            this.ActionList2.Location = new System.Drawing.Point(496, 18);
            this.ActionList2.Name = "ActionList2";
            this.ActionList2.Size = new System.Drawing.Size(205, 85);
            this.ActionList2.TabIndex = 1;
            this.ActionList2.UseCompatibleStateImageBehavior = false;
            this.ActionList2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 55;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Effect";
            this.columnHeader2.Width = 55;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Value";
            this.columnHeader3.Width = 39;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "CD";
            this.columnHeader4.Width = 34;
            // 
            // CardNameInput
            // 
            this.CardNameInput.Location = new System.Drawing.Point(6, 18);
            this.CardNameInput.MaxLength = 20;
            this.CardNameInput.Name = "CardNameInput";
            this.CardNameInput.Size = new System.Drawing.Size(133, 20);
            this.CardNameInput.TabIndex = 8;
            this.CardNameInput.Text = "Card Name";
            // 
            // CardDescriptionInput
            // 
            this.CardDescriptionInput.Location = new System.Drawing.Point(6, 44);
            this.CardDescriptionInput.Multiline = true;
            this.CardDescriptionInput.Name = "CardDescriptionInput";
            this.CardDescriptionInput.Size = new System.Drawing.Size(272, 59);
            this.CardDescriptionInput.TabIndex = 7;
            this.CardDescriptionInput.Text = "Description";
            // 
            // CardTypeBox
            // 
            this.CardTypeBox.DataSource = this.cardTypeBindingSource;
            this.CardTypeBox.FormattingEnabled = true;
            this.CardTypeBox.Location = new System.Drawing.Point(175, 18);
            this.CardTypeBox.Name = "CardTypeBox";
            this.CardTypeBox.Size = new System.Drawing.Size(103, 21);
            this.CardTypeBox.TabIndex = 10;
            // 
            // cardTypeBindingSource
            // 
            this.cardTypeBindingSource.DataSource = typeof(CyberPanicLite.Classes.Enumerated.CardType);
            // 
            // ErrorMessageLabel
            // 
            this.ErrorMessageLabel.AutoSize = true;
            this.ErrorMessageLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorMessageLabel.Location = new System.Drawing.Point(215, 422);
            this.ErrorMessageLabel.Name = "ErrorMessageLabel";
            this.ErrorMessageLabel.Size = new System.Drawing.Size(75, 13);
            this.ErrorMessageLabel.TabIndex = 21;
            this.ErrorMessageLabel.Text = "Error Message";
            this.ErrorMessageLabel.Visible = false;
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.DeleteButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.DeleteButton.FlatAppearance.BorderSize = 2;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DeleteButton.Location = new System.Drawing.Point(690, 417);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 25;
            this.DeleteButton.Text = "DELETE";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // effectTypeBindingSource
            // 
            this.effectTypeBindingSource.DataSource = typeof(CyberPanicLite.Classes.Enumerated.EffectType);
            // 
            // ManageCards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ErrorMessageLabel);
            this.Controls.Add(this.ClearIDButton);
            this.Controls.Add(this.actionBox2);
            this.Controls.Add(this.ClearAllButton);
            this.Controls.Add(this.actionBox1);
            this.Controls.Add(this.CardIDLabel);
            this.Controls.Add(this.CardList);
            this.Controls.Add(this.CardIDHeader);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.EditCardButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddCardButton);
            this.Name = "ManageCards";
            this.Text = "ManageCards";
            this.actionBox1.ResumeLayout(false);
            this.actionBox1.PerformLayout();
            this.actionBox2.ResumeLayout(false);
            this.actionBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cardTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.effectTypeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView CardList;
        private System.Windows.Forms.ColumnHeader cardIDColumn;
        private System.Windows.Forms.ColumnHeader cardNameColumn;
        private System.Windows.Forms.ColumnHeader cardDescriptionColumn;
        private System.Windows.Forms.ColumnHeader cardTypeColumn;
        private System.Windows.Forms.ColumnHeader action1Column;
        private System.Windows.Forms.ColumnHeader action2Column;
        private System.Windows.Forms.GroupBox actionBox1;
        private System.Windows.Forms.GroupBox actionBox2;
        private System.Windows.Forms.TextBox Action1DescriptionTextBox;
        private System.Windows.Forms.Button ClearIDButton;
        private System.Windows.Forms.Button ClearAllButton;
        private System.Windows.Forms.Label CardIDLabel;
        private System.Windows.Forms.Label CardIDHeader;
        private System.Windows.Forms.Button EditCardButton;
        private System.Windows.Forms.Button AddCardButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label ErrorMessageLabel;
        private System.Windows.Forms.TextBox CardNameInput;
        private System.Windows.Forms.TextBox CardDescriptionInput;
        private System.Windows.Forms.ComboBox CardTypeBox;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.ListView ActionList1;
        private System.Windows.Forms.ColumnHeader actionName;
        private System.Windows.Forms.ColumnHeader effectType;
        private System.Windows.Forms.ColumnHeader value;
        private System.Windows.Forms.ColumnHeader cooldown;
        private System.Windows.Forms.ListView ActionList2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label Action1ValueLabel;
        private System.Windows.Forms.Label Action1EffectLabel;
        private System.Windows.Forms.Label Action1TargetLabel;
        private System.Windows.Forms.Label Action1CooldownLabel;
        private System.Windows.Forms.Label Action1NameLabel;
        private System.Windows.Forms.Label Action2NameLabel;
        private System.Windows.Forms.TextBox Action2DescriptionTextBox;
        private System.Windows.Forms.Label Action2EffectLabel;
        private System.Windows.Forms.Label Action2ValueLabel;
        private System.Windows.Forms.Label Action2TargetLabel;
        private System.Windows.Forms.Label Action2CooldownLabel;
        private System.Windows.Forms.BindingSource cardTypeBindingSource;
        private System.Windows.Forms.BindingSource effectTypeBindingSource;
    }
}