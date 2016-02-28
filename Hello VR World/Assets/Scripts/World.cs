using UnityEngine;
using System.Collections;

public class World : MonoBehaviour {

    //public value fields show as configurable properties in the Unity3D Inspector //Window

    public float rotationPerFrame = 1f;

  
    // Use this for initialization
    void Start () {
        
	}

  
    // Update is called once per frame
    void Update () {

        //Rotate 1 degree around the y-axis every frame by default. Note this is 
        //simplified just to get things moving, more to it if trying for realism.

        transform.Rotate(0f, rotationPerFrame, 0f);

        
        

    }

    public void OnRayCastHit(Vector3 vector)
    {
        Destroy(this.gameObject);

    }


}
