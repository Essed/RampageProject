using UnityEngine;

public class InputSettingsPC : GlobalInputSettings
{
    public float GetHorizontalAxis()
    {       
        return Input.GetAxis(AxisName);
    }
}
