using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAim : MonoBehaviour
{
    private Camera mainCamera;

    void Start()
    {
        // Cache the camera once to save CPU cycles!
        mainCamera = Camera.main;
    }

    void Update()
    {
        //Get screen coordinates of mouse
        Vector2 mousePosition = Mouse.current.position.ReadValue();

        //Convert screen position to world position
        Vector3 mouseWorldPosition = mainCamera.ScreenToWorldPoint(new Vector3(mousePosition.x, mousePosition.y));

        //Get direction of mouse position from player's position
        Vector2 lookDirection = (mouseWorldPosition - transform.position).normalized;

        //Rotate player from initial direcition to lookDirection 
        float angle = Vector2.SignedAngle(Vector2.right, lookDirection);
        transform.eulerAngles = new Vector3(0, 0, angle);
    }
}
