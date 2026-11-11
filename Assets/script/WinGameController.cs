using UnityEngine;

public class WinGameController : MonoBehaviour
{
    
    private int spacePressCount = 0;

    
    private int targetPresses = 10;

    
    private bool hasWon = false;

    void Update()
    {
        
        if (hasWon) return;

        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            spacePressCount++;
            Debug.Log("Space bar pressed " + spacePressCount + " times.");

            
            if (spacePressCount >= targetPresses)
            {
                WinGame();
            }
        }
    }

    void WinGame()
    {
        hasWon = true;
        Debug.Log("YOU WIN!");

        
    }
}

