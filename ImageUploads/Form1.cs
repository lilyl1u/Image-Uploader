using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageUploads
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void image_UploadsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.image_UploadsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.my);

        }

        private void image_UploadsBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.image_UploadsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.my);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'my.Image_Uploads' table. You can move, or remove it, as needed.
            this.image_UploadsTableAdapter.Fill(this.my.Image_Uploads);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // add a class such that when user click on button, open a dialog box
            OpenFileDialog openFd = new OpenFileDialog();
            //save filter with acceptable image formats
            openFd.Filter = "Images only. | *.jpg; *.jpeg; *.png; *.gif;";

            //specifies to indicate return value of dialog box
            //what we expect it to show
            //displays using dialog result
            //metho showdialog is a method
            DialogResult dr = openFd.ShowDialog();

            //attaching image to the picturebox
            imgPictureBox.Image = Image.FromFile(openFd.FileName);
            
            //displays path from image that we decide to upload
            imgPathLabel1.Text = openFd.FileName;

        }


    }
}
