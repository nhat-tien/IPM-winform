using IPM_winform.Services;
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
    public partial class FileBlockWithUser : UserControl
    {
        public Action<int> OnCheck { get; set; }
        public Action<int> OnReject { get; set; }
        public Action<int> OnDelete { get; set; }
        public FileBlockWithUser()
        {
            InitializeComponent();

        }

        private string status;

        public int Id { get; set; }

        public string FileName
        {
            get => lbFileName.Text;
            set
            {
                lbFileName.Text = value;
            }
        }

        public string FileUrl
        {
            get; set;
        }

        public string UserName
        {
            get => lbUserName.Text;
            set
            {
                lbUserName.Text = value;
            }
        }

        public string Status
        {
            get => status;
            set
            {
                status = value;
                if (status == null)
                {
                    return;
                }
                if (status == "done")
                {
                    lbStatus.Text = "Đã xác nhận";
                }
                else if(status == "reject")
                {
                    lbStatus.Text = "Từ chối";
                }
                else
                {
                    lbStatus.Text = "Chờ xác nhận";
                }
            }
        }

        public void setIconStatus()
        {
            if (status == "done")
            {
                pictureBox2.Image = Properties.Resources.icons8_check_48;
            }
             else if (status == "reject")
            {
                pictureBox2.Image = Properties.Resources.icons8_x_64;
            } else
            {
                pictureBox2.Image = Properties.Resources.icons8_historical_48;
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
            setIconStatus();
            if (Author.IsUser())
            {
                contextMenuStrip2.Visible = false;
            }
        }

        private void xácNhậnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnCheck(Id);
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(FileUrl) && System.IO.File.Exists(FileUrl))
            {
                System.IO.File.Delete(FileUrl);
            }
            OnDelete(Id);
        }

        private void tảiXuốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Title = "Choose where to save the file";
                saveFileDialog.FileName = FileName; // Suggest default filename
                saveFileDialog.Filter = "All Files (*.*)|*.*";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                  
                 File.Copy(FileUrl, saveFileDialog.FileName, overwrite: true);
                        //MessageBox.Show("File downloaded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                }
            }
        }

        private void từChốiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnReject(Id);
        }
    }
}
