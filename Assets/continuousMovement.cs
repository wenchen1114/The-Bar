using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class continuousMovement : MonoBehaviour
{
    Vector2 moveAxis;
    public GameObject avatar;
    public Camera OVRcamera;
    // Update is called once per frame
    void Update()
    {
        moveAxis = OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick);
        Vector3 avatarPosition;
        avatarPosition = avatar.transform.position;
        avatarPosition.x += moveAxis.x;
        avatarPosition.y += moveAxis.y;
        avatar.transform.position = avatarPosition;
        OVRcamera.transform.position = avatarPosition;
    }
}
