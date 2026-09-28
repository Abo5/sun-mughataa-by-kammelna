using System;
using System.Buffers.Text;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Dynamic.Utils;
using System.Formats.Asn1;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2ILInjected;
using DataTracking;
using Features.GameReplay;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Kammelna.Server.WebRequests;
using Server.Models;
using Server.Models.Products;
using Sfs2X.Entities;
using Sfs2X.Entities.Data;
using Spine;
using Unity.Properties;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.Rendering;

public class Store : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<StoreItem, string> <>9__42_0;

		public static Func<IGrouping<string, StoreItem>, int> <>9__42_1;

		public static Func<StoreItem, ItemCategory> <>9__56_0;

		public static Func<IGrouping<ItemCategory, StoreItem>, ItemCategory> <>9__56_1;

		public static Func<IGrouping<ItemCategory, StoreItem>, List<StoreItem>> <>9__56_2;

		public static Func<KeyValuePair<ItemCategory, List<StoreItem>>, IEnumerable<StoreItem>> <>9__62_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(SkeletonBinary.SkeletonInput) + 1304;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal string <AssignStoreValuesToScene>b__42_0(StoreItem item)
		{
			if (item != null)
			{
				return item.<group>k__BackingField;
			}
			return (string)(object)new NullReferenceException();
		}

		internal int <AssignStoreValuesToScene>b__42_1(IGrouping<string, StoreItem> g)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_015a: Expected I4, but got O
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Expected O, but got Unknown
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Expected O, but got Unknown
			//IL_0124: Expected O, but got I
			//IL_0090: Expected O, but got I
			//IL_00aa: Expected O, but got I4
			//IL_0199: Unknown result type (might be due to invalid IL or missing references)
			//IL_019e: Expected O, but got Unknown
			//IL_01aa: Expected O, but got I
			//IL_01d5: Expected O, but got I4
			//IL_01f3: Expected O, but got I
			//IL_020e: Expected I, but got O
			//IL_0223: Expected O, but got I
			object obj = typeof(SkeletonBinary.SkeletonInput) + 1312;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3;
			if (obj2 != null)
			{
				obj3 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
				object obj4 = obj2 + 16;
				obj4 = g;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj5 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v8+E4]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45AD]");
					object obj6 = (nint)0 & (nint)1;
					bool flag = obj6 == null;
					object obj7 = !flag;
					if (obj7 == null)
					{
						goto IL_00b8;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45AD]");
					object obj8 = (nint)0 & (nint)1;
					if (obj8 == null)
					{
						goto IL_00b8;
					}
				}
				goto IL_018a;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
			IL_00b8:
			_ = 1;
			goto IL_018a;
			IL_018a:
			object obj9 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2024;
			object obj10 = (nint)0 + (nint)1312;
			object obj11 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X0_v11+E4]");
			bool flag2 = (nint)0 == 0;
			object obj12 = !flag2;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj11 = obj3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X0_v11+B8]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj2, (IntPtr)obj10);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X8_v6+10]");
			object obj14 = Enumerable.FirstOrDefault((IEnumerable<object>)0, func);
			if (obj14 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X0_v15 (System.Object)+20]");
				return 0;
			}
			return 2147483647;
		}

		internal ItemCategory <AssignStoreModels>b__56_0(StoreItem i)
		{
			//IL_0035: Expected I4, but got O
			if (i != null)
			{
				return i.<category>k__BackingField;
			}
			NullReferenceException ex = new NullReferenceException();
			return (ItemCategory)ex;
		}

		internal ItemCategory <AssignStoreModels>b__56_1(IGrouping<ItemCategory, StoreItem> g)
		{
			//IL_0124: Expected I4, but got O
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0021: Expected I, but got O
			//IL_0031: Expected O, but got I
			//IL_00cf: Expected O, but got I
			//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e6: Expected O, but got Unknown
			//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f4: Expected O, but got Unknown
			//IL_010c: Expected O, but got I
			//IL_006c: Expected O, but got I
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected O, but got Unknown
			//IL_0088: Unknown result type (might be due to invalid IL or missing references)
			//IL_008d: Expected O, but got Unknown
			nint num;
			object obj3 = default(object);
			if (g != null)
			{
				object obj = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 1528;
				num = (nint)g;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v5 (Il2CppClass<System.Linq.IGrouping`2<ItemCategory, StoreItem>>)+12E]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v5 (Il2CppClass<System.Linq.IGrouping`2<ItemCategory, StoreItem>>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_00ad;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v5 (Il2CppClass<System.Linq.IGrouping`2<ItemCategory, StoreItem>>)+B0]");
				obj3 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X10_v4-8]");
					if (0 == (nint)obj)
					{
						break;
					}
					obj3 += 16;
					obj2--;
					if ((nint)obj2 != 1)
					{
						continue;
					}
					goto IL_00ad;
				}
				goto IL_00d9;
			}
			goto IL_0116;
			IL_0116:
			NullReferenceException ex = new NullReferenceException();
			return (ItemCategory)ex;
			IL_00ad:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			object obj5 = default(object);
			object obj4 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v4+8]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v107 @ X2_v2 (should have been resolved before IL gen)");
			goto IL_00d9;
			IL_00d9:
			object obj7 = num + obj3;
			object obj8 = obj7 + 312;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X0_v6+8]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v118 @ X2_v3 (should have been resolved before IL gen)");
			goto IL_0116;
		}

		internal List<StoreItem> <AssignStoreModels>b__56_2(IGrouping<ItemCategory, StoreItem> g)
		{
			return (List<StoreItem>)(object)Enumerable.ToList((IEnumerable<object>)g);
		}

		internal IEnumerable<StoreItem> <GetStoreItem>b__62_0(KeyValuePair<ItemCategory, List<StoreItem>> c)
		{
			//IL_000a: Expected O, but got I
			IntPtr intPtr = default(IntPtr);
			return (IEnumerable<StoreItem>)(nint)intPtr;
		}
	}

	private sealed class <>c__DisplayClass42_0
	{
		public IGrouping<string, StoreItem> g;

		internal bool <AssignStoreValuesToScene>b__2(ItemGroup ig)
		{
			//IL_0113: Expected I4, but got O
			//IL_003d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Expected O, but got Unknown
			//IL_004a: Expected I, but got O
			//IL_005a: Expected O, but got I
			//IL_0095: Expected O, but got I
			//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f2: Expected O, but got Unknown
			//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0100: Expected O, but got Unknown
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b6: Expected O, but got Unknown
			if (ig != null)
			{
				IGrouping<string, StoreItem> grouping = g;
				if (g != null)
				{
					object obj = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 1544;
					nint num = (nint)grouping;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v5 (Il2CppClass<System.Linq.IGrouping`2<System.String, StoreItem>>)+12E]");
					object obj2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v5 (Il2CppClass<System.Linq.IGrouping`2<System.String, StoreItem>>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_00d6;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v5 (Il2CppClass<System.Linq.IGrouping`2<System.String, StoreItem>>)+B0]");
					object obj3 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X10_v5-8]");
						if (0 == (nint)obj)
						{
							break;
						}
						obj3 += 16;
						obj2--;
						if ((nint)obj2 != 1)
						{
							continue;
						}
						goto IL_00d6;
					}
					object obj4 = num + obj3;
					object obj5 = obj4 + 312;
					goto IL_0154;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_00d6:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			goto IL_0154;
			IL_0154:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v168 @ X0_v3] (should have been resolved before IL gen)");
			string text = default(string);
			return ig.<Name>k__BackingField == text;
		}
	}

	private sealed class <>c__DisplayClass47_0
	{
		public List<StoreItem> cardItems;

		public int? tempId;

		internal void <ShowBuyCardPopup>b__0(BuyCardPopup popup)
		{
			popup.Popup(cardItems, tempId);
		}
	}

	private sealed class <>c__DisplayClass48_0
	{
		public UniqueStoreItem uniqueStoreItem;

		public StoreItem cardItem;

		public int? templateId;

		internal void <ShowBuyUniqueCardPopup>b__0(BuyUniqueItemPopup popup)
		{
			popup.StartBuyDialogue(uniqueStoreItem, cardItem, templateId);
		}
	}

	private sealed class <>c__DisplayClass49_0
	{
		public Bundle item;

		internal void <ShowBundlePopup>b__0(BundleInfoPopup popup)
		{
			popup.PopulatePopup(item);
		}
	}

	private sealed class <>c__DisplayClass62_0
	{
		public int itemID;

		internal bool <GetStoreItem>b__1(StoreItem i)
		{
			//IL_0053: Expected I4, but got O
			//IL_0031: Expected O, but got I4
			if (i != null)
			{
				object obj = i.<id>k__BackingField - itemID;
				return obj == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass63_0
	{
		public GameAction action;

		internal bool <GetStoreItem>b__0(StoreItem i)
		{
			//IL_0053: Expected I4, but got O
			//IL_0031: Expected O, but got I4
			if (i != null)
			{
				object obj = i.<GameAction>k__BackingField - action;
				return obj == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass66_0
	{
		public long giftID;

		internal bool <GetProfileGift>b__0(ProfileGiftModel g)
		{
			//IL_0053: Expected I4, but got O
			//IL_0031: Expected O, but got I8
			if (g != null)
			{
				object obj = g.ID - giftID;
				return obj == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <LoadStoreRoutine>d__54 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state;

		private object <>2__current;

		private Coroutine[] <>7__wrap1;

		private int <>7__wrap2;

		object IEnumerator<object>.Current => <>2__current;

		object IEnumerator.Current => <>2__current;

		public <LoadStoreRoutine>d__54(int <>1__state)
		{
			this.<>1__state = <>1__state;
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0334: Expected I4, but got I8
			//IL_0623: Unknown result type (might be due to invalid IL or missing references)
			//IL_0628: Expected O, but got Unknown
			//IL_0021: Expected O, but got I4
			//IL_05fe: Expected I4, but got O
			//IL_0374: Expected O, but got I4
			//IL_003e: Expected I4, but got I8
			//IL_004d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0052: Expected O, but got Unknown
			//IL_006b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0070: Expected O, but got Unknown
			//IL_009a: Expected O, but got I4
			//IL_03f0: Expected O, but got I4
			//IL_0409: Unknown result type (might be due to invalid IL or missing references)
			//IL_040e: Expected O, but got Unknown
			//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c6: Expected O, but got Unknown
			//IL_055b: Expected O, but got I4
			//IL_0487: Expected O, but got I4
			//IL_0578: Unknown result type (might be due to invalid IL or missing references)
			//IL_057d: Expected O, but got Unknown
			//IL_05a7: Expected O, but got I4
			//IL_03b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_03b6: Expected O, but got Unknown
			//IL_03bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_03c1: Expected O, but got Unknown
			//IL_03d1: Expected O, but got I
			//IL_065d: Expected O, but got I
			//IL_05ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_05d3: Expected O, but got Unknown
			//IL_011e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0123: Expected O, but got Unknown
			//IL_013f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0144: Expected O, but got Unknown
			//IL_0170: Expected O, but got I8
			//IL_04c2: Expected O, but got I
			//IL_04d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_04d6: Expected O, but got Unknown
			//IL_0500: Expected O, but got I4
			//IL_0196: Unknown result type (might be due to invalid IL or missing references)
			//IL_019b: Expected O, but got Unknown
			//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bc: Expected O, but got Unknown
			//IL_01f0: Expected O, but got I4
			//IL_0206: Expected O, but got I
			//IL_0226: Unknown result type (might be due to invalid IL or missing references)
			//IL_022b: Expected O, but got Unknown
			//IL_0242: Unknown result type (might be due to invalid IL or missing references)
			//IL_0247: Expected O, but got Unknown
			//IL_0268: Unknown result type (might be due to invalid IL or missing references)
			//IL_026d: Expected O, but got Unknown
			//IL_02b2: Expected O, but got I8
			//IL_02d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_02dd: Expected O, but got Unknown
			//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_02fa: Expected O, but got Unknown
			int num;
			if (<>1__state != 1)
			{
				bool flag = <>1__state == 0;
				object obj = !flag;
				if (obj != null)
				{
					goto IL_0527;
				}
				<>1__state = -1;
				object obj2 = typeof(TypeConverter<ushort, char>) + 2096;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
				object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2872;
				object obj4 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X0_v37+E4]");
				bool flag2 = (nint)0 == 0;
				object obj5 = !flag2;
				if (obj5 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object wireKey = "startPosition" + 664;
				Coroutine coroutine = ContentSyncService.EnsureFreshCoroutine((string)wireKey);
				object obj6 = default(object);
				if (obj6 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v36+18]");
					if ((nint)0 != 0)
					{
						object obj7 = obj6 + 32;
						obj7 = coroutine;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						object wireKey2 = "startPosition" + 680;
						Coroutine coroutine2 = ContentSyncService.EnsureFreshCoroutine((string)wireKey2);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X21_v9-8]");
						object obj8 = 0 & 0xFFFFFFFEL;
						if (obj8 != null)
						{
							object obj9 = obj6 + 40;
							obj9 = coroutine2;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							object wireKey3 = "startPosition" + 672;
							Coroutine coroutine3 = ContentSyncService.EnsureFreshCoroutine((string)wireKey3);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X21_v11-10]");
							bool flag3 = (nint)0 < (nint)2;
							object obj10 = !flag3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X21_v11-10]");
							object obj11 = -2;
							bool flag4 = obj11 == null;
							object obj12 = ~obj10;
							object obj13 = obj12 | flag4;
							if (obj13 == null)
							{
								object obj14 = obj6 + 48;
								obj14 = coroutine3;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								object obj15 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2768;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
								GetStoreItemGroupsRequest getStoreItemGroupsRequest = default(GetStoreItemGroupsRequest);
								getStoreItemGroupsRequest..ctor();
								Coroutine coroutine4 = WebRequestExtensions.Send((IWebRequest<object>)getStoreItemGroupsRequest);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X21_v13-18]");
								object obj16 = 0 & 0xFFFFFFFCL;
								if (obj16 != null)
								{
									object obj17 = obj6 + 56;
									obj17 = coroutine4;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
									object obj18 = this + 32;
									obj18 = obj6;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
									_ = 0;
									num = 0;
									goto IL_061d;
								}
							}
						}
					}
					goto IL_05e2;
				}
				goto IL_05f0;
			}
			<>1__state = -1;
			num = ++<>7__wrap2;
			goto IL_061d;
			IL_05f0:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_061d:
			object obj19 = this + 32;
			object obj20 = obj19;
			object obj24;
			if (obj19 != null)
			{
				int num2 = num;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X9_v1+18]");
				bool flag5 = (nint)num2 < (nint)0;
				object obj21 = !flag5;
				int num3 = num;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X9_v1+18]");
				if ((nint)num3 < (nint)0)
				{
					if (obj21 == null)
					{
						object obj22 = obj19 + num;
						object obj23 = this + 24;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X8_v16+20]");
						obj23 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						_ = 1;
						return true;
					}
					goto IL_05e2;
				}
				obj19 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				obj24 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
				object obj25 = obj24;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X0_v6+E4]");
				if ((nint)0 != 0)
				{
					if (AssignStoreModels())
					{
						goto IL_045d;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					bool flag6 = AssignStoreModels();
					bool flag7 = !flag6;
					object obj26 = !flag7;
					if (obj26 != null)
					{
						goto IL_045d;
					}
				}
				object obj27 = typeof(DataRelation) + 856;
				object obj28 = obj27;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ X0_v8+E4]");
				bool flag8 = (nint)0 == 0;
				object obj29 = !flag8;
				if (obj29 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object message = "___# Content push apply failed [{0}]: {1}" + 776;
				Debug.LogError(message);
				return false;
			}
			goto IL_05f0;
			IL_045d:
			object obj30 = obj24;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X0_v17+E4]");
			bool flag9 = (nint)0 == 0;
			object obj31 = !flag9;
			if (obj31 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj30 = obj24;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X0_v17+B8]");
			object obj32 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X8_v12+18]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X8_v12+18]");
				((OneShotEvent)0).IsReady = true;
				object obj33 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
				object obj34 = obj33;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ X0_v19+E4]");
				bool flag10 = (nint)0 == 0;
				object obj35 = !flag10;
				if (obj35 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Tracker.UserProfile();
				goto IL_0527;
			}
			goto IL_05f0;
			IL_0527:
			return false;
			IL_05e2:
			IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
			goto IL_05f0;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0042: Expected O, but got I
			object obj = typeof(MemberAchievementClanFeedData) + 2648;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			NotSupportedException ex = default(NotSupportedException);
			ex..ctor();
			object obj2 = (nint)0 + (nint)1368;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			throw new OutOfMemoryException();
		}
	}

	public const string EXPIRED_THEME = "room_theme_is_expired";

	public const string NOT_ENOUGH_ACES = "not_enough_aces";

	public const string NOT_ENOUGH_ACES_REMAINING = "not_enough_aces_you_need";

	public const string NOT_ENOUGH_ACES_MESSAGE = "you_dont_have_enough_aces";

	public const string ALREADY_OWNS_CARD = "this_card_is_already_purchased";

	private static Dictionary<ItemCategory, List<StoreItem>> <StoreCategories>k__BackingField;

	private static List<ProfileGiftModel> <ProfileGifts>k__BackingField;

	private static List<ItemGroup> <ItemGroups>k__BackingField;

	private RotatingLoadingIndicator storeLoadingIndicator;

	private StoreCardGroup storeCardGroup;

	private StoreRoomThemesGroup storeRoomThemesGroup;

	private StoreHomePageGroup storeHomePageGroup;

	private ComponentReference<BuyCardPopup> buyCardPopupRef;

	private ComponentReference<BuyUniqueItemPopup> buyUniqueCardPopupRef;

	private ComponentReference<BundleInfoPopup> bundlePopupRef;

	private StoreSoundAlbum soundAlbum;

	private static readonly OneShotEvent readyStatus;

	private static Store ActiveInstance;

	private static Dictionary<ItemCategory, List<StoreItem>> StoreCategories
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00ca: Expected O, but got I4
			//IL_0095: Expected O, but got I
			//IL_0102: Expected O, but got I
			object obj = 152985600;
			object obj2 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E69CB]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = obj4;
				if (!flag)
				{
					goto IL_0085;
				}
			}
			else
			{
				_ = 1;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+E4]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				object obj5 = obj4;
				if (obj6 != null)
				{
					goto IL_0085;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj7 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v3+B8]");
			return (Dictionary<ItemCategory, List<StoreItem>>)0;
			IL_0085:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+B8]");
			return (Dictionary<ItemCategory, List<StoreItem>>)0;
		}
		set
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_005a: Expected O, but got I4
			object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	private static List<ProfileGiftModel> ProfileGifts
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00d2: Expected O, but got I4
			//IL_0095: Expected O, but got I
			//IL_00a2: Expected O, but got I
			//IL_010a: Expected O, but got I
			//IL_0117: Expected O, but got I
			object obj = 152985600;
			object obj2 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E69CD]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = obj4;
				if (!flag)
				{
					goto IL_0085;
				}
			}
			else
			{
				_ = 1;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+E4]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				object obj5 = obj4;
				if (obj6 != null)
				{
					goto IL_0085;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj7 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v3+B8]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v3+8]");
			return (List<ProfileGiftModel>)0;
			IL_0085:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+B8]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v7+8]");
			return (List<ProfileGiftModel>)0;
		}
		set
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_005a: Expected O, but got I4
			//IL_007e: Expected O, but got I
			object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+B8]");
			object obj4 = (nint)0 + (nint)8;
			obj4 = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	private static List<ItemGroup> ItemGroups
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00d2: Expected O, but got I4
			//IL_0095: Expected O, but got I
			//IL_00a2: Expected O, but got I
			//IL_010a: Expected O, but got I
			//IL_0117: Expected O, but got I
			object obj = 152985600;
			object obj2 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E69CF]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = obj4;
				if (!flag)
				{
					goto IL_0085;
				}
			}
			else
			{
				_ = 1;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+E4]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				object obj5 = obj4;
				if (obj6 != null)
				{
					goto IL_0085;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj7 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v3+B8]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v3+10]");
			return (List<ItemGroup>)0;
			IL_0085:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+B8]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v7+10]");
			return (List<ItemGroup>)0;
		}
		set
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_005a: Expected O, but got I4
			//IL_007e: Expected O, but got I
			object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+B8]");
			object obj4 = (nint)0 + (nint)16;
			obj4 = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public static bool IsLoaded
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_0107: Expected O, but got I4
			//IL_0095: Expected O, but got I
			//IL_00a5: Expected O, but got I
			//IL_018d: Expected I4, but got O
			//IL_013f: Expected O, but got I
			//IL_014f: Expected O, but got I
			//IL_0171: Expected O, but got I4
			object obj = 152985600;
			object obj2 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6A86]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v12+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = obj4;
				if (!flag)
				{
					goto IL_0085;
				}
			}
			else
			{
				_ = 1;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v12+E4]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				object obj5 = obj4;
				if (obj6 != null)
				{
					goto IL_0085;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj7 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v5+B8]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X8_v4+18]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X8_v4+18]");
			bool flag3 = (nint)0 == 0;
			object obj10 = !flag3;
			if (obj10 != null)
			{
				goto IL_00ca;
			}
			goto IL_017f;
			IL_00ca:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v8+18]");
			return false;
			IL_017f:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_0085:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v12+B8]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v10+18]");
			obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v10+18]");
			if ((nint)0 != 0)
			{
				goto IL_00ca;
			}
			goto IL_017f;
		}
	}

	public static DateTime LastStoreSeenDate
	{
		get
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			//IL_0022: Expected O, but got I4
			object key = "LAK" + 544;
			return Prefs.GetDate((string)key, (DateTime)0);
		}
		set
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Expected O, but got Unknown
			//IL_00c9: Expected O, but got I
			//IL_00d9: Expected O, but got I
			//IL_00fb: Expected O, but got I4
			//IL_007d: Expected O, but got I
			//IL_008d: Expected O, but got I
			//IL_009d: Expected O, but got I
			//IL_0038: Expected O, but got I
			//IL_0048: Expected O, but got I
			object key = "LAK" + 544;
			object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
			Prefs.SetDate((string)key, value);
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v3+E4]");
			object obj4;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v3+B8]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v8+28]");
				obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v8+28]");
				if ((nint)0 != 0)
				{
					goto IL_006d;
				}
				return;
			}
			goto IL_00a7;
			IL_00a7:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v6+B8]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v5+28]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v5+28]");
			bool flag = (nint)0 == 0;
			object obj7 = !flag;
			if (obj7 == null)
			{
				return;
			}
			goto IL_006d;
			IL_006d:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v7+18]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v7+40]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v7+28]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v65 @ X2_v2 (should have been resolved before IL gen)");
			goto IL_00a7;
		}
	}

	public static bool HasNewStoreSinceLastVisit
	{
		get
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Expected O, but got Unknown
			//IL_0058: Expected O, but got I4
			//IL_0084: Unknown result type (might be due to invalid IL or missing references)
			//IL_0089: Expected O, but got Unknown
			//IL_0093: Unknown result type (might be due to invalid IL or missing references)
			//IL_0098: Expected O, but got Unknown
			//IL_01c2: Expected O, but got I4
			//IL_01f0: Expected O, but got I4
			//IL_0185: Expected I4, but got O
			//IL_0115: Unknown result type (might be due to invalid IL or missing references)
			//IL_011a: Expected O, but got Unknown
			//IL_0144: Expected O, but got I4
			object key = "HH:mm:ss.ffZ" + 904;
			if (Prefs.GetBool((string)key))
			{
				return true;
			}
			object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v4+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj4 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
			object key2 = "LAK" + 544;
			DateTime date = Prefs.GetDate((string)key2, (DateTime)0);
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X0_v9+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			SFSConfig currentSFS = Config.CurrentSFS;
			if (currentSFS != null && currentSFS.<LastRequestUpdates>k__BackingField != null)
			{
				DateTime storeSplitRequestUpdate = currentSFS.<LastRequestUpdates>k__BackingField.StoreSplitRequestUpdate;
				object obj7 = typeof(DataRelation) + 712;
				object obj8 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X0_v17+E4]");
				bool flag3 = (nint)0 == 0;
				object obj9 = !flag3;
				if (obj9 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				return date < storeSplitRequestUpdate;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
		set
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Expected O, but got Unknown
			//IL_00c9: Expected O, but got I
			//IL_00d9: Expected O, but got I
			//IL_00fb: Expected O, but got I4
			//IL_007d: Expected O, but got I
			//IL_008d: Expected O, but got I
			//IL_009d: Expected O, but got I
			//IL_0038: Expected O, but got I
			//IL_0048: Expected O, but got I
			object key = "HH:mm:ss.ffZ" + 904;
			object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
			Prefs.SetBool((string)key, value);
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v3+E4]");
			object obj4;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v3+B8]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v8+28]");
				obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v8+28]");
				if ((nint)0 != 0)
				{
					goto IL_006d;
				}
				return;
			}
			goto IL_00a7;
			IL_00a7:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v6+B8]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v5+28]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v5+28]");
			bool flag = (nint)0 == 0;
			object obj7 = !flag;
			if (obj7 == null)
			{
				return;
			}
			goto IL_006d;
			IL_006d:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v7+18]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v7+40]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v7+28]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v65 @ X2_v2 (should have been resolved before IL gen)");
			goto IL_00a7;
		}
	}

	public static event Action OnLastStoreDateUpdated
	{
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0152: Expected O, but got I4
			//IL_016f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0174: Expected O, but got Unknown
			//IL_0184: Expected O, but got I
			//IL_0194: Expected O, but got I
			//IL_00fb: Expected O, but got I4
			//IL_0046: Expected O, but got I
			object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			object obj4 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+B8]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v4+28]");
			Delegate obj6 = (Delegate)0;
			Delegate obj12 = default(Delegate);
			while (true)
			{
				Delegate obj7 = Delegate.Combine(obj6, value);
				bool flag2 = (object)obj7 == null;
				Delegate obj8 = value;
				if (!flag2)
				{
					obj8 = (Delegate)obj4;
					if (obj7 != obj4)
					{
						break;
					}
				}
				object obj9 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v10+E4]");
				bool flag3 = (nint)0 == 0;
				object obj10 = !flag3;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj9 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v10+B8]");
				object obj11 = (nint)0 + (nint)40;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				bool flag4 = (object)obj12 == obj6;
				obj6 = obj12;
				if (!flag4)
				{
					continue;
				}
				return;
			}
			throw new InvalidCastException();
		}
		remove
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0152: Expected O, but got I4
			//IL_016f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0174: Expected O, but got Unknown
			//IL_0184: Expected O, but got I
			//IL_0194: Expected O, but got I
			//IL_00fb: Expected O, but got I4
			//IL_0046: Expected O, but got I
			object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			object obj4 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+B8]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v4+28]");
			Delegate obj6 = (Delegate)0;
			Delegate obj12 = default(Delegate);
			while (true)
			{
				Delegate obj7 = Delegate.Remove(obj6, value);
				bool flag2 = (object)obj7 == null;
				Delegate obj8 = value;
				if (!flag2)
				{
					obj8 = (Delegate)obj4;
					if (obj7 != obj4)
					{
						break;
					}
				}
				object obj9 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v10+E4]");
				bool flag3 = (nint)0 == 0;
				object obj10 = !flag3;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj9 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v10+B8]");
				object obj11 = (nint)0 + (nint)40;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				bool flag4 = (object)obj12 == obj6;
				obj6 = obj12;
				if (!flag4)
				{
					continue;
				}
				return;
			}
			throw new InvalidCastException();
		}
	}

	private void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_024d: Expected I, but got O
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Expected O, but got Unknown
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Expected O, but got Unknown
		//IL_0292: Expected O, but got I
		//IL_00d8: Expected I, but got O
		//IL_02b7: Expected O, but got I
		//IL_00b6: Expected O, but got I4
		//IL_0113: Expected O, but got I4
		//IL_01b4: Expected I, but got O
		//IL_017e: Expected O, but got I4
		//IL_01e3: Expected O, but got I4
		//IL_0226: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)3960;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(null, (IntPtr)obj2);
		object obj3 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2144;
		object obj4 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2856;
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X8_v5+B8]");
		object obj6 = 0;
		Delegate obj7 = (Delegate)obj6;
		Delegate obj13 = default(Delegate);
		Action action2 = default(Action);
		Delegate obj19 = default(Delegate);
		Action action3 = default(Action);
		Action action4 = default(Action);
		while (true)
		{
			Delegate obj8 = Delegate.Remove(obj7, action);
			if ((object)obj8 != null)
			{
				Delegate obj9 = (Delegate)obj;
				if (obj8 != obj)
				{
					object obj10 = 0;
					Delegate obj11 = null;
					break;
				}
			}
			object obj12 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
			bool flag = (object)obj13 == obj7;
			obj7 = obj13;
			if (!flag)
			{
				continue;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			action2..ctor(null, (IntPtr)obj2);
			object obj14 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X8_v14+B8]");
			object obj15 = 0;
			Delegate obj16 = (Delegate)obj15;
			while (true)
			{
				Delegate obj17 = Delegate.Combine(obj16, action2);
				object obj10;
				Delegate obj9;
				Delegate obj11;
				if ((object)obj17 != null)
				{
					obj9 = (Delegate)obj;
					bool flag2 = obj17 == obj;
					obj10 = 0;
					obj11 = null;
					if (!flag2)
					{
						break;
					}
				}
				object obj18 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				bool flag3 = (object)obj19 == obj16;
				obj16 = obj19;
				obj10 = 0;
				obj9 = obj17;
				obj11 = obj19;
				if (!flag3)
				{
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				action3..ctor(null, (IntPtr)obj2);
				object obj20 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X0_v11+E4]");
				bool flag4 = (nint)0 == 0;
				object obj21 = !flag4;
				if (obj21 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				ContentPushService.OnStoreApplied -= action3;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				action4..ctor(null, (IntPtr)obj2);
				ContentPushService.OnStoreApplied += action4;
				return;
			}
			break;
		}
		throw new InvalidCastException();
	}

	private void Start()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_01e3: Expected I, but got O
		//IL_00f4: Expected O, but got I
		//IL_010e: Expected O, but got I4
		//IL_004f: Expected O, but got I
		//IL_0184: Expected O, but got I
		//IL_0194: Expected O, but got I
		//IL_01b6: Expected O, but got I4
		//IL_014c: Expected O, but got I4
		//IL_00b1: Expected O, but got I
		//IL_00c1: Expected O, but got I
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)3952;
		object obj3 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v4+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6A8D]");
			object obj5 = (nint)0 & (nint)1;
			if (obj5 != null)
			{
				goto IL_006c;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6A8D]");
			object obj6 = (nint)0 & (nint)1;
			bool flag = obj6 == null;
			object obj7 = !flag;
			if (obj7 != null)
			{
				goto IL_006c;
			}
		}
		_ = 1;
		object obj8 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v18+E4]");
		bool flag2 = (nint)0 == 0;
		object obj9 = !flag2;
		object obj10 = obj8;
		if (obj9 != null)
		{
			goto IL_00a1;
		}
		goto IL_0162;
		IL_00a1:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v18+B8]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X8_v13+18]");
		OneShotEvent oneShotEvent = (OneShotEvent)0;
		goto IL_00c6;
		IL_00c6:
		oneShotEvent.CallWhenReady(action);
		return;
		IL_0162:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj12 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X0_v9+B8]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X8_v6+18]");
		oneShotEvent = (OneShotEvent)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X8_v6+18]");
		bool flag3 = (nint)0 == 0;
		object obj14 = !flag3;
		if (obj14 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00c6;
		IL_006c:
		obj8 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v18+E4]");
		bool flag4 = (nint)0 == 0;
		obj10 = obj8;
		if (!flag4)
		{
			goto IL_00a1;
		}
		goto IL_0162;
	}

	private void OnEnable()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected O, but got Unknown
		//IL_01c1: Expected O, but got I4
		//IL_01db: Expected O, but got I
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Expected O, but got Unknown
		//IL_01fb: Expected O, but got I
		//IL_0211: Expected O, but got I
		//IL_024a: Expected O, but got I4
		//IL_0066: Expected I, but got O
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		//IL_00b7: Expected O, but got I
		//IL_00cf: Expected I, but got O
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected O, but got Unknown
		//IL_00ef: Expected O, but got I
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected O, but got Unknown
		//IL_0118: Expected O, but got I
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
		object obj2 = typeof(Queue<string>) + 752;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj3 = obj;
		}
		object obj5 = (nint)0 + (nint)2024;
		object obj6 = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 1848;
		object obj7 = (nint)0 + (nint)3976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v3+B8]");
		object obj8 = (nint)0 + (nint)32;
		obj8 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj9 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v7+E4]");
		bool flag2 = (nint)0 == 0;
		object obj10 = !flag2;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		IAPController.IAPFailure iAPFailure = default(IAPController.IAPFailure);
		iAPFailure..ctor(this, (IntPtr)obj7);
		IAPController iAPController = default(IAPController);
		iAPController.OnIAPPurchaseFailed += iAPFailure;
		storeLoadingIndicator.StartLoading();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj11 = typeof(SqlSingle[]) + 2376;
		object obj12 = (nint)0 + (nint)3968;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj12);
		object action2 = "Unsupported map type" + 2872;
		object type = (nint)0 + (nint)2000;
		object obj13 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X0_v18+20]");
		((OneShotEvent)0).CallWhenReady(action);
		FirebaseTrack.Event((string)action2, (string)type);
		ITrackEvent trackEvent = TrackerLibrary.ShopMainShopViewed();
		object obj14 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X8_v8+E4]");
		if ((nint)0 != 0)
		{
			Tracker.DesignEvent(trackEvent);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Tracker.DesignEvent(trackEvent);
	}

	private void OnDisable()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_024f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0254: Expected O, but got Unknown
		//IL_027e: Expected O, but got I4
		//IL_00b1: Expected O, but got I
		//IL_00c1: Expected O, but got I
		//IL_00f0: Expected O, but got I
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_02be: Expected O, but got I
		//IL_02ce: Expected O, but got I
		//IL_02f8: Expected O, but got I4
		//IL_0308: Expected O, but got I
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Expected O, but got Unknown
		//IL_0199: Expected O, but got I
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Expected O, but got Unknown
		//IL_01b9: Expected O, but got I
		//IL_01e3: Expected O, but got I4
		//IL_0168: Expected O, but got I4
		//IL_0227: Expected I, but got O
		//IL_0343: Expected O, but got I
		//IL_034c: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E69D4]");
		object obj3 = (nint)0 & (nint)1;
		object obj4;
		object obj7;
		if (obj3 != null)
		{
			obj4 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v47+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = obj5;
			obj7 = obj4;
			if (!flag)
			{
				goto IL_00a1;
			}
		}
		else
		{
			_ = 1;
			obj4 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v47+E4]");
			bool flag2 = (nint)0 == 0;
			object obj8 = !flag2;
			object obj6 = obj5;
			obj7 = obj4;
			if (obj8 != null)
			{
				goto IL_00a1;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj9 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v5+B8]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v4+20]");
		UnityEngine.Object obj11 = (UnityEngine.Object)0;
		object obj12 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v1+E4]");
		bool flag3 = (nint)0 == 0;
		object obj13 = !flag3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v4+20]");
		UnityEngine.Object obj14 = (UnityEngine.Object)0;
		if (obj13 != null)
		{
			goto IL_00fe;
		}
		goto IL_0316;
		IL_00fe:
		object obj15 = typeof(Queue<string>) + 752;
		bool flag4 = obj11 == this;
		bool flag5 = !flag4;
		UnityEngine.Object obj16 = this;
		if (!flag5)
		{
			object obj17 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X0_v41+E4]");
			bool flag6 = (nint)0 == 0;
			object obj18 = !flag6;
			if (obj18 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj17 = obj2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X0_v41+B8]");
			object obj19 = (nint)0 + (nint)32;
			obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj16 = null;
		}
		object obj20 = (nint)0 + (nint)2024;
		object obj21 = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 1848;
		object obj22 = (nint)0 + (nint)3976;
		object obj23 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X0_v30+E4]");
		bool flag7 = (nint)0 == 0;
		object obj24 = !flag7;
		if (obj24 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		IAPController.IAPFailure iAPFailure = default(IAPController.IAPFailure);
		iAPFailure..ctor(this, (IntPtr)obj22);
		IAPController iAPController = default(IAPController);
		iAPController.OnIAPPurchaseFailed -= iAPFailure;
		return;
		IL_0316:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj11 = obj14;
		goto IL_00fe;
		IL_00a1:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v47+B8]");
		object obj25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v13+20]");
		obj11 = (UnityEngine.Object)0;
		obj12 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v1+E4]");
		bool flag8 = (nint)0 == 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v13+20]");
		obj14 = (UnityEngine.Object)0;
		if (!flag8)
		{
			goto IL_00fe;
		}
		goto IL_0316;
	}

	private void AssignStoreValuesToScene(ItemCategory category)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_024c: Expected O, but got I4
		//IL_0093: Expected O, but got I
		//IL_02b4: Expected O, but got I
		//IL_02de: Expected O, but got I4
		//IL_027a: Expected O, but got I
		//IL_0294: Expected O, but got I4
		//IL_0109: Expected O, but got I
		//IL_00bc: Expected O, but got I
		//IL_032f: Expected O, but got I4
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected O, but got Unknown
		//IL_0352: Expected O, but got I
		//IL_0362: Expected O, but got I
		//IL_0384: Expected O, but got I4
		//IL_0550: Expected O, but got I
		//IL_01ce: Expected O, but got I
		//IL_01de: Expected O, but got I
		//IL_0200: Expected O, but got I4
		//IL_0486: Expected O, but got I
		//IL_0496: Expected O, but got I
		//IL_04b8: Expected O, but got I4
		//IL_03bc: Expected O, but got I4
		//IL_041f: Expected O, but got I
		//IL_042f: Expected O, but got I
		//IL_0451: Expected O, but got I4
		//IL_059d: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a2: Expected O, but got Unknown
		//IL_05b8: Expected O, but got I
		//IL_05c9: Expected I, but got O
		//IL_05e7: Expected O, but got I
		//IL_04e8: Expected O, but got I4
		//IL_03fa: Expected O, but got I4
		//IL_03ec: Expected O, but got I
		//IL_060d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0612: Expected O, but got Unknown
		//IL_0628: Expected O, but got I
		//IL_0639: Expected I, but got O
		//IL_0657: Expected O, but got I
		//IL_0518: Expected O, but got I
		object obj = 152985600;
		object obj2 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E69D5]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v9+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v9+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45A8]");
		object obj6 = (nint)0 & (nint)1;
		bool flag2 = obj6 == null;
		object obj7 = !flag2;
		if (obj7 != null)
		{
			goto IL_00b0;
		}
		goto IL_02a2;
		IL_00f9:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v39+B8]");
		object dict = 0;
		object obj9;
		object obj8 = obj9;
		object obj10 = DictionaryExtensions.Get((IDictionary<System.Int32Enum, object>)dict, (System.Int32Enum)category);
		if (obj10 == null)
		{
			return;
		}
		object obj11;
		object obj13;
		Func<object, object> keySelector;
		IEnumerable<object> source;
		bool flag5;
		object obj16;
		object obj18;
		object obj19;
		object obj20;
		Func<object, int> func = default(Func<object, int>);
		object obj21;
		object obj22;
		Func<object, int> keySelector2;
		object obj23;
		IEnumerable<IGrouping<object, object>> source2;
		object obj24;
		bool flag8;
		object obj27;
		object obj29;
		object obj30;
		Func<object, object> func2 = default(Func<object, object>);
		object obj31;
		object obj32;
		IOrderedEnumerable<object> data;
		switch (category)
		{
		case ItemCategory.Cards:
		{
			obj11 = typeof(SkeletonBinary.SkeletonInput) + 1304;
			object obj12 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v32+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v32+B8]");
				obj13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X9_v7+8]");
				keySelector = (Func<object, object>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X9_v7+8]");
				bool flag3 = (nint)0 == 0;
				object obj14 = !flag3;
				source = (IEnumerable<object>)obj10;
				if (obj14 == null)
				{
					goto IL_039a;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj12 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v32+B8]");
				obj13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X9_v7+8]");
				keySelector = (Func<object, object>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X9_v7+8]");
				bool flag4 = (nint)0 == 0;
				object obj15 = !flag4;
				source = (IEnumerable<object>)obj10;
				if (obj15 == null)
				{
					goto IL_039a;
				}
			}
			goto IL_0544;
		}
		case ItemCategory.Rooms:
			{
				storeRoomThemesGroup.Populate((List<StoreItem>)obj10, (int?)(object)0);
				break;
			}
			IL_04c6:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v355 @ X0_v52+E4]");
			flag5 = (nint)0 == 0;
			obj16 = !flag5;
			if (obj16 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj17 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X8_v28+B8]");
				obj18 = 0;
			}
			obj19 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 3352;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			obj20 = (nint)0 + (nint)1296;
			func..ctor(obj18, (IntPtr)obj20);
			obj21 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ X8_v27+B8]");
			obj22 = (nint)0 + (nint)16;
			obj22 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			keySelector2 = func;
			goto IL_051d;
			IL_0544:
			obj23 = (nint)0 + (nint)1568;
			source2 = Enumerable.GroupBy(source, keySelector);
			obj24 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v355 @ X0_v52+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v355 @ X0_v52+B8]");
				obj18 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X8_v22+10]");
				keySelector2 = (Func<object, int>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X8_v22+10]");
				bool flag6 = (nint)0 == 0;
				object obj25 = !flag6;
				if (obj25 == null)
				{
					goto IL_04c6;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj24 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v355 @ X0_v52+B8]");
				obj18 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X8_v22+10]");
				keySelector2 = (Func<object, int>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X8_v22+10]");
				bool flag7 = (nint)0 == 0;
				object obj26 = !flag7;
				if (obj26 == null)
				{
					goto IL_04c6;
				}
			}
			goto IL_051d;
			IL_039a:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X8_v32+E4]");
			flag8 = (nint)0 == 0;
			obj27 = !flag8;
			if (obj27 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj28 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X8_v39+B8]");
				obj13 = 0;
			}
			obj29 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3472;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			obj30 = (nint)0 + (nint)1288;
			func2..ctor(obj13, (IntPtr)obj30);
			obj31 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X8_v38+B8]");
			obj32 = (nint)0 + (nint)8;
			obj32 = func2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj8 = 0;
			source = (IEnumerable<object>)obj10;
			keySelector = func2;
			goto IL_0544;
			IL_051d:
			data = Enumerable.OrderBy(source2, keySelector2);
			storeCardGroup.SetData((IEnumerable<IGrouping<string, StoreItem>>)data);
			break;
		}
		return;
		IL_02fc:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj33 = obj2;
		object obj34;
		obj9 = obj34;
		goto IL_00f9;
		IL_00b0:
		obj9 = (nint)0 + (nint)3272;
		obj33 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v39+E4]");
		bool flag9 = (nint)0 == 0;
		object obj35 = obj33;
		obj34 = obj9;
		if (!flag9)
		{
			goto IL_00f9;
		}
		goto IL_02fc;
		IL_007d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45A8]");
		object obj36 = (nint)0 & (nint)1;
		if (obj36 != null)
		{
			goto IL_00b0;
		}
		goto IL_02a2;
		IL_02a2:
		_ = 1;
		obj9 = (nint)0 + (nint)3272;
		obj33 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v39+E4]");
		bool flag10 = (nint)0 == 0;
		object obj37 = !flag10;
		obj35 = obj33;
		obj34 = obj9;
		if (obj37 != null)
		{
			goto IL_00f9;
		}
		goto IL_02fc;
	}

	private void PopulateStoreHomePage(StoreHomePageViewModel storeHomePageViewModel)
	{
		storeLoadingIndicator.FinishLoading();
		storeHomePageGroup.Populate(storeHomePageViewModel);
	}

	public static void CallWhenLoaded(Action action)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00df: Expected O, but got I4
		//IL_008c: Expected O, but got I
		//IL_009c: Expected O, but got I
		//IL_0117: Expected O, but got I
		//IL_0127: Expected O, but got I
		//IL_0149: Expected O, but got I4
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6A8D]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v12+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = obj3;
			if (!flag)
			{
				goto IL_007c;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v12+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			object obj4 = obj3;
			if (obj5 != null)
			{
				goto IL_007c;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v5+B8]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v4+18]");
		OneShotEvent oneShotEvent = (OneShotEvent)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v4+18]");
		bool flag3 = (nint)0 == 0;
		object obj8 = !flag3;
		if (obj8 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00a1;
		IL_007c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v12+B8]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v9+18]");
		oneShotEvent = (OneShotEvent)0;
		goto IL_00a1;
		IL_00a1:
		oneShotEvent.CallWhenReady(action);
	}

	private void OnIAPPurchaseFailed(ProductListingModel product, string error)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0134: Expected O, but got I4
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected O, but got Unknown
		//IL_00a7: Expected O, but got I
		//IL_01d6: Expected O, but got I4
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected O, but got Unknown
		//IL_0176: Expected O, but got I
		//IL_0190: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6A8E]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v8+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v8+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj6 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6A8F]");
		object obj7 = (nint)0 & (nint)1;
		bool flag2 = obj7 == null;
		object obj8 = !flag2;
		object obj9 = obj6;
		if (obj8 != null)
		{
			goto IL_00cc;
		}
		goto IL_01a6;
		IL_00f9:
		PopupWindow.ShowError(error);
		return;
		IL_01e4:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		goto IL_00f9;
		IL_00cc:
		object obj10 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X0_v1+E4]");
		if ((nint)0 != 0)
		{
			goto IL_00f9;
		}
		goto IL_01e4;
		IL_007d:
		obj6 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6A8F]");
		object obj11 = (nint)0 & (nint)1;
		bool flag3 = obj11 == null;
		obj9 = obj6;
		if (!flag3)
		{
			goto IL_00cc;
		}
		goto IL_01a6;
		IL_01a6:
		_ = 1;
		obj10 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X0_v1+E4]");
		bool flag4 = (nint)0 == 0;
		object obj12 = !flag4;
		if (obj12 != null)
		{
			goto IL_00f9;
		}
		goto IL_01e4;
	}

	public static void ShowError(string errorMsg)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_005d: Expected O, but got I4
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PopupWindow.ShowError(errorMsg);
	}

	public void ShowBuyCardPopup(List<StoreItem> cardItems, int? tempId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0059: Expected O, but got I
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		//IL_009e: Expected I, but got O
		//IL_00c8: Expected O, but got I4
		object obj = typeof(SkeletonBinary.SkeletonInput) + 1320;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1328;
		object obj4 = (nint)0 + (nint)1320;
		object obj5 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		object obj6 = (nint)0 + (nint)1840;
		object obj7 = obj2 + 16;
		obj7 = cardItems;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj4);
		object obj8 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X0_v10+E4]");
		bool flag = (nint)0 == 0;
		object obj9 = !flag;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F80CF4");
	}

	public void ShowBuyUniqueCardPopup(UniqueStoreItem uniqueStoreItem, StoreItem cardItem, int? templateId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0059: Expected O, but got I
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected O, but got Unknown
		//IL_00be: Expected I, but got O
		//IL_00ed: Expected O, but got I4
		object obj = typeof(SkeletonBinary.SkeletonInput) + 1328;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1352;
		object obj4 = (nint)0 + (nint)1328;
		object obj5 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		object obj6 = (nint)0 + (nint)1864;
		object obj7 = obj2 + 16;
		obj7 = uniqueStoreItem;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj8 = obj2 + 24;
		obj8 = cardItem;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj4);
		object obj9 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v13+E4]");
		bool flag = (nint)0 == 0;
		object obj10 = !flag;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F80CF4");
	}

	public void ShowBundlePopup(Bundle item)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0059: Expected O, but got I
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		//IL_0099: Expected I, but got O
		//IL_00c3: Expected O, but got I4
		object obj = typeof(SkeletonBinary.SkeletonInput) + 1336;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1312;
		object obj4 = (nint)0 + (nint)1336;
		object obj5 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		object obj6 = (nint)0 + (nint)1832;
		object obj7 = obj2 + 16;
		obj7 = item;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj4);
		object obj8 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X0_v10+E4]");
		bool flag = (nint)0 == 0;
		object obj9 = !flag;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F80CF4");
	}

	public void ShowBuyForFriendSubscription()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00af: Expected O, but got I4
		object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 3760;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E69D9]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v1+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v1+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		BuyForFriendPopup.Show(1);
		return;
		IL_0074:
		BuyForFriendPopup.Show(1);
	}

	public void ShowBuyForFriendCoins()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00af: Expected O, but got I4
		object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 3760;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E69DA]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v1+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v1+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		BuyForFriendPopup.Show(2);
		return;
		IL_0074:
		BuyForFriendPopup.Show(2);
	}

	private static void ClearStoreCounter()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0229: Unknown result type (might be due to invalid IL or missing references)
		//IL_022e: Expected O, but got Unknown
		//IL_023e: Expected O, but got I
		//IL_0260: Expected O, but got I4
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_02f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f7: Expected O, but got Unknown
		//IL_030d: Expected O, but got I
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected O, but got Unknown
		//IL_010c: Expected O, but got I
		//IL_0126: Expected O, but got I4
		//IL_02b8: Expected O, but got I4
		//IL_03e1: Expected O, but got I4
		//IL_03ff: Expected O, but got I
		//IL_040f: Expected O, but got I
		//IL_0479: Unknown result type (might be due to invalid IL or missing references)
		//IL_047e: Expected O, but got Unknown
		//IL_0369: Expected O, but got I
		//IL_0379: Expected O, but got I
		//IL_039b: Expected O, but got I4
		//IL_01ea: Expected O, but got I
		//IL_01fa: Expected O, but got I
		//IL_020a: Expected O, but got I
		//IL_01a5: Expected O, but got I
		//IL_01b5: Expected O, but got I
		object obj = 152985600;
		object obj2 = typeof(DataRelation) + 712;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6A90]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 == null)
		{
			goto IL_0214;
		}
		object obj4 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v27+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = obj4;
		if (!flag)
		{
			goto IL_0099;
		}
		goto IL_0276;
		IL_0214:
		_ = 1;
		obj4 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6000]");
		obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v27+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		obj6 = obj4;
		if (obj7 != null)
		{
			goto IL_0099;
		}
		goto IL_0276;
		IL_0099:
		DateTime now = DateTime.Now;
		object obj8 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v25+E4]");
		bool flag3 = (nint)0 == 0;
		DateTime dateTime = now;
		DateTime dateTime2 = now;
		obj6 = obj4;
		if (!flag3)
		{
			goto IL_00e7;
		}
		goto IL_02de;
		IL_00e7:
		object obj9 = "LAK" + 544;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6A88]");
		object obj10 = (nint)0 & (nint)1;
		bool flag4 = obj10 == null;
		object obj11 = !flag4;
		object key = obj9;
		dateTime2 = dateTime;
		obj6 = obj4;
		if (obj11 == null)
		{
			goto IL_014c;
		}
		goto IL_03aa;
		IL_014c:
		_ = 1;
		key = obj9;
		dateTime2 = dateTime;
		obj6 = obj4;
		goto IL_03aa;
		IL_03aa:
		Prefs.SetDate((string)key, dateTime2);
		object obj12 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X0_v4+E4]");
		bool flag5 = (nint)0 == 0;
		object obj13 = !flag5;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj12 = obj6;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X0_v4+B8]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X8_v4+28]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X8_v4+28]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v131 @ X8_v5+18] (should have been resolved before IL gen)");
		}
		object key2 = "HH:mm:ss.ffZ" + 904;
		Prefs.SetBool((string)key2, value: false);
		object obj16 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X0_v8+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X0_v8+B8]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X8_v13+28]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X8_v13+28]");
			if ((nint)0 == 0)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj19 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X0_v11+B8]");
			object obj20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X8_v10+28]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X8_v10+28]");
			bool flag6 = (nint)0 == 0;
			object obj21 = !flag6;
			if (obj21 == null)
			{
				return;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X8_v12+18]");
		object obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X8_v12+40]");
		object obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X8_v12+28]");
		object obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v173 @ X2_v3 (should have been resolved before IL gen)");
		goto IL_0214;
		IL_02de:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj9 = "LAK" + 544;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6A88]");
		object obj25 = (nint)0 & (nint)1;
		bool flag7 = obj25 == null;
		dateTime = dateTime2;
		obj4 = obj6;
		if (flag7)
		{
			goto IL_014c;
		}
		key = obj9;
		goto IL_03aa;
		IL_0276:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		DateTime now2 = DateTime.Now;
		obj8 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v25+E4]");
		bool flag8 = (nint)0 == 0;
		object obj26 = !flag8;
		dateTime = now2;
		obj4 = obj6;
		dateTime2 = now2;
		if (obj26 != null)
		{
			goto IL_00e7;
		}
		goto IL_02de;
	}

	public static void LoadStore()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_0161: Expected O, but got I4
		//IL_008a: Expected O, but got I
		//IL_01e7: Expected O, but got I4
		//IL_018f: Expected O, but got I
		//IL_01a9: Expected O, but got I4
		//IL_00ec: Expected O, but got I
		//IL_00fc: Expected O, but got I
		//IL_011e: Expected O, but got I4
		//IL_024a: Expected O, but got I
		//IL_0264: Expected O, but got I4
		//IL_021f: Expected O, but got I
		//IL_022f: Expected O, but got I
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_0286: Expected O, but got Unknown
		//IL_043c: Expected O, but got I4
		//IL_0308: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Expected O, but got Unknown
		//IL_0323: Expected O, but got I
		//IL_033d: Expected O, but got I4
		//IL_0473: Unknown result type (might be due to invalid IL or missing references)
		//IL_0478: Expected O, but got Unknown
		//IL_048e: Expected O, but got I
		//IL_03c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c7: Expected O, but got Unknown
		//IL_03dd: Expected O, but got I
		//IL_03eb: Expected I, but got O
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6A91]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v37+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v37+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6A86]");
		object obj5 = (nint)0 & (nint)1;
		bool flag2 = obj5 == null;
		object obj6 = !flag2;
		if (obj6 != null)
		{
			goto IL_00a7;
		}
		goto IL_01b7;
		IL_035b:
		_ = 1;
		object obj8;
		object obj7 = obj8;
		CoroutineDummy coroutineDummy2;
		CoroutineDummy coroutineDummy = coroutineDummy2;
		goto IL_04c7;
		IL_04c7:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj9 = default(object);
		obj9..ctor();
		_ = 0;
		Coroutine coroutine = coroutineDummy.StartCoroutine((IEnumerator)obj9);
		if (!HasNewStoreSinceLastVisit)
		{
			object obj10 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 640;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj11 = (nint)0 + (nint)1872;
			Action<object> action = default(Action<object>);
			action..ctor((object)null, (IntPtr)obj11);
			KammelnaRequests.GetStoreHomePage(action);
		}
		return;
		IL_02f9:
		obj8 = typeof(SkeletonBinary.SkeletonInput) + 1368;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6A92]");
		object obj12 = (nint)0 & (nint)1;
		bool flag3 = obj12 == null;
		object obj13 = !flag3;
		obj7 = obj8;
		coroutineDummy = coroutineDummy2;
		if (obj13 == null)
		{
			goto IL_035b;
		}
		goto IL_04c7;
		IL_0074:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6A86]");
		object obj14 = (nint)0 & (nint)1;
		if (obj14 != null)
		{
			goto IL_00a7;
		}
		goto IL_01b7;
		IL_01b7:
		_ = 1;
		object obj15 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v52+E4]");
		bool flag4 = (nint)0 == 0;
		object obj16 = !flag4;
		object obj17 = obj15;
		if (obj16 != null)
		{
			goto IL_00dc;
		}
		goto IL_01fd;
		IL_00a7:
		obj15 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v52+E4]");
		bool flag5 = (nint)0 == 0;
		obj17 = obj15;
		if (!flag5)
		{
			goto IL_00dc;
		}
		goto IL_01fd;
		IL_01fd:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj18 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X0_v31+B8]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X8_v23+18]");
		object obj20 = 0;
		goto IL_0234;
		IL_00dc:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v52+B8]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v33+18]");
		obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v33+18]");
		bool flag6 = (nint)0 == 0;
		object obj22 = !flag6;
		if (obj22 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0234;
		IL_0234:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v3+18]");
		object obj23 = (nint)0 & (nint)1;
		bool flag7 = obj23 == null;
		object obj24 = !flag7;
		if (obj24 != null)
		{
			return;
		}
		object obj25 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		object obj26 = obj25;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X0_v5+E4]");
		if ((nint)0 != 0)
		{
			CoroutineDummy permanentInstance = CoroutineDummy.PermanentInstance;
			object obj27 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X0_v15+E4]");
			bool flag8 = (nint)0 == 0;
			coroutineDummy2 = permanentInstance;
			coroutineDummy = permanentInstance;
			if (!flag8)
			{
				goto IL_02f9;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			CoroutineDummy permanentInstance2 = CoroutineDummy.PermanentInstance;
			object obj27 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X0_v15+E4]");
			bool flag9 = (nint)0 == 0;
			object obj28 = !flag9;
			coroutineDummy2 = permanentInstance2;
			coroutineDummy = permanentInstance2;
			if (obj28 != null)
			{
				goto IL_02f9;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj8 = typeof(SkeletonBinary.SkeletonInput) + 1368;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6A92]");
		object obj29 = (nint)0 & (nint)1;
		bool flag10 = obj29 == null;
		coroutineDummy2 = coroutineDummy;
		if (flag10)
		{
			goto IL_035b;
		}
		obj7 = obj8;
		goto IL_04c7;
	}

	private static IEnumerator LoadStoreRoutine()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(SkeletonBinary.SkeletonInput) + 1368;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		_ = 0;
		return (IEnumerator)obj2;
	}

	public static void ApplyStoreInfoUpdate()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_0161: Expected O, but got I4
		//IL_008a: Expected O, but got I
		//IL_01e7: Expected O, but got I4
		//IL_018f: Expected O, but got I
		//IL_01a9: Expected O, but got I4
		//IL_00ec: Expected O, but got I
		//IL_00fc: Expected O, but got I
		//IL_011e: Expected O, but got I4
		//IL_021f: Expected O, but got I
		//IL_022f: Expected O, but got I
		//IL_02a0: Expected O, but got I4
		//IL_030e: Expected O, but got I4
		//IL_0478: Expected O, but got I
		//IL_0487: Unknown result type (might be due to invalid IL or missing references)
		//IL_048c: Expected O, but got Unknown
		//IL_0425: Expected O, but got I
		//IL_0444: Expected O, but got I4
		//IL_044d: Expected O, but got I4
		//IL_0345: Expected O, but got I
		//IL_035d: Expected O, but got I4
		//IL_039a: Expected O, but got I4
		//IL_04c9: Expected O, but got I
		//IL_03d5: Expected O, but got I
		//IL_03ed: Expected O, but got I
		//IL_0408: Expected O, but got I
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6A93]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v34+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v34+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6A86]");
		object obj5 = (nint)0 & (nint)1;
		bool flag2 = obj5 == null;
		object obj6 = !flag2;
		if (obj6 != null)
		{
			goto IL_00a7;
		}
		goto IL_01b7;
		IL_0234:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X8_v3+18]");
		if ((nint)0 != 1)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v3+E4]");
		if ((nint)0 != 0)
		{
			bool flag3 = AssignStoreModels();
			bool flag4 = !flag3;
			object obj7 = !flag4;
			if (obj7 == null)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			if (!AssignStoreModels())
			{
				return;
			}
		}
		object obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X0_v7+E4]");
		bool flag5 = (nint)0 == 0;
		object obj9 = !flag5;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj8 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X0_v7+B8]");
		object obj10 = 0;
		object obj11 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj12 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X0_v8+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X8_v8+20]");
			bool flag6 = (UnityEngine.Object)0 != null;
			bool flag7 = !flag6;
			object obj13 = 0;
			UnityEngine.Object obj14 = null;
			if (flag7)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X8_v8+20]");
			bool flag8 = (UnityEngine.Object)0 != null;
			bool flag9 = !flag8;
			object obj15 = !flag9;
			object obj13 = 0;
			UnityEngine.Object obj14 = null;
			if (obj15 == null)
			{
				return;
			}
		}
		object obj16 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X0_v14+E4]");
		bool flag10 = (nint)0 == 0;
		object obj17 = !flag10;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj16 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X0_v14+B8]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X8_v13+20]");
		((Store)0).AssignStoreValuesToScene(ItemCategory.Cards);
		object obj19 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X8_v14+B8]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X8_v15+20]");
		((Store)0).AssignStoreValuesToScene(ItemCategory.Rooms);
		return;
		IL_00dc:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v3+B8]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X8_v27+18]");
		object obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X8_v27+18]");
		bool flag11 = (nint)0 == 0;
		object obj23 = !flag11;
		if (obj23 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0234;
		IL_01fd:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj24 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v3+B8]");
		object obj25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v17+18]");
		obj22 = 0;
		goto IL_0234;
		IL_0074:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6A86]");
		object obj26 = (nint)0 & (nint)1;
		if (obj26 != null)
		{
			goto IL_00a7;
		}
		goto IL_01b7;
		IL_01b7:
		_ = 1;
		obj24 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v3+E4]");
		bool flag12 = (nint)0 == 0;
		object obj27 = !flag12;
		object obj28 = obj24;
		if (obj27 != null)
		{
			goto IL_00dc;
		}
		goto IL_01fd;
		IL_00a7:
		obj24 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v3+E4]");
		bool flag13 = (nint)0 == 0;
		obj28 = obj24;
		if (!flag13)
		{
			goto IL_00dc;
		}
		goto IL_01fd;
	}

	private static bool AssignStoreModels()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00fb: Expected O, but got I4
		//IL_00a8: Expected O, but got I4
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Expected O, but got Unknown
		//IL_021e: Expected O, but got I
		//IL_022e: Expected O, but got I
		//IL_023e: Expected O, but got I
		//IL_0260: Expected O, but got I4
		//IL_02d5: Expected I, but got O
		//IL_01a3: Expected O, but got I
		//IL_01b3: Expected O, but got I
		//IL_01c3: Expected O, but got I
		//IL_01e5: Expected O, but got I4
		//IL_046d: Expected O, but got I
		//IL_047d: Expected O, but got I
		//IL_049f: Expected O, but got I4
		//IL_0298: Expected O, but got I4
		//IL_0328: Expected O, but got I
		//IL_0338: Expected O, but got I
		//IL_08ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_08bf: Expected O, but got Unknown
		//IL_08d5: Expected O, but got I
		//IL_08e6: Expected I, but got O
		//IL_0904: Expected O, but got I
		//IL_091f: Expected O, but got I4
		//IL_05a4: Expected O, but got I
		//IL_05b4: Expected O, but got I
		//IL_05c4: Expected O, but got I
		//IL_05e6: Expected O, but got I4
		//IL_04d7: Expected O, but got I4
		//IL_02c8: Expected O, but got I
		//IL_03c6: Expected O, but got I
		//IL_03d6: Expected O, but got I
		//IL_03e6: Expected O, but got I
		//IL_0408: Expected O, but got I4
		//IL_0943: Unknown result type (might be due to invalid IL or missing references)
		//IL_0948: Expected O, but got Unknown
		//IL_095e: Expected O, but got I
		//IL_0966: Expected I, but got O
		//IL_0977: Expected I, but got O
		//IL_0995: Expected O, but got I
		//IL_0802: Expected O, but got I
		//IL_081c: Expected O, but got I4
		//IL_062e: Expected O, but got I4
		//IL_0536: Expected O, but got I4
		//IL_053f: Expected O, but got I4
		//IL_0558: Expected O, but got I4
		//IL_0568: Expected I, but got O
		//IL_0507: Expected O, but got I
		//IL_06e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ec: Expected O, but got Unknown
		//IL_06bb: Expected O, but got I
		//IL_09bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c0: Expected O, but got Unknown
		//IL_09d6: Expected O, but got I
		//IL_09e7: Expected I, but got O
		//IL_0a05: Expected O, but got I
		//IL_083f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0844: Expected O, but got Unknown
		//IL_086e: Expected O, but got I4
		//IL_065e: Expected O, but got I
		//IL_0765: Expected O, but got I4
		//IL_0a5e: Expected O, but got I4
		//IL_0aba: Expected O, but got I
		//IL_0a96: Expected O, but got I4
		//IL_0aec: Expected O, but got I
		object obj = 152985600;
		object obj2 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E69DB]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v124+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = obj4;
			if (!flag)
			{
				goto IL_0085;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v124+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			object obj5 = obj4;
			if (obj6 != null)
			{
				goto IL_0085;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		StoreInfoViewModel storeInfoViewModel = AssembleStoreInfo();
		bool flag3 = storeInfoViewModel == null;
		StoreInfoViewModel storeInfoViewModel2 = storeInfoViewModel;
		StoreInfoViewModel storeInfoViewModel3 = storeInfoViewModel;
		if (!flag3)
		{
			goto IL_0156;
		}
		goto IL_07c3;
		IL_07c3:
		bool flag4 = storeInfoViewModel3 == null;
		return !flag4;
		IL_088c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj7 = obj2;
		object obj9;
		object obj8 = obj9;
		goto IL_0729;
		IL_06d8:
		obj8 = typeof(System.Buffers.Text.ParserHelpers) + 2152;
		obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v373 @ X0_v22+E4]");
		bool flag5 = (nint)0 == 0;
		obj9 = obj8;
		object obj10 = obj7;
		if (!flag5)
		{
			goto IL_0729;
		}
		goto IL_088c;
		IL_0085:
		StoreInfoViewModel storeInfoViewModel4 = AssembleStoreInfo();
		bool flag6 = storeInfoViewModel4 == null;
		object obj11 = !flag6;
		storeInfoViewModel2 = storeInfoViewModel4;
		if (obj11 != null)
		{
			goto IL_0156;
		}
		storeInfoViewModel3 = storeInfoViewModel4;
		goto IL_07c3;
		IL_0156:
		object obj12 = typeof(SkeletonBinary.SkeletonInput) + 1304;
		object obj13 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X0_v77+E4]");
		object obj14;
		object obj15;
		Func<object, System.Int32Enum> func;
		object obj17;
		if ((nint)0 != 0)
		{
			obj14 = (nint)0 + (nint)1560;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X0_v77+B8]");
			obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X8_v55+18]");
			func = (Func<object, System.Int32Enum>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X8_v55+18]");
			bool flag7 = (nint)0 == 0;
			object obj16 = !flag7;
			if (obj16 == null)
			{
				obj17 = obj14;
				goto IL_0276;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj13 = obj12;
			obj17 = (nint)0 + (nint)1560;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X0_v77+B8]");
			obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X8_v55+18]");
			func = (Func<object, System.Int32Enum>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X8_v55+18]");
			bool flag8 = (nint)0 == 0;
			object obj18 = !flag8;
			obj14 = obj17;
			if (obj18 == null)
			{
				goto IL_0276;
			}
		}
		goto IL_02cd;
		IL_0586:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj19 = obj12;
		object obj20 = (nint)0 + (nint)1608;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ X0_v53+B8]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ X8_v28+28]");
		Func<object, object> elementSelector = (Func<object, object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ X8_v28+28]");
		bool flag9 = (nint)0 == 0;
		object obj22 = !flag9;
		Func<object, System.Int32Enum> func3;
		Func<object, System.Int32Enum> func2 = func3;
		object obj23 = obj20;
		Func<object, System.Int32Enum> keySelector = func3;
		if (obj22 == null)
		{
			goto IL_060c;
		}
		goto IL_0663;
		IL_0365:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ X0_v53+E4]");
		bool flag10 = (nint)0 == 0;
		Func<object, System.Int32Enum> func4 = func;
		object obj25 = default(object);
		object obj24 = obj25;
		Func<object, System.Int32Enum> func5 = func;
		nint num2;
		nint num = num2;
		Func<object, System.Int32Enum> func6;
		func3 = func6;
		object obj26 = obj19;
		if (!flag10)
		{
			goto IL_03ba;
		}
		goto IL_0586;
		IL_03ba:
		obj23 = (nint)0 + (nint)1608;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ X0_v53+B8]");
		obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ X8_v28+28]");
		elementSelector = (Func<object, object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ X8_v28+28]");
		bool flag11 = (nint)0 == 0;
		object obj27 = !flag11;
		keySelector = func6;
		if (obj27 == null)
		{
			obj20 = obj23;
			obj24 = obj25;
			func5 = func4;
			num = num2;
			func2 = func6;
			goto IL_060c;
		}
		goto IL_0663;
		IL_0276:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X0_v77+E4]");
		bool flag12 = (nint)0 == 0;
		object obj28 = !flag12;
		if (obj28 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj29 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X8_v61+B8]");
			obj15 = 0;
		}
		object obj30 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3456;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj31 = (nint)0 + (nint)1264;
		Func<object, System.Int32Enum> func7 = default(Func<object, System.Int32Enum>);
		func7..ctor(obj15, (IntPtr)obj31);
		object obj32 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X8_v60+B8]");
		object obj33 = (nint)0 + (nint)24;
		obj33 = func7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj25 = 0;
		func = func7;
		obj14 = obj17;
		goto IL_02cd;
		IL_060c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ X0_v53+E4]");
		bool flag13 = (nint)0 == 0;
		object obj34 = !flag13;
		if (obj34 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj35 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ X8_v34+B8]");
			obj21 = 0;
		}
		object obj36 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 3304;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj37 = (nint)0 + (nint)1280;
		Func<object, object> func8 = default(Func<object, object>);
		func8..ctor(obj21, (IntPtr)obj37);
		object obj38 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ X8_v33+B8]");
		object obj39 = (nint)0 + (nint)40;
		obj39 = func8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		elementSelector = func8;
		obj23 = obj20;
		keySelector = func2;
		goto IL_0663;
		IL_0729:
		Dictionary<System.Int32Enum, object> dictionary;
		object obj40 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj41 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v391 @ X0_v25+E4]");
		bool flag14 = (nint)0 == 0;
		object obj42 = !flag14;
		if (obj42 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		ProductStore.LoadProducts(storeInfoViewModel2.<products>k__BackingField);
		object obj43 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ X0_v30+E4]");
		bool flag15 = (nint)0 == 0;
		object obj44 = !flag15;
		if (obj44 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj43 = obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ X0_v30+B8]");
		object obj45 = (nint)0 + (nint)8;
		obj45 = storeInfoViewModel2.<profileGifts>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj46 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ X0_v36+E4]");
		bool flag16 = (nint)0 == 0;
		object obj47 = !flag16;
		if (obj47 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj46 = obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ X0_v36+B8]");
		object obj48 = (nint)0 + (nint)16;
		obj48 = storeInfoViewModel2.<itemGroups>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		storeInfoViewModel3 = storeInfoViewModel2;
		goto IL_07c3;
		IL_02cd:
		num2 = (nint)obj14;
		IEnumerable<IGrouping<System.Int32Enum, object>> source = Enumerable.GroupBy(storeInfoViewModel2.<items>k__BackingField, func);
		obj19 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ X0_v53+E4]");
		object obj49;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ X0_v53+B8]");
			obj49 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X8_v39+20]");
			func6 = (Func<object, System.Int32Enum>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X8_v39+20]");
			bool flag17 = (nint)0 == 0;
			object obj50 = obj19;
			if (!flag17)
			{
				goto IL_0365;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj19 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ X0_v53+B8]");
			obj49 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X8_v39+20]");
			func6 = (Func<object, System.Int32Enum>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X8_v39+20]");
			bool flag18 = (nint)0 == 0;
			object obj51 = !flag18;
			object obj50 = obj19;
			if (obj51 != null)
			{
				goto IL_0365;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X0_v64+E4]");
		bool flag19 = (nint)0 == 0;
		object obj52 = !flag19;
		if (obj52 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj53 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X8_v46+B8]");
			obj49 = 0;
		}
		object obj54 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 3312;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj55 = (nint)0 + (nint)1272;
		num2 = (nint)obj55;
		Func<object, System.Int32Enum> func9 = default(Func<object, System.Int32Enum>);
		func9..ctor(obj49, (IntPtr)obj55);
		object obj56 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X8_v44+B8]");
		object obj57 = (nint)0 + (nint)32;
		obj57 = func9;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj19 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ X0_v53+E4]");
		bool flag20 = (nint)0 == 0;
		object obj58 = !flag20;
		obj25 = 0;
		func4 = func9;
		func6 = func9;
		obj24 = 0;
		func5 = func9;
		num = (nint)obj55;
		func3 = func9;
		obj26 = obj19;
		if (obj58 != null)
		{
			goto IL_03ba;
		}
		goto IL_0586;
		IL_0663:
		dictionary = Enumerable.ToDictionary(source, keySelector, elementSelector);
		object obj59 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X0_v12+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45A9]");
			object obj60 = (nint)0 & (nint)1;
			if (obj60 != null)
			{
				goto IL_06d8;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45A9]");
			object obj61 = (nint)0 & (nint)1;
			bool flag21 = obj61 == null;
			object obj62 = !flag21;
			if (obj62 != null)
			{
				goto IL_06d8;
			}
		}
		_ = 1;
		obj8 = typeof(System.Buffers.Text.ParserHelpers) + 2152;
		obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v373 @ X0_v22+E4]");
		bool flag22 = (nint)0 == 0;
		object obj63 = !flag22;
		obj9 = obj8;
		obj10 = obj7;
		if (obj63 != null)
		{
			goto IL_0729;
		}
		goto IL_088c;
	}

	private static StoreInfoViewModel AssembleStoreInfo()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00e2: Expected O, but got I4
		//IL_0097: Expected O, but got I4
		//IL_01e4: Expected O, but got I
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_028d: Expected O, but got Unknown
		//IL_02cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d0: Expected O, but got Unknown
		//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f0: Expected O, but got Unknown
		//IL_0310: Unknown result type (might be due to invalid IL or missing references)
		//IL_0315: Expected O, but got Unknown
		//IL_0330: Unknown result type (might be due to invalid IL or missing references)
		//IL_0335: Expected O, but got Unknown
		object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 4040;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E69DC]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v30+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v30+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		CachedModel<List<StoreItem>> storeItems = CachedModels.StoreItems;
		bool flag2 = storeItems == null;
		CachedModel<object> cachedModel = (CachedModel<object>)(object)storeItems;
		if (!flag2)
		{
			goto IL_012d;
		}
		goto IL_0359;
		IL_0359:
		return (StoreInfoViewModel)(object)new NullReferenceException();
		IL_012d:
		object model = cachedModel.Model;
		CachedModel<List<ProductViewModel>> storeProducts = CachedModels.StoreProducts;
		if (storeProducts != null)
		{
			object model2 = ((CachedModel<object>)(object)storeProducts).Model;
			CachedModel<List<ProfileGiftModel>> storeProfileGifts = CachedModels.StoreProfileGifts;
			if (storeProfileGifts != null)
			{
				object model3 = ((CachedModel<object>)(object)storeProfileGifts).Model;
				CachedModel<List<ItemGroup>> storeItemGroups = CachedModels.StoreItemGroups;
				if (storeItemGroups != null)
				{
					object obj5 = (nint)0 + (nint)464;
					object model4 = ((CachedModel<object>)(object)storeItemGroups).Model;
					bool flag3 = model == null;
					StoreInfoViewModel result = null;
					if (!flag3)
					{
						bool flag4 = model2 == null;
						result = null;
						if (!flag4)
						{
							bool flag5 = model3 == null;
							result = null;
							if (!flag5)
							{
								bool flag6 = model4 == null;
								result = null;
								if (!flag6)
								{
									object obj6 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2072;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
									StoreInfoViewModel storeInfoViewModel = default(StoreInfoViewModel);
									storeInfoViewModel..ctor();
									if (storeInfoViewModel == null)
									{
										goto IL_0359;
									}
									object obj7 = storeInfoViewModel + 16;
									obj7 = model;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
									object obj8 = storeInfoViewModel + 24;
									obj8 = model2;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
									object obj9 = storeInfoViewModel + 32;
									obj9 = model3;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
									object obj10 = storeInfoViewModel + 40;
									obj10 = model4;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
									result = storeInfoViewModel;
								}
							}
						}
					}
					return result;
				}
			}
		}
		goto IL_0359;
		IL_0074:
		CachedModel<List<StoreItem>> storeItems2 = CachedModels.StoreItems;
		bool flag7 = storeItems2 == null;
		object obj11 = !flag7;
		cachedModel = (CachedModel<object>)(object)storeItems2;
		if (obj11 != null)
		{
			goto IL_012d;
		}
		goto IL_0359;
	}

	public static void ClearCacheAndRefreshStore()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00e2: Expected O, but got I4
		//IL_0097: Expected O, but got I4
		//IL_0169: Expected O, but got I
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Expected O, but got Unknown
		//IL_01b0: Expected O, but got I4
		//IL_020d: Expected O, but got I
		//IL_01eb: Expected O, but got I
		object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 4040;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E69DD]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v15+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v15+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		CachedModel<List<StoreItem>> storeItems = CachedModels.StoreItems;
		CachedModel<object> cachedModel = (CachedModel<object>)(object)storeItems;
		goto IL_0115;
		IL_0115:
		cachedModel.Clear();
		CachedModel<List<ProfileGiftModel>> storeProfileGifts = CachedModels.StoreProfileGifts;
		((CachedModel<object>)(object)storeProfileGifts).Clear();
		CachedModel<List<ProductViewModel>> storeProducts = CachedModels.StoreProducts;
		((CachedModel<object>)(object)storeProducts).Clear();
		CachedModel<List<ItemGroup>> storeItemGroups = CachedModels.StoreItemGroups;
		object obj5 = (nint)0 + (nint)440;
		object obj6 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
		((CachedModel<object>)(object)storeItemGroups).Clear();
		object obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X0_v11+E4]");
		bool flag2 = (nint)0 == 0;
		object obj8 = !flag2;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj7 = obj6;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X0_v11+B8]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X8_v13+18]");
		((OneShotEvent)0).IsReady = false;
		LoadStore();
		return;
		IL_0074:
		CachedModel<List<StoreItem>> storeItems2 = CachedModels.StoreItems;
		bool flag3 = storeItems2 == null;
		object obj10 = !flag3;
		cachedModel = (CachedModel<object>)(object)storeItems2;
		if (obj10 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0115;
	}

	private void LoadStoreHomePage()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_003e: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 640;
		object obj2 = (nint)0 + (nint)3944;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		KammelnaRequests.GetStoreHomePage(action);
	}

	public static void BuyFTTicket(int numberOfTickets = 1)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_026a: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Expected O, but got Unknown
		//IL_00b6: Expected O, but got I4
		//IL_010b: Expected O, but got I4
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected O, but got Unknown
		//IL_0168: Expected O, but got I
		//IL_0193: Expected F8, but got I4
		//IL_01bd: Expected O, but got I4
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Expected O, but got Unknown
		//IL_025a: Expected I8, but got I4
		object obj = typeof(RegisteredWaitHandle) + 2040;
		object key = "clear_mass_tournaments" + 264;
		object val = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 1864;
		object key2 = "alignContent" + 216;
		object command = "fetch_products" + 1568;
		object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		object obj3 = typeof(RegisteredWaitHandle) + 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSObject sFSObject = default(SFSObject);
		sFSObject..ctor();
		SFSExtensions.Put(sFSObject, (string)key, (string)val);
		SFSExtensions.Put(sFSObject, (string)key2, numberOfTickets);
		SFS.SendZoneExtensionRequest((string)command, sFSObject);
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v7+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string itemId = Tracker.ItemId(ResourceItemId.Fasttrack);
		object obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v11+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		RemoteConfigModel current = RemoteConfig.Current;
		FastTrackConfig <FastTrack>k__BackingField = current.<FastTrack>k__BackingField;
		object obj8 = typeof(Queue<string>) + 848;
		object obj9 = (nint)0 + (nint)2200;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
		Tracker.ResourceEvent(ResourceFlowType.Sink, ResourceItemType.Access, itemId, <FastTrack>k__BackingField.<TicketPrice>k__BackingField, ResourceCurrency.Aces);
		object obj10 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X0_v18+E4]");
		bool flag3 = (nint)0 == 0;
		object obj11 = !flag3;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		PlayerRank rank = SFSKammelnaUserExtensions.GetRank(localUser);
		string rankName = rank.RankName;
		RemoteConfigModel current2 = RemoteConfig.Current;
		FastTrackConfig <FastTrack>k__BackingField2 = current2.<FastTrack>k__BackingField;
		object action = "AvailableVoices" + 3160;
		FirebaseTrack.CurrencyEvent((string)action, rankName, <FastTrack>k__BackingField2.<TicketPrice>k__BackingField);
	}

	public static IEnumerable<StoreItem> GetCategoryItems(ItemCategory category)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_016d: Expected O, but got I4
		//IL_0093: Expected O, but got I
		//IL_01d5: Expected O, but got I
		//IL_01ff: Expected O, but got I4
		//IL_019b: Expected O, but got I
		//IL_01b5: Expected O, but got I4
		//IL_0109: Expected O, but got I
		//IL_00bc: Expected O, but got I
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Expected O, but got Unknown
		object obj = 152985600;
		object obj2 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E69E0]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v9+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v9+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45A8]");
		object obj6 = (nint)0 & (nint)1;
		bool flag2 = obj6 == null;
		object obj7 = !flag2;
		if (obj7 != null)
		{
			goto IL_00b0;
		}
		goto IL_01c3;
		IL_00f9:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X0_v24+B8]");
		object dict = 0;
		IEnumerable<StoreItem> enumerable = (IEnumerable<StoreItem>)DictionaryExtensions.Get((IDictionary<System.Int32Enum, object>)dict, (System.Int32Enum)category);
		if (enumerable != null)
		{
			return enumerable;
		}
		object obj8 = typeof(List<AdaptivePerformanceScaler>) + 3592;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		return (IEnumerable<StoreItem>)list;
		IL_021d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj9 = obj2;
		object obj11;
		object obj10 = obj11;
		goto IL_00f9;
		IL_00b0:
		obj10 = (nint)0 + (nint)3272;
		obj9 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X0_v24+E4]");
		bool flag3 = (nint)0 == 0;
		object obj12 = obj9;
		obj11 = obj10;
		if (!flag3)
		{
			goto IL_00f9;
		}
		goto IL_021d;
		IL_007d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45A8]");
		object obj13 = (nint)0 & (nint)1;
		if (obj13 != null)
		{
			goto IL_00b0;
		}
		goto IL_01c3;
		IL_01c3:
		_ = 1;
		obj10 = (nint)0 + (nint)3272;
		obj9 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X0_v24+E4]");
		bool flag4 = (nint)0 == 0;
		object obj14 = !flag4;
		obj12 = obj9;
		obj11 = obj10;
		if (obj14 != null)
		{
			goto IL_00f9;
		}
		goto IL_021d;
	}

	public static StoreItem GetStoreItem(int itemID)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0280: Expected O, but got I
		//IL_029a: Expected O, but got I4
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected O, but got Unknown
		//IL_0075: Expected O, but got I
		//IL_032c: Expected O, but got I
		//IL_035e: Expected O, but got I4
		//IL_02bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c2: Expected O, but got Unknown
		//IL_02ec: Expected O, but got I4
		//IL_014c: Expected O, but got I
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected O, but got Unknown
		//IL_016c: Expected O, but got I
		//IL_017d: Expected O, but got I
		//IL_018d: Expected O, but got I
		//IL_01af: Expected O, but got I4
		//IL_00f3: Expected O, but got I
		//IL_0245: Expected I, but got O
		//IL_01df: Expected O, but got I4
		//IL_03f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fd: Expected O, but got Unknown
		//IL_0413: Expected O, but got I
		//IL_0424: Expected I, but got O
		//IL_0442: Expected O, but got I
		//IL_020f: Expected O, but got I
		object obj = typeof(SkeletonBinary.SkeletonInput) + 1344;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3;
		object obj8;
		object obj11;
		object obj9;
		object obj12;
		if (obj2 != null)
		{
			obj3 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v5+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45A8]");
				object obj5 = (nint)0 & (nint)1;
				if (obj5 != null)
				{
					goto IL_0092;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45A8]");
				object obj6 = (nint)0 & (nint)1;
				bool flag = obj6 == null;
				object obj7 = !flag;
				if (obj7 != null)
				{
					goto IL_0092;
				}
			}
			_ = 1;
			obj8 = typeof(SkeletonBinary.SkeletonInput) + 1304;
			obj9 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X0_v34+E4]");
			bool flag2 = (nint)0 == 0;
			object obj10 = !flag2;
			obj11 = obj8;
			obj12 = obj9;
			if (obj10 != null)
			{
				goto IL_00e3;
			}
			goto IL_030a;
		}
		return (StoreItem)(object)new NullReferenceException();
		IL_030a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj13 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X0_v11+B8]");
		object obj14 = 0;
		IEnumerable<KeyValuePair<System.Int32Enum, object>> source = (IEnumerable<KeyValuePair<System.Int32Enum, object>>)obj14;
		object obj15 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X0_v19+E4]");
		bool flag3 = (nint)0 == 0;
		object obj16 = !flag3;
		obj8 = obj11;
		object obj17 = obj15;
		IEnumerable<KeyValuePair<System.Int32Enum, object>> enumerable = (IEnumerable<KeyValuePair<System.Int32Enum, object>>)obj14;
		if (obj16 != null)
		{
			goto IL_0140;
		}
		goto IL_0384;
		IL_0092:
		obj8 = typeof(SkeletonBinary.SkeletonInput) + 1304;
		obj9 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X0_v34+E4]");
		bool flag4 = (nint)0 == 0;
		obj11 = obj8;
		obj12 = obj9;
		if (!flag4)
		{
			goto IL_00e3;
		}
		goto IL_030a;
		IL_0140:
		object obj18 = (nint)0 + (nint)240;
		object obj19 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3432;
		object obj20 = (nint)0 + (nint)1344;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X0_v19+B8]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X8_v15+30]");
		Func<KeyValuePair<System.Int32Enum, object>, IEnumerable<object>> selector = (Func<KeyValuePair<System.Int32Enum, object>, IEnumerable<object>>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X8_v15+30]");
		bool flag5 = (nint)0 == 0;
		object obj22 = !flag5;
		if (obj22 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X0_v19+E4]");
			bool flag6 = (nint)0 == 0;
			object obj23 = !flag6;
			if (obj23 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj24 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X8_v21+B8]");
				obj21 = 0;
			}
			object obj25 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 3480;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj26 = (nint)0 + (nint)1304;
			Func<KeyValuePair<System.Int32Enum, object>, object> func = default(Func<KeyValuePair<System.Int32Enum, object>, object>);
			func..ctor(obj21, (IntPtr)obj26);
			object obj27 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X8_v20+B8]");
			object obj28 = (nint)0 + (nint)48;
			obj28 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			selector = (Func<KeyValuePair<System.Int32Enum, object>, IEnumerable<object>>)func;
		}
		IEnumerable<object> source2 = Enumerable.SelectMany(source, selector);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<object, bool> func2 = default(Func<object, bool>);
		func2..ctor(obj2, (IntPtr)obj20);
		return (StoreItem)Enumerable.FirstOrDefault(source2, func2);
		IL_0384:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj15 = obj11;
		obj8 = obj11;
		source = enumerable;
		goto IL_0140;
		IL_00e3:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X0_v34+B8]");
		object obj29 = 0;
		source = (IEnumerable<KeyValuePair<System.Int32Enum, object>>)obj29;
		obj15 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X0_v19+E4]");
		bool flag7 = (nint)0 == 0;
		obj11 = obj8;
		obj17 = obj15;
		enumerable = (IEnumerable<KeyValuePair<System.Int32Enum, object>>)obj29;
		if (!flag7)
		{
			goto IL_0140;
		}
		goto IL_0384;
	}

	public static StoreItem GetStoreItem(GameAction action)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_004d: Expected O, but got I
		//IL_007d: Expected O, but got I4
		//IL_00c8: Expected I, but got O
		object obj = typeof(SkeletonBinary.SkeletonInput) + 1352;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (obj2 != null)
		{
			object obj3 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
			object obj4 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3432;
			object obj5 = (nint)0 + (nint)1352;
			object obj6 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v5+E4]");
			bool flag = (nint)0 == 0;
			object obj7 = !flag;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			IEnumerable<StoreItem> categoryItems = GetCategoryItems(ItemCategory.GameActions);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj2, (IntPtr)obj5);
			return (StoreItem)Enumerable.FirstOrDefault(categoryItems, func);
		}
		return (StoreItem)(object)new NullReferenceException();
	}

	public static void ResetModels(bool preserveSubscribers = false)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0099: Expected O, but got I4
		//IL_0116: Expected O, but got I
		//IL_003b: Expected O, but got I4
		//IL_00cf: Expected O, but got I
		//IL_0101: Expected O, but got I
		//IL_0076: Expected O, but got I
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
		object obj2 = obj;
		if (preserveSubscribers)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v5+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v5+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v6+18]");
			((OneShotEvent)0).IsReady = false;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v5+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v5+B8]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v5+18]");
			((OneShotEvent)0).Clear();
		}
	}

	public static List<ProfileGiftModel> GetProfileGifts()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0132: Expected O, but got I4
		//IL_0093: Expected O, but got I
		//IL_01b8: Expected O, but got I4
		//IL_0160: Expected O, but got I
		//IL_017a: Expected O, but got I4
		//IL_00f5: Expected O, but got I
		//IL_0102: Expected O, but got I
		//IL_01f0: Expected O, but got I
		//IL_01fd: Expected O, but got I
		object obj = 152985600;
		object obj2 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E69E4]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v10+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v10+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45AC]");
		object obj6 = (nint)0 & (nint)1;
		bool flag2 = obj6 == null;
		object obj7 = !flag2;
		if (obj7 != null)
		{
			goto IL_00b0;
		}
		goto IL_0188;
		IL_00e5:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v16+B8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v12+8]");
		return (List<ProfileGiftModel>)0;
		IL_01ce:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj9 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X0_v3+B8]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X8_v3+8]");
		return (List<ProfileGiftModel>)0;
		IL_00b0:
		object obj11 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v16+E4]");
		bool flag3 = (nint)0 == 0;
		object obj12 = obj11;
		if (!flag3)
		{
			goto IL_00e5;
		}
		goto IL_01ce;
		IL_007d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45AC]");
		object obj13 = (nint)0 & (nint)1;
		if (obj13 != null)
		{
			goto IL_00b0;
		}
		goto IL_0188;
		IL_0188:
		_ = 1;
		obj11 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v16+E4]");
		bool flag4 = (nint)0 == 0;
		object obj14 = !flag4;
		obj12 = obj11;
		if (obj14 != null)
		{
			goto IL_00e5;
		}
		goto IL_01ce;
	}

	public static ProfileGiftModel GetProfileGift(long giftID)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_00e4: Expected O, but got I
		//IL_0075: Expected O, but got I
		//IL_008f: Expected O, but got I4
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Expected O, but got Unknown
		//IL_0164: Expected O, but got I
		//IL_018f: Expected O, but got I4
		//IL_01ad: Expected O, but got I
		//IL_01c8: Expected I, but got O
		//IL_01dd: Expected O, but got I
		object obj = typeof(SkeletonBinary.SkeletonInput) + 1360;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3;
		if (obj2 != null)
		{
			obj3 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v5+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45AC]");
				object obj5 = (nint)0 & (nint)1;
				bool flag = obj5 == null;
				object obj6 = !flag;
				if (obj6 == null)
				{
					goto IL_009d;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45AC]");
				object obj7 = (nint)0 & (nint)1;
				if (obj7 == null)
				{
					goto IL_009d;
				}
			}
			goto IL_0144;
		}
		return (ProfileGiftModel)(object)new NullReferenceException();
		IL_009d:
		_ = 1;
		goto IL_0144;
		IL_0144:
		object obj8 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2928;
		object obj9 = (nint)0 + (nint)1360;
		object obj10 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v8+E4]");
		bool flag2 = (nint)0 == 0;
		object obj11 = !flag2;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj10 = obj3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v8+B8]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<object, bool> func = default(Func<object, bool>);
		func..ctor(obj2, (IntPtr)obj9);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X8_v6+8]");
		return (ProfileGiftModel)Enumerable.FirstOrDefault((IEnumerable<object>)0, func);
	}

	public void PlaySuccessfulPurchase()
	{
		//IL_0011: Expected O, but got I
		object obj = (nint)0 + (nint)2456;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CFF124");
		SingleSound singleSound = default(SingleSound);
		SoundChannel.PlaySFXSound(singleSound);
	}

	public void PlayItemActivate()
	{
		//IL_0011: Expected O, but got I
		object obj = (nint)0 + (nint)2456;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CFF124");
		SingleSound singleSound = default(SingleSound);
		SoundChannel.PlaySFXSound(singleSound);
	}

	public void PlayCardBackSwitchToLeft()
	{
		//IL_0011: Expected O, but got I
		object obj = (nint)0 + (nint)2456;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CFF124");
		SingleSound singleSound = default(SingleSound);
		SoundChannel.PlaySFXSound(singleSound);
	}

	public void PlayCardBackSwitchToRight()
	{
		//IL_0011: Expected O, but got I
		object obj = (nint)0 + (nint)2456;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CFF124");
		SingleSound singleSound = default(SingleSound);
		SoundChannel.PlaySFXSound(singleSound);
	}

	static Store()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_005f: Expected O, but got I
		object obj = typeof(MemberAchievementClanFeedData) + 3440;
		object obj2 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		OneShotEvent oneShotEvent = default(OneShotEvent);
		oneShotEvent..ctor();
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v3+B8]");
		object obj4 = (nint)0 + (nint)24;
		obj4 = oneShotEvent;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	private void <Start>b__39_0()
	{
		AssignStoreValuesToScene(ItemCategory.Cards);
		AssignStoreValuesToScene(ItemCategory.Rooms);
	}

	private void <LoadStoreHomePage>b__59_0(KammelnaResponseModel<StoreHomePageViewModel> response)
	{
		//IL_0011: Expected O, but got I
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		//IL_00e0: Expected O, but got I4
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		object obj = (nint)0 + (nint)1512;
		if (((KammelnaResponseModel<object>)(object)response).Succeeded)
		{
			storeLoadingIndicator.FinishLoading();
			storeHomePageGroup.Populate(response.<Model>k__BackingField);
			object obj2 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v12+E4]");
			if ((nint)0 != 0)
			{
				ClearStoreCounter();
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			ClearStoreCounter();
			return;
		}
		object obj4 = typeof(DataRelation) + 856;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object message = "___# Content push apply failed [{0}]: {1}" + 480;
		Debug.LogError(message);
	}
}
