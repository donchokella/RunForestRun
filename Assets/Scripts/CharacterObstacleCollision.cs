using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterObstacleCollision : MonoBehaviour
{
    Vector3 CharacterStartPosition;

    private void Start()
    {
        CharacterStartPosition = new Vector3(transform.position.x, transform.position.y, transform.position.z);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Obstacle"))
        {
            transform.position = CharacterStartPosition;
        }
    }
}
