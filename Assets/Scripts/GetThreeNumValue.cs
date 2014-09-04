using UnityEngine;
using System.Collections;

public class GetThreeNumValue : MonoBehaviour {

    public UILabel _label;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void GetThreeNum(int[] num)
    {
        Debug.Log("a:" + num[0]);
        Debug.Log("b:" + num[1]);
        Debug.Log("c:" + num[2]);
        _label.text = (num[0] + num[1] + num[2]).ToString();
    }
}
