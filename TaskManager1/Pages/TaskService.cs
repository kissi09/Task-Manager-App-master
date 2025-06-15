
using System;
using System.Collections.Generic;
using TaskManager1.Pages;


//This class handles operations related to managing tasks
public class TaskService
{
    private List<TaskModel> tasks = new List<TaskModel>(); //we declare a private field tasks to store a list of Taks or TaskModel objects. 

    private List<string> defaultCategories = new List<string> { "Work", "Personal", "Shopping", "Health" };

    public TaskService()
    {
        // Initialize tasks with default categories
        foreach (var category in defaultCategories)
        {
            AddTask(new TaskModel { Title = $"{category} Task 1", Category = category });
            AddTask(new TaskModel { Title = $"{category} Task 2", Category = category });
            // Add more default tasks as needed
        }
    }

    public List<TaskModel> GetTasks() // This method is a public method that returns the list of tasks.
    {
        return tasks;
    }

    public void AddTask(TaskModel task) // The AddTask method adds a new task to the list.
    {
        task.Id = tasks.Count + 1;
        task.CreatedAt = DateTime.Now;

        tasks.Add(task);
    }

    public void UpdateTask(TaskModel task)  // The UpdateTask method updates an existing task in the list.
    {
        var existingTask = tasks.Find(t => t.Id == task.Id); //it checks whether a task exists
        if (existingTask != null) // if it does
        {
            existingTask.Title = task.Title; // It updates the title by
            existingTask.Description = task.Description;
            existingTask.IsCompleted = task.IsCompleted;
            existingTask.Category = task.Category;
            existingTask.Deadline = task.Deadline;
        }
    }

    public void DeleteTask(int taskId)
    {
        tasks.RemoveAll(t => t.Id == taskId);
    }

}
