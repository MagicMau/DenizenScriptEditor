// Implementation file for parser generated by fsyacc
module DenizenScriptParser
#nowarn "64";; // turn off warnings that type variables used in production annotations are instantiated to concrete type
open Microsoft.FSharp.Text.Lexing
open Microsoft.FSharp.Text.Parsing.ParseHelpers
# 1 "C:\Users\MElbers\documents\visual studio 2013\Projects\DenizenScriptEditor\DenizenScriptScanner\DenizenScriptParser.fsp"



# 10 "C:\Users\MElbers\documents\visual studio 2013\Projects\DenizenScriptEditor\DenizenScriptScanner\DenizenScriptParser.fs"
// This type is the type of tokens accepted by the parser
type token = 
  | EOF
  | COMMENT
  | IDENTIFIER of (string)
  | INSTANTKEYWORD of (string)
  | KEYWORD of (string)
  | DQUOTE
  | SQUOTE
  | LTAG
  | RTAG
  | LBRACKET
  | RBRACKET
  | FLOAT of (float)
  | INT of (int)
  | STRING of (string)
// This type is used to give symbolic names to token indexes, useful for error messages
type tokenId = 
    | TOKEN_EOF
    | TOKEN_COMMENT
    | TOKEN_IDENTIFIER
    | TOKEN_INSTANTKEYWORD
    | TOKEN_KEYWORD
    | TOKEN_DQUOTE
    | TOKEN_SQUOTE
    | TOKEN_LTAG
    | TOKEN_RTAG
    | TOKEN_LBRACKET
    | TOKEN_RBRACKET
    | TOKEN_FLOAT
    | TOKEN_INT
    | TOKEN_STRING
    | TOKEN_end_of_input
    | TOKEN_error
// This type is used to give symbolic names to token indexes, useful for error messages
type nonTerminalId = 
    | NONTERM__startstart
    | NONTERM_start

// This function maps tokens to integers indexes
let tagOfToken (t:token) = 
  match t with
  | EOF  -> 0 
  | COMMENT  -> 1 
  | IDENTIFIER _ -> 2 
  | INSTANTKEYWORD _ -> 3 
  | KEYWORD _ -> 4 
  | DQUOTE  -> 5 
  | SQUOTE  -> 6 
  | LTAG  -> 7 
  | RTAG  -> 8 
  | LBRACKET  -> 9 
  | RBRACKET  -> 10 
  | FLOAT _ -> 11 
  | INT _ -> 12 
  | STRING _ -> 13 

// This function maps integers indexes to symbolic token ids
let tokenTagToTokenId (tokenIdx:int) = 
  match tokenIdx with
  | 0 -> TOKEN_EOF 
  | 1 -> TOKEN_COMMENT 
  | 2 -> TOKEN_IDENTIFIER 
  | 3 -> TOKEN_INSTANTKEYWORD 
  | 4 -> TOKEN_KEYWORD 
  | 5 -> TOKEN_DQUOTE 
  | 6 -> TOKEN_SQUOTE 
  | 7 -> TOKEN_LTAG 
  | 8 -> TOKEN_RTAG 
  | 9 -> TOKEN_LBRACKET 
  | 10 -> TOKEN_RBRACKET 
  | 11 -> TOKEN_FLOAT 
  | 12 -> TOKEN_INT 
  | 13 -> TOKEN_STRING 
  | 16 -> TOKEN_end_of_input
  | 14 -> TOKEN_error
  | _ -> failwith "tokenTagToTokenId: bad token"

/// This function maps production indexes returned in syntax errors to strings representing the non terminal that would be produced by that production
let prodIdxToNonTerminal (prodIdx:int) = 
  match prodIdx with
    | 0 -> NONTERM__startstart 
    | 1 -> NONTERM_start 
    | _ -> failwith "prodIdxToNonTerminal: bad production index"

let _fsyacc_endOfInputTag = 16 
let _fsyacc_tagOfErrorTerminal = 14

// This function gets the name of a token as a string
let token_to_string (t:token) = 
  match t with 
  | EOF  -> "EOF" 
  | COMMENT  -> "COMMENT" 
  | IDENTIFIER _ -> "IDENTIFIER" 
  | INSTANTKEYWORD _ -> "INSTANTKEYWORD" 
  | KEYWORD _ -> "KEYWORD" 
  | DQUOTE  -> "DQUOTE" 
  | SQUOTE  -> "SQUOTE" 
  | LTAG  -> "LTAG" 
  | RTAG  -> "RTAG" 
  | LBRACKET  -> "LBRACKET" 
  | RBRACKET  -> "RBRACKET" 
  | FLOAT _ -> "FLOAT" 
  | INT _ -> "INT" 
  | STRING _ -> "STRING" 

// This function gets the data carried by a token as an object
let _fsyacc_dataOfToken (t:token) = 
  match t with 
  | EOF  -> (null : System.Object) 
  | COMMENT  -> (null : System.Object) 
  | IDENTIFIER _fsyacc_x -> Microsoft.FSharp.Core.Operators.box _fsyacc_x 
  | INSTANTKEYWORD _fsyacc_x -> Microsoft.FSharp.Core.Operators.box _fsyacc_x 
  | KEYWORD _fsyacc_x -> Microsoft.FSharp.Core.Operators.box _fsyacc_x 
  | DQUOTE  -> (null : System.Object) 
  | SQUOTE  -> (null : System.Object) 
  | LTAG  -> (null : System.Object) 
  | RTAG  -> (null : System.Object) 
  | LBRACKET  -> (null : System.Object) 
  | RBRACKET  -> (null : System.Object) 
  | FLOAT _fsyacc_x -> Microsoft.FSharp.Core.Operators.box _fsyacc_x 
  | INT _fsyacc_x -> Microsoft.FSharp.Core.Operators.box _fsyacc_x 
  | STRING _fsyacc_x -> Microsoft.FSharp.Core.Operators.box _fsyacc_x 
let _fsyacc_gotos = [| 0us; 65535us; 1us; 65535us; 0us; 1us; |]
let _fsyacc_sparseGotoTableRowOffsets = [|0us; 1us; |]
let _fsyacc_stateToProdIdxsTableElements = [| 1us; 0us; 1us; 0us; |]
let _fsyacc_stateToProdIdxsTableRowOffsets = [|0us; 2us; |]
let _fsyacc_action_rows = 2
let _fsyacc_actionTableElements = [|0us; 16385us; 0us; 49152us; |]
let _fsyacc_actionTableRowOffsets = [|0us; 1us; |]
let _fsyacc_reductionSymbolCounts = [|1us; 0us; |]
let _fsyacc_productionToNonTerminalTable = [|0us; 1us; |]
let _fsyacc_immediateActions = [|65535us; 49152us; |]
let _fsyacc_reductions ()  =    [| 
# 145 "C:\Users\MElbers\documents\visual studio 2013\Projects\DenizenScriptEditor\DenizenScriptScanner\DenizenScriptParser.fs"
        (fun (parseState : Microsoft.FSharp.Text.Parsing.IParseState) ->
            let _1 = (let data = parseState.GetInput(1) in (Microsoft.FSharp.Core.Operators.unbox data : string)) in
            Microsoft.FSharp.Core.Operators.box
                (
                   (
                      raise (Microsoft.FSharp.Text.Parsing.Accept(Microsoft.FSharp.Core.Operators.box _1))
                   )
                 : '_startstart));
# 154 "C:\Users\MElbers\documents\visual studio 2013\Projects\DenizenScriptEditor\DenizenScriptScanner\DenizenScriptParser.fs"
        (fun (parseState : Microsoft.FSharp.Text.Parsing.IParseState) ->
            Microsoft.FSharp.Core.Operators.box
                (
                   (
# 22 "C:\Users\MElbers\documents\visual studio 2013\Projects\DenizenScriptEditor\DenizenScriptScanner\DenizenScriptParser.fsp"
                          "Nothing to see here" 
                   )
# 22 "C:\Users\MElbers\documents\visual studio 2013\Projects\DenizenScriptEditor\DenizenScriptScanner\DenizenScriptParser.fsp"
                 : string));
|]
# 165 "C:\Users\MElbers\documents\visual studio 2013\Projects\DenizenScriptEditor\DenizenScriptScanner\DenizenScriptParser.fs"
let tables () : Microsoft.FSharp.Text.Parsing.Tables<_> = 
  { reductions= _fsyacc_reductions ();
    endOfInputTag = _fsyacc_endOfInputTag;
    tagOfToken = tagOfToken;
    dataOfToken = _fsyacc_dataOfToken; 
    actionTableElements = _fsyacc_actionTableElements;
    actionTableRowOffsets = _fsyacc_actionTableRowOffsets;
    stateToProdIdxsTableElements = _fsyacc_stateToProdIdxsTableElements;
    stateToProdIdxsTableRowOffsets = _fsyacc_stateToProdIdxsTableRowOffsets;
    reductionSymbolCounts = _fsyacc_reductionSymbolCounts;
    immediateActions = _fsyacc_immediateActions;
    gotos = _fsyacc_gotos;
    sparseGotoTableRowOffsets = _fsyacc_sparseGotoTableRowOffsets;
    tagOfErrorTerminal = _fsyacc_tagOfErrorTerminal;
    parseError = (fun (ctxt:Microsoft.FSharp.Text.Parsing.ParseErrorContext<_>) -> 
                              match parse_error_rich with 
                              | Some f -> f ctxt
                              | None -> parse_error ctxt.Message);
    numTerminals = 17;
    productionToNonTerminalTable = _fsyacc_productionToNonTerminalTable  }
let engine lexer lexbuf startState = (tables ()).Interpret(lexer, lexbuf, startState)
let start lexer lexbuf : string =
    Microsoft.FSharp.Core.Operators.unbox ((tables ()).Interpret(lexer, lexbuf, 0))
