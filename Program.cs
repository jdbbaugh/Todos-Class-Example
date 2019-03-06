using System;

namespace Todos
{
    class Program
    {
        static void Main()
        {
            Todo dishes = new Todo();
            dishes.Text = "Wash the dishes";
            dishes.IsComplete = false;
            dishes.DueDate = new DateTime(2019, 3, 6);

            //dishes.PrintTodo();
            //Console.WriteLine($"Todo: {dishes.Text} IsComplete: {dishes.IsComplete}");
            Console.WriteLine(dishes);
            dishes.SetSecret("This is a secret");
            Console.WriteLine(dishes);

            Object obj = new Object();
            obj.ToString();


            Todo laundry = new Todo();
            //laundry.Text = "Wash the clothes";
            //laundry.PrintTodo();
            //Console.WriteLine($"Todo: {laundry.Text} IsComplete: {laundry.IsComplete}");

            Todo lawn = new Todo();
            //lawn.PrintTodo();
            //Console.WriteLine($"Todo: {lawn.Text} IsComplete: {lawn.IsComplete}");

/* 
            if (lawn.Text == null) {
                Console.WriteLine("It's null!!!!");
            }*/
        }
    }
}

