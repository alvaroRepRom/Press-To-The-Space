using UnityEngine;
using UnityEngine.Events;

public class Timer : MonoBehaviour
{
    [SerializeField] private float time;
    private float timer;

    public UnityEvent onTimeUp;

    private void FixedUpdate()
    {
        timer += Time.deltaTime; 
        if (timer >= time)
            onTimeUp?.Invoke();
    }

    private void OnEnable() => Reset();
    public void Reset() => timer = 0f;
}
