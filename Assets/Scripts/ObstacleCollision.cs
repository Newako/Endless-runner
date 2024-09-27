using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCollision : MonoBehaviour
{
    PlayerMove playerMove;

    private void Start()
    {
        playerMove = GameObject.FindObjectOfType<PlayerMove>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("PlayerTag"))
        {
            //Kill player
            playerMove.Die();
        }
    }
}
