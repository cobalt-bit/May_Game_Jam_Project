using UnityEngine;
using UnityEngine.Audio;

public class BGMScript : MonoBehaviour
{
    new AudioSource audio;
    [SerializeField] AudioResource[] BGMs;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audio = GetComponent<AudioSource>();
        audio.resource = BGMs[0];
        audio.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (audio.loop) return;
        if (audio.isPlaying) return;
        audio.resource = BGMs[1];
        audio.loop = true;
        audio.Play();
    }
}
