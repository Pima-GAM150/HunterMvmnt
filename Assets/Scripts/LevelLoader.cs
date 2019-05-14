using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelLoader : MonoBehaviour
{
    public int levelIndex;

    public static LevelLoader find;

    private void Awake()
    {
        find = this;
    }
}
