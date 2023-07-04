namespace ElasticCommonSchema;

public static partial class ECS
{
    public static partial class Process
    {
        public static partial class Elf
        {
            /// <summary>
            /// Machine architecture of the ELF file.
            /// </summary>
            /// <example>
            /// <c>x86-64</c>
            /// </example>
            public const string Architecture = "process.elf.architecture";
            
            /// <summary>
            /// Byte sequence of ELF file.
            /// </summary>
            /// <example>
            /// <c>Little Endian</c>
            /// </example>
            public const string ByteOrder = "process.elf.byte_order";
            
            /// <summary>
            /// CPU type of the ELF file.
            /// </summary>
            /// <example>
            /// <c>Intel</c>
            /// </example>
            public const string CpuType = "process.elf.cpu_type";
            
            /// <summary>
            /// Build or compile date.
            /// </summary>
            public const string CreationDate = "process.elf.creation_date";
            
            /// <summary>
            /// List of exported element names and types.
            /// </summary>
            public const string Exports = "process.elf.exports";
            
            /// <summary>
            /// A hash of the Go language imports in an ELF file.
            /// </summary>
            /// <example>
            /// <c>10bddcb4cee42080f76c88d9ff964491</c>
            /// </example>
            public const string GoImportHash = "process.elf.go_import_hash";
            
            /// <summary>
            /// List of imported Go language element names and types.
            /// </summary>
            public const string GoImports = "process.elf.go_imports";
            
            /// <summary>
            /// Shannon entropy calculation from the list of Go imports.
            /// </summary>
            public const string GoImportsNamesEntropy = "process.elf.go_imports_names_entropy";
            
            /// <summary>
            /// Variance for Shannon entropy calculation from the list of Go imports.
            /// </summary>
            public const string GoImportsNamesVarEntropy = "process.elf.go_imports_names_var_entropy";
            
            /// <summary>
            /// Whether the file is a stripped or obfuscated Go executable.
            /// </summary>
            public const string GoStripped = "process.elf.go_stripped";
            
            /// <summary>
            /// A hash of the imports in an ELF file.
            /// </summary>
            /// <example>
            /// <c>d41d8cd98f00b204e9800998ecf8427e</c>
            /// </example>
            public const string ImportHash = "process.elf.import_hash";
            
            /// <summary>
            /// List of imported element names and types.
            /// </summary>
            public const string Imports = "process.elf.imports";
            
            /// <summary>
            /// Shannon entropy calculation from the list of imported element names and types.
            /// </summary>
            public const string ImportsNamesEntropy = "process.elf.imports_names_entropy";
            
            /// <summary>
            /// Variance for Shannon entropy calculation from the list of imported element names and types.
            /// </summary>
            public const string ImportsNamesVarEntropy = "process.elf.imports_names_var_entropy";
            
            /// <summary>
            /// Section information of the ELF file.
            /// </summary>
            public const string Sections = "process.elf.sections";
            
            /// <summary>
            /// ELF object segment list.
            /// </summary>
            public const string Segments = "process.elf.segments";
            
            /// <summary>
            /// List of shared libraries used by this ELF object.
            /// </summary>
            public const string SharedLibraries = "process.elf.shared_libraries";
            
            /// <summary>
            /// telfhash hash for ELF file.
            /// </summary>
            public const string Telfhash = "process.elf.telfhash";
            
            /// <summary>
            /// Chi-square probability distribution of the section.
            /// </summary>
            public const string SectionsChi2 = "process.elf.sections.chi2";
            
            /// <summary>
            /// Shannon entropy calculation from the section.
            /// </summary>
            public const string SectionsEntropy = "process.elf.sections.entropy";
            
            /// <summary>
            /// ELF Section List flags.
            /// </summary>
            public const string SectionsFlags = "process.elf.sections.flags";
            
            /// <summary>
            /// ELF Section List name.
            /// </summary>
            public const string SectionsName = "process.elf.sections.name";
            
            /// <summary>
            /// ELF Section List offset.
            /// </summary>
            public const string SectionsPhysicalOffset = "process.elf.sections.physical_offset";
            
            /// <summary>
            /// ELF Section List physical size.
            /// </summary>
            public const string SectionsPhysicalSize = "process.elf.sections.physical_size";
            
            /// <summary>
            /// ELF Section List type.
            /// </summary>
            public const string SectionsType = "process.elf.sections.type";
            
            /// <summary>
            /// Variance for Shannon entropy calculation from the section.
            /// </summary>
            public const string SectionsVarEntropy = "process.elf.sections.var_entropy";
            
            /// <summary>
            /// ELF Section List virtual address.
            /// </summary>
            public const string SectionsVirtualAddress = "process.elf.sections.virtual_address";
            
            /// <summary>
            /// ELF Section List virtual size.
            /// </summary>
            public const string SectionsVirtualSize = "process.elf.sections.virtual_size";
            
            /// <summary>
            /// ELF object segment sections.
            /// </summary>
            public const string SegmentsSections = "process.elf.segments.sections";
            
            /// <summary>
            /// ELF object segment type.
            /// </summary>
            public const string SegmentsType = "process.elf.segments.type";
            
        }
    }
}

