using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManagement : MonoBehaviour
{
    public GameObject Fadeout;

    // Start is called before the first frame update
    public void Play()
    {
        StartCoroutine(Subtitle());
        
    }
    public void Exit()
    {
        Application.Quit();
    }
    IEnumerator Subtitle()
    {
        Fadeout.SetActive(true);
        yield return new WaitForSeconds(0.1f);
        SceneManager.LoadScene(1);
        
       
    }
}
