using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float runningSpeed;

    private void Update()
    {
        Vector3 newPosition = new Vector3(transform.position.x + runningSpeed * Time.deltaTime, transform.position.y, transform.position.z);
        transform.position = newPosition;
    }
}
