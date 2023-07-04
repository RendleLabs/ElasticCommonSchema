// See https://aka.ms/new-console-template for more information

using System.Diagnostics;
using System.Reflection;
using System.Text;
using Csv;
using Generator;

if (args.Length != 2 || args[0] != "-o")
{
    Console.Error.WriteLine("Usage: dotnet run -- -o {outputDirectory}");
    return 1;
}

var directory = Path.GetFullPath(args[1]);
Directory.CreateDirectory(directory);

var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("Generator.ecs.csv");
Debug.Assert(stream is not null);

var fields = new List<Field>();

foreach (var line in CsvReader.ReadFromStream(stream))
{
    fields.Add(new Field
    {
        EcsVersion = line["ECS_Version"],
        Indexed = line["Indexed"] == "true",
        FieldSet = line["Field_Set"],
        Name = line["Field"],
        Type = line["Type"],
        Level = line["Level"],
        Normalization = line["Normalization"],
        Example = line["Example"],
        Description = line["Description"]
    });
}

var container = Container.Build(fields);

var code = ClassGenerator.Generate(container);
var path = Path.Combine(directory, $"{code.Name}.cs");
File.WriteAllText(path, code.Code, Encoding.UTF8);
Console.WriteLine(path);

foreach (var c in container.All())
{
    code = ClassGenerator.Generate(c);
    path = Path.Combine(directory, $"{code.Name}.cs");
    File.WriteAllText(path, code.Code, Encoding.UTF8);
    Console.WriteLine(path);
}

var markdown = MarkdownGenerator.Generate(container);
path = Path.Combine(directory, "README.md");
File.WriteAllText(path, markdown);

return 0;
