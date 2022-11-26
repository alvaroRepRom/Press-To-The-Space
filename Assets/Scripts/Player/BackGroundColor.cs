using UnityEngine;

public class BackGroundColor : MonoBehaviour
{
    [SerializeField] private Fly flyPlayerScript;
    [SerializeField] private HeightMeterUI heightMeter;
    [SerializeField] private Color startColor;
    [SerializeField] private Color endColor;

    private SpriteRenderer sprite;

    private void Awake() => sprite = GetComponent<SpriteRenderer>();
    private void Update() => sprite.color = ColorGradient();

    private Color ColorGradient()
    {
        float t = flyPlayerScript.PlayerHeight / heightMeter.MaxHeight;
        return Color.Lerp(startColor, endColor, t); // linear interpolation between colors
    }
}
