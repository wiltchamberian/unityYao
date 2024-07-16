using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class global : MonoBehaviour
{
    public static global Instance;

    public string name;

    public int bestScore;
    public string bestName;

    private void Awake()
    {
        if(Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
