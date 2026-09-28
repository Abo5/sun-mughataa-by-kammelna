using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Sfs2X.Entities;
using UnityEngine;
using UnityEngine.TextCore;

public class ClanMembershipPrefabSelector : MonoBehaviour
{
	private sealed class <>c__DisplayClass11_0
	{
		public int generation;

		public ClanMembershipPrefabSelector <>4__this;

		internal void <InitializeForMembership>b__0(IInitializable initializable)
		{
			//IL_03fa: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ff: Expected O, but got Unknown
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0029: Expected I, but got O
			//IL_0052: Expected O, but got I4
			//IL_0176: Expected O, but got I4
			//IL_0187: Expected O, but got I4
			//IL_00bb: Expected O, but got I4
			//IL_00c4: Expected O, but got I4
			//IL_0107: Expected O, but got I
			//IL_00db: Expected O, but got I4
			//IL_0455: Expected O, but got I4
			//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01fa: Expected O, but got Unknown
			//IL_03ae: Expected O, but got I4
			//IL_03b7: Expected O, but got I4
			//IL_0317: Expected O, but got I4
			//IL_0220: Unknown result type (might be due to invalid IL or missing references)
			//IL_0225: Expected O, but got Unknown
			//IL_022d: Expected I, but got O
			//IL_023d: Expected O, but got I
			//IL_0354: Expected O, but got I4
			//IL_04af: Expected O, but got I
			//IL_0278: Expected O, but got I
			//IL_03d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_03d8: Expected O, but got Unknown
			//IL_03e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_03e6: Expected O, but got Unknown
			//IL_0286: Unknown result type (might be due to invalid IL or missing references)
			//IL_028b: Expected O, but got Unknown
			//IL_0294: Unknown result type (might be due to invalid IL or missing references)
			//IL_0299: Expected O, but got Unknown
			object obj = typeof(MemberAchievementClanFeedData) + 2976;
			UnityEngine.Object obj8;
			UnityEngine.Object obj9;
			object obj6;
			if (initializable != null)
			{
				object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2232;
				object obj3 = obj2;
				nint num = (nint)initializable;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X9_v14 (Il2CppClass<IInitializable>)+130]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v20+130]");
				bool flag = num2 < 0;
				object obj4 = !flag;
				if (obj4 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X9_v14 (Il2CppClass<IInitializable>)+C8]");
					nint num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v20+130]");
					object obj5 = num3 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X9_v16-8]");
					IInitializable initializable2 = ((0 != (nint)obj3) ? null : initializable);
					obj6 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X0_v28+E4]");
					bool flag2 = (nint)0 == 0;
					object obj7 = !flag2;
					obj8 = (UnityEngine.Object)initializable2;
					obj9 = (UnityEngine.Object)initializable2;
					if (obj7 != null)
					{
						goto IL_0097;
					}
					goto IL_0145;
				}
			}
			obj6 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X0_v28+E4]");
			bool flag3 = (nint)0 == 0;
			obj8 = null;
			obj9 = null;
			if (!flag3)
			{
				goto IL_0097;
			}
			goto IL_0145;
			IL_0097:
			bool flag4 = obj8 != null;
			bool flag5 = !flag4;
			object obj10 = !flag5;
			object obj11 = 0;
			if (obj10 != null)
			{
				goto IL_019f;
			}
			object obj12 = 0;
			UnityEngine.Object obj13 = null;
			UnityEngine.Object obj14 = null;
			goto IL_041c;
			IL_019f:
			GameObject gameObject = ((Component)obj8).gameObject;
			obj12 = obj11;
			obj13 = null;
			obj14 = gameObject;
			goto IL_041c;
			IL_02b9:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			goto IL_0497;
			IL_041c:
			ClanMembershipPrefabSelector clanMembershipPrefabSelector = <>4__this;
			object obj20 = default(object);
			if (generation == clanMembershipPrefabSelector._generation)
			{
				object obj15 = clanMembershipPrefabSelector + 64;
				obj15 = obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj16 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 3144;
				nint num4 = (nint)initializable;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ X8_v9 (Il2CppClass<IInitializable>)+12E]");
				object obj17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ X8_v9 (Il2CppClass<IInitializable>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_02b9;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ X8_v9 (Il2CppClass<IInitializable>)+B0]");
				object obj18 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ X10_v6-8]");
					if (0 == (nint)obj16)
					{
						break;
					}
					obj18 += 16;
					obj17--;
					if ((nint)obj17 != 1)
					{
						continue;
					}
					goto IL_02b9;
				}
				object obj19 = num4 + obj18;
				obj20 = obj19 + 312;
				goto IL_0497;
			}
			object obj21 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X0_v4+E4]");
			if ((nint)0 != 0)
			{
				bool flag6 = obj14 != null;
				bool flag7 = !flag6;
				object obj22 = 0;
				UnityEngine.Object obj23 = null;
				if (flag7)
				{
					return;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag8 = obj14 != null;
				bool flag9 = !flag8;
				object obj24 = !flag9;
				object obj22 = 0;
				UnityEngine.Object obj23 = null;
				if (obj24 == null)
				{
					return;
				}
			}
			object obj25 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X0_v10+E4]");
			bool flag10 = (nint)0 == 0;
			object obj26 = !flag10;
			if (obj26 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			UnityEngine.Object.Destroy(obj14);
			return;
			IL_0497:
			object obj27 = obj20;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v406 @ X0_v18+8]");
			object obj28 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v269 @ X2_v7 (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
			IL_0145:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag11 = obj9 != null;
			bool flag12 = !flag11;
			obj11 = 0;
			obj8 = obj9;
			obj12 = 0;
			obj13 = null;
			obj14 = null;
			if (!flag12)
			{
				goto IL_019f;
			}
			goto IL_041c;
		}
	}

	private ComponentReference<RectTransform> memberPrefab;

	private ComponentReference<RectTransform> nonMemberPrefab;

	private bool initializeOnStart = true;

	private RectTransform spawnRoot;

	private GameObject _current;

	private bool? _shownInClan;

	private int _generation;

	public static bool IsInClan
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_012c: Expected O, but got I
			//IL_0156: Expected O, but got I4
			//IL_005c: Expected O, but got I
			//IL_01bb: Expected I4, but got O
			//IL_00d8: Expected I4, but got O
			//IL_019f: Expected O, but got I4
			object obj = 152993792;
			object obj2 = typeof(Queue<string>) + 728;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E87CD]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = (nint)0 + (nint)1976;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+E4]");
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
				object obj4 = (nint)0 + (nint)1976;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+E4]");
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
			object obj8 = default(object);
			bool flag3 = obj8 == null;
			object obj9 = !flag3;
			if (obj9 != null)
			{
				goto IL_00b8;
			}
			goto IL_01ad;
			IL_00b8:
			User mySelf = SFS.MySelf;
			bool flag4 = mySelf == null;
			bool result = (byte)(int)mySelf != 0;
			if (!flag4)
			{
				ClanUserModel clanMembership = SFSKammelnaUserExtensions.GetClanMembership(mySelf);
				bool flag5 = clanMembership == null;
				bool flag6 = !flag5;
				result = flag6;
			}
			return result;
			IL_01ad:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_0091:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			object obj10 = default(object);
			if (obj10 != null)
			{
				goto IL_00b8;
			}
			goto IL_01ad;
		}
	}

	private void Start()
	{
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected O, but got Unknown
		//IL_0082: Expected O, but got I
		//IL_0028: Expected I, but got O
		//IL_0053: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1624;
		object obj2 = (nint)0 + (nint)1424;
		if (initializeOnStart)
		{
			InitializeForMembership();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		ClanServerConnector.OnMyMembershipChanged -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)this, (IntPtr)obj2);
		ClanServerConnector.OnMyMembershipChanged += action2;
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_003e: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1624;
		object obj2 = (nint)0 + (nint)1424;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		ClanServerConnector.OnMyMembershipChanged -= action;
	}

	public void InitializeForMembership()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_0097: Expected O, but got I
		//IL_014d: Expected O, but got I4
		//IL_015b: Expected O, but got I4
		//IL_00f2: Expected O, but got I4
		//IL_00fb: Expected O, but got I4
		//IL_01f1: Expected O, but got I4
		//IL_0193: Expected O, but got I4
		//IL_021f: Expected O, but got I4
		//IL_0117: Expected O, but got I4
		//IL_0320: Expected O, but got I4
		//IL_0211: Expected O, but got I4
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Expected O, but got Unknown
		//IL_0253: Expected O, but got I
		//IL_0262: Unknown result type (might be due to invalid IL or missing references)
		//IL_0267: Expected O, but got Unknown
		//IL_033a: Expected O, but got I
		//IL_0355: Expected I, but got O
		//IL_037f: Expected O, but got I4
		object obj = typeof(CardUtils.<>c) + 1208;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = (nint)0 + (nint)2008;
		object obj4 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj5 = obj2 + 24;
		obj5 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		bool isInClan = IsInClan;
		bool? flag = isInClan;
		object obj6 = this + 64;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X22_v4+C]");
		object obj7 = (nint)0 + (nint)1;
		object obj8 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X0_v9+E4]");
		object obj10;
		object obj12;
		if ((nint)0 != 0)
		{
			bool flag2 = (UnityEngine.Object)obj6 != null;
			bool flag3 = !flag2;
			object obj9 = !flag3;
			obj10 = 0;
			UnityEngine.Object obj11 = null;
			if (obj9 != null)
			{
				goto IL_0169;
			}
			obj12 = 0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag4 = (UnityEngine.Object)obj6 != null;
			bool flag5 = !flag4;
			obj10 = 0;
			UnityEngine.Object obj11 = null;
			obj12 = 0;
			if (!flag5)
			{
				goto IL_0169;
			}
		}
		goto IL_01c6;
		IL_01c6:
		_current = null;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		bool flag6 = !isInClan;
		object obj13 = !flag6;
		object obj14 = ~obj13;
		if (obj14 == null)
		{
			object obj15 = 32;
		}
		else
		{
			object obj15 = 40;
		}
		object obj16 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X0_v13+E4]");
		bool flag7 = (nint)0 == 0;
		object obj17 = !flag7;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj18 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2304;
		object obj19 = (nint)0 + (nint)392;
		object obj20 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		if (spawnRoot != null)
		{
			Transform transform = spawnRoot;
			UnityEngine.Object obj21 = null;
		}
		else
		{
			Transform transform2 = base.transform;
			UnityEngine.Object obj21 = null;
			Transform transform = transform2;
		}
		object obj22 = (nint)0 + (nint)2080;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj19);
		object obj23 = obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X0_v20+E4]");
		bool flag8 = (nint)0 == 0;
		object obj24 = !flag8;
		if (obj24 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F80E14");
		return;
		IL_0169:
		object obj25 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X0_v28+E4]");
		bool flag9 = (nint)0 == 0;
		object obj26 = !flag9;
		if (obj26 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		UnityEngine.Object.Destroy((UnityEngine.Object)obj6);
		obj12 = obj10;
		goto IL_01c6;
	}

	private void OnMembershipChanged(ClanUserModel membership)
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		object obj = (??)_shownInClan & 0x100;
		bool flag = membership == null;
		if ((flag ? 1 : 0) != (nint)obj)
		{
			object obj2 = (??)_shownInClan & 1;
			if (obj2 != null)
			{
				return;
			}
		}
		InitializeForMembership();
	}
}
