using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 调用 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    static public void SetActive(GameObject go, bool state)
    {
        if (go == null)
        {
            return;
        }

        if (go.activeSelf != state)
        {
            go.SetActive(state);
        }
    }
}
