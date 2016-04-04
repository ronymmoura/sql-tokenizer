using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace SqlTokenizer.Tests
{
    [TestClass]
    public class MainTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Tokenizer_CanGenerateTokens_ArgumentNullExceptionThrown()
        {
            var tokenizer = new Tokenizer(null);
            var tokens = tokenizer.GetTokens();
        }

        [TestMethod]
        public void Tokenizer_CanGenerateTokens_Generated()
        {
            var tokenizer = new Tokenizer("");
            var tokens = tokenizer.GetTokens();

            Assert.AreEqual(0, tokens.Count);
        }

        [TestMethod]
        public void Tokenizer_CanGenerateSelectTokens_Generated()
        {
            var tokenizer = new Tokenizer("SELECT * FROM TEST");
            var tokens = tokenizer.GetTokens();

            Assert.AreEqual(4, tokens.Count);
        }

        [TestMethod]
        public void Tokenizer_CanGenerateSelectTokensWithVariables_Generated()
        {
            var tokenizer = new Tokenizer("SELECT * FROM TEST WHERE ID = @ID");
            var tokens = tokenizer.GetTokens();

            Assert.AreEqual(8, tokens.Count);

            var contains = tokens.Contains(TokenType.Variable, "@ID");

            Assert.AreEqual(true, contains);
        }
    }
}
