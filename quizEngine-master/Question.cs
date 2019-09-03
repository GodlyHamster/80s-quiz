using System;
using System.Collections.Generic;
using System.Threading;
using System.IO;

namespace quizEngine{
    class Question{

        Random rnd = new Random();

        private string question;
        private int value;
        private List<Answer> options;
        private int correctIndex;
        
        public Question(string question, int value, List<Answer> options, int correctIndex){
            this.question = question;
            this.value = value;
            this.options = options;
            this.correctIndex = correctIndex;
        }
        public string GetString(){
            return this.question;
        }
        public List<Answer> GetOptions(){
            return options;
        }
        public int AnswerIt(int answerIndex){
            if(answerIndex == correctIndex){
                return value;
            } 
            return -1;
        }
    }
}