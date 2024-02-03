using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScheduleButton : MonoBehaviour
{
    public UnityEngine.UI.Button button;
    public GameObject deleteToggle;
    public int index;


    public System.Action<int> onclickcallback;


    // Start is called before the first frame update
    void Start()
    {
        button.onClick.AddListener(onClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onClick()
    {
        Debug.Log("schedulebutton "+name);
        onclickcallback.Invoke(index);

    }

}
