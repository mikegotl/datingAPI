using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TodoApi.Models;

namespace DatingAPI
{
    internal class DataGenerator
    {
        internal static void Initialize(IServiceProvider services)
        {
            using (var context = new TodoContext(
           services.GetRequiredService<DbContextOptions<TodoContext>>()))
            {
                // Look for any.
                if (context.TodoItems.Any())
                {
                    return;   // Data was already seeded
                }

                context.TodoItems.AddRange(

                    new TodoItem
                    {
                        Id = 12345,
                        Name = "Mike G",
                        IsComplete = true
                    });

                context.SaveChanges();
            }
        }
    }
}