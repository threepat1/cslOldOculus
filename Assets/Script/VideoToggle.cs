using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoToggle : MonoBehaviour
{
    private VideoPlayer video;
    public GameObject playButton, pauseButton;

    // Start is called before the first frame update
    void Start()
    {
        video = this.GetComponent<VideoPlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Toggle()
    {
       
            if (video.isPlaying && pauseButton.activeSelf)
            {
                video.Pause();
            playButton.SetActive(true);
            pauseButton.SetActive(false);
            }
            else
            {
                video.Play();
            playButton.SetActive(false);
            pauseButton.SetActive(true);

        }
        
    }
}
