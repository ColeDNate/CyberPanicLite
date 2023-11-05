namespace CyberPanicLite.Forms
{
    partial class ManageActions
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
            this.AddActionButton = new System.Windows.Forms.Button();
            this.EditActionButton = new System.Windows.Forms.Button();
            this.ActionList = new System.Windows.Forms.ListView();
            this.ActionID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ActionName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ActionDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Target = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EffectType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Value = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cooldown = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ActionDescriptionInput = new System.Windows.Forms.TextBox();
            this.ActionNameInput = new System.Windows.Forms.TextBox();
            this.EffectTypeBox = new System.Windows.Forms.ComboBox();
            this.effectTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ValueNumeric = new System.Windows.Forms.NumericUpDown();
            this.CooldownNumeric = new System.Windows.Forms.NumericUpDown();
            this.TargetEnemyRadio = new System.Windows.Forms.RadioButton();
            this.TargetSelfRadio = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ErrorMessageLabel = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ActionIDLabel = new System.Windows.Forms.Label();
            this.ClearAllButton = new System.Windows.Forms.Button();
            this.effectTypeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ClearIDButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.effectTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValueNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CooldownNumeric)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.effectTypeBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddActionButton
            // 
            this.AddActionButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.AddActionButton.Location = new System.Drawing.Point(93, 415);
            this.AddActionButton.Name = "AddActionButton";
            this.AddActionButton.Size = new System.Drawing.Size(75, 23);
            this.AddActionButton.TabIndex = 2;
            this.AddActionButton.Text = "Add Action";
            this.AddActionButton.UseVisualStyleBackColor = false;
            this.AddActionButton.Click += new System.EventHandler(this.AddActionButton_Click);
            // 
            // EditActionButton
            // 
            this.EditActionButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.EditActionButton.Location = new System.Drawing.Point(192, 415);
            this.EditActionButton.Name = "EditActionButton";
            this.EditActionButton.Size = new System.Drawing.Size(75, 23);
            this.EditActionButton.TabIndex = 3;
            this.EditActionButton.Text = "Edit Action";
            this.EditActionButton.UseVisualStyleBackColor = false;
            this.EditActionButton.Click += new System.EventHandler(this.EditActionButton_Click);
            // 
            // ActionList
            // 
            this.ActionList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ActionID,
            this.ActionName,
            this.ActionDescription,
            this.Target,
            this.EffectType,
            this.Value,
            this.Cooldown});
            this.ActionList.FullRowSelect = true;
            this.ActionList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ActionList.HideSelection = false;
            this.ActionList.Location = new System.Drawing.Point(12, 12);
            this.ActionList.Name = "ActionList";
            this.ActionList.Size = new System.Drawing.Size(745, 324);
            this.ActionList.TabIndex = 5;
            this.ActionList.UseCompatibleStateImageBehavior = false;
            this.ActionList.View = System.Windows.Forms.View.Details;
            this.ActionList.SelectedIndexChanged += new System.EventHandler(this.ActionList_SelectedIndexChanged);
            // 
            // ActionID
            // 
            this.ActionID.Text = "Action ID";
            // 
            // ActionName
            // 
            this.ActionName.Text = "Action Name";
            this.ActionName.Width = 119;
            // 
            // ActionDescription
            // 
            this.ActionDescription.Text = "Action Description";
            this.ActionDescription.Width = 268;
            // 
            // Target
            // 
            this.Target.Text = "Target";
            this.Target.Width = 96;
            // 
            // EffectType
            // 
            this.EffectType.Text = "Effect Type";
            this.EffectType.Width = 90;
            // 
            // Value
            // 
            this.Value.Text = "Value";
            this.Value.Width = 43;
            // 
            // Cooldown
            // 
            this.Cooldown.Text = "Cooldown";
            // 
            // ActionDescriptionInput
            // 
            this.ActionDescriptionInput.Location = new System.Drawing.Point(122, 18);
            this.ActionDescriptionInput.Name = "ActionDescriptionInput";
            this.ActionDescriptionInput.Size = new System.Drawing.Size(272, 20);
            this.ActionDescriptionInput.TabIndex = 7;
            this.ActionDescriptionInput.Text = "Description";
            // 
            // ActionNameInput
            // 
            this.ActionNameInput.Location = new System.Drawing.Point(8, 18);
            this.ActionNameInput.MaxLength = 20;
            this.ActionNameInput.Name = "ActionNameInput";
            this.ActionNameInput.Size = new System.Drawing.Size(108, 20);
            this.ActionNameInput.TabIndex = 8;
            this.ActionNameInput.Text = "Action Name";
            // 
            // EffectTypeBox
            // 
            this.EffectTypeBox.DataSource = this.effectTypeBindingSource;
            this.EffectTypeBox.FormattingEnabled = true;
            this.EffectTypeBox.Location = new System.Drawing.Point(497, 17);
            this.EffectTypeBox.Name = "EffectTypeBox";
            this.EffectTypeBox.Size = new System.Drawing.Size(89, 21);
            this.EffectTypeBox.TabIndex = 10;
            // 
            // effectTypeBindingSource
            // 
            this.effectTypeBindingSource.DataSource = typeof(CyberPanicLite.Classes.Enumerated.EffectType);
            // 
            // ValueNumeric
            // 
            this.ValueNumeric.Location = new System.Drawing.Point(592, 19);
            this.ValueNumeric.Name = "ValueNumeric";
            this.ValueNumeric.Size = new System.Drawing.Size(39, 20);
            this.ValueNumeric.TabIndex = 12;
            // 
            // CooldownNumeric
            // 
            this.CooldownNumeric.Location = new System.Drawing.Point(637, 19);
            this.CooldownNumeric.Name = "CooldownNumeric";
            this.CooldownNumeric.Size = new System.Drawing.Size(39, 20);
            this.CooldownNumeric.TabIndex = 13;
            // 
            // TargetEnemyRadio
            // 
            this.TargetEnemyRadio.AutoSize = true;
            this.TargetEnemyRadio.Checked = true;
            this.TargetEnemyRadio.Location = new System.Drawing.Point(400, 19);
            this.TargetEnemyRadio.Name = "TargetEnemyRadio";
            this.TargetEnemyRadio.Size = new System.Drawing.Size(91, 17);
            this.TargetEnemyRadio.TabIndex = 14;
            this.TargetEnemyRadio.TabStop = true;
            this.TargetEnemyRadio.Text = "Target Enemy";
            this.TargetEnemyRadio.UseVisualStyleBackColor = true;
            // 
            // TargetSelfRadio
            // 
            this.TargetSelfRadio.AutoSize = true;
            this.TargetSelfRadio.Location = new System.Drawing.Point(400, 42);
            this.TargetSelfRadio.Name = "TargetSelfRadio";
            this.TargetSelfRadio.Size = new System.Drawing.Size(77, 17);
            this.TargetSelfRadio.TabIndex = 15;
            this.TargetSelfRadio.Text = "Target Self";
            this.TargetSelfRadio.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ErrorMessageLabel);
            this.groupBox1.Controls.Add(this.TargetSelfRadio);
            this.groupBox1.Controls.Add(this.ActionNameInput);
            this.groupBox1.Controls.Add(this.TargetEnemyRadio);
            this.groupBox1.Controls.Add(this.ActionDescriptionInput);
            this.groupBox1.Controls.Add(this.CooldownNumeric);
            this.groupBox1.Controls.Add(this.EffectTypeBox);
            this.groupBox1.Controls.Add(this.ValueNumeric);
            this.groupBox1.Location = new System.Drawing.Point(73, 342);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(684, 67);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add or Edit";
            // 
            // ErrorMessageLabel
            // 
            this.ErrorMessageLabel.AutoSize = true;
            this.ErrorMessageLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorMessageLabel.Location = new System.Drawing.Point(6, 46);
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
            this.DeleteButton.Location = new System.Drawing.Point(682, 415);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 17;
            this.DeleteButton.Text = "DELETE";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Action ID";
            // 
            // ActionIDLabel
            // 
            this.ActionIDLabel.AutoSize = true;
            this.ActionIDLabel.Location = new System.Drawing.Point(12, 363);
            this.ActionIDLabel.Name = "ActionIDLabel";
            this.ActionIDLabel.Size = new System.Drawing.Size(51, 13);
            this.ActionIDLabel.TabIndex = 19;
            this.ActionIDLabel.Text = "Add New";
            // 
            // ClearAllButton
            // 
            this.ClearAllButton.Location = new System.Drawing.Point(12, 415);
            this.ClearAllButton.Name = "ClearAllButton";
            this.ClearAllButton.Size = new System.Drawing.Size(55, 23);
            this.ClearAllButton.TabIndex = 20;
            this.ClearAllButton.Text = "Clear All";
            this.ClearAllButton.UseVisualStyleBackColor = true;
            this.ClearAllButton.Click += new System.EventHandler(this.ClearAllButton_Click);
            // 
            // effectTypeBindingSource1
            // 
            this.effectTypeBindingSource1.DataSource = typeof(CyberPanicLite.Classes.Enumerated.EffectType);
            // 
            // ClearIDButton
            // 
            this.ClearIDButton.Location = new System.Drawing.Point(12, 386);
            this.ClearIDButton.Name = "ClearIDButton";
            this.ClearIDButton.Size = new System.Drawing.Size(55, 23);
            this.ClearIDButton.TabIndex = 21;
            this.ClearIDButton.Text = "Clear ID";
            this.ClearIDButton.UseVisualStyleBackColor = true;
            this.ClearIDButton.Click += new System.EventHandler(this.ClearIDButton_Click);
            // 
            // ManageActions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ClearIDButton);
            this.Controls.Add(this.ClearAllButton);
            this.Controls.Add(this.ActionIDLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.ActionList);
            this.Controls.Add(this.EditActionButton);
            this.Controls.Add(this.AddActionButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "ManageActions";
            this.Text = "ManageActions";
            ((System.ComponentModel.ISupportInitialize)(this.effectTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValueNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CooldownNumeric)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.effectTypeBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AddActionButton;
        private System.Windows.Forms.Button EditActionButton;
        private System.Windows.Forms.ListView ActionList;
        private System.Windows.Forms.ColumnHeader ActionName;
        private System.Windows.Forms.ColumnHeader ActionDescription;
        private System.Windows.Forms.ColumnHeader Target;
        private System.Windows.Forms.ColumnHeader EffectType;
        private System.Windows.Forms.ColumnHeader Value;
        private System.Windows.Forms.ColumnHeader Cooldown;
        private System.Windows.Forms.TextBox ActionDescriptionInput;
        private System.Windows.Forms.TextBox ActionNameInput;
        private System.Windows.Forms.ComboBox EffectTypeBox;
        private System.Windows.Forms.BindingSource effectTypeBindingSource;
        private System.Windows.Forms.ColumnHeader ActionID;
        private System.Windows.Forms.NumericUpDown ValueNumeric;
        private System.Windows.Forms.NumericUpDown CooldownNumeric;
        private System.Windows.Forms.RadioButton TargetEnemyRadio;
        private System.Windows.Forms.RadioButton TargetSelfRadio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ActionIDLabel;
        private System.Windows.Forms.Button ClearAllButton;
        private System.Windows.Forms.BindingSource effectTypeBindingSource1;
        private System.Windows.Forms.Label ErrorMessageLabel;
        private System.Windows.Forms.Button ClearIDButton;
    }
}