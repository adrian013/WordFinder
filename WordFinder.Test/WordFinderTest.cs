namespace WordFinder.Test
{
    public class WordFinderTest
    {
        private List<string> _exampleMatrix;
        private List<string> _biggestMatrix;
        public WordFinderTest()
        {
            _exampleMatrix = new List<string>
            {
                "abcdc",
                "fgwio",
                "chill",
                "pqnsd",
                "uvdxy",
                "windy"
            };

            //big matrix 50 x 53
            //generated using https://tools.atozteacherstuff.com/word-search-maker/wordsearch.php
            _biggestMatrix = new List<string>
            {
                "RSHSFAVHOQXQOTOUNMVMKAALZAWJTGRQAVWOECBAJZRIWJCDNR",
                "ATGVMPXJSLWQAARTSDXZTMFCOSPDKWXTQCJBMUGNTMKHGKOFQS",
                "HUONEWHAMPSHIREGCZRSDCKJEHLLMYSSQWAVVXAYNPMHPUNFKO",
                "QRNUNRJRSFWVMGGSGFXQPDIONIAGDHUMKFXUXUYUKBLHYMNEWX",
                "VPDXDRKATMHZNWOOTDIEUMSKPKAPFFZCIKCPLHOIOUESLVERRR",
                "TYBMELNQYLTKZENTDXPWDWMLKZTISCFNXHFYJOWCRDYOKKCJDM",
                "UNITPRENMFBCVSKRATYJLGWYOMINGONYSVIHINDIANAUONTJCK",
                "FMAGSOVJPCJMTTPBBWZDDNPMJREGKOHOAWBNDPXFJPATPWIMWN",
                "HDTBPTAOZQRMCVRYEMNIIZCEUOHFZRVKPARYACNGJNLHXMCJXZ",
                "LNTSFJDNYUMAKIRRWCSTOPWMTSENYSDTHQAVHHKBORRDGIUQKX",
                "FXEJAFAJZJILIRLRLSMMVHGZAIGQRXVEOJWZOBJXZUGABSTQKU",
                "KLIGFECZUCUADGTJCTJBHLLGHJHCXWUNACRHBFQHEBFKESNNCO",
                "EJLWFDXEYUMSWIQSNPSPKNZAFFJEGJBNFIMVWZPZHHZOCIREIO",
                "BUFIGOJZSVUKDNYYVQTUSRXYCQMKZLFEBSMXEPBPOQRTUSDHKG",
                "LOMWBIMHQNCAWIGCELCHSPQMHLSYCJFSRRYMXGGBYQYAISMLGK",
                "DHFCDMMREVEPPANAADXKUFUXFQRCQXQSVHMCQJLTUFNTGIULQA",
                "JITYBKJLGVTHNWWQTLZQJUCJTXZKAALEMHDMGROTSDHOFPZKPM",
                "NORTHCAROLINAYVBSQMJLTBBJUKDTRDEUTDILSIEIJYLRPRVUM",
                "XRRVNVTVOJRGVRBKECATYRDBKMXPOKBQZEIGKOGVWWDBZIJQQT",
                "YHPEQNVGSTSZHPURRVYPWPENNSYLVANIAFZVOUCDACEARNNUTY",
                "EOSRUKGEYIOWAVZAHJDZTTNIEOKPZNLFUCLENTIFOAHLALZKKU",
                "HDCMQGIKCQOKWKXONOFGZRFAWOOJTSFHLKODAHNLNJAQDRWSJM",
                "CENORTHDAKOTAJFGMZCGAAULJKPNLAHRDXZXCCWYSMNRZRFWVQ",
                "ZILNZVJJYXCHIOAFIPYAMCZAEHCDYSSVDCDYOAHJBJPDCSJRZS",
                "ASHTBBWXVRYJIKTZYMELEGVBRHLYIPPBYPYGRRXVFIDRKXSWVN",
                "XLAXRUMEIMYQGMPIMFDAWYTASOCQTNRQKFTRJOINAVOHGRDSVB",
                "CATEATXTRTNAXSMRDRLRZYPMEMVSTVZDSJNOULGPMLZLGFAPML",
                "UNPTJNXTGDLXJJOQVIMBTAQAYMTOECALIFORNIAFJFHBIGRTWJ",
                "SDICRLFWISCONSINPSOOEEKLHIHGVSKDSFMYBNLOCLUQRJGBWC",
                "ZJPZIHUGNJQZOGNSOENMUMINNESOTADAXKANSASLWCLIEJGQRW",
                "WCQMTMPIIZFBJPHMQMTJNBGCSXNZKGPTDZLXUYOEVFRJNITDZD",
                "UXVVVTTHAYGALWBYAVATCKANJPCWPNOSMEDBZVKTXVCWVHCHFA",
                "ESYABAMYICPILGNRWKNWORYXZNFXQKXSMYVHZUJNEFWWMIPUGF",
                "COHIRIDUJVOXEHEHJIAYSIJJVETFOHUUFSEFVXMYZYEPTEGZLP",
                "RAYQLLFYWVTPDEBFTEMWICLWNWAJWNGDAGCJOYCNURYZNQPMDR",
                "XZEDILWYZEYFLORIDAXTUBUNZMEJMYHMRPEPZPGMFYIJEHHDFG",
                "PFRVQIWQJTKHDVAHVLVDJMPTYEKOPDCAINJVHREFLQIPPUOVCP",
                "PHIUCNUFQHETNWSELAFCXTWHUXTMIBISZVGYYEOGRLBJAEZMZU",
                "IZVCFOJOZONSBQKFJBNBBVZLIIVICZLSOXXVNIRXYWTSVAIAJW",
                "JHBDMITAMQEVKRALSHTTNOXXSCVSVLNANWMLGCGTGUQHTBMROY",
                "UXEKGSCDPBSRTTIMBWASHINGTONSVMOCAOGEXOIEOZOYNVZYTL",
                "HXYVXMUFANHWYDPDGCSCXWJQBZHOGXAHAHHMUQAICMWHEMLLIK",
                "DUTGHOAMDYWKDEZJQUKENTUCKYDUXENUFRKVWMPLGAGKWCYAJE",
                "JKTXGKWKTNUMPLZNRXVJXCDEUKRRVDVSKLWSEITCNUKSYEGNXY",
                "FULRDLWNSZRDOAHDHLPNXSAQAHVISPAEAXYPSCFQICOLORADOM",
                "FBTEXASDKYNPDWLOUISIANAGIGEFQPNTNYQPWHTIZYLYRVTJHZ",
                "QKZZBHKLATJHKAMAINEUGNRCODVLCIYTHXCRBIOHRJWVKOPGVR",
                "HKWXTOGAWAZUARWOURBWQPOUEHYKAUESGEATDGJISHFZIPCYPA",
                "ZUMBEMZKSBTPFETQCJAHBCJAOMOHHYLIWISRKACXSPNRGEQTCS",
                "VVXGIAIVGYLQVJOFTJMLWADULSQCMKPBHODHINGEGVPQXGXLLH",
                "RHODEISLANDCONNECTICUTMARYLANDNEWJERSEYMASSACHUSET",
                "MINNESOTAOHIONEWMEXICOCOLORADOMISSOURIKANSASASDWEF",
                "IDAHOWISCONSINALABAMATENNESSEEALASKAMICHIGANHAWAII"
            };
        }

        [Fact]
        public void FindOneWordHorizontal()
        {
            var wordFinder = new WordFinder(_exampleMatrix);

            var wordsToSearch = new List<string> { "chill" };

            var foundWords = wordFinder.Find(wordsToSearch);

            Assert.True(wordsToSearch.SequenceEqual<string>(foundWords));
        }

        [Fact]
        public void FindOneWordVertical()
        {
            var wordFinder = new WordFinder(_exampleMatrix);

            var wordsToSearch = new List<string> { "cold" };

            var foundWords = wordFinder.Find(wordsToSearch);

            Assert.True(wordsToSearch.SequenceEqual<string>(foundWords));
        }

        [Fact]
        public void FindTreeWordsHorizontalAndVertical()
        {
            var wordFinder = new WordFinder(_exampleMatrix);

            var wordsToSearch = new List<string> { "wind", "chill", "cold"  };

            var foundWords = wordFinder.Find(wordsToSearch);

            Assert.True(wordsToSearch.SequenceEqual<string>(foundWords));
        }

        [Fact]
        public void FindNoWords()
        {
            var wordFinder = new WordFinder(_biggestMatrix);

            var wordsToSearch = new List<string> { "IMPOSIBLEWORD" };

            var foundWords = wordFinder.Find(wordsToSearch);

            Assert.Empty(foundWords);
        }

        [Fact]
        public void Find50WordsHorizontalAndVertical()
        {
            var wordFinder = new WordFinder(_biggestMatrix);

            var wordsToSearch = new List<string> {
                "IDAHO",
                "RHODEISLAND",
                "ARIZONA",
                "VERMONT",
                "MISSISSIPPI",
                "NEBRASKA",
                "NORTHCAROLINA",
                "SOUTHDAKOTA",
                "ILLINOIS",
                "WISCONSIN",
                "NEWYORK",
                "ARKANSAS",
                "NORTHDAKOTA",
                "CONNECTICUT",
                "CALIFORNIA",
                "SOUTHCAROLINA",
                "MONTANA",
                "MARYLAND",
                "INDIANA",
                "TEXAS",
                "ALABAMA",
                "GEORGIA",
                "MASSACHUSETTS",
                "NEWJERSEY",
                "WESTVIRGINIA",
                "UTAH",
                "VIRGINIA",
                "TENNESSEE",
                "FLORIDA",
                "MINNESOTA",
                "OREGON",
                "DELAWARE",
                "KANSAS",
                "ALASKA",
                "WASHINGTON",
                "OHIO",
                "MAINE",
                "HAWAII",
                "LOUISIANA",
                "MICHIGAN",
                "MISSOURI",
                "NEVADA",
                "NEWMEXICO",
                "OKLAHOMA",
                "IOWA",
                "KENTUCKY",
                "COLORADO",
                "WYOMING",
                "PENNSYLVANIA",
                "NEWHAMPSHIRE"
            };

            var expectedWords = new List<string>
            {
                "KANSAS",
                "IDAHO",
                "RHODEISLAND",
                "WISCONSIN",
                "CONNECTICUT",
                "MARYLAND",
                "ALABAMA",
                "NEWJERSEY",
                "VIRGINIA",
                "TENNESSEE"
            };

            var foundWords = wordFinder.Find(wordsToSearch);

            Assert.True(expectedWords.SequenceEqual<string>(foundWords));
        }
    }
}