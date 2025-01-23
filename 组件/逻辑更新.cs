using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 逻辑更新 : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log($"Awake {Time.frameCount}");
    }
    private void OnEnable()
    {
        Debug.Log($"OnEnable {Time.frameCount}");
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log($"Start {Time.frameCount}");

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log($"Update {Time.frameCount}");

    }
    private void LateUpdate()
    {
        Debug.Log($"LateUpdate {Time.frameCount}");

    }
}
