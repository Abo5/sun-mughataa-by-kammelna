using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using Cpp2ILInjected;
using DG.Tweening;
using DataTracking;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json.Linq.JsonPath;
using Sfs2X.Core;
using Sfs2X.Entities;
using Sfs2X.Entities.Data;
using Unity.Properties;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.Rendering;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceProviders;
using Util.Extensions;

public class FastTrackPopupManager : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<int, FTPlayMoreStates> <>9__28_0;

		public static Predicate<FastTrackResultPopup> <>9__29_0;

		public static Predicate<FastTrackResultPopup> <>9__29_1;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(DebugUI.BitField) + 2232;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal FTPlayMoreStates <UpdatePlayMoreState>b__28_0(int s)
		{
			return (FTPlayMoreStates)s;
		}

		internal bool <OnFTRecordUpdated>b__29_0(FastTrackResultPopup p)
		{
			//IL_0035: Expected I4, but got O
			if ((object)p != null)
			{
				return ((PopupUI)p).<IsCurrentlyShown>k__BackingField;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <OnFTRecordUpdated>b__29_1(FastTrackResultPopup p)
		{
			//IL_0035: Expected I4, but got O
			if ((object)p != null)
			{
				return ((PopupUI)p).<IsCurrentlyShown>k__BackingField;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	public FastTrackResultPopup WinRound;

	public FastTrackResultPopup WinStageWithReward;

	public FastTrackResultPopup WinStageNoReward;

	public FastTrackResultPopup WinLV1;

	public FastTrackResultPopup WinFT;

	public FastTrackResultPopup AIMatch;

	public FastTrackResultPopup LoseRound;

	public FastTrackResultPopup LoseFT;

	private CardGameEndScores cardGameScore;

	private List<FastTrackResultPopup> popupsList;

	private List<FastTrackResultPopup> winPopupsList;

	private List<FastTrackResultPopup> losePopupsList;

	private bool waitingToJoinLobbyToSendMatchMe;

	private CardGame game;

	private DateTime popupShowenTime;

	private GenericSoundAlbum genericSoundAlbum;

	private static FastTrackPopupManager Instance;

	public bool IsFinalResultYouWon
	{
		get
		{
			//IL_008b: Expected I4, but got O
			//IL_0069: Expected O, but got I4
			CardGameEndScores cardGameEndScores = cardGameScore;
			if (cardGameScore != null && (object)game != null)
			{
				int myTeamIndex = game.MyTeamIndex;
				object obj = cardGameEndScores.<WinnerTeamIndex>k__BackingField - myTeamIndex;
				return obj == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_003a: Expected O, but got I
		//IL_0094: Expected O, but got I4
		//IL_010b: Expected O, but got I
		//IL_011b: Expected O, but got I
		//IL_012b: Expected O, but got I
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected O, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected O, but got Unknown
		//IL_0199: Expected O, but got I4
		//IL_0210: Expected O, but got I
		//IL_0220: Expected O, but got I
		//IL_0230: Expected O, but got I
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Expected O, but got Unknown
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Expected O, but got Unknown
		//IL_029e: Expected O, but got I4
		//IL_0315: Expected O, but got I
		//IL_0325: Expected O, but got I
		//IL_0335: Expected O, but got I
		//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02de: Expected O, but got Unknown
		//IL_02e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Expected O, but got Unknown
		//IL_03a3: Expected O, but got I4
		//IL_041a: Expected O, but got I
		//IL_042a: Expected O, but got I
		//IL_043a: Expected O, but got I
		//IL_03de: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e3: Expected O, but got Unknown
		//IL_03ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f1: Expected O, but got Unknown
		//IL_04a8: Expected O, but got I4
		//IL_051f: Expected O, but got I
		//IL_052f: Expected O, but got I
		//IL_053f: Expected O, but got I
		//IL_04e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e8: Expected O, but got Unknown
		//IL_04f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f6: Expected O, but got Unknown
		//IL_05ad: Expected O, but got I4
		//IL_0624: Expected O, but got I
		//IL_0634: Expected O, but got I
		//IL_0644: Expected O, but got I
		//IL_05e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ed: Expected O, but got Unknown
		//IL_05f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fb: Expected O, but got Unknown
		//IL_06b2: Expected O, but got I4
		//IL_0729: Expected O, but got I
		//IL_0739: Expected O, but got I
		//IL_0749: Expected O, but got I
		//IL_06ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f2: Expected O, but got Unknown
		//IL_06fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0700: Expected O, but got Unknown
		//IL_07b7: Expected O, but got I4
		//IL_082e: Expected O, but got I
		//IL_083e: Expected O, but got I
		//IL_084e: Expected O, but got I
		//IL_0868: Unknown result type (might be due to invalid IL or missing references)
		//IL_086d: Expected O, but got Unknown
		//IL_07f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f7: Expected O, but got Unknown
		//IL_0800: Unknown result type (might be due to invalid IL or missing references)
		//IL_0805: Expected O, but got Unknown
		//IL_08f6: Expected O, but got I4
		//IL_0973: Expected O, but got I
		//IL_0983: Expected O, but got I
		//IL_0993: Expected O, but got I
		//IL_09a8: Expected O, but got I
		//IL_0931: Unknown result type (might be due to invalid IL or missing references)
		//IL_0936: Expected O, but got Unknown
		//IL_093f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0944: Expected O, but got Unknown
		//IL_0954: Expected O, but got I
		//IL_0a07: Expected O, but got I4
		//IL_0a7e: Expected O, but got I
		//IL_0a8e: Expected O, but got I
		//IL_0a9e: Expected O, but got I
		//IL_0a42: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a47: Expected O, but got Unknown
		//IL_0a50: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a55: Expected O, but got Unknown
		//IL_0b0c: Expected O, but got I4
		//IL_0b83: Expected O, but got I
		//IL_0b93: Expected O, but got I
		//IL_0ba3: Expected O, but got I
		//IL_0b47: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b4c: Expected O, but got Unknown
		//IL_0b55: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b5a: Expected O, but got Unknown
		//IL_0c11: Expected O, but got I4
		//IL_0c88: Expected O, but got I
		//IL_0c98: Expected O, but got I
		//IL_0ca8: Expected O, but got I
		//IL_0c4c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c51: Expected O, but got Unknown
		//IL_0c5a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c5f: Expected O, but got Unknown
		//IL_0d16: Expected O, but got I4
		//IL_0d8d: Expected O, but got I
		//IL_0d9d: Expected O, but got I
		//IL_0dad: Expected O, but got I
		//IL_0dc7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dcc: Expected O, but got Unknown
		//IL_0d51: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d56: Expected O, but got Unknown
		//IL_0d5f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d64: Expected O, but got Unknown
		//IL_0e55: Expected O, but got I4
		//IL_0ed2: Expected O, but got I
		//IL_0ee2: Expected O, but got I
		//IL_0ef2: Expected O, but got I
		//IL_0f07: Expected O, but got I
		//IL_0e90: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e95: Expected O, but got Unknown
		//IL_0e9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ea3: Expected O, but got Unknown
		//IL_0eb3: Expected O, but got I
		//IL_0f56: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f5b: Expected O, but got Unknown
		//IL_0f7b: Expected O, but got I4
		//IL_0ff2: Expected O, but got I
		//IL_1002: Expected O, but got I
		//IL_1012: Expected O, but got I
		//IL_1032: Expected O, but got I
		//IL_1038: Unknown result type (might be due to invalid IL or missing references)
		//IL_103d: Expected O, but got Unknown
		//IL_0fb6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fbb: Expected O, but got Unknown
		//IL_0fc4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc9: Expected O, but got Unknown
		//IL_1086: Expected O, but got I4
		//IL_1086: Expected O, but got I4
		//IL_1086: Expected O, but got I
		//IL_10b0: Expected O, but got I4
		//IL_10dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_10e2: Expected O, but got Unknown
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 264;
		object obj2 = typeof(List<AdaptivePerformanceScaler>) + 1032;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj4 = (nint)0 + (nint)1904;
		object obj5 = obj4;
		int version = list._version + 1;
		list._version = version;
		object[] items = list._items;
		bool flag = list._size < items.Length;
		object obj6 = !flag;
		if (obj6 == null)
		{
			int size = list._size + 1;
			list._size = size;
			object obj7 = items + list._size;
			object obj8 = obj7 + 32;
			obj8 = WinRound;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X8_v5+20]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v357 @ X8_v78+C0]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v358 @ X8_v79+70]");
			object obj11 = 0;
			list.AddWithResize((object)WinRound);
		}
		object obj12 = obj4;
		int version2 = list._version + 1;
		list._version = version2;
		object[] items2 = list._items;
		bool flag2 = list._size < items2.Length;
		object obj13 = !flag2;
		if (obj13 == null)
		{
			int size2 = list._size + 1;
			list._size = size2;
			object obj14 = items2 + list._size;
			object obj15 = obj14 + 32;
			obj15 = WinStageWithReward;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X8_v7+20]");
			object obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ X8_v75+C0]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ X8_v76+70]");
			object obj11 = 0;
			list.AddWithResize((object)WinStageWithReward);
		}
		object obj18 = obj4;
		int version3 = list._version + 1;
		list._version = version3;
		object[] items3 = list._items;
		bool flag3 = list._size < items3.Length;
		object obj19 = !flag3;
		if (obj19 == null)
		{
			int size3 = list._size + 1;
			list._size = size3;
			object obj20 = items3 + list._size;
			object obj21 = obj20 + 32;
			obj21 = WinStageNoReward;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ X8_v9+20]");
			object obj22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ X8_v72+C0]");
			object obj23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v440 @ X8_v73+70]");
			object obj11 = 0;
			list.AddWithResize((object)WinStageNoReward);
		}
		object obj24 = obj4;
		int version4 = list._version + 1;
		list._version = version4;
		object[] items4 = list._items;
		bool flag4 = list._size < items4.Length;
		object obj25 = !flag4;
		if (obj25 == null)
		{
			int size4 = list._size + 1;
			list._size = size4;
			object obj26 = items4 + list._size;
			object obj27 = obj26 + 32;
			obj27 = WinLV1;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X8_v11+20]");
			object obj28 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v451 @ X8_v69+C0]");
			object obj29 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v452 @ X8_v70+70]");
			object obj11 = 0;
			list.AddWithResize((object)WinLV1);
		}
		object obj30 = obj4;
		int version5 = list._version + 1;
		list._version = version5;
		object[] items5 = list._items;
		bool flag5 = list._size < items5.Length;
		object obj31 = !flag5;
		if (obj31 == null)
		{
			int size5 = list._size + 1;
			list._size = size5;
			object obj32 = items5 + list._size;
			object obj33 = obj32 + 32;
			obj33 = WinFT;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X8_v13+20]");
			object obj34 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v463 @ X8_v66+C0]");
			object obj35 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v464 @ X8_v67+70]");
			object obj11 = 0;
			list.AddWithResize((object)WinFT);
		}
		object obj36 = obj4;
		int version6 = list._version + 1;
		list._version = version6;
		object[] items6 = list._items;
		bool flag6 = list._size < items6.Length;
		object obj37 = !flag6;
		if (obj37 == null)
		{
			int size6 = list._size + 1;
			list._size = size6;
			object obj38 = items6 + list._size;
			object obj39 = obj38 + 32;
			obj39 = AIMatch;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ X8_v15+20]");
			object obj40 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v475 @ X8_v63+C0]");
			object obj41 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v476 @ X8_v64+70]");
			object obj11 = 0;
			list.AddWithResize((object)AIMatch);
		}
		object obj42 = obj4;
		int version7 = list._version + 1;
		list._version = version7;
		object[] items7 = list._items;
		bool flag7 = list._size < items7.Length;
		object obj43 = !flag7;
		if (obj43 == null)
		{
			int size7 = list._size + 1;
			list._size = size7;
			object obj44 = items7 + list._size;
			object obj45 = obj44 + 32;
			obj45 = LoseRound;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X8_v17+20]");
			object obj46 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v487 @ X8_v60+C0]");
			object obj47 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v488 @ X8_v61+70]");
			object obj11 = 0;
			list.AddWithResize((object)LoseRound);
		}
		object obj48 = obj4;
		int version8 = list._version + 1;
		list._version = version8;
		object[] items8 = list._items;
		bool flag8 = list._size < items8.Length;
		object obj49 = !flag8;
		if (obj49 == null)
		{
			int size8 = list._size + 1;
			list._size = size8;
			object obj50 = items8 + list._size;
			object obj51 = obj50 + 32;
			obj51 = LoseFT;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ X8_v19+20]");
			object obj52 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v499 @ X8_v57+C0]");
			object obj53 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v500 @ X8_v58+70]");
			object obj11 = 0;
			list.AddWithResize((object)LoseFT);
		}
		object obj54 = this + 104;
		obj54 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list2 = default(List<object>);
		list2..ctor();
		object obj55 = obj4;
		int version9 = list2._version + 1;
		list2._version = version9;
		object[] items9 = list2._items;
		bool flag9 = list2._size < items9.Length;
		object obj56 = !flag9;
		if (obj56 == null)
		{
			int size9 = list2._size + 1;
			list2._size = size9;
			object obj57 = items9 + list2._size;
			object obj58 = obj57 + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X21_v5-48]");
			obj58 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ X8_v21+20]");
			object obj59 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v516 @ X8_v54+C0]");
			object obj60 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v517 @ X8_v55+70]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X21_v5-48]");
			list2.AddWithResize((object)0);
		}
		object obj61 = obj4;
		int version10 = list2._version + 1;
		list2._version = version10;
		object[] items10 = list2._items;
		bool flag10 = list2._size < items10.Length;
		object obj62 = !flag10;
		if (obj62 == null)
		{
			int size10 = list2._size + 1;
			list2._size = size10;
			object obj63 = items10 + list2._size;
			object obj64 = obj63 + 32;
			obj64 = WinStageWithReward;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ X8_v23+20]");
			object obj65 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v528 @ X8_v51+C0]");
			object obj66 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v529 @ X8_v52+70]");
			object obj11 = 0;
			list2.AddWithResize((object)WinStageWithReward);
		}
		object obj67 = obj4;
		int version11 = list2._version + 1;
		list2._version = version11;
		object[] items11 = list2._items;
		bool flag11 = list2._size < items11.Length;
		object obj68 = !flag11;
		if (obj68 == null)
		{
			int size11 = list2._size + 1;
			list2._size = size11;
			object obj69 = items11 + list2._size;
			object obj70 = obj69 + 32;
			obj70 = WinStageNoReward;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ X8_v25+20]");
			object obj71 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v540 @ X8_v48+C0]");
			object obj72 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v541 @ X8_v49+70]");
			object obj11 = 0;
			list2.AddWithResize((object)WinStageNoReward);
		}
		object obj73 = obj4;
		int version12 = list2._version + 1;
		list2._version = version12;
		object[] items12 = list2._items;
		bool flag12 = list2._size < items12.Length;
		object obj74 = !flag12;
		if (obj74 == null)
		{
			int size12 = list2._size + 1;
			list2._size = size12;
			object obj75 = items12 + list2._size;
			object obj76 = obj75 + 32;
			obj76 = WinLV1;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v338 @ X8_v27+20]");
			object obj77 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v552 @ X8_v45+C0]");
			object obj78 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v553 @ X8_v46+70]");
			object obj11 = 0;
			list2.AddWithResize((object)WinLV1);
		}
		object obj79 = obj4;
		int version13 = list2._version + 1;
		list2._version = version13;
		object[] items13 = list2._items;
		bool flag13 = list2._size < items13.Length;
		object obj80 = !flag13;
		if (obj80 == null)
		{
			int size13 = list2._size + 1;
			list2._size = size13;
			object obj81 = items13 + list2._size;
			object obj82 = obj81 + 32;
			obj82 = WinFT;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ X8_v29+20]");
			object obj83 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v564 @ X8_v42+C0]");
			object obj84 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v565 @ X8_v43+70]");
			object obj11 = 0;
			list2.AddWithResize((object)WinFT);
		}
		object obj85 = this + 112;
		obj85 = list2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list3 = default(List<object>);
		list3..ctor();
		object obj86 = obj4;
		int version14 = list3._version + 1;
		list3._version = version14;
		object[] items14 = list3._items;
		bool flag14 = list3._size < items14.Length;
		object obj87 = !flag14;
		if (obj87 == null)
		{
			int size14 = list3._size + 1;
			list3._size = size14;
			object obj88 = items14 + list3._size;
			object obj89 = obj88 + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ X21_v7-20]");
			obj89 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ X8_v31+20]");
			object obj90 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v581 @ X8_v39+C0]");
			object obj91 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v582 @ X8_v40+70]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ X21_v7-20]");
			list3.AddWithResize((object)0);
		}
		object obj92 = obj4;
		int version15 = list3._version + 1;
		list3._version = version15;
		object[] items15 = list3._items;
		object obj93 = typeof(MemberAchievementClanFeedData) + 2976;
		bool flag15 = list3._size < items15.Length;
		object obj94 = !flag15;
		if (obj94 == null)
		{
			int size15 = list3._size + 1;
			list3._size = size15;
			object obj95 = items15 + list3._size;
			object obj96 = obj95 + 32;
			obj96 = LoseFT;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X8_v33+20]");
			object obj97 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v597 @ X8_v36+C0]");
			object obj98 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v598 @ X8_v37+70]");
			object obj11 = 0;
			list3.AddWithResize((object)LoseFT);
		}
		object obj99 = (nint)0 + (nint)24;
		object obj100 = this + 120;
		obj100 = list3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		float? x = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v607 @ X21_v9-10]");
		ComponentListsExtensions.MoveTo((IEnumerable<UnityEngine.Component>)0, isWorldPositions: false, x, (float?)(object)0, (float?)(object)0);
		object obj101 = obj93;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v617 @ X0_v35+E4]");
		bool flag16 = (nint)0 == 0;
		object obj102 = !flag16;
		if (obj102 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		object obj103 = this + 136;
		object obj104 = default(object);
		obj103 = obj104;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	private void Start()
	{
		//IL_0049: Expected I, but got O
		//IL_00fd: Expected O, but got I
		//IL_0105: Expected I, but got O
		//IL_0073: Expected O, but got I
		//IL_017f: Expected I, but got O
		//IL_00ab: Expected O, but got I4
		List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
		nint num = default(nint);
		if ((object)game != null)
		{
			if (!game.IsFastTrackGame)
			{
				return;
			}
			RegisterEvents();
			bool flag = popupsList == null;
			num = unchecked((nint)null);
			if (!flag)
			{
				List<object>.Enumerator enumerator = ((List<object>)(object)popupsList).GetEnumerator();
				object obj = (nint)0 + (nint)808;
				num = (nint)obj;
				if (!enumerator2.MoveNext())
				{
					enumerator2.Dispose();
					return;
				}
				NullReferenceException ex = new NullReferenceException();
				object obj2 = 0;
			}
		}
		NullReferenceException ex2 = new NullReferenceException();
		bool flag2 = num != 1;
		NullReferenceException ex3 = ex2;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			object obj3 = (nint)0 + (nint)800;
			num = (nint)obj3;
			enumerator2.Dispose();
			object obj4 = default(object);
			if (obj4 == null)
			{
				return;
			}
			OutOfMemoryException ex4 = new OutOfMemoryException();
			object obj2 = obj4;
			ex3 = (NullReferenceException)(object)ex4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223E700");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
	}

	private void OnDestroy()
	{
		UnRegisterEvents();
	}

	private void RegisterEvents()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0040: Expected O, but got I
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_0060: Expected O, but got I
		//IL_0176: Expected I, but got O
		//IL_007d: Expected I, but got O
		//IL_00a8: Expected I, but got O
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_00cd: Expected O, but got I
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		//IL_010d: Expected I, but got O
		//IL_0137: Expected O, but got I4
		object obj = typeof(DataRelation) + 3728;
		object obj2 = (nint)0 + (nint)2432;
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3344;
		object obj4 = (nint)0 + (nint)2456;
		object obj5 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1376;
		object obj6 = (nint)0 + (nint)2448;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		EventListenerDelegate eventListenerDelegate = default(EventListenerDelegate);
		eventListenerDelegate..ctor(this, (IntPtr)obj2);
		SFS.OnExtensionResponse += eventListenerDelegate;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj4);
		SFS.OnJoinGameRoom += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)this, (IntPtr)obj6);
		object obj7 = typeof(SqlSingle[]) + 2376;
		object obj8 = (nint)0 + (nint)2440;
		object obj9 = typeof(UsageHint) + 72;
		game.OnCardGameEnd += action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action3 = default(Action);
		action3..ctor(this, (IntPtr)obj8);
		object obj10 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X0_v14+E4]");
		bool flag = (nint)0 == 0;
		object obj11 = !flag;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		UserInfo.OnFastTrackRecordUpdated += action3;
	}

	private void UnRegisterEvents()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0040: Expected O, but got I
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_0060: Expected O, but got I
		//IL_0176: Expected I, but got O
		//IL_007d: Expected I, but got O
		//IL_00a8: Expected I, but got O
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_00cd: Expected O, but got I
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		//IL_010d: Expected I, but got O
		//IL_0137: Expected O, but got I4
		object obj = typeof(DataRelation) + 3728;
		object obj2 = (nint)0 + (nint)2432;
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3344;
		object obj4 = (nint)0 + (nint)2456;
		object obj5 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1376;
		object obj6 = (nint)0 + (nint)2448;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		EventListenerDelegate eventListenerDelegate = default(EventListenerDelegate);
		eventListenerDelegate..ctor(this, (IntPtr)obj2);
		SFS.OnExtensionResponse -= eventListenerDelegate;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj4);
		SFS.OnJoinGameRoom -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)this, (IntPtr)obj6);
		object obj7 = typeof(SqlSingle[]) + 2376;
		object obj8 = (nint)0 + (nint)2440;
		object obj9 = typeof(UsageHint) + 72;
		game.OnCardGameEnd -= action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action3 = default(Action);
		action3..ctor(this, (IntPtr)obj8);
		object obj10 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X0_v14+E4]");
		bool flag = (nint)0 == 0;
		object obj11 = !flag;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		UserInfo.OnFastTrackRecordUpdated -= action3;
	}

	private void OnExtensionResponse(BaseEvent evt)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected O, but got Unknown
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Expected O, but got Unknown
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected O, but got Unknown
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Expected O, but got Unknown
		//IL_0194: Expected O, but got I
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Expected O, but got Unknown
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected O, but got Unknown
		object obj = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 1864;
		string command = SFSExtensions.GetCommand(evt);
		if (command == (string)obj)
		{
			ISFSObject responseParams = SFSExtensions.GetResponseParams(evt);
			((FastTrackPopupManager)responseParams).BuyTicketsCallBack(responseParams);
			return;
		}
		object obj2 = "fetch_products" + 272;
		if (command == (string)obj2)
		{
			ISFSObject responseParams2 = SFSExtensions.GetResponseParams(evt);
			FindMatch(responseParams2);
			return;
		}
		object obj3 = "placementId" + 80;
		if (command == (string)obj3)
		{
			ISFSObject responseParams3 = SFSExtensions.GetResponseParams(evt);
			object obj4 = typeof(TypeConverter<ushort, char>) + 3048;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
			object varName = "startPosition" + 112;
			int[] defaultValue = default(int[]);
			int[] intStates = SFSExtensions.Get(responseParams3, (string)varName, defaultValue);
			UpdatePlayMoreState(intStates);
			return;
		}
		object obj5 = "m_StencilDeferredPS" + 632;
		if (command == (string)obj5)
		{
			ISFSObject responseParams4 = SFSExtensions.GetResponseParams(evt);
			object varName2 = "destinationTimeZone" + 2696;
			object defaultValue2 = (nint)0 + (nint)2000;
			object obj6 = "rightCtrl" + 2072;
			string text = SFSExtensions.Get(responseParams4, (string)varName2, (string)defaultValue2);
			if (text == (string)obj6)
			{
				ExitGame();
			}
		}
	}

	private void BuyTicketsCallBack(ISFSObject data)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0043: Expected O, but got I
		//IL_006d: Expected O, but got I4
		//IL_00d2: Expected O, but got I4
		//IL_010a: Expected O, but got I4
		//IL_016f: Expected O, but got I4
		object varName = "destinationTimeZone" + 2696;
		object obj = "not" + 104;
		string text = SFSExtensions.Get(data, (string)varName, (string)null);
		if (text == (string)obj)
		{
			object obj2 = typeof(Queue<string>) + 848;
			object obj3 = (nint)0 + (nint)2200;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v11+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel = default(SessionModel);
			User localUser = sessionModel.LocalUser;
			int fTTicketsOwned = SFSKammelnaUserExtensions.GetFTTicketsOwned(localUser);
			bool flag2 = fTTicketsOwned == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				object obj7 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X0_v19+E4]");
				bool flag3 = (nint)0 == 0;
				object obj8 = !flag3;
				if (obj8 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
				SessionModel sessionModel2 = default(SessionModel);
				User localUser2 = sessionModel2.LocalUser;
				int fTStage = SFSKammelnaUserExtensions.GetFTStage(localUser2);
				bool flag4 = fTStage == 0;
				object obj9 = !flag4;
				if (obj9 == null)
				{
					NotEnoughTicketsPopup.OpenPopup();
				}
			}
		}
		object obj10 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		ITrackEvent trackEvent = TrackerLibrary.FastTrackBuyTicketError(TrackingPlacement.InGame, text);
		object obj11 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X8_v4+E4]");
		if ((nint)0 != 0)
		{
			Tracker.DesignEvent(trackEvent);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Tracker.DesignEvent(trackEvent);
	}

	public void GoToMatch(ISFSObject data)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001b: Expected O, but got I
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		object varName = "destinationTimeZone" + 2696;
		object defaultValue = (nint)0 + (nint)2000;
		object obj = "rightCtrl" + 2072;
		string text = SFSExtensions.Get(data, (string)varName, (string)defaultValue);
		if (text == (string)obj)
		{
			ExitGame();
		}
	}

	private void OnJoinGameRoom(Room _)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Expected O, but got Unknown
		//IL_01f8: Expected O, but got I4
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0087: Expected O, but got I4
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected O, but got Unknown
		//IL_0194: Expected O, but got I4
		//IL_019d: Expected O, but got I4
		//IL_013a: Expected O, but got I4
		object obj = typeof(DataRelation) + 712;
		object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1032;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj5 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		DateTime now = DateTime.Now;
		DateTime dateTime = default(DateTime);
		TimeSpan timeSpan = dateTime.Subtract(popupShowenTime);
		object obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v8+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj8 = typeof(RegisteredWaitHandle) + 3136;
		TimeSpan timeSpan2 = default(TimeSpan);
		int seconds = timeSpan2.Seconds;
		ITrackEvent trackEvent = TrackerLibrary.FastTrackMatchSeconds(TrackingPlacement.InGame, seconds);
		object obj9 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X8_v5+E4]");
		if ((nint)0 != 0)
		{
			Tracker.DesignEvent(trackEvent);
			object obj10 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v14+E4]");
			bool flag3 = (nint)0 == 0;
			object obj11 = 0;
			if (!flag3)
			{
				goto IL_0148;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Tracker.DesignEvent(trackEvent);
			object obj10 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v14+E4]");
			bool flag4 = (nint)0 == 0;
			object obj12 = !flag4;
			object obj11 = 0;
			if (obj12 != null)
			{
				goto IL_0148;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		goto IL_0148;
		IL_0148:
		AsyncOperationHandle<SceneInstance> asyncOperationHandle = ScreenManager.ReloadScene();
	}

	private void UpdatePlayMoreState(IEnumerable<int> intStates)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0215: Expected O, but got I4
		//IL_030a: Expected O, but got I
		//IL_0316: Expected O, but got I
		//IL_0325: Unknown result type (might be due to invalid IL or missing references)
		//IL_032a: Expected O, but got Unknown
		//IL_0336: Expected O, but got I
		//IL_0346: Expected O, but got I
		//IL_0356: Expected O, but got I
		//IL_0378: Expected O, but got I4
		//IL_0052: Expected O, but got I4
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Expected O, but got Unknown
		//IL_024d: Expected O, but got I
		//IL_025e: Expected I, but got O
		//IL_027c: Expected O, but got I
		//IL_0082: Expected O, but got I
		//IL_0102: Expected O, but got I
		//IL_010e: Expected O, but got I
		//IL_0158: Expected O, but got I4
		object obj = typeof(DebugUI.BitField) + 2232;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		object obj4 = (nint)0 + (nint)3456;
		object obj5 = (nint)0 + (nint)1256;
		object obj6 = typeof(List<AdaptivePerformanceScaler>) + 1024;
		object obj7 = (nint)0 + (nint)1880;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v3+B8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X8_v12+8]");
		Func<int, System.Int32Enum> selector = (Func<int, System.Int32Enum>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X8_v12+8]");
		bool flag2 = (nint)0 == 0;
		object obj9 = !flag2;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v3+E4]");
			bool flag3 = (nint)0 == 0;
			object obj10 = !flag3;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj11 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X8_v18+B8]");
				obj8 = 0;
			}
			object obj12 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1864;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj13 = (nint)0 + (nint)3712;
			Func<int, System.Int32Enum> func = default(Func<int, System.Int32Enum>);
			func..ctor(obj8, (IntPtr)obj13);
			object obj14 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v17+B8]");
			object obj15 = (nint)0 + (nint)8;
			obj15 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			selector = func;
		}
		IEnumerable<System.Int32Enum> source = Enumerable.Select(intStates, selector);
		System.Int32Enum[] array = Enumerable.ToArray(source);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<System.Int32Enum> list = default(List<System.Int32Enum>);
		list..ctor((IEnumerable<System.Int32Enum>)array);
		bool flag4 = popupsList == null;
		IEnumerable<System.Int32Enum> enumerable = array;
		System.Int32Enum[] array2 = array;
		List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
		if (!flag4)
		{
			object obj16 = (nint)0 + (nint)808;
			array2 = (System.Int32Enum[])((nint)0 + (nint)800);
			List<object>.Enumerator enumerator = ((List<object>)(object)popupsList).GetEnumerator();
			enumerable = (IEnumerable<System.Int32Enum>)obj16;
			if (!enumerator2.MoveNext())
			{
				enumerator2.Dispose();
				return;
			}
			NullReferenceException ex = new NullReferenceException();
			object obj17 = 0;
		}
		NullReferenceException ex2 = new NullReferenceException();
		bool flag5 = (nint)enumerable != 1;
		NullReferenceException ex3 = ex2;
		if (!flag5)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			enumerable = array2;
			enumerator2.Dispose();
			object obj18 = default(object);
			if (obj18 == null)
			{
				return;
			}
			OutOfMemoryException ex4 = new OutOfMemoryException();
			object obj17 = obj18;
			ex3 = (NullReferenceException)(object)ex4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223E700");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
	}

	public void OnFTRecordUpdated()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_00dc: Expected O, but got I
		//IL_00ec: Expected O, but got I
		//IL_010e: Expected O, but got I4
		//IL_00a7: Expected O, but got I4
		//IL_0056: Expected O, but got I
		//IL_0066: Expected O, but got I
		//IL_0195: Expected O, but got I
		//IL_013e: Expected O, but got I4
		//IL_07ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f4: Expected O, but got Unknown
		//IL_080a: Expected O, but got I
		//IL_081b: Expected I, but got O
		//IL_0839: Expected O, but got I
		//IL_02db: Expected O, but got I
		//IL_02eb: Expected O, but got I
		//IL_030d: Expected O, but got I4
		//IL_017c: Expected O, but got I4
		//IL_016e: Expected O, but got I
		//IL_02a6: Expected O, but got I4
		//IL_0255: Expected O, but got I
		//IL_0265: Expected O, but got I
		//IL_033d: Expected O, but got I4
		//IL_048d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0492: Expected O, but got Unknown
		//IL_04bc: Expected O, but got I4
		//IL_085f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0864: Expected O, but got Unknown
		//IL_087a: Expected O, but got I
		//IL_088b: Expected I, but got O
		//IL_08a9: Expected O, but got I
		//IL_037b: Expected O, but got I4
		//IL_036d: Expected O, but got I
		//IL_0557: Unknown result type (might be due to invalid IL or missing references)
		//IL_055c: Expected O, but got Unknown
		//IL_0586: Expected O, but got I4
		//IL_05af: Expected O, but got I
		//IL_0416: Unknown result type (might be due to invalid IL or missing references)
		//IL_041b: Expected O, but got Unknown
		//IL_0445: Expected O, but got I4
		//IL_062f: Expected O, but got I4
		//IL_0695: Expected O, but got I4
		//IL_06e1: Expected O, but got I4
		//IL_074d: Expected O, but got I4
		if (cardGameScore == null)
		{
			return;
		}
		object obj = typeof(DebugUI.BitField) + 2232;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X0_v67+E4]");
		object obj3;
		Predicate<object> predicate;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X0_v67+B8]");
			obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X8_v44+10]");
			predicate = (Predicate<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X8_v44+10]");
			if ((nint)0 != 0)
			{
				goto IL_008b;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X0_v67+B8]");
			obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X8_v44+10]");
			predicate = (Predicate<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X8_v44+10]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_008b;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X0_v67+E4]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj6 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X8_v50+B8]");
			obj3 = 0;
		}
		object obj7 = typeof(List<Tween>) + 3240;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj8 = (nint)0 + (nint)3696;
		Predicate<object> predicate2 = default(Predicate<object>);
		predicate2..ctor(obj3, (IntPtr)obj8);
		object obj9 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X8_v49+B8]");
		object obj10 = (nint)0 + (nint)16;
		obj10 = predicate2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj11 = 0;
		predicate = predicate2;
		goto IL_0189;
		IL_0388:
		object obj13;
		object obj12 = obj13;
		Predicate<object> match;
		ITrackEvent trackEvent;
		object obj17;
		object obj18;
		ITrackEvent trackEvent2;
		if (((List<object>)(object)losePopupsList).Exists(match))
		{
			CardGameEndScores cardGameEndScores = cardGameScore;
			int myTeamIndex = game.MyTeamIndex;
			if (cardGameEndScores.<WinnerTeamIndex>k__BackingField == myTeamIndex)
			{
				trackEvent = TrackerLibrary.FastTrackPopUpMisMatchLoseWhenWin();
				object obj14 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
				object obj15 = obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v493 @ X8_v19+E4]");
				bool flag3 = (nint)0 == 0;
				object obj16 = !flag3;
				obj17 = obj11;
				if (obj16 == null)
				{
					Predicate<object> predicate3 = null;
					obj18 = obj13;
					trackEvent2 = trackEvent;
					goto IL_04e7;
				}
				goto IL_08c0;
			}
		}
		goto IL_050e;
		IL_07ba:
		throw new NullReferenceException();
		IL_05fe:
		Show();
		return;
		IL_04e7:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj17 = obj11;
		obj12 = obj18;
		trackEvent = trackEvent2;
		goto IL_08c0;
		IL_08c0:
		Tracker.DesignEvent(trackEvent);
		obj11 = obj17;
		goto IL_050e;
		IL_050e:
		CardGame cardGame = game;
		if (!((KGame)cardGame).<GamePhase>k__BackingField.IsGameFinished)
		{
			return;
		}
		object obj19 = typeof(Queue<string>) + 848;
		object obj20 = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v504 @ X0_v13+E4]");
		bool flag4 = (nint)0 == 0;
		object obj21 = !flag4;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj22 = (nint)0 + (nint)2200;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		int fTRoundsWon = SFSKammelnaUserExtensions.GetFTRoundsWon(localUser);
		if (fTRoundsWon != 5)
		{
			object obj23 = obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v532 @ X0_v19+E4]");
			bool flag5 = (nint)0 == 0;
			object obj24 = !flag5;
			if (obj24 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel2 = default(SessionModel);
			User localUser2 = sessionModel2.LocalUser;
			int fTHearts = SFSKammelnaUserExtensions.GetFTHearts(localUser2);
			bool flag6 = fTHearts != 5;
			object obj25 = 0;
			if (!flag6)
			{
				CardGameEndScores cardGameEndScores2 = cardGameScore;
				int myTeamIndex2 = game.MyTeamIndex;
				bool flag7 = cardGameEndScores2.<WinnerTeamIndex>k__BackingField != myTeamIndex2;
				obj25 = 0;
				if (flag7)
				{
					goto IL_05fe;
				}
			}
			FastTrackResultPopup loseFT = LoseFT;
			if (!((PopupUI)loseFT).<IsCurrentlyShown>k__BackingField)
			{
				return;
			}
			object obj26 = obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v544 @ X0_v26+E4]");
			bool flag8 = (nint)0 == 0;
			object obj27 = !flag8;
			if (obj27 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel3 = default(SessionModel);
			User localUser3 = sessionModel3.LocalUser;
			int fTHearts2 = SFSKammelnaUserExtensions.GetFTHearts(localUser3);
			if (fTHearts2 == 5)
			{
				return;
			}
		}
		goto IL_05fe;
		IL_008b:
		bool flag9 = winPopupsList == null;
		object obj28 = !flag9;
		if (obj28 != null)
		{
			goto IL_0189;
		}
		goto IL_07ba;
		IL_0189:
		obj13 = (nint)0 + (nint)1912;
		obj18 = obj13;
		bool flag10 = ((List<object>)(object)winPopupsList).Exists(predicate);
		bool flag11 = !flag10;
		Predicate<object> predicate4 = predicate;
		if (!flag11)
		{
			CardGameEndScores cardGameEndScores3 = cardGameScore;
			int myTeamIndex3 = game.MyTeamIndex;
			bool flag12 = cardGameEndScores3.<WinnerTeamIndex>k__BackingField != myTeamIndex3;
			predicate4 = null;
			if (flag12)
			{
				trackEvent2 = TrackerLibrary.FastTrackPopUpMisMatchWinWhenLose();
				object obj29 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
				object obj15 = obj29;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v493 @ X8_v19+E4]");
				bool flag13 = (nint)0 == 0;
				object obj30 = !flag13;
				Predicate<object> predicate3 = null;
				obj17 = obj11;
				obj12 = obj13;
				trackEvent = trackEvent2;
				if (obj30 == null)
				{
					goto IL_04e7;
				}
				goto IL_08c0;
			}
		}
		object obj31 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ X0_v52+E4]");
		object obj32;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ X0_v52+B8]");
			obj32 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ X8_v28+18]");
			match = (Predicate<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ X8_v28+18]");
			if ((nint)0 != 0)
			{
				goto IL_028a;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj31 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ X0_v52+B8]");
			obj32 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ X8_v28+18]");
			match = (Predicate<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ X8_v28+18]");
			bool flag14 = (nint)0 == 0;
			object obj33 = !flag14;
			if (obj33 != null)
			{
				goto IL_028a;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ X0_v52+E4]");
		bool flag15 = (nint)0 == 0;
		object obj34 = !flag15;
		if (obj34 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj35 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ X8_v34+B8]");
			obj32 = 0;
		}
		object obj36 = typeof(List<Tween>) + 3240;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj37 = (nint)0 + (nint)3704;
		Predicate<object> predicate5 = default(Predicate<object>);
		predicate5..ctor(obj32, (IntPtr)obj37);
		object obj38 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v355 @ X8_v33+B8]");
		object obj39 = (nint)0 + (nint)24;
		obj39 = predicate5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj11 = 0;
		match = predicate5;
		goto IL_0388;
		IL_028a:
		bool flag16 = losePopupsList == null;
		object obj40 = !flag16;
		if (obj40 != null)
		{
			goto IL_0388;
		}
		goto IL_07ba;
	}

	private void OnGameEnd(CardGameEndScores report)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		object obj = this + 96;
		obj = report;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Show();
	}

	public void Show()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00f0: Expected O, but got I4
		//IL_00ad: Expected O, but got I4
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Expected O, but got Unknown
		//IL_04fe: Expected O, but got I4
		//IL_0525: Unknown result type (might be due to invalid IL or missing references)
		//IL_052a: Expected O, but got Unknown
		//IL_0542: Unknown result type (might be due to invalid IL or missing references)
		//IL_0547: Expected O, but got Unknown
		//IL_0571: Expected O, but got I4
		//IL_01d9: Expected O, but got I4
		//IL_059a: Expected O, but got I
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Expected O, but got Unknown
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Expected O, but got Unknown
		//IL_024c: Expected O, but got I4
		//IL_0275: Expected O, but got I
		//IL_061b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0620: Expected O, but got Unknown
		//IL_0862: Expected O, but got I4
		//IL_0c97: Expected O, but got I
		//IL_0cb1: Expected O, but got I4
		//IL_0305: Expected O, but got I4
		//IL_091a: Expected O, but got I4
		//IL_0663: Expected O, but got I
		//IL_0752: Expected O, but got I4
		//IL_10b8: Expected O, but got I4
		//IL_0d27: Expected O, but got I
		//IL_0d37: Expected O, but got I
		//IL_0cef: Expected O, but got I4
		//IL_06c5: Expected O, but got I
		//IL_06d5: Expected O, but got I
		//IL_06f7: Expected O, but got I4
		//IL_0d72: Expected O, but got I
		//IL_0383: Expected O, but got I4
		//IL_0e41: Expected O, but got I4
		//IL_0957: Expected O, but got I4
		//IL_0dcc: Expected O, but got I
		//IL_0ddc: Expected O, but got I
		//IL_0dfe: Expected O, but got I4
		//IL_03bb: Expected O, but got I4
		//IL_126b: Expected O, but got I4
		//IL_0ebd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ec2: Expected O, but got Unknown
		//IL_0eec: Expected O, but got I4
		//IL_0e79: Expected O, but got I
		//IL_0e89: Expected O, but got I
		//IL_112d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1132: Expected O, but got Unknown
		//IL_115c: Expected O, but got I4
		//IL_0f17: Expected I4, but got I8
		//IL_0807: Expected O, but got I4
		//IL_09d5: Expected O, but got I4
		//IL_11a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_11ac: Expected O, but got Unknown
		//IL_11d6: Expected O, but got I4
		//IL_0f46: Expected I4, but got I8
		//IL_0b08: Expected O, but got I4
		//IL_0439: Expected O, but got I4
		//IL_0a0d: Expected O, but got I4
		//IL_0fc5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fca: Expected O, but got Unknown
		//IL_0ff4: Expected O, but got I4
		//IL_0ffd: Expected O, but got I4
		//IL_1028: Expected O, but got I4
		//IL_0470: Unknown result type (might be due to invalid IL or missing references)
		//IL_0475: Expected O, but got Unknown
		//IL_049f: Expected O, but got I4
		//IL_0a8b: Expected O, but got I4
		//IL_04cf: Expected I4, but got O
		//IL_0b97: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b9c: Expected O, but got Unknown
		//IL_0bc6: Expected O, but got I4
		//IL_0acb: Expected O, but got I4
		//IL_1226: Expected O, but got I4
		//IL_0c64: Expected O, but got I4
		object obj = typeof(DataRelation) + 712;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E89B2]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v151+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v151+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		DateTime now = DateTime.Now;
		popupShowenTime = now;
		CardGameEndScores cardGameEndScores = cardGameScore;
		if (cardGameScore != null)
		{
			goto IL_0149;
		}
		goto IL_1279;
		IL_1091:
		KGame kGame;
		bool isSpectator = kGame.IsSpectator;
		bool flag2 = !isSpectator;
		object obj5 = !flag2;
		if (obj5 != null)
		{
			return;
		}
		if ((object)game != null)
		{
			CardGamePlayer myPlayer = game.MyPlayer;
			if (myPlayer != null)
			{
				TimeSpan timeInGame = myPlayer.TimeInGame;
				object obj6 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1032;
				object obj7 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v667 @ X0_v17+E4]");
				bool flag3 = (nint)0 == 0;
				object obj8 = !flag3;
				if (obj8 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				TimeSpan timeSpan = default(TimeSpan);
				double totalSeconds = timeSpan.TotalSeconds;
				ITrackEvent trackEvent = TrackerLibrary.FastTrackRoundFinishTime((float)totalSeconds);
				object obj9 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
				object obj10 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v623 @ X8_v14+E4]");
				bool flag4 = (nint)0 == 0;
				object obj11 = !flag4;
				if (obj11 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Tracker.DesignEvent(trackEvent);
				return;
			}
		}
		goto IL_1279;
		IL_128e:
		ITrackEvent trackEvent2;
		Tracker.DesignEvent(trackEvent2);
		kGame = game;
		if ((object)game != null)
		{
			goto IL_1091;
		}
		goto IL_1279;
		IL_1062:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj13;
		object obj12 = obj13;
		int num2;
		int num = num2;
		int num4;
		int num3 = num4;
		ITrackEvent trackEvent3;
		trackEvent2 = trackEvent3;
		goto IL_128e;
		IL_0074:
		DateTime now2 = DateTime.Now;
		popupShowenTime = now2;
		cardGameEndScores = cardGameScore;
		bool flag5 = cardGameScore == null;
		object obj14 = !flag5;
		if (obj14 != null)
		{
			goto IL_0149;
		}
		goto IL_1279;
		IL_0149:
		object obj19;
		object obj45;
		object obj50;
		object obj52;
		if ((object)game != null)
		{
			object obj15 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
			int myTeamIndex = game.MyTeamIndex;
			object obj16 = obj15;
			if (cardGameEndScores.<WinnerTeamIndex>k__BackingField == myTeamIndex)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v406 @ X0_v8+E4]");
				bool flag6 = (nint)0 == 0;
				object obj17 = !flag6;
				if (obj17 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj18 = "___# Content push apply failed [{0}]: {1}" + 816;
				KLogger.LogAnalytics(obj18);
				obj19 = typeof(Queue<string>) + 848;
				object obj20 = obj19;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ X0_v85+E4]");
				bool flag7 = (nint)0 == 0;
				object obj21 = !flag7;
				if (obj21 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj22 = (nint)0 + (nint)2200;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
				SessionModel sessionModel = default(SessionModel);
				if ((object)sessionModel != null)
				{
					User localUser = sessionModel.LocalUser;
					int fTRoundsWon = SFSKammelnaUserExtensions.GetFTRoundsWon(localUser);
					if (fTRoundsWon == 5)
					{
						object obj23 = obj19;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v503 @ X0_v98+E4]");
						bool flag8 = (nint)0 == 0;
						object obj24 = !flag8;
						if (obj24 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
						SessionModel sessionModel2 = default(SessionModel);
						if ((object)sessionModel2 != null)
						{
							User localUser2 = sessionModel2.LocalUser;
							int fTLevel = SFSKammelnaUserExtensions.GetFTLevel(localUser2);
							bool flag9 = fTLevel != 2;
							object obj25 = 0;
							if (!flag9)
							{
								object obj26 = obj19;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v583 @ X0_v138+E4]");
								bool flag10 = (nint)0 == 0;
								object obj27 = !flag10;
								if (obj27 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
								SessionModel sessionModel3 = default(SessionModel);
								if ((object)sessionModel3 == null)
								{
									goto IL_1279;
								}
								User localUser3 = sessionModel3.LocalUser;
								int fTStage = SFSKammelnaUserExtensions.GetFTStage(localUser3);
								bool flag11 = fTStage != 8;
								obj25 = 0;
								if (!flag11)
								{
									ShowPopup(WinFT);
									trackEvent2 = TrackerLibrary.FastTrackComplete();
									object obj28 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
									object obj29 = obj28;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v737 @ X8_v15+E4]");
									bool flag12 = (nint)0 == 0;
									object obj30 = !flag12;
									if (obj30 == null)
									{
										obj13 = obj12;
										num2 = num;
										num4 = num3;
										int num5 = (int)WinFT;
										trackEvent3 = trackEvent2;
										goto IL_1062;
									}
									goto IL_128e;
								}
							}
							object obj31 = obj19;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v600 @ X0_v105+E4]");
							bool flag13 = (nint)0 == 0;
							object obj32 = !flag13;
							if (obj32 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
							SessionModel sessionModel4 = default(SessionModel);
							if ((object)sessionModel4 != null)
							{
								User localUser4 = sessionModel4.LocalUser;
								int fTLevel2 = SFSKammelnaUserExtensions.GetFTLevel(localUser4);
								bool flag14 = fTLevel2 != 1;
								object obj33 = 0;
								if (flag14)
								{
									goto IL_0ade;
								}
								object obj34 = obj19;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v673 @ X0_v128+E4]");
								bool flag15 = (nint)0 == 0;
								object obj35 = !flag15;
								if (obj35 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
								SessionModel sessionModel5 = default(SessionModel);
								if ((object)sessionModel5 != null)
								{
									User localUser5 = sessionModel5.LocalUser;
									int fTStage2 = SFSKammelnaUserExtensions.GetFTStage(localUser5);
									bool flag16 = fTStage2 != 6;
									obj33 = 0;
									if (flag16)
									{
										goto IL_0ade;
									}
									ShowPopup(WinLV1);
									kGame = game;
									bool flag17 = (object)game == null;
									object obj36 = !flag17;
									if (obj36 != null)
									{
										goto IL_1091;
									}
								}
							}
						}
					}
					else if ((object)game != null)
					{
						bool isSpectator2 = game.IsSpectator;
						bool flag18 = !isSpectator2;
						object obj37 = !flag18;
						if (obj37 != null)
						{
							goto IL_08e8;
						}
						if ((object)game != null)
						{
							CardGamePlayer myPlayer2 = game.MyPlayer;
							if (myPlayer2 != null)
							{
								SeatStatus seatStatus = myPlayer2.SeatStatus;
								if (seatStatus == SeatStatus.IdleBlocked)
								{
									goto IL_08e8;
								}
								ShowPopup(WinRound);
								kGame = game;
								bool flag19 = (object)game == null;
								object obj38 = !flag19;
								if (obj38 != null)
								{
									goto IL_1091;
								}
							}
						}
					}
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v406 @ X0_v8+E4]");
				bool flag20 = (nint)0 == 0;
				object obj39 = !flag20;
				if (obj39 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj40 = "___# Content push apply failed [{0}]: {1}" + 808;
				KLogger.LogAnalytics(obj40);
				object obj41 = typeof(Queue<string>) + 848;
				object obj42 = obj41;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v475 @ X0_v36+E4]");
				bool flag21 = (nint)0 == 0;
				object obj43 = !flag21;
				if (obj43 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj44 = (nint)0 + (nint)2200;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
				SessionModel sessionModel6 = default(SessionModel);
				if ((object)sessionModel6 != null)
				{
					User localUser6 = sessionModel6.LocalUser;
					int fTHearts = SFSKammelnaUserExtensions.GetFTHearts(localUser6);
					if (fTHearts == 5)
					{
						ShowPopup(LoseFT);
						obj45 = typeof(UsageHint) + 72;
						object obj46 = obj45;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v512 @ X0_v50+E4]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45D2]");
							object obj47 = (nint)0 & (nint)1;
							if (obj47 != null)
							{
								goto IL_0680;
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45D2]");
							object obj48 = (nint)0 & (nint)1;
							bool flag22 = obj48 == null;
							object obj49 = !flag22;
							if (obj49 != null)
							{
								goto IL_0680;
							}
						}
						_ = 1;
						obj50 = obj45;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ X0_v68+E4]");
						bool flag23 = (nint)0 == 0;
						object obj51 = !flag23;
						obj52 = obj50;
						if (obj51 != null)
						{
							goto IL_06b5;
						}
						goto IL_0d05;
					}
					if ((object)game != null)
					{
						bool isSpectator3 = game.IsSpectator;
						bool flag24 = !isSpectator3;
						object obj53 = !flag24;
						if (obj53 != null)
						{
							goto IL_08e8;
						}
						if ((object)game != null)
						{
							CardGamePlayer myPlayer3 = game.MyPlayer;
							if (myPlayer3 != null)
							{
								SeatStatus seatStatus2 = myPlayer3.SeatStatus;
								if (seatStatus2 == SeatStatus.IdleBlocked)
								{
									goto IL_08e8;
								}
								ShowPopup(LoseRound);
								kGame = game;
								bool flag25 = (object)game == null;
								object obj54 = !flag25;
								if (obj54 != null)
								{
									goto IL_1091;
								}
							}
						}
					}
				}
			}
		}
		goto IL_1279;
		IL_1279:
		NullReferenceException ex = new NullReferenceException();
		throw new IndexOutOfRangeException();
		IL_0d5c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45D2]");
		object obj55 = (nint)0 & (nint)1;
		if (obj55 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ X0_v68+E4]");
			bool flag26 = (nint)0 == 0;
			object obj56 = obj50;
			if (!flag26)
			{
				goto IL_0dbc;
			}
		}
		else
		{
			_ = 1;
			obj50 = obj45;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ X0_v68+E4]");
			bool flag27 = (nint)0 == 0;
			object obj57 = !flag27;
			object obj56 = obj50;
			if (obj57 != null)
			{
				goto IL_0dbc;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj58 = obj45;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ X0_v64+B8]");
		object obj59 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v649 @ X8_v37+8]");
		object obj60 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v649 @ X8_v37+8]");
		if ((nint)0 != 0)
		{
			goto IL_0eae;
		}
		goto IL_1279;
		IL_06b5:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ X0_v68+B8]");
		object obj61 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v563 @ X8_v53+8]");
		object obj62 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v563 @ X8_v53+8]");
		bool flag28 = (nint)0 == 0;
		object obj63 = !flag28;
		if (obj63 != null)
		{
			goto IL_0d5c;
		}
		goto IL_1279;
		IL_0680:
		obj50 = obj45;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ X0_v68+E4]");
		bool flag29 = (nint)0 == 0;
		obj52 = obj50;
		if (!flag29)
		{
			goto IL_06b5;
		}
		goto IL_0d05;
		IL_0dbc:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ X0_v68+B8]");
		object obj64 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v631 @ X8_v42+8]");
		obj60 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v631 @ X8_v42+8]");
		bool flag30 = (nint)0 == 0;
		object obj65 = !flag30;
		if (obj65 != null)
		{
			goto IL_0eae;
		}
		goto IL_1279;
		IL_0eae:
		object obj66 = typeof(System.Buffers.Text.ParserHelpers) + 1064;
		object obj67 = obj66;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v646 @ X0_v53+E4]");
		bool flag31 = (nint)0 == 0;
		object obj68 = !flag31;
		if (obj68 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int[] nearestFTAwardStage = PlayerRank.GetNearestFTAwardStage(-1);
		if (nearestFTAwardStage != null)
		{
			int[] nearestFTAwardStage2 = PlayerRank.GetNearestFTAwardStage(-1);
			if (nearestFTAwardStage2 != null)
			{
				num4 = nearestFTAwardStage2[1];
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v578 @ X8_v25+20]");
				nint num6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v643 @ X8_v27+24]");
				trackEvent3 = TrackerLibrary.FastTrackLost((int)num6, 0, nearestFTAwardStage[0], nearestFTAwardStage2[1]);
				object obj69 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
				object obj29 = obj69;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v737 @ X8_v15+E4]");
				bool flag32 = (nint)0 == 0;
				object obj70 = !flag32;
				obj13 = 0;
				num2 = nearestFTAwardStage[0];
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v643 @ X8_v27+24]");
				int num5 = 0;
				obj12 = 0;
				num = nearestFTAwardStage[0];
				num3 = nearestFTAwardStage2[1];
				trackEvent2 = trackEvent3;
				if (obj70 == null)
				{
					goto IL_1062;
				}
				goto IL_128e;
			}
		}
		goto IL_1279;
		IL_0ade:
		object obj71 = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v681 @ X0_v112+E4]");
		bool flag33 = (nint)0 == 0;
		object obj72 = !flag33;
		if (obj72 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel7 = default(SessionModel);
		if ((object)sessionModel7 != null)
		{
			User localUser7 = sessionModel7.LocalUser;
			PlayerRank rank = SFSKammelnaUserExtensions.GetRank(localUser7);
			if (rank != null)
			{
				object obj73 = typeof(System.Buffers.Text.ParserHelpers) + 1064;
				object obj74 = obj73;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v760 @ X0_v118+E4]");
				bool flag34 = (nint)0 == 0;
				object obj75 = !flag34;
				if (obj75 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				PlayerRank playerRank = PlayerRank.FastTrackAward();
				if (playerRank != null)
				{
					if (rank.<Points>k__BackingField < playerRank.<Points>k__BackingField)
					{
						ShowPopup(WinStageWithReward);
						kGame = game;
						bool flag35 = (object)game == null;
						object obj76 = !flag35;
						if (obj76 != null)
						{
							goto IL_1091;
						}
					}
					else
					{
						ShowPopup(WinStageNoReward);
						kGame = game;
						bool flag36 = (object)game == null;
						object obj77 = !flag36;
						if (obj77 != null)
						{
							goto IL_1091;
						}
					}
				}
			}
		}
		goto IL_1279;
		IL_08e8:
		ShowPopup(AIMatch);
		kGame = game;
		bool flag37 = (object)game == null;
		object obj78 = !flag37;
		if (obj78 != null)
		{
			goto IL_1091;
		}
		goto IL_1279;
		IL_0d05:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj50 = obj45;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ X0_v68+B8]");
		object obj79 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v582 @ X8_v46+8]");
		obj62 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v582 @ X8_v46+8]");
		if ((nint)0 != 0)
		{
			goto IL_0d5c;
		}
		goto IL_1279;
	}

	private void ShowPopup(FastTrackResultPopup popupToShow)
	{
		//IL_0024: Expected O, but got I4
		//IL_0314: Expected O, but got I
		//IL_0075: Expected O, but got I
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected O, but got Unknown
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected O, but got Unknown
		//IL_0156: Expected O, but got I
		//IL_023f: Expected O, but got I4
		//IL_0248: Expected O, but got I4
		//IL_01ef: Expected O, but got I4
		//IL_00cb: Expected O, but got I4
		//IL_0281: Expected O, but got I4
		//IL_02c2: Expected O, but got I4
		bool flag = (object)popupToShow == null;
		FastTrackResultPopup fastTrackResultPopup = popupToShow;
		List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
		if (!flag)
		{
			bool flag2 = !((PopupUI)popupToShow).<IsCurrentlyShown>k__BackingField;
			object obj = !flag2;
			if (obj != null)
			{
				return;
			}
			bool flag3 = popupsList == null;
			fastTrackResultPopup = popupToShow;
			if (!flag3)
			{
				List<object>.Enumerator enumerator = ((List<object>)(object)popupsList).GetEnumerator();
				object obj2 = (nint)0 + (nint)808;
				object obj3 = typeof(DataRelation) + 856;
				object obj4 = "___# Content push apply failed [{0}]: {1}" + 576;
				fastTrackResultPopup = (FastTrackResultPopup)obj2;
				if (!enumerator2.MoveNext())
				{
					object obj5 = (nint)0 + (nint)800;
					fastTrackResultPopup = (FastTrackResultPopup)obj5;
					enumerator2.Dispose();
					goto IL_016c;
				}
				object obj6 = 0;
				NullReferenceException ex = new NullReferenceException();
				object obj7 = 0;
			}
		}
		NullReferenceException ex2 = new NullReferenceException();
		bool flag4 = (nint)fastTrackResultPopup != 1;
		NullReferenceException ex3 = ex2;
		if (!flag4)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			object obj8 = (nint)0 + (nint)800;
			fastTrackResultPopup = (FastTrackResultPopup)obj8;
			enumerator2.Dispose();
			object obj9 = default(object);
			if (obj9 == null)
			{
				goto IL_016c;
			}
			OutOfMemoryException ex4 = new OutOfMemoryException();
			object obj7 = obj9;
			ex3 = (NullReferenceException)(object)ex4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223E700");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return;
		IL_016c:
		popupToShow.UpdatePopupValues();
		popupToShow.PopFromCenter();
		object obj10 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj11 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X0_v20+E4]");
		if ((nint)0 != 0)
		{
			bool flag5 = popupToShow == WinLV1;
			bool flag6 = !flag5;
			object obj12 = 0;
			if (flag6)
			{
				goto IL_0257;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag7 = popupToShow == WinLV1;
			bool flag8 = !flag7;
			object obj13 = !flag8;
			object obj12 = 0;
			if (obj13 == null)
			{
				goto IL_0257;
			}
		}
		goto IL_029e;
		IL_029e:
		ClaimRank(alsoExitGame: false);
		return;
		IL_0257:
		object obj14 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X0_v24+E4]");
		bool flag9 = (nint)0 == 0;
		object obj15 = !flag9;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (!(popupToShow == WinFT))
		{
			return;
		}
		goto IL_029e;
	}

	private void HideAllPopups()
	{
		//IL_0111: Expected O, but got I4
		//IL_0012: Expected O, but got I
		//IL_001e: Expected O, but got I
		//IL_0127: Expected I, but got O
		//IL_00b2: Expected I, but got O
		//IL_0064: Expected O, but got I4
		bool flag = popupsList == null;
		object obj = 152993792;
		List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
		nint num = default(nint);
		if (!flag)
		{
			object obj2 = (nint)0 + (nint)808;
			obj = (nint)0 + (nint)800;
			List<object>.Enumerator enumerator = ((List<object>)(object)popupsList).GetEnumerator();
			num = (nint)obj2;
			if (!enumerator2.MoveNext())
			{
				enumerator2.Dispose();
				return;
			}
			NullReferenceException ex = new NullReferenceException();
			object obj3 = 0;
		}
		NullReferenceException ex2 = new NullReferenceException();
		bool flag2 = num != 1;
		NullReferenceException ex3 = ex2;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			num = (nint)obj;
			enumerator2.Dispose();
			object obj4 = default(object);
			if (obj4 == null)
			{
				return;
			}
			OutOfMemoryException ex4 = new OutOfMemoryException();
			object obj3 = obj4;
			ex3 = (NullReferenceException)(object)ex4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223E700");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
	}

	private void FindMatch(ISFSObject json)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001b: Expected O, but got I
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		//IL_006a: Expected O, but got I
		//IL_0167: Expected O, but got I
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected O, but got Unknown
		//IL_00e4: Expected O, but got I4
		//IL_0115: Expected O, but got I4
		object varName = "destinationTimeZone" + 2696;
		object defaultValue = (nint)0 + (nint)2000;
		object obj = "not" + 120;
		string text = SFSExtensions.Get(json, (string)varName, (string)defaultValue);
		string text2 = (string)obj;
		if (!(text == (string)obj))
		{
			return;
		}
		List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
		if (popupsList != null)
		{
			List<object>.Enumerator enumerator = ((List<object>)(object)popupsList).GetEnumerator();
			object obj2 = (nint)0 + (nint)808;
			text2 = (string)obj2;
			if (!enumerator2.MoveNext())
			{
				enumerator2.Dispose();
				goto IL_008e;
			}
			NullReferenceException ex = new NullReferenceException();
			object obj3 = 0;
		}
		NullReferenceException ex2 = new NullReferenceException();
		bool flag = (nint)text2 != 1;
		NullReferenceException ex3 = ex2;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			object obj4 = (nint)0 + (nint)800;
			text2 = (string)obj4;
			enumerator2.Dispose();
			object obj5 = default(object);
			if (obj5 == null)
			{
				goto IL_008e;
			}
			OutOfMemoryException ex4 = new OutOfMemoryException();
			object obj3 = obj5;
			ex3 = (NullReferenceException)(object)ex4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223E700");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return;
		IL_008e:
		NotEnoughTicketsPopup.OpenPopup();
		ITrackEvent trackEvent = TrackerLibrary.FastTrackNotEnoughTickets(TrackingPlacement.InGame);
		object obj6 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		object obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X8_v11+E4]");
		bool flag2 = (nint)0 == 0;
		object obj8 = !flag2;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Tracker.DesignEvent(trackEvent);
	}

	public void ExitGame()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_012d: Expected O, but got I
		//IL_015d: Expected O, but got I4
		//IL_005e: Expected O, but got I4
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected O, but got Unknown
		//IL_00e1: Expected O, but got I4
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Expected O, but got Unknown
		object obj = typeof(Queue<string>) + 848;
		object obj2 = (nint)0 + (nint)2200;
		StopMatching();
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		bool isInLobby = sessionModel.IsInLobby;
		bool flag2 = !isInLobby;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			KGame.SendForfeitGame();
		}
		object obj6 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		object obj7 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
		game.ExitGame();
		ITrackEvent trackEvent = TrackerLibrary.FastTrackExitRoundClicked();
		object obj8 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X8_v4+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj10 = "___# Content push apply failed [{0}]: {1}" + 48;
		Tracker.DesignEvent(trackEvent);
		object obj11 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v15+E4]");
		if ((nint)0 != 0)
		{
			KLogger.LogAnalytics(obj10);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		KLogger.LogAnalytics(obj10);
	}

	public void MatchMe()
	{
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Expected O, but got Unknown
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_0238: Expected O, but got Unknown
		//IL_0145: Expected O, but got I
		//IL_015b: Expected O, but got I
		//IL_0175: Expected O, but got I4
		//IL_017e: Expected O, but got I4
		//IL_0187: Expected O, but got I4
		//IL_001e: Expected O, but got I
		//IL_0034: Expected O, but got I
		//IL_004c: Expected O, but got I4
		//IL_0055: Expected O, but got I4
		//IL_01c1: Expected O, but got I4
		//IL_01d2: Expected O, but got I4
		//IL_01f2: Expected O, but got I4
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00ac: Expected O, but got I
		//IL_00fd: Expected O, but got I4
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
		object obj2 = "___# Content push apply failed [{0}]: {1}" + 912;
		SFS.SendFindMatch(GameType.FastTrack);
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v4+E4]");
		object obj7;
		object obj4;
		object obj6;
		if ((nint)0 != 0)
		{
			KLogger.LogAnalytics(obj2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E89F4]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E89F4]");
			object obj5 = (nint)0 & (nint)1;
			bool flag = obj5 == null;
			obj6 = 0;
			obj7 = 0;
			if (!flag)
			{
				goto IL_0063;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			KLogger.LogAnalytics(obj2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E89F4]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E89F4]");
			object obj8 = (nint)0 & (nint)1;
			bool flag2 = obj8 == null;
			object obj9 = !flag2;
			obj6 = 0;
			obj7 = 0;
			if (obj9 != null)
			{
				goto IL_0063;
			}
		}
		_ = 1;
		GenericSoundAlbum genericSoundAlbum = this.genericSoundAlbum;
		bool flag3 = (object)this.genericSoundAlbum == null;
		object obj10 = !flag3;
		obj6 = obj7;
		obj4 = 1;
		if (obj10 != null)
		{
			goto IL_008c;
		}
		goto IL_01e0;
		IL_01f7:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		NullReferenceException trackEvent;
		Tracker.DesignEvent((ITrackEvent)trackEvent);
		return;
		IL_008c:
		object obj11 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		object obj12 = (nint)0 + (nint)2424;
		object obj13 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CFF124");
		SingleSound singleSound = default(SingleSound);
		SoundChannel.PlaySFXSound(singleSound);
		ITrackEvent trackEvent2 = TrackerLibrary.FastTrackNextRoundClicked();
		obj4 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X8_v6+E4]");
		bool flag4 = (nint)0 == 0;
		obj6 = 0;
		trackEvent = (NullReferenceException)trackEvent2;
		if (!flag4)
		{
			Tracker.DesignEvent(trackEvent2);
			return;
		}
		goto IL_01f7;
		IL_01e0:
		trackEvent = new NullReferenceException();
		obj13 = 0;
		goto IL_01f7;
		IL_0063:
		genericSoundAlbum = this.genericSoundAlbum;
		if ((object)this.genericSoundAlbum != null)
		{
			goto IL_008c;
		}
		goto IL_01e0;
	}

	public void StopMatching()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0040: Expected O, but got I
		//IL_0113: Expected I, but got O
		//IL_005d: Expected I, but got O
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected O, but got Unknown
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected O, but got Unknown
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected O, but got Unknown
		//IL_0176: Expected O, but got I4
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)2480;
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
		object obj4 = (nint)0 + (nint)1912;
		GameObject lifecycle = base.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(null, (IntPtr)obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)null, (IntPtr)obj4);
		object obj5 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
		object obj6 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		object obj7 = "___# Content push apply failed [{0}]: {1}" + 984;
		SFS.SendStopFindMatch(lifecycle, action, action2);
		object obj8 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v9+E4]");
		bool flag = (nint)0 == 0;
		object obj9 = !flag;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		KLogger.LogAnalytics(obj7);
		ITrackEvent trackEvent = TrackerLibrary.FastTrackEndMatchingFromGameClicked();
		object obj10 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v6+E4]");
		if ((nint)0 != 0)
		{
			Tracker.DesignEvent(trackEvent);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Tracker.DesignEvent(trackEvent);
	}

	public void PlayMoreWithNewTeammate()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00da: Expected O, but got I
		//IL_0104: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_01ee: Expected O, but got I
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Expected O, but got Unknown
		//IL_0197: Expected O, but got I4
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Expected O, but got Unknown
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Expected O, but got Unknown
		object obj = 152993792;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E89F1]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v22+E4]");
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
			object obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v22+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			object obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		goto IL_0133;
		IL_0133:
		SessionModel sessionModel = default(SessionModel);
		if (sessionModel.IsInLobby)
		{
			object obj8 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X0_v17+E4]");
			bool flag3 = (nint)0 == 0;
			object obj10 = !flag3;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj11 = "___# Content push apply failed [{0}]: {1}" + 832;
			KLogger.LogAnalytics(obj11);
			MatchMe();
			return;
		}
		KGame.RestartGame();
		object obj12 = (nint)0 + (nint)2424;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CFF124");
		SingleSound singleSound = default(SingleSound);
		SoundChannel.PlaySFXSound(singleSound);
		ITrackEvent trackEvent = TrackerLibrary.FastTrackContinueWithNewPlayerClicked();
		object obj13 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		object obj14 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v10+E4]");
		if ((nint)0 != 0)
		{
			Tracker.DesignEvent(trackEvent);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Tracker.DesignEvent(trackEvent);
		return;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag4 = (object)sessionModel == null;
		object obj15 = !flag4;
		if (obj15 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0133;
	}

	public void PlayMoreWithSameTeammate()
	{
		//IL_0009: Expected O, but got I4
		//IL_001f: Expected O, but got I
		//IL_014d: Expected O, but got I
		//IL_0163: Expected O, but got I
		//IL_017d: Expected O, but got I4
		//IL_0051: Expected O, but got I
		//IL_0067: Expected O, but got I
		//IL_01b7: Expected O, but got I4
		//IL_01c0: Expected O, but got I4
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_00cd: Expected O, but got I
		object obj = 152993792;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E89F2]");
		object obj2 = (nint)0 & (nint)1;
		object obj3;
		if (obj2 != null)
		{
			KGame.RestartGame();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E89F4]");
			obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E89F4]");
			object obj4 = (nint)0 & (nint)1;
			if (obj4 != null)
			{
				goto IL_0084;
			}
		}
		else
		{
			_ = 1;
			KGame.RestartGame();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E89F4]");
			obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E89F4]");
			object obj5 = (nint)0 & (nint)1;
			bool flag = obj5 == null;
			object obj6 = !flag;
			if (obj6 != null)
			{
				goto IL_0084;
			}
		}
		_ = 1;
		GenericSoundAlbum genericSoundAlbum = this.genericSoundAlbum;
		bool flag2 = (object)this.genericSoundAlbum == null;
		object obj7 = !flag2;
		obj3 = 1;
		if (obj7 != null)
		{
			goto IL_00ad;
		}
		goto IL_01ce;
		IL_01dc:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		NullReferenceException trackEvent;
		Tracker.DesignEvent((ITrackEvent)trackEvent);
		return;
		IL_00ad:
		object obj8 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		object obj9 = (nint)0 + (nint)2424;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CFF124");
		SingleSound singleSound = default(SingleSound);
		SoundChannel.PlaySFXSound(singleSound);
		ITrackEvent trackEvent2 = TrackerLibrary.FastTrackContinueWithSamePlayerClicked();
		obj3 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X8_v2+E4]");
		bool flag3 = (nint)0 == 0;
		trackEvent = (NullReferenceException)trackEvent2;
		if (!flag3)
		{
			Tracker.DesignEvent(trackEvent2);
			return;
		}
		goto IL_01dc;
		IL_01ce:
		trackEvent = new NullReferenceException();
		goto IL_01dc;
		IL_0084:
		genericSoundAlbum = this.genericSoundAlbum;
		if ((object)this.genericSoundAlbum != null)
		{
			goto IL_00ad;
		}
		goto IL_01ce;
	}

	public void NextStage()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00da: Expected O, but got I
		//IL_0104: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Expected O, but got Unknown
		//IL_01fb: Expected O, but got I4
		//IL_0226: Expected I4, but got I8
		//IL_0255: Expected I4, but got I8
		//IL_0285: Unknown result type (might be due to invalid IL or missing references)
		//IL_028a: Expected O, but got Unknown
		//IL_03a6: Expected O, but got I
		//IL_03c0: Expected O, but got I4
		//IL_0308: Expected O, but got I
		//IL_03fa: Expected O, but got I4
		//IL_035a: Expected O, but got I
		object obj = 152993792;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E89F3]");
		object obj3 = (nint)0 & (nint)1;
		object obj6;
		object obj4;
		if (obj3 != null)
		{
			obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v33+E4]");
			bool flag = (nint)0 == 0;
			obj6 = obj4;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v33+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		bool flag3 = (object)sessionModel == null;
		obj4 = obj6;
		if (!flag3)
		{
			goto IL_0158;
		}
		goto IL_0408;
		IL_0325:
		GenericSoundAlbum genericSoundAlbum = this.genericSoundAlbum;
		if ((object)this.genericSoundAlbum != null)
		{
			goto IL_034e;
		}
		goto IL_0408;
		IL_0408:
		NullReferenceException ex = new NullReferenceException();
		throw new IndexOutOfRangeException();
		IL_034e:
		object obj8 = (nint)0 + (nint)2424;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CFF124");
		SingleSound singleSound = default(SingleSound);
		SoundChannel.PlaySFXSound(singleSound);
		FastTrack.SendRequestNextStage();
		return;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag4 = (object)sessionModel == null;
		object obj9 = !flag4;
		if (obj9 != null)
		{
			goto IL_0158;
		}
		goto IL_0408;
		IL_0158:
		User localUser = sessionModel.LocalUser;
		int fTLevel = SFSKammelnaUserExtensions.GetFTLevel(localUser);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel2 = default(SessionModel);
		if ((object)sessionModel2 != null)
		{
			object obj10 = typeof(System.Buffers.Text.ParserHelpers) + 1064;
			User localUser2 = sessionModel2.LocalUser;
			int fTStage = SFSKammelnaUserExtensions.GetFTStage(localUser2);
			object obj11 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X0_v12+E4]");
			bool flag5 = (nint)0 == 0;
			object obj12 = !flag5;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int[] nearestFTAwardStage = PlayerRank.GetNearestFTAwardStage(-1);
			if (nearestFTAwardStage != null)
			{
				int[] nearestFTAwardStage2 = PlayerRank.GetNearestFTAwardStage(-1);
				if (nearestFTAwardStage2 != null)
				{
					object obj13 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
					ITrackEvent trackEvent = TrackerLibrary.FastTrackNextStageClicked(TrackingPlacement.InGame, fTLevel, fTStage, nearestFTAwardStage[0], nearestFTAwardStage2[1]);
					object obj14 = obj13;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X8_v8+E4]");
					if ((nint)0 != 0)
					{
						Tracker.DesignEvent(trackEvent);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E89F4]");
						object obj15 = (nint)0 & (nint)1;
						if (obj15 != null)
						{
							goto IL_0325;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						Tracker.DesignEvent(trackEvent);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E89F4]");
						object obj16 = (nint)0 & (nint)1;
						bool flag6 = obj16 == null;
						object obj17 = !flag6;
						if (obj17 != null)
						{
							goto IL_0325;
						}
					}
					_ = 1;
					genericSoundAlbum = this.genericSoundAlbum;
					bool flag7 = (object)this.genericSoundAlbum == null;
					object obj18 = !flag7;
					if (obj18 != null)
					{
						goto IL_034e;
					}
				}
			}
		}
		goto IL_0408;
	}

	public void ClaimRank(bool alsoExitGame)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00da: Expected O, but got I
		//IL_0104: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Expected O, but got Unknown
		//IL_01fb: Expected O, but got I4
		//IL_0226: Expected I4, but got I8
		//IL_0255: Expected I4, but got I8
		//IL_0285: Unknown result type (might be due to invalid IL or missing references)
		//IL_028a: Expected O, but got Unknown
		//IL_03e6: Expected O, but got I4
		//IL_034e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0353: Expected O, but got Unknown
		//IL_037d: Expected O, but got I4
		//IL_03a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a9: Expected O, but got Unknown
		object obj = 152993792;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E89B7]");
		object obj3 = (nint)0 & (nint)1;
		object obj6;
		object obj4;
		if (obj3 != null)
		{
			obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v31+E4]");
			bool flag = (nint)0 == 0;
			obj6 = obj4;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v31+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		bool flag3 = (object)sessionModel == null;
		obj4 = obj6;
		if (!flag3)
		{
			goto IL_0158;
		}
		goto IL_03f5;
		IL_03f5:
		NullReferenceException ex = new NullReferenceException();
		throw new IndexOutOfRangeException();
		IL_0158:
		User localUser = sessionModel.LocalUser;
		int fTLevel = SFSKammelnaUserExtensions.GetFTLevel(localUser);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel2 = default(SessionModel);
		if ((object)sessionModel2 != null)
		{
			object obj8 = typeof(System.Buffers.Text.ParserHelpers) + 1064;
			User localUser2 = sessionModel2.LocalUser;
			int fTStage = SFSKammelnaUserExtensions.GetFTStage(localUser2);
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X0_v12+E4]");
			bool flag4 = (nint)0 == 0;
			object obj10 = !flag4;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int[] nearestFTAwardStage = PlayerRank.GetNearestFTAwardStage(-1);
			if (nearestFTAwardStage != null)
			{
				int[] nearestFTAwardStage2 = PlayerRank.GetNearestFTAwardStage(-1);
				if (nearestFTAwardStage2 != null)
				{
					object obj11 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
					ITrackEvent trackEvent = TrackerLibrary.FastTrackClaimRankClicked(TrackingPlacement.InGame, fTLevel, fTStage, nearestFTAwardStage[0], nearestFTAwardStage2[1]);
					object obj12 = obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v8+E4]");
					if ((nint)0 != 0)
					{
						Tracker.DesignEvent(trackEvent);
						FastTrack.SendRequestClaim();
						if (!alsoExitGame)
						{
							return;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						Tracker.DesignEvent(trackEvent);
						FastTrack.SendRequestClaim();
						bool flag5 = !alsoExitGame;
						object obj13 = !flag5;
						if (obj13 == null)
						{
							return;
						}
					}
					if ((object)game != null)
					{
						game.ExitGame();
						object obj14 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
						object obj15 = obj14;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X0_v26+E4]");
						bool flag6 = (nint)0 == 0;
						object obj16 = !flag6;
						if (obj16 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						object obj17 = "___# Content push apply failed [{0}]: {1}" + 48;
						KLogger.LogAnalytics(obj17);
						return;
					}
				}
			}
		}
		goto IL_03f5;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag7 = (object)sessionModel == null;
		object obj18 = !flag7;
		if (obj18 != null)
		{
			goto IL_0158;
		}
		goto IL_03f5;
	}

	private void PlaySound()
	{
		//IL_0011: Expected O, but got I
		object obj = (nint)0 + (nint)2424;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CFF124");
		SingleSound singleSound = default(SingleSound);
		SoundChannel.PlaySFXSound(singleSound);
	}
}
