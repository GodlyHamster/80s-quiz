using System;
using System.Collections.Generic;
using System.Threading;
using System.IO;


namespace quizEngine
{
    class Program
    {
        private static int score = 0;
        static void Main(string[] args)
        {   
            Random rnd = new Random();

            //all questions
            String[] test = new String[] {
            "In welk jaar kwam: 'Take on me' uit?", 
            "Maak de titel van het lied af: 'Another one bite's the ... '", 
            "Van wie is het lied: 'Livin' on a prayer' ?", 
            "Wat is de Nr.1 hit van de jaren 80?",
            "Van wie het lied: 'Thriller' ?",
            "Typ in getallen de juiste volgorde van wanneer welk lied uitkwam (van begin tot eind)",
            "Van Wie is het lied: 'Here I Go Again' ?",
            "In welk jaar kwam: 'Africa' uit?",
            "Typ in getallen de juiste volgorde van wanneer welk lied uitkwam (van begin tot eind)",
            "Maak de Titel van het lied af: 'Addicted to ...'"};

            //correct answers: 2-3-2-3-1-132-1-2-321-2
            String[] ansQ1 = new String[] {"1983", "1985", "1989"};
            String[] ansQ2 = new String[] {"crust", "cheese", "dust"};
            String[] ansQ3 = new String[] {"Bruce Springsteen", "Bon Jovi", "New Order"};
            String[] ansQ4 = new String[] {"David's song", "I have a dream", "Weekend"};
            String[] ansQ5 = new String[] {"Michael Jackson", "Guns 'n Roses", "Bon Jovi"};
            String[] ansQ6 = new String[] {"Blue Monday", "Sweet Child o' Mine", "Take On Me"};
            String[] ansQ7 = new String[] {"WhiteSnake", "Duran Duran", "Madonna"};
            String[] ansQ8 = new String[] {"1986", "1982", "1988"};
            String[] ansQ9 = new String[] {"You Spin Me Round", "Jump", "The Reflex"};
            String[] ansQ10 = new String[] {"You", "Love", "Coke"};
            int CorrectAns = 0;
       
            Console.ForegroundColor = ConsoleColor.White;
            
            //loop through questions
            int i = 1;
            int u = 0;
            int LostPoints = 0;
            int QuestionScore;
            String QuestionAnswers = "";
            String QuestionName = "test";
            for(int p = 0; p < 10; p++){
                u = 0;
                Console.Clear();
                Console.WriteLine("Score : "+score);
                int QuestionNumber = rnd.Next(test.Length);
                if (QuestionNumber == 0){
                    QuestionName = test[QuestionNumber];
                    QuestionScore = 100;
                    CorrectAns = 2;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Points to get: " + QuestionScore);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Points lost: " + LostPoints);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("question "+i+": "+ QuestionName);
                    int j = 0;
                    for (int ans = 0; ans < 3; ans++){
                        QuestionAnswers = ansQ1[u];
                        u++;
                        j++;
                        Console.WriteLine("Type  "+ j + " for : "+QuestionAnswers);
                    }
                } else if (QuestionNumber == 1) {
                    QuestionName = test[QuestionNumber];
                    QuestionScore = 50;
                    CorrectAns = 3;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Points to get: " + QuestionScore);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Points lost: " + LostPoints);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("question "+i+": "+ QuestionName);
                    int j = 0;
                    for (int ans = 0; ans < 3; ans++){
                        QuestionAnswers = ansQ2[u];
                        u++;
                        j++;
                        Console.WriteLine("Type  "+ j + " for : "+QuestionAnswers);
                    }
                } else if (QuestionNumber == 2) {
                    QuestionName = test[QuestionNumber];
                    QuestionScore = 100;
                    CorrectAns = 2;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Points to get: " + QuestionScore);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Points lost: " + LostPoints);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("question "+i+": "+ QuestionName);
                    int j = 0;
                    for (int ans = 0; ans < 3; ans++){
                        QuestionAnswers = ansQ3[u];
                        u++;
                        j++;
                        Console.WriteLine("Type  "+ j + " for : "+QuestionAnswers);
                    }
                } else if (QuestionNumber == 3) {
                    QuestionName = test[QuestionNumber];
                    QuestionScore = 80;
                    CorrectAns = 3;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Points to get: " + QuestionScore);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Points lost: " + LostPoints);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("question "+i+": "+ QuestionName);
                    int j = 0;
                    for (int ans = 0; ans < 3; ans++){
                        QuestionAnswers = ansQ4[u];
                        u++;
                        j++;
                        Console.WriteLine("Type  "+ j + " for : "+QuestionAnswers);
                    }
                } else if (QuestionNumber == 4) {
                    QuestionName = test[QuestionNumber];
                    QuestionScore = 50;
                    CorrectAns = 1;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Points to get: " + QuestionScore);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Points lost: " + LostPoints);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("question "+i+": "+ QuestionName);
                    int j = 0;
                    for (int ans = 0; ans < 3; ans++){
                        QuestionAnswers = ansQ5[u];
                        u++;
                        j++;
                        Console.WriteLine("Type  "+ j + " for : "+QuestionAnswers);
                    }
                } else if (QuestionNumber == 5) {
                    QuestionName = test[QuestionNumber];
                    QuestionScore = 100;
                    CorrectAns = 132;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Points to get: " + QuestionScore);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Points lost: " + LostPoints);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("question "+i+": "+ QuestionName);
                    int j = 0;
                    for (int ans = 0; ans < 3; ans++){
                        QuestionAnswers = ansQ6[u];
                        u++;
                        j++;
                        Console.WriteLine("Type  "+ j + " for : "+QuestionAnswers);
                    }
                } else if (QuestionNumber == 6) {
                    QuestionName = test[QuestionNumber];
                    QuestionScore = 100;
                    CorrectAns = 1;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Points to get: " + QuestionScore);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Points lost: " + LostPoints);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("question "+i+": "+ QuestionName);
                    int j = 0;
                    for (int ans = 0; ans < 3; ans++){
                        QuestionAnswers = ansQ7[u];
                        u++;
                        j++;
                        Console.WriteLine("Type  "+ j + " for : "+QuestionAnswers);
                    }
                } else if (QuestionNumber == 7) {
                    QuestionName = test[QuestionNumber];
                    QuestionScore = 100;
                    CorrectAns = 2;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Points to get: " + QuestionScore);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Points lost: " + LostPoints);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("question "+i+": "+ QuestionName);
                    int j = 0;
                    for (int ans = 0; ans < 3; ans++){
                        QuestionAnswers = ansQ8[u];
                        u++;
                        j++;
                        Console.WriteLine("Type  "+ j + " for : "+QuestionAnswers);
                    }
                } else if (QuestionNumber == 8) {
                    QuestionName = test[QuestionNumber];
                    QuestionScore = 100;
                    CorrectAns = 321;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Points to get: " + QuestionScore);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Points lost: " + LostPoints);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("question "+i+": "+ QuestionName);
                    int j = 0;
                    for (int ans = 0; ans < 3; ans++){
                        QuestionAnswers = ansQ9[u];
                        u++;
                        j++;
                        Console.WriteLine("Type  "+ j + " for : "+QuestionAnswers);
                    }
                } else if (QuestionNumber == 9) {
                    QuestionName = test[QuestionNumber];
                    QuestionScore = 100;
                    CorrectAns = 2;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Points to get: " + QuestionScore);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Points lost: " + LostPoints);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("question "+i+": "+ QuestionName);
                    int j = 0;
                    for (int ans = 0; ans < 3; ans++){
                        QuestionAnswers = ansQ10[u];
                        u++;
                        j++;
                        Console.WriteLine("Type  "+ j + " for : "+QuestionAnswers);
                    }
                } else {
                    QuestionName = "help";
                    QuestionScore = 666;
                }
                i++;
                
                //Await player input and validate if it's an int
                int input;
                bool parsed = false;
                do{
                    Console.WriteLine("Please answer with a number");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    parsed = int.TryParse(Console.ReadLine(), out input);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                while(!parsed);
                 
                int result = QuestionScore;

                if(input == CorrectAns){//RIGHT
                    score += result;
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.DarkGreen;  
                    Console.WriteLine("CORRECT!");
                    Console.WriteLine("Score + " +result);
                    Console.Beep(1200, 200);
                    Thread.Sleep(1000);
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.Black;    
                }else{//WRONG
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.Red;                    
                    Console.WriteLine("!! WRONG !!");
                    LostPoints = LostPoints + QuestionScore;
                    Console.Beep(900, 1000);
                    Thread.Sleep(1000);
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.Black;                       
                }                
            }
            //After questions are answered player enters name for highscore
            Console.Clear();
            Console.WriteLine("Game Over your score is : "+ score + " points");       
            Console.WriteLine("Please enter your name:");
            string playerName = Console.ReadLine();
            HighScore.WriteHighScore(playerName,score,"highScore.txt"); 
            Console.Clear();


            //print highscore after highscore is saved
            string[] highScore = ListSorter.GetSortedHighScore("highScore.txt");
            
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("+++++++++++++ Highscore +++++++++++++");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            int count = highScore.Length;
            if(count>10){count =10;};
            for(int k=0;k<count;k++){
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(highScore[k]);
                Console.ForegroundColor = ConsoleColor.White;
            }   
        }
        
    }
}
