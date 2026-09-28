using System;
using System.Data.SqlTypes;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using GoogleMobileAds.Api.AdManager;
using UnityEngine;

[Serializable]
public class AnimetedElementActivator
{
	private sealed class <>c__DisplayClass14_0
	{
		public AnimetedElementActivator <>4__this;

		public bool state;

		internal void <SetActivateState>b__0()
		{
			//IL_0072: Expected O, but got I4
			AnimetedElementActivator animetedElementActivator = <>4__this;
			if (animetedElementActivator.type != ActivatorType.AudioClip)
			{
				if (animetedElementActivator.type != ActivatorType.Particle)
				{
					bool flag = animetedElementActivator.type == ActivatorType.GameObject;
					object obj = !flag;
					if (obj == null)
					{
						animetedElementActivator.gameObject.SetActive(state);
					}
				}
				else if (state)
				{
					animetedElementActivator.particle.Play();
				}
				else
				{
					animetedElementActivator.particle.Stop();
				}
			}
			else if (state)
			{
				if (~(animetedElementActivator.playOnShot ? 1u : 0u) == 0)
				{
					animetedElementActivator.audioSource.PlayOneShot(animetedElementActivator.clip);
				}
				else
				{
					animetedElementActivator.audioSource.Play();
				}
			}
			else if (!animetedElementActivator.playOnShot)
			{
				animetedElementActivator.audioSource.Stop();
			}
		}
	}

	public ActivatorType type;

	public Vector2 activateRange;

	public bool activateOnArrive;

	private GameObject gameObject;

	private ParticleSystem particle;

	public AudioSource audioSource;

	public AudioClip clip;

	public bool playOnShot;

	public float delay;

	private bool lastActivateState;

	private bool ShowGameObjectOption()
	{
		return type == ActivatorType.GameObject;
	}

	private bool ShowParticleOption()
	{
		//IL_0010: Expected O, but got I4
		object obj = type - 1;
		return obj == null;
	}

	private bool ShowAudioOption()
	{
		//IL_0010: Expected O, but got I4
		object obj = type - 2;
		return obj == null;
	}

	private bool ShowActivateRange()
	{
		return !activateOnArrive;
	}

	public void SetActivateState(float position, float travelPosition)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_00c6: Expected F8, but got O
		//IL_00d0: Invalid comparison between F4 and O
		//IL_01e3: Expected F8, but got I
		//IL_01f3: Invalid comparison between F4 and I
		//IL_0204: Expected O, but got I4
		//IL_0224: Invalid comparison between F4 and I4
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Expected I4, but got Unknown
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected O, but got Unknown
		//IL_0149: Expected O, but got I
		//IL_015a: Expected I, but got O
		//IL_02c3: Invalid comparison between F4 and I4
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Expected O, but got Unknown
		//IL_01a2: Expected O, but got I4
		object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 1392;
		object obj2 = default(object);
		Action action = default(Action);
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			obj2..ctor();
			object obj3 = obj2 + 16;
			obj3 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			bool flag2;
			if ((double)travelPosition == 1.0 && activateOnArrive)
			{
				_ = 1;
				bool flag = !lastActivateState;
				double num = 1.0;
				flag2 = true;
				if (!flag)
				{
					break;
				}
			}
			else
			{
				double num = (double)activateRange;
				if ((object)position < activateRange)
				{
					_ = 0;
					bool flag3 = !lastActivateState;
					flag2 = false;
					if (flag3)
					{
						break;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (AnimetedElementActivator)+18]");
					num = 0.0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (AnimetedElementActivator)+18]");
					bool flag4 = position < 0f;
					object obj4 = !flag4;
					float num2 = position;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (AnimetedElementActivator)+18]");
					float num3 = num2 - 0f;
					bool flag5 = num3 == 0f;
					object obj5 = ~obj4;
					bool flag6 = (byte)((obj5 | flag5) ? 1 : 0) != 0;
					bool flag7 = lastActivateState != flag6;
					flag2 = flag6;
					if (!flag7)
					{
						break;
					}
				}
			}
			lastActivateState = flag2;
			object obj6 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj7 = (nint)0 + (nint)3784;
			action..ctor(obj2, (IntPtr)obj7);
			if (delay > 0f)
			{
				object obj8 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
				object obj9 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X0_v13+E4]");
				bool flag8 = (nint)0 == 0;
				object obj10 = !flag8;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Coroutine coroutine = CoroutineDummy.WaitForSeconds(delay, action);
				break;
			}
			IntPtr invoke_impl = ((Delegate)action).invoke_impl;
			IntPtr method_code = ((Delegate)action).method_code;
			IntPtr method = ((Delegate)action).method;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v153 @ X2_v3 (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	private void PerformAction(Action action)
	{
		//IL_00b0: Invalid comparison between F4 and I4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0043: Expected O, but got I4
		while (!(delay > 0f))
		{
			IntPtr invoke_impl = ((Delegate)action).invoke_impl;
			IntPtr method_code = ((Delegate)action).method_code;
			IntPtr method = ((Delegate)action).method;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v81 @ X2_v1 (System.IntPtr) (should have been resolved before IL gen)");
		}
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Coroutine coroutine = CoroutineDummy.WaitForSeconds(delay, action);
	}

	public AnimetedElementActivator()
	{
		//IL_0012: Expected O, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [70DDA10]");
		activateRange = (Vector2)0;
		base..ctor();
	}
}
