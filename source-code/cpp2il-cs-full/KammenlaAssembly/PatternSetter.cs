using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using Cpp2ILInjected;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Mono.Btls;
using Sfs2X.Entities;
using UnityEngine;
using UnityEngine.UI;

public class PatternSetter : AvatarComponent
{
	private sealed class <>c__DisplayClass6_0
	{
		public PatternSetter <>4__this;

		public User userClient;

		internal void <Initialize>b__0()
		{
			int activePatternID = SFSKammelnaUserExtensions.GetActivePatternID(userClient);
			<>4__this.SetPattern(activePatternID);
		}
	}

	private const string TexRef = "_Effect";

	private Graphic targetGraphic;

	private Material defaultMat;

	private void Awake()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		Material material = targetGraphic.material;
		object obj = this + 48;
		obj = material;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public void SetPattern(int id)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0105: Expected O, but got I4
		//IL_00b7: Expected O, but got I4
		//IL_0154: Expected O, but got I4
		//IL_015d: Expected O, but got I4
		//IL_027c: Expected I, but got O
		//IL_028c: Expected O, but got I
		//IL_029c: Expected O, but got I
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Expected O, but got Unknown
		//IL_01ce: Expected O, but got I4
		//IL_01f7: Expected O, but got I
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Expected O, but got Unknown
		//IL_0230: Expected O, but got I
		//IL_023e: Expected I, but got O
		object obj = 152989696;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E73A8]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v13+E4]");
			bool flag = (nint)0 == 0;
			obj5 = targetGraphic;
			obj6 = targetGraphic;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj5 = targetGraphic;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v13+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = targetGraphic;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6 == null;
		bool flag4 = !flag3;
		object obj8 = !flag4;
		object obj9 = 0;
		UnityEngine.Object obj10 = null;
		if (obj8 != null)
		{
			return;
		}
		goto IL_0170;
		IL_0170:
		if (id > 0)
		{
			object obj11 = typeof(Queue<string>) + 760;
			object obj12 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X0_v5+E4]");
			bool flag5 = (nint)0 == 0;
			object obj13 = !flag5;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj14 = (nint)0 + (nint)2040;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			object obj15 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3480;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj16 = (nint)0 + (nint)3000;
			Action<object> action = default(Action<object>);
			action..ctor((object)this, (IntPtr)obj16);
			ImageCacher imageCacher = default(ImageCacher);
			imageCacher.LoadItemImage(id, ImageCacher.ItemImageType.InGame, this, action);
			return;
		}
		Graphic graphic = targetGraphic;
		Material material = defaultMat;
		nint num = (nint)graphic;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X8_v4 (Il2CppClass<UnityEngine.UI.Graphic>)+348]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X8_v4 (Il2CppClass<UnityEngine.UI.Graphic>)+350]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v116 @ X3_v2 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
		IL_0091:
		bool flag6 = obj5 == null;
		bool flag7 = !flag6;
		obj9 = 0;
		obj10 = null;
		if (!flag7)
		{
			return;
		}
		goto IL_0170;
	}

	private void SetPattern(Sprite sprite)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00e2: Expected O, but got I4
		//IL_00a3: Expected O, but got I4
		//IL_0155: Expected I, but got O
		//IL_018c: Expected O, but got I4
		//IL_0127: Expected O, but got I4
		//IL_0130: Expected O, but got I4
		//IL_0228: Expected O, but got I
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Expected O, but got Unknown
		//IL_01f2: Expected I, but got O
		//IL_0202: Expected O, but got I
		//IL_0212: Expected O, but got I
		object obj = 152989696;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E73A9]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v15+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v15+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag2 = sprite == null;
		bool flag3 = !flag2;
		object obj6 = !flag3;
		object obj7 = 0;
		if (obj6 != null)
		{
			return;
		}
		goto IL_013e;
		IL_013e:
		Graphic graphic = targetGraphic;
		nint num = (nint)graphic;
		Material material = graphic.material;
		object obj8 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X8_v5+E4]");
		bool flag4 = (nint)0 == 0;
		object obj9 = !flag4;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Material material2 = default(Material);
		while (true)
		{
			object obj10 = (nint)0 + (nint)392;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9A80");
			Texture2D texture = sprite.texture;
			object obj11 = "[{0}]:{1}" + 3080;
			material2.SetTexture((string)obj11, texture);
			Graphic graphic2 = targetGraphic;
			nint num2 = (nint)graphic2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v10 (Il2CppClass<UnityEngine.UI.Graphic>)+348]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v10 (Il2CppClass<UnityEngine.UI.Graphic>)+350]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v94 @ X3_v3 (should have been resolved before IL gen)");
		}
		IL_007d:
		bool flag5 = sprite == null;
		bool flag6 = !flag5;
		obj7 = 0;
		if (!flag6)
		{
			return;
		}
		goto IL_013e;
	}

	public override void Initialize(User userClient)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_00c7: Expected O, but got I4
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Expected O, but got Unknown
		//IL_0113: Expected O, but got I
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Expected O, but got Unknown
		//IL_014f: Expected I, but got O
		object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 1992;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(Queue<string>) + 848;
		object obj4 = (nint)0 + (nint)2200;
		object obj5 = obj2 + 16;
		obj5 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = obj2 + 24;
		obj6 = userClient;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		GameObject go = base.gameObject;
		VariableBinderExtensions.Unbind(go);
		GameObject go2 = base.gameObject;
		object obj7 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X0_v16+E4]");
		bool flag = (nint)0 == 0;
		object obj8 = !flag;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj9 = typeof(SqlSingle[]) + 2376;
		object obj10 = (nint)0 + (nint)360;
		object varName = "placementId" + 1536;
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(obj2, (IntPtr)obj10);
		VariableBinderExtensions.Bind(go2, localUser, (string)varName, action);
	}

	public override void Clear()
	{
		//IL_000f: Expected I4, but got I8
		SetPattern(-1);
	}

	public override void Initialize(AvatarData avatarData)
	{
		SetPattern(avatarData.<PatternId>k__BackingField);
	}
}
