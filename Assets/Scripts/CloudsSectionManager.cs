using UnityEngine;

public class CloudsSectionManager : MonoBehaviour
{
    [SerializeField] private GameObject[] sections;

    private int actualSection = 0;

    public void ActivationSequence()
    {
        actualSection++;
        sections[actualSection].SetActive(true);
        sections[actualSection - 1].SetActive(false);
    }
}
