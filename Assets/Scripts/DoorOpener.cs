using UnityEngine;

public class DoorOpener : MonoBehaviour
{
	[SerializeField] private Animator doorAnimator;

	private bool _isDoorOpen;
	private static readonly int OpenDoor = Animator.StringToHash("OpenDoor");

	private void OnCollisionEnter(Collision other)
	{
		if (_isDoorOpen) return;
		if (!other.gameObject.CompareTag("Player")) return;
		doorAnimator.SetTrigger(OpenDoor);
		_isDoorOpen = true;
	}
}