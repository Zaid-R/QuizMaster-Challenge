using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QuizMaster
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            try
            {
                await StartQuiz();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.ToString()}");
            }
            finally
            {
                Console.WriteLine("End of the program");
            }
        }

        static async Task StartQuiz()
        {
            List<string> questions = new List<string>
            {
                "What is the capital of France?",
                "Who wrote 'To Kill a Mockingbird'?",
                "What is the smallest prime number?",
                "What is the chemical symbol for gold?",
                "In what year did the Titanic sink?",
                "Who painted the Mona Lisa?",
                "What is the largest planet in our solar system?"
            };

            List<string> answers = new List<string>
            {
                "Paris",
                "Harper Lee",
                "2",
                "Au",
                "1912",
                "Leonardo da Vinci",
                "Jupiter"
            };

            int score = 0;
            try
            {
                for (int i = 0; i < questions.Count; i++)
                {
                    int interval = 5000;
                    Console.WriteLine($"You have {interval / 1000} seconds to answer");
                    Console.WriteLine(questions[i]);

                    var answerTask = GetAnswerAsync();
                    var timeoutTask = Task.Delay(interval);

                    var completedTask = await Task.WhenAny(answerTask, timeoutTask);

                    if (completedTask == answerTask)
                    {
                        string answer = await answerTask;
                        if (answer.ToLower() == answers[i].ToLower())
                        {
                            Console.WriteLine("That's correct!");
                            score++;
                        }
                        else
                        {
                            Console.WriteLine("Wrong answer!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("You're out of time, next question:");
                    }

                    Console.WriteLine("--------------");
                }
                Console.WriteLine($"Your score is {score}/{questions.Count}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.ToString()}");
            }
            finally
            {
                questions.Clear();
                answers.Clear();
            }
        }

        static async Task<string> GetAnswerAsync()
        {
            string answer = string.Empty;
            while (string.IsNullOrWhiteSpace(answer))
            {
                answer = await Task.Run(() => Console.ReadLine().Trim());
                if (string.IsNullOrWhiteSpace(answer))
                {
                    Console.WriteLine("You can't leave your answer empty, try again:");
                }
            }
            return answer;
        }
    }
}