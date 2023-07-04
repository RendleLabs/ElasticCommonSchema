namespace Generator;

public static class StringExtensions
{
    public static string ToPascalCase(this string original)
    {
        Span<char> span = stackalloc char[original.Length];

        bool upper = true;
        int index = 0;

        foreach (var c in original.AsSpan())
        {
            if (c == '_')
            {
                upper = true;
                continue;
            }
            if (!char.IsLetterOrDigit(c)) continue;
            if (upper)
            {
                span[index] = char.ToUpperInvariant(c);
                upper = false;
            }
            else
            {
                span[index] = c;
            }

            index++;
        }

        return new string(span.Slice(0, index));
    }
}