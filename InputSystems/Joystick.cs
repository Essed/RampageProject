using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Joystick : MonoBehaviour, IDragHandler, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField] private Image joystickBG;
    [SerializeField] private Image joystick;

    private Vector2 inputVector;

    [SerializeField] private float deadZoneX = 0f;
    [SerializeField] private float deadZoneY = 0.001f;

    public virtual void OnDrag(PointerEventData ped)
    {
        Vector2 pos;

        if (RectTransformUtility.ScreenPointToLocalPointInRectangle(joystickBG.rectTransform, ped.position, ped.pressEventCamera, out pos))
        {
            pos.x = (pos.x / joystickBG.rectTransform.sizeDelta.x);
            pos.y = (pos.y / joystickBG.rectTransform.sizeDelta.y);

            inputVector = new Vector2(pos.x * 2 + 1, pos.y * 2 - 1);

            inputVector = (inputVector.magnitude > 1.0f) ? inputVector.normalized : inputVector;

            joystick.rectTransform.anchoredPosition = new Vector2(inputVector.x * (joystickBG.rectTransform.sizeDelta.x / 2), inputVector.y * (joystickBG.rectTransform.sizeDelta.y / 2));

        }
    }

    public virtual void OnPointerDown(PointerEventData ped)
    {
        OnDrag(ped);
    }

    public virtual void OnPointerUp(PointerEventData ped)
    {
        inputVector = Vector2.zero;
        joystick.rectTransform.anchoredPosition = Vector2.zero;
    }

    public float GetHorizontalAxis()
    {
        if ((inputVector.x < 0.0f && inputVector.x <= -deadZoneX) || (inputVector.x > 0.0f && inputVector.x > deadZoneX))
        {           
           return inputVector.x; 
        }
        else return Input.GetAxis("Horizontal");
    }

    public float GetVerticalAxis()
    {
        if (inputVector.y > -deadZoneY || inputVector.y < deadZoneY)
        {            
            return inputVector.y;
        }
        else return Input.GetAxis("Vertical");
    }

}
