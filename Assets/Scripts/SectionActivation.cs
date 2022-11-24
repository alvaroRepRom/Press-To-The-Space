using UnityEngine;
using UnityEngine.Events;

public class SectionActivation : MonoBehaviour
{
    public UnityEvent onTrigger;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        onTrigger?.Invoke();
    }
}
