using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.TextCore;

public class PredictionSeasonRewardPopup : MonoBehaviour
{
	private PopupUI popupUI;

	private RectTransform rewardsContainer;

	private PredictionTopPrize rewardPrefab;

	private GameObject separatorPrefab;

	public unsafe void Show(IEnumerable<PredictionSeasonRewardModel> models)
	{
		//IL_0009: Expected O, but got I4
		//IL_0015: Expected O, but got I
		//IL_002b: Expected O, but got I
		//IL_0266: Expected O, but got I
		//IL_0288: Expected O, but got I4
		//IL_0291: Expected O, but got I4
		//IL_029a: Expected O, but got I4
		//IL_00c3: Expected O, but got I
		//IL_00d9: Expected O, but got I
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_0106: Expected O, but got I
		//IL_006a: Expected O, but got I
		//IL_008a: Expected O, but got I4
		//IL_0093: Expected O, but got I4
		//IL_037c: Expected O, but got I4
		//IL_02d4: Expected O, but got I
		//IL_02e4: Expected O, but got I
		//IL_02fa: Expected O, but got I
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_0308: Expected O, but got Unknown
		//IL_0322: Expected O, but got I4
		//IL_0342: Expected O, but got I
		//IL_0169: Expected O, but got I
		//IL_0179: Expected O, but got I
		//IL_018f: Expected O, but got I
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected O, but got Unknown
		//IL_01c4: Expected O, but got I
		//IL_044a: Expected O, but got I
		//IL_03b4: Expected O, but got I
		//IL_03c4: Expected O, but got I
		//IL_03da: Expected O, but got I
		//IL_03e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e8: Expected O, but got Unknown
		//IL_0402: Expected O, but got I4
		//IL_041a: Expected O, but got I
		//IL_0474: Expected O, but got I4
		//IL_047d: Expected O, but got I4
		//IL_01ea: Expected O, but got I
		//IL_0219: Expected O, but got I4
		//IL_0222: Expected O, but got I4
		//IL_04a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a7: Expected O, but got Unknown
		//IL_04af: Expected I, but got O
		//IL_04bf: Expected O, but got I
		//IL_0592: Expected O, but got I4
		//IL_0239: Expected O, but got I4
		//IL_0ddd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0de2: Expected O, but got Unknown
		//IL_0df1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0df6: Expected O, but got Unknown
		//IL_0e05: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e0a: Expected O, but got Unknown
		//IL_0e16: Expected O, but got I
		//IL_0e26: Expected O, but got I
		//IL_0e3c: Expected O, but got I
		//IL_0e45: Expected O, but got I4
		//IL_0e4d: Expected O, but got Ref
		//IL_04fa: Expected O, but got I
		//IL_0d8e: Expected O, but got I
		//IL_0da0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da5: Expected O, but got Unknown
		//IL_05a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ac: Expected O, but got Unknown
		//IL_05b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ba: Expected O, but got Unknown
		//IL_0c22: Expected O, but got Ref
		//IL_0c2b: Expected O, but got I4
		//IL_0c34: Expected O, but got I4
		//IL_05e7: Expected O, but got I
		//IL_0510: Unknown result type (might be due to invalid IL or missing references)
		//IL_0515: Expected O, but got Unknown
		//IL_052b: Expected O, but got I
		//IL_0536: Unknown result type (might be due to invalid IL or missing references)
		//IL_053b: Expected O, but got Unknown
		//IL_06ba: Expected O, but got I4
		//IL_0eba: Expected O, but got I
		//IL_0ecd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ed2: Expected O, but got Unknown
		//IL_0622: Expected O, but got I
		//IL_0943: Expected O, but got Ref
		//IL_094c: Expected O, but got I4
		//IL_0955: Expected O, but got I4
		//IL_096e: Expected O, but got I4
		//IL_0977: Expected O, but got I4
		//IL_0987: Expected O, but got Ref
		//IL_0998: Expected O, but got I4
		//IL_09b1: Expected O, but got I4
		//IL_09ea: Expected O, but got I4
		//IL_09f3: Expected O, but got I4
		//IL_0e62: Expected O, but got I
		//IL_0e74: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e79: Expected O, but got Unknown
		//IL_0ffe: Expected O, but got I4
		//IL_06dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e2: Expected O, but got Unknown
		//IL_0a10: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a15: Expected O, but got Unknown
		//IL_0a2d: Expected O, but got I
		//IL_0638: Unknown result type (might be due to invalid IL or missing references)
		//IL_063d: Expected O, but got Unknown
		//IL_0653: Expected O, but got I
		//IL_065e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0663: Expected O, but got Unknown
		//IL_0acc: Expected O, but got I4
		//IL_072c: Expected O, but got I
		//IL_10a8: Expected O, but got I
		//IL_0a68: Expected O, but got I
		//IL_07ff: Expected O, but got I4
		//IL_0b40: Expected O, but got I4
		//IL_1074: Expected O, but got I
		//IL_0f4f: Expected O, but got I
		//IL_0f62: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f67: Expected O, but got Unknown
		//IL_0f81: Expected O, but got I4
		//IL_0767: Expected O, but got I
		//IL_0cb2: Expected O, but got I4
		//IL_0cc3: Expected O, but got I4
		//IL_0aef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af4: Expected O, but got Unknown
		//IL_08b8: Expected O, but got I4
		//IL_0eff: Expected O, but got I
		//IL_0f11: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f16: Expected O, but got Unknown
		//IL_0a76: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a7b: Expected O, but got Unknown
		//IL_0a91: Expected O, but got I
		//IL_0822: Unknown result type (might be due to invalid IL or missing references)
		//IL_0827: Expected O, but got Unknown
		//IL_0d42: Expected O, but got I4
		//IL_0c0c: Expected O, but got I4
		//IL_0fb9: Expected O, but got I4
		//IL_077d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0782: Expected O, but got Unknown
		//IL_0798: Expected O, but got I
		//IL_07a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a8: Expected O, but got Unknown
		//IL_091f: Expected O, but got I4
		//IL_086b: Expected O, but got I4
		object obj = 152985600;
		object obj2 = (nint)0 + (nint)3120;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6608]");
		object obj3 = (nint)0 & (nint)1;
		RectTransform rectTransform;
		object obj6;
		RectTransform rectTransform2;
		object obj4;
		object obj7;
		if (obj3 != null)
		{
			rectTransform = rewardsContainer;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X22_v22+38]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X22_v22+38]");
			bool flag = (nint)0 == 0;
			obj6 = 0;
			obj6 = 0;
			obj7 = obj4;
			rectTransform2 = rewardsContainer;
			if (!flag)
			{
				goto IL_00b3;
			}
		}
		else
		{
			_ = 1;
			rectTransform = rewardsContainer;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X22_v22+38]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X22_v22+38]");
			bool flag2 = (nint)0 == 0;
			object obj8 = !flag2;
			obj6 = 0;
			obj6 = 0;
			obj7 = obj4;
			rectTransform2 = rewardsContainer;
			if (obj8 != null)
			{
				goto IL_00b3;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CD24");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X22_v17+38]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X8_v45+10]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X8_v45+10]");
		object obj11 = (nint)0 + (nint)309;
		object obj12 = obj11 & 1;
		bool flag3 = obj12 == null;
		object obj13 = !flag3;
		obj4 = obj7;
		rectTransform = rectTransform2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X8_v45+10]");
		object obj14 = 0;
		if (obj13 != null)
		{
			goto IL_0124;
		}
		goto IL_0350;
		IL_0d73:
		throw new NullReferenceException();
		IL_0dce:
		object obj15 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
		object obj16 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 1032;
		object obj17 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj18 = (nint)0 + (nint)1000;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v405 @ X0_v24+8]");
		PredictionSeasonRewardModel predictionSeasonRewardModel = (PredictionSeasonRewardModel)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v405 @ X0_v24] (should have been resolved before IL gen)");
		object obj19 = (nint)0 + (nint)920;
		PredictionTopPrize predictionTopPrize = (PredictionTopPrize)1;
		object obj20 = (object)(&obj6);
		object obj21 = default(object);
		bool flag5 = default(bool);
		object obj29 = default(object);
		object obj30;
		PredictionTopPrize predictionTopPrize2 = default(PredictionTopPrize);
		PredictionSeasonRewardModel predictionSeasonRewardModel2 = default(PredictionSeasonRewardModel);
		object obj52 = default(object);
		object obj25 = default(object);
		GameObject[] array2 = default(GameObject[]);
		object obj35 = default(object);
		object obj27 = default(object);
		object obj60 = default(object);
		GameObject[] array;
		object obj50;
		object obj23;
		while (true)
		{
			if (obj21 != null)
			{
				object obj22 = obj21;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v477 @ X8_v21+12E]");
				obj23 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v477 @ X8_v21+12E]");
				if ((nint)0 == 0)
				{
					goto IL_06a7;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v477 @ X8_v21+B0]");
				object obj24 = (nint)0 + (nint)8;
				bool flag4 = flag5;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v530 @ X10_v24-8]");
					obj25 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v530 @ X10_v24-8]");
					object obj26 = 0 - obj15;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v530 @ X10_v24-8]");
					if (0 == (nint)obj15)
					{
						break;
					}
					obj27 = obj24 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v477 @ X8_v21+12E]");
					obj23 = -1;
					obj26 = obj23 - 1;
					bool flag6 = obj26 == null;
					flag5 = (nint)obj23 != 1;
					flag4 = flag5;
					obj24 = obj27;
					if (flag5)
					{
						continue;
					}
					goto IL_06a7;
				}
				obj23 = obj24;
				object obj28 = obj22 + obj24;
				obj29 = obj28 + 312;
				flag5 = flag4;
				obj27 = obj24;
				goto IL_0ea2;
			}
			NullReferenceException ex = new NullReferenceException();
			array = (GameObject[])(object)predictionSeasonRewardModel;
			goto IL_0c19;
			IL_0ab9:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			obj30 = 0;
			goto IL_1098;
			IL_07ec:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			obj30 = 0;
			goto IL_0f3f;
			IL_0f3f:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v799 @ X0_v34+8]");
			RectTransform rectTransform3 = (RectTransform)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v799 @ X0_v34] (should have been resolved before IL gen)");
			object obj31 = predictionTopPrize & 1;
			bool flag7 = obj31 == null;
			object obj32 = !flag7;
			if (obj32 == null)
			{
				object obj33 = obj17;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v837 @ X0_v45+E4]");
				bool flag8 = (nint)0 == 0;
				object obj34 = !flag8;
				if (obj34 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				obj35 = obj19;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9DE4");
				obj30 = 0;
				rectTransform3 = rewardsContainer;
			}
			array2 = (GameObject[])(object)rewardsContainer;
			predictionTopPrize = rewardPrefab;
			object obj36 = obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v828 @ X0_v38+E4]");
			bool flag9 = (nint)0 == 0;
			object obj37 = !flag9;
			if (obj37 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			obj35 = obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9DE4");
			if ((object)predictionTopPrize2 != null)
			{
				predictionTopPrize2.Populate(predictionSeasonRewardModel2);
				predictionTopPrize = null;
				obj30 = 0;
				predictionSeasonRewardModel = predictionSeasonRewardModel2;
				continue;
			}
			NullReferenceException ex2 = new NullReferenceException();
			obj30 = 0;
			array = array2;
			goto IL_0c19;
			IL_0fe4:
			object obj38;
			object obj41;
			object obj42;
			object obj43;
			object obj44;
			object obj46;
			object obj47;
			PredictionTopPrize predictionTopPrize3;
			GameObject[] array3;
			object obj48;
			object obj49;
			object obj51;
			object obj55;
			object obj56;
			object obj57;
			object obj40;
			object obj54;
			object obj45;
			while (true)
			{
				bool flag10 = obj38 == null;
				object obj39 = !flag10;
				obj40 = obj41;
				obj25 = obj42;
				obj16 = obj43;
				obj18 = obj44;
				obj45 = obj46;
				obj15 = obj47;
				predictionTopPrize = predictionTopPrize3;
				array2 = array3;
				obj35 = obj48;
				obj27 = obj49;
				obj50 = obj30;
				if (obj39 != null)
				{
					OutOfMemoryException ex3 = new OutOfMemoryException();
					if ((nint)array == 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
						obj51 = obj52;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
						bool flag11 = obj6 == null;
						object obj53 = !flag11;
						obj54 = obj52;
						obj55 = 0;
						obj56 = obj6;
						if (obj53 == null)
						{
							obj41 = obj40;
							obj42 = obj25;
							obj54 = obj52;
							obj43 = obj16;
							obj44 = obj18;
							obj46 = obj45;
							obj47 = obj15;
							predictionTopPrize3 = predictionTopPrize;
							array3 = array2;
							obj48 = obj35;
							obj49 = obj27;
							obj30 = obj50;
							obj57 = 0;
							obj38 = obj52;
							continue;
						}
						goto IL_0a01;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99C14");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
					return;
				}
				break;
			}
			if ((nint)obj57 != 5)
			{
				bool flag12 = obj57 == null;
				object obj58 = !flag12;
				if (obj58 != null)
				{
					return;
				}
			}
			bool flag13 = (object)popupUI == null;
			obj40 = obj41;
			obj25 = obj42;
			obj16 = obj43;
			obj18 = obj44;
			obj45 = obj46;
			obj15 = obj47;
			predictionTopPrize = predictionTopPrize3;
			array2 = array3;
			obj35 = obj48;
			obj27 = obj49;
			obj50 = obj30;
			if (flag13)
			{
				break;
			}
			popupUI.PopFromCenter();
			return;
			IL_06a7:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			obj30 = 0;
			goto IL_0ea2;
			IL_0ea2:
			obj20 = obj29;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v607 @ X0_v30+8]");
			array = (GameObject[])0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v607 @ X0_v30] (should have been resolved before IL gen)");
			object obj59 = obj60 & 1;
			if (obj59 != null)
			{
				if (obj21 != null)
				{
					object obj61 = obj21;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v730 @ X8_v24+12E]");
					obj23 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v730 @ X8_v24+12E]");
					if ((nint)0 == 0)
					{
						goto IL_07ec;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v730 @ X8_v24+B0]");
					object obj62 = (nint)0 + (nint)8;
					bool flag14 = flag5;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v783 @ X10_v19-8]");
						obj25 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v783 @ X10_v19-8]");
						object obj26 = 0 - obj16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v783 @ X10_v19-8]");
						if (0 == (nint)obj16)
						{
							break;
						}
						obj27 = obj62 + 16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v730 @ X8_v24+12E]");
						obj23 = -1;
						obj26 = obj23 - 1;
						bool flag6 = obj26 == null;
						flag5 = (nint)obj23 != 1;
						flag14 = flag5;
						obj62 = obj27;
						if (flag5)
						{
							continue;
						}
						goto IL_07ec;
					}
					obj23 = obj62;
					object obj63 = obj61 + obj62;
					object obj64 = obj63 + 312;
					flag5 = flag14;
					obj27 = obj62;
					goto IL_0f3f;
				}
				NullReferenceException ex4 = new NullReferenceException();
				goto IL_0c19;
			}
			bool flag15 = obj21 == null;
			obj40 = (object)(&obj6);
			obj54 = 0;
			obj45 = 152985600;
			obj50 = obj30;
			obj6 = obj21;
			obj55 = 5;
			obj51 = 0;
			obj56 = obj21;
			obj41 = (object)(&obj6);
			obj42 = obj25;
			obj54 = 0;
			obj43 = obj16;
			obj44 = obj18;
			obj46 = 152985600;
			obj47 = obj15;
			predictionTopPrize3 = predictionTopPrize;
			array3 = array2;
			obj48 = obj35;
			obj49 = obj27;
			obj6 = obj21;
			obj57 = 5;
			obj38 = 0;
			if (!flag15)
			{
				goto IL_0a01;
			}
			goto IL_0fe4;
			IL_1098:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v740 @ X0_v17+8]");
			array = (GameObject[])0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v740 @ X0_v17] (should have been resolved before IL gen)");
			obj41 = obj40;
			obj42 = obj25;
			obj43 = obj16;
			obj44 = obj18;
			obj46 = obj45;
			obj47 = obj15;
			predictionTopPrize3 = predictionTopPrize;
			array3 = array2;
			obj48 = obj35;
			obj49 = obj27;
			obj57 = obj55;
			obj38 = obj51;
			goto IL_0fe4;
			IL_0a01:
			object obj65 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
			object obj66 = obj56;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v600 @ X8_v8+12E]");
			obj23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v600 @ X8_v8+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0ab9;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v600 @ X8_v8+B0]");
			object obj67 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v718 @ X10_v9-8]");
				obj25 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v718 @ X10_v9-8]");
				if (0 == (nint)obj65)
				{
					break;
				}
				obj27 = obj67 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v600 @ X8_v8+12E]");
				obj23 = -1;
				bool flag16 = (nint)obj23 != 1;
				obj67 = obj27;
				if (flag16)
				{
					continue;
				}
				goto IL_0ab9;
			}
			obj23 = obj67;
			object obj68 = obj66 + obj67;
			object obj69 = obj68 + 312;
			obj27 = obj67;
			obj30 = obj50;
			goto IL_1098;
			IL_0c19:
			obj40 = (object)(&obj6);
			obj54 = 0;
			obj45 = 152985600;
			obj50 = obj30;
			obj6 = obj21;
			break;
		}
		goto IL_0d73;
		IL_057f:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		obj30 = 0;
		goto IL_0dce;
		IL_00b3:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v58+10]");
		obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v58+10]");
		object obj70 = (nint)0 + (nint)309;
		object obj71 = obj70 & 1;
		bool flag17 = obj71 == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v58+10]");
		obj14 = 0;
		obj7 = obj4;
		rectTransform2 = rectTransform;
		if (!flag17)
		{
			goto IL_0124;
		}
		goto IL_0350;
		IL_0350:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X0_v66+E4]");
		bool flag18 = (nint)0 == 0;
		object obj72 = !flag18;
		obj4 = obj7;
		rectTransform = rectTransform2;
		if (obj72 != null)
		{
			goto IL_0159;
		}
		goto IL_039a;
		IL_0124:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X0_v66+E4]");
		bool flag19 = (nint)0 == 0;
		obj7 = obj4;
		rectTransform2 = rectTransform;
		if (!flag19)
		{
			goto IL_0159;
		}
		goto IL_039a;
		IL_039a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X22_v17+38]");
		object obj73 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v39+10]");
		object obj74 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v39+10]");
		object obj75 = (nint)0 + (nint)309;
		object obj76 = obj75 & 1;
		bool flag20 = obj76 == null;
		object obj77 = !flag20;
		Transform transform = rectTransform2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v39+10]");
		object obj78 = 0;
		Transform transform2 = rectTransform2;
		if (obj77 != null)
		{
			goto IL_01da;
		}
		goto IL_0430;
		IL_0159:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X22_v22+38]");
		object obj79 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X8_v53+10]");
		obj74 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X8_v53+10]");
		object obj80 = (nint)0 + (nint)309;
		object obj81 = obj80 & 1;
		bool flag21 = obj81 == null;
		transform = rectTransform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X8_v53+10]");
		obj78 = 0;
		transform2 = rectTransform;
		if (!flag21)
		{
			goto IL_01da;
		}
		goto IL_0430;
		IL_0430:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X0_v64+B8]");
		obj20 = 0;
		UIExtensions.DestroyAllChildren(transform2, (GameObject[])obj20);
		bool flag22 = models == null;
		obj30 = 0;
		obj50 = 0;
		array = (GameObject[])obj20;
		if (!flag22)
		{
			goto IL_0493;
		}
		goto IL_0d73;
		IL_01da:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v96+B8]");
		obj20 = 0;
		array = (GameObject[])obj20;
		UIExtensions.DestroyAllChildren(transform, (GameObject[])obj20);
		bool flag23 = models == null;
		object obj82 = !flag23;
		obj30 = 0;
		if (obj82 != null)
		{
			goto IL_0493;
		}
		obj50 = 0;
		goto IL_0d73;
		IL_0493:
		object obj83 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 3600;
		nint num = (nint)models;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X8_v15 (Il2CppClass<System.Collections.Generic.IEnumerable`1<PredictionSeasonRewardModel>>)+12E]");
		obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X8_v15 (Il2CppClass<System.Collections.Generic.IEnumerable`1<PredictionSeasonRewardModel>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_057f;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X8_v15 (Il2CppClass<System.Collections.Generic.IEnumerable`1<PredictionSeasonRewardModel>>)+B0]");
		object obj84 = (nint)0 + (nint)8;
		bool flag24 = flag5;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ X10_v29-8]");
			obj25 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ X10_v29-8]");
			object obj26 = 0 - obj83;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ X10_v29-8]");
			if (0 == (nint)obj83)
			{
				break;
			}
			obj27 = obj84 + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X8_v15 (Il2CppClass<System.Collections.Generic.IEnumerable`1<PredictionSeasonRewardModel>>)+12E]");
			obj23 = -1;
			obj26 = obj23 - 1;
			bool flag6 = obj26 == null;
			flag5 = (nint)obj23 != 1;
			flag24 = flag5;
			obj84 = obj27;
			if (flag5)
			{
				continue;
			}
			goto IL_057f;
		}
		obj23 = obj84;
		object obj85 = num + obj84;
		object obj86 = obj85 + 312;
		flag5 = flag24;
		obj27 = obj84;
		goto IL_0dce;
	}

	private void AddHeader()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_003f: Expected O, but got I
		//IL_0069: Expected O, but got I4
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = (nint)0 + (nint)920;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9DE4");
	}
}
