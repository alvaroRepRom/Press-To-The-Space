using UnityEngine;
using UnityEngine.UI;

public class ChangeColorImage : MonoBehaviour
{
    [SerializeField] private Color fullBarColor;
    [SerializeField] private Color emptyBarColor;

    private Image image;

    private void Awake() => image = GetComponent<Image>();
    private void Update() => image.color = ColorGradient();

    private Color ColorGradient()
    {
        return Color.Lerp(emptyBarColor, fullBarColor, image.fillAmount);
    }
}
