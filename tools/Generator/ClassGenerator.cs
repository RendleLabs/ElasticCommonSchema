using System.CodeDom.Compiler;
using System.Text;

namespace Generator;

public struct ClassCode
{
    public ClassCode(string name, string code)
    {
        Name = name;
        Code = code;
    }

    public string Name { get; }
    public string Code { get; }
}

public static class ClassGenerator
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="container"></param>
    /// <returns></returns>
    public static ClassCode Generate(Container container)
    {
        var parents = OrderParents(container);

        var name = string.Join('.', parents) + '.' + container.CSharpName;
        name = name.Trim('.');

        var builder = new StringBuilder();
        var stringWriter = new StringWriter(builder);
        var writer = new IndentedTextWriter(stringWriter, "    ");
        
        writer.WriteLine("namespace ElasticCommonSchema;");
        writer.WriteLine();

        foreach (var parent in parents)
        {
            writer.WriteLine($"public static partial class {parent}");
            writer.WriteLine("{");
            writer.Indent++;
        }
        
        writer.WriteLine($"public static partial class {container.CSharpName}");
        writer.WriteLine("{");
        writer.Indent++;

        foreach (var field in container.Fields)
        {
            writer.WriteLine("/// <summary>");
            writer.WriteLine($"/// {field.Description}");
            writer.WriteLine("/// </summary>");
            if (field.Example is { Length: > 0 })
            {
                writer.WriteLine("/// <example>");
                writer.WriteLine($"/// <c>{field.Example}</c>");
                writer.WriteLine("/// </example>");
            }
            writer.WriteLine($"public const string {field.CSharpName} = \"{field.NormalizedName}\";");
            writer.WriteLine();
        }

        while (writer.Indent > 0)
        {
            writer.Indent--;
            writer.WriteLine("}");
        }
        
        writer.WriteLine();
        
        writer.Flush();
        stringWriter.Flush();
        return new ClassCode(name, builder.ToString());
    }

    private static string[] OrderParents(Container container)
    {
        var parents = new Stack<string>();
        var parent = container.Parent;
        while (parent is not null)
        {
            parents.Push(parent.CSharpName);
            parent = parent.Parent;
        }

        return parents.ToArray();
    }
}