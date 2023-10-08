using System.Collections.Generic;
using System.Collections.ObjectModel;
using TodoListDemo.DataModel;

namespace TodoListDemo.ViewModels;

public class ToDoListViewModel : ViewModelBase
{
    public ToDoListViewModel(IEnumerable<ToDoItem> items)
    {
        ListItems = new ObservableCollection<ToDoItem>(items);
    }

    public ObservableCollection<ToDoItem> ListItems { get; }
}
