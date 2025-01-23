using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.Events;

public class 定时器 : MonoBehaviour
{
    public void Start()
    {
        Coroutine coroutine = WaitTimeManager.WaitTime(5, () =>
        {
            Debug.Log("5秒等待结束");
        });
        //WaitTimeManager.CancelWait(ref coroutine);
    }
    public class WaitTimeManager
    {
        public static TaskBehaviour s_Tasks;
        static WaitTimeManager()
        {
            GameObject go = new GameObject("#WaitTimeManager#");
            GameObject.DontDestroyOnLoad(go);
            s_Tasks = go.AddComponent<TaskBehaviour>();
        }
        static public Coroutine WaitTime(float time, UnityAction callback)
        {
            return s_Tasks.StartCoroutine(Coroutine(time, callback));
        }
        static public void CancelWait(ref Coroutine coroutine)
        {
            if (coroutine != null)
            {
                s_Tasks.StopCoroutine(coroutine);
                coroutine = null;
            }
        }
        static IEnumerator Coroutine(float time, UnityAction callback)
        {
            yield return new WaitForSeconds(time);
            callback?.Invoke();
        }
        public class TaskBehaviour : MonoBehaviour { }
    }
}
