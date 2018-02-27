namespace ImgurManager
{
    partial class FormHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.tcPrincipal = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnCopyLink = new System.Windows.Forms.Button();
            this.gbLink = new System.Windows.Forms.GroupBox();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.btnUploadImage = new System.Windows.Forms.Button();
            this.gbSelectFile = new System.Windows.Forms.GroupBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.txtFilename = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.gbAbout = new System.Windows.Forms.GroupBox();
            this.rtbCopyRight = new System.Windows.Forms.RichTextBox();
            this.pbAvatar = new System.Windows.Forms.PictureBox();
            this.ssStatus = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lblPowered = new System.Windows.Forms.Label();
            this.tcPrincipal.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbLink.SuspendLayout();
            this.gbSelectFile.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.gbAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).BeginInit();
            this.ssStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.Controls.Add(this.tabPage1);
            this.tcPrincipal.Controls.Add(this.tabPage3);
            this.tcPrincipal.Location = new System.Drawing.Point(11, 98);
            this.tcPrincipal.Name = "tcPrincipal";
            this.tcPrincipal.SelectedIndex = 0;
            this.tcPrincipal.Size = new System.Drawing.Size(408, 236);
            this.tcPrincipal.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnCopyLink);
            this.tabPage1.Controls.Add(this.gbLink);
            this.tabPage1.Controls.Add(this.btnUploadImage);
            this.tabPage1.Controls.Add(this.gbSelectFile);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(400, 210);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Upload";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnCopyLink
            // 
            this.btnCopyLink.Location = new System.Drawing.Point(203, 162);
            this.btnCopyLink.Name = "btnCopyLink";
            this.btnCopyLink.Size = new System.Drawing.Size(178, 23);
            this.btnCopyLink.TabIndex = 3;
            this.btnCopyLink.Text = "Copy Link";
            this.btnCopyLink.UseVisualStyleBackColor = true;
            this.btnCopyLink.Click += new System.EventHandler(this.btnCopyLink_Click);
            // 
            // gbLink
            // 
            this.gbLink.Controls.Add(this.txtLink);
            this.gbLink.Location = new System.Drawing.Point(17, 80);
            this.gbLink.Name = "gbLink";
            this.gbLink.Size = new System.Drawing.Size(364, 63);
            this.gbLink.TabIndex = 2;
            this.gbLink.TabStop = false;
            this.gbLink.Text = "Link";
            // 
            // txtLink
            // 
            this.txtLink.Location = new System.Drawing.Point(18, 28);
            this.txtLink.Name = "txtLink";
            this.txtLink.ReadOnly = true;
            this.txtLink.Size = new System.Drawing.Size(318, 20);
            this.txtLink.TabIndex = 0;
            // 
            // btnUploadImage
            // 
            this.btnUploadImage.Location = new System.Drawing.Point(17, 162);
            this.btnUploadImage.Name = "btnUploadImage";
            this.btnUploadImage.Size = new System.Drawing.Size(176, 23);
            this.btnUploadImage.TabIndex = 1;
            this.btnUploadImage.Text = "Upload Image";
            this.btnUploadImage.UseVisualStyleBackColor = true;
            this.btnUploadImage.Click += new System.EventHandler(this.btnUploadImage_Click);
            // 
            // gbSelectFile
            // 
            this.gbSelectFile.Controls.Add(this.btnLoad);
            this.gbSelectFile.Controls.Add(this.txtFilename);
            this.gbSelectFile.Location = new System.Drawing.Point(17, 17);
            this.gbSelectFile.Name = "gbSelectFile";
            this.gbSelectFile.Size = new System.Drawing.Size(364, 57);
            this.gbSelectFile.TabIndex = 0;
            this.gbSelectFile.TabStop = false;
            this.gbSelectFile.Text = "Select File";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(277, 19);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "...";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // txtFilename
            // 
            this.txtFilename.AllowDrop = true;
            this.txtFilename.Location = new System.Drawing.Point(17, 19);
            this.txtFilename.Name = "txtFilename";
            this.txtFilename.ReadOnly = true;
            this.txtFilename.Size = new System.Drawing.Size(253, 20);
            this.txtFilename.TabIndex = 0;
            this.txtFilename.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtFilename_DragDrop);
            this.txtFilename.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtFilename_DragEnter);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.gbAbout);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(400, 210);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "About";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // gbAbout
            // 
            this.gbAbout.Controls.Add(this.rtbCopyRight);
            this.gbAbout.Controls.Add(this.pbAvatar);
            this.gbAbout.Location = new System.Drawing.Point(21, 19);
            this.gbAbout.Name = "gbAbout";
            this.gbAbout.Size = new System.Drawing.Size(352, 176);
            this.gbAbout.TabIndex = 0;
            this.gbAbout.TabStop = false;
            // 
            // rtbCopyRight
            // 
            this.rtbCopyRight.Location = new System.Drawing.Point(199, 62);
            this.rtbCopyRight.Name = "rtbCopyRight";
            this.rtbCopyRight.ReadOnly = true;
            this.rtbCopyRight.Size = new System.Drawing.Size(134, 49);
            this.rtbCopyRight.TabIndex = 1;
            this.rtbCopyRight.Text = "Imgur Manager\nVersion 0.3\nCoded By Ismael Heredia";
            // 
            // pbAvatar
            // 
            this.pbAvatar.Image = ((System.Drawing.Image)(resources.GetObject("pbAvatar.Image")));
            this.pbAvatar.Location = new System.Drawing.Point(17, 19);
            this.pbAvatar.Name = "pbAvatar";
            this.pbAvatar.Size = new System.Drawing.Size(176, 143);
            this.pbAvatar.TabIndex = 0;
            this.pbAvatar.TabStop = false;
            // 
            // ssStatus
            // 
            this.ssStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.ssStatus.Location = new System.Drawing.Point(0, 393);
            this.ssStatus.Name = "ssStatus";
            this.ssStatus.Size = new System.Drawing.Size(431, 22);
            this.ssStatus.TabIndex = 1;
            this.ssStatus.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(58, 17);
            this.toolStripStatusLabel1.Text = "[+] Ready";
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(15, 13);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(400, 79);
            this.pbLogo.TabIndex = 2;
            this.pbLogo.TabStop = false;
            // 
            // lblPowered
            // 
            this.lblPowered.AutoSize = true;
            this.lblPowered.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPowered.Location = new System.Drawing.Point(122, 352);
            this.lblPowered.Name = "lblPowered";
            this.lblPowered.Size = new System.Drawing.Size(154, 20);
            this.lblPowered.TabIndex = 3;
            this.lblPowered.Text = "Powered By Imgur";
            this.lblPowered.Click += new System.EventHandler(this.lblPowered_Click);
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 415);
            this.Controls.Add(this.lblPowered);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.ssStatus);
            this.Controls.Add(this.tcPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormHome";
            this.Text = " - Imgur Manager 0.3 - © Ismael Heredia , Argentina , 2017 -";
            this.Load += new System.EventHandler(this.FormHome_Load);
            this.tcPrincipal.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.gbLink.ResumeLayout(false);
            this.gbLink.PerformLayout();
            this.gbSelectFile.ResumeLayout(false);
            this.gbSelectFile.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.gbAbout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).EndInit();
            this.ssStatus.ResumeLayout(false);
            this.ssStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcPrincipal;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox gbSelectFile;
        private System.Windows.Forms.Button btnUploadImage;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TextBox txtFilename;
        private System.Windows.Forms.StatusStrip ssStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.GroupBox gbAbout;
        private System.Windows.Forms.RichTextBox rtbCopyRight;
        private System.Windows.Forms.PictureBox pbAvatar;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblPowered;
        private System.Windows.Forms.Button btnCopyLink;
        private System.Windows.Forms.GroupBox gbLink;
        private System.Windows.Forms.TextBox txtLink;

    }
}

