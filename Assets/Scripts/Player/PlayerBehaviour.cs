using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    protected Rigidbody2D playerRb;
    public EntityStats playerStats;

    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
    }

}