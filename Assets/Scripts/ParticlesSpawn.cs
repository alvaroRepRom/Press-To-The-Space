using UnityEngine;

public class ParticlesSpawn : MonoBehaviour
{
    [SerializeField] private Fly flyPlayerScript;
    private ParticleSystem particles;

    private void Awake() => particles = GetComponent<ParticleSystem>();

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && flyPlayerScript.CanFly)
            particles.Play();
        else
        if (Input.GetKeyUp(KeyCode.Space))
            particles.Stop();
    }
}
