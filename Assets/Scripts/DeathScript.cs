using UnityEngine;

public class DeathScript : MonoBehaviour
{
    public GameObject deathParticles;
    public float deathTime = 2f;


    public GameObject soundManagment;
    private SoundManager soundManager;

    private void Awake()
    {
        soundManager = soundManagment.GetComponent<SoundManager>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Hazard"))
        {
            soundManager.PlayOneShot("death");
            Instantiate(deathParticles, transform.position, transform.rotation);
            Destroy(gameObject, deathTime);

        }
    }      
}


