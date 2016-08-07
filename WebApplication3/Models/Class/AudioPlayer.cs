using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace WebApplication3
{
    public class AudioPlayer : Volume,ITrec
    {
        Music directioMusic;
        public AudioPlayer(string name, int volume, Music Music, bool status) : base(name, volume, status)
        {
            directioMusic = Music;
        }

        public string GetTrec
        {
            get
            {                
                return directioMusic.ToString();
            }

        }

        public string NextTrec
        {
            get
            {
                if (directioMusic == Music.trec00)
                {
                    directioMusic = Music.trec1;
                }
                else if (directioMusic == Music.trec0)
                {
                    directioMusic = Music.trec9;
                }
                else { directioMusic++; }
                return directioMusic.ToString();
            }
            
        }

        public string PreviousTrec
        {
            get
            {
                if (directioMusic == Music.trec00)
                {
                    directioMusic = Music.trec1;
                }
                else if (directioMusic == Music.trec0)
                {
                    directioMusic = Music.trec9;
                }
                else { directioMusic--; }
                return directioMusic.ToString();
            }

        }
    }
}