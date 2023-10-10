using UnityEngine;

[RequireComponent(typeof(WeaponSettings))]
public class Weapon : MonoBehaviour
{
    [SerializeField] private WeaponSettings _weaponSettings;

    private float nextTimeToFire = 0f;

    private void Start()
    {
        _weaponSettings = GetComponent<WeaponSettings>();
    }

    private void Update()
    {
        if (Time.time >= nextTimeToFire)
        {
            nextTimeToFire = Time.time + 1f / _weaponSettings.FireRate;
            Shoot();
        }
    }

    private void Shoot()
    {
        RaycastHit hit;
        
        if (Physics.Raycast(_weaponSettings.BulletSpot.position, _weaponSettings.BulletSpot.forward, out hit, _weaponSettings.Range))
        {
            GameObject bullet = Instantiate(_weaponSettings.BulletPrefab, _weaponSettings.BulletSpot.position, _weaponSettings.BulletSpot.rotation);

            bullet.GetComponent<Bullet>().Direction = _weaponSettings.BulletSpot.forward;
        }
    }

}
