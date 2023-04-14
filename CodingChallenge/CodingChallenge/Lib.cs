namespace CodingChallenge
{
    public static class Lib
    {
        public static bool HasMatchingBrackets(string input)
        {
            Func<char, bool> isOpen = (open => open == '<');
            Func<char, bool> isClose = (close => close == '>');

            int count = 0;
            foreach (char ch in input)
            {
                count = isOpen(ch) ? count + 1 : isClose(ch) ? count - 1 : count;

                if (count < 0)
                {
                    return false;
                }
            }

            return count == 0;
        }
    }
}
