﻿namespace Ankh.UI.SvnLog
{
    partial class LogRevisionControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.logView = new Ankh.UI.SvnLog.LogRevisionView(this.components);
            this.SuspendLayout();
            // 
            // logView
            // 
            this.logView.AllowColumnReorder = true;
            this.logView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logView.HideSelection = false;
            this.logView.Location = new System.Drawing.Point(0, 0);
            this.logView.Name = "logView";
            this.logView.Size = new System.Drawing.Size(552, 324);
            this.logView.Sorting = System.Windows.Forms.SortOrder.None;
            this.logView.TabIndex = 0;
            this.logView.VirtualMode = true;
            this.logView.ShowContextMenu += new System.Windows.Forms.MouseEventHandler(this.logRevisionControl1_ShowContextMenu);
            this.logView.VirtualItemsSelectionRangeChanged += new System.Windows.Forms.ListViewVirtualItemsSelectionRangeChangedEventHandler(this.logRevisionControl1_VirtualItemsSelectionRangeChanged);
            this.logView.SelectedIndexChanged += new System.EventHandler(this.logRevisionControl1_SelectedIndexChanged);
            this.logView.RetrieveVirtualItem += new System.Windows.Forms.RetrieveVirtualItemEventHandler(this.logRevisionControl1_RetrieveVirtualItem);
            this.logView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.logRevisionControl1_ItemSelectionChanged);
            this.logView.CacheVirtualItems += new System.Windows.Forms.CacheVirtualItemsEventHandler(this.logRevisionControl1_CacheVirtualItems);
            // 
            // LogRevisionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.logView);
            this.Name = "LogRevisionControl";
            this.Size = new System.Drawing.Size(552, 324);
            this.ResumeLayout(false);

        }

        #endregion

        private LogRevisionView logView;

    }
}
