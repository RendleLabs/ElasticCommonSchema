namespace Generator;

public class Field
{
    public string EcsVersion { get; init; } = null!;
    public bool Indexed { get; init; }
    public string FieldSet { get; init; } = null!;
    public string Name { get; set; } = null!;
    public string Type { get; init; } = null!;
    public string Level { get; init; } = null!;
    public string Normalization { get; init; } = null!;
    public string Example { get; init; } = null!;
    public string Description { get; init; } = null!;

    public string CSharpName => Name.Split('.').Last().Replace('|', '_').ToPascalCase();
    public string SimpleName => Name.Split('.').Last();
    public string ContainerName => Name.Split('.')[^2];
    public string NormalizedName => Name.Replace('|', '.');
}