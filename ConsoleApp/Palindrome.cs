public class Palindrome
{
    string input = "mom";
    string reverse = "";

    public void IsPalindrome()
    {
        for (int i = input.Length; i > 0; i--)
        {
            reverse += input[i - 1];
        }

        if (input == reverse)
        {
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine(false);
        }
    }
}
