using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapTaskList
{
    class Task
    {
            //Classes allow us to make Objects
            public string TaskOwner { get; set; }

            public string TaskName { get; set; }

            public DateTime DueDate { get; set; }


            //Begin creating Constructors
            //Constructor names should be in Camel Case
            //We don't leave constructors at the default() because
            public Task(string taskOwner, string taskName)
            {
                //assign the Taskname to the Constructor string
                TaskOwner = taskOwner;
                TaskName = taskName;
                DueDate = DateTime.Now.AddDays(14);
            }



        
    }




}

