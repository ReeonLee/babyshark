using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveDataLoader : MonoBehaviour
{
    public static int saveSlotNumber = 0;

    // Start is called before the first frame update
    IEnumerator Start()
    {
        if (saveSlotNumber == 0)
            yield break;

        yield return null;
        //Fungus.FungusManager.Instance.SaveManager.Load("SaveData" + saveSlotNumber);
    }
}
