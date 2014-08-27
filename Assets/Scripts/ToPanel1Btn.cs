// Copyright 2014 Blueant Inc. All Rights Reserved.

/**
 * @created 2014/08/22
 * @filename ToPanel1Btn.cs
 * @author linw1225@163.com(vitah)
 * @fileoverview 场景scene6脚本，跳转到Panel1按钮
 */
using UnityEngine;
using System.Collections;

public class ToPanel1Btn : MonoBehaviour
{
    private GameObject _panel1 = null;
    private GameObject _panel2 = null;
       
    // Use this for initialization
    void Start()
    {
        _panel1 = GameObject.Find("Panel1");
        _panel2 = GameObject.Find("Panel2");

        if (_panel1 == null)
            Debug.Log("Panel1 获取失败！");
        else if (_panel2 == null)
            Debug.Log("Panel2 获取失败！");
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnClick()
    {
        //_panel2.SetActiveRecursively(false);
        _panel2.transform.GetComponent<UIPanel>().alpha = 0;
        _panel1.SetActiveRecursively(true);
        Debug.Log("Panel2 跳转到 Panel1");

        _panel1.transform.GetComponent<UIPanel>().alpha = 0;
        InvokeRepeating("FadePanelOne", 0.01f, 0.1f);
    }

    void FadePanelOne()
    {
        if (_panel1.transform.GetComponent<UIPanel>().alpha == 1)
        {
            CancelInvoke();
        }

        _panel1.transform.GetComponent<UIPanel>().alpha += 0.2f;

        
    }

    void FadePanelTwo()
    {
        if (_panel2.transform.GetComponent<UIPanel>().alpha == 1)
        {
            CancelInvoke();
        }

        _panel2.transform.GetComponent<UIPanel>().alpha += 0.2f;

    }
}
