using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScript
{
    private static bool _isInitialized = false;

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    public static void FirstSetupCheck()
    {
        if (_isInitialized)
            return;

        GameObject GameManagerObject = new GameObject("GameManager");

        GameManagerObject.AddComponent<GameManager>();

        Object.DontDestroyOnLoad(GameManagerObject);

        _isInitialized = true;
    }
}
