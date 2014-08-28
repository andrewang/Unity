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
