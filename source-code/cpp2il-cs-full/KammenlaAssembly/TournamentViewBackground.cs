using System;
using System.Diagnostics;
using Cpp2ILInjected;
using Server.Models;
using UnityEngine;
using UnityEngine.UI;

public class TournamentViewBackground : MonoBehaviour
{
	private Image background;

	private Image backgroundLayer2;

	private Sprite originalBackgroundSprite;

	private Sprite officialBackgroundSprite;

	public void SetupBackground(TournamentData data)
	{
		//IL_003f: Expected O, but got I4
		//IL_0059: Expected O, but got I4
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		//IL_0081: Expected O, but got I4
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected O, but got Unknown
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Expected O, but got Unknown
		//IL_0193: Expected I, but got O
		//IL_01a3: Expected O, but got I
		//IL_0239: Expected O, but got I
		//IL_025f: Expected O, but got I4
		//IL_02c6: Expected I, but got O
		//IL_02d3: Expected O, but got I
		//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e7: Expected O, but got Unknown
		//IL_02fd: Expected O, but got I
		//IL_030b: Expected I, but got O
		//IL_01de: Expected O, but got I
		//IL_028c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Expected O, but got Unknown
		//IL_029a: Unknown result type (might be due to invalid IL or missing references)
		//IL_029f: Expected O, but got Unknown
		//IL_02af: Expected O, but got I
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Expected O, but got Unknown
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Expected O, but got Unknown
		GameObject gameObject = backgroundLayer2.gameObject;
		gameObject.SetActive(value: false);
		object obj = data.<Type>k__BackingField - 3;
		bool flag = (nint)obj < 1;
		object obj2 = !flag;
		object obj3 = obj - 1;
		bool flag2 = obj3 == null;
		object obj4 = !flag2;
		object obj5 = obj2 & obj4;
		if (obj5 == null)
		{
			GameObject gameObject2 = backgroundLayer2.gameObject;
			gameObject2.SetActive(value: true);
			backgroundLayer2.sprite = officialBackgroundSprite;
			return;
		}
		MassEventModel cachedMassEvent;
		Image image;
		object obj12;
		if (data.<Type>k__BackingField == TournamentType.Mass)
		{
			object obj6 = (??)data.<ParentMassEventId>k__BackingField & 1;
			if (obj6 != null)
			{
				long? num = default(long?);
				long value = num.Value;
				cachedMassEvent = MassTournamentManager.GetCachedMassEvent(value);
				background.sprite = null;
				image = background;
				IThemeColorProfile themeColorProfile = cachedMassEvent.GenerateTheme();
				object obj7 = typeof(System.IOAsyncCallback) + 1712;
				nint num2 = (nint)themeColorProfile;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X8_v11 (Il2CppClass<IThemeColorProfile>)+12E]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X8_v11 (Il2CppClass<IThemeColorProfile>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_021f;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X8_v11 (Il2CppClass<IThemeColorProfile>)+B0]");
				object obj9 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X10_v6-8]");
					if (0 == (nint)obj7)
					{
						break;
					}
					obj9 += 16;
					obj8--;
					if ((nint)obj8 != 1)
					{
						continue;
					}
					goto IL_021f;
				}
				object obj10 = num2 + obj9;
				object obj11 = obj10 + 312;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X8_v20+8]");
				obj12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v168 @ X8_v20] (should have been resolved before IL gen)");
				goto IL_02be;
			}
		}
		background.sprite = originalBackgroundSprite;
		return;
		IL_02be:
		nint num3 = (nint)image;
		background.color = (Color)0;
		object obj13 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj14 = (nint)0 + (nint)1568;
		Action<bool> action = default(Action<bool>);
		action..ctor((object)this, (IntPtr)obj14);
		UIExtensions.LoadMassTournamentImage(backgroundLayer2, cachedMassEvent, ImageCacher.MassTournamentImageType.BackGround, setNative: false, action);
		return;
		IL_021f:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X0_v19+8]");
		obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v286 @ X0_v19] (should have been resolved before IL gen)");
		bool flag3 = (object)background == null;
		object obj15 = !flag3;
		if (obj15 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_02be;
	}

	private void <SetupBackground>b__4_0(bool success)
	{
		GameObject gameObject = backgroundLayer2.gameObject;
		gameObject.SetActive(success);
	}
}
