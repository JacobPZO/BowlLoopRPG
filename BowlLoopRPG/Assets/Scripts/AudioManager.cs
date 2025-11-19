using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
	public AudioSource EffectsSource;
    public AudioSource MusicSource;

    public float LowPitchRange = .90f;
    public float HighPitchRange = 1.1f;

    // wow singleton again???
    public static AudioManager Instance = null;

    // more singleton
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }

    public void Play(AudioClip clip)
    {
        EffectsSource.clip = clip;
        EffectsSource.Play();
    }

    public void PlayMusic(AudioClip clip)
    {
        MusicSource.clip = clip;
        MusicSource.Play();
    }

    // Play a random clip from an array & randomize the pitch slightly (for something like footsteps or random voice lines)
    public void RandomSoundEffect(params AudioClip[] clips)
    {
        int randomIndex = UnityEngine.Random.Range(0, clips.Length);
        float randomPitch = UnityEngine.Random.Range(LowPitchRange, HighPitchRange);

        EffectsSource.pitch += randomPitch - 1f;
        EffectsSource.clip = clips[randomIndex];
        EffectsSource.Play();
    }
}
