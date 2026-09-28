using System;
using System.Data;
using System.Data.SqlTypes;
using Cpp2ILInjected;
using UnityEngine;

namespace Kammelna.Server;

public abstract class ContentApplier : IContentApplier
{
	private readonly string <WireKey>k__BackingField;

	public string WireKey => <WireKey>k__BackingField;

	protected ContentApplier(string wireKey)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		object obj = this + 16;
		obj = wireKey;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public virtual void ApplyChanged()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object kind = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 2840;
		LogUnsupported((string)kind);
	}

	public virtual void ApplyDelta(string payloadJson)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object kind = "com.unity.services.authentication.profile" + 3832;
		LogUnsupported((string)kind);
	}

	public virtual void ApplyBlob(string modelJson)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object kind = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 528;
		LogUnsupported((string)kind);
	}

	private void LogUnsupported(string kind)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_0081: Expected O, but got I8
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		//IL_00e0: Expected O, but got I4
		//IL_00f6: Expected O, but got I
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected O, but got Unknown
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected O, but got Unknown
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Expected O, but got Unknown
		//IL_0172: Expected O, but got I8
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected O, but got Unknown
		//IL_01d3: Expected O, but got I4
		//IL_01e9: Expected O, but got I
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Expected O, but got Unknown
		//IL_0226: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Expected O, but got Unknown
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_023f: Expected O, but got Unknown
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_024d: Expected O, but got Unknown
		object obj = typeof(SqlSingle[]) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		string[] array = default(string[]);
		if (array.Length != 0)
		{
			object obj2 = "___# Content push apply failed [{0}]: {1}" + 504;
			object obj3 = array + 32;
			obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X22_v6-8]");
			object obj4 = 0 & 0xFFFFFFFEL;
			if (obj4 != null)
			{
				object obj5 = array + 40;
				obj5 = kind;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X22_v8-10]");
				bool flag = (nint)0 < (nint)2;
				object obj6 = !flag;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X22_v8-10]");
				object obj7 = -2;
				bool flag2 = obj7 == null;
				object obj8 = ~obj6;
				object obj9 = obj8 | flag2;
				if (obj9 == null)
				{
					object obj10 = " SDK from working.  If you would like to change it's implementation please override StartVivoxUnity method in " + 216;
					object obj11 = array + 48;
					obj11 = obj10;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X21_v5-18]");
					object obj12 = 0 & 0xFFFFFFFCL;
					if (obj12 != null)
					{
						object obj13 = array + 56;
						obj13 = <WireKey>k__BackingField;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X19_v5-20]");
						bool flag3 = (nint)0 < (nint)4;
						object obj14 = !flag3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X19_v5-20]");
						object obj15 = -4;
						bool flag4 = obj15 == null;
						object obj16 = ~obj14;
						object obj17 = obj16 | flag4;
						if (obj17 == null)
						{
							object obj18 = "[{0}]:{1}" + 352;
							object obj19 = typeof(DataRelation) + 856;
							object obj20 = array + 64;
							obj20 = obj18;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							string message = string.Concat(array);
							object obj21 = obj19;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X8_v16+E4]");
							if ((nint)0 != 0)
							{
								Debug.Log(message);
								return;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							Debug.Log(message);
							return;
						}
					}
				}
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}
}
