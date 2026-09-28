using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Dynamic.Utils;
using System.Formats.Asn1;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Features.GameReplay;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using PredictAndWinModel;
using Server.Models;
using Server.Models.Products;
using Sfs2X.Entities;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;

public class ImageCacher : Singleton<ImageCacher>
{
	public enum ItemImageType
	{
		InGame,
		InGameLandscape,
		LobbyFrame,
		StoreTitle,
		StorePreview
	}

	public enum NotificationImageType
	{
		Small,
		Large
	}

	public enum PredictAndWinImageType
	{
		LeagueLogo,
		SponsorLogo,
		SponsorImage,
		TweetImage
	}

	public enum MassTournamentImageType
	{
		BigAd,
		SmallAd,
		BigLogo,
		SmallLogo,
		BackGround,
		PrizesGrouped
	}

	public enum BannerSize
	{
		Normal,
		Wide
	}

	public enum SportTeamImageType
	{
		Prediction,
		Celebration
	}

	public enum ClanLogoElementImageType
	{
		Main,
		Mask
	}

	private sealed class <>c__DisplayClass36_0
	{
		public string avatarsPath;

		internal void <CheckAvatarsDirectorySize>b__0()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_00d1: Expected O, but got I4
			//IL_0096: Expected I8, but got I4
			//IL_0101: Expected I8, but got I4
			object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 488;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5F05]");
			object obj2 = (nint)0 & (nint)1;
			string path;
			string path2;
			if (obj2 != null)
			{
				path = avatarsPath;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v1+E4]");
				bool flag = (nint)0 == 0;
				path2 = avatarsPath;
				if (!flag)
				{
					goto IL_0088;
				}
			}
			else
			{
				_ = 1;
				path = avatarsPath;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v1+E4]");
				bool flag2 = (nint)0 == 0;
				object obj4 = !flag2;
				path2 = avatarsPath;
				if (obj4 != null)
				{
					goto IL_0088;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			FileUtils.CleanFolder(path2, 157286400L);
			return;
			IL_0088:
			FileUtils.CleanFolder(path, 157286400L);
		}
	}

	private sealed class <>c__DisplayClass37_0
	{
		public Action<Sprite> callback;

		public string userID;

		public UnityEngine.Object go;

		public DateTime timestamp;

		internal void <LoadAvatarThumbnail>g__Fallback|0(Sprite sprite)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_0114: Expected O, but got I4
			//IL_016d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0172: Expected O, but got Unknown
			//IL_017c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0181: Expected O, but got Unknown
			//IL_02cd: Expected O, but got I4
			//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e1: Expected O, but got Unknown
			//IL_02f7: Expected O, but got I
			//IL_0155: Expected O, but got I4
			//IL_025d: Expected O, but got I4
			//IL_00ba: Expected O, but got I
			//IL_00ca: Expected O, but got I
			//IL_00da: Expected O, but got I
			//IL_01c9: Expected O, but got I
			//IL_01e3: Expected O, but got I4
			//IL_0320: Expected O, but got I
			//IL_032f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0334: Expected O, but got Unknown
			//IL_035e: Expected O, but got I4
			//IL_028b: Expected O, but got I
			//IL_037c: Expected O, but got I
			//IL_0391: Expected O, but got I
			//IL_03ce: Expected O, but got I4
			object obj = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5FCA]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 == null)
			{
				goto IL_00e4;
			}
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v35+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
			goto IL_0122;
			IL_01b3:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE458B]");
			object obj4 = (nint)0 & (nint)1;
			bool flag = obj4 == null;
			object obj5 = !flag;
			if (obj5 == null)
			{
				goto IL_01f1;
			}
			goto IL_0314;
			IL_0074:
			if (sprite != null)
			{
				goto IL_009b;
			}
			goto IL_0163;
			IL_009b:
			Action<Sprite> action = callback;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v24 (System.Action`1<UnityEngine.Sprite>)+18]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v24 (System.Action`1<UnityEngine.Sprite>)+40]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v24 (System.Action`1<UnityEngine.Sprite>)+28]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v104 @ X3_v3 (should have been resolved before IL gen)");
			goto IL_00e4;
			IL_00e4:
			_ = 1;
			obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v35+E4]");
			bool flag2 = (nint)0 == 0;
			object obj9 = !flag2;
			if (obj9 != null)
			{
				goto IL_0074;
			}
			goto IL_0122;
			IL_0122:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = sprite != null;
			bool flag4 = !flag3;
			object obj10 = !flag4;
			if (obj10 != null)
			{
				goto IL_009b;
			}
			goto IL_0163;
			IL_0163:
			object obj11 = "alignContent" + 3456;
			object obj12 = "___# Content push apply failed [{0}]: {1}" + 2408;
			string text = (string)obj11 + userID + (string)obj12;
			object obj13 = 152981504;
			object obj14 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5FC9]");
			object obj15 = (nint)0 & (nint)1;
			if (obj15 != null)
			{
				object obj16 = obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X0_v17+E4]");
				if ((nint)0 != 0)
				{
					goto IL_01b3;
				}
			}
			else
			{
				_ = 1;
				object obj16 = obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X0_v17+E4]");
				bool flag5 = (nint)0 == 0;
				object obj17 = !flag5;
				if (obj17 != null)
				{
					goto IL_01b3;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE458B]");
			object obj18 = (nint)0 & (nint)1;
			if (obj18 == null)
			{
				goto IL_01f1;
			}
			goto IL_0314;
			IL_0314:
			object obj19 = (nint)0 + (nint)2264;
			object obj20 = typeof(RegisteredWaitHandle) + 40;
			object obj21 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X0_v7+E4]");
			bool flag6 = (nint)0 == 0;
			object obj22 = !flag6;
			if (obj22 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj21 = obj14;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X0_v7+B8]");
			object obj23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X8_v8+28]");
			string text2 = (string)0 + text;
			DateTime? dateTime = timestamp;
			object obj24 = obj20;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X0_v11+E4]");
			bool flag7 = (nint)0 == 0;
			object obj25 = !flag7;
			if (obj25 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2FEEFBC");
			return;
			IL_01f1:
			_ = 1;
			goto IL_0314;
		}
	}

	private sealed class <>c__DisplayClass41_0
	{
		public UnityEngine.Object go;

		public int itemID;

		public Action<Sprite> callback;

		public ItemImageType itemImageType;

		public Func<ImageInfoModel<ItemImageType>, bool> <>9__1;

		internal unsafe void <LoadItemImage>b__0()
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_0109: Expected O, but got I4
			//IL_00b7: Expected O, but got I4
			//IL_0183: Unknown result type (might be due to invalid IL or missing references)
			//IL_0188: Expected O, but got Unknown
			//IL_0158: Expected O, but got I4
			//IL_0161: Expected O, but got I4
			//IL_0230: Expected O, but got I4
			//IL_01de: Expected O, but got I4
			//IL_01e7: Expected O, but got I4
			//IL_0244: Unknown result type (might be due to invalid IL or missing references)
			//IL_0249: Expected O, but got Unknown
			//IL_026b: Expected O, but got I4
			//IL_03d7: Expected O, but got I
			//IL_03e7: Expected O, but got I
			//IL_03f7: Expected O, but got I
			//IL_02e3: Expected O, but got I
			//IL_0410: Expected O, but got I4
			//IL_0424: Expected O, but got Ref
			//IL_0288: Unknown result type (might be due to invalid IL or missing references)
			//IL_028d: Expected O, but got Unknown
			//IL_02a3: Expected O, but got I
			//IL_02b1: Expected I, but got O
			//IL_0338: Expected O, but got I
			//IL_034d: Expected O, but got I
			//IL_035c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0361: Expected O, but got Unknown
			//IL_038b: Expected O, but got I4
			//IL_0322: Unknown result type (might be due to invalid IL or missing references)
			//IL_0327: Expected O, but got Unknown
			object obj = 152981504;
			object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5FCB]");
			object obj3 = (nint)0 & (nint)1;
			UnityEngine.Object obj4;
			UnityEngine.Object obj6;
			if (obj3 != null)
			{
				obj4 = go;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v38+E4]");
				bool flag = (nint)0 == 0;
				obj6 = go;
				if (!flag)
				{
					goto IL_0091;
				}
			}
			else
			{
				_ = 1;
				obj4 = go;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v38+E4]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				obj6 = go;
				if (obj7 != null)
				{
					goto IL_0091;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = obj6 == null;
			bool flag4 = !flag3;
			object obj8 = !flag4;
			object obj9 = 0;
			UnityEngine.Object obj10 = null;
			if (obj8 == null)
			{
				goto IL_0174;
			}
			return;
			IL_023e:
			object obj11 = this + 48;
			Func<object, bool> predicate = (Func<object, bool>)obj11;
			bool flag5 = obj11 == null;
			object obj12 = !flag5;
			if (obj12 == null)
			{
				object obj13 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 3416;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj14 = (nint)0 + (nint)4024;
				Func<object, bool> func = default(Func<object, bool>);
				func..ctor((object)this, (IntPtr)obj14);
				<>9__1 = func;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				predicate = func;
			}
			object obj15 = (nint)0 + (nint)544;
			StoreItem storeItem;
			object obj16 = Enumerable.FirstOrDefault(storeItem.<images>k__BackingField, predicate);
			if (obj16 == null)
			{
				goto IL_03b8;
			}
			object format = "https://www.kammelna.com/Home/Terms" + 3920;
			goto IL_0401;
			IL_03b8:
			Action<Sprite> action = callback;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X8_v8 (System.Action`1<UnityEngine.Sprite>)+18]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X8_v8 (System.Action`1<UnityEngine.Sprite>)+40]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X8_v8 (System.Action`1<UnityEngine.Sprite>)+28]");
			object obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v185 @ X3_v3 (should have been resolved before IL gen)");
			goto IL_0401;
			IL_0401:
			object obj20 = 153100288 + 1024;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			DateTime? dateTime = default(DateTime?);
			string arg = ((Enum)(&dateTime)).ToString();
			object arg2 = default(object);
			string text = string.Format((string)format, arg2, arg);
			object obj21 = (nint)0 + (nint)2264;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X0_v10 (System.Object)+18]");
			dateTime = (DateTime)0;
			object obj22 = typeof(RegisteredWaitHandle) + 40;
			object obj23 = obj22;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X0_v19+E4]");
			bool flag6 = (nint)0 == 0;
			object obj24 = !flag6;
			if (obj24 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2FEEFBC");
			return;
			IL_0091:
			bool flag7 = obj4 == null;
			bool flag8 = !flag7;
			obj9 = 0;
			obj10 = null;
			if (!flag8)
			{
				return;
			}
			goto IL_0174;
			IL_0174:
			object obj25 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
			object obj26 = obj25;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v3+E4]");
			if ((nint)0 != 0)
			{
				storeItem = Store.GetStoreItem(itemID);
				bool flag9 = storeItem == null;
				object obj27 = !flag9;
				object obj28 = 0;
				if (obj27 != null)
				{
					goto IL_023e;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				storeItem = Store.GetStoreItem(itemID);
				bool flag10 = storeItem == null;
				object obj28 = 0;
				if (!flag10)
				{
					goto IL_023e;
				}
			}
			goto IL_03b8;
		}

		internal bool <LoadItemImage>b__1(ImageInfoModel<ItemImageType> image)
		{
			//IL_003e: Expected I4, but got O
			//IL_001c: Expected O, but got I
			if (image != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [image @ X1 (ImageInfoModel`1<ImageCacher+ItemImageType>)+20]");
				object obj = (nint)0 - (nint)itemImageType;
				return obj == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass42_0
	{
		public UnityEngine.Object go;

		public int itemID;

		public Action<Sprite, int> callback;

		public int elementIndex;

		public Action<Sprite> <>9__1;

		internal void <LoadAnimatedRoomImage>b__0()
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_0109: Expected O, but got I4
			//IL_00b7: Expected O, but got I4
			//IL_0183: Unknown result type (might be due to invalid IL or missing references)
			//IL_0188: Expected O, but got Unknown
			//IL_0158: Expected O, but got I4
			//IL_0161: Expected O, but got I4
			//IL_01de: Expected O, but got I4
			//IL_03f8: Expected O, but got I
			//IL_0408: Expected O, but got I
			//IL_0418: Expected O, but got I
			//IL_0431: Expected O, but got I4
			//IL_025a: Unknown result type (might be due to invalid IL or missing references)
			//IL_025f: Expected O, but got Unknown
			//IL_0270: Expected O, but got I
			//IL_029d: Expected O, but got I
			//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ad: Expected O, but got Unknown
			//IL_02cf: Expected O, but got I4
			//IL_02d8: Expected O, but got I4
			//IL_0359: Expected O, but got I
			//IL_036e: Expected O, but got I
			//IL_037d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0382: Expected O, but got Unknown
			//IL_03ac: Expected O, but got I4
			//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_02fa: Expected O, but got Unknown
			//IL_0310: Expected O, but got I
			//IL_031e: Expected I, but got O
			//IL_0340: Expected O, but got I4
			object obj = 152981504;
			object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5FCC]");
			object obj3 = (nint)0 & (nint)1;
			UnityEngine.Object obj4;
			UnityEngine.Object obj6;
			if (obj3 != null)
			{
				obj4 = go;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v36+E4]");
				bool flag = (nint)0 == 0;
				obj6 = go;
				if (!flag)
				{
					goto IL_0091;
				}
			}
			else
			{
				_ = 1;
				obj4 = go;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v36+E4]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				obj6 = go;
				if (obj7 != null)
				{
					goto IL_0091;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = obj6 == null;
			bool flag4 = !flag3;
			object obj8 = !flag4;
			object obj9 = 0;
			UnityEngine.Object obj10 = null;
			if (obj8 == null)
			{
				goto IL_0174;
			}
			return;
			IL_022c:
			StoreItem storeItem;
			if (storeItem.<animatedRoomFileInfoGroups>k__BackingField == null)
			{
				goto IL_03d9;
			}
			object format = "https://www.kammelna.com/Home/Terms" + 3936;
			goto IL_0422;
			IL_0422:
			object obj11 = 153100288 + 1024;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			object arg = default(object);
			object arg2 = default(object);
			string text = string.Format((string)format, arg, arg2);
			object obj12 = (nint)0 + (nint)744;
			object obj13 = ((List<object>)(object)storeItem.<animatedRoomFileInfoGroups>k__BackingField).get_Item(elementIndex);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ X0_v17 (System.Object)+28]");
			object obj14 = 0;
			object obj15 = this + 48;
			Action<object> action = (Action<object>)obj15;
			bool flag5 = obj15 == null;
			object obj16 = !flag5;
			object obj17 = 0;
			if (obj16 == null)
			{
				object obj18 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3480;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj19 = (nint)0 + (nint)4040;
				Action<object> action2 = default(Action<object>);
				action2..ctor((object)this, (IntPtr)obj19);
				<>9__1 = action2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				obj17 = 0;
				action = action2;
			}
			object obj20 = (nint)0 + (nint)2264;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X25_v5+18]");
			DateTime? dateTime = (DateTime)0;
			object obj21 = typeof(RegisteredWaitHandle) + 40;
			object obj22 = obj21;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ X0_v20+E4]");
			bool flag6 = (nint)0 == 0;
			object obj23 = !flag6;
			if (obj23 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2FEEFBC");
			return;
			IL_03d9:
			Action<Sprite, int> action3 = callback;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X8_v9 (System.Action`2<UnityEngine.Sprite, System.Int32>)+18]");
			object obj24 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X8_v9 (System.Action`2<UnityEngine.Sprite, System.Int32>)+40]");
			object obj25 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X8_v9 (System.Action`2<UnityEngine.Sprite, System.Int32>)+28]");
			object obj26 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v162 @ X4_v2 (should have been resolved before IL gen)");
			goto IL_0422;
			IL_0091:
			bool flag7 = obj4 == null;
			bool flag8 = !flag7;
			obj9 = 0;
			obj10 = null;
			if (!flag8)
			{
				return;
			}
			goto IL_0174;
			IL_0174:
			object obj27 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
			object obj28 = obj27;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v3+E4]");
			if ((nint)0 != 0)
			{
				storeItem = Store.GetStoreItem(itemID);
				bool flag9 = storeItem == null;
				object obj29 = !flag9;
				if (obj29 != null)
				{
					goto IL_022c;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				storeItem = Store.GetStoreItem(itemID);
				if (storeItem != null)
				{
					goto IL_022c;
				}
			}
			goto IL_03d9;
		}

		internal void <LoadAnimatedRoomImage>b__1(Sprite sprite)
		{
			//IL_0029: Expected O, but got I
			//IL_0039: Expected O, but got I
			//IL_0049: Expected O, but got I
			Action<Sprite, int> action = callback;
			int num = elementIndex;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Action`2<UnityEngine.Sprite, System.Int32>)+18]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Action`2<UnityEngine.Sprite, System.Int32>)+40]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Action`2<UnityEngine.Sprite, System.Int32>)+28]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v4 @ X4_v1 (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
		}
	}

	private sealed class <>c__DisplayClass43_0
	{
		public UnityEngine.Object go;

		public long giftId;

		public Action<Sprite> callback;

		internal void <LoadProfileGiftImage>b__0()
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_0105: Expected O, but got I4
			//IL_00b7: Expected O, but got I4
			//IL_017f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0184: Expected O, but got Unknown
			//IL_0154: Expected O, but got I4
			//IL_015d: Expected O, but got I4
			//IL_01da: Expected O, but got I4
			//IL_0302: Expected O, but got I
			//IL_0312: Expected O, but got I
			//IL_0322: Expected O, but got I
			//IL_033b: Expected O, but got I4
			//IL_0255: Unknown result type (might be due to invalid IL or missing references)
			//IL_025a: Expected O, but got Unknown
			//IL_026b: Expected O, but got I
			//IL_028c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0291: Expected O, but got Unknown
			//IL_02bb: Expected O, but got I4
			object obj = 152981504;
			object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5FCD]");
			object obj3 = (nint)0 & (nint)1;
			UnityEngine.Object obj4;
			UnityEngine.Object obj6;
			if (obj3 != null)
			{
				obj4 = go;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v26+E4]");
				bool flag = (nint)0 == 0;
				obj6 = go;
				if (!flag)
				{
					goto IL_0091;
				}
			}
			else
			{
				_ = 1;
				obj4 = go;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v26+E4]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				obj6 = go;
				if (obj7 != null)
				{
					goto IL_0091;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = obj6 == null;
			bool flag4 = !flag3;
			object obj8 = !flag4;
			object obj9 = 0;
			UnityEngine.Object obj10 = null;
			if (obj8 != null)
			{
				return;
			}
			goto IL_0170;
			IL_0228:
			ProfileGiftModel profileGift;
			if (profileGift.Image == null)
			{
				goto IL_02e3;
			}
			object format = "placementId" + 1200;
			goto IL_032c;
			IL_032c:
			object obj11 = 153100288 + 1024;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			object arg = default(object);
			string text = string.Format((string)format, arg);
			FileInfoModel image = profileGift.Image;
			object obj12 = (nint)0 + (nint)2264;
			DateTime? dateTime = image.<lastModified>k__BackingField;
			object obj13 = typeof(RegisteredWaitHandle) + 40;
			object obj14 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X0_v14+E4]");
			bool flag5 = (nint)0 == 0;
			object obj15 = !flag5;
			if (obj15 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2FEEFBC");
			return;
			IL_02e3:
			Action<Sprite> action = callback;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X8_v8 (System.Action`1<UnityEngine.Sprite>)+18]");
			object obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X8_v8 (System.Action`1<UnityEngine.Sprite>)+40]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X8_v8 (System.Action`1<UnityEngine.Sprite>)+28]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v113 @ X3_v1 (should have been resolved before IL gen)");
			goto IL_032c;
			IL_0091:
			bool flag6 = obj4 == null;
			bool flag7 = !flag6;
			obj9 = 0;
			obj10 = null;
			if (!flag7)
			{
				return;
			}
			goto IL_0170;
			IL_0170:
			object obj19 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
			object obj20 = obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X0_v2+E4]");
			if ((nint)0 != 0)
			{
				profileGift = Store.GetProfileGift(giftId);
				bool flag8 = profileGift == null;
				object obj21 = !flag8;
				if (obj21 != null)
				{
					goto IL_0228;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				profileGift = Store.GetProfileGift(giftId);
				if (profileGift != null)
				{
					goto IL_0228;
				}
			}
			goto IL_02e3;
		}
	}

	private sealed class <>c__DisplayClass45_0
	{
		public UnityEngine.Object go;

		public int id;

		public int tier;

		public ClanLogoElementImageType type;

		public Action<Sprite> callback;

		internal void <LoadClanLogoElementImage>b__0()
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_0105: Expected O, but got I4
			//IL_00b7: Expected O, but got I4
			//IL_017f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0184: Expected O, but got Unknown
			//IL_0154: Expected O, but got I4
			//IL_015d: Expected O, but got I4
			//IL_02dd: Expected O, but got I4
			//IL_02e6: Expected O, but got I4
			//IL_01e4: Expected O, but got I4
			//IL_0219: Expected O, but got I
			//IL_022e: Expected O, but got I
			//IL_0242: Unknown result type (might be due to invalid IL or missing references)
			//IL_0247: Expected O, but got Unknown
			//IL_0271: Expected O, but got I4
			//IL_0313: Expected O, but got I
			//IL_0323: Expected O, but got I
			//IL_0333: Expected O, but got I
			object obj = 152981504;
			object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5F07]");
			object obj3 = (nint)0 & (nint)1;
			UnityEngine.Object obj4;
			UnityEngine.Object obj6;
			if (obj3 != null)
			{
				obj4 = go;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v19+E4]");
				bool flag = (nint)0 == 0;
				obj6 = go;
				if (!flag)
				{
					goto IL_0091;
				}
			}
			else
			{
				_ = 1;
				obj4 = go;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v19+E4]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				obj6 = go;
				if (obj7 != null)
				{
					goto IL_0091;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = obj6 == null;
			bool flag4 = !flag3;
			object obj8 = !flag4;
			object obj9 = 0;
			UnityEngine.Object obj10 = null;
			if (obj8 != null)
			{
				return;
			}
			goto IL_0170;
			IL_01f2:
			string clanLogoElementPath = GetClanLogoElementPath(id, tier, type);
			object obj11 = (nint)0 + (nint)2264;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X0_v9 (ImageInfoModel`1<ImageCacher+ClanLogoElementImageType>)+18]");
			DateTime? dateTime = (DateTime)0;
			object obj12 = typeof(RegisteredWaitHandle) + 40;
			object obj13 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X0_v13+E4]");
			bool flag5 = (nint)0 == 0;
			object obj14 = !flag5;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2FEEFBC");
			return;
			IL_0170:
			object obj15 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1272;
			object obj16 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X0_v2+E4]");
			if ((nint)0 != 0)
			{
				ImageInfoModel<ClanLogoElementImageType> image = ClanLogoElementCatalog.GetImage(id, tier, type);
				bool flag6 = image == null;
				object obj17 = 0;
				if (!flag6)
				{
					goto IL_01f2;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				ImageInfoModel<ClanLogoElementImageType> image = ClanLogoElementCatalog.GetImage(id, tier, type);
				bool flag7 = image == null;
				object obj18 = !flag7;
				object obj17 = 0;
				if (obj18 != null)
				{
					goto IL_01f2;
				}
			}
			Action<Sprite> action = callback;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X8_v6 (System.Action`1<UnityEngine.Sprite>)+18]");
			object obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X8_v6 (System.Action`1<UnityEngine.Sprite>)+40]");
			object obj20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X8_v6 (System.Action`1<UnityEngine.Sprite>)+28]");
			object obj21 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v127 @ X3_v2 (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
			IL_0091:
			bool flag8 = obj4 == null;
			bool flag9 = !flag8;
			obj9 = 0;
			obj10 = null;
			if (!flag9)
			{
				return;
			}
			goto IL_0170;
		}
	}

	private sealed class <>c__DisplayClass46_0
	{
		public UnityEngine.Object go;

		public int giftId;

		public Action<Sprite> callback;

		internal void <LoadProfileGiftImage>b__0()
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_0105: Expected O, but got I4
			//IL_00b7: Expected O, but got I4
			//IL_017f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0184: Expected O, but got Unknown
			//IL_0202: Expected I8, but got I4
			//IL_0154: Expected O, but got I4
			//IL_015d: Expected O, but got I4
			//IL_01bc: Expected I8, but got I4
			//IL_01da: Expected O, but got I4
			//IL_0302: Expected O, but got I
			//IL_0312: Expected O, but got I
			//IL_0322: Expected O, but got I
			//IL_033b: Expected O, but got I4
			//IL_0255: Unknown result type (might be due to invalid IL or missing references)
			//IL_025a: Expected O, but got Unknown
			//IL_026b: Expected O, but got I
			//IL_028c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0291: Expected O, but got Unknown
			//IL_02bb: Expected O, but got I4
			object obj = 152981504;
			object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5FCE]");
			object obj3 = (nint)0 & (nint)1;
			UnityEngine.Object obj4;
			UnityEngine.Object obj6;
			if (obj3 != null)
			{
				obj4 = go;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v26+E4]");
				bool flag = (nint)0 == 0;
				obj6 = go;
				if (!flag)
				{
					goto IL_0091;
				}
			}
			else
			{
				_ = 1;
				obj4 = go;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v26+E4]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				obj6 = go;
				if (obj7 != null)
				{
					goto IL_0091;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = obj6 == null;
			bool flag4 = !flag3;
			object obj8 = !flag4;
			object obj9 = 0;
			UnityEngine.Object obj10 = null;
			if (obj8 != null)
			{
				return;
			}
			goto IL_0170;
			IL_0228:
			ProfileGiftModel profileGift;
			if (profileGift.Image == null)
			{
				goto IL_02e3;
			}
			object format = "placementId" + 1200;
			goto IL_032c;
			IL_032c:
			object obj11 = 153100288 + 1024;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			object arg = default(object);
			string text = string.Format((string)format, arg);
			FileInfoModel image = profileGift.Image;
			object obj12 = (nint)0 + (nint)2264;
			DateTime? dateTime = image.<lastModified>k__BackingField;
			object obj13 = typeof(RegisteredWaitHandle) + 40;
			object obj14 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X0_v14+E4]");
			bool flag5 = (nint)0 == 0;
			object obj15 = !flag5;
			if (obj15 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2FEEFBC");
			return;
			IL_02e3:
			Action<Sprite> action = callback;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X8_v8 (System.Action`1<UnityEngine.Sprite>)+18]");
			object obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X8_v8 (System.Action`1<UnityEngine.Sprite>)+40]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X8_v8 (System.Action`1<UnityEngine.Sprite>)+28]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v113 @ X3_v1 (should have been resolved before IL gen)");
			goto IL_032c;
			IL_0091:
			bool flag6 = obj4 == null;
			bool flag7 = !flag6;
			obj9 = 0;
			obj10 = null;
			if (!flag7)
			{
				return;
			}
			goto IL_0170;
			IL_0170:
			object obj19 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
			object obj20 = obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X0_v2+E4]");
			if ((nint)0 != 0)
			{
				profileGift = Store.GetProfileGift(giftId);
				bool flag8 = profileGift == null;
				object obj21 = !flag8;
				if (obj21 != null)
				{
					goto IL_0228;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				profileGift = Store.GetProfileGift(giftId);
				if (profileGift != null)
				{
					goto IL_0228;
				}
			}
			goto IL_02e3;
		}
	}

	private sealed class <>c__DisplayClass47_0
	{
		public UnityEngine.Object go;

		public string achievementID;

		public int level;

		public Action<Sprite> callback;

		internal void <LoadAchievementImage>b__0()
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_0105: Expected O, but got I4
			//IL_00b7: Expected O, but got I4
			//IL_017f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0184: Expected O, but got Unknown
			//IL_0154: Expected O, but got I4
			//IL_015d: Expected O, but got I4
			//IL_01da: Expected O, but got I4
			//IL_03ad: Expected O, but got I
			//IL_03bd: Expected O, but got I
			//IL_03cd: Expected O, but got I
			//IL_03f8: Expected O, but got I
			//IL_040d: Expected O, but got I
			//IL_0421: Unknown result type (might be due to invalid IL or missing references)
			//IL_0426: Expected O, but got Unknown
			//IL_0450: Expected O, but got I4
			//IL_02b5: Expected O, but got I
			//IL_02e0: Expected O, but got I
			//IL_0314: Unknown result type (might be due to invalid IL or missing references)
			//IL_0319: Expected O, but got Unknown
			//IL_0343: Expected O, but got I4
			//IL_0371: Expected O, but got I
			object obj = 152981504;
			object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5F08]");
			object obj3 = (nint)0 & (nint)1;
			UnityEngine.Object obj4;
			UnityEngine.Object obj6;
			if (obj3 != null)
			{
				obj4 = go;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v27+E4]");
				bool flag = (nint)0 == 0;
				obj6 = go;
				if (!flag)
				{
					goto IL_0091;
				}
			}
			else
			{
				_ = 1;
				obj4 = go;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v27+E4]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				obj6 = go;
				if (obj7 != null)
				{
					goto IL_0091;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = obj6 == null;
			bool flag4 = !flag3;
			object obj8 = !flag4;
			object obj9 = 0;
			UnityEngine.Object obj10 = null;
			if (obj8 != null)
			{
				return;
			}
			goto IL_0170;
			IL_0228:
			GameAchievementViewModel achievement;
			List<object> <achievementLevels>k__BackingField = (List<object>)(object)achievement.<achievementLevels>k__BackingField;
			if (achievement.<achievementLevels>k__BackingField != null)
			{
				int index = level - 1;
				if (level >= 1 && level <= <achievementLevels>k__BackingField._size)
				{
					object obj11 = (nint)0 + (nint)296;
					object obj12 = ((List<object>)(object)achievement.<achievementLevels>k__BackingField).get_Item(index);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X0_v9 (System.Object)+28]");
					object obj13 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X0_v9 (System.Object)+28]");
					if ((nint)0 != 0)
					{
						object obj14 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
						object obj15 = obj14;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X0_v10+E4]");
						bool flag5 = (nint)0 == 0;
						object obj16 = !flag5;
						if (obj16 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X23_v4+10]");
						if (!string.IsNullOrEmpty((string)0))
						{
							goto IL_03d7;
						}
					}
				}
			}
			goto IL_038e;
			IL_03d7:
			string achievementPath = GetAchievementPath(achievementID, level);
			object obj17 = (nint)0 + (nint)2264;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X23_v4+18]");
			DateTime? dateTime = (DateTime)0;
			object obj18 = typeof(RegisteredWaitHandle) + 40;
			object obj19 = obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ X0_v17+E4]");
			bool flag6 = (nint)0 == 0;
			object obj20 = !flag6;
			if (obj20 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2FEEFBC");
			return;
			IL_038e:
			Action<Sprite> action = callback;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X8_v8 (System.Action`1<UnityEngine.Sprite>)+18]");
			object obj21 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X8_v8 (System.Action`1<UnityEngine.Sprite>)+40]");
			object obj22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X8_v8 (System.Action`1<UnityEngine.Sprite>)+28]");
			object obj23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v124 @ X3_v1 (should have been resolved before IL gen)");
			goto IL_03d7;
			IL_0091:
			bool flag7 = obj4 == null;
			bool flag8 = !flag7;
			obj9 = 0;
			obj10 = null;
			if (!flag8)
			{
				return;
			}
			goto IL_0170;
			IL_0170:
			object obj24 = typeof(SqlSingle[]) + 2360;
			object obj25 = obj24;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X0_v2+E4]");
			if ((nint)0 != 0)
			{
				achievement = AchievementsManager.GetAchievement(achievementID);
				bool flag9 = achievement == null;
				object obj26 = !flag9;
				if (obj26 != null)
				{
					goto IL_0228;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				achievement = AchievementsManager.GetAchievement(achievementID);
				if (achievement != null)
				{
					goto IL_0228;
				}
			}
			goto IL_038e;
		}
	}

	[StructLayout((LayoutKind)3)]
	private struct <>c__DisplayClass50_0
	{
		public BannerSize type;

		public StoreBannerViewModel banner;
	}

	private sealed class <>c__DisplayClass54_0
	{
		public MassTournamentImageType type;

		internal bool <LoadMassTournamentImage>b__0(ImageInfoModel<MassTournamentImageType> image)
		{
			//IL_003e: Expected I4, but got O
			//IL_001c: Expected O, but got I
			if (image != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [image @ X1 (ImageInfoModel`1<ImageCacher+MassTournamentImageType>)+20]");
				object obj = (nint)0 - (nint)type;
				return obj == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass57_0
	{
		public SportTeamImageType type;

		internal bool <LoadSportTeamImage>b__0(ImageInfoModel<SportTeamImageType> model)
		{
			//IL_003e: Expected I4, but got O
			//IL_001c: Expected O, but got I
			if (model != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [model @ X1 (ImageInfoModel`1<ImageCacher+SportTeamImageType>)+20]");
				object obj = (nint)0 - (nint)type;
				return obj == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private const string UserboxAvatarPlaceholder = "Userbox-AvatarPlaceholder";

	private static Sprite _userboxAvatarPlaceholder;

	private const string AdminAvatarPlaceholder = "Kammelna_appIcon";

	private static Sprite _adminAvatarPlaceholder;

	public static Sprite AvatarPlaceholder
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Expected O, but got Unknown
			//IL_0047: Expected O, but got I
			//IL_011e: Expected O, but got I
			//IL_0150: Expected O, but got I4
			//IL_007c: Expected O, but got I
			//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b9: Expected O, but got Unknown
			//IL_01c5: Expected O, but got I
			//IL_00fb: Expected O, but got I
			//IL_019c: Expected O, but got I4
			object obj = 152981504;
			object obj2 = typeof(System.IOAsyncCallback) + 2472;
			object obj3 = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5EF5]");
			object obj4 = (nint)0 & (nint)1;
			UnityEngine.Object obj7;
			UnityEngine.Object obj9;
			if (obj4 != null)
			{
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X8_v15+B8]");
				object obj6 = 0;
				obj7 = (UnityEngine.Object)obj6;
				object obj8 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v7+E4]");
				bool flag = (nint)0 == 0;
				obj9 = (UnityEngine.Object)obj6;
				if (!flag)
				{
					goto IL_00b9;
				}
			}
			else
			{
				_ = 1;
				object obj10 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X8_v8+B8]");
				object obj11 = 0;
				obj7 = (UnityEngine.Object)obj11;
				object obj8 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v7+E4]");
				bool flag2 = (nint)0 == 0;
				object obj12 = !flag2;
				obj9 = (UnityEngine.Object)obj11;
				if (obj12 != null)
				{
					goto IL_00b9;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = obj9;
			bool flag4 = !flag3;
			object obj13 = !flag4;
			if (obj13 != null)
			{
				goto IL_00e3;
			}
			goto IL_01aa;
			IL_00e3:
			object obj14 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v12+B8]");
			return (Sprite)0;
			IL_01aa:
			object obj15 = "Unsupported map type" + 864;
			object obj16 = (nint)0 + (nint)2048;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2FF8ABC");
			object obj17 = obj2;
			Sprite sprite = default(Sprite);
			object obj18 = sprite;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			return sprite;
			IL_00b9:
			if ((bool)obj7)
			{
				goto IL_00e3;
			}
			goto IL_01aa;
		}
	}

	public static Sprite AdminPlaceholder
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Expected O, but got Unknown
			//IL_0047: Expected O, but got I
			//IL_0136: Expected O, but got I
			//IL_0146: Expected O, but got I
			//IL_0170: Expected O, but got I4
			//IL_0180: Expected O, but got I
			//IL_007c: Expected O, but got I
			//IL_008c: Expected O, but got I
			//IL_00bb: Expected O, but got I
			//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e1: Expected O, but got Unknown
			//IL_01ed: Expected O, but got I
			//IL_0215: Expected O, but got I
			//IL_010b: Expected O, but got I
			//IL_0118: Expected O, but got I
			//IL_01c4: Expected O, but got I4
			object obj = 152981504;
			object obj2 = typeof(System.IOAsyncCallback) + 2472;
			object obj3 = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5EF6]");
			object obj4 = (nint)0 & (nint)1;
			UnityEngine.Object obj7;
			UnityEngine.Object obj9;
			if (obj4 != null)
			{
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X8_v15+B8]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ X8_v16+8]");
				obj7 = (UnityEngine.Object)0;
				object obj8 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v8+E4]");
				bool flag = (nint)0 == 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ X8_v16+8]");
				obj9 = (UnityEngine.Object)0;
				if (!flag)
				{
					goto IL_00c9;
				}
			}
			else
			{
				_ = 1;
				object obj10 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X8_v8+B8]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X8_v9+8]");
				obj7 = (UnityEngine.Object)0;
				object obj8 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v8+E4]");
				bool flag2 = (nint)0 == 0;
				object obj12 = !flag2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X8_v9+8]");
				obj9 = (UnityEngine.Object)0;
				if (obj12 != null)
				{
					goto IL_00c9;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = obj9;
			bool flag4 = !flag3;
			object obj13 = !flag4;
			if (obj13 != null)
			{
				goto IL_00f3;
			}
			goto IL_01d2;
			IL_00f3:
			object obj14 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v12+B8]");
			object obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X8_v13+8]");
			return (Sprite)0;
			IL_01d2:
			object obj16 = "Invalid serialized DateTime data. Unable to find 'ticks' or 'dateData'." + 3640;
			object obj17 = (nint)0 + (nint)2048;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2FF8ABC");
			object obj18 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X8_v5+B8]");
			object obj19 = (nint)0 + (nint)8;
			Sprite sprite = default(Sprite);
			obj19 = sprite;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			return sprite;
			IL_00c9:
			if ((bool)obj7)
			{
				goto IL_00f3;
			}
			goto IL_01d2;
		}
	}

	private static string GetAvatarPath(string userID)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object obj = "alignContent" + 3456;
		return (string)obj + userID;
	}

	private static string GetAvatarThumbnailPath(string userID)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		object obj = "alignContent" + 3456;
		object obj2 = "___# Content push apply failed [{0}]: {1}" + 2408;
		return (string)obj + userID + (string)obj2;
	}

	private static string GetAppAnnouncementPath(AppAnnouncementModel model)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0024: Expected O, but got I4
		if (model != null)
		{
			object format = "alignContent" + 1992;
			object obj = 153100288 + 1024;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			object arg = default(object);
			return string.Format((string)format, arg);
		}
		return (string)(object)new NullReferenceException();
	}

	private static string GetAdCampaignLogoPath(int id)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0023: Expected O, but got I4
		object format = "___# Content push apply failed [{0}]: {1}" + 3280;
		object obj = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object arg = default(object);
		return string.Format((string)format, arg);
	}

	private static string GetProductPath(int id)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0023: Expected O, but got I4
		object format = "placementId" + 1176;
		object obj = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object arg = default(object);
		return string.Format((string)format, arg);
	}

	private unsafe static string GetItemPath(int itemID, ItemImageType itemImageType)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		//IL_0029: Expected O, but got I4
		//IL_003d: Expected O, but got Ref
		object format = "https://www.kammelna.com/Home/Terms" + 3920;
		object obj = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object obj2 = default(object);
		string arg = ((Enum)(&obj2)).ToString();
		object arg2 = default(object);
		return string.Format((string)format, arg2, arg);
	}

	private static string GetAchievementPath(string id, int level)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0023: Expected O, but got I4
		object format = "___# Content push apply failed [{0}]: {1}" + 2952;
		object obj = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object arg = default(object);
		return string.Format((string)format, id, arg);
	}

	private static string GetRoomElementPath(int itemID, int elementIndex)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0028: Expected O, but got I4
		object format = "https://www.kammelna.com/Home/Terms" + 3936;
		object obj = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object arg = default(object);
		object arg2 = default(object);
		return string.Format((string)format, arg, arg2);
	}

	private static string GetClanEmblemPath(int clanId, string file)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0023: Expected O, but got I4
		object format = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 4024;
		object obj = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object arg = default(object);
		return string.Format((string)format, arg, file);
	}

	private static string GetClanLogoElementPath(int id, int tier, ClanLogoElementImageType type)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0055: Expected O, but got I4
		object obj = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 2064;
		object format = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 4016;
		object obj2 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object arg = default(object);
		object arg2 = default(object);
		object arg3 = default(object);
		return string.Format((string)format, arg, arg2, arg3);
	}

	private static string GetNotificationPath(int id, NotificationImageType type)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_003c: Expected O, but got I4
		object obj = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 2088;
		object format = "not" + 192;
		object obj2 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object arg = default(object);
		object arg2 = default(object);
		return string.Format((string)format, arg, arg2);
	}

	private static string GetStoreBannerPath(string id, BannerSize type)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		object obj = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 2056;
		object format = "alignContent" + 3840;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object arg = default(object);
		return string.Format((string)format, id, arg);
	}

	private static string GetSportTeamPath(int id, SportTeamImageType type)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_003c: Expected O, but got I4
		object obj = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 2104;
		object format = "setMimeType" + 3616;
		object obj2 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object arg = default(object);
		object arg2 = default(object);
		return string.Format((string)format, arg, arg2);
	}

	private static string GetHighlightPath(string name)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected O, but got Unknown
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected O, but got Unknown
		//IL_00cc: Expected O, but got I4
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1624;
		object obj2 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2232;
		object obj3 = "getSecondRescanTask" + 2936;
		object obj4 = ", stale={0}" + 2920;
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Games currentGame = Preferences.CurrentGame;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		Enum enumeration = default(Enum);
		string friendlyName = EnumExtensions.GetFriendlyName(enumeration);
		return (string)obj3 + friendlyName + (string)obj4 + name;
	}

	private static string GetPredictionSeasonPath(FileInfoModel info)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0052: Expected O, but got I4
		if (info != null)
		{
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 72;
			object obj2 = "placementId" + 632;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(info.<url>k__BackingField);
			return (string)obj2 + fileNameWithoutExtension;
		}
		return (string)(object)new NullReferenceException();
	}

	private static string GetProfileGiftPath(long id)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0023: Expected O, but got I4
		object format = "placementId" + 1200;
		object obj = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object arg = default(object);
		return string.Format((string)format, arg);
	}

	private static string GetPredictAndWinPath(int id, PredictAndWinImageType type)
	{
		//IL_0139: Expected O, but got I4
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected O, but got Unknown
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected O, but got Unknown
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Expected O, but got I4
		//IL_0033: Expected O, but got I
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected O, but got Unknown
		//IL_0102: Expected O, but got I
		bool flag = type < (PredictAndWinImageType)4;
		object obj = !flag;
		if (obj == null)
		{
			object obj2 = "placementId" + 624;
			object obj3 = 139821056 + 2840;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X9_v2+type @ X1 (ImageCacher+PredictAndWinImageType)*8]");
			object obj4 = 0;
			string text = (string)obj2 + (string)obj4;
			int num = default(int);
			string text2 = num.ToString();
			return text + text2;
		}
		object obj5 = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 2096;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object obj6 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 656;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj7 = "tournament_participate_warning_body_with_tickets_warning_daily" + 968;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		ArgumentOutOfRangeException ex = default(ArgumentOutOfRangeException);
		string paramName = default(string);
		object actualValue = default(object);
		ex..ctor(paramName, actualValue, null);
		object obj8 = (nint)0 + (nint)2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		return (string)(object)new OutOfMemoryException();
	}

	private static string GetMassTournamentPath(MassEventModel massTournament, MassTournamentImageType imageType)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0038: Expected O, but got I4
		if (massTournament != null)
		{
			object obj = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 2080;
			object format = "LAK" + 3952;
			object obj2 = 153100288 + 1024;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			object arg = default(object);
			object arg2 = default(object);
			return string.Format((string)format, arg, arg2);
		}
		return (string)(object)new NullReferenceException();
	}

	private static string GetMassTournamentPrizeImage(long massTournamentId, MassEventPrizeViewModel prize)
	{
		//IL_005b: Expected O, but got I4
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		if (prize != null)
		{
			object format = "LAK" + 3944;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			object arg = default(object);
			object arg2 = default(object);
			return string.Format((string)format, arg, arg2);
		}
		return (string)(object)new NullReferenceException();
	}

	private static string GetMassTournamentBannerImage(long massTournamentId, MassEventSponsorBannerViewModel banner)
	{
		//IL_005b: Expected O, but got I4
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		if (banner != null)
		{
			object format = "LAK" + 3936;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			object arg = default(object);
			object arg2 = default(object);
			return string.Format((string)format, arg, arg2);
		}
		return (string)(object)new NullReferenceException();
	}

	private void Start()
	{
		CheckAvatarsDirectorySize();
	}

	private void CheckAvatarsDirectorySize()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Expected O, but got Unknown
		//IL_028c: Expected O, but got I4
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Expected O, but got Unknown
		//IL_02b6: Expected O, but got I
		//IL_019f: Expected O, but got I4
		//IL_01f0: Expected O, but got I4
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected O, but got Unknown
		//IL_00c8: Expected O, but got I
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Expected O, but got Unknown
		//IL_0113: Expected I, but got O
		//IL_0124: Expected I, but got O
		object obj = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 1976;
		object obj2 = (nint)0 + (nint)2000;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj3 = default(object);
		obj3..ctor();
		object obj4 = "alignContent" + 3456;
		string text = (string)obj4 + (string)obj2;
		object obj5 = 152981504;
		object obj6 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5FC8]");
		object obj7 = (nint)0 & (nint)1;
		if (obj7 != null)
		{
			object obj8 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X0_v13+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0052;
			}
		}
		else
		{
			_ = 1;
			object obj8 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X0_v13+E4]");
			bool flag = (nint)0 == 0;
			object obj9 = !flag;
			if (obj9 != null)
			{
				goto IL_0052;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		string cachePath = Config.CachePath;
		string text2 = cachePath + text;
		bool flag2 = obj3 == null;
		object obj10 = !flag2;
		nint num = 0;
		nint num2 = 0;
		string text3 = text;
		if (obj10 != null)
		{
			goto IL_00a8;
		}
		goto IL_0218;
		IL_022e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		string action;
		Task task = Task.Run((Action)(object)action);
		return;
		IL_00a8:
		object obj11 = typeof(SqlSingle[]) + 2376;
		object obj12 = (nint)0 + (nint)4000;
		object obj13 = typeof(System.Formats.Asn1.SetOfValueComparer) + 3912;
		object obj14 = obj3 + 16;
		obj14 = text2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		num2 = (nint)obj12;
		Action action2 = default(Action);
		action2..ctor(obj3, (IntPtr)obj12);
		NullReferenceException ex = (NullReferenceException)obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X0_v7 (System.NullReferenceException)+E4]");
		bool flag3 = (nint)0 == 0;
		text3 = (string)obj3;
		action = (string)(object)action2;
		if (!flag3)
		{
			Task task2 = Task.Run(action2);
			return;
		}
		goto IL_022e;
		IL_0218:
		ex = new NullReferenceException();
		action = text;
		goto IL_022e;
		IL_0052:
		string cachePath2 = Config.CachePath;
		text2 = cachePath2 + text;
		bool flag4 = obj3 == null;
		num = 0;
		num2 = 0;
		text3 = text;
		if (!flag4)
		{
			goto IL_00a8;
		}
		goto IL_0218;
	}

	public void LoadAvatarThumbnail(string userID, UnityEngine.Object go, DateTime timestamp, Action<Sprite> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected O, but got Unknown
		//IL_023d: Expected O, but got I4
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Expected O, but got Unknown
		//IL_0267: Expected O, but got I
		//IL_01bb: Expected O, but got I4
		//IL_00da: Expected O, but got I
		//IL_00f4: Expected O, but got I4
		//IL_0293: Unknown result type (might be due to invalid IL or missing references)
		//IL_0298: Expected O, but got Unknown
		//IL_02a4: Expected O, but got I
		//IL_02b0: Expected O, but got I
		//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c4: Expected O, but got Unknown
		//IL_02ee: Expected O, but got I4
		//IL_01e9: Expected O, but got I
		//IL_030c: Expected O, but got I
		//IL_0321: Expected O, but got I
		//IL_0340: Expected I, but got O
		//IL_0139: Expected O, but got I
		//IL_0163: Expected O, but got I4
		object obj = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 1984;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = obj2 + 24;
		obj4 = userID;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = obj2 + 32;
		obj5 = go;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = "alignContent" + 3456;
		string text = (string)obj6 + (string)obj4;
		object obj7 = 152981504;
		object obj8 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5FC9]");
		object obj9 = (nint)0 & (nint)1;
		if (obj9 != null)
		{
			object obj10 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X0_v29+E4]");
			if ((nint)0 != 0)
			{
				goto IL_00c4;
			}
		}
		else
		{
			_ = 1;
			object obj10 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X0_v29+E4]");
			bool flag = (nint)0 == 0;
			object obj11 = !flag;
			if (obj11 != null)
			{
				goto IL_00c4;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE458B]");
		object obj12 = (nint)0 & (nint)1;
		if (obj12 == null)
		{
			goto IL_0102;
		}
		goto IL_0284;
		IL_0284:
		object obj13 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3480;
		object obj14 = (nint)0 + (nint)4008;
		object obj15 = (nint)0 + (nint)2264;
		object obj16 = typeof(RegisteredWaitHandle) + 40;
		object obj17 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X0_v17+E4]");
		bool flag2 = (nint)0 == 0;
		object obj18 = !flag2;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj17 = obj8;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X0_v17+B8]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X8_v8+28]");
		string text2 = (string)0 + text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj14);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v3 (System.Object)+28]");
		DateTime? dateTime = (DateTime)0;
		object obj20 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X0_v23+E4]");
		bool flag3 = (nint)0 == 0;
		object obj21 = !flag3;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2FEF188");
		return;
		IL_0102:
		_ = 1;
		goto IL_0284;
		IL_00c4:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE458B]");
		object obj22 = (nint)0 & (nint)1;
		bool flag4 = obj22 == null;
		object obj23 = !flag4;
		if (obj23 == null)
		{
			goto IL_0102;
		}
		goto IL_0284;
	}

	public void LoadFullAvatarImage(string userID, UnityEngine.Object go, DateTime timestamp, Action<Sprite> callback)
	{
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected O, but got Unknown
		//IL_01b2: Expected O, but got I4
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Expected O, but got Unknown
		//IL_01dc: Expected O, but got I
		//IL_00dc: Expected O, but got I4
		//IL_0048: Expected O, but got I
		//IL_0062: Expected O, but got I4
		//IL_014c: Expected O, but got I
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected O, but got Unknown
		//IL_018a: Expected O, but got I4
		//IL_010a: Expected O, but got I
		//IL_0209: Expected O, but got I
		//IL_021e: Expected O, but got I
		//IL_0259: Expected O, but got I4
		object obj = "alignContent" + 3456;
		string text = (string)obj + userID;
		object obj2 = 152981504;
		object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5FC9]");
		object obj4 = (nint)0 & (nint)1;
		if (obj4 != null)
		{
			object obj5 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X0_v17+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0032;
			}
		}
		else
		{
			_ = 1;
			object obj5 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X0_v17+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = !flag;
			if (obj6 != null)
			{
				goto IL_0032;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE458B]");
		object obj7 = (nint)0 & (nint)1;
		if (obj7 == null)
		{
			goto IL_0070;
		}
		goto IL_0140;
		IL_0140:
		object obj8 = (nint)0 + (nint)2264;
		object obj9 = typeof(RegisteredWaitHandle) + 40;
		object obj10 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v7+E4]");
		bool flag2 = (nint)0 == 0;
		object obj11 = !flag2;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj10 = obj3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v7+B8]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X8_v8+28]");
		string text2 = (string)0 + text;
		DateTime? dateTime = timestamp;
		object obj13 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X0_v11+E4]");
		bool flag3 = (nint)0 == 0;
		object obj14 = !flag3;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2FEEFBC");
		return;
		IL_0070:
		_ = 1;
		goto IL_0140;
		IL_0032:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE458B]");
		object obj15 = (nint)0 & (nint)1;
		bool flag4 = obj15 == null;
		object obj16 = !flag4;
		if (obj16 == null)
		{
			goto IL_0070;
		}
		goto IL_0140;
	}

	public void LoadAppAnnouncementImage(AppAnnouncementModel appAnnouncement, UnityEngine.Object go, Action<Sprite> callback)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00e7: Expected O, but got I4
		//IL_00a3: Expected O, but got I4
		//IL_0210: Expected O, but got I
		//IL_0220: Expected O, but got I
		//IL_0230: Expected O, but got I
		//IL_012c: Expected O, but got I4
		//IL_0135: Expected O, but got I4
		//IL_0271: Expected O, but got I4
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Expected O, but got Unknown
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Expected O, but got Unknown
		//IL_0309: Expected O, but got I4
		//IL_0330: Expected O, but got I
		//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Expected O, but got Unknown
		//IL_02d1: Expected O, but got I4
		object obj = 152981504;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5FBA]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v25+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v25+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag2 = go == null;
		bool flag3 = !flag2;
		object obj6 = !flag3;
		object obj7 = 0;
		UnityEngine.Object obj8 = null;
		if (obj6 != null)
		{
			return;
		}
		goto IL_0148;
		IL_027f:
		object format = "alignContent" + 1992;
		object obj9 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object arg = default(object);
		string text = string.Format((string)format, arg);
		object obj10 = (nint)0 + (nint)2264;
		FileInfoModel <ButtonImage>k__BackingField = default(FileInfoModel);
		DateTime? dateTime = <ButtonImage>k__BackingField.<lastModified>k__BackingField;
		object obj11 = typeof(RegisteredWaitHandle) + 40;
		object obj12 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X0_v13+E4]");
		bool flag4 = (nint)0 == 0;
		object obj13 = !flag4;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2FEEFBC");
		return;
		IL_023a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag5 = string.IsNullOrEmpty(<ButtonImage>k__BackingField.<url>k__BackingField);
		bool flag6 = !flag5;
		object obj14 = !flag6;
		if (obj14 != null)
		{
			goto IL_0200;
		}
		goto IL_027f;
		IL_0200:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [callback @ X3 (System.Action`1<UnityEngine.Sprite>)+18]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [callback @ X3 (System.Action`1<UnityEngine.Sprite>)+40]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [callback @ X3 (System.Action`1<UnityEngine.Sprite>)+28]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v114 @ X3_v1 (should have been resolved before IL gen)");
		goto IL_023a;
		IL_007d:
		bool flag7 = go == null;
		bool flag8 = !flag7;
		obj7 = 0;
		obj8 = null;
		if (!flag8)
		{
			return;
		}
		goto IL_0148;
		IL_0148:
		if (appAnnouncement != null)
		{
			<ButtonImage>k__BackingField = appAnnouncement.<ButtonImage>k__BackingField;
			if (appAnnouncement.<ButtonImage>k__BackingField != null)
			{
				object obj18 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
				object obj19 = obj18;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X0_v5+E4]");
				if ((nint)0 == 0)
				{
					goto IL_023a;
				}
				if (!string.IsNullOrEmpty(<ButtonImage>k__BackingField.<url>k__BackingField))
				{
					goto IL_027f;
				}
			}
		}
		goto IL_0200;
	}

	public void LoadAdCampaignLogoImage(int adCampaignId, UnityEngine.Object go, Action<Sprite> callback)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00e2: Expected O, but got I4
		//IL_00a3: Expected O, but got I4
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Expected O, but got Unknown
		//IL_0394: Expected O, but got I4
		//IL_03b8: Expected O, but got I4
		//IL_03c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cc: Expected O, but got Unknown
		//IL_03e2: Expected O, but got I
		//IL_0127: Expected O, but got I4
		//IL_0130: Expected O, but got I4
		//IL_02ae: Expected O, but got I4
		//IL_0195: Expected O, but got I
		//IL_0319: Unknown result type (might be due to invalid IL or missing references)
		//IL_031e: Expected O, but got Unknown
		//IL_0348: Expected O, but got I4
		//IL_02dc: Expected O, but got I
		//IL_02f6: Expected O, but got I4
		//IL_0213: Expected O, but got I
		//IL_0228: Expected O, but got I
		//IL_0256: Expected O, but got I4
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Expected O, but got Unknown
		object obj = 152981504;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5FBB]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v35+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v35+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag2 = go == null;
		bool flag3 = !flag2;
		object obj6 = !flag3;
		object obj7 = 0;
		if (obj6 != null)
		{
			return;
		}
		goto IL_013e;
		IL_0304:
		_ = 1;
		object obj8 = typeof(RegisteredWaitHandle) + 40;
		object obj10;
		object obj9 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X0_v21+E4]");
		bool flag4 = (nint)0 == 0;
		object obj11 = !flag4;
		object obj12 = obj9;
		object obj13 = obj8;
		if (obj11 != null)
		{
			goto IL_0203;
		}
		goto IL_0366;
		IL_017f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE458B]");
		object obj14 = (nint)0 & (nint)1;
		if (obj14 != null)
		{
			goto IL_01b2;
		}
		goto IL_0304;
		IL_01b2:
		obj8 = typeof(RegisteredWaitHandle) + 40;
		obj9 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X0_v21+E4]");
		bool flag5 = (nint)0 == 0;
		obj12 = obj9;
		obj13 = obj8;
		if (!flag5)
		{
			goto IL_0203;
		}
		goto IL_0366;
		IL_007d:
		bool flag6 = go == null;
		bool flag7 = !flag6;
		obj7 = 0;
		if (!flag7)
		{
			return;
		}
		goto IL_013e;
		IL_013e:
		object format = "___# Content push apply failed [{0}]: {1}" + 3280;
		object obj15 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object arg = default(object);
		string text = string.Format((string)format, arg);
		object obj16 = 152981504;
		obj10 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5FC9]");
		object obj17 = (nint)0 & (nint)1;
		if (obj17 != null)
		{
			object obj18 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X0_v15+E4]");
			if ((nint)0 != 0)
			{
				goto IL_017f;
			}
		}
		else
		{
			_ = 1;
			object obj18 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X0_v15+E4]");
			bool flag8 = (nint)0 == 0;
			object obj19 = !flag8;
			if (obj19 != null)
			{
				goto IL_017f;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE458B]");
		object obj20 = (nint)0 & (nint)1;
		bool flag9 = obj20 == null;
		object obj21 = !flag9;
		if (obj21 != null)
		{
			goto IL_01b2;
		}
		goto IL_0304;
		IL_0203:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X0_v21+B8]");
		object obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X8_v17+28]");
		string text2 = (string)0 + text;
		object obj23 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X0_v24+E4]");
		bool flag10 = (nint)0 == 0;
		object obj24 = !flag10;
		if (obj24 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2FEEFBC");
		return;
		IL_0366:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj9 = obj10;
		obj8 = obj13;
		goto IL_0203;
	}

	public void LoadItemImage(int itemID, ItemImageType itemImageType, UnityEngine.Object go, Action<Sprite> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected O, but got Unknown
		//IL_00b7: Expected I, but got O
		//IL_00e6: Expected O, but got I4
		object obj = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 1992;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(SqlSingle[]) + 2376;
		object obj4 = (nint)0 + (nint)4016;
		object obj5 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
		object obj6 = obj2 + 16;
		obj6 = go;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj7 = obj2 + 32;
		obj7 = callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(obj2, (IntPtr)obj4);
		object obj8 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X0_v13+E4]");
		bool flag = (nint)0 == 0;
		object obj9 = !flag;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Store.CallWhenLoaded(action);
	}

	public void LoadAnimatedRoomImage(int itemID, int elementIndex, UnityEngine.Object go, Action<Sprite, int> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected O, but got Unknown
		//IL_00b7: Expected I, but got O
		//IL_00e6: Expected O, but got I4
		object obj = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 2000;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(SqlSingle[]) + 2376;
		object obj4 = (nint)0 + (nint)4032;
		object obj5 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
		object obj6 = obj2 + 16;
		obj6 = go;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj7 = obj2 + 32;
		obj7 = callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(obj2, (IntPtr)obj4);
		object obj8 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X0_v13+E4]");
		bool flag = (nint)0 == 0;
		object obj9 = !flag;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Store.CallWhenLoaded(action);
	}

	public void LoadProfileGiftImage(long giftId, UnityEngine.Object go, Action<Sprite> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected O, but got Unknown
		//IL_00b2: Expected I, but got O
		//IL_00e1: Expected O, but got I4
		object obj = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 2008;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(SqlSingle[]) + 2376;
		object obj4 = (nint)0 + (nint)4048;
		object obj5 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
		object obj6 = obj2 + 16;
		obj6 = go;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj7 = obj2 + 32;
		obj7 = callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(obj2, (IntPtr)obj4);
		object obj8 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X0_v13+E4]");
		bool flag = (nint)0 == 0;
		object obj9 = !flag;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Store.CallWhenLoaded(action);
	}

	public void LoadClanEmblem(int clanId, FileInfoModel emblem, UnityEngine.Object go, Action<Sprite> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00ed: Expected O, but got I4
		//IL_009c: Expected O, but got I4
		//IL_00a5: Expected O, but got I4
		//IL_015d: Expected O, but got I4
		//IL_0130: Expected O, but got I4
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Expected O, but got Unknown
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Expected O, but got Unknown
		//IL_01eb: Expected O, but got I4
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Expected O, but got Unknown
		//IL_02a3: Expected O, but got I4
		//IL_02ce: Expected O, but got I
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Expected O, but got Unknown
		//IL_0246: Expected O, but got I4
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5FBC]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v26+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v26+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag2 = go == null;
		bool flag3 = emblem == null;
		object obj5 = 0;
		UnityEngine.Object obj6 = null;
		if (!flag3)
		{
			goto IL_0143;
		}
		return;
		IL_0143:
		bool flag4 = !flag2;
		object obj7 = !flag4;
		if (obj7 == null)
		{
			object obj8 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 4024;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Uri uri = default(Uri);
			uri..ctor(emblem.<url>k__BackingField);
			string absolutePath = uri.AbsolutePath;
			object obj9 = typeof(System.Buffers.Text.ParserHelpers) + 72;
			object obj10 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X8_v8+E4]");
			bool flag5 = (nint)0 == 0;
			object obj11 = !flag5;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string fileName = Path.GetFileName(absolutePath);
			object format = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 4024;
			object obj12 = 153100288 + 1024;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			object arg = default(object);
			string text = string.Format((string)format, arg, fileName);
			object obj13 = (nint)0 + (nint)2264;
			DateTime? dateTime = emblem.<lastModified>k__BackingField;
			object obj14 = typeof(RegisteredWaitHandle) + 40;
			object obj15 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X0_v16+E4]");
			bool flag6 = (nint)0 == 0;
			object obj16 = !flag6;
			if (obj16 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2FEEFBC");
		}
		return;
		IL_0074:
		flag2 = go == null;
		bool flag7 = emblem == null;
		object obj17 = !flag7;
		obj5 = 0;
		obj6 = null;
		if (obj17 == null)
		{
			return;
		}
		goto IL_0143;
	}

	public void LoadClanLogoElementImage(int id, int tier, ClanLogoElementImageType type, UnityEngine.Object go, Action<Sprite> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_011f: Expected O, but got I4
		//IL_0128: Expected O, but got I4
		//IL_00d4: Expected O, but got I4
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected O, but got Unknown
		//IL_0165: Expected O, but got I
		//IL_0176: Expected I, but got O
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Expected O, but got Unknown
		//IL_01b9: Expected O, but got I4
		object obj = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 2016;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj4 = obj2 + 16;
		obj4 = go;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = obj2 + 40;
		obj5 = callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v10+E4]");
		if ((nint)0 != 0)
		{
			bool flag = (UnityEngine.Object)obj4 == null;
			bool flag2 = !flag;
			object obj7 = 0;
			UnityEngine.Object obj8 = null;
			if (!flag2)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = (UnityEngine.Object)obj4 == null;
			bool flag4 = !flag3;
			object obj9 = !flag4;
			object obj7 = 0;
			UnityEngine.Object obj8 = null;
			if (obj9 != null)
			{
				return;
			}
		}
		object obj10 = typeof(SqlSingle[]) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj11 = (nint)0 + (nint)4056;
		Action action = default(Action);
		action..ctor(obj2, (IntPtr)obj11);
		object obj12 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1272;
		object obj13 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X0_v14+E4]");
		bool flag5 = (nint)0 == 0;
		object obj14 = !flag5;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		ClanLogoElementCatalog.CallWhenLoaded(action);
	}

	public void LoadProfileGiftImage(int giftId, UnityEngine.Object go, Action<Sprite> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected O, but got Unknown
		//IL_00b2: Expected I, but got O
		//IL_00e1: Expected O, but got I4
		object obj = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 2024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(SqlSingle[]) + 2376;
		object obj4 = (nint)0 + (nint)4064;
		object obj5 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
		object obj6 = obj2 + 16;
		obj6 = go;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj7 = obj2 + 32;
		obj7 = callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(obj2, (IntPtr)obj4);
		object obj8 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X0_v13+E4]");
		bool flag = (nint)0 == 0;
		object obj9 = !flag;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Store.CallWhenLoaded(action);
	}

	public void LoadAchievementImage(string achievementID, int level, UnityEngine.Object go, Action<Sprite> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_0162: Expected O, but got I
		//IL_0172: Expected O, but got I
		//IL_0182: Expected O, but got I
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
		//IL_00c0: Expected O, but got I
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected O, but got Unknown
		//IL_00ef: Expected I, but got O
		//IL_011e: Expected O, but got I4
		object obj = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 2032;
		object obj2 = default(object);
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			obj2..ctor();
			object obj3 = obj2 + 16;
			obj3 = go;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj4 = obj2 + 24;
			obj4 = achievementID;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj5 = obj2 + 40;
			obj5 = callback;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			if (obj4 != null)
			{
				break;
			}
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v5+18]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v5+40]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v5+28]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v93 @ X3_v1 (should have been resolved before IL gen)");
		}
		object obj10 = typeof(SqlSingle[]) + 2376;
		object obj11 = (nint)0 + (nint)4072;
		object obj12 = typeof(SqlSingle[]) + 2360;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(obj2, (IntPtr)obj11);
		object obj13 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X0_v16+E4]");
		bool flag = (nint)0 == 0;
		object obj14 = !flag;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		AchievementsManager.CallWhenLoaded(action);
	}

	public void LoadHighlightImage(string highlightName, UnityEngine.Object go, Action<Sprite> callback)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00e7: Expected O, but got I4
		//IL_00a3: Expected O, but got I4
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected O, but got Unknown
		//IL_012c: Expected O, but got I4
		//IL_0135: Expected O, but got I4
		//IL_0224: Expected O, but got I4
		//IL_022d: Expected O, but got I4
		//IL_01aa: Expected O, but got I4
		//IL_01c8: Expected O, but got I
		//IL_01d8: Expected O, but got I
		//IL_01e8: Expected O, but got I
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Expected O, but got Unknown
		//IL_0272: Expected O, but got I
		//IL_03e3: Expected O, but got I4
		//IL_02d2: Expected O, but got I
		//IL_0469: Expected O, but got I4
		//IL_0411: Expected O, but got I
		//IL_042b: Expected O, but got I4
		//IL_0334: Expected O, but got I
		//IL_0349: Expected O, but got I
		//IL_035c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0361: Expected O, but got Unknown
		//IL_038b: Expected O, but got I4
		object obj = 152981504;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5FBD]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v39+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v39+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag2 = go == null;
		bool flag3 = !flag2;
		object obj6 = !flag3;
		object obj7 = 0;
		UnityEngine.Object obj8 = null;
		if (obj6 != null)
		{
			return;
		}
		goto IL_0148;
		IL_02bc:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE458B]");
		object obj9 = (nint)0 & (nint)1;
		if (obj9 != null)
		{
			goto IL_02ef;
		}
		goto IL_0439;
		IL_02ef:
		object obj11;
		object obj10 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X0_v20+E4]");
		bool flag4 = (nint)0 == 0;
		object obj12 = obj10;
		if (!flag4)
		{
			goto IL_0324;
		}
		goto IL_047f;
		IL_047f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj10 = obj11;
		goto IL_0324;
		IL_007d:
		bool flag5 = go == null;
		bool flag6 = !flag5;
		obj7 = 0;
		obj8 = null;
		if (!flag6)
		{
			return;
		}
		goto IL_0148;
		IL_0148:
		object obj13 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
		object obj14 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v2+E4]");
		if ((nint)0 == 0)
		{
			goto IL_01f2;
		}
		bool flag7 = string.IsNullOrEmpty(highlightName);
		bool flag8 = !flag7;
		object obj15 = 0;
		if (!flag8)
		{
			goto IL_01b8;
		}
		goto IL_023b;
		IL_0439:
		_ = 1;
		obj10 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X0_v20+E4]");
		bool flag9 = (nint)0 == 0;
		object obj16 = !flag9;
		obj12 = obj10;
		if (obj16 != null)
		{
			goto IL_0324;
		}
		goto IL_047f;
		IL_01b8:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [callback @ X3 (System.Action`1<UnityEngine.Sprite>)+18]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [callback @ X3 (System.Action`1<UnityEngine.Sprite>)+40]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [callback @ X3 (System.Action`1<UnityEngine.Sprite>)+28]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v112 @ X3_v2 (should have been resolved before IL gen)");
		goto IL_01f2;
		IL_01f2:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag10 = string.IsNullOrEmpty(highlightName);
		bool flag11 = !flag10;
		object obj20 = !flag11;
		obj15 = 0;
		if (obj20 != null)
		{
			goto IL_01b8;
		}
		goto IL_023b;
		IL_023b:
		string highlightPath = GetHighlightPath(highlightName);
		obj11 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5FC9]");
		object obj21 = (nint)0 & (nint)1;
		if (obj21 != null)
		{
			object obj22 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X0_v14+E4]");
			if ((nint)0 != 0)
			{
				goto IL_02bc;
			}
		}
		else
		{
			_ = 1;
			object obj22 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X0_v14+E4]");
			bool flag12 = (nint)0 == 0;
			object obj23 = !flag12;
			if (obj23 != null)
			{
				goto IL_02bc;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE458B]");
		object obj24 = (nint)0 & (nint)1;
		bool flag13 = obj24 == null;
		object obj25 = !flag13;
		if (obj25 != null)
		{
			goto IL_02ef;
		}
		goto IL_0439;
		IL_0324:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X0_v20+B8]");
		object obj26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X8_v16+28]");
		string text = (string)0 + highlightPath;
		object obj27 = typeof(RegisteredWaitHandle) + 40;
		object obj28 = obj27;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X0_v23+E4]");
		bool flag14 = (nint)0 == 0;
		object obj29 = !flag14;
		if (obj29 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2FEEFBC");
	}

	public void LoadProductImage(ProductViewModel productView, UnityEngine.Object go, Action<Sprite> callback)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00e7: Expected O, but got I4
		//IL_00a3: Expected O, but got I4
		//IL_0210: Expected O, but got I
		//IL_0220: Expected O, but got I
		//IL_0230: Expected O, but got I
		//IL_012c: Expected O, but got I4
		//IL_0135: Expected O, but got I4
		//IL_0271: Expected O, but got I4
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Expected O, but got Unknown
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Expected O, but got Unknown
		//IL_0309: Expected O, but got I4
		//IL_0330: Expected O, but got I
		//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Expected O, but got Unknown
		//IL_02d2: Expected O, but got I4
		object obj = 152981504;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5FBE]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v25+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v25+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag2 = go == null;
		bool flag3 = !flag2;
		object obj6 = !flag3;
		object obj7 = 0;
		UnityEngine.Object obj8 = null;
		if (obj6 != null)
		{
			return;
		}
		goto IL_0148;
		IL_027f:
		object format = "placementId" + 1176;
		object obj9 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object arg = default(object);
		string text = string.Format((string)format, arg);
		object obj10 = (nint)0 + (nint)2264;
		FileInfoModel <image>k__BackingField = default(FileInfoModel);
		DateTime? dateTime = <image>k__BackingField.<lastModified>k__BackingField;
		object obj11 = typeof(RegisteredWaitHandle) + 40;
		object obj12 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X0_v13+E4]");
		bool flag4 = (nint)0 == 0;
		object obj13 = !flag4;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2FEEFBC");
		return;
		IL_023a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag5 = string.IsNullOrEmpty(<image>k__BackingField.<url>k__BackingField);
		bool flag6 = !flag5;
		object obj14 = !flag6;
		if (obj14 != null)
		{
			goto IL_0200;
		}
		goto IL_027f;
		IL_0200:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [callback @ X3 (System.Action`1<UnityEngine.Sprite>)+18]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [callback @ X3 (System.Action`1<UnityEngine.Sprite>)+40]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [callback @ X3 (System.Action`1<UnityEngine.Sprite>)+28]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v114 @ X3_v1 (should have been resolved before IL gen)");
		goto IL_023a;
		IL_007d:
		bool flag7 = go == null;
		bool flag8 = !flag7;
		obj7 = 0;
		obj8 = null;
		if (!flag8)
		{
			return;
		}
		goto IL_0148;
		IL_0148:
		if (productView != null)
		{
			<image>k__BackingField = productView.<image>k__BackingField;
			if (productView.<image>k__BackingField != null)
			{
				object obj18 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
				object obj19 = obj18;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X0_v5+E4]");
				if ((nint)0 == 0)
				{
					goto IL_023a;
				}
				if (!string.IsNullOrEmpty(<image>k__BackingField.<url>k__BackingField))
				{
					goto IL_027f;
				}
			}
		}
		goto IL_0200;
	}

	public unsafe void LoadStoreBannerImage(StoreBannerViewModel banner, BannerSize type, UnityEngine.Object go, Action<Sprite> callback)
	{
		//IL_016d: Expected O, but got Ref
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_009e: Expected O, but got I
		//IL_00bd: Expected O, but got I4
		//IL_0057: Expected O, but got I
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected O, but got Unknown
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected O, but got Unknown
		//IL_01b9: Expected O, but got I
		//IL_01ce: Expected O, but got I
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_0132: Expected O, but got I4
		<>c__DisplayClass50_0 <>c__DisplayClass50_ = default(<>c__DisplayClass50_0);
		object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref <>c__DisplayClass50_, 8));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		ImageInfoModel<BannerSize> imageInfoModel = <LoadStoreBannerImage>g__GetImage|50_0(ref <>c__DisplayClass50_);
		object obj2 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v8+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v5 (ImageInfoModel`1<ImageCacher+BannerSize>)+10]");
			if (string.IsNullOrEmpty((string)0))
			{
				goto IL_0074;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v5 (ImageInfoModel`1<ImageCacher+BannerSize>)+10]");
			bool flag = string.IsNullOrEmpty((string)0);
			bool flag2 = !flag;
			object obj4 = !flag2;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		object obj5 = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 2056;
		object format = "alignContent" + 3840;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		StoreBannerViewModel storeBannerViewModel = default(StoreBannerViewModel);
		object arg = default(object);
		string text = string.Format((string)format, storeBannerViewModel.<id>k__BackingField, arg);
		object obj6 = (nint)0 + (nint)2264;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v5 (ImageInfoModel`1<ImageCacher+BannerSize>)+18]");
		DateTime? dateTime = (DateTime)0;
		object obj7 = typeof(RegisteredWaitHandle) + 40;
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X0_v17+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2FEEFBC");
		return;
		IL_0074:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [callback @ X4 (System.Action`1<UnityEngine.Sprite>)+18] (should have been resolved before IL gen)");
	}

	public void LoadNotificationImage(Notification notification, NotificationImageType type, UnityEngine.Object go, Action<Sprite> callback)
	{
		//IL_001f: Expected O, but got I4
		//IL_007e: Expected O, but got I4
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Expected O, but got Unknown
		//IL_031c: Expected O, but got I
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Expected O, but got Unknown
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Expected O, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		//IL_02d9: Expected O, but got I
		//IL_0053: Expected O, but got I4
		//IL_0169: Expected O, but got I
		//IL_0188: Expected O, but got I4
		//IL_00d5: Expected O, but got I
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Expected O, but got Unknown
		//IL_0350: Expected O, but got I4
		//IL_0369: Unknown result type (might be due to invalid IL or missing references)
		//IL_036e: Expected O, but got Unknown
		//IL_0124: Expected O, but got I
		//IL_0134: Expected O, but got I
		//IL_0144: Expected O, but got I
		//IL_01bd: Expected O, but got I
		//IL_01d2: Expected O, but got I
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Expected O, but got Unknown
		//IL_0210: Expected O, but got I4
		Notification notification2 = default(Notification);
		if (type != NotificationImageType.Large)
		{
			bool flag = type == NotificationImageType.Small;
			object obj = !flag;
			if (obj != null)
			{
				object obj2 = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 2088;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
				object obj3 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 656;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj4 = "tournament_participate_warning_body_with_tickets_warning_daily" + 968;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
				ArgumentOutOfRangeException ex = default(ArgumentOutOfRangeException);
				string paramName = default(string);
				object actualValue = default(object);
				ex..ctor(paramName, actualValue, null);
				object obj5 = (nint)0 + (nint)2384;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
				throw new OutOfMemoryException();
			}
			if (notification2 == null)
			{
				goto IL_0238;
			}
			object obj6 = 136;
		}
		else
		{
			if (notification2 == null)
			{
				goto IL_0238;
			}
			object obj6 = 128;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X1_v15 (Notification)+v96 @ X8_v3]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X1_v15 (Notification)+v96 @ X8_v3]");
		Notification notification3;
		if ((nint)0 != 0)
		{
			object obj8 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X0_v2+E4]");
			if ((nint)0 == 0)
			{
				goto IL_014e;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X23_v2+10]");
			bool flag2 = string.IsNullOrEmpty((string)0);
			bool flag3 = !flag2;
			notification3 = null;
			if (!flag3)
			{
				goto IL_00f7;
			}
			goto IL_019b;
		}
		goto IL_0238;
		IL_019b:
		object format = "not" + 192;
		object obj10 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object obj11 = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 2088;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object arg = default(object);
		object arg2 = default(object);
		string text = string.Format((string)format, arg, arg2);
		object obj12 = (nint)0 + (nint)2264;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X23_v2+18]");
		DateTime? dateTime = (DateTime)0;
		object obj13 = typeof(RegisteredWaitHandle) + 40;
		object obj14 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X0_v12+E4]");
		bool flag4 = (nint)0 == 0;
		object obj15 = !flag4;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2FEEFBC");
		return;
		IL_0238:
		throw new NullReferenceException();
		IL_00f7:
		if (callback != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [callback @ X4 (System.Action`1<UnityEngine.Sprite>)+18]");
			object obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [callback @ X4 (System.Action`1<UnityEngine.Sprite>)+40]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [callback @ X4 (System.Action`1<UnityEngine.Sprite>)+28]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v152 @ X3_v3 (should have been resolved before IL gen)");
			goto IL_014e;
		}
		goto IL_0238;
		IL_014e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X23_v2+10]");
		bool flag5 = string.IsNullOrEmpty((string)0);
		bool flag6 = !flag5;
		object obj19 = !flag6;
		notification3 = null;
		if (obj19 != null)
		{
			goto IL_00f7;
		}
		goto IL_019b;
	}

	public void LoadPredictAndWinImage(MatchPredictionModel model, PredictAndWinImageType type, UnityEngine.Object go, Action<Sprite> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00d0: Expected O, but got I4
		//IL_01c9: Expected O, but got I
		//IL_01d9: Expected O, but got I
		//IL_01e9: Expected O, but got I
		//IL_0115: Expected O, but got I4
		//IL_04d7: Expected O, but got I
		//IL_028a: Expected O, but got I
		//IL_02bb: Expected O, but got I4
		//IL_036b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0370: Expected O, but got Unknown
		//IL_03f9: Expected O, but got I
		//IL_0352: Expected I4, but got I8
		//IL_0418: Expected O, but got I4
		//IL_03ae: Expected O, but got I
		//IL_044b: Expected O, but got I
		//IL_0460: Expected O, but got I
		//IL_0474: Unknown result type (might be due to invalid IL or missing references)
		//IL_0479: Expected O, but got Unknown
		//IL_04a3: Expected O, but got I4
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5F02]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v25+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v25+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag2 = go == null;
		bool flag3 = !flag2;
		object obj5 = !flag3;
		if (obj5 != null)
		{
			return;
		}
		goto IL_0123;
		IL_03d3:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [callback @ X4 (System.Action`1<UnityEngine.Sprite>)+18] (should have been resolved before IL gen)");
		return;
		IL_027e:
		object obj6 = (nint)0 + (nint)3792;
		object obj7 = obj6;
		(object, int) tuple = (null, 0);
		bool flag4 = (object)tuple == null;
		object obj8 = !flag4;
		int num = 0;
		object obj9 = null;
		(object, int) tuple2 = tuple;
		int id = 0;
		if (obj8 != null)
		{
			goto IL_035c;
		}
		object obj10 = obj6;
		goto IL_03d3;
		IL_04cb:
		object obj11 = (nint)0 + (nint)3792;
		obj7 = obj11;
		tuple = (obj9, num);
		bool flag5 = (object)tuple == null;
		tuple2 = tuple;
		id = 0;
		obj10 = obj11;
		if (!flag5)
		{
			goto IL_035c;
		}
		goto IL_03d3;
		IL_0074:
		if (go == null)
		{
			return;
		}
		goto IL_0123;
		IL_0123:
		if (model != null)
		{
			if (type <= PredictAndWinImageType.SponsorLogo)
			{
				if (type != PredictAndWinImageType.LeagueLogo)
				{
					if (type != PredictAndWinImageType.SponsorLogo)
					{
						goto IL_027e;
					}
					obj9 = model.<sponsorLogo>k__BackingField;
					num = model.<sponsorId>k__BackingField;
				}
				else
				{
					League <league>k__BackingField = model.<league>k__BackingField;
					obj9 = model.<leagueLogo>k__BackingField;
					num = <league>k__BackingField.<id>k__BackingField;
				}
				goto IL_04cb;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [callback @ X4 (System.Action`1<UnityEngine.Sprite>)+18]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [callback @ X4 (System.Action`1<UnityEngine.Sprite>)+40]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [callback @ X4 (System.Action`1<UnityEngine.Sprite>)+28]");
			object obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v119 @ X3_v2 (should have been resolved before IL gen)");
		}
		if (type != PredictAndWinImageType.SponsorImage)
		{
			if (type != PredictAndWinImageType.TweetImage)
			{
				goto IL_027e;
			}
			Tweet <tweetImage>k__BackingField = model.<tweetImage>k__BackingField;
			if (model.<tweetImage>k__BackingField != null)
			{
				obj9 = <tweetImage>k__BackingField.<image>k__BackingField;
				num = <tweetImage>k__BackingField.<id>k__BackingField;
			}
			else
			{
				num = -1;
				obj9 = null;
			}
		}
		else
		{
			obj9 = model.<sponsorImage>k__BackingField;
			num = model.<sponsorId>k__BackingField;
		}
		goto IL_04cb;
		IL_035c:
		object obj15 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
		object obj16 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X0_v10+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v355 @ X24_v8 (System.ValueTuple`2<System.Object, System.Int32>)+10]");
			bool flag6 = string.IsNullOrEmpty((string)0);
			bool flag7 = !flag6;
			obj10 = obj7;
			if (!flag7)
			{
				goto IL_03d3;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v355 @ X24_v8 (System.ValueTuple`2<System.Object, System.Int32>)+10]");
			bool flag8 = string.IsNullOrEmpty((string)0);
			bool flag9 = !flag8;
			object obj17 = !flag9;
			obj10 = obj7;
			if (obj17 != null)
			{
				goto IL_03d3;
			}
		}
		string predictAndWinPath = GetPredictAndWinPath(id, type);
		object obj18 = (nint)0 + (nint)2264;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v355 @ X24_v8 (System.ValueTuple`2<System.Object, System.Int32>)+18]");
		DateTime? dateTime = (DateTime)0;
		object obj19 = typeof(RegisteredWaitHandle) + 40;
		object obj20 = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X0_v15+E4]");
		bool flag10 = (nint)0 == 0;
		object obj21 = !flag10;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2FEEFBC");
	}

	public void LoadPredictionSeasonImage(PredictionSeasonModel model, UnityEngine.Object go, Action<Sprite> callback)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00e7: Expected O, but got I4
		//IL_00a3: Expected O, but got I4
		//IL_03d4: Expected O, but got I
		//IL_03e4: Expected O, but got I
		//IL_03f4: Expected O, but got I
		//IL_012c: Expected O, but got I4
		//IL_0135: Expected O, but got I4
		//IL_042e: Expected O, but got I4
		//IL_020a: Expected O, but got I
		//IL_0180: Expected O, but got I4
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Expected O, but got Unknown
		//IL_01aa: Expected O, but got I
		//IL_04b4: Expected O, but got I4
		//IL_045c: Expected O, but got I
		//IL_0476: Expected O, but got I4
		//IL_026c: Expected O, but got I
		//IL_0286: Expected O, but got I
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b0: Expected O, but got Unknown
		//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bf: Expected O, but got Unknown
		//IL_02e9: Expected O, but got I4
		//IL_034c: Expected O, but got I
		//IL_036d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0372: Expected O, but got Unknown
		//IL_039c: Expected O, but got I4
		object obj = 152981504;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5FC1]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v45+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v45+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag2 = go == null;
		bool flag3 = !flag2;
		object obj6 = !flag3;
		object obj7 = 0;
		UnityEngine.Object obj8 = null;
		if (obj6 != null)
		{
			return;
		}
		goto IL_0148;
		IL_01f4:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE458B]");
		object obj9 = (nint)0 & (nint)1;
		if (obj9 != null)
		{
			goto IL_0227;
		}
		goto IL_0484;
		IL_043c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE458B]");
		object obj10 = (nint)0 & (nint)1;
		bool flag4 = obj10 == null;
		object obj11 = !flag4;
		if (obj11 != null)
		{
			goto IL_0227;
		}
		goto IL_0484;
		IL_025c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X0_v19+B8]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X8_v15+28]");
		FileInfoModel <Image>k__BackingField = default(FileInfoModel);
		string text = (string)0 + <Image>k__BackingField.<url>k__BackingField;
		FileInfoModel <Image>k__BackingField2 = model.<Image>k__BackingField;
		object obj13 = typeof(System.Buffers.Text.ParserHelpers) + 72;
		object obj14 = "placementId" + 632;
		object obj15 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X0_v23+E4]");
		bool flag5 = (nint)0 == 0;
		object obj16 = !flag5;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(<Image>k__BackingField2.<url>k__BackingField);
		string text2 = (string)obj14 + fileNameWithoutExtension;
		FileInfoModel <Image>k__BackingField3 = model.<Image>k__BackingField;
		object obj17 = (nint)0 + (nint)2264;
		DateTime? dateTime = <Image>k__BackingField3.<lastModified>k__BackingField;
		object obj18 = typeof(RegisteredWaitHandle) + 40;
		object obj19 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X0_v30+E4]");
		bool flag6 = (nint)0 == 0;
		object obj20 = !flag6;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2FEEFBC");
		return;
		IL_007d:
		bool flag7 = go == null;
		bool flag8 = !flag7;
		obj7 = 0;
		obj8 = null;
		if (!flag8)
		{
			return;
		}
		goto IL_0148;
		IL_0148:
		object obj22 = default(object);
		object obj24;
		if (model != null)
		{
			<Image>k__BackingField = model.<Image>k__BackingField;
			object obj21 = 152981504;
			obj22 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5FC9]");
			object obj23 = (nint)0 & (nint)1;
			if (obj23 != null)
			{
				obj24 = obj22;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X0_v13+E4]");
				if ((nint)0 != 0)
				{
					goto IL_01f4;
				}
				goto IL_043c;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [callback @ X3 (System.Action`1<UnityEngine.Sprite>)+18]");
			object obj25 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [callback @ X3 (System.Action`1<UnityEngine.Sprite>)+40]");
			object obj26 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [callback @ X3 (System.Action`1<UnityEngine.Sprite>)+28]");
			object obj27 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v103 @ X3_v1 (should have been resolved before IL gen)");
		}
		_ = 1;
		obj24 = obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X0_v13+E4]");
		bool flag9 = (nint)0 == 0;
		object obj28 = !flag9;
		if (obj28 != null)
		{
			goto IL_01f4;
		}
		goto IL_043c;
		IL_04ca:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj29 = obj22;
		goto IL_025c;
		IL_0227:
		obj29 = obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X0_v19+E4]");
		bool flag10 = (nint)0 == 0;
		object obj30 = obj29;
		if (!flag10)
		{
			goto IL_025c;
		}
		goto IL_04ca;
		IL_0484:
		_ = 1;
		obj29 = obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X0_v19+E4]");
		bool flag11 = (nint)0 == 0;
		object obj31 = !flag11;
		obj30 = obj29;
		if (obj31 != null)
		{
			goto IL_025c;
		}
		goto IL_04ca;
	}

	public void LoadMassTournamentImage(MassEventModel massTournament, MassTournamentImageType type, UnityEngine.Object go, Action<Sprite> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0043: Expected O, but got I
		//IL_005f: Expected I, but got O
		//IL_014c: Expected O, but got I
		//IL_015c: Expected O, but got I
		//IL_016c: Expected O, but got I
		//IL_00a3: Expected O, but got I
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected O, but got Unknown
		//IL_00e5: Expected O, but got I
		//IL_0114: Expected O, but got I4
		object obj = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 2040;
		object obj2 = default(object);
		Func<object, bool> func = default(Func<object, bool>);
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			obj2..ctor();
			object obj3 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 3424;
			object obj4 = (nint)0 + (nint)4080;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			func..ctor(obj2, (IntPtr)obj4);
			object obj5 = Enumerable.FirstOrDefault(massTournament.<Images>k__BackingField, func);
			if (obj5 != null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [callback @ X4 (System.Action`1<UnityEngine.Sprite>)+18]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [callback @ X4 (System.Action`1<UnityEngine.Sprite>)+40]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [callback @ X4 (System.Action`1<UnityEngine.Sprite>)+28]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v134 @ X3_v3 (should have been resolved before IL gen)");
		}
		object obj9 = (nint)0 + (nint)2264;
		object obj10 = typeof(RegisteredWaitHandle) + 40;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v3 (System.Object)+10]");
		string massTournamentPath = GetMassTournamentPath(massTournament, MassTournamentImageType.BigAd);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v9 (System.Object)+18]");
		DateTime? dateTime = (DateTime)0;
		object obj11 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X0_v14+E4]");
		bool flag = (nint)0 == 0;
		object obj12 = !flag;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2FEEFBC");
	}

	public void LoadMassTournamentPrizeImage(MassEventPrizeViewModel massTournamentPrize, long massTournamentId, UnityEngine.Object go, Action<Sprite> callback)
	{
		//IL_00e1: Expected O, but got I
		//IL_00f1: Expected O, but got I
		//IL_0101: Expected O, but got I
		//IL_011a: Expected O, but got I4
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		//IL_0059: Expected O, but got I
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		//IL_00a9: Expected O, but got I4
		object format = default(object);
		if (massTournamentPrize.<Image>k__BackingField != null)
		{
			format = "LAK" + 3944;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [callback @ X4 (System.Action`1<UnityEngine.Sprite>)+18]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [callback @ X4 (System.Action`1<UnityEngine.Sprite>)+40]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [callback @ X4 (System.Action`1<UnityEngine.Sprite>)+28]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v100 @ X3_v2 (should have been resolved before IL gen)");
		}
		object obj4 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object arg = default(object);
		object arg2 = default(object);
		string text = string.Format((string)format, arg, arg2);
		FileInfoModel <Image>k__BackingField = massTournamentPrize.<Image>k__BackingField;
		object obj5 = (nint)0 + (nint)2264;
		object obj6 = typeof(RegisteredWaitHandle) + 40;
		DateTime? dateTime = <Image>k__BackingField.<lastModified>k__BackingField;
		object obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X0_v13+E4]");
		bool flag = (nint)0 == 0;
		object obj8 = !flag;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2FEEFBC");
	}

	public void LoadMassTournamentBannerImage(MassEventSponsorBannerViewModel banner, long massTournamentId, UnityEngine.Object go, Action<Sprite> callback)
	{
		//IL_00e1: Expected O, but got I
		//IL_00f1: Expected O, but got I
		//IL_0101: Expected O, but got I
		//IL_011a: Expected O, but got I4
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		//IL_0059: Expected O, but got I
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		//IL_00a9: Expected O, but got I4
		object format = default(object);
		if (banner.<Image>k__BackingField != null)
		{
			format = "LAK" + 3936;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [callback @ X4 (System.Action`1<UnityEngine.Sprite>)+18]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [callback @ X4 (System.Action`1<UnityEngine.Sprite>)+40]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [callback @ X4 (System.Action`1<UnityEngine.Sprite>)+28]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v100 @ X3_v2 (should have been resolved before IL gen)");
		}
		object obj4 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object arg = default(object);
		object arg2 = default(object);
		string text = string.Format((string)format, arg, arg2);
		FileInfoModel <Image>k__BackingField = banner.<Image>k__BackingField;
		object obj5 = (nint)0 + (nint)2264;
		object obj6 = typeof(RegisteredWaitHandle) + 40;
		DateTime? dateTime = <Image>k__BackingField.<lastModified>k__BackingField;
		object obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X0_v13+E4]");
		bool flag = (nint)0 == 0;
		object obj8 = !flag;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2FEEFBC");
	}

	public void LoadSportTeamImage(SportTeam team, SportTeamImageType type, UnityEngine.Object go, Action<Sprite> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0043: Expected O, but got I
		//IL_004f: Expected O, but got I
		//IL_006a: Expected I, but got O
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected O, but got Unknown
		//IL_014e: Expected O, but got I
		//IL_016d: Expected O, but got I4
		//IL_00dc: Expected O, but got I
		//IL_0109: Expected O, but got I
		//IL_0119: Expected O, but got I
		//IL_0129: Expected O, but got I
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected O, but got Unknown
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Expected O, but got Unknown
		//IL_0253: Expected O, but got I4
		//IL_01b1: Expected O, but got I
		//IL_01c6: Expected O, but got I
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Expected O, but got Unknown
		//IL_0204: Expected O, but got I4
		object obj = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 2048;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 3432;
		object obj4 = (nint)0 + (nint)4088;
		object obj5 = (nint)0 + (nint)104;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<object, bool> func = default(Func<object, bool>);
		func..ctor(obj2, (IntPtr)obj4);
		object obj6 = Enumerable.First(team.<images>k__BackingField, func);
		object obj7 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X8_v8+E4]");
		if ((nint)0 == 0)
		{
			goto IL_0133;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v9 (System.Object)+10]");
		if (string.IsNullOrEmpty((string)0))
		{
			goto IL_00f9;
		}
		goto IL_017b;
		IL_017b:
		object obj9 = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 2104;
		object format = "setMimeType" + 3616;
		object obj10 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object arg = default(object);
		object arg2 = default(object);
		string text = string.Format((string)format, arg, arg2);
		object obj11 = (nint)0 + (nint)2264;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v9 (System.Object)+18]");
		DateTime? dateTime = (DateTime)0;
		object obj12 = typeof(RegisteredWaitHandle) + 40;
		object obj13 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X0_v20+E4]");
		bool flag = (nint)0 == 0;
		object obj14 = !flag;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2FEEFBC");
		return;
		IL_00f9:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [callback @ X4 (System.Action`1<UnityEngine.Sprite>)+18]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [callback @ X4 (System.Action`1<UnityEngine.Sprite>)+40]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [callback @ X4 (System.Action`1<UnityEngine.Sprite>)+28]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v136 @ X3_v5 (should have been resolved before IL gen)");
		goto IL_0133;
		IL_0133:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v9 (System.Object)+10]");
		bool flag2 = string.IsNullOrEmpty((string)0);
		bool flag3 = !flag2;
		object obj18 = !flag3;
		if (obj18 != null)
		{
			goto IL_00f9;
		}
		goto IL_017b;
	}

	public void UpdatePersonalAvatar(byte[] imageBytes)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00da: Expected O, but got I
		//IL_0104: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Expected O, but got Unknown
		//IL_0161: Expected I, but got O
		//IL_0171: Expected O, but got I
		//IL_031b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0320: Expected O, but got Unknown
		//IL_01ac: Expected O, but got I
		//IL_0405: Unknown result type (might be due to invalid IL or missing references)
		//IL_040a: Expected O, but got Unknown
		//IL_0334: Unknown result type (might be due to invalid IL or missing references)
		//IL_0339: Expected O, but got Unknown
		//IL_0363: Expected O, but got I4
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Expected O, but got Unknown
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Expected O, but got Unknown
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Expected O, but got Unknown
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Expected O, but got Unknown
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Expected O, but got Unknown
		//IL_0282: Expected O, but got I4
		//IL_0389: Unknown result type (might be due to invalid IL or missing references)
		//IL_038e: Expected O, but got Unknown
		//IL_03d7: Expected O, but got I4
		object obj = 152981504;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5FC5]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v54+E4]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v54+E4]");
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
		IL_01ed:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0307;
		IL_0307:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v238 @ X0_v6] (should have been resolved before IL gen)");
		object obj8 = "alignContent" + 3456;
		string text2 = default(string);
		string text = (string)obj8 + text2;
		object obj9 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		object obj10 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 488;
		object obj11 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X0_v13+E4]");
		bool flag3 = (nint)0 == 0;
		object obj12 = !flag3;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string cachePath = Config.CachePath;
		string path = cachePath + text;
		object obj13 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ X8_v16+E4]");
		bool flag4 = (nint)0 == 0;
		object obj14 = !flag4;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		FileUtils.SaveFile(path, imageBytes);
		object obj15 = "___# Content push apply failed [{0}]: {1}" + 2408;
		string text3 = (string)obj8 + text2 + (string)obj15;
		object obj16 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ X0_v23+E4]");
		bool flag5 = (nint)0 == 0;
		object obj17 = !flag5;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string cachePath2 = Config.CachePath;
		string path2 = cachePath2 + text3;
		FileUtils.SaveFile(path2, imageBytes);
		return;
		IL_0133:
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		object obj18 = typeof(UsageHint) + 8;
		nint num = (nint)localUser;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v8 (Il2CppClass<Sfs2X.Entities.User>)+12E]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v8 (Il2CppClass<Sfs2X.Entities.User>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_01ed;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v8 (Il2CppClass<Sfs2X.Entities.User>)+B0]");
		object obj20 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X10_v5-8]");
			if (0 == (nint)obj18)
			{
				break;
			}
			obj20 += 16;
			obj19--;
			if ((nint)obj19 != 1)
			{
				continue;
			}
			goto IL_01ed;
		}
		object obj21 = obj20 + 1;
		object obj22 = num + obj21;
		object obj23 = obj22 + 312;
		goto IL_0307;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag6 = (object)sessionModel == null;
		object obj24 = !flag6;
		if (obj24 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0133;
	}

	public void DeletePersonalAvatar()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00da: Expected O, but got I
		//IL_0104: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Expected O, but got Unknown
		//IL_0161: Expected I, but got O
		//IL_0171: Expected O, but got I
		//IL_01ac: Expected O, but got I
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Expected O, but got Unknown
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Expected O, but got Unknown
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Expected O, but got Unknown
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Expected O, but got Unknown
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Expected O, but got Unknown
		object obj = 152981504;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5FC6]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v15+E4]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v15+E4]");
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
		IL_01ed:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0255;
		IL_0255:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v205 @ X0_v6] (should have been resolved before IL gen)");
		ImageCacher imageCacher = default(ImageCacher);
		imageCacher.DeleteAvatar((string)(object)imageCacher);
		return;
		IL_0133:
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		object obj8 = typeof(UsageHint) + 8;
		nint num = (nint)localUser;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X8_v8 (Il2CppClass<Sfs2X.Entities.User>)+12E]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X8_v8 (Il2CppClass<Sfs2X.Entities.User>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_01ed;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X8_v8 (Il2CppClass<Sfs2X.Entities.User>)+B0]");
		object obj10 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X10_v5-8]");
			if (0 == (nint)obj8)
			{
				break;
			}
			obj10 += 16;
			obj9--;
			if ((nint)obj9 != 1)
			{
				continue;
			}
			goto IL_01ed;
		}
		object obj11 = obj10 + 1;
		object obj12 = num + obj11;
		object obj13 = obj12 + 312;
		goto IL_0255;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag3 = (object)sessionModel == null;
		object obj14 = !flag3;
		if (obj14 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0133;
	}

	public void DeleteAvatar(string userId)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_00b3: Expected O, but got I4
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		object obj = typeof(RegisteredWaitHandle) + 40;
		object obj2 = "alignContent" + 3456;
		string assetId = (string)obj2 + userId;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		RemoteAssetsCacher.DeleteAsset(assetId);
		object obj5 = "___# Content push apply failed [{0}]: {1}" + 2408;
		string assetId2 = (string)obj2 + userId + (string)obj5;
		RemoteAssetsCacher.DeleteAsset(assetId2);
	}

	private static string GetLocalImagePath(string imageID)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0076: Expected O, but got I4
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string cachePath = Config.CachePath;
		return cachePath + imageID;
	}

	private static string GetRemoteImagePath(string imageId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_013a: Expected O, but got I4
		//IL_008a: Expected O, but got I
		//IL_01c0: Expected O, but got I4
		//IL_0168: Expected O, but got I
		//IL_0182: Expected O, but got I4
		//IL_00ec: Expected O, but got I
		//IL_0101: Expected O, but got I
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5FC9]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v9+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v9+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE458B]");
		object obj5 = (nint)0 & (nint)1;
		bool flag2 = obj5 == null;
		object obj6 = !flag2;
		if (obj6 != null)
		{
			goto IL_00a7;
		}
		goto IL_0190;
		IL_00dc:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v15+B8]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X8_v11+28]");
		return (string)0 + imageId;
		IL_01d6:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj8 = obj;
		goto IL_00dc;
		IL_00a7:
		obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v15+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = obj8;
		if (!flag3)
		{
			goto IL_00dc;
		}
		goto IL_01d6;
		IL_0074:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE458B]");
		object obj10 = (nint)0 & (nint)1;
		if (obj10 != null)
		{
			goto IL_00a7;
		}
		goto IL_0190;
		IL_0190:
		_ = 1;
		obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v15+E4]");
		bool flag4 = (nint)0 == 0;
		object obj11 = !flag4;
		obj9 = obj8;
		if (obj11 != null)
		{
			goto IL_00dc;
		}
		goto IL_01d6;
	}

	public ImageCacher()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00ae: Expected O, but got I
		//IL_00d8: Expected O, but got I4
		//IL_005c: Expected O, but got I
		object obj = 152981504;
		object obj2 = typeof(Queue<string>) + 760;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5F04]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2032;
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
			object obj4 = (nint)0 + (nint)2032;
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

	internal static ImageInfoModel<BannerSize> <LoadStoreBannerImage>g__GetImage|50_0(ref <>c__DisplayClass50_0 P_0)
	{
		//IL_005f: Expected O, but got I
		//IL_0071: Expected O, but got I
		//IL_0041: Expected O, but got I4
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected O, but got Unknown
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected O, but got Unknown
		//IL_0107: Expected O, but got I
		if ((nint)P_0 != 1)
		{
			bool flag = (object)P_0 == null;
			object obj = !flag;
			if (obj != null)
			{
				object obj2 = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 2056;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
				object obj3 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 656;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj4 = "tournament_participate_warning_body_with_tickets_warning_daily" + 968;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
				ArgumentOutOfRangeException ex = default(ArgumentOutOfRangeException);
				string paramName = default(string);
				object actualValue = default(object);
				ex..ctor(paramName, actualValue, null);
				object obj5 = (nint)0 + (nint)2368;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
				return (ImageInfoModel<BannerSize>)(object)new OutOfMemoryException();
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ @ X0 (<>c__DisplayClass50_0&)+8]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ X8_v2+38]");
		return (ImageInfoModel<BannerSize>)0;
	}
}
