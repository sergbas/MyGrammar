using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using System.IO;

namespace MyGrammar.Parser
{
    public class Parser
    {
        /// <summary>
        /// Parses the TSQL.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <param name="listener">The listener.</param>
        public void Parse(string input, IParseTreeListener listener)
        {
            ICharStream Stream = CharStreams.fromstring(input);
            //Stream = new CaseChangingCharStream(Stream);
            ITokenSource Lexer = new GrammarLexerLexer(Stream, TextWriter.Null, TextWriter.Null);
            ITokenStream Tokens = new CommonTokenStream(Lexer);
            GrammarRulesParser parser = new GrammarRulesParser(Tokens, TextWriter.Null, TextWriter.Null)
            {
                BuildParseTree = true
            };

            //IParseTree tree = Parser.rule_set();
            //ParseTreeWalker.Default.Walk(listener, tree);

            TreeBuilder treeBuilder = new TreeBuilder();
            parser.AddParseListener(treeBuilder);
            //parser.setErrorHandler(new ExceptionThrowingErrorHandler());

            parser.rule_set();

            treeBuilder.getRuleSet();
        }
    }
    /*
public class Compiler
{
   public RuleSet compile(String inputString)
   {
       ANTLRInputStream input = new ANTLRInputStream(inputString);
       RuleSetGrammarLexer lexer = new RuleSetGrammarLexer(input);
       TokenStream tokens = new CommonTokenStream(lexer);
       RuleSetGrammarParser parser = new RuleSetGrammarParser(tokens);

       TreeBuilder treeBuilder = new TreeBuilder();
       parser.addParseListener(treeBuilder);
       parser.setErrorHandler(new ExceptionThrowingErrorHandler());

       parser.rule_set();

       return treeBuilder.getRuleSet();
   }
}*/
}
