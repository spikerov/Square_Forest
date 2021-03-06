using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeSlider : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;

    private float _soundVolume = 1f;

    public void ChangeVolume(float volume)
    {
        _soundVolume = volume;
        _audioSource.volume = _soundVolume;
    }
}
