using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Work5
{
    public class TaskManager
    {
        List<MyTask> tasks;

        public TaskManager()
        {
            tasks = new List<MyTask>
            {
                new MyTask{Id=1, Title= "Go shopping",  Completed=false},
                new MyTask{Id=2, Title= "Complete works",  Completed=false},
                new MyTask{Id=3, Title= "Exercise",  Completed=false},

            };
           
        }

        public void AddTask(MyTask task)
        {
            tasks.Add(task);
            Console.WriteLine("Task eklendi : " +task.Title);
        }

        public List<MyTask> GetAllTask()
        {
            Console.WriteLine("------------Tasks-----------");
            foreach (var task in tasks)
            {
                Console.WriteLine($"ID: {task.Id} - Title: {task.Title} - Completed: {task.Completed}");
            }
            return tasks;
        }

        public void CompleteTask(int id)
        {
            foreach (var task in tasks)
            {
                if (task.Id == id)
                {
                    task.Completed = true;
                    Console.WriteLine($"Task {id} tamamlandı");
                    return;
                }
            }
            Console.WriteLine("Belirtilen id'ye sahip task bulunamadı");
        }

        public void Deletetask(int id)
        {
            tasks.RemoveAll(task => task.Id == id);
            Console.WriteLine($"Task {id} silindi");
        }

    }


}
