

using UnityEngine;
using System.Collections;				// required for Coroutines

public class Jeeper : MonoBehaviour
{


   
   
    public float offsetFromObjects = 0.1f;
    public float fixedDepth = 3.0f;
    public OVRCameraRig cameraController = null;



    void Start()
    {
        OVRTouchpad.TouchHandler += OVRTouchpad_TouchHandler;

    }

    private void OVRTouchpad_TouchHandler(object sender, System.EventArgs e)
    {
        OVRTouchpad.TouchArgs touchArgs = (OVRTouchpad.TouchArgs)e;
        if (touchArgs.TouchType == OVRTouchpad.TouchEvent.SingleTap)
        {
            Vector3 cameraPosition = cameraController.centerEyeAnchor.position;
            Vector3 cameraForward = cameraController.centerEyeAnchor.forward;

            Ray ray = new Ray(cameraPosition, cameraForward);
            RaycastHit hit;
            //Send out "eye beams" from the camera...and display the jeeper close by.  
            if (Physics.Raycast(ray, out hit))
            {
                //Change the Jeeper location relative to the object hit by the ray cast  
                transform.position = hit.point + (-cameraForward * offsetFromObjects);
                transform.forward = -cameraForward;

             

                hit.transform.gameObject.BroadcastMessage("OnRayCastHit", hit.point, SendMessageOptions.DontRequireReceiver);

            }


        }
    }

    void LateUpdate()
    {





        Vector3 cameraPosition = cameraController.centerEyeAnchor.position;
        Vector3 cameraForward = cameraController.centerEyeAnchor.forward;

        Ray ray = new Ray(cameraPosition, cameraForward);
        RaycastHit hit;
        ////Send out "eye beams" from the camera...and display the jeeper close by.  
        if (Physics.Raycast(ray, out hit))
        {
            //Change the Jeeper location relative to the object hit by the ray cast  
            transform.position = hit.point + (-cameraForward * offsetFromObjects);
            transform.forward = -cameraForward;

            //    if(Input.GetMouseButton(0))
            //    {
            //hit.transform.gameObject.BroadcastMessage("OnRayCastHit", hit.point, SendMessageOptions.DontRequireReceiver);

            //}

        }

       
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            OVRManager.PlatformUIGlobalMenu();

        }



    }


}

