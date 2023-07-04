namespace ElasticCommonSchema;

public static partial class ECS
{
    public static partial class Process
    {
        public static partial class Previous
        {
            /// <summary>
            /// Array of process arguments.
            /// </summary>
            /// <example>
            /// <c>["/usr/bin/ssh", "-l", "user", "10.0.0.16"]</c>
            /// </example>
            public const string Args = "process.previous.args";
            
            /// <summary>
            /// Length of the process.args array.
            /// </summary>
            /// <example>
            /// <c>4</c>
            /// </example>
            public const string ArgsCount = "process.previous.args_count";
            
            /// <summary>
            /// Absolute path to the process executable.
            /// </summary>
            /// <example>
            /// <c>/usr/bin/ssh</c>
            /// </example>
            public const string Executable = "process.previous.executable";
            
            /// <summary>
            /// Absolute path to the process executable.
            /// </summary>
            /// <example>
            /// <c>/usr/bin/ssh</c>
            /// </example>
            public const string ExecutableText = "process.previous.executable.text";
            
        }
    }
}

