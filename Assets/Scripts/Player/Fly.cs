using UnityEngine;

public class Fly : MonoBehaviour
{
    [SerializeField] private float flyForce;
    [SerializeField] private float flyTime;
    [SerializeField] private float recuperationFactor;

    private Rigidbody2D rb;
    private float currentFlyTime;
    private bool canFly;

    public bool CanFly => canFly;
    public float FlyTimeLeft => currentFlyTime / flyTime;
    public float PlayerHeight => transform.position.y;

    private void Awake() => rb = GetComponent<Rigidbody2D>();
    private void Start() => ResetFly();
    private void Update()
    {
        if (Input.GetKey(KeyCode.Space) && canFly)
        {
            rb.AddForce(flyForce * Vector2.up);
            DecrementFlyTime();
        }
        else
            AumentFlyTime();
    }

    private void ResetFly()
    {
        canFly = true;
        currentFlyTime = flyTime;
    }

    private void DecrementFlyTime()
    {
        currentFlyTime -= Time.deltaTime;
        if (currentFlyTime <= 0f)
            canFly = false;
    }

    private void AumentFlyTime()
    {
        currentFlyTime += canFly ? Time.deltaTime * recuperationFactor : Time.deltaTime;
        if (currentFlyTime > flyTime)
            ResetFly();
    }

    public void StopPlayer()
    {
        rb.velocity = Vector2.zero;
        rb.gravityScale = 0f;
    }
}
