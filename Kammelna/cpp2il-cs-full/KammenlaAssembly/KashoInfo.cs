using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using Sfs2X.Entities.Data;

public class KashoInfo
{
	public const string C_Cards = "cards";

	private ISFSObject data;

	public int KashoPlayer
	{
		get
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object varName = "placementId" + 112;
			return SFSExtensions.Get(data, (string)varName, 0);
		}
	}

	public List<Card> Cards(int playerIndex)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0044: Expected I, but got O
		//IL_0054: Expected O, but got I
		//IL_008f: Expected O, but got I
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected O, but got Unknown
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected O, but got Unknown
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		ISFSObject iSFSObject = data;
		object obj3;
		if (data != null)
		{
			object obj = typeof(System.IOAsyncCallback) + 976;
			object obj2 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 2424;
			obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 376;
			nint num = (nint)iSFSObject;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00d0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
			object obj5 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X10_v5-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj5 += 16;
				obj4--;
				if ((nint)obj4 != 1)
				{
					continue;
				}
				goto IL_00d0;
			}
			object obj6 = obj5 + 28;
			object obj7 = num + obj6;
			object obj8 = obj7 + 312;
			goto IL_01bf;
		}
		return (List<Card>)(object)new NullReferenceException();
		IL_01bf:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v186 @ X0_v3] (should have been resolved before IL gen)");
		object obj9 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X8_v8+E4]");
		ISFSArray iSFSArray = default(ISFSArray);
		if ((nint)0 != 0)
		{
			int index = playerIndex - 1;
			return CardUtils.DecodeCards(iSFSArray, index);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		int index2 = playerIndex - 1;
		return CardUtils.DecodeCards(iSFSArray, index2);
		IL_00d0:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_01bf;
	}

	public KashoInfo(ISFSObject data)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		object obj = this + 16;
		obj = data;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
