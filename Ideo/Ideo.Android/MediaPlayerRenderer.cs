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

[assembly: ExportRenderer(typeof(MediaPlayer), typeof(MediaPlayerRenderer))]
namespace Ideo.Droid
{
    [Obsolete]
    public class MediaPlayerRenderer : ViewRenderer<MediaPlayer, VideoView>, IVisualElementRenderer, IViewRenderer, ISurfaceHolderCallback
    {
        VideoView media;
        MediaPlayer mediaPlayer;
        Android.Media.MediaPlayer mediaPlayerD;

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
                //if (Control == null)
                //{
                //    mediaPlayer = MediaPlayer.crea(this.Context);
                //    //media.SetVideoPath("/Resources/raw/teamwork2.mp4");
                //    SetNativeControl(mediaPlayer);
                //var uri = Android.Net.Uri.Parse("https://www.youtube.com/watch?v=DIV3qg0PmOQ");
                //    //var uri = Android.Net.Uri.Parse("android.resource://" + Application.PackageName + "/" + Resource.Raw.demo);
                //    //media.SetVideoURI(uri);
                //    mediaPlayer.Start();
                //}
                //Button button = FindViewById<Button>(Resource.Id.MyButton);
                //button.Click += delegate {
                //    player.Start();
                //};
                //var videoView = FindViewById<VideoView>(Resource.Id.videoView1);
                //var uri = Android.Net.Uri.Parse("/Resources/raw/teamwork2.mp4");
                media = new VideoView(Context);
                ISurfaceHolder holder = media.Holder;
                holder.SetType(SurfaceType.PushBuffers);
                holder.AddCallback(this);
                mediaPlayerD = new Android.Media.MediaPlayer();
                mediaPlayerD = Android.Media.MediaPlayer.Create(Context, (int)Resource.Raw.teamwork1);
                //mediaPlayerD.Prepare();
                string package = Context.PackageName;
                //string path = (Element.Source as ResourceVideoSource).Path;
                //var uri = Android.Net.Uri.Parse("android.resource://" + package + "/Resources/raw/teamwork2.mp4");
                //Assets.Open("my_asset.txt");/* mediaPlayerD.SetDataSource(Context,video );*/
                AssetManager assets=this.Context.Assets;
                var d=assets.OpenFd("teamwork1.mp4");
                mediaPlayerD.SetDataSource(d.FileDescriptor, d.StartOffset, d.Length);
                mediaPlayerD.Prepare();
                mediaPlayerD.Start();
                Android.Content.Res.AssetFileDescriptor afd = this.Context.Assets.OpenFd("teamwork1.mp4");
                //media.SetVideoPath(afd.);
                //media.SetVideoURI(assets.d.FileDescriptor, d.StartOffset, d.Length);
                media.Start();
                SetNativeControl(media);
            }
        }

    }

}