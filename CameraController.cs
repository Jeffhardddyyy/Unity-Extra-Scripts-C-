using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {


	// From the inspector, It allows you to assign "Player"; 
	// Whatever you assign to this, the camera will follow.
	public GameObject Player;

	private Vector3 offset;

	void Start ()
	{
		offset = transform.position - Player.transform.position;
	}

	void LateUpdate ()
	{
		transform.position = Player.transform.position + offset;
	}
}
