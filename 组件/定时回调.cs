using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class 定时回调 : MonoBehaviour
{
    IEnumerable Start()
    {
        yield return new CustomWait(10f, 1f, () =>
        {
            Debug.LogFormat($"每过1秒回调一次：{Time.time}");
        });
        Debug.Log("十秒结束");
    }


    public class CustomWait : CustomYieldInstruction
    {
        public override bool keepWaiting
        {
            get
            {
                if(Time.time - m_StartTime >=m_Time)
                {
                    return false;
                }
                else if(Time.time - m_LastTime >= m_Interval)
                {
                    m_LastTime = Time.time;
                    m_IntervalCallback?.Invoke();
                }
                return true;
            }
        }
        private UnityAction m_IntervalCallback;
        private float m_Interval;
        private float m_StartTime;
        private float m_LastTime;
        private float m_Time;
        public CustomWait(float time,float interval,UnityAction callback)
        {
            m_StartTime = Time.time;
            m_LastTime= Time.time;
            m_Interval = interval;
            m_Time = time;
            m_IntervalCallback = callback;
        }
    }
}
