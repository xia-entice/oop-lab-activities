namespace LAB21_Lucero
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.colorPicker = new System.Windows.Forms.PictureBox();
            this.buttonLine = new System.Windows.Forms.Button();
            this.buttonRect = new System.Windows.Forms.Button();
            this.buttonEllipse = new System.Windows.Forms.Button();
            this.buttonEraser = new System.Windows.Forms.Button();
            this.buttonPencil = new System.Windows.Forms.Button();
            this.buttonFill = new System.Windows.Forms.Button();
            this.buttonColor = new System.Windows.Forms.Button();
            this.picColor = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pic = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorPicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Sienna;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.buttonClear);
            this.panel1.Controls.Add(this.colorPicker);
            this.panel1.Controls.Add(this.buttonLine);
            this.panel1.Controls.Add(this.buttonRect);
            this.panel1.Controls.Add(this.buttonEllipse);
            this.panel1.Controls.Add(this.buttonEraser);
            this.panel1.Controls.Add(this.buttonPencil);
            this.panel1.Controls.Add(this.buttonFill);
            this.panel1.Controls.Add(this.buttonColor);
            this.panel1.Controls.Add(this.picColor);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(820, 101);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.Info;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(749, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 25);
            this.button1.TabIndex = 8;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // buttonClear
            // 
            this.buttonClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Font = new System.Drawing.Font("Tahoma", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonClear.ForeColor = System.Drawing.SystemColors.Info;
            this.buttonClear.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonClear.Location = new System.Drawing.Point(749, 22);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(64, 25);
            this.buttonClear.TabIndex = 6;
            this.buttonClear.Text = "Save";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.button1_Click);
            // 
            // colorPicker
            // 
            this.colorPicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorPicker.Image = ((System.Drawing.Image)(resources.GetObject("colorPicker.Image")));
            this.colorPicker.Location = new System.Drawing.Point(8, 0);
            this.colorPicker.Name = "colorPicker";
            this.colorPicker.Size = new System.Drawing.Size(186, 101);
            this.colorPicker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.colorPicker.TabIndex = 7;
            this.colorPicker.TabStop = false;
            this.colorPicker.MouseClick += new System.Windows.Forms.MouseEventHandler(this.colorPicker_MouseClick);
            // 
            // buttonLine
            // 
            this.buttonLine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLine.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonLine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.buttonLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLine.Font = new System.Drawing.Font("Tahoma", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonLine.ForeColor = System.Drawing.SystemColors.Info;
            this.buttonLine.Image = global::LAB21_Lucero.Properties.Resources.line;
            this.buttonLine.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonLine.Location = new System.Drawing.Point(668, 22);
            this.buttonLine.Name = "buttonLine";
            this.buttonLine.Size = new System.Drawing.Size(64, 55);
            this.buttonLine.TabIndex = 5;
            this.buttonLine.Text = "Line";
            this.buttonLine.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonLine.UseVisualStyleBackColor = true;
            this.buttonLine.Click += new System.EventHandler(this.buttonLine_Click);
            // 
            // buttonRect
            // 
            this.buttonRect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonRect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.buttonRect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRect.Font = new System.Drawing.Font("Tahoma", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonRect.ForeColor = System.Drawing.SystemColors.Info;
            this.buttonRect.Image = ((System.Drawing.Image)(resources.GetObject("buttonRect.Image")));
            this.buttonRect.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonRect.Location = new System.Drawing.Point(599, 22);
            this.buttonRect.Name = "buttonRect";
            this.buttonRect.Size = new System.Drawing.Size(64, 55);
            this.buttonRect.TabIndex = 4;
            this.buttonRect.Text = "Rectangle";
            this.buttonRect.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonRect.UseVisualStyleBackColor = true;
            this.buttonRect.Click += new System.EventHandler(this.buttonRect_Click);
            // 
            // buttonEllipse
            // 
            this.buttonEllipse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEllipse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonEllipse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.buttonEllipse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEllipse.Font = new System.Drawing.Font("Tahoma", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonEllipse.ForeColor = System.Drawing.SystemColors.Info;
            this.buttonEllipse.Image = ((System.Drawing.Image)(resources.GetObject("buttonEllipse.Image")));
            this.buttonEllipse.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonEllipse.Location = new System.Drawing.Point(530, 22);
            this.buttonEllipse.Name = "buttonEllipse";
            this.buttonEllipse.Size = new System.Drawing.Size(64, 55);
            this.buttonEllipse.TabIndex = 3;
            this.buttonEllipse.Text = "Ellipse";
            this.buttonEllipse.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonEllipse.UseVisualStyleBackColor = true;
            this.buttonEllipse.Click += new System.EventHandler(this.buttonEllipse_Click);
            // 
            // buttonEraser
            // 
            this.buttonEraser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEraser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonEraser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.buttonEraser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEraser.Font = new System.Drawing.Font("Tahoma", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonEraser.ForeColor = System.Drawing.SystemColors.Info;
            this.buttonEraser.Image = global::LAB21_Lucero.Properties.Resources.eraser;
            this.buttonEraser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEraser.Location = new System.Drawing.Point(461, 22);
            this.buttonEraser.Name = "buttonEraser";
            this.buttonEraser.Size = new System.Drawing.Size(64, 55);
            this.buttonEraser.TabIndex = 3;
            this.buttonEraser.Text = "Eraser";
            this.buttonEraser.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonEraser.UseVisualStyleBackColor = true;
            this.buttonEraser.Click += new System.EventHandler(this.buttonEraser_Click);
            // 
            // buttonPencil
            // 
            this.buttonPencil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPencil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonPencil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.buttonPencil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPencil.Font = new System.Drawing.Font("Tahoma", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonPencil.ForeColor = System.Drawing.SystemColors.Info;
            this.buttonPencil.Image = ((System.Drawing.Image)(resources.GetObject("buttonPencil.Image")));
            this.buttonPencil.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonPencil.Location = new System.Drawing.Point(392, 22);
            this.buttonPencil.Name = "buttonPencil";
            this.buttonPencil.Size = new System.Drawing.Size(64, 55);
            this.buttonPencil.TabIndex = 3;
            this.buttonPencil.Text = "Pencil";
            this.buttonPencil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonPencil.UseVisualStyleBackColor = true;
            this.buttonPencil.Click += new System.EventHandler(this.buttonPencil_Click);
            // 
            // buttonFill
            // 
            this.buttonFill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFill.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonFill.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.buttonFill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFill.Font = new System.Drawing.Font("Tahoma", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonFill.ForeColor = System.Drawing.SystemColors.Info;
            this.buttonFill.Image = ((System.Drawing.Image)(resources.GetObject("buttonFill.Image")));
            this.buttonFill.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonFill.Location = new System.Drawing.Point(323, 22);
            this.buttonFill.Name = "buttonFill";
            this.buttonFill.Size = new System.Drawing.Size(64, 55);
            this.buttonFill.TabIndex = 3;
            this.buttonFill.Text = "Fill";
            this.buttonFill.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonFill.UseVisualStyleBackColor = true;
            this.buttonFill.Click += new System.EventHandler(this.buttonFill_Click);
            // 
            // buttonColor
            // 
            this.buttonColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonColor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonColor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.buttonColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonColor.Font = new System.Drawing.Font("Tahoma", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonColor.ForeColor = System.Drawing.SystemColors.Info;
            this.buttonColor.Image = global::LAB21_Lucero.Properties.Resources.color;
            this.buttonColor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonColor.Location = new System.Drawing.Point(255, 22);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(64, 55);
            this.buttonColor.TabIndex = 1;
            this.buttonColor.Text = "Color";
            this.buttonColor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonColor.UseVisualStyleBackColor = true;
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // picColor
            // 
            this.picColor.BackColor = System.Drawing.Color.White;
            this.picColor.Location = new System.Drawing.Point(203, 38);
            this.picColor.Name = "picColor";
            this.picColor.Size = new System.Drawing.Size(36, 28);
            this.picColor.TabIndex = 0;
            this.picColor.UseVisualStyleBackColor = false;
            this.picColor.Click += new System.EventHandler(this.picColor_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Bisque;
            this.panel3.Location = new System.Drawing.Point(246, 17);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(493, 65);
            this.panel3.TabIndex = 6;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Sienna;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 472);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(820, 31);
            this.panel2.TabIndex = 1;
            // 
            // pic
            // 
            this.pic.BackColor = System.Drawing.Color.White;
            this.pic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic.Location = new System.Drawing.Point(0, 0);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(820, 503);
            this.pic.TabIndex = 2;
            this.pic.TabStop = false;
            this.pic.Click += new System.EventHandler(this.pictureBox_Click);
            this.pic.Paint += new System.Windows.Forms.PaintEventHandler(this.pic_Paint);
            this.pic.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pic_MouseClick);
            this.pic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_MouseDown);
            this.pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic_MouseMove);
            this.pic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 503);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.colorPicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button buttonColor;
        private Button picColor;
        private Panel panel2;
        private PictureBox pic;
        private Button buttonLine;
        private Button buttonRect;
        private Button buttonEllipse;
        private Button buttonEraser;
        private Button buttonPencil;
        private Button buttonFill;
        private Panel panel3;
        private PictureBox colorPicker;
        private Button buttonClear;
        private Button button1;
    }
}