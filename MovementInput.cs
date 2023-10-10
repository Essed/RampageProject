using UnityEngine;

public class MovementInput : MonoBehaviour
{
    
    [SerializeField] private float moveSpeed;    
    private Vector3 moveVector;

    [SerializeField] private InputMode _mode; 

    public Vector3 InputMove()
    {
        moveVector = Vector3.zero;

        if (_mode.TypeInput == InputMode.InputType.PC) 
        {
            moveVector.z = _mode.SettingsPC.GetHorizontalAxis() * moveSpeed;
        }
        else 
        {            
            moveVector.z = _mode.SettingsMobile.GetHorizontalAxis() * moveSpeed;
        }
            
        return moveVector;
    }     

}
