using System;
using UnityEngine;

public class Skeleton : MonoBehaviour
{
	[SerializeField] private new Light light;
	[SerializeField] private AudioClip skeletonMusic;
	
	private bool _audioPlayed;
	private AudioSource _audioSource;

	private void Awake()
	{
		_audioSource = GetComponent<AudioSource>();
	}
	
	private void OnCollisionEnter(Collision other)
	{
		if (_audioPlayed) return;
		if (!other.gameObject.CompareTag("Player")) return;
		var playerRigidbody = other.gameObject.GetComponent<Rigidbody>();
		light.enabled = true;
		playerRigidbody.AddForce(new Vector3(0,2,8), ForceMode.Impulse);
		_audioSource.PlayOneShot(skeletonMusic);
		_audioPlayed = true;
	}
}