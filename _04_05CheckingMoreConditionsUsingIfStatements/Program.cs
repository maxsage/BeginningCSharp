namespace _04_05CheckingMoreConditionsUsingIfStatements
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            IfStatements01();
            IfStatements02();
        }

        private static void IfStatements01()
        {
            int var1 = 10;
            
            if (var1 == 1)
            {
                // do something
            }
            else
            {
                if (var1 == 2)
                {
                    // do something else
                }
                else
                {
                    if (var1 == 3 || var1 == 4)
                    {
                        // do something else
                    }
                    else
                    {
                        // do something else
                    }
                }
            }
        }

        private static void IfStatements02()
        {
            int var1 = 10;

            if (var1 == 1)
            {
                // do something
            }
            else if (var1 == 2)
            {
                // do something else
            }
            else if (var1 == 3 || var1 == 4)
            {
                // do something else
            }
            else
            {
                // do something else
            }
        }
        
    }
}