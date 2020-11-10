namespace ImgTools
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ilIcons = new System.Windows.Forms.ImageList(this.components);
            this.ilLargeIcons = new System.Windows.Forms.ImageList(this.components);
            this.pnPanel = new System.Windows.Forms.Panel();
            this.tvwFolders = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDwFrame = new System.Windows.Forms.Button();
            this.checkBoxAutosave = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBmp = new System.Windows.Forms.CheckBox();
            this.checkPng = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSetColor = new System.Windows.Forms.Button();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.checkTransparent = new System.Windows.Forms.CheckBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMargin = new System.Windows.Forms.TextBox();
            this.txtRows = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(697, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "t_menu";
            this.menuStrip1.Visible = false;
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // ilIcons
            // 
            this.ilIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilIcons.ImageStream")));
            this.ilIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.ilIcons.Images.SetKeyName(0, "folder");
            this.ilIcons.Images.SetKeyName(1, ".img");
            this.ilIcons.Images.SetKeyName(2, ".dat");
            // 
            // ilLargeIcons
            // 
            this.ilLargeIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilLargeIcons.ImageStream")));
            this.ilLargeIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.ilLargeIcons.Images.SetKeyName(0, "folder");
            this.ilLargeIcons.Images.SetKeyName(1, ".img");
            this.ilLargeIcons.Images.SetKeyName(2, ".dat");
            // 
            // pnPanel
            // 
            this.pnPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnPanel.Location = new System.Drawing.Point(196, 90);
            this.pnPanel.Name = "pnPanel";
            this.pnPanel.Size = new System.Drawing.Size(634, 352);
            this.pnPanel.TabIndex = 1;
            this.pnPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.pnPanel_Paint);
            // 
            // tvwFolders
            // 
            this.tvwFolders.Location = new System.Drawing.Point(12, 90);
            this.tvwFolders.Name = "tvwFolders";
            this.tvwFolders.Size = new System.Drawing.Size(178, 356);
            this.tvwFolders.TabIndex = 2;
            this.tvwFolders.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvwFolders_AfterSelect);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(655, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Todos Los Derechos Reservados";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label2.Location = new System.Drawing.Point(664, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "WWW.XFSGAMES.COM.AR";
            // 
            // btnDwFrame
            // 
            this.btnDwFrame.Location = new System.Drawing.Point(6, 43);
            this.btnDwFrame.Name = "btnDwFrame";
            this.btnDwFrame.Size = new System.Drawing.Size(156, 23);
            this.btnDwFrame.TabIndex = 5;
            this.btnDwFrame.Text = "save frame";
            this.btnDwFrame.UseVisualStyleBackColor = true;
            this.btnDwFrame.Click += new System.EventHandler(this.btnDwFrame_Click);
            // 
            // checkBoxAutosave
            // 
            this.checkBoxAutosave.AutoSize = true;
            this.checkBoxAutosave.Location = new System.Drawing.Point(6, 20);
            this.checkBoxAutosave.Name = "checkBoxAutosave";
            this.checkBoxAutosave.Size = new System.Drawing.Size(108, 17);
            this.checkBoxAutosave.TabIndex = 6;
            this.checkBoxAutosave.Text = "Auto Save Frame";
            this.checkBoxAutosave.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxAutosave);
            this.groupBox1.Controls.Add(this.btnDwFrame);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(168, 72);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Save Img";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBmp);
            this.groupBox2.Controls.Add(this.checkPng);
            this.groupBox2.Location = new System.Drawing.Point(196, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(89, 72);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "More Options";
            // 
            // checkBmp
            // 
            this.checkBmp.AutoSize = true;
            this.checkBmp.Location = new System.Drawing.Point(6, 43);
            this.checkBmp.Name = "checkBmp";
            this.checkBmp.Size = new System.Drawing.Size(52, 17);
            this.checkBmp.TabIndex = 1;
            this.checkBmp.Text = ".BMP";
            this.checkBmp.UseVisualStyleBackColor = true;
            this.checkBmp.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkPng
            // 
            this.checkPng.AutoSize = true;
            this.checkPng.Checked = true;
            this.checkPng.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkPng.Location = new System.Drawing.Point(6, 19);
            this.checkPng.Name = "checkPng";
            this.checkPng.Size = new System.Drawing.Size(52, 17);
            this.checkPng.TabIndex = 0;
            this.checkPng.Text = ".PNG";
            this.checkPng.UseVisualStyleBackColor = true;
            this.checkPng.CheckedChanged += new System.EventHandler(this.checkPng_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSetColor);
            this.groupBox3.Controls.Add(this.txtColor);
            this.groupBox3.Controls.Add(this.checkTransparent);
            this.groupBox3.Location = new System.Drawing.Point(303, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(223, 72);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Color Background Frame";
            // 
            // btnSetColor
            // 
            this.btnSetColor.Location = new System.Drawing.Point(161, 43);
            this.btnSetColor.Name = "btnSetColor";
            this.btnSetColor.Size = new System.Drawing.Size(56, 23);
            this.btnSetColor.TabIndex = 0;
            this.btnSetColor.Text = "set";
            this.btnSetColor.UseVisualStyleBackColor = true;
            this.btnSetColor.Click += new System.EventHandler(this.btnSetColor_Click);
            // 
            // txtColor
            // 
            this.txtColor.BackColor = System.Drawing.Color.LawnGreen;
            this.txtColor.Enabled = false;
            this.txtColor.Location = new System.Drawing.Point(7, 45);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(148, 20);
            this.txtColor.TabIndex = 1;
            // 
            // checkTransparent
            // 
            this.checkTransparent.AutoSize = true;
            this.checkTransparent.Checked = true;
            this.checkTransparent.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkTransparent.Location = new System.Drawing.Point(7, 20);
            this.checkTransparent.Name = "checkTransparent";
            this.checkTransparent.Size = new System.Drawing.Size(79, 17);
            this.checkTransparent.TabIndex = 0;
            this.checkTransparent.Text = "transparent";
            this.checkTransparent.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label3.Location = new System.Drawing.Point(675, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "mawi240818@gmail.com";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.txtMargin);
            this.groupBox4.Controls.Add(this.txtRows);
            this.groupBox4.Location = new System.Drawing.Point(532, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(117, 72);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Frame";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "margin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "rows";
            // 
            // txtMargin
            // 
            this.txtMargin.Location = new System.Drawing.Point(51, 45);
            this.txtMargin.Name = "txtMargin";
            this.txtMargin.Size = new System.Drawing.Size(60, 20);
            this.txtMargin.TabIndex = 1;
            // 
            // txtRows
            // 
            this.txtRows.Location = new System.Drawing.Point(51, 20);
            this.txtRows.Name = "txtRows";
            this.txtRows.Size = new System.Drawing.Size(60, 20);
            this.txtRows.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 454);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tvwFolders);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pnPanel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GIT - Nano";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ImageList ilIcons;
        private System.Windows.Forms.ImageList ilLargeIcons;
        private System.Windows.Forms.Panel pnPanel;
        private System.Windows.Forms.TreeView tvwFolders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDwFrame;
        private System.Windows.Forms.CheckBox checkBoxAutosave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBmp;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSetColor;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        public System.Windows.Forms.CheckBox checkTransparent;
        public System.Windows.Forms.CheckBox checkPng;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMargin;
        private System.Windows.Forms.TextBox txtRows;
    }
}