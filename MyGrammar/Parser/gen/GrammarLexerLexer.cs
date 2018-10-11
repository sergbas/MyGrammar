//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.7
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:/Projects/MyGrammar/MyGrammar\GrammarLexer.g4 by ANTLR 4.7

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7")]
[System.CLSCompliant(false)]
public partial class GrammarLexerLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		IF=1, THEN=2, ELSE=3, AND=4, OR=5, TRUE=6, FALSE=7, MULT=8, DIV=9, PLUS=10, 
		MINUS=11, GT=12, GE=13, LT=14, LE=15, EQ=16, LPAREN=17, RPAREN=18, DECIMAL=19, 
		IDENTIFIER=20, SEMI=21, COMMENT=22, WS=23;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"IF", "THEN", "ELSE", "AND", "OR", "TRUE", "FALSE", "MULT", "DIV", "PLUS", 
		"MINUS", "GT", "GE", "LT", "LE", "EQ", "LPAREN", "RPAREN", "DECIMAL", 
		"IDENTIFIER", "SEMI", "COMMENT", "WS"
	};


	public GrammarLexerLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public GrammarLexerLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, "'if'", "'then'", "'else'", "'and'", "'or'", "'true'", "'false'", 
		"'*'", "'/'", "'+'", "'-'", "'>'", "'>='", "'<'", "'<='", "'='", "'('", 
		"')'", null, null, "';'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "IF", "THEN", "ELSE", "AND", "OR", "TRUE", "FALSE", "MULT", "DIV", 
		"PLUS", "MINUS", "GT", "GE", "LT", "LE", "EQ", "LPAREN", "RPAREN", "DECIMAL", 
		"IDENTIFIER", "SEMI", "COMMENT", "WS"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "GrammarLexer.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static GrammarLexerLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x2', '\x19', '\x95', '\b', '\x1', '\x4', '\x2', '\t', '\x2', 
		'\x4', '\x3', '\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', 
		'\x5', '\x4', '\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x4', '\b', 
		'\t', '\b', '\x4', '\t', '\t', '\t', '\x4', '\n', '\t', '\n', '\x4', '\v', 
		'\t', '\v', '\x4', '\f', '\t', '\f', '\x4', '\r', '\t', '\r', '\x4', '\xE', 
		'\t', '\xE', '\x4', '\xF', '\t', '\xF', '\x4', '\x10', '\t', '\x10', '\x4', 
		'\x11', '\t', '\x11', '\x4', '\x12', '\t', '\x12', '\x4', '\x13', '\t', 
		'\x13', '\x4', '\x14', '\t', '\x14', '\x4', '\x15', '\t', '\x15', '\x4', 
		'\x16', '\t', '\x16', '\x4', '\x17', '\t', '\x17', '\x4', '\x18', '\t', 
		'\x18', '\x3', '\x2', '\x3', '\x2', '\x3', '\x2', '\x3', '\x3', '\x3', 
		'\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x4', '\x3', 
		'\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x5', '\x3', 
		'\x5', '\x3', '\x5', '\x3', '\x5', '\x3', '\x6', '\x3', '\x6', '\x3', 
		'\x6', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', 
		'\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', 
		'\b', '\x3', '\t', '\x3', '\t', '\x3', '\n', '\x3', '\n', '\x3', '\v', 
		'\x3', '\v', '\x3', '\f', '\x3', '\f', '\x3', '\r', '\x3', '\r', '\x3', 
		'\xE', '\x3', '\xE', '\x3', '\xE', '\x3', '\xF', '\x3', '\xF', '\x3', 
		'\x10', '\x3', '\x10', '\x3', '\x10', '\x3', '\x11', '\x3', '\x11', '\x3', 
		'\x12', '\x3', '\x12', '\x3', '\x13', '\x3', '\x13', '\x3', '\x14', '\x5', 
		'\x14', 'j', '\n', '\x14', '\x3', '\x14', '\x6', '\x14', 'm', '\n', '\x14', 
		'\r', '\x14', '\xE', '\x14', 'n', '\x3', '\x14', '\x3', '\x14', '\x6', 
		'\x14', 's', '\n', '\x14', '\r', '\x14', '\xE', '\x14', 't', '\x5', '\x14', 
		'w', '\n', '\x14', '\x3', '\x15', '\x3', '\x15', '\a', '\x15', '{', '\n', 
		'\x15', '\f', '\x15', '\xE', '\x15', '~', '\v', '\x15', '\x3', '\x16', 
		'\x3', '\x16', '\x3', '\x17', '\x3', '\x17', '\x3', '\x17', '\x3', '\x17', 
		'\x6', '\x17', '\x86', '\n', '\x17', '\r', '\x17', '\xE', '\x17', '\x87', 
		'\x3', '\x17', '\x5', '\x17', '\x8B', '\n', '\x17', '\x3', '\x17', '\x3', 
		'\x17', '\x3', '\x18', '\x6', '\x18', '\x90', '\n', '\x18', '\r', '\x18', 
		'\xE', '\x18', '\x91', '\x3', '\x18', '\x3', '\x18', '\x3', '\x87', '\x2', 
		'\x19', '\x3', '\x3', '\x5', '\x4', '\a', '\x5', '\t', '\x6', '\v', '\a', 
		'\r', '\b', '\xF', '\t', '\x11', '\n', '\x13', '\v', '\x15', '\f', '\x17', 
		'\r', '\x19', '\xE', '\x1B', '\xF', '\x1D', '\x10', '\x1F', '\x11', '!', 
		'\x12', '#', '\x13', '%', '\x14', '\'', '\x15', ')', '\x16', '+', '\x17', 
		'-', '\x18', '/', '\x19', '\x3', '\x2', '\a', '\x3', '\x2', '\x32', ';', 
		'\x5', '\x2', '\x43', '\\', '\x61', '\x61', '\x63', '|', '\x6', '\x2', 
		'\x32', ';', '\x43', '\\', '\x61', '\x61', '\x63', '|', '\x3', '\x3', 
		'\f', '\f', '\x5', '\x2', '\v', '\f', '\xE', '\xF', '\"', '\"', '\x2', 
		'\x9B', '\x2', '\x3', '\x3', '\x2', '\x2', '\x2', '\x2', '\x5', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\a', '\x3', '\x2', '\x2', '\x2', '\x2', '\t', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\v', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\r', '\x3', '\x2', '\x2', '\x2', '\x2', '\xF', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\x11', '\x3', '\x2', '\x2', '\x2', '\x2', '\x13', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\x15', '\x3', '\x2', '\x2', '\x2', '\x2', '\x17', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\x19', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\x1B', '\x3', '\x2', '\x2', '\x2', '\x2', '\x1D', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\x1F', '\x3', '\x2', '\x2', '\x2', '\x2', '!', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '#', '\x3', '\x2', '\x2', '\x2', '\x2', '%', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\'', '\x3', '\x2', '\x2', '\x2', '\x2', 
		')', '\x3', '\x2', '\x2', '\x2', '\x2', '+', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '-', '\x3', '\x2', '\x2', '\x2', '\x2', '/', '\x3', '\x2', '\x2', 
		'\x2', '\x3', '\x31', '\x3', '\x2', '\x2', '\x2', '\x5', '\x34', '\x3', 
		'\x2', '\x2', '\x2', '\a', '\x39', '\x3', '\x2', '\x2', '\x2', '\t', '>', 
		'\x3', '\x2', '\x2', '\x2', '\v', '\x42', '\x3', '\x2', '\x2', '\x2', 
		'\r', '\x45', '\x3', '\x2', '\x2', '\x2', '\xF', 'J', '\x3', '\x2', '\x2', 
		'\x2', '\x11', 'P', '\x3', '\x2', '\x2', '\x2', '\x13', 'R', '\x3', '\x2', 
		'\x2', '\x2', '\x15', 'T', '\x3', '\x2', '\x2', '\x2', '\x17', 'V', '\x3', 
		'\x2', '\x2', '\x2', '\x19', 'X', '\x3', '\x2', '\x2', '\x2', '\x1B', 
		'Z', '\x3', '\x2', '\x2', '\x2', '\x1D', ']', '\x3', '\x2', '\x2', '\x2', 
		'\x1F', '_', '\x3', '\x2', '\x2', '\x2', '!', '\x62', '\x3', '\x2', '\x2', 
		'\x2', '#', '\x64', '\x3', '\x2', '\x2', '\x2', '%', '\x66', '\x3', '\x2', 
		'\x2', '\x2', '\'', 'i', '\x3', '\x2', '\x2', '\x2', ')', 'x', '\x3', 
		'\x2', '\x2', '\x2', '+', '\x7F', '\x3', '\x2', '\x2', '\x2', '-', '\x81', 
		'\x3', '\x2', '\x2', '\x2', '/', '\x8F', '\x3', '\x2', '\x2', '\x2', '\x31', 
		'\x32', '\a', 'k', '\x2', '\x2', '\x32', '\x33', '\a', 'h', '\x2', '\x2', 
		'\x33', '\x4', '\x3', '\x2', '\x2', '\x2', '\x34', '\x35', '\a', 'v', 
		'\x2', '\x2', '\x35', '\x36', '\a', 'j', '\x2', '\x2', '\x36', '\x37', 
		'\a', 'g', '\x2', '\x2', '\x37', '\x38', '\a', 'p', '\x2', '\x2', '\x38', 
		'\x6', '\x3', '\x2', '\x2', '\x2', '\x39', ':', '\a', 'g', '\x2', '\x2', 
		':', ';', '\a', 'n', '\x2', '\x2', ';', '<', '\a', 'u', '\x2', '\x2', 
		'<', '=', '\a', 'g', '\x2', '\x2', '=', '\b', '\x3', '\x2', '\x2', '\x2', 
		'>', '?', '\a', '\x63', '\x2', '\x2', '?', '@', '\a', 'p', '\x2', '\x2', 
		'@', '\x41', '\a', '\x66', '\x2', '\x2', '\x41', '\n', '\x3', '\x2', '\x2', 
		'\x2', '\x42', '\x43', '\a', 'q', '\x2', '\x2', '\x43', '\x44', '\a', 
		't', '\x2', '\x2', '\x44', '\f', '\x3', '\x2', '\x2', '\x2', '\x45', '\x46', 
		'\a', 'v', '\x2', '\x2', '\x46', 'G', '\a', 't', '\x2', '\x2', 'G', 'H', 
		'\a', 'w', '\x2', '\x2', 'H', 'I', '\a', 'g', '\x2', '\x2', 'I', '\xE', 
		'\x3', '\x2', '\x2', '\x2', 'J', 'K', '\a', 'h', '\x2', '\x2', 'K', 'L', 
		'\a', '\x63', '\x2', '\x2', 'L', 'M', '\a', 'n', '\x2', '\x2', 'M', 'N', 
		'\a', 'u', '\x2', '\x2', 'N', 'O', '\a', 'g', '\x2', '\x2', 'O', '\x10', 
		'\x3', '\x2', '\x2', '\x2', 'P', 'Q', '\a', ',', '\x2', '\x2', 'Q', '\x12', 
		'\x3', '\x2', '\x2', '\x2', 'R', 'S', '\a', '\x31', '\x2', '\x2', 'S', 
		'\x14', '\x3', '\x2', '\x2', '\x2', 'T', 'U', '\a', '-', '\x2', '\x2', 
		'U', '\x16', '\x3', '\x2', '\x2', '\x2', 'V', 'W', '\a', '/', '\x2', '\x2', 
		'W', '\x18', '\x3', '\x2', '\x2', '\x2', 'X', 'Y', '\a', '@', '\x2', '\x2', 
		'Y', '\x1A', '\x3', '\x2', '\x2', '\x2', 'Z', '[', '\a', '@', '\x2', '\x2', 
		'[', '\\', '\a', '?', '\x2', '\x2', '\\', '\x1C', '\x3', '\x2', '\x2', 
		'\x2', ']', '^', '\a', '>', '\x2', '\x2', '^', '\x1E', '\x3', '\x2', '\x2', 
		'\x2', '_', '`', '\a', '>', '\x2', '\x2', '`', '\x61', '\a', '?', '\x2', 
		'\x2', '\x61', ' ', '\x3', '\x2', '\x2', '\x2', '\x62', '\x63', '\a', 
		'?', '\x2', '\x2', '\x63', '\"', '\x3', '\x2', '\x2', '\x2', '\x64', '\x65', 
		'\a', '*', '\x2', '\x2', '\x65', '$', '\x3', '\x2', '\x2', '\x2', '\x66', 
		'g', '\a', '+', '\x2', '\x2', 'g', '&', '\x3', '\x2', '\x2', '\x2', 'h', 
		'j', '\a', '/', '\x2', '\x2', 'i', 'h', '\x3', '\x2', '\x2', '\x2', 'i', 
		'j', '\x3', '\x2', '\x2', '\x2', 'j', 'l', '\x3', '\x2', '\x2', '\x2', 
		'k', 'm', '\t', '\x2', '\x2', '\x2', 'l', 'k', '\x3', '\x2', '\x2', '\x2', 
		'm', 'n', '\x3', '\x2', '\x2', '\x2', 'n', 'l', '\x3', '\x2', '\x2', '\x2', 
		'n', 'o', '\x3', '\x2', '\x2', '\x2', 'o', 'v', '\x3', '\x2', '\x2', '\x2', 
		'p', 'r', '\a', '\x30', '\x2', '\x2', 'q', 's', '\t', '\x2', '\x2', '\x2', 
		'r', 'q', '\x3', '\x2', '\x2', '\x2', 's', 't', '\x3', '\x2', '\x2', '\x2', 
		't', 'r', '\x3', '\x2', '\x2', '\x2', 't', 'u', '\x3', '\x2', '\x2', '\x2', 
		'u', 'w', '\x3', '\x2', '\x2', '\x2', 'v', 'p', '\x3', '\x2', '\x2', '\x2', 
		'v', 'w', '\x3', '\x2', '\x2', '\x2', 'w', '(', '\x3', '\x2', '\x2', '\x2', 
		'x', '|', '\t', '\x3', '\x2', '\x2', 'y', '{', '\t', '\x4', '\x2', '\x2', 
		'z', 'y', '\x3', '\x2', '\x2', '\x2', '{', '~', '\x3', '\x2', '\x2', '\x2', 
		'|', 'z', '\x3', '\x2', '\x2', '\x2', '|', '}', '\x3', '\x2', '\x2', '\x2', 
		'}', '*', '\x3', '\x2', '\x2', '\x2', '~', '|', '\x3', '\x2', '\x2', '\x2', 
		'\x7F', '\x80', '\a', '=', '\x2', '\x2', '\x80', ',', '\x3', '\x2', '\x2', 
		'\x2', '\x81', '\x82', '\a', '\x31', '\x2', '\x2', '\x82', '\x83', '\a', 
		'\x31', '\x2', '\x2', '\x83', '\x85', '\x3', '\x2', '\x2', '\x2', '\x84', 
		'\x86', '\v', '\x2', '\x2', '\x2', '\x85', '\x84', '\x3', '\x2', '\x2', 
		'\x2', '\x86', '\x87', '\x3', '\x2', '\x2', '\x2', '\x87', '\x88', '\x3', 
		'\x2', '\x2', '\x2', '\x87', '\x85', '\x3', '\x2', '\x2', '\x2', '\x88', 
		'\x8A', '\x3', '\x2', '\x2', '\x2', '\x89', '\x8B', '\t', '\x5', '\x2', 
		'\x2', '\x8A', '\x89', '\x3', '\x2', '\x2', '\x2', '\x8B', '\x8C', '\x3', 
		'\x2', '\x2', '\x2', '\x8C', '\x8D', '\b', '\x17', '\x2', '\x2', '\x8D', 
		'.', '\x3', '\x2', '\x2', '\x2', '\x8E', '\x90', '\t', '\x6', '\x2', '\x2', 
		'\x8F', '\x8E', '\x3', '\x2', '\x2', '\x2', '\x90', '\x91', '\x3', '\x2', 
		'\x2', '\x2', '\x91', '\x8F', '\x3', '\x2', '\x2', '\x2', '\x91', '\x92', 
		'\x3', '\x2', '\x2', '\x2', '\x92', '\x93', '\x3', '\x2', '\x2', '\x2', 
		'\x93', '\x94', '\b', '\x18', '\x2', '\x2', '\x94', '\x30', '\x3', '\x2', 
		'\x2', '\x2', '\v', '\x2', 'i', 'n', 't', 'v', '|', '\x87', '\x8A', '\x91', 
		'\x3', '\b', '\x2', '\x2',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}