using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ideo.Controls
{
    public class MediaPlayer:View
    {
        public string FileName { get { return (string)GetValue(FileNameProperty); } set { SetValue(FileNameProperty, value); } }
        public bool Looping { get { return (bool)GetValue(LoopingProperty); } set { SetValue(LoopingProperty, value); } }
        public Aspect AspectMediaPlayer { get { return (Aspect)GetValue(AspectProperty); } set { SetValue(AspectProperty, value); } }
        public enum Aspect { Fill,NoAspectFill}
        public BindableProperty FileNameProperty = BindableProperty.Create("FileName", typeof(string),typeof(MediaPlayer), defaultBindingMode: BindingMode.TwoWay);
        public BindableProperty LoopingProperty = BindableProperty.Create("Looping", typeof(bool),typeof(MediaPlayer), defaultBindingMode: BindingMode.TwoWay,defaultValue:true);
        public BindableProperty AspectProperty = BindableProperty.Create("AspectMediaPlayer", typeof(int),typeof(MediaPlayer), defaultBindingMode: BindingMode.TwoWay,defaultValue:1);
        public bool Play()
        {
            if (String.IsNullOrEmpty(FileName)) 
            { 
            DependencyService.Get<IMediaPlayer>().GetPlayFromFileName(FileName,Looping);
            return true;
            }
            else
            {
                return false;
            }
        }
        public void Pause()
        {

        }
    }
}
