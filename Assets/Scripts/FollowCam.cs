using UnityEngine;
using System.Collections;

public class FollowCam : MonoBehaviour {

	static public FollowCam S; //a followcam singleton

	//fields set in the unity inspector pane
	public bool ______________;

	//fields set dynamically
	public GameObject poi; //the point of interest
	public float camZ; //the desired z pos of the camera

	void Awake () {
		S = this;
		camZ = this.transform.position.z;
	}
	
	// Update is called once per frame
	void Update () {
		if (poi == null)
			return;

		Vector3 destination = poi.transform.position;
		destination.z = camZ;
		transform.position = destination;
	}
}
