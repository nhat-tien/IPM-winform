using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPM_winform.Controls
{
    public partial class FileBlock : UserControl
    {
        public FileBlock()
        {
            InitializeComponent();

        }

        public string FileName
        {
            get => lbFileName.Text;
            set
            {
                lbFileName.Text = value;
            }
        }

        private Image GetImageFile()
        {
            string ext = Path.GetExtension(lbFileName.Text);
            switch (ext)
            {
                case ".doc":
                case ".docx":
                    return Properties.Resources.icons8_word_file_64;
                case ".xls":
                    return Properties.Resources.icons8_xls_64;
                case ".pdf":
                    return Properties.Resources.icons8_pdf_64;

                default:
                    return Properties.Resources.icons8_file_144;
            };
        }

        private void FileBlock_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = GetImageFile();
        }
    }
}
