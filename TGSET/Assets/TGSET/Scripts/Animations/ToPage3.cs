using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToPage3 : MonoBehaviour
{
    public Animation nextPageAnim;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameManager.managerInstance.isOnLevel1 = false;
            GameManager.managerInstance.hasExitedLevel1 = true;
            GameManager.managerInstance.isonLevel = false;
            nextPageAnim.Play();

            if (GameManager.managerInstance.isFreezeTimeCasted)
            {
                GameManager.managerInstance.isFreezeTimeCasted = false;
            }
        }
    }

}
