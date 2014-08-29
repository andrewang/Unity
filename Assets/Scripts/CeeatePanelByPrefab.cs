using UnityEngine;
using System.Collections;

public class CeeatePanelByPrefab : MonoBehaviour
{
    public GameObject _panel_prefab;
    public GameObject _uiroot;

	// Use this for initialization
	void Start () 
    {	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnClick() 
    {
        GameObject panel = NGUITools.AddChild(_uiroot, _panel_prefab);
        panel.transform.localPosition= new Vector3(-200,0,0);
    }
}
