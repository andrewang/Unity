// Copyright 2014 Blueant Inc. All Rights Reserved.

/**
 * @created 2014/08/27
 * @filename PanelFade.cs
 * @author linw1225@163.com(vitah)
 * @fileoverview 用于scene7,实现Panel隐藏和显示功能
 */
using UnityEngine;
using System.Collections;

public class PanelFade : MonoBehaviour
{
    // 表示Panel正在打开
    public bool _opening;
    // 表示Panel正在关闭
    public bool _closing;

    // Update is called once per frame
    void Update()
    {
        if (_opening == true)
        {
            gameObject.transform.GetComponent<UIPanel>().alpha += Time.deltaTime * 4f;

            //Debug.Log(gameObject.transform.GetComponent<UIPanel>().alpha);

            if (gameObject.transform.GetComponent<UIPanel>().alpha >= 1)
                _opening = false;
        }

        if (_closing == true)
        {
            gameObject.transform.GetComponent<UIPanel>().alpha -= Time.deltaTime * 4f;

            if (gameObject.transform.GetComponent<UIPanel>().alpha <= 0)
                _closing = false;
        }
    }
}
