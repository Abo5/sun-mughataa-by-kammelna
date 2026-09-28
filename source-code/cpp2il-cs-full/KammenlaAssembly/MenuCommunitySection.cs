using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Cpp2ILInjected;
using DataTracking;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json.Linq.JsonPath;
using Server.Models;
using Unity.Properties;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class MenuCommunitySection : MonoBehaviour
{
	private sealed class <>c__DisplayClass8_0
	{
		public LeaderBoardPlayer player;

		internal unsafe void <InitializeTopPlayers>b__0()
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Expected I4, but got Unknown
			object obj = typeof(MemberAchievementClanFeedData) + 840;
			int num = player + 44;
			string dbId = ((int*)num)->ToString();
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v4+E4]");
			if ((nint)0 != 0)
			{
				MiniProfilePopup.Show(dbId, TrackingPlacement.CommunityList);
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			MiniProfilePopup.Show(dbId, TrackingPlacement.CommunityList);
		}
	}

	private ILeaderboardSource leaderboardSource;

	private CircularProgress progress;

	private Image Top1Avatar;

	private Image Top2Avatar;

	private Image Top3Avatar;

	private Image[] avatars
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0033: Expected O, but got I4
			//IL_0049: Expected I, but got O
			//IL_0059: Expected O, but got I
			//IL_0082: Expected O, but got I
			//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bd: Expected O, but got Unknown
			//IL_015d: Expected O, but got I8
			//IL_0102: Expected I, but got O
			//IL_0112: Expected O, but got I
			//IL_013b: Expected O, but got I
			//IL_0183: Unknown result type (might be due to invalid IL or missing references)
			//IL_0188: Expected O, but got Unknown
			//IL_0230: Expected O, but got I4
			//IL_0240: Expected O, but got I4
			//IL_0260: Unknown result type (might be due to invalid IL or missing references)
			//IL_0265: Expected O, but got Unknown
			//IL_01cd: Expected I, but got O
			//IL_01dd: Expected O, but got I
			//IL_0206: Expected O, but got I
			//IL_027c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0281: Expected O, but got Unknown
			object obj = typeof(TypeConverter<ushort, char>) + 2936;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
			Image[] array = default(Image[]);
			if (array != null)
			{
				bool flag = (object)Top1Avatar == null;
				Image image = (Image)3;
				IndexOutOfRangeException ex = default(IndexOutOfRangeException);
				Image image2;
				if (!flag)
				{
					nint num = (nint)array;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v14 (Il2CppClass<UnityEngine.UI.Image[]>)+40]");
					image = (Image)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag2 = ex == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v14 (Il2CppClass<UnityEngine.UI.Image[]>)+40]");
					image2 = (Image)0;
					if (flag2)
					{
						goto IL_02b0;
					}
				}
				if (array.Length != 0)
				{
					object obj2 = array + 32;
					obj2 = Top1Avatar;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					bool flag3 = (object)Top2Avatar == null;
					image = Top1Avatar;
					if (!flag3)
					{
						nint num2 = (nint)array;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X8_v13 (Il2CppClass<UnityEngine.UI.Image[]>)+40]");
						image = (Image)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
						bool flag4 = ex == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X8_v13 (Il2CppClass<UnityEngine.UI.Image[]>)+40]");
						image2 = (Image)0;
						if (flag4)
						{
							goto IL_02b0;
						}
					}
					object obj3 = array.Length & 0xFFFFFFFEL;
					if (obj3 != null)
					{
						object obj4 = array + 40;
						obj4 = Top2Avatar;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						bool flag5 = (object)Top3Avatar == null;
						image = Top2Avatar;
						if (!flag5)
						{
							nint num3 = (nint)array;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X8_v12 (Il2CppClass<UnityEngine.UI.Image[]>)+40]");
							image = (Image)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
							bool flag6 = ex == null;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X8_v12 (Il2CppClass<UnityEngine.UI.Image[]>)+40]");
							image2 = (Image)0;
							if (flag6)
							{
								goto IL_02b0;
							}
						}
						bool flag7 = array.Length < 2;
						object obj5 = !flag7;
						object obj6 = array.Length - 2;
						bool flag8 = obj6 == null;
						object obj7 = ~obj5;
						object obj8 = obj7 | flag8;
						if (obj8 == null)
						{
							object obj9 = array + 48;
							obj9 = Top3Avatar;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							return array;
						}
					}
				}
				ex = new IndexOutOfRangeException();
				image2 = image;
				goto IL_02b0;
			}
			goto IL_02c8;
			IL_02c8:
			return (Image[])(object)new NullReferenceException();
			IL_02b0:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
			OutOfMemoryException ex2 = new OutOfMemoryException();
			goto IL_02c8;
		}
	}

	private void Start()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected O, but got Unknown
		//IL_0122: Expected O, but got I
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Expected O, but got Unknown
		//IL_0158: Expected I, but got O
		//IL_0063: Expected O, but got I4
		//IL_00b0: Expected I, but got O
		//IL_00da: Expected O, but got I4
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2536;
		object obj2 = (nint)0 + (nint)1136;
		object obj3 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1688;
		object obj4 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3000;
		object obj5 = (nint)0 + (nint)1144;
		object obj6 = typeof(System.Buffers.Text.ParserHelpers) + 1056;
		GameObject lifecycle = base.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		object obj7 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X0_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj8 = !flag;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		LeaderBoardManager.GetLeaderBoard(lifecycle, leaderboardSource, action);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)this, (IntPtr)obj5);
		object obj9 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v11+E4]");
		bool flag2 = (nint)0 == 0;
		object obj10 = !flag2;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PlayerProfilesHandler.RequestMyProfile(action2);
	}

	private unsafe void InitializeTopPlayers(LeaderboardModel model)
	{
		//IL_06f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fb: Expected O, but got Unknown
		//IL_00c6: Expected O, but got I
		//IL_00ce: Expected I, but got O
		//IL_00ed: Expected O, but got I
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Expected O, but got Unknown
		//IL_0173: Expected O, but got I
		//IL_017f: Expected O, but got I
		//IL_019f: Expected I, but got O
		//IL_02a3: Expected I, but got O
		//IL_02e3: Expected O, but got I4
		//IL_02fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ff: Expected O, but got Unknown
		//IL_0378: Expected O, but got I4
		//IL_03d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d8: Expected O, but got Unknown
		//IL_03e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e6: Expected I4, but got Unknown
		//IL_0472: Expected O, but got I
		//IL_0472: Expected O, but got I
		//IL_0499: Expected O, but got I4
		//IL_04a2: Expected O, but got I4
		//IL_04e3: Expected O, but got I4
		//IL_04ec: Expected O, but got I4
		//IL_04f5: Expected O, but got I4
		//IL_0533: Unknown result type (might be due to invalid IL or missing references)
		//IL_0538: Expected O, but got Unknown
		//IL_0558: Expected O, but got I4
		//IL_0561: Expected O, but got I4
		//IL_058f: Expected I, but got O
		//IL_05b0: Expected O, but got Ref
		//IL_0221: Expected O, but got I4
		//IL_022a: Expected O, but got I4
		//IL_0243: Expected O, but got I4
		//IL_024c: Expected O, but got I4
		//IL_05d6: Expected O, but got I4
		//IL_05df: Expected O, but got I4
		//IL_05e7: Expected O, but got Ref
		//IL_0604: Unknown result type (might be due to invalid IL or missing references)
		//IL_0609: Expected O, but got Unknown
		//IL_061f: Expected O, but got I
		//IL_0627: Expected I, but got O
		//IL_0638: Expected I, but got O
		//IL_065f: Expected O, but got I4
		//IL_0668: Expected O, but got I4
		//IL_0671: Expected O, but got I4
		//IL_01d2: Expected O, but got I
		if (model == null)
		{
			return;
		}
		List<LeaderBoardPlayer> topPlayers = model.GetTopPlayers();
		if (topPlayers == null)
		{
			return;
		}
		Image[] array = avatars;
		bool flag = array == null;
		IntPtr intPtr = default(IntPtr);
		nint num = intPtr;
		object obj = null;
		NullReferenceException ex;
		if (!flag)
		{
			if (topPlayers._size < array.Length)
			{
				return;
			}
			Image[] array2 = avatars;
			bool flag2 = array2 == null;
			num = intPtr;
			obj = null;
			if (!flag2)
			{
				object obj2 = (nint)0 + (nint)856;
				num = (nint)obj2;
				IEnumerable<object> source = Enumerable.Take((IEnumerable<object>)topPlayers, array2.Length);
				object obj3 = (nint)0 + (nint)2328;
				obj = obj3;
				List<object> list = Enumerable.ToList(source);
				Image[] array3 = avatars;
				if (array3 != null)
				{
					bool flag3 = list == null;
					ex = (NullReferenceException)(object)array3;
					if (flag3)
					{
						goto IL_069e;
					}
					object obj4 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 3392;
					object obj5 = (nint)0 + (nint)3112;
					object obj6 = (nint)0 + (nint)944;
					object obj8 = default(object);
					object obj7 = obj8;
					object obj10 = default(object);
					object obj9 = obj10;
					bool flag5 = default(bool);
					bool flag4 = flag5;
					nint num2 = (nint)obj2;
					object obj11 = obj3;
					Image[] array4 = array3;
					int num3 = 0;
					object obj12 = default(object);
					object obj20 = default(object);
					object obj21 = default(object);
					UnityAction unityAction = default(UnityAction);
					while (true)
					{
						if (num3 >= array4.Length)
						{
							return;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						obj12..ctor();
						num = (nint)obj5;
						object obj13 = list.get_Item(num3);
						bool flag6 = obj12 == null;
						obj8 = obj7;
						obj10 = obj9;
						flag5 = flag4;
						obj = num3;
						if (flag6)
						{
							break;
						}
						object obj14 = obj12 + 16;
						obj14 = obj13;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						Image[] array5 = avatars;
						bool flag7 = array5 == null;
						obj8 = obj7;
						obj10 = obj9;
						flag5 = flag4;
						obj = obj13;
						if (flag7)
						{
							break;
						}
						bool flag8 = num3 < array5.Length;
						object obj15 = !flag8;
						obj = obj13;
						if (obj15 == null)
						{
							bool flag9 = obj14 == null;
							obj8 = obj7;
							obj10 = obj9;
							flag5 = flag4;
							obj = obj13;
							if (flag9)
							{
								break;
							}
							object obj16 = array5 + num3;
							int num4 = obj14 + 44;
							string text = ((int*)num4)->ToString();
							object obj17 = obj14;
							bool flag10 = obj14 == null;
							obj8 = obj7;
							obj10 = obj9;
							flag5 = flag4;
							obj = null;
							if (flag10)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v355 @ X8_v20+58]");
							flag5 = false;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X9_v7+20]");
							nint num5 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v355 @ X8_v20+50]");
							nint num6 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v355 @ X8_v20+58]");
							UIExtensions.AssignAvatarImage((Image)num5, text, (DateTime?)(object)num6, fullSize: false);
							Image[] array6 = avatars;
							bool flag11 = array6 == null;
							obj8 = 0;
							obj10 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v355 @ X8_v20+50]");
							num = 0;
							obj = text;
							if (flag11)
							{
								break;
							}
							bool flag12 = num3 < array6.Length;
							object obj18 = !flag12;
							obj7 = 0;
							obj9 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v355 @ X8_v20+58]");
							flag4 = false;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v355 @ X8_v20+50]");
							num = 0;
							obj = text;
							if (obj18 == null)
							{
								object obj19 = array6 + num3;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X8_v22+20]");
								bool flag13 = (nint)0 == 0;
								obj8 = 0;
								obj10 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v355 @ X8_v20+50]");
								num = 0;
								obj = text;
								if (flag13)
								{
									break;
								}
								num = (nint)obj6;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D321D8");
								bool flag14 = obj20 == null;
								obj11 = (object)(&obj21);
								if (!flag14)
								{
									bool flag15 = obj21 == null;
									obj8 = 0;
									obj10 = 0;
									obj = (object)(&obj21);
									if (flag15)
									{
										break;
									}
									object obj22 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
									object obj23 = (nint)0 + (nint)1368;
									num = (nint)obj23;
									unityAction..ctor(obj12, (IntPtr)obj23);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ stack_-68_v7+100]");
									bool flag16 = (nint)0 == 0;
									object obj24 = !flag16;
									obj8 = 0;
									obj10 = 0;
									flag5 = false;
									obj = obj12;
									if (obj24 == null)
									{
										break;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ stack_-68_v7+100]");
									((UnityEvent)0).AddListener(unityAction);
									flag5 = false;
									num = 0;
									obj11 = unityAction;
								}
								num3++;
								array4 = avatars;
								bool flag17 = array4 == null;
								obj7 = 0;
								obj9 = 0;
								flag4 = flag5;
								num2 = num;
								obj8 = 0;
								obj10 = 0;
								obj = obj11;
								if (flag17)
								{
									break;
								}
								continue;
							}
						}
						obj8 = obj7;
						obj10 = obj9;
						flag5 = flag4;
						throw new IndexOutOfRangeException();
					}
				}
			}
		}
		ex = new NullReferenceException();
		goto IL_069e;
		IL_069e:
		if ((nint)((Exception)ex)._message < 1)
		{
			return;
		}
		object obj25 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 3392;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj26 = default(object);
		obj26..ctor();
		throw new NullReferenceException();
	}

	private void InitializeWeeklyProgress(PlayerProfileModel model)
	{
		//IL_004c: Expected F4, but got I4
		//IL_004c: Expected F4, but got I4
		PlayerRankingModel <ranking>k__BackingField = model.<ranking>k__BackingField;
		if (model.<ranking>k__BackingField != null)
		{
			progress.Initialize(<ranking>k__BackingField.<lastWeekPoints>k__BackingField, <ranking>k__BackingField.<currentWeekPoints>k__BackingField);
		}
	}
}
