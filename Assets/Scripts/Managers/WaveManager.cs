using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;

public class WaveManager : MonoBehaviour
{
    [SerializeField] private int amountOfEnemies;

    public int AmountOfEnemies { get => amountOfEnemies; set => amountOfEnemies = value; }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected void Wave1()
    {
        amountOfEnemies = 5;
    }
}
