using UnityEngine;

public class BombaPatlat : MonoBehaviour
{
    public GameObject sahnedeSaklananIz;
    public GameObject patlamaEfekti;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision temas)
    {
        if (temas.gameObject.tag == "zemin")
        { 

        Instantiate(patlamaEfekti, transform.position, transform.rotation);

            sahnedeSaklananIz.SetActive(true);

            Destroy(gameObject);
        }
    }
}
