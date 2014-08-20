// Copyright 2014 Blueant Inc. All Rights Reserved.

/**
 * @created 2014/08/20
 * @filename MyMouse.cs
 * @author linw1225@163.com(vitah)
 * @fileoverview 场景scene4脚本，鼠标图片更换
 */
using UnityEngine;
using System.Collections;

public class MyMouse : MonoBehaviour {

    public Transform mouseSpriteTransform;
    public Camera camera;

    void Start()
    {
        if (!mouseSpriteTransform) return;
    }

    void Update()
    {
        if (!camera) return;

        Screen.showCursor = false;

        Vector3 mousePos = Input.mousePosition;
        mousePos = camera.ScreenToWorldPoint(mousePos);

        mouseSpriteTransform.position = mousePos;
    }  
}
