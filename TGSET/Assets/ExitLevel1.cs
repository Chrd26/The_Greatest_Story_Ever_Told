using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitLevel1 : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (GameManager.managerInstance.hasExitedLevel1)
        {
            Destroy(this.gameObject);
        }
    }
}
