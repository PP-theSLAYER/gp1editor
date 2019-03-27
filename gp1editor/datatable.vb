Public Class datatable
    Public Shared moves = {"(none)",
"Thunder Shock",
"Quick Attack",
"Scratch",
"Ember",
"Vine Whip",
"Tackle",
"Razor Leaf",
"Take Down",
"Water Gun",
"Bite",
"Pound",
"Double Slap",
"Wrap",
"Hyper Beam",
"Lick",
"Dark Pulse",
"Smog",
"Sludge",
"Metal Claw",
"Vice Grip",
"Flame Wheel",
"Megahorn",
"Wing Attack",
"Flamethrower",
"Sucker Punch",
"Dig",
"Low Kick",
"Cross Chop",
"Psycho Cut",
"Psybeam",
"Earthquake",
"Stone Edge",
"Ice Punch",
"Heart Stamp",
"Discharge",
"Flash Cannon",
"Peck",
"Drill Peck",
"Ice Beam",
"Blizzard",
"Air Slash",
"Heat Wave",
"Twineedle",
"Poison Jab",
"Aerial Ace",
"Drill Run",
"Petal Blizzard",
"Mega Drain",
"Bug Buzz",
"Poison Fang",
"Night Slash",
"Slash",
"Bubble Beam",
"Submission",
"Karate Chop",
"Low Sweep",
"Aqua Jet",
"Aqua Tail",
"Seed Bomb",
"Psyshock",
"Rock Throw",
"Ancient Power",
"Rock Tomb",
"Rock Slide",
"Power Gem",
"Shadow Sneak",
"Shadow Punch",
"Shadow Claw",
"Ominous Wind",
"Shadow Ball",
"Bullet Punch",
"Magnet Bomb",
"Steel Wing",
"Iron Head",
"Parabolic Charge",
"Spark",
"Thunder Punch",
"Thunder",
"Thunderbolt",
"Twister",
"Dragon Breath",
"Dragon Pulse",
"Dragon Claw",
"Disarming Voice",
"Draining Kiss",
"Dazzling Gleam",
"Moonblast",
"Play Rough",
"Cross Poison",
"Sludge Bomb",
"Sludge Wave",
"Gunk Shot",
"Mud Shot",
"Bone Club",
"Bulldoze",
"Mud Bomb",
"Fury Cutter",
"Bug Bite",
"Signal Beam",
"X-Scissor",
"Flame Charge",
"Flame Burst",
"Fire Blast",
"Brine",
"Water Pulse",
"Scald",
"Hydro Pump",
"Psychic",
"Psystrike",
"Ice Shard",
"Icy Wind",
"Frost Breath",
"Absorb",
"Giga Drain",
"Fire Punch",
"Solar Beam",
"Leaf Blade",
"Power Whip",
"Splash",
"Acid",
"Air Cutter",
"Hurricane",
"Brick Break",
"Cut",
"Swift",
"Horn Attack",
"Stomp",
"Headbutt",
"Hyper Fang",
"Slam",
"Body Slam",
"Rest",
"Struggle",
"Scald* ",
"Hydro Pump* ",
"Wrap* ",
"Wrap* ",
"(138)",
"(139)",
"(140)",
"(141)",
"(142)",
"(143)",
"(144)",
"(145)",
"(146)",
"(147)",
"(148)",
"(149)",
"(150)",
"(151)",
"(152)",
"(153)",
"(154)",
"(155)",
"(156)",
"(157)",
"(158)",
"(159)",
"(160)",
"(161)",
"(162)",
"(163)",
"(164)",
"(165)",
"(166)",
"(167)",
"(168)",
"(169)",
"(170)",
"(171)",
"(172)",
"(173)",
"(174)",
"(175)",
"(176)",
"(177)",
"(178)",
"(179)",
"(180)",
"(181)",
"(182)",
"(183)",
"(184)",
"(185)",
"(186)",
"(187)",
"(188)",
"(189)",
"(190)",
"(191)",
"(192)",
"(193)",
"(194)",
"(195)",
"(196)",
"(197)",
"(198)",
"(199)",
"Fury Cutter",
"Bug Bite",
"Bite",
"Sucker Punch",
"Dragon Breath",
"Thunder Shock",
"Spark",
"Low Kick",
"Karate Chop",
"Ember",
"Wing Attack",
"Peck",
"Lick",
"Shadow Claw",
"Vine Whip",
"Razor Leaf",
"Mud Shot",
"Ice Shard",
"Frost Breath",
"Quick Attack",
"Scratch",
"Tackle",
"Pound",
"Cut",
"Poison Jab",
"Acid",
"Psycho Cut",
"Rock Throw",
"Metal Claw",
"Bullet Punch",
"Water Gun",
"Splash",
"Water Gun* ",
"Mud-Slap",
"Zen Headbutt",
"Confusion",
"Poison Sting",
"Bubble",
"Feint Attack",
"Steel Wing",
"Fire Fang",
"Rock Smash",
"Transform",
"Counter",
"Powder Snow",
"Close Combat",
"Dynamic Punch",
"Focus Blast",
"Aurora Beam",
"Charge Beam",
"Volt Switch",
"Wild Charge",
"Zap Cannon",
"Dragon Tail",
"Avalanche",
"Air Slash",
"Brave Bird",
"Sky Attack",
"Sand Tomb",
"Rock Blast",
"Infestation",
"Struggle Bug",
"Silver Wind",
"Astonish",
"Hex",
"Night Shade",
"Iron Tail",
"Gyro Ball",
"Heavy Slam",
"Fire Spin",
"Overheat",
"Bullet Seed",
"Grass Knot",
"Energy Ball",
"Extrasensory",
"Future Sight",
"Mirror Coat",
"Outrage",
"Snarl",
"Crunch",
"Foul Play",
"Hidden Power",
"Take Down",
"Waterfall",
"Surf",
"Draco Meteor",
"Doom Desire",
"Yawn",
"Psycho Boost",
"Origin Pulse",
"Precipice Blades",
"Present",
"Weather Ball",
"Weather Ball",
"Weather Ball",
"Weather Ball",
"Frenzy Plant",
"Smack Down",
"Blast Burn",
"Hydro Cannon",
"Last Resort",
"(301)",
"(302)",
"(303)",
"(304)",
"(305)",
"(306)",
"(307)",
"(308)",
"(309)",
"(310)",
"(311)",
"(312)",
"(313)",
"(314)",
"(315)",
"(316)",
"(317)",
"(318)",
"(319)",
"(320)",
"(321)",
"(322)",
"(323)",
"(324)",
"(325)",
"(326)",
"(327)",
"(328)",
"(329)",
"(330)",
"(331)",
"(332)",
"(333)",
"(334)",
"(335)",
"(336)",
"(337)",
"(338)",
"(339)",
"(340)",
"(341)",
"(342)",
"(343)",
"(344)",
"(345)",
"(346)",
"(347)",
"(348)",
"(349)",
"(350)",
"(351)",
"(352)",
"(353)",
"(354)",
"(355)",
"(356)",
"(357)",
"(358)",
"(359)",
"(360)",
"(361)",
"(362)",
"(363)",
"(364)",
"(365)",
"(366)",
"(367)",
"(368)",
"(369)",
"(370)",
"(371)",
"(372)",
"(373)",
"(374)",
"(375)",
"(376)",
"(377)",
"(378)",
"(379)",
"(380)",
"(381)",
"(382)",
"(383)",
"(384)",
"(385)",
"(386)",
"(387)",
"(388)",
"(389)",
"(390)",
"(391)",
"(392)",
"(393)",
"(394)",
"(395)",
"(396)",
"(397)",
"(398)",
"(399)",
"(400)",
"(401)",
"(402)",
"(403)",
"(404)",
"(405)",
"(406)",
"(407)",
"(408)",
"(409)",
"(410)",
"(411)",
"(412)",
"(413)",
"(414)",
"(415)"}


    'base stats
    Public Shared basealola = {102, 103, 70,
181, 135, 154,
155, 201, 154,
137, 125, 129,
181, 177, 195,
116, 96, 109,
177, 170, 193,
67, 109, 82,
111, 201, 145,
120, 99, 78,
163, 158, 136,
120, 132, 132,
146, 164, 164,
190, 211, 198,
190, 135, 90,
233, 190, 172,
216, 230, 153,
155, 144, 186}

    Public Shared basemel = {130, 112, 113, 264, 231, 213}

    Public Shared basestats1 = {126, 90, 126,
158, 120, 156,
200, 160, 198,
108, 78, 128,
140, 116, 160,
182, 156, 212,
142, 88, 112,
176, 118, 144,
222, 158, 186,
66, 90, 62,
86, 100, 56,
144, 120, 144,
64, 80, 68,
82, 90, 62,
130, 130, 144,
90, 80, 94,
122, 126, 126,
166, 166, 170,
86, 60, 92,
150, 110, 146,
78, 80, 102,
146, 130, 168,
112, 70, 112,
166, 120, 166,
108, 70, 124,
154, 120, 200,
114, 100, 90,
172, 150, 150,
104, 110, 100,
136, 140, 132,
190, 180, 184,
94, 92, 110,
128, 122, 142,
170, 162, 204,
124, 140, 116,
178, 190, 178,
118, 76, 106,
194, 146, 176,
54, 230, 98,
108, 280, 168,
90, 80, 88,
164, 150, 164,
130, 90, 134,
158, 120, 162,
190, 150, 202,
120, 70, 122,
170, 120, 162,
118, 120, 108,
154, 140, 172,
86, 20, 108,
140, 70, 148,
94, 80, 104,
146, 130, 156,
112, 100, 132,
176, 160, 194,
96, 80, 122,
150, 130, 178,
110, 110, 156,
180, 180, 230,
98, 80, 108,
132, 130, 132,
202, 180, 180,
76, 50, 110,
112, 80, 150,
152, 110, 186,
96, 140, 118,
144, 160, 154,
180, 180, 198,
78, 100, 158,
110, 130, 190,
152, 160, 222,
136, 80, 106,
196, 160, 170,
118, 80, 106,
156, 110, 142,
198, 160, 176,
138, 100, 168,
170, 130, 200,
110, 180, 110,
198, 190, 184,
138, 50, 128,
180, 100, 186,
132, 104, 138,
96, 70, 126,
150, 120, 182,
138, 130, 104,
192, 180, 156,
110, 160, 124,
188, 210, 180,
112, 60, 120,
196, 100, 196,
82, 60, 136,
118, 90, 172,
156, 120, 204,
186, 70, 90,
140, 120, 104,
196, 170, 162,
110, 60, 116,
168, 110, 178,
124, 80, 102,
174, 120, 150,
132, 120, 110,
164, 190, 232,
150, 100, 102,
202, 120, 140,
172, 100, 148,
204, 100, 138,
160, 180, 126,
142, 80, 136,
198, 130, 190,
116, 160, 110,
160, 210, 166,
60, 500, 40,
152, 130, 164,
178, 210, 142,
100, 60, 122,
150, 110, 176,
126, 90, 112,
160, 160, 172,
128, 60, 130,
192, 120, 194,
196, 80, 154,
180, 140, 176,
134, 130, 172,
160, 130, 198,
158, 130, 214,
186, 130, 184,
184, 150, 148,
84, 40, 42,
196, 190, 192,
190, 260, 186,
110, 96, 110,
128, 110, 114,
168, 260, 186,
174, 130, 192,
178, 130, 238,
158, 130, 156,
160, 70, 132,
202, 140, 180,
142, 60, 148,
190, 120, 190,
162, 160, 182,
180, 320, 180,
242, 180, 198,
194, 180, 232,
194, 180, 242,
110, 82, 128,
152, 122, 170,
212, 182, 250,
202, 212, 284,
220, 200, 220}

    Public Shared basestats2 = {118, 90, 118,
151, 120, 151,
198, 160, 198,
96, 78, 116,
129, 116, 158,
176, 156, 223,
122, 88, 94,
155, 118, 126,
210, 158, 171,
62, 90, 55,
94, 100, 45,
151, 120, 167,
55, 80, 63,
86, 90, 46,
150, 130, 169,
76, 80, 85,
108, 126, 117,
157, 166, 166,
70, 60, 103,
144, 110, 161,
61, 80, 112,
135, 130, 182,
102, 70, 110,
158, 120, 167,
101, 70, 112,
165, 120, 193,
145, 100, 126,
202, 150, 182,
94, 110, 86,
126, 140, 117,
174, 180, 180,
76, 92, 105,
112, 122, 137,
157, 162, 204,
116, 140, 107,
171, 190, 178,
122, 76, 96,
204, 146, 169,
44, 230, 80,
93, 280, 156,
76, 80, 83,
153, 150, 161,
116, 90, 131,
139, 120, 153,
170, 150, 202,
99, 70, 121,
146, 120, 165,
102, 120, 100,
150, 140, 179,
88, 20, 109,
147, 70, 167,
81, 80, 92,
139, 130, 150,
96, 100, 122,
163, 160, 191,
87, 80, 148,
144, 130, 207,
96, 110, 136,
166, 180, 227,
82, 80, 101,
130, 130, 130,
187, 180, 182,
103, 50, 195,
138, 80, 232,
194, 110, 271,
88, 140, 137,
130, 160, 177,
162, 180, 234,
64, 100, 139,
95, 130, 172,
138, 160, 207,
182, 80, 97,
237, 160, 166,
163, 80, 132,
196, 110, 164,
229, 160, 211,
132, 100, 170,
167, 130, 207,
109, 180, 109,
194, 190, 177,
128, 50, 165,
182, 100, 223,
118, 104, 124,
88, 70, 158,
145, 120, 218,
128, 130, 85,
184, 180, 139,
90, 160, 135,
184, 210, 190,
168, 60, 116,
323, 100, 186,
70, 60, 186,
112, 90, 223,
156, 120, 261,
288, 70, 85,
158, 120, 89,
215, 170, 144,
156, 60, 181,
214, 110, 240,
114, 80, 109,
179, 120, 173,
140, 120, 107,
158, 190, 233,
165, 100, 90,
200, 120, 144,
211, 100, 224,
212, 100, 193,
137, 180, 108,
164, 80, 119,
221, 130, 174,
157, 160, 140,
206, 210, 222,
176, 500, 60,
205, 130, 183,
165, 210, 181,
125, 60, 129,
182, 110, 187,
115, 90, 123,
154, 160, 175,
112, 60, 137,
184, 120, 210,
233, 80, 192,
170, 140, 218,
182, 130, 223,
173, 130, 198,
169, 130, 206,
197, 130, 238,
197, 150, 198,
102, 40, 29,
197, 190, 237,
180, 260, 165,
91, 96, 91,
121, 110, 104,
177, 260, 205,
201, 130, 232,
204, 130, 246,
139, 130, 153,
174, 70, 155,
227, 140, 207,
162, 60, 148,
203, 120, 220,
164, 160, 221,
190, 320, 190,
249, 180, 192,
188, 180, 253,
184, 180, 251,
94, 82, 119,
138, 122, 163,
201, 182, 263,
182, 193, 300,
210, 200, 210}

    Public Shared basestats3 = {128, 118, 111,
155, 151, 143,
190, 198, 189,
118, 116, 93,
151, 158, 126,
186, 223, 173,
127, 94, 121,
153, 126, 155,
188, 171, 207,
128, 55, 55,
137, 45, 80,
155, 167, 137,
120, 63, 50,
128, 46, 75,
163, 169, 130,
120, 85, 73,
160, 117, 105,
195, 166, 154,
102, 103, 70,
146, 161, 139,
120, 112, 60,
163, 182, 133,
111, 110, 97,
155, 167, 153,
111, 112, 96,
155, 193, 151,
137, 126, 120,
181, 182, 175,
146, 86, 89,
172, 117, 120,
207, 180, 173,
130, 105, 76,
156, 137, 111,
191, 204, 156,
172, 107, 108,
216, 178, 162,
116, 96, 109,
177, 169, 190,
251, 80, 41,
295, 156, 90,
120, 83, 73,
181, 161, 150,
128, 131, 112,
155, 153, 136,
181, 202, 167,
111, 121, 99,
155, 165, 146,
155, 100, 100,
172, 179, 143,
67, 109, 78,
111, 167, 134,
120, 92, 78,
163, 150, 136,
137, 122, 95,
190, 191, 162,
120, 148, 82,
163, 207, 138,
146, 136, 93,
207, 227, 166,
120, 101, 82,
163, 130, 123,
207, 182, 184,
93, 195, 82,
120, 232, 117,
146, 271, 167,
172, 137, 82,
190, 177, 125,
207, 234, 159,
137, 139, 61,
163, 172, 92,
190, 207, 135,
120, 97, 149,
190, 166, 209,
120, 132, 132,
146, 164, 164,
190, 211, 198,
137, 170, 127,
163, 207, 162,
207, 109, 98,
216, 177, 180,
93, 165, 121,
137, 223, 169,
141, 124, 115,
111, 158, 83,
155, 218, 140,
163, 85, 121,
207, 139, 177,
190, 135, 90,
233, 190, 172,
102, 116, 134,
137, 186, 256,
102, 186, 67,
128, 223, 107,
155, 261, 149,
111, 85, 232,
155, 89, 136,
198, 144, 193,
102, 181, 124,
146, 240, 181,
120, 109, 111,
155, 173, 173,
155, 107, 125,
216, 233, 149,
137, 90, 144,
155, 144, 186,
137, 224, 181,
137, 193, 197,
207, 108, 137,
120, 119, 141,
163, 174, 197,
190, 140, 127,
233, 222, 171,
487, 60, 128,
163, 183, 169,
233, 181, 165,
102, 129, 103,
146, 187, 156,
128, 123, 110,
190, 175, 147,
102, 137, 112,
155, 210, 184,
120, 192, 205,
172, 218, 170,
163, 223, 151,
163, 198, 158,
163, 206, 154,
163, 238, 182,
181, 198, 183,
85, 29, 85,
216, 237, 186,
277, 165, 174,
134, 91, 91,
146, 104, 114,
277, 205, 161,
163, 232, 182,
163, 246, 179,
163, 153, 136,
111, 155, 153,
172, 207, 201,
102, 148, 140,
155, 220, 186,
190, 221, 159,
330, 190, 169,
207, 192, 236,
207, 253, 185,
207, 251, 181,
121, 119, 91,
156, 163, 135,
209, 263, 198,
214, 300, 182,
225, 210, 210}

    Public Shared Function statfinder(ByVal species As String)
        'source: https://docs.google.com/spreadsheets/d/1QDk6pGO6hbh3GrdeJp_0bx-xVMiG0zYAfpWZUV7ZaME/edit#gid=220449899

        Dim stamret As Integer = 0
        Dim atkret As Integer = 0
        Dim defret As Integer = 0
        Select Case species
            Case "Bulbasaur"
                stamret = 128
                atkret = 118
                defret = 111

            Case "Ivysaur"
                stamret = 155
                atkret = 151
                defret = 143

            Case "Mega Venusaur"
                stamret = 190
                atkret = 241
                defret = 246

            Case "Venusaur"
                stamret = 190
                atkret = 198
                defret = 189

            Case "Charmander"
                stamret = 118
                atkret = 116
                defret = 93

            Case "Charmeleon"
                stamret = 151
                atkret = 158
                defret = 126

            Case "Mega Charizard X"
                stamret = 186
                atkret = 273
                defret = 213

            Case "Mega Charizard Y"
                stamret = 170
                atkret = 290
                defret = 193

            Case "Charizard"
                stamret = 186
                atkret = 223
                defret = 173

            Case "Squirtle"
                stamret = 127
                atkret = 94
                defret = 121

            Case "Wartortle"
                stamret = 153
                atkret = 126
                defret = 155

            Case "Mega Blastoise"
                stamret = 188
                atkret = 264
                defret = 237

            Case "Blastoise"
                stamret = 188
                atkret = 171
                defret = 207

            Case "Caterpie"
                stamret = 128
                atkret = 55
                defret = 55

            Case "Metapod"
                stamret = 137
                atkret = 45
                defret = 80

            Case "Butterfree"
                stamret = 155
                atkret = 167
                defret = 137

            Case "Weedle"
                stamret = 120
                atkret = 63
                defret = 50

            Case "Kakuna"
                stamret = 128
                atkret = 46
                defret = 75

            Case "Mega Beedrill"
                stamret = 163
                atkret = 303
                defret = 148

            Case "Beedrill"
                stamret = 163
                atkret = 169
                defret = 130

            Case "Pidgey"
                stamret = 120
                atkret = 85
                defret = 73

            Case "Pidgeotto"
                stamret = 160
                atkret = 117
                defret = 105

            Case "Mega Pidgeot"
                stamret = 195
                atkret = 280
                defret = 175

            Case "Pidgeot"
                stamret = 195
                atkret = 166
                defret = 154

            Case "Rattata"
                stamret = 102
                atkret = 103
                defret = 70

            Case "Alolan Rattata"
                stamret = 102
                atkret = 103
                defret = 70

            Case "Raticate"
                stamret = 146
                atkret = 161
                defret = 139

            Case "Alolan Raticate"
                stamret = 181
                atkret = 135
                defret = 154

            Case "Spearow"
                stamret = 120
                atkret = 112
                defret = 60

            Case "Fearow"
                stamret = 163
                atkret = 182
                defret = 133

            Case "Ekans"
                stamret = 111
                atkret = 110
                defret = 97

            Case "Arbok"
                stamret = 155
                atkret = 167
                defret = 153

            Case "Pikachu"
                stamret = 111
                atkret = 112
                defret = 96

            Case "Alolan Raichu"
                stamret = 155
                atkret = 201
                defret = 154

            Case "Raichu"
                stamret = 155
                atkret = 193
                defret = 151

            Case "Alolan Sandshrew"
                stamret = 137
                atkret = 125
                defret = 129

            Case "Sandshrew"
                stamret = 137
                atkret = 126
                defret = 120

            Case "Alolan Sandslash"
                stamret = 181
                atkret = 177
                defret = 195

            Case "Sandslash"
                stamret = 181
                atkret = 182
                defret = 175

            Case "Nidoran♀"
                stamret = 146
                atkret = 86
                defret = 89

            Case "Nidorina"
                stamret = 172
                atkret = 117
                defret = 120

            Case "Nidoqueen"
                stamret = 207
                atkret = 180
                defret = 173

            Case "Nidoran♂"
                stamret = 130
                atkret = 105
                defret = 76

            Case "Nidorino"
                stamret = 156
                atkret = 137
                defret = 111

            Case "Nidoking"
                stamret = 191
                atkret = 204
                defret = 156

            Case "Clefairy"
                stamret = 172
                atkret = 107
                defret = 108

            Case "Clefable"
                stamret = 216
                atkret = 178
                defret = 162

            Case "Vulpix"
                stamret = 116
                atkret = 96
                defret = 109

            Case "Alolan Vulpix"
                stamret = 116
                atkret = 96
                defret = 109

            Case "Alolan Ninetales"
                stamret = 177
                atkret = 170
                defret = 193

            Case "Ninetales"
                stamret = 177
                atkret = 169
                defret = 190

            Case "Jigglypuff"
                stamret = 251
                atkret = 80
                defret = 41

            Case "Wigglytuff"
                stamret = 295
                atkret = 156
                defret = 90

            Case "Zubat"
                stamret = 120
                atkret = 83
                defret = 73

            Case "Golbat"
                stamret = 181
                atkret = 161
                defret = 150

            Case "Oddish"
                stamret = 128
                atkret = 131
                defret = 112

            Case "Gloom"
                stamret = 155
                atkret = 153
                defret = 136

            Case "Vileplume"
                stamret = 181
                atkret = 202
                defret = 167

            Case "Paras"
                stamret = 111
                atkret = 121
                defret = 99

            Case "Parasect"
                stamret = 155
                atkret = 165
                defret = 146

            Case "Venonat"
                stamret = 155
                atkret = 100
                defret = 100

            Case "Venomoth"
                stamret = 172
                atkret = 179
                defret = 143

            Case "Alolan Diglett"
                stamret = 67
                atkret = 109
                defret = 82

            Case "Diglett"
                stamret = 67
                atkret = 109
                defret = 78

            Case "Alolan Dugtrio"
                stamret = 111
                atkret = 201
                defret = 145

            Case "Dugtrio"
                stamret = 111
                atkret = 167
                defret = 134

            Case "Alolan Meowth"
                stamret = 120
                atkret = 99
                defret = 78

            Case "Meowth"
                stamret = 120
                atkret = 92
                defret = 78

            Case "Alolan Persian"
                stamret = 163
                atkret = 158
                defret = 136

            Case "Persian"
                stamret = 163
                atkret = 150
                defret = 136

            Case "Psyduck"
                stamret = 137
                atkret = 122
                defret = 95

            Case "Golduck"
                stamret = 190
                atkret = 191
                defret = 162

            Case "Mankey"
                stamret = 120
                atkret = 148
                defret = 82

            Case "Primeape"
                stamret = 163
                atkret = 207
                defret = 138

            Case "Growlithe"
                stamret = 146
                atkret = 136
                defret = 93

            Case "Arcanine"
                stamret = 207
                atkret = 227
                defret = 166

            Case "Poliwag"
                stamret = 120
                atkret = 101
                defret = 82

            Case "Poliwhirl"
                stamret = 163
                atkret = 130
                defret = 123

            Case "Poliwrath"
                stamret = 207
                atkret = 182
                defret = 184

            Case "Abra"
                stamret = 93
                atkret = 195
                defret = 82

            Case "Kadabra"
                stamret = 120
                atkret = 232
                defret = 117

            Case "Mega Alakazam"
                stamret = 133
                atkret = 334
                defret = 176

            Case "Alakazam"
                stamret = 146
                atkret = 271
                defret = 167

            Case "Machop"
                stamret = 172
                atkret = 137
                defret = 82

            Case "Machoke"
                stamret = 190
                atkret = 177
                defret = 125

            Case "Machamp"
                stamret = 207
                atkret = 234
                defret = 159

            Case "Bellsprout"
                stamret = 137
                atkret = 139
                defret = 61

            Case "Weepinbell"
                stamret = 163
                atkret = 172
                defret = 92

            Case "Victreebel"
                stamret = 190
                atkret = 207
                defret = 135

            Case "Tentacool"
                stamret = 120
                atkret = 97
                defret = 149

            Case "Tentacruel"
                stamret = 190
                atkret = 166
                defret = 209

            Case "Geodude"
                stamret = 120
                atkret = 132
                defret = 132

            Case "Alolan Geodude"
                stamret = 120
                atkret = 132
                defret = 132

            Case "Graveler"
                stamret = 146
                atkret = 164
                defret = 164

            Case "Alolan Graveler"
                stamret = 146
                atkret = 164
                defret = 164

            Case "Alolan Golem"
                stamret = 190
                atkret = 211
                defret = 198

            Case "Golem"
                stamret = 190
                atkret = 211
                defret = 198

            Case "Ponyta"
                stamret = 137
                atkret = 170
                defret = 127

            Case "Rapidash"
                stamret = 163
                atkret = 207
                defret = 162

            Case "Slowpoke"
                stamret = 207
                atkret = 109
                defret = 98

            Case "Mega Slowbro"
                stamret = 216
                atkret = 224
                defret = 259

            Case "Slowbro"
                stamret = 216
                atkret = 177
                defret = 180

            Case "Magnemite"
                stamret = 93
                atkret = 165
                defret = 121

            Case "Magneton"
                stamret = 137
                atkret = 223
                defret = 169

            Case "Farfetch'd"
                stamret = 141
                atkret = 124
                defret = 115

            Case "Doduo"
                stamret = 111
                atkret = 158
                defret = 83

            Case "Dodrio"
                stamret = 155
                atkret = 218
                defret = 140

            Case "Seel"
                stamret = 163
                atkret = 85
                defret = 121

            Case "Dewgong"
                stamret = 207
                atkret = 139
                defret = 177

            Case "Grimer"
                stamret = 190
                atkret = 135
                defret = 90

            Case "Alolan Grimer"
                stamret = 190
                atkret = 135
                defret = 90

            Case "Muk"
                stamret = 233
                atkret = 190
                defret = 172

            Case "Alolan Muk"
                stamret = 233
                atkret = 190
                defret = 172

            Case "Shellder"
                stamret = 102
                atkret = 116
                defret = 134

            Case "Cloyster"
                stamret = 137
                atkret = 186
                defret = 256

            Case "Gastly"
                stamret = 102
                atkret = 186
                defret = 67

            Case "Haunter"
                stamret = 128
                atkret = 223
                defret = 107

            Case "Mega Gengar"
                stamret = 141
                atkret = 317
                defret = 181

            Case "Gengar"
                stamret = 155
                atkret = 261
                defret = 149

            Case "Onix"
                stamret = 111
                atkret = 85
                defret = 232

            Case "Drowzee"
                stamret = 155
                atkret = 89
                defret = 136

            Case "Hypno"
                stamret = 198
                atkret = 144
                defret = 193

            Case "Krabby"
                stamret = 102
                atkret = 181
                defret = 124

            Case "Kingler"
                stamret = 146
                atkret = 240
                defret = 181

            Case "Voltorb"
                stamret = 120
                atkret = 109
                defret = 111

            Case "Electrode"
                stamret = 155
                atkret = 173
                defret = 173

            Case "Exeggcute"
                stamret = 155
                atkret = 107
                defret = 125

            Case "Exeggutor"
                stamret = 216
                atkret = 233
                defret = 149

            Case "Alolan Exeggutor"
                stamret = 216
                atkret = 230
                defret = 153

            Case "Cubone"
                stamret = 137
                atkret = 90
                defret = 144

            Case "Marowak"
                stamret = 155
                atkret = 144
                defret = 186

            Case "Alolan Marowak"
                stamret = 155
                atkret = 144
                defret = 186

            Case "Hitmonlee"
                stamret = 137
                atkret = 224
                defret = 181

            Case "Hitmonchan"
                stamret = 137
                atkret = 193
                defret = 197

            Case "Lickitung"
                stamret = 207
                atkret = 108
                defret = 137

            Case "Koffing"
                stamret = 120
                atkret = 119
                defret = 141

            Case "Weezing"
                stamret = 163
                atkret = 174
                defret = 197

            Case "Rhyhorn"
                stamret = 190
                atkret = 140
                defret = 127

            Case "Rhydon"
                stamret = 233
                atkret = 222
                defret = 171

            Case "Chansey"
                stamret = 487
                atkret = 60
                defret = 128

            Case "Tangela"
                stamret = 163
                atkret = 183
                defret = 169

            Case "Mega Kangaskhan"
                stamret = 233
                atkret = 246
                defret = 210

            Case "Kangaskhan"
                stamret = 233
                atkret = 181
                defret = 165

            Case "Horsea"
                stamret = 102
                atkret = 129
                defret = 103

            Case "Seadra"
                stamret = 146
                atkret = 187
                defret = 156

            Case "Goldeen"
                stamret = 128
                atkret = 123
                defret = 110

            Case "Seaking"
                stamret = 190
                atkret = 175
                defret = 147

            Case "Staryu"
                stamret = 102
                atkret = 137
                defret = 112

            Case "Starmie"
                stamret = 155
                atkret = 210
                defret = 184

            Case "Mr. Mime"
                stamret = 120
                atkret = 192
                defret = 205

            Case "Scyther"
                stamret = 172
                atkret = 218
                defret = 170

            Case "Jynx"
                stamret = 163
                atkret = 223
                defret = 151

            Case "Electabuzz"
                stamret = 163
                atkret = 198
                defret = 158

            Case "Magmar"
                stamret = 163
                atkret = 206
                defret = 154

            Case "Mega Pinsir"
                stamret = 149
                atkret = 278
                defret = 210

            Case "Pinsir"
                stamret = 163
                atkret = 238
                defret = 182

            Case "Tauros"
                stamret = 181
                atkret = 198
                defret = 183

            Case "Magikarp"
                stamret = 85
                atkret = 29
                defret = 85

            Case "Mega Gyarados"
                stamret = 197
                atkret = 266
                defret = 225

            Case "Gyarados"
                stamret = 216
                atkret = 237
                defret = 186

            Case "Lapras"
                stamret = 277
                atkret = 165
                defret = 174

            Case "Ditto"
                stamret = 134
                atkret = 91
                defret = 91

            Case "Eevee"
                stamret = 146
                atkret = 104
                defret = 114

            Case "Vaporeon"
                stamret = 277
                atkret = 205
                defret = 161

            Case "Jolteon"
                stamret = 163
                atkret = 232
                defret = 182

            Case "Flareon"
                stamret = 163
                atkret = 246
                defret = 179

            Case "Porygon"
                stamret = 163
                atkret = 153
                defret = 136

            Case "Omanyte"
                stamret = 111
                atkret = 155
                defret = 153

            Case "Omastar"
                stamret = 172
                atkret = 207
                defret = 201

            Case "Kabuto"
                stamret = 102
                atkret = 148
                defret = 140

            Case "Kabutops"
                stamret = 155
                atkret = 220
                defret = 186

            Case "Mega Aerodactyl"
                stamret = 173
                atkret = 266
                defret = 192

            Case "Aerodactyl"
                stamret = 190
                atkret = 221
                defret = 159

            Case "Snorlax"
                stamret = 330
                atkret = 190
                defret = 169

            Case "Articuno"
                stamret = 207
                atkret = 192
                defret = 236

            Case "Zapdos"
                stamret = 207
                atkret = 253
                defret = 185

            Case "Moltres"
                stamret = 207
                atkret = 251
                defret = 181

            Case "Dratini"
                stamret = 121
                atkret = 119
                defret = 91

            Case "Dragonair"
                stamret = 156
                atkret = 163
                defret = 135

            Case "Dragonite"
                stamret = 209
                atkret = 263
                defret = 198

            Case "Mega Mewtwo Y"
                stamret = 214
                atkret = 388
                defret = 209

            Case "Mega Mewtwo X"
                stamret = 214
                atkret = 375
                defret = 202

            Case "Mewtwo"
                stamret = 214
                atkret = 300
                defret = 182

            Case "Mew"
                stamret = 225
                atkret = 210
                defret = 210

            Case "Chikorita"
                stamret = 128
                atkret = 92
                defret = 122

            Case "Bayleef"
                stamret = 155
                atkret = 122
                defret = 155

            Case "Meganium"
                stamret = 190
                atkret = 168
                defret = 202

            Case "Cyndaquil"
                stamret = 118
                atkret = 116
                defret = 93

            Case "Quilava"
                stamret = 151
                atkret = 158
                defret = 126

            Case "Typhlosion"
                stamret = 186
                atkret = 223
                defret = 173

            Case "Totodile"
                stamret = 137
                atkret = 117
                defret = 109

            Case "Croconaw"
                stamret = 163
                atkret = 150
                defret = 142

            Case "Feraligatr"
                stamret = 198
                atkret = 205
                defret = 188

            Case "Sentret"
                stamret = 111
                atkret = 79
                defret = 73

            Case "Furret"
                stamret = 198
                atkret = 148
                defret = 125

            Case "Hoothoot"
                stamret = 155
                atkret = 67
                defret = 88

            Case "Noctowl"
                stamret = 225
                atkret = 145
                defret = 156

            Case "Ledyba"
                stamret = 120
                atkret = 72
                defret = 118

            Case "Ledian"
                stamret = 146
                atkret = 107
                defret = 179

            Case "Spinarak"
                stamret = 120
                atkret = 105
                defret = 73

            Case "Ariados"
                stamret = 172
                atkret = 161
                defret = 124

            Case "Crobat"
                stamret = 198
                atkret = 194
                defret = 178

            Case "Chinchou"
                stamret = 181
                atkret = 106
                defret = 97

            Case "Lanturn"
                stamret = 268
                atkret = 146
                defret = 137

            Case "Pichu"
                stamret = 85
                atkret = 77
                defret = 53

            Case "Cleffa"
                stamret = 137
                atkret = 75
                defret = 79

            Case "Igglybuff"
                stamret = 207
                atkret = 69
                defret = 32

            Case "Togepi"
                stamret = 111
                atkret = 67
                defret = 116

            Case "Togetic"
                stamret = 146
                atkret = 139
                defret = 181

            Case "Natu"
                stamret = 120
                atkret = 134
                defret = 89

            Case "Xatu"
                stamret = 163
                atkret = 192
                defret = 146

            Case "Mareep"
                stamret = 146
                atkret = 114
                defret = 79

            Case "Flaaffy"
                stamret = 172
                atkret = 145
                defret = 109

            Case "Mega Ampharos"
                stamret = 189
                atkret = 268
                defret = 185

            Case "Ampharos"
                stamret = 207
                atkret = 211
                defret = 169

            Case "Bellossom"
                stamret = 181
                atkret = 169
                defret = 186

            Case "Marill"
                stamret = 172
                atkret = 37
                defret = 93

            Case "Azumarill"
                stamret = 225
                atkret = 112
                defret = 152

            Case "Sudowoodo"
                stamret = 172
                atkret = 167
                defret = 176

            Case "Politoed"
                stamret = 207
                atkret = 174
                defret = 179

            Case "Hoppip"
                stamret = 111
                atkret = 67
                defret = 94

            Case "Skiploom"
                stamret = 146
                atkret = 91
                defret = 120

            Case "Jumpluff"
                stamret = 181
                atkret = 118
                defret = 183

            Case "Aipom"
                stamret = 146
                atkret = 136
                defret = 112

            Case "Sunkern"
                stamret = 102
                atkret = 55
                defret = 55

            Case "Sunflora"
                stamret = 181
                atkret = 185
                defret = 135

            Case "Yanma"
                stamret = 163
                atkret = 154
                defret = 94

            Case "Wooper"
                stamret = 146
                atkret = 75
                defret = 66

            Case "Quagsire"
                stamret = 216
                atkret = 152
                defret = 143

            Case "Espeon"
                stamret = 163
                atkret = 261
                defret = 175

            Case "Umbreon"
                stamret = 216
                atkret = 126
                defret = 240

            Case "Murkrow"
                stamret = 155
                atkret = 175
                defret = 87

            Case "Slowking"
                stamret = 216
                atkret = 177
                defret = 180

            Case "Misdreavus"
                stamret = 155
                atkret = 167
                defret = 154

            Case "Unown"
                stamret = 134
                atkret = 136
                defret = 91

            Case "Wobbuffet"
                stamret = 382
                atkret = 60
                defret = 106

            Case "Girafarig"
                stamret = 172
                atkret = 182
                defret = 133

            Case "Pineco"
                stamret = 137
                atkret = 108
                defret = 122

            Case "Forretress"
                stamret = 181
                atkret = 161
                defret = 205

            Case "Dunsparce"
                stamret = 225
                atkret = 131
                defret = 128

            Case "Gligar"
                stamret = 163
                atkret = 143
                defret = 184

            Case "Mega Steelix"
                stamret = 181
                atkret = 212
                defret = 327

            Case "Steelix"
                stamret = 181
                atkret = 148
                defret = 272

            Case "Snubbull"
                stamret = 155
                atkret = 137
                defret = 85

            Case "Granbull"
                stamret = 207
                atkret = 212
                defret = 131

            Case "Qwilfish"
                stamret = 163
                atkret = 184
                defret = 138

            Case "Mega Scizor"
                stamret = 157
                atkret = 254
                defret = 228

            Case "Scizor"
                stamret = 172
                atkret = 236
                defret = 181

            Case "Shuckle"
                stamret = 85
                atkret = 17
                defret = 396

            Case "Mega Heracross"
                stamret = 173
                atkret = 304
                defret = 203

            Case "Heracross"
                stamret = 190
                atkret = 234
                defret = 179

            Case "Sneasel"
                stamret = 146
                atkret = 189
                defret = 146

            Case "Teddiursa"
                stamret = 155
                atkret = 142
                defret = 93

            Case "Ursaring"
                stamret = 207
                atkret = 236
                defret = 144

            Case "Slugma"
                stamret = 120
                atkret = 118
                defret = 71

            Case "Magcargo"
                stamret = 137
                atkret = 139
                defret = 191

            Case "Swinub"
                stamret = 137
                atkret = 90
                defret = 69

            Case "Piloswine"
                stamret = 225
                atkret = 181
                defret = 138

            Case "Corsola"
                stamret = 146
                atkret = 118
                defret = 156

            Case "Remoraid"
                stamret = 111
                atkret = 127
                defret = 69

            Case "Octillery"
                stamret = 181
                atkret = 197
                defret = 141

            Case "Delibird"
                stamret = 128
                atkret = 128
                defret = 90

            Case "Mantine"
                stamret = 163
                atkret = 148
                defret = 226

            Case "Skarmory"
                stamret = 163
                atkret = 148
                defret = 226

            Case "Houndour"
                stamret = 128
                atkret = 152
                defret = 83

            Case "Mega Houndoom"
                stamret = 181
                atkret = 289
                defret = 194

            Case "Houndoom"
                stamret = 181
                atkret = 224
                defret = 144

            Case "Kingdra"
                stamret = 181
                atkret = 194
                defret = 194

            Case "Phanpy"
                stamret = 207
                atkret = 107
                defret = 98

            Case "Donphan"
                stamret = 207
                atkret = 214
                defret = 185

            Case "Porygon2"
                stamret = 198
                atkret = 198
                defret = 180

            Case "Stantler"
                stamret = 177
                atkret = 192
                defret = 131

            Case "Smeargle"
                stamret = 146
                atkret = 40
                defret = 83

            Case "Tyrogue"
                stamret = 111
                atkret = 64
                defret = 64

            Case "Hitmontop"
                stamret = 137
                atkret = 173
                defret = 207

            Case "Smoochum"
                stamret = 128
                atkret = 153
                defret = 91

            Case "Elekid"
                stamret = 128
                atkret = 135
                defret = 101

            Case "Magby"
                stamret = 128
                atkret = 151
                defret = 99

            Case "Miltank"
                stamret = 216
                atkret = 157
                defret = 193

            Case "Blissey"
                stamret = 496
                atkret = 129
                defret = 169

            Case "Raikou"
                stamret = 207
                atkret = 241
                defret = 195

            Case "Entei"
                stamret = 251
                atkret = 235
                defret = 171

            Case "Suicune"
                stamret = 225
                atkret = 180
                defret = 235

            Case "Larvitar"
                stamret = 137
                atkret = 115
                defret = 93

            Case "Pupitar"
                stamret = 172
                atkret = 155
                defret = 133

            Case "Mega Tyranitar"
                stamret = 205
                atkret = 281
                defret = 251

            Case "Tyranitar"
                stamret = 225
                atkret = 251
                defret = 207

            Case "Lugia"
                stamret = 235
                atkret = 193
                defret = 310

            Case "Ho-oh"
                stamret = 214
                atkret = 239
                defret = 244

            Case "Celebi"
                stamret = 225
                atkret = 210
                defret = 210

            Case "Treecko"
                stamret = 120
                atkret = 124
                defret = 94

            Case "Grovyle"
                stamret = 137
                atkret = 172
                defret = 120

            Case "Mega Sceptile"
                stamret = 157
                atkret = 292
                defret = 169

            Case "Sceptile"
                stamret = 172
                atkret = 223
                defret = 169

            Case "Torchic"
                stamret = 128
                atkret = 130
                defret = 87

            Case "Combusken"
                stamret = 155
                atkret = 163
                defret = 115

            Case "Mega Blaziken"
                stamret = 173
                atkret = 299
                defret = 153

            Case "Blaziken"
                stamret = 190
                atkret = 240
                defret = 141

            Case "Mudkip"
                stamret = 137
                atkret = 126
                defret = 93

            Case "Marshtomp"
                stamret = 172
                atkret = 156
                defret = 133

            Case "Mega Swampert"
                stamret = 205
                atkret = 258
                defret = 198

            Case "Swampert"
                stamret = 225
                atkret = 208
                defret = 175

            Case "Poochyena"
                stamret = 111
                atkret = 96
                defret = 61

            Case "Mightyena"
                stamret = 172
                atkret = 171
                defret = 132

            Case "Zigzagoon"
                stamret = 116
                atkret = 58
                defret = 80

            Case "Linoone"
                stamret = 186
                atkret = 142
                defret = 128

            Case "Wurmple"
                stamret = 128
                atkret = 75
                defret = 59

            Case "Silcoon"
                stamret = 137
                atkret = 60
                defret = 77

            Case "Beautifly"
                stamret = 155
                atkret = 189
                defret = 98

            Case "Cascoon"
                stamret = 137
                atkret = 60
                defret = 77

            Case "Dustox"
                stamret = 155
                atkret = 98
                defret = 162

            Case "Lotad"
                stamret = 120
                atkret = 71
                defret = 77

            Case "Lombre"
                stamret = 155
                atkret = 112
                defret = 119

            Case "Ludicolo"
                stamret = 190
                atkret = 173
                defret = 176

            Case "Seedot"
                stamret = 120
                atkret = 71
                defret = 77

            Case "Nuzleaf"
                stamret = 172
                atkret = 134
                defret = 78

            Case "Shiftry"
                stamret = 207
                atkret = 200
                defret = 121

            Case "Taillow"
                stamret = 120
                atkret = 106
                defret = 61

            Case "Swellow"
                stamret = 155
                atkret = 185
                defret = 124

            Case "Wingull"
                stamret = 120
                atkret = 106
                defret = 61

            Case "Pelipper"
                stamret = 155
                atkret = 175
                defret = 174

            Case "Ralts"
                stamret = 99
                atkret = 79
                defret = 59

            Case "Kirlia"
                stamret = 116
                atkret = 117
                defret = 90

            Case "Mega Gardevoir"
                stamret = 154
                atkret = 296
                defret = 208

            Case "Gardevoir"
                stamret = 169
                atkret = 237
                defret = 195

            Case "Surskit"
                stamret = 120
                atkret = 93
                defret = 87

            Case "Masquerain"
                stamret = 172
                atkret = 192
                defret = 150

            Case "Shroomish"
                stamret = 155
                atkret = 74
                defret = 110

            Case "Breloom"
                stamret = 155
                atkret = 241
                defret = 144

            Case "Slakoth"
                stamret = 155
                atkret = 104
                defret = 92

            Case "Vigoroth"
                stamret = 190
                atkret = 159
                defret = 145

            Case "Slaking"
                stamret = 284
                atkret = 290
                defret = 166

            Case "Nincada"
                stamret = 104
                atkret = 80
                defret = 126

            Case "Ninjask"
                stamret = 156
                atkret = 196
                defret = 112

            Case "Shedinja"
                stamret = 1
                atkret = 153
                defret = 73

            Case "Whismur"
                stamret = 162
                atkret = 92
                defret = 42

            Case "Loudred"
                stamret = 197
                atkret = 134
                defret = 81

            Case "Exploud"
                stamret = 232
                atkret = 179
                defret = 137

            Case "Makuhita"
                stamret = 176
                atkret = 99
                defret = 54

            Case "Hariyama"
                stamret = 302
                atkret = 209
                defret = 114

            Case "Azurill"
                stamret = 137
                atkret = 36
                defret = 71

            Case "Nosepass"
                stamret = 102
                atkret = 82
                defret = 215

            Case "Skitty"
                stamret = 137
                atkret = 84
                defret = 79

            Case "Delcatty"
                stamret = 172
                atkret = 132
                defret = 127

            Case "Mega Sableye"
                stamret = 137
                atkret = 151
                defret = 216

            Case "Sableye"
                stamret = 137
                atkret = 141
                defret = 136

            Case "Mega Mawile"
                stamret = 137
                atkret = 188
                defret = 217

            Case "Mawile"
                stamret = 137
                atkret = 155
                defret = 141

            Case "Aron"
                stamret = 137
                atkret = 121
                defret = 141

            Case "Lairon"
                stamret = 155
                atkret = 158
                defret = 198

            Case "Mega Aggron"
                stamret = 157
                atkret = 225
                defret = 301

            Case "Aggron"
                stamret = 172
                atkret = 198
                defret = 257

            Case "Meditite"
                stamret = 102
                atkret = 78
                defret = 107

            Case "Mega Medicham"
                stamret = 155
                atkret = 205
                defret = 179

            Case "Medicham"
                stamret = 155
                atkret = 121
                defret = 152

            Case "Electrike"
                stamret = 120
                atkret = 123
                defret = 78

            Case "Mega Manectric"
                stamret = 172
                atkret = 286
                defret = 179

            Case "Manectric"
                stamret = 172
                atkret = 215
                defret = 127

            Case "Plusle"
                stamret = 155
                atkret = 167
                defret = 129

            Case "Minun"
                stamret = 155
                atkret = 147
                defret = 150

            Case "Volbeat"
                stamret = 163
                atkret = 143
                defret = 166

            Case "Illumise"
                stamret = 163
                atkret = 143
                defret = 166

            Case "Roselia"
                stamret = 137
                atkret = 186
                defret = 131

            Case "Gulpin"
                stamret = 172
                atkret = 80
                defret = 99

            Case "Swalot"
                stamret = 225
                atkret = 140
                defret = 159

            Case "Carvanha"
                stamret = 128
                atkret = 171
                defret = 39

            Case "Mega Sharpedo"
                stamret = 172
                atkret = 289
                defret = 144

            Case "Sharpedo"
                stamret = 172
                atkret = 243
                defret = 83

            Case "Wailmer"
                stamret = 277
                atkret = 136
                defret = 68

            Case "Wailord"
                stamret = 347
                atkret = 175
                defret = 87

            Case "Numel"
                stamret = 155
                atkret = 119
                defret = 79

            Case "Mega Camerupt"
                stamret = 172
                atkret = 253
                defret = 183

            Case "Camerupt"
                stamret = 172
                atkret = 194
                defret = 136

            Case "Torkoal"
                stamret = 172
                atkret = 151
                defret = 203

            Case "Spoink"
                stamret = 155
                atkret = 125
                defret = 122

            Case "Grumpig"
                stamret = 190
                atkret = 171
                defret = 188

            Case "Spinda"
                stamret = 155
                atkret = 116
                defret = 116

            Case "Trapinch"
                stamret = 128
                atkret = 162
                defret = 78

            Case "Vibrava"
                stamret = 137
                atkret = 134
                defret = 99

            Case "Flygon"
                stamret = 190
                atkret = 205
                defret = 168

            Case "Cacnea"
                stamret = 137
                atkret = 156
                defret = 74

            Case "Cacturne"
                stamret = 172
                atkret = 221
                defret = 115

            Case "Swablu"
                stamret = 128
                atkret = 76
                defret = 132

            Case "Mega Altaria"
                stamret = 181
                atkret = 222
                defret = 218

            Case "Altaria"
                stamret = 181
                atkret = 141
                defret = 201

            Case "Zangoose"
                stamret = 177
                atkret = 222
                defret = 124

            Case "Seviper"
                stamret = 177
                atkret = 196
                defret = 118

            Case "Lunatone"
                stamret = 207
                atkret = 178
                defret = 153

            Case "Solrock"
                stamret = 207
                atkret = 178
                defret = 153

            Case "Barboach"
                stamret = 137
                atkret = 93
                defret = 82

            Case "Whiscash"
                stamret = 242
                atkret = 151
                defret = 141

            Case "Corphish"
                stamret = 125
                atkret = 141
                defret = 99

            Case "Crawdaunt"
                stamret = 160
                atkret = 224
                defret = 142

            Case "Baltoy"
                stamret = 120
                atkret = 77
                defret = 124

            Case "Claydol"
                stamret = 155
                atkret = 140
                defret = 229

            Case "Lileep"
                stamret = 165
                atkret = 105
                defret = 150

            Case "Cradily"
                stamret = 200
                atkret = 152
                defret = 194

            Case "Anorith"
                stamret = 128
                atkret = 176
                defret = 100

            Case "Armaldo"
                stamret = 181
                atkret = 222
                defret = 174

            Case "Feebas"
                stamret = 85
                atkret = 29
                defret = 85

            Case "Milotic"
                stamret = 216
                atkret = 192
                defret = 219

            Case "Castform"
                stamret = 172
                atkret = 139
                defret = 139

            Case "Kecleon"
                stamret = 155
                atkret = 161
                defret = 189

            Case "Shuppet"
                stamret = 127
                atkret = 138
                defret = 65

            Case "Mega Banette"
                stamret = 162
                atkret = 312
                defret = 160

            Case "Banette"
                stamret = 162
                atkret = 218
                defret = 126

            Case "Duskull"
                stamret = 85
                atkret = 70
                defret = 162

            Case "Dusclops"
                stamret = 120
                atkret = 124
                defret = 234

            Case "Tropius"
                stamret = 223
                atkret = 136
                defret = 163

            Case "Chimecho"
                stamret = 181
                atkret = 175
                defret = 170

            Case "Mega Absol"
                stamret = 163
                atkret = 314
                defret = 130

            Case "Absol"
                stamret = 163
                atkret = 246
                defret = 120

            Case "Wynaut"
                stamret = 216
                atkret = 41
                defret = 86

            Case "Snorunt"
                stamret = 137
                atkret = 95
                defret = 95

            Case "Mega Glalie"
                stamret = 190
                atkret = 252
                defret = 168

            Case "Glalie"
                stamret = 190
                atkret = 162
                defret = 162

            Case "Spheal"
                stamret = 172
                atkret = 95
                defret = 90

            Case "Sealeo"
                stamret = 207
                atkret = 137
                defret = 132

            Case "Walrein"
                stamret = 242
                atkret = 182
                defret = 176

            Case "Clamperl"
                stamret = 111
                atkret = 133
                defret = 135

            Case "Huntail"
                stamret = 146
                atkret = 197
                defret = 179

            Case "Gorebyss"
                stamret = 146
                atkret = 211
                defret = 179

            Case "Relicanth"
                stamret = 225
                atkret = 162
                defret = 203

            Case "Luvdisc"
                stamret = 125
                atkret = 81
                defret = 128

            Case "Bagon"
                stamret = 128
                atkret = 134
                defret = 93

            Case "Shelgon"
                stamret = 163
                atkret = 172
                defret = 155

            Case "Mega Salamence"
                stamret = 197
                atkret = 282
                defret = 228

            Case "Salamence"
                stamret = 216
                atkret = 277
                defret = 168

            Case "Beldum"
                stamret = 120
                atkret = 96
                defret = 132

            Case "Metang"
                stamret = 155
                atkret = 138
                defret = 176

            Case "Mega Metagross"
                stamret = 173
                atkret = 273
                defret = 263

            Case "Metagross"
                stamret = 190
                atkret = 257
                defret = 228

            Case "Regirock"
                stamret = 190
                atkret = 179
                defret = 309

            Case "Regice"
                stamret = 190
                atkret = 179
                defret = 309

            Case "Registeel"
                stamret = 190
                atkret = 143
                defret = 285

            Case "Mega Latias"
                stamret = 173
                atkret = 263
                defret = 271

            Case "Latias"
                stamret = 190
                atkret = 228
                defret = 246

            Case "Mega Latios"
                stamret = 173
                atkret = 305
                defret = 219

            Case "Latios"
                stamret = 190
                atkret = 268
                defret = 212

            Case "Primal Kyogre"
                stamret = 205
                atkret = 331
                defret = 251

            Case "Kyogre"
                stamret = 205
                atkret = 270
                defret = 228

            Case "Primal Groudon"
                stamret = 205
                atkret = 331
                defret = 251

            Case "Groudon"
                stamret = 205
                atkret = 270
                defret = 228

            Case "Mega Rayquaza"
                stamret = 213
                atkret = 354
                defret = 197

            Case "Rayquaza"
                stamret = 213
                atkret = 284
                defret = 170

            Case "Jirachi"
                stamret = 225
                atkret = 210
                defret = 210

            Case "Deoxys"
                stamret = 137
                atkret = 345
                defret = 115

            Case "Deoxys Speed"
                stamret = 137
                atkret = 230
                defret = 218

            Case "Deoxys Attack"
                stamret = 137
                atkret = 414
                defret = 46

            Case "Deoxys Defense"
                stamret = 137
                atkret = 144
                defret = 330

            Case "Turtwig"
                stamret = 146
                atkret = 119
                defret = 110

            Case "Grotle"
                stamret = 181
                atkret = 157
                defret = 143

            Case "Torterra"
                stamret = 216
                atkret = 202
                defret = 188

            Case "Chimchar"
                stamret = 127
                atkret = 113
                defret = 86

            Case "Monferno"
                stamret = 162
                atkret = 158
                defret = 105

            Case "Infernape"
                stamret = 183
                atkret = 222
                defret = 151

            Case "Piplup"
                stamret = 142
                atkret = 112
                defret = 102

            Case "Prinplup"
                stamret = 162
                atkret = 150
                defret = 139

            Case "Empoleon"
                stamret = 197
                atkret = 210
                defret = 186

            Case "Starly"
                stamret = 120
                atkret = 101
                defret = 58

            Case "Staravia"
                stamret = 146
                atkret = 142
                defret = 94

            Case "Staraptor"
                stamret = 198
                atkret = 234
                defret = 140

            Case "Bidoof"
                stamret = 153
                atkret = 80
                defret = 73

            Case "Bibarel"
                stamret = 188
                atkret = 162
                defret = 119

            Case "Kricketot"
                stamret = 114
                atkret = 45
                defret = 74

            Case "Kricketune"
                stamret = 184
                atkret = 160
                defret = 100

            Case "Shinx"
                stamret = 128
                atkret = 117
                defret = 64

            Case "Luxio"
                stamret = 155
                atkret = 159
                defret = 95

            Case "Luxray"
                stamret = 190
                atkret = 232
                defret = 156

            Case "Budew"
                stamret = 120
                atkret = 91
                defret = 109

            Case "Roserade"
                stamret = 155
                atkret = 243
                defret = 185

            Case "Cranidos"
                stamret = 167
                atkret = 218
                defret = 71

            Case "Rampardos"
                stamret = 219
                atkret = 295
                defret = 109

            Case "Shieldon"
                stamret = 102
                atkret = 76
                defret = 195

            Case "Bastiodon"
                stamret = 155
                atkret = 94
                defret = 286

            Case "Burmy"
                stamret = 120
                atkret = 53
                defret = 83

            Case "Wormadam Plant"
                stamret = 155
                atkret = 141
                defret = 180

            Case "Wormadam Sandy"
                stamret = 155
                atkret = 141
                defret = 180

            Case "Wormadam Trash"
                stamret = 155
                atkret = 127
                defret = 175

            Case "Mothim"
                stamret = 172
                atkret = 185
                defret = 98

            Case "Combee"
                stamret = 102
                atkret = 59
                defret = 83

            Case "Vespiquen"
                stamret = 172
                atkret = 149
                defret = 190

            Case "Pachirisu"
                stamret = 155
                atkret = 94
                defret = 172

            Case "Buizel"
                stamret = 146
                atkret = 132
                defret = 67

            Case "Floatzel"
                stamret = 198
                atkret = 221
                defret = 114

            Case "Cherubi"
                stamret = 128
                atkret = 108
                defret = 92

            Case "Cherrim"
                stamret = 172
                atkret = 170
                defret = 153

            Case "Shellos"
                stamret = 183
                atkret = 103
                defret = 105

            Case "Gastrodon"
                stamret = 244
                atkret = 169
                defret = 143

            Case "Ambipom"
                stamret = 181
                atkret = 205
                defret = 143

            Case "Drifloon"
                stamret = 207
                atkret = 117
                defret = 80

            Case "Drifblim"
                stamret = 312
                atkret = 180
                defret = 102

            Case "Buneary"
                stamret = 146
                atkret = 130
                defret = 105

            Case "Mega Lopunny"
                stamret = 163
                atkret = 282
                defret = 214

            Case "Lopunny"
                stamret = 163
                atkret = 156
                defret = 194

            Case "Mismagius"
                stamret = 155
                atkret = 211
                defret = 187

            Case "Honchkrow"
                stamret = 225
                atkret = 243
                defret = 103

            Case "Glameow"
                stamret = 135
                atkret = 109
                defret = 82

            Case "Purugly"
                stamret = 174
                atkret = 172
                defret = 133

            Case "Chingling"
                stamret = 128
                atkret = 114
                defret = 94

            Case "Stunky"
                stamret = 160
                atkret = 121
                defret = 90

            Case "Skuntank"
                stamret = 230
                atkret = 184
                defret = 132

            Case "Bronzor"
                stamret = 149
                atkret = 43
                defret = 154

            Case "Bronzong"
                stamret = 167
                atkret = 161
                defret = 213

            Case "Bonsly"
                stamret = 137
                atkret = 124
                defret = 133

            Case "Mime Jr."
                stamret = 85
                atkret = 125
                defret = 142

            Case "Happiny"
                stamret = 225
                atkret = 25
                defret = 77

            Case "Chatot"
                stamret = 183
                atkret = 183
                defret = 91

            Case "Spiritomb"
                stamret = 137
                atkret = 169
                defret = 199

            Case "Gible"
                stamret = 151
                atkret = 124
                defret = 84

            Case "Gabite"
                stamret = 169
                atkret = 172
                defret = 125

            Case "Mega Garchomp"
                stamret = 217
                atkret = 309
                defret = 202

            Case "Garchomp"
                stamret = 239
                atkret = 261
                defret = 193

            Case "Munchlax"
                stamret = 286
                atkret = 137
                defret = 117

            Case "Riolu"
                stamret = 120
                atkret = 127
                defret = 78

            Case "Mega Lucario"
                stamret = 172
                atkret = 310
                defret = 175

            Case "Lucario"
                stamret = 172
                atkret = 236
                defret = 144

            Case "Hippopotas"
                stamret = 169
                atkret = 124
                defret = 118

            Case "Hippowdon"
                stamret = 239
                atkret = 201
                defret = 191

            Case "Skorupi"
                stamret = 120
                atkret = 93
                defret = 151

            Case "Drapion"
                stamret = 172
                atkret = 180
                defret = 202

            Case "Croagunk"
                stamret = 134
                atkret = 116
                defret = 76

            Case "Toxicroak"
                stamret = 195
                atkret = 211
                defret = 133

            Case "Carnivine"
                stamret = 179
                atkret = 187
                defret = 136

            Case "Finneon"
                stamret = 135
                atkret = 96
                defret = 116

            Case "Lumineon"
                stamret = 170
                atkret = 142
                defret = 170

            Case "Mantyke"
                stamret = 128
                atkret = 105
                defret = 179

            Case "Snover"
                stamret = 155
                atkret = 115
                defret = 105

            Case "Mega Abomasnow"
                stamret = 207
                atkret = 240
                defret = 191

            Case "Abomasnow"
                stamret = 207
                atkret = 178
                defret = 158

            Case "Weavile"
                stamret = 172
                atkret = 243
                defret = 171

            Case "Magnezone"
                stamret = 172
                atkret = 238
                defret = 205

            Case "Lickilicky"
                stamret = 242
                atkret = 161
                defret = 181

            Case "Rhyperior"
                stamret = 251
                atkret = 241
                defret = 190

            Case "Tangrowth"
                stamret = 225
                atkret = 207
                defret = 184

            Case "Electivire"
                stamret = 181
                atkret = 249
                defret = 163

            Case "Magmortar"
                stamret = 181
                atkret = 247
                defret = 172

            Case "Togekiss"
                stamret = 198
                atkret = 225
                defret = 217

            Case "Yanmega"
                stamret = 200
                atkret = 231
                defret = 156

            Case "Leafeon"
                stamret = 163
                atkret = 216
                defret = 219

            Case "Glaceon"
                stamret = 163
                atkret = 238
                defret = 205

            Case "Gliscor"
                stamret = 181
                atkret = 185
                defret = 222

            Case "Mamoswine"
                stamret = 242
                atkret = 247
                defret = 146

            Case "Porygon-Z"
                stamret = 198
                atkret = 264
                defret = 150

            Case "Mega Gallade"
                stamret = 154
                atkret = 297
                defret = 209

            Case "Gallade"
                stamret = 169
                atkret = 237
                defret = 195

            Case "Probopass"
                stamret = 155
                atkret = 135
                defret = 275

            Case "Dusknoir"
                stamret = 128
                atkret = 180
                defret = 254

            Case "Froslass"
                stamret = 172
                atkret = 171
                defret = 150

            Case "Rotom Heat"
                stamret = 137
                atkret = 204
                defret = 219

            Case "Rotom Wash"
                stamret = 137
                atkret = 204
                defret = 219

            Case "Rotom Frost"
                stamret = 137
                atkret = 204
                defret = 219

            Case "Rotom Spin"
                stamret = 137
                atkret = 204
                defret = 219

            Case "Rotom Cut"
                stamret = 137
                atkret = 204
                defret = 219

            Case "Rotom"
                stamret = 137
                atkret = 185
                defret = 159

            Case "Uxie"
                stamret = 181
                atkret = 156
                defret = 270

            Case "Mesprit"
                stamret = 190
                atkret = 212
                defret = 212

            Case "Azelf"
                stamret = 181
                atkret = 270
                defret = 151

            Case "Dialga"
                stamret = 205
                atkret = 275
                defret = 211

            Case "Palkia"
                stamret = 189
                atkret = 280
                defret = 215

            Case "Heatran"
                stamret = 209
                atkret = 251
                defret = 213

            Case "Regigigas"
                stamret = 221
                atkret = 287
                defret = 210

            Case "Giratina Origin"
                stamret = 284
                atkret = 225
                defret = 187

            Case "Giratina Altered"
                stamret = 284
                atkret = 187
                defret = 225

            Case "Cresselia"
                stamret = 260
                atkret = 152
                defret = 258

            Case "Phione"
                stamret = 190
                atkret = 162
                defret = 162

            Case "Manaphy"
                stamret = 225
                atkret = 210
                defret = 210

            Case "Darkrai"
                stamret = 172
                atkret = 285
                defret = 198

            Case "Shaymin Sky"
                stamret = 225
                atkret = 261
                defret = 166

            Case "Shaymin"
                stamret = 225
                atkret = 210
                defret = 210

            Case "Arceus"
                stamret = 237
                atkret = 238
                defret = 238

            Case "Victini"
                stamret = 225
                atkret = 210
                defret = 210

            Case "Snivy"
                stamret = 128
                atkret = 88
                defret = 107

            Case "Servine"
                stamret = 155
                atkret = 122
                defret = 152

            Case "Serperior"
                stamret = 181
                atkret = 161
                defret = 204

            Case "Tepig"
                stamret = 163
                atkret = 115
                defret = 85

            Case "Pignite"
                stamret = 207
                atkret = 173
                defret = 106

            Case "Emboar"
                stamret = 242
                atkret = 235
                defret = 127

            Case "Oshawott"
                stamret = 146
                atkret = 117
                defret = 85

            Case "Dewott"
                stamret = 181
                atkret = 159
                defret = 116

            Case "Samurott"
                stamret = 216
                atkret = 212
                defret = 157

            Case "Patrat"
                stamret = 128
                atkret = 98
                defret = 73

            Case "Watchog"
                stamret = 155
                atkret = 165
                defret = 139

            Case "Lillipup"
                stamret = 128
                atkret = 107
                defret = 86

            Case "Herdier"
                stamret = 163
                atkret = 145
                defret = 126

            Case "Stoutland"
                stamret = 198
                atkret = 206
                defret = 182

            Case "Purrloin"
                stamret = 121
                atkret = 98
                defret = 73

            Case "Liepard"
                stamret = 162
                atkret = 187
                defret = 106

            Case "Pansage"
                stamret = 137
                atkret = 104
                defret = 94

            Case "Simisage"
                stamret = 181
                atkret = 206
                defret = 133

            Case "Pansear"
                stamret = 137
                atkret = 104
                defret = 94

            Case "Simisear"
                stamret = 181
                atkret = 206
                defret = 133

            Case "Panpour"
                stamret = 137
                atkret = 104
                defret = 94

            Case "Simipour"
                stamret = 181
                atkret = 206
                defret = 133

            Case "Munna"
                stamret = 183
                atkret = 111
                defret = 92

            Case "Musharna"
                stamret = 253
                atkret = 183
                defret = 166

            Case "Pidove"
                stamret = 137
                atkret = 98
                defret = 80

            Case "Tranquill"
                stamret = 158
                atkret = 144
                defret = 107

            Case "Unfezant"
                stamret = 190
                atkret = 226
                defret = 146

            Case "Blitzle"
                stamret = 128
                atkret = 118
                defret = 64

            Case "Zebstrika"
                stamret = 181
                atkret = 211
                defret = 136

            Case "Roggenrola"
                stamret = 146
                atkret = 121
                defret = 110

            Case "Boldore"
                stamret = 172
                atkret = 174
                defret = 143

            Case "Gigalith"
                stamret = 198
                atkret = 226
                defret = 201

            Case "Woobat"
                stamret = 163
                atkret = 107
                defret = 85

            Case "Swoobat"
                stamret = 167
                atkret = 161
                defret = 119

            Case "Drilbur"
                stamret = 155
                atkret = 154
                defret = 85

            Case "Excadrill"
                stamret = 242
                atkret = 255
                defret = 129

            Case "Mega Audino"
                stamret = 230
                atkret = 147
                defret = 239

            Case "Audino"
                stamret = 230
                atkret = 114
                defret = 163

            Case "Timburr"
                stamret = 181
                atkret = 134
                defret = 87

            Case "Gurdurr"
                stamret = 198
                atkret = 180
                defret = 134

            Case "Conkeldurr"
                stamret = 233
                atkret = 243
                defret = 158

            Case "Tympole"
                stamret = 137
                atkret = 98
                defret = 78

            Case "Palpitoad"
                stamret = 181
                atkret = 128
                defret = 109

            Case "Seismitoad"
                stamret = 233
                atkret = 188
                defret = 150

            Case "Throh"
                stamret = 260
                atkret = 172
                defret = 160

            Case "Sawk"
                stamret = 181
                atkret = 231
                defret = 153

            Case "Sewaddle"
                stamret = 128
                atkret = 96
                defret = 124

            Case "Swadloon"
                stamret = 146
                atkret = 115
                defret = 162

            Case "Leavanny"
                stamret = 181
                atkret = 205
                defret = 165

            Case "Venipede"
                stamret = 102
                atkret = 83
                defret = 99

            Case "Whirlipede"
                stamret = 120
                atkret = 100
                defret = 173

            Case "Scolipede"
                stamret = 155
                atkret = 203
                defret = 175

            Case "Cottonee"
                stamret = 120
                atkret = 71
                defret = 111

            Case "Whimsicott"
                stamret = 155
                atkret = 164
                defret = 176

            Case "Petilil"
                stamret = 128
                atkret = 119
                defret = 91

            Case "Lilligant"
                stamret = 172
                atkret = 214
                defret = 155

            Case "Basculin"
                stamret = 172
                atkret = 189
                defret = 129

            Case "Sandile"
                stamret = 137
                atkret = 132
                defret = 69

            Case "Krokorok"
                stamret = 155
                atkret = 155
                defret = 90

            Case "Krookodile"
                stamret = 216
                atkret = 229
                defret = 158

            Case "Darumaka"
                stamret = 172
                atkret = 153
                defret = 86

            Case "Darmanitan Zen"
                stamret = 233
                atkret = 243
                defret = 202

            Case "Darmanitan"
                stamret = 233
                atkret = 263
                defret = 114

            Case "Maractus"
                stamret = 181
                atkret = 201
                defret = 130

            Case "Dwebble"
                stamret = 137
                atkret = 118
                defret = 128

            Case "Crustle"
                stamret = 172
                atkret = 188
                defret = 200

            Case "Scraggy"
                stamret = 137
                atkret = 132
                defret = 132

            Case "Scrafty"
                stamret = 163
                atkret = 163
                defret = 222

            Case "Sigilyph"
                stamret = 176
                atkret = 204
                defret = 167

            Case "Yamask"
                stamret = 116
                atkret = 95
                defret = 141

            Case "Cofagrigus"
                stamret = 151
                atkret = 163
                defret = 237

            Case "Tirtouga"
                stamret = 144
                atkret = 134
                defret = 146

            Case "Carracosta"
                stamret = 179
                atkret = 192
                defret = 197

            Case "Archen"
                stamret = 146
                atkret = 213
                defret = 89

            Case "Archeops"
                stamret = 181
                atkret = 292
                defret = 139

            Case "Trubbish"
                stamret = 137
                atkret = 96
                defret = 122

            Case "Garbodor"
                stamret = 190
                atkret = 181
                defret = 164

            Case "Zorua"
                stamret = 120
                atkret = 153
                defret = 78

            Case "Zoroark"
                stamret = 155
                atkret = 250
                defret = 127

            Case "Minccino"
                stamret = 146
                atkret = 98
                defret = 80

            Case "Cinccino"
                stamret = 181
                atkret = 198
                defret = 130

            Case "Gothita"
                stamret = 128
                atkret = 98
                defret = 112

            Case "Gothorita"
                stamret = 155
                atkret = 137
                defret = 153

            Case "Gothitelle"
                stamret = 172
                atkret = 176
                defret = 205

            Case "Solosis"
                stamret = 128
                atkret = 170
                defret = 83

            Case "Duosion"
                stamret = 163
                atkret = 208
                defret = 103

            Case "Reuniclus"
                stamret = 242
                atkret = 214
                defret = 148

            Case "Ducklett"
                stamret = 158
                atkret = 84
                defret = 96

            Case "Swanna"
                stamret = 181
                atkret = 182
                defret = 132

            Case "Vanillite"
                stamret = 113
                atkret = 118
                defret = 106

            Case "Vanillish"
                stamret = 139
                atkret = 151
                defret = 138

            Case "Vanilluxe"
                stamret = 174
                atkret = 218
                defret = 184

            Case "Deerling"
                stamret = 155
                atkret = 115
                defret = 100

            Case "Sawsbuck"
                stamret = 190
                atkret = 198
                defret = 146

            Case "Emolga"
                stamret = 146
                atkret = 158
                defret = 127

            Case "Karrablast"
                stamret = 137
                atkret = 137
                defret = 87

            Case "Escavalier"
                stamret = 172
                atkret = 223
                defret = 187

            Case "Foongus"
                stamret = 170
                atkret = 97
                defret = 91

            Case "Amoonguss"
                stamret = 249
                atkret = 155
                defret = 139

            Case "Frillish"
                stamret = 146
                atkret = 115
                defret = 134

            Case "Jellicent"
                stamret = 225
                atkret = 159
                defret = 178

            Case "Alomomola"
                stamret = 338
                atkret = 138
                defret = 131

            Case "Joltik"
                stamret = 137
                atkret = 110
                defret = 98

            Case "Galvantula"
                stamret = 172
                atkret = 201
                defret = 128

            Case "Ferroseed"
                stamret = 127
                atkret = 82
                defret = 155

            Case "Ferrothorn"
                stamret = 179
                atkret = 158
                defret = 223

            Case "Klink"
                stamret = 120
                atkret = 98
                defret = 121

            Case "Klang"
                stamret = 155
                atkret = 150
                defret = 174

            Case "Klinklang"
                stamret = 155
                atkret = 199
                defret = 214

            Case "Tynamo"
                stamret = 111
                atkret = 105
                defret = 78

            Case "Eelektrik"
                stamret = 163
                atkret = 156
                defret = 130

            Case "Eelektross"
                stamret = 198
                atkret = 217
                defret = 152

            Case "Elgyem"
                stamret = 146
                atkret = 148
                defret = 100

            Case "Beheeyem"
                stamret = 181
                atkret = 221
                defret = 163

            Case "Litwick"
                stamret = 137
                atkret = 108
                defret = 98

            Case "Lampent"
                stamret = 155
                atkret = 169
                defret = 115

            Case "Chandelure"
                stamret = 155
                atkret = 271
                defret = 182

            Case "Axew"
                stamret = 130
                atkret = 154
                defret = 101

            Case "Fraxure"
                stamret = 165
                atkret = 212
                defret = 123

            Case "Haxorus"
                stamret = 183
                atkret = 284
                defret = 172

            Case "Cubchoo"
                stamret = 146
                atkret = 128
                defret = 74

            Case "Beartic"
                stamret = 216
                atkret = 233
                defret = 152

            Case "Cryogonal"
                stamret = 190
                atkret = 190
                defret = 218

            Case "Shelmet"
                stamret = 137
                atkret = 72
                defret = 140

            Case "Accelgor"
                stamret = 190
                atkret = 220
                defret = 120

            Case "Stunfisk"
                stamret = 240
                atkret = 144
                defret = 171

            Case "Mienfoo"
                stamret = 128
                atkret = 160
                defret = 98

            Case "Mienshao"
                stamret = 163
                atkret = 258
                defret = 127

            Case "Druddigon"
                stamret = 184
                atkret = 213
                defret = 170

            Case "Golett"
                stamret = 153
                atkret = 127
                defret = 92

            Case "Golurk"
                stamret = 205
                atkret = 222
                defret = 154

            Case "Pawniard"
                stamret = 128
                atkret = 154
                defret = 114

            Case "Bisharp"
                stamret = 163
                atkret = 232
                defret = 176

            Case "Bouffalant"
                stamret = 216
                atkret = 195
                defret = 182

            Case "Rufflet"
                stamret = 172
                atkret = 150
                defret = 97

            Case "Braviary"
                stamret = 225
                atkret = 232
                defret = 152

            Case "Vullaby"
                stamret = 172
                atkret = 105
                defret = 139

            Case "Mandibuzz"
                stamret = 242
                atkret = 129
                defret = 205

            Case "Heatmor"
                stamret = 198
                atkret = 204
                defret = 129

            Case "Durant"
                stamret = 151
                atkret = 217
                defret = 188

            Case "Deino"
                stamret = 141
                atkret = 116
                defret = 93

            Case "Zweilous"
                stamret = 176
                atkret = 159
                defret = 135

            Case "Hydreigon"
                stamret = 211
                atkret = 256
                defret = 188

            Case "Larvesta"
                stamret = 146
                atkret = 156
                defret = 107

            Case "Volcarona"
                stamret = 198
                atkret = 264
                defret = 189

            Case "Cobalion"
                stamret = 209
                atkret = 192
                defret = 229

            Case "Terrakion"
                stamret = 209
                atkret = 260
                defret = 192

            Case "Virizion"
                stamret = 209
                atkret = 192
                defret = 229

            Case "Tornadus"
                stamret = 188
                atkret = 266
                defret = 164

            Case "Tornadus Therian"
                stamret = 188
                atkret = 238
                defret = 189

            Case "Thundurus Therian"
                stamret = 188
                atkret = 295
                defret = 161

            Case "Thundurus"
                stamret = 188
                atkret = 266
                defret = 164

            Case "Reshiram"
                stamret = 205
                atkret = 275
                defret = 211

            Case "Zekrom"
                stamret = 205
                atkret = 275
                defret = 211

            Case "Landorus Therian"
                stamret = 205
                atkret = 289
                defret = 179

            Case "Landorus"
                stamret = 205
                atkret = 261
                defret = 182

            Case "Kyurem White"
                stamret = 245
                atkret = 310
                defret = 183

            Case "Kyurem Black"
                stamret = 245
                atkret = 310
                defret = 183

            Case "Kyurem"
                stamret = 245
                atkret = 246
                defret = 170

            Case "Keldeo Resolute"
                stamret = 209
                atkret = 260
                defret = 192

            Case "Keldeo"
                stamret = 209
                atkret = 260
                defret = 192

            Case "Meloetta Aria"
                stamret = 225
                atkret = 250
                defret = 225

            Case "Meloetta Pirouette"
                stamret = 225
                atkret = 269
                defret = 188

            Case "Genesect"
                stamret = 174
                atkret = 252
                defret = 199

            Case "Chespin"
                stamret = 148
                atkret = 110
                defret = 106

            Case "Quilladin"
                stamret = 156
                atkret = 146
                defret = 156

            Case "Chesnaught"
                stamret = 204
                atkret = 201
                defret = 204

            Case "Fennekin"
                stamret = 120
                atkret = 116
                defret = 102

            Case "Braixen"
                stamret = 153
                atkret = 171
                defret = 130

            Case "Delphox"
                stamret = 181
                atkret = 230
                defret = 189

            Case "Froakie"
                stamret = 121
                atkret = 122
                defret = 84

            Case "Frogadier"
                stamret = 144
                atkret = 168
                defret = 114

            Case "Ash-Greninja"
                stamret = 176
                atkret = 339
                defret = 155

            Case "Greninja"
                stamret = 176
                atkret = 223
                defret = 152

            Case "Bunnelby"
                stamret = 116
                atkret = 68
                defret = 72

            Case "Diggersby"
                stamret = 198
                atkret = 112
                defret = 155

            Case "Fletchling"
                stamret = 128
                atkret = 95
                defret = 80

            Case "Fletchinder"
                stamret = 158
                atkret = 145
                defret = 110

            Case "Talonflame"
                stamret = 186
                atkret = 176
                defret = 155

            Case "Scatterbug"
                stamret = 116
                atkret = 63
                defret = 63

            Case "Spewpa"
                stamret = 128
                atkret = 48
                defret = 89

            Case "Vivillon"
                stamret = 190
                atkret = 176
                defret = 103

            Case "Litleo"
                stamret = 158
                atkret = 139
                defret = 112

            Case "Pyroar"
                stamret = 200
                atkret = 221
                defret = 149

            Case "Flabébé"
                stamret = 127
                atkret = 108
                defret = 120

            Case "Floette"
                stamret = 144
                atkret = 136
                defret = 151

            Case "Florges"
                stamret = 186
                atkret = 212
                defret = 244

            Case "Skiddo"
                stamret = 165
                atkret = 123
                defret = 102

            Case "Gogoat"
                stamret = 265
                atkret = 196
                defret = 146

            Case "Pancham"
                stamret = 167
                atkret = 145
                defret = 107

            Case "Pangoro"
                stamret = 216
                atkret = 226
                defret = 146

            Case "Furfrou"
                stamret = 181
                atkret = 164
                defret = 167

            Case "Espurr"
                stamret = 158
                atkret = 120
                defret = 114

            Case "Meowstic"
                stamret = 179
                atkret = 166
                defret = 167

            Case "Honedge"
                stamret = 128
                atkret = 135
                defret = 139

            Case "Doublade"
                stamret = 153
                atkret = 188
                defret = 206

            Case "Aegislash Blade"
                stamret = 155
                atkret = 291
                defret = 97

            Case "Aegislash Shield"
                stamret = 155
                atkret = 97
                defret = 291

            Case "Spritzee"
                stamret = 186
                atkret = 110
                defret = 113

            Case "Aromatisse"
                stamret = 226
                atkret = 173
                defret = 150

            Case "Swirlix"
                stamret = 158
                atkret = 109
                defret = 119

            Case "Slurpuff"
                stamret = 193
                atkret = 168
                defret = 163

            Case "Inkay"
                stamret = 142
                atkret = 98
                defret = 95

            Case "Malamar"
                stamret = 200
                atkret = 177
                defret = 165

            Case "Binacle"
                stamret = 123
                atkret = 96
                defret = 120

            Case "Barbaracle"
                stamret = 176
                atkret = 194
                defret = 205

            Case "Skrelp"
                stamret = 137
                atkret = 109
                defret = 109

            Case "Dragalge"
                stamret = 163
                atkret = 177
                defret = 207

            Case "Clauncher"
                stamret = 137
                atkret = 108
                defret = 117

            Case "Clawitzer"
                stamret = 174
                atkret = 221
                defret = 171

            Case "Helioptile"
                stamret = 127
                atkret = 115
                defret = 78

            Case "Heliolisk"
                stamret = 158
                atkret = 219
                defret = 168

            Case "Tyrunt"
                stamret = 151
                atkret = 158
                defret = 123

            Case "Tyrantrum"
                stamret = 193
                atkret = 227
                defret = 191

            Case "Amaura"
                stamret = 184
                atkret = 124
                defret = 109

            Case "Aurorus"
                stamret = 265
                atkret = 186
                defret = 163

            Case "Sylveon"
                stamret = 216
                atkret = 203
                defret = 205

            Case "Hawlucha"
                stamret = 186
                atkret = 195
                defret = 153

            Case "Dedenne"
                stamret = 167
                atkret = 164
                defret = 134

            Case "Carbink"
                stamret = 137
                atkret = 95
                defret = 285

            Case "Goomy"
                stamret = 128
                atkret = 101
                defret = 112

            Case "Sliggoo"
                stamret = 169
                atkret = 159
                defret = 176

            Case "Goodra"
                stamret = 207
                atkret = 220
                defret = 242

            Case "Klefki"
                stamret = 149
                atkret = 160
                defret = 179

            Case "Phantump"
                stamret = 125
                atkret = 125
                defret = 103

            Case "Trevenant"
                stamret = 198
                atkret = 201
                defret = 154

            Case "Pumpkaboo Super"
                stamret = 153
                atkret = 118
                defret = 120

            Case "Pumpkaboo Large"
                stamret = 144
                atkret = 120
                defret = 122

            Case "Pumpkaboo Average"
                stamret = 135
                atkret = 121
                defret = 123

            Case "Pumpkaboo Small"
                stamret = 127
                atkret = 122
                defret = 124

            Case "Gourgeist Super"
                stamret = 198
                atkret = 182
                defret = 200

            Case "Gourgeist Large"
                stamret = 181
                atkret = 179
                defret = 206

            Case "Gourgeist Average"
                stamret = 163
                atkret = 175
                defret = 213

            Case "Gourgeist Small"
                stamret = 146
                atkret = 171
                defret = 219

            Case "Bergmite"
                stamret = 146
                atkret = 117
                defret = 120

            Case "Avalugg"
                stamret = 216
                atkret = 196
                defret = 240

            Case "Noibat"
                stamret = 120
                atkret = 83
                defret = 73

            Case "Noivern"
                stamret = 198
                atkret = 205
                defret = 175

            Case "Xerneas"
                stamret = 246
                atkret = 250
                defret = 185

            Case "Yveltal"
                stamret = 246
                atkret = 250
                defret = 185

            Case "Zygarde Complete"
                stamret = 389
                atkret = 184
                defret = 207

            Case "Zygarde 50%"
                stamret = 239
                atkret = 203
                defret = 232

            Case "Zygarde 10%"
                stamret = 144
                atkret = 205
                defret = 173

            Case "Mega Diancie"
                stamret = 125
                atkret = 312
                defret = 214

            Case "Diancie"
                stamret = 137
                atkret = 190
                defret = 285

            Case "Hoopa Unbound"
                stamret = 173
                atkret = 311
                defret = 191

            Case "Hoopa Confined"
                stamret = 173
                atkret = 261
                defret = 187

            Case "Volcanion"
                stamret = 190
                atkret = 252
                defret = 216

            Case "Rowlet"
                stamret = 169
                atkret = 102
                defret = 99

            Case "Dartrix"
                stamret = 186
                atkret = 142
                defret = 139

            Case "Decidueye"
                stamret = 186
                atkret = 210
                defret = 179

            Case "Litten"
                stamret = 128
                atkret = 128
                defret = 79

            Case "Torracat"
                stamret = 163
                atkret = 174
                defret = 103

            Case "Incineroar"
                stamret = 216
                atkret = 214
                defret = 175

            Case "Popplio"
                stamret = 137
                atkret = 120
                defret = 103

            Case "Brionne"
                stamret = 155
                atkret = 168
                defret = 145

            Case "Primarina"
                stamret = 190
                atkret = 232
                defret = 195

            Case "Pikipek"
                stamret = 111
                atkret = 136
                defret = 59

            Case "Trumbeak"
                stamret = 146
                atkret = 159
                defret = 100

            Case "Toucannon"
                stamret = 190
                atkret = 222
                defret = 146

            Case "Yungoos"
                stamret = 134
                atkret = 122
                defret = 56

            Case "Gumshoos"
                stamret = 204
                atkret = 194
                defret = 113

            Case "Grubbin"
                stamret = 132
                atkret = 115
                defret = 85

            Case "Charjabug"
                stamret = 149
                atkret = 145
                defret = 161

            Case "Vikavolt"
                stamret = 184
                atkret = 254
                defret = 158

            Case "Crabrawler"
                stamret = 132
                atkret = 150
                defret = 104

            Case "Crabominable"
                stamret = 219
                atkret = 231
                defret = 138

            Case "Oricorio Pa'u"
                stamret = 181
                atkret = 196
                defret = 145

            Case "Oricorio Sensu"
                stamret = 181
                atkret = 196
                defret = 145

            Case "Oricorio Baile"
                stamret = 181
                atkret = 196
                defret = 145

            Case "Oricorio Pom-Pom"
                stamret = 181
                atkret = 196
                defret = 145

            Case "Cutiefly"
                stamret = 120
                atkret = 110
                defret = 81

            Case "Ribombee"
                stamret = 155
                atkret = 198
                defret = 146

            Case "Rockruff"
                stamret = 128
                atkret = 117
                defret = 78

            Case "Lycanroc Midnight"
                stamret = 198
                atkret = 218
                defret = 152

            Case "Lycanroc Dusk"
                stamret = 181
                atkret = 234
                defret = 139

            Case "Lycanroc Midday"
                stamret = 181
                atkret = 231
                defret = 140

            Case "Wishiwashi School"
                stamret = 128
                atkret = 255
                defret = 242

            Case "Wishiwashi Solo"
                stamret = 128
                atkret = 46
                defret = 43

            Case "Mareanie"
                stamret = 137
                atkret = 98
                defret = 110

            Case "Toxapex"
                stamret = 137
                atkret = 114
                defret = 273

            Case "Mudbray"
                stamret = 172
                atkret = 175
                defret = 121

            Case "Mudsdale"
                stamret = 225
                atkret = 214
                defret = 174

            Case "Dewpider"
                stamret = 116
                atkret = 72
                defret = 117

            Case "Araquanid"
                stamret = 169
                atkret = 126
                defret = 219

            Case "Fomantis"
                stamret = 120
                atkret = 100
                defret = 64

            Case "Lurantis"
                stamret = 172
                atkret = 192
                defret = 169

            Case "Morelull"
                stamret = 120
                atkret = 108
                defret = 119

            Case "Shiinotic"
                stamret = 155
                atkret = 154
                defret = 168

            Case "Salandit"
                stamret = 134
                atkret = 136
                defret = 80

            Case "Salazzle"
                stamret = 169
                atkret = 228
                defret = 130

            Case "Stufful"
                stamret = 172
                atkret = 136
                defret = 95

            Case "Bewear"
                stamret = 260
                atkret = 226
                defret = 141

            Case "Bounsweet"
                stamret = 123
                atkret = 55
                defret = 69

            Case "Steenee"
                stamret = 141
                atkret = 78
                defret = 94

            Case "Tsareena"
                stamret = 176
                atkret = 222
                defret = 195

            Case "Comfey"
                stamret = 139
                atkret = 165
                defret = 215

            Case "Oranguru"
                stamret = 207
                atkret = 168
                defret = 192

            Case "Passimian"
                stamret = 225
                atkret = 222
                defret = 160

            Case "Wimpod"
                stamret = 93
                atkret = 67
                defret = 74

            Case "Golisopod"
                stamret = 181
                atkret = 218
                defret = 226

            Case "Sandygast"
                stamret = 146
                atkret = 120
                defret = 118

            Case "Palossand"
                stamret = 198
                atkret = 178
                defret = 178

            Case "Pyukumuku"
                stamret = 146
                atkret = 97
                defret = 224

            Case "Type Null"
                stamret = 216
                atkret = 184
                defret = 184

            Case "Silvally"
                stamret = 216
                atkret = 198
                defret = 198

            Case "Minior Core"
                stamret = 155
                atkret = 218
                defret = 131

            Case "Minior Meteor"
                stamret = 155
                atkret = 116
                defret = 194

            Case "Komala"
                stamret = 163
                atkret = 216
                defret = 165

            Case "Turtonator"
                stamret = 155
                atkret = 165
                defret = 215

            Case "Togedemaru"
                stamret = 163
                atkret = 190
                defret = 145

            Case "Mimikyu"
                stamret = 146
                atkret = 177
                defret = 199

            Case "Bruxish"
                stamret = 169
                atkret = 208
                defret = 145

            Case "Drampa"
                stamret = 186
                atkret = 231
                defret = 164

            Case "Dhelmise"
                stamret = 172
                atkret = 233
                defret = 179

            Case "Jangmo-o"
                stamret = 128
                atkret = 102
                defret = 108

            Case "Hakamo-o"
                stamret = 146
                atkret = 145
                defret = 162

            Case "Kommo-o"
                stamret = 181
                atkret = 222
                defret = 240

            Case "Tapu Koko"
                stamret = 172
                atkret = 250
                defret = 181

            Case "Tapu Lele"
                stamret = 172
                atkret = 259
                defret = 208

            Case "Tapu Bulu"
                stamret = 172
                atkret = 249
                defret = 215

            Case "Tapu Fini"
                stamret = 172
                atkret = 189
                defret = 254

            Case "Cosmog"
                stamret = 125
                atkret = 54
                defret = 57

            Case "Cosmoem"
                stamret = 125
                atkret = 54
                defret = 242

            Case "Solgaleo"
                stamret = 264
                atkret = 255
                defret = 191

            Case "Lunala"
                stamret = 264
                atkret = 255
                defret = 191

            Case "Nihilego"
                stamret = 240
                atkret = 249
                defret = 210

            Case "Buzzwole"
                stamret = 216
                atkret = 236
                defret = 196

            Case "Pheromosa"
                stamret = 174
                atkret = 316
                defret = 85

            Case "Xurkitree"
                stamret = 195
                atkret = 330
                defret = 144

            Case "Celesteela"
                stamret = 219
                atkret = 207
                defret = 199

            Case "Kartana"
                stamret = 139
                atkret = 323
                defret = 182

            Case "Guzzlord"
                stamret = 440
                atkret = 188
                defret = 99

            Case "Ultra Necrozma"
                stamret = 200
                atkret = 337
                defret = 196

            Case "Necrozma Dusk Mane"
                stamret = 200
                atkret = 277
                defret = 220

            Case "Necrozma Dawn Wings"
                stamret = 200
                atkret = 277
                defret = 220

            Case "Necrozma"
                stamret = 219
                atkret = 251
                defret = 195

            Case "Magearna"
                stamret = 190
                atkret = 246
                defret = 225

            Case "Marshadow"
                stamret = 207
                atkret = 265
                defret = 190

            Case "Poipole"
                stamret = 167
                atkret = 145
                defret = 133

            Case "Naganadel"
                stamret = 177
                atkret = 263
                defret = 159

            Case "Stakataka"
                stamret = 156
                atkret = 213
                defret = 298

            Case "Blacephalon"
                stamret = 142
                atkret = 315
                defret = 148

            Case "Zeraora"
                stamret = 204
                atkret = 252
                defret = 177

            Case "Meltan"
                stamret = 130
                atkret = 112
                defret = 113

            Case "Melmetal"
                stamret = 264
                atkret = 231
                defret = 213

            Case Else
                stamret = 0
                atkret = 0
                defret = 0

        End Select

        Return {stamret, atkret, defret}
    End Function
    Public Shared Function statfinder13dec(ByVal species As String)
        'source: https://docs.google.com/spreadsheets/d/1QDk6pGO6hbh3GrdeJp_0bx-xVMiG0zYAfpWZUV7ZaME/edit#gid=220449899

        Dim stamret As Integer = 0
        Dim atkret As Integer = 0
        Dim defret As Integer = 0
        Select Case species
            Case "Bulbasaur"
                stamret = 128
                atkret = 118
                defret = 111

            Case "Ivysaur"
                stamret = 155
                atkret = 151
                defret = 143

            Case "Mega Venusaur"
                stamret = 190
                atkret = 241
                defret = 246

            Case "Venusaur"
                stamret = 190
                atkret = 198
                defret = 189

            Case "Charmander"
                stamret = 118
                atkret = 116
                defret = 93

            Case "Charmeleon"
                stamret = 151
                atkret = 158
                defret = 126

            Case "Mega Charizard X"
                stamret = 186
                atkret = 273
                defret = 213

            Case "Mega Charizard Y"
                stamret = 170
                atkret = 290
                defret = 193

            Case "Charizard"
                stamret = 186
                atkret = 223
                defret = 173

            Case "Squirtle"
                stamret = 127
                atkret = 94
                defret = 121

            Case "Wartortle"
                stamret = 153
                atkret = 126
                defret = 155

            Case "Mega Blastoise"
                stamret = 188
                atkret = 264
                defret = 237

            Case "Blastoise"
                stamret = 188
                atkret = 171
                defret = 207

            Case "Caterpie"
                stamret = 128
                atkret = 55
                defret = 55

            Case "Metapod"
                stamret = 137
                atkret = 45
                defret = 80

            Case "Butterfree"
                stamret = 155
                atkret = 167
                defret = 137

            Case "Weedle"
                stamret = 120
                atkret = 63
                defret = 50

            Case "Kakuna"
                stamret = 128
                atkret = 46
                defret = 75

            Case "Mega Beedrill"
                stamret = 163
                atkret = 303
                defret = 148

            Case "Beedrill"
                stamret = 163
                atkret = 169
                defret = 130

            Case "Pidgey"
                stamret = 120
                atkret = 85
                defret = 73

            Case "Pidgeotto"
                stamret = 160
                atkret = 117
                defret = 105

            Case "Mega Pidgeot"
                stamret = 195
                atkret = 280
                defret = 175

            Case "Pidgeot"
                stamret = 195
                atkret = 166
                defret = 154

            Case "Rattata"
                stamret = 102
                atkret = 103
                defret = 70

            Case "Alolan Rattata"
                stamret = 102
                atkret = 103
                defret = 70

            Case "Raticate"
                stamret = 146
                atkret = 161
                defret = 139

            Case "Alolan Raticate"
                stamret = 181
                atkret = 135
                defret = 154

            Case "Spearow"
                stamret = 120
                atkret = 112
                defret = 60

            Case "Fearow"
                stamret = 163
                atkret = 182
                defret = 133

            Case "Ekans"
                stamret = 111
                atkret = 110
                defret = 97

            Case "Arbok"
                stamret = 155
                atkret = 167
                defret = 153

            Case "Pikachu"
                stamret = 111
                atkret = 112
                defret = 96

            Case "Alolan Raichu"
                stamret = 155
                atkret = 201
                defret = 154

            Case "Raichu"
                stamret = 155
                atkret = 193
                defret = 151

            Case "Alolan Sandshrew"
                stamret = 137
                atkret = 125
                defret = 129

            Case "Sandshrew"
                stamret = 137
                atkret = 126
                defret = 120

            Case "Alolan Sandslash"
                stamret = 181
                atkret = 177
                defret = 195

            Case "Sandslash"
                stamret = 181
                atkret = 182
                defret = 175

            Case "Nidoran♀"
                stamret = 146
                atkret = 86
                defret = 89

            Case "Nidorina"
                stamret = 172
                atkret = 117
                defret = 120

            Case "Nidoqueen"
                stamret = 207
                atkret = 180
                defret = 173

            Case "Nidoran♂"
                stamret = 130
                atkret = 105
                defret = 76

            Case "Nidorino"
                stamret = 156
                atkret = 137
                defret = 111

            Case "Nidoking"
                stamret = 191
                atkret = 204
                defret = 156

            Case "Clefairy"
                stamret = 172
                atkret = 107
                defret = 108

            Case "Clefable"
                stamret = 216
                atkret = 178
                defret = 162

            Case "Vulpix"
                stamret = 116
                atkret = 96
                defret = 109

            Case "Alolan Vulpix"
                stamret = 116
                atkret = 96
                defret = 109

            Case "Alolan Ninetales"
                stamret = 177
                atkret = 170
                defret = 193

            Case "Ninetales"
                stamret = 177
                atkret = 169
                defret = 190

            Case "Jigglypuff"
                stamret = 251
                atkret = 80
                defret = 41

            Case "Wigglytuff"
                stamret = 295
                atkret = 156
                defret = 90

            Case "Zubat"
                stamret = 120
                atkret = 83
                defret = 73

            Case "Golbat"
                stamret = 181
                atkret = 161
                defret = 150

            Case "Oddish"
                stamret = 128
                atkret = 131
                defret = 112

            Case "Gloom"
                stamret = 155
                atkret = 153
                defret = 136

            Case "Vileplume"
                stamret = 181
                atkret = 202
                defret = 167

            Case "Paras"
                stamret = 111
                atkret = 121
                defret = 99

            Case "Parasect"
                stamret = 155
                atkret = 165
                defret = 146

            Case "Venonat"
                stamret = 155
                atkret = 100
                defret = 100

            Case "Venomoth"
                stamret = 172
                atkret = 179
                defret = 143

            Case "Alolan Diglett"
                stamret = 67
                atkret = 108
                defret = 81

            Case "Diglett"
                stamret = 67
                atkret = 109
                defret = 78

            Case "Alolan Dugtrio"
                stamret = 111
                atkret = 201
                defret = 142

            Case "Dugtrio"
                stamret = 111
                atkret = 167
                defret = 136

            Case "Alolan Meowth"
                stamret = 120
                atkret = 99
                defret = 78

            Case "Meowth"
                stamret = 120
                atkret = 92
                defret = 78

            Case "Alolan Persian"
                stamret = 163
                atkret = 158
                defret = 136

            Case "Persian"
                stamret = 163
                atkret = 150
                defret = 136

            Case "Psyduck"
                stamret = 137
                atkret = 122
                defret = 95

            Case "Golduck"
                stamret = 190
                atkret = 191
                defret = 162

            Case "Mankey"
                stamret = 120
                atkret = 148
                defret = 82

            Case "Primeape"
                stamret = 163
                atkret = 207
                defret = 138

            Case "Growlithe"
                stamret = 146
                atkret = 136
                defret = 93

            Case "Arcanine"
                stamret = 207
                atkret = 227
                defret = 166

            Case "Poliwag"
                stamret = 120
                atkret = 101
                defret = 82

            Case "Poliwhirl"
                stamret = 163
                atkret = 130
                defret = 123

            Case "Poliwrath"
                stamret = 207
                atkret = 182
                defret = 184

            Case "Abra"
                stamret = 93
                atkret = 195
                defret = 82

            Case "Kadabra"
                stamret = 120
                atkret = 232
                defret = 117

            Case "Mega Alakazam"
                stamret = 133
                atkret = 334
                defret = 176

            Case "Alakazam"
                stamret = 146
                atkret = 271
                defret = 167

            Case "Machop"
                stamret = 172
                atkret = 137
                defret = 82

            Case "Machoke"
                stamret = 190
                atkret = 177
                defret = 125

            Case "Machamp"
                stamret = 207
                atkret = 234
                defret = 159

            Case "Bellsprout"
                stamret = 137
                atkret = 139
                defret = 61

            Case "Weepinbell"
                stamret = 163
                atkret = 172
                defret = 92

            Case "Victreebel"
                stamret = 190
                atkret = 207
                defret = 135

            Case "Tentacool"
                stamret = 120
                atkret = 97
                defret = 149

            Case "Tentacruel"
                stamret = 190
                atkret = 166
                defret = 209

            Case "Geodude"
                stamret = 120
                atkret = 132
                defret = 132

            Case "Alolan Geodude"
                stamret = 120
                atkret = 132
                defret = 132

            Case "Graveler"
                stamret = 146
                atkret = 164
                defret = 164

            Case "Alolan Graveler"
                stamret = 146
                atkret = 164
                defret = 164

            Case "Alolan Golem"
                stamret = 190
                atkret = 211
                defret = 198

            Case "Golem"
                stamret = 190
                atkret = 211
                defret = 198

            Case "Ponyta"
                stamret = 137
                atkret = 170
                defret = 127

            Case "Rapidash"
                stamret = 163
                atkret = 207
                defret = 162

            Case "Slowpoke"
                stamret = 207
                atkret = 109
                defret = 98

            Case "Mega Slowbro"
                stamret = 216
                atkret = 224
                defret = 259

            Case "Slowbro"
                stamret = 216
                atkret = 177
                defret = 180

            Case "Magnemite"
                stamret = 93
                atkret = 165
                defret = 121

            Case "Magneton"
                stamret = 137
                atkret = 223
                defret = 169

            Case "Farfetch'd"
                stamret = 141
                atkret = 124
                defret = 115

            Case "Doduo"
                stamret = 111
                atkret = 158
                defret = 83

            Case "Dodrio"
                stamret = 155
                atkret = 218
                defret = 140

            Case "Seel"
                stamret = 163
                atkret = 85
                defret = 121

            Case "Dewgong"
                stamret = 207
                atkret = 139
                defret = 177

            Case "Grimer"
                stamret = 190
                atkret = 135
                defret = 90

            Case "Alolan Grimer"
                stamret = 190
                atkret = 135
                defret = 90

            Case "Muk"
                stamret = 233
                atkret = 190
                defret = 172

            Case "Alolan Muk"
                stamret = 233
                atkret = 190
                defret = 172

            Case "Shellder"
                stamret = 102
                atkret = 116
                defret = 134

            Case "Cloyster"
                stamret = 137
                atkret = 186
                defret = 256

            Case "Gastly"
                stamret = 102
                atkret = 186
                defret = 67

            Case "Haunter"
                stamret = 128
                atkret = 223
                defret = 107

            Case "Mega Gengar"
                stamret = 141
                atkret = 317
                defret = 181

            Case "Gengar"
                stamret = 155
                atkret = 261
                defret = 149

            Case "Onix"
                stamret = 111
                atkret = 85
                defret = 232

            Case "Drowzee"
                stamret = 155
                atkret = 89
                defret = 136

            Case "Hypno"
                stamret = 198
                atkret = 144
                defret = 193

            Case "Krabby"
                stamret = 102
                atkret = 181
                defret = 124

            Case "Kingler"
                stamret = 146
                atkret = 240
                defret = 181

            Case "Voltorb"
                stamret = 120
                atkret = 109
                defret = 111

            Case "Electrode"
                stamret = 155
                atkret = 173
                defret = 173

            Case "Exeggcute"
                stamret = 155
                atkret = 107
                defret = 125

            Case "Exeggutor"
                stamret = 216
                atkret = 233
                defret = 149

            Case "Alolan Exeggutor"
                stamret = 216
                atkret = 230
                defret = 153

            Case "Cubone"
                stamret = 137
                atkret = 90
                defret = 144

            Case "Marowak"
                stamret = 155
                atkret = 144
                defret = 186

            Case "Alolan Marowak"
                stamret = 155
                atkret = 144
                defret = 186

            Case "Hitmonlee"
                stamret = 137
                atkret = 224
                defret = 181

            Case "Hitmonchan"
                stamret = 137
                atkret = 193
                defret = 197

            Case "Lickitung"
                stamret = 207
                atkret = 108
                defret = 137

            Case "Koffing"
                stamret = 120
                atkret = 119
                defret = 141

            Case "Weezing"
                stamret = 163
                atkret = 174
                defret = 197

            Case "Rhyhorn"
                stamret = 190
                atkret = 140
                defret = 127

            Case "Rhydon"
                stamret = 233
                atkret = 222
                defret = 171

            Case "Chansey"
                stamret = 487
                atkret = 60
                defret = 128

            Case "Tangela"
                stamret = 163
                atkret = 183
                defret = 169

            Case "Mega Kangaskhan"
                stamret = 233
                atkret = 246
                defret = 210

            Case "Kangaskhan"
                stamret = 233
                atkret = 181
                defret = 165

            Case "Horsea"
                stamret = 102
                atkret = 129
                defret = 103

            Case "Seadra"
                stamret = 146
                atkret = 187
                defret = 156

            Case "Goldeen"
                stamret = 128
                atkret = 123
                defret = 110

            Case "Seaking"
                stamret = 190
                atkret = 175
                defret = 147

            Case "Staryu"
                stamret = 102
                atkret = 137
                defret = 112

            Case "Starmie"
                stamret = 155
                atkret = 210
                defret = 184

            Case "Mr. Mime"
                stamret = 120
                atkret = 192
                defret = 205

            Case "Scyther"
                stamret = 172
                atkret = 218
                defret = 170

            Case "Jynx"
                stamret = 163
                atkret = 223
                defret = 151

            Case "Electabuzz"
                stamret = 163
                atkret = 198
                defret = 158

            Case "Magmar"
                stamret = 163
                atkret = 206
                defret = 154

            Case "Mega Pinsir"
                stamret = 149
                atkret = 278
                defret = 210

            Case "Pinsir"
                stamret = 163
                atkret = 238
                defret = 182

            Case "Tauros"
                stamret = 181
                atkret = 198
                defret = 183

            Case "Magikarp"
                stamret = 85
                atkret = 29
                defret = 85

            Case "Mega Gyarados"
                stamret = 197
                atkret = 266
                defret = 225

            Case "Gyarados"
                stamret = 216
                atkret = 237
                defret = 186

            Case "Lapras"
                stamret = 277
                atkret = 165
                defret = 174

            Case "Ditto"
                stamret = 134
                atkret = 91
                defret = 91

            Case "Eevee"
                stamret = 146
                atkret = 104
                defret = 114

            Case "Vaporeon"
                stamret = 277
                atkret = 205
                defret = 161

            Case "Jolteon"
                stamret = 163
                atkret = 232
                defret = 182

            Case "Flareon"
                stamret = 163
                atkret = 246
                defret = 179

            Case "Porygon"
                stamret = 163
                atkret = 153
                defret = 136

            Case "Omanyte"
                stamret = 111
                atkret = 155
                defret = 153

            Case "Omastar"
                stamret = 172
                atkret = 207
                defret = 201

            Case "Kabuto"
                stamret = 102
                atkret = 148
                defret = 140

            Case "Kabutops"
                stamret = 155
                atkret = 220
                defret = 186

            Case "Mega Aerodactyl"
                stamret = 173
                atkret = 266
                defret = 192

            Case "Aerodactyl"
                stamret = 190
                atkret = 221
                defret = 159

            Case "Snorlax"
                stamret = 330
                atkret = 190
                defret = 169

            Case "Articuno"
                stamret = 207
                atkret = 192
                defret = 236

            Case "Zapdos"
                stamret = 207
                atkret = 253
                defret = 185

            Case "Moltres"
                stamret = 207
                atkret = 251
                defret = 181

            Case "Dratini"
                stamret = 121
                atkret = 119
                defret = 91

            Case "Dragonair"
                stamret = 156
                atkret = 163
                defret = 135

            Case "Dragonite"
                stamret = 209
                atkret = 263
                defret = 198

            Case "Mega Mewtwo Y"
                stamret = 214
                atkret = 388
                defret = 209

            Case "Mega Mewtwo X"
                stamret = 214
                atkret = 375
                defret = 202

            Case "Mewtwo"
                stamret = 214
                atkret = 300
                defret = 182

            Case "Mew"
                stamret = 225
                atkret = 210
                defret = 210

            Case "Chikorita"
                stamret = 128
                atkret = 92
                defret = 122

            Case "Bayleef"
                stamret = 155
                atkret = 122
                defret = 155

            Case "Meganium"
                stamret = 190
                atkret = 168
                defret = 202

            Case "Cyndaquil"
                stamret = 118
                atkret = 116
                defret = 93

            Case "Quilava"
                stamret = 151
                atkret = 158
                defret = 126

            Case "Typhlosion"
                stamret = 186
                atkret = 223
                defret = 173

            Case "Totodile"
                stamret = 137
                atkret = 117
                defret = 109

            Case "Croconaw"
                stamret = 163
                atkret = 150
                defret = 142

            Case "Feraligatr"
                stamret = 198
                atkret = 205
                defret = 188

            Case "Sentret"
                stamret = 111
                atkret = 79
                defret = 73

            Case "Furret"
                stamret = 198
                atkret = 148
                defret = 125

            Case "Hoothoot"
                stamret = 155
                atkret = 67
                defret = 88

            Case "Noctowl"
                stamret = 225
                atkret = 145
                defret = 156

            Case "Ledyba"
                stamret = 120
                atkret = 72
                defret = 118

            Case "Ledian"
                stamret = 146
                atkret = 107
                defret = 179

            Case "Spinarak"
                stamret = 120
                atkret = 105
                defret = 73

            Case "Ariados"
                stamret = 172
                atkret = 161
                defret = 124

            Case "Crobat"
                stamret = 198
                atkret = 194
                defret = 178

            Case "Chinchou"
                stamret = 181
                atkret = 106
                defret = 97

            Case "Lanturn"
                stamret = 268
                atkret = 146
                defret = 137

            Case "Pichu"
                stamret = 85
                atkret = 77
                defret = 53

            Case "Cleffa"
                stamret = 137
                atkret = 75
                defret = 79

            Case "Igglybuff"
                stamret = 207
                atkret = 69
                defret = 32

            Case "Togepi"
                stamret = 111
                atkret = 67
                defret = 116

            Case "Togetic"
                stamret = 146
                atkret = 139
                defret = 181

            Case "Natu"
                stamret = 120
                atkret = 134
                defret = 89

            Case "Xatu"
                stamret = 163
                atkret = 192
                defret = 146

            Case "Mareep"
                stamret = 146
                atkret = 114
                defret = 79

            Case "Flaaffy"
                stamret = 172
                atkret = 145
                defret = 109

            Case "Mega Ampharos"
                stamret = 189
                atkret = 268
                defret = 185

            Case "Ampharos"
                stamret = 207
                atkret = 211
                defret = 169

            Case "Bellossom"
                stamret = 181
                atkret = 169
                defret = 186

            Case "Marill"
                stamret = 172
                atkret = 37
                defret = 93

            Case "Azumarill"
                stamret = 225
                atkret = 112
                defret = 152

            Case "Sudowoodo"
                stamret = 172
                atkret = 167
                defret = 176

            Case "Politoed"
                stamret = 207
                atkret = 174
                defret = 179

            Case "Hoppip"
                stamret = 111
                atkret = 67
                defret = 94

            Case "Skiploom"
                stamret = 146
                atkret = 91
                defret = 120

            Case "Jumpluff"
                stamret = 181
                atkret = 118
                defret = 183

            Case "Aipom"
                stamret = 146
                atkret = 136
                defret = 112

            Case "Sunkern"
                stamret = 102
                atkret = 55
                defret = 55

            Case "Sunflora"
                stamret = 181
                atkret = 185
                defret = 135

            Case "Yanma"
                stamret = 163
                atkret = 154
                defret = 94

            Case "Wooper"
                stamret = 146
                atkret = 75
                defret = 66

            Case "Quagsire"
                stamret = 216
                atkret = 152
                defret = 143

            Case "Espeon"
                stamret = 163
                atkret = 261
                defret = 175

            Case "Umbreon"
                stamret = 216
                atkret = 126
                defret = 240

            Case "Murkrow"
                stamret = 155
                atkret = 175
                defret = 87

            Case "Slowking"
                stamret = 216
                atkret = 177
                defret = 180

            Case "Misdreavus"
                stamret = 155
                atkret = 167
                defret = 154

            Case "Unown"
                stamret = 134
                atkret = 136
                defret = 91

            Case "Wobbuffet"
                stamret = 382
                atkret = 60
                defret = 106

            Case "Girafarig"
                stamret = 172
                atkret = 182
                defret = 133

            Case "Pineco"
                stamret = 137
                atkret = 108
                defret = 122

            Case "Forretress"
                stamret = 181
                atkret = 161
                defret = 205

            Case "Dunsparce"
                stamret = 225
                atkret = 131
                defret = 128

            Case "Gligar"
                stamret = 163
                atkret = 143
                defret = 184

            Case "Mega Steelix"
                stamret = 181
                atkret = 212
                defret = 327

            Case "Steelix"
                stamret = 181
                atkret = 148
                defret = 272

            Case "Snubbull"
                stamret = 155
                atkret = 137
                defret = 85

            Case "Granbull"
                stamret = 207
                atkret = 212
                defret = 131

            Case "Qwilfish"
                stamret = 163
                atkret = 184
                defret = 138

            Case "Mega Scizor"
                stamret = 157
                atkret = 254
                defret = 228

            Case "Scizor"
                stamret = 172
                atkret = 236
                defret = 181

            Case "Shuckle"
                stamret = 85
                atkret = 17
                defret = 396

            Case "Mega Heracross"
                stamret = 173
                atkret = 304
                defret = 203

            Case "Heracross"
                stamret = 190
                atkret = 234
                defret = 179

            Case "Sneasel"
                stamret = 146
                atkret = 189
                defret = 146

            Case "Teddiursa"
                stamret = 155
                atkret = 142
                defret = 93

            Case "Ursaring"
                stamret = 207
                atkret = 236
                defret = 144

            Case "Slugma"
                stamret = 120
                atkret = 118
                defret = 71

            Case "Magcargo"
                stamret = 137
                atkret = 139
                defret = 191

            Case "Swinub"
                stamret = 137
                atkret = 90
                defret = 69

            Case "Piloswine"
                stamret = 225
                atkret = 181
                defret = 138

            Case "Corsola"
                stamret = 146
                atkret = 118
                defret = 156

            Case "Remoraid"
                stamret = 111
                atkret = 127
                defret = 69

            Case "Octillery"
                stamret = 181
                atkret = 197
                defret = 141

            Case "Delibird"
                stamret = 128
                atkret = 128
                defret = 90

            Case "Mantine"
                stamret = 163
                atkret = 148
                defret = 226

            Case "Skarmory"
                stamret = 163
                atkret = 148
                defret = 226

            Case "Houndour"
                stamret = 128
                atkret = 152
                defret = 83

            Case "Mega Houndoom"
                stamret = 181
                atkret = 289
                defret = 194

            Case "Houndoom"
                stamret = 181
                atkret = 224
                defret = 144

            Case "Kingdra"
                stamret = 181
                atkret = 194
                defret = 194

            Case "Phanpy"
                stamret = 207
                atkret = 107
                defret = 98

            Case "Donphan"
                stamret = 207
                atkret = 214
                defret = 185

            Case "Porygon2"
                stamret = 198
                atkret = 198
                defret = 180

            Case "Stantler"
                stamret = 177
                atkret = 192
                defret = 131

            Case "Smeargle"
                stamret = 146
                atkret = 40
                defret = 83

            Case "Tyrogue"
                stamret = 111
                atkret = 64
                defret = 64

            Case "Hitmontop"
                stamret = 137
                atkret = 173
                defret = 207

            Case "Smoochum"
                stamret = 128
                atkret = 153
                defret = 91

            Case "Elekid"
                stamret = 128
                atkret = 135
                defret = 101

            Case "Magby"
                stamret = 128
                atkret = 151
                defret = 99

            Case "Miltank"
                stamret = 216
                atkret = 157
                defret = 193

            Case "Blissey"
                stamret = 496
                atkret = 129
                defret = 169

            Case "Raikou"
                stamret = 207
                atkret = 241
                defret = 195

            Case "Entei"
                stamret = 251
                atkret = 235
                defret = 171

            Case "Suicune"
                stamret = 225
                atkret = 180
                defret = 235

            Case "Larvitar"
                stamret = 137
                atkret = 115
                defret = 93

            Case "Pupitar"
                stamret = 172
                atkret = 155
                defret = 133

            Case "Mega Tyranitar"
                stamret = 205
                atkret = 281
                defret = 251

            Case "Tyranitar"
                stamret = 225
                atkret = 251
                defret = 207

            Case "Lugia"
                stamret = 235
                atkret = 193
                defret = 310

            Case "Ho-oh"
                stamret = 214
                atkret = 239
                defret = 244

            Case "Celebi"
                stamret = 225
                atkret = 210
                defret = 210

            Case "Treecko"
                stamret = 120
                atkret = 124
                defret = 94

            Case "Grovyle"
                stamret = 137
                atkret = 172
                defret = 120

            Case "Mega Sceptile"
                stamret = 157
                atkret = 292
                defret = 169

            Case "Sceptile"
                stamret = 172
                atkret = 223
                defret = 169

            Case "Torchic"
                stamret = 128
                atkret = 130
                defret = 87

            Case "Combusken"
                stamret = 155
                atkret = 163
                defret = 115

            Case "Mega Blaziken"
                stamret = 173
                atkret = 299
                defret = 153

            Case "Blaziken"
                stamret = 190
                atkret = 240
                defret = 141

            Case "Mudkip"
                stamret = 137
                atkret = 126
                defret = 93

            Case "Marshtomp"
                stamret = 172
                atkret = 156
                defret = 133

            Case "Mega Swampert"
                stamret = 205
                atkret = 258
                defret = 198

            Case "Swampert"
                stamret = 225
                atkret = 208
                defret = 175

            Case "Poochyena"
                stamret = 111
                atkret = 96
                defret = 61

            Case "Mightyena"
                stamret = 172
                atkret = 171
                defret = 132

            Case "Zigzagoon"
                stamret = 116
                atkret = 58
                defret = 80

            Case "Linoone"
                stamret = 186
                atkret = 142
                defret = 128

            Case "Wurmple"
                stamret = 128
                atkret = 75
                defret = 59

            Case "Silcoon"
                stamret = 137
                atkret = 60
                defret = 77

            Case "Beautifly"
                stamret = 155
                atkret = 189
                defret = 98

            Case "Cascoon"
                stamret = 137
                atkret = 60
                defret = 77

            Case "Dustox"
                stamret = 155
                atkret = 98
                defret = 162

            Case "Lotad"
                stamret = 120
                atkret = 71
                defret = 77

            Case "Lombre"
                stamret = 155
                atkret = 112
                defret = 119

            Case "Ludicolo"
                stamret = 190
                atkret = 173
                defret = 176

            Case "Seedot"
                stamret = 120
                atkret = 71
                defret = 77

            Case "Nuzleaf"
                stamret = 172
                atkret = 134
                defret = 78

            Case "Shiftry"
                stamret = 207
                atkret = 200
                defret = 121

            Case "Taillow"
                stamret = 120
                atkret = 106
                defret = 61

            Case "Swellow"
                stamret = 155
                atkret = 185
                defret = 124

            Case "Wingull"
                stamret = 120
                atkret = 106
                defret = 61

            Case "Pelipper"
                stamret = 155
                atkret = 175
                defret = 174

            Case "Ralts"
                stamret = 99
                atkret = 79
                defret = 59

            Case "Kirlia"
                stamret = 116
                atkret = 117
                defret = 90

            Case "Mega Gardevoir"
                stamret = 154
                atkret = 296
                defret = 208

            Case "Gardevoir"
                stamret = 169
                atkret = 237
                defret = 195

            Case "Surskit"
                stamret = 120
                atkret = 93
                defret = 87

            Case "Masquerain"
                stamret = 172
                atkret = 192
                defret = 150

            Case "Shroomish"
                stamret = 155
                atkret = 74
                defret = 110

            Case "Breloom"
                stamret = 155
                atkret = 241
                defret = 144

            Case "Slakoth"
                stamret = 155
                atkret = 104
                defret = 92

            Case "Vigoroth"
                stamret = 190
                atkret = 159
                defret = 145

            Case "Slaking"
                stamret = 284
                atkret = 290
                defret = 166

            Case "Nincada"
                stamret = 104
                atkret = 80
                defret = 126

            Case "Ninjask"
                stamret = 156
                atkret = 199
                defret = 112

            Case "Shedinja"
                stamret = 1
                atkret = 153
                defret = 73

            Case "Whismur"
                stamret = 162
                atkret = 92
                defret = 42

            Case "Loudred"
                stamret = 197
                atkret = 134
                defret = 81

            Case "Exploud"
                stamret = 232
                atkret = 179
                defret = 137

            Case "Makuhita"
                stamret = 176
                atkret = 99
                defret = 54

            Case "Hariyama"
                stamret = 302
                atkret = 209
                defret = 114

            Case "Azurill"
                stamret = 137
                atkret = 36
                defret = 71

            Case "Nosepass"
                stamret = 102
                atkret = 82
                defret = 215

            Case "Skitty"
                stamret = 137
                atkret = 84
                defret = 79

            Case "Delcatty"
                stamret = 172
                atkret = 132
                defret = 127

            Case "Mega Sableye"
                stamret = 137
                atkret = 151
                defret = 216

            Case "Sableye"
                stamret = 137
                atkret = 141
                defret = 136

            Case "Mega Mawile"
                stamret = 137
                atkret = 188
                defret = 217

            Case "Mawile"
                stamret = 137
                atkret = 155
                defret = 141

            Case "Aron"
                stamret = 137
                atkret = 121
                defret = 141

            Case "Lairon"
                stamret = 155
                atkret = 158
                defret = 198

            Case "Mega Aggron"
                stamret = 157
                atkret = 225
                defret = 301

            Case "Aggron"
                stamret = 172
                atkret = 198
                defret = 257

            Case "Meditite"
                stamret = 102
                atkret = 78
                defret = 107

            Case "Mega Medicham"
                stamret = 155
                atkret = 205
                defret = 179

            Case "Medicham"
                stamret = 155
                atkret = 121
                defret = 152

            Case "Electrike"
                stamret = 120
                atkret = 123
                defret = 78

            Case "Mega Manectric"
                stamret = 172
                atkret = 286
                defret = 179

            Case "Manectric"
                stamret = 172
                atkret = 215
                defret = 127

            Case "Plusle"
                stamret = 155
                atkret = 167
                defret = 129

            Case "Minun"
                stamret = 155
                atkret = 147
                defret = 150

            Case "Volbeat"
                stamret = 163
                atkret = 143
                defret = 166

            Case "Illumise"
                stamret = 163
                atkret = 143
                defret = 166

            Case "Roselia"
                stamret = 137
                atkret = 186
                defret = 131

            Case "Gulpin"
                stamret = 172
                atkret = 80
                defret = 99

            Case "Swalot"
                stamret = 225
                atkret = 140
                defret = 159

            Case "Carvanha"
                stamret = 128
                atkret = 171
                defret = 39

            Case "Mega Sharpedo"
                stamret = 172
                atkret = 289
                defret = 144

            Case "Sharpedo"
                stamret = 172
                atkret = 243
                defret = 83

            Case "Wailmer"
                stamret = 277
                atkret = 136
                defret = 68

            Case "Wailord"
                stamret = 347
                atkret = 175
                defret = 87

            Case "Numel"
                stamret = 155
                atkret = 119
                defret = 79

            Case "Mega Camerupt"
                stamret = 172
                atkret = 253
                defret = 183

            Case "Camerupt"
                stamret = 172
                atkret = 194
                defret = 136

            Case "Torkoal"
                stamret = 172
                atkret = 151
                defret = 203

            Case "Spoink"
                stamret = 155
                atkret = 125
                defret = 122

            Case "Grumpig"
                stamret = 190
                atkret = 171
                defret = 188

            Case "Spinda"
                stamret = 155
                atkret = 116
                defret = 116

            Case "Trapinch"
                stamret = 128
                atkret = 162
                defret = 78

            Case "Vibrava"
                stamret = 137
                atkret = 134
                defret = 99

            Case "Flygon"
                stamret = 190
                atkret = 205
                defret = 168

            Case "Cacnea"
                stamret = 137
                atkret = 156
                defret = 74

            Case "Cacturne"
                stamret = 172
                atkret = 221
                defret = 115

            Case "Swablu"
                stamret = 128
                atkret = 76
                defret = 132

            Case "Mega Altaria"
                stamret = 181
                atkret = 222
                defret = 218

            Case "Altaria"
                stamret = 181
                atkret = 141
                defret = 201

            Case "Zangoose"
                stamret = 177
                atkret = 222
                defret = 124

            Case "Seviper"
                stamret = 177
                atkret = 196
                defret = 118

            Case "Lunatone"
                stamret = 207
                atkret = 178
                defret = 153

            Case "Solrock"
                stamret = 207
                atkret = 178
                defret = 153

            Case "Barboach"
                stamret = 137
                atkret = 93
                defret = 82

            Case "Whiscash"
                stamret = 242
                atkret = 151
                defret = 141

            Case "Corphish"
                stamret = 125
                atkret = 141
                defret = 99

            Case "Crawdaunt"
                stamret = 160
                atkret = 224
                defret = 142

            Case "Baltoy"
                stamret = 120
                atkret = 77
                defret = 124

            Case "Claydol"
                stamret = 155
                atkret = 140
                defret = 229

            Case "Lileep"
                stamret = 165
                atkret = 105
                defret = 150

            Case "Cradily"
                stamret = 200
                atkret = 152
                defret = 194

            Case "Anorith"
                stamret = 128
                atkret = 176
                defret = 100

            Case "Armaldo"
                stamret = 181
                atkret = 222
                defret = 174

            Case "Feebas"
                stamret = 85
                atkret = 29
                defret = 85

            Case "Milotic"
                stamret = 216
                atkret = 192
                defret = 219

            Case "Castform"
                stamret = 172
                atkret = 139
                defret = 139

            Case "Kecleon"
                stamret = 155
                atkret = 161
                defret = 189

            Case "Shuppet"
                stamret = 127
                atkret = 138
                defret = 65

            Case "Mega Banette"
                stamret = 162
                atkret = 312
                defret = 160

            Case "Banette"
                stamret = 162
                atkret = 218
                defret = 126

            Case "Duskull"
                stamret = 85
                atkret = 70
                defret = 162

            Case "Dusclops"
                stamret = 120
                atkret = 124
                defret = 234

            Case "Tropius"
                stamret = 223
                atkret = 136
                defret = 163

            Case "Chimecho"
                stamret = 181
                atkret = 175
                defret = 170

            Case "Mega Absol"
                stamret = 163
                atkret = 314
                defret = 130

            Case "Absol"
                stamret = 163
                atkret = 246
                defret = 120

            Case "Wynaut"
                stamret = 216
                atkret = 41
                defret = 86

            Case "Snorunt"
                stamret = 137
                atkret = 95
                defret = 95

            Case "Mega Glalie"
                stamret = 190
                atkret = 252
                defret = 168

            Case "Glalie"
                stamret = 190
                atkret = 162
                defret = 162

            Case "Spheal"
                stamret = 172
                atkret = 95
                defret = 90

            Case "Sealeo"
                stamret = 207
                atkret = 137
                defret = 132

            Case "Walrein"
                stamret = 242
                atkret = 182
                defret = 176

            Case "Clamperl"
                stamret = 111
                atkret = 133
                defret = 135

            Case "Huntail"
                stamret = 146
                atkret = 197
                defret = 179

            Case "Gorebyss"
                stamret = 146
                atkret = 211
                defret = 179

            Case "Relicanth"
                stamret = 225
                atkret = 162
                defret = 203

            Case "Luvdisc"
                stamret = 125
                atkret = 81
                defret = 128

            Case "Bagon"
                stamret = 128
                atkret = 134
                defret = 93

            Case "Shelgon"
                stamret = 163
                atkret = 172
                defret = 155

            Case "Mega Salamence"
                stamret = 197
                atkret = 282
                defret = 228

            Case "Salamence"
                stamret = 216
                atkret = 277
                defret = 168

            Case "Beldum"
                stamret = 120
                atkret = 96
                defret = 132

            Case "Metang"
                stamret = 155
                atkret = 138
                defret = 176

            Case "Mega Metagross"
                stamret = 173
                atkret = 273
                defret = 263

            Case "Metagross"
                stamret = 190
                atkret = 257
                defret = 228

            Case "Regirock"
                stamret = 190
                atkret = 179
                defret = 309

            Case "Regice"
                stamret = 190
                atkret = 179
                defret = 309

            Case "Registeel"
                stamret = 190
                atkret = 143
                defret = 285

            Case "Mega Latias"
                stamret = 173
                atkret = 263
                defret = 271

            Case "Latias"
                stamret = 190
                atkret = 228
                defret = 246

            Case "Mega Latios"
                stamret = 173
                atkret = 305
                defret = 219

            Case "Latios"
                stamret = 190
                atkret = 268
                defret = 212

            Case "Primal Kyogre"
                stamret = 205
                atkret = 331
                defret = 251

            Case "Kyogre"
                stamret = 205
                atkret = 270
                defret = 228

            Case "Primal Groudon"
                stamret = 205
                atkret = 331
                defret = 251

            Case "Groudon"
                stamret = 205
                atkret = 270
                defret = 228

            Case "Mega Rayquaza"
                stamret = 213
                atkret = 354
                defret = 197

            Case "Rayquaza"
                stamret = 213
                atkret = 284
                defret = 170

            Case "Jirachi"
                stamret = 225
                atkret = 210
                defret = 210

            Case "Deoxys"
                stamret = 137
                atkret = 345
                defret = 115

            Case "Deoxys Speed"
                stamret = 137
                atkret = 230
                defret = 218

            Case "Deoxys Attack"
                stamret = 137
                atkret = 414
                defret = 46

            Case "Deoxys Defense"
                stamret = 137
                atkret = 144
                defret = 330

            Case "Turtwig"
                stamret = 146
                atkret = 119
                defret = 110

            Case "Grotle"
                stamret = 181
                atkret = 157
                defret = 143

            Case "Torterra"
                stamret = 216
                atkret = 202
                defret = 188

            Case "Chimchar"
                stamret = 127
                atkret = 113
                defret = 86

            Case "Monferno"
                stamret = 162
                atkret = 158
                defret = 105

            Case "Infernape"
                stamret = 183
                atkret = 222
                defret = 151

            Case "Piplup"
                stamret = 142
                atkret = 112
                defret = 102

            Case "Prinplup"
                stamret = 162
                atkret = 150
                defret = 139

            Case "Empoleon"
                stamret = 197
                atkret = 210
                defret = 186

            Case "Starly"
                stamret = 120
                atkret = 101
                defret = 58

            Case "Staravia"
                stamret = 146
                atkret = 142
                defret = 94

            Case "Staraptor"
                stamret = 198
                atkret = 234
                defret = 140

            Case "Bidoof"
                stamret = 153
                atkret = 80
                defret = 73

            Case "Bibarel"
                stamret = 188
                atkret = 162
                defret = 119

            Case "Kricketot"
                stamret = 114
                atkret = 45
                defret = 74

            Case "Kricketune"
                stamret = 184
                atkret = 160
                defret = 100

            Case "Shinx"
                stamret = 128
                atkret = 117
                defret = 64

            Case "Luxio"
                stamret = 155
                atkret = 159
                defret = 95

            Case "Luxray"
                stamret = 190
                atkret = 232
                defret = 156

            Case "Budew"
                stamret = 120
                atkret = 91
                defret = 109

            Case "Roserade"
                stamret = 155
                atkret = 243
                defret = 185

            Case "Cranidos"
                stamret = 167
                atkret = 218
                defret = 71

            Case "Rampardos"
                stamret = 219
                atkret = 295
                defret = 109

            Case "Shieldon"
                stamret = 102
                atkret = 76
                defret = 195

            Case "Bastiodon"
                stamret = 155
                atkret = 94
                defret = 286

            Case "Burmy"
                stamret = 120
                atkret = 53
                defret = 83

            Case "Wormadam Plant"
                stamret = 155
                atkret = 141
                defret = 180

            Case "Wormadam Sandy"
                stamret = 155
                atkret = 141
                defret = 180

            Case "Wormadam Trash"
                stamret = 155
                atkret = 127
                defret = 175

            Case "Mothim"
                stamret = 172
                atkret = 185
                defret = 98

            Case "Combee"
                stamret = 102
                atkret = 59
                defret = 83

            Case "Vespiquen"
                stamret = 172
                atkret = 149
                defret = 190

            Case "Pachirisu"
                stamret = 155
                atkret = 94
                defret = 172

            Case "Buizel"
                stamret = 146
                atkret = 132
                defret = 67

            Case "Floatzel"
                stamret = 198
                atkret = 221
                defret = 114

            Case "Cherubi"
                stamret = 128
                atkret = 108
                defret = 92

            Case "Cherrim"
                stamret = 172
                atkret = 170
                defret = 153

            Case "Shellos"
                stamret = 183
                atkret = 103
                defret = 105

            Case "Gastrodon"
                stamret = 244
                atkret = 169
                defret = 143

            Case "Ambipom"
                stamret = 181
                atkret = 205
                defret = 143

            Case "Drifloon"
                stamret = 207
                atkret = 117
                defret = 80

            Case "Drifblim"
                stamret = 312
                atkret = 180
                defret = 102

            Case "Buneary"
                stamret = 146
                atkret = 130
                defret = 105

            Case "Mega Lopunny"
                stamret = 163
                atkret = 282
                defret = 214

            Case "Lopunny"
                stamret = 163
                atkret = 156
                defret = 194

            Case "Mismagius"
                stamret = 155
                atkret = 211
                defret = 187

            Case "Honchkrow"
                stamret = 225
                atkret = 243
                defret = 103

            Case "Glameow"
                stamret = 135
                atkret = 109
                defret = 82

            Case "Purugly"
                stamret = 174
                atkret = 172
                defret = 133

            Case "Chingling"
                stamret = 128
                atkret = 114
                defret = 94

            Case "Stunky"
                stamret = 160
                atkret = 121
                defret = 90

            Case "Skuntank"
                stamret = 230
                atkret = 184
                defret = 132

            Case "Bronzor"
                stamret = 149
                atkret = 43
                defret = 154

            Case "Bronzong"
                stamret = 167
                atkret = 161
                defret = 213

            Case "Bonsly"
                stamret = 137
                atkret = 124
                defret = 133

            Case "Mime Jr."
                stamret = 85
                atkret = 125
                defret = 142

            Case "Happiny"
                stamret = 225
                atkret = 25
                defret = 77

            Case "Chatot"
                stamret = 183
                atkret = 183
                defret = 91

            Case "Spiritomb"
                stamret = 137
                atkret = 169
                defret = 199

            Case "Gible"
                stamret = 151
                atkret = 124
                defret = 84

            Case "Gabite"
                stamret = 169
                atkret = 172
                defret = 125

            Case "Mega Garchomp"
                stamret = 217
                atkret = 309
                defret = 202

            Case "Garchomp"
                stamret = 239
                atkret = 261
                defret = 193

            Case "Munchlax"
                stamret = 286
                atkret = 137
                defret = 117

            Case "Riolu"
                stamret = 120
                atkret = 127
                defret = 78

            Case "Mega Lucario"
                stamret = 172
                atkret = 310
                defret = 175

            Case "Lucario"
                stamret = 172
                atkret = 236
                defret = 144

            Case "Hippopotas"
                stamret = 169
                atkret = 124
                defret = 118

            Case "Hippowdon"
                stamret = 239
                atkret = 201
                defret = 191

            Case "Skorupi"
                stamret = 120
                atkret = 93
                defret = 151

            Case "Drapion"
                stamret = 172
                atkret = 180
                defret = 202

            Case "Croagunk"
                stamret = 134
                atkret = 116
                defret = 76

            Case "Toxicroak"
                stamret = 195
                atkret = 211
                defret = 133

            Case "Carnivine"
                stamret = 179
                atkret = 187
                defret = 136

            Case "Finneon"
                stamret = 135
                atkret = 96
                defret = 116

            Case "Lumineon"
                stamret = 170
                atkret = 142
                defret = 170

            Case "Mantyke"
                stamret = 128
                atkret = 105
                defret = 179

            Case "Snover"
                stamret = 155
                atkret = 115
                defret = 105

            Case "Mega Abomasnow"
                stamret = 207
                atkret = 240
                defret = 191

            Case "Abomasnow"
                stamret = 207
                atkret = 178
                defret = 158

            Case "Weavile"
                stamret = 172
                atkret = 243
                defret = 171

            Case "Magnezone"
                stamret = 172
                atkret = 238
                defret = 205

            Case "Lickilicky"
                stamret = 242
                atkret = 161
                defret = 181

            Case "Rhyperior"
                stamret = 251
                atkret = 241
                defret = 190

            Case "Tangrowth"
                stamret = 225
                atkret = 207
                defret = 184

            Case "Electivire"
                stamret = 181
                atkret = 249
                defret = 163

            Case "Magmortar"
                stamret = 181
                atkret = 247
                defret = 172

            Case "Togekiss"
                stamret = 198
                atkret = 225
                defret = 217

            Case "Yanmega"
                stamret = 200
                atkret = 231
                defret = 156

            Case "Leafeon"
                stamret = 163
                atkret = 216
                defret = 219

            Case "Glaceon"
                stamret = 163
                atkret = 238
                defret = 205

            Case "Gliscor"
                stamret = 181
                atkret = 185
                defret = 222

            Case "Mamoswine"
                stamret = 242
                atkret = 247
                defret = 146

            Case "Porygon-Z"
                stamret = 198
                atkret = 264
                defret = 150

            Case "Mega Gallade"
                stamret = 154
                atkret = 297
                defret = 209

            Case "Gallade"
                stamret = 169
                atkret = 237
                defret = 195

            Case "Probopass"
                stamret = 155
                atkret = 135
                defret = 275

            Case "Dusknoir"
                stamret = 128
                atkret = 180
                defret = 254

            Case "Froslass"
                stamret = 172
                atkret = 171
                defret = 150

            Case "Rotom Heat"
                stamret = 137
                atkret = 204
                defret = 219

            Case "Rotom Wash"
                stamret = 137
                atkret = 204
                defret = 219

            Case "Rotom Frost"
                stamret = 137
                atkret = 204
                defret = 219

            Case "Rotom Spin"
                stamret = 137
                atkret = 204
                defret = 219

            Case "Rotom Cut"
                stamret = 137
                atkret = 204
                defret = 219

            Case "Rotom"
                stamret = 137
                atkret = 185
                defret = 159

            Case "Uxie"
                stamret = 181
                atkret = 156
                defret = 270

            Case "Mesprit"
                stamret = 190
                atkret = 212
                defret = 212

            Case "Azelf"
                stamret = 181
                atkret = 270
                defret = 151

            Case "Dialga"
                stamret = 205
                atkret = 275
                defret = 211

            Case "Palkia"
                stamret = 189
                atkret = 280
                defret = 215

            Case "Heatran"
                stamret = 209
                atkret = 251
                defret = 213

            Case "Regigigas"
                stamret = 221
                atkret = 287
                defret = 210

            Case "Giratina Origin"
                stamret = 284
                atkret = 225
                defret = 187

            Case "Giratina Altered"
                stamret = 284
                atkret = 187
                defret = 225

            Case "Cresselia"
                stamret = 260
                atkret = 152
                defret = 258

            Case "Phione"
                stamret = 190
                atkret = 162
                defret = 162

            Case "Manaphy"
                stamret = 225
                atkret = 210
                defret = 210

            Case "Darkrai"
                stamret = 172
                atkret = 285
                defret = 198

            Case "Shaymin Sky"
                stamret = 225
                atkret = 261
                defret = 166

            Case "Shaymin"
                stamret = 225
                atkret = 210
                defret = 210

            Case "Arceus"
                stamret = 237
                atkret = 238
                defret = 238

            Case "Victini"
                stamret = 225
                atkret = 210
                defret = 210

            Case "Snivy"
                stamret = 128
                atkret = 88
                defret = 107

            Case "Servine"
                stamret = 155
                atkret = 122
                defret = 152

            Case "Serperior"
                stamret = 181
                atkret = 161
                defret = 204

            Case "Tepig"
                stamret = 163
                atkret = 115
                defret = 85

            Case "Pignite"
                stamret = 207
                atkret = 173
                defret = 106

            Case "Emboar"
                stamret = 242
                atkret = 235
                defret = 127

            Case "Oshawott"
                stamret = 146
                atkret = 117
                defret = 85

            Case "Dewott"
                stamret = 181
                atkret = 159
                defret = 116

            Case "Samurott"
                stamret = 216
                atkret = 212
                defret = 157

            Case "Patrat"
                stamret = 128
                atkret = 98
                defret = 73

            Case "Watchog"
                stamret = 155
                atkret = 165
                defret = 139

            Case "Lillipup"
                stamret = 128
                atkret = 107
                defret = 86

            Case "Herdier"
                stamret = 163
                atkret = 145
                defret = 126

            Case "Stoutland"
                stamret = 198
                atkret = 206
                defret = 182

            Case "Purrloin"
                stamret = 121
                atkret = 98
                defret = 73

            Case "Liepard"
                stamret = 162
                atkret = 187
                defret = 106

            Case "Pansage"
                stamret = 137
                atkret = 104
                defret = 94

            Case "Simisage"
                stamret = 181
                atkret = 206
                defret = 133

            Case "Pansear"
                stamret = 137
                atkret = 104
                defret = 94

            Case "Simisear"
                stamret = 181
                atkret = 206
                defret = 133

            Case "Panpour"
                stamret = 137
                atkret = 104
                defret = 94

            Case "Simipour"
                stamret = 181
                atkret = 206
                defret = 133

            Case "Munna"
                stamret = 183
                atkret = 111
                defret = 92

            Case "Musharna"
                stamret = 253
                atkret = 183
                defret = 166

            Case "Pidove"
                stamret = 137
                atkret = 98
                defret = 80

            Case "Tranquill"
                stamret = 158
                atkret = 144
                defret = 107

            Case "Unfezant"
                stamret = 190
                atkret = 226
                defret = 146

            Case "Blitzle"
                stamret = 128
                atkret = 118
                defret = 64

            Case "Zebstrika"
                stamret = 181
                atkret = 211
                defret = 136

            Case "Roggenrola"
                stamret = 146
                atkret = 121
                defret = 110

            Case "Boldore"
                stamret = 172
                atkret = 174
                defret = 143

            Case "Gigalith"
                stamret = 198
                atkret = 226
                defret = 201

            Case "Woobat"
                stamret = 163
                atkret = 107
                defret = 85

            Case "Swoobat"
                stamret = 167
                atkret = 161
                defret = 119

            Case "Drilbur"
                stamret = 155
                atkret = 154
                defret = 85

            Case "Excadrill"
                stamret = 242
                atkret = 255
                defret = 129

            Case "Mega Audino"
                stamret = 230
                atkret = 147
                defret = 239

            Case "Audino"
                stamret = 230
                atkret = 114
                defret = 163

            Case "Timburr"
                stamret = 181
                atkret = 134
                defret = 87

            Case "Gurdurr"
                stamret = 198
                atkret = 180
                defret = 134

            Case "Conkeldurr"
                stamret = 233
                atkret = 243
                defret = 158

            Case "Tympole"
                stamret = 137
                atkret = 98
                defret = 78

            Case "Palpitoad"
                stamret = 181
                atkret = 128
                defret = 109

            Case "Seismitoad"
                stamret = 233
                atkret = 188
                defret = 150

            Case "Throh"
                stamret = 260
                atkret = 172
                defret = 160

            Case "Sawk"
                stamret = 181
                atkret = 231
                defret = 153

            Case "Sewaddle"
                stamret = 128
                atkret = 96
                defret = 124

            Case "Swadloon"
                stamret = 146
                atkret = 115
                defret = 162

            Case "Leavanny"
                stamret = 181
                atkret = 205
                defret = 165

            Case "Venipede"
                stamret = 102
                atkret = 83
                defret = 99

            Case "Whirlipede"
                stamret = 120
                atkret = 100
                defret = 173

            Case "Scolipede"
                stamret = 155
                atkret = 203
                defret = 175

            Case "Cottonee"
                stamret = 120
                atkret = 71
                defret = 111

            Case "Whimsicott"
                stamret = 155
                atkret = 164
                defret = 176

            Case "Petilil"
                stamret = 128
                atkret = 119
                defret = 91

            Case "Lilligant"
                stamret = 172
                atkret = 214
                defret = 155

            Case "Basculin"
                stamret = 172
                atkret = 189
                defret = 129

            Case "Sandile"
                stamret = 137
                atkret = 132
                defret = 69

            Case "Krokorok"
                stamret = 155
                atkret = 155
                defret = 90

            Case "Krookodile"
                stamret = 216
                atkret = 229
                defret = 158

            Case "Darumaka"
                stamret = 172
                atkret = 153
                defret = 86

            Case "Darmanitan Zen"
                stamret = 233
                atkret = 243
                defret = 202

            Case "Darmanitan"
                stamret = 233
                atkret = 263
                defret = 114

            Case "Maractus"
                stamret = 181
                atkret = 201
                defret = 130

            Case "Dwebble"
                stamret = 137
                atkret = 118
                defret = 128

            Case "Crustle"
                stamret = 172
                atkret = 188
                defret = 200

            Case "Scraggy"
                stamret = 137
                atkret = 132
                defret = 132

            Case "Scrafty"
                stamret = 163
                atkret = 163
                defret = 222

            Case "Sigilyph"
                stamret = 176
                atkret = 204
                defret = 167

            Case "Yamask"
                stamret = 116
                atkret = 95
                defret = 141

            Case "Cofagrigus"
                stamret = 151
                atkret = 163
                defret = 237

            Case "Tirtouga"
                stamret = 144
                atkret = 134
                defret = 146

            Case "Carracosta"
                stamret = 179
                atkret = 192
                defret = 197

            Case "Archen"
                stamret = 146
                atkret = 213
                defret = 89

            Case "Archeops"
                stamret = 181
                atkret = 292
                defret = 139

            Case "Trubbish"
                stamret = 137
                atkret = 96
                defret = 122

            Case "Garbodor"
                stamret = 190
                atkret = 181
                defret = 164

            Case "Zorua"
                stamret = 120
                atkret = 153
                defret = 78

            Case "Zoroark"
                stamret = 155
                atkret = 250
                defret = 127

            Case "Minccino"
                stamret = 146
                atkret = 98
                defret = 80

            Case "Cinccino"
                stamret = 181
                atkret = 198
                defret = 130

            Case "Gothita"
                stamret = 128
                atkret = 98
                defret = 112

            Case "Gothorita"
                stamret = 155
                atkret = 137
                defret = 153

            Case "Gothitelle"
                stamret = 172
                atkret = 176
                defret = 205

            Case "Solosis"
                stamret = 128
                atkret = 170
                defret = 83

            Case "Duosion"
                stamret = 163
                atkret = 208
                defret = 103

            Case "Reuniclus"
                stamret = 242
                atkret = 214
                defret = 148

            Case "Ducklett"
                stamret = 158
                atkret = 84
                defret = 96

            Case "Swanna"
                stamret = 181
                atkret = 182
                defret = 132

            Case "Vanillite"
                stamret = 113
                atkret = 118
                defret = 106

            Case "Vanillish"
                stamret = 139
                atkret = 151
                defret = 138

            Case "Vanilluxe"
                stamret = 174
                atkret = 218
                defret = 184

            Case "Deerling"
                stamret = 155
                atkret = 115
                defret = 100

            Case "Sawsbuck"
                stamret = 190
                atkret = 198
                defret = 146

            Case "Emolga"
                stamret = 146
                atkret = 158
                defret = 127

            Case "Karrablast"
                stamret = 137
                atkret = 137
                defret = 87

            Case "Escavalier"
                stamret = 172
                atkret = 223
                defret = 187

            Case "Foongus"
                stamret = 170
                atkret = 97
                defret = 91

            Case "Amoonguss"
                stamret = 249
                atkret = 155
                defret = 139

            Case "Frillish"
                stamret = 146
                atkret = 115
                defret = 134

            Case "Jellicent"
                stamret = 225
                atkret = 159
                defret = 178

            Case "Alomomola"
                stamret = 338
                atkret = 138
                defret = 131

            Case "Joltik"
                stamret = 137
                atkret = 110
                defret = 98

            Case "Galvantula"
                stamret = 172
                atkret = 201
                defret = 128

            Case "Ferroseed"
                stamret = 127
                atkret = 82
                defret = 155

            Case "Ferrothorn"
                stamret = 179
                atkret = 158
                defret = 223

            Case "Klink"
                stamret = 120
                atkret = 98
                defret = 121

            Case "Klang"
                stamret = 155
                atkret = 150
                defret = 174

            Case "Klinklang"
                stamret = 155
                atkret = 199
                defret = 214

            Case "Tynamo"
                stamret = 111
                atkret = 105
                defret = 78

            Case "Eelektrik"
                stamret = 163
                atkret = 156
                defret = 130

            Case "Eelektross"
                stamret = 198
                atkret = 217
                defret = 152

            Case "Elgyem"
                stamret = 146
                atkret = 148
                defret = 100

            Case "Beheeyem"
                stamret = 181
                atkret = 221
                defret = 163

            Case "Litwick"
                stamret = 137
                atkret = 108
                defret = 98

            Case "Lampent"
                stamret = 155
                atkret = 169
                defret = 115

            Case "Chandelure"
                stamret = 155
                atkret = 271
                defret = 182

            Case "Axew"
                stamret = 130
                atkret = 154
                defret = 101

            Case "Fraxure"
                stamret = 165
                atkret = 212
                defret = 123

            Case "Haxorus"
                stamret = 183
                atkret = 284
                defret = 172

            Case "Cubchoo"
                stamret = 146
                atkret = 128
                defret = 74

            Case "Beartic"
                stamret = 216
                atkret = 233
                defret = 152

            Case "Cryogonal"
                stamret = 190
                atkret = 190
                defret = 218

            Case "Shelmet"
                stamret = 137
                atkret = 72
                defret = 140

            Case "Accelgor"
                stamret = 190
                atkret = 220
                defret = 120

            Case "Stunfisk"
                stamret = 240
                atkret = 144
                defret = 171

            Case "Mienfoo"
                stamret = 128
                atkret = 160
                defret = 98

            Case "Mienshao"
                stamret = 163
                atkret = 258
                defret = 127

            Case "Druddigon"
                stamret = 184
                atkret = 213
                defret = 170

            Case "Golett"
                stamret = 153
                atkret = 127
                defret = 92

            Case "Golurk"
                stamret = 205
                atkret = 222
                defret = 154

            Case "Pawniard"
                stamret = 128
                atkret = 154
                defret = 114

            Case "Bisharp"
                stamret = 163
                atkret = 232
                defret = 176

            Case "Bouffalant"
                stamret = 216
                atkret = 195
                defret = 182

            Case "Rufflet"
                stamret = 172
                atkret = 150
                defret = 97

            Case "Braviary"
                stamret = 225
                atkret = 232
                defret = 152

            Case "Vullaby"
                stamret = 172
                atkret = 105
                defret = 139

            Case "Mandibuzz"
                stamret = 242
                atkret = 129
                defret = 205

            Case "Heatmor"
                stamret = 198
                atkret = 204
                defret = 129

            Case "Durant"
                stamret = 151
                atkret = 217
                defret = 188

            Case "Deino"
                stamret = 141
                atkret = 116
                defret = 93

            Case "Zweilous"
                stamret = 176
                atkret = 159
                defret = 135

            Case "Hydreigon"
                stamret = 211
                atkret = 256
                defret = 188

            Case "Larvesta"
                stamret = 146
                atkret = 156
                defret = 107

            Case "Volcarona"
                stamret = 198
                atkret = 264
                defret = 189

            Case "Cobalion"
                stamret = 209
                atkret = 192
                defret = 229

            Case "Terrakion"
                stamret = 209
                atkret = 260
                defret = 192

            Case "Virizion"
                stamret = 209
                atkret = 192
                defret = 229

            Case "Tornadus"
                stamret = 188
                atkret = 266
                defret = 164

            Case "Tornadus Therian"
                stamret = 188
                atkret = 238
                defret = 189

            Case "Thundurus Therian"
                stamret = 188
                atkret = 295
                defret = 161

            Case "Thundurus"
                stamret = 188
                atkret = 266
                defret = 164

            Case "Reshiram"
                stamret = 205
                atkret = 275
                defret = 211

            Case "Zekrom"
                stamret = 205
                atkret = 275
                defret = 211

            Case "Landorus Therian"
                stamret = 205
                atkret = 289
                defret = 179

            Case "Landorus"
                stamret = 205
                atkret = 261
                defret = 182

            Case "Kyurem White"
                stamret = 245
                atkret = 310
                defret = 183

            Case "Kyurem Black"
                stamret = 245
                atkret = 310
                defret = 183

            Case "Kyurem"
                stamret = 245
                atkret = 246
                defret = 170

            Case "Keldeo Resolute"
                stamret = 209
                atkret = 260
                defret = 192

            Case "Keldeo"
                stamret = 209
                atkret = 260
                defret = 192

            Case "Meloetta Aria"
                stamret = 225
                atkret = 250
                defret = 225

            Case "Meloetta Pirouette"
                stamret = 225
                atkret = 269
                defret = 188

            Case "Genesect"
                stamret = 174
                atkret = 252
                defret = 199

            Case "Chespin"
                stamret = 148
                atkret = 110
                defret = 106

            Case "Quilladin"
                stamret = 156
                atkret = 146
                defret = 156

            Case "Chesnaught"
                stamret = 204
                atkret = 201
                defret = 204

            Case "Fennekin"
                stamret = 120
                atkret = 116
                defret = 102

            Case "Braixen"
                stamret = 153
                atkret = 171
                defret = 130

            Case "Delphox"
                stamret = 181
                atkret = 230
                defret = 189

            Case "Froakie"
                stamret = 121
                atkret = 122
                defret = 84

            Case "Frogadier"
                stamret = 144
                atkret = 168
                defret = 114

            Case "Ash-Greninja"
                stamret = 176
                atkret = 339
                defret = 155

            Case "Greninja"
                stamret = 176
                atkret = 223
                defret = 152

            Case "Bunnelby"
                stamret = 116
                atkret = 68
                defret = 72

            Case "Diggersby"
                stamret = 198
                atkret = 112
                defret = 155

            Case "Fletchling"
                stamret = 128
                atkret = 95
                defret = 80

            Case "Fletchinder"
                stamret = 158
                atkret = 145
                defret = 110

            Case "Talonflame"
                stamret = 186
                atkret = 176
                defret = 155

            Case "Scatterbug"
                stamret = 116
                atkret = 63
                defret = 63

            Case "Spewpa"
                stamret = 128
                atkret = 48
                defret = 89

            Case "Vivillon"
                stamret = 190
                atkret = 176
                defret = 103

            Case "Litleo"
                stamret = 158
                atkret = 139
                defret = 112

            Case "Pyroar"
                stamret = 200
                atkret = 221
                defret = 149

            Case "Flabébé"
                stamret = 127
                atkret = 108
                defret = 120

            Case "Floette"
                stamret = 144
                atkret = 136
                defret = 151

            Case "Florges"
                stamret = 186
                atkret = 212
                defret = 244

            Case "Skiddo"
                stamret = 165
                atkret = 123
                defret = 102

            Case "Gogoat"
                stamret = 265
                atkret = 196
                defret = 146

            Case "Pancham"
                stamret = 167
                atkret = 145
                defret = 107

            Case "Pangoro"
                stamret = 216
                atkret = 226
                defret = 146

            Case "Furfrou"
                stamret = 181
                atkret = 164
                defret = 167

            Case "Espurr"
                stamret = 158
                atkret = 120
                defret = 114

            Case "Meowstic"
                stamret = 179
                atkret = 166
                defret = 167

            Case "Honedge"
                stamret = 128
                atkret = 135
                defret = 139

            Case "Doublade"
                stamret = 153
                atkret = 188
                defret = 206

            Case "Aegislash Blade"
                stamret = 155
                atkret = 291
                defret = 97

            Case "Aegislash Shield"
                stamret = 155
                atkret = 97
                defret = 291

            Case "Spritzee"
                stamret = 186
                atkret = 110
                defret = 113

            Case "Aromatisse"
                stamret = 226
                atkret = 173
                defret = 150

            Case "Swirlix"
                stamret = 158
                atkret = 109
                defret = 119

            Case "Slurpuff"
                stamret = 193
                atkret = 168
                defret = 163

            Case "Inkay"
                stamret = 142
                atkret = 98
                defret = 95

            Case "Malamar"
                stamret = 200
                atkret = 177
                defret = 165

            Case "Binacle"
                stamret = 123
                atkret = 96
                defret = 120

            Case "Barbaracle"
                stamret = 176
                atkret = 194
                defret = 205

            Case "Skrelp"
                stamret = 137
                atkret = 109
                defret = 109

            Case "Dragalge"
                stamret = 163
                atkret = 177
                defret = 207

            Case "Clauncher"
                stamret = 137
                atkret = 108
                defret = 117

            Case "Clawitzer"
                stamret = 174
                atkret = 221
                defret = 171

            Case "Helioptile"
                stamret = 127
                atkret = 115
                defret = 78

            Case "Heliolisk"
                stamret = 158
                atkret = 219
                defret = 168

            Case "Tyrunt"
                stamret = 151
                atkret = 158
                defret = 123

            Case "Tyrantrum"
                stamret = 193
                atkret = 227
                defret = 191

            Case "Amaura"
                stamret = 184
                atkret = 124
                defret = 109

            Case "Aurorus"
                stamret = 265
                atkret = 186
                defret = 163

            Case "Sylveon"
                stamret = 216
                atkret = 203
                defret = 205

            Case "Hawlucha"
                stamret = 186
                atkret = 195
                defret = 153

            Case "Dedenne"
                stamret = 167
                atkret = 164
                defret = 134

            Case "Carbink"
                stamret = 137
                atkret = 95
                defret = 285

            Case "Goomy"
                stamret = 128
                atkret = 101
                defret = 112

            Case "Sliggoo"
                stamret = 169
                atkret = 159
                defret = 176

            Case "Goodra"
                stamret = 207
                atkret = 220
                defret = 242

            Case "Klefki"
                stamret = 149
                atkret = 160
                defret = 179

            Case "Phantump"
                stamret = 125
                atkret = 125
                defret = 103

            Case "Trevenant"
                stamret = 198
                atkret = 201
                defret = 154

            Case "Pumpkaboo Super"
                stamret = 153
                atkret = 118
                defret = 120

            Case "Pumpkaboo Large"
                stamret = 144
                atkret = 120
                defret = 122

            Case "Pumpkaboo Average"
                stamret = 135
                atkret = 121
                defret = 123

            Case "Pumpkaboo Small"
                stamret = 127
                atkret = 122
                defret = 124

            Case "Gourgeist Super"
                stamret = 198
                atkret = 182
                defret = 200

            Case "Gourgeist Large"
                stamret = 181
                atkret = 179
                defret = 206

            Case "Gourgeist Average"
                stamret = 163
                atkret = 175
                defret = 213

            Case "Gourgeist Small"
                stamret = 146
                atkret = 171
                defret = 219

            Case "Bergmite"
                stamret = 146
                atkret = 117
                defret = 120

            Case "Avalugg"
                stamret = 216
                atkret = 196
                defret = 240

            Case "Noibat"
                stamret = 120
                atkret = 83
                defret = 73

            Case "Noivern"
                stamret = 198
                atkret = 205
                defret = 175

            Case "Xerneas"
                stamret = 246
                atkret = 250
                defret = 185

            Case "Yveltal"
                stamret = 246
                atkret = 250
                defret = 185

            Case "Zygarde Complete"
                stamret = 389
                atkret = 184
                defret = 207

            Case "Zygarde 50%"
                stamret = 239
                atkret = 203
                defret = 232

            Case "Zygarde 10%"
                stamret = 144
                atkret = 205
                defret = 173

            Case "Mega Diancie"
                stamret = 125
                atkret = 312
                defret = 214

            Case "Diancie"
                stamret = 137
                atkret = 190
                defret = 285

            Case "Hoopa Unbound"
                stamret = 173
                atkret = 311
                defret = 191

            Case "Hoopa Confined"
                stamret = 173
                atkret = 261
                defret = 187

            Case "Volcanion"
                stamret = 190
                atkret = 252
                defret = 216

            Case "Rowlet"
                stamret = 169
                atkret = 102
                defret = 99

            Case "Dartrix"
                stamret = 186
                atkret = 142
                defret = 139

            Case "Decidueye"
                stamret = 186
                atkret = 210
                defret = 179

            Case "Litten"
                stamret = 128
                atkret = 128
                defret = 79

            Case "Torracat"
                stamret = 163
                atkret = 174
                defret = 103

            Case "Incineroar"
                stamret = 216
                atkret = 214
                defret = 175

            Case "Popplio"
                stamret = 137
                atkret = 120
                defret = 103

            Case "Brionne"
                stamret = 155
                atkret = 168
                defret = 145

            Case "Primarina"
                stamret = 190
                atkret = 232
                defret = 195

            Case "Pikipek"
                stamret = 111
                atkret = 136
                defret = 59

            Case "Trumbeak"
                stamret = 146
                atkret = 159
                defret = 100

            Case "Toucannon"
                stamret = 190
                atkret = 222
                defret = 146

            Case "Yungoos"
                stamret = 134
                atkret = 122
                defret = 56

            Case "Gumshoos"
                stamret = 204
                atkret = 194
                defret = 113

            Case "Grubbin"
                stamret = 132
                atkret = 115
                defret = 85

            Case "Charjabug"
                stamret = 149
                atkret = 145
                defret = 161

            Case "Vikavolt"
                stamret = 184
                atkret = 254
                defret = 158

            Case "Crabrawler"
                stamret = 132
                atkret = 150
                defret = 104

            Case "Crabominable"
                stamret = 219
                atkret = 231
                defret = 138

            Case "Oricorio Pa'u"
                stamret = 181
                atkret = 196
                defret = 145

            Case "Oricorio Sensu"
                stamret = 181
                atkret = 196
                defret = 145

            Case "Oricorio Baile"
                stamret = 181
                atkret = 196
                defret = 145

            Case "Oricorio Pom-Pom"
                stamret = 181
                atkret = 196
                defret = 145

            Case "Cutiefly"
                stamret = 120
                atkret = 110
                defret = 81

            Case "Ribombee"
                stamret = 155
                atkret = 198
                defret = 146

            Case "Rockruff"
                stamret = 128
                atkret = 117
                defret = 78

            Case "Lycanroc Midnight"
                stamret = 198
                atkret = 218
                defret = 152

            Case "Lycanroc Dusk"
                stamret = 181
                atkret = 234
                defret = 139

            Case "Lycanroc Midday"
                stamret = 181
                atkret = 231
                defret = 140

            Case "Wishiwashi School"
                stamret = 128
                atkret = 255
                defret = 242

            Case "Wishiwashi Solo"
                stamret = 128
                atkret = 46
                defret = 43

            Case "Mareanie"
                stamret = 137
                atkret = 98
                defret = 110

            Case "Toxapex"
                stamret = 137
                atkret = 114
                defret = 273

            Case "Mudbray"
                stamret = 172
                atkret = 175
                defret = 121

            Case "Mudsdale"
                stamret = 225
                atkret = 214
                defret = 174

            Case "Dewpider"
                stamret = 116
                atkret = 72
                defret = 117

            Case "Araquanid"
                stamret = 169
                atkret = 126
                defret = 219

            Case "Fomantis"
                stamret = 120
                atkret = 100
                defret = 64

            Case "Lurantis"
                stamret = 172
                atkret = 192
                defret = 169

            Case "Morelull"
                stamret = 120
                atkret = 108
                defret = 119

            Case "Shiinotic"
                stamret = 155
                atkret = 154
                defret = 168

            Case "Salandit"
                stamret = 134
                atkret = 136
                defret = 80

            Case "Salazzle"
                stamret = 169
                atkret = 228
                defret = 130

            Case "Stufful"
                stamret = 172
                atkret = 136
                defret = 95

            Case "Bewear"
                stamret = 260
                atkret = 226
                defret = 141

            Case "Bounsweet"
                stamret = 123
                atkret = 55
                defret = 69

            Case "Steenee"
                stamret = 141
                atkret = 78
                defret = 94

            Case "Tsareena"
                stamret = 176
                atkret = 222
                defret = 195

            Case "Comfey"
                stamret = 139
                atkret = 165
                defret = 215

            Case "Oranguru"
                stamret = 207
                atkret = 168
                defret = 192

            Case "Passimian"
                stamret = 225
                atkret = 222
                defret = 160

            Case "Wimpod"
                stamret = 93
                atkret = 67
                defret = 74

            Case "Golisopod"
                stamret = 181
                atkret = 218
                defret = 226

            Case "Sandygast"
                stamret = 146
                atkret = 120
                defret = 118

            Case "Palossand"
                stamret = 198
                atkret = 178
                defret = 178

            Case "Pyukumuku"
                stamret = 146
                atkret = 97
                defret = 224

            Case "Type Null"
                stamret = 216
                atkret = 184
                defret = 184

            Case "Silvally"
                stamret = 216
                atkret = 198
                defret = 198

            Case "Minior Core"
                stamret = 155
                atkret = 218
                defret = 131

            Case "Minior Meteor"
                stamret = 155
                atkret = 116
                defret = 194

            Case "Komala"
                stamret = 163
                atkret = 216
                defret = 165

            Case "Turtonator"
                stamret = 155
                atkret = 165
                defret = 215

            Case "Togedemaru"
                stamret = 163
                atkret = 190
                defret = 145

            Case "Mimikyu"
                stamret = 146
                atkret = 177
                defret = 199

            Case "Bruxish"
                stamret = 169
                atkret = 208
                defret = 145

            Case "Drampa"
                stamret = 186
                atkret = 231
                defret = 164

            Case "Dhelmise"
                stamret = 172
                atkret = 233
                defret = 179

            Case "Jangmo-o"
                stamret = 128
                atkret = 102
                defret = 108

            Case "Hakamo-o"
                stamret = 146
                atkret = 145
                defret = 162

            Case "Kommo-o"
                stamret = 181
                atkret = 222
                defret = 240

            Case "Tapu Koko"
                stamret = 172
                atkret = 250
                defret = 181

            Case "Tapu Lele"
                stamret = 172
                atkret = 259
                defret = 208

            Case "Tapu Bulu"
                stamret = 172
                atkret = 249
                defret = 215

            Case "Tapu Fini"
                stamret = 172
                atkret = 189
                defret = 254

            Case "Cosmog"
                stamret = 125
                atkret = 54
                defret = 57

            Case "Cosmoem"
                stamret = 125
                atkret = 54
                defret = 242

            Case "Solgaleo"
                stamret = 264
                atkret = 255
                defret = 191

            Case "Lunala"
                stamret = 264
                atkret = 255
                defret = 191

            Case "Nihilego"
                stamret = 240
                atkret = 249
                defret = 210

            Case "Buzzwole"
                stamret = 216
                atkret = 236
                defret = 196

            Case "Pheromosa"
                stamret = 174
                atkret = 316
                defret = 85

            Case "Xurkitree"
                stamret = 195
                atkret = 330
                defret = 144

            Case "Celesteela"
                stamret = 219
                atkret = 207
                defret = 199

            Case "Kartana"
                stamret = 139
                atkret = 323
                defret = 182

            Case "Guzzlord"
                stamret = 440
                atkret = 188
                defret = 99

            Case "Ultra Necrozma"
                stamret = 200
                atkret = 337
                defret = 196

            Case "Necrozma Dusk Mane"
                stamret = 200
                atkret = 277
                defret = 220

            Case "Necrozma Dawn Wings"
                stamret = 200
                atkret = 277
                defret = 220

            Case "Necrozma"
                stamret = 219
                atkret = 251
                defret = 195

            Case "Magearna"
                stamret = 190
                atkret = 246
                defret = 225

            Case "Marshadow"
                stamret = 207
                atkret = 265
                defret = 190

            Case "Poipole"
                stamret = 167
                atkret = 145
                defret = 133

            Case "Naganadel"
                stamret = 177
                atkret = 263
                defret = 159

            Case "Stakataka"
                stamret = 156
                atkret = 213
                defret = 298

            Case "Blacephalon"
                stamret = 142
                atkret = 315
                defret = 148

            Case "Zeraora"
                stamret = 204
                atkret = 252
                defret = 177

            Case "Meltan"
                stamret = 130
                atkret = 118
                defret = 99

            Case "Melmetal"
                stamret = 264
                atkret = 226
                defret = 190

            Case Else
                stamret = 0
                atkret = 0
                defret = 0

        End Select

        Return {stamret, atkret, defret}
    End Function
End Class
