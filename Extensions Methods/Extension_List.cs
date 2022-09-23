using System;
using System.Collections;
using System.Collections.Generic;

public static class Extension_List
{
    public static void Shuffle<T>(this IList<T> list)
    {
        System.Random rng = new System.Random();
        int n = list.Count;
        while (n > 1)
        {
            n--;
            int k = rng.Next(n + 1);
            (list[k], list[n]) = (list[n], list[k]);
        }
    }

    public static T GetRandomItem<T>(this IList<T> list)
    {
        return list[UnityEngine.Random.Range(0, list.Count)];
    }

    // Check if List is empty
    public static bool IsEmpty(this IList list)
    {
        //null check
        if (list == null)
        throw new ArgumentNullException($"The list {list} is null and should not be.");
        return list.Count == 0;
    }
}