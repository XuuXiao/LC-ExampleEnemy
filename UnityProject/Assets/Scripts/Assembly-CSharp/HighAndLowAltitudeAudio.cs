using UnityEngine;

public class HighAndLowAltitudeAudio : MonoBehaviour
{
	public AudioSource HighAudio;

	public AudioSource LowAudio;

	public float maxAltitude;

	public float minAltitude;

	public bool transitionFromDayToNight;

	public AudioSource stopAudioAtTime;

	public float normalizedDayTimeForEvent;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void SetAudioVolumeBasedOnAltitude(float playerHeight)
	{
	}
}
