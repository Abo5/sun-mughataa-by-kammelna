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

public class UIDatePickerUGUI : MonoBehaviour
{
	public delegate void OnSelectDelegate(string date);

	public Button CloseButton;

	public UIPicker dayPicker;

	public UIPicker monthPicker;

	public UIPicker yearPicker;

	public TextMeshProUGUI field;

	public string date;

	private int year;

	private OnSelectDelegate m_OnSelect;

	public event OnSelectDelegate OnSelect
	{
		add
		{
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			object obj = typeof(TrackedDeviceRaycaster.<>c) + 672;
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
			object obj = typeof(TrackedDeviceRaycaster.<>c) + 672;
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

	private unsafe void Start()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0347: Expected O, but got I4
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected I4, but got Unknown
		//IL_006b: Expected O, but got I
		//IL_00a0: Expected O, but got I
		//IL_00f6: Expected O, but got I
		//IL_0147: Expected O, but got I
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Expected O, but got Unknown
		//IL_01ec: Expected O, but got I4
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Expected O, but got Unknown
		//IL_0293: Expected O, but got I
		//IL_02ab: Expected I, but got O
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Expected O, but got Unknown
		//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e1: Expected O, but got Unknown
		//IL_0231: Expected O, but got I4
		object obj = typeof(DataRelation) + 712;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DateTime now = DateTime.Now;
		DateTime dateTime = default(DateTime);
		int value = dateTime.Year;
		int num = this + 80;
		((int*)num)->m_value = value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X20_v3 (System.Int32)-18]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X20_v3 (System.Int32)-18]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v4+28]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v4+28]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v7+20]");
				if ((nint)0 != 0)
				{
					object obj6 = (nint)0 + (nint)1472;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E32EDC");
					string text = ((int*)num)->ToString();
					object obj7 = default(object);
					if (obj7 != null)
					{
						object obj8 = obj7;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v8+560]");
						object obj9 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v230 @ X8_v8+558] (should have been resolved before IL gen)");
						UIPicker uIPicker = monthPicker;
						if ((object)monthPicker != null)
						{
							GameObject[] items = uIPicker.items;
							if (uIPicker.items != null)
							{
								bool flag2 = items.Length < 1;
								string text2 = text;
								if (flag2)
								{
									goto IL_0244;
								}
								object obj10 = uIPicker.items + 32;
								object obj11 = 0;
								TextMeshProUGUI textMesh = default(TextMeshProUGUI);
								while (true)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X23_v5+v155 @ X21_v10*8]");
									if ((nint)0 == 0)
									{
										break;
									}
									obj11++;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E32EDC");
									TextMeshProExtensions.Localize(textMesh);
									bool flag3 = (nint)obj11 < items.Length;
									obj9 = 0;
									text2 = null;
									if (flag3)
									{
										continue;
									}
									goto IL_0244;
								}
							}
						}
					}
				}
			}
		}
		goto IL_0308;
		IL_0244:
		SetDate();
		Button closeButton = CloseButton;
		if ((object)CloseButton != null)
		{
			object obj12 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
			object obj13 = (nint)0 + (nint)520;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			UnityAction unityAction = default(UnityAction);
			unityAction..ctor(this, (IntPtr)obj13);
			if (closeButton.m_OnClick != null)
			{
				object methodName = "Network Authentication Required" + 2344;
				closeButton.m_OnClick.AddListener(unityAction);
				Invoke((string)methodName, 0.1f);
				return;
			}
		}
		goto IL_0308;
		IL_0308:
		NullReferenceException ex = new NullReferenceException();
		throw new IndexOutOfRangeException();
	}

	private unsafe void SetDate()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_0085: Expected O, but got I8
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected O, but got Unknown
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected O, but got Unknown
		//IL_0101: Expected O, but got I4
		//IL_0111: Expected O, but got I4
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Expected O, but got Unknown
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Expected O, but got Unknown
		//IL_017e: Expected O, but got I8
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Expected O, but got Unknown
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Expected I4, but got Unknown
		//IL_01fa: Expected O, but got I4
		//IL_0210: Expected O, but got I
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Expected O, but got Unknown
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Expected O, but got Unknown
		//IL_027b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Expected O, but got Unknown
		//IL_02a2: Expected O, but got I
		object obj = typeof(SqlSingle[]) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		int num = default(int);
		string text = num.ToString();
		string[] array = default(string[]);
		if (array.Length != 0)
		{
			object obj2 = array + 32;
			obj2 = text;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X21_v6-8]");
			object obj3 = 0 & 0xFFFFFFFEL;
			if (obj3 != null)
			{
				object obj4 = ", stale={0}" + 2920;
				object obj5 = array + 40;
				obj5 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				string text2 = num.ToString();
				bool flag = array.Length < 2;
				object obj6 = !flag;
				object obj7 = array.Length - 2;
				bool flag2 = obj7 == null;
				object obj8 = ~obj6;
				object obj9 = obj8 | flag2;
				if (obj9 == null)
				{
					object obj10 = array + 48;
					obj10 = text2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X21_v8-18]");
					object obj11 = 0 & 0xFFFFFFFCL;
					if (obj11 != null)
					{
						object obj12 = array + 56;
						obj12 = obj4;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						int num2 = this + 80;
						string text3 = ((int*)num2)->ToString();
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X21_v10-20]");
						bool flag3 = (nint)0 < (nint)4;
						object obj13 = !flag3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X21_v10-20]");
						object obj14 = -4;
						bool flag4 = obj14 == null;
						object obj15 = ~obj13;
						object obj16 = obj15 | flag4;
						if (obj16 == null)
						{
							object obj17 = array + 64;
							obj17 = text3;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							string text4 = string.Concat(array);
							object obj18 = this + 72;
							obj18 = text4;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X19_v3-8]");
							object obj19 = 0;
							object obj20 = obj19;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v160 @ X8_v16+558] (should have been resolved before IL gen)");
							return;
						}
					}
				}
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	private void Now()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00ec: Expected O, but got I4
		//IL_0080: Expected O, but got I4
		//IL_00a7: Expected O, but got I4
		//IL_00c1: Expected O, but got I4
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
		int month = dateTime.Month;
		DateTime now2 = DateTime.Now;
		int day = dateTime.Day;
		int index = month - 1;
		monthPicker.LerpToItemWithIndex(index, (int?)(object)0);
		int index2 = day - 1;
		dayPicker.LerpToItemWithIndex(index2, (int?)(object)0);
		yearPicker.LerpToItemWithIndex(0, (int?)(object)0);
	}

	private void FillDate(string time)
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

	public void Show()
	{
		GameObject gameObject = base.gameObject;
		gameObject.SetActive(value: true);
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
			string text = date;
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
