using System.Collections.Generic;
using Cpp2ILInjected;
using Kammelna.Server;
using Sfs2X.Entities;
using UnityEngine;
using UnityEngine.UI;

public class ProfileGiftsControls : MonoBehaviour
{
	private ProfileGiftsDisplayerListView displayer;

	private Button openBuyingButton;

	private Button openSupportersButton;

	private PlayerProfileModel _profile;

	public void Populate(PlayerProfileModel profile)
	{
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Expected O, but got Unknown
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_004f: Expected O, but got I4
		//IL_00ac: Expected O, but got I8
		//IL_00d9: Expected O, but got I
		//IL_012d: Expected O, but got I8
		//IL_0165: Expected O, but got I
		//IL_01ce: Expected O, but got I4
		//IL_022b: Expected O, but got I8
		object obj = this + 56;
		obj = profile;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj2 = typeof(Queue<string>) + 848;
		object obj3 = (nint)0 + (nint)2200;
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		int intDbId = SFSKammelnaUserExtensions.GetIntDbId(localUser);
		object obj6 = profile.<userDbId>k__BackingField - intDbId;
		bool isMine = obj6 == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X21_v3-18]");
		((ProfileGiftsDisplayerListView)0).SetItems(profile.<profileGifts>k__BackingField, isMine);
		GameObject gameObject = openBuyingButton.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel2 = default(SessionModel);
		User localUser2 = sessionModel2.LocalUser;
		int intDbId2 = SFSKammelnaUserExtensions.GetIntDbId(localUser2);
		object obj7 = profile.<userDbId>k__BackingField - intDbId2;
		bool flag2 = obj7 == null;
		bool active = !flag2;
		gameObject.SetActive(active);
		object obj8 = (nint)0 + (nint)2720;
		GameObject gameObject2 = openSupportersButton.gameObject;
		bool active2;
		if (ArraysExtensions.IsNullOrEmpty((IEnumerable<object>)profile.<profileGifts>k__BackingField))
		{
			object obj9 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X0_v26+E4]");
			bool flag3 = (nint)0 == 0;
			object obj10 = !flag3;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel3 = default(SessionModel);
			User localUser3 = sessionModel3.LocalUser;
			int intDbId3 = SFSKammelnaUserExtensions.GetIntDbId(localUser3);
			object obj11 = profile.<userDbId>k__BackingField - intDbId3;
			bool flag4 = obj11 == null;
			active2 = flag4;
		}
		else
		{
			active2 = true;
		}
		gameObject2.SetActive(active2);
	}

	public void AddCount(long giftId)
	{
		displayer.AddCount(giftId);
		GameObject gameObject = openSupportersButton.gameObject;
		gameObject.SetActive(value: true);
	}
}
