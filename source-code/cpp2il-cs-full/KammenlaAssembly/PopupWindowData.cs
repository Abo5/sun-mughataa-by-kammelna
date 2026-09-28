using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.AdaptivePerformance;

public class PopupWindowData
{
	public enum ButtonsLayout
	{
		Linear,
		Grid
	}

	public PopupWindow.MessageType type;

	public LocalizableText title;

	public LocalizableText body;

	public PopupWindow.Theme theme;

	public bool disabledPrimaryButton;

	public List<PopupButton> buttons;

	public List<GameObject> extraContent;

	public ButtonsLayout buttonsLayout;

	public LinearLayoutGroup.Orientation buttonsOrientation;

	public int gridButtonColumns;

	public float gridButtonHeight;

	public GenericSoundAlbumTrack? sound;

	public PopupWindowInputData inputData;

	public PopupWindowData()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		object obj = typeof(List<AdaptivePerformanceScaler>) + 2720;
		object obj2 = typeof(List<AdaptivePerformanceScaler>) + 1168;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj3 = this + 48;
		obj3 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list2 = default(List<object>);
		list2..ctor();
		object obj4 = this + 56;
		obj4 = list2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
	}
}
