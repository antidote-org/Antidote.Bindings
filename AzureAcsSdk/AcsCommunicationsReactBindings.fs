// ts2fable 0.8.0
module rec AcsCommunicationsReactBindings

#nowarn "3390" // disable warnings for invalid XML comments

open System
open Fable.Core
open Fable.Core.JS
open Browser.Types

[<Erase>] type KeyOf<'T> = Key of string
type Error = System.Exception

// type AudioDeviceInfo = @azure_communication_calling.AudioDeviceInfo
// type Call = @azure_communication_calling.Call
// type CallAgent = @azure_communication_calling.CallAgent
// type CallClient = @azure_communication_calling.CallClient
// type CallClientOptions = @azure_communication_calling.CallClientOptions
// type CallDirection = @azure_communication_calling.CallDirection
// type CallEndReason = @azure_communication_calling.CallEndReason
// type CallerInfo = @azure_communication_calling.CallerInfo
// type CallState_2 = @azure_communication_calling.CallState
// type ChatClient = @azure_communication_chat.ChatClient
// type ChatClientOptions = @azure_communication_chat.ChatClientOptions
// type ChatMessage_2 = @azure_communication_chat.ChatMessage
// type ChatMessageReadReceipt = @azure_communication_chat.ChatMessageReadReceipt
// type ChatParticipant = @azure_communication_chat.ChatParticipant
// type ChatThreadClient = @azure_communication_chat.ChatThreadClient
// type CommunicationIdentifier = @azure_communication_common.CommunicationIdentifier
// type CommunicationIdentifierKind = @azure_communication_common.CommunicationIdentifierKind
// type CommunicationTokenCredential = @azure_communication_common.CommunicationTokenCredential
// type CommunicationUserIdentifier = @azure_communication_common.CommunicationUserIdentifier
// type CommunicationUserKind = @azure_communication_common.CommunicationUserKind
// type ComponentSlotStyle = @fluentui_react_northstar.ComponentSlotStyle
// type CreateViewOptions = @azure_communication_calling.CreateViewOptions
// type DeviceAccess = @azure_communication_calling.DeviceAccess
// type DeviceManager = @azure_communication_calling.DeviceManager
// type DominantSpeakersInfo = @azure_communication_calling.DominantSpeakersInfo
// type GroupCallLocator = @azure_communication_calling.GroupCallLocator
// type IButtonProps = @fluentui_react.IButtonProps
// type IButtonStyles = @fluentui_react.IButtonStyles
// type IContextualMenuItem = @fluentui_react.IContextualMenuItem
// type IContextualMenuItemStyles = @fluentui_react.IContextualMenuItemStyles
// type IContextualMenuStyles = @fluentui_react.IContextualMenuStyles
// type IMessageBarProps = @fluentui_react.IMessageBarProps
// type IPersonaStyleProps = @fluentui_react.IPersonaStyleProps
// type IPersonaStyles = @fluentui_react.IPersonaStyles
// type IRenderFunction = @fluentui_react.IRenderFunction
// type IStyle = @fluentui_react.IStyle
// type IStyleFunctionOrObject = @fluentui_react.IStyleFunctionOrObject
// type LatestMediaDiagnostics = @azure_communication_calling.LatestMediaDiagnostics
// type LatestNetworkDiagnostics = @azure_communication_calling.LatestNetworkDiagnostics
// type MediaStreamType = @azure_communication_calling.MediaStreamType
// type MicrosoftTeamsUserKind = @azure_communication_common.MicrosoftTeamsUserKind
// type PartialTheme = @fluentui_react.PartialTheme
// type PermissionConstraints = @azure_communication_calling.PermissionConstraints
// type PersonaInitialsColor = @fluentui_react.PersonaInitialsColor
// type PersonaPresence = @fluentui_react.PersonaPresence
// type PersonaSize = @fluentui_react.PersonaSize
// type PhoneNumberIdentifier = @azure_communication_common.PhoneNumberIdentifier
// type PhoneNumberKind = @azure_communication_common.PhoneNumberKind
// type React_2 = React.default
// type RemoteParticipantState_2 = @azure_communication_calling.RemoteParticipantState
// type ScalingMode = @azure_communication_calling.ScalingMode
// type SendMessageOptions = @azure_communication_chat.SendMessageOptions
// type StartCallOptions = @azure_communication_calling.StartCallOptions
// type TeamsMeetingLinkLocator = @azure_communication_calling.TeamsMeetingLinkLocator
// type Theme = @fluentui_react.Theme
// type TypingIndicatorReceivedEvent = @azure_communication_chat.TypingIndicatorReceivedEvent
// type UnknownIdentifier = @azure_communication_common.UnknownIdentifier
// type UnknownIdentifierKind = @azure_communication_common.UnknownIdentifierKind
// type VideoDeviceInfo = @azure_communication_calling.VideoDeviceInfo
// type VideoStreamRenderer = @azure_communication_calling.VideoStreamRenderer
// type VideoStreamRendererView = @azure_communication_calling.VideoStreamRendererView
/// <summary>
/// A <see cref="React.Context" /> that stores a <see cref="@azure/communication-calling.CallAgent" />.
///
/// Calling components from this package must be wrapped with a <see cref="CallAgentProvider" />.
/// </summary>
let [<Import("CallAgentProvider","module")>] CallAgentProvider: (CallAgentProviderProps -> JSX.Element) = jsNative
/// <summary>
/// A <see cref="React.Context" /> that stores a <see cref="StatefulCallClient" />.
///
/// Calling components from this package must be wrapped with a <see cref="CallClientProvider" />.
/// </summary>
let [<Import("CallClientProvider","module")>] CallClientProvider: (CallClientProviderProps -> JSX.Element) = jsNative
/// <summary>A customizable UI composite for calling experience.</summary>
/// <remarks>
/// Call composite min width/height are as follow:
/// - mobile: 17.5rem x 21rem (280px x 336px, with default rem at 16px)
/// - desktop: 30rem x 22rem (480px x 352px, with default rem at 16px)
/// </remarks>
let [<Import("CallComposite","module")>] CallComposite: (CallCompositeProps -> JSX.Element) = jsNative
/// <summary>
/// A <see cref="React.Context" /> that stores a <see cref="@azure/communication-calling.Call" />.
///
/// Calling components from this package must be wrapped with a <see cref="CallProvider" />.
/// </summary>
let [<Import("CallProvider","module")>] CallProvider: (CallProviderProps -> JSX.Element) = jsNative
/// <summary>CallWithChatComposite brings together key components to provide a full call with chat experience out of the box.</summary>
let [<Import("CallWithChatComposite","module")>] CallWithChatComposite: (CallWithChatCompositeProps -> JSX.Element) = jsNative
/// <summary>
/// A button to turn camera on / off.
///
/// Can be used with <see cref="ControlBar" />.
/// </summary>
let [<Import("CameraButton","module")>] CameraButton: (CameraButtonProps -> JSX.Element) = jsNative
/// <summary>
/// A <see cref="React.Context" /> that stores a <see cref="StatefulChatClient" />.
///
/// Chat components from this package must be wrapped with a <see cref="ChatClientProvider" />.
/// </summary>
let [<Import("ChatClientProvider","module")>] ChatClientProvider: (ChatClientProviderProps -> JSX.Element) = jsNative
/// <summary>A customizable UI composite for the chat experience.</summary>
/// <remarks>Chat composite min width and height are respectively 17.5rem and 20rem (280px and 320px, with default rem at 16px)</remarks>
let [<Import("ChatComposite","module")>] ChatComposite: (ChatCompositeProps -> JSX.Element) = jsNative
/// <summary>
/// A <see cref="React.Context" /> that stores a <see cref="@azure/communication-chat.ChatThreadClient" />.
///
/// Chat components from this package must be wrapped with a <see cref="ChatThreadClientProvider" />.
/// </summary>
let [<Import("ChatThreadClientProvider","module")>] ChatThreadClientProvider: (ChatThreadClientProviderProps -> JSX.Element) = jsNative
/// <summary>Locale for  German (Germany).</summary>
let [<Import("COMPONENT_LOCALE_DE_DE","module")>] COMPONENT_LOCALE_DE_DE: ComponentLocale = jsNative
/// <summary>Locale for English (GB).</summary>
let [<Import("COMPONENT_LOCALE_EN_GB","module")>] COMPONENT_LOCALE_EN_GB: ComponentLocale = jsNative
/// <summary>Locale for English (US).</summary>
let [<Import("COMPONENT_LOCALE_EN_US","module")>] COMPONENT_LOCALE_EN_US: ComponentLocale = jsNative
/// <summary>Locale for Spanish (Spain).</summary>
let [<Import("COMPONENT_LOCALE_ES_ES","module")>] COMPONENT_LOCALE_ES_ES: ComponentLocale = jsNative
/// <summary>Locale for French (France).</summary>
let [<Import("COMPONENT_LOCALE_FR_FR","module")>] COMPONENT_LOCALE_FR_FR: ComponentLocale = jsNative
/// <summary>Locale for Italian (Italy).</summary>
let [<Import("COMPONENT_LOCALE_IT_IT","module")>] COMPONENT_LOCALE_IT_IT: ComponentLocale = jsNative
/// <summary>Locale for Japanese (Japan).</summary>
let [<Import("COMPONENT_LOCALE_JA_JP","module")>] COMPONENT_LOCALE_JA_JP: ComponentLocale = jsNative
/// <summary>Locale for Korean (South Korea).</summary>
let [<Import("COMPONENT_LOCALE_KO_KR","module")>] COMPONENT_LOCALE_KO_KR: ComponentLocale = jsNative
/// <summary>Locale for Dutch (Netherlands).</summary>
let [<Import("COMPONENT_LOCALE_NL_NL","module")>] COMPONENT_LOCALE_NL_NL: ComponentLocale = jsNative
/// <summary>Locale for Portuguese (Brazil).</summary>
let [<Import("COMPONENT_LOCALE_PT_BR","module")>] COMPONENT_LOCALE_PT_BR: ComponentLocale = jsNative
/// <summary>Locale for Russian (Russia).</summary>
let [<Import("COMPONENT_LOCALE_RU_RU","module")>] COMPONENT_LOCALE_RU_RU: ComponentLocale = jsNative
/// <summary>Locale for Turkish (Turkey).</summary>
let [<Import("COMPONENT_LOCALE_TR_TR","module")>] COMPONENT_LOCALE_TR_TR: ComponentLocale = jsNative
/// <summary>Locale for Chinese (Mainland China).</summary>
let [<Import("COMPONENT_LOCALE_ZH_CN","module")>] COMPONENT_LOCALE_ZH_CN: ComponentLocale = jsNative
/// <summary>Locale for Chinese (Taiwan).</summary>
let [<Import("COMPONENT_LOCALE_ZH_TW","module")>] COMPONENT_LOCALE_ZH_TW: ComponentLocale = jsNative
/// <summary>Locale for German (Germany)</summary>
let [<Import("COMPOSITE_LOCALE_DE_DE","module")>] COMPOSITE_LOCALE_DE_DE: CompositeLocale = jsNative
/// <summary>Locale for English (British)</summary>
let [<Import("COMPOSITE_LOCALE_EN_GB","module")>] COMPOSITE_LOCALE_EN_GB: CompositeLocale = jsNative
/// <summary>Locale for English (US)</summary>
let [<Import("COMPOSITE_LOCALE_EN_US","module")>] COMPOSITE_LOCALE_EN_US: CompositeLocale = jsNative
/// <summary>Locale for Spanish (Spain)</summary>
let [<Import("COMPOSITE_LOCALE_ES_ES","module")>] COMPOSITE_LOCALE_ES_ES: CompositeLocale = jsNative
/// <summary>Locale for French (France)</summary>
let [<Import("COMPOSITE_LOCALE_FR_FR","module")>] COMPOSITE_LOCALE_FR_FR: CompositeLocale = jsNative
/// <summary>Locale for Italian (Italy)</summary>
let [<Import("COMPOSITE_LOCALE_IT_IT","module")>] COMPOSITE_LOCALE_IT_IT: CompositeLocale = jsNative
/// <summary>Locale for Japanese (Japan)</summary>
let [<Import("COMPOSITE_LOCALE_JA_JP","module")>] COMPOSITE_LOCALE_JA_JP: CompositeLocale = jsNative
/// <summary>Locale for Korean (South Korea)</summary>
let [<Import("COMPOSITE_LOCALE_KO_KR","module")>] COMPOSITE_LOCALE_KO_KR: CompositeLocale = jsNative
/// <summary>Locale for Dutch (Netherlands)</summary>
let [<Import("COMPOSITE_LOCALE_NL_NL","module")>] COMPOSITE_LOCALE_NL_NL: CompositeLocale = jsNative
/// <summary>Locale for Portuguese (Brazil)</summary>
let [<Import("COMPOSITE_LOCALE_PT_BR","module")>] COMPOSITE_LOCALE_PT_BR: CompositeLocale = jsNative
/// <summary>Locale for Russian (Russia)</summary>
let [<Import("COMPOSITE_LOCALE_RU_RU","module")>] COMPOSITE_LOCALE_RU_RU: CompositeLocale = jsNative
/// <summary>Locale for Turkish (Turkey)</summary>
let [<Import("COMPOSITE_LOCALE_TR_TR","module")>] COMPOSITE_LOCALE_TR_TR: CompositeLocale = jsNative
/// <summary>Locale for Chinese (Mainland China)</summary>
let [<Import("COMPOSITE_LOCALE_ZH_CN","module")>] COMPOSITE_LOCALE_ZH_CN: CompositeLocale = jsNative
/// <summary>Locale for Chinese (Taiwan)</summary>
let [<Import("COMPOSITE_LOCALE_ZH_TW","module")>] COMPOSITE_LOCALE_ZH_TW: CompositeLocale = jsNative
/// <summary>The default set of icons used by the composites directly (i.e. not via the components defined in this library).</summary>
let [<Import("COMPOSITE_ONLY_ICONS","module")>] COMPOSITE_ONLY_ICONS: CompositeIcons = jsNative
/// <summary>
/// A container for various buttons for call controls.
///
/// Use with various call control buttons in this library, e.g., <see cref="CameraButton" />, or your own instances of
/// <see cref="ControlBarButton" /> directly.
/// </summary>
let [<Import("ControlBar","module")>] ControlBar: (ControlBarProps -> JSX.Element) = jsNative
/// <summary>
/// Default button styled for the <see cref="ControlBar" />.
///
/// Use this component create custom buttons that are styled the same as other buttons provided by the UI Library.
/// </summary>
let [<Import("ControlBarButton","module")>] ControlBarButton: (ControlBarButtonProps -> JSX.Element) = jsNative
/// <summary>
/// Create a <see cref="CallAdapter" /> backed by Azure Communication Services.
///
/// This is the default implementation of <see cref="CallAdapter" /> provided by this library.
///
/// Note: <c>displayName</c> can be a maximum of 256 characters.
/// </summary>
let [<Import("createAzureCommunicationCallAdapter","module")>] createAzureCommunicationCallAdapter: (AzureCommunicationCallAdapterArgs -> Promise<CallAdapter>) = jsNative
/// <summary>
/// Create a <see cref="CallAdapter" /> using the provided <see cref="StatefulCallClient" />.
///
/// Useful if you want to keep a reference to <see cref="StatefulCallClient" />.
/// Consider using <see cref="createAzureCommunicationCallAdapter" /> for a simpler API.
/// </summary>
let [<Import("createAzureCommunicationCallAdapterFromClient","module")>] createAzureCommunicationCallAdapterFromClient: (StatefulCallClient -> CallAgent -> CallAdapterLocator -> Promise<CallAdapter>) = jsNative
/// <summary>
/// Create a CallWithChatAdapter backed by Azure Communication services
/// to plug into the <see cref="CallWithChatComposite" />.
/// </summary>
let [<Import("createAzureCommunicationCallWithChatAdapter","module")>] createAzureCommunicationCallWithChatAdapter: (AzureCommunicationCallWithChatAdapterArgs -> Promise<CallWithChatAdapter>) = jsNative
/// <summary>
/// Create a <see cref="CallWithChatAdapter" /> using the provided <see cref="StatefulChatClient" /> and <see cref="StatefulCallClient" />.
///
/// Useful if you want to keep a reference to <see cref="StatefulChatClient" /> and <see cref="StatefulCallClient" />.
/// Consider using <see cref="createAzureCommunicationCallWithChatAdapter" /> for a simpler API.
/// </summary>
let [<Import("createAzureCommunicationCallWithChatAdapterFromClients","module")>] createAzureCommunicationCallWithChatAdapterFromClients: (AzureCommunicationCallWithChatAdapterFromClientArgs -> Promise<CallWithChatAdapter>) = jsNative
/// <summary>
/// Create a <see cref="ChatAdapter" /> backed by Azure Communication Services.
///
/// This is the default implementation of <see cref="ChatAdapter" /> provided by this library.
/// </summary>
let [<Import("createAzureCommunicationChatAdapter","module")>] createAzureCommunicationChatAdapter: (AzureCommunicationChatAdapterArgs -> Promise<ChatAdapter>) = jsNative
/// <summary>
/// Create a <see cref="ChatAdapter" /> using the provided <see cref="StatefulChatClient" />.
///
/// Useful if you want to keep a reference to <see cref="StatefulChatClient" />.
/// Consider using <see cref="createAzureCommunicationChatAdapter" /> for a simpler API.
/// </summary>
let [<Import("createAzureCommunicationChatAdapterFromClient","module")>] createAzureCommunicationChatAdapterFromClient: (StatefulChatClient -> ChatThreadClient -> Promise<ChatAdapter>) = jsNative
/// <summary>
/// Create the default implementation of <see cref="CallingHandlers" />.
///
/// Useful when implementing a custom component that utilizes the providers
/// exported from this library.
/// </summary>
let [<Import("createDefaultCallingHandlers","module")>] createDefaultCallingHandlers: (StatefulCallClient -> CallAgent option -> StatefulDeviceManager option -> Call option -> CallingHandlers) = jsNative
/// <summary>
/// Create the default implementation of <see cref="ChatHandlers" />.
///
/// Useful when implementing a custom component that utilizes the providers
/// exported from this library.
///
/// Returned object is memoized to avoid rerenders when used as props for React Components.
/// </summary>
let [<Import("createDefaultChatHandlers","module")>] createDefaultChatHandlers: (StatefulChatClient -> ChatThreadClient -> ChatHandlers) = jsNative
/// <summary>
/// Creates a StatefulCallClient <see cref="StatefulCallClient" /> by proxying CallClient
/// <see cref="@azure/communication-calling.CallClient" /> with ProxyCallClient <see cref="ProxyCallClient" /> which then allows access
/// to state in a declarative way.
///
/// It is important to use the <see cref="@azure/communication-calling.DeviceManager" /> and
/// <see cref="@azure/communication-calling.CallAgent" /> and <see cref="@azure/communication-calling.Call" /> (and etc.) that are
/// obtained from the StatefulCallClient in order for their state changes to be proxied properly.
/// </summary>
/// <param name="args"><see cref="StatefulCallClientArgs" /></param>
/// <param name="options"><see cref="StatefulCallClientOptions" /></param>
let [<Import("createStatefulCallClient","module")>] createStatefulCallClient: (StatefulCallClientArgs -> (StatefulCallClientOptions) option -> StatefulCallClient) = jsNative
/// <summary>
/// Creates a stateful ChatClient <see cref="StatefulChatClient" /> by proxying ChatClient
/// <see cref="@azure/communication-chat.ChatClient" /> with ProxyChatClient <see cref="ProxyChatClient" /> which then allows access
/// to state in a declarative way.
/// </summary>
let [<Import("createStatefulChatClient","module")>] createStatefulChatClient: (StatefulChatClientArgs -> (StatefulChatClientOptions) option -> StatefulChatClient) = jsNative
/// <summary>Preset dark theme for components exported from this library.</summary>
let [<Import("darkTheme","module")>] darkTheme: obj = jsNative
/// <summary>The default set of icons that are available to use in the UI components.</summary>
/// <remarks>Icons used only in the composites are available in <see cref="DEFAULT_COMPOSITE_ICONS" />.</remarks>
let [<Import("DEFAULT_COMPONENT_ICONS","module")>] DEFAULT_COMPONENT_ICONS: DEFAULT_COMPONENT_ICONS = jsNative
/// <summary>The default set of icons that are available to used in the Composites.</summary>
let [<Import("DEFAULT_COMPOSITE_ICONS","module")>] DEFAULT_COMPOSITE_ICONS: DEFAULT_COMPOSITE_ICONS = jsNative
/// <summary>
/// A button to open a menu that controls device options.
///
/// Can be used with <see cref="ControlBar" />.
/// </summary>
let [<Import("DevicesButton","module")>] DevicesButton: (DevicesButtonProps -> JSX.Element) = jsNative
/// <summary>
/// A button to end an ongoing call.
///
/// Can be used with <see cref="ControlBar" />.
/// </summary>
let [<Import("EndCallButton","module")>] EndCallButton: (EndCallButtonProps -> JSX.Element) = jsNative
/// <summary>
/// A component to show error messages on the UI.
/// All strings that can be shown are accepted as the <see cref="ErrorBarProps.strings" /> so that they can be localized.
/// Active errors are selected by <see cref="ErrorBarProps.activeErrorMessages" />.
///
/// This component internally tracks dismissed by the user.
///    * Errors that have an associated timestamp: The error is shown on the UI again if it occurs after being dismissed.
///    * Errors that do not have a timestamp: The error is dismissed until it disappears from the props.
///          If the error recurs, it is shown in the UI.
///
/// Uses <see cref="@fluentui/react.MessageBar" /> UI element.
/// </summary>
let [<Import("ErrorBar","module")>] ErrorBar: (ErrorBarProps -> JSX.Element) = jsNative
/// <summary>Provider to apply a Fluent theme across this library's react components.</summary>
/// <remarks>
/// Components in this library are composed primarily from <see href="https://developer.microsoft.com/fluentui#/controls/web">Fluent UI</see>,
/// controls, and also from <see href="https://fluentsite.z22.web.core.windows.net/0.53.0">Fluent React Northstar</see> controls.
/// This provider handles applying any theme provided to both the underlying Fluent UI controls, as well as the Fluent React Northstar controls.
/// </remarks>
let [<Import("FluentThemeProvider","module")>] FluentThemeProvider: (FluentThemeProviderProps -> JSX.Element) = jsNative
/// <summary>Reverse operation of <see cref="toFlatCommunicationIdentifier" />.</summary>
let [<Import("fromFlatCommunicationIdentifier","module")>] fromFlatCommunicationIdentifier: (string -> CommunicationIdentifier) = jsNative
/// <summary>
/// Get the selector for a specified component.
///
/// Useful when implementing a custom component that utilizes the providers
/// exported from this library.
/// </summary>
let [<Import("getCallingSelector","module")>] getCallingSelector: ('Component -> GetCallingSelector<'Component>) = jsNative
/// <summary>
/// Get the selector for a specified component.
///
/// Useful when implementing a custom component that utilizes the providers
/// exported from this library.
/// </summary>
let [<Import("getChatSelector","module")>] getChatSelector: ('Component -> GetChatSelector<'Component>) = jsNative
/// <summary>A component to lay out audio / video participants tiles in a call.</summary>
let [<Import("GridLayout","module")>] GridLayout: (GridLayoutProps -> JSX.Element) = jsNative
/// <summary>React Context provider for <see cref="_Identifiers" />.</summary>
let [<Import("_IdentifierProvider","module")>] _IdentifierProvider: (_IdentifierProviderProps -> JSX.Element) = jsNative
/// <summary>Preset light theme for components exported from this library.</summary>
let [<Import("lightTheme","module")>] lightTheme: obj = jsNative
/// <summary>Provider to provide localized strings for this library's react components.</summary>
/// <remarks>
/// Components will be provided localized strings in English (US) by default if this
/// provider is not used.
/// </remarks>
let [<Import("LocalizationProvider","module")>] LocalizationProvider: (LocalizationProviderProps -> JSX.Element) = jsNative
/// <summary>
/// Component to display the status of a sent message.
///
/// Adds an icon and tooltip corresponding to the message status.
/// </summary>
let [<Import("MessageStatusIndicator","module")>] MessageStatusIndicator: (MessageStatusIndicatorProps -> JSX.Element) = jsNative
/// <summary><c>MessageThread</c> allows you to easily create a component for rendering chat messages, handling scrolling behavior of new/old messages and customizing icons &amp; controls inside the chat thread.</summary>
/// <param name="props">
/// of type MessageThreadProps
///
/// Users will need to provide at least chat messages and userId to render the <c>MessageThread</c> component.
/// Users can also customize <c>MessageThread</c> by passing in their own Avatar, <c>MessageStatusIndicator</c> icon, <c>JumpToNewMessageButton</c>, <c>LoadPreviousMessagesButton</c> and the behavior of these controls.
///
/// <c>MessageThread</c> internally uses the <c>Chat</c> &amp; <c>Chat.Message</c> component from <c>@fluentui/react-northstar</c>. You can checkout the details about these <see href="https://fluentsite.z22.web.core.windows.net/0.53.0/components/chat/props">two components</see>.
/// </param>
let [<Import("MessageThread","module")>] MessageThread: (MessageThreadProps -> JSX.Element) = jsNative
/// <summary>
/// A button to turn microphone on / off.
///
/// Can be used with <see cref="ControlBar" />.
/// </summary>
let [<Import("MicrophoneButton","module")>] MicrophoneButton: (MicrophoneButtonProps -> JSX.Element) = jsNative
/// <summary>
/// Component to render a calling or chat participant.
///
/// Displays the participant's avatar, displayName and status as well as optional icons and context menu.
/// </summary>
let [<Import("ParticipantItem","module")>] ParticipantItem: (ParticipantItemProps -> JSX.Element) = jsNative
/// <summary>
/// Component to render all calling or chat participants.
///
/// By default, each participant is rendered with <see cref="ParticipantItem" />. See <see cref="ParticipantListProps.onRenderParticipant" /> to override.
/// </summary>
let [<Import("ParticipantList","module")>] ParticipantList: (ParticipantListProps -> JSX.Element) = jsNative
/// <summary>
/// A button to show a menu with calling or chat participants.
///
/// Can be used with <see cref="ControlBar" />.
///
/// This button contains dropdown menu items defined through its property <c>menuProps</c>. By default, it can display the number of remote participants with the full list
/// as sub-menu and an option to mute all participants, as well as a copy-to-clipboard button to copy the call invitation URL.
/// This <c>menuProps</c> can be fully redefined and its property is of type <see href="https://developer.microsoft.com/fluentui#/controls/web/contextualmenu#IContextualMenuProps">IContextualMenuProps</see>.
/// </summary>
let [<Import("ParticipantsButton","module")>] ParticipantsButton: (ParticipantsButtonProps -> JSX.Element) = jsNative
/// <summary>
/// A button to start / stop screen sharing.
///
/// Can be used with <see cref="ControlBar" />.
/// </summary>
let [<Import("ScreenShareButton","module")>] ScreenShareButton: (ScreenShareButtonProps -> JSX.Element) = jsNative
/// <summary>
/// Component for typing and sending messages.
///
/// Supports sending typing notification when user starts entering text.
/// Supports an optional message below the text input field.
/// </summary>
let [<Import("SendBox","module")>] SendBox: (SendBoxProps -> JSX.Element) = jsNative
/// <summary>
/// Utility component to convert an HTMLElement with a video stream into a JSX element.
///
/// Use to convert an HTMLElement returned by headless calling API into a component that can be rendered as a <see cref="VideoTile" />.
/// </summary>
let [<Import("StreamMedia","module")>] StreamMedia: (StreamMediaProps -> JSX.Element) = jsNative
/// <summary>
/// A string representation of a <see cref="@azure/communication-common.CommunicationIdentifier" />.
///
/// This string representation of CommunicationIdentifier is guaranteed to be stable for
/// a unique Communication user. Thus,
/// - it can be used to persist a user's identity in external databases.
/// - it can be used as keys into a Map to store data for the user.
/// </summary>
let [<Import("toFlatCommunicationIdentifier","module")>] toFlatCommunicationIdentifier: (CommunicationIdentifier -> string) = jsNative
/// <summary>Component to notify local user when one or more participants in the chat thread are typing.</summary>
let [<Import("TypingIndicator","module")>] TypingIndicator: (TypingIndicatorProps -> JSX.Element) = jsNative
/// <summary>
/// A custom React hook to simplify the creation of <see cref="CallAdapter" />.
///
/// Similar to <see cref="createAzureCommunicationCallAdapter" />, but takes care of asynchronous
/// creation of the adapter internally.
///
/// Allows arguments to be undefined so that you can respect the rule-of-hooks and pass in arguments
/// as they are created. The adapter is only created when all arguments are defined.
///
/// Note that you must memoize the arguments to avoid recreating adapter on each render.
/// See storybook for typical usage examples.
/// </summary>
let [<Import("useAzureCommunicationCallAdapter","module")>] useAzureCommunicationCallAdapter: (obj -> ((CallAdapter -> Promise<CallAdapter>)) option -> ((CallAdapter -> Promise<unit>)) option -> CallAdapter option) = jsNative
/// <summary>
/// A custom React hook to simplify the creation of <see cref="CallWithChatAdapter" />.
///
/// Similar to <see cref="createAzureCommunicationCallWithChatAdapter" />, but takes care of asynchronous
/// creation of the adapter internally.
///
/// Allows arguments to be undefined so that you can respect the rule-of-hooks and pass in arguments
/// as they are created. The adapter is only created when all arguments are defined.
///
/// Note that you must memoize the arguments to avoid recreating adapter on each render.
/// See storybook for typical usage examples.
/// </summary>
let [<Import("useAzureCommunicationCallWithChatAdapter","module")>] useAzureCommunicationCallWithChatAdapter: (obj -> ((CallWithChatAdapter -> Promise<CallWithChatAdapter>)) option -> ((CallWithChatAdapter -> Promise<unit>)) option -> CallWithChatAdapter option) = jsNative
/// <summary>
/// A custom React hook to simplify the creation of <see cref="ChatAdapter" />.
///
/// Similar to <see cref="createAzureCommunicationChatAdapter" />, but takes care of asynchronous
/// creation of the adapter internally.
///
/// Allows arguments to be undefined so that you can respect the rule-of-hooks and pass in arguments
/// as they are created. The adapter is only created when all arguments are defined.
///
/// Note that you must memoize the arguments to avoid recreating adapter on each render.
/// See storybook for typical usage examples.
/// </summary>
let [<Import("useAzureCommunicationChatAdapter","module")>] useAzureCommunicationChatAdapter: (obj -> ((ChatAdapter -> Promise<ChatAdapter>)) option -> ((ChatAdapter -> Promise<unit>)) option -> ChatAdapter option) = jsNative
/// <summary>
/// Hook to obtain <see cref="@azure/communication-calling.Call" /> from the provider.
///
/// Useful when implementing a custom component that utilizes the providers
/// exported from this library.
/// </summary>
let [<Import("useCall","module")>] useCall: (unit -> Call option) = jsNative
/// <summary>
/// Hook to obtain <see cref="@azure/communication-calling.CallAgent" /> from the provider.
///
/// Useful when implementing a custom component that utilizes the providers
/// exported from this library.
/// </summary>
let [<Import("useCallAgent","module")>] useCallAgent: (unit -> CallAgent option) = jsNative
/// <summary>
/// Hook to obtain <see cref="StatefulCallClient" /> from the provider.
///
/// Useful when implementing a custom component that utilizes the providers
/// exported from this library.
/// </summary>
let [<Import("useCallClient","module")>] useCallClient: (unit -> StatefulCallClient) = jsNative
/// <summary>
/// Hook to obtain <see cref="StatefulChatClient" /> from the provider.
///
/// Useful when implementing a custom component that utilizes the providers
/// exported from this library.
/// </summary>
let [<Import("useChatClient","module")>] useChatClient: (unit -> StatefulChatClient) = jsNative
/// <summary>
/// Hook to obtain <see cref="@azure/communication-chat.ChatThreadClient" /> from the provider.
///
/// Useful when implementing a custom component that utilizes the providers
/// exported from this library.
/// </summary>
let [<Import("useChatThreadClient","module")>] useChatThreadClient: (unit -> ChatThreadClient) = jsNative
/// <summary>
/// Hook to obtain <see cref="StatefulDeviceManager" /> from the provider.
///
/// Useful when implementing a custom component that utilizes the providers
/// exported from this library.
/// </summary>
let [<Import("useDeviceManager","module")>] useDeviceManager: (unit -> StatefulDeviceManager option) = jsNative
/// <summary>
/// Primary hook to get all hooks necessary for a React Component from this library..
///
/// Most straightforward usage of a components looks like:
/// </summary>
/// <example>
/// <code>
///     import { ParticipantList, usePropsFor } from '
/// </code>
/// </example>
let [<Import("usePropsFor","module")>] usePropsFor: ('Component -> (UsePropsFor) option -> ComponentProps<'Component>) = jsNative
/// <summary>
/// Hook to obtain a selector for a specified component.
///
/// Useful when implementing a custom component that utilizes the providers
/// exported from this library.
/// </summary>
let [<Import("useSelector","module")>] useSelector: ('ParamT -> (obj) option -> (UsePropsFor) option -> obj) = jsNative
/// <summary>React hook to access theme</summary>
let [<Import("useTheme","module")>] useTheme: (unit -> Theme) = jsNative
/// <summary>
/// VideoGallery represents a layout of video tiles for a specific call.
/// It displays a <see cref="VideoTile" /> for the local user as well as for each remote participant who has joined the call.
/// </summary>
let [<Import("VideoGallery","module")>] VideoGallery: (VideoGalleryProps -> JSX.Element) = jsNative
/// <summary>
/// A component to render the video stream for a single call participant.
///
/// Use with <see cref="GridLayout" /> in a <see cref="VideoGallery" />.
/// </summary>
let [<Import("VideoTile","module")>] VideoTile: (VideoTileProps -> JSX.Element) = jsNative

type [<AllowNullLiteral>] IExports =
    /// <summary>Error thrown from failed stateful API methods.</summary>
    abstract CallError: CallErrorStatic
    /// <summary>Error thrown from failed <see cref="StatefulChatClient" /> methods.</summary>
    abstract ChatError: ChatErrorStatic

/// <summary>Active error messages to be shown via <see cref="ErrorBar" />.</summary>
type [<AllowNullLiteral>] ActiveErrorMessage =
    /// Type of error that is active.
    abstract ``type``: ErrorType with get, set
    /// The latest timestamp when this error was observed.
    ///
    /// When available, this is used to track errors that have already been seen and dismissed
    /// by the user.
    abstract timestamp: DateTime option with get, set

/// <summary>Error reported via error events and stored in adapter state.</summary>
type [<AllowNullLiteral>] AdapterError =
    inherit Error
    /// The operation that failed.
    abstract target: string with get, set
    /// Error thrown by the failed operation.
    abstract innerError: Error with get, set
    /// Timestamp added to the error in the adapter implementation.
    abstract timestamp: DateTime with get, set

/// <summary>
/// Adapters stores the latest error for each operation in the state.
///
/// <c>target</c> is an adapter defined string for each unique operation performed by the adapter.
/// </summary>
type [<AllowNullLiteral>] AdapterErrors =
    [<EmitIndexer>] abstract Item: target: string -> AdapterError with get, set

/// <summary>Functionality for interfacing with Composite adapter state.</summary>
type [<AllowNullLiteral>] AdapterState<'TState> =
    /// Subscribes the handler to stateChanged events.
    abstract onStateChange: handler: ('TState -> unit) -> unit
    /// Unsubscribes the handler to stateChanged events.
    abstract offStateChange: handler: ('TState -> unit) -> unit
    /// Get the current State
    abstract getState: unit -> 'TState

/// <summary>Compare if 2 react components are exact equal, result type will be true/false</summary>
type AreEqual<'A, 'B> =
    obj

/// <summary>Compare if props of 2 react components are equal, result type will be true/false</summary>
type AreParamEqual<'A, 'B> =
    AreTypeEqual<Required<obj>, Required<obj>>

/// <summary>Compare if two types are equal, result type will be true/false</summary>
type AreTypeEqual<'A, 'B> =
    obj

/// <summary>Custom data attributes for displaying avatar for a user.</summary>
type [<AllowNullLiteral>] AvatarPersonaData =
    /// Primary text to display, usually the name of the person.
    abstract text: string option with get, set
    /// Image URL to use, should be a square aspect ratio and big enough to fit in the image area.
    abstract imageUrl: string option with get, set
    /// <summary>The user's initials to display in the image area when there is no image.</summary>
    /// <default>Derived from <c>text</c></default>
    abstract imageInitials: string option with get, set
    /// <summary>The background color when the user's initials are displayed.</summary>
    /// <default>Derived from <c>text</c></default>
    abstract initialsColor: U2<PersonaInitialsColor, string> option with get, set
    /// <summary>The text color when the user's initials are displayed</summary>
    /// <default><c>white</c></default>
    abstract initialsTextColor: string option with get, set

/// <summary>Callback function used to provide custom data to build an avatar for a user.</summary>
type [<AllowNullLiteral>] AvatarPersonaDataCallback =
    /// <summary>Callback function used to provide custom data to build an avatar for a user.</summary>
    [<Emit("$0($1...)")>] abstract Invoke: userId: string -> Promise<AvatarPersonaData>

/// <summary>
/// Arguments for creating the Azure Communication Services implementation of <see cref="CallAdapter" />.
///
/// Note: <c>displayName</c> can be a maximum of 256 characters.
/// </summary>
type [<AllowNullLiteral>] AzureCommunicationCallAdapterArgs =
    abstract userId: CommunicationUserIdentifier with get, set
    abstract displayName: string with get, set
    abstract credential: CommunicationTokenCredential with get, set
    abstract locator: CallAdapterLocator with get, set

/// <summary>Arguments for <see cref="createAzureCommunicationCallWithChatAdapter" /></summary>
type [<AllowNullLiteral>] AzureCommunicationCallWithChatAdapterArgs =
    abstract endpoint: string with get, set
    abstract userId: CommunicationUserIdentifier with get, set
    abstract displayName: string with get, set
    abstract credential: CommunicationTokenCredential with get, set
    abstract locator: U2<CallAndChatLocator, TeamsMeetingLinkLocator> with get, set

/// <summary>Arguments for <see cref="createAzureCommunicationCallWithChatAdapterFromClient" /></summary>
type [<AllowNullLiteral>] AzureCommunicationCallWithChatAdapterFromClientArgs =
    abstract callLocator: U2<CallAdapterLocator, TeamsMeetingLinkLocator> with get, set
    abstract callAgent: CallAgent with get, set
    abstract callClient: StatefulCallClient with get, set
    abstract chatClient: StatefulChatClient with get, set
    abstract chatThreadClient: ChatThreadClient with get, set

/// <summary>Arguments for creating the Azure Communication Services implementation of <see cref="ChatAdapter" />.</summary>
type [<AllowNullLiteral>] AzureCommunicationChatAdapterArgs =
    abstract endpoint: string with get, set
    abstract userId: CommunicationUserIdentifier with get, set
    abstract displayName: string with get, set
    abstract credential: CommunicationTokenCredential with get, set
    abstract threadId: string with get, set

/// <summary>Properties common to all composites exported from this library.</summary>
type [<AllowNullLiteral>] BaseCompositeProps<'TIcons when 'TIcons :> Record<string, JSX.Element>> =
    /// <summary>Fluent theme for the composite.</summary>
    /// <default>light theme</default>
    abstract fluentTheme: U2<PartialTheme, Theme> option with get, set
    /// Custom Icon override for the composite.
    /// A JSX element can be provided to override the default icon.
    abstract icons: 'TIcons option with get, set
    /// <summary>Locale for the composite.</summary>
    /// <default>English (US)</default>
    abstract locale: CompositeLocale option with get, set
    /// <summary>Whether composite is displayed right-to-left.</summary>
    /// <default>false</default>
    abstract rtl: bool option with get, set
    /// A callback function that can be used to provide custom data to Avatars rendered
    /// in Composite.
    abstract onFetchAvatarPersonaData: AvatarPersonaDataCallback option with get, set
    /// A callback function that can be used to provide custom menu items for a participant in
    /// participant list.
    abstract onFetchParticipantMenuItems: ParticipantMenuItemsCallback option with get, set

/// <summary>Basic fluent styles props for all components exported from this libray.</summary>
type [<AllowNullLiteral>] BaseCustomStyles =
    /// Styles for the root container.
    abstract root: IStyle option with get, set

/// <summary><see cref="CallComposite" /> Adapter interface.</summary>
type [<AllowNullLiteral>] CallAdapter =
    inherit AdapterState<CallAdapterState>
    inherit Disposable
    inherit CallAdapterCallManagement
    inherit CallAdapterDeviceManagement
    inherit CallAdapterSubscribers

/// <summary>Functionality for managing the current call.</summary>
type [<AllowNullLiteral>] CallAdapterCallManagement =
    /// <summary>Join the call with microphone initially on/off.</summary>
    /// <param name="microphoneOn">Whether microphone is initially enabled</param>
    abstract joinCall: ?microphoneOn: bool -> Call option
    /// <summary>Leave the call</summary>
    /// <param name="forEveryone">Whether to remove all participants when leaving</param>
    abstract leaveCall: ?forEveryone: bool -> Promise<unit>
    /// <summary>
    /// Start the camera
    /// This method will start rendering a local camera view when the call is not active
    /// </summary>
    /// <param name="options">Options to control how video streams are rendered {@link</param>
    abstract startCamera: ?options: VideoStreamOptions -> Promise<unit>
    /// <summary>
    /// Stop the camera
    /// This method will stop rendering a local camera view when the call is not active
    /// </summary>
    abstract stopCamera: unit -> Promise<unit>
    /// <summary>Mute the current user during the call or disable microphone locally</summary>
    abstract mute: unit -> Promise<unit>
    /// <summary>Unmute the current user during the call or enable microphone locally</summary>
    abstract unmute: unit -> Promise<unit>
    /// <summary>Start the call.</summary>
    /// <param name="participants">An array of participant ids to join</param>
    abstract startCall: participants: ResizeArray<string> -> Call option
    /// <summary>Start sharing the screen during a call.</summary>
    abstract startScreenShare: unit -> Promise<unit>
    /// <summary>Stop sharing the screen</summary>
    abstract stopScreenShare: unit -> Promise<unit>
    /// <summary>Remove a participant from the call.</summary>
    /// <param name="userId">Id of the participant to be removed</param>
    abstract removeParticipant: userId: string -> Promise<unit>
    /// <summary>Create the html view for a stream.</summary>
    /// <remarks>This method is implemented for composite</remarks>
    /// <param name="remoteUserId">Id of the participant to render, leave it undefined to create the local camera view</param>
    /// <param name="options">Options to control how video streams are rendered {@link</param>
    abstract createStreamView: ?remoteUserId: string * ?options: VideoStreamOptions -> Promise<U2<unit, CreateVideoStreamViewResult>>
    /// <summary>Dispose the html view for a stream.</summary>
    /// <remarks>This method is implemented for composite</remarks>
    /// <param name="remoteUserId">Id of the participant to render, leave it undefined to dispose the local camera view</param>
    /// <param name="options">Options to control how video streams are rendered {@link</param>
    abstract disposeStreamView: ?remoteUserId: string * ?options: VideoStreamOptions -> Promise<unit>

/// <summary><see cref="CallAdapter" /> state inferred from Azure Communication Services backend.</summary>
type [<AllowNullLiteral>] CallAdapterClientState =
    abstract userId: CommunicationIdentifierKind with get, set
    abstract displayName: string option with get, set
    abstract call: CallState option with get, set
    abstract devices: DeviceManagerState with get, set
    abstract endedCall: CallState option with get, set
    abstract isTeamsCall: bool with get, set
    /// Latest error encountered for each operation performed via the adapter.
    abstract latestErrors: AdapterErrors with get, set

/// <summary>Functionality for managing devices within a call.</summary>
type [<AllowNullLiteral>] CallAdapterDeviceManagement =
    /// <summary>Ask for permissions of devices.</summary>
    /// <remarks>Browser permission window will pop up if permissions are not granted yet</remarks>
    /// <param name="constrain">Define constraints for accessing local devices {@link</param>
    abstract askDevicePermission: constrain: PermissionConstraints -> Promise<unit>
    /// <summary>Query for available camera devices.</summary>
    /// <remarks>This method should be called after askDevicePermission()</remarks>
    /// <returns>An array of video device information entities {@link</returns>
    abstract queryCameras: unit -> Promise<ResizeArray<VideoDeviceInfo>>
    /// <summary>Query for available microphone devices.</summary>
    /// <remarks>This method should be called after askDevicePermission()</remarks>
    /// <returns>An array of audio device information entities {@link</returns>
    abstract queryMicrophones: unit -> Promise<ResizeArray<AudioDeviceInfo>>
    /// <summary>Query for available microphone devices.</summary>
    /// <remarks>This method should be called after askDevicePermission()</remarks>
    /// <returns>An array of audio device information entities {@link</returns>
    abstract querySpeakers: unit -> Promise<ResizeArray<AudioDeviceInfo>>
    /// <summary>Set the camera to use in the call.</summary>
    /// <param name="sourceInfo">Camera device to choose, pick one returned by  <see cref="CallAdapterDeviceManagement.queryCameras" /></param>
    /// <param name="options">Options to control how the camera stream is rendered {@link</param>
    abstract setCamera: sourceInfo: VideoDeviceInfo * ?options: VideoStreamOptions -> Promise<unit>
    /// <summary>Set the microphone to use in the call.</summary>
    /// <param name="sourceInfo">Microphone device to choose, pick one returned by <see cref="CallAdapterDeviceManagement.queryMicrophones" /></param>
    abstract setMicrophone: sourceInfo: AudioDeviceInfo -> Promise<unit>
    /// <summary>Set the speaker to use in the call.</summary>
    /// <param name="sourceInfo">Speaker device to choose, pick one returned by <see cref="CallAdapterDeviceManagement.querySpeakers" /></param>
    abstract setSpeaker: sourceInfo: AudioDeviceInfo -> Promise<unit>

/// <summary>Locator used by <see cref="createAzureCommunicationCallAdapter" /> to locate the call to join</summary>
type CallAdapterLocator =
    U2<TeamsMeetingLinkLocator, GroupCallLocator>

/// <summary><see cref="CallAdapter" /> state.</summary>
type [<AllowNullLiteral>] CallAdapterState =
    interface end

/// <summary>Call composite events that can be subscribed to.</summary>
type [<AllowNullLiteral>] CallAdapterSubscribers =
    /// Subscribe function for 'participantsJoined' event.
    [<Emit("$0.on('participantsJoined',$1)")>] abstract on_participantsJoined: listener: ParticipantsJoinedListener -> unit
    /// Subscribe function for 'participantsLeft' event.
    [<Emit("$0.on('participantsLeft',$1)")>] abstract on_participantsLeft: listener: ParticipantsLeftListener -> unit
    /// <summary>Subscribe function for 'isMutedChanged' event.</summary>
    /// <remarks>The event will be triggered whenever current user or remote user mute state changed</remarks>
    [<Emit("$0.on('isMutedChanged',$1)")>] abstract on_isMutedChanged: listener: IsMutedChangedListener -> unit
    /// <summary>Subscribe function for 'callIdChanged' event.</summary>
    /// <remarks>The event will be triggered when callId of current user changed.</remarks>
    [<Emit("$0.on('callIdChanged',$1)")>] abstract on_callIdChanged: listener: CallIdChangedListener -> unit
    /// Subscribe function for 'isLocalScreenSharingActiveChanged' event.
    [<Emit("$0.on('isLocalScreenSharingActiveChanged',$1)")>] abstract on_isLocalScreenSharingActiveChanged: listener: IsLocalScreenSharingActiveChangedListener -> unit
    /// Subscribe function for 'displayNameChanged' event.
    [<Emit("$0.on('displayNameChanged',$1)")>] abstract on_displayNameChanged: listener: DisplayNameChangedListener -> unit
    /// Subscribe function for 'isSpeakingChanged' event.
    [<Emit("$0.on('isSpeakingChanged',$1)")>] abstract on_isSpeakingChanged: listener: IsSpeakingChangedListener -> unit
    /// Subscribe function for 'callEnded' event.
    [<Emit("$0.on('callEnded',$1)")>] abstract on_callEnded: listener: CallEndedListener -> unit
    /// Subscribe function for 'diagnosticChanged' event.
    ///
    /// This event fires whenever there is a change in user facing diagnostics about the ongoing call.
    [<Emit("$0.on('diagnosticChanged',$1)")>] abstract on_diagnosticChanged: listener: DiagnosticChangedEventListner -> unit
    /// Subscribe function for 'error' event.
    [<Emit("$0.on('error',$1)")>] abstract on_error: listener: (AdapterError -> unit) -> unit
    /// Unsubscribe function for 'participantsJoined' event.
    [<Emit("$0.off('participantsJoined',$1)")>] abstract off_participantsJoined: listener: ParticipantsJoinedListener -> unit
    /// Unsubscribe function for 'participantsLeft' event.
    [<Emit("$0.off('participantsLeft',$1)")>] abstract off_participantsLeft: listener: ParticipantsLeftListener -> unit
    /// Unsubscribe function for 'isMutedChanged' event.
    [<Emit("$0.off('isMutedChanged',$1)")>] abstract off_isMutedChanged: listener: IsMutedChangedListener -> unit
    /// Unsubscribe function for 'callIdChanged' event.
    [<Emit("$0.off('callIdChanged',$1)")>] abstract off_callIdChanged: listener: CallIdChangedListener -> unit
    /// Unsubscribe function for 'isLocalScreenSharingActiveChanged' event.
    [<Emit("$0.off('isLocalScreenSharingActiveChanged',$1)")>] abstract off_isLocalScreenSharingActiveChanged: listener: IsLocalScreenSharingActiveChangedListener -> unit
    /// Unsubscribe function for 'displayNameChanged' event.
    [<Emit("$0.off('displayNameChanged',$1)")>] abstract off_displayNameChanged: listener: DisplayNameChangedListener -> unit
    /// Unsubscribe function for 'isSpeakingChanged' event.
    [<Emit("$0.off('isSpeakingChanged',$1)")>] abstract off_isSpeakingChanged: listener: IsSpeakingChangedListener -> unit
    /// Unsubscribe function for 'callEnded' event.
    [<Emit("$0.off('callEnded',$1)")>] abstract off_callEnded: listener: CallEndedListener -> unit
    /// Unsubscribe function for 'diagnosticChanged' event.
    [<Emit("$0.off('diagnosticChanged',$1)")>] abstract off_diagnosticChanged: listener: DiagnosticChangedEventListner -> unit
    /// Unsubscribe function for 'error' event.
    [<Emit("$0.off('error',$1)")>] abstract off_error: listener: (AdapterError -> unit) -> unit

/// <summary><see cref="CallAdapter" /> state for pure UI purposes.</summary>
type [<AllowNullLiteral>] CallAdapterUiState =
    abstract isLocalPreviewMicrophoneEnabled: bool with get, set
    abstract page: CallCompositePage with get, set

/// <summary>Arguments to initialize a <see cref="CallAgentProvider" />.</summary>
type [<AllowNullLiteral>] CallAgentProviderProps =
    abstract children: React_2.ReactNode with get, set
    abstract callAgent: CallAgent option with get, set

/// <summary>
/// State only version of <see cref="@azure/communication-calling.CallAgent" /> except calls is moved to be a child directly of
/// <see cref="CallClientState" /> and not included here. The reason to have CallAgent's state proxied is to provide access to
/// displayName. We don't flatten CallAgent.displayName and put it in CallClientState because it would be ambiguious that
/// displayName is actually reliant on the creation/existence of CallAgent to be available.
/// </summary>
type [<AllowNullLiteral>] CallAgentState =
    /// <summary>Proxy of <see cref="@azure/communication-calling.CallAgent.displayName" />.</summary>
    abstract displayName: string option with get, set

/// <summary>Arguments for use in <see cref="createAzureCommunicationCallWithChatAdapter" /> to join a Call with an associated Chat thread.</summary>
type [<AllowNullLiteral>] CallAndChatLocator =
    /// <summary>Locator used by <see cref="createAzureCommunicationCallWithChatAdapter" /> to locate the call to join</summary>
    abstract callLocator: GroupCallLocator with get, set
    /// <summary>Chat thread ID used by <see cref="createAzureCommunicationCallWithChatAdapter" /> to locate the chat thread to join</summary>
    abstract chatThreadId: string with get, set

/// <summary>Arguments to initialize a <see cref="CallClientProvider" />.</summary>
type [<AllowNullLiteral>] CallClientProviderProps =
    abstract children: React_2.ReactNode with get, set
    abstract callClient: StatefulCallClient with get, set

/// <summary>
/// Container for all of the state data proxied by <see cref="StatefulCallClient" />. The calls, callsEnded, incomingCalls, and
/// incomingCallsEnded states will be automatically provided if a callAgent has been created. The deviceManager will be
/// empty initially until populated see <see cref="DeviceManagerState" />. The userId state is provided as a convenience for the
/// developer and is completely controled and set by the developer.
/// </summary>
type [<AllowNullLiteral>] CallClientState =
    /// <summary>
    /// Proxy of <see cref="@azure/communication-calling.CallAgent.calls" /> as an object with CallState <see cref="CallState" /> fields.
    /// It is keyed by <see cref="@azure/communication-calling.Call.id" />. Please note that
    /// <see cref="@azure/communication-calling.Call.id" /> could change. You should not cache the id itself but the entire
    /// <see cref="@azure/communication-calling.Call" /> and then use the id contained to look up data in this map.
    /// </summary>
    abstract calls: CallClientStateCalls with get, set
    /// <summary>
    /// Calls that have ended are stored here so the callEndReason could be checked.
    /// It is an object with <see cref="@azure/communication-calling.Call.id" /> keys and <see cref="CallState" /> values.
    ///
    /// Only <see cref="MAX_CALL_HISTORY_LENGTH" /> Calls are kept in the history. Oldest calls are evicted if required.
    /// </summary>
    abstract callsEnded: CallClientStateCalls with get, set
    /// <summary>
    /// Proxy of <see cref="@azure/communication-calling.IncomingCall" /> as an object with <see cref="IncomingCall" /> fields.
    /// It is keyed by <see cref="@azure/communication-calling.IncomingCall.id" />.
    /// </summary>
    abstract incomingCalls: CallClientStateIncomingCalls with get, set
    /// <summary>
    /// Incoming Calls that have ended are stored here so the callEndReason could be checked.
    /// It is an as an object with <see cref="@azure/communication-calling.Call.id" /> keys and <see cref="IncomingCall" /> values.
    ///
    /// Only <see cref="MAX_CALL_HISTORY_LENGTH" /> Calls are kept in the history. Oldest calls are evicted if required.
    /// </summary>
    abstract incomingCallsEnded: CallClientStateIncomingCalls with get, set
    /// <summary>Proxy of <see cref="@azure/communication-calling.DeviceManager" />. Please review <see cref="DeviceManagerState" />.</summary>
    abstract deviceManager: DeviceManagerState with get, set
    /// <summary>Proxy of <see cref="@azure/communication-calling.CallAgent" />. Please review <see cref="CallAgentState" />.</summary>
    abstract callAgent: CallAgentState option with get, set
    /// <summary>
    /// Stores a userId. This is not used by the <see cref="StatefulCallClient" /> and is provided here as a convenience for the
    /// developer for easier access to userId. Must be passed in at initialization of the <see cref="StatefulCallClient" />.
    /// Completely controlled by the developer.
    /// </summary>
    abstract userId: CommunicationIdentifierKind with get, set
    /// Stores the latest error for each API method.
    ///
    /// See documentation of {@Link CallErrors} for details.
    abstract latestErrors: CallErrors with get, set

/// <summary>Icons that can be overridden for <see cref="CallComposite" />.</summary>
type [<AllowNullLiteral>] CallCompositeIcons =
    abstract ControlButtonCameraOff: JSX.Element option with get, set
    abstract ControlButtonCameraOn: JSX.Element option with get, set
    abstract ControlButtonEndCall: JSX.Element option with get, set
    abstract ControlButtonMicOff: JSX.Element option with get, set
    abstract ControlButtonMicOn: JSX.Element option with get, set
    abstract ControlButtonOptions: JSX.Element option with get, set
    abstract ControlButtonParticipants: JSX.Element option with get, set
    abstract ControlButtonScreenShareStart: JSX.Element option with get, set
    abstract ControlButtonScreenShareStop: JSX.Element option with get, set
    abstract ErrorBarCallCameraAccessDenied: JSX.Element option with get, set
    abstract ErrorBarCallCameraAlreadyInUse: JSX.Element option with get, set
    abstract ErrorBarCallLocalVideoFreeze: JSX.Element option with get, set
    abstract ErrorBarCallMacOsCameraAccessDenied: JSX.Element option with get, set
    abstract ErrorBarCallMacOsMicrophoneAccessDenied: JSX.Element option with get, set
    abstract ErrorBarCallMicrophoneAccessDenied: JSX.Element option with get, set
    abstract ErrorBarCallMicrophoneMutedBySystem: JSX.Element option with get, set
    abstract ErrorBarCallNetworkQualityLow: JSX.Element option with get, set
    abstract ErrorBarCallNoMicrophoneFound: JSX.Element option with get, set
    abstract ErrorBarCallNoSpeakerFound: JSX.Element option with get, set
    abstract HorizontalGalleryLeftButton: JSX.Element option with get, set
    abstract HorizontalGalleryRightButton: JSX.Element option with get, set
    abstract LobbyScreenConnectingToCall: JSX.Element option with get, set
    abstract LobbyScreenWaitingToBeAdmitted: JSX.Element option with get, set
    abstract LocalDeviceSettingsCamera: JSX.Element option with get, set
    abstract LocalDeviceSettingsMic: JSX.Element option with get, set
    abstract LocalDeviceSettingsSpeaker: JSX.Element option with get, set
    abstract LocalPreviewPlaceholder: JSX.Element option with get, set
    abstract Muted: JSX.Element option with get, set
    abstract NetworkReconnectIcon: JSX.Element option with get, set
    abstract NoticePageAccessDeniedTeamsMeeting: JSX.Element option with get, set
    abstract NoticePageJoinCallFailedDueToNoNetwork: JSX.Element option with get, set
    abstract NoticePageLeftCall: JSX.Element option with get, set
    abstract NoticePageRemovedFromCall: JSX.Element option with get, set
    abstract OptionsCamera: JSX.Element option with get, set
    abstract OptionsMic: JSX.Element option with get, set
    abstract OptionsSpeaker: JSX.Element option with get, set
    abstract ParticipantItemMicOff: JSX.Element option with get, set
    abstract ParticipantItemOptions: JSX.Element option with get, set
    abstract ParticipantItemOptionsHovered: JSX.Element option with get, set
    abstract ParticipantItemScreenShareStart: JSX.Element option with get, set
    abstract VideoTileMicOff: JSX.Element option with get, set
    abstract LocalCameraSwitch: JSX.Element option with get, set

/// <summary>Optional features of the <see cref="CallComposite" />.</summary>
type [<AllowNullLiteral>] CallCompositeOptions =
    /// <summary>
    /// Surface Azure Communication Services backend errors in the UI with <see cref="@azure/communication-react.ErrorBar" />.
    /// Hide or show the error bar.
    /// </summary>
    /// <default>true</default>
    abstract errorBar: bool option with get, set
    /// <summary>
    /// Hide or Customize the control bar element.
    /// Can be customized by providing an object of type <see cref="@azure/communication-react.CallControlOptions" />.
    /// </summary>
    /// <default>true</default>
    abstract callControls: U2<bool, CallControlOptions> option with get, set

/// <summary>Major UI screens shown in the <see cref="CallComposite" />.</summary>
type [<StringEnum>] [<RequireQualifiedAccess>] CallCompositePage =
    | AccessDeniedTeamsMeeting
    | Call
    | Configuration
    | JoinCallFailedDueToNoNetwork
    | LeftCall
    | Lobby
    | RemovedFromCall

/// <summary>Props for <see cref="CallComposite" />.</summary>
type [<AllowNullLiteral>] CallCompositeProps =
    inherit BaseCompositeProps<CallCompositeIcons>
    /// An adapter provides logic and data to the composite.
    /// Composite can also be controlled using the adapter.
    abstract adapter: CallAdapter with get, set
    /// <summary>Optimizes the composite form factor for either desktop or mobile.</summary>
    /// <remarks><c>mobile</c> is currently only optimized for Portrait mode on mobile devices and does not support landscape.</remarks>
    /// <default>'desktop'</default>
    abstract formFactor: CallCompositePropsFormFactor option with get, set
    /// URL to invite new participants to the current call. If this is supplied, a button appears in the Participants
    /// Button flyout menu.
    abstract callInvitationUrl: string option with get, set
    /// <summary>Flags to enable/disable or customize UI elements of the <see cref="CallComposite" />.</summary>
    abstract options: CallCompositeOptions option with get, set

/// <summary>
/// Strings used by the <see cref="CallComposite" /> directly.
///
/// This strings are in addition to those used by the components from the component library.
/// </summary>
type [<AllowNullLiteral>] CallCompositeStrings =
    /// Title of configuration page.
    abstract configurationPageTitle: string with get, set
    /// Optional 1-2 lines on the call details used on the configuration page.
    abstract configurationPageCallDetails: string option with get, set
    /// Text in button to start call in configuration page.
    abstract startCallButtonLabel: string with get, set
    /// Text in button to rejoin an ended call.
    abstract rejoinCallButtonLabel: string with get, set
    /// Placeholder text for local device settings dropdowns.
    abstract defaultPlaceHolder: string with get, set
    /// Label for camera dropdown.
    abstract cameraLabel: string with get, set
    /// Label for sound dropdown.
    abstract soundLabel: string with get, set
    /// Error shown when camera access is blocked by the browser.
    abstract cameraPermissionDenied: string with get, set
    /// Error shown when the camera is turned off.
    abstract cameraTurnedOff: string with get, set
    /// Error shown when microphone access is blocked by the browser.
    abstract microphonePermissionDenied: string with get, set
    /// Title text of the page shown to the user when joining a Teams meeting fails because meeting owner denied access.
    abstract failedToJoinTeamsMeetingReasonAccessDeniedTitle: string with get, set
    /// More details text of the page shown to the user when joining a Teams meeting fails because meeting owner denied access.
    abstract failedToJoinTeamsMeetingReasonAccessDeniedMoreDetails: string option with get, set
    /// Title text of the page shown to the user when joining a call fails due to a network problem.
    abstract failedToJoinCallDueToNoNetworkTitle: string with get, set
    /// More details text of the page shown to the user when joining a call fails due to a network problem.
    abstract failedToJoinCallDueToNoNetworkMoreDetails: string option with get, set
    /// Title text of the page shown to the user when they leave a call in the call composite.
    abstract leftCallTitle: string with get, set
    /// More details text of the page shown to the user when they leave a call in the call composite.
    abstract leftCallMoreDetails: string option with get, set
    /// Title text of the page shown to the user when they are removed from a call in the call composite.
    abstract removedFromCallTitle: string with get, set
    /// More details text of the page shown to the user when they are removed from a call in the call composite.
    abstract removedFromCallMoreDetails: string option with get, set
    /// Text shown to the user on the lobby screen when connecting to a call.
    abstract lobbyScreenConnectingToCallTitle: string with get, set
    /// Optional addition details shown to the user on the lobby screen when connection to a call.
    abstract lobbyScreenConnectingToCallMoreDetails: string option with get, set
    /// Text shown to the user on the lobby screen when waiting to be admitted to a call.
    abstract lobbyScreenWaitingToBeAdmittedTitle: string with get, set
    /// Optional additional details shown to the user on the lobby screen when waiting to be admitted to a call.
    abstract lobbyScreenWaitingToBeAdmittedMoreDetails: string option with get, set
    /// Message shown to the user when they are speaking while muted.
    abstract mutedMessage: string with get, set
    /// Text for link to MS privacy policy in Compliance Banner.
    abstract privacyPolicy: string with get, set
    /// Text for link to learn more about a specific subject.
    abstract learnMore: string with get, set
    /// Message to let user know the meeting is only being recorded (no transcription) in ComplianceBanner.
    abstract complianceBannerNowOnlyRecording: string with get, set
    /// Message to let user know the meeting is only being transcripted (no recording) in ComplianceBanner.
    abstract complianceBannerNowOnlyTranscription: string with get, set
    /// Message to let user know recording and transcription of the meeting are saved in ComplianceBanner.
    abstract complianceBannerRecordingAndTranscriptionSaved: string with get, set
    /// Message to let user know recording and transcription of the meeting have started in ComplianceBanner.
    abstract complianceBannerRecordingAndTranscriptionStarted: string with get, set
    /// Message to let user know recording and transcription of the meeting have stopped in ComplianceBanner.
    abstract complianceBannerRecordingAndTranscriptionStopped: string with get, set
    /// Message to let user know recording of the meeting is being saved in ComplianceBanner.
    abstract complianceBannerRecordingSaving: string with get, set
    /// Message to let user know recording of the meeting has started in ComplianceBanner.
    abstract complianceBannerRecordingStarted: string with get, set
    /// Message to let user know recording of the meeting has stopped in ComplianceBanner.
    abstract complianceBannerRecordingStopped: string with get, set
    /// Message to let user know they are giving consent to meeting being transcripted in ComplianceBanner.
    abstract complianceBannerTranscriptionConsent: string with get, set
    /// Message to let user know transcription of the meeting is being saved in ComplianceBanner.
    abstract complianceBannerTranscriptionSaving: string with get, set
    /// Message to let user know transcription of the meeting has started in ComplianceBanner.
    abstract complianceBannerTranscriptionStarted: string with get, set
    /// Message to let user know the transcription of the meeting has stopped in ComplianceBanner.
    abstract complianceBannerTranscriptionStopped: string with get, set
    /// Text for close button.
    abstract close: string with get, set
    /// Title text of the page shown to the user when there is intermittent network failure during a call.
    abstract networkReconnectTitle: string with get, set
    /// More details text of the page shown to the user when there is intermittent network failure during a call.
    abstract networkReconnectMoreDetails: string with get, set
    /// Tooltip text used to inform a user that toggling microphone in lobby is not supported.
    abstract microphoneToggleInLobbyNotAllowed: string with get, set

/// <summary>Control bar display type for <see cref="CallComposite" />.</summary>
type [<StringEnum>] [<RequireQualifiedAccess>] CallControlDisplayType =
    | Default
    | Compact

/// <summary>Customization options for the control bar in calling experience.</summary>
type [<AllowNullLiteral>] CallControlOptions =
    /// <summary>
    /// <see cref="CallControlDisplayType" /> to change how the call controls are displayed.
    /// <c>'compact'</c> display type will decreases the size of buttons and hide the labels.
    /// </summary>
    /// <remarks>If the composite <c>formFactor</c> is set to <c>'mobile'</c>, the control bar will always use compact view.</remarks>
    /// <default>'default'</default>
    abstract displayType: CallControlDisplayType option with get, set
    /// <summary>Show or Hide Camera Button during a call</summary>
    /// <default>true</default>
    abstract cameraButton: bool option with get, set
    /// <summary>Show or Hide EndCall button during a call.</summary>
    /// <default>true</default>
    abstract endCallButton: bool option with get, set
    /// <summary>Show or Hide Microphone button during a call.</summary>
    /// <default>true</default>
    abstract microphoneButton: bool option with get, set
    /// <summary>Show or Hide Devices button during a call.</summary>
    /// <default>true</default>
    abstract devicesButton: bool option with get, set
    /// <summary>Show, Hide or Disable participants button during a call.</summary>
    /// <default>true</default>
    abstract participantsButton: U2<bool, {| disabled: bool |}> option with get, set
    /// <summary>Show, Hide or Disable the screen share button during a call.</summary>
    /// <default>true</default>
    abstract screenShareButton: U2<bool, {| disabled: bool |}> option with get, set

/// <summary>Callback for <see cref="CallAdapterSubscribers" /> 'callEnded' event.</summary>
type [<AllowNullLiteral>] CallEndedListener =
    /// <summary>Callback for <see cref="CallAdapterSubscribers" /> 'callEnded' event.</summary>
    [<Emit("$0($1...)")>] abstract Invoke: ``event``: {| callId: string |} -> unit

/// <summary>Error thrown from failed stateful API methods.</summary>
type [<AllowNullLiteral>] CallError =
    inherit Error
    /// The API method target that failed.
    abstract target: CallErrorTarget with get, set
    /// Error thrown by the failed SDK method.
    abstract innerError: Error with get, set
    /// Timestamp added to the error by the stateful layer.
    abstract timestamp: DateTime with get, set

/// <summary>Error thrown from failed stateful API methods.</summary>
type [<AllowNullLiteral>] CallErrorStatic =
    [<EmitConstructor>] abstract Create: target: CallErrorTarget * innerError: Error * ?timestamp: DateTime -> CallError

/// <summary>Selector type for <see cref="ErrorBar" /> component.</summary>
type [<AllowNullLiteral>] CallErrorBarSelector =
    /// <summary>Selector type for <see cref="ErrorBar" /> component.</summary>
    [<Emit("$0($1...)")>] abstract Invoke: state: CallClientState * props: CallingBaseSelectorProps -> {| activeErrorMessages: ResizeArray<ActiveErrorMessage> |}

/// <summary>
/// Errors teed from API calls to the Calling SDK.
///
/// Each property in the object stores the latest error for a particular SDK API method.
///
/// Errors from this object can be cleared using the <see cref="newClearCallErrorsModifier" />.
/// Additionally, errors are automatically cleared when:
/// - The state is cleared.
/// - Subsequent calls to related API methods succeed.
/// See documentation of individual stateful client methods for details on when errors may be automatically cleared.
/// </summary>
type [<AllowNullLiteral>] CallErrors =
    interface end

/// <summary>String literal type for all permissible keys in {@Link CallErrors}.</summary>
type [<StringEnum>] [<RequireQualifiedAccess>] CallErrorTarget =
    | [<CompiledName("Call.addParticipant")>] Call_addParticipant
    | [<CompiledName("Call.feature")>] Call_feature
    | [<CompiledName("Call.hangUp")>] Call_hangUp
    | [<CompiledName("Call.hold")>] Call_hold
    | [<CompiledName("Call.mute")>] Call_mute
    | [<CompiledName("Call.off")>] Call_off
    | [<CompiledName("Call.on")>] Call_on
    | [<CompiledName("Call.removeParticipant")>] Call_removeParticipant
    | [<CompiledName("Call.resume")>] Call_resume
    | [<CompiledName("Call.sendDtmf")>] Call_sendDtmf
    | [<CompiledName("Call.startScreenSharing")>] Call_startScreenSharing
    | [<CompiledName("Call.startVideo")>] Call_startVideo
    | [<CompiledName("Call.stopScreenSharing")>] Call_stopScreenSharing
    | [<CompiledName("Call.stopVideo")>] Call_stopVideo
    | [<CompiledName("Call.unmute")>] Call_unmute
    | [<CompiledName("CallAgent.dispose")>] CallAgent_dispose
    | [<CompiledName("CallAgent.feature")>] CallAgent_feature
    | [<CompiledName("CallAgent.join")>] CallAgent_join
    | [<CompiledName("CallAgent.off")>] CallAgent_off
    | [<CompiledName("CallAgent.on")>] CallAgent_on
    | [<CompiledName("CallAgent.startCall")>] CallAgent_startCall
    | [<CompiledName("CallClient.createCallAgent")>] CallClient_createCallAgent
    | [<CompiledName("CallClient.feature")>] CallClient_feature
    | [<CompiledName("CallClient.getDeviceManager")>] CallClient_getDeviceManager
    | [<CompiledName("DeviceManager.askDevicePermission")>] DeviceManager_askDevicePermission
    | [<CompiledName("DeviceManager.getCameras")>] DeviceManager_getCameras
    | [<CompiledName("DeviceManager.getMicrophones")>] DeviceManager_getMicrophones
    | [<CompiledName("DeviceManager.getSpeakers")>] DeviceManager_getSpeakers
    | [<CompiledName("DeviceManager.off")>] DeviceManager_off
    | [<CompiledName("DeviceManager.on")>] DeviceManager_on
    | [<CompiledName("DeviceManager.selectMicrophone")>] DeviceManager_selectMicrophone
    | [<CompiledName("DeviceManager.selectSpeaker")>] DeviceManager_selectSpeaker

/// <summary>Callback for <see cref="CallAdapterSubscribers" /> 'callIdChanged' event.</summary>
type [<AllowNullLiteral>] CallIdChangedListener =
    /// <summary>Callback for <see cref="CallAdapterSubscribers" /> 'callIdChanged' event.</summary>
    [<Emit("$0($1...)")>] abstract Invoke: ``event``: {| callId: string |} -> unit

/// <summary>Common props used to reference calling declarative client state.</summary>
type [<AllowNullLiteral>] CallingBaseSelectorProps =
    abstract callId: string with get, set

/// <summary>
/// Object containing all the handlers required for calling components.
///
/// Calling related components from this package are able to pick out relevant handlers from this object.
/// See <see cref="useHandlers" /> and <see cref="usePropsFor" />.
/// </summary>
type [<AllowNullLiteral>] CallingHandlers =
    abstract onStartLocalVideo: (unit -> Promise<unit>) with get, set
    abstract onToggleCamera: ((VideoStreamOptions) option -> Promise<unit>) with get, set
    abstract onStartCall: (ResizeArray<U3<CommunicationUserIdentifier, PhoneNumberIdentifier, UnknownIdentifier>> -> (StartCallOptions) option -> Call option) with get, set
    abstract onSelectMicrophone: (AudioDeviceInfo -> Promise<unit>) with get, set
    abstract onSelectSpeaker: (AudioDeviceInfo -> Promise<unit>) with get, set
    abstract onSelectCamera: (VideoDeviceInfo -> (VideoStreamOptions) option -> Promise<unit>) with get, set
    abstract onToggleMicrophone: (unit -> Promise<unit>) with get, set
    abstract onStartScreenShare: (unit -> Promise<unit>) with get, set
    abstract onStopScreenShare: (unit -> Promise<unit>) with get, set
    abstract onToggleScreenShare: (unit -> Promise<unit>) with get, set
    abstract onHangUp: (unit -> Promise<unit>) with get, set
    abstract onCreateLocalStreamView: ((VideoStreamOptions) option -> Promise<U2<unit, CreateVideoStreamViewResult>>) with get, set
    abstract onCreateRemoteStreamView: (string -> (VideoStreamOptions) option -> Promise<U2<unit, CreateVideoStreamViewResult>>) with get, set
    abstract onRemoveParticipant: (string -> Promise<unit>) with get, set
    abstract onDisposeRemoteStreamView: (string -> Promise<unit>) with get, set
    abstract onDisposeLocalStreamView: (unit -> Promise<unit>) with get, set

/// <summary>Helper type for <see cref="usePropsFor" />.</summary>
type CallingReturnProps<'Component> =
    obj

/// <summary>Custom Fluent theme pallete used by calling related components in this library.</summary>
type [<AllowNullLiteral>] CallingTheme =
    abstract callingPalette: {| callRed: string; callRedDark: string; callRedDarker: string; iconWhite: string |} with get, set

/// <summary>Calling participant's state, as reflected in the UI components.</summary>
type [<AllowNullLiteral>] CallParticipantListParticipant =
    interface end

/// <summary>Arguments to initialize a <see cref="CallProvider" />.</summary>
type [<AllowNullLiteral>] CallProviderProps =
    abstract children: React_2.ReactNode with get, set
    abstract call: Call option with get, set

/// <summary>
/// State only version of <see cref="@azure/communication-calling.Call" />. <see cref="StatefulCallClient" /> will automatically
/// retrieve Call's state and add it to the state exposed by <see cref="StatefulCallClient" />.
/// </summary>
type [<AllowNullLiteral>] CallState =
    /// <summary>Proxy of <see cref="@azure/communication-calling.Call.id" />.</summary>
    abstract id: string with get, set
    /// <summary>Proxy of <see cref="@azure/communication-calling.Call.callerInfo" />.</summary>
    abstract callerInfo: CallerInfo with get, set
    /// <summary>Proxy of <see cref="@azure/communication-calling.Call.state" />.</summary>
    abstract state: CallState_2 with get, set
    /// <summary>Proxy of <see cref="@azure/communication-calling.Call.callEndReason" />.</summary>
    abstract callEndReason: CallEndReason option with get, set
    /// <summary>Proxy of <see cref="@azure/communication-calling.Call.direction" />.</summary>
    abstract direction: CallDirection with get, set
    /// <summary>Proxy of <see cref="@azure/communication-calling.Call.isMuted" />.</summary>
    abstract isMuted: bool with get, set
    /// <summary>Proxy of <see cref="@azure/communication-calling.Call.isScreenSharingOn" />.</summary>
    abstract isScreenSharingOn: bool with get, set
    /// <summary>Proxy of <see cref="@azure/communication-calling.DominantSpeakersInfo" />.</summary>
    abstract dominantSpeakers: DominantSpeakersInfo option with get, set
    /// <summary>Proxy of <see cref="@azure/communication-calling.Call.localVideoStreams" />.</summary>
    abstract localVideoStreams: ResizeArray<LocalVideoStreamState> with get, set
    /// <summary>
    /// Proxy of <see cref="@azure/communication-calling.Call.remoteParticipants" />.
    /// Object with <see cref="RemoteParticipant" /> fields keyed by flattened <see cref="RemoteParticipantState.identifier" />.
    /// To obtain a flattened <see cref="RemoteParticipantState.identifier" />, use
    /// <see cref="@azure/communication-react.toFlatCommunicationIdentifier" />.
    /// </summary>
    abstract remoteParticipants: CallStateRemoteParticipants with get, set
    /// <summary>
    /// Stores remote participants that have left the call so that the callEndReason could be retrieved.
    /// Object with <see cref="RemoteParticipant" /> fields keyed by flattened <see cref="RemoteParticipantState.identifier" />.
    /// To obtain a flattened <see cref="RemoteParticipantState.identifier" />, use
    /// <see cref="@azure/communication-react.toFlatCommunicationIdentifier" />.
    /// </summary>
    abstract remoteParticipantsEnded: CallStateRemoteParticipants with get, set
    /// <summary>Proxy of <see cref="@azure/communication-calling.TranscriptionCallFeature" />.</summary>
    abstract transcription: TranscriptionCallFeature with get, set
    /// <summary>Proxy of <see cref="@azure/communication-calling.RecordingCallFeature" />.</summary>
    abstract recording: RecordingCallFeature with get, set
    /// <summary>
    /// Stores the currently active screenshare participant's key. If there is no screenshare active, then this will be
    /// undefined. You can use this key to access the remoteParticipant data in <see cref="CallState.remoteParticipants" /> object.
    ///
    /// Note this only applies to ScreenShare in RemoteParticipant. A local ScreenShare being active will not affect this
    /// property.
    ///
    /// This property is added by the stateful layer and is not a proxy of SDK state
    /// </summary>
    abstract screenShareRemoteParticipant: string option with get, set
    /// Stores the local date when the call started on the client. This property is added by the stateful layer and is not
    /// a proxy of SDK state.
    abstract startTime: DateTime with get, set
    /// Stores the local date when the call ended on the client. This property is added by the stateful layer and is not
    /// a proxy of SDK state.
    abstract endTime: DateTime option with get, set
    /// Stores the latest call diagnostics.
    abstract diagnostics: DiagnosticsCallFeatureState with get, set

/// <summary><see cref="CallWithChatComposite" /> Adapter interface.</summary>
type [<AllowNullLiteral>] CallWithChatAdapter =
    inherit CallWithChatAdapterManagement
    inherit AdapterState<CallWithChatAdapterState>
    inherit Disposable
    inherit CallWithChatAdapterSubscriptions

/// <summary>Functionality for managing the current call with chat.</summary>
type [<AllowNullLiteral>] CallWithChatAdapterManagement =
    /// <summary>Remove a participant from a Call.</summary>
    /// <param name="userId">UserId of the participant to remove.</param>
    abstract removeParticipant: userId: string -> Promise<unit>
    /// <summary>Join the call with microphone initially on/off.</summary>
    /// <param name="microphoneOn">Whether microphone is initially enabled</param>
    abstract joinCall: ?microphoneOn: bool -> Call option
    /// <summary>Leave the call.</summary>
    /// <param name="forEveryone">Whether to remove all participants when leaving</param>
    abstract leaveCall: ?forEveryone: bool -> Promise<unit>
    /// <summary>
    /// Start the camera.
    ///
    /// This method will start rendering a local camera view when the call is not active.
    /// </summary>
    /// <param name="options">Options to control how video streams are rendered {@link</param>
    abstract startCamera: ?options: VideoStreamOptions -> Promise<unit>
    /// <summary>
    /// Stop the camera.
    ///
    /// This method will stop rendering a local camera view when the call is not active.
    /// </summary>
    abstract stopCamera: unit -> Promise<unit>
    /// <summary>Mute the current user during the call or disable microphone locally.</summary>
    abstract mute: unit -> Promise<unit>
    /// <summary>Unmute the current user during the call or enable microphone locally.</summary>
    abstract unmute: unit -> Promise<unit>
    /// <summary>Start the call.</summary>
    /// <param name="participants">An array of participant ids to join</param>
    abstract startCall: participants: ResizeArray<string> -> Call option
    /// <summary>Start sharing the screen during a call.</summary>
    abstract startScreenShare: unit -> Promise<unit>
    /// <summary>Stop sharing the screen.</summary>
    abstract stopScreenShare: unit -> Promise<unit>
    /// <summary>Create the html view for a stream.</summary>
    /// <remarks>This method is implemented for composite.</remarks>
    /// <param name="remoteUserId">Id of the participant to render, leave it undefined to create the local camera view</param>
    /// <param name="options">Options to control how video streams are rendered {@link</param>
    abstract createStreamView: ?remoteUserId: string * ?options: VideoStreamOptions -> Promise<U2<unit, CreateVideoStreamViewResult>>
    /// <summary>Dispose the html view for a stream.</summary>
    /// <remarks>This method is implemented for composite.</remarks>
    /// <param name="remoteUserId">Id of the participant to render, leave it undefined to dispose the local camera view</param>
    /// <param name="options">Options to control how video streams are rendered {@link</param>
    abstract disposeStreamView: ?remoteUserId: string * ?options: VideoStreamOptions -> Promise<unit>
    /// <summary>Ask for permissions of devices.</summary>
    /// <remarks>Browser permission window will pop up if permissions are not granted yet.</remarks>
    /// <param name="constrain">Define constraints for accessing local devices {@link</param>
    abstract askDevicePermission: constrain: PermissionConstraints -> Promise<unit>
    /// <summary>Query for available camera devices.</summary>
    /// <remarks>This method should be called after askDevicePermission()</remarks>
    /// <returns>An array of video device information entities {@link</returns>
    abstract queryCameras: unit -> Promise<ResizeArray<VideoDeviceInfo>>
    /// <summary>Query for available microphone devices.</summary>
    /// <remarks>This method should be called after askDevicePermission()</remarks>
    /// <returns>An array of audio device information entities {@link</returns>
    abstract queryMicrophones: unit -> Promise<ResizeArray<AudioDeviceInfo>>
    /// <summary>Query for available microphone devices.</summary>
    /// <remarks>This method should be called after askDevicePermission()</remarks>
    /// <returns>An array of audio device information entities {@link</returns>
    abstract querySpeakers: unit -> Promise<ResizeArray<AudioDeviceInfo>>
    /// <summary>Set the camera to use in the call.</summary>
    /// <param name="sourceInfo">Camera device to choose, pick one returned by  <see cref="CallAdapterDeviceManagement.queryCameras" /></param>
    /// <param name="options">Options to control how the camera stream is rendered {@link</param>
    abstract setCamera: sourceInfo: VideoDeviceInfo * ?options: VideoStreamOptions -> Promise<unit>
    /// <summary>Set the microphone to use in the call.</summary>
    /// <param name="sourceInfo">Microphone device to choose, pick one returned by <see cref="CallAdapterDeviceManagement.queryMicrophones" /></param>
    abstract setMicrophone: sourceInfo: AudioDeviceInfo -> Promise<unit>
    /// <summary>Set the speaker to use in the call.</summary>
    /// <param name="sourceInfo">Speaker device to choose, pick one returned by <see cref="CallAdapterDeviceManagement.querySpeakers" /></param>
    abstract setSpeaker: sourceInfo: AudioDeviceInfo -> Promise<unit>
    /// <summary>
    /// Fetch initial state for the Chat adapter.
    ///
    /// Performs the minimal fetch necessary for ChatComposite and API methods.
    /// </summary>
    abstract fetchInitialData: unit -> Promise<unit>
    /// <summary>Send a message in the thread.</summary>
    abstract sendMessage: content: string * ?options: SendMessageOptions -> Promise<unit>
    /// <summary>Send a read receipt for a message.</summary>
    abstract sendReadReceipt: chatMessageId: string -> Promise<unit>
    /// <summary>Send typing indicator in the thread.</summary>
    abstract sendTypingIndicator: unit -> Promise<unit>
    /// <summary>Update a message content.</summary>
    abstract updateMessage: messageId: string * content: string * ?metadata: Record<string, string> -> Promise<unit>
    /// <summary>Delete a message in the thread.</summary>
    abstract deleteMessage: messageId: string -> Promise<unit>
    /// <summary>Load more previous messages in the chat thread history.</summary>
    /// <remarks>This method is usually used to control incremental fetch/infinite scroll.</remarks>
    abstract loadPreviousChatMessages: messagesToLoad: float -> Promise<bool>

/// <summary>
/// CallWithChat State is a combination of Stateful Chat and Stateful Calling clients with some
/// state specific to the CallWithChat Composite only.
/// </summary>
type [<AllowNullLiteral>] CallWithChatAdapterState =
    inherit CallWithChatAdapterUiState
    inherit CallWithChatClientState

/// <summary>Call and Chat events that can be subscribed to in the <see cref="CallWithChatAdapter" />.</summary>
type [<AllowNullLiteral>] CallWithChatAdapterSubscriptions =
    [<Emit("$0.on('callEnded',$1)")>] abstract on_callEnded: listener: CallEndedListener -> unit
    [<Emit("$0.on('isMutedChanged',$1)")>] abstract on_isMutedChanged: listener: IsMutedChangedListener -> unit
    [<Emit("$0.on('callIdChanged',$1)")>] abstract on_callIdChanged: listener: CallIdChangedListener -> unit
    [<Emit("$0.on('isLocalScreenSharingActiveChanged',$1)")>] abstract on_isLocalScreenSharingActiveChanged: listener: IsLocalScreenSharingActiveChangedListener -> unit
    [<Emit("$0.on('displayNameChanged',$1)")>] abstract on_displayNameChanged: listener: DisplayNameChangedListener -> unit
    [<Emit("$0.on('isSpeakingChanged',$1)")>] abstract on_isSpeakingChanged: listener: IsSpeakingChangedListener -> unit
    [<Emit("$0.on('callParticipantsJoined',$1)")>] abstract on_callParticipantsJoined: listener: ParticipantsJoinedListener -> unit
    [<Emit("$0.on('callParticipantsLeft',$1)")>] abstract on_callParticipantsLeft: listener: ParticipantsLeftListener -> unit
    [<Emit("$0.on('callError',$1)")>] abstract on_callError: listener: (AdapterError -> unit) -> unit
    [<Emit("$0.off('callEnded',$1)")>] abstract off_callEnded: listener: CallEndedListener -> unit
    [<Emit("$0.off('isMutedChanged',$1)")>] abstract off_isMutedChanged: listener: IsMutedChangedListener -> unit
    [<Emit("$0.off('callIdChanged',$1)")>] abstract off_callIdChanged: listener: CallIdChangedListener -> unit
    [<Emit("$0.off('isLocalScreenSharingActiveChanged',$1)")>] abstract off_isLocalScreenSharingActiveChanged: listener: IsLocalScreenSharingActiveChangedListener -> unit
    [<Emit("$0.off('displayNameChanged',$1)")>] abstract off_displayNameChanged: listener: DisplayNameChangedListener -> unit
    [<Emit("$0.off('isSpeakingChanged',$1)")>] abstract off_isSpeakingChanged: listener: IsSpeakingChangedListener -> unit
    [<Emit("$0.off('callParticipantsJoined',$1)")>] abstract off_callParticipantsJoined: listener: ParticipantsJoinedListener -> unit
    [<Emit("$0.off('callParticipantsLeft',$1)")>] abstract off_callParticipantsLeft: listener: ParticipantsLeftListener -> unit
    [<Emit("$0.off('callError',$1)")>] abstract off_callError: listener: (AdapterError -> unit) -> unit
    [<Emit("$0.on('messageReceived',$1)")>] abstract on_messageReceived: listener: MessageReceivedListener -> unit
    [<Emit("$0.on('messageSent',$1)")>] abstract on_messageSent: listener: MessageSentListener -> unit
    [<Emit("$0.on('messageRead',$1)")>] abstract on_messageRead: listener: MessageReadListener -> unit
    [<Emit("$0.on('chatParticipantsAdded',$1)")>] abstract on_chatParticipantsAdded: listener: ParticipantsAddedListener -> unit
    [<Emit("$0.on('chatParticipantsRemoved',$1)")>] abstract on_chatParticipantsRemoved: listener: ParticipantsRemovedListener -> unit
    [<Emit("$0.on('chatError',$1)")>] abstract on_chatError: listener: (AdapterError -> unit) -> unit
    [<Emit("$0.off('messageReceived',$1)")>] abstract off_messageReceived: listener: MessageReceivedListener -> unit
    [<Emit("$0.off('messageSent',$1)")>] abstract off_messageSent: listener: MessageSentListener -> unit
    [<Emit("$0.off('messageRead',$1)")>] abstract off_messageRead: listener: MessageReadListener -> unit
    [<Emit("$0.off('chatParticipantsAdded',$1)")>] abstract off_chatParticipantsAdded: listener: ParticipantsAddedListener -> unit
    [<Emit("$0.off('chatParticipantsRemoved',$1)")>] abstract off_chatParticipantsRemoved: listener: ParticipantsRemovedListener -> unit
    [<Emit("$0.off('chatError',$1)")>] abstract off_chatError: listener: (AdapterError -> unit) -> unit

/// <summary>UI state pertaining to the <see cref="CallWithChatComposite" />.</summary>
type [<AllowNullLiteral>] CallWithChatAdapterUiState =
    /// <summary>Microphone state before a call has joined.</summary>
    abstract isLocalPreviewMicrophoneEnabled: bool with get, set
    /// <summary>Current page of the Composite.</summary>
    abstract page: CallCompositePage with get, set

/// <summary>State from the backend services that drives <see cref="CallWithChatComposite" />.</summary>
type [<AllowNullLiteral>] CallWithChatClientState =
    /// ID of the call participant using this CallWithChatAdapter.
    abstract userId: CommunicationIdentifierKind with get, set
    /// Display name of the participant using this CallWithChatAdapter.
    abstract displayName: string option with get, set
    /// State of the current call.
    abstract call: CallState option with get, set
    /// State of the current chat.
    abstract chat: ChatThreadClientState option with get, set
    /// Latest call error encountered for each operation performed via the adapter.
    abstract latestCallErrors: AdapterErrors with get, set
    /// Latest chat error encountered for each operation performed via the adapter.
    abstract latestChatErrors: AdapterErrors with get, set
    /// State of available and currently selected devices
    abstract devices: DeviceManagerState with get, set
    /// State of whether the active call is a Teams interop call
    abstract isTeamsCall: bool with get, set

/// <summary>Icons that can be overridden for <see cref="CallWithChatComposite" />.</summary>
type [<AllowNullLiteral>] CallWithChatCompositeIcons =
    abstract ChevronLeft: JSX.Element option with get, set
    abstract ControlBarChatButtonActive: JSX.Element option with get, set
    abstract ControlBarChatButtonInactive: JSX.Element option with get, set
    abstract ControlBarPeopleButton: JSX.Element option with get, set
    abstract Link: JSX.Element option with get, set
    abstract MoreDrawerMicrophones: JSX.Element option with get, set
    abstract MoreDrawerPeople: JSX.Element option with get, set
    abstract MoreDrawerSelectedMicrophone: JSX.Element option with get, set
    abstract MoreDrawerSelectedSpeaker: JSX.Element option with get, set
    abstract MoreDrawerSpeakers: JSX.Element option with get, set
    abstract ControlButtonCameraOff: JSX.Element option with get, set
    abstract ControlButtonCameraOn: JSX.Element option with get, set
    abstract ControlButtonEndCall: JSX.Element option with get, set
    abstract ControlButtonMicOff: JSX.Element option with get, set
    abstract ControlButtonMicOn: JSX.Element option with get, set
    abstract ControlButtonOptions: JSX.Element option with get, set
    abstract ControlButtonScreenShareStart: JSX.Element option with get, set
    abstract ControlButtonScreenShareStop: JSX.Element option with get, set
    abstract ErrorBarCallCameraAccessDenied: JSX.Element option with get, set
    abstract ErrorBarCallCameraAlreadyInUse: JSX.Element option with get, set
    abstract ErrorBarCallLocalVideoFreeze: JSX.Element option with get, set
    abstract ErrorBarCallMacOsCameraAccessDenied: JSX.Element option with get, set
    abstract ErrorBarCallMacOsMicrophoneAccessDenied: JSX.Element option with get, set
    abstract ErrorBarCallMicrophoneAccessDenied: JSX.Element option with get, set
    abstract ErrorBarCallMicrophoneMutedBySystem: JSX.Element option with get, set
    abstract ErrorBarCallNetworkQualityLow: JSX.Element option with get, set
    abstract ErrorBarCallNoMicrophoneFound: JSX.Element option with get, set
    abstract ErrorBarCallNoSpeakerFound: JSX.Element option with get, set
    abstract HorizontalGalleryLeftButton: JSX.Element option with get, set
    abstract HorizontalGalleryRightButton: JSX.Element option with get, set
    abstract LobbyScreenConnectingToCall: JSX.Element option with get, set
    abstract LobbyScreenWaitingToBeAdmitted: JSX.Element option with get, set
    abstract LocalDeviceSettingsCamera: JSX.Element option with get, set
    abstract LocalDeviceSettingsMic: JSX.Element option with get, set
    abstract LocalDeviceSettingsSpeaker: JSX.Element option with get, set
    abstract LocalPreviewPlaceholder: JSX.Element option with get, set
    abstract Muted: JSX.Element option with get, set
    abstract NetworkReconnectIcon: JSX.Element option with get, set
    abstract NoticePageAccessDeniedTeamsMeeting: JSX.Element option with get, set
    abstract NoticePageJoinCallFailedDueToNoNetwork: JSX.Element option with get, set
    abstract NoticePageLeftCall: JSX.Element option with get, set
    abstract NoticePageRemovedFromCall: JSX.Element option with get, set
    abstract OptionsCamera: JSX.Element option with get, set
    abstract OptionsMic: JSX.Element option with get, set
    abstract OptionsSpeaker: JSX.Element option with get, set
    abstract ParticipantItemMicOff: JSX.Element option with get, set
    abstract ParticipantItemScreenShareStart: JSX.Element option with get, set
    abstract VideoTileMicOff: JSX.Element option with get, set
    abstract LocalCameraSwitch: JSX.Element option with get, set
    abstract EditBoxCancel: JSX.Element option with get, set
    abstract EditBoxSubmit: JSX.Element option with get, set
    abstract MessageDelivered: JSX.Element option with get, set
    abstract MessageEdit: JSX.Element option with get, set
    abstract MessageFailed: JSX.Element option with get, set
    abstract MessageRemove: JSX.Element option with get, set
    abstract MessageSeen: JSX.Element option with get, set
    abstract MessageSending: JSX.Element option with get, set
    abstract SendBoxSend: JSX.Element option with get, set
    abstract SendBoxSendHovered: JSX.Element option with get, set
    abstract SendBoxAttachFile: JSX.Element option with get, set
    abstract ParticipantItemOptions: JSX.Element option with get, set
    abstract ParticipantItemOptionsHovered: JSX.Element option with get, set

/// <summary>Optional features of the <see cref="CallWithChatComposite" />.</summary>
type [<AllowNullLiteral>] CallWithChatCompositeOptions =
    /// Call control options to change what buttons show on the call-with-chat composite control bar.
    /// If using the boolean values, true will cause default behavior across the whole control bar. False hides the whole control bar.
    abstract callControls: U2<bool, CallWithChatControlOptions> option with get, set

/// <summary>Props required for the <see cref="CallWithChatComposite" /></summary>
type [<AllowNullLiteral>] CallWithChatCompositeProps =
    inherit BaseCompositeProps<CallWithChatCompositeIcons>
    abstract adapter: CallWithChatAdapter with get, set
    /// Fluent theme for the composite.
    ///
    /// Defaults to a light theme if undefined.
    abstract fluentTheme: U2<PartialTheme, Theme> option with get, set
    /// <summary>Optimizes the composite form factor for either desktop or mobile.</summary>
    /// <remarks><c>mobile</c> is currently only optimized for Portrait mode on mobile devices and does not support landscape.</remarks>
    /// <default>'desktop'</default>
    abstract formFactor: CallCompositePropsFormFactor option with get, set
    /// URL that can be used to copy a call-with-chat invite to the Users clipboard.
    abstract joinInvitationURL: string option with get, set
    /// <summary>Flags to enable/disable or customize UI elements of the <see cref="CallWithChatComposite" /></summary>
    abstract options: CallWithChatCompositeOptions option with get, set

/// <summary>
/// Strings used by the <see cref="CallWithChatComposite" /> directly.
///
/// This strings are in addition to those used by the components from the component library.
/// </summary>
type [<AllowNullLiteral>] CallWithChatCompositeStrings =
    /// <summary><see cref="CallWithChatComposite" /> control bar People button label</summary>
    abstract peopleButtonLabel: string with get, set
    /// <summary><see cref="CallWithChatComposite" /> control bar People button ToolTipContent</summary>
    abstract peopleButtonTooltipOpen: string with get, set
    /// <summary><see cref="CallWithChatComposite" /> control bar People button ToolTipContent</summary>
    abstract peopleButtonTooltipClose: string with get, set
    /// <summary><see cref="CallWithChatComposite" /> control bar Chat button label.</summary>
    abstract chatButtonLabel: string with get, set
    /// {@Link CallWithChatComposite} control bar Chat button ToolTipContent.
    abstract chatButtonTooltipOpen: string with get, set
    /// {@Link CallWithChatComposite} control bar Chat button ToolTipContent.
    abstract chatButtonTooltipClose: string with get, set
    /// <summary><see cref="CallWithChatComposite" /> control bar Chat button enhanced tooltip string.</summary>
    abstract chatButtonTooltipClosedWithMessageCount: string with get, set
    /// <summary>
    /// Title for the audio device selection sub-menu in more button drawer.
    ///
    /// Only used with <c>mobileView</c> set to <c>true</c> and when no speakers are available.
    /// </summary>
    abstract moreDrawerAudioDeviceMenuTitle: string option with get, set
    /// <summary>
    /// Title for the microphone selection sub-menu in more button drawer.
    ///
    /// Only used with <c>mobileView</c> set to <c>true</c> and when speakers are available.
    /// </summary>
    abstract moreDrawerMicrophoneMenuTitle: string with get, set
    /// <summary>
    /// Title for the speaker selection sub-menu in more button drawer.
    ///
    /// Only used with <c>mobileView</c> set to <c>true</c>.
    /// </summary>
    abstract moreDrawerSpeakerMenuTitle: string with get, set
    /// {@Link CallWithChatComposite} control bar More button label
    abstract moreDrawerButtonLabel: string with get, set
    /// {@Link CallWithChatComposite} control bar More button tooltip content
    abstract moreDrawerButtonTooltip: string with get, set
    /// Side pane People section Title.
    abstract peoplePaneTitle: string with get, set
    /// Side pane People section subheader.
    abstract peoplePaneSubTitle: string with get, set
    /// Side pane Chat screen title.
    abstract chatPaneTitle: string with get, set
    /// New Message label for chat button with notification icon component.
    abstract chatButtonNewMessageNotificationLabel: string with get, set
    /// <summary>
    /// Aria label for the picture in picture in picture tile that.
    /// This feature currently only shows on mobileView when the chat or people pane is expanded.
    /// </summary>
    /// <remarks>
    /// This component displays the local and most-dominant remote participant and when clicked
    /// returns the user to the call screen.
    /// </remarks>
    abstract pictureInPictureTileAriaLabel: string with get, set
    /// Label for menu item to remove participant
    abstract removeMenuLabel: string with get, set
    /// Label for button to copy invite link
    abstract copyInviteLinkButtonLabel: string with get, set
    /// Label for SidePaneHeader dismiss button
    abstract dismissSidePaneButtonLabel: string option with get, set
    /// Aria Description string for return to call button
    abstract returnToCallButtonAriaDescription: string option with get, set
    /// Aria label string for return to call back button
    abstract returnToCallButtonAriaLabel: string option with get, set

/// <summary><see cref="CallWithChatComposite" /> Call controls to show or hide buttons on the calling control bar.</summary>
type [<AllowNullLiteral>] CallWithChatControlOptions =
    /// <summary>
    /// <see cref="CallControlDisplayType" /> to change how the call controls are displayed.
    /// <c>'compact'</c> display type will decreases the size of buttons and hide the labels.
    /// </summary>
    /// <remarks>If the composite <c>formFactor</c> is set to <c>'mobile'</c>, the control bar will always use compact view.</remarks>
    /// <default>'default'</default>
    abstract displayType: CallControlDisplayType option with get, set
    /// <summary>Show or Hide Microphone button during a call.</summary>
    /// <default>true</default>
    abstract microphoneButton: bool option with get, set
    /// <summary>Show or Hide Camera Button during a call</summary>
    /// <default>true</default>
    abstract cameraButton: bool option with get, set
    /// <summary>Show, Hide or Disable the screen share button during a call.</summary>
    /// <default>true</default>
    abstract screenShareButton: U2<bool, {| disabled: bool |}> option with get, set
    /// <summary>Show or Hide EndCall button during a call.</summary>
    /// <default>true</default>
    abstract endCallButton: bool option with get, set
    /// <summary>Show or hide the chat button in the call-with-chat composite control bar.</summary>
    /// <default>true</default>
    abstract chatButton: bool option with get, set
    /// <summary>Show or hide the people button in the call-with-chat composite control bar.</summary>
    /// <default>true</default>
    abstract peopleButton: bool option with get, set

/// <summary>Events fired off by the <see cref="CallWithChatAdapter" />.</summary>
type [<StringEnum>] [<RequireQualifiedAccess>] CallWithChatEvent =
    | CallError
    | ChatError
    | CallEnded
    | IsMutedChanged
    | CallIdChanged
    | IsLocalScreenSharingActiveChanged
    | DisplayNameChanged
    | IsSpeakingChanged
    | CallParticipantsJoined
    | CallParticipantsLeft
    | MessageReceived
    | MessageSent
    | MessageRead
    | ChatParticipantsAdded
    | ChatParticipantsRemoved

/// <summary>Styles for the <see cref="CameraButton" /> menu.</summary>
type [<AllowNullLiteral>] CameraButtonContextualMenuStyles =
    inherit IContextualMenuStyles
    /// <summary>Styles for the items inside the <see cref="CameraButton" /> button menu.</summary>
    abstract menuItemStyles: IContextualMenuItemStyles option with get, set

/// <summary>Props for <see cref="CameraButton" /> component.</summary>
type [<AllowNullLiteral>] CameraButtonProps =
    inherit ControlBarButtonProps
    /// <summary>
    /// Utility property for using this component with <c>communication react eventHandlers</c>.
    /// Maps directly to the <c>onClick</c> property.
    /// </summary>
    abstract onToggleCamera: ((VideoStreamOptions) option -> Promise<unit>) option with get, set
    /// Options for rendering local video view.
    abstract localVideoViewOptions: VideoStreamOptions option with get, set
    /// Available cameras for selection
    abstract cameras: ResizeArray<OptionsDevice> option with get, set
    /// Camera that is shown as currently selected
    abstract selectedCamera: OptionsDevice option with get, set
    /// Callback when a camera is selected
    abstract onSelectCamera: (OptionsDevice -> Promise<unit>) option with get, set
    /// <summary>
    /// Whether to use a <see cref="SplitButton" /> with a <see cref="IContextualMenu" /> for device selection.
    ///
    /// default: false
    /// </summary>
    abstract enableDeviceSelectionMenu: bool option with get, set
    /// Optional strings to override in component
    abstract strings: obj option with get, set
    /// <summary>Styles for <see cref="CameraButton" /> and the device selection flyout.</summary>
    abstract styles: obj option with get, set

/// <summary>Selector type for <see cref="CameraButton" /> component.</summary>
type [<AllowNullLiteral>] CameraButtonSelector =
    /// <summary>Selector type for <see cref="CameraButton" /> component.</summary>
    [<Emit("$0($1...)")>] abstract Invoke: state: CallClientState * props: CallingBaseSelectorProps -> {| disabled: bool; ``checked``: bool; cameras: ResizeArray<VideoDeviceInfo>; selectedCamera: VideoDeviceInfo option |}

/// <summary>Strings of CameraButton that can be overridden.</summary>
type [<AllowNullLiteral>] CameraButtonStrings =
    /// Label when button is on.
    abstract onLabel: string with get, set
    /// Label when button is off.
    abstract offLabel: string with get, set
    /// Tooltip content when the button is disabled.
    abstract tooltipDisabledContent: string option with get, set
    /// Tooltip content when the button is on.
    abstract tooltipOnContent: string option with get, set
    /// Tooltip content when the button is off.
    abstract tooltipOffContent: string option with get, set
    /// Tooltip content when the button is disabled due to video loading.
    abstract tooltipVideoLoadingContent: string option with get, set
    /// Title of camera menu
    abstract cameraMenuTitle: string with get, set
    /// Tooltip of camera menu
    abstract cameraMenuTooltip: string with get, set
    /// description of camera button split button role
    abstract cameraButtonSplitRoleDescription: string option with get, set
    /// Camera split button aria label for when button is enabled.
    abstract onSplitButtonAriaLabel: string option with get, set
    /// Camera split button aria label for when button is disabled.
    abstract offSplitButtonAriaLabel: string option with get, set
    /// Camera action turned on string for announcer
    abstract cameraActionTurnedOnAnnouncement: string option with get, set
    /// Camera action turned off string for announcer
    abstract cameraActionTurnedOffAnnouncement: string option with get, set

/// <summary>Styles for <see cref="CameraButton" /></summary>
type [<AllowNullLiteral>] CameraButtonStyles =
    inherit ControlBarButtonStyles
    /// <summary>Styles for the <see cref="CameraButton" /> menu.</summary>
    abstract menuStyles: obj option with get, set

/// <summary><see cref="ChatComposite" /> Adapter interface.</summary>
type [<AllowNullLiteral>] ChatAdapter =
    interface end

/// <summary><see cref="ChatAdapter" /> state.</summary>
type [<AllowNullLiteral>] ChatAdapterState =
    interface end

/// <summary>Chat composite events that can be subscribed to.</summary>
type [<AllowNullLiteral>] ChatAdapterSubscribers =
    /// Subscribe function for 'messageReceived' event.
    [<Emit("$0.on('messageReceived',$1)")>] abstract on_messageReceived: listener: MessageReceivedListener -> unit
    /// Subscribe function for 'messageSent' event.
    [<Emit("$0.on('messageSent',$1)")>] abstract on_messageSent: listener: MessageSentListener -> unit
    /// Subscribe function for 'messageRead' event.
    [<Emit("$0.on('messageRead',$1)")>] abstract on_messageRead: listener: MessageReadListener -> unit
    /// Subscribe function for 'participantsAdded' event.
    [<Emit("$0.on('participantsAdded',$1)")>] abstract on_participantsAdded: listener: ParticipantsAddedListener -> unit
    /// Subscribe function for 'participantsRemoved' event.
    [<Emit("$0.on('participantsRemoved',$1)")>] abstract on_participantsRemoved: listener: ParticipantsRemovedListener -> unit
    /// Subscribe function for 'topicChanged' event.
    [<Emit("$0.on('topicChanged',$1)")>] abstract on_topicChanged: listener: TopicChangedListener -> unit
    /// Subscribe function for 'error' event.
    [<Emit("$0.on('error',$1)")>] abstract on_error: listener: (AdapterError -> unit) -> unit
    /// Unsubscribe function for 'messageReceived' event.
    [<Emit("$0.off('messageReceived',$1)")>] abstract off_messageReceived: listener: MessageReceivedListener -> unit
    /// Unsubscribe function for 'messageSent' event.
    [<Emit("$0.off('messageSent',$1)")>] abstract off_messageSent: listener: MessageSentListener -> unit
    /// Unsubscribe function for 'messageRead' event.
    [<Emit("$0.off('messageRead',$1)")>] abstract off_messageRead: listener: MessageReadListener -> unit
    /// Unsubscribe function for 'participantsAdded' event.
    [<Emit("$0.off('participantsAdded',$1)")>] abstract off_participantsAdded: listener: ParticipantsAddedListener -> unit
    /// Unsubscribe function for 'participantsRemoved' event.
    [<Emit("$0.off('participantsRemoved',$1)")>] abstract off_participantsRemoved: listener: ParticipantsRemovedListener -> unit
    /// Unsubscribe function for 'topicChanged' event.
    [<Emit("$0.off('topicChanged',$1)")>] abstract off_topicChanged: listener: TopicChangedListener -> unit
    /// Unsubscribe function for 'error' event.
    [<Emit("$0.off('error',$1)")>] abstract off_error: listener: (AdapterError -> unit) -> unit

/// <summary>Functionality for managing the current chat thread.</summary>
type [<AllowNullLiteral>] ChatAdapterThreadManagement =
    /// Fetch initial state for the Chat adapter.
    ///
    /// Performs the minimal fetch necessary for ChatComposite and API methods.
    abstract fetchInitialData: unit -> Promise<unit>
    /// Send a message in the thread.
    abstract sendMessage: content: string * ?options: SendMessageOptions -> Promise<unit>
    /// Send a read receipt for a message.
    abstract sendReadReceipt: chatMessageId: string -> Promise<unit>
    /// Send typing indicator in the thread.
    abstract sendTypingIndicator: unit -> Promise<unit>
    /// Remove a participant in the thread.
    abstract removeParticipant: userId: string -> Promise<unit>
    /// Set the topic for the thread.
    abstract setTopic: topicName: string -> Promise<unit>
    /// Update a message content.
    abstract updateMessage: messageId: string * content: string * ?metadata: Record<string, string> -> Promise<unit>
    /// Delete a message in the thread.
    abstract deleteMessage: messageId: string -> Promise<unit>
    /// <summary>Load more previous messages in the chat thread history.</summary>
    /// <remarks>This method is usually used to control incremental fetch/infinite scroll</remarks>
    abstract loadPreviousChatMessages: messagesToLoad: float -> Promise<bool>

/// <summary><see cref="ChatAdapter" /> state for pure UI purposes.</summary>
type [<AllowNullLiteral>] ChatAdapterUiState =
    abstract error: Error option with get, set

/// <summary>Common props for selectors for <see cref="ChatClientState" />.</summary>
type [<AllowNullLiteral>] ChatBaseSelectorProps =
    abstract threadId: string with get, set

/// <summary>Arguments to initialize a <see cref="ChatClientProvider" />.</summary>
type [<AllowNullLiteral>] ChatClientProviderProps =
    abstract children: React_2.ReactNode with get, set
    abstract chatClient: StatefulChatClient with get, set

/// <summary>Centralized state for <see cref="@azure/communication-chat.ChatClient" />.</summary>
type [<AllowNullLiteral>] ChatClientState =
    /// Identifier of the current user.
    abstract userId: CommunicationIdentifierKind with get, set
    /// <summary>
    /// DisplayName of the current user.
    /// The same value as what others see in <see cref="@azure/communication-chat.ChatParticipant.displayName" />
    /// </summary>
    abstract displayName: string with get, set
    /// <summary>
    /// Chat threads joined by the current user.
    /// Object with <see cref="ChatThreadClientState" /> fields, keyed by <see cref="ChatThreadClientState.threadId" />.
    /// </summary>
    abstract threads: ChatClientStateThreads with get, set
    /// <summary>
    /// Stores the latest error for each API method.
    ///
    /// See documentation of <see cref="ChatErrors" /> for details.
    /// </summary>
    abstract latestErrors: ChatErrors with get, set

/// <summary><see cref="ChatAdapter" /> state inferred from Azure Communication Services backend.</summary>
type [<AllowNullLiteral>] ChatCompositeClientState =
    abstract userId: CommunicationIdentifierKind with get, set
    abstract displayName: string with get, set
    abstract thread: ChatThreadClientState with get, set
    /// Latest error encountered for each operation performed via the adapter.
    abstract latestErrors: AdapterErrors with get, set

/// <summary>Icons that can be overridden for <see cref="ChatComposite" />.</summary>
type [<AllowNullLiteral>] ChatCompositeIcons =
    abstract EditBoxCancel: JSX.Element option with get, set
    abstract EditBoxSubmit: JSX.Element option with get, set
    abstract MessageDelivered: JSX.Element option with get, set
    abstract MessageEdit: JSX.Element option with get, set
    abstract MessageFailed: JSX.Element option with get, set
    abstract MessageRemove: JSX.Element option with get, set
    abstract MessageSeen: JSX.Element option with get, set
    abstract MessageSending: JSX.Element option with get, set
    abstract ParticipantItemOptions: JSX.Element option with get, set
    abstract ParticipantItemOptionsHovered: JSX.Element option with get, set
    abstract SendBoxSend: JSX.Element option with get, set
    abstract SendBoxSendHovered: JSX.Element option with get, set

/// <summary>Optional features of the <see cref="ChatComposite" />.</summary>
type [<AllowNullLiteral>] ChatCompositeOptions =
    /// <summary>
    /// Surface Azure Communication Services backend errors in the UI with <see cref="@azure/communication-react.ErrorBar" />.
    /// Hide or show the error bar.
    /// </summary>
    /// <default>true</default>
    abstract errorBar: bool option with get, set
    /// <summary>Show or hide the topic at the top of the chat. Hidden if set to <c>false</c></summary>
    /// <default>true</default>
    abstract topic: bool option with get, set
    /// enumerable to determine if the input box has focus on render or not.
    /// When undefined nothing has focus on render
    abstract autoFocus: string option with get, set

/// <summary>Props for <see cref="ChatComposite" />.</summary>
type [<AllowNullLiteral>] ChatCompositeProps =
    inherit BaseCompositeProps<ChatCompositeIcons>
    /// An adapter provides logic and data to the composite.
    /// Composite can also be controlled using the adapter.
    abstract adapter: ChatAdapter with get, set
    /// <summary>
    /// <c>(messageProps: MessageProps, defaultOnRender?: MessageRenderer) =&gt; JSX.Element</c>
    /// A callback for customizing the message renderer.
    /// </summary>
    abstract onRenderMessage: (MessageProps -> (MessageRenderer) option -> JSX.Element) option with get, set
    /// <summary>
    /// <c>(typingUsers: CommunicationParticipant[]) =&gt; JSX.Element</c>
    /// A callback for customizing the typing indicator renderer.
    /// </summary>
    abstract onRenderTypingIndicator: (ResizeArray<CommunicationParticipant> -> JSX.Element) option with get, set
    /// <summary>Flags to enable/disable visual elements of the <see cref="ChatComposite" />.</summary>
    abstract options: ChatCompositeOptions option with get, set

/// <summary>
/// Strings used by the <see cref="ChatComposite" /> directly.
///
/// This strings are in addition to those used by the components from the component library.
/// </summary>
type [<AllowNullLiteral>] ChatCompositeStrings =
    /// Chat list header text
    abstract chatListHeader: string with get, set

/// <summary>Error thrown from failed <see cref="StatefulChatClient" /> methods.</summary>
type [<AllowNullLiteral>] ChatError =
    inherit Error
    /// The API method target that failed.
    abstract target: ChatErrorTarget with get, set
    /// Error thrown by the failed SDK method.
    abstract innerError: Error with get, set
    /// Timestamp added to the error by the stateful layer.
    abstract timestamp: DateTime with get, set

/// <summary>Error thrown from failed <see cref="StatefulChatClient" /> methods.</summary>
type [<AllowNullLiteral>] ChatErrorStatic =
    [<EmitConstructor>] abstract Create: target: ChatErrorTarget * innerError: Error * ?timestamp: DateTime -> ChatError

/// <summary>Selector type for <see cref="ErrorBar" /> component.</summary>
type [<AllowNullLiteral>] ChatErrorBarSelector =
    /// <summary>Selector type for <see cref="ErrorBar" /> component.</summary>
    [<Emit("$0($1...)")>] abstract Invoke: state: ChatClientState * props: ChatBaseSelectorProps -> {| activeErrorMessages: ResizeArray<ActiveErrorMessage> |}

/// <summary>
/// Errors teed from API calls to the Chat SDK.
///
/// Each property in the object stores the latest error for a particular SDK API method.
/// </summary>
type [<AllowNullLiteral>] ChatErrors =
    interface end

/// <summary>String literal type for all permissible keys in <see cref="ChatErrors" />.</summary>
type [<StringEnum>] [<RequireQualifiedAccess>] ChatErrorTarget =
    | [<CompiledName("ChatClient.createChatThread")>] ChatClient_createChatThread
    | [<CompiledName("ChatClient.deleteChatThread")>] ChatClient_deleteChatThread
    | [<CompiledName("ChatClient.getChatThreadClient")>] ChatClient_getChatThreadClient
    | [<CompiledName("ChatClient.listChatThreads")>] ChatClient_listChatThreads
    | [<CompiledName("ChatClient.off")>] ChatClient_off
    | [<CompiledName("ChatClient.on")>] ChatClient_on
    | [<CompiledName("ChatClient.startRealtimeNotifications")>] ChatClient_startRealtimeNotifications
    | [<CompiledName("ChatClient.stopRealtimeNotifications")>] ChatClient_stopRealtimeNotifications
    | [<CompiledName("ChatThreadClient.addParticipants")>] ChatThreadClient_addParticipants
    | [<CompiledName("ChatThreadClient.deleteMessage")>] ChatThreadClient_deleteMessage
    | [<CompiledName("ChatThreadClient.getMessage")>] ChatThreadClient_getMessage
    | [<CompiledName("ChatThreadClient.getProperties")>] ChatThreadClient_getProperties
    | [<CompiledName("ChatThreadClient.listMessages")>] ChatThreadClient_listMessages
    | [<CompiledName("ChatThreadClient.listParticipants")>] ChatThreadClient_listParticipants
    | [<CompiledName("ChatThreadClient.listReadReceipts")>] ChatThreadClient_listReadReceipts
    | [<CompiledName("ChatThreadClient.removeParticipant")>] ChatThreadClient_removeParticipant
    | [<CompiledName("ChatThreadClient.sendMessage")>] ChatThreadClient_sendMessage
    | [<CompiledName("ChatThreadClient.sendReadReceipt")>] ChatThreadClient_sendReadReceipt
    | [<CompiledName("ChatThreadClient.sendTypingNotification")>] ChatThreadClient_sendTypingNotification
    | [<CompiledName("ChatThreadClient.updateMessage")>] ChatThreadClient_updateMessage
    | [<CompiledName("ChatThreadClient.updateTopic")>] ChatThreadClient_updateTopic

/// <summary>
/// Object containing all the handlers required for chat components.
///
/// Chat related components from this package are able to pick out relevant handlers from this object.
/// See <see cref="useHandlers" /> and <see cref="usePropsFor" />.
/// </summary>
type [<AllowNullLiteral>] ChatHandlers =
    abstract onSendMessage: (string -> (SendMessageOptions) option -> Promise<unit>) with get, set
    abstract onMessageSeen: (string -> Promise<unit>) with get, set
    abstract onTyping: (unit -> Promise<unit>) with get, set
    abstract onRemoveParticipant: (string -> Promise<unit>) with get, set
    abstract updateThreadTopicName: (string -> Promise<unit>) with get, set
    abstract onLoadPreviousChatMessages: (float -> Promise<bool>) with get, set
    abstract onUpdateMessage: (string -> string -> Promise<unit>) with get, set
    abstract onDeleteMessage: (string -> Promise<unit>) with get, set

/// <summary>A chat message.</summary>
type [<AllowNullLiteral>] ChatMessage =
    inherit MessageCommon
    abstract messageType: string with get, set
    abstract content: string option with get, set
    abstract editedOn: DateTime option with get, set
    abstract deletedOn: DateTime option with get, set
    abstract senderId: string option with get, set
    abstract senderDisplayName: string option with get, set
    abstract status: MessageStatus option with get, set
    abstract attached: MessageAttachedStatus option with get, set
    abstract mine: bool option with get, set
    abstract clientMessageId: string option with get, set
    abstract contentType: MessageContentType with get, set
    /// <summary>
    /// A metadata field for the message.
    /// <see cref="@azure/communication-chat.ChatMessage.metadata" />
    /// </summary>
    abstract metadata: Record<string, string> option with get, set

/// <summary>
/// An extension to <see cref="@azure/communication-chat.ChatMessage" /> that stores
/// client-side only metadata for chat messages.
///
/// TODO: The name has bitrotted. Rename me.
/// </summary>
type [<AllowNullLiteral>] ChatMessageWithStatus =
    interface end

/// <summary>Selector type for <see cref="ParticipantList" /> component.</summary>
type [<AllowNullLiteral>] ChatParticipantListSelector =
    /// <summary>Selector type for <see cref="ParticipantList" /> component.</summary>
    [<Emit("$0($1...)")>] abstract Invoke: state: ChatClientState * props: ChatBaseSelectorProps -> {| myUserId: string; participants: ResizeArray<ParticipantListParticipant> |}

/// <summary>Helper type for <see cref="usePropsFor" />.</summary>
type ChatReturnProps<'Component> =
    obj

/// <summary>Arguments to initialize a <see cref="ChatThreadClientProvider" />.</summary>
type [<AllowNullLiteral>] ChatThreadClientProviderProps =
    abstract children: React_2.ReactNode with get, set
    abstract chatThreadClient: ChatThreadClient with get, set

/// <summary>Centralized state for <see cref="@azure/communication-chat.ChatThreadClient" />.</summary>
type [<AllowNullLiteral>] ChatThreadClientState =
    /// <summary>
    /// Messages in this thread.
    /// Object with <see cref="ChatMessageWithStatus" /> entries
    /// Local messages are keyed by keyed by <see cref="ChatMessageWithStatus.clientMessageId" />.
    /// Remote messages are keyed by <see cref="@azure/communication-chat.ChatMessage.id" />.
    /// </summary>
    abstract chatMessages: ChatThreadClientStateChatMessages with get, set
    /// <summary>
    /// Participants of this chat thread.
    ///
    /// Object with <see cref="@azure/communication-chat.ChatParticipant" /> fields,
    /// keyed by <see cref="@azure/communication-chat.ChatParticipant.id" />.
    /// </summary>
    abstract participants: ChatThreadClientStateParticipants with get, set
    /// <summary>Id of this chat thread. Returned from <see cref="@azure/communication-chat.ChatThreadClient.threadId" /></summary>
    abstract threadId: string with get, set
    /// An object containing properties of this chat thread.
    abstract properties: ChatThreadProperties option with get, set
    /// <summary>An array of ReadReceipts of this chat thread. Returned from <see cref="@azure/communication-chat.ChatThreadClient.listReadReceipts" /></summary>
    abstract readReceipts: ResizeArray<ChatMessageReadReceipt> with get, set
    /// <summary>
    /// An array of typingIndicators of this chat thread. Captured from event listener of <see cref="@azure/communication-chat.ChatClient" />
    /// Stateful client only stores recent 8000ms real-time typing indicators data.
    /// </summary>
    abstract typingIndicators: ResizeArray<TypingIndicatorReceivedEvent> with get, set
    /// Latest timestamp when other users read messages sent by current user.
    abstract latestReadTime: DateTime with get, set

/// <summary>
/// Properties of a chat thread.
///
/// We define a minimal one that helps us hide the different types used by underlying API.
/// </summary>
type [<AllowNullLiteral>] ChatThreadProperties =
    abstract topic: string option with get, set

/// <summary>
/// Centralized state for <see cref="@azure/communication-calling.CallClient" /> or <see cref="@azure/communication-chat.ChatClient" />.
///
/// See also: <see cref="CallClientState" />, <see cref="ChatClientState" />.
/// </summary>
type [<AllowNullLiteral>] ClientState =
    interface end

/// <summary>Return intersect type of 2 types</summary>
type Common<'A, 'B> =
    obj

/// <summary>Return intersect properties of 2 types</summary>
type CommonProperties<'A, 'B> =
    obj

/// <summary>A Chat or Calling participant's state, as reflected in the UI.</summary>
type [<AllowNullLiteral>] CommunicationParticipant =
    /// User ID of participant
    abstract userId: string with get, set
    /// Display name of participant
    abstract displayName: string option with get, set

/// <summary>Icons used by the React components exported from this library.</summary>
/// <remarks>See <see cref="CompositeIcons" /> for icons used by composites only.</remarks>
type ComponentIcons =
    Record<KeyOf<obj>, JSX.Element>

/// <summary>Locale information for all components exported from this library.</summary>
type [<AllowNullLiteral>] ComponentLocale =
    /// Strings for components
    abstract strings: ComponentStrings with get, set

/// <summary>Helper type for <see cref="usePropsFor" />.</summary>
type ComponentProps<'Component> =
    obj

/// <summary>Strings used by all components exported from this library.</summary>
type [<AllowNullLiteral>] ComponentStrings =
    /// Strings for MessageThread
    abstract messageThread: MessageThreadStrings with get, set
    /// Strings for ParticipantItem
    abstract participantItem: ParticipantItemStrings with get, set
    /// Strings for CameraButton
    abstract cameraButton: CameraButtonStrings with get, set
    /// Strings for MicrophoneButton
    abstract microphoneButton: MicrophoneButtonStrings with get, set
    /// Strings for EndCallButton
    abstract endCallButton: EndCallButtonStrings with get, set
    /// Strings for DevicesButton
    abstract devicesButton: DevicesButtonStrings with get, set
    /// Strings for ParticipantsButton
    abstract participantsButton: ParticipantsButtonStrings with get, set
    /// Strings for ScreenShareButton
    abstract screenShareButton: ScreenShareButtonStrings with get, set
    /// Strings for TypingIndicator
    abstract typingIndicator: TypingIndicatorStrings with get, set
    /// Strings for SendBox
    abstract sendBox: SendBoxStrings with get, set
    /// Strings for MessageStatusIndicator
    abstract messageStatusIndicator: MessageStatusIndicatorStrings with get, set
    /// Strings for ErroBar
    abstract errorBar: ErrorBarStrings with get, set
    /// Strings for VideoGallery
    abstract videoGallery: VideoGalleryStrings with get, set

/// <summary>
/// Icons that can be overridden in one of the composites exported by this library.
///
/// See <see cref="ChatCompositeIcons" />, <see cref="CallCompositeIcons" /> and <see cref="CallWithChatCompositeIcons" /> for more targeted types.
/// </summary>
type [<AllowNullLiteral>] CompositeIcons =
    interface end

/// <summary>Locale information for all composites exported from this library.</summary>
type [<AllowNullLiteral>] CompositeLocale =
    /// <summary>
    /// Strings used in composites directly
    ///
    /// Contrast with <see cref="CompositeLocale.component" />, which contains strings used via the component library.
    /// </summary>
    abstract strings: CompositeStrings with get, set
    /// <summary>Locale information for the pure Components used by Composites. See <see cref="communication-react.ComponentLocale" />.</summary>
    abstract ``component``: ComponentLocale with get, set

/// <summary>
/// Strings used in the composites directly.
///
/// These strings are used by the composites directly, instead of by the contained components.
/// </summary>
type [<AllowNullLiteral>] CompositeStrings =
    /// <summary>Strings used by <see cref="CallComposite" />.</summary>
    abstract call: CallCompositeStrings with get, set
    /// <summary>Strings used by <see cref="ChatComposite" />.</summary>
    abstract chat: ChatCompositeStrings with get, set
    /// <summary>Strings used by <see cref="CallWithChatComposite" />.</summary>
    abstract callWithChat: CallWithChatCompositeStrings with get, set

/// <summary>A system message with arbitary content.</summary>
type [<AllowNullLiteral>] ContentSystemMessage =
    inherit SystemMessageCommon
    abstract systemMessageType: string with get, set
    abstract content: string with get, set

/// <summary>Props for <see cref="ControlBarButton" />.</summary>
type [<AllowNullLiteral>] ControlBarButtonProps =
    inherit IButtonProps
    /// <summary>Whether the label is displayed or not.</summary>
    /// <default><c>false</c></default>
    abstract showLabel: bool option with get, set
    /// Key to use for the Label component
    abstract labelKey: string option with get, set
    /// <summary>Id to use for the tooltip host.</summary>
    /// <default>This uses the labelKey and appends -tooltip by default</default>
    abstract tooltipId: string option with get, set
    /// Optional strings to override in component.
    abstract strings: ControlBarButtonStrings option with get, set
    /// Icon to render when the button is checked.
    abstract onRenderOnIcon: IRenderFunction<IButtonProps> option with get, set
    /// Icon to render when the button is not checked.
    abstract onRenderOffIcon: IRenderFunction<IButtonProps> option with get, set
    /// <summary>Fluent styles, including extensions common to all <see cref="ControlBarButton" />s.</summary>
    abstract styles: ControlBarButtonStyles option with get, set

/// <summary>Strings of <see cref="ControlBarButton" /> that can be overridden.</summary>
type [<AllowNullLiteral>] ControlBarButtonStrings =
    /// Label of the button. This supersedes onLabel or offLabel if used.
    abstract label: string option with get, set
    /// Label of the button shown when the button is checked.
    abstract onLabel: string option with get, set
    /// Label of the button shown when the button is not checked.
    abstract offLabel: string option with get, set
    /// Tooltip content of the button. This supersedes tooltipDisabledContent, tooltipOnContent and tooltipOffContent if used.
    abstract tooltipContent: string option with get, set
    /// Tooltip content when the button is disabled.
    abstract tooltipDisabledContent: string option with get, set
    /// Tooltip content when the button is in the checked state.
    abstract tooltipOnContent: string option with get, set
    /// Tooltip content when the button is in the unchecked state.
    abstract tooltipOffContent: string option with get, set

/// <summary>Styles for all <see cref="ControlBarButton" /> implementations.</summary>
type ControlBarButtonStyles =
    IButtonStyles

/// <summary>Present layouts for the <see cref="ControlBar" />.</summary>
type [<StringEnum>] [<RequireQualifiedAccess>] ControlBarLayout =
    | Horizontal
    | Vertical
    | DockedTop
    | DockedBottom
    | DockedLeft
    | DockedRight
    | FloatingTop
    | FloatingBottom
    | FloatingLeft
    | FloatingRight

/// <summary>Props for <see cref="ControlBar" />.</summary>
type [<AllowNullLiteral>] ControlBarProps =
    /// React Child components.
    abstract children: React_2.ReactNode option with get, set
    /// <summary>Allows users to pass an object containing custom CSS styles.</summary>
    /// <example>
    /// <code>
    /// &lt;ControlBar styles={{ root: { background: 'blue' } }} /&gt;
    /// </code>
    /// </example>
    abstract styles: BaseCustomStyles option with get, set
    /// <summary>
    /// Changes the layout of the control bar.
    /// Available layouts are <c>horizontal</c>, <c>vertical</c>, <c>dockedTop</c>, <c>dockedBottom</c>,
    /// <c>dockedLeft</c>, <c>dockedRight</c>, <c>floatingTop</c>, <c>floatingBottom</c>, <c>floatingLeft</c>,
    /// <c>floatingRight</c>
    /// Defaults to a <c>horizontal</c> layout.
    /// </summary>
    abstract layout: ControlBarLayout option with get, set

/// <summary>
/// Object returned after creating a local or remote VideoStream.
/// This contains helper functions to manipulate the render of the stream.
/// </summary>
type [<AllowNullLiteral>] CreateVideoStreamViewResult =
    /// View handle of the rendered video stream
    abstract view: {| updateScalingMode: ViewScalingMode -> Promise<unit> |} with get, set

/// <summary>Return result from <see cref="StatefulCallClient.createView" />.</summary>
type [<AllowNullLiteral>] CreateViewResult =
    abstract renderer: VideoStreamRenderer with get, set
    abstract view: VideoStreamRendererView with get, set

/// <summary>
/// Options that can be injected into the <c>onRender</c> function for customizing an
/// Avatar (<c>Persona</c>) component.
/// </summary>
type [<AllowNullLiteral>] CustomAvatarOptions =
    /// Persona coin size in pixels
    abstract coinSize: float option with get, set
    /// Only show Coin and Initials
    abstract hidePersonaDetails: bool option with get, set
    /// Text color of initials inside the coin
    abstract initialsTextColor: string option with get, set
    /// Optional property to set the aria label of the video tile if there is no available stream.
    abstract noVideoAvailableAriaLabel: string option with get, set
    /// User status
    abstract presence: PersonaPresence option with get, set
    /// Preset Persona Size number
    abstract size: PersonaSize option with get, set
    /// Custom style for the Avatar
    abstract styles: IStyleFunctionOrObject<IPersonaStyleProps, IPersonaStyles> option with get, set
    /// Display name to be used in Persona
    abstract text: string option with get, set

/// <summary>
/// A custom message type.
///
/// Custom messages are not rendered by default, but applications can provide custom renderers for them.
/// </summary>
type [<AllowNullLiteral>] CustomMessage =
    inherit MessageCommon
    abstract messageType: string with get, set
    abstract content: string with get, set

/// <summary>
/// This type is meant to encapsulate all the state inside <see cref="@azure/communication-calling.DeviceManager" />. For
/// optional parameters they may not be available until permission is granted by the user. The cameras, microphones,
/// speakers, and deviceAccess states will be empty until the corresponding
/// <see cref="@azure/communication-calling.DeviceManager" />'s getCameras, getMicrophones, getSpeakers, and askDevicePermission
/// APIs are called and completed.
/// </summary>
type [<AllowNullLiteral>] DeviceManagerState =
    /// <summary>Proxy of <see cref="@azure/communication-calling.DeviceManager.isSpeakerSelectionAvailable" />.</summary>
    abstract isSpeakerSelectionAvailable: bool with get, set
    /// <summary>Proxy of <see cref="@azure/communication-calling.DeviceManager.selectedMicrophone" />.</summary>
    abstract selectedMicrophone: AudioDeviceInfo option with get, set
    /// <summary>Proxy of <see cref="@azure/communication-calling.DeviceManager.selectedSpeaker" />.</summary>
    abstract selectedSpeaker: AudioDeviceInfo option with get, set
    /// <summary>
    /// Stores the selected camera device info. This is added by the stateful layer and does not exist in the Calling SDK.
    /// It is meant as a convenience to the developer. It must be explicitly set before it has any value and does not
    /// persist across instances of the <see cref="StatefulCallClient" />. The developer controls entirely what this value holds
    /// at any time.
    /// </summary>
    abstract selectedCamera: VideoDeviceInfo option with get, set
    /// <summary>Stores any cameras data returned from <see cref="@azure/communication-calling.DeviceManager.getCameras" />.</summary>
    abstract cameras: ResizeArray<VideoDeviceInfo> with get, set
    /// <summary>Stores any microphones data returned from <see cref="@azure/communication-calling.DeviceManager.getMicrophones" />.</summary>
    abstract microphones: ResizeArray<AudioDeviceInfo> with get, set
    /// <summary>Stores any speakers data returned from <see cref="@azure/communication-calling.DeviceManager.getSpeakers" />.</summary>
    abstract speakers: ResizeArray<AudioDeviceInfo> with get, set
    /// <summary>Stores deviceAccess data returned from <see cref="@azure/communication-calling.DeviceManager.askDevicePermission" />.</summary>
    abstract deviceAccess: DeviceAccess option with get, set
    /// <summary>
    /// Stores created views that are not associated with any CallState (when <see cref="StatefulCallClient.createView" /> is
    /// called with undefined callId, undefined participantId, and defined LocalVideoStream).
    ///
    /// The values in this array are generated internally when <see cref="StatefulCallClient.createView" /> is called and are
    /// considered immutable.
    /// </summary>
    abstract unparentedViews: ResizeArray<LocalVideoStreamState> with get, set

/// <summary>Styles for the <see cref="DevicesButton" /> menu.</summary>
type [<AllowNullLiteral>] DevicesButtonContextualMenuStyles =
    inherit IContextualMenuStyles
    /// <summary>Styles for the items inside the <see cref="DevicesButton" /> button menu.</summary>
    abstract menuItemStyles: IContextualMenuItemStyles option with get, set

/// <summary>Props for <see cref="DevicesButton" />.</summary>
type [<AllowNullLiteral>] DevicesButtonProps =
    inherit ControlBarButtonProps
    /// Available microphones for selection
    abstract microphones: ResizeArray<OptionsDevice> option with get, set
    /// Available speakers for selection
    abstract speakers: ResizeArray<OptionsDevice> option with get, set
    /// Available cameras for selection
    abstract cameras: ResizeArray<OptionsDevice> option with get, set
    /// Microphone that is shown as currently selected
    abstract selectedMicrophone: OptionsDevice option with get, set
    /// Speaker that is shown as currently selected
    abstract selectedSpeaker: OptionsDevice option with get, set
    /// Camera that is shown as currently selected
    abstract selectedCamera: OptionsDevice option with get, set
    /// Callback when a camera is selected
    abstract onSelectCamera: (OptionsDevice -> Promise<unit>) option with get, set
    /// Callback when a microphone is selected
    abstract onSelectMicrophone: (OptionsDevice -> Promise<unit>) option with get, set
    /// Speaker when a speaker is selected
    abstract onSelectSpeaker: (OptionsDevice -> Promise<unit>) option with get, set
    /// Optional strings to override in component
    abstract strings: obj option with get, set
    /// Option to increase the touch targets of the button flyout menu items from 36px to 48px.
    /// Recommended for mobile devices.
    abstract styles: DevicesButtonStyles option with get, set

/// <summary>Selector type for <see cref="DevicesButton" /> component.</summary>
type [<AllowNullLiteral>] DevicesButtonSelector =
    /// <summary>Selector type for <see cref="DevicesButton" /> component.</summary>
    [<Emit("$0($1...)")>] abstract Invoke: state: CallClientState * props: CallingBaseSelectorProps -> DevicesButtonSelectorInvokeReturn

type [<AllowNullLiteral>] DevicesButtonSelectorInvokeReturn =
    abstract microphones: ResizeArray<AudioDeviceInfo> with get, set
    abstract speakers: ResizeArray<AudioDeviceInfo> with get, set
    abstract cameras: ResizeArray<VideoDeviceInfo> with get, set
    abstract selectedMicrophone: AudioDeviceInfo option with get, set
    abstract selectedSpeaker: AudioDeviceInfo option with get, set
    abstract selectedCamera: VideoDeviceInfo option with get, set

/// <summary>Strings of <see cref="DevicesButton" /> that can be overridden.</summary>
type [<AllowNullLiteral>] DevicesButtonStrings =
    /// Label of button
    abstract label: string with get, set
    /// Button tooltip content.
    abstract tooltipContent: string option with get, set
    /// Title of camera menu
    abstract cameraMenuTitle: string with get, set
    /// Title of microphone menu
    abstract microphoneMenuTitle: string with get, set
    /// Title of speaker menu
    abstract speakerMenuTitle: string with get, set
    /// Tooltip of camera menu
    abstract cameraMenuTooltip: string with get, set
    /// Tooltip of microphone menu
    abstract microphoneMenuTooltip: string with get, set
    /// Tooltip of speaker menu
    abstract speakerMenuTooltip: string with get, set

/// <summary>Styles for the Devices button menu items.</summary>
type [<AllowNullLiteral>] DevicesButtonStyles =
    inherit ControlBarButtonStyles
    /// <summary>Styles for the <see cref="DevicesButton" /> menu.</summary>
    abstract menuStyles: obj option with get, set

/// <summary>Callback for <see cref="CallAdapterSubscribers" /> 'diagnosticChanged' event.</summary>
type [<AllowNullLiteral>] DiagnosticChangedEventListner =
    /// <summary>Callback for <see cref="CallAdapterSubscribers" /> 'diagnosticChanged' event.</summary>
    [<Emit("$0($1...)")>] abstract Invoke: ``event``: U2<MediaDiagnosticChangedEvent, NetworkDiagnosticChangedEvent> -> unit

/// <summary>State only proxy for <see cref="@azure/communication-calling.DiagnosticsCallFeature" />.</summary>
type [<AllowNullLiteral>] DiagnosticsCallFeatureState =
    /// Stores diagnostics related to network conditions.
    abstract network: NetworkDiagnosticsState with get, set
    /// Stores diagnostics related to media quality.
    abstract media: MediaDiagnosticsState with get, set

/// <summary>Callback for <see cref="CallAdapterSubscribers" /> 'displayNameChanged' event.</summary>
type [<AllowNullLiteral>] DisplayNameChangedListener =
    /// <summary>Callback for <see cref="CallAdapterSubscribers" /> 'displayNameChanged' event.</summary>
    [<Emit("$0($1...)")>] abstract Invoke: ``event``: {| participantId: CommunicationIdentifierKind; displayName: string |} -> unit

/// <summary>Functionality for correctly disposing a Composite.</summary>
type [<AllowNullLiteral>] Disposable =
    /// Dispose of the Composite
    abstract dispose: unit -> unit

/// <summary>
/// A type for trivial selectors that return no data.
///
/// Used as a default return value if <see cref="usePropsFor" /> is called for a component that requires no data.
/// </summary>
type [<AllowNullLiteral>] EmptySelector =
    /// <summary>
    /// A type for trivial selectors that return no data.
    ///
    /// Used as a default return value if <see cref="usePropsFor" /> is called for a component that requires no data.
    /// </summary>
    [<Emit("$0($1...)")>] abstract Invoke: unit -> Record<string, obj>

/// <summary>Props for <see cref="EndCallButton" />.</summary>
type [<AllowNullLiteral>] EndCallButtonProps =
    inherit ControlBarButtonProps
    /// <summary>
    /// Utility property for using this component with <c>communication react eventHandlers</c>.
    /// Maps directly to the <c>onClick</c> property.
    /// </summary>
    abstract onHangUp: (unit -> Promise<unit>) option with get, set
    /// Optional strings to override in component
    abstract strings: EndCallButtonStrings option with get, set

/// <summary>Strings of <see cref="EndCallButton" /> that can be overridden.</summary>
type [<AllowNullLiteral>] EndCallButtonStrings =
    /// Label of button
    abstract label: string with get, set
    /// Tooltip content.
    abstract tooltipContent: string option with get, set

/// <summary>
/// Props for <see cref="ErrorBar" />.
///
/// In addition to the following, <see cref="ErrorBar" /> forwards all
/// <see cref="@fluentui/react.IMessageBarProps" /> to the underlying <see cref="@fluentui/react.MessageBar" />.
/// </summary>
type [<AllowNullLiteral>] ErrorBarProps =
    inherit IMessageBarProps
    /// Strings shown on the UI on errors.
    abstract strings: ErrorBarStrings option with get, set
    /// Currently active errors.
    abstract activeErrorMessages: ResizeArray<ActiveErrorMessage> with get, set

/// <summary>All strings that may be shown on the UI in the <see cref="ErrorBar" />.</summary>
type [<AllowNullLiteral>] ErrorBarStrings =
    /// Unable to reach Chat service.
    ///
    /// This can mean:
    ///    - Incorrect Azure Communication Services endpoint was provided.
    ///    - User's network connection is down.
    abstract unableToReachChatService: string with get, set
    /// User does not have access to the Chat service.
    /// This usually means that either the Azure Communication Services endpiont or the token provided are incorrect.
    abstract accessDenied: string with get, set
    /// <summary>
    /// User is no longer on the thread.
    ///
    /// See also: <see cref="ErrorBarStrings.sendMessageNotInChatThread" /> for a more specific error.
    /// </summary>
    abstract userNotInChatThread: string with get, set
    /// Sending message failed because user is no longer on the thread.
    abstract sendMessageNotInChatThread: string with get, set
    /// A generic message when sending message fails.
    /// Prefer more specific error strings when possible.
    abstract sendMessageGeneric: string with get, set
    /// A generic message when starting video fails.
    abstract startVideoGeneric: string with get, set
    /// A generic message when starting video fails.
    abstract stopVideoGeneric: string with get, set
    /// A generic message when muting microphone fails.
    abstract muteGeneric: string with get, set
    /// A generic message when unmuting microphone fails.
    abstract unmuteGeneric: string with get, set
    /// A generic message when starting screenshare fails.
    abstract startScreenShareGeneric: string with get, set
    /// A generic message when stopping screenshare fails.
    abstract stopScreenShareGeneric: string with get, set
    /// Message shown when poor network quality is detected during a call.
    abstract callNetworkQualityLow: string with get, set
    /// Message shown on failure to detect audio output devices.
    abstract callNoSpeakerFound: string with get, set
    /// Message shown on failure to detect audio input devices.
    abstract callNoMicrophoneFound: string with get, set
    /// Message shown when microphone can be enumerated but access is blocked by the system.
    abstract callMicrophoneAccessDenied: string with get, set
    /// Message shown when microphone is muted by the system (not by local or remote participants)
    abstract callMicrophoneMutedBySystem: string with get, set
    /// Mac OS specific message shown when microphone can be enumerated but access is
    /// blocked by the system.
    abstract callMacOsMicrophoneAccessDenied: string with get, set
    /// Message shown when poor network causes local video stream to be frozen.
    abstract callLocalVideoFreeze: string with get, set
    /// Message shown when camera can be enumerated but access is blocked by the system.
    abstract callCameraAccessDenied: string with get, set
    /// Message shown when local video fails to start because camera is already in use by
    /// another applciation.
    abstract callCameraAlreadyInUse: string with get, set
    /// Mac OS specific message shown when system denies access to camera.
    abstract callMacOsCameraAccessDenied: string with get, set
    /// Mac OS specific message shown when system denies sharing local screen on a call.
    abstract callMacOsScreenShareAccessDenied: string with get, set
    /// Dimiss errorbar button aria label read by screen reader accessibility tools
    abstract dismissButtonAriaLabel: string option with get, set
    /// An error message when joining a call fails.
    abstract failedToJoinCallGeneric: string option with get, set
    /// An error message when joining a call fails specifically due to an invalid meeting link.
    abstract failedToJoinCallInvalidMeetingLink: string option with get, set

/// <summary>All errors that can be shown in the <see cref="ErrorBar" />.</summary>
type ErrorType =
    KeyOf<ErrorBarStrings>

/// <summary>Props for <see cref="FluentThemeProvider" />.</summary>
type [<AllowNullLiteral>] FluentThemeProviderProps =
    /// Children to be themed.
    abstract children: React_2.ReactNode with get, set
    /// Theme for components. Defaults to a light theme if not provided.
    abstract fluentTheme: U2<PartialTheme, Theme> option with get, set
    /// <summary>Whether components are displayed right-to-left</summary>
    /// <default><c>false</c></default>
    abstract rtl: bool option with get, set

/// <summary>Specific type of the selector applicable to a given Component.</summary>
type GetCallingSelector<'Component> =
    obj

/// <summary>Specific type of the selector applicable to a given Component.</summary>
type GetChatSelector<'Component> =
    obj

/// <summary>Props for <see cref="GridLayout" />.</summary>
type [<AllowNullLiteral>] GridLayoutProps =
    abstract children: React_2.ReactNode with get, set
    /// <summary>Allows users to pass in an object contains custom CSS styles.</summary>
    /// <example>
    /// <code>
    /// &lt;GridLayout styles={{ root: { background: 'blue' } }} /&gt;
    /// </code>
    /// </example>
    abstract styles: BaseCustomStyles option with get, set

/// <summary><see cref="GridLayout" /> Component Styles.</summary>
type [<AllowNullLiteral>] GridLayoutStyles =
    inherit BaseCustomStyles
    /// <summary>Styles for each child of <see cref="GridLayout" /></summary>
    abstract children: IStyle option with get, set

/// <summary><see cref="HorizontalGallery" /> Component Styles.</summary>
type [<AllowNullLiteral>] HorizontalGalleryStyles =
    inherit BaseCustomStyles
    /// <summary>Styles for each child of <see cref="HorizontalGallery" /></summary>
    abstract children: IStyle option with get, set
    /// Styles for navigation button to go to previous page
    abstract previousButton: IStyle option with get, set
    /// Styles for navigation button to go to next page
    abstract nextButton: IStyle option with get, set

/// <summary>Arguments to Context Provider for <see cref="_Identifiers" />.</summary>
type [<AllowNullLiteral>] _IdentifierProviderProps =
    abstract identifiers: _Identifiers option with get, set
    abstract children: React_2.ReactNode with get, set

/// <summary>Identifiers that can be used to target specific components in a composite.</summary>
type [<AllowNullLiteral>] _Identifiers =
    /// <summary><c>data-ui-id</c> value for <c>SendBox</c> Component</summary>
    abstract sendboxTextField: string with get, set
    /// <summary><c>data-ui-id</c> value for <c>ParticipantButton</c> Component's People menu item</summary>
    abstract participantButtonPeopleMenuItem: string with get, set
    /// <summary><c>data-ui-id</c> value for <c>ParticipantItem</c> Component's Menu button</summary>
    abstract participantItemMenuButton: string with get, set
    /// <summary><c>data-ui-id</c> value for <c>ParticipantList</c> Component</summary>
    abstract participantList: string with get, set
    /// <summary><c>data-ui-id</c> value for <c>ParticipantList</c> Component's People Button</summary>
    abstract participantListPeopleButton: string with get, set
    /// <summary><c>data-ui-id</c> value for <c>ParticipantList</c> Component's Remove Participant Button</summary>
    abstract participantListRemoveParticipantButton: string with get, set
    /// <summary><c>data-ui-id</c> value for <c>MessageThread</c> components message content</summary>
    abstract messageContent: string with get, set
    /// <summary><c>data-ui-id</c> value for <c>MessageThread</c> components message timestamp</summary>
    abstract messageTimestamp: string with get, set
    /// <summary><c>data-ui-id</c> value for <c>TypingIndicator</c> Component</summary>
    abstract typingIndicator: string with get, set
    /// <summary><c>data-ui-id</c> value for <c>VideoGallery</c> Component</summary>
    abstract videoGallery: string with get, set
    /// <summary><c>data-ui-id</c> value for <c>VideoTile</c> Component</summary>
    abstract videoTile: string with get, set
    /// <summary><c>data-ui-id</c> value for <c>HorizontalGallery</c> Component's left navigation button</summary>
    abstract horizontalGalleryLeftNavButton: string with get, set
    /// <summary><c>data-ui-id</c> value for <c>HorizontalGallery</c> Component's right navigation button</summary>
    abstract horizontalGalleryRightNavButton: string with get, set

/// <summary>
/// State only version of <see cref="@azure/communication-calling.IncomingCall" />. <see cref="StatefulCallClient" /> will
/// automatically detect incoming calls and add their state to the state exposed by <see cref="StatefulCallClient" />.
/// </summary>
type [<AllowNullLiteral>] IncomingCallState =
    /// <summary>Proxy of <see cref="@azure/communication-calling.IncomingCall.id" />.</summary>
    abstract id: string with get, set
    /// <summary>Proxy of <see cref="@azure/communication-calling.IncomingCall.callerInfo" />.</summary>
    abstract callerInfo: CallerInfo with get, set
    /// <summary>
    /// Set to the state returned by 'callEnded' event on <see cref="@azure/communication-calling.IncomingCall" /> when received.
    /// This property is added by the stateful layer and is not a proxy of SDK state.
    /// </summary>
    abstract callEndReason: CallEndReason option with get, set
    /// Stores the local date when the call started on the client. This property is added by the stateful layer and is not
    /// a proxy of SDK state.
    abstract startTime: DateTime with get, set
    /// Stores the local date when the call ended on the client. This property is added by the stateful layer and is not a
    /// proxy of SDK state. It is undefined if the call is not ended yet.
    abstract endTime: DateTime option with get, set

/// <summary>Callback for <see cref="CallAdapterSubscribers" /> 'isLocalScreenSharingActiveChanged' event.</summary>
type [<AllowNullLiteral>] IsLocalScreenSharingActiveChangedListener =
    /// <summary>Callback for <see cref="CallAdapterSubscribers" /> 'isLocalScreenSharingActiveChanged' event.</summary>
    [<Emit("$0($1...)")>] abstract Invoke: ``event``: {| isScreenSharingOn: bool |} -> unit

/// <summary>Callback for <see cref="CallAdapterSubscribers" /> 'isMuted' event.</summary>
type [<AllowNullLiteral>] IsMutedChangedListener =
    /// <summary>Callback for <see cref="CallAdapterSubscribers" /> 'isMuted' event.</summary>
    [<Emit("$0($1...)")>] abstract Invoke: ``event``: {| identifier: CommunicationIdentifierKind; isMuted: bool |} -> unit

/// <summary>Callback for <see cref="CallAdapterSubscribers" /> 'isSpeakingChanged' event.</summary>
type [<AllowNullLiteral>] IsSpeakingChangedListener =
    /// <summary>Callback for <see cref="CallAdapterSubscribers" /> 'isSpeakingChanged' event.</summary>
    [<Emit("$0($1...)")>] abstract Invoke: ``event``: {| identifier: CommunicationIdentifierKind; isSpeaking: bool |} -> unit

/// <summary>Arguments for <see cref="MessageThreadProps.onRenderJumpToNewMessageButton" />.</summary>
type [<AllowNullLiteral>] JumpToNewMessageButtonProps =
    /// String for button text
    abstract text: string with get, set
    /// Callback for when button is clicked
    abstract onClick: (unit -> unit) with get, set

/// <summary>Whether the stream is loading or not.</summary>
type [<StringEnum>] [<RequireQualifiedAccess>] LoadingState =
    | Loading
    | None

/// <summary>Props for <see cref="LocalizationProvider" />.</summary>
type [<AllowNullLiteral>] LocalizationProviderProps =
    /// Locale context to provide components
    abstract locale: ComponentLocale with get, set
    /// Children to provide locale context.
    abstract children: React_2.ReactNode with get, set

type [<AllowNullLiteral>] LocalVideoCameraCycleButtonProps =
    /// Array of cameras available to the user.
    abstract cameras: ResizeArray<OptionsDevice> option with get, set
    /// Currently selected camera in the local video stream.
    abstract selectedCamera: OptionsDevice option with get, set
    /// callback function to change video feed.
    abstract onSelectCamera: (OptionsDevice -> Promise<unit>) option with get, set
    /// label for local video camera switcher
    abstract label: string option with get, set
    /// description for local video camera switcher
    abstract ariaDescription: string option with get, set

/// <summary>State only version of <see cref="@azure/communication-calling.LocalVideoStream" />.</summary>
type [<AllowNullLiteral>] LocalVideoStreamState =
    /// <summary>Proxy of <see cref="@azure/communication-calling.LocalVideoStream.source" />.</summary>
    abstract source: VideoDeviceInfo with get, set
    /// <summary>Proxy of <see cref="@azure/communication-calling.LocalVideoStream.mediaStreamType" />.</summary>
    abstract mediaStreamType: MediaStreamType with get, set
    /// <summary>
    /// <see cref="VideoStreamRendererView" /> that is managed by createView/disposeView in <see cref="StatefulCallClient" />
    /// API. This can be undefined if the stream has not yet been rendered and defined after createView creates the view.
    /// </summary>
    abstract view: VideoStreamRendererViewState option with get, set

/// <summary>Payload for <see cref="DiagnosticChangedEventListner" /> where there is a change in a media diagnostic.</summary>
type [<AllowNullLiteral>] MediaDiagnosticChangedEvent =
    interface end

/// <summary>State only proxy for <see cref="@azure/communication-calling.MediaDiagnostics" />.</summary>
type [<AllowNullLiteral>] MediaDiagnosticsState =
    abstract latest: LatestMediaDiagnostics with get, set

/// <summary>
/// Discriminated union of all messages.
///
/// The <c>messageType</c> field specializes into union variants.
/// </summary>
type Message =
    U3<ChatMessage, SystemMessage, CustomMessage>

/// <summary>
/// Indicate whether a chat message should be displayed merged with the message before / after it.
///
/// Useful to merge many messages from the same sender into a single message bubble.
/// </summary>
type MessageAttachedStatus =
    U2<bool, string>

/// <summary>Common properties of all message types.</summary>
type [<AllowNullLiteral>] MessageCommon =
    abstract messageId: string with get, set
    abstract createdOn: DateTime with get, set

/// <summary>Supported types of chat message content.</summary>
type [<StringEnum>] [<RequireQualifiedAccess>] MessageContentType =
    | Text
    | Html
    | [<CompiledName("richtext/html")>] ``Richtext/html``
    | Unknown

/// <summary>
/// Props to render a single message.
///
/// See <see cref="MessageRenderer" />.
/// </summary>
type [<AllowNullLiteral>] MessageProps =
    /// <summary>Message to render. It can type <c>ChatMessage</c> or <c>SystemMessage</c> or <c>CustomMessage</c>.</summary>
    abstract message: Message with get, set
    /// Strings from parent MessageThread component
    abstract strings: MessageThreadStrings with get, set
    /// Custom CSS styles for chat message container.
    abstract messageContainerStyle: ComponentSlotStyle option with get, set
    /// <summary>Whether the date of a message is displayed or not.</summary>
    /// <default><c>false</c></default>
    abstract showDate: bool option with get, set
    /// <summary>Disable editing messages.</summary>
    /// <remarks>This removes the action menu on messages.</remarks>
    /// <default><c>false</c></default>
    abstract disableEditing: bool option with get, set
    /// <summary>Optional callback to edit a message.</summary>
    /// <param name="messageId">message id from chatClient</param>
    /// <param name="content">new content of the message</param>
    abstract onUpdateMessage: UpdateMessageCallback option with get, set
    /// <summary>Optional callback to delete a message.</summary>
    /// <param name="messageId">message id from chatClient</param>
    abstract onDeleteMessage: (string -> Promise<unit>) option with get, set
    /// <summary>Optional callback to send a message.</summary>
    /// <param name="messageId">message id from chatClient</param>
    abstract onSendMessage: (string -> Promise<unit>) option with get, set

/// <summary>Callback for <see cref="ChatAdapterSubscribers" /> 'messageRead' event.</summary>
type [<AllowNullLiteral>] MessageReadListener =
    /// <summary>Callback for <see cref="ChatAdapterSubscribers" /> 'messageRead' event.</summary>
    [<Emit("$0($1...)")>] abstract Invoke: ``event``: {| message: ChatMessage_2; readBy: CommunicationUserKind |} -> unit

/// <summary>Callback for <see cref="ChatAdapterSubscribers" /> 'messageReceived' event.</summary>
type [<AllowNullLiteral>] MessageReceivedListener =
    /// <summary>Callback for <see cref="ChatAdapterSubscribers" /> 'messageReceived' event.</summary>
    [<Emit("$0($1...)")>] abstract Invoke: ``event``: {| message: ChatMessage_2 |} -> unit

/// <summary>A component to render a single message.</summary>
type [<AllowNullLiteral>] MessageRenderer =
    /// <summary>A component to render a single message.</summary>
    [<Emit("$0($1...)")>] abstract Invoke: props: MessageProps -> JSX.Element

/// <summary>Callback for <see cref="ChatAdapterSubscribers" /> 'messageSent' event.</summary>
type MessageSentListener =
    MessageReceivedListener

/// <summary>
/// Client-side state of a sent message.
///
/// Includes transitional states that occur before message delivery is confirmed from the backend.
/// </summary>
type [<StringEnum>] [<RequireQualifiedAccess>] MessageStatus =
    | Delivered
    | Sending
    | Seen
    | Failed

/// <summary>Props for <see cref="MessageStatusIndicator" />.</summary>
type [<AllowNullLiteral>] MessageStatusIndicatorProps =
    /// Message status that determines the icon to display.
    abstract status: MessageStatus option with get, set
    abstract readCount: float option with get, set
    abstract onToggleToolTip: (bool -> unit) option with get, set
    /// number of participants not including myself
    abstract remoteParticipantsCount: float option with get, set
    /// <summary>Allows users to pass an object containing custom CSS styles.</summary>
    /// <example>
    /// <code>
    /// &lt;MessageStatus styles={{ root: { background: 'blue' } }} /&gt;
    /// </code>
    /// </example>
    abstract styles: BaseCustomStyles option with get, set
    /// Optional strings to override in component
    abstract strings: MessageStatusIndicatorStrings option with get, set

/// <summary>Strings of <see cref="MessageStatusIndicator" /> that can be overridden.</summary>
type [<AllowNullLiteral>] MessageStatusIndicatorStrings =
    /// Aria label to notify user when their message has been delivered.
    abstract deliveredAriaLabel: string option with get, set
    /// Text to display in the delivered message icon tooltip.
    abstract deliveredTooltipText: string with get, set
    /// Aria label to notify user when their message has been seen by others.
    abstract seenAriaLabel: string option with get, set
    /// Text to display in the seen message icon tooltip if read number/ participant number is 1
    abstract seenTooltipText: string with get, set
    /// Text to display in the seen message icon tooltip if read number logic is working correctly (more than 1 read number and more than 1 particiants)
    abstract readByTooltipText: string option with get, set
    /// Aria label to notify user when their message is being sent.
    abstract sendingAriaLabel: string option with get, set
    /// Text to display in the sending message icon tooltip.
    abstract sendingTooltipText: string with get, set
    /// Aria label to notify user when their message has failed to be sent.
    abstract failedToSendAriaLabel: string option with get, set
    /// Text to display in the failed message icon tooltip.
    abstract failedToSendTooltipText: string with get, set

/// <summary>Props for <see cref="MessageThread" />.</summary>
type [<AllowNullLiteral>] MessageThreadProps =
    /// UserId of the current user.
    abstract userId: string with get, set
    /// <summary>Messages to render in message thread. A message can be of type <c>ChatMessage</c>, <c>SystemMessage</c> or <c>CustomMessage</c>.</summary>
    abstract messages: ResizeArray<U3<ChatMessage, SystemMessage, CustomMessage>> with get, set
    /// number of participants in the thread
    abstract participantCount: float option with get, set
    /// read receipts for each sender in the chat
    abstract readReceiptsBySenderId: ReadReceiptsBySenderId option with get, set
    /// <summary>Allows users to pass an object containing custom CSS styles.</summary>
    /// <example>
    /// <code>
    /// &lt;MessageThread styles={{ root: { background: 'blue' } }} /&gt;
    /// </code>
    /// </example>
    abstract styles: MessageThreadStyles option with get, set
    /// <summary>Whether the new message button is disabled or not.</summary>
    /// <default><c>false</c></default>
    abstract disableJumpToNewMessageButton: bool option with get, set
    /// <summary>
    /// Whether the date of each message is displayed or not.
    /// It is ignored when onDisplayDateTimeString is supplied.
    /// </summary>
    /// <default><c>false</c></default>
    abstract showMessageDate: bool option with get, set
    /// <summary>Whether the status indicator for each message is displayed or not.</summary>
    /// <default><c>false</c></default>
    abstract showMessageStatus: bool option with get, set
    /// <summary>Number of chat messages to reload each time onLoadPreviousChatMessages is called.</summary>
    /// <default>0</default>
    abstract numberOfChatMessagesToReload: float option with get, set
    /// <summary>Optional callback to override actions on message being seen.</summary>
    /// <param name="messageId">message Id</param>
    abstract onMessageSeen: (string -> Promise<unit>) option with get, set
    /// <summary>Optional callback to override render of the message status indicator.</summary>
    /// <param name="messageStatusIndicatorProps">props of type MessageStatusIndicatorProps</param>
    abstract onRenderMessageStatus: (MessageStatusIndicatorProps -> JSX.Element option) option with get, set
    /// <summary>Optional callback to override render of the avatar.</summary>
    /// <param name="userId">user Id</param>
    abstract onRenderAvatar: OnRenderAvatarCallback option with get, set
    /// <summary>Optional callback to override render of the button for jumping to the new message.</summary>
    /// <param name="newMessageButtonProps">button props of type JumpToNewMessageButtonProps</param>
    abstract onRenderJumpToNewMessageButton: (JumpToNewMessageButtonProps -> JSX.Element) option with get, set
    /// <summary>
    /// Optional callback to override loading of previous messages.
    /// It accepts the number of history chat messages that we want to load and return a boolean Promise indicating if we have got all the history messages.
    /// If the promise resolves to <c>true</c>, we have load all chat messages into the message thread and <c>loadPreviousMessagesButton</c> will not be rendered anymore.
    /// </summary>
    abstract onLoadPreviousChatMessages: (float -> Promise<bool>) option with get, set
    /// <summary>Optional callback to override render of a message.</summary>
    /// <param name="messageProps">props of type <see cref="communication-react.MessageProps" /></param>
    /// <param name="defaultOnRender">default render of type <see cref="communication-react.MessageRenderer" /></param>
    /// <remarks><c>messageRenderer</c> is not provided for <c>CustomMessage</c> and thus only available for <c>ChatMessage</c> and <c>SystemMessage</c>.</remarks>
    abstract onRenderMessage: (MessageProps -> (MessageRenderer) option -> JSX.Element) option with get, set
    /// <summary>Optional callback to edit a message.</summary>
    /// <param name="messageId">message id from chatClient</param>
    /// <param name="content">new content of the message</param>
    abstract onUpdateMessage: UpdateMessageCallback option with get, set
    /// <summary>Optional callback to delete a message.</summary>
    /// <param name="messageId">message id from chatClient</param>
    abstract onDeleteMessage: (string -> Promise<unit>) option with get, set
    /// <summary>Optional callback to send a message.</summary>
    /// <param name="messageId">message id from chatClient</param>
    abstract onSendMessage: (string -> Promise<unit>) option with get, set
    /// <summary>
    /// /**
    ///  Disable editing messages.
    /// </summary>
    /// <remarks>This removes the action menu on messages.</remarks>
    /// <default><c>false</c></default>
    abstract disableEditing: bool option with get, set
    /// Optional strings to override in component
    abstract strings: obj option with get, set

/// <summary>Selector type for <see cref="MessageThread" /> component.</summary>
type [<AllowNullLiteral>] MessageThreadSelector =
    /// <summary>Selector type for <see cref="MessageThread" /> component.</summary>
    [<Emit("$0($1...)")>] abstract Invoke: state: ChatClientState * props: ChatBaseSelectorProps -> {| userId: string; showMessageStatus: bool; messages: ResizeArray<Message> |}

/// <summary>Strings of <see cref="MessageThread" /> that can be overridden.</summary>
type [<AllowNullLiteral>] MessageThreadStrings =
    /// String for Sunday
    abstract sunday: string with get, set
    /// String for Monday
    abstract monday: string with get, set
    /// String for Tuesday
    abstract tuesday: string with get, set
    /// String for Wednesday
    abstract wednesday: string with get, set
    /// String for Thursday
    abstract thursday: string with get, set
    /// String for Friday
    abstract friday: string with get, set
    /// String for Saturday
    abstract saturday: string with get, set
    /// String for Yesterday
    abstract yesterday: string with get, set
    /// String for participants joined
    abstract participantJoined: string with get, set
    /// String for participants left
    abstract participantLeft: string with get, set
    /// Tag shown on a message that has been edited
    abstract editedTag: string with get, set
    /// String for editing message in floating menu
    abstract editMessage: string with get, set
    /// String for removing message in floating menu
    abstract removeMessage: string with get, set
    /// String for resending failed message in floating menu
    abstract resendMessage: string option with get, set
    /// String for indicating failed to send messages
    abstract failToSendTag: string option with get, set
    /// String for LiveMessage introduction for the Chat Message
    abstract liveAuthorIntro: string with get, set
    /// String for warning on text limit exceeded in EditBox
    abstract editBoxTextLimit: string with get, set
    /// String for placeholder text in EditBox when there is no user input
    abstract editBoxPlaceholderText: string with get, set
    /// String for new messages indicator
    abstract newMessagesIndicator: string with get, set
    /// String for showing message read status in floating menu
    abstract messageReadCount: string option with get, set
    /// String for replacing display name when there is none
    abstract noDisplayNameSub: string with get, set
    /// String for Cancel button in EditBox
    abstract editBoxCancelButton: string with get, set
    /// String for Submit in EditBox when there is no user input
    abstract editBoxSubmitButton: string with get, set
    /// String for action menu indicating there are more options
    abstract actionMenuMoreOptions: string option with get, set

/// <summary>Fluent styles for <see cref="MessageThread" />.</summary>
type [<AllowNullLiteral>] MessageThreadStyles =
    inherit BaseCustomStyles
    /// Styles for load previous messages container.
    abstract loadPreviousMessagesButtonContainer: IStyle option with get, set
    /// Styles for new message container.
    abstract newMessageButtonContainer: IStyle option with get, set
    /// Styles for chat container.
    abstract chatContainer: ComponentSlotStyle option with get, set
    /// styles for my chat items.
    abstract myChatItemMessageContainer: ComponentSlotStyle option with get, set
    /// styles for chat items.
    abstract chatItemMessageContainer: ComponentSlotStyle option with get, set
    /// Styles for my chat message container.
    abstract myChatMessageContainer: ComponentSlotStyle option with get, set
    /// Styles for chat message container.
    abstract chatMessageContainer: ComponentSlotStyle option with get, set
    /// Styles for system message container.
    abstract systemMessageContainer: ComponentSlotStyle option with get, set
    /// Styles for message status indicator container.
    abstract messageStatusContainer: (bool -> IStyle) option with get, set

/// <summary>Styles for the <see cref="MicrophoneButton" /> menu.</summary>
type [<AllowNullLiteral>] MicrophoneButtonContextualMenuStyles =
    inherit IContextualMenuStyles
    /// <summary>Styles for the items inside the <see cref="MicrophoneButton" /> button menu.</summary>
    abstract menuItemStyles: IContextualMenuItemStyles option with get, set

/// <summary>Props for <see cref="MicrophoneButton" />.</summary>
type [<AllowNullLiteral>] MicrophoneButtonProps =
    inherit ControlBarButtonProps
    /// <summary>
    /// Utility property for using this component with <c>communication react eventHandlers</c>.
    /// Maps directly to the <c>onClick</c> property.
    /// </summary>
    abstract onToggleMicrophone: (unit -> Promise<unit>) option with get, set
    /// Available microphones for selection
    abstract microphones: ResizeArray<OptionsDevice> option with get, set
    /// Available speakers for selection
    abstract speakers: ResizeArray<OptionsDevice> option with get, set
    /// Microphone that is shown as currently selected
    abstract selectedMicrophone: OptionsDevice option with get, set
    /// Speaker that is shown as currently selected
    abstract selectedSpeaker: OptionsDevice option with get, set
    /// Callback when a microphone is selected
    abstract onSelectMicrophone: (OptionsDevice -> Promise<unit>) option with get, set
    /// Speaker when a speaker is selected
    abstract onSelectSpeaker: (OptionsDevice -> Promise<unit>) option with get, set
    /// <summary>
    /// Whether to use a <see cref="SplitButton" /> with a <see cref="IContextualMenu" /> for device selection.
    ///
    /// default: false
    /// </summary>
    abstract enableDeviceSelectionMenu: bool option with get, set
    /// Optional strings to override in component
    abstract strings: obj option with get, set
    /// <summary>Styles for <see cref="MicrophoneButton" /> and the device selection flyout.</summary>
    abstract styles: obj option with get, set

/// <summary>Selector type for <see cref="MicrophoneButton" /> component.</summary>
type [<AllowNullLiteral>] MicrophoneButtonSelector =
    /// <summary>Selector type for <see cref="MicrophoneButton" /> component.</summary>
    [<Emit("$0($1...)")>] abstract Invoke: state: CallClientState * props: CallingBaseSelectorProps -> MicrophoneButtonSelectorInvokeReturn

type [<AllowNullLiteral>] MicrophoneButtonSelectorInvokeReturn =
    abstract disabled: bool with get, set
    abstract ``checked``: bool with get, set
    abstract microphones: ResizeArray<AudioDeviceInfo> with get, set
    abstract speakers: ResizeArray<AudioDeviceInfo> with get, set
    abstract selectedMicrophone: AudioDeviceInfo option with get, set
    abstract selectedSpeaker: AudioDeviceInfo option with get, set

/// <summary>Strings of <see cref="MicrophoneButton" /> that can be overridden.</summary>
type [<AllowNullLiteral>] MicrophoneButtonStrings =
    /// Label when button is on.
    abstract onLabel: string with get, set
    /// Label when button is off.
    abstract offLabel: string with get, set
    /// * Tooltip content when the button is disabled.
    abstract tooltipDisabledContent: string option with get, set
    /// Tooltip content when the button is on.
    abstract tooltipOnContent: string option with get, set
    /// Tooltip content when the button is off.
    abstract tooltipOffContent: string option with get, set
    /// Title of microphone menu
    abstract microphoneMenuTitle: string option with get, set
    /// Title of speaker menu
    abstract speakerMenuTitle: string option with get, set
    /// Tooltip of microphone menu
    abstract microphoneMenuTooltip: string option with get, set
    /// Tooltip of speaker menu
    abstract speakerMenuTooltip: string option with get, set
    /// Description of microphone button split button role
    abstract microphoneButtonSplitRoleDescription: string option with get, set
    /// Microphone split button aria label when mic is enabled.
    abstract onSplitButtonAriaLabel: string option with get, set
    /// Microphone split button aria label when mic is disabled.
    abstract offSplitButtonAriaLabel: string option with get, set
    /// Microphone action turned on string for announcer
    abstract microphoneActionTurnedOnAnnouncement: string option with get, set
    /// Microphone action turned off string for announcer
    abstract microphoneActionTurnedOffAnnouncement: string option with get, set

/// <summary>Styles for <see cref="MicrophoneButton" /></summary>
type [<AllowNullLiteral>] MicrophoneButtonStyles =
    inherit ControlBarButtonStyles
    /// <summary>Styles for the <see cref="MicrophoneButton" /> menu.</summary>
    abstract menuStyles: obj option with get, set

/// <summary>Payload for <see cref="DiagnosticChangedEventListner" /> where there is a change in a network diagnostic.</summary>
type [<AllowNullLiteral>] NetworkDiagnosticChangedEvent =
    interface end

/// <summary>State only proxy for <see cref="@azure/communication-calling.NetworkDiagnostics" />.</summary>
type [<AllowNullLiteral>] NetworkDiagnosticsState =
    abstract latest: LatestNetworkDiagnostics with get, set

/// <summary>A custom rendered callback that allows users to customize the rendering of a Persona Component.</summary>
type [<AllowNullLiteral>] OnRenderAvatarCallback =
    /// <summary>A custom rendered callback that allows users to customize the rendering of a Persona Component.</summary>
    [<Emit("$0($1...)")>] abstract Invoke: ?userId: string * ?options: CustomAvatarOptions * ?defaultOnRender: (CustomAvatarOptions -> JSX.Element) -> JSX.Element

/// <summary>A device, e.g. camera, microphone, or speaker, in the <see cref="DevicesButton" /> flyout.</summary>
type [<AllowNullLiteral>] OptionsDevice =
    /// Device unique identifier
    abstract id: string with get, set
    /// Device name
    abstract name: string with get, set

/// <summary>A system message notifying that a participant was added to the chat thread.</summary>
type [<AllowNullLiteral>] ParticipantAddedSystemMessage =
    inherit SystemMessageCommon
    abstract systemMessageType: string with get, set
    abstract participants: ResizeArray<CommunicationParticipant> with get, set

/// <summary>Props for <see cref="ParticipantItem" />.</summary>
type [<AllowNullLiteral>] ParticipantItemProps =
    /// <summary>Unique User ID of the participant. This <c>userId</c> is available in the <c>onRenderAvatar</c> callback function</summary>
    abstract userId: string option with get, set
    /// Name of participant.
    abstract displayName: string option with get, set
    /// Optional indicator to show participant is the user.
    abstract me: bool option with get, set
    /// Optional callback returning a JSX element to override avatar.
    abstract onRenderAvatar: OnRenderAvatarCallback option with get, set
    /// Optional array of IContextualMenuItem for contextual menu.
    abstract menuItems: ResizeArray<IContextualMenuItem> option with get, set
    /// Optional callback returning a JSX element rendered on the right portion of the ParticipantItem. Intended for adding icons.
    abstract onRenderIcon: ((ParticipantItemProps) option -> JSX.Element option) option with get, set
    /// Optional PersonaPresence to show participant presence. This will not have an effect if property avatar is assigned.
    abstract presence: PersonaPresence option with get, set
    /// <summary>Allows users to pass in an object contains custom CSS styles.</summary>
    /// <example>
    /// <code>
    /// &lt;ParticipantItem styles={{ root: { background: 'blue' } }} /&gt;
    /// </code>
    /// </example>
    abstract styles: ParticipantItemStyles option with get, set
    /// Optional strings to override in component
    abstract strings: obj option with get, set
    /// Optional callback when component is clicked
    abstract onClick: ((ParticipantItemProps) option -> unit) option with get, set

/// <summary>Strings of <see cref="ParticipantItem" /> that can be overridden.</summary>
type [<AllowNullLiteral>] ParticipantItemStrings =
    /// String shown when participant is me
    abstract isMeText: string with get, set
    /// String shown when hovering over menu button
    abstract menuTitle: string with get, set
    /// Label for the remove button in participant menu
    abstract removeButtonLabel: string with get, set
    /// Label for the sharing icon in participant state stack
    abstract sharingIconLabel: string with get, set
    /// Label for the muted icon in participant state stack
    abstract mutedIconLabel: string with get, set
    /// placeholder text for participants who does not have a display name
    abstract displayNamePlaceholder: string option with get, set

/// <summary>Fluent styles for <see cref="ParticipantItem" />.</summary>
type [<AllowNullLiteral>] ParticipantItemStyles =
    inherit BaseCustomStyles
    /// Styles for the avatar.
    abstract avatar: IStyle option with get, set
    /// Styles for the (You) string.
    abstract me: IStyle option with get, set
    /// Styles for the container of the icon.
    abstract iconContainer: IStyle option with get, set
    /// Styles for the menu.
    abstract menu: IStyle option with get, set

/// <summary>Styles for the <see cref="ParticipantList" /> <see cref="ParticipantItem" />.</summary>
type [<AllowNullLiteral>] ParticipantListItemStyles =
    inherit ParticipantItemStyles
    /// <summary>Styles applied to the sub-menu of the <see cref="ParticipantList" /> <see cref="ParticipantItem" />.</summary>
    abstract participantSubMenuItemsStyles: IContextualMenuItemStyles option with get, set

/// <summary>Participants displayed in a <see cref="ParticipantList" />.</summary>
type [<AllowNullLiteral>] ParticipantListParticipant =
    interface end

/// <summary>Props for <see cref="ParticipantList" />.</summary>
type [<AllowNullLiteral>] ParticipantListProps =
    /// Participants in user call or chat
    abstract participants: ResizeArray<ParticipantListParticipant> with get, set
    /// User ID of user
    abstract myUserId: string option with get, set
    /// <summary>If set to <c>true</c>, excludes the local participant from the participant list with use of <c>myUserId</c> props (required in this case).</summary>
    /// <default><c>false</c></default>
    abstract excludeMe: bool option with get, set
    /// <summary>Optional callback to render each participant. If no callback is provided, each participant will be rendered with <c>ParticipantItem</c></summary>
    abstract onRenderParticipant: (ParticipantListParticipant -> JSX.Element option) option with get, set
    /// <summary>Optional callback to render the avatar for each participant. This property will have no effect if <c>onRenderParticipant</c> is assigned.</summary>
    abstract onRenderAvatar: OnRenderAvatarCallback option with get, set
    /// Optional callback to render the context menu for each participant
    abstract onRemoveParticipant: (string -> unit) option with get, set
    /// Optional callback to render custom menu items for each participant.
    abstract onFetchParticipantMenuItems: ParticipantMenuItemsCallback option with get, set
    /// Optional callback when rendered ParticipantItem is clicked
    abstract onParticipantClick: ((ParticipantListParticipant) option -> unit) option with get, set
    /// <summary>Styles for the <see cref="ParticipantList" /></summary>
    abstract styles: ParticipantListStyles option with get, set

/// <summary>Selector type for <see cref="ParticipantList" /> component.</summary>
type [<AllowNullLiteral>] ParticipantListSelector =
    /// <summary>Selector type for <see cref="ParticipantList" /> component.</summary>
    [<Emit("$0($1...)")>] abstract Invoke: state: CallClientState * props: CallingBaseSelectorProps -> {| participants: ResizeArray<CallParticipantListParticipant>; myUserId: string |}

/// <summary>Styles for the <see cref="ParticipantList" />.</summary>
type [<AllowNullLiteral>] ParticipantListStyles =
    inherit BaseCustomStyles
    /// <summary>Styles for the <see cref="ParticipantList" /> <see cref="ParticipantItem" />.</summary>
    abstract participantItemStyles: ParticipantListItemStyles option with get, set

/// <summary>A callback for providing custom menu items for each participant in <see cref="ParticipantList" />.</summary>
type [<AllowNullLiteral>] ParticipantMenuItemsCallback =
    /// <summary>A callback for providing custom menu items for each participant in <see cref="ParticipantList" />.</summary>
    [<Emit("$0($1...)")>] abstract Invoke: participantUserId: string * ?userId: string * ?defaultMenuItems: ResizeArray<IContextualMenuItem> -> ResizeArray<IContextualMenuItem>

/// <summary>A system message notifying that a participant was removed from the chat thread.</summary>
type [<AllowNullLiteral>] ParticipantRemovedSystemMessage =
    inherit SystemMessageCommon
    abstract systemMessageType: string with get, set
    abstract participants: ResizeArray<CommunicationParticipant> with get, set

/// <summary>Callback for <see cref="ChatAdapterSubscribers" /> 'participantsAdded' event.</summary>
type [<AllowNullLiteral>] ParticipantsAddedListener =
    /// <summary>Callback for <see cref="ChatAdapterSubscribers" /> 'participantsAdded' event.</summary>
    [<Emit("$0($1...)")>] abstract Invoke: ``event``: {| participantsAdded: ResizeArray<ChatParticipant>; addedBy: ChatParticipant |} -> unit

/// <summary>Styles for the <see cref="ParticipantsButton" /> menu.</summary>
type [<AllowNullLiteral>] ParticipantsButtonContextualMenuStyles =
    inherit IContextualMenuStyles
    /// <summary>Styles for the <see cref="ParticipantsButton" /> menu items.</summary>
    abstract menuItemStyles: IContextualMenuItemStyles option with get, set
    /// <summary>Styles for the <see cref="ParticipantList" /> menu item inside the <see cref="ParticipantsButton" /> menu.</summary>
    abstract participantListStyles: ParticipantListStyles option with get, set

/// <summary>Props for <see cref="ParticipantsButton" />.</summary>
type [<AllowNullLiteral>] ParticipantsButtonProps =
    inherit ControlBarButtonProps
    /// Participants in user call or chat
    abstract participants: ResizeArray<ParticipantListParticipant> with get, set
    /// User ID of user
    abstract myUserId: string option with get, set
    /// <summary>If set to <c>true</c>, excludes the local participant from the participant list with use of <c>myUserId</c> props (required in this case).</summary>
    /// <default><c>false</c></default>
    abstract excludeMe: bool option with get, set
    /// <summary>Callback to render each participant. If no callback is provided, each participant will be rendered with <c>ParticipantItem</c></summary>
    abstract onRenderParticipant: (CommunicationParticipant -> JSX.Element option) option with get, set
    /// <summary>Callback to render the avatar for each participant. This property will have no effect if <c>onRenderParticipant</c> is assigned.</summary>
    abstract onRenderAvatar: OnRenderAvatarCallback option with get, set
    /// Callback to render the context menu for each participant
    abstract onRemoveParticipant: (string -> unit) option with get, set
    /// Callback to render custom menu items for each participant.
    abstract onFetchParticipantMenuItems: ParticipantMenuItemsCallback option with get, set
    /// Optional callback to render a custom participant list.
    abstract onRenderParticipantList: (ParticipantListProps -> JSX.Element option) option with get, set
    /// <summary>Allows users to pass an object containing custom CSS styles.</summary>
    /// <example>
    /// <code>
    /// &lt;ParticipantsButton styles={{ root: { background: 'blue' } }} /&gt;
    /// </code>
    /// </example>
    abstract styles: ParticipantsButtonStyles option with get, set
    /// URL to invite new participants to the current call
    abstract callInvitationURL: string option with get, set
    /// CallBack to mute all remote participants
    abstract onMuteAll: (unit -> unit) option with get, set
    /// Optional strings to override in component
    abstract strings: obj option with get, set

/// <summary>Selector type for <see cref="ParticipantsButton" /> component.</summary>
type [<AllowNullLiteral>] ParticipantsButtonSelector =
    /// <summary>Selector type for <see cref="ParticipantsButton" /> component.</summary>
    [<Emit("$0($1...)")>] abstract Invoke: state: CallClientState * props: CallingBaseSelectorProps -> {| participants: ResizeArray<CallParticipantListParticipant>; myUserId: string |}

/// <summary>Strings of <see cref="ParticipantsButton" /> that can be overridden.</summary>
type [<AllowNullLiteral>] ParticipantsButtonStrings =
    /// Label of button
    abstract label: string with get, set
    /// Button tooltip content.
    abstract tooltipContent: string option with get, set
    /// Header of menu pop up
    abstract menuHeader: string with get, set
    /// Label of menu button to show list of participants. Placeholders: [numParticipants]
    abstract participantsListButtonLabel: string with get, set
    /// Label of menu button to copy invite link
    abstract copyInviteLinkButtonLabel: string with get, set
    /// Label of menu button to mute all participants
    abstract muteAllButtonLabel: string with get, set

/// <summary>Styles Props for <see cref="ParticipantsButton" />.</summary>
type [<AllowNullLiteral>] ParticipantsButtonStyles =
    inherit ControlBarButtonStyles
    /// <summary>Styles of the <see cref="ParticipantsButton" /> menu flyout</summary>
    abstract menuStyles: obj option with get, set

/// <summary>Callback for <see cref="CallAdapterSubscribers" /> 'participantsJoined' event.</summary>
type [<AllowNullLiteral>] ParticipantsJoinedListener =
    /// <summary>Callback for <see cref="CallAdapterSubscribers" /> 'participantsJoined' event.</summary>
    [<Emit("$0($1...)")>] abstract Invoke: ``event``: {| joined: ResizeArray<RemoteParticipant> |} -> unit

/// <summary>Callback for <see cref="CallAdapterSubscribers" /> 'participantsLeft' event.</summary>
type [<AllowNullLiteral>] ParticipantsLeftListener =
    /// <summary>Callback for <see cref="CallAdapterSubscribers" /> 'participantsLeft' event.</summary>
    [<Emit("$0($1...)")>] abstract Invoke: ``event``: {| removed: ResizeArray<RemoteParticipant> |} -> unit

/// <summary>Callback for <see cref="ChatAdapterSubscribers" /> 'participantsRemoved' event.</summary>
type [<AllowNullLiteral>] ParticipantsRemovedListener =
    /// <summary>Callback for <see cref="ChatAdapterSubscribers" /> 'participantsRemoved' event.</summary>
    [<Emit("$0($1...)")>] abstract Invoke: ``event``: {| participantsRemoved: ResizeArray<ChatParticipant>; removedBy: ChatParticipant |} -> unit

/// <summary>An array of key value pairs that stores each sender's display name and last read message</summary>
type [<AllowNullLiteral>] ReadReceiptsBySenderId =
    [<EmitIndexer>] abstract Item: key: string -> {| lastReadMessage: string; displayName: string |} with get, set

/// <summary>
/// State only version of <see cref="@azure/communication-calling.RecordingCallFeature" />. <see cref="StatefulCallClient" /> will
/// automatically listen for recording state of the call and update the state exposed by <see cref="StatefulCallClient" /> accordingly.
/// </summary>
type [<AllowNullLiteral>] RecordingCallFeature =
    /// <summary>Proxy of <see cref="@azure/communication-calling.RecordingCallFeature.isRecordingActive" />.</summary>
    abstract isRecordingActive: bool with get, set

/// <summary>
/// State only version of <see cref="@azure/communication-calling.RemoteParticipant" />. <see cref="StatefulCallClient" /> will
/// automatically retrieve RemoteParticipants and add their state to the state exposed by <see cref="StatefulCallClient" />.
/// </summary>
type [<AllowNullLiteral>] RemoteParticipantState =
    /// <summary>Proxy of <see cref="@azure/communication-calling.RemoteParticipant.identifier" />.</summary>
    abstract identifier: U4<CommunicationUserKind, PhoneNumberKind, MicrosoftTeamsUserKind, UnknownIdentifierKind> with get, set
    /// <summary>Proxy of <see cref="@azure/communication-calling.RemoteParticipant.displayName" />.</summary>
    abstract displayName: string option with get, set
    /// <summary>Proxy of <see cref="@azure/communication-calling.RemoteParticipant.state" />.</summary>
    abstract state: RemoteParticipantState_2 with get, set
    /// <summary>Proxy of <see cref="@azure/communication-calling.RemoteParticipant.callEndReason" />.</summary>
    abstract callEndReason: CallEndReason option with get, set
    /// <summary>
    /// Proxy of <see cref="@azure/communication-calling.RemoteParticipant.videoStreams" /> as an object with
    /// <see cref="RemoteVideoStream" /> fields keyed by <see cref="@azure/communication-calling.RemoteVideoStream.id" />.
    /// </summary>
    abstract videoStreams: RemoteParticipantStateVideoStreams with get, set
    /// <summary>Proxy of <see cref="@azure/communication-calling.RemoteParticipant.isMuted" />.</summary>
    abstract isMuted: bool with get, set
    /// <summary>Proxy of <see cref="@azure/communication-calling.RemoteParticipant.isSpeaking" />.</summary>
    abstract isSpeaking: bool with get, set

/// <summary>State only version of <see cref="@azure/communication-calling.RemoteVideoStream" />.</summary>
type [<AllowNullLiteral>] RemoteVideoStreamState =
    /// <summary>Proxy of <see cref="@azure/communication-calling.RemoteVideoStream.id" />.</summary>
    abstract id: float with get, set
    /// <summary>Proxy of <see cref="@azure/communication-calling.RemoteVideoStream.mediaStreamType" />.</summary>
    abstract mediaStreamType: MediaStreamType with get, set
    /// <summary>Proxy of <see cref="@azure/communication-calling.RemoteVideoStream.isAvailable" />.</summary>
    abstract isAvailable: bool with get, set
    /// <summary>
    /// <see cref="VideoStreamRendererView" /> that is managed by createView/disposeView in <see cref="StatefulCallClient" />
    /// API. This can be undefined if the stream has not yet been rendered and defined after createView creates the view.
    /// </summary>
    abstract view: VideoStreamRendererViewState option with get, set

/// <summary>Props for <see cref="ScreenShareButton" />.</summary>
type [<AllowNullLiteral>] ScreenShareButtonProps =
    inherit ControlBarButtonProps
    /// <summary>
    /// Utility property for using this component with <c>communication react eventHandlers</c>.
    /// Maps directly to the <c>onClick</c> property.
    /// </summary>
    abstract onToggleScreenShare: (unit -> Promise<unit>) option with get, set
    /// Optional strings to override in component
    abstract strings: obj option with get, set

/// <summary>Selector type for <see cref="ScreenShareButton" /> component.</summary>
type [<AllowNullLiteral>] ScreenShareButtonSelector =
    /// <summary>Selector type for <see cref="ScreenShareButton" /> component.</summary>
    [<Emit("$0($1...)")>] abstract Invoke: state: CallClientState * props: CallingBaseSelectorProps -> {| ``checked``: bool option |}

/// <summary>Strings of <see cref="ScreenShareButton" /> that can be overridden.</summary>
type [<AllowNullLiteral>] ScreenShareButtonStrings =
    /// Label when button is on.
    abstract onLabel: string with get, set
    /// Label when button is off.
    abstract offLabel: string with get, set
    /// * Tooltip content when the button is disabled.
    abstract tooltipDisabledContent: string option with get, set
    /// Tooltip content when the button is on.
    abstract tooltipOnContent: string option with get, set
    /// Tooltip content when the button is off.
    abstract tooltipOffContent: string option with get, set

/// <summary>An optimized selector that refines <see cref="ClientState" /> updates into props for React Components in this library.</summary>
type [<AllowNullLiteral>] Selector =
    /// <summary>An optimized selector that refines <see cref="ClientState" /> updates into props for React Components in this library.</summary>
    [<Emit("$0($1...)")>] abstract Invoke: state: ClientState * props: obj option -> obj option

/// <summary>Props for <see cref="SendBox" />.</summary>
type [<AllowNullLiteral>] SendBoxProps =
    /// <summary>Optional boolean to disable text box</summary>
    /// <default>false</default>
    abstract disabled: bool option with get, set
    /// Optional text for system message below text box
    abstract systemMessage: string option with get, set
    /// Optional callback called when message is sent
    abstract onSendMessage: (string -> Promise<unit>) option with get, set
    /// Optional callback called when user is typing
    abstract onTyping: (unit -> Promise<unit>) option with get, set
    /// <summary>Optional callback to render system message below the SendBox.</summary>
    /// <default>MessageBar</default>
    abstract onRenderSystemMessage: (string option -> React_2.ReactElement) option with get, set
    /// <summary>Optional boolean to support new line in SendBox.</summary>
    /// <default>false</default>
    abstract supportNewline: bool option with get, set
    /// <summary>Optional callback to render send button icon to the right of the SendBox.</summary>
    /// <default>SendBoxSendHovered icon when mouse over icon and SendBoxSend icon otherwise</default>
    abstract onRenderIcon: (bool -> JSX.Element) option with get, set
    /// <summary>Allows users to pass in an object contains custom CSS styles.</summary>
    /// <example>
    /// <code>
    /// &lt;SendBox styles={{ root: { background: 'blue' } }} /&gt;
    /// </code>
    /// </example>
    abstract styles: SendBoxStylesProps option with get, set
    /// Optional strings to override in component
    abstract strings: obj option with get, set
    /// enumerable to determine if the input box has focus on render or not.
    /// When undefined nothing has focus on render
    abstract autoFocus: string option with get, set

/// <summary>Selector type for <see cref="SendBox" /> component.</summary>
type [<AllowNullLiteral>] SendBoxSelector =
    /// <summary>Selector type for <see cref="SendBox" /> component.</summary>
    [<Emit("$0($1...)")>] abstract Invoke: state: ChatClientState * props: ChatBaseSelectorProps -> {| displayName: string; userId: string |}

/// <summary>Strings of <see cref="SendBox" /> that can be overridden.</summary>
type [<AllowNullLiteral>] SendBoxStrings =
    /// Placeholder text in SendBox when there is no user input
    abstract placeholderText: string with get, set
    /// The warning message when send box text length is more than max limit
    abstract textTooLong: string with get, set
    /// Aria label for send message button
    abstract sendButtonAriaLabel: string with get, set

/// <summary>Fluent styles for <see cref="Sendbox" />.</summary>
type [<AllowNullLiteral>] SendBoxStylesProps =
    inherit BaseCustomStyles
    /// Styles for the text field.
    abstract textField: IStyle option with get, set
    /// styles for the text field container
    abstract textFieldContainer: IStyle option with get, set
    /// Styles for the container of the send message icon.
    abstract sendMessageIconContainer: IStyle option with get, set
    /// Styles for the send message icon; These styles will be ignored when a custom send message icon is provided.
    abstract sendMessageIcon: IStyle option with get, set
    /// Styles for the system message; These styles will be ignored when a custom system message component is provided.
    abstract systemMessage: IStyle option with get, set

/// <summary>
/// Defines the methods that allow CallClient <see cref="@azure/communication-calling.CallClient" /> to be used statefully.
/// The interface provides access to proxied state and also allows registering a handler for state change events. For
/// state definition see <see cref="CallClientState" />.
///
/// State change events are driven by:
/// - Returned data from <see cref="@azure/communication-calling.DeviceManager" /> APIs.
/// - Returned data from <see cref="@azure/communication-calling.CallAgent" /> APIs.
/// - Listeners automatically attached to various azure communication-calling objects:
///    - CallAgent 'incomingCall'
///    - CallAgent 'callsUpdated'
///    - DeviceManager 'videoDevicesUpdated'
///    - DeviceManager 'audioDevicesUpdated
///    - DeviceManager 'selectedMicrophoneChanged'
///    - DeviceManager 'selectedSpeakerChanged'
///    - Call 'stateChanged'
///    - Call 'idChanged'
///    - Call 'isMutedChanged'
///    - Call 'isScreenSharingOnChanged'
///    - Call 'remoteParticipantsUpdated'
///    - Call 'localVideoStreamsUpdated'
///    - IncomingCall 'callEnded'
///    - RemoteParticipant 'stateChanged'
///    - RemoteParticipant 'isMutedChanged'
///    - RemoteParticipant 'displayNameChanged'
///    - RemoteParticipant 'isSpeakingChanged'
///    - RemoteParticipant 'videoStreamsUpdated'
///    - RemoteVideoStream 'isAvailableChanged'
///    - TranscriptionCallFeature 'isTranscriptionActiveChanged'
///    - RecordingCallFeature 'isRecordingActiveChanged'
/// </summary>
type [<AllowNullLiteral>] StatefulCallClient =
    inherit CallClient
    /// <summary>
    /// Holds all the state that we could proxy from CallClient <see cref="@azure/communication-calling.CallClient" /> as
    /// CallClientState <see cref="CallClientState" />.
    /// </summary>
    abstract getState: unit -> CallClientState
    /// <summary>Allows a handler to be registered for 'stateChanged' events.</summary>
    /// <param name="handler">Callback to receive the state.</param>
    abstract onStateChange: handler: (CallClientState -> unit) -> unit
    /// <summary>Allows unregistering for 'stateChanged' events.</summary>
    /// <param name="handler">Original callback to be unsubscribed.</param>
    abstract offStateChange: handler: (CallClientState -> unit) -> unit
    /// <summary>
    /// Renders a <see cref="RemoteVideoStreamState" /> or <see cref="LocalVideoStreamState" /> and stores the resulting
    /// <see cref="VideoStreamRendererViewState" /> under the relevant <see cref="RemoteVideoStreamState" /> or
    /// <see cref="LocalVideoStreamState" /> or as unparented view in the state. Under the hood calls
    /// <see cref="@azure/communication-calling.VideoStreamRenderer.createView" />.
    ///
    /// Scenario 1: Render RemoteVideoStreamState
    /// - CallId is required, participantId is required, and stream of type RemoteVideoStreamState is required
    /// - Resulting <see cref="VideoStreamRendererViewState" /> is stored in the given callId and participantId in
    /// <see cref="CallClientState" />
    ///
    /// Scenario 2: Render LocalVideoStreamState for a call
    /// - CallId is required, participantId must be undefined, and stream of type LocalVideoStreamState is required.
    /// - The <see cref="@azure/communication-calling.Call.localVideoStreams" /> must already be started using
    ///    <see cref="@azure/communication-calling.Call.startVideo" />.
    /// - Resulting <see cref="VideoStreamRendererViewState" /> is stored in the given callId <see cref="CallState.localVideoStreams" />
    ///    in <see cref="CallClientState" />.
    ///
    /// - Scenario 2: Render LocalVideoStreamState not part of a call (example rendering camera for local preview)
    /// - CallId must be undefined, participantId must be undefined, and stream of type LocalVideoStreamState is required.
    /// - Resulting <see cref="VideoStreamRendererViewState" /> is stored in under the given LocalVideoStreamState in
    ///    <see cref="CallClientState.deviceManager.unparentedViews" />
    /// </summary>
    /// <param name="callId">CallId for the given stream. Can be undefined if the stream is not part of any call.</param>
    /// <param name="participantId">
    /// <see cref="RemoteParticipant.identifier" /> associated with the given RemoteVideoStreamState. Could
    /// be undefined if rendering LocalVideoStreamState.
    /// </param>
    /// <param name="stream">The LocalVideoStreamState or RemoteVideoStreamState to start rendering.</param>
    /// <param name="options">Options that are passed to the {@link</param>
    abstract createView: callId: string option * participantId: CommunicationIdentifier option * stream: U2<LocalVideoStreamState, RemoteVideoStreamState> * ?options: CreateViewOptions -> Promise<CreateViewResult option>
    /// <summary>
    /// Stops rendering a <see cref="RemoteVideoStreamState" /> or <see cref="LocalVideoStreamState" /> and removes the
    /// <see cref="VideoStreamRendererView" /> from the relevant <see cref="RemoteVideoStreamState" /> in <see cref="CallClientState" /> or
    /// <see cref="LocalVideoStream" /> in <see cref="CallClientState" /> or appropriate
    /// <see cref="CallClientState.deviceManager.unparentedViews" /> Under the hood calls
    /// <see cref="@azure/communication-calling.VideoStreamRenderer.dispose" />.
    ///
    /// Its important to disposeView to clean up resources properly.
    ///
    /// Scenario 1: Dispose RemoteVideoStreamState
    /// - CallId is required, participantId is required, and stream of type RemoteVideoStreamState is required
    ///
    /// Scenario 2: Dispose LocalVideoStreamState for a call
    /// - CallId is required, participantId must be undefined, and stream of type LocalVideoStreamState is required.
    ///
    /// - Scenario 2: Dispose LocalVideoStreamState not part of a call
    /// - CallId must be undefined, participantId must be undefined, and stream of type LocalVideoStreamState is required.
    /// - LocalVideoStreamState must be the original one passed to createView.
    /// </summary>
    /// <param name="callId">CallId for the given stream. Can be undefined if the stream is not part of any call.</param>
    /// <param name="participantId">
    /// <see cref="RemoteParticipant.identifier" /> associated with the given RemoteVideoStreamState. Could
    /// be undefined if disposing LocalVideoStreamState.
    /// </param>
    /// <param name="stream">The LocalVideoStreamState or RemoteVideoStreamState to dispose.</param>
    abstract disposeView: callId: string option * participantId: CommunicationIdentifier option * stream: U2<LocalVideoStreamState, RemoteVideoStreamState> -> unit

/// <summary>Arguments to construct the StatefulCallClient.</summary>
type [<AllowNullLiteral>] StatefulCallClientArgs =
    /// UserId from SDK. This is provided for developer convenience to easily access the userId from the
    /// state. It is not used by StatefulCallClient.
    abstract userId: CommunicationUserIdentifier with get, set

/// <summary>Options to construct the StatefulCallClient with.</summary>
type [<AllowNullLiteral>] StatefulCallClientOptions =
    /// <summary>Options to construct the <see cref="@axure/communication-calling.CallClient" /> with.</summary>
    abstract callClientOptions: CallClientOptions with get, set
    /// Sets the max listeners limit of the 'stateChange' event. Defaults to the node.js EventEmitter.defaultMaxListeners
    /// if not specified.
    abstract maxStateChangeListeners: float option with get, set

/// <summary>
/// Defines the methods that allow {@Link @azure/communication-chat#ChatClient} to be used with a centralized generated state.
///
/// The interface provides access to proxied state and also allows registering a handler for state change events.
/// </summary>
type [<AllowNullLiteral>] StatefulChatClient =
    inherit ChatClient
    /// Holds all the state that we could proxy from ChatClient {@Link @azure/communication-chat#ChatClient} as
    /// ChatClientState {@Link ChatClientState}.
    abstract getState: unit -> ChatClientState
    /// <summary>Allows a handler to be registered for 'stateChanged' events.</summary>
    /// <param name="handler">Callback to receive the state.</param>
    abstract onStateChange: handler: (ChatClientState -> unit) -> unit
    /// <summary>Allows unregistering for 'stateChanged' events.</summary>
    /// <param name="handler">Original callback to be unsubscribed.</param>
    abstract offStateChange: handler: (ChatClientState -> unit) -> unit

/// <summary>Arguments to construct the <see cref="StatefulChatClient" />.</summary>
type [<AllowNullLiteral>] StatefulChatClientArgs =
    abstract userId: CommunicationUserIdentifier with get, set
    abstract displayName: string with get, set
    abstract endpoint: string with get, set
    abstract credential: CommunicationTokenCredential with get, set

/// <summary>Options to construct the <see cref="StatefulChatClient" />.</summary>
type [<AllowNullLiteral>] StatefulChatClientOptions =
    /// <summary>Options to construct the <see cref="@azure/communication-chat.ChatClient" /> with.</summary>
    abstract chatClientOptions: ChatClientOptions with get, set
    /// Sets the max listeners limit of the 'stateChange' event. Defaults to the node.js EventEmitter.defaultMaxListeners
    /// if not specified.
    abstract maxStateChangeListeners: float option with get, set

/// <summary>Defines the additional methods added by the stateful on top of <see cref="@azure/communication-calling.DeviceManager" />.</summary>
type [<AllowNullLiteral>] StatefulDeviceManager =
    inherit DeviceManager
    /// <summary>
    /// Sets the selectedCamera in the <see cref="DeviceManagerState" />. This is completely developer driven and is not tied in
    /// any way to <see cref="@azure/communication-calling.DeviceManager" />. It is entirely contained in
    /// <see cref="StatefulDeviceManager" />. See also <see cref="DeviceManagerState.selectedCamera" />.
    /// </summary>
    abstract selectCamera: (obj option -> unit) with get, set

/// <summary>Props for <see cref="StreamMedia" />.</summary>
type [<AllowNullLiteral>] StreamMediaProps =
    /// Video stream element to render.
    abstract videoStreamElement: HTMLElement option with get, set
    /// Decides whether to mirror the video or not.
    abstract isMirrored: bool option with get, set
    /// Whether the stream is loading data
    abstract loadingState: LoadingState option with get, set
    /// <summary>Allows users to pass in an object contains custom CSS styles.</summary>
    /// <example>
    /// <code>
    /// &lt;StreamMedia styles={{ root: { background: 'blue' } }} /&gt;
    /// </code>
    /// </example>
    abstract styles: BaseCustomStyles option with get, set

/// <summary>
/// Discriminated union of all system messages.
///
/// The <c>systemMessageType</c> field specializes into union variants.
/// </summary>
type SystemMessage =
    U4<ParticipantAddedSystemMessage, ParticipantRemovedSystemMessage, TopicUpdatedSystemMessage, ContentSystemMessage>

/// <summary>Common properties of all system messages.</summary>
type [<AllowNullLiteral>] SystemMessageCommon =
    inherit MessageCommon
    abstract messageType: string with get, set
    abstract iconName: string with get, set

/// <summary>Callback for <see cref="ChatAdapterSubscribers" /> 'topicChanged' event.</summary>
type [<AllowNullLiteral>] TopicChangedListener =
    /// <summary>Callback for <see cref="ChatAdapterSubscribers" /> 'topicChanged' event.</summary>
    [<Emit("$0($1...)")>] abstract Invoke: ``event``: {| topic: string |} -> unit

/// <summary>A system message notifying that the chat thread topic was updated.</summary>
type [<AllowNullLiteral>] TopicUpdatedSystemMessage =
    inherit SystemMessageCommon
    abstract systemMessageType: string with get, set
    abstract topic: string with get, set

/// <summary>
/// State only version of <see cref="@azure/communication-calling.TranscriptionCallFeature" />. <see cref="StatefulCallClient" /> will
/// automatically listen for transcription state of the call and update the state exposed by <see cref="StatefulCallClient" />
/// accordingly.
/// </summary>
type [<AllowNullLiteral>] TranscriptionCallFeature =
    /// <summary>Proxy of <see cref="@azure/communication-calling.TranscriptionCallFeature.isTranscriptionActive" />.</summary>
    abstract isTranscriptionActive: bool with get, set

/// <summary>Props for <see cref="TypingIndicator" />.</summary>
type [<AllowNullLiteral>] TypingIndicatorProps =
    /// List of the typing users.
    abstract typingUsers: ResizeArray<CommunicationParticipant> with get, set
    /// Callback to render typing users
    abstract onRenderUser: (CommunicationParticipant -> JSX.Element) option with get, set
    /// <summary>Allows users to pass in an object contains custom CSS styles.</summary>
    /// <example>
    /// <code>
    /// &lt;TypingIndicator styles={{ root: { background: 'blue' } }} /&gt;
    /// </code>
    /// </example>
    abstract styles: TypingIndicatorStylesProps option with get, set
    /// Optional strings to override in component
    abstract strings: obj option with get, set

/// <summary>Selector type for <see cref="TypingIndicator" /> component.</summary>
type [<AllowNullLiteral>] TypingIndicatorSelector =
    /// <summary>Selector type for <see cref="TypingIndicator" /> component.</summary>
    [<Emit("$0($1...)")>] abstract Invoke: state: ChatClientState * props: ChatBaseSelectorProps -> {| typingUsers: ResizeArray<CommunicationParticipant> |}

/// <summary>Strings of <see cref="TypingIndicator" /> that can be overridden.</summary>
type [<AllowNullLiteral>] TypingIndicatorStrings =
    /// <summary>String template to use when one user is typing. Placeholders: [user].</summary>
    /// <example>
    /// <code>
    /// &lt;TypingIndicator
    ///  strings={{ multipleUsersAbbreviateOne: '{users} is typing...' }}
    ///  typingUsers={[{ userId: 'user1', displayName: 'Claire' }]}
    /// /&gt;
    /// </code>
    /// would be 'Claire is typing...'
    /// </example>
    abstract singleUser: string with get, set
    /// <summary>String template to use when multiple users are typing. Placeholders: [users].</summary>
    /// <example>
    /// <code>
    /// &lt;TypingIndicator
    ///  strings={{ multipleUsers: '{users} are typing...' }}
    ///  typingUsers={[
    ///    { userId: 'user1', displayName: 'Claire' },
    ///    { userId: 'user2', displayName: 'Christopher' }
    ///  ]}
    /// /&gt;
    /// </code>
    /// would be 'Claire, Chris are typing...'
    /// </example>
    abstract multipleUsers: string with get, set
    /// <summary>String template to use when multiple users are typing with one other user abbreviated. Placeholders: [users].</summary>
    /// <example>
    /// <code lang="typescript">
    /// &lt;TypingIndicator
    /// strings={{ multipleUsersAbbreviateOne: '{users} and 1 other are typing...' }}
    /// typingUsers={[
    /// { userId: 'user1', displayName: 'Claire Romanov' },
    /// { userId: 'user2', displayName: 'Christopher Rutherford' }
    /// ]}
    /// /&gt;
    /// </code>
    /// would be 'Claire Romanov and 1 other are typing...'
    /// </example>
    abstract multipleUsersAbbreviateOne: string with get, set
    /// <summary>String template to use when multiple users are typing with one other user abbreviated. Placeholders: [users, numOthers].</summary>
    /// <example>
    /// <code>
    /// &lt;TypingIndicator
    ///  strings={{ multipleUsersAbbreviateMany: '{users} and {numOthers} others are typing...' }}
    ///  typingUsers={[
    ///    { userId: 'user1', displayName: 'Claire Romanov' },
    ///    { userId: 'user2', displayName: 'Christopher Rutherford' },
    ///    { userId: 'user3', displayName: 'Jill Vernblom' }
    ///  ]}
    /// /&gt;
    /// </code>
    /// would be 'Claire Romanov and 2 others are typing...'
    /// </example>
    abstract multipleUsersAbbreviateMany: string with get, set
    /// <summary>String to use as delimiter to separate multiple users.</summary>
    /// <example>
    /// <code>
    /// &lt;TypingIndicator
    ///  strings={{ delimiter: ' + ' }}
    ///  typingUsers={[
    ///    { userId: 'user1', displayName: 'Claire' },
    ///    { userId: 'user2', displayName: 'Chris' },
    ///    { userId: 'user3', displayName: 'Jill' }
    ///  ]}
    /// /&gt;
    /// </code>
    /// would be 'Claire + Chris + Jill are typing...'
    /// </example>
    abstract delimiter: string with get, set

/// <summary>Fluent styles for <see cref="TypingIndicator" />.</summary>
type [<AllowNullLiteral>] TypingIndicatorStylesProps =
    inherit BaseCustomStyles
    /// Styles for each typing user's displayName.
    abstract typingUserDisplayName: IStyle option with get, set
    /// Styles for the typing string.
    abstract typingString: IStyle option with get, set

type [<AllowNullLiteral>] UpdateMessageCallback =
    [<Emit("$0($1...)")>] abstract Invoke: messageId: string * content: string -> Promise<unit>

type [<StringEnum>] [<RequireQualifiedAccess>] VideoGalleryLayout =
    | Default
    | FloatingLocalVideo

/// <summary>The state of the local participant in the <see cref="VideoGallery" />.</summary>
type VideoGalleryLocalParticipant =
    VideoGalleryParticipant

/// <summary>The state of a participant in the <see cref="VideoGallery" />.</summary>
type [<AllowNullLiteral>] VideoGalleryParticipant =
    /// User ID of participant
    abstract userId: string with get, set
    /// Whether participant is muted
    abstract isMuted: bool option with get, set
    /// Display name of participant
    abstract displayName: string option with get, set
    /// Video stream of participant
    abstract videoStream: VideoGalleryStream option with get, set
    /// Whether participant is screen sharing or not
    abstract isScreenSharingOn: bool option with get, set

/// <summary>Props for <see cref="VideoGallery" />.</summary>
type [<AllowNullLiteral>] VideoGalleryProps =
    /// <summary>Allows users to pass an object containing custom CSS styles for the gallery container.</summary>
    /// <example>
    /// <code>
    /// &lt;VideoGallery styles={{ root: { border: 'solid 1px red' } }} /&gt;
    /// </code>
    /// </example>
    abstract styles: VideoGalleryStyles option with get, set
    /// Layout of the video tiles.
    abstract layout: VideoGalleryLayout option with get, set
    /// Local video particpant
    abstract localParticipant: VideoGalleryLocalParticipant with get, set
    /// List of remote video particpants
    abstract remoteParticipants: ResizeArray<VideoGalleryRemoteParticipant> option with get, set
    /// List of dominant speaker userIds in the order of their dominance. 0th index is the most dominant.
    abstract dominantSpeakers: ResizeArray<string> option with get, set
    /// Local video view options
    abstract localVideoViewOptions: VideoStreamOptions option with get, set
    /// Remote videos view options
    abstract remoteVideoViewOptions: VideoStreamOptions option with get, set
    /// Callback to create the local video stream view
    abstract onCreateLocalStreamView: ((VideoStreamOptions) option -> Promise<U2<unit, CreateVideoStreamViewResult>>) option with get, set
    /// Callback to dispose of the local video stream view
    abstract onDisposeLocalStreamView: (unit -> unit) option with get, set
    /// Callback to render the local video tile
    abstract onRenderLocalVideoTile: (VideoGalleryLocalParticipant -> JSX.Element) option with get, set
    /// Callback to create a remote video stream view
    abstract onCreateRemoteStreamView: (string -> (VideoStreamOptions) option -> Promise<U2<unit, CreateVideoStreamViewResult>>) option with get, set
    /// Callback to render a remote video tile
    abstract onRenderRemoteVideoTile: (VideoGalleryRemoteParticipant -> JSX.Element) option with get, set
    /// Callback to dispose a remote video stream view
    abstract onDisposeRemoteStreamView: (string -> Promise<unit>) option with get, set
    /// Callback to render a particpant avatar
    abstract onRenderAvatar: OnRenderAvatarCallback option with get, set
    /// Whether to display the local video camera switcher button
    abstract showCameraSwitcherInLocalPreview: bool option with get, set
    /// <summary>Whether to display a mute icon beside the user's display name.</summary>
    /// <default><c>true</c></default>
    abstract showMuteIndicator: bool option with get, set
    /// Optional strings to override in component
    abstract strings: obj option with get, set
    /// <summary>Maximum number of participant remote video streams that is rendered.</summary>
    /// <default>4</default>
    abstract maxRemoteVideoStreams: float option with get, set
    /// Camera control information for button to switch cameras.
    abstract localVideoCameraCycleButtonProps: LocalVideoCameraCycleButtonProps option with get, set

/// <summary>The state of a remote participant in the <see cref="VideoGallery" />.</summary>
type [<AllowNullLiteral>] VideoGalleryRemoteParticipant =
    inherit VideoGalleryParticipant
    /// Whether participant is speaking or not
    abstract isSpeaking: bool option with get, set
    /// Video stream of shared screen
    abstract screenShareStream: VideoGalleryStream option with get, set

/// <summary>Selector type for <see cref="VideoGallery" /> component.</summary>
type [<AllowNullLiteral>] VideoGallerySelector =
    /// <summary>Selector type for <see cref="VideoGallery" /> component.</summary>
    [<Emit("$0($1...)")>] abstract Invoke: state: CallClientState * props: CallingBaseSelectorProps -> {| screenShareParticipant: VideoGalleryRemoteParticipant option; localParticipant: VideoGalleryLocalParticipant; remoteParticipants: ResizeArray<VideoGalleryRemoteParticipant>; dominantSpeakers: ResizeArray<string> option |}

/// <summary>Video stream of a participant in <see cref="VideoGallery" />.</summary>
type [<AllowNullLiteral>] VideoGalleryStream =
    /// ID of the video stream
    abstract id: float option with get, set
    /// Whether the video stream is available or not
    abstract isAvailable: bool option with get, set
    /// Whether the video stream is receiving data or not
    abstract isReceiving: bool option with get, set
    /// Whether the video stream is mirrored or not
    abstract isMirrored: bool option with get, set
    /// Render element of the video stream
    abstract renderElement: HTMLElement option with get, set

/// <summary>All strings that may be shown on the UI in the <see cref="VideoGallery" />.</summary>
type [<AllowNullLiteral>] VideoGalleryStrings =
    /// String to notify that local user is sharing their screen
    abstract screenIsBeingSharedMessage: string with get, set
    /// String to show when remote screen share stream is loading
    abstract screenShareLoadingMessage: string with get, set
    /// String for local video label. Default is "You"
    abstract localVideoLabel: string with get, set
    /// String for local video camera switcher
    abstract localVideoCameraSwitcherLabel: string with get, set
    /// String for announcing the local video tile can be moved by keyboard controls
    abstract localVideoMovementLabel: string with get, set
    /// String for announcing the selected camera
    abstract localVideoSelectedDescription: string with get, set
    /// placeholder text for participants who does not have a display name
    abstract displayNamePlaceholder: string with get, set

/// <summary><see cref="VideoGallery" /> Component Styles.</summary>
type [<AllowNullLiteral>] VideoGalleryStyles =
    inherit BaseCustomStyles
    /// Styles for the grid layout
    abstract gridLayout: GridLayoutStyles option with get, set
    /// Styles for the horizontal gallery
    abstract horizontalGallery: HorizontalGalleryStyles option with get, set
    /// Styles for the local video
    abstract localVideo: IStyle option with get, set

/// <summary>Options to control how video streams are rendered.</summary>
type [<AllowNullLiteral>] VideoStreamOptions =
    /// Whether the video stream is mirrored or not
    abstract isMirrored: bool option with get, set
    /// <summary>Scaling mode. It can be <c>Stretch</c>, <c>Crop</c> or <c>Fit</c></summary>
    abstract scalingMode: ViewScalingMode option with get, set

/// <summary>
/// State only version of <see cref="@azure/communication-calling.VideoStreamRendererView" />. This property is added to the state exposed
/// by <see cref="StatefulCallClient" /> by <see cref="StatefulCallClient.createView" /> and removed by <see cref="StatefulCallClient.disposeView" />.
/// </summary>
type [<AllowNullLiteral>] VideoStreamRendererViewState =
    /// <summary>Proxy of <see cref="@azure/communication-calling.VideoStreamRendererView.scalingMode" />.</summary>
    abstract scalingMode: ScalingMode with get, set
    /// <summary>Proxy of <see cref="@azure/communication-calling.VideoStreamRendererView.isMirrored" />.</summary>
    abstract isMirrored: bool with get, set
    /// <summary>Proxy of <see cref="@azure/communication-calling.VideoStreamRendererView.target" />.</summary>
    abstract target: HTMLElement with get, set

/// <summary>Props for <see cref="VideoTile" />.</summary>
type [<AllowNullLiteral>] VideoTileProps =
    /// React Child components. Child Components will show as overlay component in the VideoTile.
    abstract children: React_2.ReactNode option with get, set
    /// <summary>Allows users to pass in an object contains custom CSS styles.</summary>
    /// <example>
    /// <code>
    /// &lt;VideoTile styles={{ root: { background: 'blue' } }} /&gt;
    /// </code>
    /// </example>
    abstract styles: VideoTileStylesProps option with get, set
    /// user id for the VideoTile placeholder.
    abstract userId: string option with get, set
    /// Component with the video stream.
    abstract renderElement: JSX.Element option with get, set
    /// Determines if the video is mirrored or not.
    abstract isMirrored: bool option with get, set
    /// Custom render Component function for no video is available. Render a Persona Icon if undefined.
    abstract onRenderPlaceholder: OnRenderAvatarCallback option with get, set
    /// <summary>Show label on the VideoTile</summary>
    /// <default>true</default>
    abstract showLabel: bool option with get, set
    /// <summary>Whether to display a mute icon beside the user's display name.</summary>
    /// <default>true</default>
    abstract showMuteIndicator: bool option with get, set
    /// Whether the video is muted or not.
    abstract isMuted: bool option with get, set
    /// <summary>Display Name of the Participant to be shown in the label.</summary>
    /// <remarks><c>displayName</c> is used to generate avatar initials if <c>initialsName</c> is not provided.</remarks>
    abstract displayName: string option with get, set
    /// <summary>Name of the participant used to generate initials. For example, a name <c>John Doe</c> will display <c>JD</c> as initials.</summary>
    /// <remarks><c>displayName</c> is used if this property is not specified.</remarks>
    abstract initialsName: string option with get, set
    /// <summary>
    /// Minimum size of the persona avatar in px.
    /// The persona avatar is the default placeholder shown when no video stream is available.
    /// For more information see <see href="https://developer.microsoft.com/en-us/fluentui#/controls/web/persona" />
    /// </summary>
    /// <default>32px</default>
    abstract personaMinSize: float option with get, set
    /// <summary>
    /// Maximum size of the personal avatar in px.
    /// The persona avatar is the default placeholder shown when no video stream is available.
    /// For more information see <see href="https://developer.microsoft.com/en-us/fluentui#/controls/web/persona" />
    /// </summary>
    /// <default>100px</default>
    abstract personaMaxSize: float option with get, set
    /// Optional property to set the aria label of the video tile if there is no available stream.
    abstract noVideoAvailableAriaLabel: string option with get, set
    /// Whether the participant in the videoTile is speaking. Shows a speaking indicator (border).
    abstract isSpeaking: bool option with get, set

/// <summary>Fluent styles for <see cref="VideoTile" />.</summary>
type [<AllowNullLiteral>] VideoTileStylesProps =
    inherit BaseCustomStyles
    /// Styles for video container.
    abstract videoContainer: IStyle option with get, set
    /// Styles for container overlayed on the video container.
    abstract overlayContainer: IStyle option with get, set
    /// Styles for displayName on the video container.
    abstract displayNameContainer: IStyle option with get, set

/// <summary>Scaling mode of a <see cref="VideoGalleryStream" />.</summary>
type [<StringEnum>] [<RequireQualifiedAccess>] ViewScalingMode =
    | [<CompiledName("Stretch")>] Stretch
    | [<CompiledName("Crop")>] Crop
    | [<CompiledName("Fit")>] Fit

type [<AllowNullLiteral>] DEFAULT_COMPONENT_ICONS =
    abstract ChatMessageOptions: JSX.Element with get, set
    abstract ControlButtonCameraOff: JSX.Element with get, set
    abstract ControlButtonCameraOn: JSX.Element with get, set
    abstract ControlButtonEndCall: JSX.Element with get, set
    abstract ControlButtonMicOff: JSX.Element with get, set
    abstract ControlButtonMicOn: JSX.Element with get, set
    abstract ControlButtonOptions: JSX.Element with get, set
    abstract ControlButtonParticipants: JSX.Element with get, set
    abstract ControlButtonScreenShareStart: JSX.Element with get, set
    abstract ControlButtonScreenShareStop: JSX.Element with get, set
    abstract EditBoxCancel: JSX.Element with get, set
    abstract EditBoxSubmit: JSX.Element with get, set
    abstract ErrorBarCallCameraAccessDenied: JSX.Element with get, set
    abstract ErrorBarCallCameraAlreadyInUse: JSX.Element with get, set
    abstract ErrorBarCallLocalVideoFreeze: JSX.Element with get, set
    abstract ErrorBarCallMacOsCameraAccessDenied: JSX.Element with get, set
    abstract ErrorBarCallMacOsMicrophoneAccessDenied: JSX.Element with get, set
    abstract ErrorBarCallMicrophoneAccessDenied: JSX.Element with get, set
    abstract ErrorBarCallMicrophoneMutedBySystem: JSX.Element with get, set
    abstract ErrorBarCallNetworkQualityLow: JSX.Element with get, set
    abstract ErrorBarCallNoMicrophoneFound: JSX.Element with get, set
    abstract ErrorBarCallNoSpeakerFound: JSX.Element with get, set
    abstract HorizontalGalleryLeftButton: JSX.Element with get, set
    abstract HorizontalGalleryRightButton: JSX.Element with get, set
    abstract MessageDelivered: JSX.Element with get, set
    abstract MessageEdit: JSX.Element with get, set
    abstract MessageFailed: JSX.Element with get, set
    abstract MessageRemove: JSX.Element with get, set
    abstract MessageResend: JSX.Element with get, set
    abstract MessageSeen: JSX.Element with get, set
    abstract MessageSending: JSX.Element with get, set
    abstract OptionsCamera: JSX.Element with get, set
    abstract OptionsMic: JSX.Element with get, set
    abstract OptionsSpeaker: JSX.Element with get, set
    abstract ParticipantItemMicOff: JSX.Element with get, set
    abstract ParticipantItemOptions: JSX.Element with get, set
    abstract ParticipantItemOptionsHovered: JSX.Element with get, set
    abstract ParticipantItemScreenShareStart: JSX.Element with get, set
    abstract SendBoxSend: JSX.Element with get, set
    abstract SendBoxSendHovered: JSX.Element with get, set
    abstract VideoTileMicOff: JSX.Element with get, set

type [<AllowNullLiteral>] DEFAULT_COMPOSITE_ICONS =
    abstract EditBoxCancel: JSX.Element with get, set
    abstract EditBoxSubmit: JSX.Element with get, set
    abstract MessageDelivered: JSX.Element with get, set
    abstract MessageEdit: JSX.Element with get, set
    abstract MessageFailed: JSX.Element with get, set
    abstract MessageRemove: JSX.Element with get, set
    abstract MessageSeen: JSX.Element with get, set
    abstract MessageSending: JSX.Element with get, set
    abstract ParticipantItemOptions: JSX.Element with get, set
    abstract ParticipantItemOptionsHovered: JSX.Element with get, set
    abstract SendBoxSend: JSX.Element with get, set
    abstract SendBoxSendHovered: JSX.Element with get, set
    abstract ControlButtonCameraOff: JSX.Element with get, set
    abstract ControlButtonCameraOn: JSX.Element with get, set
    abstract ControlButtonEndCall: JSX.Element with get, set
    abstract ControlButtonMicOff: JSX.Element with get, set
    abstract ControlButtonMicOn: JSX.Element with get, set
    abstract ControlButtonOptions: JSX.Element with get, set
    abstract ControlButtonParticipants: JSX.Element with get, set
    abstract ControlButtonScreenShareStart: JSX.Element with get, set
    abstract ControlButtonScreenShareStop: JSX.Element with get, set
    abstract ErrorBarCallCameraAccessDenied: JSX.Element with get, set
    abstract ErrorBarCallCameraAlreadyInUse: JSX.Element with get, set
    abstract ErrorBarCallLocalVideoFreeze: JSX.Element with get, set
    abstract ErrorBarCallMacOsCameraAccessDenied: JSX.Element with get, set
    abstract ErrorBarCallMacOsMicrophoneAccessDenied: JSX.Element with get, set
    abstract ErrorBarCallMicrophoneAccessDenied: JSX.Element with get, set
    abstract ErrorBarCallMicrophoneMutedBySystem: JSX.Element with get, set
    abstract ErrorBarCallNetworkQualityLow: JSX.Element with get, set
    abstract ErrorBarCallNoMicrophoneFound: JSX.Element with get, set
    abstract ErrorBarCallNoSpeakerFound: JSX.Element with get, set
    abstract HorizontalGalleryLeftButton: JSX.Element with get, set
    abstract HorizontalGalleryRightButton: JSX.Element with get, set
    abstract LobbyScreenConnectingToCall: JSX.Element option with get, set
    abstract LobbyScreenWaitingToBeAdmitted: JSX.Element option with get, set
    abstract LocalDeviceSettingsCamera: JSX.Element option with get, set
    abstract LocalDeviceSettingsMic: JSX.Element option with get, set
    abstract LocalDeviceSettingsSpeaker: JSX.Element option with get, set
    abstract LocalPreviewPlaceholder: JSX.Element option with get, set
    abstract Muted: JSX.Element option with get, set
    abstract NetworkReconnectIcon: JSX.Element option with get, set
    abstract NoticePageAccessDeniedTeamsMeeting: JSX.Element option with get, set
    abstract NoticePageJoinCallFailedDueToNoNetwork: JSX.Element option with get, set
    abstract NoticePageLeftCall: JSX.Element option with get, set
    abstract NoticePageRemovedFromCall: JSX.Element option with get, set
    abstract OptionsCamera: JSX.Element with get, set
    abstract OptionsMic: JSX.Element with get, set
    abstract OptionsSpeaker: JSX.Element with get, set
    abstract ParticipantItemMicOff: JSX.Element with get, set
    abstract ParticipantItemScreenShareStart: JSX.Element with get, set
    abstract VideoTileMicOff: JSX.Element with get, set
    abstract LocalCameraSwitch: JSX.Element option with get, set
    abstract ChevronLeft: JSX.Element option with get, set
    abstract ControlBarChatButtonActive: JSX.Element option with get, set
    abstract ControlBarChatButtonInactive: JSX.Element option with get, set
    abstract ControlBarPeopleButton: JSX.Element option with get, set
    abstract Link: JSX.Element option with get, set
    abstract MoreDrawerMicrophones: JSX.Element option with get, set
    abstract MoreDrawerPeople: JSX.Element option with get, set
    abstract MoreDrawerSelectedMicrophone: JSX.Element option with get, set
    abstract MoreDrawerSelectedSpeaker: JSX.Element option with get, set
    abstract MoreDrawerSpeakers: JSX.Element option with get, set
    abstract SendBoxAttachFile: JSX.Element option with get, set
    abstract ChatMessageOptions: JSX.Element with get, set
    abstract MessageResend: JSX.Element with get, set

type [<StringEnum>] [<RequireQualifiedAccess>] UsePropsFor =
    | Chat
    | Calling

type [<AllowNullLiteral>] CallClientStateCalls =
    [<EmitIndexer>] abstract Item: key: string -> CallState with get, set

type [<AllowNullLiteral>] CallClientStateIncomingCalls =
    [<EmitIndexer>] abstract Item: key: string -> IncomingCallState with get, set

type [<StringEnum>] [<RequireQualifiedAccess>] CallCompositePropsFormFactor =
    | Desktop
    | Mobile

type [<AllowNullLiteral>] CallStateRemoteParticipants =
    [<EmitIndexer>] abstract Item: keys: string -> RemoteParticipantState with get, set

type [<AllowNullLiteral>] ChatClientStateThreads =
    [<EmitIndexer>] abstract Item: key: string -> ChatThreadClientState with get, set

type [<AllowNullLiteral>] ChatThreadClientStateChatMessages =
    [<EmitIndexer>] abstract Item: key: string -> ChatMessageWithStatus with get, set

type [<AllowNullLiteral>] ChatThreadClientStateParticipants =
    [<EmitIndexer>] abstract Item: key: string -> ChatParticipant with get, set

type [<AllowNullLiteral>] RemoteParticipantStateVideoStreams =
    [<EmitIndexer>] abstract Item: key: float -> RemoteVideoStreamState with get, set
