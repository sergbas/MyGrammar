grammar GrammarRules;
/* Grammar rules */

rule_set : single_rule* EOF ;

single_rule : IF condition THEN conclusion ( ELSE conclusion )? SEMI ;

condition : logical_expr ;
conclusion : IDENTIFIER ;

logical_expr
 : logical_expr AND logical_expr # LogicalExpressionAnd
 | logical_expr OR logical_expr  # LogicalExpressionOr
 | comparison_expr               # ComparisonExpression
 | LPAREN logical_expr RPAREN    # LogicalExpressionInParen
 | logical_entity                # LogicalEntity
 ;

comparison_expr : comparison_operand comp_operator comparison_operand
                    # ComparisonExpressionWithOperator
                | LPAREN comparison_expr RPAREN # ComparisonExpressionParens
                ;

comparison_operand : arithmetic_expr
                   ;

comp_operator : GT
              | GE
              | LT
              | LE
              | EQ
              ;

arithmetic_expr
 : arithmetic_expr MULT arithmetic_expr  # ArithmeticExpressionMult
 | arithmetic_expr DIV arithmetic_expr   # ArithmeticExpressionDiv
 | arithmetic_expr PLUS arithmetic_expr  # ArithmeticExpressionPlus
 | arithmetic_expr MINUS arithmetic_expr # ArithmeticExpressionMinus
 | MINUS arithmetic_expr                 # ArithmeticExpressionNegation
 | LPAREN arithmetic_expr RPAREN         # ArithmeticExpressionParens
 | numeric_entity                        # ArithmeticExpressionNumericEntity
 ;

logical_entity : (TRUE | FALSE) # LogicalConst
               | IDENTIFIER     # LogicalVariable
               ;

numeric_entity : DECIMAL              # NumericConst
               | IDENTIFIER           # NumericVariable
               ;