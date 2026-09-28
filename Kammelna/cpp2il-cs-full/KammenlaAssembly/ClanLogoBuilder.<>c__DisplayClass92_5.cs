using System;
using System.Buffers.Text;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using System.Threading.Tasks;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server.Models.Clans;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using Newtonsoft.Json.Linq.JsonPath;
using Server.Models;
using Unity.Properties;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.InputSystem.UI;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.Rendering;
using UnityEngine.TextCore;
using UnityEngine.UI;

public class ClanLogoBuilder : MonoBehaviour
{
	[Serializable]
	private class LayerConfigReferences
	{
		public LogoLayerConfig layerConfig;

		public ClanLogoImageSelector selectorPrefab;

		public Transform selectorsParent;

		public Button belowMinButton;
	}

	private struct LayerSnapshot
	{
		private sealed class <>c__DisplayClass7_0
		{
			public IconLayer layer;

			internal bool <.ctor>b__0(IconLayer l)
			{
				//IL_00dd: Expected I4, but got O
				//IL_00bb: Expected O, but got I4
				if (l != null)
				{
					LogoLayerConfig layerConfig = l.layerConfig;
					if ((object)l.layerConfig != null)
					{
						IconLayer iconLayer = layer;
						if (layer != null)
						{
							LogoLayerConfig layerConfig2 = iconLayer.layerConfig;
							if ((object)iconLayer.layerConfig != null)
							{
								object obj = layerConfig.Layer - layerConfig2.Layer;
								return obj == null;
							}
						}
					}
				}
				NullReferenceException ex = new NullReferenceException();
				return (byte)(int)ex != 0;
			}
		}

		public readonly int ImageId;

		public readonly float Rotation;

		public readonly float Scale;

		public readonly bool Inverted;

		public readonly Color Color;

		public readonly Vector2 Position;

		public readonly int OrderInGroup;

		public LayerSnapshot(ClanLogoBuilder builder, IconLayer layer)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Expected O, but got Unknown
			//IL_006a: Expected F4, but got I
			//IL_008e: Expected O, but got I
			//IL_00ad: Expected O, but got I
			//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c6: Expected O, but got Unknown
			//IL_00d2: Expected O, but got I
			//IL_00ef: Expected I, but got O
			object obj = typeof(TrackedDeviceRaycaster.<>c) + 4048;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj2 + 16;
			obj3 = layer;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v4+20]");
			ImageId = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v4+24]");
			Rotation = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v4+2C]");
			Inverted = false;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v4+30]");
			Color = (Color)0;
			object obj5 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X8_v5+40]");
			Position = (Vector2)0;
			object obj6 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1736;
			object obj7 = (nint)0 + (nint)688;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj2, (IntPtr)obj7);
			OrderInGroup = Enumerable.ToList(Enumerable.Where(builder.layers, func)).IndexOf(obj3);
		}
	}

	private struct UndoEntry
	{
		public IconLayer Layer;

		public List<Action> Actions;
	}

	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<IconLayer, bool> <>9__53_1;

		public static Func<IconLayer, bool> <>9__70_0;

		public static Func<IconLayer, bool> <>9__70_1;

		public static Func<IconLayer, bool> <>9__73_0;

		public static Func<string, Color> <>9__75_0;

		public static Func<Color, bool> <>9__75_1;

		public static Func<IconLayer, bool> <>9__90_1;

		public static Func<IconLayer, bool> <>9__90_2;

		public static Func<IconLayer, bool> <>9__105_0;

		public static Func<IconLayer, bool> <>9__105_1;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(CardUtils.<>c) + 936;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal bool <SetLayerOrderInGroup>b__53_1(IconLayer l)
		{
			//IL_004c: Expected I4, but got O
			if (l != null)
			{
				int num = ~l.ImageId;
				return (byte)(num >> 31) != 0;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <LayersToModel>b__70_0(IconLayer l)
		{
			//IL_00a3: Expected I4, but got O
			if (l != null)
			{
				LogoLayerConfig layerConfig = l.layerConfig;
				if ((object)l.layerConfig != null)
				{
					if (layerConfig.Layer != ClanLogoLayer.Rim)
					{
						return false;
					}
					int num = ~l.ImageId;
					return (byte)(num >> 31) != 0;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <LayersToModel>b__70_1(IconLayer l)
		{
			//IL_00a6: Expected I4, but got O
			if (l != null)
			{
				LogoLayerConfig layerConfig = l.layerConfig;
				if ((object)l.layerConfig != null)
				{
					if (layerConfig.Layer == ClanLogoLayer.Icon)
					{
						int num = ~l.ImageId;
						return (byte)(num >> 31) != 0;
					}
					return false;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <HasIconItems>b__73_0(IconLayer l)
		{
			//IL_015b: Expected I4, but got O
			//IL_0068: Unknown result type (might be due to invalid IL or missing references)
			//IL_006d: Expected O, but got Unknown
			//IL_0138: Expected O, but got I4
			if (l != null)
			{
				LogoLayerConfig layerConfig = l.layerConfig;
				if ((object)l.layerConfig != null)
				{
					if (layerConfig.Layer == ClanLogoLayer.Icon)
					{
						object obj = typeof(MemberAchievementClanFeedData) + 2976;
						object obj2 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v6+E4]");
						if ((nint)0 != 0)
						{
							if (l.Selector != null)
							{
								goto IL_00c7;
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							bool flag = l.Selector != null;
							bool flag2 = !flag;
							object obj3 = !flag2;
							if (obj3 != null)
							{
								goto IL_00c7;
							}
						}
					}
					return false;
				}
			}
			goto IL_014d;
			IL_00c7:
			if ((object)l.Selector != null)
			{
				return l.Selector.HasSelectableItems;
			}
			goto IL_014d;
			IL_014d:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal Color <BuildEmblemColorPresets>b__75_0(string hex)
		{
			//IL_0011: Expected O, but got I4
			Color color2;
			Color color = (Color)ColorUtility.TryParseHtmlString(hex, out color2);
			if ((object)color != null)
			{
			}
			return color;
		}

		internal bool <BuildEmblemColorPresets>b__75_1(Color c)
		{
			//IL_0064: Unknown result type (might be due to invalid IL or missing references)
			//IL_0069: Expected O, but got Unknown
			object obj2 = default(object);
			object obj = obj2 * obj2;
			object obj4 = default(object);
			object obj3 = obj4 * obj4;
			object obj5 = obj + obj3;
			object obj7 = default(object);
			object obj6 = obj7 * obj7;
			object obj8 = obj6 + obj5;
			object obj10 = default(object);
			object obj9 = obj10 * obj10;
			object obj11 = obj9 + obj8;
			object obj12 = obj11 - 786163454;
			bool flag = (nint)obj12 < 0;
			return !flag;
		}

		internal bool <SortEmptiesToEnd>b__90_1(IconLayer l)
		{
			//IL_004c: Expected I4, but got O
			if (l != null)
			{
				int num = ~l.ImageId;
				return (byte)(num >> 31) != 0;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <SortEmptiesToEnd>b__90_2(IconLayer l)
		{
			//IL_0043: Expected I4, but got O
			if (l != null)
			{
				return (byte)(l.ImageId >> 31) != 0;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <ApplyModel>b__105_0(IconLayer l)
		{
			//IL_0073: Expected I4, but got O
			if (l != null)
			{
				LogoLayerConfig layerConfig = l.layerConfig;
				if ((object)l.layerConfig != null)
				{
					return layerConfig.Layer == ClanLogoLayer.Rim;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <ApplyModel>b__105_1(IconLayer l)
		{
			//IL_0081: Expected I4, but got O
			//IL_005f: Expected O, but got I4
			if (l != null)
			{
				LogoLayerConfig layerConfig = l.layerConfig;
				if ((object)l.layerConfig != null)
				{
					object obj = layerConfig.Layer - 1;
					return obj == null;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass104_0
	{
		public LayerConfigReferences configRef;

		internal bool <HasMinimumLayers>b__0(IconLayer l)
		{
			//IL_0125: Expected I4, but got O
			//IL_003d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Expected O, but got Unknown
			//IL_00a0: Expected O, but got I4
			bool flag;
			if (l != null)
			{
				LayerConfigReferences layerConfigReferences = configRef;
				if (configRef != null)
				{
					object obj = typeof(MemberAchievementClanFeedData) + 2976;
					object obj2 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v3+E4]");
					if ((nint)0 != 0)
					{
						flag = l.layerConfig == layerConfigReferences.layerConfig;
						bool flag2 = !flag;
						object obj3 = !flag2;
						if (obj3 == null)
						{
							goto IL_00ae;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						flag = l.layerConfig == layerConfigReferences.layerConfig;
						if (!flag)
						{
							goto IL_00ae;
						}
					}
					int num = ~l.ImageId;
					return (byte)(num >> 31) != 0;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_00ae:
			return flag;
		}
	}

	private sealed class <>c__DisplayClass53_0
	{
		public ClanLogoLayer enumGroup;

		internal bool <SetLayerOrderInGroup>b__0(IconLayer l)
		{
			//IL_0082: Expected I4, but got O
			//IL_0060: Expected O, but got I4
			if (l != null)
			{
				LogoLayerConfig layerConfig = l.layerConfig;
				if ((object)l.layerConfig != null)
				{
					object obj = layerConfig.Layer - enumGroup;
					return obj == null;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass61_0
	{
		public LogoLayerConfig config;

		internal bool <OnOpenLayerEditor>b__0(IconLayer l)
		{
			//IL_00f6: Expected I4, but got O
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0074: Expected O, but got I4
			bool flag;
			if (l != null)
			{
				object obj = typeof(MemberAchievementClanFeedData) + 2976;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v3+E4]");
				if ((nint)0 != 0)
				{
					flag = l.layerConfig == config;
					bool flag2 = !flag;
					object obj3 = !flag2;
					if (obj3 == null)
					{
						goto IL_0082;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					flag = l.layerConfig == config;
					if (!flag)
					{
						goto IL_0082;
					}
				}
				int num = ~l.ImageId;
				return (byte)(num >> 31) != 0;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_0082:
			return flag;
		}

		internal bool <OnOpenLayerEditor>b__1(IconLayer l)
		{
			//IL_00f6: Expected I4, but got O
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0074: Expected O, but got I4
			bool flag;
			if (l != null)
			{
				object obj = typeof(MemberAchievementClanFeedData) + 2976;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v3+E4]");
				if ((nint)0 != 0)
				{
					flag = l.layerConfig == config;
					bool flag2 = !flag;
					object obj3 = !flag2;
					if (obj3 == null)
					{
						goto IL_0082;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					flag = l.layerConfig == config;
					if (!flag)
					{
						goto IL_0082;
					}
				}
				int num = ~l.ImageId;
				return (byte)(num >> 31) != 0;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_0082:
			return flag;
		}
	}

	private sealed class <>c__DisplayClass63_0
	{
		public IconLayer layer;

		internal bool <SelectLayer>b__0(LayerConfigReferences b)
		{
			//IL_00b7: Expected I4, but got O
			//IL_003d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Expected O, but got Unknown
			//IL_006c: Expected O, but got I4
			if (b != null)
			{
				IconLayer iconLayer = layer;
				if (layer != null)
				{
					object obj = typeof(MemberAchievementClanFeedData) + 2976;
					object obj2 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v3+E4]");
					bool flag = (nint)0 == 0;
					object obj3 = !flag;
					if (obj3 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					return b.layerConfig == iconLayer.layerConfig;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass71_0
	{
		public LayerConfigReferences capturedRef;

		public ClanLogoBuilder <>4__this;

		internal void <Initialize>b__0()
		{
			<>4__this.OnBelowMinButtonClicked(capturedRef);
		}
	}

	private sealed class <>c__DisplayClass71_1
	{
		public IconLayer layer;

		public ClanLogoBuilder <>4__this;

		internal void <Initialize>b__1(ClanLogoLayer l, int id)
		{
			<>4__this.OnSelectorItemSelected(layer, l, id);
		}

		internal void <Initialize>b__2(ClanLogoLayer l, int id)
		{
			<>4__this.OnSelectorItemConfirmed(layer, l, id);
		}

		internal void <Initialize>b__3(Color color, Action undo)
		{
			<>4__this.OnSelectorColorSelected(layer, color, null);
		}

		internal void <Initialize>b__4(int delta)
		{
			<>4__this.OnSelectorOrderChangeRequested(layer, delta);
		}

		internal void <Initialize>b__5(Vector2 screenPos, Camera cam)
		{
			<>4__this.OnSelectorDropRequested(layer, screenPos, null);
		}

		internal void <Initialize>b__6(Vector2 screenPos, Camera cam)
		{
			<>4__this.OnSelectorDragMoved(layer, screenPos, null);
		}

		internal void <Initialize>b__7()
		{
			<>4__this.OnSelectorDragBegan(layer);
		}

		internal void <Initialize>b__8()
		{
			<>4__this.SelectLayer(layer);
		}
	}

	private sealed class <>c__DisplayClass80_0
	{
		public LayerConfigReferences configRef;

		internal bool <UpdateBelowMinButtons>b__0(IconLayer l)
		{
			//IL_0125: Expected I4, but got O
			//IL_003d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Expected O, but got Unknown
			//IL_00a0: Expected O, but got I4
			bool flag;
			if (l != null)
			{
				LayerConfigReferences layerConfigReferences = configRef;
				if (configRef != null)
				{
					object obj = typeof(MemberAchievementClanFeedData) + 2976;
					object obj2 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v3+E4]");
					if ((nint)0 != 0)
					{
						flag = l.layerConfig == layerConfigReferences.layerConfig;
						bool flag2 = !flag;
						object obj3 = !flag2;
						if (obj3 == null)
						{
							goto IL_00ae;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						flag = l.layerConfig == layerConfigReferences.layerConfig;
						if (!flag)
						{
							goto IL_00ae;
						}
					}
					int num = ~l.ImageId;
					return (byte)(num >> 31) != 0;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_00ae:
			return flag;
		}
	}

	private sealed class <>c__DisplayClass81_0
	{
		public LayerConfigReferences configRef;

		internal bool <OnBelowMinButtonClicked>b__0(LayerConfigReferences c)
		{
			//IL_00b7: Expected I4, but got O
			//IL_003d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Expected O, but got Unknown
			//IL_006c: Expected O, but got I4
			if (c != null)
			{
				LayerConfigReferences layerConfigReferences = configRef;
				if (configRef != null)
				{
					object obj = typeof(MemberAchievementClanFeedData) + 2976;
					object obj2 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v3+E4]");
					bool flag = (nint)0 == 0;
					object obj3 = !flag;
					if (obj3 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					return c.layerConfig == layerConfigReferences.layerConfig;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <OnBelowMinButtonClicked>b__1(IconLayer l)
		{
			//IL_011c: Expected I4, but got O
			//IL_003d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Expected O, but got Unknown
			//IL_00a0: Expected O, but got I4
			bool flag;
			if (l != null)
			{
				LayerConfigReferences layerConfigReferences = configRef;
				if (configRef != null)
				{
					object obj = typeof(MemberAchievementClanFeedData) + 2976;
					object obj2 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v3+E4]");
					if ((nint)0 != 0)
					{
						flag = l.layerConfig == layerConfigReferences.layerConfig;
						bool flag2 = !flag;
						object obj3 = !flag2;
						if (obj3 == null)
						{
							goto IL_00ae;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						flag = l.layerConfig == layerConfigReferences.layerConfig;
						if (!flag)
						{
							goto IL_00ae;
						}
					}
					return (byte)(l.ImageId >> 31) != 0;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_00ae:
			return flag;
		}
	}

	private sealed class <>c__DisplayClass83_0
	{
		public IconLayer layer;

		internal bool <OnSelectorOrderChangeRequested>b__0(IconLayer l)
		{
			//IL_00dd: Expected I4, but got O
			//IL_00bb: Expected O, but got I4
			if (l != null)
			{
				LogoLayerConfig layerConfig = l.layerConfig;
				if ((object)l.layerConfig != null)
				{
					IconLayer iconLayer = layer;
					if (layer != null)
					{
						LogoLayerConfig layerConfig2 = iconLayer.layerConfig;
						if ((object)iconLayer.layerConfig != null)
						{
							object obj = layerConfig.Layer - layerConfig2.Layer;
							return obj == null;
						}
					}
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass90_0
	{
		public ClanLogoLayer enumValue;

		internal bool <SortEmptiesToEnd>b__0(IconLayer l)
		{
			//IL_0082: Expected I4, but got O
			//IL_0060: Expected O, but got I4
			if (l != null)
			{
				LogoLayerConfig layerConfig = l.layerConfig;
				if ((object)l.layerConfig != null)
				{
					object obj = layerConfig.Layer - enumValue;
					return obj == null;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass92_0
	{
		public IconLayer layer;

		public ClanLogoBuilder <>4__this;
	}

	private sealed class <>c__DisplayClass92_1
	{
		public int restoreId;

		public <>c__DisplayClass92_0 CS$<>8__locals1;

		internal void <BuildUndoActions>b__0()
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected O, but got Unknown
			//IL_0102: Expected O, but got I4
			//IL_015e: Expected O, but got I
			<>c__DisplayClass92_0 cS$<>8__locals = CS$<>8__locals1;
			IconLayer layer = cS$<>8__locals.layer;
			object obj = typeof(MemberAchievementClanFeedData) + 2976;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v4+E4]");
			<>c__DisplayClass92_0 cS$<>8__locals2;
			<>c__DisplayClass92_0 cS$<>8__locals3;
			if ((nint)0 != 0)
			{
				bool flag = layer.Selector != null;
				cS$<>8__locals2 = CS$<>8__locals1;
				bool flag2 = !flag;
				cS$<>8__locals3 = CS$<>8__locals1;
				if (!flag2)
				{
					goto IL_0099;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag3 = layer.Selector != null;
				cS$<>8__locals2 = CS$<>8__locals1;
				bool flag4 = !flag3;
				object obj3 = !flag4;
				cS$<>8__locals3 = CS$<>8__locals1;
				if (obj3 != null)
				{
					goto IL_0099;
				}
			}
			object layer2 = cS$<>8__locals3.layer;
			_ = restoreId;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X20_v4 (System.Object)+10]");
			Actions.SafeInvoke((Action<object>)0, layer2);
			return;
			IL_0099:
			IconLayer layer3 = cS$<>8__locals2.layer;
			layer3.Selector.RestoreSelectionToId(restoreId);
		}
	}

	private sealed class <>c__DisplayClass92_2
	{
		public float restoreRotation;

		public <>c__DisplayClass92_0 CS$<>8__locals2;

		internal void <BuildUndoActions>b__1()
		{
			//IL_0043: Expected O, but got I
			<>c__DisplayClass92_0 cS$<>8__locals = CS$<>8__locals2;
			object layer = cS$<>8__locals.layer;
			_ = restoreRotation;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ X19_v2 (System.Object)+10]");
			Actions.SafeInvoke((Action<object>)0, layer);
		}
	}

	private sealed class <>c__DisplayClass92_3
	{
		public float restoreScale;

		public <>c__DisplayClass92_0 CS$<>8__locals3;

		internal void <BuildUndoActions>b__2()
		{
			//IL_0043: Expected O, but got I
			<>c__DisplayClass92_0 cS$<>8__locals = CS$<>8__locals3;
			object layer = cS$<>8__locals.layer;
			_ = restoreScale;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ X19_v2 (System.Object)+10]");
			Actions.SafeInvoke((Action<object>)0, layer);
		}
	}

	private sealed class <>c__DisplayClass92_4
	{
		public bool restoreInverted;

		public <>c__DisplayClass92_0 CS$<>8__locals4;

		internal void <BuildUndoActions>b__3()
		{
			//IL_0043: Expected O, but got I
			<>c__DisplayClass92_0 cS$<>8__locals = CS$<>8__locals4;
			object layer = cS$<>8__locals.layer;
			_ = restoreInverted;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ X19_v2 (System.Object)+10]");
			Actions.SafeInvoke((Action<object>)0, layer);
		}
	}

	private sealed class <>c__DisplayClass92_5
	{
		public Color restoreColor;

		public <>c__DisplayClass92_0 CS$<>8__locals5;

		internal void <BuildUndoActions>b__4()
		{
			//IL_0043: Expected O, but got I
			<>c__DisplayClass92_0 cS$<>8__locals = CS$<>8__locals5;
			object layer = cS$<>8__locals.layer;
			_ = restoreColor;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ X19_v2 (System.Object)+10]");
			Actions.SafeInvoke((Action<object>)0, layer);
		}
	}

	private sealed class <>c__DisplayClass92_6
	{
		public Vector2 restorePosition;

		public <>c__DisplayClass92_0 CS$<>8__locals6;

		internal void <BuildUndoActions>b__5()
		{
			//IL_0043: Expected O, but got I
			<>c__DisplayClass92_0 cS$<>8__locals = CS$<>8__locals6;
			object layer = cS$<>8__locals.layer;
			_ = restorePosition;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ X19_v2 (System.Object)+10]");
			Actions.SafeInvoke((Action<object>)0, layer);
		}
	}

	private sealed class <>c__DisplayClass92_7
	{
		public int restoreOrder;

		public <>c__DisplayClass92_0 CS$<>8__locals7;

		internal void <BuildUndoActions>b__6()
		{
			<>c__DisplayClass92_0 cS$<>8__locals = CS$<>8__locals7;
			cS$<>8__locals.<>4__this.SetLayerOrderInGroup(cS$<>8__locals.layer, restoreOrder);
		}
	}

	private sealed class <>c__DisplayClass97_0
	{
		public ClanLogoBuilder <>4__this;

		public Vector2 direction;

		internal void <SetupMoveButton>b__0(BaseEventData _)
		{
			//IL_0010: Expected O, but got I4
			<>4__this.StartMoving((Vector2)0);
		}

		internal void <SetupMoveButton>b__1(BaseEventData _)
		{
			<>4__this.StopMoving();
		}
	}

	[StructLayout((LayoutKind)3)]
	private struct <Initialize>d__71 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public ClanLogoBuilder <>4__this;

		private TaskAwaiter <>u__1;

		private unsafe void MoveNext()
		{
			//IL_10f3: Expected O, but got I4
			//IL_1102: Expected I4, but got I8
			//IL_1863: Unknown result type (might be due to invalid IL or missing references)
			//IL_1868: Expected O, but got Unknown
			//IL_1892: Expected O, but got I4
			//IL_114a: Expected O, but got I4
			//IL_166a: Expected O, but got I
			//IL_1393: Expected I4, but got I8
			//IL_139e: Expected O, but got Ref
			//IL_0051: Unknown result type (might be due to invalid IL or missing references)
			//IL_0056: Expected O, but got Unknown
			//IL_0080: Expected O, but got I4
			//IL_0143: Unknown result type (might be due to invalid IL or missing references)
			//IL_0148: Expected O, but got Unknown
			//IL_1182: Unknown result type (might be due to invalid IL or missing references)
			//IL_1187: Expected O, but got Unknown
			//IL_1190: Expected O, but got I4
			//IL_0163: Expected O, but got I
			//IL_1215: Unknown result type (might be due to invalid IL or missing references)
			//IL_121a: Expected O, but got Unknown
			//IL_1233: Unknown result type (might be due to invalid IL or missing references)
			//IL_1238: Expected O, but got Unknown
			//IL_1262: Expected O, but got I4
			//IL_1289: Unknown result type (might be due to invalid IL or missing references)
			//IL_128e: Expected O, but got Unknown
			//IL_12a1: Expected O, but got I4
			//IL_12cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_12d4: Expected O, but got Unknown
			//IL_12fe: Expected O, but got I4
			//IL_1360: Unknown result type (might be due to invalid IL or missing references)
			//IL_1365: Expected O, but got Unknown
			//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d5: Expected O, but got Unknown
			//IL_01da: Expected O, but got Ref
			//IL_01eb: Expected O, but got I4
			//IL_01f4: Expected O, but got I4
			//IL_0268: Expected O, but got I
			//IL_0fdf: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fe4: Expected O, but got Unknown
			//IL_100e: Expected O, but got I4
			//IL_029c: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a1: Expected O, but got Unknown
			//IL_02cb: Expected O, but got I4
			//IL_02fa: Expected O, but got I
			//IL_04a8: Expected O, but got I
			//IL_108e: Expected O, but got I4
			//IL_0338: Unknown result type (might be due to invalid IL or missing references)
			//IL_033d: Expected O, but got Unknown
			//IL_04f2: Expected O, but got I8
			//IL_10b2: Expected O, but got Ref
			//IL_10d0: Expected O, but got Ref
			//IL_181f: Unknown result type (might be due to invalid IL or missing references)
			//IL_1824: Expected O, but got Unknown
			//IL_0212: Unknown result type (might be due to invalid IL or missing references)
			//IL_0217: Expected O, but got Unknown
			//IL_037b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0380: Expected O, but got Unknown
			//IL_039d: Unknown result type (might be due to invalid IL or missing references)
			//IL_03a2: Expected O, but got Unknown
			//IL_03b2: Expected O, but got I
			//IL_0516: Unknown result type (might be due to invalid IL or missing references)
			//IL_051b: Expected O, but got Unknown
			//IL_03d1: Expected O, but got I
			//IL_1625: Expected O, but got I
			//IL_0406: Unknown result type (might be due to invalid IL or missing references)
			//IL_040b: Expected O, but got Unknown
			//IL_0421: Expected O, but got I
			//IL_0429: Expected I, but got O
			//IL_043a: Expected I, but got O
			//IL_0559: Unknown result type (might be due to invalid IL or missing references)
			//IL_055e: Expected O, but got Unknown
			//IL_0581: Unknown result type (might be due to invalid IL or missing references)
			//IL_0586: Expected O, but got Unknown
			//IL_163c: Expected O, but got I4
			//IL_1740: Unknown result type (might be due to invalid IL or missing references)
			//IL_1745: Expected O, but got Unknown
			//IL_175d: Expected O, but got I
			//IL_177c: Unknown result type (might be due to invalid IL or missing references)
			//IL_1781: Expected O, but got Unknown
			//IL_1791: Expected O, but got I
			//IL_17ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_17b3: Expected O, but got Unknown
			//IL_0479: Expected O, but got I
			//IL_0482: Expected O, but got I4
			//IL_05fb: Expected O, but got I
			//IL_0672: Expected O, but got I4
			//IL_06ec: Expected O, but got I
			//IL_06fc: Expected O, but got I
			//IL_0732: Unknown result type (might be due to invalid IL or missing references)
			//IL_0737: Expected O, but got Unknown
			//IL_0761: Expected O, but got I4
			//IL_06b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_06b7: Expected O, but got Unknown
			//IL_06c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_06c5: Expected O, but got Unknown
			//IL_078a: Expected O, but got I
			//IL_0792: Expected I, but got O
			//IL_1411: Expected O, but got I
			//IL_07c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_07c7: Expected O, but got Unknown
			//IL_07ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_0804: Expected O, but got Unknown
			//IL_17d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_17de: Expected O, but got Unknown
			//IL_1808: Expected O, but got I4
			//IL_0844: Expected O, but got Ref
			//IL_0861: Expected O, but got Ref
			//IL_0879: Expected O, but got Ref
			//IL_0896: Expected O, but got Ref
			//IL_08ac: Expected O, but got I
			//IL_08b4: Expected I, but got O
			//IL_08c2: Expected O, but got Ref
			//IL_08e2: Expected O, but got Ref
			//IL_13d5: Expected O, but got I4
			//IL_0918: Expected O, but got I
			//IL_0995: Expected O, but got I4
			//IL_0a0f: Expected O, but got I
			//IL_0a1f: Expected O, but got I
			//IL_0a50: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a55: Expected O, but got Unknown
			//IL_0a65: Expected O, but got I
			//IL_0a6d: Expected I, but got O
			//IL_0a7e: Expected I, but got O
			//IL_09d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_09da: Expected O, but got Unknown
			//IL_09e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_09e8: Expected O, but got Unknown
			//IL_146b: Expected O, but got I4
			//IL_1474: Expected O, but got I4
			//IL_0ab4: Expected O, but got I
			//IL_0ac9: Expected O, but got I
			//IL_0ad8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0add: Expected O, but got Unknown
			//IL_0af8: Expected O, but got I
			//IL_0b00: Expected I, but got O
			//IL_0b11: Expected I, but got O
			//IL_14bb: Expected O, but got I4
			//IL_14c4: Expected O, but got I4
			//IL_0b42: Expected O, but got I
			//IL_0b4a: Expected I, but got O
			//IL_0b5f: Expected O, but got I
			//IL_0b6f: Expected O, but got I
			//IL_1493: Expected O, but got I4
			//IL_149c: Expected O, but got I4
			//IL_0ba3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ba8: Expected O, but got Unknown
			//IL_0bbe: Expected O, but got I
			//IL_0bc6: Expected I, but got O
			//IL_14e3: Expected O, but got I4
			//IL_14ec: Expected O, but got I4
			//IL_0c06: Expected O, but got I
			//IL_0c1f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c24: Expected O, but got Unknown
			//IL_0c3f: Expected O, but got I
			//IL_0c47: Expected I, but got O
			//IL_0c58: Expected I, but got O
			//IL_1443: Expected O, but got I4
			//IL_144c: Expected O, but got I4
			//IL_0c89: Expected O, but got I
			//IL_0c9e: Expected O, but got I
			//IL_0cad: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cb2: Expected O, but got Unknown
			//IL_0ccd: Expected O, but got I
			//IL_0cd5: Expected I, but got O
			//IL_0ce6: Expected I, but got O
			//IL_150b: Expected O, but got I4
			//IL_1514: Expected O, but got I4
			//IL_0d17: Expected O, but got I
			//IL_0d2c: Expected O, but got I
			//IL_0d3b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d40: Expected O, but got Unknown
			//IL_0d5b: Expected O, but got I
			//IL_0d63: Expected I, but got O
			//IL_0d74: Expected I, but got O
			//IL_155b: Expected O, but got I4
			//IL_1564: Expected O, but got I4
			//IL_0da5: Expected O, but got I
			//IL_0dba: Expected O, but got I
			//IL_0dc9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0dce: Expected O, but got Unknown
			//IL_0de9: Expected O, but got I
			//IL_0df1: Expected I, but got O
			//IL_0e02: Expected I, but got O
			//IL_1533: Expected O, but got I4
			//IL_153c: Expected O, but got I4
			//IL_0e3c: Expected O, but got I
			//IL_0e4c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e51: Expected O, but got Unknown
			//IL_0e6c: Expected O, but got I
			//IL_0e74: Expected I, but got O
			//IL_0e85: Expected I, but got O
			//IL_1583: Expected O, but got I4
			//IL_158c: Expected O, but got I4
			//IL_0ebf: Expected O, but got I
			//IL_0ecf: Expected O, but got I
			//IL_0ef1: Expected O, but got I4
			//IL_0efa: Expected O, but got I4
			//IL_0f03: Expected O, but got I4
			//IL_0f24: Expected O, but got I8
			//IL_0f2d: Expected O, but got I4
			//IL_0f36: Expected O, but got I4
			ClanLogoBuilder clanLogoBuilder = <>4__this;
			List<object> list = default(List<object>);
			object obj8;
			object obj10;
			object obj18 = default(object);
			object obj29 = default(object);
			nint num2;
			object obj50 = default(object);
			Task task;
			UnityAction<System.Int32Enum, int> unityAction4 = default(UnityAction<System.Int32Enum, int>);
			object obj9 = default(object);
			object obj25;
			nint num;
			NullReferenceException ex;
			object obj4;
			if (<>1__state != 0)
			{
				if ((object)<>4__this != null)
				{
					clanLogoBuilder._initialLoad = true;
					<>4__this.SetInteractionLocked(locked: true);
					object obj = typeof(MemberAchievementClanFeedData) + 2976;
					object obj2 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X0_v42+E4]");
					bool flag = (nint)0 == 0;
					object obj3 = !flag;
					if (obj3 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag2 = clanLogoBuilder.UndoButton != null;
					bool flag3 = !flag2;
					num = 0;
					bool flag4 = false;
					if (!flag3)
					{
						if ((object)clanLogoBuilder.UndoButton == null)
						{
							ex = new NullReferenceException();
							num = 0;
							obj4 = null;
							goto IL_16e3;
						}
						clanLogoBuilder.UndoButton.interactable = false;
						num = 0;
						flag4 = false;
					}
					Task<List<Color>> emblemColorPresets = GetEmblemColorPresets();
					object obj5 = typeof(List<AdaptivePerformanceScaler>) + 3856;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj6 = (nint)0 + (nint)520;
					obj4 = obj6;
					list..ctor();
					LayerConfigReferences[] layerConfigs = clanLogoBuilder.layerConfigs;
					if (clanLogoBuilder.layerConfigs != null)
					{
						if (layerConfigs.Length < 1)
						{
							goto IL_0f73;
						}
						object obj7 = clanLogoBuilder.layerConfigs + 32;
						<Initialize>d__71 <Initialize>d__ = (<Initialize>d__71)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
						obj8 = obj9;
						obj10 = 0;
						object obj11 = 0;
						num2 = num;
						object obj12 = obj6;
						UnityAction unityAction2 = default(UnityAction);
						object obj35 = default(object);
						ClanLogoImageSelector.<Initialize>d__30 stateMachine = default(ClanLogoImageSelector.<Initialize>d__30);
						UnityAction<System.Int32Enum, int> unityAction3 = default(UnityAction<System.Int32Enum, int>);
						UnityAction<int> unityAction5 = default(UnityAction<int>);
						UnityAction<Vector2, object> unityAction6 = default(UnityAction<Vector2, object>);
						UnityAction<Vector2, object> unityAction7 = default(UnityAction<Vector2, object>);
						UnityAction unityAction8 = default(UnityAction);
						UnityAction unityAction9 = default(UnityAction);
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v743 @ X8_v39+v333 @ X24_v7*8]");
							object obj13 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v743 @ X8_v39+v333 @ X24_v7*8]");
							if ((nint)0 == 0)
							{
								break;
							}
							object obj14 = typeof(MemberAchievementClanFeedData) + 2976;
							object obj15 = obj14;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v792 @ X0_v72+E4]");
							bool flag5 = (nint)0 == 0;
							object obj16 = !flag5;
							if (obj16 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ X26_v7 (System.Object)+28]");
							bool flag6 = (UnityEngine.Object)0 != null;
							bool flag7 = !flag6;
							num = 0;
							UnityAction unityAction = null;
							if (!flag7)
							{
								object obj17 = typeof(CardUtils.<>c) + 976;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
								obj18..ctor();
								if (obj18 == null)
								{
									goto IL_15c7;
								}
								object obj19 = obj18 + 24;
								obj19 = <>4__this;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								object obj20 = obj18 + 16;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v743 @ X8_v39+v333 @ X24_v7*8]");
								obj20 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ X26_v7 (System.Object)+28]");
								object obj21 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ X26_v7 (System.Object)+28]");
								if ((nint)0 == 0)
								{
									goto IL_15f3;
								}
								object obj22 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
								object obj23 = (nint)0 + (nint)4088;
								num = (nint)obj23;
								unityAction2..ctor(obj18, (IntPtr)obj23);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v515 @ X8_v144+100]");
								if ((nint)0 == 0)
								{
									goto IL_162a;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v515 @ X8_v144+100]");
								((UnityEvent)0).AddListener(unityAction2);
								obj8 = 0;
								num = 0;
								unityAction = unityAction2;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ X26_v7 (System.Object)+10]");
							object obj24 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ X26_v7 (System.Object)+10]");
							bool flag8 = (nint)0 == 0;
							obj4 = unityAction;
							if (flag8)
							{
								goto IL_0f55;
							}
							obj9 = obj8;
							obj25 = obj10;
							object obj26 = 4294967295L;
							num2 = num;
							obj12 = unityAction;
							while (true)
							{
								obj26++;
								object obj27 = obj26;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v874 @ X8_v48+30]");
								if ((nint)obj27 >= 0)
								{
									break;
								}
								object obj28 = typeof(CardUtils.<>c) + 984;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
								obj29..ctor();
								if (obj29 != null)
								{
									object obj30 = obj29 + 24;
									obj30 = <>4__this;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
									object obj31 = typeof(System.IOAsyncCallback) + 2344;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
									_ = 4294967295L;
									_ = 63;
									_ = 0;
									object obj32 = typeof(UsageHint) + 744;
									object obj33 = obj32;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v953 @ X8_v60+B8]");
									object obj34 = 0;
									obj25 = obj34;
									obj35..ctor();
									object obj36 = obj35 + 24;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ X26_v7 (System.Object)+10]");
									obj36 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
									_ = clanLogoBuilder.Tier;
									object obj37 = obj29 + 16;
									obj37 = obj35;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
									List<object> layers = (List<object>)(object)clanLogoBuilder.layers;
									bool flag9 = clanLogoBuilder.layers == null;
									obj4 = obj35;
									if (!flag9)
									{
										obj4 = obj37;
										object obj38 = (nint)0 + (nint)696;
										object obj39 = obj38;
										int version = layers._version + 1;
										layers._version = version;
										object[] items = layers._items;
										if (layers._items != null)
										{
											bool flag10 = layers._size < items.Length;
											object obj40 = !flag10;
											if (obj40 == null)
											{
												int size = layers._size + 1;
												layers._size = size;
												object obj41 = layers._items + layers._size;
												object obj42 = obj41 + 32;
												obj42 = obj37;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
											}
											else
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v982 @ X8_v65+20]");
												object obj43 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v993 @ X8_v137+C0]");
												object obj44 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v994 @ X8_v138+70]");
												num2 = 0;
												((List<object>)(object)clanLogoBuilder.layers).AddWithResize(obj37);
											}
											object obj45 = typeof(MemberAchievementClanFeedData) + 2976;
											object obj46 = obj45;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1002 @ X0_v98+E4]");
											bool flag11 = (nint)0 == 0;
											object obj47 = !flag11;
											if (obj47 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
											}
											object obj48 = (nint)0 + (nint)496;
											num = (nint)obj48;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9D50");
											if (obj37 != null)
											{
												object obj49 = obj37 + 72;
												obj49 = obj50;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
												if (obj50 != null)
												{
													object obj51 = obj50 + 184;
													obj51 = <>4__this;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
													object obj52 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 1192;
													object obj53 = obj52;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1037 @ X0_v111+E4]");
													bool flag12 = (nint)0 == 0;
													object obj54 = !flag12;
													if (obj54 == null)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
													}
													AsyncTaskMethodBuilder asyncTaskMethodBuilder = AsyncTaskMethodBuilder.Create();
													object obj55 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref stateMachine, 8));
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
													object obj56 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref stateMachine, 32));
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
													object obj57 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref stateMachine, 40));
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
													object obj58 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref stateMachine, 56));
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
													object obj59 = (nint)0 + (nint)2744;
													num = (nint)obj59;
													AsyncTaskMethodBuilder asyncTaskMethodBuilder2 = (AsyncTaskMethodBuilder)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref stateMachine, 8));
													((AsyncTaskMethodBuilder*)asyncTaskMethodBuilder2)->Start(ref stateMachine);
													AsyncTaskMethodBuilder asyncTaskMethodBuilder3 = (AsyncTaskMethodBuilder)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref stateMachine, 8));
													task = ((AsyncTaskMethodBuilder*)asyncTaskMethodBuilder3)->Task;
													if (list != null)
													{
														object obj60 = (nint)0 + (nint)528;
														object obj61 = obj60;
														int version2 = list._version + 1;
														list._version = version2;
														<Initialize>d__ = (<Initialize>d__71)list._items;
														if (list._items != null)
														{
															int size2 = list._size;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X9_v10 (ClanLogoBuilder+<Initialize>d__71)+18]");
															bool flag13 = (nint)size2 < (nint)0;
															object obj62 = !flag13;
															if (obj62 == null)
															{
																int size3 = list._size + 1;
																list._size = size3;
																object obj63 = list._items + list._size;
																object obj64 = obj63 + 32;
																obj64 = task;
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
															}
															else
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1071 @ X8_v85+20]");
																object obj65 = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1080 @ X8_v133+C0]");
																object obj66 = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1081 @ X8_v134+70]");
																num = 0;
																list.AddWithResize((object)task);
															}
															object obj67 = typeof(TypeConverter<ushort, char>) + 512;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
															object obj68 = 0;
															num = (nint)obj68;
															unityAction3..ctor(obj29, (IntPtr)obj68);
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1010 @ X0_v101 (System.Object)+78]");
															if ((nint)0 == 0)
															{
																goto IL_1459;
															}
															object obj69 = (nint)0 + (nint)1328;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1010 @ X0_v101 (System.Object)+78]");
															((UnityEvent<System.Int32Enum, int>)0).AddListener(unityAction3);
															object obj70 = typeof(TypeConverter<ushort, char>) + 512;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
															object obj71 = (nint)0 + (nint)8;
															num = (nint)obj71;
															unityAction4..ctor(obj29, (IntPtr)obj71);
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1010 @ X0_v101 (System.Object)+80]");
															if ((nint)0 == 0)
															{
																goto IL_14a9;
															}
															object obj72 = (nint)0 + (nint)1328;
															num = (nint)obj72;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1010 @ X0_v101 (System.Object)+80]");
															((UnityEvent<System.Int32Enum, int>)0).AddListener(unityAction4);
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1010 @ X0_v101 (System.Object)+30]");
															object obj73 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1010 @ X0_v101 (System.Object)+30]");
															if ((nint)0 == 0)
															{
																goto IL_1481;
															}
															object obj74 = typeof(TypeConverter<ushort, char>) + 520;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
															object obj75 = (nint)0 + (nint)16;
															num = (nint)obj75;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4028B68");
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v506 @ X8_v99+40]");
															if ((nint)0 == 0)
															{
																goto IL_14d1;
															}
															object obj76 = (nint)0 + (nint)1344;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @402E7BC");
															object obj77 = typeof(TypeConverter<ushort, char>) + 408;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
															object obj78 = (nint)0 + (nint)24;
															num = (nint)obj78;
															unityAction5..ctor(obj29, (IntPtr)obj78);
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1010 @ X0_v101 (System.Object)+88]");
															if ((nint)0 == 0)
															{
																goto IL_1431;
															}
															object obj79 = (nint)0 + (nint)968;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1010 @ X0_v101 (System.Object)+88]");
															((UnityEvent<int>)0).AddListener(unityAction5);
															object obj80 = typeof(TypeConverter<ushort, char>) + 536;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
															object obj81 = (nint)0 + (nint)32;
															num = (nint)obj81;
															unityAction6..ctor(obj29, (IntPtr)obj81);
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1010 @ X0_v101 (System.Object)+90]");
															if ((nint)0 == 0)
															{
																goto IL_14f9;
															}
															object obj82 = (nint)0 + (nint)1360;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1010 @ X0_v101 (System.Object)+90]");
															((UnityEvent<Vector2, object>)0).AddListener(unityAction6);
															object obj83 = typeof(TypeConverter<ushort, char>) + 536;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
															object obj84 = (nint)0 + (nint)40;
															num = (nint)obj84;
															unityAction7..ctor(obj29, (IntPtr)obj84);
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1010 @ X0_v101 (System.Object)+98]");
															if ((nint)0 == 0)
															{
																goto IL_1549;
															}
															object obj85 = (nint)0 + (nint)1360;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1010 @ X0_v101 (System.Object)+98]");
															((UnityEvent<Vector2, object>)0).AddListener(unityAction7);
															object obj86 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
															object obj87 = (nint)0 + (nint)48;
															num = (nint)obj87;
															unityAction8..ctor(obj29, (IntPtr)obj87);
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1010 @ X0_v101 (System.Object)+A0]");
															if ((nint)0 == 0)
															{
																goto IL_1521;
															}
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1010 @ X0_v101 (System.Object)+A0]");
															((UnityEvent)0).AddListener(unityAction8);
															object obj88 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
															object obj89 = (nint)0 + (nint)56;
															num = (nint)obj89;
															unityAction9..ctor(obj29, (IntPtr)obj89);
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1010 @ X0_v101 (System.Object)+A8]");
															if ((nint)0 != 0)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1010 @ X0_v101 (System.Object)+A8]");
																((UnityEvent)0).AddListener(unityAction9);
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ X26_v7 (System.Object)+10]");
																obj24 = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ X26_v7 (System.Object)+10]");
																bool flag14 = (nint)0 == 0;
																object obj90 = !flag14;
																obj8 = 0;
																obj10 = 0;
																num = 0;
																obj4 = unityAction9;
																stateMachine = (ClanLogoImageSelector.<Initialize>d__30)4294967295L;
																obj9 = 0;
																obj25 = 0;
																num2 = 0;
																obj12 = unityAction9;
																if (obj90 != null)
																{
																	continue;
																}
																goto IL_0f55;
															}
															goto IL_1571;
														}
													}
													goto IL_13c3;
												}
												goto IL_13e2;
											}
											goto IL_13f8;
										}
									}
									goto IL_13ad;
								}
								goto IL_1416;
							}
							obj11++;
							bool flag15 = (nint)obj11 >= layerConfigs.Length;
							obj8 = obj9;
							obj10 = obj25;
							num = num2;
							obj4 = obj12;
							if (!flag15)
							{
								continue;
							}
							goto IL_0f73;
						}
						ex = new NullReferenceException();
						obj9 = obj8;
						obj25 = obj10;
						num = num2;
						obj4 = obj12;
					}
					else
					{
						ex = new NullReferenceException();
					}
				}
				else
				{
					ex = new NullReferenceException();
					int num3 = default(int);
					num = num3;
					IntPtr intPtr = default(IntPtr);
					obj4 = (nint)intPtr;
				}
				goto IL_16e3;
			}
			<>u__1 = (TaskAwaiter)0;
			<>1__state = -1;
			TaskAwaiter awaiter = <>u__1;
			goto IL_184b;
			IL_14a9:
			ex = new NullReferenceException();
			obj9 = 0;
			obj25 = 0;
			obj4 = obj29;
			goto IL_16e3;
			IL_15f3:
			ex = new NullReferenceException();
			obj9 = obj8;
			obj25 = obj10;
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v743 @ X8_v39+v333 @ X24_v7*8]");
			obj4 = 0;
			goto IL_16e3;
			IL_1549:
			ex = new NullReferenceException();
			obj9 = 0;
			obj25 = 0;
			obj4 = obj29;
			goto IL_16e3;
			IL_162a:
			ex = new NullReferenceException();
			obj9 = 0;
			obj25 = obj10;
			obj4 = obj18;
			goto IL_16e3;
			IL_14d1:
			ex = new NullReferenceException();
			obj9 = 0;
			obj25 = 0;
			obj4 = obj29;
			goto IL_16e3;
			IL_13c3:
			ex = new NullReferenceException();
			obj25 = 0;
			obj4 = task;
			goto IL_16e3;
			IL_1571:
			ex = new NullReferenceException();
			obj9 = 0;
			obj25 = 0;
			obj4 = obj29;
			goto IL_16e3;
			IL_1416:
			ex = new NullReferenceException();
			num = num2;
			obj4 = null;
			goto IL_16e3;
			IL_0f73:
			if ((object)clanLogoBuilder.previewer != null)
			{
				clanLogoBuilder.previewer.Initialize(clanLogoBuilder.layers, clanLogoBuilder.Tier);
				<>4__this.ApplyLayerSiblingOrder();
				<>4__this.UpdateBelowMinButtons();
				object obj91 = typeof(System.Formats.Asn1.SetOfValueComparer) + 3912;
				object obj92 = obj91;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v822 @ X0_v57+E4]");
				bool flag16 = (nint)0 == 0;
				object obj93 = !flag16;
				if (obj93 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Task task2 = Task.WhenAll((IEnumerable<Task>)list);
				if (task2 != null)
				{
					TaskAwaiter awaiter2 = task2.GetAwaiter();
					bool isCompleted = awaiter.IsCompleted;
					bool flag17 = !isCompleted;
					object obj94 = !flag17;
					if (obj94 == null)
					{
						<>1__state = 0;
						object obj95 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 48));
						obj95 = awaiter;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						AsyncVoidMethodBuilder asyncVoidMethodBuilder = (AsyncVoidMethodBuilder)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
						((AsyncVoidMethodBuilder*)asyncVoidMethodBuilder)->AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_184b;
				}
				ex = new NullReferenceException();
				num = clanLogoBuilder.Tier;
				obj4 = null;
			}
			else
			{
				ex = new NullReferenceException();
			}
			goto IL_16e3;
			IL_1521:
			ex = new NullReferenceException();
			obj9 = 0;
			obj25 = 0;
			obj4 = obj29;
			goto IL_16e3;
			IL_1481:
			ex = new NullReferenceException();
			obj9 = 0;
			obj25 = 0;
			obj4 = unityAction4;
			goto IL_16e3;
			IL_184b:
			awaiter.GetResult();
			object obj96 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj97 = obj96;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X0_v4+E4]");
			bool flag18 = (nint)0 == 0;
			object obj98 = !flag18;
			if (obj98 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag19 = <>4__this == null;
			bool flag20 = !flag19;
			object obj99 = !flag20;
			if (obj99 == null)
			{
				if ((object)<>4__this == null)
				{
					ex = new NullReferenceException();
					num = 0;
					obj4 = null;
					goto IL_16e3;
				}
				object obj100 = <>4__this + 257;
				obj100 = 256;
				if (<>4__this.HasIconItems())
				{
					if (clanLogoBuilder._pendingModel != null)
					{
						<>4__this.ApplyModel(clanLogoBuilder._pendingModel);
						nint num4 = 0;
					}
					else
					{
						<>4__this.CaptureCleanSnapshots();
						nint num4 = 0;
					}
					clanLogoBuilder._pendingModel = null;
					object obj101 = <>4__this + 264;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					<>4__this.SetInteractionLocked(locked: false);
				}
				else
				{
					clanLogoBuilder._pendingModel = null;
					object obj102 = <>4__this + 264;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					object obj103 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1240;
					object obj104 = obj103;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v735 @ X0_v16+E4]");
					bool flag21 = (nint)0 == 0;
					object obj105 = !flag21;
					if (obj105 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object message = "Complete" + 2760;
					Toast.Show((string)message, (Vector2)0, 0f);
					<>4__this.Close();
					GameObject gameObject = <>4__this.gameObject;
					object obj106 = typeof(MemberAchievementClanFeedData) + 2976;
					object obj107 = obj106;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v813 @ X0_v22+E4]");
					bool flag22 = (nint)0 == 0;
					object obj108 = !flag22;
					if (obj108 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					UnityEngine.Object.Destroy(gameObject, 1f);
				}
			}
			<>1__state = -2;
			AsyncVoidMethodBuilder asyncVoidMethodBuilder2 = (AsyncVoidMethodBuilder)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
			((AsyncVoidMethodBuilder*)asyncVoidMethodBuilder2)->SetResult();
			return;
			IL_0f55:
			ex = new NullReferenceException();
			obj9 = obj8;
			obj25 = obj10;
			goto IL_16e3;
			IL_13ad:
			ex = new NullReferenceException();
			num = num2;
			goto IL_16e3;
			IL_16e3:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
			return;
			IL_1431:
			ex = new NullReferenceException();
			obj9 = 0;
			obj25 = 0;
			obj4 = obj29;
			goto IL_16e3;
			IL_1459:
			ex = new NullReferenceException();
			obj9 = 0;
			obj25 = 0;
			obj4 = obj29;
			goto IL_16e3;
			IL_13e2:
			ex = new NullReferenceException();
			obj4 = obj50;
			goto IL_16e3;
			IL_14f9:
			ex = new NullReferenceException();
			obj9 = 0;
			obj25 = 0;
			obj4 = obj29;
			goto IL_16e3;
			IL_15c7:
			ex = new NullReferenceException();
			obj9 = obj8;
			obj25 = obj10;
			num = 0;
			obj4 = null;
			goto IL_16e3;
			IL_13f8:
			ex = new NullReferenceException();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ X26_v7 (System.Object)+20]");
			obj4 = 0;
			goto IL_16e3;
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		private unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//IL_000b: Expected O, but got Ref
			AsyncVoidMethodBuilder asyncVoidMethodBuilder = (AsyncVoidMethodBuilder)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
			((AsyncVoidMethodBuilder*)asyncVoidMethodBuilder)->SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	private const string DISCARD_TITLE_KEY = "clan_logo_discard_title";

	private const string DISCARD_BODY_KEY = "clan_logo_discard_body";

	private const string DISCARD_CONFIRM_KEY = "clan_logo_discard_confirm";

	private const string CANCEL_KEY = "Cancel";

	private Action<ClanLogoModel> m_OnSaved;

	private StatSlider RotationSlider;

	private StatSlider SizeSlider;

	private Button UndoButton;

	private Button InverseButton;

	private LayerConfigReferences[] layerConfigs;

	private ClanLogoPreviewer previewer;

	private TabsUI layerTabs;

	private List<IconLayer> layers;

	private Transform popupsParent;

	private GameObject inputBlocker;

	private GameObject MovementControlsContainer;

	private Button MoveUpButton;

	private Button MoveDownButton;

	private Button MoveLeftButton;

	private Button MoveRightButton;

	private float MoveStep;

	private float MoveRepeatRate;

	private int Tier;

	private int maxUndoCount;

	private float reorderTweenDuration;

	private IconLayer _selectedLayer;

	private Vector2 _currentMoveDirection;

	private Vector2 _moveStartPosition;

	private float _moveTimer;

	private readonly LinkedList<UndoEntry> _undoStack;

	private readonly Dictionary<IconLayer, LayerSnapshot> _cleanSnapshots;

	private readonly Dictionary<ClanLogoLayer, List<Vector2>> _slotPositions;

	private readonly List<IconLayer> _dragGroupBuffer;

	private readonly List<IconLayer> _dragPreviewBuffer;

	private bool _layoutsCaptured;

	private bool _initialLoad;

	private bool _selectorsReady;

	private ClanLogoModel _pendingModel;

	private SlideAnimationHelper _slideAnim;

	public int CurrentTier => Tier;

	public Transform PopupsParent => popupsParent;

	private SlideAnimationHelper SlideAnim
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00fc: Expected O, but got I4
			//IL_0164: Expected O, but got I
			//IL_017e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0183: Expected O, but got Unknown
			//IL_014a: Expected O, but got I4
			object obj = 152993792;
			object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E88E0]");
			object obj3 = (nint)0 & (nint)1;
			UnityEngine.Object slideAnim;
			UnityEngine.Object slideAnim2;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v7+E4]");
				bool flag = (nint)0 == 0;
				slideAnim = _slideAnim;
				slideAnim2 = _slideAnim;
				if (!flag)
				{
					goto IL_0091;
				}
			}
			else
			{
				_ = 1;
				slideAnim = _slideAnim;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v7+E4]");
				bool flag2 = (nint)0 == 0;
				object obj5 = !flag2;
				slideAnim2 = _slideAnim;
				if (obj5 != null)
				{
					goto IL_0091;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = slideAnim2;
			bool flag4 = !flag3;
			object obj6 = !flag4;
			if (obj6 != null)
			{
				goto IL_00bb;
			}
			goto IL_0158;
			IL_00bb:
			return _slideAnim;
			IL_0158:
			object obj7 = (nint)0 + (nint)56;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
			SlideAnimationHelper slideAnimationHelper = default(SlideAnimationHelper);
			_slideAnim = slideAnimationHelper;
			object obj8 = this + 272;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			return slideAnimationHelper;
			IL_0091:
			if ((bool)slideAnim)
			{
				goto IL_00bb;
			}
			goto IL_0158;
		}
	}

	public bool HasUnsavedChanges
	{
		get
		{
			//IL_00ad: Expected I4, but got O
			//IL_0050: Expected O, but got I
			//IL_0060: Unknown result type (might be due to invalid IL or missing references)
			//IL_0065: Expected O, but got Unknown
			//IL_008d: Expected O, but got I4
			//IL_0095: Unknown result type (might be due to invalid IL or missing references)
			//IL_009a: Expected I4, but got Unknown
			LinkedList<UndoEntry> undoStack = _undoStack;
			if (_undoStack != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X8_v3 (System.Collections.Generic.LinkedList`1<ClanLogoBuilder+UndoEntry>)+18]");
				bool flag = (nint)0 < (nint)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X8_v3 (System.Collections.Generic.LinkedList`1<ClanLogoBuilder+UndoEntry>)+18]");
				bool flag2 = (nint)0 == 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X8_v3 (System.Collections.Generic.LinkedList`1<ClanLogoBuilder+UndoEntry>)+18]");
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X8_v3 (System.Collections.Generic.LinkedList`1<ClanLogoBuilder+UndoEntry>)+18]");
				object obj = num ^ 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X8_v3 (System.Collections.Generic.LinkedList`1<ClanLogoBuilder+UndoEntry>)+18]");
				object obj2 = 0 & obj;
				bool flag3 = (nint)obj2 < 0;
				bool flag4 = flag == flag3;
				object obj3 = !flag2;
				return (byte)((flag4 & obj3) ? 1 : 0) != 0;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	public event Action<ClanLogoModel> OnSaved
	{
		add
		{
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Expected O, but got Unknown
			//IL_000e: Expected O, but got I4
			//IL_0065: Expected O, but got I4
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1528;
			object obj2 = this + 32;
			Delegate obj3 = (Delegate)obj2;
			object obj6 = default(object);
			bool flag2;
			Delegate obj8 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Combine(obj3, value);
				if ((object)obj4 == null)
				{
					object obj5 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj6 == null;
					object obj7 = !flag;
					object obj5 = obj6;
					if (obj7 == null)
					{
						throw new InvalidCastException();
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj8 == obj3;
				obj3 = obj8;
			}
			while (!flag2);
		}
		remove
		{
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Expected O, but got Unknown
			//IL_000e: Expected O, but got I4
			//IL_0065: Expected O, but got I4
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1528;
			object obj2 = this + 32;
			Delegate obj3 = (Delegate)obj2;
			object obj6 = default(object);
			bool flag2;
			Delegate obj8 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Remove(obj3, value);
				if ((object)obj4 == null)
				{
					object obj5 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj6 == null;
					object obj7 = !flag;
					object obj5 = obj6;
					if (obj7 == null)
					{
						throw new InvalidCastException();
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj8 == obj3;
				obj3 = obj8;
			}
			while (!flag2);
		}
	}

	private unsafe void Start()
	{
		//IL_0222: Expected O, but got I
		//IL_02f6: Expected O, but got I
		//IL_030e: Expected O, but got Ref
		//IL_0013: Expected O, but got I
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_0061: Expected O, but got I
		//IL_0079: Expected I, but got O
		//IL_008a: Expected O, but got I
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected O, but got Unknown
		//IL_00cb: Expected O, but got I
		//IL_00e3: Expected I, but got O
		//IL_00f4: Expected O, but got I
		//IL_0133: Expected O, but got I
		//IL_014b: Expected I, but got O
		//IL_017d: Expected O, but got I
		//IL_0195: Expected I, but got O
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Expected O, but got Unknown
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Expected O, but got Unknown
		//IL_0271: Expected O, but got I
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_0285: Expected O, but got Unknown
		//IL_02b2: Expected O, but got I
		//IL_02da: Expected I, but got O
		//IL_01ef: Expected O, but got I4
		object obj = (nint)0 + (nint)1000;
		AsyncVoidMethodBuilder asyncVoidMethodBuilder = AsyncVoidMethodBuilder.Create();
		<Initialize>d__71 stateMachine = default(<Initialize>d__71);
		object obj2 = (nint)(&stateMachine) | (nint)8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj3 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref stateMachine, 40));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		AsyncVoidMethodBuilder asyncVoidMethodBuilder2 = (AsyncVoidMethodBuilder)((nint)(&stateMachine) | (nint)8);
		((AsyncVoidMethodBuilder*)asyncVoidMethodBuilder2)->Start(ref stateMachine);
		StatSlider sizeSlider = SizeSlider;
		Slider slider = sizeSlider.slider;
		object obj4 = typeof(TypeConverter<ushort, char>) + 440;
		object obj5 = (nint)0 + (nint)1248;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction<float> unityAction = default(UnityAction<float>);
		unityAction..ctor((object)this, (IntPtr)obj5);
		object obj6 = (nint)0 + (nint)1112;
		slider.m_OnValueChanged.AddListener(unityAction);
		StatSlider sizeSlider2 = SizeSlider;
		object obj7 = typeof(TypeConverter<ushort, char>) + 344;
		object obj8 = (nint)0 + (nint)1208;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction<object> unityAction2 = default(UnityAction<object>);
		unityAction2..ctor((object)this, (IntPtr)obj8);
		object direction = (nint)0 + (nint)784;
		((UnityEvent<object>)(object)sizeSlider2.OnSliderLetGo).AddListener(unityAction2);
		StatSlider rotationSlider = RotationSlider;
		Slider slider2 = rotationSlider.slider;
		object obj9 = (nint)0 + (nint)1240;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction<float> unityAction3 = default(UnityAction<float>);
		unityAction3..ctor((object)this, (IntPtr)obj9);
		slider2.m_OnValueChanged.AddListener(unityAction3);
		StatSlider rotationSlider2 = RotationSlider;
		object obj10 = (nint)0 + (nint)1216;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction<object> unityAction4 = default(UnityAction<object>);
		unityAction4..ctor((object)this, (IntPtr)obj10);
		((UnityEvent<object>)(object)rotationSlider2.OnSliderLetGo).AddListener(unityAction4);
		object obj11 = typeof(UsageHint) + 744;
		SetupMoveButton(MoveUpButton, (Vector2)direction);
		SetupMoveButton(MoveDownButton, (Vector2)direction);
		object obj12 = typeof(SqlSingle[]) + 2376;
		object obj13 = (nint)0 + (nint)1232;
		object obj14 = typeof(RegisteredWaitHandle) + 56;
		SetupMoveButton(MoveLeftButton, (Vector2)direction);
		object obj15 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X8_v28+B8]");
		object obj16 = 0;
		SetupMoveButton(MoveRightButton, (Vector2)direction);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj13);
		object obj17 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X0_v34+E4]");
		bool flag = (nint)0 == 0;
		object obj18 = !flag;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		RemoteConfig.OnChanged += action;
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_006a: Expected I, but got O
		//IL_0094: Expected O, but got I4
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)1232;
		object obj3 = typeof(RegisteredWaitHandle) + 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		RemoteConfig.OnChanged -= action;
	}

	private void OnRemoteConfigChanged()
	{
		//IL_0012: Expected O, but got I
		//IL_001e: Expected O, but got I
		//IL_0177: Expected I, but got O
		//IL_00ef: Expected I, but got O
		//IL_003b: Expected O, but got I4
		//IL_00a1: Expected O, but got I4
		List<Color> list = BuildEmblemColorPresets();
		bool flag = layers == null;
		ClanLogoBuilder clanLogoBuilder = this;
		List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
		nint num = default(nint);
		if (!flag)
		{
			object obj = (nint)0 + (nint)2056;
			clanLogoBuilder = (ClanLogoBuilder)((nint)0 + (nint)2048);
			List<object>.Enumerator enumerator = ((List<object>)(object)layers).GetEnumerator();
			num = (nint)obj;
			if (!enumerator2.MoveNext())
			{
				enumerator2.Dispose();
				return;
			}
			object obj2 = 0;
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
			num = (nint)clanLogoBuilder;
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
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223E080");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
	}

	private void Update()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00bf: Expected O, but got I
		//IL_0046: Invalid comparison between F4 and I4
		//IL_0057: Expected O, but got I4
		//IL_0060: Invalid comparison between F4 and I4
		//IL_0071: Expected O, but got I4
		//IL_0096: Expected O, but got I
		object obj = typeof(UsageHint) + 744;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v3+B8]");
		object obj3 = 0;
		object obj4 = (object)_currentMoveDirection - obj3;
		object obj5 = obj4 * obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
		if ((nint)obj5 >= 786163454)
		{
			float deltaTime = Time.deltaTime;
			float num = (_moveTimer -= deltaTime);
			bool flag = num < 0f;
			object obj6 = !flag;
			bool flag2 = num == 0f;
			object obj7 = !flag2;
			object obj8 = obj6 & obj7;
			if (obj8 == null)
			{
				IntPtr intPtr = default(IntPtr);
				MoveLayer((Vector2)(nint)intPtr);
				_moveTimer = MoveRepeatRate;
			}
		}
	}

	public void SetLayerOrderInGroup(IconLayer layer, int newOrderInGroup, bool addUndo = false)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		//IL_004b: Expected O, but got I
		//IL_007a: Expected I, but got O
		//IL_00b0: Expected O, but got I
		//IL_00d3: Expected I4, but got I8
		//IL_00ed: Expected O, but got I4
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Expected O, but got Unknown
		//IL_01b3: Expected O, but got I
		//IL_01c3: Expected O, but got I
		//IL_01e5: Expected O, but got I4
		//IL_014c: Expected O, but got I
		//IL_015c: Expected O, but got I
		//IL_017e: Expected O, but got I4
		//IL_0215: Expected O, but got I4
		//IL_047b: Expected O, but got I
		//IL_048c: Expected I, but got O
		//IL_04aa: Expected O, but got I
		//IL_04e4: Expected O, but got I4
		//IL_0508: Unknown result type (might be due to invalid IL or missing references)
		//IL_050d: Expected I4, but got Unknown
		//IL_0542: Expected O, but got I4
		//IL_0245: Expected O, but got I
		//IL_0566: Expected O, but got I4
		//IL_058a: Unknown result type (might be due to invalid IL or missing references)
		//IL_058f: Expected I4, but got Unknown
		//IL_05c4: Expected O, but got I4
		//IL_039a: Expected O, but got I
		object obj = typeof(CardUtils.<>c) + 952;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		<>c__DisplayClass53_0 <>c__DisplayClass53_ = default(<>c__DisplayClass53_0);
		<>c__DisplayClass53_..ctor();
		if (layer == null)
		{
			return;
		}
		LogoLayerConfig layerConfig = layer.layerConfig;
		object obj2 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1736;
		object obj3 = (nint)0 + (nint)4056;
		<>c__DisplayClass53_.enumGroup = layerConfig.Layer;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<object, bool> func = default(Func<object, bool>);
		func..ctor((object)<>c__DisplayClass53_, (IntPtr)obj3);
		IEnumerable<object> source = Enumerable.Where(layers, func);
		List<object> list = Enumerable.ToList(source);
		object obj4 = (nint)0 + (nint)728;
		int num = list.IndexOf(layer);
		int num2 = (int)(num & 0x80000000L);
		bool flag = num2 == 0;
		object obj5 = !flag;
		if (obj5 != null)
		{
			return;
		}
		object obj6 = typeof(CardUtils.<>c) + 936;
		object obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X0_v31+E4]");
		object obj8;
		Func<object, bool> predicate;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X0_v31+B8]");
			obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X8_v30+8]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X8_v30+8]");
			bool flag2 = (nint)0 == 0;
			object obj9 = !flag2;
			if (obj9 == null)
			{
				goto IL_01f3;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X0_v31+B8]");
			obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X8_v30+8]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X8_v30+8]");
			bool flag3 = (nint)0 == 0;
			object obj10 = !flag3;
			if (obj10 == null)
			{
				goto IL_01f3;
			}
		}
		goto IL_024a;
		IL_024a:
		int num3 = Enumerable.Count(list, predicate);
		int num4;
		int num5;
		if (layer.IsNotNull)
		{
			num4 = 0;
			num5 = num3;
		}
		else
		{
			num5 = list._size;
			num4 = num3;
		}
		int num6 = num5 - 1;
		object obj11 = newOrderInGroup - num6;
		bool flag4 = (nint)obj11 < 0;
		int num7 = newOrderInGroup ^ num6;
		int num8 = newOrderInGroup ^ obj11;
		int num9 = num7 & num8;
		bool flag5 = num9 < 0;
		bool flag6 = flag4 == flag5;
		object obj12 = !flag6;
		object obj13 = ~obj12;
		if (obj13 == null)
		{
			num6 = newOrderInGroup;
		}
		object obj14 = newOrderInGroup - num4;
		bool flag7 = (nint)obj14 < 0;
		int num10 = newOrderInGroup ^ num4;
		int num11 = newOrderInGroup ^ obj14;
		int num12 = num10 & num11;
		bool flag8 = num12 < 0;
		bool flag9 = flag7 == flag8;
		object obj15 = !flag9;
		object obj16 = ~obj15;
		int num13 = ((obj16 != null) ? num6 : num4);
		if (num13 == num)
		{
			return;
		}
		list.RemoveAt(num);
		list.Insert(num13, layer);
		List<object> list2 = (List<object>)(object)layers;
		int num14 = 0;
		int num15 = 0;
		while (num14 < list2._size)
		{
			object obj17 = list2.get_Item(num14);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X0_v25 (System.Object)+18]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X8_v23+18]");
			if ((nint)0 == (nint)<>c__DisplayClass53_.enumGroup)
			{
				object value = list.get_Item(num15);
				num15++;
				((List<object>)(object)layers).set_Item(num14, value);
			}
			num14++;
			list2 = (List<object>)(object)layers;
		}
		ApplyLayerSiblingOrder();
		if (addUndo)
		{
			AddUndo(layer);
		}
		return;
		IL_01f3:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X0_v31+E4]");
		bool flag10 = (nint)0 == 0;
		object obj19 = !flag10;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj20 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X8_v34+B8]");
			obj8 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj21 = (nint)0 + (nint)4024;
		Func<object, bool> func2 = default(Func<object, bool>);
		func2..ctor(obj8, (IntPtr)obj21);
		object obj22 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v359 @ X8_v33+B8]");
		object obj23 = (nint)0 + (nint)8;
		obj23 = func2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		predicate = func2;
		goto IL_024a;
	}

	public unsafe void Undo()
	{
		//IL_0010: Expected F4, but got I
		//IL_0827: Expected O, but got I4
		//IL_0830: Expected O, but got I4
		//IL_004a: Expected F4, but got I
		//IL_006b: Expected O, but got I4
		//IL_0074: Expected O, but got I4
		//IL_07b5: Expected I, but got O
		//IL_01b7: Expected O, but got I4
		//IL_01c8: Expected F4, but got I4
		//IL_01cd: Expected I, but got O
		//IL_008e: Expected O, but got I
		//IL_009e: Expected O, but got I
		//IL_00a6: Expected I, but got O
		//IL_00d2: Expected O, but got I4
		//IL_01f6: Expected O, but got Ref
		//IL_020f: Expected F4, but got I4
		//IL_0218: Expected F4, but got I4
		//IL_0220: Expected O, but got Ref
		//IL_0229: Expected F4, but got I4
		//IL_0239: Expected I, but got O
		//IL_00ed: Expected O, but got I
		//IL_00f9: Expected O, but got I
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected O, but got Unknown
		//IL_0119: Expected O, but got I
		//IL_012a: Expected O, but got I
		//IL_0136: Expected F4, but got Ref
		//IL_0854: Expected I, but got O
		//IL_025f: Expected F4, but got I
		//IL_0181: Expected O, but got F4
		//IL_018a: Expected O, but got I4
		//IL_0144: Invalid comparison between F4 and I4
		//IL_0411: Expected I, but got O
		//IL_02b1: Expected O, but got I4
		//IL_02c5: Expected I, but got O
		//IL_074e: Expected O, but got F4
		//IL_075f: Expected O, but got I4
		//IL_02f6: Expected F4, but got I4
		//IL_02ff: Expected F4, but got I4
		//IL_0307: Expected I, but got O
		//IL_0320: Expected F4, but got I4
		//IL_0331: Expected F4, but got I4
		//IL_0339: Expected I, but got O
		//IL_043d: Expected F4, but got I4
		//IL_0446: Expected F4, but got I4
		//IL_044f: Expected F4, but got I4
		//IL_055a: Expected F4, but got I4
		//IL_056a: Expected F4, but got O
		//IL_036d: Expected O, but got I4
		//IL_0475: Expected O, but got I
		//IL_0485: Expected O, but got I
		//IL_0492: Expected F4, but got O
		//IL_04a2: Expected F4, but got I
		//IL_04b5: Expected O, but got I4
		//IL_04df: Expected I, but got O
		//IL_04ef: Expected O, but got I
		//IL_04ff: Expected O, but got I
		//IL_050f: Expected F4, but got I
		//IL_051c: Expected F4, but got O
		//IL_0521: Expected I, but got O
		//IL_05c4: Expected F4, but got I4
		//IL_05d1: Expected I, but got O
		//IL_05d9: Expected F4, but got O
		//IL_0694: Expected F4, but got I
		//IL_06b6: Expected O, but got I4
		//IL_0395: Expected F4, but got I4
		//IL_03c7: Expected F4, but got O
		//IL_0638: Expected I, but got O
		//IL_0652: Expected F4, but got I4
		//IL_066c: Expected I, but got O
		//IL_0676: Expected F4, but got O
		//IL_06ef: Expected F4, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8890]");
		float num = 0f;
		LinkedList<UndoEntry> undoStack = _undoStack;
		bool flag = _undoStack == null;
		List<object>.Enumerator enumerator = (List<object>.Enumerator)0;
		IconLayer iconLayer = (IconLayer)152993792;
		object obj3 = default(object);
		object obj4 = default(object);
		object obj5 = default(object);
		float num4 = default(float);
		LayerSnapshot layerSnapshot;
		nint num2 = default(nint);
		float num3 = default(float);
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v2 (System.Collections.Generic.LinkedList`1<ClanLogoBuilder+UndoEntry>)+18]");
			if ((nint)0 == 0)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v2 (System.Collections.Generic.LinkedList`1<ClanLogoBuilder+UndoEntry>)+10]");
			num = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v2 (System.Collections.Generic.LinkedList`1<ClanLogoBuilder+UndoEntry>)+10]");
			bool flag2 = (nint)0 == 0;
			enumerator = (List<object>.Enumerator)0;
			iconLayer = (IconLayer)152993792;
			if (!flag2)
			{
				object obj = (nint)0 + (nint)544;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X8_v5 (System.Single)+28]");
				iconLayer = (IconLayer)0;
				num2 = (nint)obj;
				_undoStack.RemoveFirst();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X8_v5 (System.Single)+30]");
				bool flag3 = (nint)0 == 0;
				enumerator = (List<object>.Enumerator)0;
				if (!flag3)
				{
					object obj2 = (nint)0 + (nint)3136;
					obj3 = (nint)0 + (nint)3384;
					obj4 = typeof(MemberAchievementClanFeedData) + 2976;
					obj5 = (nint)0 + (nint)3128;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X8_v5 (System.Single)+30]");
					List<object>.Enumerator enumerator2 = ((List<object>)0).GetEnumerator();
					List<object>.Enumerator enumerator3 = default(List<object>.Enumerator);
					num = (nint)(&enumerator3);
					while (true)
					{
						num2 = (nint)obj2;
						if (!enumerator3.MoveNext())
						{
							break;
						}
						if (num3 != 0f)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v131 @ stack_-70_v3 (System.Single)+18] (should have been resolved before IL gen)");
							num = num3;
							continue;
						}
						goto IL_073b;
					}
					enumerator3.Dispose();
					enumerator = (List<object>.Enumerator)num4;
					layerSnapshot = (LayerSnapshot)0;
					goto IL_018f;
				}
			}
		}
		goto IL_083e;
		IL_073b:
		NullReferenceException ex = new NullReferenceException();
		enumerator = (List<object>.Enumerator)num4;
		float num5 = num4;
		layerSnapshot = (LayerSnapshot)0;
		num = num3;
		goto IL_083e;
		IL_083e:
		NullReferenceException ex2 = new NullReferenceException();
		bool flag4 = num2 != 1;
		NullReferenceException ex3 = ex2;
		if (!flag4)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			num2 = (nint)obj5;
			enumerator.Dispose();
			object obj6 = default(object);
			bool flag5 = obj6 == null;
			layerSnapshot = (LayerSnapshot)obj6;
			if (flag5)
			{
				goto IL_018f;
			}
			OutOfMemoryException ex4 = new OutOfMemoryException();
			layerSnapshot = (LayerSnapshot)obj6;
			ex3 = (NullReferenceException)(object)ex4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223E0C0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return;
		IL_0684:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v484 @ X8_v7 (System.Collections.Generic.LinkedList`1<ClanLogoBuilder+UndoEntry>)+18]");
		num = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v484 @ X8_v7 (System.Collections.Generic.LinkedList`1<ClanLogoBuilder+UndoEntry>)+18]");
		bool flag6 = (nint)0 == 0;
		object obj7 = !flag6;
		object obj8 = default(object);
		object obj9;
		object obj10 = default(object);
		object obj11;
		float num7;
		IconLayer iconLayer3;
		float num8;
		LayerSnapshot layerSnapshot2;
		nint num9;
		float num6;
		IconLayer iconLayer2;
		if (obj7 == null)
		{
			bool flag7 = (object)UndoButton == null;
			obj8 = obj9;
			obj10 = obj11;
			num3 = 0f;
			num6 = num7;
			iconLayer2 = iconLayer3;
			num5 = num8;
			layerSnapshot = layerSnapshot2;
			num2 = num9;
			if (!flag7)
			{
				UndoButton.interactable = false;
				return;
			}
			goto IL_083e;
		}
		return;
		IL_018f:
		layerSnapshot2 = new LayerSnapshot(this, iconLayer);
		bool flag8 = _cleanSnapshots == null;
		object obj12 = 0;
		iconLayer2 = iconLayer;
		num5 = 0f;
		num2 = (nint)this;
		UnityEngine.Object obj15;
		IconLayer selectedLayer;
		if (!flag8)
		{
			obj12 = obj3;
			((Dictionary<object, LayerSnapshot>)(object)_cleanSnapshots).set_Item((object)iconLayer, (LayerSnapshot)(&layerSnapshot));
			bool flag9 = iconLayer == null;
			num3 = 0f;
			num6 = 0f;
			iconLayer2 = (IconLayer)(&layerSnapshot);
			num5 = 0f;
			layerSnapshot = layerSnapshot2;
			num2 = (nint)iconLayer;
			if (!flag9)
			{
				object obj13 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v431 @ X0_v21+E4]");
				num = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v431 @ X0_v21+E4]");
				if ((nint)0 != 0)
				{
					bool flag10 = iconLayer.Selector != null;
					bool flag11 = !flag10;
					object obj14 = !flag11;
					iconLayer3 = null;
					obj15 = null;
					iconLayer2 = null;
					num2 = unchecked((nint)null);
					if (obj14 == null)
					{
						goto IL_02d3;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					bool flag12 = iconLayer.Selector != null;
					bool flag13 = !flag12;
					iconLayer3 = null;
					obj15 = null;
					iconLayer2 = null;
					num2 = unchecked((nint)null);
					if (flag13)
					{
						goto IL_02d3;
					}
				}
				bool flag14 = (object)iconLayer.Selector == null;
				num3 = 0f;
				num6 = 0f;
				num5 = 0f;
				layerSnapshot = layerSnapshot2;
				if (!flag14)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X20_v5 (IconLayer)+38]");
					obj10 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X20_v5 (IconLayer)+3C]");
					obj8 = 0;
					num8 = (float)iconLayer.Color;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X20_v5 (IconLayer)+34]");
					num7 = 0f;
					iconLayer.Selector.SetColorSelectorTo((Color)0);
					selectedLayer = _selectedLayer;
					bool flag15 = _selectedLayer != iconLayer;
					iconLayer3 = iconLayer2;
					num9 = unchecked((nint)null);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X20_v5 (IconLayer)+3C]");
					obj9 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X20_v5 (IconLayer)+38]");
					obj11 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X20_v5 (IconLayer)+34]");
					num6 = 0f;
					num5 = (float)iconLayer.Color;
					num2 = unchecked((nint)null);
					if (flag15)
					{
						goto IL_0347;
					}
					goto IL_052f;
				}
			}
		}
		goto IL_083e;
		IL_0347:
		LinkedList<UndoEntry> undoStack2 = _undoStack;
		bool flag16 = _undoStack == null;
		object obj16 = !flag16;
		obj9 = obj8;
		obj11 = obj10;
		if (obj16 != null)
		{
			goto IL_0684;
		}
		num3 = 0f;
		num6 = num7;
		iconLayer2 = iconLayer3;
		num5 = num8;
		layerSnapshot = layerSnapshot2;
		num2 = num9;
		num = (float)_undoStack;
		goto IL_083e;
		IL_02d3:
		selectedLayer = _selectedLayer;
		bool flag17 = _selectedLayer == iconLayer;
		num7 = 0f;
		num8 = 0f;
		num9 = (nint)obj15;
		obj9 = obj8;
		obj11 = obj10;
		num6 = 0f;
		iconLayer2 = iconLayer3;
		num5 = 0f;
		num2 = (nint)obj15;
		if (!flag17)
		{
			goto IL_0347;
		}
		goto IL_052f;
		IL_052f:
		bool flag18 = (object)RotationSlider == null;
		obj8 = obj9;
		obj10 = obj11;
		num3 = 0f;
		layerSnapshot = layerSnapshot2;
		num = (float)selectedLayer;
		if (!flag18)
		{
			num5 = iconLayer.Rotation;
			RotationSlider.value = iconLayer.Rotation;
			bool flag19 = (object)SizeSlider == null;
			obj8 = obj9;
			obj10 = obj11;
			num3 = 0f;
			layerSnapshot = layerSnapshot2;
			num2 = unchecked((nint)null);
			num = (float)selectedLayer;
			if (!flag19)
			{
				num8 = iconLayer.Scale;
				SizeSlider.value = iconLayer.Scale;
				undoStack2 = _undoStack;
				bool flag20 = _undoStack == null;
				num7 = num6;
				iconLayer3 = iconLayer2;
				num9 = unchecked((nint)null);
				obj8 = obj9;
				obj10 = obj11;
				num3 = 0f;
				num5 = iconLayer.Scale;
				layerSnapshot = layerSnapshot2;
				num2 = unchecked((nint)null);
				num = (float)_undoStack;
				if (!flag20)
				{
					goto IL_0684;
				}
			}
		}
		goto IL_083e;
	}

	public unsafe void AddUndo(IconLayer layer)
	{
		//IL_0008: Expected O, but got Ref
		//IL_003f: Expected O, but got I4
		//IL_0081: Expected O, but got Ref
		//IL_00a1: Expected O, but got Ref
		//IL_00d3: Expected O, but got Ref
		//IL_00e5: Expected O, but got Ref
		//IL_011e: Expected O, but got Ref
		//IL_0137: Expected O, but got Ref
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Expected O, but got Unknown
		//IL_017a: Expected O, but got I
		object obj2 = default(object);
		object obj = (object)(&obj2);
		if (layer == null)
		{
			return;
		}
		LayerSnapshot value;
		bool flag = ((Dictionary<object, LayerSnapshot>)(object)_cleanSnapshots).TryGetValue((object)layer, out value);
		bool flag2 = !flag;
		object obj3 = !flag2;
		if (obj3 == null)
		{
			value = new LayerSnapshot(this, layer);
		}
		LayerSnapshot layerSnapshot = new LayerSnapshot(this, layer);
		object obj4 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 96));
		_ = 0;
		_ = 0;
		LayerSnapshot value2 = (LayerSnapshot)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 96));
		((Dictionary<object, LayerSnapshot>)(object)_cleanSnapshots).set_Item((object)layer, value2);
		_ = 0;
		_ = 0;
		LayerSnapshot prev = (LayerSnapshot)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 96));
		LayerSnapshot layerSnapshot2 = default(LayerSnapshot);
		List<Action> list = BuildUndoActions(layer, prev, (LayerSnapshot)(&layerSnapshot2));
		if (list._size != 0)
		{
			object obj5 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 96));
			_ = 0;
			object obj6 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 96));
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj7 = obj5 + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			LinkedList<UndoEntry> undoStack = _undoStack;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X29_v1-60]");
			LinkedListNode<UndoEntry> linkedListNode = undoStack.AddFirst((UndoEntry)0);
			LinkedList<UndoEntry> undoStack2 = _undoStack;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X0_v18 (System.Collections.Generic.LinkedList`1<ClanLogoBuilder+UndoEntry>)+18]");
			if ((nint)0 > (nint)maxUndoCount)
			{
				undoStack2.RemoveLast();
			}
			UndoButton.interactable = true;
		}
	}

	public void ClearUndoHistory()
	{
		//IL_0011: Expected O, but got I
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_00d7: Expected O, but got I4
		object obj = (nint)0 + (nint)536;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		_undoStack.Clear();
		CaptureCleanSnapshots();
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v6+E4]");
		if ((nint)0 != 0)
		{
			if (!(UndoButton != null))
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag = UndoButton != null;
			bool flag2 = !flag;
			object obj4 = !flag2;
			if (obj4 == null)
			{
				return;
			}
		}
		UndoButton.interactable = false;
	}

	public void OnSizeSliderChanged(float value)
	{
		if (_selectedLayer != null)
		{
			_selectedLayer.SetScale(value);
			ClampLayerWithinCircle(_selectedLayer);
			UpdateMovementButtons();
		}
	}

	public void OnRotationSliderChanged(float value)
	{
		if (_selectedLayer != null)
		{
			_selectedLayer.SetRotation(value);
		}
	}

	public void OnInverseClicked()
	{
		InvertLayer(_selectedLayer, addUndo: true);
	}

	public void OnOpenLayerEditor(int index)
	{
		//IL_0044: Expected O, but got I4
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected O, but got Unknown
		//IL_0071: Expected O, but got I
		//IL_00a8: Expected O, but got I
		LayerConfigReferences[] array = layerConfigs;
		if (layerConfigs != null)
		{
			bool flag = index < array.Length;
			object obj = !flag;
			if (obj != null)
			{
				goto IL_00b7;
			}
			object obj2 = layerConfigs + index;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v4+20]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v4+20]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X8_v5+10]");
				OnOpenLayerEditor((LogoLayerConfig)0);
				return;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_00b7;
		IL_00b7:
		throw new IndexOutOfRangeException();
	}

	public void OnOpenLayerEditor(LogoLayerConfig config)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0045: Expected O, but got I
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_0085: Expected I, but got O
		//IL_00cc: Expected O, but got I
		//IL_00dd: Expected I, but got O
		object obj = typeof(CardUtils.<>c) + 960;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		<>c__DisplayClass61_0 <>c__DisplayClass61_ = default(<>c__DisplayClass61_0);
		<>c__DisplayClass61_..ctor();
		object obj2 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1736;
		object obj3 = (nint)0 + (nint)4064;
		object obj4 = (nint)0 + (nint)2616;
		object obj5 = <>c__DisplayClass61_ + 16;
		obj5 = config;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<object, bool> func = default(Func<object, bool>);
		func..ctor((object)<>c__DisplayClass61_, (IntPtr)obj3);
		if (Enumerable.Any(layers, func))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj6 = (nint)0 + (nint)4072;
			Func<object, bool> func2 = default(Func<object, bool>);
			func2..ctor((object)<>c__DisplayClass61_, (IntPtr)obj6);
			object layer = Enumerable.First(layers, func2);
			SelectLayer((IconLayer)layer);
		}
	}

	public void OpenLayerTransformEditor(LogoLayerConfig config)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_02c8: Expected O, but got I4
		//IL_01f3: Expected O, but got I4
		//IL_0177: Expected O, but got I4
		//IL_0287: Expected O, but got I4
		//IL_018e: Expected O, but got I4
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = config != null;
		GameObject gameObject = RotationSlider.gameObject;
		bool active = flag2 && config.Rotatable;
		gameObject.SetActive(active);
		GameObject gameObject2 = SizeSlider.gameObject;
		bool active2 = flag2 && config.Sizable;
		gameObject2.SetActive(active2);
		GameObject gameObject3 = InverseButton.gameObject;
		bool active3;
		UnityEngine.Object movementControlsContainer;
		UnityEngine.Object movementControlsContainer2;
		bool flag4;
		if (flag2)
		{
			bool sizable = config.Sizable;
			gameObject3.SetActive(config.Sizable);
			active3 = config.Movable;
			movementControlsContainer = MovementControlsContainer;
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X8_v6+E4]");
			bool flag3 = (nint)0 == 0;
			object obj5 = !flag3;
			if (obj5 != null)
			{
				goto IL_021d;
			}
			object obj6 = 0;
			movementControlsContainer2 = MovementControlsContainer;
			flag4 = config.Movable;
		}
		else
		{
			gameObject3.SetActive(value: false);
			movementControlsContainer = MovementControlsContainer;
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X8_v6+E4]");
			bool flag5 = (nint)0 == 0;
			active3 = false;
			object obj6 = 0;
			bool sizable = false;
			movementControlsContainer2 = MovementControlsContainer;
			flag4 = false;
			if (!flag5)
			{
				goto IL_021d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag6 = movementControlsContainer2 != null;
		bool flag7 = !flag6;
		object obj7 = !flag7;
		active3 = flag4;
		if (obj7 == null)
		{
			return;
		}
		goto IL_0244;
		IL_0244:
		MovementControlsContainer.SetActive(active3);
		return;
		IL_021d:
		if (movementControlsContainer != null)
		{
			goto IL_0244;
		}
	}

	public void SelectLayer(IconLayer layer)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected O, but got Unknown
		//IL_00d0: Expected O, but got I4
		//IL_00c2: Expected O, but got I
		//IL_0111: Expected O, but got I
		//IL_0133: Expected O, but got I4
		//IL_0189: Expected F4, but got I
		//IL_01ad: Expected F4, but got I
		//IL_01e7: Expected O, but got I
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Expected O, but got Unknown
		//IL_023c: Expected O, but got I
		//IL_024d: Expected I, but got O
		object obj = typeof(CardUtils.<>c) + 968;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		<>c__DisplayClass63_0 <>c__DisplayClass63_ = default(<>c__DisplayClass63_0);
		<>c__DisplayClass63_..ctor();
		object obj2 = <>c__DisplayClass63_ + 16;
		obj2 = layer;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		if (obj2 != null && !((IconLayer)obj2).IsNotNull)
		{
			return;
		}
		object obj3 = this + 184;
		object obj4 = obj3;
		if (obj3 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X8_v5+48]");
			((ClanLogoImageSelector)0).SetSelectedIndicator(isSelected: false);
		}
		obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = obj2;
		if (obj2 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X8_v6+18]");
			OpenLayerTransformEditor((LogoLayerConfig)0);
			object obj6 = obj2;
			bool flag = obj2 == null;
			object obj7 = !flag;
			if (obj7 == null)
			{
				return;
			}
		}
		else
		{
			OpenLayerTransformEditor(null);
			object obj6 = obj2;
			if (obj2 == null)
			{
				return;
			}
		}
		StatSlider rotationSlider = RotationSlider;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X8_v7+24]");
		rotationSlider.value = 0f;
		object obj8 = obj2;
		StatSlider sizeSlider = SizeSlider;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X8_v8+28]");
		sizeSlider.value = 0f;
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj9 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v9+48]");
		((ClanLogoImageSelector)0).SetSelectedIndicator(isSelected: true);
		UpdateMovementButtons();
		if (!_initialLoad)
		{
			object obj10 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 344;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj11 = (nint)0 + (nint)4080;
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor((object)<>c__DisplayClass63_, (IntPtr)obj11);
			int tabIndex = ArraysExtensions.FindIndex(layerConfigs, func);
			layerTabs.Activate(tabIndex, sendCallback: false);
		}
	}

	public void Open()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0104: Expected O, but got I4
		//IL_016c: Expected O, but got I
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Expected O, but got Unknown
		//IL_0152: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E88E0]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object slideAnim;
		UnityEngine.Object slideAnim2;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v11+E4]");
			bool flag = (nint)0 == 0;
			slideAnim = _slideAnim;
			slideAnim2 = _slideAnim;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			slideAnim = _slideAnim;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v11+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			slideAnim2 = _slideAnim;
			if (obj5 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = slideAnim2;
		bool flag4 = !flag3;
		object obj6 = !flag4;
		if (obj6 != null)
		{
			goto IL_00bb;
		}
		goto IL_0160;
		IL_019a:
		SlideAnimationHelper slideAnim3 = default(SlideAnimationHelper);
		slideAnim3.SlideIn();
		InstallCloseGuard();
		return;
		IL_00bb:
		slideAnim3 = _slideAnim;
		goto IL_019a;
		IL_0160:
		object obj7 = (nint)0 + (nint)56;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		_slideAnim = slideAnim3;
		object obj8 = this + 272;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		goto IL_019a;
		IL_0091:
		if ((bool)slideAnim)
		{
			goto IL_00bb;
		}
		goto IL_0160;
	}

	public void TryClose()
	{
		//IL_0016: Expected O, but got I
		//IL_00c5: Expected O, but got I
		//IL_00df: Expected O, but got I4
		//IL_008c: Expected O, but got I4
		//IL_0049: Expected O, but got I
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Expected O, but got Unknown
		//IL_016e: Expected O, but got I
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Expected O, but got Unknown
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected O, but got Unknown
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Expected O, but got Unknown
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Expected O, but got Unknown
		//IL_052b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0530: Expected O, but got Unknown
		//IL_0546: Unknown result type (might be due to invalid IL or missing references)
		//IL_054b: Expected O, but got Unknown
		//IL_01d2: Expected I, but got O
		//IL_01ea: Expected O, but got I
		//IL_020c: Expected O, but got I4
		//IL_05c1: Expected O, but got I
		//IL_0287: Expected O, but got I4
		//IL_029f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Expected O, but got Unknown
		//IL_02df: Expected O, but got I4
		//IL_02fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0301: Expected O, but got Unknown
		//IL_0309: Expected I, but got O
		//IL_0319: Expected O, but got I
		//IL_03d1: Expected O, but got I4
		//IL_0354: Expected O, but got I
		//IL_03ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f3: Expected O, but got Unknown
		//IL_03fb: Expected I, but got O
		//IL_040b: Expected O, but got I
		//IL_049a: Expected O, but got I4
		//IL_04b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bb: Expected O, but got Unknown
		//IL_04c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c9: Expected O, but got Unknown
		//IL_04f5: Expected O, but got I4
		//IL_0506: Expected O, but got I4
		//IL_0446: Expected O, but got I
		//IL_0362: Unknown result type (might be due to invalid IL or missing references)
		//IL_0367: Expected O, but got Unknown
		//IL_0370: Unknown result type (might be due to invalid IL or missing references)
		//IL_0375: Expected O, but got Unknown
		//IL_0593: Expected O, but got I4
		//IL_059b: Expected O, but got I
		//IL_0454: Unknown result type (might be due to invalid IL or missing references)
		//IL_0459: Expected O, but got Unknown
		//IL_0462: Unknown result type (might be due to invalid IL or missing references)
		//IL_0467: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E88E3]");
		object obj = (nint)0 & (nint)1;
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E88E1]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				goto IL_0066;
			}
		}
		else
		{
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E88E1]");
			object obj3 = (nint)0 & (nint)1;
			bool flag = obj3 == null;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0066;
			}
		}
		_ = 1;
		LinkedList<UndoEntry> undoStack = _undoStack;
		bool flag2 = _undoStack == null;
		LinkedList<UndoEntry> linkedList = _undoStack;
		if (!flag2)
		{
			goto IL_0126;
		}
		goto IL_0514;
		IL_0514:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0522;
		IL_03df:
		object obj5 = typeof(System.IOAsyncCallback) + 368;
		nint num = (nint)ex;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X8_v16 (Il2CppClass<System.NullReferenceException>)+12E]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X8_v16 (Il2CppClass<System.NullReferenceException>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0487;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X8_v16 (Il2CppClass<System.NullReferenceException>)+B0]");
		object obj7 = (nint)0 + (nint)8;
		object obj8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X10_v10-8]");
			bool flag3 = 0 == (nint)obj5;
			obj8 = 0;
			linkedList = (LinkedList<UndoEntry>)num;
			if (flag3)
			{
				break;
			}
			obj7 += 16;
			obj6--;
			if ((nint)obj6 != 1)
			{
				continue;
			}
			goto IL_0487;
		}
		goto IL_0522;
		IL_0522:
		object obj9 = obj7 + 9;
		object obj10 = (object)linkedList + obj9;
		object obj11 = obj10 + 312;
		goto IL_05a9;
		IL_0066:
		undoStack = _undoStack;
		bool flag4 = _undoStack == null;
		object obj12 = !flag4;
		if (obj12 != null)
		{
			goto IL_0126;
		}
		linkedList = _undoStack;
		goto IL_0514;
		IL_0126:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v7 (System.Collections.Generic.LinkedList`1<ClanLogoBuilder+UndoEntry>)+18]");
		if ((nint)0 > (nint)0)
		{
			object obj13 = typeof(SqlSingle[]) + 2376;
			object obj14 = (nint)0 + (nint)1224;
			object obj15 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
			object input = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 3840;
			object input2 = "COORDINATE_TYPE_GCJ_02" + 1864;
			object input3 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 3848;
			InstallCloseGuard();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action action = default(Action);
			action..ctor(this, (IntPtr)obj14);
			object obj16 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ X0_v10+E4]");
			linkedList = (LinkedList<UndoEntry>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ X0_v10+E4]");
			bool flag5 = (nint)0 == 0;
			object obj17 = !flag5;
			if (obj17 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string confirmText = LocalizationUtil.Localize((string)input);
			string cancelText = LocalizationUtil.Localize((string)input2);
			PopupWindowBuilder popupWindowBuilder = PopupWindowBuilder.CreateNegativeConfirm(action, confirmText, cancelText);
			string title = LocalizationUtil.Localize((string)input3);
			bool flag6 = popupWindowBuilder == null;
			obj8 = 0;
			if (!flag6)
			{
				object input4 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 3832;
				IPopupWindowBuilderNeedsBody popupWindowBuilderNeedsBody = popupWindowBuilder.Titled(title);
				string text = LocalizationUtil.Localize((string)input4);
				bool flag7 = popupWindowBuilderNeedsBody == null;
				obj8 = 0;
				if (!flag7)
				{
					object obj18 = typeof(System.IOAsyncCallback) + 384;
					nint num2 = (nint)popupWindowBuilderNeedsBody;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X8_v12 (Il2CppClass<IPopupWindowBuilderNeedsBody>)+12E]");
					object obj19 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X8_v12 (Il2CppClass<IPopupWindowBuilderNeedsBody>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_039d;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X8_v12 (Il2CppClass<IPopupWindowBuilderNeedsBody>)+B0]");
					object obj20 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X10_v13-8]");
						if (0 == (nint)obj18)
						{
							break;
						}
						obj7 = obj20 + 16;
						obj19--;
						bool flag8 = (nint)obj19 != 1;
						obj20 = obj7;
						if (flag8)
						{
							continue;
						}
						goto IL_039d;
					}
					object obj21 = num2 + obj20;
					object obj22 = obj21 + 312;
					linkedList = (LinkedList<UndoEntry>)obj22;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v414 @ X0_v31] (should have been resolved before IL gen)");
					bool flag9 = ex == null;
					object obj23 = !flag9;
					obj7 = obj20;
					obj8 = 0;
					if (obj23 != null)
					{
						goto IL_03df;
					}
				}
			}
			goto IL_0514;
		}
		Close();
		return;
		IL_0487:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		obj8 = 0;
		object obj24 = default(object);
		obj11 = obj24;
		goto IL_05a9;
		IL_05a9:
		object obj25 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ X8_v2+8]");
		object obj26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v300 @ X2_v2 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
		IL_039d:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj27 = default(object);
		linkedList = (LinkedList<UndoEntry>)obj27;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v399 @ X0_v28] (should have been resolved before IL gen)");
		bool flag10 = ex == null;
		obj8 = 0;
		if (!flag10)
		{
			goto IL_03df;
		}
		goto IL_0514;
	}

	public void Close()
	{
		//IL_0009: Expected O, but got I4
		//IL_001f: Expected O, but got I
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Expected O, but got Unknown
		//IL_0159: Expected O, but got I
		//IL_0173: Expected O, but got I4
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_0066: Expected O, but got I
		//IL_01f9: Expected O, but got I
		//IL_01c3: Expected O, but got I4
		//IL_0225: Expected O, but got I4
		//IL_00e0: Expected O, but got I
		//IL_025d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0262: Expected O, but got Unknown
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_029a: Expected O, but got Unknown
		//IL_03ca: Expected O, but got I
		//IL_03e4: Expected O, but got I4
		//IL_03ed: Expected O, but got I4
		//IL_03f6: Expected O, but got I4
		//IL_02f3: Expected O, but got I
		//IL_030b: Expected O, but got I4
		//IL_0314: Expected O, but got I4
		//IL_043e: Expected O, but got I4
		//IL_0494: Expected O, but got I4
		//IL_04bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c1: Expected O, but got Unknown
		object obj = 152993792;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E88E4]");
		object obj2 = (nint)0 & (nint)1;
		object obj3;
		object obj5;
		if (obj2 != null)
		{
			obj3 = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E88E0]");
			object obj4 = (nint)0 & (nint)1;
			bool flag = obj4 == null;
			obj5 = obj3;
			if (!flag)
			{
				goto IL_008b;
			}
		}
		else
		{
			_ = 1;
			obj3 = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E88E0]");
			object obj6 = (nint)0 & (nint)1;
			bool flag2 = obj6 == null;
			object obj7 = !flag2;
			obj5 = obj3;
			if (obj7 != null)
			{
				goto IL_008b;
			}
		}
		_ = 1;
		UnityEngine.Object slideAnim = _slideAnim;
		object obj8 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v41+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		obj3 = obj5;
		UnityEngine.Object slideAnim2 = _slideAnim;
		if (obj9 != null)
		{
			goto IL_00d4;
		}
		goto IL_01e3;
		IL_0363:
		UnityEngine.Object slideAnim3;
		if ((bool)slideAnim3)
		{
			goto IL_038d;
		}
		goto IL_04a2;
		IL_045e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		UnityEngine.Object slideAnim4;
		bool flag4 = slideAnim4;
		bool flag5 = !flag4;
		object obj10 = !flag5;
		if (obj10 != null)
		{
			goto IL_038d;
		}
		goto IL_04a2;
		IL_0322:
		object obj11 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X0_v12+E4]");
		bool flag6 = (nint)0 == 0;
		slideAnim3 = _slideAnim;
		slideAnim4 = _slideAnim;
		if (!flag6)
		{
			goto IL_0363;
		}
		goto IL_045e;
		IL_008b:
		obj8 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v41+E4]");
		bool flag7 = (nint)0 == 0;
		slideAnim = _slideAnim;
		obj5 = obj3;
		slideAnim2 = _slideAnim;
		if (!flag7)
		{
			goto IL_00d4;
		}
		goto IL_01e3;
		IL_01e3:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj12 = (nint)0 + (nint)56;
		bool flag8 = slideAnim2;
		bool flag9 = !flag8;
		object obj13 = !flag9;
		obj3 = obj5;
		object obj14 = obj12;
		if (obj13 != null)
		{
			goto IL_011a;
		}
		goto IL_0243;
		IL_00d4:
		obj12 = (nint)0 + (nint)56;
		bool flag10 = slideAnim;
		bool flag11 = !flag10;
		obj14 = obj12;
		obj5 = obj3;
		if (!flag11)
		{
			goto IL_011a;
		}
		goto IL_0243;
		IL_0243:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		SlideAnimationHelper slideAnim5 = default(SlideAnimationHelper);
		_slideAnim = slideAnim5;
		object obj15 = this + 272;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj12 = obj14;
		obj3 = obj5;
		goto IL_0286;
		IL_011a:
		slideAnim5 = _slideAnim;
		goto IL_0286;
		IL_0286:
		object obj16 = typeof(RegisteredWaitHandle) + 3136;
		GameObject contentObject = slideAnim5.GetContentObject();
		object obj17 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X8_v4+E4]");
		object obj20;
		object obj19;
		if ((nint)0 != 0)
		{
			ScreenManager.RemovePopup(contentObject);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E88E0]");
			object obj18 = (nint)0 & (nint)1;
			bool flag12 = obj18 == null;
			obj19 = 0;
			obj20 = 0;
			if (!flag12)
			{
				goto IL_0322;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			ScreenManager.RemovePopup(contentObject);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E88E0]");
			object obj21 = (nint)0 & (nint)1;
			bool flag13 = obj21 == null;
			object obj22 = !flag13;
			obj19 = 0;
			obj20 = 0;
			if (obj22 != null)
			{
				goto IL_0322;
			}
		}
		_ = 1;
		slideAnim3 = _slideAnim;
		obj11 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X0_v12+E4]");
		bool flag14 = (nint)0 == 0;
		object obj23 = !flag14;
		obj19 = obj20;
		slideAnim4 = _slideAnim;
		if (obj23 != null)
		{
			goto IL_0363;
		}
		goto IL_045e;
		IL_04d0:
		SlideAnimationHelper slideAnim6 = default(SlideAnimationHelper);
		slideAnim6.SlideOut();
		return;
		IL_038d:
		slideAnim6 = _slideAnim;
		goto IL_04d0;
		IL_04a2:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		_slideAnim = slideAnim6;
		object obj24 = this + 272;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		goto IL_04d0;
	}

	public void Save()
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0072: Expected O, but got I4
		//IL_00a2: Expected O, but got I4
		if (HasMinimumLayers())
		{
			ClanLogoModel arg = LayersToModel();
			Actions.SafeInvoke((Action<object>)this.OnSaved, arg);
			return;
		}
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1240;
		object message = "Added Tournament Prizes And Features" + 3080;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Toast.Show((string)message, (Vector2)0, 0f);
	}

	public void LoadModel(ClanLogoModel model)
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		if (model != null)
		{
			if (_selectorsReady)
			{
				ApplyModel(model);
				return;
			}
			_pendingModel = model;
			object obj = this + 264;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public void ResetToDefault()
	{
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_0011: Expected O, but got I
		//IL_0040: Expected O, but got I4
		//IL_0068: Expected O, but got I
		//IL_02d5: Expected O, but got I
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected O, but got Unknown
		//IL_0221: Expected O, but got I4
		//IL_01d1: Expected O, but got I
		//IL_0248: Expected O, but got I4
		//IL_0131: Expected O, but got I4
		//IL_0179: Expected O, but got I4
		//IL_025f: Expected O, but got I4
		//IL_0278: Expected O, but got I4
		//IL_01c0: Expected O, but got I4
		List<object>.Enumerator enumerator;
		UnityEngine.Object obj2;
		object obj7;
		if (_selectorsReady)
		{
			object obj = (nint)0 + (nint)2176;
			obj2 = (UnityEngine.Object)obj;
			List<object> list = Enumerable.ToList((IEnumerable<object>)layers);
			bool flag = list == null;
			enumerator = (List<object>.Enumerator)0;
			if (!flag)
			{
				List<object>.Enumerator enumerator2 = list.GetEnumerator();
				object obj3 = (nint)0 + (nint)2056;
				List<object>.Enumerator enumerator3 = default(List<object>.Enumerator);
				IconLayer iconLayer = default(IconLayer);
				while (true)
				{
					obj2 = (UnityEngine.Object)obj3;
					if (!enumerator3.MoveNext())
					{
						break;
					}
					if (iconLayer != null)
					{
						iconLayer.Reset();
						continue;
					}
					goto IL_01ff;
				}
				enumerator3.Dispose();
				List<object>.Enumerator enumerator4 = list.GetEnumerator();
				object obj4 = typeof(MemberAchievementClanFeedData) + 2976;
				List<object>.Enumerator enumerator5 = default(List<object>.Enumerator);
				while (true)
				{
					obj2 = (UnityEngine.Object)obj3;
					if (!enumerator5.MoveNext())
					{
						break;
					}
					if (iconLayer == null)
					{
						goto IL_0226;
					}
					object obj5 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ X0_v37+E4]");
					bool flag2 = (nint)0 == 0;
					object obj6 = !flag2;
					if (obj6 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag3 = iconLayer.Selector != null;
					bool flag4 = !flag3;
					obj7 = 0;
					if (flag4)
					{
						continue;
					}
					if ((object)iconLayer.Selector != null)
					{
						iconLayer.Selector.PickDefault();
						obj7 = 0;
						continue;
					}
					goto IL_024d;
				}
				object obj8 = (nint)0 + (nint)2048;
				obj2 = (UnityEngine.Object)obj8;
				enumerator5.Dispose();
				goto IL_01e7;
			}
			goto IL_035a;
		}
		_pendingModel = null;
		object obj9 = this + 264;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return;
		IL_01e7:
		UpdateBelowMinButtons();
		ApplyLayerSiblingOrder();
		ClearUndoHistory();
		return;
		IL_035a:
		NullReferenceException ex = new NullReferenceException();
		bool flag5 = (nint)obj2 != 1;
		NullReferenceException ex2 = ex;
		List<object>.Enumerator enumerator6 = default(List<object>.Enumerator);
		if (!flag5)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			object obj10 = (nint)0 + (nint)2048;
			obj2 = (UnityEngine.Object)obj10;
			enumerator.Dispose();
			object obj11 = default(object);
			if (obj11 == null)
			{
				goto IL_01e7;
			}
			OutOfMemoryException ex3 = new OutOfMemoryException();
			ex2 = (NullReferenceException)(object)ex3;
			enumerator6 = (List<object>.Enumerator)obj11;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223E080");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return;
		IL_01ff:
		NullReferenceException ex4 = new NullReferenceException();
		enumerator = enumerator6;
		List<object>.Enumerator enumerator7 = enumerator6;
		enumerator6 = (List<object>.Enumerator)0;
		goto IL_035a;
		IL_0226:
		NullReferenceException ex5 = new NullReferenceException();
		enumerator = enumerator6;
		enumerator7 = enumerator6;
		enumerator6 = (List<object>.Enumerator)0;
		goto IL_035a;
		IL_024d:
		NullReferenceException ex6 = new NullReferenceException();
		obj7 = 0;
		enumerator = enumerator6;
		enumerator7 = enumerator6;
		enumerator6 = (List<object>.Enumerator)0;
		obj2 = null;
		goto IL_035a;
	}

	public ClanLogoModel LayersToModel()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_043f: Expected O, but got I4
		//IL_05d3: Expected O, but got I
		//IL_05e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e7: Expected O, but got Unknown
		//IL_05f7: Expected O, but got I
		//IL_0607: Expected O, but got I
		//IL_0629: Expected O, but got I4
		//IL_0052: Expected O, but got I4
		//IL_02f5: Expected O, but got I4
		//IL_045c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0461: Expected O, but got Unknown
		//IL_0477: Expected O, but got I
		//IL_0488: Expected I, but got O
		//IL_04a6: Expected O, but got I
		//IL_04c1: Expected O, but got I4
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Expected O, but got Unknown
		//IL_0240: Expected O, but got I
		//IL_0250: Expected O, but got I
		//IL_0260: Expected O, but got I
		//IL_0270: Expected O, but got I
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected O, but got Unknown
		//IL_0082: Expected O, but got I
		//IL_04da: Expected O, but got I
		//IL_04e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ee: Expected O, but got Unknown
		//IL_04fa: Expected O, but got I
		//IL_0506: Expected O, but got I
		//IL_0517: Expected O, but got I
		//IL_0527: Expected O, but got I
		//IL_0549: Expected O, but got I4
		//IL_029e: Expected O, but got I
		//IL_02ae: Expected O, but got I
		//IL_02be: Expected O, but got I
		//IL_02ce: Expected O, but got I
		//IL_0660: Expected I, but got O
		//IL_0164: Expected O, but got I4
		//IL_019c: Expected O, but got I
		//IL_01ac: Expected O, but got I
		//IL_01bc: Expected O, but got I
		//IL_01cc: Expected O, but got I
		//IL_0381: Expected O, but got I4
		//IL_03f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fe: Expected O, but got Unknown
		//IL_0566: Unknown result type (might be due to invalid IL or missing references)
		//IL_056b: Expected O, but got Unknown
		//IL_0581: Expected O, but got I
		//IL_0592: Expected I, but got O
		//IL_05b0: Expected O, but got I
		//IL_03c8: Expected O, but got I4
		//IL_03b1: Expected O, but got I
		object obj = typeof(CardUtils.<>c) + 936;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		object obj4 = (nint)0 + (nint)920;
		object obj5 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1296;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v3+B8]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X8_v24+10]");
		Func<object, bool> predicate = (Func<object, bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X8_v24+10]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v3+E4]");
			bool flag3 = (nint)0 == 0;
			object obj8 = !flag3;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj9 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X8_v30+B8]");
				obj6 = 0;
			}
			object obj10 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1736;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj11 = (nint)0 + (nint)4008;
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj6, (IntPtr)obj11);
			object obj12 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X8_v29+B8]");
			object obj13 = (nint)0 + (nint)16;
			obj13 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj14 = 0;
			predicate = func;
		}
		object obj15 = Enumerable.FirstOrDefault(layers, predicate);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		ClanLogoModel clanLogoModel = default(ClanLogoModel);
		clanLogoModel..ctor();
		object obj18 = default(object);
		object obj20 = default(object);
		object obj22 = default(object);
		object obj24 = default(object);
		ClanLogoRim source;
		ClanLogoRim clanLogoRim3;
		object obj17;
		object obj19;
		object obj21;
		object obj23;
		ClanLogoRim clanLogoRim2;
		if (obj15 != null)
		{
			object obj16 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1304;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			ClanLogoRim clanLogoRim = default(ClanLogoRim);
			clanLogoRim..ctor();
			bool flag4 = clanLogoRim == null;
			obj17 = obj18;
			obj19 = obj20;
			obj21 = obj22;
			obj23 = obj24;
			clanLogoRim2 = null;
			source = clanLogoRim;
			if (!flag4)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X0_v6 (System.Object)+20]");
				clanLogoRim.Id = 0;
				int color = ColorExtension.ToPackedRgba((Color)0);
				clanLogoRim.Color = color;
				bool flag5 = clanLogoModel == null;
				clanLogoRim3 = clanLogoRim;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X0_v6 (System.Object)+3C]");
				obj17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X0_v6 (System.Object)+38]");
				obj19 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X0_v6 (System.Object)+34]");
				obj21 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X0_v6 (System.Object)+30]");
				obj23 = 0;
				clanLogoRim2 = null;
				source = clanLogoRim;
				if (!flag5)
				{
					goto IL_01e7;
				}
			}
		}
		else
		{
			bool flag6 = clanLogoModel == null;
			object obj25 = !flag6;
			clanLogoRim3 = null;
			obj17 = obj18;
			obj19 = obj20;
			obj21 = obj22;
			obj23 = obj24;
			clanLogoRim2 = null;
			source = null;
			if (obj25 != null)
			{
				goto IL_01e7;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_0340;
		IL_01e7:
		object obj26 = clanLogoModel + 16;
		obj26 = clanLogoRim3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		source = (ClanLogoRim)(object)layers;
		ex = (NullReferenceException)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X0_v9 (System.NullReferenceException)+E4]");
		bool flag7 = (nint)0 == 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X0_v6 (System.Object)+3C]");
		obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X0_v6 (System.Object)+38]");
		obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X0_v6 (System.Object)+34]");
		obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X0_v6 (System.Object)+30]");
		obj23 = 0;
		clanLogoRim2 = clanLogoRim3;
		if (flag7)
		{
			goto IL_0340;
		}
		object obj27 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X0_v6 (System.Object)+3C]");
		obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X0_v6 (System.Object)+38]");
		obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X0_v6 (System.Object)+34]");
		obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X0_v6 (System.Object)+30]");
		obj23 = 0;
		clanLogoRim2 = clanLogoRim3;
		goto IL_04ce;
		IL_04ce:
		object obj28 = (nint)0 + (nint)3504;
		object obj29 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1744;
		object obj30 = (nint)0 + (nint)1200;
		object obj31 = (nint)0 + (nint)3408;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X0_v9 (System.NullReferenceException)+B8]");
		object obj32 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X8_v9+18]");
		Func<object, bool> predicate2 = (Func<object, bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X8_v9+18]");
		bool flag8 = (nint)0 == 0;
		object obj33 = !flag8;
		if (obj33 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X0_v9 (System.NullReferenceException)+E4]");
			bool flag9 = (nint)0 == 0;
			object obj34 = !flag9;
			if (obj34 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj35 = obj27;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X8_v15+B8]");
				obj32 = 0;
			}
			object obj36 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1736;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj37 = (nint)0 + (nint)4016;
			Func<object, bool> func2 = default(Func<object, bool>);
			func2..ctor(obj32, (IntPtr)obj37);
			object obj38 = obj27;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X8_v14+B8]");
			object obj39 = (nint)0 + (nint)24;
			obj39 = func2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			predicate2 = func2;
			object obj14 = 0;
		}
		IEnumerable<object> source2 = Enumerable.Where((IEnumerable<object>)source, predicate2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<object, object> func3 = default(Func<object, object>);
		func3..ctor((object)this, (IntPtr)obj30);
		IEnumerable<object> source3 = Enumerable.Select(source2, func3);
		List<object> list = Enumerable.ToList(source3);
		object obj40 = clanLogoModel + 24;
		obj40 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return clanLogoModel;
		IL_0340:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		ex = (NullReferenceException)obj;
		obj27 = obj;
		goto IL_04ce;
	}

	private unsafe void Initialize()
	{
		//IL_0039: Expected O, but got I
		//IL_0051: Expected O, but got Ref
		//IL_0014: Expected O, but got I
		AsyncVoidMethodBuilder asyncVoidMethodBuilder = AsyncVoidMethodBuilder.Create();
		<Initialize>d__71 stateMachine = default(<Initialize>d__71);
		object obj = (nint)(&stateMachine) | (nint)8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj2 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref stateMachine, 40));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		AsyncVoidMethodBuilder asyncVoidMethodBuilder2 = (AsyncVoidMethodBuilder)((nint)(&stateMachine) | (nint)8);
		((AsyncVoidMethodBuilder*)asyncVoidMethodBuilder2)->Start(ref stateMachine);
	}

	private void SetInteractionLocked(bool locked)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00f8: Expected O, but got I4
		//IL_014d: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8899]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			obj5 = inputBlocker;
			obj6 = inputBlocker;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = inputBlocker;
			obj6 = inputBlocker;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6 != null;
		bool flag4 = !flag3;
		object obj8 = !flag4;
		if (obj8 == null)
		{
			return;
		}
		goto IL_00b8;
		IL_00b8:
		inputBlocker.SetActive(locked);
		return;
		IL_0091:
		if (obj5 != null)
		{
			goto IL_00b8;
		}
	}

	private bool HasIconItems()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_014c: Expected O, but got I4
		//IL_00a5: Expected O, but got I
		//IL_00b5: Expected O, but got I
		//IL_00c5: Expected O, but got I
		//IL_00e7: Expected O, but got I4
		//IL_018a: Expected O, but got I
		//IL_019a: Expected O, but got I
		//IL_01aa: Expected O, but got I
		//IL_01cc: Expected O, but got I4
		//IL_0214: Expected O, but got I4
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Expected O, but got Unknown
		//IL_0289: Expected O, but got I
		//IL_029a: Expected I, but got O
		//IL_02b8: Expected O, but got I
		//IL_0244: Expected O, but got I
		object obj = 152993792;
		object obj2 = typeof(CardUtils.<>c) + 936;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E889A]");
		object obj3 = (nint)0 & (nint)1;
		List<IconLayer> list;
		List<IconLayer> list2;
		object obj4;
		if (obj3 != null)
		{
			list = layers;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v4+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = obj4;
			list2 = layers;
			if (!flag)
			{
				goto IL_0099;
			}
		}
		else
		{
			_ = 1;
			list = layers;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v4+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			object obj5 = obj4;
			list2 = layers;
			if (obj6 != null)
			{
				goto IL_0099;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj4 = obj2;
		object obj7 = (nint)0 + (nint)2616;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v4+B8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v4+20]");
		Func<object, bool> predicate = (Func<object, bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v4+20]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		IEnumerable<object> enumerable = list2;
		object obj10 = obj7;
		IEnumerable<object> source = list2;
		if (obj9 == null)
		{
			goto IL_01f2;
		}
		goto IL_0249;
		IL_01f2:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v4+E4]");
		bool flag4 = (nint)0 == 0;
		object obj11 = !flag4;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj12 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X8_v10+B8]");
			obj8 = 0;
		}
		object obj13 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1736;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj14 = (nint)0 + (nint)4000;
		Func<object, bool> func = default(Func<object, bool>);
		func..ctor(obj8, (IntPtr)obj14);
		object obj15 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v9+B8]");
		object obj16 = (nint)0 + (nint)32;
		obj16 = func;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj10 = obj7;
		predicate = func;
		source = enumerable;
		goto IL_0249;
		IL_0249:
		return Enumerable.Any(source, predicate);
		IL_0099:
		obj10 = (nint)0 + (nint)2616;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v4+B8]");
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v4+20]");
		predicate = (Func<object, bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v4+20]");
		bool flag5 = (nint)0 == 0;
		object obj17 = !flag5;
		source = list;
		if (obj17 == null)
		{
			obj7 = obj10;
			enumerable = list;
			goto IL_01f2;
		}
		goto IL_0249;
	}

	private static Task<List<Color>> GetEmblemColorPresets()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00e2: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(System.Formats.Asn1.SetOfValueComparer) + 3912;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E889B]");
		object obj3 = (nint)0 & (nint)1;
		List<Color> list;
		object result;
		if (obj3 != null)
		{
			list = BuildEmblemColorPresets();
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v2+E4]");
			bool flag = (nint)0 == 0;
			result = list;
			if (!flag)
			{
				goto IL_0090;
			}
		}
		else
		{
			_ = 1;
			list = BuildEmblemColorPresets();
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			result = list;
			if (obj5 != null)
			{
				goto IL_0090;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		return (Task<List<Color>>)(object)Task.FromResult((object)list);
		IL_0090:
		return (Task<List<Color>>)(object)Task.FromResult(result);
	}

	private static List<Color> BuildEmblemColorPresets()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_01de: Expected O, but got I4
		//IL_023e: Expected O, but got I4
		//IL_0265: Expected O, but got I
		//IL_0275: Expected O, but got I
		//IL_0297: Expected O, but got I4
		//IL_021e: Expected O, but got I4
		//IL_0318: Expected O, but got I
		//IL_03cd: Expected O, but got I
		//IL_03dd: Expected O, but got I
		//IL_03ff: Expected O, but got I4
		//IL_02d7: Expected O, but got I4
		//IL_0366: Expected O, but got I
		//IL_0376: Expected O, but got I
		//IL_0398: Expected O, but got I4
		//IL_049d: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a2: Expected O, but got Unknown
		//IL_04b8: Expected O, but got I
		//IL_04c9: Expected I, but got O
		//IL_04e7: Expected O, but got I
		//IL_042f: Expected O, but got I4
		//IL_0307: Expected O, but got I
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Expected O, but got Unknown
		//IL_0525: Unknown result type (might be due to invalid IL or missing references)
		//IL_052a: Expected O, but got Unknown
		//IL_0540: Expected O, but got I
		//IL_0551: Expected I, but got O
		//IL_056f: Expected O, but got I
		//IL_045f: Expected O, but got I
		//IL_0152: Expected O, but got I
		//IL_0162: Expected O, but got I
		//IL_0184: Expected O, but got I4
		IEnumerable<object> enumerable = (IEnumerable<object>)152993792;
		object obj = typeof(RegisteredWaitHandle) + 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E889C]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v32+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v32+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		RemoteConfigModel current = RemoteConfig.Current;
		bool flag2 = current == null;
		object obj5 = !flag2;
		if (obj5 != null)
		{
			goto IL_00a3;
		}
		goto IL_022c;
		IL_030c:
		object obj6 = (nint)0 + (nint)24;
		IEnumerable<object> source2;
		Func<object, Color> selector;
		IEnumerable<Color> source = Enumerable.Select(source2, selector);
		object obj8;
		object obj7 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X0_v9+E4]");
		object obj9;
		Func<Color, bool> predicate;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X0_v9+B8]");
			obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X8_v12+30]");
			predicate = (Func<Color, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X8_v12+30]");
			bool flag3 = (nint)0 == 0;
			object obj10 = !flag3;
			if (obj10 == null)
			{
				goto IL_040d;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj7 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X0_v9+B8]");
			obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X8_v12+30]");
			predicate = (Func<Color, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X8_v12+30]");
			bool flag4 = (nint)0 == 0;
			object obj11 = !flag4;
			if (obj11 == null)
			{
				goto IL_040d;
			}
		}
		goto IL_0464;
		IL_0243:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj12 = default(object);
		NullReferenceException ex = (NullReferenceException)obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X0_v19 (System.NullReferenceException)+B8]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v23+28]");
		selector = (Func<object, Color>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v23+28]");
		bool flag5 = (nint)0 == 0;
		object obj14 = !flag5;
		obj8 = obj12;
		IEnumerable<object> enumerable2;
		source2 = enumerable2;
		if (obj14 == null)
		{
			goto IL_02b5;
		}
		goto IL_030c;
		IL_0464:
		IEnumerable<Color> source3 = Enumerable.Where(source, predicate);
		return Enumerable.ToList(source3);
		IL_007d:
		current = RemoteConfig.Current;
		if (current != null)
		{
			goto IL_00a3;
		}
		goto IL_022c;
		IL_022c:
		ex = new NullReferenceException();
		enumerable2 = (IEnumerable<object>)152993792;
		goto IL_0243;
		IL_00a3:
		ClanConfigsResponse <Clans>k__BackingField = current.<Clans>k__BackingField;
		if (current.<Clans>k__BackingField != null)
		{
			enumerable2 = <Clans>k__BackingField.EmblemColorPresets;
			if (<Clans>k__BackingField.EmblemColorPresets != null)
			{
				obj12 = typeof(CardUtils.<>c) + 936;
				ex = (NullReferenceException)obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X0_v19 (System.NullReferenceException)+E4]");
				if ((nint)0 == 0)
				{
					goto IL_0243;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X0_v19 (System.NullReferenceException)+B8]");
				obj13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v23+28]");
				selector = (Func<object, Color>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v23+28]");
				bool flag6 = (nint)0 == 0;
				object obj15 = !flag6;
				obj8 = obj12;
				source2 = <Clans>k__BackingField.EmblemColorPresets;
				if (obj15 == null)
				{
					goto IL_02b5;
				}
				goto IL_030c;
			}
		}
		return null;
		IL_040d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X0_v9+E4]");
		bool flag7 = (nint)0 == 0;
		object obj16 = !flag7;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj17 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X8_v18+B8]");
			obj9 = 0;
		}
		object obj18 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 800;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj19 = (nint)0 + (nint)3992;
		Func<Color, bool> func = default(Func<Color, bool>);
		func..ctor(obj9, (IntPtr)obj19);
		object obj20 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X8_v17+B8]");
		object obj21 = (nint)0 + (nint)48;
		obj21 = func;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		predicate = func;
		goto IL_0464;
		IL_02b5:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X0_v19 (System.NullReferenceException)+E4]");
		bool flag8 = (nint)0 == 0;
		object obj22 = !flag8;
		if (obj22 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj23 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X8_v29+B8]");
			obj13 = 0;
		}
		object obj24 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3560;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj25 = (nint)0 + (nint)3984;
		Func<object, Color> func2 = default(Func<object, Color>);
		func2..ctor(obj13, (IntPtr)obj25);
		object obj26 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X8_v28+B8]");
		object obj27 = (nint)0 + (nint)40;
		obj27 = func2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj8 = obj12;
		selector = func2;
		source2 = enumerable2;
		goto IL_030c;
	}

	private unsafe void CaptureCleanSnapshots()
	{
		//IL_0178: Expected O, but got I
		//IL_0011: Expected O, but got I
		//IL_0052: Expected O, but got I
		//IL_00c7: Expected O, but got I4
		//IL_00a0: Expected O, but got Ref
		bool flag = _cleanSnapshots == null;
		IntPtr intPtr = default(IntPtr);
		ClanLogoBuilder clanLogoBuilder = (ClanLogoBuilder)(nint)intPtr;
		object obj2 = default(object);
		List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
		if (!flag)
		{
			object obj = (nint)0 + (nint)3368;
			clanLogoBuilder = (ClanLogoBuilder)obj;
			((Dictionary<object, LayerSnapshot>)(object)_cleanSnapshots).Clear();
			if (layers != null)
			{
				obj2 = (nint)0 + (nint)2048;
				List<object>.Enumerator enumerator = ((List<object>)(object)layers).GetEnumerator();
				LayerSnapshot layerSnapshot2 = default(LayerSnapshot);
				while (true)
				{
					if (enumerator2.MoveNext())
					{
						LayerSnapshot layerSnapshot = new LayerSnapshot(this, null);
						if (_cleanSnapshots == null)
						{
							break;
						}
						((Dictionary<object, LayerSnapshot>)(object)_cleanSnapshots).set_Item((object)null, (LayerSnapshot)(&layerSnapshot2));
						continue;
					}
					enumerator2.Dispose();
					return;
				}
				NullReferenceException ex = new NullReferenceException();
				object obj3 = 0;
				clanLogoBuilder = this;
			}
		}
		NullReferenceException ex2 = new NullReferenceException();
		bool flag2 = (nint)clanLogoBuilder != 1;
		NullReferenceException ex3 = ex2;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			clanLogoBuilder = (ClanLogoBuilder)obj2;
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
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223E080");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
	}

	private void CaptureSlotsAndDisableLayouts()
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		//IL_0058: Expected O, but got I
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		//IL_006f: Expected O, but got I4
		//IL_00b3: Expected O, but got I
		//IL_0158: Expected O, but got I
		//IL_017b: Expected O, but got I4
		//IL_0185: Expected I, but got O
		//IL_00f7: Expected O, but got I
		//IL_0115: Expected O, but got I4
		//IL_011f: Expected I, but got O
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected O, but got Unknown
		//IL_01ad: Expected O, but got I
		//IL_06ec: Expected O, but got I4
		//IL_0277: Expected O, but got I4
		//IL_0281: Expected I, but got O
		//IL_01e2: Expected I, but got O
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Expected O, but got Unknown
		//IL_02cd: Expected O, but got I4
		//IL_0766: Expected O, but got I4
		//IL_0211: Expected O, but got I
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_0319: Expected O, but got Unknown
		//IL_0334: Expected O, but got I
		//IL_0518: Expected O, but got I
		//IL_0529: Expected O, but got I
		//IL_0550: Expected O, but got I
		//IL_0392: Expected I, but got O
		//IL_0601: Expected O, but got I
		//IL_0609: Expected I, but got O
		//IL_0595: Unknown result type (might be due to invalid IL or missing references)
		//IL_059a: Expected I4, but got Unknown
		//IL_05a3: Expected O, but got I4
		//IL_0414: Expected I, but got O
		//IL_05b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b6: Expected O, but got Unknown
		//IL_05cc: Expected O, but got I
		//IL_0653: Unknown result type (might be due to invalid IL or missing references)
		//IL_0658: Expected O, but got Unknown
		//IL_0661: Expected O, but got I4
		//IL_066f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0674: Expected O, but got Unknown
		//IL_068a: Expected O, but got I
		//IL_0463: Expected O, but got I
		//IL_04b7: Expected O, but got I4
		//IL_06bd: Expected I, but got O
		//IL_03ad: Expected O, but got I
		//IL_03c7: Expected O, but got I
		//IL_04de: Expected O, but got I
		//IL_04ee: Expected O, but got I
		//IL_0503: Expected O, but got I
		LayerConfigReferences[] array = layerConfigs;
		if (array.Length >= 1)
		{
			object obj = typeof(MemberAchievementClanFeedData) + 2976;
			object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 3600;
			object obj3 = (nint)0 + (nint)3304;
			object obj4 = array + 32;
			object obj5 = 0;
			bool flag7 = default(bool);
			nint num3 = default(nint);
			ClanLogoBuilder clanLogoBuilder2 = default(ClanLogoBuilder);
			List<Vector2> list = default(List<Vector2>);
			object obj34 = default(object);
			object obj39 = default(object);
			do
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X28_v4+v141 @ X24_v5*8]");
				object obj6 = 0;
				object obj7 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ X0_v6+E4]");
				object obj9;
				nint num;
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X19_v6+20]");
					bool flag = (UnityEngine.Object)0 == null;
					bool flag2 = !flag;
					object obj8 = !flag2;
					obj9 = null;
					num = unchecked((nint)null);
					if (obj8 != null)
					{
						goto IL_0074;
					}
					object obj10 = null;
					UnityEngine.Object obj11 = null;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X19_v6+20]");
					bool flag3 = (UnityEngine.Object)0 == null;
					bool flag4 = !flag3;
					object obj12 = !flag4;
					obj9 = null;
					num = unchecked((nint)null);
					object obj10 = null;
					UnityEngine.Object obj11 = null;
					if (obj12 != null)
					{
						goto IL_0074;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X19_v6+20]");
				UnityEngine.Object obj13 = (UnityEngine.Object)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X19_v6+20]");
				ClanLogoBuilder clanLogoBuilder;
				nint num2;
				bool flag5;
				UnityEngine.Object obj14;
				UnityEngine.Object obj17;
				if ((nint)0 != 0)
				{
					clanLogoBuilder = (ClanLogoBuilder)obj2;
					num2 = (nint)obj13;
					flag5 = obj13 != obj2;
					if (!flag5)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X19_v6+20]");
						obj14 = (UnityEngine.Object)0;
					}
					else
					{
						obj14 = null;
					}
					object obj15 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v487 @ X0_v41+E4]");
					bool flag6 = (nint)0 == 0;
					object obj16 = !flag6;
					flag7 = flag5;
					num3 = num2;
					clanLogoBuilder2 = clanLogoBuilder;
					obj17 = obj14;
					if (obj16 == null)
					{
						goto IL_0220;
					}
				}
				else
				{
					object obj15 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v487 @ X0_v41+E4]");
					bool flag8 = (nint)0 == 0;
					object obj18 = !flag8;
					obj17 = null;
					if (obj18 == null)
					{
						flag5 = flag7;
						num2 = num3;
						clanLogoBuilder = clanLogoBuilder2;
						obj14 = null;
						goto IL_0220;
					}
				}
				goto IL_024f;
				IL_0074:
				obj5++;
				continue;
				IL_024f:
				bool flag9 = obj17 == null;
				bool flag10 = !flag9;
				object obj19 = !flag10;
				obj9 = null;
				num = unchecked((nint)null);
				if (obj19 == null)
				{
					object obj20 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1648;
					object obj21 = obj20;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v492 @ X0_v12+E4]");
					bool flag11 = (nint)0 == 0;
					object obj22 = !flag11;
					if (obj22 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					LayoutRebuilder.ForceRebuildLayoutImmediate((RectTransform)obj17);
					int childCount = ((Transform)obj17).childCount;
					object obj23 = typeof(List<Tween>) + 264;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj24 = (nint)0 + (nint)3296;
					list..ctor(childCount);
					int childCount2 = ((Transform)obj17).childCount;
					bool flag12 = childCount2 < 1;
					int num4 = childCount;
					if (!flag12)
					{
						int num5 = 0;
						nint num6 = num3;
						nint num7 = (nint)clanLogoBuilder2;
						bool flag14;
						do
						{
							Transform child = ((Transform)obj17).GetChild(num5);
							if ((object)child != null)
							{
								obj24 = obj2;
								num7 = (nint)child;
								if (child == obj2)
								{
									Vector2 anchoredPosition = ((RectTransform)child).anchoredPosition;
									object obj25 = obj3;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v504 @ X0_v18 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+1C]");
									object obj26 = (nint)0 + (nint)1;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v504 @ X0_v18 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+10]");
									num7 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v504 @ X0_v18 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
									num6 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v504 @ X0_v18 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
									nint num8 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v527 @ X9_v9 (Il2CppClass<UnityEngine.Transform>)+18]");
									bool flag13 = num8 < 0;
									object obj27 = !flag13;
									object obj28 = ~obj27;
									if (obj28 != null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v504 @ X0_v18 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
										object obj29 = (nint)0 + (nint)1;
										nint num9 = num7;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v504 @ X0_v18 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
										obj24 = num9 + 0;
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X8_v38+20]");
										object obj30 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v633 @ X8_v39+C0]");
										obj24 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v542 @ X8_v36+70]");
										list.AddWithResize((Vector2)0);
									}
								}
							}
							num5++;
							int childCount3 = ((Transform)obj17).childCount;
							flag14 = num5 >= childCount3;
							num4 = num5;
							num3 = num6;
						}
						while (!flag14);
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X19_v6+10]");
					object obj31 = 0;
					object obj32 = (nint)0 + (nint)2064;
					Dictionary<ClanLogoLayer, List<Vector2>> slotPositions = _slotPositions;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X8_v21+18]");
					((Dictionary<System.Int32Enum, object>)(object)slotPositions).set_Item((System.Int32Enum)0, (object)list);
					object obj33 = (nint)0 + (nint)600;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D31A5C");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X0_v24+18]");
					bool flag15 = (nint)0 < (nint)1;
					obj9 = list;
					if (!flag15)
					{
						num4 = obj34 + 32;
						object obj35 = 0;
						bool flag16;
						do
						{
							obj35++;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X22_v12 (System.Int32)+v255 @ X19_v12*8]");
							((Behaviour)0).enabled = false;
							object obj36 = obj35;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X0_v24+18]");
							flag16 = (nint)obj36 < 0;
							obj9 = null;
						}
						while (flag16);
					}
					object obj37 = (nint)0 + (nint)584;
					num = (nint)obj37;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D31A5C");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X0_v27+18]");
					bool flag17 = (nint)0 < (nint)1;
					object obj38 = obj34;
					clanLogoBuilder2 = this;
					if (!flag17)
					{
						obj38 = obj39 + 32;
						object obj40 = 0;
						object obj41;
						do
						{
							obj40++;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X21_v8+v257 @ X19_v9*8]");
							((Behaviour)0).enabled = false;
							obj41 = obj40;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X0_v27+18]");
						}
						while ((nint)obj41 < 0);
						clanLogoBuilder2 = this;
						obj9 = null;
						num = unchecked((nint)null);
					}
				}
				goto IL_0074;
				IL_0220:
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				flag7 = flag5;
				num3 = num2;
				clanLogoBuilder2 = clanLogoBuilder;
				obj17 = obj14;
				goto IL_024f;
			}
			while ((nint)obj5 < array.Length);
		}
		_layoutsCaptured = true;
	}

	private void OnSelectorItemSelected(IconLayer layer, ClanLogoLayer layerEnum, int id)
	{
		//IL_0012: Expected I4, but got I8
		//IL_002c: Expected O, but got I4
		//IL_0054: Expected O, but got I4
		int num = (int)(id & 0x80000000L);
		bool flag = num == 0;
		object obj = !flag;
		IconLayer layer2;
		if (obj == null)
		{
			bool flag2 = layer == null;
			object obj2 = !flag2;
			layer2 = layer;
			if (obj2 == null)
			{
				throw new NullReferenceException();
			}
		}
		else
		{
			layer2 = null;
		}
		layer.SetImage(id);
		SelectLayer(layer2);
		SortEmptiesToEnd();
		UpdateBelowMinButtons();
	}

	private void OnSelectorItemConfirmed(IconLayer layer, ClanLogoLayer layerEnum, int id)
	{
		//IL_0012: Expected I4, but got I8
		if ((int)(id & 0x80000000L) != 0)
		{
			layer.Reset();
		}
		UpdateBelowMinButtons();
		AddUndo(layer);
	}

	private void UpdateBelowMinButtons()
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		//IL_0064: Expected O, but got I4
		//IL_0163: Expected O, but got I4
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Expected O, but got Unknown
		//IL_018f: Expected O, but got I
		//IL_024e: Expected O, but got I
		//IL_0271: Expected O, but got I4
		//IL_027a: Expected O, but got I4
		//IL_027f: Expected I, but got O
		//IL_0288: Expected O, but got I4
		//IL_01e5: Expected O, but got I
		//IL_0203: Expected O, but got I4
		//IL_020c: Expected O, but got I4
		//IL_0211: Expected I, but got O
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Expected O, but got Unknown
		//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Expected O, but got Unknown
		//IL_02c5: Expected O, but got I
		//IL_02d6: Expected I, but got O
		//IL_0228: Expected O, but got I4
		//IL_033e: Expected O, but got I4
		//IL_007b: Expected O, but got I4
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected I4, but got Unknown
		//IL_00f4: Expected O, but got I4
		LayerConfigReferences[] array = layerConfigs;
		if (array.Length < 1)
		{
			return;
		}
		object obj = typeof(CardUtils.<>c) + 992;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj3 = array + 32;
		object obj4 = 0;
		<>c__DisplayClass80_0 <>c__DisplayClass80_ = default(<>c__DisplayClass80_0);
		Func<object, bool> func = default(Func<object, bool>);
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			<>c__DisplayClass80_..ctor();
			bool flag = (nint)obj4 < array.Length;
			object obj5 = !flag;
			if (obj5 != null)
			{
				break;
			}
			object obj6 = <>c__DisplayClass80_ + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X27_v4+v105 @ X24_v5*8]");
			obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj7 = obj6;
			object obj8 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X8_v9+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X8_v8+28]");
				bool flag2 = (UnityEngine.Object)0 == null;
				bool flag3 = !flag2;
				object obj9 = !flag3;
				object obj10 = 0;
				nint num = unchecked((nint)null);
				if (obj9 != null)
				{
					goto IL_0101;
				}
				object obj11 = 0;
				UnityEngine.Object obj12 = null;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X8_v8+28]");
				bool flag4 = (UnityEngine.Object)0 == null;
				bool flag5 = !flag4;
				object obj13 = !flag5;
				object obj10 = 0;
				nint num = unchecked((nint)null);
				object obj11 = 0;
				UnityEngine.Object obj12 = null;
				if (obj13 != null)
				{
					goto IL_0101;
				}
			}
			object obj14 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1736;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj15 = (nint)0 + (nint)64;
			func..ctor((object)<>c__DisplayClass80_, (IntPtr)obj15);
			int num2 = Enumerable.Count(layers, func);
			LayerConfigReferences configRef = <>c__DisplayClass80_.configRef;
			LogoLayerConfig layerConfig = configRef.layerConfig;
			GameObject gameObject = configRef.belowMinButton.gameObject;
			bool flag6 = (object)gameObject == null;
			object obj16 = !flag6;
			if (obj16 != null)
			{
				object obj17 = num2 - layerConfig.MinInstances;
				bool flag7 = (nint)obj17 < 0;
				int num3 = num2 ^ layerConfig.MinInstances;
				int num4 = num2 ^ obj17;
				int num5 = num3 & num4;
				bool flag8 = num5 < 0;
				bool flag9 = flag7 == flag8;
				bool flag10 = !flag9;
				gameObject.SetActive(flag10);
				object obj10 = 0;
				nint num = (flag10 ? 1 : 0);
				goto IL_0101;
			}
			throw new NullReferenceException();
			IL_0101:
			obj4++;
			if ((nint)obj4 < array.Length)
			{
				continue;
			}
			return;
		}
		throw new IndexOutOfRangeException();
	}

	private void OnBelowMinButtonClicked(LayerConfigReferences configRef)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0045: Expected O, but got I
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_0085: Expected I, but got O
		//IL_008d: Expected I4, but got O
		//IL_00b7: Expected I4, but got I8
		//IL_00d1: Expected O, but got I4
		//IL_00da: Expected O, but got I4
		//IL_00e2: Expected I4, but got O
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Expected O, but got Unknown
		//IL_0143: Expected O, but got I
		//IL_014f: Expected O, but got I
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Expected O, but got Unknown
		//IL_017e: Expected I, but got O
		//IL_010d: Expected O, but got I4
		//IL_0263: Expected O, but got I4
		//IL_01c3: Expected O, but got I
		//IL_01f2: Expected O, but got I
		//IL_0238: Expected O, but got I
		//IL_02ae: Expected O, but got I4
		object obj = typeof(CardUtils.<>c) + 1000;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		<>c__DisplayClass81_0 <>c__DisplayClass81_ = default(<>c__DisplayClass81_0);
		<>c__DisplayClass81_..ctor();
		object obj2 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 344;
		object obj3 = (nint)0 + (nint)72;
		object obj4 = (nint)0 + (nint)1968;
		object obj5 = <>c__DisplayClass81_ + 16;
		obj5 = configRef;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<object, bool> func = default(Func<object, bool>);
		func..ctor((object)<>c__DisplayClass81_, (IntPtr)obj3);
		bool flag = (byte)(int)obj4 != 0;
		int num = ArraysExtensions.FindIndex(layerConfigs, func);
		int num2 = (int)(num & 0x80000000L);
		bool flag2 = num2 == 0;
		object obj6 = !flag2;
		object obj7 = 0;
		int num3 = (int)func;
		if (obj6 == null)
		{
			layerTabs.Activate(num);
			obj7 = 0;
			flag = true;
			num3 = num;
		}
		object obj8 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1736;
		object obj9 = (nint)0 + (nint)80;
		object obj10 = (nint)0 + (nint)920;
		object obj11 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<object, bool> func2 = default(Func<object, bool>);
		func2..ctor((object)<>c__DisplayClass81_, (IntPtr)obj9);
		object obj12 = Enumerable.FirstOrDefault(layers, func2);
		UnityEngine.Object obj13;
		UnityEngine.Object obj15;
		if (obj12 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X0_v17 (System.Object)+48]");
			obj13 = (UnityEngine.Object)0;
			object obj14 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X0_v19+E4]");
			bool flag3 = (nint)0 == 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X0_v17 (System.Object)+48]");
			obj15 = (UnityEngine.Object)0;
			if (!flag3)
			{
				goto IL_0200;
			}
		}
		else
		{
			object obj14 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X0_v19+E4]");
			bool flag4 = (nint)0 == 0;
			object obj16 = !flag4;
			obj13 = null;
			obj15 = null;
			if (obj16 != null)
			{
				goto IL_0200;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag5 = obj15 != null;
		bool flag6 = !flag5;
		object obj17 = !flag6;
		if (obj17 == null)
		{
			return;
		}
		goto IL_0227;
		IL_0200:
		if (obj13 != null)
		{
			goto IL_0227;
		}
		return;
		IL_0227:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X0_v17 (System.Object)+48]");
		((ClanLogoImageSelector)0).OpenSelector();
	}

	private void OnSelectorColorSelected(IconLayer layer, Color color, Action undoAction)
	{
		//IL_000e: Expected O, but got I4
		layer.SetColor((Color)0);
		SelectLayer(layer);
		if ((object)color != null)
		{
			AddUndo(layer);
		}
	}

	private void OnSelectorOrderChangeRequested(IconLayer layer, int delta)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		//IL_007b: Expected I, but got O
		//IL_00c9: Expected I4, but got I8
		//IL_00e3: Expected O, but got I4
		object obj = typeof(CardUtils.<>c) + 1008;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		<>c__DisplayClass83_0 <>c__DisplayClass83_ = default(<>c__DisplayClass83_0);
		<>c__DisplayClass83_..ctor();
		object obj2 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1736;
		object obj3 = (nint)0 + (nint)88;
		object obj4 = <>c__DisplayClass83_ + 16;
		obj4 = layer;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<object, bool> func = default(Func<object, bool>);
		func..ctor((object)<>c__DisplayClass83_, (IntPtr)obj3);
		IEnumerable<object> source = Enumerable.Where(layers, func);
		List<object> list = Enumerable.ToList(source);
		int num = list.IndexOf(obj4);
		int num2 = (int)(num & 0x80000000L);
		bool flag = num2 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			int newOrderInGroup = num + delta;
			SetLayerOrderInGroup((IconLayer)obj4, newOrderInGroup, addUndo: true);
		}
	}

	private unsafe void OnSelectorDropRequested(IconLayer layer, Vector2 screenPos, Camera cam)
	{
		//IL_0016: Expected O, but got Ref
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0046: Expected O, but got I4
		object obj = default(object);
		IntPtr intPtr = default(IntPtr);
		int num = ComputeHypotheticalDropOrder(layer, screenPos, (Camera)(&obj), out *(int*)intPtr);
		object obj2 = obj & 0x80000000L;
		bool flag = obj2 == null;
		object obj3 = !flag;
		if (obj3 == null)
		{
			if (num == (nint)obj)
			{
				ApplyLayerSiblingOrder();
			}
			else
			{
				SetLayerOrderInGroup(layer, num, addUndo: true);
			}
		}
	}

	private void OnSelectorDragBegan(IconLayer layer)
	{
		if (!_layoutsCaptured)
		{
			CaptureSlotsAndDisableLayouts();
		}
	}

	private unsafe void OnSelectorDragMoved(IconLayer layer, Vector2 screenPos, Camera cam)
	{
		//IL_0038: Expected O, but got Ref
		//IL_004e: Expected I4, but got I8
		//IL_0068: Expected O, but got I4
		if (_layoutsCaptured)
		{
			int num = default(int);
			IntPtr intPtr = default(IntPtr);
			int hypotheticalOrder = ComputeHypotheticalDropOrder(layer, screenPos, (Camera)(&num), out *(int*)intPtr);
			int num2 = (int)(num & 0x80000000L);
			bool flag = num2 == 0;
			object obj = !flag;
			if (obj == null)
			{
				PreviewReorder(layer, num, hypotheticalOrder);
			}
		}
	}

	private unsafe int ComputeHypotheticalDropOrder(IconLayer layer, Vector2 screenPos, Camera cam, out int currentOrder)
	{
		//IL_0644: Expected O, but got I8
		//IL_0637: Expected I4, but got O
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_0146: Expected O, but got I4
		//IL_0104: Expected O, but got I4
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Expected O, but got Unknown
		//IL_01f7: Expected O, but got I4
		//IL_0226: Expected O, but got Ref
		//IL_0195: Expected O, but got I4
		//IL_019e: Expected O, but got I4
		//IL_057a: Expected I4, but got I8
		//IL_02bc: Expected O, but got I4
		//IL_02ce: Expected I4, but got I8
		//IL_02e8: Expected O, but got I4
		//IL_032b: Expected O, but got I
		//IL_06b9: Expected O, but got I4
		//IL_06dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e2: Expected I4, but got Unknown
		//IL_0717: Expected O, but got I4
		//IL_073b: Expected O, but got I4
		//IL_075f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0764: Expected I4, but got Unknown
		//IL_0799: Expected O, but got I4
		//IL_0496: Expected O, but got I
		//IL_04b9: Expected O, but got I4
		//IL_0449: Expected O, but got I
		//IL_0467: Expected O, but got I4
		//IL_04fd: Expected O, but got I
		Camera camera = (Camera)4294967295L;
		object obj;
		UnityEngine.Object obj4;
		object obj8;
		UnityEngine.Object obj9;
		if (layer != null && (object)layer.Selector != null)
		{
			Transform transform = layer.Selector.transform;
			if ((object)transform != null)
			{
				obj = typeof(MemberAchievementClanFeedData) + 2976;
				Transform parent = transform.parent;
				UnityEngine.Object obj5;
				if ((object)parent != null)
				{
					object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 3600;
					Transform transform2 = ((parent != obj2) ? null : parent);
					object obj3 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ X0_v40+E4]");
					bool flag = (nint)0 == 0;
					obj4 = transform2;
					obj5 = transform2;
					if (!flag)
					{
						goto IL_00de;
					}
				}
				else
				{
					object obj3 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ X0_v40+E4]");
					bool flag2 = (nint)0 == 0;
					object obj6 = !flag2;
					obj4 = null;
					obj5 = null;
					if (obj6 != null)
					{
						goto IL_00de;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag3 = obj5 == null;
				bool flag4 = !flag3;
				object obj7 = !flag4;
				obj8 = 0;
				obj9 = null;
				obj4 = obj5;
				if (obj7 == null)
				{
					goto IL_01b9;
				}
				goto IL_056d;
			}
		}
		goto IL_0629;
		IL_01b9:
		object obj10 = typeof(System.Buffers.Text.ParserHelpers) + 3608;
		object obj11 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X0_v11+E4]");
		bool flag5 = (nint)0 == 0;
		object obj12 = !flag5;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj13 = default(object);
		if (!RectTransformUtility.ScreenPointToLocalPointInRectangle((RectTransform)obj4, screenPos, (Camera)(&obj13), out *(Vector2*)null))
		{
			goto IL_056d;
		}
		LogoLayerConfig layerConfig = layer.layerConfig;
		if ((object)layer.layerConfig != null)
		{
			FillDragGroupBuffer(layerConfig.Layer);
			if (_dragGroupBuffer != null)
			{
				int num = ((List<object>)(object)_dragGroupBuffer).IndexOf((object)layer);
				camera = (Camera)num;
				int num2 = (int)(num & 0x80000000L);
				bool flag6 = num2 == 0;
				object obj14 = !flag6;
				if (obj14 != null)
				{
					goto IL_056d;
				}
				List<object> dragGroupBuffer = (List<object>)(object)_dragGroupBuffer;
				if (_dragGroupBuffer != null)
				{
					object obj15 = (nint)0 + (nint)760;
					int num3 = 0;
					int num4 = 0;
					int num5 = 0;
					object obj20 = default(object);
					object obj21 = default(object);
					do
					{
						bool isNotNull;
						if (num5 < dragGroupBuffer._size)
						{
							object obj16 = dragGroupBuffer.get_Item(num5);
							if (obj16 == null)
							{
								break;
							}
							isNotNull = ((IconLayer)obj16).IsNotNull;
							if (obj16 != layer)
							{
								object obj17 = obj;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v458 @ X0_v27+E4]");
								if ((nint)0 != 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X0_v25 (System.Object)+48]");
									bool flag7 = (UnityEngine.Object)0 == null;
									bool flag8 = !flag7;
									object obj18 = !flag8;
									if (obj18 != null)
									{
										goto IL_034b;
									}
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X0_v25 (System.Object)+48]");
									bool flag9 = (UnityEngine.Object)0 == null;
									bool flag10 = !flag9;
									object obj19 = !flag10;
									if (obj19 != null)
									{
										goto IL_034b;
									}
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X0_v25 (System.Object)+48]");
								if ((nint)0 == 0)
								{
									break;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X0_v25 (System.Object)+48]");
								Transform transform3 = ((Component)0).transform;
								if ((object)transform3 == null)
								{
									break;
								}
								Vector3 localPosition = transform3.localPosition;
								bool flag11 = obj20 <= obj21;
								object obj22 = obj21;
								if (!flag11)
								{
									num4++;
									obj22 = obj21;
								}
							}
							goto IL_034b;
						}
						int num6;
						int num7;
						if (layer.IsNotNull)
						{
							num6 = 0;
							num7 = num3;
						}
						else
						{
							List<IconLayer> dragGroupBuffer2 = _dragGroupBuffer;
							if (_dragGroupBuffer == null)
							{
								break;
							}
							num7 = dragGroupBuffer2._size;
							num6 = num3;
						}
						int num8 = num7 - 1;
						object obj23 = num4 - num8;
						bool flag12 = (nint)obj23 < 0;
						int num9 = num4 ^ num8;
						int num10 = num4 ^ obj23;
						int num11 = num9 & num10;
						bool flag13 = num11 < 0;
						bool flag14 = flag12 == flag13;
						object obj24 = !flag14;
						object obj25 = ~obj24;
						if (obj25 == null)
						{
							num8 = num4;
						}
						object obj26 = num4 - num6;
						bool flag15 = (nint)obj26 < 0;
						int num12 = num4 ^ num6;
						int num13 = num4 ^ obj26;
						int num14 = num12 & num13;
						bool flag16 = num14 < 0;
						bool flag17 = flag15 == flag16;
						object obj27 = !flag17;
						object obj28 = ~obj27;
						if (obj28 == null)
						{
							return num6;
						}
						return num8;
						IL_034b:
						num3 += (isNotNull ? 1 : 0);
						num5++;
						dragGroupBuffer = (List<object>)(object)_dragGroupBuffer;
					}
					while (_dragGroupBuffer != null);
				}
			}
		}
		goto IL_0629;
		IL_0629:
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
		IL_056d:
		return -1;
		IL_00de:
		bool flag18 = obj4 == null;
		bool flag19 = !flag18;
		obj8 = 0;
		obj9 = null;
		if (flag19)
		{
			goto IL_01b9;
		}
		goto IL_056d;
	}

	private void PreviewReorder(IconLayer dragged, int currentOrder, int hypotheticalOrder)
	{
		//IL_011c: Expected O, but got I
		//IL_014a: Expected O, but got I
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected O, but got Unknown
		//IL_016a: Expected O, but got I
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Expected O, but got Unknown
		//IL_02f6: Expected O, but got I
		//IL_0319: Expected O, but got I4
		//IL_0299: Expected O, but got I
		//IL_02b7: Expected O, but got I4
		//IL_037f: Expected O, but got I
		//IL_0397: Unknown result type (might be due to invalid IL or missing references)
		//IL_039c: Expected O, but got Unknown
		//IL_04e3: Expected O, but got I4
		//IL_0498: Expected O, but got I4
		//IL_01b4: Expected O, but got I4
		//IL_01c9: Expected O, but got I
		LogoLayerConfig layerConfig = dragged.layerConfig;
		if (!((Dictionary<System.Int32Enum, object>)(object)_slotPositions).TryGetValue((System.Int32Enum)layerConfig.Layer, out object value))
		{
			return;
		}
		FillDragGroupBuffer(layerConfig.Layer);
		List<object> dragPreviewBuffer = (List<object>)(object)_dragPreviewBuffer;
		int version = dragPreviewBuffer._version + 1;
		dragPreviewBuffer._size = 0;
		dragPreviewBuffer._version = version;
		if (dragPreviewBuffer._size >= 1)
		{
			Array.Clear(dragPreviewBuffer._items, 0, dragPreviewBuffer._size);
			dragPreviewBuffer = (List<object>)(object)_dragPreviewBuffer;
		}
		dragPreviewBuffer.AddRange(_dragGroupBuffer);
		((List<object>)(object)_dragPreviewBuffer).RemoveAt(currentOrder);
		object obj = (nint)0 + (nint)736;
		((List<object>)(object)_dragPreviewBuffer).Insert(hypotheticalOrder, (object)dragged);
		List<object> dragPreviewBuffer2 = (List<object>)(object)_dragPreviewBuffer;
		object obj2 = (nint)0 + (nint)760;
		object obj3 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj4 = (nint)0 + (nint)3352;
		object obj5 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
		int num = 0;
		float num2 = default(float);
		float num3 = default(float);
		while (true)
		{
			if (num >= dragPreviewBuffer2._size)
			{
				return;
			}
			object obj6 = dragPreviewBuffer2.get_Item(num);
			bool flag = obj6 == dragged;
			num2 = num2;
			num3 = num3;
			if (!flag)
			{
				object obj7 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v456 @ X0_v15+E4]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X0_v14 (System.Object)+48]");
					bool flag2 = (UnityEngine.Object)0 == null;
					bool flag3 = !flag2;
					object obj8 = !flag3;
					num2 = num2;
					num3 = num3;
					if (obj8 != null)
					{
						goto IL_01dc;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X0_v14 (System.Object)+48]");
					bool flag4 = (UnityEngine.Object)0 == null;
					bool flag5 = !flag4;
					object obj9 = !flag5;
					num2 = num2;
					num3 = num3;
					if (obj9 != null)
					{
						goto IL_01dc;
					}
				}
				int num4 = num;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ stack_-98_v4 (System.Object)+18]");
				bool flag6 = (nint)num4 >= (nint)0;
				num2 = num2;
				num3 = num3;
				if (!flag6)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X0_v14 (System.Object)+48]");
					Transform transform = ((Component)0).transform;
					object obj10 = typeof(System.Buffers.Text.ParserHelpers) + 3600;
					if (transform != obj10)
					{
						break;
					}
					Vector2 anchoredPosition = ((RectTransform)transform).anchoredPosition;
					Vector2 vector = ((List<Vector2>)value).get_Item(num);
					object obj11 = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v483 @ X0_v26+E4]");
					bool flag7 = (nint)0 == 0;
					object obj12 = !flag7;
					if (obj12 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					float num5 = num2 - num2;
					float num6 = num3 - num3;
					num2 = num6 * num6;
					float num7 = num5 * num5;
					num3 = num2 + num7;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
					if (!((double)num3 < 0.5))
					{
						int num8 = ShortcutExtensions.DOKill(transform);
						bool flag8 = value == null;
						object obj13 = !flag8;
						if (obj13 == null)
						{
							throw new NullReferenceException();
						}
						Vector2 vector2 = ((List<Vector2>)value).get_Item(num);
						TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTweenModuleUI.DOAnchorPos((RectTransform)transform, (Vector2)0, num3);
						object obj14 = (nint)0 + (nint)2872;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
					}
				}
			}
			goto IL_01dc;
			IL_01dc:
			num++;
			dragPreviewBuffer2 = (List<object>)(object)_dragPreviewBuffer;
		}
		throw new InvalidCastException();
	}

	private void FillDragGroupBuffer(ClanLogoLayer groupEnum)
	{
		//IL_0091: Expected O, but got I
		//IL_011b: Expected O, but got I
		//IL_01bc: Expected O, but got I4
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Expected O, but got Unknown
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Expected O, but got Unknown
		List<IconLayer> dragGroupBuffer = _dragGroupBuffer;
		int version = dragGroupBuffer._version + 1;
		dragGroupBuffer._size = 0;
		dragGroupBuffer._version = version;
		if (dragGroupBuffer._size >= 1)
		{
			Array.Clear(dragGroupBuffer._items, 0, dragGroupBuffer._size);
		}
		List<object> list = (List<object>)(object)layers;
		object obj = (nint)0 + (nint)760;
		int num = 0;
		while (num < list._size)
		{
			object obj2 = list.get_Item(num);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X0_v7 (System.Object)+18]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X8_v7+18]");
			if ((nint)0 == (nint)groupEnum)
			{
				List<object> dragGroupBuffer2 = (List<object>)(object)_dragGroupBuffer;
				object obj4 = ((List<object>)(object)layers).get_Item(num);
				int version2 = dragGroupBuffer2._version + 1;
				dragGroupBuffer2._version = version2;
				object[] items = dragGroupBuffer2._items;
				bool flag = dragGroupBuffer2._size < items.Length;
				object obj5 = !flag;
				if (obj5 != null)
				{
					dragGroupBuffer2.AddWithResize(obj4);
				}
				else
				{
					int size = dragGroupBuffer2._size + 1;
					dragGroupBuffer2._size = size;
					object obj6 = items + dragGroupBuffer2._size;
					object obj7 = obj6 + 32;
					obj7 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				}
			}
			num++;
			list = (List<object>)(object)layers;
		}
	}

	private unsafe void SortEmptiesToEnd()
	{
		//IL_000f: Expected O, but got I4
		//IL_0fd7: Expected O, but got I4
		//IL_0fe7: Expected O, but got I
		//IL_0d13: Expected O, but got I4
		//IL_0d34: Expected O, but got I4
		//IL_0061: Expected O, but got I4
		//IL_007a: Expected O, but got I4
		//IL_0093: Expected O, but got I4
		//IL_0d90: Expected O, but got I4
		//IL_0dcc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dd1: Expected O, but got Unknown
		//IL_0dda: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ddf: Expected O, but got Unknown
		//IL_00d7: Expected O, but got I
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected O, but got Unknown
		//IL_00f7: Expected O, but got I
		//IL_0103: Expected O, but got I
		//IL_1272: Expected O, but got I4
		//IL_0f3e: Expected O, but got Ref
		//IL_0f46: Expected O, but got Ref
		//IL_0f4f: Expected O, but got I4
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Expected O, but got Unknown
		//IL_0f63: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f68: Expected O, but got Unknown
		//IL_1044: Unknown result type (might be due to invalid IL or missing references)
		//IL_1049: Expected O, but got Unknown
		//IL_0185: Expected O, but got I
		//IL_0e1b: Expected O, but got I4
		//IL_0bc9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bce: Expected O, but got Unknown
		//IL_0bde: Expected O, but got Ref
		//IL_0be6: Expected O, but got Ref
		//IL_0bef: Expected O, but got I4
		//IL_0bf8: Expected O, but got I4
		//IL_12fb: Expected I4, but got O
		//IL_0229: Unknown result type (might be due to invalid IL or missing references)
		//IL_022e: Expected O, but got Unknown
		//IL_01f2: Expected I4, but got O
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Expected O, but got Unknown
		//IL_0f9f: Expected O, but got I4
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Expected O, but got Unknown
		//IL_0c05: Expected I, but got O
		//IL_0c15: Expected O, but got I
		//IL_0c50: Expected O, but got I
		//IL_031a: Expected O, but got I4
		//IL_02b6: Expected O, but got I
		//IL_0c5e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c63: Expected O, but got Unknown
		//IL_0c6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c71: Expected O, but got Unknown
		//IL_0328: Unknown result type (might be due to invalid IL or missing references)
		//IL_032d: Expected I4, but got Unknown
		//IL_0335: Unknown result type (might be due to invalid IL or missing references)
		//IL_033a: Expected O, but got Unknown
		//IL_0343: Unknown result type (might be due to invalid IL or missing references)
		//IL_0348: Expected O, but got Unknown
		//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c9: Expected O, but got Unknown
		//IL_0381: Unknown result type (might be due to invalid IL or missing references)
		//IL_0386: Expected O, but got Unknown
		//IL_038e: Expected I4, but got O
		//IL_03ec: Expected I4, but got O
		//IL_03fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0400: Expected O, but got Unknown
		//IL_041b: Expected O, but got I
		//IL_042c: Expected I, but got O
		//IL_0458: Expected O, but got I
		//IL_0460: Expected I4, but got O
		//IL_0f0c: Expected O, but got I4
		//IL_04a7: Expected O, but got I4
		//IL_056a: Expected O, but got I
		//IL_057a: Expected O, but got I
		//IL_059c: Expected O, but got I4
		//IL_05a5: Expected O, but got I4
		//IL_04fa: Expected O, but got I
		//IL_050a: Expected O, but got I
		//IL_052c: Expected O, but got I4
		//IL_0535: Expected O, but got I4
		//IL_06cf: Expected O, but got I
		//IL_06df: Expected O, but got I
		//IL_0701: Expected O, but got I4
		//IL_05e5: Expected O, but got I4
		//IL_0793: Expected O, but got I
		//IL_0668: Expected O, but got I
		//IL_0678: Expected O, but got I
		//IL_069a: Expected O, but got I4
		//IL_10ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_10f3: Expected O, but got Unknown
		//IL_1109: Expected O, but got I
		//IL_111a: Expected I, but got O
		//IL_1138: Expected O, but got I
		//IL_1153: Expected O, but got I4
		//IL_07b6: Expected O, but got I
		//IL_07be: Expected I4, but got O
		//IL_0741: Expected O, but got I4
		//IL_0615: Expected O, but got I
		//IL_116f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1174: Expected O, but got Unknown
		//IL_118a: Expected O, but got I
		//IL_119b: Expected I, but got O
		//IL_11b9: Expected O, but got I
		//IL_11e4: Expected O, but got I4
		//IL_0823: Expected I4, but got O
		//IL_0771: Expected O, but got I
		//IL_0885: Expected I4, but got O
		//IL_08a8: Expected I4, but got O
		//IL_086b: Expected I4, but got O
		//IL_08c6: Expected O, but got I
		//IL_08ed: Expected I4, but got O
		//IL_0a81: Expected I4, but got O
		//IL_0ab4: Expected I4, but got O
		//IL_0e95: Expected I4, but got O
		//IL_0ad2: Expected O, but got I
		//IL_0b09: Expected I4, but got O
		//IL_093a: Unknown result type (might be due to invalid IL or missing references)
		//IL_093f: Expected O, but got Unknown
		//IL_096a: Expected I4, but got O
		//IL_098f: Expected I4, but got O
		//IL_0b4a: Expected I4, but got O
		//IL_11f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_11f7: Expected O, but got Unknown
		//IL_0b77: Expected I4, but got O
		//IL_0ec8: Expected I4, but got O
		//IL_0bb5: Expected I4, but got O
		//IL_09ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f1: Expected O, but got Unknown
		//IL_0a0b: Expected I4, but got O
		object obj = 147423232 + 1984;
		object obj2 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X20_v4+E0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v3+E4]");
		Type typeFromHandle;
		nint num;
		RuntimeTypeHandle runtimeTypeHandle;
		ClanLogoLayer clanLogoLayer2;
		Type enumType;
		IntPtr intPtr;
		RuntimeTypeHandle runtimeTypeHandle2;
		ClanLogoLayer clanLogoLayer;
		if ((nint)0 != 0)
		{
			typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)obj);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X20_v4+98]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X8_v13 (Il2CppClass<System.NullReferenceException>)+E4]");
			clanLogoLayer = ClanLogoLayer.Rim;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X8_v13 (Il2CppClass<System.NullReferenceException>)+E4]");
			bool flag = (nint)0 == 0;
			runtimeTypeHandle = (RuntimeTypeHandle)152993792;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X8_v13 (Il2CppClass<System.NullReferenceException>)+E4]");
			clanLogoLayer2 = ClanLogoLayer.Rim;
			object obj4 = 0;
			enumType = typeFromHandle;
			intPtr = num;
			runtimeTypeHandle2 = (RuntimeTypeHandle)152993792;
			if (!flag)
			{
				goto IL_00a1;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)obj);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X20_v4+98]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X8_v13 (Il2CppClass<System.NullReferenceException>)+E4]");
			clanLogoLayer = ClanLogoLayer.Rim;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X8_v13 (Il2CppClass<System.NullReferenceException>)+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			runtimeTypeHandle = (RuntimeTypeHandle)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X8_v13 (Il2CppClass<System.NullReferenceException>)+E4]");
			clanLogoLayer2 = ClanLogoLayer.Rim;
			object obj4 = 0;
			enumType = typeFromHandle;
			intPtr = num;
			runtimeTypeHandle2 = (RuntimeTypeHandle)obj;
			if (obj5 != null)
			{
				goto IL_00a1;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Array values = Enum.GetValues(enumType);
		bool flag3 = values == null;
		object obj6 = !flag3;
		clanLogoLayer = clanLogoLayer2;
		num = intPtr;
		runtimeTypeHandle = runtimeTypeHandle2;
		if (obj6 != null)
		{
			goto IL_00cb;
		}
		goto IL_0db6;
		IL_1258:
		object obj7 = default(object);
		bool flag4 = obj7 == null;
		object obj8 = !flag4;
		Func<object, bool> func = default(Func<object, bool>);
		IEnumerable<object> enumerable = (IEnumerable<object>)(object)func;
		if (obj8 == null)
		{
			if ((nint)runtimeTypeHandle != 9)
			{
				bool flag5 = (object)runtimeTypeHandle == null;
				object obj9 = !flag5;
				if (obj9 != null)
				{
					return;
				}
			}
			ApplyLayerSiblingOrder();
			return;
		}
		goto IL_132a;
		IL_12f3:
		object obj10;
		int num2 = (int)obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
		NullReferenceException ex = default(NullReferenceException);
		object obj11 = ex;
		object obj14 = default(object);
		if (ex != null)
		{
			num = (nint)ex;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X8_v13 (Il2CppClass<System.NullReferenceException>)+12E]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X8_v13 (Il2CppClass<System.NullReferenceException>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0c99;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X8_v13 (Il2CppClass<System.NullReferenceException>)+B0]");
			object obj13 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X10_v6-8]");
				bool flag6 = 0 == (nint)obj10;
				obj14 = obj13;
				if (flag6)
				{
					break;
				}
				obj14 = obj13 + 16;
				obj12--;
				bool flag7 = (nint)obj12 != 1;
				obj13 = obj14;
				if (flag7)
				{
					continue;
				}
				goto IL_0c99;
			}
			goto IL_0dc4;
		}
		goto IL_1258;
		IL_132a:
		OutOfMemoryException ex2 = new OutOfMemoryException();
		obj10 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
		if (num2 == 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			func = (Func<object, bool>)(object)enumerable;
			object obj15 = default(object);
			obj7 = obj15;
			runtimeTypeHandle = (RuntimeTypeHandle)0;
			goto IL_12f3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99B68");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return;
		IL_00a1:
		values = Enum.GetValues(typeFromHandle);
		if (values != null)
		{
			goto IL_00cb;
		}
		goto IL_0db6;
		IL_0db6:
		ex = new NullReferenceException();
		goto IL_0dc4;
		IL_00cb:
		object obj16 = (nint)0 + (nint)3504;
		object obj17 = typeof(CardUtils.<>c) + 936;
		object obj18 = (nint)0 + (nint)760;
		object obj19 = (nint)0 + (nint)768;
		IEnumerator enumerator = values.GetEnumerator();
		num2 = 0;
		object obj20 = default(object);
		IEnumerable<object> source = default(IEnumerable<object>);
		<>c__DisplayClass90_0 <>c__DisplayClass90_ = default(<>c__DisplayClass90_0);
		List<object> list6 = default(List<object>);
		object obj38 = default(object);
		Func<object, bool> func3 = default(Func<object, bool>);
		object obj51 = default(object);
		object obj57 = default(object);
		object obj60 = default(object);
		Func<object, bool> func4 = default(Func<object, bool>);
		Func<object, bool> func5 = default(Func<object, bool>);
		object obj52;
		object obj26;
		while (true)
		{
			if (obj20 != null)
			{
				enumerable = (IEnumerable<object>)(typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528);
				object obj21 = obj20;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ X8_v24+12E]");
				clanLogoLayer = ClanLogoLayer.Rim;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ X8_v24+12E]");
				if ((nint)0 == 0)
				{
					goto IL_01d6;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ X8_v24+B0]");
				object obj22 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v539 @ X10_v23-8]");
					if (0 == (nint)enumerable)
					{
						break;
					}
					obj14 = obj22 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ X8_v24+12E]");
					clanLogoLayer = (ClanLogoLayer)(-1);
					bool flag8 = clanLogoLayer != ClanLogoLayer.Icon;
					obj22 = obj14;
					if (flag8)
					{
						continue;
					}
					goto IL_01d6;
				}
				clanLogoLayer = (ClanLogoLayer)obj22;
				object obj23 = obj21 + obj22;
				object obj24 = obj23 + 312;
				obj14 = obj22;
				goto IL_1031;
			}
			NullReferenceException ex3 = new NullReferenceException();
			enumerable = (IEnumerable<object>)(object)func;
			goto IL_0f35;
			IL_0e43:
			NullReferenceException ex4 = new NullReferenceException();
			IEnumerable<object> enumerable2;
			enumerable = enumerable2;
			goto IL_0f35;
			IL_0776:
			List<object> list;
			Func<object, bool> predicate;
			IEnumerable<object> enumerable3 = Enumerable.Where(list, predicate);
			object obj25 = (nint)0 + (nint)3136;
			obj26 = obj25;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D95D88");
			object obj27 = (nint)0 + (nint)2176;
			num2 = (int)obj27;
			List<object> list2 = Enumerable.ToList(source);
			List<object> list3 = (List<object>)(object)layers;
			bool flag9 = layers == null;
			IEnumerable<object> enumerable4;
			enumerable = enumerable4;
			List<object> list4;
			object obj29;
			object obj30;
			if (!flag9)
			{
				bool flag10 = list2 == null;
				object obj28 = obj25;
				ClanLogoLayer clanLogoLayer3 = clanLogoLayer;
				int num3 = (int)obj27;
				list4 = list2;
				if (!flag10)
				{
					List<object> list5 = list6;
					Func<object, bool> func2 = null;
					obj29 = obj30;
					object obj31 = obj25;
					enumerable2 = null;
					clanLogoLayer3 = clanLogoLayer;
					int num4 = (int)obj27;
					while (true)
					{
						bool flag11 = (nint)func2 >= list3._size;
						list6 = list5;
						predicate = func2;
						obj30 = obj29;
						obj26 = obj31;
						func = (Func<object, bool>)(object)enumerable2;
						clanLogoLayer = clanLogoLayer3;
						num2 = num4;
						if (flag11)
						{
							break;
						}
						obj26 = obj18;
						object obj32 = list3.get_Item((int)func2);
						bool flag12 = obj32 == null;
						list6 = list5;
						predicate = func2;
						obj30 = obj29;
						num2 = (int)func2;
						if (flag12)
						{
							goto IL_0e43;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1062 @ X0_v81 (System.Object)+18]");
						object obj33 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1062 @ X0_v81 (System.Object)+18]");
						bool flag13 = (nint)0 == 0;
						list6 = list5;
						predicate = func2;
						obj30 = obj29;
						num2 = (int)func2;
						if (!flag13)
						{
							clanLogoLayer3 = <>c__DisplayClass90_.enumValue;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1068 @ X8_v61+18]");
							bool flag14 = (nint)0 != (nint)<>c__DisplayClass90_.enumValue;
							num4 = (int)func2;
							if (!flag14)
							{
								list6 = (List<object>)(object)layers;
								obj26 = obj18;
								object obj34 = list2.get_Item((int)enumerable2);
								if (layers == null)
								{
									goto IL_0e9a;
								}
								obj29 = obj19;
								((List<object>)(object)layers).set_Item((int)func2, obj34);
								enumerable2 = (IEnumerable<object>)(enumerable2 + 1);
								list5 = (List<object>)(object)layers;
								obj26 = obj34;
								num4 = (int)func2;
							}
							func2 = (Func<object, bool>)(func2 + 1);
							list3 = (List<object>)(object)layers;
							bool flag15 = layers == null;
							obj31 = obj26;
							list6 = list5;
							predicate = func2;
							obj30 = obj29;
							enumerable = enumerable2;
							clanLogoLayer = clanLogoLayer3;
							num2 = num4;
							if (!flag15)
							{
								continue;
							}
							goto IL_0e35;
						}
						goto IL_0e59;
					}
					continue;
				}
				while ((nint)list4 < list3._size)
				{
					obj26 = obj18;
					object obj35 = list3.get_Item((int)list4);
					bool flag16 = obj35 == null;
					enumerable2 = enumerable4;
					num2 = (int)list4;
					if (flag16)
					{
						goto IL_0e43;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1059 @ X0_v77 (System.Object)+18]");
					object obj36 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1059 @ X0_v77 (System.Object)+18]");
					bool flag17 = (nint)0 == 0;
					enumerable2 = enumerable4;
					num2 = (int)list4;
					if (flag17)
					{
						goto IL_0e59;
					}
					clanLogoLayer3 = <>c__DisplayClass90_.enumValue;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1065 @ X8_v57+18]");
					if ((nint)0 != (nint)<>c__DisplayClass90_.enumValue)
					{
						List<object> list7 = (List<object>)(list4 + 1);
						list3 = (List<object>)(object)layers;
						bool flag18 = layers == null;
						obj28 = obj18;
						num3 = (int)list4;
						list4 = list7;
						enumerable = enumerable4;
						clanLogoLayer = <>c__DisplayClass90_.enumValue;
						num2 = (int)list7;
						if (!flag18)
						{
							continue;
						}
						goto IL_0e35;
					}
					goto IL_0e6f;
				}
				obj26 = obj28;
				func = (Func<object, bool>)(object)enumerable4;
				clanLogoLayer = clanLogoLayer3;
				num2 = num3;
				continue;
			}
			goto IL_0e35;
			IL_0e35:
			NullReferenceException ex5 = new NullReferenceException();
			goto IL_0f35;
			IL_0e9a:
			NullReferenceException ex6 = new NullReferenceException();
			obj30 = obj29;
			enumerable = enumerable2;
			clanLogoLayer = <>c__DisplayClass90_.enumValue;
			num2 = (int)enumerable2;
			goto IL_0f35;
			IL_01d6:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			obj26 = null;
			goto IL_1031;
			IL_1031:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v693 @ X0_v40] (should have been resolved before IL gen)");
			object obj37 = obj38 & 1;
			if (obj37 == null)
			{
				break;
			}
			object obj39 = typeof(CardUtils.<>c) + 1016;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			<>c__DisplayClass90_..ctor();
			if (obj20 != null)
			{
				object obj40 = obj20;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v796 @ X8_v29+12E]");
				clanLogoLayer = ClanLogoLayer.Rim;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v796 @ X8_v29+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0307;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v796 @ X8_v29+B0]");
				object obj41 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v853 @ X10_v18-8]");
					if (0 == (nint)enumerable)
					{
						break;
					}
					obj14 = obj41 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v796 @ X8_v29+12E]");
					clanLogoLayer = (ClanLogoLayer)(-1);
					bool flag19 = clanLogoLayer != ClanLogoLayer.Icon;
					obj41 = obj14;
					if (flag19)
					{
						continue;
					}
					goto IL_0307;
				}
				clanLogoLayer = (ClanLogoLayer)(obj41 + 1);
				object obj42 = obj40 + clanLogoLayer;
				object obj43 = obj42 + 312;
				obj14 = obj41;
				goto IL_108b;
			}
			NullReferenceException ex7 = new NullReferenceException();
			num2 = 0;
			goto IL_0f35;
			IL_0e6f:
			NullReferenceException ex8 = new NullReferenceException();
			enumerable = enumerable4;
			clanLogoLayer = <>c__DisplayClass90_.enumValue;
			num2 = (int)list4;
			goto IL_0f35;
			IL_05b3:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v940 @ X0_v98+E4]");
			clanLogoLayer = ClanLogoLayer.Rim;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v940 @ X0_v98+E4]");
			bool flag20 = (nint)0 == 0;
			object obj44 = !flag20;
			object obj46;
			if (obj44 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj45 = obj17;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v960 @ X8_v81+B8]");
				obj46 = 0;
			}
			object obj47 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1736;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj48 = (nint)0 + (nint)4032;
			func3..ctor(obj46, (IntPtr)obj48);
			object obj49 = obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v932 @ X8_v80+B8]");
			object obj50 = (nint)0 + (nint)56;
			obj50 = func3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj30 = 0;
			Func<object, bool> predicate2 = func3;
			goto IL_061a;
			IL_0f35:
			obj11 = (object)(&obj51);
			obj52 = (object)(&obj20);
			obj7 = 0;
			goto IL_132a;
			IL_061a:
			enumerable4 = Enumerable.Where(list, predicate2);
			object obj53 = obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v991 @ X0_v88+E4]");
			object obj54;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v991 @ X0_v88+B8]");
				obj54 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1003 @ X8_v64+40]");
				predicate = (Func<object, bool>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1003 @ X8_v64+40]");
				bool flag21 = (nint)0 == 0;
				object obj55 = !flag21;
				if (obj55 == null)
				{
					goto IL_070f;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj53 = obj17;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v991 @ X0_v88+B8]");
				obj54 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1003 @ X8_v64+40]");
				predicate = (Func<object, bool>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1003 @ X8_v64+40]");
				bool flag22 = (nint)0 == 0;
				object obj56 = !flag22;
				if (obj56 == null)
				{
					goto IL_070f;
				}
			}
			goto IL_0776;
			IL_0e59:
			NullReferenceException ex9 = new NullReferenceException();
			enumerable = enumerable2;
			goto IL_0f35;
			IL_0307:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			obj26 = 1;
			goto IL_108b;
			IL_108b:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v879 @ X0_v46+8]");
			num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v879 @ X0_v46] (should have been resolved before IL gen)");
			if (<>c__DisplayClass90_ != null && obj57 != null)
			{
				object obj58 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1288;
				num2 = (int)obj58;
				object obj59 = obj57;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v513 @ X1_v1 (System.Int32)+40]");
				clanLogoLayer = ClanLogoLayer.Rim;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v887 @ X8_v34+40]");
				nint num5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v513 @ X1_v1 (System.Int32)+40]");
				if (num5 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1960");
					<>c__DisplayClass90_.enumValue = (ClanLogoLayer)obj60;
					object obj61 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1736;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj62 = (nint)0 + (nint)96;
					func4..ctor((object)<>c__DisplayClass90_, (IntPtr)obj62);
					obj26 = obj16;
					IEnumerable<object> source2 = Enumerable.Where(layers, func4);
					object obj63 = (nint)0 + (nint)2176;
					num2 = (int)obj63;
					list = Enumerable.ToList(source2);
					if (list != null)
					{
						bool flag23 = list._size == 0;
						obj30 = 0;
						func = func4;
						if (flag23)
						{
							continue;
						}
						object obj64 = obj17;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v940 @ X0_v98+E4]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v940 @ X0_v98+B8]");
							obj46 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v949 @ X8_v75+38]");
							predicate2 = (Func<object, bool>)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v949 @ X8_v75+38]");
							bool flag24 = (nint)0 == 0;
							object obj65 = !flag24;
							obj30 = 0;
							if (obj65 == null)
							{
								goto IL_05b3;
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj64 = obj17;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v940 @ X0_v98+B8]");
							obj46 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v949 @ X8_v75+38]");
							predicate2 = (Func<object, bool>)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v949 @ X8_v75+38]");
							bool flag25 = (nint)0 == 0;
							object obj66 = !flag25;
							obj30 = 0;
							if (obj66 == null)
							{
								goto IL_05b3;
							}
						}
						goto IL_061a;
					}
					NullReferenceException ex10 = new NullReferenceException();
					obj30 = 0;
					enumerable = (IEnumerable<object>)(object)func4;
				}
				else
				{
					InvalidCastException ex11 = new InvalidCastException();
				}
			}
			else
			{
				NullReferenceException ex12 = new NullReferenceException();
			}
			goto IL_0f35;
			IL_070f:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v991 @ X0_v88+E4]");
			clanLogoLayer = ClanLogoLayer.Rim;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v991 @ X0_v88+E4]");
			bool flag26 = (nint)0 == 0;
			object obj67 = !flag26;
			if (obj67 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj68 = obj17;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1013 @ X8_v70+B8]");
				obj54 = 0;
			}
			object obj69 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1736;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj70 = (nint)0 + (nint)4040;
			func5..ctor(obj54, (IntPtr)obj70);
			object obj71 = obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v981 @ X8_v69+B8]");
			object obj72 = (nint)0 + (nint)64;
			obj72 = func5;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			list6 = (List<object>)obj54;
			predicate = func5;
			obj30 = 0;
			goto IL_0776;
		}
		obj10 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
		func = (Func<object, bool>)(object)enumerable;
		obj11 = (object)(&obj51);
		obj52 = (object)(&obj20);
		obj7 = 0;
		runtimeTypeHandle = (RuntimeTypeHandle)9;
		goto IL_12f3;
		IL_0c99:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		obj26 = null;
		object obj74 = default(object);
		object obj73 = obj74;
		goto IL_12b4;
		IL_12b4:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ X8_v11+8]");
		num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v365 @ X8_v11] (should have been resolved before IL gen)");
		goto IL_1258;
		IL_0dc4:
		object obj75 = num + obj14;
		obj73 = obj75 + 312;
		goto IL_12b4;
	}

	private unsafe void ApplyLayerSiblingOrder()
	{
		//IL_0008: Expected O, but got Ref
		//IL_0bfb: Expected O, but got I4
		//IL_0c12: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c17: Expected O, but got Unknown
		//IL_0c20: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c25: Expected O, but got Unknown
		//IL_002c: Expected O, but got I4
		//IL_0046: Expected O, but got I4
		//IL_0056: Expected O, but got I
		//IL_0ed0: Expected O, but got I
		//IL_0e86: Expected O, but got I4
		//IL_0b3b: Expected O, but got I
		//IL_0b5d: Expected O, but got I4
		//IL_0b6d: Expected O, but got I
		//IL_0b76: Expected O, but got I4
		//IL_00a8: Expected O, but got I
		//IL_00cf: Expected O, but got I
		//IL_00d8: Expected O, but got I4
		//IL_0bca: Expected O, but got I4
		//IL_0140: Expected O, but got Ref
		//IL_0159: Expected O, but got I4
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Expected O, but got Unknown
		//IL_0192: Expected O, but got I
		//IL_019e: Expected O, but got I
		//IL_01a8: Expected O, but got I4
		//IL_0e12: Expected I, but got O
		//IL_0e22: Expected O, but got I
		//IL_0f0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f13: Expected O, but got Unknown
		//IL_0234: Expected O, but got I4
		//IL_0d47: Expected O, but got I
		//IL_0d5a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d5f: Expected O, but got Unknown
		//IL_01d0: Expected O, but got I
		//IL_0a4b: Expected I, but got O
		//IL_0a5b: Expected O, but got I
		//IL_0a22: Expected O, but got Ref
		//IL_0a39: Expected O, but got Ref
		//IL_0af2: Expected O, but got I4
		//IL_0279: Expected O, but got I
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_024e: Expected O, but got Unknown
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Expected O, but got Unknown
		//IL_0a96: Expected O, but got I
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Expected O, but got Unknown
		//IL_01f9: Expected O, but got I
		//IL_02b6: Expected O, but got I
		//IL_0355: Expected O, but got I4
		//IL_0aa4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa9: Expected O, but got Unknown
		//IL_0ab2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab7: Expected O, but got Unknown
		//IL_0db1: Expected O, but got I
		//IL_02f1: Expected O, but got I
		//IL_039f: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a4: Expected O, but got Unknown
		//IL_03c4: Expected O, but got I
		//IL_0363: Unknown result type (might be due to invalid IL or missing references)
		//IL_0368: Expected O, but got Unknown
		//IL_037e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0383: Expected O, but got Unknown
		//IL_02ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0304: Expected O, but got Unknown
		//IL_031a: Expected O, but got I
		//IL_0428: Expected O, but got I
		//IL_043b: Expected I4, but got O
		//IL_047a: Expected O, but got Ref
		//IL_0c8b: Expected O, but got F4
		//IL_0c9c: Expected F4, but got I4
		//IL_04ac: Expected O, but got I
		//IL_0508: Expected O, but got I
		//IL_0517: Unknown result type (might be due to invalid IL or missing references)
		//IL_051c: Expected O, but got Unknown
		//IL_0546: Expected O, but got I4
		//IL_07fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ff: Expected O, but got Unknown
		//IL_0808: Expected O, but got I4
		//IL_05c4: Expected O, but got I
		//IL_05f2: Expected I4, but got O
		//IL_0620: Unknown result type (might be due to invalid IL or missing references)
		//IL_0625: Expected I4, but got Unknown
		//IL_063a: Expected O, but got I
		//IL_0656: Expected O, but got I4
		//IL_065f: Expected O, but got I4
		//IL_0684: Expected O, but got I4
		//IL_068d: Expected O, but got I4
		//IL_06bc: Expected O, but got I4
		//IL_06c5: Expected O, but got I4
		//IL_0709: Expected O, but got I
		//IL_0739: Unknown result type (might be due to invalid IL or missing references)
		//IL_073e: Expected O, but got Unknown
		//IL_07a2: Expected I4, but got O
		//IL_07bd: Expected O, but got I4
		//IL_07d2: Expected O, but got I
		//IL_07ec: Expected O, but got I4
		object obj2 = default(object);
		object obj = (object)(&obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E88A6]");
		nint num = 0;
		Type typeFromHandle;
		Array values;
		if ((object)previewer != null)
		{
			object handle = 147423232 + 1984;
			previewer.ApplySiblingOrder();
			object obj3 = 153100288 + 1024;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X20_v15+E0]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X8_v14+E4]");
			object obj6;
			Type enumType;
			IntPtr intPtr;
			object obj5;
			if ((nint)0 != 0)
			{
				typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)handle);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X20_v15+98]");
				num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X8_v10 (Il2CppClass<System.NullReferenceException>)+E4]");
				obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X8_v10 (Il2CppClass<System.NullReferenceException>)+E4]");
				bool flag = (nint)0 == 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X8_v10 (Il2CppClass<System.NullReferenceException>)+E4]");
				obj6 = 0;
				object obj7 = 0;
				enumType = typeFromHandle;
				intPtr = num;
				if (!flag)
				{
					goto IL_00f6;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)handle);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X20_v15+98]");
				num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X8_v10 (Il2CppClass<System.NullReferenceException>)+E4]");
				obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X8_v10 (Il2CppClass<System.NullReferenceException>)+E4]");
				bool flag2 = (nint)0 == 0;
				object obj8 = !flag2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X8_v10 (Il2CppClass<System.NullReferenceException>)+E4]");
				obj6 = 0;
				object obj7 = 0;
				enumType = typeFromHandle;
				intPtr = num;
				if (obj8 != null)
				{
					goto IL_00f6;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			values = Enum.GetValues(enumType);
			bool flag3 = values == null;
			object obj9 = !flag3;
			obj5 = obj6;
			num = intPtr;
			if (obj9 != null)
			{
				goto IL_0120;
			}
		}
		goto IL_0be8;
		IL_0da1:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v919 @ X0_v47+8]");
		UnityEngine.Object obj10 = (UnityEngine.Object)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v919 @ X0_v47] (should have been resolved before IL gen)");
		object obj11 = default(object);
		object value;
		object obj18;
		object obj26;
		List<object>.Enumerator enumerator2;
		object obj17;
		if (obj11 != null)
		{
			object obj12 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1288;
			obj10 = (UnityEngine.Object)obj12;
			object obj13 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ X1_v1 (UnityEngine.Object)+40]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v926 @ X8_v32+40]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ X1_v1 (UnityEngine.Object)+40]");
			if (num2 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1960");
				if (_slotPositions != null)
				{
					object obj14 = (nint)0 + (nint)2056;
					object obj15 = default(object);
					bool flag4 = ((Dictionary<System.Int32Enum, object>)(object)_slotPositions).TryGetValue((System.Int32Enum)obj15, out value);
					if (layers != null)
					{
						List<object>.Enumerator enumerator = ((List<object>)(object)layers).GetEnumerator();
						UnityEngine.Object obj16 = null;
						obj17 = (object)(&value);
						Transform transform = default(Transform);
						float num5 = default(float);
						while (true)
						{
							obj10 = (UnityEngine.Object)obj18;
							if (!enumerator2.MoveNext())
							{
								break;
							}
							if ((object)transform != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v939 @ stack_-B8 (UnityEngine.Transform)+18]");
								object obj19 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v939 @ stack_-B8 (UnityEngine.Transform)+18]");
								if ((nint)0 != 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v770 @ X8_v41+18]");
									if (0 != (nint)obj15)
									{
										continue;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v939 @ stack_-B8 (UnityEngine.Transform)+48]");
									UnityEngine.Object obj20 = (UnityEngine.Object)0;
									object obj21 = typeof(MemberAchievementClanFeedData) + 2976;
									object obj22 = obj21;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v988 @ X0_v68+E4]");
									bool flag5 = (nint)0 == 0;
									object obj23 = !flag5;
									if (obj23 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									if (obj20 != null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v939 @ stack_-B8 (UnityEngine.Transform)+48]");
										if ((nint)0 == 0)
										{
											throw new NullReferenceException();
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v939 @ stack_-B8 (UnityEngine.Transform)+48]");
										Transform transform2 = ((Component)0).transform;
										if ((object)transform2 == null)
										{
											throw new NullReferenceException();
										}
										transform2.SetSiblingIndex((int)obj16);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v939 @ stack_-B8 (UnityEngine.Transform)+48]");
										if ((nint)0 == 0)
										{
											throw new NullReferenceException();
										}
										int num3 = obj16 + 1;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v939 @ stack_-B8 (UnityEngine.Transform)+48]");
										((ClanLogoImageSelector)0).SetIndexLabel(num3);
										bool flag6 = !_layoutsCaptured;
										obj16 = (UnityEngine.Object)num3;
										obj17 = 0;
										if (flag6)
										{
											continue;
										}
										bool flag7 = value == null;
										obj16 = (UnityEngine.Object)num3;
										obj17 = 0;
										if (flag7)
										{
											continue;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ stack_-70_v6 (System.Object)+18]");
										bool flag8 = (nint)num3 >= (nint)0;
										obj16 = (UnityEngine.Object)num3;
										obj17 = 0;
										if (flag8)
										{
											continue;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v939 @ stack_-B8 (UnityEngine.Transform)+48]");
										if ((nint)0 == 0)
										{
											throw new NullReferenceException();
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v939 @ stack_-B8 (UnityEngine.Transform)+48]");
										Transform transform3 = ((Component)0).transform;
										if ((object)transform3 != null)
										{
											object obj24 = typeof(System.Buffers.Text.ParserHelpers) + 3600;
											obj10 = (UnityEngine.Object)obj24;
											if (transform3 != obj24)
											{
												throw new InvalidCastException();
											}
										}
										int num4 = ShortcutExtensions.DOKill(transform3);
										if (value == null)
										{
											throw new NullReferenceException();
										}
										Vector2 vector = ((List<Vector2>)value).get_Item((int)obj16);
										TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTweenModuleUI.DOAnchorPos((RectTransform)transform3, (Vector2)0, num5);
										object obj25 = (nint)0 + (nint)2872;
										obj17 = obj25;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
										obj16 = (UnityEngine.Object)num3;
									}
									else
									{
										obj16 = (UnityEngine.Object)(obj16 + 1);
										obj17 = 0;
									}
									continue;
								}
								throw new NullReferenceException();
							}
							throw new NullReferenceException();
						}
						obj10 = (UnityEngine.Object)obj26;
						enumerator2.Dispose();
						enumerator2 = (List<object>.Enumerator)num5;
						float num6 = num5;
						num5 = 0f;
						throw new OutOfMemoryException();
					}
					throw new NullReferenceException();
				}
				throw new NullReferenceException();
			}
			throw new InvalidCastException();
		}
		throw new NullReferenceException();
		IL_0adf:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		obj17 = 0;
		object obj28 = default(object);
		object obj27 = obj28;
		goto IL_0ec0;
		IL_0d37:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v820 @ X0_v43+8]");
		obj10 = (UnityEngine.Object)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v820 @ X0_v43] (should have been resolved before IL gen)");
		object obj30 = default(object);
		object obj29 = obj30 & 1;
		object obj34;
		object obj35 = default(object);
		if (obj29 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-58]");
			object obj31 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-58]");
			if ((nint)0 != 0)
			{
				object obj32 = obj31;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v836 @ X8_v27+12E]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v836 @ X8_v27+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0342;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v836 @ X8_v27+B0]");
				object obj33 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v893 @ X10_v19-8]");
					if (0 == (nint)obj34)
					{
						break;
					}
					obj35 = obj33 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v836 @ X8_v27+12E]");
					obj5 = -1;
					bool flag9 = (nint)obj5 != 1;
					obj33 = obj35;
					if (flag9)
					{
						continue;
					}
					goto IL_0342;
				}
				obj5 = obj33 + 1;
				object obj36 = obj32 + obj5;
				object obj37 = obj36 + 312;
				obj35 = obj33;
				goto IL_0da1;
			}
			throw new NullReferenceException();
		}
		object obj38 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 88));
		object obj40;
		object obj39 = obj40;
		ClanLogoBuilder clanLogoBuilder = null;
		object obj42 = default(object);
		object obj41 = (object)(&obj42);
		ClanLogoBuilder clanLogoBuilder2 = null;
		goto IL_0eff;
		IL_0221:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		obj17 = 0;
		goto IL_0d37;
		IL_00f6:
		values = Enum.GetValues(typeFromHandle);
		if (values != null)
		{
			goto IL_0120;
		}
		goto IL_0be8;
		IL_0be8:
		NullReferenceException ex = new NullReferenceException();
		enumerator2 = (List<object>.Enumerator)0;
		value = null;
		clanLogoBuilder2 = this;
		goto IL_0c0a;
		IL_0120:
		IEnumerator enumerator3 = values.GetEnumerator();
		obj40 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 88));
		bool flag10 = enumerator3 == null;
		enumerator2 = (List<object>.Enumerator)0;
		value = null;
		obj10 = null;
		if (!flag10)
		{
			obj34 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
			obj18 = (nint)0 + (nint)2056;
			obj26 = (nint)0 + (nint)2048;
			enumerator2 = (List<object>.Enumerator)0;
			value = null;
			IEnumerator enumerator4 = enumerator3;
			nint num7 = (nint)enumerator4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v615 @ X8_v23 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v615 @ X8_v23 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0221;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v615 @ X8_v23 (Il2CppClass<System.Collections.IEnumerator>)+B0]");
			object obj43 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v801 @ X10_v24-8]");
				if (0 == (nint)obj34)
				{
					break;
				}
				obj35 = obj43 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v615 @ X8_v23 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
				obj5 = -1;
				bool flag11 = (nint)obj5 != 1;
				obj43 = obj35;
				if (flag11)
				{
					continue;
				}
				goto IL_0221;
			}
			obj5 = obj43;
			object obj44 = num7 + obj43;
			object obj45 = obj44 + 312;
			obj35 = obj43;
			goto IL_0d37;
		}
		throw new NullReferenceException();
		IL_0e6c:
		bool flag12 = (object)clanLogoBuilder2 == null;
		object obj46 = !flag12;
		if (obj46 == null)
		{
			return;
		}
		OutOfMemoryException ex2 = new OutOfMemoryException();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223E080");
		if ((nint)obj10 == 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			object obj47 = default(object);
			clanLogoBuilder2 = (ClanLogoBuilder)obj47;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			clanLogoBuilder = (ClanLogoBuilder)obj47;
			obj38 = obj39;
			goto IL_0eff;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99B68");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return;
		IL_0eff:
		object obj48 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
		obj10 = (UnityEngine.Object)obj48;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
		obj41 = ex;
		if (ex != null)
		{
			num = (nint)ex;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X8_v10 (Il2CppClass<System.NullReferenceException>)+12E]");
			object obj49 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X8_v10 (Il2CppClass<System.NullReferenceException>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0adf;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X8_v10 (Il2CppClass<System.NullReferenceException>)+B0]");
			object obj50 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X10_v6-8]");
				bool flag13 = 0 == (nint)obj48;
				obj35 = obj50;
				if (flag13)
				{
					break;
				}
				obj35 = obj50 + 16;
				obj49--;
				bool flag14 = (nint)obj49 != 1;
				obj50 = obj35;
				if (flag14)
				{
					continue;
				}
				goto IL_0adf;
			}
			goto IL_0c0a;
		}
		goto IL_0e6c;
		IL_0ec0:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X8_v8+8]");
		obj10 = (UnityEngine.Object)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v251 @ X8_v8] (should have been resolved before IL gen)");
		goto IL_0e6c;
		IL_0342:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		obj17 = 1;
		goto IL_0da1;
		IL_0c0a:
		object obj51 = num + obj35;
		obj27 = obj51 + 312;
		goto IL_0ec0;
	}

	private List<Action> BuildUndoActions(IconLayer layer, LayerSnapshot prev, LayerSnapshot current)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		//IL_0311: Unknown result type (might be due to invalid IL or missing references)
		//IL_0316: Expected O, but got Unknown
		//IL_13f8: Expected O, but got I4
		//IL_1400: Unknown result type (might be due to invalid IL or missing references)
		//IL_1405: Expected O, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected O, but got Unknown
		//IL_1434: Expected O, but got I
		//IL_1470: Invalid comparison between F8 and I4
		//IL_147f: Invalid comparison between F8 and I4
		//IL_1492: Expected O, but got F8
		//IL_149f: Expected O, but got F8
		//IL_14d4: Expected O, but got I4
		//IL_14dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_14e1: Expected O, but got Unknown
		//IL_1518: Expected I, but got O
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Expected O, but got Unknown
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected O, but got Unknown
		//IL_0533: Expected O, but got I
		//IL_054d: Expected O, but got I4
		//IL_017b: Expected O, but got I
		//IL_018c: Expected I, but got O
		//IL_1552: Invalid comparison between F8 and I4
		//IL_1561: Invalid comparison between F8 and I4
		//IL_1574: Expected O, but got F8
		//IL_1581: Expected O, but got F8
		//IL_15b6: Expected O, but got I4
		//IL_15be: Unknown result type (might be due to invalid IL or missing references)
		//IL_15c3: Expected O, but got Unknown
		//IL_0341: Unknown result type (might be due to invalid IL or missing references)
		//IL_0346: Expected O, but got Unknown
		//IL_01b5: Expected O, but got I
		//IL_15f2: Expected O, but got I
		//IL_162e: Invalid comparison between F8 and I4
		//IL_163d: Invalid comparison between F8 and I4
		//IL_1650: Expected O, but got F8
		//IL_165d: Expected O, but got F8
		//IL_1692: Expected O, but got I4
		//IL_169a: Unknown result type (might be due to invalid IL or missing references)
		//IL_169f: Expected O, but got Unknown
		//IL_0384: Unknown result type (might be due to invalid IL or missing references)
		//IL_0389: Expected O, but got Unknown
		//IL_03c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ce: Expected O, but got Unknown
		//IL_022c: Expected O, but got I4
		//IL_03e9: Expected O, but got I
		//IL_03f1: Expected I, but got O
		//IL_0402: Expected I, but got O
		//IL_02bf: Expected O, but got I
		//IL_02cf: Expected O, but got I
		//IL_02df: Expected O, but got I
		//IL_02f5: Expected O, but got I4
		//IL_07cc: Expected O, but got I4
		//IL_07d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07da: Expected O, but got Unknown
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Expected O, but got Unknown
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Expected O, but got Unknown
		//IL_029a: Expected O, but got I4
		//IL_0bbe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc3: Expected O, but got Unknown
		//IL_0c1b: Expected O, but got I
		//IL_05d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05de: Expected O, but got Unknown
		//IL_042b: Expected O, but got I
		//IL_081e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0823: Expected O, but got Unknown
		//IL_0c78: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c7d: Expected O, but got Unknown
		//IL_04a2: Expected O, but got I4
		//IL_0eef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ef4: Expected O, but got Unknown
		//IL_061c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0621: Expected O, but got Unknown
		//IL_0661: Unknown result type (might be due to invalid IL or missing references)
		//IL_0666: Expected O, but got Unknown
		//IL_09fd: Expected O, but got I
		//IL_0a0d: Expected O, but got I
		//IL_0a40: Expected O, but got I
		//IL_0a58: Expected O, but got I4
		//IL_10f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_10f8: Expected O, but got Unknown
		//IL_0861: Unknown result type (might be due to invalid IL or missing references)
		//IL_0866: Expected O, but got Unknown
		//IL_0899: Unknown result type (might be due to invalid IL or missing references)
		//IL_089e: Expected O, but got Unknown
		//IL_0681: Expected O, but got I
		//IL_0689: Expected I, but got O
		//IL_069a: Expected I, but got O
		//IL_04e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e7: Expected O, but got Unknown
		//IL_04f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f5: Expected O, but got Unknown
		//IL_0510: Expected O, but got I4
		//IL_0cbb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc0: Expected O, but got Unknown
		//IL_0cee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf3: Expected O, but got Unknown
		//IL_08b9: Expected O, but got I
		//IL_08c1: Expected I, but got O
		//IL_08d2: Expected I, but got O
		//IL_0a84: Expected O, but got I4
		//IL_0f32: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f37: Expected O, but got Unknown
		//IL_0f6a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f6f: Expected O, but got Unknown
		//IL_0d0e: Expected O, but got I
		//IL_0d16: Expected I, but got O
		//IL_0d27: Expected I, but got O
		//IL_06c3: Expected O, but got I
		//IL_1136: Unknown result type (might be due to invalid IL or missing references)
		//IL_113b: Expected O, but got Unknown
		//IL_116e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1173: Expected O, but got Unknown
		//IL_0f8a: Expected O, but got I
		//IL_0f92: Expected I, but got O
		//IL_0fa3: Expected I, but got O
		//IL_08fb: Expected O, but got I
		//IL_118e: Expected O, but got I
		//IL_119f: Expected I, but got O
		//IL_0d50: Expected O, but got I
		//IL_073a: Expected O, but got I4
		//IL_0fcc: Expected O, but got I
		//IL_0972: Expected O, but got I4
		//IL_0ab1: Expected O, but got I
		//IL_0ac1: Expected O, but got I
		//IL_0af5: Expected O, but got I4
		//IL_0afe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b03: Expected O, but got Unknown
		//IL_0b1d: Expected O, but got I4
		//IL_0b26: Expected O, but got I4
		//IL_0dc7: Expected O, but got I4
		//IL_0b72: Expected O, but got I
		//IL_0b82: Expected O, but got I
		//IL_0ba8: Expected O, but got I4
		//IL_077a: Unknown result type (might be due to invalid IL or missing references)
		//IL_077f: Expected O, but got Unknown
		//IL_0788: Unknown result type (might be due to invalid IL or missing references)
		//IL_078d: Expected O, but got Unknown
		//IL_07a8: Expected O, but got I4
		//IL_1043: Expected O, but got I4
		//IL_0e52: Expected O, but got I
		//IL_0e62: Expected O, but got I
		//IL_0e88: Expected O, but got I4
		//IL_09b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b7: Expected O, but got Unknown
		//IL_09c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c5: Expected O, but got Unknown
		//IL_09e0: Expected O, but got I4
		//IL_0b45: Expected O, but got I4
		//IL_122d: Expected O, but got I4
		//IL_12a7: Expected O, but got I
		//IL_12b7: Expected O, but got I
		//IL_12f8: Expected O, but got I4
		//IL_0e07: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e0c: Expected O, but got Unknown
		//IL_0e15: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e1a: Expected O, but got Unknown
		//IL_0e35: Expected O, but got I4
		//IL_1083: Unknown result type (might be due to invalid IL or missing references)
		//IL_1088: Expected O, but got Unknown
		//IL_1091: Unknown result type (might be due to invalid IL or missing references)
		//IL_1096: Expected O, but got Unknown
		//IL_10b1: Expected O, but got I4
		//IL_126d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1272: Expected O, but got Unknown
		//IL_127b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1280: Expected O, but got Unknown
		object obj = typeof(CardUtils.<>c) + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		<>c__DisplayClass92_0 <>c__DisplayClass92_ = default(<>c__DisplayClass92_0);
		<>c__DisplayClass92_..ctor();
		object obj6;
		List<object> list = default(List<object>);
		LayerSnapshot layerSnapshot;
		LayerSnapshot layerSnapshot2;
		if (<>c__DisplayClass92_ != null)
		{
			object obj2 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 4072;
			object obj3 = (nint)0 + (nint)304;
			object obj4 = <>c__DisplayClass92_ + 16;
			obj4 = layer;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj5 = <>c__DisplayClass92_ + 24;
			obj5 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			obj6 = obj3;
			list..ctor();
			bool flag = prev.ImageId == current.ImageId;
			layerSnapshot = current;
			layerSnapshot2 = prev;
			if (flag)
			{
				goto IL_0302;
			}
			object obj7 = typeof(CardUtils.<>c) + 1032;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			<>c__DisplayClass92_1 <>c__DisplayClass92_2 = default(<>c__DisplayClass92_1);
			<>c__DisplayClass92_2..ctor();
			if (<>c__DisplayClass92_2 != null)
			{
				object obj8 = <>c__DisplayClass92_2 + 24;
				obj8 = <>c__DisplayClass92_;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				<>c__DisplayClass92_2.restoreId = prev.ImageId;
				object obj9 = typeof(SqlSingle[]) + 2376;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj10 = (nint)0 + (nint)104;
				Action action = default(Action);
				action..ctor(<>c__DisplayClass92_2, (IntPtr)obj10);
				if (list != null)
				{
					object obj11 = (nint)0 + (nint)320;
					object obj12 = obj11;
					int version = list._version + 1;
					list._version = version;
					object[] items = list._items;
					if (list._items != null)
					{
						bool flag2 = list._size < items.Length;
						object obj13 = !flag2;
						if (obj13 == null)
						{
							int size = list._size + 1;
							list._size = size;
							object obj14 = list._items + list._size;
							object obj15 = obj14 + 32;
							obj15 = action;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							layerSnapshot = (LayerSnapshot)0;
							layerSnapshot2 = (LayerSnapshot)obj10;
							obj6 = action;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X8_v125+20]");
							object obj16 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v671 @ X8_v126+C0]");
							object obj17 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v476 @ X8_v127+70]");
							layerSnapshot2 = (LayerSnapshot)0;
							list.AddWithResize((object)action);
							layerSnapshot = (LayerSnapshot)0;
							obj6 = action;
						}
						goto IL_0302;
					}
				}
			}
		}
		goto IL_132c;
		IL_07b5:
		object obj18 = current.Inverted ^ prev.Inverted;
		object obj19 = obj18 & 1;
		bool flag3 = obj19 == null;
		LayerSnapshot layerSnapshot4;
		LayerSnapshot layerSnapshot3 = layerSnapshot4;
		nint num2;
		nint num = num2;
		object obj21;
		object obj20 = obj21;
		if (!flag3)
		{
			goto IL_080f;
		}
		goto IL_0bb5;
		IL_10e4:
		object obj22 = typeof(CardUtils.<>c) + 1080;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		<>c__DisplayClass92_7 <>c__DisplayClass92_3 = default(<>c__DisplayClass92_7);
		<>c__DisplayClass92_3..ctor();
		if (<>c__DisplayClass92_3 != null)
		{
			object obj23 = <>c__DisplayClass92_3 + 24;
			obj23 = <>c__DisplayClass92_;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			<>c__DisplayClass92_3.restoreOrder = prev.OrderInGroup;
			object obj24 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj25 = (nint)0 + (nint)152;
			Action action2 = default(Action);
			action2..ctor(<>c__DisplayClass92_3, (IntPtr)obj25);
			if (list != null)
			{
				int version2 = list._version + 1;
				list._version = version2;
				object[] items2 = list._items;
				if (list._items != null)
				{
					bool flag4 = list._size < items2.Length;
					object obj26 = !flag4;
					if (obj26 == null)
					{
						int size2 = list._size + 1;
						list._size = size2;
						object obj27 = list._items + list._size;
						object obj28 = obj27 + 32;
						obj28 = action2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					}
					else
					{
						list.AddWithResize((object)action2);
					}
					goto IL_1327;
				}
			}
		}
		goto IL_132c;
		IL_080f:
		object obj29 = typeof(CardUtils.<>c) + 1056;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		<>c__DisplayClass92_4 <>c__DisplayClass92_4 = default(<>c__DisplayClass92_4);
		<>c__DisplayClass92_4..ctor();
		if (<>c__DisplayClass92_4 != null)
		{
			object obj30 = <>c__DisplayClass92_4 + 24;
			obj30 = <>c__DisplayClass92_;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			<>c__DisplayClass92_4.restoreInverted = prev.Inverted;
			object obj31 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj32 = (nint)0 + (nint)128;
			num = (nint)obj32;
			Action action3 = default(Action);
			action3..ctor(<>c__DisplayClass92_4, (IntPtr)obj32);
			if (list != null)
			{
				object obj33 = (nint)0 + (nint)320;
				object obj34 = obj33;
				int version3 = list._version + 1;
				list._version = version3;
				object[] items3 = list._items;
				if (list._items != null)
				{
					bool flag5 = list._size < items3.Length;
					object obj35 = !flag5;
					if (obj35 == null)
					{
						int size3 = list._size + 1;
						list._size = size3;
						object obj36 = list._items + list._size;
						object obj37 = obj36 + 32;
						obj37 = action3;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						layerSnapshot3 = (LayerSnapshot)0;
						obj20 = action3;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X8_v77+20]");
						object obj38 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1004 @ X8_v78+C0]");
						object obj39 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v789 @ X8_v79+70]");
						num = 0;
						list.AddWithResize((object)action3);
						layerSnapshot3 = (LayerSnapshot)0;
						obj20 = action3;
					}
					goto IL_0bb5;
				}
			}
		}
		goto IL_132c;
		IL_0e95:
		object obj40 = prev.Position - current.Position;
		object obj41 = obj40 * obj40;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
		if ((nint)obj41 < 786163454)
		{
			goto IL_10be;
		}
		object obj42 = typeof(CardUtils.<>c) + 1072;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		<>c__DisplayClass92_6 <>c__DisplayClass92_5 = default(<>c__DisplayClass92_6);
		<>c__DisplayClass92_5..ctor();
		if (<>c__DisplayClass92_5 != null)
		{
			object obj43 = <>c__DisplayClass92_5 + 24;
			obj43 = <>c__DisplayClass92_;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			<>c__DisplayClass92_5.restorePosition = prev.Position;
			object obj44 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj45 = (nint)0 + (nint)144;
			num = (nint)obj45;
			Action action4 = default(Action);
			action4..ctor(<>c__DisplayClass92_5, (IntPtr)obj45);
			if (list != null)
			{
				object obj46 = (nint)0 + (nint)320;
				object obj47 = obj46;
				int version4 = list._version + 1;
				list._version = version4;
				object[] items4 = list._items;
				if (list._items != null)
				{
					bool flag6 = list._size < items4.Length;
					object obj48 = !flag6;
					if (obj48 == null)
					{
						int size4 = list._size + 1;
						list._size = size4;
						object obj49 = list._items + list._size;
						object obj50 = obj49 + 32;
						obj50 = action4;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						layerSnapshot3 = (LayerSnapshot)0;
						obj20 = action4;
						goto IL_10be;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ X8_v49+20]");
					object obj51 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1020 @ X8_v50+C0]");
					object obj52 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1021 @ X8_v51+70]");
					num = 0;
					list.AddWithResize((object)action4);
					bool flag7 = prev.OrderInGroup != current.OrderInGroup;
					layerSnapshot3 = (LayerSnapshot)0;
					obj20 = action4;
					if (flag7)
					{
						goto IL_10e4;
					}
					goto IL_1327;
				}
			}
		}
		goto IL_132c;
		IL_1327:
		return (List<Action>)(object)list;
		IL_051d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BCF0BA]");
		object obj53 = (nint)0 & (nint)1;
		bool flag8 = obj53 == null;
		object obj54 = !flag8;
		double num4;
		double num3 = num4;
		layerSnapshot4 = layerSnapshot;
		nint num5;
		num2 = num5;
		obj21 = obj6;
		if (obj54 == null)
		{
			goto IL_057b;
		}
		goto IL_1526;
		IL_10be:
		if (prev.OrderInGroup != current.OrderInGroup)
		{
			goto IL_10e4;
		}
		goto IL_1327;
		IL_0302:
		object obj55 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4024;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
		object obj57 = default(object);
		object obj58 = default(object);
		object obj56 = obj57 - obj58;
		bool flag9 = (nint)obj56 < 0;
		bool flag10 = obj56 == null;
		object obj59 = obj57 ^ obj58;
		object obj60 = obj57 ^ obj56;
		object obj61 = obj59 & obj60;
		bool flag11 = (nint)obj61 < 0;
		bool flag12 = flag9 == flag11;
		object obj62 = !flag10;
		object obj63 = flag12 & obj62;
		object obj64 = ~obj63;
		if (obj64 == null)
		{
		}
		object obj65 = obj55;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v518 @ X8_v8+B8]");
		object obj66 = 0;
		num4 = (double)obj58 * 897988541.0;
		double num6 = (double)obj66 * 8.0;
		double num7 = num4 - num6;
		bool flag13 = num7 < 0.0;
		bool flag14 = num7 == 0.0;
		object obj67 = num4 ^ num6;
		object obj68 = num4 ^ num7;
		object obj69 = obj67 & obj68;
		bool flag15 = (nint)obj69 < 0;
		bool flag16 = flag13 == flag15;
		object obj70 = !flag14;
		object obj71 = flag16 & obj70;
		object obj72 = ~obj71;
		if (obj72 != null)
		{
			num4 = num6;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
		bool flag17 = num6 < num4;
		num5 = (nint)layerSnapshot2;
		if (flag17)
		{
			goto IL_051d;
		}
		object obj73 = typeof(CardUtils.<>c) + 1040;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		<>c__DisplayClass92_2 <>c__DisplayClass92_6 = default(<>c__DisplayClass92_2);
		<>c__DisplayClass92_6..ctor();
		if (<>c__DisplayClass92_6 != null)
		{
			object obj74 = <>c__DisplayClass92_6 + 24;
			obj74 = <>c__DisplayClass92_;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			num4 = prev.Rotation;
			<>c__DisplayClass92_6.restoreRotation = prev.Rotation;
			object obj75 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj76 = (nint)0 + (nint)112;
			num5 = (nint)obj76;
			Action action5 = default(Action);
			action5..ctor(<>c__DisplayClass92_6, (IntPtr)obj76);
			if (list != null)
			{
				object obj77 = (nint)0 + (nint)320;
				object obj78 = obj77;
				int version5 = list._version + 1;
				list._version = version5;
				object[] items5 = list._items;
				if (list._items != null)
				{
					bool flag18 = list._size < items5.Length;
					object obj79 = !flag18;
					if (obj79 == null)
					{
						int size5 = list._size + 1;
						list._size = size5;
						object obj80 = list._items + list._size;
						object obj81 = obj80 + 32;
						obj81 = action5;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						layerSnapshot = (LayerSnapshot)0;
						obj6 = action5;
						goto IL_051d;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ X8_v110+20]");
					object obj82 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v847 @ X8_v111+C0]");
					object obj83 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v848 @ X8_v112+70]");
					num5 = 0;
					list.AddWithResize((object)action5);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BCF0BA]");
					object obj84 = (nint)0 & (nint)1;
					bool flag19 = obj84 == null;
					layerSnapshot = (LayerSnapshot)0;
					obj6 = action5;
					if (flag19)
					{
						goto IL_057b;
					}
					num3 = prev.Rotation;
					layerSnapshot4 = (LayerSnapshot)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v848 @ X8_v112+70]");
					num2 = 0;
					obj21 = action5;
					goto IL_1526;
				}
			}
		}
		goto IL_132c;
		IL_057b:
		_ = 1;
		num3 = num4;
		layerSnapshot4 = layerSnapshot;
		num2 = num5;
		obj21 = obj6;
		goto IL_1526;
		IL_0bb5:
		object obj85 = prev + 16;
		object obj86 = obj85 - (object)current.Color;
		object obj87 = obj86 * obj86;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		object obj88 = obj87 + (object)current.Color;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ X23_v7+8]");
		nint num8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [current @ X3 (ClanLogoBuilder+LayerSnapshot)+18]");
		object obj89 = num8 - 0;
		object obj90 = obj89 * obj89;
		object obj91 = obj90 + obj88;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		object obj92 = obj90 + obj91;
		if ((nint)obj92 < 786163454)
		{
			goto IL_0e95;
		}
		object obj93 = typeof(CardUtils.<>c) + 1064;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		<>c__DisplayClass92_5 <>c__DisplayClass92_7 = default(<>c__DisplayClass92_5);
		<>c__DisplayClass92_7..ctor();
		if (<>c__DisplayClass92_7 != null)
		{
			object obj94 = <>c__DisplayClass92_7 + 32;
			obj94 = <>c__DisplayClass92_;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			<>c__DisplayClass92_7.restoreColor = (Color)obj85;
			object obj95 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj96 = (nint)0 + (nint)136;
			num = (nint)obj96;
			Action action6 = default(Action);
			action6..ctor(<>c__DisplayClass92_7, (IntPtr)obj96);
			if (list != null)
			{
				object obj97 = (nint)0 + (nint)320;
				object obj98 = obj97;
				int version6 = list._version + 1;
				list._version = version6;
				object[] items6 = list._items;
				if (list._items != null)
				{
					bool flag20 = list._size < items6.Length;
					object obj99 = !flag20;
					if (obj99 == null)
					{
						int size6 = list._size + 1;
						list._size = size6;
						object obj100 = list._items + list._size;
						object obj101 = obj100 + 32;
						obj101 = action6;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						layerSnapshot3 = (LayerSnapshot)0;
						obj20 = action6;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X8_v62+20]");
						object obj102 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1012 @ X8_v63+C0]");
						object obj103 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v837 @ X8_v64+70]");
						num = 0;
						list.AddWithResize((object)action6);
						layerSnapshot3 = (LayerSnapshot)0;
						obj20 = action6;
					}
					goto IL_0e95;
				}
			}
		}
		goto IL_132c;
		IL_1526:
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
		double num9 = num3 - num6;
		bool flag21 = num9 < 0.0;
		bool flag22 = num9 == 0.0;
		object obj104 = num3 ^ num6;
		object obj105 = num3 ^ num9;
		object obj106 = obj104 & obj105;
		bool flag23 = (nint)obj106 < 0;
		bool flag24 = flag21 == flag23;
		object obj107 = !flag22;
		object obj108 = flag24 & obj107;
		object obj109 = ~obj108;
		if (obj109 != null)
		{
			num3 = num6;
		}
		object obj110 = obj55;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v677 @ X8_v13+B8]");
		object obj111 = 0;
		double num10 = num3 * 897988541.0;
		double num11 = (double)obj111 * 8.0;
		double num12 = num10 - num11;
		bool flag25 = num12 < 0.0;
		bool flag26 = num12 == 0.0;
		object obj112 = num10 ^ num11;
		object obj113 = num10 ^ num12;
		object obj114 = obj112 & obj113;
		bool flag27 = (nint)obj114 < 0;
		bool flag28 = flag25 == flag27;
		object obj115 = !flag26;
		object obj116 = flag28 & obj115;
		object obj117 = ~obj116;
		if (obj117 != null)
		{
			num10 = num11;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
		if (num11 < num10)
		{
			goto IL_07b5;
		}
		object obj118 = typeof(CardUtils.<>c) + 1048;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		<>c__DisplayClass92_3 <>c__DisplayClass92_8 = default(<>c__DisplayClass92_3);
		<>c__DisplayClass92_8..ctor();
		if (<>c__DisplayClass92_8 != null)
		{
			object obj119 = <>c__DisplayClass92_8 + 24;
			obj119 = <>c__DisplayClass92_;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			num10 = prev.Scale;
			<>c__DisplayClass92_8.restoreScale = prev.Scale;
			object obj120 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj121 = (nint)0 + (nint)120;
			num2 = (nint)obj121;
			Action action7 = default(Action);
			action7..ctor(<>c__DisplayClass92_8, (IntPtr)obj121);
			if (list != null)
			{
				object obj122 = (nint)0 + (nint)320;
				object obj123 = obj122;
				int version7 = list._version + 1;
				list._version = version7;
				object[] items7 = list._items;
				if (list._items != null)
				{
					bool flag29 = list._size < items7.Length;
					object obj124 = !flag29;
					if (obj124 == null)
					{
						int size7 = list._size + 1;
						list._size = size7;
						object obj125 = list._items + list._size;
						object obj126 = obj125 + 32;
						obj126 = action7;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						layerSnapshot4 = (LayerSnapshot)0;
						obj21 = action7;
						goto IL_07b5;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X8_v92+20]");
					object obj127 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v991 @ X8_v93+C0]");
					object obj128 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v992 @ X8_v94+70]");
					num2 = 0;
					list.AddWithResize((object)action7);
					object obj129 = current.Inverted ^ prev.Inverted;
					object obj130 = obj129 & 1;
					bool flag30 = obj130 == null;
					object obj131 = !flag30;
					layerSnapshot4 = (LayerSnapshot)0;
					obj21 = action7;
					if (obj131 != null)
					{
						goto IL_080f;
					}
					layerSnapshot3 = (LayerSnapshot)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v992 @ X8_v94+70]");
					num = 0;
					obj20 = action7;
					goto IL_0bb5;
				}
			}
		}
		goto IL_132c;
		IL_132c:
		return (List<Action>)(object)new NullReferenceException();
	}

	private float PositionExtent()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0101: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_01a6: Invalid comparison between F4 and I4
		//IL_01b5: Invalid comparison between F4 and I4
		//IL_01c8: Expected O, but got F4
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Expected O, but got Unknown
		//IL_01fd: Expected O, but got I4
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Expected O, but got Unknown
		//IL_00cc: Expected F4, but got I4
		//IL_0154: Expected F4, but got I4
		object obj = 152993792;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E88E6]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v5+E4]");
			bool flag = (nint)0 == 0;
			obj5 = previewer;
			obj6 = previewer;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v5+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = previewer;
			obj6 = previewer;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6 != null;
		bool flag4 = !flag3;
		float num = 0f;
		if (!flag4)
		{
			goto IL_0162;
		}
		goto IL_019d;
		IL_019d:
		bool flag5 = num < 0f;
		bool flag6 = num == 0f;
		object obj8 = num ^ num;
		object obj9 = num & obj8;
		bool flag7 = (nint)obj9 < 0;
		bool flag8 = flag5 == flag7;
		object obj10 = !flag6;
		object obj11 = flag8 & obj10;
		object obj12 = ~obj11;
		if (obj12 != null)
		{
			num = 1f;
		}
		return num;
		IL_0162:
		float rimHalfExtent = previewer.GetRimHalfExtent();
		num = rimHalfExtent * 1.0586423E+09f;
		goto IL_019d;
		IL_0091:
		bool flag9 = obj5 != null;
		bool flag10 = !flag9;
		object obj13 = !flag10;
		if (obj13 != null)
		{
			goto IL_0162;
		}
		num = 0f;
		goto IL_019d;
	}

	private float GetEffectiveMaxMoveDistance(IconLayer layer)
	{
		//IL_0009: Expected O, but got I4
		//IL_010f: Expected O, but got I
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Expected O, but got Unknown
		//IL_020e: Expected O, but got I4
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_01a5: Expected O, but got I4
		//IL_01ae: Expected F4, but got I4
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected O, but got Unknown
		//IL_0307: Expected O, but got I4
		//IL_0072: Expected F4, but got I4
		//IL_01c5: Expected F4, but got I4
		//IL_0261: Expected F4, but got I4
		//IL_026a: Expected F4, but got I4
		//IL_031e: Invalid comparison between F4 and I4
		//IL_032d: Invalid comparison between F4 and I4
		//IL_0340: Expected O, but got F4
		//IL_0348: Unknown result type (might be due to invalid IL or missing references)
		//IL_034d: Expected O, but got Unknown
		//IL_0375: Expected O, but got I4
		//IL_037d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0382: Expected O, but got Unknown
		//IL_03ef: Invalid comparison between F4 and I4
		//IL_03fe: Invalid comparison between F4 and I4
		//IL_0411: Expected O, but got F4
		//IL_0419: Unknown result type (might be due to invalid IL or missing references)
		//IL_041e: Expected O, but got Unknown
		//IL_0446: Expected O, but got I4
		//IL_044e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0453: Expected O, but got Unknown
		//IL_009a: Expected F4, but got I4
		//IL_03bb: Invalid comparison between F8 and I4
		//IL_00f4: Expected F8, but got I4
		object obj = 152993792;
		float num2;
		if (layer != null)
		{
			object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v19+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag2 = previewer != null;
			bool flag3 = !flag2;
			float num = 0f;
			if (!flag3)
			{
				bool flag4 = (object)previewer == null;
				num2 = 0f;
				if (flag4)
				{
					goto IL_02d2;
				}
				float rimHalfExtent = previewer.GetRimHalfExtent();
				num = rimHalfExtent * 1.0586423E+09f;
			}
			bool flag5 = num < 0f;
			bool flag6 = num == 0f;
			object obj5 = num ^ num;
			object obj6 = num & obj5;
			bool flag7 = (nint)obj6 < 0;
			bool flag8 = flag5 == flag7;
			object obj7 = !flag6;
			object obj8 = flag8 & obj7;
			object obj9 = ~obj8;
			double num3 = ((obj9 != null) ? 1.0 : ((double)num));
			double num4 = 1.0 - (double)layer.Scale;
			if (num4 < 0.0)
			{
				num4 = 0.0;
			}
			return (float)num3 * (float)num4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E88E6]");
		object obj10 = (nint)0 & (nint)1;
		UnityEngine.Object obj13;
		UnityEngine.Object obj14;
		if (obj10 != null)
		{
			object obj11 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj12 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X0_v6+E4]");
			bool flag9 = (nint)0 == 0;
			obj13 = previewer;
			obj14 = previewer;
			if (!flag9)
			{
				goto IL_0181;
			}
		}
		else
		{
			_ = 1;
			object obj15 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj12 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X0_v6+E4]");
			bool flag10 = (nint)0 == 0;
			object obj16 = !flag10;
			obj13 = previewer;
			obj14 = previewer;
			if (obj16 != null)
			{
				goto IL_0181;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag11 = obj14 != null;
		bool flag12 = !flag11;
		num2 = 0f;
		float num5 = 0f;
		if (!flag12)
		{
			goto IL_0278;
		}
		goto IL_03e6;
		IL_0278:
		if ((object)previewer == null)
		{
			goto IL_02d2;
		}
		float rimHalfExtent2 = previewer.GetRimHalfExtent();
		num5 = rimHalfExtent2 * 1.0586423E+09f;
		goto IL_03e6;
		IL_0181:
		bool flag13 = obj13 != null;
		bool flag14 = !flag13;
		object obj17 = !flag14;
		num2 = 0f;
		if (obj17 != null)
		{
			goto IL_0278;
		}
		num5 = 0f;
		goto IL_03e6;
		IL_03e6:
		bool flag15 = num5 < 0f;
		bool flag16 = num5 == 0f;
		object obj18 = num5 ^ num5;
		object obj19 = num5 & obj18;
		bool flag17 = (nint)obj19 < 0;
		bool flag18 = flag15 == flag17;
		object obj20 = !flag16;
		object obj21 = flag18 & obj20;
		object obj22 = ~obj21;
		if (obj22 != null)
		{
			num5 = 1f;
		}
		return num5;
		IL_02d2:
		throw new NullReferenceException();
	}

	private unsafe void ClampLayerWithinCircle(IconLayer layer)
	{
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected O, but got Unknown
		//IL_008c: Expected O, but got I
		//IL_019c: Expected O, but got I4
		//IL_0119: Invalid comparison between O and F4
		//IL_01ea: Invalid comparison between O and F4
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Expected Ref, but got Unknown
		//IL_0159: Expected O, but got I4
		if (layer == null)
		{
			return;
		}
		LogoLayerConfig layerConfig = layer.layerConfig;
		if (!layerConfig.Movable)
		{
			return;
		}
		float effectiveMaxMoveDistance = GetEffectiveMaxMoveDistance(layer);
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BCF0CD]");
		object obj2 = (nint)0 & (nint)1;
		Vector2 position;
		Vector2 position2;
		if (obj2 != null)
		{
			position = layer.Position;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			position2 = layer.Position;
			if (!flag)
			{
				goto IL_00f0;
			}
		}
		else
		{
			_ = 1;
			position = layer.Position;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X0_v3+E4]");
			bool flag2 = (nint)0 == 0;
			object obj4 = !flag2;
			position2 = layer.Position;
			if (obj4 != null)
			{
				goto IL_00f0;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj5 = position2 * position2;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		if (obj5 <= (object)effectiveMaxMoveDistance)
		{
			return;
		}
		goto IL_0130;
		IL_0130:
		Vector2 vector = Vector2.Normalize(ref *(Vector2*)(layer + 64));
		layer.SetPosition((Vector2)0);
		return;
		IL_00f0:
		object obj6 = position * position;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		if (obj6 > (object)effectiveMaxMoveDistance)
		{
			goto IL_0130;
		}
	}

	private void InvertLayer(IconLayer layer, bool addUndo)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_00c5: Expected O, but got I4
		//IL_00ce: Expected O, but got I4
		//IL_0071: Expected O, but got I4
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Expected O, but got Unknown
		//IL_0271: Expected O, but got I4
		//IL_0298: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Expected O, but got Unknown
		//IL_01ad: Expected O, but got I4
		if (layer == null)
		{
			return;
		}
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+E4]");
		if ((nint)0 != 0)
		{
			bool flag = layer.layerConfig == null;
			bool flag2 = !flag;
			object obj3 = 0;
			UnityEngine.Object obj4 = null;
			if (!flag2)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = layer.layerConfig == null;
			bool flag4 = !flag3;
			object obj5 = !flag4;
			object obj3 = 0;
			UnityEngine.Object obj4 = null;
			if (obj5 != null)
			{
				return;
			}
		}
		LogoLayerConfig layerConfig = layer.layerConfig;
		if (layerConfig.Sizable)
		{
			bool inverted = !layer.Inverted;
			layer.SetInverted(inverted);
			float rotation = 1f - layer.Rotation;
			layer.SetRotation(rotation);
			if (_selectedLayer == layer)
			{
				object obj6 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X0_v15+E4]");
				bool flag5 = (nint)0 == 0;
				object obj7 = !flag5;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				if (RotationSlider != null)
				{
					RotationSlider.value = layer.Rotation;
				}
			}
			if (addUndo)
			{
				AddUndo(layer);
			}
		}
		else
		{
			object obj8 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X0_v7+E4]");
			bool flag6 = (nint)0 == 0;
			object obj10 = !flag6;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj11 = "WhiteSmoke" + 3352;
			KLogger.LogWarning(obj11);
		}
	}

	private void SetupMoveButton(Button button, Vector2 direction)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_00ed: Expected O, but got I4
		//IL_00f6: Expected O, but got I4
		//IL_00a7: Expected O, but got I4
		//IL_0122: Expected O, but got I
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected O, but got Unknown
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Expected O, but got Unknown
		//IL_0195: Expected O, but got I
		//IL_01a6: Expected I, but got O
		//IL_01b7: Expected O, but got I
		//IL_01f4: Expected O, but got I
		//IL_024e: Expected O, but got I4
		//IL_02cb: Expected O, but got I
		//IL_02db: Expected O, but got I
		//IL_02eb: Expected O, but got I
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Expected O, but got Unknown
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_029c: Expected O, but got Unknown
		//IL_0341: Expected O, but got I
		//IL_0352: Expected I, but got O
		//IL_03ce: Expected O, but got I4
		//IL_0409: Unknown result type (might be due to invalid IL or missing references)
		//IL_040e: Expected O, but got Unknown
		//IL_0417: Unknown result type (might be due to invalid IL or missing references)
		//IL_041c: Expected O, but got Unknown
		object obj = typeof(CardUtils.<>c) + 1088;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		<>c__DisplayClass97_0 <>c__DisplayClass97_ = default(<>c__DisplayClass97_0);
		<>c__DisplayClass97_..ctor();
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj3 = <>c__DisplayClass97_ + 16;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X0_v8+E4]");
		if ((nint)0 != 0)
		{
			bool flag = button == null;
			bool flag2 = !flag;
			object obj5 = 0;
			if (!flag2)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = button == null;
			bool flag4 = !flag3;
			object obj6 = !flag4;
			object obj5 = 0;
			if (obj6 != null)
			{
				return;
			}
		}
		GameObject gameObject = button.gameObject;
		object obj7 = (nint)0 + (nint)688;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E32E24");
		object obj8 = typeof(DebugUI.BitField) + 1760;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		EventTrigger.Entry entry = default(EventTrigger.Entry);
		entry..ctor();
		entry.eventID = EventTriggerType.PointerDown;
		object obj9 = typeof(TypeConverter<ushort, char>) + 352;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj10 = (nint)0 + (nint)160;
		UnityAction<object> unityAction = default(UnityAction<object>);
		unityAction..ctor((object)<>c__DisplayClass97_, (IntPtr)obj10);
		object obj11 = (nint)0 + (nint)808;
		object obj12 = obj11;
		((UnityEvent<object>)(object)entry.callback).AddListener(unityAction);
		EventTrigger eventTrigger = default(EventTrigger);
		List<EventTrigger.Entry> triggers = eventTrigger.triggers;
		object obj13 = (nint)0 + (nint)2152;
		object obj14 = obj13;
		int version = triggers._version + 1;
		triggers._version = version;
		EventTrigger.Entry[] items = triggers._items;
		bool flag5 = triggers._size < items.Length;
		object obj15 = !flag5;
		if (obj15 == null)
		{
			int size = triggers._size + 1;
			triggers._size = size;
			object obj16 = items + triggers._size;
			object obj17 = obj16 + 32;
			obj17 = entry;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj18 = entry;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X8_v10+20]");
			object obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X8_v19+C0]");
			object obj20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ X8_v20+70]");
			obj12 = 0;
			((List<object>)(object)triggers).AddWithResize((object)entry);
			object obj18 = entry;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		EventTrigger.Entry entry2 = default(EventTrigger.Entry);
		entry2..ctor();
		entry2.eventID = EventTriggerType.PointerUp;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj21 = (nint)0 + (nint)168;
		UnityAction<object> unityAction2 = default(UnityAction<object>);
		unityAction2..ctor((object)<>c__DisplayClass97_, (IntPtr)obj21);
		((UnityEvent<object>)(object)entry2.callback).AddListener(unityAction2);
		List<EventTrigger.Entry> triggers2 = eventTrigger.triggers;
		int version2 = triggers2._version + 1;
		triggers2._version = version2;
		EventTrigger.Entry[] items2 = triggers2._items;
		bool flag6 = triggers2._size < items2.Length;
		object obj22 = !flag6;
		if (obj22 == null)
		{
			int size2 = triggers2._size + 1;
			triggers2._size = size2;
			object obj23 = items2 + triggers2._size;
			object obj24 = obj23 + 32;
			obj24 = entry2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		else
		{
			((List<object>)(object)triggers2).AddWithResize((object)entry2);
		}
	}

	private void StartMoving(Vector2 direction)
	{
		IconLayer selectedLayer = _selectedLayer;
		if (_selectedLayer != null)
		{
			LogoLayerConfig layerConfig = selectedLayer.layerConfig;
			if (layerConfig.Movable)
			{
				Vector2 currentMoveDirection = default(Vector2);
				_currentMoveDirection = currentMoveDirection;
				_moveStartPosition = selectedLayer.Position;
				_moveTimer = 0f;
			}
		}
	}

	private void StopMoving()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00c8: Expected O, but got I
		object obj = typeof(UsageHint) + 744;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v3+B8]");
		object obj3 = 0;
		object obj4 = (object)_currentMoveDirection - obj3;
		object obj5 = obj4 * obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
		if ((nint)obj5 < 786163454)
		{
			return;
		}
		IconLayer selectedLayer = _selectedLayer;
		_currentMoveDirection = (Vector2)obj3;
		if (_selectedLayer != null)
		{
			object obj6 = selectedLayer.Position - _moveStartPosition;
			object obj7 = obj6 * obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
			if ((nint)obj7 >= 786163454)
			{
				AddUndo(_selectedLayer);
				UpdateMovementButtons();
			}
		}
	}

	private void MoveLayer(Vector2 direction)
	{
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected O, but got Unknown
		//IL_00bc: Expected O, but got I
		//IL_01f3: Expected O, but got I4
		//IL_027e: Expected O, but got I4
		IconLayer selectedLayer = _selectedLayer;
		if (_selectedLayer == null)
		{
			return;
		}
		LogoLayerConfig layerConfig = selectedLayer.layerConfig;
		if (!layerConfig.Movable)
		{
			return;
		}
		object obj = default(object);
		float num = (float)obj * MoveStep;
		object obj2 = default(object);
		float num2 = (float)obj2 * MoveStep;
		float effectiveMaxMoveDistance = GetEffectiveMaxMoveDistance(_selectedLayer);
		object obj3 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BCF0CD]");
		object obj4 = (nint)0 & (nint)1;
		float num3;
		float num4;
		float num5;
		float num6;
		if (obj4 != null)
		{
			num3 = (float)selectedLayer.Position + num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ X1_v1 (IconLayer)+44]");
			num4 = 0f + num2;
			object obj5 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X0_v7+E4]");
			bool flag = (nint)0 == 0;
			num5 = num4;
			num6 = num3;
			if (!flag)
			{
				goto IL_0141;
			}
		}
		else
		{
			_ = 1;
			num3 = (float)selectedLayer.Position + num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ X1_v1 (IconLayer)+44]");
			num4 = 0f + num2;
			object obj5 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X0_v7+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			num5 = num4;
			num6 = num3;
			if (obj6 != null)
			{
				goto IL_0141;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		float num7 = num6 * num6;
		float num8 = num5 * num5;
		float num9 = num7 + num8;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		if (num9 > effectiveMaxMoveDistance)
		{
			return;
		}
		goto IL_026e;
		IL_026e:
		_selectedLayer.SetPosition((Vector2)0);
		UpdateMovementButtons();
		return;
		IL_0141:
		float num10 = num3 * num3;
		float num11 = num4 * num4;
		float num12 = num10 + num11;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		if (num12 > effectiveMaxMoveDistance)
		{
			return;
		}
		goto IL_026e;
	}

	private void UpdateMovementButtons()
	{
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected O, but got Unknown
		//IL_04a9: Expected O, but got I
		//IL_04b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bd: Expected O, but got Unknown
		//IL_04d3: Expected O, but got I
		//IL_039f: Expected O, but got I4
		//IL_00c9: Expected O, but got I
		//IL_00e3: Expected O, but got I4
		//IL_0500: Unknown result type (might be due to invalid IL or missing references)
		//IL_0505: Expected O, but got Unknown
		//IL_051d: Expected O, but got I
		//IL_052d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0532: Expected O, but got Unknown
		//IL_03cd: Expected O, but got I
		//IL_064c: Expected O, but got I4
		//IL_054f: Expected O, but got I
		//IL_055f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0564: Expected O, but got Unknown
		//IL_057a: Expected O, but got I
		//IL_0431: Expected O, but got I4
		//IL_017a: Expected O, but got I
		//IL_0194: Expected O, but got I4
		//IL_05cd: Expected O, but got I
		//IL_05dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e2: Expected O, but got Unknown
		//IL_0467: Expected O, but got I
		//IL_06b4: Expected O, but got I4
		//IL_01d4: Invalid comparison between O and F4
		//IL_01e5: Expected O, but got I4
		//IL_01fd: Invalid comparison between F4 and I4
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Expected I4, but got Unknown
		//IL_0221: Invalid comparison between O and F4
		//IL_0232: Expected O, but got I4
		//IL_024a: Invalid comparison between F4 and I4
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Expected I4, but got Unknown
		//IL_026e: Invalid comparison between O and F4
		//IL_027f: Expected O, but got I4
		//IL_0297: Invalid comparison between F4 and I4
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Expected I4, but got Unknown
		//IL_02dc: Invalid comparison between O and F4
		//IL_02ed: Expected O, but got I4
		//IL_0305: Invalid comparison between F4 and I4
		//IL_031c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0321: Expected I4, but got Unknown
		IconLayer selectedLayer = _selectedLayer;
		float effectiveMaxMoveDistance;
		object obj;
		object obj4;
		if (_selectedLayer != null)
		{
			LogoLayerConfig layerConfig = selectedLayer.layerConfig;
			if (layerConfig.Movable)
			{
				effectiveMaxMoveDistance = GetEffectiveMaxMoveDistance(_selectedLayer);
				obj = typeof(UsageHint) + 744;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X8_v7+B8]");
				object obj3 = 0;
				obj4 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BCF0CD]");
				object obj5 = (nint)0 & (nint)1;
				if (obj5 != null)
				{
					object obj6 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X0_v39+E4]");
					if ((nint)0 != 0)
					{
						goto IL_00b3;
					}
				}
				else
				{
					_ = 1;
					object obj6 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X0_v39+E4]");
					bool flag = (nint)0 == 0;
					object obj7 = !flag;
					if (obj7 != null)
					{
						goto IL_00b3;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE4589]");
				object obj8 = (nint)0 & (nint)1;
				if (obj8 == null)
				{
					goto IL_00f1;
				}
				goto IL_04f0;
			}
		}
		bool right = false;
		bool down = false;
		bool left = false;
		bool up = false;
		goto IL_05e7;
		IL_04f0:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X8_v8+10]");
		object obj10 = default(object);
		object obj9 = 0 * obj10;
		object obj11 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X8_v11+B8]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X8_v12+18]");
		object obj13 = 0 * obj10;
		object obj14 = (object)selectedLayer.Position + obj9;
		object obj15 = (object)selectedLayer.Position + obj13;
		object obj16 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X0_v8+E4]");
		bool flag2 = (nint)0 == 0;
		object obj17 = !flag2;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj18 = obj14 * obj14;
		object obj19 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X8_v18+B8]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X8_v19+20]");
		object obj21 = 0 * obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BCF0CD]");
		object obj22 = (nint)0 & (nint)1;
		object obj23;
		object obj25;
		if (obj22 != null)
		{
			obj23 = (object)selectedLayer.Position + obj21;
			object obj24 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ X0_v20+E4]");
			bool flag3 = (nint)0 == 0;
			obj25 = obj23;
			if (!flag3)
			{
				goto IL_0164;
			}
		}
		else
		{
			_ = 1;
			obj23 = (object)selectedLayer.Position + obj21;
			object obj24 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ X0_v20+E4]");
			bool flag4 = (nint)0 == 0;
			object obj26 = !flag4;
			obj25 = obj23;
			if (obj26 != null)
			{
				goto IL_0164;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BCF0D1]");
		object obj27 = (nint)0 & (nint)1;
		bool flag5 = obj27 == null;
		obj23 = obj25;
		if (flag5)
		{
			goto IL_01aa;
		}
		goto IL_0597;
		IL_00f1:
		_ = 1;
		goto IL_04f0;
		IL_0164:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BCF0D1]");
		object obj28 = (nint)0 & (nint)1;
		bool flag6 = obj28 == null;
		object obj29 = !flag6;
		obj25 = obj23;
		if (obj29 == null)
		{
			goto IL_01aa;
		}
		goto IL_0597;
		IL_0597:
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
		object obj30 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ X8_v22+B8]");
		object obj31 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ X8_v23+28]");
		object obj32 = 0 * obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		object obj33 = (object)selectedLayer.Position + obj32;
		object obj34 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v358 @ X0_v13+E4]");
		bool flag7 = (nint)0 == 0;
		object obj35 = !flag7;
		if (obj35 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag8 = obj25 < (object)effectiveMaxMoveDistance;
		object obj36 = !flag8;
		float num = (float)obj25 - effectiveMaxMoveDistance;
		bool flag9 = num == 0f;
		object obj37 = ~obj36;
		bool flag10 = (byte)((obj37 | flag9) ? 1 : 0) != 0;
		object obj38 = default(object);
		bool flag11 = obj38 < (object)effectiveMaxMoveDistance;
		object obj39 = !flag11;
		float num2 = (float)obj38 - effectiveMaxMoveDistance;
		bool flag12 = num2 == 0f;
		object obj40 = ~obj39;
		bool flag13 = (byte)((obj40 | flag12) ? 1 : 0) != 0;
		bool flag14 = obj15 < (object)effectiveMaxMoveDistance;
		object obj41 = !flag14;
		float num3 = (float)obj15 - effectiveMaxMoveDistance;
		bool flag15 = num3 == 0f;
		object obj42 = ~obj41;
		bool flag16 = (byte)((obj42 | flag15) ? 1 : 0) != 0;
		object obj43 = obj33 * obj33;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		bool flag17 = obj43 < (object)effectiveMaxMoveDistance;
		object obj44 = !flag17;
		float num4 = (float)obj43 - effectiveMaxMoveDistance;
		bool flag18 = num4 == 0f;
		object obj45 = ~obj44;
		bool flag19 = (byte)((obj45 | flag18) ? 1 : 0) != 0;
		right = flag19;
		down = flag13;
		left = flag10;
		up = flag16;
		goto IL_05e7;
		IL_05e7:
		SetMovementButtonsInteractable(up, down, left, right);
		return;
		IL_01aa:
		_ = 1;
		obj25 = obj23;
		goto IL_0597;
		IL_00b3:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE4589]");
		object obj46 = (nint)0 & (nint)1;
		bool flag20 = obj46 == null;
		object obj47 = !flag20;
		if (obj47 == null)
		{
			goto IL_00f1;
		}
		goto IL_04f0;
	}

	private void SetMovementButtonsInteractable(bool up, bool down, bool left, bool right)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_028b: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_00be: Expected O, but got I4
		//IL_0334: Expected O, but got I4
		//IL_033d: Expected O, but got I4
		//IL_0136: Expected O, but got I4
		//IL_013f: Expected O, but got I4
		//IL_02de: Expected O, but got I4
		//IL_03dc: Expected O, but got I4
		//IL_03e5: Expected O, but got I4
		//IL_01bf: Expected O, but got I4
		//IL_01c8: Expected O, but got I4
		//IL_0183: Expected I4, but got O
		//IL_0386: Expected O, but got I4
		//IL_048c: Expected O, but got I4
		//IL_0495: Expected O, but got I4
		//IL_020c: Expected I4, but got O
		//IL_0436: Expected O, but got I4
		//IL_04e8: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E88AA]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object moveUpButton;
		UnityEngine.Object moveUpButton2;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v26+E4]");
			bool flag = (nint)0 == 0;
			moveUpButton = MoveUpButton;
			moveUpButton2 = MoveUpButton;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v26+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			moveUpButton = MoveUpButton;
			moveUpButton2 = MoveUpButton;
			if (obj5 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = moveUpButton2 != null;
		bool flag4 = !flag3;
		object obj6 = 0;
		UnityEngine.Object obj7 = null;
		if (flag4)
		{
			goto IL_00d1;
		}
		goto IL_02f1;
		IL_024b:
		MoveRightButton.interactable = right;
		return;
		IL_0224:
		UnityEngine.Object moveRightButton;
		if (moveRightButton != null)
		{
			goto IL_024b;
		}
		return;
		IL_04b5:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		UnityEngine.Object moveRightButton2;
		bool flag5 = moveRightButton2 != null;
		bool flag6 = !flag5;
		object obj8 = !flag6;
		if (obj8 == null)
		{
			return;
		}
		goto IL_024b;
		IL_0091:
		bool flag7 = moveUpButton != null;
		bool flag8 = !flag7;
		object obj9 = !flag8;
		obj6 = 0;
		obj7 = null;
		if (obj9 == null)
		{
			goto IL_00d1;
		}
		goto IL_02f1;
		IL_02f1:
		bool interactable = default(bool);
		MoveUpButton.interactable = interactable;
		UnityEngine.Object moveDownButton = MoveDownButton;
		object obj10 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X0_v19+E4]");
		bool flag9 = (nint)0 == 0;
		object obj11 = !flag9;
		obj6 = 0;
		UnityEngine.Object moveDownButton2 = MoveDownButton;
		if (obj11 != null)
		{
			goto IL_0112;
		}
		goto IL_0355;
		IL_00d1:
		obj10 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X0_v19+E4]");
		bool flag10 = (nint)0 == 0;
		moveDownButton = MoveDownButton;
		moveDownButton2 = MoveDownButton;
		if (!flag10)
		{
			goto IL_0112;
		}
		goto IL_0355;
		IL_0355:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag11 = moveDownButton2 != null;
		bool flag12 = !flag11;
		object obj12 = 0;
		UnityEngine.Object obj13 = null;
		if (flag12)
		{
			goto IL_0152;
		}
		goto IL_0399;
		IL_0112:
		bool flag13 = moveDownButton != null;
		bool flag14 = !flag13;
		object obj14 = !flag14;
		obj12 = 0;
		obj13 = null;
		if (obj14 == null)
		{
			goto IL_0152;
		}
		goto IL_0399;
		IL_0399:
		MoveDownButton.interactable = down;
		UnityEngine.Object moveLeftButton = MoveLeftButton;
		object obj15 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X0_v12+E4]");
		bool flag15 = (nint)0 == 0;
		object obj16 = !flag15;
		obj12 = 0;
		bool flag16 = down;
		UnityEngine.Object moveLeftButton2 = MoveLeftButton;
		if (obj16 != null)
		{
			goto IL_019b;
		}
		goto IL_0405;
		IL_0152:
		obj15 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X0_v12+E4]");
		bool flag17 = (nint)0 == 0;
		moveLeftButton = MoveLeftButton;
		flag16 = (byte)(int)obj13 != 0;
		moveLeftButton2 = MoveLeftButton;
		if (!flag17)
		{
			goto IL_019b;
		}
		goto IL_0405;
		IL_0405:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag18 = moveLeftButton2 != null;
		bool flag19 = !flag18;
		object obj17 = 0;
		UnityEngine.Object obj18 = null;
		if (flag19)
		{
			goto IL_01db;
		}
		goto IL_0449;
		IL_019b:
		bool flag20 = moveLeftButton != null;
		bool flag21 = !flag20;
		object obj19 = !flag21;
		obj17 = 0;
		obj18 = null;
		if (obj19 == null)
		{
			goto IL_01db;
		}
		goto IL_0449;
		IL_0449:
		MoveLeftButton.interactable = left;
		moveRightButton = MoveRightButton;
		object obj20 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ X8_v4+E4]");
		bool flag22 = (nint)0 == 0;
		object obj21 = !flag22;
		obj17 = 0;
		bool flag23 = left;
		moveRightButton2 = MoveRightButton;
		if (obj21 != null)
		{
			goto IL_0224;
		}
		goto IL_04b5;
		IL_01db:
		moveRightButton = MoveRightButton;
		obj20 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ X8_v4+E4]");
		bool flag24 = (nint)0 == 0;
		flag23 = (byte)(int)obj18 != 0;
		moveRightButton2 = MoveRightButton;
		if (!flag24)
		{
			goto IL_0224;
		}
		goto IL_04b5;
	}

	private void InstallCloseGuard()
	{
		//IL_0009: Expected O, but got I4
		//IL_001f: Expected O, but got I
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected O, but got Unknown
		//IL_0135: Expected O, but got I
		//IL_014f: Expected O, but got I4
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_0066: Expected O, but got I
		//IL_019f: Expected O, but got I4
		//IL_01ed: Expected O, but got I4
		//IL_0207: Expected O, but got I
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Expected O, but got Unknown
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Expected O, but got Unknown
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Expected O, but got Unknown
		//IL_0269: Expected O, but got I
		//IL_02a0: Expected O, but got I4
		//IL_02e3: Expected I, but got O
		object obj = 152993792;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E88E7]");
		object obj2 = (nint)0 & (nint)1;
		object obj3;
		object obj5;
		if (obj2 != null)
		{
			obj3 = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E88E0]");
			object obj4 = (nint)0 & (nint)1;
			bool flag = obj4 == null;
			obj5 = obj3;
			if (!flag)
			{
				goto IL_008b;
			}
		}
		else
		{
			_ = 1;
			obj3 = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E88E0]");
			object obj6 = (nint)0 & (nint)1;
			bool flag2 = obj6 == null;
			object obj7 = !flag2;
			obj5 = obj3;
			if (obj7 != null)
			{
				goto IL_008b;
			}
		}
		_ = 1;
		UnityEngine.Object slideAnim = _slideAnim;
		object obj8 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v18+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		UnityEngine.Object slideAnim2 = _slideAnim;
		if (obj9 != null)
		{
			goto IL_00cc;
		}
		goto IL_01b7;
		IL_0235:
		object obj10 = typeof(RegisteredWaitHandle) + 3136;
		object obj11 = typeof(SqlSingle[]) + 2376;
		object obj12 = (nint)0 + (nint)1256;
		SlideAnimationHelper slideAnim3 = default(SlideAnimationHelper);
		GameObject contentObject = slideAnim3.GetContentObject();
		object obj13 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X0_v4+E4]");
		bool flag4 = (nint)0 == 0;
		object obj14 = !flag4;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		ScreenManager.RemovePopup(contentObject);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj12);
		ScreenManager.PushPopup(contentObject, action);
		return;
		IL_00f6:
		slideAnim3 = _slideAnim;
		goto IL_0235;
		IL_01fb:
		object obj15 = (nint)0 + (nint)56;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		_slideAnim = slideAnim3;
		object obj16 = this + 272;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		goto IL_0235;
		IL_008b:
		obj8 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v18+E4]");
		bool flag5 = (nint)0 == 0;
		slideAnim = _slideAnim;
		slideAnim2 = _slideAnim;
		if (!flag5)
		{
			goto IL_00cc;
		}
		goto IL_01b7;
		IL_01b7:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag6 = slideAnim2;
		bool flag7 = !flag6;
		object obj17 = !flag7;
		if (obj17 != null)
		{
			goto IL_00f6;
		}
		goto IL_01fb;
		IL_00cc:
		if ((bool)slideAnim)
		{
			goto IL_00f6;
		}
		goto IL_01fb;
	}

	private bool HasMinimumLayers()
	{
		//IL_0244: Expected I4, but got O
		//IL_0030: Expected O, but got I
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_004c: Expected O, but got I
		//IL_0055: Expected O, but got I4
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_0286: Expected O, but got Unknown
		//IL_02b4: Expected O, but got I4
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		//IL_0095: Expected O, but got I
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected O, but got Unknown
		//IL_00d3: Expected I, but got O
		//IL_0120: Expected O, but got I
		//IL_015a: Expected O, but got I
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Expected I4, but got Unknown
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Expected O, but got Unknown
		LayerConfigReferences[] array = layerConfigs;
		if (layerConfigs == null)
		{
			goto IL_0228;
		}
		bool result;
		if (array.Length >= 1)
		{
			object obj = (nint)0 + (nint)4048;
			object obj2 = layerConfigs + 32;
			object obj3 = (nint)0 + (nint)3544;
			object obj4 = 0;
			<>c__DisplayClass104_0 <>c__DisplayClass104_ = default(<>c__DisplayClass104_0);
			Func<object, bool> func = default(Func<object, bool>);
			while (true)
			{
				object obj5 = typeof(CardUtils.<>c) + 944;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				<>c__DisplayClass104_..ctor();
				bool flag = (nint)obj4 < array.Length;
				object obj6 = !flag;
				if (obj6 != null)
				{
					break;
				}
				if (<>c__DisplayClass104_ != null)
				{
					object obj7 = <>c__DisplayClass104_ + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X26_v5+v97 @ X25_v6*8]");
					obj7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					object obj8 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1736;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					func..ctor((object)<>c__DisplayClass104_, (IntPtr)obj);
					int num = Enumerable.Count(layers, func);
					object obj9 = obj7;
					if (obj7 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v13+10]");
						object obj10 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v13+10]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X8_v14+2C]");
							object obj11 = (nint)num - (nint)0;
							bool flag2 = (nint)obj11 < 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X8_v14+2C]");
							int num2 = (int)((nint)num ^ (nint)0);
							int num3 = num ^ obj11;
							int num4 = num2 & num3;
							bool flag3 = num4 < 0;
							bool flag4 = flag2 == flag3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X8_v14+2C]");
							bool flag5 = (nint)num < (nint)0;
							result = flag4;
							if (!flag5)
							{
								obj4++;
								if ((nint)obj4 < array.Length)
								{
									continue;
								}
								result = flag4;
							}
							goto IL_026d;
						}
					}
				}
				goto IL_0228;
			}
			goto IL_0236;
		}
		result = true;
		goto IL_026d;
		IL_0236:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		return (byte)(int)ex != 0;
		IL_0228:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_0236;
		IL_026d:
		return result;
	}

	private unsafe void ApplyModel(ClanLogoModel model)
	{
		//IL_0020: Expected O, but got I4
		//IL_0031: Expected F8, but got I4
		//IL_004c: Expected O, but got I
		//IL_00b7: Expected native int or pointer, but got F8
		//IL_00c0: Expected I4, but got F8
		//IL_00da: Expected F4, but got O
		//IL_00e3: Expected O, but got I4
		//IL_010c: Expected O, but got I
		//IL_0114: Expected I4, but got O
		//IL_008e: Expected F4, but got O
		//IL_0097: Expected O, but got I4
		//IL_0cfd: Expected native int or pointer, but got F8
		//IL_0d06: Expected O, but got F8
		//IL_0d32: Expected native int or pointer, but got F8
		//IL_0d3b: Expected I4, but got F8
		//IL_013c: Expected native int or pointer, but got F8
		//IL_03b1: Expected native int or pointer, but got F8
		//IL_01cd: Expected native int or pointer, but got F8
		//IL_01e6: Expected O, but got I
		//IL_01f6: Expected O, but got I
		//IL_0218: Expected O, but got I4
		//IL_045a: Expected native int or pointer, but got F8
		//IL_0473: Expected O, but got I
		//IL_0483: Expected O, but got I
		//IL_04a5: Expected O, but got I4
		//IL_04ad: Expected O, but got I4
		//IL_04bd: Expected O, but got I
		//IL_028f: Expected O, but got I
		//IL_02c9: Expected I4, but got O
		//IL_02d1: Expected I4, but got O
		//IL_017a: Expected O, but got I
		//IL_018a: Expected O, but got I
		//IL_01ac: Expected O, but got I4
		//IL_0e51: Expected O, but got I
		//IL_0e59: Expected I, but got O
		//IL_0e78: Expected O, but got I
		//IL_03ef: Expected O, but got I
		//IL_03ff: Expected O, but got I
		//IL_0421: Expected O, but got I4
		//IL_0429: Expected O, but got I4
		//IL_0249: Expected O, but got I4
		//IL_04ee: Expected O, but got I4
		//IL_0308: Expected I, but got O
		//IL_0dce: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dd3: Expected O, but got Unknown
		//IL_0de9: Expected O, but got I
		//IL_0dfa: Expected I, but got O
		//IL_0dfe: Expected native int or pointer, but got F8
		//IL_0e1d: Expected O, but got I
		//IL_0e38: Expected O, but got I4
		//IL_0edb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ee0: Expected O, but got Unknown
		//IL_0ef6: Expected O, but got I
		//IL_0f07: Expected I, but got O
		//IL_0f0b: Expected native int or pointer, but got F8
		//IL_0f2a: Expected O, but got I
		//IL_0447: Expected O, but got I
		//IL_0265: Expected native int or pointer, but got F8
		//IL_027e: Expected O, but got I
		//IL_0539: Expected O, but got I4
		//IL_050a: Expected native int or pointer, but got F8
		//IL_0523: Expected O, but got I
		//IL_0592: Expected O, but got I4
		//IL_05c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ca: Expected I4, but got Unknown
		//IL_05ff: Expected O, but got I4
		//IL_0608: Expected I4, but got O
		//IL_0f58: Expected I4, but got O
		//IL_0649: Unknown result type (might be due to invalid IL or missing references)
		//IL_064e: Expected O, but got Unknown
		//IL_071e: Expected O, but got I4
		//IL_072f: Expected F8, but got I4
		//IL_0760: Expected O, but got I
		//IL_0790: Expected I, but got O
		//IL_0798: Expected O, but got I4
		//IL_07a8: Expected O, but got I4
		//IL_07b1: Expected F8, but got I4
		//IL_080c: Expected I, but got O
		//IL_0814: Expected O, but got I4
		//IL_082c: Expected O, but got I
		//IL_0835: Expected F8, but got I4
		//IL_0859: Expected O, but got I
		//IL_0886: Expected O, but got I
		//IL_08a6: Expected F8, but got I4
		//IL_08b1: Expected I, but got O
		//IL_08b9: Expected O, but got I4
		//IL_08cf: Expected F8, but got I4
		//IL_08ed: Expected F8, but got I
		//IL_0afc: Expected O, but got I
		//IL_0b0c: Expected O, but got I
		//IL_0b22: Expected O, but got I
		//IL_0b3a: Expected F4, but got I4
		//IL_0b43: Expected O, but got I4
		//IL_0936: Expected O, but got I
		//IL_0981: Invalid comparison between F8 and I4
		//IL_0990: Invalid comparison between F8 and I4
		//IL_09a8: Expected O, but got F8
		//IL_09b5: Expected O, but got F8
		//IL_09ea: Expected O, but got I4
		//IL_09f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f7: Expected O, but got Unknown
		//IL_10ec: Expected I, but got O
		//IL_0b61: Expected O, but got I
		//IL_0b71: Expected O, but got I
		//IL_0b89: Expected F8, but got I
		//IL_0ba2: Expected F4, but got I4
		//IL_0bab: Expected O, but got I4
		//IL_1008: Invalid comparison between F8 and I4
		//IL_0be4: Expected F4, but got I4
		//IL_0be9: Expected I, but got O
		//IL_0bf2: Expected F4, but got I4
		//IL_0ab8: Expected F4, but got I4
		//IL_0665: Invalid comparison between F4 and I4
		//IL_0674: Invalid comparison between F4 and I4
		//IL_0687: Expected O, but got F4
		//IL_068f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0694: Expected O, but got Unknown
		//IL_06bc: Expected O, but got I4
		//IL_06c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c9: Expected O, but got Unknown
		//IL_06d2: Expected I4, but got O
		//IL_103c: Expected O, but got I
		//IL_104c: Expected O, but got I
		//IL_1062: Expected O, but got I
		//IL_107c: Expected O, but got I4
		//IL_1085: Expected O, but got I4
		//IL_1095: Expected O, but got I
		//IL_10a5: Expected O, but got I
		//IL_10d6: Expected O, but got I4
		//IL_0a36: Expected F4, but got I4
		//IL_0c3a: Expected O, but got I4
		//IL_0c4b: Expected F8, but got I4
		//IL_0acb: Expected I, but got O
		//IL_0ad4: Expected F4, but got I4
		//IL_0f92: Expected O, but got I4
		//IL_0fd1: Expected I, but got O
		//IL_0fe1: Expected O, but got I
		if (model == null)
		{
			return;
		}
		bool flag = layers == null;
		List<object>.Enumerator enumerator = (List<object>.Enumerator)0;
		ClanLogoModel clanLogoModel = model;
		double num = 152993792.0;
		List<object>.Enumerator enumerator5;
		int num3;
		if (!flag)
		{
			object obj = (nint)0 + (nint)2056;
			num = 0.0 + 2048.0;
			List<object>.Enumerator enumerator2 = ((List<object>)(object)layers).GetEnumerator();
			List<object>.Enumerator enumerator3 = default(List<object>.Enumerator);
			IconLayer iconLayer = default(IconLayer);
			float num2;
			List<object>.Enumerator enumerator4 = default(List<object>.Enumerator);
			while (true)
			{
				clanLogoModel = (ClanLogoModel)obj;
				if (!enumerator3.MoveNext())
				{
					break;
				}
				bool flag2 = iconLayer == null;
				enumerator = enumerator4;
				num2 = (float)enumerator4;
				enumerator4 = (List<object>.Enumerator)0;
				if (!flag2)
				{
					iconLayer.Reset();
					continue;
				}
				goto IL_0ca9;
			}
			num3 = (int)((double*)(nint)num)->m_value;
			enumerator3.Dispose();
			enumerator5 = enumerator4;
			num2 = (float)enumerator4;
			enumerator4 = (List<object>.Enumerator)0;
			goto IL_00e8;
		}
		goto IL_0c9b;
		IL_0c7e:
		UpdateBelowMinButtons();
		ApplyLayerSiblingOrder();
		ClearUndoHistory();
		return;
		IL_0375:
		if (model.Icons == null)
		{
			goto IL_0c7e;
		}
		num = (double)typeof(CardUtils.<>c) + 936.0;
		double value = ((double*)(nint)num)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v657 @ X0_v57 (System.Double)+E4]");
		object obj2;
		Func<object, bool> predicate;
		Func<object, bool> func = default(Func<object, bool>);
		int num4;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v657 @ X0_v57 (System.Double)+B8]");
			obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v675 @ X8_v41+50]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v675 @ X8_v41+50]");
			bool flag3 = (nint)0 == 0;
			object obj3 = !flag3;
			func = (Func<object, bool>)num4;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v675 @ X8_v41+50]");
				Func<object, bool> func2 = (Func<object, bool>)0;
				goto IL_04cb;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			value = ((double*)(nint)num)->m_value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v657 @ X0_v57 (System.Double)+B8]");
			obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v675 @ X8_v41+50]");
			Func<object, bool> func2 = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v675 @ X8_v41+50]");
			bool flag4 = (nint)0 == 0;
			object obj4 = !flag4;
			func = (Func<object, bool>)num4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v675 @ X8_v41+50]");
			predicate = (Func<object, bool>)0;
			if (obj4 == null)
			{
				goto IL_04cb;
			}
		}
		goto IL_0e45;
		IL_0226:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v617 @ X0_v74 (System.Double)+E4]");
		bool flag5 = (nint)0 == 0;
		object obj5 = !flag5;
		object obj6;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			double value2 = ((double*)(nint)num)->m_value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v666 @ X8_v64 (System.Double)+B8]");
			obj6 = 0;
		}
		object obj7 = obj6;
		object obj8 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1736;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj9 = (nint)0 + (nint)3968;
		Func<object, bool> func3 = default(Func<object, bool>);
		func3..ctor(obj6, (IntPtr)obj9);
		double value3 = ((double*)(nint)num)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v601 @ X8_v63 (System.Double)+B8]");
		object obj10 = (nint)0 + (nint)72;
		obj10 = func3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj11 = 0;
		func = func3;
		goto IL_0283;
		IL_0e45:
		object obj12 = (nint)0 + (nint)3504;
		nint num5 = (nint)obj12;
		IEnumerable<object> source = Enumerable.Where(layers, predicate);
		object obj13 = (nint)0 + (nint)2176;
		clanLogoModel = (ClanLogoModel)obj13;
		List<object> list = Enumerable.ToList(source);
		List<ClanLogoIcon> icons = model.Icons;
		bool flag6 = model.Icons == null;
		Func<object, bool> func4;
		obj7 = func4;
		enumerator = enumerator5;
		if (!flag6)
		{
			bool flag7 = list == null;
			obj7 = func4;
			enumerator = enumerator5;
			if (!flag7)
			{
				object obj14 = icons._size - list._size;
				bool flag8 = (nint)obj14 < 0;
				int num6 = icons._size ^ list._size;
				int num7 = icons._size ^ obj14;
				int num8 = num6 & num7;
				bool flag9 = num8 < 0;
				bool flag10 = flag8 == flag9;
				object obj15 = !flag10;
				bool flag11 = (byte)(int)(~obj15) != 0;
				int num9 = (flag11 ? list._size : icons._size);
				bool flag12 = num9 < 1;
				num3 = (int)clanLogoModel;
				if (flag12)
				{
					goto IL_0c7e;
				}
				obj7 = typeof(MemberAchievementClanFeedData) + 2976;
				int num10 = 0;
				object obj21 = default(object);
				object obj25 = default(object);
				while (true)
				{
					bool flag13 = model.Icons == null;
					func = (Func<object, bool>)num10;
					enumerator = enumerator5;
					num = 1135869952.0;
					if (flag13)
					{
						break;
					}
					object obj16 = ((List<object>)(object)model.Icons).get_Item(num10);
					object obj17 = (nint)0 + (nint)760;
					object obj18 = list.get_Item(num10);
					bool flag14 = obj16 == null;
					num5 = (nint)obj17;
					func = (Func<object, bool>)num10;
					enumerator = enumerator5;
					clanLogoModel = (ClanLogoModel)num10;
					num = 1135869952.0;
					if (flag14)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v717 @ X0_v33 (System.Object)+14]");
					Color color = ColorExtension.FromPackedRgba(0);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v717 @ X0_v33 (System.Object)+10]");
					ApplyModelToLayer((IconLayer)obj18, 0, (Color)obj17);
					bool flag15 = obj18 == null;
					num5 = (nint)obj17;
					func = (Func<object, bool>)num10;
					enumerator = enumerator5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v717 @ X0_v33 (System.Object)+10]");
					clanLogoModel = (ClanLogoModel)0;
					num = 1135869952.0;
					if (flag15)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v717 @ X0_v33 (System.Object)+18]");
					object obj19 = (nint)1127481344 - (nint)0;
					float num2 = (float)obj19 / 1.13587E+09f;
					((IconLayer)obj18).SetRotation(num2);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ X0_v35 (System.Object)+18]");
					object obj20 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ X0_v35 (System.Object)+18]");
					bool flag16 = (nint)0 == 0;
					double num11 = 1135869952.0;
					num5 = (nint)obj17;
					func = (Func<object, bool>)num10;
					enumerator = enumerator5;
					clanLogoModel = null;
					num = 1135869952.0;
					if (flag16)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ X8_v30+24]");
					double num12 = 0.0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ X8_v30+20]");
					nint num13 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ X8_v30+24]");
					float num19;
					object obj28;
					object obj29;
					object obj32;
					object obj33;
					object obj34;
					object obj35;
					object obj36;
					bool flag22;
					float num20;
					object obj37;
					if (num13 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v717 @ X0_v33 (System.Object)+24]");
						nint num14 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ X8_v30+20]");
						obj21 = num14 - 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ X8_v30+24]");
						double num15 = 0.0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ X8_v30+20]");
						double num16 = num15 - 0.0;
						double num17 = (double)obj21 / num16;
						double num18 = num17 - 1.0;
						bool flag17 = num18 < 0.0;
						bool flag18 = num18 == 0.0;
						object obj22 = num17 ^ 1.0;
						object obj23 = num17 ^ num18;
						object obj24 = obj22 & obj23;
						bool flag19 = (nint)obj24 < 0;
						bool flag20 = flag17 == flag19;
						obj25 = !flag18;
						object obj26 = flag20 & obj25;
						object obj27 = ~obj26;
						num12 = ((obj27 != null) ? num17 : 1.0);
						flag11 = !(num17 < 0.0);
						num19 = (flag11 ? ((float)num12) : 0f);
						((IconLayer)obj18).SetScale(num19);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v717 @ X0_v33 (System.Object)+1C]");
						obj28 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v717 @ X0_v33 (System.Object)+20]");
						obj29 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E88E6]");
						object obj30 = (nint)0 & (nint)1;
						bool flag21 = obj30 == null;
						object obj31 = !flag21;
						obj32 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v717 @ X0_v33 (System.Object)+20]");
						obj33 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v717 @ X0_v33 (System.Object)+1C]");
						obj34 = 0;
						obj35 = obj21;
						num11 = num12;
						obj36 = obj25;
						flag22 = flag11;
						num20 = num19;
						obj37 = 0;
						if (obj31 == null)
						{
							goto IL_0a48;
						}
					}
					else
					{
						((IconLayer)obj18).SetScale(0f);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v717 @ X0_v33 (System.Object)+1C]");
						obj28 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v717 @ X0_v33 (System.Object)+20]");
						obj29 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E88E6]");
						object obj38 = (nint)0 & (nint)1;
						bool flag23 = obj38 == null;
						num19 = 0f;
						obj32 = 0;
						if (flag23)
						{
							goto IL_0a48;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v717 @ X0_v33 (System.Object)+20]");
						obj33 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v717 @ X0_v33 (System.Object)+1C]");
						obj34 = 0;
						obj35 = obj21;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ X8_v30+24]");
						num11 = 0.0;
						obj36 = obj25;
						flag22 = flag11;
						num20 = 0f;
						obj37 = 0;
					}
					goto IL_10e4;
					IL_0a48:
					_ = 1;
					obj33 = obj29;
					obj34 = obj28;
					obj35 = obj21;
					num11 = num12;
					obj36 = obj25;
					flag22 = flag11;
					num20 = num19;
					obj37 = obj32;
					goto IL_10e4;
					IL_10e4:
					nint num21 = (nint)obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v813 @ X0_v41 (Il2CppClass<System.Object>)+E4]");
					float num22;
					if ((nint)0 != 0)
					{
						bool flag24 = previewer != null;
						bool flag25 = !flag24;
						num22 = 0f;
						if (flag25)
						{
							goto IL_065c;
						}
						num5 = unchecked((nint)null);
						num2 = 0f;
						clanLogoModel = null;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						bool flag26 = previewer != null;
						bool flag27 = !flag26;
						num22 = 0f;
						num5 = unchecked((nint)null);
						num2 = 0f;
						clanLogoModel = null;
						if (flag27)
						{
							goto IL_065c;
						}
					}
					bool flag28 = (object)previewer == null;
					obj21 = obj35;
					obj25 = obj36;
					flag11 = flag22;
					func = (Func<object, bool>)num10;
					enumerator = enumerator5;
					num = 1135869952.0;
					if (flag28)
					{
						break;
					}
					float rimHalfExtent = previewer.GetRimHalfExtent();
					num22 = rimHalfExtent * 1.0586423E+09f;
					goto IL_065c;
					IL_065c:
					bool flag29 = num22 < 0f;
					bool flag30 = num22 == 0f;
					object obj39 = num22 ^ num22;
					object obj40 = num22 & obj39;
					bool flag31 = (nint)obj40 < 0;
					bool flag32 = flag29 == flag31;
					obj25 = !flag30;
					object obj41 = flag32 & obj25;
					flag11 = (byte)(int)(~obj41) != 0;
					double num23 = (flag11 ? 1.0 : ((double)num22));
					num2 = (float)obj34 * (float)num23;
					num11 = (double)obj33 * num23;
					((IconLayer)obj18).SetPosition((Vector2)0);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v717 @ X0_v33 (System.Object)+28]");
					((IconLayer)obj18).SetInverted(inverted: false);
					num10++;
					bool flag33 = num9 == num10;
					obj21 = obj35;
					num5 = unchecked((nint)null);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v717 @ X0_v33 (System.Object)+28]");
					clanLogoModel = (ClanLogoModel)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v717 @ X0_v33 (System.Object)+28]");
					num3 = 0;
					if (!flag33)
					{
						continue;
					}
					goto IL_0c7e;
				}
			}
		}
		goto IL_0c9b;
		IL_0c9b:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0ca9;
		IL_0ca9:
		NullReferenceException ex2 = new NullReferenceException();
		bool flag34 = (nint)clanLogoModel != 1;
		NullReferenceException ex3 = ex2;
		if (!flag34)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			clanLogoModel = (ClanLogoModel)((double*)(nint)num)->m_value;
			enumerator.Dispose();
			object obj42 = default(object);
			bool flag35 = obj42 == null;
			enumerator5 = enumerator;
			List<object>.Enumerator enumerator4 = (List<object>.Enumerator)obj42;
			num3 = (int)((double*)(nint)num)->m_value;
			if (flag35)
			{
				goto IL_00e8;
			}
			OutOfMemoryException ex4 = new OutOfMemoryException();
			enumerator4 = (List<object>.Enumerator)obj42;
			ex3 = (NullReferenceException)(object)ex4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223E080");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return;
		IL_0283:
		object obj43 = (nint)0 + (nint)920;
		Color color2 = (Color)obj43;
		object obj44 = Enumerable.FirstOrDefault(layers, func);
		bool flag36 = obj44 == null;
		func4 = (Func<object, bool>)obj7;
		num4 = (int)func;
		num3 = (int)func;
		if (!flag36)
		{
			ClanLogoRim rim = model.Rim;
			bool flag37 = model.Rim == null;
			num5 = (nint)obj43;
			enumerator = enumerator5;
			clanLogoModel = (ClanLogoModel)(object)func;
			if (flag37)
			{
				goto IL_0c9b;
			}
			num4 = rim.Id;
			Color color3 = ColorExtension.FromPackedRgba(rim.Color);
			ApplyModelToLayer((IconLayer)obj44, rim.Id, (Color)obj43);
			func4 = (Func<object, bool>)obj7;
			num3 = rim.Id;
		}
		goto IL_0375;
		IL_00e8:
		bool flag38 = model.Rim == null;
		func4 = (Func<object, bool>)obj7;
		color2 = (Color)num5;
		num4 = (int)func;
		if (!flag38)
		{
			num = (double)typeof(CardUtils.<>c) + 936.0;
			double value4 = ((double*)(nint)num)->m_value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v617 @ X0_v74 (System.Double)+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v617 @ X0_v74 (System.Double)+B8]");
				obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v649 @ X8_v58+48]");
				func = (Func<object, bool>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v649 @ X8_v58+48]");
				bool flag39 = (nint)0 == 0;
				object obj45 = !flag39;
				if (obj45 == null)
				{
					goto IL_0226;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				value4 = ((double*)(nint)num)->m_value;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v617 @ X0_v74 (System.Double)+B8]");
				obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v649 @ X8_v58+48]");
				func = (Func<object, bool>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v649 @ X8_v58+48]");
				bool flag40 = (nint)0 == 0;
				object obj46 = !flag40;
				if (obj46 == null)
				{
					goto IL_0226;
				}
			}
			goto IL_0283;
		}
		goto IL_0375;
		IL_04cb:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v657 @ X0_v57 (System.Double)+E4]");
		bool flag41 = (nint)0 == 0;
		object obj47 = !flag41;
		if (obj47 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			double value5 = ((double*)(nint)num)->m_value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v686 @ X8_v47 (System.Double)+B8]");
			obj2 = 0;
		}
		object obj48 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1736;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj49 = (nint)0 + (nint)3976;
		Func<object, bool> func5 = default(Func<object, bool>);
		func5..ctor(obj2, (IntPtr)obj49);
		double value6 = ((double*)(nint)num)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v637 @ X8_v46 (System.Double)+B8]");
		object obj50 = (nint)0 + (nint)80;
		obj50 = func5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		func4 = func5;
		obj11 = 0;
		func = (Func<object, bool>)obj2;
		predicate = func5;
		goto IL_0e45;
	}

	private static void ApplyModelToLayer(IconLayer layer, int imageId, Color color)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_00da: Expected O, but got I4
		//IL_009c: Expected O, but got I4
		//IL_0109: Expected O, but got I4
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v4+E4]");
		if ((nint)0 != 0)
		{
			if (layer.Selector != null)
			{
				goto IL_0072;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag = layer.Selector != null;
			bool flag2 = !flag;
			object obj3 = !flag2;
			if (obj3 != null)
			{
				goto IL_0072;
			}
		}
		layer.SetImage(imageId);
		goto IL_00fb;
		IL_00fb:
		layer.SetColor((Color)0);
		return;
		IL_0072:
		layer.Selector.RestoreSelectionToId(imageId);
		layer.Selector.SetColorSelectorTo((Color)0);
		goto IL_00fb;
	}

	public ClanLogoBuilder()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Expected O, but got Unknown
		//IL_006b: Expected F4, but got I
		//IL_007a: Expected I4, but got I8
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected O, but got Unknown
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected O, but got Unknown
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Expected O, but got Unknown
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Expected O, but got Unknown
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Expected O, but got Unknown
		object obj = typeof(List<AdaptivePerformanceScaler>) + 1680;
		object obj2 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 3272;
		object obj3 = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 768;
		object obj4 = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 472;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj5 = this + 96;
		obj5 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [72535F0]");
		MoveStep = 0f;
		maxUndoCount = 20;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		LinkedList<UndoEntry> linkedList = default(LinkedList<UndoEntry>);
		linkedList..ctor();
		object obj6 = this + 216;
		obj6 = linkedList;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Dictionary<object, LayerSnapshot> dictionary = default(Dictionary<object, LayerSnapshot>);
		dictionary..ctor();
		object obj7 = this + 224;
		obj7 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Dictionary<System.Int32Enum, object> dictionary2 = default(Dictionary<System.Int32Enum, object>);
		dictionary2..ctor();
		object obj8 = this + 232;
		obj8 = dictionary2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list2 = default(List<object>);
		list2..ctor();
		object obj9 = this + 240;
		obj9 = list2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list3 = default(List<object>);
		list3..ctor();
		object obj10 = this + 248;
		obj10 = list3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
	}

	private void <Start>b__49_0(Action _)
	{
		AddUndo(_selectedLayer);
	}

	private void <Start>b__49_1(Action _)
	{
		AddUndo(_selectedLayer);
	}

	private ClanLogoIcon <LayersToModel>b__70_2(IconLayer l)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0052: Expected O, but got I4
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected O, but got Unknown
		//IL_00c3: Expected O, but got I
		//IL_01a8: Expected O, but got I4
		//IL_0145: Expected O, but got I4
		//IL_014e: Expected O, but got I4
		//IL_0165: Expected O, but got I4
		//IL_016e: Expected F4, but got I4
		//IL_01fb: Expected O, but got I4
		//IL_0204: Expected O, but got I4
		//IL_020d: Expected F4, but got I4
		//IL_05b1: Invalid comparison between F4 and I4
		//IL_05c0: Invalid comparison between F4 and I4
		//IL_05d3: Expected O, but got F4
		//IL_05db: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e0: Expected O, but got Unknown
		//IL_0608: Expected O, but got I4
		//IL_0610: Unknown result type (might be due to invalid IL or missing references)
		//IL_0615: Expected O, but got Unknown
		//IL_065d: Invalid comparison between F8 and I4
		//IL_066c: Invalid comparison between F8 and I4
		//IL_0684: Expected O, but got F8
		//IL_0691: Expected O, but got F8
		//IL_06c6: Expected O, but got I4
		//IL_06ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d3: Expected O, but got Unknown
		//IL_0731: Expected O, but got I
		//IL_0388: Expected O, but got I4
		//IL_0332: Expected O, but got I4
		//IL_0349: Expected F4, but got I4
		//IL_03d1: Expected F4, but got I4
		//IL_0757: Invalid comparison between F4 and I4
		//IL_0766: Invalid comparison between F4 and I4
		//IL_0779: Expected O, but got F4
		//IL_0781: Unknown result type (might be due to invalid IL or missing references)
		//IL_0786: Expected O, but got Unknown
		//IL_07ae: Expected O, but got I4
		//IL_07b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07bb: Expected O, but got Unknown
		//IL_0806: Invalid comparison between F8 and I4
		//IL_0815: Invalid comparison between F8 and I4
		//IL_082d: Expected O, but got F8
		//IL_083a: Expected O, but got F8
		//IL_086f: Expected O, but got I4
		//IL_0877: Unknown result type (might be due to invalid IL or missing references)
		//IL_087c: Expected O, but got Unknown
		//IL_04a1: Invalid comparison between F8 and I4
		//IL_04b0: Invalid comparison between F8 and I4
		//IL_04cd: Expected O, but got F8
		//IL_04df: Expected O, but got F8
		//IL_0514: Expected O, but got I4
		//IL_051c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0521: Expected O, but got Unknown
		//IL_0901: Invalid comparison between F4 and I4
		//IL_0565: Expected F8, but got I4
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1280;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		ClanLogoIcon clanLogoIcon = default(ClanLogoIcon);
		clanLogoIcon..ctor();
		if (l == null || clanLogoIcon == null)
		{
			goto IL_056a;
		}
		clanLogoIcon.Id = l.ImageId;
		int color = ColorExtension.ToPackedRgba((Color)0);
		clanLogoIcon.Color = color;
		float num = l.Rotation * 3.2833536E+09f;
		float rotation = num + 1.1274813E+09f;
		clanLogoIcon.Rotation = rotation;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E88E6]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X0_v27+E4]");
			bool flag = (nint)0 == 0;
			obj5 = previewer;
			obj6 = previewer;
			if (!flag)
			{
				goto IL_0121;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X0_v27+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = previewer;
			obj6 = previewer;
			if (obj7 != null)
			{
				goto IL_0121;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6 != null;
		bool flag4 = !flag3;
		object obj8 = 0;
		object obj9 = 0;
		float num2 = 0f;
		UnityEngine.Object obj10 = null;
		if (!flag4)
		{
			goto IL_0220;
		}
		goto IL_05a8;
		IL_074e:
		float num3;
		bool flag5 = num3 < 0f;
		bool flag6 = num3 == 0f;
		object obj11 = num3 ^ num3;
		object obj12 = num3 & obj11;
		bool flag7 = (nint)obj12 < 0;
		bool flag8 = flag5 == flag7;
		object obj13 = !flag6;
		object obj14 = flag8 & obj13;
		object obj15 = ~obj14;
		double num4 = ((obj15 != null) ? 1.0 : ((double)num3));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [l @ X1 (IconLayer)+44]");
		double num5 = 0.0 / num4;
		double num6 = num5 - 1.0;
		bool flag9 = num6 < 0.0;
		bool flag10 = num6 == 0.0;
		object obj16 = num5 ^ 1.0;
		object obj17 = num5 ^ num6;
		object obj18 = obj16 & obj17;
		bool flag11 = (nint)obj18 < 0;
		bool flag12 = flag9 == flag11;
		object obj19 = !flag10;
		object obj20 = flag12 & obj19;
		object obj21 = ~obj20;
		double num7 = ((obj21 != null) ? num5 : 1.0);
		double num8 = ((!(num5 < -1.0)) ? num7 : (-1.0));
		clanLogoIcon.PositionY = (float)num8;
		LogoLayerConfig layerConfig = l.layerConfig;
		if ((object)l.layerConfig != null)
		{
			double num9 = (double)l.Scale - 1.0;
			bool flag13 = num9 < 0.0;
			bool flag14 = num9 == 0.0;
			object obj22 = (double)l.Scale ^ 1.0;
			object obj23 = (double)l.Scale ^ num9;
			object obj24 = obj22 & obj23;
			bool flag15 = (nint)obj24 < 0;
			bool flag16 = flag13 == flag15;
			object obj25 = !flag14;
			object obj26 = flag16 & obj25;
			object obj27 = ~obj26;
			double num10 = ((obj27 != null) ? ((double)l.Scale) : 1.0);
			if (l.Scale < 0f)
			{
				num10 = 0.0;
			}
			float num11 = layerConfig.MaxSize - layerConfig.MinSize;
			double num12 = (double)num11 * num10;
			double num13 = (double)layerConfig.MinSize + num12;
			clanLogoIcon.Scale = (float)num13;
			clanLogoIcon.IsFlipped = l.Inverted;
			return clanLogoIcon;
		}
		goto IL_056a;
		IL_056a:
		return (ClanLogoIcon)(object)new NullReferenceException();
		IL_03df:
		if ((object)previewer == null)
		{
			goto IL_056a;
		}
		float rimHalfExtent = previewer.GetRimHalfExtent();
		num3 = rimHalfExtent * 1.0586423E+09f;
		goto IL_074e;
		IL_030e:
		UnityEngine.Object obj28;
		bool flag17 = obj28 != null;
		bool flag18 = !flag17;
		object obj29 = !flag18;
		if (obj29 != null)
		{
			goto IL_03df;
		}
		num3 = 0f;
		goto IL_074e;
		IL_05a8:
		bool flag19 = num2 < 0f;
		bool flag20 = num2 == 0f;
		object obj30 = num2 ^ num2;
		object obj31 = num2 & obj30;
		bool flag21 = (nint)obj31 < 0;
		bool flag22 = flag19 == flag21;
		object obj32 = !flag20;
		object obj33 = flag22 & obj32;
		object obj34 = ~obj33;
		double num14 = ((obj34 != null) ? 1.0 : ((double)num2));
		double num15 = (double)l.Position / num14;
		double num16 = num15 - 1.0;
		bool flag23 = num16 < 0.0;
		bool flag24 = num16 == 0.0;
		object obj35 = num15 ^ 1.0;
		object obj36 = num15 ^ num16;
		object obj37 = obj35 & obj36;
		bool flag25 = (nint)obj37 < 0;
		bool flag26 = flag23 == flag25;
		object obj38 = !flag24;
		object obj39 = flag26 & obj38;
		object obj40 = ~obj39;
		double num17 = ((obj40 != null) ? num15 : 1.0);
		double num18 = ((!(num15 < -1.0)) ? num17 : (-1.0));
		clanLogoIcon.PositionX = (float)num18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E88E6]");
		object obj41 = (nint)0 & (nint)1;
		UnityEngine.Object obj43;
		if (obj41 != null)
		{
			obj28 = previewer;
			object obj42 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ X8_v16+E4]");
			bool flag27 = (nint)0 == 0;
			obj43 = previewer;
			if (!flag27)
			{
				goto IL_030e;
			}
		}
		else
		{
			_ = 1;
			obj28 = previewer;
			object obj42 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ X8_v16+E4]");
			bool flag28 = (nint)0 == 0;
			object obj44 = !flag28;
			obj43 = previewer;
			if (obj44 != null)
			{
				goto IL_030e;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag29 = obj43 != null;
		bool flag30 = !flag29;
		num3 = 0f;
		if (!flag30)
		{
			goto IL_03df;
		}
		goto IL_074e;
		IL_0121:
		bool flag31 = obj5 != null;
		bool flag32 = !flag31;
		object obj45 = !flag32;
		obj8 = 0;
		if (obj45 != null)
		{
			goto IL_0220;
		}
		obj9 = 0;
		num2 = 0f;
		obj10 = null;
		goto IL_05a8;
		IL_0220:
		if ((object)previewer == null)
		{
			goto IL_056a;
		}
		float rimHalfExtent2 = previewer.GetRimHalfExtent();
		num2 = rimHalfExtent2 * 1.0586423E+09f;
		obj9 = obj8;
		obj10 = null;
		goto IL_05a8;
	}
}
