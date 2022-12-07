namespace GarthBrooksProject
{
    partial class frmMainPage
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
            this.btnSplashScreen = new System.Windows.Forms.Button();
            this.btnLoadData = new System.Windows.Forms.Button();
            this.dgvAlbums = new System.Windows.Forms.DataGridView();
            this.btnAlbumSearch = new System.Windows.Forms.Button();
            this.txtAlbumSearch = new System.Windows.Forms.TextBox();
            this.pbCurrentAlbum = new System.Windows.Forms.PictureBox();
            this.bdAddNew = new System.Windows.Forms.GroupBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblArt = new System.Windows.Forms.Label();
            this.txtArt = new System.Windows.Forms.TextBox();
            this.lblyear = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.lblurl = new System.Windows.Forms.Label();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.lbldesc = new System.Windows.Forms.Label();
            this.txtdesc = new System.Windows.Forms.TextBox();
            this.BTNadd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlbums)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCurrentAlbum)).BeginInit();
            this.bdAddNew.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSplashScreen
            // 
            this.btnSplashScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSplashScreen.Location = new System.Drawing.Point(1282, 51);
            this.btnSplashScreen.Name = "btnSplashScreen";
            this.btnSplashScreen.Size = new System.Drawing.Size(178, 64);
            this.btnSplashScreen.TabIndex = 20;
            this.btnSplashScreen.Text = "SplashScreen";
            this.btnSplashScreen.UseVisualStyleBackColor = true;
            this.btnSplashScreen.Click += new System.EventHandler(this.btnSplashScreen_Click);
            // 
            // btnLoadData
            // 
            this.btnLoadData.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadData.Location = new System.Drawing.Point(267, 51);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(178, 64);
            this.btnLoadData.TabIndex = 19;
            this.btnLoadData.Text = "Load Data";
            this.btnLoadData.UseVisualStyleBackColor = true;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // dgvAlbums
            // 
            this.dgvAlbums.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlbums.Location = new System.Drawing.Point(267, 121);
            this.dgvAlbums.Name = "dgvAlbums";
            this.dgvAlbums.Size = new System.Drawing.Size(1193, 383);
            this.dgvAlbums.TabIndex = 21;
            this.dgvAlbums.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlbums_CellClick);
            // 
            // btnAlbumSearch
            // 
            this.btnAlbumSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlbumSearch.Location = new System.Drawing.Point(451, 51);
            this.btnAlbumSearch.Name = "btnAlbumSearch";
            this.btnAlbumSearch.Size = new System.Drawing.Size(178, 64);
            this.btnAlbumSearch.TabIndex = 22;
            this.btnAlbumSearch.Text = "Album Search";
            this.btnAlbumSearch.UseVisualStyleBackColor = true;
            this.btnAlbumSearch.Click += new System.EventHandler(this.btnAlbumSearch_Click);
            // 
            // txtAlbumSearch
            // 
            this.txtAlbumSearch.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlbumSearch.Location = new System.Drawing.Point(635, 51);
            this.txtAlbumSearch.Multiline = true;
            this.txtAlbumSearch.Name = "txtAlbumSearch";
            this.txtAlbumSearch.Size = new System.Drawing.Size(641, 64);
            this.txtAlbumSearch.TabIndex = 23;
            // 
            // pbCurrentAlbum
            // 
            this.pbCurrentAlbum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.pbCurrentAlbum.Location = new System.Drawing.Point(11, 177);
            this.pbCurrentAlbum.Name = "pbCurrentAlbum";
            this.pbCurrentAlbum.Size = new System.Drawing.Size(250, 250);
            this.pbCurrentAlbum.TabIndex = 24;
            this.pbCurrentAlbum.TabStop = false;
            // 
            // bdAddNew
            // 
            this.bdAddNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.bdAddNew.Controls.Add(this.BTNadd);
            this.bdAddNew.Controls.Add(this.lbldesc);
            this.bdAddNew.Controls.Add(this.txtdesc);
            this.bdAddNew.Controls.Add(this.lblurl);
            this.bdAddNew.Controls.Add(this.txtURL);
            this.bdAddNew.Controls.Add(this.lblyear);
            this.bdAddNew.Controls.Add(this.txtYear);
            this.bdAddNew.Controls.Add(this.lblArt);
            this.bdAddNew.Controls.Add(this.txtArt);
            this.bdAddNew.Controls.Add(this.lblName);
            this.bdAddNew.Controls.Add(this.txtName);
            this.bdAddNew.Location = new System.Drawing.Point(11, 514);
            this.bdAddNew.Name = "bdAddNew";
            this.bdAddNew.Size = new System.Drawing.Size(1449, 209);
            this.bdAddNew.TabIndex = 25;
            this.bdAddNew.TabStop = false;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(291, 39);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(263, 32);
            this.txtName.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.White;
            this.lblName.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(95, 38);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(169, 32);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Album Name:";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblArt
            // 
            this.lblArt.BackColor = System.Drawing.Color.White;
            this.lblArt.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArt.Location = new System.Drawing.Point(560, 39);
            this.lblArt.Name = "lblArt";
            this.lblArt.Size = new System.Drawing.Size(169, 32);
            this.lblArt.TabIndex = 3;
            this.lblArt.Text = "Album Artist:";
            this.lblArt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtArt
            // 
            this.txtArt.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArt.Location = new System.Drawing.Point(747, 40);
            this.txtArt.Name = "txtArt";
            this.txtArt.Size = new System.Drawing.Size(225, 32);
            this.txtArt.TabIndex = 2;
            // 
            // lblyear
            // 
            this.lblyear.BackColor = System.Drawing.Color.White;
            this.lblyear.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblyear.Location = new System.Drawing.Point(995, 38);
            this.lblyear.Name = "lblyear";
            this.lblyear.Size = new System.Drawing.Size(169, 32);
            this.lblyear.TabIndex = 5;
            this.lblyear.Text = "Album Year:";
            this.lblyear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtYear
            // 
            this.txtYear.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYear.Location = new System.Drawing.Point(1191, 39);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(175, 32);
            this.txtYear.TabIndex = 4;
            // 
            // lblurl
            // 
            this.lblurl.BackColor = System.Drawing.Color.White;
            this.lblurl.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblurl.Location = new System.Drawing.Point(95, 151);
            this.lblurl.Name = "lblurl";
            this.lblurl.Size = new System.Drawing.Size(169, 32);
            this.lblurl.TabIndex = 7;
            this.lblurl.Text = "Album URL:";
            this.lblurl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtURL
            // 
            this.txtURL.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtURL.Location = new System.Drawing.Point(291, 152);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(681, 32);
            this.txtURL.TabIndex = 6;
            // 
            // lbldesc
            // 
            this.lbldesc.BackColor = System.Drawing.Color.White;
            this.lbldesc.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldesc.Location = new System.Drawing.Point(95, 99);
            this.lbldesc.Name = "lbldesc";
            this.lbldesc.Size = new System.Drawing.Size(169, 32);
            this.lbldesc.TabIndex = 9;
            this.lbldesc.Text = "Album Desc:";
            this.lbldesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtdesc
            // 
            this.txtdesc.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdesc.Location = new System.Drawing.Point(291, 100);
            this.txtdesc.Name = "txtdesc";
            this.txtdesc.Size = new System.Drawing.Size(1075, 32);
            this.txtdesc.TabIndex = 8;
            // 
            // BTNadd
            // 
            this.BTNadd.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNadd.Location = new System.Drawing.Point(1122, 137);
            this.BTNadd.Name = "BTNadd";
            this.BTNadd.Size = new System.Drawing.Size(219, 64);
            this.BTNadd.TabIndex = 10;
            this.BTNadd.Text = "Add New Album";
            this.BTNadd.UseVisualStyleBackColor = true;
            this.BTNadd.Click += new System.EventHandler(this.BTNadd_Click);
            // 
            // frmMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1543, 809);
            this.Controls.Add(this.bdAddNew);
            this.Controls.Add(this.pbCurrentAlbum);
            this.Controls.Add(this.txtAlbumSearch);
            this.Controls.Add(this.btnAlbumSearch);
            this.Controls.Add(this.dgvAlbums);
            this.Controls.Add(this.btnSplashScreen);
            this.Controls.Add(this.btnLoadData);
            this.Name = "frmMainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Garth Brooks SQL Server Site - Main Page";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlbums)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCurrentAlbum)).EndInit();
            this.bdAddNew.ResumeLayout(false);
            this.bdAddNew.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSplashScreen;
        private System.Windows.Forms.Button btnLoadData;
        private System.Windows.Forms.DataGridView dgvAlbums;
        private System.Windows.Forms.Button btnAlbumSearch;
        private System.Windows.Forms.TextBox txtAlbumSearch;
        private System.Windows.Forms.PictureBox pbCurrentAlbum;
        private System.Windows.Forms.GroupBox bdAddNew;
        private System.Windows.Forms.Label lbldesc;
        private System.Windows.Forms.TextBox txtdesc;
        private System.Windows.Forms.Label lblurl;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Label lblyear;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label lblArt;
        private System.Windows.Forms.TextBox txtArt;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button BTNadd;
    }
}