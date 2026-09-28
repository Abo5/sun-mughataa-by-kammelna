using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Threading;
using Cpp2ILInjected;
using Kammelna.Server;
using Sfs2X.Entities;
using UnityEngine;
using UnityEngine.Rendering;

public class FriendSelector : MonoBehaviour
{
	public delegate void SelectionDoneDelegate(string selectedDbId);

	private PopupUI popup;

	private FriendsListUI friendsList;

	private InputFieldTMProUGUI emailInput;

	private SelectionDoneDelegate m_OnSelectionDone;

	private Action m_OnSelectionCancelled;

	public event SelectionDoneDelegate OnSelectionDone
	{
		add
		{
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			object obj = typeof(DebugUI.BitField) + 3152;
			object obj2 = this + 56;
			Delegate obj3 = (Delegate)obj2;
			bool flag;
			Delegate obj5 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Combine(obj3, value);
				if ((object)obj4 == null || obj4 == obj)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj5 == obj3;
					obj3 = obj5;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
		remove
		{
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			object obj = typeof(DebugUI.BitField) + 3152;
			object obj2 = this + 56;
			Delegate obj3 = (Delegate)obj2;
			bool flag;
			Delegate obj5 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Remove(obj3, value);
				if ((object)obj4 == null || obj4 == obj)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj5 == obj3;
					obj3 = obj5;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
	}

	public event Action OnSelectionCancelled
	{
		add
		{
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			object obj = typeof(SqlSingle[]) + 2376;
			object obj2 = this + 64;
			Delegate obj3 = (Delegate)obj2;
			bool flag;
			Delegate obj5 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Combine(obj3, value);
				if ((object)obj4 == null || obj4 == obj)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj5 == obj3;
					obj3 = obj5;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
		remove
		{
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			object obj = typeof(SqlSingle[]) + 2376;
			object obj2 = this + 64;
			Delegate obj3 = (Delegate)obj2;
			bool flag;
			Delegate obj5 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Remove(obj3, value);
				if ((object)obj4 == null || obj4 == obj)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj5 == obj3;
					obj3 = obj5;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
	}

	private void Start()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_004d: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2024;
		object obj2 = (nint)0 + (nint)2592;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		friendsList.OnItemSelected += action;
	}

	public void Show()
	{
		//IL_0014: Expected O, but got I4
		//IL_0024: Expected O, but got I
		//IL_0034: Expected O, but got I
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected O, but got Unknown
		//IL_0082: Expected O, but got I
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected O, but got Unknown
		//IL_00c5: Expected I, but got O
		//IL_00ef: Expected O, but got I4
		object obj = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v5+90]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v6+B8]");
		object text = 0;
		emailInput.Text = (string)text;
		popup.PopFromCenter();
		PopupUI popupUI = popup;
		object obj3 = typeof(SqlSingle[]) + 2376;
		object obj4 = (nint)0 + (nint)2584;
		object obj5 = typeof(RegisteredWaitHandle) + 3136;
		GameObject gameObject = popupUI.content.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj4);
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X0_v10+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		ScreenManager.PushPopup(gameObject, action);
	}

	public void CloseSelectionPanel()
	{
		popup.ShrinkToParent();
	}

	private void FriendsListOnItemSelected(FriendProfile friend)
	{
		int num = default(int);
		string text = num.ToString();
		SelectionDoneDelegate onSelectionDone = this.OnSelectionDone;
		if (this.OnSelectionDone != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v33.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
		popup.ShrinkToParent();
	}

	private void SelectFriend(int userId)
	{
		int num = default(int);
		string text = num.ToString();
		SelectionDoneDelegate onSelectionDone = this.OnSelectionDone;
		if (this.OnSelectionDone != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v17.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
		popup.ShrinkToParent();
	}

	private void Cancel()
	{
		Action onSelectionCancelled = this.OnSelectionCancelled;
		if (this.OnSelectionCancelled != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v12.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
		popup.ShrinkToParent();
	}

	private void Update()
	{
		if (emailInput.IsSubmitted())
		{
			string text = emailInput.Text;
			ValidateEmail(text);
		}
	}

	private void ValidateEmail(string email)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00e3: Expected O, but got I4
		//IL_0097: Expected O, but got I4
		//IL_00a0: Expected O, but got I4
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Expected O, but got Unknown
		//IL_014f: Expected O, but got I
		//IL_0179: Expected O, but got I4
		//IL_0121: Expected O, but got I4
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Expected O, but got Unknown
		//IL_0236: Expected O, but got I4
		//IL_025d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0262: Expected O, but got Unknown
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Expected O, but got Unknown
		//IL_029f: Expected O, but got I
		//IL_02ad: Expected I, but got O
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 2504;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6934]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v21+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v21+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag2 = StringUtil.IsValidEmail(email);
		bool flag3 = !flag2;
		object obj5 = 0;
		if (!flag3)
		{
			goto IL_012f;
		}
		return;
		IL_012f:
		object obj6 = typeof(Queue<string>) + 848;
		object obj7 = (nint)0 + (nint)2200;
		object obj8 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v3+E4]");
		bool flag4 = (nint)0 == 0;
		object obj9 = !flag4;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		string email2 = SFSKammelnaUserExtensions.GetEmail(localUser);
		if (!email.Equals(email2, StringComparison.CurrentCultureIgnoreCase))
		{
			object obj10 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
			object obj11 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X0_v13+E4]");
			bool flag5 = (nint)0 == 0;
			object obj12 = !flag5;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object msgBody = "LAK" + 2136;
			PopupWindow.ShowLoading((string)msgBody);
			object obj13 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 576;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj14 = (nint)0 + (nint)2576;
			Action<object> action = default(Action<object>);
			action..ctor((object)this, (IntPtr)obj14);
			KammelnaRequests.FindFriend(email, action);
		}
		return;
		IL_0074:
		bool flag6 = StringUtil.IsValidEmail(email);
		bool flag7 = !flag6;
		object obj15 = !flag7;
		obj5 = 0;
		if (obj15 == null)
		{
			return;
		}
		goto IL_012f;
	}

	private void ShowPopup()
	{
		popup.PopFromCenter();
	}

	private void HidePopup()
	{
		popup.ShrinkToParent();
	}

	private void <ValidateEmail>g__ValidateEmailCallback|17_0(KammelnaResponseModel<PlayerProfileModel> response)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00db: Expected O, but got I4
		//IL_0098: Expected O, but got I4
		//IL_010e: Expected O, but got I
		//IL_01fa: Expected O, but got I4
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Expected O, but got Unknown
		//IL_015e: Expected O, but got I4
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6935]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v19+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v19+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		PopupWindow.SetLoading(loading: false);
		goto IL_0102;
		IL_0102:
		object obj5 = (nint)0 + (nint)1328;
		bool succeeded = ((KammelnaResponseModel<object>)(object)response).Succeeded;
		object obj6 = obj;
		if (succeeded)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X0_v6+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PopupWindow.DismissMessage();
			int num = default(int);
			string text = num.ToString();
			SelectionDoneDelegate onSelectionDone = this.OnSelectionDone;
			if (this.OnSelectionDone != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v98.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
			popup.ShrinkToParent();
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X0_v6+E4]");
			bool flag3 = (nint)0 == 0;
			object obj8 = !flag3;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object error = "WhiteSmoke" + 496;
			PopupWindow.SetError((string)error);
		}
		return;
		IL_0074:
		PopupWindow.SetLoading(loading: false);
		bool flag4 = response == null;
		object obj9 = !flag4;
		if (obj9 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0102;
	}
}
