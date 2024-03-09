using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchRemove : MonoBehaviour
{

    void destroy()
    {
        Destroy(gameObject);
    }


    // Start is called before the first frame update
    void Start()
    {
        Invoke("destroy", 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
