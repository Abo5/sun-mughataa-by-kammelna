using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Threading;
using System.Xml.Schema;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json.Linq.JsonPath;
using TMPro;
using Unity.Properties;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

namespace Managers.Achievemenets;

public class AchievementLevelDescription : MonoBehaviour
{
	private sealed class <>c__DisplayClass8_0
	{
		public GameAchievementViewModel model;

		internal void <Populate>b__0()
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0043: Expected O, but got I4
			//IL_0074: Expected O, but got I4
			GameAchievementViewModel gameAchievementViewModel = model;
			object obj = typeof(RegisteredWaitHandle) + 1552;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			RoutingManager.Route(gameAchievementViewModel.<routingCommand>k__BackingField, null, (Games?)(object)0);
		}
	}

	private TextMeshProUGUI pointsText;

	private ProgressBar progressBar;

	private GameObject notchStyleDeep;

	private GameObject roundedDeep;

	private CanvasGroup canvasGroup;

	private float lockedAlpha = 0.7f;

	private GameObject ctaRoot;

	private Button goButton;

	public void Populate(GameAchievementViewModel model, UserAchievementModel userModel, int levelNumber, int userValue, bool isActive, bool isUnlocked, UnityAction customOnGo = null)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_0082: Expected O, but got I
		//IL_024d: Expected O, but got I4
		//IL_00df: Expected O, but got I4
		//IL_0116: Expected O, but got I4
		//IL_0665: Expected O, but got I
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bb: Expected O, but got Unknown
		//IL_04ce: Expected O, but got I4
		//IL_02cd: Expected O, but got I4
		//IL_02f2: Expected O, but got I4
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Expected O, but got Unknown
		//IL_0319: Expected O, but got I
		//IL_0329: Unknown result type (might be due to invalid IL or missing references)
		//IL_032e: Expected I4, but got Unknown
		//IL_033c: Expected O, but got I4
		//IL_050c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0511: Expected O, but got Unknown
		//IL_052b: Expected O, but got I4
		//IL_05eb: Expected O, but got I4
		//IL_0575: Expected O, but got I
		//IL_0585: Unknown result type (might be due to invalid IL or missing references)
		//IL_058a: Expected I4, but got Unknown
		//IL_0598: Expected O, but got I4
		//IL_05b3: Expected O, but got I4
		//IL_06d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d8: Expected I4, but got Unknown
		//IL_0700: Expected O, but got I4
		//IL_0382: Unknown result type (might be due to invalid IL or missing references)
		//IL_0387: Expected O, but got Unknown
		//IL_03bf: Expected O, but got I4
		//IL_03d9: Expected O, but got I4
		//IL_0422: Expected O, but got I4
		//IL_0460: Unknown result type (might be due to invalid IL or missing references)
		//IL_0465: Expected O, but got Unknown
		//IL_047b: Expected O, but got I
		//IL_048c: Expected I, but got O
		object obj = typeof(XmlSchemaInclude) + 3704;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj4 = obj2 + 16;
		obj4 = model;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = obj4;
		List<object> list;
		int num2;
		object description;
		if (obj4 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X8_v4+38]");
			list = (List<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X8_v4+38]");
			if ((nint)0 != 0 && list._size > 0)
			{
				object obj6 = list._size - 1;
				bool singleLevel = obj6 == null;
				ApplyBarStyle(singleLevel);
				bool flag = levelNumber < list._size;
				object obj7 = !flag;
				object obj8 = ~obj7;
				object obj9 = ~obj8;
				int num = ((obj9 != null) ? list._size : levelNumber);
				num2 = ((levelNumber < 1) ? 1 : num);
				int index = num2 - 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X8_v4+38]");
				object obj10 = ((List<object>)0).get_Item(index);
				object obj11 = obj4;
				if (obj4 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v388 @ X8_v10+28]");
					if ((nint)0 == 2)
					{
						description = userModel + 40;
						goto IL_066e;
					}
				}
				description = obj10 + 32;
				goto IL_066e;
			}
		}
		ApplyPoints(0, 0, 0, isUnlocked: false);
		ToggleCTA(show: false, null);
		object obj12 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ X0_v11+E4]");
		if ((nint)0 != 0)
		{
			bool flag2 = progressBar;
			bool flag3 = !flag2;
			object obj13 = !flag3;
			if (obj13 == null)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			if (!progressBar)
			{
				return;
			}
		}
		progressBar.StaticInitialize(1, 0);
		return;
		IL_0308:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X0_v21 (System.Object)+14]");
		object obj14 = ~(nint)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X0_v21 (System.Object)+14]");
		int num3 = 0 & obj14;
		object obj15 = (isUnlocked ? 1 : 0) ^ 1;
		bool flag4 = obj4 == null;
		object obj16 = obj15;
		object obj18;
		object obj17 = obj18;
		int cap = num3;
		if (!flag4)
		{
			goto IL_0372;
		}
		goto IL_05d9;
		IL_066e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X0_v21 (System.Object)+18]");
		ApplyPoints(0, num2, list._size, isUnlocked);
		object obj19 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v407 @ X0_v23+E4]");
		if ((nint)0 != 0)
		{
			obj18 = isUnlocked || isActive;
			bool flag5 = canvasGroup;
			bool flag6 = !flag5;
			object obj20 = !flag6;
			obj17 = obj18;
			if (obj20 == null)
			{
				goto IL_0308;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj18 = isUnlocked || isActive;
			bool flag7 = canvasGroup;
			bool flag8 = !flag7;
			obj17 = obj18;
			if (flag8)
			{
				goto IL_0308;
			}
		}
		object obj21 = obj17 & 1;
		bool flag9 = obj21 == null;
		object obj22 = !flag9;
		float alpha = 1f;
		if (obj22 == null)
		{
			alpha = lockedAlpha;
		}
		canvasGroup.alpha = alpha;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X0_v21 (System.Object)+14]");
		object obj23 = ~(nint)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X0_v21 (System.Object)+14]");
		num3 = 0 & obj23;
		obj15 = (isUnlocked ? 1 : 0) ^ 1;
		bool flag10 = obj4 == null;
		object obj24 = !flag10;
		obj18 = obj17;
		obj16 = obj15;
		cap = num3;
		if (obj24 != null)
		{
			goto IL_0372;
		}
		goto IL_05d9;
		IL_06be:
		object obj26;
		object obj25 = obj26 & obj16;
		bool show = (byte)((obj25 & isActive) ? 1 : 0) != 0;
		UnityAction onGoHandler;
		ToggleCTA(show, onGoHandler);
		bool flag11 = obj17 == null;
		object obj27 = !flag11;
		object obj28 = ~obj27;
		int userValue2 = ((obj28 == null) ? userValue : 0);
		ApplyProgress(cap, userValue2, isUnlocked, (string)description);
		return;
		IL_05d9:
		onGoHandler = customOnGo;
		obj26 = 0;
		goto IL_06be;
		IL_0372:
		object obj29 = typeof(RegisteredWaitHandle) + 1544;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object objA = default(object);
		object objB = default(object);
		bool flag12 = object.Equals(objA, objB);
		obj26 = (flag12 ? 1 : 0) ^ 1;
		bool flag13 = customOnGo == null;
		object obj30 = !flag13;
		onGoHandler = customOnGo;
		obj16 = obj15;
		obj17 = obj18;
		cap = num3;
		if (obj30 == null)
		{
			bool flag14 = !flag12;
			object obj31 = !flag14;
			onGoHandler = customOnGo;
			obj16 = obj15;
			obj17 = obj18;
			cap = num3;
			if (obj31 == null)
			{
				object obj32 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj33 = (nint)0 + (nint)2016;
				UnityAction unityAction = default(UnityAction);
				unityAction..ctor(obj2, (IntPtr)obj33);
				onGoHandler = unityAction;
				obj16 = obj15;
				obj17 = obj18;
				cap = num3;
			}
		}
		goto IL_06be;
	}

	public void RefreshSelection(GameAchievementViewModel model, UserAchievementModel userModel, int selectedLevel, int unlockedLevel, int userValue)
	{
		//IL_00d3: Expected O, but got I4
		//IL_00e1: Expected O, but got I4
		//IL_0119: Expected O, but got I4
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Expected O, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		//IL_0166: Expected O, but got I4
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Expected I4, but got Unknown
		//IL_01d3: Expected O, but got I4
		//IL_01db: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e0: Expected I4, but got Unknown
		List<AchievementLevelModel> list;
		if (model != null)
		{
			list = model.<achievementLevels>k__BackingField;
			if (model.<achievementLevels>k__BackingField != null)
			{
				int? num = list._size;
				List<AchievementLevelModel> list2 = default(List<AchievementLevelModel>);
				list = list2;
			}
		}
		else
		{
			list = null;
		}
		object obj = unlockedLevel + 1;
		object obj2 = unlockedLevel + 1;
		bool flag = (nint)obj2 < 0;
		bool flag2 = obj2 == null;
		bool flag3 = !flag;
		object obj3 = !flag2;
		object obj4 = flag3 & obj3;
		object obj5 = ~obj4;
		bool flag4;
		if (obj5 == null)
		{
			object obj6 = selectedLevel - obj;
			flag4 = obj6 == null;
		}
		else
		{
			flag4 = false;
		}
		bool isActive = unlockedLevel < (nint)list && flag4;
		object obj7 = selectedLevel - unlockedLevel;
		bool flag5 = (nint)obj7 < 0;
		bool flag6 = obj7 == null;
		int num2 = selectedLevel ^ unlockedLevel;
		int num3 = selectedLevel ^ obj7;
		int num4 = num2 & num3;
		bool flag7 = num4 < 0;
		bool flag8 = flag5 == flag7;
		object obj8 = !flag8;
		bool isUnlocked = (byte)((obj8 | flag6) ? 1 : 0) != 0;
		Populate(model, userModel, selectedLevel, userValue, isActive, isUnlocked);
	}

	private unsafe void ApplyPoints(int points, int levelNumber, int totalLevels, bool isUnlocked)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0106: Expected O, but got I4
		//IL_00b4: Expected O, but got I4
		//IL_0243: Expected O, but got I4
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Expected O, but got Unknown
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_0286: Expected O, but got Unknown
		//IL_02b0: Expected O, but got I4
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dc: Expected O, but got Unknown
		//IL_02e9: Expected O, but got Ref
		//IL_09c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ce: Expected O, but got Unknown
		//IL_09f9: Expected O, but got I4
		//IL_031f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0324: Expected O, but got Unknown
		//IL_034f: Expected O, but got I4
		//IL_0612: Unknown result type (might be due to invalid IL or missing references)
		//IL_0617: Expected O, but got Unknown
		//IL_0641: Expected O, but got I4
		//IL_0a1f: Expected O, but got I4
		//IL_0668: Unknown result type (might be due to invalid IL or missing references)
		//IL_066d: Expected O, but got Unknown
		//IL_0697: Unknown result type (might be due to invalid IL or missing references)
		//IL_069c: Expected O, but got Unknown
		//IL_0375: Expected O, but got I4
		//IL_06cc: Expected O, but got I4
		//IL_0a35: Expected I, but got O
		//IL_0a45: Expected O, but got I
		//IL_0a77: Expected O, but got I
		//IL_038b: Expected I, but got O
		//IL_039b: Expected O, but got I
		//IL_03cd: Expected O, but got I
		//IL_0abe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac3: Expected O, but got Unknown
		//IL_06f2: Expected O, but got I4
		//IL_0414: Unknown result type (might be due to invalid IL or missing references)
		//IL_0419: Expected O, but got Unknown
		//IL_0b66: Expected O, but got I8
		//IL_04bc: Expected O, but got I8
		//IL_0b02: Expected I, but got O
		//IL_0b12: Expected O, but got I
		//IL_0b44: Expected O, but got I
		//IL_0708: Expected I, but got O
		//IL_0718: Expected O, but got I
		//IL_074a: Expected O, but got I
		//IL_0458: Expected I, but got O
		//IL_0468: Expected O, but got I
		//IL_049a: Expected O, but got I
		//IL_0b9d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ba2: Expected O, but got Unknown
		//IL_0bbe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc3: Expected O, but got Unknown
		//IL_0791: Unknown result type (might be due to invalid IL or missing references)
		//IL_0796: Expected O, but got Unknown
		//IL_04f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f8: Expected O, but got Unknown
		//IL_0514: Unknown result type (might be due to invalid IL or missing references)
		//IL_0519: Expected O, but got Unknown
		//IL_0839: Expected O, but got I8
		//IL_07d5: Expected I, but got O
		//IL_07e5: Expected O, but got I
		//IL_0817: Expected O, but got I
		//IL_0870: Unknown result type (might be due to invalid IL or missing references)
		//IL_0875: Expected O, but got Unknown
		//IL_0920: Expected O, but got I4
		//IL_0930: Expected O, but got I4
		//IL_0950: Unknown result type (might be due to invalid IL or missing references)
		//IL_0955: Expected O, but got Unknown
		//IL_08b4: Expected I, but got O
		//IL_08c4: Expected O, but got I
		//IL_08f6: Expected O, but got I
		//IL_097d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0982: Expected O, but got Unknown
		//IL_099e: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a3: Expected O, but got Unknown
		object obj = 152993792;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8564]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v81+E4]");
			bool flag = (nint)0 == 0;
			obj5 = pointsText;
			obj6 = pointsText;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj5 = pointsText;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v81+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = pointsText;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6;
		bool flag4 = !flag3;
		string text = null;
		if (!flag4)
		{
			goto IL_0158;
		}
		return;
		IL_0bd1:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0bdf;
		IL_0bed:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
		IL_0bdf:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		goto IL_0bed;
		IL_0091:
		bool flag5 = obj5;
		bool flag6 = !flag5;
		object obj8 = !flag6;
		text = null;
		if (obj8 == null)
		{
			return;
		}
		goto IL_0158;
		IL_0158:
		TextMeshProUGUI textMesh;
		object text6;
		object[] formattedArguments;
		if (points > 0)
		{
			if ((object)pointsText != null)
			{
				Transform transform = pointsText.transform;
				bool flag7 = (object)transform == null;
				text = null;
				if (!flag7)
				{
					Transform parent = transform.parent;
					bool flag8 = (object)parent == null;
					text = null;
					if (!flag8)
					{
						GameObject gameObject = parent.gameObject;
						bool flag9 = (object)gameObject == null;
						text = null;
						if (!flag9)
						{
							gameObject.SetActive(value: true);
							object obj9 = 153100288 + 1024;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
							object format = "1.2.840.113549.1.12.1.5" + 3512;
							object arg = default(object);
							string text2 = string.Format((string)format, arg);
							object obj10 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2504;
							object obj11 = obj10;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v452 @ X0_v21+E4]");
							bool flag10 = (nint)0 == 0;
							object obj12 = !flag10;
							if (obj12 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							object iconName = "___# Content push apply failed [{0}]: {1}" + 2944;
							object obj13 = default(object);
							string text3 = StringUtil.Sprite((string)iconName, (Color?)(object)(&obj13));
							if (isUnlocked)
							{
								textMesh = pointsText;
								object obj14 = typeof(TypeConverter<ushort, char>) + 3400;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
								object[] array = default(object[]);
								bool flag11 = array == null;
								int num = 0;
								text = (string)2;
								if (flag11)
								{
									goto IL_0bd1;
								}
								bool flag12 = text2 == null;
								string text4 = (string)2;
								if (!flag12)
								{
									nint num2 = (nint)array;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X8_v54 (Il2CppClass<System.Object[]>)+40]");
									text4 = (string)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
									bool flag13 = ex2 == null;
									num = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X8_v54 (Il2CppClass<System.Object[]>)+40]");
									text = (string)0;
									if (flag13)
									{
										goto IL_0bed;
									}
								}
								bool flag14 = array.Length == 0;
								num = 0;
								text = text4;
								if (!flag14)
								{
									object obj15 = array + 32;
									obj15 = text2;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
									bool flag15 = text3 == null;
									string text5 = text2;
									if (!flag15)
									{
										nint num3 = (nint)array;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ X8_v53 (Il2CppClass<System.Object[]>)+40]");
										text5 = (string)0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
										bool flag16 = ex2 == null;
										num = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ X8_v53 (Il2CppClass<System.Object[]>)+40]");
										text = (string)0;
										if (flag16)
										{
											goto IL_0bed;
										}
									}
									object obj16 = array.Length & 0xFFFFFFFEL;
									bool flag17 = obj16 == null;
									num = 0;
									text = text5;
									if (!flag17)
									{
										object obj17 = array + 40;
										obj17 = text3;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
										text6 = "WhiteSmoke" + 1880;
										formattedArguments = array;
										goto IL_0c03;
									}
								}
							}
							else if (totalLevels > 1)
							{
								object obj18 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
								object obj19 = obj18;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v471 @ X0_v41+E4]");
								bool flag18 = (nint)0 == 0;
								object obj20 = !flag18;
								if (obj20 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								object input = "Network Authentication Required" + 3280;
								int num = default(int);
								string text7 = LocalizationUtil.LocalizeOrdinal((string)input, num);
								textMesh = pointsText;
								object obj21 = typeof(TypeConverter<ushort, char>) + 3400;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
								object[] array2 = default(object[]);
								bool flag19 = array2 == null;
								num = 0;
								text = (string)3;
								if (flag19)
								{
									goto IL_0bd1;
								}
								bool flag20 = text7 == null;
								string text8 = (string)3;
								if (!flag20)
								{
									nint num4 = (nint)array2;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ X8_v44 (Il2CppClass<System.Object[]>)+40]");
									text8 = (string)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
									bool flag21 = ex2 == null;
									num = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ X8_v44 (Il2CppClass<System.Object[]>)+40]");
									text = (string)0;
									if (flag21)
									{
										goto IL_0bed;
									}
								}
								bool flag22 = array2.Length == 0;
								num = 0;
								text = text8;
								if (!flag22)
								{
									object obj22 = array2 + 32;
									obj22 = text7;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
									bool flag23 = text2 == null;
									string text9 = text7;
									if (!flag23)
									{
										nint num5 = (nint)array2;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v421 @ X8_v43 (Il2CppClass<System.Object[]>)+40]");
										text9 = (string)0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
										bool flag24 = ex2 == null;
										num = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v421 @ X8_v43 (Il2CppClass<System.Object[]>)+40]");
										text = (string)0;
										if (flag24)
										{
											goto IL_0bed;
										}
									}
									object obj23 = array2.Length & 0xFFFFFFFEL;
									bool flag25 = obj23 == null;
									num = 0;
									text = text9;
									if (!flag25)
									{
										object obj24 = array2 + 40;
										obj24 = text2;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
										bool flag26 = text3 == null;
										string text10 = text2;
										if (!flag26)
										{
											nint num6 = (nint)array2;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v422 @ X8_v42 (Il2CppClass<System.Object[]>)+40]");
											text10 = (string)0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
											bool flag27 = ex2 == null;
											num = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v422 @ X8_v42 (Il2CppClass<System.Object[]>)+40]");
											text = (string)0;
											if (flag27)
											{
												goto IL_0bed;
											}
										}
										bool flag28 = array2.Length < 2;
										object obj25 = !flag28;
										object obj26 = array2.Length - 2;
										bool flag29 = obj26 == null;
										object obj27 = ~obj25;
										object obj28 = obj27 | flag29;
										num = 0;
										text = text10;
										if (obj28 == null)
										{
											object obj29 = array2 + 48;
											obj29 = text3;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
											text6 = "Unsupported map type" + 336;
											formattedArguments = array2;
											goto IL_0c03;
										}
									}
								}
							}
							else
							{
								textMesh = pointsText;
								object obj30 = typeof(TypeConverter<ushort, char>) + 3400;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
								object[] array3 = default(object[]);
								bool flag30 = array3 == null;
								int num = 0;
								text = (string)2;
								if (flag30)
								{
									goto IL_0bd1;
								}
								bool flag31 = text2 == null;
								string text11 = (string)2;
								if (!flag31)
								{
									nint num7 = (nint)array3;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v423 @ X8_v26 (Il2CppClass<System.Object[]>)+40]");
									text11 = (string)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
									bool flag32 = ex2 == null;
									num = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v423 @ X8_v26 (Il2CppClass<System.Object[]>)+40]");
									text = (string)0;
									if (flag32)
									{
										goto IL_0bed;
									}
								}
								bool flag33 = array3.Length == 0;
								num = 0;
								text = text11;
								if (!flag33)
								{
									object obj31 = array3 + 32;
									obj31 = text2;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
									bool flag34 = text3 == null;
									string text12 = text2;
									if (!flag34)
									{
										nint num8 = (nint)array3;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ X8_v25 (Il2CppClass<System.Object[]>)+40]");
										text12 = (string)0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
										bool flag35 = ex2 == null;
										num = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ X8_v25 (Il2CppClass<System.Object[]>)+40]");
										text = (string)0;
										if (flag35)
										{
											goto IL_0bed;
										}
									}
									object obj32 = array3.Length & 0xFFFFFFFEL;
									bool flag36 = obj32 == null;
									num = 0;
									text = text12;
									if (!flag36)
									{
										object obj33 = array3 + 40;
										obj33 = text3;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
										text6 = "Unsupported map type" + 4048;
										formattedArguments = array3;
										goto IL_0c03;
									}
								}
							}
							goto IL_0bdf;
						}
					}
				}
			}
		}
		else if ((object)pointsText != null)
		{
			Transform transform2 = pointsText.transform;
			bool flag37 = (object)transform2 == null;
			text = null;
			if (!flag37)
			{
				Transform parent2 = transform2.parent;
				bool flag38 = (object)parent2 == null;
				text = null;
				if (!flag38)
				{
					GameObject gameObject2 = parent2.gameObject;
					bool flag39 = (object)gameObject2 == null;
					text = null;
					if (!flag39)
					{
						gameObject2.SetActive(value: false);
						return;
					}
				}
			}
		}
		goto IL_0bd1;
		IL_0c03:
		TextMeshProExtensions.Localize(textMesh, (string)text6, formattedArguments);
	}

	private void ApplyProgress(int cap, int userValue, bool isComplete, string description)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_011a: Expected O, but got I4
		//IL_00b4: Expected O, but got I4
		//IL_01f4: Expected O, but got I4
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Expected I4, but got Unknown
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Expected O, but got Unknown
		//IL_0293: Unknown result type (might be due to invalid IL or missing references)
		//IL_0298: Expected O, but got Unknown
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Expected O, but got Unknown
		//IL_02c6: Expected O, but got I4
		//IL_025e: Expected O, but got I4
		//IL_03fa: Expected O, but got I4
		//IL_0390: Expected O, but got I4
		//IL_0332: Expected O, but got I
		object obj = 152993792;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8565]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v25+E4]");
			bool flag = (nint)0 == 0;
			obj5 = progressBar;
			obj6 = progressBar;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj5 = progressBar;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v25+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = progressBar;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6;
		bool flag4 = !flag3;
		bool flag5 = isComplete;
		int num2 = default(int);
		int num = num2;
		int num3 = 0;
		if (!flag4)
		{
			goto IL_0180;
		}
		goto IL_027a;
		IL_027a:
		object input = "Complete" + 16;
		object obj8 = "The '{0}' attribute is not declared." + 504;
		object obj9 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
		bool flag6 = !isComplete;
		object obj10 = !flag6;
		object obj11 = ~obj10;
		if (obj11 != null)
		{
			input = obj8;
		}
		object obj12 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X8_v7+E4]");
		bool flag7 = (nint)0 == 0;
		object obj13 = !flag7;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string text = LocalizationUtil.Localize((string)input);
		object obj14 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X8_v8+E4]");
		if ((nint)0 != 0)
		{
			if (!progressBar)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag8 = progressBar;
			bool flag9 = !flag8;
			object obj15 = !flag9;
			if (obj15 == null)
			{
				return;
			}
		}
		object obj16 = (nint)0 + (nint)3688;
		string barText = text + (string)obj16 + description;
		progressBar.SetBarText(barText);
		return;
		IL_0180:
		GameObject gameObject = progressBar.gameObject;
		bool flag10 = cap < 0;
		bool flag11 = cap == 0;
		int num4 = cap ^ cap;
		int num5 = cap & num4;
		bool flag12 = num5 < 0;
		bool flag13 = flag10 == flag12;
		object obj17 = !flag11;
		bool flag14 = (byte)((flag13 & obj17) ? 1 : 0) != 0;
		gameObject.SetActive(flag14);
		bool flag15 = cap < 1;
		flag5 = isComplete;
		num = 0;
		num3 = (flag14 ? 1 : 0);
		if (!flag15)
		{
			bool flag16 = !isComplete;
			object obj18 = !flag16;
			object obj19 = ~obj18;
			if (obj19 == null)
			{
			}
			progressBar.Initialize(cap, cap);
			flag5 = false;
			num = cap;
			num3 = cap;
		}
		goto IL_027a;
		IL_0091:
		bool flag17 = obj5;
		bool flag18 = !flag17;
		object obj20 = !flag18;
		if (obj20 != null)
		{
			goto IL_0180;
		}
		flag5 = isComplete;
		num = num2;
		num3 = 0;
		goto IL_027a;
	}

	private void ApplyBarStyle(bool singleLevel)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0172: Expected O, but got I4
		//IL_00b4: Expected O, but got I4
		//IL_0223: Expected O, but got I4
		//IL_026d: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8566]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v11+E4]");
			bool flag = (nint)0 == 0;
			obj5 = notchStyleDeep;
			obj6 = notchStyleDeep;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v11+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = notchStyleDeep;
			obj6 = notchStyleDeep;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6;
		bool flag4 = !flag3;
		bool flag5 = false;
		if (flag4)
		{
			goto IL_00cb;
		}
		goto IL_01d2;
		IL_0132:
		roundedDeep.SetActive(singleLevel);
		return;
		IL_010c:
		UnityEngine.Object obj8;
		if ((bool)obj8)
		{
			goto IL_0132;
		}
		return;
		IL_023b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		UnityEngine.Object obj9;
		bool flag6 = obj9;
		bool flag7 = !flag6;
		object obj10 = !flag7;
		if (obj10 == null)
		{
			return;
		}
		goto IL_0132;
		IL_0091:
		bool flag8 = obj5;
		bool flag9 = !flag8;
		object obj11 = !flag9;
		flag5 = false;
		if (obj11 == null)
		{
			goto IL_00cb;
		}
		goto IL_01d2;
		IL_01d2:
		flag5 = (byte)((singleLevel ? 1u : 0u) ^ 1u) != 0;
		notchStyleDeep.SetActive(flag5);
		obj8 = roundedDeep;
		object obj12 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X0_v4+E4]");
		bool flag10 = (nint)0 == 0;
		object obj13 = !flag10;
		obj9 = roundedDeep;
		if (obj13 != null)
		{
			goto IL_010c;
		}
		goto IL_023b;
		IL_00cb:
		obj12 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X0_v4+E4]");
		bool flag11 = (nint)0 == 0;
		obj8 = roundedDeep;
		obj9 = roundedDeep;
		if (!flag11)
		{
			goto IL_010c;
		}
		goto IL_023b;
	}

	private void HideProgress()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0127: Expected O, but got I4
		//IL_0171: Expected O, but got I4
		//IL_00dd: Expected O, but got I
		object obj = 152993792;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8567]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			obj5 = progressBar;
			obj6 = progressBar;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj5 = progressBar;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = progressBar;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6;
		bool flag4 = !flag3;
		object obj8 = !flag4;
		if (obj8 == null)
		{
			return;
		}
		goto IL_00b7;
		IL_00b7:
		progressBar.StaticInitialize(1, 0);
		object barText = (nint)0 + (nint)2000;
		progressBar.SetBarText((string)barText);
		return;
		IL_0091:
		if ((bool)obj5)
		{
			goto IL_00b7;
		}
	}

	private void ToggleCTA(bool show, UnityAction onGoHandler)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_017a: Expected O, but got I4
		//IL_00b4: Expected O, but got I4
		//IL_021d: Expected O, but got I4
		//IL_0137: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8568]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v14+E4]");
			bool flag = (nint)0 == 0;
			obj5 = ctaRoot;
			obj6 = ctaRoot;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v14+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = ctaRoot;
			obj6 = ctaRoot;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6;
		bool flag4 = !flag3;
		bool flag5 = false;
		if (flag4)
		{
			goto IL_00cb;
		}
		goto IL_01da;
		IL_0277:
		Button button = goButton;
		button.m_OnClick.RemoveAllListeners();
		if (show && onGoHandler != null)
		{
			Button button2 = goButton;
			button2.m_OnClick.AddListener(onGoHandler);
		}
		return;
		IL_0114:
		UnityEngine.Object obj8;
		bool flag6 = obj8;
		bool flag7 = !flag6;
		object obj9 = !flag7;
		if (obj9 == null)
		{
			return;
		}
		goto IL_0277;
		IL_0242:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		UnityEngine.Object obj10;
		if ((bool)obj10)
		{
			goto IL_0277;
		}
		return;
		IL_0091:
		bool flag8 = obj5;
		bool flag9 = !flag8;
		object obj11 = !flag9;
		flag5 = false;
		if (obj11 == null)
		{
			goto IL_00cb;
		}
		goto IL_01da;
		IL_01da:
		ctaRoot.SetActive(show);
		obj8 = goButton;
		object obj12 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v7+E4]");
		bool flag10 = (nint)0 == 0;
		object obj13 = !flag10;
		UnityAction unityAction = null;
		flag5 = show;
		obj10 = goButton;
		if (obj13 != null)
		{
			goto IL_0114;
		}
		goto IL_0242;
		IL_00cb:
		obj12 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v7+E4]");
		bool flag11 = (nint)0 == 0;
		obj8 = goButton;
		unityAction = onGoHandler;
		obj10 = goButton;
		if (!flag11)
		{
			goto IL_0114;
		}
		goto IL_0242;
	}
}
