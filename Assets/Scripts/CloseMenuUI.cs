using UnityEngine;

public class CloseMenuUI : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            gameObject.SetActive(false);
    }
}
