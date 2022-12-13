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
        BindingSource factsBindingSource= new BindingSource();

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
        }
        private void loadAlbumData()
        {
            AlbumsDAO albumsDAO = new AlbumsDAO();

            //connect list of albums to DGV
            albumBindingSource.DataSource = albumsDAO.GetAlbumFacts(txtAlbumSearch.Text);
            dgvAlbums.DataSource = albumBindingSource;
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

            AlbumsDAO albumsDAO = new AlbumsDAO();
            factsBindingSource.DataSource = albumsDAO.GetAlbumFacts(dgvAlbums.Rows[rowClicked].ToString());

            dgvFacts.DataSource = factsBindingSource;
        }
    }
}
