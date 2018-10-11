grammar RuleSetGrammar;

/* Lexical rules */
 
IF   : 'if' ;
THEN : 'then';
 
AND : 'and' ;
OR  : 'or' ;
 
TRUE  : 'true' ;
FALSE : 'false' ;
 
MULT  : '*' ;
DIV   : '/' ;
PLUS  : '+' ;
MINUS : '-' ;
 
GT : '>' ;
GE : '>=' ;
LT : '<' ;
LE : '<=' ;
EQ : '=' ;
 
LPAREN : '(' ;
RPAREN : ')' ;
 
// DECIMAL, IDENTIFIER, COMMENTS, WS are set using regular expressions
 
DECIMAL : '-'?[0-9]+('.'[0-9]+)? ;
 
IDENTIFIER : [a-zA-Z_][a-zA-Z_0-9]* ;
 
SEMI : ';' ;
 
// COMMENT and WS are stripped from the output token stream by sending
// to a different channel 'skip'
 
COMMENT : '//' .+? ('\n'|EOF) -> skip ;
 
WS : [ \r\t\u000C\n]+ -> skip ;