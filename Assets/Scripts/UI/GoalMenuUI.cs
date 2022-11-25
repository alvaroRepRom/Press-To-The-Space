using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GoalMenuUI : MonoBehaviour
{
    [SerializeField] private GameObject winUI;
    [SerializeField] private GameObject loseUI;
    [SerializeField] private TextMeshProUGUI resultsUI;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            ResetGame();
    }

    public void OpenGoal(bool hasWin, float heightAchived)
    {
        gameObject.SetActive(true);
        winUI.SetActive(hasWin);
        loseUI.SetActive(!hasWin);

        float rest = heightAchived % 10;
        heightAchived /= 10;
        int integer = (int)heightAchived;
        resultsUI.text = "Height: " + integer.ToString() + "," + (int)rest + " km";
    }

    public void ResetGame() => SceneManager.LoadScene(SceneManager.GetActiveScene().name);
}
