//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#pragma warning disable 1591

// Option: missing-value detection (*Specified/ShouldSerialize*/Reset*) enabled
    
// Generated from: steammessages_video.steamclient.proto
// Note: requires additional types generated from: steammessages_unified_base.steamclient.proto
namespace SteamKit2.Unified.Internal
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CVideo_ClientGetVideoURL_Request")]
  public partial class CVideo_ClientGetVideoURL_Request : global::ProtoBuf.IExtensible
  {
    public CVideo_ClientGetVideoURL_Request() {}
    

    private ulong? _video_id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"video_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public ulong video_id
    {
      get { return _video_id?? default(ulong); }
      set { _video_id = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool video_idSpecified
    {
      get { return _video_id != null; }
      set { if (value == (_video_id== null)) _video_id = value ? this.video_id : (ulong?)null; }
    }
    private bool ShouldSerializevideo_id() { return video_idSpecified; }
    private void Resetvideo_id() { video_idSpecified = false; }
    

    private uint? _client_cellid;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"client_cellid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint client_cellid
    {
      get { return _client_cellid?? default(uint); }
      set { _client_cellid = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool client_cellidSpecified
    {
      get { return _client_cellid != null; }
      set { if (value == (_client_cellid== null)) _client_cellid = value ? this.client_cellid : (uint?)null; }
    }
    private bool ShouldSerializeclient_cellid() { return client_cellidSpecified; }
    private void Resetclient_cellid() { client_cellidSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CVideo_ClientGetVideoURL_Response")]
  public partial class CVideo_ClientGetVideoURL_Response : global::ProtoBuf.IExtensible
  {
    public CVideo_ClientGetVideoURL_Response() {}
    

    private ulong? _video_id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"video_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public ulong video_id
    {
      get { return _video_id?? default(ulong); }
      set { _video_id = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool video_idSpecified
    {
      get { return _video_id != null; }
      set { if (value == (_video_id== null)) _video_id = value ? this.video_id : (ulong?)null; }
    }
    private bool ShouldSerializevideo_id() { return video_idSpecified; }
    private void Resetvideo_id() { video_idSpecified = false; }
    

    private string _video_url;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"video_url", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string video_url
    {
      get { return _video_url?? ""; }
      set { _video_url = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool video_urlSpecified
    {
      get { return _video_url != null; }
      set { if (value == (_video_url== null)) _video_url = value ? this.video_url : (string)null; }
    }
    private bool ShouldSerializevideo_url() { return video_urlSpecified; }
    private void Resetvideo_url() { video_urlSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"VideoBookmark")]
  public partial class VideoBookmark : global::ProtoBuf.IExtensible
  {
    public VideoBookmark() {}
    

    private uint? _app_id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"app_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint app_id
    {
      get { return _app_id?? default(uint); }
      set { _app_id = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool app_idSpecified
    {
      get { return _app_id != null; }
      set { if (value == (_app_id== null)) _app_id = value ? this.app_id : (uint?)null; }
    }
    private bool ShouldSerializeapp_id() { return app_idSpecified; }
    private void Resetapp_id() { app_idSpecified = false; }
    

    private uint? _playback_position_in_seconds;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"playback_position_in_seconds", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint playback_position_in_seconds
    {
      get { return _playback_position_in_seconds?? default(uint); }
      set { _playback_position_in_seconds = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool playback_position_in_secondsSpecified
    {
      get { return _playback_position_in_seconds != null; }
      set { if (value == (_playback_position_in_seconds== null)) _playback_position_in_seconds = value ? this.playback_position_in_seconds : (uint?)null; }
    }
    private bool ShouldSerializeplayback_position_in_seconds() { return playback_position_in_secondsSpecified; }
    private void Resetplayback_position_in_seconds() { playback_position_in_secondsSpecified = false; }
    

    private ulong? _video_track_id;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"video_track_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public ulong video_track_id
    {
      get { return _video_track_id?? default(ulong); }
      set { _video_track_id = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool video_track_idSpecified
    {
      get { return _video_track_id != null; }
      set { if (value == (_video_track_id== null)) _video_track_id = value ? this.video_track_id : (ulong?)null; }
    }
    private bool ShouldSerializevideo_track_id() { return video_track_idSpecified; }
    private void Resetvideo_track_id() { video_track_idSpecified = false; }
    

    private ulong? _audio_track_id;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"audio_track_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public ulong audio_track_id
    {
      get { return _audio_track_id?? default(ulong); }
      set { _audio_track_id = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool audio_track_idSpecified
    {
      get { return _audio_track_id != null; }
      set { if (value == (_audio_track_id== null)) _audio_track_id = value ? this.audio_track_id : (ulong?)null; }
    }
    private bool ShouldSerializeaudio_track_id() { return audio_track_idSpecified; }
    private void Resetaudio_track_id() { audio_track_idSpecified = false; }
    

    private ulong? _timedtext_track_id;
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"timedtext_track_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public ulong timedtext_track_id
    {
      get { return _timedtext_track_id?? default(ulong); }
      set { _timedtext_track_id = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool timedtext_track_idSpecified
    {
      get { return _timedtext_track_id != null; }
      set { if (value == (_timedtext_track_id== null)) _timedtext_track_id = value ? this.timedtext_track_id : (ulong?)null; }
    }
    private bool ShouldSerializetimedtext_track_id() { return timedtext_track_idSpecified; }
    private void Resettimedtext_track_id() { timedtext_track_idSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CVideo_SetVideoBookmark_Notification")]
  public partial class CVideo_SetVideoBookmark_Notification : global::ProtoBuf.IExtensible
  {
    public CVideo_SetVideoBookmark_Notification() {}
    
    private readonly global::System.Collections.Generic.List<VideoBookmark> _bookmarks = new global::System.Collections.Generic.List<VideoBookmark>();
    [global::ProtoBuf.ProtoMember(1, Name=@"bookmarks", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<VideoBookmark> bookmarks
    {
      get { return _bookmarks; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CVideo_GetVideoBookmarks_Request")]
  public partial class CVideo_GetVideoBookmarks_Request : global::ProtoBuf.IExtensible
  {
    public CVideo_GetVideoBookmarks_Request() {}
    
    private readonly global::System.Collections.Generic.List<uint> _appids = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(1, Name=@"appids", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> appids
    {
      get { return _appids; }
    }
  

    private uint? _updated_since;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"updated_since", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint updated_since
    {
      get { return _updated_since?? default(uint); }
      set { _updated_since = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool updated_sinceSpecified
    {
      get { return _updated_since != null; }
      set { if (value == (_updated_since== null)) _updated_since = value ? this.updated_since : (uint?)null; }
    }
    private bool ShouldSerializeupdated_since() { return updated_sinceSpecified; }
    private void Resetupdated_since() { updated_sinceSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CVideo_GetVideoBookmarks_Response")]
  public partial class CVideo_GetVideoBookmarks_Response : global::ProtoBuf.IExtensible
  {
    public CVideo_GetVideoBookmarks_Response() {}
    
    private readonly global::System.Collections.Generic.List<VideoBookmark> _bookmarks = new global::System.Collections.Generic.List<VideoBookmark>();
    [global::ProtoBuf.ProtoMember(1, Name=@"bookmarks", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<VideoBookmark> bookmarks
    {
      get { return _bookmarks; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CVideo_UnlockedH264_Notification")]
  public partial class CVideo_UnlockedH264_Notification : global::ProtoBuf.IExtensible
  {
    public CVideo_UnlockedH264_Notification() {}
    

    private byte[] _encryption_key;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"encryption_key", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] encryption_key
    {
      get { return _encryption_key?? null; }
      set { _encryption_key = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool encryption_keySpecified
    {
      get { return _encryption_key != null; }
      set { if (value == (_encryption_key== null)) _encryption_key = value ? this.encryption_key : (byte[])null; }
    }
    private bool ShouldSerializeencryption_key() { return encryption_keySpecified; }
    private void Resetencryption_key() { encryption_keySpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CFovasVideo_ClientGetOPFSettings_Request")]
  public partial class CFovasVideo_ClientGetOPFSettings_Request : global::ProtoBuf.IExtensible
  {
    public CFovasVideo_ClientGetOPFSettings_Request() {}
    

    private uint? _app_id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"app_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint app_id
    {
      get { return _app_id?? default(uint); }
      set { _app_id = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool app_idSpecified
    {
      get { return _app_id != null; }
      set { if (value == (_app_id== null)) _app_id = value ? this.app_id : (uint?)null; }
    }
    private bool ShouldSerializeapp_id() { return app_idSpecified; }
    private void Resetapp_id() { app_idSpecified = false; }
    

    private uint? _client_cellid;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"client_cellid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint client_cellid
    {
      get { return _client_cellid?? default(uint); }
      set { _client_cellid = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool client_cellidSpecified
    {
      get { return _client_cellid != null; }
      set { if (value == (_client_cellid== null)) _client_cellid = value ? this.client_cellid : (uint?)null; }
    }
    private bool ShouldSerializeclient_cellid() { return client_cellidSpecified; }
    private void Resetclient_cellid() { client_cellidSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CFovasVideo_ClientGetOPFSettings_Response")]
  public partial class CFovasVideo_ClientGetOPFSettings_Response : global::ProtoBuf.IExtensible
  {
    public CFovasVideo_ClientGetOPFSettings_Response() {}
    

    private uint? _app_id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"app_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint app_id
    {
      get { return _app_id?? default(uint); }
      set { _app_id = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool app_idSpecified
    {
      get { return _app_id != null; }
      set { if (value == (_app_id== null)) _app_id = value ? this.app_id : (uint?)null; }
    }
    private bool ShouldSerializeapp_id() { return app_idSpecified; }
    private void Resetapp_id() { app_idSpecified = false; }
    

    private string _opf_settings;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"opf_settings", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string opf_settings
    {
      get { return _opf_settings?? ""; }
      set { _opf_settings = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool opf_settingsSpecified
    {
      get { return _opf_settings != null; }
      set { if (value == (_opf_settings== null)) _opf_settings = value ? this.opf_settings : (string)null; }
    }
    private bool ShouldSerializeopf_settings() { return opf_settingsSpecified; }
    private void Resetopf_settings() { opf_settingsSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    public interface IVideo
    {
      CVideo_ClientGetVideoURL_Response ClientGetVideoURL(CVideo_ClientGetVideoURL_Request request);
    NoResponse SetVideoBookmark(CVideo_SetVideoBookmark_Notification request);
    CVideo_GetVideoBookmarks_Response GetVideoBookmarks(CVideo_GetVideoBookmarks_Request request);
    
    }
    
    
    public interface IVideoClient
    {
      NoResponse NotifyUnlockedH264(CVideo_UnlockedH264_Notification request);
    
    }
    
    
    public interface IFovasVideo
    {
      CFovasVideo_ClientGetOPFSettings_Response ClientGetOPFSettings(CFovasVideo_ClientGetOPFSettings_Request request);
    
    }
    
    
}
#pragma warning restore 1591
