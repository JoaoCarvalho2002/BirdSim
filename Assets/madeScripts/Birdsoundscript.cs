using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Birdsoundsript : MonoBehaviour
{
    public AudioClip[] sounds;
    public AudioSource source;
    [Range(0.1f,0.5f)]
    public float volumeChangeMultiplier = 0.2f;
    public float pitchChangeMultiplier = 0.2f;
    void Start ()
    {
        source= GetComponent<AudioSource>();
    }
    // Update is called once per frame
    void Update()
    {
            source.clip = sounds[Random.Range(0, sounds.Length)];
            source.volume = Random.Range(0-volumeChangeMultiplier,2);
            source.pitch = Random.Range(1-pitchChangeMultiplier,2 + pitchChangeMultiplier);
            source.PlayOneShot(source.clip);
    }
}
