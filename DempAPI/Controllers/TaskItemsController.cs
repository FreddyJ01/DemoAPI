using DemoAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DempAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskItemsController : ControllerBase
    {
        // This is my list of TaskItems - This is our temporary static "Database" just for this example.
        private static List<TaskItem> TaskItems = new List<TaskItem>()
        {
            new TaskItem{Id = 1, Title = "Website Redesign", Description = "Revamp company website"},
            new TaskItem{Id = 2, Title = "Marketing Campaign", Description = "Analyze marketing efforts"},
            new TaskItem{Id = 3, Title = "Product Feature Development", Description = "Brainstorm new features"}
        };

        // This attribute specifies that this method handles HTTP Get Requests
        [HttpGet]
        public IEnumerable<TaskItem> Get()
        {
            return TaskItems;
        }

        // Endpoint -> api/taskitems
        [HttpPost]
        // The [FromBody] attribute allows this method to accept the parameters from the JSON body of the request
        public void Post([FromBody] TaskItem taskItem)
        {
            TaskItems.Add(taskItem);
        }

        // Endpoint -> api/taskitems/id
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] TaskItem taskItem)
        {
            var existingTaskItem = TaskItems.FirstOrDefault(t=>t.Id==id);

            if (existingTaskItem != null)
            {
                existingTaskItem.Title = taskItem.Title;
                existingTaskItem.Description = taskItem.Description;
            }
        }

        [HttpDelete("{id}")]
        public void Delete (int id)
        {
            var existingTaskItem = TaskItems.FirstOrDefault(t => t.Id == id);

            if (existingTaskItem != null)
            {
                TaskItems.Remove(existingTaskItem);
            }
        }
    }
}
