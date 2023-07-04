namespace ElasticCommonSchema;

public static partial class ECS
{
    public static partial class Threat
    {
        public static partial class Indicator
        {
            public static partial class File
            {
                /// <summary>
                /// Last time the file was accessed.
                /// </summary>
                public const string Accessed = "threat.indicator.file.accessed";
                
                /// <summary>
                /// Array of file attributes.
                /// </summary>
                /// <example>
                /// <c>["readonly", "system"]</c>
                /// </example>
                public const string Attributes = "threat.indicator.file.attributes";
                
                /// <summary>
                /// File creation time.
                /// </summary>
                public const string Created = "threat.indicator.file.created";
                
                /// <summary>
                /// Last time the file attributes or metadata changed.
                /// </summary>
                public const string Ctime = "threat.indicator.file.ctime";
                
                /// <summary>
                /// Device that is the source of the file.
                /// </summary>
                /// <example>
                /// <c>sda</c>
                /// </example>
                public const string Device = "threat.indicator.file.device";
                
                /// <summary>
                /// Directory where the file is located.
                /// </summary>
                /// <example>
                /// <c>/home/alice</c>
                /// </example>
                public const string Directory = "threat.indicator.file.directory";
                
                /// <summary>
                /// Drive letter where the file is located.
                /// </summary>
                /// <example>
                /// <c>C</c>
                /// </example>
                public const string DriveLetter = "threat.indicator.file.drive_letter";
                
                /// <summary>
                /// File extension, excluding the leading dot.
                /// </summary>
                /// <example>
                /// <c>png</c>
                /// </example>
                public const string Extension = "threat.indicator.file.extension";
                
                /// <summary>
                /// A fork is additional data associated with a filesystem object.
                /// </summary>
                /// <example>
                /// <c>Zone.Identifer</c>
                /// </example>
                public const string ForkName = "threat.indicator.file.fork_name";
                
                /// <summary>
                /// Primary group ID (GID) of the file.
                /// </summary>
                /// <example>
                /// <c>1001</c>
                /// </example>
                public const string Gid = "threat.indicator.file.gid";
                
                /// <summary>
                /// Primary group name of the file.
                /// </summary>
                /// <example>
                /// <c>alice</c>
                /// </example>
                public const string Group = "threat.indicator.file.group";
                
                /// <summary>
                /// Inode representing the file in the filesystem.
                /// </summary>
                /// <example>
                /// <c>256383</c>
                /// </example>
                public const string Inode = "threat.indicator.file.inode";
                
                /// <summary>
                /// Media type of file, document, or arrangement of bytes.
                /// </summary>
                public const string MimeType = "threat.indicator.file.mime_type";
                
                /// <summary>
                /// Mode of the file in octal representation.
                /// </summary>
                /// <example>
                /// <c>0640</c>
                /// </example>
                public const string Mode = "threat.indicator.file.mode";
                
                /// <summary>
                /// Last time the file content was modified.
                /// </summary>
                public const string Mtime = "threat.indicator.file.mtime";
                
                /// <summary>
                /// Name of the file including the extension, without the directory.
                /// </summary>
                /// <example>
                /// <c>example.png</c>
                /// </example>
                public const string Name = "threat.indicator.file.name";
                
                /// <summary>
                /// File owner's username.
                /// </summary>
                /// <example>
                /// <c>alice</c>
                /// </example>
                public const string Owner = "threat.indicator.file.owner";
                
                /// <summary>
                /// Full path to the file, including the file name.
                /// </summary>
                /// <example>
                /// <c>/home/alice/example.png</c>
                /// </example>
                public const string Path = "threat.indicator.file.path";
                
                /// <summary>
                /// File size in bytes.
                /// </summary>
                /// <example>
                /// <c>16384</c>
                /// </example>
                public const string Size = "threat.indicator.file.size";
                
                /// <summary>
                /// Target path for symlinks.
                /// </summary>
                public const string TargetPath = "threat.indicator.file.target_path";
                
                /// <summary>
                /// File type (file, dir, or symlink).
                /// </summary>
                /// <example>
                /// <c>file</c>
                /// </example>
                public const string Type = "threat.indicator.file.type";
                
                /// <summary>
                /// The user ID (UID) or security identifier (SID) of the file owner.
                /// </summary>
                /// <example>
                /// <c>1001</c>
                /// </example>
                public const string Uid = "threat.indicator.file.uid";
                
                /// <summary>
                /// Full path to the file, including the file name.
                /// </summary>
                /// <example>
                /// <c>/home/alice/example.png</c>
                /// </example>
                public const string PathText = "threat.indicator.file.path.text";
                
                /// <summary>
                /// Target path for symlinks.
                /// </summary>
                public const string TargetPathText = "threat.indicator.file.target_path.text";
                
            }
        }
    }
}

