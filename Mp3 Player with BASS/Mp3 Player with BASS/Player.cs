using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Un4seen.Bass;

namespace Mp3_Player_with_BASS
{
    class Player
    {
        int stream;
        bool playing, paused;
        public Player()
        {
            Bass.BASS_Init(-1, 44100, BASSInit.BASS_DEVICE_DEFAULT, System.IntPtr.Zero);
            
            playing = false;
            paused = false;
        }
        #region accessors
        public bool Playing
        {
            set { playing = value; }
            get { return playing; }
        }
        public bool Paused
        {
            set { paused = value; }
            get { return paused; }
        }
        public int Stream
        {
            get { return stream; }
        }

        #endregion
        #region methods
        public void LoadSong(string location)
        {
            stream = Bass.BASS_StreamCreateFile(location, 0, 0, BASSFlag.BASS_SAMPLE_FLOAT);
            
        }

        public void PlaySong()
        {
            
            Bass.BASS_ChannelPlay(stream,false);
            SetVolume(0);
            SetVolume(100);
        }

        public void StopSong()
        {
            Bass.BASS_ChannelStop(stream);
        }

        public void PauseSong()
        {
            Bass.BASS_ChannelPause(stream);
        }
        public void SeekSong(double seconds)
        {
            Bass.BASS_ChannelSetPosition(stream, Bass.BASS_ChannelSeconds2Bytes(stream, seconds));
           
        }
        public int CurrentPossition()
        {
            return  (int)Bass.BASS_ChannelBytes2Seconds(stream,Bass.BASS_ChannelGetPosition(stream));
        }
        
        public void SetVolume(float value)
        {
            Bass.BASS_ChannelSetAttribute(stream, BASSAttribute.BASS_ATTRIB_VOL, value/100);
        }
        public void SetBalance(float value)
        {
            Bass.BASS_ChannelSetAttribute(stream, BASSAttribute.BASS_ATTRIB_PAN, value / 100);
        }
        public void Mute(bool trigger,float volume)
        {
            
            if (trigger==true)
            {
         
                Bass.BASS_ChannelSetAttribute(stream, BASSAttribute.BASS_ATTRIB_VOL, volume);
                
            }
            else
            {
                Bass.BASS_ChannelSetAttribute(stream, BASSAttribute.BASS_ATTRIB_VOL, volume/100);
            }

        }
        ~Player()
        {
            Bass.BASS_Free();
        }
        #endregion 
    }
}
