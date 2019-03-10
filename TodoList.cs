using System;
using System.Collections.Generic;

namespace Todos
{

    public class TodoList {
        // NOTE: You'll need to create a container inside this class to store the todos
        //  This container should only be accessible from within the class.
        private List<Todo> PriorityList {get; set;} = new List<Todo>();


        // NOTE: There are additional methods used in Program.cs that need
        // to be added to this class
        public Todo GetElementAt(int num) {
            return PriorityList[num];
        }

        public void PrintIncomplete() {
            foreach(Todo item in PriorityList) {
                if (item.IsComplete == false) {
                    Console.WriteLine(item);
                }
            }
        }

        public Todo GetRandomTodo() {
            // Console.WriteLine($"this is {}");
            Random rand = new Random();
            int randomNum = rand.Next(PriorityList.Count);
            return PriorityList[randomNum];
        }


        // Add a new todo to the front of the todo list
        public void AddTopPriorityTodo(Todo todo) {
            PriorityList.Insert(0, todo);
            // Console.WriteLine($"TOP PRIORITY: {todo.Text}");
        }

        // Add a new todo to the end of the todo list
        public void AddLeastPriorityTodo(Todo todo) {
            PriorityList.Add(todo);
            // Console.WriteLine($"LOW PRIORITY: {todo.Text}");
            // add the appropriate code to complete this method
        }

        // For the GetTopPriorityTodo() method
        //  If the includeCompleted parameter is false AND
        //  ALL of the Todos are complete, you should return null;
        public Todo GetTopPriorityTodo(bool includeCompleted) {
            // add the appropriate code to complete this method
            if (!PriorityList.Find(listItem => listItem.IsComplete == includeCompleted).IsComplete) {
            return PriorityList.Find(listItem => listItem.IsComplete == includeCompleted);
            } else {
            return null;
            }
        }

        public void PrintAll()
        {
            foreach(Todo todo in PriorityList){

                Console.WriteLine($"Todo:{todo.Text}. Done? {todo.IsComplete} Due on: {todo.DueDate}");
            }

        }
    }
}