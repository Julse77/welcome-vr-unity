using UnityEngine;
using UnityEngine.Video;

public class PlayVideo : MonoBehaviour
{
    public GameObject myVideo;
    public VideoPlayer videoClip;

    public void OnPlayVideo()
    {
        myVideo.SetActive(true);
        videoClip.Play();
    }
}
