using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{
    public GameObject map;
    public Canvas canvas;

    private void Start()
    {
        canvas.GetComponent<Canvas>().enabled = false;
    }

    void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.M)|| Input.GetKeyDown(KeyCode.Escape))
        {

         //   if(Cursor.visible != true)
         //   {
                Cursor.visible = !Cursor.visible;
                Cursor.lockState = CursorLockMode.None;
          //  }
           
            canvas.enabled = !canvas.enabled;
            map.SetActive(map);
            
 
        }
        


    }
}
