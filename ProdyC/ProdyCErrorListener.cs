using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Antlr4.Runtime;

namespace Interpreter.ProdyC
{
    public class ProdyCErrorListener : BaseErrorListener
    {
        public Boolean HasErrors { get; private set; } = false;
        public List<string> ErrorMessages  { get; private set; } = new List<string>();
        public override void SyntaxError(TextWriter output, 
                                        IRecognizer recognizer, IToken offendingSymbol, 
                                        int line, int charPositionInLine, 
                                        string msg, RecognitionException e)
        {
            HasErrors = true;
            ErrorMessages.Add($"Erro de sintaxe na linha {line}, posição {charPositionInLine}: {msg}");
        }
    }
}