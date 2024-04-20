using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveAgain : MonoBehaviour
{
    public int slotNumber;
    public GameObject saveConfirm;

    public void onClickSaveSlot()
    {
        Fungus.FungusManager.Instance.SaveManager.Save("SaveData" + slotNumber);
        saveConfirm.SetActive(true);

    }
}
