namespace Automaton.Core.Tests;

using System.Text.Json;

public class TaskTests
{
    [Fact]
    public void Serialize()
    {
        Task t1 = new("Test");
        string json = JsonSerializer.Serialize(t1);
        Task? t2 = JsonSerializer.Deserialize<Task>(json);
        Assert.NotNull(t2);
        Assert.Equal(t1, t2);
    }
}
