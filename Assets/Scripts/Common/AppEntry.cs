using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppEntry : MonoBehaviour
{
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    static void Initialize()
    {
        // シングルトンのロード
        Instantiate(Resources.Load("Prefabs/DataStore") as GameObject);
        Instantiate(Resources.Load("Prefabs/SoundManager") as GameObject);
    }
}
