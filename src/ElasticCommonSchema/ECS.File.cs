namespace ElasticCommonSchema;

public static partial class ECS
{
    public static partial class File
    {
        /// <summary>
        /// Last time the file was accessed.
        /// </summary>
        public const string Accessed = "file.accessed";
        
        /// <summary>
        /// Array of file attributes.
        /// </summary>
        /// <example>
        /// <c>["readonly", "system"]</c>
        /// </example>
        public const string Attributes = "file.attributes";
        
        /// <summary>
        /// File creation time.
        /// </summary>
        public const string Created = "file.created";
        
        /// <summary>
        /// Last time the file attributes or metadata changed.
        /// </summary>
        public const string Ctime = "file.ctime";
        
        /// <summary>
        /// Device that is the source of the file.
        /// </summary>
        /// <example>
        /// <c>sda</c>
        /// </example>
        public const string Device = "file.device";
        
        /// <summary>
        /// Directory where the file is located.
        /// </summary>
        /// <example>
        /// <c>/home/alice</c>
        /// </example>
        public const string Directory = "file.directory";
        
        /// <summary>
        /// Drive letter where the file is located.
        /// </summary>
        /// <example>
        /// <c>C</c>
        /// </example>
        public const string DriveLetter = "file.drive_letter";
        
        /// <summary>
        /// File extension, excluding the leading dot.
        /// </summary>
        /// <example>
        /// <c>png</c>
        /// </example>
        public const string Extension = "file.extension";
        
        /// <summary>
        /// A fork is additional data associated with a filesystem object.
        /// </summary>
        /// <example>
        /// <c>Zone.Identifer</c>
        /// </example>
        public const string ForkName = "file.fork_name";
        
        /// <summary>
        /// Primary group ID (GID) of the file.
        /// </summary>
        /// <example>
        /// <c>1001</c>
        /// </example>
        public const string Gid = "file.gid";
        
        /// <summary>
        /// Primary group name of the file.
        /// </summary>
        /// <example>
        /// <c>alice</c>
        /// </example>
        public const string Group = "file.group";
        
        /// <summary>
        /// Inode representing the file in the filesystem.
        /// </summary>
        /// <example>
        /// <c>256383</c>
        /// </example>
        public const string Inode = "file.inode";
        
        /// <summary>
        /// Media type of file, document, or arrangement of bytes.
        /// </summary>
        public const string MimeType = "file.mime_type";
        
        /// <summary>
        /// Mode of the file in octal representation.
        /// </summary>
        /// <example>
        /// <c>0640</c>
        /// </example>
        public const string Mode = "file.mode";
        
        /// <summary>
        /// Last time the file content was modified.
        /// </summary>
        public const string Mtime = "file.mtime";
        
        /// <summary>
        /// Name of the file including the extension, without the directory.
        /// </summary>
        /// <example>
        /// <c>example.png</c>
        /// </example>
        public const string Name = "file.name";
        
        /// <summary>
        /// File owner's username.
        /// </summary>
        /// <example>
        /// <c>alice</c>
        /// </example>
        public const string Owner = "file.owner";
        
        /// <summary>
        /// Full path to the file, including the file name.
        /// </summary>
        /// <example>
        /// <c>/home/alice/example.png</c>
        /// </example>
        public const string Path = "file.path";
        
        /// <summary>
        /// File size in bytes.
        /// </summary>
        /// <example>
        /// <c>16384</c>
        /// </example>
        public const string Size = "file.size";
        
        /// <summary>
        /// Target path for symlinks.
        /// </summary>
        public const string TargetPath = "file.target_path";
        
        /// <summary>
        /// File type (file, dir, or symlink).
        /// </summary>
        /// <example>
        /// <c>file</c>
        /// </example>
        public const string Type = "file.type";
        
        /// <summary>
        /// The user ID (UID) or security identifier (SID) of the file owner.
        /// </summary>
        /// <example>
        /// <c>1001</c>
        /// </example>
        public const string Uid = "file.uid";
        
        /// <summary>
        /// Full path to the file, including the file name.
        /// </summary>
        /// <example>
        /// <c>/home/alice/example.png</c>
        /// </example>
        public const string PathText = "file.path.text";
        
        /// <summary>
        /// Target path for symlinks.
        /// </summary>
        public const string TargetPathText = "file.target_path.text";
        
    }
}

