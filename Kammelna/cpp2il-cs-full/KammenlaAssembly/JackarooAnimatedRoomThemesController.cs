using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Jackaroo;
using UnityEngine;
using UnityEngine.AdaptivePerformance;

public class JackarooAnimatedRoomThemesController : AnimatedRoomThemesController
{
	private JackarooCardGameVisualControls _visualControls;

	private GameObject _defaultJackarooTheme;

	protected unsafe override void OnCreateSpineRoomElement(SpineRoomElementData data)
	{
		//IL_0008: Expected O, but got Ref
		//IL_0010: Expected O, but got Ref
		//IL_030f: Expected O, but got I
		//IL_02c3: Expected O, but got Ref
		//IL_0023: Expected O, but got Ref
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected O, but got Unknown
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected O, but got Unknown
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected O, but got Unknown
		//IL_015d: Expected O, but got I
		//IL_0194: Expected O, but got Ref
		//IL_01c2: Expected O, but got I4
		//IL_01ce: Expected O, but got I
		//IL_01dc: Expected O, but got Ref
		//IL_01e4: Expected native int or pointer, but got O
		//IL_01fc: Expected O, but got Ref
		//IL_0204: Expected native int or pointer, but got O
		//IL_0217: Expected O, but got I4
		//IL_0252: Expected O, but got I4
		//IL_0252: Expected O, but got Ref
		//IL_0252: Expected O, but got Ref
		//IL_0252: Expected O, but got Ref
		//IL_0252: Expected O, but got I4
		//IL_0252: Expected O, but got Ref
		//IL_0252: Expected O, but got Ref
		//IL_0252: Expected O, but got Ref
		//IL_0252: Expected O, but got Ref
		object obj2 = default(object);
		object obj = (object)(&obj2);
		object obj4 = default(object);
		object obj3 = (object)(&obj4);
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [data @ X1 (SpineRoomElementData)+58]");
		object obj5 = (nint)0 & (nint)1;
		if (obj5 != null)
		{
			object obj6 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 192));
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [data @ X1 (SpineRoomElementData)+20]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [data @ X1 (SpineRoomElementData)+30]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [data @ X1 (SpineRoomElementData)+40]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [data @ X1 (SpineRoomElementData)+50]");
			_ = 0;
			_ = data.<Info>k__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [data @ X1 (SpineRoomElementData)+10]");
			_ = 0;
			object obj7 = obj6 | 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			_ = data.<AnimationJson>k__BackingField;
			object obj8 = obj6 + 96;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			_ = data.<AtlasJson>k__BackingField;
			object obj9 = obj6 + 104;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			_ = data.<Image>k__BackingField;
			object obj10 = obj6 + 112;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			_ = 0;
			object obj11 = obj6 + 120;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ X24_v1+F0]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ X24_v1+100]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ X24_v1+110]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ X24_v1+120]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ X24_v1+B0]");
			obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ X24_v1+C0]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ X24_v1+D0]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ X24_v1+E0]");
			_ = 0;
			SpineRoomElement spineRoomElement = factory.CreateSpineRoomElement((SpineRoomElementData)(&obj4), null);
			JackarooCardGameVisualControls visualControls = _visualControls;
			Vector2 position = default(Vector2);
			visualControls.<Board>k__BackingField.SetBoardImage(spineRoomElement, (Vector2)0, position);
			object value = (nint)0 + (nint)2112;
			Color? color = (Color?)(object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 216));
			*(Color?*)(nint)color = (Color)value;
			Color? color2 = (Color?)(object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 240));
			*(Color?*)(nint)color2 = (Color)value;
			obj3 = 0;
			bool? flag = default(bool?);
			bool? flag2 = default(bool?);
			bool? flag3 = default(bool?);
			Sprite rightMarble = default(Sprite);
			object obj12 = default(object);
			object obj13 = default(object);
			bool? flag4 = default(bool?);
			_visualControls.SetThemeAndApply((Color?)(object)(&obj4), (Color?)(object)(&flag), (Color?)(object)(&flag2), (Color?)(object)(&flag3), null, null, null, null, rightMarble, (bool?)(object)0, (Color?)(object)(&obj12), (Color?)(object)(&obj13), (Color?)(object)(&flag4), (bool?)(object)0);
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [data @ X1 (SpineRoomElementData)+40]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [data @ X1 (SpineRoomElementData)+50]");
			_ = 0;
			_ = data.<AnimationJson>k__BackingField;
			_ = data.<Image>k__BackingField;
			obj3 = data.<Info>k__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [data @ X1 (SpineRoomElementData)+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [data @ X1 (SpineRoomElementData)+20]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [data @ X1 (SpineRoomElementData)+30]");
			_ = 0;
			base.OnCreateSpineRoomElement((SpineRoomElementData)(&obj4));
		}
	}

	protected override void OnRoomThemeChanged(bool hasAnimatedRoom)
	{
		JackarooCardGameVisualControls visualControls = _visualControls;
		visualControls.<Board>k__BackingField.ResetJackarooBoardTheme();
		GameObject gameObject = _defaultJackarooTheme.gameObject;
		bool active = (byte)((hasAnimatedRoom ? 1u : 0u) ^ 1u) != 0;
		gameObject.SetActive(active);
	}

	protected override void OnLoadAnimatedElements()
	{
		GameObject gameObject = _defaultJackarooTheme.gameObject;
		gameObject.SetActive(value: false);
	}

	public JackarooAnimatedRoomThemesController()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		object obj = typeof(List<AdaptivePerformanceScaler>) + 1168;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj2 = this + 64;
		obj2 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		((MonoBehaviour)this)..ctor();
	}
}
