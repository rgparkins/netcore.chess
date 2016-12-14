using NUnit.Framework;

namespace Saucar.Chess.Tests
{
    public class ExampleAttribute : TestFixtureAttribute
    {
        public ExampleAttribute(params object[] parameters)
            : base(parameters)
        {
        }
    }
}