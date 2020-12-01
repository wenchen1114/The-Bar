using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyBeer : MonoBehaviour
{
    public Collider player;
    public Transform playerTransform;
    public GameObject beer;

    // Update is called once per frame
    void Update()
    {
        float playerX = playerTransform.position.x;
        float playerY = playerTransform.position.y;
        float playerZ = playerTransform.position.z;
        if (player.isTrigger == true) {
            Instantiate(beer, new Vector3(playerX, playerY+10, playerZ), Quaternion.identity);
        }
    }
}
