using System;

namespace Training.CSharp7
{
    class Program
    {
        static void Main(string[] args)
        {
            var logger = new Logger();

            logger.Write("\n****OUT VARIABLES****");
            var outVariables = new OutVariables(logger);
            outVariables.ParseInt("sdf");
            outVariables.GetValue("key3");

            //logger.Write("\n****NUMERIC LITERALS****");
            //var numericLiterals = new NumericLiterals(logger);
            //numericLiterals.Sum();

            //logger.Write("\n****PATTERN MATCHING****");
            //var patternMatching = new PatternMatching(logger);
            //patternMatching.ParseInt("s");
            //patternMatching.JoinString(", ", "value1", new[] { "val", "ue2" }, new string[0], null);

            //logger.Write("\n****LOCAL FUNCTIONS****");
            //var localFunctions = new LocalFunctions(logger);
            //localFunctions.GetFibonacciSequence(120000);
            //localFunctions.FindClosestFibonacciNumber(120000);

            //logger.Write("\n****EXPRESSION-BODIED MEMBERS****");
            //var expressionBodiedMembers = new ExpressionBodiedMembers(logger);
            //expressionBodiedMembers.Logger.Write("ExpressionBodiedMembers: writing to his logger.");

            //logger.Write("\n****REF LOCALS AND RETURN****");
            //var refLocalsAndReturn = new RefLocalsAndReturn(logger);
            //var values = new[] { "cy", "ber", "com" };
            //refLocalsAndReturn.Replace(values, v => v == "com", "king");

            //logger.Write("\n****REF SEMANTICS****");
            //var refSemantics = new RefSemantics(logger);
            //refSemantics.SumAreas(refSemantics.Rectangle, refSemantics.Rectangle);


            //logger.Write("\n****VALUE TUPLES****");
            //var valueTuple = new ValueTuples(logger);
            //valueTuple.GetFibonacciSquaresArea(10);
            //valueTuple.GetFibonacciSquareAreaById(12);

            //logger.Write("\n****VALUE TASKS****");
            //var valueTasks = new ValueTasks(logger);
            //valueTasks.GetValues().GetAwaiter().GetResult();
            //valueTasks.GetValues().GetAwaiter().GetResult();

            //logger.Write("\n****STRING AS SPAN****");
            //var stringAsSpan = new StringAsSpan(logger);
            //var s = "string value which need to be take care of";
            //stringAsSpan.IsNullOrEmpty(s);
            //stringAsSpan.ToUpper(s);

            Console.ReadKey();
        }
    }
}
