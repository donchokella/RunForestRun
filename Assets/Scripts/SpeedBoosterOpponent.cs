using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SpeedBoosterOpponent : MonoBehaviour
{
    public NavMeshAgent OpponentAgent;
    //public PlayerController playerController;
    public OpponentController opponentController;

    public GameObject speedBoostIcon;

    private void Start()
    {
        OpponentAgent = GetComponent<NavMeshAgent>();
        speedBoostIcon.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Booster"))
        {
            //playerController.runningSpeed += 3f;
            opponentController.OpponentAgent.speed += 3f;
            speedBoostIcon.SetActive(true);

            StartCoroutine(SlowDownAfeterCoroutine());
        }
    }

    private IEnumerator SlowDownAfeterCoroutine()
    {
        yield return new WaitForSeconds(2f);
        //playerController.runningSpeed -= 3f;
        opponentController.OpponentAgent.speed -= 3f;

        speedBoostIcon.SetActive(false);
    }
}
