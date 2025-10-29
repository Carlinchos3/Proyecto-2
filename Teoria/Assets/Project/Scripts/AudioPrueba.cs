using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioPreuba : MonoBehaviour
{
    [SerializeField] private AudioMixerSnapshot[] snapshots;
    [SerializeField] private AudioSource musicSource;

    [SerializeField] private int bpm = 128;

    private float beatTime;

    private void Awake()
    {
        beatTime = 60f / bpm;
    }

    private float GetBeatValue()
    {
        if (musicSource == null) return 0f;

        float songTime = musicSource.time;
        float currentBeat = songTime / beatTime;

        // Valor oscilando entre -1 y 1
        return Mathf.Sin(currentBeat * Mathf.PI * 2f);
    }

    private void Update()
    {

        // Cambiar de snapshot con teclas 1,2,3...
        for (int i = 0; i < snapshots.Length; i++)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1 + i))
            {
                snapshots[i].TransitionTo(0.5f);
            }
        }
    }
}
