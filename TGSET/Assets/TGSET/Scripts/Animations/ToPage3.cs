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
            nextPageAnim.Play();
        }
    }

}
