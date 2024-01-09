module rec Feliz.ReactPhoneNumberInput

open Fable.Core
open Fable.Core.JsInterop
open Fable.React

type IPhoneInputProperty =
    interface end

module Interop =
    let inline mkPhoneInputAttr (key: string) (value: obj) : IPhoneInputProperty = unbox (key, value)

[<Erase>]
type Exports =
    static member inline PhoneInputWithCountry  (props: IPhoneInputProperty list) =
        Interop.reactApi.createElement(import "default" "react-phone-number-input", createObj !!props)

    static member inline PhoneInputWithoutCountry  (props: IPhoneInputProperty list) =
        Interop.reactApi.createElement(import "default" "react-phone-number-input/input", createObj !!props)

    [<Import("isPossiblePhoneNumber", "react-phone-number-input")>]
    static member inline isPossiblePhoneNumber (text: string, ?defaultCountry: CountryCode) : bool =
        jsNative

[<Erase>]
type phoneInput =

    static member inline value (value : string) =
        Interop.mkPhoneInputAttr "value" value

    static member inline onChange (func : string -> unit) =
        Interop.mkPhoneInputAttr "onChange" func

    static member inline className (className : string) =
        Interop.mkPhoneInputAttr "className" className

    static member inline country (country : CountryCode) =
        Interop.mkPhoneInputAttr "country" country

type [<StringEnum>] [<RequireQualifiedAccess>] CountryCode =
    | [<CompiledName("AC")>] AC
    | [<CompiledName("AD")>] AD
    | [<CompiledName("AE")>] AE
    | [<CompiledName("AF")>] AF
    | [<CompiledName("AG")>] AG
    | [<CompiledName("AI")>] AI
    | [<CompiledName("AL")>] AL
    | [<CompiledName("AM")>] AM
    | [<CompiledName("AO")>] AO
    | [<CompiledName("AR")>] AR
    | [<CompiledName("AS")>] AS
    | [<CompiledName("AT")>] AT
    | [<CompiledName("AU")>] AU
    | [<CompiledName("AW")>] AW
    | [<CompiledName("AX")>] AX
    | [<CompiledName("AZ")>] AZ
    | [<CompiledName("BA")>] BA
    | [<CompiledName("BB")>] BB
    | [<CompiledName("BD")>] BD
    | [<CompiledName("BE")>] BE
    | [<CompiledName("BF")>] BF
    | [<CompiledName("BG")>] BG
    | [<CompiledName("BH")>] BH
    | [<CompiledName("BI")>] BI
    | [<CompiledName("BJ")>] BJ
    | [<CompiledName("BL")>] BL
    | [<CompiledName("BM")>] BM
    | [<CompiledName("BN")>] BN
    | [<CompiledName("BO")>] BO
    | [<CompiledName("BQ")>] BQ
    | [<CompiledName("BR")>] BR
    | [<CompiledName("BS")>] BS
    | [<CompiledName("BT")>] BT
    | [<CompiledName("BW")>] BW
    | [<CompiledName("BY")>] BY
    | [<CompiledName("BZ")>] BZ
    | [<CompiledName("CA")>] CA
    | [<CompiledName("CC")>] CC
    | [<CompiledName("CD")>] CD
    | [<CompiledName("CF")>] CF
    | [<CompiledName("CG")>] CG
    | [<CompiledName("CH")>] CH
    | [<CompiledName("CI")>] CI
    | [<CompiledName("CK")>] CK
    | [<CompiledName("CL")>] CL
    | [<CompiledName("CM")>] CM
    | [<CompiledName("CN")>] CN
    | [<CompiledName("CO")>] CO
    | [<CompiledName("CR")>] CR
    | [<CompiledName("CU")>] CU
    | [<CompiledName("CV")>] CV
    | [<CompiledName("CW")>] CW
    | [<CompiledName("CX")>] CX
    | [<CompiledName("CY")>] CY
    | [<CompiledName("CZ")>] CZ
    | [<CompiledName("DE")>] DE
    | [<CompiledName("DJ")>] DJ
    | [<CompiledName("DK")>] DK
    | [<CompiledName("DM")>] DM
    | [<CompiledName("DO")>] DO
    | [<CompiledName("DZ")>] DZ
    | [<CompiledName("EC")>] EC
    | [<CompiledName("EE")>] EE
    | [<CompiledName("EG")>] EG
    | [<CompiledName("EH")>] EH
    | [<CompiledName("ER")>] ER
    | [<CompiledName("ES")>] ES
    | [<CompiledName("ET")>] ET
    | [<CompiledName("FI")>] FI
    | [<CompiledName("FJ")>] FJ
    | [<CompiledName("FK")>] FK
    | [<CompiledName("FM")>] FM
    | [<CompiledName("FO")>] FO
    | [<CompiledName("FR")>] FR
    | [<CompiledName("GA")>] GA
    | [<CompiledName("GB")>] GB
    | [<CompiledName("GD")>] GD
    | [<CompiledName("GE")>] GE
    | [<CompiledName("GF")>] GF
    | [<CompiledName("GG")>] GG
    | [<CompiledName("GH")>] GH
    | [<CompiledName("GI")>] GI
    | [<CompiledName("GL")>] GL
    | [<CompiledName("GM")>] GM
    | [<CompiledName("GN")>] GN
    | [<CompiledName("GP")>] GP
    | [<CompiledName("GQ")>] GQ
    | [<CompiledName("GR")>] GR
    | [<CompiledName("GT")>] GT
    | [<CompiledName("GU")>] GU
    | [<CompiledName("GW")>] GW
    | [<CompiledName("GY")>] GY
    | [<CompiledName("HK")>] HK
    | [<CompiledName("HN")>] HN
    | [<CompiledName("HR")>] HR
    | [<CompiledName("HT")>] HT
    | [<CompiledName("HU")>] HU
    | [<CompiledName("ID")>] ID
    | [<CompiledName("IE")>] IE
    | [<CompiledName("IL")>] IL
    | [<CompiledName("IM")>] IM
    | [<CompiledName("IN")>] IN
    | [<CompiledName("IO")>] IO
    | [<CompiledName("IQ")>] IQ
    | [<CompiledName("IR")>] IR
    | [<CompiledName("IS")>] IS
    | [<CompiledName("IT")>] IT
    | [<CompiledName("JE")>] JE
    | [<CompiledName("JM")>] JM
    | [<CompiledName("JO")>] JO
    | [<CompiledName("JP")>] JP
    | [<CompiledName("KE")>] KE
    | [<CompiledName("KG")>] KG
    | [<CompiledName("KH")>] KH
    | [<CompiledName("KI")>] KI
    | [<CompiledName("KM")>] KM
    | [<CompiledName("KN")>] KN
    | [<CompiledName("KP")>] KP
    | [<CompiledName("KR")>] KR
    | [<CompiledName("KW")>] KW
    | [<CompiledName("KY")>] KY
    | [<CompiledName("KZ")>] KZ
    | [<CompiledName("LA")>] LA
    | [<CompiledName("LB")>] LB
    | [<CompiledName("LC")>] LC
    | [<CompiledName("LI")>] LI
    | [<CompiledName("LK")>] LK
    | [<CompiledName("LR")>] LR
    | [<CompiledName("LS")>] LS
    | [<CompiledName("LT")>] LT
    | [<CompiledName("LU")>] LU
    | [<CompiledName("LV")>] LV
    | [<CompiledName("LY")>] LY
    | [<CompiledName("MA")>] MA
    | [<CompiledName("MC")>] MC
    | [<CompiledName("MD")>] MD
    | [<CompiledName("ME")>] ME
    | [<CompiledName("MF")>] MF
    | [<CompiledName("MG")>] MG
    | [<CompiledName("MH")>] MH
    | [<CompiledName("MK")>] MK
    | [<CompiledName("ML")>] ML
    | [<CompiledName("MM")>] MM
    | [<CompiledName("MN")>] MN
    | [<CompiledName("MO")>] MO
    | [<CompiledName("MP")>] MP
    | [<CompiledName("MQ")>] MQ
    | [<CompiledName("MR")>] MR
    | [<CompiledName("MS")>] MS
    | [<CompiledName("MT")>] MT
    | [<CompiledName("MU")>] MU
    | [<CompiledName("MV")>] MV
    | [<CompiledName("MW")>] MW
    | [<CompiledName("MX")>] MX
    | [<CompiledName("MY")>] MY
    | [<CompiledName("MZ")>] MZ
    | [<CompiledName("NA")>] NA
    | [<CompiledName("NC")>] NC
    | [<CompiledName("NE")>] NE
    | [<CompiledName("NF")>] NF
    | [<CompiledName("NG")>] NG
    | [<CompiledName("NI")>] NI
    | [<CompiledName("NL")>] NL
    | [<CompiledName("NO")>] NO
    | [<CompiledName("NP")>] NP
    | [<CompiledName("NR")>] NR
    | [<CompiledName("NU")>] NU
    | [<CompiledName("NZ")>] NZ
    | [<CompiledName("OM")>] OM
    | [<CompiledName("PA")>] PA
    | [<CompiledName("PE")>] PE
    | [<CompiledName("PF")>] PF
    | [<CompiledName("PG")>] PG
    | [<CompiledName("PH")>] PH
    | [<CompiledName("PK")>] PK
    | [<CompiledName("PL")>] PL
    | [<CompiledName("PM")>] PM
    | [<CompiledName("PR")>] PR
    | [<CompiledName("PS")>] PS
    | [<CompiledName("PT")>] PT
    | [<CompiledName("PW")>] PW
    | [<CompiledName("PY")>] PY
    | [<CompiledName("QA")>] QA
    | [<CompiledName("RE")>] RE
    | [<CompiledName("RO")>] RO
    | [<CompiledName("RS")>] RS
    | [<CompiledName("RU")>] RU
    | [<CompiledName("RW")>] RW
    | [<CompiledName("SA")>] SA
    | [<CompiledName("SB")>] SB
    | [<CompiledName("SC")>] SC
    | [<CompiledName("SD")>] SD
    | [<CompiledName("SE")>] SE
    | [<CompiledName("SG")>] SG
    | [<CompiledName("SH")>] SH
    | [<CompiledName("SI")>] SI
    | [<CompiledName("SJ")>] SJ
    | [<CompiledName("SK")>] SK
    | [<CompiledName("SL")>] SL
    | [<CompiledName("SM")>] SM
    | [<CompiledName("SN")>] SN
    | [<CompiledName("SO")>] SO
    | [<CompiledName("SR")>] SR
    | [<CompiledName("SS")>] SS
    | [<CompiledName("ST")>] ST
    | [<CompiledName("SV")>] SV
    | [<CompiledName("SX")>] SX
    | [<CompiledName("SY")>] SY
    | [<CompiledName("SZ")>] SZ
    | [<CompiledName("TA")>] TA
    | [<CompiledName("TC")>] TC
    | [<CompiledName("TD")>] TD
    | [<CompiledName("TG")>] TG
    | [<CompiledName("TH")>] TH
    | [<CompiledName("TJ")>] TJ
    | [<CompiledName("TK")>] TK
    | [<CompiledName("TL")>] TL
    | [<CompiledName("TM")>] TM
    | [<CompiledName("TN")>] TN
    | [<CompiledName("TO")>] TO
    | [<CompiledName("TR")>] TR
    | [<CompiledName("TT")>] TT
    | [<CompiledName("TV")>] TV
    | [<CompiledName("TW")>] TW
    | [<CompiledName("TZ")>] TZ
    | [<CompiledName("UA")>] UA
    | [<CompiledName("UG")>] UG
    | [<CompiledName("US")>] US
    | [<CompiledName("UY")>] UY
    | [<CompiledName("UZ")>] UZ
    | [<CompiledName("VA")>] VA
    | [<CompiledName("VC")>] VC
    | [<CompiledName("VE")>] VE
    | [<CompiledName("VG")>] VG
    | [<CompiledName("VI")>] VI
    | [<CompiledName("VN")>] VN
    | [<CompiledName("VU")>] VU
    | [<CompiledName("WF")>] WF
    | [<CompiledName("WS")>] WS
    | [<CompiledName("XK")>] XK
    | [<CompiledName("YE")>] YE
    | [<CompiledName("YT")>] YT
    | [<CompiledName("ZA")>] ZA
    | [<CompiledName("ZM")>] ZM
    | [<CompiledName("ZW")>] ZW
