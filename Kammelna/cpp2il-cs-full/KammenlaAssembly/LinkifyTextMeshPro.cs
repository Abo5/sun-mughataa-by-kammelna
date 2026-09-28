using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json.Linq.JsonPath;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class LinkifyTextMeshPro : MonoBehaviour
{
	private Color highlightColor;

	private bool underline;

	private string[] allowedDomains;

	private string link;

	private TextMeshProUGUI textMesh;

	private Button button;

	private void Awake()
	{
		//IL_000c: Expected O, but got I
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_001d: Expected O, but got I
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		object obj = (nint)0 + (nint)152;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		object obj2 = this + 72;
		object obj3 = default(object);
		obj2 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		GameObject gameObject = base.gameObject;
		object obj4 = (nint)0 + (nint)592;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E32E24");
		object obj5 = this + 80;
		object obj6 = default(object);
		obj5 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Setup();
		SetText();
	}

	private unsafe void Setup()
	{
		//IL_0008: Expected O, but got Ref
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		//IL_0041: Expected O, but got I
		//IL_0049: Expected I, but got O
		//IL_0081: Expected O, but got I4
		//IL_021d: Expected O, but got I
		//IL_0235: Expected I, but got O
		//IL_00bc: Expected O, but got I
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected O, but got Unknown
		//IL_018d: Expected O, but got I
		//IL_019f: Expected O, but got Ref
		//IL_0163: Expected O, but got I
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Expected O, but got Unknown
		//IL_01ce: Expected O, but got I
		//IL_01e6: Expected I, but got O
		object obj2 = default(object);
		object obj = (object)(&obj2);
		TextMeshProUGUI textMeshProUGUI = textMesh;
		object obj3 = typeof(System.Formats.Asn1.SetOfValueComparer) + 3616;
		object obj4 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2856;
		object obj5 = (nint)0 + (nint)1240;
		nint num = (nint)textMeshProUGUI;
		textMeshProUGUI.raycastTarget = true;
		object obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X0_v7+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj6 = obj3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X0_v7+B8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj5);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X8_v6+58]");
		((FastAction<object>)0).Add(action);
		this.button.interactable = false;
		Selectable selectable = this.button;
		object obj9 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1832;
		_ = selectable.m_Colors;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v13 (UnityEngine.UI.Selectable)+64]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v13 (UnityEngine.UI.Selectable)+74]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v13 (UnityEngine.UI.Selectable)+84]");
		_ = 0;
		object obj10 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X8_v11+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v13 (UnityEngine.UI.Selectable)+84]");
			object obj11 = 0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			selectable = this.button;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X29_v1-40]");
			object obj11 = 0;
		}
		ColorBlock colorBlock = default(ColorBlock);
		selectable.colors = (ColorBlock)(&colorBlock);
		Button button = this.button;
		object obj12 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj13 = (nint)0 + (nint)1248;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj13);
		button.m_OnClick.AddListener(unityAction);
	}

	private void SetText()
	{
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Expected O, but got Unknown
		//IL_0212: Expected O, but got I4
		//IL_022c: Expected O, but got I
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0051: Expected O, but got I
		//IL_0249: Expected I, but got O
		//IL_0273: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_00e8: Expected O, but got I4
		//IL_0289: Expected I, but got O
		//IL_02c0: Expected O, but got I4
		//IL_0186: Expected O, but got I4
		object obj = this + 64;
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X20_v3+8]");
		object obj2 = 0;
		object obj3 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3640;
		object obj4 = (nint)0 + (nint)1232;
		object obj5 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
		object obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v4+550]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v66 @ X8_v4+548] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v4+F0]");
		bool flag = (nint)0 != 1;
		string text2 = default(string);
		string text = text2;
		if (!flag)
		{
			object obj8 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X0_v30+E4]");
			bool flag2 = (nint)0 == 0;
			object obj9 = !flag2;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string text3 = StringsExtensions.Reverse(text2);
			obj7 = 0;
			text = text3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<object, object> func = default(Func<object, object>);
		func..ctor((object)this, (IntPtr)obj4);
		object obj10 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X0_v11+E4]");
		bool flag3 = (nint)0 == 0;
		object obj11 = !flag3;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string text4 = StringsExtensions.ReplaceUrls(text, 1, allowedDomains, (Func<string, string>)func);
		TextMeshProUGUI textMeshProUGUI = textMesh;
		bool flag4 = !((TMP_Text)textMeshProUGUI).m_isRightToLeft;
		string text5 = text4;
		if (!flag4)
		{
			object obj12 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X0_v24+E4]");
			bool flag5 = (nint)0 == 0;
			object obj13 = !flag5;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string text6 = StringsExtensions.Reverse(text4);
			text5 = text6;
		}
		nint num = (nint)textMeshProUGUI;
		textMeshProUGUI.text = text5;
		object obj14 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X0_v18+E4]");
		bool flag6 = (nint)0 == 0;
		object obj15 = !flag6;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag7 = StringsExtensions.IsNullOrEmpty(link);
		bool interactable = (byte)((flag7 ? 1u : 0u) ^ 1u) != 0;
		button.interactable = interactable;
	}

	private string LinkifyUrl(string url)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0218: Expected O, but got I4
		//IL_0071: Expected O, but got I
		//IL_0086: Expected O, but got I
		//IL_0098: Expected I4, but got I8
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected O, but got Unknown
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected O, but got Unknown
		//IL_014b: Expected O, but got I4
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Expected O, but got Unknown
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Expected O, but got Unknown
		//IL_0252: Expected O, but got I4
		//IL_0192: Expected O, but got I4
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 4032;
		object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 4024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UriBuilder uriBuilder = default(UriBuilder);
		uriBuilder..ctor(url);
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (uriBuilder != null)
		{
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v5+B8]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v6+20]");
			uriBuilder.Scheme = (string)0;
			uriBuilder.Port = -1;
			Uri uri = uriBuilder.Uri;
			if ((object)uri != null)
			{
				object obj7 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2504;
				string absoluteUri = uri.AbsoluteUri;
				object obj8 = this + 64;
				obj8 = absoluteUri;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				string components = uri.GetComponents((UriComponents)126, UriFormat.Unescaped);
				object obj9 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X8_v7+E4]");
				bool flag2 = (nint)0 == 0;
				object obj10 = !flag2;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj11 = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 560;
				object obj12 = "1.2.840.113549.1.12.1.5" + 2456;
				string text = StringUtil.Color(components, (Color)0);
				bool flag3 = !underline;
				string text2 = text;
				if (!flag3)
				{
					object obj13 = obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X0_v22+E4]");
					bool flag4 = (nint)0 == 0;
					object obj14 = !flag4;
					if (obj14 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					string text3 = StringUtil.Underline(text);
					text2 = text3;
				}
				return (string)obj11 + text2 + (string)obj12;
			}
		}
		return (string)(object)new NullReferenceException();
	}

	private void OnTextChanged(UnityEngine.Object o)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00fe: Expected O, but got I4
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Expected O, but got Unknown
		//IL_0150: Expected O, but got I4
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Expected O, but got Unknown
		//IL_01da: Expected O, but got I
		//IL_01e8: Expected I, but got O
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Expected O, but got Unknown
		object obj = 152989696;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E73DF]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v14+E4]");
			bool flag = (nint)0 == 0;
			obj5 = textMesh;
			obj6 = textMesh;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj5 = textMesh;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v14+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = textMesh;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = o != obj6;
		bool flag4 = !flag3;
		object obj8 = !flag4;
		if (obj8 == null)
		{
			goto IL_015e;
		}
		return;
		IL_015e:
		string text = textMesh.text;
		object value = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 560;
		if (!text.Contains((string)value))
		{
			object obj9 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj10 = (nint)0 + (nint)1256;
			Action action = default(Action);
			action..ctor(this, (IntPtr)obj10);
			object obj11 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
			object obj12 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X0_v10+E4]");
			if ((nint)0 != 0)
			{
				CoroutineDummy.WaitForEndOfFrame(action);
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			CoroutineDummy.WaitForEndOfFrame(action);
		}
		return;
		IL_0091:
		if (o != obj5)
		{
			return;
		}
		goto IL_015e;
	}

	private void OpenLink()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00ff: Expected O, but got I4
		//IL_00b6: Expected O, but got I4
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Expected O, but got Unknown
		//IL_014d: Expected O, but got I4
		//IL_0156: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E73E0]");
		object obj3 = (nint)0 & (nint)1;
		string value;
		string value2;
		if (obj3 != null)
		{
			value = link;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v6+E4]");
			bool flag = (nint)0 == 0;
			value2 = link;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			value = link;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v6+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			value2 = link;
			if (obj5 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = StringsExtensions.IsNullOrEmpty(value2);
		bool flag4 = !flag3;
		object obj6 = !flag4;
		object obj7 = 0;
		if (obj6 != null)
		{
			return;
		}
		goto IL_0164;
		IL_0164:
		object obj8 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
		object obj9 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v2+E4]");
		if ((nint)0 != 0)
		{
			KUtil.OpenURL(link);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		KUtil.OpenURL(link);
		return;
		IL_0091:
		bool flag5 = StringsExtensions.IsNullOrEmpty(value);
		bool flag6 = !flag5;
		obj7 = 0;
		if (!flag6)
		{
			return;
		}
		goto IL_0164;
	}
}
