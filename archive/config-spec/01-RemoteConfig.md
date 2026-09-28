# ٠١ — `RemoteConfig` الكامل

[↩ الفهرس](README.md)

> كل قيمة في اللعبة يتحكّم بها الخادم. **هذا أهمّ ملف لمن يعيد البناء**: هذه هي الأرقام
> التي ليست في الثنائي ولا في أصول Unity، ويجب أن يوفّرها خادمك.
>
> ✅ = مقروء من كود الآلة أو من إزاحة حقل في `dump.cs`.

---

## ١. البنية

```csharp
public static class RemoteConfig {                    // dump.cs:94634
    private static readonly RemoteConfigModel DEFAULTS;          // 0x0
    public static OneShotEvent<RemoteConfigModel> ReadyState { get; }
    public static RemoteConfigModel Current { get; }             // @0x509AE6C
    public static event Action OnChanged;                        // 0x10
    public static void Initialize();  // @0x50A9A10
    public static void Refresh();     // @0x50A9B8C
    private static void Fetch();      // @0x50A9F5C
    private static void OnResponse(KammelnaResponseModel<RemoteConfigModel>);  // @0x50AA038
    public static void Apply(RemoteConfigModel model);           // @0x50A9E54
}
```

### مساران للتسليم ✅

| المسار | التفصيل |
|---|---|
| **HTTP** | `GetRemoteConfigRequest.EndPoint` @`0x527309C` = `Config.BackendURL + "api/Config/Game"` |
| **دفع** | `ContentPushService` بالمفتاح **`"remote_config"`** — نفس الخدمة التي تسلّم `mass_events` و`store_item_groups` و`store_home` و`predictions` |

```asm
0x52730CC  add x0, x0, #0x460   "api/Config/Game"
0x52730F8  bl  Config$$get_BackendURL
```

### `RemoteConfigModel` — ١٢ حقلًا ✅ (`dump.cs:126668`)

| الإزاحة | الحقل | النوع |
|---|---|---|
| `0x10` | `Economy` | `EconomyConfig` |
| `0x18` | `Tournaments` | `TournamentsSection` |
| `0x20` | `Predictions` | `PredictionsConfig` |
| `0x28` | `Visuals` | `VisualsConfig` |
| `0x30` | `Chat` | `ChatConfig` |
| `0x38` | `AutoClickers` | `AutoClickersConfig` |
| `0x40` | `GiftBomb` | `GiftBombConfig` |
| `0x48` | `FriendlyChallenge` | `FriendlyChallengeConfig` |
| `0x50` | **`Jackaroo`** | `JackarooConfig` *(`[JsonProperty(NullValueHandling=1)]`)* |
| `0x58` | `FastTrack` | `FastTrackConfig` *(`[JsonProperty(NullValueHandling=1)]`)* |
| `0x60` | `Clans` | `ClanConfigsResponse` |
| `0x68` | `SubscriberCategoryDiscounts` | `Dictionary<ItemCategory, int>` |

> ⚠️ **`DEFAULTS` ليس كائنًا مُعبّأ يدويًّا**: `.cctor` @`0x50AA204` ينفّذ `new RemoteConfigModel()` فقط.
> والبانِي @`0x5186978` يُنشئ **كل** الأقسام الفرعية **عدا `Clans`** — فهذا يبقى `null` حتى يصل الخادم.
> فالافتراضيات الحقيقية هي ما تخبزه بواني الأقسام، وهي أدناه.

---

## ٢. ⭐⭐ `JackarooConfig` — الثغرة المُغلقة

```asm
Server.Models.JackarooConfig$$.ctor @0x5186EF0 (20B)
  adrp x8, #0x7253000
  ldr  d0, [x8, #0x200]        ; ٨ بايت في 0x7253200
  str  d0, [x0, #0x10]         ; → MinMarbleMoveDuration@0x10 + MaxMarbleMoveDuration@0x14
```
```
0x7253200:  9a 99 99 3e | 00 00 20 40
            = 0.3f        = 2.5f
```

| الحقل | الإزاحة | **الافتراضي** |
|---|---|---|
| `MinMarbleMoveDuration` | `0x10` | **`0.3` ثانية** ✅ |
| `MaxMarbleMoveDuration` | `0x14` | **`2.5` ثانية** ✅ |
| `CustomRulesEnabled` | `0x18` | `false` (غير مكتوب في البانِي) |

> ⭐⭐ هذا يُغلق الثغرة المعلنة في [جكارو ٠٨ §٣](../jackaroo-spec/08-الأنيميشن-حركة-الجلول.md).
> بتعويضها في الصيغة المُثبتة هناك:
>
> ```
> GetDurationForNodes(N) = 0.3 + (N − 1) × (2.5 − 0.3) / 12
>                        = 0.3 + (N − 1) × 0.18333…
> ```
>
> | عدد العقد | المدّة الكلّية | المدّة لكل قفزة |
> |---|---|---|
> | 1 | 0.300 ث | 0.300 |
> | 2 | 0.483 ث | 0.242 |
> | 4 | 0.850 ث | 0.213 |
> | 7 | 1.400 ث | 0.200 |
> | 13 | 2.500 ث | 0.192 |
>
> ⚠️ ولأن `FloatExtensions.Map` **بلا تقييد**، فمسار أطول من ١٣ عقدة يتجاوز ٢.٥ ث خطّيًّا.

---

## ٣. `EconomyConfig` ✅ — كل الافتراضيات مخبوزة

```asm
Server.Models.EconomyConfig$$.ctor @0x5186CAC (44B)
  ldr d0, [0x7253000 + 0x1F0]  → [x0+0x10]     ; 01 00 00 00 | a0 00 00 00
  mov w8, #0xcccd ; movk w8, #0x3d4c, lsl #16  ; 0x3D4CCCCD
  str w8, [x0, #0x18]
  ldr d0, [0x7253000 + 0x1F8]  → [x0+0x1c]     ; 32 00 00 00 | 64 00 00 00
```

| الحقل | الإزاحة | **الافتراضي** |
|---|---|---|
| `MinCurrencySubscriptionDays` | `0x10` | **1** |
| `SubscriptionDayPrice` | `0x14` | **160** آص/يوم |
| `TransferCurrencyFee` | `0x18` | **`0.05`** (٥٪) |
| `CreateRoomPrice` | `0x1C` | **50** آص |
| `CreateVoiceRoomPrice` | `0x20` | **100** آص |

> 📌 يتقاطع مع [الاقتصاد §٣](../economy-spec/01-الاقتصاد-الكامل.md) و[الردهة ٠١ §٢.٤](../lobby-spec/01-البروتوكول-والغرف.md):
> الغرفة العادية **٥٠** والصوتية **١٠٠** — والمشترك معفى، وصاحب ثيم مدفوع معفى من العادية فقط.

---

## ٤. `GiftBombConfig` ✅ (١١ حقلًا)

```asm
Server.Models.GiftBombConfig$$.ctor @0x5185D34 (192B)
  mov  w8, #0x101 ; strh w8, [x19, #0x10]   ; كلا العَلَمين = true
  ldr  d0, [0x7253000+0x1E0] → [x19+0x14]
  … InitializeArray  →  SubShardDays (int[3])
  ldr  q0, [0x7253000+0x220] → [x19+0x28]   ; ١٦ بايت
  ldr  d0, [0x7253000+0x1E8] → [x19+0x38]
```

| الحقل | الإزاحة | **الافتراضي** |
|---|---|---|
| `CurrencyBombEnabled` | `0x10` | **`true`** |
| `SubscriptionBombEnabled` | `0x11` | **`true`** |
| `MinShardPrice` | `0x14` | **400** |
| `MaxShardPrice` | `0x18` | **1,000,000** |
| `SubShardDays` | `0x20` | **`{ 1, 2, 3 }`** ✅ (`global-metadata.dat` @`0xAAA650`) |
| `MinShardCount` | `0x28` | **25** |
| `MaxShardCount` | `0x2C` | **10,000** |
| `MinSubShardCount` | `0x30` | **50** |
| `MaxSubShardCount` | `0x34` | **10,000** |
| `SubBombOneDayAceToSub` | `0x38` | **160** |
| `MinBombActiveSeconds` | `0x3C` | **15** |

> `SubBombOneDayAceToSub = 160` يطابق `SubscriptionDayPrice = 160` بالضبط ✅.

---

## ٥. `FastTrackConfig` ✅

```asm
Server.Models.FastTrackConfig$$.ctor @0x5186F04 (1864B)
  ldr d0, [0x7253000+0x208] → [x19+0x10]    ; 55 00 00 00 | 0a 00 00 00
```

| الحقل | الإزاحة | **الافتراضي** |
|---|---|---|
| `TicketPrice` | `0x10` | **85** |
| `MaxWaitingTimeSeconds` | `0x14` | **10** |
| `LevelStages` | `0x18` | `List<List<int>>` — قائمتان ↓ |

**عتبات المراحل** — مقروءة من الثوابت المباشرة في البانِي ✅:

```
المرحلة ١:  1001 · 2501 · 4001 · 6001 · 8001 · 10500
المرحلة ٢:  12501 · 15001 · 17501 · 20001 · 25001 · 30001 · 35001 · 40001
```

---

## ٦. `FriendlyChallengeConfig` ✅ (٩ حقول)

```asm
Server.Models.FriendlyChallengeConfig$$.ctor @0x5185B80 (260B)
  ldr d0, [0x7253000+0x1D8] → [x19+0x14]        ; d0 07 00 00 | 02 00 00 00
  mov x8, #0x3E8 ; movk #0x999a,lsl32 ; movk #0x3e99,lsl48 → [x19+0x1c]
  ldr d0, [0x7175000+0x5D8] → [x19+0x24]        ; 03 00 00 00 | 01 00 00 00
  fmov d0, #7.0 ; bl TimeSpan$$FromDays ; get_TotalSeconds → [x19+0x30] و[x19+0x38]
```

| الحقل | الإزاحة | **الافتراضي** |
|---|---|---|
| `Enabled` | `0x10` | `false` (غير مكتوب) |
| `FixedFee` | `0x14` | **2000** |
| `PrizeCondition` | `0x18` | **2** |
| `MinimumPrize` | `0x1C` | **1000** |
| `PercentageFee` | `0x20` | **`0.3`** (٣٠٪) |
| `MaxScore` | `0x24` | **3** |
| `BestOf` | `0x28` | **1** |
| `ScoreLifetimeSeconds` | `0x30` | **604,800** (٧ أيام) |
| `LockDurationSeconds` | `0x38` | **604,800** (٧ أيام) |

---

## ٧. `ChatConfig` · `AutoClickersConfig` · `VisualsConfig` ✅

```asm
ChatConfig$$.ctor @0x5186ED8 (16B):        mov w8,#1 ; strb w8,[x0,#0x10]
AutoClickersConfig$$.ctor @0x5186EE8 (8B): — لا شيء —
VisualsConfig$$.ctor @0x5186E74 (100B):    str <string>, [x19+0x18]
```

| القسم | الحقل | الإزاحة | الافتراضي |
|---|---|---|---|
| `ChatConfig` | `IsPublicChatSubsLocked` | `0x10` | **`true`** ⭐ الدردشة العامة مقفلة على المشتركين افتراضيًّا |
| | `IsChatBotEnabled` | `0x11` | `false` |
| `AutoClickersConfig` | `ClicksPeriod` | `0x10` | **0** |
| | `MaxAllowedClicksPerPeriod` | `0x14` | **0** |
| | `DeleteCredentials` | `0x18` | `false` |
| `VisualsConfig` | `IsEid` | `0x10` | `false` |
| | `MiniGameButtonImage` | `0x18` | سلسلة ثابتة |

> ⚠️ `AutoClickersConfig` **صفريّ بالكامل** — كاشف النقر الآليّ **معطّل** حتى يُرسل الخادم قيمًا.

---

## ٨. `TournamentsSection` ✅ (٧ حقول)

| الحقل | الإزاحة | النوع |
|---|---|---|
| `SubscribersDiscount` | `0x10` | int |
| `NonSubscribersDiscount` | `0x14` | int |
| `OfficialEndTime` | `0x18` | DateTime |
| `MassTutorialUrl` | `0x20` | string |
| `Public` | `0x28` | `TournamentConfig` |
| `Private` | `0x30` | `TournamentConfig` |
| `_addons` | `0x38` | `TournamentAddonConfig` |

### `TournamentConfig` (١٣ حقلًا) ✅

| الحقل | الإزاحة | النوع | ملاحظة |
|---|---|---|---|
| `FixedFee` | `0x10` | `int[][]` | |
| `CreationFee` | `0x18` | float | |
| `AllowedSizes` | `0x20` | `int[][]` | |
| `MaxStartTime` | `0x28` | int | |
| `InstantTournamentStartTime` | `0x2C` | int | |
| `CreationAllowed` | `0x30` | bool | |
| `TournamentPrizeCondition` | `0x34` | `PrizeCondition` | |
| `AllowedSizesWire` | `0x38` | `Dictionary<int,int>` | **صيغة السلك** |
| `FixedFeesWire` | `0x40` | `Dictionary<int,int>` | **صيغة السلك** |
| `MaxStartTimeWire` | `0x48` | TimeSpan | |
| `InstantStartTimeWire` | `0x50` | TimeSpan | |
| `_acesMinPrizeBySize` | `0x58` | `Dictionary<int,int>` | مُشتقّ |
| `_fixedFeePriceBySize` | `0x60` | `Dictionary<int,int>` | مُشتقّ |

> ⭐ الأزواج `…Wire` هي ما يُرسَل فعلًا؛ والحقول غير الـ`Wire` مُشتقّة منها في العميل.

`TournamentAddonConfig`: حقل واحد `Price` @`0x14`.

---

## ٩. `ClanConfigsResponse` ✅ (١٥ حقلًا) — **الوحيد الذي يبقى `null` افتراضيًّا**

| الحقل | الإزاحة | النوع |
|---|---|---|
| `CreationCost` | `0x10` | int |
| `RenewalCost` | `0x14` | int |
| `PaidAnnouncementCost` | `0x18` | int |
| `InterClanTopXCount` | `0x1C` | int |
| `CreationPeriodDays` | `0x20` | int |
| `RenewalPeriodDays` | `0x24` | int |
| `GracePeriodDays` | `0x28` | int |
| `SubscriptionWarningLeadTimeDays` | `0x2C` | int |
| `RollbackDays` | `0x30` | int |
| `XpGainMode` | `0x34` | `ClanXpGainMode` |
| `XpGainValue` | `0x38` | float |
| `Tiers` | `0x40` | `List<ClanTierConfig>` |
| `SupportTiers` | `0x48` | `List<ClanSupportTierConfig>` |
| `VaultVisualTiers` | `0x50` | `List<ClanVaultVisualTierConfig>` |
| `EmblemColorPresets` | `0x58` | `List<string>` |

```csharp
enum ClanXpGainMode { FixedValue = 0, RelativeToRankPoints = 1 }         // ✅
class ClanTierConfig            { int Tier@0x10; int XpThreshold@0x14; int MaxMembers@0x18; int EmblemUpgradeCost@0x1C; }
class ClanSupportTierConfig     { VaultSupportTier Tier@0x10; int Threshold@0x14; }
class ClanVaultVisualTierConfig { ClanVaultVisualTier Tier@0x10; int Threshold@0x14; }
```

> ⚠️ **`Clans` وحده لا يُنشأ في بانِي `RemoteConfigModel`** ⇒ يبقى `null` حتى يصل الخادم.
> أي كود يقرأ `RemoteConfig.Current.Clans` قبل الاستجابة **يرمي `NullReferenceException`**.

---

## ١٠. `PredictionsConfig` ✅ (٩ حقول)

`SeasonCorrectScorePoints`@`0x10` · `SeasonCorrectWinnerPoints`@`0x14` ·
`TopPrizeShowRewardsText`@`0x18` · ثم ستّ سلاسل صور للزرّ:
`PredictAndWinButtonImage`@`0x20` · `…IconImage`@`0x28` · `…TextImage`@`0x30`
ونظائرها للتابلت `…Tablet`@`0x38`/`0x40`/`0x48`.

---

## ١١. جدول الأرقام الجاهزة للبناء

| القيمة | الافتراضي | أين تؤثّر |
|---|---|---|
| `MinMarbleMoveDuration` | **0.3 ث** | كل حركة جلّة في جكارو |
| `MaxMarbleMoveDuration` | **2.5 ث** | مسار ١٣ عقدة |
| `CreateRoomPrice` | **50** | إنشاء غرفة |
| `CreateVoiceRoomPrice` | **100** | إنشاء غرفة صوتية |
| `SubscriptionDayPrice` | **160** | شراء اشتراك بالآص |
| `TransferCurrencyFee` | **5٪** | تحويل الآص |
| `FastTrack.TicketPrice` | **85** | تذكرة المسار السريع |
| `FastTrack.MaxWaitingTimeSeconds` | **10** | انتظار المطابقة |
| `FriendlyChallenge.PercentageFee` | **30٪** | رسوم التحدّي |
| `FriendlyChallenge.*LifetimeSeconds` | **604800** | صلاحية النتيجة والقفل |
| `GiftBomb.MinBombActiveSeconds` | **15** | مدّة القنبلة |
| `Chat.IsPublicChatSubsLocked` | **true** | قفل الدردشة العامة |

---

## ١٢. ما لم يُحسَم — ✅ أُغلق أكثره (٢٧ سبتمبر ٢٠٢٦)

* ~~`VisualsConfig.MiniGameButtonImage`.~~ ✅ **سلسلة فارغة `""`** مخبوزةً.
* ~~بواني `TournamentConfig` · `PredictionsConfig` · `TournamentsSection`.~~ ✅ **مفكوكة كاملةً**:
  * **`TournamentConfig`** @`0x5187718`: `FixedFee = {{8,2000},{16,4000},{32,8000}}` ·
    `CreationFee = 0.1f` · `AllowedSizes = {{8,30000},{16,40000},{32,50000}}` (جدول **حجم ← أدنى جائزة** لا قائمة أحجام) ·
    `MaxStartTime = 21600` · `InstantStart = 15` · 🚩 **`CreationAllowed = false`** · كلّ حقول السلك `null`/`Zero` ·
    القاموسان يُبنيان في `RebuildLookups` @`0x518A484`.
  * **`PredictionsConfig`** @`0x5186DAC`: `5` · `1` · `true` · ستّ سلاسل `""`.
  * **`TournamentsSection`** @`0x5186CD8`: `SubscribersDiscount = 140` · `MassTutorialUrl = null` (الوحيد) · الأبناء الثلاثة يُنشَؤون.
* ⚠️ **تعارضٌ يحتاج فضًّا لاحقًا حول افتراضيّ شرط الجائزة**:
  * هذا الأرشيف يوثّق (من `TournamentPrizeEditView.GetValidationModel` @`0x502E510`) أنّ **المرصود `Disallowed = 2`**.
  * ووكيل الجولة الثانية يقرأ من بانٍ آخر أنّ الافتراضيّ **`Required = 0`**.
  * الموضعان مختلفان (تحقّق واجهة مقابل بانٍ)، فقد لا يتعارضان فعلًا. **لم يُفضّ بعد** — 🟡 يبقى مفتوحًا.
  * والتعداد نفسه مؤكَّد: `{ Required = 0, Optional = 1, Disallowed = 2 }`.
* ~~`ClanVaultVisualTier` و`VaultSupportTier`.~~ 🟡 لم يُبلَّغ عنهما في هذه الجولة — يبقيان مفتوحَين.

---

[↩ الفهرس](README.md)
