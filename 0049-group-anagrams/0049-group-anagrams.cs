class Solution
{
    private const int Mod = (int)(1e9);
    private static readonly int[] PrimeNumbers = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97, 101 };

    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        int n = strs.Length;
        var anagrams = new Dictionary<long, List<string>>();

        for (int i = 0; i < n; i++)
        {
            long hash = 1;
            foreach (char c in strs[i])
                hash = (hash * PrimeNumbers[c - 'a']) % Mod;
            if (!anagrams.ContainsKey(hash)) anagrams[hash] = new List<string>();
            anagrams[hash].Add(strs[i]);
        }
        var groupedAnagrams = new List<IList<string>>();
        foreach (var group in anagrams) groupedAnagrams.Add(group.Value);
        return groupedAnagrams;
    }

}