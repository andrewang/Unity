using UnityEngine;
using System.Collections;

public class SendMessageThreeNum : MonoBehaviour {

    public GameObject _object;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnClick()
    {
        int[] num = { 1, 2, 3 };
        Debug.Log("Send message");
        _object.SendMessage("GetThreeNum", num);
        Debug.Log("Send message success");
    }
}
