using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MusicLibrary2;


namespace GarthBrooksProject
{
    public partial class frmMainPage : Form
    {
        public frmMainPage()
        {
            InitializeComponent();
        }

        //connect Music Library to main Program
		BindingSource albumBindingSource = new BindingSource();
		AlbumsDAO albumsDAO = new AlbumsDAO();

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            loadAllMusicData();
        }

        private void loadAllMusicData()
        {
            AlbumsDAO albumsDAO = new AlbumsDAO();

            //connect list of albums to DGV
            albumBindingSource.DataSource = albumsDAO.GetAllAlbums();
            dgvAlbums.DataSource = albumBindingSource;
        }

        private void loadSearchMusicData()
        {
            AlbumsDAO albumsDAO = new AlbumsDAO();

            //connect list of albums to DGV
            albumBindingSource.DataSource = albumsDAO.GetSearchAlbums(txtAlbumSearch.Text);
            dgvAlbums.DataSource = albumBindingSource;
            pbCurrentAlbum.Image = null;
        }


        private void btnSplashScreen_Click(object sender, EventArgs e)
        {
            showSplashScreen();
        }

        private void showSplashScreen()
        {
            //Hide mainscreen and show splash
            Form splashScreen = new frmSplashScreen();
            this.Hide();
            splashScreen.ShowDialog();
        }

        private void btnAlbumSearch_Click(object sender, EventArgs e)
        {
            loadSearchMusicData();
        }

        private void dgvAlbums_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int rowClicked = dgv.CurrentRow.Index;
            string imageURL = dgv.Rows[rowClicked].Cells[5].Value.ToString();
            pbCurrentAlbum.Load(AlbumImages.images[rowClicked+1]);

        }

        private void BTNadd_Click(object sender, EventArgs e)
        {
            addAlbumToAlbumsTable();
        }

        private void addAlbumToAlbumsTable()
        {
            // create new album out of elements typed on main page
            Album album = new Album
            {
                AlbumName = txtName.Text,
                AlbumArtist = txtArt.Text,
                AlbumYear = Int32.Parse(txtYear.Text),
                AlbumDesc = txtdesc.Text,
                AlbumURL  = txtURL.Text
            };

            AlbumsDAO albumsDAO = new AlbumsDAO();
            int result = albumsDAO.addNewAlbum(album);
            MessageBox.Show("Number of new albums Inserted: " + result.ToString(), "NEW RECORD INSERTED?", MessageBoxButtons.OK, MessageBoxIcon.Information);

            clearOutAndAddNewRecordsFields();
        }

        private void clearOutAndAddNewRecordsFields()
        {
            txtName.Text = "";
            txtArt.Text = "";
            txtdesc.Text = "";
            txtURL.Text = "";
            txtYear.Text = "";
        }
    }
}
