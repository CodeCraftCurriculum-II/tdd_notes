namespace TestFraemwork
{

    class TestFraemwork
    {
        // A generic Test function 
        public static void Test<T>(T expected, T actual, string description = "Test")
        {
            if (expected.Equals(actual)) // Note that we use the Equals method to compare the values not the == operator. 
            {
                Console.WriteLine($"🟢 {description}, expected {expected}, recived {actual}");
            }
            else
            {
                Console.WriteLine($"🔴 {description}, expected {expected}, recived {actual}");
            }
        }

        // Overloaded test functions 
        public static void Test(int expected, int actul, string description)
        {
            TestFraemwork.Test<int>(expected, actul, description);
        }

        public static void Test(string expected, string actul, string description)
        {
            TestFraemwork.Test<String>(expected, actul, description);
        }

    }
}