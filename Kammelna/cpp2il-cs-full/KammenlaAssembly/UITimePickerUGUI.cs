using System;
using System.Data;
using System.Data.SqlTypes;
using Cpp2ILInjected;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem.UI;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class UITimePickerUGUI : MonoBehaviour
{
	public delegate void OnSelectDelegate(string time);

	public Button CloseButton;

	public UIPicker hoursPicker;

	public UIPicker minutesPicker;

	public UIPicker ampmPicker;

	public TextMeshProUGUI field;

	public string time;

	private string[] ampm;

	private OnSelectDelegate m_OnSelect;

	public event OnSelectDelegate OnSelect
	{
		add
		{
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			object obj = typeof(TrackedDeviceRaycaster.<>c) + 1040;
			object obj2 = this + 88;
			Delegate obj3 = (Delegate)obj2;
			bool flag;
			Delegate obj5 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Combine(obj3, value);
				if ((object)obj4 == null || obj4 == obj)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj5 == obj3;
					obj3 = obj5;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
		remove
		{
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			object obj = typeof(TrackedDeviceRaycaster.<>c) + 1040;
			object obj2 = this + 88;
			Delegate obj3 = (Delegate)obj2;
			bool flag;
			Delegate obj5 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Remove(obj3, value);
				if ((object)obj4 == null || obj4 == obj)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj5 == obj3;
					obj3 = obj5;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
	}

	private void Start()
	{
		//IL_06e4: Expected O, but got I
		//IL_06ed: Expected O, but got I4
		//IL_002e: Expected O, but got I
		//IL_0037: Expected O, but got I4
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_0095: Expected O, but got I
		//IL_00ce: Expected O, but got I
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected O, but got Unknown
		//IL_00ee: Expected O, but got I
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected O, but got Unknown
		//IL_015e: Expected O, but got I4
		//IL_0167: Expected O, but got I4
		//IL_0186: Expected O, but got I4
		//IL_01a1: Expected O, but got I4
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Expected O, but got Unknown
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Expected O, but got Unknown
		//IL_0667: Expected I, but got O
		//IL_02f3: Expected I, but got O
		//IL_02fb: Expected I, but got O
		//IL_030b: Expected O, but got I
		//IL_031b: Expected O, but got I
		//IL_037e: Expected O, but got I4
		//IL_038e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0393: Expected O, but got Unknown
		//IL_03c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c6: Expected O, but got Unknown
		//IL_0421: Expected I, but got O
		//IL_046e: Expected O, but got I
		//IL_048f: Expected O, but got I4
		//IL_049f: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a4: Expected O, but got Unknown
		//IL_04d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d7: Expected O, but got Unknown
		//IL_051e: Expected O, but got I
		//IL_0533: Expected O, but got I
		//IL_053c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0541: Expected O, but got Unknown
		//IL_0554: Unknown result type (might be due to invalid IL or missing references)
		//IL_0559: Expected O, but got Unknown
		//IL_0575: Expected O, but got I4
		//IL_058f: Expected I, but got O
		//IL_05f7: Expected O, but got I
		//IL_0607: Expected O, but got I
		UIPicker uIPicker = ampmPicker;
		bool flag = (object)ampmPicker == null;
		IntPtr intPtr = default(IntPtr);
		string text = (string)(nint)intPtr;
		UnityEvent unityEvent = (UnityEvent)152989696;
		if (!flag)
		{
			GameObject[] items = uIPicker.items;
			bool flag2 = uIPicker.items == null;
			text = (string)(nint)intPtr;
			unityEvent = (UnityEvent)152989696;
			if (!flag2)
			{
				object obj = typeof(SqlSingle[]) + 32;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
				unityEvent = (UnityEvent)(this + 80);
				string text2 = default(string);
				unityEvent = (UnityEvent)(object)text2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X20_v2 (UnityEngine.Events.UnityEvent)-18]");
				UIPicker uIPicker2 = (UIPicker)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X20_v2 (UnityEngine.Events.UnityEvent)-18]");
				bool flag3 = (nint)0 == 0;
				text = text2;
				if (!flag3)
				{
					object obj2 = (nint)0 + (nint)1472;
					object obj3 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
					object obj4 = (nint)0 + (nint)928;
					object methodName = "Network Authentication Required" + 2344;
					nint num2 = default(nint);
					nint num = num2;
					nint num4 = default(nint);
					nint num3 = num4;
					bool flag5 = default(bool);
					bool flag4 = flag5;
					bool flag7 = default(bool);
					bool flag6 = flag7;
					object obj6 = default(object);
					object obj5 = obj6;
					object obj8 = default(object);
					object obj7 = obj8;
					object obj10 = default(object);
					object obj9 = obj10;
					bool flag9 = default(bool);
					bool flag8 = flag9;
					bool flag11 = default(bool);
					bool flag10 = flag11;
					object obj12 = default(object);
					object obj11 = obj12;
					object obj14 = default(object);
					object obj13 = obj14;
					object obj15 = 32;
					object obj16 = 0;
					string text3 = text2;
					object obj17 = obj;
					TextMeshProUGUI textMeshProUGUI = default(TextMeshProUGUI);
					UnityAction unityAction = default(UnityAction);
					while (true)
					{
						GameObject[] items2 = uIPicker2.items;
						bool flag12 = uIPicker2.items == null;
						num2 = num;
						num4 = num3;
						flag5 = flag4;
						flag7 = flag6;
						obj6 = obj5;
						obj8 = obj7;
						obj10 = obj9;
						flag9 = flag8;
						flag11 = flag10;
						obj12 = obj11;
						obj14 = obj13;
						object obj18 = obj15;
						object obj19 = obj16;
						text = text3;
						obj = obj17;
						if (flag12)
						{
							break;
						}
						obj = items2.Length;
						bool flag13 = (nint)obj16 < items2.Length;
						obj14 = !flag13;
						obj12 = obj16 - items2.Length;
						flag11 = (nint)obj12 < 0;
						flag9 = obj12 == null;
						obj10 = obj16 ^ items2.Length;
						obj8 = obj16 ^ obj12;
						obj6 = obj10 & obj8;
						flag7 = (nint)obj6 < 0;
						flag5 = (nint)obj16 >= items2.Length;
						num2 = num;
						num4 = num3;
						obj18 = obj15;
						obj19 = obj16;
						text = text3;
						if (!flag5)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X8_v12 (UnityEngine.GameObject[])+v145 @ X27_v5]");
							bool flag14 = (nint)0 == 0;
							num2 = num;
							num4 = num3;
							obj18 = obj15;
							obj19 = obj16;
							text = text3;
							if (flag14)
							{
								break;
							}
							text = (string)obj2;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E32EDC");
							bool flag15 = (object)textMeshProUGUI == null;
							num2 = num;
							num4 = num3;
							obj18 = obj15;
							obj19 = obj16;
							if (flag15)
							{
								break;
							}
							num4 = (nint)unityEvent;
							nint num5 = (nint)textMeshProUGUI;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X8_v13 (Il2CppClass<TMPro.TextMeshProUGUI>)+548]");
							obj = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X8_v13 (Il2CppClass<TMPro.TextMeshProUGUI>)+550]");
							text = (string)0;
							string text4 = textMeshProUGUI.text;
							bool flag16 = unityEvent == null;
							num2 = num;
							obj18 = obj15;
							obj19 = obj16;
							if (flag16)
							{
								break;
							}
							object obj20 = obj16;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X28_v1 (Il2CppClass<UnityEngine.Events.UnityEvent>)+18]");
							bool flag17 = (nint)obj20 < 0;
							obj14 = !flag17;
							object obj21 = obj16;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X28_v1 (Il2CppClass<UnityEngine.Events.UnityEvent>)+18]");
							obj12 = obj21 - 0;
							flag11 = (nint)obj12 < 0;
							flag9 = obj12 == null;
							object obj22 = obj16;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X28_v1 (Il2CppClass<UnityEngine.Events.UnityEvent>)+18]");
							obj10 = obj22 ^ 0;
							obj8 = obj16 ^ obj12;
							obj6 = obj10 & obj8;
							flag7 = (nint)obj6 < 0;
							if (obj14 == null)
							{
								object obj23 = (object)unityEvent + obj15;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								nint num6 = (nint)unityEvent;
								bool flag18 = unityEvent == null;
								num2 = num;
								obj18 = obj15;
								obj19 = obj16;
								text = text4;
								if (flag18)
								{
									break;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X8_v16 (Il2CppClass<UnityEngine.Events.UnityEvent>)+18]");
								obj = 0;
								object obj24 = obj16;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X8_v16 (Il2CppClass<UnityEngine.Events.UnityEvent>)+18]");
								bool flag19 = (nint)obj24 < 0;
								obj14 = !flag19;
								object obj25 = obj16;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X8_v16 (Il2CppClass<UnityEngine.Events.UnityEvent>)+18]");
								obj12 = obj25 - 0;
								flag11 = (nint)obj12 < 0;
								flag9 = obj12 == null;
								object obj26 = obj16;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X8_v16 (Il2CppClass<UnityEngine.Events.UnityEvent>)+18]");
								obj10 = obj26 ^ 0;
								obj8 = obj16 ^ obj12;
								obj6 = obj10 & obj8;
								flag7 = (nint)obj6 < 0;
								if (obj14 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X8_v16 (Il2CppClass<UnityEngine.Events.UnityEvent>)+v145 @ X27_v5]");
									text = (string)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X8_v16 (Il2CppClass<UnityEngine.Events.UnityEvent>)+v145 @ X27_v5]");
									TextMeshProExtensions.Localize(textMeshProUGUI, (string)0);
									obj19 = obj16 + 1;
									uIPicker2 = ampmPicker;
									obj18 = obj15 + 8;
									bool flag20 = (object)ampmPicker == null;
									object obj27 = !flag20;
									num2 = 0;
									num = 0;
									num3 = (nint)unityEvent;
									flag4 = flag5;
									flag6 = flag7;
									obj5 = obj6;
									obj7 = obj8;
									obj9 = obj10;
									flag8 = flag9;
									flag10 = flag11;
									obj11 = obj12;
									obj13 = obj14;
									obj15 = obj18;
									obj16 = obj19;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X8_v16 (Il2CppClass<UnityEngine.Events.UnityEvent>)+v146 @ X27_v1]");
									text3 = (string)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X8_v16 (Il2CppClass<UnityEngine.Events.UnityEvent>)+18]");
									obj17 = 0;
									if (obj27 == null)
									{
										break;
									}
									continue;
								}
							}
							throw new IndexOutOfRangeException();
						}
						SetDate();
						Button closeButton = CloseButton;
						if ((object)CloseButton == null)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						unityAction..ctor(this, (IntPtr)obj4);
						bool flag21 = closeButton.m_OnClick == null;
						text = (string)(object)this;
						if (flag21)
						{
							break;
						}
						closeButton.m_OnClick.AddListener(unityAction);
						Invoke((string)methodName, 0.1f);
						return;
					}
				}
			}
		}
		throw new NullReferenceException();
	}

	private void SetDate()
	{
		//IL_004f: Expected O, but got I4
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected O, but got Unknown
		//IL_009d: Expected O, but got I4
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected O, but got Unknown
		//IL_0108: Expected O, but got I4
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected O, but got Unknown
		//IL_015e: Expected O, but got I4
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Expected O, but got Unknown
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected O, but got Unknown
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Expected O, but got Unknown
		//IL_01d9: Expected O, but got I4
		//IL_01ef: Expected O, but got I
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Expected O, but got Unknown
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Expected O, but got Unknown
		//IL_0253: Expected O, but got I
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Expected O, but got Unknown
		//IL_02e5: Expected O, but got I4
		//IL_030f: Expected O, but got I4
		//IL_031f: Expected O, but got I4
		//IL_033f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0344: Expected O, but got Unknown
		//IL_0361: Unknown result type (might be due to invalid IL or missing references)
		//IL_0366: Expected O, but got Unknown
		//IL_036f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0374: Expected O, but got Unknown
		//IL_0384: Expected O, but got I
		//IL_03a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ab: Expected O, but got Unknown
		//IL_03cd: Expected O, but got I
		if ((object)hoursPicker != null)
		{
			int num = default(int);
			string text = num.ToString();
			UIPicker uIPicker = hoursPicker;
			if ((object)hoursPicker != null)
			{
				object obj = uIPicker._currentSelectionIndex + 1;
				bool flag = (nint)obj > 9;
				string text2 = text;
				if (!flag)
				{
					object obj2 = ", stale={0}" + 3424;
					string text3 = (string)obj2 + text;
					object obj3 = 0;
					text2 = text3;
				}
				if ((object)minutesPicker != null)
				{
					string text4 = num.ToString();
					UIPicker uIPicker2 = minutesPicker;
					if ((object)minutesPicker != null)
					{
						object obj4 = typeof(SqlSingle[]) + 32;
						object obj5 = uIPicker2._currentSelectionIndex + 1;
						bool flag2 = (nint)obj5 > 9;
						string text5 = text4;
						if (!flag2)
						{
							object obj6 = ", stale={0}" + 3424;
							string text6 = (string)obj6 + text4;
							text5 = text6;
							object obj3 = 0;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
						string[] array = default(string[]);
						if (array != null)
						{
							object obj7 = array + 32;
							obj7 = text2;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							object obj8 = "1.2.840.113549.1.12.1.5" + 1488;
							object obj9 = array + 40;
							obj9 = obj8;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X21_v6-10]");
							bool flag3 = (nint)0 < (nint)2;
							object obj10 = !flag3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X21_v6-10]");
							object obj11 = -2;
							bool flag4 = obj11 == null;
							object obj12 = ~obj10;
							object obj13 = obj12 | flag4;
							if (obj13 != null)
							{
								goto IL_0413;
							}
							object obj14 = array + 48;
							obj14 = text5;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							object obj15 = (nint)0 + (nint)3072;
							object obj16 = array + 56;
							obj16 = obj15;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							UIPicker uIPicker3 = ampmPicker;
							if ((object)ampmPicker != null)
							{
								string[] array2 = ampm;
								if (ampm != null)
								{
									bool flag5 = uIPicker3._currentSelectionIndex < array2.Length;
									object obj17 = !flag5;
									if (obj17 == null)
									{
										bool flag6 = array.Length < 4;
										object obj18 = !flag6;
										object obj19 = array.Length - 4;
										bool flag7 = obj19 == null;
										object obj20 = ~obj18;
										object obj21 = obj20 | flag7;
										if (obj21 == null)
										{
											object obj22 = ampm + uIPicker3._currentSelectionIndex;
											object obj23 = array + 64;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X8_v27+20]");
											obj23 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
											string text7 = string.Concat(array);
											object obj24 = this + 72;
											obj24 = text7;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X19_v4-8]");
											object obj25 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X19_v4-8]");
											if ((nint)0 != 0)
											{
												object obj26 = obj25;
												Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v275 @ X8_v28+558] (should have been resolved before IL gen)");
												return;
											}
											goto IL_0405;
										}
									}
									goto IL_0413;
								}
							}
						}
					}
				}
			}
		}
		goto IL_0405;
		IL_0405:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0413;
		IL_0413:
		throw new IndexOutOfRangeException();
	}

	private void FillTime(string time)
	{
		//IL_0017: Expected I, but got O
		//IL_0027: Expected O, but got I
		//IL_0037: Expected O, but got I
		TextMeshProUGUI textMeshProUGUI = field;
		nint num = (nint)textMeshProUGUI;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ X8_v1 (Il2CppClass<TMPro.TextMeshProUGUI>)+558]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ X8_v1 (Il2CppClass<TMPro.TextMeshProUGUI>)+560]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v4 @ X3_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	public void Now()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0111: Expected O, but got I4
		//IL_00bf: Expected O, but got I4
		//IL_00e6: Expected O, but got I4
		//IL_00a6: Expected O, but got I4
		object obj = typeof(DataRelation) + 712;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DateTime now = DateTime.Now;
		DateTime dateTime = default(DateTime);
		int minute = dateTime.Minute;
		DateTime now2 = DateTime.Now;
		int hour = dateTime.Hour;
		bool flag2 = hour < 13;
		int num = hour;
		if (!flag2)
		{
			num = hour - 12;
			ampmPicker.LerpToItemWithIndex(1, (int?)(object)0);
		}
		minutesPicker.LerpToItemWithIndex(minute, (int?)(object)0);
		int index = num - 1;
		hoursPicker.LerpToItemWithIndex(index, (int?)(object)0);
	}

	public void Hide()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0031: Expected O, but got I4
		GameObject gameObject = base.gameObject;
		gameObject.SetActive(value: false);
		object obj = this + 88;
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	private void CallOnSelect()
	{
		OnSelectDelegate onSelect = this.OnSelect;
		if (this.OnSelect != null)
		{
			string text = time;
			IntPtr invoke_impl = ((Delegate)onSelect).invoke_impl;
			IntPtr method_code = ((Delegate)onSelect).method_code;
			IntPtr method = ((Delegate)onSelect).method;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v4 @ X3_v1 (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	private void OnClose()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_0037: Expected O, but got I4
		SetDate();
		GameObject gameObject = base.gameObject;
		gameObject.SetActive(value: false);
		object obj = this + 88;
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
