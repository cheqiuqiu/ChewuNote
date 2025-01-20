using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEditor;
using UnityEngine;

public class _移动 : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
        Debug.Log("** SimpleLogic:Start()..");
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        float distance = speed * Time.deltaTime;
        Debug.Log("** Update 帧更新 .. 时间差 = "+ Time.deltaTime); ;
        Vector3 pos = this.transform.localPosition;
        
        pos.x += distance;
        
        this.transform.localPosition = pos; 
    }
}
