using Microsoft.VisualStudio.Package;
using Microsoft.VisualStudio.TextManager.Interop;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YamlDotNet.Core.Tokens;

namespace Deloitte.DenizenScriptEditor
{
    class Scanner : IScanner
    {
        private IVsTextLines buffer;
        private Microsoft.FSharp.Text.Lexing.LexBuffer<char> _lexer;

        private bool _isInTag = false;
        private bool _isInComment = false;

        public Scanner(IVsTextLines buffer)
        {
            // TODO: Complete member initialization
            this.buffer = buffer;
        }

        public bool ScanTokenAndProvideInfoAboutIt(TokenInfo tokenInfo, ref int state)
        {
            var token = DenizenScriptScanner.Scanner.NextToken(_lexer);

            if (token.IsEOF)
                return false;

            if (!_isInTag && !_isInComment)
            {
                tokenInfo.Type = TokenType.Text;
                tokenInfo.Color = TokenColor.Text;
            }
            tokenInfo.StartIndex = _lexer.StartPos.AbsoluteOffset - 1;
            tokenInfo.EndIndex = _lexer.EndPos.AbsoluteOffset - 1;


            if (token.IsKEYWORD || token.IsINSTANTKEYWORD)
            {
                tokenInfo.Type = TokenType.Keyword;
                tokenInfo.Color = TokenColor.Number;
            }
            else if (token.IsCOMMENT)
            {
                _isInComment = true;
                tokenInfo.Type = TokenType.LineComment;
                tokenInfo.Color = TokenColor.Comment;
            }
            else if (token.IsIDENTIFIER)
            {
                tokenInfo.Type = TokenType.Operator;
                tokenInfo.Color = TokenColor.Keyword;
            }
            else if (token.IsLTAG)
            {
                _isInTag = true;
                tokenInfo.Type = TokenType.String;
                tokenInfo.Color = TokenColor.String;
            }
            else if (token.IsRTAG)
            {
                _isInTag = false;
            }

            return true;
        }

        public void SetSource(string source, int offset)
        {
            string text = source.Substring(offset);
            _lexer = DenizenScriptScanner.Scanner.PrepareLexer(text);
            _isInTag = false;
            _isInComment = false;
        }
    }
}
