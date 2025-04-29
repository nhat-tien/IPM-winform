using DocumentFormat.OpenXml.Spreadsheet;
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
    public partial class UserBlock : UserControl
    {
        public UserBlock()
        {
            InitializeComponent();

        }

        public string AvatarUrl { get; set; }

        public int Id { get; set; }

        public bool Owner { get; set; } = false;

        public string Name
        {
            get => lbName.Text;
            set
            {
                lbName.Text = value;
            }
        }
        public string Email
        {
            get => lbEmail.Text;
            set
            {
                lbEmail.Text = value;
            }
        }
        private void GetImageFile()
        {
            if (!String.IsNullOrEmpty(AvatarUrl))
            {
                pictureBox1.Image = Image.FromFile(AvatarUrl);
            }
            else
            {
                pictureBox1.Image = Properties.Resources.user_avatar_male_5;
            }
        }

        private void FileBlock_Load(object sender, EventArgs e)
        {
            GetImageFile();
        }


        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                //isDragging = true;
                //clickOffset = e.Location; // Save where we clicked
                //this.BringToFront();
                this.DoDragDrop(this, DragDropEffects.Copy);
            }
        }

        private void OnMouseMove(object sender, MouseEventArgs e)
        {
            //if (isDragging)
            //{
            //    Point newLocation = this.Parent.PointToClient(MousePosition);
            //    newLocation.Offset(-clickOffset.X, -clickOffset.Y);
            //    this.Location = newLocation;
            //}
        }

        private void OnMouseUp(object sender, MouseEventArgs e)
        {
            //if (e.Button == MouseButtons.Left)
            //{
            //    isDragging = false;
            //}
        }

        private Bitmap CreateControlBitmap(System.Windows.Forms.Control ctrl)
        {
            Bitmap bmp = new Bitmap(ctrl.Width, ctrl.Height);
            ctrl.DrawToBitmap(bmp, new Rectangle(Point.Empty, ctrl.Size));
            return bmp;
        }
    }
}
