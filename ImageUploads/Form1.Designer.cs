namespace ImageUploads
{
    partial class Form1
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label imgPathLabel;
            System.Windows.Forms.Label imgLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.my = new ImageUploads.my();
            this.image_UploadsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.image_UploadsTableAdapter = new ImageUploads.myTableAdapters.Image_UploadsTableAdapter();
            this.tableAdapterManager = new ImageUploads.myTableAdapters.TableAdapterManager();
            this.image_UploadsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.image_UploadsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idLabel1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.imgPathLabel1 = new System.Windows.Forms.Label();
            this.imgPictureBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            idLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            imgPathLabel = new System.Windows.Forms.Label();
            imgLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.my)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.image_UploadsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.image_UploadsBindingNavigator)).BeginInit();
            this.image_UploadsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idLabel.ForeColor = System.Drawing.Color.DarkOliveGreen;
            idLabel.Location = new System.Drawing.Point(95, 126);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(35, 22);
            idLabel.TabIndex = 1;
            idLabel.Text = "ID:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nameLabel.ForeColor = System.Drawing.Color.DarkOliveGreen;
            nameLabel.Location = new System.Drawing.Point(95, 170);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(67, 22);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Name:";
            // 
            // imgPathLabel
            // 
            imgPathLabel.AutoSize = true;
            imgPathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            imgPathLabel.ForeColor = System.Drawing.Color.DarkOliveGreen;
            imgPathLabel.Location = new System.Drawing.Point(93, 217);
            imgPathLabel.Name = "imgPathLabel";
            imgPathLabel.Size = new System.Drawing.Size(110, 22);
            imgPathLabel.TabIndex = 5;
            imgPathLabel.Text = "Image Path";
            // 
            // imgLabel
            // 
            imgLabel.AutoSize = true;
            imgLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            imgLabel.ForeColor = System.Drawing.Color.DarkOliveGreen;
            imgLabel.Location = new System.Drawing.Point(93, 275);
            imgLabel.Name = "imgLabel";
            imgLabel.Size = new System.Drawing.Size(69, 22);
            imgLabel.TabIndex = 7;
            imgLabel.Text = "Image:";
            // 
            // my
            // 
            this.my.DataSetName = "my";
            this.my.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // image_UploadsBindingSource
            // 
            this.image_UploadsBindingSource.DataMember = "Image_Uploads";
            this.image_UploadsBindingSource.DataSource = this.my;
            // 
            // image_UploadsTableAdapter
            // 
            this.image_UploadsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Image_UploadsTableAdapter = this.image_UploadsTableAdapter;
            this.tableAdapterManager.UpdateOrder = ImageUploads.myTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // image_UploadsBindingNavigator
            // 
            this.image_UploadsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.image_UploadsBindingNavigator.BindingSource = this.image_UploadsBindingSource;
            this.image_UploadsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.image_UploadsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.image_UploadsBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.image_UploadsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.image_UploadsBindingNavigatorSaveItem});
            this.image_UploadsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.image_UploadsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.image_UploadsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.image_UploadsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.image_UploadsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.image_UploadsBindingNavigator.Name = "image_UploadsBindingNavigator";
            this.image_UploadsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.image_UploadsBindingNavigator.Size = new System.Drawing.Size(797, 27);
            this.image_UploadsBindingNavigator.TabIndex = 0;
            this.image_UploadsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // image_UploadsBindingNavigatorSaveItem
            // 
            this.image_UploadsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.image_UploadsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("image_UploadsBindingNavigatorSaveItem.Image")));
            this.image_UploadsBindingNavigatorSaveItem.Name = "image_UploadsBindingNavigatorSaveItem";
            this.image_UploadsBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.image_UploadsBindingNavigatorSaveItem.Text = "Save Data";
            this.image_UploadsBindingNavigatorSaveItem.Click += new System.EventHandler(this.image_UploadsBindingNavigatorSaveItem_Click_1);
            // 
            // idLabel1
            // 
            this.idLabel1.BackColor = System.Drawing.Color.SeaShell;
            this.idLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.image_UploadsBindingSource, "id", true));
            this.idLabel1.Location = new System.Drawing.Point(254, 130);
            this.idLabel1.Name = "idLabel1";
            this.idLabel1.Size = new System.Drawing.Size(153, 23);
            this.idLabel1.TabIndex = 2;
            this.idLabel1.Text = "label1";
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.Color.SeaShell;
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.image_UploadsBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(254, 172);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(153, 22);
            this.nameTextBox.TabIndex = 4;
            // 
            // imgPathLabel1
            // 
            this.imgPathLabel1.BackColor = System.Drawing.Color.SeaShell;
            this.imgPathLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgPathLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.image_UploadsBindingSource, "ImgPath", true));
            this.imgPathLabel1.Location = new System.Drawing.Point(254, 221);
            this.imgPathLabel1.Name = "imgPathLabel1";
            this.imgPathLabel1.Size = new System.Drawing.Size(272, 23);
            this.imgPathLabel1.TabIndex = 6;
            this.imgPathLabel1.Text = "label1";
            // 
            // imgPictureBox
            // 
            this.imgPictureBox.BackColor = System.Drawing.Color.SeaShell;
            this.imgPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.image_UploadsBindingSource, "Img", true));
            this.imgPictureBox.Location = new System.Drawing.Point(254, 275);
            this.imgPictureBox.Name = "imgPictureBox";
            this.imgPictureBox.Size = new System.Drawing.Size(272, 209);
            this.imgPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPictureBox.TabIndex = 8;
            this.imgPictureBox.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.SeaShell;
            this.button1.Location = new System.Drawing.Point(310, 490);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 52);
            this.button1.TabIndex = 9;
            this.button1.Text = "Browse Images";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label1.Location = new System.Drawing.Point(154, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(466, 42);
            this.label1.TabIndex = 10;
            this.label1.Text = "Image Upload Application";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SeaShell;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.button2.Location = new System.Drawing.Point(621, 504);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 26);
            this.button2.TabIndex = 11;
            this.button2.Text = "Click save to upload";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(797, 566);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idLabel1);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(imgPathLabel);
            this.Controls.Add(this.imgPathLabel1);
            this.Controls.Add(imgLabel);
            this.Controls.Add(this.imgPictureBox);
            this.Controls.Add(this.image_UploadsBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.my)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.image_UploadsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.image_UploadsBindingNavigator)).EndInit();
            this.image_UploadsBindingNavigator.ResumeLayout(false);
            this.image_UploadsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private my my;
        private System.Windows.Forms.BindingSource image_UploadsBindingSource;
        private myTableAdapters.Image_UploadsTableAdapter image_UploadsTableAdapter;
        private myTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator image_UploadsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton image_UploadsBindingNavigatorSaveItem;
        private System.Windows.Forms.Label idLabel1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label imgPathLabel1;
        private System.Windows.Forms.PictureBox imgPictureBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}

