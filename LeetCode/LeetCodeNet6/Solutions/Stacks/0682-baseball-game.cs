namespace LeetCodeNet6.Solutions.Stacks;

/*
Link:
    https://leetcode.com/problems/baseball-game/ 
*/
public class Solution682
{
    private HashSet<string> opSet = new() { "C", "D", "+" };
    
    public int CalPoints(string[] ops)
    {
        Stack<int> scores = new();
        foreach (var op in ops)
        {
            switch (op)
            {
                case "+":
                    var pop = scores.Pop();
                    var peek = scores.Peek();
                    scores.Push(pop);
                    scores.Push(pop + peek);
                    break;
                case "D":
                    scores.Push(scores.Peek() * 2);
                    break;
                case "C":
                    scores.Pop();
                    break;
                default:
                    var val = int.Parse(op);
                    scores.Push(val);
                    break;
            }
        }

        return scores.Sum();
    }
}