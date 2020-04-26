namespace demo_test_private_method
{
    public class AnotherClass
    {
        public static void TestClass()
        {
            //Internal Methods available here.
            var cwpm = new ClassWithPrivateMethods();
            cwpm._doMultiply(1, 2);
        }
        
        public static void TestInterface()
        {
            //Only interface methods available here.
            IComplexOperations cwpm = new ClassWithPrivateMethods();
            cwpm.ComplexOperationsFiveAndTen();
        }
    }
}