<<<<<<< HEAD
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _向上移动 : MonoBehaviour
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
        Debug.Log("** Update 帧更新 .. 时间差 = " + Time.deltaTime); ;
        Vector3 pos = this.transform.localPosition;

        pos.y += distance;

        this.transform.localPosition = pos;
    }
}
=======
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _向上移动 : MonoBehaviour
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
        Debug.Log("** Update 帧更新 .. 时间差 = " + Time.deltaTime); ;
        Vector3 pos = this.transform.localPosition;

        pos.y += distance;

        this.transform.localPosition = pos;
    }
}
>>>>>>> 5b5d006049d1f6a35a9c791f8900d71c72d73da2
