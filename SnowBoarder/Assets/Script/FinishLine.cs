using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] ParticleSystem finishEffect;
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            finishEffect.Play();
            Invoke("ReLoadScean",1f);
        }
    }
    void ReLoadScean()
    {
        SceneManager.LoadScene(0);
    }
}