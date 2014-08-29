using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class MapCamera : MonoBehaviour {

	public bool canDraw = true;

	float mSize = 0;

	void Update()
	{
		mSize = Screen.height / 2.0f;

		if(camera.orthographicSize != mSize)
			camera.orthographicSize = mSize;
	}
}
