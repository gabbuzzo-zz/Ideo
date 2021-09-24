using Android.App;
using Android.Content;
using Android.Content.Res;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Ideo.Controls;
using Ideo.Droid;
using Java.IO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms.Platform.Android.FastRenderers;

#pragma warning disable CS0612 // Il tipo o il membro è obsoleto
[assembly: ExportRenderer(typeof(MediaPlayer), typeof(MediaPlayerRenderer))]
#pragma warning restore CS0612 // Il tipo o il membro è obsoleto
namespace Ideo.Droid
{
    [Obsolete]
    public class MediaPlayerRenderer : ViewRenderer<MediaPlayer, VideoView>, IVisualElementRenderer, IViewRenderer, ISurfaceHolderCallback, IMediaPlayer
    {
        VideoView media;
        //MediaPlayer mediaPlayer;
        Android.Media.MediaPlayer mediaPlayerD;
        //string fileName;

        public void GetPlayFromFileName(string fileName,bool? isLooping)
        {
            PlayVideo(fileName,false);
        }
        private void PlayVideo(string fileName,bool? isLooping)
        {
            media = new VideoView(Context);
            ISurfaceHolder holder = media.Holder;
            holder.SetType(SurfaceType.PushBuffers);
            holder.AddCallback(this);
            mediaPlayerD = new Android.Media.MediaPlayer();
            string package = Context.PackageName;
            AssetManager assets = this.Context.Assets;
            var d = assets.OpenFd(fileName);
            mediaPlayerD.Looping = isLooping.Value;
            mediaPlayerD.SetDataSource(d.FileDescriptor, d.StartOffset, d.Length);
            mediaPlayerD.Prepare();
            mediaPlayerD.Start();
            //int w = Context.Display.Width;
            //int h = Context.Display.Height;
            //holder.Surface.SetSize(w,h);
            Android.Content.Res.AssetFileDescriptor afd = this.Context.Assets.OpenFd(fileName);
            media.Start();
            SetNativeControl(media);

        }
        public void SurfaceChanged(ISurfaceHolder holder, [GeneratedEnum] Format format, int width, int height)
        {
        }

        public void SurfaceCreated(ISurfaceHolder holder)
        {
            mediaPlayerD.SetDisplay(holder);
        }

        public void SurfaceDestroyed(ISurfaceHolder holder)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<MediaPlayer> e)
        {
            base.OnElementChanged(e);
            if (e.OldElement != null)
            {
                return;
                //media.E += Media_AnimationEnd;
            }
            if (e.NewElement != null)
            {
                PlayVideo(e.NewElement.FileName,e.NewElement.Looping);
            }
        }

    }

}