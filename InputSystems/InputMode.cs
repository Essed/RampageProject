using UnityEngine;

public class InputMode : MonoBehaviour
{
    public enum InputType
    {
        Mobile,
        PC
    }

    [SerializeField] private InputType _typeInput;    
    
    [SerializeField] private InputSettingsMobile _settingsMobile;
    [SerializeField] private InputSettingsPC _settingsPC;

    public InputType TypeInput
    {
        get { return _typeInput; }
    }

    public InputSettingsPC SettingsPC
    {
        get { return _settingsPC; }
    }

    public InputSettingsMobile SettingsMobile
    {
        get { return _settingsMobile; }
    }

}
