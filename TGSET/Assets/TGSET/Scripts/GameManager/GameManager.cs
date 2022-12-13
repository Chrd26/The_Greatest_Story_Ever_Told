using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager managerInstance;
    private bool isOnLevel1, isOnLevel2, isOnLevel3, isOnLevel4, isOnLevel5, areControllsEnabled;

    // Start is called before the first frame update
    void Start()
    {
        //Initialize Defaults
        isOnLevel1 = false;
        isOnLevel2 = false;
        isOnLevel3 = false;
        isOnLevel4 = false;
        isOnLevel5 = false;
        areControllsEnabled = false;

        //Set the instance of the managerInstance to this
        if (managerInstance == null)
        {
            managerInstance = this;
        }
        
    }
}
