# الطرنيب — الملف الشامل الموحّد

> كل ما استُخرج عن الطرنيب في «كملنا Enjoy» — ملف واحد جاهز للدمج.
> **حالة التغطية: 39/39 دالة ≥150 بايت مفكوكة — 100٪، مُتحقَّق تقاطعيًا.**

| | |
|---|---|
| التطبيق | كملنا Enjoy 3.9.5 (295) · `net.peakgames.kammelna` |
| المحرّك | Unity 6000.3.8f1 · IL2CPP · arm64 |
| الشبكة | SmartFoxServer 2X · الحركة: DOTween |
| المصدر | `ipa-1h37p27m.ipa` · SHA256 `93ee85c4…c913a` · **1018/1018 ملف مُتحقَّق** |
| التاريخ | 2026-09-19 |

**درجات اليقين**: ✅ مؤكَّد حرفيًا · 🟡 مستنتج · ⚪ من نصوص التطبيق · ❌ غير قابل للاستخراج

---

## ملخص تنفيذي

**الطرنيب معتمد على الخادم** — لا وضع أوفلاين ولا ذكاء اصطناعي ولا تعليم داخل التطبيق.

### الحقائق المؤكَّدة ✅

| الحقيقة | القيمة | المصدر |
|---|---|---|
| عدد الأوراق | **52** (13 مرتبة × 4 أنواع) | `get_AllTarneebCards` @0x5326DC8 |
| أوراق كل لاعب | **13** (صفّان: 8+5) | `cardBacks[13]` · `GetRange(0,13)` |
| ترتيب القوة | **`Rank + 2`** (ACE=14) | `TarneebCardUtils.GetValue` |
| فرز اليد | **حسب النوع** `card.Suit` | `CardValue` @0x51EE900 |
| التوزيع | خلط 52 → 13 لكل لاعب + فرز | `OnStartRound` @0x51EE918 |
| **نهاية الصكة** | **> 30 نقطة ⇒ 31 تفوز** | `IsGameOver` @0x51EED08 |
| عدد اللاعبين | **4** يُنشَأون صراحة | `TarneebGame.Init` @0x532733C |
| المزايدة | **7–13 أكلة** ثم نوع الحكم | `BidValue` @0x4F85A68 |
| أزرار المزايدة | **11** (7 أرقام + 4 أنواع) | `Awake` @0x4F84104 — 11× `AddWithResize` |
| **رسالة المزايدة** | `pass` · `b`=عدد · `s`=**اسم نصّي** للنوع | `SubmitBid` @0x4F855B0 |
| مراحل المزايدة | `EatingBid` → `PickingSuit` | `[ENUM: TarneebBiddingStage]` |
| `Suit.NONE = 4` | مزايدة بلا نوع بعد → تُخفى الأيقونة | `SetBidInfo` @0x4FBC384 |
| **شروط الفرشّ** | **7 شروط** — أهمها: بادئ اللفّة | `UpdateButtons` @0x4FBBC18 |
| أنيميشن الفرشّ | `DOAnchorPosY` −732↔−328 · 0.5 ث | `Show/HideSawaButton` |
| أنيميشن لوحة المزايدة | `DOSizeDelta` ×2 + `TweenCallback` · `DOAnchorPosY` | `SetBidInfo` · `ShowBid` |
| فقاعة صندوق اللاعب | **6 حالات** + صوت عند المزايدة | `OnPlayerDidLastAction` @0x4FBC818 |
| أكلات اللاعب | `EatingCounts[Index-1]` | `get_EatingsCount` @0x5327CE0 |
| أكلات الخصم | **الجاران** (لا المقابل) | `get_OpponentTeamEatingsCount` @0x5327E64 |
| فريق المزايد | `IsRoundBidder \|\| Teammate.IsRoundBidder` | `get_IsTeamBidder` @0x532806C |
| عدّاد الأكلات | **مؤجَّل** + يتحرك فقط عند التغيّر | `UpdateEatingCount` + `b__0` |
| مساعد أنيميشن | **`AnimEmphasise2`** (غير موثّق في البلوت) | `<UpdateEatingCount>b__0` |
| ترشيح الأزرار | بمقارنة **`BidValue(button)`** لا الفهرس | `<getStateButtons>b__21_0` |
| المزايدة المسبقة | مشروطة بـ4 شروط | `ShowPredetermineBid` @0x4F84D58 |
| مفاتيح خاصة | `hb` `bStg` `ecs` `rndB` `b` `s` | تفكيك ARM64 + `ScriptString` |
| الأنيميشن العام | **مطابق للبلوت 100٪** | قيم Unity المُسلسلة |
| القطع والتقييد | **غير موجود** (صفر `CheatingCard`) | جرد المشهد |

### ما لا يوجد في التطبيق ❌ (مُثبَت لا مُفترَض)

صيغة تحويل الأكلات إلى نقاط · عقوبة فشل المزايدة · إلزامات اللعب.

**الدليل**: `ShowRoundBoard` (2348B) مفكوكة — صفر ضرب، فقط `GetTeamScore`/`GetTeamEeatings`.
`GetScores()` يُرجع `null`. `SaveRoundScore` تخزين فقط. `EndGame` تغليف وإطلاق حدث فقط.
وفُحص `remoteConfig` و27,881 سلسلة و219 نقطة نهاية — صفر تطابق.

⇒ **الطريق الوحيد**: 3–4 جولات لعب مع تسجيل (المزايدة، الأكلات، النقاط الناتجة).

---

# ٠١ — الأوراق والتعريفات


## 1. نموذج الورقة — مشترك مع البلوت

✅ `[CS: Card.cs]` · `[ENUM: Suit]` · `[ENUM: Rank]` — نفس الأصناف تمامًا.

```csharp
public class Card { public Rank Rank { get; } public Suit Suit { get; }
                    public int AsInt() => (int)Suit * 13 + (int)Rank; }
```

| الأنواع | `SPADES=0` · `HEARTS=1` · `CLUBS=2` · `DIAMONDS=3` · `NONE=4` |
|---|---|
| المراتب | `TWO=0` … `ACE=12` · `NONE=13` |

## 2. الفرق الجوهري عن البلوت: **المجموعة كاملة**

✅ `[CS: TarneebCardUtils.cs]`

```csharp
private static readonly IEnumerable<Rank> TarneebCardRanks;   // كل المراتب
public static IEnumerable<Card> AllTarneebCards;              // TarneebCardRanks × SuitMethods.GetAll()
public static Card RandomTarneebCard(List<Card> exclusionList = null);
```

| البند | الطرنيب | البلوت |
|---|---|---|
| عدد الأوراق | **52** | 32 |
| المراتب المستخدمة | **TWO … ACE** (13) | SEVEN … ACE (8) |
| أوراق كل لاعب | **13** | 8 |
| لفّات الجولة | **13** | 8 |

✅ تأكيد حجم اليد: `[UNITY: TarneebUserbox.cardBacks = 13 مرجع]`
✅ وتخطيط اليد: `[UNITY: Hand.maxCardsInBottomRow = 8]` ⇒ **صفّان** (8 + 5)
   — بعكس البلوت الذي يضع الثمانية في صف واحد.

## 3. ⭐ دالة القيمة — بسيطة بلا جداول

✅ `[CS: TarneebCardUtils.cs → GetValue]` — مقروءة بالكامل:

```csharp
public override int GetValue(Card card) => (int)card.Rank + 2;
```

| الورقة | القيمة |
|---|---|
| TWO | 2 |
| THREE … TEN | 3 … 10 |
| JACK | 11 |
| QUEEN | 12 |
| KING | 13 |
| **ACE** | **14** |

> ⭐ **فرق معماري كبير**: البلوت يملك **8 جداول ثابتة في الثنائي** (أبناط + رتب قوة
> منفصلة للصن والحكم). الطرنيب **لا يملك أي جدول** — مجرد `Rank + 2`.
>
> **المعنى**: منطق «من يأكل اللفة» ووزن الحكم **ليسا في العميل** — الخادم يحسبهما.
> راجع [README §⚠️](README.md).

## 4. الترميز

✅ مشترك مع البلوت بالكامل — `[CS: CardUtils.cs]`:
`FromInt` (suit = i/13، rank = i%13) · `FromString` · `DecodeCards` · `EncodeBinaryLongCards` · `SortCards`.

## 5. مظهر الأوراق

✅ `[UNITY: Hand.gameCardsSprite]` — 13 مرجع sprite (فهرس = `Rank`)
✅ `[CS: CardsSprites.cs]` · `[CS: CardBackSetter.cs]` — مشتركة مع البلوت.

---

---
# ٠٢ — تدفق اللعبة والحالات


## 1. البنية الطبقية

```
KGame → CardGame → TarneebGame              [CS: TarneebGame.cs] (390 سطر)
KPlayer → CardGamePlayer → TarneebPlayer    [CS: TarneebPlayer.cs] (396)
CardGameVisualControls (مشترك مع البلوت)
```

مقارنة الحجم مع البلوت: `BalootGame` 1203 سطر · **`TarneebGame` 390 سطر** — لأن
الطرنيب لا يحمل نمط لعب ولا مضاعفة ولا مشاريع ولا إكة.

## 2. حقول `TarneebGame` ✅

```csharp
private static readonly string HIGHEST_BID;    // = "hb"
private static readonly string BIDDING_STAGE;  // = "bStg"
private static readonly string EATING_COUNT;   // = "ecs"

private int                  HighestBid   { get; }   // أعلى مزايدة حاليًا
private TarneebBiddingStage  BiddingStage { get; }   // EatingBid | PickingSuit
private int[]                EatingCounts { get; }   // عدّاد الأكلات لكل لاعب
private TarneebScores        _scores;
private TarneebCardUtils     _cardUtils;

protected override void Init();
protected override void UpdateGameState(ISFSObject gameState);
protected override void EndGame(ISFSObject data);
public    override int[] GetScores();     // ← يُرجع null (النقاط من الخادم)
```

> ✅ قيم السلاسل الثلاث مُستخرجة من الثنائي بتفكيك `TarneebGame..cctor @0x53277A8`
> وربطها بجدول `ScriptString` — انظر [٠٧](07-بروتوكول-الخادم.md).

## 3. مراحل اللعبة

✅ مشتركة مع البلوت: `[ENUM: CardGameStages]` — `[SFS: "gStg"]`
```
None · Bidding · Playing · WaitingForEating · InCheatCatch · MoveNextRequired
```

✅ خاص بالطرنيب: `[ENUM: TarneebBiddingStage]` — `[CS: TarneebBiddingStage.cs]` — `[SFS: "bStg"]`
```csharp
public enum TarneebBiddingStage { EatingBid = 0, PickingSuit = 1 }
```
| المرحلة | المعنى |
|---|---|
| `EatingBid` | المزايدة على **عدد الأكلات** (7–13) |
| `PickingSuit` | الفائز بالمزايدة يختار **نوع الحكم** |

## 4. المقاعد والفرق

✅ مشترك مع البلوت: أربعة مقاعد، المتقابلان خويّان (1↔3، 2↔4).
⚪ `[LOC: Teammate]` = «الخوي» · `[LOC: Team 1/2]`.

## 5. دورة الصكة

```
┌─ START_ROUND [SFS:"sr"]
│  ① توزيع 13 ورقة لكل لاعب (52 ورقة كاملة)
│  ② Stage = Bidding · BiddingStage = EatingBid
│       كل لاعب: [7] [8] [9] [10] [11] [12] [13] أو [بس]
│       إن مرّ الجميع → «ورق» (waraq) = إعادة توزيع
│  ③ BiddingStage = PickingSuit
│       الفائز بالمزايدة يختار: [سبيت] [هاص] [شريّا] [ديمن]
│  ④ Stage = Playing — 13 لفّة
│       الخادم يرسل الأوراق المسموحة [SFS:"ppcs"] لصاحب الدور
│       عدّاد الأكلات يُحدَّث في [SFS:"ecs"]
│  ⑤ (اختياري) فرشّ — إعلان حسم بقية اللفّات  [SFS:"sawa"]
└─ END_ROUND [SFS:"er"] → النشرة → صكة جديدة أو END_GAME [SFS:"eg"]
```

## 6. ⭐ منطق التوزيع — **مستخرج من الثنائي**

✅ `[CS: KammelnaOffline.Tarneeb.TarneebGameController.cs → OnStartRound]` @`0x51EE918` (984 بايت)

تسلسل الاستدعاءات كما فُكّ من ARM64:

```csharp
protected override void OnStartRound() {
    var deck = TarneebCardUtils.AllTarneebCards   // 52 ورقة
                 .ToList()
                 .Shuffle();                      // ArraysExtensions.Shuffle
    // ثم لكل لاعب من الأربعة:
    player.Cards = deck.GetRange(0, 13);          // mov w1,#0 ; mov w2,#0xD
    player.Cards.Sort(new Comparison<Card>(...)); // فرز اليد
}
```

✅ النمط `GetRange(0, 13)` + `Sort` **يتكرّر أربع مرات** — مرة لكل لاعب.

### دالة الفرز
✅ `[CS: ...TarneebGameController.cs → CardValue]` @`0x51EE900` — مفكوكة:
```asm
cbz x1, →null ; ldr w0, [x1, #0x14] ; ret
```
إزاحة `0x14` في `Card` = **`<Suit>k__BackingField`** (مؤكَّد من `dump.cs`: `Rank // 0x10`, `Suit // 0x14`).

```csharp
protected override int CardValue(Card card)      => (int)card.Suit;
public    override int GetOfflineValue(Card card) => (int)card.Suit;   // نفس الجسم
```

> ⭐ أي أن الطرنيب يفرز اليد **حسب النوع** لا الرتبة — ترتيب العرض البصري.
> (ترتيب القوة يبقى `TarneebCardUtils.GetValue = Rank + 2`.)

## 7. سرعة اللعب والجلسات

✅ مشتركة مع البلوت: 5 ث / 10 ث / 30 ث / لا نهائي ⚪ `[LOC: Speed…]`
✅ `[CS: Timer.cs]` — 12 نسخة في مشهد الطرنيب (نفس عدد البلوت).

---

---
# ٠٣ — المزايدة


> ⭐ هذا أوضح جزء في الطرنيب — الواجهة مقروءة بالكامل من الكود.

## 1. البنية

✅ `[CS: TarneebBiddingButtons.cs]` (3,420 سطر) — الحقول العامة حرفيًا:

```csharp
public Button buttonPass;          // بس
public Button button7;             // 7  أكلات
public Button button8;             // 8
public Button button9;             // 9
public Button button10;            // 10
public Button button11;            // 11
public Button button12;            // 12
public Button button13;            // 13 (كل اللفّات)

public Button buttonClubs;         // حكم شريّا
public Button buttonDiamonds;      // حكم ديمن
public Button buttonSpades;        // حكم سبيت
public Button buttonHearts;        // حكم هاص

public GameObject biddingButtonsParent;
private Button[] stateButtons;
private Button[] round1DefaultState1;
private Button[] allBidButtons;     // مجموعة 7..13
private Button[] allSuitButtons;    // مجموعة الأنواع الأربعة
private const string Waraq = "waraq";
```

> **مدى المزايدة: 7 إلى 13 أكلة.** لا يوجد أقل من 7 ولا خيارات نمط لعب (لا صن/حكم/أشكل).

## 2. الدوال ✅

```csharp
private int  BidValue(...);                       // يحوّل الزر إلى عدد
private bool isValidBid(...);                     // شرط صحة المزايدة
protected override Button[] getStateButtons();
protected override void UpdateStateButtons(...);
protected override void ShowBid(...) / UpdateShowBid(...) / UpdateHideBid(...);
protected override void SubmitBid(...);
protected override void PredetermineBid(...) / ShowPredetermineBid(...) / SubmitPredetermineBid(...);
```

> `PredetermineBid` = **المزايدة المسبقة** (يختار اللاعب قراره قبل دوره) — موجودة في البلوت أيضًا.

✅ سلاسل الصنف المستخرجة من الثنائي: `"b"` · `"s"` · `"pass"` · `"incorrect button "`
— أي أن رسالة المزايدة تُرسل بمفتاحين: **`b`** (bid) و**`s`** (suit).

## 3. المرحلتان

✅ `[ENUM: TarneebBiddingStage]` — `[SFS: "bStg"]`

| المرحلة | الأزرار الظاهرة | الناتج |
|---|---|---|
| **`EatingBid`** (0) | `button7`…`button13` + `buttonPass` | `[SFS: "b"]` = عدد الأكلات |
| **`PickingSuit`** (1) | `buttonClubs/Diamonds/Spades/Hearts` | `[SFS: "s"]` = نوع الحكم |

✅ أعلى مزايدة حالية: `[SFS: "hb"]` = `TarneebGame.HighestBid`
   — تُستخدم في `isValidBid` لمنع المزايدة بقيمة ≤ الحالية. 🟡

## 4. «ورق» (إعادة التوزيع)

✅ ثابت `Waraq = "waraq"` في `TarneebBiddingButtons`.
⚪ نفس آلية البلوت: إن مرّ الجميع، تُعاد التوزيعة وينتقل الموزّع.

## 5. الأصوات

✅ `[ENUM: TarneebSound]` — **فارغ تمامًا** (لا مقاطع خاصة بالطرنيب).
✅ `[CS: TarneebGameSoundControls.cs]` (265 سطر) يستخدم الألبوم المشترك.

المقاطع المتاحة ذات الصلة (من جرد الأصوات الكامل):
`spades` · `hearts` · `clubs` · `diamonds` · `s` · `h` · `c` · `d`
· `7` `8` `9` `10` `11` `12` `13` ← **أرقام المزايدة** · `pass` · `waraq`

> ⭐ ملاحظة: مقاطع الأرقام `7`–`13` الموجودة في التطبيق تخدم **مزايدة الطرنيب** مباشرة
> (البلوت لا يزايد بأرقام)، وأسماء الأنواع تخدم اختيار الحكم في اللعبتين.

## 6. ما لا يمكن استخراجه

❌ **شرط `isValidBid` الدقيق** — جسم الدالة مشوّه في الفك.
❌ **هل توجد مزايدة إجبارية على الموزّع؟** غير مذكورة في العميل.
❌ **معنى كل قيمة مزايدة في النقاط** — على الخادم.

---

---
# ٠٤ — اللعب والنقاط


## 1. اللعب

✅ مشترك مع البلوت في البنية:

| البند | المفتاح |
|---|---|
| النوع المطلوب | `[SFS: "current_suit"]` |
| نوع الحكم | `[SFS: "ts"]` |
| الأوراق الملعوبة | `[SFS: "played_cards"]` |
| **الأوراق المسموح لعبها** | `[SFS: "ppcs"]` ⭐ |
| صاحب الدور | `[SFS: "mover"]` |
| لعب ورقة | `[SFS: "card"]` |
| المرحلة | `[SFS: "gStg"]` |

> ⭐ **الخادم يحسب `ppcs`** ويرسلها. العميل يعتّم الباقي فقط
> (`[CS: GameCard.cs → ColorGray]`، تدرّج 0.25 ث — انظر [٠٥](05-الأنيميشن.md)).
>
> ❌ خوارزمية `PlayableCards` **غير موجودة في العميل** — بعكس البلوت الذي يملك
> نسخة كاملة في `BalootUtils.PlayableCards`.

## 2. عدّاد الأكلات ⭐

✅ `[CS: TarneebGame.cs]` — خاص بالطرنيب:

```csharp
private static readonly string EATING_COUNT;   // = "ecs"
private int[] EatingCounts { get; }            // مصفوفة عدّادات
```

الخادم يرسل مصفوفة `ecs` وتُقرأ عبر `SFSExtensions.Get(gameState, "ecs", default)`.
هذا محور لعبة الطرنيب كلها: **المزايدة على عدد الأكلات، والعدّاد يتتبّع التحقّق**.

✅ العرض: `[CS: TarneebUserbox.cs]` (858 سطر) — مفاتيح نصوصه المستخرجة:
`"a_bid"` · `"your_turn"` · `"his_turn"` · `"thinking"` · `"waiting"` · `"click_to_continue"` · `"0"`

## 3. نتيجة الجولة ✅

`[CS: TarneebRoundScore.cs]` — مقروء بالكامل:

```csharp
public class TarneebRoundScore : CardGameRoundScore {
    private const string C_RoundBid = "rndB";
    public int  RoundBid  { get; private set; }          // المزايدة الفائزة
    public bool BidderWon => WinnerTeamIndex == Bidder;  // هل نجح المزايد؟
    public override void Record(ISFSObject data) {
        base.Record(data);
        RoundBid = SFSExtensions.Get(data, "rndB", 0);
    }
}
```

✅ يرث من `CardGameRoundScore` ⇒ يحصل على كل مفاتيح البلوت المشتركة:
`s1`/`s2` (نقاط) · `ts1`/`ts2` (تراكمي) · `e1`/`e2` (أكلات) · `w` (الفائز) ·
`b` (المزايد) · `winner` · `pp`/`cp` · `gp` · `lr`.

> ⚠️ لكن **بلا** `p1`/`p2` (أبناط) ولا `r1`/`r2` (مشاريع) ولا `kbt` (كبوت) ولا `em` —
> هذه خاصة بالبلوت.

✅ `[CS: TarneebScores.cs]` (108 سطر) — `SaveRoundScore(ISFSObject)` فقط، بلا حساب محلي.

## 4. نافذة النشرة

✅ `[CS: TarneebRoundBoardPopup.cs]` (1,238 سطر) — سلاسله المستخرجة من الثنائي:

| السلسلة | الدور |
|---|---|
| `"Your Team"` | فريقك |
| `"Opponent Team"` | فريق الخصم |
| `"Won"` / `"Lost"` | ربح / خسر |
| `"Correct"` / `"Wrong"` | المزايدة صحّت / فشلت |

⇒ النشرة تعرض لكل فريق: **المزايدة، هل تحققت، والنتيجة**.

## 5. الفرشّ (مقابل السوا)

⚪ `[LOC: Sawa] → <Tarneeb>فرشّ</Tarneeb>`
⚪ `[LOC: Sawa Confirmation] → تأكيد الفرشّ`
⚪ `[LOC: Sawa description…] → «اضغط تأكيد الفرشّ لإتمام الفرشّ بالأوراق الحالية…»`
✅ نفس مسار الشبكة: `[SFS: "sawa"]` · `[SFS: "sw"]` · `[CS: SawaInfo.cs]` · `[CS: SawaButtons.cs]`

## 6. ⭐ شرط نهاية الصكة — **مستخرج من الثنائي**

✅ `[CS: KammelnaOffline.Tarneeb.TarneebGameController.cs → IsGameOver]` — مفكوك حرفيًا من ARM64:

```asm
IsGameOver @0x51EED08 (36 بايت)
  ldr  w8, [x0, #0x30]    ; Team1TotalScore
  cmp  w8, #0x1e          ; 30
  b.le →                  ; إن لم يتجاوز، افحص الفريق الثاني
  mov  w0, #1 ; ret       ; انتهت
  ldr  w8, [x0, #0x34]    ; Team2TotalScore
  cmp  w8, #0x1e          ; 30
  cset w0, gt             ; return Team2TotalScore > 30
```

مكافئه بـ C#:
```csharp
protected override bool IsGameOver()
    => Team1TotalScore > 30 || Team2TotalScore > 30;
```

> ✅ إزاحتا `0x30` و`0x34` مؤكَّدتان من `dump.cs`:
> `protected int Team1TotalScore; // 0x30` و `protected int Team2TotalScore; // 0x34`
>
> ⭐ **الصكة تنتهي عند تجاوز 30 نقطة — أي الوصول إلى 31.**
> (البلوت: 152 نقطة · الطرنيب: **31 نقطة**)

## 7. ❌ ما هو غير قابل للاستخراج

| البند | السبب |
|---|---|
| **صيغة تحويل الأكلات إلى نقاط** | لا يوجد حساب محلي — `GetScores()` يُرجع `null` |

| **عقوبة فشل المزايدة** | على الخادم |
| **إلزامات اللعب** (اتباع النوع، الدق بالحكم) | الخادم يرسل `ppcs` جاهزة |
| **هل يوجد تقييد/غش في الطرنيب؟** | لا توجد أصناف `Cheating*` خاصة بالطرنيب |

> للحصول عليها: اللعب والرصد، أو مصدر خارجي لقواعد الطرنيب.

---

---
# ٠٩ — الدوال المفكوكة من ARM64 (حصيلة الحفر العميق)


> كل ما في هذا الفصل **مفكوك حرفيًا من ثنائي `UnityFramework`** بـcapstone،
> ومربوط بأسماء الدوال عبر `script.json.gz`. هذه أشياء **لا تظهر** في مخرجات Cpp2IL المشوّهة.

---

## ١. جرد التغطية الكامل

| المقياس | القيمة |
|---|---|
| إجمالي دوال الطرنيب في الثنائي | **105** |
| قوالب `NotImplementedException` (64 بايت بالضبط) | **9** |
| دوال جوهرية مفكوكة في هذا الفصل | **11** |

> ⭐ **تقنية**: كل دالة بحجم **64 بايت** في هذا البناء هي قالب `throw new NotImplementedException()`.
> بهذا مُيّز المنفَّذ من الفارغ بيقين دون قراءة كل دالة.

**الفارغة التسع**: `TarneebAiLogic.PlayCard` · `TarneebAiLogic.Bid` ·
`TarneebPlayingManager.StartPlaying` · `.OnPlay` · `.CopyCards` ·
`TarneebGameController.GetEatingPlayer` · `.GetPlayableCards` · `.OnEndRound` · `.GetBiddingFromSfsParam`

---

## ٢. ⭐ شرط نهاية الصكة — **٣١ نقطة**

`[CS: TarneebGameController → IsGameOver]` @`0x51EED08` (36B)

```asm
ldr  w8, [x0, #0x30]   ; Team1TotalScore
cmp  w8, #0x1e         ; 30
b.le →
mov  w0, #1 ; ret
ldr  w8, [x0, #0x34]   ; Team2TotalScore
cmp  w8, #0x1e
cset w0, gt
```
```csharp
protected override bool IsGameOver()
    => Team1TotalScore > 30 || Team2TotalScore > 30;
```
✅ الإزاحتان مؤكَّدتان من `dump.cs`: `Team1TotalScore // 0x30`، `Team2TotalScore // 0x34`.

---

## ٣. ⭐ التوزيع

`[CS: TarneebGameController → OnStartRound]` @`0x51EE918` (984B)

```csharp
var deck = TarneebCardUtils.AllTarneebCards.ToList().Shuffle();
// يتكرّر أربع مرات — مرة لكل لاعب:
player.Cards = deck.GetRange(0, 13);              // mov w1,#0 ; mov w2,#0xD
player.Cards.Sort(new Comparison<Card>(CardValue));
```

## ٤. دالة الفرز

`CardValue` @`0x51EE900` · `GetOfflineValue` @`0x51EECF0` — **نفس الجسم**:
```asm
cbz x1,→null ; ldr w0, [x1, #0x14] ; ret
```
`Card` layout من `dump.cs`: `Rank // 0x10` · `Suit // 0x14`
```csharp
protected override int CardValue(Card card)       => (int)card.Suit;
public    override int GetOfflineValue(Card card) => (int)card.Suit;
```
⇒ اليد تُفرز **حسب النوع** (عرض بصري). ترتيب القوة يبقى `TarneebCardUtils.GetValue = Rank + 2`.

---

## ٥. حسابات الأكلات — `TarneebPlayer`

```csharp
// get_IsTeamBidder @0x532806C (80B)
public bool IsTeamBidder => IsRoundBidder || Teammate.IsRoundBidder;

// get_EatingsCount @0x5327CE0 (176B)
public int EatingsCount => ((TarneebGame)Game).EatingCounts[Index - 1];
//   ldr w9,[x19,#0x10] = Index ; sub w9,w9,#1 ; عنصر المصفوفة عند [x8, 0x20 + i*4]
//   [x0,#0x178] = TarneebGame.EatingCounts

// get_TeamEatingsCount @0x5327D90 (212B)          ← أكلات اللاعب + الخوي
// get_OpponentTeamEatingsCount @0x5327E64 (520B)  ← أكلات الخصمين
```

---

## ٦. ⭐ الفرشّ (Farsh) — الشروط الكاملة

`[CS: TarneebPlayingButtons → UpdateButtons]` @`0x4FBBC18` (264B) — سلسلة الحراسة كما فُكّت:

```csharp
void UpdateButtons() {
    if (game.IsSpectator)                → HideSawaButton();
    if (!MyPlayer.IsHumanSeated)         → HideSawaButton();
    if (!MyPlayer.CanPlayCard)           → HideSawaButton();   // دورك
    if (game.<field 0x15C> != 1)         → HideSawaButton();   // فحص مرحلة
    if (game.CardsOnFloor.Any())         → HideSawaButton();   // ← يجب أن تكون بادئ اللفّة
    if (Room.IsOffline())                → HideSawaButton();
    if (game.IsTutorial)                 → HideSawaButton();
    else                                 → ShowSawaButton();
}
```

> ⭐ **القاعدة الجوهرية**: الفرشّ متاح **فقط عندما تبدأ اللفّة** (لا أوراق على الأرض)
> وفي دورك، وفي جلسة أونلاين غير تعليمية.

### أنيميشن زر الفرشّ ✅

| الحالة | الدالة | الحركة |
|---|---|---|
| إظهار | `ShowSawaButton` @`0x4FBBD20` | `interactable = true` · `DOKill` · `SetAsLastSibling` · **`DOAnchorPosY(-328, 0.5s)`** |
| إخفاء | `HideSawaButton` @`0x4FBBDD8` | `interactable = false` · `DOKill` · **`DOAnchorPosY(-732, 0.5s)`** |

⇒ الزر ينزلق بين **y = −732** (مخفي) و**y = −328** (ظاهر) خلال **٠.٥ ثانية**.

---

## ٧. المزايدة

### `BidValue` @`0x4F85A68` (584B) — تعيين مباشر
```
button7→7 · button8→8 · button9→9 · button10→0xA · button11→0xB · button12→0xC · button13→0xD
```
✅ **لا قاعدة خفية** — مجرد ربط زر برقم.

### `UpdateStateButtons` @`0x4F85CB0` (1312B) — واجهة بحتة
الاستدعاءات المفكوكة: `GameObject.SetActive` · `Enumerable.Contains` (على قائمة أزرار مسموحة) ·
`Selectable.set_interactable` · **`DOTweenModuleUI.DOColor`** (تلوين الزر المعطَّل) · `DOKill`.

> ⇒ **قيد المزايدة يأتي من الخادم** كقائمة أزرار مسموحة — نفس نمط البلوت (`bs`).
> العميل يفعّل/يعطّل ويلوّن فقط.

### `isValidBid` @`0x4F851E8` (260B)
يفحص `BiddingStage` (حقل `0x174` في `TarneebGame`) — أي أنه تحقّق **مرحلة** لا قيمة.

---

## ٨. نتيجة سلبية مهمّة — لا صيغة نقاط في العميل

`[CS: TarneebRoundBoardPopup → ShowRoundBoard]` @`0x4FB61E4` (**2348B**) — فُكّ بالكامل:

| ما وُجد | ما **لم** يوجد |
|---|---|
| `CardGameScores.get_LastCardGameRoundScore` | ❌ أي `mul` / `madd` |
| `CardGameRoundScore.GetTeamScore` | ❌ أي صيغة حسابية |
| `CardGameRoundScore.GetTeamEeatings` | ❌ أي ثابت نقاط |
| `TarneebRoundScore.get_BidderWon` | |
| `KGame.get_IsSpectator` · `CardGame.get_MyTeamIndex` | |
| السلاسل: `"Your Team"` `"Opponent Team"` `"Won"` `"Lost"` `"Correct"` `"Wrong"` | |

العملية الحسابية الوحيدة: `sub w8, w8, w21` — **تطبيع فهرس الفريق**، لا نقاط.

> ✅ **مُثبَت**: النشرة **تعرض** قيم الخادم ولا تحسبها.
> مع `GetScores() => null` في `TarneebGame`، تكون صيغة النقاط **قطعًا خارج التطبيق**.

---

## ٩. ما تبقّى غير مفكوك (واجهة فقط، بلا قواعد)

| الدالة | الحجم | الطبيعة |
|---|---|---|
| `TarneebBiddingButtons.Awake` | 2820B | ربط أزرار ومستمعات |
| `TarneebUserbox.OnPlayerDidLastAction` | 868B | عرض آخر إجراء |
| `TarneebUserbox.OnGameStatusUpdate` | 776B | تحديث عرض |
| `TarneebUserbox.SetBidInfo` | 676B | عرض المزايدة |
| `TarneebGame.Init` | 644B | تهيئة مراجع |
| `TarneebGameSoundControls.OnRoundEnd` | 580B | اختيار مقطع صوتي من `LastCardGameRoundScore` |
| `TarneebCardUtils.get_AllTarneebCards` | 552B | بناء الـ52 ورقة (LINQ) |
| `TarneebUserbox.UpdateEatingCount` | 496B | عرض عدّاد الأكلات |
| `TarneebPlayingButtons.Start` | 392B | تهيئة |
| `TarneebCardUtils.RandomTarneebCard` | 364B | ورقة عشوائية |
| `TarneebScores.SaveRoundScore` | 368B | حفظ حزمة الجولة في القائمة |

> فُحصت طبيعتها من استدعاءاتها — كلها عرض وتهيئة، لا قواعد لعب.

---


---

## ١٠. ⭐ الدفعة الثانية — بقية الدوال (فُكّت فعليًا لا افتراضًا)

> في الجولة الأولى قيّمت هذه الدوال **من أسماء استدعاءاتها** وقلت إنها «واجهة فقط».
> درس البلوت أثبت خطأ هذا المنهج، فأُعيد تفكيكها كلها فعليًا. وطلعت فيها قواعد.

### ١٠.١ `TarneebGame.Init` @`0x532733C` (644B) ✅

```
CardGamePlayer..ctor  ×4        ← ⭐ أربعة لاعبين يُنشَأون صراحة
CardGameScores..ctor
CardUtils..ctor                 ← TarneebCardUtils
cmp w8, #2
```

### ١٠.٢ `TarneebPlayer.get_OpponentTeamEatingsCount` @`0x5327E64` (520B) ✅

```
CardGame.GetNextPlayerIndex  ×2
```
```csharp
// أكلات الخصمين = اللاعب التالي + الذي يليه بمقدار خطوتين
public int OpponentTeamEatingsCount =>
    EatingCounts[NextPlayerIndex(me)] + EatingCounts[NextPlayerIndex(NextPlayerIndex(NextPlayerIndex(me)))];
```
> ⭐ يؤكّد ترتيب المقاعد: **الخصمان هما الجاران**، والخوي هو المقابل.

### ١٠.٣ `TarneebUserbox.SetBidInfo` @`0x4FBC384` (676B) ✅ — **فيها قاعدة**

```
cmp w20, #4                          ← ⭐ Suit.NONE = 4
Int32.ToString()                     ← عرض رقم المزايدة
SpritesStore.GetSuitSprite(...)      ← ⭐ أيقونة نوع الحكم
Image.set_sprite(...)
GameObject.SetActive(...)
DOKill() ; DOTweenModuleUI.DOSizeDelta(...)   ← ⭐ أنيميشن تمدّد لوحة المزايدة
TweenCallback..ctor                  ← دالة إتمام
DOSizeDelta(...)                     ← مرة ثانية (انكماش/تمدّد)
```

> ⭐ **القاعدة**: `Suit.NONE (4)` تعني **مزايدة بلا نوع بعد** (مرحلة `EatingBid`)،
> فتُخفى أيقونة النوع ويُعرض الرقم فقط. وعند `PickingSuit` تظهر الأيقونة.
>
> **الأنيميشن**: لوحة المزايدة تتمدّد/تنكمش بـ`DOSizeDelta` مرّتين مع `TweenCallback`.

### ١٠.٤ `TarneebUserbox.UpdateEatingCount` @`0x4FBC628` (496B) ✅

```
CoroutineDummy.WaitForSeconds(...)   ← ⭐ تحديث مؤجَّل
Action..ctor
CardGamePlayer.get_IsRoundBidder     ← ⭐ فرع مختلف للمزايد
```
> ⭐ عدّاد الأكلات **لا يُحدَّث فورًا** بل بعد تأخير (لتزامنه مع أنيميشن الأكلة)،
> وله عرض مختلف إن كان اللاعب هو المزايد.

### ١٠.٥ `TarneebUserbox.OnGameStatusUpdate` @`0x4FBC07C` (776B) ✅

```
base Userbox.OnGameStatusUpdate(...)
CardGamePlayer.get_IsRoundBidder
TarneebUserbox.SetBidInfo(...)  ×2
TarneebPlayer.get_EatingsCount
TarneebPlayer.get_TeamEatingsCount
TarneebPlayer.get_OpponentTeamEatingsCount
TarneebPlayer.get_IsTeamBidder
```
> ⇒ صندوق اللاعب يعرض: **المزايدة · أكلاتي · أكلات فريقي · أكلات الخصم · هل فريقي المزايد**.

### ١٠.٦ `TarneebCardUtils.get_AllTarneebCards` @`0x5326DC8` (552B) ✅

```
Func<Rank, IEnumerable<Suit>>
Enumerable.SelectMany<Rank, Suit, Card>(...)
```
```csharp
AllTarneebCards = TarneebCardRanks.SelectMany(r => SuitMethods.GetAll(), (r, s) => new Card(r, s));
```
⇒ **حاصل ضرب ديكارتي** 13 مرتبة × 4 أنواع = **52 ورقة** ✅

### ١٠.٧ أزرار المزايدة ✅

| الدالة | الاستدعاءات | المعنى |
|---|---|---|
| `getStateButtons` @`0x4F84C08` | `Func<bool>` + `Enumerable.Where` | ترشيح الأزرار الفعّالة |
| `ShowPredetermineBid` @`0x4F84D58` | `allowBiddingPredetermination` · `IsBidding` · `Any<int>` · `IsSpectator` · `get_tGame` | ⭐ شروط **المزايدة المسبقة** |
| `UpdateShowBid` @`0x4F85008` | `MyPlayer` · `IsBidder` · `cmp #1` · `allowBiddingPredetermination` | إظهار المزايدة |

> ⭐ **المزايدة المسبقة** (`PredetermineBid`) مشروطة بـ:
> `allowBiddingPredetermination` مفعّلة · المرحلة مزايدة · وجود خيارات · **ولست مشاهدًا**.

### ١٠.٨ `TarneebPlayingButtons.Start` @`0x4FBBA8C` (392B) ✅

```
UnityEngine.Object.FindAnyObjectByType<...>()
KGame.add_OnRoundStart(action)          ← ⭐ الاشتراك في بداية الجولة
KGame.add_OnGameStateUpdated(action)    ← ⭐ الاشتراك في تحديث الحالة
UnityAction..ctor
```
> ⇒ زر الفرشّ يُعاد تقييمه عند **بداية كل جولة** وعند **كل تحديث حالة**.

### ١٠.٩ أصوات الطرنيب ✅

`OnRoundEnd` @`0x53278F4` (580B):
```
CardGameScores.get_LastCardGameRoundScore
CardGameSoundControls.get_MyTeamIndex     ← ⭐ فريقي أم الخصم
KGame.get_IsFastTrackGame                 ← ⭐ فرع خاص بكأس كملنا
SoundAlbum<T>.GetClip(...)
```

`OnGameEnd` @`0x5327B38` (280B):
```
SFSKammelnaRoomExtensions.GetGameType
CardGameEndScores..ctor
CardGameSoundControls.get_MyTeamIndex
KGame.get_IsSpectator                     ← ⭐ المشاهد يسمع مقطعًا مختلفًا
SoundAlbum<T>.GetClip(...)  ×2            ← مقطعان: فوز/خسارة
```

### ١٠.١٠ `TarneebScores.SaveRoundScore` @`0x53280BC` (368B) ✅
```
CardGameRoundScore..ctor    ← ينشئ TarneebRoundScore ويضيفه للقائمة
```
لا حساب — تخزين فقط. ✅ يؤكّد §٨.

---

## ١١. جرد التغطية النهائي

| الفئة | العدد |
|---|---|
| إجمالي دوال الطرنيب | **105** |
| قوالب `NotImplementedException` (64B) | 9 |
| مفكوكة (الدفعة الأولى والثانية) | 22 |

> ⚠️ **هذا الجرد كان ناقصًا** — انظر §١٢ للتصحيح والجرد المُتحقَّق.


---


---

## ١٢. ⭐ الدفعة الثالثة — تصحيح ادعاء التغطية

> ⚠️ **تصحيح**: ادّعيت في §١١ أن «كل دالة ≥150 بايت مفكوكة». **هذا كان خطأً.**
> فحص جديد كشف **10 دوال ≥150 بايت** غير مغطّاة. فُكّت كلها هنا، وفيها اكتشافات حقيقية.

### ١٢.١ `TarneebBiddingButtons.Awake` @`0x4F84104` (2,820B) ✅

```
UnityEngine.Object.FindAnyObjectByType<...>()
List<Button>..ctor
AddWithResize  × 11        ← ⭐ إحدى عشرة إضافة
```
> ⭐ **11 = 7 أزرار مزايدة (7…13) + 4 أزرار أنواع** — تأكيد مباشر لتكوين
> `allBidButtons` و`allSuitButtons` من [٠٣](03-المزايدة.md).

`<Awake>b__20_0` @`0x4F861D8` (240B): `UnityAction..ctor` — ربط مستمعي النقر.

### ١٢.٢ ⭐ `TarneebUserbox.OnPlayerDidLastAction` @`0x4FBC818` (868B) — **الأغنى**

```
base Userbox.OnPlayerDidLastAction(...)

// ست سلاسل تُقارن بـ String.op_Equality:
"a_bid" · "thinking" · "his_turn" · "your_turn" · "waiting" · "click_to_continue"

CardGame.get_LastAction()
if (lastAction == "a_bid")
    GameSoundManager.Instance.PlaySound(...)        ← ⭐ صوت عند المزايدة

DOTweenModuleUI.DOFade(...).SetDelay(...)           ← ⭐ تلاشٍ بتأخير
ShortcutExtensionsTMPText.DOFade(...)               ← تلاشي النص

SuitMethods.GetSuitLocalizationString(...)          ← ⭐ اسم نوع الحكم مترجمًا
```

> ⭐ **فقاعة صندوق اللاعب** تعرض ستّ حالات مختلفة، وتُشغّل صوتًا عند المزايدة،
> وتتلاشى بـ`DOFade` مع `SetDelay`، وتعرض **اسم نوع الحكم مترجمًا** عبر
> `SuitMethods.GetSuitLocalizationString`.

### ١٢.٣ ⭐ `<UpdateEatingCount>b__0` @`0x4FBCBC4` (416B) — **مساعد أنيميشن جديد**

```
Int32.ToString()
String.op_Inequality(...)              ← ⭐ مقارنة العدّاد القديم بالجديد
UIExtensions.rectTransform(...)
AnimationExtensions.AnimEmphasise2(...)  ← ⭐⭐ دالة لم تُوثّق في [٠٨]
```

> ⭐ **قاعدتان**:
> 1. عدّاد الأكلات **يتحرّك فقط إذا تغيّرت قيمته فعلًا** (`op_Inequality`).
> 2. يستخدم **`AnimEmphasise2`** — نسخة ثانية من `AnimEmphasise`
>    لم تُذكر في [أرشيف البلوت §٥](../baloot-spec/08-الأنيميشن-الكامل.md).

### ١٢.٤ `TarneebUserbox.Awake` @`0x4FBBF94` (232B) ✅

```
"0"                                    ← القيمة الابتدائية للعدّاد
base Userbox.Awake(...)
GameObject.GetComponent<...>()  ×2
RectTransform.get_sizeDelta()          ← ⭐ حفظ الحجم الأصلي
```
> ⇒ يحفظ `sizeDelta` الأصلي ليُستخدم في أنيميشن `DOSizeDelta` داخل `SetBidInfo` (§١٠.٣).

### ١٢.٥ `TarneebBiddingButtons.ShowBid` @`0x4F84F5C` (172B) ✅

```
DOKill()
DOTweenModuleUI.DOAnchorPosY(...)      ← ⭐ لوحة المزايدة تنزلق رأسيًا
```
> نفس نمط زر الفرشّ (§٦) — انزلاق بـ`DOAnchorPosY`.

### ١٢.٦ مرشّحات الأزرار ✅

| الدالة | الحجم | المنطق |
|---|---|---|
| `<getStateButtons>b__21_0` | 304B | `Object.op_Equality` ×2 ثم **`BidValue(button)`** |
| `<ShowPredetermineBid>b__22_0` | 304B | نفس النمط — **`BidValue(button)`** |
| `PredetermineBid` | 164B | `Object.op_Equality` |

> ⭐ ترشيح الأزرار يتم **بمقارنة `BidValue(button)`** بالمدى المسموح
> (القادم من الخادم) — لا بفهرس الزر. تصميم نظيف يمكن نقله مباشرة.

### ١٢.٧ `TarneebCardUtils.RandomTarneebCard` @`0x5326FF0` (364B) ✅
```
get_AllTarneebCards() → List..ctor → Enumerable.Except(exclusionList) → ToList
```
يطابق الكود المفكوك في [٠١](01-الأوراق-والتعريفات.md).

---

## ١٣. جرد التغطية النهائي (مُتحقَّق)

| الفئة | العدد |
|---|---|
| إجمالي دوال الطرنيب | **105** |
| قوالب `NotImplementedException` (64B) | 9 |
| **مفكوكة ومُوثّقة** | **32** |
| توابع صغيرة (<150B): `get_`/`set_`/`.ctor`/lambdas | **64** |

### الدوال <150 بايت غير المفكوكة (كلها توابع تافهة)
```
SubmitPredetermineBid(140B) · .ctor ×9 · get_tarneebGame(136B) · get_Game(136B)
get_tGame(124B) · get_player(124B) · get_game(124B) · Record(120B)
<get_AllTarneebCards>b__3_1(112B) · <SetBidInfo>b__12_0(48B) · UpdateHideBid(44B)
<Awake>b__1(32B) · ShowSawaPanel(28B) · GetValue(28B) · get_BidderWon(20B)
set_EatingCounts(12B) · get/set_HighestBid · get/set_BiddingStage · get_EatingCounts
get_GameScores · get_GameCardUtils · get_RoundBid/set_RoundBid · OnGameStateUpdated(4B)
```

> ⚠️ **هذا الجرد أيضًا كان ناقصًا بدالتين** — انظر §١٤ للجرد النهائي المُتحقَّق تقاطعيًا.


---


---

## ١٤. ⭐ الدفعة الرابعة — إقفال آخر دالتين

فحص تقاطعي أخير (كل دالة ≥150B مقابل قائمة المفكوك) كشف اثنتين متبقيتين.

### ١٤.١ ⭐ `TarneebBiddingButtons.SubmitBid` @`0x4F855B0` (1,208B) — **بنية رسالة المزايدة**

```
السلاسل: "pass" · "b" · "s"

isValidBid(...)                                  ← تحقق أولًا
SFSObject..ctor                                  ← بناء الرسالة

Object.op_Equality(button, buttonPass)
    → SFSExtensions.Put(obj, "pass", ...)        ← تمرير

Object.op_Equality × 7                           ← مطابقة زر الرقم
    → BidValue(button)
    → SFSExtensions.Put(obj, "b", value)         ← ⭐ عدد الأكلات (7..13)

CardGame.SendBidding(obj)                        ← ⭐ الإرسال

Object.op_Equality × 4                           ← مطابقة زر النوع
    → EnumExtensions.GetFriendlyName(suit)       ← ⭐⭐ اسم نصّي لا رقم
    → SFSExtensions.Put(obj, "s", suitName)

وإلا: String.Concat("incorrect button ", name)
      → throw ArgumentException
```

> ⭐⭐ **اكتشاف بروتوكولي**: نوع الحكم يُرسَل **كاسم نصّي** عبر
> `EnumExtensions.GetFriendlyName(Suit)` — **لا كرقم**.
> أي أن `[SFS: "s"]` قيمته نص مثل اسم النوع، بينما `[SFS: "b"]` عدد صحيح.
>
> وأي زر غير معروف يرمي `ArgumentException("incorrect button " + …)` —
> ما يفسّر وجود السلسلة `"incorrect button "` المستخرجة في [٠٧](07-بروتوكول-الخادم.md).

### ١٤.٢ `TarneebGame.EndGame` @`0x53275D0` (176B) ✅

```csharp
base.EndGame(data);                                   // KGame.EndGame
var type   = Room.GetGameType();                      // SFSKammelnaRoomExtensions
var scores = new CardGameEndScores(data, type);
InvokeOnCardGameEnd(scores);                          // CardGame
```
> لا حساب — تغليف وإطلاق حدث فقط. ✅ يؤكّد أن النقاط تأتي جاهزة من الخادم.

---

## ١٥. ✅ جرد التغطية النهائي — مُتحقَّق تقاطعيًا

| الفئة | العدد |
|---|---|
| إجمالي دوال الطرنيب | **105** |
| **دوال ≥ 150 بايت** | **39** |
| **منها مفكوكة ومُوثّقة** | **39 — 100٪** ✅ |
| قوالب `NotImplementedException` (64B) | 9 |
| توابع < 150B (`get_`/`set_`/`.ctor`/lambdas) | 57 |

### طريقة التحقق
```
1. جرد كل دالة تحوي "Tarneeb" من script.json.gz → 105
2. حساب حجم كل دالة = عنوان الدالة التالية − عنوانها
3. ترشيح ≥150 بايت → 39
4. مقارنة تقاطعية مع قائمة المفكوك → كشف 2 ناقصتين → فُكّتا
```

> ✅ **لم يبقَ في الطرنيب أي دالة ذات منطق غير مفكوكة.**
> الـ57 المتبقية توابع وصول ومُنشئات، أكبرها 140 بايت (`SubmitPredetermineBid` — تمرير).


---

---
# ٠٥ — الأنيميشن


> الطرنيب يشارك البلوت **نفس محرّك الحركة ونفس الأصناف** (`CardGameVisualControls`).
> لذلك كل التفاصيل في [أرشيف البلوت — ٠٨](../baloot-spec/08-الأنيميشن-الكامل.md) تنطبق حرفيًا.
> هذا الفصل يوثّق ما تحقّقت منه في مشهد الطرنيب + الفروق.

---

## 1. ✅ القيم مطابقة تمامًا للبلوت

مقروءة من `[UNITY: CardGameVisualControls]` في مشهد `03game_tarneeb`:

| الحقل | القيمة | مطابق للبلوت؟ |
|---|---|---|
| `localCardMoveDuration` | **0.2** ث | ✅ |
| `localCardMoveDelay` | **0.0** | ✅ |
| `localCardRotDuration` | **0.25** ث | ✅ |
| `localCardScaleDuration` | **0.5** ث | ✅ |
| `serverCardMoveDuration` | **0.4** ث | ✅ |
| `serverCardMoveDelay` | **0.2** ث | ✅ |
| `serverCardRotDuration` | **0.6** ث | ✅ |
| `serverCardScaleDuration` | **0.6** ث | ✅ |
| `localCardStartScale` | **(1.6, 1.6, 1.6)** | ✅ |
| `serverCardStartScale` | **(0.65, 0.65, 0.65)** | ✅ |
| `cardSlotFlingY` | **1860** | ✅ |

وكذلك الثوابت المشتركة في `[CS: CardGameVisualControls.cs]`:
`HumanPerceptionTime = 0.6f` · `ConsecutiveCardPlayTime = 0.1f` · `AnimationPreCollisionTime = 0.3f`
· `MinRandPosTime/MaxRandPosTime = 0.35/0.45` · `MinRandSlide/MaxRandSlide = 0/30`
· `MinRandRot/RandRot = 1/3` · `MinRandPos/RandPos = 6/9`.

✅ ومنحنيا `UserboxCardPlayIntroRotation` و`UserboxCardPlayIntroScale` (مع تجاوز 1.025 ثم ارتداد 0.99)
— نفس القيم بالضبط.

## 2. ⭐ الفروق الحقيقية

### 2.1 تخطيط اليد — صفّان بدل صف
| | الطرنيب | البلوت |
|---|---|---|
| أوراق اليد | **13** | 8 |
| `maxCardsInBottomRow` | 8 | 8 |
| النتيجة | **صفّان: 8 أسفل + 5 أعلى** | صف واحد |

⇒ أنيميشن إعادة ترتيب اليد (`AddReorganizeHandToActionsBuffer`) يحرّك أوراقًا بين صفّين.

### 2.2 ترتيب الطبقات
✅ `[CS: GameCard.cs → SetSortingOrder]` = `13 - index` — **مصمَّم أصلًا لـ13 ورقة**،
أي أن الطرنيب هو الحالة القصوى لهذه الصيغة (البلوت يستخدم 6..13 فقط).

### 2.3 ارتفاع الورقة عند الاختيار
✅ `[CS: GameCard.cs]` يعرّف `BalootPickedCardYOffSet = 100f` و`JackarooPickedCardYOffSet = 20f`.
🟡 الطرنيب يقع ضمن المسار الافتراضي (`GetYOffSet`) — أي **100** كالبلوت،
لأن لا ثابت خاصًا به.

### 2.4 صندوق اللاعب
✅ `[UNITY: TarneebUserbox]`:
```
isPlayerPrefab = 1          (البلوت: 0)
direction      = 0          (البلوت: 3)
cardBacks      = [13 refs]  (البلوت: 8)
_restingLocalScale = 1.0    (مطابق)
```

## 3. مقاطع الأنيميشن والنوافذ

✅ مشتركة بالكامل: `Kaboot Winner/Loser`، `Winner Score`، `Rank up/down`،
`MM_Show/Hide/Start`، `VS screen_Player card` — كلها في حزم عامة لا خاصة بلعبة.

✅ `[UNITY: DOTweenAnimation]` — **16 مكوّن** في مشهد الطرنيب (نفس عدد البلوت)،
بنفس النمط القياسي:

| الحركة | المدة | Ease |
|---|---|---|
| إظهار نافذة (Scale) | 0.3 ث | **OutBack (27)** |
| إخفاء نافذة (Scale) | 0.3 ث | **InBack (26)** |
| مؤشر تحميل (Rotate −360) | 1.5 ث | Linear ∞ |
| نبض (Scale) | 1.0 ث | InOutSine ∞ Yoyo |
| انزلاق (LocalMove Y −12) | 0.3 ث | OutQuad |

✅ `[CS: SlideAnimationHelper.cs]` — **5 نسخ** في مشهد الطرنيب (البلوت 6)، `duration = 0.4f`.

## 4. تعتيم الأوراق غير الصالحة

✅ آلية مطابقة للبلوت — `[CS: GameCard.cs]`:
```
الخادم يرسل ppcs → PlayableCards → DimCard(true/false)
→ DOColor(ColorGray, 0.25s) للأوراق غير الصالحة
عند الاختيار: يرتفع 100 وحدة، يكبُر إلى 1.2×، مدة 0.1 ث، صوت CARD_PREPARE
```

---

---
# ٠٦ — الواجهة والتصميم


## 1. المشاهد
| المشهد | الجهاز |
|---|---|
| `scenes/03game_tarneeb` | جوال |
| `scenes/03tgame_tarneeb` | تابلت |

القماش المرجعي: **1080 × 1920** ✅

## 2. جرد مكوّنات المشهد (جوال) ✅

| العدد | المكوّن | | العدد | المكوّن |
|---|---|---|---|---|
| 426 | `Image` | | 13 | `GameCard` |
| 128 | `TextMeshProUGUI` | | 12 | `Timer` |
| 55 | `Button` | | 9 | `RankUIModular` |
| 54 | `LocalizeTextMeshProUGUI` | | 5 | **`TarneebUserbox`** |
| 49 | `LayoutElement` | | 5 | `CardsRevealer` |
| 20 | `HorizontalLayoutGroup` | | 5 | `SlideAnimationHelper` |
| 20 | `VerticalLayoutGroup` | | 5 | `EmoteViewer` |
| 16 | `DOTweenAnimation` | | 4 | `RadialLayout` |
| 15 | `UiToggler` | | 2 | `CounterBubbleText` |
| 13 | `UsernameSetter`/`AvatarImageSetter`/`AvatarInitializer` | | 1 | `TarneebGame`, `TarneebBiddingButtons`, `TarneebPlayingButtons`, `TarneebRoundBoardPopup`, `Hand`, `CardGameVisualControls` |

### الفروق عن مشهد البلوت
| | الطرنيب | البلوت |
|---|---|---|
| `Image` | 426 | 452 |
| `Button` | 55 | 73 |
| **`CheatingCard`** | **0** | **76** |
| `CardsRevealer` | 5 | 30 |
| `HighlightsItem` | 0 | 18 |
| `EmoteViewer` | 5 | 31 |

> ⭐ **صفر `CheatingCard`** — تأكيد قاطع أن **الطرنيب بلا نظام قطع وتقييد**،
> وهو أكبر فارق وظيفي عن البلوت.

## 3. الألوان
📄 [`refs/colors-palette.md`](refs/colors-palette.md) — **31 لون فريد**.
اللوحة شبه مطابقة للبلوت (نفس نظام التصميم عبر التطبيق).

## 4. التخطيط والإحداثيات
📄 [`refs/ui-hierarchy-phone.txt`](refs/ui-hierarchy-phone.txt) — **1025 كائن**
📄 [`refs/ui-hierarchy-tablet.txt`](refs/ui-hierarchy-tablet.txt) — **1306 كائن**

الصيغة: `الاسم  pos(x,y) size(w,h) anchor[…] pivot(x,y) [scale] {المكوّنات} [مخفي]`

## 5. الخطوط والنصوص
📄 [`refs/fonts-and-text.md`](refs/fonts-and-text.md) — **329 عنصر نص**
نفس عائلات الخطوط في البلوت (Hacen Liner Screen، Ara Jozoor، Ara Hamah، Sukar…).
⚠️ خطوط عربية مرخّصة — تحتاج ترخيصًا أو بديلًا مفتوحًا (Cairo/Tajawal/Almarai).

## 6. مواصفة التصميم البصري
📄 [`refs/design-spec.md`](refs/design-spec.md) — **1,010 عنصر صورة**
(426 جوال + 584 تابلت) لكل واحد: اسم الصورة · الأبعاد · حدود 9-slice · نوع الرسم · الصبغة · اللمس.
+ مجموعات التخطيط بالحشو والتباعد والمحاذاة.

> الرسومات نفسها غير مُصدَّرة — تُنتَج أصليًا بهويتك. المواصفة تعطيك المقاسات والسلوك بدقة.

## 7. النصوص
📄 [`refs/tarneeb-localization.md`](refs/tarneeb-localization.md) — **35 مفتاح** بصيغة `<Tarneeb>`.

---

---
# ٠٧ — بروتوكول الخادم


> الطرنيب **معتمد كليًا على الخادم**. هذا الفصل يوثّق المفاتيح الخاصة به فقط؛
> المفاتيح المشتركة في [أرشيف البلوت — ١٢](../baloot-spec/12-بروتوكول-الخادم.md).

---

## 1. مفاتيح خاصة بالطرنيب ✅

| المفتاح | الثابت | الصنف | المعنى |
|---|---|---|---|
| `hb` | `HIGHEST_BID` | `TarneebGame` | أعلى مزايدة حاليًا |
| `bStg` | `BIDDING_STAGE` | `TarneebGame` | `[ENUM: TarneebBiddingStage]` — 0=EatingBid، 1=PickingSuit |
| `ecs` | `EATING_COUNT` | `TarneebGame` | **مصفوفة عدّادات الأكلات** |
| `rndB` | `C_RoundBid` | `TarneebRoundScore` | المزايدة الفائزة في الجولة |
| `b` | — | `TarneebBiddingButtons` | قيمة المزايدة المُرسَلة (7–13) |
| `s` | — | `TarneebBiddingButtons` | نوع الحكم المُختار |
| `pass` | — | `TarneebBiddingButtons` | تمرير |
| `waraq` | `Waraq` | `TarneebBiddingButtons` | إعادة توزيع |

### كيف استُخرجت هذه القيم

الثوابت `static readonly string` لا تظهر قيمها في الفك (`Cpp2IL` يعرضها مشوّهة).
استُخرجت بتفكيك ARM64 مباشر وربط مراجع السلاسل بجدول `ScriptString` من `Il2CppDumper`:

```
TarneebGame..cctor @0x53277A8
  adrp x23, #0x8d40000 ; add x23, x23, #0x9e0   ->  "hb"
  adrp x21, #0x8d39000 ; add x21, x21, #0xdf0   ->  "bStg"
  adrp x20, #0x8d3d000 ; add x20, x20, #0x638   ->  "ecs"
```

طُبّقت نفس الطريقة على **71 دالة** في أصناف الطرنيب.

## 2. مفاتيح واجهة `TarneebUserbox` ✅

مستخرجة من الثنائي — مفاتيح ترجمة تُعرض في صندوق اللاعب:

| المفتاح | الدور |
|---|---|
| `a_bid` | عرض مزايدة اللاعب |
| `your_turn` | «دورك» |
| `his_turn` | «دوره» |
| `thinking` | «يفكّر» |
| `waiting` | «في الانتظار» |
| `click_to_continue` | «اضغط للاستمرار» |
| `0` | قيمة عدّاد افتراضية |

## 3. سلاسل `TarneebRoundBoardPopup` ✅

`"Your Team"` · `"Opponent Team"` · `"Won"` · `"Lost"` · `"Correct"` · `"Wrong"`

## 4. المفاتيح المشتركة المستخدمة

من `KGame` / `CardGame` / `CardGamePlayer` — انظر [البلوت ١٢](../baloot-spec/12-بروتوكول-الخادم.md):

`game_state` · `sr` · `er` · `eg` · `gStg` · `gp` · `mover` · `card` · `played_cards` ·
`current_suit` · `ts` · `rb` · `b` · `dealer` · `mn` · **`ppcs`** · `pcs` · `apcs` · `pcsCount` ·
`bs` · `sawa` · `sw` · `kasho` · `hks` · `cks` · `emt` · `ne` · `gst` · `ghl` · `wdt` · `ait` · `seat` · `ss`

### ⚠️ مفاتيح البلوت غير المستخدمة في الطرنيب
`gm` (نمط اللعب) · `gem` (المضاعفة) · `hc` (حكم مقفل) · `rd` (مُضاعِف) · `fc` (ورقة الأرض) ·
`dp`/`prcs` (المشاريع) · `de` (الإكة) · `chup`/`live_catch` (التقييد) · `p1`/`p2` (أبناط) ·
`r1`/`r2` (مشاريع) · `kbt` (كبوت)

## 5. ملاحظة معمارية

```csharp
// [CS: TarneebGame.cs]
public override int[] GetScores() => null;
```

⇒ العميل **لا يحسب أي نقطة**. كل شيء يصل جاهزًا في حزم `er` / `eg`.

---

---
# ٠٨ — فهرس الكود


**المسار**: `source-code/cpp2il-cs-full/KammenlaAssembly/<الملف>`

## أ. أصناف الطرنيب

| الملف | الأسطر | الوظيفة | الحالة |
|---|---|---|---|
| `TarneebBiddingButtons.cs` | **3,420** | ⭐ واجهة المزايدة: أزرار 7–13 + 4 أنواع + بس | ✅ مقروء |
| `TarneebRoundBoardPopup.cs` | 1,238 | نشرة نهاية الجولة | ✅ |
| `TarneebUserbox.cs` | 858 | صندوق اللاعب (13 ظهر ورقة) | ✅ |
| `TarneebPlayer.cs` | 396 | لاعب الطرنيب (بلا حقول إضافية) | ✅ |
| `TarneebCardUtils.cs` | 397 | `AllTarneebCards` (52) · `GetValue = Rank+2` | ✅ |
| `TarneebGame.cs` | 390 | `HighestBid` · `BiddingStage` · `EatingCounts` | ✅ |
| `TarneebGameSoundControls.cs` | 265 | تحكّم الصوت (ألبوم مشترك) | ✅ |
| `TarneebPlayingButtons.cs` | 152 | أزرار أثناء اللعب | ✅ |
| `TarneebScores.cs` | 108 | `SaveRoundScore` فقط | ✅ |
| `TarneebRoundScore.cs` | 40 | `rndB` · `BidderWon` | ✅ مقروء بالكامل |
| `TarneebBiddingStage.cs` | 5 | `enum { EatingBid, PickingSuit }` | ✅ |
| `TarneebSound.cs` | 4 | `enum` **فارغ** | ✅ |

## ب. وضع الأوفلاين — ❌ هيكل فارغ

| الملف | الأسطر | الحالة |
|---|---|---|
| `KammelnaOffline.Tarneeb.TarneebGameController.cs` | 379 | ⚠️ **4 دوال `NotImplementedException`** |
| `KammelnaOffline.Tarneeb.TarneebPlayingManager.cs` | 107 | ❌ `StartPlaying`/`OnPlay`/`CopyCards` كلها `NotImplementedException` |
| `KammelnaOffline.Tarneeb.TarneebBiddingManager.cs` | 41 | ❌ يُرجع مصفوفات فارغة |
| `KammelnaOffline.Tarneeb.TarneebAiLogic.cs` | 40 | ❌ `PlayCard`/`Bid` → `NotImplementedException` |
| `KammelnaOffline.Tarneeb.TarneebOfflinePlayer.cs` | 11 | صنف فارغ يرث `OfflinePlayer` |

> **مقارنة**: `BalootGameController.cs` = 7,265 سطر بـ**صفر** `NotImplementedException`.

## ج. الأصناف المشتركة المستخدمة

`Card` · `Suit` · `Rank` · `CardUtils` · `CardGame` · `CardGamePlayer` · `KGame` ·
`CardGameVisualControls` · `CardGameUiControls` · `Hand` · `GameCard` · `UserBox` · `Timer` ·
`CardGameRoundScore` · `CardGameScores` · `CardGameEndScores` · `AnimationExtensions` ·
`SlideAnimationHelper` · `PopupUI` · `GameSoundManager` · `SawaInfo` · `SawaButtons` · `KashoButton`

تفاصيلها في [فهرس كود البلوت](../baloot-spec/13-فهرس-الكود.md).

## د. الأصناف غير الموجودة للطرنيب

`TarneebProject*` · `TarneebCheating*` · `TarneebHighlights` · `TarneebStatistics` ·
`TarneebEndScores` · أي `Tutorial` — **لا وجود لها**.

## هـ. تقنيات الاستخراج المستخدمة

| التقنية | الاستخدام |
|---|---|
| تفكيك ARM64 (capstone) | استخراج قيم `static readonly string` |
| `script.json.gz → ScriptString` | ربط عناوين السلاسل بقيمها |
| `script.json.gz → ScriptMethod` | تحديد عناوين 71 دالة طرنيب |
| UnityPy + typetree | الألوان، الإحداثيات، الخطوط، التصميم |
| `LocalizationText` | المصطلحات ونصوص الواجهة |

---

---

## ملحق — المراجع الخام

| الملف | المحتوى |
|---|---|
| `tarneeb-spec/refs/ui-hierarchy-phone.txt` | شجرة واجهة الجوال — 1025 كائن بالإحداثيات |
| `tarneeb-spec/refs/ui-hierarchy-tablet.txt` | شجرة واجهة التابلت — 1306 كائن |
| `tarneeb-spec/refs/colors-palette.md` | 31 لون فريد بالـHEX |
| `tarneeb-spec/refs/fonts-and-text.md` | 329 عنصر نص |
| `tarneeb-spec/refs/design-spec.md` | 1,010 عنصر صورة بـ9-slice ونوع الرسم والصبغة |
| `tarneeb-spec/refs/tarneeb-localization.md` | 35 مفتاح `<Tarneeb>` + المصطلحات |

## ملحق — تقنيات الاستخراج

| التقنية | ماذا حلّت |
|---|---|
| تفكيك ARM64 (capstone) | **39 دالة** — كل دالة ≥150 بايت في الطرنيب |
| قاعدة حجم القالب (64 بايت) | تمييز 9 دوال فارغة من 105 بيقين |
| `script.json.gz → ScriptString` | `hb` · `bStg` · `ecs` · وكل سلاسل الواجهة |
| `script.json.gz → ScriptMethod` | عناوين وأحجام 105 دالة — أساس جرد التغطية |
| `dump.cs` إزاحات الحقول | `Team1TotalScore // 0x30` · `Card.Suit // 0x14` |
| UnityPy + typetree | الألوان · الإحداثيات · الخطوط · مواصفة التصميم |
| `LocalizationText` | المصطلحات (صكة، فرشّ) ونصوص الواجهة |
