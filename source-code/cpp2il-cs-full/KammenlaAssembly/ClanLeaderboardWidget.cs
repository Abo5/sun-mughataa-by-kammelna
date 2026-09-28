using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using TMPro;
using Unity.Properties;
using UnityEngine;

public class ClanLeaderboardWidget : MonoBehaviour, IClanLandingWidget
{
	private ClanLeaderboardEntry[] Top3Clans;

	public void Populate(ClanLandingResponseModel landing)
	{
		bool flag = landing == null;
		List<InterClanLeaderboardEntryModel> top = (List<InterClanLeaderboardEntryModel>)(object)landing;
		if (!flag)
		{
			top = landing.Top3;
		}
		Populate(top);
	}

	public void Populate(List<InterClanLeaderboardEntryModel> top3)
	{
		//IL_005c: Expected O, but got I
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected O, but got Unknown
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected O, but got Unknown
		//IL_013b: Expected O, but got I
		//IL_0151: Expected O, but got I
		//IL_016c: Expected O, but got I4
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Expected I4, but got Unknown
		//IL_0240: Expected O, but got I
		//IL_0240: Expected O, but got I
		//IL_026c: Expected O, but got I
		//IL_0293: Expected O, but got I4
		//IL_00d8: Expected O, but got I
		//IL_00d8: Expected O, but got I
		ClanLeaderboardEntry[] top3Clans = Top3Clans;
		bool flag = top3 == null;
		List<InterClanLeaderboardEntryModel> list = top3;
		if (!flag)
		{
			int num = 0;
			while (true)
			{
				if (num >= top3Clans.Length)
				{
					return;
				}
				object obj = top3Clans + num;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X8_v10+20]");
				Component component = (Component)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X8_v10+20]");
				GameObject gameObject = ((Component)0).gameObject;
				object obj2 = num - top3._size;
				bool flag2 = (nint)obj2 < 0;
				int num2 = num ^ top3._size;
				int num3 = num ^ obj2;
				int num4 = num2 & num3;
				bool flag3 = num4 < 0;
				bool flag4 = flag2 == flag3;
				bool active = !flag4;
				gameObject.SetActive(active);
				if (num < top3._size)
				{
					object obj3 = ((List<object>)(object)top3).get_Item(num);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X0_v12 (System.Object)+14]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X22_v5 (UnityEngine.Component)+28]");
					nint num5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X0_v12 (System.Object)+18]");
					TextMeshProExtensions.FixArabic((TextMeshProUGUI)num5, (string)0);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X22_v5 (UnityEngine.Component)+30]");
					nint num6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X0_v12 (System.Object)+24]");
					TextMeshProExtensions.SetNumber((TextMeshProUGUI)num6, 0, useCommas: true);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X22_v5 (UnityEngine.Component)+20]");
					bool flag5 = (nint)0 == 0;
					object obj4 = !flag5;
					if (obj4 == null)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X22_v5 (UnityEngine.Component)+20]");
					nint num7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X0_v12 (System.Object)+14]");
					nint num8 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X0_v12 (System.Object)+28]");
					((ClanEmblemLoader)num7).Load((int)num8, (FileInfoModel)0);
				}
				top3Clans = Top3Clans;
				num++;
			}
			throw new NullReferenceException();
		}
		while ((nint)list < top3Clans.Length)
		{
			object obj5 = (object)top3Clans + (object)list;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X8_v7+20]");
			GameObject gameObject2 = ((Component)0).gameObject;
			gameObject2.SetActive(value: false);
			top3Clans = Top3Clans;
			list = (List<InterClanLeaderboardEntryModel>)(list + 1);
		}
	}

	public ClanLeaderboardWidget()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		object obj = typeof(TypeConverter<ushort, char>) + 1960;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object obj2 = this + 32;
		object obj3 = default(object);
		obj2 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
	}
}
