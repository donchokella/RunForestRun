using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{
    public Transform camTarget;
    public Vector3 dist;
    public float sSpeed = 10f;
    public Transform lookTarget;

    private void LateUpdate()
    {
        Vector3 dPos = camTarget.position + dist;
        Vector3 sPos = Vector3.Lerp(transform.position, dPos, sSpeed * Time.deltaTime);
        transform.position = sPos;
        transform.LookAt(lookTarget.position);
    }
}
