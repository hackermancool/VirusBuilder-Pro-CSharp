namespace VirusBuilder_Pro_CSharp
{
    partial class Main
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.sloganLabel = new System.Windows.Forms.Label();
            this.selectComponentLabel = new System.Windows.Forms.Label();
            this.componentList = new System.Windows.Forms.ListBox();
            this.field1Label = new System.Windows.Forms.Label();
            this.field1TextBox = new System.Windows.Forms.TextBox();
            this.field2TextBox = new System.Windows.Forms.TextBox();
            this.field2Label = new System.Windows.Forms.Label();
            this.extraInfoLabel = new System.Windows.Forms.Label();
            this.addComponentButton = new System.Windows.Forms.Button();
            this.creditLabel = new System.Windows.Forms.Label();
            this.buildVirusButton = new System.Windows.Forms.Button();
            this.batExtensionLabel = new System.Windows.Forms.Label();
            this.shellExtensionLabel = new System.Windows.Forms.Label();
            this.batchPathTextBox = new System.Windows.Forms.TextBox();
            this.shellPathTextBox = new System.Windows.Forms.TextBox();
            this.batchPathLabel = new System.Windows.Forms.Label();
            this.shellPathLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Tahoma", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(-7, -9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(835, 97);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "VirusBuilder Pro C#";
            // 
            // sloganLabel
            // 
            this.sloganLabel.AutoSize = true;
            this.sloganLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sloganLabel.Location = new System.Drawing.Point(595, 82);
            this.sloganLabel.Name = "sloganLabel";
            this.sloganLabel.Size = new System.Drawing.Size(280, 19);
            this.sloganLabel.TabIndex = 1;
            this.sloganLabel.Text = "Effective cross-platform virus creation.";
            this.sloganLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // selectComponentLabel
            // 
            this.selectComponentLabel.AutoSize = true;
            this.selectComponentLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectComponentLabel.Location = new System.Drawing.Point(12, 85);
            this.selectComponentLabel.Name = "selectComponentLabel";
            this.selectComponentLabel.Size = new System.Drawing.Size(212, 16);
            this.selectComponentLabel.TabIndex = 2;
            this.selectComponentLabel.Text = "Select a component to add to virus:";
            // 
            // componentList
            // 
            this.componentList.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.componentList.FormattingEnabled = true;
            this.componentList.ItemHeight = 16;
            this.componentList.Items.AddRange(new object[] {
            "Title",
            "Colour (Windows Only)",
            "Echo Text to Screen",
            "Shutdown",
            "Restart",
            "Hibernate",
            "Wait",
            "Open CMD (Windows Only)",
            "Open Notepad (Windows Only)"});
            this.componentList.Location = new System.Drawing.Point(12, 104);
            this.componentList.Name = "componentList";
            this.componentList.Size = new System.Drawing.Size(250, 228);
            this.componentList.TabIndex = 3;
            this.componentList.SelectedIndexChanged += new System.EventHandler(this.componentList_SelectedIndexChanged);
            // 
            // field1Label
            // 
            this.field1Label.AutoSize = true;
            this.field1Label.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.field1Label.Location = new System.Drawing.Point(268, 104);
            this.field1Label.Name = "field1Label";
            this.field1Label.Size = new System.Drawing.Size(80, 16);
            this.field1Label.TabIndex = 4;
            this.field1Label.Text = "Field 1 Label";
            this.field1Label.Visible = false;
            // 
            // field1TextBox
            // 
            this.field1TextBox.Location = new System.Drawing.Point(271, 124);
            this.field1TextBox.Name = "field1TextBox";
            this.field1TextBox.Size = new System.Drawing.Size(601, 21);
            this.field1TextBox.TabIndex = 5;
            this.field1TextBox.Visible = false;
            // 
            // field2TextBox
            // 
            this.field2TextBox.Location = new System.Drawing.Point(271, 168);
            this.field2TextBox.Name = "field2TextBox";
            this.field2TextBox.Size = new System.Drawing.Size(601, 21);
            this.field2TextBox.TabIndex = 7;
            this.field2TextBox.Visible = false;
            // 
            // field2Label
            // 
            this.field2Label.AutoSize = true;
            this.field2Label.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.field2Label.Location = new System.Drawing.Point(268, 148);
            this.field2Label.Name = "field2Label";
            this.field2Label.Size = new System.Drawing.Size(80, 16);
            this.field2Label.TabIndex = 6;
            this.field2Label.Text = "Field 2 Label";
            this.field2Label.Visible = false;
            // 
            // extraInfoLabel
            // 
            this.extraInfoLabel.AutoSize = true;
            this.extraInfoLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extraInfoLabel.Location = new System.Drawing.Point(268, 196);
            this.extraInfoLabel.Name = "extraInfoLabel";
            this.extraInfoLabel.Size = new System.Drawing.Size(63, 16);
            this.extraInfoLabel.TabIndex = 8;
            this.extraInfoLabel.Text = "Extra Info";
            this.extraInfoLabel.Visible = false;
            // 
            // addComponentButton
            // 
            this.addComponentButton.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addComponentButton.Location = new System.Drawing.Point(273, 217);
            this.addComponentButton.Name = "addComponentButton";
            this.addComponentButton.Size = new System.Drawing.Size(599, 51);
            this.addComponentButton.TabIndex = 9;
            this.addComponentButton.Text = "Add Component";
            this.addComponentButton.UseVisualStyleBackColor = true;
            this.addComponentButton.Visible = false;
            this.addComponentButton.Click += new System.EventHandler(this.addComponentButton_Click);
            // 
            // creditLabel
            // 
            this.creditLabel.AutoSize = true;
            this.creditLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditLabel.Location = new System.Drawing.Point(635, 325);
            this.creditLabel.Name = "creditLabel";
            this.creditLabel.Size = new System.Drawing.Size(245, 16);
            this.creditLabel.TabIndex = 10;
            this.creditLabel.Text = "Created by hackermancool under GPL-3.0";
            this.creditLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // buildVirusButton
            // 
            this.buildVirusButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buildVirusButton.Location = new System.Drawing.Point(781, 274);
            this.buildVirusButton.Name = "buildVirusButton";
            this.buildVirusButton.Size = new System.Drawing.Size(91, 48);
            this.buildVirusButton.TabIndex = 11;
            this.buildVirusButton.Text = "Build Virus";
            this.buildVirusButton.UseVisualStyleBackColor = true;
            this.buildVirusButton.Click += new System.EventHandler(this.buildVirusButton_Click);
            // 
            // batExtensionLabel
            // 
            this.batExtensionLabel.AutoSize = true;
            this.batExtensionLabel.Location = new System.Drawing.Point(754, 279);
            this.batExtensionLabel.Name = "batExtensionLabel";
            this.batExtensionLabel.Size = new System.Drawing.Size(27, 13);
            this.batExtensionLabel.TabIndex = 12;
            this.batExtensionLabel.Text = ".bat";
            // 
            // shellExtensionLabel
            // 
            this.shellExtensionLabel.AutoSize = true;
            this.shellExtensionLabel.Location = new System.Drawing.Point(755, 302);
            this.shellExtensionLabel.Name = "shellExtensionLabel";
            this.shellExtensionLabel.Size = new System.Drawing.Size(22, 13);
            this.shellExtensionLabel.TabIndex = 13;
            this.shellExtensionLabel.Text = ".sh";
            // 
            // batchPathTextBox
            // 
            this.batchPathTextBox.Location = new System.Drawing.Point(331, 274);
            this.batchPathTextBox.Name = "batchPathTextBox";
            this.batchPathTextBox.Size = new System.Drawing.Size(426, 21);
            this.batchPathTextBox.TabIndex = 14;
            this.batchPathTextBox.Text = "virusbuilder-pro-csharp";
            this.batchPathTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // shellPathTextBox
            // 
            this.shellPathTextBox.Location = new System.Drawing.Point(332, 299);
            this.shellPathTextBox.Name = "shellPathTextBox";
            this.shellPathTextBox.Size = new System.Drawing.Size(425, 21);
            this.shellPathTextBox.TabIndex = 15;
            this.shellPathTextBox.Text = "virusbuilder-pro-csharp";
            this.shellPathTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // batchPathLabel
            // 
            this.batchPathLabel.AutoSize = true;
            this.batchPathLabel.Location = new System.Drawing.Point(268, 279);
            this.batchPathLabel.Name = "batchPathLabel";
            this.batchPathLabel.Size = new System.Drawing.Size(63, 13);
            this.batchPathLabel.TabIndex = 16;
            this.batchPathLabel.Text = "Batch Path:";
            // 
            // shellPathLabel
            // 
            this.shellPathLabel.AutoSize = true;
            this.shellPathLabel.Location = new System.Drawing.Point(267, 302);
            this.shellPathLabel.Name = "shellPathLabel";
            this.shellPathLabel.Size = new System.Drawing.Size(58, 13);
            this.shellPathLabel.TabIndex = 17;
            this.shellPathLabel.Text = "Shell Path:";
            // 
            // Main
            // 
            this.AcceptButton = this.addComponentButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 346);
            this.Controls.Add(this.shellPathLabel);
            this.Controls.Add(this.batchPathLabel);
            this.Controls.Add(this.shellPathTextBox);
            this.Controls.Add(this.batchPathTextBox);
            this.Controls.Add(this.shellExtensionLabel);
            this.Controls.Add(this.batExtensionLabel);
            this.Controls.Add(this.buildVirusButton);
            this.Controls.Add(this.creditLabel);
            this.Controls.Add(this.addComponentButton);
            this.Controls.Add(this.extraInfoLabel);
            this.Controls.Add(this.field2TextBox);
            this.Controls.Add(this.field2Label);
            this.Controls.Add(this.field1TextBox);
            this.Controls.Add(this.field1Label);
            this.Controls.Add(this.componentList);
            this.Controls.Add(this.selectComponentLabel);
            this.Controls.Add(this.sloganLabel);
            this.Controls.Add(this.titleLabel);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Main";
            this.ShowIcon = false;
            this.Text = "VirusBuilder Pro C#";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label sloganLabel;
        private System.Windows.Forms.Label selectComponentLabel;
        private System.Windows.Forms.ListBox componentList;
        private System.Windows.Forms.Label field1Label;
        private System.Windows.Forms.TextBox field1TextBox;
        private System.Windows.Forms.TextBox field2TextBox;
        private System.Windows.Forms.Label field2Label;
        private System.Windows.Forms.Label extraInfoLabel;
        private System.Windows.Forms.Button addComponentButton;
        private System.Windows.Forms.Label creditLabel;
        private System.Windows.Forms.Button buildVirusButton;
        private System.Windows.Forms.Label batExtensionLabel;
        private System.Windows.Forms.Label shellExtensionLabel;
        private System.Windows.Forms.TextBox batchPathTextBox;
        private System.Windows.Forms.TextBox shellPathTextBox;
        private System.Windows.Forms.Label batchPathLabel;
        private System.Windows.Forms.Label shellPathLabel;
    }
}

