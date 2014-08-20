// Copyright 2014 Blueant Inc. All Rights Reserved.

/**
 * @created 2014/08/20
 * @filename SkillCDTimeSprite.cs
 * @author linw1225@163.com(vitah)
 * @fileoverview 
 */
using UnityEngine;
using System.Collections;

public class SkillCDTimeSprite : MonoBehaviour
{
    public string[] _sprite_name = { 
            "num_0","num_1", "num_2", "num_3", "num_4", 
            "num_5", "num_6", "num_7", "num_8", "num_9" 
    };

    // 技能是否處於CD狀態
    public bool _skill_is_cd;
    public float _cd_time ;

    UISprite _cd_sprite;
    UIAtlas _altas;
    GameObject _skill_btn;

    // Use this for initialization
    void Start()
    {
        // cd时间初始化
        _cd_time = 3f;

        // 找到对应的altas
        _altas = (UIAtlas)Resources.Load("Prefabs/MyTest", typeof(UIAtlas));
        
        // CD阴影效果sprite初始化
        _cd_sprite = GameObject.Find("UI Root/Camera/SkillButton/CDSprite").GetComponent<UISprite>();
        // 按钮初始化
        _skill_btn = GameObject.Find("UI Root/Camera/SkillButton");
    }

    // Update is called once per frame
    void Update()
    {
        if ( _skill_is_cd )
        {
            float time = _cd_time * _cd_sprite.fillAmount;
            time -= Time.deltaTime;

            // 更新cd和cd时间的sprite
            _skill_is_cd = UpdateCDSprite(_cd_time, time, _skill_btn, "CDSprite");
        }
    }

    void OnClick()
    {
        if (_skill_is_cd)
        {
            Debug.Log("技能CD");
        }
        else
        {
            Debug.Log("施放技能");
            _skill_is_cd = true;
            _cd_sprite.fillAmount = 1;

            // 在按钮下面创建sprite
            UISprite time_sprite = NGUITools.AddSprite(_skill_btn, _altas, _sprite_name[(int)_cd_time+1]);
            time_sprite.height = 25;
            time_sprite.width = 18;
        }
    }

    bool UpdateCDSprite(float cd_time, float time_left, GameObject btn, string sprite_name)
    {
        // 获取btn按钮下cd的sprite
        UISprite cd_sprite = btn.transform.Find(sprite_name).GetComponent<UISprite>();
        cd_sprite.fillAmount = time_left / cd_time;

        // 按钮下的cd时间sprite
        UISprite sprite = btn.transform.Find("Sprite").GetComponent<UISprite>();

        // 处理剩余时间，显示对应的sprite
        if (time_left > 0)
        {
            if ((int)time_left < time_left)
                sprite.spriteName = _sprite_name[(int)time_left + 1];
            else
                sprite.spriteName = _sprite_name[(int)time_left];

            return true;
        }
        else
        {
            // 删除CD时间sprite
            Destroy(btn.transform.Find("Sprite").gameObject);
            cd_sprite.fillAmount = 0;
            return false;
        }
    }
}
