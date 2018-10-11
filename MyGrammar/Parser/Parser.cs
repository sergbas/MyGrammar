using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using System.IO;

namespace MyGrammar.Parser
{
    public static class Parser
    {
        /// <summary>
        /// Parses the TSQL.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <param name="listener">The listener.</param>
        public static void Parse(string input, IParseTreeListener listener)
        {
            ICharStream Stream = CharStreams.fromstring(input);
            //Stream = new CaseChangingCharStream(Stream);
            ITokenSource Lexer = new GrammarLexerLexer(Stream, TextWriter.Null, TextWriter.Null);
            ITokenStream Tokens = new CommonTokenStream(Lexer);
            GrammarRulesParser Parser = new GrammarRulesParser(Tokens, TextWriter.Null, TextWriter.Null)
            {
                BuildParseTree = true
            };
            IParseTree tree = Parser.rule_set();
            ParseTreeWalker.Default.Walk(listener, tree);
        }
    }
}
