namespace ElasticCommonSchema;

public static partial class ECS
{
    public static partial class Process
    {
        public static partial class Parent
        {
            public static partial class Elf
            {
                public static partial class Header
                {
                    /// <summary>
                    /// Version of the ELF Application Binary Interface (ABI).
                    /// </summary>
                    public const string AbiVersion = "process.parent.elf.header.abi_version";
                    
                    /// <summary>
                    /// Header class of the ELF file.
                    /// </summary>
                    public const string Class = "process.parent.elf.header.class";
                    
                    /// <summary>
                    /// Data table of the ELF header.
                    /// </summary>
                    public const string Data = "process.parent.elf.header.data";
                    
                    /// <summary>
                    /// Header entrypoint of the ELF file.
                    /// </summary>
                    public const string Entrypoint = "process.parent.elf.header.entrypoint";
                    
                    /// <summary>
                    /// "0x1" for original ELF files.
                    /// </summary>
                    public const string ObjectVersion = "process.parent.elf.header.object_version";
                    
                    /// <summary>
                    /// Application Binary Interface (ABI) of the Linux OS.
                    /// </summary>
                    public const string OsAbi = "process.parent.elf.header.os_abi";
                    
                    /// <summary>
                    /// Header type of the ELF file.
                    /// </summary>
                    public const string Type = "process.parent.elf.header.type";
                    
                    /// <summary>
                    /// Version of the ELF header.
                    /// </summary>
                    public const string Version = "process.parent.elf.header.version";
                    
                }
            }
        }
    }
}

