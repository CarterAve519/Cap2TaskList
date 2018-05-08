using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapTaskList
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate a new Task object
            Task newTask = new Task("Keith", "Garbage Duty");
            Task secondTask = new Task("Jacob", "Dishes");


            //Print the different Objects
            Console.WriteLine(newTask.TaskOwner + " "
                + newTask.TaskName + " " + newTask.DueDate);
            Console.WriteLine(secondTask.TaskOwner + " "
                + secondTask.TaskName + " " + newTask.DueDate);

            //create list
            List<Task> TaskList = new List<Task>();

            //We want to build a new list of tasks, so
            //  we're going to create a loop

            bool whileBool = false;

            while (whileBool)
            {

            }



        }
    }
}
}
