using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Models
{
    public class TaskApp
    {
        public int Id { get; set; }
        public string TitlOfTask { get; set; }

        public bool IsCompleted { get; set; }
    }
}
