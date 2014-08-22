// Copyright 2014 Blueant Inc. All Rights Reserved.

/**
 * @created 2014/08/22
 * @filename ToPanel1Btn.cs
 * @author linw1225@163.com(vitah)
 * @fileoverview 场景scene6脚本，跳转到Panel2按钮
 */
using UnityEngine;
using System.Collections;

public class ToPanel2Btn : MonoBehaviour
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

        _panel1.SetActiveRecursively(true);
        _panel2.SetActiveRecursively(false);

        _panel1.transform.GetComponent<UIPanel>().alpha = 0;
        InvokeRepeating("FadePanelOne", 0.25f, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnClick()
    {
        _panel1.SetActiveRecursively(false);

        _panel2.SetActiveRecursively(true);
        _panel2.transform.GetComponent<UIPanel>().alpha = 0;

        InvokeRepeating("FadePanelTwo", 0.25f, 0.5f);
        Debug.Log("Panel1 跳转到 Panel2");
    }

    void FadePanelOne()
    {
        _panel1.transform.GetComponent<UIPanel>().alpha += 0.5f;
    }

    void FadePanelTwo()
    {
        _panel2.transform.GetComponent<UIPanel>().alpha += 0.5f;
    }
}
