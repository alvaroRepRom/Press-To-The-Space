using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class HeightMeterUI : MonoBehaviour
{
    [SerializeField] private Fly flyPlayerScript;
    [SerializeField] private float goalHeight;
    [SerializeField] private float permitedFallHeight;
    private Image image;
    private float playerMaxHeight = 0f;

    public UnityEvent<bool, float> onGoals;
    public float MaxHeight => goalHeight;

    private void Awake() => image = GetComponent<Image>();
    private void Update()
    {
        Fill();
        MaxHeightAchived();
        EndGameConditions();
    }

    private void Fill() => image.fillAmount = flyPlayerScript.PlayerHeight / goalHeight;

    private void MaxHeightAchived() 
    {
        if (playerMaxHeight < flyPlayerScript.PlayerHeight)
            playerMaxHeight = flyPlayerScript.PlayerHeight;
    }

    private void EndGameConditions()
    {
        if ((flyPlayerScript.PlayerHeight < playerMaxHeight - permitedFallHeight) || 
            (playerMaxHeight >= goalHeight))
        {
            bool winCondition = playerMaxHeight >= goalHeight;
            onGoals?.Invoke(winCondition, winCondition ? goalHeight : playerMaxHeight);
            flyPlayerScript.StopPlayer();
            enabled = false;
        }
    }
}
