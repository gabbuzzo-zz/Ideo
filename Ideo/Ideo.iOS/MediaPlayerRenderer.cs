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
        AVFoundation.AVPlayer player;



        protected override void OnElementChanged(ElementChangedEventArgs<Controls.MediaPlayer> e)
        {
            base.OnElementChanged(e);
            if (e.OldElement != null)
            {

            }
            if (e.NewElement != null)
            {
                view = new UIView();
                var path = NSBundle.MainBundle.PathForResource("teamwork1", "mp4");
                var playerController = new AVPlayerViewController();
                NSUrl url = NSUrl.FromString(path);
                player = new AVPlayer(url);
                playerController.Player = player;
                //player.Play();
                //view.AddSubview(playerController.View);
                //playerController.View.Frame = view.Frame;
                playerController.ShowsPlaybackControls = false;
                var playerLayer = AVPlayerLayer.FromPlayer(player);
                playerLayer.Frame = playerController.View.Frame;
                CGRect rect = new CGRect(10, 10, 200, 200);
                playerController.View.Frame = rect;
                view.AddSubview(playerController.View);
                view.ClipsToBounds = true;
                player.Play();
                //this.view.Layer.AddSublayer(playerLayer);
                SetNativeControl(view);

            }
        }
    }
}