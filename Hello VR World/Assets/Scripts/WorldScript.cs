using UnityEngine;
using System.Collections;

public class WorldScript : MonoBehaviour {

    //public value fields show as configurable properties in the Unity3D Inspector //Window

    public float rotationPerFrame = 1f;


    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        //Rotate 1 degree around the y-axis every frame.

        if (rotationPerFrame > 0f)

            transform.Rotate(0f,1f,0f);

	}
}
