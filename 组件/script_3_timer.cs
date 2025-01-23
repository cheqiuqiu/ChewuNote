<<<<<<< HEAD
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using UnityEngine;
using UnityEngine.Events;

public class script_3_定时器 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Coroutine coroutine = WaitTimeManager.WaitTime(5, () => { Debug.Log("5秒等待结束"); });
        //等待结束前是否关闭
        //WaitTimeManager.CancelWait(ref coroutine);
    }
    public class WaitTimeManager
    {
        private static TaskBehaviour s_Tasks;
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
        static public void CanelWait(ref Coroutine coroutine)
        {
            if(coroutine != null)
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
        class TaskBehaviour : MonoBehaviour { }
    }

    
}
=======
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using UnityEngine;
using UnityEngine.Events;

public class script_3_定时器 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Coroutine coroutine = WaitTimeManager.WaitTime(5, () => { Debug.Log("5秒等待结束"); });
        //等待结束前是否关闭
        //WaitTimeManager.CancelWait(ref coroutine);
    }
    public class WaitTimeManager
    {
        private static TaskBehaviour s_Tasks;
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
        static public void CanelWait(ref Coroutine coroutine)
        {
            if(coroutine != null)
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
        class TaskBehaviour : MonoBehaviour { }
    }

    
}
>>>>>>> 5b5d006049d1f6a35a9c791f8900d71c72d73da2
