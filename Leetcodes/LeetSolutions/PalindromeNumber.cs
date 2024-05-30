namespace Leetcodes.LeetSolutions
{
    public class PalindromeNumber
    {
        bool IsPalindrome(int x)
        {
            var text = x.ToString().ToCharArray();
            Array.Reverse(text);

            var stuff = new string(text);

            var stringVal = x.ToString();

            if (stuff == stringVal)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
