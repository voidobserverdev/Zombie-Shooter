using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] private Transform firePoint;
    [SerializeField] private GameObject bullet;

    private PlayerControls playerControls;

    void Awake()
    {
        playerControls = new PlayerControls();
    }

    void OnEnable()
    {
        playerControls.Player.Enable();
    }

    void OnDisable()
    {
        playerControls.Player.Disable();
    }

    void Update()
    {
        if (playerControls.Player.Fire.WasPressedThisFrame())
        {
            FireBullet();
        }
    }

    void FireBullet()
    {
        Instantiate(bullet, firePoint.position, firePoint.rotation);
    }
}
