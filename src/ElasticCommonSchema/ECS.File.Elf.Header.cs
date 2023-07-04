namespace ElasticCommonSchema;

public static partial class ECS
{
    public static partial class File
    {
        public static partial class Elf
        {
            public static partial class Header
            {
                /// <summary>
                /// Version of the ELF Application Binary Interface (ABI).
                /// </summary>
                public const string AbiVersion = "file.elf.header.abi_version";
                
                /// <summary>
                /// Header class of the ELF file.
                /// </summary>
                public const string Class = "file.elf.header.class";
                
                /// <summary>
                /// Data table of the ELF header.
                /// </summary>
                public const string Data = "file.elf.header.data";
                
                /// <summary>
                /// Header entrypoint of the ELF file.
                /// </summary>
                public const string Entrypoint = "file.elf.header.entrypoint";
                
                /// <summary>
                /// "0x1" for original ELF files.
                /// </summary>
                public const string ObjectVersion = "file.elf.header.object_version";
                
                /// <summary>
                /// Application Binary Interface (ABI) of the Linux OS.
                /// </summary>
                public const string OsAbi = "file.elf.header.os_abi";
                
                /// <summary>
                /// Header type of the ELF file.
                /// </summary>
                public const string Type = "file.elf.header.type";
                
                /// <summary>
                /// Version of the ELF header.
                /// </summary>
                public const string Version = "file.elf.header.version";
                
            }
        }
    }
}

