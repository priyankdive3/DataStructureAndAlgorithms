using DataStructureandAlgorithm;

namespace DSA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select Programs\n 1.Binary search\n 2.Bubble sort\n 3.Anagram Detection\n 4.Check Prime Number\n 5.Check Number is Prime,palindrome or Anagram");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    BinarySearch binarysearch = new BinarySearch();
                    binarysearch.Search(@"E:\RFP\DataStructureAndAlgorithms\DSA\DSA\Words.txt");
                    break;
                case 2:
                    BubbleSort bubblesort = new BubbleSort();
                    bubblesort.Sort(@"E:\RFP\DataStructureAndAlgorithms\DSA\DSA\Words.txt");
                    break;
                case 3:
                    Anagram anagram = new Anagram();
                    anagram.AnagramCheck("heart", "earth");
                    break;
                case 4:
                    PrimeNumber prime = new PrimeNumber();
                    prime.Prime();
                    break;
                case 5:
                    PrimePalindromeAnagram primePalimdrome = new PrimePalindromeAnagram();
                    primePalimdrome.PrimeNumber();
                    primePalimdrome.Palindrome();
                    primePalimdrome.AnagramCheck();
                    break;
            }
        }
    }
}
