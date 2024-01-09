// ts2fable 0.7.1
module rec AzCalling
open System
open Fable.Core
open Fable.Core.JS
open Browser.Types
open AzLogger
open AzCommon

type ReadonlyArray<'T> = System.Collections.Generic.IReadOnlyList<'T>
let [<Import("*","@azure/communication-calling")>] exports: IExports = jsNative


// type AzureLogger = @azure_logger.AzureLogger
// type CommunicationTokenCredential = @azure_communication_common.CommunicationTokenCredential
// type CommunicationUserIdentifier = @azure_communication_common.CommunicationUserIdentifier
// type CommunicationUserKind = @azure_communication_common.CommunicationUserKind
// type MicrosoftTeamsUserIdentifier = @azure_communication_common.MicrosoftTeamsUserIdentifier
// type MicrosoftTeamsUserKind = @azure_communication_common.MicrosoftTeamsUserKind
// type PhoneNumberIdentifier = @azure_communication_common.PhoneNumberIdentifier
// type PhoneNumberKind = @azure_communication_common.PhoneNumberKind
// type UnknownIdentifier = @azure_communication_common.UnknownIdentifier
// type UnknownIdentifierKind = @azure_communication_common.UnknownIdentifierKind

type [<AllowNullLiteral>] IExports =
    abstract CallClient: CallClientStatic
    abstract LocalVideoStream: LocalVideoStreamStatic
    abstract VideoStreamRenderer: VideoStreamRendererStatic

/// Options for accepting a call.
/// Pass video streams that will be used to accept a call.
/// If videoOptions is undefined, then call will be started with local video off.
type [<AllowNullLiteral>] AcceptCallOptions =
    abstract videoOptions: VideoOptions option with get, set

/// Options for making an outgoing PSTN call
type [<AllowNullLiteral>] AddPhoneNumberOptions =
    ///  A phone number in E.164 format that will be used to represent callers identity.
    ///  For example, using the alternateCallerId to add a participant using PSTN, this number will
    ///  be used as the caller id in the PSTN call.
    abstract alternateCallerId: PhoneNumberIdentifier option with get, set

/// Information about a microphone or speaker device.
type [<AllowNullLiteral>] AudioDeviceInfo =
    /// Get the name of this video device.
    abstract name: string
    /// Get Id of this video device.
    abstract id: string
    /// Is this the systems default audio device
    abstract isSystemDefault: bool
    /// Get this audio device type
    abstract deviceType: AudioDeviceType

type [<StringEnum>] [<RequireQualifiedAccess>] AudioDeviceType =
    | [<CompiledName "Microphone">] Microphone
    | [<CompiledName "Speaker">] Speaker
    | [<CompiledName "CompositeAudioDevice">] CompositeAudioDevice

/// Audio options provided when making an outgoing call or joining a group call
type [<AllowNullLiteral>] AudioOptions =
    /// Whether to start the call muted
    abstract muted: bool option with get, set

/// Represents a Call
type [<AllowNullLiteral>] Call =
    /// Get the unique Id for this Call.
    abstract id: string
    /// Caller Information if the call is incoming.
    abstract callerInfo: CallerInfo
    /// Get the state of this Call.
    abstract state: CallState
    /// Containing code/subCode indicating how call ended
    abstract callEndReason: CallEndReason option
    /// Get the call direction, whether Incoming or Outgoing.
    abstract direction: CallDirection
    /// Whether local user is muted, locally or remotely
    abstract isMuted: bool
    /// Whether screen sharing is on
    abstract isScreenSharingOn: bool
    /// Collection of video streams sent to other participants in a call.
    abstract localVideoStreams: ReadonlyArray<LocalVideoStream>
    /// Collection of remote participants participating in this call.
    abstract remoteParticipants: ReadonlyArray<RemoteParticipant>
    /// <summary>Hang up the call.</summary>
    /// <param name="options">? - HangUp options.</param>
    abstract hangUp: options: HangUpOptions option -> Promise<unit>
    /// Mute local microphone.
    abstract mute: unit -> Promise<unit>
    /// Unmute local microphone.
    abstract unmute: unit -> Promise<unit>
    /// Send DTMF tone.
    abstract sendDtmf: dtmfTone: DtmfTone -> Promise<unit>
    /// <summary>Start sending video stream in the call.</summary>
    /// <param name="localVideoStream">- Represents a local video stream and takes a camera in constructor.</param>
    abstract startVideo: localVideoStream: LocalVideoStream -> Promise<unit>
    /// <summary>Stop local video, pass localVideoStream you got from call.startVideo() API call.</summary>
    /// <param name="localVideoStream">- The local video stream to stop streaming.</param>
    abstract stopVideo: localVideoStream: LocalVideoStream -> Promise<unit>
    /// <summary>Add a participant to this Call.</summary>
    /// <param name="identifier">- The identifier of the participant to add.</param>
    // abstract addParticipant: identifier: CommunicationUserIdentifier -> RemoteParticipant
    abstract addParticipant: identifier: CommunicationUserIdentifier -> RemoteParticipant
    // abstract addParticipant: identifier: U2<CommunicationUserIdentifier, MicrosoftTeamsUserIdentifier> -> RemoteParticipant
    // abstract addParticipant: identifier: PhoneNumberIdentifier * ?options: AddPhoneNumberOptions -> RemoteParticipant
    /// <summary>Remove a participant from this Call.</summary>
    /// <param name="identifier">- The identifier of the participant to remove.</param>
    abstract removeParticipant: identifier: U4<CommunicationUserIdentifier, PhoneNumberIdentifier, MicrosoftTeamsUserIdentifier, UnknownIdentifier> -> Promise<unit>
    /// Put this Call on hold.
    abstract hold: unit -> Promise<unit>
    /// Resume this Call.
    abstract resume: unit -> Promise<unit>
    /// Start local screen sharing, browser handles screen/window enumeration and selection.
    abstract startScreenSharing: unit -> Promise<unit>
    /// Stop local screen sharing.
    abstract stopScreenSharing: unit -> Promise<unit>
    /// <summary>Subscribe function for stateChanged event</summary>
    /// <param name="listener">- callback fn that will be called when value of this property will change</param>
    ///
    // TODO: Ask Maxime how to implement this "on_stateChange" with the PropertyChangedEvent
    // [<Emit "$0.on('stateChanged',$1)">] abstract on_stateChanged: listener: PropertyChangedEvent -> unit
    [<Emit "$0.on('stateChanged',$1)">] abstract on_stateChanged: listener: obj -> unit
    /// <summary>Subscribe function for idChanged event</summary>
    /// <param name="listener">- callback fn that will be called when value of this property will change</param>
    // [<Emit "$0.on('idChanged',$1)">] abstract on_idChanged: listener: PropertyChangedEvent -> unit
    [<Emit "$0.on('idChanged',$1)">] abstract on_idChanged: listener: obj -> unit
    /// <summary>Subscribe function for isMutedChanged event</summary>
    /// <param name="listener">- callback fn that will be called when value of this property will change</param>
    [<Emit "$0.on('isMutedChanged',$1)">] abstract on_isMutedChanged: listener: PropertyChangedEvent -> unit
    /// <summary>Subscribe function for isScreenSharingChanged event</summary>
    /// <param name="listener">- callback fn that will be called when value of this property will change</param>
    [<Emit "$0.on('isScreenSharingOnChanged',$1)">] abstract on_isScreenSharingOnChanged: listener: PropertyChangedEvent -> unit
    /// <summary>Subscribe function for remoteParticipantsUpdated event</summary>
    // / <param name="listener">- callback fn that will be called when this collection will change,
    // / it will pass arrays of added and removed elements</param>
    [<Emit "$0.on('remoteParticipantsUpdated',$1)">]
    abstract member on_remoteParticipantsUpdated: (CollectionUpdatedEventInvokeArgs<'T> -> unit) -> unit
    // / <summary>Subscribe function for localVideoStreamsUpdated event</summary>
    // / <param name="listener">- callback fn that will be called when this collection will change,
    // / it will pass arrays of added and removed elements</param>
    [<Emit "$0.on('localVideoStreamsUpdated',$1)">] abstract on_localVideoStreamsUpdated: (CollectionUpdatedEventInvokeArgs<'T> -> unit) -> unit
    /// <summary>Unsubscribe function for stateChanged event</summary>
    /// <param name="listener">- callback fn that was used to subscribe to this event</param>
    [<Emit "$0.off('stateChanged',$1)">] abstract off_stateChanged: listener: PropertyChangedEvent -> unit
    /// <summary>Unsubscribe function for idChanged event</summary>
    /// <param name="listener">- callback fn that was used to subscribe to this event</param>
    [<Emit "$0.off('idChanged',$1)">] abstract off_idChanged: listener: PropertyChangedEvent -> unit
    /// <summary>Subscribe function for isMutedChanged event</summary>
    /// <param name="listener">- callback fn that will be called when value of this property will change</param>
    [<Emit "$0.off('isMutedChanged',$1)">] abstract off_isMutedChanged: listener: PropertyChangedEvent -> unit
    /// <summary>Unsubscribe function for isScreenSharingChanged event</summary>
    /// <param name="listener">- callback fn that was used to subscribe to this event</param>
    [<Emit "$0.off('isScreenSharingOnChanged',$1)">] abstract off_isScreenSharingOnChanged: listener: PropertyChangedEvent -> unit
    /// <summary>Unsubscribe function for remoteParticipantsUpdated event</summary>
    /// <param name="listener">- callback fn that was used to subscribe to this event</param>
    [<Emit "$0.off('remoteParticipantsUpdated',$1)">] abstract off_remoteParticipantsUpdated: listener: CollectionUpdatedEvent<RemoteParticipant> -> unit
    /// <summary>Unsubscribe function for localVideoStreamsUpdated event</summary>
    /// <param name="listener">- callback fn that was used to subscribe to this event</param>
    [<Emit "$0.off('localVideoStreamsUpdated',$1)">] abstract off_localVideoStreamsUpdated: listener: CollectionUpdatedEvent<LocalVideoStream> -> unit

/// The CallAgent is used to handle calls.
type [<AllowNullLiteral>] CallAgent =
    /// Get the calls.
    abstract calls: ReadonlyArray<Call>
    /// Specify the display name of the local participant for all new calls.
    abstract displayName: string option
    /// <summary>Initiates a call to the participants provided.</summary>
    /// <param name="participants">- User Identifiers (Callees) to make a call to.</param>
    /// <param name="options">? - Start Call options.</param>
    // abstract startCall: participants: ResizeArray<U3<CommunicationUserIdentifier, PhoneNumberIdentifier, UnknownIdentifier>> * ?options: StartCallOptions -> Call
    abstract startCall: participants: ResizeArray<obj> * options: obj option -> Call
    /// <summary>Join a group call.
    /// To join a group call just use a groupId.</summary>
    /// <param name="groupLocator">- Group call information.</param>
    /// <param name="options">- Call start options.</param>
    // abstract join: groupLocator: GroupLocator * ?options: JoinCallOptions -> Call
    abstract join: groupLocator: GroupLocator * ?options: obj option -> Call
    /// Dispose this CallAgent ( required to create another new CallAgent)
    abstract dispose: unit -> Promise<unit>
    /// <summary>Subscribe function for incomingCall event.</summary>
    // / <param name="listener">- callback fn that will be called when this callAgent will receive an incoming call</param>
    [<Emit "$0.on('incomingCall',$1)">]
    abstract member on_incomingCall:(IncomingCallEventInvokeArgs<'T> -> unit) -> unit
    /// <summary>Unsubscribe function for incomingCall event.</summary>
    /// <param name="listener">- callback fn that was used to subscribe to this event.</param>
    [<Emit "$0.off('incomingCall',$1)">] abstract off_incomingCall: listener: IncomingCallEvent -> unit
    /// <summary>Subscribe function for callsUpdated event.</summary>
    // / <param name="listener">- callback fn that will be called when this collection will change,
    // / it will pass arrays of added and removed elements</param>
    [<Emit "$0.on('callsUpdated',$1)">]
// abstract member on_callsUpdated: (CollectionUpdatedEventInvokeArgs<'T> -> unit) -> unit
    abstract member on_callsUpdated: (CollectionUpdatedEventInvokeArgs<'T> -> unit) -> unit
    /// <summary>Unsubscribe function for callsUpdated event.</summary>
    /// <param name="listener">- allback fn that was used to subscribe to this event.</param>
    [<Emit "$0.off('callsUpdated',$1)">]
    abstract member off_callsUpdated: listener: (CollectionUpdatedEvent<'T> -> unit) -> unit

/// Options for creating CallAgent.
type [<AllowNullLiteral>] CallAgentOptions =
    /// Specify the display name of the local participant for all new calls.
    abstract displayName: string option with get, set

/// The CallClient is the main entry point to the SDK.
/// The CallClient is used to create the CallAgent and to get the DeviceManager.
type [<AllowNullLiteral>] CallClient =
    /// <summary>The CallAgent is used to handle calls.
    /// To create the CallAgent, pass a CommunicationTokenCredential object provided from SDK.
    /// - The CallClient can only have one active CallAgent instance at a time.
    /// - You can create a new CallClient instance to create a new CallAgent.
    /// - You can dispose of a CallClient's current active CallAgent, and call the CallClient's
    ///    createCallAgent() method again to create a new CallAgent.</summary>
    /// <param name="tokenCredential">- The token credential. Use AzureCommunicationTokenCredential from</param>
    /// <param name="options">- The CallAgentOptions for additional options like display name.</param>
    abstract createCallAgent: tokenCredential: CommunicationTokenCredential * options: CallAgentOptions option -> Promise<CallAgent>
    /// The DeviceManager is used to handle media devices such as cameras, microphones, and speakers.
    abstract getDeviceManager: unit -> Promise<DeviceManager>

/// The CallClient is the main entry point to the SDK.
/// The CallClient is used to create the CallAgent and to get the DeviceManager.
type [<AllowNullLiteral>] CallClientStatic =
    /// Create a CallClient.
    [<Emit "new $0($1...)">] abstract Create: ?options: obj -> CallClient

type [<AllowNullLiteral>] CallClientOptions =
    /// Specify custom logger injected to the client,
    /// Logger implementation is provided by @azure/logger package
    abstract logger: AzureLogger option with get, set

type [<StringEnum>] [<RequireQualifiedAccess>] CallDirection =
    | [<CompiledName "Incoming">] Incoming
    | [<CompiledName "Outgoing">] Outgoing

type [<AllowNullLiteral>] CallEndedEvent =
    [<Emit "$0($1...)">] abstract Invoke: args: CallEndedEventInvokeArgs<'T> -> unit

type [<AllowNullLiteral>] CallEndedEventInvokeArgs<'T> =
    abstract callEndReason: CallEndReason with get, set

/// Describes the reason why the call ended
type [<AllowNullLiteral>] CallEndReason =
    /// Get the HTTP code.
    abstract code: float
    /// Get the subCode/reason code.
    abstract subCode: float option

/// Caller Information
type [<AllowNullLiteral>] CallerInfo =
    /// Identifier of the caller
    abstract identifier: U4<CommunicationUserKind, PhoneNumberKind, MicrosoftTeamsUserKind, UnknownIdentifierKind> option
    /// Display name of caller ( optional )
    abstract displayName: string option

type [<StringEnum>] [<RequireQualifiedAccess>] CallState =
    | [<CompiledName "None">] None
    | [<CompiledName "Connecting">] Connecting
    | [<CompiledName "Ringing">] Ringing
    | [<CompiledName "Connected">] Connected
    | [<CompiledName "LocalHold">] LocalHold
    | [<CompiledName "RemoteHold">] RemoteHold
    | [<CompiledName "InLobby">] InLobby
    | [<CompiledName "Disconnecting">] Disconnecting
    | [<CompiledName "Disconnected">] Disconnected
    | [<CompiledName "EarlyMedia">] EarlyMedia

type [<AllowNullLiteral>] CollectionUpdatedEvent<'T> =
    [<Emit "$0($1...)">] abstract Invoke: args: CollectionUpdatedEventInvokeArgs<'T> -> unit

type [<AllowNullLiteral>] CollectionUpdatedEventInvokeArgs<'T> =
    abstract added: ResizeArray<'T> with get, set
    abstract removed: ResizeArray<'T> with get, set

/// Error that get's throw when API call fails.
type [<AllowNullLiteral>] CommunicationServicesError =
    /// Get the error name
    abstract name: string
    /// Get the HTTP code.
    abstract code: float
    /// Get the subCode/reason code
    abstract subCode: float
    /// Get a human readable message about the error
    abstract message: string

/// Information about a composite audio device
type [<AllowNullLiteral>] CompositeAudioDeviceInfo =
    abstract microphone: AudioDeviceInfo
    abstract speaker: AudioDeviceInfo
    abstract compositeAudioDeviceType: CompositeAudioDeviceType

type [<StringEnum>] [<RequireQualifiedAccess>] CompositeAudioDeviceType =
    | [<CompiledName "Speaker">] Speaker
    | [<CompiledName "Headphones">] Headphones
    | [<CompiledName "Headset">] Headset
    | [<CompiledName "Handset">] Handset
    | [<CompiledName "Speakerphone">] Speakerphone

/// Options for the renderer of a video stream
type [<AllowNullLiteral>] CreateViewOptions =
    abstract isMirrored: bool option with get, set
    abstract scalingMode: ScalingMode option with get, set

/// Defines permission granted by the user
type [<AllowNullLiteral>] DeviceAccess =
    abstract audio: bool with get, set
    abstract video: bool with get, set

/// The Device Manager is used to handle system
/// media devices such as cameras, microphones, and speakers.
type [<AllowNullLiteral>] DeviceManager =
    /// Whether the device host can select speaker output
    abstract isSpeakerSelectionAvailable: bool
    /// The microphone device that is being used.
    abstract selectedMicrophone: AudioDeviceInfo option
    /// The speaker device that is being used.
    abstract selectedSpeaker: AudioDeviceInfo option
    /// Get a list of available video devices for use.
    abstract getCameras: unit -> Promise<ResizeArray<VideoDeviceInfo>>
    /// Get a list of available microphone devices for use.
    abstract getMicrophones: unit -> Promise<ResizeArray<AudioDeviceInfo>>
    /// Get a list of available speaker devices for use.
    abstract getSpeakers: unit -> Promise<ResizeArray<AudioDeviceInfo>>
    /// <summary>Selects the microphone device to use.</summary>
    /// <param name="microphoneDevice">- Microphone device information.</param>
    abstract selectMicrophone: microphoneDevice: AudioDeviceInfo -> Promise<unit>
    /// <summary>Select the speaker device to use.</summary>
    /// <param name="speakerDevice">- Speaker device information.</param>
    abstract selectSpeaker: speakerDevice: AudioDeviceInfo -> Promise<unit>
    /// <summary>Show browser prompt to ask the front end user for permission to use the specified device.</summary>
    /// <param name="permissionConstraints">- configures which permission (audio/video) to request</param>
    abstract askDevicePermission: permissionConstraints: obj -> Promise<DeviceAccess>
    /// <summary>Subscribe function for videoDevicesUpdated event</summary>
    // <param name="listener">- callback fn that will be called when value of this property will change</param>
    [<Emit "$0.on('videoDevicesUpdated',$1)">] abstract on_videoDevicesUpdated: (CollectionUpdatedEventInvokeArgs<VideoDeviceInfo> -> unit) -> unit
    // /// <summary>Subscribe function for videoDevicesUpdated event</summary>
    // /// <param name="listener">- callback fn that will be called when value of this property will change</param>
    // [<Emit "$0.on('videoDevicesUpdated',$1)">] abstract on_videoDevicesUpdated: listener: CollectionUpdatedEvent<VideoDeviceInfo> -> unit
    /// <summary>Subscribe function for audioDevicesUpdated event</summary>
    /// <param name="listener">- callback fn that will be called when value of this property will change</param>
    // [<Emit "$0.on('audioDevicesUpdated',$1)">] abstract on_audioDevicesUpdated: listener: CollectionUpdatedEvent<AudioDeviceInfo> -> unit
    [<Emit "$0.on('audioDevicesUpdated',$1)">] abstract on_audioDevicesUpdated: listener: (CollectionUpdatedEventInvokeArgs<AudioDeviceInfo> -> unit) -> unit
    /// <summary>Subscribe function for selectedMicrophoneChanged event</summary>
    /// <param name="listener">- callback fn that will be called when value of this property will change</param>
    [<Emit "$0.on('selectedMicrophoneChanged',$1)">] abstract on_selectedMicrophoneChanged: listener: PropertyChangedEvent -> unit
    /// <summary>Subscribe function for selectedSpeakerChanged event</summary>
    // / <param name="listener">- callback fn that will be called when value of this property will change</param>
    // [<Emit "$0.on('selectedSpeakerChanged',$1)">] abstract on_selectedSpeakerChanged: listener: PropertyChangedEvent -> unit
    [<Emit "$0.on('selectedSpeakerChanged',$1)">] abstract on_selectedSpeakerChanged: (CollectionUpdatedEventInvokeArgs<AudioDeviceInfo> -> unit) -> unit
    /// <summary>Unsubscribe function for videoDevicesUpdated event</summary>
    /// <param name="listener">- callback fn that was used to subscribe to this event</param>
    [<Emit "$0.off('videoDevicesUpdated',$1)">] abstract off_videoDevicesUpdated: listener: CollectionUpdatedEvent<VideoDeviceInfo> -> unit
    /// <summary>Unsubscribe function for audioDevicesUpdated event</summary>
    /// <param name="listener">- callback fn that was used to subscribe to this event</param>
    [<Emit "$0.off('audioDevicesUpdated',$1)">] abstract off_audioDevicesUpdated: listener: CollectionUpdatedEvent<AudioDeviceInfo> -> unit
    /// <summary>Unsubscribe function for selectedMicrophoneChanged event</summary>
    /// <param name="listener">- callback fn that will be called when value of this property will change</param>
    [<Emit "$0.off('selectedMicrophoneChanged',$1)">] abstract off_selectedMicrophoneChanged: listener: PropertyChangedEvent -> unit
    /// <summary>Unsubscribe function for selectedSpeakerChanged event</summary>
    /// <param name="listener">- callback fn that will be called when value of this property will change</param>
    [<Emit "$0.off('selectedSpeakerChanged',$1)">] abstract off_selectedSpeakerChanged: listener: PropertyChangedEvent -> unit

type [<StringEnum>] [<RequireQualifiedAccess>] DeviceType =
    | [<CompiledName "Camera">] Camera
    | [<CompiledName "Microphone">] Microphone
    | [<CompiledName "Speaker">] Speaker

/// Dispose of an object
type [<AllowNullLiteral>] Disposable =
    abstract dispose: ?causeId: string -> unit

type [<StringEnum>] [<RequireQualifiedAccess>] DtmfTone =
    | [<CompiledName "A">] A
    | [<CompiledName "B">] B
    | [<CompiledName "C">] C
    | [<CompiledName "D">] D
    | [<CompiledName "Flash">] Flash
    | [<CompiledName "Num0">] Num0
    | [<CompiledName "Num1">] Num1
    | [<CompiledName "Num2">] Num2
    | [<CompiledName "Num3">] Num3
    | [<CompiledName "Num4">] Num4
    | [<CompiledName "Num5">] Num5
    | [<CompiledName "Num6">] Num6
    | [<CompiledName "Num7">] Num7
    | [<CompiledName "Num8">] Num8
    | [<CompiledName "Num9">] Num9
    | [<CompiledName "Pound">] Pound
    | [<CompiledName "Star">] Star

/// Locator used for joining a group call.
type [<AllowNullLiteral>] GroupCallLocator =
    abstract groupId: string with get, set

type GroupLocator =
    GroupCallLocator

/// Options for hanging up a call
type [<AllowNullLiteral>] HangUpOptions =
    /// End the call for everyone
    abstract forEveryone: bool with get, set

/// Represents an incoming call
type [<AllowNullLiteral>] IncomingCall =
    /// Get the unique Id for this Call.
    abstract id: string
    /// Identifier of the caller
    abstract callerInfo: CallerInfo
    /// Containing code/subCode indicating how call ended
    abstract callEndReason: CallEndReason option
    /// <summary>Accept this incoming Call.</summary>
    /// <param name="options">- accept options.</param>
    abstract accept2: ?options: AcceptCallOptions -> Promise<Call>
    abstract accept: obj option -> Promise<Call>
    /// Reject this incoming Call.
    abstract reject: unit -> Promise<unit>
    /// <summary>Subscribe function for onCallEnded event</summary>
    // / <param name="listener">- callback fn that was used to subscribe to this event</param>
    // [<Emit "$0.on('callEnded',$1)">] abstract member on_callEnded: (CallEndedEventInvokeArgs<'T> -> unit) -> unit
    [<Emit "$0.on('callEnded',$1)">] abstract member on_callEnded: (IncomingCallEventInvokeArgs<'T> -> unit) -> unit
    /// <summary>Unsubscribe function for onCallEnded event</summary>
    /// <param name="listener">- callback fn that was used to subscribe to this event</param>
    [<Emit "$0.off('callEnded',$1)">] abstract off_callEnded: listener: CallEndedEvent -> unit

type [<AllowNullLiteral>] IncomingCallEvent =
    [<Emit "$0($1...)">] abstract Invoke: args: IncomingCallEventInvokeArgs<'T> -> unit

type [<AllowNullLiteral>] IncomingCallEventInvokeArgs<'T> =
    abstract incomingCall: IncomingCall with get, set

/// Options for joining a group call.
/// Pass video streams that will be used to start a call.
/// Pass audio options weather to join the call muted or unmuted
/// If videoOptions is undefined, then call will be started with local video off.
type [<AllowNullLiteral>] JoinCallOptions =
    abstract videoOptions: VideoOptions option with get, set
    abstract audioOptions: AudioOptions option with get, set

/// Represents a local video stream for a local camera device
type [<AllowNullLiteral>] LocalVideoStream =
    // TODO: 2X OBJ
    /// <summary>Switch to use a different video source</summary>
    /// <param name="source">- The new video source to use.</param>
    abstract switchSource: source: VideoDeviceInfo -> Promise<unit>

/// Represents a local video stream for a local camera device
type [<AllowNullLiteral>] LocalVideoStreamStatic =
    /// Create a local video stream
    [<Emit "new $0($1...)">] abstract Create: source: VideoDeviceInfo -> LocalVideoStream

type [<StringEnum>] [<RequireQualifiedAccess>] MediaStreamType =
    | [<CompiledName "Video">] Video
    | [<CompiledName "ScreenSharing">] ScreenSharing

/// Define constraints for accessing local devices
type [<AllowNullLiteral>] PermissionConstraints =
    abstract audio: bool with get, set
    abstract video: bool with get, set

type [<AllowNullLiteral>] PropertyChangedEvent =
    [<Emit "$0($1...)">] abstract Invoke: unit -> unit

/// Represents a remote participant in a call.
type [<AllowNullLiteral>] RemoteParticipant =
    /// Get the identifier for this remote participant.
    /// Same as the one used to provision token for another user
    abstract identifier: U4<CommunicationUserKind, PhoneNumberKind, MicrosoftTeamsUserKind, UnknownIdentifierKind>
    /// Optional display name, if it was set by the endpoint of
    /// that remote participant
    abstract displayName: string option
    /// Get state of this remote participant.
    abstract state: RemoteParticipantState
    /// Reason why participant left the call, contains code/subCode/message.
    abstract callEndReason: CallEndReason option
    /// Collection of video streams this participants has.
    abstract videoStreams: ReadonlyArray<RemoteVideoStream>
    /// Whether this remote participant is muted or not
    abstract isMuted: bool
    abstract isSpeaking: bool
    /// <summary>Subscribe function for stateChanged event</summary>
    /// <param name="listener">- callback fn that will be called when value of this property will change</param>
    [<Emit "$0.on('stateChanged',$1)">] abstract on_stateChanged: listener: PropertyChangedEvent -> unit
    /// <summary>Subscribe function for isMutedChanged event</summary>
    // / <param name="listener">- callback fn that will be called when value of this property will change</param>
    [<Emit "$0.on('isMutedChanged',$1)">] abstract on_isMutedChanged: PropertyChangedEvent -> unit
    /// <summary>Subscribe function for displayNameChanged event</summary>
    /// <param name="listener">- callback fn that will be called when value of this property will change</param>
    [<Emit "$0.on('displayNameChanged',$1)">] abstract on_displayNameChanged: listener: PropertyChangedEvent -> unit
    /// <summary>Subscribe function for isSpeakingChanged event</summary>
    /// <param name="listener">- callback fn that will be called when value of this property will change</param>
    [<Emit "$0.on('isSpeakingChanged',$1)">] abstract on_isSpeakingChanged: listener: PropertyChangedEvent -> unit
    /// <summary>Subscribe function for videoStreamsUpdated  event</summary>
    // / <param name="listener">- callback fn that will be called when this collection will change,
    // / it will pass arrays of added and removed elements</param>
    [<Emit "$0.on('videoStreamsUpdated',$1)">]
    // abstract member on_videoStreamsUpdated: (CollectionUpdatedEventInvokeArgs<'T> -> unit) -> unit
    abstract member on_videoStreamsUpdated: (CollectionUpdatedEventInvokeArgs<'T> -> unit) -> unit
    /// <summary>Unsubscribe function for stateChanged event</summary>
    /// <param name="listener">- callback fn that was used to subscribe to this event</param>
    [<Emit "$0.off('stateChanged',$1)">] abstract off_stateChanged: listener: PropertyChangedEvent -> unit
    /// <summary>Unsubscribe function for isMutedChanged event</summary>
    /// <param name="listener">- callback fn that was used to subscribe to this event</param>
    [<Emit "$0.off('isMutedChanged',$1)">] abstract off_isMutedChanged: listener: PropertyChangedEvent -> unit
    /// <summary>Unsubscribe function for displayNameChanged event</summary>
    /// <param name="listener">- callback fn that was used to subscribe to this event</param>
    [<Emit "$0.off('displayNameChanged',$1)">] abstract off_displayNameChanged: listener: PropertyChangedEvent -> unit
    /// <summary>Unsubscribe function for isSpeakingChanged event</summary>
    /// <param name="listener">- callback fn that was used to subscribe to this event</param>
    [<Emit "$0.off('isSpeakingChanged',$1)">] abstract off_isSpeakingChanged: listener: PropertyChangedEvent -> unit
    /// <summary>Unsubscribe function for videoStreamsUpdated event</summary>
    /// <param name="listener">- callback fn that was used to subscribe to this event</param>
    [<Emit "$0.off('videoStreamsUpdated',$1)">] abstract off_videoStreamsUpdated: listener: CollectionUpdatedEvent<RemoteVideoStream> -> unit

type [<StringEnum>] [<RequireQualifiedAccess>] RemoteParticipantState =
    | [<CompiledName "Idle">] Idle
    | [<CompiledName "Connecting">] Connecting
    | [<CompiledName "Ringing">] Ringing
    | [<CompiledName "Connected">] Connected
    | [<CompiledName "Hold">] Hold
    | [<CompiledName "InLobby">] InLobby
    | [<CompiledName "EarlyMedia">] EarlyMedia
    | [<CompiledName "Disconnected">] Disconnected

/// Represents a remote participants video or screen-sharing stream
type [<AllowNullLiteral>] RemoteVideoStream =
    /// Id of the remote stream
    abstract id: float
    /// Get this remote media stream type.
    abstract mediaStreamType: MediaStreamType
    /// Whether the stream is available or not.
    abstract isAvailable: bool
    /// <summary>Subscribe function for isAvailableChanged event</summary>
    // / <param name="listener">- callback fn that will be called when value of this property will change</param>
    // [<Emit "$0.on('isAvailableChanged',$1)">] abstract on_isAvailableChanged: listener: PropertyChangedEvent -> unit
    [<Emit "$0.on('isAvailableChanged',$1)">] abstract on_isAvailableChanged:  (CollectionUpdatedEventInvokeArgs<'T>-> unit) -> unit
    /// <summary>Unsubscribe function for isAvailableChanged event</summary>
    /// <param name="listener">- callback fn that was used to subscribe to this event</param>
    [<Emit "$0.off('isAvailableChanged',$1)">] abstract off_isAvailableChanged: listener: PropertyChangedEvent -> unit

type RenderTarget =
    HTMLElement

type [<StringEnum>] [<RequireQualifiedAccess>] ScalingMode =
    | [<CompiledName "Stretch">] Stretch
    | [<CompiledName "Crop">] Crop
    | [<CompiledName "Fit">] Fit

/// Options for starting an outgoing call.
type [<AllowNullLiteral>] StartCallOptions =
    inherit JoinCallOptions
    ///  A phone number in E.164 format that will be used to represent callers identity.
    ///  For example, using the alternateCallerId to add a participant using PSTN, this number will
    ///  be used as the caller id in the PSTN call.
    abstract alternateCallerId: PhoneNumberIdentifier option with get, set

/// Stream size.
type [<AllowNullLiteral>] StreamSize =
    abstract width: float with get, set
    abstract height: float with get, set

/// Information about a camera device
type [<AllowNullLiteral>] VideoDeviceInfo =
    /// Get the name of this video device.
    abstract name: string
    /// Get Id of this video device.
    abstract id: string
    /// Get this video device type
    abstract deviceType: VideoDeviceType

type [<StringEnum>] [<RequireQualifiedAccess>] VideoDeviceType =
    | [<CompiledName "Unknown">] Unknown
    | [<CompiledName "UsbCamera">] UsbCamera
    | [<CompiledName "CaptureAdapter">] CaptureAdapter
    | [<CompiledName "Virtual">] Virtual

/// Represents a local video stream and takes a camera in constructor.
type [<AllowNullLiteral>] VideoOptions =
    abstract localVideoStreams: ResizeArray<LocalVideoStream> option with get, set

/// The renderer for a video stream
type [<AllowNullLiteral>] VideoStreamRenderer =
    /// Dimensions of the renderer
    abstract size: StreamSize
    /// <summary>Create the view for the video stream.</summary>
    /// <param name="options">- Renderer options.</param>
    abstract createView: ?options: CreateViewOptions -> Promise<VideoStreamRendererView>
    /// Dispose of this Renderer
    abstract dispose: unit -> unit

/// The renderer for a video stream
type [<AllowNullLiteral>] VideoStreamRendererStatic =
    // / <summary>Create a Renderer for a local camera preview or remote video stream.
    // / Future APIs:
    // /      getStats(): Promise<RendererStats>; // Helpful in debugging; should be included
    // /      onNextFrame((IFrame) -> void) // to allow app to fetch raw frames - to be implemented later
    // /      captureFrame(timeoutMs: number, bufferName?: string): Promise<IVideoFrame>; // This can come in later
    // /      events/delegates are provided by IRendererEvents
    // / </summary>
    // / <param name="videoStream">- The video stream to render</param>
    // [<Emit "new $0($1...)">] abstract Create: videoStream: U2<LocalVideoStream, RemoteVideoStream> -> VideoStreamRenderer
    [<Emit "new $0($1...)">] abstract CreateLocal: videoStream: LocalVideoStream -> VideoStreamRenderer
    [<Emit "new $0($1...)">] abstract CreateRemote: videoStream: RemoteVideoStream -> VideoStreamRenderer

/// The view for a video stream.
type [<AllowNullLiteral>] VideoStreamRendererView =
    inherit Disposable
    /// The current scale mode for the video.
    abstract scalingMode: ScalingMode
    /// Weather to display the video stream is mirrored.
    abstract isMirrored: bool
    /// The target html element in which the video is rendering on.
    /// Use this property and attach it to any UI html element. Example:
    ///      document.getElement('someDiv').appendChild(rendererView.target);
    // TODO: WAS THIS LINE // abstract target: HTMLElement
    abstract target: obj
    /// <summary>Update the scale mode for this view.</summary>
    /// <param name="scalingMode">- The new scale mode.</param>
    abstract updateScalingMode: scalingMode: ScalingMode -> Promise<unit>
