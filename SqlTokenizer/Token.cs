namespace SqlTokenizer
{
    /// <summary>
    /// Class that represents a token.
    /// </summary>
    public class Token
    {
        public TokenType Type { get; set; }
        public string Value { get; set; }

        /// <summary>
        /// Compare two tokens.
        /// </summary>
        /// <param name="type">The type of the token to be compared.</param>
        /// <param name="value">The value of the token to be compared.</param>
        /// <returns></returns>
        public bool Equals(TokenType type, string value)
        {
            return Type == type && Value == value;
        }
    }
}
