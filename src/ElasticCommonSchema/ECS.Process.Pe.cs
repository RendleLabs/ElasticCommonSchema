namespace ElasticCommonSchema;

public static partial class ECS
{
    public static partial class Process
    {
        public static partial class Pe
        {
            /// <summary>
            /// CPU architecture target for the file.
            /// </summary>
            /// <example>
            /// <c>x64</c>
            /// </example>
            public const string Architecture = "process.pe.architecture";
            
            /// <summary>
            /// Internal company name of the file, provided at compile-time.
            /// </summary>
            /// <example>
            /// <c>Microsoft Corporation</c>
            /// </example>
            public const string Company = "process.pe.company";
            
            /// <summary>
            /// Internal description of the file, provided at compile-time.
            /// </summary>
            /// <example>
            /// <c>Paint</c>
            /// </example>
            public const string Description = "process.pe.description";
            
            /// <summary>
            /// Process name.
            /// </summary>
            /// <example>
            /// <c>6.3.9600.17415</c>
            /// </example>
            public const string FileVersion = "process.pe.file_version";
            
            /// <summary>
            /// A hash of the Go language imports in a PE file.
            /// </summary>
            /// <example>
            /// <c>10bddcb4cee42080f76c88d9ff964491</c>
            /// </example>
            public const string GoImportHash = "process.pe.go_import_hash";
            
            /// <summary>
            /// List of imported Go language element names and types.
            /// </summary>
            public const string GoImports = "process.pe.go_imports";
            
            /// <summary>
            /// Shannon entropy calculation from the list of Go imports.
            /// </summary>
            public const string GoImportsNamesEntropy = "process.pe.go_imports_names_entropy";
            
            /// <summary>
            /// Variance for Shannon entropy calculation from the list of Go imports.
            /// </summary>
            public const string GoImportsNamesVarEntropy = "process.pe.go_imports_names_var_entropy";
            
            /// <summary>
            /// Whether the file is a stripped or obfuscated Go executable.
            /// </summary>
            public const string GoStripped = "process.pe.go_stripped";
            
            /// <summary>
            /// A hash of the imports in a PE file.
            /// </summary>
            /// <example>
            /// <c>0c6803c4e922103c4dca5963aad36ddf</c>
            /// </example>
            public const string Imphash = "process.pe.imphash";
            
            /// <summary>
            /// A hash of the imports in a PE file.
            /// </summary>
            /// <example>
            /// <c>d41d8cd98f00b204e9800998ecf8427e</c>
            /// </example>
            public const string ImportHash = "process.pe.import_hash";
            
            /// <summary>
            /// List of imported element names and types.
            /// </summary>
            public const string Imports = "process.pe.imports";
            
            /// <summary>
            /// Shannon entropy calculation from the list of imported element names and types.
            /// </summary>
            public const string ImportsNamesEntropy = "process.pe.imports_names_entropy";
            
            /// <summary>
            /// Variance for Shannon entropy calculation from the list of imported element names and types.
            /// </summary>
            public const string ImportsNamesVarEntropy = "process.pe.imports_names_var_entropy";
            
            /// <summary>
            /// Internal name of the file, provided at compile-time.
            /// </summary>
            /// <example>
            /// <c>MSPAINT.EXE</c>
            /// </example>
            public const string OriginalFileName = "process.pe.original_file_name";
            
            /// <summary>
            /// A hash of the PE header and data from one or more PE sections.
            /// </summary>
            /// <example>
            /// <c>73ff189b63cd6be375a7ff25179a38d347651975</c>
            /// </example>
            public const string Pehash = "process.pe.pehash";
            
            /// <summary>
            /// Internal product name of the file, provided at compile-time.
            /// </summary>
            /// <example>
            /// <c>Microsoft® Windows® Operating System</c>
            /// </example>
            public const string Product = "process.pe.product";
            
            /// <summary>
            /// Section information of the PE file.
            /// </summary>
            public const string Sections = "process.pe.sections";
            
            /// <summary>
            /// Shannon entropy calculation from the section.
            /// </summary>
            public const string SectionsEntropy = "process.pe.sections.entropy";
            
            /// <summary>
            /// PE Section List name.
            /// </summary>
            public const string SectionsName = "process.pe.sections.name";
            
            /// <summary>
            /// PE Section List physical size.
            /// </summary>
            public const string SectionsPhysicalSize = "process.pe.sections.physical_size";
            
            /// <summary>
            /// Variance for Shannon entropy calculation from the section.
            /// </summary>
            public const string SectionsVarEntropy = "process.pe.sections.var_entropy";
            
            /// <summary>
            /// PE Section List virtual size. This is always the same as `physical_size`.
            /// </summary>
            public const string SectionsVirtualSize = "process.pe.sections.virtual_size";
            
        }
    }
}

