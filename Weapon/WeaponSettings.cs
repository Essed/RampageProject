using UnityEngine;

public class WeaponSettings : MonoBehaviour
{
    [SerializeField] private TypeWeapon typeWeapon;
       
    [SerializeField] private float damage = 5f;
    [SerializeField] private float range = 5f;
    [SerializeField] private float fireRate = 10f;

    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform spotBullet;    
    [SerializeField] private Vector3 weaponPosition;   
    
    public Transform BulletSpot
    {
        get { return spotBullet; }
    }

    public GameObject BulletPrefab
    {
        get { return bulletPrefab; }
    }

    public float Range
    {
        get { return range; }
    }

    public float FireRate
    {
        get { return fireRate; }
    }

    public enum TypeWeapon
    {
        Pistol,
        SubmachineGun,
        Shotgun
    }

    public void PositionShift(float value)
    {
        if (value >= 0.0f)
        {
            transform.localPosition = new Vector3(weaponPosition.x, weaponPosition.y, weaponPosition.z);
        }
        else
        {
            transform.localPosition = new Vector3(-weaponPosition.x + 0.65f, weaponPosition.y, weaponPosition.z);
        }
    }
}
