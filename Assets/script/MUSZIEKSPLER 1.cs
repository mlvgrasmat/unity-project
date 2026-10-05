using UnityEngine;

public class MUSZIEKSPLER1 : MonoBehaviour
{


    string currentSong = "";

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Playsong("34 plus 35, ariana grande");
        Playsong("jingel bels");
        Playsong("lego batman theme song");
        SetVolume(5.5f);
    }

    // Update is called once per frame
    void Update()
    {

    }


    void Playsong(string songName)
    {
        Debug.Log("Now Playing" + songName);
        currentSong = songName;
    }

    void stopsong()
    {
        Debug.Log(currentSong + "is stoped");

    }

    void SetVolume(float volume)
    {
        if (volume > 0)
        {
            if (volume <= 10)
            {
                Debug.Log("Volume is now" + volume);
            }

        }
        else
        {
            Debug.Log("volume is onder 0 niet mogelijk");
        }
    }

}






