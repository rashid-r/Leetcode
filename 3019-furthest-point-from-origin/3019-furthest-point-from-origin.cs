public class Solution {
    public int FurthestDistanceFromOrigin(string moves) {
        int leftCount = 0, rightCount = 0, underscoreCount = 0;

        foreach (char ch in moves) {
            switch (ch) {
                case 'L':
                    leftCount++;
                    break;
                case 'R':
                    rightCount++;
                    break;
                case '_':
                    underscoreCount++;
                    break;
            }
        }

        int moveRight = rightCount - leftCount + underscoreCount;
        int moveLeft = leftCount - rightCount + underscoreCount;

        return Math.Max(Math.Abs(moveRight), Math.Abs(moveLeft));
    }
}
