using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("demo_test_private_method.UnitTests")]
namespace demo_test_private_method
{
    public class ClassWithPrivateMethods: IComplexOperations
    {
        protected internal int _doSum(int a, int b)
        {
            return a + b;
        }

        protected internal int _doMultiply(int a, int b)
        {
            return a * b;
        }
        
        public bool ComplexOperations(int a, int b)
        {
            return _doMultiply(a, b) >= _doSum(a, b);
        }

        public bool ComplexOperationsFiveAndTen()
        {
            return ComplexOperations(5, 10);
        }
    }
}