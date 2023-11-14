using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] ParticleSystem crashEffect;
    void OnTriggerEnter2D(Collider2D other)
    {
       if(other.tag == "Ground")
       {
            crashEffect.Play();
            Invoke("ReLoadScean",.5f);
       }
    }
    void ReLoadScean()
    {
        SceneManager.LoadScene(0);
    }
}
