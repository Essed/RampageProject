using UnityEngine;

public class PlayerCamera : MonoBehaviour
{

    [SerializeField] private Transform playerTransform;
    [SerializeField] private Vector3 offset;
    [SerializeField] private float cameraSpeed = 5f;


    private void LateUpdate()
    {
        Vector3 newCameraPosition = new Vector3(offset.x, playerTransform.position.y + offset.y, playerTransform.position.z + offset.z);
        transform.position = Vector3.Lerp(transform.position, newCameraPosition, cameraSpeed * Time.deltaTime);
    }

}
