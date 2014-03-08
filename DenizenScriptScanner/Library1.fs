namespace DenizenScriptScanner

module Scanner =

    let PrepareLexer text =
        Lexing.LexBuffer<_>.FromString text

    let NextToken lexbuf =
        DenizenScriptLexer.tokenize lexbuf


    let keywords = 
        [ "time"; "chat"; "heal"; "narrate"; "zap"; "scribe"; "flag"; "foreach"; "if"; "remove" ]
        |>
        List.collect (fun x -> [ x; "^" + x])
        |>
        List.map (fun x -> (x, "KEYWORD"))
        |>
        Map.ofList
