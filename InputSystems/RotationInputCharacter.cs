using UnityEngine;

public class RotationInputCharacter : MonoBehaviour
{
    [SerializeField] private Joystick _joystick;
    [SerializeField] private WeaponSettings _weaponSettings; 

    float rotationHorizontal;    

    Quaternion startRotation;
   
    private void Start()
    {
        startRotation = transform.rotation;       
    }

    public Quaternion InputRotate()
    {
        rotationHorizontal = _joystick.GetHorizontalAxis();

        Quaternion rotationY = Quaternion.AngleAxis(rotationHorizontal, Vector3.up);      

        Quaternion needRotation = Quaternion.identity;
        
        if (rotationHorizontal >= 0.0f)
        {            
            rotationY = Quaternion.Euler(0, 0, 0);
            _weaponSettings.PositionShift(rotationHorizontal);
        }
        else if(rotationHorizontal < 0.0f)
        {            
            rotationY = Quaternion.Euler(0, 180, 0);
            _weaponSettings.PositionShift(rotationHorizontal);
        }
              

        needRotation = startRotation * rotationY;

        return needRotation;
    }  

}
