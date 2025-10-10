using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class BossAudioManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private AudioMixerSnapshot[] snapshots;

    int bmp = 128;
    float initialDelay = 0.0f;

    float beatTime;

    AudioSource musicSource;

    private Image img;

    private void Awake()
    {
        beatTime = 60f / bmp;
    }


    float GetBeatTime()
    {
        float songTime = musicSource.time;

        float currentBeatTime = songTime / beatTime;

        float result = Mathf.Sin(currentBeatTime * 360 * Mathf.Deg2Rad);

        return result;
    }

    // Update is called once per frame
    void Update()
    {
        img.GetComponent<RectTransform>().localScale = Vector3.one * (1.0f + 0.5f);

        for (int i = 0; i < snapshots.Length; i++)
        {
            if(Input.GetKeyDown(KeyCode.Alpha1 + i))
            {
                snapshots[i].TransitionTo(0.5f);
            }
        }
    }
}
