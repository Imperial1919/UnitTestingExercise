using System;


namespace UnitTestingExercise
{
    public class UnitTestMethods
    {
        // Make sure your references are set properly
            // Righ-click on Dependencies in your .Tests project and set your reference

        public int Addition(int num1, int num2, int num3)
        {
           
            int answer = num1 + num2 + num3;
            return answer;

        }

        

        // Create a Subtract method that passes 2 integers
            // Keep track of which number is getting passed as minuend and subtrahend

        public int Subtract(int num1,int num2)
        {
            int answer = num1 - num2;
            return answer;

        }

        // Create a Multiply method that passes 2 integers

        public int Multiply(int num1,int num2)
        {
            int answer = num1 * num2;
            return answer;
        }

        // Create a Divide method that passes 2 integers
        public int Divide(int num1, int num2)
        {
            int answer = num1 / num2;
            return answer;

        }

        public string Hello()
        {
            string answer;
            string name;

            name = "Bryce";
            answer = name;
            return answer;
        }



        public string Goodbye()
        {
            string Farewell;
            string Output;

            Farewell = "Goodbye";
            Output = Farewell + "Friend.";
            return Output;

        }

        // Create 2 methods that will utilize the [Fact] tests you wrote

        
    }
}
