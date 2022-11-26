using UnityEngine;

public class CloudsMove : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private bool goRight;

    private float leftWallDistance = -10f;
    private float rightWallDistance = 10f;
    private Vector2 direction;

    private void Start() => direction = goRight ? Vector2.right : Vector2.left;
    private void Update()
    {
        float xPos = transform.position.x;
        if (goRight && xPos > rightWallDistance)
        {
            direction = Vector2.left;
            goRight = false;
        }
        if (!goRight && xPos < leftWallDistance)
        {
            direction = Vector2.right;
            goRight = true;
        }
        transform.Translate(speed * Time.deltaTime * direction);
    }
}
