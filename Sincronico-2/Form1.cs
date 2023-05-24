using System;
using System.Drawing.Drawing2D;
using System.Threading;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;

namespace Sincronico_1
{
    public partial class Form1 : Form
    {
        private SoundPlayer player;

        string imagepath = System.Reflection.Assembly.GetExecutingAssembly()
               .Location + @"\..\..\..\..\Resources\maxwell-the-cat-maxwell.gif";

        string soundpath = System.Reflection.Assembly.GetExecutingAssembly()
                   .Location + @"\..\..\..\..\Resources\Maxwell the Cat Theme.wav";

        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            tenorgif.Visible = true;
            PlaySound();

            //await Task.Delay(43000);

            await Wait();

            MessageBox.Show("ｍａｘｗｅｌｌ");

            tenorgif.Visible = false;
            StopSound();
        }

        private async Task Wait()
        {
            await Task.Delay(43000);
        }

        private void PlaySound()
        {
            try
            {
                player = new SoundPlayer(soundpath);
                player.Play();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al reproducir el sonido." + ex.Message);
            }
        }

        private void StopSound()
        {
            try
            {
                player.Stop();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al detener el sonido." + ex.Message);
            }
            finally
            {
                player.Dispose();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            tenorgif.Visible = false;
            tenorgif.Image = Image.FromFile(imagepath);
            RoundButtons(button1);
            RoundButtons(button2);

            player = new SoundPlayer(soundpath);
        }

        #region "meh, extras"
        public Button RoundButtons(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = Color.FromArgb(57, 62, 65);
            btn.ForeColor = Color.White;
            btn.Cursor = Cursors.Hand;

            using (GraphicsPath Raduis = new GraphicsPath())
            {
                Raduis.StartFigure();

                Raduis.AddArc(new Rectangle(0, 0, 20, 20), 180, 90);

                Raduis.AddLine(10, 0, btn.Width - 20, 0);

                Raduis.AddArc(new Rectangle(btn.Width - 20, 0, 20, 20), -90, 90);

                Raduis.AddLine(btn.Width, 20, btn.Width, btn.Height - 10);

                Raduis.AddArc(new Rectangle(btn.Width - 25, btn.Height - 25, 25, 25), 0, 90);

                Raduis.AddLine(btn.Width - 10, btn.Width, 20, btn.Height);

                Raduis.AddArc(new Rectangle(0, btn.Height - 20, 20, 20), 90, 90);

                Raduis.CloseFigure();

                btn.Region = new Region(Raduis);
            }

            return btn;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
    }
}