using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManager : MonoBehaviour
{
    public static MainManager Instance;

    private void Awake()
    {
        // start of the new code because 2 MainManager objects were created 
        // when returning to main menu from the game
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        // end of new code
        
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
