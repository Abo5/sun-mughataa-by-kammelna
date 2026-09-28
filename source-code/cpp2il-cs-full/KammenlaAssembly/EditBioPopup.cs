using System;
using System.Buffers.Text;
using System.Collections.Generic;
using Cpp2ILInjected;
using Features.GameReplay;
using Kammelna.Server;
using Newtonsoft.Json.Linq.JsonPath;
using Sfs2X.Entities;
using UnityEngine;
using UnityEngine.UI;
using Util.SystemHelpers;

public class EditBioPopup : MonoBehaviour, IInitializable
{
	private PopupUI popup;

	private InputFieldTMProUGUI newBio;

	private void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_004d: Expected I, but got O
		object obj = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 3456;
		object obj2 = (nint)0 + (nint)1528;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		InputField.OnValidateInput onValidateInput = default(InputField.OnValidateInput);
		onValidateInput..ctor(null, (IntPtr)obj2);
		newBio.OnValidateInput += onValidateInput;
	}

	public void Initialize()
	{
		Show();
	}

	private unsafe void Show()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00da: Expected O, but got I
		//IL_0104: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected O, but got Unknown
		//IL_0213: Expected O, but got I4
		//IL_021b: Expected O, but got Ref
		//IL_01ba: Expected O, but got I4
		//IL_01c3: Expected O, but got I4
		//IL_01cb: Expected O, but got Ref
		//IL_0239: Unknown result type (might be due to invalid IL or missing references)
		//IL_023e: Expected O, but got Unknown
		//IL_02db: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E77F5]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v22+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = obj4;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v22+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			object obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		goto IL_0133;
		IL_022a:
		object obj8 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
		object obj9 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X0_v9+E4]");
		PlayerProfileModel playerProfileModel;
		if ((nint)0 != 0)
		{
			if (!LocalizationUtil.IsArabicFixed(playerProfileModel.<bio>k__BackingField))
			{
				goto IL_02ea;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = LocalizationUtil.IsArabicFixed(playerProfileModel.<bio>k__BackingField);
			bool flag4 = !flag3;
			object obj10 = !flag4;
			if (obj10 == null)
			{
				goto IL_02ea;
			}
		}
		goto IL_0304;
		IL_0304:
		popup.PopFromCenter(1f);
		return;
		IL_02ea:
		newBio.Text = playerProfileModel.<bio>k__BackingField;
		goto IL_0304;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		bool flag5 = (object)sessionModel == null;
		object obj11 = !flag5;
		if (obj11 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0133;
		IL_0133:
		object obj12 = typeof(System.Buffers.Text.ParserHelpers) + 1056;
		User localUser = sessionModel.LocalUser;
		string dbId = SFSKammelnaUserExtensions.GetDbId(localUser);
		object obj13 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v4+E4]");
		if ((nint)0 != 0)
		{
			bool flag6 = PlayerProfilesHandler.TryGetCached(dbId, out playerProfileModel);
			bool flag7 = !flag6;
			object obj14 = !flag7;
			object obj15 = 0;
			string text = (string)(&playerProfileModel);
			if (obj14 != null)
			{
				goto IL_022a;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag8 = PlayerProfilesHandler.TryGetCached(dbId, out playerProfileModel);
			bool flag9 = !flag8;
			object obj15 = 0;
			string text = (string)(&playerProfileModel);
			if (!flag9)
			{
				goto IL_022a;
			}
		}
		goto IL_0304;
	}

	public void UpdateBio()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0131: Expected O, but got I4
		//IL_013b: Expected O, but got I4
		//IL_00a4: Expected O, but got I4
		//IL_0198: Expected O, but got I4
		object obj = typeof(System.IOAsyncCallback) + 3096;
		object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1056;
		string text = newBio.Text;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X8_v4+E4]");
		string text2;
		string text3;
		if ((nint)0 != 0)
		{
			text2 = InputSanitizer.SanitizeHtmlTags(text);
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X8_v5+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = 0;
			int num = 200;
			text3 = text2;
			if (!flag)
			{
				goto IL_00c3;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			text2 = InputSanitizer.SanitizeHtmlTags(text);
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X8_v5+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			object obj5 = 0;
			int num = 200;
			text3 = text2;
			if (obj6 != null)
			{
				goto IL_00c3;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		PlayerProfilesHandler.UpdateMyBio(text3);
		PopupUI popupUI = popup;
		bool flag3 = (object)popup == null;
		object obj7 = !flag3;
		if (obj7 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00db;
		IL_00c3:
		PlayerProfilesHandler.UpdateMyBio(text2);
		popupUI = popup;
		goto IL_00db;
		IL_00db:
		popupUI.ShrinkToParent(null);
	}
}
