using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager managerInstance;
    public bool isOnLevel1, isonLevel, hasExitedLevel1, isFreezeTimeAvailable, isFreezeTimeCasted;

    // Start is called before the first frame update
    void Start()
    {
        //Initialize Defaults
        isFreezeTimeAvailable = false;
        isFreezeTimeCasted = false;
        isOnLevel1 = false;
        isonLevel = false;
        hasExitedLevel1 = false;

        //Set the instance of the managerInstance to this
        if (managerInstance == null)
        {
            managerInstance = this;
        }
        
    }
}
