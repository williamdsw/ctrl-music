using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Resources;

namespace CTRLMusic
{
    class Som
    {
        public void Chimes()
        {
            SystemSounds.Asterisk.Play();
        }

        public void Chord()
        {
            SystemSounds.Hand.Play();
        }

        public void Tada()
        {
            SystemSounds.Beep.Play();
        }

        public SoundPlayer LogOn()
        {
            SoundPlayer logon = new SoundPlayer(CTRLMusic.Properties.Resources._10_SOM_tandantantentan);

            logon.Play();

            return logon;
        }
        
        public void Notify()
        {
            SystemSounds.Exclamation.Play();
        }
    }
}
