// O(logN)
public class Solution : VersionControl
{
    public int FirstBadVersion(int n)
    {
        int low = 1;
        int high = n;
        int mid = 0;
        while (low <= high)
        {
            mid = low + (high - low) / 2;
            if (IsBadVersion(mid))
            {
                high = mid - 1;
            }
            else
            {
                low = mid + 1;
            }

        }
        if (IsBadVersion(mid))
            return mid;
        else
            return mid + 1;
    }
}
