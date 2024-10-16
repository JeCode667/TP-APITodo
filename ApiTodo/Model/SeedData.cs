public class SeedData
{
    public static void Init()
    {
        TodoContext context = new();

        Todo todo1 = new("Laver le linge", true, DateTime.Parse("2025-09-01"));
        Todo todo2 = new("Faire les courses", false, DateTime.Now);
        Todo todo3 = new("Apprendre le latin", true);

        context.Todos.AddRange(
            todo1,
            todo2,
            todo3
        );

        context.SaveChanges();
    }
}
