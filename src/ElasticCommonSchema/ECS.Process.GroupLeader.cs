namespace ElasticCommonSchema;

public static partial class ECS
{
    public static partial class Process
    {
        public static partial class GroupLeader
        {
            /// <summary>
            /// Array of process arguments.
            /// </summary>
            /// <example>
            /// <c>["/usr/bin/ssh", "-l", "user", "10.0.0.16"]</c>
            /// </example>
            public const string Args = "process.group_leader.args";
            
            /// <summary>
            /// Length of the process.args array.
            /// </summary>
            /// <example>
            /// <c>4</c>
            /// </example>
            public const string ArgsCount = "process.group_leader.args_count";
            
            /// <summary>
            /// Full command line that started the process.
            /// </summary>
            /// <example>
            /// <c>/usr/bin/ssh -l user 10.0.0.16</c>
            /// </example>
            public const string CommandLine = "process.group_leader.command_line";
            
            /// <summary>
            /// Unique identifier for the process.
            /// </summary>
            /// <example>
            /// <c>c2c455d9f99375d</c>
            /// </example>
            public const string EntityId = "process.group_leader.entity_id";
            
            /// <summary>
            /// Absolute path to the process executable.
            /// </summary>
            /// <example>
            /// <c>/usr/bin/ssh</c>
            /// </example>
            public const string Executable = "process.group_leader.executable";
            
            /// <summary>
            /// Whether the process is connected to an interactive shell.
            /// </summary>
            /// <example>
            /// <c>True</c>
            /// </example>
            public const string Interactive = "process.group_leader.interactive";
            
            /// <summary>
            /// Process name.
            /// </summary>
            /// <example>
            /// <c>ssh</c>
            /// </example>
            public const string Name = "process.group_leader.name";
            
            /// <summary>
            /// Process id.
            /// </summary>
            /// <example>
            /// <c>4242</c>
            /// </example>
            public const string Pid = "process.group_leader.pid";
            
            /// <summary>
            /// This boolean is used to identify if a leader process is the same as the top level process.
            /// </summary>
            /// <example>
            /// <c>True</c>
            /// </example>
            public const string SameAsProcess = "process.group_leader.same_as_process";
            
            /// <summary>
            /// The time the process started.
            /// </summary>
            /// <example>
            /// <c>2016-05-23T08:05:34.853Z</c>
            /// </example>
            public const string Start = "process.group_leader.start";
            
            /// <summary>
            /// Information about the controlling TTY device.
            /// </summary>
            public const string Tty = "process.group_leader.tty";
            
            /// <summary>
            /// The working directory of the process.
            /// </summary>
            /// <example>
            /// <c>/home/alice</c>
            /// </example>
            public const string WorkingDirectory = "process.group_leader.working_directory";
            
            /// <summary>
            /// Full command line that started the process.
            /// </summary>
            /// <example>
            /// <c>/usr/bin/ssh -l user 10.0.0.16</c>
            /// </example>
            public const string CommandLineText = "process.group_leader.command_line.text";
            
            /// <summary>
            /// Absolute path to the process executable.
            /// </summary>
            /// <example>
            /// <c>/usr/bin/ssh</c>
            /// </example>
            public const string ExecutableText = "process.group_leader.executable.text";
            
            /// <summary>
            /// Process name.
            /// </summary>
            /// <example>
            /// <c>ssh</c>
            /// </example>
            public const string NameText = "process.group_leader.name.text";
            
            /// <summary>
            /// The working directory of the process.
            /// </summary>
            /// <example>
            /// <c>/home/alice</c>
            /// </example>
            public const string WorkingDirectoryText = "process.group_leader.working_directory.text";
            
        }
    }
}

