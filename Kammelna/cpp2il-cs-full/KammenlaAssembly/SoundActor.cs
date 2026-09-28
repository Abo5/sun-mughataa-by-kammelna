using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using Spine;
using UnityEngine;

public class SoundActor : ScriptableObject
{
	private sealed class <>c__DisplayClass5_0
	{
		public string sound;

		internal bool <GetAudioClip>b__0(AudioClip clip)
		{
			//IL_0055: Expected I4, but got O
			if ((object)clip != null)
			{
				string name = clip.name;
				return name == sound;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	public int id;

	private string displayName;

	private List<AudioClip> sounds;

	public string DisplayName => displayName;

	public AudioClip GetAudioClip(string sound)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_007a: Expected I, but got O
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected O, but got Unknown
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected O, but got Unknown
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Expected O, but got Unknown
		//IL_012b: Expected O, but got I4
		object obj = typeof(SkeletonBinary.SkeletonInput) + 536;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (obj2 != null)
		{
			object obj3 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 240;
			object obj4 = (nint)0 + (nint)472;
			object obj5 = obj2 + 16;
			obj5 = sound;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj2, (IntPtr)obj4);
			AudioClip audioClip = (AudioClip)Enumerable.FirstOrDefault(sounds, func);
			if ((object)audioClip != null)
			{
				return audioClip;
			}
			object obj6 = "ThisIsFakeReceiptData" + 2344;
			object obj7 = "1.2.840.113549.1.12.1.5" + 1504;
			string text = (string)obj6 + displayName + (string)obj7 + (string)obj5;
			object obj8 = typeof(DataRelation) + 856;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X8_v9+E4]");
			bool flag = (nint)0 == 0;
			object obj10 = !flag;
			object message = text;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				message = text;
			}
			Debug.LogWarning(message);
			return audioClip;
		}
		return (AudioClip)(object)new NullReferenceException();
	}

	public AudioClip GetSoundSample()
	{
		return (AudioClip)ArraysExtensions.Random((IList<object>)sounds);
	}
}
