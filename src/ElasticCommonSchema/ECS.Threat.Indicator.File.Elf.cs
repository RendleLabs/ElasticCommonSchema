namespace ElasticCommonSchema;

public static partial class ECS
{
    public static partial class Threat
    {
        public static partial class Indicator
        {
            public static partial class File
            {
                public static partial class Elf
                {
                    /// <summary>
                    /// Machine architecture of the ELF file.
                    /// </summary>
                    /// <example>
                    /// <c>x86-64</c>
                    /// </example>
                    public const string Architecture = "threat.indicator.file.elf.architecture";
                    
                    /// <summary>
                    /// Byte sequence of ELF file.
                    /// </summary>
                    /// <example>
                    /// <c>Little Endian</c>
                    /// </example>
                    public const string ByteOrder = "threat.indicator.file.elf.byte_order";
                    
                    /// <summary>
                    /// CPU type of the ELF file.
                    /// </summary>
                    /// <example>
                    /// <c>Intel</c>
                    /// </example>
                    public const string CpuType = "threat.indicator.file.elf.cpu_type";
                    
                    /// <summary>
                    /// Build or compile date.
                    /// </summary>
                    public const string CreationDate = "threat.indicator.file.elf.creation_date";
                    
                    /// <summary>
                    /// List of exported element names and types.
                    /// </summary>
                    public const string Exports = "threat.indicator.file.elf.exports";
                    
                    /// <summary>
                    /// A hash of the Go language imports in an ELF file.
                    /// </summary>
                    /// <example>
                    /// <c>10bddcb4cee42080f76c88d9ff964491</c>
                    /// </example>
                    public const string GoImportHash = "threat.indicator.file.elf.go_import_hash";
                    
                    /// <summary>
                    /// List of imported Go language element names and types.
                    /// </summary>
                    public const string GoImports = "threat.indicator.file.elf.go_imports";
                    
                    /// <summary>
                    /// Shannon entropy calculation from the list of Go imports.
                    /// </summary>
                    public const string GoImportsNamesEntropy = "threat.indicator.file.elf.go_imports_names_entropy";
                    
                    /// <summary>
                    /// Variance for Shannon entropy calculation from the list of Go imports.
                    /// </summary>
                    public const string GoImportsNamesVarEntropy = "threat.indicator.file.elf.go_imports_names_var_entropy";
                    
                    /// <summary>
                    /// Whether the file is a stripped or obfuscated Go executable.
                    /// </summary>
                    public const string GoStripped = "threat.indicator.file.elf.go_stripped";
                    
                    /// <summary>
                    /// A hash of the imports in an ELF file.
                    /// </summary>
                    /// <example>
                    /// <c>d41d8cd98f00b204e9800998ecf8427e</c>
                    /// </example>
                    public const string ImportHash = "threat.indicator.file.elf.import_hash";
                    
                    /// <summary>
                    /// List of imported element names and types.
                    /// </summary>
                    public const string Imports = "threat.indicator.file.elf.imports";
                    
                    /// <summary>
                    /// Shannon entropy calculation from the list of imported element names and types.
                    /// </summary>
                    public const string ImportsNamesEntropy = "threat.indicator.file.elf.imports_names_entropy";
                    
                    /// <summary>
                    /// Variance for Shannon entropy calculation from the list of imported element names and types.
                    /// </summary>
                    public const string ImportsNamesVarEntropy = "threat.indicator.file.elf.imports_names_var_entropy";
                    
                    /// <summary>
                    /// Section information of the ELF file.
                    /// </summary>
                    public const string Sections = "threat.indicator.file.elf.sections";
                    
                    /// <summary>
                    /// ELF object segment list.
                    /// </summary>
                    public const string Segments = "threat.indicator.file.elf.segments";
                    
                    /// <summary>
                    /// List of shared libraries used by this ELF object.
                    /// </summary>
                    public const string SharedLibraries = "threat.indicator.file.elf.shared_libraries";
                    
                    /// <summary>
                    /// telfhash hash for ELF file.
                    /// </summary>
                    public const string Telfhash = "threat.indicator.file.elf.telfhash";
                    
                    /// <summary>
                    /// Chi-square probability distribution of the section.
                    /// </summary>
                    public const string SectionsChi2 = "threat.indicator.file.elf.sections.chi2";
                    
                    /// <summary>
                    /// Shannon entropy calculation from the section.
                    /// </summary>
                    public const string SectionsEntropy = "threat.indicator.file.elf.sections.entropy";
                    
                    /// <summary>
                    /// ELF Section List flags.
                    /// </summary>
                    public const string SectionsFlags = "threat.indicator.file.elf.sections.flags";
                    
                    /// <summary>
                    /// ELF Section List name.
                    /// </summary>
                    public const string SectionsName = "threat.indicator.file.elf.sections.name";
                    
                    /// <summary>
                    /// ELF Section List offset.
                    /// </summary>
                    public const string SectionsPhysicalOffset = "threat.indicator.file.elf.sections.physical_offset";
                    
                    /// <summary>
                    /// ELF Section List physical size.
                    /// </summary>
                    public const string SectionsPhysicalSize = "threat.indicator.file.elf.sections.physical_size";
                    
                    /// <summary>
                    /// ELF Section List type.
                    /// </summary>
                    public const string SectionsType = "threat.indicator.file.elf.sections.type";
                    
                    /// <summary>
                    /// Variance for Shannon entropy calculation from the section.
                    /// </summary>
                    public const string SectionsVarEntropy = "threat.indicator.file.elf.sections.var_entropy";
                    
                    /// <summary>
                    /// ELF Section List virtual address.
                    /// </summary>
                    public const string SectionsVirtualAddress = "threat.indicator.file.elf.sections.virtual_address";
                    
                    /// <summary>
                    /// ELF Section List virtual size.
                    /// </summary>
                    public const string SectionsVirtualSize = "threat.indicator.file.elf.sections.virtual_size";
                    
                    /// <summary>
                    /// ELF object segment sections.
                    /// </summary>
                    public const string SegmentsSections = "threat.indicator.file.elf.segments.sections";
                    
                    /// <summary>
                    /// ELF object segment type.
                    /// </summary>
                    public const string SegmentsType = "threat.indicator.file.elf.segments.type";
                    
                }
            }
        }
    }
}

