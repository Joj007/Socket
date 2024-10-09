using System.Net.Sockets;
using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static public List<string> lista = new List<string>();
        static Random rnd = new Random();
        static void Main(string[] args)
        {

            lista.Add("Az államnak kötelessége az, hogy a néptársak tömegéből a legnagyobb gondossággal és pontossággal kiválassza és a köz szolgálatába állítsa a természet által láthatólag legnagyobb tehetséggel megáldott emberanyagot. - Adolf Hitler");
            lista.Add("Általában a felsőbb rétegek, módosabb szülők gyermekeit magasabb kiképzésre méltatják. A tehetség kérdésének teljesen alárendelt szerep jut. Alkotó munka pedig csak úgy lehetséges, ha a tudás tehetséggel párosul. - Adolf Hitler");
            lista.Add("A népi államok célja, hogy az ifjúság megfelelő nevelése révén gondoskodjanak arról, hogy egykor földünkön a végső és döntő küzdelem érett nemzedékre találjon. Az a nép fog győzni, amely először lép erre az útra! - Adolf Hitler");
            lista.Add("Senki sem lehet büszke népére, ha annak egy része ínségben él, gondterhelt, esetleg züllött. Csak testileg-lelkileg egészséges nép keltheti fel bennünk annak az öröm érzetét, hogy ehhez a néphez tartozunk, és csak az ilyen nép lehet nemzeti büszkeség tárgya. Ezt a legnagyobb büszkeséget viszont csakis az érezheti, aki ismeri népe nagyságát. - Adolf Hitler");
            lista.Add("Olyan nemzeti érzés nincs, amely nyerészkedésen alapszik. - Adolf Hitler");
            lista.Add("Aki szereti népét, szeretetét csupán az érte hozott áldozatok árán mutathatja ki. - Adolf Hitler");
            lista.Add("A német történelem nagy jelentőségű neveinek a tömegéből ki kell választani a legnagyobbakat, és olyan módon kell bemutatnunk ifjúságunknak, hogy azok a nemzeti érzés megdönthetetlen pillérei legyenek. - Adolf Hitler");
            lista.Add("Az általános képzettség és a különleges szakképzettség között éles ellentétnek kell fennállania. Minthogy az utóbbi éppen manapság mindinkább a pénz szolgájává alacsonyodik le, legalább az ideális szemléletű általános műveltségnek kell ellensúlyként fennmaradnia. - Adolf Hitler");
            lista.Add("Nem azért tanulunk történelmet, hogy megtörtént tényeket megismerjünk, hanem azért, hogy benne a jövő és saját népünk létének tanítómesterére találjunk. Ez a célunk. A történelemtanítás csak eszköz. - Adolf Hitler");
            lista.Add("A történelemtanítás eredménye száz közül kilencvenkilenc esetben siralmas. Néhány adat, születési szám, név mégmegmarad emlékezetünkben, de teljesen hiányzik a határozott, nagy koncepciójú irányvonal. Ami lényeges, azt nem tanítják. Az egyes tanulók többé-kevésbé zseniális hajlamára bízzák, hogy az adatok áradatában és az események forgatagában rátaláljanak a belső indítóokra. - Adolf Hitler");
            lista.Add("Aligha tanul más nép annyi történelmet, mint a német, de alig is van olyan nép, amely ennek kevésbé vehetné hasznát, mint a miénk. Ha a politika a keletkező történelem, akkor történelmi nevelésünk felett politikai magatartásunk ítélkezik. Nem helyénvaló politikai teljesítményeink siralmas eredményeinek bírálgatása mindaddig, amíg nem gondoskodunk jobb politikai nevelésről. - Adolf Hitler");
            lista.Add("Mindenekelőtt a fiatal agyat általában ne terheljük olyan anyaggal, amelynek 95%-ára amúgy sincs szüksége, és ezért megint elfelejti. - Adolf Hitler");
            lista.Add("Nem a fegyverek hiánya, az akarathiány tesz bennünket ma is minden komoly ellenállásra képtelenné. Ez a hiány ma áthatja egész népünket, megakadályoz minden kockázatos elhatározást, mintha a test nagysága nem éppen a merészségben gyökereznék. - Adolf Hitler");
            lista.Add("Mások hibája jól látszik, magunké alig látható. Az ember mások hibáit mint a pelyvát teríti szét, a sajátjait elrejti, mint rossz dobást ügyes csaló. - Buddha");
            lista.Add("Ezer haszontalan szónál többet ér egyetlen szó, amely nyugalmat ad. - Buddha");
            lista.Add("Erényes, igaz és bölcs az, aki sem a maga, sem a más érdekében nem vágyódik sok gyerekre, hatalomra vagy gazdagságra, aki saját érdekeit nem helyezi az igazságosság elé.   - Buddha");
            lista.Add("Tekints arra az emberre, aki feltárja előtted hibáidat úgy, mintha rejtett kincset tárna fel. Ő a bölcs, aki megmutatja neked az élet veszedelmeit. Kövesd: aki követi, csak jót lát és semmi rosszat.   - Buddha");
            lista.Add("A bolond, aki bölcsnek hiszi magát, egész életében önmaga ellensége. Hibát hibára halmoz, és azok végül keserű gyümölcsöt teremnek.   - Buddha");
            lista.Add("Az önmagán uralkodó elme nagy örömök forrása.   - Buddha");
            lista.Add("Aki fejlődik a hitben, aki sohasem felejti el legfőbb célját, akinek cselekedetei tiszták, s aki gondosan ügyel cselekedeteire, aki önuralomban tökéletesedik, és aki mindig, örökké éber, az megdicsőül.   - Buddha");
            lista.Add("„Megbántottak, megsértettek, legyőztek, kifosztottak.” Aki így gondolkodik, nem szabadul meg a gyűlölettől.   - Buddha");
            lista.Add("Ha az ember tisztátalan elmével szól vagy cselekszik, a szenvedés úgy követi, mint a kocsiba fogott igásállatot a kerék.   - Buddha");
            lista.Add("A gondolat szóként nyilvánul meg. A szó tettként nyilvánul meg. A tett szokássá válik. A szokás pedig jellemmé szilárdul. Vigyázz ezért nagyon, hogy mit gondolsz. Tégy róla, hogy a gondolataid szeretetből szülessenek, és együttérzésből valamennyi létező iránt.   - Buddha");
            lista.Add("Ha az élet hosszú útján a vándor nem talál magánál jobb vagy legalább magához méltó társat, hadd menjen örömmel, hisz a bolond nem segítheti az útját.   - Buddha");
            lista.Add("Mint a virág, ami szépen virít és szép a színe, de nincs illata, olyan a meddő szó, annak a szava, aki beszél, de nem úgy cselekszik. És mint egy pompás virág, aminek szép a színe és kellemes az illata, olyanok a termékeny szavak, annak a szavai, aki beszél, és aszerint cselekszik.   - Buddha");
            lista.Add("Ne gondolkodj mások hibáin, mit tettek és mit nem tettek. Gondolkodj inkább saját bűneiden, mit tettél és mit nem tettél.   - Buddha");
            lista.Add("A halál semmiség, de legyőzötten, dicsőség nélkül élni, az olyan mintha mindennap meghalna az ember.   - Bonaparte Napóleon");
            lista.Add("Mindent azoknak köszönhetek, akik megnyerték nekem a csatáimat. Nem hízelgőkre, hanem jó katonákra van szükségem.   - Bonaparte Napóleon");
            lista.Add("Tudom, mikor kell ledobnom az oroszlán bőrét, hogy magamra öltsem a rókáét.   - Bonaparte Napóleon");
            lista.Add("Fiatal koromban, tudatlan és becsvágyó lévén, forradalmár voltam.   - Bonaparte Napóleon");
            lista.Add("A hatalmam a dicsőségemen alapul, a dicsőségem pedig a győztes csatáimon.   - Bonaparte Napóleon");
            lista.Add("Én leszek a királyok Brutusa és a Köztársaság Caesarja.   - Bonaparte Napóleon");
            lista.Add("Tapasztalataim arra késztetnek, hogy tetteik alapján ítéljem meg az embereket.   - Bonaparte Napóleon");
            lista.Add("Mind közül az önkényuralmi rendszer a legjobb és a legstabilabb, ha az élén egy bölcs, felvilágosult és határozott király áll, és ő maga irányítja az országot.   - Bonaparte Napóleon");
            lista.Add("Én soha nem tűrtem a kritikát. Az orvostól is azt kérik, hogy szüntesse meg a lázat, és nem azt, hogy írjon egy szatírát ellene.   - Bonaparte Napóleon");
            lista.Add("A vallás valójában a lélek pihenője, a remény, a szerencsétlenek mentőkötele. Mennyi szolgálatot tett a kereszténység az emberiségnek! És még mennyivel nagyobb hatalma volna, ha a papjai értenék a dolgukat!   - Bonaparte Napóleon");
            lista.Add("Dicsőségem nem a győzelmeimben, hanem a törvénykönyvemben van.   - Bonaparte Napóleon");
            lista.Add("Egy hadsereg vezér nélkül semmit nem ér.   - Bonaparte Napóleon");
            lista.Add("A intelligencia többet ér, mint az erő; az erő önmagában, intelligencia nélkül, nem ér semmit. Hajdan, a hősi időkben a sereg legerősebb embere lett a tábornok; a modern időkben a legintelligensebb harcosé a tábornoki poszt.   - Bonaparte Napóleon");
            lista.Add("Szerintem az egyik legnagyszerűbb dolog a sportban, hogy mindenkiről igen rövid idő alatt kiderül, mire képes nyomás alatt: összeroppan vagy túltesz saját magán.   - Donald Trump");
            lista.Add("Mindegy, hogy hány éves vagy: a saját érzéseidhez, ambíciódhoz és céljaidhoz mérd magadat, ne pedig másokéihoz.   - Donald Trump");
            lista.Add("Akármi legyen a mostani munkád, végezd szenvedéllyel, és csodák fognak történni. Találkozni fogsz a megfelelő emberrel, fel fognak rád figyelni. Én ezt újra meg újra tapasztalom.   - Donald Trump");
            lista.Add("Az élet nevű játékban az elért pontszámot pénzben fejezik ki.   - Donald Trump");
            lista.Add("Nem a pénz miatt csinálom. Abból van már elég, több is, mint amennyire valaha szükségem lesz. Azért csinálom, hogy csináljam. Az én művészetem a biznisz, a nagy üzletek megkötése. Mások gyönyörű képeket visznek vászonra, vagy csodálatos verseket írnak. Én üzleteket szeretek kötni, lehetőleg nagy üzleteket. Ezt élvezem az életben.   - Donald Trump");
            lista.Add("A holnapi eredményeidet az határozza meg, amit ma csinálsz. Ha azt akarod, hogy tartós legyen a jóléted, mindennap tenned kell érte valamit!   - Donald Trump");
            lista.Add("Ha a maximumot akarod elérni, nem engedheted meg magadnak az önelégültség luxusát.   - Donald Trump");
            lista.Add("Ha valaki keresztbe tesz neked, azt tanácsolom: „állj bosszút!” Nem nagyon szoktak ilyet tanácsolni, de a való élet már csak ilyen. Ha nem vágsz vissza, balfék vagy! Ha valaki kitol veled, verd le rajta, mert jól fog esni, és mások is okulnak belőle. Imádok bosszút állni. Engem rendszeresen átvernek. Én meg visszavágok, és mi ennek az eredménye? Velem sokkal kevesebbszer próbálkoznak, mint másokkal. Tudják, hogy ha megpróbálják, abból balhé lesz. Mindig vágj vissza!   - Donald Trump");
            lista.Add("A világ gonosz és durva. Azt hisszük, civilizáltak vagyunk. Valójában azonban a világ kegyetlen, az emberek könyörtelenek. Szemtől szembe kedvesen viselkednek, de az álca mögött le akarnak mészárolni.   - Donald Trump");
            lista.Add("Ha sikeres akarsz lenni, hozzá kell szoknod, hogy gyakran elhangzik a „nem” szó – és neked nem szabad meghallanod. Ha gyerekkorodban anyukád, apukád, a tanárod, az edződ azt mondta, nem lehet, nem szabad, te jó kisfiú vagy jó kislány voltál, azonnal abbahagytad, amit csináltál? Ennek következtében a felnőttek 89 százaléka arra van kondícionálva, hogy ha elhangzik a „nem” szó, már le is állnak. Aki feladja, nem jut el sehova. Nem leszel sikeres, ha hallgatsz a „nem”-ekre.   - Donald Trump");
            lista.Add("A siker szempontjából az a legfontosabb, hogy szeresd, amit csinálsz. Sokat kell dolgoznod, és hatalmas kihívásoknak kell megfelelned a siker felé vezető úton. Ha nem szereted, amit csinálsz, sosem fogsz ezzel boldogulni. Ha szereted a munkádat, a nehézségeket legyűri az élvezet.   - Donald Trump");
            lista.Add("Ha valaki a szólás szabadságával élve sérti más ember méltóságát, becsületét, ha igaztalan, súlyosan sértő dolgot állít, mindezt nagy nyilvánosság előtt teszi, az büntetendő cselekmény.   - Gyurcsány Ferenc");
            lista.Add("A sajtó túllép működésének okszerűen velejáró szerepén, ha a közvélemény befolyásolása nem egyszerűen a sajtó állásfoglalásának természetes következménye, hanem kifejezetten azt célozza, hogy az egyik politikai szereplőnek közvetlen kárt okozzon.   - Gyurcsány Ferenc");
            lista.Add("Demokratikus, hazafias sajtó nélkül nincs erős, demokratikus Magyarország.   - Gyurcsány Ferenc");
            lista.Add("A köznyilvánosság minősége nem egyszerűen a társadalom minőségének tükre, hanem annak a közösség vezetőivel közel egyenrangú alakítója. Határozott meggyőződésem, hogy a nyilvánosságnak ezt a szerepét sokkal többen nem értik, mint ahányan igen, sokkal többen nem vállalják ennek felelőségét, mint ahányan igen.   - Gyurcsány Ferenc");
            lista.Add("Amikor az emberek többsége újságot választ, akkor, bár azt hiheti, hogy „csak” értékrendet választ, valójában viszont véleményt, olyat, amely nagy valószínűséggel azonos a sajátjával. A tájékozódásnál sokszor fontosabb, hogy az újságolvasással megerősítést nyerjen saját véleményünk, valamely véleményközösséghez való tartozásunk. Az ellentétes állásponttal való találkozás diszkomfortot okoz, mert arra kényszeríti az embert, hogy újra átgondolja saját véleményének helyességét.   - Gyurcsány Ferenc");
            lista.Add("A demokratikus sajtónak kulcsszerepe van a demokratikus társadalom megszervezésében, fenntartásában, mert normát, mintát közvetít és teremt.   - Gyurcsány Ferenc");
            lista.Add("Te egy tőről metszett fideszes politikus vagy, frissebb, mint Orbán, de minden bizonnyal tehetségtelenebb. Eldőlt, hogy mentalitásod, gondolkodásod, véleményed a Fidesz világához köt, bár igaz, magadat jobban szereted, mint őket.   - Gyurcsány Ferenc");
            lista.Add("Mi az oka az Orbán által felépített és fenntartott, Magyarországnak egyoldalúan káros, valójában alárendeltséget jelentő orosz kapcsolatnak? Egyetlen válasz lehetséges: Orbánt a markukban tartják az oroszok. Valamivel zsarolják. Mivel?   - Gyurcsány Ferenc");
            lista.Add("Orbánt nem zavarja, hogy orosz állami hackerek ki-be mászkálnak a kormány informatikai hálózatába, visznek, amit tudnak, magyar, EU, NATO titkokat. Nem tesz ellenük semmit, fenntartja a szívélyes kapcsolatot.   - Gyurcsány Ferenc");
            lista.Add("Nem hinném, hogy politikai vitákat bibliai idézetekkel, mint végső, megfellebbezhetetlen érvekkel lehet eldönteni. Ájtatatosságba burkolózó kurzuskeresztények rossz szokása ez. Ha elfogy gondolat, kölcsönkérnek mondjuk az apostoloktól. Ha nincs hova menekülni, akkor a szentírás tekintélye mögé bújnak.   - Gyurcsány Ferenc");
            lista.Add("Amikor valamelyik ellenzéki párt politikusa tagnak jelentkezik hozzánk, a beszélgetések végén igyekszem én is találkozni a tagjelölttel. Belenézni a szemébe. Érteni az okokat, az ambíciókat, a gondolat finomságát, mélységét, látni a reakciókat. Persze ők meg engem tesztelnek végső döntésük előtt. Így van ez rendjén.   - Gyurcsány Ferenc");
            lista.Add("Az élet a legnagyobb csoda. Száznál valamivel több kémiai elem úgy rendeződött össze, hogy a majdnem semmi életre kelt: megmozdult, válaszolt, megsokszorozta önmagát. Hogy ki vagy mi volt a rendező, nem tudjuk. Az egyik hisz az anyagi világ felsőbb elrendezettségében, az isteni akaratban, a másik pedig ezzel szemben a véletlen teremtő valóságában. Az élet alig magyarázható csoda, így okszerű, hogy a csoda mögött is csodát keressünk. Minden kultúra megtalálta saját Istenét az élet, a rend végső forrásaként. Az élet teremti az Istent, vagy az Isten teremti az életet? A kérdés válasz nélkül is a létező világ, más életének elfogadásában, a szeretetben nyer evilági, végül praktikus értelmet.   - Gyurcsány Ferenc");
            lista.Add("A politika nem egy bonyolult műfaj. Persze van neki egy szakmai mélysége, de az alapkérdései nem bonyolultak. Az emberek megválasztanak vezetőket, a vezetők megmondják, hogy mit vállalnak, aztán azt teljesítik, vagy nem. És ha nem, akkor el kell őket küldeni, le kell őket cserélni.   - Orbán Viktor");
            lista.Add("Senki sem mondhatja meg a magyaroknak, hogy mi kikkel éljünk együtt, se Gyuri bácsi, se a brüsszeli bürokraták, senki. Azt a magyarok döntik el, hogy Magyarország területén kivel kívánunk együtt élni. És erről a jogunkról nem vagyunk hajlandóak lemondani, és nem engedjük, hogy megfosszanak bennünket ettől a jogunktól.   - Orbán Viktor");
            lista.Add("Túlzás nélkül biztosan mondhatom azt, hogy ma Magyarország nélkül, a magyar emberek nélkül, a magyar kormány hangja nélkül nincs szabadság Európában.   - Orbán Viktor");
            lista.Add("A szólásszabadság Nyugat-Európában rossz bőrben van. Ott kialakultak olyan liberális társadalmak, amelyben a közvéleményt alakító tényezők, leginkább a média, az egyetemek, a kutatóintézetek, az alapítványok és persze a politikusok egyszínűvé váltak, és nagyjából ugyanazt mondják. Én tudom, hogy a magyaroknak ezt nehéz elhinni, mert mi a Nyugatot mindig a szabadság szimbólumának tekintettük, de ennek vége van. Tehát ha kinyitok, most meg sem nevezem az országot, mondjuk, két német újságot, egy baloldalit meg egy jobboldalit, ott a fontos kérdésekről pontosan ugyanazt fogom olvasni. Tehát egész egyszerűen ma egy olyan vélemény-úthenger uralkodik Nyugat-Európában, amit a magyarok el se tudnak képzelni. És ez párosul a mindennapi elnyomásnak a jelenségeivel.   - Orbán Viktor");
            lista.Add("Háborús hangulat van Brüsszelben. Ugye, amikor én beszélgetek Önnel erről a kérdésről, akkor mi azt mondjuk, hogy orosz–ukrán háború. És érzékelhető, legalábbis az én szándékom szerint, a szavaimból érzékelhető egyfajta távolságtartás, mert ez itt van a szomszédságunkban. Ez egy jelentős konfliktus. Szegény ukránok borzalmasan szenvednek. Százezerszám halnak meg emberek, özvegyek, árvák, lebombázott városok, tehát borzalmas, amit látunk, de ennek ellenére az álláspontunk világosan az, hogy ez egy orosz–ukrán háború. Ez nem a mi háborúnk, ez két szláv nép háborúja, amit minél hamarabb tűzszünettel és béketárgyalással le kellene zárni. Tehát a magyar ember számára ez nem egy olyan háború, amiben mi is benne vagyunk. Ha azonban a brüsszeli vezetőket hallgatom, ők úgy beszélnek a háborúról, mint a saját háborújukról, ugyanis ők benne vannak.   - Orbán Viktor");
            lista.Add("Az a különlegessége van Donald Trumpnak, minden más elnökhöz képest, hogy ő már az elnökség előtt is egy legenda volt. Beugró kicsi filmszerepek, nagy ingatlanmágnás, szóval ő egy legenda.   - Orbán Viktor");
            lista.Add("Magyarországon nagyon nehéz választást nyerni, Magyarországon nagyon nagy politikai küzdelmek zajlanak, ami a demokráciának a bizonyítéka.   - Orbán Viktor");
            lista.Add("Az, hogy Magyarország a családi értékek mellett kiáll, miközben mindenki az LMBTQ-s bolondságokról beszél egész Nyugat-Európában, és az alkotmányban védjük a családi értékeket, ez Amerikában tiszteletet vált ki. Szóval jobban állunk elismertség és tekintély szempontjából, mint mi azt gondolni szoktuk.   - Orbán Viktor");
            lista.Add("Az amerikaiak általában az európai kultúrát és történelmet részleteiben nem ismerik. Van egy műveltségük és tudásuk persze a világról és így Európáról is. Annyit megértenek az amerikaiak, hogy mi egy szomszédos ország vagyunk. És ha a szomszédodban háború van, az neked rossz. Azt is mondhatnám, hogy miután üzletemberek az amerikaiak, pontosan tudják, hogy a te ingatlanodnak, a te házadnak az értékét csökkenti, ha a szomszédodban veszekednek, vagy ott háború van. Ennyit értenek.   - Orbán Viktor");
            lista.Add("Azért mentem Amerikába, hogy az amerikai–magyar politikai barátságot helyreállítsuk. A mostani kormányzattal ez nem megy. Ennek megvan a maga oka. Egy háborúpárti kormányzat, ami most Washingtonban van, demokraták adják az elnököt, és elkötelezettek a háború mellett. Mi meg egy békepárti kormány vagyunk, tehát nem őrölünk egy malomban. Ellenben Trump elnök úr a béke elnöke volt. Az ő esetében sincs szó zsákbamacskáról, hiszen ő már volt elnök, tehát pontosan tudjuk, hogy mi fog történni. Ő az első négy évében lezárt háborúkat. Ő volt hosszú idő után az első olyan elnök, akinek az ideje alatt nem indult háború. Tehát róla tudjuk, az elnöki működéséből tudjuk, hogy ő a béke embere.   - Orbán Viktor");
            lista.Add("Egy olyan elnökünk lesz most, aki a sarkától a füléig minden sejtjével, elkötelezetten hívő lélekként fogja szolgálni a hazáját.   - Orbán Viktor");
            lista.Add("Valóban ő a hetedik, ami egy veszélyes szám. Énnekem az a kitüntetés adatott meg, hogy én mind a hét köztársasági elnökkel dolgozhattam miniszterelnökként is. Úgyhogy van valami elképzelésem arról, hogy melyik helyzethez milyen köztársasági elnök való, milyen köztársasági elnök tudja leginkább szolgálni Magyarországot egy adott helyzetben.   - Orbán Viktor");
            lista.Add("A ’24-es év nem is kezdődhetett volna rosszabbul. Köztársasági elnök asszonyunk benyújtotta lemondását az Országgyűlésnek. Olyan ez, mint egy rémálom. Mindannyiunkat megvisel.   - Orbán Viktor");
            lista.Add("A demokrácia a kormányzás legrosszabb formája, leszámítva azokat, amiket már próbáltunk.   - Winston Churchill");
            lista.Add("Abból élünk, amit kapunk, de az éltet minket, amit adunk.   - Winston Churchill");
            lista.Add("Minden ember akkora, amekkora dolgok feldühítik.   - Winston Churchill");
            lista.Add("Mindenféle hibát el fogsz követni, ameddig azonban nagylelkű maradsz és igaz, de egyúttal a végsőkig kitartó, nem tudsz komolyan ártani a világnak, és még nagy bajt sem tudsz okozni.   - Winston Churchill");
            lista.Add("Szeretem, ha mennek a dolgok. Ha nem mennek, szeretem elérni, hogy menjenek.   - Winston Churchill");
            lista.Add("Mindig kész vagyok tanulni, annak azonban nem mindig örülök, ha tanítanak.   - Winston Churchill");
            lista.Add("Az élet egyik legkegyetlenebb leckéje, hogy alkalmanként rá kell jönnöd, hogy a bolondoknak is lehet igazuk.   - Winston Churchill");
            lista.Add("Mindig bölcs dolog előre nézni; de nehéz messzebbre tekinteni, mint ameddig ellátunk.   - Winston Churchill");
            lista.Add("Ez nem a vég. Nem is a vég kezdete. De talán ez a kezdet vége.   - Winston Churchill");
            lista.Add("Fanatikus az, akit lehetetlen meggyőzni, de témát sem hajlandó váltani.   - Winston Churchill");



            string kar = "r";
            while (kar=="r")
            {
                uzenet();
                //Console.WriteLine("-----------------------------------\nÚj üzenet?");
                kar = Console.ReadLine().ToString();
            }















        }

        static private void uzenet()
        {
            try
            {
                // Create a TcpClient.
                // Note: Port number must match the server's port
                TcpClient client = new TcpClient("localhost", 65432);

                // Get a client stream for reading and writing.
                NetworkStream stream = client.GetStream();

                // Send a message to the connected server.
                byte[] data = Encoding.UTF8.GetBytes(lista[rnd.Next(lista.Count)]);

                // Send the message to the server
                stream.Write(data, 0, data.Length);
                //Console.WriteLine("Sent: {0}", message);

                // Buffer to store the response bytes.
                data = new byte[256];
                string responseData = string.Empty;

                // Read the response from the server.
                int bytes = stream.Read(data, 0, data.Length);
                responseData = Encoding.UTF8.GetString(data, 0, bytes);
                Console.WriteLine("Napi bölcsesség: {0}", responseData);

                // Close everything
                stream.Close();
                client.Close();
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("ArgumentNullException: {0}", e);
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}", e);
            }
        }
    }
}
