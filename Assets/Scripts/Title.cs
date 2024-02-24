using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("GameStart");

    }

    // Update is called once per frame
    void Update()
    {
    }
    

    public void onClickNewGame()
    {
        Debug.Log("NewGame");
        SaveDataLoader.saveSlotNumber = 0;
        UnityEngine.SceneManagement.SceneManager.LoadScene("Intro");
    }

    public void onClickLoad()
    {
        Debug.Log("GameLoad");
    }

    public void onClickAlbum()
    {
        Debug.Log("Album");
    }

    public void onClickQuit()
    {
        Debug.Log("GameQuit");
        Application.Quit();
    }

    public void onClickReset()
    {
        PlayerPrefs.DeleteAll();
    }
}
