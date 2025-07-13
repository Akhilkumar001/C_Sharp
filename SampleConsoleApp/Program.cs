using SampleConsoleApp.Data;
using SampleConsoleApp.Models;

using var context = new AppDbContext();

context.Database.EnsureCreated();

if (!context.Devs.Any())
{
    context.Devs.Add(new Dev
    {
        UserId = Guid.NewGuid().ToString(),
        Name = "Akhilkumar Acha",
        Email = "sample@example.com"
    });
    context.SaveChanges();
}

foreach (var dev in context.Devs)
{
    Console.WriteLine($"UserID: {dev.UserId}, Name: {dev.Name}, Email: {dev.Email}");
}
