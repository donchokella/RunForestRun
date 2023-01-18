using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CheckCollisions : MonoBehaviour
{
    public PlayerController playerController;
    public GameObject EndPanel;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("FinishLine"))
        {
            PlayerFinished();
        }
    }

    void PlayerFinished()
    {
        playerController.runningSpeed = 0;
        transform.Rotate(transform.rotation.x, transform.rotation.y + 150, transform.rotation.z, Space.Self);

        EndPanel.SetActive(true);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
