using ToDoList.Models;

TaskService service = new TaskService();

while (true)
{
    Console.WriteLine("\nTask Manager");
    Console.WriteLine("1 - Add Task");
    Console.WriteLine("2 - View Tasks");
    Console.WriteLine("3 - Mark Task as Completed");
    Console.WriteLine("4 - Delete Task");
    Console.WriteLine("0 - Exit");
    Console.Write("Choose an option: ");
    string input = Console.ReadLine();

    switch (input)
    {
        case "1":
            Console.Write("Enter task title: ");
            string title = Console.ReadLine();
            service.AddTask(title);
            break;

        case "2":
            service.ListTasks();
            break;

        case "3":
            Console.Write("Enter task ID to mark as completed: ");
            int idToComplete = int.Parse(Console.ReadLine());
            service.CompleteTask(idToComplete);
            break;

        case "4":
            Console.Write("Enter task ID to delete: ");
            int idToDelete = int.Parse(Console.ReadLine());
            service.DeleteTask(idToDelete);
            break;

        case "0":
            return;

        default:
            Console.WriteLine("Invalid option. Please try again.");
            break;
    }
}
