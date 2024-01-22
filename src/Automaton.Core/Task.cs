namespace Automaton.Core;

public record Task
{
    public Task(string name)
    {
        Name = name;
        Id = Guid.NewGuid();
    }

    public string Name { get; init; }

    public Guid Id { get; init; }
};
