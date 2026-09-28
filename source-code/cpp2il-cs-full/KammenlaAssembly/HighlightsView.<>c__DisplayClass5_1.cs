using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DG.Tweening;
using Features.GameReplay;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server.Models.Clans;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.Rendering;
using UnityEngine.TextCore;
using UnityEngine.UI;

public class HighlightsView : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<HighlightsItem, bool> <>9__5_0;

		public static Action<HighlightsItem> <>9__6_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 1392;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal bool <AnimateHighlights>b__5_0(HighlightsItem item)
		{
			//IL_0067: Expected I4, but got O
			if ((object)item != null)
			{
				GameObject gameObject = item.gameObject;
				if ((object)gameObject != null)
				{
					return gameObject.activeSelf;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal void <ResetHighlights>b__6_0(HighlightsItem item)
		{
			GameObject gameObject = item.gameObject;
			gameObject.SetActive(value: false);
		}
	}

	private sealed class <>c__DisplayClass5_0
	{
		public RectTransform rect;

		public HighlightsView <>4__this;

		public Action <>9__3;

		internal void <AnimateHighlights>b__3()
		{
			//IL_0011: Expected O, but got I
			HighlightsView highlightsView = <>4__this;
			object obj = (nint)0 + (nint)2408;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CFF124");
			SingleSound singleSound = default(SingleSound);
			SoundChannel.PlaySFXSound(singleSound);
		}
	}

	private sealed class <>c__DisplayClass5_1
	{
		public HighlightsItem item;

		public <>c__DisplayClass5_0 CS$<>8__locals1;

		internal void <AnimateHighlights>b__1()
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Expected O, but got Unknown
			//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d3: Expected O, but got Unknown
			//IL_00e9: Expected O, but got I
			//IL_00fc: Expected I, but got O
			//IL_013a: Expected O, but got I4
			//IL_00be: Expected O, but got I
			HighlightsItem highlightsItem = item;
			object obj = typeof(SqlSingle[]) + 3912;
			object obj2 = CS$<>8__locals1 + 32;
			Action action = (Action)obj2;
			Action action2;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X0_v3+E4]");
				bool flag = (nint)0 == 0;
				action2 = action;
				if (!flag)
				{
					goto IL_0083;
				}
			}
			else
			{
				object obj4 = typeof(SqlSingle[]) + 2376;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj5 = (nint)0 + (nint)3360;
				Action action3 = default(Action);
				action3..ctor(CS$<>8__locals1, (IntPtr)obj5);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X0_v3+E4]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				action = action3;
				action2 = action3;
				if (obj6 != null)
				{
					goto IL_0083;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			action = action2;
			goto IL_0083;
			IL_0083:
			Image highlightsDeep = highlightsItem.highlightsDeep;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X23_v2-10]");
			AnimationExtensions.DOStamp(highlightsDeep, 0.3f, 40f, 0f, 3f, 0.3f, (RectTransform)0, action);
		}

		internal void <AnimateHighlights>b__2()
		{
			//IL_0011: Expected O, but got I
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_0037: Expected O, but got Unknown
			//IL_0063: Expected O, but got I
			//IL_0096: Expected O, but got I4
			HighlightsItem highlightsItem = item;
			object obj = (nint)0 + (nint)2944;
			RectTransform rectTransform = highlightsItem.highlightSticker.rectTransform;
			object obj2 = typeof(UsageHint) + 816;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X8_v6+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X8_v7+C]");
			float duration = 0f * 0f;
			float elasticity = default(float);
			Tweener tweener = ShortcutExtensions.DOPunchScale(rectTransform, (Vector3)2, duration, 0, elasticity);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		}
	}

	public HighlightsItem[] highlights;

	private GameSoundAlbum gameSoundAlbum;

	public PopupUI stampsTarget;

	public void InitializeHighlights(CardGame game, CardGameEndScores endGame)
	{
		//IL_0010: Expected O, but got I
		//IL_0993: Expected O, but got I4
		//IL_09a4: Expected O, but got I4
		//IL_0800: Expected O, but got I4
		//IL_0840: Expected O, but got I
		//IL_0877: Expected I4, but got O
		//IL_0827: Expected I4, but got O
		//IL_0050: Expected O, but got I
		//IL_0084: Expected O, but got I4
		//IL_00cb: Expected O, but got I4
		//IL_00d4: Expected O, but got I4
		//IL_0122: Expected O, but got I4
		//IL_0915: Expected O, but got I
		//IL_091d: Expected I4, but got O
		//IL_06ef: Expected O, but got I
		//IL_0149: Expected O, but got I
		//IL_0184: Expected O, but got I4
		//IL_047f: Expected O, but got I
		//IL_048e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0493: Expected O, but got Unknown
		//IL_0a01: Expected I4, but got O
		//IL_01d6: Expected O, but got I
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Expected O, but got Unknown
		//IL_01fb: Expected O, but got I4
		//IL_09c7: Expected I4, but got O
		//IL_04df: Expected I, but got O
		//IL_04ef: Expected O, but got I
		//IL_0528: Expected I4, but got O
		//IL_023f: Expected I, but got O
		//IL_024f: Expected O, but got I
		//IL_0288: Expected I4, but got O
		//IL_056d: Expected I, but got O
		//IL_058f: Expected O, but got I4
		//IL_05d3: Expected O, but got I4
		//IL_02ee: Expected O, but got I4
		//IL_0332: Expected O, but got I4
		//IL_0605: Expected O, but got I4
		//IL_039d: Expected O, but got I4
		//IL_03f2: Expected O, but got I
		//IL_0458: Expected O, but got I
		//IL_0461: Unknown result type (might be due to invalid IL or missing references)
		//IL_0466: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E67CB]");
		CardGameHighlights cardGameHighlights = (CardGameHighlights)0;
		bool flag = endGame == null;
		CardGameEndScores cardGameEndScores = endGame;
		Dictionary<object, int>.KeyCollection.Enumerator enumerator = (Dictionary<object, int>.KeyCollection.Enumerator)0;
		CardGame cardGame = game;
		Dictionary<object, int> dictionary = (Dictionary<object, int>)152985600;
		HighlightsView highlightsView = this;
		CardGame cardGame2 = game;
		CardGame cardGame3 = default(CardGame);
		CardGameEndScores cardGameEndScores2;
		CardGame cardGame4;
		Dictionary<object, int>.KeyCollection.Enumerator enumerator3 = default(Dictionary<object, int>.KeyCollection.Enumerator);
		int num3;
		int num;
		Dictionary<object, int>.KeyCollection.Enumerator enumerator4;
		Dictionary<object, int> dictionary2;
		if (!flag)
		{
			CardGameHighlights <CGHighlights>k__BackingField = endGame.<CGHighlights>k__BackingField;
			if (endGame.<CGHighlights>k__BackingField == null)
			{
				return;
			}
			object obj = (nint)0 + (nint)2488;
			cardGame = (CardGame)obj;
			bool flag2 = ArraysExtensions.IsNullOrEmpty((IEnumerable<KeyValuePair<object, int>>)<CGHighlights>k__BackingField.<Highlights>k__BackingField);
			bool flag3 = !flag2;
			object obj2 = !flag3;
			if (obj2 != null)
			{
				return;
			}
			ResetHighlights();
			cardGameHighlights = endGame.<CGHighlights>k__BackingField;
			bool flag4 = endGame.<CGHighlights>k__BackingField == null;
			cardGameEndScores = endGame;
			enumerator = (Dictionary<object, int>.KeyCollection.Enumerator)0;
			dictionary = (Dictionary<object, int>)152985600;
			highlightsView = this;
			cardGame2 = game;
			if (!flag4)
			{
				dictionary = (Dictionary<object, int>)(object)cardGameHighlights.<Highlights>k__BackingField;
				bool flag5 = cardGameHighlights.<Highlights>k__BackingField == null;
				cardGameEndScores = endGame;
				enumerator = (Dictionary<object, int>.KeyCollection.Enumerator)0;
				highlightsView = this;
				cardGame2 = game;
				if (!flag5)
				{
					cardGameHighlights = (CardGameHighlights)((nint)0 + (nint)3344);
					cardGame = (CardGame)(object)cardGameHighlights;
					Dictionary<object, int>.KeyCollection keys = ((Dictionary<object, int>)(object)cardGameHighlights.<Highlights>k__BackingField).Keys;
					bool flag6 = keys == null;
					cardGameEndScores = endGame;
					enumerator = (Dictionary<object, int>.KeyCollection.Enumerator)0;
					highlightsView = this;
					cardGame2 = game;
					if (!flag6)
					{
						Dictionary<object, int>.KeyCollection.Enumerator enumerator2 = keys.GetEnumerator();
						if ((object)game != null)
						{
							object obj3 = (nint)0 + (nint)2808;
							object obj4 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
							cardGameEndScores = endGame;
							object obj5 = 0;
							while (true)
							{
								num = (int)obj3;
								bool flag7 = enumerator.MoveNext();
								bool flag8 = !flag7;
								cardGame2 = game;
								if (flag8)
								{
									break;
								}
								CardGameHighlights <CGHighlights>k__BackingField2 = endGame.<CGHighlights>k__BackingField;
								bool flag9 = endGame.<CGHighlights>k__BackingField == null;
								cardGame2 = game;
								if (flag9)
								{
									goto IL_0776;
								}
								nint num2 = (nint)<CGHighlights>k__BackingField2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v600 @ X8_v38 (Il2CppClass<CardGameHighlights>)+190]");
								cardGameEndScores = (CardGameEndScores)0;
								string highlightsName = endGame.<CGHighlights>k__BackingField.GetHighlightsName((string)(object)cardGame3);
								HighlightsItem[] array = highlights;
								bool flag10 = highlights == null;
								num = (int)cardGame3;
								cardGame2 = game;
								if (flag10)
								{
									goto IL_079f;
								}
								bool flag11 = (nint)obj5 == array.Length;
								cardGame2 = game;
								if (flag11)
								{
									break;
								}
								object obj6 = obj4;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v608 @ X0_v59+E4]");
								bool flag12 = (nint)0 == 0;
								object obj7 = !flag12;
								if (obj7 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								bool flag13 = StringsExtensions.IsNullOrEmpty(highlightsName);
								bool flag14 = !flag13;
								object obj8 = !flag14;
								if (obj8 != null)
								{
									continue;
								}
								HighlightsItem[] array2 = highlights;
								bool flag15 = highlights == null;
								cardGameEndScores2 = cardGameEndScores;
								num = 0;
								cardGame4 = game;
								if (flag15)
								{
									goto IL_0666;
								}
								bool flag16 = (nint)obj5 < array2.Length;
								object obj9 = !flag16;
								enumerator = enumerator3;
								enumerator4 = enumerator3;
								dictionary2 = null;
								cardGame = null;
								highlightsView = this;
								cardGame2 = game;
								if (obj9 != null)
								{
									goto IL_080e;
								}
								object obj10 = (object)highlights + obj5;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v627 @ X8_v43+20]");
								HighlightsItem highlightsItem = (HighlightsItem)0;
								num3 = dictionary.get_Item((object)cardGame3);
								KPlayer playerByIndex = game.GetPlayerByIndex(num3);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v627 @ X8_v43+20]");
								if ((nint)0 != 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v627 @ X8_v43+20]");
									((HighlightsItem)0).SetUp(highlightsName, playerByIndex);
									obj5++;
									cardGameEndScores = (CardGameEndScores)(object)playerByIndex;
									continue;
								}
								goto IL_087c;
							}
						}
						else
						{
							object obj11 = (nint)0 + (nint)2808;
							HighlightsItem highlightsItem = (HighlightsItem)(typeof(System.Formats.Asn1.SetOfValueComparer) + 2536);
							cardGameEndScores = endGame;
							cardGame2 = game;
							while (true)
							{
								num = (int)obj11;
								if (!enumerator.MoveNext())
								{
									break;
								}
								CardGameHighlights <CGHighlights>k__BackingField3 = endGame.<CGHighlights>k__BackingField;
								if (endGame.<CGHighlights>k__BackingField == null)
								{
									goto IL_0776;
								}
								nint num4 = (nint)<CGHighlights>k__BackingField3;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v603 @ X8_v32 (Il2CppClass<CardGameHighlights>)+190]");
								cardGameEndScores = (CardGameEndScores)0;
								string highlightsName2 = endGame.<CGHighlights>k__BackingField.GetHighlightsName((string)(object)cardGame3);
								HighlightsItem[] array3 = highlights;
								bool flag17 = highlights == null;
								num = (int)cardGame3;
								cardGame2 = cardGame3;
								if (!flag17)
								{
									bool flag18 = array3.Length == 0;
									cardGame2 = cardGame3;
									if (flag18)
									{
										break;
									}
									nint num5 = (nint)highlightsItem;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v611 @ X0_v49 (Il2CppClass<HighlightsItem>)+E4]");
									bool flag19 = (nint)0 == 0;
									object obj12 = !flag19;
									if (obj12 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									bool flag20 = StringsExtensions.IsNullOrEmpty(highlightsName2);
									bool flag21 = !flag20;
									object obj13 = !flag21;
									cardGame2 = cardGame3;
									if (obj13 != null)
									{
										continue;
									}
									goto IL_05e9;
								}
								goto IL_079f;
							}
						}
						enumerator.Dispose();
						enumerator = enumerator3;
						enumerator4 = enumerator3;
						dictionary2 = null;
						highlightsView = this;
						goto IL_06c9;
					}
				}
			}
		}
		goto IL_07c8;
		IL_06c9:
		GameObject gameObject = highlightsView.gameObject;
		cardGameHighlights = endGame.<CGHighlights>k__BackingField;
		object obj14 = (nint)0 + (nint)2488;
		bool flag22 = endGame.<CGHighlights>k__BackingField == null;
		cardGame = null;
		if (!flag22)
		{
			cardGame = (CardGame)obj14;
			bool flag23 = ArraysExtensions.IsNullOrEmpty((IEnumerable<KeyValuePair<object, int>>)cardGameHighlights.<Highlights>k__BackingField);
			bool flag24 = (object)gameObject == null;
			highlightsView = (HighlightsView)(object)gameObject;
			if (!flag24)
			{
				bool active = (byte)((flag23 ? 1u : 0u) ^ 1u) != 0;
				gameObject.SetActive(active);
				return;
			}
		}
		goto IL_07c8;
		IL_087c:
		NullReferenceException ex = new NullReferenceException();
		cardGameEndScores = null;
		Dictionary<object, int>.KeyCollection.Enumerator enumerator5 = enumerator3;
		enumerator4 = enumerator3;
		dictionary2 = null;
		num = num3;
		highlightsView = this;
		cardGame2 = game;
		goto IL_08c0;
		IL_080e:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		enumerator5 = enumerator;
		num = (int)cardGame;
		ex = (NullReferenceException)(object)ex2;
		goto IL_08c0;
		IL_08c0:
		bool flag25 = num != 1;
		NullReferenceException ex3 = ex;
		if (!flag25)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			object obj15 = default(object);
			dictionary = (Dictionary<object, int>)obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			object obj16 = (nint)0 + (nint)2800;
			num = (int)obj16;
			enumerator5.Dispose();
			bool flag26 = obj15 == null;
			enumerator = enumerator5;
			dictionary2 = (Dictionary<object, int>)obj15;
			if (flag26)
			{
				goto IL_06c9;
			}
			OutOfMemoryException ex4 = new OutOfMemoryException();
			dictionary2 = (Dictionary<object, int>)obj15;
			ex3 = (NullReferenceException)(object)ex4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22384D4");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return;
		IL_05e9:
		bool flag27 = highlights == null;
		object obj17 = !flag27;
		cardGameEndScores2 = cardGameEndScores;
		num = 0;
		cardGame4 = cardGame3;
		enumerator = enumerator3;
		enumerator4 = enumerator3;
		dictionary2 = null;
		cardGame = null;
		cardGameHighlights = (CardGameHighlights)(object)highlights;
		Dictionary<object, int> dictionary3 = dictionary;
		highlightsView = this;
		cardGame2 = cardGame3;
		if (obj17 == null)
		{
			goto IL_0666;
		}
		goto IL_07de;
		IL_07de:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X8_v8 (CardGameHighlights)+18]");
		bool flag28 = (nint)0 == 0;
		object obj18 = !flag28;
		if (obj18 == null)
		{
			goto IL_080e;
		}
		object obj19 = (nint)0 + (nint)3336;
		cardGameEndScores = (CardGameEndScores)obj19;
		int num6 = dictionary3.get_Item((object)cardGame2);
		ex = new NullReferenceException();
		enumerator5 = enumerator;
		num = (int)cardGame2;
		goto IL_08c0;
		IL_0776:
		ex = new NullReferenceException();
		enumerator5 = enumerator3;
		enumerator4 = enumerator3;
		dictionary2 = null;
		highlightsView = this;
		goto IL_08c0;
		IL_079f:
		ex = new NullReferenceException();
		enumerator5 = enumerator3;
		enumerator4 = enumerator3;
		dictionary2 = null;
		highlightsView = this;
		goto IL_08c0;
		IL_0666:
		ex = new NullReferenceException();
		cardGameEndScores = cardGameEndScores2;
		enumerator5 = enumerator3;
		enumerator4 = enumerator3;
		dictionary2 = null;
		highlightsView = this;
		cardGame2 = cardGame4;
		goto IL_08c0;
		IL_07c8:
		NullReferenceException ex5 = new NullReferenceException();
		dictionary3 = dictionary;
		goto IL_07de;
	}

	public Sequence AnimateHighlights(CardGame game, CardGameEndScores endGame)
	{
		InitializeHighlights(game, endGame);
		return AnimateHighlights();
	}

	public unsafe Sequence AnimateHighlights()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0071: Expected O, but got I4
		//IL_0098: Expected O, but got I
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Expected O, but got Unknown
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_00f6: Expected O, but got I4
		//IL_0304: Expected O, but got I4
		//IL_0172: Expected O, but got I
		//IL_0379: Expected O, but got I4
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Expected O, but got Unknown
		//IL_03b7: Expected O, but got I
		//IL_03d7: Expected O, but got I
		//IL_03f9: Expected O, but got I4
		//IL_01e7: Expected O, but got I
		//IL_0207: Expected O, but got I
		//IL_0229: Expected O, but got I4
		//IL_04ca: Expected O, but got I
		//IL_0427: Expected O, but got I
		//IL_0449: Expected O, but got I4
		//IL_0550: Expected O, but got I
		//IL_0ecd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ed2: Expected O, but got Unknown
		//IL_0ee8: Expected O, but got I
		//IL_0ef9: Expected I, but got O
		//IL_0ef9: Expected O, but got I
		//IL_0f01: Expected I, but got O
		//IL_0f17: Expected O, but got I
		//IL_0f32: Expected O, but got I4
		//IL_057d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0582: Expected O, but got Unknown
		//IL_058a: Expected I, but got O
		//IL_059a: Expected O, but got I
		//IL_066d: Expected O, but got I4
		//IL_0f98: Expected O, but got I
		//IL_0fb1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fb6: Expected O, but got Unknown
		//IL_0fc5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fca: Expected O, but got Unknown
		//IL_0fd6: Expected O, but got I
		//IL_0fe2: Expected O, but got I
		//IL_05d5: Expected O, but got I
		//IL_0f5a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f5f: Expected O, but got Unknown
		//IL_0682: Unknown result type (might be due to invalid IL or missing references)
		//IL_0687: Expected O, but got Unknown
		//IL_0690: Unknown result type (might be due to invalid IL or missing references)
		//IL_0695: Expected O, but got Unknown
		//IL_0de0: Expected O, but got I4
		//IL_06b2: Expected I, but got O
		//IL_06c2: Expected O, but got I
		//IL_05eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f0: Expected O, but got Unknown
		//IL_0606: Expected O, but got I
		//IL_0611: Unknown result type (might be due to invalid IL or missing references)
		//IL_0616: Expected O, but got Unknown
		//IL_0795: Expected O, but got I4
		//IL_1040: Expected I, but got O
		//IL_1050: Expected O, but got I
		//IL_1063: Unknown result type (might be due to invalid IL or missing references)
		//IL_1068: Expected O, but got Unknown
		//IL_06fd: Expected O, but got I
		//IL_0bfe: Expected O, but got I4
		//IL_0c0f: Expected O, but got I4
		//IL_100a: Unknown result type (might be due to invalid IL or missing references)
		//IL_100f: Expected O, but got Unknown
		//IL_07e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e6: Expected I, but got Unknown
		//IL_07aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_07af: Expected O, but got Unknown
		//IL_07b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07bd: Expected O, but got Unknown
		//IL_114b: Expected O, but got I4
		//IL_0713: Unknown result type (might be due to invalid IL or missing references)
		//IL_0718: Expected O, but got Unknown
		//IL_072e: Expected O, but got I
		//IL_0739: Unknown result type (might be due to invalid IL or missing references)
		//IL_073e: Expected O, but got Unknown
		//IL_0c23: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c28: Expected O, but got Unknown
		//IL_0c30: Expected I, but got O
		//IL_0c40: Expected O, but got I
		//IL_0cdf: Expected O, but got I4
		//IL_0824: Unknown result type (might be due to invalid IL or missing references)
		//IL_0829: Expected O, but got Unknown
		//IL_1195: Expected O, but got I
		//IL_0c7b: Expected O, but got I
		//IL_0867: Unknown result type (might be due to invalid IL or missing references)
		//IL_086c: Expected O, but got Unknown
		//IL_0874: Expected I, but got O
		//IL_0884: Expected O, but got I
		//IL_0cf4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf9: Expected O, but got Unknown
		//IL_0d02: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d07: Expected O, but got Unknown
		//IL_0957: Expected O, but got I4
		//IL_0c89: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c8e: Expected O, but got Unknown
		//IL_0ca4: Expected O, but got I
		//IL_10d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_10dd: Expected O, but got Unknown
		//IL_10f7: Expected I, but got O
		//IL_08bf: Expected O, but got I
		//IL_0d48: Expected I, but got O
		//IL_1097: Unknown result type (might be due to invalid IL or missing references)
		//IL_109c: Expected O, but got Unknown
		//IL_09a4: Expected O, but got I
		//IL_09b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b8: Expected O, but got Unknown
		//IL_09f2: Expected O, but got I4
		//IL_096c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0971: Expected O, but got Unknown
		//IL_097a: Unknown result type (might be due to invalid IL or missing references)
		//IL_097f: Expected O, but got Unknown
		//IL_0a37: Expected O, but got I4
		//IL_08d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08da: Expected O, but got Unknown
		//IL_08f0: Expected O, but got I
		//IL_08fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0900: Expected O, but got Unknown
		//IL_0d88: Expected O, but got I4
		//IL_0a4d: Expected I, but got O
		//IL_0b14: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b19: Expected O, but got Unknown
		//IL_0da7: Expected O, but got I4
		//IL_0b5b: Expected I, but got O
		//IL_0dc3: Expected O, but got I4
		//IL_0ba7: Expected I, but got O
		//IL_0aa0: Expected O, but got I
		//IL_0abe: Expected O, but got I4
		//IL_0acb: Expected I, but got O
		//IL_0bc6: Expected O, but got I4
		//IL_0bcf: Expected O, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E67CC]");
		nint num = 0;
		Sequence sequence = (Sequence)(typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 1400);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj = default(object);
		obj..ctor();
		bool flag = obj == null;
		Func<object, bool> func = null;
		object obj3 = default(object);
		UnityEngine.Object obj2 = (UnityEngine.Object)obj3;
		UnityEngine.Object obj4 = null;
		object obj10;
		RectTransform rectTransform3;
		nint num2;
		object obj13;
		RectTransform rectTransform;
		object obj9;
		if (!flag)
		{
			object obj5 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj6 = obj + 24;
			obj6 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj7 = obj + 16;
			obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj8 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X8_v14+E4]");
			obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X8_v14+E4]");
			object obj12;
			if ((nint)0 != 0)
			{
				obj10 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
				bool flag2 = stampsTarget;
				bool flag3 = !flag2;
				object obj11 = !flag3;
				rectTransform = null;
				obj12 = obj10;
				if (obj11 == null)
				{
					goto IL_0111;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj10 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
				bool flag4 = stampsTarget;
				bool flag5 = !flag4;
				rectTransform = null;
				obj12 = obj10;
				if (flag5)
				{
					goto IL_0111;
				}
			}
			RectTransform rectTransform2 = UIExtensions.rectTransform(stampsTarget);
			obj7 = rectTransform2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj13 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X0_v32+E4]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X0_v32+E4]");
			bool flag6 = (nint)0 == 0;
			object obj14 = !flag6;
			rectTransform = rectTransform2;
			rectTransform3 = rectTransform2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X0_v32+E4]");
			num2 = 0;
			if (obj14 != null)
			{
				goto IL_0166;
			}
			goto IL_0332;
		}
		goto IL_0eb3;
		IL_0d14:
		Sequence result;
		return result;
		IL_0417:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v602 @ X0_v113+E4]");
		obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v602 @ X0_v113+E4]");
		bool flag7 = (nint)0 == 0;
		object obj15 = !flag7;
		nint num3 = default(nint);
		object obj17;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj16 = obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v624 @ X8_v56+B8]");
			num3 = 0;
		}
		object obj18 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1448;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj19 = (nint)0 + (nint)3344;
		Func<object, bool> func2 = default(Func<object, bool>);
		func2..ctor((object)num3, (IntPtr)obj19);
		num = (nint)obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X8_v4 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+B8]");
		object obj20 = (nint)0 + (nint)8;
		obj20 = func2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj21 = 0;
		Func<object, bool> predicate = func2;
		object obj23;
		object obj22 = obj23;
		goto IL_047e;
		IL_04e0:
		GameObject gameObject = base.gameObject;
		bool flag8 = (object)gameObject == null;
		func = null;
		obj4 = null;
		Sequence sequence2;
		sequence = sequence2;
		if (!flag8)
		{
			gameObject.SetActive(value: false);
			result = sequence2;
			goto IL_0d14;
		}
		goto IL_0eb3;
		IL_047e:
		object obj24 = obj22;
		IEnumerable<object> enumerable = Enumerable.Where(highlights, predicate);
		object obj25;
		obj4 = (UnityEngine.Object)obj25;
		bool flag9 = ArraysExtensions.IsNullOrEmpty(enumerable);
		bool flag10 = !flag9;
		obj2 = (UnityEngine.Object)num3;
		IEnumerable<object> enumerable2 = enumerable;
		if (!flag10)
		{
			goto IL_04e0;
		}
		bool flag11 = enumerable == null;
		func = null;
		obj2 = (UnityEngine.Object)num3;
		enumerable2 = enumerable;
		sequence = sequence2;
		if (flag11)
		{
			goto IL_0eb3;
		}
		object obj26 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 3232;
		nint num4 = (nint)enumerable;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v633 @ X8_v23 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+12E]");
		obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v633 @ X8_v23 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_065a;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v633 @ X8_v23 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+B0]");
		object obj27 = (nint)0 + (nint)8;
		bool flag13 = default(bool);
		bool flag12 = flag13;
		object obj29;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v675 @ X10_v30-8]");
			object obj28 = 0 - obj26;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v675 @ X10_v30-8]");
			if (0 == (nint)obj26)
			{
				break;
			}
			obj29 = obj27 + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v633 @ X8_v23 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+12E]");
			obj9 = -1;
			obj28 = obj9 - 1;
			bool flag14 = obj28 == null;
			flag13 = (nint)obj9 != 1;
			flag12 = flag13;
			obj27 = obj29;
			if (flag13)
			{
				continue;
			}
			goto IL_065a;
		}
		obj9 = obj27;
		object obj30 = num4 + obj27;
		object obj31 = obj30 + 312;
		flag13 = flag12;
		obj29 = obj27;
		goto IL_0f88;
		IL_0111:
		obj13 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X0_v32+E4]");
		num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X0_v32+E4]");
		bool flag15 = (nint)0 == 0;
		rectTransform3 = rectTransform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X0_v32+E4]");
		num2 = 0;
		if (!flag15)
		{
			goto IL_0166;
		}
		goto IL_0332;
		IL_0332:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		rectTransform = rectTransform3;
		num = num2;
		goto IL_0166;
		IL_0166:
		obj25 = (nint)0 + (nint)2600;
		sequence2 = DOTween.Sequence();
		if (highlights != null)
		{
			obj17 = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 1392;
			object obj32 = obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v602 @ X0_v113+E4]");
			if ((nint)0 != 0)
			{
				obj22 = (nint)0 + (nint)3472;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v602 @ X0_v113+B8]");
				num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X8_v4 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+8]");
				predicate = (Func<object, bool>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X8_v4 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+8]");
				bool flag16 = (nint)0 == 0;
				object obj33 = !flag16;
				if (obj33 == null)
				{
					obj23 = obj22;
					num3 = num;
					goto IL_0417;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj32 = obj17;
				obj23 = (nint)0 + (nint)3472;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v602 @ X0_v113+B8]");
				num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v617 @ X8_v50 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+8]");
				predicate = (Func<object, bool>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v617 @ X8_v50 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+8]");
				bool flag17 = (nint)0 == 0;
				object obj34 = !flag17;
				obj22 = obj23;
				num = num3;
				if (obj34 == null)
				{
					goto IL_0417;
				}
			}
			goto IL_047e;
		}
		obj4 = (UnityEngine.Object)obj25;
		bool flag18 = ArraysExtensions.IsNullOrEmpty<object>(null);
		bool flag19 = !flag18;
		object obj35 = !flag19;
		if (obj35 != null)
		{
			goto IL_04e0;
		}
		func = null;
		sequence = sequence2;
		goto IL_0eb3;
		IL_065a:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		obj24 = 0;
		goto IL_0f88;
		IL_0eb3:
		throw new NullReferenceException();
		IL_0f88:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v703 @ X0_v57+8]");
		TweenCallback tweenCallback = (TweenCallback)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v703 @ X0_v57] (should have been resolved before IL gen)");
		obj17 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
		obj25 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
		obj22 = (nint)0 + (nint)3368;
		object obj36 = (nint)0 + (nint)3376;
		enumerable2 = enumerable;
		num = (nint)(&func);
		Func<object, bool> func3 = default(Func<object, bool>);
		object obj39 = default(object);
		object obj40 = default(object);
		UnityEngine.Object obj41 = default(UnityEngine.Object);
		TweenCallback tweenCallback2 = default(TweenCallback);
		TweenCallback tweenCallback3 = default(TweenCallback);
		object obj51 = default(object);
		object obj48;
		while (true)
		{
			if (func3 != null)
			{
				nint num5 = (nint)func3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v757 @ X8_v29 (Il2CppClass<System.Func`2<System.Object, System.Boolean>>)+12E]");
				obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v757 @ X8_v29 (Il2CppClass<System.Func`2<System.Object, System.Boolean>>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0782;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v757 @ X8_v29 (Il2CppClass<System.Func`2<System.Object, System.Boolean>>)+B0]");
				object obj37 = (nint)0 + (nint)8;
				bool flag20 = flag13;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v800 @ X10_v25-8]");
					object obj28 = 0 - obj17;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v800 @ X10_v25-8]");
					if (0 == (nint)obj17)
					{
						break;
					}
					obj29 = obj37 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v757 @ X8_v29 (Il2CppClass<System.Func`2<System.Object, System.Boolean>>)+12E]");
					obj9 = -1;
					obj28 = obj9 - 1;
					bool flag14 = obj28 == null;
					flag13 = (nint)obj9 != 1;
					flag20 = flag13;
					obj37 = obj29;
					if (flag13)
					{
						continue;
					}
					goto IL_0782;
				}
				obj9 = obj37;
				object obj38 = num5 + obj37;
				obj39 = obj38 + 312;
				flag13 = flag20;
				obj29 = obj37;
				goto IL_1038;
			}
			NullReferenceException ex = new NullReferenceException();
			obj4 = (UnityEngine.Object)(object)tweenCallback;
			goto IL_0dcd;
			IL_10c5:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v911 @ X0_v72] (should have been resolved before IL gen)");
			predicate = (Func<object, bool>)(obj40 + 16);
			predicate = (Func<object, bool>)(object)obj41;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			nint num6 = (nint)enumerable2;
			nint num7;
			if (enumerable2 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v834 @ X8_v39 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+10]");
				obj2 = (UnityEngine.Object)0;
				object obj42 = typeof(MemberAchievementClanFeedData) + 2976;
				object obj43 = obj42;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v922 @ X0_v78+E4]");
				num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v922 @ X0_v78+E4]");
				bool flag21 = (nint)0 == 0;
				object obj44 = !flag21;
				if (obj44 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag22 = obj2 == null;
				bool flag23 = !flag22;
				object obj45 = !flag23;
				if (obj45 != null)
				{
					goto IL_0ad9;
				}
				num = (nint)enumerable2;
				if (enumerable2 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X8_v4 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+10]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X8_v4 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+10]");
						int childCount = ((Transform)0).childCount;
						bool flag24 = childCount == 0;
						object obj46 = !flag24;
						UnityEngine.Object obj47 = null;
						num7 = (nint)enumerable2;
						if (obj46 != null)
						{
							goto IL_0b40;
						}
						goto IL_0ad9;
					}
					NullReferenceException ex2 = new NullReferenceException();
					obj24 = 0;
					obj4 = null;
				}
				else
				{
					NullReferenceException ex3 = new NullReferenceException();
					obj24 = 0;
					obj4 = null;
				}
			}
			else
			{
				NullReferenceException ex4 = new NullReferenceException();
				obj4 = obj41;
				num = (nint)enumerable2;
			}
			goto IL_0dcd;
			IL_0b40:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			tweenCallback2..ctor(obj40, (IntPtr)obj22);
			Sequence sequence3 = TweenSettingsExtensions.AppendCallback(sequence2, tweenCallback2);
			Sequence sequence4 = TweenSettingsExtensions.AppendInterval(sequence2, 0.5f);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			tweenCallback3..ctor(obj40, (IntPtr)obj36);
			Sequence sequence5 = TweenSettingsExtensions.AppendCallback(sequence2, tweenCallback3);
			obj21 = 0;
			obj24 = 0;
			enumerable2 = (IEnumerable<object>)(object)tweenCallback3;
			tweenCallback = tweenCallback3;
			num = num7;
			continue;
			IL_0dcd:
			func = func3;
			obj48 = 0;
			sequence = sequence2;
			goto IL_0eb3;
			IL_0ad9:
			enumerable2 = enumerable2;
			RectTransform rectTransform4 = UIExtensions.rectTransform((Component)(object)predicate);
			if (enumerable2 != null)
			{
				object obj49 = enumerable2 + 16;
				obj49 = rectTransform4;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				UnityEngine.Object obj47 = rectTransform4;
				num7 = num;
				goto IL_0b40;
			}
			NullReferenceException ex5 = new NullReferenceException();
			obj24 = 0;
			obj4 = rectTransform4;
			goto IL_0dcd;
			IL_0782:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			obj24 = 0;
			goto IL_1038;
			IL_1038:
			num = (nint)obj39;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v841 @ X0_v63+8]");
			obj4 = (UnityEngine.Object)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v841 @ X0_v63] (should have been resolved before IL gen)");
			object obj50 = obj51 & 1;
			if (obj50 == null)
			{
				break;
			}
			num = (nint)(typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 1408);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			obj40..ctor();
			if (obj40 != null)
			{
				enumerable2 = (IEnumerable<object>)(obj40 + 24);
				enumerable2 = (IEnumerable<object>)obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				if (func3 != null)
				{
					object obj52 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 608;
					nint num8 = (nint)func3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v854 @ X8_v36 (Il2CppClass<System.Func`2<System.Object, System.Boolean>>)+12E]");
					obj9 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v854 @ X8_v36 (Il2CppClass<System.Func`2<System.Object, System.Boolean>>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_0944;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v854 @ X8_v36 (Il2CppClass<System.Func`2<System.Object, System.Boolean>>)+B0]");
					object obj53 = (nint)0 + (nint)8;
					bool flag25 = flag13;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v896 @ X10_v20-8]");
						object obj28 = 0 - obj52;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v896 @ X10_v20-8]");
						if (0 == (nint)obj52)
						{
							break;
						}
						obj29 = obj53 + 16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v854 @ X8_v36 (Il2CppClass<System.Func`2<System.Object, System.Boolean>>)+12E]");
						obj9 = -1;
						obj28 = obj9 - 1;
						bool flag14 = obj28 == null;
						flag13 = (nint)obj9 != 1;
						flag25 = flag13;
						obj53 = obj29;
						if (flag13)
						{
							continue;
						}
						goto IL_0944;
					}
					obj9 = obj53;
					object obj54 = num8 + obj53;
					object obj55 = obj54 + 312;
					flag13 = flag25;
					obj29 = obj53;
					goto IL_10c5;
				}
				NullReferenceException ex6 = new NullReferenceException();
				obj4 = (UnityEngine.Object)obj;
			}
			else
			{
				NullReferenceException ex7 = new NullReferenceException();
				obj4 = null;
			}
			goto IL_0dcd;
			IL_0944:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			obj24 = 0;
			goto IL_10c5;
		}
		func = func3;
		obj48 = 0;
		sequence = sequence2;
		object obj56 = 0;
		object obj62 = default(object);
		Sequence result2 = default(Sequence);
		while (true)
		{
			if (func == null)
			{
				goto IL_1131;
			}
			object obj57 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
			nint num9 = (nint)func;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v403 @ X8_v7 (Il2CppClass<System.Func`2<System.Object, System.Boolean>>)+12E]");
			obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v403 @ X8_v7 (Il2CppClass<System.Func`2<System.Object, System.Boolean>>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0ccc;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v403 @ X8_v7 (Il2CppClass<System.Func`2<System.Object, System.Boolean>>)+B0]");
			object obj58 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v587 @ X10_v7-8]");
				if (0 == (nint)obj57)
				{
					break;
				}
				obj29 = obj58 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v403 @ X8_v7 (Il2CppClass<System.Func`2<System.Object, System.Boolean>>)+12E]");
				obj9 = -1;
				bool flag26 = (nint)obj9 != 1;
				obj58 = obj29;
				if (flag26)
				{
					continue;
				}
				goto IL_0ccc;
			}
			obj9 = obj58;
			object obj59 = num9 + obj58;
			object obj60 = obj59 + 312;
			obj29 = obj58;
			goto IL_1185;
			IL_1131:
			bool flag27 = obj56 == null;
			object obj61 = !flag27;
			result = sequence;
			if (obj61 != null)
			{
				OutOfMemoryException ex8 = new OutOfMemoryException();
				if ((nint)obj4 == 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
					obj56 = obj62;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
					obj48 = obj62;
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99C14");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
				return result2;
			}
			break;
			IL_0ccc:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			obj24 = 0;
			goto IL_1185;
			IL_1185:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v610 @ X0_v6+8]");
			obj4 = (UnityEngine.Object)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v610 @ X0_v6] (should have been resolved before IL gen)");
			goto IL_1131;
		}
		goto IL_0d14;
	}

	public void ResetHighlights()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_00ce: Expected O, but got I
		//IL_00de: Expected O, but got I
		//IL_00ee: Expected O, but got I
		//IL_0110: Expected O, but got I4
		//IL_0052: Expected O, but got I
		//IL_0062: Expected O, but got I
		//IL_0072: Expected O, but got I
		//IL_0094: Expected O, but got I4
		//IL_0148: Expected O, but got I4
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Expected O, but got Unknown
		//IL_01d6: Expected O, but got I
		//IL_01e7: Expected I, but got O
		//IL_0205: Expected O, but got I
		//IL_0178: Expected O, but got I
		if (highlights == null)
		{
			return;
		}
		object obj = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 1392;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v5+E4]");
		object obj4;
		Action<object> action;
		object obj6;
		object obj3;
		if ((nint)0 != 0)
		{
			obj3 = (nint)0 + (nint)2176;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v5+B8]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X8_v6+10]");
			action = (Action<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X8_v6+10]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				obj6 = obj3;
				goto IL_0126;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
			obj6 = (nint)0 + (nint)2176;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v5+B8]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X8_v6+10]");
			action = (Action<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X8_v6+10]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj3 = obj6;
			if (obj7 == null)
			{
				goto IL_0126;
			}
		}
		goto IL_017d;
		IL_017d:
		ArraysExtensions.ForEach(highlights, action);
		return;
		IL_0126:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v5+E4]");
		bool flag3 = (nint)0 == 0;
		object obj8 = !flag3;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj9 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X8_v12+B8]");
			obj4 = 0;
		}
		object obj10 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2208;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj11 = (nint)0 + (nint)3352;
		Action<object> action2 = default(Action<object>);
		action2..ctor(obj4, (IntPtr)obj11);
		object obj12 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v11+B8]");
		object obj13 = (nint)0 + (nint)16;
		obj13 = action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj3 = obj6;
		action = action2;
		goto IL_017d;
	}
}
