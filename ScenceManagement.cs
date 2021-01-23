using UnityEngine.SceneManagement;
using UnityEngine;
using System.Collections;

public class ScenceManagement : MonoBehaviour
{
    public GameObject Fadeout;

    private void OnTriggerEnter(Collider other)
    {
        StartCoroutine(Subtitle());
        
    }
   

        IEnumerator Subtitle()
        {


            Fadeout.SetActive(true);
            Fadeout.GetComponent<Animator>().Play("fadeout");
            yield return new WaitForSeconds(5);
              SceneManager.LoadScene(2);
    }
}
