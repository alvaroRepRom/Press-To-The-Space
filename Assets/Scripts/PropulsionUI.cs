using UnityEngine;
using UnityEngine.UI;

public class PropulsionUI : MonoBehaviour
{
    [SerializeField] private Fly propulsion;
    private Image image;

    private void Awake() => image = GetComponent<Image>();
    private void Update() => image.fillAmount = propulsion.FlyTimeLeft;
}