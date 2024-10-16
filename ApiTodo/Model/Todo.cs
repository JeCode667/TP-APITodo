public class Todo{

    public int Id {get; set;}
    public string Task {get; set;}
    public bool Completed {get; set;}
    public  DateTime? Deadline {get; set;}

    public Todo(string task, bool completed, DateTime? deadline = null){
        Task = task;
        Completed = completed;
        Deadline = deadline;
    }
    
}