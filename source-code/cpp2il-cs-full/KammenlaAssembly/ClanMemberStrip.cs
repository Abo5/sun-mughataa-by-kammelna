using System;
using System.Buffers.Text;
using System.Diagnostics;
using Cpp2ILInjected;
using ListView;
using UnityEngine;
using UnityEngine.UI;

public class ClanMemberStrip : ListViewItem<ClanMemberWrapper, int>
{
	private AvatarInitializer avatar;

	private ClansSerializedUtils clanUtils;

	private Button OptionsButton;

	private Transform optionsList;

	private ComponentReference<OptionListPopup> settingsPopup;

	public ClanUserModel _user;

	private ClanMembersListView _listView;

	public void SetListView(ClanMembersListView listView)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		object obj = this + 200;
		obj = listView;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public unsafe override void Setup(ClanMemberWrapper datum, bool firstTime)
	{
		//IL_000c: Expected O, but got I
		//IL_007a: Expected O, but got Ref
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		//IL_0026: Expected O, but got I
		object obj = (nint)0 + (nint)1648;
		int num = default(int);
		bool firstTime2 = default(bool);
		base.Setup((ClanMemberWrapper)(&num), firstTime2);
		object obj2 = this + 192;
		obj2 = datum.<User>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		AvatarData avatarData = (ClanUserModel)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X20_v3-28]");
		((AvatarInitializer)0).Initialize(avatarData);
		GameObject gameObject = OptionsButton.gameObject;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v4+40]");
		bool active = (nint)0 == 0;
		gameObject.SetActive(active);
	}

	public void ToggleOptions()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_005f: Expected O, but got I
		//IL_0077: Expected I, but got O
		//IL_00a1: Expected O, but got I4
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2904;
		object obj2 = (nint)0 + (nint)1408;
		object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		object obj4 = (nint)0 + (nint)2200;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F80CF4");
	}

	private void <ToggleOptions>b__9_0(OptionListPopup p)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected O, but got Unknown
		object obj = p + 144;
		obj = _user;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Transform parent = OptionsButton.transform;
		p.PopFromCustomParent(parent);
		Transform transform = p.transform;
		UIExtensions.AttachToCanvas(transform, CanvasLayer.SecondaryCanvas, worldPositionStays: true);
	}
}
