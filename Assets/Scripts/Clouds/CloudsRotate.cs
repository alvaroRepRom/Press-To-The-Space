using UnityEngine;

public class CloudsRotate : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private bool goClockwise;

    private Vector3 direction;

    private void Start() => direction = goClockwise ? Vector3.forward : Vector3.back;
    private void Update() => transform.Rotate(speed * Time.deltaTime * direction);
}
