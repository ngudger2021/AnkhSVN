﻿namespace Ankh.UI.SccManagement
{
    partial class CreateBranch
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.specificVersionRadio = new System.Windows.Forms.RadioButton();
            this.headVersionRadio = new System.Windows.Forms.RadioButton();
            this.wcVersionRadio = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.fromUrlBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fromFolderBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.logMessage = new Ankh.UI.PendingChanges.LogMessageEditor();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.toUrlBox = new System.Windows.Forms.TextBox();
            this.toUrlBrowse = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.versionBox = new System.Windows.Forms.TextBox();
            this.versionBrowse = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(334, 442);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(253, 442);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.versionBrowse);
            this.groupBox3.Controls.Add(this.versionBox);
            this.groupBox3.Controls.Add(this.specificVersionRadio);
            this.groupBox3.Controls.Add(this.headVersionRadio);
            this.groupBox3.Controls.Add(this.wcVersionRadio);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.fromUrlBox);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.fromFolderBox);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(18, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(397, 160);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "From:";
            // 
            // specificVersionRadio
            // 
            this.specificVersionRadio.AutoSize = true;
            this.specificVersionRadio.Location = new System.Drawing.Point(62, 118);
            this.specificVersionRadio.Name = "specificVersionRadio";
            this.specificVersionRadio.Size = new System.Drawing.Size(103, 17);
            this.specificVersionRadio.TabIndex = 7;
            this.specificVersionRadio.Text = "&Specific version:";
            this.specificVersionRadio.UseVisualStyleBackColor = true;
            // 
            // headVersionRadio
            // 
            this.headVersionRadio.AutoSize = true;
            this.headVersionRadio.Checked = true;
            this.headVersionRadio.Location = new System.Drawing.Point(62, 72);
            this.headVersionRadio.Name = "headVersionRadio";
            this.headVersionRadio.Size = new System.Drawing.Size(123, 17);
            this.headVersionRadio.TabIndex = 5;
            this.headVersionRadio.TabStop = true;
            this.headVersionRadio.Text = "&Head/Latest Version";
            this.headVersionRadio.UseVisualStyleBackColor = true;
            // 
            // wcVersionRadio
            // 
            this.wcVersionRadio.AutoSize = true;
            this.wcVersionRadio.Location = new System.Drawing.Point(62, 95);
            this.wcVersionRadio.Name = "wcVersionRadio";
            this.wcVersionRadio.Size = new System.Drawing.Size(92, 17);
            this.wcVersionRadio.TabIndex = 6;
            this.wcVersionRadio.Text = "&Working Copy";
            this.wcVersionRadio.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "&Version:";
            // 
            // fromUrlBox
            // 
            this.fromUrlBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fromUrlBox.Location = new System.Drawing.Point(62, 44);
            this.fromUrlBox.Name = "fromUrlBox";
            this.fromUrlBox.Size = new System.Drawing.Size(302, 20);
            this.fromUrlBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "&Url:";
            // 
            // fromFolderBox
            // 
            this.fromFolderBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fromFolderBox.Location = new System.Drawing.Point(62, 20);
            this.fromFolderBox.Name = "fromFolderBox";
            this.fromFolderBox.Size = new System.Drawing.Size(302, 20);
            this.fromFolderBox.TabIndex = 1;
            this.fromFolderBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Folder:";
            // 
            // logMessage
            // 
            this.logMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.logMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logMessage.Location = new System.Drawing.Point(18, 261);
            this.logMessage.Name = "logMessage";
            this.logMessage.Size = new System.Drawing.Size(397, 168);
            this.logMessage.TabIndex = 3;
            this.logMessage.Text = null;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.toUrlBrowse);
            this.groupBox1.Controls.Add(this.toUrlBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(18, 178);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 56);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "&To:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ur&l:";
            // 
            // toUrlBox
            // 
            this.toUrlBox.Location = new System.Drawing.Point(35, 22);
            this.toUrlBox.Name = "toUrlBox";
            this.toUrlBox.Size = new System.Drawing.Size(329, 20);
            this.toUrlBox.TabIndex = 1;
            // 
            // toUrlBrowse
            // 
            this.toUrlBrowse.Location = new System.Drawing.Point(370, 22);
            this.toUrlBrowse.Name = "toUrlBrowse";
            this.toUrlBrowse.Size = new System.Drawing.Size(21, 23);
            this.toUrlBrowse.TabIndex = 2;
            this.toUrlBrowse.Text = "...";
            this.toUrlBrowse.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Log Message:";
            // 
            // versionBox
            // 
            this.versionBox.Location = new System.Drawing.Point(171, 118);
            this.versionBox.Name = "versionBox";
            this.versionBox.Size = new System.Drawing.Size(193, 20);
            this.versionBox.TabIndex = 8;
            this.versionBox.Text = "1";
            this.versionBox.TextChanged += new System.EventHandler(this.versionBox_TextChanged);
            // 
            // versionBrowse
            // 
            this.versionBrowse.Enabled = false;
            this.versionBrowse.Location = new System.Drawing.Point(370, 116);
            this.versionBrowse.Name = "versionBrowse";
            this.versionBrowse.Size = new System.Drawing.Size(21, 23);
            this.versionBrowse.TabIndex = 9;
            this.versionBrowse.Text = "...";
            this.versionBrowse.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(27, 442);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(172, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "S&witch to Branch after creation";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // CreateDirectory
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(427, 477);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.logMessage);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Name = "CreateDirectory";
            this.Text = "Create Branch/Tag";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox fromUrlBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fromFolderBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton specificVersionRadio;
        private System.Windows.Forms.RadioButton headVersionRadio;
        private System.Windows.Forms.RadioButton wcVersionRadio;
        private System.Windows.Forms.Label label3;
        private Ankh.UI.PendingChanges.LogMessageEditor logMessage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button toUrlBrowse;
        private System.Windows.Forms.TextBox toUrlBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button versionBrowse;
        private System.Windows.Forms.TextBox versionBox;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}