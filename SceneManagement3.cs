using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneManagement3 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {

        SceneManager.LoadScene(6);
    }

}

