<<<<<<< HEAD
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _旋转 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
    }
    public float value=1;
    // Update is called once per frame
    void Update()
    {
        float defence = value * Time.deltaTime;
        Vector3 angles = this.transform.localEulerAngles;
        angles.y += defence;
        this.transform.localEulerAngles = angles;
    }
}
=======
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _旋转 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
    }
    public float value=1;
    // Update is called once per frame
    void Update()
    {
        float defence = value * Time.deltaTime;
        Vector3 angles = this.transform.localEulerAngles;
        angles.y += defence;
        this.transform.localEulerAngles = angles;
    }
}
>>>>>>> 5b5d006049d1f6a35a9c791f8900d71c72d73da2
