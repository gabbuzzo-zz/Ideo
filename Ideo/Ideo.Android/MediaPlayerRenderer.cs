using Android.App;
using Android.Content;
using Android.Content.Res;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Util;
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
    public class MediaPlayerRenderer : ViewRenderer<MediaPlayer, LinearLayout>, IVisualElementRenderer, IViewRenderer, ISurfaceHolderCallback, IMediaPlayer
    {
        VideoView media;
        LinearLayout linear;
        MediaPlayer mediaPlayer;
        //MediaPlayer mediaPlayer;
        Android.Media.MediaPlayer mediaPlayerD;

        //string fileName;

        public void GetPlayFromFileName(string fileName, bool? isLooping)
        {
            PlayVideo(fileName, false);
        }
        private void PlayVideo(string fileName, bool? isLooping)
        {
            SurfaceView surfaceView = new SurfaceView(this.Context);
            ISurfaceHolder holder = media.Holder;
            holder.SetType(SurfaceType.PushBuffers);
            holder.AddCallback(this);
            string package = Context.PackageName;
            AssetManager assets = this.Context.Assets;
            var d = assets.OpenFd(fileName);
            mediaPlayerD.Looping = isLooping.Value;
            mediaPlayerD.SetDataSource(d.FileDescriptor, d.StartOffset, d.Length);
            mediaPlayerD.Prepare();
            media.SetMediaController(new MediaController(this.Context));
            ResizeVideoView();
            mediaPlayerD.Start();
            //int w = Context.Display.Width;
            //int h = Context.Display.Height;
            //holder.Surface.SetSize(w,h);
            Android.Content.Res.AssetFileDescriptor afd = this.Context.Assets.OpenFd(fileName);
            media.Start();
            SetNativeControl(linear);

        }

        private void ResizeVideoView()
        {
            //DisplayMetrics mDisplayMetrics = new DisplayMetrics();
            //Display display = Context.ApplicationContext.Display;
            //display.GetRealMetrics(mDisplayMetrics);
            //Context.ApplicationContext.Display.GetRealMetrics(mDisplayMetrics);
            int videoWidth = mediaPlayerD.VideoWidth;
            int videoHeight = mediaPlayerD.VideoHeight;
            int videoProportion = (int)videoWidth / (int)videoHeight;
            int screenWidth = Context.Display.Width;
            int screenHeight = Context.Display.Height;
            int screenProportion = (int)screenWidth / (int)screenHeight;
            ViewGroup.LayoutParams lp = media.LayoutParameters;
            if (videoProportion > screenProportion)
            {
                lp.Width = screenWidth;
                lp.Height = (int)((float)screenWidth / videoProportion);
            }
            else
            {
                lp.Width = (int)(videoProportion * (float)screenHeight);
                lp.Height = screenHeight;
            }
            media.LayoutParameters = lp;
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
                mediaPlayer = e.NewElement as MediaPlayer;
                media = new VideoView(Context);
                mediaPlayerD = new Android.Media.MediaPlayer();
                var f = e.NewElement as MediaPlayer;
                linear = new LinearLayout(this.Context);
                if (f.AspectMediaPlayer == MediaPlayer.Aspect.Fill)
                {
                    int screenWidth = ((Activity)Context).WindowManager.DefaultDisplay.Width;
                    int screenHeight = ((Activity)Context).WindowManager.DefaultDisplay.Height;
                    Android.Views.ViewGroup.LayoutParams videoParams = GenerateDefaultLayoutParams();
                    LayoutParams paramsT = new LayoutParams(ViewGroup.LayoutParams.WrapContent,ViewGroup.LayoutParams.WrapContent);
                    linear.AddView(media, paramsT);
                }
                PlayVideo(e.NewElement.FileName, e.NewElement.Looping);
            }
        }

    }

}