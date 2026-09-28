using System;
using UnityEngine;

public class ChallengeStateLightSwitch : MonoBehaviour
{
	private GameObject rightLight;

	private GameObject leftLight;

	private void Awake()
	{
		rightLight.SetActive(value: false);
		leftLight.SetActive(value: false);
	}

	public void ShowLight(int result)
	{
		//IL_004d: Expected I4, but got I8
		//IL_0067: Expected O, but got I4
		//IL_00c1: Expected O, but got I4
		GameObject gameObject;
		if (result >= 1)
		{
			gameObject = rightLight;
		}
		else
		{
			int num = (int)(result & 0x80000000L);
			bool flag = num == 0;
			object obj = !flag;
			if (obj == null)
			{
				rightLight.SetActive(value: false);
				leftLight.SetActive(value: false);
				return;
			}
			gameObject = leftLight;
			bool flag2 = (object)leftLight == null;
			object obj2 = !flag2;
			if (obj2 == null)
			{
				throw new NullReferenceException();
			}
		}
		gameObject.SetActive(value: true);
	}

	private void DisableLights()
	{
		rightLight.SetActive(value: false);
		leftLight.SetActive(value: false);
	}
}
