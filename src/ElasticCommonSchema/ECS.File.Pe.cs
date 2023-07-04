﻿namespace ElasticCommonSchema;

public static partial class ECS
{
    public static partial class File
    {
        public static partial class Pe
        {
            /// <summary>
            /// CPU architecture target for the file.
            /// </summary>
            /// <example>
            /// <c>x64</c>
            /// </example>
            public const string Architecture = "file.pe.architecture";
            
            /// <summary>
            /// Internal company name of the file, provided at compile-time.
            /// </summary>
            /// <example>
            /// <c>Microsoft Corporation</c>
            /// </example>
            public const string Company = "file.pe.company";
            
            /// <summary>
            /// Internal description of the file, provided at compile-time.
            /// </summary>
            /// <example>
            /// <c>Paint</c>
            /// </example>
            public const string Description = "file.pe.description";
            
            /// <summary>
            /// Process name.
            /// </summary>
            /// <example>
            /// <c>6.3.9600.17415</c>
            /// </example>
            public const string FileVersion = "file.pe.file_version";
            
            /// <summary>
            /// A hash of the Go language imports in a PE file.
            /// </summary>
            /// <example>
            /// <c>10bddcb4cee42080f76c88d9ff964491</c>
            /// </example>
            public const string GoImportHash = "file.pe.go_import_hash";
            
            /// <summary>
            /// List of imported Go language element names and types.
            /// </summary>
            public const string GoImports = "file.pe.go_imports";
            
            /// <summary>
            /// Shannon entropy calculation from the list of Go imports.
            /// </summary>
            public const string GoImportsNamesEntropy = "file.pe.go_imports_names_entropy";
            
            /// <summary>
            /// Variance for Shannon entropy calculation from the list of Go imports.
            /// </summary>
            public const string GoImportsNamesVarEntropy = "file.pe.go_imports_names_var_entropy";
            
            /// <summary>
            /// Whether the file is a stripped or obfuscated Go executable.
            /// </summary>
            public const string GoStripped = "file.pe.go_stripped";
            
            /// <summary>
            /// A hash of the imports in a PE file.
            /// </summary>
            /// <example>
            /// <c>0c6803c4e922103c4dca5963aad36ddf</c>
            /// </example>
            public const string Imphash = "file.pe.imphash";
            
            /// <summary>
            /// A hash of the imports in a PE file.
            /// </summary>
            /// <example>
            /// <c>d41d8cd98f00b204e9800998ecf8427e</c>
            /// </example>
            public const string ImportHash = "file.pe.import_hash";
            
            /// <summary>
            /// List of imported element names and types.
            /// </summary>
            public const string Imports = "file.pe.imports";
            
            /// <summary>
            /// Shannon entropy calculation from the list of imported element names and types.
            /// </summary>
            public const string ImportsNamesEntropy = "file.pe.imports_names_entropy";
            
            /// <summary>
            /// Variance for Shannon entropy calculation from the list of imported element names and types.
            /// </summary>
            public const string ImportsNamesVarEntropy = "file.pe.imports_names_var_entropy";
            
            /// <summary>
            /// Internal name of the file, provided at compile-time.
            /// </summary>
            /// <example>
            /// <c>MSPAINT.EXE</c>
            /// </example>
            public const string OriginalFileName = "file.pe.original_file_name";
            
            /// <summary>
            /// A hash of the PE header and data from one or more PE sections.
            /// </summary>
            /// <example>
            /// <c>73ff189b63cd6be375a7ff25179a38d347651975</c>
            /// </example>
            public const string Pehash = "file.pe.pehash";
            
            /// <summary>
            /// Internal product name of the file, provided at compile-time.
            /// </summary>
            /// <example>
            /// <c>Microsoft® Windows® Operating System</c>
            /// </example>
            public const string Product = "file.pe.product";
            
            /// <summary>
            /// Section information of the PE file.
            /// </summary>
            public const string Sections = "file.pe.sections";
            
            /// <summary>
            /// Shannon entropy calculation from the section.
            /// </summary>
            public const string SectionsEntropy = "file.pe.sections.entropy";
            
            /// <summary>
            /// PE Section List name.
            /// </summary>
            public const string SectionsName = "file.pe.sections.name";
            
            /// <summary>
            /// PE Section List physical size.
            /// </summary>
            public const string SectionsPhysicalSize = "file.pe.sections.physical_size";
            
            /// <summary>
            /// Variance for Shannon entropy calculation from the section.
            /// </summary>
            public const string SectionsVarEntropy = "file.pe.sections.var_entropy";
            
            /// <summary>
            /// PE Section List virtual size. This is always the same as `physical_size`.
            /// </summary>
            public const string SectionsVirtualSize = "file.pe.sections.virtual_size";
            
        }
    }
}

