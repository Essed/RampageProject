using UnityEngine;

public class InputSettingsMobile : GlobalInputSettings
{

    private int axisValue;
    private float valueAxis;

    [Range(0.01f, 0.1f)]
    [SerializeField] float smoothValue;

    public int AxisValue
    {
        get { return axisValue; }

        set
        {   
            if(value >= -1 || value <= 1)
            {                
                axisValue = value;                
            }
        }
    }


    public float GetHorizontalAxis()
    {
        return GetAxisValue(AxisValue);        
    }

    private float GetAxisValue(int t)
    {
        Vector3 newPosition = Vector3.zero;

        if (axisValue != 0)
        {
            valueAxis += 0.33f * smoothValue;

            valueAxis = Mathf.Clamp(valueAxis, -1f, 1f);

            newPosition = new Vector3(valueAxis, 0, 0);
        }
        else
        {
            valueAxis = 0;
        }

        return newPosition.x * t;
    }

}
