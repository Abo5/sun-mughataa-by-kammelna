using System;
using System.Collections;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using Cpp2ILInjected;
using DG.Tweening;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server.Models.Clans;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.UI;

public class DateTimeText : MonoBehaviour
{
	private sealed class <RefreshDateCoroutine>d__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state;

		private object <>2__current;

		public DateTimeText <>4__this;

		object IEnumerator<object>.Current => <>2__current;

		object IEnumerator.Current => <>2__current;

		public <RefreshDateCoroutine>d__15(int <>1__state)
		{
			this.<>1__state = <>1__state;
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_00a0: Expected I4, but got I8
			//IL_013d: Expected I4, but got O
			//IL_0045: Expected O, but got I4
			//IL_0062: Expected I4, but got I8
			//IL_007e: Expected O, but got I4
			//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0101: Expected O, but got Unknown
			DateTimeText dateTimeText = <>4__this;
			if (<>1__state != 1)
			{
				bool flag = <>1__state == 0;
				object obj = !flag;
				if (obj != null)
				{
					goto IL_0129;
				}
				<>1__state = -1;
				bool flag2 = (object)<>4__this == null;
				object obj2 = !flag2;
				if (obj2 != null)
				{
					goto IL_00eb;
				}
			}
			else
			{
				<>1__state = -1;
				if ((object)<>4__this != null)
				{
					if (<>4__this.enabled)
					{
						goto IL_00eb;
					}
					goto IL_0129;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_00eb:
			<>4__this.RefreshDate();
			object obj3 = this + 24;
			obj3 = dateTimeText._waitFor1Second;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			_ = 1;
			return true;
			IL_0129:
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0042: Expected O, but got I
			object obj = typeof(MemberAchievementClanFeedData) + 2648;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			NotSupportedException ex = default(NotSupportedException);
			ex..ctor();
			object obj2 = (nint)0 + (nint)1320;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			throw new OutOfMemoryException();
		}
	}

	private TextMeshProUGUI text;

	private string fallbackText;

	private Graphic[] flashingObjects;

	private DateTimeFormat[] formatters;

	private bool _flashingActive;

	private DateTime <Date>k__BackingField;

	private readonly WaitForSeconds _waitFor1Second;

	public DateTime Date
	{
		get
		{
			return <Date>k__BackingField;
		}
		private set
		{
			<Date>k__BackingField = value;
		}
	}

	private void Awake()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0045: Expected O, but got I4
		//IL_005b: Expected O, but got I
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected O, but got Unknown
		Graphic[] array = flashingObjects;
		if (array.Length >= 1)
		{
			object obj = array + 32;
			object obj2 = 0;
			do
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X22_v4+v42 @ X21_v5*8]");
				GameObject gameObject = ((Component)0).gameObject;
				obj2++;
				gameObject.SetActive(_flashingActive);
			}
			while ((nint)obj2 < array.Length);
		}
	}

	private void OnEnable()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		object obj = typeof(CardUtils.<>c) + 3800;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		_ = 0;
		object obj3 = obj2 + 32;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Coroutine coroutine = StartCoroutine((IEnumerator)obj2);
	}

	public void SetDate(DateTime date)
	{
		<Date>k__BackingField = date;
		RefreshDate();
	}

	public void SetFallbackText(string fallbackText)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		object obj = this + 40;
		obj = fallbackText;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		RefreshDate();
	}

	private void RefreshDate()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002c: Expected O, but got I
		//IL_01f9: Expected I, but got O
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected O, but got Unknown
		//IL_01b9: Expected O, but got I4
		//IL_007d: Expected I, but got O
		//IL_013a: Expected O, but got I
		//IL_014a: Expected I, but got O
		//IL_015a: Expected O, but got I
		//IL_016a: Expected O, but got I
		object obj = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 920;
		object obj2 = (nint)0 + (nint)224;
		object obj3 = (nint)0 + (nint)744;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<object, bool> func = default(Func<object, bool>);
		func..ctor((object)this, (IntPtr)obj2);
		object obj4 = Enumerable.FirstOrDefault(formatters, func);
		if (obj4 != null)
		{
			string formattedText = ((DateTimeFormat)obj4).GetFormattedText(<Date>k__BackingField);
			TextMeshProExtensions.FixArabic(text, formattedText);
			nint num = (nint)obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v90 @ X8_v13 (Il2CppClass<System.Object>)+178] (should have been resolved before IL gen)");
			object obj5 = default(object);
			if (obj5 != null)
			{
				BeginFlashing();
				return;
			}
			goto IL_0174;
		}
		StopFlashing();
		object obj6 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
		object obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X0_v7+E4]");
		TextMeshProUGUI textMeshProUGUI;
		TextMeshProUGUI textMesh;
		if ((nint)0 != 0)
		{
			bool flag = StringsExtensions.IsNullOrEmpty(fallbackText);
			textMeshProUGUI = text;
			bool flag2 = !flag;
			textMesh = text;
			if (!flag2)
			{
				goto IL_012e;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = StringsExtensions.IsNullOrEmpty(fallbackText);
			textMeshProUGUI = text;
			bool flag4 = !flag3;
			object obj8 = !flag4;
			textMesh = text;
			if (obj8 != null)
			{
				goto IL_012e;
			}
		}
		TextMeshProExtensions.Localize(textMesh, fallbackText);
		return;
		IL_0174:
		StopFlashing();
		return;
		IL_012e:
		object obj9 = (nint)0 + (nint)2000;
		object obj10 = obj9;
		nint num2 = (nint)textMeshProUGUI;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X8_v11 (Il2CppClass<TMPro.TextMeshProUGUI>)+558]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X8_v11 (Il2CppClass<TMPro.TextMeshProUGUI>)+560]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v154 @ X3_v2 (should have been resolved before IL gen)");
		goto IL_0174;
	}

	private IEnumerator RefreshDateCoroutine()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		object obj = typeof(CardUtils.<>c) + 3800;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		_ = 0;
		object obj3 = obj2 + 32;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return (IEnumerator)obj2;
	}

	private void Reset()
	{
		//IL_000c: Expected O, but got I
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		object obj = (nint)0 + (nint)1184;
		object obj2 = this + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D321D8");
	}

	private void BeginFlashing()
	{
		//IL_001c: Expected O, but got I4
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected O, but got Unknown
		//IL_007a: Expected O, but got I4
		//IL_0090: Expected O, but got I
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected O, but got Unknown
		//IL_00cb: Expected O, but got I
		//IL_00ee: Expected O, but got I
		//IL_0117: Expected O, but got I
		bool flag = !_flashingActive;
		object obj = !flag;
		if (obj != null)
		{
			return;
		}
		_flashingActive = true;
		Graphic[] array = flashingObjects;
		if (array.Length >= 1)
		{
			object obj2 = array + 32;
			object obj3 = 0;
			do
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X22_v4+v112 @ X21_v5*8]");
				GameObject gameObject = ((Component)0).gameObject;
				obj3++;
				gameObject.SetActive(value: true);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X22_v4+v112 @ X21_v5*8]");
				int num = ShortcutExtensions.DOKill((Component)0, complete: true);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X22_v4+v112 @ X21_v5*8]");
				UIExtensions.SetAlpha((Graphic)0, 1f);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X22_v4+v112 @ X21_v5*8]");
				TransitionExtension.FadeFlash((Graphic)0, 1f, 0f, repeat: true, Ease.Linear);
			}
			while ((nint)obj3 < array.Length);
		}
	}

	private void StopFlashing()
	{
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_0072: Expected O, but got I4
		//IL_0088: Expected O, but got I
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_00c3: Expected O, but got I
		//IL_00e6: Expected O, but got I
		if (!_flashingActive)
		{
			return;
		}
		_flashingActive = false;
		Graphic[] array = flashingObjects;
		if (array.Length >= 1)
		{
			object obj = array + 32;
			object obj2 = 0;
			do
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X22_v4+v100 @ X21_v5*8]");
				GameObject gameObject = ((Component)0).gameObject;
				obj2++;
				gameObject.SetActive(value: false);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X22_v4+v100 @ X21_v5*8]");
				int num = ShortcutExtensions.DOKill((Component)0, complete: true);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X22_v4+v100 @ X21_v5*8]");
				UIExtensions.SetAlpha((Graphic)0, 1f);
			}
			while ((nint)obj2 < array.Length);
		}
	}

	public DateTimeText()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		object obj = typeof(UsageHint) + 1640;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		WaitForSeconds waitForSeconds = default(WaitForSeconds);
		waitForSeconds..ctor(1f);
		object obj2 = this + 80;
		obj2 = waitForSeconds;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
	}

	private bool <RefreshDate>b__13_0(DateTimeFormat f)
	{
		//IL_006a: Expected I4, but got O
		if (f != null && f.condition != null)
		{
			return f.condition.IsSatisfied(<Date>k__BackingField);
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}
}
