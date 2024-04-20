using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveData : MonoBehaviour
{
    public int saveSlotNumber;
    public SaveAgain saveAgain;
    public GameObject saveConfirm;


    public void onClick()
    {
        if(Fungus.FungusManager.Instance.SaveManager.SaveDataExists("SaveData" + saveSlotNumber))
        {
            Debug.Log("데이터있음");

            saveAgain.gameObject.SetActive(true);
            saveAgain.slotNumber = saveSlotNumber;

            return;       
        }


        Fungus.FungusManager.Instance.SaveManager.Save("SaveData" + saveSlotNumber);
        saveConfirm.SetActive(true);
    }




}
