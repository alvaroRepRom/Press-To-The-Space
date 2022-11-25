using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private float yOffset = 2.5f;
    [SerializeField] private float maxOffsetAmortiguated = 2f;

    private void Start() => transform.position = new Vector3(target.position.x, target.position.y + yOffset, transform.position.z);

    private void LateUpdate()
    {
        Vector3 newCamPos = new Vector3(target.position.x, target.position.y + yOffset, transform.position.z);
        transform.position = newCamPos;
    }
}
