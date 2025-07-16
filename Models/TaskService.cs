using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Models
{
    [NotMapped]
    public class TaskService
    {
        private readonly AppDbContext _context = new AppDbContext();

        public void AddTask(string title)
        {
            var task = new TaskApp
            {
                TitlOfTask = title,
                IsCompleted = false
            };

            _context.Tasks.Add(task);
            _context.SaveChanges();
            Console.WriteLine("Task added successfully.");
        }

        public void ListTasks()
        {
            var tasks = _context.Tasks.ToList();
            Console.WriteLine("\nList of Tasks:");
            foreach (var task in tasks)
            {
                string status = task.IsCompleted ? "Completed" : "Not Completed";
                Console.WriteLine($"ID: {task.Id} | Title: {task.TitlOfTask} | Status: {status}");
            }
        }

        public void CompleteTask(int id)
        {
            var task = _context.Tasks.Find(id);
            if (task != null)
            {
                task.IsCompleted = true;
                _context.SaveChanges();
                Console.WriteLine("Task marked as completed.");
            }
            else
            {
                Console.WriteLine("Task not found.");
            }
        }

        public void DeleteTask(int id)
        {
            var task = _context.Tasks.Find(id);
            if (task != null)
            {
                _context.Tasks.Remove(task);
                _context.SaveChanges();
                Console.WriteLine("Task deleted.");
            }
            else
            {
                Console.WriteLine("Task not found.");
            }
        }
    }
}

