using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private float yOffset = 2.5f;
    [SerializeField] private float amortiguation = 2.5f;

    private void Start() => transform.position = new Vector3(target.position.x, target.position.y + yOffset, transform.position.z);

    private void LateUpdate()
    {
        Vector3 newCamPos = new Vector3(target.position.x, target.position.y + yOffset, transform.position.z);
        transform.position = newCamPos;
        //transform.position = Vector3.MoveTowards(transform.position, newCamPos, amortiguation * Time.deltaTime);
    }
}
