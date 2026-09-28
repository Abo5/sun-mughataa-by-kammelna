using System.ComponentModel;
using Cpp2ILInjected;
using UI.UI_Themeing;
using UnityEngine;

public class UserNotesEditor : MonoBehaviour
{
	private InputFieldTMProUGUI input;

	private UiToggler uiToggler;

	private UiToggler buttonsAreaToggler;

	private int userId;

	private FriendProfile friendProfile;

	private bool isExpanded;

	public void ToggleCollapse()
	{
		bool expanded = !isExpanded;
		bool flag = (byte)((isExpanded ? 1u : 0u) ^ 1u) != 0;
		isExpanded = flag;
		OnCollapsibleStateChange(expanded);
	}

	private void OnCollapsibleStateChange(bool expanded)
	{
		FriendProfile friendProfile = this.friendProfile;
		input.Text = friendProfile.Notes;
		uiToggler.ToggleManual(expanded);
		input.Interactable = expanded;
		if (expanded)
		{
			input.FocusInput();
		}
	}

	public void OnNoteEdited()
	{
		FriendProfile friendProfile = this.friendProfile;
		string text = input.Text;
		if (friendProfile.Notes != text)
		{
			buttonsAreaToggler.ToggleManual(isON: true);
		}
	}

	public void SaveNote()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		string text = input.Text;
		object obj = this.friendProfile + 56;
		obj = text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		FriendProfile friendProfile = this.friendProfile;
		friendProfile.<IsDirty>k__BackingField = true;
		bool expanded = !isExpanded;
		bool flag = (byte)((isExpanded ? 1u : 0u) ^ 1u) != 0;
		isExpanded = flag;
		OnCollapsibleStateChange(expanded);
		buttonsAreaToggler.ToggleManual(isON: false);
		uiToggler.ToggleManual(isON: false);
	}

	public void UndoEdit()
	{
		FriendProfile friendProfile = this.friendProfile;
		input.Text = friendProfile.Notes;
		bool expanded = !isExpanded;
		bool flag = (byte)((isExpanded ? 1u : 0u) ^ 1u) != 0;
		isExpanded = flag;
		OnCollapsibleStateChange(expanded);
		buttonsAreaToggler.ToggleManual(isON: false);
		uiToggler.ToggleManual(isON: false);
	}

	public void Initialize(int userID)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00b6: Expected O, but got I4
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_0081: Expected O, but got I
		//IL_0081: Expected O, but got I
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
		userId = userID;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		FriendProfile profile = FriendsManager.GetProfile(userID);
		object obj4 = this + 64;
		obj4 = profile;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X19_v2-20]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v4+38]");
		((InputFieldTMProUGUI)num).Text = (string)0;
	}
}
