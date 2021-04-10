using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneEnder : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene("Stage1");
        }
    }
}