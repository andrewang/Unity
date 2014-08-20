// Copyright 2014 Blueant Inc. All Rights Reserved.

/**
 * @created 2014/08/20
 * @filename LoadSceneTest.cs
 * @author linw1225@163.com(vitah)
 * @fileoverview 场景scene2脚本，载入其他场景
 */
using UnityEngine;
using System.Collections;

public class LoadSceneTest : MonoBehaviour 
{
    void OnClick()
    {
        Application.LoadLevel("scene1");
    }
}
