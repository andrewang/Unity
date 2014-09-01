// Copyright 2014 Blueant Inc. All Rights Reserved.

/**
 * @created 2014/09/01
 * @filename CloseFadePanel.cs
 * @author linw1225@163.com(vitah)
 * @fileoverview 用于场景scene7，对应关闭Panel按钮
 */
using UnityEngine;
using System.Collections;

public class CloseFadePanel : MonoBehaviour
{
    void OnClick()
    {
        PanelFade _panelfade_script = GameObject.Find("UI Root/Panel1").GetComponent<PanelFade>();
        _panelfade_script._closing = true;
    }
}
