namespace HexView.Wpf
{
    /// <summary>
    /// Enumerates how the data (bytes read from the buffer) is to be interpreted when displayed.
    /// </summary>
    public enum DataType
    {
        /// <summary>
        /// Display the data as floating point values.
        /// </summary>
        FloatingPoint,

        /// <summary>
        /// Display the data as integral (integer) values.
        /// </summary>
        Integer,
    }

    /// <summary>
    /// Enumerates the signedness of the data to display.
    /// </summary>
    public enum DataSignedness
    {
        /// <summary>
        /// Display the data as signed values.
        /// </summary>
        Signed,

        /// <summary>
        /// Display the data as unsigned values.
        /// </summary>
        Unsigned,
    }

    /// <summary>
    /// Enumerates the format to display integral data in.
    /// </summary>
    public enum DataFormat
    {
        /// <summary>
        /// Display the data in decimal format.
        /// </summary>
        Decimal,

        /// <summary>
        /// Display the data in hexadecimal format.
        /// </summary>
        Hexadecimal,
    }

    /// <summary>
    /// Enumerates the Endianess of the data to display.
    /// </summary>
    public enum DataEndianess
    {
        /// <summary>
        /// Extract the data in Little-Endian format
        /// </summary>
        Little,

        /// <summary>
        /// Extract the data in Big-Endian format
        /// </summary>
        Big,
    }

    /// <summary>
    /// Enumerates the address column formatting options.
    /// </summary>
    public enum AddressFormat
    {
        /// <summary>
        /// 16 bit HEX address "0000".
        /// </summary>
        Address16,

        /// <summary>
        /// 24 bit HEX address "00:0000".
        /// </summary>
        Address24,

        /// <summary>
        /// 32 bit HEX address "0000:0000".
        /// </summary>
        Address32,

        /// <summary>
        /// 48 bit HEX address "0000:00000000".
        /// </summary>
        Address48,

        /// <summary>
        /// 64 bit HEX address "00000000:00000000".
        /// </summary>
        Address64,
    }

    /// <summary>
    /// Enumerates the address column formatting options.
    /// </summary>
    public enum AddressDisplayFormat
    {
        /// <summary>16 bit HEX address "0000" 4 spaces. </summary>
        Addr16,

        /// <summary>24 bit HEX address "00:0000" 7 spaces. </summary>
        Addr24,

        /// <summary>32 bit HEX address "0000:0000" 9 spaces. </summary>
        Addr32,

        /// <summary>48 bit HEX address "0000:00000000" 13 spaces. </summary>
        Addr48,

        /// <summary>64 bit HEX address "00000000:00000000" 17 spaces. </summary>
        Addr64,
    }

    /// <summary>
    /// Enumerates the text section encodings/formats that the control is able to display.
    /// </summary>
    public enum TextFormat
    {
        /// <summary>
        /// Display data in ASCII (ISO-8859-1) encoding.
        /// </summary>
        Ascii,
    }
}
