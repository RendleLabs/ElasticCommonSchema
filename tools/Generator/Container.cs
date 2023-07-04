namespace Generator;

public class Container
{
    public Container(string name, Container? parent)
    {
        Name = name;
        Parent = parent;
    }

    public Container? Parent { get; }
    public string Name { get; }
    public string CSharpName => Name.ToPascalCase();
    public string QualifiedCSharpName => Parent is not null ? $"{Parent.QualifiedCSharpName}.{CSharpName}" : CSharpName;

    public Dictionary<string, Container> Containers { get; } = new();

    public List<Field> Fields { get; } = new();

    public Container GetOrAddContainer(string name)
    {
        if (Containers.TryGetValue(name, out var container)) return container;
        Containers[name] = container = new Container(name, this);
        return container;
    }

    public void Clean()
    {
        foreach (var field in Fields.ToArray())
        {
            if (Containers.TryGetValue(field.SimpleName, out var container))
            {
                foreach (var f in container.Fields)
                {
                    f.Name = $"{field.Name}|{f.SimpleName}";
                    Fields.Add(f);
                }
            }
            Containers.Remove(field.SimpleName);
        }

        foreach (var container in Containers.Values)
        {
            container.Clean();
        }
    }

    public IEnumerable<Container> All()
    {
        foreach (var container in Containers.Values)
        {
            yield return container;
            foreach (var subContainer in container.All())
            {
                yield return subContainer;
            }
        }
    }

    public static Container Build(IEnumerable<Field> fields)
    {
        var container = new Container("ECS", null);

        foreach (var field in fields)
        {
            if (field.FieldSet == "base")
            {
                container.Fields.Add(field);
                continue;
            }

            AddField(field, container);
        }
        
        container.Clean();

        return container;
    }

    private static void AddField(Field field, Container container)
    {
        var parts = field.Name.Split('.');
        
        for (int i = 0; i < parts.Length - 1; i++)
        {
            container = container.GetOrAddContainer(parts[i]);
        }

        container.Fields.Add(field);
    }
}