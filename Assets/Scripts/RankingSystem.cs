using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RankingSystem : MonoBehaviour
{
    public float dist;
    public GameObject endTarget;
    public int rank;  // not sure it shhould be here? I understood. To be able to see at Unity Editor

    void CalculateDistance()
    {
        dist = Vector3.Distance(transform.position, endTarget.transform.position);
    }

    private void Update()
    {
        CalculateDistance();
    }
}
