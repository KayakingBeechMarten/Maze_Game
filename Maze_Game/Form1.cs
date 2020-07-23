using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maze_Game
{
    public partial class Form1 : Form
    {
        System.Media.SoundPlayer startSoundPlayer = new System.Media.SoundPlayer(@"C:\Users\Deagan Mandeville\Downloads\smb_kick.wav");
        System.Media.SoundPlayer finishSoundPlayer = new System.Media.SoundPlayer(@"C:\Users\Deagan Mandeville\Downloads\smb_1-up.wav");
        public Form1()
        {
            InitializeComponent();
            MoveToStart();
        }

        private void finishlabel_MouseEnter(object sender, EventArgs e)
        {
            finishSoundPlayer.Play();
            MessageBox.Show("Congrats!");
            Close();
        }
        private void MoveToStart()
        {
            startSoundPlayer.Play();
            Point startingpoint = panel1.Location;
            startingpoint.Offset(10, 10);
            Cursor.Position = PointToScreen(startingpoint);
        }

        private void wall_mouseenter(object sender, EventArgs e)
        {
            MoveToStart();
        }
    }

}
