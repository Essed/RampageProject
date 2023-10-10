using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationInputWeapon : MonoBehaviour
{
    [SerializeField] private Joystick _joystick;

    [SerializeField] private float sensivity = 1f;
    [SerializeField] private float rotationAmplitude = 1f;

    [SerializeField] private float maxAngle = 60f;
    [SerializeField] private float minAngle = -60f;
      
    float rotationVertical;

    Quaternion startRotation;

    private void Start()
    {
        startRotation = transform.rotation;
    }

    public Quaternion InputRotate()
    {
        rotationVertical = _joystick.GetVerticalAxis() * rotationAmplitude * sensivity;
               
        rotationVertical = Mathf.Clamp(rotationVertical, minAngle, maxAngle);
               
        Quaternion rotationZ = Quaternion.AngleAxis(-rotationVertical, Vector3.right);

        Quaternion needRotation = Quaternion.identity;

        needRotation = startRotation * transform.rotation * rotationZ;

        return needRotation;
    }

}
