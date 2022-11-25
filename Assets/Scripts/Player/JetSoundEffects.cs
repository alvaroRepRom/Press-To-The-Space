using UnityEngine;

public class JetSoundEffects : MonoBehaviour
{
    [SerializeField] private AudioClip idle;
    [SerializeField] private AudioClip run;
    
    private AudioSource audioSource;
    private Fly fly;
    private bool isMoving;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        fly = GetComponentInParent<Fly>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Space) && fly.CanFly && !isMoving)
            SwitchEffect(run, true);
        else 
        if ((!Input.GetKey(KeyCode.Space) || !fly.CanFly) && isMoving)
            SwitchEffect(idle, false);
    }

    private void SwitchEffect(AudioClip clip, bool isAscending)
    {
        audioSource.clip = clip;
        audioSource.Play();
        isMoving = isAscending;
    }
}
