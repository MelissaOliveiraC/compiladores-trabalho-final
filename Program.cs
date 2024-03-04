using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using Interpreter.Lang;
using Interpreter.ProdyC; 
//using Grammar;

internal class Program
{
    private static void Main(string[] args)
    {
        // entrada de arquivo .ProdyC e Lexer      
        var inputStream = new AntlrFileStream("input.ProdyC");
        var lexer = new ProdyCLexer(inputStream);

        // instanciando de parser e tokens
        var tokenStream = new BufferedTokenStream(lexer);
        var parser = new ProdyCParser(tokenStream);

        // instanciando errorListener e fazendo as devidas operações
        var errorListener = new ProdyCErrorListener();
        parser.RemoveErrorListeners();
        parser.AddErrorListener(errorListener);
        parser.ErrorHandler = new DefaultErrorStrategy();

        // instanciando semanticListener
        var semanticListener = new SemanticProdyCListener();
        parser.RemoveParseListeners();
        parser.AddParseListener(semanticListener);

        //parser
        IParseTree? tree = null;
        try
        {
            tree = parser.prog();
            // sucesso do arquivo .ProdyC
            Console.WriteLine("Execução de código realizada com sucesso.");
            if (errorListener.HasErrors){
                Console.WriteLine("Erros!");
                errorListener.ErrorMessages.ForEach(e => Console.WriteLine(e));
                tree = null;
            }
            if (semanticListener.HasErrors){
                Console.WriteLine("Erros Semanticos.");
                semanticListener.ErrorMessages.ForEach(e => Console.WriteLine(e));
                tree = null;
            }
            
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }

        // executando o interpretador
        if (tree != null)
        {
            var interpreter = new ProdyCInterpreter(semanticListener.Functions);
            interpreter.Visit(tree);
        }

    }
}