using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float runningSpeed;

    float touchHorizontal;
    float newHorizontal = 0;
    public float horizontalSpeed;

    public float limitHorizontal;

    private void FixedUpdate()
    {
        PlayerMovement();
    }

    private void PlayerMovement()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            touchHorizontal = -Input.GetTouch(0).deltaPosition.x / Screen.width;
        }
        else if (Input.GetMouseButton(0))
        {
            touchHorizontal = Input.GetAxis("Mouse X");
        }
        else
        {
            touchHorizontal = 0;
        }

        newHorizontal = transform.position.z + horizontalSpeed * touchHorizontal * Time.deltaTime;

        newHorizontal = Mathf.Clamp(newHorizontal, -limitHorizontal, limitHorizontal);

        Vector3 newPosition = new Vector3(transform.position.x + runningSpeed * Time.deltaTime, transform.position.y, newHorizontal);

        transform.position = newPosition;
    }
}
