using System;
using System.Drawing;
using System.Windows.Forms;
using System.Media;

namespace GarthBrooksProject
{
    public partial class frmSplashScreen : Form
    {
        public frmSplashScreen()
        {
            InitializeComponent();
        }

        //  Global Constant
        const int NUMELEMENTS = 16;

        //  Global Array
        //string[] images =
        //{
        //    "C:\\Users\\Chadwick Acison\\Desktop\\GarthProject\\GarthBrooksProject\\GarthBrooksSolution\\GarthBrooksProject\\images\\garth00.jpg",
        //    "C:\\Users\\Chadwick Acison\\Desktop\\GarthProject\\GarthBrooksProject\\GarthBrooksSolution\\GarthBrooksProject\\images\\garth01.jpg",
        //    "C:\\Users\\Chadwick Acison\\Desktop\\GarthProject\\GarthBrooksProject\\GarthBrooksSolution\\GarthBrooksProject\\images\\garth02.jpg",
        //    "C:\\Users\\Chadwick Acison\\Desktop\\GarthProject\\GarthBrooksProject\\GarthBrooksSolution\\GarthBrooksProject\\images\\garth03.jpg",
        //    "C:\\Users\\Chadwick Acison\\Desktop\\GarthProject\\GarthBrooksProject\\GarthBrooksSolution\\GarthBrooksProject\\images\\garth04.jpg",
        //    "C:\\Users\\Chadwick Acison\\Desktop\\GarthProject\\GarthBrooksProject\\GarthBrooksSolution\\GarthBrooksProject\\images\\garth05.jpg",
        //    "C:\\Users\\Chadwick Acison\\Desktop\\GarthProject\\GarthBrooksProject\\GarthBrooksSolution\\GarthBrooksProject\\images\\garth06.jpg",
        //    "C:\\Users\\Chadwick Acison\\Desktop\\GarthProject\\GarthBrooksProject\\GarthBrooksSolution\\GarthBrooksProject\\images\\garth07.jpg",
        //    "C:\\Users\\Chadwick Acison\\Desktop\\GarthProject\\GarthBrooksProject\\GarthBrooksSolution\\GarthBrooksProject\\images\\garth08.jpg",
        //    "C:\\Users\\Chadwick Acison\\Desktop\\GarthProject\\GarthBrooksProject\\GarthBrooksSolution\\GarthBrooksProject\\images\\garth09.jpg",
        //    "C:\\Users\\Chadwick Acison\\Desktop\\GarthProject\\GarthBrooksProject\\GarthBrooksSolution\\GarthBrooksProject\\images\\garth10.jpg",
        //    "C:\\Users\\Chadwick Acison\\Desktop\\GarthProject\\GarthBrooksProject\\GarthBrooksSolution\\GarthBrooksProject\\images\\garth11.jpg",
        //    "C:\\Users\\Chadwick Acison\\Desktop\\GarthProject\\GarthBrooksProject\\GarthBrooksSolution\\GarthBrooksProject\\images\\garth12.jpg",
        //    "C:\\Users\\Chadwick Acison\\Desktop\\GarthProject\\GarthBrooksProject\\GarthBrooksSolution\\GarthBrooksProject\\images\\garth13.jpg",
        //    "C:\\Users\\Chadwick Acison\\Desktop\\GarthProject\\GarthBrooksProject\\GarthBrooksSolution\\GarthBrooksProject\\images\\garth14.jpg",
        //    "C:\\Users\\Chadwick Acison\\Desktop\\GarthProject\\GarthBrooksProject\\GarthBrooksSolution\\GarthBrooksProject\\images\\garth15.jpg",
        //};

        private void btnMainPage_Click(object sender, EventArgs e)
        {
            showMainForm();
        }

        private void showMainForm()
        {
            //close splashscreen than open MainPage
            Form mainForm = new frmMainPage();
            this.Hide();
            mainForm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            exitProgramOrNot();
        }

        private void exitProgramOrNot()
        {
            DialogResult dialog = MessageBox.Show(
            "Do You Really Want To Exit The Program?",
            "EXIT NOW?",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void frmSplashScreen_Load(object sender, EventArgs e)
        {
            //Fill Image boxes from list

            pb00.Image = Image.FromFile(AlbumImages.images[0]);
            pb01.Image = Image.FromFile(AlbumImages.images[1]);
            pb02.Image = Image.FromFile(AlbumImages.images[2]);
            pb03.Image = Image.FromFile(AlbumImages.images[3]);
            pb04.Image = Image.FromFile(AlbumImages.images[4]);
            pb05.Image = Image.FromFile(AlbumImages.images[5]);
            pb06.Image = Image.FromFile(AlbumImages.images[6]);
            pb07.Image = Image.FromFile(AlbumImages.images[7]);
            pb08.Image = Image.FromFile(AlbumImages.images[8]);
            pb09.Image = Image.FromFile(AlbumImages.images[9]);
            pb10.Image = Image.FromFile(AlbumImages.images[10]);
            pb11.Image = Image.FromFile(AlbumImages.images[11]);
            pb12.Image = Image.FromFile(AlbumImages.images[12]);
            pb13.Image = Image.FromFile(AlbumImages.images[13]);
            pb14.Image = Image.FromFile(AlbumImages.images[14]);
            pb15.Image = Image.FromFile(AlbumImages.images[15]);
        }

        private void mainPageMenuItem_Click(object sender, EventArgs e)
        {
            showMainForm();
        }

        private void helpMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Good Luck, I Believe in You!",
                            "YOU GOT THIS",
                            MessageBoxButtons.OK, 
                            MessageBoxIcon.Information);
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            exitProgramOrNot();
        }

        private void btnfunny_Click(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer("C:\\Users\\Chadwick Acison\\Desktop\\GarthProject\\GarthBrooksProject\\GarthBrooksSolution\\GarthBrooksProject\\sound.wav");
            splayer.Play();
        }
    }
}
