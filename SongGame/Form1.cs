using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SongGame
{
    public partial class Form1 : Form
    {
        private int gameScore;
        private List<Tuple<string, string>> songList;

        public Form1()
        {
            InitializeComponent();
            gameScore = 0;
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            gameScore = 0;
        }
    }
}
