using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace SqlTokenizer.Tests
{
    [TestClass]
    public class MainTests
    {
        [TestMethod]
        public void CanGenerateTokens()
        {
            var tokenizer = new Tokenizer("SELECT");
            var tokens = tokenizer.GetTokens();

            Assert.AreNotEqual(0, tokens.Count);
        }
    }
}
