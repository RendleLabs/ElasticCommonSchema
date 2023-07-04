namespace ElasticCommonSchema;

public static partial class ECS
{
    public static partial class Process
    {
        /// <summary>
        /// Array of process arguments.
        /// </summary>
        /// <example>
        /// <c>["/usr/bin/ssh", "-l", "user", "10.0.0.16"]</c>
        /// </example>
        public const string Args = "process.args";
        
        /// <summary>
        /// Length of the process.args array.
        /// </summary>
        /// <example>
        /// <c>4</c>
        /// </example>
        public const string ArgsCount = "process.args_count";
        
        /// <summary>
        /// Full command line that started the process.
        /// </summary>
        /// <example>
        /// <c>/usr/bin/ssh -l user 10.0.0.16</c>
        /// </example>
        public const string CommandLine = "process.command_line";
        
        /// <summary>
        /// The time the process ended.
        /// </summary>
        /// <example>
        /// <c>2016-05-23T08:05:34.853Z</c>
        /// </example>
        public const string End = "process.end";
        
        /// <summary>
        /// Unique identifier for the process.
        /// </summary>
        /// <example>
        /// <c>c2c455d9f99375d</c>
        /// </example>
        public const string EntityId = "process.entity_id";
        
        /// <summary>
        /// Array of environment variable bindings.
        /// </summary>
        /// <example>
        /// <c>["PATH=/usr/local/bin:/usr/bin", "USER=ubuntu"]</c>
        /// </example>
        public const string EnvVars = "process.env_vars";
        
        /// <summary>
        /// Absolute path to the process executable.
        /// </summary>
        /// <example>
        /// <c>/usr/bin/ssh</c>
        /// </example>
        public const string Executable = "process.executable";
        
        /// <summary>
        /// The exit code of the process.
        /// </summary>
        /// <example>
        /// <c>137</c>
        /// </example>
        public const string ExitCode = "process.exit_code";
        
        /// <summary>
        /// Whether the process is connected to an interactive shell.
        /// </summary>
        /// <example>
        /// <c>True</c>
        /// </example>
        public const string Interactive = "process.interactive";
        
        /// <summary>
        /// A chunk of input or output (IO) from a single process.
        /// </summary>
        public const string Io = "process.io";
        
        /// <summary>
        /// Process name.
        /// </summary>
        /// <example>
        /// <c>ssh</c>
        /// </example>
        public const string Name = "process.name";
        
        /// <summary>
        /// Deprecated identifier of the group of processes the process belongs to.
        /// </summary>
        public const string Pgid = "process.pgid";
        
        /// <summary>
        /// Process id.
        /// </summary>
        /// <example>
        /// <c>4242</c>
        /// </example>
        public const string Pid = "process.pid";
        
        /// <summary>
        /// The time the process started.
        /// </summary>
        /// <example>
        /// <c>2016-05-23T08:05:34.853Z</c>
        /// </example>
        public const string Start = "process.start";
        
        /// <summary>
        /// Process title.
        /// </summary>
        public const string Title = "process.title";
        
        /// <summary>
        /// Information about the controlling TTY device.
        /// </summary>
        public const string Tty = "process.tty";
        
        /// <summary>
        /// Seconds the process has been up.
        /// </summary>
        /// <example>
        /// <c>1325</c>
        /// </example>
        public const string Uptime = "process.uptime";
        
        /// <summary>
        /// The working directory of the process.
        /// </summary>
        /// <example>
        /// <c>/home/alice</c>
        /// </example>
        public const string WorkingDirectory = "process.working_directory";
        
        /// <summary>
        /// Full command line that started the process.
        /// </summary>
        /// <example>
        /// <c>/usr/bin/ssh -l user 10.0.0.16</c>
        /// </example>
        public const string CommandLineText = "process.command_line.text";
        
        /// <summary>
        /// Absolute path to the process executable.
        /// </summary>
        /// <example>
        /// <c>/usr/bin/ssh</c>
        /// </example>
        public const string ExecutableText = "process.executable.text";
        
        /// <summary>
        /// An array of byte offsets and lengths denoting where IO data has been skipped.
        /// </summary>
        public const string IoBytesSkipped = "process.io.bytes_skipped";
        
        /// <summary>
        /// If true, the process producing the output has exceeded the max_kilobytes_per_process configuration setting.
        /// </summary>
        public const string IoMaxBytesPerProcessExceeded = "process.io.max_bytes_per_process_exceeded";
        
        /// <summary>
        /// A chunk of output or input sanitized to UTF-8.
        /// </summary>
        public const string IoText = "process.io.text";
        
        /// <summary>
        /// The total number of bytes captured in this event.
        /// </summary>
        public const string IoTotalBytesCaptured = "process.io.total_bytes_captured";
        
        /// <summary>
        /// The total number of bytes that were not captured due to implementation restrictions such as buffer size limits.
        /// </summary>
        public const string IoTotalBytesSkipped = "process.io.total_bytes_skipped";
        
        /// <summary>
        /// The type of object on which the IO action (read or write) was taken.
        /// </summary>
        public const string IoType = "process.io.type";
        
        /// <summary>
        /// Process name.
        /// </summary>
        /// <example>
        /// <c>ssh</c>
        /// </example>
        public const string NameText = "process.name.text";
        
        /// <summary>
        /// Process title.
        /// </summary>
        public const string TitleText = "process.title.text";
        
        /// <summary>
        /// The number of character columns per line. e.g terminal width
        /// </summary>
        /// <example>
        /// <c>80</c>
        /// </example>
        public const string TtyColumns = "process.tty.columns";
        
        /// <summary>
        /// The number of character rows in the terminal. e.g terminal height
        /// </summary>
        /// <example>
        /// <c>24</c>
        /// </example>
        public const string TtyRows = "process.tty.rows";
        
        /// <summary>
        /// The working directory of the process.
        /// </summary>
        /// <example>
        /// <c>/home/alice</c>
        /// </example>
        public const string WorkingDirectoryText = "process.working_directory.text";
        
    }
}

