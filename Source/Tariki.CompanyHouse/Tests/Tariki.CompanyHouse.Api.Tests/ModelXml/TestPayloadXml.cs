namespace Tariki.CompanyHouse.Api.Tests.ModelXml
{
    public class TestPayloadXml
    {
        public const string Document =
            @"  <Document xmlns=""http://xmlgw.companieshouse.gov.uk/v1-0/schema"" xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xsi:schemaLocation=""http://xmlgw.companieshouse.gov.uk/v1-0/schema http://xmlgw.companieshouse.gov.uk/v1-0/schema/CompanyDocument.xsd""><CompanyNumber>99999999</CompanyNumber>	<NumPages>2</NumPages>	<FormType>288a</FormType> </Document>";

        public const string NumberSearch =
            @"<NumberSearch xmlns=""http://xmlgw.companieshouse.gov.uk/v1-0/schema"" xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xsi:schemaLocation=""http://xmlgw.companieshouse.gov.uk/v1-0/schema http://xmlgw.companieshouse.gov.uk/v1-0/schema/NumberSearch.xsd"">
<SearchRows>1</SearchRows>  <CoSearchItem>    <CompanyName>TEST COMPANY LIMITED</CompanyName>    <CompanyNumber>99999999</CompanyNumber>    <DataSet>LIVE</DataSet>    <CompanyIndexStatus>EFFECTIVE</CompanyIndexStatus>    <CompanyDate>2002-09-24+06:00</CompanyDate>  </CoSearchItem></NumberSearch>";

        public const string NameSearch = @"
  <NameSearch xmlns=""http://xmlgw.companieshouse.gov.uk/v1-0/schema"" xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xsi:schemaLocation=""http://xmlgw.companieshouse.gov.uk/v1-0/schema http://xmlgw.companieshouse.gov.uk/v1-0/schema/NameSearch.xsd"">
  <ContinuationKey>f84e37eJylz01rwjAYB/A6rcZSHZvOXPcFhOqxePGRoIIT11TdTYoGFOsLVgfe1E++f6yM6o4L+UHy5O0fM1sik9iFuO2raP/e2qy2wfpIVsohdiZeHji+kFJ4o25LyLGQvvD6xAv9ZJk4xecWKupsDpFyXT2XKthN5647/R13gvUsVLv6xJkkX6uGi2+ln3syDCNl2U6iETvderyYifdeKzxdwwZuXTN+DrueuJXwH3a6NB5DfX302uO/2Zrhdh4s1fEu478Ov+mooCOnIQMmZCEHDPJggQ0FKMIzvMArlKAM+q4K8B91X2pj</ContinuationKey>
  <RegressionKey>f84e37eJylz01rwjAYB/A6rcZSHZvOXPcFhOqxePGRoIIT11TdTYoGFOsLVgfe1E++f6yM6o4L+UHy5O0fM1sik9iFuO2raP/e2qy2wfpIVsohdiZeHji+kFJ4o25LyLGQvvD6xAv9ZJk4xecWKupsDpFyXT2XKthN5647/R13gvUsVLv6xJkkX6uGi2+ln3syDCNl2U6iETvderyYifdeKzxdwwZuXTN+DrueuJXwH3a6NB5DfX302uO/2Zrhdh4s1fEu478Ov+mooCOnIQMmZCEHDPJggQ0FKMIzvMArlKAM+q4K8B91X2pj</RegressionKey>
  <SearchRows>100</SearchRows>
  <CoSearchItem>
    <CompanyName>TESQUIRE LIMITED</CompanyName>
    <CompanyNumber>06114228</CompanyNumber>
    <DataSet>LIVE</DataSet>
    <CompanyIndexStatus>DISSOLVED</CompanyIndexStatus>
    <CompanyDate>2009-11-01T00:00:00</CompanyDate>
<SearchMatch>NEAR</SearchMatch>
  </CoSearchItem>
  <CoSearchItem>
    <CompanyName>TESRANET WIRELESS ACCESS (NI) LTD</CompanyName>
    <CompanyNumber>NI047678</CompanyNumber>
    <DataSet>LIVE</DataSet>
    <CompanyIndexStatus>REMOVED</CompanyIndexStatus>
    <CompanyDate></CompanyDate>
  </CoSearchItem>
  <CoSearchItem>
    <CompanyName>TES (RB211-535) LIMITED</CompanyName>
    <CompanyNumber>05795051</CompanyNumber>
    <DataSet>LIVE</DataSet>
    <CompanyIndexStatus>DISSOLVED</CompanyIndexStatus>
    <CompanyDate></CompanyDate>
  </CoSearchItem>
  <CoSearchItem>
    <CompanyName>TES REALISATIONS LIMITED</CompanyName>
    <CompanyNumber>SC283258</CompanyNumber>
    <DataSet>LIVE</DataSet>
    <CompanyIndexStatus>DISSOLVED</CompanyIndexStatus>
    <CompanyDate></CompanyDate>
  </CoSearchItem>
  <CoSearchItem>
    <CompanyName>TES RECRUITMENT LIMITED</CompanyName>
    <CompanyNumber>06604315</CompanyNumber>
    <DataSet>LIVE</DataSet>
    <CompanyIndexStatus></CompanyIndexStatus>
    <CompanyDate></CompanyDate>
  </CoSearchItem>
  <CoSearchItem>
    <CompanyName>TES REINFORCEMENT LIMITED</CompanyName>
    <CompanyNumber>05358151</CompanyNumber>
    <DataSet>LIVE</DataSet>
    <CompanyIndexStatus></CompanyIndexStatus>
    <CompanyDate></CompanyDate>
  </CoSearchItem>
  <CoSearchItem>
    <CompanyName>TESREMOS LIMITED</CompanyName>
    <CompanyNumber>04359423</CompanyNumber>
    <DataSet>LIVE</DataSet>
    <CompanyIndexStatus></CompanyIndexStatus>
    <CompanyDate></CompanyDate>
  </CoSearchItem>
  <CoSearchItem>
    <CompanyName>TESRON ALLIANCE LIMITED</CompanyName>
    <CompanyNumber>04886711</CompanyNumber>
    <DataSet>LIVE</DataSet>
    <CompanyIndexStatus>DISSOLVED</CompanyIndexStatus>
    <CompanyDate></CompanyDate>
  </CoSearchItem>
  <CoSearchItem>
    <CompanyName>TESS LIMITED</CompanyName>
    <CompanyNumber>05759057</CompanyNumber>
    <DataSet>LIVE</DataSet>
    <CompanyIndexStatus></CompanyIndexStatus>
    <CompanyDate></CompanyDate>
  </CoSearchItem>
  <CoSearchItem>
    <CompanyName>TESSA LIMITED</CompanyName>
    <CompanyNumber>05461441</CompanyNumber>
    <DataSet>LIVE</DataSet>
    <CompanyIndexStatus></CompanyIndexStatus>
    <CompanyDate></CompanyDate>
  </CoSearchItem>
  <CoSearchItem>
    <CompanyName>TESSA BARON LIMITED</CompanyName>
    <CompanyNumber>03081438</CompanyNumber>
    <DataSet>LIVE</DataSet>
    <CompanyIndexStatus></CompanyIndexStatus>
    <CompanyDate></CompanyDate>
  </CoSearchItem>
  <CoSearchItem>
    <CompanyName>TESSA CHRISTOU LIMITED</CompanyName>
    <CompanyNumber>06533856</CompanyNumber>
    <DataSet>LIVE</DataSet>
    <CompanyIndexStatus></CompanyIndexStatus>
    <CompanyDate></CompanyDate>
  </CoSearchItem>
  <CoSearchItem>
    <CompanyName>TESSA COGGIN LIMITED</CompanyName>
    <CompanyNumber>06600398</CompanyNumber>
    <DataSet>LIVE</DataSet>
    <CompanyIndexStatus></CompanyIndexStatus>
    <CompanyDate></CompanyDate>
  </CoSearchItem>
  <CoSearchItem>
    <CompanyName>TESSA CORR ASSOCIATES LIMITED</CompanyName>
    <CompanyNumber>05590571</CompanyNumber>
    <DataSet>LIVE</DataSet>
    <CompanyIndexStatus></CompanyIndexStatus>
    <CompanyDate></CompanyDate>
  </CoSearchItem>
  <CoSearchItem>
    <CompanyName>TESSA CUNNINGHAM LIMITED</CompanyName>
    <CompanyNumber>04703018</CompanyNumber>
    <DataSet>LIVE</DataSet>
    <CompanyIndexStatus></CompanyIndexStatus>
    <CompanyDate></CompanyDate>
  </CoSearchItem>
  <CoSearchItem>
    <CompanyName>TESSA DAVIDSON LIMITED</CompanyName>
    <CompanyNumber>05559606</CompanyNumber>
    <DataSet>LIVE</DataSet>
    <CompanyIndexStatus></CompanyIndexStatus>
    <CompanyDate></CompanyDate>
  </CoSearchItem>
  <CoSearchItem>
    <CompanyName>TESSADAY LTD</CompanyName>
    <CompanyNumber>04475731</CompanyNumber>
    <DataSet>LIVE</DataSet>
    <CompanyIndexStatus>DISSOLVED</CompanyIndexStatus>
    <CompanyDate></CompanyDate>
  </CoSearchItem>
  <CoSearchItem>
    <CompanyName>TESSA DEVELOPMENTS LIMITED</CompanyName>
    <CompanyNumber>04171834</CompanyNumber>
    <DataSet>LIVE</DataSet>
    <CompanyIndexStatus></CompanyIndexStatus>
    <CompanyDate></CompanyDate>
  </CoSearchItem>
  <CoSearchItem>
    <CompanyName>TESSA FOWLER LTD</CompanyName>
    <CompanyNumber>04611911</CompanyNumber>
    <DataSet>LIVE</DataSet>
    <CompanyIndexStatus></CompanyIndexStatus>
    <CompanyDate></CompanyDate>
  </CoSearchItem>
  <CoSearchItem>
    <CompanyName>TESSA GROUP LTD.</CompanyName>
    <CompanyNumber>06672530</CompanyNumber>
    <DataSet>LIVE</DataSet>
    <CompanyIndexStatus></CompanyIndexStatus>
    <CompanyDate></CompanyDate>
  </CoSearchItem>
  <CoSearchItem>
    <CompanyName>TESSA JONES LIMITED</CompanyName>
    <CompanyNumber>05988384</CompanyNumber>
    <DataSet>LIVE</DataSet>
    <CompanyIndexStatus></CompanyIndexStatus>
    <CompanyDate></CompanyDate>
  </CoSearchItem>
  <CoSearchItem>
    <CompanyName>TESSA KENNEDY DESIGN LIMITED</CompanyName>
    <CompanyNumber>01964628</CompanyNumber>
    <DataSet>LIVE</DataSet>
    <CompanyIndexStatus></CompanyIndexStatus>
    <CompanyDate></CompanyDate>
  </CoSearchItem>
  <CoSearchItem>
    <CompanyName>TESSA LAM DESIGNS LIMITED</CompanyName>
    <CompanyNumber>01941572</CompanyNumber>
    <DataSet>LIVE</DataSet>
    <CompanyIndexStatus></CompanyIndexStatus>
    <CompanyDate></CompanyDate>
  </CoSearchItem>
  <CoSearchItem>
    <CompanyName>TESSA LANG PROPERTY SERVICES LIMITED</CompanyName>
    <CompanyNumber>06712920</CompanyNumber>
    <DataSet>LIVE</DataSet>
    <CompanyIndexStatus></CompanyIndexStatus>
    <CompanyDate></CompanyDate>
  </CoSearchItem>
  <CoSearchItem>
    <CompanyName>TESSALATE LIMITED</CompanyName>
    <CompanyNumber>05240461</CompanyNumber>
    <DataSet>LIVE</DataSet>
    <CompanyIndexStatus></CompanyIndexStatus>
    <CompanyDate></CompanyDate>
  </CoSearchItem>
  <CoSearchItem>
    <CompanyName>TESSA LEISURE LIMITED</CompanyName>
    <CompanyNumber>06822076</CompanyNumber>
    <DataSet>LIVE</DataSet>
    <CompanyIndexStatus></CompanyIndexStatus>
    <CompanyDate></CompanyDate>
  </CoSearchItem>
  <CoSearchItem>
    <CompanyName>T.E.S. (SALES) LIMITED</CompanyName>
    <CompanyNumber>06060666</CompanyNumber>
    <DataSet>LIVE</DataSet>
    <CompanyIndexStatus></CompanyIndexStatus>
    <CompanyDate></CompanyDate>
  </CoSearchItem>
  <CoSearchItem>
    <CompanyName>TESSALLA CONSULTING LIMITED</CompanyName>
    <CompanyNumber>05087887</CompanyNumber>
    <DataSet>LIVE</DataSet>
    <CompanyIndexStatus></CompanyIndexStatus>
    <CompanyDate></CompanyDate>
  </CoSearchItem>
  <CoSearchItem>
    <CompanyName>TESSALLA CONTRACTS LIMITED</CompanyName>
    <CompanyNumber>05088322</CompanyNumber>
    <DataSet>LIVE</DataSet>
    <CompanyIndexStatus>DISSOLVED</CompanyIndexStatus>
    <CompanyDate></CompanyDate>
  </CoSearchItem>
  <CoSearchItem>
    <CompanyName>TESSALLA ENTERPRISES LIMITED</CompanyName>
    <CompanyNumber>05088323</CompanyNumber>
    <DataSet>LIVE</DataSet>
    <CompanyIndexStatus>DISSOLVED</CompanyIndexStatus>
    <CompanyDate></CompanyDate>
  </CoSearchItem>
  <CoSearchItem>
    <CompanyName>TESSALLA ENTERPRISES LIMITED</CompanyName>
    <CompanyNumber>06785153</CompanyNumber>
    <DataSet>LIVE</DataSet>
    <CompanyIndexStatus></CompanyIndexStatus>
    <CompanyDate></CompanyDate>
  </CoSearchItem>
  <CoSearchItem>
    <CompanyName>TESSALL GARAGE,LIMITED</CompanyName>
    <CompanyNumber>00486062</CompanyNumber>
    <DataSet>LIVE</DataSet>
    <CompanyIndexStatus></CompanyIndexStatus>
    <CompanyDate></CompanyDate>
  </CoSearchItem>
  <CoSearchItem>
    <CompanyName>TESSA MAYES PRODUCTIONS LIMITED</CompanyName>
    <CompanyNumber>06227454</CompanyNumber>
    <DataSet>LIVE</DataSet>
    <CompanyIndexStatus></CompanyIndexStatus>
    <CompanyDate></CompanyDate>
  </CoSearchItem>
  <CoSearchItem>
    <CompanyName>TESSA MCMANUS LIMITED</CompanyName>
    <CompanyNumber>04615020</CompanyNumber>
    <DataSet>LIVE</DataSet>
    <CompanyIndexStatus></CompanyIndexStatus>
    <CompanyDate></CompanyDate>
  </CoSearchItem>
  <CoSearchItem>
    <CompanyName>TESSAM DEVELOPMENTS LIMITED</CompanyName>
    <CompanyNumber>01801861</CompanyNumber>
    <DataSet>LIVE</DataSet>
    <CompanyIndexStatus></CompanyIndexStatus>
    <CompanyDate></CompanyDate>
  </CoSearchItem>
  <CoSearchItem>
    <CompanyName>TESSAN LIMITED</CompanyName>
    <CompanyNumber>04849525</CompanyNumber>
    <DataSet>LIVE</DataSet>
    <CompanyIndexStatus>DISSOLVED</CompanyIndexStatus>
    <CompanyDate></CompanyDate>
  </CoSearchItem>
  <CoSearchItem>
    <CompanyName>TESSA NEWCOMB LIMITED</CompanyName>
    <CompanyNumber>04633075</CompanyNumber>
    <DataSet>LIVE</DataSet>
    <CompanyIndexStatus></CompanyIndexStatus>
    <CompanyDate></CompanyDate>
  </CoSearchItem>
  <CoSearchItem>
    <CompanyName>TESSANN LIMITED</CompanyName>
    <CompanyNumber>02353773</CompanyNumber>
    <DataSet>LIVE</DataSet>
    <CompanyIndexStatus></CompanyIndexStatus>
    <CompanyDate></CompanyDate>
  </CoSearchItem>
  <CoSearchItem>
    <CompanyName>TESSANT LIMITED</CompanyName>
    <CompanyNumber>06559080</CompanyNumber>
    <DataSet>LIVE</DataSet>
    <CompanyIndexStatus></CompanyIndexStatus>
    <CompanyDate></CompanyDate>
  </CoSearchItem>
  <CoSearchItem>
    <CompanyName>TESSA OSBORN LIMITED</CompanyName>
    <CompanyNumber>05724579</CompanyNumber>
    <DataSet>LIVE</DataSet>
    <CompanyIndexStatus></CompanyIndexStatus>
    <CompanyDate></CompanyDate>
  </CoSearchItem>
  <CoSearchItem>
    <CompanyName>TESSA PROJECTS LTD</CompanyName>
    <CompanyNumber>06133575</CompanyNumber>
    <DataSet>LIVE</DataSet>
    <CompanyIndexStatus></CompanyIndexStatus>
    <CompanyDate></CompanyDate>
  </CoSearchItem>
  <CoSearchItem>
    <CompanyName>TESSA PROPERTIES LIMITED</CompanyName>
    <CompanyNumber>04535622</CompanyNumber>
    <DataSet>LIVE</DataSet>
    <CompanyIndexStatus></CompanyIndexStatus>
    <CompanyDate></CompanyDate>
  </CoSearchItem>
  <CoSearchItem>
    <CompanyName>TESSARO PRODUCTS LIMITED</CompanyName>
    <CompanyNumber>03824223</CompanyNumber>
    <DataSet>LIVE</DataSet>
    <CompanyIndexStatus>DISSOLVED</CompanyIndexStatus>
    <CompanyDate></CompanyDate>
  </CoSearchItem>
  <CoSearchItem>
    <CompanyName>TESSART LTD</CompanyName>
    <CompanyNumber>05723067</CompanyNumber>
    <DataSet>LIVE</DataSet>
    <CompanyIndexStatus>DISSOLVED</CompanyIndexStatus>
    <CompanyDate></CompanyDate>
  </CoSearchItem>
  <CoSearchItem>
    <CompanyName>THE TESSA SANDERSON FOUNDATION AND ACADEMY</CompanyName>
    <CompanyNumber>06790095</CompanyNumber>
    <DataSet>LIVE</DataSet>
    <CompanyIndexStatus></CompanyIndexStatus>
    <CompanyDate></CompanyDate>
  </CoSearchItem>
  <CoSearchItem>
    <CompanyName>TESSA SHAW CONSULTANTS LIMITED</CompanyName>
    <CompanyNumber>06503623</CompanyNumber>
    <DataSet>LIVE</DataSet>
    <CompanyIndexStatus></CompanyIndexStatus>
    <CompanyDate></CompanyDate>
  </CoSearchItem>
  <CoSearchItem>
    <CompanyName>TESS ASHEN LIMITED</CompanyName>
    <CompanyNumber>05528523</CompanyNumber>
    <DataSet>LIVE</DataSet>
    <CompanyIndexStatus></CompanyIndexStatus>
    <CompanyDate></CompanyDate>
  </CoSearchItem>
  <CoSearchItem>
    <CompanyName>TESSASTONE LIMITED</CompanyName>
    <CompanyNumber>01397107</CompanyNumber>
    <DataSet>LIVE</DataSet>
    <CompanyIndexStatus></CompanyIndexStatus>
    <CompanyDate></CompanyDate>
  </CoSearchItem>
  <CoSearchItem>
    <CompanyName>TESSA'S TOTS LIMITED</CompanyName>
    <CompanyNumber>04757542</CompanyNumber>
    <DataSet>LIVE</DataSet>
    <CompanyIndexStatus>DISSOLVED</CompanyIndexStatus>
    <CompanyDate></CompanyDate>
  </CoSearchItem>
  <CoSearchItem>
    <CompanyName>TESSA THOMSON-GLOVER LIMITED</CompanyName>
    <CompanyNumber>04355456</CompanyNumber>
    <DataSet>LIVE</DataSet>
    <CompanyIndexStatus>DISSOLVED</CompanyIndexStatus>
    <CompanyDate></CompanyDate>
  </CoSearchItem>
  <CoSearchItem>
    <CompanyName>TESSA TRAEGER LIMITED</CompanyName>
    <CompanyNumber>04190644</CompanyNumber>
    <DataSet>LIVE</DataSet>
    <CompanyIndexStatus></CompanyIndexStatus>
    <CompanyDate></CompanyDate>
  </CoSearchItem>
  <CoSearchItem>
    <CompanyName>TESSA WRIGHT LIMITED</CompanyName>
    <CompanyNumber>05637607</CompanyNumber>
    <DataSet>LIVE</DataSet>
    <CompanyIndexStatus></CompanyIndexStatus>
    <CompanyDate></CompanyDate>
  </CoSearchItem>
  <CoSearchItem>
    <CompanyName>TESS BARNES LIMITED</CompanyName>
    <CompanyNumber>05584186</CompanyNumber>
    <DataSet>LIVE</DataSet>
    <CompanyIndexStatus>DISSOLVED</CompanyIndexStatus>
    <CompanyDate></CompanyDate>
  </CoSearchItem>
  <CoSearchItem>
    <CompanyName>TESSBROOK PROPERTIES LIMITED</CompanyName>
    <CompanyNumber>05219192</CompanyNumber>
    <DataSet>LIVE</DataSet>
    <CompanyIndexStatus></CompanyIndexStatus>
    <CompanyDate></CompanyDate>
  </CoSearchItem>
  <CoSearchItem>
    <CompanyName>TESS BUSINESS SERVICES LIMITED</CompanyName>
    <CompanyNumber>06013227</CompanyNumber>
    <DataSet>LIVE</DataSet>
    <CompanyIndexStatus></CompanyIndexStatus>
    <CompanyDate></CompanyDate>
  </CoSearchItem>
  <CoSearchItem>
    <CompanyName>TESS CADS DESIGN SERVICES LTD</CompanyName>
    <CompanyNumber>06237270</CompanyNumber>
    <DataSet>LIVE</DataSet>
    <CompanyIndexStatus></CompanyIndexStatus>
    <CompanyDate></CompanyDate>
  </CoSearchItem>
  <CoSearchItem>
    <CompanyName>TESS CONSTRUCTION LIMITED</CompanyName>
    <CompanyNumber>00765907</CompanyNumber>
    <DataSet>LIVE</DataSet>
    <CompanyIndexStatus></CompanyIndexStatus>
    <CompanyDate></CompanyDate>
  </CoSearchItem>
  <CoSearchItem>
    <CompanyName>TESS CONSULTING</CompanyName>
    <CompanyNumber>SL005365</CompanyNumber>
    <DataSet>LIVE</DataSet>
    <CompanyIndexStatus></CompanyIndexStatus>
    <CompanyDate></CompanyDate>
  </CoSearchItem>
  <CoSearchItem>
    <CompanyName>TES (SCOTLAND) LTD.</CompanyName>
    <CompanyNumber>SC323342</CompanyNumber>
    <DataSet>LIVE</DataSet>
    <CompanyIndexStatus></CompanyIndexStatus>
    <CompanyDate></CompanyDate>
  </CoSearchItem>
  <CoSearchItem>
    <CompanyName>TESSDESIGNS LIMITED</CompanyName>
    <CompanyNumber>04066392</CompanyNumber>
    <DataSet>LIVE</DataSet>
    <CompanyIndexStatus></CompanyIndexStatus>
    <CompanyDate></CompanyDate>
  </CoSearchItem>
  <CoSearchItem>
    <CompanyName>TESS DEVELOPMENTS LIMITED</CompanyName>
    <CompanyNumber>05781127</CompanyNumber>
    <DataSet>LIVE</DataSet>
    <CompanyIndexStatus>DISSOLVED</CompanyIndexStatus>
    <CompanyDate></CompanyDate>
  </CoSearchItem>
  <CoSearchItem>
    <CompanyName>TES SECURITY LIMITED</CompanyName>
    <CompanyNumber>05136449</CompanyNumber>
    <DataSet>LIVE</DataSet>
    <CompanyIndexStatus>DISSOLVED</CompanyIndexStatus>
    <CompanyDate></CompanyDate>
  </CoSearchItem>
  <CoSearchItem>
    <CompanyName>TESSEL LIMITED</CompanyName>
    <CompanyNumber>06287240</CompanyNumber>
    <DataSet>LIVE</DataSet>
    <CompanyIndexStatus></CompanyIndexStatus>
    <CompanyDate></CompanyDate>
  </CoSearchItem>
  <CoSearchItem>
    <CompanyName>TESSELATE LTD</CompanyName>
    <CompanyNumber>05426590</CompanyNumber>
    <DataSet>LIVE</DataSet>
    <CompanyIndexStatus></CompanyIndexStatus>
    <CompanyDate></CompanyDate>
  </CoSearchItem>
  <CoSearchItem>
    <CompanyName>TESSELATED SYSTEMS LIMITED</CompanyName>
    <CompanyNumber>02150923</CompanyNumber>
    <DataSet>LIVE</DataSet>
    <CompanyIndexStatus></CompanyIndexStatus>
    <CompanyDate></CompanyDate>
  </CoSearchItem>
  <CoSearchItem>
    <CompanyName>TESSELLA PLC</CompanyName>
    <CompanyNumber>01466429</CompanyNumber>
    <DataSet>LIVE</DataSet>
    <CompanyIndexStatus></CompanyIndexStatus>
    <CompanyDate></CompanyDate>
  </CoSearchItem>
  <CoSearchItem>
    <CompanyName>TESSELLA DEVELOPMENTS LIMITED</CompanyName>
    <CompanyNumber>05236167</CompanyNumber>
    <DataSet>LIVE</DataSet>
    <CompanyIndexStatus></CompanyIndexStatus>
    <CompanyDate></CompanyDate>
  </CoSearchItem>
  <CoSearchItem>
    <CompanyName>TESSELLA SOFTWARE LIMITED</CompanyName>
    <CompanyNumber>01805702</CompanyNumber>
    <DataSet>LIVE</DataSet>
    <CompanyIndexStatus></CompanyIndexStatus>
    <CompanyDate></CompanyDate>
  </CoSearchItem>
  <CoSearchItem>
    <CompanyName>TESSELLA SUPPORT SERVICES LIMITED</CompanyName>
    <CompanyNumber>01770901</CompanyNumber>
    <DataSet>LIVE</DataSet>
    <CompanyIndexStatus></CompanyIndexStatus>
    <CompanyDate></CompanyDate>
  </CoSearchItem>
  <CoSearchItem>
    <CompanyName>TESSELLA SYSTEMS LIMITED</CompanyName>
    <CompanyNumber>01514703</CompanyNumber>
    <DataSet>LIVE</DataSet>
    <CompanyIndexStatus></CompanyIndexStatus>
    <CompanyDate></CompanyDate>
  </CoSearchItem>
  <CoSearchItem>
    <CompanyName>TESSELLATE LIMITED</CompanyName>
    <CompanyNumber>04362386</CompanyNumber>
    <DataSet>LIVE</DataSet>
    <CompanyIndexStatus>DISSOLVED</CompanyIndexStatus>
    <CompanyDate></CompanyDate>
  </CoSearchItem>
  <CoSearchItem>
    <CompanyName>TESSELLATE BUSINESS SOLUTIONS LIMITED</CompanyName>
    <CompanyNumber>04491691</CompanyNumber>
    <DataSet>LIVE</DataSet>
    <CompanyIndexStatus>DISSOLVED</CompanyIndexStatus>
    <CompanyDate></CompanyDate>
  </CoSearchItem>
  <CoSearchItem>
    <CompanyName>TESSELLATED SOLUTIONS LTD</CompanyName>
    <CompanyNumber>06756662</CompanyNumber>
    <DataSet>LIVE</DataSet>
    <CompanyIndexStatus></CompanyIndexStatus>
    <CompanyDate></CompanyDate>
  </CoSearchItem>
  <CoSearchItem>
    <CompanyName>TESSELLATIONS LIMITED</CompanyName>
    <CompanyNumber>05048426</CompanyNumber>
    <DataSet>LIVE</DataSet>
    <CompanyIndexStatus></CompanyIndexStatus>
    <CompanyDate></CompanyDate>
  </CoSearchItem>
  <CoSearchItem>
    <CompanyName>TESSENDERLO FINE CHEMICALS LIMITED</CompanyName>
    <CompanyNumber>00646784</CompanyNumber>
    <DataSet>LIVE</DataSet>
    <CompanyIndexStatus></CompanyIndexStatus>
    <CompanyDate></CompanyDate>
  </CoSearchItem>
  <CoSearchItem>
    <CompanyName>TESSENDERLO HOLDING UK LIMITED</CompanyName>
    <CompanyNumber>03514787</CompanyNumber>
    <DataSet>LIVE</DataSet>
    <CompanyIndexStatus></CompanyIndexStatus>
    <CompanyDate></CompanyDate>
  </CoSearchItem>
  <CoSearchItem>
    <CompanyName>TESSENDERLO UK LIMITED</CompanyName>
    <CompanyNumber>04244527</CompanyNumber>
    <DataSet>LIVE</DataSet>
    <CompanyIndexStatus></CompanyIndexStatus>
    <CompanyDate></CompanyDate>
  </CoSearchItem>
  <CoSearchItem>
    <CompanyName>TESSENDORF BUSINESS CONSULTING LIMITED</CompanyName>
    <CompanyNumber>04736096</CompanyNumber>
    <DataSet>LIVE</DataSet>
    <CompanyIndexStatus></CompanyIndexStatus>
    <CompanyDate></CompanyDate>
  </CoSearchItem>
  <CoSearchItem>
    <CompanyName>TESSERA LIMITED</CompanyName>
    <CompanyNumber>03752271</CompanyNumber>
    <DataSet>LIVE</DataSet>
    <CompanyIndexStatus>DISSOLVED</CompanyIndexStatus>
    <CompanyDate></CompanyDate>
  </CoSearchItem>
  <CoSearchItem>
    <CompanyName>TESSERA ASSOCIATES LIMITED</CompanyName>
    <CompanyNumber>03164128</CompanyNumber>
    <DataSet>LIVE</DataSet>
    <CompanyIndexStatus></CompanyIndexStatus>
    <CompanyDate></CompanyDate>
  </CoSearchItem>
  <CoSearchItem>
    <CompanyName>TESSERA CONSULTING LIMITED</CompanyName>
    <CompanyNumber>04162873</CompanyNumber>
    <DataSet>LIVE</DataSet>
    <CompanyIndexStatus></CompanyIndexStatus>
    <CompanyDate></CompanyDate>
  </CoSearchItem>
  <CoSearchItem>
    <CompanyName>TESSERA CREDIT SERVICES LIMITED</CompanyName>
    <CompanyNumber>02453485</CompanyNumber>
    <DataSet>LIVE</DataSet>
    <CompanyIndexStatus></CompanyIndexStatus>
    <CompanyDate></CompanyDate>
  </CoSearchItem>
  <CoSearchItem>
    <CompanyName>TESSERACT LIMITED</CompanyName>
    <CompanyNumber>02934702</CompanyNumber>
    <DataSet>LIVE</DataSet>
    <CompanyIndexStatus></CompanyIndexStatus>
    <CompanyDate></CompanyDate>
  </CoSearchItem>
  <CoSearchItem>
    <CompanyName>TESSERACT ASSET MANAGEMENT (UK) LIMITED</CompanyName>
    <CompanyNumber>05902882</CompanyNumber>
    <DataSet>LIVE</DataSet>
    <CompanyIndexStatus></CompanyIndexStatus>
    <CompanyDate></CompanyDate>
  </CoSearchItem>
  <CoSearchItem>
    <CompanyName>TESSERACT COMMUNICATIONS, INC.</CompanyName>
    <CompanyNumber>FC021862</CompanyNumber>
    <DataSet>LIVE</DataSet>
    <CompanyIndexStatus></CompanyIndexStatus>
    <CompanyDate></CompanyDate>
  </CoSearchItem>
  <CoSearchItem>
    <CompanyName>TESSERACT INC. LIMITED</CompanyName>
    <CompanyNumber>05595205</CompanyNumber>
    <DataSet>LIVE</DataSet>
    <CompanyIndexStatus></CompanyIndexStatus>
    <CompanyDate></CompanyDate>
  </CoSearchItem>
  <CoSearchItem>
    <CompanyName>TESSERACT MANAGEMENT SYSTEMS LIMITED</CompanyName>
    <CompanyNumber>03199681</CompanyNumber>
    <DataSet>LIVE</DataSet>
    <CompanyIndexStatus></CompanyIndexStatus>
    <CompanyDate></CompanyDate>
  </CoSearchItem>
  <CoSearchItem>
    <CompanyName>TESSERACTS LIMITED</CompanyName>
    <CompanyNumber>04563281</CompanyNumber>
    <DataSet>LIVE</DataSet>
    <CompanyIndexStatus></CompanyIndexStatus>
    <CompanyDate></CompanyDate>
  </CoSearchItem>
  <CoSearchItem>
    <CompanyName>TESSERAE LIMITED</CompanyName>
    <CompanyNumber>03024564</CompanyNumber>
    <DataSet>LIVE</DataSet>
    <CompanyIndexStatus></CompanyIndexStatus>
    <CompanyDate></CompanyDate>
  </CoSearchItem>
  <CoSearchItem>
    <CompanyName>TESSERAE CREATIVE LTD</CompanyName>
    <CompanyNumber>04131303</CompanyNumber>
    <DataSet>LIVE</DataSet>
    <CompanyIndexStatus></CompanyIndexStatus>
    <CompanyDate></CompanyDate>
  </CoSearchItem>
  <CoSearchItem>
    <CompanyName>TESSERAE ENVIRONMENTAL CONSULTANTS LIMITED</CompanyName>
    <CompanyNumber>05895843</CompanyNumber>
    <DataSet>LIVE</DataSet>
    <CompanyIndexStatus>STATUSR</CompanyIndexStatus>
    <CompanyDate></CompanyDate>
  </CoSearchItem>
  <CoSearchItem>
    <CompanyName>TESSERAE PARTNERS LLP</CompanyName>
    <CompanyNumber>OC321773</CompanyNumber>
    <DataSet>LIVE</DataSet>
    <CompanyIndexStatus></CompanyIndexStatus>
    <CompanyDate></CompanyDate>
  </CoSearchItem>
  <CoSearchItem>
    <CompanyName>TESSERA FASHIONS LIMITED</CompanyName>
    <CompanyNumber>06822153</CompanyNumber>
    <DataSet>LIVE</DataSet>
    <CompanyIndexStatus></CompanyIndexStatus>
    <CompanyDate></CompanyDate>
  </CoSearchItem>
  <CoSearchItem>
    <CompanyName>TESSERA GROUP PLC</CompanyName>
    <CompanyNumber>03638265</CompanyNumber>
    <DataSet>LIVE</DataSet>
    <CompanyIndexStatus></CompanyIndexStatus>
    <CompanyDate></CompanyDate>
  </CoSearchItem>
  <CoSearchItem>
    <CompanyName>TESSERA MARINE LLP</CompanyName>
    <CompanyNumber>OC315471</CompanyNumber>
    <DataSet>LIVE</DataSet>
    <CompanyIndexStatus>DISSOLVED</CompanyIndexStatus>
    <CompanyDate></CompanyDate>
  </CoSearchItem>
  <CoSearchItem>
    <CompanyName>TESSERA PORTFOLIO MANAGEMENT LIMITED</CompanyName>
    <CompanyNumber>03730080</CompanyNumber>
    <DataSet>LIVE</DataSet>
    <CompanyIndexStatus></CompanyIndexStatus>
    <CompanyDate></CompanyDate>
  </CoSearchItem>
  <CoSearchItem>
    <CompanyName>TESSERA SERVICES LTD</CompanyName>
    <CompanyNumber>04917347</CompanyNumber>
    <DataSet>LIVE</DataSet>
    <CompanyIndexStatus></CompanyIndexStatus>
    <CompanyDate></CompanyDate>
  </CoSearchItem>
  <CoSearchItem>
    <CompanyName>TESSERA SOLUTIONS LIMITED</CompanyName>
    <CompanyNumber>SC241955</CompanyNumber>
    <DataSet>LIVE</DataSet>
    <CompanyIndexStatus></CompanyIndexStatus>
    <CompanyDate></CompanyDate>
  </CoSearchItem>
  <CoSearchItem>
    <CompanyName>TESSERATION LIMITED</CompanyName>
    <CompanyNumber>04625608</CompanyNumber>
    <DataSet>LIVE</DataSet>
    <CompanyIndexStatus></CompanyIndexStatus>
    <CompanyDate></CompanyDate>
  </CoSearchItem>
  <CoSearchItem>
    <CompanyName>T.E.S. SERVICES LIMITED</CompanyName>
    <CompanyNumber>02656760</CompanyNumber>
    <DataSet>LIVE</DataSet>
    <CompanyIndexStatus></CompanyIndexStatus>
    <CompanyDate></CompanyDate>
  </CoSearchItem>
</NameSearch>
";

    }
}