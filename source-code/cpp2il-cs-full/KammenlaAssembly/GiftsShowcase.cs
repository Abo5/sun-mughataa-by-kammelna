using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Features.GameReplay;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server.Models.Clans;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using Sfs2X.Entities;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;
using Util;

public class GiftsShowcase : MonoBehaviour
{
	private class GiftQueueItem : IEquatable<GiftQueueItem>
	{
		private readonly int <GiftID>k__BackingField;

		private readonly long <Expiration>k__BackingField;

		private readonly int <InstanceID>k__BackingField;

		private readonly Transform <Transform>k__BackingField;

		public int GiftID => <GiftID>k__BackingField;

		public long Expiration => <Expiration>k__BackingField;

		public int InstanceID => <InstanceID>k__BackingField;

		public Transform Transform => <Transform>k__BackingField;

		public bool IsExpired
		{
			get
			{
				//IL_0009: Expected O, but got I4
				//IL_0018: Unknown result type (might be due to invalid IL or missing references)
				//IL_001d: Expected O, but got Unknown
				//IL_0033: Expected O, but got I
				//IL_0185: Unknown result type (might be due to invalid IL or missing references)
				//IL_018a: Expected O, but got Unknown
				//IL_01be: Expected O, but got I4
				//IL_005f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0064: Expected O, but got Unknown
				//IL_010d: Expected O, but got I8
				//IL_0131: Unknown result type (might be due to invalid IL or missing references)
				//IL_0136: Expected I8, but got Unknown
				//IL_0220: Expected O, but got I4
				object obj = 152985600;
				object obj2 = typeof(DataRelation) + 712;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E66E3]");
				object obj3 = (nint)0 & (nint)1;
				object obj4;
				long num;
				object obj6;
				long num2;
				if (obj3 != null)
				{
					obj4 = typeof(DataRelation) + 824;
					num = <Expiration>k__BackingField;
					object obj5 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v5+E4]");
					bool flag = (nint)0 == 0;
					obj6 = obj4;
					num2 = <Expiration>k__BackingField;
					if (!flag)
					{
						goto IL_00ad;
					}
				}
				else
				{
					_ = 1;
					obj4 = typeof(DataRelation) + 824;
					num = <Expiration>k__BackingField;
					object obj5 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v5+E4]");
					bool flag2 = (nint)0 == 0;
					object obj7 = !flag2;
					obj6 = obj4;
					num2 = <Expiration>k__BackingField;
					if (obj7 != null)
					{
						goto IL_00ad;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				DateTime dateTime = DateTime.Now;
				object obj8 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X8_v2+E4]");
				bool flag3 = (nint)0 == 0;
				object obj9 = !flag3;
				num = num2;
				DateTime dateTime2 = dateTime;
				if (obj9 != null)
				{
					goto IL_00f3;
				}
				goto IL_023e;
				IL_00f3:
				long num3 = DateTimeUtil.ToUniversalTimestamp(dateTime);
				object obj10 = num - num3;
				bool flag4 = (nint)obj10 < 0;
				long num4 = num ^ num3;
				long num5 = num ^ obj10;
				long num6 = num4 & num5;
				bool flag5 = num6 < 0;
				bool flag6 = flag4 == flag5;
				return !flag6;
				IL_023e:
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				dateTime = dateTime2;
				num = num2;
				goto IL_00f3;
				IL_00ad:
				dateTime = DateTime.Now;
				obj8 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X8_v2+E4]");
				bool flag7 = (nint)0 == 0;
				dateTime2 = dateTime;
				num2 = num;
				if (!flag7)
				{
					goto IL_00f3;
				}
				goto IL_023e;
			}
		}

		public GiftQueueItem(int instanceId, Transform transform, int giftId, long expiration)
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Expected O, but got Unknown
			object obj = this + 40;
			obj = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		public GiftQueueItem(StoreOwnedItem item)
		{
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Expected O, but got Unknown
			//IL_00ca: Expected I8, but got I4
			//IL_0053: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Expected O, but got Unknown
			//IL_0082: Expected O, but got I4
			//IL_00b0: Expected O, but got I
			<GiftID>k__BackingField = item.<itemId>k__BackingField;
			if ((object)((??)item.<expirationDate>k__BackingField & 1) != null)
			{
				object obj = typeof(DataRelation) + 824;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v5+E4]");
				if ((object)((nint)0 != 0) == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [item @ X1 (StoreOwnedItem)+20]");
				<Expiration>k__BackingField = DateTimeUtil.ToTimestamp((DateTime)0);
			}
			else
			{
				<Expiration>k__BackingField = -1L;
			}
		}

		public override bool Equals(object obj)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0029: Expected I, but got O
			//IL_0052: Expected O, but got I4
			//IL_0086: Expected O, but got I
			//IL_00ed: Expected O, but got I8
			if (obj != null)
			{
				object obj2 = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 464;
				object obj3 = obj2;
				nint num = (nint)obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X9_v2 (Il2CppClass<System.Object>)+130]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v6+130]");
				bool flag = num2 < 0;
				object obj4 = !flag;
				object obj5 = ~obj4;
				if (obj5 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X9_v2 (Il2CppClass<System.Object>)+C8]");
					nint num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v6+130]");
					object obj6 = num3 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X9_v4-8]");
					if (0 == (nint)obj3)
					{
						int num4 = <GiftID>k__BackingField;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [obj @ X1 (System.Object)+10]");
						if ((nint)num4 == 0)
						{
							long num5 = <Expiration>k__BackingField;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [obj @ X1 (System.Object)+18]");
							object obj7 = num5 - 0;
							return obj7 == null;
						}
					}
				}
			}
			return false;
		}

		public bool Equals(GiftQueueItem other)
		{
			//IL_0057: Expected O, but got I8
			if (other != null && <GiftID>k__BackingField == other.<GiftID>k__BackingField)
			{
				object obj = <Expiration>k__BackingField - other.<Expiration>k__BackingField;
				return obj == null;
			}
			return false;
		}

		public override int GetHashCode()
		{
			return <InstanceID>k__BackingField;
		}
	}

	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<GiftQueueItem, bool> <>9__17_0;

		public static Func<GiftQueueItem, bool> <>9__17_2;

		public static Func<StoreOwnedItem, bool> <>9__27_0;

		public static Func<StoreOwnedItem, GiftQueueItem> <>9__27_1;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 384;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal bool <Update>b__17_0(GiftQueueItem item)
		{
			//IL_0294: Expected I4, but got O
			//IL_0026: Expected O, but got I4
			//IL_0035: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Expected O, but got Unknown
			//IL_0050: Expected O, but got I
			//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ad: Expected O, but got Unknown
			//IL_01e4: Expected O, but got I4
			//IL_007c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0081: Expected O, but got Unknown
			//IL_0130: Expected O, but got I8
			//IL_0154: Unknown result type (might be due to invalid IL or missing references)
			//IL_0159: Expected I8, but got Unknown
			//IL_0249: Expected O, but got I4
			object obj4;
			long num;
			long num2;
			DateTime dateTime;
			DateTime dateTime2;
			object obj8;
			if (item != null)
			{
				object obj = 152985600;
				object obj2 = typeof(DataRelation) + 712;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E66E3]");
				object obj3 = (nint)0 & (nint)1;
				object obj6;
				if (obj3 != null)
				{
					obj4 = typeof(DataRelation) + 824;
					num = item.<Expiration>k__BackingField;
					object obj5 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v6+E4]");
					bool flag = (nint)0 == 0;
					obj6 = obj4;
					num2 = item.<Expiration>k__BackingField;
					if (!flag)
					{
						goto IL_00d0;
					}
				}
				else
				{
					_ = 1;
					obj4 = typeof(DataRelation) + 824;
					num = item.<Expiration>k__BackingField;
					object obj5 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v6+E4]");
					bool flag2 = (nint)0 == 0;
					object obj7 = !flag2;
					obj6 = obj4;
					num2 = item.<Expiration>k__BackingField;
					if (obj7 != null)
					{
						goto IL_00d0;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				dateTime = DateTime.Now;
				obj8 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X8_v2+E4]");
				bool flag3 = (nint)0 == 0;
				object obj9 = !flag3;
				num = num2;
				dateTime2 = dateTime;
				if (obj9 != null)
				{
					goto IL_0116;
				}
				goto IL_0267;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_00d0:
			dateTime = DateTime.Now;
			obj8 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X8_v2+E4]");
			bool flag4 = (nint)0 == 0;
			dateTime2 = dateTime;
			num2 = num;
			if (!flag4)
			{
				goto IL_0116;
			}
			goto IL_0267;
			IL_0267:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			dateTime = dateTime2;
			num = num2;
			goto IL_0116;
			IL_0116:
			long num3 = DateTimeUtil.ToUniversalTimestamp(dateTime);
			object obj10 = num - num3;
			bool flag5 = (nint)obj10 < 0;
			long num4 = num ^ num3;
			long num5 = num ^ obj10;
			long num6 = num4 & num5;
			bool flag6 = num6 < 0;
			bool flag7 = flag5 == flag6;
			return !flag7;
		}

		internal bool <Update>b__17_2(GiftQueueItem item)
		{
			//IL_0294: Expected I4, but got O
			//IL_0026: Expected O, but got I4
			//IL_0035: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Expected O, but got Unknown
			//IL_0050: Expected O, but got I
			//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ad: Expected O, but got Unknown
			//IL_01e4: Expected O, but got I4
			//IL_007c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0081: Expected O, but got Unknown
			//IL_0130: Expected O, but got I8
			//IL_0154: Unknown result type (might be due to invalid IL or missing references)
			//IL_0159: Expected I8, but got Unknown
			//IL_0249: Expected O, but got I4
			object obj4;
			long num;
			long num2;
			DateTime dateTime;
			DateTime dateTime2;
			object obj8;
			if (item != null)
			{
				object obj = 152985600;
				object obj2 = typeof(DataRelation) + 712;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E66E3]");
				object obj3 = (nint)0 & (nint)1;
				object obj6;
				if (obj3 != null)
				{
					obj4 = typeof(DataRelation) + 824;
					num = item.<Expiration>k__BackingField;
					object obj5 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v6+E4]");
					bool flag = (nint)0 == 0;
					obj6 = obj4;
					num2 = item.<Expiration>k__BackingField;
					if (!flag)
					{
						goto IL_00d0;
					}
				}
				else
				{
					_ = 1;
					obj4 = typeof(DataRelation) + 824;
					num = item.<Expiration>k__BackingField;
					object obj5 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v6+E4]");
					bool flag2 = (nint)0 == 0;
					object obj7 = !flag2;
					obj6 = obj4;
					num2 = item.<Expiration>k__BackingField;
					if (obj7 != null)
					{
						goto IL_00d0;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				dateTime = DateTime.Now;
				obj8 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X8_v2+E4]");
				bool flag3 = (nint)0 == 0;
				object obj9 = !flag3;
				num = num2;
				dateTime2 = dateTime;
				if (obj9 != null)
				{
					goto IL_0116;
				}
				goto IL_0267;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_00d0:
			dateTime = DateTime.Now;
			obj8 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X8_v2+E4]");
			bool flag4 = (nint)0 == 0;
			dateTime2 = dateTime;
			num2 = num;
			if (!flag4)
			{
				goto IL_0116;
			}
			goto IL_0267;
			IL_0267:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			dateTime = dateTime2;
			num = num2;
			goto IL_0116;
			IL_0116:
			long num3 = DateTimeUtil.ToUniversalTimestamp(dateTime);
			object obj10 = num - num3;
			bool flag5 = (nint)obj10 < 0;
			long num4 = num ^ num3;
			long num5 = num ^ obj10;
			long num6 = num4 & num5;
			bool flag6 = num6 < 0;
			bool flag7 = flag5 == flag6;
			return !flag7;
		}

		internal bool <LoadPlayersGifts>b__27_0(StoreOwnedItem item)
		{
			//IL_004b: Expected I4, but got O
			if (item != null)
			{
				bool isExpired = item.isExpired;
				return (byte)((isExpired ? 1u : 0u) ^ 1u) != 0;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal GiftQueueItem <LoadPlayersGifts>b__27_1(StoreOwnedItem item)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 464;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			GiftQueueItem giftQueueItem = default(GiftQueueItem);
			giftQueueItem..ctor(item);
			return giftQueueItem;
		}
	}

	private sealed class <>c__DisplayClass17_0
	{
		public GiftQueueItem item;

		internal bool <Update>b__3(GameObject slot)
		{
			//IL_0087: Expected I4, but got O
			//IL_0065: Expected O, but got I4
			if ((object)slot != null)
			{
				int instanceID = slot.GetInstanceID();
				GiftQueueItem giftQueueItem = item;
				if (item != null)
				{
					object obj = instanceID - giftQueueItem.<InstanceID>k__BackingField;
					return obj == null;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass18_0
	{
		public GiftsShowcase <>4__this;

		public GiftNotification gift;

		internal void <OnGiftReceived>b__0()
		{
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0032: Expected O, but got Unknown
			//IL_0077: Unknown result type (might be due to invalid IL or missing references)
			//IL_007c: Expected O, but got Unknown
			GiftNotification giftNotification = gift;
			GiftsShowcase giftsShowcase = <>4__this;
			object obj = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 464;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			_ = 0;
			object obj3 = obj2 + 40;
			obj3 = giftsShowcase._broadcastPoint;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			_ = giftNotification.<ItemId>k__BackingField;
			_ = -1;
			giftsShowcase.QueueGift((GiftQueueItem)obj2);
		}
	}

	private sealed class <>c__DisplayClass23_0
	{
		public GameObject prefab;

		public GiftsShowcase <>4__this;

		public Vector2 giftSize;

		public Vector3 giftScale;

		public GameObject slot;

		public Transform startPosition;

		public int giftId;

		public long expiration;

		public Quaternion giftRotation;

		public Action <>9__1;

		public Func<GiftQueueItem, bool> <>9__2;

		public TweenCallback <>9__3;

		internal void <AddGift>b__0(bool success)
		{
			//IL_0b59: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b5e: Expected O, but got Unknown
			//IL_0443: Expected O, but got I4
			//IL_005f: Expected O, but got I
			//IL_0094: Expected O, but got I4
			//IL_00ed: Expected O, but got I4
			//IL_0118: Expected O, but got I
			//IL_014e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0153: Expected O, but got Unknown
			//IL_0175: Expected O, but got I4
			//IL_019a: Unknown result type (might be due to invalid IL or missing references)
			//IL_019f: Expected O, but got Unknown
			//IL_01b5: Expected O, but got I
			//IL_01c3: Expected I, but got O
			//IL_0230: Expected O, but got I
			//IL_01e5: Expected O, but got I4
			//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a8: Expected O, but got Unknown
			//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d3: Expected O, but got Unknown
			//IL_0328: Expected O, but got I
			//IL_039f: Expected O, but got I4
			//IL_0493: Expected O, but got I
			//IL_04a3: Expected O, but got I
			//IL_04b3: Expected O, but got I
			//IL_03df: Unknown result type (might be due to invalid IL or missing references)
			//IL_03e4: Expected O, but got Unknown
			//IL_03ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_03f2: Expected O, but got Unknown
			//IL_0501: Unknown result type (might be due to invalid IL or missing references)
			//IL_0506: Expected O, but got Unknown
			//IL_0528: Expected O, but got I4
			//IL_0545: Unknown result type (might be due to invalid IL or missing references)
			//IL_054a: Expected O, but got Unknown
			//IL_0560: Expected O, but got I
			//IL_056e: Expected I, but got O
			//IL_05e2: Expected O, but got I
			//IL_0590: Expected O, but got I4
			//IL_0670: Expected O, but got I4
			//IL_0690: Unknown result type (might be due to invalid IL or missing references)
			//IL_0695: Expected O, but got Unknown
			//IL_069e: Unknown result type (might be due to invalid IL or missing references)
			//IL_06a3: Expected O, but got Unknown
			//IL_06e1: Expected O, but got I4
			//IL_08f4: Expected O, but got I4
			//IL_07d8: Expected O, but got I4
			//IL_0993: Expected F4, but got O
			//IL_0993: Expected O, but got I4
			//IL_09a8: Expected O, but got I
			//IL_0831: Expected O, but got I4
			//IL_09f4: Expected F4, but got O
			//IL_09f4: Expected O, but got I4
			//IL_0a09: Expected O, but got I
			//IL_0b1d: Expected O, but got I
			//IL_0a65: Expected O, but got I4
			//IL_0a7e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a83: Expected O, but got Unknown
			//IL_0aa5: Expected O, but got I4
			//IL_0bb9: Expected O, but got I
			//IL_0ac2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ac7: Expected O, but got Unknown
			//IL_0add: Expected O, but got I
			//IL_0aeb: Expected I, but got O
			object obj = typeof(MemberAchievementClanFeedData) + 2976;
			GiftsShowcase giftsShowcase5;
			if (success)
			{
				if ((object)prefab != null)
				{
					prefab.SetActive(value: true);
					if ((object)prefab != null)
					{
						object obj2 = (nint)0 + (nint)1360;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E32EDC");
						RectTransform rectTransform = default(RectTransform);
						if ((object)rectTransform != null)
						{
							rectTransform.sizeDelta = (Vector2)0;
							if ((object)prefab != null)
							{
								Transform transform = prefab.transform;
								if ((object)transform != null)
								{
									transform.localScale = (Vector3)0;
									if ((object)prefab != null)
									{
										object obj3 = (nint)0 + (nint)1344;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E32EDC");
										ParticleSystem particleSystem = default(ParticleSystem);
										if ((object)particleSystem != null)
										{
											particleSystem.Stop();
											object obj4 = this + 104;
											Action action = (Action)obj4;
											bool flag = obj4 == null;
											object obj5 = !flag;
											GiftsShowcase giftsShowcase = (GiftsShowcase)(object)particleSystem;
											if (obj5 == null)
											{
												object obj6 = typeof(SqlSingle[]) + 2376;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
												object obj7 = (nint)0 + (nint)2360;
												Action action2 = default(Action);
												action2..ctor(this, (IntPtr)obj7);
												<>9__1 = action2;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
												object obj8 = 0;
												action = action2;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X22_v5-50]");
											if ((nint)0 != 0)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X22_v5-30]");
												giftsShowcase.Explode((GameObject)0, action);
												GiftsShowcase giftsShowcase2 = <>4__this;
												if ((object)<>4__this != null && (object)prefab != null)
												{
													List<object> activeGifts = (List<object>)(object)giftsShowcase2.activeGifts;
													int instanceID = prefab.GetInstanceID();
													object obj9 = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 464;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
													object obj10 = default(object);
													obj10..ctor();
													object obj11 = obj10 + 40;
													obj11 = startPosition;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
													_ = giftId;
													_ = expiration;
													if (giftsShowcase2.activeGifts != null)
													{
														object obj12 = (nint)0 + (nint)2360;
														object obj13 = obj12;
														int version = activeGifts._version + 1;
														activeGifts._version = version;
														object[] items = activeGifts._items;
														if (activeGifts._items != null)
														{
															bool flag2 = activeGifts._size < items.Length;
															object obj14 = !flag2;
															if (obj14 == null)
															{
																int size = activeGifts._size + 1;
																activeGifts._size = size;
																object obj15 = activeGifts._items + activeGifts._size;
																object obj16 = obj15 + 32;
																obj16 = obj10;
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																Action action3 = action;
																object obj17 = obj10;
															}
															else
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X8_v17+20]");
																object obj18 = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v464 @ X8_v47+C0]");
																object obj19 = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v465 @ X8_v48+70]");
																Action action3 = (Action)0;
																((List<object>)(object)giftsShowcase2.activeGifts).AddWithResize(obj10);
																object obj17 = obj10;
															}
															GiftsShowcase giftsShowcase3 = <>4__this;
															if ((object)<>4__this != null)
															{
																object obj20 = this + 112;
																Func<object, bool> predicate = (Func<object, bool>)obj20;
																bool flag3 = obj20 == null;
																object obj21 = !flag3;
																if (obj21 == null)
																{
																	object obj22 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 408;
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
																	object obj23 = (nint)0 + (nint)2368;
																	Func<object, bool> func = default(Func<object, bool>);
																	func..ctor((object)this, (IntPtr)obj23);
																	<>9__2 = func;
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																	object obj8 = 0;
																	predicate = func;
																}
																object item = Enumerable.FirstOrDefault(giftsShowcase3.activeGifts, predicate);
																if (giftsShowcase3.activeGifts != null)
																{
																	object obj24 = (nint)0 + (nint)2384;
																	bool flag4 = ((List<object>)(object)giftsShowcase3.activeGifts).Remove(item);
																	GiftsShowcase giftsShowcase4 = <>4__this;
																	if ((object)<>4__this != null)
																	{
																		GameObject[] slots = giftsShowcase4.Slots;
																		if (giftsShowcase4.Slots != null)
																		{
																			bool flag5 = giftsShowcase4.nextSlot < slots.Length;
																			object obj25 = !flag5;
																			if (obj25 != null)
																			{
																				goto IL_0b43;
																			}
																			object obj26 = giftsShowcase4.Slots + giftsShowcase4.nextSlot;
																			object obj27 = obj26 + 32;
																			obj27 = prefab;
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																			object obj28 = obj;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v500 @ X0_v34+E4]");
																			bool flag6 = (nint)0 == 0;
																			object obj29 = !flag6;
																			if (obj29 == null)
																			{
																				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																			}
																			if (startPosition == null)
																			{
																				if ((object)prefab != null)
																				{
																					Transform transform2 = prefab.transform;
																					if ((object)slot != null)
																					{
																						Transform transform3 = slot.transform;
																						if ((object)transform3 != null)
																						{
																							Vector3 localPosition = transform3.localPosition;
																							if ((object)transform2 != null)
																							{
																								transform2.localPosition = (Vector3)0;
																								if ((object)prefab != null)
																								{
																									Transform transform4 = prefab.transform;
																									if ((object)transform4 != null)
																									{
																										transform4.rotation = (Quaternion)0;
																										giftsShowcase5 = <>4__this;
																										if ((object)<>4__this != null)
																										{
																											giftsShowcase5.animating = false;
																											goto IL_0b11;
																										}
																									}
																								}
																							}
																						}
																					}
																				}
																			}
																			else if ((object)prefab != null)
																			{
																				Transform transform5 = prefab.transform;
																				if ((object)startPosition != null)
																				{
																					Vector3 position = startPosition.position;
																					if ((object)transform5 != null)
																					{
																						transform5.position = (Vector3)0;
																						if ((object)prefab != null)
																						{
																							Transform transform6 = prefab.transform;
																							if ((object)slot != null)
																							{
																								Transform transform7 = slot.transform;
																								if ((object)transform7 != null)
																								{
																									Vector3 localPosition2 = transform7.localPosition;
																									TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOLocalMove(transform6, (Vector3)0, (float)giftScale);
																									object obj30 = (nint)0 + (nint)2904;
																									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
																									if ((object)prefab != null)
																									{
																										Transform transform8 = prefab.transform;
																										TweenerCore<Quaternion, Quaternion, NoOptions> tweenerCore2 = ShortcutExtensions.DORotateQuaternion(transform8, (Quaternion)0, (float)giftRotation);
																										object obj31 = (nint)0 + (nint)2832;
																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
																										if ((object)prefab != null)
																										{
																											Transform transform9 = prefab.transform;
																											float duration = (float)giftScale * 1.0687087E+09f;
																											TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore3 = ShortcutExtensions.DOScale(transform9, (Vector3)0, duration);
																											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
																											object obj32 = this + 120;
																											TweenCallback tweenCallback = (TweenCallback)obj32;
																											bool flag7 = obj32 == null;
																											object obj33 = !flag7;
																											if (obj33 == null)
																											{
																												object obj34 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
																												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
																												object obj35 = (nint)0 + (nint)2376;
																												TweenCallback tweenCallback2 = default(TweenCallback);
																												tweenCallback2..ctor(this, (IntPtr)obj35);
																												<>9__3 = tweenCallback2;
																												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																												tweenCallback = tweenCallback2;
																											}
																											object obj36 = (nint)0 + (nint)2504;
																											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
																											giftsShowcase5 = <>4__this;
																											if ((object)<>4__this != null)
																											{
																												goto IL_0b11;
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
					}
				}
			}
			else
			{
				object obj37 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v5+E4]");
				bool flag8 = (nint)0 == 0;
				object obj38 = !flag8;
				UnityEngine.Object obj39 = prefab;
				if (obj38 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj39 = prefab;
				}
				UnityEngine.Object.Destroy(obj39);
				GiftsShowcase giftsShowcase6 = <>4__this;
				if ((object)<>4__this != null)
				{
					giftsShowcase6.animating = false;
					return;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			goto IL_0b43;
			IL_0b11:
			object obj40 = (nint)0 + (nint)2456;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C96E70");
			int nextSlot = default(int);
			giftsShowcase5.nextSlot = nextSlot;
			return;
			IL_0b43:
			throw new IndexOutOfRangeException();
		}

		internal void <AddGift>b__1()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_00c2: Expected O, but got I4
			object obj = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E66E9]");
			object obj2 = (nint)0 & (nint)1;
			UnityEngine.Object obj4;
			UnityEngine.Object obj5;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v1+E4]");
				bool flag = (nint)0 == 0;
				obj4 = slot;
				obj5 = slot;
				if (!flag)
				{
					goto IL_0088;
				}
			}
			else
			{
				_ = 1;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v1+E4]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				obj4 = slot;
				obj5 = slot;
				if (obj6 != null)
				{
					goto IL_0088;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			UnityEngine.Object.Destroy(obj5);
			return;
			IL_0088:
			UnityEngine.Object.Destroy(obj4);
		}

		internal bool <AddGift>b__2(GiftQueueItem g)
		{
			//IL_007f: Expected I4, but got O
			//IL_005d: Expected O, but got I4
			if (g != null && (object)slot != null)
			{
				int instanceID = slot.GetInstanceID();
				object obj = g.<InstanceID>k__BackingField - instanceID;
				return obj == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal void <AddGift>b__3()
		{
			//IL_0011: Expected O, but got I
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Expected O, but got Unknown
			//IL_0031: Expected O, but got I
			//IL_003d: Expected O, but got I
			//IL_0060: Expected F4, but got O
			//IL_0060: Expected O, but got I4
			//IL_0095: Expected I, but got O
			object obj = (nint)0 + (nint)2904;
			object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
			object obj3 = (nint)0 + (nint)3432;
			object obj4 = (nint)0 + (nint)2504;
			Transform transform = prefab.transform;
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOScale(transform, (Vector3)0, (float)giftScale);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			TweenCallback tweenCallback = default(TweenCallback);
			tweenCallback..ctor(<>4__this, (IntPtr)obj3);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
		}
	}

	private sealed class <>c__DisplayClass24_0
	{
		public GiftsShowcase <>4__this;

		public GameObject newGift;

		public Func<GiftQueueItem, bool> <>9__3;

		internal void <ShiftGifts>b__0()
		{
			//IL_009a: Expected O, but got I
			//IL_00e1: Expected O, but got I4
			//IL_00f7: Expected O, but got I
			//IL_0117: Unknown result type (might be due to invalid IL or missing references)
			//IL_011c: Expected O, but got Unknown
			//IL_0139: Unknown result type (might be due to invalid IL or missing references)
			//IL_013e: Expected O, but got Unknown
			//IL_014a: Expected O, but got I
			//IL_0167: Expected I, but got O
			//IL_0198: Expected O, but got I
			//IL_0198: Expected O, but got I
			//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01cd: Expected O, but got Unknown
			//IL_01ef: Expected O, but got I4
			//IL_0214: Unknown result type (might be due to invalid IL or missing references)
			//IL_0219: Expected O, but got Unknown
			//IL_022f: Expected O, but got I
			//IL_023d: Expected I, but got O
			//IL_02ac: Expected O, but got I
			//IL_0336: Expected O, but got I4
			//IL_0346: Expected O, but got I4
			//IL_0366: Unknown result type (might be due to invalid IL or missing references)
			//IL_036b: Expected O, but got Unknown
			//IL_0388: Unknown result type (might be due to invalid IL or missing references)
			//IL_038d: Expected O, but got Unknown
			//IL_03b7: Expected O, but got I4
			//IL_045b: Expected O, but got I4
			//IL_046b: Expected O, but got I4
			//IL_048b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0490: Expected O, but got Unknown
			//IL_04ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_04b1: Expected O, but got Unknown
			//IL_0533: Unknown result type (might be due to invalid IL or missing references)
			//IL_0538: Expected O, but got Unknown
			//IL_05ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_05b2: Expected O, but got Unknown
			GiftsShowcase giftsShowcase = <>4__this;
			if ((object)<>4__this != null)
			{
				GameObject[] slots = giftsShowcase.Slots;
				if (giftsShowcase.Slots != null)
				{
					<>4__this.ShakySlide(slots[0], slots[1], null);
					object obj = <>4__this;
					if ((object)<>4__this != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X20_v4 (System.Object)+28]");
						object obj2 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X20_v4 (System.Object)+28]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X8_v6+18]");
							bool flag = (nint)0 < (nint)1;
							object obj3 = !flag;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X8_v6+18]");
							object obj4 = -1;
							bool flag2 = obj4 == null;
							object obj5 = ~obj3;
							object obj6 = obj5 | flag2;
							if (obj6 != null)
							{
								goto IL_05ff;
							}
							object obj7 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
							object obj8 = (nint)0 + (nint)3432;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
							TweenCallback tweenCallback = default(TweenCallback);
							tweenCallback..ctor(<>4__this, (IntPtr)obj8);
							GiftsShowcase giftsShowcase2 = <>4__this;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X8_v6+28]");
							nint num = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X8_v6+30]");
							giftsShowcase2.ShakySlide((GameObject)num, (GameObject)0, tweenCallback);
							GiftsShowcase giftsShowcase3 = <>4__this;
							if ((object)<>4__this != null)
							{
								object obj9 = this + 32;
								Func<object, bool> predicate = (Func<object, bool>)obj9;
								bool flag3 = obj9 == null;
								object obj10 = !flag3;
								TweenCallback tweenCallback2 = tweenCallback;
								if (obj10 == null)
								{
									object obj11 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 408;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
									object obj12 = (nint)0 + (nint)2392;
									Func<object, bool> func = default(Func<object, bool>);
									func..ctor((object)this, (IntPtr)obj12);
									<>9__3 = func;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
									predicate = func;
									tweenCallback2 = null;
								}
								object item = Enumerable.FirstOrDefault(giftsShowcase3.activeGifts, predicate);
								if (giftsShowcase3.activeGifts != null)
								{
									object obj13 = (nint)0 + (nint)2384;
									bool flag4 = ((List<object>)(object)giftsShowcase3.activeGifts).Remove(item);
									GiftsShowcase giftsShowcase4 = <>4__this;
									if ((object)<>4__this != null)
									{
										GameObject[] slots2 = giftsShowcase4.Slots;
										if (giftsShowcase4.Slots != null)
										{
											bool flag5 = slots2.Length < 2;
											object obj14 = !flag5;
											object obj15 = slots2.Length - 2;
											bool flag6 = obj15 == null;
											object obj16 = ~obj14;
											object obj17 = obj16 | flag6;
											if (obj17 != null)
											{
												goto IL_05ff;
											}
											object obj18 = typeof(MemberAchievementClanFeedData) + 2976;
											object obj19 = obj18;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X0_v15+E4]");
											bool flag7 = (nint)0 == 0;
											object obj20 = !flag7;
											if (obj20 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											}
											UnityEngine.Object.Destroy(slots2[2]);
											GiftsShowcase giftsShowcase5 = <>4__this;
											if ((object)<>4__this != null)
											{
												GameObject[] slots3 = giftsShowcase5.Slots;
												if (giftsShowcase5.Slots != null)
												{
													bool flag8 = slots3.Length < 1;
													object obj21 = !flag8;
													object obj22 = slots3.Length - 1;
													bool flag9 = obj22 == null;
													object obj23 = ~obj21;
													object obj24 = obj23 | flag9;
													if (obj24 != null)
													{
														goto IL_05ff;
													}
													object obj25 = giftsShowcase5.Slots + 48;
													obj25 = slots3[1];
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
													GiftsShowcase giftsShowcase6 = <>4__this;
													if ((object)<>4__this != null)
													{
														GameObject[] slots4 = giftsShowcase6.Slots;
														if (giftsShowcase6.Slots != null)
														{
															object obj26 = giftsShowcase6.Slots + 40;
															obj26 = slots4[0];
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
															GiftsShowcase giftsShowcase7 = <>4__this;
															if ((object)<>4__this != null && giftsShowcase7.Slots != null)
															{
																object obj27 = giftsShowcase7.Slots + 32;
																obj27 = newGift;
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																if ((object)<>4__this != null)
																{
																	<>4__this.ArrangeHierarchy();
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
						}
					}
				}
			}
			NullReferenceException ex = new NullReferenceException();
			goto IL_05ff;
			IL_05ff:
			throw new IndexOutOfRangeException();
		}

		internal bool <ShiftGifts>b__3(GiftQueueItem g)
		{
			//IL_0154: Expected I4, but got O
			//IL_0091: Expected O, but got I4
			//IL_00a1: Expected O, but got I4
			//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c6: Expected O, but got Unknown
			//IL_0124: Expected O, but got I4
			if (g != null)
			{
				GiftsShowcase giftsShowcase = <>4__this;
				if ((object)<>4__this != null)
				{
					GameObject[] slots = giftsShowcase.Slots;
					if (giftsShowcase.Slots != null)
					{
						bool flag = slots.Length < 2;
						object obj = !flag;
						object obj2 = slots.Length - 2;
						bool flag2 = obj2 == null;
						object obj3 = ~obj;
						object obj4 = obj3 | flag2;
						if (obj4 != null)
						{
							goto IL_0146;
						}
						if ((object)slots[2] != null)
						{
							int instanceID = slots[2].GetInstanceID();
							object obj5 = g.<InstanceID>k__BackingField - instanceID;
							return obj5 == null;
						}
					}
				}
			}
			NullReferenceException ex = new NullReferenceException();
			goto IL_0146;
			IL_0146:
			IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
			return (byte)(int)ex2 != 0;
		}
	}

	private sealed class <>c__DisplayClass24_1
	{
		public Vector3 temp;

		public <>c__DisplayClass24_0 CS$<>8__locals1;

		internal void <ShiftGifts>g__OnFinish|1()
		{
			//IL_007f: Expected O, but got I4
			//IL_008f: Expected O, but got I4
			//IL_00af: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b4: Expected O, but got Unknown
			//IL_012b: Expected O, but got I4
			//IL_018f: Expected O, but got I
			//IL_022f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0234: Expected O, but got Unknown
			//IL_025e: Expected O, but got I4
			//IL_02da: Unknown result type (might be due to invalid IL or missing references)
			//IL_02df: Expected O, but got Unknown
			<>c__DisplayClass24_0 cS$<>8__locals = CS$<>8__locals1;
			if (CS$<>8__locals1 != null)
			{
				GiftsShowcase <>4__this = cS$<>8__locals.<>4__this;
				if ((object)cS$<>8__locals.<>4__this != null)
				{
					GameObject[] slots = <>4__this.Slots;
					if (<>4__this.Slots != null)
					{
						bool flag = slots.Length < 2;
						object obj = !flag;
						object obj2 = slots.Length - 2;
						bool flag2 = obj2 == null;
						object obj3 = ~obj;
						object obj4 = obj3 | flag2;
						if (obj4 != null)
						{
							goto IL_03b7;
						}
						if ((object)slots[2] != null)
						{
							Transform transform = slots[2].transform;
							if ((object)transform != null)
							{
								transform.localPosition = (Vector3)0;
								<>c__DisplayClass24_0 cS$<>8__locals2 = CS$<>8__locals1;
								if (CS$<>8__locals1 != null)
								{
									GiftsShowcase <>4__this2 = cS$<>8__locals2.<>4__this;
									if ((object)cS$<>8__locals2.<>4__this != null)
									{
										object obj5 = (nint)0 + (nint)3016;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9B038");
										<>c__DisplayClass24_0 cS$<>8__locals3 = CS$<>8__locals1;
										if (CS$<>8__locals1 != null)
										{
											GiftsShowcase <>4__this3 = cS$<>8__locals3.<>4__this;
											if ((object)cS$<>8__locals3.<>4__this != null)
											{
												GameObject[] slots2 = <>4__this3.Slots;
												if (<>4__this3.Slots != null)
												{
													object obj6 = typeof(MemberAchievementClanFeedData) + 2976;
													object obj7 = obj6;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X8_v13+E4]");
													bool flag3 = (nint)0 == 0;
													object obj8 = !flag3;
													if (obj8 == null)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
													}
													UnityEngine.Object.Destroy(slots2[0]);
													<>c__DisplayClass24_0 cS$<>8__locals4 = CS$<>8__locals1;
													if (CS$<>8__locals1 != null)
													{
														GiftsShowcase <>4__this4 = cS$<>8__locals4.<>4__this;
														if ((object)cS$<>8__locals4.<>4__this != null && <>4__this4.Slots != null)
														{
															object obj9 = <>4__this4.Slots + 32;
															obj9 = cS$<>8__locals4.newGift;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
															<>c__DisplayClass24_0 cS$<>8__locals5 = CS$<>8__locals1;
															if (CS$<>8__locals1 != null && (object)cS$<>8__locals5.<>4__this != null)
															{
																cS$<>8__locals5.<>4__this.ArrangeHierarchy();
																<>c__DisplayClass24_0 cS$<>8__locals6 = CS$<>8__locals1;
																if (CS$<>8__locals1 != null && (object)cS$<>8__locals6.<>4__this != null)
																{
																	cS$<>8__locals6.<>4__this.StopAnimating();
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
						}
					}
				}
			}
			NullReferenceException ex = new NullReferenceException();
			goto IL_03b7;
			IL_03b7:
			throw new IndexOutOfRangeException();
		}
	}

	private sealed class <>c__DisplayClass24_2
	{
		public Vector3 temp;

		public <>c__DisplayClass24_0 CS$<>8__locals2;

		internal void <ShiftGifts>g__OnFinish|2()
		{
			//IL_00cc: Expected O, but got I4
			//IL_0130: Expected O, but got I
			//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d5: Expected O, but got Unknown
			//IL_01ff: Expected O, but got I4
			//IL_027b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0280: Expected O, but got Unknown
			<>c__DisplayClass24_0 cS$<>8__locals = CS$<>8__locals2;
			if (CS$<>8__locals2 != null)
			{
				GiftsShowcase <>4__this = cS$<>8__locals.<>4__this;
				if ((object)cS$<>8__locals.<>4__this != null)
				{
					GameObject[] slots = <>4__this.Slots;
					if (<>4__this.Slots != null && (object)slots[1] != null)
					{
						Transform transform = slots[1].transform;
						if ((object)transform != null)
						{
							transform.localPosition = (Vector3)0;
							<>c__DisplayClass24_0 cS$<>8__locals2 = CS$<>8__locals2;
							if (CS$<>8__locals2 != null)
							{
								GiftsShowcase <>4__this2 = cS$<>8__locals2.<>4__this;
								if ((object)cS$<>8__locals2.<>4__this != null)
								{
									object obj = (nint)0 + (nint)3016;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9B038");
									<>c__DisplayClass24_0 cS$<>8__locals3 = CS$<>8__locals2;
									if (CS$<>8__locals2 != null)
									{
										GiftsShowcase <>4__this3 = cS$<>8__locals3.<>4__this;
										if ((object)cS$<>8__locals3.<>4__this != null)
										{
											GameObject[] slots2 = <>4__this3.Slots;
											if (<>4__this3.Slots != null)
											{
												object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
												object obj3 = obj2;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X8_v13+E4]");
												bool flag = (nint)0 == 0;
												object obj4 = !flag;
												if (obj4 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												}
												UnityEngine.Object.Destroy(slots2[0]);
												<>c__DisplayClass24_0 cS$<>8__locals4 = CS$<>8__locals2;
												if (CS$<>8__locals2 != null)
												{
													GiftsShowcase <>4__this4 = cS$<>8__locals4.<>4__this;
													if ((object)cS$<>8__locals4.<>4__this != null && <>4__this4.Slots != null)
													{
														object obj5 = <>4__this4.Slots + 32;
														obj5 = cS$<>8__locals4.newGift;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
														<>c__DisplayClass24_0 cS$<>8__locals5 = CS$<>8__locals2;
														if (CS$<>8__locals2 != null && (object)cS$<>8__locals5.<>4__this != null)
														{
															cS$<>8__locals5.<>4__this.ArrangeHierarchy();
															<>c__DisplayClass24_0 cS$<>8__locals6 = CS$<>8__locals2;
															if (CS$<>8__locals2 != null && (object)cS$<>8__locals6.<>4__this != null)
															{
																cS$<>8__locals6.<>4__this.StopAnimating();
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
					}
				}
			}
			NullReferenceException ex = new NullReferenceException();
			throw new IndexOutOfRangeException();
		}
	}

	private sealed class <>c__DisplayClass26_0
	{
		public GameObject gift;

		public GiftsShowcase <>4__this;

		public int index;

		internal bool <GiftExpired>b__0(GiftQueueItem g)
		{
			//IL_007f: Expected I4, but got O
			//IL_005d: Expected O, but got I4
			if (g != null && (object)gift != null)
			{
				int instanceID = gift.GetInstanceID();
				object obj = g.<InstanceID>k__BackingField - instanceID;
				return obj == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal void <GiftExpired>b__1()
		{
			GiftsShowcase giftsShowcase = <>4__this;
			giftsShowcase.nextSlot = index;
			giftsShowcase.animating = false;
		}
	}

	private sealed class <>c__DisplayClass32_0
	{
		public GameObject obj;

		public Vector3 targetLocation;

		public float left;

		public TweenCallback callback;

		public TweenCallback <>9__1;

		internal void <ShakySlide>b__0()
		{
			//IL_0011: Expected O, but got I
			//IL_001d: Expected O, but got I
			//IL_0056: Expected O, but got I4
			//IL_006f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0074: Expected O, but got Unknown
			//IL_0096: Expected O, but got I4
			//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b8: Expected O, but got Unknown
			//IL_00ce: Expected O, but got I
			//IL_00dc: Expected I, but got O
			object obj = (nint)0 + (nint)2904;
			object obj2 = (nint)0 + (nint)2504;
			Transform transform = this.obj.transform;
			float duration = (float)targetLocation + left;
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOLocalMove(transform, (Vector3)0, duration);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
			object obj3 = this + 48;
			TweenCallback tweenCallback = (TweenCallback)obj3;
			bool flag = obj3 == null;
			object obj4 = !flag;
			if (obj4 == null)
			{
				object obj5 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj6 = (nint)0 + (nint)2440;
				TweenCallback tweenCallback2 = default(TweenCallback);
				tweenCallback2..ctor(this, (IntPtr)obj6);
				<>9__1 = tweenCallback2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				tweenCallback = tweenCallback2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
		}

		internal void <ShakySlide>b__1()
		{
			//IL_0011: Expected O, but got I
			//IL_001d: Expected O, but got I
			//IL_0045: Expected F4, but got O
			//IL_0045: Expected O, but got I4
			object obj = (nint)0 + (nint)2904;
			object obj2 = (nint)0 + (nint)2504;
			Transform transform = this.obj.transform;
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOLocalMove(transform, (Vector3)0, (float)targetLocation);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
		}
	}

	private sealed class <>c__DisplayClass33_0
	{
		public ParticleSystem ps;

		internal void <Explode>b__0()
		{
			ps.Stop();
		}
	}

	private GameObject GiftPrefab;

	private GameObject[] Slots;

	public RectTransform GiftsContainer;

	private Vector2 GiftsContainerSize;

	private Button OpenShowcasePanel;

	private GameEventsChannel gameEventsChannel;

	private KPlayer player;

	private float animSpeed;

	private bool animating;

	private readonly List<GiftQueueItem> queue;

	private readonly List<GiftQueueItem> activeGifts;

	private KGame _game;

	private KGameVisualControls _gameVisual;

	private RectTransform _broadcastPoint;

	private int nextSlot;

	public void Setup(KPlayer kPlayer)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0438: Expected O, but got I
		//IL_043e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0443: Expected O, but got Unknown
		//IL_047f: Expected O, but got I4
		//IL_0043: Expected O, but got I
		//IL_004f: Expected O, but got I
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_006f: Expected O, but got I
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		//IL_008a: Expected O, but got I
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected O, but got Unknown
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected O, but got Unknown
		//IL_0109: Expected I, but got O
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Expected O, but got Unknown
		//IL_012e: Expected O, but got I
		//IL_0158: Expected I, but got O
		//IL_0169: Expected O, but got I
		//IL_0195: Expected I, but got O
		//IL_01e6: Expected O, but got I4
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Expected O, but got Unknown
		//IL_0241: Expected O, but got I4
		//IL_02cc: Expected O, but got I4
		//IL_026c: Expected O, but got I4
		//IL_0275: Expected O, but got I4
		//IL_036a: Unknown result type (might be due to invalid IL or missing references)
		//IL_036f: Expected O, but got Unknown
		//IL_0399: Expected O, but got I4
		//IL_03c2: Expected O, but got I
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = (nint)0 + (nint)88;
		object obj3 = this + 80;
		KPlayer kPlayer2 = default(KPlayer);
		obj3 = kPlayer2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		object obj6 = (nint)0 + (nint)136;
		object obj7 = (nint)0 + (nint)144;
		object obj8 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2136;
		object obj9 = (nint)0 + (nint)3408;
		object obj10 = this + 128;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v8+40]");
		obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		object obj11 = this + 112;
		object obj12 = default(object);
		obj11 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		object obj13 = this + 120;
		object obj14 = default(object);
		obj13 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj9);
		object obj15 = typeof(SqlSingle[]) + 2376;
		object obj16 = (nint)0 + (nint)3400;
		((KGame)obj11).OnGiftSent += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj16);
		object obj17 = (nint)0 + (nint)3416;
		_game.OnGameInitialized += action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action3 = default(Action);
		action3..ctor(this, (IntPtr)obj17);
		player.OnUserChanged += action3;
		GiftPrefab.SetActive(value: false);
		bool flag2 = GiftsContainer;
		bool flag3 = !flag2;
		Vector2 vector = (Vector2)0;
		if (!flag3)
		{
			Rect rect = GiftsContainer.rect;
			object obj18 = typeof(System.Buffers.Text.ParserHelpers) + 3512;
			object obj19 = obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v350 @ X0_v58+E4]");
			bool flag4 = (nint)0 == 0;
			object obj20 = !flag4;
			if (obj20 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Vector2 giftsContainerSize = default(Vector2);
			GiftsContainerSize = giftsContainerSize;
			RectTransform rectTransform = UIExtensions.rectTransform(GiftsContainer);
			rectTransform.sizeDelta = (Vector2)0;
			vector = (Vector2)0;
		}
		object obj21 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X8_v6+E4]");
		if ((nint)0 != 0)
		{
			bool flag5 = OpenShowcasePanel;
			bool flag6 = !flag5;
			object obj22 = !flag6;
			if (obj22 == null)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			if (!OpenShowcasePanel)
			{
				return;
			}
		}
		Room room = ((KGame)obj11).Room;
		GameType gameType = SFSKammelnaRoomExtensions.GetGameType(room);
		if (GameTypeExtensions.IsTournament(gameType))
		{
			object obj23 = typeof(Queue<string>) + 872;
			object obj24 = obj23;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ X0_v43+E4]");
			bool flag7 = (nint)0 == 0;
			object obj25 = !flag7;
			if (obj25 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj26 = (nint)0 + (nint)2248;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			TournamentMatchInfo tournamentMatchInfo = default(TournamentMatchInfo);
			TournamentData tournament = tournamentMatchInfo.Tournament;
			if (tournament.<Type>k__BackingField == TournamentType.OfficialMonthly)
			{
				GameObject gameObject = OpenShowcasePanel.gameObject;
				gameObject.SetActive(value: false);
			}
		}
	}

	public void ShowSendGiftPanel()
	{
		gameEventsChannel.TriggerShowGiftPanel();
	}

	private void Update()
	{
		//IL_0402: Expected O, but got I4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0065: Expected O, but got I4
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected O, but got Unknown
		//IL_0161: Expected O, but got I
		//IL_0171: Expected O, but got I
		//IL_0193: Expected O, but got I4
		//IL_0204: Expected O, but got I
		//IL_00fa: Expected O, but got I
		//IL_010a: Expected O, but got I
		//IL_012c: Expected O, but got I4
		//IL_01c3: Expected O, but got I4
		//IL_025a: Expected O, but got I4
		//IL_041f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0424: Expected O, but got Unknown
		//IL_043a: Expected O, but got I
		//IL_044b: Expected I, but got O
		//IL_0469: Expected O, but got I
		//IL_0484: Expected O, but got I4
		//IL_04a1: Expected O, but got I
		//IL_04b1: Expected O, but got I
		//IL_04d3: Expected O, but got I4
		//IL_01f3: Expected O, but got I
		//IL_03cb: Expected I8, but got I
		//IL_03cb: Expected O, but got I
		//IL_02a1: Expected O, but got I4
		//IL_04f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f5: Expected O, but got Unknown
		//IL_050b: Expected O, but got I
		//IL_051c: Expected I, but got O
		//IL_053a: Expected O, but got I
		//IL_0555: Expected O, but got I4
		//IL_02d1: Expected O, but got I
		bool flag = !animating;
		object obj = !flag;
		if (obj != null)
		{
			return;
		}
		object obj2 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+E4]");
		if ((nint)0 != 0)
		{
			bool isLoaded = Store.IsLoaded;
			bool flag2 = !isLoaded;
			object obj4 = !flag2;
			if (obj4 == null)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			if (!Store.IsLoaded)
			{
				return;
			}
		}
		object obj5 = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 384;
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X0_v43+E4]");
		object obj7;
		Func<object, bool> predicate;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X0_v43+B8]");
			obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X8_v39+8]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X8_v39+8]");
			bool flag3 = (nint)0 == 0;
			object obj8 = !flag3;
			if (obj8 == null)
			{
				goto IL_01a1;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X0_v43+B8]");
			obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X8_v39+8]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X8_v39+8]");
			bool flag4 = (nint)0 == 0;
			object obj9 = !flag4;
			if (obj9 == null)
			{
				goto IL_01a1;
			}
		}
		goto IL_01f8;
		IL_01f8:
		object obj10 = (nint)0 + (nint)2920;
		object obj21;
		if (Enumerable.Any(activeGifts, predicate))
		{
			object obj11 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X0_v19+E4]");
			bool flag5 = (nint)0 == 0;
			object obj12 = !flag5;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj11 = obj5;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X0_v19+B8]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X8_v30+10]");
			Func<object, bool> predicate2 = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X8_v30+10]");
			bool flag6 = (nint)0 == 0;
			object obj14 = !flag6;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X0_v19+E4]");
				bool flag7 = (nint)0 == 0;
				object obj15 = !flag7;
				if (obj15 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj16 = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ X8_v36+B8]");
					obj13 = 0;
				}
				object obj17 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 408;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj18 = (nint)0 + (nint)2328;
				Func<object, bool> func = default(Func<object, bool>);
				func..ctor(obj13, (IntPtr)obj18);
				object obj19 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X8_v35+B8]");
				object obj20 = (nint)0 + (nint)16;
				obj20 = func;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				obj21 = 0;
				predicate2 = func;
			}
			object item = Enumerable.First(activeGifts, predicate2);
			bool flag8 = ((List<object>)(object)activeGifts).Remove(item);
			Func<GameObject, bool> predicate3 = <Update>g__MatchQueueItem|17_1((GiftQueueItem)item);
			object gift = Enumerable.First(Slots, (Func<object, bool>)predicate3);
			Func<GameObject, bool> predicate4 = <Update>g__MatchQueueItem|17_1((GiftQueueItem)item);
			int index = ArraysExtensions.FindIndex(Slots, (Func<object, bool>)predicate4);
			GiftExpired((GameObject)gift, index);
		}
		else if (Enumerable.Any((IEnumerable<object>)queue))
		{
			object item2 = Enumerable.First((IEnumerable<object>)queue);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X0_v14 (System.Object)+10]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X0_v14 (System.Object)+28]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X0_v14 (System.Object)+18]");
			AddGift((int)num, (Transform)num2, 0L);
			bool flag9 = ((List<object>)(object)queue).Remove(item2);
		}
		return;
		IL_01a1:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X0_v43+E4]");
		bool flag10 = (nint)0 == 0;
		object obj22 = !flag10;
		if (obj22 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj23 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X8_v45+B8]");
			obj7 = 0;
		}
		object obj24 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 408;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj25 = (nint)0 + (nint)2320;
		Func<object, bool> func2 = default(Func<object, bool>);
		func2..ctor(obj7, (IntPtr)obj25);
		object obj26 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X8_v44+B8]");
		object obj27 = (nint)0 + (nint)8;
		obj27 = func2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj21 = 0;
		predicate = func2;
		goto IL_01f8;
	}

	private void OnGiftReceived(GiftNotification gift)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_00d7: Expected O, but got I4
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected O, but got Unknown
		//IL_015a: Expected O, but got I
		//IL_016b: Expected I, but got O
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Expected O, but got Unknown
		//IL_01ae: Expected O, but got I4
		//IL_0108: Expected O, but got I
		//IL_0122: Expected O, but got I4
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Expected O, but got Unknown
		//IL_021f: Expected I, but got O
		//IL_022f: Expected O, but got I
		//IL_02be: Expected O, but got I4
		//IL_04e5: Expected O, but got I
		//IL_0502: Expected O, but got I
		//IL_026a: Expected O, but got I
		//IL_02cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d0: Expected O, but got Unknown
		//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02de: Expected O, but got Unknown
		//IL_02e7: Expected O, but got I4
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Expected O, but got Unknown
		//IL_0286: Unknown result type (might be due to invalid IL or missing references)
		//IL_028b: Expected O, but got Unknown
		//IL_042c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0431: Expected O, but got Unknown
		//IL_0447: Expected O, but got I
		//IL_0541: Unknown result type (might be due to invalid IL or missing references)
		//IL_0546: Expected O, but got Unknown
		//IL_034a: Unknown result type (might be due to invalid IL or missing references)
		//IL_034f: Expected O, but got Unknown
		//IL_0365: Expected O, but got I
		//IL_037f: Expected O, but got I4
		//IL_0388: Expected O, but got I4
		//IL_0391: Expected I8, but got I4
		//IL_03aa: Expected O, but got I4
		//IL_03b3: Expected I8, but got I4
		object obj = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 400;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = obj2 + 24;
		obj4 = gift;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		if (!player.IsHuman)
		{
			return;
		}
		object obj5 = obj4;
		KGame game = _game;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X8_v5+18]");
		KPlayer playerBySFSId = game.GetPlayerBySFSId(0);
		bool adCampaign = ((GiftNotification)obj4).AdCampaign;
		bool flag = !adCampaign;
		object obj6 = !flag;
		object obj15;
		if (obj6 == null)
		{
			object obj7 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X8_v14+18]");
			object obj8 = (nint)0 + (nint)1;
			bool flag2 = obj8 == null;
			object obj9 = !flag2;
			if (obj9 != null)
			{
				KPlayer kPlayer = player;
				User <User>k__BackingField = kPlayer.<User>k__BackingField;
				object obj10 = typeof(UsageHint) + 8;
				nint num = (nint)<User>k__BackingField;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X8_v17 (Il2CppClass<Sfs2X.Entities.User>)+12E]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X8_v17 (Il2CppClass<Sfs2X.Entities.User>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_02ab;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X8_v17 (Il2CppClass<Sfs2X.Entities.User>)+B0]");
				object obj12 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X10_v7-8]");
					if (0 == (nint)obj10)
					{
						break;
					}
					obj12 += 16;
					obj11--;
					if ((nint)obj11 != 1)
					{
						continue;
					}
					goto IL_02ab;
				}
				object obj13 = num + obj12;
				object obj14 = obj13 + 312;
				obj15 = 0;
				goto IL_04cf;
			}
		}
		object obj16 = typeof(SqlSingle[]) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj17 = (nint)0 + (nint)2344;
		Action action = default(Action);
		action..ctor(obj2, (IntPtr)obj17);
		object obj18 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		object obj19 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X0_v20+E4]");
		bool flag3 = (nint)0 == 0;
		object obj20 = !flag3;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Coroutine coroutine = CoroutineDummy.WaitForSeconds(1f, action);
		return;
		IL_051f:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj21 = default(object);
		obj21..ctor();
		_ = 0;
		object obj22 = obj21 + 40;
		Transform transform;
		obj22 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X8_v22+10]");
		_ = 0;
		_ = -1;
		QueueGift((GiftQueueItem)obj21);
		return;
		IL_03c9:
		_ = 1;
		object obj24;
		object obj23 = obj24;
		object obj26;
		object obj25 = obj26;
		long num3;
		long num2 = num3;
		Transform transform2;
		transform = transform2;
		goto IL_051f;
		IL_02ab:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		obj15 = 0;
		goto IL_04cf;
		IL_04cf:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v339 @ X0_v25] (should have been resolved before IL gen)");
		object obj27 = (nint)0 + (nint)3240;
		obj26 = obj27;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X8_v14+20]");
		long num4 = default(long);
		if (!Enumerable.Contains((IEnumerable<long>)0, num4))
		{
			return;
		}
		object obj28 = obj4;
		if (playerBySFSId != null)
		{
			Userbox activeUserbox = _gameVisual.GetActiveUserbox(playerBySFSId);
			Transform transform3 = activeUserbox.transform;
			obj24 = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 464;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E66F8]");
			object obj29 = (nint)0 & (nint)1;
			bool flag4 = obj29 == null;
			object obj30 = !flag4;
			obj26 = 0;
			num3 = 0L;
			transform2 = transform3;
			obj23 = obj24;
			obj25 = 0;
			num2 = 0L;
			transform = transform3;
			if (obj30 == null)
			{
				goto IL_03c9;
			}
		}
		else
		{
			transform2 = _broadcastPoint;
			obj24 = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 464;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E66F8]");
			object obj31 = (nint)0 & (nint)1;
			bool flag5 = obj31 == null;
			num3 = num4;
			if (flag5)
			{
				goto IL_03c9;
			}
			obj23 = obj24;
			obj25 = obj27;
			num2 = num4;
			transform = _broadcastPoint;
		}
		goto IL_051f;
	}

	private void OnUserChanged()
	{
		LoadPlayersGifts();
	}

	private void OnGameInitialized()
	{
		LoadPlayersGifts();
	}

	private void QueueGift(int giftId, Transform startPosition = null, long expiration = -1L)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		object obj = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 464;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		_ = 0;
		object obj3 = obj2 + 40;
		obj3 = startPosition;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		QueueGift((GiftQueueItem)obj2);
	}

	private void QueueGift(GiftQueueItem giftQueueItem)
	{
		//IL_0059: Expected O, but got I4
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected O, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected O, but got Unknown
		ShowContainer();
		List<object> list = (List<object>)(object)queue;
		int version = list._version + 1;
		list._version = version;
		object[] items = list._items;
		bool flag = list._size < items.Length;
		object obj = !flag;
		if (obj == null)
		{
			int size = list._size + 1;
			list._size = size;
			object obj2 = items + list._size;
			object obj3 = obj2 + 32;
			obj3 = giftQueueItem;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		else
		{
			list.AddWithResize((object)giftQueueItem);
		}
	}

	private void AddGift(int giftId, Transform startPosition = null, long expiration = -1L)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_007e: Expected O, but got I8
		//IL_0098: Expected O, but got I4
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00e5: Expected O, but got I4
		//IL_0238: Expected O, but got I4
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected O, but got Unknown
		//IL_0149: Expected O, but got I4
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Expected O, but got Unknown
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Expected O, but got Unknown
		//IL_0275: Expected O, but got I
		//IL_01aa: Expected F8, but got I8
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Expected O, but got Unknown
		//IL_01fe: Expected O, but got I4
		//IL_02d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02da: Expected O, but got Unknown
		//IL_034b: Expected O, but got I
		//IL_03c3: Expected O, but got I
		//IL_03f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f8: Expected O, but got Unknown
		//IL_0404: Expected O, but got I
		//IL_0463: Expected O, but got I4
		//IL_0493: Unknown result type (might be due to invalid IL or missing references)
		//IL_0498: Expected O, but got Unknown
		//IL_04d8: Expected O, but got I
		//IL_04e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ec: Expected O, but got Unknown
		//IL_04f8: Expected O, but got I
		//IL_0522: Expected I, but got O
		object obj = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 408;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (obj2 != null)
		{
			object obj3 = obj2 + 24;
			obj3 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj4 = obj2 + 64;
			obj4 = startPosition;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			animating = true;
			object obj5 = expiration + 1;
			bool flag = obj5 == null;
			object obj6 = !flag;
			StoreItem storeItem = default(StoreItem);
			if (obj6 == null)
			{
				object obj7 = typeof(DataRelation) + 712;
				object obj8 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X0_v42+E4]");
				bool flag2 = (nint)0 == 0;
				object obj9 = !flag2;
				if (obj9 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				DateTime now = DateTime.Now;
				object obj10 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
				object obj11 = obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X0_v46+E4]");
				bool flag3 = (nint)0 == 0;
				object obj12 = !flag3;
				if (obj12 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3 (System.Object)+48]");
				storeItem = Store.GetStoreItem(0);
				if (storeItem == null)
				{
					goto IL_054b;
				}
				DateTime dateTime2 = default(DateTime);
				DateTime dateTime = dateTime2.AddSeconds(storeItem.<duration>k__BackingField);
				DateTime date = dateTime2.ToUniversalTime();
				object obj13 = typeof(DataRelation) + 824;
				object obj14 = obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X8_v24+E4]");
				bool flag4 = (nint)0 == 0;
				object obj15 = !flag4;
				if (obj15 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				long num = DateTimeUtil.ToTimestamp(date);
			}
			ShowContainer();
			GameObject[] slots = Slots;
			if (Slots != null)
			{
				bool flag5 = nextSlot < slots.Length;
				object obj16 = !flag5;
				if (obj16 != null)
				{
					goto IL_0559;
				}
				object obj17 = Slots + nextSlot;
				object obj18 = obj2 + 56;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X8_v9+20]");
				obj18 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				if (obj18 != null)
				{
					Transform transform = ((GameObject)obj18).transform;
					if ((object)transform != null)
					{
						object obj19 = typeof(System.Buffers.Text.ParserHelpers) + 3600;
						if (transform != obj19)
						{
							goto IL_0567;
						}
						Vector2 sizeDelta = ((RectTransform)transform).sizeDelta;
						_ = storeItem.<duration>k__BackingField;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3 (System.Object)+38]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3 (System.Object)+38]");
							Transform transform2 = ((GameObject)0).transform;
							if ((object)transform2 != null)
							{
								Vector3 localScale = transform2.localScale;
								_ = storeItem.<duration>k__BackingField;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3 (System.Object)+38]");
								if ((nint)0 != 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3 (System.Object)+38]");
									Transform transform3 = ((GameObject)0).transform;
									if ((object)transform3 != null)
									{
										object obj20 = typeof(MemberAchievementClanFeedData) + 2976;
										object obj21 = (nint)0 + (nint)920;
										Quaternion rotation = transform3.rotation;
										_ = storeItem.<duration>k__BackingField;
										Transform transform4 = base.transform;
										object obj22 = obj20;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X0_v30+E4]");
										bool flag6 = (nint)0 == 0;
										object obj23 = !flag6;
										if (obj23 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9DE4");
										object obj24 = obj2 + 16;
										object obj25 = default(object);
										obj24 = obj25;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
										if (obj24 != null)
										{
											object obj26 = (nint)0 + (nint)1312;
											object obj27 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
											object obj28 = (nint)0 + (nint)2352;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E32EDC");
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
											Action<bool> action = default(Action<bool>);
											action..ctor(obj2, (IntPtr)obj28);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3 (System.Object)+48]");
											Image img = default(Image);
											UIExtensions.LoadItemImage(img, 0, ImageCacher.ItemImageType.InGame, FilterMode.Bilinear, action);
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
		goto IL_054b;
		IL_0567:
		throw new InvalidCastException();
		IL_0559:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		goto IL_0567;
		IL_054b:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_0559;
	}

	private void ShiftGifts(GameObject newGift, bool animate = true)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_05ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b1: Expected O, but got Unknown
		//IL_05ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f4: Expected O, but got Unknown
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Expected O, but got Unknown
		//IL_038e: Expected O, but got I4
		//IL_039e: Expected O, but got I4
		//IL_03be: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c3: Expected O, but got Unknown
		//IL_03e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e5: Expected O, but got Unknown
		//IL_03fb: Expected O, but got I
		//IL_040c: Expected I, but got O
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected O, but got Unknown
		//IL_06a4: Expected O, but got F4
		//IL_0519: Expected O, but got I4
		//IL_0839: Expected O, but got I4
		//IL_0842: Expected O, but got I4
		//IL_052e: Expected O, but got I
		//IL_0547: Unknown result type (might be due to invalid IL or missing references)
		//IL_054c: Expected O, but got Unknown
		//IL_0723: Unknown result type (might be due to invalid IL or missing references)
		//IL_0728: Expected O, but got Unknown
		//IL_073e: Expected O, but got I
		//IL_0567: Expected O, but got I
		//IL_0575: Expected I, but got O
		//IL_0581: Expected O, but got I
		//IL_01f4: Expected O, but got F4
		//IL_0bf3: Expected I, but got O
		//IL_087f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0884: Expected O, but got Unknown
		//IL_08ae: Expected O, but got I4
		//IL_025c: Expected O, but got I4
		//IL_026c: Expected O, but got I4
		//IL_028c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Expected O, but got Unknown
		//IL_08d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_08db: Expected O, but got Unknown
		//IL_02d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d7: Expected O, but got Unknown
		//IL_02ed: Expected O, but got I
		//IL_0990: Expected O, but got I4
		//IL_09a0: Expected O, but got I4
		//IL_09c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c5: Expected O, but got Unknown
		//IL_0b8e: Expected O, but got I4
		//IL_0a66: Expected O, but got I4
		object obj = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 416;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		<>c__DisplayClass24_0 <>c__DisplayClass24_ = default(<>c__DisplayClass24_0);
		<>c__DisplayClass24_..ctor();
		object obj3;
		GameObject obj10;
		GameObject target;
		object obj12;
		TweenCallback callback;
		TweenCallback tweenCallback = default(TweenCallback);
		<>c__DisplayClass24_2 <>c__DisplayClass24_3;
		if (<>c__DisplayClass24_ != null)
		{
			object obj2 = <>c__DisplayClass24_ + 16;
			obj2 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj3 = <>c__DisplayClass24_ + 24;
			obj3 = newGift;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			List<GiftQueueItem> list = activeGifts;
			if (activeGifts != null)
			{
				float num = default(float);
				bool flag = default(bool);
				if (list._size <= 2)
				{
					if (list._size != 1)
					{
						if (list._size != 2)
						{
							return;
						}
						object obj4 = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 424;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						<>c__DisplayClass24_1 <>c__DisplayClass24_2 = default(<>c__DisplayClass24_1);
						<>c__DisplayClass24_2..ctor();
						if (<>c__DisplayClass24_2 != null)
						{
							object obj5 = <>c__DisplayClass24_2 + 32;
							obj5 = <>c__DisplayClass24_;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							GameObject[] slots = Slots;
							if (Slots != null && (object)slots[1] != null)
							{
								Transform transform = slots[1].transform;
								if ((object)transform != null)
								{
									Vector3 localPosition = transform.localPosition;
									<>c__DisplayClass24_2.temp = (Vector3)num;
									GameObject[] slots2 = Slots;
									if (flag)
									{
										if (Slots != null)
										{
											bool flag2 = slots2.Length < 1;
											object obj6 = !flag2;
											object obj7 = slots2.Length - 1;
											bool flag3 = obj7 == null;
											object obj8 = ~obj6;
											object obj9 = obj8 | flag3;
											if (obj9 != null)
											{
												goto IL_0bab;
											}
											obj10 = slots2[1];
											target = slots2[2];
											object obj11 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
											obj12 = (nint)0 + (nint)2400;
											callback = tweenCallback;
											<>c__DisplayClass24_3 = (<>c__DisplayClass24_2)(object)<>c__DisplayClass24_2;
											goto IL_0be2;
										}
									}
									else if (Slots != null && (object)slots2[1] != null)
									{
										Transform transform2 = slots2[1].transform;
										GameObject[] slots3 = Slots;
										if (Slots != null)
										{
											bool flag4 = slots3.Length < 2;
											object obj13 = !flag4;
											object obj14 = slots3.Length - 2;
											bool flag5 = obj14 == null;
											object obj15 = ~obj13;
											object obj16 = obj15 | flag5;
											if (obj16 != null)
											{
												goto IL_0bab;
											}
											if ((object)slots3[2] != null)
											{
												Transform transform3 = slots3[2].transform;
												if ((object)transform3 != null)
												{
													Vector3 localPosition2 = transform3.localPosition;
													if ((object)transform2 != null)
													{
														transform2.localPosition = (Vector3)0;
														<>c__DisplayClass24_2.<ShiftGifts>g__OnFinish|1();
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
					else if (flag)
					{
						if (obj3 != null)
						{
							Transform target2 = ((GameObject)obj3).transform;
							GameObject[] slots4 = Slots;
							if (Slots != null && (object)slots4[1] != null)
							{
								Transform transform4 = slots4[1].transform;
								if ((object)transform4 != null)
								{
									Vector3 localPosition3 = transform4.localPosition;
									TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOLocalMove(target2, (Vector3)0, num);
									object obj17 = (nint)0 + (nint)2904;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
									object obj18 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
									object obj19 = (nint)0 + (nint)3432;
									TweenCallback tweenCallback2 = default(TweenCallback);
									tweenCallback2..ctor(this, (IntPtr)obj19);
									object obj20 = (nint)0 + (nint)2504;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
									Vector3 vector = (Vector3)tweenCallback2;
									goto IL_0847;
								}
							}
						}
					}
					else if (obj3 != null)
					{
						Transform transform5 = ((GameObject)obj3).transform;
						GameObject[] slots5 = Slots;
						if (Slots != null && (object)slots5[1] != null)
						{
							Transform transform6 = slots5[1].transform;
							if ((object)transform6 != null)
							{
								Vector3 localScale = transform6.localScale;
								if ((object)transform5 != null)
								{
									transform5.localPosition = (Vector3)0;
									Vector3 vector = (Vector3)0;
									goto IL_0847;
								}
							}
						}
					}
				}
				else if (list._size != 3)
				{
					if (list._size != 4)
					{
						return;
					}
					GameObject[] slots6 = Slots;
					if (Slots != null)
					{
						bool flag6 = slots6.Length < 2;
						object obj21 = !flag6;
						object obj22 = slots6.Length - 2;
						bool flag7 = obj22 == null;
						object obj23 = ~obj21;
						object obj24 = obj23 | flag7;
						if (obj24 == null)
						{
							object obj25 = typeof(SqlSingle[]) + 2376;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
							object obj26 = (nint)0 + (nint)2384;
							Action action = default(Action);
							action..ctor(<>c__DisplayClass24_, (IntPtr)obj26);
							((GiftsShowcase)(object)action).Explode(slots6[2], action);
							return;
						}
						goto IL_0bab;
					}
				}
				else
				{
					object obj27 = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 432;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					<>c__DisplayClass24_2 <>c__DisplayClass24_4 = default(<>c__DisplayClass24_2);
					<>c__DisplayClass24_4..ctor();
					if (<>c__DisplayClass24_4 != null)
					{
						object obj28 = <>c__DisplayClass24_4 + 32;
						obj28 = <>c__DisplayClass24_;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						GameObject[] slots7 = Slots;
						if (Slots != null && (object)slots7[0] != null)
						{
							Transform transform7 = slots7[0].transform;
							if ((object)transform7 != null)
							{
								Vector3 localPosition4 = transform7.localPosition;
								<>c__DisplayClass24_4.temp = (Vector3)num;
								GameObject[] slots8 = Slots;
								if (flag)
								{
									if (Slots != null)
									{
										obj10 = slots8[0];
										target = slots8[1];
										object obj29 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
										obj12 = (nint)0 + (nint)2408;
										callback = tweenCallback;
										<>c__DisplayClass24_3 = <>c__DisplayClass24_4;
										goto IL_0be2;
									}
								}
								else if (Slots != null && (object)slots8[0] != null)
								{
									Transform transform8 = slots8[0].transform;
									GameObject[] slots9 = Slots;
									if (Slots != null && (object)slots9[1] != null)
									{
										Transform transform9 = slots9[1].transform;
										if ((object)transform9 != null)
										{
											Vector3 localPosition5 = transform9.localPosition;
											if ((object)transform8 != null)
											{
												transform8.localPosition = (Vector3)0;
												<>c__DisplayClass24_4.<ShiftGifts>g__OnFinish|2();
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
		goto IL_0b9d;
		IL_0be2:
		tweenCallback..ctor(<>c__DisplayClass24_3, (IntPtr)obj12);
		((GiftsShowcase)(object)tweenCallback).ShakySlide(obj10, target, callback, reverse: false);
		return;
		IL_0847:
		GameObject[] slots10 = Slots;
		if (Slots != null)
		{
			object obj30 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj31 = obj30;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X8_v26+E4]");
			bool flag8 = (nint)0 == 0;
			object obj32 = !flag8;
			if (obj32 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			UnityEngine.Object.Destroy(slots10[1]);
			if (Slots != null)
			{
				object obj33 = Slots + 40;
				obj33 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				return;
			}
		}
		goto IL_0b9d;
		IL_0b9d:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0bab;
		IL_0bab:
		throw new IndexOutOfRangeException();
	}

	private void ArrangeHierarchy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Expected O, but got I4
		//IL_002c: Expected O, but got I4
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		//IL_0074: Expected O, but got I
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected O, but got Unknown
		//IL_00ac: Expected O, but got I4
		//IL_00cb: Expected O, but got I
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected O, but got Unknown
		//IL_0111: Expected O, but got I4
		GameObject[] slots = Slots;
		object format = "FilterFunction '{0}' expects {1} parameters but only {2} were provided. Missing parameters will be set to their default values." + 3112;
		object obj = 153100288 + 1024;
		object obj2 = 4;
		object arg = default(object);
		while (true)
		{
			object obj3 = obj2 - 4;
			if ((nint)obj3 < slots.Length)
			{
				object obj4 = obj3 + 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
				string text = string.Format((string)format, arg);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X8_v6 (UnityEngine.GameObject[])+v112 @ X22_v5*8]");
				((UnityEngine.Object)0).name = text;
				GameObject[] slots2 = Slots;
				object obj5 = obj4 - 1;
				bool flag = (nint)obj5 < slots2.Length;
				object obj6 = !flag;
				if (obj6 != null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X8_v7 (UnityEngine.GameObject[])+v112 @ X22_v5*8]");
				Transform transform = ((GameObject)0).transform;
				transform.SetAsFirstSibling();
				slots = Slots;
				obj2++;
				bool flag2 = Slots == null;
				object obj7 = !flag2;
				if (obj7 == null)
				{
					throw new NullReferenceException();
				}
				continue;
			}
			return;
		}
		throw new IndexOutOfRangeException();
	}

	private void GiftExpired(GameObject gift, int index)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_00a4: Expected I, but got O
		//IL_00cd: Expected O, but got I
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		//IL_00ed: Expected O, but got I
		//IL_012b: Expected I, but got O
		object obj = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 440;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		<>c__DisplayClass26_0 <>c__DisplayClass26_ = default(<>c__DisplayClass26_0);
		<>c__DisplayClass26_..ctor();
		object obj2 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 408;
		object obj3 = (nint)0 + (nint)2416;
		object obj4 = <>c__DisplayClass26_ + 16;
		obj4 = gift;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = <>c__DisplayClass26_ + 24;
		obj5 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		<>c__DisplayClass26_.index = index;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<object, bool> func = default(Func<object, bool>);
		func..ctor((object)<>c__DisplayClass26_, (IntPtr)obj3);
		object item = Enumerable.FirstOrDefault(activeGifts, func);
		object obj6 = (nint)0 + (nint)2384;
		object obj7 = typeof(SqlSingle[]) + 2376;
		object obj8 = (nint)0 + (nint)2424;
		bool flag = ((List<object>)(object)activeGifts).Remove(item);
		animating = true;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(<>c__DisplayClass26_, (IntPtr)obj8);
		((GiftsShowcase)(object)action).Explode(<>c__DisplayClass26_.gift, action);
	}

	private void LoadPlayersGifts()
	{
		//IL_007b: Expected O, but got I4
		//IL_0105: Expected O, but got I4
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Expected O, but got Unknown
		//IL_022f: Expected O, but got I
		//IL_023f: Expected O, but got I
		//IL_0261: Expected O, but got I4
		//IL_0271: Expected O, but got I
		//IL_04e0: Expected O, but got I
		//IL_01b0: Expected O, but got I
		//IL_01c0: Expected O, but got I
		//IL_01e2: Expected O, but got I4
		//IL_038a: Expected O, but got I
		//IL_039a: Expected O, but got I
		//IL_03bc: Expected O, but got I4
		//IL_03dc: Expected O, but got I
		//IL_02a9: Expected O, but got I4
		//IL_05ac: Expected O, but got I
		//IL_05ca: Expected O, but got I
		//IL_0303: Expected O, but got I
		//IL_0313: Expected O, but got I
		//IL_0335: Expected O, but got I4
		//IL_052d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0532: Expected O, but got Unknown
		//IL_0548: Expected O, but got I
		//IL_0559: Expected I, but got O
		//IL_0577: Expected O, but got I
		//IL_0208: Expected O, but got I
		//IL_040c: Expected O, but got I4
		//IL_02d9: Expected O, but got I
		//IL_05eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f0: Expected O, but got Unknown
		//IL_0606: Expected O, but got I
		//IL_0617: Expected I, but got O
		//IL_0635: Expected O, but got I
		//IL_0363: Expected O, but got I
		//IL_0487: Unknown result type (might be due to invalid IL or missing references)
		//IL_048c: Expected O, but got Unknown
		//IL_04a2: Expected O, but got I
		//IL_04b0: Expected I, but got O
		//IL_043c: Expected O, but got I
		List<GiftQueueItem> list = queue;
		int version = list._version + 1;
		list._size = 0;
		list._version = version;
		if (list._size >= 1)
		{
			Array.Clear(list._items, 0, list._size);
			object obj = 0;
		}
		List<GiftQueueItem> list2 = activeGifts;
		int version2 = list2._version + 1;
		list2._size = 0;
		list2._version = version2;
		if (list2._size >= 1)
		{
			Array.Clear(list2._items, 0, list2._size);
			object obj = 0;
		}
		HideContainer();
		if (!player.IsHuman)
		{
			return;
		}
		KPlayer kPlayer = player;
		IEnumerable<StoreOwnedItem> ownedGifts = SFSKammelnaUserExtensions.GetOwnedGifts(kPlayer.<User>k__BackingField);
		object obj2 = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 384;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ X8_v38+E4]");
		object obj4;
		Func<object, bool> predicate;
		IEnumerable<object> source;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ X8_v38+B8]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X9_v12+18]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X9_v12+18]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			source = ownedGifts;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X9_v12+18]");
				Func<object, bool> func = (Func<object, bool>)0;
				goto IL_0287;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ X8_v38+B8]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X9_v12+18]");
			Func<object, bool> func = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X9_v12+18]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X9_v12+18]");
			predicate = (Func<object, bool>)0;
			source = ownedGifts;
			if (obj6 == null)
			{
				goto IL_0287;
			}
		}
		goto IL_04d4;
		IL_03ea:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X0_v23+E4]");
		bool flag3 = (nint)0 == 0;
		object obj7 = !flag3;
		object obj9;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj8 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ X8_v34+B8]");
			obj9 = 0;
		}
		object obj10 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3488;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj11 = (nint)0 + (nint)2312;
		Func<object, object> func2 = default(Func<object, object>);
		func2..ctor(obj9, (IntPtr)obj11);
		object obj12 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v352 @ X8_v33+B8]");
		object obj13 = (nint)0 + (nint)32;
		obj13 = func2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		IEnumerable<object> enumerable;
		IEnumerable<object> source2 = enumerable;
		Func<object, object> selector = func2;
		goto IL_058e;
		IL_0287:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ X8_v38+E4]");
		bool flag4 = (nint)0 == 0;
		object obj14 = !flag4;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj15 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ X8_v45+B8]");
			obj4 = 0;
		}
		object obj16 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3480;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj17 = (nint)0 + (nint)2304;
		Func<object, bool> func3 = default(Func<object, bool>);
		func3..ctor(obj4, (IntPtr)obj17);
		object obj18 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ X8_v44+B8]");
		object obj19 = (nint)0 + (nint)24;
		obj19 = func3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		predicate = func3;
		source = ownedGifts;
		goto IL_04d4;
		IL_04d4:
		object obj20 = (nint)0 + (nint)3776;
		IEnumerable<object> enumerable2 = Enumerable.Where(source, predicate);
		object obj21 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X0_v23+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X0_v23+B8]");
			obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ X8_v28+20]");
			selector = (Func<object, object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ X8_v28+20]");
			bool flag5 = (nint)0 == 0;
			object obj22 = !flag5;
			source2 = enumerable2;
			if (obj22 == null)
			{
				enumerable = enumerable2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ X8_v28+20]");
				Func<object, object> func4 = (Func<object, object>)0;
				goto IL_03ea;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj21 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X0_v23+B8]");
			obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ X8_v28+20]");
			Func<object, object> func4 = (Func<object, object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ X8_v28+20]");
			bool flag6 = (nint)0 == 0;
			object obj23 = !flag6;
			enumerable = enumerable2;
			source2 = enumerable2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ X8_v28+20]");
			selector = (Func<object, object>)0;
			if (obj23 == null)
			{
				goto IL_03ea;
			}
		}
		goto IL_058e;
		IL_058e:
		IEnumerable<object> source3 = Enumerable.Select(source2, selector);
		object obj24 = (nint)0 + (nint)3040;
		IEnumerable<object> source4 = ArraysExtensions.TakeLast(source3, 3);
		object obj25 = (nint)0 + (nint)2904;
		List<object> list3 = Enumerable.ToList(source4);
		if (list3._size >= 1)
		{
			object obj26 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 24;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj27 = (nint)0 + (nint)3424;
			Action<object> action = default(Action<object>);
			action..ctor((object)this, (IntPtr)obj27);
			list3.ForEach(action);
		}
	}

	private void ShowContainer()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0119: Expected O, but got I4
		//IL_00b3: Expected O, but got I4
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Expected O, but got Unknown
		//IL_01c8: Expected O, but got I4
		//IL_0164: Expected O, but got I4
		//IL_016d: Expected O, but got I4
		//IL_0238: Expected O, but got I4
		//IL_0253: Expected F4, but got O
		//IL_0253: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E66DD]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object giftsContainer;
		UnityEngine.Object giftsContainer2;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v17+E4]");
			bool flag = (nint)0 == 0;
			giftsContainer = GiftsContainer;
			giftsContainer2 = GiftsContainer;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			giftsContainer = GiftsContainer;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v17+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			giftsContainer2 = GiftsContainer;
			if (obj5 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = giftsContainer2 == null;
		bool flag4 = !flag3;
		object obj6 = !flag4;
		object obj7 = 0;
		if (obj6 != null)
		{
			goto IL_00c1;
		}
		goto IL_017b;
		IL_00c1:
		GameObject gameObject = base.gameObject;
		gameObject.SetActive(value: true);
		return;
		IL_017b:
		Rect rect = GiftsContainer.rect;
		object obj8 = typeof(System.Buffers.Text.ParserHelpers) + 3512;
		object obj9 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X0_v6+E4]");
		bool flag5 = (nint)0 == 0;
		object obj10 = !flag5;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int num = ShortcutExtensions.DOKill(GiftsContainer, complete: true);
		GameObject gameObject2 = base.gameObject;
		gameObject2.SetActive(value: true);
		RectTransform rectTransform = UIExtensions.rectTransform(GiftsContainer);
		rectTransform.sizeDelta = (Vector2)0;
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTweenModuleUI.DOSizeDelta(GiftsContainer, (Vector2)0, (float)GiftsContainerSize);
		return;
		IL_0091:
		bool flag6 = giftsContainer == null;
		bool flag7 = !flag6;
		obj7 = 0;
		if (!flag7)
		{
			goto IL_00c1;
		}
		goto IL_017b;
	}

	public void HideContainer()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_01a5: Expected O, but got I4
		//IL_00b3: Expected O, but got I4
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Expected O, but got Unknown
		//IL_0264: Expected O, but got I4
		//IL_01f0: Expected O, but got I4
		//IL_01f9: Expected O, but got I4
		//IL_02b7: Expected O, but got I4
		//IL_02d2: Expected F4, but got O
		//IL_02d2: Expected O, but got I4
		//IL_02e7: Expected O, but got I
		//IL_0300: Unknown result type (might be due to invalid IL or missing references)
		//IL_0305: Expected O, but got Unknown
		//IL_0320: Expected O, but got I
		//IL_032e: Expected I, but got O
		//IL_033a: Expected O, but got I
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Expected O, but got Unknown
		//IL_0123: Expected O, but got I4
		//IL_013e: Expected O, but got I
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Expected O, but got Unknown
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E66DE]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object giftsContainer;
		UnityEngine.Object giftsContainer2;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v20+E4]");
			bool flag = (nint)0 == 0;
			giftsContainer = GiftsContainer;
			giftsContainer2 = GiftsContainer;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			giftsContainer = GiftsContainer;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v20+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			giftsContainer2 = GiftsContainer;
			if (obj5 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = giftsContainer2 == null;
		bool flag4 = !flag3;
		object obj6 = !flag4;
		object obj7 = 0;
		if (obj6 != null)
		{
			goto IL_00c1;
		}
		goto IL_0207;
		IL_00c1:
		GameObject gameObject = base.gameObject;
		gameObject.SetActive(value: false);
		GameObject[] slots = Slots;
		if (slots.Length >= 1)
		{
			object obj8 = slots + 32;
			object obj9 = 0;
			do
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X21_v8+v154 @ X20_v12*8]");
				((GameObject)0).SetActive(value: false);
				obj9++;
			}
			while ((nint)obj9 < slots.Length);
		}
		return;
		IL_0207:
		animating = true;
		Rect rect = GiftsContainer.rect;
		object obj10 = typeof(System.Buffers.Text.ParserHelpers) + 3512;
		object obj11 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X0_v6+E4]");
		bool flag5 = (nint)0 == 0;
		object obj12 = !flag5;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int num = ShortcutExtensions.DOKill(GiftsContainer, complete: true);
		RectTransform rectTransform = UIExtensions.rectTransform(GiftsContainer);
		rectTransform.sizeDelta = (Vector2)0;
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTweenModuleUI.DOSizeDelta(GiftsContainer, (Vector2)0, (float)GiftsContainerSize);
		object obj13 = (nint)0 + (nint)2872;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		object obj14 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj15 = (nint)0 + (nint)3392;
		TweenCallback tweenCallback = default(TweenCallback);
		tweenCallback..ctor(this, (IntPtr)obj15);
		object obj16 = (nint)0 + (nint)2488;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
		return;
		IL_0091:
		bool flag6 = giftsContainer == null;
		bool flag7 = !flag6;
		obj7 = 0;
		if (!flag7)
		{
			goto IL_00c1;
		}
		goto IL_0207;
	}

	private void HideSlots()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0045: Expected O, but got I4
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_006e: Expected O, but got I
		GameObject[] slots = Slots;
		if (slots.Length >= 1)
		{
			object obj = slots + 32;
			object obj2 = 0;
			do
			{
				obj2++;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X21_v4+v40 @ X20_v5*8]");
				((GameObject)0).SetActive(value: false);
			}
			while ((nint)obj2 < slots.Length);
		}
	}

	private void StopAnimating()
	{
		animating = false;
	}

	private void ShakySlide(GameObject obj, GameObject target, TweenCallback callback, bool reverse = false)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0125: Expected O, but got I4
		//IL_015a: Expected O, but got I
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Expected O, but got Unknown
		//IL_017a: Expected O, but got I
		//IL_0186: Expected O, but got I
		//IL_01bd: Expected O, but got I4
		//IL_027b: Expected O, but got I4
		//IL_0209: Expected I, but got O
		object obj2 = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 448;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		<>c__DisplayClass32_0 <>c__DisplayClass32_ = default(<>c__DisplayClass32_0);
		<>c__DisplayClass32_..ctor();
		object obj3 = <>c__DisplayClass32_ + 16;
		obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = <>c__DisplayClass32_ + 40;
		obj4 = callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Transform transform = ((GameObject)obj3).transform;
		Vector3 localPosition = transform.localPosition;
		Transform transform2 = target.transform;
		Vector3 localPosition2 = transform2.localPosition;
		Vector3 vector = default(Vector3);
		<>c__DisplayClass32_.targetLocation = vector;
		float value = UnityEngine.Random.value;
		float num = value * 25f;
		float num2 = num + 10f;
		float num3 = num2 + 15f;
		float num4 = 0f - num3;
		bool flag = !reverse;
		object obj5 = !flag;
		object obj6 = ~obj5;
		if (obj6 != null)
		{
			num3 = num4;
		}
		<>c__DisplayClass32_.left = num3;
		object obj7 = (nint)0 + (nint)2904;
		object obj8 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
		object obj9 = (nint)0 + (nint)2432;
		object obj10 = (nint)0 + (nint)2504;
		float num5 = num2 + 10f;
		float num6 = 0f - num5;
		bool flag2 = !reverse;
		object obj11 = !flag2;
		object obj12 = ~obj11;
		float num7 = ((obj12 != null) ? num5 : num6);
		Transform target2 = <>c__DisplayClass32_.obj.transform;
		float duration = (float)vector + num7;
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOLocalMove(target2, (Vector3)0, duration);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TweenCallback tweenCallback = default(TweenCallback);
		tweenCallback..ctor(<>c__DisplayClass32_, (IntPtr)obj9);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
	}

	private void Explode(GameObject obj, Action callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected O, but got Unknown
		//IL_00b8: Expected O, but got I4
		//IL_011a: Expected O, but got I
		//IL_0126: Expected O, but got I
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected O, but got Unknown
		//IL_0146: Expected O, but got I
		//IL_0152: Expected O, but got I
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected O, but got Unknown
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Expected O, but got Unknown
		//IL_0259: Expected O, but got I
		//IL_0290: Expected O, but got I
		//IL_02ab: Expected O, but got I4
		//IL_02ca: Expected I, but got O
		//IL_01f5: Expected O, but got I4
		object obj2 = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 456;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		<>c__DisplayClass33_0 <>c__DisplayClass33_ = default(<>c__DisplayClass33_0);
		<>c__DisplayClass33_..ctor();
		object obj3 = (nint)0 + (nint)1344;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E32EDC");
		object obj4 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj5 = <>c__DisplayClass33_ + 16;
		object obj6 = default(object);
		obj5 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj7 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X0_v10+E4]");
		if ((nint)0 != 0)
		{
			bool flag = (UnityEngine.Object)obj5;
			bool flag2 = !flag;
			object obj8 = !flag2;
			if (obj8 != null)
			{
				goto IL_0100;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			if ((bool)(UnityEngine.Object)obj5)
			{
				goto IL_0100;
			}
		}
		goto IL_010e;
		IL_010e:
		object obj9 = (nint)0 + (nint)1280;
		object obj10 = (nint)0 + (nint)2736;
		object obj11 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
		object obj12 = (nint)0 + (nint)2448;
		object obj13 = (nint)0 + (nint)2528;
		object obj14 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E32EDC");
		Graphic target = default(Graphic);
		TweenerCore<Color, Color, ColorOptions> tweenerCore = DOTweenModuleUI.DOFade(target, 0f, 0.2f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
		Transform target2 = obj.transform;
		object obj15 = typeof(UsageHint) + 816;
		object obj16 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X8_v15+B8]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X8_v16+C]");
		object obj18 = default(object);
		float duration = 0f * (float)obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X8_v16+14]");
		object obj19 = (nint)0 * (nint)1058642330;
		float elasticity = default(float);
		Tweener tweener = ShortcutExtensions.DOPunchScale(target2, (Vector3)4, duration, 0, elasticity);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TweenCallback tweenCallback = default(TweenCallback);
		tweenCallback..ctor(<>c__DisplayClass33_, (IntPtr)obj12);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
		object obj20 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X0_v24+E4]");
		bool flag3 = (nint)0 == 0;
		object obj21 = !flag3;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Coroutine coroutine = CoroutineDummy.WaitForSeconds(1.5f, callback);
		return;
		IL_0100:
		((ParticleSystem)obj5).Play();
		goto IL_010e;
	}

	public GiftsShowcase()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		object obj = typeof(List<Tween>) + 864;
		animSpeed = 0.3f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj2 = this + 96;
		obj2 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list2 = default(List<object>);
		list2..ctor();
		object obj3 = this + 104;
		obj3 = list2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
	}

	internal static Func<GameObject, bool> <Update>g__MatchQueueItem|17_1(GiftQueueItem item)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0079: Expected I, but got O
		object obj = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 392;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (obj2 != null)
		{
			object obj3 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1328;
			object obj4 = (nint)0 + (nint)2336;
			object obj5 = obj2 + 16;
			obj5 = item;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj2, (IntPtr)obj4);
			return func;
		}
		return (Func<GameObject, bool>)(object)new NullReferenceException();
	}

	private void <HideContainer>b__29_0()
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_0062: Expected O, but got I4
		//IL_007d: Expected O, but got I
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected O, but got Unknown
		GameObject gameObject = base.gameObject;
		gameObject.SetActive(value: false);
		GameObject[] slots = Slots;
		if (slots.Length >= 1)
		{
			object obj = slots + 32;
			object obj2 = 0;
			do
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X22_v4+v24 @ X21_v5*8]");
				((GameObject)0).SetActive(value: false);
				obj2++;
			}
			while ((nint)obj2 < slots.Length);
		}
		animating = false;
	}
}
