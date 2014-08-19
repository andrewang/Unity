// Copyright 2014 Blueant Inc. All Rights Reserved.

/**
 * @created 2014/08/19
 * @filename AddBlood.cs
 * @author linw1225@163.com(vitah)
 * @fileoverview 场景scene1脚本，血量增加
 */
using UnityEngine;
using System.Collections;

public class AddBlood : MonoBehaviour {

    public UISlider _blood_slider;

	void OnClick()
    {
        _blood_slider.value += 0.1f;
    }
}
