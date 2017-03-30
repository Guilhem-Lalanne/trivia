using System;
using System.IO;
using ApprovalTests;
using ApprovalTests.Reporters;
using NUnit.Framework;

namespace Trivia.Tests
{
    [TestFixture]
    [UseReporter(typeof(DiffReporter))]
    public class GoldenMaster
    {
        [Test]
        public void ShouldNotChange()
        {
            // var est la déclartion du type qui suit
            var stringWriter = new StringWriter();

            // Svg du contenu de la console :
            var previousConsoleOut = Console.Out;
            Console.SetOut(stringWriter);
            GameRunner.Main(null);

            // reset de la sortie console
            Console.SetOut(previousConsoleOut);
            Approvals.Verify(stringWriter.ToString());
        }
    }
}
