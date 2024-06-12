namespace C_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var i = 0;
            //IF STATEMENT
            //if (i == 0)
            //{
            //    Console.WriteLine("It is equal");
            //} else if (i < 0) {
            //    Console.WriteLine("Less than 0");
            //}
            while (true) {

                Console.WriteLine("Enter a number: ");

                int userNum = Convert.ToInt32(Console.ReadLine());

                if (userNum == 0)
                {
                    return; //you can also use break
                } else if (userNum % 2 == 0)
                {
                    Console.WriteLine($"{userNum} is even");
                }
                else
                {
                    Console.WriteLine($"{userNum} is odd");
                }


            } 
            //Console.WriteLine("Enter a number: ");

            //int userNum = Convert.ToInt32(Console.ReadLine());
            
            //if (userNum == 0)
            //{
            //    return;
            //}

            //if (userNum % 2 == 0)
            //{
            //    Console.WriteLine($"{userNum} is even");
            //} else
            //{
            //    Console.WriteLine($"{userNum} is odd");
            //}


            //int[][] jaggedArray = new int[3][];
            //jaggedArray[0] = new int[] { 1, 2, 3 };
            //jaggedArray[1] = new int[] { 4, 5 };
            //jaggedArray[2] = new int[] { 6, 7, 8, 9 };

           
        }
    }
}
