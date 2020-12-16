using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class VideoPrepare : MonoBehaviour
{
    private VideoPlayer video;
 
    // Start is called before the first frame update
    void Awake()
    {
        video = GetComponent<VideoPlayer>();
        video.Prepare();
        video.loopPointReached += CheckOver;
        //StartCoroutine(LoadVideoCoroutine("MyVideo"));

    }
    IEnumerator LoadVideoCoroutine(string videoName)
    {
        Debug.Log("videoName: " + videoName);
        string path = AndroidPathManager.GetFriendlyFilesPath() + "/" + videoName + ".mp4";
      
        Debug.Log("Path: " + path);
        video.url = path;
        video.Prepare();
        while (!video.isPrepared)
        {
      
            if (!gameObject.activeInHierarchy)
                yield break;

            yield return null;
        }

        
    }

    // Update is called once per frame
    void CheckOver(UnityEngine.Video.VideoPlayer vp)
    {
     
        SceneManager.LoadScene(1);//the scene that you want to load after the video has ended.
    }
}
