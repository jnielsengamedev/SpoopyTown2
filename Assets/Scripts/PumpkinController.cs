using UnityEngine;

public class PumpkinController : MonoBehaviour
{
	[SerializeField] private new Light light;

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("Player"))
		{
			light.enabled = true;
		}
	}

	private void OnTriggerExit(Collider other)
	{
		if (other.gameObject.CompareTag("Player"))
		{
			light.enabled = false;
		}
	}
}