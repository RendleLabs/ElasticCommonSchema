namespace ElasticCommonSchema;

public static partial class ECS
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
            public const string Architecture = "file.elf.architecture";
            
            /// <summary>
            /// Byte sequence of ELF file.
            /// </summary>
            /// <example>
            /// <c>Little Endian</c>
            /// </example>
            public const string ByteOrder = "file.elf.byte_order";
            
            /// <summary>
            /// CPU type of the ELF file.
            /// </summary>
            /// <example>
            /// <c>Intel</c>
            /// </example>
            public const string CpuType = "file.elf.cpu_type";
            
            /// <summary>
            /// Build or compile date.
            /// </summary>
            public const string CreationDate = "file.elf.creation_date";
            
            /// <summary>
            /// List of exported element names and types.
            /// </summary>
            public const string Exports = "file.elf.exports";
            
            /// <summary>
            /// A hash of the Go language imports in an ELF file.
            /// </summary>
            /// <example>
            /// <c>10bddcb4cee42080f76c88d9ff964491</c>
            /// </example>
            public const string GoImportHash = "file.elf.go_import_hash";
            
            /// <summary>
            /// List of imported Go language element names and types.
            /// </summary>
            public const string GoImports = "file.elf.go_imports";
            
            /// <summary>
            /// Shannon entropy calculation from the list of Go imports.
            /// </summary>
            public const string GoImportsNamesEntropy = "file.elf.go_imports_names_entropy";
            
            /// <summary>
            /// Variance for Shannon entropy calculation from the list of Go imports.
            /// </summary>
            public const string GoImportsNamesVarEntropy = "file.elf.go_imports_names_var_entropy";
            
            /// <summary>
            /// Whether the file is a stripped or obfuscated Go executable.
            /// </summary>
            public const string GoStripped = "file.elf.go_stripped";
            
            /// <summary>
            /// A hash of the imports in an ELF file.
            /// </summary>
            /// <example>
            /// <c>d41d8cd98f00b204e9800998ecf8427e</c>
            /// </example>
            public const string ImportHash = "file.elf.import_hash";
            
            /// <summary>
            /// List of imported element names and types.
            /// </summary>
            public const string Imports = "file.elf.imports";
            
            /// <summary>
            /// Shannon entropy calculation from the list of imported element names and types.
            /// </summary>
            public const string ImportsNamesEntropy = "file.elf.imports_names_entropy";
            
            /// <summary>
            /// Variance for Shannon entropy calculation from the list of imported element names and types.
            /// </summary>
            public const string ImportsNamesVarEntropy = "file.elf.imports_names_var_entropy";
            
            /// <summary>
            /// Section information of the ELF file.
            /// </summary>
            public const string Sections = "file.elf.sections";
            
            /// <summary>
            /// ELF object segment list.
            /// </summary>
            public const string Segments = "file.elf.segments";
            
            /// <summary>
            /// List of shared libraries used by this ELF object.
            /// </summary>
            public const string SharedLibraries = "file.elf.shared_libraries";
            
            /// <summary>
            /// telfhash hash for ELF file.
            /// </summary>
            public const string Telfhash = "file.elf.telfhash";
            
            /// <summary>
            /// Chi-square probability distribution of the section.
            /// </summary>
            public const string SectionsChi2 = "file.elf.sections.chi2";
            
            /// <summary>
            /// Shannon entropy calculation from the section.
            /// </summary>
            public const string SectionsEntropy = "file.elf.sections.entropy";
            
            /// <summary>
            /// ELF Section List flags.
            /// </summary>
            public const string SectionsFlags = "file.elf.sections.flags";
            
            /// <summary>
            /// ELF Section List name.
            /// </summary>
            public const string SectionsName = "file.elf.sections.name";
            
            /// <summary>
            /// ELF Section List offset.
            /// </summary>
            public const string SectionsPhysicalOffset = "file.elf.sections.physical_offset";
            
            /// <summary>
            /// ELF Section List physical size.
            /// </summary>
            public const string SectionsPhysicalSize = "file.elf.sections.physical_size";
            
            /// <summary>
            /// ELF Section List type.
            /// </summary>
            public const string SectionsType = "file.elf.sections.type";
            
            /// <summary>
            /// Variance for Shannon entropy calculation from the section.
            /// </summary>
            public const string SectionsVarEntropy = "file.elf.sections.var_entropy";
            
            /// <summary>
            /// ELF Section List virtual address.
            /// </summary>
            public const string SectionsVirtualAddress = "file.elf.sections.virtual_address";
            
            /// <summary>
            /// ELF Section List virtual size.
            /// </summary>
            public const string SectionsVirtualSize = "file.elf.sections.virtual_size";
            
            /// <summary>
            /// ELF object segment sections.
            /// </summary>
            public const string SegmentsSections = "file.elf.segments.sections";
            
            /// <summary>
            /// ELF object segment type.
            /// </summary>
            public const string SegmentsType = "file.elf.segments.type";
            
        }
    }
}

