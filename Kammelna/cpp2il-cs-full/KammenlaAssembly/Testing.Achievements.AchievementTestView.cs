using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Xml.Schema;
using ArabicSupport;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server;
using Server.Models;
using Sfs2X.Entities;
using Spine;
using TMPro;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

namespace Testing.Achievements;

public class AchievementTestView : MonoBehaviour, ITestPanel
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<GameAchievementViewModel, TMP_Dropdown.OptionData> <>9__27_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(XmlSchemaInclude) + 3728;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal TMP_Dropdown.OptionData <PopulateDropdown>b__27_0(GameAchievementViewModel a)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Expected O, but got Unknown
			//IL_0037: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Expected O, but got Unknown
			if (a != null)
			{
				object obj = typeof(SqlSingle[]) + 2352;
				object format = "WhiteSmoke" + 4080;
				object obj2 = typeof(SkeletonBinary.SkeletonInput) + 2120;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
				string arg = ArabicFixer.Fix(a.<name>k__BackingField);
				object arg2 = default(object);
				string text = string.Format((string)format, arg2, arg);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				TMP_Dropdown.OptionData optionData = default(TMP_Dropdown.OptionData);
				optionData..ctor(text);
				return optionData;
			}
			return (TMP_Dropdown.OptionData)(object)new NullReferenceException();
		}
	}

	private sealed class <>c__DisplayClass21_0
	{
		public AchievementTestView <>4__this;

		public string id;

		internal void <IncrementAchievement>b__0(KammelnaResponseModel<bool> response)
		{
			//IL_016a: Unknown result type (might be due to invalid IL or missing references)
			//IL_016f: Expected O, but got Unknown
			//IL_0194: Unknown result type (might be due to invalid IL or missing references)
			//IL_0199: Expected O, but got Unknown
			//IL_0280: Expected O, but got I
			//IL_029a: Expected O, but got I4
			//IL_0042: Expected O, but got I4
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Expected O, but got Unknown
			//IL_022e: Expected O, but got I4
			//IL_0237: Expected O, but got I4
			//IL_01dc: Expected O, but got I
			//IL_0086: Unknown result type (might be due to invalid IL or missing references)
			//IL_008b: Expected O, but got Unknown
			//IL_0351: Expected O, but got I
			//IL_036b: Expected O, but got I4
			//IL_02ea: Expected O, but got I4
			//IL_02f3: Expected O, but got I4
			//IL_02fc: Expected O, but got I4
			//IL_0120: Expected O, but got I4
			//IL_0129: Expected O, but got I4
			//IL_00ce: Expected O, but got I
			//IL_03bb: Expected O, but got I4
			//IL_03c4: Expected O, but got I4
			//IL_03cd: Expected O, but got I4
			string text;
			object obj2;
			LocalizableText localizableText;
			Vector2 displacement;
			Vector2 vector;
			LocalizableText localizableText2;
			object obj7;
			if (response.Succeeded)
			{
				object obj = 153100288 + 1024;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
				object format = "WhiteSmoke" + 2592;
				object arg = default(object);
				text = string.Format((string)format, arg, id);
				obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1240;
				object obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X0_v30+E4]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7B7D]");
					object obj4 = (nint)0 & (nint)1;
					if (obj4 != null)
					{
						goto IL_00eb;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7B7D]");
					object obj5 = (nint)0 & (nint)1;
					bool flag = obj5 == null;
					object obj6 = !flag;
					if (obj6 != null)
					{
						goto IL_00eb;
					}
				}
				_ = 1;
				localizableText = TextMeshProExtensions.FixOnly(text);
				obj7 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X8_v27+E4]");
				bool flag2 = (nint)0 == 0;
				object obj8 = !flag2;
				displacement = (Vector2)0;
				vector = (Vector2)0;
				localizableText2 = localizableText;
				if (obj8 != null)
				{
					goto IL_013f;
				}
				goto IL_03e3;
			}
			string errorMessage = response.ErrorMessage;
			object obj9 = "WhiteSmoke" + 2656;
			string text2 = (string)obj9 + errorMessage;
			object obj10 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1240;
			object obj11 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X0_v10+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7B7D]");
				object obj12 = (nint)0 & (nint)1;
				if (obj12 != null)
				{
					goto IL_01f9;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7B7D]");
				object obj13 = (nint)0 & (nint)1;
				bool flag3 = obj13 == null;
				object obj14 = !flag3;
				if (obj14 != null)
				{
					goto IL_01f9;
				}
			}
			_ = 1;
			LocalizableText localizableText3 = TextMeshProExtensions.FixOnly(text2);
			object obj15 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X8_v11+E4]");
			bool flag4 = (nint)0 == 0;
			object obj16 = !flag4;
			Vector2 displacement2 = (Vector2)0;
			Vector2 vector2 = (Vector2)0;
			LocalizableText localizableText4 = localizableText3;
			if (obj16 != null)
			{
				goto IL_024d;
			}
			goto IL_0312;
			IL_024d:
			Toast.Show(localizableText3, displacement2, 0f);
			return;
			IL_013f:
			Toast.Show(localizableText, displacement, 0f);
			return;
			IL_03e3:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			displacement = vector;
			localizableText = localizableText2;
			goto IL_013f;
			IL_00eb:
			localizableText = TextMeshProExtensions.FixOnly(text);
			obj7 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X8_v27+E4]");
			bool flag5 = (nint)0 == 0;
			displacement = (Vector2)0;
			vector = (Vector2)0;
			localizableText2 = localizableText;
			if (!flag5)
			{
				goto IL_013f;
			}
			goto IL_03e3;
			IL_01f9:
			localizableText3 = TextMeshProExtensions.FixOnly(text2);
			obj15 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X8_v11+E4]");
			bool flag6 = (nint)0 == 0;
			displacement2 = (Vector2)0;
			vector2 = (Vector2)0;
			localizableText4 = localizableText3;
			if (!flag6)
			{
				goto IL_024d;
			}
			goto IL_0312;
			IL_0312:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			displacement2 = vector2;
			localizableText3 = localizableText4;
			goto IL_024d;
		}
	}

	private sealed class <>c__DisplayClass22_0
	{
		public string id;

		public AchievementTestView <>4__this;

		internal void <SetAchievementProgress>b__0(KammelnaResponseModel<bool> response)
		{
			//IL_016a: Unknown result type (might be due to invalid IL or missing references)
			//IL_016f: Expected O, but got Unknown
			//IL_0194: Unknown result type (might be due to invalid IL or missing references)
			//IL_0199: Expected O, but got Unknown
			//IL_0280: Expected O, but got I
			//IL_029a: Expected O, but got I4
			//IL_0042: Expected O, but got I4
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Expected O, but got Unknown
			//IL_022e: Expected O, but got I4
			//IL_0237: Expected O, but got I4
			//IL_01dc: Expected O, but got I
			//IL_0086: Unknown result type (might be due to invalid IL or missing references)
			//IL_008b: Expected O, but got Unknown
			//IL_0351: Expected O, but got I
			//IL_036b: Expected O, but got I4
			//IL_02ea: Expected O, but got I4
			//IL_02f3: Expected O, but got I4
			//IL_02fc: Expected O, but got I4
			//IL_0120: Expected O, but got I4
			//IL_0129: Expected O, but got I4
			//IL_00ce: Expected O, but got I
			//IL_03bb: Expected O, but got I4
			//IL_03c4: Expected O, but got I4
			//IL_03cd: Expected O, but got I4
			string text;
			object obj2;
			LocalizableText localizableText;
			Vector2 displacement;
			Vector2 vector;
			LocalizableText localizableText2;
			object obj7;
			if (response.Succeeded)
			{
				object obj = 153100288 + 1024;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
				object format = "WhiteSmoke" + 2648;
				object arg = default(object);
				text = string.Format((string)format, id, arg);
				obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1240;
				object obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X0_v30+E4]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7B7D]");
					object obj4 = (nint)0 & (nint)1;
					if (obj4 != null)
					{
						goto IL_00eb;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7B7D]");
					object obj5 = (nint)0 & (nint)1;
					bool flag = obj5 == null;
					object obj6 = !flag;
					if (obj6 != null)
					{
						goto IL_00eb;
					}
				}
				_ = 1;
				localizableText = TextMeshProExtensions.FixOnly(text);
				obj7 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X8_v27+E4]");
				bool flag2 = (nint)0 == 0;
				object obj8 = !flag2;
				displacement = (Vector2)0;
				vector = (Vector2)0;
				localizableText2 = localizableText;
				if (obj8 != null)
				{
					goto IL_013f;
				}
				goto IL_03e3;
			}
			string errorMessage = response.ErrorMessage;
			object obj9 = "WhiteSmoke" + 2640;
			string text2 = (string)obj9 + errorMessage;
			object obj10 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1240;
			object obj11 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X0_v10+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7B7D]");
				object obj12 = (nint)0 & (nint)1;
				if (obj12 != null)
				{
					goto IL_01f9;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7B7D]");
				object obj13 = (nint)0 & (nint)1;
				bool flag3 = obj13 == null;
				object obj14 = !flag3;
				if (obj14 != null)
				{
					goto IL_01f9;
				}
			}
			_ = 1;
			LocalizableText localizableText3 = TextMeshProExtensions.FixOnly(text2);
			object obj15 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X8_v11+E4]");
			bool flag4 = (nint)0 == 0;
			object obj16 = !flag4;
			Vector2 displacement2 = (Vector2)0;
			Vector2 vector2 = (Vector2)0;
			LocalizableText localizableText4 = localizableText3;
			if (obj16 != null)
			{
				goto IL_024d;
			}
			goto IL_0312;
			IL_024d:
			Toast.Show(localizableText3, displacement2, 0f);
			return;
			IL_013f:
			Toast.Show(localizableText, displacement, 0f);
			return;
			IL_03e3:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			displacement = vector;
			localizableText = localizableText2;
			goto IL_013f;
			IL_00eb:
			localizableText = TextMeshProExtensions.FixOnly(text);
			obj7 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X8_v27+E4]");
			bool flag5 = (nint)0 == 0;
			displacement = (Vector2)0;
			vector = (Vector2)0;
			localizableText2 = localizableText;
			if (!flag5)
			{
				goto IL_013f;
			}
			goto IL_03e3;
			IL_01f9:
			localizableText3 = TextMeshProExtensions.FixOnly(text2);
			obj15 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X8_v11+E4]");
			bool flag6 = (nint)0 == 0;
			displacement2 = (Vector2)0;
			vector2 = (Vector2)0;
			localizableText4 = localizableText3;
			if (!flag6)
			{
				goto IL_024d;
			}
			goto IL_0312;
			IL_0312:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			displacement2 = vector2;
			localizableText3 = localizableText4;
			goto IL_024d;
		}
	}

	private sealed class <>c__DisplayClass23_0
	{
		public string id;

		internal void <ForceUnlockAchievementLevel>b__0(KammelnaResponseModel<bool> response)
		{
			//IL_0062: Unknown result type (might be due to invalid IL or missing references)
			//IL_0067: Expected O, but got Unknown
			//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_0204: Expected O, but got Unknown
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Expected O, but got Unknown
			//IL_012e: Expected O, but got I
			//IL_0148: Expected O, but got I4
			//IL_00dc: Expected O, but got I4
			//IL_00e5: Expected O, but got I4
			//IL_008a: Expected O, but got I
			//IL_0198: Expected O, but got I4
			//IL_01a1: Expected O, but got I4
			//IL_01aa: Expected O, but got I4
			string text;
			object obj;
			if (response.Succeeded)
			{
				text = id;
				obj = "WhiteSmoke" + 2584;
			}
			else
			{
				string errorMessage = response.ErrorMessage;
				obj = "WhiteSmoke" + 2664;
				text = errorMessage;
			}
			string text2 = (string)obj + text;
			object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1240;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X0_v8+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7B7D]");
				object obj4 = (nint)0 & (nint)1;
				if (obj4 != null)
				{
					goto IL_00a7;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7B7D]");
				object obj5 = (nint)0 & (nint)1;
				bool flag = obj5 == null;
				object obj6 = !flag;
				if (obj6 != null)
				{
					goto IL_00a7;
				}
			}
			_ = 1;
			LocalizableText localizableText = TextMeshProExtensions.FixOnly(text2);
			object obj7 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v7+E4]");
			bool flag2 = (nint)0 == 0;
			object obj8 = !flag2;
			Vector2 displacement = (Vector2)0;
			Vector2 vector = (Vector2)0;
			LocalizableText localizableText2 = localizableText;
			if (obj8 != null)
			{
				goto IL_00fb;
			}
			goto IL_01c0;
			IL_00a7:
			localizableText = TextMeshProExtensions.FixOnly(text2);
			obj7 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v7+E4]");
			bool flag3 = (nint)0 == 0;
			displacement = (Vector2)0;
			vector = (Vector2)0;
			localizableText2 = localizableText;
			if (!flag3)
			{
				goto IL_00fb;
			}
			goto IL_01c0;
			IL_01c0:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			displacement = vector;
			localizableText = localizableText2;
			goto IL_00fb;
			IL_00fb:
			Toast.Show(localizableText, displacement, 0f);
		}
	}

	private sealed class <>c__DisplayClass24_0
	{
		public string id;

		internal void <ResetAchievementProgress>b__0(KammelnaResponseModel<bool> response)
		{
			//IL_0062: Unknown result type (might be due to invalid IL or missing references)
			//IL_0067: Expected O, but got Unknown
			//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_0204: Expected O, but got Unknown
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Expected O, but got Unknown
			//IL_012e: Expected O, but got I
			//IL_0148: Expected O, but got I4
			//IL_00dc: Expected O, but got I4
			//IL_00e5: Expected O, but got I4
			//IL_008a: Expected O, but got I
			//IL_0198: Expected O, but got I4
			//IL_01a1: Expected O, but got I4
			//IL_01aa: Expected O, but got I4
			string text;
			object obj;
			if (response.Succeeded)
			{
				text = id;
				obj = "WhiteSmoke" + 2624;
			}
			else
			{
				string errorMessage = response.ErrorMessage;
				obj = "WhiteSmoke" + 2632;
				text = errorMessage;
			}
			string text2 = (string)obj + text;
			object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1240;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X0_v8+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7B7D]");
				object obj4 = (nint)0 & (nint)1;
				if (obj4 != null)
				{
					goto IL_00a7;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7B7D]");
				object obj5 = (nint)0 & (nint)1;
				bool flag = obj5 == null;
				object obj6 = !flag;
				if (obj6 != null)
				{
					goto IL_00a7;
				}
			}
			_ = 1;
			LocalizableText localizableText = TextMeshProExtensions.FixOnly(text2);
			object obj7 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v7+E4]");
			bool flag2 = (nint)0 == 0;
			object obj8 = !flag2;
			Vector2 displacement = (Vector2)0;
			Vector2 vector = (Vector2)0;
			LocalizableText localizableText2 = localizableText;
			if (obj8 != null)
			{
				goto IL_00fb;
			}
			goto IL_01c0;
			IL_00a7:
			localizableText = TextMeshProExtensions.FixOnly(text2);
			obj7 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v7+E4]");
			bool flag3 = (nint)0 == 0;
			displacement = (Vector2)0;
			vector = (Vector2)0;
			localizableText2 = localizableText;
			if (!flag3)
			{
				goto IL_00fb;
			}
			goto IL_01c0;
			IL_01c0:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			displacement = vector;
			localizableText = localizableText2;
			goto IL_00fb;
			IL_00fb:
			Toast.Show(localizableText, displacement, 0f);
		}
	}

	private TMP_Dropdown _achievementDropdown;

	private TMP_InputField _incrementValueInput;

	private TMP_InputField _setValueInput;

	private Button _incrementAchievementButton;

	private Button _setProgressButton;

	private Button _forceUnlockButton;

	private Button _resetButton;

	private Button _closeButton;

	private long _targetUserId;

	private int _incrementValue;

	private int _setValue;

	private List<GameAchievementViewModel> _achievements;

	private ITestPanel _testPanelImplementation;

	private Action _onHide;

	public GameAchievementViewModel SelectedAchievement
	{
		get
		{
			List<object> achievements = (List<object>)(object)_achievements;
			if (_achievements != null)
			{
				if (achievements._size < 1)
				{
					return null;
				}
				TMP_Dropdown achievementDropdown = _achievementDropdown;
				if ((object)_achievementDropdown != null)
				{
					return (GameAchievementViewModel)((List<object>)(object)_achievements).get_Item(achievementDropdown.m_Value);
				}
			}
			return (GameAchievementViewModel)(object)new NullReferenceException();
		}
	}

	private void Start()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00cf: Expected O, but got I4
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected O, but got Unknown
		//IL_013d: Expected O, but got I
		//IL_0167: Expected O, but got I4
		//IL_010f: Expected O, but got I4
		//IL_01fe: Expected O, but got I4
		//IL_0253: Expected I8, but got I4
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Expected O, but got Unknown
		//IL_0288: Expected O, but got I
		//IL_0296: Expected I, but got O
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Expected O, but got Unknown
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7B47]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v28+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v28+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool isProduction = Config.IsProduction;
		bool flag2 = !isProduction;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			goto IL_011d;
		}
		goto IL_02e1;
		IL_02e1:
		GameObject gameObject = base.gameObject;
		gameObject.SetActive(value: false);
		return;
		IL_011d:
		object obj6 = typeof(Queue<string>) + 848;
		object obj7 = (nint)0 + (nint)2200;
		object obj8 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v7+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		if (SFSKammelnaUserExtensions.Can(localUser, UserPermission.RunServerCommands))
		{
			object obj10 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X0_v13+E4]");
			bool flag4 = (nint)0 == 0;
			object obj11 = !flag4;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel2 = default(SessionModel);
			User localUser2 = sessionModel2.LocalUser;
			int intDbId = SFSKammelnaUserExtensions.GetIntDbId(localUser2);
			_targetUserId = intDbId;
			BindButtonEvents();
			object obj12 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj13 = (nint)0 + (nint)1720;
			Action action = default(Action);
			action..ctor(this, (IntPtr)obj13);
			object obj14 = typeof(SqlSingle[]) + 2360;
			object obj15 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X0_v22+E4]");
			if ((nint)0 != 0)
			{
				AchievementsManager.CallWhenLoaded(action);
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			AchievementsManager.CallWhenLoaded(action);
			return;
		}
		goto IL_02e1;
		IL_0074:
		if (!Config.IsProduction)
		{
			goto IL_011d;
		}
		goto IL_02e1;
	}

	private void OnDisable()
	{
		Actions.SafeInvoke(_onHide);
	}

	public void OnDestroy()
	{
		UnBindButtonEvents();
	}

	public void Show(Action onHide)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		object obj = this + 128;
		obj = onHide;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		GameObject gameObject = base.gameObject;
		gameObject.SetActive(value: true);
	}

	public void Hide()
	{
		GameObject gameObject = base.gameObject;
		gameObject.SetActive(value: false);
	}

	public unsafe void IncrementAchievement()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected Ref, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected Ref, but got Unknown
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Expected O, but got Unknown
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_0276: Expected O, but got Unknown
		//IL_0294: Expected O, but got I
		//IL_02ae: Expected O, but got I4
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected O, but got Unknown
		//IL_010d: Expected O, but got I
		//IL_011e: Expected I, but got O
		//IL_022b: Expected O, but got I4
		//IL_0234: Expected O, but got I4
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Expected O, but got Unknown
		//IL_01d1: Expected O, but got I
		//IL_0144: Expected O, but got I
		//IL_0306: Expected O, but got I4
		//IL_030f: Expected O, but got I4
		//IL_0318: Expected O, but got I4
		object obj = typeof(XmlSchemaInclude) + 3736;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		AchievementTestView achievementTestView = default(AchievementTestView);
		if (!achievementTestView.IsDevAccessAllowed() || !ValidateSelected(out *(string*)(obj2 + 24)))
		{
			return;
		}
		TMP_InputField incrementValueInput = _incrementValueInput;
		if (int.TryParse(incrementValueInput.m_Text, out *(int*)(this + 104)))
		{
			object obj4 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 496;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj5 = (nint)0 + (nint)2048;
			Action<object> action = default(Action<object>);
			action..ctor(obj2, (IntPtr)obj5);
			long targetUserId = _targetUserId;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Object)+18]");
			AchievementTestRequests.TriggerAchievement(targetUserId, (string)0, _incrementValue, action);
			GameObject gameObject = base.gameObject;
			gameObject.SetActive(value: false);
			return;
		}
		object obj6 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1240;
		object obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X0_v15+E4]");
		string text;
		string text2;
		if ((nint)0 != 0)
		{
			object obj8 = "WhiteSmoke" + 2600;
			text = (string)obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7B7D]");
			object obj9 = (nint)0 & (nint)1;
			bool flag = obj9 == null;
			text2 = (string)obj8;
			if (!flag)
			{
				goto IL_01f6;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj10 = "WhiteSmoke" + 2600;
			text = (string)obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7B7D]");
			object obj11 = (nint)0 & (nint)1;
			bool flag2 = obj11 == null;
			object obj12 = !flag2;
			text2 = (string)obj10;
			if (obj12 != null)
			{
				goto IL_01f6;
			}
		}
		_ = 1;
		LocalizableText localizableText = TextMeshProExtensions.FixOnly(text2);
		object obj13 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X8_v6+E4]");
		bool flag3 = (nint)0 == 0;
		object obj14 = !flag3;
		Vector2 displacement = (Vector2)0;
		Vector2 vector = (Vector2)0;
		LocalizableText localizableText2 = localizableText;
		if (obj14 != null)
		{
			goto IL_024a;
		}
		goto IL_032e;
		IL_032e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		displacement = vector;
		localizableText = localizableText2;
		goto IL_024a;
		IL_024a:
		Toast.Show(localizableText, displacement, 0f);
		return;
		IL_01f6:
		localizableText = TextMeshProExtensions.FixOnly(text);
		obj13 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X8_v6+E4]");
		bool flag4 = (nint)0 == 0;
		displacement = (Vector2)0;
		vector = (Vector2)0;
		localizableText2 = localizableText;
		if (!flag4)
		{
			goto IL_024a;
		}
		goto IL_032e;
	}

	public unsafe void SetAchievementProgress()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected Ref, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected Ref, but got Unknown
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Expected O, but got Unknown
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Expected O, but got Unknown
		//IL_0277: Expected O, but got I
		//IL_0291: Expected O, but got I4
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected O, but got Unknown
		//IL_010d: Expected O, but got I
		//IL_011e: Expected I, but got O
		//IL_020e: Expected O, but got I4
		//IL_0217: Expected O, but got I4
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Expected O, but got Unknown
		//IL_01b4: Expected O, but got I
		//IL_0144: Expected O, but got I
		//IL_02e9: Expected O, but got I4
		//IL_02f2: Expected O, but got I4
		//IL_02fb: Expected O, but got I4
		object obj = typeof(XmlSchemaInclude) + 3744;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 24;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		AchievementTestView achievementTestView = default(AchievementTestView);
		if (!achievementTestView.IsDevAccessAllowed() || !ValidateSelected(out *(string*)(obj2 + 16)))
		{
			return;
		}
		TMP_InputField setValueInput = _setValueInput;
		if (int.TryParse(setValueInput.m_Text, out *(int*)(this + 108)))
		{
			object obj4 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 496;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj5 = (nint)0 + (nint)2056;
			Action<object> action = default(Action<object>);
			action..ctor(obj2, (IntPtr)obj5);
			long targetUserId = _targetUserId;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Object)+10]");
			AchievementTestRequests.SetProgress(targetUserId, (string)0, _setValue, action);
			return;
		}
		object obj6 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1240;
		object obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X0_v15+E4]");
		string text;
		string text2;
		if ((nint)0 != 0)
		{
			object obj8 = "WhiteSmoke" + 2608;
			text = (string)obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7B7D]");
			object obj9 = (nint)0 & (nint)1;
			bool flag = obj9 == null;
			text2 = (string)obj8;
			if (!flag)
			{
				goto IL_01d9;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj10 = "WhiteSmoke" + 2608;
			text = (string)obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7B7D]");
			object obj11 = (nint)0 & (nint)1;
			bool flag2 = obj11 == null;
			object obj12 = !flag2;
			text2 = (string)obj10;
			if (obj12 != null)
			{
				goto IL_01d9;
			}
		}
		_ = 1;
		LocalizableText localizableText = TextMeshProExtensions.FixOnly(text2);
		object obj13 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X8_v6+E4]");
		bool flag3 = (nint)0 == 0;
		object obj14 = !flag3;
		Vector2 displacement = (Vector2)0;
		Vector2 vector = (Vector2)0;
		LocalizableText localizableText2 = localizableText;
		if (obj14 != null)
		{
			goto IL_022d;
		}
		goto IL_0311;
		IL_0311:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		displacement = vector;
		localizableText = localizableText2;
		goto IL_022d;
		IL_022d:
		Toast.Show(localizableText, displacement, 0f);
		return;
		IL_01d9:
		localizableText = TextMeshProExtensions.FixOnly(text);
		obj13 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X8_v6+E4]");
		bool flag4 = (nint)0 == 0;
		displacement = (Vector2)0;
		vector = (Vector2)0;
		localizableText2 = localizableText;
		if (!flag4)
		{
			goto IL_022d;
		}
		goto IL_0311;
	}

	public unsafe void ForceUnlockAchievementLevel()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected Ref, but got Unknown
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		//IL_0091: Expected O, but got I
		//IL_00a2: Expected I, but got O
		//IL_00c2: Expected O, but got I
		object obj = typeof(XmlSchemaInclude) + 3752;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (((AchievementTestView)obj2).IsDevAccessAllowed() && ValidateSelected(out *(string*)(obj2 + 16)))
		{
			object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 496;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj4 = (nint)0 + (nint)2064;
			Action<object> action = default(Action<object>);
			action..ctor(obj2, (IntPtr)obj4);
			long targetUserId = _targetUserId;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v3 (System.Object)+10]");
			AchievementTestRequests.ForceUnlock(targetUserId, (string)0, action);
		}
	}

	public unsafe void ResetAchievementProgress()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected Ref, but got Unknown
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		//IL_0091: Expected O, but got I
		//IL_00a2: Expected I, but got O
		//IL_00c2: Expected O, but got I
		object obj = typeof(XmlSchemaInclude) + 3760;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (((AchievementTestView)obj2).IsDevAccessAllowed() && ValidateSelected(out *(string*)(obj2 + 16)))
		{
			object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 496;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj4 = (nint)0 + (nint)2072;
			Action<object> action = default(Action<object>);
			action..ctor(obj2, (IntPtr)obj4);
			long targetUserId = _targetUserId;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v3 (System.Object)+10]");
			AchievementTestRequests.ResetAchievement(targetUserId, (string)0, action);
		}
	}

	private void BindButtonEvents()
	{
		//IL_025d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0262: Expected O, but got Unknown
		//IL_0285: Expected O, but got I
		//IL_0011: Expected O, but got I
		//IL_0029: Expected I, but got O
		//IL_0094: Expected O, but got I
		//IL_00ac: Expected I, but got O
		//IL_0049: Expected O, but got I4
		//IL_005a: Expected O, but got I4
		//IL_0117: Expected O, but got I
		//IL_012f: Expected I, but got O
		//IL_00cc: Expected O, but got I4
		//IL_00dd: Expected O, but got I4
		//IL_019a: Expected O, but got I
		//IL_01b2: Expected I, but got O
		//IL_014f: Expected O, but got I4
		//IL_0160: Expected O, but got I4
		//IL_021d: Expected O, but got I
		//IL_0235: Expected I, but got O
		//IL_01d2: Expected O, but got I4
		//IL_01e3: Expected O, but got I4
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		Button incrementAchievementButton = _incrementAchievementButton;
		bool flag = (object)_incrementAchievementButton == null;
		IntPtr intPtr = default(IntPtr);
		UnityAction unityAction = (UnityAction)(nint)intPtr;
		if (!flag)
		{
			object obj2 = (nint)0 + (nint)1712;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			UnityAction unityAction2 = default(UnityAction);
			unityAction2..ctor(this, (IntPtr)obj2);
			incrementAchievementButton.m_OnClick.AddListener(unityAction2);
			object obj3 = 0;
			unityAction = unityAction2;
			object obj4 = 0;
		}
		Button setProgressButton = _setProgressButton;
		if ((object)_setProgressButton != null)
		{
			object obj5 = (nint)0 + (nint)1736;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			UnityAction unityAction3 = default(UnityAction);
			unityAction3..ctor(this, (IntPtr)obj5);
			setProgressButton.m_OnClick.AddListener(unityAction3);
			object obj3 = 0;
			unityAction = unityAction3;
			object obj4 = 0;
		}
		Button forceUnlockButton = _forceUnlockButton;
		if ((object)_forceUnlockButton != null)
		{
			object obj6 = (nint)0 + (nint)1704;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			UnityAction unityAction4 = default(UnityAction);
			unityAction4..ctor(this, (IntPtr)obj6);
			forceUnlockButton.m_OnClick.AddListener(unityAction4);
			object obj3 = 0;
			unityAction = unityAction4;
			object obj4 = 0;
		}
		Button resetButton = _resetButton;
		if ((object)_resetButton != null)
		{
			object obj7 = (nint)0 + (nint)1728;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			UnityAction unityAction5 = default(UnityAction);
			unityAction5..ctor(this, (IntPtr)obj7);
			resetButton.m_OnClick.AddListener(unityAction5);
			object obj3 = 0;
			unityAction = unityAction5;
			object obj4 = 0;
		}
		Button closeButton = _closeButton;
		if ((object)_closeButton != null)
		{
			object obj8 = (nint)0 + (nint)1688;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			UnityAction unityAction6 = default(UnityAction);
			unityAction6..ctor(this, (IntPtr)obj8);
			closeButton.m_OnClick.AddListener(unityAction6);
		}
	}

	private void UnBindButtonEvents()
	{
		//IL_025d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0262: Expected O, but got Unknown
		//IL_0285: Expected O, but got I
		//IL_0011: Expected O, but got I
		//IL_0029: Expected I, but got O
		//IL_0094: Expected O, but got I
		//IL_00ac: Expected I, but got O
		//IL_0049: Expected O, but got I4
		//IL_005a: Expected O, but got I4
		//IL_0117: Expected O, but got I
		//IL_012f: Expected I, but got O
		//IL_00cc: Expected O, but got I4
		//IL_00dd: Expected O, but got I4
		//IL_019a: Expected O, but got I
		//IL_01b2: Expected I, but got O
		//IL_014f: Expected O, but got I4
		//IL_0160: Expected O, but got I4
		//IL_021d: Expected O, but got I
		//IL_0235: Expected I, but got O
		//IL_01d2: Expected O, but got I4
		//IL_01e3: Expected O, but got I4
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		Button incrementAchievementButton = _incrementAchievementButton;
		bool flag = (object)_incrementAchievementButton == null;
		IntPtr intPtr = default(IntPtr);
		UnityAction unityAction = (UnityAction)(nint)intPtr;
		if (!flag)
		{
			object obj2 = (nint)0 + (nint)1712;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			UnityAction unityAction2 = default(UnityAction);
			unityAction2..ctor(this, (IntPtr)obj2);
			incrementAchievementButton.m_OnClick.RemoveListener(unityAction2);
			object obj3 = 0;
			unityAction = unityAction2;
			object obj4 = 0;
		}
		Button setProgressButton = _setProgressButton;
		if ((object)_setProgressButton != null)
		{
			object obj5 = (nint)0 + (nint)1736;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			UnityAction unityAction3 = default(UnityAction);
			unityAction3..ctor(this, (IntPtr)obj5);
			setProgressButton.m_OnClick.RemoveListener(unityAction3);
			object obj3 = 0;
			unityAction = unityAction3;
			object obj4 = 0;
		}
		Button forceUnlockButton = _forceUnlockButton;
		if ((object)_forceUnlockButton != null)
		{
			object obj6 = (nint)0 + (nint)1704;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			UnityAction unityAction4 = default(UnityAction);
			unityAction4..ctor(this, (IntPtr)obj6);
			forceUnlockButton.m_OnClick.RemoveListener(unityAction4);
			object obj3 = 0;
			unityAction = unityAction4;
			object obj4 = 0;
		}
		Button resetButton = _resetButton;
		if ((object)_resetButton != null)
		{
			object obj7 = (nint)0 + (nint)1728;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			UnityAction unityAction5 = default(UnityAction);
			unityAction5..ctor(this, (IntPtr)obj7);
			resetButton.m_OnClick.RemoveListener(unityAction5);
			object obj3 = 0;
			unityAction = unityAction5;
			object obj4 = 0;
		}
		Button closeButton = _closeButton;
		if ((object)_closeButton != null)
		{
			object obj8 = (nint)0 + (nint)1696;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			UnityAction unityAction6 = default(UnityAction);
			unityAction6..ctor(this, (IntPtr)obj8);
			closeButton.m_OnClick.RemoveListener(unityAction6);
		}
	}

	private void PopulateDropdown()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_01b5: Expected O, but got I4
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_008a: Expected O, but got I
		//IL_00b4: Expected O, but got I4
		//IL_01d5: Expected O, but got I
		//IL_01e5: Expected O, but got I
		//IL_0207: Expected O, but got I4
		//IL_00fb: Expected O, but got I4
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Expected O, but got Unknown
		//IL_023f: Expected O, but got I
		//IL_0250: Expected I, but got O
		//IL_026e: Expected O, but got I
		//IL_012b: Expected O, but got I
		object obj = typeof(SqlSingle[]) + 2360;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		IEnumerable<GameAchievementViewModel> gameAchievements = AchievementsManager.GameAchievements;
		List<object> list = Enumerable.ToList((IEnumerable<object>)gameAchievements);
		object obj4 = this + 112;
		obj4 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = typeof(XmlSchemaInclude) + 3728;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X20_v4-50]");
		((TMP_Dropdown)0).ClearOptions();
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X0_v13+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj6 = obj5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X0_v13+B8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X8_v8+8]");
		Func<object, object> selector = (Func<object, object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X8_v8+8]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X0_v13+E4]");
			bool flag4 = (nint)0 == 0;
			object obj10 = !flag4;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj11 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X8_v14+B8]");
				obj8 = 0;
			}
			object obj12 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1272;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj13 = (nint)0 + (nint)2040;
			Func<object, object> func = default(Func<object, object>);
			func..ctor(obj8, (IntPtr)obj13);
			object obj14 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X8_v13+B8]");
			object obj15 = (nint)0 + (nint)8;
			obj15 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			selector = func;
		}
		IEnumerable<object> source = Enumerable.Select(_achievements, selector);
		List<object> options = Enumerable.ToList(source);
		_achievementDropdown.AddOptions((List<TMP_Dropdown.OptionData>)(object)options);
		_achievementDropdown.value = 0;
		_achievementDropdown.RefreshShownValue();
	}

	private bool IsDevAccessAllowed()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00d0: Expected O, but got I4
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Expected O, but got Unknown
		//IL_013e: Expected O, but got I
		//IL_0168: Expected O, but got I4
		//IL_0110: Expected O, but got I4
		//IL_01e3: Expected I4, but got O
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7B4D]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v10+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v10+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool isProduction = Config.IsProduction;
		bool flag2 = !isProduction;
		object obj5 = !flag2;
		if (obj5 != null)
		{
			goto IL_009a;
		}
		goto IL_011e;
		IL_009a:
		return false;
		IL_011e:
		object obj6 = typeof(Queue<string>) + 848;
		object obj7 = (nint)0 + (nint)2200;
		object obj8 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v2+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		if ((object)sessionModel != null)
		{
			User localUser = sessionModel.LocalUser;
			return SFSKammelnaUserExtensions.Can(localUser, UserPermission.RunServerCommands);
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_0074:
		if (Config.IsProduction)
		{
			goto IL_009a;
		}
		goto IL_011e;
	}

	private unsafe bool ValidateSelected(out string achievementId)
	{
		//IL_03a3: Expected I4, but got O
		//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e7: Expected O, but got Unknown
		//IL_0311: Expected O, but got I4
		//IL_0338: Unknown result type (might be due to invalid IL or missing references)
		//IL_033d: Expected O, but got Unknown
		//IL_035b: Expected O, but got I
		//IL_003d: Expected O, but got I
		//IL_0057: Expected O, but got I4
		//IL_02af: Expected I, but got O
		//IL_043f: Expected O, but got I4
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Expected O, but got Unknown
		//IL_0217: Expected O, but got I4
		//IL_0460: Expected O, but got I4
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Expected O, but got Unknown
		//IL_0261: Expected O, but got I
		//IL_027b: Expected O, but got I4
		//IL_0283: Expected I, but got O
		//IL_00f4: Expected O, but got I
		ref string reference = ref *(string*)null;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		List<object> achievements = (List<object>)(object)_achievements;
		object obj;
		string text;
		object obj6;
		string text2;
		object obj9 = default(object);
		nint num;
		if (_achievements != null)
		{
			if (achievements._size == 0)
			{
				obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1240;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X0_v15+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj4 = "WhiteSmoke" + 2576;
				text = (string)obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7B7D]");
				object obj5 = (nint)0 & (nint)1;
				if (obj5 == null)
				{
					goto IL_02a1;
				}
				IntPtr intPtr = default(IntPtr);
				num = intPtr;
				obj6 = obj;
				text2 = (string)obj4;
				goto IL_0408;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7B8E]");
			object obj7 = (nint)0 & (nint)1;
			bool flag2 = obj7 == null;
			object obj8 = !flag2;
			if (obj8 == null)
			{
				_ = 1;
				achievements = (List<object>)(object)_achievements;
				if (_achievements == null)
				{
					goto IL_0395;
				}
			}
			bool flag3 = achievements._size < 1;
			int num2 = 0;
			if (flag3)
			{
				goto IL_01d9;
			}
			TMP_Dropdown achievementDropdown = _achievementDropdown;
			if ((object)_achievementDropdown != null)
			{
				obj9 = (nint)0 + (nint)2512;
				num2 = achievementDropdown.m_Value;
				object obj10 = achievements.get_Item(achievementDropdown.m_Value);
				if (obj10 == null)
				{
					goto IL_01d9;
				}
				List<object> achievements2 = (List<object>)(object)_achievements;
				if (_achievements != null && achievements2._size >= 1)
				{
					TMP_Dropdown achievementDropdown2 = _achievementDropdown;
					if ((object)_achievementDropdown != null)
					{
						object obj11 = ((List<object>)(object)_achievements).get_Item(achievementDropdown2.m_Value);
						if (obj11 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X0_v30 (System.Object)+10]");
							reference = ref *(string*)null;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							return true;
						}
					}
				}
			}
		}
		goto IL_0395;
		IL_0408:
		LocalizableText text3 = TextMeshProExtensions.FixOnly(text2);
		object obj12 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X8_v6+E4]");
		bool flag4 = (nint)0 == 0;
		object obj13 = !flag4;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Toast.Show(text3, (Vector2)0, 0f);
		return false;
		IL_01d9:
		obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1240;
		object obj14 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X0_v24+E4]");
		bool flag5 = (nint)0 == 0;
		object obj15 = !flag5;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj16 = "WhiteSmoke" + 2616;
		text = (string)obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7B7D]");
		object obj17 = (nint)0 & (nint)1;
		bool flag6 = obj17 == null;
		object obj18 = !flag6;
		num = (nint)obj9;
		obj6 = obj;
		text2 = (string)obj16;
		if (obj18 == null)
		{
			goto IL_02a1;
		}
		goto IL_0408;
		IL_02a1:
		_ = 1;
		num = (nint)obj9;
		obj6 = obj;
		text2 = text;
		goto IL_0408;
		IL_0395:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	public AchievementTestView()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		object obj = typeof(List<AdaptivePerformanceScaler>) + 1152;
		_incrementValue = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj2 = this + 112;
		obj2 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
	}

	private void <BindButtonEvents>b__25_0()
	{
		GameObject gameObject = base.gameObject;
		gameObject.SetActive(value: false);
	}

	private void <UnBindButtonEvents>b__26_0()
	{
		GameObject gameObject = base.gameObject;
		gameObject.SetActive(value: false);
	}
}
