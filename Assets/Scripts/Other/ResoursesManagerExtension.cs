using System.Collections.Generic;
using System;






public static class WalkAnimationTool
{
    public enum WalkDirections
    {
        Top = 1,
        Bottom = 2,
        Right = 3,
        Left = 4
    }
    private static readonly Dictionary<WalkDirections, string> WalkingAnimationDictionary = new Dictionary<WalkDirections, string> () {{WalkDirections.Top,"IsWalkingTop"},{WalkDirections.Bottom,"IsWalkingBot"},{WalkDirections.Right,"IsWalking"},{WalkDirections.Left,"IsWalkingLeft"}};

    public static string Get(this WalkDirections walkDirections)
    {
        return WalkingAnimationDictionary[walkDirections];
    }
    public static string GetOpposite(this WalkDirections walkDirections)
    {
        int index = Convert.ToInt32(walkDirections);
        index += index % 2 == 0 ? -1 : +1;
        return Get((WalkDirections) index);
    }
}