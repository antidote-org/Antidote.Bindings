module rec Luxon

open System
open Fable.Core

//////////////////////////////////////////////////////
// IMPORTANT: This is a partial binding.
//////////////////////////////////////////////////////

#nowarn "3390" // disable warnings for invalid XML comments
#nowarn "0044" // disable warnings for `Obsolete` usage


let [<Import("VERSION","luxon")>] VERSION: string = jsNative


[<Import("*","luxon")>]
let luxon : IExports = jsNative

[<Import("Duration", "luxon")>]
let duration : Duration.DurationStatic = jsNative

[<Import("Interval", "luxon")>]
let interval : Interval.IntervalStatic = jsNative

[<Erase>]
type KeyOf<'T> = Key of string

type [<AllowNullLiteral>] IExports =
    /// <summary>
    /// A DateTime is an immutable data structure representing a specific date and time and accompanying methods.
    /// It contains class and instance methods for creating, parsing, interrogating, transforming, and formatting them.
    ///
    /// A DateTime comprises of:
    /// * A timestamp. Each DateTime instance refers to a specific millisecond of the Unix epoch.
    /// * A time zone. Each instance is considered in the context of a specific zone (by default the local system's zone).
    /// * Configuration properties that effect how output strings are formatted, such as <c>locale</c>, <c>numberingSystem</c>, and <c>outputCalendar</c>.
    ///
    /// Here is a brief overview of the most commonly used functionality it provides:
    ///
    /// * **Creation**: To create a DateTime from its components, use one of its factory class methods: <see cref="DateTime.local" />, <see cref="DateTime.utc" />, and (most flexibly) <see cref="DateTime.fromObject" />.
    /// To create one from a standard string format, use <see cref="DateTime.fromISO" />, <see cref="DateTime.fromHTTP" />, and <see cref="DateTime.fromRFC2822" />.
    /// To create one from a custom string format, use <see cref="DateTime.fromFormat" />. To create one from a native JS date, use <see cref="DateTime.fromJSDate" />.
    /// * **Gregorian calendar and time**: To examine the Gregorian properties of a DateTime individually (i.e as opposed to collectively through <see cref="DateTime.toObject" />), use the <see cref="DateTime.year" />,
    /// <see cref="DateTime.month" />, <see cref="DateTime.day" />, <see cref="DateTime.hour" />, <see cref="DateTime.minute" />, <see cref="DateTime.second" />, <see cref="DateTime.millisecond" /> accessors.
    /// * **Week calendar**: For ISO week calendar attributes, see the <see cref="DateTime.weekYear" />, <see cref="DateTime.weekNumber" />, and <see cref="DateTime.weekday" /> accessors.
    /// * **Configuration** See the <see cref="DateTime.locale" /> and <see cref="DateTime.numberingSystem" /> accessors.
    /// * **Transformation**: To transform the DateTime into other DateTimes, use <see cref="DateTime.set" />, <see cref="DateTime.reconfigure" />, <see cref="DateTime.setZone" />, <see cref="DateTime.setLocale" />,
    /// <see cref="DateTime.plus" />, <see cref="DateTime.minus" />, <see cref="DateTime.endOf" />, <see cref="DateTime.startOf" />, <see cref="DateTime.toUTC" />, and <see cref="DateTime.toLocal" />.
    /// * **Output**: To convert the DateTime to other representations, use the <see cref="DateTime.toRelative" />, <see cref="DateTime.toRelativeCalendar" />, <see cref="DateTime.toJSON" />, <see cref="DateTime.toISO" />,
    /// <see cref="DateTime.toHTTP" />, <see cref="DateTime.toObject" />, <see cref="DateTime.toRFC2822" />, <see cref="DateTime.toString" />, <see cref="DateTime.toLocaleString" />, <see cref="DateTime.toFormat" />,
    /// <see cref="DateTime.toMillis" /> and <see cref="DateTime.toJSDate" />.
    ///
    /// There's plenty others documented below. In addition, for more information on subtler topics
    /// like internationalization, time zones, alternative calendars, validity, and so on, see the external documentation.
    /// </summary>
    abstract DateTime: DateTimeStatic

/// <summary>
/// A DateTime is an immutable data structure representing a specific date and time and accompanying methods.
/// It contains class and instance methods for creating, parsing, interrogating, transforming, and formatting them.
///
/// A DateTime comprises of:
/// * A timestamp. Each DateTime instance refers to a specific millisecond of the Unix epoch.
/// * A time zone. Each instance is considered in the context of a specific zone (by default the local system's zone).
/// * Configuration properties that effect how output strings are formatted, such as <c>locale</c>, <c>numberingSystem</c>, and <c>outputCalendar</c>.
///
/// Here is a brief overview of the most commonly used functionality it provides:
///
/// * **Creation**: To create a DateTime from its components, use one of its factory class methods: <see cref="DateTime.local" />, <see cref="DateTime.utc" />, and (most flexibly) <see cref="DateTime.fromObject" />.
/// To create one from a standard string format, use <see cref="DateTime.fromISO" />, <see cref="DateTime.fromHTTP" />, and <see cref="DateTime.fromRFC2822" />.
/// To create one from a custom string format, use <see cref="DateTime.fromFormat" />. To create one from a native JS date, use <see cref="DateTime.fromJSDate" />.
/// * **Gregorian calendar and time**: To examine the Gregorian properties of a DateTime individually (i.e as opposed to collectively through <see cref="DateTime.toObject" />), use the <see cref="DateTime.year" />,
/// <see cref="DateTime.month" />, <see cref="DateTime.day" />, <see cref="DateTime.hour" />, <see cref="DateTime.minute" />, <see cref="DateTime.second" />, <see cref="DateTime.millisecond" /> accessors.
/// * **Week calendar**: For ISO week calendar attributes, see the <see cref="DateTime.weekYear" />, <see cref="DateTime.weekNumber" />, and <see cref="DateTime.weekday" /> accessors.
/// * **Configuration** See the <see cref="DateTime.locale" /> and <see cref="DateTime.numberingSystem" /> accessors.
/// * **Transformation**: To transform the DateTime into other DateTimes, use <see cref="DateTime.set" />, <see cref="DateTime.reconfigure" />, <see cref="DateTime.setZone" />, <see cref="DateTime.setLocale" />,
/// <see cref="DateTime.plus" />, <see cref="DateTime.minus" />, <see cref="DateTime.endOf" />, <see cref="DateTime.startOf" />, <see cref="DateTime.toUTC" />, and <see cref="DateTime.toLocal" />.
/// * **Output**: To convert the DateTime to other representations, use the <see cref="DateTime.toRelative" />, <see cref="DateTime.toRelativeCalendar" />, <see cref="DateTime.toJSON" />, <see cref="DateTime.toISO" />,
/// <see cref="DateTime.toHTTP" />, <see cref="DateTime.toObject" />, <see cref="DateTime.toRFC2822" />, <see cref="DateTime.toString" />, <see cref="DateTime.toLocaleString" />, <see cref="DateTime.toFormat" />,
/// <see cref="DateTime.toMillis" /> and <see cref="DateTime.toJSDate" />.
///
/// There's plenty others documented below. In addition, for more information on subtler topics
/// like internationalization, time zones, alternative calendars, validity, and so on, see the external documentation.
/// </summary>
type [<AllowNullLiteral>] DateTime =
    /// <summary>Get the value of unit.</summary>
    /// <param name="unit">a unit such as 'minute' or 'day'</param>
    /// <example>DateTime.local(2017, 7, 4).get('month'); //=&gt; 7</example>
    /// <example>DateTime.local(2017, 7, 4).get('day'); //=&gt; 4</example>
    abstract get: unit: KeyOf<DateTime> -> float
    /// Returns whether the DateTime is valid. Invalid DateTimes occur when:
    /// * The DateTime was created from invalid calendar information, such as the 13th month or February 30
    /// * The DateTime was created by an operation on another invalid date
    abstract isValid: bool
    /// Returns an error code if this DateTime is invalid, or null if the DateTime is valid
    abstract invalidReason: string option
    /// Returns an explanation of why this DateTime became invalid, or null if the DateTime is valid
    abstract invalidExplanation: string option
    /// Get the locale of a DateTime, such 'en-GB'. The locale is used when formatting the DateTime
    abstract locale: string
    /// Get the numbering system of a DateTime, such 'beng'. The numbering system is used when formatting the DateTime
    abstract numberingSystem: string
    /// Get the output calendar of a DateTime, such 'islamic'. The output calendar is used when formatting the DateTime
    abstract outputCalendar: string
    /// Get the time zone associated with this DateTime.
    abstract zone: Zone
    /// Get the name of the time zone.
    abstract zoneName: string
    /// <summary>Get the year</summary>
    /// <example>DateTime.local(2017, 5, 25).year //=&gt; 2017</example>
    abstract year: float
    /// <summary>Get the quarter</summary>
    /// <example>DateTime.local(2017, 5, 25).quarter //=&gt; 2</example>
    abstract quarter: QuarterNumbers
    /// <summary>Get the month (1-12).</summary>
    /// <example>DateTime.local(2017, 5, 25).month //=&gt; 5</example>
    abstract month: MonthNumbers
    /// <summary>Get the day of the month (1-30ish).</summary>
    /// <example>DateTime.local(2017, 5, 25).day //=&gt; 25</example>
    abstract day: DayNumbers
    /// <summary>Get the hour of the day (0-23).</summary>
    /// <example>DateTime.local(2017, 5, 25, 9).hour //=&gt; 9</example>
    abstract hour: HourNumbers
    /// <summary>Get the minute of the hour (0-59).</summary>
    /// <example>DateTime.local(2017, 5, 25, 9, 30).minute //=&gt; 30</example>
    abstract minute: MinuteNumbers
    /// <summary>Get the second of the minute (0-59).</summary>
    /// <example>DateTime.local(2017, 5, 25, 9, 30, 52).second //=&gt; 52</example>
    abstract second: SecondNumbers
    /// <summary>Get the millisecond of the second (0-999).</summary>
    /// <example>DateTime.local(2017, 5, 25, 9, 30, 52, 654).millisecond //=&gt; 654</example>
    abstract millisecond: float
    /// <summary>Get the week year</summary>
    /// <seealso href="https://en.wikipedia.org/wiki/ISO_week_date" />
    /// <example>DateTime.local(2014, 12, 31).weekYear //=&gt; 2015</example>
    abstract weekYear: float
    /// <summary>Get the week number of the week year (1-52ish).</summary>
    /// <seealso href="https://en.wikipedia.org/wiki/ISO_week_date" />
    /// <example>DateTime.local(2017, 5, 25).weekNumber //=&gt; 21</example>
    abstract weekNumber: WeekNumbers
    /// <summary>
    /// Get the day of the week.
    /// 1 is Monday and 7 is Sunday
    /// </summary>
    /// <seealso href="https://en.wikipedia.org/wiki/ISO_week_date" />
    /// <example>DateTime.local(2014, 11, 31).weekday //=&gt; 4</example>
    abstract weekday: WeekdayNumbers
    /// <summary>Get the ordinal (meaning the day of the year)</summary>
    /// <example>DateTime.local(2017, 5, 25).ordinal //=&gt; 145</example>
    abstract ordinal: float
    /// <summary>
    /// Get the human readable short month name, such as 'Oct'.
    /// Defaults to the system's locale if no locale has been specified
    /// </summary>
    /// <example>DateTime.local(2017, 10, 30).monthShort //=&gt; Oct</example>
    abstract monthShort: string
    /// <summary>
    /// Get the human readable long month name, such as 'October'.
    /// Defaults to the system's locale if no locale has been specified
    /// </summary>
    /// <example>DateTime.local(2017, 10, 30).monthLong //=&gt; October</example>
    abstract monthLong: string
    /// <summary>
    /// Get the human readable short weekday, such as 'Mon'.
    /// Defaults to the system's locale if no locale has been specified
    /// </summary>
    /// <example>DateTime.local(2017, 10, 30).weekdayShort //=&gt; Mon</example>
    abstract weekdayShort: string
    /// <summary>
    /// Get the human readable long weekday, such as 'Monday'.
    /// Defaults to the system's locale if no locale has been specified
    /// </summary>
    /// <example>DateTime.local(2017, 10, 30).weekdayLong //=&gt; Monday</example>
    abstract weekdayLong: string
    /// <summary>Get the UTC offset of this DateTime in minutes</summary>
    /// <example>DateTime.now().offset //=&gt; -240</example>
    /// <example>DateTime.utc().offset //=&gt; 0</example>
    abstract offset: float
    /// Get the short human name for the zone's current offset, for example "EST" or "EDT".
    /// Defaults to the system's locale if no locale has been specified
    abstract offsetNameShort: string
    /// Get the long human name for the zone's current offset, for example "Eastern Standard Time" or "Eastern Daylight Time".
    /// Defaults to the system's locale if no locale has been specified
    abstract offsetNameLong: string
    /// Get whether this zone's offset ever changes, as in a DST.
    abstract isOffsetFixed: bool
    /// Get whether the DateTime is in a DST.
    abstract isInDST: bool
    /// <summary>Returns true if this DateTime is in a leap year, false otherwise</summary>
    /// <example>DateTime.local(2016).isInLeapYear //=&gt; true</example>
    /// <example>DateTime.local(2013).isInLeapYear //=&gt; false</example>
    abstract isInLeapYear: bool
    /// <summary>Returns the number of days in this DateTime's month</summary>
    /// <example>DateTime.local(2016, 2).daysInMonth //=&gt; 29</example>
    /// <example>DateTime.local(2016, 3).daysInMonth //=&gt; 31</example>
    abstract daysInMonth: PossibleDaysInMonth
    /// <summary>Returns the number of days in this DateTime's year</summary>
    /// <example>DateTime.local(2016).daysInYear //=&gt; 366</example>
    /// <example>DateTime.local(2013).daysInYear //=&gt; 365</example>
    abstract daysInYear: PossibleDaysInYear
    /// <summary>Returns the number of weeks in this DateTime's year</summary>
    /// <seealso href="https://en.wikipedia.org/wiki/ISO_week_date" />
    /// <example>DateTime.local(2004).weeksInWeekYear //=&gt; 53</example>
    /// <example>DateTime.local(2013).weeksInWeekYear //=&gt; 52</example>
    abstract weeksInWeekYear: PossibleWeeksInYear
    /// <summary>
    /// Returns the resolved Intl options for this DateTime.
    /// This is useful in understanding the behavior of formatting methods
    /// </summary>
    /// <param name="opts">the same options as toLocaleString</param>
    abstract resolvedLocaleOptions: ?opts: U2<LocaleOptions, DateTimeFormatOptions> -> ResolvedLocaleOptions
    /// <summary>
    /// "Set" the DateTime's zone to UTC. Returns a newly-constructed DateTime.
    ///
    /// Equivalent to <see cref="DateTime.setZone" />('utc')
    /// </summary>
    /// <param name="offset">optionally, an offset from UTC in minutes. Defaults to 0.</param>
    /// <param name="opts">options to pass to <c>setZone()</c>. Defaults to {}.</param>
    abstract toUTC: ?offset: float * ?opts: ZoneOptions -> DateTime
    /// <summary>
    /// "Set" the DateTime's zone to the host's local zone. Returns a newly-constructed DateTime.
    ///
    /// Equivalent to <c>setZone('local')</c>
    /// </summary>
    abstract toLocal: unit -> DateTime
    /// <summary>
    /// "Set" the DateTime's zone to specified zone. Returns a newly-constructed DateTime.
    ///
    /// By default, the setter keeps the underlying time the same (as in, the same timestamp), but the new instance will report different local times and consider DSTs when making computations,
    /// as with <see cref="DateTime.plus" />. You may wish to use <see cref="DateTime.toLocal" /> and <see cref="DateTime.toUTC" /> which provide simple convenience wrappers for commonly used zones.
    /// </summary>
    /// <param name="zone">
    /// a zone identifier. As a string, that can be any IANA zone supported by the host environment, or a fixed-offset name of the form 'UTC+3', or the strings 'local' or 'utc'.
    /// You may also supply an instance of a <see cref="DateTime.Zone" /> class. Defaults to 'local'.
    /// </param>
    /// <param name="opts">options</param>
    /// <param name="opts.keepLocalTime">If true, adjust the underlying time so that the local time stays the same, but in the target zone. You should rarely need this. Defaults to false.</param>
    abstract setZone: ?zone: U2<string, Zone> * ?opts: ZoneOptions -> DateTime
    /// <summary>"Set" the locale, numberingSystem, or outputCalendar. Returns a newly-constructed DateTime.</summary>
    /// <param name="properties">the properties to set</param>
    /// <example>DateTime.local(2017, 5, 25).reconfigure({ locale: 'en-GB' })</example>
    abstract reconfigure: properties: LocaleOptions -> DateTime
    /// <summary>
    /// "Set" the locale. Returns a newly-constructed DateTime.
    /// Just a convenient alias for reconfigure({ locale })
    /// </summary>
    /// <example>DateTime.local(2017, 5, 25).setLocale('en-GB')</example>
    abstract setLocale: locale: string -> DateTime
    /// <summary>
    /// "Set" the values of specified units. Returns a newly-constructed DateTime.
    /// You can only set units with this method; for "setting" metadata, see <see cref="DateTime.reconfigure" /> and <see cref="DateTime.setZone" />.
    /// </summary>
    /// <param name="values">a mapping of units to numbers</param>
    /// <example>dt.set({ year: 2017 })</example>
    /// <example>dt.set({ hour: 8, minute: 30 })</example>
    /// <example>dt.set({ weekday: 5 })</example>
    /// <example>dt.set({ year: 2005, ordinal: 234 })</example>
    abstract set: values: DateObjectUnits -> DateTime
    /// <summary>
    /// Adding hours, minutes, seconds, or milliseconds increases the timestamp by the right number of milliseconds. Adding days, months, or years shifts the calendar,
    /// accounting for DSTs and leap years along the way. Thus, <c>dt.plus({ hours: 24 })</c> may result in a different time than <c>dt.plus({ days: 1 })</c> if there's a DST shift in between.
    /// </summary>
    /// <param name="duration">The amount to add. Either a Luxon Duration, a number of milliseconds, the object argument to Duration.fromObject()</param>
    /// <example>DateTime.now().plus(123) //~&gt; in 123 milliseconds</example>
    /// <example>DateTime.now().plus({ minutes: 15 }) //~&gt; in 15 minutes</example>
    /// <example>DateTime.now().plus({ days: 1 }) //~&gt; this time tomorrow</example>
    /// <example>DateTime.now().plus({ days: -1 }) //~&gt; this time yesterday</example>
    /// <example>DateTime.now().plus({ hours: 3, minutes: 13 }) //~&gt; in 3 hr, 13 min</example>
    /// <example>DateTime.now().plus(Duration.fromObject({ hours: 3, minutes: 13 })) //~&gt; in 3 hr, 13 min</example>
    abstract plus: duration: DurationLike -> DateTime
    /// <summary>See <see cref="DateTime.plus" /></summary>
    /// <param name="duration">The amount to subtract. Either a Luxon Duration, a number of milliseconds, the object argument to Duration.fromObject()</param>
    abstract minus: duration: DurationLike -> DateTime
    /// <summary>"Set" this DateTime to the beginning of a unit of time.</summary>
    /// <param name="unit">The unit to go to the beginning of. Can be 'year', 'quarter', 'month', 'week', 'day', 'hour', 'minute', 'second', or 'millisecond'.</param>
    /// <example>DateTime.local(2014, 3, 3).startOf('month').toISODate(); //=&gt; '2014-03-01'</example>
    /// <example>DateTime.local(2014, 3, 3).startOf('year').toISODate(); //=&gt; '2014-01-01'</example>
    /// <example>DateTime.local(2014, 3, 3).startOf('week').toISODate(); //=&gt; '2014-03-03', weeks always start on Mondays</example>
    /// <example>DateTime.local(2014, 3, 3, 5, 30).startOf('day').toISOTime(); //=&gt; '00:00.000-05:00'</example>
    /// <example>DateTime.local(2014, 3, 3, 5, 30).startOf('hour').toISOTime(); //=&gt; '05:00:00.000-05:00'</example>
    abstract startOf: unit: DateTimeUnit -> DateTime
    /// <summary>"Set" this DateTime to the end (meaning the last millisecond) of a unit of time</summary>
    /// <param name="unit">The unit to go to the end of. Can be 'year', 'quarter', 'month', 'week', 'day', 'hour', 'minute', 'second', or 'millisecond'.</param>
    /// <example>DateTime.local(2014, 3, 3).endOf('month').toISO(); //=&gt; '2014-03-31T23:59:59.999-05:00'</example>
    /// <example>DateTime.local(2014, 3, 3).endOf('year').toISO(); //=&gt; '2014-12-31T23:59:59.999-05:00'</example>
    /// <example>DateTime.local(2014, 3, 3).endOf('week').toISO(); // =&gt; '2014-03-09T23:59:59.999-05:00', weeks start on Mondays</example>
    /// <example>DateTime.local(2014, 3, 3, 5, 30).endOf('day').toISO(); //=&gt; '2014-03-03T23:59:59.999-05:00'</example>
    /// <example>DateTime.local(2014, 3, 3, 5, 30).endOf('hour').toISO(); //=&gt; '2014-03-03T05:59:59.999-05:00'</example>
    abstract endOf: unit: DateTimeUnit -> DateTime
    /// <summary>
    /// Returns a string representation of this DateTime formatted according to the specified format string.
    /// **You may not want this.** See <see cref="DateTime.toLocaleString" /> for a more flexible formatting tool. For a table of tokens and their interpretations,
    /// see <see href="https://moment.github.io/luxon/#/formatting?id=table-of-tokens">here</see>.
    /// Defaults to en-US if no locale has been specified, regardless of the system's locale.
    /// </summary>
    /// <param name="fmt">the format string</param>
    /// <param name="opts">opts to override the configuration options on this DateTime</param>
    /// <example>DateTime.now().toFormat('yyyy LLL dd') //=&gt; '2017 Apr 22'</example>
    /// <example>DateTime.now().setLocale('fr').toFormat('yyyy LLL dd') //=&gt; '2017 avr. 22'</example>
    /// <example>DateTime.now().toFormat('yyyy LLL dd', { locale: "fr" }) //=&gt; '2017 avr. 22'</example>
    /// <example>DateTime.now().toFormat("HH 'hours and' mm 'minutes'") //=&gt; '20 hours and 55 minutes'</example>
    abstract toFormat: fmt: string * ?opts: LocaleOptions -> string
    /// <summary>
    /// Returns a localized string representing this date. Accepts the same options as the Intl.DateTimeFormat constructor and any presets defined by Luxon,
    /// such as <c>DateTime.DATE_FULL</c> or <c>DateTime.TIME_SIMPLE</c> of the DateTime in the assigned locale.
    /// Defaults to the system's locale if no locale has been specified
    /// </summary>
    /// <seealso href="https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/DateTimeFormat" />
    /// <param name="formatOpts">Intl.DateTimeFormat constructor options and configuration options</param>
    /// <param name="opts">opts to override the configuration options on this DateTime</param>
    /// <example>DateTime.now().toLocaleString(); //=&gt; 4/20/2017</example>
    /// <example>DateTime.now().setLocale('en-gb').toLocaleString(); //=&gt; '20/04/2017'</example>
    /// <example>DateTime.now().toLocaleString({ locale: 'en-gb' }); //=&gt; '20/04/2017'</example>
    /// <example>DateTime.now().toLocaleString(DateTime.DATE_FULL); //=&gt; 'April 20, 2017'</example>
    /// <example>DateTime.now().toLocaleString(DateTime.TIME_SIMPLE); //=&gt; '11:32 AM'</example>
    /// <example>DateTime.now().toLocaleString(DateTime.DATETIME_SHORT); //=&gt; '4/20/2017, 11:32 AM'</example>
    /// <example>DateTime.now().toLocaleString({ weekday: 'long', month: 'long', day: '2-digit' }); //=&gt; 'Thursday, April 20'</example>
    /// <example>DateTime.now().toLocaleString({ weekday: 'short', month: 'short', day: '2-digit', hour: '2-digit', minute: '2-digit' }); //=&gt; 'Thu, Apr 20, 11:27 AM'</example>
    /// <example>DateTime.now().toLocaleString({ hour: '2-digit', minute: '2-digit', hourCycle: 'h23' }); //=&gt; '11:32'</example>
    abstract toLocaleString: ?formatOpts: DateTimeFormatOptions * ?opts: LocaleOptions -> string
    /// <summary>
    /// Returns an array of format "parts", meaning individual tokens along with metadata. This is allows callers to post-process individual sections of the formatted output.
    /// Defaults to the system's locale if no locale has been specified
    /// </summary>
    /// <seealso href="https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/DateTimeFormat/formatToParts" />
    /// <param name="opts">Intl.DateTimeFormat constructor options, same as <c>toLocaleString</c>.</param>
    /// <example>
    /// DateTime.now().toLocaleParts(); //=&gt; [
    ///                                 //=&gt;   { type: 'day', value: '25' },
    ///                                 //=&gt;   { type: 'literal', value: '/' },
    ///                                 //=&gt;   { type: 'month', value: '05' },
    ///                                 //=&gt;   { type: 'literal', value: '/' },
    ///                                 //=&gt;   { type: 'year', value: '1982' }
    ///                                 //=&gt; ]
    /// </example>
    abstract toLocaleParts: ?opts: DateTimeFormatOptions -> ResizeArray<Intl.DateTimeFormatPart>
    /// <summary>Returns an ISO 8601-compliant string representation of this DateTime</summary>
    /// <param name="opts">options</param>
    /// <param name="opts.suppressMilliseconds">exclude milliseconds from the format if they're 0. Defaults to false.</param>
    /// <param name="opts.suppressSeconds">exclude seconds from the format if they're 0. Defaults to false.</param>
    /// <param name="opts.includeOffset">include the offset, such as 'Z' or '-04:00'. Defaults to true.</param>
    /// <param name="opts.format">choose between the basic and extended format. Defaults to 'extended'.</param>
    /// <example>DateTime.utc(1982, 5, 25).toISO() //=&gt; '1982-05-25T00:00:00.000Z'</example>
    /// <example>DateTime.now().toISO() //=&gt; '2017-04-22T20:47:05.335-04:00'</example>
    /// <example>DateTime.now().toISO({ includeOffset: false }) //=&gt; '2017-04-22T20:47:05.335'</example>
    /// <example>DateTime.now().toISO({ format: 'basic' }) //=&gt; '20170422T204705.335-0400'</example>
    abstract toISO: ?opts: ToISOTimeOptions -> string
    /// <summary>Returns an ISO 8601-compliant string representation of this DateTime's date component</summary>
    /// <param name="opts">options</param>
    /// <param name="opts.format">choose between the basic and extended format. Defaults to 'extended'.</param>
    /// <example>DateTime.utc(1982, 5, 25).toISODate() //=&gt; '1982-05-25'</example>
    /// <example>DateTime.utc(1982, 5, 25).toISODate({ format: 'basic' }) //=&gt; '19820525'</example>
    abstract toISODate: ?opts: ToISODateOptions -> string
    /// <summary>Returns an ISO 8601-compliant string representation of this DateTime's week date</summary>
    /// <example>DateTime.utc(1982, 5, 25).toISOWeekDate() //=&gt; '1982-W21-2'</example>
    abstract toISOWeekDate: unit -> string
    /// <summary>Returns an ISO 8601-compliant string representation of this DateTime's time component</summary>
    /// <param name="opts">options</param>
    /// <param name="opts.suppressMilliseconds">exclude milliseconds from the format if they're 0. Defaults to false.</param>
    /// <param name="opts.suppressSeconds">exclude seconds from the format if they're 0. Defaults to false.</param>
    /// <param name="opts.includeOffset">include the offset, such as 'Z' or '-04:00'. Defaults to true.</param>
    /// <param name="opts.includePrefix">include the <c>T</c> prefix. Defaults to false.</param>
    /// <param name="opts.format">choose between the basic and extended format. Defaults to 'extended'.</param>
    /// <example>DateTime.utc().set({ hour: 7, minute: 34 }).toISOTime() //=&gt; '07:34:19.361Z'</example>
    /// <example>DateTime.utc().set({ hour: 7, minute: 34, seconds: 0, milliseconds: 0 }).toISOTime({ suppressSeconds: true }) //=&gt; '07:34Z'</example>
    /// <example>DateTime.utc().set({ hour: 7, minute: 34 }).toISOTime({ format: 'basic' }) //=&gt; '073419.361Z'</example>
    /// <example>DateTime.utc().set({ hour: 7, minute: 34 }).toISOTime({ includePrefix: true }) //=&gt; 'T07:34:19.361Z'</example>
    abstract toISOTime: ?ops: ToISOTimeOptions -> string
    /// <summary>Returns an RFC 2822-compatible string representation of this DateTime, always in UTC</summary>
    /// <example>DateTime.utc(2014, 7, 13).toRFC2822() //=&gt; 'Sun, 13 Jul 2014 00:00:00 +0000'</example>
    /// <example>DateTime.local(2014, 7, 13).toRFC2822() //=&gt; 'Sun, 13 Jul 2014 00:00:00 -0400'</example>
    abstract toRFC2822: unit -> string
    /// <summary>
    /// Returns a string representation of this DateTime appropriate for use in HTTP headers.
    /// Specifically, the string conforms to RFC 1123.
    /// </summary>
    /// <seealso href="https://www.w3.org/Protocols/rfc2616/rfc2616-sec3.html#sec3.3.1" />
    /// <example>DateTime.utc(2014, 7, 13).toHTTP() //=&gt; 'Sun, 13 Jul 2014 00:00:00 GMT'</example>
    /// <example>DateTime.utc(2014, 7, 13, 19).toHTTP() //=&gt; 'Sun, 13 Jul 2014 19:00:00 GMT'</example>
    abstract toHTTP: unit -> string
    /// <summary>Returns a string representation of this DateTime appropriate for use in SQL Date</summary>
    /// <example>DateTime.utc(2014, 7, 13).toSQLDate() //=&gt; '2014-07-13'</example>
    abstract toSQLDate: unit -> string
    /// <summary>Returns a string representation of this DateTime appropriate for use in SQL Time</summary>
    /// <param name="opts">options</param>
    /// <param name="opts.includeZone">include the zone, such as 'America/New_York'. Overrides includeOffset. Defaults to false.</param>
    /// <param name="opts.includeOffset">include the offset, such as 'Z' or '-04:00'. Defaults to true.</param>
    /// <example>DateTime.utc().toSQL() //=&gt; '05:15:16.345'</example>
    /// <example>DateTime.now().toSQL() //=&gt; '05:15:16.345 -04:00'</example>
    /// <example>DateTime.now().toSQL({ includeOffset: false }) //=&gt; '05:15:16.345'</example>
    /// <example>DateTime.now().toSQL({ includeZone: false }) //=&gt; '05:15:16.345 America/New_York'</example>
    abstract toSQLTime: ?opts: ToSQLOptions -> string
    /// <summary>Returns a string representation of this DateTime appropriate for use in SQL DateTime</summary>
    /// <param name="opts">options</param>
    /// <param name="opts.includeZone">include the zone, such as 'America/New_York'. Overrides includeOffset. Defaults to false.</param>
    /// <param name="opts.includeOffset">include the offset, such as 'Z' or '-04:00'. Defaults to true.</param>
    /// <example>DateTime.utc(2014, 7, 13).toSQL() //=&gt; '2014-07-13 00:00:00.000 Z'</example>
    /// <example>DateTime.local(2014, 7, 13).toSQL() //=&gt; '2014-07-13 00:00:00.000 -04:00'</example>
    /// <example>DateTime.local(2014, 7, 13).toSQL({ includeOffset: false }) //=&gt; '2014-07-13 00:00:00.000'</example>
    /// <example>DateTime.local(2014, 7, 13).toSQL({ includeZone: true }) //=&gt; '2014-07-13 00:00:00.000 America/New_York'</example>
    abstract toSQL: ?opts: ToSQLOptions -> string
    /// Returns a string representation of this DateTime appropriate for debugging
    abstract toString: unit -> string
    /// <summary>Returns the epoch milliseconds of this DateTime. Alias of <see cref="DateTime.toMillis" /></summary>
    abstract valueOf: unit -> float
    /// Returns the epoch milliseconds of this DateTime.
    abstract toMillis: unit -> float
    /// Returns the epoch seconds of this DateTime.
    abstract toSeconds: unit -> float
    /// Returns an ISO 8601 representation of this DateTime appropriate for use in JSON.
    abstract toJSON: unit -> string
    /// Returns a BSON serializable equivalent to this DateTime.
    abstract toBSON: unit -> DateTime
    /// <summary>Returns a JavaScript object with this DateTime's year, month, day, and so on.</summary>
    /// <param name="opts">options for generating the object</param>
    /// <param name="opts.includeConfig">include configuration attributes in the output. Defaults to false.</param>
    /// <example>DateTime.now().toObject() //=&gt; { year: 2017, month: 4, day: 22, hour: 20, minute: 49, second: 42, millisecond: 268 }</example>
    abstract toObject: ?opts: {| includeConfig: bool option |} -> ToObjectOutput
    /// Returns a JavaScript Date equivalent to this DateTime.
    abstract toJSDate: unit -> System.DateTime
    /// <summary>Return the difference between two DateTimes as a Duration.</summary>
    /// <param name="otherDateTime">the DateTime to compare this one to</param>
    /// <param name="unit-">the unit or array of units (such as 'hours' or 'days') to include in the duration. Defaults to ['milliseconds'].</param>
    /// <param name="opts">options that affect the creation of the Duration</param>
    /// <param name="opts.conversionAccuracy">the conversion system to use. Defaults to 'casual'.</param>
    /// <example>
    /// var i1 = DateTime.fromISO('1982-05-25T09:45'),
    ///     i2 = DateTime.fromISO('1983-10-14T10:30');
    /// i2.diff(i1).toObject() //=&gt; { milliseconds: 43807500000 }
    /// i2.diff(i1, 'hours').toObject() //=&gt; { hours: 12168.75 }
    /// i2.diff(i1, ['months', 'days']).toObject() //=&gt; { months: 16, days: 19.03125 }
    /// i2.diff(i1, ['months', 'days', 'hours']).toObject() //=&gt; { months: 16, days: 19, hours: 0.75 }
    /// </example>
    abstract diff: otherDateTime: DateTime * ?unit: DurationUnits * ?opts: DiffOptions -> Duration
    /// <summary>
    /// Return the difference between this DateTime and right now.
    /// See <see cref="DateTime.diff" />
    /// </summary>
    /// <param name="unit">the unit or units units (such as 'hours' or 'days') to include in the duration. Defaults to ['milliseconds'].</param>
    /// <param name="opts">options that affect the creation of the Duration</param>
    /// <param name="opts.conversionAccuracy">the conversion system to use. Defaults to 'casual'.</param>
    abstract diffNow: ?unit: DurationUnits * ?opts: DiffOptions -> Duration
    /// <summary>Return an Interval spanning between this DateTime and another DateTime</summary>
    /// <param name="otherDateTime">the other end point of the Interval</param>
    abstract until: otherDateTime: DateTime -> Interval
    /// <summary>
    /// Return whether this DateTime is in the same unit of time as another DateTime.
    /// Note that time zones are **ignored** in this comparison, which compares the **local** calendar time. Use <see cref="DateTime.setZone" /> to convert one of the dates if needed.
    /// </summary>
    /// <param name="otherDateTime">the other DateTime</param>
    /// <param name="unit">the unit of time to check sameness on</param>
    /// <example>DateTime.now().hasSame(otherDT, 'day'); //~&gt; true if otherDT is in the same current calendar day</example>
    abstract hasSame: otherDateTime: DateTime * unit: DateTimeUnit -> bool
    /// <summary>
    /// Equality check
    /// Two DateTimes are equal iff they represent the same millisecond, have the same zone and location, and are both valid.
    /// To compare just the millisecond values, use <c>+dt1 === +dt2</c>.
    /// </summary>
    /// <param name="other">the other DateTime</param>
    abstract equals: other: DateTime -> bool
    /// <summary>
    /// Returns a string representation of a this time relative to now, such as "in two days". Can only internationalize if your
    /// platform supports Intl.RelativeTimeFormat. Rounds down by default.
    /// </summary>
    /// <param name="options">options that affect the output</param>
    /// <param name="options.base">the DateTime to use as the basis to which this time is compared. Defaults to now.</param>
    /// <param name="options.style">the style of units, must be "long", "short", or "narrow". Defaults to long.</param>
    /// <param name="options.unit">
    /// use a specific unit or array of units; if omitted, or an array, the method will pick the best unit.
    /// Use an array or one of "years", "quarters", "months", "weeks", "days", "hours", "minutes", or "seconds"
    /// </param>
    /// <param name="options.round">whether to round the numbers in the output. Defaults to true.</param>
    /// <param name="options.padding">
    /// padding in milliseconds. This allows you to round up the result if it fits inside the threshold. Don't use in combination with {round: false}
    /// because the decimal output will include the padding. Defaults to 0.
    /// </param>
    /// <param name="options.locale">override the locale of this DateTime</param>
    /// <param name="options.numberingSystem">override the numberingSystem of this DateTime. The Intl system may choose not to honor this</param>
    /// <example>DateTime.now().plus({ days: 1 }).toRelative() //=&gt; "in 1 day"</example>
    /// <example>DateTime.now().setLocale("es").toRelative({ days: 1 }) //=&gt; "dentro de 1 día"</example>
    /// <example>DateTime.now().plus({ days: 1 }).toRelative({ locale: "fr" }) //=&gt; "dans 23 heures"</example>
    /// <example>DateTime.now().minus({ days: 2 }).toRelative() //=&gt; "2 days ago"</example>
    /// <example>DateTime.now().minus({ days: 2 }).toRelative({ unit: "hours" }) //=&gt; "48 hours ago"</example>
    /// <example>DateTime.now().minus({ hours: 36 }).toRelative({ round: false }) //=&gt; "1.5 days ago"</example>
    abstract toRelative: ?options: ToRelativeOptions -> string option
    /// <summary>
    /// Returns a string representation of this date relative to today, such as "yesterday" or "next month".
    /// Only internationalizes on platforms that supports Intl.RelativeTimeFormat.
    /// </summary>
    /// <param name="options">options that affect the output</param>
    /// <param name="options.base">the DateTime to use as the basis to which this time is compared. Defaults to now.</param>
    /// <param name="options.locale">override the locale of this DateTime</param>
    /// <param name="options.unit">use a specific unit; if omitted, the method will pick the unit. Use one of "years", "quarters", "months", "weeks", or "days"</param>
    /// <param name="options.numberingSystem">override the numberingSystem of this DateTime. The Intl system may choose not to honor this</param>
    /// <example>DateTime.now().plus({ days: 1 }).toRelativeCalendar() //=&gt; "tomorrow"</example>
    /// <example>DateTime.now().setLocale("es").plus({ days: 1 }).toRelative() //=&gt; ""mañana"</example>
    /// <example>DateTime.now().plus({ days: 1 }).toRelativeCalendar({ locale: "fr" }) //=&gt; "demain"</example>
    /// <example>DateTime.now().minus({ days: 2 }).toRelativeCalendar() //=&gt; "2 days ago"</example>
    abstract toRelativeCalendar: ?options: ToRelativeCalendarOptions -> string option
    abstract toUnixInteger : unit -> int

/// <summary>
/// A DateTime is an immutable data structure representing a specific date and time and accompanying methods.
/// It contains class and instance methods for creating, parsing, interrogating, transforming, and formatting them.
///
/// A DateTime comprises of:
/// * A timestamp. Each DateTime instance refers to a specific millisecond of the Unix epoch.
/// * A time zone. Each instance is considered in the context of a specific zone (by default the local system's zone).
/// * Configuration properties that effect how output strings are formatted, such as <c>locale</c>, <c>numberingSystem</c>, and <c>outputCalendar</c>.
///
/// Here is a brief overview of the most commonly used functionality it provides:
///
/// * **Creation**: To create a DateTime from its components, use one of its factory class methods: <see cref="DateTime.local" />, <see cref="DateTime.utc" />, and (most flexibly) <see cref="DateTime.fromObject" />.
/// To create one from a standard string format, use <see cref="DateTime.fromISO" />, <see cref="DateTime.fromHTTP" />, and <see cref="DateTime.fromRFC2822" />.
/// To create one from a custom string format, use <see cref="DateTime.fromFormat" />. To create one from a native JS date, use <see cref="DateTime.fromJSDate" />.
/// * **Gregorian calendar and time**: To examine the Gregorian properties of a DateTime individually (i.e as opposed to collectively through <see cref="DateTime.toObject" />), use the <see cref="DateTime.year" />,
/// <see cref="DateTime.month" />, <see cref="DateTime.day" />, <see cref="DateTime.hour" />, <see cref="DateTime.minute" />, <see cref="DateTime.second" />, <see cref="DateTime.millisecond" /> accessors.
/// * **Week calendar**: For ISO week calendar attributes, see the <see cref="DateTime.weekYear" />, <see cref="DateTime.weekNumber" />, and <see cref="DateTime.weekday" /> accessors.
/// * **Configuration** See the <see cref="DateTime.locale" /> and <see cref="DateTime.numberingSystem" /> accessors.
/// * **Transformation**: To transform the DateTime into other DateTimes, use <see cref="DateTime.set" />, <see cref="DateTime.reconfigure" />, <see cref="DateTime.setZone" />, <see cref="DateTime.setLocale" />,
/// <see cref="DateTime.plus" />, <see cref="DateTime.minus" />, <see cref="DateTime.endOf" />, <see cref="DateTime.startOf" />, <see cref="DateTime.toUTC" />, and <see cref="DateTime.toLocal" />.
/// * **Output**: To convert the DateTime to other representations, use the <see cref="DateTime.toRelative" />, <see cref="DateTime.toRelativeCalendar" />, <see cref="DateTime.toJSON" />, <see cref="DateTime.toISO" />,
/// <see cref="DateTime.toHTTP" />, <see cref="DateTime.toObject" />, <see cref="DateTime.toRFC2822" />, <see cref="DateTime.toString" />, <see cref="DateTime.toLocaleString" />, <see cref="DateTime.toFormat" />,
/// <see cref="DateTime.toMillis" /> and <see cref="DateTime.toJSDate" />.
///
/// There's plenty others documented below. In addition, for more information on subtler topics
/// like internationalization, time zones, alternative calendars, validity, and so on, see the external documentation.
/// </summary>
type [<AllowNullLiteral>] DateTimeStatic =
    [<EmitConstructor>] abstract Create: unit -> DateTime
    /// <summary>
    /// Create a DateTime for the current instant, in the system's time zone.
    ///
    /// Use Settings to override these default values if needed.
    /// </summary>
    /// <example>DateTime.now().toISO() //~&gt; now in the ISO format</example>
    abstract now: unit -> DateTime
    /// <summary>Create a local DateTime</summary>
    /// <param name="year">The calendar year. If omitted (as in, call <c>local()</c> with no arguments), the current time will be used</param>
    /// <param name="month">The month, 1-indexed</param>
    /// <param name="day">The day of the month, 1-indexed</param>
    /// <param name="hour">The hour of the day, in 24-hour time</param>
    /// <param name="minute">The minute of the hour, meaning a number between 0 and 59</param>
    /// <param name="second">The second of the minute, meaning a number between 0 and 59</param>
    /// <param name="millisecond">The millisecond of the second, meaning a number between 0 and 999</param>
    /// <example>DateTime.local()                                  //~&gt; now</example>
    /// <example>DateTime.local({ zone: "America/New_York" })      //~&gt; now, in US east coast time</example>
    /// <example>DateTime.local(2017)                              //~&gt; 2017-01-01T00:00:00</example>
    /// <example>DateTime.local(2017, 3)                           //~&gt; 2017-03-01T00:00:00</example>
    /// <example>DateTime.local(2017, 3, 12, { locale: "fr")       //~&gt; 2017-03-12T00:00:00, with a French locale</example>
    /// <example>DateTime.local(2017, 3, 12, 5)                    //~&gt; 2017-03-12T05:00:00</example>
    /// <example>DateTime.local(2017, 3, 12, 5, { zone: "utc" })   //~&gt; 2017-03-12T05:00:00, in UTC</example>
    /// <example>DateTime.local(2017, 3, 12, 5, 45)                //~&gt; 2017-03-12T05:45:00</example>
    /// <example>DateTime.local(2017, 3, 12, 5, 45, 10)            //~&gt; 2017-03-12T05:45:10</example>
    /// <example>DateTime.local(2017, 3, 12, 5, 45, 10, 765)       //~&gt; 2017-03-12T05:45:10.765</example>
    abstract local: year: float * month: float * day: float * hour: float * minute: float * second: float * millisecond: float * ?opts: DateTimeJSOptions -> DateTime
    abstract local: year: float * month: float * day: float * hour: float * minute: float * second: float * ?opts: DateTimeJSOptions -> DateTime
    abstract local: year: float * month: float * day: float * hour: float * minute: float * ?opts: DateTimeJSOptions -> DateTime
    abstract local: year: float * month: float * day: float * hour: float * ?opts: DateTimeJSOptions -> DateTime
    abstract local: year: float * month: float * day: float * ?opts: DateTimeJSOptions -> DateTime
    abstract local: year: float * month: float * ?opts: DateTimeJSOptions -> DateTime
    abstract local: year: float * ?opts: DateTimeJSOptions -> DateTime
    abstract local: ?opts: DateTimeJSOptions -> DateTime
    /// <summary>Create a DateTime in UTC</summary>
    /// <param name="year">The calendar year. If omitted (as in, call <c>utc()</c> with no arguments), the current time will be used</param>
    /// <param name="month">The month, 1-indexed</param>
    /// <param name="day">The day of the month</param>
    /// <param name="hour">The hour of the day, in 24-hour time</param>
    /// <param name="minute">The minute of the hour, meaning a number between 0 and 59</param>
    /// <param name="second">The second of the minute, meaning a number between 0 and 59</param>
    /// <param name="millisecond">The millisecond of the second, meaning a number between 0 and 999</param>
    /// <param name="options">configuration options for the DateTime</param>
    /// <param name="options.locale">a locale to set on the resulting DateTime instance</param>
    /// <param name="options.outputCalendar">the output calendar to set on the resulting DateTime instance</param>
    /// <param name="options.numberingSystem">the numbering system to set on the resulting DateTime instance</param>
    /// <example>DateTime.utc()                                            //~&gt; now</example>
    /// <example>DateTime.utc(2017)                                        //~&gt; 2017-01-01T00:00:00Z</example>
    /// <example>DateTime.utc(2017, 3)                                     //~&gt; 2017-03-01T00:00:00Z</example>
    /// <example>DateTime.utc(2017, 3, 12)                                 //~&gt; 2017-03-12T00:00:00Z</example>
    /// <example>DateTime.utc(2017, 3, 12, 5)                              //~&gt; 2017-03-12T05:00:00Z</example>
    /// <example>DateTime.utc(2017, 3, 12, 5, 45)                          //~&gt; 2017-03-12T05:45:00Z</example>
    /// <example>DateTime.utc(2017, 3, 12, 5, 45, { locale: "fr" } )       //~&gt; 2017-03-12T05:45:00Z with a French locale</example>
    /// <example>DateTime.utc(2017, 3, 12, 5, 45, 10)                      //~&gt; 2017-03-12T05:45:10Z</example>
    /// <example>DateTime.utc(2017, 3, 12, 5, 45, 10, 765, { locale: "fr") //~&gt; 2017-03-12T05:45:10.765Z with a French locale</example>
    abstract utc: year: float * month: float * day: float * hour: float * minute: float * second: float * millisecond: float * ?options: LocaleOptions -> DateTime
    abstract utc: year: float * month: float * day: float * hour: float * minute: float * second: float * ?options: LocaleOptions -> DateTime
    abstract utc: year: float * month: float * day: float * hour: float * minute: float * ?options: LocaleOptions -> DateTime
    abstract utc: year: float * month: float * day: float * hour: float * ?options: LocaleOptions -> DateTime
    abstract utc: year: float * month: float * day: float * ?options: LocaleOptions -> DateTime
    abstract utc: year: float * month: float * ?options: LocaleOptions -> DateTime
    abstract utc: year: float * ?options: LocaleOptions -> DateTime
    abstract utc: ?options: LocaleOptions -> DateTime
    /// <summary>Create a DateTime from a JavaScript Date object. Uses the default zone.</summary>
    /// <param name="date">a JavaScript Date object</param>
    /// <param name="options">configuration options for the DateTime</param>
    /// <param name="options.zone">the zone to place the DateTime into</param>
    abstract fromJSDate: date: System.DateTime * ?options: {| zone: U2<string, Zone> option |} -> DateTime
    /// <summary>Create a DateTime from a number of milliseconds since the epoch (meaning since 1 January 1970 00:00:00 UTC). Uses the default zone.</summary>
    /// <param name="milliseconds">a number of milliseconds since 1970 UTC</param>
    /// <param name="options">configuration options for the DateTime</param>
    /// <param name="options.zone">the zone to place the DateTime into. Defaults to 'local'.</param>
    /// <param name="options.locale">a locale to set on the resulting DateTime instance</param>
    /// <param name="options.outputCalendar">the output calendar to set on the resulting DateTime instance</param>
    /// <param name="options.numberingSystem">the numbering system to set on the resulting DateTime instance</param>
    abstract fromMillis: milliseconds: float * ?options: DateTimeJSOptions -> DateTime
    /// <summary>Create a DateTime from a number of seconds since the epoch (meaning since 1 January 1970 00:00:00 UTC). Uses the default zone.</summary>
    /// <param name="seconds">a number of seconds since 1970 UTC</param>
    /// <param name="options">configuration options for the DateTime</param>
    /// <param name="options.zone">the zone to place the DateTime into. Defaults to 'local'.</param>
    /// <param name="options.locale">a locale to set on the resulting DateTime instance</param>
    /// <param name="options.outputCalendar">the output calendar to set on the resulting DateTime instance</param>
    /// <param name="options.numberingSystem">the numbering system to set on the resulting DateTime instance</param>
    abstract fromSeconds: seconds: float * ?options: DateTimeJSOptions -> DateTime
    /// <summary>Create a DateTime from a JavaScript object with keys like 'year' and 'hour' with reasonable defaults.</summary>
    /// <param name="obj">the object to create the DateTime from</param>
    /// <param name="obj.year">a year, such as 1987</param>
    /// <param name="obj.month">a month, 1-12</param>
    /// <param name="obj.day">a day of the month, 1-31, depending on the month</param>
    /// <param name="obj.ordinal">day of the year, 1-365 or 366</param>
    /// <param name="obj.weekYear">an ISO week year</param>
    /// <param name="obj.weekNumber">an ISO week number, between 1 and 52 or 53, depending on the year</param>
    /// <param name="obj.weekday">an ISO weekday, 1-7, where 1 is Monday and 7 is Sunday</param>
    /// <param name="obj.hour">hour of the day, 0-23</param>
    /// <param name="obj.minute">minute of the hour, 0-59</param>
    /// <param name="obj.second">second of the minute, 0-59</param>
    /// <param name="obj.millisecond">millisecond of the second, 0-999</param>
    /// <param name="opts">options for creating this DateTime</param>
    /// <param name="opts.zone">interpret the numbers in the context of a particular zone. Can take any value taken as the first argument to setZone(). Defaults to 'local'.</param>
    /// <param name="opts.locale">a locale to set on the resulting DateTime instance. Defaults to 'system's locale'.</param>
    /// <param name="opts.outputCalendar">the output calendar to set on the resulting DateTime instance</param>
    /// <param name="opts.numberingSystem">the numbering system to set on the resulting DateTime instance</param>
    /// <example>DateTime.fromObject({ year: 1982, month: 5, day: 25}).toISODate() //=&gt; '1982-05-25'</example>
    /// <example>DateTime.fromObject({ year: 1982 }).toISODate() //=&gt; '1982-01-01'</example>
    /// <example>DateTime.fromObject({ hour: 10, minute: 26, second: 6 }) //~&gt; today at 10:26:06</example>
    /// <example>DateTime.fromObject({ hour: 10, minute: 26, second: 6 }, { zone: 'utc' }),</example>
    /// <example>DateTime.fromObject({ hour: 10, minute: 26, second: 6 }, { zone: 'local' })</example>
    /// <example>DateTime.fromObject({ hour: 10, minute: 26, second: 6 }, { }zone: 'America/New_York' })</example>
    /// <example>DateTime.fromObject({ weekYear: 2016, weekNumber: 2, weekday: 3 }).toISODate() //=&gt; '2016-01-13'</example>
    abstract fromObject: obj: DateObjectUnits * ?opts: DateTimeJSOptions -> DateTime
    /// <summary>Create a DateTime from an ISO 8601 string</summary>
    /// <param name="text">the ISO string</param>
    /// <param name="opts">options to affect the creation</param>
    /// <param name="opts.zone">use this zone if no offset is specified in the input string itself. Will also convert the time to this zone. Defaults to 'local'.</param>
    /// <param name="opts.setZone">override the zone with a fixed-offset zone specified in the string itself, if it specifies one. Defaults to false.</param>
    /// <param name="opts.locale">a locale to set on the resulting DateTime instance. Defaults to 'system's locale'.</param>
    /// <param name="opts.outputCalendar">the output calendar to set on the resulting DateTime instance</param>
    /// <param name="opts.numberingSystem">the numbering system to set on the resulting DateTime instance</param>
    /// <example>DateTime.fromISO('2016-05-25T09:08:34.123')</example>
    /// <example>DateTime.fromISO('2016-05-25T09:08:34.123+06:00')</example>
    /// <example>DateTime.fromISO('2016-05-25T09:08:34.123+06:00', {setZone: true})</example>
    /// <example>DateTime.fromISO('2016-05-25T09:08:34.123', {zone: 'utc'})</example>
    /// <example>DateTime.fromISO('2016-W05-4')</example>
    abstract fromISO: text: string * ?opts: DateTimeOptions -> DateTime
    /// <summary>Create a DateTime from an RFC 2822 string</summary>
    /// <param name="text">the RFC 2822 string</param>
    /// <param name="opts">options to affect the creation</param>
    /// <param name="opts.zone">
    /// convert the time to this zone. Since the offset is always specified in the string itself,
    /// this has no effect on the interpretation of string, merely the zone the resulting DateTime is expressed in. Defaults to 'local'
    /// </param>
    /// <param name="opts.setZone">override the zone with a fixed-offset zone specified in the string itself, if it specifies one. Defaults to false.</param>
    /// <param name="opts.locale">a locale to set on the resulting DateTime instance. Defaults to 'system's locale'.</param>
    /// <param name="opts.outputCalendar">the output calendar to set on the resulting DateTime instance</param>
    /// <param name="opts.numberingSystem">the numbering system to set on the resulting DateTime instance</param>
    /// <example>DateTime.fromRFC2822('25 Nov 2016 13:23:12 GMT')</example>
    /// <example>DateTime.fromRFC2822('Fri, 25 Nov 2016 13:23:12 +0600')</example>
    /// <example>DateTime.fromRFC2822('25 Nov 2016 13:23 Z')</example>
    abstract fromRFC2822: text: string * ?opts: DateTimeOptions -> DateTime
    /// <summary>Create a DateTime from an HTTP header date</summary>
    /// <seealso href="https://www.w3.org/Protocols/rfc2616/rfc2616-sec3.html#sec3.3.1" />
    /// <param name="text">the HTTP header date</param>
    /// <param name="opts">options to affect the creation</param>
    /// <param name="opts.zone">
    /// convert the time to this zone. Since HTTP dates are always in UTC,
    /// this has no effect on the interpretation of string,merely the zone the resulting DateTime is expressed in. Defaults to 'local'.
    /// </param>
    /// <param name="opts.setZone">
    /// override the zone with the fixed-offset zone specified in the string. For HTTP dates, this is always UTC,
    /// so this option is equivalent to setting the <c>zone</c> option to 'utc', but this option is included for consistency with similar methods. Defaults to false.
    /// </param>
    /// <param name="opts.locale">a locale to set on the resulting DateTime instance. Defaults to 'system's locale'.</param>
    /// <param name="opts.outputCalendar">the output calendar to set on the resulting DateTime instance</param>
    /// <param name="opts.numberingSystem">the numbering system to set on the resulting DateTime instance</param>
    /// <example>DateTime.fromHTTP('Sun, 06 Nov 1994 08:49:37 GMT')</example>
    /// <example>DateTime.fromHTTP('Sunday, 06-Nov-94 08:49:37 GMT')</example>
    /// <example>DateTime.fromHTTP('Sun Nov  6 08:49:37 1994')</example>
    abstract fromHTTP: text: string * ?opts: DateTimeOptions -> DateTime
    /// <summary>
    /// Create a DateTime from an input string and format string.
    /// Defaults to en-US if no locale has been specified, regardless of the system's locale. For a table of tokens and their interpretations,
    /// see <see href="https://moment.github.io/luxon/#/parsing?id=table-of-tokens">here</see>.
    /// </summary>
    /// <param name="text">the string to parse</param>
    /// <param name="fmt">the format the string is expected to be in (see the link below for the formats)</param>
    /// <param name="opts">options to affect the creation</param>
    /// <param name="opts.zone">use this zone if no offset is specified in the input string itself. Will also convert the DateTime to this zone. Defaults to 'local'.</param>
    /// <param name="opts.setZone">override the zone with a zone specified in the string itself, if it specifies one. Defaults to false.</param>
    /// <param name="opts.locale">a locale string to use when parsing. Will also set the DateTime to this locale. Defaults to 'en-US'.</param>
    /// <param name="opts.numberingSystem">the numbering system to use when parsing. Will also set the resulting DateTime to this numbering system</param>
    /// <param name="opts.outputCalendar">the output calendar to set on the resulting DateTime instance</param>
    abstract fromFormat: text: string * fmt: string * ?opts: DateTimeOptions -> DateTime
    [<Obsolete("use fromFormat instead")>]
    abstract fromString: text: string * format: string * ?options: DateTimeOptions -> DateTime
    /// <summary>
    /// Create a DateTime from a SQL date, time, or datetime
    /// Defaults to en-US if no locale has been specified, regardless of the system's locale
    /// </summary>
    /// <param name="text">the string to parse</param>
    /// <param name="opts">options to affect the creation</param>
    /// <param name="opts.zone">use this zone if no offset is specified in the input string itself. Will also convert the DateTime to this zone. Defaults to 'local'.</param>
    /// <param name="opts.setZone">override the zone with a zone specified in the string itself, if it specifies one. Defaults to false.</param>
    /// <param name="opts.locale">a locale string to use when parsing. Will also set the DateTime to this locale. Defaults to 'en-US'.</param>
    /// <param name="opts.numberingSystem">the numbering system to use when parsing. Will also set the resulting DateTime to this numbering system</param>
    /// <param name="opts.outputCalendar">the output calendar to set on the resulting DateTime instance</param>
    /// <example>DateTime.fromSQL('2017-05-15')</example>
    /// <example>DateTime.fromSQL('2017-05-15 09:12:34')</example>
    /// <example>DateTime.fromSQL('2017-05-15 09:12:34.342')</example>
    /// <example>DateTime.fromSQL('2017-05-15 09:12:34.342+06:00')</example>
    /// <example>DateTime.fromSQL('2017-05-15 09:12:34.342 America/Los_Angeles')</example>
    /// <example>DateTime.fromSQL('2017-05-15 09:12:34.342 America/Los_Angeles', { setZone: true })</example>
    /// <example>DateTime.fromSQL('2017-05-15 09:12:34.342', { zone: 'America/Los_Angeles' })</example>
    /// <example>DateTime.fromSQL('09:12:34.342')</example>
    abstract fromSQL: text: string * ?opts: DateTimeOptions -> DateTime
    /// <summary>Create an invalid DateTime.</summary>
    /// <param name="reason">simple string of why this DateTime is invalid. Should not contain parameters or anything else data-dependent</param>
    /// <param name="explanation">longer explanation, may include parameters and other useful debugging information. Defaults to null.</param>
    abstract invalid: reason: string * ?explanation: string -> DateTime
    /// <summary>Check if an object is a DateTime. Works across context boundaries</summary>
    /// <param name="o" />
    abstract isDateTime: o: obj -> bool
    /// <summary>Return the min of several date times</summary>
    /// <param name="dateTimes">the DateTimes from which to choose the minimum</param>
    abstract min: [<ParamArray>] dateTimes: DateTime[] -> DateTime
    /// <summary>Return the max of several date times</summary>
    /// <param name="dateTimes">the DateTimes from which to choose the maximum</param>
    abstract max: [<ParamArray>] dateTimes: DateTime[] -> DateTime
    /// <summary>Explain how a string would be parsed by fromFormat()</summary>
    /// <param name="text">the string to parse</param>
    /// <param name="fmt">the format the string is expected to be in (see description)</param>
    /// <param name="options">options taken by fromFormat()</param>
    abstract fromFormatExplain: text: string * fmt: string * ?options: DateTimeOptions -> ExplainedFormat
    [<Obsolete("use fromFormatExplain instead")>]
    abstract fromStringExplain: text: string * fmt: string * ?options: DateTimeOptions -> ExplainedFormat
    /// <summary><see cref="DateTime.toLocaleString" /> format like 10/14/1983</summary>
    abstract DATE_SHORT: Intl.DateTimeFormatOptions
    /// <summary><see cref="DateTime.toLocaleString" /> format like 'Oct 14, 1983'</summary>
    abstract DATE_MED: Intl.DateTimeFormatOptions
    /// <summary><see cref="DateTime.toLocaleString" /> format like 'Fri, Oct 14, 1983'</summary>
    abstract DATE_MED_WITH_WEEKDAY: Intl.DateTimeFormatOptions
    /// <summary><see cref="DateTime.toLocaleString" /> format like 'October 14, 1983'</summary>
    abstract DATE_FULL: Intl.DateTimeFormatOptions
    /// <summary><see cref="DateTime.toLocaleString" /> format like 'Tuesday, October 14, 1983'</summary>
    abstract DATE_HUGE: Intl.DateTimeFormatOptions
    /// <summary><see cref="DateTime.toLocaleString" /> format like '09:30 AM'. Only 12-hour if the locale is.</summary>
    abstract TIME_SIMPLE: Intl.DateTimeFormatOptions
    /// <summary><see cref="DateTime.toLocaleString" /> format like '09:30:23 AM'. Only 12-hour if the locale is.</summary>
    abstract TIME_WITH_SECONDS: Intl.DateTimeFormatOptions
    /// <summary><see cref="DateTime.toLocaleString" /> format like '09:30:23 AM EDT'. Only 12-hour if the locale is.</summary>
    abstract TIME_WITH_SHORT_OFFSET: Intl.DateTimeFormatOptions
    /// <summary><see cref="DateTime.toLocaleString" /> format like '09:30:23 AM Eastern Daylight Time'. Only 12-hour if the locale is.</summary>
    abstract TIME_WITH_LONG_OFFSET: Intl.DateTimeFormatOptions
    /// <summary><see cref="DateTime.toLocaleString" /> format like '09:30', always 24-hour.</summary>
    abstract TIME_24_SIMPLE: Intl.DateTimeFormatOptions
    /// <summary><see cref="DateTime.toLocaleString" /> format like '09:30:23', always 24-hour.</summary>
    abstract TIME_24_WITH_SECONDS: Intl.DateTimeFormatOptions
    /// <summary><see cref="DateTime.toLocaleString" /> format like '09:30:23 EDT', always 24-hour.</summary>
    abstract TIME_24_WITH_SHORT_OFFSET: Intl.DateTimeFormatOptions
    /// <summary><see cref="DateTime.toLocaleString" /> format like '09:30:23 Eastern Daylight Time', always 24-hour.</summary>
    abstract TIME_24_WITH_LONG_OFFSET: Intl.DateTimeFormatOptions
    /// <summary><see cref="DateTime.toLocaleString" /> format like '10/14/1983, 9:30 AM'. Only 12-hour if the locale is.</summary>
    abstract DATETIME_SHORT: Intl.DateTimeFormatOptions
    /// <summary><see cref="DateTime.toLocaleString" /> format like '10/14/1983, 9:30:33 AM'. Only 12-hour if the locale is.</summary>
    abstract DATETIME_SHORT_WITH_SECONDS: Intl.DateTimeFormatOptions
    /// <summary><see cref="DateTime.toLocaleString" /> format like 'Oct 14, 1983, 9:30 AM'. Only 12-hour if the locale is.</summary>
    abstract DATETIME_MED: Intl.DateTimeFormatOptions
    /// <summary><see cref="DateTime.toLocaleString" /> format like 'Oct 14, 1983, 9:30:33 AM'. Only 12-hour if the locale is.</summary>
    abstract DATETIME_MED_WITH_SECONDS: Intl.DateTimeFormatOptions
    /// <summary><see cref="DateTime.toLocaleString" /> format like 'Fri, 14 Oct 1983, 9:30 AM'. Only 12-hour if the locale is.</summary>
    abstract DATETIME_MED_WITH_WEEKDAY: Intl.DateTimeFormatOptions
    /// <summary><see cref="DateTime.toLocaleString" /> format like 'October 14, 1983, 9:30 AM EDT'. Only 12-hour if the locale is.</summary>
    abstract DATETIME_FULL: Intl.DateTimeFormatOptions
    /// <summary><see cref="DateTime.toLocaleString" /> format like 'October 14, 1983, 9:30:33 AM EDT'. Only 12-hour if the locale is.</summary>
    abstract DATETIME_FULL_WITH_SECONDS: Intl.DateTimeFormatOptions
    /// <summary><see cref="DateTime.toLocaleString" /> format like 'Friday, October 14, 1983, 9:30 AM Eastern Daylight Time'. Only 12-hour if the locale is.</summary>
    abstract DATETIME_HUGE: Intl.DateTimeFormatOptions
    /// <summary><see cref="DateTime.toLocaleString" /> format like 'Friday, October 14, 1983, 9:30:33 AM Eastern Daylight Time'. Only 12-hour if the locale is.</summary>
    abstract DATETIME_HUGE_WITH_SECONDS: Intl.DateTimeFormatOptions


type [<AllowNullLiteral>] DateTimeOptions =
    inherit LocaleOptions
    /// <summary>Use this zone if no offset is specified in the input string itself. Will also convert the time to this zone.</summary>
    /// <default>local</default>
    abstract zone: U2<string, Zone> option with get, set
    /// <summary>Override the zone with a fixed-offset zone specified in the string itself, if it specifies one.</summary>
    /// <default>false</default>
    abstract setZone: bool option with get, set

type [<AllowNullLiteral>] LocaleOptions =
    /// <default>system's locale</default>
    abstract locale: string option with get, set
    abstract outputCalendar: CalendarSystem option with get, set
    abstract numberingSystem: NumberingSystem option with get, set

type CalendarSystem = obj
type NumberingSystem = obj
type Zone = obj
type DateTimeFormatOptions = Intl.DateTimeFormatOptions
type DurationLike = obj
type ToISODateOptions = obj
type ToISOTimeOptions = obj
type DurationUnits = obj
type DiffOptions = obj
type Duration = obj
type Interval = obj

type [<AllowNullLiteral>] DateObjectUnits =
    abstract year: float option with get, set
    abstract month: float option with get, set
    abstract day: float option with get, set
    abstract ordinal: float option with get, set
    abstract weekYear: float option with get, set
    abstract weekNumber: float option with get, set
    abstract weekday: float option with get, set
    abstract hour: float option with get, set
    abstract minute: float option with get, set
    abstract second: float option with get, set
    abstract millisecond: float option with get, set

type DateTimeJSOptions =
    DateTimeOptions


type [<AllowNullLiteral>] ExplainedFormat =
    abstract input: string with get, set
    // abstract tokens: Array<{| literal: bool; ``val``: string |}> with get, set
    // abstract regex: RegExp option with get, set
    // abstract rawMatches: RegExpMatchArray option with get, set
    // abstract matches: ExplainedFormatMatches option with get, set
    // abstract result: ExplainedFormatMatches option with get, set
    abstract zone: Zone option with get, set
    abstract invalidReason: string option with get, set


module Intl =

    type DateTimeFormatOptions = obj
    type DateTimeFormatPart = obj

    [<AllowNullLiteral>]
    type NumberFormatOptions =
        interface end


type [<AllowNullLiteral>] ToSQLOptions =
    /// <summary>Include the offset, such as 'Z' or '-04:00'</summary>
    /// <default>true</default>
    abstract includeOffset: bool option with get, set
    /// <summary>Include the zone, such as 'America/New_York'. Overrides includeOffset.</summary>
    /// <default>false</default>
    abstract includeZone: bool option with get, set


type [<AllowNullLiteral>] ToObjectOutput =
    inherit DateTimeJSOptions
    abstract year: float with get, set
    abstract month: float with get, set
    abstract day: float with get, set
    abstract hour: float with get, set
    abstract minute: float with get, set
    abstract second: float with get, set
    abstract millisecond: float with get, set


type [<AllowNullLiteral>] ToRelativeOptions =
    inherit ToRelativeCalendarOptions
    /// <default>long</default>
    abstract style: StringUnitLength option with get, set
    /// <default>true</default>
    abstract round: bool option with get, set
    /// <summary>
    /// Padding in milliseconds. This allows you to round up the result if it fits inside the threshold.
    /// Don't use in combination with {round: false} because the decimal output will include the padding.
    /// </summary>
    /// <default>0</default>
    abstract padding: float option with get, set
    /// A single unit or an array of units. If an array is supplied, the method will pick the best one
    /// to use from the array. If omitted, the method will pick the unit from a default set.
    abstract unit: U2<ToRelativeUnit, ResizeArray<ToRelativeUnit>> option with get, set

type [<AllowNullLiteral>] ToRelativeCalendarOptions =
    /// <summary>The DateTime to use as the basis to which this time is compared</summary>
    /// <default>now</default>
    abstract ``base``: DateTime option with get, set
    /// Override the locale of this DateTime
    abstract locale: string option with get, set
    /// If omitted, the method will pick the unit.
    abstract unit: ToRelativeUnit option with get, set
    /// Override the numberingSystem of this DateTime.
    /// The Intl system may choose not to honor this.
    abstract numberingSystem: NumberingSystem option with get, set


type [<StringEnum>] [<RequireQualifiedAccess>] HourCycle =
    | H11
    | H12
    | H23
    | H24

type [<StringEnum>] [<RequireQualifiedAccess>] StringUnitLength =
    | Narrow
    | Short
    | Long

type [<StringEnum>] [<RequireQualifiedAccess>] NumberUnitLength =
    | Numeric
    | [<CompiledName "2-digit">] N2Digit

type UnitLength =
    U2<StringUnitLength, NumberUnitLength>


type [<StringEnum>] [<RequireQualifiedAccess>] DateTimeUnit =
    | Year
    | Quarter
    | Month
    | Week
    | Day
    | Hour
    | Minute
    | Second
    | Millisecond

type [<StringEnum>] [<RequireQualifiedAccess>] ToRelativeUnit =
    | Years
    | Quarters
    | Months
    | Weeks
    | Days
    | Hours
    | Minutes
    | Seconds

type [<StringEnum>] [<RequireQualifiedAccess>] ConversionAccuracy =
    | Casual
    | Longterm

type [<RequireQualifiedAccess>] MonthNumbers =
    | N1 = 1
    | N2 = 2
    | N3 = 3
    | N4 = 4
    | N5 = 5
    | N6 = 6
    | N7 = 7
    | N8 = 8
    | N9 = 9
    | N10 = 10
    | N11 = 11
    | N12 = 12

type [<RequireQualifiedAccess>] WeekdayNumbers =
    | N1 = 1
    | N2 = 2
    | N3 = 3
    | N4 = 4
    | N5 = 5
    | N6 = 6
    | N7 = 7

type [<RequireQualifiedAccess>] DayNumbers =
    | N1 = 1
    | N2 = 2
    | N3 = 3
    | N4 = 4
    | N5 = 5
    | N6 = 6
    | N7 = 7
    | N8 = 8
    | N9 = 9
    | N10 = 10
    | N11 = 11
    | N12 = 12
    | N13 = 13
    | N14 = 14
    | N15 = 15
    | N16 = 16
    | N17 = 17
    | N18 = 18
    | N19 = 19
    | N20 = 20
    | N21 = 21
    | N22 = 22
    | N23 = 23
    | N24 = 24
    | N25 = 25
    | N26 = 26
    | N27 = 27
    | N28 = 28
    | N29 = 29
    | N30 = 30
    | N31 = 31

type [<RequireQualifiedAccess>] SecondNumbers =
    | N0 = 0
    | N1 = 1
    | N2 = 2
    | N3 = 3
    | N4 = 4
    | N5 = 5
    | N6 = 6
    | N7 = 7
    | N8 = 8
    | N9 = 9
    | N10 = 10
    | N11 = 11
    | N12 = 12
    | N13 = 13
    | N14 = 14
    | N15 = 15
    | N16 = 16
    | N17 = 17
    | N18 = 18
    | N19 = 19
    | N20 = 20
    | N21 = 21
    | N22 = 22
    | N23 = 23
    | N24 = 24
    | N25 = 25
    | N26 = 26
    | N27 = 27
    | N28 = 28
    | N29 = 29
    | N30 = 30
    | N31 = 31
    | N32 = 32
    | N33 = 33
    | N34 = 34
    | N35 = 35
    | N36 = 36
    | N37 = 37
    | N38 = 38
    | N39 = 39
    | N40 = 40
    | N41 = 41
    | N42 = 42
    | N43 = 43
    | N44 = 44
    | N45 = 45
    | N46 = 46
    | N47 = 47
    | N48 = 48
    | N49 = 49
    | N50 = 50
    | N51 = 51
    | N52 = 52
    | N53 = 53
    | N54 = 54
    | N55 = 55
    | N56 = 56
    | N57 = 57
    | N58 = 58
    | N59 = 59

type MinuteNumbers =
    SecondNumbers

type [<RequireQualifiedAccess>] HourNumbers =
    | N0 = 0
    | N1 = 1
    | N2 = 2
    | N3 = 3
    | N4 = 4
    | N5 = 5
    | N6 = 6
    | N7 = 7
    | N8 = 8
    | N9 = 9
    | N10 = 10
    | N11 = 11
    | N12 = 12
    | N13 = 13
    | N14 = 14
    | N15 = 15
    | N16 = 16
    | N17 = 17
    | N18 = 18
    | N19 = 19
    | N20 = 20
    | N21 = 21
    | N22 = 22
    | N23 = 23

type [<RequireQualifiedAccess>] WeekNumbers =
    | N1 = 1
    | N2 = 2
    | N3 = 3
    | N4 = 4
    | N5 = 5
    | N6 = 6
    | N7 = 7
    | N8 = 8
    | N9 = 9
    | N10 = 10
    | N11 = 11
    | N12 = 12
    | N13 = 13
    | N14 = 14
    | N15 = 15
    | N16 = 16
    | N17 = 17
    | N18 = 18
    | N19 = 19
    | N20 = 20
    | N21 = 21
    | N22 = 22
    | N23 = 23
    | N24 = 24
    | N25 = 25
    | N26 = 26
    | N27 = 27
    | N28 = 28
    | N29 = 29
    | N30 = 30
    | N31 = 31
    | N32 = 32
    | N33 = 33
    | N34 = 34
    | N35 = 35
    | N36 = 36
    | N37 = 37
    | N38 = 38
    | N39 = 39
    | N40 = 40
    | N41 = 41
    | N42 = 42
    | N43 = 43
    | N44 = 44
    | N45 = 45
    | N46 = 46
    | N47 = 47
    | N48 = 48
    | N49 = 49
    | N50 = 50
    | N51 = 51
    | N52 = 52
    | N53 = 53

type [<RequireQualifiedAccess>] QuarterNumbers =
    | N1 = 1
    | N2 = 2
    | N3 = 3
    | N4 = 4

type [<RequireQualifiedAccess>] PossibleDaysInMonth =
    | N28 = 28
    | N29 = 29
    | N30 = 30
    | N31 = 31

type [<RequireQualifiedAccess>] PossibleDaysInYear =
    | N365 = 365
    | N366 = 366

type [<RequireQualifiedAccess>] PossibleWeeksInYear =
    | N52 = 52
    | N53 = 53

type ResolvedLocaleOptions =
    /// <default>system's locale</default>
    abstract locale: string with get, set
    abstract outputCalendar: CalendarSystem with get, set
    abstract numberingSystem: NumberingSystem with get, set


type [<AllowNullLiteral>] ZoneOptions =
    /// If true, adjust the underlying time so that the local time stays the same, but in the target zone.
    /// You should rarely need this.
    /// Defaults to false.
    abstract keepLocalTime: bool option with get, set
    [<Obsolete("since 0.2.12. Use keepLocalTime instead")>]
    abstract keepCalendarTime: bool option with get, set

module Interval =

    type [<AllowNullLiteral>] IExports =
        /// <summary>
        /// An Interval object represents a half-open interval of time, where each endpoint is a <see cref="DateTime" />. Conceptually, it's a container for those two endpoints, accompanied by methods for
        /// creating, parsing, interrogating, comparing, transforming, and formatting them.
        ///
        /// Here is a brief overview of the most commonly used methods and getters in Interval:
        ///
        /// * **Creation** To create an Interval, use <see cref="Interval.fromDateTimes" />, <see cref="Interval.after" />, <see cref="Interval.before" />, or <see cref="Interval.fromISO" />.
        /// * **Accessors** Use <see cref="Interval.start" /> and <see cref="Interval.end" /> to get the start and end.
        /// * **Interrogation** To analyze the Interval, use <see cref="Interval.count" />, <see cref="Interval.length" />, <see cref="Interval.hasSame" />,
        /// * <see cref="Interval.contains" />, <see cref="Interval.isAfter" />, or <see cref="Interval.isBefore" />.
        /// * **Transformation** To create other Intervals out of this one, use <see cref="Interval.set" />, <see cref="Interval.splitAt" />, <see cref="Interval.splitBy" />, <see cref="Interval.divideEqually" />,
        /// * <see cref="Interval.merge" />, <see cref="Interval.xor" />, <see cref="Interval.union" />, <see cref="Interval.intersection" />, or <see cref="Interval.difference" />.
        /// * **Comparison** To compare this Interval to another one, use <see cref="Interval.equals" />, <see cref="Interval.overlaps" />, <see cref="Interval.abutsStart" />, <see cref="Interval.abutsEnd" />, <see cref="Interval.engulfs" />
        /// * **Output** To convert the Interval into other representations, see <see cref="Interval.toString" />, <see cref="Interval.toISO" />, <see cref="Interval.toISODate" />, <see cref="Interval.toISOTime" />,
        /// * <see cref="Interval.toFormat" />, and <see cref="Interval.toDuration" />.
        /// </summary>
        abstract Interval: IntervalStatic

    type [<AllowNullLiteral>] IntervalObject =
        abstract start: DateTime option with get, set
        abstract ``end``: DateTime option with get, set

    type DateInput =
        U2<DateTime, DateObjectUnits>

    /// <summary>
    /// An Interval object represents a half-open interval of time, where each endpoint is a <see cref="DateTime" />. Conceptually, it's a container for those two endpoints, accompanied by methods for
    /// creating, parsing, interrogating, comparing, transforming, and formatting them.
    ///
    /// Here is a brief overview of the most commonly used methods and getters in Interval:
    ///
    /// * **Creation** To create an Interval, use <see cref="Interval.fromDateTimes" />, <see cref="Interval.after" />, <see cref="Interval.before" />, or <see cref="Interval.fromISO" />.
    /// * **Accessors** Use <see cref="Interval.start" /> and <see cref="Interval.end" /> to get the start and end.
    /// * **Interrogation** To analyze the Interval, use <see cref="Interval.count" />, <see cref="Interval.length" />, <see cref="Interval.hasSame" />,
    /// * <see cref="Interval.contains" />, <see cref="Interval.isAfter" />, or <see cref="Interval.isBefore" />.
    /// * **Transformation** To create other Intervals out of this one, use <see cref="Interval.set" />, <see cref="Interval.splitAt" />, <see cref="Interval.splitBy" />, <see cref="Interval.divideEqually" />,
    /// * <see cref="Interval.merge" />, <see cref="Interval.xor" />, <see cref="Interval.union" />, <see cref="Interval.intersection" />, or <see cref="Interval.difference" />.
    /// * **Comparison** To compare this Interval to another one, use <see cref="Interval.equals" />, <see cref="Interval.overlaps" />, <see cref="Interval.abutsStart" />, <see cref="Interval.abutsEnd" />, <see cref="Interval.engulfs" />
    /// * **Output** To convert the Interval into other representations, see <see cref="Interval.toString" />, <see cref="Interval.toISO" />, <see cref="Interval.toISODate" />, <see cref="Interval.toISOTime" />,
    /// * <see cref="Interval.toFormat" />, and <see cref="Interval.toDuration" />.
    /// </summary>
    type [<AllowNullLiteral>] Interval =
        /// Returns the start of the Interval
        abstract start: DateTime
        /// Returns the end of the Interval
        abstract ``end``: DateTime
        /// Returns whether this Interval's end is at least its start, meaning that the Interval isn't 'backwards'.
        abstract isValid: bool
        /// Returns an error code if this Interval is invalid, or null if the Interval is valid
        abstract invalidReason: string
        /// Returns an explanation of why this Interval became invalid, or null if the Interval is valid
        abstract invalidExplanation: string
        /// <summary>Returns the length of the Interval in the specified unit.</summary>
        /// <param name="unit">the unit (such as 'hours' or 'days') to return the length in.</param>
        abstract length: ?unit: Duration.DurationUnit -> float
        /// <summary>
        /// Returns the count of minutes, hours, days, months, or years included in the Interval, even in part.
        /// Unlike <see cref="Interval.length" /> this counts sections of the calendar, not periods of time, e.g. specifying 'day'
        /// asks 'what dates are included in this interval?', not 'how many days long is this interval?'
        /// </summary>
        /// <param name="unit">the unit of time to count. Defaults to 'milliseconds'.</param>
        abstract count: ?unit: Duration.DurationUnit -> float
        /// <summary>Returns whether this Interval's start and end are both in the same unit of time</summary>
        /// <param name="unit">the unit of time to check sameness on</param>
        abstract hasSame: unit: Duration.DurationUnit -> bool
        /// Return whether this Interval has the same start and end DateTimes.
        abstract isEmpty: unit -> bool
        /// <summary>Return whether this Interval's start is after the specified DateTime.</summary>
        /// <param name="dateTime" />
        abstract isAfter: dateTime: DateTime -> bool
        /// <summary>Return whether this Interval's end is before the specified DateTime.</summary>
        /// <param name="dateTime" />
        abstract isBefore: dateTime: DateTime -> bool
        /// <summary>Return whether this Interval contains the specified DateTime.</summary>
        /// <param name="dateTime" />
        abstract contains: dateTime: DateTime -> bool
        /// <summary>"Sets" the start and/or end dates. Returns a newly-constructed Interval.</summary>
        /// <param name="values">the values to set</param>
        /// <param name="values.start">the starting DateTime</param>
        /// <param name="values.end">the ending DateTime</param>
        abstract set: ?values: IntervalObject -> Interval
        /// <summary>Split this Interval at each of the specified DateTimes</summary>
        /// <param name="dateTimes">the unit of time to count.</param>
        abstract splitAt: [<ParamArray>] dateTimes: DateTime[] -> ResizeArray<Interval>
        /// <summary>
        /// Split this Interval into smaller Intervals, each of the specified length.
        /// Left over time is grouped into a smaller interval
        /// </summary>
        /// <param name="duration">The length of each resulting interval.</param>
        abstract splitBy: duration: DurationLike -> ResizeArray<Interval>
        /// <summary>Split this Interval into the specified number of smaller intervals.</summary>
        /// <param name="numberOfParts">The number of Intervals to divide the Interval into.</param>
        abstract divideEqually: numberOfParts: float -> ResizeArray<Interval>
        /// <summary>Return whether this Interval overlaps with the specified Interval</summary>
        /// <param name="other" />
        abstract overlaps: other: Interval -> bool
        /// <summary>Return whether this Interval's end is adjacent to the specified Interval's start.</summary>
        /// <param name="other" />
        abstract abutsStart: other: Interval -> bool
        /// <summary>Return whether this Interval's start is adjacent to the specified Interval's end.</summary>
        /// <param name="other" />
        abstract abutsEnd: other: Interval -> bool
        /// <summary>Return whether this Interval engulfs the start and end of the specified Interval.</summary>
        /// <param name="other" />
        abstract engulfs: other: Interval -> bool
        /// <summary>Return whether this Interval has the same start and end as the specified Interval.</summary>
        /// <param name="other" />
        abstract equals: other: Interval -> bool
        /// <summary>
        /// Return an Interval representing the intersection of this Interval and the specified Interval.
        /// Specifically, the resulting Interval has the maximum start time and the minimum end time of the two Intervals.
        /// Returns null if the intersection is empty, meaning, the intervals don't intersect.
        /// </summary>
        /// <param name="other" />
        abstract intersection: other: Interval -> Interval option
        /// <summary>
        /// Return an Interval representing the union of this Interval and the specified Interval.
        /// Specifically, the resulting Interval has the minimum start time and the maximum end time of the two Intervals.
        /// </summary>
        /// <param name="other" />
        abstract union: other: Interval -> Interval
        /// <summary>Return an Interval representing the span of time in this Interval that doesn't overlap with any of the specified Intervals.</summary>
        /// <param name="intervals" />
        abstract difference: [<ParamArray>] intervals: Interval[] -> ResizeArray<Interval>
        /// Returns a string representation of this Interval appropriate for debugging.
        abstract toString: unit -> string
        /// <summary>Returns an ISO 8601-compliant string representation of this Interval.</summary>
        /// <seealso href="https://en.wikipedia.org/wiki/ISO_8601#Time_intervals" />
        /// <param name="opts">The same options as <see cref="DateTime.toISO" /></param>
        abstract toISO: ?opts: ToISOTimeOptions -> string
        /// <summary>
        /// Returns an ISO 8601-compliant string representation of date of this Interval.
        /// The time components are ignored.
        /// </summary>
        /// <seealso href="https://en.wikipedia.org/wiki/ISO_8601#Time_intervals" />
        abstract toISODate: unit -> string
        /// <summary>
        /// Returns an ISO 8601-compliant string representation of time of this Interval.
        /// The date components are ignored.
        /// </summary>
        /// <seealso href="https://en.wikipedia.org/wiki/ISO_8601#Time_intervals" />
        /// <param name="opts">The same options as <see cref="DateTime.toISO" /></param>
        abstract toISOTime: ?opts: ToISOTimeOptions -> string
        /// <summary>Returns a string representation of this Interval formatted according to the specified format string.</summary>
        /// <param name="dateFormat">the format string. This string formats the start and end time. See <see cref="DateTime.toFormat" /> for details.</param>
        /// <param name="opts">options</param>
        /// <param name="opts.separator">a separator to place between the start and end representations. Defaults to ' - '.</param>
        abstract toFormat: dateFormat: string * ?opts: {| separator: string option |} -> string
        /// <summary>Return a Duration representing the time spanned by this interval.</summary>
        /// <param name="unit">the unit or units (such as 'hours' or 'days') to include in the duration. Defaults to ['milliseconds'].</param>
        /// <param name="opts">options that affect the creation of the Duration</param>
        /// <param name="opts.conversionAccuracy">the conversion system to use. Defaults to 'casual'.</param>
        /// <example>Interval.fromDateTimes(dt1, dt2).toDuration().toObject() //=&gt; { milliseconds: 88489257 }</example>
        /// <example>Interval.fromDateTimes(dt1, dt2).toDuration('days').toObject() //=&gt; { days: 1.0241812152777778 }</example>
        /// <example>Interval.fromDateTimes(dt1, dt2).toDuration(['hours', 'minutes']).toObject() //=&gt; { hours: 24, minutes: 34.82095 }</example>
        /// <example>Interval.fromDateTimes(dt1, dt2).toDuration(['hours', 'minutes', 'seconds']).toObject() //=&gt; { hours: 24, minutes: 34, seconds: 49.257 }</example>
        /// <example>Interval.fromDateTimes(dt1, dt2).toDuration('seconds').toObject() //=&gt; { seconds: 88489.257 }</example>
        abstract toDuration: ?unit: U2<Duration.DurationUnit, ResizeArray<Duration.DurationUnit>> * ?opts: DiffOptions -> Duration
        /// <summary>Run mapFn on the interval start and end, returning a new Interval from the resulting DateTimes</summary>
        /// <param name="mapFn" />
        /// <example>Interval.fromDateTimes(dt1, dt2).mapEndpoints(endpoint =&gt; endpoint.toUTC())</example>
        /// <example>Interval.fromDateTimes(dt1, dt2).mapEndpoints(endpoint =&gt; endpoint.plus({ hours: 2 }))</example>
        abstract mapEndpoints: mapFn: (DateTime -> DateTime) -> Interval

    /// <summary>
    /// An Interval object represents a half-open interval of time, where each endpoint is a <see cref="DateTime" />. Conceptually, it's a container for those two endpoints, accompanied by methods for
    /// creating, parsing, interrogating, comparing, transforming, and formatting them.
    ///
    /// Here is a brief overview of the most commonly used methods and getters in Interval:
    ///
    /// * **Creation** To create an Interval, use <see cref="Interval.fromDateTimes" />, <see cref="Interval.after" />, <see cref="Interval.before" />, or <see cref="Interval.fromISO" />.
    /// * **Accessors** Use <see cref="Interval.start" /> and <see cref="Interval.end" /> to get the start and end.
    /// * **Interrogation** To analyze the Interval, use <see cref="Interval.count" />, <see cref="Interval.length" />, <see cref="Interval.hasSame" />,
    /// * <see cref="Interval.contains" />, <see cref="Interval.isAfter" />, or <see cref="Interval.isBefore" />.
    /// * **Transformation** To create other Intervals out of this one, use <see cref="Interval.set" />, <see cref="Interval.splitAt" />, <see cref="Interval.splitBy" />, <see cref="Interval.divideEqually" />,
    /// * <see cref="Interval.merge" />, <see cref="Interval.xor" />, <see cref="Interval.union" />, <see cref="Interval.intersection" />, or <see cref="Interval.difference" />.
    /// * **Comparison** To compare this Interval to another one, use <see cref="Interval.equals" />, <see cref="Interval.overlaps" />, <see cref="Interval.abutsStart" />, <see cref="Interval.abutsEnd" />, <see cref="Interval.engulfs" />
    /// * **Output** To convert the Interval into other representations, see <see cref="Interval.toString" />, <see cref="Interval.toISO" />, <see cref="Interval.toISODate" />, <see cref="Interval.toISOTime" />,
    /// * <see cref="Interval.toFormat" />, and <see cref="Interval.toDuration" />.
    /// </summary>
    type [<AllowNullLiteral>] IntervalStatic =
        [<EmitConstructor>] abstract Create: unit -> Interval
        /// <summary>Create an invalid Interval.</summary>
        /// <param name="reason">simple string of why this Interval is invalid. Should not contain parameters or anything else data-dependent</param>
        /// <param name="explanation">longer explanation, may include parameters and other useful debugging information. Defaults to null.</param>
        abstract invalid: reason: string * ?explanation: string -> Interval
        /// <summary>Create an Interval from a start DateTime and an end DateTime. Inclusive of the start but not the end.</summary>
        /// <param name="start" />
        /// <param name="end" />
        abstract fromDateTimes: start: DateInput * ``end``: DateInput -> Interval
        abstract fromDateTimes: start: System.DateTime * ``end``: System.DateTime -> Interval
        abstract fromDateTimes: start: DateTime * ``end``: DateTime -> Interval
        /// <summary>Create an Interval from a start DateTime and a Duration to extend to.</summary>
        /// <param name="start" />
        /// <param name="duration">the length of the Interval.</param>
        abstract after: start: DateInput * duration: DurationLike -> Interval
        /// <summary>Create an Interval from an end DateTime and a Duration to extend backwards to.</summary>
        /// <param name="end" />
        /// <param name="duration">the length of the Interval.</param>
        abstract before: ``end``: DateInput * duration: DurationLike -> Interval
        /// <summary>
        /// Create an Interval from an ISO 8601 string.
        /// Accepts <c>&lt;start&gt;/&lt;end&gt;</c>, <c>&lt;start&gt;/&lt;duration&gt;</c>, and <c>&lt;duration&gt;/&lt;end&gt;</c> formats.
        /// </summary>
        /// <seealso href="https://en.wikipedia.org/wiki/ISO_8601#Time_intervals" />
        /// <param name="text">the ISO string to parse</param>
        /// <param name="opts">options to pass <see cref="DateTime.fromISO" /> and optionally <see cref="Duration.fromISO" /></param>
        abstract fromISO: text: string * ?opts: DateTimeOptions -> Interval
        /// <summary>Check if an object is an Interval. Works across context boundaries</summary>
        /// <param name="o" />
        abstract isInterval: o: obj -> bool
        /// <summary>
        /// Merge an array of Intervals into a equivalent minimal set of Intervals.
        /// Combines overlapping and adjacent Intervals.
        /// </summary>
        /// <param name="intervals" />
        abstract merge: intervals: ResizeArray<Interval> -> ResizeArray<Interval>
        /// <summary>Return an array of Intervals representing the spans of time that only appear in one of the specified Intervals.</summary>
        /// <param name="intervals" />
        abstract xor: intervals: ResizeArray<Interval> -> ResizeArray<Interval>

module Duration =

    type [<AllowNullLiteral>] IExports =
        /// <summary>
        /// A Duration object represents a period of time, like "2 months" or "1 day, 1 hour".
        /// Conceptually, it's just a map of units to their quantities, accompanied by some additional configuration and methods for creating, parsing, interrogating, transforming, and formatting them.
        /// They can be used on their own or in conjunction with other Luxon types; for example, you can use <see cref="DateTime.plus" /> to add a Duration object to a DateTime, producing another DateTime.
        ///
        /// Here is a brief overview of commonly used methods and getters in Duration:
        ///
        /// * **Creation** To create a Duration, use <see cref="Duration.fromMillis" />, <see cref="Duration.fromObject" />, or <see cref="Duration.fromISO" />.
        /// * **Unit values** See the <see cref="Duration.years" />, <see cref="Duration.months" />, <see cref="Duration.weeks" />, <see cref="Duration.days" />, <see cref="Duration.hours" />, <see cref="Duration.minutes" />,
        /// * <see cref="Duration.seconds" />, <see cref="Duration.milliseconds" /> accessors.
        /// * **Configuration** See  <see cref="Duration.locale" /> and <see cref="Duration.numberingSystem" /> accessors.
        /// * **Transformation** To create new Durations out of old ones use <see cref="Duration.plus" />, <see cref="Duration.minus" />, <see cref="Duration.normalize" />, <see cref="Duration.set" />, <see cref="Duration.reconfigure" />,
        /// * <see cref="Duration.shiftTo" />, and <see cref="Duration.negate" />.
        /// * **Output** To convert the Duration into other representations, see <see cref="Duration.as" />, <see cref="Duration.toISO" />, <see cref="Duration.toFormat" />, and <see cref="Duration.toJSON" />
        ///
        /// There's are more methods documented below. In addition, for more information on subtler topics like internationalization and validity, see the external documentation.
        /// </summary>
        abstract Duration: DurationStatic

    type [<AllowNullLiteral>] DurationOptions =
        abstract locale: string option with get, set
        abstract numberingSystem: NumberingSystem option with get, set
        abstract conversionAccuracy: ConversionAccuracy option with get, set

    type [<AllowNullLiteral>] DurationObjectUnits =
        abstract years: float option with get, set
        abstract quarters: float option with get, set
        abstract months: float option with get, set
        abstract weeks: float option with get, set
        abstract days: float option with get, set
        abstract hours: float option with get, set
        abstract minutes: float option with get, set
        abstract seconds: float option with get, set
        abstract milliseconds: float option with get, set

    type [<AllowNullLiteral>] DurationLikeObject =
        inherit DurationObjectUnits
        abstract year: float option with get, set
        abstract quarter: float option with get, set
        abstract month: float option with get, set
        abstract week: float option with get, set
        abstract day: float option with get, set
        abstract hour: float option with get, set
        abstract minute: float option with get, set
        abstract second: float option with get, set
        abstract millisecond: float option with get, set

    [<StringEnum>]
    [<RequireQualifiedAccess>]
    type DurationUnit =
        | Years
        | Quarters
        | Months
        | Weeks
        | Days
        | Hours
        | Minutes
        | Seconds
        | Milliseconds
        | Year
        | Quarter
        | Month
        | Week
        | Day
        | Hour
        | Minute
        | Second
        | Millisecond

    type DurationUnits =
        U2<DurationUnit, ResizeArray<DurationUnit>>

    type [<StringEnum>] [<RequireQualifiedAccess>] ToISOFormat =
        | Basic
        | Extended

    type [<AllowNullLiteral>] ToISOTimeDurationOptions =
        /// <summary>Include the <c>T</c> prefix</summary>
        /// <default>false</default>
        abstract includePrefix: bool option with get, set
        /// <summary>Exclude milliseconds from the format if they're 0</summary>
        /// <default>false</default>
        abstract suppressMilliseconds: bool option with get, set
        /// <summary>Exclude seconds from the format if they're 0</summary>
        /// <default>false</default>
        abstract suppressSeconds: bool option with get, set
        /// <summary>Choose between the basic and extended format</summary>
        /// <default>'extended'</default>
        abstract format: ToISOFormat option with get, set

    type [<AllowNullLiteral>] ToHumanDurationOptions =
        inherit Intl.NumberFormatOptions
        abstract listStyle: ToHumanDurationOptionsListStyle option with get, set

    /// Either a Luxon Duration, a number of milliseconds, the object argument to Duration.fromObject()
    [<Obsolete("Use DurationLike instead.")>]
    type DurationInput =
        U3<Duration, float, DurationLikeObject>

    /// Either a Luxon Duration, a number of milliseconds, the object argument to Duration.fromObject()
    type DurationLike =
        U3<Duration, DurationLikeObject, float>

    /// <summary>
    /// A Duration object represents a period of time, like "2 months" or "1 day, 1 hour".
    /// Conceptually, it's just a map of units to their quantities, accompanied by some additional configuration and methods for creating, parsing, interrogating, transforming, and formatting them.
    /// They can be used on their own or in conjunction with other Luxon types; for example, you can use <see cref="DateTime.plus" /> to add a Duration object to a DateTime, producing another DateTime.
    ///
    /// Here is a brief overview of commonly used methods and getters in Duration:
    ///
    /// * **Creation** To create a Duration, use <see cref="Duration.fromMillis" />, <see cref="Duration.fromObject" />, or <see cref="Duration.fromISO" />.
    /// * **Unit values** See the <see cref="Duration.years" />, <see cref="Duration.months" />, <see cref="Duration.weeks" />, <see cref="Duration.days" />, <see cref="Duration.hours" />, <see cref="Duration.minutes" />,
    /// * <see cref="Duration.seconds" />, <see cref="Duration.milliseconds" /> accessors.
    /// * **Configuration** See  <see cref="Duration.locale" /> and <see cref="Duration.numberingSystem" /> accessors.
    /// * **Transformation** To create new Durations out of old ones use <see cref="Duration.plus" />, <see cref="Duration.minus" />, <see cref="Duration.normalize" />, <see cref="Duration.set" />, <see cref="Duration.reconfigure" />,
    /// * <see cref="Duration.shiftTo" />, and <see cref="Duration.negate" />.
    /// * **Output** To convert the Duration into other representations, see <see cref="Duration.as" />, <see cref="Duration.toISO" />, <see cref="Duration.toFormat" />, and <see cref="Duration.toJSON" />
    ///
    /// There's are more methods documented below. In addition, for more information on subtler topics like internationalization and validity, see the external documentation.
    /// </summary>
    type [<AllowNullLiteral>] Duration =
        /// Get  the locale of a Duration, such 'en-GB'
        abstract locale: string
        /// Get the numbering system of a Duration, such 'beng'. The numbering system is used when formatting the Duration
        abstract numberingSystem: string
        /// <summary>
        /// Returns a string representation of this Duration formatted according to the specified format string. You may use these tokens:
        /// * <c>S</c> for milliseconds
        /// * <c>s</c> for seconds
        /// * <c>m</c> for minutes
        /// * <c>h</c> for hours
        /// * <c>d</c> for days
        /// * <c>M</c> for months
        /// * <c>y</c> for years
        /// Notes:
        /// * Add padding by repeating the token, e.g. "yy" pads the years to two digits, "hhhh" pads the hours out to four digits
        /// * The duration will be converted to the set of units in the format string using <see cref="Duration.shiftTo" /> and the Durations's conversion accuracy setting.
        /// </summary>
        /// <param name="fmt">the format string</param>
        /// <param name="opts">options</param>
        /// <param name="opts.floor">floor numerical values. Defaults to true.</param>
        /// <example>Duration.fromObject({ years: 1, days: 6, seconds: 2 }).toFormat("y d s") //=&gt; "1 6 2"</example>
        /// <example>Duration.fromObject({ years: 1, days: 6, seconds: 2 }).toFormat("yy dd sss") //=&gt; "01 06 002"</example>
        /// <example>Duration.fromObject({ years: 1, days: 6, seconds: 2 }).toFormat("M S") //=&gt; "12 518402000"</example>
        abstract toFormat: fmt: string * ?opts: {| floor: bool option |} -> string
        /// <summary>
        /// Returns a string representation of a Duration with all units included
        /// To modify its behavior use the <c>listStyle</c> and any Intl.NumberFormat option, though <c>unitDisplay</c> is especially relevant. See <see cref="Intl.NumberFormat" />.
        /// </summary>
        /// <param name="opts">On option object to override the formatting. Accepts the same keys as the options parameter of the native <c>Int.NumberFormat</c> constructor, as well as <c>listStyle</c>.</param>
        /// <example>
        /// <code lang="js">
        /// var dur = Duration.fromObject({ days: 1, hours: 5, minutes: 6 })
        /// dur.toHuman() //=&gt; '1 day, 5 hours, 6 minutes'
        /// dur.toHuman({ listStyle: "long" }) //=&gt; '1 day, 5 hours, and 6 minutes'
        /// dur.toHuman({ unitDisplay: "short" }) //=&gt; '1 day, 5 hr, 6 min'
        /// </code>
        /// </example>
        abstract toHuman: ?opts: ToHumanDurationOptions -> string
        /// <summary>Returns a JavaScript object with this Duration's values.</summary>
        /// <example>Duration.fromObject({ years: 1, days: 6, seconds: 2 }).toObject() //=&gt; { years: 1, days: 6, seconds: 2 }</example>
        abstract toObject: unit -> DurationObjectUnits
        /// <summary>Returns an ISO 8601-compliant string representation of this Duration.</summary>
        /// <seealso href="https://en.wikipedia.org/wiki/ISO_8601#Durations" />
        /// <example>Duration.fromObject({ years: 3, seconds: 45 }).toISO() //=&gt; 'P3YT45S'</example>
        /// <example>Duration.fromObject({ months: 4, seconds: 45 }).toISO() //=&gt; 'P4MT45S'</example>
        /// <example>Duration.fromObject({ months: 5 }).toISO() //=&gt; 'P5M'</example>
        /// <example>Duration.fromObject({ minutes: 5 }).toISO() //=&gt; 'PT5M'</example>
        /// <example>Duration.fromObject({ milliseconds: 6 }).toISO() //=&gt; 'PT0.006S'</example>
        abstract toISO: unit -> string
        /// <summary>Returns an ISO 8601-compliant string representation of this Duration, formatted as a time of day.</summary>
        /// <seealso href="https://en.wikipedia.org/wiki/ISO_8601#Times" />
        /// <param name="opts">options</param>
        /// <param name="opts.suppressMilliseconds">exclude milliseconds from the format if they're 0. Defaults to false.</param>
        /// <param name="opts.suppressSeconds">exclude seconds from the format if they're 0. Defaults to false.</param>
        /// <param name="opts.includePrefix">include the <c>T</c> prefix. Defaults to false.</param>
        /// <param name="opts.format">choose between the basic and extended format. Defaults to 'extended'.</param>
        /// <example>Duration.fromObject({ hours: 11 }).toISOTime() //=&gt; '11:00:00.000'</example>
        /// <example>Duration.fromObject({ hours: 11 }).toISOTime({ suppressMilliseconds: true }) //=&gt; '11:00:00'</example>
        /// <example>Duration.fromObject({ hours: 11 }).toISOTime({ suppressSeconds: true }) //=&gt; '11:00'</example>
        /// <example>Duration.fromObject({ hours: 11 }).toISOTime({ includePrefix: true }) //=&gt; 'T11:00:00.000'</example>
        /// <example>Duration.fromObject({ hours: 11 }).toISOTime({ format: 'basic' }) //=&gt; '110000.000'</example>
        abstract toISOTime: ?opts: ToISOTimeDurationOptions -> string
        /// Returns an ISO 8601 representation of this Duration appropriate for use in JSON.
        abstract toJSON: unit -> string
        /// Returns an ISO 8601 representation of this Duration appropriate for use in debugging.
        abstract toString: unit -> string
        /// Returns an milliseconds value of this Duration.
        abstract toMillis: unit -> float
        /// <summary>Returns an milliseconds value of this Duration. Alias of <see cref="toMillis" /></summary>
        abstract valueOf: unit -> float
        /// <summary>Make this Duration longer by the specified amount. Return a newly-constructed Duration.</summary>
        /// <param name="duration">The amount to add. Either a Luxon Duration, a number of milliseconds, the object argument to Duration.fromObject()</param>
        abstract plus: duration: DurationLike -> Duration
        /// <summary>Make this Duration shorter by the specified amount. Return a newly-constructed Duration.</summary>
        /// <param name="duration">The amount to subtract. Either a Luxon Duration, a number of milliseconds, the object argument to Duration.fromObject()</param>
        abstract minus: duration: DurationLike -> Duration
        /// <summary>Scale this Duration by the specified amount. Return a newly-constructed Duration.</summary>
        /// <example>Duration.fromObject({ hours: 1, minutes: 30 }).mapUnit(x =&gt; x * 2) //=&gt; { hours: 2, minutes: 60 }</example>
        /// <example>Duration.fromObject({ hours: 1, minutes: 30 }).mapUnit((x, u) =&gt; u === "hour" ? x * 2 : x) //=&gt; { hours: 2, minutes: 30 }</example>
        abstract mapUnits: fn: (float -> (DurationUnit) option -> float) -> Duration
        /// <summary>Get the value of unit.</summary>
        /// <param name="unit">a unit such as 'minute' or 'day'</param>
        /// <example>Duration.fromObject({years: 2, days: 3}).get('years') //=&gt; 2</example>
        /// <example>Duration.fromObject({years: 2, days: 3}).get('months') //=&gt; 0</example>
        /// <example>Duration.fromObject({years: 2, days: 3}).get('days') //=&gt; 3</example>
        abstract get: unit: DurationUnit -> float
        /// <summary>"Set" the values of specified units. Return a newly-constructed Duration.</summary>
        /// <param name="values">a mapping of units to numbers</param>
        /// <example>dur.set({ years: 2017 })</example>
        /// <example>dur.set({ hours: 8, minutes: 30 })</example>
        abstract set: values: DurationLikeObject -> Duration
        /// <summary>"Set" the locale and/or numberingSystem.  Returns a newly-constructed Duration.</summary>
        /// <example>dur.reconfigure({ locale: 'en-GB' })</example>
        abstract reconfigure: ?opts: DurationOptions -> Duration
        /// <summary>Return the length of the duration in the specified unit.</summary>
        /// <param name="unit">a unit such as 'minutes' or 'days'</param>
        /// <example>Duration.fromObject({years: 1}).as('days') //=&gt; 365</example>
        /// <example>Duration.fromObject({years: 1}).as('months') //=&gt; 12</example>
        /// <example>Duration.fromObject({hours: 60}).as('days') //=&gt; 2.5</example>
        abstract ``as``: unit: DurationUnit -> float
        /// <summary>Reduce this Duration to its canonical representation in its current units.</summary>
        /// <example>Duration.fromObject({ years: 2, days: 5000 }).normalize().toObject() //=&gt; { years: 15, days: 255 }</example>
        /// <example>Duration.fromObject({ hours: 12, minutes: -45 }).normalize().toObject() //=&gt; { hours: 11, minutes: 15 }</example>
        abstract normalize: unit -> Duration
        /// <summary>Convert this Duration into its representation in a different set of units.</summary>
        /// <example>Duration.fromObject({ hours: 1, seconds: 30 }).shiftTo('minutes', 'milliseconds').toObject() //=&gt; { minutes: 60, milliseconds: 30000 }</example>
        abstract shiftTo: [<ParamArray>] units: DurationUnit[] -> Duration
        /// <summary>Return the negative of this Duration.</summary>
        /// <example>Duration.fromObject({ hours: 1, seconds: 30 }).negate().toObject() //=&gt; { hours: -1, seconds: -30 }</example>
        abstract negate: unit -> Duration
        /// Get the years.
        abstract years: float
        /// Get the quarters.
        abstract quarters: float
        /// Get the months.
        abstract months: float
        /// Get the weeks
        abstract weeks: float
        /// Get the days.
        abstract days: float
        /// Get the hours.
        abstract hours: float
        /// Get the minutes.
        abstract minutes: float
        /// Get the seconds.
        abstract seconds: float
        /// Get the milliseconds.
        abstract milliseconds: float
        /// Returns whether the Duration is invalid. Invalid durations are returned by diff operations
        /// on invalid DateTimes or Intervals.
        abstract isValid: bool
        /// Returns an error code if this Duration became invalid, or null if the Duration is valid
        abstract invalidReason: string
        /// Returns an explanation of why this Duration became invalid, or null if the Duration is valid
        abstract invalidExplanation: string
        /// <summary>
        /// Equality check
        /// Two Durations are equal iff they have the same units and the same values for each unit.
        /// </summary>
        /// <param name="other" />
        abstract equals: other: Duration -> bool

    /// <summary>
    /// A Duration object represents a period of time, like "2 months" or "1 day, 1 hour".
    /// Conceptually, it's just a map of units to their quantities, accompanied by some additional configuration and methods for creating, parsing, interrogating, transforming, and formatting them.
    /// They can be used on their own or in conjunction with other Luxon types; for example, you can use <see cref="DateTime.plus" /> to add a Duration object to a DateTime, producing another DateTime.
    ///
    /// Here is a brief overview of commonly used methods and getters in Duration:
    ///
    /// * **Creation** To create a Duration, use <see cref="Duration.fromMillis" />, <see cref="Duration.fromObject" />, or <see cref="Duration.fromISO" />.
    /// * **Unit values** See the <see cref="Duration.years" />, <see cref="Duration.months" />, <see cref="Duration.weeks" />, <see cref="Duration.days" />, <see cref="Duration.hours" />, <see cref="Duration.minutes" />,
    /// * <see cref="Duration.seconds" />, <see cref="Duration.milliseconds" /> accessors.
    /// * **Configuration** See  <see cref="Duration.locale" /> and <see cref="Duration.numberingSystem" /> accessors.
    /// * **Transformation** To create new Durations out of old ones use <see cref="Duration.plus" />, <see cref="Duration.minus" />, <see cref="Duration.normalize" />, <see cref="Duration.set" />, <see cref="Duration.reconfigure" />,
    /// * <see cref="Duration.shiftTo" />, and <see cref="Duration.negate" />.
    /// * **Output** To convert the Duration into other representations, see <see cref="Duration.as" />, <see cref="Duration.toISO" />, <see cref="Duration.toFormat" />, and <see cref="Duration.toJSON" />
    ///
    /// There's are more methods documented below. In addition, for more information on subtler topics like internationalization and validity, see the external documentation.
    /// </summary>
    type [<AllowNullLiteral>] DurationStatic =
        [<EmitConstructor>] abstract Create: unit -> Duration
        /// <summary>Create Duration from a number of milliseconds.</summary>
        /// <param name="count">of milliseconds</param>
        /// <param name="opts">options for parsing</param>
        /// <param name="opts.locale">the locale to use</param>
        /// <param name="opts.numberingSystem">the numbering system to use</param>
        /// <param name="opts.conversionAccuracy">the conversion system to use</param>
        abstract fromMillis: count: float * ?opts: DurationOptions -> Duration
        /// <summary>
        /// Create a Duration from a JavaScript object with keys like 'years' and 'hours'.
        /// If this object is empty then a zero milliseconds duration is returned.
        /// </summary>
        /// <param name="obj">the object to create the DateTime from</param>
        /// <param name="obj.years" />
        /// <param name="obj.quarters" />
        /// <param name="obj.months" />
        /// <param name="obj.weeks" />
        /// <param name="obj.days" />
        /// <param name="obj.hours" />
        /// <param name="obj.minutes" />
        /// <param name="obj.seconds" />
        /// <param name="obj.milliseconds" />
        /// <param name="opts">options for creating this Duration. Defaults to {}.</param>
        /// <param name="opts.locale">the locale to use. Defaults to 'en-US'.</param>
        /// <param name="opts.numberingSystem">the numbering system to use</param>
        /// <param name="opts.conversionAccuracy">the conversion system to use. Defaults to 'casual'.</param>
        abstract fromObject: obj: DurationLikeObject * ?opts: DurationOptions -> Duration
        /// <summary>Create a Duration from DurationLike.</summary>
        /// <param name="durationLike">Either a Luxon Duration, a number of milliseconds, or the object argument to Duration.fromObject()</param>
        abstract fromDurationLike: durationLike: DurationLike -> Duration
        /// <summary>Create a Duration from an ISO 8601 duration string.</summary>
        /// <seealso href="https://en.wikipedia.org/wiki/ISO_8601#Durations" />
        /// <param name="text">text to parse</param>
        /// <param name="opts">options for parsing</param>
        /// <param name="opts.locale">the locale to use. Defaults to 'en-US'.</param>
        /// <param name="opts.numberingSystem">the numbering system to use</param>
        /// <param name="opts.conversionAccuracy">the conversion system to use. Defaults to 'casual'.</param>
        /// <example>Duration.fromISO('P3Y6M1W4DT12H30M5S').toObject() //=&gt; { years: 3, months: 6, weeks: 1, days: 4, hours: 12, minutes: 30, seconds: 5 }</example>
        /// <example>Duration.fromISO('PT23H').toObject() //=&gt; { hours: 23 }</example>
        /// <example>Duration.fromISO('P5Y3M').toObject() //=&gt; { years: 5, months: 3 }</example>
        abstract fromISO: text: string * ?opts: DurationOptions -> Duration
        /// <summary>Create a Duration from an ISO 8601 time string.</summary>
        /// <seealso href="https://en.wikipedia.org/wiki/ISO_8601#Times" />
        /// <param name="text">text to parse</param>
        /// <param name="opts">options for parsing</param>
        /// <param name="opts.locale">the locale to use. Defaults to 'en-US'.</param>
        /// <param name="opts.numberingSystem">the numbering system to use</param>
        /// <param name="opts.conversionAccuracy">the conversion system to use. Defaults to 'casual'.</param>
        /// <example>Duration.fromISOTime('11:22:33.444').toObject() //=&gt; { hours: 11, minutes: 22, seconds: 33, milliseconds: 444 }</example>
        /// <example>Duration.fromISOTime('11:00').toObject() //=&gt; { hours: 11, minutes: 0, seconds: 0 }</example>
        /// <example>Duration.fromISOTime('T11:00').toObject() //=&gt; { hours: 11, minutes: 0, seconds: 0 }</example>
        /// <example>Duration.fromISOTime('1100').toObject() //=&gt; { hours: 11, minutes: 0, seconds: 0 }</example>
        /// <example>Duration.fromISOTime('T1100').toObject() //=&gt; { hours: 11, minutes: 0, seconds: 0 }</example>
        abstract fromISOTime: text: string * ?opts: DurationOptions -> Duration
        /// <summary>Create an invalid Duration.</summary>
        /// <param name="reason">simple string of why this datetime is invalid. Should not contain parameters or anything else data-dependent</param>
        /// <param name="explanation">longer explanation, may include parameters and other useful debugging information. Defaults to null.</param>
        abstract invalid: reason: string * ?explanation: string -> Duration
        /// <summary>Check if an object is a Duration. Works across context boundaries</summary>
        /// <param name="o" />
        abstract isDuration: o: obj -> bool

    type [<StringEnum>] [<RequireQualifiedAccess>] ToHumanDurationOptionsListStyle =
        | Long
        | Short
        | Narrow
