using UnityEngine;

public class CoffinOpener : MonoBehaviour
{
	[SerializeField] private GameObject coffinLid;
	[SerializeField] private AudioClip coffinBreakingSound;
	private AudioSource _audioSource;
	private bool _coffinOpened;

	private void Awake()
	{
		_audioSource = GetComponent<AudioSource>();
	}

	private void OnCollisionEnter(Collision other)
	{
		if (_coffinOpened) return;
		if (!other.gameObject.CompareTag("Player")) return;
		coffinLid.SetActive(false);
		_audioSource.PlayOneShot(coffinBreakingSound);
		_coffinOpened = true;
	}
}