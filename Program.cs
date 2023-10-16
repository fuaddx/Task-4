namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 2
            /*int[] arr = { 2, 3, 6, 6 ,7};

            int count ;
            for (int i = 0; i < arr.Length; i++)
            {
                count = 1;
                if (arr[i] != 0)
                {
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        if (arr[i] == arr[j])
                        {
                            count++;
                            arr[j] = 0;
                        }
                    }

                    Console.WriteLine(arr[i] + " -> " + count +" dene ");
                }
            }*/

            // Task 3 
            /*Console.Write("Enter the size of the array: ");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[size];
            int elementCount = 0;
            bool AddElement = false;

            for (elementCount = 0; elementCount < size; elementCount++)
            {
                Console.Write("Do you want to add an element? (Yes/y or No/n): ");
                string response = Console.ReadLine();

                if (response != "Yes" && response != "yes" && response != "Y" && response != "y")
                {
                    break;
                }

                AddElement = true; 

                Console.Write("Enter an element: ");
                array[elementCount] = Convert.ToInt32(Console.ReadLine());
            }

            if (AddElement)
            {
                Console.WriteLine("Array elements:");

                for (int i = 0; i < elementCount; i++)
                {
                    Console.WriteLine(array[i]);
                }
            }*/
    }   }        
}