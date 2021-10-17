using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xamarin.Forms;

namespace Ideo.Controls
{

    public class TitleLabelAnimated : StackLayout
    {
        public string Title { get { return (string)GetValue(TitleProperty); } set { SetValue(TitleProperty, value); } }
        private readonly BindableProperty TitleProperty =
            BindableProperty.Create("Title", typeof(string), typeof(TitleLabelAnimated), "Ideo", BindingMode.Default);

        public TitleLabelAnimated()
        {
            this.HorizontalOptions = LayoutOptions.CenterAndExpand;
            this.VerticalOptions = LayoutOptions.CenterAndExpand;
            this.Orientation = StackOrientation.Horizontal;
            if (String.IsNullOrEmpty(Title))
            {
                //Title = "Ideo";
            }
            else
            {
                Animate(Title);
            }
        }

        private async void Animate(string title)
        {
            char[] charsRead = new char[Title.Length];
            List<Label> labels = new List<Label>();
            using (StringReader reader = new StringReader(Title))
            {
                await reader.ReadAsync(charsRead, 0, Title.Length);
            }

            StringBuilder reformattedText = new StringBuilder();
            using (StringWriter writer = new StringWriter(reformattedText))
            {
                foreach (char c in charsRead)
                {
                    if (char.IsLetter(c) || char.IsWhiteSpace(c))
                    {
                        await writer.WriteLineAsync(char.ToLower(c));
                    }
                }
            }
            foreach (var i in charsRead)
            {
                Label c = new Label() { Text = i.ToString(),FontSize=40,FontAttributes=FontAttributes.Bold };
                 new Animation() {
                            { 0, 0.50, new Animation (v => c.TranslationY = v, 0, -70,easing:Easing.BounceIn) },
                            { 0.50, 1, new Animation (v => c.TranslationY = v, -70, 0, easing: Easing.BounceOut) }
                                }.Commit(this, "TitleBouncing", length: 1500, repeat: () => true);
                this.Children.Add(c);
                labels.Add(c);
            }

        }
    }
}
