// Copyright 2014 Blueant Inc. All Rights Reserved.

/**
 * @created 2014/09/01
 * @filename DeletePanelPrefab.cs
 * @author linw1225@163.com(vitah)
 * @fileoverview 用于预设PanelPrefab中的关闭按钮并删除Panel对象按钮
 */
using UnityEngine;
using System.Collections;

public class DeletePanelPrefab : MonoBehaviour 
{
    void OnClick()
    {
        // 找到该按钮要关闭的Panel对象中的PanelFade脚本
        PanelFade _panelfade_script = gameObject.GetComponentInParent<PanelFade>();
        // 把脚本中对应关闭状态的_closing设为true
        _panelfade_script._closing = true;
    }
}
