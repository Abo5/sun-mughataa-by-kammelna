using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using Server.Models;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.TextCore;

public class GroupUserFeedsPopup : MonoBehaviour
{
	private PopupUI popupUi;

	private RectTransform itemsList;

	private UserFeedItemUI feedItemPrefab;

	public unsafe void Show(IEnumerable<UserFeedItem> feedItems)
	{
		//IL_0009: Expected O, but got I4
		//IL_0015: Expected O, but got I
		//IL_002b: Expected O, but got I
		//IL_026e: Expected O, but got I
		//IL_0290: Expected O, but got I4
		//IL_0299: Expected O, but got I4
		//IL_02a2: Expected O, but got I4
		//IL_00c3: Expected O, but got I
		//IL_00d9: Expected O, but got I
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_0106: Expected O, but got I
		//IL_006a: Expected O, but got I
		//IL_008a: Expected O, but got I4
		//IL_0093: Expected O, but got I4
		//IL_0384: Expected O, but got I4
		//IL_02dc: Expected O, but got I
		//IL_02ec: Expected O, but got I
		//IL_0302: Expected O, but got I
		//IL_030b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0310: Expected O, but got Unknown
		//IL_032a: Expected O, but got I4
		//IL_034a: Expected O, but got I
		//IL_0169: Expected O, but got I
		//IL_0179: Expected O, but got I
		//IL_018f: Expected O, but got I
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected O, but got Unknown
		//IL_01c4: Expected O, but got I
		//IL_0452: Expected O, but got I
		//IL_03bc: Expected O, but got I
		//IL_03cc: Expected O, but got I
		//IL_03e2: Expected O, but got I
		//IL_03eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f0: Expected O, but got Unknown
		//IL_040a: Expected O, but got I4
		//IL_0422: Expected O, but got I
		//IL_047c: Expected O, but got I4
		//IL_0485: Expected O, but got I4
		//IL_01f2: Expected O, but got I
		//IL_0221: Expected O, but got I4
		//IL_022a: Expected O, but got I4
		//IL_04aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_04af: Expected O, but got Unknown
		//IL_04b7: Expected I, but got O
		//IL_04c7: Expected O, but got I
		//IL_059a: Expected O, but got I4
		//IL_0241: Expected O, but got I4
		//IL_0ce9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cee: Expected O, but got Unknown
		//IL_0cfd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d02: Expected O, but got Unknown
		//IL_0d11: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d16: Expected O, but got Unknown
		//IL_0d22: Expected O, but got I
		//IL_0d32: Expected O, but got I
		//IL_0d45: Expected O, but got Ref
		//IL_0502: Expected O, but got I
		//IL_0cac: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb1: Expected O, but got Unknown
		//IL_05af: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b4: Expected O, but got Unknown
		//IL_05bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c2: Expected O, but got Unknown
		//IL_0bf8: Expected O, but got I4
		//IL_05ef: Expected O, but got I
		//IL_0518: Unknown result type (might be due to invalid IL or missing references)
		//IL_051d: Expected O, but got Unknown
		//IL_0533: Expected O, but got I
		//IL_053e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0543: Expected O, but got Unknown
		//IL_06c2: Expected O, but got I4
		//IL_0da3: Expected O, but got I
		//IL_0db6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dbb: Expected O, but got Unknown
		//IL_062a: Expected O, but got I
		//IL_0a02: Expected O, but got I4
		//IL_0a1c: Expected O, but got I4
		//IL_0d5d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d62: Expected O, but got Unknown
		//IL_06e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ea: Expected O, but got Unknown
		//IL_0ec7: Expected O, but got I4
		//IL_0640: Unknown result type (might be due to invalid IL or missing references)
		//IL_0645: Expected O, but got Unknown
		//IL_065b: Expected O, but got I
		//IL_0666: Unknown result type (might be due to invalid IL or missing references)
		//IL_066b: Expected O, but got Unknown
		//IL_0a30: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a35: Expected O, but got Unknown
		//IL_0a4d: Expected O, but got I
		//IL_072b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0730: Expected O, but got Unknown
		//IL_0748: Expected O, but got I
		//IL_0aec: Expected O, but got I4
		//IL_081b: Expected O, but got I4
		//IL_0f09: Expected O, but got I
		//IL_0a88: Expected O, but got I
		//IL_0783: Expected O, but got I
		//IL_0bac: Expected O, but got I4
		//IL_0dea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0def: Expected O, but got Unknown
		//IL_0b0f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b14: Expected O, but got Unknown
		//IL_0870: Expected O, but got I4
		//IL_083e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0843: Expected O, but got Unknown
		//IL_0a96: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a9b: Expected O, but got Unknown
		//IL_0ab1: Expected O, but got I
		//IL_08cd: Expected O, but got I
		//IL_0799: Unknown result type (might be due to invalid IL or missing references)
		//IL_079e: Expected O, but got Unknown
		//IL_07b4: Expected O, but got I
		//IL_07bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c4: Expected O, but got Unknown
		//IL_0896: Expected O, but got I
		//IL_08fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0900: Expected O, but got Unknown
		//IL_0934: Expected O, but got I
		//IL_0956: Expected O, but got I4
		//IL_0bc3: Expected O, but got I4
		//IL_0b90: Expected O, but got I4
		//IL_09dd: Expected O, but got I
		//IL_0e5a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e5f: Expected O, but got Unknown
		//IL_09eb: Expected O, but got I4
		object obj = 152985600;
		object obj2 = (nint)0 + (nint)3120;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E63BC]");
		object obj3 = (nint)0 & (nint)1;
		RectTransform rectTransform;
		Component component;
		object obj5;
		RectTransform rectTransform2;
		Component component2;
		if (obj3 != null)
		{
			rectTransform = itemsList;
			component = (Component)obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X22_v9 (UnityEngine.Component)+38]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X22_v9 (UnityEngine.Component)+38]");
			bool flag = (nint)0 == 0;
			obj5 = 0;
			obj5 = 0;
			component2 = component;
			rectTransform2 = itemsList;
			if (!flag)
			{
				goto IL_00b3;
			}
		}
		else
		{
			_ = 1;
			rectTransform = itemsList;
			component = (Component)obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X22_v9 (UnityEngine.Component)+38]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X22_v9 (UnityEngine.Component)+38]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			obj5 = 0;
			obj5 = 0;
			component2 = component;
			rectTransform2 = itemsList;
			if (obj6 != null)
			{
				goto IL_00b3;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CD24");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X22_v3 (UnityEngine.Component)+38]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X8_v48+10]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X8_v48+10]");
		object obj9 = (nint)0 + (nint)309;
		object obj10 = obj9 & 1;
		bool flag3 = obj10 == null;
		object obj11 = !flag3;
		component = component2;
		rectTransform = rectTransform2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X8_v48+10]");
		object obj12 = 0;
		if (obj11 != null)
		{
			goto IL_0124;
		}
		goto IL_0358;
		IL_0c8e:
		throw new NullReferenceException();
		IL_0cda:
		object obj13 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
		object obj14 = typeof(SqlSingle[]) + 480;
		object obj15 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj16 = (nint)0 + (nint)880;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ X0_v23+8]");
		UserFeedItem userFeedItem = (UserFeedItem)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v400 @ X0_v23] (should have been resolved before IL gen)");
		object obj17 = (object)(&obj5);
		object obj18 = default(object);
		bool flag5 = default(bool);
		object obj25 = default(object);
		object obj27 = default(object);
		object obj32 = default(object);
		object obj35;
		object obj43 = default(object);
		object obj44 = default(object);
		Component component3 = default(Component);
		object obj45 = default(object);
		Component component4 = default(Component);
		GameObject[] array;
		object obj34;
		object obj20;
		object obj23;
		while (true)
		{
			if (obj18 != null)
			{
				object obj19 = obj18;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v471 @ X8_v21+12E]");
				obj20 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v471 @ X8_v21+12E]");
				if ((nint)0 == 0)
				{
					goto IL_06af;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v471 @ X8_v21+B0]");
				object obj21 = (nint)0 + (nint)8;
				bool flag4 = flag5;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v520 @ X10_v24-8]");
					object obj22 = 0 - obj13;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v520 @ X10_v24-8]");
					if (0 == (nint)obj13)
					{
						break;
					}
					obj23 = obj21 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v471 @ X8_v21+12E]");
					obj20 = -1;
					obj22 = obj20 - 1;
					bool flag6 = obj22 == null;
					flag5 = (nint)obj20 != 1;
					flag4 = flag5;
					obj21 = obj23;
					if (flag5)
					{
						continue;
					}
					goto IL_06af;
				}
				obj20 = obj21;
				object obj24 = obj19 + obj21;
				obj25 = obj24 + 312;
				flag5 = flag4;
				obj23 = obj21;
				goto IL_0d8b;
			}
			NullReferenceException ex = new NullReferenceException();
			array = (GameObject[])(object)userFeedItem;
			goto IL_0bed;
			IL_0d8b:
			obj17 = obj25;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v597 @ X0_v29+8]");
			array = (GameObject[])0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v597 @ X0_v29] (should have been resolved before IL gen)");
			object obj26 = obj27 & 1;
			if (obj26 != null)
			{
				if (obj18 != null)
				{
					object obj28 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 1320;
					object obj29 = obj18;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v703 @ X8_v26+12E]");
					obj20 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v703 @ X8_v26+12E]");
					if ((nint)0 == 0)
					{
						goto IL_0808;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v703 @ X8_v26+B0]");
					object obj30 = (nint)0 + (nint)8;
					bool flag7 = flag5;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v773 @ X10_v19-8]");
						object obj22 = 0 - obj28;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v773 @ X10_v19-8]");
						if (0 == (nint)obj28)
						{
							break;
						}
						obj23 = obj30 + 16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v703 @ X8_v26+12E]");
						obj20 = -1;
						obj22 = obj20 - 1;
						bool flag6 = obj22 == null;
						flag5 = (nint)obj20 != 1;
						flag7 = flag5;
						obj30 = obj23;
						if (flag5)
						{
							continue;
						}
						goto IL_0808;
					}
					obj20 = obj30;
					object obj31 = obj29 + obj30;
					obj32 = obj31 + 312;
					flag5 = flag7;
					obj23 = obj30;
					goto IL_0e18;
				}
				NullReferenceException ex2 = new NullReferenceException();
				goto IL_0bed;
			}
			object obj33 = 0;
			obj34 = obj35;
			obj5 = obj18;
			object obj36 = 0;
			while (true)
			{
				if (obj5 == null)
				{
					goto IL_0ead;
				}
				object obj37 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
				object obj38 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v604 @ X8_v6+12E]");
				obj20 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v604 @ X8_v6+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0ad9;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v604 @ X8_v6+B0]");
				object obj39 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v716 @ X10_v7-8]");
					if (0 == (nint)obj37)
					{
						break;
					}
					obj23 = obj39 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v604 @ X8_v6+12E]");
					obj20 = -1;
					bool flag8 = (nint)obj20 != 1;
					obj39 = obj23;
					if (flag8)
					{
						continue;
					}
					goto IL_0ad9;
				}
				obj20 = obj39;
				object obj40 = obj38 + obj39;
				object obj41 = obj40 + 312;
				obj23 = obj39;
				goto IL_0ef9;
				IL_0ead:
				bool flag9 = obj36 == null;
				object obj42 = !flag9;
				if (obj42 != null)
				{
					OutOfMemoryException ex3 = new OutOfMemoryException();
					if ((nint)array == 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
						obj36 = obj43;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
						obj33 = obj43;
						continue;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99C14");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
					return;
				}
				break;
				IL_0ad9:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				obj34 = 0;
				goto IL_0ef9;
				IL_0ef9:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v760 @ X0_v4+8]");
				array = (GameObject[])0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v760 @ X0_v4] (should have been resolved before IL gen)");
				goto IL_0ead;
			}
			if ((object)popupUi == null)
			{
				break;
			}
			popupUi.PopFromCenter();
			return;
			IL_0e18:
			obj17 = obj32;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v788 @ X0_v33] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
			if (obj44 != null)
			{
				bool flag10 = (object)component3 == null;
				array = (GameObject[])1;
				if (!flag10)
				{
					obj17 = obj44;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X8_v3+40]");
					array = (GameObject[])0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					if (obj45 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
						OutOfMemoryException ex4 = new OutOfMemoryException();
						array = null;
						goto IL_0bed;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v794 @ X0_v37+18]");
				obj17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v794 @ X0_v37+18]");
				if ((nint)0 != 0)
				{
					object obj46 = obj44 + 32;
					obj46 = component3;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					GameObject[] array2 = (GameObject[])(object)itemsList;
					object obj47 = obj15;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v808 @ X0_v44+E4]");
					obj17 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v808 @ X0_v44+E4]");
					bool flag11 = (nint)0 == 0;
					object obj48 = !flag11;
					if (obj48 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9DE4");
					if ((object)component4 != null)
					{
						Transform transform = component4.transform;
						if ((object)transform != null)
						{
							transform.SetAsFirstSibling();
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E63B8]");
							obj17 = 0;
							array2 = (GameObject[])(component4 + 128);
							array2 = (GameObject[])obj44;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							object obj49 = Enumerable.First((IEnumerable<object>)array2);
							((BaseUserFeedItemUI)component4).Populate((UserFeedItem)obj49);
							obj35 = 0;
							userFeedItem = (UserFeedItem)obj49;
							continue;
						}
						NullReferenceException ex5 = new NullReferenceException();
						obj35 = 0;
						array = null;
					}
					else
					{
						NullReferenceException ex6 = new NullReferenceException();
						obj35 = 0;
						array = array2;
					}
				}
				else
				{
					IndexOutOfRangeException ex7 = new IndexOutOfRangeException();
				}
			}
			else
			{
				NullReferenceException ex8 = new NullReferenceException();
				array = (GameObject[])1;
			}
			goto IL_0bed;
			IL_0808:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			obj35 = 0;
			goto IL_0e18;
			IL_0bed:
			obj33 = 0;
			obj34 = obj35;
			obj5 = obj18;
			break;
			IL_06af:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			obj35 = 0;
			goto IL_0d8b;
		}
		goto IL_0c8e;
		IL_0587:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		obj35 = 0;
		goto IL_0cda;
		IL_00b3:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v61+10]");
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v61+10]");
		object obj50 = (nint)0 + (nint)309;
		object obj51 = obj50 & 1;
		bool flag12 = obj51 == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v61+10]");
		obj12 = 0;
		component2 = component;
		rectTransform2 = rectTransform;
		if (!flag12)
		{
			goto IL_0124;
		}
		goto IL_0358;
		IL_0358:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X0_v77+E4]");
		bool flag13 = (nint)0 == 0;
		object obj52 = !flag13;
		component = component2;
		rectTransform = rectTransform2;
		if (obj52 != null)
		{
			goto IL_0159;
		}
		goto IL_03a2;
		IL_0124:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X0_v77+E4]");
		bool flag14 = (nint)0 == 0;
		component2 = component;
		rectTransform2 = rectTransform;
		if (!flag14)
		{
			goto IL_0159;
		}
		goto IL_03a2;
		IL_03a2:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X22_v3 (UnityEngine.Component)+38]");
		object obj53 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v42+10]");
		object obj54 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v42+10]");
		object obj55 = (nint)0 + (nint)309;
		object obj56 = obj55 & 1;
		bool flag15 = obj56 == null;
		object obj57 = !flag15;
		Transform transform2 = rectTransform2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v42+10]");
		object obj58 = 0;
		Transform transform3 = rectTransform2;
		if (obj57 != null)
		{
			goto IL_01e2;
		}
		goto IL_0438;
		IL_0159:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X22_v9 (UnityEngine.Component)+38]");
		object obj59 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X8_v56+10]");
		obj54 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X8_v56+10]");
		object obj60 = (nint)0 + (nint)309;
		object obj61 = obj60 & 1;
		bool flag16 = obj61 == null;
		transform2 = rectTransform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X8_v56+10]");
		obj58 = 0;
		component2 = component;
		transform3 = rectTransform;
		if (!flag16)
		{
			goto IL_01e2;
		}
		goto IL_0438;
		IL_0438:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X0_v75+B8]");
		obj17 = 0;
		UIExtensions.DestroyAllChildren(transform3, (GameObject[])obj17);
		bool flag17 = feedItems == null;
		obj35 = 0;
		obj34 = 0;
		array = (GameObject[])obj17;
		if (!flag17)
		{
			goto IL_049b;
		}
		goto IL_0c8e;
		IL_01e2:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v110+B8]");
		obj17 = 0;
		array = (GameObject[])obj17;
		UIExtensions.DestroyAllChildren(transform2, (GameObject[])obj17);
		bool flag18 = feedItems == null;
		object obj62 = !flag18;
		obj35 = 0;
		if (obj62 != null)
		{
			goto IL_049b;
		}
		obj34 = 0;
		goto IL_0c8e;
		IL_049b:
		object obj63 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 3856;
		nint num = (nint)feedItems;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X8_v15 (Il2CppClass<System.Collections.Generic.IEnumerable`1<Server.Models.UserFeedItem>>)+12E]");
		obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X8_v15 (Il2CppClass<System.Collections.Generic.IEnumerable`1<Server.Models.UserFeedItem>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0587;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X8_v15 (Il2CppClass<System.Collections.Generic.IEnumerable`1<Server.Models.UserFeedItem>>)+B0]");
		object obj64 = (nint)0 + (nint)8;
		bool flag19 = flag5;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v370 @ X10_v29-8]");
			object obj22 = 0 - obj63;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v370 @ X10_v29-8]");
			if (0 == (nint)obj63)
			{
				break;
			}
			obj23 = obj64 + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X8_v15 (Il2CppClass<System.Collections.Generic.IEnumerable`1<Server.Models.UserFeedItem>>)+12E]");
			obj20 = -1;
			obj22 = obj20 - 1;
			bool flag6 = obj22 == null;
			flag5 = (nint)obj20 != 1;
			flag19 = flag5;
			obj64 = obj23;
			if (flag5)
			{
				continue;
			}
			goto IL_0587;
		}
		obj20 = obj64;
		object obj65 = num + obj64;
		object obj66 = obj65 + 312;
		flag5 = flag19;
		obj23 = obj64;
		goto IL_0cda;
	}
}
