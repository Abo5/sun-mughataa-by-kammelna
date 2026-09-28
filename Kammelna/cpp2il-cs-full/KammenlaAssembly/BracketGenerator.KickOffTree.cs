using System;
using System.Buffers.Text;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Text.RegularExpressions;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using GoogleMobileAds.Api.AdManager;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json.Linq.JsonPath;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.TextCore;

public class BracketGenerator : MonoBehaviour
{
	private class KickOffTree
	{
		private readonly List<Vector2> _bracketsPositions;

		private readonly Vector2 _startingPoint;

		private readonly Vector2 _spacing;

		private readonly Vector2 _bracketUnitRectSize;

		private int _gamesInCurrentColumn;

		private int _xSpacingFactor;

		private int _ySpacingFactor;

		public KickOffTree(int firstRoundGames, Vector2 startingPoint, Vector2 spacing, Vector2 bracketUnitRectSize)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_007c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0081: Expected O, but got Unknown
			object obj = typeof(List<Tween>) + 264;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			List<Vector2> list = default(List<Vector2>);
			list..ctor();
			object obj2 = this + 16;
			obj2 = list;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			_ySpacingFactor = 1;
			base..ctor();
			_gamesInCurrentColumn = firstRoundGames;
			Vector2 startingPoint2 = default(Vector2);
			_startingPoint = startingPoint2;
			Vector2 spacing2 = default(Vector2);
			_spacing = spacing2;
			Vector2 bracketUnitRectSize2 = default(Vector2);
			_bracketUnitRectSize = bracketUnitRectSize2;
		}

		public List<Vector2> CreateBracketPositions()
		{
			CreateColumn();
			return _bracketsPositions;
		}

		private void CreateColumn()
		{
			//IL_0016: Expected O, but got I
			//IL_02a0: Expected O, but got I4
			//IL_02ae: Expected I4, but got O
			//IL_02c6: Expected O, but got I4
			//IL_02e0: Expected O, but got I4
			//IL_0058: Unknown result type (might be due to invalid IL or missing references)
			//IL_005d: Expected O, but got Unknown
			//IL_0089: Expected O, but got I
			//IL_0093: Unknown result type (might be due to invalid IL or missing references)
			//IL_0098: Expected O, but got Unknown
			//IL_00cc: Expected O, but got I4
			//IL_0182: Expected O, but got I
			//IL_0197: Expected O, but got I
			//IL_01b9: Expected O, but got I
			//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c8: Expected O, but got Unknown
			//IL_020d: Expected O, but got I4
			//IL_00e1: Expected O, but got I
			//IL_00f1: Expected O, but got I
			//IL_0106: Expected O, but got I
			//IL_010f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0114: Expected O, but got Unknown
			//IL_0231: Expected O, but got I
			//IL_0246: Unknown result type (might be due to invalid IL or missing references)
			//IL_024b: Expected O, but got Unknown
			//IL_025e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0263: Expected O, but got Unknown
			int num = _gamesInCurrentColumn;
			object obj = (nint)0 + (nint)3304;
			bool flag = _gamesInCurrentColumn < 1;
			nint num3 = default(nint);
			nint num2 = num3;
			if (!flag)
			{
				goto IL_003d;
			}
			goto IL_0293;
			IL_003d:
			object obj2 = _bracketUnitRectSize + _spacing;
			object obj3 = obj2 * _xSpacingFactor;
			object obj4 = (object)_startingPoint + obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BracketGenerator+KickOffTree)+2C]");
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BracketGenerator+KickOffTree)+24]");
			object obj5 = num4 + 0;
			object obj6 = obj5 * _ySpacingFactor;
			double num5 = (double)obj6 * -0.5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BracketGenerator+KickOffTree)+1C]");
			double num6 = 0.0 + num5;
			object obj7 = 0;
			while (true)
			{
				List<Vector2> bracketsPositions = _bracketsPositions;
				object obj8 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X0_v5 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+1C]");
				object obj9 = (nint)0 + (nint)1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X0_v5 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+10]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BracketGenerator+KickOffTree)+2C]");
				nint num7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BracketGenerator+KickOffTree)+24]");
				object obj11 = num7 + 0;
				object obj12 = obj11 * _ySpacingFactor;
				object obj13 = obj12 * obj7;
				double num8 = num6 - (double)obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X0_v5 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
				nint num9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X9_v10+18]");
				bool flag2 = num9 < 0;
				object obj14 = !flag2;
				if (obj14 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X8_v8+20]");
					object obj15 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X8_v12+C0]");
					object obj16 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X8_v13+70]");
					bracketsPositions.AddWithResize((Vector2)0);
					obj7++;
					num = _gamesInCurrentColumn;
					bool flag3 = (nint)obj7 >= _gamesInCurrentColumn;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X8_v13+70]");
					num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X8_v13+70]");
					num2 = 0;
					if (flag3)
					{
						break;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X0_v5 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
					object obj17 = (nint)0 + (nint)1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X0_v5 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
					object obj18 = obj10 + 0;
					obj7++;
					num = _gamesInCurrentColumn;
					bool flag4 = (nint)obj7 < _gamesInCurrentColumn;
					num2 = num3;
					if (!flag4)
					{
						break;
					}
				}
			}
			goto IL_0293;
			IL_0293:
			while (true)
			{
				object obj19 = num + num;
				int num10 = (_gamesInCurrentColumn = obj19 >> 1);
				object obj20 = num + 1;
				bool flag5 = (nint)obj20 < 3;
				object obj21 = !flag5;
				object obj22 = ~obj21;
				if (obj22 == null)
				{
					int xSpacingFactor = _xSpacingFactor + 1;
					_xSpacingFactor = xSpacingFactor;
					bool flag6 = num10 >= 1;
					num3 = num2;
					if (flag6)
					{
						break;
					}
					num = num10;
					continue;
				}
				return;
			}
			goto IL_003d;
		}

		private Vector2 GetColumnStartingPoint()
		{
			return (Vector2)this;
		}

		private void AddUnitPosition(Vector2 columnStartingPoint, int row)
		{
			//IL_0011: Expected O, but got I
			//IL_002f: Expected O, but got I
			//IL_0044: Expected O, but got I
			//IL_0066: Expected O, but got I
			//IL_0070: Unknown result type (might be due to invalid IL or missing references)
			//IL_0075: Expected O, but got Unknown
			//IL_00b8: Expected O, but got I4
			//IL_0111: Expected O, but got I
			//IL_0121: Expected O, but got I
			//IL_0136: Expected O, but got I
			//IL_00dc: Expected O, but got I
			//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f6: Expected O, but got Unknown
			List<Vector2> bracketsPositions = _bracketsPositions;
			object obj = (nint)0 + (nint)3304;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v2 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+1C]");
			object obj3 = (nint)0 + (nint)1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v2 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+10]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BracketGenerator+KickOffTree)+2C]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BracketGenerator+KickOffTree)+24]");
			object obj5 = num + 0;
			object obj6 = obj5 * _ySpacingFactor;
			object obj7 = obj6 * (object)columnStartingPoint;
			object obj9 = default(object);
			object obj8 = obj9 - obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v2 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X9_v4+18]");
			bool flag = num2 < 0;
			object obj10 = !flag;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v2 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
				object obj11 = (nint)0 + (nint)1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v2 (System.Collections.Generic.List`1<UnityEngine.Vector2>)+18]");
				object obj12 = obj4 + 0;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X8_v6+20]");
				object obj13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v7+C0]");
				object obj14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X8_v8+70]");
				bracketsPositions.AddWithResize((Vector2)0);
			}
		}

		private void CreateNextColumn()
		{
			//IL_0011: Expected O, but got I4
			//IL_001f: Expected I4, but got O
			//IL_0039: Expected O, but got I4
			//IL_0053: Expected O, but got I4
			object obj = _gamesInCurrentColumn + _gamesInCurrentColumn;
			int gamesInCurrentColumn = obj >> 1;
			_gamesInCurrentColumn = gamesInCurrentColumn;
			object obj2 = _gamesInCurrentColumn + 1;
			bool flag = (nint)obj2 < 3;
			object obj3 = !flag;
			if (obj3 != null)
			{
				int xSpacingFactor = _xSpacingFactor + 1;
				_xSpacingFactor = xSpacingFactor;
				CreateColumn();
			}
		}

		private int GetNumberOfGamesAtNextRound()
		{
			//IL_0011: Expected O, but got I4
			//IL_001f: Expected I4, but got O
			object obj = _gamesInCurrentColumn + _gamesInCurrentColumn;
			return obj >> 1;
		}

		private bool AnotherRowIsNeeded()
		{
			bool flag = _gamesInCurrentColumn == 0;
			return !flag;
		}

		private void IncreaseSpacingFactors()
		{
			int xSpacingFactor = _xSpacingFactor + 1;
			_xSpacingFactor = xSpacingFactor;
		}
	}

	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<GameObject, BracketUnit> <>9__15_0;

		public static Func<GameObject, BracketLines> <>9__16_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 3336;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal BracketUnit <GetBracketUnits>b__15_0(GameObject o)
		{
			//IL_0011: Expected O, but got I
			if ((object)o != null)
			{
				object obj = (nint)0 + (nint)1120;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E32EDC");
				BracketUnit result = default(BracketUnit);
				return result;
			}
			return (BracketUnit)(object)new NullReferenceException();
		}

		internal BracketLines <GetBracketLines>b__16_0(GameObject o)
		{
			//IL_0011: Expected O, but got I
			if ((object)o != null)
			{
				object obj = (nint)0 + (nint)1112;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E32EDC");
				BracketLines result = default(BracketLines);
				return result;
			}
			return (BracketLines)(object)new NullReferenceException();
		}
	}

	private GameObject bracketUnit;

	private GameObject bracketLines;

	private GameObject bracketLine_prefab;

	private RectTransform bracketsArea;

	private int tournamentSize;

	private Vector2 margin;

	private Vector2 spacing;

	private float lineThickness;

	private readonly List<GameObject> bracketUnits;

	private readonly List<GameObject> _bracketLines;

	private Sequence _navigationSequence;

	private readonly Dictionary<string, GameObject> groups;

	private Vector2 BracketUnitRectSize
	{
		get
		{
			//IL_0011: Expected O, but got I
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_004c: Expected O, but got Unknown
			if ((object)bracketUnit != null)
			{
				object obj = (nint)0 + (nint)1360;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E32EDC");
				RectTransform rectTransform = default(RectTransform);
				if ((object)rectTransform != null)
				{
					object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 3512;
					Rect rect = rectTransform.rect;
					Vector2 result = (Vector2)obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal2 @ X0_v7 (UnityEngine.Vector2)+E4]");
					if ((nint)0 != 0)
					{
						return result;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					Vector2 result2 = default(Vector2);
					return result2;
				}
			}
			return (Vector2)new NullReferenceException();
		}
	}

	public void GenerateBrackets(int numberOfGames)
	{
		tournamentSize = numberOfGames;
		Clear();
		PrepareForFlattening();
		CreateBracketsTree();
		FlattenUnits();
	}

	public List<BracketUnit> GetBracketUnits()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00db: Expected O, but got I4
		//IL_0173: Expected O, but got I
		//IL_0183: Expected O, but got I
		//IL_01a5: Expected O, but got I4
		//IL_0052: Expected O, but got I4
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected O, but got Unknown
		//IL_0113: Expected O, but got I
		//IL_0124: Expected I, but got O
		//IL_0142: Expected O, but got I
		//IL_0082: Expected O, but got I
		object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 3336;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+B8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X8_v6+8]");
		Func<object, object> selector = (Func<object, object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X8_v6+8]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+E4]");
			bool flag3 = (nint)0 == 0;
			object obj6 = !flag3;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj7 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v12+B8]");
				obj4 = 0;
			}
			object obj8 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1344;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj9 = (nint)0 + (nint)1808;
			Func<object, object> func = default(Func<object, object>);
			func..ctor(obj4, (IntPtr)obj9);
			object obj10 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X8_v11+B8]");
			object obj11 = (nint)0 + (nint)8;
			obj11 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			selector = func;
		}
		IEnumerable<object> source = Enumerable.Select(bracketUnits, selector);
		return (List<BracketUnit>)(object)Enumerable.ToList(source);
	}

	public List<BracketLines> GetBracketLines()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00db: Expected O, but got I4
		//IL_0173: Expected O, but got I
		//IL_0183: Expected O, but got I
		//IL_01a5: Expected O, but got I4
		//IL_0052: Expected O, but got I4
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected O, but got Unknown
		//IL_0113: Expected O, but got I
		//IL_0124: Expected I, but got O
		//IL_0142: Expected O, but got I
		//IL_0082: Expected O, but got I
		object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 3336;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+B8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X8_v6+10]");
		Func<object, object> selector = (Func<object, object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X8_v6+10]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+E4]");
			bool flag3 = (nint)0 == 0;
			object obj6 = !flag3;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj7 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v12+B8]");
				obj4 = 0;
			}
			object obj8 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1336;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj9 = (nint)0 + (nint)1800;
			Func<object, object> func = default(Func<object, object>);
			func..ctor(obj4, (IntPtr)obj9);
			object obj10 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X8_v11+B8]");
			object obj11 = (nint)0 + (nint)16;
			obj11 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			selector = func;
		}
		IEnumerable<object> source = Enumerable.Select(_bracketLines, selector);
		return (List<BracketLines>)(object)Enumerable.ToList(source);
	}

	public void GenerateBrackets()
	{
		Clear();
		PrepareForFlattening();
		CreateBracketsTree();
		FlattenUnits();
	}

	private void PrepareForFlattening()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0102: Expected O, but got I
		//IL_0136: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_0189: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6BD3]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)360;
			GameObject gameObject = bracketUnit;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = obj4;
			GameObject gameObject2 = bracketUnit;
			if (!flag)
			{
				goto IL_00a5;
			}
		}
		else
		{
			_ = 1;
			object obj4 = (nint)0 + (nint)360;
			GameObject gameObject = bracketUnit;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v3+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			object obj6 = obj4;
			GameObject gameObject2 = bracketUnit;
			if (obj7 != null)
			{
				goto IL_00a5;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9A80");
		GameObject gameObject3 = default(GameObject);
		bool flag3 = (object)gameObject3 == null;
		object obj8 = !flag3;
		if (obj8 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00b4;
		IL_00a5:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9A80");
		goto IL_00b4;
		IL_00b4:
		Transform parent = gameObject3.transform;
		Transform root = gameObject3.transform;
		MakeGroup(parent, root);
		UnityEngine.Object.Destroy(gameObject3);
	}

	private unsafe void MakeGroup(Transform parent, Transform root)
	{
		//IL_0be1: Expected O, but got I
		//IL_0029: Expected O, but got I
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected O, but got Unknown
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Expected O, but got Unknown
		//IL_0171: Expected O, but got I4
		//IL_0181: Expected O, but got I
		//IL_01b3: Expected O, but got I4
		//IL_0c2a: Expected O, but got I4
		//IL_00a6: Expected O, but got I
		//IL_0297: Expected O, but got I4
		//IL_0231: Expected I, but got O
		//IL_0241: Expected O, but got I
		//IL_026f: Expected O, but got I
		//IL_0277: Expected O, but got I
		//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d9: Expected O, but got Unknown
		//IL_02fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ff: Expected I, but got Unknown
		//IL_0333: Expected I, but got O
		//IL_03c1: Expected O, but got I
		//IL_0d05: Expected O, but got I4
		//IL_0d0e: Expected O, but got I4
		//IL_0d17: Expected O, but got I4
		//IL_0474: Expected I, but got O
		//IL_061b: Expected O, but got I
		//IL_063f: Expected O, but got I4
		//IL_04be: Expected I, but got O
		//IL_0659: Expected O, but got I
		//IL_0674: Unknown result type (might be due to invalid IL or missing references)
		//IL_0679: Expected O, but got Unknown
		//IL_0693: Expected O, but got I4
		//IL_06bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c2: Expected O, but got Unknown
		//IL_06d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d6: Expected O, but got Unknown
		//IL_0594: Expected I, but got O
		//IL_072b: Expected O, but got I4
		//IL_0736: Expected O, but got I4
		//IL_0515: Unknown result type (might be due to invalid IL or missing references)
		//IL_051a: Expected O, but got Unknown
		//IL_052a: Expected I, but got O
		//IL_0568: Expected I, but got O
		//IL_074c: Expected I, but got O
		//IL_0d8b: Expected O, but got I
		//IL_0d9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da3: Expected O, but got Unknown
		//IL_0797: Expected O, but got I
		//IL_0ac3: Expected O, but got I4
		//IL_0ace: Expected O, but got I4
		//IL_0ad7: Expected O, but got I4
		//IL_0d45: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d4a: Expected O, but got Unknown
		//IL_0ec5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eca: Expected O, but got Unknown
		//IL_0838: Expected I, but got O
		//IL_0840: Unknown result type (might be due to invalid IL or missing references)
		//IL_0845: Expected O, but got Unknown
		//IL_084e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0853: Expected O, but got Unknown
		//IL_0e42: Expected O, but got I4
		//IL_0bf8: Expected O, but got I4
		//IL_0c03: Expected O, but got I4
		//IL_07ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b2: Expected O, but got Unknown
		//IL_07d8: Expected O, but got I
		//IL_0af4: Expected O, but got I
		//IL_088d: Expected I, but got O
		//IL_0970: Expected O, but got I4
		//IL_0e84: Expected O, but got I
		//IL_0b2f: Expected O, but got I
		//IL_08d8: Expected O, but got I
		//IL_070e: Expected I, but got O
		//IL_0dd3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dd8: Expected O, but got Unknown
		//IL_0baa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0baf: Expected O, but got Unknown
		//IL_09c3: Expected I, but got O
		//IL_09d3: Expected O, but got I
		//IL_09fc: Expected O, but got I4
		//IL_0a05: Expected I4, but got O
		//IL_097e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0983: Expected I, but got Unknown
		//IL_0990: Expected O, but got I
		//IL_0999: Unknown result type (might be due to invalid IL or missing references)
		//IL_099e: Expected O, but got Unknown
		//IL_0b3d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b42: Expected O, but got Unknown
		//IL_0b4b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b50: Expected O, but got Unknown
		//IL_0aa2: Expected O, but got I4
		//IL_0aad: Expected O, but got I4
		//IL_08ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f3: Expected O, but got Unknown
		//IL_0919: Expected O, but got I
		//IL_0a30: Expected O, but got I
		//IL_0a52: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a57: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6CD4]");
		nint num = 0;
		string objectName = GetObjectName(parent, root);
		bool flag = groups == null;
		Transform transform = root;
		Transform transform2 = root;
		string text = objectName;
		bool flag18 = default(bool);
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		object obj10;
		Transform transform6;
		Transform transform5 = default(Transform);
		if (!flag)
		{
			num = (nint)0 + (nint)2680;
			transform2 = (Transform)num;
			bool flag2 = ((Dictionary<object, object>)(object)groups).ContainsKey((object)objectName);
			Dictionary<object, object> dictionary = (Dictionary<object, object>)(object)groups;
			if (flag2)
			{
				bool flag3 = groups == null;
				transform = (Transform)(object)objectName;
				text = objectName;
				if (!flag3)
				{
					num = (nint)0 + (nint)2704;
					transform2 = (Transform)num;
					object obj = ((Dictionary<object, object>)(object)groups).get_Item((object)objectName);
					bool flag4 = obj == null;
					transform = (Transform)(object)objectName;
					text = objectName;
					if (!flag4)
					{
						Transform transform3 = ((GameObject)obj).transform;
						bool flag5 = (object)transform3 == null;
						transform = null;
						text = objectName;
						if (!flag5)
						{
							transform3.SetAsLastSibling();
							transform = null;
							goto IL_059e;
						}
					}
				}
			}
			else
			{
				object obj2 = typeof(SqlSingle[]) + 392;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
				object handle = typeof(IAsyncEnumerable<>) + 3032;
				object obj3 = 153100288 + 1024;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X8_v45+E0]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ X0_v75+E4]");
				num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ X0_v75+E4]");
				bool flag6 = (nint)0 == 0;
				object obj5 = !flag6;
				if (obj5 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)handle);
				Type[] array = default(Type[]);
				bool flag7 = array == null;
				transform = null;
				text = objectName;
				if (!flag7)
				{
					bool flag8 = (object)typeFromHandle == null;
					Transform transform4 = null;
					if (!flag8)
					{
						nint num2 = (nint)array;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v395 @ X8_v57 (Il2CppClass<System.Type[]>)+40]");
						transform4 = (Transform)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
						bool flag9 = ex == null;
						transform5 = null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v395 @ X8_v57 (Il2CppClass<System.Type[]>)+40]");
						transform = (Transform)0;
						transform6 = (Transform)num2;
						text = objectName;
						if (flag9)
						{
							goto IL_0c0e;
						}
					}
					transform6 = (Transform)array.Length;
					bool flag10 = array.Length == 0;
					transform5 = null;
					transform = transform4;
					text = objectName;
					if (flag10)
					{
						goto IL_0cdf;
					}
					object obj6 = array + 32;
					obj6 = typeFromHandle;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					num = (nint)(typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2096);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					GameObject gameObject = default(GameObject);
					gameObject..ctor(objectName, array);
					bool flag11 = dictionary == null;
					nint num3 = unchecked((nint)null);
					transform = (Transform)(object)objectName;
					transform2 = (Transform)(object)array;
					text = objectName;
					if (!flag11)
					{
						num = (nint)0 + (nint)2720;
						num3 = num;
						dictionary.set_Item((object)objectName, (object)gameObject);
						bool flag12 = groups == null;
						transform = (Transform)(object)objectName;
						transform2 = (Transform)(object)gameObject;
						text = objectName;
						if (!flag12)
						{
							dictionary = (Dictionary<object, object>)((nint)0 + (nint)2704);
							transform2 = (Transform)(object)dictionary;
							object obj7 = ((Dictionary<object, object>)(object)groups).get_Item((object)objectName);
							bool flag13 = obj7 == null;
							transform = (Transform)(object)objectName;
							text = objectName;
							if (!flag13)
							{
								Transform transform7 = ((GameObject)obj7).transform;
								bool flag14 = (object)transform7 == null;
								transform = null;
								text = objectName;
								if (!flag14)
								{
									transform = bracketsArea;
									transform7.SetParent(bracketsArea, worldPositionStays: false);
									bool flag15 = groups == null;
									num3 = unchecked((nint)null);
									transform2 = null;
									text = objectName;
									if (!flag15)
									{
										transform2 = (Transform)(object)dictionary;
										object obj8 = ((Dictionary<object, object>)(object)groups).get_Item((object)objectName);
										bool flag16 = obj8 == null;
										num3 = unchecked((nint)null);
										transform = (Transform)(object)objectName;
										text = objectName;
										if (!flag16)
										{
											Transform transform8 = ((GameObject)obj8).transform;
											if ((object)transform8 != null)
											{
												object obj9 = typeof(System.Buffers.Text.ParserHelpers) + 3600;
												obj10 = obj9;
												num = (nint)transform8;
												object obj11 = (object)transform8 - obj9;
												bool flag17 = obj11 == null;
												flag18 = transform8 != obj9;
												transform5 = null;
												num3 = unchecked((nint)null);
												transform6 = transform8;
												text = objectName;
												if (flag18)
												{
													goto IL_0c2f;
												}
											}
											UIExtensions.MaximizeInParent((RectTransform)transform8);
											num3 = unchecked((nint)null);
											transform = null;
											goto IL_059e;
										}
									}
								}
							}
						}
					}
				}
			}
		}
		goto IL_0bbd;
		IL_059e:
		bool flag19 = (object)parent == null;
		text = objectName;
		Transform transform10 = default(Transform);
		object obj12;
		object obj13;
		if (!flag19)
		{
			if (parent.childCount == 0)
			{
				return;
			}
			GameObject gameObject2 = parent.gameObject;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6CD6]");
			num = 0;
			bool flag20 = (object)gameObject2 == null;
			obj12 = 0;
			obj13 = 0;
			Dictionary<object, object> dictionary = (Dictionary<object, object>)152985600;
			transform = null;
			text = (string)(object)gameObject2;
			if (!flag20)
			{
				object obj14 = (nint)0 + (nint)1808;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E3438C");
				object obj15 = default(object);
				bool flag21 = obj15 == null;
				object obj16 = !flag21;
				if (obj16 != null)
				{
					return;
				}
				object obj17 = (nint)0 + (nint)1744;
				transform2 = (Transform)obj17;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E3438C");
				object obj19 = default(object);
				object obj18 = obj19 & 1;
				bool flag22 = obj18 == null;
				object obj20 = !flag22;
				if (obj20 != null)
				{
					return;
				}
				IEnumerator enumerator = parent.GetEnumerator();
				text = (string)(typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528);
				dictionary = (Dictionary<object, object>)(typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1952);
				transform = null;
				object obj21 = default(object);
				num = (nint)(&obj21);
				object obj25 = default(object);
				object obj27 = default(object);
				object obj33 = default(object);
				object obj39 = default(object);
				Transform transform9 = default(Transform);
				while (true)
				{
					bool flag23 = (object)transform5 == null;
					obj12 = 0;
					obj13 = 0;
					if (flag23)
					{
						break;
					}
					nint num4 = (nint)transform5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v803 @ X8_v30 (Il2CppClass<UnityEngine.Transform>)+12E]");
					nint num5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v803 @ X8_v30 (Il2CppClass<UnityEngine.Transform>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_081c;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v803 @ X8_v30 (Il2CppClass<UnityEngine.Transform>)+B0]");
					object obj22 = (nint)0 + (nint)8;
					bool flag24 = flag18;
					object obj23;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v837 @ X10_v29-8]");
						object obj11 = 0 - text;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v837 @ X10_v29-8]");
						if (0 == (nint)text)
						{
							break;
						}
						obj23 = obj22 + 16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v803 @ X8_v30 (Il2CppClass<UnityEngine.Transform>)+12E]");
						num5 = -1;
						obj11 = num5 - 1;
						bool flag17 = obj11 == null;
						flag18 = num5 != 1;
						obj22 = obj23;
						flag24 = flag18;
						if (flag18)
						{
							continue;
						}
						goto IL_081c;
					}
					num5 = (nint)obj22;
					object obj24 = num4 + obj22;
					obj25 = obj24 + 312;
					obj23 = obj22;
					flag18 = flag24;
					goto IL_0d73;
					IL_0d73:
					transform6 = (Transform)obj25;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v865 @ X0_v51+8]");
					transform = (Transform)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v865 @ X0_v51] (should have been resolved before IL gen)");
					object obj26 = obj27 & 1;
					if (obj26 != null)
					{
						if ((object)transform5 == null)
						{
							goto IL_0be6;
						}
						nint num6 = (nint)transform5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v870 @ X8_v33 (Il2CppClass<UnityEngine.Transform>)+12E]");
						num5 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v870 @ X8_v33 (Il2CppClass<UnityEngine.Transform>)+12E]");
						if ((nint)0 == 0)
						{
							goto IL_095d;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v870 @ X8_v33 (Il2CppClass<UnityEngine.Transform>)+B0]");
						object obj28 = (nint)0 + (nint)8;
						bool flag25 = flag18;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v903 @ X10_v24-8]");
							object obj11 = 0 - text;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v903 @ X10_v24-8]");
							if (0 == (nint)text)
							{
								break;
							}
							obj23 = obj28 + 16;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v870 @ X8_v33 (Il2CppClass<UnityEngine.Transform>)+12E]");
							num5 = -1;
							obj11 = num5 - 1;
							bool flag17 = obj11 == null;
							flag18 = num5 != 1;
							obj28 = obj23;
							flag25 = flag18;
							if (flag18)
							{
								continue;
							}
							goto IL_095d;
						}
						num5 = (nint)(obj28 + 1);
						object obj29 = num6 + num5;
						object obj30 = obj29 + 312;
						obj23 = obj28;
						flag18 = flag25;
						goto IL_0e01;
					}
					obj12 = 0;
					obj13 = 0;
					object obj31 = 0;
					while (true)
					{
						object obj32 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
						obj10 = obj32;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
						if (obj33 == null)
						{
							goto IL_0e28;
						}
						object obj34 = obj33;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v693 @ X8_v5+12E]");
						object obj35 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v693 @ X8_v5+12E]");
						if ((nint)0 == 0)
						{
							goto IL_0b78;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v693 @ X8_v5+B0]");
						object obj36 = (nint)0 + (nint)8;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v749 @ X10_v7-8]");
							if (0 == (nint)obj32)
							{
								break;
							}
							obj23 = obj36 + 16;
							obj35--;
							bool flag26 = (nint)obj35 != 1;
							obj36 = obj23;
							if (flag26)
							{
								continue;
							}
							goto IL_0b78;
						}
						object obj37 = obj34 + obj36;
						transform6 = (Transform)(obj37 + 312);
						obj23 = obj36;
						goto IL_0e74;
						IL_0e28:
						bool flag27 = obj31 == null;
						object obj38 = !flag27;
						if (obj38 == null)
						{
							return;
						}
						OutOfMemoryException ex2 = new OutOfMemoryException();
						if ((nint)obj10 != 1)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
						obj31 = obj39;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
						obj13 = obj39;
						continue;
						IL_0b78:
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
						transform2 = null;
						transform6 = transform9;
						goto IL_0e74;
						IL_0e74:
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ X8_v4 (UnityEngine.Transform)+8]");
						obj10 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v510 @ X8_v4 (UnityEngine.Transform)] (should have been resolved before IL gen)");
						goto IL_0e28;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99B68");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
					return;
					IL_06e8:
					MakeGroup(transform10, root);
					transform = transform10;
					transform2 = root;
					num = (nint)transform10;
					continue;
					IL_095d:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
					transform2 = (Transform)1;
					goto IL_0e01;
					IL_0e01:
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v940 @ X0_v55] (should have been resolved before IL gen)");
					if ((object)transform10 == null)
					{
						goto IL_06e8;
					}
					transform = (Transform)(object)dictionary;
					nint num7 = (nint)transform10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ X1_v10 (UnityEngine.Transform)+130]");
					obj23 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X9_v23 (Il2CppClass<UnityEngine.Transform>)+130]");
					nint num8 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ X1_v10 (UnityEngine.Transform)+130]");
					bool flag28 = num8 < 0;
					object obj40 = !flag28;
					flag18 = (byte)(int)(~obj40) != 0;
					if (!flag18)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X9_v23 (Il2CppClass<UnityEngine.Transform>)+C8]");
						nint num9 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ X1_v10 (UnityEngine.Transform)+130]");
						object obj41 = num9 + 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v967 @ X9_v25-8]");
						num5 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v967 @ X9_v25-8]");
						object obj11 = 0 - transform;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v967 @ X9_v25-8]");
						bool flag17 = 0 == (nint)transform;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v967 @ X9_v25-8]");
						num7 = 0;
						if (flag17)
						{
							goto IL_06e8;
						}
					}
					goto IL_0a90;
					IL_081c:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
					transform2 = null;
					goto IL_0d73;
				}
				goto IL_0bd0;
			}
		}
		goto IL_0bbd;
		IL_0cdf:
		ex = new IndexOutOfRangeException();
		goto IL_0c0e;
		IL_0c2f:
		throw new InvalidCastException();
		IL_0c0e:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		OutOfMemoryException ex3 = new OutOfMemoryException();
		obj10 = 0;
		goto IL_0c2f;
		IL_0bd0:
		NullReferenceException ex4 = new NullReferenceException();
		transform6 = (Transform)num;
		goto IL_0cdf;
		IL_0a90:
		InvalidCastException ex5 = new InvalidCastException();
		obj12 = 0;
		obj13 = 0;
		transform6 = transform10;
		goto IL_0cdf;
		IL_0bbd:
		NullReferenceException ex6 = new NullReferenceException();
		transform5 = null;
		goto IL_0bd0;
		IL_0be6:
		NullReferenceException ex7 = new NullReferenceException();
		obj12 = 0;
		obj13 = 0;
		goto IL_0cdf;
	}

	private void FlattenUnits()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_004e: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2096;
		object obj2 = (nint)0 + (nint)728;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		((List<object>)(object)bracketUnits).ForEach(action);
	}

	private void Flatten(GameObject unit)
	{
		Transform root = unit.transform;
		Flatten(unit, root);
	}

	private void Flatten(GameObject unit, Transform root)
	{
		//IL_003c: Expected O, but got I
		//IL_0061: Expected O, but got I4
		//IL_007b: Expected O, but got I
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_00ae: Expected O, but got I4
		GameObject gameObject = base.gameObject;
		if (!gameObject.activeSelf)
		{
			return;
		}
		object obj = (nint)0 + (nint)1808;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E3438C");
		object obj2 = default(object);
		bool flag = obj2 == null;
		object obj3 = !flag;
		if (obj3 == null)
		{
			object obj4 = (nint)0 + (nint)1744;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E3438C");
			object obj6 = default(object);
			object obj5 = obj6 & 1;
			bool flag2 = obj5 == null;
			object obj7 = !flag2;
			if (obj7 == null)
			{
				Transform transform = unit.transform;
				int childCount = transform.childCount;
				if (childCount >= 1)
				{
					int num = childCount;
					do
					{
						Transform transform2 = unit.transform;
						num--;
						Transform child = transform2.GetChild(num);
						GameObject unit2 = child.gameObject;
						Flatten(unit2, root);
					}
					while (num > 0);
				}
			}
		}
		Transform obj8 = unit.transform;
		string objectName = GetObjectName(obj8, root);
		if (((Dictionary<object, object>)(object)groups).ContainsKey((object)objectName))
		{
			Transform transform3 = unit.transform;
			object obj9 = ((Dictionary<object, object>)(object)groups).get_Item((object)objectName);
			Transform parent = ((GameObject)obj9).transform;
			transform3.SetParent(parent);
		}
	}

	private static bool CanComponentBeSplit(GameObject unit)
	{
		//IL_0083: Expected I4, but got O
		//IL_0011: Expected O, but got I
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0058: Expected O, but got I
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected I4, but got Unknown
		if ((object)unit != null)
		{
			object obj = (nint)0 + (nint)1808;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E3438C");
			object obj3 = default(object);
			object obj2 = obj3 & 1;
			if (obj2 != null)
			{
				return false;
			}
			object obj4 = (nint)0 + (nint)1744;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E3438C");
			object obj5 = default(object);
			return (byte)(obj5 ^ 1) != 0;
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	private static string GetObjectName(Transform obj, Transform root)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0039: Expected O, but got I4
		//IL_0041: Expected I4, but got O
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected O, but got Unknown
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Expected O, but got Unknown
		//IL_014f: Expected O, but got I
		//IL_0179: Expected O, but got I4
		//IL_00ae: Expected O, but got I4
		Transform current = default(Transform);
		Transform root2 = default(Transform);
		string path = UIExtensions.GetPath(current, root2);
		if (path != null)
		{
			object obj2 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 1240;
			bool flag = path.StartsWith((string)obj2);
			bool flag2 = !flag;
			object obj3 = 0;
			int num = (int)obj2;
			string input = path;
			if (!flag2)
			{
				object obj4 = obj2;
				if (obj2 == null)
				{
					goto IL_00e4;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v8+10]");
				num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v8+10]");
				string text = path.Substring(0);
				obj3 = 0;
				input = text;
			}
			object obj5 = typeof(System.Buffers.Text.ParserHelpers) + 3920;
			object pattern = "[{0}]:{1}" + 192;
			object replacement = (nint)0 + (nint)2000;
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v7+E4]");
			bool flag3 = (nint)0 == 0;
			object obj7 = !flag3;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			return Regex.Replace(input, (string)pattern, (string)replacement);
		}
		goto IL_00e4;
		IL_00e4:
		return (string)(object)new NullReferenceException();
	}

	public void ScrollToRound(int round)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00f0: Expected O, but got I4
		//IL_0080: Invalid comparison between F8 and I8
		//IL_00c1: Expected I4, but got F8
		//IL_00a4: Expected I4, but got I8
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		double y = 1.0 - (double)round;
		double num = Math.Pow(2.0, y);
		double num2 = 1.0 - num;
		double num3 = num2 * (double)tournamentSize;
		int matchId;
		if (num3 == 9.218868437227405E+18)
		{
			matchId = -2147483647;
		}
		else
		{
			double num4 = num3 + 1.0;
			matchId = (int)num4;
		}
		ScrollToMatch(matchId, highlight: false);
	}

	public void ScrollToMatch(int matchId, bool highlight = true)
	{
		//IL_0011: Expected O, but got I
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected O, but got Unknown
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		//IL_0104: Expected O, but got I4
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected O, but got Unknown
		//IL_047c: Expected O, but got I4
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Expected O, but got Unknown
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Expected O, but got Unknown
		//IL_0278: Expected O, but got I4
		//IL_02be: Invalid comparison between F4 and I4
		//IL_0237: Expected O, but got I4
		//IL_0365: Unknown result type (might be due to invalid IL or missing references)
		//IL_036a: Expected O, but got Unknown
		//IL_04a2: Expected O, but got I
		//IL_04de: Expected O, but got I4
		object obj = (nint)0 + (nint)2592;
		int index = matchId - 1;
		object obj2 = obj;
		object obj3 = ((List<object>)(object)bracketUnits).get_Item(index);
		Transform transform = ((GameObject)obj3).transform;
		object obj4 = typeof(System.Buffers.Text.ParserHelpers) + 3600;
		if (transform == obj4)
		{
			Vector2 anchoredPosition = ((RectTransform)transform).anchoredPosition;
			RectTransform rectTransform = UIExtensions.parent(bracketsArea);
			Rect rect = rectTransform.rect;
			object obj5 = typeof(System.Buffers.Text.ParserHelpers) + 3512;
			Vector2 sizeDelta = bracketsArea.sizeDelta;
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X0_v17+E4]");
			bool flag = (nint)0 == 0;
			object obj7 = !flag;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj8 = default(object);
			double num = (double)obj8 * -0.5;
			double num2 = num - (double)obj8;
			object obj9 = default(object);
			double num3 = (double)obj9 * 0.5;
			double num4 = num3 + num2;
			object obj10 = default(object);
			double num5 = (double)obj10 * 0.5;
			double num6 = num5 - (double)obj10;
			object obj11 = default(object);
			double num7 = (double)obj11 * -0.5;
			double num8 = num6 + num7;
			float min = (float)obj9 - (float)obj8;
			float num9 = FloatExtensions.EnsureRange((float)num4, min, 0f);
			float num10 = (float)obj10 - (float)obj11;
			float num11 = FloatExtensions.EnsureRange((float)num8, 0f, num10);
			Vector2 anchoredPosition2 = bracketsArea.anchoredPosition;
			object obj12 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
			object obj13 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ X0_v24+E4]");
			bool flag2 = (nint)0 == 0;
			object obj14 = !flag2;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj15 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
			float num12 = 0f - num11;
			float num13 = num11 - num9;
			float num14 = num13 * num13;
			float num15 = num12 * num12;
			float num16 = num14 + num15;
			transform.SetAsLastSibling();
			object obj16 = this + 104;
			bool flag3 = obj16 == null;
			bool flag4 = false;
			if (!flag3)
			{
				bool flag5 = TweenExtensions.IsActive((Tween)obj16);
				bool flag6 = !flag5;
				flag4 = false;
				if (!flag6)
				{
					TweenExtensions.Kill((Tween)obj16, highlight);
					obj2 = 0;
					flag4 = highlight;
				}
			}
			object obj17 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v348 @ X0_v29+E4]");
			bool flag7 = (nint)0 == 0;
			object obj18 = !flag7;
			if (obj18 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Sequence sequence = DOTween.Sequence();
			obj16 = sequence;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			if (num16 > 1.1255153E+09f)
			{
				TweenerCore<Vector2, Vector2, VectorOptions> t = DOTweenModuleUI.DOAnchorPosX(bracketsArea, num9, 0.3f);
				Sequence s = TweenSettingsExtensions.Append(_navigationSequence, t);
				TweenerCore<Vector2, Vector2, VectorOptions> t2 = DOTweenModuleUI.DOAnchorPosY(bracketsArea, num11, 0.3f);
				Sequence sequence2 = TweenSettingsExtensions.Append(s, t2);
			}
			if (highlight)
			{
				object obj19 = typeof(UsageHint) + 816;
				object obj20 = obj19;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v403 @ X8_v19+B8]");
				object obj21 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ X8_v20+C]");
				float duration = 0f * num10;
				float elasticity = default(float);
				Tweener t3 = ShortcutExtensions.DOPunchScale(transform, (Vector3)4, duration, 0, elasticity);
				Sequence sequence3 = TweenSettingsExtensions.Append((Sequence)obj16, t3);
			}
			return;
		}
		throw new InvalidCastException();
	}

	private void Clear()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_01e6: Expected I, but got O
		//IL_0031: Expected O, but got I
		//IL_005d: Expected I, but got O
		//IL_0082: Expected O, but got I
		//IL_00af: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2096;
		object obj2 = (nint)0 + (nint)1120;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)null, (IntPtr)obj2);
		object obj3 = (nint)0 + (nint)2560;
		((List<object>)(object)bracketUnits).ForEach(action);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)null, (IntPtr)obj2);
		((List<object>)(object)_bracketLines).ForEach(action2);
		object obj4 = (nint)0 + (nint)2712;
		Dictionary<object, object>.ValueCollection values = ((Dictionary<object, object>)(object)groups).Values;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action3 = default(Action<object>);
		action3..ctor((object)null, (IntPtr)obj2);
		ArraysExtensions.ForEach(values, action3);
		List<GameObject> list = bracketUnits;
		int version = list._version + 1;
		list._size = 0;
		list._version = version;
		if (list._size >= 1)
		{
			Array.Clear(list._items, 0, list._size);
		}
		List<GameObject> list2 = _bracketLines;
		int version2 = list2._version + 1;
		list2._size = 0;
		list2._version = version2;
		if (list2._size >= 1)
		{
			Array.Clear(list2._items, 0, list2._size);
		}
		((Dictionary<object, object>)(object)groups).Clear();
	}

	private unsafe void CreateBracketsTree()
	{
		//IL_0015: Expected O, but got I4
		//IL_0044: Expected I, but got O
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		//IL_010e: Expected O, but got I4
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Expected O, but got Unknown
		//IL_070d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0712: Expected O, but got Unknown
		//IL_0259: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Expected O, but got Unknown
		//IL_0274: Expected O, but got I
		//IL_028e: Expected O, but got I4
		//IL_0297: Expected O, but got I4
		//IL_077d: Expected O, but got I4
		//IL_019f: Expected I4, but got O
		//IL_01a4: Expected I, but got O
		//IL_04c4: Invalid comparison between F8 and I4
		//IL_04d5: Expected O, but got I4
		//IL_02d6: Expected O, but got I4
		//IL_01bf: Expected O, but got I
		//IL_0504: Invalid comparison between F8 and I4
		//IL_0512: Unknown result type (might be due to invalid IL or missing references)
		//IL_0517: Expected I4, but got Unknown
		//IL_051f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0524: Expected I4, but got Unknown
		//IL_058e: Expected O, but got I
		//IL_05b7: Expected F8, but got I4
		//IL_01ed: Expected F8, but got I4
		//IL_0374: Invalid comparison between F8 and I8
		//IL_05f7: Expected F8, but got I4
		//IL_07b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07bc: Expected O, but got Unknown
		//IL_0398: Expected F8, but got I8
		//IL_03c0: Expected O, but got I
		//IL_03da: Expected O, but got I4
		//IL_03ed: Expected F8, but got I4
		//IL_03f5: Expected I4, but got F8
		//IL_0410: Expected F8, but got I4
		//IL_0428: Expected I4, but got F8
		Vector2 bracketAreaSize = GetBracketAreaSize();
		int num = default(int);
		List<Vector2>.Enumerator enumerator2 = default(List<Vector2>.Enumerator);
		nint num2 = default(nint);
		double num7 = default(double);
		double num4 = default(double);
		if ((object)bracketsArea != null)
		{
			bracketsArea.sizeDelta = (Vector2)0;
			num = tournamentSize;
			Vector2 bracketUnitRectSize = BracketUnitRectSize;
			bool flag = (object)bracketsArea == null;
			num2 = unchecked((nint)null);
			if (!flag)
			{
				object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 3344;
				Vector2 sizeDelta = bracketsArea.sizeDelta;
				double num3 = num4 * 0.5;
				double num5 = (double)margin - num3;
				double num6 = num7 * 0.5;
				double num8 = num6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BracketGenerator)+48]");
				double num9 = num8 - 0.0;
				num7 = num4 * 0.5;
				double num10 = num7 + num5;
				Vector2 bracketUnitRectSize2 = BracketUnitRectSize;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj2 = num + num;
				object obj3 = obj2 >> 1;
				object obj4 = typeof(List<Tween>) + 264;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				List<Vector2> list = default(List<Vector2>);
				list..ctor();
				object obj6 = default(object);
				object obj5 = obj6 + 16;
				obj5 = list;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				_ = 1;
				obj6..ctor();
				_ = spacing;
				((KickOffTree)obj6).CreateColumn();
				bool flag2 = obj5 == null;
				num4 = num5;
				double num11 = 0.5;
				num = (int)list;
				num2 = unchecked((nint)null);
				if (!flag2)
				{
					object pos = (nint)0 + (nint)3120;
					List<Vector2>.Enumerator enumerator = ((List<Vector2>)obj5).GetEnumerator();
					double num12 = default(double);
					while (enumerator2.MoveNext())
					{
						CreateBracketUnit((Vector2)pos);
						num7 = num12;
						num5 = 0.0;
					}
					enumerator2.Dispose();
					num4 = num5;
					num11 = 0.5;
					goto IL_0215;
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		bool flag3 = num2 != 1;
		NullReferenceException ex2 = ex;
		if (!flag3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			num2 = ((int*)num)->m_value;
			enumerator2.Dispose();
			object obj7 = default(object);
			if (obj7 == null)
			{
				goto IL_0215;
			}
			OutOfMemoryException ex3 = new OutOfMemoryException();
			object obj8 = obj7;
			ex2 = (NullReferenceException)(object)ex3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22390BC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return;
		IL_0753:
		object obj10;
		double num14;
		double num15;
		int num18;
		int num25;
		double num26;
		object obj15;
		object obj16;
		int numberOfRounds;
		int num27;
		double num28;
		int num29;
		int num31;
		while (true)
		{
			object obj9 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v456 @ X0_v24+E4]");
			bool flag4 = (nint)0 == 0;
			object obj11 = !flag4;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			double num13 = Math.Pow(2.0, num14);
			num15 = (double)tournamentSize / num13;
			double num16 = num15 - 9.218868437227405E+18;
			bool flag5 = num16 == 0.0;
			object obj12 = !flag5;
			object obj13 = ~obj12;
			bool flag6;
			bool flag7;
			if (obj13 == null)
			{
				double num17 = (double)num18 - num15;
				flag6 = num17 < 0.0;
				int num19 = num18 ^ num15;
				int num20 = num18 ^ num17;
				int num21 = num19 & num20;
				flag7 = num21 < 0;
			}
			else
			{
				flag7 = false;
				flag6 = false;
			}
			if (flag6 == flag7)
			{
				object obj14 = obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v517 @ X0_v30+E4]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				double num22 = Math.Pow(2.0, num14);
				num15 = (double)tournamentSize / num22;
				double num23 = ((num15 != 9.218868437227405E+18) ? num15 : 2147483648.0);
				double num24 = num23 + (double)num25;
				num26 = num14 + 1.0;
				obj15 = obj16 + 1;
				if ((nint)obj15 != numberOfRounds)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6CD9]");
					object obj17 = (nint)0 & (nint)1;
					bool flag8 = obj17 == null;
					object obj18 = !flag8;
					num27 = 0;
					num28 = tournamentSize;
					num29 = (int)num24;
					obj16 = obj15;
					num18 = 0;
					num7 = tournamentSize;
					num4 = num15;
					num14 = num26;
					num25 = (int)num24;
					if (obj18 == null)
					{
						break;
					}
					continue;
				}
				goto IL_0620;
			}
			CreateBracketLines(num18, num25);
			num27 = num18 + 2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6CD9]");
			object obj19 = (nint)0 & (nint)1;
			bool flag9 = obj19 == null;
			int num30 = num25;
			obj15 = obj16;
			num28 = tournamentSize;
			num26 = num14;
			num29 = num25;
			num31 = num18;
			if (flag9)
			{
				break;
			}
			num30 = num25;
			num18 = num27;
			num7 = tournamentSize;
			num4 = num15;
			num31 = num27;
		}
		goto IL_0436;
		IL_0215:
		numberOfRounds = TournamentMath.GetNumberOfRounds(tournamentSize);
		bool flag10 = numberOfRounds < 2;
		num31 = 0;
		if (flag10)
		{
			goto IL_0620;
		}
		obj10 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6CD9]");
		object obj20 = (nint)0 & (nint)1;
		bool flag11 = obj20 == null;
		object obj21 = !flag11;
		obj16 = 1;
		num18 = 0;
		num14 = 1.0;
		num25 = 0;
		num31 = 0;
		if (obj21 == null)
		{
			obj15 = 1;
			num27 = 0;
			num28 = num7;
			num15 = num4;
			num26 = 1.0;
			num29 = 0;
			num31 = 0;
			goto IL_0436;
		}
		goto IL_0753;
		IL_0436:
		_ = 1;
		obj16 = obj15;
		num18 = num27;
		num7 = num28;
		num4 = num15;
		num14 = num26;
		num25 = num29;
		goto IL_0753;
		IL_0620:
		EmphasizeLastMatch();
	}

	private void EmphasizeLastMatch()
	{
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected O, but got Unknown
		//IL_00a9: Expected O, but got I
		//IL_00c9: Expected O, but got I
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected O, but got Unknown
		//IL_00ec: Expected O, but got I4
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_0135: Expected O, but got I4
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Expected O, but got Unknown
		//IL_01c2: Expected O, but got I4
		object obj = Enumerable.Last((IEnumerable<object>)bracketUnits);
		Transform transform = ((GameObject)obj).transform;
		if ((object)transform != null)
		{
			object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 3600;
			if (transform != obj2)
			{
				throw new InvalidCastException();
			}
		}
		object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 3512;
		object obj4 = typeof(UsageHint) + 816;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X8_v10+B8]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X8_v11+14]");
		object obj7 = (nint)0 * (nint)1067869798;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X8_v11+C]");
		object obj9 = default(object);
		object obj8 = 0 * obj9;
		transform.localScale = (Vector3)0;
		Vector2 anchoredPosition = ((RectTransform)transform).anchoredPosition;
		Rect rect = ((RectTransform)transform).rect;
		object obj10 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X0_v16+E4]");
		bool flag = (nint)0 == 0;
		object obj11 = !flag;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj12 = obj7 * 1050253722;
		double num = (double)obj12 * 0.5;
		float value = (float)obj8 + (float)num;
		float? x = value;
		UIExtensions.MoveTo((RectTransform)transform, isWorldPositions: false, x, (float?)(object)0);
	}

	private Vector2 GetBracketAreaSize()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0050: Expected O, but got I4
		RectTransform rectTransform = UIExtensions.parent(bracketsArea);
		if ((object)rectTransform != null)
		{
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 3512;
			Rect rect = rectTransform.rect;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v6+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Vector2 bracketUnitRectSize = BracketUnitRectSize;
			Vector2 bracketUnitRectSize2 = BracketUnitRectSize;
			int numberOfRounds = TournamentMath.GetNumberOfRounds(tournamentSize);
			return BracketUnitRectSize;
		}
		return (Vector2)new NullReferenceException();
	}

	private Vector2 GetStartingPoint()
	{
		Vector2 bracketUnitRectSize = BracketUnitRectSize;
		if ((object)bracketsArea != null)
		{
			return bracketsArea.sizeDelta;
		}
		return (Vector2)new NullReferenceException();
	}

	private Vector2 GetCorner()
	{
		if ((object)bracketsArea != null)
		{
			return bracketsArea.sizeDelta;
		}
		return (Vector2)new NullReferenceException();
	}

	private void CreateBracketUnit(Vector2 pos)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_01ed: Expected O, but got I
		//IL_0217: Expected O, but got I4
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		//IL_00ba: Expected O, but got I4
		//IL_0154: Expected O, but got I4
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Expected O, but got Unknown
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Expected O, but got Unknown
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = (nint)0 + (nint)544;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9D50");
		GameObject gameObject = default(GameObject);
		if ((object)gameObject != null)
		{
			Transform transform = gameObject.transform;
			if ((object)transform != null)
			{
				object obj5 = typeof(System.Buffers.Text.ParserHelpers) + 3600;
				if (transform != obj5)
				{
					goto IL_01da;
				}
				((RectTransform)transform).anchoredPosition = (Vector2)0;
				List<object> list = (List<object>)(object)bracketUnits;
				if (bracketUnits != null)
				{
					int version = list._version + 1;
					list._version = version;
					object[] items = list._items;
					if (list._items != null)
					{
						bool flag2 = list._size < items.Length;
						object obj6 = !flag2;
						if (obj6 == null)
						{
							int size = list._size + 1;
							list._size = size;
							object obj7 = list._items + list._size;
							object obj8 = obj7 + 32;
							obj8 = gameObject;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						}
						else
						{
							((List<object>)(object)bracketUnits).AddWithResize((object)gameObject);
						}
						return;
					}
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_01da;
		IL_01da:
		throw new InvalidCastException();
	}

	private void DrawColumnBrackets(int column, int gamesDoneDrawing)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_0044: Expected O, but got I4
		//IL_025d: Expected O, but got I4
		//IL_00e2: Expected F8, but got I4
		//IL_0114: Invalid comparison between F8 and I4
		//IL_0125: Expected O, but got I4
		//IL_0154: Invalid comparison between F8 and I4
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Expected I4, but got Unknown
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Expected I4, but got Unknown
		//IL_01de: Expected O, but got I
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6CD9]");
		object obj2 = (nint)0 & (nint)1;
		bool flag = obj2 == null;
		object obj3 = !flag;
		int num = column;
		int num2 = 0;
		int num4 = default(int);
		int num3 = num4;
		int num5 = column;
		int num7 = default(int);
		int num6 = num7;
		double num9 = default(double);
		double num8 = num9;
		int num10 = 0;
		if (obj3 == null)
		{
			goto IL_008c;
		}
		goto IL_0233;
		IL_008c:
		_ = 1;
		num3 = num4;
		num5 = num;
		num6 = tournamentSize;
		num8 = num9;
		num10 = num2;
		goto IL_0233;
		IL_0233:
		while (true)
		{
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X0_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			double num11 = Math.Pow(2.0, column);
			num9 = (double)tournamentSize / num11;
			double num12 = num9 - 9.218868437227405E+18;
			bool flag3 = num12 == 0.0;
			object obj6 = !flag3;
			object obj7 = ~obj6;
			bool flag4;
			bool flag5;
			if (obj7 == null)
			{
				double num13 = (double)num10 - num9;
				flag4 = num13 < 0.0;
				int num14 = num10 ^ num9;
				int num15 = num10 ^ num13;
				int num16 = num14 & num15;
				flag5 = num16 < 0;
			}
			else
			{
				flag5 = false;
				flag4 = false;
			}
			if (flag4 != flag5)
			{
				CreateBracketLines(num10, num4);
				num2 = num10 + 2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6CD9]");
				object obj8 = (nint)0 & (nint)1;
				bool flag6 = obj8 == null;
				num = num10;
				if (flag6)
				{
					break;
				}
				num3 = num4;
				num5 = num10;
				num6 = tournamentSize;
				num8 = num9;
				num10 = num2;
				continue;
			}
			return;
		}
		goto IL_008c;
	}

	private void CreateBracketLines(int GameNumberInColumn, int gamesDoneDrawing)
	{
		//IL_006f: Expected O, but got I
		//IL_008f: Expected O, but got I4
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected O, but got Unknown
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected O, but got Unknown
		//IL_0153: Expected O, but got I4
		//IL_019c: Expected O, but got I4
		//IL_01ed: Expected O, but got I4
		RectTransform rectTransform = CreateEmptyLinesHolder();
		rectTransform.SetSiblingIndex(0);
		List<object> list = (List<object>)(object)_bracketLines;
		GameObject gameObject = rectTransform.gameObject;
		int version = list._version + 1;
		list._version = version;
		object[] items = list._items;
		object obj = (nint)0 + (nint)3632;
		bool flag = list._size < items.Length;
		object obj2 = !flag;
		if (obj2 == null)
		{
			int size = list._size + 1;
			list._size = size;
			object obj3 = items + list._size;
			object obj4 = obj3 + 32;
			obj4 = gameObject;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		else
		{
			list.AddWithResize((object)gameObject);
		}
		int bracket = gamesDoneDrawing + GameNumberInColumn;
		float num = OffsetMaxX(bracket);
		int bracket2 = gamesDoneDrawing + GameNumberInColumn;
		float num2 = OffsetMaxY(bracket2);
		rectTransform.offsetMin = (Vector2)0;
		int bracket3 = gamesDoneDrawing + GameNumberInColumn;
		float num3 = OffsetMinX(bracket3);
		int bracket4 = gamesDoneDrawing + GameNumberInColumn;
		float num4 = OffsetMinY(bracket4);
		rectTransform.offsetMax = (Vector2)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		BracketLines bracketLines = default(BracketLines);
		bracketLines.DrawLines(bracketLine_prefab, bracketsArea, lineThickness);
		rectTransform.anchoredPosition = (Vector2)0;
	}

	private RectTransform CreateEmptyLinesHolder()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0084: Expected O, but got I
		//IL_00ae: Expected O, but got I4
		//IL_005b: Expected O, but got I
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = (nint)0 + (nint)544;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9D50");
		object obj5 = default(object);
		if (obj5 != null)
		{
			object obj6 = (nint)0 + (nint)1360;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E32EDC");
			RectTransform result = default(RectTransform);
			return result;
		}
		return (RectTransform)(object)new NullReferenceException();
	}

	private float OffsetMinX(int bracket)
	{
		//IL_0009: Expected O, but got I4
		//IL_001f: Expected O, but got I
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Expected O, but got Unknown
		//IL_017a: Expected O, but got I
		//IL_0194: Expected O, but got I4
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		//IL_0070: Expected O, but got I
		//IL_01ee: Expected O, but got I4
		//IL_011d: Expected O, but got I4
		//IL_028b: Expected O, but got F4
		//IL_0298: Invalid comparison between F4 and I8
		//IL_0315: Unknown result type (might be due to invalid IL or missing references)
		//IL_031a: Expected O, but got Unknown
		//IL_0323: Unknown result type (might be due to invalid IL or missing references)
		//IL_0328: Expected O, but got Unknown
		//IL_0343: Expected I4, but got O
		//IL_02b8: Expected O, but got I4
		//IL_02c9: Expected O, but got I
		object obj = 152985600;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6CD8]");
		object obj2 = (nint)0 & (nint)1;
		List<GameObject> list;
		object obj3;
		object obj5;
		List<GameObject> list2;
		if (obj2 != null)
		{
			list = bracketUnits;
			obj3 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6CD9]");
			object obj4 = (nint)0 & (nint)1;
			bool flag = obj4 == null;
			obj5 = obj3;
			list2 = bracketUnits;
			if (!flag)
			{
				goto IL_009f;
			}
		}
		else
		{
			_ = 1;
			list = bracketUnits;
			obj3 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6CD9]");
			object obj6 = (nint)0 & (nint)1;
			bool flag2 = obj6 == null;
			object obj7 = !flag2;
			obj5 = obj3;
			list2 = bracketUnits;
			if (obj7 != null)
			{
				goto IL_009f;
			}
		}
		_ = 1;
		int num = tournamentSize;
		object obj8 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v8+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		list = list2;
		int num2 = tournamentSize;
		if (obj9 != null)
		{
			goto IL_00e8;
		}
		goto IL_020e;
		IL_0302:
		throw new NullReferenceException();
		IL_026d:
		double num4;
		float num3 = (float)num / (float)num4;
		object obj10 = num3 << 1;
		if (num3 == 9.2188684E+18f)
		{
			obj10 = 0;
		}
		object obj11 = bracket + obj10;
		object obj12 = obj11 + 1;
		object obj13 = obj12 + obj12;
		int index = obj13 >> 1;
		List<object> list3;
		object obj14 = list3.get_Item(index);
		if (obj14 != null)
		{
			object obj15 = (nint)0 + (nint)1360;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E32EDC");
			RectTransform rectTransform = default(RectTransform);
			if ((object)rectTransform != null)
			{
				Vector2 offsetMin = rectTransform.offsetMin;
				return num3;
			}
		}
		goto IL_0302;
		IL_00e8:
		num4 = Math.Pow(2.0, 1.0);
		bool flag4 = list == null;
		object obj16 = !flag4;
		list3 = (List<object>)(object)list;
		if (obj16 != null)
		{
			goto IL_026d;
		}
		num3 = (float)num4;
		goto IL_0302;
		IL_009f:
		num = tournamentSize;
		obj8 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v8+E4]");
		bool flag5 = (nint)0 == 0;
		list2 = list;
		num2 = tournamentSize;
		if (!flag5)
		{
			goto IL_00e8;
		}
		goto IL_020e;
		IL_020e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		num4 = Math.Pow(2.0, 1.0);
		bool flag6 = list2 == null;
		list3 = (List<object>)(object)list2;
		num = num2;
		num3 = (float)num4;
		if (!flag6)
		{
			goto IL_026d;
		}
		goto IL_0302;
	}

	private float OffsetMaxX(int bracket)
	{
		//IL_002a: Expected O, but got I
		int index = default(int);
		object obj = ((List<object>)(object)bracketUnits).get_Item(index);
		object obj2 = (nint)0 + (nint)1360;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E32EDC");
		RectTransform rectTransform = default(RectTransform);
		Vector2 offsetMax = rectTransform.offsetMax;
		float result = default(float);
		return result;
	}

	private float OffsetMinY(int bracket)
	{
		//IL_002a: Expected O, but got I
		int index = default(int);
		object obj = ((List<object>)(object)bracketUnits).get_Item(index);
		object obj2 = (nint)0 + (nint)1360;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E32EDC");
		RectTransform rectTransform = default(RectTransform);
		Vector2 offsetMax = rectTransform.offsetMax;
		Vector2 offsetMin = rectTransform.offsetMin;
		object obj4 = default(object);
		object obj3 = obj4 + obj4;
		return (float)obj3 * 0.5f;
	}

	private float OffsetMaxY(int bracket)
	{
		//IL_0038: Expected O, but got I
		int index = bracket + 1;
		object obj = ((List<object>)(object)bracketUnits).get_Item(index);
		object obj2 = (nint)0 + (nint)1360;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E32EDC");
		RectTransform rectTransform = default(RectTransform);
		Vector2 offsetMax = rectTransform.offsetMax;
		Vector2 offsetMin = rectTransform.offsetMin;
		object obj4 = default(object);
		object obj3 = obj4 + obj4;
		return (float)obj3 * 0.5f;
	}

	private int bracketNumberInNextColumn(int matchNumber)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00be: Expected O, but got I4
		//IL_0062: Expected O, but got F8
		//IL_006f: Invalid comparison between F8 and I8
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected O, but got Unknown
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_0102: Expected I4, but got O
		//IL_008f: Expected O, but got I4
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		double num = Math.Pow(2.0, 1.0);
		double num2 = (double)tournamentSize / num;
		object obj4 = num2 << 1;
		if (num2 == 9.218868437227405E+18)
		{
			obj4 = 0;
		}
		object obj5 = matchNumber + obj4;
		object obj6 = obj5 + 1;
		object obj7 = obj6 + obj6;
		return obj7 >> 1;
	}

	private int NumberOfGamesInColumn(int column)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00bc: Expected O, but got I4
		//IL_003a: Expected F8, but got I4
		//IL_005c: Invalid comparison between F8 and I8
		//IL_008d: Expected I4, but got F8
		//IL_0080: Expected I4, but got I8
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		double num = Math.Pow(2.0, column);
		double num2 = (double)tournamentSize / num;
		if (num2 == 9.218868437227405E+18)
		{
			return -2147483648;
		}
		return (int)num2;
	}

	public int GetFirstMatchIdInRound(int round)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00f0: Expected O, but got I4
		//IL_0080: Invalid comparison between F8 and I8
		//IL_00c1: Expected I4, but got F8
		//IL_00a4: Expected I4, but got I8
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		double y = 1.0 - (double)round;
		double num = Math.Pow(2.0, y);
		double num2 = 1.0 - num;
		double num3 = num2 * (double)tournamentSize;
		if (num3 == 9.218868437227405E+18)
		{
			return -2147483647;
		}
		double num4 = num3 + 1.0;
		return (int)num4;
	}

	public BracketGenerator()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected O, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected O, but got Unknown
		object obj = typeof(List<AdaptivePerformanceScaler>) + 1168;
		object obj2 = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 2384;
		lineThickness = 3f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj3 = this + 88;
		obj3 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list2 = default(List<object>);
		list2..ctor();
		object obj4 = this + 96;
		obj4 = list2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Dictionary<object, object> dictionary = default(Dictionary<object, object>);
		dictionary..ctor();
		object obj5 = this + 112;
		obj5 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
	}
}
