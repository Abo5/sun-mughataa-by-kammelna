using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Diagnostics;
using System.Formats.Asn1;
using Cpp2ILInjected;
using DataTracking;
using Kammelna.Server;
using ListView;
using Mono.Btls;
using Server.Models;
using Sfs2X.Entities;
using TMPro;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class RoomCard : ListViewItem<RoomDataHolder, int>
{
	private sealed class <>c__DisplayClass20_0
	{
		public RoomCard <>4__this;

		public int seatIndex;

		public int roomId;

		internal void <OnJoinRoomTeamClick>b__0(string password)
		{
			DoJoin(roomId, seatIndex, password);
		}
	}

	private sealed class <>c__DisplayClass21_0
	{
		public RoomCard <>4__this;

		public int roomId;

		internal void <OnWatchRoomClick>b__0(string password)
		{
			DoWatch(roomId, password);
		}
	}

	public TextMeshProUGUI Team1Points;

	public TextMeshProUGUI Team2Points;

	public TextMeshProUGUI gameTitle;

	public Image ThemeBorder;

	public Image DefaultBorder;

	private RoomInfoIcons roomInfoIcons;

	private RankSprites rankSprites;

	private Sprite passwordIcon;

	private AvatarInitializer[] avatarInitializer;

	private Button[] joinbutton;

	private ThemeProvider _themeProvider;

	private TextMeshProUGUI RankText;

	private int roomThemeId;

	protected GameRoomData room
	{
		get
		{
			//IL_0030: Expected O, but got I
			//IL_0012: Expected O, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (RoomCard)+40]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (RoomCard)+40]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X8_v3+10]");
				return (GameRoomData)0;
			}
			return (GameRoomData)(object)new NullReferenceException();
		}
	}

	protected virtual void Awake()
	{
		//IL_0019: Expected O, but got I4
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected O, but got Unknown
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected O, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		AvatarInitializer[] array = avatarInitializer;
		object obj = array.Length;
		if (array.Length >= 1)
		{
			object obj2 = array + 32;
			do
			{
				object obj3 = obj2;
				obj2 += 8;
				_ = 5;
				obj--;
			}
			while ((nint)obj != 1);
		}
	}

	public override void Setup(RoomDataHolder datum, bool firstTime)
	{
		//IL_001a: Expected O, but got I
		//IL_0048: Expected O, but got I
		//IL_005b: Expected I, but got O
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (RoomCard)+40]");
		if (datum.Equals(0))
		{
			return;
		}
		object obj = (nint)0 + (nint)1992;
		((ListViewItem<object, int>)(object)this).Setup((object)datum, firstTime);
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v82 @ X8_v6 (Il2CppClass<RoomCard>)+328] (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	protected unsafe virtual void Refresh()
	{
		//IL_0009: Expected O, but got I4
		//IL_001f: Expected O, but got I
		//IL_00f0: Expected O, but got I
		//IL_010a: Expected O, but got I4
		//IL_0095: Expected O, but got I
		//IL_00b7: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_013a: Expected O, but got I
		//IL_13c9: Expected O, but got I
		//IL_01d5: Expected I, but got O
		//IL_01e5: Expected O, but got I
		//IL_01f5: Expected O, but got I
		//IL_0e59: Expected O, but got I
		//IL_1147: Expected O, but got I
		//IL_0ebb: Expected O, but got I
		//IL_0ed2: Expected I, but got O
		//IL_0ee2: Expected O, but got I
		//IL_0ef2: Expected O, but got I
		//IL_0f2c: Expected O, but got I
		//IL_0281: Expected I, but got O
		//IL_0291: Expected O, but got I
		//IL_02a1: Expected O, but got I
		//IL_0f42: Expected I, but got O
		//IL_0f69: Expected O, but got I
		//IL_117c: Expected O, but got I
		//IL_0ff4: Expected O, but got I4
		//IL_02c5: Expected O, but got I
		//IL_1063: Expected I, but got O
		//IL_1073: Expected O, but got I
		//IL_1024: Expected O, but got I
		//IL_13fe: Expected O, but got I
		//IL_1425: Expected O, but got I
		//IL_02f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fe: Expected O, but got Unknown
		//IL_030a: Expected O, but got I
		//IL_031a: Expected O, but got I
		//IL_0344: Expected O, but got I4
		//IL_1059: Expected O, but got I4
		//IL_108f: Expected O, but got I
		//IL_10b6: Expected O, but got I
		//IL_10db: Expected O, but got I
		//IL_1443: Expected O, but got I
		//IL_146a: Expected O, but got I
		//IL_1473: Expected O, but got I4
		//IL_03e3: Expected O, but got I4
		//IL_03f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f5: Expected O, but got Unknown
		//IL_0420: Unknown result type (might be due to invalid IL or missing references)
		//IL_0425: Expected O, but got Unknown
		//IL_1101: Expected O, but got I
		//IL_110a: Expected O, but got I4
		//IL_11b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_11b5: Expected O, but got Unknown
		//IL_11c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_11c9: Expected O, but got Unknown
		//IL_11d5: Expected O, but got I
		//IL_11e6: Expected O, but got I4
		//IL_112f: Expected O, but got I
		//IL_120b: Expected O, but got I
		//IL_12fc: Expected O, but got I
		//IL_048f: Expected O, but got I
		//IL_067e: Expected O, but got I
		//IL_0902: Expected O, but got I4
		//IL_091d: Expected O, but got I4
		//IL_0927: Unknown result type (might be due to invalid IL or missing references)
		//IL_092c: Expected O, but got Unknown
		//IL_0954: Unknown result type (might be due to invalid IL or missing references)
		//IL_0959: Expected O, but got Unknown
		//IL_070c: Expected O, but got I
		//IL_079a: Expected O, but got I
		//IL_07bb: Expected O, but got I4
		//IL_07cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d0: Expected O, but got Unknown
		//IL_07fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0803: Expected O, but got Unknown
		//IL_09de: Expected O, but got I
		//IL_084a: Unknown result type (might be due to invalid IL or missing references)
		//IL_084f: Expected O, but got Unknown
		//IL_0a3b: Expected O, but got I4
		//IL_0896: Expected O, but got I
		//IL_08f2: Expected O, but got I
		//IL_0a53: Expected O, but got I4
		//IL_0a6e: Expected O, but got I4
		//IL_0a78: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a7d: Expected O, but got Unknown
		//IL_0aa5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aaa: Expected O, but got Unknown
		//IL_0b11: Expected O, but got I4
		//IL_0b30: Expected O, but got I
		//IL_0b4d: Expected O, but got I4
		//IL_0b91: Expected O, but got I4
		//IL_0b9a: Expected O, but got I4
		//IL_0555: Unknown result type (might be due to invalid IL or missing references)
		//IL_055a: Expected O, but got Unknown
		//IL_0574: Expected O, but got I4
		//IL_057d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0582: Expected O, but got Unknown
		//IL_05a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ae: Expected O, but got Unknown
		//IL_0bd5: Expected O, but got I4
		//IL_0bed: Expected O, but got I4
		//IL_0c08: Expected O, but got I4
		//IL_0c12: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c17: Expected O, but got Unknown
		//IL_0c3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c44: Expected O, but got Unknown
		//IL_138a: Expected O, but got I
		//IL_13ab: Expected O, but got I4
		//IL_0caf: Expected O, but got I
		//IL_0cd0: Expected O, but got I4
		//IL_0cee: Expected O, but got I
		//IL_0d0f: Expected O, but got I4
		//IL_0d2d: Expected O, but got I
		//IL_0d4e: Expected O, but got I4
		//IL_0d5e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d63: Expected O, but got Unknown
		//IL_0d91: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d96: Expected O, but got Unknown
		//IL_0ddd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0de2: Expected O, but got Unknown
		//IL_0df3: Expected O, but got I
		//IL_0e13: Expected O, but got I4
		//IL_0e1d: Expected O, but got I4
		//IL_052e: Expected O, but got I
		//IL_0547: Expected O, but got I4
		object obj = 152989696;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7A57]");
		object obj2 = (nint)0 & (nint)1;
		TextMeshProUGUI textMeshProUGUI;
		TextMeshProUGUI team1Points;
		if (obj2 != null)
		{
			textMeshProUGUI = Team1Points;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7A56]");
			object obj3 = (nint)0 & (nint)1;
			bool flag = obj3 == null;
			team1Points = Team1Points;
			if (!flag)
			{
				goto IL_0085;
			}
		}
		else
		{
			_ = 1;
			textMeshProUGUI = Team1Points;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7A56]");
			object obj4 = (nint)0 & (nint)1;
			bool flag2 = obj4 == null;
			object obj5 = !flag2;
			team1Points = Team1Points;
			if (obj5 != null)
			{
				goto IL_0085;
			}
		}
		_ = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (RoomCard)+40]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (RoomCard)+40]");
		bool flag3 = (nint)0 == 0;
		textMeshProUGUI = team1Points;
		if (!flag3)
		{
			goto IL_0167;
		}
		goto IL_0e2c;
		IL_11a1:
		object obj7 = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 2624;
		object obj8 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
		object obj9 = (nint)0 + (nint)2000;
		bool flag5 = default(bool);
		bool flag4 = flag5;
		object obj10 = 0;
		object obj12;
		object obj11 = obj12;
		object obj14;
		object obj13 = obj14;
		bool flag6;
		bool flag9;
		object obj17;
		object obj19;
		object obj21;
		bool flag11;
		bool flag13;
		object obj23;
		object obj25;
		while (true)
		{
			bool flag8;
			object obj16;
			object obj18;
			object obj20;
			bool flag10;
			bool flag12;
			object obj22;
			object obj24;
			if (flag6)
			{
				flag5 = true;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (RoomCard)+40]");
				object obj15 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (RoomCard)+40]");
				bool flag7 = (nint)0 == 0;
				flag5 = flag4;
				flag8 = flag9;
				obj16 = obj17;
				obj18 = obj19;
				obj20 = obj21;
				flag10 = flag11;
				flag12 = flag13;
				obj22 = obj23;
				obj24 = obj25;
				obj12 = obj11;
				obj14 = obj13;
				if (flag7)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ X8_v56+10]");
				object obj26 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ X8_v56+10]");
				bool flag14 = (nint)0 == 0;
				flag5 = flag4;
				flag8 = flag9;
				obj16 = obj17;
				obj18 = obj19;
				obj20 = obj21;
				flag10 = flag11;
				flag12 = flag13;
				obj22 = obj23;
				obj24 = obj25;
				obj12 = obj11;
				obj14 = obj13;
				if (flag14)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ X8_v57+40]");
				object obj27 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ X8_v57+40]");
				bool flag15 = (nint)0 == 0;
				flag5 = flag4;
				flag8 = flag9;
				obj16 = obj17;
				obj18 = obj19;
				obj20 = obj21;
				flag10 = flag11;
				flag12 = flag13;
				obj22 = obj23;
				obj24 = obj25;
				obj12 = obj11;
				obj14 = obj13;
				if (flag15)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ X8_v58+18]");
				obj14 = 0;
				object obj28 = obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ X8_v58+18]");
				bool flag16 = (nint)obj28 < 0;
				obj24 = !flag16;
				object obj29 = obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ X8_v58+18]");
				obj22 = obj29 - 0;
				flag12 = (nint)obj22 < 0;
				flag10 = obj22 == null;
				object obj30 = obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ X8_v58+18]");
				obj20 = obj30 ^ 0;
				obj18 = obj10 ^ obj22;
				obj16 = obj20 & obj18;
				flag8 = (nint)obj16 < 0;
				if (obj24 != null)
				{
					goto IL_1130;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ X8_v57+40]");
				object obj31 = 0 + obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X8_v59+20]");
				bool flag17 = (nint)0 == 0;
				flag5 = flag4;
				obj12 = obj11;
				if (flag17)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X8_v59+20]");
				bool isHuman = ((PlayerInfo)0).IsHuman;
				flag5 = isHuman;
				flag9 = flag8;
				obj17 = obj16;
				obj19 = obj18;
				obj21 = obj20;
				flag11 = flag10;
				flag13 = flag12;
				obj23 = obj22;
				obj25 = obj24;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ X8_v58+18]");
				obj13 = 0;
			}
			AvatarInitializer[] array = avatarInitializer;
			bool flag18 = avatarInitializer == null;
			flag8 = flag9;
			obj16 = obj17;
			obj18 = obj19;
			obj20 = obj21;
			flag10 = flag11;
			flag12 = flag13;
			obj22 = obj23;
			obj24 = obj25;
			obj12 = obj11;
			obj14 = obj13;
			if (flag18)
			{
				break;
			}
			obj14 = array.Length;
			bool flag19 = (nint)obj10 < array.Length;
			obj24 = !flag19;
			obj22 = obj10 - array.Length;
			flag12 = (nint)obj22 < 0;
			flag10 = obj22 == null;
			obj20 = obj10 ^ array.Length;
			obj18 = obj10 ^ obj22;
			obj16 = obj20 & obj18;
			flag8 = (nint)obj16 < 0;
			if (obj24 == null)
			{
				object obj32 = (object)avatarInitializer + obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ X8_v43+20]");
				bool flag20 = (nint)0 == 0;
				obj12 = obj11;
				if (flag20)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ X8_v43+20]");
				GameObject gameObject = ((Component)0).gameObject;
				bool flag21 = (object)gameObject == null;
				obj12 = obj11;
				if (flag21)
				{
					break;
				}
				gameObject.SetActive(flag5);
				Button[] array2 = joinbutton;
				bool flag22 = joinbutton == null;
				obj12 = 0;
				if (flag22)
				{
					break;
				}
				obj14 = array2.Length;
				bool flag23 = (nint)obj10 < array2.Length;
				obj24 = !flag23;
				obj22 = obj10 - array2.Length;
				flag12 = (nint)obj22 < 0;
				flag10 = obj22 == null;
				obj20 = obj10 ^ array2.Length;
				obj18 = obj10 ^ obj22;
				obj16 = obj20 & obj18;
				flag8 = (nint)obj16 < 0;
				if (obj24 == null)
				{
					object obj33 = (object)joinbutton + obj10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X8_v45+20]");
					bool flag24 = (nint)0 == 0;
					obj12 = 0;
					if (flag24)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X8_v45+20]");
					GameObject gameObject2 = ((Component)0).gameObject;
					bool flag25 = (object)gameObject2 == null;
					obj12 = 0;
					if (flag25)
					{
						break;
					}
					flag4 = (byte)((flag5 ? 1u : 0u) ^ 1u) != 0;
					gameObject2.SetActive(flag4);
					bool flag26 = !flag4;
					object obj34 = !flag26;
					obj11 = 0;
					if (obj34 != null)
					{
						goto IL_054c;
					}
					AvatarInitializer[] array3 = avatarInitializer;
					bool flag27 = avatarInitializer == null;
					flag5 = flag4;
					obj12 = 0;
					if (flag27)
					{
						break;
					}
					obj14 = array3.Length;
					bool flag28 = (nint)obj10 < array3.Length;
					obj24 = !flag28;
					obj22 = obj10 - array3.Length;
					flag12 = (nint)obj22 < 0;
					flag10 = obj22 == null;
					obj20 = obj10 ^ array3.Length;
					obj18 = obj10 ^ obj22;
					obj16 = obj20 & obj18;
					flag8 = (nint)obj16 < 0;
					if (obj24 == null)
					{
						object obj35 = (object)avatarInitializer + obj10;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v609 @ X8_v47+20]");
						flag5 = false;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (RoomCard)+40]");
						object obj36 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (RoomCard)+40]");
						bool flag29 = (nint)0 == 0;
						obj12 = 0;
						if (flag29)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ X8_v49+10]");
						object obj37 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ X8_v49+10]");
						bool flag30 = (nint)0 == 0;
						obj12 = 0;
						if (flag30)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X8_v50+40]");
						object obj38 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X8_v50+40]");
						bool flag31 = (nint)0 == 0;
						obj12 = 0;
						if (flag31)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ X8_v51+18]");
						obj14 = 0;
						object obj39 = obj10;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ X8_v51+18]");
						bool flag32 = (nint)obj39 < 0;
						obj24 = !flag32;
						object obj40 = obj10;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ X8_v51+18]");
						obj22 = obj40 - 0;
						flag12 = (nint)obj22 < 0;
						flag10 = obj22 == null;
						object obj41 = obj10;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ X8_v51+18]");
						obj20 = obj41 ^ 0;
						obj18 = obj10 ^ obj22;
						obj16 = obj20 & obj18;
						flag8 = (nint)obj16 < 0;
						if (obj24 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X8_v50+40]");
							object obj42 = 0 + obj10;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X8_v52+20]");
							AvatarData avatarData = (PlayerInfo)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v609 @ X8_v47+20]");
							bool flag33 = (byte)(~(nuint)0u) != 0;
							object obj43 = !flag33;
							obj12 = 0;
							if (obj43 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v609 @ X8_v47+20]");
								((AvatarInitializer)0).Initialize(avatarData);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v609 @ X8_v47+20]");
								flag4 = false;
								obj11 = 0;
								goto IL_054c;
							}
							break;
						}
					}
				}
			}
			goto IL_1130;
			IL_1130:
			throw new IndexOutOfRangeException();
			IL_054c:
			obj10++;
			bool flag34 = (nint)obj10 < 4;
			obj25 = !flag34;
			obj23 = obj10 - 4;
			flag13 = (nint)obj23 < 0;
			flag11 = (nint)obj10 == 4;
			obj21 = obj10 ^ 4;
			obj19 = obj10 ^ obj23;
			obj17 = obj21 & obj19;
			flag9 = (nint)obj17 < 0;
			obj13 = obj14;
			flag5 = flag4;
			flag8 = flag9;
			obj16 = obj17;
			obj18 = obj19;
			obj20 = obj21;
			flag10 = flag11;
			flag12 = flag13;
			obj22 = obj23;
			obj24 = obj25;
			obj12 = obj11;
			if (!flag11)
			{
				continue;
			}
			goto IL_0e3a;
		}
		goto IL_0e2c;
		IL_0e2c:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0e3a;
		IL_1003:
		bool flag35 = (object)RankText == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X8_v6+4C]");
		object obj44 = 0;
		if (flag35)
		{
			goto IL_0e2c;
		}
		string text = RankText.text;
		TextMeshProExtensions.Localize(RankText, text);
		obj12 = 0;
		goto IL_105e;
		IL_0085:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (RoomCard)+40]");
		obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (RoomCard)+40]");
		bool flag36 = (nint)0 == 0;
		object obj45 = !flag36;
		if (obj45 != null)
		{
			goto IL_0167;
		}
		goto IL_0e2c;
		IL_0167:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v25+10]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v25+10]");
			int num = (int)((nint)0 + (nint)52);
			string text2 = ((int*)num)->ToString();
			if ((object)textMeshProUGUI != null)
			{
				nint num2 = (nint)textMeshProUGUI;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v393 @ X8_v27 (Il2CppClass<TMPro.TextMeshProUGUI>)+558]");
				obj14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v393 @ X8_v27 (Il2CppClass<TMPro.TextMeshProUGUI>)+560]");
				obj12 = 0;
				textMeshProUGUI.text = text2;
				TextMeshProUGUI team2Points = Team2Points;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (RoomCard)+40]");
				object obj46 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (RoomCard)+40]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X8_v30+10]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X8_v30+10]");
						int num3 = (int)((nint)0 + (nint)56);
						string text3 = ((int*)num3)->ToString();
						if ((object)Team2Points != null)
						{
							nint num4 = (nint)team2Points;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ X8_v32 (Il2CppClass<TMPro.TextMeshProUGUI>)+558]");
							obj14 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ X8_v32 (Il2CppClass<TMPro.TextMeshProUGUI>)+560]");
							obj12 = 0;
							Team2Points.text = text3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (RoomCard)+40]");
							object obj47 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (RoomCard)+40]");
							if ((nint)0 != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ X8_v35+10]");
								object obj48 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ X8_v35+10]");
								if ((nint)0 != 0)
								{
									obj14 = typeof(Queue<string>) + 848;
									object obj49 = (nint)0 + (nint)2200;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ X8_v36+4C]");
									obj9 = 0;
									object obj50 = obj14;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v440 @ X0_v48+E4]");
									bool flag37 = (nint)0 == 0;
									object obj51 = !flag37;
									if (obj51 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
									SessionModel sessionModel = default(SessionModel);
									if ((object)sessionModel != null)
									{
										User localUser = sessionModel.LocalUser;
										PlayerRank rank = SFSKammelnaUserExtensions.GetRank(localUser);
										if (rank != null)
										{
											bool flag38 = (nint)obj9 < (nint)rank.<Rank>k__BackingField;
											obj25 = !flag38;
											obj23 = obj9 - rank.<Rank>k__BackingField;
											flag13 = (nint)obj23 < 0;
											flag11 = obj23 == null;
											obj21 = obj9 ^ rank.<Rank>k__BackingField;
											obj19 = obj9 ^ obj23;
											obj17 = obj21 & obj19;
											flag9 = (nint)obj17 < 0;
											bool flag39 = (nint)obj9 > (nint)rank.<Rank>k__BackingField;
											flag6 = true;
											if (flag39)
											{
												goto IL_11a1;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (RoomCard)+40]");
											object obj52 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (RoomCard)+40]");
											bool flag40 = (nint)0 == 0;
											bool flag8 = flag9;
											object obj16 = obj17;
											object obj18 = obj19;
											object obj20 = obj21;
											bool flag10 = flag11;
											bool flag12 = flag13;
											object obj22 = obj23;
											object obj24 = obj25;
											if (!flag40)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X8_v62+10]");
												object obj53 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X8_v62+10]");
												bool flag41 = (nint)0 == 0;
												flag8 = flag9;
												obj16 = obj17;
												obj18 = obj19;
												obj20 = obj21;
												flag10 = flag11;
												flag12 = flag13;
												obj22 = obj23;
												obj24 = obj25;
												if (!flag41)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X8_v63+48]");
													bool flag42 = GameTypeExtensions.IsRanked(GameType.Friendly);
													flag6 = flag42;
													goto IL_11a1;
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
		}
		goto IL_0e2c;
		IL_105e:
		nint num5 = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v462 @ X8_v12 (Il2CppClass<RoomCard>)+338]");
		obj14 = 0;
		RefreshRoomThemeBorder();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (RoomCard)+40]");
		object obj54 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (RoomCard)+40]");
		bool flag43 = (nint)0 == 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X8_v6+4C]");
		obj44 = 0;
		if (!flag43)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ X8_v15+10]");
			object obj55 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ X8_v15+10]");
			bool flag44 = (nint)0 == 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X8_v6+4C]");
			obj44 = 0;
			if (!flag44)
			{
				TextMeshProUGUI textMesh = gameTitle;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v338 @ X8_v16+28]");
				TextMeshProExtensions.FixArabic(textMesh, (string)0);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (RoomCard)+40]");
				object obj56 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (RoomCard)+40]");
				bool flag45 = (nint)0 == 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X8_v6+4C]");
				obj44 = 0;
				obj12 = 0;
				if (!flag45)
				{
					bool flag46 = (object)roomInfoIcons == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X8_v6+4C]");
					obj44 = 0;
					obj12 = 0;
					if (!flag46)
					{
						RoomInfoIcons obj57 = roomInfoIcons;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ X8_v19+10]");
						obj57.UpdateIcons((GameRoomData)0);
						return;
					}
				}
			}
		}
		goto IL_0e2c;
		IL_0e3a:
		TextMeshProUGUI rankText = RankText;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (RoomCard)+40]");
		object obj58 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (RoomCard)+40]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ X8_v5+10]");
			object obj59 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ X8_v5+10]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
				Enum enumeration = default(Enum);
				string friendlyName = EnumExtensions.GetFriendlyName(enumeration);
				bool flag47 = (object)RankText == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X8_v6+4C]");
				obj44 = 0;
				if (!flag47)
				{
					nint num6 = (nint)rankText;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ X8_v8 (Il2CppClass<TMPro.TextMeshProUGUI>)+558]");
					obj14 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ X8_v8 (Il2CppClass<TMPro.TextMeshProUGUI>)+560]");
					obj12 = 0;
					RankText.text = friendlyName;
					TextMeshProUGUI rankText2 = RankText;
					bool flag48 = (object)RankText == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X8_v6+4C]");
					obj44 = 0;
					if (!flag48)
					{
						nint num7 = (nint)rankText2;
						string text4 = RankText.text;
						object obj60 = obj8;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ X8_v10+E4]");
						obj14 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ X8_v10+E4]");
						if ((nint)0 != 0)
						{
							if (!StringsExtensions.IsNullOrEmpty(text4))
							{
								goto IL_1003;
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							bool flag49 = StringsExtensions.IsNullOrEmpty(text4);
							bool flag50 = !flag49;
							object obj61 = !flag50;
							if (obj61 == null)
							{
								goto IL_1003;
							}
						}
						goto IL_105e;
					}
				}
			}
		}
		goto IL_0e2c;
	}

	protected virtual void RefreshRoomThemeBorder()
	{
		//IL_0016: Expected O, but got I
		//IL_00c7: Expected O, but got I
		//IL_00e1: Expected O, but got I4
		//IL_0076: Expected O, but got I
		//IL_0098: Expected O, but got I4
		//IL_0049: Expected O, but got I
		//IL_011b: Expected O, but got I
		//IL_0105: Expected O, but got I
		//IL_02ed: Expected O, but got I
		//IL_014e: Expected O, but got I
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Expected O, but got Unknown
		//IL_0191: Expected O, but got I4
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Expected O, but got Unknown
		//IL_0274: Expected O, but got I
		//IL_0282: Expected I, but got O
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7A58]");
		object obj = (nint)0 & (nint)1;
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7A56]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				goto IL_0066;
			}
		}
		else
		{
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7A56]");
			object obj3 = (nint)0 & (nint)1;
			bool flag = obj3 == null;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0066;
			}
		}
		_ = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (RoomCard)+40]");
		object obj5 = 0;
		goto IL_010a;
		IL_010a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v3+10]");
		if (((GameRoomData)0).HasTheme)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (RoomCard)+40]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v7+10]");
			object obj7 = 0;
			object obj8 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X0_v9+E4]");
			bool flag2 = (nint)0 == 0;
			object obj10 = !flag2;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X8_v8+30]");
			StoreItem storeItem = Store.GetStoreItem(0);
			if (GamesFlagExtensions.MatchesCurrentGame(storeItem.<targetGames>k__BackingField))
			{
				int num = roomThemeId;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X8_v8+30]");
				if ((nint)num != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X8_v8+30]");
					roomThemeId = 0;
					ThemeBorder.enabled = false;
					object obj11 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj12 = (nint)0 + (nint)2888;
					Action<bool> action = default(Action<bool>);
					action..ctor((object)this, (IntPtr)obj12);
					Image themeBorder = ThemeBorder;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X8_v8+30]");
					UIExtensions.LoadItemImage(themeBorder, 0, ImageCacher.ItemImageType.StoreTitle, FilterMode.Point, action);
				}
				GameObject gameObject = DefaultBorder.gameObject;
				gameObject.SetActive(value: false);
				return;
			}
		}
		ApplyDefaultThemeBorder();
		return;
		IL_0066:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (RoomCard)+40]");
		obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (RoomCard)+40]");
		bool flag3 = (nint)0 == 0;
		object obj13 = !flag3;
		if (obj13 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_010a;
	}

	protected void ApplyDefaultThemeBorder()
	{
		ThemeBorder.enabled = false;
		roomThemeId = 0;
		GameObject gameObject = DefaultBorder.gameObject;
		gameObject.SetActive(value: true);
		_themeProvider.UpdateTheme(null);
	}

	public void OnJoinRoomTeamClick(int teamIndex)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_003f: Expected O, but got I4
		//IL_03cb: Expected O, but got I
		//IL_0059: Expected O, but got I
		//IL_0070: Expected O, but got I4
		//IL_03e0: Expected O, but got I
		//IL_00a2: Expected O, but got I
		//IL_00c9: Expected O, but got I4
		//IL_03f5: Expected O, but got I
		//IL_011b: Expected O, but got I
		//IL_012c: Expected O, but got I
		//IL_0169: Expected O, but got I
		//IL_0183: Expected O, but got I4
		//IL_040a: Expected O, but got I
		//IL_0106: Expected O, but got I4
		//IL_01ac: Expected O, but got I
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Expected O, but got Unknown
		//IL_01e8: Expected O, but got I
		//IL_01f9: Expected I, but got O
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Expected O, but got Unknown
		//IL_02f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f8: Expected O, but got Unknown
		//IL_0316: Expected O, but got I
		//IL_0330: Expected O, but got I4
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_024e: Expected O, but got Unknown
		//IL_026c: Expected O, but got I
		//IL_0376: Expected O, but got I4
		object obj = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 2080;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = 152989696;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (RoomCard)+40]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X8_v6+10]");
		int firstJoinableSeatForTeam = ((GameRoomData)0).GetFirstJoinableSeatForTeam(teamIndex);
		object obj6 = firstJoinableSeatForTeam + 1;
		if (obj6 == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (RoomCard)+40]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v9+10]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v10+58]");
		bool flag = (nint)0 != 1;
		RoomCard roomCard = (RoomCard)firstJoinableSeatForTeam;
		Action<object> action = default(Action<object>);
		object obj15;
		string text;
		string text2;
		object obj22;
		if (!flag)
		{
			bool flag2 = CanBypassLock();
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7A56]");
				object obj9 = (nint)0 & (nint)1;
				bool flag3 = obj9 == null;
				object obj10 = !flag3;
				if (obj10 == null)
				{
					_ = 1;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (RoomCard)+40]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X8_v19+10]");
				object obj12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v20+10]");
				_ = 0;
				object obj13 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj14 = (nint)0 + (nint)864;
				action..ctor(obj2, (IntPtr)obj14);
				obj15 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
				object obj16 = obj15;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X0_v19+E4]");
				if ((nint)0 != 0)
				{
					object obj17 = "LAK" + 2296;
					text = (string)obj17;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7A46]");
					object obj18 = (nint)0 & (nint)1;
					bool flag4 = obj18 == null;
					text2 = (string)obj17;
					if (!flag4)
					{
						goto IL_0291;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj19 = "LAK" + 2296;
					text = (string)obj19;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7A46]");
					object obj20 = (nint)0 & (nint)1;
					bool flag5 = obj20 == null;
					object obj21 = !flag5;
					text2 = (string)obj19;
					if (obj21 != null)
					{
						goto IL_0291;
					}
				}
				_ = 1;
				obj22 = obj15;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ X0_v20+E4]");
				bool flag6 = (nint)0 == 0;
				object obj23 = !flag6;
				text = text2;
				if (obj23 != null)
				{
					goto IL_02c6;
				}
				goto IL_038c;
			}
			roomCard = (RoomCard)flag2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (RoomCard)+40]");
		object obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X8_v13+10]");
		object obj25 = 0;
		object password = (nint)0 + (nint)2000;
		RoomCard roomCard2 = roomCard;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X8_v14+10]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3 (System.Object)+18]");
		roomCard2.DoJoin((int)num, 0, (string)password);
		return;
		IL_038c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		text = text2;
		goto IL_02c6;
		IL_0291:
		obj22 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ X0_v20+E4]");
		bool flag7 = (nint)0 == 0;
		text2 = text;
		if (!flag7)
		{
			goto IL_02c6;
		}
		goto IL_038c;
		IL_02c6:
		PopupWindow.AskFor(InputField.ContentType.Password, text, passwordIcon, (Action<string>)action);
	}

	public void OnWatchRoomClick()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_031b: Expected O, but got I
		//IL_004b: Expected O, but got I
		//IL_0330: Expected O, but got I
		//IL_00bc: Expected O, but got I
		//IL_00cd: Expected O, but got I
		//IL_0345: Expected O, but got I
		//IL_00a7: Expected O, but got I4
		//IL_00fc: Expected O, but got I
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Expected O, but got Unknown
		//IL_0138: Expected O, but got I
		//IL_0149: Expected I, but got O
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Expected O, but got Unknown
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		//IL_0248: Expected O, but got Unknown
		//IL_0266: Expected O, but got I
		//IL_0280: Expected O, but got I4
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Expected O, but got Unknown
		//IL_01bc: Expected O, but got I
		//IL_02c6: Expected O, but got I4
		object obj = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 2088;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (RoomCard)+40]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X8_v6+10]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X8_v7+58]");
		Action<object> action = default(Action<object>);
		object obj10;
		string text;
		string text2;
		RoomCard roomCard = default(RoomCard);
		object obj17;
		if ((nint)0 == 1)
		{
			bool flag = CanBypassLock();
			if (!flag)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (RoomCard)+40]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X8_v14+10]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v15+10]");
				_ = 0;
				object obj8 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj9 = (nint)0 + (nint)872;
				action..ctor(obj2, (IntPtr)obj9);
				obj10 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
				object obj11 = obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X0_v16+E4]");
				if ((nint)0 != 0)
				{
					object obj12 = "LAK" + 2296;
					text = (string)obj12;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7A46]");
					object obj13 = (nint)0 & (nint)1;
					bool flag2 = obj13 == null;
					text2 = (string)obj12;
					if (!flag2)
					{
						goto IL_01e1;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj14 = "LAK" + 2296;
					text = (string)obj14;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7A46]");
					object obj15 = (nint)0 & (nint)1;
					bool flag3 = obj15 == null;
					object obj16 = !flag3;
					text2 = (string)obj14;
					if (obj16 != null)
					{
						goto IL_01e1;
					}
				}
				_ = 1;
				obj17 = obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X0_v17+E4]");
				bool flag4 = (nint)0 == 0;
				object obj18 = !flag4;
				text = text2;
				if (obj18 != null)
				{
					goto IL_0216;
				}
				goto IL_02dc;
			}
			roomCard = (RoomCard)flag;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (RoomCard)+40]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X8_v10+10]");
		object obj20 = 0;
		object password = (nint)0 + (nint)2000;
		RoomCard roomCard2 = roomCard;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v11+10]");
		roomCard2.DoWatch(0, (string)password);
		return;
		IL_0216:
		PopupWindow.AskFor(InputField.ContentType.Password, text, passwordIcon, (Action<string>)action);
		return;
		IL_02dc:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		text = text2;
		goto IL_0216;
		IL_01e1:
		obj17 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X0_v17+E4]");
		bool flag5 = (nint)0 == 0;
		text2 = text;
		if (!flag5)
		{
			goto IL_0216;
		}
		goto IL_02dc;
	}

	private bool CanBypassLock()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00d1: Expected O, but got I
		//IL_00fb: Expected O, but got I4
		//IL_00ac: Expected O, but got I4
		//IL_0053: Expected O, but got I
		//IL_028a: Expected O, but got I
		//IL_027a: Expected I4, but got O
		//IL_0183: Expected O, but got I
		//IL_01ff: Expected O, but got I4
		object obj = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7A5B]");
		object obj2 = (nint)0 & (nint)1;
		object obj5;
		object obj3;
		if (obj2 != null)
		{
			obj3 = (nint)0 + (nint)2200;
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v18+E4]");
			bool flag = (nint)0 == 0;
			obj5 = obj3;
			if (!flag)
			{
				goto IL_0088;
			}
		}
		else
		{
			_ = 1;
			obj3 = (nint)0 + (nint)2200;
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v18+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			obj5 = obj3;
			if (obj6 != null)
			{
				goto IL_0088;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		bool flag3 = (object)sessionModel == null;
		obj3 = obj5;
		if (!flag3)
		{
			goto IL_014f;
		}
		goto IL_026c;
		IL_026c:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_014f:
		User localUser = sessionModel.LocalUser;
		int intDbId = SFSKammelnaUserExtensions.GetIntDbId(localUser);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (RoomCard)+40]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (RoomCard)+40]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X8_v6+10]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X8_v6+10]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X8_v7+20]");
				if ((nint)intDbId == 0)
				{
					return true;
				}
				object obj9 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X0_v7+E4]");
				bool flag4 = (nint)0 == 0;
				object obj10 = !flag4;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
				SessionModel sessionModel2 = default(SessionModel);
				if ((object)sessionModel2 != null)
				{
					User localUser2 = sessionModel2.LocalUser;
					return SFSKammelnaUserExtensions.Can(localUser2, UserPermission.ManageGameRooms);
				}
			}
		}
		goto IL_026c;
		IL_0088:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag5 = (object)sessionModel == null;
		object obj11 = !flag5;
		if (obj11 != null)
		{
			goto IL_014f;
		}
		goto IL_026c;
	}

	private void DoJoin(int roomId, int seatIndex, string password = "")
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_00a3: Expected O, but got I4
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00f3: Expected O, but got I4
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		ITrackEvent trackEvent = TrackerLibrary.MenuRoomJoined();
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object msgBody = "Invalid serialized DateTime data. Unable to find 'ticks' or 'dateData'." + 3144;
		Tracker.DesignEvent(trackEvent);
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v5+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PopupWindow.ShowLoading((string)msgBody);
		SFS.JoinGameRoom(roomId, seatIndex, password);
	}

	private void DoWatch(int roomId, string password = "")
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected O, but got Unknown
		//IL_00a4: Expected O, but got I4
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_00f4: Expected O, but got I4
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		ITrackEvent trackEvent = TrackerLibrary.MenuRoomWatched();
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object msgBody = "Invalid serialized DateTime data. Unable to find 'ticks' or 'dateData'." + 3144;
		Tracker.DesignEvent(trackEvent);
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v5+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PopupWindow.ShowLoading((string)msgBody);
		SFS.JoinGameRoom(roomId, 0, password);
	}

	public RoomCard()
	{
		((ListViewItem<object, int>)(object)this)..ctor();
	}

	private void <RefreshRoomThemeBorder>b__18_0(bool success)
	{
		//IL_0077: Expected O, but got I
		//IL_0024: Expected O, but got I
		//IL_0065: Expected O, but got I
		ThemeBorder.enabled = success;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (RoomCard)+40]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ X8_v4+10]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X8_v5+60]");
		if ((nint)0 != 0)
		{
			ThemeProvider themeProvider = _themeProvider;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X8_v5+60]");
			themeProvider.UpdateTheme((IThemeColorProfile)0);
		}
	}
}
