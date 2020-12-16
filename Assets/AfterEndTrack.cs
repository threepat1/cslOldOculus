using RenderHeads.Media.AVProVideo;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AfterEndTrack : MonoBehaviour
{
    private IMediaControl mediaPlayer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!mediaPlayer.IsLooping() && mediaPlayer.CanPlay() && mediaPlayer.IsFinished())
        {
            SceneManager.LoadScene(1);
        }
    }
}
