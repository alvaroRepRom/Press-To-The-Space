using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private float yOffset = 2.5f;
    [SerializeField] private float maxOffsetAmortiguated = 2f;
    [SerializeField] private float amortiguation = 2.5f;

    private void Start() => transform.position = new Vector3(target.position.x, target.position.y + yOffset, transform.position.z);

    private void LateUpdate()
    {
        Vector3 newCamPos = new Vector3(target.position.x, target.position.y + yOffset, transform.position.z);
        transform.position = newCamPos;
        /*
        if (transform.position.y > target.position.y + maxOffsetAmortiguated)
            transform.position = new Vector3(newCamPos.x, newCamPos.y + maxOffsetAmortiguated, newCamPos.z);
        else 
        if (transform.position.y < target.position.y - maxOffsetAmortiguated)
            transform.position = new Vector3(newCamPos.x, newCamPos.y - maxOffsetAmortiguated, newCamPos.z);
        else
            transform.position = Vector3.MoveTowards(transform.position, newCamPos, amortiguation * Time.deltaTime);
        */
        //transform.position = Vector3.MoveTowards(transform.position, newCamPos, amortiguation * Time.deltaTime);
    }
}
