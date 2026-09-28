using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json.Linq.JsonPath;
using Server.Models;
using TMPro;
using Unity.Properties;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.UI;

public class PredictionTopPrize : MonoBehaviour
{
	private TextMeshProUGUI placeText;

	private TextMeshProUGUI compositeText;

	private GameObject goldContainer;

	private GameObject titleContainer;

	private GameObject trophyContainer;

	private TextMeshProUGUI goldText;

	private Image titleIcon;

	private Image trophyIcon;

	public unsafe void Populate(PredictionSeasonRewardModel reward)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0111: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Expected O, but got Unknown
		//IL_0307: Expected O, but got I4
		//IL_032d: Expected O, but got Ref
		//IL_01e2: Expected O, but got I4
		//IL_054b: Expected O, but got I4
		//IL_0208: Expected O, but got Ref
		//IL_0352: Expected O, but got Ref
		//IL_022d: Expected O, but got Ref
		//IL_05d7: Expected O, but got I4
		//IL_0368: Expected I, but got O
		//IL_0378: Expected O, but got I
		//IL_03a1: Expected O, but got I
		//IL_0640: Expected I4, but got O
		//IL_03df: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e4: Expected O, but got Unknown
		//IL_0243: Expected I, but got O
		//IL_0253: Expected O, but got I
		//IL_027c: Expected O, but got I
		//IL_0799: Expected O, but got I4
		//IL_07a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a6: Expected I4, but got Unknown
		//IL_07c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c9: Expected O, but got Unknown
		//IL_041d: Expected O, but got Ref
		//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bf: Expected O, but got Unknown
		//IL_02db: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e0: Expected O, but got Unknown
		//IL_0b5b: Expected O, but got I4
		//IL_067b: Expected O, but got I4
		//IL_0a01: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a06: Expected O, but got Unknown
		//IL_0a30: Expected O, but got I4
		//IL_07e8: Expected O, but got I4
		//IL_080e: Expected O, but got Ref
		//IL_048e: Expected O, but got I8
		//IL_0433: Expected I, but got O
		//IL_0443: Expected O, but got I
		//IL_046c: Expected O, but got I
		//IL_0833: Expected O, but got Ref
		//IL_04bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c1: Expected O, but got Unknown
		//IL_04dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e2: Expected O, but got Unknown
		//IL_0adb: Expected O, but got I4
		//IL_0ae4: Expected O, but got I4
		//IL_0af6: Expected O, but got I4
		//IL_0aff: Expected O, but got I4
		//IL_0849: Expected I, but got O
		//IL_0859: Expected O, but got I
		//IL_0887: Expected O, but got I
		//IL_08ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_08cf: Expected O, but got Unknown
		//IL_08eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f0: Expected O, but got Unknown
		//IL_0944: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6501]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v93+E4]");
			bool flag = (nint)0 == 0;
			obj5 = placeText;
			obj6 = placeText;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj5 = placeText;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v93+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = placeText;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6 != null;
		bool flag4 = !flag3;
		object[] array = null;
		UnityEngine.Object obj8 = null;
		object[] array2 = null;
		if (!flag4)
		{
			goto IL_016e;
		}
		goto IL_04ef;
		IL_09cd:
		bool flag5 = reward == null;
		Action<bool> action2;
		Action<bool> action = action2;
		int num;
		UnityEngine.Object obj12;
		object obj16;
		Action<bool> action3;
		UnityEngine.Object obj17;
		object obj13;
		object obj15 = default(object);
		string titleId;
		if (!flag5)
		{
			object obj9 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
			object obj10 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X8_v17+E4]");
			bool flag6 = (nint)0 == 0;
			object obj11 = !flag6;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag7 = StringsExtensions.IsNullOrEmpty(reward.titleId);
			bool flag8 = (object)titleContainer == null;
			action = action2;
			obj8 = null;
			if (!flag8)
			{
				bool active = (byte)((flag7 ? 1u : 0u) ^ 1u) != 0;
				titleContainer.SetActive(active);
				titleId = reward.titleId;
				num = reward.titleLevelId;
				UIExtensions.LoadAchievementImage(titleIcon, reward.titleId, reward.titleLevelId);
				obj12 = trophyContainer;
				obj13 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v658 @ X8_v13+E4]");
				bool flag9 = (nint)0 == 0;
				object obj14 = !flag9;
				obj15 = 0;
				action = null;
				array2 = (object[])reward.titleLevelId;
				obj16 = 0;
				action3 = null;
				obj17 = trophyContainer;
				if (obj14 != null)
				{
					goto IL_0658;
				}
				goto IL_0b1c;
			}
		}
		goto IL_0c5c;
		IL_05b4:
		UnityEngine.Object obj18;
		bool flag10 = obj18;
		bool flag11 = !flag10;
		object obj19 = !flag11;
		titleId = null;
		action2 = action;
		array = array2;
		obj8 = null;
		if (obj19 == null)
		{
			goto IL_05ff;
		}
		goto IL_09cd;
		IL_0b6e:
		bool flag12 = reward == null;
		array = array2;
		if (!flag12)
		{
			bool flag13 = (object)trophyContainer == null;
			array = array2;
			if (!flag13)
			{
				bool flag14 = reward.trophyImage == null;
				bool active2 = !flag14;
				trophyContainer.SetActive(active2);
				FileInfoModel trophyImage = reward.trophyImage;
				if (reward.trophyImage != null)
				{
					UIExtensions.LoadImage(timestamp: trophyImage.<lastModified>k__BackingField, img: trophyIcon, imageId: trophyImage.<url>k__BackingField, url: trophyImage.<url>k__BackingField);
				}
				return;
			}
		}
		goto IL_0c5c;
		IL_0091:
		bool flag15 = obj5 != null;
		bool flag16 = !flag15;
		object obj20 = !flag16;
		array = null;
		obj8 = null;
		if (obj20 != null)
		{
			goto IL_016e;
		}
		array2 = null;
		goto IL_04ef;
		IL_016e:
		if (reward == null)
		{
			goto IL_0c5c;
		}
		object obj21 = typeof(TypeConverter<ushort, char>) + 3400;
		int num2 = default(int);
		object text;
		object[] array4;
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		if (reward.place == reward.place2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
			object obj22 = 153100288 + 1024;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			object[] array3 = default(object[]);
			bool flag17 = array3 == null;
			obj8 = (UnityEngine.Object)(&num2);
			if (flag17)
			{
				goto IL_0c5c;
			}
			object obj23 = default(object);
			bool flag18 = obj23 == null;
			UnityEngine.Object obj24 = (UnityEngine.Object)(&num2);
			if (!flag18)
			{
				nint num3 = (nint)array3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v389 @ X8_v57 (Il2CppClass<System.Object[]>)+40]");
				obj24 = (UnityEngine.Object)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag19 = ex == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v389 @ X8_v57 (Il2CppClass<System.Object[]>)+40]");
				obj8 = (UnityEngine.Object)0;
				if (flag19)
				{
					goto IL_0c78;
				}
			}
			bool flag20 = array3.Length == 0;
			obj8 = obj24;
			if (!flag20)
			{
				object obj25 = array3 + 32;
				obj25 = obj23;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				text = "{0} color encoding is currently unsupported for outputting to HDR." + 1352;
				array4 = array3;
				goto IL_0c8e;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
			object obj26 = 153100288 + 1024;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			object[] array5 = default(object[]);
			bool flag21 = array5 == null;
			obj8 = (UnityEngine.Object)(&num2);
			if (flag21)
			{
				goto IL_0c5c;
			}
			object obj27 = default(object);
			bool flag22 = obj27 == null;
			UnityEngine.Object obj28 = (UnityEngine.Object)(&num2);
			if (!flag22)
			{
				nint num4 = (nint)array5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v390 @ X8_v49 (Il2CppClass<System.Object[]>)+40]");
				obj28 = (UnityEngine.Object)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag23 = ex == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v390 @ X8_v49 (Il2CppClass<System.Object[]>)+40]");
				obj8 = (UnityEngine.Object)0;
				if (flag23)
				{
					goto IL_0c78;
				}
			}
			bool flag24 = array5.Length == 0;
			obj8 = obj28;
			if (!flag24)
			{
				object obj29 = array5 + 32;
				obj29 = obj27;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
				object obj30 = default(object);
				bool flag25 = obj30 == null;
				int num5 = default(int);
				UnityEngine.Object obj31 = (UnityEngine.Object)(&num5);
				if (!flag25)
				{
					nint num6 = (nint)array5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v391 @ X8_v48 (Il2CppClass<System.Object[]>)+40]");
					obj31 = (UnityEngine.Object)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag26 = ex == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v391 @ X8_v48 (Il2CppClass<System.Object[]>)+40]");
					obj8 = (UnityEngine.Object)0;
					if (flag26)
					{
						goto IL_0c78;
					}
				}
				object obj32 = array5.Length & 0xFFFFFFFEL;
				bool flag27 = obj32 == null;
				obj8 = obj31;
				if (!flag27)
				{
					object obj33 = array5 + 40;
					obj33 = obj30;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					text = "Picking audio files is not supported on iOS" + 88;
					array4 = array5;
					goto IL_0c8e;
				}
			}
		}
		goto IL_0c6a;
		IL_0c8e:
		TextMeshProExtensions.Localize(placeText, (string)text, array4);
		action = null;
		array2 = array4;
		goto IL_04ef;
		IL_04ef:
		SetCompositeText(reward);
		object obj34 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X8_v6+E4]");
		if ((nint)0 != 0)
		{
			bool flag28 = goldContainer;
			bool flag29 = !flag28;
			object obj35 = !flag29;
			string text2 = null;
			obj8 = null;
			if (obj35 == null)
			{
				goto IL_0563;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag30 = goldContainer;
			bool flag31 = !flag30;
			string text2 = null;
			obj8 = null;
			if (flag31)
			{
				goto IL_0563;
			}
		}
		bool flag32 = reward == null;
		array = array2;
		object[] array7;
		UnityEngine.Object obj45;
		object obj43;
		if (!flag32)
		{
			bool flag33 = (object)goldContainer == null;
			array = array2;
			if (!flag33)
			{
				bool flag34 = reward.aces < 0;
				bool flag35 = reward.aces == 0;
				int num7 = reward.aces ^ reward.aces;
				int num8 = reward.aces & num7;
				bool flag36 = num8 < 0;
				bool flag37 = flag34 == flag36;
				object obj36 = !flag35;
				bool active3 = (byte)((flag37 & obj36) ? 1 : 0) != 0;
				goldContainer.SetActive(active3);
				object obj37 = typeof(TypeConverter<ushort, char>) + 3400;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
				object obj38 = 153100288 + 1024;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
				object[] array6 = default(object[]);
				bool flag38 = array6 == null;
				array = null;
				obj8 = (UnityEngine.Object)(&num2);
				if (!flag38)
				{
					object obj39 = default(object);
					bool flag39 = obj39 == null;
					UnityEngine.Object obj40 = (UnityEngine.Object)(&num2);
					if (!flag39)
					{
						nint num9 = (nint)array6;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X8_v31 (Il2CppClass<System.Object[]>)+40]");
						obj40 = (UnityEngine.Object)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
						bool flag40 = ex == null;
						array = null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X8_v31 (Il2CppClass<System.Object[]>)+40]");
						obj8 = (UnityEngine.Object)0;
						if (flag40)
						{
							goto IL_0c78;
						}
					}
					bool flag41 = array6.Length == 0;
					array = null;
					obj8 = obj40;
					if (!flag41)
					{
						object obj41 = array6 + 32;
						obj41 = obj39;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						object obj42 = "AvailableVoices" + 3920;
						string text2 = (string)obj42;
						TextMeshProExtensions.Localize(goldText, (string)obj42, array6);
						obj18 = titleContainer;
						obj43 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v468 @ X8_v19+E4]");
						bool flag42 = (nint)0 == 0;
						object obj44 = !flag42;
						action = null;
						array2 = array6;
						action2 = null;
						array7 = array6;
						obj45 = titleContainer;
						if (obj44 != null)
						{
							goto IL_05b4;
						}
						goto IL_0976;
					}
					goto IL_0c6a;
				}
			}
		}
		goto IL_0c5c;
		IL_0c78:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
		IL_0b1c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag43 = obj17;
		bool flag44 = !flag43;
		obj15 = obj16;
		action = action3;
		array2 = (object[])num;
		obj8 = null;
		if (!flag44)
		{
			goto IL_0b6e;
		}
		return;
		IL_0c6a:
		ex = new IndexOutOfRangeException();
		goto IL_0c78;
		IL_05ff:
		obj12 = trophyContainer;
		obj13 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v658 @ X8_v13+E4]");
		bool flag45 = (nint)0 == 0;
		obj16 = obj15;
		action3 = action;
		num = (int)array2;
		obj17 = trophyContainer;
		if (!flag45)
		{
			goto IL_0658;
		}
		goto IL_0b1c;
		IL_0563:
		obj18 = titleContainer;
		obj43 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v468 @ X8_v19+E4]");
		bool flag46 = (nint)0 == 0;
		action2 = action;
		array7 = array2;
		obj45 = titleContainer;
		if (!flag46)
		{
			goto IL_05b4;
		}
		goto IL_0976;
		IL_0658:
		bool flag47 = obj12;
		bool flag48 = !flag47;
		object obj46 = !flag48;
		obj8 = null;
		if (obj46 == null)
		{
			return;
		}
		goto IL_0b6e;
		IL_0976:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag49 = obj45;
		bool flag50 = !flag49;
		action = action2;
		array2 = array7;
		titleId = null;
		array = array7;
		obj8 = null;
		if (flag50)
		{
			goto IL_05ff;
		}
		goto IL_09cd;
		IL_0c5c:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_0c6a;
	}

	private void SetCompositeText(PredictionSeasonRewardModel reward)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0105: Expected O, but got I4
		//IL_00b7: Expected O, but got I4
		//IL_0154: Expected O, but got I4
		//IL_015d: Expected O, but got I4
		//IL_0217: Expected O, but got I4
		//IL_01c3: Expected O, but got I4
		//IL_01cc: Expected O, but got I4
		//IL_0239: Unknown result type (might be due to invalid IL or missing references)
		//IL_023e: Expected O, but got Unknown
		//IL_03a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a9: Expected O, but got Unknown
		//IL_028e: Expected O, but got I4
		//IL_03d4: Expected O, but got I4
		//IL_03f1: Expected O, but got I4
		//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Expected O, but got Unknown
		//IL_0314: Expected O, but got I4
		//IL_056f: Expected O, but got I4
		//IL_0620: Unknown result type (might be due to invalid IL or missing references)
		//IL_0625: Expected O, but got Unknown
		//IL_064f: Expected O, but got I4
		//IL_040e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0413: Expected O, but got Unknown
		//IL_043d: Expected O, but got I4
		//IL_044a: Expected I8, but got I4
		//IL_0676: Unknown result type (might be due to invalid IL or missing references)
		//IL_067b: Expected O, but got Unknown
		//IL_0ac1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac6: Expected O, but got Unknown
		//IL_069a: Expected O, but got I
		//IL_0786: Unknown result type (might be due to invalid IL or missing references)
		//IL_078b: Expected O, but got Unknown
		//IL_0480: Expected O, but got I
		//IL_046f: Expected I8, but got I4
		//IL_06f4: Expected O, but got I4
		//IL_04da: Expected O, but got I4
		//IL_0815: Expected O, but got I
		//IL_0825: Expected O, but got I
		//IL_0835: Expected O, but got I
		//IL_085e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0863: Expected O, but got Unknown
		//IL_088d: Expected O, but got I4
		//IL_089d: Expected O, but got I
		//IL_08f6: Expected O, but got I4
		//IL_0907: Expected O, but got I4
		//IL_07f2: Expected O, but got I4
		//IL_05a2: Expected O, but got I
		//IL_05b2: Expected O, but got I
		//IL_05c2: Expected O, but got I
		//IL_05fb: Expected O, but got I
		//IL_072f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0734: Expected O, but got Unknown
		//IL_073d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0742: Expected O, but got Unknown
		//IL_075d: Expected O, but got I4
		//IL_0a69: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a6e: Expected O, but got Unknown
		//IL_0924: Unknown result type (might be due to invalid IL or missing references)
		//IL_0929: Expected O, but got Unknown
		//IL_0953: Expected O, but got I4
		//IL_0515: Unknown result type (might be due to invalid IL or missing references)
		//IL_051a: Expected O, but got Unknown
		//IL_0523: Unknown result type (might be due to invalid IL or missing references)
		//IL_0528: Expected O, but got Unknown
		//IL_0543: Expected O, but got I4
		//IL_097a: Unknown result type (might be due to invalid IL or missing references)
		//IL_097f: Expected O, but got Unknown
		//IL_09e6: Expected O, but got I4
		//IL_0a21: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a26: Expected O, but got Unknown
		//IL_0a2f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a34: Expected O, but got Unknown
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6502]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v74+E4]");
			bool flag = (nint)0 == 0;
			obj5 = compositeText;
			obj6 = compositeText;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj5 = compositeText;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v74+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = compositeText;
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
		IL_0611:
		object obj11 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2648;
		object obj12 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v405 @ X0_v34+E4]");
		bool flag5 = (nint)0 == 0;
		object obj13 = !flag5;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object key = "ThisIsFakeReceiptData" + 1968;
		string text = LocalizationText.GetText((string)key);
		object obj14 = (nint)0 + (nint)3072;
		object obj15 = obj14;
		List<object> list = default(List<object>);
		int version = list._version + 1;
		list._version = version;
		object[] items = list._items;
		bool flag6 = list._size < items.Length;
		object obj16 = !flag6;
		object obj20;
		object obj19;
		if (obj16 == null)
		{
			int size = list._size + 1;
			list._size = size;
			object obj17 = items + list._size;
			object obj18 = obj17 + 32;
			obj18 = text;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj19 = 0;
			obj20 = text;
			goto IL_076a;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ X8_v39+20]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v559 @ X8_v40+C0]");
		object obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v560 @ X8_v41+70]");
		obj19 = 0;
		list.AddWithResize((object)text);
		string titleId = reward.titleId;
		object obj23 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
		object obj24 = obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v493 @ X8_v25+E4]");
		bool flag7 = (nint)0 == 0;
		object obj25 = !flag7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v560 @ X8_v41+70]");
		object obj26 = 0;
		obj20 = text;
		string titleId2 = reward.titleId;
		if (obj25 != null)
		{
			goto IL_07cd;
		}
		goto IL_08c0;
		IL_076a:
		titleId = reward.titleId;
		object obj27 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
		obj24 = obj27;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v493 @ X8_v25+E4]");
		bool flag8 = (nint)0 == 0;
		obj26 = obj19;
		titleId2 = reward.titleId;
		if (!flag8)
		{
			goto IL_07cd;
		}
		goto IL_08c0;
		IL_0915:
		object obj28 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2648;
		object obj29 = obj28;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v519 @ X0_v15+E4]");
		bool flag9 = (nint)0 == 0;
		object obj30 = !flag9;
		if (obj30 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object key2 = "Unsupported map type" + 624;
		string text2 = LocalizationText.GetText((string)key2);
		int version2 = list._version + 1;
		list._version = version2;
		object[] items2 = list._items;
		bool flag10 = list._size < items2.Length;
		object obj31 = !flag10;
		if (obj31 == null)
		{
			int size2 = list._size + 1;
			list._size = size2;
			object obj32 = items2 + list._size;
			object obj33 = obj32 + 32;
			obj33 = text2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		else
		{
			list.AddWithResize((object)text2);
		}
		goto IL_0a5f;
		IL_0091:
		bool flag11 = obj5 == null;
		bool flag12 = !flag11;
		obj9 = 0;
		obj10 = null;
		if (!flag12)
		{
			return;
		}
		goto IL_0170;
		IL_0170:
		object obj34 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v2+E4]");
		if ((nint)0 != 0)
		{
			bool flag13 = placeText == null;
			bool flag14 = !flag13;
			object obj35 = !flag14;
			object obj36 = 0;
			UnityEngine.Object obj37 = null;
			if (obj35 != null)
			{
				goto IL_022a;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag15 = placeText == null;
			bool flag16 = !flag15;
			object obj36 = 0;
			UnityEngine.Object obj37 = null;
			if (!flag16)
			{
				goto IL_022a;
			}
		}
		goto IL_0373;
		IL_07cd:
		bool flag17 = StringsExtensions.IsNullOrEmpty(titleId);
		bool flag18 = !flag17;
		object obj38 = 0;
		if (flag18)
		{
			goto IL_0915;
		}
		goto IL_0a5f;
		IL_0373:
		GameObject gameObject = compositeText.gameObject;
		gameObject.SetActive(value: true);
		object obj39 = typeof(List<AdaptivePerformanceScaler>) + 3624;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		list..ctor();
		object obj40 = reward.aces;
		bool flag19 = reward.aces < 1;
		object obj41 = 0;
		if (!flag19)
		{
			object obj42 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2648;
			object obj43 = obj42;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X0_v45+E4]");
			bool flag20 = (nint)0 == 0;
			object obj44 = !flag20;
			long n = reward.aces;
			if (obj44 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				n = reward.aces;
			}
			object key3 = "AvailableVoices" + 3920;
			string text3 = LocalizationText.GetText((string)key3, n);
			object obj45 = (nint)0 + (nint)3072;
			object obj46 = obj45;
			int version3 = list._version + 1;
			list._version = version3;
			object[] items3 = list._items;
			bool flag21 = list._size < items3.Length;
			object obj47 = !flag21;
			if (obj47 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ X8_v55+20]");
				object obj48 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v509 @ X8_v56+C0]");
				object obj49 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ X8_v57+70]");
				obj41 = 0;
				list.AddWithResize((object)text3);
				bool flag22 = reward.trophyImage == null;
				obj40 = text3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ X8_v57+70]");
				obj19 = 0;
				obj20 = text3;
				if (!flag22)
				{
					goto IL_0611;
				}
				goto IL_076a;
			}
			int size3 = list._size + 1;
			list._size = size3;
			object obj50 = items3 + list._size;
			object obj51 = obj50 + 32;
			obj51 = text3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj41 = 0;
			obj40 = text3;
		}
		bool flag23 = reward.trophyImage == null;
		object obj52 = !flag23;
		if (obj52 != null)
		{
			goto IL_0611;
		}
		obj19 = obj41;
		obj20 = obj40;
		goto IL_076a;
		IL_022a:
		object obj53 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		object obj54 = obj53;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X0_v55+E4]");
		if ((nint)0 != 0)
		{
			SFSConfig currentSFS = Config.CurrentSFS;
			bool flag24 = currentSFS == null;
			object obj55 = !flag24;
			if (obj55 != null)
			{
				goto IL_02d6;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			SFSConfig currentSFS2 = Config.CurrentSFS;
			if (currentSFS2 != null)
			{
				goto IL_02d6;
			}
		}
		goto IL_0373;
		IL_08c0:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag25 = StringsExtensions.IsNullOrEmpty(titleId2);
		bool flag26 = !flag25;
		object obj56 = !flag26;
		obj19 = obj26;
		obj38 = 0;
		if (obj56 == null)
		{
			goto IL_0915;
		}
		goto IL_0a5f;
		IL_0a5f:
		object separator = " SDK from working.  If you would like to change it's implementation please override StartVivoxUnity method in " + 2440;
		string text4 = string.Join((string)separator, (IEnumerable<string>)list);
		TextMeshProExtensions.FixArabic(compositeText, text4);
		return;
		IL_02d6:
		object obj57 = typeof(RegisteredWaitHandle) + 56;
		object obj58 = obj57;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X0_v57+E4]");
		bool flag27 = (nint)0 == 0;
		object obj59 = !flag27;
		if (obj59 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		RemoteConfigModel current = RemoteConfig.Current;
		PredictionsConfig <Predictions>k__BackingField = current.<Predictions>k__BackingField;
		if (<Predictions>k__BackingField.<TopPrizeShowRewardsText>k__BackingField)
		{
			goto IL_0373;
		}
		GameObject gameObject2 = compositeText.gameObject;
		gameObject2.SetActive(value: false);
	}
}
