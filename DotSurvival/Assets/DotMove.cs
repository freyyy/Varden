using UnityEngine;
using System.Collections;

public class DotMove : MonoBehaviour {

	public Vector2 dot;
	public Camera cam;
	Vector3 camCoord;
	public float speed;
	// Use this for initialization
	void Start () 
	{
		speed = 0.1f;
		dot = transform.localPosition;
		camCoord = transform.localPosition;
		camCoord.z = -1.0f;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKey (KeyCode.UpArrow)) 
		{
			dot.y += speed;
			camCoord.y += speed;
		}


		if (Input.GetKey (KeyCode.DownArrow)) 
		{
			dot.y -= speed;
			camCoord.y -= speed;
		}


		if (Input.GetKey (KeyCode.LeftArrow)) 
		{
			dot.x -= speed;
			camCoord.x -= speed;
		}


		if (Input.GetKey (KeyCode.RightArrow)) 
		{
			dot.x += speed;
			camCoord.x += speed;
		}

		cam.transform.localPosition = camCoord;

		transform.localPosition = dot;
	}
}
