// $Id$
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Ankh.UI
{
	/// <summary>
	/// Summary description for ViewLogDialog.
	/// </summary>
	public class ViewLogDialog : System.Windows.Forms.Form
	{
   //     public event EventHandler GetLog;
		
        public ViewLogDialog()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
            this.fromRevisionComboBox.Items.AddRange( new object[]{
                                                                 RevisionChoice.Head,
                                                                 RevisionChoice.Prev,
                                                                 RevisionChoice.Date,
                                                                 RevisionChoice.Base,
                                                                 RevisionChoice.Commited});

		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>

        private enum RevisionChoice
        {
            Date,
            Head,
            Base,
            Commited,
            Prev
        }

        protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}


		
        #region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.label1 = new System.Windows.Forms.Label();
            this.fromRevisionComboBox = new System.Windows.Forms.ComboBox();
            this.toRevisionComboBox = new System.Windows.Forms.ComboBox();
            this.showRevisionCheckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.singleRevisionCheckBox = new System.Windows.Forms.CheckBox();
            this.logRichTextBox = new System.Windows.Forms.RichTextBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.getLogButton = new System.Windows.Forms.Button();
            this.showDateCheckBox = new System.Windows.Forms.CheckBox();
            this.showAuthorCheckBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.showMessageCheckBox = new System.Windows.Forms.CheckBox();
            this.showModifiedFilesCheckBox = new System.Windows.Forms.CheckBox();
            this.fromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.toDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(88, -16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Revision";
            // 
            // fromRevisionComboBox
            // 
            this.fromRevisionComboBox.Location = new System.Drawing.Point(147, 8);
            this.fromRevisionComboBox.Name = "fromRevisionComboBox";
            this.fromRevisionComboBox.Size = new System.Drawing.Size(121, 21);
            this.fromRevisionComboBox.TabIndex = 1;
            this.fromRevisionComboBox.TextChanged += new System.EventHandler(this.fromRevisionComboBox_TextChanged);
            this.fromRevisionComboBox.SelectedIndexChanged += new System.EventHandler(this.fromRevisionComboBox_SelectedIndexChanged);
            // 
            // toRevisionComboBox
            // 
            this.toRevisionComboBox.Enabled = false;
            this.toRevisionComboBox.Location = new System.Drawing.Point(147, 40);
            this.toRevisionComboBox.Name = "toRevisionComboBox";
            this.toRevisionComboBox.Size = new System.Drawing.Size(121, 21);
            this.toRevisionComboBox.TabIndex = 3;
            this.toRevisionComboBox.TextChanged += new System.EventHandler(this.toRevisionComboBox_TextChanged);
            this.toRevisionComboBox.SelectedIndexChanged += new System.EventHandler(this.toRevisionComboBox_SelectedIndexChanged);
            // 
            // showRevisionCheckBox
            // 
            this.showRevisionCheckBox.Checked = true;
            this.showRevisionCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showRevisionCheckBox.Location = new System.Drawing.Point(0, 96);
            this.showRevisionCheckBox.Name = "showRevisionCheckBox";
            this.showRevisionCheckBox.Size = new System.Drawing.Size(88, 24);
            this.showRevisionCheckBox.TabIndex = 4;
            this.showRevisionCheckBox.Text = "Revision nr.";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(107, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "From";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(107, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "To";
            // 
            // singleRevisionCheckBox
            // 
            this.singleRevisionCheckBox.Checked = true;
            this.singleRevisionCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.singleRevisionCheckBox.Location = new System.Drawing.Point(272, 8);
            this.singleRevisionCheckBox.Name = "singleRevisionCheckBox";
            this.singleRevisionCheckBox.Size = new System.Drawing.Size(112, 24);
            this.singleRevisionCheckBox.TabIndex = 2;
            this.singleRevisionCheckBox.Text = "Single revision";
            this.singleRevisionCheckBox.CheckedChanged += new System.EventHandler(this.singleRevisionCheckBoxChecked);
            // 
            // logRichTextBox
            // 
            this.logRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
                | System.Windows.Forms.AnchorStyles.Right);
            this.logRichTextBox.Location = new System.Drawing.Point(0, 128);
            this.logRichTextBox.Name = "logRichTextBox";
            this.logRichTextBox.Size = new System.Drawing.Size(592, 296);
            this.logRichTextBox.TabIndex = 11;
            this.logRichTextBox.Text = "";
            // 
            // closeButton
            // 
            this.closeButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.closeButton.Location = new System.Drawing.Point(488, 440);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(94, 23);
            this.closeButton.TabIndex = 10;
            this.closeButton.Text = "Close";
            // 
            // getLogButton
            // 
            this.getLogButton.Location = new System.Drawing.Point(472, 96);
            this.getLogButton.Name = "getLogButton";
            this.getLogButton.Size = new System.Drawing.Size(99, 23);
            this.getLogButton.TabIndex = 9;
            this.getLogButton.Text = "Get log";
            // 
            // showDateCheckBox
            // 
            this.showDateCheckBox.Checked = true;
            this.showDateCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showDateCheckBox.Location = new System.Drawing.Point(96, 96);
            this.showDateCheckBox.Name = "showDateCheckBox";
            this.showDateCheckBox.Size = new System.Drawing.Size(48, 24);
            this.showDateCheckBox.TabIndex = 5;
            this.showDateCheckBox.Text = "Date";
            // 
            // showAuthorCheckBox
            // 
            this.showAuthorCheckBox.Checked = true;
            this.showAuthorCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showAuthorCheckBox.Location = new System.Drawing.Point(152, 96);
            this.showAuthorCheckBox.Name = "showAuthorCheckBox";
            this.showAuthorCheckBox.Size = new System.Drawing.Size(64, 24);
            this.showAuthorCheckBox.TabIndex = 6;
            this.showAuthorCheckBox.Text = "Author";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(0, 67);
            this.label4.Name = "label4";
            this.label4.TabIndex = 17;
            this.label4.Text = "Show:";
            // 
            // showMessageCheckBox
            // 
            this.showMessageCheckBox.Checked = true;
            this.showMessageCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showMessageCheckBox.Location = new System.Drawing.Point(224, 96);
            this.showMessageCheckBox.Name = "showMessageCheckBox";
            this.showMessageCheckBox.TabIndex = 7;
            this.showMessageCheckBox.Text = "Message";
            // 
            // showModifiedFilesCheckBox
            // 
            this.showModifiedFilesCheckBox.Location = new System.Drawing.Point(336, 96);
            this.showModifiedFilesCheckBox.Name = "showModifiedFilesCheckBox";
            this.showModifiedFilesCheckBox.TabIndex = 8;
            this.showModifiedFilesCheckBox.Text = "Modified files";
            // 
            // fromDateTimePicker
            // 
            this.fromDateTimePicker.Enabled = false;
            this.fromDateTimePicker.Location = new System.Drawing.Point(384, 8);
            this.fromDateTimePicker.Name = "fromDateTimePicker";
            this.fromDateTimePicker.TabIndex = 20;
            // 
            // toDateTimePicker
            // 
            this.toDateTimePicker.Enabled = false;
            this.toDateTimePicker.Location = new System.Drawing.Point(384, 41);
            this.toDateTimePicker.Name = "toDateTimePicker";
            this.toDateTimePicker.TabIndex = 21;
            // 
            // ViewLogDialog
            // 
            this.AcceptButton = this.getLogButton;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(592, 469);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                          this.toDateTimePicker,
                                                                          this.fromDateTimePicker,
                                                                          this.showModifiedFilesCheckBox,
                                                                          this.showMessageCheckBox,
                                                                          this.label4,
                                                                          this.showAuthorCheckBox,
                                                                          this.showDateCheckBox,
                                                                          this.getLogButton,
                                                                          this.closeButton,
                                                                          this.logRichTextBox,
                                                                          this.singleRevisionCheckBox,
                                                                          this.label3,
                                                                          this.label2,
                                                                          this.showRevisionCheckBox,
                                                                          this.toRevisionComboBox,
                                                                          this.fromRevisionComboBox,
                                                                          this.label1});
            this.Name = "ViewLogDialog";
            this.Text = "ViewLogDialog";
            this.ResumeLayout(false);

        }
		#endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox fromRevisionComboBox;
        private System.Windows.Forms.ComboBox toRevisionComboBox;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button getLogButton;
        private System.Windows.Forms.DateTimePicker fromDateTimePicker;
        private System.Windows.Forms.DateTimePicker toDateTimePicker;
        private System.Windows.Forms.CheckBox showRevisionCheckBox;
        private System.Windows.Forms.RichTextBox logRichTextBox;
        private System.Windows.Forms.CheckBox showDateCheckBox;
        private System.Windows.Forms.CheckBox showAuthorCheckBox;
        private System.Windows.Forms.CheckBox showMessageCheckBox;
        private System.Windows.Forms.CheckBox showModifiedFilesCheckBox;
        private System.Windows.Forms.CheckBox singleRevisionCheckBox;
        private System.ComponentModel.IContainer components;
        private static readonly Regex validateRevisionNumber = 
            new Regex(@"\w{1,}", RegexOptions.Compiled);
       
        [STAThread] 
        public static void Main()
        {
            ViewLogDialog the = new ViewLogDialog();
            the.ShowDialog();
         }

        
        private void singleRevisionCheckBoxChecked(object sender, System.EventArgs e)
        {
            this.toRevisionComboBox.SelectedItem = null;

            if (this.singleRevisionCheckBox.Checked)
            {
                this.toRevisionComboBox.Items.Clear();
                this.toRevisionComboBox.Enabled = false;
                this.toDateTimePicker.Enabled = false;
            }
            else
            {
                this.toRevisionComboBox.Items.Clear();
                EnableAndDisableToCombo();
            }
        }

        private void fromRevisionComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            this.toRevisionComboBox.Items.Clear(); 
            this.toRevisionComboBox.SelectedItem = null;
               
            EnableAndDisableToCombo();
        }

        private void EnableAndDisableToCombo()
        {
            if (this.fromRevisionComboBox.SelectedItem != null )
            {

                if ((RevisionChoice)this.fromRevisionComboBox.SelectedItem 
                    == RevisionChoice.Date)
                {
                   // this.toRevisionComboBox.SelectedItem = RevisionChoice.Date;
                    this.fromDateTimePicker.Enabled = true;
                    this.toDateTimePicker.Enabled = false;

                    if (!this.singleRevisionCheckBox.Checked)
                    {
                        this.toDateTimePicker.Enabled = true;
                        this.toRevisionComboBox.Enabled = true;
                        this.toRevisionComboBox.Items.Clear();
                        this.toRevisionComboBox.Items.Add(RevisionChoice.Date);
                    }
                }
                else
                {
                    this.fromDateTimePicker.Enabled = false;
                    this.toDateTimePicker.Enabled = false;

                    if (!this.singleRevisionCheckBox.Checked)
                    {
                        SetToCombo();

                        if ((RevisionChoice)this.fromRevisionComboBox.SelectedItem 
                            == RevisionChoice.Head)
                        {
                            this.toRevisionComboBox.Enabled = false;
                        }
                    }
                } 
            }

            else if (ValidateForm( this.fromRevisionComboBox.Text ) && 
                    !this.singleRevisionCheckBox.Checked && 
                this.fromRevisionComboBox.SelectedItem == null )
                {
                    SetToCombo();
                }
        }


        private void SetToCombo()
        {
            this.toRevisionComboBox.Items.Clear();
            this.toRevisionComboBox.Items.AddRange(  new object[]{
                                                                     RevisionChoice.Head,
                                                                     RevisionChoice.Prev,
                                                                     RevisionChoice.Base,
                                                                     RevisionChoice.Commited}); 
                       
            this.toRevisionComboBox.Enabled = true;
        }

        private void toRevisionComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (this.fromRevisionComboBox.SelectedItem != null)
            {
                if ((RevisionChoice)this.fromRevisionComboBox.SelectedItem 
                    == RevisionChoice.Date )
                {
                    this.toDateTimePicker.Enabled = true;                
                }
            
                else
                {
                    this.toDateTimePicker.Enabled = false;
                        
                }
            } 
        }

        /// <summary>
        /// Tried to evaluate wheteher the entered revision number is
        /// valid (regular expression) 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fromRevisionComboBox_TextChanged(object sender, System.EventArgs e)
        {
           if (this.fromRevisionComboBox.Text != "" )
               //&& this.fromRevisionComboBox.SelectedItem == null)
            {
               this.toRevisionComboBox.SelectedItem = null;
               EnableTextCombo(this.fromRevisionComboBox.Text);
            }
        }

        private void EnableTextCombo( string text)
        {
            if(ValidateForm(text))
            {
                if (!this.singleRevisionCheckBox.Checked)
                    this.toRevisionComboBox.Enabled = true;
            }
        }
        
        private bool ValidateForm(string text)
        {

            return validateRevisionNumber.IsMatch( text );
        }

        private void toRevisionComboBox_TextChanged(object sender, System.EventArgs e)
        {
            if (this.fromRevisionComboBox.Text != "" || 
                this.fromRevisionComboBox.SelectedItem != null)
            {
                EnableTextCombo(this.toRevisionComboBox.Text);
            }
        }                                     
 
	}

}




