// $Id$
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

using SharpSvn;

namespace Ankh.UI
{
    /// <summary>
    /// Summary description for AddRepositoryDialog.
    /// </summary>
    public partial class AddRepositoryRootDialog : System.Windows.Forms.Form
    {
        readonly IAnkhServiceProvider _context;
        public AddRepositoryRootDialog()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //Set revision choices in combobox

            this.ValidateAdd();
        }

        public AddRepositoryRootDialog(IAnkhServiceProvider context)
            :this()
        {
            if (context == null)
                throw new ArgumentNullException("context");

            _context = context;

            foreach (string url in _context.GetService<IAnkhConfigurationService>().GetRecentReposUrls())
            {
                urlTextBox.Items.Add(url);
            }
        }

   
        /// <summary>
        /// The URL entered in the text box.
        /// </summary>
        public Uri Uri
        {
            get
            {
                Uri uri;
                if (string.IsNullOrEmpty(urlTextBox.Text) || !Uri.TryCreate(urlTextBox.Text, UriKind.Absolute, out uri))
                    return null;

                return uri;
            }
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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

        private void revisionPicker_Changed(object sender, System.EventArgs e)
        {
            this.ValidateAdd();            
        }

        private void urlTextBox_TextChanged(object sender, System.EventArgs e)
        {
            this.ValidateAdd();
        }

        private void ValidateAdd()
        {
            this.okButton.Enabled = Uri != null;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            RegistryLifoList recentUrls = _context.GetService<IAnkhConfigurationService>().GetRecentReposUrls();

            Uri unused;
            if (!string.IsNullOrEmpty(urlTextBox.Text) && Uri.TryCreate(urlTextBox.Text, UriKind.Absolute, out unused))
            {
                if (!recentUrls.Contains(urlTextBox.Text))
                    recentUrls.Add(urlTextBox.Text);
            }
        }
    }
}
