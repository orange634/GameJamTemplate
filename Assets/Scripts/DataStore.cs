using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataStore : MonoBehaviour
{
    // シングルトン用
    private static GameObject mInstance = null;
    void Awake ()
    {
        // シングルトン用
        if (mInstance == null)
        {
            mInstance = gameObject;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
