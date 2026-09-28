using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using Sfs2X.Entities;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.UI;

public class CriteriaSection : MonoBehaviour
{
	[Serializable]
	public class PerformanceCriteria
	{
		public Image Border;

		public TextMeshProUGUI Value;

		public void Setup(PlayerPerformance performance, PlayerPerformanceSprites sprites)
		{
			//IL_004f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0054: Expected O, but got Unknown
			//IL_0061: Expected O, but got I
			Sprite stampBorder = sprites.GetStampBorder(performance);
			Border.sprite = stampBorder;
			Color stampColor = sprites.GetStampColor(performance);
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 1008;
			Value.color = (Color)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			Enum enumeration = default(Enum);
			string friendlyName = EnumExtensions.GetFriendlyName(enumeration);
			TextMeshProExtensions.Localize(Value, friendlyName);
		}

		public void Setup(CheatingPerformance performance, PlayerPerformanceSprites sprites)
		{
			//IL_004f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0054: Expected O, but got Unknown
			//IL_0061: Expected O, but got I
			Sprite stampBorder = sprites.GetStampBorder(performance);
			Border.sprite = stampBorder;
			Color stampColor = sprites.GetStampColor(performance);
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 936;
			Value.color = (Color)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			Enum enumeration = default(Enum);
			string friendlyName = EnumExtensions.GetFriendlyName(enumeration);
			TextMeshProExtensions.Localize(Value, friendlyName);
		}
	}

	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Action<PerformanceCriteria> <>9__8_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(CardUtils.<>c) + 2856;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal void <PrepareCheatAndCatch>b__8_0(PerformanceCriteria c)
		{
			GameObject gameObject = c.Border.gameObject;
			gameObject.SetActive(value: false);
			UIExtensions.SetAlphaChildren(c.Border, 0f);
		}
	}

	private sealed class <>c__DisplayClass10_0
	{
		public CriteriaSection <>4__this;

		public Action callBack;

		internal void <AnimateOverallStamps>b__0()
		{
			CriteriaSection criteriaSection = <>4__this;
			CardGameEndScores gameEnd = criteriaSection.gameEnd;
			SingleSound stampSound = criteriaSection.gameSoundAlbum.GetStampSound(gameEnd.<OverallPerformance>k__BackingField);
			SoundChannel.PlaySFXSound(stampSound);
			Actions.SafeInvoke(callBack);
		}
	}

	private sealed class <>c__DisplayClass9_0
	{
		public CriteriaSection <>4__this;

		public Action callBack;

		public Action <>9__2;

		public Action <>9__1;

		internal void <AnimatePerformanceStamps>b__0()
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected O, but got Unknown
			//IL_00da: Expected O, but got I4
			//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f3: Expected O, but got Unknown
			//IL_0191: Unknown result type (might be due to invalid IL or missing references)
			//IL_0196: Expected O, but got Unknown
			//IL_01ac: Expected O, but got I
			//IL_01b4: Expected I, but got O
			//IL_01c2: Expected I, but got O
			//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ef: Expected O, but got Unknown
			//IL_0219: Expected O, but got I4
			//IL_0127: Unknown result type (might be due to invalid IL or missing references)
			//IL_012c: Expected O, but got Unknown
			CriteriaSection criteriaSection = <>4__this;
			CardGameEndScores gameEnd = criteriaSection.gameEnd;
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 1624;
			SingleSound stampSound = criteriaSection.gameSoundAlbum.GetStampSound(gameEnd.<PlayStylePerformance>k__BackingField);
			SoundChannel.PlaySFXSound(stampSound);
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X0_v6+E4]");
			if ((nint)0 != 0)
			{
				if (Preferences.CurrentGame != Games.Baloot)
				{
					return;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Games currentGame = Preferences.CurrentGame;
				bool flag = currentGame == Games.Baloot;
				object obj3 = !flag;
				if (obj3 != null)
				{
					return;
				}
			}
			object obj4 = this + 40;
			Action action = (Action)obj4;
			Action action3;
			if (obj4 != null)
			{
				object obj5 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
				object obj6 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X0_v8+E4]");
				bool flag2 = (nint)0 == 0;
				nint num = 0;
				Action action2 = null;
				action3 = action;
				if (!flag2)
				{
					goto IL_016f;
				}
			}
			else
			{
				object obj7 = typeof(SqlSingle[]) + 2376;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj8 = (nint)0 + (nint)3976;
				nint num = (nint)obj8;
				Action action4 = default(Action);
				action4..ctor(this, (IntPtr)obj8);
				<>9__1 = action4;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj9 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
				object obj6 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X0_v8+E4]");
				bool flag3 = (nint)0 == 0;
				object obj10 = !flag3;
				action = action4;
				Action action2 = action4;
				action3 = action4;
				if (obj10 != null)
				{
					goto IL_016f;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			action = action3;
			goto IL_016f;
			IL_016f:
			Coroutine coroutine = CoroutineDummy.WaitForSeconds(0.3f, action);
		}

		internal void <AnimatePerformanceStamps>b__1()
		{
			//IL_0059: Unknown result type (might be due to invalid IL or missing references)
			//IL_005e: Expected O, but got Unknown
			//IL_0076: Unknown result type (might be due to invalid IL or missing references)
			//IL_007b: Expected O, but got Unknown
			//IL_012b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0130: Expected O, but got Unknown
			//IL_0146: Expected O, but got I
			//IL_0154: Expected I, but got O
			//IL_0197: Expected O, but got I4
			CriteriaSection criteriaSection = <>4__this;
			PerformanceCriteria cheatAndCatch = criteriaSection.CheatAndCatch;
			CardGameEndScores gameEnd = criteriaSection.gameEnd;
			float strength = CheatingPerformanceExtensions.GetStrength(gameEnd.<CheatingPerformance>k__BackingField);
			CriteriaSection criteriaSection2 = <>4__this;
			object obj = typeof(SqlSingle[]) + 3912;
			RectTransform target = UIExtensions.rectTransform(criteriaSection2.stampsTarget);
			object obj2 = this + 32;
			Action action = (Action)obj2;
			Action action2;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X0_v7+E4]");
				bool flag = (nint)0 == 0;
				action2 = action;
				Action action3 = null;
				if (!flag)
				{
					goto IL_00da;
				}
			}
			else
			{
				object obj4 = typeof(SqlSingle[]) + 2376;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj5 = (nint)0 + (nint)3984;
				Action action4 = default(Action);
				action4..ctor(this, (IntPtr)obj5);
				<>9__2 = action4;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X0_v7+E4]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				action = action4;
				action2 = action4;
				Action action3 = action4;
				if (obj6 != null)
				{
					goto IL_00da;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			action = action2;
			goto IL_00da;
			IL_00da:
			float rotation = strength + strength;
			AnimationExtensions.DOStamp(cheatAndCatch.Border, 0.3f, 40f, rotation, 3f, 0f, target, action);
		}

		internal void <AnimatePerformanceStamps>b__2()
		{
			CriteriaSection criteriaSection = <>4__this;
			CardGameEndScores gameEnd = criteriaSection.gameEnd;
			SingleSound stampSound = criteriaSection.gameSoundAlbum.GetStampSound(gameEnd.<CheatingPerformance>k__BackingField);
			SoundChannel.PlaySFXSound(stampSound);
			Actions.SafeInvoke(callBack);
		}
	}

	public PerformanceCriteria PlayAndBid;

	public PerformanceCriteria CheatAndCatch;

	public Image OverallPerformance;

	public Image cheatAndCatchIcon;

	public PopupUI stampsTarget;

	private PlayerPerformanceSprites performanceSprites;

	private GameSoundAlbum gameSoundAlbum;

	private CardGameEndScores gameEnd;

	public void PrepareCheatAndCatch(CardGame game)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_07c9: Expected O, but got I4
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
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Expected O, but got Unknown
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Expected O, but got Unknown
		//IL_02ce: Expected O, but got I
		//IL_02de: Expected O, but got I
		//IL_02ee: Expected O, but got I
		//IL_0310: Expected O, but got I4
		//IL_0328: Expected O, but got I
		//IL_025a: Expected I, but got O
		//IL_028d: Expected O, but got I4
		//IL_01f5: Expected O, but got I
		//IL_0205: Expected O, but got I
		//IL_0215: Expected O, but got I
		//IL_0244: Expected O, but got I
		//IL_0358: Expected O, but got I4
		//IL_02ab: Expected I, but got O
		//IL_07fb: Expected O, but got I
		//IL_080c: Expected I, but got O
		//IL_082a: Expected O, but got I
		//IL_0456: Expected I, but got O
		//IL_0395: Expected I, but got O
		//IL_03c6: Expected O, but got I4
		//IL_03cf: Expected O, but got I4
		//IL_03d7: Expected I, but got O
		//IL_0388: Expected O, but got I
		//IL_04f8: Expected I, but got O
		//IL_052c: Expected I, but got O
		//IL_085d: Expected I, but got O
		//IL_0564: Expected O, but got I4
		//IL_0573: Unknown result type (might be due to invalid IL or missing references)
		//IL_0578: Expected O, but got Unknown
		//IL_0888: Expected O, but got I
		//IL_08a8: Expected O, but got I
		//IL_08b6: Expected O, but got I4
		//IL_08d3: Expected O, but got I
		//IL_08ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f2: Expected O, but got Unknown
		//IL_0908: Expected O, but got I
		//IL_0916: Expected O, but got I4
		//IL_0946: Expected I, but got O
		//IL_05b3: Expected I, but got O
		//IL_05ce: Expected I, but got O
		//IL_05de: Expected O, but got I
		//IL_05ee: Expected O, but got I
		//IL_061f: Expected O, but got I4
		//IL_0628: Expected O, but got I4
		//IL_0631: Expected O, but got I4
		//IL_063e: Expected I, but got O
		//IL_0683: Expected O, but got I4
		//IL_068c: Expected O, but got I4
		//IL_0695: Expected O, but got I4
		//IL_06a2: Expected I, but got O
		//IL_06b8: Expected I, but got O
		//IL_06c8: Expected O, but got I
		//IL_06d8: Expected O, but got I
		//IL_0709: Expected O, but got I4
		//IL_0712: Expected O, but got I4
		//IL_071b: Expected O, but got I4
		//IL_0728: Expected I, but got O
		//IL_0740: Unknown result type (might be due to invalid IL or missing references)
		//IL_0745: Expected O, but got Unknown
		object obj = typeof(SqlSingle[]) + 920;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		IEnumerable<object> enumerable = default(IEnumerable<object>);
		bool flag = enumerable == null;
		Action<object> action = (Action<object>)2;
		if (flag)
		{
			goto IL_076d;
		}
		bool flag2 = PlayAndBid == null;
		action = (Action<object>)2;
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		Action<object> action2;
		if (!flag2)
		{
			nint num = (nint)enumerable;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X8_v55 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+40]");
			action = (Action<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
			bool flag3 = ex == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X8_v55 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+40]");
			action2 = (Action<object>)0;
			if (flag3)
			{
				goto IL_0791;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3 (System.Collections.Generic.IEnumerable`1<System.Object>)+18]");
		object obj7;
		nint num3;
		Component overallPerformance;
		object obj16;
		object obj17 = default(object);
		nint num4;
		if ((nint)0 != 0)
		{
			object obj2 = enumerable + 32;
			obj2 = PlayAndBid;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			bool flag4 = CheatAndCatch == null;
			action = (Action<object>)(object)PlayAndBid;
			if (!flag4)
			{
				nint num2 = (nint)enumerable;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X8_v54 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+40]");
				action = (Action<object>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag5 = ex == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X8_v54 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+40]");
				action2 = (Action<object>)0;
				if (flag5)
				{
					goto IL_0791;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3 (System.Collections.Generic.IEnumerable`1<System.Object>)+18]");
			object obj3 = 0 & 0xFFFFFFFEL;
			if (obj3 != null)
			{
				object obj4 = typeof(CardUtils.<>c) + 2856;
				object obj5 = enumerable + 40;
				obj5 = CheatAndCatch;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj6 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X0_v51+E4]");
				object obj8;
				object obj9;
				if ((nint)0 != 0)
				{
					obj7 = (nint)0 + (nint)2432;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X0_v51+B8]");
					obj8 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ X8_v43+8]");
					action = (Action<object>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ X8_v43+8]");
					bool flag6 = (nint)0 == 0;
					obj9 = obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ X8_v43+8]");
					Action<object> action3 = (Action<object>)0;
					if (!flag6)
					{
						goto IL_0252;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj6 = obj4;
					obj7 = (nint)0 + (nint)2432;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X0_v51+B8]");
					obj8 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ X8_v43+8]");
					action = (Action<object>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ X8_v43+8]");
					bool flag7 = (nint)0 == 0;
					object obj10 = !flag7;
					obj9 = obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ X8_v43+8]");
					Action<object> action3 = (Action<object>)0;
					if (obj10 != null)
					{
						goto IL_0252;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X0_v51+E4]");
				bool flag8 = (nint)0 == 0;
				object obj11 = !flag8;
				if (obj11 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj12 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v348 @ X8_v49+B8]");
					obj8 = 0;
				}
				object typeFromHandle = typeof(Action<PerformanceCriteria>);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj13 = (nint)0 + (nint)3952;
				Action<object> action4 = default(Action<object>);
				action4..ctor(obj8, (IntPtr)obj13);
				object obj14 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X8_v48+B8]");
				object obj15 = (nint)0 + (nint)8;
				obj15 = action4;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				num3 = (nint)obj9;
				ArraysExtensions.ForEach(enumerable, action4);
				overallPerformance = OverallPerformance;
				bool flag9 = (object)OverallPerformance == null;
				obj16 = 0;
				obj17 = 0;
				num4 = (nint)obj9;
				action = action4;
				if (!flag9)
				{
					goto IL_03ed;
				}
				goto IL_076d;
			}
		}
		goto IL_077b;
		IL_0252:
		num3 = (nint)obj7;
		ArraysExtensions.ForEach(enumerable, action);
		overallPerformance = OverallPerformance;
		bool flag10 = (object)OverallPerformance == null;
		object obj18 = !flag10;
		obj16 = obj17;
		if (obj18 != null)
		{
			goto IL_03ed;
		}
		num4 = (nint)obj7;
		goto IL_076d;
		IL_0791:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
		IL_076d:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_077b;
		IL_03ed:
		GameObject gameObject = overallPerformance.gameObject;
		bool flag11 = (object)gameObject == null;
		obj17 = obj16;
		num4 = num3;
		action = null;
		if (!flag11)
		{
			gameObject.SetActive(value: false);
			bool flag12 = (object)game == null;
			obj17 = obj16;
			num4 = unchecked((nint)null);
			action = null;
			if (!flag12)
			{
				Room room = game.Room;
				if (room == null)
				{
					return;
				}
				Room room2 = game.Room;
				if (SFSKammelnaRoomExtensions.IsCheatingAllowed(room2))
				{
					return;
				}
				PerformanceCriteria cheatAndCatch = CheatAndCatch;
				bool flag13 = CheatAndCatch == null;
				obj17 = obj16;
				num4 = unchecked((nint)null);
				action = null;
				if (!flag13)
				{
					bool flag14 = (object)cheatAndCatch.Border == null;
					obj17 = obj16;
					num4 = unchecked((nint)null);
					action = null;
					if (!flag14)
					{
						RectTransform rectTransform = cheatAndCatch.Border.rectTransform;
						bool flag15 = (object)rectTransform == null;
						obj17 = obj16;
						num4 = unchecked((nint)null);
						action = null;
						if (!flag15)
						{
							rectTransform.anchoredPosition = (Vector2)0;
							object obj19 = typeof(UsageHint) + 816;
							object obj20 = obj19;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v396 @ X8_v21+B8]");
							object obj21 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v397 @ X8_v22+50]");
							object obj22 = (nint)0 * (nint)1114636288;
							rectTransform.localEulerAngles = (Vector3)0;
							object obj23 = obj19;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X8_v26+B8]");
							object obj24 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ X8_v27+C]");
							object obj25 = 0 * obj22;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ X8_v27+14]");
							object obj26 = (nint)0 * (nint)1068289229;
							rectTransform.localScale = (Vector3)0;
							PerformanceCriteria cheatAndCatch2 = CheatAndCatch;
							bool flag16 = CheatAndCatch == null;
							object obj28 = default(object);
							object obj27 = obj28;
							obj17 = obj16;
							num4 = unchecked((nint)null);
							action = null;
							if (!flag16)
							{
								Image border = cheatAndCatch2.Border;
								bool flag17 = (object)cheatAndCatch2.Border == null;
								obj27 = obj28;
								obj17 = obj16;
								num4 = unchecked((nint)null);
								action = null;
								if (!flag17)
								{
									nint num5 = (nint)border;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ X8_v31 (Il2CppClass<UnityEngine.UI.Image>)+2B0]");
									action = (Action<object>)0;
									cheatAndCatch2.Border.color = (Color)0;
									PerformanceCriteria cheatAndCatch3 = CheatAndCatch;
									bool flag18 = CheatAndCatch == null;
									double num6 = 1.0;
									obj26 = 0;
									obj27 = 0;
									obj25 = 0;
									obj17 = obj16;
									num4 = unchecked((nint)null);
									if (!flag18)
									{
										TextMeshProUGUI value = cheatAndCatch3.Value;
										bool flag19 = (object)cheatAndCatch3.Value == null;
										num6 = 1.0;
										obj26 = 0;
										obj27 = 0;
										obj25 = 0;
										obj17 = obj16;
										num4 = unchecked((nint)null);
										if (!flag19)
										{
											nint num7 = (nint)value;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v426 @ X8_v33 (Il2CppClass<TMPro.TextMeshProUGUI>)+2B0]");
											action = (Action<object>)0;
											cheatAndCatch3.Value.color = (Color)0;
											PerformanceCriteria cheatAndCatch4 = CheatAndCatch;
											bool flag20 = CheatAndCatch == null;
											num6 = 1.0;
											obj26 = 0;
											obj27 = 0;
											obj25 = 0;
											obj17 = obj16;
											num4 = unchecked((nint)null);
											if (!flag20)
											{
												object text = "not" + 32;
												TextMeshProExtensions.Localize(cheatAndCatch4.Value, (string)text);
												UIExtensions.SetAlpha(cheatAndCatchIcon, 0.275f);
												return;
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}
		goto IL_076d;
		IL_077b:
		ex = new IndexOutOfRangeException();
		action2 = action;
		goto IL_0791;
	}

	public void AnimatePerformanceStamps(Action callBack = null)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_00a8: Expected O, but got I4
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		//IL_0155: Expected O, but got I
		//IL_0165: Expected O, but got I
		//IL_0175: Expected O, but got I
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Expected O, but got Unknown
		//IL_0223: Expected O, but got I
		//IL_0234: Expected I, but got O
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_024d: Expected O, but got Unknown
		//IL_0277: Expected O, but got I4
		object obj = typeof(CardUtils.<>c) + 2872;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = obj2 + 24;
		obj4 = callBack;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		PerformanceCriteria playAndBid = PlayAndBid;
		GameObject gameObject = playAndBid.Border.gameObject;
		bool activeSelf = gameObject.activeSelf;
		bool flag = !activeSelf;
		object obj5 = !flag;
		if (obj5 == null)
		{
			object obj6 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X0_v16+E4]");
			if ((nint)0 != 0)
			{
				Games currentGame = Preferences.CurrentGame;
				if (currentGame == Games.Jackaroo)
				{
					goto IL_0120;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Games currentGame2 = Preferences.CurrentGame;
				if (currentGame2 == Games.Jackaroo)
				{
					goto IL_0120;
				}
			}
			PerformanceCriteria playAndBid2 = PlayAndBid;
			CardGameEndScores cardGameEndScores = gameEnd;
			float strength = PlayerPerformanceExtensions.GetStrength(cardGameEndScores.<PlayStylePerformance>k__BackingField);
			RectTransform target = UIExtensions.rectTransform(stampsTarget);
			object obj8 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj9 = (nint)0 + (nint)3968;
			Action action = default(Action);
			action..ctor(obj2, (IntPtr)obj9);
			object obj10 = typeof(SqlSingle[]) + 3912;
			object obj11 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X0_v23+E4]");
			bool flag2 = (nint)0 == 0;
			object obj12 = !flag2;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			float rotation = strength + strength;
			AnimationExtensions.DOStamp(playAndBid2.Border, 0.3f, 40f, rotation, 3f, 0f, target, action);
			return;
		}
		goto IL_0120;
		IL_0120:
		object obj13 = obj4;
		if (obj4 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X8_v6+18]");
			object obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X8_v6+40]");
			object obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X8_v6+28]");
			object obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v149 @ X2_v1 (should have been resolved before IL gen)");
		}
	}

	public void AnimateOverallStamps(Action callBack = null)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_0096: Expected O, but got I4
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected O, but got Unknown
		//IL_0143: Expected O, but got I
		//IL_0153: Expected O, but got I
		//IL_0163: Expected O, but got I
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Expected O, but got Unknown
		//IL_01e1: Expected O, but got I
		//IL_01f2: Expected I, but got O
		//IL_0201: Unknown result type (might be due to invalid IL or missing references)
		//IL_0206: Expected O, but got Unknown
		//IL_0230: Expected O, but got I4
		object obj = typeof(CardUtils.<>c) + 2864;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = obj2 + 24;
		obj4 = callBack;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		GameObject gameObject = OverallPerformance.gameObject;
		bool activeSelf = gameObject.activeSelf;
		bool flag = !activeSelf;
		object obj5 = !flag;
		if (obj5 == null)
		{
			object obj6 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X0_v16+E4]");
			if ((nint)0 != 0)
			{
				Games currentGame = Preferences.CurrentGame;
				if (currentGame == Games.Jackaroo)
				{
					goto IL_010e;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Games currentGame2 = Preferences.CurrentGame;
				if (currentGame2 == Games.Jackaroo)
				{
					goto IL_010e;
				}
			}
			RectTransform target = UIExtensions.rectTransform(stampsTarget);
			object obj8 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj9 = (nint)0 + (nint)3960;
			Action action = default(Action);
			action..ctor(obj2, (IntPtr)obj9);
			object obj10 = typeof(SqlSingle[]) + 3912;
			object obj11 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X0_v22+E4]");
			bool flag2 = (nint)0 == 0;
			object obj12 = !flag2;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			AnimationExtensions.DOStamp(OverallPerformance, 0.3f, 40f, 0f, 3f, 0.3f, target, action);
			return;
		}
		goto IL_010e;
		IL_010e:
		object obj13 = obj4;
		if (obj4 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v4+18]");
			object obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v4+40]");
			object obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v4+28]");
			object obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v98 @ X2_v1 (should have been resolved before IL gen)");
		}
	}

	public void InitPerformanceVars(CardGameEndScores scores)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_004d: Expected O, but got I
		object obj = this + 88;
		obj = scores;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ X20_v2-38]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ X8_v1+3C]");
		((PerformanceCriteria)num).Setup(PlayerPerformance.Weak, performanceSprites);
		CardGameEndScores cardGameEndScores = gameEnd;
		CheatAndCatch.Setup(cardGameEndScores.<CheatingPerformance>k__BackingField, performanceSprites);
		CardGameEndScores cardGameEndScores2 = gameEnd;
		Sprite overallPerformanceBadge = performanceSprites.GetOverallPerformanceBadge(cardGameEndScores2.<OverallPerformance>k__BackingField);
		OverallPerformance.sprite = overallPerformanceBadge;
	}

	private void PlayStampSound(PlayerPerformance stampLevel)
	{
		SingleSound stampSound = gameSoundAlbum.GetStampSound(stampLevel);
		SoundChannel.PlaySFXSound(stampSound);
	}

	private void PlayStampSound(CheatingPerformance stampLevel)
	{
		SingleSound stampSound = gameSoundAlbum.GetStampSound(stampLevel);
		SoundChannel.PlaySFXSound(stampSound);
	}
}
