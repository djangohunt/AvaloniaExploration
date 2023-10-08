using System.Collections.Generic;
using TodoListDemo.DataModel;

namespace TodoListDemo.Services;

public class ToDoListService
{
    public List<ToDoItem> GetItems()
    {
        List<ToDoItem> items = new List<ToDoItem>();

        ToDoItem item1 = new ToDoItem();
        item1.Description = "Walk Tarlo";

        ToDoItem item2 = new ToDoItem();
        item2.Description = "Wash wetsuit";

        ToDoItem item3 = new ToDoItem();
        item3.Description = "Learn Avalonia";

        items.Add(item1);
        items.Add(item2);
        items.Add(item3);

        return items;
    }
}
