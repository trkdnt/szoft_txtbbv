---


---

<h1 id="pontozólap">Pontozólap</h1>
<p>Név: Török Donát<br>
Neptun: TXTBBV</p>
<h2 id="projekt-rövid-leírása">Projekt rövid leírása:</h2>
<p>Egy egyszerű web- és desktopalkalmazás idézetek kezelésére és megjelenítésére. Az alkalmazás API-n keresztül kapcsolódik egy adatbázishoz, ahol különböző kategóriákba sorolt idézetek tárolódnak. A webes felületen megtekinthetők az összes idézetek egy táblázatban, szűrési lehetőséggel a kategóriák szerint, illetve új idézetek rögzíthetők. A desktopalkalmazás lehetőséget nyújt az idézetek hozzáadására, módosítására és törlésére egy DataGridView vezérlőn keresztül, amely automatikusan frissül az adatbázisból. A weboldal egy dinamikusan betöltött “Nap idézete” funkciót is tartalmaz, ami véletlenszerűen jelenít meg egy idézetet a felhasználónak.</p>
<h2 id="hozott-anyag">Hozott Anyag</h2>
<p><strong>CSS</strong>:</p>
<ul>
<li>A weboldal stílusának biztosításához egy hozott CSS fájlt használtam.</li>
<li><strong>Fájl neve:</strong> <code>style.css</code></li>
</ul>
<h3 id="windows-forms-application"><strong>Windows Forms Application</strong></h3>
<h4 id="user-interface">User Interface</h4>
<ul>
<li>
<p><strong><code>1x2p</code> Az alkalmazásból a kilépés csak megerősítő kérdés után lehetséges.</strong></p>
<ul>
<li><strong>Teljesítve:</strong> A <code>FormClosing</code> esemény kezelője megerősítést kér a kilépés előtt.</li>
<li><strong>Screenshot:</strong></li>
</ul>
</li>
</ul>
<hr>
<h4 id="tábla-adatainak-megjelenítése-datagridview-ban">Tábla adatainak megjelenítése <code>DataGridView</code>-ban</h4>
<ul>
<li>
<p><strong><code>1x2p</code> Adatok megjelenítése.</strong></p>
<ul>
<li><strong>Teljesítve:</strong> Az idézetek a <code>DataGridView</code>-ban jelennek meg.</li>
<li><strong>Screenshot:</strong></li>
</ul>
</li>
</ul>
<hr>
<h4 id="adatkötés-bindingsource--on-keresztül">Adatkötés <code>BindingSource</code> -on keresztül</h4>
<ul>
<li>
<p><strong><code>1x2p</code> Működő <code>BindingSource</code>.</strong></p>
<ul>
<li><strong>Teljesítve:</strong> A <code>BindingSource</code> biztosítja az adatkötést a <code>DataGridView</code> és más vezérlők között.</li>
<li><strong>Screenshot:</strong></li>
</ul>
</li>
<li>
<p><strong><code>3x1p</code> Egy <code>BindingSource</code>-ra egy gyűjtemény megjelenítésére alkalmas vezérlő (ListÍBox, ComboBox, DataGridVIew) mellett más adatkötött vezérlő is van kötve, mint <code>TextBox</code>, <code>DateTimePicker</code>, <code>ComboBox</code> idegen kulcs értékének beállítására, stb.</strong></p>
<ul>
<li><strong>Teljesítve:</strong> A <code>TextBox</code> vezérlők az éppen kiválasztott rekord értékeit jelenítik meg.</li>
<li><strong>Screenshot:</strong></li>
</ul>
</li>
</ul>
<hr>
<h4 id="új-rekord-rögzítése">Új rekord rögzítése</h4>
<ul>
<li>
<p><strong><code>1x1p</code> Ha legalább egy nem kulcs mező, pl. Mennyiség is fel van véve.</strong></p>
<ul>
<li><strong>Teljesítve:</strong> Az új rekord felvétele során az idézet, szerző, kategória és egyéb mezők is rögzíthetők.</li>
<li><strong>Screenshot:</strong></li>
</ul>
</li>
<li>
<p><strong><code>1x2p</code> Ellenőrzéshez kötött adatfelvitel (egyszerű validáció pl: <code>String.IsNullOrEmpty()</code>).</strong></p>
<ul>
<li><strong>Teljesítve:</strong> Az üres mezőket egyszerű validációval ellenőrzi.</li>
<li><strong>Screenshot:</strong></li>
</ul>
</li>
</ul>
<hr>
<h4 id="rekord-törlése">Rekord törlése</h4>
<ul>
<li>
<p><strong><code>1x2p</code> Sikeres törlés.</strong></p>
<ul>
<li><strong>Teljesítve:</strong> Rekord törlése az adatbázisból működik.</li>
<li><strong>Screenshot:</strong></li>
</ul>
</li>
<li>
<p><strong><code>1x2p</code> Megerősítéshez kötött törlés.</strong></p>
<ul>
<li><strong>Teljesítve:</strong> A törlést megerősítő kérdés előzi meg.</li>
<li><strong>Screenshot:</strong></li>
</ul>
</li>
</ul>
<hr>
<h3 id="asp-.net"><strong>ASP .NET</strong></h3>
<h4 id="asp-.net-alkalmazás-melyet-lehet-a-forms-alapú-projekttel-közös-solution-ben-létrehozni.">ASP .NET alkalmazás, melyet lehet a Forms alapú projekttel közös solution-ben létrehozni.</h4>
<ul>
<li><code>1x2p</code>  <code>program.cs</code> beállítása <code>wwwroot</code> mappában tárolt statikus tartalmak megosztására</li>
</ul>
<h4 id="api-végpontok">API végpontok</h4>
<ul>
<li>
<p><strong><code>1x3p</code> Teljes SQL tábla adatainak szolgáltatása API végponton keresztül.</strong></p>
<ul>
<li><strong>Teljesítve:</strong> A <code>GET /api/donat</code> végpont visszaadja a tábla tartalmát.</li>
<li><strong>Screenshot:</strong></li>
</ul>
</li>
<li>
<p><strong><code>2x2p</code> SQL tábla egy választható rekordjának szolgáltatása API végponton keresztül.</strong></p>
<ul>
<li><strong>Teljesítve:</strong> A <code>GET /api/donat/{id}</code> végpont működik.</li>
<li><strong>Screenshot:</strong></li>
</ul>
</li>
<li>
<p><strong><code>1x3p</code> SQL tábla egy választható rekordjának törlése.</strong></p>
<ul>
<li><strong>Teljesítve:</strong> A <code>DELETE /api/donat/{id}</code> végpont működik.</li>
<li><strong>Screenshot:</strong></li>
</ul>
</li>
<li>
<p><strong><code>1x5p</code> Új rekord felvétele <code>HttpPost</code> metóduson keresztül SQL táblába.</strong></p>
<ul>
<li><strong>Teljesítve:</strong> A <code>POST /api/donat</code> végpont új rekordot rögzít.</li>
<li><strong>Screenshot:</strong></li>
</ul>
</li>
<li>
<p><strong><code>1x3p</code> Rekord módosítása <code>HttpPost</code> metóduson keresztül SQL táblában.</strong></p>
<ul>
<li><strong>Teljesítve:</strong> A <code>PUT /api/donat/{id}</code> végpont működik.</li>
<li><strong>Screenshot:</strong></li>
</ul>
</li>
</ul>
<hr>
<h3 id="javascript"><strong>Javascript</strong></h3>
<ul>
<li><strong><code>1x5p</code> (pl: szöveg és kép) DOM feltöltése javascripttel (vizsgán írandó, NEM HOZOTT).</strong>
<ul>
<li><strong>Teljesítve:</strong> A <code>vizsga.js</code> fájl dinamikusan tölti fel a táblázatot és a “Nap idézete” mezőt.</li>
<li><strong>Screenshot:</strong></li>
</ul>
</li>
</ul>
<h3 id="weboldal"><strong>Weboldal</strong></h3>
<h4 id="a-weboldalnak-van-egy-értelmezhető-struktúrája-1x1p"><strong>1. A weboldalnak van egy értelmezhető struktúrája (<code>1x1p</code>)</strong></h4>
<ul>
<li><strong>Teljesítve:</strong> Az <code>index.html</code> egyértelmű, értelmezhető struktúrával rendelkezik:
<ul>
<li>Fejléc (<code>&lt;head&gt;</code>), szövegek, táblázat a tartalom megjelenítéséhez, form elemek rekordok hozzáadásához és szűréséhez.</li>
</ul>
</li>
<li><strong>Pont:</strong> 1 pont</li>
<li><strong>Screenshot:</strong></li>
</ul>
<hr>
<h4 id="a-weboldal-dinamikus-tartalommal-tölthető-fel-adatbázison-keresztül-1x1p"><strong>2. A weboldal dinamikus tartalommal tölthető fel adatbázison keresztül (<code>1x1p</code>)</strong></h4>
<ul>
<li><strong>Teljesítve:</strong> Az API végpontokon keresztül (pl. <code>GET /api/donat</code>) a táblázat dinamikusan frissül az adatbázis adataival.</li>
<li><strong>Pont:</strong> 1 pont</li>
<li><strong>Screenshot:</strong></li>
</ul>
<hr>
<h4 id="a-weboldal-használ-legalább-20-sor-értelmes-css-t-1x1p"><strong>3. A weboldal használ legalább 20 sor értelmes CSS-t (<code>1x1p</code>)</strong></h4>
<ul>
<li><strong>Teljesítve:</strong> A <code>style.css</code> fájlban több mint 20 sor értelmes CSS található:
<ul>
<li>Táblázatok formázása, szövegek középre igazítása, hover effektek stb.</li>
</ul>
</li>
<li><strong>Pont:</strong> 1 pont</li>
<li><strong>Screenshot:</strong></li>
</ul>
<hr>
<h4 id="a-weboldal-javascriptje-más-funkciót-is-ellát-mint-az-adatok-betöltése-1x1p"><strong>5. A weboldal JavaScriptje más funkciót is ellát, mint az adatok betöltése (<code>1x1p</code>)</strong></h4>
<ul>
<li><strong>Teljesítve:</strong> A <code>vizsga.js</code> fájl tartalmaz további funkciókat, például:
<ul>
<li>Új rekord rögzítése (<code>POST /api/donat</code>).</li>
<li>Adatok szűrése kategória alapján (<code>GET /api/donat/category/{category}</code>).</li>
</ul>
</li>
<li><strong>Pont:</strong> 1 pont</li>
<li><strong>Screenshot:</strong></li>
</ul>
<hr>
<h3 id="egyéb-extra"><strong>Egyéb, extra</strong></h3>
<h4 id="scaffold-dbcontext-használata-1x1p"><strong><code>Scaffold-DbContext</code> használata (<code>1x1p</code>)</strong></h4>
<p><strong>Screenshot:</strong></p>

