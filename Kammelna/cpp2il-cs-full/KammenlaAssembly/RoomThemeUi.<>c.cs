using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Formats.Asn1;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Sfs2X.Entities;
using Unity.Properties;
using UnityEngine;
using UnityEngine.UI;

public class RoomThemeUi : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Action<Image> <>9__12_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 2136;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal void <OnExitGame>b__12_0(Image image)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0074: Expected O, but got I4
			object obj = typeof(SqlSingle[]) + 3912;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Tween tween = AnimationExtensions.DOFadeChildren(image, 0f, 0.3f);
		}
	}

	private Image background;

	private Image roomTheme;

	private Image dimmingLayer;

	private RoomThemesSprites roomThemesSprites;

	private GameEventsChannel gameEventsChannel;

	private SportTeamRoomTheme sportTeamRoomTheme;

	private KGame _game;

	private Transform[] _roomElementsTransformToShowHide;

	public Transform AnimatedElementsParent
	{
		get
		{
			if ((object)background != null)
			{
				return background.transform;
			}
			return (Transform)(object)new NullReferenceException();
		}
	}

	private void Start()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_02e5: Expected O, but got I
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f9: Expected O, but got Unknown
		//IL_0305: Expected O, but got I
		//IL_032f: Expected O, but got I4
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_006c: Expected I, but got O
		//IL_007d: Expected O, but got I
		//IL_00a7: Expected I, but got O
		//IL_00b8: Expected O, but got I
		//IL_00e4: Expected I, but got O
		//IL_00f5: Expected O, but got I
		//IL_0121: Expected I, but got O
		//IL_0132: Expected O, but got I
		//IL_015e: Expected I, but got O
		//IL_01b2: Expected O, but got I
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Expected O, but got Unknown
		//IL_01ed: Expected I, but got O
		//IL_0233: Expected O, but got I4
		//IL_02ab: Expected O, but got I
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = (nint)0 + (nint)136;
		object obj3 = typeof(SqlSingle[]) + 2376;
		object obj4 = (nint)0 + (nint)3016;
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		object obj7 = this + 80;
		object obj8 = default(object);
		obj7 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj4);
		object obj9 = (nint)0 + (nint)3032;
		((KGame)obj7).OnGameExiting += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj9);
		object obj10 = (nint)0 + (nint)3008;
		gameEventsChannel.ShowUi += action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action3 = default(Action);
		action3..ctor(this, (IntPtr)obj10);
		object obj11 = (nint)0 + (nint)3000;
		gameEventsChannel.HideUi += action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action4 = default(Action);
		action4..ctor(this, (IntPtr)obj11);
		object obj12 = (nint)0 + (nint)2992;
		gameEventsChannel.ShowGiftSelection += action4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action5 = default(Action);
		action5..ctor(this, (IntPtr)obj12);
		gameEventsChannel.HideGiftSelection += action5;
		UIExtensions.SetAlpha(roomTheme, 0f);
		UIExtensions.SetAlpha(dimmingLayer, 0f);
		GameObject go = base.gameObject;
		object obj13 = (nint)0 + (nint)3024;
		object varName = "placementId" + 2112;
		Room room = _game.Room;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action6 = default(Action);
		action6..ctor(this, (IntPtr)obj13);
		VariableBinderExtensions.Bind(go, room, (string)varName, action6);
		Transform transform = background.transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		transform.localScale = (Vector3)0;
		UIExtensions.SetAlpha(background, 0f);
		Room room2 = _game.Room;
		if (SFSKammelnaRoomExtensions.HasTheme(room2))
		{
			TweenerCore<Color, Color, ColorOptions> tweenerCore = DOTweenModuleUI.DOFade(background, 1f, 0f);
			object obj14 = (nint)0 + (nint)2736;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
		}
		else
		{
			TweenerCore<Color, Color, ColorOptions> tweenerCore2 = DOTweenModuleUI.DOFade(background, 1f, 0.3f);
		}
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_0104: Expected I, but got O
		//IL_0031: Expected O, but got I
		//IL_005d: Expected I, but got O
		//IL_006e: Expected O, but got I
		//IL_009a: Expected I, but got O
		//IL_00ab: Expected O, but got I
		//IL_00d7: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)3032;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj3 = (nint)0 + (nint)3008;
		gameEventsChannel.ShowUi -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj3);
		object obj4 = (nint)0 + (nint)3000;
		gameEventsChannel.HideUi -= action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action3 = default(Action);
		action3..ctor(this, (IntPtr)obj4);
		object obj5 = (nint)0 + (nint)2992;
		gameEventsChannel.ShowGiftSelection -= action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action4 = default(Action);
		action4..ctor(this, (IntPtr)obj5);
		gameEventsChannel.HideGiftSelection -= action4;
	}

	private void OnExitGame()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0033: Expected O, but got I4
		//IL_0049: Expected I, but got O
		//IL_0059: Expected O, but got I
		//IL_0082: Expected O, but got I
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected O, but got Unknown
		//IL_0169: Expected O, but got I8
		//IL_0108: Expected I, but got O
		//IL_0118: Expected O, but got I
		//IL_0141: Expected O, but got I
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Expected O, but got Unknown
		//IL_0242: Expected O, but got I4
		//IL_0258: Expected O, but got I
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Expected O, but got Unknown
		//IL_01d9: Expected I, but got O
		//IL_01e9: Expected O, but got I
		//IL_0212: Expected O, but got I
		//IL_029a: Unknown result type (might be due to invalid IL or missing references)
		//IL_029f: Expected O, but got Unknown
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ad: Expected O, but got Unknown
		//IL_0385: Expected O, but got I
		//IL_0395: Expected O, but got I
		//IL_03a5: Expected O, but got I
		//IL_03c7: Expected O, but got I4
		//IL_03df: Expected O, but got I
		//IL_02fa: Expected O, but got I
		//IL_030a: Expected O, but got I
		//IL_031a: Expected O, but got I
		//IL_033c: Expected O, but got I4
		//IL_040f: Expected O, but got I4
		//IL_04ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bf: Expected O, but got Unknown
		//IL_04d5: Expected O, but got I
		//IL_04e6: Expected I, but got O
		//IL_0504: Expected O, but got I
		//IL_0362: Expected O, but got I
		//IL_043f: Expected O, but got I
		object obj = typeof(TypeConverter<ushort, char>) + 2936;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		bool flag = (object)background == null;
		Image image = (Image)3;
		IEnumerable<object> enumerable = default(IEnumerable<object>);
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		Image image2;
		if (!flag)
		{
			nint num = (nint)enumerable;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X8_v27 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+40]");
			image = (Image)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
			bool flag2 = ex == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X8_v27 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+40]");
			image2 = (Image)0;
			if (flag2)
			{
				goto IL_046f;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3 (System.Collections.Generic.IEnumerable`1<System.Object>)+18]");
		object obj9;
		object obj13;
		Action<object> action;
		object obj15;
		object obj12;
		if ((nint)0 != 0)
		{
			object obj2 = enumerable + 32;
			obj2 = background;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			bool flag3 = (object)roomTheme == null;
			image = background;
			if (!flag3)
			{
				nint num2 = (nint)enumerable;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X8_v26 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+40]");
				image = (Image)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag4 = ex == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X8_v26 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+40]");
				image2 = (Image)0;
				if (flag4)
				{
					goto IL_046f;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3 (System.Collections.Generic.IEnumerable`1<System.Object>)+18]");
			object obj3 = 0 & 0xFFFFFFFEL;
			if (obj3 != null)
			{
				object obj4 = enumerable + 40;
				obj4 = roomTheme;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				bool flag5 = (object)dimmingLayer == null;
				image = roomTheme;
				if (!flag5)
				{
					nint num3 = (nint)enumerable;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X8_v25 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+40]");
					image = (Image)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag6 = ex == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X8_v25 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+40]");
					image2 = (Image)0;
					if (flag6)
					{
						goto IL_046f;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3 (System.Collections.Generic.IEnumerable`1<System.Object>)+18]");
				bool flag7 = (nint)0 < (nint)2;
				object obj5 = !flag7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3 (System.Collections.Generic.IEnumerable`1<System.Object>)+18]");
				object obj6 = -2;
				bool flag8 = obj6 == null;
				object obj7 = ~obj5;
				object obj8 = obj7 | flag8;
				if (obj8 == null)
				{
					obj9 = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 2136;
					object obj10 = enumerable + 48;
					obj10 = dimmingLayer;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					object obj11 = obj9;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X0_v26+E4]");
					if ((nint)0 != 0)
					{
						obj12 = (nint)0 + (nint)2192;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X0_v26+B8]");
						obj13 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X8_v15+8]");
						action = (Action<object>)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X8_v15+8]");
						bool flag9 = (nint)0 == 0;
						object obj14 = !flag9;
						if (obj14 == null)
						{
							obj15 = obj12;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X8_v15+8]");
							Action<object> action2 = (Action<object>)0;
							goto IL_03ed;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj11 = obj9;
						obj15 = (nint)0 + (nint)2192;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X0_v26+B8]");
						obj13 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X8_v15+8]");
						Action<object> action2 = (Action<object>)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X8_v15+8]");
						bool flag10 = (nint)0 == 0;
						object obj16 = !flag10;
						obj12 = obj15;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X8_v15+8]");
						action = (Action<object>)0;
						if (obj16 == null)
						{
							goto IL_03ed;
						}
					}
					goto IL_049d;
				}
			}
		}
		ex = new IndexOutOfRangeException();
		image2 = image;
		goto IL_046f;
		IL_049d:
		ArraysExtensions.ForEach(enumerable, action);
		return;
		IL_046f:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		OutOfMemoryException ex2 = new OutOfMemoryException();
		throw new NullReferenceException();
		IL_03ed:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X0_v26+E4]");
		bool flag11 = (nint)0 == 0;
		object obj17 = !flag11;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj18 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X8_v21+B8]");
			obj13 = 0;
		}
		object obj19 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2392;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj20 = (nint)0 + (nint)912;
		Action<object> action3 = default(Action<object>);
		action3..ctor(obj13, (IntPtr)obj20);
		object obj21 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X8_v20+B8]");
		object obj22 = (nint)0 + (nint)8;
		obj22 = action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj12 = obj15;
		action = action3;
		goto IL_049d;
	}

	private void RoomThemeChanged()
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_0046: Expected O, but got I
		//IL_007f: Expected O, but got I4
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		//IL_01c6: Expected O, but got I4
		//IL_01cf: Expected O, but got I4
		//IL_015c: Expected O, but got I4
		//IL_02d4: Expected O, but got I4
		//IL_0482: Unknown result type (might be due to invalid IL or missing references)
		//IL_0487: Expected O, but got Unknown
		//IL_04b1: Expected O, but got I4
		//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f6: Expected O, but got Unknown
		//IL_030c: Expected O, but got I
		//IL_031a: Expected I, but got O
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Expected O, but got Unknown
		//IL_032e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0333: Expected O, but got Unknown
		//IL_035d: Expected O, but got I4
		//IL_03bc: Expected O, but got I4
		//IL_02a0: Expected O, but got I4
		//IL_0423: Unknown result type (might be due to invalid IL or missing references)
		//IL_0428: Expected O, but got Unknown
		//IL_03f4: Expected O, but got I4
		//IL_03fd: Expected O, but got I4
		//IL_0443: Expected O, but got I
		//IL_0451: Expected I, but got O
		//IL_02b7: Expected O, but got I4
		Room room = _game.Room;
		int roomSportTeamID = SFSKammelnaRoomExtensions.GetRoomSportTeamID(room);
		object obj = typeof(Queue<string>) + 848;
		object obj2 = (nint)0 + (nint)2200;
		bool isFastTrackGame = _game.IsFastTrackGame;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X0_v9+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		int fTLevel = SFSKammelnaUserExtensions.GetFTLevel(localUser);
		bool isTutorial = _game.IsTutorial;
		object obj5 = typeof(MemberAchievementClanFeedData) + 2976;
		Sprite sprite = roomThemesSprites.GetRoomTheme(isFastTrackGame, fTLevel, isTutorial);
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X0_v19+E4]");
		if ((nint)0 != 0)
		{
			bool flag2 = sprite != null;
			bool flag3 = !flag2;
			object obj7 = 0;
			if (!flag3)
			{
				goto IL_016a;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag4 = sprite != null;
			bool flag5 = !flag4;
			object obj8 = !flag5;
			object obj7 = 0;
			if (obj8 != null)
			{
				goto IL_016a;
			}
		}
		Room room2 = _game.Room;
		int roomThemeID;
		StoreItem storeItem;
		object obj12;
		if (SFSKammelnaRoomExtensions.HasTheme(room2))
		{
			Room room3 = _game.Room;
			roomThemeID = SFSKammelnaRoomExtensions.GetRoomThemeID(room3);
			object obj9 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
			object obj10 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X0_v40+E4]");
			if ((nint)0 != 0)
			{
				storeItem = Store.GetStoreItem(roomThemeID);
				bool flag6 = storeItem == null;
				object obj11 = !flag6;
				if (obj11 != null)
				{
					goto IL_03ca;
				}
				obj12 = 0;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				storeItem = Store.GetStoreItem(roomThemeID);
				bool flag7 = storeItem == null;
				obj12 = 0;
				if (!flag7)
				{
					goto IL_03ca;
				}
			}
			goto IL_040b;
		}
		bool flag8 = roomSportTeamID < 1;
		object obj13 = 0;
		if (!flag8)
		{
			object obj14 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3472;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj15 = (nint)0 + (nint)2976;
			Action<object> action = default(Action<object>);
			action..ctor((object)this, (IntPtr)obj15);
			object obj16 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1176;
			object obj17 = obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X0_v33+E4]");
			bool flag9 = (nint)0 == 0;
			object obj18 = !flag9;
			if (obj18 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			SportTeamsUtil.GetSportTeamById(roomSportTeamID, action);
			return;
		}
		goto IL_0473;
		IL_03ca:
		bool flag10 = GamesFlagExtensions.MatchesCurrentGame(storeItem.<targetGames>k__BackingField);
		bool flag11 = !flag10;
		obj12 = 0;
		obj13 = 0;
		if (!flag11)
		{
			goto IL_040b;
		}
		goto IL_0473;
		IL_016a:
		roomTheme.sprite = sprite;
		UIExtensions.SetAlpha(roomTheme, 1f);
		return;
		IL_040b:
		bool isTablet = ScreenUtility.IsTablet;
		object obj19 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj20 = (nint)0 + (nint)2984;
		Action<bool> action2 = default(Action<bool>);
		action2..ctor((object)this, (IntPtr)obj20);
		UIExtensions.LoadItemImage(roomTheme, roomThemeID, isTablet ? ImageCacher.ItemImageType.InGameLandscape : ImageCacher.ItemImageType.InGame, FilterMode.Point, action2);
		return;
		IL_0473:
		object obj21 = typeof(SqlSingle[]) + 3912;
		object obj22 = obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X8_v9+E4]");
		bool flag12 = (nint)0 == 0;
		object obj23 = !flag12;
		if (obj23 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Tween tween = AnimationExtensions.DOFadeChildren(roomTheme, 0f, 0.3f);
	}

	public void EnableDimming()
	{
		//IL_0055: Expected O, but got I4
		Color color = roomTheme.color;
		object obj = default(object);
		Image image;
		if ((nint)obj > 0)
		{
			image = roomTheme;
			bool flag = (object)roomTheme == null;
			object obj2 = !flag;
			if (obj2 == null)
			{
				throw new NullReferenceException();
			}
		}
		else
		{
			image = background;
		}
		dimmingLayer.sprite = image.m_Sprite;
		int num = ShortcutExtensions.DOKill(dimmingLayer);
		TweenerCore<Color, Color, ColorOptions> tweenerCore = DOTweenModuleUI.DOFade(dimmingLayer, 0.5f, 0.3f);
	}

	public void DisableDimming()
	{
		int num = ShortcutExtensions.DOKill(dimmingLayer);
		TweenerCore<Color, Color, ColorOptions> tweenerCore = DOTweenModuleUI.DOFade(dimmingLayer, 0f, 0.3f);
	}

	public void ShowControls()
	{
		//IL_0033: Invalid comparison between O and F8
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_0088: Expected O, but got I4
		//IL_00e9: Expected F8, but got I4
		//IL_0129: Expected O, but got I
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected O, but got Unknown
		//IL_0178: Expected O, but got I4
		//IL_019d: Expected O, but got I
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Expected O, but got Unknown
		Transform transform = background.transform;
		Vector3 localScale = transform.localScale;
		object obj = default(object);
		if (obj <= (object)1.0)
		{
			return;
		}
		object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X0_v8+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Games currentGame = Preferences.CurrentGame;
		if (currentGame == Games.Jackaroo)
		{
			double num = 0.25;
		}
		else
		{
			double num = 0.0;
		}
		Transform target = background.transform;
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOScale(target, 1f, 0.3f);
		object obj5 = (nint)0 + (nint)2776;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
		Transform[] roomElementsTransformToShowHide = _roomElementsTransformToShowHide;
		if (roomElementsTransformToShowHide.Length >= 1)
		{
			object obj6 = roomElementsTransformToShowHide + 32;
			object obj7 = 0;
			do
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X22_v3+v227 @ X21_v4*8]");
				TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore2 = ShortcutExtensions.DOScale((Transform)0, 1f, 0.4f);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
				obj7++;
			}
			while ((nint)obj7 < roomElementsTransformToShowHide.Length);
		}
	}

	public void HideControls()
	{
		//IL_002e: Invalid comparison between O and F8
		//IL_003f: Expected O, but got I4
		//IL_005c: Invalid comparison between F8 and I4
		//IL_006d: Expected O, but got I4
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected O, but got Unknown
		//IL_00f8: Expected O, but got I4
		//IL_0119: Expected O, but got I
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected O, but got Unknown
		Transform transform = background.transform;
		Vector3 localScale = transform.localScale;
		object obj = default(object);
		bool flag = obj < (object)1.0;
		object obj2 = !flag;
		double num = (double)obj - 1.0;
		bool flag2 = num == 0.0;
		object obj3 = !flag2;
		object obj4 = obj2 & obj3;
		if (obj4 != null)
		{
			return;
		}
		Transform target = background.transform;
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOScale(target, 1.2f, 0.3f);
		Transform[] roomElementsTransformToShowHide = _roomElementsTransformToShowHide;
		if (roomElementsTransformToShowHide.Length >= 1)
		{
			object obj5 = roomElementsTransformToShowHide + 32;
			object obj6 = 0;
			do
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X21_v3+v177 @ X20_v4*8]");
				TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore2 = ShortcutExtensions.DOScale((Transform)0, 0f, 0.4f);
				obj6++;
			}
			while ((nint)obj6 < roomElementsTransformToShowHide.Length);
		}
	}

	private void <RoomThemeChanged>b__13_1(bool success)
	{
		if (success)
		{
			TweenerCore<Color, Color, ColorOptions> tweenerCore = DOTweenModuleUI.DOFade(roomTheme, 1f, 0.3f);
		}
	}

	private void <RoomThemeChanged>b__13_0(SportTeam c)
	{
		sportTeamRoomTheme.SetRoomTheme(c);
		UIExtensions.SetAlpha(roomTheme, 1f);
	}
}
