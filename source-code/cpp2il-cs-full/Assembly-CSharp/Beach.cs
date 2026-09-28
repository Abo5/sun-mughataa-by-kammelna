using System;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Newtonsoft.Json.Linq.JsonPath;
using UnityEngine;
using UnityEngine.UI;

public class Beach : MonoBehaviour
{
	private Image beach;

	private Material beachMaterial;

	private float forwardMoveDuration = 2f;

	private float foamTurbulanceDuration;

	private Vector2 volumeRange;

	private AudioSource audio;

	private AudioClip[] environmentClips;

	private Vector2 environmentPlayRange;

	private Material beachInstanceMaterial;

	private float nextPlayTime;

	private void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_0029: Expected O, but got I
		//IL_0060: Expected F4, but got I
		//IL_0060: Expected F4, but got O
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 3912;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Material material = default(Material);
		material..ctor(beachMaterial);
		object obj2 = this + 88;
		obj2 = material;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X20_v4-38]");
		object obj3 = 0;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v62 @ X8_v3+348] (should have been resolved before IL gen)");
		float time = Time.time;
		Vector2 vector = environmentPlayRange;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Beach)+54]");
		float num = UnityEngine.Random.Range((float)vector, 0f);
		float num2 = time + num;
		float num3 = num2 + 10f;
		nextPlayTime = num3;
	}

	private float GetNextRandomClipTime()
	{
		//IL_0020: Expected F4, but got I
		//IL_0020: Expected F4, but got O
		float time = Time.time;
		Vector2 vector = environmentPlayRange;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Beach)+54]");
		float num = UnityEngine.Random.Range((float)vector, 0f);
		return time + num;
	}

	private void Update()
	{
		//IL_00ab: Expected O, but got I4
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_00fe: Expected O, but got I
		//IL_0123: Expected F4, but got I
		//IL_0123: Expected F4, but got O
		float time = Time.time;
		if (!(time > nextPlayTime))
		{
			return;
		}
		AudioClip[] array = environmentClips;
		if (environmentClips != null)
		{
			int num = UnityEngine.Random.Range(0, array.Length);
			AudioClip[] array2 = environmentClips;
			if (environmentClips != null)
			{
				bool flag = num < array2.Length;
				object obj = !flag;
				if (obj != null)
				{
					goto IL_0153;
				}
				if ((object)audio != null)
				{
					object obj2 = environmentClips + num;
					AudioSource audioSource = audio;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ X9_v5+20]");
					audioSource.PlayOneShot((AudioClip)0);
					float time2 = Time.time;
					Vector2 vector = environmentPlayRange;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Beach)+54]");
					float num2 = UnityEngine.Random.Range((float)vector, 0f);
					float num3 = time2 + num2;
					nextPlayTime = num3;
					return;
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_0153;
		IL_0153:
		throw new IndexOutOfRangeException();
	}

	private void OnPlayEnvironemntClip()
	{
		//IL_0081: Expected O, but got I4
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected O, but got Unknown
		//IL_00d4: Expected O, but got I
		AudioClip[] array = environmentClips;
		if (environmentClips != null)
		{
			int num = UnityEngine.Random.Range(0, array.Length);
			AudioClip[] array2 = environmentClips;
			if (environmentClips != null)
			{
				bool flag = num < array2.Length;
				object obj = !flag;
				if (obj != null)
				{
					goto IL_00e3;
				}
				if ((object)audio != null)
				{
					object obj2 = environmentClips + num;
					AudioSource audioSource = audio;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X9_v4+20]");
					audioSource.PlayOneShot((AudioClip)0);
					return;
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_00e3;
		IL_00e3:
		throw new IndexOutOfRangeException();
	}

	public void MoveBeachForward()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected O, but got Unknown
		//IL_00ed: Expected O, but got I4
		//IL_0034: Expected O, but got I
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_0099: Expected F4, but got O
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
		object obj2 = "ThisIsFakeReceiptData" + 144;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj5 = (nint)0 + (nint)2864;
		object obj6 = "Unsupported map type" + 3688;
		Sequence s = DOTween.Sequence();
		object obj7 = "[{0}]:{1}" + 912;
		string property = (string)obj7 + (string)obj2;
		TweenerCore<float, float, FloatOptions> tweenerCore = ShortcutExtensions.DOFloat(beachInstanceMaterial, 0.45f, property, forwardMoveDuration);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		Tween t = default(Tween);
		Sequence sequence = TweenSettingsExtensions.Append(s, t);
		float duration = forwardMoveDuration * 1.04522054E+09f;
		string property2 = (string)obj7 + (string)obj6;
		TweenerCore<float, float, FloatOptions> tweenerCore2 = ShortcutExtensions.DOFloat(beachInstanceMaterial, 0.2f, property2, duration);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		Tween t2 = default(Tween);
		Sequence sequence2 = TweenSettingsExtensions.Join(s, t2);
		TweenerCore<float, float, FloatOptions> t3 = DoAudioVolume((float)volumeRange, forwardMoveDuration);
		Sequence sequence3 = TweenSettingsExtensions.Join(s, t3);
	}

	public TweenerCore<float, float, FloatOptions> DoAudioVolume(float targetVolume, float duration)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0040: Expected O, but got I
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_00e4: Expected I, but got O
		//IL_0067: Expected I, but got O
		//IL_0091: Expected O, but got I4
		object obj = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 56;
		object obj2 = (nint)0 + (nint)3248;
		object obj3 = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 136;
		object obj4 = (nint)0 + (nint)3256;
		object obj5 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		DOGetter<float> dOGetter = default(DOGetter<float>);
		dOGetter..ctor((object)this, (IntPtr)obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		DOSetter<float> dOSetter = default(DOSetter<float>);
		dOSetter..ctor((object)this, (IntPtr)obj4);
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		return DOTween.To(dOGetter, dOSetter, targetVolume, duration);
	}

	public TweenerCore<float, float, FloatOptions> DoBeachFloat(float targetValue, string property, float duration)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object obj = "[{0}]:{1}" + 912;
		string text = default(string);
		string property2 = (string)obj + text;
		return ShortcutExtensions.DOFloat(beachInstanceMaterial, targetValue, property2, duration);
	}

	public Beach()
	{
		//IL_001d: Expected O, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [70DC928]");
		volumeRange = (Vector2)0;
		base..ctor();
	}

	private float <DoAudioVolume>b__15_0()
	{
		return audio.volume;
	}

	private void <DoAudioVolume>b__15_1(float a)
	{
		audio.volume = a;
	}
}
