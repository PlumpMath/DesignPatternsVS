﻿using System;
using System.Collections.Generic;

namespace InterpreterRealWorld
{
    internal static class Program
    {
        private static void Main()
        {
            const string roman = "MCMXXVIII";
            var context = new Context(roman);

            // Build the 'parse tree'
            var tree = new List<Expression>
            {
                new ThousandExpression(),
                new HundredExpression(),
                new TenExpression(),
                new OneExpression()
            };

            // Interpret
            foreach (var exp in tree)
            {
                exp.Interpret(context);
            }

            Console.WriteLine("{0} = {1}",
              roman, context.Output);

            // Wait for user
            Console.ReadKey();
        }
    }

    /// <summary>
    /// The 'Context' class
    /// </summary>
    internal class Context
    {
        private string _input;
        private int _output;

        // Constructor
        public Context(string input)
        {
            _input = input;
        }

        // Gets or sets input
        public string Input
        {
            get { return _input; }
            set { _input = value; }
        }

        // Gets or sets output
        public int Output
        {
            get { return _output; }
            set { _output = value; }
        }
    }

    /// <summary>
    /// The 'AbstractExpression' class
    /// </summary>
    internal abstract class Expression
    {
        public void Interpret(Context context)
        {
            if (context.Input.Length == 0)
                return;

            if (context.Input.StartsWith(Nine()))
            {
                context.Output += (9 * Multiplier());
                context.Input = context.Input.Substring(2);
            }
            else if (context.Input.StartsWith(Four()))
            {
                context.Output += (4 * Multiplier());
                context.Input = context.Input.Substring(2);
            }
            else if (context.Input.StartsWith(Five()))
            {
                context.Output += (5 * Multiplier());
                context.Input = context.Input.Substring(1);
            }

            while (context.Input.StartsWith(One()))
            {
                context.Output += (1 * Multiplier());
                context.Input = context.Input.Substring(1);
            }
        }

        public abstract string One();
        public abstract string Four();
        public abstract string Five();
        public abstract string Nine();
        protected abstract int Multiplier();
    }

    /// <summary>
    /// A 'TerminalExpression' class
    /// <remarks>
    /// Thousand checks for the Roman Numeral M 
    /// </remarks>
    /// </summary>
    internal class ThousandExpression : Expression
    {
        public override string One() { return "M"; }
        public override string Four() { return " "; }
        public override string Five() { return " "; }
        public override string Nine() { return " "; }
        protected override int Multiplier() { return 1000; }
    }

    /// <summary>
    /// A 'TerminalExpression' class
    /// <remarks>
    /// Hundred checks C, CD, D or CM
    /// </remarks>
    /// </summary>
    internal class HundredExpression : Expression
    {
        public override string One() { return "C"; }
        public override string Four() { return "CD"; }
        public override string Five() { return "D"; }
        public override string Nine() { return "CM"; }
        protected override int Multiplier() { return 100; }
    }

    /// <summary>
    /// A 'TerminalExpression' class
    /// <remarks>
    /// Ten checks for X, XL, L and XC
    /// </remarks>
    /// </summary>
    internal class TenExpression : Expression
    {
        public override string One() { return "X"; }
        public override string Four() { return "XL"; }
        public override string Five() { return "L"; }
        public override string Nine() { return "XC"; }
        protected override int Multiplier() { return 10; }
    }

    /// <summary>
    /// A 'TerminalExpression' class
    /// <remarks>
    /// One checks for I, II, III, IV, V, VI, VI, VII, VIII, IX
    /// </remarks>
    /// </summary>
    internal class OneExpression : Expression
    {
        public override string One() { return "I"; }
        public override string Four() { return "IV"; }
        public override string Five() { return "V"; }
        public override string Nine() { return "IX"; }
        protected override int Multiplier() { return 1; }
    }
}
