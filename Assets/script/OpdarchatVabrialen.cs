using UnityEngine;

public class OpdarchatVabrialen : MonoBehaviour
{

    int mijnleeftijd = 16;
    bool goedeleerling = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mijnleeftijd++;
        Debug.Log("ik ben al" + mijnleeftijd + "jaar oud!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
