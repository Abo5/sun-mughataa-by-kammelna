using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class ClanLogoImageSelectorItem : MonoBehaviour, ISelectable
{
	private sealed class <>c__DisplayClass10_0
	{
		public ClanLogoImageSelector manager;

		public ClanLogoImageSelectorItem <>4__this;

		internal void <InitAsEmpty>b__0()
		{
			manager.PickItem(<>4__this);
		}
	}

	private sealed class <>c__DisplayClass9_0
	{
		public ClanLogoImageSelector manager;

		public ClanLogoImageSelectorItem <>4__this;

		public TaskCompletionSource<bool> tcs;

		internal void <Init>b__0()
		{
			manager.PickItem(<>4__this);
		}

		internal void <Init>b__1(bool success)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_006f: Expected O, but got I4
			ClanLogoImageSelectorItem clanLogoImageSelectorItem = <>4__this;
			object obj = typeof(MemberAchievementClanFeedData) + 2976;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v4+E4]");
			if ((nint)0 != 0)
			{
				bool flag = clanLogoImageSelectorItem.loadingIndicator != null;
				bool flag2 = !flag;
				object obj3 = !flag2;
				if (obj3 != null)
				{
					goto IL_00bd;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				if (clanLogoImageSelectorItem.loadingIndicator != null)
				{
					goto IL_00bd;
				}
			}
			goto IL_00e4;
			IL_00e4:
			ClanLogoImageSelectorItem clanLogoImageSelectorItem2 = <>4__this;
			GameObject gameObject = clanLogoImageSelectorItem2.image.gameObject;
			gameObject.SetActive(success);
			GameObject gameObject2 = <>4__this.gameObject;
			gameObject2.SetActive(success);
			bool flag3 = tcs.TrySetResult(success);
			return;
			IL_00bd:
			ClanLogoImageSelectorItem clanLogoImageSelectorItem3 = <>4__this;
			clanLogoImageSelectorItem3.loadingIndicator.SetActive(value: false);
			goto IL_00e4;
		}
	}

	private Image image;

	private Button button;

	private Image emptyImage;

	private Image selectedIndicator;

	private GameObject loadingIndicator;

	private int <Id>k__BackingField;

	public int Id
	{
		get
		{
			return <Id>k__BackingField;
		}
		private set
		{
			<Id>k__BackingField = value;
		}
	}

	public Task<bool> Init(ClanLogoElementViewModel model, int tier, ClanLogoImageSelector manager)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected O, but got Unknown
		//IL_00ee: Expected O, but got I4
		//IL_0292: Expected O, but got I4
		//IL_0243: Expected O, but got I4
		//IL_025a: Expected O, but got I4
		//IL_02d8: Expected O, but got I4
		//IL_036e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0373: Expected O, but got Unknown
		//IL_037f: Expected O, but got I
		//IL_039a: Expected I, but got O
		//IL_03d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d5: Expected O, but got Unknown
		//IL_03e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ea: Expected O, but got Unknown
		//IL_03f6: Expected O, but got I
		//IL_0429: Unknown result type (might be due to invalid IL or missing references)
		//IL_042e: Expected O, but got Unknown
		//IL_0460: Expected I, but got O
		//IL_04b0: Expected O, but got I
		object obj = typeof(CardUtils.<>c) + 1152;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj5;
		if (obj2 != null)
		{
			object obj3 = obj2 + 16;
			obj3 = manager;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj4 = obj2 + 24;
			obj4 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			if (model != null)
			{
				obj5 = typeof(MemberAchievementClanFeedData) + 2976;
				<Id>k__BackingField = model.Id;
				object obj6 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X0_v12+E4]");
				if ((nint)0 != 0)
				{
					bool flag = emptyImage != null;
					bool flag2 = !flag;
					object obj7 = !flag2;
					if (obj7 != null)
					{
						goto IL_0139;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					if (emptyImage != null)
					{
						goto IL_0139;
					}
				}
				goto IL_0197;
			}
		}
		goto IL_04b0;
		IL_02a0:
		if ((object)loadingIndicator != null)
		{
			loadingIndicator.SetActive(value: true);
			object obj8 = 0;
			goto IL_02dd;
		}
		goto IL_04b0;
		IL_02dd:
		Button button = this.button;
		if ((object)this.button != null && button.m_OnClick != null)
		{
			button.m_OnClick.RemoveAllListeners();
			Button button2 = this.button;
			if ((object)this.button != null)
			{
				object obj9 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
				object obj10 = (nint)0 + (nint)304;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				UnityAction unityAction = default(UnityAction);
				unityAction..ctor(obj2, (IntPtr)obj10);
				if (button2.m_OnClick != null)
				{
					object obj11 = typeof(Queue<string>) + 1856;
					object obj12 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
					object obj13 = (nint)0 + (nint)312;
					button2.m_OnClick.AddListener(unityAction);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					TaskCompletionSource<bool> taskCompletionSource = default(TaskCompletionSource<bool>);
					taskCompletionSource..ctor();
					object obj14 = obj2 + 32;
					obj14 = taskCompletionSource;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					Action<bool> action = default(Action<bool>);
					action..ctor(obj2, (IntPtr)obj13);
					UIExtensions.LoadClanLogoImage(image, <Id>k__BackingField, tier, action);
					object obj15 = obj14;
					if (obj14 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X8_v9+10]");
						return (Task<bool>)0;
					}
				}
			}
		}
		goto IL_04b0;
		IL_04b0:
		return (Task<bool>)(object)new NullReferenceException();
		IL_0197:
		if ((object)image != null)
		{
			GameObject gameObject = image.gameObject;
			if ((object)gameObject != null)
			{
				gameObject.SetActive(value: false);
				object obj16 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X8_v6+E4]");
				if ((nint)0 != 0)
				{
					bool flag3 = loadingIndicator != null;
					bool flag4 = !flag3;
					object obj17 = !flag4;
					if (obj17 != null)
					{
						goto IL_02a0;
					}
					object obj8 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					bool flag5 = loadingIndicator != null;
					bool flag6 = !flag5;
					object obj8 = 0;
					if (!flag6)
					{
						goto IL_02a0;
					}
				}
				goto IL_02dd;
			}
		}
		goto IL_04b0;
		IL_0139:
		if ((object)emptyImage != null)
		{
			GameObject gameObject2 = emptyImage.gameObject;
			if ((object)gameObject2 != null)
			{
				gameObject2.SetActive(value: false);
				goto IL_0197;
			}
		}
		goto IL_04b0;
	}

	public Task<bool> InitAsEmpty(ClanLogoImageSelector manager)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_006a: Expected I4, but got I8
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected O, but got Unknown
		//IL_0202: Expected O, but got I4
		//IL_012a: Expected O, but got I4
		//IL_0133: Expected O, but got I4
		//IL_0177: Expected I4, but got O
		//IL_02d3: Expected O, but got I4
		//IL_01b3: Expected O, but got I4
		//IL_0278: Expected O, but got I4
		//IL_0281: Expected O, but got I4
		//IL_01ca: Expected O, but got I4
		//IL_0343: Expected O, but got I4
		//IL_03d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03de: Expected O, but got Unknown
		//IL_03ea: Expected O, but got I
		//IL_0405: Expected I, but got O
		//IL_043b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0440: Expected O, but got Unknown
		object obj = typeof(CardUtils.<>c) + 1144;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj5;
		UnityEngine.Object obj9;
		UnityEngine.Object obj10;
		UnityEngine.Object obj13;
		object obj11;
		bool flag6;
		if (obj2 != null)
		{
			object obj3 = obj2 + 16;
			obj3 = manager;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj4 = obj2 + 24;
			obj4 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			<Id>k__BackingField = -1;
			if ((object)image != null)
			{
				GameObject gameObject = image.gameObject;
				if ((object)gameObject != null)
				{
					obj5 = typeof(MemberAchievementClanFeedData) + 2976;
					gameObject.SetActive(value: false);
					object obj6 = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X8_v5+E4]");
					if ((nint)0 != 0)
					{
						bool flag = loadingIndicator != null;
						bool flag2 = !flag;
						object obj7 = !flag2;
						object obj8 = 0;
						obj9 = null;
						if (obj7 == null)
						{
							goto IL_0146;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						bool flag3 = loadingIndicator != null;
						bool flag4 = !flag3;
						object obj8 = 0;
						obj9 = null;
						if (flag4)
						{
							goto IL_0146;
						}
					}
					if ((object)loadingIndicator != null)
					{
						loadingIndicator.SetActive(value: false);
						obj10 = emptyImage;
						obj11 = obj5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X8_v11+E4]");
						bool flag5 = (nint)0 == 0;
						object obj12 = !flag5;
						object obj8 = 0;
						flag6 = false;
						obj13 = emptyImage;
						if (obj12 != null)
						{
							goto IL_018f;
						}
						goto IL_02a2;
					}
				}
			}
		}
		goto IL_04b5;
		IL_04b5:
		return (Task<bool>)(object)new NullReferenceException();
		IL_0146:
		obj10 = emptyImage;
		obj11 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X8_v11+E4]");
		bool flag7 = (nint)0 == 0;
		flag6 = (byte)(int)obj9 != 0;
		obj13 = emptyImage;
		if (!flag7)
		{
			goto IL_018f;
		}
		goto IL_02a2;
		IL_02a2:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag8 = obj13 != null;
		bool flag9 = !flag8;
		object obj14 = 0;
		if (!flag9)
		{
			goto IL_02e1;
		}
		goto IL_0348;
		IL_0348:
		Button button = this.button;
		if ((object)this.button != null && button.m_OnClick != null)
		{
			button.m_OnClick.RemoveAllListeners();
			Button button2 = this.button;
			if ((object)this.button != null)
			{
				object obj15 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
				object obj16 = (nint)0 + (nint)296;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				UnityAction unityAction = default(UnityAction);
				unityAction..ctor(obj2, (IntPtr)obj16);
				if (button2.m_OnClick != null)
				{
					object obj17 = typeof(System.Formats.Asn1.SetOfValueComparer) + 3912;
					button2.m_OnClick.AddListener(unityAction);
					object obj18 = obj17;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X0_v20+E4]");
					if ((nint)0 != 0)
					{
						return Task.FromResult(result: true);
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					return Task.FromResult(result: true);
				}
			}
		}
		goto IL_04b5;
		IL_02e1:
		if ((object)emptyImage != null)
		{
			GameObject gameObject2 = emptyImage.gameObject;
			if ((object)gameObject2 != null)
			{
				gameObject2.SetActive(value: true);
				obj14 = 0;
				goto IL_0348;
			}
		}
		goto IL_04b5;
		IL_018f:
		bool flag10 = obj10 != null;
		bool flag11 = !flag10;
		object obj19 = !flag11;
		if (obj19 != null)
		{
			goto IL_02e1;
		}
		obj14 = 0;
		goto IL_0348;
	}

	public void Select()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_010a: Expected O, but got I4
		//IL_015e: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8913]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			obj5 = selectedIndicator;
			obj6 = selectedIndicator;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = selectedIndicator;
			obj6 = selectedIndicator;
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
		GameObject gameObject = selectedIndicator.gameObject;
		gameObject.SetActive(value: true);
		return;
		IL_0091:
		if ((bool)obj5)
		{
			goto IL_00b7;
		}
	}

	public void Deselect()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_010a: Expected O, but got I4
		//IL_015e: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8914]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			obj5 = selectedIndicator;
			obj6 = selectedIndicator;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = selectedIndicator;
			obj6 = selectedIndicator;
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
		GameObject gameObject = selectedIndicator.gameObject;
		gameObject.SetActive(value: false);
		return;
		IL_0091:
		if ((bool)obj5)
		{
			goto IL_00b7;
		}
	}

	public void SetColor(Color color)
	{
		//IL_0108: Expected I4, but got I8
		//IL_0122: Expected O, but got I4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_00e5: Expected O, but got I4
		//IL_0086: Expected I, but got O
		//IL_0096: Expected O, but got I
		//IL_00a6: Expected O, but got I
		int num = (int)(<Id>k__BackingField & 0x80000000L);
		bool flag = num == 0;
		object obj = !flag;
		if (obj != null)
		{
			return;
		}
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v3+E4]");
		if ((nint)0 != 0)
		{
			if (this.image != null)
			{
				goto IL_006f;
			}
			return;
		}
		goto IL_00b0;
		IL_006f:
		Image image = this.image;
		nint num2 = (nint)image;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X8_v8 (Il2CppClass<UnityEngine.UI.Image>)+2A8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X8_v8 (Il2CppClass<UnityEngine.UI.Image>)+2B0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v95 @ X2_v4 (should have been resolved before IL gen)");
		goto IL_00b0;
		IL_00b0:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag2 = this.image != null;
		bool flag3 = !flag2;
		object obj6 = !flag3;
		if (obj6 == null)
		{
			return;
		}
		goto IL_006f;
	}
}
