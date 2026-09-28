using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Formats.Asn1;
using Cpp2ILInjected;
using GoogleMobileAds.Api.AdManager;
using UnityEngine;

public class AnimatedAssetsLoader : Singleton<AnimatedAssetsLoader>
{
	private sealed class <>c__DisplayClass0_0
	{
		public EmoteAnimationDataModel model;

		public int counter;

		public Action<EmoteAnimationDataModel> callback;

		internal void <LoadEmoteItem>b__0(Sprite sprite)
		{
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Expected O, but got Unknown
			//IL_010d: Expected O, but got I
			//IL_011d: Expected O, but got I
			//IL_012d: Expected O, but got I
			//IL_00a4: Expected O, but got I
			//IL_00b4: Expected O, but got I
			//IL_00c4: Expected O, but got I
			Texture2D texture = sprite.texture;
			object obj = model + 16;
			obj = texture;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			int num = counter - 1;
			counter = num;
			if (model.IsValid())
			{
				Action<EmoteAnimationDataModel> action = callback;
				EmoteAnimationDataModel emoteAnimationDataModel = model;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ X8_v6 (System.Action`1<EmoteAnimationDataModel>)+18]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ X8_v6 (System.Action`1<EmoteAnimationDataModel>)+40]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ X8_v6 (System.Action`1<EmoteAnimationDataModel>)+28]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v61 @ X3_v2 (should have been resolved before IL gen)");
			}
			if (counter != 0)
			{
				return;
			}
			Action<EmoteAnimationDataModel> action2 = callback;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X8_v5 (System.Action`1<EmoteAnimationDataModel>)+18]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X8_v5 (System.Action`1<EmoteAnimationDataModel>)+40]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X8_v5 (System.Action`1<EmoteAnimationDataModel>)+28]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v62 @ X3_v1 (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
		}

		internal void <LoadEmoteItem>b__1(AudioClip audioClip)
		{
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Expected O, but got Unknown
			//IL_00fb: Expected O, but got I
			//IL_010b: Expected O, but got I
			//IL_011b: Expected O, but got I
			//IL_0092: Expected O, but got I
			//IL_00a2: Expected O, but got I
			//IL_00b2: Expected O, but got I
			object obj = model + 24;
			obj = audioClip;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			int num = counter - 1;
			counter = num;
			if (model.IsValid())
			{
				Action<EmoteAnimationDataModel> action = callback;
				EmoteAnimationDataModel emoteAnimationDataModel = model;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ X8_v6 (System.Action`1<EmoteAnimationDataModel>)+18]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ X8_v6 (System.Action`1<EmoteAnimationDataModel>)+40]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ X8_v6 (System.Action`1<EmoteAnimationDataModel>)+28]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v57 @ X3_v2 (should have been resolved before IL gen)");
			}
			if (counter != 0)
			{
				return;
			}
			Action<EmoteAnimationDataModel> action2 = callback;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X8_v5 (System.Action`1<EmoteAnimationDataModel>)+18]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X8_v5 (System.Action`1<EmoteAnimationDataModel>)+40]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X8_v5 (System.Action`1<EmoteAnimationDataModel>)+28]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v58 @ X3_v1 (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
		}

		internal void <LoadEmoteItem>b__2(string json)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_00d4: Expected O, but got I4
			//IL_0133: Expected O, but got I
			//IL_015a: Unknown result type (might be due to invalid IL or missing references)
			//IL_015f: Expected O, but got Unknown
			//IL_0118: Expected O, but got I4
			//IL_0225: Expected O, but got I
			//IL_0235: Expected O, but got I
			//IL_0245: Expected O, but got I
			object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6B56]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v14+E4]");
				if ((nint)0 != 0)
				{
					goto IL_0074;
				}
			}
			else
			{
				_ = 1;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v14+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 != null)
				{
					goto IL_0074;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag2 = StringsExtensions.IsNullOrEmpty(json);
			bool flag3 = !flag2;
			object obj5 = !flag3;
			if (obj5 == null)
			{
				goto IL_0127;
			}
			goto IL_0177;
			IL_0177:
			int num = counter - 1;
			counter = num;
			if (model.IsValid())
			{
				Action<EmoteAnimationDataModel> action = callback;
				EmoteAnimationDataModel emoteAnimationDataModel = model;
			}
			else
			{
				if (counter != 0)
				{
					return;
				}
				Action<EmoteAnimationDataModel> action = callback;
				EmoteAnimationDataModel emoteAnimationDataModel = null;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X8_v6 (System.Action`1<EmoteAnimationDataModel>)+18]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X8_v6 (System.Action`1<EmoteAnimationDataModel>)+40]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X8_v6 (System.Action`1<EmoteAnimationDataModel>)+28]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v113 @ X3_v1 (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
			IL_0127:
			object obj9 = (nint)0 + (nint)1144;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3021E4C");
			object obj10 = default(object);
			JsonUtility.FromJsonOverwrite(json, obj10);
			object obj11 = model + 32;
			obj11 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			goto IL_0177;
			IL_0074:
			if (!StringsExtensions.IsNullOrEmpty(json))
			{
				goto IL_0127;
			}
			goto IL_0177;
		}

		internal void <LoadEmoteItem>g__ProcessAssetLoaded|3()
		{
			//IL_00d9: Expected O, but got I
			//IL_00e9: Expected O, but got I
			//IL_00f9: Expected O, but got I
			//IL_0070: Expected O, but got I
			//IL_0080: Expected O, but got I
			//IL_0090: Expected O, but got I
			int num = counter - 1;
			counter = num;
			if (model.IsValid())
			{
				Action<EmoteAnimationDataModel> action = callback;
				EmoteAnimationDataModel emoteAnimationDataModel = model;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ X8_v6 (System.Action`1<EmoteAnimationDataModel>)+18]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ X8_v6 (System.Action`1<EmoteAnimationDataModel>)+40]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ X8_v6 (System.Action`1<EmoteAnimationDataModel>)+28]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v55 @ X3_v2 (should have been resolved before IL gen)");
			}
			if (counter != 0)
			{
				return;
			}
			Action<EmoteAnimationDataModel> action2 = callback;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X8_v5 (System.Action`1<EmoteAnimationDataModel>)+18]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X8_v5 (System.Action`1<EmoteAnimationDataModel>)+40]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X8_v5 (System.Action`1<EmoteAnimationDataModel>)+28]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v56 @ X3_v1 (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
		}
	}

	private sealed class <>c__DisplayClass1_0
	{
		public GiftAnimationDataModel model;

		public int counter;

		public Action<GiftAnimationDataModel> callback;

		internal void <LoadAnimatedGiftItem>b__0(Sprite sprite)
		{
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Expected O, but got Unknown
			//IL_010d: Expected O, but got I
			//IL_011d: Expected O, but got I
			//IL_012d: Expected O, but got I
			//IL_00a4: Expected O, but got I
			//IL_00b4: Expected O, but got I
			//IL_00c4: Expected O, but got I
			Texture2D texture = sprite.texture;
			object obj = model + 16;
			obj = texture;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			int num = counter - 1;
			counter = num;
			if (model.IsValid())
			{
				Action<GiftAnimationDataModel> action = callback;
				GiftAnimationDataModel giftAnimationDataModel = model;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ X8_v6 (System.Action`1<GiftAnimationDataModel>)+18]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ X8_v6 (System.Action`1<GiftAnimationDataModel>)+40]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ X8_v6 (System.Action`1<GiftAnimationDataModel>)+28]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v61 @ X3_v2 (should have been resolved before IL gen)");
			}
			if (counter != 0)
			{
				return;
			}
			Action<GiftAnimationDataModel> action2 = callback;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X8_v5 (System.Action`1<GiftAnimationDataModel>)+18]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X8_v5 (System.Action`1<GiftAnimationDataModel>)+40]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X8_v5 (System.Action`1<GiftAnimationDataModel>)+28]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v62 @ X3_v1 (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
		}

		internal void <LoadAnimatedGiftItem>b__1(AudioClip audioClip)
		{
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Expected O, but got Unknown
			//IL_00fb: Expected O, but got I
			//IL_010b: Expected O, but got I
			//IL_011b: Expected O, but got I
			//IL_0092: Expected O, but got I
			//IL_00a2: Expected O, but got I
			//IL_00b2: Expected O, but got I
			object obj = model + 24;
			obj = audioClip;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			int num = counter - 1;
			counter = num;
			if (model.IsValid())
			{
				Action<GiftAnimationDataModel> action = callback;
				GiftAnimationDataModel giftAnimationDataModel = model;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ X8_v6 (System.Action`1<GiftAnimationDataModel>)+18]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ X8_v6 (System.Action`1<GiftAnimationDataModel>)+40]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ X8_v6 (System.Action`1<GiftAnimationDataModel>)+28]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v57 @ X3_v2 (should have been resolved before IL gen)");
			}
			if (counter != 0)
			{
				return;
			}
			Action<GiftAnimationDataModel> action2 = callback;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X8_v5 (System.Action`1<GiftAnimationDataModel>)+18]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X8_v5 (System.Action`1<GiftAnimationDataModel>)+40]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X8_v5 (System.Action`1<GiftAnimationDataModel>)+28]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v58 @ X3_v1 (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
		}

		internal void <LoadAnimatedGiftItem>b__2(string json)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_00d4: Expected O, but got I4
			//IL_0133: Expected O, but got I
			//IL_015a: Unknown result type (might be due to invalid IL or missing references)
			//IL_015f: Expected O, but got Unknown
			//IL_0118: Expected O, but got I4
			//IL_0225: Expected O, but got I
			//IL_0235: Expected O, but got I
			//IL_0245: Expected O, but got I
			object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6B57]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v14+E4]");
				if ((nint)0 != 0)
				{
					goto IL_0074;
				}
			}
			else
			{
				_ = 1;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v14+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 != null)
				{
					goto IL_0074;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag2 = StringsExtensions.IsNullOrEmpty(json);
			bool flag3 = !flag2;
			object obj5 = !flag3;
			if (obj5 == null)
			{
				goto IL_0127;
			}
			goto IL_0177;
			IL_0177:
			int num = counter - 1;
			counter = num;
			if (model.IsValid())
			{
				Action<GiftAnimationDataModel> action = callback;
				GiftAnimationDataModel giftAnimationDataModel = model;
			}
			else
			{
				if (counter != 0)
				{
					return;
				}
				Action<GiftAnimationDataModel> action = callback;
				GiftAnimationDataModel giftAnimationDataModel = null;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X8_v6 (System.Action`1<GiftAnimationDataModel>)+18]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X8_v6 (System.Action`1<GiftAnimationDataModel>)+40]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X8_v6 (System.Action`1<GiftAnimationDataModel>)+28]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v113 @ X3_v1 (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
			IL_0127:
			object obj9 = (nint)0 + (nint)1264;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3021E4C");
			object obj10 = default(object);
			JsonUtility.FromJsonOverwrite(json, obj10);
			object obj11 = model + 32;
			obj11 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			goto IL_0177;
			IL_0074:
			if (!StringsExtensions.IsNullOrEmpty(json))
			{
				goto IL_0127;
			}
			goto IL_0177;
		}

		internal void <LoadAnimatedGiftItem>g__ProcessAssetLoaded|3()
		{
			//IL_00d9: Expected O, but got I
			//IL_00e9: Expected O, but got I
			//IL_00f9: Expected O, but got I
			//IL_0070: Expected O, but got I
			//IL_0080: Expected O, but got I
			//IL_0090: Expected O, but got I
			int num = counter - 1;
			counter = num;
			if (model.IsValid())
			{
				Action<GiftAnimationDataModel> action = callback;
				GiftAnimationDataModel giftAnimationDataModel = model;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ X8_v6 (System.Action`1<GiftAnimationDataModel>)+18]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ X8_v6 (System.Action`1<GiftAnimationDataModel>)+40]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ X8_v6 (System.Action`1<GiftAnimationDataModel>)+28]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v55 @ X3_v2 (should have been resolved before IL gen)");
			}
			if (counter != 0)
			{
				return;
			}
			Action<GiftAnimationDataModel> action2 = callback;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X8_v5 (System.Action`1<GiftAnimationDataModel>)+18]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X8_v5 (System.Action`1<GiftAnimationDataModel>)+40]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X8_v5 (System.Action`1<GiftAnimationDataModel>)+28]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v56 @ X3_v1 (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
		}
	}

	public void LoadEmoteItem(int itemID, UnityEngine.Object go, Action<EmoteAnimationDataModel> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_004d: Expected O, but got I
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected O, but got Unknown
		//IL_006d: Expected O, but got I
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected O, but got Unknown
		//IL_00fa: Expected O, but got I4
		//IL_0141: Expected I, but got O
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Expected O, but got Unknown
		//IL_0166: Expected O, but got I
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Expected O, but got Unknown
		//IL_0186: Expected O, but got I
		//IL_01ca: Expected O, but got I4
		//IL_0211: Expected I, but got O
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_022a: Expected O, but got Unknown
		//IL_0236: Expected O, but got I
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_024a: Expected O, but got Unknown
		//IL_0256: Expected O, but got I
		//IL_0295: Expected O, but got I4
		//IL_02dc: Expected I, but got O
		object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 1040;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(DataRelation) + 3008;
		object obj4 = typeof(Queue<string>) + 760;
		object obj5 = (nint)0 + (nint)2040;
		object obj6 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3480;
		object obj7 = (nint)0 + (nint)3280;
		object obj8 = obj2 + 32;
		obj8 = callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj9 = default(object);
		obj9..ctor();
		object obj10 = obj2 + 16;
		obj10 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		_ = 3;
		object obj11 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X0_v13+E4]");
		bool flag = (nint)0 == 0;
		object obj12 = !flag;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj7);
		object obj13 = typeof(Queue<string>) + 704;
		object obj14 = (nint)0 + (nint)1920;
		object obj15 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1184;
		object obj16 = (nint)0 + (nint)3288;
		ImageCacher imageCacher = default(ImageCacher);
		imageCacher.LoadItemImage(itemID, ImageCacher.ItemImageType.InGame, go, action);
		object obj17 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X0_v20+E4]");
		bool flag2 = (nint)0 == 0;
		object obj18 = !flag2;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor(obj2, (IntPtr)obj16);
		object obj19 = typeof(Queue<string>) + 864;
		object obj20 = (nint)0 + (nint)2232;
		object obj21 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
		object obj22 = (nint)0 + (nint)3296;
		AudioCacher audioCacher = default(AudioCacher);
		audioCacher.LoadItemAudio(itemID, go, action2);
		object obj23 = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X0_v27+E4]");
		bool flag3 = (nint)0 == 0;
		object obj24 = !flag3;
		if (obj24 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action3 = default(Action<object>);
		action3..ctor(obj2, (IntPtr)obj22);
		StringCacher stringCacher = default(StringCacher);
		stringCacher.LoadItemAnimationData(itemID, go, action3);
	}

	public void LoadAnimatedGiftItem(int itemID, UnityEngine.Object go, Action<GiftAnimationDataModel> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_004d: Expected O, but got I
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected O, but got Unknown
		//IL_006d: Expected O, but got I
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected O, but got Unknown
		//IL_00fa: Expected O, but got I4
		//IL_0141: Expected I, but got O
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Expected O, but got Unknown
		//IL_0166: Expected O, but got I
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Expected O, but got Unknown
		//IL_0186: Expected O, but got I
		//IL_01ca: Expected O, but got I4
		//IL_0211: Expected I, but got O
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_022a: Expected O, but got Unknown
		//IL_0236: Expected O, but got I
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_024a: Expected O, but got Unknown
		//IL_0256: Expected O, but got I
		//IL_0295: Expected O, but got I4
		//IL_02dc: Expected I, but got O
		object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 1048;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2824;
		object obj4 = typeof(Queue<string>) + 760;
		object obj5 = (nint)0 + (nint)2040;
		object obj6 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3480;
		object obj7 = (nint)0 + (nint)3304;
		object obj8 = obj2 + 32;
		obj8 = callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj9 = default(object);
		obj9..ctor();
		object obj10 = obj2 + 16;
		obj10 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		_ = 3;
		object obj11 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X0_v13+E4]");
		bool flag = (nint)0 == 0;
		object obj12 = !flag;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj7);
		object obj13 = typeof(Queue<string>) + 704;
		object obj14 = (nint)0 + (nint)1920;
		object obj15 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1184;
		object obj16 = (nint)0 + (nint)3312;
		ImageCacher imageCacher = default(ImageCacher);
		imageCacher.LoadItemImage(itemID, ImageCacher.ItemImageType.InGame, go, action);
		object obj17 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X0_v20+E4]");
		bool flag2 = (nint)0 == 0;
		object obj18 = !flag2;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor(obj2, (IntPtr)obj16);
		object obj19 = typeof(Queue<string>) + 864;
		object obj20 = (nint)0 + (nint)2232;
		object obj21 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
		object obj22 = (nint)0 + (nint)3320;
		AudioCacher audioCacher = default(AudioCacher);
		audioCacher.LoadItemAudio(itemID, go, action2);
		object obj23 = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X0_v27+E4]");
		bool flag3 = (nint)0 == 0;
		object obj24 = !flag3;
		if (obj24 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action3 = default(Action<object>);
		action3..ctor(obj2, (IntPtr)obj22);
		StringCacher stringCacher = default(StringCacher);
		stringCacher.LoadItemAnimationData(itemID, go, action3);
	}

	public void LoadAnimatedRoomElements(int itemID, UnityEngine.Object go, Action<AnimatedRoomDataModel> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(SqlSingle[]) + 3848;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		AnimatedRoomElementsLoader animatedRoomElementsLoader = default(AnimatedRoomElementsLoader);
		animatedRoomElementsLoader..ctor(itemID, go);
		animatedRoomElementsLoader.Load(callback);
	}

	public AnimatedAssetsLoader()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00ae: Expected O, but got I
		//IL_00d8: Expected O, but got I4
		//IL_005c: Expected O, but got I
		object obj = 152985600;
		object obj2 = typeof(Queue<string>) + 688;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6B55]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)1880;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v1+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = obj4;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = (nint)0 + (nint)1880;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v1+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			object obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CECC90");
		return;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CECC90");
	}
}
