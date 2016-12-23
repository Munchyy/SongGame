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
        List<Button> buttonList;
        private List<QuizQuestion> questions;
        private Random rand;

        public Form1()
        {
            InitializeComponent();
            //get answerButtons in a list to access them easily
            buttonList = new List<Button>();
            buttonList.Add(answerButton1);
            buttonList.Add(answerButton2);
            buttonList.Add(answerButton3);
            buttonList.Add(answerButton4);
            buttonList.Add(answerButton5);
            buttonList.Add(answerButton6);

            //set size and height for each button
            foreach(Button button in buttonList)
            {
                button.Height = (answerLayoutPanel.Height / 2) - 10;
                button.Width = (answerLayoutPanel.Width / 3) - 10;
            }

            correctLabel.Text = "";

            //make random
            rand = new Random();
            //init game score label
            gameScore = 0;
            scoreLabel.Text = gameScore.ToString();

            //fetch the chart music info
            ChartSongFinder.Radio1ChartSongFinder songFinder = new ChartSongFinder.Radio1ChartSongFinder();
            songList = songFinder.Top40List;

            //get the first round of 40 questions
            questions = MakeQuiz();
            SetQuiz(questions.ElementAt(0));

        }

        ///get a QuizQuestion for each entry,
        ///this is the answer, the question and a list of false answers
        ///that can not also be a correct answer
        private List<QuizQuestion> MakeQuiz()
        {
            
            List<QuizQuestion> questions = new List<QuizQuestion>();
            ShuffleSongs();
            foreach(Tuple<string,string> tuple in songList)
            {
                questions.Add(new QuizQuestion(tuple, songList, rand));
            }
            return questions;
        }

        private void ShowScoreScreen()
        {
            if(gameScore == 40)
                MessageBox.Show("You got 100% Right!", "Game Over");
            else
                MessageBox.Show(String.Format("Game is finished, your score is: {0}/40", gameScore), "Game Over");
        }

        private void SetQuiz(QuizQuestion question)
        {
            List<string> possibleAnswers = question.FalseAnswers;
            int randInt = new Random().Next(6);
            possibleAnswers.Insert(randInt, question.Answer);
            int index = 0;

            //set the answers to the buttons
            foreach(Button but in buttonList)
            {
                but.Text = possibleAnswers.ElementAt(index);
                index++;
            }
            songNameLabel.Text = question.Question;
        }

        
        private void restartButton_Click(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void RestartGame()
        {
            ShowScoreScreen();
            gameScore = 0;
            scoreLabel.Text = gameScore.ToString();
            questions = MakeQuiz();
            SetQuiz(questions.ElementAt(0));
        }

        private void answerButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            if (questions.ElementAt(0).CheckAnswer(clickedButton.Text))
            {
                gameScore++;
                scoreLabel.Text = gameScore.ToString();
                correctLabel.Text = "Correct";
            }
            else
            {
                correctLabel.Text = "Incorrect";
                MessageBox.Show(String.Format("Incorrect. The answer was: {0}", questions.ElementAt(0).Answer),"Wrong Answer");
            }
            questions.RemoveAt(0);
            if (questions.Count > 0)
                SetQuiz(questions.ElementAt(0));
            else RestartGame();
        }

        private void ShuffleSongs()
        {
            int n = songList.Count;
            while (n > 1)
            {
                n--;
                int k = rand.Next(n + 1);
                Tuple<string,string> value = songList[k];
                songList[k] = songList[n];
                songList[n] = value;
            }
        } 
    }
}
