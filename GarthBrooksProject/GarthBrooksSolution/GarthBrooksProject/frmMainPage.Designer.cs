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
            this.dgvFacts = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlbums)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacts)).BeginInit();
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
            this.dgvAlbums.Size = new System.Drawing.Size(1193, 351);
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
            // dgvFacts
            // 
            this.dgvFacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacts.Location = new System.Drawing.Point(267, 527);
            this.dgvFacts.Name = "dgvFacts";
            this.dgvFacts.Size = new System.Drawing.Size(1193, 150);
            this.dgvFacts.TabIndex = 26;
            // 
            // frmMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1543, 809);
            this.Controls.Add(this.dgvFacts);
            this.Controls.Add(this.txtAlbumSearch);
            this.Controls.Add(this.btnAlbumSearch);
            this.Controls.Add(this.dgvAlbums);
            this.Controls.Add(this.btnSplashScreen);
            this.Controls.Add(this.btnLoadData);
            this.Name = "frmMainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Garth Brooks SQL Server Site - Main Page";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlbums)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSplashScreen;
        private System.Windows.Forms.Button btnLoadData;
        private System.Windows.Forms.DataGridView dgvAlbums;
        private System.Windows.Forms.Button btnAlbumSearch;
        private System.Windows.Forms.TextBox txtAlbumSearch;
        private System.Windows.Forms.DataGridView dgvFacts;
    }
}