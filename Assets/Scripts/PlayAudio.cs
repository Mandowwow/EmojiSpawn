using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudio : MonoBehaviour
{
    [SerializeField] private AudioClip clip;
    [SerializeField] private AudioSource source;
    private bool musicStart = true;
    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0) {
            if (musicStart) {
                source.PlayOneShot(clip);
                musicStart = false;
            }
        }
    }
}
