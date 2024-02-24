using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlbumSlot : MonoBehaviour
{
    public GameObject Lock;
    public int endingNumber;

    private void OnEnable()
    {
        int unLock = PlayerPrefs.GetInt("unlockEnding" + endingNumber, 0);

        if(unLock == 0)
        {
            Lock.SetActive(true);
        }

        else
        {
            Lock.SetActive(false);
        }
    }
}
