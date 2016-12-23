using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongGame
{
    class QuizQuestion
    {

        private string question;
        public string Question { get { return question; } }
        private string answer;
        public string Answer { get { return answer; } }
        private List<string> falseAnswers;
        private Tuple<string, string> answerTuple;
        public List<string> FalseAnswers { get { return falseAnswers; } }

        private Random rand;

        public QuizQuestion(Tuple<string,string> answer, List<Tuple<string,string>> songList, Random rand)
        {
            this.answerTuple = answer;
            this.question = answerTuple.Item2;
            this.answer = answerTuple.Item1;
            this.rand = rand;
            falseAnswers = MakeFalseAnswers(songList);
            
        }

        private List<string> MakeFalseAnswers(List<Tuple<string,string>> songList)
        {
            List<string> falseAnswers = new List<string>();
            List<Tuple<string, string>> tempList = new List<Tuple<string, string>>(songList);
            tempList.Remove(answerTuple);
            for(int i = 0; i < 5; i++)
            {
                falseAnswers.Add(tempList.ElementAt(rand.Next(tempList.Count)).Item1);
            }
            falseAnswers.Add(answer);
            falseAnswers.OrderBy(item => rand.Next(falseAnswers.Count));
            return falseAnswers;
        }

        public bool CheckAnswer(string answerGiven)
        {
            if (answerGiven.Equals(answer))
                return true;
            else
                return false;
        }
    }
}
