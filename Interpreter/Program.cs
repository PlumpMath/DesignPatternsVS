using System;
using System.Collections;

namespace Interpreter
{
    internal static class Program
    {
        private static void Main()
        {
            var context = new Context();

            // Usually a tree 
            var list = new ArrayList
            {
                new TerminalExpression(),
                new NonterminalExpression(),
                new TerminalExpression(),
                new TerminalExpression()
            };

            // Populate 'abstract syntax tree' 

            // Interpret
            foreach (AbstractExpression exp in list)
            {
                exp.Interpret(context);
            }

            // Wait for user
            Console.ReadKey();
        }
    }
    /// <summary>
    /// The 'Context' class
    /// </summary>
    internal class Context
    {
    }

    /// <summary>
    /// The 'AbstractExpression' abstract class
    /// </summary>
    internal abstract class AbstractExpression
    {
        public abstract void Interpret(Context context);
    }

    /// <summary>
    /// The 'TerminalExpression' class
    /// </summary>
    internal class TerminalExpression : AbstractExpression
    {
        public override void Interpret(Context context)
        {
            Console.WriteLine("Called Terminal.Interpret()");
        }
    }

    /// <summary>
    /// The 'NonterminalExpression' class
    /// </summary>
    internal class NonterminalExpression : AbstractExpression
    {
        public override void Interpret(Context context)
        {
            Console.WriteLine("Called Nonterminal.Interpret()");
        }
    }
}
