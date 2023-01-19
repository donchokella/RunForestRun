using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SpeedBoosterOpponent : MonoBehaviour
{
    public NavMeshAgent OpponentAgent;
    //public PlayerController playerController;
    public OpponentController opponentController;

    private void Start()
    {
        OpponentAgent = GetComponent<NavMeshAgent>();

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Booster"))
        {
            //playerController.runningSpeed += 3f;
            opponentController.OpponentAgent.speed += 3f;
            StartCoroutine(SlowDownAfeterCoroutine());
        }
    }

    private IEnumerator SlowDownAfeterCoroutine()
    {
        yield return new WaitForSeconds(2f);
        //playerController.runningSpeed -= 3f;
        opponentController.OpponentAgent.speed -= 3f;
    }
}
