using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loading : MonoBehaviour


{

    void Start()
    {
        Invoke("loadScene",3);
  
    }

    void loadScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Title");
    }


}

