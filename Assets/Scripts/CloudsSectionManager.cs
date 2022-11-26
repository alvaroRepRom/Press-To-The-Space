using UnityEngine;

public class CloudsSectionManager : MonoBehaviour
{
    [SerializeField] private GameObject[] sections;

    private int actualSection = 0;

    public void ActivationSequence()
    {
        // There is no need of a Condition statment because the number of sections are controlled
        actualSection++;
        sections[actualSection].SetActive(true);
        sections[actualSection - 1].SetActive(false);
    }
}
