using DempAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DempAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskItemsController : ControllerBase
    {
        // This is my list of TaskItems
        private static List<TaskItem> TaskItems = new List<TaskItem>()
        {
            new TaskItem{Id = 1, Title = "Website Redesign", Description = "Revamp company website"},
            new TaskItem{Id = 2, Title = "Marketing Campaign", Description = "Analyze marketing efforts"},
            new TaskItem{Id = 3, Title = "Product Feature Development", Description = "Brainstorm new features"}
        };

        // This is 

    }
}
