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
            ChartSongFinder.Radio1ChartSongFinder songFinder = new ChartSongFinder.Radio1ChartSongFinder();
            songList = songFinder.Top40List;
            RunQuiz();
            RestartGame();

        }

        private void RunQuiz()
        {
            List<string> falseAnswers = new List<string>();
            Tuple<string, string> answer = null;
            List<int> usedAnswers = new List<int>();
            while (falseAnswers != null)
            {
                answer = MakeQuiz(songList,usedAnswers, out falseAnswers);

                //logic to display question/answers and keep score
                
            }
            RestartGame();
        }

        private void ShowScoreScreen()
        {
            MessageBox.Show(String.Format("Game is finished, your score is: {0}", gameScore), "Game Over");
        }

        //Takes a list of 40 songs, returns the answer tuple and an out parameter
        //of the false answers
        private Tuple<string,string> MakeQuiz(List<Tuple<string,string>> songList, List<int> usedAnswers, out List<string> falseAnswers)
        {
            if(usedAnswers.Count == 40)
            {
                falseAnswers = null;
                return new Tuple<string, string>(null, null);
            }
            falseAnswers = new List<string>();
            Random rnd = new Random();
            int randInt = rnd.Next(0, 39);
            while(usedAnswers.Contains(randInt))
            {
                randInt = rnd.Next(0, 39);
            }
            Tuple<string, string> answerTuple = songList.ElementAt(randInt);

            for(int i = 0; i < 5; i++)
            {
                int rInt = rnd.Next(0, 39);
                while(rInt == randInt)
                {
                    rInt = rnd.Next(0, 39);
                }
                falseAnswers.Add(songList.ElementAt(rInt).Item1);
            }

            return answerTuple;
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void RestartGame()
        {
            ShowScoreScreen();
            gameScore = 0;
            RunQuiz();
        }
    }
}
