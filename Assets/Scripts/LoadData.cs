using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadData : MonoBehaviour
{
    public int saveSlotNumber;
    public UnityEngine.UI.Button saveDataButton;


    public void onClick()
    {
        //SaveDataLoader.saveSlotNumber = saveSlotNumber;
        //UnityEngine.SceneManagement.SceneManager.LoadScene("Intro");
        Fungus.FungusManager.Instance.SaveManager.Load("SaveData" + saveSlotNumber);
    }

    

    private void OnEnable()
    {
        if(Fungus.FungusManager.Instance.SaveManager.SaveDataExists("SaveData" + saveSlotNumber))
        {
            saveDataButton.interactable = true;
        }
        else
        {
            saveDataButton.interactable = false;
        }
    }




}
