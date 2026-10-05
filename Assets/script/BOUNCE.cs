using UnityEngine;

public class BOUNCE : MonoBehaviour
{
    private Renderer vloerRenderer;

    void Start()
    {
        
        vloerRenderer = GetComponent<Renderer>();
    }

    
    void OnCollisionEnter(Collision collision)
    {


        Color willekeurigeKleur = new Color(Random.value, Random.value, Random.value);

        
        vloerRenderer.material.color = willekeurigeKleur;
       
    }


}
