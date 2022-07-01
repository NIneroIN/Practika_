using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Player
{
    static int stars = 0;

    public static void AddStar()
    {
        stars += 1;
    }

    public static int CountStars() => stars;
}
