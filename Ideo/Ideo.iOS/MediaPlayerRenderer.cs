using Foundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIKit;
//using Xamarin.Forms;
using Ideo.iOS;
using Ideo.Controls;
using Xamarin.Forms.Platform.iOS;
using AVFoundation;
using Xamarin.Forms;
using AVKit;
using System.IO;
using CoreAnimation;
using System.ComponentModel;
using CoreGraphics;

[assembly: ExportRenderer(typeof(Ideo.Controls.MediaPlayer), typeof(MediaPlayerRenderer))]

namespace Ideo.iOS
{
    public class MediaPlayerRenderer : ViewRenderer<Controls.MediaPlayer, UIView>
    {
        UIView view;
        AVFoundation.AVPlayer avp;
        AVPlayerViewController avpvc;
        protected override void OnElementChanged(ElementChangedEventArgs<Controls.MediaPlayer> e)
        {
            base.OnElementChanged(e);
            if (e.OldElement != null)
            {

            }
            if (e.NewElement != null)
            {
                List<string> stringDir = new List<string>();
                view = new UIView();
                var directories = Directory.GetCurrentDirectory()+"/Resources/teamwork1.mp4";
                
                
                //foreach (var directory in directories)
                //{
                //    Console.WriteLine(directory);
                //    //stringDir.Add(directory);
                //}
                
                NSUrl file = NSUrl.FromString("https://www.youtube.com/watch?v=PilNQ2TkwGw");
                var apc = NSBundle.MainBundle.GetUrlForResource("teamwork1", "mp4");
                var path = NSBundle.MainBundle.PathForResource("teamwork1", "mp4");
                var url2 = NSBundle.MainBundle.GetUrlForResource("teamwork1", "mp4");
                var fileS = File.Exists(path);
                avp = new AVPlayer(NSUrl.FromString(path));
                var coder = new NSCoder();
                avpvc = new AVPlayerViewController();
                avpvc.Player =new AVPlayer(NSUrl.FromString(path));
                avpvc.ShowsPlaybackControls = false;
                var plLayer = new AVPlayerLayer() { Player = avp };
                plLayer.Frame = this.NativeView.Bounds;
                var duration = avp.CurrentItem.Duration;
                this.view.Layer.AddSublayer(plLayer);
                //view.Add();
                //playerLayer!.frame = self.view!.bounds
                //self.view!.layer.addSublayer(playerLayer!)
                avp.Play();
                avpvc.Player.Play();
                    SetNativeControl(avpvc.View);

            }
        }
    }
}