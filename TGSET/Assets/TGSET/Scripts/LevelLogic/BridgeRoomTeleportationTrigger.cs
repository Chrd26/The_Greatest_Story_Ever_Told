using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeRoomTeleportationTrigger : MonoBehaviour
{
    public GameObject player;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            player.transform.position = new Vector3(31.51f, 27.0f, 0);
            Debug.Log("Teleport");
        }
    }
}
