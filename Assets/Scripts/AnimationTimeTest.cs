// Copyright 2014 Blueant Inc. All Rights Reserved.

/**
 * @created 2014/09/03
 * @filename AnimationTimeTest.cs
 * @author linw1225@163.com(vitah)
 * @fileoverview 用于场景scene17，在控件scele值为变1时打印时间
 */
using UnityEngine;
using System.Collections;

public class AnimationTimeTest : MonoBehaviour
{

    // 两个label控件
    public UILabel _label_1;
    public UILabel _label_2;

    // 控件变为1时值为true
    bool _one;
    bool _two;
    // Use this for initialization
    void Start()
    {
        _one = false;
        _two = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (_label_1.transform.localScale.x == 1 && _one == false)
        {
            Debug.Log("Label 1:" + Time.time);
            _one = true;
        }

        if (_label_2.transform.localScale.x == 1 && _two == false)
        {
            Debug.Log("Label 2:" + Time.time);
            _two = true;
        }
    }
}
