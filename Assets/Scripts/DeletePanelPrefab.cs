using UnityEngine;
using System.Collections;

public class DeletePanelPrefab : MonoBehaviour {

	// Use this for initialization
	void Start () 
    {	
	}
	
	// Update is called once per frame
	void Update () 
    {	
	}

    void OnClick()
    {
        NGUITools.Destroy(gameObject.transform.parent.gameObject);
    }
}
