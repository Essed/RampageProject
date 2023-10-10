using UnityEngine;

public class CharacterMotion : MonoBehaviour
{
    private MovementInput moveInput;
    private RotationInputCharacter rotationInputCharacter;
    private RotationInputWeapon rotationInputWeapon;
    private CharacterController controller;

    [SerializeField] private Transform _target;

    private void Start()
    {
        moveInput = GetComponent<MovementInput>();
        rotationInputCharacter = GetComponent<RotationInputCharacter>();
        rotationInputWeapon = GetComponent<RotationInputWeapon>();
        controller = GetComponent<CharacterController>();
    }

    private void Update()
    {        
        RotateCharacter();
        RotateWeapon();
        MoveCharacter();
    }

    private void MoveCharacter()
    {
        controller.Move(moveInput.InputMove() * Time.deltaTime);
    }

    private void RotateCharacter()
    {
        transform.rotation = rotationInputCharacter.InputRotate();
    }

    public void RotateWeapon()
    {
        _target.rotation = rotationInputWeapon.InputRotate();
    }
    
}
