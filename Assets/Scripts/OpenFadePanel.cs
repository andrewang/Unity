using UnityEngine;
using System.Collections;

public class OpenFadePanel : MonoBehaviour 
{
    void OnClick()
    {
        PanelFade _panelfade_script = GameObject.Find("UI Root/Panel1").GetComponent<PanelFade>();
        _panelfade_script._opening = true;
    }
}
