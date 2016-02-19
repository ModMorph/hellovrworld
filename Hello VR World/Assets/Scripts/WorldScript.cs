using UnityEngine;
using System.Collections;

public class WorldScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        //Rotate 1 degree around the y-axis every frame.
        transform.Rotate(0f,1f,0f);

	}
}
