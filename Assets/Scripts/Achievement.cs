using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Achievement : MonoBehaviour
{
    public void onEnding(int endingNumber)
    {
        PlayerPrefs.SetInt("unlockEnding" + endingNumber, 1);
    }
}
