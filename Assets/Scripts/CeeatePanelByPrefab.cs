// Copyright 2014 Blueant Inc. All Rights Reserved.

/**
 * @created 2014/09/11
 * @filename CeeatePanelByPrefab.cs
 * @author linw1225@163.com(vitah)
 * @fileoverview 用于场景scene10，动态载入panel预设
 */

using UnityEngine;
using System.Collections;

public class CeeatePanelByPrefab : MonoBehaviour
{
    // panel的预设
    public GameObject _panel_prefab;
    // NGUI的UI Root
    public GameObject _uiroot;

    void OnClick() 
    {
        // 为_uiroot对象添加子对象 
        GameObject panel = NGUITools.AddChild(_uiroot, _panel_prefab);
        // panel的位置调整
        panel.transform.localPosition= new Vector3(-200,0,0);
    }
}
