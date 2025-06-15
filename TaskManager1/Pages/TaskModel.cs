namespace TaskManager1.Pages
{
	public class TaskModel
	{
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; }
        public string Category { get; set; }  // New property for category or project
        public DateTime CreatedAt { get; set; }
        public DateTime? Deadline { get; set; }
        public int Progress { get; set; }

    }
}
