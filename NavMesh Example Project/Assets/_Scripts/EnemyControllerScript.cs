using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityStandardAssets.Characters.ThirdPerson;
using UnityEngine.UI;


public class EnemyControllerScript : MonoBehaviour
{

    public NavMeshAgent enemyAgent;

    public GameObject player;
    public Text text;
    public int hit;
    void Start()
    {
        enemyAgent.updateRotation = false;
        player = GameObject.FindGameObjectWithTag("Player");

    }

    // Update is called once per frame
    void Update()
    {
        enemyAgent.SetDestination(player.transform.position);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.name =="LowBody")
        {
            hit++;
            text.text = "Player Hit: " + hit;
        }
    }
}
