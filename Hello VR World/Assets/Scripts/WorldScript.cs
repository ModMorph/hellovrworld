using UnityEngine;
using System.Collections;

public class WorldScript : MonoBehaviour {

    //public value fields show as configurable properties in the Unity3D Inspector //Window

    public float rotationPerFrame = 1f;

    private bool isRotating = false;
    // Use this for initialization
    void Start () {
        OVRTouchpad.TouchHandler += OVRTouchpad_TouchHandler;
	}

    private void OVRTouchpad_TouchHandler(object sender, System.EventArgs e)
    {
        //if(e.TouchType == OVRTouchpad.TouchEvent.SingleTap)
        //{
        //    isRotating = !isRotating;
        //}
    }

    // Update is called once per frame
    void Update () {

        //Rotate 1 degree around the y-axis every frame.


        if(Input.GetMouseButton(0))
        {
            isRotating = !isRotating; 
        }

        if (rotationPerFrame > 0f && isRotating)

            transform.Rotate(0f, rotationPerFrame, 0f);

        float x = Input.GetAxis("Mouse X");
        float y = Input.GetAxis("Mouse Y");

        if(x > 0f || y > 0f)
        {
            Vector3 vector = new Vector3(x, y);

            transform.position = transform.position + vector * Time.deltaTime;
        }
        

    }

    public void OnRayCastHit(Vector3 vector)
    {
        Destroy(this.gameObject);

    }


}
