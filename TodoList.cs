using System;
using System.Collections.Generic;

namespace Todos
{

    public class TodoList {
        // NOTE: You'll need to create a container inside this class to store the todos
        //  This container should only be accessible from within the class.
        private List<Todo> TopPriority {get; set;} = new List<Todo>();
        private List<Todo> LeastPriority {get; set;} = new List<Todo>();


        // NOTE: There are additional methods used in Program.cs that need
        // to be added to this class


        // Add a new todo to the front of the todo list
        public void AddTopPriorityTodo(Todo todo) {
            TopPriority.Add(todo);
            Console.WriteLine($"TOP PRIORITY: {todo.Text}");
        }

        // Add a new todo to the end of the todo list
        public void AddLeastPriorityTodo(Todo todo) {
            LeastPriority.Add(todo);
            Console.WriteLine($"LOW PRIORITY: {todo.Text}");
            // add the appropriate code to complete this method
        }

        // For the GetTopPriorityTodo() method
        //  If the includeCompleted parameter is false AND
        //  ALL of the Todos are complete, you should return null;
        public Todo GetTopPriorityTodo(bool includeCompleted) {
            // add the appropriate code to complete this method
            return null;
        }

        public void PrintAll()
        {
            // Console.WriteLine($"{String.Join(", ", )} {}")
        }


    }
}