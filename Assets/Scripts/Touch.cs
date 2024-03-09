using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touch : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public GameObject effectprefab;

    // Update is called once per frame
    void Update()
    {
       if(Input.GetMouseButtonDown(0))
        {
            GameObject effectobject = Instantiate(effectprefab, transform);
            Transform effecttransform = effectobject.transform;
            effecttransform.localPosition = Input.mousePosition-new Vector3(Screen.width*0.5f,Screen.height*0.5f,0);


        }
    }
}
