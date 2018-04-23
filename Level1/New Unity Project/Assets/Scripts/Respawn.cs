using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour {

    public Transform playerShip;
    public int playerLives = 2;
    public GameObject player;

    void Start()
    {
        Instantiate(playerShip, gameObject.transform.position, Quaternion.identity);
        player = GameObject.FindGameObjectWithTag("Player");

    }

    void Update()
    {

        if (player == null && playerLives >= 1)
        {
            playerLives--;
            Instantiate(playerShip, gameObject.transform.position, Quaternion.identity);
            player = GameObject.FindGameObjectWithTag("Player");

        }
    }
}
