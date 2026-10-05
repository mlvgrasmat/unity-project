using UnityEngine;

public class BALBOUNCE : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("De bal raakt: " + collision.gameObject.name);
    }
}