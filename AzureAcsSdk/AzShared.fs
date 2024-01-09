module AzShared

open AzCalling

type AzureCommunications = {
    CallAgent: CallAgent
    DeviceManager: DeviceManager
}

type PlatformAzureCommunications =
    | CommunicationsWeb of AzureCommunications
    | CommunicationsiOS

type ReceivingCallState = {
    AzCommunication: AzureCommunications
    IncomingCall: IncomingCall
}

type InCallState = {
    AzCommunication: AzureCommunications
    Call: Call
    LocalVideoStream: LocalVideoStream
    LocalVideoStreamRenderer: VideoStreamRenderer
    IsFullscreen: bool
}
