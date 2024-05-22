using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
using DG.Tweening;
using UnityEditor;

public static class ExtensionsUtils
{
#if UNITY_EDITOR
    [MenuItem("Gabriel/Test")]
    public static void Test()
    {
        Debug.Log("Teste");
    }

    [MenuItem("Gabriel/Test2 %g")]
    public static void Test2()
    {
        Debug.Log("Teste2");
    }
#endif

    public static void Scale(this Transform t, float size)
    {
        t.localScale = Vector3.one * size;
    }

    public static void Scale(this GameObject g, float size)
    {
        g.transform.localScale = Vector3.one * size;
    }

    public static void ScaleVector(this Vector3 v, float size)
    {
        //v.localScale = Vector3.one * size;
    }

    #region RANDOMIC
    //Randômico Lista
    public static T GetRandom<T>(this List<T> list)
    {
        return list[Random.Range(0, list.Count)];
    }

    //Randômico Array
    public static T GetRandom<T>(this T[] array)
    {
        if (array.Length == 0)
        {
            return default(T);
        }

        return array[Random.Range(0, array.Length)];
    }

    //Randômico Mas Nunca Igual
    public static T GetRandomButNotSame<T>(this List<T> list, T unique)
    {
        if (list.Count == 1)
            return unique;

        int randomIndex = Random.Range(0, list.Count);
        return list[randomIndex];
    }
    #endregion
}

