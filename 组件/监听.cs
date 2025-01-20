using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class 监听 : MonoBehaviour
{
    public Slider Slider;
    public Scrollbar Scrollbar;
    public TMP_Dropdown TMP_Dropdown;
    public TMP_InputField TMP_InputField;
    // Start is called before the first frame update
    void Start()
    {
        /*
        1.Slider
        设置Slider取值范围的最小值/最大值
        */
        Slider.minValue = 0;
        Slider.maxValue = 100;
        Slider.onValueChanged.AddListener((value) => { Debug.Log($"Slider滑动变阻值 = {value}"); });

        /*
        2.Scrollbar
        */
        Scrollbar.onValueChanged.AddListener((value) => { Debug.Log($"Scrollbar滚动变化值 = {value}"); });

        /*
       3.TMP_Dropdown
       */
        TMP_Dropdown.options = new List<TMP_Dropdown.OptionData>();
        TMP_Dropdown.options.Add(new TMP_Dropdown.OptionData() { text = "下拉选单1" });
        TMP_Dropdown.options.Add(new TMP_Dropdown.OptionData() { text = "下拉选单2" });
        TMP_Dropdown.options.Add(new TMP_Dropdown.OptionData() { text = "下拉选单3" });
        TMP_Dropdown.onValueChanged.AddListener((index) => { Debug.Log($"TMP_Dropdown下拉索引 = {index}"); });

        /*
       4.TMP_InputField
       */
        TMP_InputField.onValueChanged.AddListener((str) => { Debug.Log($"TMP_InputField 输入字符串中 = {str}"); });
        TMP_InputField.onEndEdit.AddListener((str) => { Debug.Log($"TMP_InputField 输入字符串结束 = {str}"); });
        TMP_InputField.onEndTextSelection.AddListener((str, i, k) => { Debug.Log($"TMP_InputField 鼠标框选字符串 = {str} 起始位置 = {i} 结束位置 = {k}"); });
        TMP_InputField.onDeselect.AddListener((str) => { Debug.Log($"TMP_InputField 取消选字符串 = {str}"); });


    }


}
