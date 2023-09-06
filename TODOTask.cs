namespace TaskTracker;

public class TODOTask
{
    private string _name;
    private string _description;
    private DateOnly _dateOfCreation;
    private DateOnly _dueDate;
    private bool _isComplete;

    public string Name { get => _name; set => _name = value; }
    public string Description { get => _description; set => _description = value; }
    public DateOnly DateOfCreation { get => _dateOfCreation; private set => _dateOfCreation = value; }
    public DateOnly DueDate { get => _dueDate; set => _dueDate = value; }
    public bool IsComplete { get => _isComplete; set => _isComplete = value; }

    public TODOTask(string name, string description, DateOnly dateOfCreation, DateOnly dueDate)
    {
        Name = name;
        Description = description;
        DateOfCreation = dateOfCreation;
        DueDate = dueDate;
        IsComplete = false;
    }

    public override string ToString()
    {
        return $"{Name} {DueDate} {IsComplete}";
    }
}
