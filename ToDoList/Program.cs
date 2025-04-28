//Welcome to Mr Khan's ToDoList App
var shallContinue = true;
var todoList = new List<string>();

while (shallContinue)
{
    Console.WriteLine("Hello");
    Console.WriteLine("[S]ee all ToDos");
    Console.WriteLine("[A]dd a ToDo");
    Console.WriteLine("[R]emove a ToDo");
    Console.WriteLine("[E]xit");
    Console.Write("Enter your choice: ");
    var userChoice = Console.ReadLine();

    //choice implementation using if-else statement
    if (userChoice == "S" || userChoice == "s")
    {
        SeeAllToDos(todoList);
    }
    else if (userChoice == "A" || userChoice == "a")
    {
        AddToDo(todoList);
    }
    else if (userChoice == "R" || userChoice == "r")
    {
        RemoveToDo(todoList);
    }
    else if (userChoice == "E" || userChoice == "e")
    {
        Console.WriteLine("Exiting the calculator app.............");
        shallContinue = false;
    }
    else
    {
        Console.WriteLine("Invalid input! \n");
    }

    //choice implementation using switch case statements
    //var userChoice = Console.ReadLine().toLower() - to avoid having case 'S' AND case 's'

    //switch (userChoice)
    //{
    //    case "s":
    //        SeeAllToDos(todoList);
    //        break;

    //    case "a":
    //        AddToDo(todoList);
    //        break;

    //    case "r":
    //        RemoveToDo(todoList);
    //        break;

    //    case "e":
    //        Console.WriteLine("Exiting the calculator app...");
    //        shallContinue = false;
    //        break;

    //    default:
    //        Console.WriteLine("Invalid input!");
    //        break;
    //}
}

static void SeeAllToDos(List<string> todoList)
{
    if (todoList.Count == 0)
    {
        Console.WriteLine("No ToDos have been added yet! \n");
        return;
    }

    for (int i = 0; i < todoList.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {todoList[i]}");
    }
    Console.WriteLine();
    //testing performance
    //var index = 0;
    //foreach (var todo in todoList)
    //{
    //    index++;
    //    Console.WriteLine($"{index}. {todo}");
    //}
}

static void AddToDo(List<string> todoList)
{
    while (true)
    {
        Console.Write("Enter ToDo description: ");
        var todoDescription = Console.ReadLine();

        if (string.IsNullOrEmpty(todoDescription))
        {
            Console.WriteLine("Description cannot be empty. \n");
            continue;
        }
        else if (todoList.Contains(todoDescription))
        {
            Console.WriteLine("Description must be unique. \n");
            continue;
        }
        else
        {
            todoList.Add(todoDescription);
            Console.WriteLine($"ToDo added successfully: '{todoDescription}' \n");
            break;
        }
    }
}

static void RemoveToDo(List<string> todoList)
{
    if (todoList.Count == 0)
    {
        Console.WriteLine("No ToDos have been added yet! \n");
        return;
    }

    while (true)
    {
        Console.WriteLine("Select the index of the ToDo you want to remove: ");
        for (int i = 0; i < todoList.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {todoList[i]}");
        }
        var toDoToRemove = Console.ReadLine();
        if ((string.IsNullOrEmpty(toDoToRemove)))
        {
            Console.WriteLine("Index cannot be empty. \n");
            continue;
        }
        bool isValidIndex = int.TryParse(toDoToRemove, out int index);
        if (isValidIndex && index > 0 && index <= todoList.Count)
        {
            string removedToDo = todoList[index - 1];
            todoList.RemoveAt(index - 1);
            Console.WriteLine($"ToDo removed successfully: '{removedToDo}' \n");
            break;
        }
        else
        {
            Console.WriteLine("Invalid index. \n");
        }
    }
}
