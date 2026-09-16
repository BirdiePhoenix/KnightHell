using UnityEngine;
using System.Threading.Tasks;
using System.Collections;

public class EnemyBehaviour : MonoBehaviour
{
    public EntityStats enemyStats;
    protected GameObject player;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

}