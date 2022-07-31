using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeCamera : MonoBehaviour
{
    public Animator cameraShake;
    public void CameraShake()
    {
        cameraShake.SetTrigger("Shake");
    }
}
