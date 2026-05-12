
using System;

namespace Eliza
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continueConversation = true;
            Console.WriteLine("Hello, I am Eliza a psychology program, what would you like to talk about? ");

            while (continueConversation)
            {
                {
                    string input = Console.ReadLine();
                    input = input.ToLower();

                    if (input == "end convo") { continueConversation = false; }

                    string respond = CreateElizaResponse(input);
                    Console.WriteLine(" Eliza: " + respond);

                }
            }
        }
        static string CreateElizaResponse(string input)
        {
            string[] inputArray = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string noun = "";
            Random gen = new Random();

            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i] == "my")
                {
                    noun = inputArray[i + 1];
                    return $"Tell me more about your {noun}";
                }

                if (inputArray[i] == "love" || inputArray[i] == "hate")
                {

                    return $"You have strong feelings about that";

                }
            }
                int nullRespond = gen.Next(1, 4);
                string respond = "";
                if (nullRespond == 1)
                {
                    respond = "Please go on.";
                }

                if (nullRespond == 2)
                { 
                    respond = "Tell me more.";
                }

                if (nullRespond == 3)
                { 
                    respond = "Continue";
                }

               return respond;

        }
    }
}
