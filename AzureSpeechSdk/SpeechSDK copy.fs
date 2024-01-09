// ts2fable 0.9.0
module rec SpeechSDK

// #nowarn "3390" // disable warnings for invalid XML comments
// #nowarn "0044" // disable warnings for `Obsolete` usage

open System
open Fable.Core
open Fable.Core.JS
open Browser.Types

type Error = System.Exception

type PathLike = PathLike
let [<Import("OutputFormatPropertyName","module")>] OutputFormatPropertyName: string = jsNative
let [<Import("CancellationErrorCodePropertyName","module")>] CancellationErrorCodePropertyName: string = jsNative
let [<Import("ServicePropertiesPropertyName","module")>] ServicePropertiesPropertyName: string = jsNative
let [<Import("ForceDictationPropertyName","module")>] ForceDictationPropertyName: string = jsNative
let [<Import("AutoDetectSourceLanguagesOpenRangeOptionName","module")>] AutoDetectSourceLanguagesOpenRangeOptionName: string = jsNative
/// List of command message types
let [<Import("ConversationTranslatorMessageTypes","module")>] ConversationTranslatorMessageTypes: ConversationTranslatorMessageTypes = jsNative
/// List of command types
let [<Import("ConversationTranslatorCommandTypes","module")>] ConversationTranslatorCommandTypes: ConversationTranslatorCommandTypes = jsNative
let [<Import("AudioWorkletSourceURLPropertyName","module")>] AudioWorkletSourceURLPropertyName: obj = jsNative

type [<AllowNullLiteral>] IExports =
    /// <summary>Represents audio input configuration used for specifying what type of input to use (microphone, file, stream).</summary>
    abstract AudioConfig: AudioConfigStatic
    /// <summary>Represents audio input stream used for custom audio input configurations.</summary>
    abstract AudioConfigImpl: AudioConfigImplStatic
    abstract AudioOutputConfigImpl: AudioOutputConfigImplStatic
    /// <summary>Represents audio stream format used for custom audio input configurations.</summary>
    abstract AudioStreamFormat: AudioStreamFormatStatic
    abstract AudioStreamFormatImpl: AudioStreamFormatImplStatic
    /// <summary>Represents audio input stream used for custom audio input configurations.</summary>
    abstract AudioInputStream: AudioInputStreamStatic
    /// <summary>Represents memory backed push audio input stream used for custom audio input configurations.</summary>
    abstract PushAudioInputStream: PushAudioInputStreamStatic
    /// <summary>Represents memory backed push audio input stream used for custom audio input configurations.</summary>
    abstract PushAudioInputStreamImpl: PushAudioInputStreamImplStatic
    abstract PullAudioInputStream: PullAudioInputStreamStatic
    /// <summary>Represents audio input stream used for custom audio input configurations.</summary>
    abstract PullAudioInputStreamImpl: PullAudioInputStreamImplStatic
    /// <summary>Represents audio output stream used for custom audio output configurations.</summary>
    abstract AudioOutputStream: AudioOutputStreamStatic
    /// <summary>Represents memory backed push audio output stream used for custom audio output configurations.</summary>
    abstract PullAudioOutputStream: PullAudioOutputStreamStatic
    /// <summary>Represents memory backed push audio output stream used for custom audio output configurations.</summary>
    abstract PullAudioOutputStreamImpl: PullAudioOutputStreamImplStatic
    abstract PushAudioOutputStream: PushAudioOutputStreamStatic
    /// <summary>Represents audio output stream used for custom audio output configurations.</summary>
    abstract PushAudioOutputStreamImpl: PushAudioOutputStreamImplStatic
    /// <summary>
    /// An abstract base class that defines callback methods (read() and close()) for
    /// custom audio input streams).
    /// </summary>
    abstract PullAudioInputStreamCallback: PullAudioInputStreamCallbackStatic
    /// <summary>
    /// An abstract base class that defines callback methods (write() and close()) for
    /// custom audio output streams).
    /// </summary>
    abstract PushAudioOutputStreamCallback: PushAudioOutputStreamCallbackStatic
    /// <summary>
    /// Represents a keyword recognition model for recognizing when
    /// the user says a keyword to initiate further speech recognition.
    /// </summary>
    abstract KeywordRecognitionModel: KeywordRecognitionModelStatic
    /// <summary>Defines content for session events like SessionStarted/Stopped, SoundStarted/Stopped.</summary>
    abstract SessionEventArgs: SessionEventArgsStatic
    /// <summary>Defines payload for session events like Speech Start/End Detected</summary>
    abstract RecognitionEventArgs: RecognitionEventArgsStatic
    /// <summary>Intent recognition result event arguments.</summary>
    abstract IntentRecognitionEventArgs: IntentRecognitionEventArgsStatic
    /// <summary>Defines result of speech recognition.</summary>
    abstract RecognitionResult: RecognitionResultStatic
    /// <summary>Defines result of speech recognition.</summary>
    abstract SpeechRecognitionResult: SpeechRecognitionResultStatic
    /// <summary>Intent recognition result.</summary>
    abstract IntentRecognitionResult: IntentRecognitionResultStatic
    /// <summary>Language understanding model</summary>
    abstract LanguageUnderstandingModel: LanguageUnderstandingModelStatic
    abstract LanguageUnderstandingModelImpl: LanguageUnderstandingModelImplStatic
    /// <summary>Defines contents of speech recognizing/recognized event.</summary>
    abstract SpeechRecognitionEventArgs: SpeechRecognitionEventArgsStatic
    /// <summary>Defines contents of conversation transcribed/transcribing event.</summary>
    abstract ConversationTranscriptionEventArgs: ConversationTranscriptionEventArgsStatic
    /// <summary>Defines contents of meeting transcribed/transcribing event.</summary>
    abstract MeetingTranscriptionEventArgs: MeetingTranscriptionEventArgsStatic
    abstract SpeechRecognitionCanceledEventArgs: SpeechRecognitionCanceledEventArgsStatic
    /// <summary>Translation text result event arguments.</summary>
    abstract TranslationRecognitionEventArgs: TranslationRecognitionEventArgsStatic
    /// <summary>Translation Synthesis event arguments</summary>
    abstract TranslationSynthesisEventArgs: TranslationSynthesisEventArgsStatic
    /// <summary>Translation text result.</summary>
    abstract TranslationRecognitionResult: TranslationRecognitionResultStatic
    /// <summary>
    /// Defines translation synthesis result, i.e. the voice output of the translated
    /// text in the target language.
    /// </summary>
    abstract TranslationSynthesisResult: TranslationSynthesisResultStatic
    /// <summary>Speech configuration.</summary>
    abstract SpeechConfig: SpeechConfigStatic
    abstract SpeechConfigImpl: SpeechConfigImplStatic
    /// <summary>Speech translation configuration.</summary>
    abstract SpeechTranslationConfig: SpeechTranslationConfigStatic
    abstract SpeechTranslationConfigImpl: SpeechTranslationConfigImplStatic
    /// <summary>Represents collection of properties and their values.</summary>
    abstract PropertyCollection: PropertyCollectionStatic
    /// <summary>Defines the base class Recognizer which mainly contains common event handlers.</summary>
    abstract Recognizer: RecognizerStatic
    /// <summary>Performs speech recognition from microphone, file, or other audio input streams, and gets transcribed text as result.</summary>
    abstract SpeechRecognizer: SpeechRecognizerStatic
    /// <summary>Intent recognizer.</summary>
    abstract IntentRecognizer: IntentRecognizerStatic
    /// <summary>Translation recognizer</summary>
    abstract TranslationRecognizer: TranslationRecognizerStatic
    /// <summary>Represents collection of parameters and their values.</summary>
    abstract Translations: TranslationsStatic
    /// <summary>Contains detailed information for NoMatch recognition results.</summary>
    abstract NoMatchDetails: NoMatchDetailsStatic
    /// <summary>Define payload of speech recognition canceled result events.</summary>
    abstract TranslationRecognitionCanceledEventArgs: TranslationRecognitionCanceledEventArgsStatic
    /// <summary>Define payload of intent recognition canceled result events.</summary>
    abstract IntentRecognitionCanceledEventArgs: IntentRecognitionCanceledEventArgsStatic
    /// <summary>Contains detailed information about why a result was canceled.</summary>
    abstract CancellationDetailsBase: CancellationDetailsBaseStatic
    /// <summary>Contains detailed information about why a result was canceled.</summary>
    abstract CancellationDetails: CancellationDetailsStatic
    /// Defines payload for connection events like Connected/Disconnected.
    /// Added in version 1.2.0
    abstract ConnectionEventArgs: ConnectionEventArgsStatic
    /// Defines payload for any Service message event
    /// Added in version 1.9.0
    abstract ServiceEventArgs: ServiceEventArgsStatic
    /// Connection is a proxy class for managing connection to the speech service of the specified Recognizer.
    /// By default, a Recognizer autonomously manages connection to service when needed.
    /// The Connection class provides additional methods for users to explicitly open or close a connection and
    /// to subscribe to connection status changes.
    /// The use of Connection is optional, and mainly for scenarios where fine tuning of application
    /// behavior based on connection status is needed. Users can optionally call Open() to manually set up a connection
    /// in advance before starting recognition on the Recognizer associated with this Connection.
    /// If the Recognizer needs to connect or disconnect to service, it will
    /// setup or shutdown the connection independently. In this case the Connection will be notified by change of connection
    /// status via Connected/Disconnected events.
    /// Added in version 1.2.1.
    abstract Connection: ConnectionStatic
    /// Allows additions of new phrases to improve speech recognition.
    ///
    /// Phrases added to the recognizer are effective at the start of the next recognition, or the next time the SpeechSDK must reconnect
    /// to the speech service.
    abstract PhraseListGrammar: PhraseListGrammarStatic
    /// <summary>Class that defines base configurations for dialog service connector</summary>
    abstract DialogServiceConfig: DialogServiceConfigStatic
    /// <summary>Dialog Service configuration.</summary>
    abstract DialogServiceConfigImpl: DialogServiceConfigImplStatic
    /// <summary>Class that defines configurations for the dialog service connector object for using a Bot Framework backend.</summary>
    abstract BotFrameworkConfig: BotFrameworkConfigStatic
    /// <summary>Class that defines configurations for the dialog service connector object for using a CustomCommands backend.</summary>
    abstract CustomCommandsConfig: CustomCommandsConfigStatic
    /// <summary>Dialog Service Connector</summary>
    abstract DialogServiceConnector: DialogServiceConnectorStatic
    /// <summary>Defines contents of received message/events.</summary>
    abstract ActivityReceivedEventArgs: ActivityReceivedEventArgsStatic
    /// <summary>Defines contents of received message/events.</summary>
    abstract TurnStatusReceivedEventArgs: TurnStatusReceivedEventArgsStatic
    /// <summary>
    /// Base audio player class
    /// TODO: Plays only PCM for now.
    /// </summary>
    abstract BaseAudioPlayer: BaseAudioPlayerStatic
    abstract ConnectionMessageEventArgs: ConnectionMessageEventArgsStatic
    /// ConnectionMessage represents implementation specific messages sent to and received from
    /// the speech service. These messages are provided for debugging purposes and should not
    /// be used for production use cases with the Azure Cognitive Services Speech Service.
    /// Messages sent to and received from the Speech Service are subject to change without
    /// notice. This includes message contents, headers, payloads, ordering, etc.
    /// Added in version 1.11.0.
    abstract ConnectionMessage: ConnectionMessageStatic
    abstract ConnectionMessageImpl: ConnectionMessageImplStatic
    /// <summary>Defines Voice Profile class for Speaker Recognition</summary>
    abstract VoiceProfile: VoiceProfileStatic
    /// <summary>Output format</summary>
    abstract VoiceProfileEnrollmentResult: VoiceProfileEnrollmentResultStatic
    abstract VoiceProfileEnrollmentCancellationDetails: VoiceProfileEnrollmentCancellationDetailsStatic
    /// <summary>Output format</summary>
    abstract VoiceProfileResult: VoiceProfileResultStatic
    abstract VoiceProfileCancellationDetails: VoiceProfileCancellationDetailsStatic
    /// <summary>Output format</summary>
    abstract VoiceProfilePhraseResult: VoiceProfilePhraseResultStatic
    /// <summary>
    /// Defines VoiceProfileClient class for Speaker Recognition
    /// Handles operations from user for Voice Profile operations (e.g. createProfile, deleteProfile)
    /// </summary>
    abstract VoiceProfileClient: VoiceProfileClientStatic
    /// <summary>
    /// Defines SpeakerRecognizer class for Speaker Recognition
    /// Handles operations from user for Voice Profile operations (e.g. createProfile, deleteProfile)
    /// </summary>
    abstract SpeakerRecognizer: SpeakerRecognizerStatic
    /// <summary>
    /// Defines SpeakerIdentificationModel class for Speaker Recognition
    /// Model contains a set of profiles against which to identify speaker(s)
    /// </summary>
    abstract SpeakerIdentificationModel: SpeakerIdentificationModelStatic
    /// <summary>
    /// Defines SpeakerVerificationModel class for Speaker Recognition
    /// Model contains a profile against which to verify a speaker
    /// </summary>
    abstract SpeakerVerificationModel: SpeakerVerificationModelStatic
    /// <summary>Language auto detect configuration.</summary>
    abstract AutoDetectSourceLanguageConfig: AutoDetectSourceLanguageConfigStatic
    /// <summary>Output format</summary>
    abstract AutoDetectSourceLanguageResult: AutoDetectSourceLanguageResultStatic
    /// <summary>Source Language configuration.</summary>
    abstract SourceLanguageConfig: SourceLanguageConfigStatic
    /// <summary>Output format</summary>
    abstract SpeakerRecognitionResult: SpeakerRecognitionResultStatic
    abstract SpeakerRecognitionCancellationDetails: SpeakerRecognitionCancellationDetailsStatic
    /// <summary>
    /// Defines the class SpeechSynthesizer for text to speech.
    /// Updated in version 1.16.0
    /// </summary>
    abstract SpeechSynthesizer: SpeechSynthesizerStatic
    abstract SynthesisRequest: SynthesisRequestStatic
    /// <summary>Base class for synthesis results</summary>
    abstract SynthesisResult: SynthesisResultStatic
    /// <summary>Defines result of speech synthesis.</summary>
    abstract SpeechSynthesisResult: SpeechSynthesisResultStatic
    /// <summary>Defines contents of speech synthesis events.</summary>
    abstract SpeechSynthesisEventArgs: SpeechSynthesisEventArgsStatic
    /// <summary>Defines contents of speech synthesis word boundary event.</summary>
    abstract SpeechSynthesisWordBoundaryEventArgs: SpeechSynthesisWordBoundaryEventArgsStatic
    /// <summary>Defines contents of speech synthesis bookmark event.</summary>
    abstract SpeechSynthesisBookmarkEventArgs: SpeechSynthesisBookmarkEventArgsStatic
    /// <summary>Defines contents of speech synthesis viseme event.</summary>
    abstract SpeechSynthesisVisemeEventArgs: SpeechSynthesisVisemeEventArgsStatic
    /// <summary>Defines result of speech synthesis.</summary>
    abstract SynthesisVoicesResult: SynthesisVoicesResultStatic
    /// <summary>
    /// Information about Speech Synthesis voice
    /// Added in version 1.20.0.
    /// </summary>
    abstract VoiceInfo: VoiceInfoStatic
    /// <summary>
    /// Represents the speaker playback audio destination, which only works in browser.
    /// Note: the SDK will try to use &lt;a href="<see href="https://www.w3.org/TR/media-source/"&gt;Media" /> Source Extensions&lt;/a&gt; to play audio.
    /// Mp3 format has better supports on Microsoft Edge, Chrome and Safari (desktop), so, it's better to specify mp3 format for playback.
    /// </summary>
    abstract SpeakerAudioDestination: SpeakerAudioDestinationStatic
    /// <summary>Defines content of a RecognitionErrorEvent.</summary>
    abstract ConversationTranscriptionCanceledEventArgs: ConversationTranscriptionCanceledEventArgsStatic
    /// <summary>Defines content of a MeetingTranscriptionCanceledEvent.</summary>
    abstract MeetingTranscriptionCanceledEventArgs: MeetingTranscriptionCanceledEventArgsStatic
    /// <summary>Pronunciation assessment configuration.</summary>
    abstract PronunciationAssessmentConfig: PronunciationAssessmentConfigStatic
    /// <summary>Pronunciation assessment results.</summary>
    abstract PronunciationAssessmentResult: PronunciationAssessmentResultStatic
    /// Defines diagnostics API for managing console output
    /// Added in version 1.21.0
    abstract Diagnostics: DiagnosticsStatic
    /// <summary>Defines content of a CancellationEvent.</summary>
    abstract CancellationEventArgsBase: CancellationEventArgsBaseStatic
    abstract Conversation: ConversationStatic
    abstract ConversationImpl: ConversationImplStatic
    abstract ConversationCommon: ConversationCommonStatic
    abstract ConversationExpirationEventArgs: ConversationExpirationEventArgsStatic
    abstract ConversationParticipantsChangedEventArgs: ConversationParticipantsChangedEventArgsStatic
    abstract ConversationTranslationCanceledEventArgs: ConversationTranslationCanceledEventArgsStatic
    abstract ConversationTranslationEventArgs: ConversationTranslationEventArgsStatic
    abstract ConversationTranslationResult: ConversationTranslationResultStatic
    /// Join, leave or connect to a conversation.
    abstract ConversationTranslator: ConversationTranslatorStatic
    /// <summary>Performs speech recognition with speaker separation from microphone, file, or other audio input streams, and gets transcribed text as result.</summary>
    abstract ConversationTranscriber: ConversationTranscriberStatic
    abstract User: UserStatic
    abstract Participant: ParticipantStatic
    abstract Meeting: MeetingStatic
    abstract MeetingImpl: MeetingImplStatic
    abstract MeetingTranscriber: MeetingTranscriberStatic
    /// <summary>Defines result of conversation transcription.</summary>
    abstract ConversationTranscriptionResult: ConversationTranscriptionResultStatic
    abstract CognitiveSubscriptionKeyAuthentication: CognitiveSubscriptionKeyAuthenticationStatic
    abstract CognitiveTokenAuthentication: CognitiveTokenAuthenticationStatic
    abstract AuthInfo: AuthInfoStatic
    abstract IntentConnectionFactory: IntentConnectionFactoryStatic
    abstract SpeakerRecognitionConnectionFactoryBase: SpeakerRecognitionConnectionFactoryBaseStatic
    abstract SpeakerRecognitionConnectionFactory: SpeakerRecognitionConnectionFactoryStatic
    abstract VoiceProfileConnectionFactory: VoiceProfileConnectionFactoryStatic
    abstract SpeechRecognitionEvent: SpeechRecognitionEventStatic
    abstract RecognitionTriggeredEvent: RecognitionTriggeredEventStatic
    abstract ListeningStartedEvent: ListeningStartedEventStatic
    abstract ConnectingToServiceEvent: ConnectingToServiceEventStatic
    abstract RecognitionStartedEvent: RecognitionStartedEventStatic
    abstract RecognitionEndedEvent: RecognitionEndedEventStatic
    abstract ServiceRecognizerBase: ServiceRecognizerBaseStatic
    abstract ConversationServiceRecognizer: ConversationServiceRecognizerStatic
    abstract RecognizerConfig: RecognizerConfigStatic
    abstract SpeechServiceConfig: SpeechServiceConfigStatic
    abstract Context: ContextStatic
    abstract System: SystemStatic
    abstract OS: OSStatic
    abstract Device: DeviceStatic
    abstract WebsocketMessageFormatter: WebsocketMessageFormatterStatic
    abstract SpeechConnectionFactory: SpeechConnectionFactoryStatic
    abstract ConversationTranscriberConnectionFactory: ConversationTranscriberConnectionFactoryStatic
    abstract TranscriberConnectionFactory: TranscriberConnectionFactoryStatic
    abstract TranslationConnectionFactory: TranslationConnectionFactoryStatic
    abstract SpeechSynthesisConnectionFactory: SpeechSynthesisConnectionFactoryStatic
    abstract EnumTranslation: EnumTranslationStatic
    abstract TranslationSynthesisEnd: TranslationSynthesisEndStatic
    abstract TranslationHypothesis: TranslationHypothesisStatic
    abstract TranslationPhrase: TranslationPhraseStatic
    abstract TranslationServiceRecognizer: TranslationServiceRecognizerStatic
    abstract SpeechDetected: SpeechDetectedStatic
    abstract SpeechHypothesis: SpeechHypothesisStatic
    abstract SpeechKeyword: SpeechKeywordStatic
    abstract SpeechServiceRecognizer: SpeechServiceRecognizerStatic
    abstract ConversationTranscriptionServiceRecognizer: ConversationTranscriptionServiceRecognizerStatic
    abstract TranscriptionServiceRecognizer: TranscriptionServiceRecognizerStatic
    abstract DetailedSpeechPhrase: DetailedSpeechPhraseStatic
    abstract SimpleSpeechPhrase: SimpleSpeechPhraseStatic
    abstract AddedLmIntent: AddedLmIntentStatic
    abstract IntentServiceRecognizer: IntentServiceRecognizerStatic
    abstract IntentResponse: IntentResponseStatic
    abstract RequestSession: RequestSessionStatic
    /// Represents the JSON used in the speech.context message sent to the speech service.
    /// The dynamic grammar is always refreshed from the encapsulated dynamic grammar object.
    abstract SpeechContext: SpeechContextStatic
    /// <summary>Responsible for building the object to be sent to the speech service to support dynamic grammars.</summary>
    abstract DynamicGrammarBuilder: DynamicGrammarBuilderStatic
    abstract DialogServiceAdapter: DialogServiceAdapterStatic
    /// Represents the JSON used in the agent.config message sent to the speech service.
    abstract AgentConfig: AgentConfigStatic
    abstract SynthesisAudioMetadata: SynthesisAudioMetadataStatic
    abstract SynthesisTurn: SynthesisTurnStatic
    abstract SynthesisAdapterBase: SynthesisAdapterBaseStatic
    /// <summary>
    /// Implements methods for speaker recognition classes, sending requests to endpoint
    /// and parsing response into expected format
    /// </summary>
    abstract SynthesisRestAdapter: SynthesisRestAdapterStatic
    abstract SynthesizerConfig: SynthesizerConfigStatic
    /// Represents the JSON used in the synthesis.context message sent to the speech service.
    /// The dynamic grammar is always refreshed from the encapsulated dynamic grammar object.
    abstract SynthesisContext: SynthesisContextStatic
    abstract SpeakerRecognitionConfig: SpeakerRecognitionConfigStatic
    abstract SpeakerServiceRecognizer: SpeakerServiceRecognizerStatic
    abstract VoiceServiceRecognizer: VoiceServiceRecognizerStatic
    abstract AudioSourceEvent: AudioSourceEventStatic
    abstract AudioSourceInitializingEvent: AudioSourceInitializingEventStatic
    abstract AudioSourceReadyEvent: AudioSourceReadyEventStatic
    abstract AudioSourceOffEvent: AudioSourceOffEventStatic
    abstract AudioSourceErrorEvent: AudioSourceErrorEventStatic
    abstract AudioStreamNodeEvent: AudioStreamNodeEventStatic
    abstract AudioStreamNodeAttachingEvent: AudioStreamNodeAttachingEventStatic
    abstract AudioStreamNodeAttachedEvent: AudioStreamNodeAttachedEventStatic
    abstract AudioStreamNodeDetachedEvent: AudioStreamNodeDetachedEventStatic
    abstract AudioStreamNodeErrorEvent: AudioStreamNodeErrorEventStatic
    abstract ServiceEvent: ServiceEventStatic
    abstract ConnectionEvent: ConnectionEventStatic
    abstract ConnectionStartEvent: ConnectionStartEventStatic
    abstract ConnectionEstablishedEvent: ConnectionEstablishedEventStatic
    abstract ConnectionClosedEvent: ConnectionClosedEventStatic
    abstract ConnectionErrorEvent: ConnectionErrorEventStatic
    abstract ConnectionEstablishErrorEvent: ConnectionEstablishErrorEventStatic
    abstract ConnectionMessageReceivedEvent: ConnectionMessageReceivedEventStatic
    abstract ConnectionMessageSentEvent: ConnectionMessageSentEventStatic
    abstract ConnectionOpenResponse: ConnectionOpenResponseStatic
    /// <summary>The error that is thrown when an argument passed in is null.</summary>
    abstract DeferralMap: DeferralMapStatic
    abstract DialogEvent: DialogEventStatic
    abstract SendingAgentContextMessageEvent: SendingAgentContextMessageEventStatic
    /// <summary>The error that is thrown when an argument passed in is null.</summary>
    abstract ArgumentNullError: ArgumentNullErrorStatic
    /// <summary>The error that is thrown when an invalid operation is performed in the code.</summary>
    abstract InvalidOperationError: InvalidOperationErrorStatic
    /// <summary>The error that is thrown when an object is disposed.</summary>
    abstract ObjectDisposedError: ObjectDisposedErrorStatic
    abstract Events: EventsStatic
    abstract EventSource: EventSourceStatic
    abstract createGuid: unit -> string
    abstract createNoDashGuid: unit -> string
    abstract List: ListStatic
    abstract PlatformEvent: PlatformEventStatic
    abstract PromiseResult: PromiseResultStatic
    abstract PromiseResultEventSource: PromiseResultEventSourceStatic
    abstract Deferred: DeferredStatic
    abstract Sink: SinkStatic
    abstract marshalPromiseToCallbacks: promise: Promise<'T> * ?cb: ('T -> unit) * ?err: (string -> unit) -> unit
    abstract Queue: QueueStatic
    abstract RawWebsocketMessage: RawWebsocketMessageStatic
    abstract RiffPcmEncoder: RiffPcmEncoderStatic
    abstract Stream: StreamStatic
    abstract ChunkedArrayBufferStream: ChunkedArrayBufferStreamStatic
    abstract Timeout: TimeoutStatic
    abstract OCSPEvent: OCSPEventStatic
    abstract OCSPMemoryCacheHitEvent: OCSPMemoryCacheHitEventStatic
    abstract OCSPCacheMissEvent: OCSPCacheMissEventStatic
    abstract OCSPDiskCacheHitEvent: OCSPDiskCacheHitEventStatic
    abstract OCSPCacheUpdateNeededEvent: OCSPCacheUpdateNeededEventStatic
    abstract OCSPMemoryCacheStoreEvent: OCSPMemoryCacheStoreEventStatic
    abstract OCSPDiskCacheStoreEvent: OCSPDiskCacheStoreEventStatic
    abstract OCSPCacheUpdateCompleteEvent: OCSPCacheUpdateCompleteEventStatic
    abstract OCSPStapleReceivedEvent: OCSPStapleReceivedEventStatic
    abstract OCSPWSUpgradeStartedEvent: OCSPWSUpgradeStartedEventStatic
    abstract OCSPCacheEntryExpiredEvent: OCSPCacheEntryExpiredEventStatic
    abstract OCSPCacheEntryNeedsRefreshEvent: OCSPCacheEntryNeedsRefreshEventStatic
    abstract OCSPCacheHitEvent: OCSPCacheHitEventStatic
    abstract OCSPVerificationFailedEvent: OCSPVerificationFailedEventStatic
    abstract OCSPCacheFetchErrorEvent: OCSPCacheFetchErrorEventStatic
    abstract OCSPResponseRetrievedEvent: OCSPResponseRetrievedEventStatic
    abstract OCSPCacheUpdateErrorEvent: OCSPCacheUpdateErrorEventStatic
    abstract BackgroundEvent: BackgroundEventStatic
    abstract ConnectionFactoryBase: ConnectionFactoryBaseStatic
    abstract SpeechConnectionMessage: SpeechConnectionMessageStatic
    abstract ConversationManager: ConversationManagerStatic
    abstract ConversationConnectionConfig: ConversationConnectionConfigStatic
    abstract ConversationRecognizerFactory: ConversationRecognizerFactoryStatic
    /// Sends messages to the Conversation Translator websocket and listens for incoming events containing websocket messages.
    /// Based off the recognizers in the SDK folder.
    abstract ConversationTranslatorRecognizer: ConversationTranslatorRecognizerStatic
    abstract TranscriberRecognizer: TranscriberRecognizerStatic
    abstract MuteAllEventArgs: MuteAllEventArgsStatic
    abstract LockRoomEventArgs: LockRoomEventArgsStatic
    abstract ParticipantEventArgs: ParticipantEventArgsStatic
    abstract ParticipantAttributeEventArgs: ParticipantAttributeEventArgsStatic
    abstract ParticipantsListEventArgs: ParticipantsListEventArgsStatic
    abstract ConversationReceivedTranslationEventArgs: ConversationReceivedTranslationEventArgsStatic
    /// Users participating in the conversation
    abstract InternalParticipants: InternalParticipantsStatic
    abstract AudioOutputFormatImpl: AudioOutputFormatImplStatic
    abstract SpeechSynthesisEvent: SpeechSynthesisEventStatic
    abstract SynthesisTriggeredEvent: SynthesisTriggeredEventStatic
    abstract ConnectingToSynthesisServiceEvent: ConnectingToSynthesisServiceEventStatic
    abstract SynthesisStartedEvent: SynthesisStartedEventStatic
    abstract ConsoleLoggingListener: ConsoleLoggingListenerStatic
    abstract MicAudioSource: MicAudioSourceStatic
    abstract FileAudioSource: FileAudioSourceStatic
    abstract PcmRecorder: PcmRecorderStatic
    abstract WebsocketConnection: WebsocketConnectionStatic
    abstract WebsocketMessageAdapter: WebsocketMessageAdapterStatic
    abstract ReplayableAudioNode: ReplayableAudioNodeStatic
    abstract ProxyInfo: ProxyInfoStatic
    abstract RestMessageAdapter: RestMessageAdapterStatic
    abstract RestConfigBase: RestConfigBaseStatic

/// <summary>Represents audio input configuration used for specifying what type of input to use (microphone, file, stream).</summary>
type [<AllowNullLiteral>] AudioConfig =
    /// <summary>Explicitly frees any external resource attached to the object</summary>
    abstract close: unit -> unit
    /// <summary>Sets an arbitrary property.</summary>
    /// <param name="name">The name of the property to set.</param>
    /// <param name="value">The new value of the property.</param>
    abstract setProperty: name: string * value: string -> unit
    /// <summary>Returns the current value of an arbitrary property.</summary>
    /// <param name="name">The name of the property to query.</param>
    /// <param name="def">The value to return in case the property is not known.</param>
    /// <returns>The current value, or provided default, of the given property.</returns>
    abstract getProperty: name: string * ?def: string -> string

/// <summary>Represents audio input configuration used for specifying what type of input to use (microphone, file, stream).</summary>
type [<AllowNullLiteral>] AudioConfigStatic =
    [<EmitConstructor>] abstract Create: unit -> AudioConfig
    /// <summary>Creates an AudioConfig object representing the default microphone on the system.</summary>
    /// <returns>The audio input configuration being created.</returns>
    abstract fromDefaultMicrophoneInput: unit -> AudioConfig
    /// <summary>Creates an AudioConfig object representing a microphone with the specified device ID.</summary>
    /// <param name="deviceId">
    /// Specifies the device ID of the microphone to be used.
    /// Default microphone is used the value is omitted.
    /// </param>
    /// <returns>The audio input configuration being created.</returns>
    abstract fromMicrophoneInput: ?deviceId: string -> AudioConfig
    /// <summary>Creates an AudioConfig object representing the specified file.</summary>
    /// <param name="fileName">Specifies the audio input file. Currently, only WAV / PCM is supported.</param>
    /// <returns>The audio input configuration being created.</returns>
    abstract fromWavFileInput: file: U2<File, Buffer> * ?name: string -> AudioConfig
    /// <summary>Creates an AudioConfig object representing the specified stream.</summary>
    /// <param name="audioStream">
    /// Specifies the custom audio input
    /// stream. Currently, only WAV / PCM is supported.
    /// </param>
    /// <returns>The audio input configuration being created.</returns>
    // abstract fromStreamInput: audioStream: U3<AudioInputStream, PullAudioInputStreamCallback, MediaStream> -> AudioConfig
    abstract fromStreamInput: audioStream: U3<AudioInputStream, PullAudioInputStreamCallback, obj> -> AudioConfig
    /// <summary>Creates an AudioConfig object representing the default speaker.</summary>
    /// <returns>
    /// The audio output configuration being created.
    /// Added in version 1.11.0
    /// </returns>
    abstract fromDefaultSpeakerOutput: unit -> AudioConfig
    /// <summary>
    /// Creates an AudioConfig object representing the custom IPlayer object.
    /// You can use the IPlayer object to control pause, resume, etc.
    /// </summary>
    /// <param name="player">the IPlayer object for playback.</param>
    /// <returns>
    /// The audio output configuration being created.
    /// Added in version 1.12.0
    /// </returns>
    abstract fromSpeakerOutput: ?player: IPlayer -> AudioConfig
    /// <summary>Creates an AudioConfig object representing a specified output audio file</summary>
    /// <param name="filename">the filename of the output audio file</param>
    /// <returns>
    /// The audio output configuration being created.
    /// Added in version 1.11.0
    /// </returns>
    abstract fromAudioFileOutput: filename: PathLike -> AudioConfig
    /// <summary>Creates an AudioConfig object representing a specified audio output stream</summary>
    /// <param name="audioStream">
    /// Specifies the custom audio output
    /// stream.
    /// </param>
    /// <returns>
    /// The audio output configuration being created.
    /// Added in version 1.11.0
    /// </returns>
    abstract fromStreamOutput: audioStream: U2<AudioOutputStream, PushAudioOutputStreamCallback> -> AudioConfig

/// <summary>Represents audio input stream used for custom audio input configurations.</summary>
type [<AllowNullLiteral>] AudioConfigImpl =
    inherit AudioConfig
    inherit IAudioSource
    /// Format information for the audio
    abstract format: Promise<AudioStreamFormatImpl>
    /// <summary>Explicitly frees any external resource attached to the object</summary>
    abstract close: ?cb: (unit -> unit) * ?err: (string -> unit) -> unit
    abstract id: unit -> string
    /// <returns>A promise.</returns>
    abstract turnOn: unit -> Promise<unit>
    /// <param name="audioNodeId">The audio node id.</param>
    /// <returns>A promise.</returns>
    abstract attach: audioNodeId: string -> Promise<IAudioStreamNode>
    /// <param name="audioNodeId">The audio node id.</param>
    abstract detach: audioNodeId: string -> unit
    /// <returns>A promise.</returns>
    abstract turnOff: unit -> Promise<unit>
    /// <returns>An event source for audio events.</returns>
    abstract events: EventSource<AudioSourceEvent>
    /// Sets an arbitrary property.
    abstract setProperty: name: string * value: string -> unit
    /// Returns the current value of an arbitrary property.
    abstract getProperty: name: string * ?def: string -> string
    abstract deviceInfo: Promise<ISpeechConfigAudioDevice>

/// <summary>Represents audio input stream used for custom audio input configurations.</summary>
type [<AllowNullLiteral>] AudioConfigImplStatic =
    /// <summary>Creates and initializes an instance of this class.</summary>
    /// <param name="source">An audio source.</param>
    [<EmitConstructor>] abstract Create: source: IAudioSource -> AudioConfigImpl

type [<AllowNullLiteral>] AudioOutputConfigImpl =
    inherit AudioConfig
    inherit IAudioDestination
    abstract format: AudioStreamFormat with set
    abstract write: buffer: ArrayBuffer -> unit
    /// Explicitly frees any external resource attached to the object
    abstract close: unit -> unit
    abstract id: unit -> string
    /// Sets an arbitrary property.
    abstract setProperty: unit -> unit
    /// Returns the current value of an arbitrary property.
    abstract getProperty: unit -> string

type [<AllowNullLiteral>] AudioOutputConfigImplStatic =
    /// <summary>Creates and initializes an instance of this class.</summary>
    /// <param name="destination">An audio destination.</param>
    [<EmitConstructor>] abstract Create: destination: IAudioDestination -> AudioOutputConfigImpl

type [<RequireQualifiedAccess>] AudioFormatTag =
    | PCM = 1
    | MuLaw = 2
    | Siren = 3
    | MP3 = 4
    | SILKSkype = 5
    | OGG_OPUS = 6
    | WEBM_OPUS = 7
    | ALaw = 8
    | FLAC = 9
    | OPUS = 10

/// <summary>Represents audio stream format used for custom audio input configurations.</summary>
type [<AllowNullLiteral>] AudioStreamFormat =
    /// <summary>Explicitly frees any external resource attached to the object</summary>
    abstract close: unit -> unit

/// <summary>Represents audio stream format used for custom audio input configurations.</summary>
type [<AllowNullLiteral>] AudioStreamFormatStatic =
    [<EmitConstructor>] abstract Create: unit -> AudioStreamFormat
    /// <summary>
    /// Creates an audio stream format object representing the default audio stream
    /// format (16KHz 16bit mono PCM).
    /// </summary>
    /// <returns>The audio stream format being created.</returns>
    abstract getDefaultInputFormat: unit -> AudioStreamFormat
    /// <summary>Creates an audio stream format object with the specified format characteristics.</summary>
    /// <param name="samplesPerSecond">Sample rate, in samples per second (Hertz).</param>
    /// <param name="bitsPerSample">Bits per sample, typically 16.</param>
    /// <param name="channels">
    /// Number of channels in the waveform-audio data. Monaural data
    /// uses one channel and stereo data uses two channels.
    /// </param>
    /// <param name="format">Audio format (PCM, alaw or mulaw).</param>
    /// <returns>The audio stream format being created.</returns>
    abstract getWaveFormat: samplesPerSecond: float * bitsPerSample: float * channels: float * format: AudioFormatTag -> AudioStreamFormat
    /// <summary>Creates an audio stream format object with the specified pcm waveformat characteristics.</summary>
    /// <param name="samplesPerSecond">Sample rate, in samples per second (Hertz).</param>
    /// <param name="bitsPerSample">Bits per sample, typically 16.</param>
    /// <param name="channels">
    /// Number of channels in the waveform-audio data. Monaural data
    /// uses one channel and stereo data uses two channels.
    /// </param>
    /// <returns>The audio stream format being created.</returns>
    abstract getWaveFormatPCM: samplesPerSecond: float * bitsPerSample: float * channels: float -> AudioStreamFormat

type [<AllowNullLiteral>] AudioStreamFormatImpl =
    inherit AudioStreamFormat
    abstract privHeader: ArrayBuffer with get, set
    /// <summary>Closes the configuration object.</summary>
    abstract close: unit -> unit
    /// <summary>The format of the audio, valid values: 1 (PCM)</summary>
    abstract formatTag: float with get, set
    /// <summary>The number of channels, valid values: 1 (Mono).</summary>
    abstract channels: float with get, set
    /// <summary>The sample rate, valid values: 16000.</summary>
    abstract samplesPerSec: float with get, set
    /// <summary>The bits per sample, valid values: 16</summary>
    abstract bitsPerSample: float with get, set
    /// <summary>Average bytes per second, usually calculated as nSamplesPerSec * nChannels * ceil(wBitsPerSample, 8).</summary>
    abstract avgBytesPerSec: float with get, set
    /// <summary>The size of a single frame, valid values: nChannels * ceil(wBitsPerSample, 8).</summary>
    abstract blockAlign: float with get, set
    abstract header: ArrayBuffer
    abstract setString: view: DataView * offset: float * str: string -> unit

type [<AllowNullLiteral>] AudioStreamFormatImplStatic =
    /// <summary>Creates an instance with the given values.</summary>
    /// <param name="samplesPerSec">Samples per second.</param>
    /// <param name="bitsPerSample">Bits per sample.</param>
    /// <param name="channels">Number of channels.</param>
    /// <param name="format">Audio format (PCM, alaw or mulaw).</param>
    [<EmitConstructor>] abstract Create: ?samplesPerSec: float * ?bitsPerSample: float * ?channels: float * ?format: AudioFormatTag -> AudioStreamFormatImpl
    /// <summary>Retrieves the default input format.</summary>
    /// <returns>The default input format.</returns>
    abstract getDefaultInputFormat: unit -> AudioStreamFormatImpl
    /// <summary>Creates an audio context appropriate to current browser</summary>
    /// <returns>An audio context instance</returns>
    // abstract getAudioContext: ?sampleRate: float -> AudioContext
    abstract getAudioContext: ?sampleRate: float -> obj

/// <summary>Represents audio input stream used for custom audio input configurations.</summary>
type [<AllowNullLiteral>] AudioInputStream =
    /// <summary>Explicitly frees any external resource attached to the object</summary>
    abstract close: unit -> unit

/// <summary>Represents audio input stream used for custom audio input configurations.</summary>
type [<AllowNullLiteral>] AudioInputStreamStatic =
    /// <summary>Creates and initializes an instance.</summary>
    [<EmitConstructor>] abstract Create: unit -> AudioInputStream
    /// <summary>Creates a memory backed PushAudioInputStream with the specified audio format.</summary>
    /// <param name="format">
    /// The audio data format in which audio will be
    /// written to the push audio stream's write() method (Required if format is not 16 kHz 16bit mono PCM).
    /// </param>
    /// <returns>The audio input stream being created.</returns>
    abstract createPushStream: ?format: AudioStreamFormat -> PushAudioInputStream
    /// <summary>
    /// Creates a PullAudioInputStream that delegates to the specified callback interface for read()
    /// and close() methods.
    /// </summary>
    /// <param name="callback">
    /// The custom audio input object, derived from
    /// PullAudioInputStreamCallback
    /// </param>
    /// <param name="format">
    /// The audio data format in which audio will be returned from
    /// the callback's read() method (Required if format is not 16 kHz 16bit mono PCM).
    /// </param>
    /// <returns>The audio input stream being created.</returns>
    abstract createPullStream: callback: PullAudioInputStreamCallback * ?format: AudioStreamFormat -> PullAudioInputStream

/// <summary>Represents memory backed push audio input stream used for custom audio input configurations.</summary>
type [<AllowNullLiteral>] PushAudioInputStream =
    inherit AudioInputStream
    /// <summary>Writes the audio data specified by making an internal copy of the data.</summary>
    /// <param name="dataBuffer">The audio buffer of which this function will make a copy.</param>
    abstract write: dataBuffer: ArrayBuffer -> unit
    /// <summary>Closes the stream.</summary>
    abstract close: unit -> unit

/// <summary>Represents memory backed push audio input stream used for custom audio input configurations.</summary>
type [<AllowNullLiteral>] PushAudioInputStreamStatic =
    /// <summary>Creates and initializes an instance.</summary>
    [<EmitConstructor>] abstract Create: unit -> PushAudioInputStream
    /// <summary>Creates a memory backed PushAudioInputStream with the specified audio format.</summary>
    /// <param name="format">
    /// The audio data format in which audio will be written to the
    /// push audio stream's write() method (Required if format is not 16 kHz 16bit mono PCM).
    /// </param>
    /// <returns>The push audio input stream being created.</returns>
    abstract create: ?format: AudioStreamFormat -> PushAudioInputStream

/// <summary>Represents memory backed push audio input stream used for custom audio input configurations.</summary>
type [<AllowNullLiteral>] PushAudioInputStreamImpl =
    inherit PushAudioInputStream
    inherit IAudioSource
    /// Format information for the audio
    abstract format: Promise<AudioStreamFormatImpl>
    /// <summary>Writes the audio data specified by making an internal copy of the data.</summary>
    /// <param name="dataBuffer">The audio buffer of which this function will make a copy.</param>
    abstract write: dataBuffer: ArrayBuffer -> unit
    /// <summary>Closes the stream.</summary>
    abstract close: unit -> unit
    abstract id: unit -> string
    abstract turnOn: unit -> Promise<unit>
    abstract attach: audioNodeId: string -> Promise<IAudioStreamNode>
    abstract detach: audioNodeId: string -> unit
    abstract turnOff: unit -> Promise<unit>
    abstract events: EventSource<AudioSourceEvent>
    abstract deviceInfo: Promise<ISpeechConfigAudioDevice>

/// <summary>Represents memory backed push audio input stream used for custom audio input configurations.</summary>
type [<AllowNullLiteral>] PushAudioInputStreamImplStatic =
    /// <summary>Creates and initalizes an instance with the given values.</summary>
    /// <param name="format">The audio stream format.</param>
    [<EmitConstructor>] abstract Create: ?format: AudioStreamFormat -> PushAudioInputStreamImpl

type [<AllowNullLiteral>] PullAudioInputStream =
    inherit AudioInputStream
    /// <summary>Explicitly frees any external resource attached to the object</summary>
    abstract close: unit -> unit

type [<AllowNullLiteral>] PullAudioInputStreamStatic =
    /// <summary>Creates and initializes and instance.</summary>
    [<EmitConstructor>] abstract Create: unit -> PullAudioInputStream
    /// <summary>
    /// Creates a PullAudioInputStream that delegates to the specified callback interface for
    /// read() and close() methods, using the default format (16 kHz 16bit mono PCM).
    /// </summary>
    /// <param name="callback">
    /// The custom audio input object,
    /// derived from PullAudioInputStreamCustomCallback
    /// </param>
    /// <param name="format">
    /// The audio data format in which audio will be
    /// returned from the callback's read() method (Required if format is not 16 kHz 16bit mono PCM).
    /// </param>
    /// <returns>The push audio input stream being created.</returns>
    abstract create: callback: PullAudioInputStreamCallback * ?format: AudioStreamFormat -> PullAudioInputStream

/// <summary>Represents audio input stream used for custom audio input configurations.</summary>
type [<AllowNullLiteral>] PullAudioInputStreamImpl =
    inherit PullAudioInputStream
    inherit IAudioSource
    /// Format information for the audio
    abstract format: Promise<AudioStreamFormatImpl>
    /// <summary>Closes the stream.</summary>
    abstract close: unit -> unit
    abstract id: unit -> string
    abstract turnOn: unit -> Promise<unit>
    abstract attach: audioNodeId: string -> Promise<IAudioStreamNode>
    abstract detach: audioNodeId: string -> unit
    abstract turnOff: unit -> Promise<unit>
    abstract events: EventSource<AudioSourceEvent>
    abstract deviceInfo: Promise<ISpeechConfigAudioDevice>

/// <summary>Represents audio input stream used for custom audio input configurations.</summary>
type [<AllowNullLiteral>] PullAudioInputStreamImplStatic =
    /// <summary>
    /// Creates a PullAudioInputStream that delegates to the specified callback interface for
    /// read() and close() methods, using the default format (16 kHz 16bit mono PCM).
    /// </summary>
    /// <param name="callback">
    /// The custom audio input object,
    /// derived from PullAudioInputStreamCustomCallback
    /// </param>
    /// <param name="format">
    /// The audio data format in which audio will be
    /// returned from the callback's read() method (Required if format is not 16 kHz 16bit mono PCM).
    /// </param>
    [<EmitConstructor>] abstract Create: callback: PullAudioInputStreamCallback * ?format: AudioStreamFormatImpl -> PullAudioInputStreamImpl

/// <summary>Represents audio output stream used for custom audio output configurations.</summary>
type [<AllowNullLiteral>] AudioOutputStream =
    /// <summary>
    /// Sets the format of the AudioOutputStream
    /// Note: the format is set by the synthesizer before writing. Do not set it before passing it to AudioConfig
    /// </summary>
    abstract format: AudioStreamFormat with set
    /// <summary>Explicitly frees any external resource attached to the object</summary>
    abstract close: unit -> unit

/// <summary>Represents audio output stream used for custom audio output configurations.</summary>
type [<AllowNullLiteral>] AudioOutputStreamStatic =
    /// <summary>Creates and initializes an instance.</summary>
    [<EmitConstructor>] abstract Create: unit -> AudioOutputStream
    /// <summary>Creates a memory backed PullAudioOutputStream with the specified audio format.</summary>
    /// <returns>The audio output stream being created.</returns>
    abstract createPullStream: unit -> PullAudioOutputStream

/// <summary>Represents memory backed push audio output stream used for custom audio output configurations.</summary>
type [<AllowNullLiteral>] PullAudioOutputStream =
    inherit AudioOutputStream
    /// <summary>Reads audio data from the internal buffer.</summary>
    /// <param name="dataBuffer">An ArrayBuffer to store the read data.</param>
    /// <returns>Audio buffer length has been read.</returns>
    abstract read: dataBuffer: ArrayBuffer -> Promise<float>
    /// <summary>Closes the stream.</summary>
    abstract close: unit -> unit

/// <summary>Represents memory backed push audio output stream used for custom audio output configurations.</summary>
type [<AllowNullLiteral>] PullAudioOutputStreamStatic =
    /// <summary>Creates and initializes an instance.</summary>
    [<EmitConstructor>] abstract Create: unit -> PullAudioOutputStream
    /// <summary>Creates a memory backed PullAudioOutputStream with the specified audio format.</summary>
    /// <returns>The push audio output stream being created.</returns>
    abstract create: unit -> PullAudioOutputStream

/// <summary>Represents memory backed push audio output stream used for custom audio output configurations.</summary>
type [<AllowNullLiteral>] PullAudioOutputStreamImpl =
    inherit PullAudioOutputStream
    inherit IAudioDestination
    /// Sets the format information to the stream. For internal use only.
    /// Format information for the audio
    abstract format: AudioStreamFormat with get, set
    /// <summary>Checks if the stream is closed</summary>
    abstract isClosed: bool
    /// <summary>Gets the id of the stream</summary>
    abstract id: unit -> string
    /// <summary>Reads audio data from the internal buffer.</summary>
    /// <param name="dataBuffer">An ArrayBuffer to store the read data.</param>
    /// <returns>- Audio buffer length has been read.</returns>
    abstract read: dataBuffer: ArrayBuffer -> Promise<float>
    /// <summary>Writes the audio data specified by making an internal copy of the data.</summary>
    /// <param name="dataBuffer">The audio buffer of which this function will make a copy.</param>
    abstract write: dataBuffer: ArrayBuffer -> unit
    /// <summary>Closes the stream.</summary>
    abstract close: unit -> unit

/// <summary>Represents memory backed push audio output stream used for custom audio output configurations.</summary>
type [<AllowNullLiteral>] PullAudioOutputStreamImplStatic =
    /// <summary>Creates and initializes an instance with the given values.</summary>
    [<EmitConstructor>] abstract Create: unit -> PullAudioOutputStreamImpl

type [<AllowNullLiteral>] PushAudioOutputStream =
    inherit AudioOutputStream
    /// <summary>Explicitly frees any external resource attached to the object</summary>
    abstract close: unit -> unit

type [<AllowNullLiteral>] PushAudioOutputStreamStatic =
    /// <summary>Creates and initializes and instance.</summary>
    [<EmitConstructor>] abstract Create: unit -> PushAudioOutputStream
    /// <summary>
    /// Creates a PushAudioOutputStream that delegates to the specified callback interface for
    /// write() and close() methods.
    /// </summary>
    /// <param name="callback">
    /// The custom audio output object,
    /// derived from PushAudioOutputStreamCallback
    /// </param>
    /// <returns>The push audio output stream being created.</returns>
    abstract create: callback: PushAudioOutputStreamCallback -> PushAudioOutputStream

/// <summary>Represents audio output stream used for custom audio output configurations.</summary>
type [<AllowNullLiteral>] PushAudioOutputStreamImpl =
    inherit PushAudioOutputStream
    inherit IAudioDestination
    /// Sets the format of the AudioOutputStream
    /// Note: the format is set by the synthesizer before writing. Do not set it before passing it to AudioConfig
    abstract format: AudioStreamFormat with set
    abstract write: buffer: ArrayBuffer -> unit
    /// Explicitly frees any external resource attached to the object
    abstract close: unit -> unit
    abstract id: unit -> string

/// <summary>Represents audio output stream used for custom audio output configurations.</summary>
type [<AllowNullLiteral>] PushAudioOutputStreamImplStatic =
    /// <summary>
    /// Creates a PushAudioOutputStream that delegates to the specified callback interface for
    /// read() and close() methods.
    /// </summary>
    /// <param name="callback">
    /// The custom audio output object,
    /// derived from PushAudioOutputStreamCallback
    /// </param>
    [<EmitConstructor>] abstract Create: callback: PushAudioOutputStreamCallback -> PushAudioOutputStreamImpl

/// <summary>Defines the possible reasons a recognition result might be canceled.</summary>
type [<RequireQualifiedAccess>] CancellationReason =
    /// <summary>Indicates that an error occurred during speech recognition.</summary>
    | Error = 0
    /// <summary>Indicates that the end of the audio stream was reached.</summary>
    | EndOfStream = 1

/// <summary>
/// An abstract base class that defines callback methods (read() and close()) for
/// custom audio input streams).
/// </summary>
type [<AllowNullLiteral>] PullAudioInputStreamCallback =
    /// <summary>
    /// Reads data from audio input stream into the data buffer. The maximal number of bytes
    /// to be read is determined by the size of dataBuffer.
    /// </summary>
    /// <param name="dataBuffer">The byte array to store the read data.</param>
    /// <returns>the number of bytes have been read.</returns>
    abstract read: dataBuffer: ArrayBuffer -> float
    /// <summary>Closes the audio input stream.</summary>
    abstract close: unit -> unit

/// <summary>
/// An abstract base class that defines callback methods (read() and close()) for
/// custom audio input streams).
/// </summary>
type [<AllowNullLiteral>] PullAudioInputStreamCallbackStatic =
    [<EmitConstructor>] abstract Create: unit -> PullAudioInputStreamCallback

/// <summary>
/// An abstract base class that defines callback methods (write() and close()) for
/// custom audio output streams).
/// </summary>
type [<AllowNullLiteral>] PushAudioOutputStreamCallback =
    /// <summary>Writes audio data into the data buffer.</summary>
    /// <param name="dataBuffer">The byte array that stores the audio data to write.</param>
    abstract write: dataBuffer: ArrayBuffer -> unit
    /// <summary>Closes the audio output stream.</summary>
    abstract close: unit -> unit

/// <summary>
/// An abstract base class that defines callback methods (write() and close()) for
/// custom audio output streams).
/// </summary>
type [<AllowNullLiteral>] PushAudioOutputStreamCallbackStatic =
    [<EmitConstructor>] abstract Create: unit -> PushAudioOutputStreamCallback

/// <summary>
/// Represents a keyword recognition model for recognizing when
/// the user says a keyword to initiate further speech recognition.
/// </summary>
type [<AllowNullLiteral>] KeywordRecognitionModel =
    /// <summary>Dispose of associated resources.</summary>
    abstract close: unit -> unit

/// <summary>
/// Represents a keyword recognition model for recognizing when
/// the user says a keyword to initiate further speech recognition.
/// </summary>
type [<AllowNullLiteral>] KeywordRecognitionModelStatic =
    [<EmitConstructor>] abstract Create: unit -> KeywordRecognitionModel
    /// <summary>Creates a keyword recognition model using the specified filename.</summary>
    /// <param name="fileName">
    /// A string that represents file name for the keyword recognition model.
    /// Note, the file can point to a zip file in which case the model
    /// will be extracted from the zip.
    /// </param>
    /// <returns>The keyword recognition model being created.</returns>
    abstract fromFile: fileName: string -> KeywordRecognitionModel
    /// <summary>Creates a keyword recognition model using the specified filename.</summary>
    /// <param name="file">
    /// A File that represents file for the keyword recognition model.
    /// Note, the file can point to a zip file in which case the model will be extracted from the zip.
    /// </param>
    /// <returns>The keyword recognition model being created.</returns>
    abstract fromStream: file: File -> KeywordRecognitionModel

/// <summary>Defines content for session events like SessionStarted/Stopped, SoundStarted/Stopped.</summary>
type [<AllowNullLiteral>] SessionEventArgs =
    /// <summary>Represents the session identifier.</summary>
    /// <returns>Represents the session identifier.</returns>
    abstract sessionId: string

/// <summary>Defines content for session events like SessionStarted/Stopped, SoundStarted/Stopped.</summary>
type [<AllowNullLiteral>] SessionEventArgsStatic =
    /// <summary>Creates and initializes an instance of this class.</summary>
    /// <param name="sessionId">The session id.</param>
    [<EmitConstructor>] abstract Create: sessionId: string -> SessionEventArgs

/// <summary>Defines payload for session events like Speech Start/End Detected</summary>
type [<AllowNullLiteral>] RecognitionEventArgs =
    inherit SessionEventArgs
    /// <summary>Represents the message offset</summary>
    abstract offset: float

/// <summary>Defines payload for session events like Speech Start/End Detected</summary>
type [<AllowNullLiteral>] RecognitionEventArgsStatic =
    /// <summary>Creates and initializes an instance of this class.</summary>
    /// <param name="offset">The offset.</param>
    /// <param name="sessionId">The session id.</param>
    [<EmitConstructor>] abstract Create: offset: float * ?sessionId: string -> RecognitionEventArgs

/// <summary>Define Speech Recognizer output formats.</summary>
type [<RequireQualifiedAccess>] OutputFormat =
    | Simple = 0
    | Detailed = 1

/// <summary>Intent recognition result event arguments.</summary>
type [<AllowNullLiteral>] IntentRecognitionEventArgs =
    inherit RecognitionEventArgs
    /// <summary>Represents the intent recognition result.</summary>
    /// <returns>Represents the intent recognition result.</returns>
    abstract result: IntentRecognitionResult

/// <summary>Intent recognition result event arguments.</summary>
type [<AllowNullLiteral>] IntentRecognitionEventArgsStatic =
    /// <summary>Creates and initializes an instance of this class.</summary>
    /// <param name="result">The result of the intent recognition.</param>
    /// <param name="offset">The offset.</param>
    /// <param name="sessionId">The session id.</param>
    [<EmitConstructor>] abstract Create: result: IntentRecognitionResult * ?offset: float * ?sessionId: string -> IntentRecognitionEventArgs

/// <summary>Defines result of speech recognition.</summary>
type [<AllowNullLiteral>] RecognitionResult =
    /// <summary>Specifies the result identifier.</summary>
    /// <returns>Specifies the result identifier.</returns>
    abstract resultId: string
    /// <summary>Specifies status of the result.</summary>
    /// <returns>Specifies status of the result.</returns>
    abstract reason: ResultReason
    /// <summary>Presents the recognized text in the result.</summary>
    /// <returns>Presents the recognized text in the result.</returns>
    abstract text: string
    /// <summary>Duration of recognized speech in 100 nano second increments.</summary>
    /// <returns>Duration of recognized speech in 100 nano second increments.</returns>
    abstract duration: float
    /// <summary>Offset of recognized speech in 100 nano second increments.</summary>
    /// <returns>Offset of recognized speech in 100 nano second increments.</returns>
    abstract offset: float
    /// <summary>Primary Language detected.</summary>
    /// <returns>language detected.</returns>
    abstract language: string
    /// <summary>Primary Language detection confidence (Unknown, Low, Medium, High).</summary>
    /// <returns>detection confidence strength.</returns>
    abstract languageDetectionConfidence: string
    /// <summary>In case of an unsuccessful recognition, provides details of the occurred error.</summary>
    /// <returns>a brief description of an error.</returns>
    abstract errorDetails: string
    /// <summary>A string containing Json serialized recognition result as it was received from the service.</summary>
    /// <returns>Json serialized representation of the result.</returns>
    abstract json: string
    /// <summary>The set of properties exposed in the result.</summary>
    /// <returns>The set of properties exposed in the result.</returns>
    abstract properties: PropertyCollection

/// <summary>Defines result of speech recognition.</summary>
type [<AllowNullLiteral>] RecognitionResultStatic =
    /// <summary>Creates and initializes an instance of this class.</summary>
    /// <param name="resultId">The result id.</param>
    /// <param name="reason">The reason.</param>
    /// <param name="text">The recognized text.</param>
    /// <param name="duration">The duration.</param>
    /// <param name="offset">The offset into the stream.</param>
    /// <param name="language">Primary Language detected, if provided.</param>
    /// <param name="languageDetectionConfidence">Primary Language confidence ("Unknown," "Low," "Medium," "High"...), if provided.</param>
    /// <param name="errorDetails">Error details, if provided.</param>
    /// <param name="json">Additional Json, if provided.</param>
    /// <param name="properties">Additional properties, if provided.</param>
    [<EmitConstructor>] abstract Create: ?resultId: string * ?reason: ResultReason * ?text: string * ?duration: float * ?offset: float * ?language: string * ?languageDetectionConfidence: string * ?errorDetails: string * ?json: string * ?properties: PropertyCollection -> RecognitionResult

/// <summary>Defines result of speech recognition.</summary>
type [<AllowNullLiteral>] SpeechRecognitionResult =
    inherit RecognitionResult
    /// <summary>speaker id from conversation transcription/id scenarios</summary>
    /// <returns>id of speaker in given result</returns>
    abstract speakerId: string

/// <summary>Defines result of speech recognition.</summary>
type [<AllowNullLiteral>] SpeechRecognitionResultStatic =
    /// <summary>Creates and initializes an instance of this class.</summary>
    /// <param name="resultId">The result id.</param>
    /// <param name="reason">The reason.</param>
    /// <param name="text">The recognized text.</param>
    /// <param name="duration">The duration.</param>
    /// <param name="offset">The offset into the stream.</param>
    /// <param name="language">Primary Language detected, if provided.</param>
    /// <param name="languageDetectionConfidence">Primary Language confidence ("Unknown," "Low," "Medium," "High"...), if provided.</param>
    /// <param name="speakerId">speaker id for conversation transcription, if provided.</param>
    /// <param name="errorDetails">Error details, if provided.</param>
    /// <param name="json">Additional Json, if provided.</param>
    /// <param name="properties">Additional properties, if provided.</param>
    [<EmitConstructor>] abstract Create: ?resultId: string * ?reason: ResultReason * ?text: string * ?duration: float * ?offset: float * ?language: string * ?languageDetectionConfidence: string * ?speakerId: string * ?errorDetails: string * ?json: string * ?properties: PropertyCollection -> SpeechRecognitionResult

/// <summary>Intent recognition result.</summary>
type [<AllowNullLiteral>] IntentRecognitionResult =
    inherit SpeechRecognitionResult
    /// <summary>A String that represents the intent identifier being recognized.</summary>
    /// <returns>A String that represents the intent identifier being recognized.</returns>
    abstract intentId: string

/// <summary>Intent recognition result.</summary>
type [<AllowNullLiteral>] IntentRecognitionResultStatic =
    /// <summary>Creates and initializes an instance of this class.</summary>
    /// <param name="intentId">The intent id.</param>
    /// <param name="resultId">The result id.</param>
    /// <param name="reason">The reason.</param>
    /// <param name="text">The recognized text.</param>
    /// <param name="duration">The duration.</param>
    /// <param name="offset">The offset into the stream.</param>
    /// <param name="language">Primary Language detected, if provided.</param>
    /// <param name="languageDetectionConfidence">Primary Language confidence ("Unknown," "Low," "Medium," "High"...), if provided.</param>
    /// <param name="errorDetails">Error details, if provided.</param>
    /// <param name="json">Additional Json, if provided.</param>
    /// <param name="properties">Additional properties, if provided.</param>
    [<EmitConstructor>] abstract Create: ?intentId: string * ?resultId: string * ?reason: ResultReason * ?text: string * ?duration: float * ?offset: float * ?language: string * ?languageDetectionConfidence: string * ?errorDetails: string * ?json: string * ?properties: PropertyCollection -> IntentRecognitionResult

/// <summary>Language understanding model</summary>
type [<AllowNullLiteral>] LanguageUnderstandingModel =
    interface end

/// <summary>Language understanding model</summary>
type [<AllowNullLiteral>] LanguageUnderstandingModelStatic =
    /// <summary>Creates and initializes a new instance</summary>
    [<EmitConstructor>] abstract Create: unit -> LanguageUnderstandingModel
    /// <summary>Creates an language understanding model using the specified endpoint.</summary>
    /// <param name="uri">A String that represents the endpoint of the language understanding model.</param>
    /// <returns>The language understanding model being created.</returns>
    // abstract fromEndpoint: uri: URL -> LanguageUnderstandingModel
    abstract fromEndpoint: uri: obj -> LanguageUnderstandingModel
    /// <summary>Creates an language understanding model using the application id of Language Understanding service.</summary>
    /// <param name="appId">A String that represents the application id of Language Understanding service.</param>
    /// <returns>The language understanding model being created.</returns>
    abstract fromAppId: appId: string -> LanguageUnderstandingModel
    /// <summary>
    /// Creates a language understanding model using hostname, subscription key and application
    /// id of Language Understanding service.
    /// </summary>
    /// <param name="subscriptionKey">
    /// A String that represents the subscription key of
    /// Language Understanding service.
    /// </param>
    /// <param name="appId">
    /// A String that represents the application id of Language
    /// Understanding service.
    /// </param>
    /// <param name="region">
    /// A String that represents the region
    /// of the Language Understanding service (see the &lt;a href="<see href="https://aka.ms/csspeech/region"&gt;region" /> page&lt;/a&gt;).
    /// </param>
    /// <returns>The language understanding model being created.</returns>
    abstract fromSubscription: subscriptionKey: string * appId: string * region: string -> LanguageUnderstandingModel

type [<AllowNullLiteral>] LanguageUnderstandingModelImpl =
    inherit LanguageUnderstandingModel
    abstract appId: string with get, set
    abstract region: string with get, set
    abstract subscriptionKey: string with get, set

type [<AllowNullLiteral>] LanguageUnderstandingModelImplStatic =
    /// <summary>Creates and initializes a new instance</summary>
    [<EmitConstructor>] abstract Create: unit -> LanguageUnderstandingModelImpl

/// <summary>Defines contents of speech recognizing/recognized event.</summary>
type [<AllowNullLiteral>] SpeechRecognitionEventArgs =
    inherit RecognitionEventArgs
    /// <summary>Specifies the recognition result.</summary>
    /// <returns>the recognition result.</returns>
    abstract result: SpeechRecognitionResult

/// <summary>Defines contents of speech recognizing/recognized event.</summary>
type [<AllowNullLiteral>] SpeechRecognitionEventArgsStatic =
    /// <summary>Creates and initializes an instance of this class.</summary>
    /// <param name="result">The speech recognition result.</param>
    /// <param name="offset">The offset.</param>
    /// <param name="sessionId">The session id.</param>
    [<EmitConstructor>] abstract Create: result: SpeechRecognitionResult * ?offset: float * ?sessionId: string -> SpeechRecognitionEventArgs

/// <summary>Defines contents of conversation transcribed/transcribing event.</summary>
type [<AllowNullLiteral>] ConversationTranscriptionEventArgs =
    inherit RecognitionEventArgs
    /// <summary>Specifies the transcription result.</summary>
    /// <returns>the recognition result.</returns>
    abstract result: ConversationTranscriptionResult

/// <summary>Defines contents of conversation transcribed/transcribing event.</summary>
type [<AllowNullLiteral>] ConversationTranscriptionEventArgsStatic =
    /// <summary>Creates and initializes an instance of this class.</summary>
    /// <param name="result">The conversation transcription result.</param>
    /// <param name="offset">The offset.</param>
    /// <param name="sessionId">The session id.</param>
    [<EmitConstructor>] abstract Create: result: ConversationTranscriptionResult * ?offset: float * ?sessionId: string -> ConversationTranscriptionEventArgs

/// <summary>Defines contents of meeting transcribed/transcribing event.</summary>
type [<AllowNullLiteral>] MeetingTranscriptionEventArgs =
    inherit SpeechRecognitionEventArgs

/// <summary>Defines contents of meeting transcribed/transcribing event.</summary>
type [<AllowNullLiteral>] MeetingTranscriptionEventArgsStatic =
    /// <summary>Creates and initializes an instance of this class.</summary>
    /// <param name="result">The speech recognition result.</param>
    /// <param name="offset">The offset.</param>
    /// <param name="sessionId">The session id.</param>
    [<EmitConstructor>] abstract Create: result: SpeechRecognitionResult * ?offset: float * ?sessionId: string -> MeetingTranscriptionEventArgs

type [<AllowNullLiteral>] SpeechRecognitionCanceledEventArgs =
    inherit CancellationEventArgsBase

type [<AllowNullLiteral>] SpeechRecognitionCanceledEventArgsStatic =
    /// <summary>Creates and initializes an instance of this class.</summary>
    /// <param name="reason">The cancellation reason.</param>
    /// <param name="errorDetails">Error details, if provided.</param>
    /// <param name="offset">The offset.</param>
    /// <param name="sessionId">The session id.</param>
    [<EmitConstructor>] abstract Create: reason: CancellationReason * errorDetails: string * errorCode: CancellationErrorCode * ?offset: float * ?sessionId: string -> SpeechRecognitionCanceledEventArgs

/// <summary>Translation text result event arguments.</summary>
type [<AllowNullLiteral>] TranslationRecognitionEventArgs =
    inherit RecognitionEventArgs
    /// <summary>Specifies the recognition result.</summary>
    /// <returns>the recognition result.</returns>
    abstract result: TranslationRecognitionResult

/// <summary>Translation text result event arguments.</summary>
type [<AllowNullLiteral>] TranslationRecognitionEventArgsStatic =
    /// <summary>Creates and initializes an instance of this class.</summary>
    /// <param name="result">The translation recognition result.</param>
    /// <param name="offset">The offset.</param>
    /// <param name="sessionId">The session id.</param>
    [<EmitConstructor>] abstract Create: result: TranslationRecognitionResult * ?offset: float * ?sessionId: string -> TranslationRecognitionEventArgs

/// <summary>Translation Synthesis event arguments</summary>
type [<AllowNullLiteral>] TranslationSynthesisEventArgs =
    inherit SessionEventArgs
    /// <summary>Specifies the translation synthesis result.</summary>
    /// <returns>Specifies the translation synthesis result.</returns>
    abstract result: TranslationSynthesisResult

/// <summary>Translation Synthesis event arguments</summary>
type [<AllowNullLiteral>] TranslationSynthesisEventArgsStatic =
    /// <summary>Creates and initializes an instance of this class.</summary>
    /// <param name="result">The translation synthesis result.</param>
    /// <param name="sessionId">The session id.</param>
    [<EmitConstructor>] abstract Create: result: TranslationSynthesisResult * ?sessionId: string -> TranslationSynthesisEventArgs

/// <summary>Translation text result.</summary>
type [<AllowNullLiteral>] TranslationRecognitionResult =
    inherit SpeechRecognitionResult
    /// <summary>
    /// Presents the translation results. Each item in the dictionary represents
    /// a translation result in one of target languages, where the key is the name
    /// of the target language, in BCP-47 format, and the value is the translation
    /// text in the specified language.
    /// </summary>
    /// <returns>the current translation map that holds all translations requested.</returns>
    abstract translations: Translations

/// <summary>Translation text result.</summary>
type [<AllowNullLiteral>] TranslationRecognitionResultStatic =
    /// <summary>Creates and initializes an instance of this class.</summary>
    /// <param name="translations">The translations.</param>
    /// <param name="resultId">The result id.</param>
    /// <param name="reason">The reason.</param>
    /// <param name="text">The recognized text.</param>
    /// <param name="duration">The duration.</param>
    /// <param name="offset">The offset into the stream.</param>
    /// <param name="language">Primary Language detected, if provided.</param>
    /// <param name="languageDetectionConfidence">Primary Language confidence ("Unknown," "Low," "Medium," "High"...), if provided.</param>
    /// <param name="errorDetails">Error details, if provided.</param>
    /// <param name="json">Additional Json, if provided.</param>
    /// <param name="properties">Additional properties, if provided.</param>
    [<EmitConstructor>] abstract Create: translations: Translations * ?resultId: string * ?reason: ResultReason * ?text: string * ?duration: float * ?offset: float * ?language: string * ?languageDetectionConfidence: string * ?errorDetails: string * ?json: string * ?properties: PropertyCollection -> TranslationRecognitionResult
    abstract fromSpeechRecognitionResult: result: SpeechRecognitionResult -> TranslationRecognitionResult

/// <summary>
/// Defines translation synthesis result, i.e. the voice output of the translated
/// text in the target language.
/// </summary>
type [<AllowNullLiteral>] TranslationSynthesisResult =
    /// <summary>Translated text in the target language.</summary>
    /// <returns>Translated audio in the target language.</returns>
    abstract audio: ArrayBuffer
    /// <summary>The synthesis status.</summary>
    /// <returns>The synthesis status.</returns>
    abstract reason: ResultReason

/// <summary>
/// Defines translation synthesis result, i.e. the voice output of the translated
/// text in the target language.
/// </summary>
type [<AllowNullLiteral>] TranslationSynthesisResultStatic =
    /// <summary>Creates and initializes an instance of this class.</summary>
    /// <param name="reason">The synthesis reason.</param>
    /// <param name="audio">The audio data.</param>
    [<EmitConstructor>] abstract Create: reason: ResultReason * audio: ArrayBuffer -> TranslationSynthesisResult

/// <summary>Defines the possible reasons a recognition result might be generated.</summary>
type [<RequireQualifiedAccess>] ResultReason =
    /// <summary>
    /// Indicates speech could not be recognized. More details
    /// can be found in the NoMatchDetails object.
    /// </summary>
    | NoMatch = 0
    /// <summary>
    /// Indicates that the recognition was canceled. More details
    /// can be found using the CancellationDetails object.
    /// </summary>
    | Canceled = 1
    /// <summary>Indicates the speech result contains hypothesis text.</summary>
    | RecognizingSpeech = 2
    /// <summary>
    /// Indicates the speech result contains final text that has been recognized.
    /// Speech Recognition is now complete for this phrase.
    /// </summary>
    | RecognizedSpeech = 3
    /// <summary>
    /// Indicates the speech result contains a finalized acceptance of a provided keyword.
    /// Speech recognition will continue unless otherwise configured.
    /// </summary>
    | RecognizedKeyword = 4
    /// <summary>Indicates the intent result contains hypothesis text and intent.</summary>
    | RecognizingIntent = 5
    /// <summary>
    /// Indicates the intent result contains final text and intent.
    /// Speech Recognition and Intent determination are now complete for this phrase.
    /// </summary>
    | RecognizedIntent = 6
    /// <summary>Indicates the translation result contains hypothesis text and its translation(s).</summary>
    | TranslatingSpeech = 7
    /// <summary>
    /// Indicates the translation result contains final text and corresponding translation(s).
    /// Speech Recognition and Translation are now complete for this phrase.
    /// </summary>
    | TranslatedSpeech = 8
    /// <summary>Indicates the synthesized audio result contains a non-zero amount of audio data</summary>
    | SynthesizingAudio = 9
    /// <summary>Indicates the synthesized audio is now complete for this phrase.</summary>
    | SynthesizingAudioCompleted = 10
    /// <summary>Indicates the speech synthesis is now started</summary>
    | SynthesizingAudioStarted = 11
    /// <summary>Indicates the voice profile is being enrolled and customers need to send more audio to create a voice profile.</summary>
    | EnrollingVoiceProfile = 12
    /// <summary>Indicates the voice profile has been enrolled.</summary>
    | EnrolledVoiceProfile = 13
    /// <summary>Indicates successful identification of some speakers.</summary>
    | RecognizedSpeakers = 14
    /// <summary>Indicates successfully verified one speaker.</summary>
    | RecognizedSpeaker = 15
    /// <summary>Indicates a voice profile has been reset successfully.</summary>
    | ResetVoiceProfile = 16
    /// <summary>Indicates a voice profile has been deleted successfully.</summary>
    | DeletedVoiceProfile = 17
    /// <summary>Indicates synthesis voices list has been successfully retrieved.</summary>
    | VoicesListRetrieved = 18
    /// <summary>
    /// Indicates the transcription result contains hypothesis text and its translation(s) for
    /// other participants in the conversation.
    /// </summary>
    | TranslatingParticipantSpeech = 19
    /// <summary>
    /// Indicates the transcription result contains final text and corresponding translation(s)
    /// for other participants in the conversation. Speech Recognition and Translation are now
    /// complete for this phrase.
    /// </summary>
    | TranslatedParticipantSpeech = 20
    /// <summary>
    /// &lt;summary&gt;
    /// Indicates the transcription result contains the instant message and corresponding
    /// translation(s).
    /// </summary>
    | TranslatedInstantMessage = 21
    /// <summary>
    /// Indicates the transcription result contains the instant message for other participants
    /// in the conversation and corresponding translation(s).
    /// </summary>
    | TranslatedParticipantInstantMessage = 22

/// <summary>Speech configuration.</summary>
type [<AllowNullLiteral>] SpeechConfig =
    /// <summary>
    /// Sets the proxy configuration.
    /// Only relevant in Node.js environments.
    /// Added in version 1.4.0.
    /// </summary>
    /// <param name="proxyHostName">The host name of the proxy server.</param>
    /// <param name="proxyPort">The port number of the proxy server.</param>
    abstract setProxy: proxyHostName: string * proxyPort: float -> unit
    /// <summary>
    /// Sets the proxy configuration.
    /// Only relevant in Node.js environments.
    /// Added in version 1.4.0.
    /// </summary>
    /// <param name="proxyHostName">The host name of the proxy server, without the protocol scheme (<see href="http://)" /></param>
    /// <param name="proxyPort">The port number of the proxy server.</param>
    /// <param name="proxyUserName">The user name of the proxy server.</param>
    /// <param name="proxyPassword">The password of the proxy server.</param>
    abstract setProxy: proxyHostName: string * proxyPort: float * proxyUserName: string * proxyPassword: string -> unit
    /// <summary>
    /// Gets the authorization token.
    /// Gets/Sets the authorization token.
    /// Note: The caller needs to ensure that the authorization token is valid. Before the authorization token
    /// expires, the caller needs to refresh it by calling this setter with a new valid token.
    /// </summary>
    abstract authorizationToken: string with get, set
    /// <summary>
    /// Returns the configured language.
    /// Gets/Sets the input language.
    /// </summary>
    abstract speechRecognitionLanguage: string with get, set
    /// <summary>Sets an arbitrary property.</summary>
    /// <param name="name">The name of the property to set.</param>
    /// <param name="value">The new value of the property.</param>
    abstract setProperty: name: U2<string, PropertyId> * value: string -> unit
    /// <summary>Returns the current value of an arbitrary property.</summary>
    /// <param name="name">The name of the property to query.</param>
    /// <param name="def">The value to return in case the property is not known.</param>
    /// <returns>The current value, or provided default, of the given property.</returns>
    abstract getProperty: name: string * ?def: string -> string
    /// <summary>
    /// Gets speech recognition output format (simple or detailed).
    /// Note: This output format is for speech recognition result, use [SpeechConfig.speechSynthesisOutputFormat] to
    /// get synthesized audio output format.
    /// Gets/Sets speech recognition output format (simple or detailed).
    /// Note: This output format is for speech recognition result, use [SpeechConfig.speechSynthesisOutputFormat] to
    /// set synthesized audio output format.
    /// </summary>
    /// <returns>Returns the output format.</returns>
    abstract outputFormat: OutputFormat with get, set
    /// <summary>
    /// Gets the endpoint ID of a customized speech model that is used for speech recognition.
    /// Gets/Sets the endpoint ID of a customized speech model that is used for speech recognition.
    /// </summary>
    /// <returns>The endpoint ID</returns>
    abstract endpointId: string with get, set
    /// <summary>Closes the configuration.</summary>
    abstract close: unit -> unit
    /// <returns>The subscription key set on the config.</returns>
    abstract subscriptionKey: string
    /// <returns>The region set on the config.</returns>
    abstract region: string
    /// <summary>
    /// Sets a property value that will be passed to service using the specified channel.
    /// Added in version 1.7.0.
    /// </summary>
    /// <param name="The">name of the property.</param>
    /// <param name="Value">to set.</param>
    /// <param name="The">channel used to pass the specified property to service.</param>
    abstract setServiceProperty: name: string * value: string * channel: ServicePropertyChannel -> unit
    /// <summary>
    /// Sets profanity option.
    /// Added in version 1.7.0.
    /// </summary>
    /// <param name="Profanity">option to set.</param>
    abstract setProfanity: profanity: ProfanityOption -> unit
    /// <summary>
    /// Enable audio logging in service.
    /// Audio and content logs are stored either in Microsoft-owned storage, or in your own storage account linked
    /// to your Cognitive Services subscription (Bring Your Own Storage (BYOS) enabled Speech resource).
    /// The logs will be removed after 30 days.
    /// Added in version 1.7.0.
    /// </summary>
    abstract enableAudioLogging: unit -> unit
    /// <summary>
    /// Includes word-level timestamps.
    /// Added in version 1.7.0.
    /// </summary>
    abstract requestWordLevelTimestamps: unit -> unit
    /// <summary>
    /// Enable dictation. Only supported in speech continuous recognition.
    /// Added in version 1.7.0.
    /// </summary>
    abstract enableDictation: unit -> unit
    /// <summary>
    /// Gets the language of the speech synthesizer.
    /// Added in version 1.11.0.
    /// Sets the language of the speech synthesizer.
    /// Added in version 1.11.0.
    /// </summary>
    /// <returns>Returns the speech synthesis language.</returns>
    abstract speechSynthesisLanguage: string with get, set
    /// <summary>
    /// Gets the voice of the speech synthesizer.
    /// Added in version 1.11.0.
    /// Sets the voice of the speech synthesizer. (see &lt;a href="<see href="https://aka.ms/speech/tts-languages"&gt;available" /> voices&lt;/a&gt;).
    /// Added in version 1.11.0.
    /// </summary>
    /// <returns>Returns the speech synthesis voice.</returns>
    abstract speechSynthesisVoiceName: string with get, set
    /// <summary>
    /// Gets the speech synthesis output format.
    /// Added in version 1.11.0.
    /// Sets the speech synthesis output format (e.g. Riff16Khz16BitMonoPcm).
    /// The default format is Audio16Khz64KBitRateMonoMp3 for browser and Riff16Khz16BitMonoPcm for Node.JS.
    /// Added in version 1.11.0.
    /// </summary>
    /// <returns>Returns the speech synthesis output format</returns>
    abstract speechSynthesisOutputFormat: SpeechSynthesisOutputFormat with get, set

/// <summary>Speech configuration.</summary>
type [<AllowNullLiteral>] SpeechConfigStatic =
    /// <summary>Creates and initializes an instance.</summary>
    [<EmitConstructor>] abstract Create: unit -> SpeechConfig
    /// <summary>
    /// Static instance of SpeechConfig returned by passing subscriptionKey and service region.
    /// Note: Please use your LanguageUnderstanding subscription key in case you want to use the Intent recognizer.
    /// </summary>
    /// <param name="subscriptionKey">The subscription key.</param>
    /// <param name="region">The region name (see the &lt;a href="<see href="https://aka.ms/csspeech/region"&gt;region" /> page&lt;/a&gt;).</param>
    /// <returns>The speech factory</returns>
    abstract fromSubscription: subscriptionKey: string * region: string -> SpeechConfig
    /// <summary>
    /// Creates an instance of the speech config with specified endpoint and subscription key.
    /// This method is intended only for users who use a non-standard service endpoint or parameters.
    /// Note: Please use your LanguageUnderstanding subscription key in case you want to use the Intent recognizer.
    /// Note: The query parameters specified in the endpoint URL are not changed, even if they are set by any other APIs.
    /// For example, if language is defined in the uri as query parameter "language=de-DE", and also set by
    /// SpeechConfig.speechRecognitionLanguage = "en-US", the language setting in uri takes precedence,
    /// and the effective language is "de-DE". Only the parameters that are not specified in the
    /// endpoint URL can be set by other APIs.
    /// Note: To use authorization token with fromEndpoint, pass an empty string to the subscriptionKey in the
    /// fromEndpoint method, and then set authorizationToken="token" on the created SpeechConfig instance to
    /// use the authorization token.
    /// </summary>
    /// <param name="endpoint">The service endpoint to connect to.</param>
    /// <param name="subscriptionKey">The subscription key. If a subscription key is not specified, an authorization token must be set.</param>
    /// <returns>A speech factory instance.</returns>
    // abstract fromEndpoint: endpoint: URL * ?subscriptionKey: string -> SpeechConfig
    abstract fromEndpoint: endpoint: obj * ?subscriptionKey: string -> SpeechConfig
    /// <summary>
    /// Creates an instance of the speech config with specified host and subscription key.
    /// This method is intended only for users who use a non-default service host. Standard resource path will be assumed.
    /// For services with a non-standard resource path or no path at all, use fromEndpoint instead.
    /// Note: Query parameters are not allowed in the host URI and must be set by other APIs.
    /// Note: To use an authorization token with fromHost, use fromHost(URL),
    /// and then set the AuthorizationToken property on the created SpeechConfig instance.
    /// Note: Added in version 1.9.0.
    /// </summary>
    /// <param name="host">The service endpoint to connect to. Format is "<see href="protocol://host:port"" /> where ":port" is optional.</param>
    /// <param name="subscriptionKey">The subscription key. If a subscription key is not specified, an authorization token must be set.</param>
    /// <returns>A speech factory instance.</returns>
    // abstract fromHost: hostName: URL * ?subscriptionKey: string -> SpeechConfig
    abstract fromHost: hostName: obj * ?subscriptionKey: string -> SpeechConfig
    /// <summary>
    /// Creates an instance of the speech factory with specified initial authorization token and region.
    /// Note: The caller needs to ensure that the authorization token is valid. Before the authorization token
    /// expires, the caller needs to refresh it by calling this setter with a new valid token.
    /// Note: Please use a token derived from your LanguageUnderstanding subscription key in case you want
    /// to use the Intent recognizer. As configuration values are copied when creating a new recognizer,
    /// the new token value will not apply to recognizers that have already been created. For recognizers
    /// that have been created before, you need to set authorization token of the corresponding recognizer
    /// to refresh the token. Otherwise, the recognizers will encounter errors during recognition.
    /// </summary>
    /// <param name="authorizationToken">The initial authorization token.</param>
    /// <param name="region">The region name (see the &lt;a href="<see href="https://aka.ms/csspeech/region"&gt;region" /> page&lt;/a&gt;).</param>
    /// <returns>A speech factory instance.</returns>
    abstract fromAuthorizationToken: authorizationToken: string * region: string -> SpeechConfig

type [<AllowNullLiteral>] SpeechConfigImpl =
    inherit SpeechConfig
    abstract properties: PropertyCollection
    // abstract endPoint: URL
    abstract endPoint: obj
    abstract subscriptionKey: string
    abstract region: string
    /// Gets the authorization token.
    abstract authorizationToken: string with get, set
    /// Returns the configured language.
    abstract speechRecognitionLanguage: string with get, set
    abstract autoDetectSourceLanguages: string with get, set
    /// Gets speech recognition output format (simple or detailed).
    /// Note: This output format is for speech recognition result, use [SpeechConfig.speechSynthesisOutputFormat] to
    /// get synthesized audio output format.
    abstract outputFormat: OutputFormat with get, set
    /// Gets the endpoint ID of a customized speech model that is used for speech recognition.
    abstract endpointId: string with get, set
    /// Sets an arbitrary property.
    abstract setProperty: name: U2<string, PropertyId> * value: string -> unit
    /// Returns the current value of an arbitrary property.
    abstract getProperty: name: U2<string, PropertyId> * ?def: string -> string
    /// Sets the proxy configuration.
    /// Only relevant in Node.js environments.
    /// Added in version 1.4.0.
    abstract setProxy: proxyHostName: string * proxyPort: float -> unit
    /// Sets the proxy configuration.
    /// Only relevant in Node.js environments.
    /// Added in version 1.4.0.
    abstract setProxy: proxyHostName: string * proxyPort: float * proxyUserName: string * proxyPassword: string -> unit
    /// Sets a property value that will be passed to service using the specified channel.
    /// Added in version 1.7.0.
    abstract setServiceProperty: name: string * value: string -> unit
    /// Sets profanity option.
    /// Added in version 1.7.0.
    abstract setProfanity: profanity: ProfanityOption -> unit
    /// Enable audio logging in service.
    /// Audio and content logs are stored either in Microsoft-owned storage, or in your own storage account linked
    /// to your Cognitive Services subscription (Bring Your Own Storage (BYOS) enabled Speech resource).
    /// The logs will be removed after 30 days.
    /// Added in version 1.7.0.
    abstract enableAudioLogging: unit -> unit
    /// Includes word-level timestamps.
    /// Added in version 1.7.0.
    abstract requestWordLevelTimestamps: unit -> unit
    /// Enable dictation. Only supported in speech continuous recognition.
    /// Added in version 1.7.0.
    abstract enableDictation: unit -> unit
    abstract clone: unit -> SpeechConfigImpl
    /// Gets the language of the speech synthesizer.
    /// Added in version 1.11.0.
    abstract speechSynthesisLanguage: string with get, set
    /// Gets the voice of the speech synthesizer.
    /// Added in version 1.11.0.
    abstract speechSynthesisVoiceName: string with get, set
    /// Gets the speech synthesis output format.
    /// Added in version 1.11.0.
    abstract speechSynthesisOutputFormat: SpeechSynthesisOutputFormat with get, set

type [<AllowNullLiteral>] SpeechConfigImplStatic =
    [<EmitConstructor>] abstract Create: unit -> SpeechConfigImpl

/// <summary>Speech translation configuration.</summary>
type [<AllowNullLiteral>] SpeechTranslationConfig =
    inherit SpeechConfig
    /// <summary>
    /// Gets/Sets the authorization token.
    /// Note: The caller needs to ensure that the authorization token is valid. Before the authorization token
    /// expires, the caller needs to refresh it by calling this setter with a new valid token.
    /// </summary>
    /// <param name="value">The authorization token.</param>
    abstract authorizationToken: string with set
    /// <summary>Gets/Sets the speech recognition language.</summary>
    /// <param name="value">The authorization token.</param>
    abstract speechRecognitionLanguage: string with set
    /// <summary>Add a (text) target language to translate into.</summary>
    /// <param name="value">The language such as de-DE</param>
    abstract addTargetLanguage: value: string -> unit
    /// <summary>Gets the (text) target language to translate into.</summary>
    /// <param name="value">The language such as de-DE</param>
    abstract targetLanguages: ResizeArray<string>
    /// <summary>
    /// Gets the selected voice name.
    /// Gets/Sets voice of the translated language, enable voice synthesis output.
    /// </summary>
    /// <returns>The voice name.</returns>
    abstract voiceName: string with get, set
    /// <summary>Sets a named property as value</summary>
    /// <param name="name">The name of the property to set.</param>
    /// <param name="value">The new value of the property.</param>
    abstract setProperty: name: U2<string, PropertyId> * value: string -> unit
    /// <summary>Dispose of associated resources.</summary>
    abstract close: unit -> unit

/// <summary>Speech translation configuration.</summary>
type [<AllowNullLiteral>] SpeechTranslationConfigStatic =
    /// Creates an instance of recognizer config.
    [<EmitConstructor>] abstract Create: unit -> SpeechTranslationConfig
    /// <summary>Static instance of SpeechTranslationConfig returned by passing a subscription key and service region.</summary>
    /// <param name="subscriptionKey">The subscription key.</param>
    /// <param name="region">The region name (see the &lt;a href="<see href="https://aka.ms/csspeech/region"&gt;region" /> page&lt;/a&gt;).</param>
    /// <returns>The speech translation config.</returns>
    abstract fromSubscription: subscriptionKey: string * region: string -> SpeechTranslationConfig
    /// <summary>
    /// Static instance of SpeechTranslationConfig returned by passing authorization token and service region.
    /// Note: The caller needs to ensure that the authorization token is valid. Before the authorization token
    /// expires, the caller needs to refresh it by setting the property authorizationToken with a new
    /// valid token. Otherwise, all the recognizers created by this SpeechTranslationConfig instance
    /// will encounter errors during recognition.
    /// As configuration values are copied when creating a new recognizer, the new token value will not apply
    /// to recognizers that have already been created.
    /// For recognizers that have been created before, you need to set authorization token of the corresponding recognizer
    /// to refresh the token. Otherwise, the recognizers will encounter errors during recognition.
    /// </summary>
    /// <param name="authorizationToken">The authorization token.</param>
    /// <param name="region">The region name (see the &lt;a href="<see href="https://aka.ms/csspeech/region"&gt;region" /> page&lt;/a&gt;).</param>
    /// <returns>The speech translation config.</returns>
    abstract fromAuthorizationToken: authorizationToken: string * region: string -> SpeechTranslationConfig
    /// <summary>
    /// Creates an instance of the speech config with specified host and subscription key.
    /// This method is intended only for users who use a non-default service host. Standard resource path will be assumed.
    /// For services with a non-standard resource path or no path at all, use fromEndpoint instead.
    /// Note: Query parameters are not allowed in the host URI and must be set by other APIs.
    /// Note: To use an authorization token with fromHost, use fromHost(URL),
    /// and then set the AuthorizationToken property on the created SpeechConfig instance.
    /// Note: Added in version 1.9.0.
    /// </summary>
    /// <param name="host">The service endpoint to connect to. Format is "<see href="protocol://host:port"" /> where ":port" is optional.</param>
    /// <param name="subscriptionKey">The subscription key. If a subscription key is not specified, an authorization token must be set.</param>
    /// <returns>A speech factory instance.</returns>
    // abstract fromHost: hostName: URL * ?subscriptionKey: string -> SpeechConfig
    abstract fromHost: hostName: obj * ?subscriptionKey: string -> SpeechConfig
    /// <summary>
    /// Creates an instance of the speech translation config with specified endpoint and subscription key.
    /// This method is intended only for users who use a non-standard service endpoint or paramters.
    /// Note: The query properties specified in the endpoint URL are not changed, even if they are
    /// set by any other APIs. For example, if language is defined in the uri as query parameter
    /// "language=de-DE", and also set by the speechRecognitionLanguage property, the language
    /// setting in uri takes precedence, and the effective language is "de-DE".
    /// Only the properties that are not specified in the endpoint URL can be set by other APIs.
    /// Note: To use authorization token with fromEndpoint, pass an empty string to the subscriptionKey in the
    /// fromEndpoint method, and then set authorizationToken="token" on the created SpeechConfig instance to
    /// use the authorization token.
    /// </summary>
    /// <param name="endpoint">The service endpoint to connect to.</param>
    /// <param name="subscriptionKey">The subscription key.</param>
    /// <returns>A speech config instance.</returns>
    // abstract fromEndpoint: endpoint: URL * subscriptionKey: string -> SpeechTranslationConfig
    abstract fromEndpoint: endpoint: obj * subscriptionKey: string -> SpeechTranslationConfig

type [<AllowNullLiteral>] SpeechTranslationConfigImpl =
    inherit SpeechTranslationConfig
    /// <summary>
    /// Gets/Sets the authorization token.
    /// If this is set, subscription key is ignored.
    /// User needs to make sure the provided authorization token is valid and not expired.
    /// </summary>
    /// <param name="value">The authorization token.</param>
    abstract authorizationToken: string with set
    /// <summary>
    /// Sets the speech recognition language.
    /// Gets the speech recognition language.
    /// </summary>
    /// <returns>The speechRecognitionLanguage.</returns>
    abstract speechRecognitionLanguage: string with get, set
    abstract subscriptionKey: string
    /// <summary>
    /// Gets the output format
    /// Gets/Sets the output format
    /// </summary>
    abstract outputFormat: OutputFormat with get, set
    /// <summary>
    /// Gets the endpoint id.
    /// Gets/Sets the endpoint id.
    /// </summary>
    abstract endpointId: string with get, set
    /// <summary>Add a (text) target language to translate into.</summary>
    /// <param name="value">The language such as de-DE</param>
    abstract addTargetLanguage: value: string -> unit
    /// <summary>Gets the (text) target language to translate into.</summary>
    /// <param name="value">The language such as de-DE</param>
    abstract targetLanguages: ResizeArray<string>
    /// <summary>
    /// Gets the voice name.
    /// Gets/Sets the voice of the translated language, enable voice synthesis output.
    /// </summary>
    abstract voiceName: string with get, set
    /// <summary>Provides the region.</summary>
    /// <returns>The region.</returns>
    abstract region: string
    /// Sets the proxy configuration.
    /// Only relevant in Node.js environments.
    /// Added in version 1.4.0.
    abstract setProxy: proxyHostName: string * proxyPort: float -> unit
    /// Sets the proxy configuration.
    /// Only relevant in Node.js environments.
    /// Added in version 1.4.0.
    abstract setProxy: proxyHostName: string * proxyPort: float * proxyUserName: string * proxyPassword: string -> unit
    /// <summary>Gets an arbitrary property value.</summary>
    /// <param name="name">The name of the property.</param>
    /// <param name="def">The default value of the property in case it is not set.</param>
    /// <returns>The value of the property.</returns>
    abstract getProperty: name: string * ?def: string -> string
    /// <summary>Gets/Sets an arbitrary property value.</summary>
    /// <param name="name">The name of the property to set.</param>
    /// <param name="value">The value of the property.</param>
    abstract setProperty: name: U2<string, PropertyId> * value: string -> unit
    /// <summary>Provides access to custom properties.</summary>
    /// <returns>The properties.</returns>
    abstract properties: PropertyCollection
    /// <summary>Dispose of associated resources.</summary>
    abstract close: unit -> unit
    /// Sets a property value that will be passed to service using the specified channel.
    /// Added in version 1.7.0.
    abstract setServiceProperty: name: string * value: string -> unit
    /// Sets profanity option.
    /// Added in version 1.7.0.
    abstract setProfanity: profanity: ProfanityOption -> unit
    /// Enable audio logging in service.
    /// Audio and content logs are stored either in Microsoft-owned storage, or in your own storage account linked
    /// to your Cognitive Services subscription (Bring Your Own Storage (BYOS) enabled Speech resource).
    /// The logs will be removed after 30 days.
    /// Added in version 1.7.0.
    abstract enableAudioLogging: unit -> unit
    /// Includes word-level timestamps.
    /// Added in version 1.7.0.
    abstract requestWordLevelTimestamps: unit -> unit
    /// Enable dictation. Only supported in speech continuous recognition.
    /// Added in version 1.7.0.
    abstract enableDictation: unit -> unit
    /// Gets the language of the speech synthesizer.
    /// Added in version 1.11.0.
    abstract speechSynthesisLanguage: string with get, set
    /// Gets the voice of the speech synthesizer.
    /// Added in version 1.11.0.
    abstract speechSynthesisVoiceName: string with get, set
    /// Gets the speech synthesis output format.
    /// Added in version 1.11.0.
    abstract speechSynthesisOutputFormat: SpeechSynthesisOutputFormat with get, set

type [<AllowNullLiteral>] SpeechTranslationConfigImplStatic =
    [<EmitConstructor>] abstract Create: unit -> SpeechTranslationConfigImpl

/// <summary>Represents collection of properties and their values.</summary>
type [<AllowNullLiteral>] PropertyCollection =
    /// <summary>
    /// Returns the property value in type String.
    /// Currently only String, int and bool are allowed.
    /// If the name is not available, the specified defaultValue is returned.
    /// </summary>
    /// <param name="key">The parameter name.</param>
    /// <param name="def">
    /// The default value which is returned if the parameter
    /// is not available in the collection.
    /// </param>
    /// <returns>value of the parameter.</returns>
    abstract getProperty: key: U2<PropertyId, string> * ?def: U3<string, float, bool> -> string
    /// <summary>Sets the String value of the parameter specified by name.</summary>
    /// <param name="key">The parameter name.</param>
    /// <param name="value">The value of the parameter.</param>
    abstract setProperty: key: U2<string, PropertyId> * value: string -> unit
    /// <summary>Clones the collection.</summary>
    /// <returns>A copy of the collection.</returns>
    abstract clone: unit -> PropertyCollection
    /// <summary>Merges this set of properties into another, no overwrites.</summary>
    /// <param name="destinationCollection">The collection to merge into.</param>
    abstract mergeTo: destinationCollection: PropertyCollection -> unit
    /// <summary>Get the keys in Property Collection.</summary>
    /// <returns>Keys in the collection.</returns>
    abstract keys: ResizeArray<string>

/// <summary>Represents collection of properties and their values.</summary>
type [<AllowNullLiteral>] PropertyCollectionStatic =
    [<EmitConstructor>] abstract Create: unit -> PropertyCollection

/// <summary>Defines speech property ids.</summary>
type [<RequireQualifiedAccess>] PropertyId =
    /// <summary>
    /// The Cognitive Services Speech Service subscription Key. If you are using an intent recognizer, you need to
    /// specify the LUIS endpoint key for your particular LUIS app. Under normal circumstances, you shouldn't
    /// have to use this property directly.
    /// Instead, use [[SpeechConfig.fromSubscription]].
    /// </summary>
    | SpeechServiceConnection_Key = 0
    /// <summary>
    /// The Cognitive Services Speech Service endpoint (url). Under normal circumstances, you shouldn't
    /// have to use this property directly.
    /// Instead, use [[SpeechConfig.fromEndpoint]].
    /// NOTE: This endpoint is not the same as the endpoint used to obtain an access token.
    /// </summary>
    | SpeechServiceConnection_Endpoint = 1
    /// <summary>
    /// The Cognitive Services Speech Service region. Under normal circumstances, you shouldn't have to
    /// use this property directly.
    /// Instead, use [[SpeechConfig.fromSubscription]], [[SpeechConfig.fromEndpoint]], [[SpeechConfig.fromAuthorizationToken]].
    /// </summary>
    | SpeechServiceConnection_Region = 2
    /// <summary>
    /// The Cognitive Services Speech Service authorization token (aka access token). Under normal circumstances,
    /// you shouldn't have to use this property directly.
    /// Instead, use [[SpeechConfig.fromAuthorizationToken]], [[SpeechRecognizer.authorizationToken]],
    /// [[IntentRecognizer.authorizationToken]], [[TranslationRecognizer.authorizationToken]], [[SpeakerRecognizer.authorizationToken]].
    /// </summary>
    | SpeechServiceAuthorization_Token = 3
    /// <summary>The Cognitive Services Speech Service authorization type. Currently unused.</summary>
    | SpeechServiceAuthorization_Type = 4
    /// <summary>
    /// The Cognitive Services Speech Service endpoint id. Under normal circumstances, you shouldn't
    /// have to use this property directly.
    /// Instead, use [[SpeechConfig.endpointId]].
    /// NOTE: The endpoint id is available in the Speech Portal, listed under Endpoint Details.
    /// </summary>
    | SpeechServiceConnection_EndpointId = 5
    /// <summary>
    /// The list of comma separated languages (BCP-47 format) used as target translation languages. Under normal circumstances,
    /// you shouldn't have to use this property directly.
    /// Instead use [[SpeechTranslationConfig.addTargetLanguage]],
    /// [[SpeechTranslationConfig.targetLanguages]], [[TranslationRecognizer.targetLanguages]].
    /// </summary>
    | SpeechServiceConnection_TranslationToLanguages = 6
    /// <summary>
    /// The name of the Cognitive Service Text to Speech Service Voice. Under normal circumstances, you shouldn't have to use this
    /// property directly.
    /// Instead, use [[SpeechTranslationConfig.voiceName]].
    /// NOTE: Valid voice names can be found &lt;a href="<see href="https://aka.ms/csspeech/voicenames"&gt;here&lt;/a&gt;." />
    /// </summary>
    | SpeechServiceConnection_TranslationVoice = 7
    /// <summary>Translation features.</summary>
    | SpeechServiceConnection_TranslationFeatures = 8
    /// <summary>
    /// The Language Understanding Service Region. Under normal circumstances, you shouldn't have to use this property directly.
    /// Instead, use [[LanguageUnderstandingModel]].
    /// </summary>
    | SpeechServiceConnection_IntentRegion = 9
    /// The host name of the proxy server used to connect to the Cognitive Services Speech Service. Only relevant in Node.js environments.
    /// You shouldn't have to use this property directly.
    /// Instead use &lt;see cref="SpeechConfig.SetProxy(string,int,string,string)"/&gt;.
    /// Added in version 1.4.0.
    | SpeechServiceConnection_ProxyHostName = 10
    /// The port of the proxy server used to connect to the Cognitive Services Speech Service. Only relevant in Node.js environments.
    /// You shouldn't have to use this property directly.
    /// Instead use &lt;see cref="SpeechConfig.SetProxy(string,int,string,string)"/&gt;.
    /// Added in version 1.4.0.
    | SpeechServiceConnection_ProxyPort = 11
    /// The user name of the proxy server used to connect to the Cognitive Services Speech Service. Only relevant in Node.js environments.
    /// You shouldn't have to use this property directly.
    /// Instead use &lt;see cref="SpeechConfig.SetProxy(string,int,string,string)"/&gt;.
    /// Added in version 1.4.0.
    | SpeechServiceConnection_ProxyUserName = 12
    /// The password of the proxy server used to connect to the Cognitive Services Speech Service. Only relevant in Node.js environments.
    /// You shouldn't have to use this property directly.
    /// Instead use &lt;see cref="SpeechConfig.SetProxy(string,int,string,string)"/&gt;.
    /// Added in version 1.4.0.
    | SpeechServiceConnection_ProxyPassword = 13
    /// <summary>
    /// The Cognitive Services Speech Service recognition Mode. Can be "INTERACTIVE", "CONVERSATION", "DICTATION".
    /// This property is intended to be read-only. The SDK is using it internally.
    /// </summary>
    | SpeechServiceConnection_RecoMode = 14
    /// <summary>
    /// The spoken language to be recognized (in BCP-47 format). Under normal circumstances, you shouldn't have to use this property
    /// directly.
    /// Instead, use [[SpeechConfig.speechRecognitionLanguage]].
    /// </summary>
    | SpeechServiceConnection_RecoLanguage = 15
    /// <summary>
    /// The session id. This id is a universally unique identifier (aka UUID) representing a specific binding of an audio input stream
    /// and the underlying speech recognition instance to which it is bound. Under normal circumstances, you shouldn't have to use this
    /// property directly.
    /// Instead use [[SessionEventArgs.sessionId]].
    /// </summary>
    | Speech_SessionId = 16
    /// <summary>The spoken language to be synthesized (e.g. en-US)</summary>
    | SpeechServiceConnection_SynthLanguage = 17
    /// <summary>The name of the TTS voice to be used for speech synthesis</summary>
    | SpeechServiceConnection_SynthVoice = 18
    /// <summary>The string to specify TTS output audio format</summary>
    | SpeechServiceConnection_SynthOutputFormat = 19
    /// <summary>
    /// The list of comma separated languages used as possible source languages
    /// Added in version 1.13.0
    /// </summary>
    | SpeechServiceConnection_AutoDetectSourceLanguages = 20
    /// <summary>
    /// The requested Cognitive Services Speech Service response output format (simple or detailed). Under normal circumstances, you shouldn't have
    /// to use this property directly.
    /// Instead use [[SpeechConfig.outputFormat]].
    /// </summary>
    | SpeechServiceResponse_RequestDetailedResultTrueFalse = 21
    /// <summary>The requested Cognitive Services Speech Service response output profanity level. Currently unused.</summary>
    | SpeechServiceResponse_RequestProfanityFilterTrueFalse = 22
    /// <summary>The Cognitive Services Speech Service response output (in JSON format). This property is available on recognition result objects only.</summary>
    | SpeechServiceResponse_JsonResult = 23
    /// <summary>
    /// The Cognitive Services Speech Service error details (in JSON format). Under normal circumstances, you shouldn't have to
    /// use this property directly. Instead use [[CancellationDetails.errorDetails]].
    /// </summary>
    | SpeechServiceResponse_JsonErrorDetails = 24
    /// <summary>The cancellation reason. Currently unused.</summary>
    | CancellationDetails_Reason = 25
    /// <summary>The cancellation text. Currently unused.</summary>
    | CancellationDetails_ReasonText = 26
    /// <summary>The Cancellation detailed text. Currently unused.</summary>
    | CancellationDetails_ReasonDetailedText = 27
    /// <summary>The Language Understanding Service response output (in JSON format). Available via [[IntentRecognitionResult]]</summary>
    | LanguageUnderstandingServiceResponse_JsonResult = 28
    /// The URL string built from speech configuration.
    /// This property is intended to be read-only. The SDK is using it internally.
    /// NOTE: Added in version 1.7.0.
    | SpeechServiceConnection_Url = 29
    /// The initial silence timeout value (in milliseconds) used by the service.
    /// Added in version 1.7.0
    | SpeechServiceConnection_InitialSilenceTimeoutMs = 30
    /// The end silence timeout value (in milliseconds) used by the service.
    /// Added in version 1.7.0
    | SpeechServiceConnection_EndSilenceTimeoutMs = 31
    /// <summary>
    /// A duration of detected silence, measured in milliseconds, after which speech-to-text will determine a spoken
    /// phrase has ended and generate a final Recognized result. Configuring this timeout may be helpful in situations
    /// where spoken input is significantly faster or slower than usual and default segmentation behavior consistently
    /// yields results that are too long or too short. Segmentation timeout values that are inappropriately high or low
    /// can negatively affect speech-to-text accuracy; this property should be carefully configured and the resulting
    /// behavior should be thoroughly validated as intended.
    ///
    /// For more information about timeout configuration that includes discussion of default behaviors, please visit
    /// <see href="https://aka.ms/csspeech/timeouts." />
    ///
    /// Added in version 1.21.0.
    /// </summary>
    | Speech_SegmentationSilenceTimeoutMs = 32
    /// A boolean value specifying whether audio logging is enabled in the service or not.
    /// Audio and content logs are stored either in Microsoft-owned storage, or in your own storage account linked
    /// to your Cognitive Services subscription (Bring Your Own Storage (BYOS) enabled Speech resource).
    /// The logs will be removed after 30 days.
    /// Added in version 1.7.0
    | SpeechServiceConnection_EnableAudioLogging = 33
    /// <summary>
    /// The speech service connection language identifier mode.
    /// Can be "AtStart" (the default), or "Continuous". See Language
    /// Identification document <see href="https://aka.ms/speech/lid?pivots=programming-language-javascript" />
    /// for more details.
    /// Added in 1.25.0
    /// </summary>
    | SpeechServiceConnection_LanguageIdMode = 34
    /// A string value representing the desired endpoint version to target for Speech Recognition.
    /// Added in version 1.21.0
    | SpeechServiceConnection_RecognitionEndpointVersion = 35
    /// /**
    ///      A string value the current speaker recognition scenario/mode (TextIndependentIdentification, etc.).
    ///      Added in version 1.23.0
    | SpeechServiceConnection_SpeakerIdMode = 36
    /// The requested Cognitive Services Speech Service response output profanity setting.
    /// Allowed values are "masked", "removed", and "raw".
    /// Added in version 1.7.0.
    | SpeechServiceResponse_ProfanityOption = 37
    /// A string value specifying which post processing option should be used by service.
    /// Allowed values are "TrueText".
    /// Added in version 1.7.0
    | SpeechServiceResponse_PostProcessingOption = 38
    /// A boolean value specifying whether to include word-level timestamps in the response result.
    /// Added in version 1.7.0
    | SpeechServiceResponse_RequestWordLevelTimestamps = 39
    /// The number of times a word has to be in partial results to be returned.
    /// Added in version 1.7.0
    | SpeechServiceResponse_StablePartialResultThreshold = 40
    /// A string value specifying the output format option in the response result. Internal use only.
    /// Added in version 1.7.0.
    | SpeechServiceResponse_OutputFormatOption = 41
    /// A boolean value to request for stabilizing translation partial results by omitting words in the end.
    /// Added in version 1.7.0.
    | SpeechServiceResponse_TranslationRequestStablePartialResult = 42
    /// <summary>A boolean value specifying whether to request WordBoundary events.</summary>
    | SpeechServiceResponse_RequestWordBoundary = 43
    /// <summary>A boolean value specifying whether to request punctuation boundary in WordBoundary Events. Default is true.</summary>
    | SpeechServiceResponse_RequestPunctuationBoundary = 44
    /// <summary>A boolean value specifying whether to request sentence boundary in WordBoundary Events. Default is false.</summary>
    | SpeechServiceResponse_RequestSentenceBoundary = 45
    /// <summary>Identifier used to connect to the backend service.</summary>
    | Conversation_ApplicationId = 46
    /// <summary>Type of dialog backend to connect to.</summary>
    | Conversation_DialogType = 47
    /// <summary>Silence timeout for listening</summary>
    | Conversation_Initial_Silence_Timeout = 48
    /// <summary>From Id to add to speech recognition activities.</summary>
    | Conversation_From_Id = 49
    /// <summary>ConversationId for the session.</summary>
    | Conversation_Conversation_Id = 50
    /// <summary>Comma separated list of custom voice deployment ids.</summary>
    | Conversation_Custom_Voice_Deployment_Ids = 51
    /// <summary>Speech activity template, stamp properties from the template on the activity generated by the service for speech.</summary>
    | Conversation_Speech_Activity_Template = 52
    /// <summary>Enables or disables the receipt of turn status messages as obtained on the turnStatusReceived event.</summary>
    | Conversation_Request_Bot_Status_Messages = 53
    /// Specifies the connection ID to be provided in the Agent configuration message, e.g. a Direct Line token for
    /// channel authentication.
    /// Added in version 1.15.1.
    | Conversation_Agent_Connection_Id = 54
    /// The Cognitive Services Speech Service host (url). Under normal circumstances, you shouldn't have to use this property directly.
    /// Instead, use [[SpeechConfig.fromHost]].
    | SpeechServiceConnection_Host = 55
    /// Set the host for service calls to the Conversation Translator REST management and websocket calls.
    | ConversationTranslator_Host = 56
    /// Optionally set the the host's display name.
    /// Used when joining a conversation.
    | ConversationTranslator_Name = 57
    /// Optionally set a value for the X-CorrelationId request header.
    /// Used for troubleshooting errors in the server logs. It should be a valid guid.
    | ConversationTranslator_CorrelationId = 58
    /// Set the conversation token to be sent to the speech service. This enables the
    /// service to service call from the speech service to the Conversation Translator service for relaying
    /// recognitions. For internal use.
    | ConversationTranslator_Token = 59
    /// <summary>
    /// The reference text of the audio for pronunciation evaluation.
    /// For this and the following pronunciation assessment parameters, see
    /// <see href="https://docs.microsoft.com/azure/cognitive-services/speech-service/rest-speech-to-text#pronunciation-assessment-parameters" /> for details.
    /// Under normal circumstances, you shouldn't have to use this property directly.
    /// Added in version 1.15.0
    /// </summary>
    | PronunciationAssessment_ReferenceText = 60
    /// The point system for pronunciation score calibration (FivePoint or HundredMark).
    /// Under normal circumstances, you shouldn't have to use this property directly.
    /// Added in version 1.15.0
    | PronunciationAssessment_GradingSystem = 61
    /// The pronunciation evaluation granularity (Phoneme, Word, or FullText).
    /// Under normal circumstances, you shouldn't have to use this property directly.
    /// Added in version 1.15.0
    | PronunciationAssessment_Granularity = 62
    /// Defines if enable miscue calculation.
    /// With this enabled, the pronounced words will be compared to the reference text,
    /// and will be marked with omission/insertion based on the comparison. The default setting is False.
    /// Under normal circumstances, you shouldn't have to use this property directly.
    /// Added in version 1.15.0
    | PronunciationAssessment_EnableMiscue = 63
    /// The json string of pronunciation assessment parameters
    /// Under normal circumstances, you shouldn't have to use this property directly.
    /// Added in version 1.15.0
    | PronunciationAssessment_Json = 64
    /// Pronunciation assessment parameters.
    /// This property is intended to be read-only. The SDK is using it internally.
    /// Added in version 1.15.0
    | PronunciationAssessment_Params = 65
    /// Version of Speaker Recognition API to use.
    /// Added in version 1.18.0
    | SpeakerRecognition_Api_Version = 66

/// <summary>Defines the base class Recognizer which mainly contains common event handlers.</summary>
type [<AllowNullLiteral>] Recognizer =
    abstract audioConfig: AudioConfig with get, set
    abstract privReco: ServiceRecognizerBase with get, set
    abstract privProperties: PropertyCollection with get, set
    /// <summary>Defines event handler for session started events.</summary>
    abstract sessionStarted: (Recognizer -> SessionEventArgs -> unit) with get, set
    /// <summary>Defines event handler for session stopped events.</summary>
    abstract sessionStopped: (Recognizer -> SessionEventArgs -> unit) with get, set
    /// <summary>Defines event handler for speech started events.</summary>
    abstract speechStartDetected: (Recognizer -> RecognitionEventArgs -> unit) with get, set
    /// <summary>Defines event handler for speech stopped events.</summary>
    abstract speechEndDetected: (Recognizer -> RecognitionEventArgs -> unit) with get, set
    /// <summary>Dispose of associated resources.</summary>
    abstract close: ?cb: (unit -> unit) * ?errorCb: (string -> unit) -> unit
    abstract internalData: obj
    /// <summary>
    /// This method performs cleanup of resources.
    /// The Boolean parameter disposing indicates whether the method is called
    /// from Dispose (if disposing is true) or from the finalizer (if disposing is false).
    /// Derived classes should override this method to dispose resource if needed.
    /// </summary>
    /// <param name="disposing">Flag to request disposal.</param>
    abstract dispose: disposing: bool -> Promise<unit>
    abstract createRecognizerConfig: speechConfig: SpeechServiceConfig -> RecognizerConfig
    abstract createServiceRecognizer: authentication: IAuthentication * connectionFactory: IConnectionFactory * audioConfig: AudioConfig * recognizerConfig: RecognizerConfig -> ServiceRecognizerBase
    abstract implCommonRecognizerSetup: unit -> unit
    abstract recognizeOnceAsyncImpl: recognitionMode: RecognitionMode -> Promise<SpeechRecognitionResult>
    abstract startContinuousRecognitionAsyncImpl: recognitionMode: RecognitionMode -> Promise<unit>
    abstract stopContinuousRecognitionAsyncImpl: unit -> Promise<unit>
    abstract implRecognizerStop: unit -> Promise<unit>

/// <summary>Defines the base class Recognizer which mainly contains common event handlers.</summary>
type [<AllowNullLiteral>] RecognizerStatic =
    /// <summary>Creates and initializes an instance of a Recognizer</summary>
    /// <param name="audioInput">An optional audio input stream associated with the recognizer</param>
    [<EmitConstructor>] abstract Create: audioConfig: AudioConfig * properties: PropertyCollection * connectionFactory: IConnectionFactory -> Recognizer
    /// <summary>This method returns the current state of the telemetry setting.</summary>
    /// <returns>true if the telemetry is enabled, false otherwise.</returns>
    abstract telemetryEnabled: bool
    /// <summary>This method globally enables or disables telemetry.</summary>
    /// <param name="enabled">
    /// Global setting for telemetry collection.
    /// If set to true, telemetry information like microphone errors,
    /// recognition errors are collected and sent to Microsoft.
    /// If set to false, no telemetry is sent to Microsoft.
    /// </param>
    abstract enableTelemetry: enabled: bool -> unit
    abstract getAuthFromProperties: properties: PropertyCollection -> IAuthentication

/// <summary>Performs speech recognition from microphone, file, or other audio input streams, and gets transcribed text as result.</summary>
type [<AllowNullLiteral>] SpeechRecognizer =
    inherit Recognizer
    /// <summary>The event recognizing signals that an intermediate recognition result is received.</summary>
    abstract recognizing: (Recognizer -> SpeechRecognitionEventArgs -> unit) with get, set
    /// <summary>The event recognized signals that a final recognition result is received.</summary>
    abstract recognized: (Recognizer -> SpeechRecognitionEventArgs -> unit) with get, set
    /// <summary>The event canceled signals that an error occurred during recognition.</summary>
    abstract canceled: (Recognizer -> SpeechRecognitionCanceledEventArgs -> unit) with get, set
    /// <summary>Gets the endpoint id of a customized speech model that is used for speech recognition.</summary>
    /// <returns>the endpoint id of a customized speech model that is used for speech recognition.</returns>
    abstract endpointId: string
    /// <summary>
    /// Gets the authorization token used to communicate with the service.
    /// Gets/Sets the authorization token used to communicate with the service.
    /// </summary>
    /// <returns>Authorization token.</returns>
    abstract authorizationToken: string with get, set
    /// <summary>Gets the spoken language of recognition.</summary>
    /// <returns>The spoken language of recognition.</returns>
    abstract speechRecognitionLanguage: string
    /// <summary>Gets the output format of recognition.</summary>
    /// <returns>The output format of recognition.</returns>
    abstract outputFormat: OutputFormat
    /// <summary>The collection of properties and their values defined for this SpeechRecognizer.</summary>
    /// <returns>The collection of properties and their values defined for this SpeechRecognizer.</returns>
    abstract properties: PropertyCollection
    /// <summary>
    /// Starts speech recognition, and stops after the first utterance is recognized.
    /// The task returns the recognition text as result.
    /// Note: RecognizeOnceAsync() returns when the first utterance has been recognized,
    /// so it is suitable only for single shot recognition
    /// like command or query. For long-running recognition, use StartContinuousRecognitionAsync() instead.
    /// </summary>
    /// <param name="cb">Callback that received the SpeechRecognitionResult.</param>
    /// <param name="err">Callback invoked in case of an error.</param>
    abstract recognizeOnceAsync: ?cb: (SpeechRecognitionResult -> unit) * ?err: (string -> unit) -> unit
    /// <summary>
    /// Starts speech recognition, until stopContinuousRecognitionAsync() is called.
    /// User must subscribe to events to receive recognition results.
    /// </summary>
    /// <param name="cb">Callback invoked once the recognition has started.</param>
    /// <param name="err">Callback invoked in case of an error.</param>
    abstract startContinuousRecognitionAsync: ?cb: (unit -> unit) * ?err: (string -> unit) -> unit
    /// <summary>Stops continuous speech recognition.</summary>
    /// <param name="cb">Callback invoked once the recognition has stopped.</param>
    /// <param name="err">Callback invoked in case of an error.</param>
    abstract stopContinuousRecognitionAsync: ?cb: (unit -> unit) * ?err: (string -> unit) -> unit
    /// <summary>
    /// Starts speech recognition with keyword spotting, until
    /// stopKeywordRecognitionAsync() is called.
    /// User must subscribe to events to receive recognition results.
    /// Note: Key word spotting functionality is only available on the
    /// Speech Devices SDK. This functionality is currently not included in the SDK itself.
    /// </summary>
    /// <param name="model">
    /// The keyword recognition model that
    /// specifies the keyword to be recognized.
    /// </param>
    /// <param name="cb">Callback invoked once the recognition has started.</param>
    /// <param name="err">Callback invoked in case of an error.</param>
    abstract startKeywordRecognitionAsync: model: KeywordRecognitionModel * ?cb: (unit -> unit) * ?err: (string -> unit) -> unit
    /// <summary>
    /// Stops continuous speech recognition.
    /// Note: Key word spotting functionality is only available on the
    /// Speech Devices SDK. This functionality is currently not included in the SDK itself.
    /// </summary>
    /// <param name="cb">Callback invoked once the recognition has stopped.</param>
    /// <param name="err">Callback invoked in case of an error.</param>
    abstract stopKeywordRecognitionAsync: ?cb: (unit -> unit) -> unit
    /// <summary>closes all external resources held by an instance of this class.</summary>
    abstract close: ?cb: (unit -> unit) * ?errorCb: (string -> unit) -> unit
    /// <summary>Disposes any resources held by the object.</summary>
    /// <param name="disposing">true if disposing the object.</param>
    abstract dispose: disposing: bool -> Promise<unit>
    abstract createRecognizerConfig: speechConfig: SpeechServiceConfig -> RecognizerConfig
    abstract createServiceRecognizer: authentication: IAuthentication * connectionFactory: IConnectionFactory * audioConfig: AudioConfig * recognizerConfig: RecognizerConfig -> ServiceRecognizerBase

/// <summary>Performs speech recognition from microphone, file, or other audio input streams, and gets transcribed text as result.</summary>
type [<AllowNullLiteral>] SpeechRecognizerStatic =
    /// <summary>SpeechRecognizer constructor.</summary>
    /// <param name="speechConfig">an set of initial properties for this recognizer</param>
    /// <param name="audioConfig">An optional audio configuration associated with the recognizer</param>
    [<EmitConstructor>] abstract Create: speechConfig: SpeechConfig * ?audioConfig: AudioConfig -> SpeechRecognizer
    /// <summary>SpeechRecognizer constructor.</summary>
    /// <param name="speechConfig">an set of initial properties for this recognizer</param>
    /// <param name="autoDetectSourceLanguageConfig">An source language detection configuration associated with the recognizer</param>
    /// <param name="audioConfig">An optional audio configuration associated with the recognizer</param>
    abstract FromConfig: speechConfig: SpeechConfig * autoDetectSourceLanguageConfig: AutoDetectSourceLanguageConfig * ?audioConfig: AudioConfig -> SpeechRecognizer

/// <summary>Intent recognizer.</summary>
type [<AllowNullLiteral>] IntentRecognizer =
    inherit Recognizer
    /// <summary>The event recognizing signals that an intermediate recognition result is received.</summary>
    abstract recognizing: (IntentRecognizer -> IntentRecognitionEventArgs -> unit) with get, set
    /// <summary>The event recognized signals that a final recognition result is received.</summary>
    abstract recognized: (IntentRecognizer -> IntentRecognitionEventArgs -> unit) with get, set
    /// <summary>The event canceled signals that an error occurred during recognition.</summary>
    abstract canceled: (IntentRecognizer -> IntentRecognitionCanceledEventArgs -> unit) with get, set
    /// <summary>Gets the spoken language of recognition.</summary>
    /// <returns>the spoken language of recognition.</returns>
    abstract speechRecognitionLanguage: string
    /// <summary>
    /// Gets the authorization token used to communicate with the service.
    /// Gets/Sets the authorization token used to communicate with the service.
    /// Note: Please use a token derived from your LanguageUnderstanding subscription key for the Intent recognizer.
    /// </summary>
    /// <returns>Authorization token.</returns>
    abstract authorizationToken: string with get, set
    /// <summary>The collection of properties and their values defined for this IntentRecognizer.</summary>
    /// <returns>
    /// The collection of properties and their
    /// values defined for this IntentRecognizer.
    /// </returns>
    abstract properties: PropertyCollection
    /// <summary>
    /// Starts intent recognition, and stops after the first utterance is recognized.
    /// The task returns the recognition text and intent as result.
    /// Note: RecognizeOnceAsync() returns when the first utterance has been recognized,
    /// so it is suitable only for single shot recognition like command or query.
    /// For long-running recognition, use StartContinuousRecognitionAsync() instead.
    /// </summary>
    /// <param name="cb">Callback that received the recognition has finished with an IntentRecognitionResult.</param>
    /// <param name="err">Callback invoked in case of an error.</param>
    abstract recognizeOnceAsync: ?cb: (IntentRecognitionResult -> unit) * ?err: (string -> unit) -> unit
    /// <summary>
    /// Starts speech recognition, until stopContinuousRecognitionAsync() is called.
    /// User must subscribe to events to receive recognition results.
    /// </summary>
    /// <param name="cb">Callback invoked once the recognition has started.</param>
    /// <param name="err">Callback invoked in case of an error.</param>
    abstract startContinuousRecognitionAsync: ?cb: (unit -> unit) * ?err: (string -> unit) -> unit
    /// <summary>Stops continuous intent recognition.</summary>
    /// <param name="cb">Callback invoked once the recognition has stopped.</param>
    /// <param name="err">Callback invoked in case of an error.</param>
    abstract stopContinuousRecognitionAsync: ?cb: (unit -> unit) * ?err: (string -> unit) -> unit
    /// <summary>
    /// Starts speech recognition with keyword spotting, until stopKeywordRecognitionAsync() is called.
    /// User must subscribe to events to receive recognition results.
    /// Note: Key word spotting functionality is only available on the Speech Devices SDK.
    /// This functionality is currently not included in the SDK itself.
    /// </summary>
    /// <param name="model">The keyword recognition model that specifies the keyword to be recognized.</param>
    /// <param name="cb">Callback invoked once the recognition has started.</param>
    /// <param name="err">Callback invoked in case of an error.</param>
    abstract startKeywordRecognitionAsync: model: KeywordRecognitionModel * ?cb: (unit -> unit) * ?err: (string -> unit) -> unit
    /// <summary>
    /// Stops continuous speech recognition.
    /// Note: Key word spotting functionality is only available on the Speech Devices SDK.
    /// This functionality is currently not included in the SDK itself.
    /// </summary>
    /// <param name="cb">Callback invoked once the recognition has stopped.</param>
    /// <param name="err">Callback invoked in case of an error.</param>
    abstract stopKeywordRecognitionAsync: ?cb: (unit -> unit) * ?err: (string -> unit) -> unit
    /// <summary>Adds a phrase that should be recognized as intent.</summary>
    /// <param name="intentId">A String that represents the identifier of the intent to be recognized.</param>
    /// <param name="phrase">A String that specifies the phrase representing the intent.</param>
    abstract addIntent: simplePhrase: string * ?intentId: string -> unit
    /// <summary>Adds an intent from Language Understanding service for recognition.</summary>
    /// <param name="intentId">
    /// A String that represents the identifier of the intent
    /// to be recognized. Ignored if intentName is empty.
    /// </param>
    /// <param name="model">The intent model from Language Understanding service.</param>
    /// <param name="intentName">
    /// The intent name defined in the intent model. If it
    /// is empty, all intent names defined in the model will be added.
    /// </param>
    abstract addIntentWithLanguageModel: intentId: string * model: LanguageUnderstandingModel * ?intentName: string -> unit
    /// <summary>Adds all intents from the specified Language Understanding Model.</summary>
    /// <param name="model">The language understanding model containing the intents.</param>
    /// <param name="intentId">A custom id String to be returned in the IntentRecognitionResult's getIntentId() method.</param>
    abstract addAllIntents: model: LanguageUnderstandingModel * ?intentId: string -> unit
    /// <summary>closes all external resources held by an instance of this class.</summary>
    abstract close: ?cb: (unit -> unit) * ?errorCb: (string -> unit) -> unit
    abstract createRecognizerConfig: speechConfig: SpeechServiceConfig -> RecognizerConfig
    abstract createServiceRecognizer: authentication: IAuthentication * connectionFactory: IConnectionFactory * audioConfig: AudioConfig * recognizerConfig: RecognizerConfig -> ServiceRecognizerBase
    /// This method performs cleanup of resources.
    /// The Boolean parameter disposing indicates whether the method is called
    /// from Dispose (if disposing is true) or from the finalizer (if disposing is false).
    /// Derived classes should override this method to dispose resource if needed.
    abstract dispose: disposing: bool -> Promise<unit>

/// <summary>Intent recognizer.</summary>
type [<AllowNullLiteral>] IntentRecognizerStatic =
    /// <summary>Initializes an instance of the IntentRecognizer.</summary>
    /// <param name="speechConfig">The set of configuration properties.</param>
    /// <param name="audioConfig">An optional audio input config associated with the recognizer</param>
    [<EmitConstructor>] abstract Create: speechConfig: SpeechConfig * ?audioConfig: AudioConfig -> IntentRecognizer

/// <summary>Output format</summary>
type [<RequireQualifiedAccess>] VoiceProfileType =
    /// <summary>Text independent speaker identification</summary>
    | TextIndependentIdentification = 0
    /// <summary>Text dependent speaker verification</summary>
    | TextDependentVerification = 1
    /// <summary>Text independent speaker verification</summary>
    | TextIndependentVerification = 2

/// <summary>Translation recognizer</summary>
type [<AllowNullLiteral>] TranslationRecognizer =
    inherit Recognizer
    /// <summary>The event recognizing signals that an intermediate recognition result is received.</summary>
    abstract recognizing: (TranslationRecognizer -> TranslationRecognitionEventArgs -> unit) with get, set
    /// <summary>The event recognized signals that a final recognition result is received.</summary>
    abstract recognized: (TranslationRecognizer -> TranslationRecognitionEventArgs -> unit) with get, set
    /// <summary>The event canceled signals that an error occurred during recognition.</summary>
    abstract canceled: (TranslationRecognizer -> TranslationRecognitionCanceledEventArgs -> unit) with get, set
    /// <summary>The event synthesizing signals that a translation synthesis result is received.</summary>
    abstract synthesizing: (TranslationRecognizer -> TranslationSynthesisEventArgs -> unit) with get, set
    /// <summary>Gets the language name that was set when the recognizer was created.</summary>
    /// <returns>Gets the language name that was set when the recognizer was created.</returns>
    abstract speechRecognitionLanguage: string
    /// <summary>
    /// Gets target languages for translation that were set when the recognizer was created.
    /// The language is specified in BCP-47 format. The translation will provide translated text for each of language.
    /// </summary>
    /// <returns>Gets target languages for translation that were set when the recognizer was created.</returns>
    abstract targetLanguages: ResizeArray<string>
    /// <summary>Gets the name of output voice.</summary>
    /// <returns>the name of output voice.</returns>
    abstract voiceName: string
    /// <summary>The collection of properties and their values defined for this TranslationRecognizer.</summary>
    /// <returns>The collection of properties and their values defined for this TranslationRecognizer.</returns>
    abstract properties: PropertyCollection
    /// <summary>
    /// Gets the authorization token used to communicate with the service.
    /// Gets/Sets the authorization token used to communicate with the service.
    /// </summary>
    /// <returns>Authorization token.</returns>
    abstract authorizationToken: string with get, set
    /// <summary>
    /// Starts recognition and translation, and stops after the first utterance is recognized.
    /// The task returns the translation text as result.
    /// Note: recognizeOnceAsync returns when the first utterance has been recognized, so it is suitable only
    /// for single shot recognition like command or query. For long-running recognition,
    /// use startContinuousRecognitionAsync() instead.
    /// </summary>
    /// <param name="cb">Callback that received the result when the translation has completed.</param>
    /// <param name="err">Callback invoked in case of an error.</param>
    abstract recognizeOnceAsync: ?cb: (TranslationRecognitionResult -> unit) * ?err: (string -> unit) -> unit
    /// <summary>
    /// Starts recognition and translation, until stopContinuousRecognitionAsync() is called.
    /// User must subscribe to events to receive translation results.
    /// </summary>
    /// <param name="cb">Callback that received the translation has started.</param>
    /// <param name="err">Callback invoked in case of an error.</param>
    abstract startContinuousRecognitionAsync: ?cb: (unit -> unit) * ?err: (string -> unit) -> unit
    /// <summary>Stops continuous recognition and translation.</summary>
    /// <param name="cb">Callback that received the translation has stopped.</param>
    /// <param name="err">Callback invoked in case of an error.</param>
    abstract stopContinuousRecognitionAsync: ?cb: (unit -> unit) * ?err: (string -> unit) -> unit
    /// <summary>
    /// dynamically remove a language from list of target language
    /// (can be used while recognition is ongoing)
    /// </summary>
    /// <param name="lang">language to be removed</param>
    abstract removeTargetLanguage: lang: string -> unit
    /// <summary>
    /// dynamically add a language to list of target language
    /// (can be used while recognition is ongoing)
    /// </summary>
    /// <param name="lang">language to be added</param>
    abstract addTargetLanguage: lang: string -> unit
    /// <summary>closes all external resources held by an instance of this class.</summary>
    abstract close: ?cb: (unit -> unit) * ?errorCb: (string -> unit) -> unit
    /// <summary>handles ConnectionEstablishedEvent for conversation translation scenarios.</summary>
    abstract onConnection: unit -> unit
    /// <summary>handles disconnection events for conversation translation scenarios.</summary>
    abstract onDisconnection: unit -> Promise<unit>
    /// This method performs cleanup of resources.
    /// The Boolean parameter disposing indicates whether the method is called
    /// from Dispose (if disposing is true) or from the finalizer (if disposing is false).
    /// Derived classes should override this method to dispose resource if needed.
    abstract dispose: disposing: bool -> Promise<unit>
    abstract createRecognizerConfig: speechConfig: SpeechServiceConfig -> RecognizerConfig
    abstract createServiceRecognizer: authentication: IAuthentication * connectionFactory: IConnectionFactory * audioConfig: AudioConfig * recognizerConfig: RecognizerConfig -> ServiceRecognizerBase

/// <summary>Translation recognizer</summary>
type [<AllowNullLiteral>] TranslationRecognizerStatic =
    /// <summary>Initializes an instance of the TranslationRecognizer.</summary>
    /// <param name="speechConfig">Set of properties to configure this recognizer.</param>
    /// <param name="audioConfig">An optional audio config associated with the recognizer</param>
    /// <param name="connectionFactory">An optional connection factory to use to generate the endpoint URIs, headers to set, etc...</param>
    [<EmitConstructor>] abstract Create: speechConfig: SpeechTranslationConfig * ?audioConfig: AudioConfig * ?connectionFactory: IConnectionFactory -> TranslationRecognizer
    /// <summary>TranslationRecognizer constructor.</summary>
    /// <param name="speechTranslationConfig">an set of initial properties for this recognizer</param>
    /// <param name="autoDetectSourceLanguageConfig">An source language detection configuration associated with the recognizer</param>
    /// <param name="audioConfig">An optional audio configuration associated with the recognizer</param>
    abstract FromConfig: speechTranslationConfig: SpeechTranslationConfig * autoDetectSourceLanguageConfig: AutoDetectSourceLanguageConfig * ?audioConfig: AudioConfig -> TranslationRecognizer

/// <summary>Represents collection of parameters and their values.</summary>
type [<AllowNullLiteral>] Translations =
    /// <summary>Get the languages in the object in a String array.</summary>
    /// <returns>languages in translations object.</returns>
    abstract languages: ResizeArray<string>
    /// <summary>
    /// Returns the parameter value in type String. The parameter must have the same type as String.
    /// Currently only String, int and bool are allowed.
    /// If the name is not available, the specified defaultValue is returned.
    /// </summary>
    /// <param name="key">The parameter name.</param>
    /// <param name="def">The default value which is returned if the parameter is not available in the collection.</param>
    /// <returns>value of the parameter.</returns>
    abstract get: key: string * ?def: string -> string
    /// <summary>Sets the String value of the parameter specified by name.</summary>
    /// <param name="key">The parameter name.</param>
    /// <param name="value">The value of the parameter.</param>
    abstract set: key: string * value: string -> unit

/// <summary>Represents collection of parameters and their values.</summary>
type [<AllowNullLiteral>] TranslationsStatic =
    [<EmitConstructor>] abstract Create: unit -> Translations

/// <summary>Defines the possible reasons a recognition result might not be recognized.</summary>
type [<RequireQualifiedAccess>] NoMatchReason =
    /// <summary>Indicates that speech was detected, but not recognized.</summary>
    | NotRecognized = 0
    /// <summary>
    /// Indicates that the start of the audio stream contained only silence,
    /// and the service timed out waiting for speech.
    /// </summary>
    | InitialSilenceTimeout = 1
    /// <summary>
    /// Indicates that the start of the audio stream contained only noise,
    /// and the service timed out waiting for speech.
    /// </summary>
    | InitialBabbleTimeout = 2

/// <summary>Contains detailed information for NoMatch recognition results.</summary>
type [<AllowNullLiteral>] NoMatchDetails =
    /// <summary>The reason the recognition was canceled.</summary>
    /// <returns>Specifies the reason canceled.</returns>
    abstract reason: NoMatchReason

/// <summary>Contains detailed information for NoMatch recognition results.</summary>
type [<AllowNullLiteral>] NoMatchDetailsStatic =
    [<EmitConstructor>] abstract Create: unit -> NoMatchDetails
    /// <summary>Creates an instance of NoMatchDetails object for the NoMatch SpeechRecognitionResults.</summary>
    /// <param name="result">The recognition result that was not recognized.</param>
    /// <returns>The no match details object being created.</returns>
    abstract fromResult: result: U3<SpeechRecognitionResult, IntentRecognitionResult, TranslationRecognitionResult> -> NoMatchDetails

/// <summary>Define payload of speech recognition canceled result events.</summary>
type [<AllowNullLiteral>] TranslationRecognitionCanceledEventArgs =
    /// <summary>Specifies the recognition result.</summary>
    /// <returns>the recognition result.</returns>
    abstract result: TranslationRecognitionResult
    /// <summary>Specifies the session identifier.</summary>
    /// <returns>the session identifier.</returns>
    abstract sessionId: string
    /// <summary>The reason the recognition was canceled.</summary>
    /// <returns>Specifies the reason canceled.</returns>
    abstract reason: CancellationReason
    /// <summary>
    /// The error code in case of an unsuccessful recognition.
    /// Added in version 1.1.0.
    /// </summary>
    /// <returns>An error code that represents the error reason.</returns>
    abstract errorCode: CancellationErrorCode
    /// <summary>In case of an unsuccessful recognition, provides details of the occurred error.</summary>
    /// <returns>A String that represents the error details.</returns>
    abstract errorDetails: string

/// <summary>Define payload of speech recognition canceled result events.</summary>
type [<AllowNullLiteral>] TranslationRecognitionCanceledEventArgsStatic =
    /// <summary>Creates and initializes an instance of this class.</summary>
    /// <param name="sessionid">The session id.</param>
    /// <param name="cancellationReason">The cancellation reason.</param>
    /// <param name="errorDetails">Error details, if provided.</param>
    /// <param name="result">The result.</param>
    [<EmitConstructor>] abstract Create: sessionid: string * cancellationReason: CancellationReason * errorDetails: string * errorCode: CancellationErrorCode * result: TranslationRecognitionResult -> TranslationRecognitionCanceledEventArgs

/// <summary>Define payload of intent recognition canceled result events.</summary>
type [<AllowNullLiteral>] IntentRecognitionCanceledEventArgs =
    inherit IntentRecognitionEventArgs
    inherit CancellationEventArgs
    /// <summary>The reason the recognition was canceled.</summary>
    /// <returns>Specifies the reason canceled.</returns>
    abstract reason: CancellationReason
    /// <summary>
    /// The error code in case of an unsuccessful recognition.
    /// Added in version 1.1.0.
    /// </summary>
    /// <returns>An error code that represents the error reason.</returns>
    abstract errorCode: CancellationErrorCode
    /// <summary>In case of an unsuccessful recognition, provides details of the occurred error.</summary>
    /// <returns>A String that represents the error details.</returns>
    abstract errorDetails: string

/// <summary>Define payload of intent recognition canceled result events.</summary>
type [<AllowNullLiteral>] IntentRecognitionCanceledEventArgsStatic =
    /// <summary>Creates and initializes an instance of this class.</summary>
    /// <param name="result">The result of the intent recognition.</param>
    /// <param name="offset">The offset.</param>
    /// <param name="sessionId">The session id.</param>
    [<EmitConstructor>] abstract Create: reason: CancellationReason * errorDetails: string * errorCode: CancellationErrorCode * ?result: IntentRecognitionResult * ?offset: float * ?sessionId: string -> IntentRecognitionCanceledEventArgs

/// <summary>Contains detailed information about why a result was canceled.</summary>
type [<AllowNullLiteral>] CancellationDetailsBase =
    /// <summary>The reason the recognition was canceled.</summary>
    /// <returns>Specifies the reason canceled.</returns>
    abstract reason: CancellationReason
    /// <summary>In case of an unsuccessful recognition, provides details of the occurred error.</summary>
    /// <returns>A String that represents the error details.</returns>
    abstract errorDetails: string
    /// <summary>
    /// The error code in case of an unsuccessful recognition.
    /// Added in version 1.1.0.
    /// </summary>
    /// <returns>An error code that represents the error reason.</returns>
    abstract ErrorCode: CancellationErrorCode

/// <summary>Contains detailed information about why a result was canceled.</summary>
type [<AllowNullLiteral>] CancellationDetailsBaseStatic =
    /// <summary>Creates and initializes an instance of this class.</summary>
    /// <param name="reason">The cancellation reason.</param>
    /// <param name="errorDetails">The error details, if provided.</param>
    [<EmitConstructor>] abstract Create: reason: CancellationReason * errorDetails: string * errorCode: CancellationErrorCode -> CancellationDetailsBase

/// <summary>Contains detailed information about why a result was canceled.</summary>
type [<AllowNullLiteral>] CancellationDetails =
    inherit CancellationDetailsBase

/// <summary>Contains detailed information about why a result was canceled.</summary>
type [<AllowNullLiteral>] CancellationDetailsStatic =
    /// <summary>Creates and initializes an instance of this class.</summary>
    /// <param name="reason">The cancellation reason.</param>
    /// <param name="errorDetails">The error details, if provided.</param>
    [<EmitConstructor>] abstract Create: reason: CancellationReason * errorDetails: string * errorCode: CancellationErrorCode -> CancellationDetails
    /// <summary>Creates an instance of CancellationDetails object for the canceled RecognitionResult.</summary>
    /// <param name="result">The result that was canceled.</param>
    /// <returns>The cancellation details object being created.</returns>
    abstract fromResult: result: U2<RecognitionResult, SpeechSynthesisResult> -> CancellationDetails

/// Defines error code in case that CancellationReason is Error.
/// Added in version 1.1.0.
type [<RequireQualifiedAccess>] CancellationErrorCode =
    /// Indicates that no error occurred during speech recognition.
    | NoError = 0
    /// Indicates an authentication error.
    | AuthenticationFailure = 1
    /// Indicates that one or more recognition parameters are invalid.
    | BadRequestParameters = 2
    /// Indicates that the number of parallel requests exceeded the number of allowed
    /// concurrent transcriptions for the subscription.
    | TooManyRequests = 3
    /// Indicates a connection error.
    | ConnectionFailure = 4
    /// Indicates a time-out error when waiting for response from service.
    | ServiceTimeout = 5
    /// Indicates that an error is returned by the service.
    | ServiceError = 6
    /// Indicates an unexpected runtime error.
    | RuntimeError = 7
    /// Indicates an quota overrun on existing key.
    | Forbidden = 8

/// Defines payload for connection events like Connected/Disconnected.
/// Added in version 1.2.0
type [<AllowNullLiteral>] ConnectionEventArgs =
    inherit SessionEventArgs

/// Defines payload for connection events like Connected/Disconnected.
/// Added in version 1.2.0
type [<AllowNullLiteral>] ConnectionEventArgsStatic =
    /// <summary>Creates and initializes an instance of this class.</summary>
    /// <param name="sessionId">The session id.</param>
    [<EmitConstructor>] abstract Create: sessionId: string -> ConnectionEventArgs

/// Defines payload for any Service message event
/// Added in version 1.9.0
type [<AllowNullLiteral>] ServiceEventArgs =
    inherit SessionEventArgs
    abstract jsonString: string
    abstract eventName: string

/// Defines payload for any Service message event
/// Added in version 1.9.0
type [<AllowNullLiteral>] ServiceEventArgsStatic =
    /// <summary>Creates and initializes an instance of this class.</summary>
    /// <param name="json">json payload of the USP message.</param>
    [<EmitConstructor>] abstract Create: json: string * name: string * ?sessionId: string -> ServiceEventArgs

/// Connection is a proxy class for managing connection to the speech service of the specified Recognizer.
/// By default, a Recognizer autonomously manages connection to service when needed.
/// The Connection class provides additional methods for users to explicitly open or close a connection and
/// to subscribe to connection status changes.
/// The use of Connection is optional, and mainly for scenarios where fine tuning of application
/// behavior based on connection status is needed. Users can optionally call Open() to manually set up a connection
/// in advance before starting recognition on the Recognizer associated with this Connection.
/// If the Recognizer needs to connect or disconnect to service, it will
/// setup or shutdown the connection independently. In this case the Connection will be notified by change of connection
/// status via Connected/Disconnected events.
/// Added in version 1.2.1.
type [<AllowNullLiteral>] Connection =
    /// Starts to set up connection to the service.
    /// Users can optionally call openConnection() to manually set up a connection in advance before starting recognition on the
    /// Recognizer associated with this Connection. After starting recognition, calling Open() will have no effect
    ///
    /// Note: On return, the connection might not be ready yet. Please subscribe to the Connected event to
    /// be notified when the connection is established.
    abstract openConnection: ?cb: (unit -> unit) * ?err: (string -> unit) -> unit
    /// Closes the connection the service.
    /// Users can optionally call closeConnection() to manually shutdown the connection of the associated Recognizer.
    ///
    /// If closeConnection() is called during recognition, recognition will fail and cancel with an error.
    abstract closeConnection: ?cb: (unit -> unit) * ?err: (string -> unit) -> unit
    /// <summary>
    /// Appends a parameter in a message to service.
    /// Added in version 1.12.1.
    /// </summary>
    /// <param name="path">The path of the network message.</param>
    /// <param name="propertyName">Name of the property</param>
    /// <param name="propertyValue">Value of the property. This is a json string.</param>
    abstract setMessageProperty: path: string * propertyName: string * propertyValue: U2<string, obj> -> unit
    /// <summary>
    /// Sends a message to the speech service.
    /// Added in version 1.13.0.
    /// </summary>
    /// <param name="path">The WebSocket path of the message</param>
    /// <param name="payload">The payload of the message. This is a json string or a ArrayBuffer.</param>
    /// <param name="success">A callback to indicate success.</param>
    /// <param name="error">A callback to indicate an error.</param>
    abstract sendMessageAsync: path: string * payload: U2<string, ArrayBuffer> * ?success: (unit -> unit) * ?error: (string -> unit) -> unit
    /// Any message from service that is not being processed by any other top level recognizers.
    ///
    /// Will be removed in 2.0.
    abstract receivedServiceMessage: (ServiceEventArgs -> unit) with get, set
    /// Any message received from the Speech Service.
    abstract messageReceived: (ConnectionMessageEventArgs -> unit) with get, set
    /// Any message sent to the Speech Service.
    abstract messageSent: (ConnectionMessageEventArgs -> unit) with get, set
    /// The Connected event to indicate that the recognizer is connected to service.
    abstract connected: (ConnectionEventArgs -> unit) with get, set
    /// The Disconnected event to indicate that the recognizer is disconnected from service.
    abstract disconnected: (ConnectionEventArgs -> unit) with get, set
    /// Dispose of associated resources.
    abstract close: unit -> unit

/// Connection is a proxy class for managing connection to the speech service of the specified Recognizer.
/// By default, a Recognizer autonomously manages connection to service when needed.
/// The Connection class provides additional methods for users to explicitly open or close a connection and
/// to subscribe to connection status changes.
/// The use of Connection is optional, and mainly for scenarios where fine tuning of application
/// behavior based on connection status is needed. Users can optionally call Open() to manually set up a connection
/// in advance before starting recognition on the Recognizer associated with this Connection.
/// If the Recognizer needs to connect or disconnect to service, it will
/// setup or shutdown the connection independently. In this case the Connection will be notified by change of connection
/// status via Connected/Disconnected events.
/// Added in version 1.2.1.
type [<AllowNullLiteral>] ConnectionStatic =
    [<EmitConstructor>] abstract Create: unit -> Connection
    /// <summary>Gets the Connection instance from the specified recognizer.</summary>
    /// <param name="recognizer">The recognizer associated with the connection.</param>
    /// <returns>The Connection instance of the recognizer.</returns>
    abstract fromRecognizer: recognizer: U2<Recognizer, ConversationTranscriber> -> Connection
    /// <summary>Gets the Connection instance from the specified synthesizer.</summary>
    /// <param name="synthesizer">The synthesizer associated with the connection.</param>
    /// <returns>The Connection instance of the synthesizer.</returns>
    abstract fromSynthesizer: synthesizer: SpeechSynthesizer -> Connection

/// Allows additions of new phrases to improve speech recognition.
///
/// Phrases added to the recognizer are effective at the start of the next recognition, or the next time the SpeechSDK must reconnect
/// to the speech service.
type [<AllowNullLiteral>] PhraseListGrammar =
    /// <summary>Adds a single phrase to the current recognizer.</summary>
    /// <param name="phrase">Phrase to add.</param>
    abstract addPhrase: phrase: string -> unit
    /// <summary>Adds multiple phrases to the current recognizer.</summary>
    /// <param name="phrases">Array of phrases to add.</param>
    abstract addPhrases: phrases: ResizeArray<string> -> unit
    /// Clears all phrases added to the current recognizer.
    abstract clear: unit -> unit

/// Allows additions of new phrases to improve speech recognition.
///
/// Phrases added to the recognizer are effective at the start of the next recognition, or the next time the SpeechSDK must reconnect
/// to the speech service.
type [<AllowNullLiteral>] PhraseListGrammarStatic =
    [<EmitConstructor>] abstract Create: unit -> PhraseListGrammar
    /// <summary>Creates a PhraseListGrammar from a given speech recognizer. Will accept any recognizer that derives from</summary>
    /// <param name="recognizer">The recognizer to add phrase lists to.</param>
    abstract fromRecognizer: recognizer: U3<Recognizer, ConversationTranscriber, MeetingTranscriber> -> PhraseListGrammar

/// <summary>Class that defines base configurations for dialog service connector</summary>
type [<AllowNullLiteral>] DialogServiceConfig =
    /// <summary>Sets an arbitrary property.</summary>
    /// <param name="name">The name of the property to set.</param>
    /// <param name="value">The new value of the property.</param>
    abstract setProperty: name: U2<string, PropertyId> * value: string -> unit
    /// <summary>Returns the current value of an arbitrary property.</summary>
    /// <param name="name">The name of the property to query.</param>
    /// <param name="def">The value to return in case the property is not known.</param>
    /// <returns>The current value, or provided default, of the given property.</returns>
    abstract getProperty: name: U2<string, PropertyId> * ?def: string -> string
    /// <summary>Sets a property value that will be passed to service using the specified channel.</summary>
    /// <param name="The">name of the property.</param>
    /// <param name="Value">to set.</param>
    /// <param name="The">channel used to pass the specified property to service.</param>
    abstract setServiceProperty: name: string * value: string * channel: ServicePropertyChannel -> unit
    /// <summary>
    /// Sets the proxy configuration.
    /// Only relevant in Node.js environments.
    /// Added in version 1.4.0.
    /// </summary>
    /// <param name="proxyHostName">The host name of the proxy server.</param>
    /// <param name="proxyPort">The port number of the proxy server.</param>
    abstract setProxy: proxyHostName: string * proxyPort: float -> unit
    /// <summary>
    /// Sets the proxy configuration.
    /// Only relevant in Node.js environments.
    /// Added in version 1.4.0.
    /// </summary>
    /// <param name="proxyHostName">The host name of the proxy server, without the protocol scheme (<see href="http://)" /></param>
    /// <param name="porxyPort">The port number of the proxy server.</param>
    /// <param name="proxyUserName">The user name of the proxy server.</param>
    /// <param name="proxyPassword">The password of the proxy server.</param>
    abstract setProxy: proxyHostName: string * proxyPort: float * proxyUserName: string * proxyPassword: string -> unit
    /// <summary>
    /// Returns the configured language.
    /// Gets/Sets the input language.
    /// </summary>
    abstract speechRecognitionLanguage: string with get, set
    /// <summary>Sets the corresponding backend application identifier.</summary>
    /// <param name="value">The application identifier to set.</param>
    abstract applicationId: string with set

/// <summary>Class that defines base configurations for dialog service connector</summary>
type [<AllowNullLiteral>] DialogServiceConfigStatic =
    /// <summary>Creates an instance of DialogService config.</summary>
    [<EmitConstructor>] abstract Create: unit -> DialogServiceConfig
    abstract DialogTypes: {| BotFramework: string; CustomCommands: string |}

/// <summary>Dialog Service configuration.</summary>
type [<AllowNullLiteral>] DialogServiceConfigImpl =
    inherit DialogServiceConfig
    /// <summary>Provides access to custom properties.</summary>
    /// <returns>The properties.</returns>
    abstract properties: PropertyCollection
    /// <summary>
    /// Gets the speech recognition language.
    /// Sets the speech recognition language.
    /// </summary>
    abstract speechRecognitionLanguage: string with get, set
    abstract outputFormat: OutputFormat with get, set
    /// <summary>Sets a named property as value</summary>
    /// <param name="name">The property to set.</param>
    /// <param name="value">The value.</param>
    abstract setProperty: name: U2<string, PropertyId> * value: string -> unit
    /// <summary>Sets a named property as value</summary>
    /// <param name="name">The property to get.</param>
    /// <param name="def">The default value to return in case the property is not known.</param>
    /// <returns>The current value, or provided default, of the given property.</returns>
    abstract getProperty: name: U2<string, PropertyId> * ?def: string -> string
    /// <summary>
    /// Sets the proxy configuration.
    /// Only relevant in Node.js environments.
    /// Added in version 1.4.0.
    /// </summary>
    /// <param name="proxyHostName">The host name of the proxy server, without the protocol scheme (<see href="http://)" /></param>
    /// <param name="proxyPort">The port number of the proxy server.</param>
    /// <param name="proxyUserName">The user name of the proxy server.</param>
    /// <param name="proxyPassword">The password of the proxy server.</param>
    abstract setProxy: proxyHostName: string * proxyPort: float * ?proxyUserName: string * ?proxyPassword: string -> unit
    abstract setServiceProperty: name: string * value: string * channel: ServicePropertyChannel -> unit
    /// <summary>Dispose of associated resources.</summary>
    abstract close: unit -> unit

/// <summary>Dialog Service configuration.</summary>
type [<AllowNullLiteral>] DialogServiceConfigImplStatic =
    /// Creates an instance of dialogService config.
    [<EmitConstructor>] abstract Create: unit -> DialogServiceConfigImpl

/// <summary>Class that defines configurations for the dialog service connector object for using a Bot Framework backend.</summary>
type [<AllowNullLiteral>] BotFrameworkConfig =
    inherit DialogServiceConfigImpl

/// <summary>Class that defines configurations for the dialog service connector object for using a Bot Framework backend.</summary>
type [<AllowNullLiteral>] BotFrameworkConfigStatic =
    /// Creates an instance of BotFrameworkConfig.
    [<EmitConstructor>] abstract Create: unit -> BotFrameworkConfig
    /// <summary>Creates a bot framework configuration instance with the provided subscription information.</summary>
    /// <param name="subscription">Subscription key associated with the bot</param>
    /// <param name="region">The region name (see the &lt;a href="<see href="https://aka.ms/csspeech/region"&gt;region" /> page&lt;/a&gt;).</param>
    /// <param name="botId">
    /// Optional. Identifier for using a specific bot within an Azure resource group. Equivalent to the
    /// resource name.
    /// </param>
    /// <returns>A new bot framework configuration instance.</returns>
    abstract fromSubscription: subscription: string * region: string * ?botId: string -> BotFrameworkConfig
    /// <summary>
    /// Creates a bot framework configuration instance for the specified authorization token and region.
    /// Note: The caller must ensure that an authorization token is valid. Before an authorization token expires, the
    /// caller must refresh it by setting the authorizationToken property on the corresponding
    /// DialogServiceConnector instance created with this config. The contents of configuration objects are copied
    /// when connectors are created, so setting authorizationToken on a DialogServiceConnector will not update the
    /// original configuration's authorization token. Create a new configuration instance or set the
    /// SpeechServiceAuthorization_Token property to update an existing instance if it will be used to create
    /// further DialogServiceConnectors.
    /// </summary>
    /// <param name="authorizationToken">The authorization token associated with the bot</param>
    /// <param name="region">The region name (see the &lt;a href="<see href="https://aka.ms/csspeech/region"&gt;region" /> page&lt;/a&gt;).</param>
    /// <param name="botId">
    /// Optional. Identifier for using a specific bot within an Azure resource group. Equivalent to the
    /// resource name.
    /// </param>
    /// <returns>A new bot framework configuration instance.</returns>
    abstract fromAuthorizationToken: authorizationToken: string * region: string * ?botId: string -> BotFrameworkConfig
    /// <summary>
    /// Creates an instance of a BotFrameworkConfig.
    /// This method is intended only for users who use a non-default service host. The standard resource path will be
    /// assumed. For services with a non-standard resource path or no path at all, use fromEndpoint instead.
    /// Note: Query parameters are not allowed in the host URI and must be set by other APIs.
    /// Note: To use an authorization token with fromHost, use fromHost(URL) and then set the AuthorizationToken
    /// property on the created BotFrameworkConfig instance.
    /// Note: Added in version 1.15.0.
    /// </summary>
    /// <param name="host">
    /// If a URL is provided, the fully-qualified host with protocol (e.g.
    /// <see href="wss://your.host.com:1234)" /> will be used. If a string is provided, it will be embedded in
    /// <see href="wss://{host}.convai.speech.azure.us." />
    /// </param>
    /// <param name="subscriptionKey">
    /// The subscription key. If a subscription key is not specified, an authorization
    /// token must be set.
    /// </param>
    /// <param name="botId">
    /// Optional. Identifier for using a specific bot within an Azure resource group. Equivalent to the
    /// resource name.
    /// </param>
    /// <returns>A new bot framework configuration instance.</returns>
    // abstract fromHost: host: U2<URL, string> * ?subscriptionKey: string * ?botId: string -> BotFrameworkConfig
    abstract fromHost: host: U2<obj, string> * ?subscriptionKey: string * ?botId: string -> BotFrameworkConfig
    /// <summary>
    /// Creates an instance of a BotFrameworkConfig.
    /// This method is intended only for users who use a non-standard service endpoint or parameters.
    /// Note: The query parameters specified in the endpoint URL are not changed, even if they are set by any other APIs.
    /// Note: To use authorization token with fromEndpoint, pass an empty string to the subscriptionKey in the
    /// fromEndpoint method, and then set authorizationToken="token" on the created BotFrameworkConfig instance to
    /// use the authorization token.
    /// Note: Added in version 1.15.0.
    /// </summary>
    /// <param name="endpoint">The service endpoint to connect to.</param>
    /// <param name="subscriptionKey">
    /// The subscription key. If a subscription key is not specified, an authorization
    /// token must be set.
    /// </param>
    /// <returns>- A new bot framework configuration instance using the provided endpoint.</returns>
    // abstract fromEndpoint: endpoint: URL * ?subscriptionKey: string -> BotFrameworkConfig
    abstract fromEndpoint: endpoint: obj * ?subscriptionKey: string -> BotFrameworkConfig

/// <summary>Class that defines configurations for the dialog service connector object for using a CustomCommands backend.</summary>
type [<AllowNullLiteral>] CustomCommandsConfig =
    inherit DialogServiceConfigImpl
    /// <summary>
    /// Sets the corresponding backend application identifier.
    /// Gets the corresponding backend application identifier.
    /// </summary>
    /// <param name="value">The application identifier to get.</param>
    abstract applicationId: string with get, set

/// <summary>Class that defines configurations for the dialog service connector object for using a CustomCommands backend.</summary>
type [<AllowNullLiteral>] CustomCommandsConfigStatic =
    /// Creates an instance of CustomCommandsConfig.
    [<EmitConstructor>] abstract Create: unit -> CustomCommandsConfig
    /// <summary>Creates an instance of the bot framework config with the specified subscription and region.</summary>
    /// <param name="applicationId">Speech Commands application id.</param>
    /// <param name="subscription">Subscription key associated with the bot</param>
    /// <param name="region">The region name (see the &lt;a href="<see href="https://aka.ms/csspeech/region"&gt;region" /> page&lt;/a&gt;).</param>
    /// <returns>A new bot framework config.</returns>
    abstract fromSubscription: applicationId: string * subscription: string * region: string -> CustomCommandsConfig
    /// <summary>
    /// Creates an instance of the bot framework config with the specified Speech Commands application id, authorization token and region.
    /// Note: The caller needs to ensure that the authorization token is valid. Before the authorization token
    /// expires, the caller needs to refresh it by calling this setter with a new valid token.
    /// As configuration values are copied when creating a new recognizer, the new token value will not apply to recognizers that have already been created.
    /// For recognizers that have been created before, you need to set authorization token of the corresponding recognizer
    /// to refresh the token. Otherwise, the recognizers will encounter errors during recognition.
    /// </summary>
    /// <param name="applicationId">Speech Commands application id.</param>
    /// <param name="authorizationToken">The authorization token associated with the application.</param>
    /// <param name="region">The region name (see the &lt;a href="<see href="https://aka.ms/csspeech/region"&gt;region" /> page&lt;/a&gt;).</param>
    /// <returns>A new speech commands config.</returns>
    abstract fromAuthorizationToken: applicationId: string * authorizationToken: string * region: string -> CustomCommandsConfig

/// <summary>Dialog Service Connector</summary>
type [<AllowNullLiteral>] DialogServiceConnector =
    inherit Recognizer
    /// <summary>The event recognizing signals that an intermediate recognition result is received.</summary>
    abstract recognizing: (DialogServiceConnector -> SpeechRecognitionEventArgs -> unit) with get, set
    /// <summary>The event recognized signals that a final recognition result is received.</summary>
    abstract recognized: (DialogServiceConnector -> SpeechRecognitionEventArgs -> unit) with get, set
    /// <summary>The event canceled signals that an error occurred during recognition.</summary>
    abstract canceled: (DialogServiceConnector -> SpeechRecognitionCanceledEventArgs -> unit) with get, set
    /// <summary>The event activityReceived signals that an activity has been received.</summary>
    abstract activityReceived: (DialogServiceConnector -> ActivityReceivedEventArgs -> unit) with get, set
    /// <summary>
    /// The event turnStatusReceived signals that a turn status message has been received. These messages are
    /// associated with both an interaction and a conversation. They are used to notify the client in the event
    /// of an interaction failure with the dialog backend, e.g. in the event of a network issue, timeout, crash,
    /// or other problem.
    /// </summary>
    abstract turnStatusReceived: (DialogServiceConnector -> TurnStatusReceivedEventArgs -> unit) with get, set
    /// <summary>
    /// Starts a connection to the service.
    /// Users can optionally call connect() to manually set up a connection in advance, before starting interactions.
    ///
    /// Note: On return, the connection might not be ready yet. Please subscribe to the Connected event to
    /// be notified when the connection is established.
    /// </summary>
    abstract connect: ?cb: (unit -> unit) * ?err: (string -> unit) -> unit
    /// Closes the connection the service.
    /// Users can optionally call disconnect() to manually shutdown the connection of the associated DialogServiceConnector.
    ///
    /// If disconnect() is called during a recognition, recognition will fail and cancel with an error.
    abstract disconnect: ?cb: (unit -> unit) * ?err: (string -> unit) -> unit
    /// <summary>
    /// Gets the authorization token used to communicate with the service.
    /// Sets the authorization token used to communicate with the service.
    /// </summary>
    /// <returns>Authorization token.</returns>
    abstract authorizationToken: string with get, set
    /// <summary>The collection of properties and their values defined for this DialogServiceConnector.</summary>
    /// <returns>The collection of properties and their values defined for this DialogServiceConnector.</returns>
    abstract properties: PropertyCollection
    /// Gets the template for the activity generated by service from speech.
    ///  Properties from the template will be stamped on the generated activity.
    ///  It can be empty
    /// Sets the template for the activity generated by service from speech.
    ///  Properties from the template will be stamped on the generated activity.
    ///  It can be null or empty.
    ///  Note: it has to be a valid Json object.
    abstract speechActivityTemplate: string with get, set
    /// <summary>Starts recognition and stops after the first utterance is recognized.</summary>
    /// <param name="cb">Callback that received the result when the reco has completed.</param>
    /// <param name="err">Callback invoked in case of an error.</param>
    abstract listenOnceAsync: ?cb: (SpeechRecognitionResult -> unit) * ?err: (string -> unit) -> unit
    abstract sendActivityAsync: activity: string * ?cb: (unit -> unit) * ?errCb: (string -> unit) -> unit
    /// <summary>closes all external resources held by an instance of this class.</summary>
    abstract close: ?cb: (unit -> unit) * ?err: (string -> unit) -> unit
    /// This method performs cleanup of resources.
    /// The Boolean parameter disposing indicates whether the method is called
    /// from Dispose (if disposing is true) or from the finalizer (if disposing is false).
    /// Derived classes should override this method to dispose resource if needed.
    abstract dispose: disposing: bool -> Promise<unit>
    abstract createRecognizerConfig: speechConfig: SpeechServiceConfig -> RecognizerConfig
    abstract createServiceRecognizer: authentication: IAuthentication * connectionFactory: IConnectionFactory * audioConfig: AudioConfig * recognizerConfig: RecognizerConfig -> ServiceRecognizerBase

/// <summary>Dialog Service Connector</summary>
type [<AllowNullLiteral>] DialogServiceConnectorStatic =
    /// <summary>Initializes an instance of the DialogServiceConnector.</summary>
    /// <param name="dialogConfig">Set of properties to configure this recognizer.</param>
    /// <param name="audioConfig">An optional audio config associated with the recognizer</param>
    [<EmitConstructor>] abstract Create: dialogConfig: DialogServiceConfig * ?audioConfig: AudioConfig -> DialogServiceConnector

/// <summary>Defines contents of received message/events.</summary>
type [<AllowNullLiteral>] ActivityReceivedEventArgs =
    /// <summary>Gets the received activity</summary>
    /// <returns>the received activity.</returns>
    abstract activity: obj option
    abstract audioStream: PullAudioOutputStream

/// <summary>Defines contents of received message/events.</summary>
type [<AllowNullLiteral>] ActivityReceivedEventArgsStatic =
    /// <summary>Creates and initializes an instance of this class.</summary>
    /// <param name="activity">The activity..</param>
    [<EmitConstructor>] abstract Create: activity: obj option * ?audioStream: PullAudioOutputStream -> ActivityReceivedEventArgs

/// <summary>Defines contents of received message/events.</summary>
type [<AllowNullLiteral>] TurnStatusReceivedEventArgs =
    /// <summary>Gets the interaction identifier associated with this turn status event.</summary>
    /// <returns>the received interaction id.</returns>
    abstract interactionId: obj option
    /// <summary>Gets the conversation identifier associated with this turn status event.</summary>
    /// <returns>the received conversation id.</returns>
    abstract conversationId: obj option
    /// <summary>Gets the received turn status code.</summary>
    /// <returns>the received turn status.</returns>
    abstract statusCode: float

/// <summary>Defines contents of received message/events.</summary>
type [<AllowNullLiteral>] TurnStatusReceivedEventArgsStatic =
    /// <summary>Creates and initializes an instance of this class.</summary>
    /// <param name="turnStatus">The JSON-encoded turn status message.</param>
    [<EmitConstructor>] abstract Create: turnStatus: string -> TurnStatusReceivedEventArgs

/// Defines channels used to pass property settings to service.
/// Added in version 1.7.0.
type [<RequireQualifiedAccess>] ServicePropertyChannel =
    /// Uses URI query parameter to pass property settings to service.
    | UriQueryParameter = 0

/// Profanity option.
/// Added in version 1.7.0.
type [<RequireQualifiedAccess>] ProfanityOption =
    | Masked = 0
    | Removed = 1
    | Raw = 2

/// <summary>
/// Base audio player class
/// TODO: Plays only PCM for now.
/// </summary>
type [<AllowNullLiteral>] BaseAudioPlayer =
    /// <summary>play Audio sample</summary>
    /// <param name="newAudioData">audio data to be played.</param>
    abstract playAudioSample: newAudioData: ArrayBuffer * ?cb: (unit -> unit) * ?err: (string -> unit) -> unit
    /// stops audio and clears the buffers
    abstract stopAudio: ?cb: (unit -> unit) * ?err: (string -> unit) -> unit

/// <summary>
/// Base audio player class
/// TODO: Plays only PCM for now.
/// </summary>
type [<AllowNullLiteral>] BaseAudioPlayerStatic =
    /// <summary>Creates and initializes an instance of this class.</summary>
    /// <param name="audioFormat">audio stream format recognized by the player.</param>
    [<EmitConstructor>] abstract Create: ?audioFormat: AudioStreamFormat -> BaseAudioPlayer

type [<AllowNullLiteral>] ConnectionMessageEventArgs =
    /// Gets the &lt;see cref="ConnectionMessage"/&gt; associated with this &lt;see cref="ConnectionMessageEventArgs"/&gt;.
    abstract message: ConnectionMessage
    /// Returns a string that represents the connection message event.
    abstract toString: unit -> string

type [<AllowNullLiteral>] ConnectionMessageEventArgsStatic =
    [<EmitConstructor>] abstract Create: message: ConnectionMessage -> ConnectionMessageEventArgs

/// ConnectionMessage represents implementation specific messages sent to and received from
/// the speech service. These messages are provided for debugging purposes and should not
/// be used for production use cases with the Azure Cognitive Services Speech Service.
/// Messages sent to and received from the Speech Service are subject to change without
/// notice. This includes message contents, headers, payloads, ordering, etc.
/// Added in version 1.11.0.
type [<AllowNullLiteral>] ConnectionMessage =
    /// The message path.
    abstract path: string
    /// Checks to see if the ConnectionMessage is a text message.
    /// See also IsBinaryMessage().
    abstract isTextMessage: bool
    /// Checks to see if the ConnectionMessage is a binary message.
    /// See also GetBinaryMessage().
    abstract isBinaryMessage: bool
    /// Gets the text message payload. Typically the text message content-type is
    /// application/json. To determine other content-types use
    /// Properties.GetProperty("Content-Type").
    abstract TextMessage: string
    /// Gets the binary message payload.
    abstract binaryMessage: ArrayBuffer
    /// A collection of properties and their values defined for this &lt;see cref="ConnectionMessage"/&gt;.
    /// Message headers can be accessed via this collection (e.g. "Content-Type").
    abstract properties: PropertyCollection
    /// Returns a string that represents the connection message.
    abstract toString: unit -> string
    abstract messageType: MessageType
    abstract headers: IStringDictionary<string>
    abstract body: obj option
    abstract textBody: string
    abstract binaryBody: ArrayBuffer
    abstract id: string

/// ConnectionMessage represents implementation specific messages sent to and received from
/// the speech service. These messages are provided for debugging purposes and should not
/// be used for production use cases with the Azure Cognitive Services Speech Service.
/// Messages sent to and received from the Speech Service are subject to change without
/// notice. This includes message contents, headers, payloads, ordering, etc.
/// Added in version 1.11.0.
type [<AllowNullLiteral>] ConnectionMessageStatic =
    [<EmitConstructor>] abstract Create: messageType: MessageType * body: obj option * ?headers: IStringDictionary<string> * ?id: string -> ConnectionMessage

type [<AllowNullLiteral>] ConnectionMessageImpl =
    /// The message path.
    abstract path: string
    /// Checks to see if the ConnectionMessage is a text message.
    /// See also IsBinaryMessage().
    abstract isTextMessage: bool
    /// Checks to see if the ConnectionMessage is a binary message.
    /// See also GetBinaryMessage().
    abstract isBinaryMessage: bool
    /// Gets the text message payload. Typically the text message content-type is
    /// application/json. To determine other content-types use
    /// Properties.GetProperty("Content-Type").
    abstract TextMessage: string
    /// Gets the binary message payload.
    abstract binaryMessage: ArrayBuffer
    /// A collection of properties and their values defined for this &lt;see cref="ConnectionMessage"/&gt;.
    /// Message headers can be accessed via this collection (e.g. "Content-Type").
    abstract properties: PropertyCollection
    /// Returns a string that represents the connection message.
    abstract toString: unit -> string

type [<AllowNullLiteral>] ConnectionMessageImplStatic =
    // [<EmitConstructor>] abstract Create: message: IntConnectionMessage -> ConnectionMessageImpl
    [<EmitConstructor>] abstract Create: message: obj -> ConnectionMessageImpl

/// <summary>Defines Voice Profile class for Speaker Recognition</summary>
type [<AllowNullLiteral>] VoiceProfile =
    /// <summary>profileId of this Voice Profile instance</summary>
    /// <returns>profileId of this Voice Profile instance.</returns>
    abstract profileId: string
    /// <summary>profileType of this Voice Profile instance</summary>
    /// <returns>profile type of this Voice Profile instance.</returns>
    abstract profileType: VoiceProfileType

/// <summary>Defines Voice Profile class for Speaker Recognition</summary>
type [<AllowNullLiteral>] VoiceProfileStatic =
    /// <summary>Creates and initializes an instance of this class.</summary>
    /// <param name="profileId">profileId of this Voice Profile.</param>
    /// <param name="profileType">profileType of this Voice Profile.</param>
    [<EmitConstructor>] abstract Create: profileId: string * profileType: VoiceProfileType -> VoiceProfile

type [<AllowNullLiteral>] EnrollmentResultDetails =
    abstract profileId: string with get, set
    abstract enrollmentsCount: float with get, set
    abstract enrollmentsLength: float with get, set
    abstract enrollmentsSpeechLength: float with get, set
    abstract remainingEnrollmentsCount: float with get, set
    abstract remainingEnrollmentsSpeechLength: float with get, set
    abstract audioLength: float with get, set
    abstract audioSpeechLength: float with get, set
    abstract enrollmentStatus: string with get, set

type [<AllowNullLiteral>] EnrollmentResultJSON =
    abstract profileId: string with get, set
    abstract enrollmentsCount: float with get, set
    abstract enrollmentsLength: string with get, set
    abstract enrollmentsSpeechLength: string with get, set
    abstract remainingEnrollmentsCount: float with get, set
    abstract remainingEnrollmentsSpeechLength: string with get, set
    abstract audioLength: string with get, set
    abstract audioSpeechLength: string with get, set
    abstract enrollmentStatus: string with get, set
    abstract remainingEnrollments: float option with get, set
    abstract identificationProfileId: string option with get, set
    abstract verificationProfileId: string option with get, set

/// <summary>Output format</summary>
type [<AllowNullLiteral>] VoiceProfileEnrollmentResult =
    abstract reason: ResultReason
    abstract enrollmentsCount: float
    abstract enrollmentsLength: float
    abstract properties: PropertyCollection
    abstract enrollmentResultDetails: EnrollmentResultDetails
    abstract errorDetails: string

/// <summary>Output format</summary>
type [<AllowNullLiteral>] VoiceProfileEnrollmentResultStatic =
    [<EmitConstructor>] abstract Create: reason: ResultReason * json: string * statusText: string -> VoiceProfileEnrollmentResult
    abstract FromIdentificationProfileList: json: {| value: ResizeArray<EnrollmentResultJSON> |} -> ResizeArray<VoiceProfileEnrollmentResult>
    abstract FromVerificationProfileList: json: {| value: ResizeArray<EnrollmentResultJSON> |} -> ResizeArray<VoiceProfileEnrollmentResult>

type [<AllowNullLiteral>] VoiceProfileEnrollmentCancellationDetails =
    inherit CancellationDetailsBase

type [<AllowNullLiteral>] VoiceProfileEnrollmentCancellationDetailsStatic =
    /// <summary>Creates and initializes an instance of this class.</summary>
    /// <param name="reason">The cancellation reason.</param>
    /// <param name="errorDetails">The error details, if provided.</param>
    [<EmitConstructor>] abstract Create: reason: CancellationReason * errorDetails: string * errorCode: CancellationErrorCode -> VoiceProfileEnrollmentCancellationDetails
    /// <summary>Creates an instance of VoiceProfileEnrollmentCancellationDetails object for the canceled VoiceProfileEnrollmentResult.</summary>
    /// <param name="result">The result that was canceled.</param>
    /// <returns>The cancellation details object being created.</returns>
    abstract fromResult: result: VoiceProfileEnrollmentResult -> VoiceProfileEnrollmentCancellationDetails

/// <summary>Output format</summary>
type [<AllowNullLiteral>] VoiceProfileResult =
    abstract reason: ResultReason
    abstract properties: PropertyCollection
    abstract errorDetails: string

/// <summary>Output format</summary>
type [<AllowNullLiteral>] VoiceProfileResultStatic =
    [<EmitConstructor>] abstract Create: reason: ResultReason * statusText: string -> VoiceProfileResult

type [<AllowNullLiteral>] VoiceProfileCancellationDetails =
    inherit CancellationDetailsBase

type [<AllowNullLiteral>] VoiceProfileCancellationDetailsStatic =
    /// <summary>Creates and initializes an instance of this class.</summary>
    /// <param name="reason">The cancellation reason.</param>
    /// <param name="errorDetails">The error details, if provided.</param>
    [<EmitConstructor>] abstract Create: reason: CancellationReason * errorDetails: string * errorCode: CancellationErrorCode -> VoiceProfileCancellationDetails
    /// <summary>Creates an instance of VoiceProfileCancellationDetails object for the canceled VoiceProfileResult.</summary>
    /// <param name="result">The result that was canceled.</param>
    /// <returns>The cancellation details object being created.</returns>
    abstract fromResult: result: VoiceProfileResult -> VoiceProfileCancellationDetails

/// <summary>Output format</summary>
type [<AllowNullLiteral>] VoiceProfilePhraseResult =
    inherit VoiceProfileResult
    abstract phrases: ResizeArray<string>
    abstract ``type``: string

/// <summary>Output format</summary>
type [<AllowNullLiteral>] VoiceProfilePhraseResultStatic =
    [<EmitConstructor>] abstract Create: reason: ResultReason * statusText: string * ``type``: string * phraseArray: ResizeArray<string> -> VoiceProfilePhraseResult

/// <summary>
/// Defines VoiceProfileClient class for Speaker Recognition
/// Handles operations from user for Voice Profile operations (e.g. createProfile, deleteProfile)
/// </summary>
type [<AllowNullLiteral>] VoiceProfileClient =
    inherit Recognizer
    abstract privProperties: PropertyCollection with get, set
    /// <summary>The collection of properties and their values defined for this VoiceProfileClient.</summary>
    /// <returns>The collection of properties and their values defined for this VoiceProfileClient.</returns>
    abstract properties: PropertyCollection
    /// <summary>
    /// Gets the authorization token used to communicate with the service.
    /// Gets/Sets the authorization token used to communicate with the service.
    /// </summary>
    /// <returns>Authorization token.</returns>
    abstract authorizationToken: string with get, set
    /// <summary>Create a speaker recognition voice profile</summary>
    /// <param name="profileType">Type of Voice Profile to be created</param>
    /// <param name="lang">Language string (locale) for Voice Profile</param>
    /// <returns>- Promise of a VoiceProfile.</returns>
    abstract createProfileAsync: profileType: VoiceProfileType * lang: string -> Promise<VoiceProfile>
    /// <summary>Get current information of a voice profile</summary>
    /// <param name="profile">Voice Profile to retrieve info for</param>
    /// <returns>- Promise of a VoiceProfileEnrollmentResult.</returns>
    abstract retrieveEnrollmentResultAsync: profile: VoiceProfile -> Promise<VoiceProfileEnrollmentResult>
    /// <summary>Get all voice profiles on account with given voice profile type</summary>
    /// <param name="profileType">profile type (identification/verification) for which to list profiles</param>
    /// <returns>- Promise of an array of VoiceProfileEnrollmentResults.</returns>
    abstract getAllProfilesAsync: profileType: VoiceProfileType -> Promise<ResizeArray<VoiceProfileEnrollmentResult>>
    /// <summary>Get valid authorization phrases for voice profile enrollment</summary>
    /// <param name="profileType">Profile Type to get activation phrases for</param>
    /// <param name="lang">Language string (locale) for Voice Profile</param>
    abstract getActivationPhrasesAsync: profileType: VoiceProfileType * lang: string -> Promise<VoiceProfilePhraseResult>
    /// <summary>Create a speaker recognition voice profile</summary>
    /// <param name="profile">Voice Profile to create enrollment for</param>
    /// <param name="audioConfig">source info from which to create enrollment</param>
    /// <returns>- Promise of a VoiceProfileEnrollmentResult.</returns>
    abstract enrollProfileAsync: profile: VoiceProfile * audioConfig: AudioConfig -> Promise<VoiceProfileEnrollmentResult>
    /// <summary>Delete a speaker recognition voice profile</summary>
    /// <param name="profile">Voice Profile to be deleted</param>
    /// <returns>- Promise of a VoiceProfileResult.</returns>
    abstract deleteProfileAsync: profile: VoiceProfile -> Promise<VoiceProfileResult>
    /// <summary>Remove all enrollments for a speaker recognition voice profile</summary>
    /// <param name="profile">Voice Profile to be reset</param>
    /// <returns>- Promise of a VoiceProfileResult.</returns>
    abstract resetProfileAsync: profile: VoiceProfile -> Promise<VoiceProfileResult>
    /// <summary>Clean up object and close underlying connection</summary>
    abstract close: unit -> Promise<unit>
    abstract createServiceRecognizer: authentication: IAuthentication * connectionFactory: IConnectionFactory * audioConfig: AudioConfig * recognizerConfig: RecognizerConfig -> ServiceRecognizerBase
    /// This method performs cleanup of resources.
    /// The Boolean parameter disposing indicates whether the method is called
    /// from Dispose (if disposing is true) or from the finalizer (if disposing is false).
    /// Derived classes should override this method to dispose resource if needed.
    abstract dispose: disposing: bool -> Promise<unit>
    abstract createRecognizerConfig: speechConfig: SpeechServiceConfig -> RecognizerConfig

/// <summary>
/// Defines VoiceProfileClient class for Speaker Recognition
/// Handles operations from user for Voice Profile operations (e.g. createProfile, deleteProfile)
/// </summary>
type [<AllowNullLiteral>] VoiceProfileClientStatic =
    /// <summary>VoiceProfileClient constructor.</summary>
    /// <param name="speechConfig">An set of initial properties for this synthesizer (authentication key, region, &amp;c)</param>
    [<EmitConstructor>] abstract Create: speechConfig: SpeechConfig -> VoiceProfileClient

/// <summary>
/// Defines SpeakerRecognizer class for Speaker Recognition
/// Handles operations from user for Voice Profile operations (e.g. createProfile, deleteProfile)
/// </summary>
type [<AllowNullLiteral>] SpeakerRecognizer =
    inherit Recognizer
    abstract privProperties: PropertyCollection with get, set
    /// <summary>
    /// Gets the authorization token used to communicate with the service.
    /// Gets/Sets the authorization token used to communicate with the service.
    /// </summary>
    /// <returns>Authorization token.</returns>
    abstract authorizationToken: string with get, set
    /// <summary>The collection of properties and their values defined for this SpeakerRecognizer.</summary>
    /// <returns>The collection of properties and their values defined for this SpeakerRecognizer.</returns>
    abstract properties: PropertyCollection
    /// <summary>Get recognition result for model using given audio</summary>
    /// <param name="model">Model containing Voice Profiles to be identified</param>
    /// <param name="cb">Callback invoked once result is returned.</param>
    /// <param name="err">Callback invoked in case of an error.</param>
    abstract recognizeOnceAsync: model: U2<SpeakerIdentificationModel, SpeakerVerificationModel> -> Promise<SpeakerRecognitionResult>
    /// <summary>Included for compatibility</summary>
    abstract close: unit -> Promise<unit>
    abstract recognizeSpeakerOnceAsyncImpl: model: SpeakerRecognitionModel -> Promise<SpeakerRecognitionResult>
    abstract implRecognizerStop: unit -> Promise<unit>
    abstract createRecognizerConfig: speechConfig: SpeechServiceConfig -> RecognizerConfig
    abstract createServiceRecognizer: authentication: IAuthentication * connectionFactory: IConnectionFactory * audioConfig: AudioConfig * recognizerConfig: RecognizerConfig -> ServiceRecognizerBase
    /// This method performs cleanup of resources.
    /// The Boolean parameter disposing indicates whether the method is called
    /// from Dispose (if disposing is true) or from the finalizer (if disposing is false).
    /// Derived classes should override this method to dispose resource if needed.
    abstract dispose: disposing: bool -> Promise<unit>

/// <summary>
/// Defines SpeakerRecognizer class for Speaker Recognition
/// Handles operations from user for Voice Profile operations (e.g. createProfile, deleteProfile)
/// </summary>
type [<AllowNullLiteral>] SpeakerRecognizerStatic =
    /// <summary>Initializes an instance of the SpeakerRecognizer.</summary>
    /// <param name="speechConfig">The set of configuration properties.</param>
    /// <param name="audioConfig">An optional audio input config associated with the recognizer</param>
    [<EmitConstructor>] abstract Create: speechConfig: SpeechConfig * audioConfig: AudioConfig -> SpeakerRecognizer

/// <summary>
/// Defines SpeakerIdentificationModel class for Speaker Recognition
/// Model contains a set of profiles against which to identify speaker(s)
/// </summary>
type [<AllowNullLiteral>] SpeakerIdentificationModel =
    inherit SpeakerRecognitionModel
    abstract voiceProfileIds: string
    abstract profileIds: ResizeArray<string>
    abstract scenario: string

/// <summary>
/// Defines SpeakerIdentificationModel class for Speaker Recognition
/// Model contains a set of profiles against which to identify speaker(s)
/// </summary>
type [<AllowNullLiteral>] SpeakerIdentificationModelStatic =
    [<EmitConstructor>] abstract Create: unit -> SpeakerIdentificationModel
    abstract fromProfiles: profiles: ResizeArray<VoiceProfile> -> SpeakerIdentificationModel

/// <summary>
/// Defines SpeakerVerificationModel class for Speaker Recognition
/// Model contains a profile against which to verify a speaker
/// </summary>
type [<AllowNullLiteral>] SpeakerVerificationModel =
    inherit SpeakerRecognitionModel
    abstract voiceProfile: VoiceProfile
    abstract profileIds: ResizeArray<string>
    abstract scenario: string

/// <summary>
/// Defines SpeakerVerificationModel class for Speaker Recognition
/// Model contains a profile against which to verify a speaker
/// </summary>
type [<AllowNullLiteral>] SpeakerVerificationModelStatic =
    [<EmitConstructor>] abstract Create: unit -> SpeakerVerificationModel
    abstract fromProfile: profile: VoiceProfile -> SpeakerVerificationModel

/// <summary>Language auto detect configuration.</summary>
type [<AllowNullLiteral>] AutoDetectSourceLanguageConfig =
    /// <summary>Gets an auto detected language config properties</summary>
    /// <returns>Properties of the config.</returns>
    abstract properties: PropertyCollection
    /// <summary>Sets LID operation to desired mode</summary>
    /// <param name="mode">LID mode desired.</param>
    abstract mode: LanguageIdMode with set

/// <summary>Language auto detect configuration.</summary>
type [<AllowNullLiteral>] AutoDetectSourceLanguageConfigStatic =
    [<EmitConstructor>] abstract Create: unit -> AutoDetectSourceLanguageConfig
    /// <summary>Creates an instance of the AutoDetectSourceLanguageConfig with open range.</summary>
    /// <returns>Instance of AutoDetectSourceLanguageConfig</returns>
    abstract fromOpenRange: unit -> AutoDetectSourceLanguageConfig
    /// <summary>Creates an instance of the AutoDetectSourceLanguageConfig with given languages.</summary>
    /// <param name="languages">Comma-separated string of languages (eg. "en-US,fr-FR") to populate properties of config.</param>
    /// <returns>Instance of AutoDetectSourceLanguageConfig</returns>
    abstract fromLanguages: languages: ResizeArray<string> -> AutoDetectSourceLanguageConfig
    /// <summary>Creates an instance of the AutoDetectSourceLanguageConfig with given SourceLanguageConfigs.</summary>
    /// <param name="configs">SourceLanguageConfigs to populate properties of config.</param>
    /// <returns>Instance of AutoDetectSourceLanguageConfig</returns>
    abstract fromSourceLanguageConfigs: configs: ResizeArray<SourceLanguageConfig> -> AutoDetectSourceLanguageConfig

/// <summary>Output format</summary>
type [<AllowNullLiteral>] AutoDetectSourceLanguageResult =
    abstract language: string
    abstract languageDetectionConfidence: string

/// <summary>Output format</summary>
type [<AllowNullLiteral>] AutoDetectSourceLanguageResultStatic =
    [<EmitConstructor>] abstract Create: unit -> AutoDetectSourceLanguageResult
    /// <summary>Creates an instance of AutoDetectSourceLanguageResult object from a SpeechRecognitionResult instance.</summary>
    /// <param name="result">The recognition result.</param>
    /// <returns>AutoDetectSourceLanguageResult object being created.</returns>
    abstract fromResult: result: SpeechRecognitionResult -> AutoDetectSourceLanguageResult
    /// <summary>Creates an instance of AutoDetectSourceLanguageResult object from a ConversationTranscriptionResult instance.</summary>
    /// <param name="result">The transcription result.</param>
    /// <returns>AutoDetectSourceLanguageResult object being created.</returns>
    abstract fromConversationTranscriptionResult: result: ConversationTranscriptionResult -> AutoDetectSourceLanguageResult

/// <summary>Source Language configuration.</summary>
type [<AllowNullLiteral>] SourceLanguageConfig =
    abstract language: string
    abstract endpointId: string

/// <summary>Source Language configuration.</summary>
type [<AllowNullLiteral>] SourceLanguageConfigStatic =
    [<EmitConstructor>] abstract Create: unit -> SourceLanguageConfig
    /// <summary>
    /// Creates an instance of the SourceLanguageConfig with the given language and optional endpointId.
    /// Added in version 1.13.0.
    /// </summary>
    /// <param name="language">language (eg. "en-US") value of config.</param>
    /// <param name="endpointId">endpointId of model bound to given language of config.</param>
    /// <returns>Instance of SourceLanguageConfig</returns>
    abstract fromLanguage: language: string * ?endpointId: string -> SourceLanguageConfig

type [<RequireQualifiedAccess>] SpeakerRecognitionResultType =
    | Verify = 0
    | Identify = 1

/// <summary>Output format</summary>
type [<AllowNullLiteral>] SpeakerRecognitionResult =
    abstract properties: PropertyCollection
    abstract reason: ResultReason
    abstract profileId: string
    abstract errorDetails: string
    abstract score: float

/// <summary>Output format</summary>
type [<AllowNullLiteral>] SpeakerRecognitionResultStatic =
    [<EmitConstructor>] abstract Create: response: SpeakerResponse * ?resultReason: ResultReason * ?cancellationErrorCode: CancellationErrorCode * ?errorDetails: string -> SpeakerRecognitionResult

type [<AllowNullLiteral>] SpeakerRecognitionCancellationDetails =
    inherit CancellationDetailsBase

type [<AllowNullLiteral>] SpeakerRecognitionCancellationDetailsStatic =
    /// <summary>Creates and initializes an instance of this class.</summary>
    /// <param name="reason">The cancellation reason.</param>
    /// <param name="errorDetails">The error details, if provided.</param>
    [<EmitConstructor>] abstract Create: reason: CancellationReason * errorDetails: string * errorCode: CancellationErrorCode -> SpeakerRecognitionCancellationDetails
    /// <summary>Creates an instance of SpeakerRecognitionCancellationDetails object for the canceled SpeakerRecognitionResult</summary>
    /// <param name="result">The result that was canceled.</param>
    /// <returns>The cancellation details object being created.</returns>
    abstract fromResult: result: SpeakerRecognitionResult -> SpeakerRecognitionCancellationDetails

/// <summary>Define speech synthesis audio output formats.</summary>
type [<RequireQualifiedAccess>] SpeechSynthesisOutputFormat =
    /// <summary>raw-8khz-8bit-mono-mulaw</summary>
    | Raw8Khz8BitMonoMULaw = 0
    /// <summary>riff-16khz-16kbps-mono-siren</summary>
    /// <remarks>Unsupported by the service. Do not use this value.</remarks>
    | Riff16Khz16KbpsMonoSiren = 1
    /// <summary>audio-16khz-16kbps-mono-siren</summary>
    /// <remarks>Unsupported by the service. Do not use this value.</remarks>
    | Audio16Khz16KbpsMonoSiren = 2
    /// <summary>audio-16khz-32kbitrate-mono-mp3</summary>
    | Audio16Khz32KBitRateMonoMp3 = 3
    /// <summary>audio-16khz-128kbitrate-mono-mp3</summary>
    | Audio16Khz128KBitRateMonoMp3 = 4
    /// <summary>audio-16khz-64kbitrate-mono-mp3</summary>
    | Audio16Khz64KBitRateMonoMp3 = 5
    /// <summary>audio-24khz-48kbitrate-mono-mp3</summary>
    | Audio24Khz48KBitRateMonoMp3 = 6
    /// <summary>audio-24khz-96kbitrate-mono-mp3</summary>
    | Audio24Khz96KBitRateMonoMp3 = 7
    /// <summary>audio-24khz-160kbitrate-mono-mp3</summary>
    | Audio24Khz160KBitRateMonoMp3 = 8
    /// <summary>raw-16khz-16bit-mono-truesilk</summary>
    | Raw16Khz16BitMonoTrueSilk = 9
    /// <summary>riff-16khz-16bit-mono-pcm</summary>
    | Riff16Khz16BitMonoPcm = 10
    /// <summary>riff-8khz-16bit-mono-pcm</summary>
    | Riff8Khz16BitMonoPcm = 11
    /// <summary>riff-24khz-16bit-mono-pcm</summary>
    | Riff24Khz16BitMonoPcm = 12
    /// <summary>riff-8khz-8bit-mono-mulaw</summary>
    | Riff8Khz8BitMonoMULaw = 13
    /// <summary>raw-16khz-16bit-mono-pcm</summary>
    | Raw16Khz16BitMonoPcm = 14
    /// <summary>raw-24khz-16bit-mono-pcm</summary>
    | Raw24Khz16BitMonoPcm = 15
    /// <summary>raw-8khz-16bit-mono-pcm</summary>
    | Raw8Khz16BitMonoPcm = 16
    /// <summary>ogg-16khz-16bit-mono-opus</summary>
    | Ogg16Khz16BitMonoOpus = 17
    /// <summary>ogg-24khz-16bit-mono-opus</summary>
    | Ogg24Khz16BitMonoOpus = 18
    /// <summary>raw-48khz-16bit-mono-pcm</summary>
    | Raw48Khz16BitMonoPcm = 19
    /// <summary>riff-48khz-16bit-mono-pcm</summary>
    | Riff48Khz16BitMonoPcm = 20
    /// <summary>audio-48khz-96kbitrate-mono-mp3</summary>
    | Audio48Khz96KBitRateMonoMp3 = 21
    /// <summary>audio-48khz-192kbitrate-mono-mp3</summary>
    | Audio48Khz192KBitRateMonoMp3 = 22
    /// <summary>
    /// ogg-48khz-16bit-mono-opus
    /// Added in version 1.16.0
    /// </summary>
    | Ogg48Khz16BitMonoOpus = 23
    /// <summary>
    /// webm-16khz-16bit-mono-opus
    /// Added in version 1.16.0
    /// </summary>
    | Webm16Khz16BitMonoOpus = 24
    /// <summary>
    /// webm-24khz-16bit-mono-opus
    /// Added in version 1.16.0
    /// </summary>
    | Webm24Khz16BitMonoOpus = 25
    /// <summary>
    /// raw-24khz-16bit-mono-truesilk
    /// Added in version 1.17.0
    /// </summary>
    | Raw24Khz16BitMonoTrueSilk = 26
    /// <summary>
    /// raw-8khz-8bit-mono-alaw
    /// Added in version 1.17.0
    /// </summary>
    | Raw8Khz8BitMonoALaw = 27
    /// <summary>
    /// riff-8khz-8bit-mono-alaw
    /// Added in version 1.17.0
    /// </summary>
    | Riff8Khz8BitMonoALaw = 28
    /// <summary>
    /// webm-24khz-16bit-24kbps-mono-opus
    /// Audio compressed by OPUS codec in a webm container, with bitrate of 24kbps, optimized for IoT scenario.
    /// Added in version 1.19.0
    /// </summary>
    | Webm24Khz16Bit24KbpsMonoOpus = 29
    /// <summary>
    /// audio-16khz-16bit-32kbps-mono-opus
    /// Audio compressed by OPUS codec without container, with bitrate of 32kbps.
    /// Added in version 1.20.0
    /// </summary>
    | Audio16Khz16Bit32KbpsMonoOpus = 30
    /// <summary>
    /// audio-24khz-16bit-48kbps-mono-opus
    /// Audio compressed by OPUS codec without container, with bitrate of 48kbps.
    /// Added in version 1.20.0
    /// </summary>
    | Audio24Khz16Bit48KbpsMonoOpus = 31
    /// <summary>
    /// audio-24khz-16bit-24kbps-mono-opus
    /// Audio compressed by OPUS codec without container, with bitrate of 24kbps.
    /// Added in version 1.20.0
    /// </summary>
    | Audio24Khz16Bit24KbpsMonoOpus = 32
    /// <summary>
    /// raw-22050hz-16bit-mono-pcm
    /// Raw PCM audio at 22050Hz sampling rate and 16-bit depth.
    /// Added in version 1.22.0
    /// </summary>
    | Raw22050Hz16BitMonoPcm = 33
    /// <summary>
    /// riff-22050hz-16bit-mono-pcm
    /// PCM audio at 22050Hz sampling rate and 16-bit depth, with RIFF header.
    /// Added in version 1.22.0
    /// </summary>
    | Riff22050Hz16BitMonoPcm = 34
    /// <summary>
    /// raw-44100hz-16bit-mono-pcm
    /// Raw PCM audio at 44100Hz sampling rate and 16-bit depth.
    /// Added in version 1.22.0
    /// </summary>
    | Raw44100Hz16BitMonoPcm = 35
    /// <summary>
    /// riff-44100hz-16bit-mono-pcm
    /// PCM audio at 44100Hz sampling rate and 16-bit depth, with RIFF header.
    /// Added in version 1.22.0
    /// </summary>
    | Riff44100Hz16BitMonoPcm = 36

/// <summary>
/// Defines the class SpeechSynthesizer for text to speech.
/// Updated in version 1.16.0
/// </summary>
type [<AllowNullLiteral>] SpeechSynthesizer =
    abstract audioConfig: AudioConfig with get, set
    abstract privAdapter: SynthesisAdapterBase with get, set
    abstract privRestAdapter: SynthesisRestAdapter with get, set
    abstract privProperties: PropertyCollection with get, set
    abstract synthesisRequestQueue: Queue<SynthesisRequest> with get, set
    /// <summary>Defines event handler for synthesis start events.</summary>
    abstract synthesisStarted: (SpeechSynthesizer -> SpeechSynthesisEventArgs -> unit) with get, set
    /// <summary>Defines event handler for synthesizing events.</summary>
    abstract synthesizing: (SpeechSynthesizer -> SpeechSynthesisEventArgs -> unit) with get, set
    /// <summary>Defines event handler for synthesis completed events.</summary>
    abstract synthesisCompleted: (SpeechSynthesizer -> SpeechSynthesisEventArgs -> unit) with get, set
    /// <summary>Defines event handler for synthesis cancelled events.</summary>
    abstract SynthesisCanceled: (SpeechSynthesizer -> SpeechSynthesisEventArgs -> unit) with get, set
    /// <summary>Defines event handler for word boundary events</summary>
    abstract wordBoundary: (SpeechSynthesizer -> SpeechSynthesisWordBoundaryEventArgs -> unit) with get, set
    /// <summary>
    /// Defines event handler for bookmark reached events
    /// Added in version 1.16.0
    /// </summary>
    abstract bookmarkReached: (SpeechSynthesizer -> SpeechSynthesisBookmarkEventArgs -> unit) with get, set
    /// <summary>
    /// Defines event handler for viseme received event
    /// Added in version 1.16.0
    /// </summary>
    abstract visemeReceived: (SpeechSynthesizer -> SpeechSynthesisVisemeEventArgs -> unit) with get, set
    /// <summary>
    /// Gets the authorization token used to communicate with the service.
    /// Gets/Sets the authorization token used to communicate with the service.
    /// </summary>
    /// <returns>Authorization token.</returns>
    abstract authorizationToken: string with get, set
    /// <summary>The collection of properties and their values defined for this SpeechSynthesizer.</summary>
    /// <returns>The collection of properties and their values defined for this SpeechSynthesizer.</returns>
    abstract properties: PropertyCollection
    /// <summary>Indicates if auto detect source language is enabled</summary>
    /// <returns>if auto detect source language is enabled</returns>
    abstract autoDetectSourceLanguage: bool
    abstract buildSsml: text: string -> string
    /// <summary>
    /// Executes speech synthesis on plain text.
    /// The task returns the synthesis result.
    /// </summary>
    /// <param name="text">Text to be synthesized.</param>
    /// <param name="cb">Callback that received the SpeechSynthesisResult.</param>
    /// <param name="err">Callback invoked in case of an error.</param>
    /// <param name="stream">AudioOutputStream to receive the synthesized audio.</param>
    abstract speakTextAsync: text: string * ?cb: (SpeechSynthesisResult -> unit) * ?err: (string -> unit) * ?stream: U3<AudioOutputStream, PushAudioOutputStreamCallback, PathLike> -> unit
    /// <summary>
    /// Executes speech synthesis on SSML.
    /// The task returns the synthesis result.
    /// </summary>
    /// <param name="ssml">SSML to be synthesized.</param>
    /// <param name="cb">Callback that received the SpeechSynthesisResult.</param>
    /// <param name="err">Callback invoked in case of an error.</param>
    /// <param name="stream">AudioOutputStream to receive the synthesized audio.</param>
    abstract speakSsmlAsync: ssml: string * ?cb: (SpeechSynthesisResult -> unit) * ?err: (string -> unit) * ?stream: U3<AudioOutputStream, PushAudioOutputStreamCallback, PathLike> -> unit
    /// <summary>
    /// Get list of synthesis voices available.
    /// The task returns the synthesis voice result.
    /// </summary>
    /// <param name="locale">Locale of voices in BCP-47 format; if left empty, get all available voices.</param>
    /// <returns>- Promise of a SynthesisVoicesResult.</returns>
    abstract getVoicesAsync: ?locale: string -> Promise<SynthesisVoicesResult>
    /// <summary>Dispose of associated resources.</summary>
    abstract close: ?cb: (unit -> unit) * ?err: (string -> unit) -> unit
    abstract internalData: obj
    /// <summary>
    /// This method performs cleanup of resources.
    /// The Boolean parameter disposing indicates whether the method is called
    /// from Dispose (if disposing is true) or from the finalizer (if disposing is false).
    /// Derived classes should override this method to dispose resource if needed.
    /// </summary>
    /// <param name="disposing">Flag to request disposal.</param>
    abstract dispose: disposing: bool -> Promise<unit>
    abstract createSynthesizerConfig: speechConfig: SpeechServiceConfig -> SynthesizerConfig
    abstract createSynthesisAdapter: authentication: IAuthentication * connectionFactory: ISynthesisConnectionFactory * audioConfig: AudioConfig * synthesizerConfig: SynthesizerConfig -> SynthesisAdapterBase
    abstract implCommonSynthesizeSetup: unit -> unit
    abstract speakImpl: text: string * IsSsml: bool * ?cb: (SpeechSynthesisResult -> unit) * ?err: (string -> unit) * ?dataStream: U3<AudioOutputStream, PushAudioOutputStreamCallback, PathLike> -> unit
    abstract getVoices: locale: string -> Promise<SynthesisVoicesResult>
    abstract adapterSpeak: unit -> Promise<unit>

/// <summary>
/// Defines the class SpeechSynthesizer for text to speech.
/// Updated in version 1.16.0
/// </summary>
type [<AllowNullLiteral>] SpeechSynthesizerStatic =
    /// <summary>SpeechSynthesizer constructor.</summary>
    /// <param name="speechConfig">An set of initial properties for this synthesizer.</param>
    /// <param name="audioConfig">An optional audio configuration associated with the synthesizer.</param>
    [<EmitConstructor>] abstract Create: speechConfig: SpeechConfig * ?audioConfig: AudioConfig -> SpeechSynthesizer
    /// <summary>SpeechSynthesizer constructor.</summary>
    /// <param name="speechConfig">an set of initial properties for this synthesizer</param>
    /// <param name="autoDetectSourceLanguageConfig">An source language detection configuration associated with the synthesizer</param>
    /// <param name="audioConfig">An optional audio configuration associated with the synthesizer</param>
    abstract FromConfig: speechConfig: SpeechConfig * autoDetectSourceLanguageConfig: AutoDetectSourceLanguageConfig * ?audioConfig: AudioConfig -> SpeechSynthesizer

type [<AllowNullLiteral>] SynthesisRequest =
    abstract requestId: string with get, set
    abstract text: string with get, set
    abstract isSSML: bool with get, set
    abstract cb: (SpeechSynthesisResult -> unit) with get, set
    abstract err: (string -> unit) with get, set
    abstract dataStream: IAudioDestination with get, set

type [<AllowNullLiteral>] SynthesisRequestStatic =
    [<EmitConstructor>] abstract Create: requestId: string * text: string * isSSML: bool * ?cb: (SpeechSynthesisResult -> unit) * ?err: (string -> unit) * ?dataStream: IAudioDestination -> SynthesisRequest

/// <summary>Base class for synthesis results</summary>
type [<AllowNullLiteral>] SynthesisResult =
    /// <summary>Specifies the result identifier.</summary>
    /// <returns>Specifies the result identifier.</returns>
    abstract resultId: string
    /// <summary>Specifies status of the result.</summary>
    /// <returns>Specifies status of the result.</returns>
    abstract reason: ResultReason
    /// <summary>In case of an unsuccessful synthesis, provides details of the occurred error.</summary>
    /// <returns>a brief description of an error.</returns>
    abstract errorDetails: string
    /// <summary>The set of properties exposed in the result.</summary>
    /// <returns>The set of properties exposed in the result.</returns>
    abstract properties: PropertyCollection

/// <summary>Base class for synthesis results</summary>
type [<AllowNullLiteral>] SynthesisResultStatic =
    /// <summary>Creates and initializes an instance of this class.</summary>
    /// <param name="resultId">The result id.</param>
    /// <param name="reason">The reason.</param>
    /// <param name="errorDetails">Error details, if provided.</param>
    /// <param name="properties">Additional properties, if provided.</param>
    [<EmitConstructor>] abstract Create: ?resultId: string * ?reason: ResultReason * ?errorDetails: string * ?properties: PropertyCollection -> SynthesisResult

/// <summary>Defines result of speech synthesis.</summary>
type [<AllowNullLiteral>] SpeechSynthesisResult =
    inherit SynthesisResult
    /// <summary>The synthesized audio data</summary>
    /// <returns>The synthesized audio data.</returns>
    abstract audioData: ArrayBuffer
    /// <summary>The time duration of synthesized audio, in ticks (100 nanoseconds).</summary>
    /// <returns>The time duration of synthesized audio.</returns>
    abstract audioDuration: float

/// <summary>Defines result of speech synthesis.</summary>
type [<AllowNullLiteral>] SpeechSynthesisResultStatic =
    /// <summary>Creates and initializes an instance of this class.</summary>
    /// <param name="resultId">The result id.</param>
    /// <param name="reason">The reason.</param>
    /// <param name="audioData">The synthesized audio binary.</param>
    /// <param name="errorDetails">Error details, if provided.</param>
    /// <param name="properties">Additional properties, if provided.</param>
    /// <param name="audioDuration">The audio duration.</param>
    [<EmitConstructor>] abstract Create: ?resultId: string * ?reason: ResultReason * ?audioData: ArrayBuffer * ?errorDetails: string * ?properties: PropertyCollection * ?audioDuration: float -> SpeechSynthesisResult

/// <summary>Defines contents of speech synthesis events.</summary>
type [<AllowNullLiteral>] SpeechSynthesisEventArgs =
    /// <summary>Specifies the synthesis result.</summary>
    /// <returns>the synthesis result.</returns>
    abstract result: SpeechSynthesisResult

/// <summary>Defines contents of speech synthesis events.</summary>
type [<AllowNullLiteral>] SpeechSynthesisEventArgsStatic =
    /// <summary>Creates and initializes an instance of this class.</summary>
    /// <param name="result">The speech synthesis result.</param>
    [<EmitConstructor>] abstract Create: result: SpeechSynthesisResult -> SpeechSynthesisEventArgs

/// <summary>Defines contents of speech synthesis word boundary event.</summary>
type [<AllowNullLiteral>] SpeechSynthesisWordBoundaryEventArgs =
    /// <summary>Specifies the audio offset.</summary>
    /// <returns>the audio offset.</returns>
    abstract audioOffset: float
    /// <summary>Specifies the duration, in ticks (100 nanoseconds).</summary>
    /// <returns>Duration in 100 nanosecond increments.</returns>
    abstract duration: float
    /// <summary>Specifies the text of the word boundary event.</summary>
    /// <returns>the text.</returns>
    abstract text: string
    /// <summary>Specifies the word length</summary>
    /// <returns>the word length</returns>
    abstract wordLength: float
    /// <summary>Specifies the text offset.</summary>
    /// <returns>the text offset.</returns>
    abstract textOffset: float
    /// <summary>Specifies the boundary type.</summary>
    /// <returns>the boundary type.</returns>
    abstract boundaryType: SpeechSynthesisBoundaryType

/// <summary>Defines contents of speech synthesis word boundary event.</summary>
type [<AllowNullLiteral>] SpeechSynthesisWordBoundaryEventArgsStatic =
    /// <summary>Creates and initializes an instance of this class.</summary>
    /// <param name="audioOffset">The audio offset.</param>
    /// <param name="duration">The audio duration.</param>
    /// <param name="text">The text.</param>
    /// <param name="wordLength">The length of the word.</param>
    /// <param name="textOffset">The text offset.</param>
    /// <param name="boundaryType">The boundary type</param>
    [<EmitConstructor>] abstract Create: audioOffset: float * duration: float * text: string * wordLength: float * textOffset: float * boundaryType: SpeechSynthesisBoundaryType -> SpeechSynthesisWordBoundaryEventArgs

/// <summary>Defines contents of speech synthesis bookmark event.</summary>
type [<AllowNullLiteral>] SpeechSynthesisBookmarkEventArgs =
    /// <summary>Specifies the audio offset.</summary>
    /// <returns>the audio offset.</returns>
    abstract audioOffset: float
    /// <summary>Specifies the bookmark.</summary>
    /// <returns>the bookmark text.</returns>
    abstract text: string

/// <summary>Defines contents of speech synthesis bookmark event.</summary>
type [<AllowNullLiteral>] SpeechSynthesisBookmarkEventArgsStatic =
    /// <summary>Creates and initializes an instance of this class.</summary>
    /// <param name="audioOffset">The audio offset.</param>
    /// <param name="text">The bookmark text.</param>
    [<EmitConstructor>] abstract Create: audioOffset: float * text: string -> SpeechSynthesisBookmarkEventArgs

/// <summary>Defines contents of speech synthesis viseme event.</summary>
type [<AllowNullLiteral>] SpeechSynthesisVisemeEventArgs =
    /// <summary>Specifies the audio offset.</summary>
    /// <returns>the audio offset.</returns>
    abstract audioOffset: float
    /// <summary>Specifies the viseme ID.</summary>
    /// <returns>the viseme ID.</returns>
    abstract visemeId: float
    /// <summary>Specifies the animation.</summary>
    /// <returns>the animation, could be in svg or other format.</returns>
    abstract animation: string

/// <summary>Defines contents of speech synthesis viseme event.</summary>
type [<AllowNullLiteral>] SpeechSynthesisVisemeEventArgsStatic =
    /// <summary>Creates and initializes an instance of this class.</summary>
    /// <param name="audioOffset">The audio offset.</param>
    /// <param name="visemeId">The viseme ID.</param>
    /// <param name="animation">The animation, could be in svg or other format.</param>
    [<EmitConstructor>] abstract Create: audioOffset: float * visemeId: float * animation: string -> SpeechSynthesisVisemeEventArgs

/// <summary>Defines the boundary type of speech synthesis boundary event.</summary>
type [<StringEnum>] [<RequireQualifiedAccess>] SpeechSynthesisBoundaryType =
    /// <summary>Indicates the boundary text is a word.</summary>
    | [<CompiledName("WordBoundary")>] Word
    /// <summary>Indicates the boundary text is a punctuation.</summary>
    | [<CompiledName("PunctuationBoundary")>] Punctuation
    /// <summary>Indicates the boundary text is a sentence.</summary>
    | [<CompiledName("SentenceBoundary")>] Sentence

/// <summary>Defines result of speech synthesis.</summary>
type [<AllowNullLiteral>] SynthesisVoicesResult =
    inherit SynthesisResult
    /// <summary>The list of voices</summary>
    /// <returns>List of synthesized voices.</returns>
    abstract voices: ResizeArray<VoiceInfo>

/// <summary>Defines result of speech synthesis.</summary>
type [<AllowNullLiteral>] SynthesisVoicesResultStatic =
    /// <summary>Creates and initializes an instance of this class.</summary>
    /// <param name="requestId">result id for request.</param>
    /// <param name="json">json payload from endpoint.</param>
    [<EmitConstructor>] abstract Create: requestId: string * json: obj option * errorDetails: string -> SynthesisVoicesResult

/// Defines the gender of synthesis voices.
/// Added in version 1.20.0.
type [<RequireQualifiedAccess>] SynthesisVoiceGender =
    /// Gender unknown
    | Unknown = 0
    /// Female voice
    | Female = 1
    /// Male voice
    | Male = 2

type [<RequireQualifiedAccess>] SynthesisVoiceType =
    | OnlineNeural = 1
    | OnlineStandard = 2
    | OfflineNeural = 3
    | OfflineStandard = 4

/// <summary>
/// Information about Speech Synthesis voice
/// Added in version 1.20.0.
/// </summary>
type [<AllowNullLiteral>] VoiceInfo =
    abstract name: string
    abstract locale: string
    abstract shortName: string
    abstract displayName: string
    abstract localName: string
    abstract localeName: string
    abstract gender: SynthesisVoiceGender
    abstract voiceType: SynthesisVoiceType
    abstract styleList: ResizeArray<string>
    abstract voicePath: string

/// <summary>
/// Information about Speech Synthesis voice
/// Added in version 1.20.0.
/// </summary>
type [<AllowNullLiteral>] VoiceInfoStatic =
    [<EmitConstructor>] abstract Create: json: VoiceInfoStaticJson -> VoiceInfo

type [<AllowNullLiteral>] VoiceInfoStaticJson =
    abstract Name: string with get, set
    abstract LocalName: string with get, set
    abstract DisplayName: string with get, set
    abstract ShortName: string with get, set
    abstract Gender: string with get, set
    abstract VoiceType: string with get, set
    abstract LocaleName: string with get, set
    abstract Locale: string with get, set
    abstract StyleList: ResizeArray<string> with get, set

/// <summary>Represents audio player interface to control the audio playback, such as pause, resume, etc.</summary>
type [<AllowNullLiteral>] IPlayer =
    /// <summary>Pauses the audio playing</summary>
    abstract pause: unit -> unit
    /// <summary>Resumes the audio playing</summary>
    abstract resume: ?cb: (unit -> unit) * ?err: (string -> unit) -> unit
    /// <summary>Defines event handler audio playback start event.</summary>
    abstract onAudioStart: (IPlayer -> unit) with get, set
    /// <summary>Defines event handler audio playback end event.</summary>
    abstract onAudioEnd: (IPlayer -> unit) with get, set
    /// <summary>Gets the current play audio offset.</summary>
    /// <returns>The current play audio offset, in second</returns>
    abstract currentTime: float with get, set

/// <summary>
/// Represents the speaker playback audio destination, which only works in browser.
/// Note: the SDK will try to use &lt;a href="<see href="https://www.w3.org/TR/media-source/"&gt;Media" /> Source Extensions&lt;/a&gt; to play audio.
/// Mp3 format has better supports on Microsoft Edge, Chrome and Safari (desktop), so, it's better to specify mp3 format for playback.
/// </summary>
type [<AllowNullLiteral>] SpeakerAudioDestination =
    inherit IAudioDestination
    inherit IPlayer
    abstract id: unit -> string
    abstract write: buffer: ArrayBuffer * ?cb: (unit -> unit) * ?err: (string -> unit) -> unit
    abstract close: ?cb: (unit -> unit) * ?err: (string -> unit) -> unit
    abstract format: AudioStreamFormat with set
    abstract volume: float with get, set
    abstract mute: unit -> unit
    abstract unmute: unit -> unit
    abstract isClosed: bool
    /// Gets the current play audio offset.
    abstract currentTime: float
    /// Pauses the audio playing
    abstract pause: unit -> unit
    /// Resumes the audio playing
    abstract resume: ?cb: (unit -> unit) * ?err: (string -> unit) -> unit
    /// Defines event handler audio playback start event.
    abstract onAudioStart: (IPlayer -> unit) with get, set
    /// Defines event handler audio playback end event.
    abstract onAudioEnd: (IPlayer -> unit) with get, set
    abstract internalAudio: HTMLAudioElement

/// <summary>
/// Represents the speaker playback audio destination, which only works in browser.
/// Note: the SDK will try to use &lt;a href="<see href="https://www.w3.org/TR/media-source/"&gt;Media" /> Source Extensions&lt;/a&gt; to play audio.
/// Mp3 format has better supports on Microsoft Edge, Chrome and Safari (desktop), so, it's better to specify mp3 format for playback.
/// </summary>
type [<AllowNullLiteral>] SpeakerAudioDestinationStatic =
    [<EmitConstructor>] abstract Create: ?audioDestinationId: string -> SpeakerAudioDestination

type [<AllowNullLiteral>] CancellationEventArgs =
    abstract sessionId: string
    abstract offset: float
    abstract reason: CancellationReason
    abstract errorCode: CancellationErrorCode
    /// <summary>In case of an unsuccessful recognition, provides details of the occurred error.</summary>
    /// <returns>A String that represents the error details.</returns>
    abstract errorDetails: string

/// <summary>Defines content of a RecognitionErrorEvent.</summary>
type [<AllowNullLiteral>] ConversationTranscriptionCanceledEventArgs =
    inherit CancellationEventArgsBase

/// <summary>Defines content of a RecognitionErrorEvent.</summary>
type [<AllowNullLiteral>] ConversationTranscriptionCanceledEventArgsStatic =
    /// <summary>Creates and initializes an instance of this class.</summary>
    /// <param name="reason">The cancellation reason.</param>
    /// <param name="errorDetails">Error details, if provided.</param>
    /// <param name="offset">The offset.</param>
    /// <param name="sessionId">The session id.</param>
    [<EmitConstructor>] abstract Create: reason: CancellationReason * errorDetails: string * errorCode: CancellationErrorCode * ?offset: float * ?sessionId: string -> ConversationTranscriptionCanceledEventArgs

/// <summary>Defines content of a MeetingTranscriptionCanceledEvent.</summary>
type [<AllowNullLiteral>] MeetingTranscriptionCanceledEventArgs =
    inherit CancellationEventArgsBase

/// <summary>Defines content of a MeetingTranscriptionCanceledEvent.</summary>
type [<AllowNullLiteral>] MeetingTranscriptionCanceledEventArgsStatic =
    /// <summary>Creates and initializes an instance of this class.</summary>
    /// <param name="reason">The cancellation reason.</param>
    /// <param name="errorDetails">Error details, if provided.</param>
    /// <param name="offset">The offset.</param>
    /// <param name="sessionId">The session id.</param>
    [<EmitConstructor>] abstract Create: reason: CancellationReason * errorDetails: string * errorCode: CancellationErrorCode * ?offset: float * ?sessionId: string -> MeetingTranscriptionCanceledEventArgs

/// <summary>
/// Defines the point system for pronunciation score calibration; default value is FivePoint.
/// Added in version 1.15.0
/// </summary>
type [<RequireQualifiedAccess>] PronunciationAssessmentGradingSystem =
    /// <summary>Five point calibration</summary>
    | FivePoint = 1
    /// <summary>Hundred mark</summary>
    | HundredMark = 2

/// <summary>
/// Defines the pronunciation evaluation granularity; default value is Phoneme.
/// Added in version 1.15.0
/// </summary>
type [<RequireQualifiedAccess>] PronunciationAssessmentGranularity =
    /// <summary>Shows the score on the full text, word and phoneme level</summary>
    | Phoneme = 1
    /// <summary>Shows the score on the full text and word level</summary>
    | Word = 2
    /// <summary>Shows the score on the full text level only</summary>
    | FullText = 3

/// <summary>Pronunciation assessment configuration.</summary>
type [<AllowNullLiteral>] PronunciationAssessmentConfig =
    abstract toJSON: unit -> string
    abstract applyTo: recognizer: Recognizer -> unit
    /// <summary>
    /// Gets the reference text.
    /// Gets/Sets the reference text.
    /// </summary>
    /// <returns>Reference text.</returns>
    abstract referenceText: string with get, set
    /// <summary>
    /// Sets the phoneme alphabet.
    /// The valid values are "SAPI" (default) and "IPA".
    /// Added in version 1.20.0
    /// </summary>
    /// <param name="phonemeAlphabet">Phoneme alphabet.</param>
    abstract phonemeAlphabet: string with set
    /// <summary>
    /// Sets the boolean enableMiscue property.
    /// Added in version 1.26.0
    /// Gets the boolean enableMiscue property.
    /// Added in version 1.26.0
    /// </summary>
    /// <returns>enableMiscue - enable miscue.</returns>
    abstract enableMiscue: bool with get, set
    /// <summary>
    /// Sets the nbest phoneme count
    /// Added in version 1.20.0
    /// </summary>
    /// <param name="nbestPhonemeCount">NBest phoneme count.</param>
    abstract nbestPhonemeCount: float with set
    /// <summary>Gets a pronunciation assessment config properties</summary>
    /// <returns>Properties of the config.</returns>
    abstract properties: PropertyCollection

/// <summary>Pronunciation assessment configuration.</summary>
type [<AllowNullLiteral>] PronunciationAssessmentConfigStatic =
    /// <summary>PronunciationAssessmentConfig constructor.</summary>
    /// <param name="referenceText" />
    /// <param name="gradingSystem" />
    /// <param name="granularity" />
    /// <param name="enableMiscue" />
    [<EmitConstructor>] abstract Create: referenceText: string * ?gradingSystem: PronunciationAssessmentGradingSystem * ?granularity: PronunciationAssessmentGranularity * ?enableMiscue: bool -> PronunciationAssessmentConfig
    /// <summary>
    /// Creates an instance of the PronunciationAssessmentConfig from json.
    /// This method is designed to support the pronunciation assessment parameters still in preview.
    /// Under normal circumstances, use the constructor instead.
    /// </summary>
    /// <param name="json">The json string containing the pronunciation assessment parameters.</param>
    /// <returns>Instance of PronunciationAssessmentConfig</returns>
    abstract fromJSON: json: string -> PronunciationAssessmentConfig

type [<AllowNullLiteral>] DetailResult =
    abstract Words: ResizeArray<WordResult> with get, set
    abstract PronunciationAssessment: {| AccuracyScore: float; CompletenessScore: float; FluencyScore: float; PronScore: float |} with get, set

type [<AllowNullLiteral>] WordResult =
    abstract Word: string with get, set
    abstract Phonemes: ResizeArray<{| Phoneme: string option; PronunciationAssessment: {| NBestPhonemes: ResizeArray<{| Phoneme: string |}> |} option |}> with get, set
    abstract PronunciationAssessment: {| AccuracyScore: float; ErrorType: string |} option with get, set
    abstract Syllables: ResizeArray<{| Syllable: string |}> with get, set

/// <summary>Pronunciation assessment results.</summary>
type [<AllowNullLiteral>] PronunciationAssessmentResult =
    /// <summary>Gets the detail result of pronunciation assessment.</summary>
    /// <returns>detail result.</returns>
    abstract detailResult: DetailResult
    /// <summary>
    /// The score indicating the pronunciation accuracy of the given speech, which indicates
    /// how closely the phonemes match a native speaker's pronunciation.
    /// </summary>
    /// <returns>Accuracy score.</returns>
    abstract accuracyScore: float
    /// <summary>
    /// The overall score indicating the pronunciation quality of the given speech.
    /// This is calculated from AccuracyScore, FluencyScore and CompletenessScore with weight.
    /// </summary>
    /// <returns>Pronunciation score.</returns>
    abstract pronunciationScore: float
    /// <summary>The score indicating the completeness of the given speech by calculating the ratio of pronounced words towards entire input.</summary>
    /// <returns>Completeness score.</returns>
    abstract completenessScore: float
    /// <summary>The score indicating the fluency of the given speech.</summary>
    /// <returns>Fluency score.</returns>
    abstract fluencyScore: float

/// <summary>Pronunciation assessment results.</summary>
type [<AllowNullLiteral>] PronunciationAssessmentResultStatic =
    [<EmitConstructor>] abstract Create: unit -> PronunciationAssessmentResult
    /// <summary>Creates an instance of the PronunciationAssessmentResult from recognition result.</summary>
    /// <param name="result">The recognition result.</param>
    /// <returns>Instance of PronunciationAssessmentConfig</returns>
    abstract fromResult: result: RecognitionResult -> PronunciationAssessmentResult

/// <summary>Language Identification mode</summary>
type [<RequireQualifiedAccess>] LanguageIdMode =
    /// <summary>Detect language at audio start</summary>
    | AtStart = 0
    /// <summary>Continuously detect language</summary>
    | Continuous = 1

/// Defines diagnostics API for managing console output
/// Added in version 1.21.0
type [<AllowNullLiteral>] Diagnostics =
    interface end

/// Defines diagnostics API for managing console output
/// Added in version 1.21.0
type [<AllowNullLiteral>] DiagnosticsStatic =
    [<EmitConstructor>] abstract Create: unit -> Diagnostics
    // abstract SetLoggingLevel: logLevel: LogLevel -> unit
    abstract SetLoggingLevel: logLevel: obj -> unit
    abstract StartConsoleOutput: unit -> unit
    abstract StopConsoleOutput: unit -> unit
    abstract SetLogOutputPath: path: string -> unit

/// <summary>Defines content of a CancellationEvent.</summary>
type [<AllowNullLiteral>] CancellationEventArgsBase =
    inherit RecognitionEventArgs
    inherit CancellationEventArgs
    /// <summary>The reason the recognition was canceled.</summary>
    /// <returns>Specifies the reason canceled.</returns>
    abstract reason: CancellationReason
    /// <summary>The error code in case of an unsuccessful operation.</summary>
    /// <returns>An error code that represents the error reason.</returns>
    abstract errorCode: CancellationErrorCode
    /// <summary>In case of an unsuccessful operation, provides details of the occurred error.</summary>
    /// <returns>A String that represents the error details.</returns>
    abstract errorDetails: string

/// <summary>Defines content of a CancellationEvent.</summary>
type [<AllowNullLiteral>] CancellationEventArgsBaseStatic =
    /// <summary>Creates and initializes an instance of this class.</summary>
    /// <param name="reason">The cancellation reason.</param>
    /// <param name="errorDetails">Error details, if provided.</param>
    /// <param name="offset">The offset.</param>
    /// <param name="sessionId">The session id.</param>
    [<EmitConstructor>] abstract Create: reason: CancellationReason * errorDetails: string * errorCode: CancellationErrorCode * ?offset: float * ?sessionId: string -> CancellationEventArgsBase

/// <summary>Defines SpeakerRecognitionModel interface for Speaker Recognition models</summary>
type [<AllowNullLiteral>] SpeakerRecognitionModel =
    abstract scenario: string with get, set
    abstract profileIds: ResizeArray<string> with get, set

type [<AllowNullLiteral>] Conversation =
    inherit IConversation
    /// Gets/sets authorization token used to communicate with the service.
    /// Note: The caller needs to ensure that the authorization token is valid. Before the authorization token
    /// expires, the caller needs to refresh it by calling this setter with a new valid token.
    /// Otherwise, the recognizer will encounter errors during recognition.
    abstract authorizationToken: string with get, set
    abstract config: SpeechTranslationConfig
    /// Gets the unique identifier for the current conversation.
    abstract conversationId: string
    abstract conversationInfo: ConversationInfo
    /// Gets the collection of properties and their values defined for this instance.
    abstract properties: PropertyCollection
    /// Gets the language name that is used for recognition.
    abstract speechRecognitionLanguage: string
    abstract participants: ResizeArray<Participant>
    abstract isConnected: bool
    /// Start a conversation.
    abstract startConversationAsync: ?cb: Callback * ?err: Callback -> unit
    /// Delete a conversation. After this no one will be able to join the conversation.
    abstract deleteConversationAsync: ?cb: Callback * ?err: Callback -> unit
    /// End a conversation.
    abstract endConversationAsync: ?cb: Callback * ?err: Callback -> unit
    /// Lock a conversation. This will prevent new participants from joining.
    abstract lockConversationAsync: ?cb: Callback * ?err: Callback -> unit
    /// Add Participant to Conversation.
    abstract addParticipantAsync: participant: IParticipant * ?cb: Callback * ?err: Callback -> unit
    /// Mute all other participants in the conversation. After this no other participants will
    /// have their speech recognitions broadcast, nor be able to send text messages.
    abstract muteAllParticipantsAsync: ?cb: Callback * ?err: Callback -> unit
    /// <summary>Mute a participant.</summary>
    /// <param name="userId">A user identifier</param>
    abstract muteParticipantAsync: userId: string * ?cb: Callback * ?err: Callback -> unit
    /// <summary>Remove a participant from a conversation using the user id, Participant or User object</summary>
    /// <param name="userId">A user identifier</param>
    abstract removeParticipantAsync: userId: U3<string, IParticipant, IUser> * ?cb: Callback * ?err: Callback -> unit
    /// Unlocks a conversation.
    abstract unlockConversationAsync: ?cb: Callback * ?err: Callback -> unit
    /// Unmute all other participants in the conversation.
    abstract unmuteAllParticipantsAsync: ?cb: Callback * ?err: Callback -> unit
    /// <summary>Unmute a participant.</summary>
    /// <param name="userId">A user identifier</param>
    abstract unmuteParticipantAsync: userId: string * ?cb: Callback * ?err: Callback -> unit

type [<AllowNullLiteral>] ConversationStatic =
    [<EmitConstructor>] abstract Create: unit -> Conversation
    /// <summary>Create a conversation</summary>
    /// <param name="speechConfig" />
    /// <param name="cb" />
    /// <param name="err" />
    abstract createConversationAsync: speechConfig: SpeechTranslationConfig * ?arg2: U2<string, Callback> * ?arg3: Callback * ?arg4: Callback -> Conversation

type [<AllowNullLiteral>] ConversationImpl =
    inherit Conversation
    inherit IDisposable
    abstract room: IInternalConversation
    abstract connection: ConversationRecognizer
    abstract config: SpeechTranslationConfig
    /// Gets the unique identifier for the current conversation.
    abstract conversationId: string
    /// Gets the collection of properties and their values defined for this instance.
    abstract properties: PropertyCollection
    /// Gets the language name that is used for recognition.
    abstract speechRecognitionLanguage: string
    abstract isMutedByHost: bool
    abstract isConnected: bool
    abstract participants: ResizeArray<Participant>
    abstract me: Participant
    abstract host: Participant
    abstract transcriberRecognizer: TranscriberRecognizer
    abstract conversationInfo: ConversationInfo
    /// Gets/sets authorization token used to communicate with the service.
    /// Note: The caller needs to ensure that the authorization token is valid. Before the authorization token
    /// expires, the caller needs to refresh it by calling this setter with a new valid token.
    /// Otherwise, the recognizer will encounter errors during recognition.
    abstract authorizationToken: string with get, set
    abstract conversationTranslator: ConversationTranslator with set
    /// <summary>Create a new conversation as Host</summary>
    /// <param name="cb" />
    /// <param name="err" />
    abstract createConversationAsync: ?cb: Callback * ?err: Callback -> unit
    /// <summary>Starts a new conversation as host.</summary>
    /// <param name="cb" />
    /// <param name="err" />
    abstract startConversationAsync: ?cb: Callback * ?err: Callback -> unit
    /// <summary>Join a conversation as a participant.</summary>
    /// <param name="participant">participant to add</param>
    /// <param name="cb" />
    /// <param name="err" />
    abstract addParticipantAsync: participant: IParticipant * ?cb: Callback * ?err: Callback -> unit
    /// <summary>Join a conversation as a participant.</summary>
    /// <param name="conversation" />
    /// <param name="nickname" />
    /// <param name="lang" />
    /// <param name="cb" />
    /// <param name="err" />
    abstract joinConversationAsync: conversationId: string * nickname: string * lang: string * ?cb: Callback * ?err: Callback -> unit
    /// <summary>Deletes a conversation</summary>
    /// <param name="cb" />
    /// <param name="err" />
    abstract deleteConversationAsync: ?cb: Callback * ?err: Callback -> unit
    abstract deleteConversationImplAsync: unit -> Promise<unit>
    /// <summary>Issues a request to close the client websockets</summary>
    /// <param name="cb" />
    /// <param name="err" />
    abstract endConversationAsync: ?cb: Callback * ?err: Callback -> unit
    abstract endConversationImplAsync: unit -> Promise<unit>
    /// <summary>Issues a request to lock the conversation</summary>
    /// <param name="cb" />
    /// <param name="err" />
    abstract lockConversationAsync: ?cb: Callback * ?err: Callback -> unit
    /// <summary>Issues a request to mute the conversation</summary>
    /// <param name="cb" />
    /// <param name="err" />
    abstract muteAllParticipantsAsync: ?cb: Callback * ?err: Callback -> unit
    /// <summary>Issues a request to mute a participant in the conversation</summary>
    /// <param name="userId" />
    /// <param name="cb" />
    /// <param name="err" />
    abstract muteParticipantAsync: userId: string * ?cb: Callback * ?err: Callback -> unit
    /// <summary>Issues a request to remove a participant from the conversation</summary>
    /// <param name="userId" />
    /// <param name="cb" />
    /// <param name="err" />
    abstract removeParticipantAsync: userId: U3<string, IParticipant, IUser> * ?cb: Callback * ?err: Callback -> unit
    /// <summary>Issues a request to unlock the conversation</summary>
    /// <param name="cb" />
    /// <param name="err" />
    abstract unlockConversationAsync: ?cb: Callback * ?err: Callback -> unit
    /// <summary>Issues a request to unmute all participants in the conversation</summary>
    /// <param name="cb" />
    /// <param name="err" />
    abstract unmuteAllParticipantsAsync: ?cb: Callback * ?err: Callback -> unit
    /// <summary>Issues a request to unmute a participant in the conversation</summary>
    /// <param name="userId" />
    /// <param name="cb" />
    /// <param name="err" />
    abstract unmuteParticipantAsync: userId: string * ?cb: Callback * ?err: Callback -> unit
    /// <summary>Send a text message</summary>
    /// <param name="message" />
    /// <param name="cb" />
    /// <param name="err" />
    abstract sendTextMessageAsync: message: string * ?cb: Callback * ?err: Callback -> unit
    /// <summary>Set translated to languages</summary>
    /// <param name="languages">languages to translate to</param>
    /// <param name="cb" />
    /// <param name="err" />
    abstract setTranslatedLanguagesAsync: languages: ResizeArray<string> * ?cb: Callback * ?err: Callback -> unit
    /// <summary>Change nickname</summary>
    /// <param name="nickname">new nickname for the room</param>
    /// <param name="cb" />
    /// <param name="err" />
    abstract changeNicknameAsync: nickname: string * ?cb: Callback * ?err: Callback -> unit
    abstract isDisposed: unit -> bool
    /// Performs cleanup operations on this instance
    abstract dispose: unit -> unit
    abstract connectTranscriberRecognizer: recognizer: TranscriberRecognizer -> Promise<unit>
    abstract getKeepAlive: unit -> string

type [<AllowNullLiteral>] ConversationImplStatic =
    /// <summary>Create a conversation impl</summary>
    /// <param name="speechConfig" />
    /// <param name="id">optional conversationId</param>
    [<EmitConstructor>] abstract Create: speechConfig: SpeechTranslationConfig * ?id: string -> ConversationImpl

type [<AllowNullLiteral>] Callback =
    [<Emit("$0($1...)")>] abstract Invoke: ?result: obj -> unit

/// Manages conversations.
/// Added in version 1.4.0
type [<AllowNullLiteral>] IConversation =
    abstract config: SpeechTranslationConfig with get, set
    /// Gets/sets authorization token used to communicate with the service.
    /// Note: The caller needs to ensure that the authorization token is valid. Before the authorization token
    /// expires, the caller needs to refresh it by calling this setter with a new valid token.
    /// Otherwise, the recognizer will encounter errors during recognition.
    abstract authorizationToken: string with get, set
    /// Gets the unique identifier for the current conversation.
    abstract conversationId: string
    /// Gets the collection of properties and their values defined for this instance.
    abstract properties: PropertyCollection
    /// Gets the language name that is used for recognition.
    abstract speechRecognitionLanguage: string
    /// Start a conversation.
    ///  The host must connect to the websocket within a minute for the conversation to remain open.
    abstract startConversationAsync: ?cb: (unit -> unit) * ?err: (string -> unit) -> unit
    /// Delete a conversation. After this no one will be able to join the conversation.
    abstract deleteConversationAsync: ?cb: (unit -> unit) * ?err: (string -> unit) -> unit
    /// End a conversation.
    abstract endConversationAsync: ?cb: (unit -> unit) * ?err: (string -> unit) -> unit
    /// Lock a conversation. This will prevent new participants from joining.
    abstract lockConversationAsync: ?cb: (unit -> unit) * ?err: (string -> unit) -> unit
    /// Mute all other participants in the conversation. After this no other participants will
    /// have their speech recognitions broadcast, nor be able to send text messages.
    abstract muteAllParticipantsAsync: ?cb: (unit -> unit) * ?err: (string -> unit) -> unit
    /// <summary>Mute a participant.</summary>
    /// <param name="userId">A user identifier</param>
    abstract muteParticipantAsync: userId: string * ?cb: (unit -> unit) * ?err: (string -> unit) -> unit
    /// <summary>Remove a participant from a conversation using the user id, Participant or User object</summary>
    /// <param name="userId">A user identifier</param>
    abstract removeParticipantAsync: userId: U3<string, IParticipant, IUser> * ?cb: (unit -> unit) * ?err: (string -> unit) -> unit
    /// Unlocks a conversation.
    abstract unlockConversationAsync: unit -> unit
    /// Unmute all other participants in the conversation.
    abstract unmuteAllParticipantsAsync: ?cb: (unit -> unit) * ?err: (string -> unit) -> unit
    /// <summary>Unmute a participant.</summary>
    /// <param name="userId">A user identifier</param>
    abstract unmuteParticipantAsync: userId: string * ?cb: (unit -> unit) * ?err: (string -> unit) -> unit

type [<AllowNullLiteral>] ConversationProperties =
    [<EmitIndexer>] abstract Item: key: string -> obj option with get, set
    abstract id: string option with get, set
    abstract attendees: ResizeArray<TranscriptionParticipant> option with get, set
    abstract record: string option with get, set

type [<AllowNullLiteral>] ConversationInfo =
    abstract id: string with get, set
    abstract participants: ResizeArray<TranscriptionParticipant> with get, set
    abstract conversationProperties: ConversationProperties with get, set

type [<AllowNullLiteral>] ConversationCommon =
    abstract privAudioConfig: AudioConfig with get, set
    abstract privSpeechTranslationConfig: SpeechTranslationConfig with get, set
    abstract handleCallback: cb: Callback * err: Callback -> unit
    abstract handleError: error: obj option * err: Callback -> unit

type [<AllowNullLiteral>] ConversationCommonStatic =
    [<EmitConstructor>] abstract Create: ?audioConfig: AudioConfig -> ConversationCommon

type [<AllowNullLiteral>] ConversationExpirationEventArgs =
    inherit SessionEventArgs
    /// How much longer until the conversation expires (in minutes).
    abstract expirationTime: float

type [<AllowNullLiteral>] ConversationExpirationEventArgsStatic =
    [<EmitConstructor>] abstract Create: expirationTime: float * ?sessionId: string -> ConversationExpirationEventArgs

type [<AllowNullLiteral>] ConversationParticipantsChangedEventArgs =
    inherit SessionEventArgs
    abstract reason: ParticipantChangedReason
    abstract participants: ResizeArray<IParticipant>

type [<AllowNullLiteral>] ConversationParticipantsChangedEventArgsStatic =
    [<EmitConstructor>] abstract Create: reason: ParticipantChangedReason * participants: ResizeArray<IParticipant> * ?sessionId: string -> ConversationParticipantsChangedEventArgs

type [<AllowNullLiteral>] ConversationTranslationCanceledEventArgs =
    inherit CancellationEventArgsBase

type [<AllowNullLiteral>] ConversationTranslationCanceledEventArgsStatic =
    /// <summary>Creates and initializes an instance of this class.</summary>
    /// <param name="reason">The cancellation reason.</param>
    /// <param name="errorDetails">Error details, if provided.</param>
    /// <param name="offset">The offset.</param>
    /// <param name="sessionId">The session id.</param>
    [<EmitConstructor>] abstract Create: reason: CancellationReason * errorDetails: string * errorCode: CancellationErrorCode * ?offset: float * ?sessionId: string -> ConversationTranslationCanceledEventArgs

type [<AllowNullLiteral>] ConversationTranslationEventArgs =
    inherit RecognitionEventArgs
    /// <summary>Specifies the recognition result.</summary>
    /// <returns>the recognition result.</returns>
    abstract result: ConversationTranslationResult

type [<AllowNullLiteral>] ConversationTranslationEventArgsStatic =
    /// <summary>Creates and initializes an instance of this class.</summary>
    /// <param name="result">The translation recognition result.</param>
    /// <param name="offset">The offset.</param>
    /// <param name="sessionId">The session id.</param>
    [<EmitConstructor>] abstract Create: result: ConversationTranslationResult * ?offset: float * ?sessionId: string -> ConversationTranslationEventArgs

type [<AllowNullLiteral>] ConversationTranslationResult =
    inherit TranslationRecognitionResult
    /// The unique identifier for the participant this result is for.
    abstract participantId: string
    /// The original language this result was in.
    abstract originalLang: string

type [<AllowNullLiteral>] ConversationTranslationResultStatic =
    [<EmitConstructor>] abstract Create: participantId: string * translations: Translations * ?originalLanguage: string * ?resultId: string * ?reason: ResultReason * ?text: string * ?duration: float * ?offset: float * ?errorDetails: string * ?json: string * ?properties: PropertyCollection -> ConversationTranslationResult

type [<RequireQualifiedAccess>] SpeechState =
    | Inactive = 0
    | Connecting = 1
    | Connected = 2

/// Join, leave or connect to a conversation.
type [<AllowNullLiteral>] ConversationTranslator =
    inherit ConversationCommon
    inherit IConversationTranslator
    inherit IDisposable
    /// Event that signals an error with the conversation transcription, or the end of the audio stream has been reached.
    abstract canceled: (ConversationHandler -> ConversationTranslationCanceledEventArgs -> unit) with get, set
    /// Event that signals how many more minutes are left before the conversation expires.
    abstract conversationExpiration: (IConversationTranslator -> ConversationExpirationEventArgs -> unit) with get, set
    /// Event that signals participants in the conversation have changed (e.g. a new participant joined).
    abstract participantsChanged: (IConversationTranslator -> ConversationParticipantsChangedEventArgs -> unit) with get, set
    /// Defines event handler for session started events.
    abstract sessionStarted: (ConversationHandler -> SessionEventArgs -> unit) with get, set
    /// Defines event handler for session stopped events.
    abstract sessionStopped: (ConversationHandler -> SessionEventArgs -> unit) with get, set
    /// Event that signals a translated text message from a conversation participant.
    abstract textMessageReceived: (IConversationTranslator -> ConversationTranslationEventArgs -> unit) with get, set
    /// The event recognized signals that a final  conversation translation result is received.
    abstract transcribed: (IConversationTranslator -> ConversationTranslationEventArgs -> unit) with get, set
    /// The event recognizing signals that an intermediate conversation translation result is received.
    abstract transcribing: (IConversationTranslator -> ConversationTranslationEventArgs -> unit) with get, set
    abstract recognized: (IConversationTranslator -> TranslationRecognitionEventArgs -> unit) with get, set
    abstract recognizing: (IConversationTranslator -> TranslationRecognitionEventArgs -> unit) with get, set
    /// Gets the collection of properties and their values defined for this instance.
    abstract properties: PropertyCollection
    /// Gets the language name that is used for recognition.
    abstract speechRecognitionLanguage: string
    abstract participants: ResizeArray<Participant>
    abstract setServiceProperty: name: string * value: string -> unit
    /// <summary>Join a conversation. If this is the host, pass in the previously created Conversation object.</summary>
    /// <param name="conversation" />
    /// <param name="nickname" />
    /// <param name="lang" />
    /// <param name="cb" />
    /// <param name="err" />
    abstract joinConversationAsync: conversation: IConversation * nickname: string * ?cb: Callback * ?err: Callback -> unit
    /// Start a conversation.
    /// Joins an existing conversation.
    abstract joinConversationAsync: conversationId: string * nickname: string * lang: string * ?cb: Callback * ?err: Callback -> unit
    /// <summary>Leave the conversation</summary>
    /// <param name="cb" />
    /// <param name="err" />
    abstract leaveConversationAsync: ?cb: Callback * ?err: Callback -> unit
    /// <summary>Send a text message</summary>
    /// <param name="message" />
    /// <param name="cb" />
    /// <param name="err" />
    abstract sendTextMessageAsync: message: string * ?cb: Callback * ?err: Callback -> unit
    /// <summary>Start speaking</summary>
    /// <param name="cb" />
    /// <param name="err" />
    abstract startTranscribingAsync: ?cb: Callback * ?err: Callback -> unit
    /// <summary>Stop speaking</summary>
    /// <param name="cb" />
    /// <param name="err" />
    abstract stopTranscribingAsync: ?cb: Callback * ?err: Callback -> unit
    abstract isDisposed: unit -> bool
    /// Performs cleanup operations on this instance
    abstract dispose: ?reason: string * ?success: (unit -> unit) * ?err: (string -> unit) -> unit

/// Join, leave or connect to a conversation.
type [<AllowNullLiteral>] ConversationTranslatorStatic =
    [<EmitConstructor>] abstract Create: ?audioConfig: AudioConfig -> ConversationTranslator

/// <summary>Performs speech recognition with speaker separation from microphone, file, or other audio input streams, and gets transcribed text as result.</summary>
type [<AllowNullLiteral>] ConversationTranscriber =
    inherit Recognizer
    /// <summary>The event transcribing signals that an intermediate transcription result is received.</summary>
    abstract transcribing: (Recognizer -> ConversationTranscriptionEventArgs -> unit) with get, set
    /// <summary>The event transcriber signals that a final recognition result is received.</summary>
    abstract transcribed: (Recognizer -> ConversationTranscriptionEventArgs -> unit) with get, set
    /// <summary>The event canceled signals that an error occurred during transcription.</summary>
    abstract canceled: (Recognizer -> ConversationTranscriptionCanceledEventArgs -> unit) with get, set
    /// <summary>Gets the endpoint id of a customized speech model that is used for transcription.</summary>
    /// <returns>the endpoint id of a customized speech model that is used for speech recognition.</returns>
    abstract endpointId: string
    /// <summary>
    /// Gets the authorization token used to communicate with the service.
    /// Gets/Sets the authorization token used to communicate with the service.
    /// </summary>
    /// <returns>Authorization token.</returns>
    abstract authorizationToken: string with get, set
    /// <summary>Gets the spoken language of transcription.</summary>
    /// <returns>The spoken language of transcription.</returns>
    abstract speechRecognitionLanguage: string
    /// <summary>Gets the output format of transcription.</summary>
    /// <returns>The output format of transcription.</returns>
    abstract outputFormat: OutputFormat
    /// <summary>The collection of properties and their values defined for this conversation transcriber.</summary>
    /// <returns>The collection of properties and their values defined for this SpeechRecognizer.</returns>
    abstract properties: PropertyCollection
    /// <summary>
    /// Starts conversation transcription, until stopTranscribingAsync() is called.
    /// User must subscribe to events to receive transcription results.
    /// </summary>
    /// <param name="cb">Callback invoked once the transcription has started.</param>
    /// <param name="err">Callback invoked in case of an error.</param>
    abstract startTranscribingAsync: ?cb: (unit -> unit) * ?err: (string -> unit) -> unit
    /// <summary>Stops conversation transcription.</summary>
    /// <param name="cb">Callback invoked once the transcription has stopped.</param>
    /// <param name="err">Callback invoked in case of an error.</param>
    abstract stopTranscribingAsync: ?cb: (unit -> unit) * ?err: (string -> unit) -> unit
    /// <summary>closes all external resources held by an instance of this class.</summary>
    abstract close: ?cb: (unit -> unit) * ?errorCb: (string -> unit) -> unit
    /// <summary>Disposes any resources held by the object.</summary>
    /// <param name="disposing">true if disposing the object.</param>
    abstract dispose: disposing: bool -> Promise<unit>
    abstract createRecognizerConfig: speechConfig: SpeechServiceConfig -> RecognizerConfig
    abstract createServiceRecognizer: authentication: IAuthentication * connectionFactory: IConnectionFactory * audioConfig: AudioConfig * recognizerConfig: RecognizerConfig -> ServiceRecognizerBase

/// <summary>Performs speech recognition with speaker separation from microphone, file, or other audio input streams, and gets transcribed text as result.</summary>
type [<AllowNullLiteral>] ConversationTranscriberStatic =
    /// <summary>ConversationTranscriber constructor.</summary>
    /// <param name="speechConfig">an set of initial properties for this recognizer</param>
    /// <param name="audioConfig">An optional audio configuration associated with the recognizer</param>
    [<EmitConstructor>] abstract Create: speechConfig: SpeechConfig * ?audioConfig: AudioConfig -> ConversationTranscriber
    /// <summary>ConversationTranscriber constructor.</summary>
    /// <param name="speechConfig">an set of initial properties for this recognizer</param>
    /// <param name="autoDetectSourceLanguageConfig">An source language detection configuration associated with the recognizer</param>
    /// <param name="audioConfig">An optional audio configuration associated with the recognizer</param>
    abstract FromConfig: speechConfig: SpeechConfig * autoDetectSourceLanguageConfig: AutoDetectSourceLanguageConfig * ?audioConfig: AudioConfig -> ConversationTranscriber

/// Represents a user in a conversation.
/// Added in version 1.4.0
type [<AllowNullLiteral>] IUser =
    /// Gets the user's ID
    abstract userId: string

type [<AllowNullLiteral>] User =
    inherit IUser
    /// Gets the user's ID
    abstract userId: string

type [<AllowNullLiteral>] UserStatic =
    [<EmitConstructor>] abstract Create: userId: string -> User

type [<AllowNullLiteral>] VoiceSignature =
    abstract Version: float with get, set
    abstract Tag: string with get, set
    abstract Data: string with get, set

type [<AllowNullLiteral>] TranscriptionParticipant =
    /// The unique identifier for the participant.
    abstract id: string
    /// The participant's preferred spoken language.
    abstract preferredLanguage: string
    /// The participant's voice signature
    abstract voice: string

/// Represents a participant in a conversation.
/// Added in version 1.4.0
type [<AllowNullLiteral>] IParticipant =
    inherit TranscriptionParticipant
    /// Gets the colour of the user's avatar as an HTML hex string (e.g. FF0000 for red).
    abstract avatar: string
    /// The participant's display name. Please note that there may be more than one participant
    /// with the same name. You can use &lt;see cref="Id"/&gt; property to tell them apart.
    abstract displayName: string
    /// Gets whether or not this participant is the host.
    abstract isHost: bool
    /// Gets whether or not this participant is muted.
    abstract isMuted: bool
    /// Gets whether or not the participant is using Text To Speech (TTS).
    abstract isUsingTts: bool
    /// Contains properties of the participant.
    abstract properties: PropertyCollection

type [<AllowNullLiteral>] Participant =
    inherit IParticipant
    /// Gets the colour of the user's avatar as an HTML hex string (e.g. FF0000 for red).
    abstract avatar: string
    /// The participant's display name. Please note that there may be more than one participant
    /// with the same name. You can use &lt;see cref="Id"/&gt; property to tell them apart.
    abstract displayName: string
    /// The unique identifier for the participant.
    abstract id: string
    /// The participant's preferred spoken language.
    abstract preferredLanguage: string
    /// Gets whether or not this participant is the host.
    abstract isHost: bool
    /// Gets whether or not this participant is muted.
    abstract isMuted: bool
    /// Gets whether or not the participant is using Text To Speech (TTS).
    abstract isUsingTts: bool
    /// The participant's voice signature
    abstract voice: string
    /// Contains properties of the participant.
    abstract properties: PropertyCollection

type [<AllowNullLiteral>] ParticipantStatic =
    [<EmitConstructor>] abstract Create: id: string * avatar: string * displayName: string * isHost: bool * isMuted: bool * isUsingTts: bool * preferredLanguage: string * ?voice: string -> Participant
    abstract From: id: string * language: string * voice: string -> IParticipant

type [<RequireQualifiedAccess>] ParticipantChangedReason =
    /// Participant has joined the conversation.
    | JoinedConversation = 0
    /// Participant has left the conversation. This could be voluntary, or involuntary
    ///  (e.g. they are experiencing networking issues).
    | LeftConversation = 1
    /// The participants' state has changed (e.g. they became muted, changed their nickname).
    | Updated = 2

type [<AllowNullLiteral>] ConversationHandler =
    /// Defines event handler for session started events.
    abstract sessionStarted: (ConversationHandler -> SessionEventArgs -> unit) with get, set
    /// Defines event handler for session stopped events.
    abstract sessionStopped: (ConversationHandler -> SessionEventArgs -> unit) with get, set
    /// Event that signals an error with the conversation transcription, or the end of the audio stream has been reached.
    abstract canceled: (ConversationHandler -> ConversationTranslationCanceledEventArgs -> unit) with get, set
    /// Leave the current conversation. After this is called, you will no longer receive any events.
    abstract leaveConversationAsync: ?cb: Callback * ?err: Callback -> unit
    /// Starts sending audio to the conversation service for speech recognition and translation. You
    /// should subscribe to the Transcribing, and Transcribed events to receive conversation
    /// translation results for yourself, and other participants in the conversation.
    abstract startTranscribingAsync: ?cb: Callback * ?err: Callback -> unit
    /// Stops sending audio to the conversation service. You will still receive Transcribing, and
    /// and Transcribed events for other participants in the conversation.
    abstract stopTranscribingAsync: ?cb: Callback * ?err: Callback -> unit

/// A conversation translator that enables a connected experience where participants can use their
/// own devices to see everyone else's recognitions and IMs in their own languages. Participants
/// can also speak and send IMs to others.
type [<AllowNullLiteral>] IConversationTranslator =
    inherit ConversationHandler
    /// Gets the collection of properties and their values defined for this instance.
    abstract properties: PropertyCollection
    /// Gets the language name that is used for recognition.
    abstract speechRecognitionLanguage: string
    /// Event that signals how many more minutes are left before the conversation expires.
    abstract conversationExpiration: (IConversationTranslator -> ConversationExpirationEventArgs -> unit) with get, set
    /// Event that signals participants in the conversation have changed (e.g. a new participant joined).
    abstract participantsChanged: (IConversationTranslator -> ConversationParticipantsChangedEventArgs -> unit) with get, set
    /// Event that signals a translated text message from a conversation participant.
    abstract textMessageReceived: (IConversationTranslator -> ConversationTranslationEventArgs -> unit) with get, set
    /// The event recognized signals that a final  conversation translation result is received.
    abstract transcribed: (IConversationTranslator -> ConversationTranslationEventArgs -> unit) with get, set
    /// The event recognizing signals that an intermediate conversation translation result is received.
    abstract transcribing: (IConversationTranslator -> ConversationTranslationEventArgs -> unit) with get, set
    /// Start a conversation.
    abstract joinConversationAsync: conversation: IConversation * nickname: string * ?cb: Callback * ?err: Callback -> unit
    /// <summary>Joins an existing conversation.</summary>
    /// <param name="conversationId">The unique identifier for the conversation to join.</param>
    /// <param name="nickname">The display name to use for the current participant.</param>
    /// <param name="lang">The speech language to use for the current participant.</param>
    abstract joinConversationAsync: conversationId: string * nickname: string * lang: string * ?cb: Callback * ?err: Callback -> unit
    /// <summary>
    /// Sends an instant message to all participants in the conversation. This instant message
    /// will be translated into each participant's text language.
    /// </summary>
    /// <param name="message" />
    abstract sendTextMessageAsync: message: string * ?cb: Callback * ?err: Callback -> unit

/// A conversation transcriber that enables a connected experience where conversations can
/// logged with each participant recognized.
type [<AllowNullLiteral>] ConversationTranscriptionHandler =
    inherit ConversationHandler
    /// The event recognized signals that a final conversation translation result is received.
    abstract transcribed: (ConversationTranscriptionHandler -> ConversationTranscriptionEventArgs -> unit) with get, set
    /// The event recognizing signals that an intermediate conversation translation result is received.
    abstract transcribing: (ConversationTranscriptionHandler -> ConversationTranscriptionEventArgs -> unit) with get, set
    /// <summary>Joins an existing conversation.</summary>
    /// <param name="conversation">The conversation to join.</param>
    abstract joinConversationAsync: conversation: IConversation * ?cb: Callback * ?err: Callback -> unit

type [<AllowNullLiteral>] Meeting =
    inherit IMeeting
    /// Gets/sets authorization token used to communicate with the service.
    /// Note: The caller needs to ensure that the authorization token is valid. Before the authorization token
    /// expires, the caller needs to refresh it by calling this setter with a new valid token.
    /// Otherwise, the recognizer will encounter errors during recognition.
    abstract authorizationToken: string with get, set
    abstract config: SpeechTranslationConfig
    /// Gets the unique identifier for the current meeting.
    abstract meetingId: string
    abstract meetingInfo: MeetingInfo
    /// Gets the collection of properties and their values defined for this instance.
    abstract properties: PropertyCollection
    /// Gets the language name that is used for recognition.
    abstract speechRecognitionLanguage: string
    abstract participants: ResizeArray<Participant>
    abstract isConnected: bool
    /// Start a meeting.
    abstract startMeetingAsync: ?cb: Callback * ?err: Callback -> unit
    /// Delete a meeting. After this no one will be able to join the meeting.
    abstract deleteMeetingAsync: ?cb: Callback * ?err: Callback -> unit
    /// End a meeting.
    abstract endMeetingAsync: ?cb: Callback * ?err: Callback -> unit
    /// Lock a meeting. This will prevent new participants from joining.
    abstract lockMeetingAsync: ?cb: Callback * ?err: Callback -> unit
    /// Add Participant to Meeting.
    abstract addParticipantAsync: participant: IParticipant * ?cb: Callback * ?err: Callback -> unit
    /// Mute all other participants in the Meeting. After this no other participants will
    /// have their speech recognitions broadcast, nor be able to send text messages.
    abstract muteAllParticipantsAsync: ?cb: Callback * ?err: Callback -> unit
    /// <summary>Mute a participant.</summary>
    /// <param name="userId">A user identifier</param>
    abstract muteParticipantAsync: userId: string * ?cb: Callback * ?err: Callback -> unit
    /// <summary>Remove a participant from a meeting using the user id, Participant or User object</summary>
    /// <param name="userId">A user identifier</param>
    abstract removeParticipantAsync: userId: U3<string, IParticipant, IUser> * ?cb: Callback * ?err: Callback -> unit
    /// Unlocks a meeting.
    abstract unlockMeetingAsync: ?cb: Callback * ?err: Callback -> unit
    /// Unmute all other participants in the meeting.
    abstract unmuteAllParticipantsAsync: ?cb: Callback * ?err: Callback -> unit
    /// <summary>Unmute a participant.</summary>
    /// <param name="userId">A user identifier</param>
    abstract unmuteParticipantAsync: userId: string * ?cb: Callback * ?err: Callback -> unit

type [<AllowNullLiteral>] MeetingStatic =
    [<EmitConstructor>] abstract Create: unit -> Meeting
    /// <summary>Create a meeting</summary>
    /// <param name="speechConfig" />
    /// <param name="cb" />
    /// <param name="err" />
    abstract createMeetingAsync: speechConfig: SpeechTranslationConfig * ?arg2: U2<string, Callback> * ?arg3: Callback * ?arg4: Callback -> Meeting

type [<AllowNullLiteral>] MeetingImpl =
    inherit Meeting
    inherit IDisposable
    abstract room: IInternalConversation
    abstract connection: ConversationRecognizer
    abstract config: SpeechTranslationConfig
    /// Gets the unique identifier for the current meeting.
    abstract meetingId: string
    /// Gets the collection of properties and their values defined for this instance.
    abstract properties: PropertyCollection
    /// Gets the language name that is used for recognition.
    abstract speechRecognitionLanguage: string
    abstract isMutedByHost: bool
    abstract isConnected: bool
    abstract participants: ResizeArray<Participant>
    abstract me: Participant
    abstract host: Participant
    abstract transcriberRecognizer: TranscriberRecognizer
    abstract meetingInfo: MeetingInfo
    /// Gets/sets authorization token used to communicate with the service.
    /// Note: The caller needs to ensure that the authorization token is valid. Before the authorization token
    /// expires, the caller needs to refresh it by calling this setter with a new valid token.
    /// Otherwise, the recognizer will encounter errors during recognition.
    abstract authorizationToken: string with get, set
    /// <summary>Create a new meeting as Host</summary>
    /// <param name="cb" />
    /// <param name="err" />
    abstract createMeetingAsync: ?cb: Callback * ?err: Callback -> unit
    /// <summary>Starts a new meeting as host.</summary>
    /// <param name="cb" />
    /// <param name="err" />
    abstract startMeetingAsync: ?cb: Callback * ?err: Callback -> unit
    /// <summary>Join a meeting as a participant.</summary>
    /// <param name="participant">participant to add</param>
    /// <param name="cb" />
    /// <param name="err" />
    abstract addParticipantAsync: participant: IParticipant * ?cb: Callback * ?err: Callback -> unit
    /// <summary>Join a meeting as a participant.</summary>
    /// <param name="meeting" />
    /// <param name="nickname" />
    /// <param name="lang" />
    /// <param name="cb" />
    /// <param name="err" />
    abstract joinMeetingAsync: meetingId: string * nickname: string * lang: string * ?cb: Callback * ?err: Callback -> unit
    /// <summary>Deletes a meeting</summary>
    /// <param name="cb" />
    /// <param name="err" />
    abstract deleteMeetingAsync: ?cb: Callback * ?err: Callback -> unit
    abstract deleteMeetingImplAsync: unit -> Promise<unit>
    /// <summary>Issues a request to close the client websockets</summary>
    /// <param name="cb" />
    /// <param name="err" />
    abstract endMeetingAsync: ?cb: Callback * ?err: Callback -> unit
    abstract endMeetingImplAsync: unit -> Promise<unit>
    /// <summary>Issues a request to lock the conversation</summary>
    /// <param name="cb" />
    /// <param name="err" />
    abstract lockMeetingAsync: ?cb: Callback * ?err: Callback -> unit
    /// <summary>Issues a request to mute the meeting</summary>
    /// <param name="cb" />
    /// <param name="err" />
    abstract muteAllParticipantsAsync: ?cb: Callback * ?err: Callback -> unit
    /// <summary>Issues a request to mute a participant in the meeting</summary>
    /// <param name="userId" />
    /// <param name="cb" />
    /// <param name="err" />
    abstract muteParticipantAsync: userId: string * ?cb: Callback * ?err: Callback -> unit
    /// <summary>Issues a request to remove a participant from the conversation</summary>
    /// <param name="userId" />
    /// <param name="cb" />
    /// <param name="err" />
    abstract removeParticipantAsync: userId: U3<string, IParticipant, IUser> * ?cb: Callback * ?err: Callback -> unit
    /// <summary>Issues a request to unlock the meeting</summary>
    /// <param name="cb" />
    /// <param name="err" />
    abstract unlockMeetingAsync: ?cb: Callback * ?err: Callback -> unit
    /// <summary>Issues a request to unmute all participants in the meeting</summary>
    /// <param name="cb" />
    /// <param name="err" />
    abstract unmuteAllParticipantsAsync: ?cb: Callback * ?err: Callback -> unit
    /// <summary>Issues a request to unmute a participant in the meeting</summary>
    /// <param name="userId" />
    /// <param name="cb" />
    /// <param name="err" />
    abstract unmuteParticipantAsync: userId: string * ?cb: Callback * ?err: Callback -> unit
    /// <summary>Send a text message</summary>
    /// <param name="message" />
    /// <param name="cb" />
    /// <param name="err" />
    abstract sendTextMessageAsync: message: string * ?cb: Callback * ?err: Callback -> unit
    /// <summary>Set translated to languages</summary>
    /// <param name="languages">languages to translate to</param>
    /// <param name="cb" />
    /// <param name="err" />
    abstract setTranslatedLanguagesAsync: languages: ResizeArray<string> * ?cb: Callback * ?err: Callback -> unit
    /// <summary>Change nickname</summary>
    /// <param name="nickname">new nickname for the room</param>
    /// <param name="cb" />
    /// <param name="err" />
    abstract changeNicknameAsync: nickname: string * ?cb: Callback * ?err: Callback -> unit
    abstract isDisposed: unit -> bool
    /// Performs cleanup operations on this instance
    abstract dispose: unit -> unit
    abstract connectTranscriberRecognizer: recognizer: TranscriberRecognizer -> Promise<unit>
    abstract getKeepAlive: unit -> string

type [<AllowNullLiteral>] MeetingImplStatic =
    /// <summary>Create a Meeting impl</summary>
    /// <param name="speechConfig" />
    /// <param name="id">optional conversationId</param>
    [<EmitConstructor>] abstract Create: speechConfig: SpeechTranslationConfig * id: string -> MeetingImpl


/// Manages meetings.
type [<AllowNullLiteral>] IMeeting =
    abstract config: SpeechTranslationConfig with get, set
    /// Gets/sets authorization token used to communicate with the service.
    /// Note: The caller needs to ensure that the authorization token is valid. Before the authorization token
    /// expires, the caller needs to refresh it by calling this setter with a new valid token.
    /// Otherwise, the recognizer will encounter errors during recognition.
    abstract authorizationToken: string with get, set
    /// Gets the unique identifier for the current meeting.
    abstract meetingId: string
    /// Gets the collection of properties and their values defined for this instance.
    abstract properties: PropertyCollection
    /// Gets the language name that is used for recognition.
    abstract speechRecognitionLanguage: string
    /// Start a meeting.
    ///  The host must connect to the websocket within a minute for the meeting to remain open.
    abstract startMeetingAsync: ?cb: (unit -> unit) * ?err: (string -> unit) -> unit
    /// Delete a meeting. After this no one will be able to join the meeting.
    abstract deleteMeetingAsync: ?cb: (unit -> unit) * ?err: (string -> unit) -> unit
    /// End a meeting.
    abstract endMeetingAsync: ?cb: (unit -> unit) * ?err: (string -> unit) -> unit
    /// Lock a meeting. This will prevent new participants from joining.
    abstract lockMeetingAsync: ?cb: (unit -> unit) * ?err: (string -> unit) -> unit
    /// Mute all other participants in the meeting. After this no other participants will
    /// have their speech recognitions broadcast, nor be able to send text messages.
    abstract muteAllParticipantsAsync: ?cb: (unit -> unit) * ?err: (string -> unit) -> unit
    /// <summary>Mute a participant.</summary>
    /// <param name="userId">A user identifier</param>
    abstract muteParticipantAsync: userId: string * ?cb: (unit -> unit) * ?err: (string -> unit) -> unit
    /// <summary>Remove a participant from a meeting using the user id, Participant or User object</summary>
    /// <param name="userId">A user identifier</param>
    abstract removeParticipantAsync: userId: U3<string, IParticipant, IUser> * ?cb: (unit -> unit) * ?err: (string -> unit) -> unit
    /// Unlocks a meeting.
    abstract unlockMeetingAsync: unit -> unit
    /// Unmute all other participants in the meeting.
    abstract unmuteAllParticipantsAsync: ?cb: (unit -> unit) * ?err: (string -> unit) -> unit
    /// <summary>Unmute a participant.</summary>
    /// <param name="userId">A user identifier</param>
    abstract unmuteParticipantAsync: userId: string * ?cb: (unit -> unit) * ?err: (string -> unit) -> unit

type [<AllowNullLiteral>] MeetingProperties =
    [<EmitIndexer>] abstract Item: key: string -> obj option with get, set
    abstract id: string option with get, set
    abstract attendees: ResizeArray<TranscriptionParticipant> option with get, set
    abstract record: string option with get, set

type [<AllowNullLiteral>] MeetingInfo =
    abstract id: string with get, set
    abstract participants: ResizeArray<TranscriptionParticipant> with get, set
    abstract meetingProperties: MeetingProperties with get, set

type [<AllowNullLiteral>] MeetingTranscriber =
    inherit MeetingTranscriptionHandler
    /// <summary>The event canceled signals that an error occurred during the meeting.</summary>
    abstract MeetingCanceled: (MeetingHandler -> CancellationEventArgs -> unit) with get, set
    /// <summary>The event canceled signals that an error occurred during transcription.</summary>
    abstract canceled: (MeetingHandler -> CancellationEventArgs -> unit) with get, set
    /// <summary>The event recognized signals that a final meeting transcription result is received.</summary>
    abstract transcribed: (MeetingTranscriptionHandler -> MeetingTranscriptionEventArgs -> unit) with get, set
    /// <summary>The event recognizing signals that an intermediate meeting transcription result is received.</summary>
    abstract transcribing: (MeetingTranscriptionHandler -> MeetingTranscriptionEventArgs -> unit) with get, set
    /// <summary>Defines event handler for session started events.</summary>
    abstract sessionStarted: (MeetingHandler -> SessionEventArgs -> unit) with get, set
    /// <summary>Defines event handler for session stopped events.</summary>
    abstract sessionStopped: (MeetingHandler -> SessionEventArgs -> unit) with get, set
    /// <summary>Defines event handler for meeting started events.</summary>
    abstract MeetingStarted: (MeetingHandler -> SessionEventArgs -> unit) with get, set
    /// <summary>Defines event handler for meeting stopped events.</summary>
    abstract meetingStopped: (MeetingHandler -> SessionEventArgs -> unit) with get, set
    abstract privAudioConfig: AudioConfig with get, set
    /// <summary>Gets the spoken language of recognition.</summary>
    /// <returns>The spoken language of recognition.</returns>
    abstract speechRecognitionLanguage: string
    /// <summary>The collection of properties and their values defined for this MeetingTranscriber.</summary>
    /// <returns>The collection of properties and their values defined for this MeetingTranscriber.</returns>
    abstract properties: PropertyCollection
    abstract internalData: obj
    [<Obsolete("")>]
    abstract connection: Connection
    /// <summary>
    /// Gets the authorization token used to communicate with the service.
    /// Gets/Sets the authorization token used to communicate with the service.
    /// </summary>
    /// <returns>Authorization token.</returns>
    abstract authorizationToken: string with get, set
    /// <summary>Joins an existing meeting.</summary>
    /// <param name="meeting">meeting to be recognized</param>
    abstract joinMeetingAsync: meeting: IMeeting * ?cb: Callback * ?err: Callback -> unit
    /// <summary>
    /// Starts meeting transcription, until stopTranscribingAsync() is called.
    /// User must subscribe to events to receive transcription results.
    /// </summary>
    /// <param name="cb">Callback invoked once the transcription has started.</param>
    /// <param name="err">Callback invoked in case of an error.</param>
    abstract startTranscribingAsync: ?cb: Callback * ?err: Callback -> unit
    /// <summary>
    /// Starts meeting transcription, until stopTranscribingAsync() is called.
    /// User must subscribe to events to receive transcription results.
    /// </summary>
    /// <param name="cb">Callback invoked once the transcription has started.</param>
    /// <param name="err">Callback invoked in case of an error.</param>
    abstract stopTranscribingAsync: ?cb: Callback * ?err: Callback -> unit
    /// Leave the current meeting. After this is called, you will no longer receive any events.
    abstract leaveMeetingAsync: ?cb: Callback * ?err: Callback -> unit
    /// <summary>closes all external resources held by an instance of this class.</summary>
    abstract close: ?cb: (unit -> unit) * ?errorCb: (string -> unit) -> unit
    /// <summary>Disposes any resources held by the object.</summary>
    /// <param name="disposing">true if disposing the object.</param>
    abstract dispose: disposing: bool -> Promise<unit>

type [<AllowNullLiteral>] MeetingTranscriberStatic =
    /// <summary>MeetingTranscriber constructor.</summary>
    /// <param name="audioConfig">An optional audio configuration associated with the recognizer</param>
    [<EmitConstructor>] abstract Create: ?audioConfig: AudioConfig -> MeetingTranscriber

type [<AllowNullLiteral>] MeetingHandler =
    /// Defines event handler for session started events.
    abstract sessionStarted: (MeetingHandler -> SessionEventArgs -> unit) with get, set
    /// Defines event handler for session stopped events.
    abstract sessionStopped: (MeetingHandler -> SessionEventArgs -> unit) with get, set
    /// Event that signals an error with the meeting transcription, or the end of the audio stream has been reached.
    abstract canceled: (MeetingHandler -> MeetingTranscriptionCanceledEventArgs -> unit) with get, set
    /// Leave the current meeting. After this is called, you will no longer receive any events.
    abstract leaveMeetingAsync: ?cb: Callback * ?err: Callback -> unit
    /// Starts sending audio to the transcription service for speech recognition and translation. You
    /// should subscribe to the Transcribing, and Transcribed events to receive results.
    abstract startTranscribingAsync: ?cb: Callback * ?err: Callback -> unit
    /// Stops sending audio to the transcription service. You will still receive Transcribing, and
    /// and Transcribed events for other participants in the meeting.
    abstract stopTranscribingAsync: ?cb: Callback * ?err: Callback -> unit

/// A meeting transcriber that enables a connected experience where meetings can be
/// transcribed with each participant recognized.
type [<AllowNullLiteral>] MeetingTranscriptionHandler =
    inherit MeetingHandler
    /// The event recognized signals that a final meeting transcription result is received.
    abstract transcribed: (MeetingTranscriptionHandler -> MeetingTranscriptionEventArgs -> unit) with get, set
    /// The event recognizing signals that an intermediate meeting transcription result is received.
    abstract transcribing: (MeetingTranscriptionHandler -> MeetingTranscriptionEventArgs -> unit) with get, set
    /// <summary>Joins an existing meeting.</summary>
    /// <param name="meeting">The meeting to join.</param>
    abstract joinMeetingAsync: meeting: IMeeting * ?cb: Callback * ?err: Callback -> unit

/// <summary>Defines result of conversation transcription.</summary>
type [<AllowNullLiteral>] ConversationTranscriptionResult =
    inherit RecognitionResult
    /// <summary>speaker id</summary>
    /// <returns>id of speaker in given result</returns>
    abstract speakerId: string

/// <summary>Defines result of conversation transcription.</summary>
type [<AllowNullLiteral>] ConversationTranscriptionResultStatic =
    /// <summary>Creates and initializes an instance of this class.</summary>
    /// <param name="resultId">The result id.</param>
    /// <param name="reason">The reason.</param>
    /// <param name="text">The recognized text.</param>
    /// <param name="duration">The duration.</param>
    /// <param name="offset">The offset into the stream.</param>
    /// <param name="language">Primary Language detected, if provided.</param>
    /// <param name="languageDetectionConfidence">Primary Language confidence ("Unknown," "Low," "Medium," "High"...), if provided.</param>
    /// <param name="speakerId">speaker id for conversation transcription.</param>
    /// <param name="errorDetails">Error details, if provided.</param>
    /// <param name="json">Additional Json, if provided.</param>
    /// <param name="properties">Additional properties, if provided.</param>
    [<EmitConstructor>] abstract Create: ?resultId: string * ?reason: ResultReason * ?text: string * ?duration: float * ?offset: float * ?language: string * ?languageDetectionConfidence: string * ?speakerId: string * ?errorDetails: string * ?json: string * ?properties: PropertyCollection -> ConversationTranscriptionResult

type [<AllowNullLiteral>] CognitiveSubscriptionKeyAuthentication =
    inherit IAuthentication
    /// <summary>Fetches the subscription key.</summary>
    /// <param name="authFetchEventId">The id to fetch.</param>
    abstract fetch: authFetchEventId: string -> Promise<AuthInfo>
    /// <summary>Fetches the subscription key.</summary>
    /// <param name="authFetchEventId">The id to fetch.</param>
    abstract fetchOnExpiry: authFetchEventId: string -> Promise<AuthInfo>

type [<AllowNullLiteral>] CognitiveSubscriptionKeyAuthenticationStatic =
    /// <summary>Creates and initializes an instance of the CognitiveSubscriptionKeyAuthentication class.</summary>
    /// <param name="subscriptionKey">The subscription key</param>
    [<EmitConstructor>] abstract Create: subscriptionKey: string -> CognitiveSubscriptionKeyAuthentication

type [<AllowNullLiteral>] CognitiveTokenAuthentication =
    inherit IAuthentication
    abstract fetch: authFetchEventId: string -> Promise<AuthInfo>
    abstract fetchOnExpiry: authFetchEventId: string -> Promise<AuthInfo>

type [<AllowNullLiteral>] CognitiveTokenAuthenticationStatic =
    [<EmitConstructor>] abstract Create: fetchCallback: (string -> Promise<string>) * fetchOnExpiryCallback: (string -> Promise<string>) -> CognitiveTokenAuthentication

type [<AllowNullLiteral>] IAuthentication =
    abstract fetch: authFetchEventId: string -> Promise<AuthInfo>
    abstract fetchOnExpiry: authFetchEventId: string -> Promise<AuthInfo>

type [<AllowNullLiteral>] AuthInfo =
    abstract headerName: string
    abstract token: string

type [<AllowNullLiteral>] AuthInfoStatic =
    [<EmitConstructor>] abstract Create: headerName: string * token: string -> AuthInfo

type [<AllowNullLiteral>] IConnectionFactory =
    abstract create: config: RecognizerConfig * authInfo: AuthInfo * ?connectionId: string -> IConnection

type [<AllowNullLiteral>] ISynthesisConnectionFactory =
    abstract create: config: SynthesizerConfig * authInfo: AuthInfo * ?connectionId: string -> IConnection

type [<AllowNullLiteral>] IntentConnectionFactory =
    inherit ConnectionFactoryBase
    abstract create: config: RecognizerConfig * authInfo: AuthInfo * ?connectionId: string -> IConnection

type [<AllowNullLiteral>] IntentConnectionFactoryStatic =
    [<EmitConstructor>] abstract Create: unit -> IntentConnectionFactory

type [<AllowNullLiteral>] SpeakerRecognitionConnectionFactoryBase =
    inherit ConnectionFactoryBase
    abstract create: config: RecognizerConfig * authInfo: AuthInfo * endpointPath: string * ?connectionId: string -> IConnection

type [<AllowNullLiteral>] SpeakerRecognitionConnectionFactoryBaseStatic =
    [<EmitConstructor>] abstract Create: unit -> SpeakerRecognitionConnectionFactoryBase

type [<AllowNullLiteral>] SpeakerRecognitionConnectionFactory =
    inherit SpeakerRecognitionConnectionFactoryBase
    abstract create: config: RecognizerConfig * authInfo: AuthInfo * ?connectionId: string -> IConnection

type [<AllowNullLiteral>] SpeakerRecognitionConnectionFactoryStatic =
    [<EmitConstructor>] abstract Create: unit -> SpeakerRecognitionConnectionFactory

type [<AllowNullLiteral>] VoiceProfileConnectionFactory =
    inherit SpeakerRecognitionConnectionFactoryBase
    abstract create: config: RecognizerConfig * authInfo: AuthInfo * ?connectionId: string -> IConnection

type [<AllowNullLiteral>] VoiceProfileConnectionFactoryStatic =
    [<EmitConstructor>] abstract Create: unit -> VoiceProfileConnectionFactory

type [<AllowNullLiteral>] SpeechRecognitionEvent =
    inherit PlatformEvent
    abstract requestId: string
    abstract sessionId: string

type [<AllowNullLiteral>] SpeechRecognitionEventStatic =
    [<EmitConstructor>] abstract Create: eventName: string * requestId: string * sessionId: string * ?eventType: EventType -> SpeechRecognitionEvent

type [<AllowNullLiteral>] RecognitionTriggeredEvent =
    inherit SpeechRecognitionEvent
    abstract audioSourceId: string
    abstract audioNodeId: string

type [<AllowNullLiteral>] RecognitionTriggeredEventStatic =
    [<EmitConstructor>] abstract Create: requestId: string * sessionId: string * audioSourceId: string * audioNodeId: string -> RecognitionTriggeredEvent

type [<AllowNullLiteral>] ListeningStartedEvent =
    inherit SpeechRecognitionEvent
    abstract audioSourceId: string
    abstract audioNodeId: string

type [<AllowNullLiteral>] ListeningStartedEventStatic =
    [<EmitConstructor>] abstract Create: requestId: string * sessionId: string * audioSourceId: string * audioNodeId: string -> ListeningStartedEvent

type [<AllowNullLiteral>] ConnectingToServiceEvent =
    inherit SpeechRecognitionEvent
    abstract authFetchEventid: string

type [<AllowNullLiteral>] ConnectingToServiceEventStatic =
    [<EmitConstructor>] abstract Create: requestId: string * authFetchEventid: string * sessionId: string -> ConnectingToServiceEvent

type [<AllowNullLiteral>] RecognitionStartedEvent =
    inherit SpeechRecognitionEvent
    abstract audioSourceId: string
    abstract audioNodeId: string
    abstract authFetchEventId: string

type [<AllowNullLiteral>] RecognitionStartedEventStatic =
    [<EmitConstructor>] abstract Create: requestId: string * audioSourceId: string * audioNodeId: string * authFetchEventId: string * sessionId: string -> RecognitionStartedEvent

type [<RequireQualifiedAccess>] RecognitionCompletionStatus =
    | Success = 0
    | AudioSourceError = 1
    | AudioSourceTimeout = 2
    | AuthTokenFetchError = 3
    | AuthTokenFetchTimeout = 4
    | UnAuthorized = 5
    | ConnectTimeout = 6
    | ConnectError = 7
    | ClientRecognitionActivityTimeout = 8
    | UnknownError = 9

type [<AllowNullLiteral>] RecognitionEndedEvent =
    inherit SpeechRecognitionEvent
    abstract audioSourceId: string
    abstract audioNodeId: string
    abstract authFetchEventId: string
    abstract serviceTag: string
    abstract status: RecognitionCompletionStatus
    abstract error: string

type [<AllowNullLiteral>] RecognitionEndedEventStatic =
    [<EmitConstructor>] abstract Create: requestId: string * audioSourceId: string * audioNodeId: string * authFetchEventId: string * sessionId: string * serviceTag: string * status: RecognitionCompletionStatus * error: string -> RecognitionEndedEvent

type [<AllowNullLiteral>] CustomModel =
    abstract language: string with get, set
    abstract endpoint: string with get, set

type [<AllowNullLiteral>] PhraseDetection =
    abstract customModels: ResizeArray<CustomModel> option with get, set
    abstract onInterim: {| action: string |} option with get, set
    abstract onSuccess: {| action: string |} option with get, set
    abstract mode: string option with get, set
    abstract INTERACTIVE: Segmentation option with get, set
    abstract CONVERSATION: Segmentation option with get, set
    abstract DICTATION: Segmentation option with get, set
    abstract speakerDiarization: SpeakerDiarization option with get, set

type [<AllowNullLiteral>] SpeakerDiarization =
    abstract mode: string option with get, set
    abstract audioSessionId: string option with get, set
    abstract audioOffsetMs: float option with get, set
    abstract identityProvider: string option with get, set

type [<AllowNullLiteral>] Segmentation =
    abstract segmentation: {| mode: string; segmentationSilenceTimeoutMs: float |} with get, set

type [<AllowNullLiteral>] ServiceRecognizerBase =
    inherit IDisposable
    abstract privSpeechContext: SpeechContext with get, set
    abstract privRequestSession: RequestSession with get, set
    abstract privConnectionId: string with get, set
    abstract privDiarizationSessionId: string with get, set
    abstract privRecognizerConfig: RecognizerConfig with get, set
    abstract privRecognizer: Recognizer with get, set
    abstract privSuccessCallback: (SpeechRecognitionResult -> unit) with get, set
    abstract privErrorCallback: (string -> unit) with get, set
    abstract privEnableSpeakerId: bool with get, set
    abstract setSpeechSegmentationTimeoutJson: unit -> unit
    abstract setLanguageIdJson: unit -> unit
    abstract setOutputDetailLevelJson: unit -> unit
    abstract isSpeakerDiarizationEnabled: bool
    abstract audioSource: IAudioSource
    abstract speechContext: SpeechContext
    abstract dynamicGrammar: DynamicGrammarBuilder
    abstract agentConfig: AgentConfig
    abstract conversationTranslatorToken: string with set
    abstract voiceProfileType: string with set
    abstract authentication: IAuthentication with set
    abstract isDisposed: unit -> bool
    /// Performs cleanup operations on this instance
    abstract dispose: ?reason: string -> Promise<unit>
    abstract connectionEvents: EventSource<ConnectionEvent>
    abstract serviceEvents: EventSource<ServiceEvent>
    abstract recognitionMode: RecognitionMode
    abstract recognizeOverride: (RecognitionMode -> (SpeechRecognitionResult -> unit) -> (string -> unit) -> Promise<unit>) with get, set
    abstract recognizeSpeaker: (SpeakerRecognitionModel -> Promise<SpeakerRecognitionResult>) with get, set
    abstract recognize: recoMode: RecognitionMode * successCallback: (SpeechRecognitionResult -> unit) * errorCallBack: (string -> unit) -> Promise<unit>
    abstract stopRecognizing: unit -> Promise<unit>
    abstract connect: unit -> Promise<unit>
    abstract connectAsync: ?cb: Callback * ?err: Callback -> unit
    abstract disconnectOverride: (unit -> Promise<unit>) with get, set
    abstract disconnect: unit -> Promise<unit>
    abstract sendMessage: message: string -> Promise<unit>
    abstract sendNetworkMessage: path: string * payload: U2<string, ArrayBuffer> -> Promise<unit>
    abstract activityTemplate: string with get, set
    abstract processTypeSpecificMessages: connectionMessage: SpeechConnectionMessage * ?successCallback: (SpeechRecognitionResult -> unit) * ?errorCallBack: (string -> unit) -> Promise<bool>
    abstract sendTelemetryData: unit -> Promise<unit>
    abstract cancelRecognition: sessionId: string * requestId: string * cancellationReason: CancellationReason * errorCode: CancellationErrorCode * error: string -> unit
    abstract cancelRecognitionLocal: cancellationReason: CancellationReason * errorCode: CancellationErrorCode * error: string -> Promise<unit>
    abstract receiveMessageOverride: (unit -> Promise<unit>) with get, set
    abstract receiveMessage: unit -> Promise<unit>
    abstract sendSpeechContext: connection: IConnection * generateNewRequestId: bool -> Promise<unit>
    abstract sendPrePayloadJSONOverride: (IConnection -> Promise<unit>) with get, set
    abstract noOp: unit -> Promise<unit>
    abstract sendPrePayloadJSON: connection: IConnection * ?generateNewRequestId: bool -> Promise<unit>
    abstract sendWaveHeader: connection: IConnection -> Promise<unit>
    abstract postConnectImplOverride: (Promise<IConnection> -> Promise<IConnection>) with get, set
    abstract connectImpl: unit -> Promise<IConnection>
    abstract configConnectionOverride: (IConnection -> Promise<IConnection>) with get, set
    abstract handleSpeechPhraseMessage: (string -> Promise<unit>) with get, set
    abstract handleSpeechHypothesisMessage: (string -> unit) with get, set
    abstract sendSpeechServiceConfig: connection: IConnection * requestSession: RequestSession * SpeechServiceConfigJson: string -> Promise<unit>
    abstract fetchConnection: unit -> Promise<IConnection>
    abstract sendAudio: audioStreamNode: IAudioStreamNode -> Promise<unit>

type [<AllowNullLiteral>] ServiceRecognizerBaseStatic =
    [<EmitConstructor>] abstract Create: authentication: IAuthentication * connectionFactory: IConnectionFactory * audioSource: IAudioSource * recognizerConfig: RecognizerConfig * recognizer: Recognizer -> ServiceRecognizerBase
    abstract telemetryData: (string -> unit) with get, set
    abstract telemetryDataEnabled: bool with get, set

type [<AllowNullLiteral>] ConversationServiceRecognizer =
    inherit ServiceRecognizerBase
    abstract processTypeSpecificMessages: connectionMessage: SpeechConnectionMessage -> Promise<bool>
    abstract handleRecognizedCallback: result: SpeechRecognitionResult * offset: float * sessionId: string -> unit
    abstract handleRecognizingCallback: result: SpeechRecognitionResult * duration: float * sessionId: string -> unit
    abstract processSpeechMessages: connectionMessage: SpeechConnectionMessage -> Promise<bool>
    abstract cancelRecognition: sessionId: string * requestId: string * cancellationReason: CancellationReason * errorCode: CancellationErrorCode * error: string -> unit
    abstract handleSpeechPhrase: textBody: string -> Promise<unit>
    abstract handleSpeechHypothesis: textBody: string -> unit

type [<AllowNullLiteral>] ConversationServiceRecognizerStatic =
    [<EmitConstructor>] abstract Create: authentication: IAuthentication * connectionFactory: IConnectionFactory * audioSource: IAudioSource * recognizerConfig: RecognizerConfig * recognizer: Recognizer -> ConversationServiceRecognizer

type [<RequireQualifiedAccess>] RecognitionMode =
    | Interactive = 0
    | Conversation = 1
    | Dictation = 2

type [<RequireQualifiedAccess>] SpeechResultFormat =
    | Simple = 0
    | Detailed = 1

type [<AllowNullLiteral>] RecognizerConfig =
    abstract parameters: PropertyCollection
    abstract recognitionMode: RecognitionMode with get, set
    abstract SpeechServiceConfig: SpeechServiceConfig
    abstract recognitionActivityTimeout: float
    abstract isContinuousRecognition: bool
    abstract languageIdMode: string
    abstract autoDetectSourceLanguages: string
    abstract recognitionEndpointVersion: string
    abstract sourceLanguageModels: ResizeArray<{| language: string; endpoint: string |}>
    abstract maxRetryCount: float
    abstract isSpeakerDiarizationEnabled: bool with get, set

type [<AllowNullLiteral>] RecognizerConfigStatic =
    [<EmitConstructor>] abstract Create: speechServiceConfig: SpeechServiceConfig * parameters: PropertyCollection -> RecognizerConfig

type [<AllowNullLiteral>] SpeechServiceConfig =
    abstract serialize: unit -> string
    abstract Context: Context
    abstract Recognition: string with get, set

type [<AllowNullLiteral>] SpeechServiceConfigStatic =
    [<EmitConstructor>] abstract Create: context: Context -> SpeechServiceConfig

type [<AllowNullLiteral>] Context =
    abstract system: System with get, set
    abstract os: OS with get, set
    abstract audio: ISpeechConfigAudio with get, set
    [<EmitIndexer>] abstract Item: section: string -> obj option with get, set

type [<AllowNullLiteral>] ContextStatic =
    [<EmitConstructor>] abstract Create: os: OS -> Context

type [<AllowNullLiteral>] System =
    abstract name: string with get, set
    abstract version: string with get, set
    abstract build: string with get, set
    abstract lang: string with get, set

type [<AllowNullLiteral>] SystemStatic =
    [<EmitConstructor>] abstract Create: unit -> System

type [<AllowNullLiteral>] OS =
    abstract platform: string with get, set
    abstract name: string with get, set
    abstract version: string with get, set

type [<AllowNullLiteral>] OSStatic =
    [<EmitConstructor>] abstract Create: platform: string * name: string * version: string -> OS

type [<AllowNullLiteral>] Device =
    abstract manufacturer: string with get, set
    abstract model: string with get, set
    abstract version: string with get, set

type [<AllowNullLiteral>] DeviceStatic =
    [<EmitConstructor>] abstract Create: manufacturer: string * model: string * version: string -> Device

type [<AllowNullLiteral>] ISpeechConfigAudio =
    abstract source: ISpeechConfigAudioDevice option with get, set
    abstract playback: ISpeechConfigAudioDevice option with get, set

type [<AllowNullLiteral>] ISpeechConfigAudioDevice =
    abstract manufacturer: string with get, set
    abstract model: string with get, set
    abstract connectivity: connectivity with get, set
    abstract ``type``: ``type`` with get, set
    abstract samplerate: float with get, set
    abstract bitspersample: float with get, set
    abstract channelcount: float with get, set

type [<StringEnum>] [<RequireQualifiedAccess>] connectivity =
    | [<CompiledName("Bluetooth")>] Bluetooth
    | [<CompiledName("Wired")>] Wired
    | [<CompiledName("WiFi")>] WiFi
    | [<CompiledName("Cellular")>] Cellular
    | [<CompiledName("InBuilt")>] InBuilt
    | [<CompiledName("Unknown")>] Unknown

type [<StringEnum>] [<RequireQualifiedAccess>] ``type`` =
    | [<CompiledName("Phone")>] Phone
    | [<CompiledName("Speaker")>] Speaker
    | [<CompiledName("Car")>] Car
    | [<CompiledName("Headset")>] Headset
    | [<CompiledName("Thermostat")>] Thermostat
    | [<CompiledName("Microphones")>] Microphones
    | [<CompiledName("Deskphone")>] Deskphone
    | [<CompiledName("RemoteControl")>] RemoteControl
    | [<CompiledName("Unknown")>] Unknown
    | [<CompiledName("File")>] File
    | [<CompiledName("Stream")>] Stream

type [<AllowNullLiteral>] ITranslations =
    abstract TranslationStatus: TranslationStatus with get, set
    abstract Translations: ResizeArray<ITranslation> with get, set
    abstract FailureReason: string with get, set

type [<AllowNullLiteral>] ITranslation =
    abstract Language: string with get, set
    abstract Text: string option with get, set
    abstract DisplayText: string option with get, set

type [<AllowNullLiteral>] ISpeechEndDetectedResult =
    abstract Offset: float option with get, set

type [<AllowNullLiteral>] ITurnStart =
    abstract context: ITurnStartContext with get, set

type [<AllowNullLiteral>] ITurnStartContext =
    abstract serviceTag: string with get, set

type [<AllowNullLiteral>] IResultErrorDetails =
    abstract errorText: string with get, set
    abstract recogSate: RecognitionCompletionStatus with get, set

type [<AllowNullLiteral>] WebsocketMessageFormatter =
    inherit IWebsocketMessageFormatter
    abstract toConnectionMessage: message: RawWebsocketMessage -> Promise<ConnectionMessage>
    abstract fromConnectionMessage: message: ConnectionMessage -> Promise<RawWebsocketMessage>

type [<AllowNullLiteral>] WebsocketMessageFormatterStatic =
    [<EmitConstructor>] abstract Create: unit -> WebsocketMessageFormatter

type [<AllowNullLiteral>] SpeechConnectionFactory =
    inherit ConnectionFactoryBase
    abstract create: config: RecognizerConfig * authInfo: AuthInfo * ?connectionId: string -> IConnection

type [<AllowNullLiteral>] SpeechConnectionFactoryStatic =
    [<EmitConstructor>] abstract Create: unit -> SpeechConnectionFactory

type [<AllowNullLiteral>] ConversationTranscriberConnectionFactory =
    inherit ConnectionFactoryBase
    abstract create: config: RecognizerConfig * authInfo: AuthInfo * ?connectionId: string -> IConnection
    abstract setV2UrlParams: config: RecognizerConfig * queryParams: IStringDictionary<string> * endpoint: string -> unit

type [<AllowNullLiteral>] ConversationTranscriberConnectionFactoryStatic =
    [<EmitConstructor>] abstract Create: unit -> ConversationTranscriberConnectionFactory

type [<AllowNullLiteral>] TranscriberConnectionFactory =
    inherit ConnectionFactoryBase
    abstract create: config: RecognizerConfig * authInfo: AuthInfo * ?connectionId: string -> IConnection
    abstract setQueryParams: queryParams: IStringDictionary<string> * config: RecognizerConfig * endpointUrl: string -> unit

type [<AllowNullLiteral>] TranscriberConnectionFactoryStatic =
    [<EmitConstructor>] abstract Create: unit -> TranscriberConnectionFactory

type [<AllowNullLiteral>] TranslationConnectionFactory =
    inherit ConnectionFactoryBase
    abstract create: config: RecognizerConfig * authInfo: AuthInfo * ?connectionId: string -> IConnection
    abstract getEndpointUrl: config: RecognizerConfig * ?returnRegionPlaceholder: bool -> string
    abstract setQueryParams: queryParams: IStringDictionary<string> * config: RecognizerConfig * endpointUrl: string -> unit

type [<AllowNullLiteral>] TranslationConnectionFactoryStatic =
    [<EmitConstructor>] abstract Create: unit -> TranslationConnectionFactory

type [<AllowNullLiteral>] SpeechSynthesisConnectionFactory =
    inherit ISynthesisConnectionFactory
    abstract create: config: SynthesizerConfig * authInfo: AuthInfo * ?connectionId: string -> IConnection

type [<AllowNullLiteral>] SpeechSynthesisConnectionFactoryStatic =
    [<EmitConstructor>] abstract Create: unit -> SpeechSynthesisConnectionFactory

type [<AllowNullLiteral>] EnumTranslation =
    interface end

type [<AllowNullLiteral>] EnumTranslationStatic =
    [<EmitConstructor>] abstract Create: unit -> EnumTranslation
    abstract implTranslateRecognitionResult: recognitionStatus: RecognitionStatus -> ResultReason
    abstract implTranslateCancelResult: recognitionStatus: RecognitionStatus -> CancellationReason
    abstract implTranslateCancelErrorCode: recognitionStatus: RecognitionStatus -> CancellationErrorCode
    abstract implTranslateErrorDetails: cancellationErrorCode: CancellationErrorCode -> string

type [<RequireQualifiedAccess>] SynthesisStatus =
    /// <summary>The response contains valid audio data.</summary>
    | Success = 0
    /// <summary>Indicates the end of audio data. No valid audio data is included in the message.</summary>
    | SynthesisEnd = 1
    /// <summary>Indicates an error occurred during synthesis data processing.</summary>
    | Error = 2

type [<RequireQualifiedAccess>] RecognitionStatus =
    | Success = 0
    | NoMatch = 1
    | InitialSilenceTimeout = 2
    | BabbleTimeout = 3
    | Error = 4
    | EndOfDictation = 5
    | TooManyRequests = 6
    | BadRequest = 7
    | Forbidden = 8

type [<AllowNullLiteral>] ITranslationSynthesisEnd =
    abstract SynthesisStatus: SynthesisStatus option with get, set
    abstract FailureReason: string option with get, set
    abstract Status: SynthesisStatus option with get, set

type [<AllowNullLiteral>] TranslationSynthesisEnd =
    inherit ITranslationSynthesisEnd
    abstract SynthesisStatus: SynthesisStatus
    abstract FailureReason: string

type [<AllowNullLiteral>] TranslationSynthesisEndStatic =
    [<EmitConstructor>] abstract Create: unit -> TranslationSynthesisEnd
    abstract fromJSON: json: string -> TranslationSynthesisEnd

type [<AllowNullLiteral>] ITranslationHypothesis =
    abstract Duration: float with get, set
    abstract Offset: float with get, set
    abstract Text: string with get, set
    abstract Translation: ITranslations with get, set

type [<AllowNullLiteral>] TranslationHypothesis =
    inherit ITranslationHypothesis
    abstract Duration: float
    abstract Offset: float
    abstract Text: string
    abstract Translation: ITranslations

type [<AllowNullLiteral>] TranslationHypothesisStatic =
    [<EmitConstructor>] abstract Create: unit -> TranslationHypothesis
    abstract fromJSON: json: string -> TranslationHypothesis

type [<AllowNullLiteral>] ITranslationPhrase =
    abstract RecognitionStatus: RecognitionStatus with get, set
    abstract Offset: float with get, set
    abstract Duration: float with get, set
    abstract Translation: ITranslations option with get, set
    abstract Text: string with get, set
    abstract DisplayText: string option with get, set
    abstract PrimaryLanguage: IPrimaryLanguage option with get, set

type [<AllowNullLiteral>] TranslationPhrase =
    inherit ITranslationPhrase
    abstract RecognitionStatus: RecognitionStatus
    abstract Offset: float
    abstract Duration: float
    abstract Text: string
    abstract Language: string
    abstract Confidence: string
    abstract Translation: ITranslations

type [<AllowNullLiteral>] TranslationPhraseStatic =
    [<EmitConstructor>] abstract Create: unit -> TranslationPhrase
    abstract fromJSON: json: string -> TranslationPhrase
    abstract fromTranslationResponse: translationResponse: {| SpeechPhrase: ITranslationPhrase |} -> TranslationPhrase

type [<AllowNullLiteral>] TranslationServiceRecognizer =
    inherit ConversationServiceRecognizer
    abstract processTypeSpecificMessages: connectionMessage: SpeechConnectionMessage -> Promise<bool>
    abstract cancelRecognition: sessionId: string * requestId: string * cancellationReason: CancellationReason * errorCode: CancellationErrorCode * error: string -> unit
    abstract handleRecognizingCallback: result: SpeechRecognitionResult * duration: float * sessionId: string -> unit
    abstract handleRecognizedCallback: result: SpeechRecognitionResult * offset: float * sessionId: string -> unit

type [<AllowNullLiteral>] TranslationServiceRecognizerStatic =
    [<EmitConstructor>] abstract Create: authentication: IAuthentication * connectionFactory: IConnectionFactory * audioSource: IAudioSource * recognizerConfig: RecognizerConfig * translationRecognizer: TranslationRecognizer -> TranslationServiceRecognizer

type [<AllowNullLiteral>] ISpeechDetected =
    abstract Offset: float with get, set

type [<AllowNullLiteral>] SpeechDetected =
    inherit ISpeechDetected
    abstract Offset: float

type [<AllowNullLiteral>] SpeechDetectedStatic =
    [<EmitConstructor>] abstract Create: unit -> SpeechDetected
    abstract fromJSON: json: string -> SpeechDetected

type [<AllowNullLiteral>] ISpeechHypothesis =
    abstract Text: string with get, set
    abstract Offset: float with get, set
    abstract Duration: float with get, set
    abstract PrimaryLanguage: IPrimaryLanguage option with get, set
    abstract SpeakerId: string option with get, set

type [<AllowNullLiteral>] SpeechHypothesis =
    inherit ISpeechHypothesis
    abstract Text: string
    abstract Offset: float
    abstract Duration: float
    abstract Language: string
    abstract LanguageDetectionConfidence: string
    abstract SpeakerId: string

type [<AllowNullLiteral>] SpeechHypothesisStatic =
    [<EmitConstructor>] abstract Create: unit -> SpeechHypothesis
    abstract fromJSON: json: string -> SpeechHypothesis

type [<AllowNullLiteral>] ISpeechKeyword =
    abstract Status: string with get, set
    abstract Text: string with get, set
    abstract Offset: float with get, set
    abstract Duration: float with get, set

type [<AllowNullLiteral>] SpeechKeyword =
    inherit ISpeechKeyword
    abstract Status: string
    abstract Text: string
    abstract Offset: float
    abstract Duration: float

type [<AllowNullLiteral>] SpeechKeywordStatic =
    [<EmitConstructor>] abstract Create: unit -> SpeechKeyword
    abstract fromJSON: json: string -> SpeechKeyword

type [<AllowNullLiteral>] SpeechServiceRecognizer =
    inherit ServiceRecognizerBase
    abstract processTypeSpecificMessages: connectionMessage: SpeechConnectionMessage -> Promise<bool>
    abstract cancelRecognition: sessionId: string * requestId: string * cancellationReason: CancellationReason * errorCode: CancellationErrorCode * error: string -> unit

type [<AllowNullLiteral>] SpeechServiceRecognizerStatic =
    [<EmitConstructor>] abstract Create: authentication: IAuthentication * connectionFactory: IConnectionFactory * audioSource: IAudioSource * recognizerConfig: RecognizerConfig * speechRecognizer: SpeechRecognizer -> SpeechServiceRecognizer

type [<AllowNullLiteral>] ConversationTranscriptionServiceRecognizer =
    inherit ServiceRecognizerBase
    abstract setSpeakerDiarizationJson: unit -> unit
    abstract processTypeSpecificMessages: connectionMessage: SpeechConnectionMessage -> Promise<bool>
    abstract cancelRecognition: sessionId: string * requestId: string * cancellationReason: CancellationReason * errorCode: CancellationErrorCode * error: string -> unit

type [<AllowNullLiteral>] ConversationTranscriptionServiceRecognizerStatic =
    [<EmitConstructor>] abstract Create: authentication: IAuthentication * connectionFactory: IConnectionFactory * audioSource: IAudioSource * recognizerConfig: RecognizerConfig * conversationTranscriber: ConversationTranscriber -> ConversationTranscriptionServiceRecognizer

type [<AllowNullLiteral>] TranscriptionServiceRecognizer =
    inherit ConversationServiceRecognizer
    abstract sendSpeechEventAsync: info: ConversationInfo * command: string -> Promise<unit>
    abstract sendMeetingSpeechEventAsync: info: MeetingInfo * command: string -> Promise<unit>
    abstract processTypeSpecificMessages: connectionMessage: SpeechConnectionMessage -> Promise<bool>
    abstract handleRecognizedCallback: result: SpeechRecognitionResult * offset: float * sessionId: string -> unit
    abstract handleRecognizingCallback: result: SpeechRecognitionResult * duration: float * sessionId: string -> unit
    abstract cancelRecognition: sessionId: string * requestId: string * cancellationReason: CancellationReason * errorCode: CancellationErrorCode * error: string -> unit
    abstract sendTranscriptionStartJSON: connection: IConnection -> Promise<unit>
    abstract sendSpeechEvent: connection: IConnection * payload: TranscriptionServiceRecognizerSendSpeechEventPayload -> Promise<unit>

/// <summary>
/// Typescript interface contains an <see href="https://www.typescriptlang.org/docs/handbook/2/objects.html#index-signatures">index signature</see> (like <c>{ [key:string]: string }</c>).
/// Unlike an indexer in F#, index signatures index over a type's members.
///
/// As such an index signature cannot be implemented via regular F# Indexer (<c>Item</c> property),
/// but instead by just specifying fields.
///
/// Easiest way to declare such a type is with an Anonymous Record and force it into the function.
/// For example:
/// <code lang="fsharp">
/// type I =
///     [&lt;EmitIndexer&gt;]
///     abstract Item: string -&gt; string
/// let f (i: I) = jsNative
///
/// let t = {| Value1 = "foo"; Value2 = "bar" |}
/// f (!! t)
/// </code>
/// </summary>
type [<AllowNullLiteral>] TranscriptionServiceRecognizerSendSpeechEventPayload =
    [<EmitIndexer>] abstract Item: id: string -> obj option with get, set

type [<AllowNullLiteral>] TranscriptionServiceRecognizerStatic =
    [<EmitConstructor>] abstract Create: authentication: IAuthentication * connectionFactory: IConnectionFactory * audioSource: IAudioSource * recognizerConfig: RecognizerConfig * transcriber: TranscriberRecognizer -> TranscriptionServiceRecognizer

type [<AllowNullLiteral>] IDetailedSpeechPhrase =
    abstract RecognitionStatus: RecognitionStatus with get, set
    abstract NBest: ResizeArray<IPhrase> with get, set
    abstract Duration: float option with get, set
    abstract Offset: float option with get, set
    abstract PrimaryLanguage: IPrimaryLanguage option with get, set
    abstract DisplayText: string option with get, set
    abstract SpeakerId: string option with get, set

type [<AllowNullLiteral>] IPhrase =
    abstract Confidence: float option with get, set
    abstract Lexical: string with get, set
    abstract ITN: string with get, set
    abstract MaskedITN: string with get, set
    abstract Display: string option with get, set
    abstract DisplayText: string option with get, set
    abstract Words: ResizeArray<IWord> option with get, set
    abstract DisplayWords: ResizeArray<IWord> option with get, set

type [<AllowNullLiteral>] IWord =
    abstract Word: string with get, set
    abstract Offset: float with get, set
    abstract Duration: float with get, set

type [<AllowNullLiteral>] DetailedSpeechPhrase =
    inherit IDetailedSpeechPhrase
    abstract getJsonWithCorrectedOffsets: baseOffset: float -> string
    abstract RecognitionStatus: RecognitionStatus
    abstract NBest: ResizeArray<IPhrase>
    abstract Duration: float
    abstract Offset: float
    abstract Language: string
    abstract LanguageDetectionConfidence: string
    abstract Text: string
    abstract SpeakerId: string

type [<AllowNullLiteral>] DetailedSpeechPhraseStatic =
    [<EmitConstructor>] abstract Create: unit -> DetailedSpeechPhrase
    abstract fromJSON: json: string -> DetailedSpeechPhrase

type [<AllowNullLiteral>] ISimpleSpeechPhrase =
    abstract RecognitionStatus: RecognitionStatus with get, set
    abstract DisplayText: string with get, set
    abstract Offset: float option with get, set
    abstract Duration: float option with get, set
    abstract PrimaryLanguage: IPrimaryLanguage option with get, set
    abstract SpeakerId: string option with get, set

type [<AllowNullLiteral>] IPrimaryLanguage =
    abstract Language: string with get, set
    abstract Confidence: string with get, set

type [<AllowNullLiteral>] SimpleSpeechPhrase =
    inherit ISimpleSpeechPhrase
    abstract RecognitionStatus: RecognitionStatus
    abstract DisplayText: string
    abstract Offset: float
    abstract Duration: float
    abstract Language: string
    abstract LanguageDetectionConfidence: string
    abstract SpeakerId: string

type [<AllowNullLiteral>] SimpleSpeechPhraseStatic =
    [<EmitConstructor>] abstract Create: unit -> SimpleSpeechPhrase
    abstract fromJSON: json: string -> SimpleSpeechPhrase

type [<AllowNullLiteral>] AddedLmIntent =
    abstract modelImpl: LanguageUnderstandingModelImpl with get, set
    abstract intentName: string with get, set

type [<AllowNullLiteral>] AddedLmIntentStatic =
    /// <summary>Creates and initializes an instance of this class.</summary>
    /// <param name="modelImpl">The model.</param>
    /// <param name="intentName">The intent name.</param>
    [<EmitConstructor>] abstract Create: modelImpl: LanguageUnderstandingModelImpl * intentName: string -> AddedLmIntent

type [<AllowNullLiteral>] IntentServiceRecognizer =
    inherit ServiceRecognizerBase
    abstract setIntents: addedIntents: IntentServiceRecognizerSetIntentsAddedIntents * umbrellaIntent: AddedLmIntent -> unit
    abstract processTypeSpecificMessages: connectionMessage: SpeechConnectionMessage -> Promise<bool>
    abstract cancelRecognition: sessionId: string * requestId: string * cancellationReason: CancellationReason * errorCode: CancellationErrorCode * error: string -> unit

/// <summary>
/// Typescript interface contains an <see href="https://www.typescriptlang.org/docs/handbook/2/objects.html#index-signatures">index signature</see> (like <c>{ [key:string]: string }</c>).
/// Unlike an indexer in F#, index signatures index over a type's members.
///
/// As such an index signature cannot be implemented via regular F# Indexer (<c>Item</c> property),
/// but instead by just specifying fields.
///
/// Easiest way to declare such a type is with an Anonymous Record and force it into the function.
/// For example:
/// <code lang="fsharp">
/// type I =
///     [&lt;EmitIndexer&gt;]
///     abstract Item: string -&gt; string
/// let f (i: I) = jsNative
///
/// let t = {| Value1 = "foo"; Value2 = "bar" |}
/// f (!! t)
/// </code>
/// </summary>
type [<AllowNullLiteral>] IntentServiceRecognizerSetIntentsAddedIntents =
    [<EmitIndexer>] abstract Item: id: string -> AddedLmIntent with get, set

type [<AllowNullLiteral>] IntentServiceRecognizerStatic =
    [<EmitConstructor>] abstract Create: authentication: IAuthentication * connectionFactory: IConnectionFactory * audioSource: IAudioSource * recognizerConfig: RecognizerConfig * recognizer: IntentRecognizer -> IntentServiceRecognizer

type [<AllowNullLiteral>] IIntentResponse =
    abstract query: string option with get, set
    abstract topScoringIntent: ISingleIntent option with get, set
    abstract entities: ResizeArray<IIntentEntity> option with get, set

type [<AllowNullLiteral>] IIntentEntity =
    abstract entity: string with get, set
    abstract ``type``: string with get, set
    abstract startIndex: float with get, set
    abstract endIndex: float with get, set
    abstract score: float with get, set

type [<AllowNullLiteral>] ISingleIntent =
    abstract intent: string with get, set
    abstract score: float with get, set

type [<AllowNullLiteral>] IntentResponse =
    inherit IIntentResponse
    abstract query: string
    abstract topScoringIntent: ISingleIntent
    abstract entities: ResizeArray<IIntentEntity>

type [<AllowNullLiteral>] IntentResponseStatic =
    [<EmitConstructor>] abstract Create: unit -> IntentResponse
    abstract fromJSON: json: string -> IntentResponse

type [<AllowNullLiteral>] SpeakerResponse =
    abstract scenario: string with get, set
    abstract status: SpeakerStatus with get, set
    abstract verificationResult: VerificationResult option with get, set
    abstract identificationResult: IdentificationResult option with get, set

type [<AllowNullLiteral>] SpeakerStatus =
    abstract statusCode: string with get, set
    abstract reason: string with get, set

type [<AllowNullLiteral>] VerificationResult =
    abstract recognitionResult: string with get, set
    abstract profileId: string with get, set
    abstract score: float with get, set

type [<AllowNullLiteral>] IdentificationResult =
    abstract identifiedProfile: ProfileScore with get, set
    abstract profilesRanking: ResizeArray<ProfileScore> with get, set

type [<AllowNullLiteral>] ProfileScore =
    abstract profileId: string with get, set
    abstract score: float with get, set

type [<AllowNullLiteral>] EnrollmentResponse =
    abstract scenario: string with get, set
    abstract status: SpeakerStatus with get, set
    abstract enrollment: EnrollmentStatus with get, set
    abstract profiles: ResizeArray<IProfile> with get, set

type [<AllowNullLiteral>] ProfileResponse =
    abstract scenario: string with get, set
    abstract operation: string with get, set
    abstract status: SpeakerStatus with get, set
    abstract profiles: ResizeArray<IProfile> with get, set
    abstract profileId: string option with get, set

type [<AllowNullLiteral>] ProfilePhraseResponse =
    abstract status: SpeakerStatus with get, set
    abstract passPhraseType: string with get, set
    abstract locale: string with get, set
    abstract phrases: ResizeArray<string> with get, set

type [<AllowNullLiteral>] IProfile =
    abstract profileId: string with get, set
    abstract profileStatus: string with get, set
    abstract enrollmentStatus: string with get, set
    abstract enrollmentCount: float with get, set
    abstract enrollmentLength: float with get, set
    abstract enrollmentSpeechLength: float with get, set
    abstract remainingEnrollmentCount: float with get, set
    abstract remainingEnrollmentLength: float with get, set
    abstract remainingEnrollmentSpeechLength: float with get, set
    abstract locale: string with get, set
    abstract passPhrase: string with get, set

type [<AllowNullLiteral>] EnrollmentStatus =
    abstract profileId: string with get, set
    abstract enrollmentStatus: string with get, set
    abstract enrollmentLength: float with get, set
    abstract enrollmentSpeechLength: float with get, set
    abstract remainingEnrollmentCount: float with get, set
    abstract remainingEnrollmentSpeechLength: float with get, set
    abstract audioLength: float with get, set
    abstract audioSpeechLength: float with get, set

type [<AllowNullLiteral>] RequestSession =
    abstract sessionId: string
    abstract requestId: string
    abstract audioNodeId: string
    abstract turnCompletionPromise: Promise<unit>
    abstract isSpeechEnded: bool
    abstract isRecognizing: bool
    abstract currentTurnAudioOffset: float
    abstract recogNumber: float
    abstract numConnectionAttempts: float
    abstract bytesSent: float
    abstract recognitionBytesSent: float
    abstract listenForServiceTelemetry: eventSource: IEventSource<PlatformEvent> -> unit
    abstract startNewRecognition: unit -> unit
    abstract onAudioSourceAttachCompleted: audioNode: ReplayableAudioNode * isError: bool -> Promise<unit>
    abstract onPreConnectionStart: authFetchEventId: string * connectionId: string -> unit
    abstract onAuthCompleted: isError: bool -> Promise<unit>
    abstract onConnectionEstablishCompleted: statusCode: float * ?reason: string -> Promise<unit>
    abstract onServiceTurnEndResponse: continuousRecognition: bool -> Promise<unit>
    abstract onSpeechContext: unit -> unit
    abstract onServiceTurnStartResponse: unit -> unit
    abstract onHypothesis: offset: float -> unit
    abstract onPhraseRecognized: offset: float -> unit
    abstract onServiceRecognized: offset: float -> unit
    abstract onAudioSent: bytesSent: float -> unit
    abstract onRetryConnection: unit -> unit
    abstract dispose: unit -> Promise<unit>
    abstract getTelemetry: unit -> string
    abstract onStopRecognizing: unit -> Promise<unit>
    abstract onSpeechEnded: unit -> unit
    abstract onEvent: ``event``: SpeechRecognitionEvent -> unit

type [<AllowNullLiteral>] RequestSessionStatic =
    [<EmitConstructor>] abstract Create: audioSourceId: string -> RequestSession

/// Represents the JSON used in the speech.context message sent to the speech service.
/// The dynamic grammar is always refreshed from the encapsulated dynamic grammar object.
type [<AllowNullLiteral>] SpeechContext =
    /// <summary>Gets a section of the speech.context object.</summary>
    /// <param name="sectionName">Name of the section to get.</param>
    /// <returns>string or Context JSON serializable object that represents the value.</returns>
    abstract getSection: sectionName: string -> U2<string, Context>
    /// <summary>Adds a section to the speech.context object.</summary>
    /// <param name="sectionName">Name of the section to add.</param>
    /// <param name="value">JSON serializable object that represents the value.</param>
    abstract setSection: sectionName: string * value: U2<string, Context> -> unit
    abstract setPronunciationAssessmentParams: ``params``: string * ?isSpeakerDiarizationEnabled: bool -> unit
    abstract setDetailedOutputFormat: unit -> unit
    abstract setWordLevelTimings: unit -> unit
    abstract setSpeakerDiarizationAudioOffsetMs: audioOffsetMs: float -> unit
    abstract toJSON: unit -> string

/// Represents the JSON used in the speech.context message sent to the speech service.
/// The dynamic grammar is always refreshed from the encapsulated dynamic grammar object.
type [<AllowNullLiteral>] SpeechContextStatic =
    [<EmitConstructor>] abstract Create: dynamicGrammar: DynamicGrammarBuilder -> SpeechContext

/// <summary>Responsible for building the object to be sent to the speech service to support dynamic grammars.</summary>
type [<AllowNullLiteral>] DynamicGrammarBuilder =
    abstract addPhrase: phrase: U2<string, ResizeArray<string>> -> unit
    abstract clearPhrases: unit -> unit
    abstract addReferenceGrammar: grammar: U2<string, ResizeArray<string>> -> unit
    abstract clearGrammars: unit -> unit
    abstract generateGrammarObject: unit -> IDynamicGrammar

/// <summary>Responsible for building the object to be sent to the speech service to support dynamic grammars.</summary>
type [<AllowNullLiteral>] DynamicGrammarBuilderStatic =
    [<EmitConstructor>] abstract Create: unit -> DynamicGrammarBuilder

/// Top level grammar node
type [<AllowNullLiteral>] IDynamicGrammar =
    abstract ReferenceGrammars: ResizeArray<string> option with get, set
    abstract Groups: ResizeArray<IDynamicGrammarGroup> option with get, set

/// Group of Dynamic Grammar items of a common type.
type [<AllowNullLiteral>] IDynamicGrammarGroup =
    abstract Type: string with get, set
    abstract Name: string option with get, set
    abstract SubstringMatch: string option with get, set
    abstract Items: U2<ResizeArray<IDynamicGrammarPeople>, ResizeArray<IDynamicGrammarGeneric>> with get, set

type [<AllowNullLiteral>] IDynamicGrammarPeople =
    abstract Name: string with get, set
    abstract First: string option with get, set
    abstract Middle: string option with get, set
    abstract Last: string option with get, set
    abstract Synonyms: ResizeArray<string> option with get, set
    abstract Weight: float option with get, set

/// Generic phrase based dynamic grammars
type [<AllowNullLiteral>] IDynamicGrammarGeneric =
    abstract Text: string with get, set
    abstract Synonyms: ResizeArray<string> option with get, set
    abstract Weight: float option with get, set

type [<AllowNullLiteral>] DialogServiceAdapter =
    inherit ServiceRecognizerBase
    abstract sendMessage: message: string -> Promise<unit>
    abstract privDisconnect: unit -> Promise<unit>
    abstract processTypeSpecificMessages: connectionMessage: SpeechConnectionMessage -> Promise<bool>
    abstract cancelRecognition: sessionId: string * requestId: string * cancellationReason: CancellationReason * errorCode: CancellationErrorCode * error: string -> Promise<unit>
    abstract listenOnce: recoMode: RecognitionMode * successCallback: (SpeechRecognitionResult -> unit) * errorCallback: (string -> unit) -> Promise<unit>

type [<AllowNullLiteral>] DialogServiceAdapterStatic =
    [<EmitConstructor>] abstract Create: authentication: IAuthentication * connectionFactory: IConnectionFactory * audioSource: IAudioSource * recognizerConfig: RecognizerConfig * dialogServiceConnector: DialogServiceConnector -> DialogServiceAdapter

/// Represents the JSON used in the agent.config message sent to the speech service.
type [<AllowNullLiteral>] AgentConfig =
    abstract toJsonString: unit -> string
    abstract get: unit -> IAgentConfig
    /// <summary>Setter for the agent.config object.</summary>
    /// <param name="value">a JSON serializable object.</param>
    abstract set: value: IAgentConfig -> unit

/// Represents the JSON used in the agent.config message sent to the speech service.
type [<AllowNullLiteral>] AgentConfigStatic =
    [<EmitConstructor>] abstract Create: unit -> AgentConfig

type [<AllowNullLiteral>] IAgentConfig =
    abstract botInfo: IAgentConfigBotInfo with get, set
    abstract version: float with get, set

type [<StringEnum>] [<RequireQualifiedAccess>] MetadataType =
    | [<CompiledName("WordBoundary")>] WordBoundary
    | [<CompiledName("Bookmark")>] Bookmark
    | [<CompiledName("Viseme")>] Viseme
    | [<CompiledName("SentenceBoundary")>] SentenceBoundary
    | [<CompiledName("SessionEnd")>] SessionEnd

type [<AllowNullLiteral>] ISynthesisMetadata =
    abstract Type: MetadataType with get, set
    abstract Data: ISynthesisMetadataData with get, set

type [<AllowNullLiteral>] ISynthesisAudioMetadata =
    abstract Metadata: ResizeArray<ISynthesisMetadata> with get, set

type [<AllowNullLiteral>] SynthesisAudioMetadata =
    inherit ISynthesisAudioMetadata
    abstract Metadata: ResizeArray<ISynthesisMetadata>

type [<AllowNullLiteral>] SynthesisAudioMetadataStatic =
    [<EmitConstructor>] abstract Create: unit -> SynthesisAudioMetadata
    abstract fromJSON: json: string -> SynthesisAudioMetadata

type [<AllowNullLiteral>] ISynthesisResponseContext =
    abstract serviceTag: string with get, set

type [<AllowNullLiteral>] ISynthesisResponseAudio =
    abstract ``type``: string with get, set
    abstract streamId: string with get, set

type [<AllowNullLiteral>] ISynthesisResponse =
    abstract context: ISynthesisResponseContext with get, set
    abstract audio: ISynthesisResponseAudio with get, set

type [<AllowNullLiteral>] SynthesisTurn =
    abstract requestId: string
    abstract streamId: string with get, set
    abstract audioOutputFormat: AudioOutputFormatImpl with get, set
    abstract turnCompletionPromise: Promise<unit>
    abstract isSynthesisEnded: bool
    abstract isSynthesizing: bool
    abstract currentTextOffset: float
    abstract currentSentenceOffset: float
    abstract bytesReceived: float
    abstract audioDuration: float
    abstract getAllReceivedAudio: unit -> Promise<ArrayBuffer>
    abstract getAllReceivedAudioWithHeader: unit -> Promise<ArrayBuffer>
    abstract startNewSynthesis: requestId: string * rawText: string * isSSML: bool * ?audioDestination: IAudioDestination -> unit
    abstract onPreConnectionStart: authFetchEventId: string -> unit
    abstract onAuthCompleted: isError: bool -> unit
    abstract onConnectionEstablishCompleted: statusCode: float -> unit
    abstract onServiceResponseMessage: responseJson: string -> unit
    abstract onServiceTurnEndResponse: unit -> unit
    abstract onServiceTurnStartResponse: unit -> unit
    abstract onAudioChunkReceived: data: ArrayBuffer -> unit
    abstract onTextBoundaryEvent: metadata: ISynthesisMetadata -> unit
    abstract onVisemeMetadataReceived: metadata: ISynthesisMetadata -> unit
    abstract onSessionEnd: metadata: ISynthesisMetadata -> unit
    abstract dispose: unit -> unit
    abstract onStopSynthesizing: unit -> unit
    /// Gets the viseme animation string (merged from animation chunk), and clears the internal
    /// partial animation.
    abstract getAndClearVisemeAnimation: unit -> string
    abstract onEvent: ``event``: SpeechSynthesisEvent -> unit

type [<AllowNullLiteral>] SynthesisTurnStatic =
    [<EmitConstructor>] abstract Create: unit -> SynthesisTurn

type [<AllowNullLiteral>] SynthesisAdapterBase =
    inherit IDisposable
    abstract privSynthesisTurn: SynthesisTurn with get, set
    abstract privConnectionId: string with get, set
    abstract privSynthesizerConfig: SynthesizerConfig with get, set
    abstract privSpeechSynthesizer: SpeechSynthesizer with get, set
    abstract privSuccessCallback: (SpeechSynthesisResult -> unit) with get, set
    abstract privErrorCallback: (string -> unit) with get, set
    abstract synthesisContext: SynthesisContext
    abstract agentConfig: AgentConfig
    abstract connectionEvents: EventSource<ConnectionEvent>
    abstract serviceEvents: EventSource<ServiceEvent>
    abstract speakOverride: (string -> string -> (SpeechSynthesisResult -> unit) -> (string -> unit) -> unit) with get, set
    abstract activityTemplate: string with get, set
    abstract receiveMessageOverride: (unit -> unit) with get, set
    abstract connectImplOverride: (bool -> unit) with get, set
    abstract configConnectionOverride: (IConnection -> Promise<IConnection>) with get, set
    abstract audioOutputFormat: AudioOutputFormatImpl with set
    abstract isDisposed: unit -> bool
    /// Performs cleanup operations on this instance
    abstract dispose: ?reason: string -> Promise<unit>
    abstract connect: unit -> Promise<unit>
    abstract sendNetworkMessage: path: string * payload: U2<string, ArrayBuffer> -> Promise<unit>
    abstract Speak: text: string * isSSML: bool * requestId: string * successCallback: (SpeechSynthesisResult -> unit) * errorCallBack: (string -> unit) * audioDestination: IAudioDestination -> Promise<unit>
    abstract cancelSynthesis: requestId: string * cancellationReason: CancellationReason * errorCode: CancellationErrorCode * error: string -> unit
    abstract cancelSynthesisLocal: cancellationReason: CancellationReason * errorCode: CancellationErrorCode * error: string -> unit
    abstract processTypeSpecificMessages: connectionMessage: SpeechConnectionMessage -> bool
    abstract receiveMessage: unit -> Promise<unit>
    abstract sendSynthesisContext: connection: IConnection -> Promise<unit>
    abstract connectImpl: ?isUnAuthorized: bool -> Promise<IConnection>
    abstract sendSpeechServiceConfig: connection: IConnection * SpeechServiceConfigJson: string -> Promise<unit>
    abstract sendSsmlMessage: connection: IConnection * ssml: string * requestId: string -> Promise<unit>

type [<AllowNullLiteral>] SynthesisAdapterBaseStatic =
    abstract telemetryData: (string -> unit) with get, set
    abstract telemetryDataEnabled: bool with get, set
    [<EmitConstructor>] abstract Create: authentication: IAuthentication * connectionFactory: ISynthesisConnectionFactory * synthesizerConfig: SynthesizerConfig * speechSynthesizer: SpeechSynthesizer * audioDestination: IAudioDestination -> SynthesisAdapterBase
    abstract addHeader: audio: ArrayBuffer * format: AudioOutputFormatImpl -> ArrayBuffer

/// <summary>
/// Implements methods for speaker recognition classes, sending requests to endpoint
/// and parsing response into expected format
/// </summary>
type [<AllowNullLiteral>] SynthesisRestAdapter =
    /// <summary>Sends list voices request to endpoint.</summary>
    /// <param name="connectionId">guid for connectionId</param>
    /// <returns>rest response to status request</returns>
    abstract getVoicesList: connectionId: string -> Promise<IRestResponse>

/// <summary>
/// Implements methods for speaker recognition classes, sending requests to endpoint
/// and parsing response into expected format
/// </summary>
type [<AllowNullLiteral>] SynthesisRestAdapterStatic =
    [<EmitConstructor>] abstract Create: config: SynthesizerConfig * authentication: IAuthentication -> SynthesisRestAdapter

type [<RequireQualifiedAccess>] SynthesisServiceType =
    | Standard = 0
    | Custom = 1

type [<AllowNullLiteral>] SynthesizerConfig =
    abstract parameters: PropertyCollection
    abstract synthesisServiceType: SynthesisServiceType with get, set
    abstract SpeechServiceConfig: SpeechServiceConfig

type [<AllowNullLiteral>] SynthesizerConfigStatic =
    [<EmitConstructor>] abstract Create: speechServiceConfig: SpeechServiceConfig * parameters: PropertyCollection -> SynthesizerConfig

/// Represents the JSON used in the synthesis.context message sent to the speech service.
/// The dynamic grammar is always refreshed from the encapsulated dynamic grammar object.
type [<AllowNullLiteral>] SynthesisContext =
    /// <summary>Adds a section to the synthesis.context object.</summary>
    /// <param name="sectionName">Name of the section to add.</param>
    /// <param name="value">JSON serializable object that represents the value.</param>
    abstract setSection: sectionName: string * value: U2<string, obj> -> unit
    /// <summary>Sets the audio output format for synthesis context generation.</summary>
    /// <param name="format">the output format</param>
    abstract audioOutputFormat: AudioOutputFormatImpl with set
    abstract toJSON: unit -> string

/// Represents the JSON used in the synthesis.context message sent to the speech service.
/// The dynamic grammar is always refreshed from the encapsulated dynamic grammar object.
type [<AllowNullLiteral>] SynthesisContextStatic =
    [<EmitConstructor>] abstract Create: speechSynthesizer: SpeechSynthesizer -> SynthesisContext

type [<AllowNullLiteral>] SpeakerRecognitionConfig =
    abstract parameters: PropertyCollection
    abstract Context: Context

type [<AllowNullLiteral>] SpeakerRecognitionConfigStatic =
    [<EmitConstructor>] abstract Create: context: Context * parameters: PropertyCollection -> SpeakerRecognitionConfig

type [<AllowNullLiteral>] SpeakerServiceRecognizer =
    inherit ServiceRecognizerBase
    abstract processTypeSpecificMessages: connectionMessage: SpeechConnectionMessage -> Promise<bool>
    abstract cancelRecognition: sessionId: string * requestId: string * cancellationReason: CancellationReason * errorCode: CancellationErrorCode * error: string -> unit
    abstract recognizeSpeakerOnce: model: SpeakerRecognitionModel -> Promise<SpeakerRecognitionResult>

type [<AllowNullLiteral>] SpeakerServiceRecognizerStatic =
    [<EmitConstructor>] abstract Create: authentication: IAuthentication * connectionFactory: IConnectionFactory * audioSource: IAudioSource * recognizerConfig: RecognizerConfig * recognizer: SpeakerRecognizer -> SpeakerServiceRecognizer

type [<AllowNullLiteral>] VoiceServiceRecognizer =
    inherit ServiceRecognizerBase
    abstract SpeakerAudioSource: IAudioSource with set
    abstract processTypeSpecificMessages: connectionMessage: SpeechConnectionMessage -> Promise<bool>
    abstract cancelRecognition: sessionId: string * requestId: string * cancellationReason: CancellationReason * errorCode: CancellationErrorCode * error: string -> unit
    abstract createProfile: profileType: VoiceProfileType * locale: string -> Promise<ResizeArray<string>>
    abstract resetProfile: profile: VoiceProfile -> Promise<VoiceProfileResult>
    abstract deleteProfile: profile: VoiceProfile -> Promise<VoiceProfileResult>
    abstract retrieveEnrollmentResult: profile: VoiceProfile -> Promise<VoiceProfileEnrollmentResult>
    abstract getAllProfiles: profileType: VoiceProfileType -> Promise<ResizeArray<VoiceProfileEnrollmentResult>>
    abstract getActivationPhrases: profileType: VoiceProfileType * lang: string -> Promise<VoiceProfilePhraseResult>
    abstract enrollProfile: profile: VoiceProfile -> Promise<VoiceProfileEnrollmentResult>

type [<AllowNullLiteral>] VoiceServiceRecognizerStatic =
    [<EmitConstructor>] abstract Create: authentication: IAuthentication * connectionFactory: IConnectionFactory * audioSource: IAudioSource * recognizerConfig: RecognizerConfig * recognizer: VoiceProfileClient -> VoiceServiceRecognizer

type [<AllowNullLiteral>] AudioSourceEvent =
    inherit PlatformEvent
    abstract audioSourceId: string

type [<AllowNullLiteral>] AudioSourceEventStatic =
    [<EmitConstructor>] abstract Create: eventName: string * audioSourceId: string * ?eventType: EventType -> AudioSourceEvent

type [<AllowNullLiteral>] AudioSourceInitializingEvent =
    inherit AudioSourceEvent

type [<AllowNullLiteral>] AudioSourceInitializingEventStatic =
    [<EmitConstructor>] abstract Create: audioSourceId: string -> AudioSourceInitializingEvent

type [<AllowNullLiteral>] AudioSourceReadyEvent =
    inherit AudioSourceEvent

type [<AllowNullLiteral>] AudioSourceReadyEventStatic =
    [<EmitConstructor>] abstract Create: audioSourceId: string -> AudioSourceReadyEvent

type [<AllowNullLiteral>] AudioSourceOffEvent =
    inherit AudioSourceEvent

type [<AllowNullLiteral>] AudioSourceOffEventStatic =
    [<EmitConstructor>] abstract Create: audioSourceId: string -> AudioSourceOffEvent

type [<AllowNullLiteral>] AudioSourceErrorEvent =
    inherit AudioSourceEvent
    abstract error: string

type [<AllowNullLiteral>] AudioSourceErrorEventStatic =
    [<EmitConstructor>] abstract Create: audioSourceId: string * error: string -> AudioSourceErrorEvent

type [<AllowNullLiteral>] AudioStreamNodeEvent =
    inherit AudioSourceEvent
    abstract audioNodeId: string

type [<AllowNullLiteral>] AudioStreamNodeEventStatic =
    [<EmitConstructor>] abstract Create: eventName: string * audioSourceId: string * audioNodeId: string -> AudioStreamNodeEvent

type [<AllowNullLiteral>] AudioStreamNodeAttachingEvent =
    inherit AudioStreamNodeEvent

type [<AllowNullLiteral>] AudioStreamNodeAttachingEventStatic =
    [<EmitConstructor>] abstract Create: audioSourceId: string * audioNodeId: string -> AudioStreamNodeAttachingEvent

type [<AllowNullLiteral>] AudioStreamNodeAttachedEvent =
    inherit AudioStreamNodeEvent

type [<AllowNullLiteral>] AudioStreamNodeAttachedEventStatic =
    [<EmitConstructor>] abstract Create: audioSourceId: string * audioNodeId: string -> AudioStreamNodeAttachedEvent

type [<AllowNullLiteral>] AudioStreamNodeDetachedEvent =
    inherit AudioStreamNodeEvent

type [<AllowNullLiteral>] AudioStreamNodeDetachedEventStatic =
    [<EmitConstructor>] abstract Create: audioSourceId: string * audioNodeId: string -> AudioStreamNodeDetachedEvent

type [<AllowNullLiteral>] AudioStreamNodeErrorEvent =
    inherit AudioStreamNodeEvent
    abstract error: string

type [<AllowNullLiteral>] AudioStreamNodeErrorEventStatic =
    [<EmitConstructor>] abstract Create: audioSourceId: string * audioNodeId: string * error: string -> AudioStreamNodeErrorEvent

type [<AllowNullLiteral>] ServiceEvent =
    inherit PlatformEvent
    abstract jsonString: string

type [<AllowNullLiteral>] ServiceEventStatic =
    [<EmitConstructor>] abstract Create: eventName: string * jsonstring: string * ?eventType: EventType -> ServiceEvent

type [<AllowNullLiteral>] ConnectionEvent =
    inherit PlatformEvent
    abstract connectionId: string

type [<AllowNullLiteral>] ConnectionEventStatic =
    [<EmitConstructor>] abstract Create: eventName: string * connectionId: string * ?eventType: EventType -> ConnectionEvent

type [<AllowNullLiteral>] ConnectionStartEvent =
    inherit ConnectionEvent
    abstract uri: string
    abstract headers: IStringDictionary<string>

type [<AllowNullLiteral>] ConnectionStartEventStatic =
    [<EmitConstructor>] abstract Create: connectionId: string * uri: string * ?headers: IStringDictionary<string> -> ConnectionStartEvent

type [<AllowNullLiteral>] ConnectionEstablishedEvent =
    inherit ConnectionEvent

type [<AllowNullLiteral>] ConnectionEstablishedEventStatic =
    [<EmitConstructor>] abstract Create: connectionId: string -> ConnectionEstablishedEvent

type [<AllowNullLiteral>] ConnectionClosedEvent =
    inherit ConnectionEvent
    abstract reason: string
    abstract statusCode: float

type [<AllowNullLiteral>] ConnectionClosedEventStatic =
    [<EmitConstructor>] abstract Create: connectionId: string * statusCode: float * reason: string -> ConnectionClosedEvent

type [<AllowNullLiteral>] ConnectionErrorEvent =
    inherit ConnectionEvent
    abstract message: string
    abstract ``type``: string

type [<AllowNullLiteral>] ConnectionErrorEventStatic =
    [<EmitConstructor>] abstract Create: connectionId: string * message: string * ``type``: string -> ConnectionErrorEvent

type [<AllowNullLiteral>] ConnectionEstablishErrorEvent =
    inherit ConnectionEvent
    abstract reason: string
    abstract statusCode: float

type [<AllowNullLiteral>] ConnectionEstablishErrorEventStatic =
    [<EmitConstructor>] abstract Create: connectionId: string * statuscode: float * reason: string -> ConnectionEstablishErrorEvent

type [<AllowNullLiteral>] ConnectionMessageReceivedEvent =
    inherit ConnectionEvent
    abstract networkReceivedTime: string
    abstract message: ConnectionMessage

type [<AllowNullLiteral>] ConnectionMessageReceivedEventStatic =
    [<EmitConstructor>] abstract Create: connectionId: string * networkReceivedTimeISO: string * message: ConnectionMessage -> ConnectionMessageReceivedEvent

type [<AllowNullLiteral>] ConnectionMessageSentEvent =
    inherit ConnectionEvent
    abstract networkSentTime: string
    abstract message: ConnectionMessage

type [<AllowNullLiteral>] ConnectionMessageSentEventStatic =
    [<EmitConstructor>] abstract Create: connectionId: string * networkSentTimeISO: string * message: ConnectionMessage -> ConnectionMessageSentEvent

type [<RequireQualifiedAccess>] MessageType =
    | Text = 0
    | Binary = 1

type [<AllowNullLiteral>] ConnectionOpenResponse =
    abstract statusCode: float
    abstract reason: string

type [<AllowNullLiteral>] ConnectionOpenResponseStatic =
    [<EmitConstructor>] abstract Create: statusCode: float * reason: string -> ConnectionOpenResponse

/// <summary>The error that is thrown when an argument passed in is null.</summary>
type [<AllowNullLiteral>] DeferralMap =
    abstract add: id: string * deferral: Deferred<'T> -> unit
    abstract getId: id: string -> Deferred<obj option>
    abstract complete: id: string * result: 'T -> unit

/// <summary>The error that is thrown when an argument passed in is null.</summary>
type [<AllowNullLiteral>] DeferralMapStatic =
    [<EmitConstructor>] abstract Create: unit -> DeferralMap

type [<AllowNullLiteral>] DialogEvent =
    inherit PlatformEvent

type [<AllowNullLiteral>] DialogEventStatic =
    [<EmitConstructor>] abstract Create: eventName: string * ?eventType: EventType -> DialogEvent

type [<AllowNullLiteral>] SendingAgentContextMessageEvent =
    inherit DialogEvent
    abstract agentConfig: AgentConfig

type [<AllowNullLiteral>] SendingAgentContextMessageEventStatic =
    [<EmitConstructor>] abstract Create: agentConfig: AgentConfig -> SendingAgentContextMessageEvent

/// <summary>The error that is thrown when an argument passed in is null.</summary>
type ArgumentNullError = ArgumentNullError of Error
    // inherit System.Exception

/// <summary>The error that is thrown when an argument passed in is null.</summary>
type [<AllowNullLiteral>] ArgumentNullErrorStatic =
    /// <summary>Creates an instance of ArgumentNullError.</summary>
    /// <param name="argumentName">Name of the argument that is null</param>
    [<EmitConstructor>] abstract Create: argumentName: string -> ArgumentNullError

/// <summary>The error that is thrown when an invalid operation is performed in the code.</summary>
type InvalidOperationError = InvalidOperationError of Error
    // inherit Error

/// <summary>The error that is thrown when an invalid operation is performed in the code.</summary>
type [<AllowNullLiteral>] InvalidOperationErrorStatic =
    /// <summary>Creates an instance of InvalidOperationError.</summary>
    /// <param name="error">The error</param>
    [<EmitConstructor>] abstract Create: error: string -> InvalidOperationError

/// <summary>The error that is thrown when an object is disposed.</summary>
type ObjectDisposedError = ObjectDisposedError of Error
    // inherit Error

/// <summary>The error that is thrown when an object is disposed.</summary>
type [<AllowNullLiteral>] ObjectDisposedErrorStatic =
    /// <summary>Creates an instance of ObjectDisposedError.</summary>
    /// <param name="objectName">The object that is disposed</param>
    /// <param name="error">The error</param>
    [<EmitConstructor>] abstract Create: objectName: string * ?error: string -> ObjectDisposedError

type [<AllowNullLiteral>] Events =
    interface end

type [<AllowNullLiteral>] EventsStatic =
    [<EmitConstructor>] abstract Create: unit -> Events
    abstract setEventSource: eventSource: IEventSource<PlatformEvent> -> unit
    abstract instance: IEventSource<PlatformEvent>

type [<AllowNullLiteral>] EventSource<'TEvent when 'TEvent :> PlatformEvent> =
    inherit IEventSource<'TEvent>
    abstract onEvent: ``event``: 'TEvent -> unit
    abstract attach: onEventCallback: ('TEvent -> unit) -> IDetachable
    abstract attachListener: listener: IEventListener<'TEvent> -> IDetachable
    abstract attachConsoleListener: listener: IEventListener<'TEvent> -> IDetachable
    abstract isDisposed: unit -> bool
    /// Performs cleanup operations on this instance
    abstract dispose: unit -> unit
    abstract metadata: IStringDictionary<string>

type [<AllowNullLiteral>] EventSourceStatic =
    [<EmitConstructor>] abstract Create: ?metadata: IStringDictionary<string> -> EventSource<'TEvent>

type [<AllowNullLiteral>] IAudioSource =
    abstract id: unit -> string
    abstract turnOn: unit -> Promise<unit>
    abstract attach: audioNodeId: string -> Promise<IAudioStreamNode>
    abstract detach: audioNodeId: string -> unit
    abstract turnOff: unit -> Promise<unit>
    abstract events: EventSource<AudioSourceEvent> with get, set
    abstract format: Promise<AudioStreamFormatImpl> with get, set
    abstract deviceInfo: Promise<ISpeechConfigAudioDevice> with get, set
    abstract setProperty: name: string * value: string -> unit
    abstract getProperty: name: string * ?def: string -> string

type [<AllowNullLiteral>] IAudioStreamNode =
    inherit IDetachable
    abstract id: unit -> string
    abstract read: unit -> Promise<IStreamChunk<ArrayBuffer>>

type [<RequireQualifiedAccess>] ConnectionState =
    | None = 0
    | Connected = 1
    | Connecting = 2
    | Disconnected = 3

type [<AllowNullLiteral>] IConnection =
    abstract id: string with get, set
    abstract state: unit -> ConnectionState
    abstract ``open``: unit -> Promise<ConnectionOpenResponse>
    abstract send: message: ConnectionMessage -> Promise<unit>
    abstract read: unit -> Promise<ConnectionMessage>
    abstract events: EventSource<ConnectionEvent> with get, set
    abstract dispose: ?disposing: string -> Promise<unit>

type [<AllowNullLiteral>] IDetachable =
    abstract detach: unit -> Promise<unit>

type [<AllowNullLiteral>] IStringDictionary<'TValue> =
    [<EmitIndexer>] abstract Item: propName: string -> 'TValue with get, set

type [<AllowNullLiteral>] INumberDictionary<'TValue> =
    inherit Object
    [<EmitIndexer>] abstract Item: propName: float -> 'TValue with get, set

type [<AllowNullLiteral>] IDisposable =
    /// <returns />
    abstract isDisposed: unit -> bool
    /// <summary>Performs cleanup operations on this instance</summary>
    /// <param name="reason">
    /// optional reason for disposing the instance.
    /// This will be used to throw errors when a operations are performed on the disposed object.
    /// </param>
    abstract dispose: ?reason: string -> unit

type [<AllowNullLiteral>] IEventListener<'TEvent when 'TEvent :> PlatformEvent> =
    abstract onEvent: e: 'TEvent -> unit

type [<AllowNullLiteral>] IEventSource<'TEvent when 'TEvent :> PlatformEvent> =
    inherit IDisposable
    abstract metadata: IStringDictionary<string> with get, set
    abstract onEvent: e: 'TEvent -> unit
    abstract attach: onEventCallback: ('TEvent -> unit) -> IDetachable
    abstract attachListener: listener: IEventListener<'TEvent> -> IDetachable
    abstract attachConsoleListener: listener: IEventListener<'TEvent> -> IDetachable

type [<AllowNullLiteral>] IErrorMessages =
    abstract authInvalidSubscriptionKey: string with get, set
    abstract authInvalidSubscriptionRegion: string with get, set
    abstract invalidArgs: string with get, set
    abstract invalidCreateJoinConversationResponse: string with get, set
    abstract invalidParticipantRequest: string with get, set
    abstract permissionDeniedConnect: string with get, set
    abstract permissionDeniedConversation: string with get, set
    abstract permissionDeniedParticipant: string with get, set
    abstract permissionDeniedSend: string with get, set
    abstract permissionDeniedStart: string with get, set

type [<AllowNullLiteral>] ITimer =
    /// <summary>start timer</summary>
    /// <param name="delay" />
    /// <param name="successCallback" />
    /// <returns />
    abstract start: unit -> unit
    /// <summary>stops timer</summary>
    /// <param name="timerId" />
    abstract stop: unit -> unit

type [<AllowNullLiteral>] IWebsocketMessageFormatter =
    abstract toConnectionMessage: message: RawWebsocketMessage -> Promise<ConnectionMessage>
    abstract fromConnectionMessage: message: ConnectionMessage -> Promise<RawWebsocketMessage>

type [<AllowNullLiteral>] IList<'TItem> =
    inherit IDisposable
    abstract get: itemIndex: float -> 'TItem
    abstract first: unit -> 'TItem
    abstract last: unit -> 'TItem
    abstract add: item: 'TItem -> unit
    abstract insertAt: index: float * item: 'TItem -> unit
    abstract removeFirst: unit -> 'TItem
    abstract removeLast: unit -> 'TItem
    abstract removeAt: index: float -> 'TItem
    abstract remove: index: float * count: float -> ResizeArray<'TItem>
    abstract clear: unit -> unit
    abstract length: unit -> float
    abstract onAdded: addedCallback: (unit -> unit) -> IDetachable
    abstract onRemoved: removedCallback: (unit -> unit) -> IDetachable
    abstract onDisposed: disposedCallback: (unit -> unit) -> IDetachable
    abstract join: ?seperator: string -> string
    abstract toArray: unit -> ResizeArray<'TItem>
    abstract any: ?callback: ('TItem -> float -> bool) -> bool
    abstract all: callback: ('TItem -> bool) -> bool
    abstract forEach: callback: ('TItem -> float -> unit) -> unit
    abstract select: callback: ('TItem -> float -> 'T2) -> List<'T2>
    abstract where: callback: ('TItem -> float -> bool) -> List<'TItem>
    abstract orderBy: compareFn: ('TItem -> 'TItem -> float) -> List<'TItem>
    abstract orderByDesc: compareFn: ('TItem -> 'TItem -> float) -> List<'TItem>
    abstract clone: unit -> List<'TItem>
    abstract concat: list: List<'TItem> -> List<'TItem>
    abstract concatArray: array: ResizeArray<'TItem> -> List<'TItem>

type [<AllowNullLiteral>] List<'TItem> =
    inherit IList<'TItem>
    abstract get: itemIndex: float -> 'TItem
    abstract first: unit -> 'TItem
    abstract last: unit -> 'TItem
    abstract add: item: 'TItem -> unit
    abstract insertAt: index: float * item: 'TItem -> unit
    abstract removeFirst: unit -> 'TItem
    abstract removeLast: unit -> 'TItem
    abstract removeAt: index: float -> 'TItem
    abstract remove: index: float * count: float -> ResizeArray<'TItem>
    abstract clear: unit -> unit
    abstract length: unit -> float
    abstract onAdded: addedCallback: (unit -> unit) -> IDetachable
    abstract onRemoved: removedCallback: (unit -> unit) -> IDetachable
    abstract onDisposed: disposedCallback: (unit -> unit) -> IDetachable
    abstract join: ?seperator: string -> string
    abstract toArray: unit -> ResizeArray<'TItem>
    abstract any: ?callback: ('TItem -> float -> bool) -> bool
    abstract all: callback: ('TItem -> bool) -> bool
    abstract forEach: callback: ('TItem -> float -> unit) -> unit
    abstract select: callback: ('TItem -> float -> 'T2) -> List<'T2>
    abstract where: callback: ('TItem -> float -> bool) -> List<'TItem>
    abstract orderBy: compareFn: ('TItem -> 'TItem -> float) -> List<'TItem>
    abstract orderByDesc: compareFn: ('TItem -> 'TItem -> float) -> List<'TItem>
    abstract clone: unit -> List<'TItem>
    abstract concat: list: List<'TItem> -> List<'TItem>
    abstract concatArray: array: ResizeArray<'TItem> -> List<'TItem>
    abstract isDisposed: unit -> bool
    /// Performs cleanup operations on this instance
    abstract dispose: ?reason: string -> unit

type [<AllowNullLiteral>] ListStatic =
    [<EmitConstructor>] abstract Create: ?list: ResizeArray<'TItem> -> List<'TItem>

type [<RequireQualifiedAccess>] EventType =
    | Debug = 0
    | Info = 1
    | Warning = 2
    | Error = 3
    | None = 4

type [<AllowNullLiteral>] PlatformEvent =
    abstract name: string
    abstract eventId: string
    abstract eventTime: string
    abstract eventType: EventType
    abstract metadata: IStringDictionary<string>

type [<AllowNullLiteral>] PlatformEventStatic =
    [<EmitConstructor>] abstract Create: eventName: string * eventType: EventType -> PlatformEvent

type [<RequireQualifiedAccess>] PromiseState =
    | None = 0
    | Resolved = 1
    | Rejected = 2

type [<AllowNullLiteral>] IDeferred<'T> =
    abstract promise: Promise<'T>
    abstract resolve: result: 'T -> IDeferred<'T>
    abstract reject: error: string -> IDeferred<'T>

type [<AllowNullLiteral>] PromiseResult<'T> =
    abstract privIsCompleted: bool with get, set
    abstract privIsError: bool with get, set
    abstract privError: string with get, set
    abstract privResult: 'T with get, set
    abstract isCompleted: bool
    abstract isError: bool
    abstract error: string
    abstract result: 'T
    abstract throwIfError: (unit -> unit) with get, set

type [<AllowNullLiteral>] PromiseResultStatic =
    [<EmitConstructor>] abstract Create: promiseResultEventSource: PromiseResultEventSource<'T> -> PromiseResult<'T>

type [<AllowNullLiteral>] PromiseResultEventSource<'T> =
    abstract setResult: ('T -> unit) with get, set
    abstract setError: (string -> unit) with get, set
    abstract on: (('T -> unit) -> (string -> unit) -> unit) with get, set

type [<AllowNullLiteral>] PromiseResultEventSourceStatic =
    [<EmitConstructor>] abstract Create: unit -> PromiseResultEventSource<'T>

type [<AllowNullLiteral>] Deferred<'T> =
    inherit IDeferred<'T>
    abstract promise: Promise<'T>
    abstract resolve: (U2<'T, Promise<'T>> -> Deferred<'T>) with get, set
    abstract reject: (string -> Deferred<'T>) with get, set

type [<AllowNullLiteral>] DeferredStatic =
    [<EmitConstructor>] abstract Create: unit -> Deferred<'T>

type [<AllowNullLiteral>] Sink<'T> =
    abstract state: PromiseState
    abstract result: PromiseResult<'T>
    abstract resolve: result: 'T -> unit
    abstract reject: error: string -> unit
    abstract on: successCallback: ('T -> unit) * errorCallback: (string -> unit) -> unit

type [<AllowNullLiteral>] SinkStatic =
    [<EmitConstructor>] abstract Create: unit -> Sink<'T>

type [<AllowNullLiteral>] IQueue<'TItem> =
    inherit IDisposable
    abstract enqueue: item: 'TItem -> unit
    abstract enqueueFromPromise: promise: Promise<'TItem> -> unit
    abstract dequeue: unit -> Promise<'TItem>
    abstract peek: unit -> Promise<'TItem>
    abstract length: unit -> float

type [<AllowNullLiteral>] Queue<'TItem> =
    inherit IQueue<'TItem>
    abstract enqueue: item: 'TItem -> unit
    abstract enqueueFromPromise: promise: Promise<'TItem> -> unit
    abstract dequeue: unit -> Promise<'TItem>
    abstract peek: unit -> Promise<'TItem>
    abstract length: unit -> float
    abstract isDisposed: unit -> bool
    abstract drainAndDispose: pendingItemProcessor: ('TItem -> unit) * ?reason: string -> Promise<unit>
    /// Performs cleanup operations on this instance
    abstract dispose: ?reason: string -> Promise<unit>

type [<AllowNullLiteral>] QueueStatic =
    [<EmitConstructor>] abstract Create: ?list: List<'TItem> -> Queue<'TItem>

type [<AllowNullLiteral>] RawWebsocketMessage =
    abstract messageType: MessageType
    abstract payload: obj option
    abstract textContent: string
    abstract binaryContent: ArrayBuffer
    abstract id: string

type [<AllowNullLiteral>] RawWebsocketMessageStatic =
    [<EmitConstructor>] abstract Create: messageType: MessageType * payload: obj option * ?id: string -> RawWebsocketMessage

type [<AllowNullLiteral>] RiffPcmEncoder =
    abstract encode: actualAudioFrame: Float32Array -> ArrayBuffer

type [<AllowNullLiteral>] RiffPcmEncoderStatic =
    [<EmitConstructor>] abstract Create: actualSampleRate: float * desiredSampleRate: float -> RiffPcmEncoder

type [<AllowNullLiteral>] IStreamChunk<'TBuffer> =
    abstract isEnd: bool with get, set
    abstract buffer: 'TBuffer with get, set
    abstract timeReceived: float with get, set

type [<AllowNullLiteral>] Stream<'TBuffer> =
    abstract isClosed: bool
    abstract isReadEnded: bool
    abstract id: string
    abstract close: unit -> unit
    abstract writeStreamChunk: streamChunk: IStreamChunk<'TBuffer> -> unit
    abstract read: unit -> Promise<IStreamChunk<'TBuffer>>
    abstract readEnded: unit -> unit

type [<AllowNullLiteral>] StreamStatic =
    [<EmitConstructor>] abstract Create: ?streamId: string -> Stream<'TBuffer>

/// <summary>Defines translation status.</summary>
type [<RequireQualifiedAccess>] TranslationStatus =
    | Success = 0
    | Error = 1

type [<AllowNullLiteral>] ChunkedArrayBufferStream =
    inherit Stream<ArrayBuffer>
    abstract writeStreamChunk: chunk: IStreamChunk<ArrayBuffer> -> unit
    abstract close: unit -> unit

type [<AllowNullLiteral>] ChunkedArrayBufferStreamStatic =
    [<EmitConstructor>] abstract Create: targetChunkSize: float * ?streamId: string -> ChunkedArrayBufferStream

type [<AllowNullLiteral>] IAudioDestination =
    abstract id: unit -> string
    abstract write: buffer: ArrayBuffer -> unit
    abstract format: AudioStreamFormat with get, set
    abstract close: ?cb: (unit -> unit) * ?err: (string -> unit) -> unit

type [<AllowNullLiteral>] IWorkerTimers =
    abstract clearTimeout: (float -> unit) with get, set
    abstract setTimeout: ((unit -> obj option) -> float -> float) with get, set

type [<AllowNullLiteral>] Timeout =
    interface end

type [<AllowNullLiteral>] TimeoutStatic =
    [<EmitConstructor>] abstract Create: unit -> Timeout
    abstract clearTimeout: obj with get, set
    abstract setTimeout: obj with get, set
    abstract load: unit -> obj option
    abstract timers: (unit -> IWorkerTimers) with get, set

type [<AllowNullLiteral>] OCSPEvent =
    inherit PlatformEvent

type [<AllowNullLiteral>] OCSPEventStatic =
    [<EmitConstructor>] abstract Create: eventName: string * eventType: EventType * signature: string -> OCSPEvent

type [<AllowNullLiteral>] OCSPMemoryCacheHitEvent =
    inherit OCSPEvent

type [<AllowNullLiteral>] OCSPMemoryCacheHitEventStatic =
    [<EmitConstructor>] abstract Create: signature: string -> OCSPMemoryCacheHitEvent

type [<AllowNullLiteral>] OCSPCacheMissEvent =
    inherit OCSPEvent

type [<AllowNullLiteral>] OCSPCacheMissEventStatic =
    [<EmitConstructor>] abstract Create: signature: string -> OCSPCacheMissEvent

type [<AllowNullLiteral>] OCSPDiskCacheHitEvent =
    inherit OCSPEvent

type [<AllowNullLiteral>] OCSPDiskCacheHitEventStatic =
    [<EmitConstructor>] abstract Create: signature: string -> OCSPDiskCacheHitEvent

type [<AllowNullLiteral>] OCSPCacheUpdateNeededEvent =
    inherit OCSPEvent

type [<AllowNullLiteral>] OCSPCacheUpdateNeededEventStatic =
    [<EmitConstructor>] abstract Create: signature: string -> OCSPCacheUpdateNeededEvent

type [<AllowNullLiteral>] OCSPMemoryCacheStoreEvent =
    inherit OCSPEvent

type [<AllowNullLiteral>] OCSPMemoryCacheStoreEventStatic =
    [<EmitConstructor>] abstract Create: signature: string -> OCSPMemoryCacheStoreEvent

type [<AllowNullLiteral>] OCSPDiskCacheStoreEvent =
    inherit OCSPEvent

type [<AllowNullLiteral>] OCSPDiskCacheStoreEventStatic =
    [<EmitConstructor>] abstract Create: signature: string -> OCSPDiskCacheStoreEvent

type [<AllowNullLiteral>] OCSPCacheUpdateCompleteEvent =
    inherit OCSPEvent

type [<AllowNullLiteral>] OCSPCacheUpdateCompleteEventStatic =
    [<EmitConstructor>] abstract Create: signature: string -> OCSPCacheUpdateCompleteEvent

type [<AllowNullLiteral>] OCSPStapleReceivedEvent =
    inherit OCSPEvent

type [<AllowNullLiteral>] OCSPStapleReceivedEventStatic =
    [<EmitConstructor>] abstract Create: unit -> OCSPStapleReceivedEvent

type [<AllowNullLiteral>] OCSPWSUpgradeStartedEvent =
    inherit OCSPEvent

type [<AllowNullLiteral>] OCSPWSUpgradeStartedEventStatic =
    [<EmitConstructor>] abstract Create: serialNumber: string -> OCSPWSUpgradeStartedEvent

type [<AllowNullLiteral>] OCSPCacheEntryExpiredEvent =
    inherit OCSPEvent

type [<AllowNullLiteral>] OCSPCacheEntryExpiredEventStatic =
    [<EmitConstructor>] abstract Create: serialNumber: string * expireTime: float -> OCSPCacheEntryExpiredEvent

type [<AllowNullLiteral>] OCSPCacheEntryNeedsRefreshEvent =
    inherit OCSPEvent

type [<AllowNullLiteral>] OCSPCacheEntryNeedsRefreshEventStatic =
    [<EmitConstructor>] abstract Create: serialNumber: string * startTime: float * expireTime: float -> OCSPCacheEntryNeedsRefreshEvent

type [<AllowNullLiteral>] OCSPCacheHitEvent =
    inherit OCSPEvent

type [<AllowNullLiteral>] OCSPCacheHitEventStatic =
    [<EmitConstructor>] abstract Create: serialNumber: string * startTime: float * expireTime: float -> OCSPCacheHitEvent

type [<AllowNullLiteral>] OCSPVerificationFailedEvent =
    inherit OCSPEvent

type [<AllowNullLiteral>] OCSPVerificationFailedEventStatic =
    [<EmitConstructor>] abstract Create: serialNumber: string * error: string -> OCSPVerificationFailedEvent

type [<AllowNullLiteral>] OCSPCacheFetchErrorEvent =
    inherit OCSPEvent

type [<AllowNullLiteral>] OCSPCacheFetchErrorEventStatic =
    [<EmitConstructor>] abstract Create: serialNumber: string * error: string -> OCSPCacheFetchErrorEvent

type [<AllowNullLiteral>] OCSPResponseRetrievedEvent =
    inherit OCSPEvent

type [<AllowNullLiteral>] OCSPResponseRetrievedEventStatic =
    [<EmitConstructor>] abstract Create: serialNumber: string -> OCSPResponseRetrievedEvent

type [<AllowNullLiteral>] OCSPCacheUpdateErrorEvent =
    inherit OCSPEvent

type [<AllowNullLiteral>] OCSPCacheUpdateErrorEventStatic =
    [<EmitConstructor>] abstract Create: serialNumber: string * error: string -> OCSPCacheUpdateErrorEvent

type [<AllowNullLiteral>] BackgroundEvent =
    inherit PlatformEvent
    abstract error: string

type [<AllowNullLiteral>] BackgroundEventStatic =
    [<EmitConstructor>] abstract Create: error: string -> BackgroundEvent

type [<AllowNullLiteral>] ConnectionFactoryBase =
    inherit IConnectionFactory
    abstract create: config: RecognizerConfig * authInfo: AuthInfo * ?connectionId: string -> IConnection
    abstract setCommonUrlParams: config: RecognizerConfig * queryParams: IStringDictionary<string> * endpoint: string -> unit
    abstract setUrlParameter: propId: PropertyId * parameterName: string * config: RecognizerConfig * queryParams: IStringDictionary<string> * endpoint: string -> unit

type [<AllowNullLiteral>] ConnectionFactoryBaseStatic =
    [<EmitConstructor>] abstract Create: unit -> ConnectionFactoryBase
    abstract getHostSuffix: region: string -> string

type [<AllowNullLiteral>] SpeechConnectionMessage =
    inherit ConnectionMessage
    abstract path: string
    abstract requestId: string
    abstract contentType: string
    abstract streamId: string
    abstract additionalHeaders: IStringDictionary<string>

type [<AllowNullLiteral>] SpeechConnectionMessageStatic =
    [<EmitConstructor>] abstract Create: messageType: MessageType * path: string * requestId: string * contentType: string * body: obj option * ?streamId: string * ?additionalHeaders: IStringDictionary<string> * ?id: string -> SpeechConnectionMessage
    abstract fromConnectionMessage: message: ConnectionMessage -> SpeechConnectionMessage

type [<AllowNullLiteral>] ConversationManager =
    /// <summary>Make a POST request to the Conversation Manager service endpoint to create or join a conversation.</summary>
    /// <param name="args" />
    /// <param name="conversationCode" />
    /// <param name="callback" />
    /// <param name="errorCallback" />
    abstract createOrJoin: args: PropertyCollection * conversationCode: string * ?cb: (obj option -> unit) * ?err: (string -> unit) -> unit
    /// <summary>Make a DELETE request to the Conversation Manager service endpoint to leave the conversation.</summary>
    /// <param name="args" />
    /// <param name="sessionToken" />
    /// <param name="callback" />
    abstract leave: args: PropertyCollection * sessionToken: string -> Promise<unit>

type [<AllowNullLiteral>] ConversationManagerStatic =
    [<EmitConstructor>] abstract Create: unit -> ConversationManager

type [<AllowNullLiteral>] ConversationConnectionConfig =
    inherit RestConfigBase

type [<AllowNullLiteral>] ConversationConnectionConfigStatic =
    [<EmitConstructor>] abstract Create: unit -> ConversationConnectionConfig
    abstract host: string
    abstract apiVersion: string
    abstract clientAppId: string
    abstract defaultLanguageCode: string
    abstract restPath: string
    abstract webSocketPath: string
    abstract transcriptionEventKeys: ResizeArray<string>

type [<AllowNullLiteral>] ConversationRecognizerFactory =
    interface end

type [<AllowNullLiteral>] ConversationRecognizerFactoryStatic =
    [<EmitConstructor>] abstract Create: unit -> ConversationRecognizerFactory
    abstract fromConfig: conversation: IConversation * speechConfig: SpeechTranslationConfig * ?audioConfig: AudioConfig -> ConversationRecognizer

/// Sends messages to the Conversation Translator websocket and listens for incoming events containing websocket messages.
/// Based off the recognizers in the SDK folder.
type [<AllowNullLiteral>] ConversationTranslatorRecognizer =
    inherit Recognizer
    inherit ConversationRecognizer
    abstract canceled: (ConversationRecognizer -> ConversationTranslationCanceledEventArgs -> unit) with get, set
    abstract conversationExpiration: (ConversationRecognizer -> ConversationExpirationEventArgs -> unit) with get, set
    abstract lockRoomCommandReceived: (ConversationRecognizer -> LockRoomEventArgs -> unit) with get, set
    abstract muteAllCommandReceived: (ConversationRecognizer -> MuteAllEventArgs -> unit) with get, set
    abstract participantJoinCommandReceived: (ConversationRecognizer -> ParticipantEventArgs -> unit) with get, set
    abstract participantLeaveCommandReceived: (ConversationRecognizer -> ParticipantEventArgs -> unit) with get, set
    abstract participantUpdateCommandReceived: (ConversationRecognizer -> ParticipantAttributeEventArgs -> unit) with get, set
    abstract connectionOpened: (ConversationRecognizer -> SessionEventArgs -> unit) with get, set
    abstract connectionClosed: (ConversationRecognizer -> SessionEventArgs -> unit) with get, set
    abstract translationReceived: (ConversationRecognizer -> ConversationReceivedTranslationEventArgs -> unit) with get, set
    abstract participantsListReceived: (ConversationRecognizer -> ParticipantsListEventArgs -> unit) with get, set
    abstract participantsChanged: (ConversationRecognizer -> ConversationParticipantsChangedEventArgs -> unit) with get, set
    abstract connected: (ConnectionEventArgs -> unit) with set
    abstract disconnected: (ConnectionEventArgs -> unit) with set
    /// Return the speech language used by the recognizer
    abstract speechRecognitionLanguage: string
    /// Return the properties for the recognizer
    abstract properties: PropertyCollection
    abstract isDisposed: unit -> bool
    /// <summary>Connect to the recognizer</summary>
    /// <param name="token" />
    abstract connect: token: string * ?cb: (unit -> unit) * ?err: (string -> unit) -> unit
    /// Disconnect from the recognizer
    abstract disconnect: ?cb: (unit -> unit) * ?err: (string -> unit) -> unit
    /// <summary>Send the mute all participants command to the websocket</summary>
    /// <param name="conversationId" />
    /// <param name="participantId" />
    /// <param name="isMuted" />
    abstract sendRequest: command: string * ?cb: (unit -> unit) * ?err: (string -> unit) -> unit
    /// Close and dispose the recognizer
    abstract close: unit -> Promise<unit>
    /// <summary>Dispose the recognizer</summary>
    /// <param name="disposing" />
    abstract dispose: disposing: bool -> Promise<unit>
    /// <summary>Create the config for the recognizer</summary>
    /// <param name="speechConfig" />
    abstract createRecognizerConfig: speechConfig: SpeechServiceConfig -> RecognizerConfig
    /// <summary>
    /// Create the service recognizer.
    /// The audio source is redundnant here but is required by the implementation.
    /// </summary>
    /// <param name="authentication" />
    /// <param name="connectionFactory" />
    /// <param name="audioConfig" />
    /// <param name="recognizerConfig" />
    abstract createServiceRecognizer: authentication: IAuthentication * connectionFactory: IConnectionFactory * audioConfig: AudioConfig * recognizerConfig: RecognizerConfig -> ServiceRecognizerBase

/// Sends messages to the Conversation Translator websocket and listens for incoming events containing websocket messages.
/// Based off the recognizers in the SDK folder.
type [<AllowNullLiteral>] ConversationTranslatorRecognizerStatic =
    [<EmitConstructor>] abstract Create: conversation: IConversation * speechConfig: SpeechTranslationConfig * ?audioConfig: AudioConfig -> ConversationTranslatorRecognizer

type [<AllowNullLiteral>] TranscriberRecognizer =
    inherit Recognizer
    abstract recognizing: (Recognizer -> SpeechRecognitionEventArgs -> unit) with get, set
    abstract recognized: (Recognizer -> SpeechRecognitionEventArgs -> unit) with get, set
    abstract canceled: (Recognizer -> CancellationEventArgs -> unit) with get, set
    abstract speechRecognitionLanguage: string
    abstract properties: PropertyCollection
    abstract authorizationToken: string with get, set
    abstract conversation: Conversation with set
    abstract getConversationInfo: unit -> ConversationInfo
    abstract meeting: Meeting with set
    abstract getMeetingInfo: unit -> MeetingInfo
    abstract IsMeetingRecognizer: unit -> bool
    abstract startContinuousRecognitionAsync: ?cb: (unit -> unit) * ?err: (string -> unit) -> unit
    abstract stopContinuousRecognitionAsync: ?cb: (unit -> unit) * ?err: (string -> unit) -> unit
    /// Dispose of associated resources.
    abstract close: unit -> Promise<unit>
    abstract pushConversationEvent: conversationInfo: ConversationInfo * command: string -> Promise<unit>
    abstract pushMeetingEvent: meetingInfo: MeetingInfo * command: string -> Promise<unit>
    abstract enforceAudioGating: unit -> Promise<unit>
    abstract connectMeetingCallbacks: transcriber: MeetingTranscriber -> unit
    abstract disconnectCallbacks: unit -> unit
    /// <summary>Disposes any resources held by the object.</summary>
    /// <param name="disposing">true if disposing the object.</param>
    abstract dispose: disposing: bool -> Promise<unit>
    abstract createRecognizerConfig: speechConfig: SpeechServiceConfig -> RecognizerConfig
    abstract createServiceRecognizer: authentication: IAuthentication * connectionFactory: IConnectionFactory * audioConfig: AudioConfig * recognizerConfig: RecognizerConfig -> ServiceRecognizerBase

type [<AllowNullLiteral>] TranscriberRecognizerStatic =
    /// <summary>TranscriberRecognizer constructor.</summary>
    /// <param name="speechTranslationConfig">Non-audio configuration associated with the recognizer</param>
    /// <param name="audioConfig">An audio configuration associated with the recognizer</param>
    [<EmitConstructor>] abstract Create: speechTranslationConfig: SpeechTranslationConfig * audioConfig: AudioConfig -> TranscriberRecognizer

type [<AllowNullLiteral>] MuteAllEventArgs =
    inherit SessionEventArgs
    abstract isMuted: bool

type [<AllowNullLiteral>] MuteAllEventArgsStatic =
    [<EmitConstructor>] abstract Create: isMuted: bool * ?sessionId: string -> MuteAllEventArgs

type [<AllowNullLiteral>] LockRoomEventArgs =
    inherit SessionEventArgs
    abstract isMuted: bool

type [<AllowNullLiteral>] LockRoomEventArgsStatic =
    [<EmitConstructor>] abstract Create: isLocked: bool * ?sessionId: string -> LockRoomEventArgs

type [<AllowNullLiteral>] ParticipantEventArgs =
    inherit SessionEventArgs
    abstract participant: IInternalParticipant

type [<AllowNullLiteral>] ParticipantEventArgsStatic =
    [<EmitConstructor>] abstract Create: participant: IInternalParticipant * ?sessionId: string -> ParticipantEventArgs

type [<AllowNullLiteral>] ParticipantAttributeEventArgs =
    inherit SessionEventArgs
    abstract value: U4<bool, float, string, ResizeArray<string>>
    abstract key: string
    abstract id: string

type [<AllowNullLiteral>] ParticipantAttributeEventArgsStatic =
    [<EmitConstructor>] abstract Create: participantId: string * key: string * value: U4<bool, float, string, ResizeArray<string>> * ?sessionId: string -> ParticipantAttributeEventArgs

type [<AllowNullLiteral>] ParticipantsListEventArgs =
    inherit SessionEventArgs
    abstract sessionToken: string
    abstract conversationId: string
    abstract translateTo: ResizeArray<string>
    abstract profanityFilter: string
    abstract roomProfanityFilter: string
    abstract isRoomLocked: bool
    abstract isMuteAll: bool
    abstract participants: ResizeArray<IInternalParticipant>

type [<AllowNullLiteral>] ParticipantsListEventArgsStatic =
    [<EmitConstructor>] abstract Create: conversationId: string * token: string * translateTo: ResizeArray<string> * profanityFilter: string * roomProfanityFilter: string * isRoomLocked: bool * isMuteAll: bool * participants: ResizeArray<IInternalParticipant> * ?sessionId: string -> ParticipantsListEventArgs

type [<AllowNullLiteral>] ConversationReceivedTranslationEventArgs =
    abstract payload: ConversationTranslationResult
    abstract command: string
    abstract sessionId: string

type [<AllowNullLiteral>] ConversationReceivedTranslationEventArgsStatic =
    [<EmitConstructor>] abstract Create: command: string * payload: ConversationTranslationResult * ?sessionId: string -> ConversationReceivedTranslationEventArgs

/// Internal conversation data
type [<AllowNullLiteral>] IInternalConversation =
    abstract cognitiveSpeechAuthToken: string with get, set
    abstract cognitiveSpeechRegion: string with get, set
    abstract participantId: string with get, set
    abstract name: string with get, set
    abstract description: string with get, set
    abstract speechModel: string with get, set
    abstract modalities: float with get, set
    abstract isApproved: bool with get, set
    abstract isMuted: bool with get, set
    abstract roomId: string with get, set
    abstract avatar: string with get, set
    abstract token: string with get, set
    abstract correlationId: string with get, set
    abstract requestId: string with get, set
    abstract isHost: bool with get, set

/// The user who is participating in the conversation.
type [<AllowNullLiteral>] IInternalParticipant =
    abstract avatar: string option with get, set
    abstract displayName: string option with get, set
    abstract id: string option with get, set
    abstract isHost: bool option with get, set
    abstract isMuted: bool option with get, set
    abstract isUsingTts: bool option with get, set
    abstract profanity: bool option with get, set
    abstract preferredLanguage: string option with get, set
    abstract translateToLanguages: ResizeArray<string> option with get, set
    abstract voice: string option with get, set

/// Users participating in the conversation
type [<AllowNullLiteral>] InternalParticipants =
    abstract participants: ResizeArray<IInternalParticipant> with get, set
    abstract meId: string option with get, set
    /// <summary>Add or update a participant</summary>
    /// <param name="value" />
    abstract addOrUpdateParticipant: value: IInternalParticipant -> IInternalParticipant
    /// <summary>Find the participant's position in the participants list.</summary>
    /// <param name="id" />
    abstract getParticipantIndex: id: string -> float
    /// <summary>Find the participant by id.</summary>
    /// <param name="id" />
    abstract getParticipant: id: string -> IInternalParticipant
    /// Remove a participant from the participants list.
    abstract deleteParticipant: id: string -> unit
    /// Helper to return the conversation host.
    abstract host: IInternalParticipant
    /// Helper to return the current user.
    abstract me: IInternalParticipant

/// Users participating in the conversation
type [<AllowNullLiteral>] InternalParticipantsStatic =
    [<EmitConstructor>] abstract Create: ?participants: ResizeArray<IInternalParticipant> * ?meId: string -> InternalParticipants

/// Recognizer for handling Conversation Translator websocket messages
type [<AllowNullLiteral>] ConversationRecognizer =
    abstract isDisposed: unit -> bool
    abstract sendRequest: (string -> ((unit -> unit)) option -> ((string -> unit)) option -> unit) with get, set
    abstract cancelSpeech: (unit -> Promise<unit>) option with get, set
    abstract close: (unit -> Promise<unit>) option with get, set
    abstract conversationExpiration: (ConversationRecognizer -> ConversationExpirationEventArgs -> unit) option with get, set
    abstract connected: (ConnectionEventArgs -> unit) option with get, set
    abstract disconnected: (ConnectionEventArgs -> unit) option with get, set
    abstract canceled: (ConversationRecognizer -> ConversationTranslationCanceledEventArgs -> unit) option with get, set
    abstract connectionOpened: (ConversationRecognizer -> SessionEventArgs -> unit) option with get, set
    abstract connectionClosed: (ConversationRecognizer -> SessionEventArgs -> unit) option with get, set
    abstract participantsListReceived: (ConversationRecognizer -> ParticipantsListEventArgs -> unit) option with get, set
    abstract translationReceived: (ConversationRecognizer -> ConversationReceivedTranslationEventArgs -> unit) option with get, set
    abstract lockRoomCommandReceived: (ConversationRecognizer -> LockRoomEventArgs -> unit) option with get, set
    abstract muteAllCommandReceived: (ConversationRecognizer -> MuteAllEventArgs -> unit) option with get, set
    abstract participantJoinCommandReceived: (ConversationRecognizer -> ParticipantEventArgs -> unit) option with get, set
    abstract participantLeaveCommandReceived: (ConversationRecognizer -> ParticipantEventArgs -> unit) option with get, set
    abstract participantUpdateCommandReceived: (ConversationRecognizer -> ParticipantAttributeEventArgs -> unit) option with get, set
    abstract connect: (string -> ((unit -> unit)) option -> ((string -> unit)) option -> unit) option with get, set

/// Error message returned from the Conversation Translator websocket
type [<AllowNullLiteral>] IConversationResponseErrorMessage =
    abstract code: string with get, set
    abstract message: string with get, set

/// Error returned from the Conversation Translator websocket
type [<AllowNullLiteral>] IConversationResponseError =
    abstract error: IConversationResponseErrorMessage with get, set

/// Base message command
type [<AllowNullLiteral>] IClientMessage =
    abstract ``type``: obj option with get, set

/// Command message
type [<AllowNullLiteral>] ICommandMessage =
    inherit IClientMessage
    abstract command: string option with get, set

/// Text message command
type [<AllowNullLiteral>] IInstantMessageCommand =
    inherit ICommandMessage
    abstract roomId: string with get, set
    abstract nickname: string option with get, set
    abstract participantId: string with get, set
    abstract text: string with get, set

/// Lock command
type [<AllowNullLiteral>] ILockConversationCommand =
    inherit ICommandMessage
    abstract id: string option with get, set
    abstract nickname: string option with get, set
    abstract participantId: string with get, set
    abstract roomid: string with get, set
    abstract value: bool with get, set

/// Mute all command
type [<AllowNullLiteral>] IMuteAllCommand =
    inherit ICommandMessage
    abstract roomid: string with get, set
    abstract nickname: string option with get, set
    abstract participantId: string with get, set
    abstract value: bool with get, set
    abstract id: string option with get, set

/// Mute participant command
type [<AllowNullLiteral>] IMuteCommand =
    inherit ICommandMessage
    abstract roomid: string with get, set
    abstract nickname: string option with get, set
    abstract participantId: string with get, set
    abstract value: bool with get, set
    abstract id: string option with get, set

/// Remove participant command
type [<AllowNullLiteral>] IEjectParticipantCommand =
    inherit ICommandMessage
    abstract roomid: string with get, set
    abstract participantId: string with get, set

/// Change nickname command
type [<AllowNullLiteral>] IChangeNicknameCommand =
    inherit ICommandMessage
    abstract roomid: string with get, set
    abstract participantId: string with get, set
    abstract nickname: string with get, set
    abstract value: string with get, set

/// HTTP response helper
type [<AllowNullLiteral>] IResponse =
    abstract ok: bool with get, set
    abstract status: float with get, set
    abstract statusText: string with get, set
    abstract data: string with get, set
    abstract json: (unit -> 'T) with get, set
    abstract headers: string with get, set

type [<AllowNullLiteral>] AudioOutputFormatImpl =
    inherit AudioStreamFormatImpl
    /// <summary>The format tag of the audio</summary>
    abstract formatTag: AudioFormatTag with get, set
    /// <summary>Specifies if this audio output format has a header</summary>
    abstract hasHeader: bool
    /// <summary>Specifies the header of this format</summary>
    abstract header: ArrayBuffer
    /// <summary>Updates the header based on the audio length</summary>
    /// <param name="audioLength">the audio length</param>
    abstract updateHeader: audioLength: float -> unit
    /// <summary>Specifies the audio format string to be sent to the service</summary>
    abstract requestAudioFormatString: string

type [<AllowNullLiteral>] AudioOutputFormatImplStatic =
    abstract SpeechSynthesisOutputFormatToString: INumberDictionary<string> with get, set
    /// <summary>Creates an instance with the given values.</summary>
    /// <param name="formatTag" />
    /// <param name="channels">Number of channels.</param>
    /// <param name="samplesPerSec">Samples per second.</param>
    /// <param name="avgBytesPerSec">Average bytes per second.</param>
    /// <param name="blockAlign">Block alignment.</param>
    /// <param name="bitsPerSample">Bits per sample.</param>
    /// <param name="audioFormatString">Audio format string</param>
    /// <param name="requestAudioFormatString">Audio format string sent to service.</param>
    /// <param name="hasHeader">If the format has header or not.</param>
    [<EmitConstructor>] abstract Create: formatTag: AudioFormatTag * channels: float * samplesPerSec: float * avgBytesPerSec: float * blockAlign: float * bitsPerSample: float * audioFormatString: string * requestAudioFormatString: string * hasHeader: bool -> AudioOutputFormatImpl
    abstract fromSpeechSynthesisOutputFormat: ?speechSynthesisOutputFormat: SpeechSynthesisOutputFormat -> AudioOutputFormatImpl
    abstract fromSpeechSynthesisOutputFormatString: speechSynthesisOutputFormatString: string -> AudioOutputFormatImpl
    abstract getDefaultOutputFormat: unit -> AudioOutputFormatImpl

type [<AllowNullLiteral>] SpeechSynthesisEvent =
    inherit PlatformEvent
    abstract requestId: string

type [<AllowNullLiteral>] SpeechSynthesisEventStatic =
    [<EmitConstructor>] abstract Create: eventName: string * requestId: string * ?eventType: EventType -> SpeechSynthesisEvent

type [<AllowNullLiteral>] SynthesisTriggeredEvent =
    inherit SpeechSynthesisEvent
    abstract audioSessionDestinationId: string
    abstract audioTurnDestinationId: string

type [<AllowNullLiteral>] SynthesisTriggeredEventStatic =
    [<EmitConstructor>] abstract Create: requestId: string * sessionAudioDestinationId: string * turnAudioDestinationId: string -> SynthesisTriggeredEvent

type [<AllowNullLiteral>] ConnectingToSynthesisServiceEvent =
    inherit SpeechSynthesisEvent
    abstract authFetchEventId: string

type [<AllowNullLiteral>] ConnectingToSynthesisServiceEventStatic =
    [<EmitConstructor>] abstract Create: requestId: string * authFetchEventId: string -> ConnectingToSynthesisServiceEvent

type [<AllowNullLiteral>] SynthesisStartedEvent =
    inherit SpeechSynthesisEvent
    abstract authFetchEventId: string

type [<AllowNullLiteral>] SynthesisStartedEventStatic =
    [<EmitConstructor>] abstract Create: requestId: string * authFetchEventId: string -> SynthesisStartedEvent

type [<AllowNullLiteral>] ConsoleLoggingListener =
    inherit IEventListener<PlatformEvent>
    abstract logPath: PathLike with set
    abstract enableConsoleOutput: bool with set
    abstract onEvent: ``event``: PlatformEvent -> unit

type [<AllowNullLiteral>] ConsoleLoggingListenerStatic =
    // [<EmitConstructor>] abstract Create: ?logLevelFilter: LogLevel -> ConsoleLoggingListener
    [<EmitConstructor>] abstract Create: ?logLevelFilter: obj -> ConsoleLoggingListener

type [<AllowNullLiteral>] IRecorder =
    // abstract record: context: AudioContext * mediaStream: MediaStream * outputStream: Stream<ArrayBuffer> -> unit
    abstract record: context: obj * mediaStream: obj * outputStream: Stream<ArrayBuffer> -> unit
    // abstract releaseMediaResources: context: AudioContext -> unit
    abstract releaseMediaResources: context: obj -> unit
    abstract setWorkletUrl: url: string -> unit

type [<AllowNullLiteral>] MicAudioSource =
    inherit IAudioSource
    abstract format: Promise<AudioStreamFormatImpl>
    abstract turnOn: unit -> Promise<unit>
    abstract id: unit -> string
    abstract attach: audioNodeId: string -> Promise<IAudioStreamNode>
    abstract detach: audioNodeId: string -> unit
    abstract turnOff: unit -> Promise<unit>
    abstract events: EventSource<AudioSourceEvent>
    abstract deviceInfo: Promise<ISpeechConfigAudioDevice>
    abstract setProperty: name: string * value: string -> unit

type [<AllowNullLiteral>] MicAudioSourceStatic =
    // [<EmitConstructor>] abstract Create: privRecorder: IRecorder * ?deviceId: string * ?audioSourceId: string * ?mediaStream: MediaStream -> MicAudioSource
    [<EmitConstructor>] abstract Create: privRecorder: IRecorder * ?deviceId: string * ?audioSourceId: string * ?mediaStream: obj -> MicAudioSource

type [<AllowNullLiteral>] FileAudioSource =
    inherit IAudioSource
    abstract format: Promise<AudioStreamFormatImpl>
    abstract turnOn: unit -> Promise<unit>
    abstract id: unit -> string
    abstract attach: audioNodeId: string -> Promise<IAudioStreamNode>
    abstract detach: audioNodeId: string -> unit
    abstract turnOff: unit -> Promise<unit>
    abstract events: EventSource<AudioSourceEvent>
    abstract deviceInfo: Promise<ISpeechConfigAudioDevice>

type [<AllowNullLiteral>] FileAudioSourceStatic =
    [<EmitConstructor>] abstract Create: file: U2<File, Buffer> * ?filename: string * ?audioSourceId: string -> FileAudioSource

type [<AllowNullLiteral>] PcmRecorder =
    inherit IRecorder
    // abstract record: context: AudioContext * mediaStream: MediaStream * outputStream: Stream<ArrayBuffer> -> unit
    abstract record: context: obj * mediaStream: obj * outputStream: Stream<ArrayBuffer> -> unit
    // abstract releaseMediaResources: context: AudioContext -> unit
    abstract releaseMediaResources: context: obj -> unit
    abstract setWorkletUrl: url: string -> unit

type [<AllowNullLiteral>] PcmRecorderStatic =
    [<EmitConstructor>] abstract Create: stopInputOnRelease: bool -> PcmRecorder

type [<AllowNullLiteral>] WebsocketConnection =
    inherit IConnection
    abstract dispose: unit -> Promise<unit>
    abstract isDisposed: unit -> bool
    abstract id: string
    abstract uri: string
    abstract state: unit -> ConnectionState
    abstract ``open``: unit -> Promise<ConnectionOpenResponse>
    abstract send: message: ConnectionMessage -> Promise<unit>
    abstract read: unit -> Promise<ConnectionMessage>
    abstract events: EventSource<ConnectionEvent>

type [<AllowNullLiteral>] WebsocketConnectionStatic =
    [<EmitConstructor>] abstract Create: uri: string * queryParameters: IStringDictionary<string> * headers: IStringDictionary<string> * messageFormatter: IWebsocketMessageFormatter * proxyInfo: ProxyInfo * ?enableCompression: bool * ?connectionId: string -> WebsocketConnection

type [<AllowNullLiteral>] WebsocketMessageAdapter =
    abstract state: ConnectionState
    abstract ``open``: unit -> Promise<ConnectionOpenResponse>
    abstract send: message: ConnectionMessage -> Promise<unit>
    abstract read: unit -> Promise<ConnectionMessage>
    abstract close: ?reason: string -> Promise<unit>
    abstract events: EventSource<ConnectionEvent>

type [<AllowNullLiteral>] WebsocketMessageAdapterStatic =
    abstract forceNpmWebSocket: bool with get, set
    [<EmitConstructor>] abstract Create: uri: string * connectionId: string * messageFormatter: IWebsocketMessageFormatter * proxyInfo: ProxyInfo * headers: WebsocketMessageAdapterStaticHeaders * enableCompression: bool -> WebsocketMessageAdapter

/// <summary>
/// Typescript interface contains an <see href="https://www.typescriptlang.org/docs/handbook/2/objects.html#index-signatures">index signature</see> (like <c>{ [key:string]: string }</c>).
/// Unlike an indexer in F#, index signatures index over a type's members.
///
/// As such an index signature cannot be implemented via regular F# Indexer (<c>Item</c> property),
/// but instead by just specifying fields.
///
/// Easiest way to declare such a type is with an Anonymous Record and force it into the function.
/// For example:
/// <code lang="fsharp">
/// type I =
///     [&lt;EmitIndexer&gt;]
///     abstract Item: string -&gt; string
/// let f (i: I) = jsNative
///
/// let t = {| Value1 = "foo"; Value2 = "bar" |}
/// f (!! t)
/// </code>
/// </summary>
type [<AllowNullLiteral>] WebsocketMessageAdapterStaticHeaders =
    [<EmitIndexer>] abstract Item: key: string -> string with get, set

type [<AllowNullLiteral>] ReplayableAudioNode =
    inherit IAudioStreamNode
    abstract id: unit -> string
    abstract read: unit -> Promise<IStreamChunk<ArrayBuffer>>
    abstract detach: unit -> Promise<unit>
    abstract replay: unit -> unit
    abstract shrinkBuffers: offset: float -> unit
    abstract findTimeAtOffset: offset: float -> float

type [<AllowNullLiteral>] ReplayableAudioNodeStatic =
    [<EmitConstructor>] abstract Create: audioSource: IAudioStreamNode * bytesPerSecond: float -> ReplayableAudioNode

type [<AllowNullLiteral>] ProxyInfo =
    abstract HostName: string
    abstract Port: float
    abstract UserName: string
    abstract Password: string

type [<AllowNullLiteral>] ProxyInfoStatic =
    [<EmitConstructor>] abstract Create: unit -> ProxyInfo
    abstract fromParameters: parameters: PropertyCollection -> ProxyInfo
    abstract fromRecognizerConfig: config: RecognizerConfig -> ProxyInfo

type [<StringEnum>] [<RequireQualifiedAccess>] RestRequestType =
    | [<CompiledName("GET")>] Get
    | [<CompiledName("POST")>] Post
    | [<CompiledName("DELETE")>] Delete
    | File

type [<AllowNullLiteral>] IRestResponse =
    abstract ok: bool with get, set
    abstract status: float with get, set
    abstract statusText: string with get, set
    abstract data: string with get, set
    abstract json: obj option with get, set
    abstract headers: string with get, set

type [<AllowNullLiteral>] RestMessageAdapter =
    abstract options: IRequestOptions with set
    abstract setHeaders: key: string * value: string -> unit
    abstract request: method: RestRequestType * uri: string * ?queryParams: RestMessageAdapterRequestQueryParams * ?body: obj -> Promise<IRestResponse>

/// <summary>
/// Typescript interface contains an <see href="https://www.typescriptlang.org/docs/handbook/2/objects.html#index-signatures">index signature</see> (like <c>{ [key:string]: string }</c>).
/// Unlike an indexer in F#, index signatures index over a type's members.
///
/// As such an index signature cannot be implemented via regular F# Indexer (<c>Item</c> property),
/// but instead by just specifying fields.
///
/// Easiest way to declare such a type is with an Anonymous Record and force it into the function.
/// For example:
/// <code lang="fsharp">
/// type I =
///     [&lt;EmitIndexer&gt;]
///     abstract Item: string -&gt; string
/// let f (i: I) = jsNative
///
/// let t = {| Value1 = "foo"; Value2 = "bar" |}
/// f (!! t)
/// </code>
/// </summary>
type [<AllowNullLiteral>] RestMessageAdapterRequestQueryParams =
    [<EmitIndexer>] abstract Item: key: string -> obj option with get, set

type [<AllowNullLiteral>] RestMessageAdapterStatic =
    [<EmitConstructor>] abstract Create: configParams: IRequestOptions -> RestMessageAdapter
    abstract extractHeaderValue: headerKey: string * headers: string -> string

/// HTTP request helper
type [<AllowNullLiteral>] IRequestOptions =
    abstract headers: IRequestOptionsHeaders option with get, set
    abstract ignoreCache: bool option with get, set
    abstract timeout: float option with get, set

type [<AllowNullLiteral>] IRestParams =
    abstract apiVersion: string with get, set
    abstract authorization: string with get, set
    abstract clientAppId: string with get, set
    abstract contentTypeKey: string with get, set
    abstract correlationId: string with get, set
    abstract languageCode: string with get, set
    abstract nickname: string with get, set
    abstract profanity: string with get, set
    abstract requestId: string with get, set
    abstract roomId: string with get, set
    abstract sessionToken: string with get, set
    abstract subscriptionKey: string with get, set
    abstract subscriptionRegion: string with get, set
    abstract token: string with get, set

type [<AllowNullLiteral>] RestConfigBase =
    interface end

type [<AllowNullLiteral>] RestConfigBaseStatic =
    [<EmitConstructor>] abstract Create: unit -> RestConfigBase
    abstract requestOptions: IRequestOptions
    abstract configParams: IRestParams
    abstract restErrors: IErrorMessages

type [<AllowNullLiteral>] ConversationTranslatorMessageTypes =
    abstract command: string with get, set
    abstract final: string with get, set
    abstract info: string with get, set
    abstract instantMessage: string with get, set
    abstract keepAlive: string with get, set
    abstract partial: string with get, set
    abstract participantCommand: string with get, set
    abstract translatedMessage: string with get, set

type [<AllowNullLiteral>] ConversationTranslatorCommandTypes =
    abstract changeNickname: string with get, set
    abstract disconnectSession: string with get, set
    abstract ejectParticipant: string with get, set
    abstract instant_message: string with get, set
    abstract joinSession: string with get, set
    abstract leaveSession: string with get, set
    abstract participantList: string with get, set
    abstract roomExpirationWarning: string with get, set
    abstract setLockState: string with get, set
    abstract setMute: string with get, set
    abstract setMuteAll: string with get, set
    abstract setProfanityFiltering: string with get, set
    abstract setTranslateToLanguages: string with get, set
    abstract setUseTTS: string with get, set

type [<AllowNullLiteral>] IAgentConfigBotInfo =
    abstract commType: string with get, set
    abstract connectionId: string with get, set
    abstract conversationId: string with get, set
    abstract fromId: string with get, set
    abstract commandsCulture: string with get, set
    abstract ttsAudioFormat: string with get, set

type [<AllowNullLiteral>] ISynthesisMetadataData =
    abstract Offset: float with get, set
    abstract Duration: float with get, set
    abstract text: {| Text: string; Length: float; BoundaryType: SpeechSynthesisBoundaryType |} with get, set
    abstract Bookmark: string with get, set
    abstract VisemeId: float with get, set
    abstract AnimationChunk: string with get, set
    abstract IsLastAnimation: bool with get, set

type [<AllowNullLiteral>] IRequestOptionsHeaders =
    [<EmitIndexer>] abstract Item: key: string -> string with get, set


// const speechConfig = SpeechSDK.SpeechConfig.fromSubscription(
//     "a653c6ef0384423db1680447b9a74c8c",
//     "eastus"
//   );

let speechConfig:LanguageUnderstandingModel = SpeechSDK.SpeechConfigStatic.Create() //fromSubscription("a653c6ef0384423db1680447b9a74c8c", "eastus")

    // abstract fromSubscription: subscriptionKey: string * appId: string * region: string -> LanguageUnderstandingModel
