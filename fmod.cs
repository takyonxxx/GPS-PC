using System;
using System.Runtime.InteropServices;

namespace Fmod
{
    /// <summary>
    /// Summary description for fmod.
    /// </summary>
    public class F_MOD
    {
        public enum SOUND_FORMAT
        {
            NONE,     /* Unitialized / unknown */
            PCM8,     /* 8bit integer PCM data */
            PCM16,    /* 16bit integer PCM data  */
            PCM24,    /* 24bit integer PCM data  */
            PCM32,    /* 32bit integer PCM data  */
            PCMFLOAT, /* 32bit floating point PCM data  */
            GCADPCM,  /* Compressed GameCube DSP data */
            IMAADPCM, /* Compressed XBox ADPCM data */
            VAG,      /* Compressed PlayStation 2 ADPCM data */
            XMA,      /* Compressed Xbox360 data. */
            MPEG,     /* Compressed MPEG layer 2 or 3 data. */
            MAX       /* Maximum number of sound formats supported. */
        }
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
        public enum FSOUND_SPEAKERMODES : uint
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
            FSOUND_MIXER_BLENDMODE,
            /// <summary>
            /// Removed / obsolete. 
            /// </summary>
            FSOUND_MIXER_MMXP5,
            /// <summary>
            /// Removed / obsolete. 
            /// </summary>
            FSOUND_MIXER_MMXP6,
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
            FSOUND_MIXER_MONO,
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
        public enum FSOUND_MODES : uint
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
            FSOUND_NORMAL = (FSOUND_MODES.FSOUND_16BITS | FSOUND_MODES.FSOUND_SIGNED | FSOUND_MODES.FSOUND_MONO)
        }



        public struct FSOUND_TOC_TAG
        {
            /// <summary>
            /// The string "TOC", just in case this structure is accidentally treated as a string
            /// </summary>
            public char[] name;

            /// <summary>
            /// The number of tracks on the CD
            /// </summary>
            public int numtracks;

            /// <summary>
            /// The start offset of each track in minutes
            /// </summary>
            public int[] min;

            /// <summary>
            /// The start offset of each track in seconds
            /// </summary>
            public int[] sec;

            /// <summary>
            /// The start offset of each track in frames
            /// </summary>
            public int[] frame;
        }



        /// <summary>
        /// Structure defining the properties for a reverb source, related to a FSOUND channel.
        /// For more indepth descriptions of the reverb properties under win32, please see the EAX3
        /// documentation at http://developer.creative.com/ under the 'downloads' section.
        /// If they do not have the EAX3 documentation, then most information can be attained from
        /// the EAX2 documentation, as EAX3 only adds some more parameters and functionality on top of 
        /// EAX2. Note the default reverb properties are the same as the FSOUND_PRESET_GENERIC preset.
        /// Note that integer values that typically range from -10,000 to 1000 are represented in 
        /// decibels, and are of a logarithmic scale, not linear, wheras float values are typically linear.
        /// PORTABILITY: Each member has the platform it supports in braces ie (win32/xbox). 
        /// Some reverb parameters are only supported in win32 and some only on xbox. If all parameters are set then
        /// the reverb should product a similar effect on either platform.
        /// Linux and FMODCE do not support the reverb api.
        /// The numerical values listed below are the maximum, minimum and default values for each variable respectively.
        /// </summary>
        public struct FSOUND_REVERB_CHANNELPROPERTIES
        {
            /// <summary>
            /// 0 , 25 , 0 , sets all listener properties (WIN32/PS2 only) 
            /// </summary>
            public uint Environment;

            /// <summary>
            /// 1.0 , 100.0 , 7.5 , environment size in meters (WIN32 only) 
            /// </summary>
            public float EnvSize;

            /// <summary>
            /// 0.0 , 1.0 , 1.0 , environment diffusion (WIN32/XBOX) 
            /// </summary>
            public float EnvDiffusion;

            /// <summary>
            /// -10000, 0 , -1000 , room effect level (at mid frequencies) (WIN32/XBOX/PS2) 
            /// </summary>
            public int Room;

            /// <summary>
            /// -10000, 0 , -100 , relative room effect level at high frequencies (WIN32/XBOX) 
            /// </summary>
            public int RoomHF;

            /// <summary>
            /// -10000, 0 , 0 , relative room effect level at low frequencies (WIN32 only) 
            /// </summary>
            public int RoomLF;

            /// <summary>
            /// 0.1 , 20.0 , 1.49 , reverberation decay time at mid frequencies (WIN32/XBOX) 
            /// </summary>
            public float DecayTime;

            /// <summary>
            /// 0.1 , 2.0 , 0.83 , high-frequency to mid-frequency decay time ratio (WIN32/XBOX) 
            /// </summary>
            public float DecayHFRatio;

            /// <summary>
            /// 0.1 , 2.0 , 1.0 , low-frequency to mid-frequency decay time ratio (WIN32 only) 
            /// </summary>
            public float DecayLFRatio;

            /// <summary>
            /// -10000, 1000 , -2602 , early reflections level relative to room effect (WIN32/XBOX) 
            /// </summary>
            public int Reflections;

            /// <summary>
            /// 0.0 , 0.3 , 0.007 , initial reflection delay time (WIN32/XBOX) 
            /// </summary>
            public float ReflectionsDelay;

            /// <summary>
            /// , , [0,0,0], early reflections panning vector (WIN32 only) 
            /// </summary>
            public float ReflectionsPan_3;

            /// <summary>
            /// -10000, 2000 , 200 , late reverberation level relative to room effect (WIN32/XBOX) 
            /// </summary>
            public int Reverb;

            /// <summary>
            /// 0.0 , 0.1 , 0.011 , late reverberation delay time relative to initial reflection (WIN32/XBOX) 
            /// </summary>
            public float ReverbDelay;

            /// <summary>
            /// , , [0,0,0], late reverberation panning vector (WIN32 only) 
            /// </summary>
            public float ReverbPan_3;

            /// <summary>
            /// .075 , 0.25 , 0.25 , echo time (WIN32/PS2 only. PS2 = Delay time for ECHO/DELAY modes only) 
            /// </summary>
            public float EchoTime;

            /// <summary>
            /// 0.0 , 1.0 , 0.0 , echo depth (WIN32/PS2 only. PS2 = Feedback level for ECHO mode only) 
            /// </summary>
            public float EchoDepth;

            /// <summary>
            /// 0.04 , 4.0 , 0.25 , modulation time (WIN32 only) 
            /// </summary>
            public float ModulationTime;

            /// <summary>
            /// 0.0 , 1.0 , 0.0 , modulation depth (WIN32 only) 
            /// </summary>
            public float ModulationDepth;

            /// <summary>
            /// -100 , 0.0 , -5.0 , change in level per meter at high frequencies (WIN32 only) 
            /// </summary>
            public float AirAbsorptionHF;

            /// <summary>
            /// 1000.0, 20000 , 5000.0 , reference high frequency (hz) (WIN32/XBOX) 
            /// </summary>
            public float HFReference;

            /// <summary>
            /// 20.0 , 1000.0, 250.0 , reference low frequency (hz) (WIN32 only) 
            /// </summary>
            public float LFReference;

            /// <summary>
            /// 0.0 , 10.0 , 0.0 , like FSOUND_3D_SetRolloffFactor but for room effect (WIN32/XBOX) 
            /// </summary>
            public float RoomRolloffFactor;

            /// <summary>
            /// 0.0 , 100.0 , 100.0 , Value that controls the echo density in the late reverberation decay. (XBOX only) 
            /// </summary>
            public float Diffusion;

            /// <summary>
            /// 0.0 , 100.0 , 100.0 , Value that controls the modal density in the late reverberation decay (XBOX only) 
            /// </summary>
            public float Density;

            /// <summary>
            /// FSOUND_REVERB_FLAGS - modifies the behavior of above properties (WIN32/PS2 only) 
            /// </summary>
            public uint Flags;
        }



        /// <summary>
        /// Structure defining a reverb environment.
        /// For more indepth descriptions of the reverb properties under win32, 
        /// please see the EAX2 and EAX3 documentation at http://developer.creative.com/ 
        /// under the 'downloads' section. If they do not have the EAX3 documentation, 
        /// then most information can be attained from the EAX2 documentation, as EAX3 only 
        /// adds some more parameters and functionality on top of EAX2. Note the default 
        /// reverb properties are the same as the FSOUND_PRESET_GENERIC preset. Note that integer 
        /// values that typically range from -10,000 to 1000 are represented in decibels, and 
        /// are of a logarithmic scale, not linear, wheras float values are typically linear. 
        /// PORTABILITY: Each member has the platform it supports in braces ie (win32/xbox). 
        /// Some reverb parameters are only supported in win32 and some only on xbox. 
        /// If all parameters are set then the reverb should product a similar effect on either platform.
        /// The numerical values listed below are the maximum, minimum and default values for 
        /// each variable respectively.
        /// </summary>
        public struct FSOUND_REVERB_PROPERTIES
        {
            /// <summary>
            /// -10000, 1000, 0, direct path level (at low and mid frequencies) (WIN32/XBOX) 
            /// </summary>
            public int Direct;

            /// <summary>
            /// -10000, 0, 0, relative direct path level at high frequencies (WIN32/XBOX) 
            /// </summary>
            public int DirectHF;

            /// <summary>
            /// -10000, 1000, 0, room effect level (at low and mid frequencies) (WIN32/XBOX/PS2) 
            /// </summary>
            public int Room;

            /// <summary>
            /// -10000, 0, 0, relative room effect level at high frequencies (WIN32/XBOX) 
            /// </summary>
            public int RoomHF;

            /// <summary>
            /// -10000, 0, 0, main obstruction control (attenuation at high frequencies) (WIN32/XBOX) 
            /// </summary>
            public int Obstruction;

            /// <summary>
            /// 0.0, 1.0, 0.0, obstruction low-frequency level re. main control (WIN32/XBOX) 
            /// </summary>
            public float ObstructionLFRatio;

            /// <summary>
            /// -10000, 0, 0, main occlusion control (attenuation at high frequencies) (WIN32/XBOX) 
            /// </summary>
            public int Occlusion;

            /// <summary>
            /// 0.0, 1.0, 0.25, occlusion low-frequency level re. main control (WIN32/XBOX) 
            /// </summary>
            public float OcclusionLFRatio;

            /// <summary>
            /// 0.0, 10.0, 1.5, relative occlusion control for room effect (WIN32) 
            /// </summary>
            public float OcclusionRoomRatio;

            /// <summary>
            /// 0.0, 10.0, 1.0, relative occlusion control for direct path (WIN32) 
            /// </summary>
            public float OcclusionDirectRatio;

            /// <summary>
            /// -10000, 0, 0, main exlusion control (attenuation at high frequencies) (WIN32) 
            /// </summary>
            public int Exclusion;

            /// <summary>
            /// 0.0, 1.0, 1.0, exclusion low-frequency level re. main control (WIN32) 
            /// </summary>
            public float ExclusionLFRatio;

            /// <summary>
            /// -10000, 0, 0, outside sound cone level at high frequencies (WIN32) 
            /// </summary>
            public int OutsideVolumeHF;

            /// <summary>
            /// 0.0, 10.0, 0.0, like DS3D flDopplerFactor but per source (WIN32) 
            /// </summary>
            public float DopplerFactor;

            /// <summary>
            /// 0.0, 10.0, 0.0, like DS3D flRolloffFactor but per source (WIN32) 
            /// </summary>
            public float RolloffFactor;

            /// <summary>
            /// 0.0, 10.0, 0.0, like DS3D flRolloffFactor but for room effect (WIN32/XBOX) 
            /// </summary>
            public float RoomRolloffFactor;

            /// <summary>
            /// 0.0, 10.0, 1.0, multiplies AirAbsorptionHF member of FSOUND_REVERB_PROPERTIES (WIN32) 
            /// </summary>
            public float AirAbsorptionFactor;

            /// <summary>
            /// FSOUND_REVERB_CHANNELFLAGS - modifies the behavior of properties (WIN32) 
            /// </summary>
            public int Flags;
        }



        [DllImport("fmod.dll")]
        public static extern bool FSOUND_3D_Listener_GetAttributes(ref float F_FLOAT_API_pos, ref float F_FLOAT_API_vel, ref float F_FLOAT_API_fx, ref float F_FLOAT_API_fy, ref float F_FLOAT_API_fz, ref float F_FLOAT_API_tx, ref float F_FLOAT_API_ty, ref float F_FLOAT_API_tz);


        /// <summary>
        /// This updates the position, velocity and orientation of a 3d sound listener.
        /// </summary>
        /// <param name="F_FLOAT_API_pos">Pointer to a position vector (xyz float triplet), of the listener in world space, measured in distance units. This can be NULL to ignore it.</param>
        /// <param name="F_FLOAT_API_vel">Pointer to a velocity vector (xyz float triplet), of the listener measured in distance units PER SECOND. This can be NULL to ignore it.</param>
        /// <param name="F_FLOAT_API_fx">x component of a FORWARD unit length orientation vector</param>
        /// <param name="F_FLOAT_API_fy">y component of a FORWARD unit length orientation vector</param>
        /// <param name="F_FLOAT_API_fz">z component of a FORWARD unit length orientation vector</param>
        /// <param name="F_FLOAT_API_tx">x component of a TOP or upwards facing unit length orientation vector</param>
        /// <param name="F_FLOAT_API_ty">y component of a TOP or upwards facing unit length orientation vector</param>
        /// <param name="F_FLOAT_API_tz">z component of a TOP or upwards facing unit length orientation vector</param>
        /// <returns>On success, TRUE is returned. On failure, FALSE is returned.</returns>
        [DllImport("fmod.dll")]
        public static extern bool FSOUND_3D_Listener_SetAttributes(float F_FLOAT_API_pos, float F_FLOAT_API_vel, float F_FLOAT_API_fx, float F_FLOAT_API_fy, float F_FLOAT_API_fz, float F_FLOAT_API_tx, float F_FLOAT_API_ty, float F_FLOAT_API_tz);


        /// <summary>
        /// Sets the current listener number and number of listeners, if the user wants to simulate multiple listeners at once. 
        /// </summary>
        /// <param name="current">Current listener number. Listener commands following this function call will affect this listener number. (default: 0)</param>
        /// <param name="numlisteners">Number of listeners active. (default: 1)</param>
        [DllImport("fmod.dll")]
        public static extern void FSOUND_3D_Listener_SetCurrent(int current, int numlisteners);


        /// <summary>
        /// Sets FMOD's 3d engine relative distance factor, compared to 1.0 meters. It equates to 'how many units per meter' does your engine have.
        /// </summary>
        /// <param name="F_FLOAT_API_factor">1.0 = 1 meter units. If you are using feet then scale would equal 3.28.</param>
        [DllImport("fmod.dll")]
        public static extern void FSOUND_3D_SetDistanceFactor(float F_FLOAT_API_factor);


        /// <summary>
        /// Sets the doppler shift scale factor.
        /// </summary>
        /// <param name="F_FLOAT_API_scale">Doppler shift scale. Default value for FSOUND is 1.0f</param>
        [DllImport("fmod.dll")]
        public static extern void FSOUND_3D_SetDopplerFactor(float F_FLOAT_API_scale);


        /// <summary>
        /// Sets the global attenuation rolloff factor. Normally volume for a sample will scale at 1 / distance. This gives a logarithmic attenuation of volume as the source gets further away (or closer).
        /// Setting this value makes the sound drop off faster or slower. The higher the value, the faster volume will fall off. 
        /// The lower the value, the slower it will fall off. For example a rolloff factor of 1 will simulate the real world, where as a value of 2 will make sounds attenuate 2 times quicker.
        /// </summary>
        /// <param name="F_FLOAT_API_factor">The rolloff factor to set for this sample. Valid ranges are 0 to 10.</param>
        [DllImport("fmod.dll")]
        public static extern void FSOUND_3D_SetRolloffFactor(float F_FLOAT_API_factor);


        [DllImport("fmod.dll")]
        public static extern IntPtr FSOUND_DSPCALLBACK(ref IntPtr originalbuffer, ref  IntPtr newbuffer, int length, ref  IntPtr userdata);


        /// <summary>
        /// Callback used with user streams.
        /// </summary>
        /// <param name="FSOUND_STREAM">Pointer to the stream in question.</param>
        /// <param name="buff">from FSOUND_Stream_Create - Pointer to the stream data buffer to write to
        ///		from FSOUND_Stream_SetEndCallback - NULL
        ///		from FSOUND_Stream_SetSyncCallback - Pointer to a string</param>
        /// <param name="len">from FSOUND_Stream_Create - Length of buffer specified in BYTES. 
        ///		from FSOUND_Stream_SetEndCallback - 0
        ///		from FSOUND_Stream_SetSyncCallback - 0</param>
        /// <param name="userdata">A user data value specified from FSOUND_Stream_Create.</param>
        /// <returns>If created by FSOUND_Stream_Create - To allow the stream to continue, TRUE is returned.
        /// To stop the stream, FALSE is returned. The return value is ignored if created by FSOUND_Stream_SetEndCallback or FSOUND_Stream_SetSyncCallback
        /// </returns>
        [DllImport("fmod.dll")]
        public static extern bool FSOUND_STREAMCALLBACK(IntPtr FSOUND_STREAM, ref IntPtr buff, int len, ref IntPtr userdata);


        /// <summary>
        /// Callback to allocate a block of memory.
        /// </summary>
        /// <param name="size">Size in bytes of the memory block to be allocated and returned.</param>
        /// <returns>On success, a pointer to the newly allocated block of memory is returned. On failure, NULL is returned.</returns>
        [DllImport("fmod.dll")]
        public static extern IntPtr FSOUND_ALLOCCALLBACK(uint size);


        /// <summary>
        /// Callback to re-allocate a block of memory to a different size.
        /// </summary>
        /// <param name="ptr">Pointer to a block of memory to be resized. If this is NULL then a new block of memory is simply allocated.</param>
        /// <param name="size">Size of the memory to be reallocated. The original memory must be preserved.</param>
        /// <returns>On success, a pointer to the newly re-allocated block of memory is returned. On failure, NULL is returned.</returns>
        [DllImport("fmod.dll")]
        public static extern IntPtr FSOUND_REALLOCCALLBACK(ref IntPtr ptr, uint size);


        /// <summary>
        /// Callback to free a block of memory.
        /// </summary>
        /// <param name="ptr">Pointer to a pre-existing block of memory to be freed.</param>
        [DllImport("fmod.dll")]
        public static extern void FSOUND_FREECALLBACK(ref IntPtr ptr);


        /// <summary>
        /// Callback for opening a file.
        /// </summary>
        /// <param name="name">This is the filename. You may treat this as you like.</param>
        /// <returns>On success, return a non 0 number. On failure, return 0.</returns>
        [DllImport("fmod.dll")]
        public static extern IntPtr FSOUND_OPENCALLBACK(string name);


        /// <summary>
        /// Calback for closing a file.
        /// </summary>
        /// <param name="handle">This is the handle you returned from the open callback to use for your own file routines.</param>
        [DllImport("fmod.dll")]
        public static extern void FSOUND_CLOSECALLBACK(ref IntPtr handle);


        /// <summary>
        /// Callback to receive a new piece of metadata from an internet stream
        /// </summary>
        /// <param name="name">Pointer to the name of the piece of metadata (null-terminated ASCII string)</param>
        /// <param name="svalue">Pointer to the metadata (null-terminated ASCII string)</param>
        /// <param name="FSOUND_Stream_Net_SetMetadataCallback">Userdata that was specified in FSOUND_Stream_Net_SetMetadataCallback</param>
        /// <returns>Currently ignored</returns>
        [DllImport("fmod.dll")]
        public static extern bool FSOUND_METADATACALLBACK(string name, string svalue, ref IntPtr FSOUND_Stream_Net_SetMetadataCallback);


        /// <summary>
        /// Callback for reading from a file.
        /// </summary>
        /// <param name="buffer">You must read and copy your file data into this pointer.</param>
        /// <param name="size">You must read this many bytes from your file data.</param>
        /// <param name="handle">This is the handle you returned from the open callback to use for your own file routines.</param>
        /// <returns>Return the number of bytes that were *successfully* read here. Normally this is just the same as 'length', but if you are at the end of the file, you will probably only read successfully the number of bytes up to the end of the file (if you tried to read more than that).</returns>
        [DllImport("fmod.dll")]
        public static extern int FSOUND_READCALLBACK(ref IntPtr buffer, int size, ref IntPtr handle);


        /// <summary>
        /// Callback for seeking within a file.
        /// </summary>
        /// <param name="handle">This is the handle you returned from the open callback to use for your own file routines.</param>
        /// <param name="pos">This is the position or offset to seek by depending on the mode.</param>
        /// <param name="mode">This is the seek command. It uses and is compatible with SEEK_SET, SEEK_CUR and SEEK_END from stdio.h, so use them.</param>
        /// <returns>If successful, the seek callback returns 0. Otherwise, it returns a nonzero value. On devices incapable of seeking, the return value is undefined.</returns>
        [DllImport("fmod.dll")]
        public static extern int FSOUND_SEEKCALLBACK(ref IntPtr handle, int pos, bool mode);


        /// <summary>
        /// Callback for returning the current file pointer position within the file.
        /// </summary>
        /// <param name="handle">This is the handle you returned from the open callback to use for your own file routines.</param>
        /// <returns>On success, the offset within the file in bytes is returned. On failure, -1 is returned.</returns>
        [DllImport("fmod.dll")]
        public static extern int FSOUND_TELLCALLBACK(ref IntPtr handle);


        [DllImport("fmod.dll")]
        public static extern bool FSOUND_CD_OpenTray(char drive, bool open);


        /// <summary>
        /// Returns the number of tracks on the currently inserted CD.
        /// </summary>
        /// <param name="drive">the drive ID to use. 0 is the default CD drive. Using D or E in single quotes would be D: or E: for example.</param>
        /// <returns>On success, the number of CD tracks on the currently inserted is returned. On failure, 0 is returned.</returns>
        [DllImport("fmod.dll")]
        public static extern int FSOUND_CD_GetNumTracks(char drive);


        /// <summary>
        /// Gets the pause status of the current CD audio track.
        /// </summary>
        /// <param name="drive">the drive ID to use. 0 is the default CD drive. Using D or E in single quotes would be D: or E: for example.</param>
        /// <returns>If the track is currently paused, TRUE is returned. If the track is currently not paused, FALSE is returned.</returns>
        [DllImport("fmod.dll")]
        public static extern bool FSOUND_CD_GetPaused(char drive);


        /// <summary>
        /// Returns the currently playing CD track number.
        /// </summary>
        /// <param name="drive">The drive ID to use. 0 is the default CD drive. Using D or E in single quotes would be D: or E: for example.</param>
        /// <returns>On success, the CD track number currently playing is returned. (starts from 1). On failure, 0 is returned.</returns>
        [DllImport("fmod.dll")]
        public static extern int FSOUND_CD_GetTrack(char drive);


        /// <summary>
        /// Gets the track length of a CD.
        /// </summary>
        /// <param name="drive">The drive ID to use. 0 is the default CD drive. Using D or E in single quotes would be D: or E: for example.</param>
        /// <param name="track">The CD track number to query the length of. (starts from 1)</param>
        /// <returns></returns>
        [DllImport("fmod.dll")]
        public static extern int FSOUND_CD_GetTrackLength(char drive, int track);


        /// <summary>
        /// Returns the current track time playing on a CD.
        /// </summary>
        /// <param name="drive">the drive ID to use. 0 is the default CD drive. Using D or E in single quotes would be D: or E: for example.</param>
        /// <returns>On success, the position of the current playing track in milliseconds is returned. On failure, 0 is returned.</returns>
        [DllImport("fmod.dll")]
        public static extern int FSOUND_CD_GetTrackTime(char drive);


        /// <summary>
        /// Plays a CD Audio track.
        /// </summary>
        /// <param name="drive">the drive ID to use. 0 is the default CD drive. Using D or E in single quotes would be D: or E: for example.</param>
        /// <param name="track">the CD track number to play. The first track starts at 1.</param>
        /// <returns>On success, TRUE is returned. On failure, FALSE is returned.</returns>
        [DllImport("fmod.dll")]
        public static extern bool FSOUND_CD_Play(char drive, int track);


        /// <summary>
        /// Sets the pause status of the currently playing CD audio track.
        /// </summary>
        /// <param name="drive">the drive ID to use. 0 is the default CD drive. Using D or E in single quotes would be D: or E: for example.</param>
        /// <param name="paused">TRUE to pause track, FALSE to unpause track.</param>
        /// <returns>On success, TRUE is returned. On failure, FALSE is returned.</returns>
        [DllImport("fmod.dll")]
        public static extern bool FSOUND_CD_SetPaused(char drive, bool paused);


        /// <summary>
        /// Sets the playback mode of the CD.
        /// </summary>
        /// <param name="drive">the drive ID to use. 0 is the default CD drive. Using D or E in single quotes would be D: or E: for example.</param>
        /// <param name="mode">See FSOUND_CDPLAYMODES for a list of valid parameters to send to this function.</param>
        [DllImport("fmod.dll")]
        public static extern void FSOUND_CD_SetPlayMode(char drive, FSOUND_CDPLAYMODES mode);


        /// <summary>
        /// Performs a seek within a track specified by milliseconds.
        /// </summary>
        /// <param name="drive">The drive ID to use. 0 is the default CD drive. Using D or E in single quotes would be D: or E: for example.</param>
        /// <param name="ms">Time to seek into the current track in milliseconds.</param>
        /// <returns>On success, TRUE is returned. On failure, FALSE is returned.</returns>
        [DllImport("fmod.dll")]
        public static extern bool FSOUND_CD_SetTrackTime(char drive, int ms);


        /// <summary>
        /// Sets the volume of the playing CD audio.
        /// </summary>
        /// <param name="drive">the drive ID to use. 0 is the default CD drive. Using D or E in single quotes would be D: or E: for example. </param>
        /// <param name="volume">An integer value from 0-255. 0 being the lowest volume, 255 being the highest (full).</param>
        /// <returns>On success, TRUE is returned. On failure, FALSE is returned.</returns>
        [DllImport("fmod.dll")]
        public static extern bool FSOUND_CD_SetVolume(char drive, int volume);


        /// <summary>
        /// Stops the currently playing CD audio track.
        /// </summary>
        /// <param name="drive">the drive ID to use. 0 is the default CD drive. Using D or E in single quotes would be D: or E: for example.</param>
        /// <returns>On success, TRUE is returned. On failure, FALSE is returned.</returns>
        [DllImport("fmod.dll")]
        public static extern bool FSOUND_CD_Stop(char drive);


        [DllImport("fmod.dll")]
        public static extern int FSOUND_PlaySound(int channel, IntPtr FSOUND_SAMPLE);


        [DllImport("fmod.dll")]
        public static extern int FSOUND_PlaySoundEx(int channel, IntPtr FSOUND_SAMPLE, IntPtr FSOUND_DSPUNIT, bool startpaused);


        [DllImport("fmod.dll")]
        public static extern bool FSOUND_StopSound(int channel);


        [DllImport("fmod.dll")]
        public static extern bool FSOUND_SetFrequency(int channel, int freq);


        [DllImport("fmod.dll")]
        public static extern bool FSOUND_SetLevels(int channel, int frontleft, int center, int frontright, int backleft, int backright, int lfe);


        [DllImport("fmod.dll")]
        public static extern bool FSOUND_SetLoopMode(int channel, FSOUND_MODES loopmode);


        [DllImport("fmod.dll")]
        public static extern bool FSOUND_SetMute(int channel, bool mute);


        [DllImport("fmod.dll")]
        public static extern bool FSOUND_SetPan(int channel, int pan);


        [DllImport("fmod.dll")]
        public static extern bool FSOUND_SetPaused(int channel, bool paused);


        [DllImport("fmod.dll")]
        public static extern bool FSOUND_SetPriority(int channel, int priority);


        [DllImport("fmod.dll")]
        public static extern bool FSOUND_SetReserved(int channel, bool reserved);


        [DllImport("fmod.dll")]
        public static extern bool FSOUND_SetSurround(int channel, bool surround);


        [DllImport("fmod.dll")]
        public static extern bool FSOUND_SetVolume(int channel, int vol);


        [DllImport("fmod.dll")]
        public static extern bool FSOUND_SetVolumeAbsolute(int channel, int vol);


        [DllImport("fmod.dll")]
        public static extern int FSOUND_GetVolume(int channel);


        [DllImport("fmod.dll")]
        public static extern int FSOUND_GetAmplitude(int channel);


        [DllImport("fmod.dll")]
        public static extern bool FSOUND_3D_SetAttributes(int channel, ref float F_FLOAT_API_pos, ref float F_FLOAT_API_vel);


        [DllImport("fmod.dll")]
        public static extern bool FSOUND_3D_SetMinMaxDistance(int channel, float F_FLOAT_API_min, float F_FLOAT_API_max);


        [DllImport("fmod.dll")]
        public static extern bool FSOUND_SetCurrentPosition(int channel, uint pos);


        [DllImport("fmod.dll")]
        public static extern int FSOUND_GetCurrentPosition(int channel);


        [DllImport("fmod.dll")]
        public static extern IntPtr FSOUND_GetCurrentSample(int channel);


        [DllImport("fmod.dll")]
        public static extern bool FSOUND_GetCurrentLevels(int channel, ref float F_FLOAT_API_l, ref float F_FLOAT_API_r);


        [DllImport("fmod.dll")]
        public static extern int FSOUND_GetFrequency(int channel);


        [DllImport("fmod.dll")]
        public static extern uint FSOUND_GetLoopMode(int channel);


        [DllImport("fmod.dll")]
        public static extern int FSOUND_GetMixer();


        [DllImport("fmod.dll")]
        public static extern bool FSOUND_GetMute(int channel);


        [DllImport("fmod.dll")]
        public static extern int FSOUND_GetNumSubChannels(int channel);


        [DllImport("fmod.dll")]
        public static extern int FSOUND_GetPan(int channel);


        [DllImport("fmod.dll")]
        public static extern bool FSOUND_GetPaused(int channel);


        [DllImport("fmod.dll")]
        public static extern int FSOUND_GetPriority(int channel);


        [DllImport("fmod.dll")]
        public static extern bool FSOUND_GetReserved(int channel);


        [DllImport("fmod.dll")]
        public static extern bool FSOUND_GetSubChannel(int channel, int subchannel);


        [DllImport("fmod.dll")]
        public static extern bool FSOUND_GetSurround(int channel);


        [DllImport("fmod.dll")]
        public static extern bool FSOUND_IsPlaying(int channel);


        [DllImport("fmod.dll")]
        public static extern bool FSOUND_3D_GetAttributes(int channel, ref float F_FLOAT_API_pos, ref float F_FLOAT_API_vel);


        [DllImport("fmod.dll")]
        public static extern bool FSOUND_3D_GetMinMaxDistance(int channel, ref float F_FLOAT_API_mindistance, ref float F_FLOAT_API_maxdistance);


        [DllImport("fmod.dll")]
        public static extern void FSOUND_DSP_ClearMixBuffer();


        /// <summary>
        /// Creates a DSP unit, and places it in the DSP chain position specified by the priority
        /// parameter. Read the remarks section carefully for issues regarding DSP units.
        /// DSP units are freed with FSOUND_DSP_Free.
        /// </summary>
        /// <param name="FSOUND_DSPCALLBACK">This is a pointer to your DSP Unit callback, of type FSOUND_DSPCALLBACK.
        /// The prototype for a callback is declared in the following fashion.
        /// Callbacks must return a pointer to the buffer you work on, so that
        /// the next dsp unit can work on it. See the definition of FSOUND_DSPCALLBACK for more.</param>
        /// <param name="priority">Order in the priority chain. Valid numbers are 0 to 1000, 0 being
        /// highest priority (first), with 1000 being lowest priority (last). 
        /// Note that FSOUNDs soundeffects mixers and copy routines are considered
        /// part of this DSP unit chain which you can play with.																												  </param>
        /// <param name="userdata">User defined parameter, this gets passed into the callback when it is called. It is safe to leave this value 0.</param>
        /// <returns>On success, a pointer to a new valid DSP unit is returned. On failure, NULL is returned.</returns>
        [DllImport("fmod.dll")]
        public static extern IntPtr FSOUND_DSP_Create(IntPtr FSOUND_DSPCALLBACK, FSOUND_DSP_PRIORITIES priority, IntPtr userdata);


        /// <summary>
        /// Frees and removes a DSP unit from the DSP chain.
        /// </summary>
        /// <param name="FSOUND_DSPUNIT">Pointer to DSP unit to be freed.</param>
        [DllImport("fmod.dll")]
        public static extern void FSOUND_DSP_Free(IntPtr FSOUND_DSPUNIT);


        /// <summary>
        /// Allows the user to toggle a DSP unit on or off.
        /// </summary>
        /// <param name="FSOUND_DSPUNIT">Pointer to DSP unit to have its active flag changed.</param>
        /// <param name="active">Flag to say whether DSP unit should be rendered active or inactive. valid values are TRUE or FALSE.</param>
        [DllImport("fmod.dll")]
        public static extern void FSOUND_DSP_SetActive(IntPtr FSOUND_DSPUNIT, bool active);


        /// <summary>
        /// Returns if a DSP unit is active or not.
        /// </summary>
        /// <param name="FSOUND_DSPUNIT">Pointer to DSP unit to have its active flag returned.</param>
        /// <returns>On success, TRUE is returned. On failure, FALSE is returned.</returns>
        [DllImport("fmod.dll")]
        public static extern bool FSOUND_DSP_GetActive(IntPtr FSOUND_DSPUNIT);


        /// <summary>
        /// Returns the buffer lenth passed by the DSP system to DSP unit callbacks, so you can allocate memory etc using this data.
        /// </summary>
        /// <returns>The size of the DSP unit buffer in SAMPLES (not bytes).</returns>
        [DllImport("fmod.dll")]
        public static extern int FSOUND_DSP_GetBufferLength();


        /// <summary>
        /// This is the total size in samples (not bytes) of the FSOUND mix buffer. This is affected by FSOUND_SetBufferSize.
        /// </summary>
        /// <returns>The size of the FSOUND mixing buffer in SAMPLES (not bytes).</returns>
        [DllImport("fmod.dll")]
        public static extern int FSOUND_DSP_GetBufferLengthTotal();


        /// <summary>
        /// Changes a DSP Unit's priority position in the DSP chain.
        /// </summary>
        /// <param name="FSOUND_DSPUNIT">Pointer to DSP unit to have its priority changed.</param>
        /// <param name="priority">Order in the priority chain. Valid numbers are 0 to 1000, 0 being highest priority (first), with 1000 being lowest priority (last).</param>
        [DllImport("fmod.dll")]
        public static extern void FSOUND_DSP_SetPriority(IntPtr FSOUND_DSPUNIT, int priority);


        /// <summary>
        /// Returns the priority status in the DSP chain, of a specified unit.
        /// </summary>
        /// <param name="FSOUND_DSPUNIT">Pointer to DSP unit to get priority value from.</param>
        /// <returns>On success, the priority of the unit, from 0 to 1000. On failure, -1 is returned.</returns>
        [DllImport("fmod.dll")]
        public static extern int FSOUND_DSP_GetPriority(IntPtr FSOUND_DSPUNIT);


        /// <summary>
        /// Returns a pointer to FSOUND's system DSP clear unit.
        /// </summary>
        /// <returns>Pointer to the DSP unit.</returns>
        [DllImport("fmod.dll")]
        public static extern IntPtr FSOUND_DSP_GetClearUnit();


        /// <summary>
        /// Returns a pointer to FSOUND's system Clip and Copy DSP unit.
        /// </summary>
        /// <returns>Pointer to the DSP unit.</returns>
        [DllImport("fmod.dll")]
        public static extern IntPtr FSOUND_DSP_GetClipAndCopyUnit();


        /// <summary>
        /// Returns a pointer to FSOUND's system DSP Music mixer unit.
        /// </summary>
        /// <returns>Pointer to the DSP unit.</returns>
        [DllImport("fmod.dll")]
        public static extern IntPtr FSOUND_DSP_GetMusicUnit();


        /// <summary>
        /// Returns a pointer to FSOUND's system DSP SFX mixer unit.
        /// </summary>
        /// <returns>Pointer to the DSP unit.</returns>
        [DllImport("fmod.dll")]
        public static extern IntPtr FSOUND_DSP_GetSFXUnit();


        /// <summary>
        /// Returns a pointer to FSOUND's system DSP FFT processing unit.
        /// </summary>
        /// <returns>Pointer to the DSP unit.</returns>
        [DllImport("fmod.dll")]
        public static extern IntPtr FSOUND_DSP_GetFFTUnit();


        /// <summary>
        /// Function to return a pointer to the current spectrum buffer. The buffer contains 512 floating 
        /// point values that represent each frequency band's amplitude for the current FMOD SoundSystem
        /// mixing buffer. The range of frequencies covered by the spectrum is 1 to the nyquist frequency
        /// or half of the output rate. So if the output rate is 44100, then frequencies provided are up 
        /// to 22050. (entry 511)
        /// </summary>
        /// <returns>A pointer to a buffer containing 512 floats.</returns>
        [DllImport("fmod.dll")]
        public static extern IntPtr FSOUND_DSP_GetSpectrum();


        /// <summary>
        /// Allows the user to mix their own data from one buffer to another, 
        /// using FSOUNDs optimized mixer routines. This was mainly provided 
        /// for DSP routines, though it can be used for anything.
        /// </summary>
        /// <param name="destbuffer">Pointer to a buffer to have the data mixed into.</param>
        /// <param name="srcbuffer">Pointer to the source buffer to be mixed in.</param>
        /// <param name="len">Amount to mix in SAMPLES.</param>
        /// <param name="freq">Speed to mix data to output buffer. Remember if you mix at a rate 
        ///		different than the output rate, the buffer lengths will have to be 
        ///		different to compensate. Ie if the output rate is 44100 and you supply
        ///		a value of 88200 to FSOUND_DSP_MixBuffers, you will only need a destbuffer
        ///		that is half the size of srcbuffer. If you supply a value of 22050 then
        ///		you will need a destbuffer that is twice as big as srcbuffer. If they
        ///		are both the same size then it will only mix half of the data.</param>
        /// <param name="vol">volume scalar value of mix. Valid values are 0 (silence) to 255 (full volume). See FSOUND_SetVolume for more information.</param>
        /// <param name="pan">pan value for data being mixed. Valid values are 0 (full left), 128 (middle), 255 (full right) and FSOUND_STEREOPAN. See FSOUND_SetPan for more information.</param>
        /// <param name="mode">Bit settings to describe the source buffer. Valid values are found in
        ///		FSOUND_MODES, but only 8/16bit and stereo/mono flags are interpreted,
        ///		other flags are ignored.</param>
        /// <returns>On success, TRUE is returned. On failure, FALSE is returned.</returns>
        [DllImport("fmod.dll")]
        public static extern bool FSOUND_DSP_MixBuffers(IntPtr destbuffer, IntPtr srcbuffer, int len, int freq, int vol, int pan, FSOUND_MODES mode);


        [DllImport("fmod.dll")]
        public static extern bool FSOUND_FX_Disable(int channel);


        /// <summary>
        /// Enables effect processing for the specified channel. This command continues to add effects to a channel (up to 16) until FSOUND_FX_Disable is called.
        /// </summary>
        /// <param name="channel">Channel number/handle to enable fx for.</param>
        /// <param name="fxtype">A single fx enum value to enable certain effects.</param>
        /// <returns>On success, an FX id is returned. On failure, -1 is returned.</returns>
        [DllImport("fmod.dll")]
        public static extern int FSOUND_FX_Enable(int channel, FSOUND_FX_MODES fxtype);


        /// <summary>
        /// Sets the parameters for the chorus effect on a particular channel
        /// </summary>
        /// <param name="fxid">fx handle generated by FSOUND_FX_Enable, to set chorus parameters for.</param>
        /// <param name="WetDryMix">Ratio of wet (processed) signal to dry (unprocessed) signal. Must be in the range from 0 through 100 (all wet).</param>
        /// <param name="Depth">Percentage by which the delay time is modulated by the low-frequency oscillator, in hundredths of a percentage point. Must be in the range from 0 through 100. The default value is 25.</param>
        /// <param name="Feedback">Percentage of output signal to feed back into the effects input, in the range from -99 to 99. The default value is 0.</param>
        /// <param name="Frequency">Frequency of the LFO, in the range from 0 to 10. The default value is 0.</param>
        /// <param name="Waveform">Waveform of the LFO. Defined values are 0 triangle.1 sine.By default, the waveform is a sine.</param>
        /// <param name="Delay">Number of milliseconds the input is delayed before it is played back, in the range from 0 to 20. The default value is 0 ms.</param>
        /// <param name="Phase">Phase differential between left and right LFOs, in the range from 0 through 4. Possible values are defined as follows: 
        /// 0 -180 degrees
        /// 1 - 90 degrees
        /// 2 0 degrees
        /// 3 90 degrees
        /// 4 180 degrees</param>
        /// <returns>On success, TRUE is returned. On failure, FALSE is returned.</returns>
        [DllImport("fmod.dll")]
        public static extern bool FSOUND_FX_SetChorus(int fxid, float WetDryMix, float Depth, float Feedback, float Frequency, int Waveform, float Delay, int Phase);


        /// <summary>
        /// Sets the parameters for the compressor effect on a particular channel
        /// </summary>
        /// <param name="fxid">fx handle generated by FSOUND_FX_Enable, to set compressor parameters for.</param>
        /// <param name="Gain">Output gain of signal after compression, in the range from -60 to 60. The default value is 0 dB.</param>
        /// <param name="Attack">Time before compression reaches its full value, in the range from 0.01 to 500. The default value is 0.01 ms.</param>
        /// <param name="Release">Speed at which compression is stopped after input drops below fThreshold, in the range from 50 to 3000. The default value is 50 ms.</param>
        /// <param name="Threshold">Point at which compression begins, in decibels, in the range from -60 to 0. The default value is -10 dB.</param>
        /// <param name="Ratio">Compression ratio, in the range from 1 to 100. The default value is 10, which means 10:1 compression.</param>
        /// <param name="Predelay"> Time after lThreshold is reached before attack phase is started, in milliseconds, in the range from 0 to 4. The default value is 0 ms. </param>
        /// <returns>On success, TRUE is returned. On failure, FALSE is returned.</returns>
        [DllImport("fmod.dll")]
        public static extern bool FSOUND_FX_SetCompressor(int fxid, float Gain, float Attack, float Release, float Threshold, float Ratio, float Predelay);


        /// <summary>
        /// Sets the parameters for the distortion effect on a particular channel
        /// </summary>
        /// <param name="fxid">fx handle generated by FSOUND_FX_Enable, to set distortion parameters for.</param>
        /// <param name="Gain">Amount of signal change after distortion, in the range from -60 through 0. The default value is 0 dB.</param>
        /// <param name="Edge">Percentage of distortion intensity, in the range in the range from 0 through 100. The default value is 50 percent.</param>
        /// <param name="PostEQCenterFrequency">Center frequency of harmonic content addition, in the range from 100 through 8000. The default value is 4000 Hz.</param>
        /// <param name="PostEQBandwidth">Width of frequency band that determines range of harmonic content addition, in the range from 100 through 8000. The default value is 4000 Hz.</param>
        /// <param name="PreLowpassCutoff">Filter cutoff for high-frequency harmonics attenuation, in the range from 100 through 8000. The default value is 4000 Hz.</param>
        /// <returns>On success, TRUE is returned. On failure, FALSE is returned.</returns>
        [DllImport("fmod.dll")]
        public static extern bool FSOUND_FX_SetDistortion(int fxid, float Gain, float Edge, float PostEQCenterFrequency, float PostEQBandwidth, float PreLowpassCutoff);


        /// <summary>
        /// Sets the parameters for the echo effect on a particular channel
        /// </summary>
        /// <param name="fxid">fx handle generated by FSOUND_FX_Enable, to set echo parameters for.</param>
        /// <param name="WetDryMix">Ratio of wet (processed) signal to dry (unprocessed) signal. Must be in the range from 0 through 100 (all wet).</param>
        /// <param name="Feedback">Percentage of output fed back into input, in the range from 0 through 100. The default value is 0.</param>
        /// <param name="LeftDelay">Delay for left channel, in milliseconds, in the range from 1 through 2000. The default value is 333 ms.</param>
        /// <param name="RightDelay">Delay for right channel, in milliseconds, in the range from 1 through 2000. The default value is 333 ms.</param>
        /// <param name="PanDelay">Value that specifies whether to swap left and right delays with each successive echo. The default value is FALSE, meaning no swap. Possible values are defined as TRUE or FALSE.</param>
        /// <returns>On success, TRUE is returned. On failure, FALSE is returned.</returns>
        [DllImport("fmod.dll")]
        public static extern bool FSOUND_FX_SetEcho(int fxid, float WetDryMix, float Feedback, float LeftDelay, float RightDelay, int PanDelay);


        /// <summary>
        /// Sets the parameters for the flanger effect on a particular channel
        /// </summary>
        /// <param name="fxid">fx handle generated by FSOUND_FX_Enable, to set flanger parameters for.</param>
        /// <param name="WetDryMix">Ratio of wet (processed) signal to dry (unprocessed) signal. Must be in the range from 0 through 100 (all wet).</param>
        /// <param name="Depth">Percentage by which the delay time is modulated by the low-frequency oscillator (LFO), in hundredths of a percentage point. Must be in the range from 0 through 100. The default value is 25.</param>
        /// <param name="Feedback">Percentage of output signal to feed back into the effects input, in the range from -99 to 99. The default value is 0.</param>
        /// <param name="Frequency">Frequency of the LFO, in the range from 0 to 10. The default value is 0.</param>
        /// <param name="Waveform">Waveform of the LFO. By default, the waveform is a sine. Possible values are defined as follows: 0 - Triangle. 1 - Sine.</param>
        /// <param name="Delay">Number of milliseconds the input is delayed before it is played back, in the range from 0 to 4. The default value is 0 ms.</param>
        /// <param name="Phase">Phase differential between left and right LFOs, in the range from 0 through 4. Possible values are defined as follows: 
        ///		0 -180 degrees
        ///		1 - 90 degrees
        ///		2 0 degrees
        ///		3 90 degrees
        ///		4 180 degrees</param>
        /// <returns>On success, TRUE is returned. On failure, FALSE is returned.</returns>
        [DllImport("fmod.dll")]
        public static extern bool FSOUND_FX_SetFlanger(int fxid, float WetDryMix, float Depth, float Feedback, float Frequency, int Waveform, float Delay, int Phase);


        /// <summary>
        /// Sets the parameters for the gargle effect on a particular channel
        /// </summary>
        /// <param name="fxid">fx handle generated by FSOUND_FX_Enable, to set gargle parameters for.</param>
        /// <param name="RateHz">Rate of modulation, in Hertz. Must be in the range from 1 through 1000.</param>
        /// <param name="WaveShape">Shape of the modulation wave. The following values are defined. 
        ///		0 - Triangular wave. 
        ///		1 - Square wave.</param>
        /// <returns>On success, TRUE is returned. On failure, FALSE is returned.</returns>
        [DllImport("fmod.dll")]
        public static extern bool FSOUND_FX_SetGargle(int fxid, int RateHz, int WaveShape);


        /// <summary>
        /// Sets the parameters for the I3DL2 Reverb effect on a particular channel
        /// </summary>
        /// <param name="fxid"> fx handle generated by FSOUND_FX_Enable, to set I3DL2 Reverb parameters for.</param>
        /// <param name="Room">Attenuation of the room effect, in millibels (mB), in the range from -10000 to 0. The default value is -1000 mB.</param>
        /// <param name="RoomHF"> Attenuation of the room high-frequency effect, in mB, in the range from -10000 to 0. The default value is 0 mB. </param>
        /// <param name="RoomRolloffFactor">Rolloff factor for the reflected signals, in the range from 0 to 10. The default value is 0.0. The rolloff factor for the direct path is controlled by the listener.</param>
        /// <param name="DecayTime">Decay time, in seconds, in the range from .1 to 20. The default value is 1.49 seconds.</param>
        /// <param name="DecayHFRatio">Ratio of the decay time at high frequencies to the decay time at low frequencies, in the range from 0.1 to 2. The default value is 0.83.</param>
        /// <param name="Reflections">Attenuation of early reflections relative to lRoom, in mB, in the range from -10000 to 1000. The default value is -2602 mB.</param>
        /// <param name="ReflectionsDelay">Delay time of the first reflection relative to the direct path, in seconds, in the range from 0 to 0.3. The default value is 0.007 seconds.</param>
        /// <param name="Reverb">Attenuation of late reverberation relative to lRoom, in mB, in the range from -10000 to 2000. The default value is 200 mB.</param>
        /// <param name="ReverbDelay">Time limit between the early reflections and the late reverberation relative to the time of the first reflection, in seconds, in the range from 0 to 0.1. The default value is 0.011 seconds.</param>
        /// <param name="Diffusion">Echo density in the late reverberation decay, in percent, in the range from 0 to 100. The default value is 100.0 percent.</param>
        /// <param name="Density">Modal density in the late reverberation decay, in percent, in the range from 0 to 100. The default value is 100.0 percent.</param>
        /// <param name="HFReference">Reference high frequency, in hertz, in the range from 20 to 20000. The default value is 5000.0 Hz.</param>
        /// <returns>On success, TRUE is returned. On failure, FALSE is returned.</returns>
        [DllImport("fmod.dll")]
        public static extern bool FSOUND_FX_SetI3DL2Reverb(int fxid, int Room, int RoomHF, float RoomRolloffFactor, float DecayTime, float DecayHFRatio, int Reflections, float ReflectionsDelay, int Reverb, float ReverbDelay, float Diffusion, float Density, float HFReference);


        /// <summary>
        /// Sets the parameters for the Param EQ effect on a particular channel
        /// </summary>
        /// <param name="fxid">fx handle generated by FSOUND_FX_Enable, to set ParamEQ parameters for.</param>
        /// <param name="Center">Center frequency, in hertz, in the range from 80 to 16000. This value cannot exceed one-third of the frequency of the buffer. Default is 8000.</param>
        /// <param name="Bandwidth">Bandwidth, in semitones, in the range from 1 to 36. Default is 12.</param>
        /// <param name="Gain">Gain, in the range from -15 to 15. Default is 0.</param>
        /// <returns>On success, TRUE is returned. On failure, FALSE is returned.</returns>
        [DllImport("fmod.dll")]
        public static extern bool FSOUND_FX_SetParamEQ(int fxid, float Center, float Bandwidth, float Gain);


        /// <summary>
        /// Sets the parameters for the Waves Reverb effect on a particular channel
        /// </summary>
        /// <param name="fxid">fx handle generated by FSOUND_FX_Enable, number/handle to set Waves Reverb parameters for.</param>
        /// <param name="InGain">Input gain of signal, in decibels (dB), in the range from -96 through 0. The default value is 0 dB.</param>
        /// <param name="ReverbMix">Reverb mix, in dB, in the range from -96 through 0. The default value is 0 dB.</param>
        /// <param name="ReverbTime">Reverb time, in milliseconds, in the range from .001 through 3000. The default value is 1000.</param>
        /// <param name="HighFreqRTRatio">In the range from .001 through .999. The default value is 0.001.</param>
        /// <returns>On success, TRUE is returned. On failure, FALSE is returned.</returns>
        [DllImport("fmod.dll")]
        public static extern bool FSOUND_FX_SetWavesReverb(int fxid, float InGain, float ReverbMix, float ReverbTime, float HighFreqRTRatio);


        [DllImport("fmod.dll")]
        public static extern float FSOUND_GetCPUUsage();


        /// <summary>
        /// Returns the number of active channels in FSOUND, or ones that are playing.
        /// </summary>
        /// <returns>Number of active channels.</returns>
        [DllImport("fmod.dll")]
        public static extern int FSOUND_GetChannelsPlaying();


        /// <summary>
        /// Returns the currently selected driver number. Drivers are enumerated when selecting a driver 
        /// with FSOUND_SetDriver or other driver related functions such as FSOUND_GetNumDrivers or 
        /// FSOUND_GetDriverName
        /// </summary>
        /// <returns>Currently selected driver id.</returns>
        [DllImport("fmod.dll")]
        public static extern int FSOUND_GetDriver();


        /// <summary>
        /// Returns information on capabilities of the current output mode.
        /// </summary>
        /// <param name="id">Enumerated driver ID. This must be in a valid range delimited by FSOUND_GetNumDrivers.</param>
        /// <param name="caps">Pointer to an unsigned int to have the caps bits stored.</param>
        /// <returns>On success, TRUE is returned. On failure, FALSE is returned.</returns>
        [DllImport("fmod.dll")]
        public static extern bool FSOUND_GetDriverCaps(int id, ref uint caps);


        /// <summary>
        /// Returns the name of the selected driver. Drivers are enumerated when selecting a 
        /// driver with FSOUND_SetDriver or other driver related functions such 
        /// as FSOUND_GetNumDrivers or FSOUND_GetDriver
        /// </summary>
        /// <param name="id">Enumerated driver ID. This must be in a valid range delimited by FSOUND_GetNumDrivers.</param>
        /// <returns>On success, a pointer to a NULL terminated string containing the name of the specified 
        /// device is returned. The number of drivers enumerated can be found with FSOUND_GetNumDrivers.
        /// On failure, NULL is returned.</returns>
        [DllImport("fmod.dll")]
        public static extern string FSOUND_GetDriverName(int id);


        /// <summary>
        /// Returns an error code set by FMOD.
        /// </summary>
        /// <returns>Code, see FMOD_ERRORS</returns>
        [DllImport("fmod.dll")]
        public static extern int FSOUND_GetError();


        /// <summary>
        /// Returns the current maximum index for a sample. This figure grows as you allocate more samples (in blocks)
        /// </summary>
        /// <returns>Maximum sample index</returns>
        [DllImport("fmod.dll")]
        public static extern int FSOUND_GetMaxSamples();


        /// <summary>
        /// Returns the total number of channels allocated.
        /// </summary>
        /// <returns>Number of channels allocated</returns>
        [DllImport("fmod.dll")]
        public static extern int FSOUND_GetMaxChannels();


        /// <summary>
        /// Returns information on the memory usage of fmod. This is useful for 
        /// determining a fixed memory size to make FMOD work within for fixed memory 
        /// machines such as pocketpc and consoles.
        /// </summary>
        /// <param name="currentalloced">Currently allocated memory at time of call.</param>
        /// <param name="maxalloced">Maximum allocated memory since FSOUND_Init or FSOUND_SetMemorySystem</param>
        [DllImport("fmod.dll")]
        public static extern void FSOUND_GetMemoryStats(ref uint currentalloced, ref uint maxalloced);


        /// <summary>
        /// Returns the number of sound cards or devices enumerated for the current output type. (Direct Sound, WaveOut etc.)
        /// </summary>
        /// <returns>Total number of enumerated sound devices.</returns>
        [DllImport("fmod.dll")]
        public static extern int FSOUND_GetNumDrivers();


        /// <summary>
        /// Returns the number of available hardware mixed 2d and 3d channels.
        /// </summary>
        /// <param name="num2d">Pointer to integer to store the number of available hardware mixed 2d channels.</param>
        /// <param name="num3d">Pointer to integer to store the number of available hardware mixed 3d channels.</param>
        /// <param name="total">Usually num2d + num3d, but on some platforms like PS2 and GameCube, this will be the same as num2d and num3d (and not the sum) because 2d and 3d voices share the same pool.</param>
        /// <returns>On success, TRUE is returned. On failure, FALSE is returned.</returns>
        [DllImport("fmod.dll")]
        public static extern bool FSOUND_GetNumHWChannels(ref int num2d, ref int num3d, ref int total);


        /// <summary>
        /// Returns the current id to the output type. See FSOUND_OUTPUTTYPES for valid parameters and descriptions.
        /// </summary>
        /// <returns>id to output type</returns>
        [DllImport("fmod.dll")]
        public static extern FSOUND_OUTPUTTYPES FSOUND_GetOutput();


        /// <summary>
        /// Returns a pointer to the system level output device module. This means a pointer to a DIRECTSOUND, WINMM handle, or with NOSOUND output, NULL.
        /// </summary>
        /// <returns>Pointer to output handle specific to the device.</returns>
        [DllImport("fmod.dll")]
        public static extern IntPtr FSOUND_GetOutputHandle();


        /// <summary>
        /// Returns the current mixing rate
        /// </summary>
        /// <returns>Currently set output rate in HZ.</returns>
        [DllImport("fmod.dll")]
        public static extern int FSOUND_GetOutputRate();


        /// <summary>
        /// Returns the master volume for any sound effects played.
        /// It specifically has SFX in the function name, as it does not affect music or CD volume.
        /// This must also be altered with FMUSIC_SetMasterVolume.
        /// </summary>
        /// <returns>On success, the SFX master volume is returned. Valid ranges are from 0 (silent) to 255 (full volume)</returns>
        [DllImport("fmod.dll")]
        public static extern int FSOUND_GetSFXMasterVolume();


        /// <summary>
        /// Returns the FMOD version number.
        /// </summary>
        /// <returns>FMOD version number.</returns>
        [DllImport("fmod.dll")]
        public static extern float FSOUND_GetVersion();


        [DllImport("fmod.dll")]
        public static extern void FSOUND_Close();


        /// <summary>
        /// Specify user callbacks for FMOD's internal file manipulation functions. 
        /// If ANY of these parameters are NULL, then FMOD will switch back to its own file routines.
        /// You can replace this with memory routines (ie name can be cast to a memory address for example, then open sets up
        /// a handle based on this information), or alternate file routines, ie a WAD file reader.
        /// </summary>
        /// <param name="FSOUND_OPENCALLBACK">Callback for opening a file.</param>
        /// <param name="FSOUND_CLOSECALLBACK">Callback for closing a file.</param>
        /// <param name="FSOUND_READCALLBACK">Callback for reading from a file.</param>
        /// <param name="FSOUND_SEEKCALLBACK">Callback for seeking within a file.</param>
        /// <param name="FSOUND_TELLCALLBACK">Callback for returning the offset from the base of the open file in bytes.</param>
        [DllImport("fmod.dll")]
        public static extern void FSOUND_File_SetCallbacks(IntPtr FSOUND_OPENCALLBACK, IntPtr FSOUND_CLOSECALLBACK, IntPtr FSOUND_READCALLBACK, IntPtr FSOUND_SEEKCALLBACK, IntPtr FSOUND_TELLCALLBACK);


        /// <summary>
        /// Initializes the FMOD Sound System.
        /// </summary>
        /// <param name="mixrate">Output rate in hz between 4000 and 65535. Any thing outside this will cause
        /// the function to fail and return FALSE. PS2 Note. Only rates of 24000 and 48000 are supported.
        /// SmartPhone Note. Use 22050 or the operating system may crash outside of the control of fmod.</param>
        /// <param name="maxsoftwarechannels">Maximum number of SOFTWARE channels available. The number of HARDWARE channels is autodetected. 
        /// The total number of channels available (hardware and software) after initialization can be found with FSOUND_GetMaxChannels.
        /// Having a large number of maxchannels does not adversely affect cpu usage, but it means it has the POTENTIAL to mix a large number of channels, 
        /// which can have an adverse effect on cpu usage.
        /// 1024 is the highest number that can be set. Anything higher will return an error.
        /// </param>
        /// <param name="flags">See FSOUND_INIT_FLAGS. Controls some global or initialization time aspects of playback.</param>
        /// <returns>On success, TRUE is returned. On failure, FALSE is returned.</returns>
        [DllImport("fmod.dll")]
        public static extern bool FSOUND_Init(int mixrate, int maxsoftwarechannels, FSOUND_INIT_FLAGS flags);


        /// <summary>
        /// Sets the FMOD internal mixing buffer size. It is configurable because low buffersizes use less memory, but are more instable.
        /// More importantly, increasing buffer size will increase sound output stability, but on the other hand increases latency, and to some extent, CPU usage.
        /// * FMOD chooses the most optimal size by default for best stability, depending on the output type - and if the drivers are emulated or not (NT). 
        /// It is not recommended changing this value unless you really need to. You may get worse performance than the default settings chosen by FMOD.
        /// </summary>
        /// <param name="len_ms">The buffer size in milliseconds.</param>
        /// <returns>On success, TRUE is returned. On failure, (ie if FMOD is already active) FALSE is returned.</returns>
        [DllImport("fmod.dll")]
        public static extern bool FSOUND_SetBufferSize(int len_ms);


        /// <summary>
        /// Selects a soundcard driver. It is used when an output mode has enumerated more than one output device, and you need to select between them.
        /// </summary>
        /// <param name="driver">Driver number to select. 0 will select the DEFAULT sound driver. 
        /// '0 will select an INVALID driver which will case the DEVICE to be set 
        /// to a null (nosound) driver. '0 Selects other valid drivers that can be listed with FSOUND_GetDriverName.</param>
        /// <returns>On success, TRUE is returned. On failure, (ie if FMOD is already active) FALSE is returned.</returns>
        [DllImport("fmod.dll")]
        public static extern bool FSOUND_SetDriver(int driver);


        /// <summary>
        /// This is an optional function to set the window handle of the application you are writing, so Directsound can tell if it is in focus or not.
        /// </summary>
        /// <param name="hwnd">Pointer to a HWND windows handle of your application. NULL means it will pick the foreground application window.</param>
        /// <returns>On success, TRUE is returned. On failure, FALSE is returned.</returns>
        [DllImport("fmod.dll")]
        public static extern bool FSOUND_SetHWND(IntPtr hwnd);


        /// <summary>
        /// This sets the maximum allocatable channels on a hardware card. FMOD automatically detects and allocates the maximum number of 3d hardware channels, so calling this will limit that number if it becomes too much.
        /// </summary>
        /// <param name="max">The maximum number of hardware channels to allocate, even if the soundcard supports more.</param>
        /// <returns>On success, TRUE is returned. On failure, FALSE is returned.</returns>
        [DllImport("fmod.dll")]
        public static extern bool FSOUND_SetMaxHardwareChannels(int max);


        /// <summary>
        /// Specifies a method for FMOD to allocate memory, either through callbacks or its own internal memory management. You can also supply a pool of memory for FMOD to work with and it will do so with no extra calls to malloc or free. 
        /// This is useful for systems that want FMOD to use their own memory management, or fixed memory devices such as PocketPC, XBox, PS2 and GameCube that dont want any allocations occuring out of their control causing fragmentation or unpredictable overflows in a tight memory space.
        /// See remarks for more useful information.
        /// </summary>
        /// <param name="poolmem">If you want a fixed block of memory for FMOD to use, pass it in here. Specify the length in poollen. Specifying NULL doesnt use internal management and it relies on callbacks.</param>
        /// <param name="poollen">Length in bytes of the pool of memory for FMOD to use specified in. Specifying 0 turns off internal memory management and relies purely on callbacks. Length must be a multiple of 512.</param>
        /// <param name="FSOUND_ALLOCCALLBACK">Only supported if pool is NULL. Otherwise it overrides the FMOD internal calls to alloc. Compatible with ansi malloc().</param>
        /// <param name="FSOUND_REALLOCCALLBACK">Only supported if pool is NULL. Otherwise it overrides the FMOD internal calls to realloc. Compatible with ansi realloc().</param>
        /// <param name="FSOUND_FREECALLBACK">Only supported if pool is NULL. Otherwise it overrides the FMOD internal calls to free. Compatible with ansi free().</param>
        [DllImport("fmod.dll")]
        public static extern void FSOUND_SetMemorySystem(IntPtr poolmem, int poollen, IntPtr FSOUND_ALLOCCALLBACK, IntPtr FSOUND_REALLOCCALLBACK, IntPtr FSOUND_FREECALLBACK);


        /// <summary>
        /// This sets the minimum allowable hardware channels before FMOD drops back to 100 percent software.
        /// This is helpful for minimum spec cards, and not having to guess how many hardware channels
        /// they might have. This way you can guarantee and assume a certain number of channels for
        /// your application and place them all in FSOUND_HW3D without fear of the playsound failing
        /// because it runs out of channels on a low spec card.
        /// </summary>
        /// <param name="min">The minimum number of hardware channels allowable on a card before it uses the software engine 1004562604f the time.</param>
        /// <returns>On success, TRUE is returned. On failure, FALSE is returned.</returns>
        [DllImport("fmod.dll")]
        public static extern bool FSOUND_SetMinHardwareChannels(int min);


        /// <summary>
        /// Sets a digital mixer type.
        /// </summary>
        /// <param name="mixer">mixer type, see FSOUND_MIXERTYPES for valid parameters and descriptions.</param>
        /// <returns>On success, TRUE is returned. On failure, (ie if FMOD is already active) FALSE is returned.</returns>
        [DllImport("fmod.dll")]
        public static extern bool FSOUND_SetMixer(FSOUND_MIXERTYPES mixer);


        /// <summary>
        /// Sets up the soundsystem output mode.
        /// </summary>
        /// <param name="outputtype">The output system to be used. See FSOUND_OUTPUTTYPES for valid parameters and descriptions. -1 Is autodetect based on operating system.</param>
        /// <returns>On success, TRUE is returned. On failure, (ie if FMOD is already active) FALSE is returned.</returns>
        [DllImport("fmod.dll")]
        public static extern bool FSOUND_SetOutput(FSOUND_OUTPUTTYPES outputtype);


        [DllImport("fmod.dll")]
        public static extern int FSOUND_Record_GetDriver();


        /// <summary>
        /// Returns the name of the selected recording driver. Drivers are enumerated when selecting a driver with
        /// FSOUND_Record_SetDriver or other driver related functions such as FSOUND_Record_GetNumDrivers or FSOUND_Record_GetDriver
        /// </summary>
        /// <param name="id">Enumerated driver ID. This must be in a valid range delimited by FSOUND_Record_GetNumDrivers.</param>
        /// <returns>On success, a pointer to a NULL terminated string containing the name of the specified device is returned. The number of drivers enumerated can be found with FSOUND_Record_GetNumDrivers.
        /// On failure, NULL is returned.</returns>
        [DllImport("fmod.dll")]
        public static extern string FSOUND_Record_GetDriverName(int id);


        /// <summary>
        /// Returns the number of sound cards or devices enumerated for the current input type. (DirectSound, WaveOut etc.)
        /// </summary>
        /// <returns>Total number of enumerated sound devices.</returns>
        [DllImport("fmod.dll")]
        public static extern int FSOUND_Record_GetNumDrivers();


        /// <summary>
        /// Gets the position in the sample buffer that has been recorded to.
        /// </summary>
        /// <returns>On success, the offset in SAMPLES, for the record buffer that the input device has just written up to is returned.
        /// On failure (recording device hasnt been started), -1 is returned.</returns>
        [DllImport("fmod.dll")]
        public static extern int FSOUND_Record_GetPosition();


        /// <summary>
        /// Selects a soundcard recording driver.
        /// It is used when an output mode has enumerated more than one recording device and you need to select between them.
        /// </summary>
        /// <param name="driver">Recording driver number to select.
        /// '=0 will select the DEFAULT recording sound driver.
        /// '0 Selects other valid drivers that can be listed with FSOUND_Record_GetDriverName.</param>
        /// <returns>On success, TRUE is returned. On failure, FALSE is returned.</returns>
        [DllImport("fmod.dll")]
        public static extern bool FSOUND_Record_SetDriver(int driver);


        /// <summary>
        /// Starts recording into a predefined sample using the sample's default playback rate as the recording rate.
        /// </summary>
        /// <param name="FSOUND_SAMPLE_sptr">The sample to record into.</param>
        /// <param name="loop">TRUE or FALSE flag whether the recorder should keep recording once it has hit the end, 
        /// and start from the start again, therefore creating a continuous recording session into that 
        /// sample buffer. Looping the recording buffer is good for realtime processing of recordedinformation, as you can record and playback the sample at the same time.</param>
        /// <returns>On success, TRUE is returned. On failure, FALSE is returned.</returns>
        [DllImport("fmod.dll")]
        public static extern bool FSOUND_Record_StartSample(IntPtr FSOUND_SAMPLE_sptr, bool loop);


        /// <summary>
        /// Halts recording to the specified sample.
        /// </summary>
        /// <returns>On success, TRUE is returned. On failure, FALSE is returned.</returns>
        [DllImport("fmod.dll")]
        public static extern bool FSOUND_Record_Stop();


        [DllImport("fmod.dll")]
        public static extern bool FSOUND_Reverb_SetProperties(FSOUND_REVERB_PROPERTIES prop);


        /// <summary>
        /// Returns the current hardware reverb environment.
        /// </summary>
        /// <param name="prop">Pointer to a FSOUND_REVERB_PROPERTIES structure definition. The definiotion for this structure is given in the link below.</param>
        /// <returns>On success, TRUE is returned. On failure, FALSE is returned.</returns>
        [DllImport("fmod.dll")]
        public static extern bool FSOUND_Reverb_GetProperties(FSOUND_REVERB_PROPERTIES prop);


        /// <summary>
        /// Sets the channel specific reverb properties for hardware, including wet/dry mix (room size), and things like obstruction and occlusion properties.
        /// </summary>
        /// <param name="channel">The channel to have its reverb properties changed. FSOUND_ALL can also be used (see remarks)</param>
        /// <param name="prop">Pointer to a FSOUND_REVERB_CHANNELPROPERTIES structure definition. The definition for this structure is given in the link below.</param>
        /// <returns>On success, TRUE is returned. On failure, FALSE is returned.</returns>
        [DllImport("fmod.dll")]
        public static extern bool FSOUND_Reverb_SetChannelProperties(int channel, FSOUND_REVERB_PROPERTIES prop);


        /// <summary>
        /// This function gets the current reverb properties for this channel.
        /// </summary>
        /// <param name="channel">The channel to have its reverb mix returned.</param>
        /// <param name="prop">Pointer to a FSOUND_REVERB_CHANNELPROPERTIES structure definition. The definition for this structure is given in the link below.</param>
        /// <returns>On success, TRUE is returned. On failure, FALSE is returned.</returns>
        [DllImport("fmod.dll")]
        public static extern bool FSOUND_Reverb_GetChannelProperties(int channel, FSOUND_REVERB_PROPERTIES prop);


        [DllImport("fmod.dll")]
        public static extern IntPtr FSOUND_Sample_Alloc(int index, int length, FSOUND_MODES mode, int deffreq, int defvol, int defpan, int defpri);


        /// <summary>
        /// Removes a sample from memory and makes its slot available again.
        /// </summary>
        /// <param name="FSOUND_SAMPLE">Pointer to the sample definition to be freed.</param>
        [DllImport("fmod.dll")]
        public static extern void FSOUND_Sample_Free(IntPtr FSOUND_SAMPLE);


        /// <summary>
        /// Returns a pointer to a managed sample based on the index passed.
        /// </summary>
        /// <param name="sampno">The index in the sample management pool of the requested sample.</param>
        /// <returns>Pointer to a sample.</returns>
        [DllImport("fmod.dll")]
        public static extern IntPtr FSOUND_Sample_Get(int sampno);


        /// <summary>
        /// Returns the default volume, frequency, pan and priority values for the specified sample.
        /// </summary>
        /// <param name="FSOUND_SAMPLE">Pointer to the sample to get the default information from.</param>
        /// <param name="deffreq">Pointer to value to be filled with the sample default frequency. Can be NULL.</param>
        /// <param name="defvol">Pointer to value to be filled with the sample default volume. Can be NULL.</param>
        /// <param name="defpan">Pointer to value to be filled with the sample default pan. Can be NULL.</param>
        /// <param name="defpri">Pointer to value to be filled with the sample default priority. Can be NULL.</param>
        /// <returns>On success, TRUE is returned. On failure, FALSE is returned.</returns>
        [DllImport("fmod.dll")]
        public static extern bool FSOUND_Sample_GetDefaults(IntPtr FSOUND_SAMPLE, ref int deffreq, ref int defvol, ref int defpan, ref int defpri);


        /// <summary>
        /// Returns the default volume, frequency, pan, priority and random playback variations for the specified sample.
        /// </summary>
        /// <param name="FSOUND_SAMPLE">Pointer to the sample to get the default information from.</param>
        /// <param name="deffreq">Pointer to value to be filled with the sample default frequency. Can be NULL.</param>
        /// <param name="defvol">Pointer to value to be filled with the sample default volume. Can be NULL.</param>
        /// <param name="defpan">Pointer to value to be filled with the sample default pan. Can be NULL.</param>
        /// <param name="defpri">Pointer to value to be filled with the sample default priority. Can be NULL.</param>
        /// <param name="varfreq">Pointer to value to be filled with the sample random frequency variance. Can be NULL.</param>
        /// <param name="varvol">Pointer to value to be filled with the sample random volume variance. Can be NULL.</param>
        /// <param name="varpan">Pointer to value to be filled with the sample random pan variance. Can be NULL.</param>
        /// <returns>On success, TRUE is returned. On failure, FALSE is returned.</returns>
        [DllImport("fmod.dll")]
        public static extern bool FSOUND_Sample_GetDefaultsEx(IntPtr FSOUND_SAMPLE, ref int deffreq, ref int defvol, ref int defpan, ref int defpri, ref int varfreq, ref int varvol, ref int varpan);


        /// <summary>
        /// Returns the length of the sample in SAMPLES.
        /// </summary>
        /// <param name="FSOUND_SAMPLE">Pointer to the sample to get the length from.</param>
        /// <returns>On success, the length of sample in SAMPLES is returned. On failure, 0 is returned.</returns>
        [DllImport("fmod.dll")]
        public static extern uint FSOUND_Sample_GetLength(IntPtr FSOUND_SAMPLE);


        /// <summary>
        /// Returns the start and end positions of the specified sample loop in SAMPLES (not bytes).
        /// </summary>
        /// <param name="FSOUND_SAMPLE">Pointer to the sample to get the loop point information from.</param>
        /// <param name="loopstart">Pointer to value to be filled with the sample loop start point. Can be NULL.</param>
        /// <param name="loopend">Pointer to value to be filled with the sample loop end point. Can be NULL.</param>
        /// <returns>On success, TRUE is returned. On failure, FALSE is returned.</returns>
        [DllImport("fmod.dll")]
        public static extern bool FSOUND_Sample_GetLoopPoints(IntPtr FSOUND_SAMPLE, ref int loopstart, ref int loopend);


        /// <summary>
        /// Get the minimum and maximum audible distance for a sample.
        /// </summary>
        /// <param name="FSOUND_SAMPLE">The sample to get minimum and maximum audible distance information from.</param>
        /// <param name="F_FLOAT_API_min">Pointer to value to be filled with the sample.</param>
        /// <param name="F_FLOAT_API_max">Maximum volume distance. See remarks for more on units.</param>
        /// <returns>On success, TRUE is returned.On failure, FALSE is returned.</returns>
        [DllImport("fmod.dll")]
        public static extern bool FSOUND_Sample_GetMinMaxDistance(IntPtr FSOUND_SAMPLE, ref float F_FLOAT_API_min, ref float F_FLOAT_API_max);


        /// <summary>
        /// Returns a bitfield containing information about the specified sample. 
        /// The values can be bitwise AND'ed with the values contained in FSOUND_MODES to see if certain criteria are true or not. 
        /// Information that can be retrieved from the same in this field are loop type, bitdepth and stereo/mono.
        /// </summary>
        /// <param name="FSOUND_SAMPLE">Pointer to the sample to get the mode information on</param>
        /// <returns>On success, the sample mode is returned. On failure, 0 is returned.</returns>
        [DllImport("fmod.dll")]
        public static extern FSOUND_MODES FSOUND_Sample_GetMode(IntPtr FSOUND_SAMPLE);


        /// <summary>
        /// Returns a pointer to a NULL terminated string containing the sample's name.
        /// </summary>
        /// <param name="FSOUND_SAMPLE">Pointer to the sample to get the name from.</param>
        /// <returns>On success, the name of the sample is returned. On failure, NULL is returned.</returns>
        [DllImport("fmod.dll")]
        public static extern string FSOUND_Sample_GetName(IntPtr FSOUND_SAMPLE);


        /// <summary>
        /// Loads and decodes a static soundfile into memory. This includes such files as .WAV, .MP2, .MP3, .OGG, .RAW and others.
        /// </summary>
        /// <param name="index">Sample pool index. See remarks for more on the sample pool.
        /// 0 or above - The absolute index into the sample pool. The pool will grow as the index gets larger. If a slot is already used it will be replaced.
        /// FSOUND_FREE - Let FSOUND select an arbitrary sample slot. 
        /// FSOUND_UNMANAGED - Dont have this sample managed within fsounds sample management system</param>
        /// <param name="name_or_data">Name of sound file or pointer to memory image to load.</param>
        /// <param name="inputmode">Description of the data format, OR in the bits defined in FSOUND_MODES to describe the data being loaded.</param>
        /// <param name="offset">Optional. 0 by default. If > 0, this value is used to specify an offset in a file, so fmod will seek before opening. length must also be specified if this value is used.</param>
        /// <param name="length">Optional. 0 by default. If > 0, this value is used to specify the length of a memory block when using FSOUND_LOADMEMORY, or it is the length of a file or file segment if the offset parameter is used. On PlayStation 2 this must be 16 byte aligned for memory loading.</param>
        /// <returns>On success, a sample pointer is returned. On failure, NULL is returned.</returns>
        [DllImport("fmod.dll")]
        public static extern IntPtr FSOUND_Sample_Load(int index, string name_or_data, FSOUND_MODES inputmode, int offset, int length);


        /// <summary>
        /// Returns a pointer to the beginning of the sample data for a sample. Data written to these pointers must be signed.
        /// </summary>
        /// <param name="FSOUND_SAMPLE">Pointer to the sample definition.</param>
        /// <param name="offset">Offset in BYTES to the position you want to lock in the sample buffer.</param>
        /// <param name="length">Number of BYTES you want to lock in the sample buffer.</param>
        /// <param name="ptr1">Address of a pointer that will point to the first part of the locked data.</param>
        /// <param name="ptr2">Address of a pointer that will point to the second part of the locked data.
        /// This will be NULL if the data locked hasnt wrapped at the end of the buffer.</param>
        /// <param name="len1">Length of data in BYTES that was locked for ptr1</param>
        /// <param name="len2">Length of data in BYTES that was locked for ptr2. This will be 0 if the data locked hasnt wrapped at the end of the buffer.</param>
        /// <returns>On success, TRUE is returned. On failure, FALSE is returned.</returns>
        [DllImport("fmod.dll")]
        public static extern bool FSOUND_Sample_Lock(IntPtr FSOUND_SAMPLE, int offset, int length, ref IntPtr ptr1, ref IntPtr ptr2, ref uint len1, ref uint len2);


        /// <summary>
        /// Sets a sample's default attributes, so when it is played it uses these values without having to specify them later.
        /// </summary>
        /// <param name="FSOUND_SAMPLE">Pointer to the sample to have its attributes set.</param>
        /// <param name="deffreq">Default sample frequency. The value here is specified in hz. -1 to ignore.</param>
        /// <param name="defvol">Default sample volume. This is a value from 0 to 255. -1 to ignore.</param>
        /// <param name="defpan">Default sample pan position. This is a value from 0 to 255 or FSOUND_STEREOPAN.</param>
        /// <param name="defpri">Default sample priority. This is a value from 0 to 255. -1 to ignore.</param>
        /// <returns>On success, TRUE is returned. On failure, FALSE is returned.</returns>
        [DllImport("fmod.dll")]
        public static extern bool FSOUND_Sample_SetDefaults(IntPtr FSOUND_SAMPLE, int deffreq, int defvol, int defpan, int defpri);


        /// <summary>
        /// Sets a sample's default attributes, so when it is played it uses these values without having to specify them later.
        /// </summary>
        /// <param name="FSOUND_SAMPLE">Pointer to the sample to have its attributes set.</param>
        /// <param name="deffreq">Default sample frequency. The value here is specified in hz. -1 to ignore.</param>
        /// <param name="defvol">Default sample volume. This is a value from 0 to 255. -1 to ignore.</param>
        /// <param name="defpan">Default sample pan position. This is a value from 0 to 255 or FSOUND_STEREOPAN.</param>
        /// <param name="defpri">Default sample priority. This is a value from 0 to 255. -1 to ignore.</param>
        /// <param name="varfreq">Frequency variation in hz to apply to deffreq each time this sample is played. -1 to ignore.</param>
        /// <param name="varvol">Volume variation to apply to defvol each time this sample is played. -1 to ignore.</param>
        /// <param name="varpan">Pan variation to apply to defpan each time this sample is played. -1 to ignore.</param>
        /// <returns>On success, TRUE is returned. On failure, FALSE is returned.</returns>
        [DllImport("fmod.dll")]
        public static extern bool FSOUND_Sample_SetDefaultsEx(IntPtr FSOUND_SAMPLE, int deffreq, int defvol, int defpan, int defpri, int varfreq, int varvol, int varpan);


        /// <summary>
        /// Sets the maximum number of times a sample can play back at once.
        /// </summary>
        /// <param name="FSOUND_SAMPLE">Pointer to the sample to have its playback behaviour changed.</param>
        /// <param name="max">Maximum number of times a sample can play back at once.</param>
        /// <returns>On success, TRUE is returned. On failure, FALSE is returned.</returns>
        [DllImport("fmod.dll")]
        public static extern bool FSOUND_Sample_SetMaxPlaybacks(IntPtr FSOUND_SAMPLE, int max);


        /// <summary>
        /// Sets the minimum and maximum audible distance for a sample.
        /// MinDistance is the minimum distance that the sound emitter will cease to continue growing 
        /// louder at (as it approaches the listener). Within the mindistance it stays at the constant loudest volume possible. Outside of this mindistance it begins to attenuate.
        /// MaxDistance is the distance a sound stops attenuating at. Beyond this point it will stay at the volume it would be at maxdistance units from the listener and will not attenuate any more.
        /// MinDistance is useful to give the impression that the sound is loud or soft in 3d space. An example of this is a small quiet object, such as a bumblebee, which you could set a mindistance of to 0.1 for example, which would cause it to attenuate quickly and dissapear when only a few meters away from the listener.
        /// Another example is a jumbo jet, which you could set to a mindistance of 100.0, which would keep the sound volume at max until the listener was 100 meters away, then it would be hundreds of meters more before it would fade out.
        /// </summary>
        /// <param name="FSOUND_SAMPLE">The sample to have its minimum and maximum distance set.</param>
        /// <param name="F_FLOAT_API_min">The samples minimum volume distance in "units". See remarks for more on units.</param>
        /// <param name="F_FLOAT_API_max">The samples maximum volume distance in "units". See remarks for more on units.</param>
        /// <returns>On success, TRUE is returned. On failure, FALSE is returned.</returns>
        [DllImport("fmod.dll")]
        public static extern bool FSOUND_Sample_SetMinMaxDistance(IntPtr FSOUND_SAMPLE, float F_FLOAT_API_min, float F_FLOAT_API_max);


        /// <summary>
        /// Sets a sample's mode. This can only be FSOUND_LOOP_OFF,FSOUND_LOOP_NORMAL, FSOUND_LOOP_BIDI or FSOUND_2D.
        /// You cannot change the description of the contents of a sample or its location. FSOUND_2D will be ignored on the Win32 platform if FSOUND_HW3D was used to create the sample.
        /// </summary>
        /// <param name="FSOUND_SAMPLE">Pointer to the sample to have the mode set.</param>
        /// <param name="mode">The mode bits to set from FSOUND_MODES.</param>
        /// <returns>On success, TRUE is returned. On failure, FALSE is returned.</returns>
        [DllImport("fmod.dll")]
        public static extern bool FSOUND_Sample_SetMode(IntPtr FSOUND_SAMPLE, FSOUND_MODES mode);


        /// <summary>
        /// Sets a sample's loop points, specified in SAMPLES, not bytes.
        /// </summary>
        /// <param name="FSOUND_SAMPLE">Pointer to the sample to have its loop points set.</param>
        /// <param name="loopstart">The starting position of the sample loop </param>
        /// <param name="loopend">The end position of the sample loop</param>
        /// <returns>On success, TRUE is returned. On failure, FALSE is returned.</returns>
        [DllImport("fmod.dll")]
        public static extern bool FSOUND_Sample_SetLoopPoints(IntPtr FSOUND_SAMPLE, int loopstart, int loopend);


        /// <summary>
        /// Releases previous sample data lock from FSOUND_Sample_Lock
        /// </summary>
        /// <param name="FSOUND_SAMPLE">Pointer to the sample definition.</param>
        /// <param name="ptr1">Pointer to the 1st locked portion of sample data, from FSOUND_Sample_Lock.</param>
        /// <param name="ptr2">Pointer to the 2nd locked portion of sample data, from FSOUND_Sample_Lock.</param>
        /// <param name="len1">Length of data in BYTES that was locked for ptr1</param>
        /// <param name="len2">Length of data in BYTES that was locked for ptr2. This will be 0 if the data locked hasnt wrapped at the end of the buffer.</param>
        /// <returns>On success, TRUE is returned. On failure, FALSE is returned.</returns>
        [DllImport("fmod.dll")]
        public static extern bool FSOUND_Sample_Unlock(IntPtr FSOUND_SAMPLE, IntPtr ptr1, IntPtr ptr2, uint len1, uint len2);


        /// <summary>
        /// This function uploads new sound data from memory to a preallocated/existing sample and does conversion based on the specified source mode. If sample data already exists at this handle then it is replaced with the new data being uploaded.
        /// </summary>
        /// <param name="FSOUND_SAMPLE">Pointer to the destination sample</param>
        /// <param name="srcdata">Pointer to the source data to be uploaded. On PlayStation 2 this is an IOP address not an EE address.</param>
        /// <param name="mode_in">Description of the source data format. Bitwise OR in these bits to describe the data being passed in.
        /// See FSOUND_MODES for valid parameters and descriptions.
        /// FSOUND_HW3D, FSOUND_HW2D and FSOUND_LOOP modes are ignored, the mode describes the source format, not the destination format.</param>
        /// <returns>On success, TRUE is returned. On failure, FALSE is returned.</returns>
        [DllImport("fmod.dll")]
        public static extern bool FSOUND_Sample_Upload(IntPtr FSOUND_SAMPLE, ref IntPtr srcdata, FSOUND_MODES mode_in);


        [DllImport("fmod.dll")]
        public static extern IntPtr FSOUND_Stream_AddSyncPoint(ref IntPtr FSOUND_STREAM_stream, uint pcmoffset, string name);


        [DllImport("fmod.dll")]
        public static extern bool FSOUND_Stream_Close(IntPtr FSOUND_STREAM_stream);


        [DllImport("fmod.dll")]
        public static extern IntPtr FSOUND_Stream_Create(IntPtr FSOUND_STREAMCALLBACK_callback, int lenbytes, FSOUND_MODES mode, int samplerate, IntPtr userdata);


        [DllImport("fmod.dll")]
        public static extern IntPtr FSOUND_Stream_CreateDSP(IntPtr FSOUND_STREAM_stream, IntPtr FSOUND_DSPCALLBACK_callback, int priority, IntPtr userdata);


        [DllImport("fmod.dll")]
        public static extern bool FSOUND_Stream_DeleteSyncPoint(IntPtr FSOUND_SYNCPOINT_point);


        [DllImport("fmod.dll")]
        public static extern bool FSOUND_Stream_FindTagField(IntPtr FSOUND_STREAM_stream, FSOUND_TAGFIELD_TYPE type, string name, ref IntPtr value, ref int length);


        [DllImport("fmod.dll")]
        public static extern int FSOUND_Stream_GetLength(IntPtr FSOUND_STREAM_stream);


        [DllImport("fmod.dll")]
        public static extern int FSOUND_Stream_GetLengthMs(IntPtr FSOUND_STREAM_stream);


        [DllImport("fmod.dll")]
        public static extern uint FSOUND_Stream_GetMode(IntPtr FSOUND_STREAM_stream);


        [DllImport("fmod.dll")]
        public static extern int FSOUND_Stream_GetNumSubStreams(IntPtr FSOUND_STREAM_stream);


        [DllImport("fmod.dll")]
        public static extern int FSOUND_Stream_GetNumSyncPoints(IntPtr FSOUND_STREAM_stream);


        [DllImport("fmod.dll")]
        public static extern bool FSOUND_Stream_GetNumTagFields(IntPtr FSOUND_STREAM_stream, ref int num);


        [DllImport("fmod.dll")]
        public static extern int FSOUND_Stream_GetOpenState(IntPtr FSOUND_STREAM_stream);


        [DllImport("fmod.dll")]
        public static extern uint FSOUND_Stream_GetPosition(IntPtr FSOUND_STREAM_stream);


        [DllImport("fmod.dll")]
        public static extern IntPtr FSOUND_Stream_GetSample(IntPtr FSOUND_STREAM_stream);


        [DllImport("fmod.dll")]
        public static extern IntPtr FSOUND_Stream_GetSyncPoint(IntPtr FSOUND_STREAM_stream, int index);


        [DllImport("fmod.dll")]
        public static extern string FSOUND_Stream_GetSyncPointInfo(IntPtr FSOUND_SYNCPOINT_point, ref uint pcmoffset);


        [DllImport("fmod.dll")]
        public static extern bool FSOUND_Stream_GetTagField(IntPtr FSOUND_STREAM_stream, int num, ref FSOUND_TAGFIELD_TYPE type, ref string name, IntPtr val, ref int length);


        [DllImport("fmod.dll")]
        public static extern int FSOUND_Stream_GetTime(IntPtr FSOUND_STREAM_stream);


        [DllImport("fmod.dll")]
        public static extern bool FSOUND_Stream_Net_GetBufferProperties(ref int buffersize, ref int prebuffer_percent, ref int rebuffer_percent);


        [DllImport("fmod.dll")]
        public static extern string FSOUND_Stream_Net_GetLastServerStatus();


        [DllImport("fmod.dll")]
        public static extern bool FSOUND_Stream_Net_GetStatus(IntPtr FSOUND_STREAM_stream, ref FSOUND_STREAM_NET_STATUS status, ref int bufferused, ref int bitrate, ref FSOUND_STATUS_FLAGS flags);


        [DllImport("fmod.dll")]
        public static extern bool FSOUND_Stream_Net_SetBufferProperties(int buffersize, int prebuffer_percent, int rebuffer_percent);


        [DllImport("fmod.dll")]
        public static extern bool FSOUND_Stream_Net_SetMetadataCallback(IntPtr FSOUND_STREAM_stream, IntPtr FSOUND_METADATACALLBACK_callback, IntPtr userdata);


        [DllImport("fmod.dll")]
        public static extern bool FSOUND_Stream_Net_SetProxy(string proxy);


        [DllImport("fmod.dll")]
        public static extern IntPtr FSOUND_Stream_Open(IntPtr name_or_data, uint mode, int offset, int length);


        [DllImport("fmod.dll")]
        public static extern int FSOUND_Stream_Play(int channel, IntPtr FSOUND_STREAM_stream);


        [DllImport("fmod.dll")]
        public static extern int FSOUND_Stream_PlayEx(int channel, IntPtr FSOUND_STREAM_stream, IntPtr FSOUND_DSPUNIT_dspunit, bool paused);


        [DllImport("fmod.dll")]
        public static extern bool FSOUND_Stream_SetBufferSize(int ms);


        [DllImport("fmod.dll")]
        public static extern bool FSOUND_Stream_SetEndCallback(IntPtr FSOUND_STREAM_stream, IntPtr FSOUND_STREAMCALLBACK_callback, IntPtr userdata);


        [DllImport("fmod.dll")]
        public static extern bool FSOUND_Stream_SetLoopCount(IntPtr FSOUND_STREAM_stream, int count);


        [DllImport("fmod.dll")]
        public static extern bool FSOUND_Stream_SetLoopPoints(IntPtr FSOUND_STREAM_stream, uint loopstart, uint loopend);


        [DllImport("fmod.dll")]
        public static extern bool FSOUND_Stream_SetMode(IntPtr FSOUND_STREAM_stream, FSOUND_MODES mode);


        [DllImport("fmod.dll")]
        public static extern bool FSOUND_Stream_SetPosition(IntPtr FSOUND_STREAM_stream, uint position);


        [DllImport("fmod.dll")]
        public static extern bool FSOUND_Stream_SetSubStream(IntPtr FSOUND_STREAM_stream, int index);


        [DllImport("fmod.dll")]
        public static extern bool FSOUND_Stream_SetSubStreamSentence(IntPtr FSOUND_STREAM_stream, ref int sentencelist, int numitems);


        [DllImport("fmod.dll")]
        public static extern bool FSOUND_Stream_SetSyncCallback(IntPtr FSOUND_STREAM_stream, IntPtr FSOUND_STREAMCALLBACK_callback, IntPtr userdata);


        [DllImport("fmod.dll")]
        public static extern bool FSOUND_Stream_SetTime(IntPtr FSOUND_STREAM_stream, int ms);


        [DllImport("fmod.dll")]
        public static extern bool FSOUND_Stream_Stop(IntPtr FSOUND_STREAM_stream);


        [DllImport("fmod.dll")]
        public static extern bool FSOUND_SetPanSeperation(int pansep);


        /// <summary>
        /// Sets the master volume for any sound effects played. Does not affect music or CD output.
        /// </summary>
        /// <param name="volume"> The volume to set. Valid ranges are from 0 (silent) to 255 (full volume)</param>
        /// <returns>On success, TRUE is returned. On failure, FALSE is returned.</returns>
        [DllImport("fmod.dll")]
        public static extern bool FSOUND_SetSFXMasterVolume(int volume);


        /// <summary>
        /// Sets the mode for the users speaker setup.
        /// </summary>
        /// <param name="speakermode">This is an enum describing the users speaker setup.</param>
        [DllImport("fmod.dll")]
        public static extern void FSOUND_SetSpeakerMode(FSOUND_SPEAKERMODES speakermode);


        /// <summary>
        /// This updates the 3d sound engine and DMA engine (only on some platforms), and should be called once a game frame.
        /// This function will also update the software mixer if you have selected FSOUND_OUTPUT_NOSOUND_NONREALTIME as your output mode.
        /// </summary>
        [DllImport("fmod.dll")]
        public static extern void FSOUND_Update();







    }
}
