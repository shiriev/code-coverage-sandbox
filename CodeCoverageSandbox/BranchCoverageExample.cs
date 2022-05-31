namespace CodeCoverageSandbox;

public class BranchCoverageExample
{
    public void MultiBranch(int x, int y)
    {
        if (x > 0)
        {
            if (y > 0)
            {
                var r = x + y;
            }
        }
    }
}