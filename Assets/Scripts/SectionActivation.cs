using UnityEngine;
using UnityEngine.Events;

public class SectionActivation : MonoBehaviour
{
    // this class work together with CloudsSectionManager script
    public UnityEvent onTrigger;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        onTrigger?.Invoke();
        Destroy(this); // Destroy this script as a GameObject Component on the Scene
    }
}
