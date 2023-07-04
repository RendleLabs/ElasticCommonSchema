namespace ElasticCommonSchema;

public static partial class ECS
{
    public static partial class Process
    {
        public static partial class Elf
        {
            public static partial class Header
            {
                /// <summary>
                /// Version of the ELF Application Binary Interface (ABI).
                /// </summary>
                public const string AbiVersion = "process.elf.header.abi_version";
                
                /// <summary>
                /// Header class of the ELF file.
                /// </summary>
                public const string Class = "process.elf.header.class";
                
                /// <summary>
                /// Data table of the ELF header.
                /// </summary>
                public const string Data = "process.elf.header.data";
                
                /// <summary>
                /// Header entrypoint of the ELF file.
                /// </summary>
                public const string Entrypoint = "process.elf.header.entrypoint";
                
                /// <summary>
                /// "0x1" for original ELF files.
                /// </summary>
                public const string ObjectVersion = "process.elf.header.object_version";
                
                /// <summary>
                /// Application Binary Interface (ABI) of the Linux OS.
                /// </summary>
                public const string OsAbi = "process.elf.header.os_abi";
                
                /// <summary>
                /// Header type of the ELF file.
                /// </summary>
                public const string Type = "process.elf.header.type";
                
                /// <summary>
                /// Version of the ELF header.
                /// </summary>
                public const string Version = "process.elf.header.version";
                
            }
        }
    }
}

