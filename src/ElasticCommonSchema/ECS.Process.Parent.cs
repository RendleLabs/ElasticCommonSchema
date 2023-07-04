namespace ElasticCommonSchema;

public static partial class ECS
{
    public static partial class Process
    {
        public static partial class Parent
        {
            /// <summary>
            /// Array of process arguments.
            /// </summary>
            /// <example>
            /// <c>["/usr/bin/ssh", "-l", "user", "10.0.0.16"]</c>
            /// </example>
            public const string Args = "process.parent.args";
            
            /// <summary>
            /// Length of the process.args array.
            /// </summary>
            /// <example>
            /// <c>4</c>
            /// </example>
            public const string ArgsCount = "process.parent.args_count";
            
            /// <summary>
            /// Full command line that started the process.
            /// </summary>
            /// <example>
            /// <c>/usr/bin/ssh -l user 10.0.0.16</c>
            /// </example>
            public const string CommandLine = "process.parent.command_line";
            
            /// <summary>
            /// The time the process ended.
            /// </summary>
            /// <example>
            /// <c>2016-05-23T08:05:34.853Z</c>
            /// </example>
            public const string End = "process.parent.end";
            
            /// <summary>
            /// Unique identifier for the process.
            /// </summary>
            /// <example>
            /// <c>c2c455d9f99375d</c>
            /// </example>
            public const string EntityId = "process.parent.entity_id";
            
            /// <summary>
            /// Absolute path to the process executable.
            /// </summary>
            /// <example>
            /// <c>/usr/bin/ssh</c>
            /// </example>
            public const string Executable = "process.parent.executable";
            
            /// <summary>
            /// The exit code of the process.
            /// </summary>
            /// <example>
            /// <c>137</c>
            /// </example>
            public const string ExitCode = "process.parent.exit_code";
            
            /// <summary>
            /// Whether the process is connected to an interactive shell.
            /// </summary>
            /// <example>
            /// <c>True</c>
            /// </example>
            public const string Interactive = "process.parent.interactive";
            
            /// <summary>
            /// Process name.
            /// </summary>
            /// <example>
            /// <c>ssh</c>
            /// </example>
            public const string Name = "process.parent.name";
            
            /// <summary>
            /// Deprecated identifier of the group of processes the process belongs to.
            /// </summary>
            public const string Pgid = "process.parent.pgid";
            
            /// <summary>
            /// Process id.
            /// </summary>
            /// <example>
            /// <c>4242</c>
            /// </example>
            public const string Pid = "process.parent.pid";
            
            /// <summary>
            /// The time the process started.
            /// </summary>
            /// <example>
            /// <c>2016-05-23T08:05:34.853Z</c>
            /// </example>
            public const string Start = "process.parent.start";
            
            /// <summary>
            /// Process title.
            /// </summary>
            public const string Title = "process.parent.title";
            
            /// <summary>
            /// Information about the controlling TTY device.
            /// </summary>
            public const string Tty = "process.parent.tty";
            
            /// <summary>
            /// Seconds the process has been up.
            /// </summary>
            /// <example>
            /// <c>1325</c>
            /// </example>
            public const string Uptime = "process.parent.uptime";
            
            /// <summary>
            /// The working directory of the process.
            /// </summary>
            /// <example>
            /// <c>/home/alice</c>
            /// </example>
            public const string WorkingDirectory = "process.parent.working_directory";
            
            /// <summary>
            /// Full command line that started the process.
            /// </summary>
            /// <example>
            /// <c>/usr/bin/ssh -l user 10.0.0.16</c>
            /// </example>
            public const string CommandLineText = "process.parent.command_line.text";
            
            /// <summary>
            /// Absolute path to the process executable.
            /// </summary>
            /// <example>
            /// <c>/usr/bin/ssh</c>
            /// </example>
            public const string ExecutableText = "process.parent.executable.text";
            
            /// <summary>
            /// Process name.
            /// </summary>
            /// <example>
            /// <c>ssh</c>
            /// </example>
            public const string NameText = "process.parent.name.text";
            
            /// <summary>
            /// Process title.
            /// </summary>
            public const string TitleText = "process.parent.title.text";
            
            /// <summary>
            /// The working directory of the process.
            /// </summary>
            /// <example>
            /// <c>/home/alice</c>
            /// </example>
            public const string WorkingDirectoryText = "process.parent.working_directory.text";
            
        }
    }
}

