using System;
using System.Runtime.InteropServices;

namespace FmodManaged.FSOUND.Enums
{

	/// <summary>
	/// Miscellaneous values for FMOD functions.
	/// </summary>
	public enum FSOUND_MISC_VALUES
	{
		/// <summary>
		/// value to play on any free channel, or to allocate a sample in a free sample slot.
		/// </summary>
		FSOUND_FREE = -1,
		/// <summary>
		///  value to allocate a sample that is NOT managed by FSOUND or placed in a sample slot. 
		/// </summary>
		FSOUND_UNMANAGED = -2,
		/// <summary>
		/// for a channel index , this flag will affect ALL channels available! Not supported by every function.
		/// </summary>
		FSOUND_ALL = -3,			
		/// <summary>
		/// value for FSOUND_SetPan so that stereo sounds are not played at half volume. See FSOUND_SetPan for more on this.
		/// </summary>
		FSOUND_STEREOPAN = -1,		
		/// <summary>
		/// special 'channel' ID for all channel based functions that want to alter the global FSOUND software mixing output channel
		/// </summary>
		FSOUND_SYSTEMCHANNEL = -1000, 
		/// <summary>
		/// special 'sample' ID for all sample based functions that want to alter the global FSOUND software mixing output sample 
		/// </summary>
		FSOUND_SYSTEMSAMPLE = -1000	
	}
	/*
		/// <summary>
		/// A set of predefined environment PARAMETERS, created by Creative Labs
		/// These are used to initialize an FSOUND_REVERB_PROPERTIES structure statically.
		/// </summary>
		public enum FSOUND_REVERB_PRESETS
		{
			FSOUND_PRESET_OFF = {0, 7.5f, 1.00f, -10000, -10000, 0, 1.00f, 1.00f, 1.0f, -2602, 0.007f, { 0.0f,0.0f,0.0f }, 200, 0.011f, { 0.0f,0.0f,0.0f }, 0.250f, 0.00f, 0.25f, 0.000f, -5.0f, 5000.0f, 250.0f, 0.0f, 0.0f, 0.0f, 0x33f }  
			FSOUND_PRESET_GENERIC {0, 7.5f, 1.00f, -1000, -100, 0, 1.49f, 0.83f, 1.0f, -2602, 0.007f, { 0.0f,0.0f,0.0f }, 200, 0.011f, { 0.0f,0.0f,0.0f }, 0.250f, 0.00f, 0.25f, 0.000f, -5.0f, 5000.0f, 250.0f, 0.0f, 100.0f, 100.0f, 0x3f }  
			FSOUND_PRESET_PADDEDCELL {1, 1.4f, 1.00f, -1000, -6000, 0, 0.17f, 0.10f, 1.0f, -1204, 0.001f, { 0.0f,0.0f,0.0f }, 207, 0.002f, { 0.0f,0.0f,0.0f }, 0.250f, 0.00f, 0.25f, 0.000f, -5.0f, 5000.0f, 250.0f, 0.0f, 100.0f, 100.0f, 0x3f }  
			FSOUND_PRESET_ROOM {2, 1.9f, 1.00f, -1000, -454, 0, 0.40f, 0.83f, 1.0f, -1646, 0.002f, { 0.0f,0.0f,0.0f }, 53, 0.003f, { 0.0f,0.0f,0.0f }, 0.250f, 0.00f, 0.25f, 0.000f, -5.0f, 5000.0f, 250.0f, 0.0f, 100.0f, 100.0f, 0x3f }  
			FSOUND_PRESET_BATHROOM {3, 1.4f, 1.00f, -1000, -1200, 0, 1.49f, 0.54f, 1.0f, -370, 0.007f, { 0.0f,0.0f,0.0f }, 1030, 0.011f, { 0.0f,0.0f,0.0f }, 0.250f, 0.00f, 0.25f, 0.000f, -5.0f, 5000.0f, 250.0f, 0.0f, 100.0f, 60.0f, 0x3f }  
			FSOUND_PRESET_LIVINGROOM {4, 2.5f, 1.00f, -1000, -6000, 0, 0.50f, 0.10f, 1.0f, -1376, 0.003f, { 0.0f,0.0f,0.0f }, -1104, 0.004f, { 0.0f,0.0f,0.0f }, 0.250f, 0.00f, 0.25f, 0.000f, -5.0f, 5000.0f, 250.0f, 0.0f, 100.0f, 100.0f, 0x3f }  
			FSOUND_PRESET_STONEROOM {5, 11.6f, 1.00f, -1000, -300, 0, 2.31f, 0.64f, 1.0f, -711, 0.012f, { 0.0f,0.0f,0.0f }, 83, 0.017f, { 0.0f,0.0f,0.0f }, 0.250f, 0.00f, 0.25f, 0.000f, -5.0f, 5000.0f, 250.0f, 0.0f, 100.0f, 100.0f, 0x3f }  
			FSOUND_PRESET_AUDITORIUM {6, 21.6f, 1.00f, -1000, -476, 0, 4.32f, 0.59f, 1.0f, -789, 0.020f, { 0.0f,0.0f,0.0f }, -289, 0.030f, { 0.0f,0.0f,0.0f }, 0.250f, 0.00f, 0.25f, 0.000f, -5.0f, 5000.0f, 250.0f, 0.0f, 100.0f, 100.0f, 0x3f }  
			FSOUND_PRESET_CONCERTHALL {7, 19.6f, 1.00f, -1000, -500, 0, 3.92f, 0.70f, 1.0f, -1230, 0.020f, { 0.0f,0.0f,0.0f }, -2, 0.029f, { 0.0f,0.0f,0.0f }, 0.250f, 0.00f, 0.25f, 0.000f, -5.0f, 5000.0f, 250.0f, 0.0f, 100.0f, 100.0f, 0x3f }  
			FSOUND_PRESET_CAVE {8, 14.6f, 1.00f, -1000, 0, 0, 2.91f, 1.30f, 1.0f, -602, 0.015f, { 0.0f,0.0f,0.0f }, -302, 0.022f, { 0.0f,0.0f,0.0f }, 0.250f, 0.00f, 0.25f, 0.000f, -5.0f, 5000.0f, 250.0f, 0.0f, 100.0f, 100.0f, 0x1f }  
			FSOUND_PRESET_ARENA {9, 36.2f, 1.00f, -1000, -698, 0, 7.24f, 0.33f, 1.0f, -1166, 0.020f, { 0.0f,0.0f,0.0f }, 16, 0.030f, { 0.0f,0.0f,0.0f }, 0.250f, 0.00f, 0.25f, 0.000f, -5.0f, 5000.0f, 250.0f, 0.0f, 100.0f, 100.0f, 0x3f }  
			FSOUND_PRESET_HANGAR {10, 50.3f, 1.00f, -1000, -1000, 0, 10.05f, 0.23f, 1.0f, -602, 0.020f, { 0.0f,0.0f,0.0f }, 198, 0.030f, { 0.0f,0.0f,0.0f }, 0.250f, 0.00f, 0.25f, 0.000f, -5.0f, 5000.0f, 250.0f, 0.0f, 100.0f, 100.0f, 0x3f }  
			FSOUND_PRESET_CARPETTEDHALLWAY {11, 1.9f, 1.00f, -1000, -4000, 0, 0.30f, 0.10f, 1.0f, -1831, 0.002f, { 0.0f,0.0f,0.0f }, -1630, 0.030f, { 0.0f,0.0f,0.0f }, 0.250f, 0.00f, 0.25f, 0.000f, -5.0f, 5000.0f, 250.0f, 0.0f, 100.0f, 100.0f, 0x3f }  
			FSOUND_PRESET_HALLWAY {12, 1.8f, 1.00f, -1000, -300, 0, 1.49f, 0.59f, 1.0f, -1219, 0.007f, { 0.0f,0.0f,0.0f }, 441, 0.011f, { 0.0f,0.0f,0.0f }, 0.250f, 0.00f, 0.25f, 0.000f, -5.0f, 5000.0f, 250.0f, 0.0f, 100.0f, 100.0f, 0x3f }  
			FSOUND_PRESET_STONECORRIDOR {13, 13.5f, 1.00f, -1000, -237, 0, 2.70f, 0.79f, 1.0f, -1214, 0.013f, { 0.0f,0.0f,0.0f }, 395, 0.020f, { 0.0f,0.0f,0.0f }, 0.250f, 0.00f, 0.25f, 0.000f, -5.0f, 5000.0f, 250.0f, 0.0f, 100.0f, 100.0f, 0x3f }  
			FSOUND_PRESET_ALLEY {14, 7.5f, 0.30f, -1000, -270, 0, 1.49f, 0.86f, 1.0f, -1204, 0.007f, { 0.0f,0.0f,0.0f }, -4, 0.011f, { 0.0f,0.0f,0.0f }, 0.125f, 0.95f, 0.25f, 0.000f, -5.0f, 5000.0f, 250.0f, 0.0f, 100.0f, 100.0f, 0x3f }  
			FSOUND_PRESET_FOREST {15, 38.0f, 0.30f, -1000, -3300, 0, 1.49f, 0.54f, 1.0f, -2560, 0.162f, { 0.0f,0.0f,0.0f }, -229, 0.088f, { 0.0f,0.0f,0.0f }, 0.125f, 1.00f, 0.25f, 0.000f, -5.0f, 5000.0f, 250.0f, 0.0f, 79.0f, 100.0f, 0x3f }  
			FSOUND_PRESET_CITY {16, 7.5f, 0.50f, -1000, -800, 0, 1.49f, 0.67f, 1.0f, -2273, 0.007f, { 0.0f,0.0f,0.0f }, -1691, 0.011f, { 0.0f,0.0f,0.0f }, 0.250f, 0.00f, 0.25f, 0.000f, -5.0f, 5000.0f, 250.0f, 0.0f, 50.0f, 100.0f, 0x3f }  
			FSOUND_PRESET_MOUNTAINS {17, 100.0f, 0.27f, -1000, -2500, 0, 1.49f, 0.21f, 1.0f, -2780, 0.300f, { 0.0f,0.0f,0.0f }, -1434, 0.100f, { 0.0f,0.0f,0.0f }, 0.250f, 1.00f, 0.25f, 0.000f, -5.0f, 5000.0f, 250.0f, 0.0f, 27.0f, 100.0f, 0x1f }  
			FSOUND_PRESET_QUARRY {18, 17.5f, 1.00f, -1000, -1000, 0, 1.49f, 0.83f, 1.0f, -10000, 0.061f, { 0.0f,0.0f,0.0f }, 500, 0.025f, { 0.0f,0.0f,0.0f }, 0.125f, 0.70f, 0.25f, 0.000f, -5.0f, 5000.0f, 250.0f, 0.0f, 100.0f, 100.0f, 0x3f }  
			FSOUND_PRESET_PLAIN {19, 42.5f, 0.21f, -1000, -2000, 0, 1.49f, 0.50f, 1.0f, -2466, 0.179f, { 0.0f,0.0f,0.0f }, -1926, 0.100f, { 0.0f,0.0f,0.0f }, 0.250f, 1.00f, 0.25f, 0.000f, -5.0f, 5000.0f, 250.0f, 0.0f, 21.0f, 100.0f, 0x3f }  
			FSOUND_PRESET_PARKINGLOT {20, 8.3f, 1.00f, -1000, 0, 0, 1.65f, 1.50f, 1.0f, -1363, 0.008f, { 0.0f,0.0f,0.0f }, -1153, 0.012f, { 0.0f,0.0f,0.0f }, 0.250f, 0.00f, 0.25f, 0.000f, -5.0f, 5000.0f, 250.0f, 0.0f, 100.0f, 100.0f, 0x1f }  
			FSOUND_PRESET_SEWERPIPE {21, 1.7f, 0.80f, -1000, -1000, 0, 2.81f, 0.14f, 1.0f, 429, 0.014f, { 0.0f,0.0f,0.0f }, 1023, 0.021f, { 0.0f,0.0f,0.0f }, 0.250f, 0.00f, 0.25f, 0.000f, -5.0f, 5000.0f, 250.0f, 0.0f, 80.0f, 60.0f, 0x3f }  
			FSOUND_PRESET_UNDERWATER {22, 1.8f, 1.00f, -1000, -4000, 0, 1.49f, 0.10f, 1.0f, -449, 0.007f, { 0.0f,0.0f,0.0f }, 1700, 0.011f, { 0.0f,0.0f,0.0f }, 0.250f, 0.00f, 1.18f, 0.348f, -5.0f, 5000.0f, 250.0f, 0.0f, 100.0f, 100.0f, 0x3f }  
			FSOUND_PRESET_DRUGGED {23, 1.9f, 0.50f, -1000, 0, 0, 8.39f, 1.39f, 1.0f, -115, 0.002f, { 0.0f,0.0f,0.0f }, 985, 0.030f, { 0.0f,0.0f,0.0f }, 0.250f, 0.00f, 0.25f, 1.000f, -5.0f, 5000.0f, 250.0f, 0.0f, 100.0f, 100.0f, 0x1f }  
			FSOUND_PRESET_DIZZY {24, 1.8f, 0.60f, -1000, -400, 0, 17.23f, 0.56f, 1.0f, -1713, 0.020f, { 0.0f,0.0f,0.0f }, -613, 0.030f, { 0.0f,0.0f,0.0f }, 0.250f, 1.00f, 0.81f, 0.310f, -5.0f, 5000.0f, 250.0f, 0.0f, 100.0f, 100.0f, 0x1f }  
			FSOUND_PRESET_PSYCHOTIC {25, 1.0f, 0.50f, -1000, -151, 0, 7.56f, 0.91f, 1.0f, -626, 0.020f, { 0.0f,0.0f,0.0f }, 774, 0.030f, { 0.0f,0.0f,0.0f }, 0.250f, 0.00f, 4.00f, 1.000f, -5.0f, 5000.0f, 250.0f, 0.0f, 100.0f, 100.0f, 0x1f }  
			FSOUND_PRESET_PS2_ROOM {1, 0, 0, 0, 0, 0, 0.0f, 0.0f, 0.0f, 0, 0.000f, { 0.0f,0.0f,0.0f }, 0, 0.000f, { 0.0f,0.0f,0.0f }, 0.000f, 0.00f, 0.00f, 0.000f, 0.0f, 0000.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0x31f }  
			FSOUND_PRESET_PS2_STUDIO_A {2, 0, 0, 0, 0, 0, 0.0f, 0.0f, 0.0f, 0, 0.000f, { 0.0f,0.0f,0.0f }, 0, 0.000f, { 0.0f,0.0f,0.0f }, 0.000f, 0.00f, 0.00f, 0.000f, 0.0f, 0000.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0x31f }  
			FSOUND_PRESET_PS2_STUDIO_B {3, 0, 0, 0, 0, 0, 0.0f, 0.0f, 0.0f, 0, 0.000f, { 0.0f,0.0f,0.0f }, 0, 0.000f, { 0.0f,0.0f,0.0f }, 0.000f, 0.00f, 0.00f, 0.000f, 0.0f, 0000.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0x31f }  
			FSOUND_PRESET_PS2_STUDIO_C {4, 0, 0, 0, 0, 0, 0.0f, 0.0f, 0.0f, 0, 0.000f, { 0.0f,0.0f,0.0f }, 0, 0.000f, { 0.0f,0.0f,0.0f }, 0.000f, 0.00f, 0.00f, 0.000f, 0.0f, 0000.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0x31f }  
			FSOUND_PRESET_PS2_HALL {5, 0, 0, 0, 0, 0, 0.0f, 0.0f, 0.0f, 0, 0.000f, { 0.0f,0.0f,0.0f }, 0, 0.000f, { 0.0f,0.0f,0.0f }, 0.000f, 0.00f, 0.00f, 0.000f, 0.0f, 0000.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0x31f }  
			FSOUND_PRESET_PS2_SPACE {6, 0, 0, 0, 0, 0, 0.0f, 0.0f, 0.0f, 0, 0.000f, { 0.0f,0.0f,0.0f }, 0, 0.000f, { 0.0f,0.0f,0.0f }, 0.000f, 0.00f, 0.00f, 0.000f, 0.0f, 0000.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0x31f }  
			FSOUND_PRESET_PS2_ECHO {7, 0, 0, 0, 0, 0, 0.0f, 0.0f, 0.0f, 0, 0.000f, { 0.0f,0.0f,0.0f }, 0, 0.000f, { 0.0f,0.0f,0.0f }, 0.000f, 0.00f, 0.00f, 0.000f, 0.0f, 0000.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0x31f }  
			FSOUND_PRESET_PS2_DELAY {8, 0, 0, 0, 0, 0, 0.0f, 0.0f, 0.0f, 0, 0.000f, { 0.0f,0.0f,0.0f }, 0, 0.000f, { 0.0f,0.0f,0.0f }, 0.000f, 0.00f, 0.00f, 0.000f, 0.0f, 0000.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0x31f }  
			FSOUND_PRESET_PS2_PIPE {9, 0, 0, 0, 0, 0, 0.0f, 0.0f, 0.0f, 0, 0.000f, { 0.0f,0.0f,0.0f }, 0, 0.000f, { 0.0f,0.0f,0.0f }, 0.000f, 0.00f, 0.00f, 0.000f, 0.0f, 0000.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0x31f }  
		}
		*/

	/// <summary>
	/// Driver description bitfields. Use FSOUND_Driver_GetCaps to determine if a driver enumerated
	/// has the settings you are after. The enumerated driver depends on the output mode, see
	/// FSOUND_OUTPUTTYPES
	/// </summary>
	public enum FSOUND_CAPS
	{
		/// <summary>
		/// This driver supports hardware accelerated 3d sound.
		/// </summary>
		FSOUND_CAPS_HARDWARE = 0x1,
		/// <summary>
		/// This driver supports hardware accelerated 3d sound.
		/// </summary>
		FSOUND_CAPS_EAX2 = 0x2,
		/// <summary>
		/// This driver supports EAX 3 reverb
		/// </summary>
		FSOUND_CAPS_EAX3 = 0x10
	}

	/// <summary>
	/// These default priorities are used by FMOD internal system DSP units. 
	/// They describe the position of the DSP chain, and the order of how audio 
	/// processing is executed. You can actually through the use of FSOUND_DSP_GetxxxUnit 
	/// (where xxx is the name of the DSP unit), 
	/// disable or even change the priority of a DSP unit.
	/// </summary>
	public enum FSOUND_DSP_PRIORITIES
	{
		/// <summary>
		/// DSP CLEAR unit - done first
		/// </summary>
		FSOUND_DSP_DEFAULTPRIORITY_CLEARUNIT = 0, 
		/// <summary>
		/// DSP SFX unit - done second 
		/// </summary>
		FSOUND_DSP_DEFAULTPRIORITY_SFXUNIT = 100, 
		/// <summary>
		/// DSP MUSIC unit - done third 
		/// </summary>
		FSOUND_DSP_DEFAULTPRIORITY_MUSICUNIT = 200, 
		/// <summary>
		/// User priority, use this as reference for your own DSP units
		/// </summary>
		FSOUND_DSP_DEFAULTPRIORITY_USER = 300, 
		/// <summary>
		/// This reads data for FSOUND_DSP_GetSpectrum, so it comes after user units
		/// </summary>
		FSOUND_DSP_DEFAULTPRIORITY_FFTUNIT = 900, 
		/// <summary>
		/// DSP CLIP AND COPY unit - last
		/// </summary>
		FSOUND_DSP_DEFAULTPRIORITY_CLIPANDCOPYUNIT = 1000 

	}

	/// <summary>
	/// These values are used with FSOUND_FX_Enable to enable DirectX 8 FX for a channel.
	/// </summary>
	public enum FSOUND_FX_MODES
	{
		FSOUND_FX_CHORUS,
		FSOUND_FX_COMPRESSOR,  
		FSOUND_FX_DISTORTION, 
		FSOUND_FX_ECHO,  
		FSOUND_FX_FLANGER,  
		FSOUND_FX_GARGLE,  
		FSOUND_FX_I3DL2REVERB,  
		FSOUND_FX_PARAMEQ,  
		FSOUND_FX_WAVES_REVERB,  
		FSOUND_FX_MAX
	}

	/// <summary>
	/// These values describe the protocol and format of an internet stream. Use FSOUND_Stream_Net_GetStatus to retrieve this information for an open internet stream.
	/// </summary>
	public enum FSOUND_STATUS_FLAGS
	{
		FSOUND_PROTOCOL_SHOUTCAST = 0x00000001,
		FSOUND_PROTOCOL_ICECAST = 0x00000002,  
		FSOUND_PROTOCOL_HTTP = 0x00000004,  
		FSOUND_FORMAT_MPEG = 0x00010000,  
		FSOUND_FORMAT_OGGVORBIS = 0x00020000  
	}

	/// <summary>
	/// Status values for internet streams. Use FSOUND_Stream_Net_GetStatus to get the current status of an internet stream.
	/// </summary>
	public enum FSOUND_STREAM_NET_STATUS
	{
		/// <summary>
		///Stream hasn't connected yet 
		/// </summary>
		FSOUND_STREAM_NET_NOTCONNECTED,
		/// <summary>
		/// Stream is connecting to remote host
		/// </summary>
		FSOUND_STREAM_NET_CONNECTING,		
		/// <summary>
		/// Stream is buffering data
		/// </summary>
		FSOUND_STREAM_NET_BUFFERING,		
		/// <summary>
		/// Stream is ready to play
		/// </summary>
		FSOUND_STREAM_NET_READY,			
		/// <summary>
		/// Stream has suffered a fatal error 
		/// </summary>
		FSOUND_STREAM_NET_ERROR				
	}
		
	/// <summary>
	/// Describes the type of a particular tag field.
	/// </summary>
	public enum FSOUND_TAGFIELD_TYPE
	{
		/// <summary>
		/// A vorbis comment
		/// </summary>
		FSOUND_TAGFIELD_VORBISCOMMENT,		
		/// <summary>
		/// Part of an ID3v1 tag
		/// </summary>
		FSOUND_TAGFIELD_ID3V1,				
		/// <summary>
		/// An ID3v2 frame
		/// </summary>
		FSOUND_TAGFIELD_ID3V2,				
		/// <summary>
		/// A SHOUTcast header line
		/// </summary>
		FSOUND_TAGFIELD_SHOUTCAST,			
		/// <summary>
		/// An Icecast header line
		/// </summary>
		FSOUND_TAGFIELD_ICECAST,			
		/// <summary>
		/// An Advanced Streaming Format header line
		/// </summary>
		FSOUND_TAGFIELD_ASF					
	}

	/// <summary>
	/// These output types are used with FSOUND_SetOutput, to choose which output driver to use.
	/// FSOUND_OUTPUT_DSOUND will not support hardware 3d acceleration if the sound card driver 
	/// does not support DirectX 6 Voice Manager Extensions. 
	/// FSOUND_OUTPUT_WINMM is recommended for NT and CE.
	/// </summary>
	public enum FSOUND_OUTPUTTYPES
	{
		/// <summary>
		/// NoSound driver, all calls to this succeed but do nothing.
		/// </summary>
		FSOUND_OUTPUT_NOSOUND,		
		/// <summary>
		/// Windows Multimedia driver.
		/// </summary>
		FSOUND_OUTPUT_WINMM,			
		/// <summary>
		/// DirectSound driver. You need this to get EAX2 or EAX3 support, or FX api support.
		/// </summary>
		FSOUND_OUTPUT_DSOUND,		
		/// <summary>
		/// A3D driver. 
		/// </summary>
		FSOUND_OUTPUT_A3D,			
		/// <summary>
		/// Linux/Unix OSS (Open Sound System) driver, i.e. the kernel sound drivers. 
		/// </summary>
		FSOUND_OUTPUT_OSS,			
		/// <summary>
		/// Linux/Unix ESD (Enlightment Sound Daemon) driver. 
		/// </summary>
		FSOUND_OUTPUT_ESD,			
		/// <summary>
		/// Linux Alsa driver. 
		/// </summary>
		FSOUND_OUTPUT_ALSA,			
		/// <summary>
		/// Low latency ASIO driver 
		/// </summary>
		FSOUND_OUTPUT_ASIO,			
		/// <summary>
		/// Xbox driver 
		/// </summary>
		FSOUND_OUTPUT_XBOX,			
		/// <summary>
		/// PlayStation 2 driver 
		/// </summary>
		FSOUND_OUTPUT_PS2,			
		/// <summary>
		/// Mac SoundManager driver 
		/// </summary>
		FSOUND_OUTPUT_MAC,			
		/// <summary>
		/// Gamecube driver 
		/// </summary>
		FSOUND_OUTPUT_GC,			
		/// <summary>
		/// This is the same as nosound, but the sound generation is driven by FSOUND_Update 
		/// </summary>
		FSOUND_OUTPUT_NOSOUND_NONREALTIME	

	}

	/// <summary>
	/// On failure of commands in FMOD, use FSOUND_GetError to attain what happened.
	/// </summary>
	public enum FMOD_ERRORS
	{
		/// <summary>
		/// No errors 
		/// </summary>
		FMOD_ERR_NONE,				
		/// <summary>
		/// Cannot call this command after FSOUND_Init. Call FSOUND_Close first. 
		/// </summary>
		FMOD_ERR_BUSY,				
		/// <summary>
		/// This command failed because FSOUND_Init or FSOUND_SetOutput was not called 
		/// </summary>
		FMOD_ERR_UNINITIALIZED,		
		/// <summary>
		/// Error initializing output device. 
		/// </summary>
		FMOD_ERR_INIT,				
		/// <summary>
		/// Error initializing output device, but more specifically, the output device is already in use and cannot be reused. 
		/// </summary>
		FMOD_ERR_ALLOCATED,			
		/// <summary>
		/// Playing the sound failed. 
		/// </summary>
		FMOD_ERR_PLAY,				
		/// <summary>
		/// Soundcard does not support the features needed for this soundsystem (16bit stereo output) 
		/// </summary>
		FMOD_ERR_OUTPUT_FORMAT,		
		/// <summary>
		/// Error setting cooperative level for hardware. 
		/// </summary>
		FMOD_ERR_COOPERATIVELEVEL,  
		/// <summary>
		/// Error creating hardware sound buffer. 
		/// </summary>
		FMOD_ERR_CREATEBUFFER,		
		/// <summary>
		/// File not found 
		/// </summary>
		FMOD_ERR_FILE_NOTFOUND,		
		/// <summary>
		/// Unknown file format 
		/// </summary>
		FMOD_ERR_FILE_FORMAT,		
		/// <summary>
		/// Error loading file 
		/// </summary>
		FMOD_ERR_FILE_BAD,			
		/// <summary>
		/// Not enough memory or resources 
		/// </summary>
		FMOD_ERR_MEMORY,			
		/// <summary>
		/// The version number of this file format is not supported 
		/// </summary>
		FMOD_ERR_VERSION,			
		/// <summary>
		/// An invalid parameter was passed to this function 
		/// </summary>
		FMOD_ERR_INVALID_PARAM,		
		/// <summary>
		/// Tried to use an EAX command on a non EAX enabled channel or output. 
		/// </summary>
		FMOD_ERR_NO_EAX,			
		/// <summary>
		/// Failed to allocate a new channel 
		/// </summary>
		FMOD_ERR_CHANNEL_ALLOC,		
		/// <summary>
		/// Recording is not supported on this machine 
		/// </summary>
		FMOD_ERR_RECORD,			
		/// <summary>
		/// Windows Media Player not installed so cannot play wma or use internet streaming. 
		/// </summary>
		FMOD_ERR_MEDIAPLAYER,		
		/// <summary>
		/// An error occured trying to open the specified CD device 
		/// </summary>
		FMOD_ERR_CDDEVICE			
	}

	/// <summary>
	/// Playback method for a CD Audio track, with FSOUND_CD_SetPlayMode
	/// </summary>
	public enum FSOUND_CDPLAYMODES
	{
		/// <summary>
		/// Starts from the current track and plays to end of CD. 
		/// </summary>
		FSOUND_CD_PLAYCONTINUOUS = 0,  
		/// <summary>
		/// Plays the specified track then stops. 
		/// </summary>
		FSOUND_CD_PLAYONCE = 1, 
		/// <summary>
		/// Plays the specified track looped, forever until stopped manually. 
		/// </summary>
		FSOUND_CD_PLAYLOOPED = 2,
		/// <summary>
		/// Plays tracks in random order 
		/// </summary>
		FSOUND_CD_PLAYRANDOM = 3 
	}

	/// <summary>
	/// Initialization flags. Use them with FSOUND_Init in the flags parameter to change various behaviour.
	/// FSOUND_INIT_ENABLESYSTEMCHANNELFX Is an init mode which enables the FSOUND mixer buffer to be affected by DirectX 8 effects.
	/// Note that due to limitations of DirectSound, FSOUND_Init may fail if this is enabled because the buffersize is too small.
	/// This can be fixed with FSOUND_SetBufferSize. Increase the BufferSize until it works.
	/// When it is enabled you can use the FSOUND_FX api, and use FSOUND_SYSTEMCHANNEL as the channel id when setting parameters.
	/// </summary>
	public enum FSOUND_INIT_FLAGS
	{
		/// <summary>
		/// Win32 only - Causes MIDI playback to force software decoding. 
		/// </summary>
		FSOUND_INIT_USEDEFAULTMIDISYNTH = 0x0001,	 
		/// <summary>
		/// Win32 only - For DirectSound output - sound is not muted when window is out of focus. 
		/// </summary>
		FSOUND_INIT_GLOBALFOCUS = 0x0002,			 
		/// <summary>
		/// Win32 only - For DirectSound output - Allows FSOUND_FX api to be used on global software mixer output! (use FSOUND_SYSTEMCHANNEL as channel id) 
		/// </summary>
		FSOUND_INIT_ENABLESYSTEMCHANNELFX = 0x0004,	 
		/// <summary>
		/// This latency adjusts FSOUND_GetCurrentLevels, but incurs a small cpu and memory hit 
		/// </summary>
		FSOUND_INIT_ACCURATEVULEVELS = 0x0008,		 
		/// <summary>
		/// PS2 only - Disable reverb on CORE 0 to regain SRAM 
		/// </summary>
		FSOUND_INIT_PS2_DISABLECORE0REVERB = 0x0010, 
		/// <summary>
		/// PS2 only - Disable reverb on CORE 1 to regain SRAM 
		/// </summary>
		FSOUND_INIT_PS2_DISABLECORE1REVERB = 0x0020, 
		/// <summary>
		/// PS2 only - By default FMOD uses DMA CH0 for mixing, CH1 for uploads, this flag swaps them around 
		/// </summary>
		FSOUND_INIT_PS2_SWAPDMACORES = 0x0040,		 
		/// <summary>
		/// Callbacks are not latency adjusted, and are called at mix time. Also information functions are immediate 
		/// </summary>
		FSOUND_INIT_DONTLATENCYADJUST = 0x0080,		 
		/// <summary>
		/// GC only - Initializes GC audio libraries 
		/// </summary>
		FSOUND_INIT_GC_INITLIBS = 0x0100,			 
		/// <summary>
		/// Turns off fmod streamer thread, and makes streaming update from FSOUND_Update called by the user 
		/// </summary>
		FSOUND_INIT_STREAM_FROM_MAIN_THREAD = 0x0200,
		/// <summary>
		/// PS2 only - Turns on volume ramping system to remove hardware clicks. 
		/// </summary>
		FSOUND_INIT_PS2_USEVOLUMERAMPING = 0x0400,	 
		/// <summary>
		/// Win32 only - For DirectSound output. 3D commands are batched together and executed at FSOUND_Update. 
		/// </summary>
		FSOUND_INIT_DSOUND_DEFERRED = 0x0800,		 
		/// <summary>
		/// Win32 only - For DirectSound output. FSOUND_HW3D buffers use a slightly higher quality algorithm when 3d hardware acceleration is not present. 
		/// </summary>
		FSOUND_INIT_DSOUND_HRTF_LIGHT = 0x1000,		 
		/// <summary>
		/// Win32 only - For DirectSound output. FSOUND_HW3D buffers use full quality 3d playback when 3d hardware acceleration is not present. 
		/// </summary>
		FSOUND_INIT_DSOUND_HRTF_FULL = 0x2000		 
	}

	/// <summary>
	/// These are speaker types defined for use with the FSOUND_SetSpeakerMode command.
	/// Note - Only reliably works with FSOUND_OUTPUT_DSOUND or FSOUND_OUTPUT_XBOX output modes. 
	/// Other output modes will only interpret FSOUND_SPEAKERMODE_MONO and set everything else to be stereo.
	/// Using either DolbyDigital or DTS will use whatever 5.1 digital mode is available if destination hardware is unsure.
	/// </summary>
	public enum FSOUND_SPEAKERMODES :uint
	{
		/// <summary>
		/// Dolby Digital Output (XBOX or PC only). 
		/// </summary>
		FSOUND_SPEAKERMODE_DOLBYDIGITAL, 
		/// <summary>
		/// The speakers are headphones. 
		/// </summary>
		FSOUND_SPEAKERMODE_HEADPHONES, 
		/// <summary>
		/// The speakers are monaural. 
		/// </summary>
		FSOUND_SPEAKERMODE_MONO, 
		/// <summary>
		/// The speakers are quadraphonic. 
		/// </summary>
		FSOUND_SPEAKERMODE_QUAD, 
		/// <summary>
		/// The speakers are stereo (default value). 
		/// </summary>
		FSOUND_SPEAKERMODE_STEREO, 
		/// <summary>
		/// The speakers are surround sound. 
		/// </summary>
		FSOUND_SPEAKERMODE_SURROUND, 
		/// <summary>
		/// DTS output (XBOX only). 
		/// </summary>
		FSOUND_SPEAKERMODE_DTS, 
		/// <summary>
		/// Dolby Prologic 2. Playstation 2 and Gamecube only. PlayStation 2 doesnt support interior panning, but supports 48 voices simultaneously. 
		/// </summary>
		FSOUND_SPEAKERMODE_PROLOGIC2, 
		/// <summary>
		/// Dolby Prologic 2. Playstation 2 and Gamecube only. PlayStation 2 does support interior panning, but only supports 24 voices simultaneously. 
		/// </summary>
		FSOUND_SPEAKERMODE_PROLOGIC2_INTERIOR 
	}

	/// <summary>
	/// These mixer types are used with FSOUND_SetMixer, to choose which mixer to use, or to act 
	/// upon for other reasons using FSOUND_GetMixer. 
	/// It is not nescessary to set the mixer. FMOD will autodetect the best mixer for you.
	/// </summary>
	public enum FSOUND_MIXERTYPES
	{
		/// <summary>
		/// CE/PS2/GC Only - Non interpolating/low quality mixer. 
		/// </summary>
		FSOUND_MIXER_AUTODETECT,			
		/// <summary>
		/// Removed / obsolete. 
		/// </summary>
		FSOUND_MIXER_BLENDMODE	,			
		/// <summary>
		/// Removed / obsolete. 
		/// </summary>
		FSOUND_MIXER_MMXP5	,				
		/// <summary>
		/// Removed / obsolete. 
		/// </summary>
		FSOUND_MIXER_MMXP6	,				
		/// <summary>
		/// FSOUND_MIXER_QUALITY_FPU /* Win32/Linux only - Interpolating/volume ramping FPU mixer. 
		/// </summary>
		FSOUND_MIXER_QUALITY_AUTODETECT,	
		/// <summary>
		/// Win32/Linux only - Interpolating/volume ramping P5 MMX mixer. 
		/// </summary>
		FSOUND_MIXER_QUALITY_MMXP5,			
		/// <summary>
		/// Win32/Linux only - Interpolating/volume ramping ppro+ MMX mixer. 
		/// </summary>
		FSOUND_MIXER_QUALITY_MMXP6,			
		/// <summary>
		/// CE/PS2/GC only - MONO non interpolating/low quality mixer. For speed
		/// </summary>
		FSOUND_MIXER_MONO	,				
		/// <summary>
		/// CE/PS2/GC only - MONO Interpolating mixer. For speed 
		/// </summary>
		FSOUND_MIXER_QUALITY_MONO,			
		FSOUND_MIXER_MAX 

	}

	/// <summary>
	/// Sample description bitfields, OR them together for loading and describing samples.
	/// NOTE. If the file format being loaded already has a defined format, such as WAV or MP3, then 
	/// trying to override the pre-defined format with a new set of format flags will not work. For 
	/// example, an 8 bit WAV file will not load as 16bit if you specify FSOUND_16BITS. It will just
	/// ignore the flag and go ahead loading it as 8bits. For these type of formats the only flags
	/// you can specify that will really alter the behaviour of how it is loaded, are the following.
	/// </summary>
	public enum  FSOUND_MODES :uint
	{
		/// <summary>
		/// For non looping samples. 
		/// </summary>
		FSOUND_LOOP_OFF = 0x00000001,			
		/// <summary>
		/// For forward looping samples. 
		/// </summary>
		FSOUND_LOOP_NORMAL = 0x00000002,		
		/// <summary>
		/// For bidirectional looping samples. (no effect if in hardware). 
		/// </summary>
		FSOUND_LOOP_BIDI = 0x00000004,			
		/// <summary>
		/// For 8 bit samples. 
		/// </summary>
		FSOUND_8BITS = 0x00000008,				
		/// <summary>
		/// For 16 bit samples. 
		/// </summary>
		FSOUND_16BITS = 0x00000010,				
		/// <summary>
		/// For mono samples. 
		/// </summary>
		FSOUND_MONO = 0x00000020,				
		/// <summary>
		/// For stereo samples. 
		/// </summary>
		FSOUND_STEREO = 0x00000040,				
		/// <summary>
		/// For user created source data containing unsigned samples. 
		/// </summary>
		FSOUND_UNSIGNED = 0x00000080,			
		/// <summary>
		/// For user created source data containing signed data. 
		/// </summary>
		FSOUND_SIGNED = 0x00000100,				
		/// <summary>
		/// For user created source data stored as delta values. 
		/// </summary>
		FSOUND_DELTA = 0x00000200,				
		/// <summary>
		/// For user created source data stored using IT214 compression. 
		/// </summary>
		FSOUND_IT214 = 0x00000400,				
		/// <summary>
		/// For user created source data stored using IT215 compression. 
		/// </summary>
		FSOUND_IT215 = 0x00000800,				
		/// <summary>
		/// Attempts to make samples use 3d hardware acceleration. (if the card supports it) 
		/// </summary>
		FSOUND_HW3D = 0x00001000,				
		/// <summary>
		/// Tells software (not hardware) based sample not to be included in 3d processing. 
		/// </summary>
		FSOUND_2D = 0x00002000,					
		/// <summary>
		/// For a streamimg sound where you feed the data to it. 
		/// </summary>
		FSOUND_STREAMABLE = 0x00004000,			
		/// <summary>
		/// "name" will be interpreted as a pointer to data for streaming and samples. 
		/// </summary>
		FSOUND_LOADMEMORY = 0x00008000,			
		/// <summary>
		/// Will ignore file format and treat as raw pcm. 
		/// </summary>
		FSOUND_LOADRAW = 0x00010000,			
		/// <summary>
		/// For FSOUND_Stream_Open - for accurate FSOUND_Stream_GetLengthMs/FSOUND_Stream_SetTime. WARNING, see FSOUND_Stream_Open for inital opening time performance issues. 
		/// </summary>
		FSOUND_MPEGACCURATE = 0x00020000,		
		/// <summary>
		/// For forcing stereo streams and samples to be mono - needed if using FSOUND_HW3D and stereo data - incurs a small speed hit for streams 
		/// </summary>
		FSOUND_FORCEMONO = 0x00040000,			
		/// <summary>
		/// 2D hardware sounds. allows hardware specific effects 
		/// </summary>
		FSOUND_HW2D = 0x00080000,				
		/// <summary>
		/// Allows DX8 FX to be played back on a sound. Requires DirectX 8 - Note these sounds cannot be played more than once, be 8 bit, be less than a certain size, or have a changing frequency 
		/// </summary>
		FSOUND_ENABLEFX = 0x00100000,			
		/// <summary>
		/// For FMODCE only - decodes mpeg streams using a lower quality decode, but faster execution 
		/// </summary>
		FSOUND_MPEGHALFRATE = 0x00200000,		
		/// <summary>
		/// Contents are stored compressed as IMA ADPCM 
		/// </summary>
		FSOUND_IMAADPCM = 0x00400000,			
		/// <summary>
		/// For PS2 only - Contents are compressed as Sony VAG format 
		/// </summary>
		FSOUND_VAG = 0x00800000,				
		/// <summary>
		/// For FSOUND_Stream_Open/FMUSIC_LoadSong - Causes stream or music to open in the background and not block the foreground app. See FSOUND_Stream_GetOpenState or FMUSIC_GetOpenState to determine when it IS ready. 
		/// </summary>
		FSOUND_NONBLOCKING = 0x01000000,		
		/// <summary>
		/// For Gamecube only - Contents are compressed as Gamecube DSP-ADPCM format 
		/// </summary>
		FSOUND_GCADPCM = 0x02000000,			
		/// <summary>
		/// For PS2 and Gamecube only - Contents are interleaved into a multi-channel (more than stereo) format 
		/// </summary>
		FSOUND_MULTICHANNEL = 0x04000000,		
		/// <summary>
		/// For PS2 only - Sample/Stream is forced to use hardware voices 00-23 
		/// </summary>
		FSOUND_USECORE0 = 0x08000000,			
		/// <summary>
		/// For PS2 only - Sample/Stream is forced to use hardware voices 24-47 
		/// </summary>
		FSOUND_USECORE1 = 0x10000000,			
		/// <summary>
		/// For PS2 only - "name" will be interpreted as a pointer to data for streaming and samples. The address provided will be an IOP address 
		/// </summary>
		FSOUND_LOADMEMORYIOP = 0x20000000,		
		/// <summary>
		/// Skips id3v2 etc tag checks when opening a stream, to reduce seek/read overhead when opening files (helps with CD performance) 
		/// </summary>
		FSOUND_IGNORETAGS = 0x40000000,			
		/// <summary>
		/// Specifies an internet stream 
		/// </summary>
		FSOUND_STREAM_NET = 0x80000000,			
		/// <summary>
		/// Normal Mode
		/// </summary>
		FSOUND_NORMAL = (FmodManaged.FSOUND.Enums.FSOUND_MODES.FSOUND_16BITS | FmodManaged.FSOUND.Enums.FSOUND_MODES.FSOUND_SIGNED | FmodManaged.FSOUND.Enums.FSOUND_MODES.FSOUND_MONO)
	}
}
