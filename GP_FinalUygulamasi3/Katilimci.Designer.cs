namespace GP_FinalUygulamasi3
{
    partial class Katilimci
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Katilimci));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnRenk = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.imgButon = new System.Windows.Forms.ImageList(this.components);
            this.btnOnayla = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDoluluk = new System.Windows.Forms.Label();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.lstKatilimcilar = new System.Windows.Forms.ListBox();
            this.lblSayi = new System.Windows.Forms.Label();
            this.pnlMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(129)))), ((int)(((byte)(87)))));
            this.pnlMenu.Controls.Add(this.btnCikis);
            this.pnlMenu.Controls.Add(this.btnRenk);
            this.pnlMenu.Controls.Add(this.btnKapat);
            this.pnlMenu.Controls.Add(this.btnOnayla);
            this.pnlMenu.Controls.Add(this.panel1);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(194, 471);
            this.pnlMenu.TabIndex = 8;
            // 
            // btnRenk
            // 
            this.btnRenk.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnRenk.Enabled = false;
            this.btnRenk.FlatAppearance.BorderSize = 0;
            this.btnRenk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRenk.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(162)));
            this.btnRenk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(215)))), ((int)(((byte)(205)))));
            this.btnRenk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRenk.Location = new System.Drawing.Point(0, 440);
            this.btnRenk.Name = "btnRenk";
            this.btnRenk.Size = new System.Drawing.Size(194, 31);
            this.btnRenk.TabIndex = 12;
            this.btnRenk.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRenk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRenk.UseVisualStyleBackColor = true;
            // 
            // btnKapat
            // 
            this.btnKapat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKapat.FlatAppearance.BorderSize = 0;
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(162)));
            this.btnKapat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(215)))), ((int)(((byte)(205)))));
            this.btnKapat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKapat.ImageIndex = 3;
            this.btnKapat.ImageList = this.imgButon;
            this.btnKapat.Location = new System.Drawing.Point(0, 131);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(194, 51);
            this.btnKapat.TabIndex = 11;
            this.btnKapat.Text = "ANA YAPIYA DÖN";
            this.btnKapat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKapat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // imgButon
            // 
            this.imgButon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgButon.ImageStream")));
            this.imgButon.TransparentColor = System.Drawing.Color.Transparent;
            this.imgButon.Images.SetKeyName(0, "exit.png");
            this.imgButon.Images.SetKeyName(1, "info.png");
            this.imgButon.Images.SetKeyName(2, "correct.png");
            this.imgButon.Images.SetKeyName(3, "Go-back-icon.png");
            // 
            // btnOnayla
            // 
            this.btnOnayla.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOnayla.FlatAppearance.BorderSize = 0;
            this.btnOnayla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOnayla.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(162)));
            this.btnOnayla.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(215)))), ((int)(((byte)(205)))));
            this.btnOnayla.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOnayla.ImageIndex = 2;
            this.btnOnayla.ImageList = this.imgButon;
            this.btnOnayla.Location = new System.Drawing.Point(0, 80);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(194, 51);
            this.btnOnayla.TabIndex = 10;
            this.btnOnayla.Text = "ONAYLA";
            this.btnOnayla.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOnayla.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOnayla.UseVisualStyleBackColor = true;
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 80);
            this.panel1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Impact", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(215)))), ((int)(((byte)(205)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 80);
            this.label1.TabIndex = 10;
            this.label1.Text = "TG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDoluluk
            // 
            this.lblDoluluk.AutoSize = true;
            this.lblDoluluk.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(162)));
            this.lblDoluluk.Location = new System.Drawing.Point(201, 440);
            this.lblDoluluk.Name = "lblDoluluk";
            this.lblDoluluk.Size = new System.Drawing.Size(199, 22);
            this.lblDoluluk.TabIndex = 11;
            this.lblDoluluk.Text = "< DOLULUK ORANI :";
            // 
            // btnInfo
            // 
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.ImageIndex = 1;
            this.btnInfo.ImageList = this.imgButon;
            this.btnInfo.Location = new System.Drawing.Point(665, 0);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(43, 45);
            this.btnInfo.TabIndex = 12;
            this.btnInfo.UseVisualStyleBackColor = true;
            // 
            // btnCikis
            // 
            this.btnCikis.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCikis.FlatAppearance.BorderSize = 0;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(162)));
            this.btnCikis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(215)))), ((int)(((byte)(205)))));
            this.btnCikis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCikis.ImageIndex = 0;
            this.btnCikis.ImageList = this.imgButon;
            this.btnCikis.Location = new System.Drawing.Point(0, 182);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(194, 51);
            this.btnCikis.TabIndex = 13;
            this.btnCikis.Text = "UYGULAMADAN ÇIK";
            this.btnCikis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCikis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // lstKatilimcilar
            // 
            this.lstKatilimcilar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(215)))), ((int)(((byte)(205)))));
            this.lstKatilimcilar.FormattingEnabled = true;
            this.lstKatilimcilar.Location = new System.Drawing.Point(347, 122);
            this.lstKatilimcilar.Name = "lstKatilimcilar";
            this.lstKatilimcilar.Size = new System.Drawing.Size(214, 238);
            this.lstKatilimcilar.TabIndex = 0;
            // 
            // lblSayi
            // 
            this.lblSayi.AutoSize = true;
            this.lblSayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(162)));
            this.lblSayi.Location = new System.Drawing.Point(406, 442);
            this.lblSayi.Name = "lblSayi";
            this.lblSayi.Size = new System.Drawing.Size(0, 22);
            this.lblSayi.TabIndex = 13;
            // 
            // Katilimci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(177)))), ((int)(((byte)(138)))));
            this.ClientSize = new System.Drawing.Size(708, 471);
            this.Controls.Add(this.lblSayi);
            this.Controls.Add(this.lstKatilimcilar);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.lblDoluluk);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Katilimci";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Katilimci";
            this.Load += new System.EventHandler(this.Katilimci_Load);
            this.pnlMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnOnayla;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRenk;
        private System.Windows.Forms.ImageList imgButon;
        private System.Windows.Forms.Label lblDoluluk;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.ListBox lstKatilimcilar;
        private System.Windows.Forms.Label lblSayi;
    }
}