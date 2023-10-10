using UnityEngine;
using UnityEngine.EventSystems;

public class InputMobile : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public enum AxisType
    {
        Positive,
        Negative
    }

    [SerializeField] private AxisType _type;

    [SerializeField] private InputMode _mode;

    public void OnPointerDown(PointerEventData eventData)
    {
        if (_type == AxisType.Positive)
        {           
            _mode.SettingsMobile.AxisValue = 1;           
        }
        else
        {
            _mode.SettingsMobile.AxisValue = -1;            
        }
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        _mode.SettingsMobile.AxisValue = 0;        
    }     
    
}
