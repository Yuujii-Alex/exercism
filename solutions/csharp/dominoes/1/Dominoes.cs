public static class Dominoes
{
    public static bool CanChain(IEnumerable<(int, int)> dominoes)
    {
        var list = dominoes.ToList();
        
        if (list.Count == 0) return true;
        
        if (list.Count == 1) return list[0].Item1 == list[0].Item2;

        var used = new bool[list.Count];
        var currentChain = new List<(int, int)>();

        // starting chain with first domino in normal orientation
        used[0] = true;
        currentChain.Add(list[0]);
        if (FindChain(list, used, currentChain)) return true;
        currentChain.RemoveAt(0);

        // starting chain with first domino flipped
        currentChain.Add((list[0].Item2, list[0].Item1));
        if (FindChain(list, used, currentChain)) return true;

        return false;
    }

    private static bool FindChain(List<(int, int)> pool, bool[] used, List<(int, int)> currentChain)
    {
        // base case: all dominoes have been used
        if (currentChain.Count == pool.Count)
        {
            return currentChain[^1].Item2 == currentChain[0].Item1;
        }

        int requiredLeft = currentChain[^1].Item2;

        for (int i = 0; i < pool.Count; i++)
        {
            if (used[i]) continue;

            int left = pool[i].Item1;
            int right = pool[i].Item2;

            // scenario: domino matches in normal orientation
            if (left == requiredLeft)
            {
                used[i] = true;
                currentChain.Add((left, right));

                if (FindChain(pool, used, currentChain)) return true;

                // Backtrack if it didn't lead to a solution
                currentChain.RemoveAt(currentChain.Count - 1);
                used[i] = false;
            }
            
            // scenario: domino matches if we flip it
            if (right == requiredLeft)
            {
                used[i] = true;
                currentChain.Add((right, left)); // flip orientation

                if (FindChain(pool, used, currentChain)) return true;

                // backtrack
                currentChain.RemoveAt(currentChain.Count - 1);
                used[i] = false;
            }
        }

        return false;
    }
}