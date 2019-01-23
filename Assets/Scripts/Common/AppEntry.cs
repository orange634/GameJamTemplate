using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppEntry : MonoBehaviour
{
    // [SerializeField] private GameObject SoundManagerPref;
    // [SerializeField] private GameObject dataStorePref;

    [RuntimeInitializeOnLoadMethod]
    static void Initialize()
    {
        // シングルトンのロード
        Instantiate(Resources.Load("Prefabs/DataStore") as GameObject);
        Instantiate(Resources.Load("Prefabs/SoundManager") as GameObject);
        // Instantiate(SoundManagerPref);
        // Instantiate(dataStorePref);
    }
}
