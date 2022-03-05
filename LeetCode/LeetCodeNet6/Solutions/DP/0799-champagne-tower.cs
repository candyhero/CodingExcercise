namespace LeetCodeNet6.Solutions.DP;

/*
Link: 
    https://leetcode.com/problems/champagne-tower/
    
Notes:
    Bottom Up Approach: 
        Champagne into any glass = half of champagne out from each parents
        Champagne out from any glass = champagne in - 1
    
    Custom Memoization with dictionary 
*/
public class Solution799
{
    private Dictionary<(int, int), double> _Buffer = new();

    public double ChampagneTower(int poured, int query_row, int query_glass)
    {
        _Buffer = new(){ [(0, 0)] = Math.Max(poured, 0) };
        return Math.Min(GetChampagneInFrom(query_row, query_glass), 1);
    }

    private double GetChampagneInFrom(int qr, int qc)
    {
        if (!_Buffer.ContainsKey((qr, qc)))
        {
            var champagneFromLeftParents = GetChampagneOutFrom(qr - 1, qc - 1) / 2.0;
            var champagneFromRightParents = GetChampagneOutFrom(qr - 1, qc) / 2.0;
            _Buffer[(qr, qc)] = champagneFromLeftParents + champagneFromRightParents;
        }

        return _Buffer[(qr, qc)];
    }

    private double GetChampagneOutFrom(int qr, int qc)
    {
        if (qc < 0 || qc > qr) return 0;
        return Math.Max(GetChampagneInFrom(qr, qc) - 1, 0);
    }
}