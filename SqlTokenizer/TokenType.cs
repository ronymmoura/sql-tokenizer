using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SqlTokenizer
{
    /// <summary>
    /// Enum that contains the types that one token can be.
    /// </summary>
    public enum TokenType
    {
        None = 0,
        Word,
        Keyword,
        Number,
        String,
        Symbol,
        Variable
    }
}