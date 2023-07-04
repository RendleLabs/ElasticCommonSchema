using System.Text;

namespace Generator;

public static class MarkdownGenerator
{
    public static string Generate(Container container)
    {
        var builder = new StringBuilder();
        Write(container, builder, "#");
        return builder.ToString();
    }

    private static void Write(Container container, StringBuilder builder, string headerChars)
    {
        builder.AppendLine($"{headerChars} {container.QualifiedCSharpName}");
        builder.AppendLine();
        if (container.Fields.Count > 0)
        {
            builder.AppendLine($"**Fields**");
            builder.AppendLine();
            builder.AppendLine("| Field | ECS Name | Description | Example |");
            builder.AppendLine("| ----- | ----- | ----------- | ------- |");
            foreach (var field in container.Fields.OrderBy(f => f.CSharpName))
            {
                builder.AppendLine($"| {field.CSharpName} | {field.NormalizedName} | {field.Description} | {field.Example} |");
            }

            builder.AppendLine();
        }

        if (container.Containers.Count > 0)
        {
            foreach (var childContainer in container.Containers.Values.OrderBy(c => c.CSharpName))
            {
                Write(childContainer, builder, headerChars + "#");
            }
        }
    }
}