using System;

namespace Todos
{
    public class Todo
    {
        public string Text {get; set;} = "";
        public bool IsComplete  {get; set;} = true;
        public DateTime DueDate {get; set;}

        private string Secret {get; set;} = "Tell no one!";

        public void PrintTodo() {
            Console.WriteLine($"Todo: {Text} IsComplete: {IsComplete} Due: {DueDate}");
        }

        public string AsStringRepresentation() {
            Console.WriteLine("Inside AsStringRepresentation()");
            return $"Todo: {Text} done? {IsComplete} due on: {DueDate} Shh...{Secret}";
        }

        public override string ToString() {
            Console.WriteLine("Inside ToString()");
            string result = AsStringRepresentation();
            return result;

            // In the real world, I would not go to the trouble of having an AsStringRepresentation()
            //  method. I would just have the following code in the ToString() method:

            // return $"Todo: {Text} done? {IsComplete} due on: {DueDate} Shh...{Secret}";
        }

        public void SetSecret(string newSecret) {
            Secret = newSecret;
        }
    }
}