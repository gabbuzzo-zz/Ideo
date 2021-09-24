using System;
using System.Collections.Generic;
using System.Text;

namespace Ideo
{
   public interface IMediaPlayer
    {
        void GetPlayFromFileName(string fileName,bool? isLooping);
    }
}
