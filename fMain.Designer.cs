namespace Lab5
{
    partial class fMain
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            toolStrip1 = new ToolStrip();
            btnAdd = new ToolStripButton();
            btnEdit = new ToolStripButton();
            tsSeparator1 = new ToolStripSeparator();
            btnDel = new ToolStripButton();
            btnClear = new ToolStripButton();
            tsSeparator2 = new ToolStripSeparator();
            btnExit = new ToolStripButton();
            bindSrcBicycles = new BindingSource(components);
            gvBicycles = new DataGridView();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindSrcBicycles).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gvBicycles).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnAdd, btnEdit, tsSeparator1, btnDel, btnClear, tsSeparator2, btnExit });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 27);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnAdd
            // 
            btnAdd.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnAdd.Image = (Image)resources.GetObject("btnAdd.Image");
            btnAdd.ImageTransparentColor = Color.Magenta;
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(29, 24);
            btnAdd.Text = "Додати запис про велосипед";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnEdit.Image = (Image)resources.GetObject("btnEdit.Image");
            btnEdit.ImageTransparentColor = Color.Magenta;
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(29, 24);
            btnEdit.Text = "Редагувати запис ";
            btnEdit.Click += btnEdit_Click;
            // 
            // tsSeparator1
            // 
            tsSeparator1.Name = "tsSeparator1";
            tsSeparator1.Size = new Size(6, 27);
            // 
            // btnDel
            // 
            btnDel.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnDel.Image = (Image)resources.GetObject("btnDel.Image");
            btnDel.ImageTransparentColor = Color.Magenta;
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(29, 24);
            btnDel.Text = "Видалити запис";
            btnDel.Click += btnDel_Click;
            // 
            // btnClear
            // 
            btnClear.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnClear.Image = (Image)resources.GetObject("btnClear.Image");
            btnClear.ImageTransparentColor = Color.Magenta;
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(29, 24);
            btnClear.Text = "Очистити дані";
            btnClear.Click += btnClear_Click;
            // 
            // tsSeparator2
            // 
            tsSeparator2.Name = "tsSeparator2";
            tsSeparator2.Size = new Size(6, 27);
            // 
            // btnExit
            // 
            btnExit.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.ImageTransparentColor = Color.Magenta;
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(29, 24);
            btnExit.Text = "Вийти з програми";
            btnExit.Click += btnExit_Click;
            // 
            // gvBicycles
            // 
            gvBicycles.AllowUserToAddRows = false;
            gvBicycles.AllowUserToDeleteRows = false;
            gvBicycles.AutoGenerateColumns = false;
            gvBicycles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvBicycles.DataSource = bindSrcBicycles;
            gvBicycles.Dock = DockStyle.Fill;
            gvBicycles.Location = new Point(0, 27);
            gvBicycles.Margin = new Padding(3, 4, 3, 4);
            gvBicycles.Name = "gvBicycles";
            gvBicycles.ReadOnly = true;
            gvBicycles.RowHeadersWidth = 51;
            gvBicycles.RowTemplate.Height = 24;
            gvBicycles.Size = new Size(800, 535);
            gvBicycles.TabIndex = 1;
            // 
            // fMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 562);
            Controls.Add(gvBicycles);
            Controls.Add(toolStrip1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "fMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Лабораторна робота 5";
            Load += fMain_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindSrcBicycles).EndInit();
            ((System.ComponentModel.ISupportInitialize)gvBicycles).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnEdit;
        private System.Windows.Forms.ToolStripSeparator tsSeparator1;
        private System.Windows.Forms.ToolStripButton btnDel;
        private System.Windows.Forms.ToolStripButton btnClear;
        private System.Windows.Forms.ToolStripSeparator tsSeparator2;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.BindingSource bindSrcBicycles;
        private System.Windows.Forms.DataGridView gvBicycles;
    }
}

