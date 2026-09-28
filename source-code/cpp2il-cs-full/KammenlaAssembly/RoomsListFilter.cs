using System;
using System.Diagnostics;
using System.Threading;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Features.GameReplay;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json.Linq.JsonPath;
using Unity.Properties;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using Util.SystemHelpers;

public class RoomsListFilter : MonoBehaviour
{
	private InputField filterWord;

	private KRadioPicker filterRoomType;

	private KRadioPicker filterGameType;

	private KRadioPicker filterPlayingSpeed;

	private KRadioPicker filterRoomLocked;

	private Image filtersTopBar;

	public UnityEvent<RoomsFilterModel> OnFilterUpdated;

	private void Awake()
	{
		//IL_0751: Expected O, but got I4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_0044: Expected I, but got O
		//IL_0052: Expected I, but got O
		//IL_0074: Expected O, but got I4
		//IL_008e: Expected O, but got I
		//IL_0096: Expected I, but got O
		//IL_00cc: Expected O, but got I4
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected O, but got Unknown
		//IL_0104: Expected O, but got I
		//IL_011c: Expected I, but got O
		//IL_01a6: Expected O, but got I4
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Expected O, but got Unknown
		//IL_01dd: Expected O, but got I
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Expected O, but got Unknown
		//IL_0205: Expected I, but got O
		//IL_02d7: Expected O, but got I4
		//IL_0305: Expected O, but got I4
		//IL_030e: Expected O, but got I4
		//IL_033b: Expected O, but got I
		//IL_0344: Unknown result type (might be due to invalid IL or missing references)
		//IL_0349: Expected O, but got Unknown
		//IL_0361: Expected I, but got O
		//IL_0297: Expected O, but got I4
		//IL_0433: Expected O, but got I4
		//IL_0461: Expected O, but got I4
		//IL_046a: Expected O, but got I4
		//IL_02b6: Expected O, but got I4
		//IL_0497: Expected O, but got I
		//IL_04a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a5: Expected O, but got Unknown
		//IL_04bd: Expected I, but got O
		//IL_04eb: Expected O, but got I4
		//IL_03f3: Expected O, but got I4
		//IL_0698: Expected O, but got I4
		//IL_06ce: Expected O, but got I4
		//IL_06d7: Expected O, but got I4
		//IL_05b0: Expected O, but got I
		//IL_05b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05be: Expected O, but got Unknown
		//IL_05d9: Expected I, but got O
		//IL_0412: Expected O, but got I4
		//IL_0607: Expected O, but got I4
		//IL_0716: Expected O, but got I4
		//IL_0564: Expected O, but got I4
		//IL_0583: Expected O, but got I4
		//IL_064a: Expected O, but got I4
		//IL_0653: Expected O, but got I4
		//IL_067b: Expected O, but got I4
		InputField inputField = filterWord;
		bool flag = (object)filterWord == null;
		UnityEvent<object> unityEvent = (UnityEvent<object>)152989696;
		object obj8;
		UnityEvent<object> unityEvent2;
		object obj3;
		nint num;
		if (!flag)
		{
			object obj = typeof(TypeConverter<ushort, char>) + 464;
			object obj2 = (nint)0 + (nint)3048;
			unityEvent = (UnityEvent<object>)(object)inputField.m_OnDidEndEdit;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			num = (nint)obj2;
			UnityAction<object> unityAction = default(UnityAction<object>);
			unityAction..ctor((object)this, (IntPtr)obj2);
			bool flag2 = inputField.m_OnDidEndEdit == null;
			obj3 = 0;
			if (!flag2)
			{
				object obj4 = (nint)0 + (nint)1208;
				num = (nint)obj4;
				((UnityEvent<object>)(object)inputField.m_OnDidEndEdit).AddListener(unityAction);
				InputField inputField2 = filterWord;
				bool flag3 = (object)filterWord == null;
				obj3 = 0;
				unityEvent = (UnityEvent<object>)(object)filterWord;
				if (!flag3)
				{
					object obj5 = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 3456;
					object obj6 = (nint)0 + (nint)3088;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					InputField.OnValidateInput onValidateInput = default(InputField.OnValidateInput);
					onValidateInput..ctor(this, (IntPtr)obj6);
					Delegate obj7 = Delegate.Combine(inputField2.m_OnValidateInput, onValidateInput);
					if ((object)obj7 != null && obj7 != obj5)
					{
						throw new InvalidCastException();
					}
					filterWord.onValidateInput = (InputField.OnValidateInput)obj7;
					unityEvent = (UnityEvent<object>)(object)filterRoomType;
					bool flag4 = (object)filterRoomType == null;
					obj3 = 0;
					num = 0;
					if (!flag4)
					{
						obj8 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2416;
						object obj9 = (nint)0 + (nint)3056;
						object a = filterRoomType + 200;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						Action<int> action = default(Action<int>);
						action..ctor((object)this, (IntPtr)obj9);
						Delegate obj10 = Delegate.Combine((Delegate)a, action);
						if ((object)obj10 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
							object obj11 = default(object);
							if (obj11 == null)
							{
								goto IL_071b;
							}
							a = obj11;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							unityEvent2 = (UnityEvent<object>)(object)filterGameType;
							bool flag5 = (object)filterGameType == null;
							object obj12 = !flag5;
							object obj13 = obj11;
							if (obj12 != null)
							{
								goto IL_032f;
							}
							obj3 = 0;
							num = 0;
							unityEvent = (UnityEvent<object>)(object)filterGameType;
						}
						else
						{
							a = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							unityEvent2 = (UnityEvent<object>)(object)filterGameType;
							bool flag6 = (object)filterGameType == null;
							object obj13 = 0;
							obj3 = 0;
							num = 0;
							unityEvent = (UnityEvent<object>)(object)filterGameType;
							if (!flag6)
							{
								goto IL_032f;
							}
						}
					}
				}
			}
		}
		goto IL_0702;
		IL_05a4:
		object obj14 = (nint)0 + (nint)3080;
		UnityEvent<object> unityEvent3;
		unityEvent = (UnityEvent<object>)(unityEvent3 + 200);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<int> action2 = default(Action<int>);
		RoomsListFilter roomsListFilter;
		action2..ctor((object)roomsListFilter, (IntPtr)obj14);
		Delegate obj15 = Delegate.Combine((Delegate)(object)unityEvent, action2);
		bool flag7 = (object)obj15 == null;
		obj3 = 0;
		num = 0;
		object obj18;
		object obj19;
		nint num2;
		if (!flag7)
		{
			roomsListFilter = (RoomsListFilter)obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
			object obj16 = default(object);
			bool flag8 = obj16 == null;
			object obj17 = !flag8;
			obj3 = 0;
			obj18 = obj16;
			num = 0;
			if (obj17 == null)
			{
				obj19 = 0;
				num2 = 0;
				throw new InvalidCastException();
			}
		}
		else
		{
			obj18 = 0;
		}
		unityEvent = (UnityEvent<object>)obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return;
		IL_071b:
		throw new InvalidCastException();
		IL_0702:
		throw new NullReferenceException();
		IL_048b:
		object obj20 = (nint)0 + (nint)3072;
		UnityEvent<object> unityEvent4;
		unityEvent = (UnityEvent<object>)(unityEvent4 + 200);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<int> action3 = default(Action<int>);
		action3..ctor((object)this, (IntPtr)obj20);
		Delegate obj21 = Delegate.Combine((Delegate)(object)unityEvent, action3);
		bool flag9 = (object)obj21 == null;
		obj19 = 0;
		num2 = 0;
		roomsListFilter = this;
		if (!flag9)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
			object obj22 = default(object);
			if (obj22 == null)
			{
				goto IL_071b;
			}
			unityEvent = (UnityEvent<object>)obj22;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			unityEvent3 = (UnityEvent<object>)(object)filterRoomLocked;
			bool flag10 = (object)filterRoomLocked == null;
			obj19 = 0;
			object obj23 = obj22;
			num2 = 0;
			roomsListFilter = this;
			obj3 = 0;
			num = 0;
			unityEvent = (UnityEvent<object>)(object)filterRoomLocked;
			if (!flag10)
			{
				goto IL_05a4;
			}
		}
		else
		{
			unityEvent = (UnityEvent<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			unityEvent3 = (UnityEvent<object>)(object)roomsListFilter.filterRoomLocked;
			bool flag11 = (object)roomsListFilter.filterRoomLocked == null;
			object obj24 = !flag11;
			object obj23 = 0;
			obj3 = obj19;
			num = num2;
			unityEvent = (UnityEvent<object>)(object)roomsListFilter.filterRoomLocked;
			if (obj24 != null)
			{
				goto IL_05a4;
			}
		}
		goto IL_0702;
		IL_032f:
		object obj25 = (nint)0 + (nint)3064;
		object a2 = unityEvent2 + 200;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<int> action4 = default(Action<int>);
		action4..ctor((object)this, (IntPtr)obj25);
		Delegate obj26 = Delegate.Combine((Delegate)a2, action4);
		if ((object)obj26 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
			object obj27 = default(object);
			if (obj27 == null)
			{
				goto IL_071b;
			}
			a2 = obj27;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			unityEvent4 = (UnityEvent<object>)(object)filterPlayingSpeed;
			bool flag12 = (object)filterPlayingSpeed == null;
			object obj28 = !flag12;
			object obj29 = obj27;
			if (obj28 != null)
			{
				goto IL_048b;
			}
			obj3 = 0;
			num = 0;
			unityEvent = (UnityEvent<object>)(object)filterPlayingSpeed;
		}
		else
		{
			a2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			unityEvent4 = (UnityEvent<object>)(object)filterPlayingSpeed;
			bool flag13 = (object)filterPlayingSpeed == null;
			object obj29 = 0;
			obj3 = 0;
			num = 0;
			unityEvent = (UnityEvent<object>)(object)filterPlayingSpeed;
			if (!flag13)
			{
				goto IL_048b;
			}
		}
		goto IL_0702;
	}

	private char OnValidateInput(string text, int charIndex, char addedChar)
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		//IL_0069: Expected O, but got I4
		if (addedChar == '\n' || addedChar == '\r')
		{
			return '\0';
		}
		object obj = typeof(System.IOAsyncCallback) + 3096;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		return InputSanitizer.UserInputValidationCallback(text, charIndex, addedChar);
	}

	private void UpdateFilter()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_004d: Expected I4, but got O
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_013d: Expected O, but got I
		//IL_017e: Expected O, but got I4
		//IL_026b: Expected O, but got I
		//IL_02ac: Expected O, but got I4
		//IL_00d4: Expected O, but got I
		//IL_0115: Expected O, but got I4
		//IL_030e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0313: Expected O, but got Unknown
		//IL_033d: Expected O, but got I4
		//IL_0202: Expected O, but got I
		//IL_0243: Expected O, but got I4
		//IL_0527: Expected O, but got I4
		//IL_0476: Expected O, but got I4
		//IL_04a8: Expected O, but got I4
		//IL_03f5: Expected O, but got I4
		if (OnFilterUpdated == null)
		{
			return;
		}
		object obj = typeof(RegisteredWaitHandle) + 1456;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		InputField inputField = filterWord;
		System.Int32Enum int32Enum = (System.Int32Enum)inputField.m_Text;
		object obj3 = obj2 + 16;
		obj3 = inputField.m_Text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		KRadioPicker kRadioPicker = filterRoomType;
		KRadioPicker kRadioPicker2;
		if (kRadioPicker.<SelectedIndex>k__BackingField != 2)
		{
			if (kRadioPicker.<SelectedIndex>k__BackingField == 1)
			{
				object obj4 = (nint)0 + (nint)2704;
				object obj5 = obj4;
				System.Int32Enum? int32Enum2 = (System.Int32Enum)1;
				kRadioPicker2 = filterGameType;
				bool flag = (object)filterGameType == null;
				object obj6 = !flag;
				int32Enum = (System.Int32Enum)1;
				if (obj6 == null)
				{
					goto IL_04b6;
				}
			}
			else
			{
				_ = 0;
				kRadioPicker2 = filterGameType;
			}
		}
		else
		{
			object obj7 = (nint)0 + (nint)2704;
			object obj5 = obj7;
			System.Int32Enum? int32Enum2 = (System.Int32Enum)0;
			kRadioPicker2 = filterGameType;
			bool flag2 = (object)filterGameType == null;
			object obj8 = !flag2;
			int32Enum = (System.Int32Enum)0;
			if (obj8 == null)
			{
				goto IL_04b6;
			}
		}
		KRadioPicker kRadioPicker3;
		if (kRadioPicker2.<SelectedIndex>k__BackingField != 2)
		{
			if (kRadioPicker2.<SelectedIndex>k__BackingField == 1)
			{
				object obj9 = (nint)0 + (nint)2008;
				object obj5 = obj9;
				bool? flag3 = true;
				kRadioPicker3 = filterPlayingSpeed;
				bool flag4 = (object)filterPlayingSpeed == null;
				object obj10 = !flag4;
				int32Enum = (System.Int32Enum)1;
				if (obj10 == null)
				{
					goto IL_04b6;
				}
			}
			else
			{
				_ = 0;
				kRadioPicker3 = filterPlayingSpeed;
			}
		}
		else
		{
			object obj11 = (nint)0 + (nint)2008;
			object obj5 = obj11;
			bool? flag5 = false;
			kRadioPicker3 = filterPlayingSpeed;
			bool flag6 = (object)filterPlayingSpeed == null;
			object obj12 = !flag6;
			int32Enum = (System.Int32Enum)0;
			if (obj12 == null)
			{
				goto IL_04b6;
			}
		}
		KRadioPicker kRadioPicker4;
		if (kRadioPicker3.<SelectedIndex>k__BackingField != 0)
		{
			object obj13 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
			object obj14 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ X8_v36+E4]");
			bool flag7 = (nint)0 == 0;
			object obj15 = !flag7;
			if (obj15 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int speedIndexValue = KUtil.GetSpeedIndexValue(kRadioPicker3.<SelectedIndex>k__BackingField);
			int? num = speedIndexValue;
			kRadioPicker4 = filterRoomLocked;
			bool flag8 = (object)filterRoomLocked == null;
			object obj16 = !flag8;
			if (obj16 == null)
			{
				goto IL_04b6;
			}
		}
		else
		{
			_ = 0;
			kRadioPicker4 = filterRoomLocked;
		}
		KRadioPicker kRadioPicker5;
		if (kRadioPicker4.<SelectedIndex>k__BackingField != 2)
		{
			if (kRadioPicker4.<SelectedIndex>k__BackingField == 1)
			{
				bool? flag9 = false;
				kRadioPicker5 = filterRoomType;
				bool flag10 = (object)filterRoomType == null;
				object obj17 = !flag10;
				if (obj17 != null)
				{
					goto IL_042b;
				}
			}
			else
			{
				_ = 0;
				kRadioPicker5 = filterRoomType;
				bool flag11 = (object)filterRoomType == null;
				object obj18 = !flag11;
				if (obj18 != null)
				{
					goto IL_042b;
				}
			}
			goto IL_04b6;
		}
		bool? flag12 = true;
		kRadioPicker5 = filterRoomType;
		goto IL_042b;
		IL_042b:
		if (kRadioPicker5.<SelectedIndex>k__BackingField == 3)
		{
			bool? flag13 = true;
			bool? flag14 = flag13;
		}
		else
		{
			bool? flag14 = (bool?)(object)0;
		}
		((UnityEvent<object>)(object)OnFilterUpdated).Invoke(obj2);
		return;
		IL_04b6:
		throw new NullReferenceException();
	}

	public void ShowFilters()
	{
		UIExtensions.ShowKeyboard(filterWord);
		GameObject gameObject = filtersTopBar.gameObject;
		gameObject.SetActive(value: true);
		TweenerCore<Color, Color, ColorOptions> tweenerCore = DOTweenModuleUI.DOFade(filtersTopBar, 1f, 0.2f);
	}

	public void HideFilters()
	{
		//IL_000c: Expected O, but got I
		object obj = (nint)0 + (nint)2456;
		TweenerCore<Color, Color, ColorOptions> tweenerCore = DOTweenModuleUI.DOFade(filtersTopBar, 0f, 0.2f);
		TweenCallback tweenCallback = TweenHelpers.Disable(filtersTopBar);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
	}

	public void ResetFilters()
	{
		//IL_0014: Expected O, but got I4
		//IL_0024: Expected O, but got I
		//IL_0034: Expected O, but got I
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		//IL_00bf: Expected O, but got I4
		//IL_018a: Expected O, but got I
		object obj = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v5+90]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v6+B8]");
		object text = 0;
		filterWord.text = (string)text;
		object obj3 = typeof(MemberAchievementClanFeedData) + 2976;
		filterRoomType.Select(0);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X0_v6+E4]");
		if ((nint)0 != 0)
		{
			bool flag = filterGameType != null;
			bool flag2 = !flag;
			object obj5 = !flag2;
			if (obj5 != null)
			{
				goto IL_010a;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			if (filterGameType != null)
			{
				goto IL_010a;
			}
		}
		goto IL_0159;
		IL_0159:
		filterPlayingSpeed.Select(0);
		filterRoomLocked.Select(0);
		object obj6 = (nint)0 + (nint)2456;
		TweenerCore<Color, Color, ColorOptions> tweenerCore = DOTweenModuleUI.DOFade(filtersTopBar, 0f, 0.2f);
		TweenCallback tweenCallback = TweenHelpers.Disable(filtersTopBar);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
		return;
		IL_010a:
		GameObject gameObject = filterGameType.gameObject;
		if (gameObject.activeInHierarchy)
		{
			filterGameType.Select(0);
		}
		goto IL_0159;
	}

	private void <Awake>b__7_0(string s)
	{
		UpdateFilter();
	}

	private void <Awake>b__7_1(int i)
	{
		UpdateFilter();
	}

	private void <Awake>b__7_2(int i)
	{
		UpdateFilter();
	}

	private void <Awake>b__7_3(int i)
	{
		UpdateFilter();
	}

	private void <Awake>b__7_4(int i)
	{
		UpdateFilter();
	}
}
