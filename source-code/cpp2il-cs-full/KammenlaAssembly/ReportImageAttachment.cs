using System;
using System.Buffers.Text;
using System.Diagnostics;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json.Linq.JsonPath;
using ReportEnums;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class ReportImageAttachment : MonoBehaviour, IReportElement<byte[]>, IDummyReportElement, IReportElement<object>
{
	private ReportElementType type;

	private bool isRequired;

	private Button attach;

	private Button remove;

	private RawImage preview;

	private GameObject emphasise;

	private Texture2D defaultPreview;

	public ReportElementType Type => type;

	public bool IsReportElementActive
	{
		get
		{
			//IL_009d: Expected I4, but got O
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			RawImage rawImage = preview;
			if ((object)preview != null)
			{
				object obj = typeof(MemberAchievementClanFeedData) + 2976;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v3+E4]");
				if ((nint)0 != 0)
				{
					return rawImage.m_Texture != defaultPreview;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				return rawImage.m_Texture != defaultPreview;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	public bool IsRequired => isRequired;

	object IReportElement<object>.Value
	{
		get
		{
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			//IL_0048: Expected O, but got Unknown
			RawImage rawImage = preview;
			if ((object)preview != null)
			{
				Texture2D texture = (Texture2D)rawImage.m_Texture;
				if ((object)rawImage.m_Texture != null)
				{
					object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 656;
					if (texture != obj)
					{
						goto IL_008c;
					}
				}
				return ImageConversion.EncodeToJPG((Texture2D)rawImage.m_Texture);
			}
			NullReferenceException ex = new NullReferenceException();
			goto IL_008c;
			IL_008c:
			return new InvalidCastException();
		}
	}

	public byte[] Value
	{
		get
		{
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			//IL_0048: Expected O, but got Unknown
			RawImage rawImage = preview;
			if ((object)preview != null)
			{
				Texture2D texture = (Texture2D)rawImage.m_Texture;
				if ((object)rawImage.m_Texture != null)
				{
					object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 656;
					if (texture != obj)
					{
						goto IL_008c;
					}
				}
				return ImageConversion.EncodeToJPG((Texture2D)rawImage.m_Texture);
			}
			NullReferenceException ex = new NullReferenceException();
			goto IL_008c;
			IL_008c:
			return (byte[])(object)new InvalidCastException();
		}
	}

	public bool isImageAttached
	{
		get
		{
			//IL_009d: Expected I4, but got O
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			RawImage rawImage = preview;
			if ((object)preview != null)
			{
				object obj = typeof(MemberAchievementClanFeedData) + 2976;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v3+E4]");
				if ((nint)0 != 0)
				{
					return rawImage.m_Texture != defaultPreview;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				return rawImage.m_Texture != defaultPreview;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	public void HighlightRequired()
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_0065: Expected O, but got I4
		if (isRequired)
		{
			RawImage rawImage = preview;
			object obj = typeof(MemberAchievementClanFeedData) + 2976;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X0_v4+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag2 = rawImage.m_Texture != defaultPreview;
			bool active = (byte)((flag2 ? 1u : 0u) ^ 1u) != 0;
			emphasise.SetActive(active);
		}
	}

	private void Start()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_003d: Expected I, but got O
		//IL_006f: Expected O, but got I
		//IL_0087: Expected I, but got O
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected O, but got Unknown
		//IL_0165: Expected O, but got I4
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected O, but got Unknown
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Expected O, but got Unknown
		Button button = attach;
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj2 = (nint)0 + (nint)696;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj2);
		button.m_OnClick.AddListener(unityAction);
		Button button2 = remove;
		object obj3 = (nint)0 + (nint)704;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction2 = default(UnityAction);
		unityAction2..ctor(this, (IntPtr)obj3);
		button2.m_OnClick.AddListener(unityAction2);
		RawImage rawImage = preview;
		Texture texture = rawImage.m_Texture;
		if ((object)rawImage.m_Texture != null)
		{
			object obj4 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 656;
			if (texture == obj4)
			{
				object obj5 = this + 72;
				obj5 = rawImage.m_Texture;
				if (texture == obj4)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					return;
				}
			}
			throw new InvalidCastException();
		}
		object obj6 = this + 72;
		obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	private void OnAttachClick()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected O, but got Unknown
		//IL_00ec: Expected I, but got O
		//IL_0116: Expected O, but got I4
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		//IL_0094: Expected O, but got I4
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3688;
		object obj2 = (nint)0 + (nint)688;
		object obj3 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1152;
		object obj4 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object msgBody = "LAK" + 2136;
		KMediaPicker.OnSelectFromNativeGallery += action;
		KMediaPicker.PickFromGallery();
		object obj7 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v8+E4]");
		bool flag2 = (nint)0 == 0;
		object obj8 = !flag2;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PopupWindow.ShowLoading((string)msgBody);
	}

	private void OnRemoveClick()
	{
		ChangeVisibleButton(showAttachButton: true);
		preview.texture = defaultPreview;
	}

	private void AttachImage(Texture2D texture2D)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0282: Expected I, but got O
		//IL_02ac: Expected O, but got I4
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_01c7: Expected O, but got I4
		//IL_01d5: Expected O, but got I4
		//IL_00ee: Expected O, but got I4
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Expected O, but got Unknown
		//IL_013b: Expected O, but got I4
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Expected O, but got Unknown
		//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c9: Expected O, but got Unknown
		//IL_02d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d8: Expected O, but got Unknown
		//IL_0302: Expected O, but got I4
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Expected O, but got Unknown
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3688;
		object obj2 = (nint)0 + (nint)688;
		object obj3 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1152;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		KMediaPicker.OnSelectFromNativeGallery -= action;
		GameObject gameObject = base.gameObject;
		if (!gameObject.activeInHierarchy)
		{
			return;
		}
		object obj6 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X0_v12+E4]");
		if ((nint)0 != 0)
		{
			bool flag2 = texture2D == null;
			bool flag3 = !flag2;
			UnityEngine.Object obj8 = null;
			object obj9 = 0;
			if (!flag3)
			{
				goto IL_00fd;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag4 = texture2D == null;
			bool flag5 = !flag4;
			object obj10 = !flag5;
			UnityEngine.Object obj8 = null;
			object obj9 = 0;
			if (obj10 != null)
			{
				goto IL_00fd;
			}
		}
		HighlightRequired();
		preview.texture = texture2D;
		ChangeVisibleButton(showAttachButton: false);
		object obj11 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		object obj12 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X0_v17+E4]");
		if ((nint)0 != 0)
		{
			PopupWindow.DismissMessage();
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		PopupWindow.DismissMessage();
		return;
		IL_00fd:
		object obj13 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		object obj14 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X0_v24+E4]");
		bool flag6 = (nint)0 == 0;
		object obj15 = !flag6;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PopupWindow.DismissMessage();
		object message = "Index = {0} position = {1}" + 1736;
		object title = "Drop Menu Toggle" + 3600;
		object buttonText = "Network Authentication Required" + 3128;
		object obj16 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X0_v26+E4]");
		bool flag7 = (nint)0 == 0;
		object obj17 = !flag7;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PopupWindow.ShowError((string)title, (string)message, (string)buttonText);
	}

	private void ChangeVisibleButton(bool showAttachButton)
	{
		GameObject gameObject = attach.gameObject;
		gameObject.SetActive(showAttachButton);
		GameObject gameObject2 = remove.gameObject;
		bool active = (byte)((showAttachButton ? 1u : 0u) ^ 1u) != 0;
		gameObject2.SetActive(active);
	}
}
