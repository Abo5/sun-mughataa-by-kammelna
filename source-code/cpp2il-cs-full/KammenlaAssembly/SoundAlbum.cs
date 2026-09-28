using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Cpp2ILInjected;
using UnityEngine;

public abstract class SoundAlbum<T> : ScriptableObject
{
	[Serializable]
	public class SingleSoundDescriptor
	{
		public T soundId;

		public SingleSound soundClip;
	}

	private sealed class <>c__DisplayClass1_0
	{
		public T soundId;

		internal bool <GetClip>b__0(SingleSoundDescriptor sd)
		{
			//IL_0068: Expected I4, but got O
			if (sd != null)
			{
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
				object objA = default(object);
				object objB = default(object);
				return object.Equals(objA, objB);
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	protected List<SingleSoundDescriptor> trackList;

	public SingleSound GetClip(T soundId)
	{
		//IL_0216: Expected O, but got I
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Expected O, but got Unknown
		//IL_023e: Expected O, but got I4
		//IL_006b: Expected O, but got I
		//IL_0081: Expected O, but got I
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_00a9: Expected O, but got I4
		//IL_010f: Expected O, but got I
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Expected O, but got Unknown
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Expected O, but got Unknown
		//IL_01bf: Expected O, but got I4
		//IL_013d: Expected O, but got I
		nint num = 0;
		IntPtr intPtr = num;
		object obj = num + 309;
		object obj2 = obj & 1;
		bool flag = obj2 == null;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @31DB0EC");
		object obj4 = default(object);
		if (obj4 != null)
		{
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v10 (Il2CppRgctx<SoundAlbum`1>)+30]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v10 (Il2CppRgctx<SoundAlbum`1>)+30]");
			object obj6 = (nint)0 + (nint)309;
			object obj7 = obj6 & 1;
			bool flag2 = obj7 == null;
			object obj8 = !flag2;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X8_v14 (Il2CppRgctx<SoundAlbum`1>)+28]");
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj4, (IntPtr)0);
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (SoundAlbum`1<T>)+18]");
			object obj9 = Enumerable.FirstOrDefault((IEnumerable<object>)0, func);
			if (obj9 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X0_v10 (System.Object)+18]");
				return (SingleSound)0;
			}
			nint num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			string arg = base.name;
			object format = "___# Content push apply failed [{0}]: {1}" + 896;
			object arg2 = default(object);
			string text = string.Format((string)format, arg2, arg);
			object obj10 = typeof(DataRelation) + 856;
			object obj11 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v24+E4]");
			bool flag3 = (nint)0 == 0;
			object obj12 = !flag3;
			object message = text;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				message = text;
			}
			Debug.LogError(message);
			return null;
		}
		return (SingleSound)(object)new NullReferenceException();
	}

	public void PlaySFXSound(T soundId)
	{
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CFF124");
		SingleSound singleSound = default(SingleSound);
		SoundChannel.PlaySFXSound(singleSound);
	}
}
