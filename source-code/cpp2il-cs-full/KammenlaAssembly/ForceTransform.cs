using UnityEngine;

public class ForceTransform : MonoBehaviour
{
	private Quaternion Rotation;

	private void Update()
	{
		//IL_001d: Expected O, but got I4
		Transform transform = base.transform;
		transform.rotation = (Quaternion)0;
	}
}
