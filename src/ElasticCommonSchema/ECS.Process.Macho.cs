namespace ElasticCommonSchema;

public static partial class ECS
{
    public static partial class Process
    {
        public static partial class Macho
        {
            /// <summary>
            /// A hash of the Go language imports in a Mach-O file.
            /// </summary>
            /// <example>
            /// <c>10bddcb4cee42080f76c88d9ff964491</c>
            /// </example>
            public const string GoImportHash = "process.macho.go_import_hash";
            
            /// <summary>
            /// List of imported Go language element names and types.
            /// </summary>
            public const string GoImports = "process.macho.go_imports";
            
            /// <summary>
            /// Shannon entropy calculation from the list of Go imports.
            /// </summary>
            public const string GoImportsNamesEntropy = "process.macho.go_imports_names_entropy";
            
            /// <summary>
            /// Variance for Shannon entropy calculation from the list of Go imports.
            /// </summary>
            public const string GoImportsNamesVarEntropy = "process.macho.go_imports_names_var_entropy";
            
            /// <summary>
            /// Whether the file is a stripped or obfuscated Go executable.
            /// </summary>
            public const string GoStripped = "process.macho.go_stripped";
            
            /// <summary>
            /// A hash of the imports in a Mach-O file.
            /// </summary>
            /// <example>
            /// <c>d41d8cd98f00b204e9800998ecf8427e</c>
            /// </example>
            public const string ImportHash = "process.macho.import_hash";
            
            /// <summary>
            /// List of imported element names and types.
            /// </summary>
            public const string Imports = "process.macho.imports";
            
            /// <summary>
            /// Shannon entropy calculation from the list of imported element names and types.
            /// </summary>
            public const string ImportsNamesEntropy = "process.macho.imports_names_entropy";
            
            /// <summary>
            /// Variance for Shannon entropy calculation from the list of imported element names and types.
            /// </summary>
            public const string ImportsNamesVarEntropy = "process.macho.imports_names_var_entropy";
            
            /// <summary>
            /// Section information of the Mach-O file.
            /// </summary>
            public const string Sections = "process.macho.sections";
            
            /// <summary>
            /// A hash of the imports in a Mach-O file.
            /// </summary>
            /// <example>
            /// <c>d3ccf195b62a9279c3c19af1080497ec</c>
            /// </example>
            public const string Symhash = "process.macho.symhash";
            
            /// <summary>
            /// Shannon entropy calculation from the section.
            /// </summary>
            public const string SectionsEntropy = "process.macho.sections.entropy";
            
            /// <summary>
            /// Mach-O Section List name.
            /// </summary>
            public const string SectionsName = "process.macho.sections.name";
            
            /// <summary>
            /// Mach-O Section List physical size.
            /// </summary>
            public const string SectionsPhysicalSize = "process.macho.sections.physical_size";
            
            /// <summary>
            /// Variance for Shannon entropy calculation from the section.
            /// </summary>
            public const string SectionsVarEntropy = "process.macho.sections.var_entropy";
            
            /// <summary>
            /// Mach-O Section List virtual size. This is always the same as `physical_size`.
            /// </summary>
            public const string SectionsVirtualSize = "process.macho.sections.virtual_size";
            
        }
    }
}

