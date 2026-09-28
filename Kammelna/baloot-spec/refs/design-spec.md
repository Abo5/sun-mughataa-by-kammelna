# مواصفة التصميم البصري — البلوت

> **ما هذا**: كل عنصر رسومي في شاشة البلوت مع اسم صورته، أبعادها الأصلية، حدود التمدّد (9-slice)،
> نوع الرسم، ولون الصبغة. هذه **قائمة تسليم لمصمّمك**: يرسم بدائل أصلية بنفس الأبعاد والسلوك.

> الرسومات نفسها غير مُصدَّرة عمدًا — نسختك بهوية مختلفة تحتاج رسمًا أصليًا أصلًا.

## ١. كيف تقرأ الجدول

| العمود | المعنى |
|---|---|
| **الصورة** | اسم الأصل في أطلس اللعبة |
| **الأبعاد** | المقاس الأصلي بالبكسل — ارسم بديلك بنفسه |
| **9-slice** | `[يسار, أسفل, يمين, أعلى]` المناطق الثابتة عند التمدّد · `—` تُرسم كما هي |
| **النوع** | `Simple` · `Sliced` (9-slice) · `Filled` (تعبئة) · `Tiled` (تكرار) |
| **الصبغة** | لون يُضرب في الصورة · `#FFFFFF` = بلا تغيير |
| **لمس** | هل العنصر يستقبل النقر (RaycastTarget) |



## ١.٥ نظام التصميم — العائلات القابلة لإعادة الاستخدام

> ⭐ **أهم اكتشاف تصميمي**: الواجهة كلها مبنية من **عدد صغير من الأشكال** تتكرّر بألوان
> ومقاسات مختلفة. ارسم العائلة مرة واحدة بهويتك، وكرّرها — تغطّي الشاشة كاملة.

### أكثر الصور استخدامًا

| الصورة | مرات | الأبعاد | 9-slice | الدور |
|---|---|---|---|---|
| `grey_button_2` | 102 | 170×180 | `[50.0, 50.0, 50.0, 50.0]` | **الزر القياسي** — الأكثر استخدامًا في اللعبة كلها |
| `white_alpha_notch_4` | 56 | 179×86 | `[35.0, 53.0, 36.0, 14.0]` | شارة/لصيقة بزاوية مقطوعة |
| `circle_white_panel_7` | 36 | 245×245 | — | إطار أفاتار دائري |
| `circle_white_panel_8` | 31 | 262×262 | — | إطار أفاتار دائري (أكبر) |
| `avatar_default` | 31 | 100×100 | — | صورة افتراضية للاعب |
| `club_2` | 21 | 41×41 | — | رمز نوع |
| `ring_yellow_blackBorders` | 18 | 132×132 | — | حلقة المؤقّت |
| `ring_black` | 18 | 135×135 | — | خلفية حلقة المؤقّت |
| `subrank_second` | 16 | 32×8 | — | مرتبة فرعية |
| `subrank_third` | 16 | 32×8 | — | مرتبة فرعية |
| `white_alpha_notch_3` | 16 | 84×72 | `[27.0, 32.0, 25.0, 12.0]` | — |
| `swipe` | 16 | 66×92 | — | مؤشّر السحب |
| `subrank_fourth` | 16 | 32×8 | — | مرتبة فرعية |
| `subrank_first` | 16 | 32×8 | — | مرتبة فرعية |
| `ring_yellow` | 16 | 106×106 | — | — |
| `darkGrey_gradient_notch_6` | 12 | 1024×251 | `[64.5, 0.0, 93.9, 227.3]` | شريط علوي متدرّج (عرض كامل 1024) |
| `white_silverBorders_panel_2` | 12 | 134×73 | `[10.0, 10.0, 10.0, 10.0]` | — |
| `darkGrey_deep_4` | 12 | 314×314 | `[50.0, 50.0, 50.0, 50.0]` | لوحة غائرة |
| `diamond_2` | 11 | 39×41 | — | رمز نوع |
| `heart_6` | 11 | 47×37 | — | رمز نوع |
| `spade_2` | 11 | 40×37 | — | رمز نوع |
| `circle_black_panel` | 10 | 132×141 | — | ظل الأفاتار |

### العائلات (نفس الشكل — ألوان/مقاسات مختلفة)

| العائلة | عدد المتغيّرات | الأمثلة |
|---|---|---|
| **panel** | 7 | `black_panel`, `brightBlue_panel`, `brown_panel`, `darkGrey_panel_6`, `white_panel_21`, `white_panel_4`, `yellow_panel` |
| **button** | 6 | `green_button_2`, `green_button_8`, `grey_button_2`, `grey_button_4`, `grey_button_5`, `red_button_5` |
| **deep** | 5 | `darkGrey_deep`, `darkGrey_deep_2`, `darkGrey_deep_3`, `darkGrey_deep_4`, `darkGrey_deep_5` |
| **heart** | 5 | `heart`, `heart_10`, `heart_6`, `heart_7`, `heart_8` |
| **diamond** | 4 | `diamond`, `diamond_2`, `diamond_4`, `diamond_6` |
| **notch** | 4 | `darkGrey_notch`, `darkGrey_notch_2`, `white_notch`, `white_notch_3` |
| **club** | 4 | `club`, `club_2`, `club_4`, `club_6` |
| **spade** | 4 | `spade`, `spade_2`, `spade_4`, `spade_6` |
| **alpha_notch** | 4 | `white_alpha_notch`, `white_alpha_notch_3`, `white_alpha_notch_4`, `yellow_alpha_notch` |
| **ring_yellow** | 3 | `ring_yellow`, `ring_yellow_2`, `ring_yellow_3` |
| **circle_white_panel** | 3 | `circle_white_panel_6`, `circle_white_panel_7`, `circle_white_panel_8` |
| **gradient_notch** | 3 | `darkGrey_gradient_notch`, `darkGrey_gradient_notch_2`, `darkGrey_gradient_notch_6` |
| **alpha_deep** | 3 | `brown_alpha_deep_6`, `darkGrey_alpha_deep_6`, `white_alpha_deep` |

### قائمة الرسم المختصرة لمصمّمك

| # | الأصل المطلوب | المقاس | ملاحظة |
|---|---|---|---|
| 1 | زر قياسي (9-slice) | 170×180 | حدود `[50,50,50,50]` — يُستخدم 102 مرة |
| 2 | زر عريض للتأكيد | 899×184 | حدود `[80,80,80,80]` |
| 3 | لوحة بنية كبيرة | 841×553 | حدود `[135,140,135,130]` |
| 4 | لوحة غائرة | 314×314 | حدود `[50,50,50,50]` |
| 5 | شارة بزاوية مقطوعة | 179×86 | حدود `[35,53,36,14]` |
| 6 | إطار أفاتار دائري | 245×245 و 262×262 | بلا 9-slice |
| 7 | حلقة مؤقّت | 132×132 + 135×135 | `Filled · Radial360` |
| 8 | رموز الأنواع الأربعة | 128×128 تقريبًا | بثلاثة مقاسات: ~40، ~47، ~128 |
| 9 | شريط علوي متدرّج | 1024×251 | حدود `[64,0,94,227]` |
| 10 | مراتب فرعية | 32×8 | أربع حالات |

## ٢-phone. عناصر الصور  (452 عنصر · 137 منها 9-slice)

| العنصر | الصورة | الأبعاد | 9-slice | النوع | الصبغة | α | لمس |
|---|---|---|---|---|---|---|---|
| Icon - Close | `arrow_darkGrey_4` | 60×46 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| AvatarPicture | `avatar_default` | 100×100 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| AvatarPicture | `avatar_default` | 100×100 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| AvatarPicture | `avatar_default` | 100×100 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| AvatarPicture | `avatar_default` | 100×100 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| AvatarPicture | `avatar_default` | 100×100 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| AvatarPicture | `avatar_default` | 100×100 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| AvatarPicture | `avatar_default` | 100×100 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| AvatarPicture | `avatar_default` | 100×100 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| AvatarPicture | `avatar_default` | 100×100 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| AvatarPicture | `avatar_default` | 100×100 | — | Simple | `#FFFFFF` | 1.00 | — |
| AvatarPicture | `avatar_default` | 100×100 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| AvatarPicture | `avatar_default` | 100×100 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| AvatarPicture | `avatar_default` | 100×100 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Game Bubble | `black_oneCorner_panel` | 202×138 | `[52.0, 52.0, 47.0, 42.0]` | Sliced | `#FFFFFF` | 0.81 | — |
| Game Bubble | `black_oneCorner_panel` | 202×138 | `[52.0, 52.0, 47.0, 42.0]` | Sliced | `#FFFFFF` | 0.81 | — |
| Game Bubble | `black_oneCorner_panel` | 202×138 | `[52.0, 52.0, 47.0, 42.0]` | Sliced | `#FFFFFF` | 0.81 | — |
| Game Bubble | `black_oneCorner_panel` | 202×138 | `[52.0, 52.0, 47.0, 42.0]` | Sliced | `#FFFFFF` | 0.81 | — |
| Game Bubble | `black_oneCorner_panel` | 202×138 | `[52.0, 52.0, 47.0, 42.0]` | Sliced | `#FFFFFF` | 0.81 | — |
| Text Background | `brown_alpha_deep_6` | 184×141 | `[41.0, 50.0, 35.0, 38.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Background | `brown_greyBorders_panel` | 685×683 | `[82.0, 88.0, 83.0, 156.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Room Loading | `brown_greyBorders_panel` | 827×783 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Background | `brown_panel` | 841×553 | `[135.0, 140.0, 135.0, 130.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Icon | `chat_black_2` | 69×60 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Icon | `chat_black_2` | 69×60 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Timer | `circle_alpha_black_cover` | 84×84 | — | Simple | `#000000` | 1.00 | — |
| Timer | `circle_alpha_black_cover` | 84×84 | — | Simple | `#000000` | 1.00 | ✓ |
| Avatar Shadow | `circle_black_panel` | 132×141 | — | Simple | `#FFFFFF` | 0.57 | — |
| AvatarShadow | `circle_black_panel` | 132×141 | — | Simple | `#FFFFFF` | 0.49 | — |
| AvatarShadow | `circle_black_panel` | 132×141 | — | Simple | `#FFFFFF` | 0.49 | — |
| AvatarShadow | `circle_black_panel` | 132×141 | — | Simple | `#FFFFFF` | 0.49 | — |
| AvatarShadow | `circle_black_panel` | 132×141 | — | Simple | `#FFFFFF` | 0.49 | — |
| Chat Bubble | `circle_red_whiteBorder_panel` | 55×55 | `[27.0, 27.0, 27.0, 27.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Chat Bubble | `circle_red_whiteBorder_panel` | 55×55 | `[27.0, 27.0, 27.0, 27.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Counter Base | `circle_white_panel_6` | 42×42 | — | Simple | `#A30000` | 1.00 | ✓ |
| BG | `circle_white_panel_7` | 245×245 | — | Simple | `#5B4C3D` | 1.00 | ✓ |
| BG | `circle_white_panel_7` | 245×245 | — | Simple | `#5B4C3D` | 1.00 | ✓ |
| BG | `circle_white_panel_7` | 245×245 | — | Simple | `#5B4C3D` | 1.00 | ✓ |
| BG | `circle_white_panel_7` | 245×245 | — | Simple | `#5B4C3D` | 1.00 | ✓ |
| BG | `circle_white_panel_7` | 245×245 | — | Simple | `#5B4C3D` | 1.00 | ✓ |
| BG | `circle_white_panel_7` | 245×245 | — | Simple | `#5B4C3D` | 1.00 | ✓ |
| BG | `circle_white_panel_7` | 245×245 | — | Simple | `#5B4C3D` | 1.00 | ✓ |
| BG | `circle_white_panel_7` | 245×245 | — | Simple | `#5B4C3D` | 1.00 | ✓ |
| Timer | `circle_white_panel_7` | 245×245 | — | Simple | `#000000` | 0.34 | — |
| Timer | `circle_white_panel_7` | 245×245 | — | Simple | `#000000` | 0.34 | — |
| Timer | `circle_white_panel_7` | 245×245 | — | Simple | `#000000` | 0.34 | — |
| Timer | `circle_white_panel_7` | 245×245 | — | Simple | `#000000` | 0.34 | — |
| Timer | `circle_white_panel_7` | 245×245 | — | Simple | `#000000` | 0.34 | — |
| Timer | `circle_white_panel_7` | 245×245 | — | Simple | `#000000` | 0.89 | — |
| Timer | `circle_white_panel_7` | 245×245 | — | Simple | `#000000` | 0.34 | — |
| Timer | `circle_white_panel_7` | 245×245 | — | Simple | `#000000` | 0.34 | — |
| Timer | `circle_white_panel_7` | 245×245 | — | Simple | `#000000` | 0.34 | — |
| Timer | `circle_white_panel_7` | 245×245 | — | Simple | `#000000` | 0.34 | — |
| Avatar image holder | `circle_white_panel_8` | 262×262 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Avatar image holder | `circle_white_panel_8` | 262×262 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Avatar image holder | `circle_white_panel_8` | 262×262 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Avatar image holder | `circle_white_panel_8` | 262×262 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Avatar image holder | `circle_white_panel_8` | 262×262 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Avatar image holder | `circle_white_panel_8` | 262×262 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Avatar image holder | `circle_white_panel_8` | 262×262 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Avatar image holder | `circle_white_panel_8` | 262×262 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Avatar image holder | `circle_white_panel_8` | 262×262 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Avatar image holder | `circle_white_panel_8` | 262×262 | — | Simple | `#FFFFFF` | 1.00 | — |
| Avatar image holder | `circle_white_panel_8` | 262×262 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Avatar image holder | `circle_white_panel_8` | 262×262 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Avatar image holder | `circle_white_panel_8` | 262×262 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Subrank 2 | `club` | 35×35 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Suit | `club_2` | 41×41 | — | Simple | `#FFFFFF` | 1.00 | — |
| Suit | `club_2` | 41×41 | — | Simple | `#FFFFFF` | 1.00 | — |
| Suit | `club_2` | 41×41 | — | Simple | `#FFFFFF` | 1.00 | — |
| Suit | `club_2` | 41×41 | — | Simple | `#FFFFFF` | 1.00 | — |
| Suit | `club_2` | 41×41 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| club | `club_2` | 41×41 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| club | `club_2` | 41×41 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| club | `club_2` | 41×41 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| club | `club_2` | 41×41 | — | Simple | `#FFFFFF` | 1.00 | — |
| club | `club_2` | 41×41 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Icon | `club_4` | 27×30 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Club | `club_6` | 121×128 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Club | `club_6` | 121×128 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Clubs_Border | `club_border` | 121×128 | — | Filled · Radial360 | `#FFFFFF` | 1.00 | ✓ |
| Clubs_Border | `club_border` | 121×128 | — | Filled · Radial360 | `#FFFFFF` | 1.00 | ✓ |
| OwnerBadge | `crown_2` | 54×51 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| OwnerBadge | `crown_2` | 54×51 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| OwnerBadge | `crown_2` | 54×51 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| OwnerBadge | `crown_2` | 54×51 | — | Simple | `#FFFFFF` | 1.00 | — |
| OwnerBadge | `crown_2` | 54×51 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| lit background | `darkGreen_deep` | 105×106 | `[15.0, 15.0, 15.0, 15.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Background | `darkGrey_15pt_panel` | 611×611 | `[80.0, 70.0, 80.0, 80.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Background | `darkGrey_15pt_panel` | 611×611 | `[80.0, 70.0, 80.0, 80.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Background | `darkGrey_15pt_panel` | 611×611 | `[80.0, 70.0, 80.0, 80.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| BroadcastMessageBox | `darkGrey_15pt_panel` | 611×611 | `[80.0, 70.0, 80.0, 80.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Inner | `darkGrey_alpha_cover` | 222×43 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Coins | `darkGrey_alpha_deep_6` | 302×300 | `[40.0, 40.0, 40.0, 40.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Price | `darkGrey_alpha_deep_6` | 302×300 | `[40.0, 40.0, 40.0, 40.0]` | Sliced | `#FFFFFF` | 0.81 | ✓ |
| solid background | `darkGrey_deep_2` | 105×106 | `[15.0, 15.0, 15.0, 15.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Description | `darkGrey_deep_4` | 314×314 | `[50.0, 50.0, 50.0, 50.0]` | Sliced | `#FFFFFF` | 0.78 | ✓ |
| Gift List Mask | `darkGrey_deep_4` | 314×314 | `[50.0, 50.0, 50.0, 50.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Gifts Panel | `darkGrey_deep_4` | 314×314 | `[50.0, 50.0, 50.0, 50.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Players Panel | `darkGrey_deep_4` | 314×314 | `[50.0, 50.0, 50.0, 50.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Deep | `darkGrey_deep_5` | 585×138 | `[70.0, 50.0, 70.0, 40.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Inner | `darkGrey_deep_5` | 585×138 | `[70.0, 50.0, 70.0, 40.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Background | `darkGrey_gradient_notch` | 1080×564 | `[72.0, 24.0, 79.0, 525.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Bidding Baloot | `darkGrey_gradient_notch` | 1080×564 | `[72.0, 24.0, 79.0, 525.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Background | `darkGrey_gradient_notch_6` | 1024×251 | `[64.5, 0.0, 93.9, 227.3]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Background | `darkGrey_gradient_notch_6` | 1024×251 | `[64.5, 0.0, 93.9, 227.3]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Choose Project | `darkGrey_gradient_notch_6` | 1024×251 | `[64.5, 0.0, 93.9, 227.3]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Idle blocker | `darkGrey_gradient_notch_6` | 1024×251 | `[64.5, 0.0, 93.9, 227.3]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Kasho Button | `darkGrey_gradient_notch_6` | 1024×251 | `[64.5, 0.0, 93.9, 227.3]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| panel | `darkGrey_gradient_notch_6` | 1024×251 | `[64.5, 0.0, 93.9, 227.3]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Username - Base | `darkGrey_notch_2` | 297×69 | `[28.0, 30.0, 28.0, 6.0]` | Simple | `#FFFFFF` | 1.00 | ✓ |
| Dealer Icon | `dealer` | 32×37 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Dealer icon | `dealer` | 32×37 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Dealer icon | `dealer` | 32×37 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Dealer icon | `dealer` | 32×37 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Dealer icon | `dealer` | 32×37 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Background | `defaultRoomTheme_gamePlay` | 1080×1921 | — | Simple | `#FFFFFF` | 1.00 | — |
| Room Theme | `defaultRoomTheme_gamePlay` | 1080×1921 | — | Simple | `#FFFFFF` | 1.00 | — |
| Userbox Dimming Background | `defaultRoomTheme_gamePlay` | 1080×1921 | — | Simple | `#FFFFFF` | 0.68 | — |
| Subrank 1 | `diamond` | 35×35 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| diamond | `diamond_2` | 39×41 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| diamond | `diamond_2` | 39×41 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| diamond | `diamond_2` | 39×41 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| diamond | `diamond_2` | 39×41 | — | Simple | `#FFFFFF` | 1.00 | — |
| diamond | `diamond_2` | 39×41 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Icon | `diamond_4` | 29×29 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Diamond | `diamond_6` | 115×128 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Diamond | `diamond_6` | 115×128 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Diamond_Border | `diamond_border` | 114×128 | — | Filled · Radial360 | `#FFFFFF` | 1.00 | ✓ |
| Diamond_Border | `diamond_border` | 114×128 | — | Filled · Radial360 | `#FFFFFF` | 1.00 | ✓ |
| Mask | `fill_gradient_yellow_red` | 237×6 | — | Filled · Horizontal | `#000000` | 1.00 | ✓ |
| PlayerVoice indicator | `fill_gradient_yellow_red` | 237×6 | — | Filled · Horizontal | `#FFFFFF` | 1.00 | ✓ |
| fire_logo | `fire_lit` | 49×66 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Icon | `fire_unlit` | 49×66 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Gift | `gift_6` | 54×62 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Icon | `gift_White` | 44×44 | — | Simple | `#FFFFFF` | 1.00 | — |
| Icon | `gift_White` | 44×44 | — | Simple | `#FFFFFF` | 1.00 | — |
| Icon | `gift_White` | 44×44 | — | Simple | `#FFFFFF` | 1.00 | — |
| Icon | `gift_White` | 44×44 | — | Simple | `#FFFFFF` | 1.00 | — |
| Gift icon | `gift_darkBlack` | 92×88 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Icon | `gift_darkBlack` | 92×88 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Icon | `gift_grey` | 53×53 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Coins_icon | `goldenCards_8` | 246×256 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Icon | `goldenCards_8` | 246×256 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Icon | `goldenCards_lv1` | 168×95 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Button - OK | `green_button_8` | 899×184 | `[80.0, 80.0, 80.0, 80.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Button - 100 | `grey_button_2` | 170×180 | `[50.0, 50.0, 50.0, 50.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Button - 400 | `grey_button_2` | 170×180 | `[50.0, 50.0, 50.0, 50.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Button - 50 | `grey_button_2` | 170×180 | `[50.0, 50.0, 50.0, 50.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Button - Accept | `grey_button_2` | 170×180 | `[50.0, 50.0, 50.0, 50.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Button - Ashkal | `grey_button_2` | 170×180 | `[50.0, 50.0, 50.0, 50.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Button - Automatic Ekka placeholde | `grey_button_2` | 170×180 | `[50.0, 50.0, 50.0, 50.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Button - Before To Sun | `grey_button_2` | 170×180 | `[50.0, 50.0, 50.0, 50.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Button - Cancel | `grey_button_2` | 170×180 | `[50.0, 50.0, 50.0, 50.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Button - Catch | `grey_button_2` | 170×180 | `[50.0, 50.0, 50.0, 50.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Button - Confirm Hokom | `grey_button_2` | 170×180 | `[50.0, 50.0, 50.0, 50.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Button - Double | `grey_button_2` | 170×180 | `[50.0, 50.0, 50.0, 50.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Button - Ekka | `grey_button_2` | 170×180 | `[50.0, 50.0, 50.0, 50.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Button - Four | `grey_button_2` | 170×180 | `[50.0, 50.0, 50.0, 50.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Button - Hokom | `grey_button_2` | 170×180 | `[50.0, 50.0, 50.0, 50.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Button - Hokom 2 | `grey_button_2` | 170×180 | `[50.0, 50.0, 50.0, 50.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Button - Hokom Closed | `grey_button_2` | 170×180 | `[50.0, 50.0, 50.0, 50.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Button - Hokom Clubs | `grey_button_2` | 170×180 | `[50.0, 50.0, 50.0, 50.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Button - Hokom Diamonds | `grey_button_2` | 170×180 | `[50.0, 50.0, 50.0, 50.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Button - Hokom Hearts | `grey_button_2` | 170×180 | `[50.0, 50.0, 50.0, 50.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Button - Hokom Open | `grey_button_2` | 170×180 | `[50.0, 50.0, 50.0, 50.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Button - Hokom Spades | `grey_button_2` | 170×180 | `[50.0, 50.0, 50.0, 50.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Button - Kasho | `grey_button_2` | 170×180 | `[50.0, 50.0, 50.0, 50.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Button - Open Cards | `grey_button_2` | 170×180 | `[50.0, 50.0, 50.0, 50.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Button - Pass | `grey_button_2` | 170×180 | `[50.0, 50.0, 50.0, 50.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Button - Projects | `grey_button_2` | 170×180 | `[50.0, 50.0, 50.0, 50.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Button - Qahwa | `grey_button_2` | 170×180 | `[50.0, 50.0, 50.0, 50.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Button - Refuse | `grey_button_2` | 170×180 | `[50.0, 50.0, 50.0, 50.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Button - Sawa | `grey_button_2` | 170×180 | `[50.0, 50.0, 50.0, 50.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Button - Sawa Confirmation | `grey_button_2` | 170×180 | `[50.0, 50.0, 50.0, 50.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Button - Sira | `grey_button_2` | 170×180 | `[50.0, 50.0, 50.0, 50.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Button - Sit Here | `grey_button_2` | 170×180 | `[50.0, 50.0, 50.0, 50.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Button - Sit Here | `grey_button_2` | 170×180 | `[50.0, 50.0, 50.0, 50.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Button - Sit Here | `grey_button_2` | 170×180 | `[50.0, 50.0, 50.0, 50.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Button - Sit Here | `grey_button_2` | 170×180 | `[50.0, 50.0, 50.0, 50.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Button - Sit Here | `grey_button_2` | 170×180 | `[50.0, 50.0, 50.0, 50.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Button - Sun | `grey_button_2` | 170×180 | `[50.0, 50.0, 50.0, 50.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Button - To Sun | `grey_button_2` | 170×180 | `[50.0, 50.0, 50.0, 50.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Button - Triple | `grey_button_2` | 170×180 | `[50.0, 50.0, 50.0, 50.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Button - Wala | `grey_button_2` | 170×180 | `[50.0, 50.0, 50.0, 50.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Button - Wrong Ekka | `grey_button_2` | 170×180 | `[50.0, 50.0, 50.0, 50.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Button - Wrong Sawa | `grey_button_2` | 170×180 | `[50.0, 50.0, 50.0, 50.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Image | `grey_button_2` | 170×180 | `[50.0, 50.0, 50.0, 50.0]` | Sliced | `#000000` | 0.15 | — |
| Image | `grey_button_2` | 170×180 | `[50.0, 50.0, 50.0, 50.0]` | Sliced | `#000000` | 0.15 | — |
| background | `grey_button_2` | 170×180 | `[50.0, 50.0, 50.0, 50.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Background | `grey_button_5` | 380×150 | `[70.0, 63.0, 70.0, 58.0]` | Sliced | `#FFFFFF` | 1.00 | — |
| Background | `grey_button_5` | 380×150 | `[70.0, 63.0, 70.0, 58.0]` | Sliced | `#FFFFFF` | 1.00 | — |
| Button - Chat | `grey_circle_button` | 187×187 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Button - Chat | `grey_circle_button` | 187×187 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Button - Send to All | `grey_circle_button` | 187×187 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Icon | `grey_circle_gift_button` | 120×120 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Icon | `grey_circle_gift_button` | 120×120 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Icon | `grey_circle_gift_button` | 120×120 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Icon | `grey_circle_gift_button` | 120×120 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Button - Send | `grey_gift_emptySpace_button` | 213×84 | `[45.0, 0.0, 91.0, 0.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Subrank 3 | `heart` | 35×35 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Hearts | `heart_10` | 128×110 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Hearts | `heart_10` | 128×110 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| heart | `heart_6` | 47×37 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| heart | `heart_6` | 47×37 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| heart | `heart_6` | 47×37 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| heart | `heart_6` | 47×37 | — | Simple | `#FFFFFF` | 1.00 | — |
| heart | `heart_6` | 47×37 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Icon | `heart_7` | 31×27 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Hearts_Border | `heart_border` | 128×110 | — | Filled · Radial360 | `#FFFFFF` | 1.00 | ✓ |
| Hearts_Border | `heart_border` | 128×110 | — | Filled · Radial360 | `#FFFFFF` | 1.00 | ✓ |
| Logo | `kammelna_logo` | 676×431 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Mute indicator | `mic_off_2` | 512×530 | — | Simple | `#FFFFFF` | 1.00 | — |
| mute indicator | `mic_off_2` | 512×530 | — | Simple | `#FFFFFF` | 1.00 | — |
| mute indicator | `mic_off_2` | 512×530 | — | Simple | `#FFFFFF` | 1.00 | — |
| mute indicator | `mic_off_2` | 512×530 | — | Simple | `#FFFFFF` | 1.00 | — |
| mute indicator | `mic_off_2` | 512×530 | — | Simple | `#FFFFFF` | 1.00 | — |
| Icon | `profile_White` | 63×62 | — | Simple | `#FFFFFF` | 1.00 | — |
| Icon | `profile_White` | 63×62 | — | Simple | `#FFFFFF` | 1.00 | — |
| Icon | `profile_White` | 63×62 | — | Simple | `#FFFFFF` | 1.00 | — |
| Icon | `profile_White` | 63×62 | — | Simple | `#FFFFFF` | 1.00 | — |
| Icon | `questionMark_lightBulb` | 314×314 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Rank Badge inGame | `rank_0_ingame` | 585×481 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Rank Badge inGame | `rank_0_ingame` | 585×481 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Rank Badge inGame | `rank_0_ingame` | 585×481 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Rank Badge inGame | `rank_0_ingame` | 585×481 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Rank Mini Zats | `rank_1_FTMini` | 72×52 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Avatar image background | `rank_1_circular_rim` | 192×192 | — | Simple | `#FFFFFF` | 1.00 | — |
| Rank Normal Zats | `rank_1_default` | 245×72 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Rank Badge inGame | `rank_1_ingame` | 585×481 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Rank Badge inGame | `rank_1_ingame` | 585×481 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Rank Badge inGame | `rank_1_ingame` | 585×481 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Rank Badge inGame | `rank_1_ingame` | 585×481 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Button - Cancel | `red_button_5` | 380×150 | `[70.0, 63.0, 70.0, 58.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Highlight | `ring_black` | 135×135 | — | Simple | `#FFFFFF` | 1.00 | — |
| Highlight | `ring_black` | 135×135 | — | Simple | `#FFFFFF` | 1.00 | — |
| Highlight | `ring_black` | 135×135 | — | Simple | `#FFFFFF` | 1.00 | — |
| Highlight | `ring_black` | 135×135 | — | Simple | `#FFFFFF` | 1.00 | — |
| Highlight | `ring_black` | 135×135 | — | Simple | `#FFFFFF` | 1.00 | — |
| Highlight | `ring_black` | 135×135 | — | Simple | `#FFFFFF` | 1.00 | — |
| Highlight | `ring_black` | 135×135 | — | Simple | `#FFFFFF` | 1.00 | — |
| Highlight | `ring_black` | 135×135 | — | Simple | `#FFFFFF` | 1.00 | — |
| Highlight | `ring_black` | 135×135 | — | Simple | `#FFFFFF` | 1.00 | — |
| Image | `ring_grey` | 88×88 | — | Simple | `#29FF00` | 1.00 | ✓ |
| Image | `ring_grey` | 88×88 | — | Simple | `#29FF00` | 1.00 | ✓ |
| Image | `ring_grey` | 88×88 | — | Simple | `#29FF00` | 1.00 | ✓ |
| Image | `ring_grey` | 88×88 | — | Simple | `#29FF00` | 1.00 | ✓ |
| Sound indicator | `ring_pattern` | 180×181 | — | Simple | `#FFFFFF` | 1.00 | — |
| Sound indicator | `ring_pattern` | 180×181 | — | Simple | `#FFFFFF` | 1.00 | — |
| Sound indicator | `ring_pattern` | 180×181 | — | Simple | `#FFFFFF` | 1.00 | — |
| Sound indicator | `ring_pattern` | 180×181 | — | Simple | `#FFFFFF` | 1.00 | — |
| Counter Inner Border | `ring_yellow_2` | 42×42 | — | Simple | `#000000` | 0.23 | ✓ |
| Fill | `ring_yellow_3` | 75×75 | — | Filled · Radial360 | `#FFFFFF` | 1.00 | — |
| Fill | `ring_yellow_3` | 75×75 | — | Filled · Radial360 | `#FFFFFF` | 1.00 | ✓ |
| Fill | `ring_yellow_3` | 75×75 | — | Filled · Radial360 | `#FFFFFF` | 1.00 | — |
| Fill base | `ring_yellow_3` | 75×75 | — | Filled · Radial360 | `#787878` | 1.00 | ✓ |
| Fill | `ring_yellow_blackBorders` | 132×132 | — | Filled · Radial360 | `#FFFFFF` | 1.00 | — |
| Fill | `ring_yellow_blackBorders` | 132×132 | — | Filled · Radial360 | `#FFFFFF` | 1.00 | — |
| Fill | `ring_yellow_blackBorders` | 132×132 | — | Filled · Radial360 | `#FFFFFF` | 1.00 | — |
| Fill | `ring_yellow_blackBorders` | 132×132 | — | Filled · Radial360 | `#FFFFFF` | 1.00 | — |
| Fill | `ring_yellow_blackBorders` | 132×132 | — | Filled · Radial360 | `#FFFFFF` | 1.00 | — |
| Fill | `ring_yellow_blackBorders` | 132×132 | — | Filled · Radial360 | `#FFFFFF` | 1.00 | — |
| Fill | `ring_yellow_blackBorders` | 132×132 | — | Filled · Radial360 | `#FFFFFF` | 1.00 | — |
| Fill | `ring_yellow_blackBorders` | 132×132 | — | Filled · Radial360 | `#FFFFFF` | 1.00 | — |
| Fill | `ring_yellow_blackBorders` | 132×132 | — | Filled · Radial360 | `#FFFFFF` | 1.00 | — |
| Sound indicator Glow | `smooth_shine_white_2` | 253×253 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Sound indicator Glow | `smooth_shine_white_2` | 253×253 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Sound indicator Glow | `smooth_shine_white_2` | 253×253 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Sound indicator Glow | `smooth_shine_white_2` | 253×253 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Subrank 4 | `spade` | 35×35 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| spade | `spade_2` | 40×37 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| spade | `spade_2` | 40×37 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| spade | `spade_2` | 40×37 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| spade | `spade_2` | 40×37 | — | Simple | `#FFFFFF` | 1.00 | — |
| spade | `spade_2` | 40×37 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Icon | `spade_4` | 27×27 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Spades | `spade_6` | 124×128 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Spades | `spade_6` | 124×128 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Spades_Border | `spade_border` | 124×128 | — | Filled · Radial360 | `#FFFFFF` | 1.00 | ✓ |
| Spades_Border | `spade_border` | 124×128 | — | Filled · Radial360 | `#FFFFFF` | 1.00 | ✓ |
| Zat | `streak` | 420×585 | — | Simple | `#FFFFFF` | 1.00 | — |
| sup1 | `subrank_first` | 32×8 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| sup1 | `subrank_first` | 32×8 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| sup1 | `subrank_first` | 32×8 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| sup1 | `subrank_first` | 32×8 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| sup1 | `subrank_first` | 32×8 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| sup1 | `subrank_first` | 32×8 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| sup1 | `subrank_first` | 32×8 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| sup1 | `subrank_first` | 32×8 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Subrank 1 | `subrank_first_1` | 12×9 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| sup4 | `subrank_fourth` | 32×8 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| sup4 | `subrank_fourth` | 32×8 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| sup4 | `subrank_fourth` | 32×8 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| sup4 | `subrank_fourth` | 32×8 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| sup4 | `subrank_fourth` | 32×8 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| sup4 | `subrank_fourth` | 32×8 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| sup4 | `subrank_fourth` | 32×8 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| sup4 | `subrank_fourth` | 32×8 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Subrank 4 | `subrank_fourth_1` | 12×9 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| sup2 | `subrank_second` | 32×8 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| sup2 | `subrank_second` | 32×8 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| sup2 | `subrank_second` | 32×8 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| sup2 | `subrank_second` | 32×8 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| sup2 | `subrank_second` | 32×8 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| sup2 | `subrank_second` | 32×8 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| sup2 | `subrank_second` | 32×8 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| sup2 | `subrank_second` | 32×8 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Subrank 2 | `subrank_second_1` | 12×9 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| sup3 | `subrank_third` | 32×8 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| sup3 | `subrank_third` | 32×8 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| sup3 | `subrank_third` | 32×8 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| sup3 | `subrank_third` | 32×8 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| sup3 | `subrank_third` | 32×8 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| sup3 | `subrank_third` | 32×8 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| sup3 | `subrank_third` | 32×8 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| sup3 | `subrank_third` | 32×8 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Subrank 3 | `subrank_third_1` | 12×9 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Gift | `swipe` | 66×92 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Gift | `swipe` | 66×92 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Gift | `swipe` | 66×92 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Gift | `swipe` | 66×92 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Profile | `swipe` | 66×92 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Profile | `swipe` | 66×92 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Profile | `swipe` | 66×92 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Profile | `swipe` | 66×92 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Icon checked | `tick_green_5` | 98×98 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Background | `tick_grey_empty` | 84×84 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Bet | `white_alpha_deep` | 115×40 | `[16.0, 14.0, 16.0, 14.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Double | `white_alpha_deep` | 115×40 | `[16.0, 14.0, 16.0, 14.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Background | `white_alpha_notch` | 703×112 | `[60.0, 40.0, 60.0, 50.0]` | Sliced | `#272727` | 1.00 | — |
| Project 1 | `white_alpha_notch_3` | 84×72 | `[27.0, 32.0, 25.0, 12.0]` | Simple | `#FFFFFF` | 1.00 | — |
| Project 1 | `white_alpha_notch_3` | 84×72 | `[27.0, 32.0, 25.0, 12.0]` | Simple | `#FFFFFF` | 1.00 | — |
| Project 1 | `white_alpha_notch_3` | 84×72 | `[27.0, 32.0, 25.0, 12.0]` | Simple | `#FFFFFF` | 1.00 | — |
| Project 1 | `white_alpha_notch_3` | 84×72 | `[27.0, 32.0, 25.0, 12.0]` | Simple | `#FFFFFF` | 1.00 | — |
| Project 2 | `white_alpha_notch_3` | 84×72 | `[27.0, 32.0, 25.0, 12.0]` | Simple | `#FFFFFF` | 1.00 | — |
| Project 2 | `white_alpha_notch_3` | 84×72 | `[27.0, 32.0, 25.0, 12.0]` | Simple | `#FFFFFF` | 1.00 | — |
| Project 2 | `white_alpha_notch_3` | 84×72 | `[27.0, 32.0, 25.0, 12.0]` | Simple | `#FFFFFF` | 1.00 | — |
| Project 2 | `white_alpha_notch_3` | 84×72 | `[27.0, 32.0, 25.0, 12.0]` | Simple | `#FFFFFF` | 1.00 | — |
| Bet | `white_alpha_notch_4` | 179×86 | `[35.0, 53.0, 36.0, 14.0]` | Sliced | `#FFFFFF` | 1.00 | — |
| Bet | `white_alpha_notch_4` | 179×86 | `[35.0, 53.0, 36.0, 14.0]` | Sliced | `#FFFFFF` | 1.00 | — |
| Bet | `white_alpha_notch_4` | 179×86 | `[35.0, 53.0, 36.0, 14.0]` | Sliced | `#FFFFFF` | 1.00 | — |
| Bet | `white_alpha_notch_4` | 179×86 | `[35.0, 53.0, 36.0, 14.0]` | Sliced | `#FFFFFF` | 1.00 | — |
| GiftsShowcase | `white_alpha_notch_4` | 179×86 | `[35.0, 53.0, 36.0, 14.0]` | Sliced | `#FFFFFF` | 1.00 | — |
| GiftsShowcase | `white_alpha_notch_4` | 179×86 | `[35.0, 53.0, 36.0, 14.0]` | Sliced | `#FFFFFF` | 1.00 | — |
| GiftsShowcase | `white_alpha_notch_4` | 179×86 | `[35.0, 53.0, 36.0, 14.0]` | Sliced | `#FFFFFF` | 1.00 | — |
| GiftsShowcase | `white_alpha_notch_4` | 179×86 | `[35.0, 53.0, 36.0, 14.0]` | Sliced | `#FFFFFF` | 1.00 | — |
| Image | `white_alpha_notch_4` | 179×86 | `[35.0, 53.0, 36.0, 14.0]` | Sliced | `#8EFF4C` | 1.00 | — |
| Image | `white_alpha_notch_4` | 179×86 | `[35.0, 53.0, 36.0, 14.0]` | Sliced | `#FFFFFF` | 1.00 | — |
| Image | `white_alpha_notch_4` | 179×86 | `[35.0, 53.0, 36.0, 14.0]` | Sliced | `#FF8391` | 1.00 | — |
| Image | `white_alpha_notch_4` | 179×86 | `[35.0, 53.0, 36.0, 14.0]` | Sliced | `#F9E606` | 1.00 | ✓ |
| Image | `white_alpha_notch_4` | 179×86 | `[35.0, 53.0, 36.0, 14.0]` | Sliced | `#FF8391` | 1.00 | — |
| Image | `white_alpha_notch_4` | 179×86 | `[35.0, 53.0, 36.0, 14.0]` | Sliced | `#FFFFFF` | 1.00 | — |
| Image | `white_alpha_notch_4` | 179×86 | `[35.0, 53.0, 36.0, 14.0]` | Sliced | `#8EFF4C` | 1.00 | — |
| Image | `white_alpha_notch_4` | 179×86 | `[35.0, 53.0, 36.0, 14.0]` | Sliced | `#FFFFFF` | 1.00 | — |
| Image | `white_alpha_notch_4` | 179×86 | `[35.0, 53.0, 36.0, 14.0]` | Sliced | `#FFFFFF` | 1.00 | — |
| Image | `white_alpha_notch_4` | 179×86 | `[35.0, 53.0, 36.0, 14.0]` | Sliced | `#F9E606` | 1.00 | ✓ |
| Image | `white_alpha_notch_4` | 179×86 | `[35.0, 53.0, 36.0, 14.0]` | Sliced | `#FFFFFF` | 1.00 | — |
| Image | `white_alpha_notch_4` | 179×86 | `[35.0, 53.0, 36.0, 14.0]` | Sliced | `#FF8391` | 1.00 | — |
| Image | `white_alpha_notch_4` | 179×86 | `[35.0, 53.0, 36.0, 14.0]` | Sliced | `#FFFFFF` | 1.00 | — |
| Image | `white_alpha_notch_4` | 179×86 | `[35.0, 53.0, 36.0, 14.0]` | Sliced | `#FFFFFF` | 1.00 | — |
| Image | `white_alpha_notch_4` | 179×86 | `[35.0, 53.0, 36.0, 14.0]` | Sliced | `#FFFFFF` | 1.00 | — |
| Image | `white_alpha_notch_4` | 179×86 | `[35.0, 53.0, 36.0, 14.0]` | Sliced | `#FF8391` | 1.00 | — |
| Image | `white_alpha_notch_4` | 179×86 | `[35.0, 53.0, 36.0, 14.0]` | Sliced | `#F9E606` | 1.00 | ✓ |
| Image | `white_alpha_notch_4` | 179×86 | `[35.0, 53.0, 36.0, 14.0]` | Sliced | `#8EFF4C` | 1.00 | — |
| Image | `white_alpha_notch_4` | 179×86 | `[35.0, 53.0, 36.0, 14.0]` | Sliced | `#8EFF4C` | 1.00 | — |
| Image | `white_alpha_notch_4` | 179×86 | `[35.0, 53.0, 36.0, 14.0]` | Sliced | `#F9E606` | 1.00 | ✓ |
| Title | `white_notch_3` | 409×107 | `[52.0, 52.0, 53.0, 18.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Layout | `white_oneCorner_panel` | 202×138 | `[45.0, 52.0, 46.0, 37.0]` | Sliced | `#FFFFFF` | 1.00 | — |
| Layout | `white_oneCorner_panel` | 202×138 | `[45.0, 52.0, 46.0, 37.0]` | Sliced | `#FFFFFF` | 1.00 | — |
| Layout | `white_oneCorner_panel` | 202×138 | `[45.0, 52.0, 46.0, 37.0]` | Sliced | `#FFFFFF` | 1.00 | — |
| Layout | `white_oneCorner_panel` | 202×138 | `[45.0, 52.0, 46.0, 37.0]` | Sliced | `#FFFFFF` | 1.00 | — |
| Layout | `white_oneCorner_panel` | 202×138 | `[45.0, 52.0, 46.0, 37.0]` | Sliced | `#FFFFFF` | 1.00 | — |
| Elegant Loading Indicator | `white_panel_21` | 1024×346 | `[55.9, 77.7, 55.9, 86.3]` | Simple | `#FFFFFF` | 1.00 | ✓ |
| Kasho | `white_panel_4` | 50×232 | `[22.0, 26.0, 22.0, 20.0]` | Sliced | `#FF8A94` | 0.90 | ✓ |
| Sawa | `white_panel_4` | 50×232 | `[22.0, 26.0, 22.0, 20.0]` | Sliced | `#83FF39` | 0.90 | ✓ |
| Count | `white_silverBorders_panel_2` | 134×73 | `[10.0, 10.0, 10.0, 10.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Count | `white_silverBorders_panel_2` | 134×73 | `[10.0, 10.0, 10.0, 10.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Count | `white_silverBorders_panel_2` | 134×73 | `[10.0, 10.0, 10.0, 10.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Count | `white_silverBorders_panel_2` | 134×73 | `[10.0, 10.0, 10.0, 10.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Project 1 | `white_silverBorders_panel_2` | 134×73 | `[10.0, 10.0, 10.0, 10.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Project 2 | `white_silverBorders_panel_2` | 134×73 | `[10.0, 10.0, 10.0, 10.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Highlight | `yellow_alpha_notch` | 308×81 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Dealer | `yellow_panel` | 106×41 | `[20.0, 20.0, 20.0, 13.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Blocker | *(بلا صورة)* | — | — | Simple | `#FFFFFF` | 0.00 | ✓ |
| Blocker | *(بلا صورة)* | — | — | Simple | `#FFFFFF` | 0.00 | — |
| Blocker | *(بلا صورة)* | — | — | Simple | `#000000` | 0.00 | ✓ |
| Bottom player | *(بلا صورة)* | — | — | Simple | `#FFFFFF` | 0.00 | ✓ |
| Button - Close | *(بلا صورة)* | — | — | Simple | `#FFFFFF` | 0.00 | ✓ |
| Button - Close | *(بلا صورة)* | — | — | Simple | `#FFFFFF` | 0.00 | ✓ |
| Button - Close | *(بلا صورة)* | — | — | Simple | `#FFFFFF` | 0.00 | ✓ |
| Button - Gift | *(بلا صورة)* | — | — | Sliced | `#FFFFFF` | 0.00 | ✓ |
| Button - Gift | *(بلا صورة)* | — | — | Simple | `#FFFFFF` | 0.00 | ✓ |
| Button - Gift | *(بلا صورة)* | — | — | Simple | `#FFFFFF` | 0.00 | ✓ |
| Button - Gift | *(بلا صورة)* | — | — | Simple | `#FFFFFF` | 0.00 | ✓ |
| Button - Gift | *(بلا صورة)* | — | — | Simple | `#FFFFFF` | 0.00 | ✓ |
| Button - Gift | *(بلا صورة)* | — | — | Simple | `#FFFFFF` | 0.00 | ✓ |
| Button - fire mode | *(بلا صورة)* | — | — | Sliced | `#FFFFFF` | 0.00 | ✓ |
| EmoteViewer | *(بلا صورة)* | — | — | Simple | `#FFFFFF` | 1.00 | — |
| EmoteViewer | *(بلا صورة)* | — | — | Simple | `#FFFFFF` | 1.00 | — |
| EmoteViewer | *(بلا صورة)* | — | — | Simple | `#FFFFFF` | 1.00 | — |
| EmoteViewer | *(بلا صورة)* | — | — | Simple | `#FFFFFF` | 1.00 | — |
| EmoteViewer | *(بلا صورة)* | — | — | Simple | `#FFFFFF` | 1.00 | — |
| Gifts List View | *(بلا صورة)* | — | — | Simple | `#FFFFFF` | 0.00 | ✓ |
| Layer 1 - dealer | *(بلا صورة)* | — | — | Simple | `#00FFC7` | 0.00 | ✓ |
| Layer 1 - dealer | *(بلا صورة)* | — | — | Simple | `#00FFC7` | 0.00 | ✓ |
| Layer 1 - dealer | *(بلا صورة)* | — | — | Simple | `#00FFC7` | 0.00 | ✓ |
| Layer 1 - dealer | *(بلا صورة)* | — | — | Simple | `#00FFC7` | 0.00 | ✓ |
| Layer 2 - showcase | *(بلا صورة)* | — | — | Simple | `#0061FF` | 0.00 | ✓ |
| Layer 2 - showcase | *(بلا صورة)* | — | — | Simple | `#0061FF` | 0.00 | ✓ |
| Layer 2 - showcase | *(بلا صورة)* | — | — | Simple | `#0061FF` | 0.00 | ✓ |
| Layer 2 - showcase | *(بلا صورة)* | — | — | Simple | `#0061FF` | 0.00 | ✓ |
| Layer 3 - game mode | *(بلا صورة)* | — | — | Simple | `#2F00FF` | 0.00 | ✓ |
| Layer 3 - game mode | *(بلا صورة)* | — | — | Simple | `#2F00FF` | 0.00 | ✓ |
| Layer 3 - game mode | *(بلا صورة)* | — | — | Simple | `#2F00FF` | 0.00 | ✓ |
| Layer 3 - game mode | *(بلا صورة)* | — | — | Simple | `#2F00FF` | 0.00 | ✓ |
| Layer 4 - double | *(بلا صورة)* | — | — | Simple | `#C500FF` | 0.00 | ✓ |
| Layer 4 - double | *(بلا صورة)* | — | — | Simple | `#C500FF` | 0.00 | ✓ |
| Layer 4 - double | *(بلا صورة)* | — | — | Simple | `#C500FF` | 0.00 | ✓ |
| Layer 4 - double | *(بلا صورة)* | — | — | Simple | `#C500FF` | 0.00 | ✓ |
| Layer 5 - Kasho | *(بلا صورة)* | — | — | Simple | `#FF006E` | 0.00 | ✓ |
| Layer 5 - Kasho | *(بلا صورة)* | — | — | Simple | `#FF006E` | 0.00 | ✓ |
| Layer 5 - Kasho | *(بلا صورة)* | — | — | Simple | `#FF006E` | 0.00 | ✓ |
| Layer 5 - Kasho | *(بلا صورة)* | — | — | Simple | `#FF006E` | 0.00 | ✓ |
| Layer 6 - sawa | *(بلا صورة)* | — | — | Simple | `#FF006E` | 0.00 | ✓ |
| Layer 6 - sawa | *(بلا صورة)* | — | — | Simple | `#FF006E` | 0.00 | ✓ |
| Layer 6 - sawa | *(بلا صورة)* | — | — | Simple | `#FF006E` | 0.00 | ✓ |
| Layer 6 - sawa | *(بلا صورة)* | — | — | Simple | `#FF006E` | 0.00 | ✓ |
| Layer 7 - projects | *(بلا صورة)* | — | — | Simple | `#FF0000` | 0.00 | ✓ |
| Layer 7 - projects | *(بلا صورة)* | — | — | Simple | `#FF0000` | 0.00 | ✓ |
| Layer 7 - projects | *(بلا صورة)* | — | — | Simple | `#FF0000` | 0.00 | ✓ |
| Layer 7 - projects | *(بلا صورة)* | — | — | Simple | `#FF0000` | 0.00 | ✓ |
| Left player | *(بلا صورة)* | — | — | Simple | `#FFFFFF` | 0.00 | ✓ |
| Playing Buttons | *(بلا صورة)* | — | — | Simple | `#FFFFFF` | 1.00 | — |
| Popup | *(بلا صورة)* | — | — | Simple | `#000000` | 0.42 | ✓ |
| Right player | *(بلا صورة)* | — | — | Simple | `#FFFFFF` | 0.00 | ✓ |
| Slot 1 | *(بلا صورة)* | — | — | Simple | `#FFFFFF` | 1.00 | — |
| Slot 1 | *(بلا صورة)* | — | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Slot 1 | *(بلا صورة)* | — | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Slot 1 | *(بلا صورة)* | — | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Slot 1 | *(بلا صورة)* | — | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Slot 2 | *(بلا صورة)* | — | — | Simple | `#FFFFFF` | 1.00 | — |
| Slot 2 | *(بلا صورة)* | — | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Slot 2 | *(بلا صورة)* | — | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Slot 2 | *(بلا صورة)* | — | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Slot 2 | *(بلا صورة)* | — | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| SwipeWheel click area | *(بلا صورة)* | — | — | Simple | `#FFFFFF` | 0.00 | ✓ |
| SwipeWheel click area | *(بلا صورة)* | — | — | Simple | `#FFFFFF` | 0.00 | ✓ |
| SwipeWheel click area | *(بلا صورة)* | — | — | Simple | `#FFFFFF` | 0.00 | ✓ |
| SwipeWheel click area | *(بلا صورة)* | — | — | Simple | `#FFFFFF` | 0.00 | ✓ |
| Toggle Checkbox - black with Label | *(بلا صورة)* | — | — | Simple | `#FFFFFF` | 0.00 | ✓ |
| Top player | *(بلا صورة)* | — | — | Simple | `#FFFFFF` | 0.00 | ✓ |
| User / Game info | *(بلا صورة)* | — | — | Simple | `#FFFFFF` | 0.00 | ✓ |

## ٢-tablet. عناصر الصور  (610 عنصر · 182 منها 9-slice)

| العنصر | الصورة | الأبعاد | 9-slice | النوع | الصبغة | α | لمس |
|---|---|---|---|---|---|---|---|
| Achievements icon | `achievements` | 43×42 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Icon - Close | `arrow_darkGrey_4` | 60×46 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| AvatarPicture | `avatar_default` | 100×100 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| AvatarPicture | `avatar_default` | 100×100 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| AvatarPicture | `avatar_default` | 100×100 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| AvatarPicture | `avatar_default` | 100×100 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| AvatarPicture | `avatar_default` | 100×100 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| AvatarPicture | `avatar_default` | 100×100 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| AvatarPicture | `avatar_default` | 100×100 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| AvatarPicture | `avatar_default` | 100×100 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| AvatarPicture | `avatar_default` | 100×100 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| AvatarPicture | `avatar_default` | 100×100 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| AvatarPicture | `avatar_default` | 100×100 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| AvatarPicture | `avatar_default` | 100×100 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| AvatarPicture | `avatar_default` | 100×100 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| AvatarPicture | `avatar_default` | 100×100 | — | Simple | `#FFFFFF` | 1.00 | — |
| AvatarPicture | `avatar_default` | 100×100 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| AvatarPicture | `avatar_default` | 100×100 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| AvatarPicture | `avatar_default` | 100×100 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| AvatarPicture | `avatar_default` | 100×100 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Game Bubble | `black_oneCorner_panel` | 202×138 | `[52.0, 52.0, 47.0, 42.0]` | Sliced | `#FFFFFF` | 0.81 | — |
| Game Bubble | `black_oneCorner_panel` | 202×138 | `[52.0, 52.0, 47.0, 42.0]` | Sliced | `#FFFFFF` | 0.81 | — |
| Game Bubble | `black_oneCorner_panel` | 202×138 | `[52.0, 52.0, 47.0, 42.0]` | Sliced | `#FFFFFF` | 0.81 | — |
| Game Bubble | `black_oneCorner_panel` | 202×138 | `[52.0, 52.0, 47.0, 42.0]` | Sliced | `#FFFFFF` | 0.81 | — |
| Game Bubble | `black_oneCorner_panel` | 202×138 | `[52.0, 52.0, 47.0, 42.0]` | Sliced | `#FFFFFF` | 0.81 | — |
| BG | `black_panel` | 85×85 | `[22.0, 22.0, 22.0, 22.0]` | Sliced | `#FFFFFF` | 0.82 | ✓ |
| Points Bar | `brightBlue_panel` | 279×104 | `[60.0, 0.0, 60.0, 0.0]` | Filled · Horizontal | `#FFFFFF` | 1.00 | ✓ |
| Text Background | `brown_alpha_deep_6` | 184×141 | `[41.0, 50.0, 35.0, 38.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Background | `brown_greyBorders_panel` | 685×683 | `[82.0, 88.0, 83.0, 156.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Room Loading | `brown_greyBorders_panel` | 827×783 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Background | `brown_panel` | 841×553 | `[135.0, 140.0, 135.0, 130.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| CardBack | `cardback_default` | 175×256 | — | Simple | `#FFFFFF` | 1.00 | — |
| CardBack | `cardback_default` | 175×256 | — | Simple | `#FFFFFF` | 1.00 | — |
| CardBack | `cardback_default` | 175×256 | — | Simple | `#FFFFFF` | 1.00 | — |
| CardBack | `cardback_default` | 175×256 | — | Simple | `#FFFFFF` | 1.00 | — |
| CardBack | `cardback_default` | 175×256 | — | Simple | `#FFFFFF` | 1.00 | — |
| CardBack | `cardback_default` | 175×256 | — | Simple | `#FFFFFF` | 1.00 | — |
| CardBack | `cardback_default` | 175×256 | — | Simple | `#FFFFFF` | 1.00 | — |
| CardBack | `cardback_default` | 175×256 | — | Simple | `#FFFFFF` | 1.00 | — |
| CardBack | `cardback_default` | 175×256 | — | Simple | `#FFFFFF` | 1.00 | — |
| CardBack | `cardback_default` | 175×256 | — | Simple | `#FFFFFF` | 1.00 | — |
| Icon | `chat_black_2` | 69×60 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Icon | `chat_black_2` | 69×60 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Enabled Image | `chat_black_3` | 97×96 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Background | `chat_lightGrey` | 96×96 | — | Simple | `#FFFFFF` | 1.00 | — |
| Timer | `circle_alpha_black_cover` | 84×84 | — | Simple | `#000000` | 1.00 | — |
| Timer | `circle_alpha_black_cover` | 84×84 | — | Simple | `#000000` | 1.00 | ✓ |
| Avatar Shadow | `circle_black_panel` | 132×141 | — | Simple | `#FFFFFF` | 0.57 | — |
| AvatarShadow | `circle_black_panel` | 132×141 | — | Simple | `#FFFFFF` | 0.49 | — |
| AvatarShadow | `circle_black_panel` | 132×141 | — | Simple | `#FFFFFF` | 0.49 | — |
| AvatarShadow | `circle_black_panel` | 132×141 | — | Simple | `#FFFFFF` | 0.49 | — |
| AvatarShadow | `circle_black_panel` | 132×141 | — | Simple | `#FFFFFF` | 0.49 | — |
| Image | `circle_green_online_indicator` | 105×105 | — | Simple | `#FFFFFF` | 1.00 | — |
| Chat Bubble | `circle_red_whiteBorder_panel` | 55×55 | `[27.0, 27.0, 27.0, 27.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Chat Bubble | `circle_red_whiteBorder_panel` | 55×55 | `[27.0, 27.0, 27.0, 27.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Off Sprite | `circle_white_cover` | 53×53 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Off Sprite | `circle_white_cover` | 53×53 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Counter Base | `circle_white_panel_6` | 42×42 | — | Simple | `#A30000` | 1.00 | ✓ |
| BG | `circle_white_panel_7` | 245×245 | — | Simple | `#5B4C3D` | 1.00 | ✓ |
| BG | `circle_white_panel_7` | 245×245 | — | Simple | `#5B4C3D` | 1.00 | ✓ |
| BG | `circle_white_panel_7` | 245×245 | — | Simple | `#5B4C3D` | 1.00 | ✓ |
| BG | `circle_white_panel_7` | 245×245 | — | Simple | `#5B4C3D` | 1.00 | ✓ |
| BG | `circle_white_panel_7` | 245×245 | — | Simple | `#5B4C3D` | 1.00 | ✓ |
| BG | `circle_white_panel_7` | 245×245 | — | Simple | `#5B4C3D` | 1.00 | ✓ |
| BG | `circle_white_panel_7` | 245×245 | — | Simple | `#5B4C3D` | 1.00 | ✓ |
| BG | `circle_white_panel_7` | 245×245 | — | Simple | `#5B4C3D` | 1.00 | ✓ |
| Timer | `circle_white_panel_7` | 245×245 | — | Simple | `#000000` | 0.34 | — |
| Timer | `circle_white_panel_7` | 245×245 | — | Simple | `#000000` | 0.34 | — |
| Timer | `circle_white_panel_7` | 245×245 | — | Simple | `#000000` | 0.34 | — |
| Timer | `circle_white_panel_7` | 245×245 | — | Simple | `#000000` | 0.34 | — |
| Timer | `circle_white_panel_7` | 245×245 | — | Simple | `#000000` | 0.34 | — |
| Timer | `circle_white_panel_7` | 245×245 | — | Simple | `#000000` | 0.89 | — |
| Timer | `circle_white_panel_7` | 245×245 | — | Simple | `#000000` | 0.34 | — |
| Timer | `circle_white_panel_7` | 245×245 | — | Simple | `#000000` | 0.34 | — |
| Timer | `circle_white_panel_7` | 245×245 | — | Simple | `#000000` | 0.34 | — |
| Timer | `circle_white_panel_7` | 245×245 | — | Simple | `#000000` | 0.34 | — |
| Avatar image holder | `circle_white_panel_8` | 262×262 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Avatar image holder | `circle_white_panel_8` | 262×262 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Avatar image holder | `circle_white_panel_8` | 262×262 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Avatar image holder | `circle_white_panel_8` | 262×262 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Avatar image holder | `circle_white_panel_8` | 262×262 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Avatar image holder | `circle_white_panel_8` | 262×262 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Avatar image holder | `circle_white_panel_8` | 262×262 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Avatar image holder | `circle_white_panel_8` | 262×262 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Avatar image holder | `circle_white_panel_8` | 262×262 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Avatar image holder | `circle_white_panel_8` | 262×262 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Avatar image holder | `circle_white_panel_8` | 262×262 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Avatar image holder | `circle_white_panel_8` | 262×262 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Avatar image holder | `circle_white_panel_8` | 262×262 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Avatar image holder | `circle_white_panel_8` | 262×262 | — | Simple | `#FFFFFF` | 1.00 | — |
| Avatar image holder | `circle_white_panel_8` | 262×262 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Avatar image holder | `circle_white_panel_8` | 262×262 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Avatar image holder | `circle_white_panel_8` | 262×262 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Avatar image holder | `circle_white_panel_8` | 262×262 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Subrank 2 | `club` | 35×35 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Subrank 2 | `club` | 35×35 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Suit | `club_2` | 41×41 | — | Simple | `#FFFFFF` | 1.00 | — |
| Suit | `club_2` | 41×41 | — | Simple | `#FFFFFF` | 1.00 | — |
| Suit | `club_2` | 41×41 | — | Simple | `#FFFFFF` | 1.00 | — |
| Suit | `club_2` | 41×41 | — | Simple | `#FFFFFF` | 1.00 | — |
| Suit | `club_2` | 41×41 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| club | `club_2` | 41×41 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| club | `club_2` | 41×41 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| club | `club_2` | 41×41 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| club | `club_2` | 41×41 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| club | `club_2` | 41×41 | — | Simple | `#FFFFFF` | 1.00 | — |
| club | `club_2` | 41×41 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Icon | `club_4` | 27×30 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Club | `club_6` | 121×128 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Club | `club_6` | 121×128 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Clubs_Border | `club_border` | 121×128 | — | Filled · Radial360 | `#FFFFFF` | 1.00 | ✓ |
| Clubs_Border | `club_border` | 121×128 | — | Filled · Radial360 | `#FFFFFF` | 1.00 | ✓ |
| OwnerBadge | `crown_2` | 54×51 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| OwnerBadge | `crown_2` | 54×51 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| OwnerBadge | `crown_2` | 54×51 | — | Simple | `#FFFFFF` | 1.00 | — |
| OwnerBadge | `crown_2` | 54×51 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| OwnerBadge | `crown_2` | 54×51 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| lit background | `darkGreen_deep` | 105×106 | `[15.0, 15.0, 15.0, 15.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Background | `darkGrey_15pt_panel` | 611×611 | `[80.0, 70.0, 80.0, 80.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Background | `darkGrey_15pt_panel` | 611×611 | `[80.0, 70.0, 80.0, 80.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Background | `darkGrey_15pt_panel` | 611×611 | `[80.0, 70.0, 80.0, 80.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| BroadcastMessageBox | `darkGrey_15pt_panel` | 611×611 | `[80.0, 70.0, 80.0, 80.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Inner | `darkGrey_alpha_cover` | 222×43 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Coins | `darkGrey_alpha_deep_6` | 302×300 | `[40.0, 40.0, 40.0, 40.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Coins | `darkGrey_alpha_deep_6` | 302×300 | `[40.0, 40.0, 40.0, 40.0]` | Sliced | `#FFFFFF` | 1.00 | — |
| Price | `darkGrey_alpha_deep_6` | 302×300 | `[40.0, 40.0, 40.0, 40.0]` | Sliced | `#FFFFFF` | 0.81 | ✓ |
| players | `darkGrey_deep` | 533×109 | `[60.0, 56.0, 60.0, 48.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| players | `darkGrey_deep` | 533×109 | `[60.0, 56.0, 60.0, 48.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| points | `darkGrey_deep` | 533×109 | `[60.0, 56.0, 60.0, 48.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| points | `darkGrey_deep` | 533×109 | `[60.0, 56.0, 60.0, 48.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| solid background | `darkGrey_deep_2` | 105×106 | `[15.0, 15.0, 15.0, 15.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Achievements Meter | `darkGrey_deep_3` | 328×84 | `[50.0, 42.0, 50.0, 34.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Likes Meter | `darkGrey_deep_3` | 328×84 | `[50.0, 42.0, 50.0, 34.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Points Meter | `darkGrey_deep_3` | 328×84 | `[50.0, 42.0, 50.0, 34.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Tournament Points Meter | `darkGrey_deep_3` | 328×84 | `[50.0, 42.0, 50.0, 34.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Backgrond | `darkGrey_deep_4` | 314×314 | `[50.0, 50.0, 50.0, 50.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Content Mask | `darkGrey_deep_4` | 314×314 | `[50.0, 50.0, 50.0, 50.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Description | `darkGrey_deep_4` | 314×314 | `[50.0, 50.0, 50.0, 50.0]` | Sliced | `#FFFFFF` | 0.78 | ✓ |
| Gift List Mask | `darkGrey_deep_4` | 314×314 | `[50.0, 50.0, 50.0, 50.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Gifts Panel | `darkGrey_deep_4` | 314×314 | `[50.0, 50.0, 50.0, 50.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Motion Reply Panel | `darkGrey_deep_4` | 314×314 | `[50.0, 50.0, 50.0, 50.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Players Panel | `darkGrey_deep_4` | 314×314 | `[50.0, 50.0, 50.0, 50.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Text Reply Panel | `darkGrey_deep_4` | 314×314 | `[50.0, 50.0, 50.0, 50.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Deep | `darkGrey_deep_5` | 585×138 | `[70.0, 50.0, 70.0, 40.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Inner | `darkGrey_deep_5` | 585×138 | `[70.0, 50.0, 70.0, 40.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Them - team2 | `darkGrey_deep_5` | 585×138 | `[70.0, 50.0, 70.0, 40.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| US - team1 | `darkGrey_deep_5` | 585×138 | `[70.0, 50.0, 70.0, 40.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Background | `darkGrey_gradient_notch` | 1080×564 | `[72.0, 24.0, 79.0, 525.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Background | `darkGrey_gradient_notch` | 1080×564 | `[72.0, 24.0, 79.0, 525.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Bidding Baloot | `darkGrey_gradient_notch` | 1080×564 | `[72.0, 24.0, 79.0, 525.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Container | `darkGrey_gradient_notch` | 1080×564 | `[72.0, 24.0, 79.0, 525.0]` | Sliced | `#FFFFFF` | 0.04 | ✓ |
| Backgorund | `darkGrey_gradient_notch_2` | 1080×222 | `[50.0, 67.0, 50.0, 15.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Backgorund | `darkGrey_gradient_notch_2` | 1080×222 | `[50.0, 67.0, 50.0, 15.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Blocker | `darkGrey_gradient_notch_2` | 1080×222 | `[50.0, 67.0, 50.0, 15.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Color tint | `darkGrey_gradient_notch_2` | 1080×222 | `[50.0, 67.0, 50.0, 15.0]` | Sliced | `#FFFFFF` | 0.10 | ✓ |
| Background | `darkGrey_gradient_notch_6` | 1024×251 | `[64.5, 0.0, 93.9, 227.3]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Background | `darkGrey_gradient_notch_6` | 1024×251 | `[64.5, 0.0, 93.9, 227.3]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Choose Project | `darkGrey_gradient_notch_6` | 1024×251 | `[64.5, 0.0, 93.9, 227.3]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Idle blocker | `darkGrey_gradient_notch_6` | 1024×251 | `[64.5, 0.0, 93.9, 227.3]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Kasho Button | `darkGrey_gradient_notch_6` | 1024×251 | `[64.5, 0.0, 93.9, 227.3]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| panel | `darkGrey_gradient_notch_6` | 1024×251 | `[64.5, 0.0, 93.9, 227.3]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Watchers score deep | `darkGrey_notch` | 1140×648 | `[133.0, 143.0, 133.0, 0.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Username - Base | `darkGrey_notch_2` | 297×69 | `[28.0, 30.0, 28.0, 6.0]` | Simple | `#FFFFFF` | 1.00 | ✓ |
| Depth | `darkGrey_panel_6` | 646×1462 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Dealer Icon | `dealer` | 32×37 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Dealer icon | `dealer` | 32×37 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Dealer icon | `dealer` | 32×37 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Dealer icon | `dealer` | 32×37 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Dealer icon | `dealer` | 32×37 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Background | `defaultRoomTheme_gamePlay_tablet` | 2048×1534 | — | Simple | `#FFFFFF` | 1.00 | — |
| Room Theme | `defaultRoomTheme_gamePlay_tablet` | 2048×1534 | — | Simple | `#FFFFFF` | 1.00 | — |
| Userbox Dimming Background | `defaultRoomTheme_gamePlay_tablet` | 2048×1534 | — | Simple | `#FFFFFF` | 0.68 | — |
| Subrank 1 | `diamond` | 35×35 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Subrank 1 | `diamond` | 35×35 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| diamond | `diamond_2` | 39×41 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| diamond | `diamond_2` | 39×41 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| diamond | `diamond_2` | 39×41 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| diamond | `diamond_2` | 39×41 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| diamond | `diamond_2` | 39×41 | — | Simple | `#FFFFFF` | 1.00 | — |
| diamond | `diamond_2` | 39×41 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Icon | `diamond_4` | 29×29 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Diamond | `diamond_6` | 115×128 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Diamond | `diamond_6` | 115×128 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Diamond_Border | `diamond_border` | 114×128 | — | Filled · Radial360 | `#FFFFFF` | 1.00 | ✓ |
| Diamond_Border | `diamond_border` | 114×128 | — | Filled · Radial360 | `#FFFFFF` | 1.00 | ✓ |
| Mask | `fill_gradient_yellow_red` | 237×6 | — | Filled · Horizontal | `#000000` | 1.00 | ✓ |
| PlayerVoice indicator | `fill_gradient_yellow_red` | 237×6 | — | Filled · Horizontal | `#FFFFFF` | 1.00 | ✓ |
| fire_logo | `fire_lit` | 49×66 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Icon | `fire_unlit` | 49×66 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Image | `friend_add` | 92×92 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Gift | `gift_6` | 54×62 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Icon | `gift_White` | 44×44 | — | Simple | `#FFFFFF` | 1.00 | — |
| Icon | `gift_White` | 44×44 | — | Simple | `#FFFFFF` | 1.00 | — |
| Icon | `gift_White` | 44×44 | — | Simple | `#FFFFFF` | 1.00 | — |
| Icon | `gift_White` | 44×44 | — | Simple | `#FFFFFF` | 1.00 | — |
| Gift icon | `gift_darkBlack` | 92×88 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Icon | `gift_darkBlack` | 92×88 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Icon | `gift_darkBlack` | 92×88 | — | Simple | `#FFFFFF` | 1.00 | — |
| Icon | `gift_grey` | 53×53 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Coins_icon | `goldenCards_8` | 246×256 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Icon | `goldenCards_8` | 246×256 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Icon | `goldenCards_8` | 246×256 | — | Simple | `#FFFFFF` | 1.00 | — |
| Icon | `goldenCards_lv1` | 168×95 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Feedback | `green_button_2` | 585×138 | `[40.0, 71.0, 39.0, 65.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Button - OK | `green_button_8` | 899×184 | `[80.0, 80.0, 80.0, 80.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| On Sprite | `green_circle_button_3` | 72×72 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| On Sprite | `green_circle_button_3` | 72×72 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Button - 100 | `grey_button_2` | 170×180 | `[50.0, 50.0, 50.0, 50.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Button - 400 | `grey_button_2` | 170×180 | `[50.0, 50.0, 50.0, 50.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Button - 50 | `grey_button_2` | 170×180 | `[50.0, 50.0, 50.0, 50.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Button - Accept | `grey_button_2` | 170×180 | `[50.0, 50.0, 50.0, 50.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Button - Add | `grey_button_2` | 170×180 | `[50.0, 50.0, 50.0, 50.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Button - Ashkal | `grey_button_2` | 170×180 | `[50.0, 50.0, 50.0, 50.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Button - Automatic Ekka placeholde | `grey_button_2` | 170×180 | `[50.0, 50.0, 50.0, 50.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Button - Back | `grey_button_2` | 170×180 | `[50.0, 50.0, 50.0, 50.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Button - Before To Sun | `grey_button_2` | 170×180 | `[50.0, 50.0, 50.0, 50.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Button - Cancel | `grey_button_2` | 170×180 | `[50.0, 50.0, 50.0, 50.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Button - Catch | `grey_button_2` | 170×180 | `[50.0, 50.0, 50.0, 50.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Button - Confirm Hokom | `grey_button_2` | 170×180 | `[50.0, 50.0, 50.0, 50.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Button - Double | `grey_button_2` | 170×180 | `[50.0, 50.0, 50.0, 50.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Button - Ekka | `grey_button_2` | 170×180 | `[50.0, 50.0, 50.0, 50.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Button - Four | `grey_button_2` | 170×180 | `[50.0, 50.0, 50.0, 50.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Button - Gift | `grey_button_2` | 170×180 | `[50.0, 50.0, 50.0, 50.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Button - Hokom | `grey_button_2` | 170×180 | `[50.0, 50.0, 50.0, 50.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Button - Hokom 2 | `grey_button_2` | 170×180 | `[50.0, 50.0, 50.0, 50.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Button - Hokom Closed | `grey_button_2` | 170×180 | `[50.0, 50.0, 50.0, 50.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Button - Hokom Clubs | `grey_button_2` | 170×180 | `[50.0, 50.0, 50.0, 50.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Button - Hokom Diamonds | `grey_button_2` | 170×180 | `[50.0, 50.0, 50.0, 50.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Button - Hokom Hearts | `grey_button_2` | 170×180 | `[50.0, 50.0, 50.0, 50.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Button - Hokom Open | `grey_button_2` | 170×180 | `[50.0, 50.0, 50.0, 50.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Button - Hokom Spades | `grey_button_2` | 170×180 | `[50.0, 50.0, 50.0, 50.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Button - Kasho | `grey_button_2` | 170×180 | `[50.0, 50.0, 50.0, 50.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Button - Kick | `grey_button_2` | 170×180 | `[50.0, 50.0, 50.0, 50.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Button - Kick | `grey_button_2` | 170×180 | `[50.0, 50.0, 50.0, 50.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Button - Like | `grey_button_2` | 170×180 | `[50.0, 50.0, 50.0, 50.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Button - Manage | `grey_button_2` | 170×180 | `[50.0, 50.0, 50.0, 50.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Button - Mute | `grey_button_2` | 170×180 | `[50.0, 50.0, 50.0, 50.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Button - Mute | `grey_button_2` | 170×180 | `[50.0, 50.0, 50.0, 50.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Button - No | `grey_button_2` | 170×180 | `[50.0, 50.0, 50.0, 50.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Button - Open Cards | `grey_button_2` | 170×180 | `[50.0, 50.0, 50.0, 50.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Button - Pass | `grey_button_2` | 170×180 | `[50.0, 50.0, 50.0, 50.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Button - Projects | `grey_button_2` | 170×180 | `[50.0, 50.0, 50.0, 50.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Button - Qahwa | `grey_button_2` | 170×180 | `[50.0, 50.0, 50.0, 50.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Button - Refuse | `grey_button_2` | 170×180 | `[50.0, 50.0, 50.0, 50.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Button - Report | `grey_button_2` | 170×180 | `[50.0, 50.0, 50.0, 50.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Button - Sawa | `grey_button_2` | 170×180 | `[50.0, 50.0, 50.0, 50.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Button - Sawa Confirmation | `grey_button_2` | 170×180 | `[50.0, 50.0, 50.0, 50.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Button - Sira | `grey_button_2` | 170×180 | `[50.0, 50.0, 50.0, 50.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Button - Sit Here | `grey_button_2` | 170×180 | `[50.0, 50.0, 50.0, 50.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Button - Sit Here | `grey_button_2` | 170×180 | `[50.0, 50.0, 50.0, 50.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Button - Sit Here | `grey_button_2` | 170×180 | `[50.0, 50.0, 50.0, 50.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Button - Sit Here | `grey_button_2` | 170×180 | `[50.0, 50.0, 50.0, 50.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Button - Sit Here | `grey_button_2` | 170×180 | `[50.0, 50.0, 50.0, 50.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Button - Sun | `grey_button_2` | 170×180 | `[50.0, 50.0, 50.0, 50.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Button - To Sun | `grey_button_2` | 170×180 | `[50.0, 50.0, 50.0, 50.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Button - Triple | `grey_button_2` | 170×180 | `[50.0, 50.0, 50.0, 50.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Button - UnMute | `grey_button_2` | 170×180 | `[50.0, 50.0, 50.0, 50.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Button - Wala | `grey_button_2` | 170×180 | `[50.0, 50.0, 50.0, 50.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Button - Wrong Ekka | `grey_button_2` | 170×180 | `[50.0, 50.0, 50.0, 50.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Button - Wrong Sawa | `grey_button_2` | 170×180 | `[50.0, 50.0, 50.0, 50.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Button - Yes | `grey_button_2` | 170×180 | `[50.0, 50.0, 50.0, 50.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Image | `grey_button_2` | 170×180 | `[50.0, 50.0, 50.0, 50.0]` | Sliced | `#000000` | 0.15 | — |
| Image | `grey_button_2` | 170×180 | `[50.0, 50.0, 50.0, 50.0]` | Sliced | `#000000` | 0.15 | — |
| background | `grey_button_2` | 170×180 | `[50.0, 50.0, 50.0, 50.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| teams background | `grey_button_2` | 170×180 | `[50.0, 50.0, 50.0, 50.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Watchers score content | `grey_button_4` | 144×144 | `[35.0, 35.0, 35.0, 35.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Background | `grey_button_5` | 380×150 | `[70.0, 63.0, 70.0, 58.0]` | Sliced | `#FFFFFF` | 1.00 | — |
| Background | `grey_button_5` | 380×150 | `[70.0, 63.0, 70.0, 58.0]` | Sliced | `#FFFFFF` | 1.00 | — |
| Button | `grey_button_5` | 380×150 | `[70.0, 63.0, 70.0, 58.0]` | Sliced | `#FFFFFF` | 0.98 | — |
| Button - Chat | `grey_circle_button` | 187×187 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Button - Chat | `grey_circle_button` | 187×187 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Button - Quick | `grey_circle_button` | 187×187 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Button - Send to All | `grey_circle_button` | 187×187 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| ShineFlowUI | `grey_circle_button` | 187×187 | — | Simple | `#D5FBFF` | 1.00 | ✓ |
| Icon | `grey_circle_gift_button` | 120×120 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Icon | `grey_circle_gift_button` | 120×120 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Icon | `grey_circle_gift_button` | 120×120 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Icon | `grey_circle_gift_button` | 120×120 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Button - Send | `grey_gift_emptySpace_button` | 213×84 | `[45.0, 0.0, 91.0, 0.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Game Border | `grey_holed_panel` | 802×170 | `[729.0, 85.0, 73.0, 85.0]` | Sliced | `#FFFFFF` | 1.00 | — |
| Subrank 3 | `heart` | 35×35 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Subrank 3 | `heart` | 35×35 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Hearts | `heart_10` | 128×110 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Hearts | `heart_10` | 128×110 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| heart | `heart_6` | 47×37 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| heart | `heart_6` | 47×37 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| heart | `heart_6` | 47×37 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| heart | `heart_6` | 47×37 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| heart | `heart_6` | 47×37 | — | Simple | `#FFFFFF` | 1.00 | — |
| heart | `heart_6` | 47×37 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Icon | `heart_7` | 31×27 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Image | `heart_8` | 176×156 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Likes icon | `heart_8` | 176×156 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Hearts_Border | `heart_border` | 128×110 | — | Filled · Radial360 | `#FFFFFF` | 1.00 | ✓ |
| Hearts_Border | `heart_border` | 128×110 | — | Filled · Radial360 | `#FFFFFF` | 1.00 | ✓ |
| Logo | `kammelna_logo` | 676×431 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Mute indicator | `mic_off_2` | 512×530 | — | Simple | `#FFFFFF` | 1.00 | — |
| mute indicator | `mic_off_2` | 512×530 | — | Simple | `#FFFFFF` | 1.00 | — |
| mute indicator | `mic_off_2` | 512×530 | — | Simple | `#FFFFFF` | 1.00 | — |
| mute indicator | `mic_off_2` | 512×530 | — | Simple | `#FFFFFF` | 1.00 | — |
| mute indicator | `mic_off_2` | 512×530 | — | Simple | `#FFFFFF` | 1.00 | — |
| Points Icon front | `point_blue` | 81×81 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Points Icon back | `point_grey` | 81×81 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Icon | `profile_White` | 63×62 | — | Simple | `#FFFFFF` | 1.00 | — |
| Icon | `profile_White` | 63×62 | — | Simple | `#FFFFFF` | 1.00 | — |
| Icon | `profile_White` | 63×62 | — | Simple | `#FFFFFF` | 1.00 | — |
| Icon | `profile_White` | 63×62 | — | Simple | `#FFFFFF` | 1.00 | — |
| Icon | `questionMark_lightBulb` | 314×314 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Rank Badge inGame | `rank_0_ingame` | 585×481 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Rank Badge inGame | `rank_0_ingame` | 585×481 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Rank Badge inGame | `rank_0_ingame` | 585×481 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Rank Badge inGame | `rank_0_ingame` | 585×481 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Rank Mini Zats | `rank_1_FTMini` | 72×52 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Rank Mini Zats | `rank_1_FTMini` | 72×52 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Rank Mini Zats | `rank_1_FTMini` | 72×52 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Rank Mini Zats | `rank_1_FTMini` | 72×52 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Rank Mini Zats | `rank_1_FTMini` | 72×52 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Avatar image background | `rank_1_circular_rim` | 192×192 | — | Simple | `#FFFFFF` | 1.00 | — |
| Rank Normal Zats | `rank_1_default` | 245×72 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Rank Normal Zats | `rank_1_default` | 245×72 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Rank Badge inGame | `rank_1_ingame` | 585×481 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Rank Badge inGame | `rank_1_ingame` | 585×481 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Rank Badge inGame | `rank_1_ingame` | 585×481 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Rank Badge inGame | `rank_1_ingame` | 585×481 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Button - Cancel | `red_button_5` | 380×150 | `[70.0, 63.0, 70.0, 58.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Highlight | `ring_black` | 135×135 | — | Simple | `#FFFFFF` | 1.00 | — |
| Highlight | `ring_black` | 135×135 | — | Simple | `#FFFFFF` | 1.00 | — |
| Highlight | `ring_black` | 135×135 | — | Simple | `#FFFFFF` | 1.00 | — |
| Highlight | `ring_black` | 135×135 | — | Simple | `#FFFFFF` | 1.00 | — |
| Highlight | `ring_black` | 135×135 | — | Simple | `#FFFFFF` | 1.00 | — |
| Highlight | `ring_black` | 135×135 | — | Simple | `#FFFFFF` | 1.00 | — |
| Highlight | `ring_black` | 135×135 | — | Simple | `#FFFFFF` | 1.00 | — |
| Highlight | `ring_black` | 135×135 | — | Simple | `#FFFFFF` | 1.00 | — |
| Highlight | `ring_black` | 135×135 | — | Simple | `#FFFFFF` | 1.00 | — |
| Image | `ring_grey` | 88×88 | — | Simple | `#29FF00` | 1.00 | ✓ |
| Image | `ring_grey` | 88×88 | — | Simple | `#29FF00` | 1.00 | ✓ |
| Image | `ring_grey` | 88×88 | — | Simple | `#29FF00` | 1.00 | ✓ |
| Image | `ring_grey` | 88×88 | — | Simple | `#29FF00` | 1.00 | ✓ |
| Sound indicator | `ring_pattern` | 180×181 | — | Simple | `#FFFFFF` | 1.00 | — |
| Sound indicator | `ring_pattern` | 180×181 | — | Simple | `#FFFFFF` | 1.00 | — |
| Sound indicator | `ring_pattern` | 180×181 | — | Simple | `#FFFFFF` | 1.00 | — |
| Sound indicator | `ring_pattern` | 180×181 | — | Simple | `#FFFFFF` | 1.00 | — |
| Bottom | `ring_yellow` | 106×106 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Bottom | `ring_yellow` | 106×106 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Bottom | `ring_yellow` | 106×106 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Bottom | `ring_yellow` | 106×106 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Left | `ring_yellow` | 106×106 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Left | `ring_yellow` | 106×106 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Left | `ring_yellow` | 106×106 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Left | `ring_yellow` | 106×106 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Right | `ring_yellow` | 106×106 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Right | `ring_yellow` | 106×106 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Right | `ring_yellow` | 106×106 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Right | `ring_yellow` | 106×106 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Top | `ring_yellow` | 106×106 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Top | `ring_yellow` | 106×106 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Top | `ring_yellow` | 106×106 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Top | `ring_yellow` | 106×106 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Counter Inner Border | `ring_yellow_2` | 42×42 | — | Simple | `#000000` | 0.23 | ✓ |
| Fill | `ring_yellow_3` | 75×75 | — | Filled · Radial360 | `#FFFFFF` | 1.00 | — |
| Fill | `ring_yellow_3` | 75×75 | — | Filled · Radial360 | `#FFFFFF` | 1.00 | ✓ |
| Fill | `ring_yellow_3` | 75×75 | — | Filled · Radial360 | `#FFFFFF` | 1.00 | — |
| Fill base | `ring_yellow_3` | 75×75 | — | Filled · Radial360 | `#787878` | 1.00 | ✓ |
| Fill | `ring_yellow_blackBorders` | 132×132 | — | Filled · Radial360 | `#FFFFFF` | 1.00 | — |
| Fill | `ring_yellow_blackBorders` | 132×132 | — | Filled · Radial360 | `#FFFFFF` | 1.00 | — |
| Fill | `ring_yellow_blackBorders` | 132×132 | — | Filled · Radial360 | `#FFFFFF` | 1.00 | — |
| Fill | `ring_yellow_blackBorders` | 132×132 | — | Filled · Radial360 | `#FFFFFF` | 1.00 | — |
| Fill | `ring_yellow_blackBorders` | 132×132 | — | Filled · Radial360 | `#FFFFFF` | 1.00 | — |
| Fill | `ring_yellow_blackBorders` | 132×132 | — | Filled · Radial360 | `#FFFFFF` | 1.00 | — |
| Fill | `ring_yellow_blackBorders` | 132×132 | — | Filled · Radial360 | `#FFFFFF` | 1.00 | — |
| Fill | `ring_yellow_blackBorders` | 132×132 | — | Filled · Radial360 | `#FFFFFF` | 1.00 | — |
| Fill | `ring_yellow_blackBorders` | 132×132 | — | Filled · Radial360 | `#FFFFFF` | 1.00 | — |
| Tournament Points Icon | `rournament_point` | 96×96 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Bottom | `seat_off` | 16×15 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Bottom | `seat_off` | 16×15 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Left | `seat_off` | 16×15 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Left | `seat_off` | 16×15 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Right | `seat_off` | 16×15 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Right | `seat_off` | 16×15 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Top | `seat_off` | 16×15 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Top | `seat_off` | 16×15 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Active | `seat_on` | 15×15 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Active | `seat_on` | 15×15 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Active | `seat_on` | 15×15 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Active | `seat_on` | 15×15 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Active | `seat_on` | 15×15 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Active | `seat_on` | 15×15 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Active | `seat_on` | 15×15 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Active | `seat_on` | 15×15 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Enabled Image | `smile_black` | 96×96 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Image | `smile_chat_black` | 96×96 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Background | `smile_lightGrey` | 96×96 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Sound indicator Glow | `smooth_shine_white_2` | 253×253 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Sound indicator Glow | `smooth_shine_white_2` | 253×253 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Sound indicator Glow | `smooth_shine_white_2` | 253×253 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Sound indicator Glow | `smooth_shine_white_2` | 253×253 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Subrank 4 | `spade` | 35×35 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Subrank 4 | `spade` | 35×35 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| spade | `spade_2` | 40×37 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| spade | `spade_2` | 40×37 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| spade | `spade_2` | 40×37 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| spade | `spade_2` | 40×37 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| spade | `spade_2` | 40×37 | — | Simple | `#FFFFFF` | 1.00 | — |
| spade | `spade_2` | 40×37 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Icon | `spade_4` | 27×27 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Spades | `spade_6` | 124×128 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Spades | `spade_6` | 124×128 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Spades_Border | `spade_border` | 124×128 | — | Filled · Radial360 | `#FFFFFF` | 1.00 | ✓ |
| Spades_Border | `spade_border` | 124×128 | — | Filled · Radial360 | `#FFFFFF` | 1.00 | ✓ |
| Zat | `streak` | 420×585 | — | Simple | `#FFFFFF` | 1.00 | — |
| sup1 | `subrank_first` | 32×8 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| sup1 | `subrank_first` | 32×8 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| sup1 | `subrank_first` | 32×8 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| sup1 | `subrank_first` | 32×8 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| sup1 | `subrank_first` | 32×8 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| sup1 | `subrank_first` | 32×8 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| sup1 | `subrank_first` | 32×8 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| sup1 | `subrank_first` | 32×8 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Subrank 1 | `subrank_first_1` | 12×9 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Subrank 1 | `subrank_first_1` | 12×9 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Subrank 1 | `subrank_first_1` | 12×9 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Subrank 1 | `subrank_first_1` | 12×9 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Subrank 1 | `subrank_first_1` | 12×9 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| sup4 | `subrank_fourth` | 32×8 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| sup4 | `subrank_fourth` | 32×8 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| sup4 | `subrank_fourth` | 32×8 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| sup4 | `subrank_fourth` | 32×8 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| sup4 | `subrank_fourth` | 32×8 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| sup4 | `subrank_fourth` | 32×8 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| sup4 | `subrank_fourth` | 32×8 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| sup4 | `subrank_fourth` | 32×8 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Subrank 4 | `subrank_fourth_1` | 12×9 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Subrank 4 | `subrank_fourth_1` | 12×9 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Subrank 4 | `subrank_fourth_1` | 12×9 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Subrank 4 | `subrank_fourth_1` | 12×9 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Subrank 4 | `subrank_fourth_1` | 12×9 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| sup2 | `subrank_second` | 32×8 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| sup2 | `subrank_second` | 32×8 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| sup2 | `subrank_second` | 32×8 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| sup2 | `subrank_second` | 32×8 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| sup2 | `subrank_second` | 32×8 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| sup2 | `subrank_second` | 32×8 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| sup2 | `subrank_second` | 32×8 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| sup2 | `subrank_second` | 32×8 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Subrank 2 | `subrank_second_1` | 12×9 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Subrank 2 | `subrank_second_1` | 12×9 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Subrank 2 | `subrank_second_1` | 12×9 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Subrank 2 | `subrank_second_1` | 12×9 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Subrank 2 | `subrank_second_1` | 12×9 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| sup3 | `subrank_third` | 32×8 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| sup3 | `subrank_third` | 32×8 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| sup3 | `subrank_third` | 32×8 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| sup3 | `subrank_third` | 32×8 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| sup3 | `subrank_third` | 32×8 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| sup3 | `subrank_third` | 32×8 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| sup3 | `subrank_third` | 32×8 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| sup3 | `subrank_third` | 32×8 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Subrank 3 | `subrank_third_1` | 12×9 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Subrank 3 | `subrank_third_1` | 12×9 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Subrank 3 | `subrank_third_1` | 12×9 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Subrank 3 | `subrank_third_1` | 12×9 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Subrank 3 | `subrank_third_1` | 12×9 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Gift | `swipe` | 66×92 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Gift | `swipe` | 66×92 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Gift | `swipe` | 66×92 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Gift | `swipe` | 66×92 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Profile | `swipe` | 66×92 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Profile | `swipe` | 66×92 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Profile | `swipe` | 66×92 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Profile | `swipe` | 66×92 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Icon checked | `tick_green_5` | 98×98 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Background | `tick_grey_empty` | 84×84 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Bet | `white_alpha_deep` | 115×40 | `[16.0, 14.0, 16.0, 14.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Double | `white_alpha_deep` | 115×40 | `[16.0, 14.0, 16.0, 14.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Background | `white_alpha_notch` | 703×112 | `[60.0, 40.0, 60.0, 50.0]` | Sliced | `#272727` | 1.00 | — |
| Project 1 | `white_alpha_notch_3` | 84×72 | `[27.0, 32.0, 25.0, 12.0]` | Simple | `#FFFFFF` | 1.00 | — |
| Project 1 | `white_alpha_notch_3` | 84×72 | `[27.0, 32.0, 25.0, 12.0]` | Simple | `#FFFFFF` | 1.00 | — |
| Project 1 | `white_alpha_notch_3` | 84×72 | `[27.0, 32.0, 25.0, 12.0]` | Simple | `#FFFFFF` | 1.00 | — |
| Project 1 | `white_alpha_notch_3` | 84×72 | `[27.0, 32.0, 25.0, 12.0]` | Simple | `#FFFFFF` | 1.00 | — |
| Project 2 | `white_alpha_notch_3` | 84×72 | `[27.0, 32.0, 25.0, 12.0]` | Simple | `#FFFFFF` | 1.00 | — |
| Project 2 | `white_alpha_notch_3` | 84×72 | `[27.0, 32.0, 25.0, 12.0]` | Simple | `#FFFFFF` | 1.00 | — |
| Project 2 | `white_alpha_notch_3` | 84×72 | `[27.0, 32.0, 25.0, 12.0]` | Simple | `#FFFFFF` | 1.00 | — |
| Project 2 | `white_alpha_notch_3` | 84×72 | `[27.0, 32.0, 25.0, 12.0]` | Simple | `#FFFFFF` | 1.00 | — |
| Bet | `white_alpha_notch_4` | 179×86 | `[35.0, 53.0, 36.0, 14.0]` | Sliced | `#FFFFFF` | 1.00 | — |
| Bet | `white_alpha_notch_4` | 179×86 | `[35.0, 53.0, 36.0, 14.0]` | Sliced | `#FFFFFF` | 1.00 | — |
| Bet | `white_alpha_notch_4` | 179×86 | `[35.0, 53.0, 36.0, 14.0]` | Sliced | `#FFFFFF` | 1.00 | — |
| Bet | `white_alpha_notch_4` | 179×86 | `[35.0, 53.0, 36.0, 14.0]` | Sliced | `#FFFFFF` | 1.00 | — |
| GiftsShowcase | `white_alpha_notch_4` | 179×86 | `[35.0, 53.0, 36.0, 14.0]` | Sliced | `#FFFFFF` | 1.00 | — |
| GiftsShowcase | `white_alpha_notch_4` | 179×86 | `[35.0, 53.0, 36.0, 14.0]` | Sliced | `#FFFFFF` | 1.00 | — |
| GiftsShowcase | `white_alpha_notch_4` | 179×86 | `[35.0, 53.0, 36.0, 14.0]` | Sliced | `#FFFFFF` | 1.00 | — |
| GiftsShowcase | `white_alpha_notch_4` | 179×86 | `[35.0, 53.0, 36.0, 14.0]` | Sliced | `#FFFFFF` | 1.00 | — |
| Image | `white_alpha_notch_4` | 179×86 | `[35.0, 53.0, 36.0, 14.0]` | Sliced | `#8EFF4C` | 1.00 | — |
| Image | `white_alpha_notch_4` | 179×86 | `[35.0, 53.0, 36.0, 14.0]` | Sliced | `#FF8391` | 1.00 | — |
| Image | `white_alpha_notch_4` | 179×86 | `[35.0, 53.0, 36.0, 14.0]` | Sliced | `#FFFFFF` | 1.00 | — |
| Image | `white_alpha_notch_4` | 179×86 | `[35.0, 53.0, 36.0, 14.0]` | Sliced | `#FFFFFF` | 1.00 | — |
| Image | `white_alpha_notch_4` | 179×86 | `[35.0, 53.0, 36.0, 14.0]` | Sliced | `#FF8391` | 1.00 | — |
| Image | `white_alpha_notch_4` | 179×86 | `[35.0, 53.0, 36.0, 14.0]` | Sliced | `#F9E606` | 1.00 | ✓ |
| Image | `white_alpha_notch_4` | 179×86 | `[35.0, 53.0, 36.0, 14.0]` | Sliced | `#8EFF4C` | 1.00 | — |
| Image | `white_alpha_notch_4` | 179×86 | `[35.0, 53.0, 36.0, 14.0]` | Sliced | `#FFFFFF` | 1.00 | — |
| Image | `white_alpha_notch_4` | 179×86 | `[35.0, 53.0, 36.0, 14.0]` | Sliced | `#F9E606` | 1.00 | ✓ |
| Image | `white_alpha_notch_4` | 179×86 | `[35.0, 53.0, 36.0, 14.0]` | Sliced | `#FFFFFF` | 1.00 | — |
| Image | `white_alpha_notch_4` | 179×86 | `[35.0, 53.0, 36.0, 14.0]` | Sliced | `#FFFFFF` | 1.00 | — |
| Image | `white_alpha_notch_4` | 179×86 | `[35.0, 53.0, 36.0, 14.0]` | Sliced | `#FF8391` | 1.00 | — |
| Image | `white_alpha_notch_4` | 179×86 | `[35.0, 53.0, 36.0, 14.0]` | Sliced | `#FFFFFF` | 1.00 | — |
| Image | `white_alpha_notch_4` | 179×86 | `[35.0, 53.0, 36.0, 14.0]` | Sliced | `#FFFFFF` | 1.00 | — |
| Image | `white_alpha_notch_4` | 179×86 | `[35.0, 53.0, 36.0, 14.0]` | Sliced | `#FFFFFF` | 1.00 | — |
| Image | `white_alpha_notch_4` | 179×86 | `[35.0, 53.0, 36.0, 14.0]` | Sliced | `#FF8391` | 1.00 | — |
| Image | `white_alpha_notch_4` | 179×86 | `[35.0, 53.0, 36.0, 14.0]` | Sliced | `#F9E606` | 1.00 | ✓ |
| Image | `white_alpha_notch_4` | 179×86 | `[35.0, 53.0, 36.0, 14.0]` | Sliced | `#8EFF4C` | 1.00 | — |
| Image | `white_alpha_notch_4` | 179×86 | `[35.0, 53.0, 36.0, 14.0]` | Sliced | `#8EFF4C` | 1.00 | — |
| Image | `white_alpha_notch_4` | 179×86 | `[35.0, 53.0, 36.0, 14.0]` | Sliced | `#F9E606` | 1.00 | ✓ |
| Background | `white_notch` | 351×86 | `[40.0, 45.0, 40.0, 23.0]` | Sliced | `#000000` | 1.00 | ✓ |
| Background | `white_notch` | 351×86 | `[40.0, 45.0, 40.0, 23.0]` | Sliced | `#000000` | 1.00 | ✓ |
| BG | `white_notch_3` | 409×107 | `[52.0, 52.0, 53.0, 18.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Title | `white_notch_3` | 409×107 | `[52.0, 52.0, 53.0, 18.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Layout | `white_oneCorner_panel` | 202×138 | `[45.0, 52.0, 46.0, 37.0]` | Sliced | `#FFFFFF` | 1.00 | — |
| Layout | `white_oneCorner_panel` | 202×138 | `[45.0, 52.0, 46.0, 37.0]` | Sliced | `#FFFFFF` | 1.00 | — |
| Layout | `white_oneCorner_panel` | 202×138 | `[45.0, 52.0, 46.0, 37.0]` | Sliced | `#FFFFFF` | 1.00 | — |
| Layout | `white_oneCorner_panel` | 202×138 | `[45.0, 52.0, 46.0, 37.0]` | Sliced | `#FFFFFF` | 1.00 | — |
| Layout | `white_oneCorner_panel` | 202×138 | `[45.0, 52.0, 46.0, 37.0]` | Sliced | `#FFFFFF` | 1.00 | — |
| Elegant Loading Indicator | `white_panel_21` | 1024×346 | `[55.9, 77.7, 55.9, 86.3]` | Simple | `#FFFFFF` | 1.00 | ✓ |
| Kasho | `white_panel_4` | 50×232 | `[22.0, 26.0, 22.0, 20.0]` | Sliced | `#FF8A94` | 0.90 | ✓ |
| Sawa | `white_panel_4` | 50×232 | `[22.0, 26.0, 22.0, 20.0]` | Sliced | `#83FF39` | 0.90 | ✓ |
| Count | `white_silverBorders_panel_2` | 134×73 | `[10.0, 10.0, 10.0, 10.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Count | `white_silverBorders_panel_2` | 134×73 | `[10.0, 10.0, 10.0, 10.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Count | `white_silverBorders_panel_2` | 134×73 | `[10.0, 10.0, 10.0, 10.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Count | `white_silverBorders_panel_2` | 134×73 | `[10.0, 10.0, 10.0, 10.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Project 1 | `white_silverBorders_panel_2` | 134×73 | `[10.0, 10.0, 10.0, 10.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Project 2 | `white_silverBorders_panel_2` | 134×73 | `[10.0, 10.0, 10.0, 10.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Highlight | `yellow_alpha_notch` | 308×81 | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Dealer | `yellow_panel` | 106×41 | `[20.0, 20.0, 20.0, 13.0]` | Sliced | `#FFFFFF` | 1.00 | ✓ |
| Blocker | *(بلا صورة)* | — | — | Simple | `#FFFFFF` | 0.00 | ✓ |
| Blocker | *(بلا صورة)* | — | — | Simple | `#FFFFFF` | 0.00 | ✓ |
| Blocker | *(بلا صورة)* | — | — | Simple | `#FFFFFF` | 0.00 | — |
| Blocker | *(بلا صورة)* | — | — | Simple | `#000000` | 0.00 | ✓ |
| Blocker | *(بلا صورة)* | — | — | Simple | `#000000` | 0.00 | ✓ |
| Bottom player | *(بلا صورة)* | — | — | Simple | `#FFFFFF` | 0.00 | ✓ |
| Button - Close | *(بلا صورة)* | — | — | Simple | `#FFFFFF` | 0.00 | ✓ |
| Button - Close | *(بلا صورة)* | — | — | Simple | `#FFFFFF` | 0.00 | ✓ |
| Button - Close | *(بلا صورة)* | — | — | Simple | `#FFFFFF` | 0.00 | ✓ |
| Button - Gift | *(بلا صورة)* | — | — | Sliced | `#FFFFFF` | 0.00 | ✓ |
| Button - Gift | *(بلا صورة)* | — | — | Simple | `#FFFFFF` | 0.00 | ✓ |
| Button - Gift | *(بلا صورة)* | — | — | Simple | `#FFFFFF` | 0.00 | ✓ |
| Button - Gift | *(بلا صورة)* | — | — | Simple | `#FFFFFF` | 0.00 | ✓ |
| Button - Gift | *(بلا صورة)* | — | — | Simple | `#FFFFFF` | 0.00 | ✓ |
| Button - Gift | *(بلا صورة)* | — | — | Simple | `#FFFFFF` | 0.00 | ✓ |
| Button - fire mode | *(بلا صورة)* | — | — | Sliced | `#FFFFFF` | 0.00 | ✓ |
| Emote Action Message Mask | *(بلا صورة)* | — | — | Simple | `#FFFFFF` | 1.00 | — |
| EmoteViewer | *(بلا صورة)* | — | — | Simple | `#FFFFFF` | 1.00 | — |
| EmoteViewer | *(بلا صورة)* | — | — | Simple | `#FFFFFF` | 1.00 | — |
| EmoteViewer | *(بلا صورة)* | — | — | Simple | `#FFFFFF` | 1.00 | — |
| EmoteViewer | *(بلا صورة)* | — | — | Simple | `#FFFFFF` | 1.00 | — |
| EmoteViewer | *(بلا صورة)* | — | — | Simple | `#FFFFFF` | 1.00 | — |
| Game Message Displayer Mask | *(بلا صورة)* | — | — | Simple | `#FFFFFF` | 1.00 | — |
| Gifts List View | *(بلا صورة)* | — | — | Simple | `#FFFFFF` | 0.00 | ✓ |
| ImageReaction | *(بلا صورة)* | — | — | Simple | `#FFFFFF` | 0.00 | ✓ |
| Layer 1 - dealer | *(بلا صورة)* | — | — | Simple | `#00FFC7` | 0.00 | ✓ |
| Layer 1 - dealer | *(بلا صورة)* | — | — | Simple | `#00FFC7` | 0.00 | ✓ |
| Layer 1 - dealer | *(بلا صورة)* | — | — | Simple | `#00FFC7` | 0.00 | ✓ |
| Layer 1 - dealer | *(بلا صورة)* | — | — | Simple | `#00FFC7` | 0.00 | ✓ |
| Layer 2 - showcase | *(بلا صورة)* | — | — | Simple | `#0061FF` | 0.00 | ✓ |
| Layer 2 - showcase | *(بلا صورة)* | — | — | Simple | `#0061FF` | 0.00 | ✓ |
| Layer 2 - showcase | *(بلا صورة)* | — | — | Simple | `#0061FF` | 0.00 | ✓ |
| Layer 2 - showcase | *(بلا صورة)* | — | — | Simple | `#0061FF` | 0.00 | ✓ |
| Layer 3 - game mode | *(بلا صورة)* | — | — | Simple | `#2F00FF` | 0.00 | ✓ |
| Layer 3 - game mode | *(بلا صورة)* | — | — | Simple | `#2F00FF` | 0.00 | ✓ |
| Layer 3 - game mode | *(بلا صورة)* | — | — | Simple | `#2F00FF` | 0.00 | ✓ |
| Layer 3 - game mode | *(بلا صورة)* | — | — | Simple | `#2F00FF` | 0.00 | ✓ |
| Layer 4 - double | *(بلا صورة)* | — | — | Simple | `#C500FF` | 0.00 | ✓ |
| Layer 4 - double | *(بلا صورة)* | — | — | Simple | `#C500FF` | 0.00 | ✓ |
| Layer 4 - double | *(بلا صورة)* | — | — | Simple | `#C500FF` | 0.00 | ✓ |
| Layer 4 - double | *(بلا صورة)* | — | — | Simple | `#C500FF` | 0.00 | ✓ |
| Layer 5 - Kasho | *(بلا صورة)* | — | — | Simple | `#FF006E` | 0.00 | ✓ |
| Layer 5 - Kasho | *(بلا صورة)* | — | — | Simple | `#FF006E` | 0.00 | ✓ |
| Layer 5 - Kasho | *(بلا صورة)* | — | — | Simple | `#FF006E` | 0.00 | ✓ |
| Layer 5 - Kasho | *(بلا صورة)* | — | — | Simple | `#FF006E` | 0.00 | ✓ |
| Layer 6 - sawa | *(بلا صورة)* | — | — | Simple | `#FF006E` | 0.00 | ✓ |
| Layer 6 - sawa | *(بلا صورة)* | — | — | Simple | `#FF006E` | 0.00 | ✓ |
| Layer 6 - sawa | *(بلا صورة)* | — | — | Simple | `#FF006E` | 0.00 | ✓ |
| Layer 6 - sawa | *(بلا صورة)* | — | — | Simple | `#FF006E` | 0.00 | ✓ |
| Layer 7 - projects | *(بلا صورة)* | — | — | Simple | `#FF0000` | 0.00 | ✓ |
| Layer 7 - projects | *(بلا صورة)* | — | — | Simple | `#FF0000` | 0.00 | ✓ |
| Layer 7 - projects | *(بلا صورة)* | — | — | Simple | `#FF0000` | 0.00 | ✓ |
| Layer 7 - projects | *(بلا صورة)* | — | — | Simple | `#FF0000` | 0.00 | ✓ |
| Left player | *(بلا صورة)* | — | — | Simple | `#FFFFFF` | 0.00 | ✓ |
| Mask | *(بلا صورة)* | — | — | Simple | `#FFFFFF` | 1.00 | — |
| Player Control Mask | *(بلا صورة)* | — | — | Simple | `#FFFFFF` | 1.00 | — |
| Playing Buttons | *(بلا صورة)* | — | — | Simple | `#FFFFFF` | 1.00 | — |
| Popup | *(بلا صورة)* | — | — | Simple | `#000000` | 0.42 | ✓ |
| Right player | *(بلا صورة)* | — | — | Simple | `#FFFFFF` | 0.00 | ✓ |
| Slot 1 | *(بلا صورة)* | — | — | Simple | `#FFFFFF` | 1.00 | — |
| Slot 1 | *(بلا صورة)* | — | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Slot 1 | *(بلا صورة)* | — | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Slot 1 | *(بلا صورة)* | — | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Slot 1 | *(بلا صورة)* | — | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Slot 2 | *(بلا صورة)* | — | — | Simple | `#FFFFFF` | 1.00 | — |
| Slot 2 | *(بلا صورة)* | — | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Slot 2 | *(بلا صورة)* | — | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Slot 2 | *(بلا صورة)* | — | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| Slot 2 | *(بلا صورة)* | — | — | Simple | `#FFFFFF` | 1.00 | ✓ |
| SwipeWheel click area | *(بلا صورة)* | — | — | Simple | `#FFFFFF` | 0.00 | ✓ |
| SwipeWheel click area | *(بلا صورة)* | — | — | Simple | `#FFFFFF` | 0.00 | ✓ |
| SwipeWheel click area | *(بلا صورة)* | — | — | Simple | `#FFFFFF` | 0.00 | ✓ |
| SwipeWheel click area | *(بلا صورة)* | — | — | Simple | `#FFFFFF` | 0.00 | ✓ |
| Teams details Mask | *(بلا صورة)* | — | — | Simple | `#FFFFFF` | 1.00 | — |
| TextReaction | *(بلا صورة)* | — | — | Simple | `#FFFFFF` | 0.00 | ✓ |
| Title Setter | *(بلا صورة)* | — | — | Simple | `#FFFFFF` | 1.00 | — |
| Toggle Checkbox - black with Label | *(بلا صورة)* | — | — | Simple | `#FFFFFF` | 0.00 | ✓ |
| Top player | *(بلا صورة)* | — | — | Simple | `#FFFFFF` | 0.00 | ✓ |
| User / Game info | *(بلا صورة)* | — | — | Simple | `#FFFFFF` | 0.00 | ✓ |

## ٣-phone. مجموعات التخطيط  (46)

| العنصر | النوع | الحشو L/R/T/B | التباعد | المحاذاة | تمديد W/H |
|---|---|---|---|---|---|
| Horizontal | HorizontalLayoutGroup | 0/0/0/0 | 0.0 | MiddleCenter | —/— |
| Bottom Section | VerticalLayoutGroup | 0/0/0/0 | 0.0 | MiddleCenter | —/— |
| Chat Bubble | HorizontalLayoutGroup | 10/7/0/0 | 0.0 | MiddleCenter | ✓/✓ |
| Timer container | VerticalLayoutGroup | 0/0/0/0 | 0.0 | MiddleCenter | —/— |
| Chat Bubble | VerticalLayoutGroup | 0/0/0/0 | 0.0 | LowerRight | —/— |
| Layout | VerticalLayoutGroup | 40/40/30/35 | 0.0 | MiddleCenter | —/— |
| Layout | VerticalLayoutGroup | 0/0/-6/0 | 6.0 | MiddleCenter | —/— |
| Subranks | HorizontalLayoutGroup | 2/2/2/2 | 3.0 | MiddleCenter | ✓/✓ |
| Layout | VerticalLayoutGroup | 0/0/0/0 | 0.0 | MiddleCenter | —/— |
| Double | HorizontalLayoutGroup | 5/5/5/5 | 0.0 | MiddleCenter | —/— |
| Message Container | VerticalLayoutGroup | 0/0/0/0 | 0.0 | LowerCenter | —/— |
| vertical layout | VerticalLayoutGroup | 0/0/0/0 | 0.0 | UpperCenter | —/— |
| Horizontal | HorizontalLayoutGroup | 0/0/0/0 | 0.0 | MiddleCenter | —/— |
| Bets Container | HorizontalLayoutGroup | 0/0/0/0 | 9.0 | MiddleCenter | ✓/— |
| Subranks | HorizontalLayoutGroup | 2/2/2/2 | 3.0 | MiddleCenter | ✓/✓ |
| Buttons Container | HorizontalLayoutGroup | 0/0/0/0 | -8.65999984741211 | UpperCenter | ✓/✓ |
| Chat Bubble | VerticalLayoutGroup | 0/0/0/0 | 0.0 | LowerRight | —/— |
| Layout | VerticalLayoutGroup | 40/40/30/35 | 0.0 | MiddleCenter | —/— |
| Chat Bubble | HorizontalLayoutGroup | 10/7/0/0 | 0.0 | MiddleCenter | ✓/✓ |
| Projects parent - keep enabled | HorizontalLayoutGroup | 0/0/0/0 | 9.0 | MiddleCenter | —/— |
| Background | VerticalLayoutGroup | 0/0/40/0 | -14.0 | UpperCenter | —/— |
| Subranks | HorizontalLayoutGroup | 2/2/2/2 | 3.0 | MiddleCenter | ✓/✓ |
| Container | LinearLayoutGroup | 10/10/30/150 | 0.0 | MiddleCenter | —/— |
| Subranks | HorizontalLayoutGroup | 2/2/2/2 | 3.0 | MiddleCenter | ✓/✓ |
| vertical layout | VerticalLayoutGroup | 0/0/0/0 | 0.0 | UpperCenter | —/— |
| Layout | VerticalLayoutGroup | 40/40/30/35 | 0.0 | MiddleCenter | —/— |
| Chat Bubble | VerticalLayoutGroup | 0/0/0/0 | 0.0 | LowerRight | —/— |
| layout | HorizontalLayoutGroup | 0/0/0/0 | 0.0 | MiddleCenter | —/— |
| Layout | HorizontalLayoutGroup | 0/0/0/-150 | 0.0 | LowerLeft | —/— |
| vertical layout | VerticalLayoutGroup | 0/0/0/0 | 0.0 | UpperCenter | —/— |
| vertical layout | VerticalLayoutGroup | 0/0/0/0 | 0.0 | UpperCenter | —/— |
| Bet | HorizontalLayoutGroup | 5/5/5/5 | 10.0 | MiddleCenter | —/— |
| Price | HorizontalLayoutGroup | 0/0/0/0 | 0.0 | MiddleCenter | —/— |
| Layout | VerticalLayoutGroup | 40/40/30/35 | 0.0 | MiddleCenter | —/— |
| Chat Bubble | VerticalLayoutGroup | 0/0/0/0 | 0.0 | LowerRight | —/— |
| Chat Bubble | VerticalLayoutGroup | 0/0/0/0 | 0.0 | LowerRight | —/— |
| Check Box | HorizontalLayoutGroup | 0/20/0/0 | 0.0 | MiddleCenter | —/— |
| Buttons | HorizontalLayoutGroup | 0/0/10/0 | 50.0 | MiddleCenter | ✓/— |
| Subranks | HorizontalLayoutGroup | 2/2/2/2 | 3.0 | MiddleCenter | ✓/✓ |
| Subranks | HorizontalLayoutGroup | 2/2/2/2 | 3.0 | MiddleCenter | ✓/✓ |
| Layout | VerticalLayoutGroup | 0/0/0/-150 | 0.0 | LowerCenter | ✓/— |
| Bidding Baloot | HorizontalLayoutGroup | 5/5/28/390 | 5.0 | UpperLeft | ✓/✓ |
| Subranks | HorizontalLayoutGroup | 2/2/2/2 | 3.0 | MiddleCenter | ✓/✓ |
| Description | HorizontalLayoutGroup | 30/30/30/30 | 0.0 | MiddleCenter | —/— |
| Container | VerticalLayoutGroup | 35/35/60/175 | 25.0 | MiddleRight | —/— |
| Subranks | HorizontalLayoutGroup | 2/2/2/2 | 3.0 | MiddleCenter | ✓/✓ |

## ٣-tablet. مجموعات التخطيط  (53)

| العنصر | النوع | الحشو L/R/T/B | التباعد | المحاذاة | تمديد W/H |
|---|---|---|---|---|---|
| Bottom Section | VerticalLayoutGroup | 0/0/0/0 | 0.0 | MiddleCenter | —/— |
| Chat Bubble | HorizontalLayoutGroup | 10/7/0/0 | 0.0 | MiddleCenter | ✓/✓ |
| Layout | VerticalLayoutGroup | 40/40/30/35 | 0.0 | MiddleCenter | —/— |
| Chat Bubble | VerticalLayoutGroup | 0/0/0/0 | 0.0 | LowerRight | —/— |
| Timer container | VerticalLayoutGroup | 0/0/0/0 | 0.0 | MiddleCenter | —/— |
| Message Container | VerticalLayoutGroup | 0/0/0/0 | 0.0 | LowerCenter | —/— |
| Double | HorizontalLayoutGroup | 5/5/5/5 | 0.0 | MiddleCenter | —/— |
| Layout | VerticalLayoutGroup | 0/0/0/0 | 0.0 | MiddleCenter | —/— |
| Subranks | HorizontalLayoutGroup | 2/2/2/2 | 3.0 | MiddleCenter | ✓/✓ |
| Layout | VerticalLayoutGroup | 0/0/-6/0 | 6.0 | MiddleCenter | —/— |
| Subranks | HorizontalLayoutGroup | 2/2/2/2 | 3.0 | MiddleCenter | ✓/✓ |
| Bets Container | HorizontalLayoutGroup | 0/0/0/0 | 9.0 | MiddleCenter | ✓/— |
| Horizontal | HorizontalLayoutGroup | 0/0/0/0 | 0.0 | MiddleCenter | —/— |
| vertical layout | VerticalLayoutGroup | 0/0/0/0 | 0.0 | UpperCenter | —/— |
| Projects parent - keep enabled | HorizontalLayoutGroup | 0/0/0/0 | 9.0 | MiddleCenter | —/— |
| Chat Bubble | HorizontalLayoutGroup | 10/7/0/0 | 0.0 | MiddleCenter | ✓/✓ |
| Layout | VerticalLayoutGroup | 40/40/30/35 | 0.0 | MiddleCenter | —/— |
| Chat Bubble | VerticalLayoutGroup | 0/0/0/0 | 0.0 | LowerRight | —/— |
| Buttons Container | HorizontalLayoutGroup | 0/0/0/0 | -8.65999984741211 | UpperCenter | ✓/✓ |
| Subranks | HorizontalLayoutGroup | 2/2/2/2 | 3.0 | MiddleCenter | ✓/✓ |
| Background | VerticalLayoutGroup | 0/0/40/0 | -14.0 | UpperCenter | —/— |
| vertical layout | VerticalLayoutGroup | 0/0/0/0 | 0.0 | UpperCenter | —/— |
| Subranks | HorizontalLayoutGroup | 2/2/2/2 | 3.0 | MiddleCenter | ✓/✓ |
| Container | LinearLayoutGroup | 10/10/30/150 | 0.0 | MiddleCenter | —/— |
| layout | HorizontalLayoutGroup | 0/0/0/0 | 0.0 | MiddleCenter | —/— |
| Layout | HorizontalLayoutGroup | 0/0/0/-150 | 0.0 | LowerLeft | —/— |
| Title notch | HorizontalLayoutGroup | 0/0/7/5 | 0.0 | UpperLeft | ✓/✓ |
| Chat Bubble | VerticalLayoutGroup | 0/0/0/0 | 0.0 | LowerRight | —/— |
| Layout | VerticalLayoutGroup | 40/40/30/35 | 0.0 | MiddleCenter | —/— |
| Coins | HorizontalLayoutGroup | 0/0/0/0 | 0.0 | MiddleRight | —/✓ |
| Content | GridLayoutGroup | 10/10/10/10 | {'x': 0.0, 'y': 0.0} | UpperRight | —/— |
| vertical layout | VerticalLayoutGroup | 0/0/0/0 | 0.0 | UpperCenter | —/— |
| Price | HorizontalLayoutGroup | 0/0/0/0 | 0.0 | MiddleCenter | —/— |
| Bet | HorizontalLayoutGroup | 5/5/5/5 | 10.0 | MiddleCenter | —/— |
| vertical layout | VerticalLayoutGroup | 0/0/0/0 | 0.0 | UpperCenter | —/— |
| Layout | VerticalLayoutGroup | 40/40/30/35 | 0.0 | MiddleCenter | —/— |
| Chat Bubble | VerticalLayoutGroup | 0/0/0/0 | 0.0 | LowerRight | —/— |
| Chat Bubble | VerticalLayoutGroup | 0/0/0/0 | 0.0 | LowerRight | —/— |
| Buttons | HorizontalLayoutGroup | 0/0/10/0 | 50.0 | MiddleCenter | ✓/— |
| Check Box | HorizontalLayoutGroup | 0/20/0/0 | 0.0 | MiddleCenter | —/— |
| Subranks | HorizontalLayoutGroup | 2/2/2/2 | 3.0 | MiddleCenter | ✓/✓ |
| Our Progress Indicator | HorizontalLayoutGroup | 0/10/0/0 | 0.0 | MiddleRight | —/✓ |
| Subranks | HorizontalLayoutGroup | 2/2/2/2 | 3.0 | MiddleCenter | ✓/✓ |
| Layout | VerticalLayoutGroup | 0/0/0/-150 | 0.0 | LowerCenter | ✓/— |
| Bidding Baloot | HorizontalLayoutGroup | 5/5/28/390 | 5.0 | UpperLeft | ✓/✓ |
| Text Reply Grid | GridLayoutGroup | 0/0/20/0 | {'x': -12.0, 'y': -19.0} | UpperCenter | —/— |
| Description | HorizontalLayoutGroup | 30/30/30/30 | 0.0 | MiddleCenter | —/— |
| Container | VerticalLayoutGroup | 35/35/60/175 | 25.0 | MiddleRight | —/— |
| Their Progress Indicator | HorizontalLayoutGroup | 10/0/0/0 | 0.0 | MiddleLeft | —/✓ |
| Subranks | HorizontalLayoutGroup | 2/2/2/2 | 3.0 | MiddleCenter | ✓/✓ |
| Horizontal | HorizontalLayoutGroup | 0/0/0/0 | 0.0 | MiddleCenter | —/— |
| Subranks | HorizontalLayoutGroup | 2/2/2/2 | 3.0 | MiddleCenter | ✓/✓ |
| Toggles | HorizontalLayoutGroup | 0/0/0/0 | 0.0 | MiddleCenter | ✓/✓ |